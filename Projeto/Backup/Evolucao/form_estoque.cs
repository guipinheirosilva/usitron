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
    public partial class form_estoque : Form
    {
        public string aux;
        public bool materia_prima;
        public bool novo_item;
        public string cod_a_ser;
        public string cod_a_abrir;
        public form_estoque()
        {
            InitializeComponent();
        }

        private void form_estoque_Load(object sender, EventArgs e)
        {
            if (novo_item == true)
            {
                criar_novo_item();
            }
            if (cod_a_abrir != "")
            {
                localiza_item_estoque(cod_a_abrir);
            }

        }

        private void novo_registro_Click(object sender, EventArgs e)
        {
            criar_novo_item();
            if (cb_tipo.Text == "01 – Matéria-Prima")
            {
                tb_item.ReadOnly = true;
                formar_nome();
            }
            else
            {
                tb_item.ReadOnly = false;
            }

        }

        private void criar_novo_item()
        {
            try
            {
                this.datEstoque.DeleteCommand.CommandText =
                    "DELETE FROM ESTOQUE WHERE ITEM_ESTOQUE = 'NOVO'";
                this.fbConnection1.Open();
                this.datEstoque.DeleteCommand.Connection = fbConnection1;
                this.datEstoque.DeleteCommand.ExecuteNonQuery();
                this.fbConnection1.Close();

                this.datEstoque.InsertCommand.CommandText =
                    "INSERT INTO ESTOQUE (ITEM_ESTOQUE, COD_BARRAS_ITEM_FABRICANTE, ESTOQUE_ATUAL_ESTOQUE)" +
                    "VALUES ('NOVO', '" + cod_a_ser + "', 0)";
                this.fbConnection1.Open();
                this.datEstoque.InsertCommand.Connection = fbConnection1;
                this.datEstoque.InsertCommand.ExecuteNonQuery();
                this.fbConnection1.Close();
                dsEstoque.Clear();
                this.datEstoque.SelectCommand.CommandText =
                        "SELECT * FROM ESTOQUE WHERE ITEM_ESTOQUE = 'NOVO'";
                this.fbConnection1.Open();
                this.datEstoque.SelectCommand.Connection = fbConnection1;
                this.datEstoque.SelectCommand.ExecuteNonQuery();
                datEstoque.Fill(ESTOQUE);
                this.fbConnection1.Close();
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show("Ocorreu um erro ao cadastrar um no item de estoque!");
            }
        }

        private void apaga_registro_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("O registro será excluído permanentemente, tem certeza?",
                "Confirma a exclusão?", MessageBoxButtons.YesNo))
            {
                try
                {
                    this.datEstoque.DeleteCommand.CommandText =
                    "DELETE FROM ESTOQUE WHERE COD_ESTOQUE = '" + tb_cod.Text + "'";
                    this.fbConnection1.Open();
                    this.datEstoque.DeleteCommand.Connection = fbConnection1;
                    this.datEstoque.DeleteCommand.ExecuteNonQuery();
                    this.fbConnection1.Close();
                    localiza_item();
                }
                catch
                {

                    fbConnection1.Close();
                }

            }


        }

        private void salva_registro_Click(object sender, EventArgs e)
        {
            if (campos_obrigatorios())
            {
                if (nao_existe_outro())
                {
                    atualizar();
                }
                else
                {
                    MessageBox.Show("Já existe um item cadastrado com essa características");
                }
            }
            else
            {
                MessageBox.Show("O campo Cliente é Obrigatório para Cadastro de Matéria Prima.");
            }


        }

        private bool nao_existe_outro()
        {
            try
            {
                if (cb_tipo.Text == "01 – Matéria-Prima")
                {
                    FbCommand select = new FbCommand();
                    select.Connection = fbConnection1;
                    fbConnection1.Open();
                    string item = "null", cliente = "null", grupo = "null", material = "null", classificacao = "null",
                        acabamento = "null", espessura = "null", dimensao = "null", proprietario = "null";
                    if (tb_item.Text != "")
                        item = "'" + tb_item.Text + "'";
                    if (tb_cliente.Text != "")
                        cliente = "'" + tb_cliente.Text + "'";
                    if (tb_grupo.Text != "")
                        grupo = "'" + tb_grupo.Text + "'";
                    if (tb_material.Text != "")
                        material = "'" + tb_material.Text + "'";
                    if (tb_classificacao.Text != "")
                        classificacao = "'" + tb_classificacao.Text + "'";
                    if (tb_acabamento.Text != "")
                        acabamento = "'" + tb_acabamento.Text + "'";
                    if (tb_espessura.Text != "")
                        espessura = "'" + tb_espessura.Text + "'";
                    if (tb_dimensao.Text != "")
                        dimensao = "'" + tb_dimensao.Text + "'";
                    if (tb_cliente.Text != "")
                        proprietario = "'" + tb_cliente.Text + "'";



                    select.CommandText =
                        "SELECT * FROM ESTOQUE " +
                        "WHERE (ITEM_ESTOQUE = " + item + " AND NOME_PROPRIETARIO_ESTOQUE = " + cliente + ") OR (GRUPO_ESTOQUE = " +
                        grupo + " AND MATERIAL_ESTOQUE = " + material + " AND CLASSIFICACAO_ESTOQUE = " +
                        classificacao + " AND ACABAMENTO_ESTOQUE = " + acabamento + " AND ESPESSURA_ESTOQUE = " +
                        espessura + " AND DIMENSAO_ESTOQUE = " + dimensao + " AND NOME_PROPRIETARIO_ESTOQUE = " +
                        cliente + ")";
                    FbDataAdapter estoqueDataAdapter = new FbDataAdapter();
                    estoqueDataAdapter.SelectCommand = select;
                    DataSet estoqueDataSet = new DataSet();
                    estoqueDataAdapter.Fill(estoqueDataSet);
                    fbConnection1.Close();
                    foreach (DataRow dr in estoqueDataSet.Tables[0].Rows)
                    {
                        if (dr["COD_ESTOQUE"].ToString() != tb_cod.Text)
                        {
                            return false;
                        }
                    }
                    return true;
                }
                else
                {
                    FbCommand select = new FbCommand();
                    select.Connection = fbConnection1;
                    fbConnection1.Open();
                    string item = "null", descricao = "null";
                    if (tb_item.Text != "")
                        item = "'" + tb_item.Text + "'";

                    if (textBox11.Text != "")
                        descricao = "'" + textBox11.Text + "'";

                    select.CommandText =
                        "SELECT * FROM ESTOQUE " +
                        "WHERE (ITEM_ESTOQUE = " + item + " AND DESCRICAO_ESTOQUE = " + descricao + ")";
                    FbDataAdapter estoqueDataAdapter = new FbDataAdapter();
                    estoqueDataAdapter.SelectCommand = select;
                    DataSet estoqueDataSet = new DataSet();
                    estoqueDataAdapter.Fill(estoqueDataSet);
                    fbConnection1.Close();
                    foreach (DataRow dr in estoqueDataSet.Tables[0].Rows)
                    {
                        if (dr["COD_ESTOQUE"].ToString() != tb_cod.Text)
                        {
                            return false;
                        }
                    }
                    return true;
                }
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
                return true;
            }

        }

        private bool campos_obrigatorios()
        {
            if (cb_tipo.Text == "01 – Matéria-Prima")
            {
                
                /*if (tb_grupo.Text == "")
                    return false;
                if (tb_material.Text == "")
                    return false;
                if (tb_classificacao.Text == "")
                    return false;
                
                if (tb_acabamento.Text == "")
                    return false;
                if (tb_espessura.Text == "")
                    return false;
                if (tb_dimensao.Text == "")
                    return false;*/
                 
                if (tb_cliente.Text == "")
                    return false;
                return true;
            }
            else
            {
                return true;
            }

        }
        private void atualizar()
        {
            try
            {
                /*
                    //entradas
                    this.BindingContext[dsItens_nota_ent, "ITENS_NOTA_ENT"].EndCurrentEdit();
                    fbConnection1.Open();
                    if (dsItens_nota_ent.HasChanges())
                    {

                        datItens_nota_ent.UpdateCommand = cbItens_nota_ent.GetUpdateCommand();
                        datItens_nota_ent.InsertCommand = cbItens_nota_ent.GetInsertCommand();
                        datItens_nota_ent.DeleteCommand = cbItens_nota_ent.GetDeleteCommand();
                        datItens_nota_ent.Update(dsItens_nota_ent, "ITENS_NOTA_ENT");
                        dsItens_nota_ent.AcceptChanges();

                    }
                    fbConnection1.Close();
            
                    //saidas
                    this.BindingContext[dsSaida_estoque, "SAIDA_ESTOQUE"].EndCurrentEdit();
                    fbConnection1.Open();
                    if (dsSaida_estoque.HasChanges())
                    {

                        datSaida_estoque.UpdateCommand = cbSaida_estoque.GetUpdateCommand();
                        datSaida_estoque.InsertCommand = cbSaida_estoque.GetInsertCommand();
                        datSaida_estoque.DeleteCommand = cbSaida_estoque.GetDeleteCommand();
                        datSaida_estoque.Update(dsSaida_estoque, "SAIDA_ESTOQUE");
                        dsSaida_estoque.AcceptChanges();

                    }
                    fbConnection1.Close();
                */

                this.BindingContext[dsEstoque, "ESTOQUE"].EndCurrentEdit();
                fbConnection1.Open();
                if (dsEstoque.HasChanges())
                {

                    datEstoque.UpdateCommand = cbEstoque.GetUpdateCommand();
                    datEstoque.InsertCommand = cbEstoque.GetInsertCommand();
                    datEstoque.DeleteCommand = cbEstoque.GetDeleteCommand();
                    datEstoque.Update(dsEstoque, "ESTOQUE");
                    dsEstoque.AcceptChanges();

                }
                fbConnection1.Close();

            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private void calcular_estoque(string cod_estoque)
        {
            classeEstoque est = new classeEstoque();
            est.fbConnection1.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=\evolucao_dokinos\\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=True;Packet Size=8192;Server Type=0";
            est.calcular_estoque(cod_estoque);
            /*
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
                    "UPDATE ESTOQUE SET ESTOQUE_ATUAL_ESTOQUE = '" + saldo.ToString() + "' WHERE COD_ESTOQUE = '" + cod_estoque + "'";
                FbDataAdapter estoqueDataAdapter = new FbDataAdapter();
                estoqueDataAdapter.UpdateCommand = update;
                estoqueDataAdapter.UpdateCommand.ExecuteNonQuery();
                fbConnection1.Close();
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
             * */
        }

        private void button3_Click(object sender, EventArgs e)
        {
            aux = tb_cod.Text;
            tb_cod.Text = "";
            if (materia_prima)
                localiza_item_mp();
            else
                localiza_item();
            if (cb_tipo.Text == "01 – Matéria-Prima")
            {
                tb_item.ReadOnly = true;
            }
        }

        private void localiza_item_mp()
        {
            form_busca_item_estoque_mp localiza_item = new form_busca_item_estoque_mp();
            try
            {
                localiza_item.ShowDialog();
            }
            finally
            {
                localiza_item.Dispose();
                if (localiza_item.cod_escolhido == "")
                {
                    tb_cod.Text = aux;
                }
                else
                {
                    try
                    {
                        dsEstoque.Clear();
                        this.datEstoque.SelectCommand.CommandText =
                        "SELECT * FROM ESTOQUE WHERE COD_ESTOQUE = '" + localiza_item.cod_escolhido + "'";
                        this.fbConnection1.Open();
                        this.datEstoque.SelectCommand.Connection = fbConnection1;
                        this.datEstoque.SelectCommand.ExecuteNonQuery();
                        datEstoque.Fill(ESTOQUE);
                        this.fbConnection1.Close();

                        dsItens_nf.Clear();
                        this.datItens_nf.SelectCommand.CommandText =
                        "SELECT * FROM ITENS_NF_ENTRADA WHERE COD_ITENS_NF_ENT = '" + localiza_item.cod_escolhido + "' ORDER BY DATA_ENT_ITENS_NF_ENT DESC";
                        this.fbConnection1.Open();
                        this.datItens_nf.SelectCommand.Connection = fbConnection1;
                        this.datItens_nf.SelectCommand.ExecuteNonQuery();
                        datItens_nf.Fill(ITENS_NF_ENTRADA);
                        this.fbConnection1.Close();

                        dsItens_nota_ent.Clear();
                        this.datItens_nota_ent.SelectCommand.CommandText =
                        "SELECT * FROM ITENS_NOTA_ENT WHERE COD_ITEM_EST_ITEM_ENT = '" + localiza_item.cod_escolhido + "' ORDER BY DATA_INSERCAO_ITEM_ENT_NOTA DESC";
                        this.fbConnection1.Open();
                        this.datItens_nota_ent.SelectCommand.Connection = fbConnection1;
                        this.datItens_nota_ent.SelectCommand.ExecuteNonQuery();
                        datItens_nota_ent.Fill(ITENS_NOTA_ENT);
                        this.fbConnection1.Close();

                        dsSaida_estoque.Clear();
                        this.datSaida_estoque.SelectCommand.CommandText =
                        "SELECT * FROM ESTOQUE_SAIDA WHERE COD_ITEM_ESTOQUE_SAIDA = '" + localiza_item.cod_escolhido + "' ORDER BY DATA_ESTOQUE_SAIDA DESC";
                        this.fbConnection1.Open();
                        this.datSaida_estoque.SelectCommand.Connection = fbConnection1;
                        this.datSaida_estoque.SelectCommand.ExecuteNonQuery();
                        datSaida_estoque.Fill(ESTOQUE_SAIDA);
                        this.fbConnection1.Close();

                        dsItens_ped.Clear();
                        this.datItens_ped.SelectCommand.CommandText =
                        "SELECT * FROM ITENS_PEDIDO_COMPRA WHERE COD_ESTOQUE_ITEM_PED = '" + localiza_item.cod_escolhido + "' ORDER BY DATA_CHEGADA_ITEM_PED DESC";
                        this.fbConnection1.Open();
                        this.datItens_ped.SelectCommand.Connection = fbConnection1;
                        this.datItens_ped.SelectCommand.ExecuteNonQuery();
                        datItens_ped.Fill(ITENS_PEDIDO_COMPRA);
                        this.fbConnection1.Close();

                        dsItens_requisicao.Clear();
                        this.datItens_requisicao.SelectCommand.CommandText =
                        "SELECT * FROM ITENS_REQUISICAO WHERE COD_ESTOQUE_ITEM_REQ = '" + localiza_item.cod_escolhido + "' ORDER BY COD_ITEM_REQ DESC";
                        this.fbConnection1.Open();
                        this.datItens_requisicao.SelectCommand.Connection = fbConnection1;
                        this.datItens_requisicao.SelectCommand.ExecuteNonQuery();
                        datItens_requisicao.Fill(ITENS_REQUISICAO);
                        this.fbConnection1.Close();
                    }
                    catch
                    {
                        fbConnection1.Close();
                    }

                }
            }
        }

        private void localiza_item()
        {
            form_busca_item_estoque_mp localiza_item = new form_busca_item_estoque_mp();
            try
            {
                localiza_item.ShowDialog();
            }
            finally
            {
                localiza_item.Dispose();
                if (localiza_item.cod_escolhido == "")
                { tb_cod.Text = aux; }
                else
                {
                    try
                    {
                        dsEstoque.Clear();
                        this.datEstoque.SelectCommand.CommandText =
                        "SELECT * FROM ESTOQUE WHERE COD_ESTOQUE = '" + localiza_item.cod_escolhido + "'";
                        this.fbConnection1.Open();
                        this.datEstoque.SelectCommand.Connection = fbConnection1;
                        this.datEstoque.SelectCommand.ExecuteNonQuery();
                        datEstoque.Fill(ESTOQUE);
                        this.fbConnection1.Close();

                        dsItens_nf.Clear();
                        this.datItens_nf.SelectCommand.CommandText =
                        "SELECT * FROM ITENS_NF_ENTRADA WHERE COD_ITENS_NF_ENT = '" + localiza_item.cod_escolhido + "' ORDER BY DATA_ENT_ITENS_NF_ENT DESC";
                        this.fbConnection1.Open();
                        this.datItens_nf.SelectCommand.Connection = fbConnection1;
                        this.datItens_nf.SelectCommand.ExecuteNonQuery();
                        datItens_nf.Fill(ITENS_NF_ENTRADA);
                        this.fbConnection1.Close();

                        dsItens_nota_ent.Clear();
                        this.datItens_nota_ent.SelectCommand.CommandText =
                        "SELECT * FROM ITENS_NOTA_ENT WHERE COD_ITEM_EST_ITEM_ENT = '" + localiza_item.cod_escolhido + "' ORDER BY DATA_INSERCAO_ITEM_ENT_NOTA DESC";
                        this.fbConnection1.Open();
                        this.datItens_nota_ent.SelectCommand.Connection = fbConnection1;
                        this.datItens_nota_ent.SelectCommand.ExecuteNonQuery();
                        datItens_nota_ent.Fill(ITENS_NOTA_ENT);
                        this.fbConnection1.Close();

                        dsSaida_estoque.Clear();
                        this.datSaida_estoque.SelectCommand.CommandText =
                        "SELECT * FROM ESTOQUE_SAIDA WHERE COD_ITEM_ESTOQUE_SAIDA = '" + localiza_item.cod_escolhido + "' ORDER BY DATA_ESTOQUE_SAIDA DESC";
                        this.fbConnection1.Open();
                        this.datSaida_estoque.SelectCommand.Connection = fbConnection1;
                        this.datSaida_estoque.SelectCommand.ExecuteNonQuery();
                        datSaida_estoque.Fill(ESTOQUE_SAIDA);
                        this.fbConnection1.Close();

                        dsItens_ped.Clear();
                        this.datItens_ped.SelectCommand.CommandText =
                        "SELECT * FROM ITENS_PEDIDO_COMPRA WHERE COD_ESTOQUE_ITEM_PED = '" + localiza_item.cod_escolhido + "' ORDER BY DATA_CHEGADA_ITEM_PED DESC";
                        this.fbConnection1.Open();
                        this.datItens_ped.SelectCommand.Connection = fbConnection1;
                        this.datItens_ped.SelectCommand.ExecuteNonQuery();
                        datItens_ped.Fill(ITENS_PEDIDO_COMPRA);
                        this.fbConnection1.Close();

                        dsItens_requisicao.Clear();
                        this.datItens_requisicao.SelectCommand.CommandText =
                        "SELECT * FROM ITENS_REQUISICAO WHERE COD_ESTOQUE_ITEM_REQ = '" + localiza_item.cod_escolhido + "' ORDER BY COD_ITEM_REQ DESC";
                        this.fbConnection1.Open();
                        this.datItens_requisicao.SelectCommand.Connection = fbConnection1;
                        this.datItens_requisicao.SelectCommand.ExecuteNonQuery();
                        datItens_requisicao.Fill(ITENS_REQUISICAO);
                        this.fbConnection1.Close();
                    }
                    catch
                    {
                        fbConnection1.Close();
                    }

                }
            }
        }

        private void bt_imprimir_cod_Click(object sender, EventArgs e)
        {

            dsCod_barras imprimir = new dsCod_barras();
            fbConnection1.Open();
            datEstoque.Fill(imprimir.ESTOQUE);
            fbConnection1.Close();
            crCod_barras novo_cod = new crCod_barras();
            novo_cod.SetDataSource(imprimir);
            form_imprimir imprime = new form_imprimir(novo_cod);
            imprime.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form_usuario usuario = new form_usuario();
            try
            {
                usuario.ShowDialog();
            }
            finally
            {

                if (usuario.confirmado == true)
                {
                    try
                    {
                        if (usuario._cod_usuario == "1" || usuario._cod_usuario == "6")
                        {
                            atualizar_entradas_saidas();
                            atualizar();
                            calcular_estoque(tb_cod.Text);
                            localiza_item_estoque(tb_cod.Text);
                        }
                    }
                    catch { }
                }
            }


        }

        private void atualizar_entradas_saidas()
        {
            try
            {
                //entradas
                this.BindingContext[dsItens_nota_ent, "ITENS_NOTA_ENT"].EndCurrentEdit();
                fbConnection1.Open();
                if (dsItens_nota_ent.HasChanges())
                {

                    datItens_nota_ent.UpdateCommand = cbItens_nota_ent.GetUpdateCommand();
                    datItens_nota_ent.InsertCommand = cbItens_nota_ent.GetInsertCommand();
                    datItens_nota_ent.DeleteCommand = cbItens_nota_ent.GetDeleteCommand();
                    datItens_nota_ent.Update(dsItens_nota_ent, "ITENS_NOTA_ENT");
                    dsItens_nota_ent.AcceptChanges();

                }
                fbConnection1.Close();

                //saidas
                this.BindingContext[dsSaida_estoque, "ESTOQUE_SAIDA"].EndCurrentEdit();
                fbConnection1.Open();
                if (dsSaida_estoque.HasChanges())
                {

                    datSaida_estoque.UpdateCommand = cbSaida_estoque.GetUpdateCommand();
                    datSaida_estoque.InsertCommand = cbSaida_estoque.GetInsertCommand();
                    datSaida_estoque.DeleteCommand = cbSaida_estoque.GetDeleteCommand();
                    datSaida_estoque.Update(dsSaida_estoque, "ESTOQUE_SAIDA");
                    dsSaida_estoque.AcceptChanges();

                }
                fbConnection1.Close();
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private void localiza_item_estoque(string cod)
        {
            try
            {
                dsEstoque.Clear();
                this.datEstoque.SelectCommand.CommandText =
                "SELECT * FROM ESTOQUE WHERE COD_ESTOQUE = '" + cod + "'";
                this.fbConnection1.Open();
                this.datEstoque.SelectCommand.Connection = fbConnection1;
                this.datEstoque.SelectCommand.ExecuteNonQuery();
                datEstoque.Fill(ESTOQUE);
                this.fbConnection1.Close();

                dsItens_nf.Clear();
                this.datItens_nf.SelectCommand.CommandText =
                "SELECT * FROM ITENS_NF_ENTRADA WHERE COD_ITENS_NF_ENT = '" + cod + "' ORDER BY DATA_ENT_ITENS_NF_ENT DESC";
                this.fbConnection1.Open();
                this.datItens_nf.SelectCommand.Connection = fbConnection1;
                this.datItens_nf.SelectCommand.ExecuteNonQuery();
                datItens_nf.Fill(ITENS_NF_ENTRADA);
                this.fbConnection1.Close();

                dsItens_nota_ent.Clear();
                this.datItens_nota_ent.SelectCommand.CommandText =
                "SELECT * FROM ITENS_NOTA_ENT WHERE COD_ITEM_EST_ITEM_ENT = '" + cod + "' ORDER BY DATA_INSERCAO_ITEM_ENT_NOTA DESC";
                this.fbConnection1.Open();
                this.datItens_nota_ent.SelectCommand.Connection = fbConnection1;
                this.datItens_nota_ent.SelectCommand.ExecuteNonQuery();
                datItens_nota_ent.Fill(ITENS_NOTA_ENT);
                this.fbConnection1.Close();

                dsSaida_estoque.Clear();
                this.datSaida_estoque.SelectCommand.CommandText =
                        "SELECT es.*, op.desenho_op_atual, op.n_pdf " +
                        "FROM ESTOQUE_SAIDA es " +
                        "LEFT JOIN op " +
                        "ON es.op_estoque_saida = op.cod_op " +
                        "WHERE es.cod_item_estoque_saida = " + cod + " " +
                        "ORDER BY es.data_estoque_saida DESC";
                this.fbConnection1.Open();
                this.datSaida_estoque.SelectCommand.Connection = fbConnection1;
                this.datSaida_estoque.SelectCommand.ExecuteNonQuery();
                datSaida_estoque.Fill(ESTOQUE_SAIDA);
                this.fbConnection1.Close();

                dsItens_ped.Clear();
                this.datItens_ped.SelectCommand.CommandText =
                "SELECT * FROM ITENS_PEDIDO_COMPRA WHERE COD_ESTOQUE_ITEM_PED = '" + cod + "' ORDER BY DATA_CHEGADA_ITEM_PED DESC";
                this.fbConnection1.Open();
                this.datItens_ped.SelectCommand.Connection = fbConnection1;
                this.datItens_ped.SelectCommand.ExecuteNonQuery();
                datItens_ped.Fill(ITENS_PEDIDO_COMPRA);
                this.fbConnection1.Close();

                dsItens_requisicao.Clear();
                this.datItens_requisicao.SelectCommand.CommandText =
                "SELECT * FROM ITENS_REQUISICAO WHERE COD_ESTOQUE_ITEM_REQ = '" + cod + "' ORDER BY COD_ITEM_REQ DESC";
                this.fbConnection1.Open();
                this.datItens_requisicao.SelectCommand.Connection = fbConnection1;
                this.datItens_requisicao.SelectCommand.ExecuteNonQuery();
                datItens_requisicao.Fill(ITENS_REQUISICAO);
                this.fbConnection1.Close();

                dsOp.Clear();
                this.datOp.SelectCommand.CommandText =
                "SELECT * FROM OP WHERE COD_MATERIAL_OP = '" + cod + "' AND (MATERIAL_RETIRADO_OP != '1' OR MATERIAL_RETIRADO_OP IS NULL)";
                this.fbConnection1.Open();
                this.datOp.SelectCommand.Connection = fbConnection1;
                this.datOp.SelectCommand.ExecuteNonQuery();
                datOp.Fill(OP);
                this.fbConnection1.Close();

            }
            catch
            {
                fbConnection1.Close();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            form_localiza_cliente forn = new form_localiza_cliente(true);
            try
            {
                forn.ShowDialog();
            }
            finally
            {
                //tb_estado_cliente.Text = forn.estado_escolhido;
                tb_cnpj_cliente.Text = forn.cnpj_escolhido;
                tb_cliente.Text = forn.cliente_escolhido;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            form_tabela_grupo grupo = new form_tabela_grupo();
            try
            {
                grupo.busca = true;
                grupo.ShowDialog();
            }
            finally
            {
                tb_grupo.Text = grupo.nome;
                formar_nome();
            }
        }

        private void formar_nome()
        {
            try
            {
                if (cb_tipo.Text[1].ToString() == "1")
                {
                    string grupo = "", material = "", classificacao = "", acabamento = "", espessura = "", dimensoes = "", comprimento = "";
                    if (tb_grupo.Text != "")
                        grupo = tb_grupo.Text + " ";
                    if (tb_material.Text != "")
                        material = tb_material.Text + " ";
                    if (tb_classificacao.Text != "")
                        classificacao = tb_classificacao.Text + " ";
                    if (tb_acabamento.Text != "")
                        acabamento = tb_acabamento.Text + " ";
                    if (tb_espessura.Text != "")
                        espessura = tb_espessura.Text + " ";
                    if (tb_dimensao.Text != "")
                        dimensoes = tb_dimensao.Text + " ";
                    if (tb_comprimento.Text != "")
                        comprimento = tb_comprimento.Text;

                    string nome = grupo + material + classificacao + acabamento + espessura + dimensoes + comprimento;
                    if (nome.Trim() == "")
                    {
                        MessageBox.Show("O Nome da matéria prima é formada pela descrição dos campos: grupo, material, classificação, acabamento, espessura e comprimento. Escolha pelo menos uma opção entre estas!");
                    }
                    tb_item.Text = nome;
                }
            }
            catch { }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            form_tabela_material grupo = new form_tabela_material();
            try
            {
                grupo.busca = true;
                grupo.ShowDialog();
            }
            finally
            {
                tb_material.Text = grupo.nome;
                formar_nome();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            form_tabela_classificacao grupo = new form_tabela_classificacao();
            try
            {
                grupo.busca = true;
                grupo.ShowDialog();
            }
            finally
            {
                tb_classificacao.Text = grupo.nome;
                formar_nome();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            form_tabela_acabamento grupo = new form_tabela_acabamento();
            try
            {
                grupo.busca = true;
                grupo.ShowDialog();
            }
            finally
            {
                tb_acabamento.Text = grupo.nome;
                formar_nome();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            form_tabela_espessura grupo = new form_tabela_espessura();
            try
            {
                grupo.busca = true;
                grupo.ShowDialog();
            }
            finally
            {
                tb_espessura.Text = grupo.nome;
                formar_nome();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            form_tabela_dimensao grupo = new form_tabela_dimensao();
            try
            {
                grupo.busca = true;
                grupo.ShowDialog();
            }
            finally
            {
                tb_dimensao.Text = grupo.nome;
                formar_nome();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            form_tabela_comprimento grupo = new form_tabela_comprimento();
            try
            {
                grupo.busca = true;
                grupo.ShowDialog();
            }
            finally
            {
                tb_comprimento.Text = grupo.nome;
                formar_nome();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            datEstoque.SelectCommand.CommandText =
                "SELECT * FROM ESTOQUE WHERE TIPO_ITEM_ESTOQUE != '01 – Matéria-Prima'";

            dsCod_barras imprimir = new dsCod_barras();
            fbConnection1.Open();
            datEstoque.Fill(imprimir.ESTOQUE);
            fbConnection1.Close();
            crCod_barras novo_cod = new crCod_barras();
            novo_cod.SetDataSource(imprimir);
            form_imprimir imprime = new form_imprimir(novo_cod);
            imprime.Show();
        }

        private void cb_tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_tipo.Text == "999 – Matéria-Prima")
            {
                tb_item.ReadOnly = true;
                formar_nome();
            }
            else
            {
                tb_item.ReadOnly = false;
            }

        }

        private void tb_item_TextChanged(object sender, EventArgs e)
        {
            if (cb_tipo.Text == "" && tb_cod.Text != "")
            {
                MessageBox.Show("Por favor, escolha o Tipo de Estoque no campo 'Tipo' antes de digitar a descrição");
                tb_item.Text = "";
            }
        }

        private void dgvOp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }




    }
}