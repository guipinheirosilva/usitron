using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;

namespace Evolucao
{
    public partial class form_saidas_estoque : Form
    {
        double qtde_estoque;
        double qtde_saida;

        public bool extorno = false;
        public bool saidas_conjuntas;
        public string operador;
        

        bool erro_ao_retirar;

        public string cnpj_empresa;
        public form_saidas_estoque(string cnpj_empresa)
        {
            this.cnpj_empresa = cnpj_empresa;
            InitializeComponent();
        }

        private void bt_localizar_item_Click(object sender, EventArgs e)
        {
            
            form_busca_item_estoque_mp localiza_item = new form_busca_item_estoque_mp(cnpj_empresa);
            try
            {
                localiza_item.ShowDialog();
            }
            finally
            {
                localiza_item.Dispose();
                localizar(localiza_item.cod_escolhido);
            }
        }

        private void localizar(string cod_item)
        {
                try
                {
                    FbCommand select = new FbCommand();
                    select.Connection = fbConnection1;
                    fbConnection1.Open();
                    select.CommandText =
                    "SELECT COD_ESTOQUE, ITEM_ESTOQUE, DESCRICAO_ESTOQUE, ESTOQUE_ATUAL_ESTOQUE FROM ESTOQUE WHERE COD_ESTOQUE = '" + cod_item + "'";
                    datEstoque.SelectCommand = select;
                    DataSet estoqueDataSet = new DataSet();
                    datEstoque.Fill(estoqueDataSet);
                    fbConnection1.Close();
                    foreach (DataRow dr in estoqueDataSet.Tables[0].Rows)
                    {
                        tb_cod_item.Text = dr[0].ToString();
                        tb_item_item.Text = dr[1].ToString();
                        tb_descricao_item.Text = dr[2].ToString();
                        tb_qtde_item.Text = dr[3].ToString();
                        tb_qtde_saida.Focus();
                    }
                }
                catch(Exception a)
                {
                    fbConnection1.Close();
                    MessageBox.Show(a.ToString());
                }
        }

        private void bt_adicionar_item_Click(object sender, EventArgs e)
        {
            remover("","");
        }

        private void remover(string lote, string palete)
        {
            if (tb_qtde_saida.Text == "" || tb_cracha.Text == "")
            {
                MessageBox.Show("Coloque os campos obrigatórios por favor (Quantidade e Cracha)");
            }
            else
            {
                bool erro = false; 
                
                try
                {
                    qtde_estoque = Convert.ToDouble(tb_qtde_item.Text);
                    qtde_saida = Convert.ToDouble(tb_qtde_saida.Text);
                    if (extorno)
                    {
                        qtde_saida = qtde_saida * -1;
                        tb_qtde_saida.Text = qtde_saida.ToString();
                    }
                }
                catch {
                    erro = true;
                }
                if (erro == true)
                {
                    MessageBox.Show("Não é possível dar essa saída");
                }
                else
                {
                    inserir_saida(lote, palete);
                    localizar_itens();

                    classeEstoque_material est = new classeEstoque_material();
                    est.fbConnection1.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=True;Packet Size=8192;Server Type=0";
                    est.calcular_estoque(tb_cod_item.Text);
                    /*
                    if (qtde_saida <= qtde_estoque)
                    {
                        
                    }
                    else
                    {
                        MessageBox.Show("Não existe estoque suficiente");
                    }*/
                }
                dsEstoque.Clear();
                
                qtde_estoque = 0;
                qtde_saida = 0;
            }
        }

        private void calcular_estoque(string cod_estoque)
        {
            try
            {
                //puxando todas as entradas desse item
                FbCommand select_entradas = new FbCommand();
                select_entradas.Connection = fbConnection1;
                fbConnection1.Open();
                select_entradas.CommandText =
                    "SELECT QTDE_ITEM_ENT FROM ITENS_NOTA_ENT WHERE COD_ITEM_EST_ITEM_ENT = '" + cod_estoque + "'";
                FbDataAdapter entradasDataAdapter = new FbDataAdapter();
                entradasDataAdapter.SelectCommand = select_entradas;
                DataSet entradasDataSet = new DataSet();
                entradasDataAdapter.Fill(entradasDataSet);
                fbConnection1.Close();
                double entradas = 0;
                foreach (DataRow dr in entradasDataSet.Tables[0].Rows)
                {
                    try
                    {
                        entradas = entradas + Convert.ToDouble(dr[0].ToString());
                    }
                    catch { }
                }
                //buscar saidas
                FbCommand select_saidas = new FbCommand();
                select_saidas.Connection = fbConnection1;
                fbConnection1.Open();
                select_saidas.CommandText =
                    "SELECT QTDE_ESTOQUE_SAIDA FROM ESTOQUE_SAIDA WHERE COD_ITEM_ESTOQUE_SAIDA = '" + cod_estoque + "'";
                FbDataAdapter saidasDataAdapter = new FbDataAdapter();
                saidasDataAdapter.SelectCommand = select_saidas;
                DataSet saidasDataSet = new DataSet();
                saidasDataAdapter.Fill(saidasDataSet);
                fbConnection1.Close();
                double saidas = 0;
                foreach (DataRow dr_saidas in saidasDataSet.Tables[0].Rows)
                {
                    try
                    {
                        saidas = saidas + Convert.ToDouble(dr_saidas[0].ToString());
                    }
                    catch { }
                }
                double saldo = 0;
                try
                {
                    saldo = entradas - saidas;
                }
                catch { }
                //update estoque
                FbCommand update = new FbCommand();
                update.Connection = fbConnection1;
                fbConnection1.Open();
                update.CommandText =
                    "UPDATE ESTOQUE SET ESTOQUE_ATUAL_ESTOQUE = '" + saldo.ToString().Replace(".","").Replace(",",".") + "' WHERE COD_ESTOQUE = '" + cod_estoque + "'";
                FbDataAdapter datEstoque = new FbDataAdapter();
                datEstoque.UpdateCommand = update;
                datEstoque.UpdateCommand.ExecuteNonQuery();
                fbConnection1.Close();
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private void inserir_saida(string lote, string palete)
        {
            string op = "null";
            if (tb_op.Text != "")
            {
                op = tb_op.Text;
            }
            if (lote != "" && lote != null && lote != "''")
                lote = "'" + lote + "'";
            else
                lote = "null";
            if (palete != "" && palete != null && palete != "''")
                palete = "'" + palete + "'";
            else
                palete = "null";
            try
            {
                this.datSaida_estoque.InsertCommand.CommandText =
                "INSERT INTO ESTOQUE_SAIDA (COD_ITEM_ESTOQUE_SAIDA, ITEM_ESTOQUE_SAIDA, QTDE_ESTOQUE_SAIDA, " +
                "CRACHA_ESTOQUE_SAIDA, OP_ESTOQUE_SAIDA, DATA_ESTOQUE_SAIDA, LOTE_ESTOQUE_SAIDA, PALETE_ESTOQUE_SAIDA) VALUES " +
                "('" + tb_cod_item.Text + "','" + tb_item_item.Text + "','" + tb_qtde_saida.Text.Replace(".","").Replace(",", ".") + "','" + tb_cracha.Text + "'," +
                "" + op + ",'" + tb_data.Text.Replace("/", ".") + "'," + lote + ", " + palete + ")";
                this.fbConnection1.Open();
                this.datSaida_estoque.InsertCommand.Connection = fbConnection1;
                this.datSaida_estoque.InsertCommand.ExecuteNonQuery();
                this.fbConnection1.Close();

                //UPDATE NO PALETE
                FbCommand update = new FbCommand();
                update.Connection = fbConnection1;
               
                
                fbConnection1.Open();
                update.CommandText =
                   "UPDATE PALETE_LOTE SET QTD_PALETE_LOTE = QTD_PALETE_LOTE - " + tb_qtde_saida.Text.Replace(".", "").Replace(",", ".") +
                   " WHERE LOTE_PALETE_LOTE = " + lote + " AND N_PALETE_LOTE = " + palete;
                FbDataAdapter datUpdate = new FbDataAdapter();
                datUpdate.UpdateCommand = update;
                datUpdate.UpdateCommand.ExecuteNonQuery();
                fbConnection1.Close();
                    
            }
            catch
            {
                fbConnection1.Close();
                erro_ao_retirar = true;
                MessageBox.Show("Erro na inserção");
            }
        }

        private void localizar_itens()
        {
            try
            {
                dsSaida_estoque.Clear();
                this.datSaida_estoque.SelectCommand.CommandText =
                "SELECT * FROM ESTOQUE_SAIDA ORDER BY COD_ESTOQUE_SAIDA DESC";
                this.fbConnection1.Open();
                this.datSaida_estoque.SelectCommand.Connection = fbConnection1;
                this.datSaida_estoque.SelectCommand.ExecuteNonQuery();
                datSaida_estoque.Fill(ESTOQUE_SAIDA);
                this.fbConnection1.Close();
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());    
            }
        }

        private void atualizar_estoque()
        {
            
        }

        private void form_saidas_estoque_Load(object sender, EventArgs e)
        {
            
            if (saidas_conjuntas)
            {
                atualizar_estoque();
                string cod_estoque = "";
                string lote = "";
                string palete = "";
                string op = "";
                double qtde_a_retirar = 0;
                
                //buscar linhas da tabela BAIXAS_CONJUNTAS_ESTOQUE
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT * FROM BAIXAS_CONJUNTAS_ESTOQUE ORDER BY COD_BCE";
                FbDataAdapter datBaixas = new FbDataAdapter();
                datBaixas.SelectCommand = select;
                DataSet dsBaixas = new DataSet();
                datBaixas.Fill(dsBaixas);
                fbConnection1.Close();
                foreach (DataRow dr in dsBaixas.Tables[0].Rows)
                {
                    tb_data.Text = DateTime.Now.ToShortDateString();
                    if (dr[1].ToString() != "")
                    {
                        op = dr[1].ToString();
                    }
                    else
                    {
                        cod_estoque = dr[2].ToString();
                        qtde_a_retirar = Convert.ToDouble(dr[5].ToString());
                        localizar(cod_estoque);
                        tb_qtde_saida.Text = qtde_a_retirar.ToString();
                        if (Convert.ToDouble(tb_qtde_saida.Text) > Convert.ToDouble(tb_qtde_item.Text))
                        {
                            MessageBox.Show("A quantidade disponível no estoque não é suficiente para essa retirada");
                        }
                        else
                        {
                            tb_cracha.Text = operador;
                            tb_op.Text = op;
                            lote = dr[4].ToString();
                            palete = dr[7].ToString();
                            remover(lote, palete);
                            if (!erro_ao_retirar)
                            {
                                marcar_op_retirada(op, lote);
                                classeEstoque_material est = new classeEstoque_material();
                                est.fbConnection1.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=True;Packet Size=8192;Server Type=0";
                                est.calcular_estoque(tb_cod_item.Text);
                                tb_qtde_saida.Text = "";
                                tb_data.Text = "";
                                tb_cracha.Text = "";
                                tb_op.Text = "";
                                tb_cod_item.Text = ""; tb_item_item.Text = ""; tb_descricao_item.Text = ""; tb_qtde_item.Text = "";
                            }
                        }
                    }
                }
                this.Close();
            }
        }

        private string buscarOs(string p)
        {
            string op = "erro";
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                select.CommandText =
                    "SELECT COD_OP FROM OP WHERE DESENHO_OP_ATUAL = '" + p + "'";
                FbDataAdapter datTable = new FbDataAdapter();
                datTable.SelectCommand = select;
                DataSet dsTable = new DataSet();
                fbConnection1.Open();
                datTable.Fill(dsTable);
                fbConnection1.Close();
                DataRow dr = dsTable.Tables[0].Rows[0];
                return dr[0].ToString();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message, "Erro buscar OS");
                fbConnection1.Close();
                return op;
            }
        }

        private void marcar_op_retirada(string op, string lote)
        {
            try
            {
                FbCommand update = new FbCommand();
                update.Connection = fbConnection1;
                fbConnection1.Open();
                update.CommandText =
                    "UPDATE OP SET MATERIAL_RETIRADO_OP = '1', LOTE = '" + lote + "' WHERE COD_OP = '" + op + "'";
                FbDataAdapter datOp = new FbDataAdapter();
                datOp.UpdateCommand = update;
                datOp.UpdateCommand.ExecuteNonQuery();
                fbConnection1.Close();
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private void tb_cod_item_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                localizar(tb_cod_item.Text);
            }
        }
    }
}