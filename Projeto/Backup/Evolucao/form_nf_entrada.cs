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
    public partial class form_nf_entrada : Form
    {
        public string cod_a_abrir;
        public bool abrir;
        double valor_total;
        string x;
        public form_nf_entrada()
        {
            InitializeComponent();
        }

        private void procura_item(string item)
        {
            
            this.datEstoque.SelectCommand.CommandText =
            "SELECT * FROM ESTOQUE WHERE COD_BARRAS_ITEM_FABRICANTE = '" + item + "'";
            this.fbConnection1.Open();
            this.datEstoque.SelectCommand.Connection = fbConnection1;
            this.datEstoque.SelectCommand.ExecuteNonQuery();
            this.fbConnection1.Close();
            datEstoque.Fill(ESTOQUE);


        
        }
        /*
        private void tb_cod_barras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                //tb_vendas.Focus();
                e.Handled = true;
                SendKeys.Send("{TAB}");
                x = tb_cod_barras.Text;
                try
                {
                    procura_item(x);


                }
                catch
                {
                    MessageBox.Show("Erro na leitura do código, por favor passe de novo");
                    tb_cod_barras.Text = "";
                    return;
                }
                if (tb_item_item.Text == "")
                {
                    MessageBox.Show("Item não cadastrado, cadastre por favor");
                    form_estoque novo = new form_estoque();

                    novo.novo_item = true;
                    novo.cod_a_ser = x;
                    //MessageBox.Show(novo.cod_a_ser);
                    novo.Show();
                    
                }
                else
                {
                    tb_qtde.Focus();
                }
                

            }
        }
        */
        private void bt_localizar_item_Click(object sender, EventArgs e)
        {
            form_localiza_produto localiza_item = new form_localiza_produto();
            try
            {
                localiza_item.buscar = true;
                localiza_item.ShowDialog();
            }
            finally
            {
                localiza_item.Dispose();
                if (localiza_item.cod_produto_escolhido == "")
                { }
                else
                {
                    tb_descricao_item.Text = localiza_item.descricao_completa_produto_escolhido;
                    tb_cod_item.Text = localiza_item.cod_produto_escolhido;
                   
                    tb_item_item.Text = localiza_item.grupo_escolhido;

                }
            }

        }

        private void bt_adicionar_item_Click(object sender, EventArgs e)
        {
            if (tb_pedido_compra.Text == "")
                tb_pedido_compra.Text = "0";
            inserir_itens(tb_cod_item.Text, tb_item_item.Text + " - " + tb_descricao_item.Text, tb_qtde.Text, tb_valor_unit.Text, tb_pedido_compra.Text);
            dsItens_nf_entrada.Clear();
            localizar_itens();
            dsEstoque.Clear();
            tb_qtde.Text = "";
            tb_valor_unit.Text = "";
            somar_itens();
        }

        public void localizar_itens()
        {
            dsItens_nf_entrada.Clear();
            this.datItens_nf_entrada.SelectCommand.CommandText =
            "SELECT * FROM ITENS_NF_ENTRADA WHERE COD_NOTA_ITENS_NF_ENT = '" + tb_cod.Text + "'";
            this.fbConnection1.Open();
            this.datItens_nf_entrada.SelectCommand.Connection = fbConnection1;
            this.datItens_nf_entrada.SelectCommand.ExecuteNonQuery();
            datItens_nf_entrada.Fill(ITENS_NF_ENTRADA);
            this.fbConnection1.Close();

        }

        public void inserir_itens(string cod, string item, string qtde, string valor, string cod_ped)
        {
            //string data_atual = DateTime.Now.ToShortDateString();
            try
            {
                double valor_total_item = 0;
                
                try
                {
                    valor_total_item = Convert.ToDouble(valor) * Convert.ToDouble(qtde);
                }
                catch
                {
                    valor_total_item = 0;
                }
                if (cod == "")
                    cod = "null";
                else
                    cod = "'" + cod + "'";
                if (item == "")
                    item = "null";
                else
                    item = "'" + item + "'";
                if (qtde == "")
                    qtde = "null";
                else
                    qtde = "'" + qtde + "'";
                if (valor == "")
                    valor = "null";
                else
                    valor = "'" + valor + "'";
                if (cod_ped == "")
                    cod_ped = "null";
                else
                    cod_ped = "'" + cod_ped + "'";
                string icms = "null", ipi = "null", iva = "null", cst = "null", cfop = "null";
                buscar_informacoes_de_tributacao(cod, out icms, out ipi, out iva, out cst, out cfop);

                
                this.datItens_nf_entrada.InsertCommand.CommandText =
                "INSERT INTO ITENS_NF_ENTRADA (COD_ITENS_NF_ENT, ITEM_ITENS_NF_ENT, QTDE_ITENS_NF_ENT, " +
                "VALOR_ITENS_NF_ENT, N_NOTA_ITENS_NF_ENT, FORN_ITENS_NF_ENT, DATA_ENT_ITENS_NF_ENT, " + 
                "PEDIDO_COMPRA_ITENS_NF_ENT, COD_NOTA_ITENS_NF_ENT, VALOR_TOTAL_ITENS_NF_ENT, " + 
                "CFOP_ITENS_NF_ENT, ICMS_ITENS_NF_ENT, IPI_ITENS_NF_ENT, IVA_ITENS_NF_ENT, CST_ITENS_NF_ENT) VALUES " +
                "(" + cod + "," + item + "," + qtde.Replace(",",".") + "," + valor.Replace(",",".") + "," +
                "'" + tb_n_nf.Text + "','" + tb_fornecedor.Text + "','" + tb_data_entrada.Text.Replace("/", ".") + 
                "', " + cod_ped + ", '" + tb_cod.Text + "','" + valor_total_item.ToString().Replace(".","").Replace(",",".") + 
                "', " + cfop + "," + icms + "," + ipi + "," + iva + "," + cst + ")";
                this.fbConnection1.Open();
                this.datItens_nf_entrada.InsertCommand.Connection = fbConnection1;
                this.datItens_nf_entrada.InsertCommand.ExecuteNonQuery();
                this.fbConnection1.Close();
            }
            catch 
            {
                fbConnection1.Close();
                MessageBox.Show("Erro na inserção");
            }


        }

        private void buscar_informacoes_de_tributacao(string cod, out string icms, out string ipi, out string iva, out string cst, out string cfop)
        {
            icms = "null"; ipi = "null"; iva = "null"; cst = "null"; cfop = "null";
            try
            {
                FbCommand comando = new FbCommand();
                comando.Connection = fbConnection1;
                fbConnection1.Open();
                comando.CommandText = "SELECT * FROM PRODUTOS WHERE COD_PRODUTO = " + cod + "";
                FbDataAdapter produtosDataAdapter = new FbDataAdapter();
                produtosDataAdapter.SelectCommand = comando;
                DataSet produtosDataSet = new DataSet();
                produtosDataAdapter.Fill(produtosDataSet);
                DataRow dr = produtosDataSet.Tables[0].Rows[0];
                if(dr["ALIQUOTA_ICMS_PRODUTO"].ToString() != "")
                    icms = "'" + dr["ALIQUOTA_ICMS_PRODUTO"].ToString() + "'";
                if (dr["ALIQUOTA_IPI_PRODUTO"].ToString() != "")
                    ipi = "'" + dr["ALIQUOTA_IPI_PRODUTO"].ToString() + "'";
                if (dr["IVA_PRODUTO"].ToString() != "")
                    iva = "'" + dr["IVA_PRODUTO"].ToString() + "'";
                if (dr["ORIGEM_PRODUTO"].ToString() != "")
                    cst = "'" + dr["ORIGEM_PRODUTO"].ToString()[0] + "'";
                if (dr["CFOP_ENTRADA_PRODUTO"].ToString() != "")
                    cfop = "'" + dr["CFOP_ENTRADA_PRODUTO"].ToString() + "'";
                fbConnection1.Close();
            }
            catch(Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private void salva_registro_Click(object sender, EventArgs e)
        {
            Atualizar();
        }

        private void Atualizar()
        {
            this.BindingContext[dsNota_fiscal_entrada, "NOTA_FISCAL_ENTRADA"].EndCurrentEdit();
            fbConnection1.Open();
            if (dsNota_fiscal_entrada.HasChanges())
            {
                datNota_fiscal_entrada.UpdateCommand = cbNota_fiscal_entrada.GetUpdateCommand();
                datNota_fiscal_entrada.InsertCommand = cbNota_fiscal_entrada.GetInsertCommand();
                datNota_fiscal_entrada.DeleteCommand = cbNota_fiscal_entrada.GetDeleteCommand();
                datNota_fiscal_entrada.Update(dsNota_fiscal_entrada, "NOTA_FISCAL_ENTRADA");
                dsNota_fiscal_entrada.AcceptChanges();
            }
            fbConnection1.Close();

            this.BindingContext[dsItens_nf_entrada, "ITENS_NF_ENTRADA"].EndCurrentEdit();
            fbConnection1.Open();
            if (dsItens_nf_entrada.HasChanges())
            {
                datItens_nf_entrada.UpdateCommand = cbItens_nf_entrada.GetUpdateCommand();
                datItens_nf_entrada.InsertCommand = cbItens_nf_entrada.GetInsertCommand();
                datItens_nf_entrada.DeleteCommand = cbItens_nf_entrada.GetDeleteCommand();
                datItens_nf_entrada.Update(dsItens_nf_entrada, "ITENS_NF_ENTRADA");
                dsItens_nf_entrada.AcceptChanges();
            }
            fbConnection1.Close();

            this.BindingContext[dsFatura_nf_entrada, "FATURA_NF_ENTRADA"].EndCurrentEdit();
            fbConnection1.Open();
            if (dsFatura_nf_entrada.HasChanges())
            {
                datFatura_nf_entrada.UpdateCommand = cbFatura_nf_entrada.GetUpdateCommand();
                datFatura_nf_entrada.InsertCommand = cbFatura_nf_entrada.GetInsertCommand();
                datFatura_nf_entrada.DeleteCommand = cbFatura_nf_entrada.GetDeleteCommand();
                datFatura_nf_entrada.Update(dsFatura_nf_entrada, "FATURA_NF_ENTRADA");
                dsFatura_nf_entrada.AcceptChanges();
            }
            fbConnection1.Close();
        }

        private void bt_somar_Click(object sender, EventArgs e)
        {
            somar_itens();
        }

        private void somar_itens()
        {
            for (int i = 0; i < dgvItens.RowCount; i++)
            {
                try
                {
                    //MessageBox.Show(valor_total.ToString());
                    double valor_item = 0;
                    valor_item = (Convert.ToDouble(dgvItens.Rows[i].Cells["col_valor_item"].Value.ToString()) *
                             Convert.ToDouble(dgvItens.Rows[i].Cells["col_qtde"].Value.ToString()));
                    valor_total = valor_total + valor_item;
                    dgvItens.Rows[i].Cells["col_valor_total"].Value = valor_item.ToString("n2").Replace(".", "");
                 
                }
                catch
                {

                }

            }
            try
            {
                valor_total = valor_total + Convert.ToDouble(tb_outros_valores.Text);
            }
            catch { }
            tb_total.Text = valor_total.ToString("n2");
            valor_total = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cb_confirmada.Checked == false)
            {
                if (tb_data_entrada.Text == "")
                {
                    MessageBox.Show("Coloque a data de entrada da NF por favor");
                }
                else
                {
                    try
                    {
                        for (int i = 0; i < dgvItens.RowCount; i++)
                        {
                            inserir_no_estoque(dgvItens.Rows[i].Cells["col_qtde"].Value.ToString(), dgvItens.Rows[i].Cells["col_cod_item"].Value.ToString());
                            acertar_valores_produto(dgvItens.Rows[i].Cells["col_cod_item"].Value.ToString(), dgvItens.Rows[i].Cells["col_cfop"].Value.ToString(),
                                dgvItens.Rows[i].Cells["col_iva"].Value.ToString().Replace(".", "").Replace(",", "."), dgvItens.Rows[i].Cells["col_icms"].Value.ToString().Replace(".", "").Replace(",", "."),
                                dgvItens.Rows[i].Cells["col_ipi"].Value.ToString().Replace(".", "").Replace(",", "."), dgvItens.Rows[i].Cells["col_valor_item"].Value.ToString().Replace(".", "").Replace(",", "."),
                                dgvItens.Rows[i].Cells["col_cst"].Value.ToString());
                            if (dgvItens.Rows[i].Cells["col_itens_ped"].Value.ToString() != "")
                            {
                                update_item_ped(dgvItens.Rows[i].Cells["col_itens_ped"].Value.ToString());
                                update_item_req(dgvItens.Rows[i].Cells["col_itens_ped"].Value.ToString());
                                update_custos_os(dgvItens.Rows[i].Cells["col_itens_ped"].Value.ToString(), Convert.ToDouble(dgvItens.Rows[i].Cells["col_valor_item"].Value.ToString()),
                                    dgvItens.Rows[i].Cells["col_item"].Value.ToString(), Convert.ToDouble(dgvItens.Rows[i].Cells["col_qtde"].Value.ToString()));
                            }


                        }
                        cb_confirmada.Checked = true;
                        Atualizar();
                        MessageBox.Show("Nota cadastrada");
                    }
                    catch
                    {
                        MessageBox.Show("Erro na Nota");
                    }
                }
            }
            else
            {
                MessageBox.Show("Nota Fiscal já cadastrada");
            }
        }
        private void update_custos_os(string n_item_ped, double valor, string descricao, double qtde)
        {
            try
            {
                double valor_total = valor * qtde;
                string _os = null;
                comando_select.CommandText = "SELECT * FROM ITENS_PEDIDO_COMPRA WHERE COD_ITEM_PED = '" + n_item_ped + "'";
                DataSet ped = new DataSet();
                fbConnection1.Open();
                datItens_ped.SelectCommand = comando_select;
                datItens_ped.Fill(ped);
                fbConnection1.Close();
                foreach (DataRow dr in ped.Tables[0].Rows)
                {
                    _os = dr["OP_ITEM_PED"].ToString();
                }
                if (_os == "")
                    _os = "null";
                else
                    _os = "'" + _os + "'";
                this.datDespesas_molde.InsertCommand.CommandText =
                    "INSERT INTO DESPESAS_MOLDE (VALOR_DESPESA, FORNECEDOR_DESPESA, OBS_DESPESA, OS_DESPESA) " +
                     "VALUES ('" + valor_total.ToString().Replace(".", "").Replace("/", ".") + "','" + tb_fornecedor.Text + "','" + descricao + "'," + _os + ")";
                this.fbConnection1.Open();
                this.datDespesas_molde.InsertCommand.Connection = fbConnection1;
                this.datDespesas_molde.InsertCommand.ExecuteNonQuery();
                this.fbConnection1.Close();
            }
            catch
            {
                MessageBox.Show("Erro, verifique os campos");
                fbConnection1.Close();
            }
        }

        private void update_item_req(string n_item_ped)
        {
            try
            {
                string _cod_req = null;
                comando_select.CommandText = "SELECT * FROM ITENS_PEDIDO_COMPRA WHERE COD_ITEM_PED = '" + n_item_ped + "'";
                DataSet ped = new DataSet();
                fbConnection1.Open();
                datItens_ped.SelectCommand = comando_select;
                datItens_ped.Fill(ped);
                fbConnection1.Close();
                foreach (DataRow dr in ped.Tables[0].Rows)
                {
                    _cod_req = dr["COD_ITEM_REQ_ITEM_PED"].ToString();
                }

                if (_cod_req != "")
                {
                    this.datItens_req.UpdateCommand.CommandText =
                    "UPDATE ITENS_REQUISICAO SET SITUACAO_ATUAL_ITEM_REQ = 'ITEM CHEGOU NO DIA " + tb_data_entrada.Text + " COD. ENTRADA: " + tb_cod.Text + "' WHERE COD_ITEM_REQ = '" + _cod_req + "'";
                    this.fbConnection1.Open();
                    this.datItens_req.UpdateCommand.Connection = fbConnection1;
                    this.datItens_req.UpdateCommand.ExecuteNonQuery();
                    this.fbConnection1.Close();
                }
            }
            catch
            {
                MessageBox.Show("Erro na inserção do status no Item da Requisição");
                fbConnection1.Close();
            }
        }

        private void update_item_ped(string n_item_ped)
        {
            try
            {
                this.datItens_ped.UpdateCommand.CommandText =
                "UPDATE ITENS_PEDIDO_COMPRA SET CHEGOU_ITEM_PED = '1' WHERE COD_ITEM_PED = '" + n_item_ped + "'";
                this.fbConnection1.Open();
                this.datItens_ped.UpdateCommand.Connection = fbConnection1;
                this.datItens_ped.UpdateCommand.ExecuteNonQuery();
                this.fbConnection1.Close();

                this.datItens_ped.UpdateCommand.CommandText =
                "UPDATE ITENS_PEDIDO_COMPRA SET COD_NF_ENTRADA_ITEM_PED = '" + tb_n_nf.Text + "' WHERE COD_ITEM_PED = '" + n_item_ped + "'";
                this.fbConnection1.Open();
                this.datItens_ped.UpdateCommand.Connection = fbConnection1;
                this.datItens_ped.UpdateCommand.ExecuteNonQuery();
                this.fbConnection1.Close();

                this.datItens_ped.UpdateCommand.CommandText =
                "UPDATE ITENS_PEDIDO_COMPRA SET DATA_ENTRADA_ITEM_PED = '" + Convert.ToDateTime(tb_data_entrada.Text).ToShortDateString().Replace("/", ".") + "' WHERE COD_ITEM_PED = '" + n_item_ped + "'";
                this.fbConnection1.Open();
                this.datItens_ped.UpdateCommand.Connection = fbConnection1;
                this.datItens_ped.UpdateCommand.ExecuteNonQuery();
                this.fbConnection1.Close();
            }
            catch
            {
                MessageBox.Show("Erro na Inserção de informação nos Itens do Pedido de Compra");
                fbConnection1.Close();
            }
        }

        private void acertar_valores_produto(string cod, string cfop, string iva, string ipi, string icms, string valor_total, string cst)
        {
            try
            {
                //CFOP
                valor_total = valor_total.ToString().Replace(".", ",");
                this.datProdutos.UpdateCommand.CommandText =
                 "UPDATE PRODUTOS SET CFOP_ENTRADA_PRODUTO = '" + cfop + "' WHERE COD_PRODUTO = '" + cod + "'";
                this.fbConnection1.Open();
                this.datProdutos.UpdateCommand.Connection = fbConnection1;
                this.datProdutos.UpdateCommand.ExecuteNonQuery();
                this.fbConnection1.Close();
                string _cst = "null";
                //ORIGEM MERCADORIA
                if (cst[0].ToString() == "0")
                {
                    _cst = "'0 - Nacional'";
                }
                if (cst[0].ToString() == "1")
                {
                    _cst = "'1 - Estrangeira - Importação direta'";
                }
                if (cst[0].ToString() == "2")
                {
                    _cst = "'2 - Estrangeira - Adquirida no mercado interno'";
                }

                this.datProdutos.UpdateCommand.CommandText =
                     "UPDATE PRODUTOS SET ORIGEM_PRODUTO = " + _cst + " WHERE COD_PRODUTO = '" + cod + "'";
                this.fbConnection1.Open();
                this.datProdutos.UpdateCommand.Connection = fbConnection1;
                this.datProdutos.UpdateCommand.ExecuteNonQuery();
                this.fbConnection1.Close();


                string _iva = "null";
                if (iva != "")
                {
                    _iva = "'" + iva + "'";
                    this.datProdutos.UpdateCommand.CommandText =
                     "UPDATE PRODUTOS SET IVA_PRODUTO = " + _iva + " WHERE COD_PRODUTO = '" + cod + "'";
                    this.fbConnection1.Open();
                    this.datProdutos.UpdateCommand.Connection = fbConnection1;
                    this.datProdutos.UpdateCommand.ExecuteNonQuery();
                    this.fbConnection1.Close();
                }
                string _icms = "null";
                if (icms != "")
                {
                    _icms = "'" + icms + "'";
                    this.datProdutos.UpdateCommand.CommandText =
                     "UPDATE PRODUTOS SET ALIQUOTA_ICMS_PRODUTO = " + _icms + " WHERE COD_PRODUTO = '" + cod + "'";
                    this.fbConnection1.Open();
                    this.datProdutos.UpdateCommand.Connection = fbConnection1;
                    this.datProdutos.UpdateCommand.ExecuteNonQuery();
                    this.fbConnection1.Close();
                }
                string _ipi = "null";
                if (ipi != "")
                {
                    _ipi = "'" + ipi + "'";
                    this.datProdutos.UpdateCommand.CommandText =
                     "UPDATE PRODUTOS SET ALIQUOTA_IPI_PRODUTO = " + _ipi + " WHERE COD_PRODUTO = '" + cod + "'";
                    this.fbConnection1.Open();
                    this.datProdutos.UpdateCommand.Connection = fbConnection1;
                    this.datProdutos.UpdateCommand.ExecuteNonQuery();
                    this.fbConnection1.Close();
                }
                try
                {
                    double bc_com_ipi, valor_icms_normal, valor_icms_com_st, valor_ipi;
                    double bc_normal = Convert.ToDouble(valor_total);
                    valor_ipi = bc_normal * Convert.ToDouble(ipi) / 100;
                    bc_com_ipi = bc_normal + valor_ipi;
                    valor_icms_normal = Convert.ToDouble(icms) / 100 * bc_normal;
                    valor_icms_com_st = (bc_com_ipi + (bc_com_ipi * Convert.ToDouble(iva)) / 100) * Convert.ToDouble(icms) / 100 - valor_icms_normal;
                    double valor_custo_total = bc_normal + valor_ipi + valor_icms_com_st;

                    string _custo_total = "null";
                    if (valor_custo_total > 0)
                        _custo_total = valor_custo_total.ToString("n2").Replace(".", "").Replace(",", ".");
                    string custo = "";
                    if (valor_total != "")
                        custo = "'" + _custo_total + "'";
                    if (custo == "'null'")
                        custo = "null";
                    double venda = valor_custo_total * 2;
                    string valor_venda = "null";
                    if (venda > 0)
                        valor_venda = "'" + venda.ToString("n2").Replace(".", "").Replace(",", ".") + "'";

                    /*
                    double bc_com_ipi, valor_icms_normal, valor_icms_com_st, valor_ipi;
                    double bc_normal = Convert.ToDouble(valor_total);
                    valor_ipi = bc_normal * Convert.ToDouble(ipi) / 100;
                    bc_com_ipi = bc_normal + valor_ipi;
                    valor_icms_normal = bc_normal + (Convert.ToDouble(icms)/100 * bc_normal);
                    valor_icms_com_st = ((bc_com_ipi + (bc_com_ipi * Convert.ToDouble(iva)/100)) * Convert.ToDouble(icms)/100) - valor_icms_normal;
                    double valor_custo_total = bc_normal + valor_ipi + valor_icms_com_st;

                    string _custo_total = "null";
                    if (valor_custo_total > 0)
                        _custo_total = valor_custo_total.ToString("n2");
                     * */
                    this.datProdutos.UpdateCommand.CommandText =
                     "UPDATE PRODUTOS SET CUSTO_PRODUTO = " + custo + ", VALOR_VENDA_PRODUTOR_PRODUTO = " + valor_venda + " WHERE COD_PRODUTO = '" + cod + "'";
                    this.fbConnection1.Open();
                    this.datProdutos.UpdateCommand.Connection = fbConnection1;
                    this.datProdutos.UpdateCommand.ExecuteNonQuery();
                    this.fbConnection1.Close();
                }
                catch
                {
                    fbConnection1.Close();
                }
            }
            catch
            {
                MessageBox.Show("Erro na atualização do estoque");
                fbConnection1.Close();
            }
        }

        private void inserir_no_estoque(string _qtde, string cod)
        {
            try
            {
                decimal qtde = Convert.ToDecimal(_qtde);
                this.datProdutos.UpdateCommand.CommandText =
                "UPDATE PRODUTOS SET ESTOQUE_ATUAL_PRODUTO = ESTOQUE_ATUAL_PRODUTO + " + qtde.ToString().Replace(".", "").Replace(",", ".") + " WHERE COD_PRODUTO = '" + cod + "'";
                this.fbConnection1.Open();
                this.datProdutos.UpdateCommand.Connection = fbConnection1;
                this.datProdutos.UpdateCommand.ExecuteNonQuery();
                this.fbConnection1.Close();

                this.datProdutos.UpdateCommand.CommandText =
                "UPDATE PRODUTOS SET ESTOQUE_MEDIO_PRODUTO = ESTOQUE_MEDIO_PRODUTO + " + qtde.ToString().Replace(".", "").Replace(",", ".") + " WHERE COD_PRODUTO = '" + cod + "'";
                this.fbConnection1.Open();
                this.datProdutos.UpdateCommand.Connection = fbConnection1;
                this.datProdutos.UpdateCommand.ExecuteNonQuery();
                this.fbConnection1.Close();
                /*
                this.datEstoque.UpdateCommand.CommandText =
                "UPDATE ESTOQUE SET ESTOQUE_ATUAL_ESTOQUE = ESTOQUE_ATUAL_ESTOQUE + " + qtde.ToString().Replace(".", "").Replace(",", ".") + " WHERE COD_ESTOQUE = '" + cod + "'";
                this.fbConnection1.Open();
                this.datEstoque.UpdateCommand.Connection = fbConnection1;
                this.datEstoque.UpdateCommand.ExecuteNonQuery();
                this.fbConnection1.Close();
                */
                
            }
            catch
            {
                MessageBox.Show("Erro na atualização do estoque");
                fbConnection1.Close();
            }
        }
        private void novo_registro_Click(object sender, EventArgs e)
        {
            try
            {
                dsItens_nf_entrada.Clear();
                dsNota_fiscal_entrada.Clear();
                dsFatura_nf_entrada.Clear();

                this.datNota_fiscal_entrada.DeleteCommand.CommandText =
                "DELETE FROM NOTA_FISCAL_ENTRADA WHERE N_NF_ENTRADA = 'novo'";
                this.fbConnection1.Open();
                this.datNota_fiscal_entrada.DeleteCommand.Connection = fbConnection1;
                this.datNota_fiscal_entrada.DeleteCommand.ExecuteNonQuery();
                this.fbConnection1.Close();

                this.datNota_fiscal_entrada.InsertCommand.CommandText =
                    "INSERT INTO NOTA_FISCAL_ENTRADA (N_NF_ENTRADA) VALUES ('novo') ";
                this.fbConnection1.Open();
                this.datNota_fiscal_entrada.InsertCommand.Connection = fbConnection1;
                this.datNota_fiscal_entrada.InsertCommand.ExecuteNonQuery();
                this.fbConnection1.Close();

                this.datNota_fiscal_entrada.SelectCommand.CommandText =
                "SELECT * FROM NOTA_FISCAL_ENTRADA WHERE N_NF_ENTRADA = 'novo'";
                this.fbConnection1.Open();
                this.datNota_fiscal_entrada.SelectCommand.Connection = fbConnection1;
                this.datNota_fiscal_entrada.SelectCommand.ExecuteNonQuery();
                datNota_fiscal_entrada.Fill(NOTA_FISCAL_ENTRADA);
                this.fbConnection1.Close();
                tb_n_nf.Focus();
            }
            catch
            {
                this.fbConnection1.Close();
                
                this.datNota_fiscal_entrada.DeleteCommand.CommandText =
                "DELETE FROM NOTA_FISCAL_ENTRADA WHERE N_NF_ENTRADA = 'novo'";
                this.fbConnection1.Open();
                this.datNota_fiscal_entrada.DeleteCommand.Connection = fbConnection1;
                this.datNota_fiscal_entrada.DeleteCommand.ExecuteNonQuery();
                this.fbConnection1.Close();

                this.datNota_fiscal_entrada.InsertCommand.CommandText =
                    "INSERT INTO NOTA_FISCAL_ENTRADA (N_NF_ENTRADA) VALUES ('novo') ";
                this.fbConnection1.Open();
                this.datNota_fiscal_entrada.InsertCommand.Connection = fbConnection1;
                this.datNota_fiscal_entrada.InsertCommand.ExecuteNonQuery();
                this.fbConnection1.Close();

                this.datNota_fiscal_entrada.SelectCommand.CommandText =
                "SELECT * FROM NOTA_FISCAL_ENTRADA WHERE N_NF_ENTRADA = 'novo'";
                this.fbConnection1.Open();
                this.datNota_fiscal_entrada.SelectCommand.Connection = fbConnection1;
                this.datNota_fiscal_entrada.SelectCommand.ExecuteNonQuery();
                datNota_fiscal_entrada.Fill(NOTA_FISCAL_ENTRADA);
                this.fbConnection1.Close();
                tb_n_nf.Focus();
            }
            datForn.Fill(FORNECEDORES);
        }

        private void bt_forn_Click(object sender, EventArgs e)
        {
            form_localiza_forn localiza_forn = new form_localiza_forn(true);
            try
            {
                localiza_forn.ShowDialog();
            }
            finally
            {
                localiza_forn.Dispose();
                tb_fornecedor.Text = localiza_forn.razao_forn_escolhido;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            localiza_nf();
        }

        private void localiza_nf()
        {
            form_localiza_nf_entrada localiza_nf = new form_localiza_nf_entrada();
            try
            {
                localiza_nf.ShowDialog();
            }
            finally
            {
                localiza_nf.Dispose();
                try
                {
                    dsNota_fiscal_entrada.Clear();
                    this.datNota_fiscal_entrada.SelectCommand.CommandText =
                    "SELECT * FROM NOTA_FISCAL_ENTRADA WHERE COD_CONTROLE_NF_ENTRADA = '" + localiza_nf.nf_escolhida + "'";
                    this.fbConnection1.Open();
                    this.datNota_fiscal_entrada.SelectCommand.Connection = fbConnection1;
                    this.datNota_fiscal_entrada.SelectCommand.ExecuteNonQuery();
                    datNota_fiscal_entrada.Fill(NOTA_FISCAL_ENTRADA);
                    this.fbConnection1.Close();

                    

                    localizar_itens();
                    selecionar_dup();
                }
                catch {
                    fbConnection1.Close();
                    MessageBox.Show("Erro na localização, tente outra vez");
                }
                
            }
        }

        private void apaga_registro_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("O registro será excluído permanentemente, tem certeza?",
               "Confirma a exclusão?", MessageBoxButtons.YesNo))
            {
                if (cb_confirmada.Checked != true)
                {
                    try
                    {
                        this.datItens_nf_entrada.DeleteCommand.CommandText =
                                "DELETE FROM ITENS_NF_ENTRADA WHERE N_NOTA_ITENS_NF_ENT = '" + tb_cod.Text + "'";
                        this.fbConnection1.Open();
                        this.datItens_nf_entrada.DeleteCommand.Connection = fbConnection1;
                        this.datItens_nf_entrada.DeleteCommand.ExecuteNonQuery();
                        this.fbConnection1.Close();

                        this.datNota_fiscal_entrada.DeleteCommand.CommandText =
                                "DELETE FROM NOTA_FISCAL_ENTRADA WHERE COD_CONTROLE_NF_ENTRADA = '" + tb_cod.Text + "'";
                        this.fbConnection1.Open();
                        this.datNota_fiscal_entrada.DeleteCommand.Connection = fbConnection1;
                        this.datNota_fiscal_entrada.DeleteCommand.ExecuteNonQuery();
                        this.fbConnection1.Close();

                        



                        localiza_nf();
                    }
                    catch
                    {
                        MessageBox.Show("Erro ao excluir NF");
                    }
                }
                else
                {
                    MessageBox.Show("Essa Nota Fiscal não pode ser excluida");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form_pesquisa_pedido_compra ped = new form_pesquisa_pedido_compra();
            try
            {
                ped.ShowDialog();
            }
            finally
            {
                ped.Dispose();
                tb_pedido_compra.Text = ped.cod;
            }
        }

        private void buscar_descricao_cp()
        {
            string frase = "";
            for (int i = 0; i < dgvItens.RowCount; i++)
            {
                string _item = "", _os = "";
                comando_select.CommandText = "SELECT * FROM ITENS_PEDIDO_COMPRA WHERE COD_ITEM_PED = '" + dgvItens.Rows[i].Cells["col_itens_ped"].Value.ToString() + "'";
                DataSet itens = new DataSet();
                fbConnection1.Open();
                datItens_ped.SelectCommand = comando_select;
                datItens_ped.Fill(itens);
                fbConnection1.Close();
                foreach (DataRow dr in itens.Tables[0].Rows)
                {
                    _item = dr["ITEM_ITEM_PED"].ToString();
                    _os = dr["OP_ITEM_PED"].ToString();
                }
                string subfrase = "";
                if (_os != "")
                    subfrase = _item + " OS: " + _os + " /";
                else
                    subfrase = _item + " /";
                if (frase.Contains(subfrase) == false)
                {
                    frase = frase + subfrase;
                }

            }
            //tb_descricao_cp.Text = frase;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (tb_descricao_cp.Text == "")
            {
                buscar_descricao_cp();
            }
            try
            {

                DateTime _data = Convert.ToDateTime(tb_data_dup.Text);
                double _valor = Convert.ToDouble(tb_valor_dup.Text);
                this.datFatura_nf_entrada.InsertCommand.CommandText =
                "INSERT INTO FATURA_NF_ENTRADA (DATA_VENC_FATURA_ENT, VALOR_FATURA_ENT, COD_NF_ENTRADA_FATURA_ENT) " +
                "VALUES " +
                "('" + _data.ToShortDateString().Replace("/",".") + "','" + _valor.ToString("n2").Replace(".","").Replace(",",".") + "','" + tb_cod.Text + "')";
                this.fbConnection1.Open();
                this.datFatura_nf_entrada.InsertCommand.Connection = fbConnection1;
                this.datFatura_nf_entrada.InsertCommand.ExecuteNonQuery();
                this.fbConnection1.Close();
                selecionar_dup();

            }
            catch
            {
                fbConnection1.Close();
                MessageBox.Show("Erro na inserção, verifique os dados");
            }
            
        }

        private void selecionar_dup()
        {
            try
            {
                dsFatura_nf_entrada.Clear();
                this.datFatura_nf_entrada.SelectCommand.CommandText =
                    "SELECT * FROM FATURA_NF_ENTRADA WHERE COD_NF_ENTRADA_FATURA_ENT = '" + tb_cod.Text + "'";
                this.fbConnection1.Open();
                this.datFatura_nf_entrada.SelectCommand.Connection = fbConnection1;
                this.datFatura_nf_entrada.SelectCommand.ExecuteNonQuery();
                datFatura_nf_entrada.Fill(FATURA_NF_ENTRADA);
                this.fbConnection1.Close();
            }
            catch
            {
                MessageBox.Show("Erro na seleção de duplicatas");
                fbConnection1.Close();
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (tb_descricao_cp.Text == "")
            {
                MessageBox.Show("Digite ou busque a descrição que será incluída no Contas a pagar");

            }
            else
            {
                if (DialogResult.Yes == MessageBox.Show("Se já houver registros no Contas a Pagar referentes a essa NF, estes serão excluídos",
                   "Confirma?", MessageBoxButtons.YesNo))
                {


                    apagar_itens_cp();
                    for (int i = 0; i < dgvFatura_ent.RowCount; i++)
                    {
                        try
                        {
                            //FALTA COLOCAR A DESCRICAO CORRETA NO CP, PARA ISSO TERÁ QUE FAZER UM LOOP COM TODOS OS ITENS DOS PEDIDOS E GERAR
                            //A SEGUINTE FRASE (1-PORTA MOLDE OS 1043, 2-H13 OS 2030)
                            //FALTA TAMBÉM ATUALIZAR O BANCO COM O MEU


                            DateTime _data = Convert.ToDateTime(dgvFatura_ent.Rows[i].Cells["col_data_fat"].Value.ToString());
                            double _valor = Convert.ToDouble(dgvFatura_ent.Rows[i].Cells["col_valor_fat"].Value.ToString());
                            string _nome_forn = "", _cod_forn = "";
                            comando_select.CommandText = "SELECT * FROM FORNECEDORES WHERE RAZAO_SOCIAL_FORN = '" + tb_fornecedor.Text + "'";
                            DataSet forn = new DataSet();
                            fbConnection1.Open();
                            datForn.SelectCommand = comando_select;
                            datForn.Fill(forn);
                            fbConnection1.Close();
                            foreach (DataRow dr in forn.Tables[0].Rows)
                            {
                                _nome_forn = dr["RAZAO_SOCIAL_FORN"].ToString();
                                _cod_forn = dr["COD_FORN"].ToString();
                            }
                            string plano = "";
                            string cod_plano = "";

                            if (cbPlanos.Text == "")
                            {
                                buscar_plano(dgvItens.Rows[i].Cells["col_itens_ped"].Value.ToString());
                                MessageBox.Show("Escolha um plano de conta para essa NF, por favor");
                            }
                            else
                            {
                                plano = cbPlanos.Text;
                                cod_plano = buscar_cod_plano(plano);
                                plano = "'" + plano + "'";
                                if (_nome_forn != "")
                                {
                                    int dup = i + 1;
                                    this.datContas_a_pagar.InsertCommand.CommandText =
                                        "INSERT INTO CONTAS_A_PAGAR (DATA_PREVISTA_CP, VALOR_CP, COD_FORNECEDOR_CP, RAZAO_FORNECEDOR_CP, DESCRICAO_CP, DUPLICATA_CP, NF_CP, PLANO_CP, COD_PLANO_CP) " +
                                         "VALUES " +
                                         "('" + _data.ToShortDateString().Replace("/", ".") + "','" + _valor.ToString("n2").Replace(".", "").Replace(",", ".") + "','" + _cod_forn + "','" + _nome_forn +
                                         "','" + tb_descricao_cp.Text +
                                         "','" + dup.ToString() + "/" + dgvFatura_ent.RowCount.ToString() + "','" + tb_n_nf.Text + "'," + plano + "," + cod_plano + ")";
                                    this.fbConnection1.Open();
                                    this.datContas_a_pagar.InsertCommand.Connection = fbConnection1;
                                    this.datContas_a_pagar.InsertCommand.ExecuteNonQuery();
                                    this.fbConnection1.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Fornecedor não encontrado ou com dados incompletos.");
                                }
                            }
                        }






                        catch
                        {
                            int n = i + 1;
                            MessageBox.Show("Erro na Inserção da linha " + n.ToString());
                            fbConnection1.Close();
                        }
                    }
                }
            }
        }

        private string buscar_cod_plano(string plano)
        {
            comando_select.CommandText = "SELECT * FROM PLANOS WHERE NOME_PLANO = '" + plano + "'";
            DataSet pl = new DataSet();
            fbConnection1.Open();
            datItens_ped.SelectCommand = comando_select;
            datItens_ped.Fill(pl);
            fbConnection1.Close();
            string _cod = "";
            foreach (DataRow dr in pl.Tables[0].Rows)
            {
                _cod = dr["COD_PLANO"].ToString();
            }
            if (_cod != "")
                _cod = "'" + _cod + "'";
            else
                _cod = "null";
            return _cod;
        }

        private void buscar_plano(string item_ped)
        {
            comando_select.CommandText = "SELECT * FROM ITENS_PEDIDO_COMPRA WHERE COD_ITEM_PED = '" + item_ped + "'";
            DataSet ped = new DataSet();
            fbConnection1.Open();
            datItens_ped.SelectCommand = comando_select;
            datItens_ped.Fill(ped);
            fbConnection1.Close();
            string _plano = "";
            foreach (DataRow dr in ped.Tables[0].Rows)
            {
                _plano = dr["PLANO_ITEM_PED"].ToString();
            }
            cbPlanos.Items.Add(_plano);
        }
        
        private void apagar_itens_cp()
        {
            this.datContas_a_pagar.DeleteCommand.CommandText =
            "DELETE FROM CONTAS_A_PAGAR WHERE NF_CP = '" + tb_n_nf.Text + "' AND RAZAO_FORNECEDOR_CP = '" + tb_fornecedor.Text + "'";
            this.fbConnection1.Open();
            this.datContas_a_pagar.DeleteCommand.Connection = fbConnection1;
            this.datContas_a_pagar.DeleteCommand.ExecuteNonQuery();
            this.fbConnection1.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            apagar_itens_cp();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            form_planos planos = new form_planos();
            try
            {
                planos.ShowDialog();

            }
            finally
            {
                cbPlanos.Text = planos.nome_escolhido;

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            buscar_descricao_cp();
            for (int j = 0; j < dgvItens.RowCount; j++)
            {
                buscar_plano(dgvItens.Rows[j].Cells["col_itens_ped"].Value.ToString());
            }
        }

        private void form_nf_entrada_Load(object sender, EventArgs e)
        {
            if (abrir == true)
            {
                try
                {
                    dsNota_fiscal_entrada.Clear();
                    this.datNota_fiscal_entrada.SelectCommand.CommandText =
                    "SELECT * FROM NOTA_FISCAL_ENTRADA WHERE COD_CONTROLE_NF_ENTRADA = '" + cod_a_abrir + "'";
                    this.fbConnection1.Open();
                    this.datNota_fiscal_entrada.SelectCommand.Connection = fbConnection1;
                    this.datNota_fiscal_entrada.SelectCommand.ExecuteNonQuery();
                    datNota_fiscal_entrada.Fill(NOTA_FISCAL_ENTRADA);
                    this.fbConnection1.Close();



                    localizar_itens();
                    selecionar_dup();
                }
                catch
                {
                    fbConnection1.Close();
                    MessageBox.Show("Erro na localização, tente outra vez");
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (tb_n_pedido_compra.Text == "")
                MessageBox.Show("Insira um pedido por favor");
            else
            {
                comando_select.CommandText = "SELECT * FROM ITENS_PEDIDO_COMPRA WHERE N_PEDIDO_ITEM_PED = '" + tb_n_pedido_compra.Text + "'";
                DataSet ped = new DataSet();
                fbConnection1.Open();
                datItens_ped.SelectCommand = comando_select;
                datItens_ped.Fill(ped);
                fbConnection1.Close();
                string[] _cod = new string[100];
                string[] _item = new string[100];
                string unidade = "";
                string[] _descricao = new string[100];
                string[] _qtde = new string[100];
                string[] _valor_unit = new string[100];
                string[] _cod_item_pc = new string[100];
                int i = 0;
                foreach (DataRow dr in ped.Tables[0].Rows)
                {
                    _cod[i] = dr["COD_ESTOQUE_ITEM_PED"].ToString();
                    _item[i] = dr["ITEM_ITEM_PED"].ToString();
                    _descricao[i] = dr["DESCRICAO_ITEM_PED"].ToString();
                    unidade = dr["UNID_ITEM_PED"].ToString();
                    if (unidade == "KG" || unidade == "Kg" || unidade == "kg")
                    {
                        _qtde[i] = dr["PESO_ITEM_PED"].ToString();
                    }
                    else
                    {
                        _qtde[i] = dr["QTDE_ITEM_PED"].ToString();
                    }
                    _valor_unit[i] = dr["VALOR_UNIT_ITEM_PED"].ToString();
                    _cod_item_pc[i] = dr["COD_ITEM_PED"].ToString();
                    i++;
                    
                }

                for (int j = 0; j < i; j++)
                {
                    inserir_itens(_cod[j], _item[j] + " - " + _descricao[j], _qtde[j], _valor_unit[j], _cod_item_pc[j]);

                }
                dsItens_nf_entrada.Clear();
                localizar_itens();
                tb_n_pedido_compra.Text = "";
                somar_itens();

                
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            form_pesquisa_pedido_compra pc = new form_pesquisa_pedido_compra();
            try
            {
                pc.nf_entrada = true;
                pc.ShowDialog();

            }
            finally
            {
                tb_n_pedido_compra.Text = pc.cod;
            }
        }










    }
}