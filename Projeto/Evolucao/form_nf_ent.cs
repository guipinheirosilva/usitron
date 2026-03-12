using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using System.IO;

namespace Evolucao
{
    public partial class form_nf_ent : Form
    {
        int ind_101, ind_102, ind_201, ind_202, ind_500, ind_900,
            ind_00, ind_10, ind_20, ind_30, ind_40, ind_41, ind_50, ind_51, ind_60, ind_70, ind_90;
        bool erro_ao_retirar;
        bool importar_conjunto;

        public form_nf_ent()
        {
            InitializeComponent();
        }

        private void novo_registro_Click(object sender, EventArgs e)
        {
            nova_nf();
            
        }
        private void nova_nf()
        {
            try
            {
                datNota_fiscal_ent.InsertCommand.CommandText =
                    "INSERT INTO NOTA_FISCAL_ENT (CLIENTE_FORN_NF_ENT) values ('novo')";
                datNota_fiscal_ent.InsertCommand.Connection = fbConnection1;
                fbConnection1.Open();
                datNota_fiscal_ent.InsertCommand.ExecuteNonQuery();
                fbConnection1.Close(); 
                selecionar_nf(buscar_ultima_insercao());

            }
            catch (Exception a)
            {
                fbConnection1.Close(); 
                MessageBox.Show(a.ToString());
            }

        }

        private void selecionar_nf(string cod)
        {
            try
            {
                dsNota_fiscal_ent.Clear();
                datNota_fiscal_ent.SelectCommand.CommandText =
                    "SELECT * FROM NOTA_FISCAL_ENT WHERE COD_SISTEMA_NF_ENT = '" + cod + "'";
                datNota_fiscal_ent.SelectCommand.Connection = fbConnection1;
                fbConnection1.Open();
                datNota_fiscal_ent.SelectCommand.ExecuteNonQuery();
                datNota_fiscal_ent.Fill(NOTA_FISCAL_ENT);
                fbConnection1.Close(); 
                dsItens_nota_ent.Clear();
                datItens_nota_ent.SelectCommand.CommandText =
                    "SELECT * FROM ITENS_NOTA_ENT WHERE COD_SISTEMA_NF_ITEM_ENT = '" + cod + "' ORDER BY COD_ITENS_NOTA_ENT";
                datItens_nota_ent.SelectCommand.Connection = fbConnection1;
                fbConnection1.Open();
                datItens_nota_ent.SelectCommand.ExecuteNonQuery();
                datItens_nota_ent.Fill(ITENS_NOTA_ENT);
                fbConnection1.Close(); 
                dsFatura_nf_ent.Clear();
                datFatura_nf_ent.SelectCommand.CommandText =
                   "SELECT * FROM FATURA_NF_ENT WHERE NF_FATURA_ENT = '" + cod + "' ORDER BY COD_FATURA_ENT";
                datFatura_nf_ent.SelectCommand.Connection = fbConnection1;
                fbConnection1.Open();
                datFatura_nf_ent.SelectCommand.ExecuteNonQuery();
                datFatura_nf_ent.Fill(FATURA_NF_ENT);
                fbConnection1.Close(); 
            }
            catch (Exception a)
            {
                fbConnection1.Close(); 
                MessageBox.Show(a.ToString());
            }

        }

        private string buscar_ultima_insercao()
        {
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                select.CommandText =
                    "SELECT COD_SISTEMA_NF_ENT FROM NOTA_FISCAL_ENT ORDER BY COD_SISTEMA_NF_ENT DESC";
                fbConnection1.Open();
                FbDataAdapter nota_fiscal_entDataAdapter = new FbDataAdapter();
                nota_fiscal_entDataAdapter.SelectCommand = select;
                DataSet nota_fiscal_entDataSet = new DataSet();
                nota_fiscal_entDataAdapter.Fill(nota_fiscal_entDataSet);
                fbConnection1.Close(); 
                DataRow dr = nota_fiscal_entDataSet.Tables[0].Rows[0];
                return dr[0].ToString();
            }
            catch (Exception a)
            {
                fbConnection1.Close(); 
                MessageBox.Show(a.ToString());
                return "erro";

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form_localiza_forn forn = new form_localiza_forn(false, cnpj_empresa);
            try
            {

                forn.ShowDialog();
            }
            finally
            {
                tb_estado_cliente.Text = forn.estado_escolhido;
                tb_cnpj_cliente.Text = forn.cnpj_escolhido;
                tb_cliente.Text = forn.razao_forn_escolhido;
            }
        }
        private void localizar_item_fornecedor(string cod)
        {

            try
            {
                FbCommand comando_select = new FbCommand();
                comando_select.Connection = fbConnection1;
                comando_select.CommandText = "SELECT * FROM PRODUTOS WHERE COD_FORNECEDOR_PRODUTO = '" + cod + "'";
                DataSet prod = new DataSet();
                fbConnection1.Open();
                FbDataAdapter datProdutos = new FbDataAdapter();
                datProdutos.SelectCommand = comando_select;
                datProdutos.Fill(prod);
                fbConnection1.Close(); 

                foreach (DataRow dr in prod.Tables[0].Rows)
                {
                    tb_cod_peca.Text = dr["COD_FORNECEDOR_PRODUTO"].ToString();
                    tb_descricao_peca.Text = dr["DESCRICAO_PRODUTO"].ToString();
                    tb_unid_peca.Text = dr["COD_UNIDADE_PRODUTO"].ToString();
                    tb_preco_unit_peca.Text = dr["VALOR_VENDA_PRODUTOR_PRODUTO"].ToString();
                    tb_ncm_peca.Text = dr["NCM_PRODUTO"].ToString();
                    tb_cfo_peca.Text = "9999";
                    tb_ean.Text = dr["COD_BARRAS_PRODUTO"].ToString();
                    
                    

                }
            }
            catch
            {

                fbConnection1.Close(); 
            }
        }
        private void button10_Click(object sender, EventArgs e)
        {
            form_localiza_produto localiza_item = new form_localiza_produto(true, cnpj_empresa);
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
                    localizar_item_fornecedor(localiza_item.cod_produto_escolhido);
                }

            }
        }

        private void buscar_item(string cod)
        {
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT COD_ESTOQUE, ITEM_ESTOQUE, DESCRICAO_ESTOQUE, UNIDADE_ESTOQUE, NCM_ESTOQUE FROM " +
                    "ESTOQUE WHERE COD_ESTOQUE = '" + cod + "'";
                FbDataAdapter estoqueDataAdapter = new FbDataAdapter();
                estoqueDataAdapter.SelectCommand = select;
                DataSet estoqueDataSet = new DataSet();
                estoqueDataAdapter.Fill(estoqueDataSet);
                fbConnection1.Close(); 
                foreach (DataRow dr in estoqueDataSet.Tables[0].Rows)
                {
                    tb_cod_peca.Text = dr[0].ToString();
                    tb_descricao_peca.Text = dr[1].ToString() + " " + dr[2].ToString();
                    tb_unid_peca.Text = dr[3].ToString();
                    tb_ncm_peca.Text = dr[4].ToString();
                }

            }
            catch (Exception a)
            {
                fbConnection1.Close(); 
                MessageBox.Show(a.ToString());
            }
        }

        private void salva_registro_Click(object sender, EventArgs e)
        {
            if (!todas_tem_ncm())
                MessageBox.Show("É obrigatório todos os itens conter NCM");
            atualizar();
        }

        private bool todas_tem_ncm()
        {
            for (int i = 0; i < dgvItens_nota.RowCount; i++)
            {
                if (dgvItens_nota.Rows[i].Cells["col_ncm"].Value.ToString() == "")
                    return false;
            }
            return true;
        }

        private void atualizar()
        {
            try
            {
                this.BindingContext[dsNota_fiscal_ent, "NOTA_FISCAL_ENT"].EndCurrentEdit();
                if (dsNota_fiscal_ent.HasChanges())
                {
                    fbConnection1.Open();
                    datNota_fiscal_ent.UpdateCommand = cbNota_fiscal_ent.GetUpdateCommand();
                    datNota_fiscal_ent.InsertCommand = cbNota_fiscal_ent.GetInsertCommand();
                    datNota_fiscal_ent.DeleteCommand = cbNota_fiscal_ent.GetDeleteCommand();
                    datNota_fiscal_ent.Update(dsNota_fiscal_ent, "NOTA_FISCAL_ENT");
                    dsNota_fiscal_ent.AcceptChanges();
                    fbConnection1.Close(); 
                }
                this.BindingContext[dsItens_nota_ent, "ITENS_NOTA_ENT"].EndCurrentEdit();
                if (dsItens_nota_ent.HasChanges())
                {
                    fbConnection1.Open();
                    datItens_nota_ent.UpdateCommand = cbItens_nota_ent.GetUpdateCommand();
                    datItens_nota_ent.InsertCommand = cbItens_nota_ent.GetInsertCommand();
                    datItens_nota_ent.DeleteCommand = cbItens_nota_ent.GetDeleteCommand();
                    datItens_nota_ent.Update(dsItens_nota_ent, "ITENS_NOTA_ENT");
                    dsItens_nota_ent.AcceptChanges();
                    fbConnection1.Close(); 
                }
                this.BindingContext[dsFatura_nf_ent, "FATURA_NF_ENT"].EndCurrentEdit();
                if (dsFatura_nf_ent.HasChanges())
                {
                    fbConnection1.Open();
                    datFatura_nf_ent.UpdateCommand = cbFatura_nf_ent.GetUpdateCommand();
                    datFatura_nf_ent.InsertCommand = cbFatura_nf_ent.GetInsertCommand();
                    datFatura_nf_ent.DeleteCommand = cbFatura_nf_ent.GetDeleteCommand();
                    datFatura_nf_ent.Update(dsFatura_nf_ent, "FATURA_NF_ENT");
                    dsFatura_nf_ent.AcceptChanges();
                    fbConnection1.Close(); 
                }
            }
            catch (Exception a)
            {
                fbConnection1.Close(); 
                MessageBox.Show(a.ToString());
                // MessageBox.Show("2");
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            form_localiza_nf_ent ent = new form_localiza_nf_ent();
            try
            {
                ent.ShowDialog();
            }
            finally
            {
                if (ent.n_nf != null)
                    selecionar_nf(ent.n_nf);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (cbBaixada.Checked)
                MessageBox.Show("Essa nota não pode ser apagada");
            else
            {
                if (DialogResult.Yes == MessageBox.Show("O registro será excluído permanentemente, tem certeza?",
                       "Confirma a exclusão?", MessageBoxButtons.YesNo))
                {
                    try
                    {

                        this.datItens_nota_ent.DeleteCommand.CommandText =
                           "DELETE FROM ITENS_NOTA_ENT WHERE COD_SISTEMA_NF_ITEM_ENT = '" + tb_cod_interno.Text + "'";
                        this.fbConnection1.Open();
                        this.datItens_nota_ent.DeleteCommand.Connection = fbConnection1;
                        this.datItens_nota_ent.DeleteCommand.ExecuteNonQuery();
                        this.fbConnection1.Close(); 

                        this.datNota_fiscal_ent.DeleteCommand.CommandText =
                            "DELETE FROM NOTA_FISCAL_ENT WHERE COD_SISTEMA_NF_ENT = '" + tb_cod_interno.Text + "'";
                        this.fbConnection1.Open();
                        this.datNota_fiscal_ent.DeleteCommand.Connection = fbConnection1;
                        this.datNota_fiscal_ent.DeleteCommand.ExecuteNonQuery();
                        this.fbConnection1.Close(); 

                        this.datItens_nota_ent.DeleteCommand.CommandText =
                            "DELETE FROM ITENS_NOTA_ENT WHERE COD_SISTEMA_NF_ITEM_ENT = '" + tb_cod_interno.Text + "'";
                        this.fbConnection1.Open();
                        this.datItens_nota_ent.DeleteCommand.Connection = fbConnection1;
                        this.datItens_nota_ent.DeleteCommand.ExecuteNonQuery();
                        this.fbConnection1.Close(); 

                        this.datFatura_nf_ent.DeleteCommand.CommandText =
                            "DELETE FROM FATURA_NF_ENT WHERE NF_FATURA_ENT = '" + tb_cod_interno.Text + "'";
                        this.fbConnection1.Open();
                        this.datFatura_nf_ent.DeleteCommand.Connection = fbConnection1;
                        this.datFatura_nf_ent.DeleteCommand.ExecuteNonQuery();
                        this.fbConnection1.Close(); 
                        dsNota_fiscal_ent.Clear();
                        dsItens_nota_ent.Clear();
                        dsFatura_nf_ent.Clear();

                        //abre_nova();
                    }
                    catch (Exception a)
                    {
                        fbConnection1.Close(); 
                        MessageBox.Show(a.ToString());
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DateTime hoje = DateTime.Now;
            form_pesquisa_pedido_compra ped = new form_pesquisa_pedido_compra(cnpj_empresa);
            try
            {
                ped.nf_entrada = true;
                ped.ShowDialog();
            }
            finally
            {
                if (ped.cod != null)
                {
                    tb_ent_sai_nfe.Text = "0";
                    tb_data_emissao.Text = hoje.ToShortDateString();
                    tb_saida.Text = hoje.ToShortDateString();
                    tb_n_nf.Text = ped.cod;
                    inserir_itens_pedido(ped.cod);
                    calcular();
                }
            }
        }

        private void inserir_itens_pedido(string n_pedido)
        {
            try
            {
                FbCommand select1 = new FbCommand();
                select1.Connection = fbConnection1;
                select1.CommandText =
                    "SELECT NOME_FORN_PED, CNPJ_FORN_PED, VALOR_OUTRAS_DESP_PED, VALOR_REAL_IPI_PED, DESCONTO_PED  FROM PEDIDO_COMPRA WHERE COD_PED = '" + n_pedido + "'";
                FbDataAdapter datPedido_compra1 = new FbDataAdapter();
                fbConnection1.Open();
                datPedido_compra1.SelectCommand = select1;
                DataSet dsPedido_compra1 = new DataSet();
                datPedido_compra1.Fill(dsPedido_compra1);
                fbConnection1.Close();
                double outras_despesas = 0, ipi = 0, desconto = 0;
                foreach (DataRow d in dsPedido_compra1.Tables[0].Rows)
                {
                    tb_cliente.Text = d[0].ToString();
                    tb_cnpj_cliente.Text = d[1].ToString();
                    try
                    {
                        outras_despesas = Convert.ToDouble(d["VALOR_OUTRAS_DESP_PED"].ToString());
                    }
                    catch { }
                    try
                    {
                        ipi = Convert.ToDouble(d["VALOR_REAL_IPI_PED"].ToString());
                    }
                    catch { }
                    try
                    {
                        desconto = Convert.ToDouble(d["DESCONTO_PED"].ToString());
                    }
                    catch { }

                }

                FbCommand select2 = new FbCommand();
                select2.Connection = fbConnection1;
                select2.CommandText =
                    "SELECT SUM(QTDE_ITEM_PED * VALOR_UNIT_ITEM_PED) " +
                    "FROM ITENS_PEDIDO_COMPRA WHERE N_PEDIDO_ITEM_PED = '" + n_pedido + "'";
                FbDataAdapter datPedido_compra2 = new FbDataAdapter();
                fbConnection1.Open();
                datPedido_compra2.SelectCommand = select2;
                DataSet dsPedido_compra2 = new DataSet();
                datPedido_compra2.Fill(dsPedido_compra2);
                fbConnection1.Close();
                double valor_total = 0;
                foreach (DataRow dr in dsPedido_compra2.Tables[0].Rows)
                {
                    valor_total = Convert.ToDouble(dr[0].ToString());
                }

                //falta calcular o 


                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                select.CommandText =
                    "SELECT COD_ITEM_PED, COD_ITEM_REQ_ITEM_PED, QTDE_ITEM_PED, UNID_ITEM_PED, " +
                    "VALOR_UNIT_ITEM_PED, ITEM_ITEM_PED, COD_ESTOQUE_ITEM_PED, COD_BARRAS_ITEM_PED, DESCRICAO_ITEM_PED " +
                    "FROM ITENS_PEDIDO_COMPRA WHERE N_PEDIDO_ITEM_PED = '" + n_pedido + "' ORDER BY COD_ITEM_PED";
                FbDataAdapter datPedido_compra = new FbDataAdapter();
                fbConnection1.Open();
                datPedido_compra.SelectCommand = select;
                DataSet dsPedido_compra = new DataSet();
                datPedido_compra.Fill(dsPedido_compra);
                fbConnection1.Close(); 
                int i = 1;
                foreach (DataRow dr in dsPedido_compra.Tables[0].Rows)
                {
                    insert_itens_nf_entrada(n_pedido, i.ToString(), dr[0].ToString(), dr[1].ToString(), dr[2].ToString(),
                        dr[3].ToString(), dr[4].ToString(), dr[5].ToString() + " " + dr[8].ToString() , dr[6].ToString(), dr[6].ToString(), "", "", dr[7].ToString());
                    i++;
                }

               
                calcular();
            }
            catch (Exception a)
            {
                fbConnection1.Close(); 
                MessageBox.Show(a.ToString());
            }
        }



        private void insert_itens_nf_entrada(string n_pedido, string n_linha_ped, string cod_item_ped, string cod_item_req, string qtde,
            string unid, string valor_unit, string descricao, string cod_item_est, string cod_item, string cfop, string ncm, string ean)
        {
            string _cod_item_ped = "null", _cod_item_req = "null", _qtde = "null", _unid = "null",
                _valor_unit = "null", _descricao = "null", _cod_item_est = "null", _n_pedido = "null",
                _n_linha_ped = "null", _cod_item = "null", _cfop = "null", _ncm = "null", _ean = "null";
            double valor_total = 0;
            try
            {
                try
                {
                    valor_total = Convert.ToDouble(qtde) * Convert.ToDouble(valor_unit);
                }
                catch { }
                if (cod_item_ped != "")
                    _cod_item_ped = "'" + cod_item_ped + "'";
                if (cod_item_req != "")
                    _cod_item_req = "'" + cod_item_req + "'";
                if (qtde != "")
                    _qtde = "'" + Convert.ToDouble(qtde).ToString().Replace(".", "").Replace(",", ".") + "'";
                if (unid != "")
                    _unid = "'" + unid + "'";
                if (valor_unit != "")
                    _valor_unit = "'" + Convert.ToDouble(valor_unit).ToString().Replace(".", "").Replace(",", ".") + "'";
                if (descricao != "")
                    _descricao = "'" + descricao + "'";
                if (cod_item_est != "")
                    _cod_item_est = "'" + cod_item_est + "'";
                if (n_pedido != "")
                    _n_pedido = "'" + n_pedido + "'";
                if (n_linha_ped != "")
                    _n_linha_ped = "'" + n_linha_ped + "'";
                if (cod_item != "")
                    _cod_item = "'" + cod_item + "'";
                if (cfop != "")
                    _cfop = "'" + cfop + "'";
                if (ncm != "")
                    _ncm = "'" + ncm + "'";
                if (ean != "")
                    _ean = "'" + ean + "'";

                if (cfop == "")
                    _cfop = "'5102'";
                string data_insercao = DateTime.Now.ToShortDateString().Replace("/", ".");

                FbCommand insert = new FbCommand();
                insert.Connection = fbConnection1;
                fbConnection1.Open();
                insert.CommandText =
                    "INSERT INTO ITENS_NOTA_ENT (DESCRICAO_ITEM_ENT, UNIDADE_ITEM_ENT, " +
                    "PRECO_UNIT_ITEM_ENT, PRECO_TOTAL_ITEM_ENT, QTDE_ITEM_ENT, " +
                    "COD_ITEM_REQ_ITEM_ENT, COD_ITEM_PED_ITEM_ENT, COD_ITEM_EST_ITEM_ENT, " +
                    "PEDIDO_COMPRA_ITEM_ENT, N_LINHA_PED_ITEM_ENT, COD_SISTEMA_NF_ITEM_ENT, " +
                    "COD_ITEM_ENT, CFOP_ITEM_ENT, NCM_ITEM_ENT, NF_ITEM_ENT, CNPJ_CLIENTE_ITEM_ENT, DATA_INSERCAO_ITEM_ENT_NOTA, COD_EAN_ITEM_ENT) VALUES " +
                    "(" + _descricao + "," + _unid + "," + _valor_unit + ",'" +
                    valor_total.ToString().Replace(".", "").Replace(",", ".") + "'," +
                    _qtde + "," + _cod_item_req + "," + _cod_item_ped + "," +
                    _cod_item_est + "," + _n_pedido + "," + _n_linha_ped + ",'" +
                    tb_cod_interno.Text + "'," + _cod_item + "," + _cfop + "," + _ncm + ",'" +
                    tb_n_nf.Text + "','" + tb_cnpj_cliente.Text + "','" + data_insercao + "'," + _ean + ")";
                FbDataAdapter itens_nota_entDataAdapter = new FbDataAdapter();
                itens_nota_entDataAdapter.InsertCommand = insert;
                itens_nota_entDataAdapter.InsertCommand.ExecuteNonQuery();
                fbConnection1.Close(); 

                dsItens_nota_ent.Clear();
                datItens_nota_ent.SelectCommand.CommandText =
                    "SELECT * FROM ITENS_NOTA_ENT WHERE COD_SISTEMA_NF_ITEM_ENT = '" + tb_cod_interno.Text + "' ORDER BY COD_ITENS_NOTA_ENT";
                datItens_nota_ent.SelectCommand.Connection = fbConnection1;
                fbConnection1.Open();
                datItens_nota_ent.SelectCommand.ExecuteNonQuery();
                datItens_nota_ent.Fill(ITENS_NOTA_ENT);
                fbConnection1.Close(); 

            }
            catch (Exception a)
            {
                fbConnection1.Close(); 
                MessageBox.Show(a.ToString());
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            insert_itens_nf_entrada(tb_pedido_compra.Text, tb_n_item_pedido_compra.Text, "", "", tb_qtde_peca.Text,
                tb_unid_peca.Text, tb_preco_unit_peca.Text, tb_descricao_peca.Text, tb_cod_peca.Text, tb_cod_peca.Text, tb_cfo_peca.Text, tb_ncm_peca.Text, tb_ean.Text);

            calcular();
        }

        private void inserir_itens_ent(string descricao, string unidade, string qtde, string st, string preco_unit,
            string preco_total, string perc_ipi, string perc_icms, string n_nf, string valor_ipi, string pedido_compra,
            string cod, string cfop, string valor_icms, string valor_iss, string prestacao_servico, string valor_bc,
            string data_insercao, string cnpj_cliente_forn, string status_atual, string n_linha_pedido, string valor_bc_icms_st,
            string valor_icms_st, string valor_frete, string valor_desconto, string valor_seguro, string valor_outras_desp,
            string iva, string perc_reducao, string perc_cofins, string valor_cofins, string perc_pis, string valor_pis,
            string origem, string mod_bc, string perc_iss, string mod_bc_st, string perc_reducao_st, string perc_icms_st,
            string aliquota_credito, string valor_credito, string ipi_trib, string ipi_n_trib, string cst_ipi_trib,
            string cst_ipi_n_trib, string tipo_pis, string cst_pis, string tipo_cofins, string cst_cofins, string tipo_servico,
            string bc_ipi, string bc_pis, string bc_cofins, string bc_iss, string bc_com_ipi, string cod_item_req,
            string cod_item_ped, string cod_item_est, string ncm, string codBarras, string vbcstret, string pst, string vicmssubstituto, string vicmsstret)
        {
            try
            {
                string _descricao = "null", _unidade = "null", _qtde = "null", _st = "null", _preco_unit = "null",
                _preco_total = "null", _perc_ipi = "null", _perc_icms = "null", _n_nf = "null";
                string _valor_ipi = "null", _pedido_compra = "null",
                _cod = "null", _cfop = "null", _valor_icms = "null", _valor_iss = "null", _prestacao_servico = "null", _valor_bc = "null",
                _data_insercao = "null";
                string _cnpj_cliente_forn = "null", _status_atual = "null", _n_linha_pedido = "null", _valor_bc_icms_st = "null";
                string _iva = "null", _valor_icms_st = "null", _valor_frete = "null", _valor_desconto = "null", _valor_seguro = "null", _valor_outras_desp = "null";
                string _origem = "null", _mod_bc = "null", _perc_iss = "null", _mod_bc_st = "null", _perc_reducao = "null", _perc_reducao_st = "null", _perc_icms_st = "null";
                string _aliquota_credito = "null", _valor_credito = "null", _ipi_trib = "null", _ipi_n_trib = "null",
                    _cst_ipi_trib = "null", _cst_ipi_n_trib = "null";
                string _tipo_pis = "null", _cst_pis = "null", _tipo_cofins = "null", _cst_cofins = "null", _tipo_servico = "null";
                string _bc_ipi = "null", _bc_pis = "null", _bc_cofins = "null", _bc_iss = "null", _bc_com_ipi = "null";
                string _cod_item_req = "null", _cod_item_ped = "null", _cod_item_est = "null";
                string _perc_cofins = "null", _valor_cofins = "null", _perc_pis = "null", _valor_pis = "null";
                string _ncm = "null";
                string _codBarras = "null";
                string _vbcstret = "null", _pst = "null", _vicmssubstituto = "null", _vicmsstret = "null";
                //tratando nulls

                try
                {
                    if (descricao != "" && descricao != null)
                        _descricao = "'" + descricao + "'";
                }
                catch { }
                try
                {
                    if (unidade != "" && unidade != null)
                        _unidade = "'" + unidade + "'";
                }
                catch { }
                try
                {
                    if (qtde != "" && qtde != null)
                        _qtde = "'" + Convert.ToDouble(qtde).ToString().Replace(".", "").Replace(",", ".") + "'";
                }
                catch { }
                try
                {
                    if (st != "" && st != null)
                        _st = "'" + st + "'";
                }
                catch { }
                try
                {
                    if (preco_unit != "" && preco_unit != null)
                        _preco_unit = "'" + Convert.ToDouble(preco_unit).ToString().Replace(".", "").Replace(",", ".") + "'";
                }
                catch { }
                try
                {
                    if (preco_total != "" && preco_total != null)
                        _preco_total = "'" + Convert.ToDouble(preco_total).ToString().Replace(".", "").Replace(",", ".") + "'";
                }
                catch { }
                try
                {
                    if (perc_ipi != "" && perc_ipi != null)
                        _perc_ipi = "'" + Convert.ToDouble(perc_ipi).ToString().Replace(".", "").Replace(",", ".") + "'";
                }
                catch { }
                try
                {
                    if (perc_icms != "" && perc_icms != null)
                        _perc_icms = "'" + Convert.ToDouble(perc_icms).ToString().Replace(".", "").Replace(",", ".") + "'";
                }
                catch { }
                try
                {
                    if (n_nf != "" && n_nf != null)
                        _n_nf = "'" + n_nf + "'";
                }
                catch { }



                try
                {
                    if (valor_ipi != "" && valor_ipi != null)
                        _valor_ipi = "'" + Convert.ToDouble(valor_ipi).ToString().Replace(".", "").Replace(",", ".") + "'";
                }
                catch { }
                try
                {
                    if (pedido_compra != "" && pedido_compra != null)
                        _pedido_compra = "'" + pedido_compra + "'";
                }
                catch { }
                try
                {
                    if (cod != "" && cod != null)
                        _cod = "'" + cod + "'";
                }
                catch { }
                try
                {
                    if (cfop != "" && cfop != null)
                        _cfop = "'" + cfop + "'";
                }
                catch { }
                try
                {
                    if (valor_icms != "" && valor_icms != null)
                        _valor_icms = "'" + Convert.ToDouble(valor_icms).ToString().Replace(".", "").Replace(",", ".") + "'";
                }
                catch { }
                try
                {
                    if (valor_iss != "" && valor_iss != null)
                        _valor_iss = "'" + Convert.ToDouble(valor_iss).ToString().Replace(".", "").Replace(",", ".") + "'";
                }
                catch { }
                try
                {
                    if (prestacao_servico != "" && prestacao_servico != null)
                        _prestacao_servico = "'" + prestacao_servico + "'";
                }
                catch { }
                try
                {
                    if (valor_bc != "" && valor_bc != null)
                        _valor_bc = "'" + Convert.ToDouble(valor_bc).ToString().Replace(".", "").Replace(",", ".") + "'";
                }
                catch { }
                try
                {
                    if (data_insercao != "" && data_insercao != null)
                        _data_insercao = "'" + Convert.ToDateTime(data_insercao).ToShortDateString().Replace("/", ".") + "'";
                }
                catch { }



                try
                {
                    if (cnpj_cliente_forn != "" && cnpj_cliente_forn != null)
                        _cnpj_cliente_forn = "'" + cnpj_cliente_forn + "'";
                }
                catch { }
                try
                {
                    if (status_atual != "" && status_atual != null)
                        _status_atual = "'" + status_atual + "'";
                }
                catch { }
                try
                {
                    if (n_linha_pedido != "" && n_linha_pedido != null)
                        _n_linha_pedido = "'" + n_linha_pedido + "'";
                }
                catch { }
                try
                {
                    if (iva != "" && iva != null)
                        _iva = "'" + Convert.ToDouble(iva).ToString().Replace(".", "").Replace(",", ".") + "'";
                }
                catch { }
                try
                {
                    if (valor_bc_icms_st != "" && valor_bc_icms_st != null)
                        _valor_bc_icms_st = "'" + Convert.ToDouble(valor_bc_icms_st).ToString().Replace(".", "").Replace(",", ".") + "'";
                }
                catch { }

                try
                {
                    if (valor_icms_st != "" && valor_icms_st != null)
                        _valor_icms_st = "'" + Convert.ToDouble(valor_icms_st).ToString().Replace(".", "").Replace(",", ".") + "'";
                }
                catch { }
                try
                {
                    if (valor_frete != "" && valor_frete != null)
                        _valor_frete = "'" + Convert.ToDouble(valor_frete).ToString().Replace(".", "").Replace(",", ".") + "'";
                }
                catch { }
                try
                {
                    if (valor_desconto != "" && valor_desconto != null)
                        _valor_desconto = "'" + Convert.ToDouble(valor_desconto).ToString().Replace(".", "").Replace(",", ".") + "'";
                }
                catch { }
                try
                {
                    if (valor_seguro != "" && valor_seguro != null)
                        _valor_seguro = "'" + Convert.ToDouble(valor_seguro).ToString().Replace(".", "").Replace(",", ".") + "'";
                }
                catch { }
                try
                {
                    if (valor_outras_desp != "" && valor_outras_desp != null)
                        _valor_outras_desp = "'" + Convert.ToDouble(valor_outras_desp).ToString().Replace(".", "").Replace(",", ".") + "'";
                }
                catch { }
                try
                {
                    if (valor_bc_icms_st != "" && valor_bc_icms_st != null)
                        _valor_bc_icms_st = "'" + Convert.ToDouble(valor_bc_icms_st).ToString().Replace(".", "").Replace(",", ".") + "'";
                }
                catch { }


                try
                {
                    if (iva != "" && iva != null)
                        _iva = "'" + Convert.ToDouble(iva).ToString().Replace(".", "").Replace(",", ".") + "'";
                }
                catch { }
                try
                {
                    if (perc_reducao != "" && perc_reducao != null)
                        _perc_reducao = "'" + Convert.ToDouble(perc_reducao).ToString().Replace(".", "").Replace(",", ".") + "'";
                }
                catch { }
                try
                {
                    if (perc_cofins != "" && perc_cofins != null)
                        _perc_cofins = "'" + Convert.ToDouble(perc_cofins).ToString().Replace(".", "").Replace(",", ".") + "'";
                }
                catch { }
                try
                {
                    if (valor_cofins != "" && valor_cofins != null)
                        _valor_cofins = "'" + Convert.ToDouble(valor_cofins).ToString().Replace(".", "").Replace(",", ".") + "'";
                }
                catch { }
                try
                {
                    if (perc_pis != "" && perc_pis != null)
                        _perc_pis = "'" + Convert.ToDouble(perc_pis).ToString().Replace(".", "").Replace(",", ".") + "'";
                }
                catch { }
                try
                {
                    if (valor_pis != "" && valor_pis != null)
                        _valor_pis = "'" + Convert.ToDouble(valor_pis).ToString().Replace(".", "").Replace(",", ".") + "'";
                }
                catch { }


                try
                {
                    if (origem != "" && origem != null)
                        _origem = "'" + origem + "'";
                }
                catch { }
                try
                {
                    if (mod_bc != "" && mod_bc != null)
                        _mod_bc = "'" + mod_bc + "'";
                }
                catch { }
                try
                {
                    if (perc_iss != "" && perc_iss != null)
                        _perc_iss = "'" + Convert.ToDouble(perc_iss).ToString().Replace(".", "").Replace(",", ".") + "'";
                }
                catch { }
                try
                {
                    if (mod_bc_st != "" && mod_bc_st != null)
                        _mod_bc_st = "'" + mod_bc_st + "'";
                }
                catch { }
                try
                {
                    if (perc_reducao_st != "" && perc_reducao_st != null)
                        _perc_reducao_st = "'" + Convert.ToDouble(perc_reducao_st).ToString().Replace(".", "").Replace(",", ".") + "'";
                }
                catch { }
                try
                {
                    if (perc_icms_st != "" && perc_icms_st != null)
                        _perc_icms_st = "'" + Convert.ToDouble(perc_icms_st).ToString().Replace(".", "").Replace(",", ".") + "'";
                }
                catch { }


                try
                {
                    if (aliquota_credito != "" && aliquota_credito != null)
                        _aliquota_credito = "'" + Convert.ToDouble(aliquota_credito).ToString().Replace(".", "").Replace(",", ".") + "'";
                }
                catch { }
                try
                {
                    if (valor_credito != "" && valor_credito != null)
                        _valor_credito = "'" + Convert.ToDouble(valor_credito).ToString().Replace(".", "").Replace(",", ".") + "'";
                }
                catch { }
                try
                {
                    if (ipi_trib != "" && ipi_trib != null)
                        _ipi_trib = "'" + ipi_trib + "'";
                }
                catch { }
                try
                {
                    if (cst_ipi_trib != "" && cst_ipi_trib != null)
                        _cst_ipi_trib = "'" + cst_ipi_trib + "'";
                }
                catch { }
                try
                {
                    if (ipi_n_trib != "" && ipi_n_trib != null)
                        _ipi_n_trib = "'" + ipi_n_trib + "'";
                }
                catch { }
                try
                {
                    if (cst_ipi_n_trib != "" && cst_ipi_n_trib != null)
                        _cst_ipi_n_trib = "'" + cst_ipi_n_trib + "'";
                }
                catch { }


                try
                {
                    if (tipo_pis != "" && tipo_pis != null)
                        _tipo_pis = "'" + tipo_pis + "'";
                }
                catch { }
                try
                {
                    if (cst_pis != "" && cst_pis != null)
                        _cst_pis = "'" + cst_pis + "'";
                }
                catch { }
                try
                {
                    if (tipo_cofins != "" && tipo_cofins != null)
                        _tipo_cofins = "'" + tipo_cofins + "'";
                }
                catch { }
                try
                {
                    if (cst_cofins != "" && cst_cofins != null)
                        _cst_cofins = "'" + cst_cofins + "'";
                }
                catch { }
                try
                {
                    if (tipo_servico != "" && tipo_servico != null)
                        _tipo_servico = "'" + tipo_servico + "'";
                }
                catch { }


                try
                {
                    if (bc_ipi != "" && bc_ipi != null)
                        _bc_ipi = "'" + Convert.ToDouble(bc_ipi).ToString().Replace(".", "").Replace(",", ".") + "'";
                }
                catch { }
                try
                {
                    if (bc_pis != "" && bc_pis != null)
                        _bc_pis = "'" + Convert.ToDouble(bc_pis).ToString().Replace(".", "").Replace(",", ".") + "'";
                }
                catch { }
                try
                {
                    if (bc_cofins != "" && bc_cofins != null)
                        _bc_cofins = "'" + Convert.ToDouble(bc_cofins).ToString().Replace(".", "").Replace(",", ".") + "'";
                }
                catch { }
                try
                {
                    if (bc_iss != "" && bc_iss != null)
                        _bc_iss = "'" + Convert.ToDouble(bc_iss).ToString().Replace(".", "").Replace(",", ".") + "'";
                }
                catch { }
                try
                {
                    if (bc_com_ipi != "" && bc_com_ipi != null)
                        _bc_com_ipi = "'" + bc_com_ipi + "'";
                }
                catch { }



                try
                {
                    if (cod_item_est != "" && cod_item_est != null)
                        _cod_item_est = "'" + cod_item_est + "'";
                }
                catch { }
                try
                {
                    if (cod_item_ped != "" && cod_item_ped != null)
                        _cod_item_ped = "'" + cod_item_ped + "'";
                }
                catch { }
                try
                {
                    if (ncm != "" && ncm != null)
                        _ncm = "'" + ncm + "'";
                }
                catch { }

                try
                {
                    if (codBarras != "" && codBarras != null)
                        _codBarras = "'" + codBarras + "'";
                }
                catch { }
                try
                {
                    if (vbcstret != "" && vbcstret != null)
                        _vbcstret = "'" + Convert.ToDouble(vbcstret).ToString().Replace(".", "").Replace(",", ".") + "'";
                }
                catch { }
                try
                {
                    if (pst != "" && pst != null)
                        _pst = "'" + Convert.ToDouble(pst).ToString().Replace(".", "").Replace(",", ".") + "'";
                }
                catch { }
                try
                {
                    if (vicmssubstituto != "" && vicmssubstituto != null)
                        _vicmssubstituto = "'" + Convert.ToDouble(vicmssubstituto).ToString().Replace(".", "").Replace(",", ".") + "'";
                }
                catch { }
                try
                {
                    if (vicmsstret != "" && vicmsstret != null)
                        _vicmsstret = "'" + Convert.ToDouble(vicmsstret).ToString().Replace(".", "").Replace(",", ".") + "'";
                }
                catch { }

                /*   campos[2, 4] = "ADD VBCSTRET_ITEM_ENT DOUBLE PRECISION";
             campos[2, 5] = "ADD PST_ITEM_ENT DOUBLE PRECISION";
             campos[2, 6] = "ADD VICMSSUBSTITUTO_ITEM_ENT DOUBLE PRECISION";
             campos[2, 7] = "ADD VICMSSTRET_ITEM_ENT DOUBLE PRECISION";
              * */
                string tipo = "null";
                //string _descricao2 = buscar_descricao_mp(_cod, out _cod_item_est, out tipo);
                //if (_cod_item_est == "")
                //    _cod_item_est = "null";
                datItens_nota_ent.InsertCommand.CommandText =
                    "INSERT INTO ITENS_NOTA_ENT " +
                    "(DESCRICAO_ITEM_ENT, UNIDADE_ITEM_ENT, QTDE_ITEM_ENT, ST_ITEM_ENT, PRECO_UNIT_ITEM_ENT, PRECO_TOTAL_ITEM_ENT, " +
                    "IPI_ITEM_ENT, ICM_ITEM_ENT, VALOR_IPI_ITEM_ENT, PEDIDO_COMPRA_ITEM_ENT, COD_ITEM_ENT, CFOP_ITEM_ENT, " +
                    "VALOR_ICM_ITEM_ENT, VALOR_ISS_ITEM_ENT, PRESTACAO_SERVICO_ITEM_ENT, VALOR_BC_ITEM_ENT, DATA_INSERCAO_ITEM_ENT_NOTA, " +
                    "CNPJ_CLIENTE_ITEM_ENT, STATUS_ATUAL_NFE_ENT, N_LINHA_PED_ITEM_ENT, VALOR_BC_ICMS_ST_ITEM_ENT, VALOR_ICMS_ST_ITEM_ENT, " +
                    "VALOR_FRETE_ITEM_ENT, VALOR_DESCONTO_ITEM_ENT, VALOR_SEGURO_ITEM_ENT, VALOR_OUTRAS_DESP_ITEM_ENT, IVA_ITEM_ENT, " +
                    "REDUCAO_ITEM_ENT, COFINS_ITEM_ENT, VALOR_COFINS_ITEM_ENT, PIS_ITEM_ENT, VALOR_PIS_ITEM_ENT, ORIGEM_ITEM_ENT, " +
                    "MOD_BC_ITEM_ENT, ISS_ITEM_ENT, MOD_BC_ST_ITEM_ENT, REDUCAO_ST_ITEM_ENT, ICMS_ST_ITEM_ENT, ALIQUOTA_CREDITO_ITEM_ENT, " +
                    "VALOR_CREDITO_ITEM_ENT, IPI_TRIB_ITEM_ENT, IPI_N_TRIB_ITEM_ENT, CST_IPI_TRIB_ITEM_ENT, CST_IPI_N_TRIB_ITEM_ENT, " +
                    "TIPO_PIS_ITEM_ENT, CST_PIS_ITEM_ENT, TIPO_COFINS_ITEM_ENT, CST_COFINS_ITEM_ENT, TIPO_SERVICO_ITEM_ENT, BC_IPI_ITEM_ENT, " +
                    "BC_PIS_ITEM_ENT, BC_COFINS_ITEM_ENT, BC_ISS_ITEM_ENT, BC_COM_IPI_ITEM_ENT, COD_ITEM_REQ_ITEM_ENT, COD_ITEM_PED_ITEM_ENT, " +
                    "COD_ITEM_EST_ITEM_ENT, COD_SISTEMA_NF_ITEM_ENT, NCM_ITEM_ENT, NF_ITEM_ENT, COD_EAN_ITEM_ENT, VBCSTRET_ITEM_ENT, PST_ITEM_ENT, " + 
                    "VICMSSUBSTITUTO_ITEM_ENT, VICMSSTRET_ITEM_ENT, SALDO_ITEM_ENT) VALUES " +
                    "(" + _descricao + "," + _unidade + "," + _qtde + "," + _st + "," + _preco_unit + "," + _preco_total + "," +
                    _perc_ipi + "," + _perc_icms + "," + _valor_ipi + "," + _pedido_compra + "," + _cod + "," +
                    _cfop + "," + _valor_icms + "," + _valor_iss + "," + _prestacao_servico + "," + _valor_bc + "," +
                    _data_insercao + "," + _cnpj_cliente_forn + "," + _status_atual + "," + _n_linha_pedido + "," + _valor_bc_icms_st + "," +
                    _valor_icms_st + "," + _valor_frete + "," + _valor_desconto + "," + _valor_seguro + "," + _valor_outras_desp + "," +
                    _iva + "," + _perc_reducao + "," + _perc_cofins + "," + _valor_cofins + "," + _perc_pis + "," + _valor_pis + "," +
                    _origem + "," + _mod_bc + "," + _perc_iss + "," + _mod_bc_st + "," + _perc_reducao_st + "," + _perc_icms_st + "," +
                    _aliquota_credito + "," + _valor_credito + "," + _ipi_trib + "," + _ipi_n_trib + "," + _cst_ipi_trib + "," +
                    _cst_ipi_n_trib + "," + _tipo_pis + "," + _cst_pis + "," + _tipo_cofins + "," + _cst_cofins + "," + _tipo_servico + "," +
                    _bc_ipi + "," + _bc_pis + "," + _bc_cofins + "," + _bc_iss + "," + _bc_com_ipi + "," + _cod_item_req + "," +
                    _cod_item_ped + "," + _cod_item_est + ",'" + tb_cod_interno.Text + "'," + _ncm + ",'" + tb_n_nf.Text + "', " + _codBarras + "," +
                    _vbcstret + "," + _pst + "," + _vicmssubstituto + "," + _vicmsstret + ","  + _qtde + ") RETURNING COD_ITENS_NOTA_ENT";
                datItens_nota_ent.InsertCommand.Connection = fbConnection1;
                fbConnection1.Open();
                object ultimo_item_nota_ent_inserido = datItens_nota_ent.InsertCommand.ExecuteScalar();
                fbConnection1.Close();

                if (tipo == "01 – Matéria-Prima")
                {
                    //INSERINDO LOTE

                    FbCommand insert_lote = new FbCommand();
                    insert_lote.Connection = fbConnection1;
                    fbConnection1.Open();
                    insert_lote.CommandText =
                        "INSERT INTO LOTE_RECEBIMENTO (COD_PRODUTO_LR, DESCRICAO_LR,  " +
                        "CLIENTE_LR, QTDE_LR, NOTA_FISCAL_LR, DATA_LIBERACAO_LR) VALUES ('" +
                        _cod_item_est + "'," + _descricao + ",'" + tb_cliente.Text + "'," +
                       _qtde + ",'" + tb_n_nf.Text + "','" +
                            Convert.ToDateTime(tb_data_emissao.Text).ToShortDateString().Replace("/", ".") + "') RETURNING COD_LR";
                    FbDataAdapter datLote = new FbDataAdapter();
                    datLote.InsertCommand = insert_lote;
                    object ultimo_lote_inserido = datLote.InsertCommand.ExecuteScalar();
                    fbConnection1.Close();

                    //UPDATE LOTE NO ITENS_NOTA

                    FbCommand update = new FbCommand();
                    update.Connection = fbConnection1;
                    fbConnection1.Open();
                    update.CommandText =
                        "UPDATE ITENS_NOTA_ENT SET LOTE_ITEM_ENT = '" + ultimo_lote_inserido.ToString() + "', " +
                        "QTDE_LOTE_ITEM_ENT = " + _qtde + ", " +
                        "NOME_PROPRIETARIO_ITEM_ENT = '" + tb_cliente.Text + "', BAIXADO_ITEM_ENT = 1 WHERE COD_ITENS_NOTA_ENT = '" +
                        ultimo_item_nota_ent_inserido + "'";
                    datItens_nota_ent.UpdateCommand = update;
                    datItens_nota_ent.UpdateCommand.ExecuteNonQuery();
                    fbConnection1.Close();

                    classeEstoque_material est = new classeEstoque_material();
                    est.fbConnection1.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=True;Packet Size=8192;Server Type=0";
                    est.calcular_estoque(_cod_item_est);
                }


                dsItens_nota_ent.Clear();
                datItens_nota_ent.SelectCommand.CommandText =
                    "SELECT * FROM ITENS_NOTA_ENT WHERE COD_SISTEMA_NF_ITEM_ENT = '" + tb_cod_interno.Text + "' ORDER BY COD_ITENS_NOTA_ENT";
                datItens_nota_ent.SelectCommand.Connection = fbConnection1;
                fbConnection1.Open();
                datItens_nota_ent.SelectCommand.ExecuteNonQuery();
                datItens_nota_ent.Fill(ITENS_NOTA_ENT);
                fbConnection1.Close(); 

            }
            catch (Exception a)
            {
                fbConnection1.Close(); 
                MessageBox.Show(a.ToString());
            }
        }

        private string buscar_descricao_mp(string item_estoque, out string item, out string tipo)
        {
            item = ""; tipo = "";
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    //"SELECT DESCRICAO_ESTOQUE, cod_estoque, TIPO_ITEM_ESTOQUE FROM ESTOQUE WHERE ITEM_ESTOQUE = " + item_estoque + "";
                    "SELECT DESCRICAO_PRODUTO, cod_PRODUTO, NOME_FAMILIA_PRODUTO FROM PRODUTOS WHERE COD_FORNECEDOR_PRODUTO = " + item_estoque + "";
                FbDataAdapter datTabela = new FbDataAdapter();
                datTabela.SelectCommand = select;
                DataSet dsTabela = new DataSet();
                datTabela.Fill(dsTabela);
                fbConnection1.Close();
                foreach (DataRow dr in dsTabela.Tables[0].Rows)
                {
                    item = dr[1].ToString();
                    tipo = dr[2].ToString();
                    return dr[0].ToString();
                }
                return "";
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
                return "";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            calcular();
        }

        private bool verificar_se_e_tributada(string n_cfo)
        {
            if (n_cfo == "")
                MessageBox.Show("Digite a CFOP de todos os itens");
            try
            {
                FbCommand comand = new FbCommand();
                comand.Connection = fbConnection1;
                comand.CommandText =
                    "SELECT TRIBUTADA_CFO FROM CFO WHERE N_CFO = '" + n_cfo + "'";
                fbConnection1.Open();
                FbDataAdapter datCfo = new FbDataAdapter();
                DataSet cfo = new DataSet();
                datCfo.SelectCommand = comand;
                datCfo.Fill(cfo);
                fbConnection1.Close(); 
                if (cfo.Tables[0].Rows.Count > 1)
                {
                    MessageBox.Show("Existem 2 CFOPs com o mesmo código, verifique.");
                    return false;
                }
                else
                {
                    try
                    {
                        DataRow dr = cfo.Tables[0].Rows[0];
                        if (dr[0].ToString() == "1")
                            return true;
                        else
                            return false;
                    }
                    catch
                    {
                        return false;
                    }
                }

            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
                fbConnection1.Close(); 
                return false;
            }

        }

        private void calcular()
        {
            double valor_produtos = 0, ipi_total, icm_total = 0, valor_total = 0, valor_ipi_total = 0, valor_icm_total = 0,
                valor_bc_total = 0, valor_iss_total = 0, base_calculo_iss_total = 0, valor_bc_st_total = 0, valor_st_total = 0,
                valor_frete = 0, valor_desconto = 0, valor_outras_desp = 0, valor_seguro = 0, valor_simples = 0;

            for (int i = 0; i < dgvItens_nota.RowCount; i++)
            {
                if (dgvItens_nota.Rows[i].Cells["col_prestacao_servico"].Value.ToString() == "1")
                {
                    valor_iss_total = valor_iss_total + Convert.ToDouble(dgvItens_nota.Rows[i].Cells["col_valor_iss"].Value.ToString());
                    base_calculo_iss_total = base_calculo_iss_total + Convert.ToDouble(dgvItens_nota.Rows[i].Cells["col_preco_total"].Value.ToString());
                }
                else
                {
                    try
                    {
                        valor_simples = valor_simples + Convert.ToDouble(dgvItens_nota.Rows[i].Cells["col_valor_credito"].Value.ToString());
                    }
                    catch { }
                    try
                    {
                        valor_produtos = valor_produtos + Convert.ToDouble(dgvItens_nota.Rows[i].Cells["col_preco_total"].Value.ToString());
                    }
                    catch { }
                    if (verificar_se_existem_2_cfops())
                    {
                        if (verificar_se_e_tributada(dgvItens_nota.Rows[i].Cells["col_cfo"].Value.ToString()))
                        {
                            try
                            {
                                valor_total = valor_total + Convert.ToDouble(dgvItens_nota.Rows[i].Cells["col_preco_total"].Value.ToString());
                            }
                            catch { }
                        }
                    }
                    else
                    {
                        try
                        {
                            valor_total = valor_total + Convert.ToDouble(dgvItens_nota.Rows[i].Cells["col_preco_total"].Value.ToString());
                        }
                        catch { }
                    }
                    try
                    {
                        valor_icm_total = valor_icm_total + (Convert.ToDouble(dgvItens_nota.Rows[i].Cells["col_valor_icm"].Value.ToString()));
                    }
                    catch { }
                    try
                    {
                        valor_ipi_total = valor_ipi_total + (Convert.ToDouble(dgvItens_nota.Rows[i].Cells["col_valor_ipi"].Value.ToString()));
                    }
                    catch { }
                    try
                    {
                        valor_bc_total = valor_bc_total + (Convert.ToDouble(dgvItens_nota.Rows[i].Cells["col_valor_bc"].Value.ToString()));
                    }
                    catch { }
                    try
                    {
                        valor_bc_st_total = valor_bc_st_total + (Convert.ToDouble(dgvItens_nota.Rows[i].Cells["col_valor_bc_st"].Value.ToString()));
                    }
                    catch { }
                    try
                    {
                        valor_st_total = valor_st_total + (Convert.ToDouble(dgvItens_nota.Rows[i].Cells["col_valor_st"].Value.ToString()));
                    }
                    catch { }
                    try
                    {
                        valor_frete = valor_frete + (Convert.ToDouble(dgvItens_nota.Rows[i].Cells["col_frete"].Value.ToString()));
                    }
                    catch { }
                    try
                    {
                        valor_desconto = valor_desconto + (Convert.ToDouble(dgvItens_nota.Rows[i].Cells["col_desconto"].Value.ToString()));
                    }
                    catch { }
                    try
                    {
                        valor_seguro = valor_seguro + (Convert.ToDouble(dgvItens_nota.Rows[i].Cells["col_seguro"].Value.ToString()));
                    }
                    catch { }

                    try
                    {
                        valor_outras_desp = valor_outras_desp + (Convert.ToDouble(dgvItens_nota.Rows[i].Cells["col_outras_desp"].Value.ToString()));
                    }
                    catch { }
                }
            }


            valor_total = valor_produtos + valor_ipi_total + base_calculo_iss_total +
                valor_st_total + valor_frete - valor_desconto + valor_seguro + valor_outras_desp;
            tb_base_calc_icm.Text = valor_bc_total.ToString("n2");
            tb_base_calc_iss.Text = base_calculo_iss_total.ToString("n2");
            tb_valor_total_iss.Text = valor_iss_total.ToString("n2");
            tb_valor_icm_st.Text = valor_st_total.ToString("n2");
            tb_base_cal_icm_st.Text = valor_bc_st_total.ToString("n2");
            tb_valor_icm.Text = valor_icm_total.ToString("n2");
            tb_valor_ipi.Text = valor_ipi_total.ToString("n2");
            tb_total_prod.Text = valor_produtos.ToString("n2");
            tb_total_nota.Text = valor_total.ToString("n2");
            tb_valor_fre.Text = valor_frete.ToString("n2");
            tb_valor_seg.Text = valor_seguro.ToString("n2");
            tb_desconto.Text = valor_desconto.ToString("n2");

            tb_outras_des_ace.Text = valor_outras_desp.ToString("n2");
            tb_valor_simples.Text = valor_simples.ToString("n2");

        }
        private bool verificar_se_existem_2_cfops()
        {
            bool existe = false;
            string cfop_inicial = dgvItens_nota.Rows[0].Cells["col_cfo"].Value.ToString();
            for (int i = 1; i < dgvItens_nota.RowCount; i++)
            {
                try
                {
                    if (cfop_inicial != dgvItens_nota.Rows[i].Cells["col_cfo"].Value.ToString())
                        existe = true;
                }
                catch { }

            }
            return existe;
        }

        private void apaga_faturas_anteriores()
        {
            try
            {
                this.datFatura_nf_ent.DeleteCommand.CommandText =
                        "DELETE FROM FATURA_NF_ENT WHERE NF_FATURA_ENT = '" + tb_cod_interno.Text + "'";
                this.fbConnection1.Open();
                this.datFatura_nf_ent.DeleteCommand.Connection = fbConnection1;
                this.datFatura_nf_ent.DeleteCommand.ExecuteNonQuery();
                this.fbConnection1.Close(); 
            }
            catch (Exception a)
            {
                fbConnection1.Close(); 
                MessageBox.Show(a.ToString());
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            inserir_nova_forma_pgto();
        }

        private void insere_fatura(string prazo, string data, string valor, string nf)
        {
            try
            {
                if (prazo != "null")
                    prazo = "'" + prazo + "'";
                this.datFatura_nf_ent.InsertCommand.CommandText =
                        "INSERT INTO FATURA_NF_ENT (PRAZO_FATURA_ENT, DATA_VENC_FATURA_ENT, VALOR_FATURA_ENT, NF_FATURA_ENT)" +
                        "VALUES (" + prazo + ",'" + data.Replace("/", ".") + "','" + valor + "','" + nf + "')";
                this.fbConnection1.Open();
                this.datFatura_nf_ent.InsertCommand.Connection = fbConnection1;
                this.datFatura_nf_ent.InsertCommand.ExecuteNonQuery();
                this.fbConnection1.Close(); 
            }
            catch (Exception a)
            {
                fbConnection1.Close(); 
                MessageBox.Show(a.ToString());
            }

        }

        private void inserir_nova_forma_pgto()
        {
            if (tb_total_nota.Text != "")
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
                    apaga_faturas_anteriores();
                    acertar_faturas(localiza_forma.n_parcelas, localiza_forma.prazo_1, localiza_forma.prazo_2, localiza_forma.prazo_3,
                                    localiza_forma.prazo_4, localiza_forma.prazo_5, localiza_forma.prazo_6,
                                    localiza_forma.prazo_7, localiza_forma.prazo_8, localiza_forma.prazo_9,
                                    localiza_forma.prazo_10, localiza_forma.prazo_11, localiza_forma.prazo_12);
                    try
                    {
                        dsFatura_nf_ent.Clear();
                        this.datFatura_nf_ent.SelectCommand.CommandText =
                        "SELECT * FROM FATURA_NF_ENT WHERE NF_FATURA_ENT = '" + tb_cod_interno.Text + "'";
                        this.fbConnection1.Open();
                        this.datFatura_nf_ent.SelectCommand.Connection = fbConnection1;
                        this.datFatura_nf_ent.SelectCommand.ExecuteNonQuery();
                        datFatura_nf_ent.Fill(FATURA_NF_ENT);
                        this.fbConnection1.Close(); 
                    }
                    catch
                    {
                        fbConnection1.Close(); 
                    }

                }

            }
            else
                MessageBox.Show("Calcule o valor da Nota antes de inserir a forma de pagamento.");
        }

        private bool verificar_se_e_faturado(string cfo)
        {
            if (verificar_se_e_tributada(cfo))
                return true;
            else
                return false;
        }

        private double buscar_valor_faturado()
        {
            double valor_faturado = 0;
            for (int i = 0; i < dgvItens_nota.RowCount; i++)
            {
                try
                {
                    
                        double preco_total = 0, ipi = 0, st = 0, frete = 0, desconto = 0, seguro = 0, outras_desp = 0;
                        try
                        {
                            preco_total = Convert.ToDouble(dgvItens_nota.Rows[i].Cells["col_preco_total"].Value.ToString());
                        }
                        catch { }
                        try
                        {
                            ipi = Convert.ToDouble(dgvItens_nota.Rows[i].Cells["col_valor_ipi"].Value.ToString());
                        }
                        catch { }
                        try
                        {
                            st = Convert.ToDouble(dgvItens_nota.Rows[i].Cells["col_valor_st"].Value.ToString());
                        }
                        catch { }
                        try
                        {
                            frete = Convert.ToDouble(dgvItens_nota.Rows[i].Cells["col_frete"].Value.ToString());
                        }
                        catch
                        { }
                        try
                        {
                            desconto = Convert.ToDouble(dgvItens_nota.Rows[i].Cells["col_desconto"].Value.ToString());
                        }
                        catch { }
                        try
                        {
                            seguro = Convert.ToDouble(dgvItens_nota.Rows[i].Cells["col_seguro"].Value.ToString());
                        }
                        catch { }
                        try
                        {
                            outras_desp = Convert.ToDouble(dgvItens_nota.Rows[i].Cells["col_outras_desp"].Value.ToString());
                        }
                        catch { }
                        valor_faturado = valor_faturado + preco_total + ipi + st + frete + seguro + outras_desp - desconto;

                   
                }
                catch { }


            }
            return valor_faturado;
        }
        private void acertar_faturas(string n_parcelas, string prazo_1, string prazo_2, string prazo_3,
        string prazo_4, string prazo_5, string prazo_6, string prazo_7, string prazo_8, string prazo_9, string prazo_10, string prazo_11, string prazo_12)
        {
            try
            {

                int numero_parcelas = 0;
                DateTime hoje = DateTime.Now;
                //hoje = DateTime.Now;
                try
                {
                    numero_parcelas = Convert.ToInt32(n_parcelas);
                }
                catch
                {
                    numero_parcelas = 0;
                    // MessageBox.Show("Número de parcelas incorreto");
                }
                //decimal valor = 0;// buscar_valor_faturado() / numero_parcelas;
                double valor = buscar_valor_faturado() / numero_parcelas;
                // Convert.ToDecimal(Convert.ToDecimal((Convert.ToDecimal(tb_total_prod.Text) - Convert.ToDecimal(tb_valor_desconto.Text)) / numero_parcelas).ToString("n2"));
                string[] prazos = { prazo_1, prazo_2, prazo_3, prazo_4, prazo_5, prazo_6, prazo_7, prazo_8, prazo_9, prazo_10, prazo_11, prazo_12 };

                for (int i = 0; i < numero_parcelas; i++)
                {
                    double prazo = 0;
                    prazo = Convert.ToDouble(prazos[i]);
                    DateTime data1 = hoje.AddDays(prazo);
                    insere_fatura(prazos[i].ToString(), data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), tb_cod_interno.Text);
                }




            }
            catch { }

        }
        /*
        private void acertar_faturas(string n_parcelas, string prazo_1, string prazo_2, string prazo_3,
            string prazo_4, string prazo_5, string prazo_6)
        {

            int numero_parcelas = 0;
            DateTime hoje = DateTime.Now;
            //hoje = DateTime.Now;
            try
            {
                numero_parcelas = Convert.ToInt32(n_parcelas);
            }
            catch
            {
                numero_parcelas = 0;
                MessageBox.Show("Número de parcelas incorreto");
            }
            double valor = buscar_valor_faturado() / numero_parcelas;

            switch (numero_parcelas)
            {

                case 1:
                    {
                        double prazo = Convert.ToDouble(prazo_1);
                        DateTime data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_1, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(".", "").Replace(",", "."), tb_cod_interno.Text);
                        break;
                    }

                case 2:
                    {
                        double prazo = Convert.ToDouble(prazo_1);
                        DateTime data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_1, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(".", "").Replace(",", "."), tb_cod_interno.Text);
                        prazo = Convert.ToDouble(prazo_2);
                        data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_2, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(".", "").Replace(",", "."), tb_cod_interno.Text);
                        break;
                    }
                case 3:
                    {
                        double prazo = Convert.ToDouble(prazo_1);
                        DateTime data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_1, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(".", "").Replace(",", "."), tb_cod_interno.Text);
                        prazo = Convert.ToDouble(prazo_2);
                        data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_2, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(".", "").Replace(",", "."), tb_cod_interno.Text);
                        prazo = Convert.ToDouble(prazo_3);
                        data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_3, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(".", "").Replace(",", "."), tb_cod_interno.Text);
                        break;
                    }
                case 4:
                    {
                        double prazo = Convert.ToDouble(prazo_1);
                        DateTime data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_1, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(".","").Replace(",","."), tb_cod_interno.Text);
                        prazo = Convert.ToDouble(prazo_2);
                        data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_2, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(".","").Replace(",","."), tb_cod_interno.Text);
                        prazo = Convert.ToDouble(prazo_3);
                        data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_3, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(".","").Replace(",","."), tb_cod_interno.Text);
                        prazo = Convert.ToDouble(prazo_4);
                        data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_4, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(".","").Replace(",","."), tb_cod_interno.Text);
                        break;
                    }
                case 5:
                    {
                        double prazo = Convert.ToDouble(prazo_1);
                        DateTime data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_1, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(".","").Replace(",","."), tb_cod_interno.Text);
                        prazo = Convert.ToDouble(prazo_2);
                        data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_2, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(".","").Replace(",","."), tb_cod_interno.Text);
                        prazo = Convert.ToDouble(prazo_3);
                        data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_3, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(".","").Replace(",","."), tb_cod_interno.Text);
                        prazo = Convert.ToDouble(prazo_4);
                        data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_4, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(".","").Replace(",","."), tb_cod_interno.Text);
                        prazo = Convert.ToDouble(prazo_5);
                        data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_5, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(".","").Replace(",","."), tb_cod_interno.Text);
                        break;
                    }
                case 6:
                    {
                        double prazo = Convert.ToDouble(prazo_1);
                        DateTime data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_1, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(".","").Replace(",","."), tb_cod_interno.Text);
                        prazo = Convert.ToDouble(prazo_2);
                        data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_2, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(".","").Replace(",","."), tb_cod_interno.Text);
                        prazo = Convert.ToDouble(prazo_3);
                        data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_3, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(".","").Replace(",","."), tb_cod_interno.Text);
                        prazo = Convert.ToDouble(prazo_4);
                        data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_4, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(".","").Replace(",","."), tb_cod_interno.Text);
                        prazo = Convert.ToDouble(prazo_5);
                        data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_5, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(".","").Replace(",","."), tb_cod_interno.Text);
                        prazo = Convert.ToDouble(prazo_6);
                        data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_6, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(".","").Replace(",","."), tb_cod_interno.Text);
                        break;
                    }



            }

        }
        */
        private void update_coluna_xml_aut(string procCTe)
        {
            try
            {
                

                fbConnection1.Open();
                FbTransaction trans = fbConnection1.BeginTransaction();
                fbConnection1.Close();
                FbCommand update = new FbCommand("UPDATE NOTA_FISCAL_ENT SET XML_AUTORIZADO_NF_ENT = ? " +
                    "WHERE COD_SISTEMA_NF_ENT = ?", fbConnection1, trans);
                update.Parameters.AddWithValue("XML_AUTORIZADO_NF_ENT", procCTe);
                update.Parameters.AddWithValue("COD_SISTEMA_NF_ENT", tb_cod_interno.Text);
                fbConnection1.Open();
                FbDataAdapter datTabela = new FbDataAdapter();
                datTabela.UpdateCommand = update;
                datTabela.UpdateCommand.ExecuteNonQuery();
                fbConnection1.Close();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
                fbConnection1.Close();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            importar_conjunto = true;
            OpenFileDialog openFileDialog2 = new OpenFileDialog();
             openFileDialog2.Multiselect = true;
             if (openFileDialog2.ShowDialog() == DialogResult.OK)
             {
                 progressBar1.Maximum = openFileDialog2.FileNames.Length - 1;
                 progressBar1.Value = 0;
                 DateTime inicio = DateTime.Now;
                 if (openFileDialog2.FileNames.Length > 0)
                 {
                     if (openFileDialog2.FileNames.Length == 1)
                         importar_conjunto = false;

                     List<string> nf_importadas = new List<string>();

                     for (int i = 0; i < openFileDialog2.FileNames.Length; i++)
                     {
                         if(i != 0 || tb_cod_interno.Text == "")
                             nova_nf();

                         string caminho;

                         caminho = openFileDialog2.FileNames[i];
                         tb_caminho.Text = openFileDialog2.FileNames[i].ToString();
                         
                         string conteudoXml = File.ReadAllText(tb_caminho.Text);
                         update_coluna_xml_aut(conteudoXml);

                         buscar_dados_autorizacao(tb_caminho.Text);
                         if (verificar_se_nf_ja_foi_importada(tb_chave_acesso_nfe.Text))
                         {
                             MessageBox.Show("Essa nota já foi importada");
                         }
                         else
                         {
                             //buscando dados_nota

                             buscar_dados_nf(tb_caminho.Text);
                             //buscando dados_cliente/forn
                             buscar_dados_cliente_forn(tb_caminho.Text);
                             //buscando dados_destinatario
                             buscar_dados_destinatario(tb_caminho.Text);
                             //buscando produtos e tributacao
                             buscar_produtos(tb_caminho.Text);
                             //buscando totais
                             buscar_totais(tb_caminho.Text);
                             //buscando duplicatas
                             if(!tb_cliente.Text.Contains("CLARA"))
                                 buscar_duplicatas(tb_caminho.Text);
                             //buscando informações complementares
                             buscar_inf_comp(tb_caminho.Text);
                             //buscando dados de autorizacao


                             calcular();
                             /*
                             if ((!razao_social_empresa.Contains("LLOC") && tb_cnpj_cliente.Text != cnpj_empresa))
                                 baixar_nf();
                             if((tb_cnpj_destinatario.Text != cnpj_empresa && razao_social_empresa.Contains("LLOC") && importar_conjunto))  // estoque terceiros
                                 cbBaixada.Checked = true;
                              * */
                             atualizar();
                             nf_importadas.Add(tb_cod_interno.Text);
                             progressBar1.Value = i;
                             progressBar1.Update();
                         }
                     }
                     if (importar_conjunto && razao_social_empresa.Contains("LLOC"))
                     {
                         atualizar_estoque(nf_importadas);
                     }
                     DateTime fim = DateTime.Now;
                     TimeSpan tempo = fim - inicio;
                     //MessageBox.Show(tempo.ToString());
                     MessageBox.Show("NFs importadas.");
                 }
             }

        }

        private void atualizar_estoque(List<string> nf_importadas)
        {
            try
            {
                string nfs = "";
                for (int i = 0; i < nf_importadas.Count; i++)
                {
                    if (i == 0)
                        nfs += " AND (COD_SISTEMA_NF_ITEM_ENT = '" + nf_importadas[i].ToString() + "' OR ";
                    else if (i == nf_importadas.Count - 1)
                        nfs += " COD_SISTEMA_NF_ITEM_ENT = '" + nf_importadas[i].ToString() + "') ";
                    else
                        nfs += " COD_SISTEMA_NF_ITEM_ENT = '" + nf_importadas[i].ToString() + "' OR ";


                }

                FbCommand select = new FbCommand();
               
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                        "SELECT DISTINCT(COD_EAN_ITEM_ENT) FROM ITENS_NOTA_ENT WHERE 0 = 0 " + nfs;
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();
                foreach (DataRow dr in dtSelect.Rows)
                {
                    FbCommand comando = new FbCommand();
                    comando.Connection = fbConnection1;
                    comando.CommandText =
                        "SELECT COD_BARRAS_CAIXA_PRODUTO, COD_BARRAS_PRODUTO, QTDE_UNIDADE_PRODUTO, CNPJ_FORNECEDOR_PRODUTO, COD_PRODUTO, COD_FORNECEDOR_PRODUTO " +
                        "FROM PRODUTOS WHERE (COD_BARRAS_CAIXA_PRODUTO = '" + dr[0].ToString() + "' OR COD_BARRAS_PRODUTO = '" + dr[0].ToString() + "')";
                    fbConnection1.Open();
                    FbDataAdapter datTable = new FbDataAdapter();
                    datTable.SelectCommand = comando;
                    DataSet dsTable = new DataSet();
                    datTable.Fill(dsTable);
                    fbConnection1.Close();
                    int i = 0;
                    try
                    {
                        foreach (DataRow drProd in dsTable.Tables[0].Rows)
                        {
                            classeEstoque estoque = new classeEstoque();
                            estoque.fbConnection1.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=True;Packet Size=8192;Server Type=0";
                            //estoque.calcular_estoque(drProd[0].ToString(), drProd[1].ToString(), drProd[2].ToString(), drProd[3].ToString(), drProd[4].ToString());
                            estoque.calcular_estoque(dr["COD_FORNECEDOR_PRODUTO"].ToString());
                           i++;
                        }
                    }
                    catch
                    {
                        
                    }
                    
                }
            }
            catch (Exception a)
            {
                fbConnection1.Close();
            }


        }

        private bool verificar_se_nf_ja_foi_importada(string chave)
        {
            try
            {
                FbCommand select = new FbCommand();
                select.CommandText =
                    "SELECT * FROM NOTA_FISCAL_ENT WHERE CHAVE_ACESSO_NF_ENT = '" + chave + "'";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();
                foreach (DataRow dr in dtSelect.Rows)
                {
                        return true;
                }
                return false;
            }
            catch(Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
                return false;
            }
        }

        private void buscar_dados_autorizacao(string caminho)
        {
            try
            {
                DataSet ds = new DataSet();
                ds.ReadXml(@caminho);
                foreach (DataRow dr in ds.Tables["infProt"].Rows)
                {
                    tb_status_nfe.Text = dr["xMotivo"].ToString();
                    tb_chave_acesso_nfe.Text = dr["chNFe"].ToString();
                    tb_protocolo_autorizacao.Text = dr["nProt"].ToString();
                }
            }
            catch (Exception a)
            {
                fbConnection1.Close(); 
                MessageBox.Show(a.ToString());
            }
        }

        private void buscar_inf_comp(string caminho)
        {
            try
            {
                DataSet ds = new DataSet();
                ds.ReadXml(@caminho);
                foreach (DataRow dr in ds.Tables["infAdic"].Rows)
                {
                    tb_dados_adicionais.Text = dr["infCpl"].ToString();
                }
            }
            catch (Exception a)
            {
                fbConnection1.Close(); 
                //MessageBox.Show(a.ToString());
            }
        }

        private void buscar_duplicatas(string caminho)
        {
            try
            {
                DataSet ds = new DataSet();
                ds.ReadXml(@caminho);
                if (ds.Tables.Contains("dup"))
                {
                    foreach (DataRow dr in ds.Tables["dup"].Rows)
                    {
                        try
                        {
                            insere_fatura("null", Convert.ToDateTime(dr["dVenc"].ToString()).ToShortDateString(),
                                Convert.ToDouble(dr["vDup"].ToString().Replace(".", ",")).ToString().Replace(".","").Replace(",","."), tb_cod_interno.Text);
                        }
                        catch (Exception a)
                        {
                            MessageBox.Show(a.ToString());
                        }
                    }
                }

                dsFatura_nf_ent.Clear();
                datFatura_nf_ent.SelectCommand.CommandText =
                   "SELECT * FROM FATURA_NF_ENT WHERE NF_FATURA_ENT = '" + tb_cod_interno.Text + "' ORDER BY COD_FATURA_ENT";
                datFatura_nf_ent.SelectCommand.Connection = fbConnection1;
                fbConnection1.Open();
                datFatura_nf_ent.SelectCommand.ExecuteNonQuery();
                datFatura_nf_ent.Fill(FATURA_NF_ENT);
                fbConnection1.Close(); 

            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
            }
        }

        private void buscar_totais(string p)
        {

        }



        private void buscar_produtos(string caminho)
        {
            try
            {
                string _descricao = "", _unidade = "", _qtde = "", _st = "", _preco_unit = "",
                _preco_total = "", _perc_ipi = "", _perc_icms = "", _n_nf = "", _ncm = "";
                string _valor_ipi = "", _pedido_compra = "",
                _cod = "", _cfop = "", _valor_icms = "", _valor_iss = "", _prestacao_servico = "", _valor_bc = "",
                _data_insercao = DateTime.Now.ToShortDateString().Replace("/", ".");
                string _cnpj_cliente_forn = "", _status_atual = "", _n_linha_pedido = "", _valor_bc_icms_st = "";
                string _iva = "", _valor_icms_st = "", _valor_frete = "", _valor_desconto = "", _valor_seguro = "", _valor_outras_desp = "";
                string _origem = "", _mod_bc = "", _perc_iss = "", _mod_bc_st = "", _perc_reducao_st = "", _perc_icms_st = "";
                string _aliquota_credito = "", _valor_credito = "", _ipi_trib = "", _ipi_n_trib = "", _perc_reducao = "",
                    _cst_ipi_trib = "", _cst_ipi_n_trib = "";
                string _tipo_pis = "", _cst_pis = "", _tipo_cofins = "", _cst_cofins = "", _tipo_servico = "";
                string _bc_ipi = "", _bc_pis = "", _bc_cofins = "", _bc_iss = "", _bc_com_ipi = "";
                string _cod_item_req = "", _cod_item_ped = "", _cod_item_est = "";
                string _perc_cofins = "null", _valor_cofins = "null", _perc_pis = "null", _valor_pis = "null";
                string _codBarras = "null";
                string _vbcstret = "null", _pst = "null", _vicmssubstituto = "null", _vicmsstret = "null";
                /*   campos[2, 4] = "ADD VBCSTRET_ITEM_ENT DOUBLE PRECISION";
                campos[2, 5] = "ADD PST_ITEM_ENT DOUBLE PRECISION";
                campos[2, 6] = "ADD VICMSSUBSTITUTO_ITEM_ENT DOUBLE PRECISION";
                campos[2, 7] = "ADD VICMSSTRET_ITEM_ENT DOUBLE PRECISION";
                 * */
                DataSet ds = new DataSet();
                ds.ReadXml(@caminho);
                int i = 0;
                ind_101 = 0; ind_102 = 0; ind_201 = 0; ind_202 = 0; ind_500 = 0; ind_900 = 0;
                ind_00 = 0; ind_10 = 0; ind_20 = 0; ind_30 = 0; ind_40 = 0; ind_41 = 0; ind_50 = 0; ind_51 = 0; ind_60 = 0; ind_70 = 0; ind_90 = 0;
                foreach (DataRow dr in ds.Tables["prod"].Rows)
                {
                    _descricao = dr["xProd"].ToString();
                    _unidade = dr["uCom"].ToString();
                    _qtde = dr["qCom"].ToString().Replace(".", ",");
                    _ncm = dr["NCM"].ToString();
                    _cfop = dr["CFOP"].ToString();
                    _preco_unit = dr["vUnCom"].ToString().Replace(".", ",");
                    _preco_total = dr["vProd"].ToString().Replace(".", ",");
                    _cod = dr["cProd"].ToString();
                    _codBarras = dr["cEAN"].ToString();
                    try
                    {
                        _pedido_compra = dr["xPed"].ToString();
                    }
                    catch { }
                    try
                    {
                        _n_linha_pedido = dr["nItemPed"].ToString();
                    }
                    catch { }


                    try { _valor_frete = dr["vFrete"].ToString().Replace(".", ","); }
                    catch { }; try { _valor_seguro = dr["vSeg"].ToString().Replace(".", ","); }
                    catch { }; try { _valor_desconto = dr["vDesc"].ToString().Replace(".", ","); }
                    catch { }; try { _valor_outras_desp = dr["vOutro"].ToString().Replace(".", ","); }
                    catch { };

                    //existe um problema no índice "i" quando na mesma nota existem duas cfops-cst diferentes pois o i tem que incrementar quando for cst igual
                    buscar_informacoes_icms(tb_caminho.Text, i.ToString(), out _st, out _perc_icms, out _valor_icms, out _valor_bc,
                        out _valor_bc_icms_st, out _iva, out _valor_icms_st, out _origem, out _mod_bc, out _mod_bc_st,
                        out _perc_reducao_st, out _perc_icms_st, out _aliquota_credito, out _valor_credito, out _perc_reducao, out _vbcstret, out _pst, out _vicmssubstituto, out _vicmsstret);
                    buscar_informacoes_ipi(tb_caminho.Text, i.ToString(), out _cst_ipi_trib, out _bc_ipi, out _perc_ipi, out _valor_ipi,
                        out _cst_ipi_n_trib);
                    buscar_informacoes_pis(tb_caminho.Text, i.ToString(), out _perc_pis, out _valor_pis, out _tipo_pis, out _cst_pis,
                        out _bc_pis);
                    buscar_informacoes_cofins(tb_caminho.Text, i.ToString(), out _perc_cofins, out _valor_cofins, out _tipo_cofins, out _cst_cofins,
                        out _bc_cofins);

                    _cod_item_est = buscar_cod_item_estoque(_cod);

                    //insert_itens_nf_entrada("", "", "", "", _qtde, _unidade,
                    //_preco_unit, _descricao, "", _cod, _cfop, _ncm); 
                    inserir_itens_ent(_descricao, _unidade, _qtde, _st, _preco_unit,
            _preco_total, _perc_ipi, _perc_icms, _n_nf, _valor_ipi, _pedido_compra,
            _cod, _cfop, _valor_icms, _valor_iss, _prestacao_servico, _valor_bc,
            _data_insercao, _cnpj_cliente_forn, _status_atual, _n_linha_pedido, _valor_bc_icms_st,
            _valor_icms_st, _valor_frete, _valor_desconto, _valor_seguro, _valor_outras_desp,
            _iva, _perc_reducao, _perc_cofins, _valor_cofins, _perc_pis, _valor_pis,
            _origem, _mod_bc, _perc_iss, _mod_bc_st, _perc_reducao_st, _perc_icms_st,
            _aliquota_credito, _valor_credito, _ipi_trib, _ipi_n_trib, _cst_ipi_trib,
            _cst_ipi_n_trib, _tipo_pis, _cst_pis, _tipo_cofins, _cst_cofins, _tipo_servico,
            _bc_ipi, _bc_pis, _bc_cofins, _bc_iss, _bc_com_ipi, _cod_item_req,
            _cod_item_ped, _cod_item_est, _ncm, _codBarras, _vbcstret, _pst, _vicmssubstituto, _vicmsstret);

                    i++;
                }

            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
            }
        }

        private string buscar_cod_item_estoque(string _cod)
        {
             try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT COD_PRODUTO FROM PRODUTOS WHERE COD_FORNECEDOR_PRODUTO = '" + _cod + "'";
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();
                foreach (DataRow dr in dtSelect.Rows)
                {
                    return dr[0].ToString();
                }
                return "0";
            }
            catch (Exception ex)
            {
                fbConnection1.Close();
                MessageBox.Show(ex.Message);
                return "0";
            }
        }

        private void buscar_informacoes_cofins(string caminho, string n_item, out string _perc_cofins, out string _valor_cofins, out string _tipo_cofins, out string _cst_cofins, out string _bc_cofins)
        {
            _perc_cofins = ""; _valor_cofins = ""; _tipo_cofins = ""; _cst_cofins = ""; _bc_cofins = "";
            DataSet ds = new DataSet();
            ds.ReadXml(@caminho);
            //DataRow dr;
            try
            {
                //dr = ds.Tables["COFINSAliq"].Rows[Convert.ToInt32(n_item)];
                foreach (DataRow dr in ds.Tables["COFINSAliq"].Select("COFINS_id = " + n_item))
                {
                    _cst_cofins = dr["CST"].ToString();
                    _bc_cofins = dr["vBC"].ToString().Replace(".", ",");
                    _perc_cofins = dr["pCOFINS"].ToString().Replace(".", ",");
                    _valor_cofins = dr["vCOFINS"].ToString().Replace(".", ",");
                }
            }
            catch { }
            try
            {
                foreach (DataRow dr in ds.Tables["COFINSNT"].Select("COFINS_id = " + n_item))
                {
                   // dr = ds.Tables["COFINSNT"].Rows[Convert.ToInt32(n_item)];
                    _cst_cofins = dr["CST"].ToString();
                }
            }
            catch { }
        }

        private void buscar_informacoes_pis(string caminho, string n_item, out string _perc_pis, out string _valor_pis, out string _tipo_pis, out string _cst_pis, out string _bc_pis)
        {
            _perc_pis = ""; _valor_pis = ""; _tipo_pis = ""; _cst_pis = ""; _bc_pis = "";
            DataSet ds = new DataSet();
            ds.ReadXml(@caminho);
           // DataRow dr;
            try
            {
               //dr = ds.Tables["PISAliq"].Rows[Convert.ToInt32(n_item)];
                foreach (DataRow dr1 in ds.Tables["PISAliq"].Select("PIS_id = " + n_item))
                {
                    //dr = ds.Tables["PISAliq"].Select("PIS_id = " + n_item);
                    _cst_pis = dr1["CST"].ToString();
                    _bc_pis = dr1["vBC"].ToString().Replace(".", ",");
                    _perc_pis = dr1["pPIS"].ToString().Replace(".", ",");
                    _valor_pis = dr1["vPIS"].ToString().Replace(".", ",");
                }
            }
            catch { }
           
            try
            {
                foreach (DataRow dr1 in ds.Tables["PISNT"].Select("PIS_id = " + n_item))
                {
                    //dr1 = ds.Tables["PISNT"].Rows[Convert.ToInt32(n_item)];
                    _cst_pis = dr1["CST"].ToString();
                }
            }
            catch { }

        }

        private void buscar_informacoes_ipi(string caminho, string n_item,
            out string _cst_ipi_trib, out string _bc_ipi,
            out string _perc_ipi, out string _valor_ipi,
            out string _cst_ipi_n_trib)
        {
            _perc_ipi = ""; _valor_ipi = ""; _cst_ipi_trib = ""; _bc_ipi = ""; _cst_ipi_n_trib = "";
            DataSet ds = new DataSet();
            ds.ReadXml(@caminho);
           // DataRow dr;
            try
            {
                //dr = ds.Tables["IPITrib"].Rows[Convert.ToInt32(n_item)];
                foreach (DataRow dr in ds.Tables["IPITrib"].Select("IPI_id = " + n_item))
                {
                    _cst_ipi_trib = dr["CST"].ToString();
                    _bc_ipi = dr["vBC"].ToString().Replace(".", ",");
                    _perc_ipi = dr["pIPI"].ToString().Replace(".", ",");
                    _valor_ipi = dr["vIPI"].ToString().Replace(".", ",");
                }
            }
            catch { }
            try
            {
                //dr = ds.Tables["IPINT"].Rows[Convert.ToInt32(n_item)];
                foreach (DataRow dr in ds.Tables["IPINT"].Select("IPI_id = " + n_item))
                {
                    _cst_ipi_n_trib = dr["CST"].ToString();
                }
            }
            catch { }
        }

        private void buscar_informacoes_icms(string caminho, string n_item, out string _cst, out string _perc_icms,
            out string _valor_icms, out string _valor_bc, out string _valor_bc_icms_st, out string _iva,
            out string _valor_icms_st, out string _origem, out string _mod_bc, out string _mod_bc_st,
            out string _perc_reducao_st, out string _perc_icms_st, out string _aliquota_credito,
            out string _valor_credito, out string _perc_reducao, out string _vbcstret, out string _pst, 
            out string _vicmssubstituto, out string _vicmsstret)
        {
            _perc_icms = ""; _valor_icms = ""; _valor_bc = ""; _valor_bc_icms_st = "";
            _valor_icms_st = ""; _origem = ""; _mod_bc = ""; _mod_bc_st = ""; _perc_reducao_st = "";
            _perc_icms_st = ""; _aliquota_credito = ""; _valor_credito = ""; _cst = ""; _iva = ""; _perc_reducao = "";
            _vbcstret = ""; _pst = ""; _vicmssubstituto = ""; _vicmsstret = "";
            DataSet ds = new DataSet();
            ds.ReadXml(@caminho);
            DataRow dr;
            //REGIME SIMPLES NACIONAL
            try
            {
                dr = ds.Tables["ICMSSN101"].Rows[Convert.ToInt32(ind_101)];

                if (dr["ICMS_Id"].ToString() == n_item)
                {
                    _origem = dr["orig"].ToString();
                    _cst = dr["CSOSN"].ToString();
                    _aliquota_credito = dr["pCredSN"].ToString().Replace(".", ",");
                    _valor_credito = dr["vCredICMSSN"].ToString().Replace(".", ",");
                    ind_101++;
                }
            }
            catch { }
            try
            {
                dr = ds.Tables["ICMSSN102"].Rows[Convert.ToInt32(ind_102)];
                if (dr["ICMS_Id"].ToString() == n_item)
                {
                    _origem = dr["orig"].ToString();
                    _cst = dr["CSOSN"].ToString();
                    ind_102++;
                }
            }
            catch { }
            try
            {
                dr = ds.Tables["ICMSSN201"].Rows[Convert.ToInt32(ind_201)];
                if (dr["ICMS_Id"].ToString() == n_item)
                {
                    _origem = dr["orig"].ToString();
                    _cst = dr["CSOSN"].ToString();
                    try { _mod_bc_st = dr["modBCST"].ToString(); }
                    catch { }
                    try { _iva = dr["pMVAST"].ToString().Replace(".", ","); }
                    catch { }
                    try { _perc_reducao_st = dr["pRedBCST"].ToString().Replace(".", ","); }
                    catch { }
                    try { _valor_bc_icms_st = dr["vBCST"].ToString().Replace(".", ","); }
                    catch { }
                    try { _perc_icms_st = dr["pICMSST"].ToString().Replace(".", ","); }
                    catch { }
                    try { _valor_icms_st = dr["vICMSST"].ToString().Replace(".", ","); }
                    catch { }
                    _aliquota_credito = dr["pCredSN"].ToString().Replace(".", ",");
                    _valor_credito = dr["vCredICMSSN"].ToString().Replace(".", ",");
                    ind_201++;
                }

            }
            catch { }
            try
            {
                dr = ds.Tables["ICMSSN202"].Rows[Convert.ToInt32(ind_202)];
                if (dr["ICMS_Id"].ToString() == n_item)
                {
                    _origem = dr["orig"].ToString();
                    _cst = dr["CSOSN"].ToString();
                    try { _mod_bc_st = dr["modBCST"].ToString(); }
                    catch { }
                    try { _iva = dr["pMVAST"].ToString().Replace(".", ","); }
                    catch { }
                    try { _perc_reducao_st = dr["pRedBCST"].ToString().Replace(".", ","); }
                    catch { }
                    try { _valor_bc_icms_st = dr["vBCST"].ToString().Replace(".", ","); }
                    catch { }
                    try { _perc_icms_st = dr["pICMSST"].ToString().Replace(".", ","); }
                    catch { }
                    try { _valor_icms_st = dr["vICMSST"].ToString().Replace(".", ","); }
                    catch { }
                    ind_202++;
                }
            }
            catch { }
            try
            {
                dr = ds.Tables["ICMSSN500"].Rows[Convert.ToInt32(ind_500)];
                if (dr["ICMS_Id"].ToString() == n_item)
                {
                    _origem = dr["orig"].ToString();
                    _cst = dr["CSOSN"].ToString();
                    ind_500++;
                }
                // falta colocar a informaçãp de BC retido vBCSTRet, vICMSSTRet
            }
            catch { }
            try
            {
                dr = ds.Tables["ICMSSN900"].Rows[Convert.ToInt32(ind_900)];
                if (dr["ICMS_Id"].ToString() == n_item)
                {
                    _origem = dr["orig"].ToString();
                    _cst = dr["CSOSN"].ToString();
                    try { _mod_bc = dr["modBC"].ToString(); }
                    catch { }
                    try { _valor_bc = dr["vBC"].ToString().Replace(".", ","); }
                    catch { }
                    try { _perc_reducao = dr["pRedBC"].ToString().Replace(".", ","); }
                    catch { }
                    try { _perc_icms = dr["pICMS"].ToString().Replace(".", ","); }
                    catch { }
                    try { _valor_icms = dr["vICMS"].ToString().Replace(".", ","); }
                    catch { }
                    try { _mod_bc_st = dr["modBCST"].ToString(); }
                    catch { }
                    try { _iva = dr["pMVAST"].ToString().Replace(".", ","); }
                    catch { }
                    try { _perc_reducao_st = dr["pRedBCST"].ToString().Replace(".", ","); }
                    catch { }
                    try { _valor_bc_icms_st = dr["vBCST"].ToString().Replace(".", ","); }
                    catch { }
                    try { _perc_icms_st = dr["pICMSST"].ToString().Replace(".", ","); }
                    catch { }
                    try { _valor_icms_st = dr["vICMSST"].ToString().Replace(".", ","); }
                    catch { }
                    try { _aliquota_credito = dr["pCredSN"].ToString().Replace(".", ","); }
                    catch { }
                    try { _valor_credito = dr["vCredICMSSN"].ToString().Replace(".", ","); }
                    catch { }
                    ind_900++;
                }
            }
            catch { }
            //REGIME NORMAL
            try
            {
                dr = ds.Tables["ICMS00"].Rows[Convert.ToInt32(ind_00)];
                if (dr["ICMS_Id"].ToString() == n_item)
                {
                    _origem = dr["orig"].ToString();
                    _cst = dr["CST"].ToString();
                    _mod_bc = dr["modBC"].ToString();
                    _valor_bc = dr["vBC"].ToString().Replace(".", ",");
                    _perc_icms = dr["pICMS"].ToString().Replace(".", ",");
                    _valor_icms = dr["vICMS"].ToString().Replace(".", ",");
                    ind_00++;
                }
            }
            catch { }
            try
            {
                dr = ds.Tables["ICMS10"].Rows[Convert.ToInt32(ind_10)];
                if (dr["ICMS_Id"].ToString() == n_item)
                {
                    _origem = dr["orig"].ToString();
                    _cst = dr["CST"].ToString();
                    _mod_bc = dr["modBC"].ToString();
                    _valor_bc = dr["vBC"].ToString().Replace(".", ",");
                    _perc_icms = dr["pICMS"].ToString().Replace(".", ",");
                    _valor_icms = dr["vICMS"].ToString().Replace(".", ",");
                    _mod_bc_st = dr["modBCST"].ToString();
                    try { _iva = dr["pMVAST"].ToString().Replace(".", ","); }
                    catch { }
                    try { _perc_reducao_st = dr["pRedBCST"].ToString().Replace(".", ","); }
                    catch { }
                    _valor_bc_icms_st = dr["vBCST"].ToString().Replace(".", ",");
                    _perc_icms_st = dr["pICMSST"].ToString().Replace(".", ",");
                    _valor_icms_st = dr["vICMSST"].ToString().Replace(".", ",");
                    ind_10++;
                }
            }
            catch { }
            try
            {
                dr = ds.Tables["ICMS20"].Rows[Convert.ToInt32(ind_20)];
                if (dr["ICMS_Id"].ToString() == n_item)
                {
                    _origem = dr["orig"].ToString();
                    _cst = dr["CST"].ToString();
                    _mod_bc = dr["modBC"].ToString();
                    _perc_reducao = dr["pRedBC"].ToString().Replace(".", ",");
                    _valor_bc = dr["vBC"].ToString().Replace(".", ",");
                    _perc_icms = dr["pICMS"].ToString().Replace(".", ",");
                    _valor_icms = dr["vICMS"].ToString().Replace(".", ",");
                    ind_20++;
                }
            }
            catch { }
            try
            {
                dr = ds.Tables["ICMS30"].Rows[Convert.ToInt32(ind_30)];
                if (dr["ICMS_Id"].ToString() == n_item)
                {
                    _origem = dr["orig"].ToString();
                    _cst = dr["CST"].ToString();
                    _mod_bc_st = dr["modBCST"].ToString();
                    try { _iva = dr["pMVAST"].ToString().Replace(".", ","); }
                    catch { }
                    try { _perc_reducao_st = dr["pRedBCST"].ToString().Replace(".", ","); }
                    catch { }
                    _valor_bc_icms_st = dr["vBCST"].ToString().Replace(".", ",");
                    _perc_icms_st = dr["pICMSST"].ToString().Replace(".", ",");
                    _valor_icms_st = dr["vICMSST"].ToString().Replace(".", ",");
                    ind_30++;
                }
            }
            catch { }
            try
            {
                dr = ds.Tables["ICMS40"].Rows[Convert.ToInt32(ind_40)];
                if (dr["ICMS_Id"].ToString() == n_item)
                {
                    _origem = dr["orig"].ToString();
                    _cst = dr["CST"].ToString();
                    ind_40++;
                }
            }
            catch { }
            try
            {
                dr = ds.Tables["ICMS41"].Rows[Convert.ToInt32(ind_41)];
                if (dr["ICMS_Id"].ToString() == n_item)
                {
                    _origem = dr["orig"].ToString();
                    _cst = dr["CST"].ToString();
                    ind_41++;
                }
            }
            catch { }
            try
            {
                dr = ds.Tables["ICMS50"].Rows[Convert.ToInt32(ind_50)];
                if (dr["ICMS_Id"].ToString() == n_item)
                {
                    _origem = dr["orig"].ToString();
                    _cst = dr["CST"].ToString();
                    ind_50++;
                }
            }
            catch { }
            try
            {
                dr = ds.Tables["ICMS51"].Rows[Convert.ToInt32(ind_51)];
                if (dr["ICMS_Id"].ToString() == n_item)
                {
                    _origem = dr["orig"].ToString();
                    _cst = dr["CST"].ToString();
                    try { _mod_bc = dr["modBC"].ToString().Replace(".", ","); }
                    catch { }
                    try { _perc_reducao = dr["pRedBC"].ToString().Replace(".", ","); }
                    catch { }
                    try { _valor_bc = dr["vBC"].ToString().Replace(".", ","); }
                    catch { }
                    try { _perc_icms = dr["pICMS"].ToString().Replace(".", ","); }
                    catch { }
                    try { _valor_icms = dr["vICMS"].ToString().Replace(".", ","); }
                    catch { }
                    ind_51++;
                }
            }
            catch { }
            try
            {
                dr = ds.Tables["ICMS60"].Rows[Convert.ToInt32(ind_60)];
                if (dr["ICMS_Id"].ToString() == n_item)
                {
                    _origem = dr["orig"].ToString();
                    _cst = dr["CST"].ToString();
                    try { _valor_bc_icms_st = dr["vBCST"].ToString().Replace(".", ","); }
                    catch { }
                    try { _valor_icms_st = dr["vICMSST"].ToString().Replace(".", ","); }
                    catch { }
                    try { _vbcstret = dr["vbcstret"].ToString().Replace(".", ","); }
                    catch { }
                    try { _pst = dr["pst"].ToString().Replace(".", ","); }
                    catch { }
                    try { _vicmssubstituto = dr["vicmssubstituto"].ToString().Replace(".", ","); }
                    catch { }
                    try { _vicmsstret = dr["vicmsstret"].ToString().Replace(".", ","); }
                    catch { }
                  //  out _vbcstret, out _pst, out _vicmssubstituto, out _vicmsstret
                    ind_60++;
                }
            }
            catch { }
            try
            {
                dr = ds.Tables["ICMS70"].Rows[Convert.ToInt32(ind_70)];
                if (dr["ICMS_Id"].ToString() == n_item)
                {
                    _origem = dr["orig"].ToString();
                    _cst = dr["CST"].ToString();
                    _mod_bc = dr["modBC"].ToString();
                    _perc_reducao = dr["pRedBC"].ToString().Replace(".", ",");
                    _valor_bc = dr["vBC"].ToString().Replace(".", ",");
                    _perc_icms = dr["pICMS"].ToString().Replace(".", ",");
                    _valor_icms = dr["vICMS"].ToString().Replace(".", ",");
                    _mod_bc_st = dr["modBCST"].ToString();
                    try { _iva = dr["pMVAST"].ToString().Replace(".", ","); }
                    catch { }
                    try { _perc_reducao_st = dr["pRedBCST"].ToString().Replace(".", ","); }
                    catch { }
                    _valor_bc_icms_st = dr["vBCST"].ToString().Replace(".", ",");
                    _perc_icms_st = dr["pICMSST"].ToString().Replace(".", ",");
                    _valor_icms_st = dr["vICMSST"].ToString().Replace(".", ",");
                    ind_70++;
                }
            }
            catch { }
            try
            {
                dr = ds.Tables["ICMS90"].Rows[Convert.ToInt32(ind_90)];
                if (dr["ICMS_Id"].ToString() == n_item)
                {
                    _origem = dr["orig"].ToString();
                    _cst = dr["CST"].ToString();
                    _mod_bc = dr["modBC"].ToString();
                    try { _perc_reducao = dr["pRedBC"].ToString().Replace(".", ","); }
                    catch { }
                    _valor_bc = dr["vBC"].ToString().Replace(".", ",");
                    _perc_icms = dr["pICMS"].ToString().Replace(".", ",");
                    _valor_icms = dr["vICMS"].ToString().Replace(".", ",");
                    _mod_bc_st = dr["modBCST"].ToString();
                    try { _iva = dr["pMVAST"].ToString().Replace(".", ","); }
                    catch { }
                    try { _perc_reducao_st = dr["pRedBCST"].ToString().Replace(".", ","); }
                    catch { }
                    _valor_bc_icms_st = dr["vBCST"].ToString().Replace(".", ",");
                    _perc_icms_st = dr["pICMSST"].ToString().Replace(".", ",");
                    _valor_icms_st = dr["vICMSST"].ToString().Replace(".", ",");
                    ind_90++;
                }
            }
            catch { }

        }

        private void buscar_dados_destinatario(string caminho)
        {
            try
            {
                DataSet ds = new DataSet();
                ds.ReadXml(@caminho);
                //DataTable dt = ds.Tables["ide"];
                string ie = "";
                foreach (DataRow dr in ds.Tables["dest"].Rows)
                {
                    tb_cnpj_destinatario.Text = dr["CNPJ"].ToString();
                    tb_razao_destinatario.Text = dr["xNome"].ToString();
                    ie = dr["IE"].ToString();
                }
                foreach (DataRow dr_end in ds.Tables["enderDest"].Rows)
                {
                    string fone = "99999999";
                    try{
                        fone = dr_end["fone"].ToString();
                    }
                    catch{}
                    string cep = "99999999";
                    try
                    {
                        cep = dr_end["CEP"].ToString();
                    }
                    catch { }
                    verificar_se_cliente_e_cadastrado(tb_cnpj_destinatario.Text, tb_razao_destinatario.Text, ie,
                        dr_end["xLgr"].ToString(), dr_end["nro"].ToString(), dr_end["xBairro"].ToString(),
                         dr_end["cMun"].ToString(), dr_end["xMun"].ToString(), dr_end["UF"].ToString(), cep
                          , fone ); 
                }

            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
            }
        }

        private void verificar_se_cliente_e_cadastrado(string cnpj, string razao, 
            string ie, string endereco, string numero, string bairro, 
            string codigo_cidade, string cidade, string estado, 
            string cep, string fone)
        {
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText = 
                    "SELECT CNPJ FROM CLIENTES WHERE CNPJ = '" + cnpj + "'";
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();
                bool existe = false;
                foreach(DataRow dr in dtSelect.Rows)
                {
                    existe = true;
                }

                if (!existe)
                {
                    FbCommand insert = new FbCommand();
                    insert.Connection = fbConnection1;
                    fbConnection1.Open();
                    insert.CommandText =
                        "INSERT INTO CLIENTES (CNPJ, IE, RAZAO_SOCIAL, ENDERECO, NUMERO_CLIENTE, BAIRRO, CIDADE, ESTADO, CEP_CLIENTE, " +
                        "FONE, COD_CIDADE_CLIENTE) " +
                        "VALUES ('" + cnpj + "','" + ie + "','" + razao + "','" + endereco + "','" + numero + "','" + 
                        bairro + "','" + cidade + "','" +
                        estado + "','" + cep + "','" + fone + "','" + codigo_cidade + "')";
                    FbDataAdapter datInsert = new FbDataAdapter();
                    datInsert.InsertCommand = insert;
                    datInsert.InsertCommand.ExecuteNonQuery();
                    fbConnection1.Close();
                }

            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
                fbConnection1.Close();
            }
        }

        private void buscar_dados_cliente_forn(string caminho)
        {
            try
            {
                DataSet ds = new DataSet();
                ds.ReadXml(@caminho);
                string ie = "";
               
                foreach (DataRow dr in ds.Tables["emit"].Rows)
                {
                    tb_cnpj_cliente.Text = dr["CNPJ"].ToString();
                    tb_cliente.Text = dr["xNome"].ToString();
                    ie = dr["IE"].ToString();
                    
                }
                foreach (DataRow dr_end in ds.Tables["enderEmit"].Rows)
                {
                    tb_estado_cliente.Text = dr_end["UF"].ToString();
                }
                foreach (DataRow dr_end in ds.Tables["enderEmit"].Rows)
                {
                    string fone = "99999999";
                    try
                    {
                        fone = dr_end["fone"].ToString();
                    }
                    catch { }
                    string cep = "99999999";
                    try
                    {
                        cep = dr_end["CEP"].ToString();
                    }
                    catch { }
                    verificar_se_cliente_e_cadastrado(tb_cnpj_cliente.Text, tb_cliente.Text, ie,
                        dr_end["xLgr"].ToString(), dr_end["nro"].ToString(), dr_end["xBairro"].ToString(),
                         dr_end["cMun"].ToString(), dr_end["xMun"].ToString(), dr_end["UF"].ToString(), cep
                          , fone);
                }

            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
            }
        }

        protected void apagar_campos(Control ctrl)
        {
            foreach (Control c in ctrl.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }

                if (c.HasChildren)
                {
                    apagar_campos(c);
                }
            }
            foreach (Control d in ctrl.Controls)
            {
                if (d is System.Windows.Forms.RadioButton)
                {
                    ((System.Windows.Forms.RadioButton)(d)).Checked = false;
                }

                if (d.HasChildren)
                {
                    apagar_campos(d);
                }
            }
            foreach (Control e in ctrl.Controls)
            {
                if (e is System.Windows.Forms.CheckBox)
                {
                    ((System.Windows.Forms.CheckBox)(e)).Checked = false;
                }

                if (e.HasChildren)
                {
                    apagar_campos(e);
                }
            }
        }

        private void buscar_dados_nf(string caminho)
        {
            try
            {
                DataSet ds = new DataSet();
                ds.ReadXml(@caminho);
                //DataTable dt = ds.Tables["ide"];
                foreach (DataRow dr in ds.Tables["ide"].Rows)
                {
                    tb_n_nf.Text = dr["nNF"].ToString();
                    tb_natureza_operacao.Text = dr["natOp"].ToString();
                    tb_data_emissao.Text = Convert.ToDateTime(dr["dhEmi"].ToString()).ToShortDateString();
                    tb_ent_sai_nfe.Text = dr["tpNF"].ToString();
                }

            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //if (verificarSeTemPedido())
            //{
            //    if(verificarSePedidoIgualNF())
            //        MessageBox.Show("O Pedido inserido é igual a NF. Se houver Nota Fiscal isso não pode acontecer. Verifique.");
                
            //}
            //else
            //{
            //    MessageBox.Show("É necessário indicar o Pedido e o item do Pedido para confirmar a NF nos itens de Vendas ou Industrialização.");
            //}
            baixar_nf();
        }

        private bool verificarSePedidoIgualNF()
        {
            for (int i = 0; i < dgvItens_nota.RowCount; i++)
            {
                try
                {
                    string ped = dgvItens_nota.Rows[i].Cells["col_pedido"].Value.ToString();
                    string nPed = dgvItens_nota.Rows[i].Cells["col_n_linha_ped"].Value.ToString();
                    string cfop = dgvItens_nota.Rows[i].Cells["col_cfo"].Value.ToString();

                    if (cfop.Substring(1, 1) == "1" || cfop.Substring(1, 1) == "4")
                    {
                        if (ped != tb_n_nf.Text)
                        {
                            return false;// MessageBox.Show("É necessário colocar Pedido de Compra em todos os itens de compra ou industrialização antes de confirmar a nota");
                        }
                    }

                }
                catch
                {
                    return false;
                }
            }
            return true;
        }
        private bool verificarSeTemPedido()
        {
            for (int i = 0; i < dgvItens_nota.RowCount; i++)
            {
                try
                {
                    string ped = dgvItens_nota.Rows[i].Cells["col_pedido"].Value.ToString();
                    string nPed = dgvItens_nota.Rows[i].Cells["col_n_linha_ped"].Value.ToString();
                    string cfop = dgvItens_nota.Rows[i].Cells["col_cfo"].Value.ToString();
                   
                    if (cfop.Substring(1, 1) == "1" || cfop.Substring(1, 1) == "4")
                    {
                        if((ped == "" || nPed == ""))
                        {
                            return false;// MessageBox.Show("É necessário colocar Pedido de Compra em todos os itens de compra ou industrialização antes de confirmar a nota");
                        }
                    }

                }
                catch
                {
                    return false;
                }
            }
            return true;
        }

        private bool verificarPedido()
        {
            for (int i = 0; i < dgvItens_nota.RowCount; i++)
            {
                try
                {
                    int ped = Convert.ToInt32(dgvItens_nota.Rows[i].Cells["col_pedido"].Value.ToString());
                    int nPed = Convert.ToInt32(dgvItens_nota.Rows[i].Cells["col_n_linha_ped"].Value.ToString());
                    string codPed, codReq, codEst;
                    buscar_informacoes_no_pedido(ped.ToString(), nPed.ToString(), out codReq, out codPed, out codEst);
                    if (codPed == "")
                    {
                        return false;
                    }
                }
                catch
                {
                    return false;
                }
            }
            return true;
        }

        private void buscar_informacoes_no_pedido(string pedido, string n_linha, out string cod_req, out string cod_ped, out string cod_est)
        {
            cod_req = ""; cod_ped = ""; cod_est = "";
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                select.CommandText =
                    "SELECT COD_ITEM_PED, COD_ITEM_REQ_ITEM_PED, COD_ESTOQUE_ITEM_PED " +
                    "FROM ITENS_PEDIDO_COMPRA WHERE N_PEDIDO_ITEM_PED = '" + pedido + "' ORDER BY COD_ITEM_PED";
                FbDataAdapter datPedido_compra = new FbDataAdapter();
                fbConnection1.Open();
                datPedido_compra.SelectCommand = select;
                DataSet dsPedido_compra = new DataSet();
                datPedido_compra.Fill(dsPedido_compra);
                fbConnection1.Close();
                DataRow dr;
                int linha = Convert.ToInt32(n_linha) - 1;
                try
                {
                    dr = dsPedido_compra.Tables[0].Rows[linha];
                    cod_ped = dr[0].ToString();
                    cod_req = dr[1].ToString();
                    cod_est = dr[2].ToString();
                }
                catch { }
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                //MessageBox.Show(a.ToString());
            }
        }

        private void update_item_nf_ent(string cod_estoque, string cod_item_nf, out string almoxarifado)
        {
            almoxarifado = "";
            try
            {
                FbCommand update = new FbCommand();
                update.Connection = fbConnection1;
                fbConnection1.Open();
                if (cod_estoque != "")
                {
                    //VERIFICANDO O TIPO DE ITEM DO ESTOQUE
                    FbCommand select = new FbCommand();
                    select.Connection = fbConnection1;
                    select.CommandText =
                        "SELECT TIPO_ITEM_ESTOQUE FROM ESTOQUE WHERE COD_ESTOQUE = '" + cod_estoque + "'";
                    FbDataAdapter datEstoque = new FbDataAdapter();
                    datEstoque.SelectCommand = select;
                    DataSet dsEstoque = new DataSet();
                    datEstoque.Fill(dsEstoque);
                    foreach (DataRow dr in dsEstoque.Tables[0].Rows)
                    {
                        try
                        {

                            //SE FOR MATERIA PRIMA APENAS MARCA MATERIA PRIMA POIS AINDA VAI PASSAR PELA QUALIDADE ANTES DE DAR ENTRADA
                            /*
                            if (dr[0].ToString() != "")
                            {
                                if (dr[0].ToString()[1].ToString() == "1")
                                {
                                    almoxarifado = "0";
                                    update.CommandText =
                                        "UPDATE ITENS_NOTA_ENT SET MATERIA_PRIMA_ITEM_ENT = '1' WHERE COD_ITENS_NOTA_ENT = '" + cod_item_nf + "'";
                                    FbDataAdapter itens_nfDataAdapter = new FbDataAdapter();
                                    itens_nfDataAdapter.UpdateCommand = update;
                                    itens_nfDataAdapter.UpdateCommand.ExecuteNonQuery();
                                }
                                else // SE NÃO FOR MATERIA PRIMA MARCA COMO BAIXADO (VAI CONTAR NO ESTOQUE)
                                {
                                    almoxarifado = "1";
                                    update.CommandText =
                                        "UPDATE ITENS_NOTA_ENT SET BAIXADO_ITEM_ENT = '1', ALMOXARIFADO_ITEM_ENT = '1' WHERE COD_ITENS_NOTA_ENT = '" + cod_item_nf + "'";
                                    FbDataAdapter itens_nfDataAdapter = new FbDataAdapter();
                                    itens_nfDataAdapter.UpdateCommand = update;
                                    itens_nfDataAdapter.UpdateCommand.ExecuteNonQuery();
                                }
                            }
                            else // SE NÃO FOR MATERIA PRIMA MARCA COMO BAIXADO (VAI CONTAR NO ESTOQUE)
                            {
                            */
                                almoxarifado = "1";
                                update.CommandText =
                                    //"UPDATE ITENS_NOTA_ENT SET BAIXADO_ITEM_ENT = '1', ALMOXARIFADO_ITEM_ENT = '1' WHERE COD_ITENS_NOTA_ENT = '" + cod_item_nf + "'";
                                    "UPDATE ITENS_NOTA_ENT SET BAIXADO_ITEM_ENT = '1' WHERE COD_ITENS_NOTA_ENT = '" + cod_item_nf + "'";
                            FbDataAdapter itens_nfDataAdapter = new FbDataAdapter();
                                itens_nfDataAdapter.UpdateCommand = update;
                                itens_nfDataAdapter.UpdateCommand.ExecuteNonQuery();
                           // }
                            fbConnection1.Close();
                        }
                        catch
                        {
                            fbConnection1.Close();
                        }
                    }
                    fbConnection1.Close();
                }
                else
                {
                    almoxarifado = "1";
                    update.CommandText =
                                   "UPDATE ITENS_NOTA_ENT SET BAIXADO_ITEM_ENT = '1', ALMOXARIFADO_ITEM_ENT = '1' WHERE COD_ITENS_NOTA_ENT = '" + cod_item_nf + "'";
                    FbDataAdapter itens_nfDataAdapter = new FbDataAdapter();
                    itens_nfDataAdapter.UpdateCommand = update;
                    itens_nfDataAdapter.UpdateCommand.ExecuteNonQuery();
                    fbConnection1.Close();
                }
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private void baixar_nf()
        {
            if (!cbBaixada.Checked)
            {
               // if (verificarPedido())
               // {
                tb_saida.Text = DateTime.Now.ToShortDateString();

                    for (int i = 0; i < dgvItens_nota.RowCount; i++)
                    {
                        string cod_req, cod_ped, cod_est;
                        buscar_informacoes_no_pedido(dgvItens_nota.Rows[i].Cells["col_pedido"].Value.ToString(),
                            dgvItens_nota.Rows[i].Cells["col_n_linha_ped"].Value.ToString(), out cod_req, out cod_ped, out cod_est);
                        try
                        {
                            if (cod_req != "")
                                dgvItens_nota.Rows[i].Cells["col_cod_item_req"].Value = cod_req;
                        }
                        catch { }
                        try
                        {
                            if (cod_ped != "")
                                dgvItens_nota.Rows[i].Cells["col_cod_item_ped"].Value = cod_ped;
                        }
                        catch { }
                        try
                        {
                            if (cod_est != "")
                                dgvItens_nota.Rows[i].Cells["col_cod_item_est"].Value = cod_est;
                        }
                        catch { }
                        try
                        {
                            Convert.ToDateTime(tb_saida.Text);
                        }
                        catch
                        {
                            tb_saida.Text = DateTime.Now.ToShortDateString();
                        }
                        cbBaixada.Checked = true;
                        atualizar();
                        string almoxarifado = "";
                        update_item_nf_ent(dgvItens_nota.Rows[i].Cells["col_cod_item_est"].Value.ToString(),
                            dgvItens_nota.Rows[i].Cells["col_cod_item"].Value.ToString(), out almoxarifado);
                        if (cod_ped.Trim() != "")
                        {
                            update_item_req(cod_ped);
                            update_item_ped(cod_ped);
                        }

                        update_item_estoque(dgvItens_nota.Rows[i].Cells["col_cod_item_est"].Value.ToString(),
                            dgvItens_nota.Rows[i].Cells["col_preco_total"].Value.ToString(),
                            dgvItens_nota.Rows[i].Cells["col_qtde"].Value.ToString(),
                            dgvItens_nota.Rows[i].Cells["col_qtde_lote"].Value.ToString(),
                            dgvItens_nota.Rows[i].Cells["col_ncm"].Value.ToString(),
                            dgvItens_nota.Rows[i].Cells["col_unidade"].Value.ToString());


                        if (almoxarifado == "1")
                        {
                            classeEstoque est = new classeEstoque();
                            est.fbConnection1.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=True;Packet Size=8192;Server Type=0";
                            est.calcular_estoque(dgvItens_nota.Rows[i].Cells["col_cod_item_est"].Value.ToString());
                        }
                        else
                        {
                            //verificar entrada de materia prima como vai ficar conforme o calculo que já é feito na saída do material da Bralyx
                        }

                    }
                    inserir_cp();
                    MessageBox.Show("Nf Baixada");
              //  }
               // else
              //  {
              //      MessageBox.Show("Insira o Pedido de Compra e o nº da linha em todos os itens");
              //  }
            }
            else
            {
                MessageBox.Show("Esta Nota Fiscal já foi Baixada");
            }
        }

        private void baixar_nf_old()
        {
            if (tb_ent_sai_nfe.Text != "")
            {
                try
                {
                    List<string> itens = new List<string>();
                    if (existem_itens_com_estoque_negativo(out itens))
                    {
                        string total = "";
                        for (int i = 0; i < itens.Count; i++)
                        {
                            total = total + itens[i] + "\n";
                        }
                        MessageBox.Show("O(s) item(ns): " + total + " estão com estoque negativo, Verifique.");
                    }

                    if (!cbBaixada.Checked)
                    {

                        cbBaixada.Checked = true;

                        //tb_saida.Text = DateTime.Now.ToShortDateString();
                        atualizar();

                        for (int i = 0; i < dgvItens_nota.RowCount; i++)
                        {
                            try
                            {
                                string cfop = dgvItens_nota.Rows[i].Cells["col_cfo"].Value.ToString();
                                string codFornecedor = dgvItens_nota.Rows[i].Cells["colCodFornecedor"].Value.ToString();
                                update_item_nf_ent(dgvItens_nota.Rows[i].Cells["col_cod_item"].Value.ToString());
                                if (cfop != "5411" &&
                                    cfop != "6411" &&
                                    cfop != "5202" &&
                                    cfop != "6202" &&
                                    cfop != "5949" &&
                                    cfop != "6949")
                                {
                                    if (custo_automatico_empresa == "1" && tb_cnpj_destinatario.Text == cnpj_empresa)
                                    {
                                        acertar_custo_produto(dgvItens_nota.Rows[i].Cells["colCodBarras"].Value.ToString(),
                                            dgvItens_nota.Rows[i].Cells["col_qtde"].Value.ToString(),
                                            dgvItens_nota.Rows[i].Cells["col_valor_unit"].Value.ToString(),
                                            dgvItens_nota.Rows[i].Cells["col_valor_ipi"].Value.ToString(),
                                            dgvItens_nota.Rows[i].Cells["col_valor_st"].Value.ToString(),
                                            dgvItens_nota.Rows[i].Cells["col_desconto"].Value.ToString());
                                    }
                                }


                            }
                            catch (Exception a)
                            {
                                MessageBox.Show(a.Message);
                            }

                            classeEstoque_material est = new classeEstoque_material();
                            est.fbConnection1.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=True;Packet Size=8192;Server Type=0";
                            est.calcular_estoque(dgvItens_nota.Rows[i].Cells["col_cod_item_est"].Value.ToString());

                        }

                        //MessageBox.Show("Parar");
                        classe_particularidades part = new classe_particularidades();
                        part.executar_particularidades(tb_cod_interno.Text);
                        part.insere_estoque();

                        int temInvalido = 0;

                        foreach (string eanInvalidos in part.EANnaoEncontrado)
                        {
                            for (int i = 0; i < dgvItens_nota.RowCount; i++)
                            {
                                if (dgvItens_nota.Rows[i].Cells["colCodBarras"].Value.ToString() == eanInvalidos)
                                {
                                    dgvItens_nota.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                                    temInvalido++;
                                    //MessageBox.Show("Código EAN não encontrado!\nVerifique os itens");
                                }
                            }
                        }

                            if (tb_cod_vendedor.Text != "")
                            {
                                inserir_pedido_de_nf_entrada();
                            }
                            if (!importar_conjunto && !tb_cliente.Text.ToUpper().Contains("CLARA"))
                            {
                                inserir_cp();
                                

                            }
                            MessageBox.Show("NF baixada com sucesso!");

                    }
                    else
                    {
                        MessageBox.Show("Esta Nota Fiscal já foi Baixada");
                    }

                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message);
                }
            }
            else
            {
                MessageBox.Show("Digite a data de entrada da NF por favor");
            }


        }

        private bool existem_itens_com_estoque_negativo(out List<string> itens)
        {
            bool retorno = false;
            itens = new List<string>();
            try
            {
                FbCommand select = new FbCommand();
                select.CommandText =
                    "SELECT COD_PRODUTO, DESCRICAO_PRODUTO, COD_BARRAS_PRODUTO FROM PRODUTOS WHERE ESTOQUE_ATUAL_PRODUTO < 0";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();

                for (int i = 0; i < dgvItens_nota.Rows.Count; i++)
                {
                    foreach (DataRow dr in dtSelect.Select("COD_BARRAS_PRODUTO = '" + dgvItens_nota.Rows[i].Cells["colCodBarras"].Value.ToString() + "'"))
                    {
                        itens.Add(dr["DESCRICAO_PRODUTO"].ToString());
                        retorno = true;
                    }
                }
                return retorno;
                
            }
            catch(Exception ex) 
            {
                fbConnection1.Close();
                MessageBox.Show(ex.Message);
                return retorno;
            }
        }

        public bool verificaPedidoUnico(string cnpj, string nf_entrada)
        {

            
          
            FbConnection conexao = new FbConnection();
            try
            {

                FbCommand select = new FbCommand();

                conexao.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=False; MaxPoolSize = 100;Packet Size=8192;Server Type=0";
                select.CommandText =
                    "SELECT * FROM PEDIDOS_VENDA WHERE CNPJ_PED_VENDA = " + cnpj + " AND NF_ENTRADA_PED_VENDA = " + nf_entrada;
                select.Connection = conexao;
                conexao.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataSet dsSelect = new DataSet();

                datSelect.Fill(dsSelect);
                conexao.Close(); conexao.Dispose();
                foreach (DataRow drPedido in dsSelect.Tables[0].Rows)
                {
                    return true;
                }
                return false;
            }
            catch (Exception a)
            {
                conexao.Close(); conexao.Dispose();
                return false;
            }
        }

        private void buscar_dados_produto(string ean, out string cod, out double qtde, out string unidade, out string descricao)
        {
            cod = ""; qtde = 1; unidade = "UN"; descricao = "ERRO";
            FbConnection conexao = new FbConnection();
            try
            {
                FbCommand select = new FbCommand();

                conexao.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=False; MaxPoolSize = 100;Packet Size=8192;Server Type=0";
                select.CommandText =
                    "SELECT COD_FORNECEDOR_PRODUTO, QTDE_UNIDADE_PRODUTO, COD_UNIDADE_PRODUTO, DESCRICAO_PRODUTO " + 
                    "FROM PRODUTOS WHERE (COD_BARRAS_PRODUTO = '" + ean + "' or COD_BARRAS_CAIXA_PRODUTO = '" + ean + "')";
                select.Connection = conexao;
                conexao.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                conexao.Close(); conexao.Dispose();
                foreach (DataRow dr in dtSelect.Rows)
                {
                    cod = dr[0].ToString();
                    unidade = dr[2].ToString();
                    descricao = dr[3].ToString();
                    try
                    {
                        qtde = Convert.ToDouble(dr[1].ToString());
                    }
                    catch { }
                }
                
            }
            catch
            {
                conexao.Close(); conexao.Dispose();
                
            }
        }

        private string buscar_ean_produto(string idProduto, out string dun, out string qtde, out string cnpj)
        {
            dun = ""; qtde = ""; cnpj = "";
            string retorno = "null"; FbConnection conexao = new FbConnection();
            try
            {
                FbCommand select = new FbCommand();

                conexao.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=False; MaxPoolSize = 100;Packet Size=8192;Server Type=0";
                select.CommandText =
                    "SELECT COD_BARRAS_PRODUTO, COD_BARRAS_CAIXA_PRODUTO, QTDE_UNIDADE_PRODUTO, CNPJ_FORNECEDOR_PRODUTO FROM PRODUTOS WHERE COD_PRODUTO = " + idProduto + "";
                select.Connection = conexao;
                conexao.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                conexao.Close(); conexao.Dispose();
                foreach (DataRow dr in dtSelect.Rows)
                {
                    dun = dr[1].ToString(); qtde = dr[2].ToString(); cnpj = dr[3].ToString();
                    if (dr[0].ToString() != "")
                        return dr[0].ToString();
                }
                return retorno;
            }
            catch
            {
                conexao.Close(); conexao.Dispose();
                return retorno;
            }
        }
        private bool inserir_pedido_de_nf_entrada()
        {
            try
            {

                string idPedido = "", clientePedido = "", dataPedido = "", cnpjPedido = "", totalProdutoPedido = "null", totalPedido = "null",
                    totalDescontoPedido = "null", nomeVendedorPedido = "", codVendedorPedido = "null", idClientePedido = "null",
                    qtdeItens = "null", dataEntrega = "null", condPgto = "", obsPedido = "", troca = "null", bonificacao = "null",
                    venda_direta = "null", fechado = "null", saida_venda_direta = "null", nf_entrada = "null";
                string idItemPedido = "null", idPedidoItem = "null", idProduto = "null", nomeProduto = "", unidadeProduto = "",
                    qtdeItem = "null", valorUnitarioItem = "null", valorTotalItem = "null", porcItem = "null";

                string codUsuario = "";

                codUsuario = tb_cod_vendedor.Text;



                idPedido = "0";
                dataPedido = tb_data_emissao.Text.Replace("/",".");
                clientePedido = tb_cliente.Text;
                cnpjPedido = tb_cnpj_cliente.Text;

                qtdeItens = dgvItens_nota.RowCount.ToString();
                int _qtdeItens = 0;
                try
                {
                    _qtdeItens = Convert.ToInt32(qtdeItens);
                }
                catch
                { }
                totalProdutoPedido = tb_total_prod.Text;
                totalPedido = tb_total_nota.Text;
                totalDescontoPedido = "0,00";
                nomeVendedorPedido = tb_vendedor.Text;
                codVendedorPedido = tb_cod_vendedor.Text;
                idClientePedido = "0";

                dataEntrega =  tb_data_emissao.Text.Replace("/",".");
                condPgto = "";
                obsPedido = "";

                try
                {
                    troca = "0";
                    bonificacao = "0";
                    venda_direta = "0";
                    saida_venda_direta = "1";
                    nf_entrada = tb_n_nf.Text;
                    if (troca == "1")
                        obsPedido += " SR. MOTORISTA RETIRAR PRODUTOS AVARIADOS OU VENCIDOS / IDENTIFICADOS COM OS ITENS EM NOTA FISCAL / NÃO REALIZAR TROCA SE ESTIVER COM PRODUTOS FALTANDO";
                    if (troca == "")
                        troca = "0";
                    if (bonificacao == "")
                        bonificacao = "0";
                    if (venda_direta == "")
                    {
                        venda_direta = "0";
                    }
                    if (venda_direta == "1")
                    {
                        fechado = "1";
                    }
                }
                catch { }

                try
                {
                    Convert.ToDouble(totalProdutoPedido);
                    totalProdutoPedido = "'" + totalProdutoPedido.Replace(".","").Replace(",",".") + "'";
                }
                catch { }
                try
                {
                    Convert.ToDouble(totalPedido);
                    if (totalPedido != "")
                        totalPedido = "'" + totalPedido.Replace(".", "").Replace(",", ".") + "'";
                }
                catch { }
                try
                {
                    Convert.ToDouble(totalDescontoPedido);
                    if (totalDescontoPedido != "")
                        totalDescontoPedido = "'" + totalDescontoPedido.Replace(".", "").Replace(",", ".") + "'";
                }
                catch { }
                try
                {
                    Convert.ToInt32(codVendedorPedido);
                    if (codVendedorPedido != "")
                        codVendedorPedido = "'" + codVendedorPedido + "'";
                }
                catch { }
                try
                {
                    Convert.ToInt32(idClientePedido);
                    if (idClientePedido != "")
                        idClientePedido = "'" + idClientePedido + "'";
                }
                catch { }
                try
                {
                    Convert.ToInt32(qtdeItens);
                    if (qtdeItens != "")
                        qtdeItens = "'" + qtdeItens + "'";
                }
                catch { }
                try
                {
                    Convert.ToDateTime(dataEntrega);
                    if (dataEntrega != "")
                        dataEntrega = "'" + dataEntrega.Replace("/", ".") + "'";
                }
                catch { dataEntrega = "null"; }
                string id = "";
                double _total = 0;
                try
                {
                    _total = Convert.ToDouble(tb_total_nota.Text);
                }
                catch { }
                if (_total > 0)
                {
                    if (!verificaPedidoUnico(cnpjPedido, tb_n_nf.Text))
                    {
                        FbCommand insert = new FbCommand();
                        FbConnection conexao = new FbConnection();

                        try
                        {
                            insert.Connection = conexao;
                            conexao.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=False; MaxPoolSize = 100;Packet Size=8192;Server Type=0";
                            insert.CommandText =
                                "INSERT INTO PEDIDOS_VENDA " +
                                "(DATA_PED_VENDA," +
                                "CLIENTE_PED_VENDA, " +
                                "CNPJ_PED_VENDA, " +
                                "VALOR_TOTAL_PROD_PED_VENDA, " +
                                "VALOR_TOTAL_PED_VENDA, " +
                                "VALOR_DESCONTO_PED_VENDA, " +
                                "VENDEDOR_PED_VENDA, " +
                                "COD_VENDEDOR_PED_VENDA, " +
                                "ID_PEDIDO_CEL_PED_VENDA, " +
                                "QTDE_ITENS_PED_VENDA, " +
                                "DATA_ENTREGA_PED_VENDA, " +
                                "COND_PGTO_PED_VENDA, " +
                                "OBS_PED_VENDA, " +
                                "BONIFICACAO_PED_VENDA, " +
                                "TROCA_PED_VENDA, " +
                                "VENDA_DIRETA_PED_VENDA, " +
                                "BAIXADO_ESTOQUE_PED_VENDA, " +
                                "SAIDA_VENDA_DIRETA_PED_VENDA, " +
                                "NF_ENTRADA_PED_VENDA) " +
                                "VALUES ('" + dataPedido + "'," +
                                "'" + clientePedido.Replace("'", "") + "'," +
                                "'" + cnpjPedido.Replace("'", "") + "'," +
                                totalProdutoPedido + "," +
                                totalPedido + "," +
                                totalDescontoPedido + "," +
                                "'" + nomeVendedorPedido + "'," +
                                codUsuario + ", " +
                                "'" + idPedido + "', " +
                                qtdeItens + ", " +
                                dataEntrega + ", " +
                                "'" + condPgto + "', " +
                                "'" + obsPedido + "'," +
                                bonificacao + "," +
                                troca + "," +
                                venda_direta + "," +
                                fechado + "," +
                                saida_venda_direta + "," +
                                nf_entrada + ")";
                            conexao.Open();
                            insert.ExecuteNonQuery();
                            conexao.Close();
                            try
                            {
                                conexao = new FbConnection();
                                string idPedidoSistema = "";
                                try
                                {

                                    FbCommand select = new FbCommand();
                                    conexao.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=False; MaxPoolSize = 100;Packet Size=8192;Server Type=0";
                                    select.CommandText =
                                        "SELECT * FROM PEDIDOS_VENDA WHERE nf_entrada_ped_venda = " + tb_n_nf.Text;
                                    select.Connection = conexao;
                                    conexao.Open();
                                    FbDataAdapter datSelect = new FbDataAdapter();
                                    datSelect.SelectCommand = select;
                                    DataSet dsSelect = new DataSet();
                                    datSelect.Fill(dsSelect);
                                    conexao.Close(); conexao.Dispose();
                                    DataRow drProduto = dsSelect.Tables[0].Rows[0];
                                    idPedidoSistema = "'" + drProduto[0].ToString() + "'";
                                }
                                catch (Exception a)
                                {
                                    fbConnection1.Close();
                                }
                                for (int i = 0; i < dgvItens_nota.Rows.Count; i++)
                                {
                                    int baixado = 0;
                                    try
                                    {
                                        string cod_produto = "";
                                        double qtde_caixa = 1;
                                        string unidade = "UN";
                                        string descricao = "";
                                        buscar_dados_produto(dgvItens_nota.Rows[i].Cells["colCodBarras"].Value.ToString(), out cod_produto, out qtde_caixa, out unidade, out descricao);
                                        idItemPedido = "0";
                                        idPedidoItem = "0";
                                        idProduto = cod_produto;
                                        nomeProduto = descricao;
                                        unidadeProduto = unidade;
                                        double qtde_total_item = 0;
                                        qtde_total_item = Convert.ToDouble(dgvItens_nota.Rows[i].Cells["col_qtde"].Value.ToString()) * qtde_caixa;
                                        qtdeItem = qtde_total_item.ToString("n2");

                                        valorUnitarioItem = dgvItens_nota.Rows[i].Cells["col_valor_unit"].Value.ToString();
                                        valorTotalItem = Convert.ToDouble(dgvItens_nota.Rows[i].Cells["col_preco_total"].Value.ToString()).ToString("n2");

                                        porcItem = "0,00";
                                        try
                                        {
                                            Convert.ToInt32(idItemPedido);
                                            if (idItemPedido != "")
                                                idItemPedido = "'" + idItemPedido + "'";
                                        }
                                        catch { }
                                        try
                                        {
                                            Convert.ToInt32(idProduto);
                                            if (idProduto != "")
                                                idProduto = "'" + idProduto + "'";
                                        }
                                        catch { }
                                        try
                                        {
                                            Convert.ToDouble(qtdeItem);
                                            if (qtdeItem != "")
                                                qtdeItem = "'" + qtdeItem.Replace(".", "").Replace(",", ".") + "'";
                                        }
                                        catch { }
                                        try
                                        {
                                            Convert.ToDouble(valorUnitarioItem);
                                            if (valorUnitarioItem != "")
                                                valorUnitarioItem = "'" + valorUnitarioItem.Replace(".", "").Replace(",", ".") + "'";
                                        }
                                        catch { }
                                        try
                                        {
                                            Convert.ToDouble(valorTotalItem);
                                            if (valorTotalItem != "")
                                                valorTotalItem = "'" + valorTotalItem.Replace(".", "").Replace(",", ".") + "'";
                                        }
                                        catch { }
                                        try
                                        {
                                            Convert.ToDouble(porcItem);
                                            if (porcItem != "")
                                                porcItem = "'" + porcItem.Replace(".", "").Replace(",", ".") + "'";
                                        }
                                        catch { porcItem = "null"; }

                                        FbCommand insertItem = new FbCommand();
                                        FbConnection _conexao = new FbConnection();
                                        try
                                        {
                                            string _dun, _qtde, _cnpj;
                                            string ean = buscar_ean_produto(idProduto, out _dun, out _qtde, out _cnpj);
                                            if (ean != "null")
                                                ean = "'" + ean + "'";

                                            double custo_produto = 0;
                                            try
                                            {
                                                custo_produto = 0;
                                            }
                                            catch { }

                                            _conexao.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=False; MaxPoolSize = 100;Packet Size=8192;Server Type=0";
                                            insertItem.Connection = _conexao;
                                            insertItem.CommandText =
                                                "INSERT INTO ITENS_PEDIDO_VENDA " +
                                                "(QTDE_ITEM_VENDA," +
                                                "DESCRICAO_PROD_ITEM_VENDA, " +
                                                "VALOR_UNIT_PROD_ITEM_VENDA, " +
                                                "VALOR_TOTAL_PROD_ITEM_VENDA, " +
                                                "UNIDADE_PROD_ITEM_VENDA, " +
                                                "COD_PEDIDO_ITEM_VENDA, " +
                                                "COD_VENDEDOR_ITEM_VENDA, " +
                                                "COD_SISTEMA_PROD_ITEM_VENDA, COD_PROD_ITEM_VENDA, " +
                                                "PORC_DESC_ITEM_VENDA, EAN_ITEM_VENDA, CUSTO_ITEM_VENDA) " +
                                                "VALUES (" + qtdeItem + "," +
                                                "'" + nomeProduto + "'," +
                                                valorUnitarioItem + "," +
                                                valorTotalItem + "," +
                                                "'UN'," +
                                                idPedidoSistema + "," +
                                                codUsuario + "," +
                                                idProduto + "," + idProduto + "," +
                                                porcItem + "," + ean + "," +
                                                custo_produto.ToString("n2").Replace(".", "").Replace(",", ".") + ")";
                                            _conexao.Open();

                                            insertItem.ExecuteNonQuery();
                                            _conexao.Close(); _conexao.Dispose();

                                            string log2 = "";

                                            try
                                            {
                                                classeEstoque estoque = new classeEstoque();
                                                estoque.fbConnection1.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=False; MaxPoolSize = 100;Packet Size=8192;Server Type=0";
                                                estoque.calcular_estoque("");
                                            }
                                            catch { }


                                        }
                                        catch (Exception a)
                                        {

                                            _conexao.Close(); _conexao.Dispose();
                                            return false;
                                        }
                                    }

                                    catch (Exception a)
                                    {
                                        return false;
                                    }
                                }
                            }
                            catch (Exception a)
                            {
                                conexao.Close(); conexao.Dispose();
                                return false;
                            }
                        }
                        catch (Exception a)
                        {
                            conexao.Close(); conexao.Dispose();
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }

                }


                return true;
            }
            catch { return false; }
        }

        private void acertar_custo_produto(string codBarras, string qtde_nota, string valor_nota, string valor_st, string valor_ipi, string desconto)
        {
            try
            {
                //BUSCANDO CUSTOS ATUAIS DO PRODUTO
                FbCommand select = new FbCommand();
                select.CommandText =
                    "SELECT * FROM PRODUTOS WHERE COD_BARRAS_CAIXA_PRODUTO = '" + codBarras + "' OR COD_BARRAS_PRODUTO = '" + codBarras + "'";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();
                double qtde_atual = 0;
                double valor_custo_atual = 0;
                double qtde_por_caixa = 0;
              
                foreach (DataRow dr in dtSelect.Rows)
                {
                    try
                    {
                        qtde_atual = Convert.ToDouble(dr["ESTOQUE_ATUAL_PRODUTO"].ToString());
                        if (qtde_atual < 0)
                            qtde_atual = 0;
                    }
                    catch { }
                    try
                    {
                        valor_custo_atual = Convert.ToDouble(dr["CUSTO_PRODUTO"].ToString());
                    }
                    catch { }
                    try
                    {
                        qtde_por_caixa = Convert.ToDouble(dr["QTDE_UNIDADE_PRODUTO"].ToString());
                    }
                    catch { }
                }

                //CALCULANDO CUSTO DA NOTA
                double qtde_total_nota = 0;
                try
                {
                    qtde_total_nota = Convert.ToDouble(qtde_nota) * qtde_por_caixa;
                }
                catch { }

                double valor_unit_nota = 0;
                try
                {
                    double _valor_st = 0;
                    double _valor_ipi = 0;
                    double _desconto = 0;
                    try
                    {
                        _desconto = Convert.ToDouble(desconto) / Convert.ToDouble(qtde_nota);
                    }
                    catch { }
                    try
                    {
                        _valor_st = Convert.ToDouble(valor_st) / Convert.ToDouble(qtde_nota);
                    }
                    catch { }
                    try
                    {
                        _valor_ipi = Convert.ToDouble(valor_ipi) / Convert.ToDouble(qtde_nota);
                    }
                    catch { }

                    //double valor_nota_st_ipi = 0;
                    //try
                    //{
                    //    valor_nota_st_ipi = Convert.ToDouble(valor_nota);
                    //    valor_nota_st_ipi = valor_nota_st_ipi + _valor_st + _valor_ipi;
                    //}
                    //catch { }
                    valor_unit_nota = (Convert.ToDouble(valor_nota) + _valor_st + _valor_ipi - _desconto) / qtde_por_caixa;
                   // valor_unit_nota = valor_unit_nota + _valor_st + _valor_ipi;
                }
                catch { }

                double qtde_total_geral = qtde_total_nota + qtde_atual;
                double valor_total_atual = qtde_atual * valor_custo_atual;
                double valor_total_nota = qtde_total_nota * valor_unit_nota;

                double valor_total_geral = valor_total_atual + valor_total_nota;
                double custo_atualizado = valor_total_geral / qtde_total_geral;

                FbCommand update = new FbCommand();
                update.Connection = fbConnection1;
                fbConnection1.Open();
                update.CommandText =
                    "UPDATE PRODUTOS SET CUSTO_PRODUTO = '" + custo_atualizado.ToString("n2").Replace(".","").Replace(",",".") + "' " +
                    "WHERE COD_BARRAS_CAIXA_PRODUTO = '" + codBarras + "' OR COD_BARRAS_PRODUTO = '" + codBarras + "'";
                FbDataAdapter datUpdate = new FbDataAdapter();
                datUpdate.UpdateCommand = update;
                datUpdate.UpdateCommand.ExecuteNonQuery();
                fbConnection1.Close();



            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private void inserir_saida(string cod_os, string posicao_os, string item, string descricao, double qtde)
        {
           
            try
            {
                this.datSaida.InsertCommand.CommandText =
                "INSERT INTO ESTOQUE_SAIDA (COD_ITEM_ESTOQUE_SAIDA, ITEM_ESTOQUE_SAIDA, QTDE_ESTOQUE_SAIDA, " +
                "CRACHA_ESTOQUE_SAIDA, POS_ESTOQUE_SAIDA, DATA_ESTOQUE_SAIDA, DESENHO_ESTOQUE_SAIDA) VALUES " +
                "('" + item + "','" + descricao + "'," + qtde + "," +
                "999, '" + posicao_os + "', CURRENT_DATE, '" + cod_os + "')";
                this.fbConnection1.Open();
                this.datSaida.InsertCommand.Connection = fbConnection1;
                this.datSaida.InsertCommand.ExecuteNonQuery();
                this.fbConnection1.Close(); 
            }
            catch
            {
                fbConnection1.Close(); 
                erro_ao_retirar = true;
                MessageBox.Show("Erro na inserção");
            }
        }

        private void apagar_itens_cr_pedido()
        {
            for (int i = 0; i < dgvItens_nota.Rows.Count; i++)
            {
                if (dgvItens_nota.Rows[i].Cells["col_pedido"].Value.ToString() != "")
                {
                    try
                    {
                        FbCommand delete = new FbCommand();
                        delete.Connection = fbConnection1;
                        delete.CommandText =
                            "DELETE FROM CONTAS_A_PAGAR WHERE NF_CP = '" + dgvItens_nota.Rows[i].Cells["col_pedido"].Value.ToString() + "' AND ORIGEM_CP = 'PC'";
                        fbConnection1.Open();
                        FbDataAdapter datDelete = new FbDataAdapter();
                        datDelete.DeleteCommand = delete;
                        datDelete.DeleteCommand.ExecuteNonQuery();
                        fbConnection1.Close();
                    }
                    catch (Exception a)
                    {
                        fbConnection1.Close();
                        MessageBox.Show(a.ToString());
                    }
                }
            }
        }

        private void inserir_cp()
        {
            apagar_itens_cp();
            apagar_itens_cr_pedido();

            for (int i = 0; i < dgvFatura_nf.RowCount; i++)
            {
                try
                {
                    DateTime _data = Convert.ToDateTime(dgvFatura_nf.Rows[i].Cells["col_data_venc"].Value.ToString());
                    double _valor = Convert.ToDouble(dgvFatura_nf.Rows[i].Cells["col_valor_fatura"].Value.ToString());
                    string _nome_forn = "null", _cod_forn = "null";
                    FbCommand comando_select = new FbCommand();
                    comando_select.Connection = fbConnection1;
                    comando_select.CommandText = "SELECT * FROM CLIENTES WHERE replace(replace(REPLACE(CNPJ, '.', ''), '/', ''), '-', '') LIKE '" +
                        tb_cnpj_cliente.Text.Replace(".","").Replace("/","").Replace("-","") + "'";
                    DataSet forn = new DataSet();
                    fbConnection1.Open();
                    FbDataAdapter datForn = new FbDataAdapter();
                    datForn.SelectCommand = comando_select;
                    datForn.Fill(forn);
                    fbConnection1.Close(); 
                    foreach (DataRow dr in forn.Tables[0].Rows)
                    {
                        _nome_forn = "'" + dr["RAZAO_SOCIAL"].ToString() + "'";
                        _cod_forn = "'" + dr["COD_CLIENTE"].ToString() + "'";
                    }
                    string plano = "";
                    string cod_plano = "";

                    plano = buscar_plano(dgvItens_nota.Rows[0].Cells["col_pedido"].Value.ToString(), out cod_plano);
                    if (plano != "null")
                        plano = "'" + plano + "'";
                    if (cod_plano != "null")
                        cod_plano = "'" + cod_plano + "'";
                    int dup = i + 1;
                    string descricao_cp = "Duplic.: " + dup.ToString() + " ref. NF: " + tb_n_nf.Text;

                    string pessoa = "0";
                    buscar_pessoa(dgvItens_nota.Rows[0].Cells["col_pedido"].Value.ToString(), out pessoa);

                    FbCommand insert = new FbCommand();
                    insert.Connection = fbConnection1;
                    fbConnection1.Open();
                    insert.CommandText =
                        "INSERT INTO CONTAS_A_PAGAR (DATA_PREVISTA_CP, VALOR_CP, COD_FORNECEDOR_CP, RAZAO_FORNECEDOR_CP, DESCRICAO_CP, DUPLICATA_CP, NF_CP, PLANO_CP, COD_PLANO_CP, ORIGEM_CP, STATUS_CP, PESSOA_CP) " +
                         "VALUES " +
                         "('" + _data.ToShortDateString().Replace("/", ".") + "','" + _valor.ToString("n2").Replace(".", "").Replace(",", ".") + "'," + _cod_forn + "," + _nome_forn +
                         ",'" + descricao_cp +
                         "','" + dup.ToString() + "/" + dgvFatura_nf.RowCount.ToString() + "','" + tb_n_nf.Text + "'," + plano + "," + cod_plano + ",'NF','LANÇADO'," + pessoa + ")";
                    FbDataAdapter datContas_a_pagar = new FbDataAdapter();
                    datContas_a_pagar.InsertCommand = insert;
                    datContas_a_pagar.InsertCommand.ExecuteNonQuery();
                    fbConnection1.Close(); 
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.ToString());
                    fbConnection1.Close(); 
                }
            }

        }

        private void buscar_pessoa(string cod_pedido, out string pessoa)
        {
            pessoa = "0";
            if (cod_pedido != "")
            {
                try
                {
                    FbCommand comando_select = new FbCommand();
                    comando_select.Connection = fbConnection1;
                    comando_select.CommandText = @"SELECT COD_EMPRESA FROM EMPRESA emp
                INNER JOIN PEDIDO_COMPRA pc on pc.CNPJ_EMISSOR_PED = emp.CNPJ_EMPRESA
                WHERE COD_PED = '" + cod_pedido + "'";
                    DataSet forn = new DataSet();
                    fbConnection1.Open();
                    FbDataAdapter datForn = new FbDataAdapter();
                    datForn.SelectCommand = comando_select;
                    datForn.Fill(forn);
                    fbConnection1.Close();
                    foreach (DataRow dr in forn.Tables[0].Rows)
                    {
                        pessoa = dr[0].ToString();
                    }
                    if (pessoa == "0")
                        MessageBox.Show("Pedido sem empresa emissora cadastrada");
                }
                catch (Exception ex)
                {
                    fbConnection1.Close();
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private string buscar_plano(string n_pedido, out string cod_plano)
        {
            string _plano = "null";
            cod_plano = "null";
            try
            {
                FbCommand comando_select = new FbCommand();
                comando_select.Connection = fbConnection1;
                fbConnection1.Open();
                comando_select.CommandText = "SELECT PLANO_PED FROM PEDIDO_COMPRA WHERE cod_ped = '" + n_pedido + "'";
                DataSet ped = new DataSet();
                FbDataAdapter datPed = new FbDataAdapter();
                datPed.SelectCommand = comando_select;
                datPed.Fill(ped);
                fbConnection1.Close(); 
                foreach (DataRow dr in ped.Tables[0].Rows)
                {
                    _plano = dr[0].ToString();
                    cod_plano = buscar_cod_plano(_plano);
                }

                return _plano;
            }
            catch (Exception a)
            {
                fbConnection1.Close(); 
               // MessageBox.Show(a.ToString());
                return _plano;
            }
        }

        private string buscar_cod_plano(string _plano)
        {
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT COD_PLANO FROM PLANOS WHERE NOME_PLANO = '" + _plano + "'";
                FbDataAdapter datPlano = new FbDataAdapter();
                datPlano.SelectCommand = select;
                DataSet dsPlanos = new DataSet();
                datPlano.Fill(dsPlanos);
                fbConnection1.Close(); 
                foreach (DataRow dr in dsPlanos.Tables[0].Rows)
                {
                    return dr[0].ToString();
                }
                return "null";
            }
            catch (Exception a)
            {
                fbConnection1.Close(); 
                MessageBox.Show(a.ToString());
                return "null";
            }
        }
        private void apagar_itens_cp()
        {
            try
            {
                string cod_fornecedor = buscar_cod_forn();

                FbCommand delete = new FbCommand();
                delete.Connection = fbConnection1;
                fbConnection1.Open();
                delete.CommandText =
                    "DELETE FROM CONTAS_A_PAGAR WHERE NF_CP = '" + tb_n_nf.Text +
                    "' AND COD_FORNECEDOR_CP = " + cod_fornecedor + " AND ORIGEM_CP = 'NF'";
                FbDataAdapter datContas_a_pagar = new FbDataAdapter();
                datContas_a_pagar.DeleteCommand = delete;
                datContas_a_pagar.DeleteCommand.ExecuteNonQuery();
                fbConnection1.Close(); 
            }
            catch (Exception a)
            {
                fbConnection1.Close(); 
                MessageBox.Show(a.ToString());
            }
        }

        private string buscar_cod_forn()
        {
            string _nome_forn = "null", _cod_forn = "null";
            try
            {

                FbCommand comando_select = new FbCommand();
                comando_select.Connection = fbConnection1;
                comando_select.CommandText = "SELECT * FROM CLIENTES WHERE replace(replace(REPLACE(CNPJ, '.', ''), '/', ''), '-', '') LIKE '" +
                    tb_cnpj_cliente.Text.Replace(".", "").Replace("/", "").Replace("-", "") + "'";
                DataSet forn = new DataSet();
                fbConnection1.Open();
                FbDataAdapter datForn = new FbDataAdapter();
                datForn.SelectCommand = comando_select;
                datForn.Fill(forn);
                fbConnection1.Close(); 
                foreach (DataRow dr in forn.Tables[0].Rows)
                {
                    _cod_forn = "'" + dr["COD_CLIENTE"].ToString() + "'";
                }
                return _cod_forn;
            }
            catch (Exception a)
            {
                fbConnection1.Close(); 
                MessageBox.Show(a.ToString());
                return _cod_forn;
            }
        }

        private void update_item_nf_ent(string codSistema)
        {
            try
            {
                FbCommand update = new FbCommand();
                update.Connection = fbConnection1;
                fbConnection1.Open();
                update.CommandText =
                    "UPDATE ITENS_NOTA_ENT SET BAIXADO_ITEM_ENT = '1' WHERE COD_ITENS_NOTA_ENT = '" + codSistema + "'";
                FbDataAdapter itens_nfDataAdapter = new FbDataAdapter();
                itens_nfDataAdapter.UpdateCommand = update;
                itens_nfDataAdapter.UpdateCommand.ExecuteNonQuery();
                fbConnection1.Close(); 
            }
            catch (Exception a)
            {
                fbConnection1.Close(); 
                MessageBox.Show(a.ToString());
                //MessageBox.Show("3");
            }
        }

        private void update_item_estoque(string cod, string valor_total, string qtde, string qtde_lote, string ncm, string unidade)
        {
            if (qtde_lote != "")
            {
                try
                {
                    double valor_unit = 0, peso_unit = 0;
                    if (!unidade.ToUpper().Contains("KG"))
                    {
                        if (unidade.ToUpper().Contains("TON") || unidade.ToUpper().Contains("TN")) //SE UNIDADE FOR TONELADA
                        {
                            double nova_qtde = Convert.ToDouble(qtde) * 1000;
                            qtde = nova_qtde.ToString(); //TRANSFORMAR EM KG
                        }
                    }
                    try
                    {
                        valor_unit = Convert.ToDouble(valor_total) / Convert.ToDouble(qtde_lote);
                    }
                    catch { }

                    try
                    {
                        peso_unit = Convert.ToDouble(qtde) / Convert.ToDouble(qtde_lote);
                    }
                    catch { }

                    FbCommand update = new FbCommand();
                    update.Connection = fbConnection1;
                    fbConnection1.Open();
                    update.CommandText =
                        "UPDATE ESTOQUE SET NCM_ESTOQUE = '" + ncm + "' WHERE COD_ESTOQUE = '" + cod + "'";
                    //"UPDATE ESTOQUE SET NCM_ESTOQUE = '" + ncm + "', VALOR_UNIT_ESTOQUE = '" + valor_unit.ToString().Replace(".", "").Replace(",", ".") + "', " +
                    //"PESO_UNIT_ESTOQUE = '" + peso_unit.ToString().Replace(".", "").Replace(",", ".") + "' WHERE COD_ESTOQUE = '" + cod + "'";
                    FbDataAdapter datEstoque = new FbDataAdapter();
                    datEstoque.UpdateCommand = update;
                    datEstoque.UpdateCommand.ExecuteNonQuery();
                    fbConnection1.Close(); 

                }
                catch (Exception a)
                {
                    fbConnection1.Close(); 
                    //MessageBox.Show(a.ToString());
                }

            }
        }


        private void buscar_informacoes_no_pedido(string pedido, string n_linha, out string cod_req, out string cod_ped, out string cod_est, out string cod_os, out string posicao_os, out double item_qtde)
        {
            cod_req = ""; cod_ped = ""; cod_est = ""; cod_os = ""; posicao_os = "";
            item_qtde = 0;
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                select.CommandText =
                    "SELECT COD_ITEM_PED, COD_ITEM_REQ_ITEM_PED, COD_ESTOQUE_ITEM_PED, OP_ITEM_PED, POSICAO_ITEM_PED, QTDE_ITEM_PED " +
                    "FROM ITENS_PEDIDO_COMPRA WHERE N_PEDIDO_ITEM_PED = '" + pedido + "' ORDER BY COD_ITEM_PED";
                FbDataAdapter datPedido_compra = new FbDataAdapter();
                fbConnection1.Open();
                datPedido_compra.SelectCommand = select;
                DataSet dsPedido_compra = new DataSet();
                datPedido_compra.Fill(dsPedido_compra);
                fbConnection1.Close(); 
                DataRow dr;
                int linha = Convert.ToInt32(n_linha) - 1;
                try
                {
                    dr = dsPedido_compra.Tables[0].Rows[linha];
                    cod_ped = dr[0].ToString();
                    cod_req = dr[1].ToString();
                    cod_est = dr[2].ToString();
                    cod_os = dr[3].ToString();
                    posicao_os = dr[4].ToString();
                    item_qtde = Convert.ToDouble(dr[5].ToString());
                    
                }
                catch { }
            }
            catch (Exception a)
            {
                fbConnection1.Close(); 
                MessageBox.Show(a.ToString());
                //MessageBox.Show("1");
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
                    "UPDATE ESTOQUE SET ESTOQUE_ATUAL_ESTOQUE = '" + saldo.ToString().Replace(".", "").Replace(",", ".") + "' WHERE COD_ESTOQUE = '" + cod_estoque + "'";
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



        private void update_item_req(string n_item_ped)
        {
            try
            {
                string _cod_req = null;
                FbCommand comando_select = new FbCommand();
                comando_select.Connection = fbConnection1;
                comando_select.CommandText = "SELECT * FROM ITENS_PEDIDO_COMPRA WHERE COD_ITEM_PED = '" + n_item_ped + "'";
                DataSet ped = new DataSet();
                fbConnection1.Open();
                FbDataAdapter datItens_ped = new FbDataAdapter();
                datItens_ped.SelectCommand = comando_select;
                datItens_ped.Fill(ped);
                fbConnection1.Close(); 
                foreach (DataRow dr in ped.Tables[0].Rows)
                {
                    _cod_req = dr["COD_ITEM_REQ_ITEM_PED"].ToString();
                }

                if (_cod_req != "")
                {
                    //FbDataAdapter datItens_req = new FbDataAdapter();
                    datItens_req.UpdateCommand.Connection = fbConnection1;
                    datItens_req.UpdateCommand.CommandText =
                    "UPDATE ITENS_REQUISICAO SET SITUACAO_ATUAL_ITEM_REQ = 'ITEM CHEGOU NO DIA " + tb_saida.Text + " NF: " + tb_n_nf.Text + "' WHERE COD_ITEM_REQ = '" + _cod_req + "'";
                    fbConnection1.Open();
                    datItens_req.UpdateCommand.Connection = fbConnection1;
                    datItens_req.UpdateCommand.ExecuteNonQuery();
                    fbConnection1.Close(); 
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
                //FbDataAdapter datItens_ped = new FbDataAdapter();
                datItens_ped.UpdateCommand.Connection = fbConnection1;
                datItens_ped.UpdateCommand.CommandText =
                "UPDATE ITENS_PEDIDO_COMPRA SET CHEGOU_ITEM_PED = '1' WHERE COD_ITEM_PED = '" + n_item_ped + "'";
                fbConnection1.Open();
                datItens_ped.UpdateCommand.Connection = fbConnection1;
                datItens_ped.UpdateCommand.ExecuteNonQuery();
                fbConnection1.Close(); 

                datItens_ped.UpdateCommand.CommandText =
                "UPDATE ITENS_PEDIDO_COMPRA SET COD_NF_ENTRADA_ITEM_PED = '" + tb_n_nf.Text + "' WHERE COD_ITEM_PED = '" + n_item_ped + "'";
                fbConnection1.Open();
                datItens_ped.UpdateCommand.Connection = fbConnection1;
                datItens_ped.UpdateCommand.ExecuteNonQuery();
                fbConnection1.Close(); 

                datItens_ped.UpdateCommand.CommandText =
                "UPDATE ITENS_PEDIDO_COMPRA SET DATA_CHEGADA_ITEM_PED = '" + Convert.ToDateTime(tb_saida.Text).ToShortDateString().Replace("/", ".") + "' WHERE COD_ITEM_PED = '" + n_item_ped + "'";
                fbConnection1.Open();
                datItens_ped.UpdateCommand.Connection = fbConnection1;
                datItens_ped.UpdateCommand.ExecuteNonQuery();
                fbConnection1.Close(); 
            }
            catch
            {
                MessageBox.Show("Erro na Inserção de informação nos Itens do Pedido de Compra");
                fbConnection1.Close(); 
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT COD_ESTOQUE, ITEM_ESTOQUE, ESTOQUE_ATUAL_ESTOQUE FROM ESTOQUE";
                FbDataAdapter datEstoque = new FbDataAdapter();
                datEstoque.SelectCommand = select;
                DataSet dsEstoque = new DataSet();
                datEstoque.Fill(dsEstoque);
                fbConnection1.Close(); 
                foreach (DataRow dr in dsEstoque.Tables[0].Rows)
                {
                    inserir_itens_ent(dr[1].ToString(), "", dr[2].ToString(), "", "", "", "", "", tb_n_nf.Text, "", "", "", "", "", "", "", "", DateTime.Now.ToShortDateString(), "99999999999999",
                        "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", dr[0].ToString(), "", "", "", "", "", "");
                    calcular_estoque(dr[0].ToString());
                }
            }
            catch
            {
                fbConnection1.Close(); 
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (dgvItens_nota.SelectedRows.Count > 0)
            {
                if (verificar_se_todos_tem_lote())
                {
                    try
                    {
                        FbCommand delete = new FbCommand();
                        delete.Connection = fbConnection1;
                        fbConnection1.Open();
                        delete.CommandText = "DELETE FROM IMP_FICHA_MATERIAL";
                        FbDataAdapter datImp_ficha_material = new FbDataAdapter();
                        datImp_ficha_material.DeleteCommand = delete;
                        datImp_ficha_material.DeleteCommand.ExecuteNonQuery();
                        fbConnection1.Close(); 

                        for (int i = 0; i < dgvItens_nota.RowCount; i++)
                        {
                            try
                            {
                                fbConnection1.Open();
                                FbTransaction trans = fbConnection1.BeginTransaction();
                                fbConnection1.Close(); 
                                FbCommand insert = new FbCommand("INSERT INTO IMP_FICHA_MATERIAL " +
                  "(PROPRIETARIO_IFM, COD_ITEM_IFM, DESCRICAO_ITEM_IFM, QTDE_IFM, LOTE_IFM, PROX_OPERACAO_IFM, " +
                  "DIMENSOES_IFM, DATA_LIBERACAO_IFM, COD_BARRAS_IFM, TIPO_MATERIAL_IFM, RASTREAMENTO_IFM) " +
                  "VALUES(?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)", fbConnection1, trans);
                                insert.Parameters.AddWithValue("PROPRIETARIO_IFM", dgvItens_nota.Rows[i].Cells["col_cliente"].Value.ToString());
                                insert.Parameters.AddWithValue("COD_ITEM_IFM", dgvItens_nota.Rows[i].Cells["col_cod_item_est"].Value.ToString());
                                string descricao = null, dimensoes = null, tipo_material = null;
                                buscar_dados_item_estoque(dgvItens_nota.Rows[i].Cells["col_cod_item_est"].Value.ToString(),
                                    out descricao, out dimensoes, out tipo_material);
                                insert.Parameters.AddWithValue("DESCRICAO_ITEM_IFM", descricao);
                                insert.Parameters.AddWithValue("QTDE_IFM", dgvItens_nota.Rows[i].Cells["col_qtde_lote"].Value.ToString());
                                insert.Parameters.AddWithValue("LOTE_IFM", dgvItens_nota.Rows[i].Cells["col_lote"].Value.ToString());
                                insert.Parameters.AddWithValue("PROX_OPERACAO_IFM", "ARMAZENAR");
                                insert.Parameters.AddWithValue("DIMENSOES_IFM", dimensoes);
                                insert.Parameters.AddWithValue("DATA_LIBERACAO_IFM", DateTime.Now.ToShortDateString().Replace("/", "."));

                                //criando código de barras
                                BarcodeLib.Barcode bar = new BarcodeLib.Barcode();
                                Image bmp = bar.Encode(BarcodeLib.TYPE.CODE128, "#" + dgvItens_nota.Rows[i].Cells["col_cod_item_est"].Value.ToString() +
                                    "#" + tb_n_nf.Text + "#" + dgvItens_nota.Rows[i].Cells["col_lote"].Value.ToString(), 300, 150);

                                FbParameter blob = new FbParameter();
                                blob.FbDbType = FbDbType.Binary;
                                // using System.ComponentModel and convert Bitmap to byte[]
                                blob.Value = (byte[])TypeDescriptor.GetConverter(bmp).ConvertTo(bmp, typeof(byte[]));
                                //inserindo código no banco
                                insert.Parameters.Add(blob);
                                insert.Parameters.AddWithValue("TIPO_MATERIAL_IFM", tipo_material);

                                insert.Parameters.AddWithValue("RASTREAMENTO_IFM", buscar_cod_rastreamento(dgvItens_nota.Rows[i].Cells["col_lote"].Value.ToString()));
                                fbConnection1.Open();
                                //insert.Connection = fbConnection1;
                                datImp_ficha_material.InsertCommand = insert;
                                datImp_ficha_material.InsertCommand.ExecuteNonQuery();

                                fbConnection1.Close(); 

                            }
                            catch (Exception a)
                            {
                                fbConnection1.Close(); 
                                MessageBox.Show(a.ToString());
                            }

                        }

                        FbCommand select = new FbCommand();
                        select.Connection = fbConnection1;
                        fbConnection1.Open();
                        select.CommandText = "SELECT * FROM IMP_FICHA_MATERIAL ORDER BY COD_IFM";
                        datImp_ficha_material.SelectCommand = select;
                        dsImp_ficha_material fichas = new dsImp_ficha_material();
                        datImp_ficha_material.Fill(fichas.IMP_FICHA_MATERIAL);
                        fbConnection1.Close(); 
                        //crTeste nova_op = new crTeste();
                        crFicha_material_2 nova_op = new crFicha_material_2();
                        nova_op.SetDataSource(fichas);
                        form_imprimir imprime = new form_imprimir(nova_op);
                        imprime.Show();
                    }
                    catch (Exception a)
                    {
                        fbConnection1.Close(); 
                        MessageBox.Show(a.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("É necessário digitar o lote de todos os itens além de digitar o proprietário no campo ao lado");
                }
            }
            else
            {
                MessageBox.Show("Selecione os itens a imprimir");
            }
        }

        private string buscar_cod_rastreamento(string cod_lote)
        {

            string rastreamento = "";
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT * FROM LOTE_RECEBIMENTO WHERE COD_LR = '" + cod_lote + "'";
                FbDataAdapter datLr = new FbDataAdapter();
                datLr.SelectCommand = select;
                DataSet dsLr = new DataSet();
                datLr.Fill(dsLr);
                fbConnection1.Close(); 

                foreach (DataRow dr in dsLr.Tables[0].Rows)
                {
                    rastreamento = dr["RASTREAMENTO_LR"].ToString();
                }
                return rastreamento;
            }
            catch (Exception a)
            {
                fbConnection1.Close(); 
                MessageBox.Show(a.ToString());
                return "erro";
            }
        }

        private void buscar_dados_item_estoque(string cod, out string descricao, out string dimensoes, out string tipo_material)
        {
            descricao = null; dimensoes = null; tipo_material = null;
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT ITEM_ESTOQUE, DESCRICAO_ESTOQUE, MATERIAL_ESTOQUE, DIMENSAO_ESTOQUE FROM ESTOQUE WHERE " +
                    " COD_ESTOQUE = '" + cod + "'";
                FbDataAdapter datEstoque = new FbDataAdapter();
                datEstoque.SelectCommand = select;
                DataSet dsEstoque = new DataSet();
                datEstoque.Fill(dsEstoque);
                fbConnection1.Close(); 
                foreach (DataRow dr in dsEstoque.Tables[0].Rows)
                {
                    descricao = dr[0].ToString();
                    if (dr[1].ToString() != "")
                        descricao = descricao + " " + dr[1].ToString();
                    dimensoes = dr[3].ToString();
                    tipo_material = dr[2].ToString();
                }
            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
                fbConnection1.Close(); 
            }
        }

        private bool verificar_se_todos_tem_lote()
        {

            try
            {
                for (int i = 0; i < dgvItens_nota.RowCount; i++)
                {
                    if (dgvItens_nota.Rows[i].Cells["col_lote"].Value.ToString() == "")
                    {
                        return false;
                    }
                }
                return true;
            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
                return false;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
        }

        private void button16_Click_1(object sender, EventArgs e)
        {

        }

        private void dgvItens_nota_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvItens_nota.Columns[e.ColumnIndex].Name == "col_buscar_item_est")
            {
                form_busca_item_estoque_mp est = new form_busca_item_estoque_mp(cnpj_empresa);
                try
                {
                    est.ShowDialog();
                }
                finally
                {
                    if (est.cod_escolhido != "")
                    {
                        dgvItens_nota.Rows[e.RowIndex].Cells["col_cod_item_est"].Value = est.cod_escolhido;
                    }
                    else
                        dgvItens_nota.Rows[e.RowIndex].Cells["col_cod_item_est"].Value = "";
                }
            }
            if (dgvItens_nota.Columns[e.ColumnIndex].Name == "col_novo_lote")
            {
                form_lote_mp lote = new form_lote_mp();
                try
                {
                    if (dgvItens_nota.Rows[e.RowIndex].Cells["col_lote"].Value.ToString() != "")
                    {
                        lote.cod_lote = dgvItens_nota.Rows[e.RowIndex].Cells["col_lote"].Value.ToString();
                        lote.ShowDialog();
                    }
                    else
                    {
                        string cod_produto, descricao_produto, dimensoes_produto, material_produto, cliente_produto,
                            cnpj_cliente_produto;
                        buscar_informacoes_produto_pedido(dgvItens_nota.Rows[e.RowIndex].Cells["col_cod_item_est"].Value.ToString(),
                            dgvItens_nota.Rows[e.RowIndex].Cells["col_cfo"].Value.ToString(),
                            dgvItens_nota.Rows[e.RowIndex].Cells["col_cod_item_req"].Value.ToString(),
                            out cod_produto, out descricao_produto, out dimensoes_produto, out material_produto, out cliente_produto,
                            out cnpj_cliente_produto);

                        lote.cod_mp = cod_produto;
                        lote.descricao_mp = descricao_produto;
                        lote.dimensoes = dimensoes_produto;
                        lote.material = material_produto;
                        lote.nome_cliente = cliente_produto;
                        lote.cnpj_cliente = cnpj_cliente_produto;
                        lote.nota_fiscal = tb_n_nf.Text;
                        lote.ShowDialog();
                    }
                }
                finally
                {
                    dgvItens_nota.Rows[e.RowIndex].Cells["col_lote"].Value = lote.cod_lote;
                    string cod_produto_lote, descricao_produto_lote, dimensoes_produto_lote, material_produto_lote, cliente_produto_lote,
                            cnpj_cliente_produto_lote, qtde_produto_lote, data_liberacao_lote, nota_fiscal_lote, rastreameto_lote;
                    buscar_informacoes_lote(dgvItens_nota.Rows[e.RowIndex].Cells["col_lote"].Value.ToString(),
                        out cod_produto_lote, out descricao_produto_lote, out dimensoes_produto_lote, out material_produto_lote,
                        out cliente_produto_lote, out cnpj_cliente_produto_lote, out qtde_produto_lote, out data_liberacao_lote,
                        out nota_fiscal_lote, out rastreameto_lote);
                    dgvItens_nota.Rows[e.RowIndex].Cells["col_qtde_lote"].Value = qtde_produto_lote;
                    dgvItens_nota.Rows[e.RowIndex].Cells["col_cnpj_cliente"].Value = cnpj_cliente_produto_lote;
                    dgvItens_nota.Rows[e.RowIndex].Cells["col_cliente"].Value = cliente_produto_lote;
                }
            }
        }

        private void buscar_informacoes_lote(string cod_lote, out string cod_produto_lote, out string descricao_produto_lote,
            out string dimensoes_produto_lote, out string material_produto_lote, out string cliente_produto_lote,
            out string cnpj_cliente_produto_lote, out string qtde_produto_lote, out string data_liberacao_lote,
            out string nota_fiscal_lote, out string rastreameto_lote)
        {
            cod_produto_lote = ""; descricao_produto_lote = ""; dimensoes_produto_lote = ""; material_produto_lote = "";
            cliente_produto_lote = ""; cnpj_cliente_produto_lote = ""; qtde_produto_lote = ""; data_liberacao_lote = "";
            nota_fiscal_lote = ""; rastreameto_lote = "";

            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT * FROM LOTE_RECEBIMENTO WHERE COD_LR = '" + cod_lote + "'";
                FbDataAdapter datLr = new FbDataAdapter();
                datLr.SelectCommand = select;
                DataSet dsLr = new DataSet();
                datLr.Fill(dsLr);
                fbConnection1.Close(); 
                foreach (DataRow dr in dsLr.Tables[0].Rows)
                {
                    cod_produto_lote = dr["COD_PRODUTO_LR"].ToString();
                    descricao_produto_lote = dr["DESCRICAO_LR"].ToString();
                    dimensoes_produto_lote = dr["DIMENSOES_LR"].ToString();
                    material_produto_lote = dr["MATERIAL_LR"].ToString();
                    cliente_produto_lote = dr["CLIENTE_LR"].ToString();
                    cnpj_cliente_produto_lote = dr["CNPJ_CLIENTE_LR"].ToString();
                    rastreameto_lote = dr["RASTREAMENTO_LR"].ToString();
                    qtde_produto_lote = dr["QTDE_LR"].ToString();
                    try
                    {
                        data_liberacao_lote = Convert.ToDateTime(dr["DATA_LIBERACAO_LR"].ToString()).ToShortDateString();
                    }
                    catch { }
                    nota_fiscal_lote = dr["NOTA_FISCAL_LR"].ToString();
                }

            }
            catch (Exception a)
            {
                fbConnection1.Close(); 
                MessageBox.Show(a.ToString());
            }

        }

        private void buscar_informacoes_produto_pedido(string cod_estoque, string cfop, string cod_item_requisicao, out string cod_produto, out string descricao_produto,
            out string dimensoes_produto, out string material_produto, out string cliente_produto, out string cnpj_cliente)
        {
            cod_produto = ""; descricao_produto = ""; dimensoes_produto = ""; material_produto = ""; cliente_produto = ""; cnpj_cliente = "";
            try
            {
                buscar_dados_item_estoque(cod_estoque, out descricao_produto, out dimensoes_produto, out material_produto);
                cod_produto = cod_estoque;
                if (cfop[1].ToString() == "9") //REMESSA PARA BENEFICIAMENTO
                {
                    cnpj_cliente = tb_cnpj_cliente.Text;
                    cliente_produto = tb_cliente.Text;
                }
                if (cfop[1].ToString() == "1") //VENDAS
                {
                    if (buscar_cliente_requisicao(cod_item_requisicao, out cnpj_cliente, out cliente_produto))
                    {

                    }
                    else
                    {
                        buscar_cnpj_nome_empresa(out cnpj_cliente, out cliente_produto);
                    }
                }
            }
            catch (Exception a)
            {
                fbConnection1.Close(); 
                MessageBox.Show(a.ToString());
            }
        }

        private void buscar_cnpj_nome_empresa(out string cnpj_cliente, out string cliente_produto)
        {
            cnpj_cliente = ""; cliente_produto = "";
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT RAZAO_SOCIAL_EMPRESA, CNPJ_EMPRESA FROM EMPRESA";
                FbDataAdapter datEmpresa = new FbDataAdapter();
                datEmpresa.SelectCommand = select;
                DataSet dsEmpresa = new DataSet();
                datEmpresa.Fill(dsEmpresa);
                foreach (DataRow dr in dsEmpresa.Tables[0].Rows)
                {
                    cnpj_cliente = dr[1].ToString();
                    cliente_produto = dr[0].ToString();
                }
            }
            catch (Exception a)
            {
                fbConnection1.Close(); 
                MessageBox.Show(a.ToString());
            }
        }

        private bool buscar_cliente_requisicao(string cod_item_requisicao, out string cnpj_cliente, out string cliente_produto)
        {
            cnpj_cliente = ""; cliente_produto = "";
            try
            {
                FbCommand select_item_req = new FbCommand();
                select_item_req.Connection = fbConnection1;
                fbConnection1.Open();
                select_item_req.CommandText =
                    "SELECT COD_REQ_ITEM_REQ FROM ITENS_REQUISICAO WHERE COD_ITEM_REQ = '" + cod_item_requisicao + "'";
                FbDataAdapter datItem_req = new FbDataAdapter();
                datItem_req.SelectCommand = select_item_req;
                DataSet dsItem_req = new DataSet();
                datItem_req.Fill(dsItem_req);
                fbConnection1.Close(); 
                string cod_req = "";
                foreach (DataRow dr in dsItem_req.Tables[0].Rows)
                {
                    cod_req = dr[0].ToString();
                }

                FbCommand select_req = new FbCommand();
                select_req.Connection = fbConnection1;
                fbConnection1.Open();
                select_req.CommandText =
                    "SELECT CLIENTE_REQUISICAO FROM REQUISICOES WHERE COD_REQUISICAO = '" + cod_req + "'";
                FbDataAdapter datReq = new FbDataAdapter();
                datReq.SelectCommand = select_req;
                DataSet dsReq = new DataSet();
                datReq.Fill(dsReq);
                fbConnection1.Close(); 
                foreach (DataRow dr_req in dsReq.Tables[0].Rows)
                {
                    if (dr_req[0].ToString() != "")
                    {
                        cliente_produto = dr_req[0].ToString();
                        cnpj_cliente = buscar_cnpj_cliente(cliente_produto);
                        return true;
                    }

                }
                return false;
            }
            catch (Exception a)
            {
                fbConnection1.Close(); 
                MessageBox.Show(a.ToString());
                return false;
            }
        }

        private string buscar_cnpj_cliente(string cliente_produto)
        {
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT CNPJ FROM CLIENTES WHERE RAZAO_SOCIAL = '" + cliente_produto + "'";
                FbDataAdapter datClientes = new FbDataAdapter();
                datClientes.SelectCommand = select;
                DataSet dsClientes = new DataSet();
                datClientes.Fill(dsClientes);
                fbConnection1.Close(); 
                foreach (DataRow dr in dsClientes.Tables[0].Rows)
                {
                    return dr[0].ToString();
                }
                return "Não encontrado";
            }
            catch (Exception a)
            {
                fbConnection1.Close(); 
                MessageBox.Show(a.ToString());

                return "erro";
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void form_nf_ent_Load(object sender, EventArgs e)
        {
         
            detectar_dados_empresa(out razao_social_empresa, out nome_fantasia_empresa, out cnpj_empresa, out ie_empresa, out im_empresa, out cnae_empresa, out endereco_empresa, out n_endereco_empresa,
      out complemento_empresa, out bairro_empresa, out cidade_empresa, out estado_empresa, out cep_empresa, out telefone_empresa, out cod_cidade_empresa, out pais_empresa,
      out cod_pais_empresa, out licenca_dll_nfe_empresa, out nome_certificado_nfe_empresa, out assunto_nfe_email_empresa, out smtp_nfe_empresa, out email_nfe_empresa,
      out senha_email_nfe_empresa, out logotipo_empresa, out proxy_empresa, out usuario_proxy_empresa, out senha_proxy_empresa, out crt_empresa, out portaEmailEmpresa, out sslEmpresa, out serie_empresa,
      out boleto_pedido_empresa, out cliente_inadimplente_empresa, out custo_automatico_empresa);
        }

        string cnpj_empresa = "", razao_social_empresa = "", nome_fantasia_empresa = "", ie_empresa = "", im_empresa = "", cnae_empresa = "", endereco_empresa = "", n_endereco_empresa = "",
          complemento_empresa = "", bairro_empresa = "", cidade_empresa = "", estado_empresa = "", cep_empresa = "", telefone_empresa = "", cod_cidade_empresa = "", pais_empresa = "",
          cod_pais_empresa = "", licenca_dll_nfe_empresa = "", nome_certificado_nfe_empresa = "", assunto_nfe_email_empresa = "", smtp_nfe_empresa = "", email_nfe_empresa = "",
          senha_email_nfe_empresa = "", logotipo_empresa = "", proxy_empresa = "", usuario_proxy_empresa = "", senha_proxy_empresa = "", crt_empresa = "", portaEmailEmpresa = "",
          sslEmpresa = "", serie_empresa = "", boleto_pedido_empresa = "", cliente_inadimplente_empresa = "", custo_automatico_empresa = "";

        private void detectar_dados_empresa(out string razao_social_empresa, out string nome_fantasia_empresa, out string cnpj_empresa, out string ie_empresa, out string im_empresa, out string cnae_empresa, out string endereco_empresa, out string n_endereco_empresa,
               out string complemento_empresa, out string bairro_empresa, out string cidade_empresa, out string estado_empresa, out string cep_empresa, out string telefone_empresa, out string cod_cidade_empresa, out string pais_empresa,
               out string cod_pais_empresa, out string licenca_dll_nfe_empresa, out string nome_certificado_nfe_empresa, out string assunto_nfe_email_empresa, out string smtp_nfe_empresa, out string email_nfe_empresa,
               out string senha_email_nfe_empresa, out string logotipo_empresa, out string proxy_empresa, out string usuario_proxy_empresa, out string senha_proxy_empresa,
       out string crt_empresa, out string portaEmailEmpresa, out string sslEmpresa, out string serie_empresa, out string boleto_pedido_empresa, out string cliente_inadimplente_empresa, out string custo_automatico_empresa)
        {
            razao_social_empresa = ""; nome_fantasia_empresa = ""; cnpj_empresa = ""; ie_empresa = ""; im_empresa = ""; cnae_empresa = ""; endereco_empresa = ""; n_endereco_empresa = "";
            complemento_empresa = ""; bairro_empresa = ""; cidade_empresa = ""; estado_empresa = ""; cep_empresa = ""; telefone_empresa = ""; cod_cidade_empresa = ""; pais_empresa = "";
            cod_pais_empresa = ""; licenca_dll_nfe_empresa = ""; nome_certificado_nfe_empresa = ""; assunto_nfe_email_empresa = ""; smtp_nfe_empresa = ""; email_nfe_empresa = "";
            senha_email_nfe_empresa = ""; logotipo_empresa = ""; proxy_empresa = ""; usuario_proxy_empresa = ""; senha_proxy_empresa = ""; crt_empresa = ""; portaEmailEmpresa = "";
            sslEmpresa = ""; serie_empresa = ""; boleto_pedido_empresa = ""; cliente_inadimplente_empresa = ""; custo_automatico_empresa = "";
            try
            {
                FbCommand comando = new FbCommand();
                comando.Connection = fbConnection1;
                comando.CommandText = "SELECT * FROM EMPRESA where LICENCA_DLL_NFE_EMPRESA is not null";
                DataSet empresa = new DataSet();
                fbConnection1.Open();
                FbDataAdapter datEmpresa = new FbDataAdapter();

                datEmpresa.SelectCommand = comando;
                datEmpresa.Fill(empresa);
                fbConnection1.Close();
                foreach (DataRow dr in empresa.Tables[0].Rows)
                {
                    razao_social_empresa = dr["RAZAO_SOCIAL_EMPRESA"].ToString();
                    nome_fantasia_empresa = dr["NOME_FANTASIA_EMPRESA"].ToString();
                    cnpj_empresa = dr["CNPJ_EMPRESA"].ToString().Replace(".", "").Replace("/", "").Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "");
                    ie_empresa = dr["IE_EMPRESA"].ToString().Replace(".", "").Replace("/", "").Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "");
                    im_empresa = dr["IM_EMPRESA"].ToString().Replace(".", "").Replace("/", "").Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "");
                    cnae_empresa = dr["CNAE_EMPRESA"].ToString().Replace(".", "").Replace("/", "").Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "");
                    endereco_empresa = dr["ENDERECO_EMPRESA"].ToString();
                    n_endereco_empresa = dr["N_ENDERECO_EMPRESA"].ToString();
                    complemento_empresa = dr["COMPLEMENTO_EMPRESA"].ToString();
                    bairro_empresa = dr["BAIRRO_EMPRESA"].ToString();
                    cidade_empresa = dr["CIDADE_EMPRESA"].ToString();
                    estado_empresa = dr["ESTADO_EMPRESA"].ToString();
                    cep_empresa = dr["CEP_EMPRESA"].ToString().Replace(".", "").Replace("/", "").Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "");
                    telefone_empresa = dr["TELEFONE_EMPRESA"].ToString().Replace(".", "").Replace("/", "").Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "");
                    cod_cidade_empresa = dr["COD_CIDADE_EMPRESA"].ToString();
                    pais_empresa = dr["PAIS_EMPRESA"].ToString();
                    cod_cidade_empresa = dr["COD_CIDADE_EMPRESA"].ToString();
                    licenca_dll_nfe_empresa = dr["LICENCA_DLL_NFE_EMPRESA"].ToString();
                    nome_certificado_nfe_empresa = dr["NOME_CERTIFICADO_NFE_EMPRESA"].ToString();
                    assunto_nfe_email_empresa = dr["ASSUNTO_NFE_EMAIL_EMPRESA"].ToString();
                    smtp_nfe_empresa = dr["SMTP_NFE_EMPRESA"].ToString();
                    email_nfe_empresa = dr["EMAIL_NFE_EMPRESA"].ToString();
                    senha_email_nfe_empresa = dr["SENHA_EMAIL_NFE_EMPRESA"].ToString();
                    logotipo_empresa = dr["LOGOTIPO_EMPRESA"].ToString();
                    proxy_empresa = dr["PROXY_EMPRESA"].ToString();
                    usuario_proxy_empresa = dr["USUARIO_PROXY_EMPRESA"].ToString();
                    senha_proxy_empresa = dr["SENHA_PROXY_EMPRESA"].ToString();
                    crt_empresa = dr["CRT_EMPRESA"].ToString();
                    try
                    {
                        portaEmailEmpresa = dr["PORTA_EMAIL_EMP"].ToString();
                    }
                    catch { }
                    try
                    {
                        sslEmpresa = dr["SSL_EMP"].ToString();
                    }
                    catch { }

                    serie_empresa = dr["SERIE_EMPRESA"].ToString();
                    try
                    {
                        boleto_pedido_empresa = dr["BOLETO_PEDIDO_EMPRESA"].ToString();
                    }
                    catch { }
                    try
                    {
                        cliente_inadimplente_empresa = dr["CLIENTE_INADIMPLENTE_EMPRESA"].ToString();
                    }
                    catch { }
                    try
                    {
                        custo_automatico_empresa = dr["CUSTO_AUTOMATICO_EMPRESA"].ToString();
                    }
                    catch { }
                }

            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private void button16_Click_2(object sender, EventArgs e)
        {
            form_vendedores vend = new form_vendedores();
            try
            {
                vend.ShowDialog();
            }
            finally
            {
                tb_cod_vendedor.Text = vend.cod_vendedor_escolhido;
                tb_vendedor.Text = vend.vendedor_escolhido;
            }
        }


    }
}
