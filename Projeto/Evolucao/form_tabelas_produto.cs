using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using System.Collections;
using System.Data.OleDb;

namespace Evolucao
{
    public partial class form_tabelas_produto : Form
    {
        string cnpj_empresa;
        public form_tabelas_produto(string cnpj_empresa)
        {
            this.cnpj_empresa = cnpj_empresa;
            InitializeComponent();
        }

        private void form_tabelas_produto_Load(object sender, EventArgs e)
        {           
                
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (tb_cod_tabela.Text == "")
                MessageBox.Show("Insira ou localize uma tabela");
            else
            {
                form_localiza_produto prod = new form_localiza_produto(false, cnpj_empresa);
                try
                {
                    prod.ShowDialog();
                }
                finally
                {
                    for (int i = 0; i < prod.qtde_produtos_selecionados; i++)
                    {
                        string descricao = "", preco = "", item2 = "", preco_minimo = "";
                        if (prod.produtos_selecionados[i] != null)
                        {
                            try
                            {
                                comando_select.CommandText = "SELECT * FROM ITENS_TP WHERE COD_TABELA_ITEM_TP = '" + tb_cod_tabela.Text + "' AND COD_PRODUTO_ITEM_TP = '" + prod.produtos_selecionados[i].ToString() + "'";
                                DataSet item = new DataSet();
                                fbConnection1.Open();
                                datItens_tp.SelectCommand = comando_select;
                                datItens_tp.Fill(item);
                                fbConnection1.Close();

                                foreach (DataRow dr in item.Tables[0].Rows)
                                {
                                    item2 = dr["DESCRICAO_PRODUTO_ITEM_TP"].ToString();
                                }
                                
                            }
                            catch
                            {
                                fbConnection1.Close();
                            }
                            if (item2 == "")
                            {
                                try
                                {


                                    try
                                    {
                                        comando_select.CommandText = "SELECT * FROM PRODUTOS WHERE COD_PRODUTO = '" + prod.produtos_selecionados[i].ToString() + "'";
                                        DataSet produtos = new DataSet();
                                        fbConnection1.Open();
                                        datProdutos.SelectCommand = comando_select;
                                        datProdutos.Fill(produtos);
                                        fbConnection1.Close();

                                        foreach (DataRow dr in produtos.Tables[0].Rows)
                                        {
                                            descricao = dr["DESCRICAO_PRODUTO"].ToString();
                                            preco = dr["VALOR_VENDA_REVEND_PRODUTO"].ToString();
                                            preco_minimo = dr["VALOR_PROMOCAO_PRODUTO"].ToString();
                                        }
                                        preco = preco.Replace(".", "").Replace(",", ".");
                                        preco_minimo = preco_minimo.Replace(".", "").Replace(",", ".");
                                    }
                                    catch
                                    {
                                        fbConnection1.Close();
                                    }
                                    if (preco == "")
                                        preco = "null";
                                    else
                                        preco = "'" + preco + "'";
                                    if (preco_minimo == "")
                                        preco_minimo = "null";
                                    else
                                        preco_minimo = "'" + preco_minimo + "'";
                                    this.datItens_tp.InsertCommand.CommandText =
                                   "INSERT INTO ITENS_TP (COD_TABELA_ITEM_TP, COD_PRODUTO_ITEM_TP, DESCRICAO_PRODUTO_ITEM_TP, PRECO_PRODUTO_ITEM_TP, PRECO_MINIMO_ITEM_TP)" +
                                   "VALUES ('" + tb_cod_tabela.Text + "','" + prod.produtos_selecionados[i].ToString() + "','" + descricao + "'," + preco + "," + preco_minimo + ")";
                                    this.fbConnection1.Open();
                                    this.datItens_tp.InsertCommand.Connection = fbConnection1;
                                    this.datItens_tp.InsertCommand.ExecuteNonQuery();
                                    this.fbConnection1.Close();

                                }
                                catch
                                {
                                    fbConnection1.Close();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Produto já cadastrado");
                            }
                        }

                    }
                    selecionar_itens(tb_cod_tabela.Text);

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.datTabela_preco.DeleteCommand.CommandText =
               "DELETE FROM TABELA_PRECO WHERE NOME_TABELA_PRECO = 'NOVO'";
                this.fbConnection1.Open();
                this.datTabela_preco.DeleteCommand.Connection = fbConnection1;
                this.datTabela_preco.DeleteCommand.ExecuteNonQuery();
                this.fbConnection1.Close();

                this.datTabela_preco.InsertCommand.CommandText =
                           "INSERT INTO TABELA_PRECO(NOME_TABELA_PRECO)" +
                           "VALUES ('NOVO')";
                this.fbConnection1.Open();
                this.datTabela_preco.InsertCommand.Connection = fbConnection1;
                this.datTabela_preco.InsertCommand.ExecuteNonQuery();
                this.fbConnection1.Close();

                dsItens_tp.Clear();
                dsTabela_preco.Clear();
                this.datTabela_preco.SelectCommand.CommandText =
                "SELECT * FROM TABELA_PRECO WHERE NOME_TABELA_PRECO = 'NOVO'";
                this.fbConnection1.Open();
                this.datTabela_preco.SelectCommand.Connection = fbConnection1;
                this.datTabela_preco.SelectCommand.ExecuteNonQuery();
                datTabela_preco.Fill(TABELA_PRECO);
                this.fbConnection1.Close();
            }
            catch
            {
                fbConnection1.Close();
            }
        }

        private void selecionar_itens(string cod)
        {
            try
            {
                dsItens_tp.Clear();
                this.datItens_tp.SelectCommand.CommandText =
                "SELECT * FROM ITENS_TP WHERE COD_TABELA_ITEM_TP = '" + cod + "' ORDER BY DESCRICAO_PRODUTO_ITEM_TP";
                this.fbConnection1.Open();
                this.datItens_tp.SelectCommand.Connection = fbConnection1;
                this.datItens_tp.SelectCommand.ExecuteNonQuery();
                datItens_tp.Fill(ITENS_TP);
                this.fbConnection1.Close();
            }
            catch
            {
                fbConnection1.Close();
            }
        }

        private void localizarTabela(string cod, string descricao)
        {
            try
            {
                dsTabela_preco.Clear();
                this.datTabela_preco.SelectCommand.CommandText =
            "SELECT * FROM TABELA_PRECO WHERE COD_TABELA_PRECO = '" + cod + "'";
                this.fbConnection1.Open();
                this.datTabela_preco.SelectCommand.Connection = fbConnection1;
                this.datTabela_preco.SelectCommand.ExecuteNonQuery();
                datTabela_preco.Fill(TABELA_PRECO);
                this.fbConnection1.Close();
                selecionar_itens(cod);
                //tb_cod_tabela.Text = cod;
              //  tbNomeTabela.Text = descricao;
            }
            catch
            {
                fbConnection1.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            form_localiza_tabela_preco tab = new form_localiza_tabela_preco();
            try
            {
                tab.ShowDialog();
            }
            finally
            {
                localizarTabela(tab._cod, tab._descricao);
                btAtualizarTabela.Enabled = true;

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            salvar();
        }

        private void salvar()
        {
            try
            {
                this.BindingContext[dsTabela_preco, "TABELA_PRECO"].EndCurrentEdit();
                if (dsTabela_preco.HasChanges())
                {
                    fbConnection1.Open();
                    datTabela_preco.UpdateCommand = cbTabela_preco.GetUpdateCommand();
                    datTabela_preco.InsertCommand = cbTabela_preco.GetInsertCommand();
                    datTabela_preco.DeleteCommand = cbTabela_preco.GetDeleteCommand();
                    datTabela_preco.Update(dsTabela_preco, "TABELA_PRECO");
                    dsTabela_preco.AcceptChanges();
                    fbConnection1.Close();
                }
            }
            catch
            {
                fbConnection1.Close();
            }
            try
            {
                this.BindingContext[dsItens_tp, "ITENS_TP"].EndCurrentEdit();
                if (dsItens_tp.HasChanges())
                {
                    fbConnection1.Open();
                    datItens_tp.UpdateCommand = cbItens_tp.GetUpdateCommand();
                    datItens_tp.InsertCommand = cbItens_tp.GetInsertCommand();
                    datItens_tp.DeleteCommand = cbItens_tp.GetDeleteCommand();
                    datItens_tp.Update(dsItens_tp, "ITENS_TP");
                    dsItens_tp.AcceptChanges();
                    fbConnection1.Close();
                }
            }
            catch
            {
                fbConnection1.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Essa operação irá excluir a tabela de estoque, tem certeza?",
             "Confirma?", MessageBoxButtons.YesNo))
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
                        if (usuario._cod_usuario == "1" || usuario._cod_usuario == "2")
                        {
                            ArrayList clientes = new ArrayList();
                            string razaoClientes = "";
                            clientes = verificarCliente(tb_cod_tabela.Text);
                            if (clientes.Count > 0)
                            {
                                for (int i = 0; i < clientes.Count; i++)
                                {
                                    if (i == 0)
                                    {
                                        razaoClientes = "Não foi possível excluir a tabela " +
                                            tbNomeTabela.Text + "! \nExiste(m) cliente(s) cadastrado(s) nesta tabela: \n" +
                                            clientes[i].ToString() + "\n";
                                    }
                                    else
                                    {
                                        razaoClientes = razaoClientes + clientes[i].ToString();
                                    }
                                }
                                MessageBox.Show(razaoClientes);
                            }
                            else
                            {
                                excuirTabela(tb_cod_tabela.Text);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Usuário não autorizado");
                        }
                    }
                }
            }
        }

        private void excuirTabela(string codTabela)
        {
            FbCommand delete = new FbCommand();
            delete.Connection = fbConnection1;
            fbConnection1.Open();
            delete.CommandText = "DELETE FROM TABELA_PRECO WHERE COD_TABELA_PRECO = '" + codTabela + "'";
            FbDataAdapter datTabela = new FbDataAdapter();
            datTabela.DeleteCommand = delete;
            datTabela.DeleteCommand.ExecuteNonQuery();
            fbConnection1.Close();
        }

        private ArrayList verificarCliente(string codTab)
        {
            ArrayList clientes = new ArrayList();
            try
            {         
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                select.CommandText =
                    "SELECT * FROM CLIENTES WHERE COD_TP_CLIENTE = '" + codTab + "'";
                fbConnection1.Open();
                FbDataAdapter datTabPreco = new FbDataAdapter();
                datTabPreco.SelectCommand = select;
                DataSet dsTabela = new DataSet();
                datTabPreco.Fill(dsTabela);
                fbConnection1.Close();
                foreach (DataRow dr in dsTabela.Tables[0].Rows)
                {
                    clientes.Add(dr["RAZAO_SOCIAL"].ToString());
                }
            }
            catch
            {
                fbConnection1.Close();
            }
            return clientes;
        }

        private void btAtualizarTabela_Click(object sender, EventArgs e)
        {
            OleDbConnection _olecon = new OleDbConnection();
            OleDbCommand _oleCmd;
            String _Arquivo;
            string file;
            string path;
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
            if (of.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                file = of.FileName;
                path = file.Replace(of.SafeFileName, "");
                _Arquivo = @file;
                //_StringConexao = String.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0 Xml;HDR=YES;ReadOnly=False';", _Arquivo);
                try
                {
                    _olecon = new OleDbConnection(@"provider=Microsoft.ACE.OLEDB.12.0;data source='" + file + "';Extended Properties=\'Excel 8.0;HDR=NO;IMEX=1;\'");
                    _olecon.Open();

                    _oleCmd = new OleDbCommand();
                    _oleCmd.Connection = _olecon;
                    _oleCmd.CommandType = CommandType.Text;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                OleDbDataAdapter theDataAdapter = new OleDbDataAdapter("SELECT * FROM [Planilha1$]", _olecon);
                DataSet theDS = new DataSet();
                theDataAdapter.Fill(theDS);
                IDictionary<int, double> plan = new Dictionary<int, double>();

                foreach (DataRow dr in theDS.Tables[0].Rows)
                {
                    int item;
                    try
                    {
                        item = Convert.ToInt32(dr[0].ToString());

                    }
                    catch
                    {
                        item = 0;
                    }
                    if (item != 0 )
                    {
                        try
                        {
                            FbCommand select = new FbCommand();
                            select.Connection = fbConnection1;
                            select.CommandText =
                                "SELECT COD_PRODUTO_ITEM_TP FROM ITENS_TP WHERE COD_TABELA_ITEM_TP = '" + tb_cod_tabela.Text +
                                "' and COD_PRODUTO_ITEM_TP = '" + item + "'";
                            fbConnection1.Open();
                            FbDataAdapter datTabela = new FbDataAdapter();
                            datTabela.SelectCommand = select;
                            DataSet dsTabela = new DataSet();
                            datTabela.Fill(dsTabela);
                            fbConnection1.Close();
                            bool existe = false;
                            foreach (DataRow drT in dsTabela.Tables[0].Rows)
                            {
                                existe = true;
                            }
                            if (existe)
                            {
                                try
                                {

                                    FbCommand update = new FbCommand();
                                    update.Connection = fbConnection1;
                                    update.CommandText =
                                        "UPDATE ITENS_TP SET PRECO_PRODUTO_ITEM_TP = '" + dr[3].ToString().Replace("R$ ", "").Replace(".", "").Replace(",", ".") +
                                        "', PRECO_MINIMO_ITEM_TP = '" + dr[3].ToString().Replace("R$ ", "").Replace(".", "").Replace(",", ".") + "'" + 
                                        " WHERE COD_TABELA_ITEM_TP = '" + tb_cod_tabela.Text + "' AND COD_PRODUTO_ITEM_TP = '" + dr[0].ToString() + "'";
                                    fbConnection1.Open();
                                    FbDataAdapter datUpdate = new FbDataAdapter();
                                    datUpdate.UpdateCommand = update;
                                    datUpdate.UpdateCommand.ExecuteNonQuery();
                                    fbConnection1.Close();
                                }
                                catch (Exception a)
                                {
                                    fbConnection1.Close();
                                    MessageBox.Show("Erro ao atualizar item \n" + a.ToString());
                                }
                            }
                            else
                            {
                                try
                                {
                                    FbCommand insert = new FbCommand();
                                    insert.Connection = fbConnection1;
                                    fbConnection1.Open();
                                    insert.CommandText =
                                        "INSERT INTO ITENS_TP (COD_TABELA_ITEM_TP, COD_PRODUTO_ITEM_TP, DESCRICAO_PRODUTO_ITEM_TP, " +
                                        "PRECO_PRODUTO_ITEM_TP, PRECO_MINIMO_ITEM_TP) VALUES ('" + tb_cod_tabela.Text +
                                        "', '" + dr[0].ToString() + "', '" + dr[1].ToString() +
                                        "', '" + dr[3].ToString().Replace("R$ ", "").Replace(".", "").Replace(",", ".") + "','" + 
                                        dr[3].ToString().Replace("R$ ", "").Replace(".", "").Replace(",", ".") + "')";
                                    FbDataAdapter datInsert = new FbDataAdapter();
                                    datInsert.InsertCommand = insert;
                                    datInsert.InsertCommand.ExecuteNonQuery();
                                    fbConnection1.Close();
                                }
                                catch (Exception a)
                                {
                                    fbConnection1.Close();
                                    MessageBox.Show("Erro ao inserir novo item \n" + a.ToString());
                                }
                            }



                        }
                        catch (Exception a)
                        {
                            fbConnection1.Close();
                            MessageBox.Show(a.ToString());
                        }
                    }
                }
                MessageBox.Show("Processo Realizado com Sucesso! \nTabela Atualizada!");
                localizarTabela(tb_cod_tabela.Text, tbNomeTabela.Text);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (dgvItens_tp.SelectedRows.Count > 0)
            {
                for (int i = 0; i < dgvItens_tp.SelectedRows.Count; i++)
                {
                    double preco = 0, preco_minimo = 0;
                    try
                    {
                        preco = Convert.ToDouble(dgvItens_tp.SelectedRows[i].Cells["col_preco"].Value.ToString());
                    }
                    catch { }
                    try
                    {
                        preco_minimo = Convert.ToDouble(dgvItens_tp.SelectedRows[i].Cells["col_preco_minimo"].Value.ToString());
                    }
                    catch { }
                    double porc = 0;
                    try
                    {
                        porc = Convert.ToDouble(tb_porc.Text);
                    }
                    catch { }
                    try
                    {
                        preco = preco + ((preco * porc) / 100);
                    }
                    catch { }
                    try
                    {
                        preco_minimo = preco_minimo + ((preco_minimo * porc) / 100);
                    }
                    catch { }
                    dgvItens_tp.SelectedRows[i].Cells["col_preco"].Value = preco.ToString("n2");
                    dgvItens_tp.SelectedRows[i].Cells["col_preco_minimo"].Value = preco_minimo.ToString("n2");


                }
                salvar();
            }
            else
            {
                MessageBox.Show("Por favor, selecione ao menos uma linha para acertar os preços. ");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {

            form_forma_pgto localiza_forma = new form_forma_pgto();
            try
            {
                localiza_forma.busca_forma_escolhida = true;
                localiza_forma.ShowDialog();
            }
            finally
            {
                localiza_forma.Dispose();
                //MessageBox.Show(localiza_peca.peca_escolhida);
                cb_forma_pgto.Text = localiza_forma.forma_pgto_escolhida;
            }
        }
    }
}