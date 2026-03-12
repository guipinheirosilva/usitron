using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using DFW;
using System.Runtime.InteropServices;
using System.Threading;
using System.Collections;
//using Microsoft.VisualBasic;

namespace Evolucao
{
    public partial class form_pdv : Form
    {

        NFe_Util_2G.Util util2 = new NFe_Util_2G.Util();
        public string cnpj;
        public form_pdv(string cnpj)
        {
            this.cnpj = cnpj;
            InitializeComponent();
        }
         string razao_social_empresa = "", nome_fantasia_empresa = "", cnpj_empresa = "", ie_empresa = "", im_empresa = "", cnae_empresa = "", endereco_empresa = "", n_endereco_empresa = "",
                      complemento_empresa = "", bairro_empresa = "", cidade_empresa = "", estado_empresa = "", cep_empresa = "", telefone_empresa = "", cod_cidade_empresa = "", pais_empresa = "",
                      cod_pais_empresa = "", licenca_dll_nfe_empresa = "", nome_certificado_nfe_empresa = "", assunto_nfe_email_empresa = "", smtp_nfe_empresa = "", email_nfe_empresa = "",
                      senha_email_nfe_empresa = "", logotipo_empresa = "", proxy_empresa = "", usuario_proxy_empresa = "", senha_proxy_empresa = "", crt_empresa = "", serie_nfce_empresa = "";


         private void form_pdv_Load(object sender, EventArgs e)
         {
             //cbNfe_teste.Checked = true;
             detectar_dados_empresa(out razao_social_empresa, out nome_fantasia_empresa, out cnpj_empresa, out ie_empresa, out im_empresa, out cnae_empresa, out endereco_empresa, out n_endereco_empresa,
                              out complemento_empresa, out bairro_empresa, out cidade_empresa, out estado_empresa, out cep_empresa, out telefone_empresa, out cod_cidade_empresa, out pais_empresa,
                              out cod_pais_empresa, out licenca_dll_nfe_empresa, out nome_certificado_nfe_empresa, out assunto_nfe_email_empresa, out smtp_nfe_empresa, out email_nfe_empresa,
                              out senha_email_nfe_empresa, out logotipo_empresa, out proxy_empresa, out usuario_proxy_empresa, out senha_proxy_empresa, out crt_empresa, out serie_nfce_empresa);


         }

        private void tb_cod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                
                buscar_item(tb_cod.Text);


            }
        }

        private void buscar_item(string cod)
        {

            try
            {
                try
                {
                    if (cod.Remove(3) == "200")
                    {
                        tb_qtde.Text = cod.Substring(7, 5).Insert(2, ",");
                        cod = cod.Substring(1, 6);
                        tb_cod.Text = cod;
                    }
                }
                catch { }
                FbCommand select = new FbCommand();
                select.CommandText =
                    "SELECT prod.COD_PRODUTO, prod.COD_BARRAS_PRODUTO, prod.DESCRICAO_PRODUTO, " + 
                    "item.PRECO_PRODUTO_ITEM_TP FROM PRODUTOS prod " + 
                    "INNER JOIN ITENS_TP item ON prod.COD_PRODUTO = item.COD_PRODUTO_ITEM_TP " + 
                    "INNER JOIN TABELA_PRECO tab ON tab.COD_TABELA_PRECO = item.COD_TABELA_ITEM_TP " + 
                    " WHERE prod.COD_BARRAS_PRODUTO = '" + cod + "' " + 
                    "AND tab.NOME_TABELA_PRECO = 'PDV'";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();
                bool existe = false;
                foreach (DataRow dr in dtSelect.Rows)
                {
                    try
                    {
                        tb_valor_unit.Text = Convert.ToDouble(dr[3].ToString()).ToString("n2");
                    }
                    catch { }
                    labelDescricao.Text = dr[2].ToString();
                    if(tb_qtde.Text =="")
                        tb_qtde.Text = "1";
                    existe = true;
                    inserir_item();
                }

                if (!existe)
                    MessageBox.Show("Item não cadastrado ou não está na tabela de preço");
            }
            catch (Exception a)
            {
                fbConnection1.Close();
            }  
        }

        private void detectar_dados_empresa(out string razao_social_empresa, out string nome_fantasia_empresa, out string cnpj_empresa, out string ie_empresa, out string im_empresa, out string cnae_empresa, out string endereco_empresa, out string n_endereco_empresa,
            out string complemento_empresa, out string bairro_empresa, out string cidade_empresa, out string estado_empresa, out string cep_empresa, out string telefone_empresa, out string cod_cidade_empresa, out string pais_empresa,
            out string cod_pais_empresa, out string licenca_dll_nfe_empresa, out string nome_certificado_nfe_empresa, out string assunto_nfe_email_empresa, out string smtp_nfe_empresa, out string email_nfe_empresa,
            out string senha_email_nfe_empresa, out string logotipo_empresa, out string proxy_empresa, out string usuario_proxy_empresa, out string senha_proxy_empresa, out string crt_empresa, out string serie_nfce_empresa)
        {
            razao_social_empresa = ""; nome_fantasia_empresa = ""; cnpj_empresa = ""; ie_empresa = ""; im_empresa = ""; cnae_empresa = ""; endereco_empresa = ""; n_endereco_empresa = "";
            complemento_empresa = ""; bairro_empresa = ""; cidade_empresa = ""; estado_empresa = ""; cep_empresa = ""; telefone_empresa = ""; cod_cidade_empresa = ""; pais_empresa = "";
            cod_pais_empresa = ""; licenca_dll_nfe_empresa = ""; nome_certificado_nfe_empresa = ""; assunto_nfe_email_empresa = ""; smtp_nfe_empresa = ""; email_nfe_empresa = "";
            senha_email_nfe_empresa = ""; logotipo_empresa = ""; proxy_empresa = ""; usuario_proxy_empresa = ""; senha_proxy_empresa = ""; crt_empresa = ""; serie_nfce_empresa = "";
            try
            {
                FbCommand comando = new FbCommand();
                comando.Connection = fbConnection1;
                comando.CommandText = "SELECT * FROM EMPRESA where CNPJ_EMPRESA = '" + cnpj + "'";
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
                    byte[] figura = (byte[])dr["LOGOTIPO_EMPRESA"];

                   // byte[] data = (byte[])dt.Rows[0]["IMAGE"];
                    MemoryStream ms = new MemoryStream(figura);
                    //pictureBox1.Image = Image.FromStream(ms);

                    pbLogo.Image = Image.FromStream(ms);
                    logotipo_empresa =  dr["LOGOTIPO_EMPRESA"].ToString();
                    proxy_empresa = dr["PROXY_EMPRESA"].ToString();
                    usuario_proxy_empresa = dr["USUARIO_PROXY_EMPRESA"].ToString();
                    senha_proxy_empresa = dr["SENHA_PROXY_EMPRESA"].ToString();
                    crt_empresa = dr["CRT_EMPRESA"].ToString();
                    serie_nfce_empresa = dr["SERIE_NFCE_EMPRESA"].ToString();


                }

            }
            catch
            {
                fbConnection1.Close();
                MessageBox.Show("Erro ao buscar dados da empresa");
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            inserir_item();
        }



        private void inserir_item()
        {
            if (tbCod_pedido.Text != "")
            {
                if (tb_cod.Text != "")
                {
                    if (tb_valor_unit.Text != "")
                    {
                        if (tb_qtde.Text != "")
                        {
                            try
                            {

                                string cod_estoque = "null", ean = "null", descricao = "null",
                                    unidade = "null", ncm = "null",
                                    cfop = "null", st_icms = "null",
                                    cst_icms = "null", cst_icms_st = "null";

                                double qtde = 0, valor_unit = 0, valor_total = 0, bc_icms = 0, aliq_icms = 0,
                                    valor_icms = 0, bc_icms_st = 0, aliq_icms_st = 0, valor_icms_st = 0,
                                    porc_trib, valor_trib = 0, valor_desconto = 0, custo = 0;

                                buscar_informacoes_produto(tb_cod.Text, out cod_estoque, out ean, out descricao,
                                    out unidade, out ncm, out cfop, out st_icms, out custo);
                                porc_trib = buscarTotalTribPorItem(ncm);
                                try
                                {
                                    qtde = Convert.ToDouble(tb_qtde.Text);
                                }
                                catch { }
                                try
                                {
                                    valor_unit = Convert.ToDouble(tb_valor_unit.Text);
                                }
                                catch { }
                                valor_total = valor_unit * qtde;
                                
                                if (crt_empresa != "1")
                                {
                                    // bc_icms = valor_total;
                                    // aliq_icms = Convert.ToDouble(1
                                }
                                valor_trib = valor_total * porc_trib / 100;

                                string n_nfce = "null";
                                try
                                {
                                    n_nfce = "'" + Convert.ToInt32(tbCod_pedido.Text).ToString() + "'";
                                }
                                catch { }
                                try
                                {
                                    custo = custo * qtde;
                                }
                                catch { }

                                FbCommand insert = new FbCommand();
                                insert.CommandText =
                                    "INSERT INTO ITENS_NFCE " +
                                    "(COD_PEDIDO_INFCE, COD_NFCE_INFCE, COD_ESTOQUE_INFCE, EAN_INFCE, " +
                                    "DESCRICAO_INFCE, UNIDADE_INFCE, QTDE_INFCE, VALOR_UNIT_INFCE, " +
                                    "NCM_INFCE, VALOR_TOTAL_INFCE, CFOP_INFCE, BC_ICMS_INFCE, ALIQ_ICMS_INFCE, " +
                                    "CST_ICMS_INFCE, VALOR_ICMS_INFCE, BC_ICMS_ST_INFCE, ALIQ_ICMS_ST_INFCE, " +
                                    "VALOR_ICMS_ST_INFCE, CST_ICMS_ST_INFCE, PORC_TRIB_INFCE, VALOR_TRIB_INFCE, " +
                                    "VALOR_DESCONTO_INFCE, CUSTO_INFCE) VALUES " +
                                    "('" + tbCod_pedido.Text + "'," + n_nfce + ",'" + cod_estoque + "','" + ean + "','" + descricao + "','" + unidade + "','" + qtde.ToString().Replace(".","").Replace(",", ".") + "','" +
                                    valor_unit.ToString().Replace(".", "").Replace(",", ".") + "','" + ncm + "','" + valor_total.ToString().Replace(".", "").Replace(",", ".") + "','" + cfop + "','" + bc_icms.ToString().Replace(",", ".")
                                    + "','" + aliq_icms.ToString().Replace(".", "").Replace(",", ".") + "'," + st_icms + ",'" +
                                    valor_icms.ToString().Replace(",", ".") + "','" + bc_icms_st.ToString().Replace(".", "").Replace(",", ".") + "','" + aliq_icms_st.ToString().Replace(".", "").Replace(",", ".") + "','" +
                                    valor_icms_st.ToString().Replace(".", "").Replace(",", ".") + "'," + cst_icms_st + ",'" + porc_trib.ToString().Replace(",", ".") + "','" +
                                    valor_trib.ToString().Replace(".", "").Replace(",", ".") + "','" + valor_desconto.ToString().Replace(".", "").Replace(",", ".") + "','" + custo.ToString().Replace(".", "").Replace(",", ".") + "')";

                                insert.Connection = fbConnection1;
                                fbConnection1.Open();
                                FbDataAdapter datInsert = new FbDataAdapter();
                                datInsert.InsertCommand = insert;
                                datInsert.InsertCommand.ExecuteNonQuery();
                                fbConnection1.Close();

                                selecionar_itens(tbCod_pedido.Text);

                                tb_cod.Text = "";
                                tb_qtde.Text = "";
                                tb_valor_unit.Text = "";
                                //labelDescricao.Text = "";
                                tb_cod.Focus();

                            }
                            catch (Exception a)
                            {
                                fbConnection1.Close();
                                MessageBox.Show(a.ToString());
                            }
                        }
                        else
                        {
                            MessageBox.Show("Digite a quantidade do produto");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Digite o valor unitário do produto");
                    }
                }
                else
                    MessageBox.Show("Digite o código do produto");
            }
            else
                MessageBox.Show("Crie um pedido antes de inserir os itens");

        }

        private void selecionar_itens(string pedido)
        {


            try

            {
                dsItens_nfce.Clear();
                FbCommand select = new FbCommand();
                select.CommandText =
                    "SELECT * FROM ITENS_NFCE " +
                    " WHERE COD_PEDIDO_INFCE = '" + pedido + "'";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
               // DataTable dtSelect = new DataTable();
                datSelect.Fill(ITENS_NFCE);
                fbConnection1.Close();
                somar_itens();
                

            }
            catch (Exception a)
            {
                fbConnection1.Close();
            }  

        }

        private void somar_itens()
        {
            if( tb_desconto.Text == "")
            tb_desconto.Text = "0,00";
        //if (tb_valor_pago.Text == "")
            //tb_valor_pago.Text = tb_valor_compra.Text;
            try
            {
                double total_compra = 0;
                for (int i = 0; i < dgvItens.RowCount; i++)
                {
                    total_compra = total_compra + Convert.ToDouble(Convert.ToDouble(dgvItens.Rows[i].Cells[5].Value.ToString()).ToString("n2"));

                }
                valor_produtos_label.Text = total_compra.ToString("n3");
                double desconto = 0;
                double valor_com_desconto = total_compra;
                try
                {
                    desconto = Convert.ToDouble(tb_desconto.Text);
                    valor_com_desconto = total_compra - desconto;
                }
                catch { }
                tb_valor_compra.Text = valor_com_desconto.ToString("n3");
            }
            catch {
                tb_valor_compra.Text = "0,00";
            }

        }

        private double buscarTotalTribPorItem(string ncm)
        {
            double porcTrib = 0;
            try
            {
                OleDbConnection _olecon;
                OleDbCommand _oleCmd;
                String _Arquivo = @"c:/evolucao/Excel/ncm.xls";
                //     String _StringConexao = String.Format(@"provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0 Xml;HDR=YES;ReadOnly=False';", _Arquivo);
                String _StringConexao = String.Format("provider=Microsoft.ACE.OLEDB.12.0;data source='" + _Arquivo + "';Extended Properties=\"Excel 8.0;HDR=YES;IMEX=1;ReadOnly=False\"");
                String _Consulta;
                

                _olecon = new OleDbConnection(_StringConexao);
                _olecon.Open();

                _oleCmd = new OleDbCommand();
                _oleCmd.Connection = _olecon;
                _oleCmd.CommandType = CommandType.Text;

                _oleCmd.CommandText = "SELECT * FROM [ncm$] WHERE ncm = '" + ncm + "'";
                OleDbDataReader reader = _oleCmd.ExecuteReader();
                int i = 3;
                while (reader.Read())
                {
                    porcTrib = Convert.ToDouble(reader.GetString(i).Replace(".", ","));
                }

                reader.Close();

            }
            catch { }
            return porcTrib;
        }

        private void buscar_informacoes_produto(string cod, out string cod_estoque, out string ean, out string descricao, 
            out string unidade, out string ncm, out string cfop, out string st_icms, out double custo)
        {
            cod_estoque = ""; ean = ""; descricao = ""; unidade = ""; ncm = ""; cfop = ""; st_icms = ""; custo = 0;

            try
            {
                FbCommand select = new FbCommand();
                select.CommandText =
                    "SELECT prod.COD_PRODUTO, prod.COD_BARRAS_PRODUTO, prod.DESCRICAO_PRODUTO, " +
                    "prod.COD_UNIDADE_PRODUTO, prod.NCM_PRODUTO, prod.ST_SAIDA_PRODUTO, prod.CUSTO_PRODUTO FROM PRODUTOS prod " +
                    " WHERE (prod.COD_PRODUTO = '" + cod + "' OR prod.COD_BARRAS_PRODUTO = '" + cod + "') ";
                   
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();
                foreach (DataRow dr in dtSelect.Rows)
                {
                    cod_estoque = dr[0].ToString();
                    ean = dr[1].ToString();
                    descricao = dr[2].ToString();
                    unidade = dr[3].ToString();
                    ncm = dr[4].ToString();
                    if (ncm == "99999999" || ncm == "")
                        ncm = "00000000";
                    st_icms = dr[5].ToString();
                   
                    cfop = "5102";
                    if (st_icms == "400" || st_icms == "500" || st_icms == "60")
                        cfop = "5405";
                    if (st_icms == "101" || st_icms == "102")
                        cfop = "5102";
                    try
                    {
                        custo = Convert.ToDouble(dr["CUSTO_PRODUTO"].ToString());
                    }
                    catch { }
                }



            }
            catch (Exception a)
            {
                fbConnection1.Close();
            }  
        }

        private void button5_Click(object sender, EventArgs e)
        {
            criar_pedido_novo();
        }

        private void criar_pedido_novo()
        {
            tb_valor_pago.Text = "";
            tb_troco.Text = "";
            labelDescricao.Text = "";
            dsItens_nfce.Clear();
            dsNfce.Clear();
            labelDesconto.Visible = false;
            tb_desconto.Visible = false;
            labelPorcDesc.Visible = false;
            tb_porc_desc.Visible = false;
            criar_pedido();
            
            
        }
        
        private void criar_pedido()
        {
            try
            {
                string n_nfce = "null";
                int n_pedido = buscar_ultimo_pedido() + 1;
                datNfce.InsertCommand.CommandText =
                    "INSERT INTO NFCE (NUMERO_NFCE, SERIE_NFCE, DATA_EMISSAO_NFCE, PEDIDO_NFCE) VALUES " +
                    "(" + n_nfce.ToString() +",'" + serie_nfce_empresa + "','" + DateTime.Now.ToShortDateString().Replace("/", ".") + "','" + n_pedido + "')";
                datNfce.InsertCommand.Connection = fbConnection1;
                fbConnection1.Open();
                datNfce.InsertCommand.ExecuteNonQuery();
                fbConnection1.Close();

                int ultima_insercao_nfce = buscar_ultima_insercao_nfce();
                selecionar_nfce(ultima_insercao_nfce);
                tb_cod.Focus();
            }
            catch (Exception a)
            {
                fbConnection1.Close();

            }
        }

        private void selecionar_nfce(int ultima_insercao_nfce)
        {
            try
            {
                dsNfce.Clear();
                datNfce.SelectCommand.CommandText =
                    "SELECT * FROM NFCE WHERE COD_NFCE = '" + ultima_insercao_nfce.ToString() + "'";
                datNfce.SelectCommand.Connection = fbConnection1;
                fbConnection1.Open();
                datNfce.Fill(NFCE);
                fbConnection1.Close();
                selecionar_itens(tbCod_pedido.Text);
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                
            }
        }

        private int buscar_ultima_insercao_nfce()
        {
            int retorno = 0;
            try
            {
                FbCommand select = new FbCommand();
                select.CommandText =
                    "SELECT FIRST(1) COD_NFCE FROM NFCE " +
                    " ORDER BY COD_NFCE DESC";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();
                foreach (DataRow dr in dtSelect.Rows)
                {
                    return Convert.ToInt32(dr[0].ToString());
                }
                return retorno;
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                return 0;
            } 
        }

        private int buscar_ultimo_pedido()
        {
            int retorno = 0;
            try
            {
                FbCommand select = new FbCommand();
                select.CommandText =
                    "SELECT FIRST(1) PEDIDO_NFCE FROM NFCE " +
                    " ORDER BY PEDIDO_NFCE DESC";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();
                foreach (DataRow dr in dtSelect.Rows)
                {
                    return Convert.ToInt32(dr[0].ToString());
                }
                return retorno;
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                return 0;
            }  
        }

        private string buscar_ultimo_lancamento()
        {
            string retorno = "0";
            try
            {
                FbCommand select = new FbCommand();
                select.CommandText =
                    "SELECT FIRST(1) NUMERO_NFCE FROM NFCE " +
                    " ORDER BY NUMERO_NFCE DESC";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();
                foreach (DataRow dr in dtSelect.Rows)
                {
                    return dr[0].ToString();
                }
                return retorno;
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                return "0";
            }  

        }

        private void labelDescricao_Click(object sender, EventArgs e)
        {

        }

        private void tb_qtde_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                inserir_item();
            }
        }
        
        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                double valor_total = Convert.ToDouble(tb_valor_compra.Text);
                double valor_pago = Convert.ToDouble(tb_valor_pago.Text);
                double troco = valor_pago - valor_total;
                tb_valor_pago.Text = valor_pago.ToString("n2");
                tb_troco.Text = troco.ToString("n2");
            }
        }

        private void tb_desconto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                double porc_desconto = 0;
                try
                {
                    porc_desconto = Convert.ToDouble(tb_desconto.Text) / Convert.ToDouble(valor_produtos_label.Text) * 100;
                }
                catch { }
                tb_porc_desc.Text = porc_desconto.ToString("n2");
                somar_itens();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!cbFechado.Checked)
            {
                if (tb_valor_pago.Text == "")
                    tb_valor_pago.Text = tb_valor_compra.Text;
                int posX = ((SystemInformation.WorkingArea.Width / 2) - 200);

                int posY = ((SystemInformation.WorkingArea.Height / 2) - 200);
                string _cpf = Microsoft.VisualBasic.Interaction.InputBox("Digite o CPF: ", "Evolução", tb_cpf_cliente.Text, posX, posY);
                tb_cpf_cliente.Text = _cpf;

                form_forma_pagamento_pdv fp = new form_forma_pagamento_pdv();
                try
                {
                    fp.ShowDialog();
                }
                finally
                {
                    tb_forma_pgto.Text = fp.forma_pgto;
                }

                
                tb_data.Text = DateTime.Now.ToShortDateString();
                tb_hora.Text = DateTime.Now.ToShortTimeString();
                cbFechado.Checked = true;
                somar_itens();
               
                salvar_nfce();
                 calcular_estoque();
            }
            else
            {
                MessageBox.Show("Pedido já fechado");
            }
        }
        private string buscar_ean_produto(string idProduto, out string dun, out string qtde, out string cnpj, out string cod)
        {
            dun = ""; qtde = ""; cnpj = ""; cod = "";
            string retorno = "null";
            try
            {
                FbCommand select = new FbCommand();
                FbConnection conexao = new FbConnection();
                conexao.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=True;Packet Size=8192;Server Type=0";
                select.CommandText =
                    "SELECT COD_BARRAS_PRODUTO, COD_BARRAS_CAIXA_PRODUTO, QTDE_UNIDADE_PRODUTO, " +
                    "CNPJ_FORNECEDOR_PRODUTO, COD_PRODUTO FROM PRODUTOS WHERE COD_PRODUTO like '" + idProduto + "' OR COD_FORNECEDOR_PRODUTO LIKE '%" + idProduto + "%'";
                select.Connection = conexao;
                conexao.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                conexao.Close();
                foreach (DataRow dr in dtSelect.Rows)
                {
                    dun = dr[1].ToString(); qtde = dr[2].ToString(); cnpj = dr[3].ToString();
                    cod = dr[4].ToString();
                    if (dr[0].ToString() != "")
                        return dr[0].ToString();
                }
                return retorno;
            }
            catch
            {
                return retorno;
            }
        }

        private void calcular_estoque()
        {
            
            for (int i = 0; i < dgvItens.RowCount; i++)
            {
                try
                {
                    try
                    {
                        string _dun, _qtde, _cnpj, _cod;
                        string ean = buscar_ean_produto(dgvItens.Rows[i].Cells["col_cod"].Value.ToString(), out _dun, out _qtde, out _cnpj, out _cod);

                        //classeEstoque estoque = new classeEstoque();
                        //estoque.fbConnection1.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=True;Packet Size=8192;Server Type=0";
                        //estoque.calcular_estoque(_dun, ean, _qtde, _cnpj, _cod);
                    }
                    catch { }
                }
                catch
                {
                    fbConnection1.Close();
                    //        erro = true;
                    MessageBox.Show("Erro");
                }

            }
        }

        private void salvar_nfce()
        {
            try
            {
                this.BindingContext[dsNfce, "NFCE"].EndCurrentEdit();
                if (dsNfce.HasChanges())
                {
                    fbConnection1.Open();
                    datNfce.UpdateCommand = cbNfce.GetUpdateCommand();
                    datNfce.InsertCommand = cbNfce.GetInsertCommand();
                    datNfce.DeleteCommand = cbNfce.GetDeleteCommand();
                    datNfce.Update(dsNfce, "NFCE");
                    dsNfce.AcceptChanges();
                    fbConnection1.Close();
                }
                this.BindingContext[dsItens_nfce, "ITENS_NFCE"].EndCurrentEdit();
                if (dsItens_nfce.HasChanges())
                {
                    fbConnection1.Open();
                    datItens_nfce.UpdateCommand = cbItens_nfce.GetUpdateCommand();
                    datItens_nfce.InsertCommand = cbItens_nfce.GetInsertCommand();
                    datItens_nfce.DeleteCommand = cbItens_nfce.GetDeleteCommand();
                    datItens_nfce.Update(dsItens_nfce, "ITENS_NFCE");
                    dsItens_nfce.AcceptChanges();
                    fbConnection1.Close();
                }
            }
            catch { }
        }

        private void buscar_dados_cliente(string cnpj,
    out string ie_cliente, out string cnpj_cliente,
    out string logradouro_cliente,
    out string n_logradouro_cliente,
    out string complemento_cliente,
    out string bairro_cliente,
    out string cod_municipio_cliente,
    out string uf_cliente, out string cep_cliente,
    out string cod_pais_cliente, out string pais_cliente,
    out string telefone_cliente, out string cidade_cliente,
    out bool pessoa_fisica, out string email_cliente, out string forma_pgto)
        {
            ie_cliente = ""; cnpj_cliente = ""; logradouro_cliente = ""; n_logradouro_cliente = "";
            complemento_cliente = ""; bairro_cliente = ""; cod_municipio_cliente = "";
            uf_cliente = ""; cep_cliente = ""; cod_pais_cliente = ""; pais_cliente = "";
            telefone_cliente = ""; cidade_cliente = ""; pessoa_fisica = false; email_cliente = ""; forma_pgto = "";
            try
            {
                FbCommand comando = new FbCommand();
                comando.Connection = fbConnection1;
                comando.CommandText =
                    "SELECT * FROM CLIENTES WHERE CNPJ = '" + cnpj + "'";
                fbConnection1.Open();
                //comando_select.Connection = fbConnection1;
                FbDataAdapter datClientes = new FbDataAdapter();
                datClientes.SelectCommand = comando;
                DataSet cliente = new DataSet();
                datClientes.Fill(cliente);
                fbConnection1.Close();
                foreach (DataRow dr in cliente.Tables[0].Rows)
                {
                    ie_cliente = dr["IE"].ToString();
                    cnpj_cliente = dr["CNPJ"].ToString();
                    logradouro_cliente = dr["ENDERECO"].ToString();
                    n_logradouro_cliente = dr["NUMERO_CLIENTE"].ToString();
                    complemento_cliente = dr["COMPLEMENTO_CLIENTE"].ToString();
                    bairro_cliente = dr["BAIRRO"].ToString();
                    cod_municipio_cliente = dr["COD_CIDADE_CLIENTE"].ToString();
                    uf_cliente = dr["ESTADO"].ToString();
                    cep_cliente = dr["CEP_CLIENTE"].ToString();
                    cod_pais_cliente = dr["COD_PAIS_CLIENTE"].ToString();
                    pais_cliente = dr["PAIS"].ToString();
                    telefone_cliente = dr["FONE1"].ToString();
                    cidade_cliente = dr["CIDADE"].ToString();
                    email_cliente = dr["EMAIL"].ToString();
                    forma_pgto = dr["FORMA_PAGAMENTO_CLIENTE"].ToString();
                    if (dr["PESSOA_FISICA_CLIENTE"].ToString() == "1")
                        pessoa_fisica = true;
                    else
                        pessoa_fisica = false;
                }
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        public Boolean criar_arquivo_xml(String Name)
        {
            StreamWriter Arquivo;

            try
            {

                Arquivo = new StreamWriter("c:\\evolucao\\NFCE\\XML\\" + Name);


                //Arquivo.
                Arquivo.Close();
                return true;

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

                return false;

            }

        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (tbRecibo.Text == "")
            {
                if (tb_n_nfce.Text == "")
                {
                    string ultimo = buscar_ultimo_lancamento();
                    int proximo = Convert.ToInt32(ultimo) + 1;
                    tb_n_nfce.Text = proximo.ToString();
                }
                tb_data.Text = DateTime.Now.ToShortDateString();
                tb_hora.Text = DateTime.Now.ToShortTimeString();
                if (gerar_xml_nfce())
                {
                    bool envio_ok = false;
                    bool autorizacao_ok = false;
                    try
                    {
                        enviar_nfce(out envio_ok);
                        salvar_nfce();
                    }
                    finally
                    {
                        if (envio_ok)
                        {
                            try
                            {
                                Thread.Sleep(5000);
                                autorizar(out autorizacao_ok);
                                salvar_nfce();
                            }
                            finally
                            {

                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Recibo preenchido. NF já enviada. Favor clicar em Buscar Autorização para Autorizar");
            }


        }

        private void autorizar(out bool autorizacao_ok)
        {
            autorizacao_ok = false;
            if (tbProtocolo.Text == "")
            {

                int ambiente = 2;
                if (cbNfe_teste.Checked == false)
                    ambiente = 1;
                string proxy = proxy_empresa;
                string usuario = usuario_proxy_empresa;
                string senha = senha_proxy_empresa;
                string licenca = licenca_dll_nfe_empresa;
                string nomeCertificado = nome_certificado_nfe_empresa;
                string _msgCabec, _msgDados, _msgRetWS, _msgResultado;
                string arquivo = "";
                string caminho = "c:\\evolucao\\NFCE\\assinadas\\" + "NFE" + tb_n_nfce.Text + "_assinadas.xml";
                StreamReader objReader = new StreamReader(caminho);
                ArrayList arrText = new ArrayList();
                arquivo = objReader.ReadToEnd();
                string recibo = tbRecibo.Text;
                string _dhProtocolo = "";
                string _nroProtocolo = "";
                string _cMsg = ""; string _xMsg = "";
                int cStat = 0;
                objReader.Close();
                string _procNF = util2.BuscaNFe2G("sp", ambiente, ref arquivo, recibo, nomeCertificado, "3.10", out _msgDados,
                    out _msgRetWS, out cStat, out _msgResultado, out _nroProtocolo, out _dhProtocolo, out _cMsg, out _xMsg, proxy, usuario,
                    senha, licenca);
                //int resultado = util2.ConsultaNF2G(estado_empresa, ambiente, nome_certificado_nfe_empresa,"2.00", out _msgDados, out _msgRetWS, out _msgResultado, tb_chave_acesso_nfe.Text, proxy, usuario, senha);
                //int resultado = util.BuscaNFeSCAN(estado_empresa, ambiente, estado_empresa, ref arquivo, ref recibo, out _procNF, nomeCertificado, out _msgCabec, out _msgDados, out _msgRetWS, out _msgResultado, proxy, usuario, senha, licenca);
                if (cStat == 0)
                {
                    barra_status.Text = "Ok";
                    //tb_status_nfe.Text = "Ok";
                    //salvar_xml_autorizado(_NFeAssinada);
                }
                else
                {
                    if (cStat == 105)
                    {
                        barra_status.Text = "Lote em processamento";
                    }

                    else
                    {
                        if (cStat == 106)
                        {
                            barra_status.Text = "Lote não localizado";
                        }
                        else
                        {
                            if (cStat == 110)
                            {
                                barra_status.Text = "NFe Cancelada.";
                            }
                            else
                            {
                                if (cStat == 100)
                                {
                                    //criar_codigo_barras();
                                    gerar_xml_autorizada(_procNF);
                                    barra_status.Text = "NFe Autorizada. ";
                                    //tb_status_nfe.Text = "NFe Autorizada.";
                                    tbProtocolo.Text = _nroProtocolo;
                                    salvar_nfce();
                                    autorizacao_ok = true;
                                    imprimir_nfce();
                                }
                                else
                                {
                                    MessageBox.Show(_msgResultado, cStat.ToString());
                                    tbRecibo.Text = "";

                                }
                            }
                        }

                    }
                }
            }
            else
            {
                MessageBox.Show("Essa NF já foi autorizada");
            }
        }

        private void gerar_xml_autorizada(string xml_autorizado)
        {
            FileInfo t = new FileInfo("c:\\evolucao\\NFCE\\autorizadas\\" + "NFE" + tbChave.Text + ".xml");
            using (StreamWriter texto = t.CreateText())
            {
                texto.WriteLine(xml_autorizado);
            }
        }

        private void enviar_nfce(out bool envio_ok)
        {
            envio_ok = false;
            if (tbRecibo.Text == "")
            {
                string proxy = proxy_empresa;
                string usuario = usuario_proxy_empresa;
                string senha = senha_proxy_empresa;
                string licenca = licenca_dll_nfe_empresa;
                string nomeCertificado = nome_certificado_nfe_empresa;
                string _nroRecibo, _msgCabec, _msgDados, _msgRetWS, _msgResultado, _NFeAssinada;
                string arquivo = "";
                string caminho_xml = "c:\\evolucao\\NFCE\\XML\\NFE" + tb_n_nfce.Text + ".xml";
                string caminho = "c:\\evolucao\\NFCE\\ASSINADAS\\NFE" + tb_n_nfce.Text + ".xml";

                string arquivo1 = "";
                StreamReader objReader1 = new StreamReader(caminho_xml);
                ArrayList arrText1 = new ArrayList();
                arquivo1 = objReader1.ReadToEnd();
                objReader1.Close();

                int resultado1 = 0;
                string msgResultado1 = "";
                string lote1 = "";
                string url1 = "";
                string assinada = util2.AssinarNFCe(arquivo1, nomeCertificado, "000001", "01605775-5c94-46ac-94ee-f7c17d50b53c", "100", "", "0", out resultado1, out msgResultado1, out lote1, out url1);

                if (assinada == "")
                {
                    MessageBox.Show(msgResultado1);
                }
                /*
                StreamReader objReader = new StreamReader(caminho);
                ArrayList arrText = new ArrayList();
                arquivo = objReader.ReadToEnd();
                objReader.Close();
                 */ 
                int resultado = 0;
                int _cStat = 0;
                string _dhRecbto = "";
                string tMed = "";



                string _xml = util2.EnviaNFe2G("sp", ref assinada, nomeCertificado, "3.10", out _msgDados,
                    out _msgRetWS, out _cStat, out _msgResultado, out _nroRecibo, out _dhRecbto, out tMed,
                    proxy, usuario, senha, licenca);
                //string _xml = util2.EnviaNFe2G("sp", ref arquivo, nomeCertificado, "3.10", out _msgDados,
                //    out _msgRetWS, out _cStat, out _msgResultado, out _nroRecibo, out _dhRecbto, out tMed,
                //    proxy, usuario, senha, licenca);
                resultado = _cStat;
                //int resultado = util.EnviaNFeSCAN(estado_empresa, ref arquivo, out _nroRecibo, nomeCertificado, out _msgCabec, out _msgDados, out _msgRetWS, out _msgResultado, out _NFeAssinada, proxy, usuario, senha, licenca);

                if (resultado == 103)
                {
                    barra_status.Text = "NFe enviada com sucesso. Consulte o Status para autorizá-la";
                    //gbNfe.BackColor = Color.Orange;
                    //tb_status_nfe.Text = "NFe enviada com sucesso. Consulte o Status para autorizá-la";
                    salvar_xml_assinado(_xml);
                    tbRecibo.Text = _nroRecibo;
                    //DateTime data_hora = new DateTime();


                    salvar_nfce();
                    envio_ok = true;
                }
                else
                {
                    MessageBox.Show(_msgResultado, resultado.ToString());

                }

            }
            else
            {
                MessageBox.Show("Essa NF já foi enviada");
                envio_ok = true;
            }

        }

        private void salvar_xml_assinado(string xml_autorizado)
        {

            criar_arquivo_xml("NFE" + tb_n_nfce.Text + "_assinadas.xml");
            FileInfo t = new FileInfo("c:\\evolucao\\NFCE\\assinadas\\" + "NFE" + tb_n_nfce.Text + "_assinadas.xml");
            using (StreamWriter texto = t.CreateText())
            {
                texto.WriteLine(xml_autorizado);
            }


        }

        private bool gerar_xml_nfce()
        {
            criar_arquivo("NFE" + tb_n_nfce.Text + ".txt");
            escrever_no_arquivo_nfe();
            string arquivo;
            string caminho = "c:\\evolucao\\NFCE\\TXT\\NFE" + tb_n_nfce.Text + ".txt";
            StreamReader objReader = new StreamReader(caminho);
            ArrayList arrText = new ArrayList();
            arquivo = objReader.ReadToEnd();
            objReader.Close();
            string _txtNumerado, _erros, _msgResultado;
            int _qtErros;
            int resultado = 0;
            string _XML = util2.Txt2XML2015003(arquivo, 1, "Evolucao", out _txtNumerado, out resultado, out _erros, out _qtErros, out _msgResultado);
            //string _XML = util2.Txt2XML310(arquivo, 1, "Evolucao", out _txtNumerado, out resultado, out _erros, out _qtErros, out _msgResultado);
            //string _XML = util2.Txt2XML2G(arquivo, 1, "Evolucao", out _txtNumerado, out resultado, out _erros, out _qtErros, out _msgResultado);
            if (resultado == 6901)
            {
                //MessageBox.Show(_XML);
                try
                {
                    criar_arquivo_xml("NFE" + tb_n_nfce.Text + ".xml");
                    FileInfo t = new FileInfo("c:\\evolucao\\NFCE\\XML\\" + "NFE" + tb_n_nfce.Text + ".xml");
                    using (StreamWriter texto = t.CreateText())
                    {
                        texto.WriteLine(_XML);
                    }

                    barra_status.Text = "Arquivo XML gerado com sucesso";
                    //tb_status_nfe.Text = "Arquivo XML gerado com sucesso";
                    //gbNfe.BackColor = Color.Yellow;

                    tbChave.Text = buscar_chave("c:\\evolucao\\NFCE\\xml\\" + "NFE" + tb_n_nfce.Text + ".xml");
                    salvar_nfce();
                    return true;
                    //criar_codigo_barras();

                }
                catch
                {
                    barra_status.Text = "Erro, tente outra vez";
                    return false;
                   // tb_status_nfe.Text = "Erro, tente outra vez";
                   // gbNfe.BackColor = Color.Red;
                }
            }
            else
            {
                MessageBox.Show(_erros);
                MessageBox.Show(_msgResultado);
                return false;
            }

        }

        private string buscar_chave(string caminho)
        {
            string chave = "";
            DataSet ds = new DataSet();
            ds.ReadXml(@caminho);
            DataTable dt = ds.Tables["infNFe"];
            DataRow dr = dt.Rows[0];
            chave = dr["Id"].ToString().Replace("NFe", "");
            return chave;
        }

        private string transforma_decimal(int qtde_depois_virg, string numero, int n_caracteres)
        {

            int tamanho = numero.Length;
            int pos_virgula = 0;
            int qtde_decimais = 0;
            if (numero.Contains(","))
            {
                while (numero[pos_virgula].ToString() != ",")
                {
                    pos_virgula++;
                }
                pos_virgula++; //por que começa com 0
                qtde_decimais = tamanho - pos_virgula;
                if (qtde_decimais > qtde_depois_virg)
                {
                    numero = Convert.ToDouble(numero).ToString("n" + qtde_depois_virg.ToString());
                    numero = numero.Replace(".", "");
                }
                for (int i = qtde_decimais; i < qtde_depois_virg; i++)
                {
                    numero = numero + "0";
                }
            }
            else
            {
                if (numero == "")
                    numero = "0";
                numero = numero + ",";
                for (int i = qtde_decimais; i < qtde_depois_virg; i++)
                {
                    numero = numero + "0";
                }
            }

            return numero.Replace(",", ".");
            
        }

        private void escrever_no_arquivo_nfe()
        {

            int nfe = 2;
            if (cbNfe_teste.Checked == false)
                nfe = 1;

            DateTime emissao = Convert.ToDateTime(tb_data.Text);

            int tipo_doc_fiscal;
            tipo_doc_fiscal = 1; //saida

            FileInfo t = new FileInfo("c:\\evolucao\\NFCE\\TXT\\" + "NFE" + tb_n_nfce.Text + ".txt");
            using (StreamWriter texto = t.CreateText())
            {
                texto.WriteLine("NOTA FISCAL |1|");
                string ano = Convert.ToDateTime(tb_data.Text).Year.ToString();
                ano = ano.Remove(0, 2);
                string mes = Convert.ToDateTime(tb_data.Text).Month.ToString();
                if (mes.Length == 1)
                    mes = "0" + mes;
                string _chaveNFe = "";
                string _tipo_emissao = "1"; //SE FOSSE CONTINGÊNCIA SERIA 2 
                string _msgResultado_cria, _cNF, _cDV;

                texto.WriteLine("A|3.10|NFe|");
                if (mes.Length == 1)
                    mes = "0" + mes;
                string dia = emissao.Day.ToString();
                if (dia.Length == 1)
                    dia = "0" + dia;
                DateTime sai_ent = new DateTime();
                string dia_saida, mes_saida, ano_saida;
                string data_completa = ""; //data saida
                try
                {
                    sai_ent = Convert.ToDateTime(tb_data.Text);
                    dia_saida = sai_ent.Day.ToString();
                    if (dia_saida.Length == 1)
                        dia_saida = "0" + dia_saida;
                    mes_saida = sai_ent.Month.ToString();
                    if (mes_saida.Length == 1)
                        mes_saida = "0" + mes_saida;
                    ano_saida = sai_ent.Year.ToString();
                    data_completa = ano_saida + "-" + mes_saida + "-" + dia_saida;
                }

                catch { }

                bool pessoa_fisica = false;
                string ie_cliente_2, cnpj_cliente_2, logradouro_cliente_2, n_logradouro_cliente_2, complemento_cliente_2, bairro_cliente_2, cod_municipio_cliente_2,
                uf_cliente_2, cep_cliente_2, cod_pais_cliente_2, pais_cliente_2, telefone_cliente_2, cidade_cliente_2, email_cliente_2, forma_pgto_2;
                buscar_dados_cliente(tb_cpf_cliente.Text, out ie_cliente_2, out cnpj_cliente_2, out logradouro_cliente_2,
                    out n_logradouro_cliente_2, out complemento_cliente_2, out bairro_cliente_2,
                    out cod_municipio_cliente_2, out uf_cliente_2, out cep_cliente_2, out cod_pais_cliente_2,
                    out pais_cliente_2, out telefone_cliente_2, out cidade_cliente_2, out pessoa_fisica, out email_cliente_2, out forma_pgto_2);

                //NFE 3.0
                string _dhEvento = Convert.ToDateTime(tb_data.Text + " " + tb_hora.Text).ToString("yyyy-MM-ddTHH:mm:sszzz");

                string _data_completa = Convert.ToDateTime(tb_data.Text).ToString("yyyy-MM-ddTHH:mm:sszzz");

                string tipo_operacao = "1"; // verificar_operacao();
                string form_pgto = "0";
                /*1 - DINHEIRO
2 - CARTÃO DE DÉBITO
3 - CARTAO DE CRÉDITO
4 - VALE REFEIÇÃO
5 - CHEQUE*/
               // if(tb_forma_pgto.Text[0] == "1" || tb_forma_pgto.Text[0] == "2" || 
               // if (cb_forma_pgto.Text != "")
              //      form_pgto = cb_forma_pgto.Text[0].ToString();

                string serie = "1";
                if (serie_nfce_empresa != "")
                    serie = serie_nfce_empresa;

                string indIe = "1";
                if (ie_cliente_2 == "ISENTO")
                {
                    indIe = "2";
                    ie_cliente_2 = "";
                }
                if (pessoa_fisica)
                    indIe = "9";

                string suframa = "";

                string finalidade = "1";
                //////////////////////////////////////////////////

                texto.WriteLine("B|" + cod_cidade_empresa.Remove(2) + "||VENDAS|" + form_pgto + "|65|" + serie + "|" + tb_n_nfce.Text +
              //  texto.WriteLine("B|43||VENDAS|" + form_pgto + "|65|" + serie + "|" + tb_n_nfce.Text +
                    "|" + _dhEvento + "||" + tipo_doc_fiscal + "|" + tipo_operacao + "|" + cod_cidade_empresa +
                    "|4|1||" + nfe.ToString() + "|" + finalidade + "|1|1|0|3.0|||");
              
                //////////////////////////////////////////////////


                texto.WriteLine("C|" + razao_social_empresa + "||" + ie_empresa + "||" + im_empresa + "|" + cnae_empresa + "|" + crt_empresa + "|");
                texto.WriteLine("C02|" + cnpj_empresa + "|");
                //texto.WriteLine("C02a|" + tb_cpf.Text + "|");
                texto.WriteLine("C05|" + endereco_empresa + "|" + n_endereco_empresa + "|" + complemento_empresa + "|" + bairro_empresa + "|" + cod_cidade_empresa + "|" + cidade_empresa + "|" + estado_empresa + "|" + cep_empresa + "|||" + telefone_empresa + "|");



                if (tb_cpf_cliente.Text != "")
                {
                    string razao = "Consumidor";
                    if (nfe.ToString() == "2")
                        razao = "NF-E EMITIDA EM AMBIENTE DE HOMOLOGACAO - SEM VALOR FISCAL";
                    texto.WriteLine("E|" + razao + "|9|||||");
                    texto.WriteLine("E03|" + tb_cpf_cliente.Text.Replace(".", "").Replace("/", "").Replace("-", "") + "|");
                    //texto.WriteLine("E05|" + logradouro_cliente_2 + "|" + n_logradouro_cliente_2 + "|" + complemento_cliente_2 + "|" + bairro_cliente_2 + "|" + cod_municipio_cliente_2 + "|" + cidade_cliente_2 + "|" + uf_cliente_2 + "|" + cep_cliente_2.Replace("-", "") + "|" + cod_pais_cliente_2 + "||" + telefone_cliente_2.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", "") + "|");
                }
                //double totalTribNota = 0;
                for (int i = 0; i < dgvItens.RowCount; i++)
                {
                    //preparando campos
                    int numero = i + 1;
                    string qtde_prod = transforma_decimal(4, dgvItens.Rows[i].Cells["col_qtde"].Value.ToString(), 15);
                    string valor_unit_item = transforma_decimal(4, dgvItens.Rows[i].Cells["col_valor_unit"].Value.ToString(), 21);
                    string cod_prod = dgvItens.Rows[i].Cells["col_ean"].Value.ToString();
                    if (cod_prod == "")
                        cod_prod = "000000";
                    string valor_total_item = transforma_decimal(2, dgvItens.Rows[i].Cells["col_valor_total"].Value.ToString(), 15);
                    string frete = "0.00";// transforma_decimal(2, dgvItens.Rows[i].Cells["col_frete"].Value.ToString(), 15);
                    string seguro = "0.00";// transforma_decimal(2, dgvItens.Rows[i].Cells["col_seguro"].Value.ToString(), 15);
                    string desconto = transforma_decimal(2, verificar_desconto_proporcional(dgvItens.Rows[i].Cells["col_valor_total"].Value.ToString()), 15);
                    string outras_desp = "0.00";// transforma_decimal(2, dgvItens.Rows[i].Cells["col_outras_desp"].Value.ToString(), 15);
                    string vTotalTrib = transforma_decimal(2, dgvItens.Rows[i].Cells["col_valor_trib"].Value.ToString(), 15);
                    texto.WriteLine("H|" + numero.ToString() + "|.|");
                    string ean = "";// dgvItens.Rows[i].Cells["col_ean"].Value.ToString();
                   // if (ean.Length != 13)
                    //    ean = "";
                    string ncm = dgvItens.Rows[i].Cells["col_ncm"].Value.ToString();
                    if (ncm == "99999999" || ncm == "")
                        ncm = "00000000";
                    string descricao = dgvItens.Rows[i].Cells["col_descricao"].Value.ToString().Replace("Á", "A").Replace("Ã", "A");
                    if(nfe.ToString() == "2")
                        descricao = "NOTA FISCAL EMITIDA EM AMBIENTE DE HOMOLOGACAO - SEM VALOR FISCAL";
                    string cest = "";
                    if (dgvItens.Rows[i].Cells["col_cst_icms"].Value.ToString() == "10" ||
                        dgvItens.Rows[i].Cells["col_cst_icms"].Value.ToString() == "60" ||
                        dgvItens.Rows[i].Cells["col_cst_icms"].Value.ToString() == "201" ||
                        dgvItens.Rows[i].Cells["col_cst_icms"].Value.ToString() == "202" ||
                        dgvItens.Rows[i].Cells["col_cst_icms"].Value.ToString() == "500" ||
                        dgvItens.Rows[i].Cells["col_cst_icms"].Value.ToString() == "90" ||
                        dgvItens.Rows[i].Cells["col_cst_icms"].Value.ToString() == "70" ||
                        dgvItens.Rows[i].Cells["col_cst_icms"].Value.ToString() == "900")
                    {
                        cest = buscar_cest(dgvItens.Rows[i].Cells["col_ncm"].Value.ToString());
                    }

                    if (cest == "")
                    {
                        cest = "2899900";
                    }

                    string cfop = dgvItens.Rows[i].Cells["col_cfop"].Value.ToString();

                    if (cfop == "")
                    {
                        string cst = dgvItens.Rows[i].Cells["col_cst_icms"].Value.ToString();
                        if (cst == "")
                            cst = "102";

                        if (cst == "500" || cst == "60" || cst == "400")
                            cfop = "5405";
                        else
                            cfop = "5102";

                        dgvItens.Rows[i].Cells["col_cfop"].Value = cfop;
                        salvar_nfce();
                    }

                    texto.WriteLine("I|" + cod_prod + "|" + ean + "|" + descricao +
                        "|" + ncm +
                        "|" + cest +
                        "||" +  cfop +
                        "|" + dgvItens.Rows[i].Cells["col_unidade"].Value.ToString() +
                        "|" + qtde_prod + "|" + valor_unit_item + "|" + valor_total_item +
                        "|" + ean +
                        "|" + dgvItens.Rows[i].Cells["col_unidade"].Value.ToString() +
                        "|" + qtde_prod + "|" + valor_unit_item + "|" + frete +
                        "|" + seguro + "|" + desconto + "|" + outras_desp +
                        "|1" +
                        "||||");

                    int linhas;
                    string[] tributacao = new string[200];
                    tributacao = txt_tributacao(dgvItens.Rows[i].Cells["col_cod_interno"].Value.ToString(),
                        out linhas, cod_municipio_cliente_2, "", vTotalTrib);
                    for (int l = 0; l < linhas; l++)
                    {
                        texto.WriteLine(tributacao[l]);
                    }
                }
                texto.WriteLine("W|");
                double bc_icms = 0, icms = 0, bc_icms_st, icms_st = 0, total_trib = 0;
                buscar_somatorios(out bc_icms, out icms, out bc_icms_st, out icms_st, out total_trib);
                string base_cal_icm = transforma_decimal(2, bc_icms.ToString(), 15);
                string valor_tot_icm = transforma_decimal(2, icms.ToString(), 15);
                string base_cal_icm_st = transforma_decimal(2, bc_icms_st.ToString(), 15);
                string valor_tot_icm_st = transforma_decimal(2, icms_st.ToString(), 15);
                string valor_total_prod = transforma_decimal(2, valor_produtos_label.Text, 15);
                string valor_total_frete = transforma_decimal(2, "0,00", 15);
                string valor_total_seguro = transforma_decimal(2, "0,00", 15);
                string valor_total_desc = transforma_decimal(2, tb_desconto.Text, 15);
                string valot_total_II = "0.00";
                string valor_total_ipi = transforma_decimal(2, "0,00", 15);
                string valor_pis = buscar_total_pis();
                string valor_cofins = buscar_total_cofins();
                string outras_des_ace = transforma_decimal(2, "0,00", 15);
                //string valor_total_nfe = transforma_decimal(2, tb_valor_compra.Text, 15);
                string valor_total_nfe = transforma_decimal(2, valor_produtos_label.Text, 15);
                string vTotTribNf = transforma_decimal(2, total_trib.ToString(), 15);
                string icmsDeson = "0.00";
                // texto.WriteLine("W02|1.00|2.00|3.00|4.00|5.00|6.00|7.00|8.00|9.00|10.00|11.00|12.00|13.00|14.00|15.00|16.00|");
                //texto.WriteLine("W02|" + base_cal_icm + "|" + valor_tot_icm + "|" + icmsDeson + "|" + base_cal_icm_st + "|" + valor_tot_icm_st + "|" + valor_total_prod + "|" + valor_total_frete +
                //    "|" + valor_total_seguro + "|" + valor_total_desc + "|" + valot_total_II + "|" + valor_total_ipi + "|" + valor_pis + "|" + valor_cofins + "|" + outras_des_ace + "|" + valor_total_nfe + "|" + vTotTribNf + "|");
                texto.WriteLine("W02|" + base_cal_icm + "|" + valor_tot_icm + "|" + icmsDeson + "|0.00|0.00|0.00|" + base_cal_icm_st + "|" + valor_tot_icm_st + "|" + valor_total_prod + "|" + valor_total_frete +
                        "|" + valor_total_seguro + "|" + valor_total_desc + "|" + valot_total_II + "|" + valor_total_ipi + "|" + valor_pis + "|" + valor_cofins + "|" + outras_des_ace + "|" + valor_total_nfe + "|" + vTotTribNf + "|");

                //    texto.WriteLine("I|" + cod_prod + "|" + ean + "|" + descricao +
                //        "|" + ncm +
                //        "||" + dgvItens.Rows[i].Cells["col_cfop"].Value.ToString() +
                //        "|" + dgvItens.Rows[i].Cells["col_unidade"].Value.ToString() +
                //        "|" + qtde_prod + "|" + valor_unit_item + "|" + valor_total_item +
                //        "|" + ean +
                //        "|" + dgvItens.Rows[i].Cells["col_unidade"].Value.ToString() +
                //        "|" + qtde_prod + "|" + valor_unit_item + "|" + frete +
                //        "|" + seguro + "|" + desconto + "|" + outras_desp +
                //        "|1" +
                //        "|||");
                  
                //    int linhas;
                //    string[] tributacao = new string[200];
                //    tributacao = txt_tributacao(dgvItens.Rows[i].Cells["col_cod_interno"].Value.ToString(),
                //        out linhas, cod_municipio_cliente_2,"", vTotalTrib);
                //    for (int l = 0; l < linhas; l++)
                //    {
                //        texto.WriteLine(tributacao[l]);
                //    }
                //}
                //texto.WriteLine("W|");
                //double bc_icms = 0, icms = 0, bc_icms_st, icms_st = 0, total_trib = 0;
                //buscar_somatorios(out bc_icms, out icms, out bc_icms_st, out icms_st, out total_trib);
                //string base_cal_icm = transforma_decimal(2, bc_icms.ToString(), 15);
                //string valor_tot_icm = transforma_decimal(2, icms.ToString(), 15);
                //string base_cal_icm_st = transforma_decimal(2, bc_icms_st.ToString(), 15);
                //string valor_tot_icm_st = transforma_decimal(2,icms_st.ToString(), 15);
                //string valor_total_prod = transforma_decimal(2, valor_produtos_label.Text, 15);
                //string valor_total_frete = transforma_decimal(2, "0,00", 15);
                //string valor_total_seguro = transforma_decimal(2,"0,00", 15);
                //string valor_total_desc = transforma_decimal(2, tb_desconto.Text, 15);
                //string valot_total_II = "0.00";
                //string valor_total_ipi = transforma_decimal(2, "0,00", 15);
                //string valor_pis = buscar_total_pis();
                //string valor_cofins = buscar_total_cofins();
                //string outras_des_ace = transforma_decimal(2, "0,00", 15);
                //string valor_total_nfe = transforma_decimal(2, tb_valor_compra.Text, 15);

                //string vTotTribNf = transforma_decimal(2, total_trib.ToString(), 15);
                //string icmsDeson = "0.00";
                //// texto.WriteLine("W02|1.00|2.00|3.00|4.00|5.00|6.00|7.00|8.00|9.00|10.00|11.00|12.00|13.00|14.00|15.00|16.00|");
                //texto.WriteLine("W02|" + base_cal_icm + "|" + valor_tot_icm + "|" + icmsDeson + "|" + base_cal_icm_st + "|" + valor_tot_icm_st + "|" + valor_total_prod + "|" + valor_total_frete +
                //    "|" + valor_total_seguro + "|" + valor_total_desc + "|" + valot_total_II + "|" + valor_total_ipi + "|" + valor_pis + "|" + valor_cofins + "|" + outras_des_ace + "|" + valor_total_nfe + "|" + vTotTribNf + "|");
             
                texto.WriteLine("X|9|");
                texto.WriteLine("X26|||||||");
                
                try
               {
                   //string valor_total = transforma_decimal(2, tb_valor_pago.Text, 15);
                    texto.WriteLine("Y|");
                    texto.WriteLine("YA|99|" + valor_total_nfe + "||||");
                }
                catch { }
                
                texto.WriteLine("Z|||"); //tirando os enter do textbox
            }
        }

        private string buscar_cest(string ncm)
        {
            string cest = "2899900";
            DataSet theDS = new DataSet();
            try
            {
                ncm = Convert.ToInt64(ncm).ToString();
                OleDbConnection theConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;data source='c:\\evolucao\\excel\\cest.xls';Extended Properties=\"Excel 8.0;HDR=NO;IMEX=1;\"");
                theConnection.Open();
                OleDbDataAdapter theDataAdapter = new OleDbDataAdapter("SELECT * FROM [cest$]", theConnection);
                theDataAdapter.Fill(theDS);
                theConnection.Close();

                foreach (DataRow dr in theDS.Tables[0].Select("F3 = '" + ncm + "'"))
                {
                    cest = dr[1].ToString().Replace(".", "");
                }
                foreach (DataRow dr in theDS.Tables[0].Select("F3 = '" + ncm.Remove(ncm.Length - 1) + "'"))
                {
                    cest = dr[1].ToString().Replace(".", "");
                }
                foreach (DataRow dr in theDS.Tables[0].Select("F3 = '" + ncm.Remove(ncm.Length - 2) + "'"))
                {
                    cest = dr[1].ToString().Replace(".", "");
                }
                foreach (DataRow dr in theDS.Tables[0].Select("F3 = '" + ncm.Remove(ncm.Length - 3) + "'"))
                {
                    cest = dr[1].ToString().Replace(".", "");
                }
                foreach (DataRow dr in theDS.Tables[0].Select("F3 = '" + ncm.Remove(ncm.Length - 4) + "'"))
                {
                    cest = dr[1].ToString().Replace(".", "");
                }
                foreach (DataRow dr in theDS.Tables[0].Select("F3 = '" + ncm.Remove(ncm.Length - 5) + "'"))
                {
                    cest = dr[1].ToString().Replace(".", "");
                }
                foreach (DataRow dr in theDS.Tables[0].Select("F3 = '" + ncm.Remove(ncm.Length - 6) + "'"))
                {
                    cest = dr[1].ToString().Replace(".", "");
                } 
            }
            catch{}

            return cest;

        }

        private string verificar_desconto_proporcional(string valor_item)
        {
            try
            {
                if (tb_desconto.Text != "" && tb_desconto.Text != "0,00")
                {
                    double _valor_item = Convert.ToDouble(valor_item);
                    double _valor_desconto = Convert.ToDouble(tb_desconto.Text);
                    double _valor_produtos = Convert.ToDouble(valor_produtos_label.Text);
                    double _valor_desconto_item = _valor_item * _valor_desconto / _valor_produtos;
                    return _valor_desconto_item.ToString();
                }
                else
                    return "0,00";
            }
            catch { return "0,00"; }
        }

        private void buscar_somatorios(out double bc_icms, out double icms, out double bc_icms_st, out double icms_st, out double total_trib)
        {
            bc_icms = 0; icms = 0; bc_icms_st = 0; icms_st = 0; total_trib = 0; 
            for (int i = 0; i < dgvItens.RowCount; i++)
            {
                try
                {
                    bc_icms = bc_icms + Convert.ToDouble(dgvItens.Rows[i].Cells["col_bc_icms"].Value.ToString());
                }
                catch { }
                try
                {
                    icms = icms + Convert.ToDouble(dgvItens.Rows[i].Cells["col_valor_icms"].Value.ToString());
                }
                catch { }
                try
                {
                    bc_icms_st = bc_icms_st + Convert.ToDouble(dgvItens.Rows[i].Cells["col_bc_icms_st"].Value.ToString());
                }
                catch { }
                try
                {
                    icms_st = icms_st + Convert.ToDouble(dgvItens.Rows[i].Cells["col_valor_icms_st"].Value.ToString());
                }
                catch { }
                try
                {
                    total_trib = total_trib + Convert.ToDouble(Convert.ToDouble(dgvItens.Rows[i].Cells["col_valor_trib"].Value.ToString()).ToString("n2"));
                }
                catch { }
            }
        }

        private string buscar_total_cofins()
        {
            return "0.00";
        }

        private string buscar_total_pis()
        {
            return "0.00";
        }

        private string[] txt_tributacao(string cod, out int n_linhas, string cod_municipio, string cod_servico, string totalTrib)
        {

            string[] texto = new string[200];
            int linhas = 2;
            try
            {
                FbCommand comando = new FbCommand();
                comando.Connection = fbConnection1;
                comando.CommandText =
                    "SELECT * FROM ITENS_NFCE WHERE COD_INFCE = " + cod;
                DataSet item = new DataSet();
                fbConnection1.Open();
                FbDataAdapter itens_nota = new FbDataAdapter();
                itens_nota.SelectCommand = comando;
                itens_nota.Fill(item);
                fbConnection1.Close();
                DataRow dr = item.Tables[0].Rows[0];
                if (totalTrib == "0" || totalTrib == "")
                {
                    texto[0] = "M|";
                }
                else
                {
                    texto[0] = "M|" + totalTrib + "|";
                }
                texto[1] = "N|";
                /*
                 * 
                 * //TRIBUTAÇÃO NORMAL
                //CST 00
                if (dr["ST_ITEM"].ToString() == "00")
                {
                    string origem_merc = dr["ORIGEM_ITEM"].ToString();
                    string mod_det_bc_icms = dr["MOD_BC_ITEM"].ToString();
                    string valor_bc_icms = transforma_decimal(2, dr["VALOR_BC_ITEM"].ToString(), 15);
                    string aliq_imp = transforma_decimal(2, dr["ICM_ITEM"].ToString(), 5);
                    string valor_icms = transforma_decimal(2, dr["VALOR_ICM_ITEM"].ToString(), 15);
                    texto[linhas] = "N02|" + origem_merc + "|00|" + mod_det_bc_icms + "|" + valor_bc_icms + "|" + aliq_imp + "|" + valor_icms + "|";
                    linhas++;
                }
                if (dr["ST_ITEM"].ToString() == "10")
                {
                    string origem_merc = dr["ORIGEM_ITEM"].ToString();
                    string mod_det_bc_icms = dr["MOD_BC_ITEM"].ToString();
                    string valor_bc_icms = transforma_decimal(2, dr["VALOR_BC_ITEM"].ToString(), 15);
                    string aliq_imp = transforma_decimal(2, dr["ICM_ITEM"].ToString(), 5);
                    string valor_icms = transforma_decimal(2, dr["VALOR_ICM_ITEM"].ToString(), 15);
                    string st_mod_det_bc_icms = dr["MOD_BC_ST_ITEM"].ToString();
                    string st_per_mar_val_adi_icm = transforma_decimal(2, dr["IVA_ITEM"].ToString(), 5);
                    string st_per_red_bc_icm = transforma_decimal(2, dr["REDUCAO_ST_ITEM"].ToString(), 5);
                    string st_val_bc_icm = transforma_decimal(2, dr["VALOR_BC_ICMS_ST_ITEM"].ToString(), 15);
                    string st_ali_imp_icm = transforma_decimal(2, dr["ICMS_ST_ITEM"].ToString(), 5);
                    string st_valor_icms = transforma_decimal(2, dr["VALOR_ICMS_ST_ITEM"].ToString(), 15);
                    texto[linhas] = "N03|" + origem_merc + "|10|" + mod_det_bc_icms + "|" + valor_bc_icms + "|" + aliq_imp + "|" + valor_icms + "|" + st_mod_det_bc_icms + "|" + st_per_mar_val_adi_icm + "|" + st_per_red_bc_icm + "|" + st_val_bc_icm + "|" + st_ali_imp_icm + "|" + st_valor_icms + "|";
                    linhas++;
                }

                if (dr["ST_ITEM"].ToString() == "20")
                {
                    string origem_merc = dr["ORIGEM_ITEM"].ToString();
                    string mod_det_bc_icms = dr["MOD_BC_ITEM"].ToString();
                    string per_red_bc = transforma_decimal(2, dr["REDUCAO_ITEM"].ToString(), 5);
                    string valor_bc_icms = transforma_decimal(2, dr["VALOR_BC_ITEM"].ToString(), 15);
                    string aliq_imp = transforma_decimal(2, dr["ICM_ITEM"].ToString(), 5);
                    string valor_icms = transforma_decimal(2, dr["VALOR_ICM_ITEM"].ToString(), 15);
                    texto[linhas] = "N04|" + origem_merc + "|20|" + mod_det_bc_icms + "|" + per_red_bc + "|" + valor_bc_icms + "|" + aliq_imp + "|" + valor_icms + "|0.00||";
                    linhas++;
                }

                if (dr["ST_ITEM"].ToString() == "30")
                {
                    string origem_merc = dr["ORIGEM_ITEM"].ToString();
                    string st_mod_det_bc_icms = dr["MOD_BC_ST_ITEM"].ToString();
                    string st_per_mar_val_adi_icm = transforma_decimal(2, dr["IVA_ITEM"].ToString(), 5);
                    string st_per_red_bc_icm = transforma_decimal(2, dr["REDUCAO_ST_ITEM"].ToString(), 5);
                    string st_val_bc_icm = transforma_decimal(2, dr["VALOR_BC_ICMS_ST_ITEM"].ToString(), 15);
                    string st_ali_imp_icm = transforma_decimal(2, dr["ICMS_ST_ITEM"].ToString(), 5);
                    string st_valor_icms = transforma_decimal(2, dr["VALOR_ICMS_ST_ITEM"].ToString(), 15);
                    texto[linhas] = "N05|" + origem_merc + "|30|" + st_mod_det_bc_icms + "|" + st_per_mar_val_adi_icm + "|" + st_per_red_bc_icm + "|" + st_val_bc_icm + "|" + st_ali_imp_icm + "|" + st_valor_icms + "|";
                    linhas++;
                }

                if (dr["ST_ITEM"].ToString() == "40" || dr["ST_ITEM"].ToString() == "41" || dr["ST_ITEM"].ToString() == "50")
                {
                    string origem_merc = dr["ORIGEM_ITEM"].ToString();
                    texto[linhas] = "N06|" + origem_merc + "|" + dr["ST_ITEM"].ToString() + "|0| |"; //O DOIS ULTIMOS CAMPOS SÓ SERÃO USADOS SE FOR VENDA DE VEICULOS
                    linhas++;
                }

                if (dr["ST_ITEM"].ToString() == "51")
                {
                    string origem_merc = dr["ORIGEM_ITEM"].ToString();
                    string mod_det_bc_icms = dr["MOD_BC_ITEM"].ToString();
                    string per_red_bc = transforma_decimal(2, dr["REDUCAO_ITEM"].ToString(), 5);
                    string valor_bc_icms = transforma_decimal(2, dr["VALOR_BC_ITEM"].ToString(), 15);
                    string aliq_imp = transforma_decimal(2, dr["ICM_ITEM"].ToString(), 5);
                    string valor_icms = transforma_decimal(2, dr["VALOR_ICM_ITEM"].ToString(), 15);
                    texto[linhas] = "N07|" + origem_merc + "|51|" + mod_det_bc_icms + "|" + per_red_bc + "|" + valor_bc_icms + "|" + aliq_imp + "|" + valor_icms + "|";
                    linhas++;
                }

                if (dr["ST_ITEM"].ToString() == "60")
                {
                    string origem_merc = dr["ORIGEM_ITEM"].ToString();
                    // string st_val_bc_icm = transforma_decimal(2, tb_st_valor_bc_icms.Text, 15);
                    //string st_valor_icms = transforma_decimal(2, tb_st_val_icms.Text, 15);
                    texto[linhas] = "N08|" + origem_merc + "|60|0|0|"; //CONFORME CONTADOR DISSE É ZERO POIS NÃO TEM COMO SABER
                    linhas++;
                }

                if (dr["ST_ITEM"].ToString() == "70")
                {
                    string origem_merc = dr["ORIGEM_ITEM"].ToString();
                    string mod_det_bc_icms = dr["MOD_BC_ITEM"].ToString();
                    string valor_bc_icms = transforma_decimal(2, dr["VALOR_BC_ITEM"].ToString(), 15);
                    string aliq_imp = transforma_decimal(2, dr["ICM_ITEM"].ToString(), 5);
                    string valor_icms = transforma_decimal(2, dr["VALOR_ICM_ITEM"].ToString(), 15);
                    string st_mod_det_bc_icms = dr["MOD_BC_ST_ITEM"].ToString();
                    string st_per_mar_val_adi_icm = transforma_decimal(2, dr["IVA_ITEM"].ToString(), 5);
                    string st_per_red_bc_icm = transforma_decimal(2, dr["REDUCAO_ST_ITEM"].ToString(), 5);
                    string st_val_bc_icm = transforma_decimal(2, dr["VALOR_BC_ICMS_ST_ITEM"].ToString(), 15);
                    string st_ali_imp_icm = transforma_decimal(2, dr["ICMS_ST_ITEM"].ToString(), 5);
                    string st_valor_icms = transforma_decimal(2, dr["VALOR_ICMS_ST_ITEM"].ToString(), 15);
                    string per_red_bc = transforma_decimal(2, dr["REDUCAO_ITEM"].ToString(), 5);
                    texto[linhas] = "N09|" + origem_merc + "|70|" + mod_det_bc_icms + "|" + per_red_bc + "|" + valor_bc_icms + "|" + aliq_imp + "|" + valor_icms + "|" + st_mod_det_bc_icms + "|" + st_per_mar_val_adi_icm + "|" + st_per_red_bc_icm + "|" + st_val_bc_icm + "|" + st_ali_imp_icm + "|" + st_valor_icms + "|";
                    linhas++;
                }

                if (dr["ST_ITEM"].ToString() == "90")
                {
                    string origem_merc = dr["ORIGEM_ITEM"].ToString();
                    string mod_det_bc_icms = dr["MOD_BC_ITEM"].ToString();
                    string valor_bc_icms = transforma_decimal(2, dr["VALOR_BC_ITEM"].ToString(), 15);
                    string aliq_imp = transforma_decimal(2, dr["ICM_ITEM"].ToString(), 5);
                    string valor_icms = transforma_decimal(2, dr["VALOR_ICM_ITEM"].ToString(), 15);
                    string st_mod_det_bc_icms = dr["MOD_BC_ST_ITEM"].ToString();
                    string st_per_mar_val_adi_icm = transforma_decimal(2, dr["IVA_ITEM"].ToString(), 5);
                    string st_per_red_bc_icm = transforma_decimal(2, dr["REDUCAO_ST_ITEM"].ToString(), 5);
                    string st_val_bc_icm = transforma_decimal(2, dr["VALOR_BC_ICMS_ST_ITEM"].ToString(), 15);
                    string st_ali_imp_icm = transforma_decimal(2, dr["ICMS_ST_ITEM"].ToString(), 5);
                    string st_valor_icms = transforma_decimal(2, dr["VALOR_ICMS_ST_ITEM"].ToString(), 15);
                    string per_red_bc = transforma_decimal(2, dr["REDUCAO_ITEM"].ToString(), 5);
                    texto[linhas] = "N10|" + origem_merc + "|90|" + mod_det_bc_icms + "|" + per_red_bc + "|" + valor_bc_icms + "|" + aliq_imp + "|" + valor_icms + "|" + st_mod_det_bc_icms + "|" + st_per_mar_val_adi_icm + "|" + st_per_red_bc_icm + "|" + st_val_bc_icm + "|" + st_ali_imp_icm + "|" + st_valor_icms + "|";
                    linhas++;
                }
                */

                //SIMPLES NACIONAL
                
               if (dr["CST_ICMS_INFCE"].ToString() == "101")
                {
                    string origem_merc = "0";
                    string mod_det_bc_icms = dr["MOD_BC_ITEM"].ToString();
                    string aliq_simples = transforma_decimal(2, dr["ALIQUOTA_CREDITO_ITEM"].ToString(), 5);
                    string valor_credito = transforma_decimal(2, dr["VALOR_CREDITO_ITEM"].ToString(), 15);
                    texto[linhas] = "N10c|" + origem_merc + "|101|" + aliq_simples + "|" + valor_credito + "|";
                    linhas++;
                }

                if (dr["CST_ICMS_INFCE"].ToString() == "102" || dr["CST_ICMS_INFCE"].ToString() == "103" ||
                    dr["CST_ICMS_INFCE"].ToString() == "300" || dr["CST_ICMS_INFCE"].ToString() == "400" ||
                    dr["CST_ICMS_INFCE"].ToString() == "00")
                {
                    string origem_merc = "0";// dr["ORIGEM_ITEM"].ToString();
                    string mod_det_bc_icms = "3";// dr["MOD_BC_ITEM"].ToString();
                    texto[linhas] = "N10d|" + origem_merc + "|" + dr["CST_ICMS_INFCE"].ToString() + "|";
                    linhas++;
                }
                if (dr["CST_ICMS_INFCE"].ToString() == "500" || dr["CST_ICMS_INFCE"].ToString() == "60")
                {
                    string origem_merc = "0";// dr["ORIGEM_ITEM"].ToString();
                    string mod_det_bc_icms = "3";// dr["MOD_BC_ITEM"].ToString();
                   // texto[linhas] = "N10d|" + origem_merc + "|" + dr["CST_ICMS_INFCE"].ToString() + "|";
                    texto[linhas] = "N10g|0|500|0.00|0.00|";
                    linhas++;
                }

                /*
                if (dr["ST_ITEM"].ToString() == "201")
                {
                    string origem_merc = dr["ORIGEM_ITEM"].ToString();
                    string st_mod_det_bc_icms = dr["MOD_BC_ST_ITEM"].ToString();
                    string st_per_mar_val_adi_icm = transforma_decimal(2, dr["IVA_ITEM"].ToString(), 5);
                    string st_per_red_bc_icm = transforma_decimal(2, dr["REDUCAO_ST_ITEM"].ToString(), 5);
                    string st_val_bc_icm = transforma_decimal(2, dr["VALOR_BC_ICMS_ST_ITEM"].ToString(), 15);
                    string st_ali_imp_icm = transforma_decimal(2, dr["ICMS_ST_ITEM"].ToString(), 5);
                    string st_valor_icms = transforma_decimal(2, dr["VALOR_ICMS_ST_ITEM"].ToString(), 15);
                    string aliq_simples = transforma_decimal(2, dr["ALIQUOTA_CREDITO_ITEM"].ToString(), 5);
                    string valor_credito = transforma_decimal(2, dr["VALOR_CREDITO_ITEM"].ToString(), 15);
                    texto[linhas] = "N10e|" + origem_merc + "|201|" + st_mod_det_bc_icms + "|" + st_per_mar_val_adi_icm +
                        "|" + st_per_red_bc_icm + "|" + st_val_bc_icm + "|" + st_ali_imp_icm + "|" + st_valor_icms +
                        "|" + aliq_simples + "|" + valor_credito + "|";

                    linhas++;
                }
                if (dr["ST_ITEM"].ToString() == "202" || dr["ST_ITEM"].ToString() == "203")
                {
                    string origem_merc = dr["ORIGEM_ITEM"].ToString();
                    string st_mod_det_bc_icms = dr["MOD_BC_ST_ITEM"].ToString();
                    string st_per_mar_val_adi_icm = transforma_decimal(2, dr["IVA_ITEM"].ToString(), 5);
                    string st_per_red_bc_icm = transforma_decimal(2, dr["REDUCAO_ST_ITEM"].ToString(), 5);
                    string st_val_bc_icm = transforma_decimal(2, dr["VALOR_BC_ICMS_ST_ITEM"].ToString(), 15);
                    string st_ali_imp_icm = transforma_decimal(2, dr["ICMS_ST_ITEM"].ToString(), 5);
                    string st_valor_icms = transforma_decimal(2, dr["VALOR_ICMS_ST_ITEM"].ToString(), 15);
                    texto[linhas] = "N10f|" + origem_merc + "|" + dr["ST_ITEM"].ToString() + "|" + st_mod_det_bc_icms + "|" + st_per_mar_val_adi_icm +
                        "|" + st_per_red_bc_icm + "|" + st_val_bc_icm + "|" + st_ali_imp_icm + "|" + st_valor_icms + "|";
                    linhas++;
                }
                if (dr["ST_ITEM"].ToString() == "500")
                {
                    string origem_merc = dr["ORIGEM_ITEM"].ToString();
                    string st_mod_det_bc_icms = dr["MOD_BC_ST_ITEM"].ToString();
                    string valor_bc_icms_st_retido = transforma_decimal(2, "0", 15);
                    string valor_icms_st_retido = transforma_decimal(2, "0", 15);
                    texto[linhas] = "N10g|" + origem_merc + "|500|" + valor_bc_icms_st_retido + "|" + valor_icms_st_retido + "|";
                    linhas++;
                }
                if (dr["ST_ITEM"].ToString() == "900")
                {
                    string origem_merc = dr["ORIGEM_ITEM"].ToString();
                    string mod_det_bc_icms = dr["MOD_BC_ITEM"].ToString();
                    string valor_bc_icms = transforma_decimal(2, dr["VALOR_BC_ITEM"].ToString(), 15);
                    string aliq_imp = transforma_decimal(2, dr["ICM_ITEM"].ToString(), 5);
                    string valor_icms = transforma_decimal(2, dr["VALOR_ICM_ITEM"].ToString(), 15);
                    string st_mod_det_bc_icms = dr["MOD_BC_ST_ITEM"].ToString();
                    string st_per_mar_val_adi_icm = transforma_decimal(2, dr["IVA_ITEM"].ToString(), 5);
                    string st_per_red_bc_icm = transforma_decimal(2, dr["REDUCAO_ST_ITEM"].ToString(), 5);
                    string st_val_bc_icm = transforma_decimal(2, dr["VALOR_BC_ICMS_ST_ITEM"].ToString(), 15);
                    string st_ali_imp_icm = transforma_decimal(2, dr["ICMS_ST_ITEM"].ToString(), 5);
                    string st_valor_icms = transforma_decimal(2, dr["VALOR_ICMS_ST_ITEM"].ToString(), 15);
                    string per_red_bc = transforma_decimal(2, dr["REDUCAO_ITEM"].ToString(), 5);
                    string aliq_simples = transforma_decimal(2, dr["ALIQUOTA_CREDITO_ITEM"].ToString(), 5);
                    string valor_credito = transforma_decimal(2, dr["VALOR_CREDITO_ITEM"].ToString(), 15);
                    texto[linhas] = "N10h|" + origem_merc + "|900|" + mod_det_bc_icms + "|" + valor_bc_icms + "|" + per_red_bc +
                        "|" + aliq_imp + "|" + valor_icms + "|" + st_mod_det_bc_icms + "|" + st_per_mar_val_adi_icm +
                        "|" + st_per_red_bc_icm + "|" + st_val_bc_icm + "|" + st_ali_imp_icm + "|" + st_valor_icms +
                        "|" + aliq_simples + "|" + valor_credito + "|";
                    linhas++;
                }
                 * */
                //IPI
               // texto[linhas] = ("O|||||999|");
            //    linhas++;
            //    string cod_sit_tri_ipi = "";
                /*
                if (dr["IPI_TRIB_ITEM"].ToString() == "1")
                {
                    cod_sit_tri_ipi = dr["CST_IPI_TRIB_ITEM"].ToString();
                    string valor_ipi = transforma_decimal(2, dr["VALOR_IPI_ITEM"].ToString(), 15);
                    texto[linhas] = "O07|" + cod_sit_tri_ipi + "|" + valor_ipi + "|";
                    linhas++;
                    string val_bc_ipi = transforma_decimal(2, dr["BC_IPI_ITEM"].ToString(), 15);
                    string ali_ipi = transforma_decimal(2, dr["IPI_ITEM"].ToString(), 5);
                    texto[linhas] = "O10|" + val_bc_ipi + "|" + ali_ipi + "|";
                    linhas++;
                  
                }
                 * */
               // if (dr["IPI_N_TRIB_ITEM"].ToString() == "1")
             //   {
                  //  cod_sit_tri_ipi = "53";
                //    texto[linhas] = "O08|" + cod_sit_tri_ipi + "|";
               //     linhas++;
               // }
                //PIS
                /*
                if (dr["CST_PIS_ITEM"].ToString() == "01" || dr["CST_PIS_ITEM"].ToString() == "02")
                {
                    texto[linhas] = "Q|"; linhas++;
                    texto[linhas] = "Q02|" + dr["CST_PIS_ITEM"].ToString() + "|" + transforma_decimal(2, dr["BC_PIS_ITEM"].ToString(), 15) + "|" + transforma_decimal(2, dr["PIS_ITEM"].ToString(), 5) + "|" + transforma_decimal(2, dr["VALOR_PIS_ITEM"].ToString(), 15) + "|";
                    linhas++;
                }
                if (dr["CST_PIS_ITEM"].ToString() == "03")
                {
                    texto[linhas] = "Q|"; linhas++;
                    texto[linhas] = "Q03|" + dr["CST_PIS_ITEM"].ToString() + "|" + transforma_decimal(4, dr["QTDE_ITEM"].ToString(), 16) + "|" + transforma_decimal(2, dr["PIS_ITEM"].ToString(), 5) + "|" + transforma_decimal(2, dr["VALOR_PIS_ITEM"].ToString(), 15) + "|";
                    linhas++;
                }
                 * */
               // if (dr["CST_PIS_ITEM"].ToString() == "04" || dr["CST_PIS_ITEM"].ToString() == "06" ||
           //         dr["CST_PIS_ITEM"].ToString() == "07" || dr["CST_PIS_ITEM"].ToString() == "08" ||
           //         dr["CST_PIS_ITEM"].ToString() == "09")
            //    {
                    texto[linhas] = "Q|"; linhas++;
                    texto[linhas] = "Q04|04|";
                    linhas++;
               // }
                //COFINS
            /*
                if (dr["CST_COFINS_ITEM"].ToString() == "01" || dr["CST_COFINS_ITEM"].ToString() == "02")
                {
                    texto[linhas] = "S|"; linhas++;
                    texto[linhas] = "S02|" + dr["CST_COFINS_ITEM"].ToString() + "|" +
                        transforma_decimal(2, dr["BC_COFINS_ITEM"].ToString(), 15) + "|" +
                        transforma_decimal(2, dr["COFINS_ITEM"].ToString(), 5) + "|" +
                        transforma_decimal(2, dr["VALOR_COFINS_ITEM"].ToString(), 15) + "|";
                    linhas++;
                }
                if (dr["CST_COFINS_ITEM"].ToString() == "03")
                {
                    texto[linhas] = "S|"; linhas++;
                    texto[linhas] = "S03|" + dr["CST_COFINS_ITEM"].ToString() + "|" +
                        transforma_decimal(4, dr["QTDE_ITEM"].ToString(), 16) + "|" +
                        transforma_decimal(2, dr["COFINS_ITEM"].ToString(), 5) + "|" +
                        transforma_decimal(2, dr["VALOR_COFINS_ITEM"].ToString(), 15) + "|";
                    linhas++;
                }
             * */
             //   if (dr["CST_COFINS_ITEM"].ToString() == "04" || dr["CST_COFINS_ITEM"].ToString() == "06" ||
             //       dr["CST_COFINS_ITEM"].ToString() == "07" || dr["CST_COFINS_ITEM"].ToString() == "08" ||
             //       dr["CST_COFINS_ITEM"].ToString() == "09")
              //  {
                    texto[linhas] = "S|"; linhas++;
                    texto[linhas] = "S04|04|";
                    linhas++;
              //  }
              //  if (dr["PRESTACAO_SERVICO_ITEM"].ToString() == "1")
        //        {
        //            texto[linhas] = "U|" + transforma_decimal(2, dr["BC_ISS_ITEM"].ToString(), 15) + "|" + transforma_decimal(2, dr["ISS_ITEM"].ToString(), 15) + "|" + transforma_decimal(2, dr["VALOR_ISS_ITEM"].ToString(), 15) + "|" + cod_municipio + "|" + cod_servico + "|N|";
        //        }

                n_linhas = linhas;
                return texto;
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
                n_linhas = linhas;
                return texto;
            }

        }
        public Boolean criar_arquivo(String Name)
        {
            StreamWriter Arquivo;
            try
            {
                Arquivo = new StreamWriter("c:\\evolucao\\NFCE\\TXT\\" + Name);
                Arquivo.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                FbCommand delete = new FbCommand();
                delete.CommandText =
                    "DELETE FROM NFCE WHERE PEDIDO_NFCE = '" + tbCod_pedido.Text + "'";
                delete.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datDelete = new FbDataAdapter();
                datDelete.DeleteCommand = delete;
                datDelete.DeleteCommand.ExecuteNonQuery();
                fbConnection1.Close();

               // FbCommand delete = new FbCommand();
                delete.CommandText =
                    "DELETE FROM ITENS_NFCE WHERE COD_PEDIDO_INFCE = '" + tbCod_pedido.Text + "'";
                delete.Connection = fbConnection1;
                fbConnection1.Open();
                //FbDataAdapter datDelete = new FbDataAdapter();
                datDelete.DeleteCommand = delete;
                datDelete.DeleteCommand.ExecuteNonQuery();
                fbConnection1.Close();

                dsNfce.Clear();
                dsItens_nfce.Clear();

            }
            catch (Exception a)
            {
                fbConnection1.Close();

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            form_pesquisa_pdv _pdv = new form_pesquisa_pdv();
            try
            {
                _pdv.ShowDialog();
            }
            finally
            {
                tb_valor_pago.Text = "";
                tb_troco.Text = "";
                selecionar_nfce(Convert.ToInt32(_pdv.pedido));
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (tb_valor_pago.Text == "")
                tb_valor_pago.Text = tb_valor_compra.Text;
            if (tbChave.Text!= "")
            {
                imprimir_nfce();
            }
            else
            {
                imprimir_pedido();
            }
        }

        private void imprimir_pedido()
        {
            try
            {
                Declaracoes.iRetorno = Declaracoes.eBuscarPortaVelocidade_DUAL_DarumaFramework();
                if (Declaracoes.iRetorno != 1)
                {
                    MessageBox.Show("Impressora desligada!", "DarumaFramework");

                }

                Declaracoes.iRetorno = Declaracoes.regTermica_DUAL_DarumaFramework("1");
                Declaracoes.eDefinirProduto_Daruma("DUAL");
                //BUFFER

                 Declaracoes.iRetorno = Declaracoes.iImprimirBMP_DUAL_DarumaFramework(@"c:\\evolucao\\logo_nfce.bmp");
                 //Declaracoes.iRetorno = Declaracoes.iImprimirTexto_DUAL_DarumaFramework(@"<tb>texto1</tb><tb><ibmp>c:\\evolucao\\logo_nfce.bmp</ibmp></tb><tb>texto</tb>", 0);
                 string desconto = "";
                 if (tb_desconto.Text == "")
                 {
                     tb_desconto.Text = "0,00";

                 }
                 else
                 {
                     try
                     {
                         if (Convert.ToDouble(tb_desconto.Text) > 0)
                         {

                             desconto = @"<l><b>DESCONTO:</b> R$ " + Convert.ToDouble(tb_desconto.Text).ToString("n3") + "</l>";
                         }
                     }
                     catch { }
                 }
                if (tb_troco.Text == "")
                    tb_troco.Text = "0,00";
                


                string itens = "";
                for (int i = 0; i < dgvItens.RowCount; i++)
                {
                    string codigo = zero(11, dgvItens.Rows[i].Cells[1].Value.ToString());
                    if (codigo == "")
                        codigo = zero(11, dgvItens.Rows[i].Cells[0].Value.ToString());
                    string descricao = dgvItens.Rows[i].Cells[2].Value.ToString();
                    if (descricao.Length > 33)
                        descricao = descricao.Remove(33);
                    int item = i + 1;
                    itens = itens + "<l>" + zero(3, item.ToString()) + "<tb><ad>" + codigo + "</ad><tb>" + descricao + "</l>" + 
                        "<l><ad>" + Convert.ToDouble(dgvItens.Rows[i].Cells[3].Value.ToString()).ToString("n2") +
                        "<tb><tb>" + Convert.ToDouble(dgvItens.Rows[i].Cells[4].Value.ToString()).ToString("n3") + 
                        "<tb><tb>" + Convert.ToDouble(dgvItens.Rows[i].Cells[5].Value.ToString()).ToString("n2") + "</l></ad>";
                }
                //Declaracoes.iRetorno = Declaracoes.iImprimirBMP_DUAL_DarumaFramework(@"c:\\1\\logo.bmp");
                Declaracoes.iRetorno = Declaracoes.iImprimirTexto_DUAL_DarumaFramework(@"<e><ce>PEDIDO DE VENDA</e></ce>"+ 
@"<l><tc>-</tc></l><b>" + 
razao_social_empresa + @"<l>" +
@"CNPJ: " + cnpj_empresa + @"/IE: " + ie_empresa + @"</l></b>" +
@"<l><tc>-</tc></l><b>" +  
@"<l><b>Item <tb>Código<tb>Descrição dos itens </l>" + 
@"<l>Vlr. Unit.<tb><tb>Qtde <tb><tb>Vlr.Total</l></b>" +
@"<l><tc>-</tc></l><b>" +
@"</b></c>" + itens +
@"<l><tc>-</tc></l><b>" + 
@"<l><b>VALOR COMPRA:</b> R$ " + Convert.ToDouble(tb_valor_compra.Text).ToString("n3") + "</l>" +
desconto +
@"<l><b>VALOR PAGO:</b> R$ " + Convert.ToDouble(tb_valor_pago.Text).ToString("n2") + "</l>" +
@"<l><b>TROCO:</b> R$ " + Convert.ToDouble(tb_troco.Text).ToString("n2") + "</l>" +
@"<l><b>Forma de Pagamento:</b> R$ " + tb_forma_pgto.Text + "</l>" +
@"<l><tc>-</tc></l><b>" +
@"<l>Controle: " + tbCod_pedido.Text + " " + @" Data:<dt></dt> Hora:<hr></hr></l>" + 
@"<l><tc>-</tc></l><b>" + 
@"<ce><qrcode><lmodulo>3</lmodulo>http://www.labragantina.com.br</qrcode></ce>" +  
@"<l><ce>Visite nosso site:www.labragantina.com.br</ce></l>"+

@"<sl>1</sl>" + 
@"<gui></gui>", 0);

                if (Declaracoes.iRetorno == 1)
                {
                    MessageBox.Show("Impressao Concluida!", "Daruma_Framework_CSharp", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Erro ao realizar a impressão do BUFFER!", "Daruma_Framework_CSharp", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch { }

        }

        
        private string zero(int tamanho_pretendido, string valor)
        {

            int tamanho = valor.Length;
            for (int p = 0; p < tamanho_pretendido - tamanho; p++)
            {
                valor = "0" + valor;
            }
            return valor;
        }

        private void imprimir_nfce()
        {
            try
            {
                Declaracoes.iRetorno = Declaracoes.eBuscarPortaVelocidade_DUAL_DarumaFramework();
                if (Declaracoes.iRetorno != 1)
                {
                    MessageBox.Show("Impressora desligada!", "DarumaFramework");

                }
                
                Declaracoes.iRetorno = Declaracoes.regTermica_DUAL_DarumaFramework("1");
                Declaracoes.eDefinirProduto_Daruma("DUAL");
                //BUFFER

               // Declaracoes.iRetorno = Declaracoes.iImprimirBMP_DUAL_DarumaFramework(@"c:\\evolucao\\logo_nfce.bmp");
              //  Declaracoes.iRetorno = Declaracoes.iImprimirTexto_DUAL_DarumaFramework(@"<tb>texto1</tb><tb><ibmp>c:\\evolucao\\logo_nfce.bmp</ibmp></tb><tb>texto</tb>", 0);

                string itens = "";
                string desconto = "";
                if (tb_desconto.Text == "")
                {
                    tb_desconto.Text = "0,00";

                }
                else
                {try
                    {
                        if (Convert.ToDouble(tb_desconto.Text) > 0)
                        {

                            desconto = @"<l><b>DESCONTO:</b> R$ " + Convert.ToDouble(tb_desconto.Text).ToString("n3") + "</l>";
                        }
                    }
                    catch { }
                }
                if (tb_troco.Text == "")
                    tb_troco.Text = "0,00";
                
                /*
                for (int i = 0; i < dgvItens.RowCount; i++)
                {
                    string codigo = zero(11, dgvItens.Rows[i].Cells[1].Value.ToString());
                    if (codigo == "")
                        codigo = zero(11, dgvItens.Rows[i].Cells[0].Value.ToString());
                    string descricao = dgvItens.Rows[i].Cells[2].Value.ToString();
                    if (descricao.Length > 11)
                        descricao = descricao.Remove(11);
                    itens = itens + "<l>" + codigo + " " + descricao + " " + Convert.ToDouble(dgvItens.Rows[i].Cells[4].Value.ToString()).ToString("n2") +
                        " " + Convert.ToDouble(dgvItens.Rows[i].Cells[5].Value.ToString()).ToString("n2") + dgvItens.Rows[i].Cells[3].Value.ToString() +
                        " " + Convert.ToDouble(dgvItens.Rows[i].Cells[6].Value.ToString()).ToString("n2") + "</l>";
                }
                */
                string cpf ="";
                if(tb_cpf_cliente.Text != "")
                    cpf = @"<l>CPF/CNPJ CONSUMIDOR: " + tb_cpf_cliente.Text + "</l>";
                for (int i = 0; i < dgvItens.RowCount; i++)
                {
                    string codigo = zero(11, dgvItens.Rows[i].Cells[1].Value.ToString());
                    if (codigo == "")
                        codigo = zero(11, dgvItens.Rows[i].Cells[0].Value.ToString());
                    string descricao = dgvItens.Rows[i].Cells[2].Value.ToString();
                    if (descricao.Length > 33)
                        descricao = descricao.Remove(33);
                    int item = i + 1;
                    itens = itens + "<l>" + zero(3, item.ToString()) + "<tb><ad>" + codigo + "</ad><tb>" + descricao + "</l>" +
                        "<l><ad>" + Convert.ToDouble(dgvItens.Rows[i].Cells[3].Value.ToString()).ToString("n2") +
                        "<tb><tb>" + Convert.ToDouble(dgvItens.Rows[i].Cells[4].Value.ToString()).ToString("n3") +
                        "<tb><tb>" + Convert.ToDouble(dgvItens.Rows[i].Cells[5].Value.ToString()).ToString("n2") + "</l></ad>";
                }
                Declaracoes.iRetorno = Declaracoes.iImprimirTexto_DUAL_DarumaFramework(@"<e><ce>DANFE SIMPLIFICADO " +
"<l>Operação Destinada a " + 
"<l>Consumidor Final</e></ce>" +
"<code128><cbv><w2><h50><txt>" + tbChave.Text + @"</txt><txtl> " +

@"<l><tc>-</tc></l><b>" + 
razao_social_empresa + @"<l>" +
@"CNPJ: " + cnpj_empresa + @"/IE: " + ie_empresa + @"</l></b>" +
@"<l><tc>-</tc></l><b>" +  
@"<e><ce>NFC-e
Consulte www.sefaz.sp.gov.br </ce></e>" +
@"<l><tc> </tc></l><b>" +  
@"<l>CHAVE DE ACESSO: " + tbChave.Text +
@"<l><tc> </tc></l><b>" +  
@"<l>AUTORIZAÇÃO DE USO " +
"</l><l>Protocolo: " + tbProtocolo.Text +
@"<l><tc> </tc></l><b>" +  
"</l><l>Data e Hora: " + tb_data.Text + " " + Convert.ToDateTime(tb_hora.Text).ToShortTimeString() +
@"<l><tc> </tc></l><b>" +  
"<l>Série: " + serie_nfce_empresa + "'</l> " + 
"<l>Número da Nota: " + tb_n_nfce.Text + " </l>" +
@"</txtl></h50></w2></cbv></code128> " +
@"<l><tc>-</tc></l><b>" +
@"<l><b>Item <tb>Código<tb>Descrição dos itens </l>" +
@"<l>Qtde<tb><tb>Vlr. Unit.<tb><tb>Vlr.Total</l></b>" +
@"<l><tc>-</tc></l><b>" +
@"</b></c>" + itens +
@"<l><b>VALOR COMPRA:</b> R$ " + Convert.ToDouble(tb_valor_compra.Text).ToString("n3") + "</l>" +
desconto +
@"<l><b>VALOR PAGO:</b> R$ " + Convert.ToDouble(tb_valor_pago.Text).ToString("n2") + "</l>" +
@"<l><b>TROCO:</b> R$ " + Convert.ToDouble(tb_troco.Text).ToString("n2") + "</l>" +
@"<l><b>Forma de Pagamento:</b> " + tb_forma_pgto.Text + "</l>" +
@"<l><tc>-</tc></l><b>" +
@"<l><ce>Controle: " + tbCod_pedido.Text + "  " + cpf + "</ce></l> "  +
@"<l><tc>-</tc></l><b>" + 
@"<ce><qrcode><lmodulo>3</lmodulo>http://www.labragantina.com.br</qrcode></ce>" +  
@"<l><ce>Visite nosso site:www.labragantina.com.br</ce></l>"+
@"<sl>1</sl> 
<gui></gui>
", 0);  

                if (Declaracoes.iRetorno == 1)
                {
                    MessageBox.Show("Impressao Concluida!", "Daruma_Framework_CSharp", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Erro ao realizar a impressão do BUFFER!", "Daruma_Framework_CSharp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                /*
               
               


                Declaracoes.iRetorno = Declaracoes.iImprimirTexto_DUAL_DarumaFramework("<sn><l><ce><s>Teste com Formatação DHTM</s></ce>", 0);
                Declaracoes.iRetorno = Declaracoes.iImprimirTexto_DUAL_DarumaFramework("<n>Estes são os carácteres que<l> você poderá utilizar<n><l>Você poderá a qualquer momento<l> combinar as formatações!!", 0);
                Declaracoes.iRetorno = Declaracoes.iImprimirTexto_DUAL_DarumaFramework("<<b>><</b>> Para sinalizar Negrito", 0);
                Declaracoes.iRetorno = Declaracoes.iImprimirTexto_DUAL_DarumaFramework("<<i>><</i>> Para sinalizar Itálico", 0);
                Declaracoes.iRetorno = Declaracoes.iImprimirTexto_DUAL_DarumaFramework("<<s>><</s>> Para sinalizar Sublinhado", 0);
                Declaracoes.iRetorno = Declaracoes.iImprimirTexto_DUAL_DarumaFramework("<<e>><</e>> Para sinalizar Expandido", 0);
                Declaracoes.iRetorno = Declaracoes.iImprimirTexto_DUAL_DarumaFramework("<<c>><</c>> Para sinalizar Condensado", 0);
                Declaracoes.iRetorno = Declaracoes.iImprimirTexto_DUAL_DarumaFramework("<<n>><</n>> Para sinalizar Normal", 0);
                Declaracoes.iRetorno = Declaracoes.iImprimirTexto_DUAL_DarumaFramework("<<l>><</l>> Para Saltar Uma Linha", 0);
                Declaracoes.iRetorno = Declaracoes.iImprimirTexto_DUAL_DarumaFramework("<<fe>><</fe>> Ativa o Modo fonte Elite", 0);
                Declaracoes.iRetorno = Declaracoes.iImprimirTexto_DUAL_DarumaFramework("<<ad>><</ad>> Para alinhar a direita", 0);
                Declaracoes.iRetorno = Declaracoes.iImprimirTexto_DUAL_DarumaFramework("<<ft>>n1,..,n6<</ft>> Habilitar tabulação", 0);
                Declaracoes.iRetorno = Declaracoes.iImprimirTexto_DUAL_DarumaFramework("<<sl>>NN<</sl>> Saltar Várias Linhas", 0);
                Declaracoes.iRetorno = Declaracoes.iImprimirTexto_DUAL_DarumaFramework("<<tc>>C<</tc>>Riscar Linha<l> com Carácter Específico", 0);
                Declaracoes.iRetorno = Declaracoes.iImprimirTexto_DUAL_DarumaFramework("<<ce>><</ce>> Para Centralizar", 0);
                Declaracoes.iRetorno = Declaracoes.iImprimirTexto_DUAL_DarumaFramework("<<dt>><</dt>> Para Imprimir Data Atual", 0);
                Declaracoes.iRetorno = Declaracoes.iImprimirTexto_DUAL_DarumaFramework("<<hr>><</hr>> Para Imprimir Hora Atual", 0);
                Declaracoes.iRetorno = Declaracoes.iImprimirTexto_DUAL_DarumaFramework("<<sp>>NN<</sp>> Inserir NN Espaços<l> em Branco", 0);
                Declaracoes.iRetorno = Declaracoes.iImprimirTexto_DUAL_DarumaFramework("<<sn>><</sn>> Sinal Sonoro, Apitar", 0);
                Declaracoes.iRetorno = Declaracoes.iImprimirTexto_DUAL_DarumaFramework("<<g>><</g>> Abre a Gaveta", 0);
                Declaracoes.iRetorno = Declaracoes.iImprimirTexto_DUAL_DarumaFramework("<<a>><</a>> Aguardar Término da Impressão", 0);
                Declaracoes.iRetorno = Declaracoes.iImprimirTexto_DUAL_DarumaFramework("<l><tc>_</tc><tc>_</tc>", 0);
                Declaracoes.iRetorno = Declaracoes.iImprimirTexto_DUAL_DarumaFramework("<e><ce>TABULAÇÃO</ce><e><tc>_</tc>", 0);

                //IMPRIMINDO A PRIMEIRA LINHA
                Declaracoes.iRetorno = Declaracoes.iImprimirTexto_DUAL_DarumaFramework("<b>FABR<tb>Ano<tb>Modelo<tb>Valor<tb>Cor</b>", 0);
                //IMPRIMINDO A SEGUNDA LINHA
                Declaracoes.iRetorno = Declaracoes.iImprimirTexto_DUAL_DarumaFramework("GM<tb>2000<tb>Corsa<tb>12.000<tb>Azul", 0);
                //IMPRIMINDO A TERCEIRA LINHA
                Declaracoes.iRetorno = Declaracoes.iImprimirTexto_DUAL_DarumaFramework("Ford<tb>2005<tb>Fiesta<tb>14.000<tb>Azul", 0);
                //IMPRIMINDO A QUARTA LINHA
                Declaracoes.iRetorno = Declaracoes.iImprimirTexto_DUAL_DarumaFramework("Fiat<tb>1998<tb>Uno<tb>9.000<tb>Azul", 0);
                //IMPRIMINDO A QUINTA LINHA
                Declaracoes.iRetorno = Declaracoes.iImprimirTexto_DUAL_DarumaFramework("GM<tb>1997<tb>Vectra<tb>18.000<tb>Azul", 0);
                //IMPRIMINDO A SEXTA LINHA
                Declaracoes.iRetorno = Declaracoes.iImprimirTexto_DUAL_DarumaFramework("GM<tb>1999<tb>Tigra<tb>17.000<tb>Azul", 0);
                //IMPRIMINDO A SETIMA LINHA
                Declaracoes.iRetorno = Declaracoes.iImprimirTexto_DUAL_DarumaFramework("Ford<tb>2001<tb>Ka<tb>5.000<tb>Azul", 0);
                //IMPRIMINDO A OITAVA LINHA
                Declaracoes.iRetorno = Declaracoes.iImprimirTexto_DUAL_DarumaFramework("GM<tb>1998<tb>Corsa<tb>10.000<tb>Azul", 0);
                //IMPRIMINDO A NONA LINHA
                Declaracoes.iRetorno = Declaracoes.iImprimirTexto_DUAL_DarumaFramework("Fiat<tb>1996<tb>Fiurino<tb>6.000<tb>Azul", 0);
                //IMPRIMINDO A DECIMA LINHA
                Declaracoes.iRetorno = Declaracoes.iImprimirTexto_DUAL_DarumaFramework("WV<tb>1979<tb>Fusca<tb>3.000<tb>Azul", 0);
                //IMPRIMINDO A DECIMA PRIMEIRA LINHA
                Declaracoes.iRetorno = Declaracoes.iImprimirTexto_DUAL_DarumaFramework("GM<tb>1996<tb>Vectra<tb>16.000<tb>Azul", 0);
                //IMPRIMINDO A DECIMA SEGUNDA LINHA
                Declaracoes.iRetorno = Declaracoes.iImprimirTexto_DUAL_DarumaFramework("Fiat<tb>1985<tb>Fiat147<tb>3.000<tb>Azul", 0);
                //IMPRIMINDO A DECIMA TERCEIRA LINHA
                Declaracoes.iRetorno = Declaracoes.iImprimirTexto_DUAL_DarumaFramework("GM<tb>2003<tb>Celta<tb>17.000<tb>Azul<sl>7</sl>", 0);

                Declaracoes.iRetorno = Declaracoes.iImprimirTexto_DUAL_DarumaFramework("<l><tc>_</tc>", 0);
                Declaracoes.iRetorno = Declaracoes.iImprimirTexto_DUAL_DarumaFramework("<l></l><e>DATA:<dt></dt></e><l></l><e>Hora:<hr></hr></e><l></l>", 0);
                Declaracoes.iRetorno = Declaracoes.iImprimirTexto_DUAL_DarumaFramework("<ce>Anvançando 3 Linhas</ce><sl>3</sl>", 0);
                Declaracoes.iRetorno = Declaracoes.iImprimirTexto_DUAL_DarumaFramework("<ce>Avançando 1 Linha</ce><sl>1</sl>", 0);
                Declaracoes.iRetorno = Declaracoes.iImprimirTexto_DUAL_DarumaFramework("<l>Inserindo<sp>5</sp>5 espaços em Branco", 0);
                Declaracoes.iRetorno = Declaracoes.iImprimirTexto_DUAL_DarumaFramework("<ce>Formatação Normal</ce>", 0);
                Declaracoes.iRetorno = Declaracoes.iImprimirTexto_DUAL_DarumaFramework("<n>DARUMA AUTOMAÇÃO!!</n><l>", 0);
                Declaracoes.iRetorno = Declaracoes.iImprimirTexto_DUAL_DarumaFramework("<ce>NEGR+ITAL+SUBL+EXPAND</ce>", 0);
                Declaracoes.iRetorno = Declaracoes.iImprimirTexto_DUAL_DarumaFramework("<b><i><s><e>DARUMA AUTOMAÇÃO!!</b></i></s></e>", 0);
                Declaracoes.iRetorno = Declaracoes.iImprimirTexto_DUAL_DarumaFramework("<ce>NEGR+ITAL+SUBL+CONDENSADO</ce>", 0);
                Declaracoes.iRetorno = Declaracoes.iImprimirTexto_DUAL_DarumaFramework("<b><i><s><c>DARUMA AUTOMAÇÃO!!</b></i></s></c>", 0);
                Declaracoes.iRetorno = Declaracoes.iImprimirTexto_DUAL_DarumaFramework("<ce>NEGR+ITAL+SUBL+NORMAL</ce>", 0);
                Declaracoes.iRetorno = Declaracoes.iImprimirTexto_DUAL_DarumaFramework("<b><i><s><n>DARUMA AUTOMAÇÃO!!</b></i></s></n>", 0);
                Declaracoes.iRetorno = Declaracoes.iImprimirTexto_DUAL_DarumaFramework("<e>DARUMA AUTOMAÇÃO!!<e>", 0);
                Declaracoes.iRetorno = Declaracoes.iImprimirTexto_DUAL_DarumaFramework("<ce>CONDENSADO</ce>", 0);
                Declaracoes.iRetorno = Declaracoes.iImprimirTexto_DUAL_DarumaFramework("<c>DARUMA AUTOMAÇÃO!!</c>", 0);
                Declaracoes.iRetorno = Declaracoes.iImprimirTexto_DUAL_DarumaFramework("<ce>NEGRITO+EXPANDIDO</ce>", 0);
                Declaracoes.iRetorno = Declaracoes.iImprimirTexto_DUAL_DarumaFramework("<b><e>DARUMA AUTOMAÇÃO!!</b></e>", 0);
                Declaracoes.iRetorno = Declaracoes.iImprimirTexto_DUAL_DarumaFramework("<ce>ITÁLICO+EXPANDIDO</ce>", 0);
                Declaracoes.iRetorno = Declaracoes.iImprimirTexto_DUAL_DarumaFramework("<i><e>DARUMA AUTOMAÇÃO!!</i></e>", 0);
                Declaracoes.iRetorno = Declaracoes.iImprimirTexto_DUAL_DarumaFramework("<ce><dt></dt>SUBLINHADO+EXPANDIDO</ce>", 0);
                Declaracoes.iRetorno = Declaracoes.iImprimirTexto_DUAL_DarumaFramework("<s><e>DARUMA AUTOMAÇÃO!!</s></e>", 0);
                Declaracoes.iRetorno = Declaracoes.iImprimirTexto_DUAL_DarumaFramework("<ce>NEGRITO+CONDENSADO</ce>", 0);
                Declaracoes.iRetorno = Declaracoes.iImprimirTexto_DUAL_DarumaFramework("<b><c>DARUMA AUTOMAÇÃO!!</b></c>", 0);
                Declaracoes.iRetorno = Declaracoes.iImprimirTexto_DUAL_DarumaFramework("<ce>ITÁLICO+CONDENSADO</ce>", 0);
                Declaracoes.iRetorno = Declaracoes.iImprimirTexto_DUAL_DarumaFramework("<i><c>DARUMA AUTOMAÇÃO!!</i></c>", 0);
                Declaracoes.iRetorno = Declaracoes.iImprimirTexto_DUAL_DarumaFramework("<ce>SUBLINHADO+CONDENSADO</ce>", 0);
                Declaracoes.iRetorno = Declaracoes.iImprimirTexto_DUAL_DarumaFramework("<s><c>DARUMA AUTOMAÇÃO!!</s></c>", 0);
                Declaracoes.iRetorno = Declaracoes.iImprimirTexto_DUAL_DarumaFramework("<ce>NEGRITO+NORMAL</ce>", 0);
                Declaracoes.iRetorno = Declaracoes.iImprimirTexto_DUAL_DarumaFramework("<b><n>DARUMA AUTOMAÇÃO!!</b></n>", 0);
                Declaracoes.iRetorno = Declaracoes.iImprimirTexto_DUAL_DarumaFramework("<ce>ITÁLICO+NORMAL</ce>", 0);
                Declaracoes.iRetorno = Declaracoes.iImprimirTexto_DUAL_DarumaFramework("<l><i><n>DARUMA AUTOMAÇÃO!!</i></n>", 0);
                Declaracoes.iRetorno = Declaracoes.iImprimirTexto_DUAL_DarumaFramework("<ce>SUBLINHADO+NORMAL</ce>", 0);
                Declaracoes.iRetorno = Declaracoes.iImprimirTexto_DUAL_DarumaFramework("<s><n>DARUMA AUTOMAÇÃO!!</s></n><l>", 0);
                Declaracoes.iRetorno = Declaracoes.iImprimirTexto_DUAL_DarumaFramework("<ce>ALINHADO A DIREITA</ce>", 0);
                Declaracoes.iRetorno = Declaracoes.iImprimirTexto_DUAL_DarumaFramework("<ad>DARUMA</ad><l>", 0);
                Declaracoes.iRetorno = Declaracoes.iImprimirTexto_DUAL_DarumaFramework("<ce>CENTRALIZADO + EXPANDIDO</ce>", 0);
                Declaracoes.iRetorno = Declaracoes.iImprimirTexto_DUAL_DarumaFramework("<e><ce>DARUMA!!</ce></e><l>", 0);
                Declaracoes.iRetorno = Declaracoes.iImprimirTexto_DUAL_DarumaFramework("<ft>05,10,15,20,30,40</ft>", 0);
                Declaracoes.iRetorno = Declaracoes.iImprimirTexto_DUAL_DarumaFramework("<ce>TABULADO NA COLUNA 10</ce>", 0);
                Declaracoes.iRetorno = Declaracoes.iImprimirTexto_DUAL_DarumaFramework("<tb></tb><tb></tb>DARUMA<l>", 0);
                Declaracoes.iRetorno = Declaracoes.iImprimirTexto_DUAL_DarumaFramework("<l><e><b>FIM TAGS COMPLETO</e></b>", 0);
                Declaracoes.iRetorno = Declaracoes.iImprimirTexto_DUAL_DarumaFramework("<sl>03</sl>", 0);

                if (Declaracoes.iRetorno == 1)
                {
                    MessageBox.Show("Impressao Concluida!", "Daruma_Framework_CSharp", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Erro, na impressão do Exemplo 3!", "Daruma_Framework_CSharp", MessageBoxButtons.OK, MessageBoxIcon.Error);
           */

            }
            catch (Exception a)
            {

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            somar_itens();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            labelDesconto.Visible = true;
            tb_desconto.Visible = true;
            labelPorcDesc.Visible = true;
            tb_porc_desc.Visible = true;
        }

        private void tb_porc_desc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                double desconto = 0;
                try
                {
                    desconto = Convert.ToDouble(valor_produtos_label.Text) * Convert.ToDouble(tb_porc_desc.Text) / 100;
                }
                catch { }
                tb_desconto.Text = desconto.ToString("n2");
                somar_itens();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (tbRecibo.Text != "")
            {
                try
                {
                    Thread.Sleep(5000);
                    bool autorizacao_ok = false;
                    autorizar(out autorizacao_ok);
                    salvar_nfce();
                }
                finally
                {

                }
            }
        }

        private void dgvItens_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
           
        }

        private void dgvItens_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            somar_itens();
            salvar_nfce();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            form_localiza_produto localiza_item = new form_localiza_produto(true, cnpj);
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
                    tb_cod.Text = localiza_item.ean_escolhido;
                    buscar_item(tb_cod.Text);

                }

            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            salvar_nfce();
        }

        private void btnEmail_Click(object sender, EventArgs e)
        {
            if (tbProtocolo.Text != "")
            {
                form_digite_email form_email = new form_digite_email();
                string email = "";
                try
                {
                    form_email.ShowDialog();
                }
                finally
                {
                    Email enviar_email = new Email();
                    email = form_email.email;
                    string caminho = @"c:\\evolucao\\nfce\autorizadas\NFE" + tbChave.Text + ".xml";
                    string caminho_danfe = @"c:\\evolucao\\nfce\DANFES\DANFE_NFCE_" + tb_n_nfce.Text + ".pdf";
                    bool _erro;
                    GerarPdfNfce pdf = new GerarPdfNfce();
                    pdf.gerarPdf(caminho);
                    string assunto = "NFCe " + nome_fantasia_empresa + " nº. " + tb_n_nfce.Text;
                    string corpo =
"<html xmlns:v='urn:schemas-microsoft-com:vml'" +
"xmlns:o='urn:schemas-microsoft-com:office:office'" +
"xmlns:w='urn:schemas-microsoft-com:office:word'" +
"xmlns='http://www.w3.org/TR/REC-html40'>" +

"<head>" +
"<meta http-equiv=Content-Type content='text/html; charset=windows-1252'>" +
"<meta name=ProgId content=Word.Document>" +
"<meta name=Generator content='Microsoft Word 11'>" +
"<meta name=Originator content='Microsoft Word 11'>" +
"<link rel=File-List href='body_arquivos/filelist.xml'>" +
"<title>Prezado cliente,</title>" +
"</head>" +
"<body lang=PT-BR link=blue vlink=purple style='tab-interval:35.4pt' fontface = 'Arial'> " +
"<div class=Section1> " +
"<p class=MsoPlainText><span style='font-family:'Calibri''>Prezado cliente,<o:p></o:p></span></p> " +
"<p class=MsoPlainText><span style='font-family:'Calibri''><o:p>&nbsp;</o:p></span></p>" +
"<p class=MsoPlainText><span style='font-family:'Calibri''>Segue anexo o Cupom Eletronico em XML e o DANFE segue em PDF.<br><br><o:p></o:p></span></p>" +
        "<p class=MsoPlainText><span style='font-family:'Calibri''>Atenciosamente,<o:p></o:p></span></p>" +
"<p class=MsoNormal><span style='font-size:10.0pt;font-family:'Calibri';" +
"mso-bidi-font-family:Arial'><o:p>&nbsp;</o:p></span></p>" +
"<p class=MsoNormal><span style='font-size:10.0pt;font-family:'Calibri';" +
"mso-no-proof:yes'>_________________________<br>" + nome_fantasia_empresa +
"<br>" +
"Tel: " + telefone_empresa + "<br>" +
"e-mail: <a href='mailto:" + email_nfe_empresa + "'>" + email_nfe_empresa + "</a><br><br><br><br>" +
"<p class=MsoPlainText><span style='font-size:6.5pt;font-family:'Calibri''>Documento emitido por Evolução Informática <br>(11) 2277-0369<br><br><o:p></o:p></span></p>" +
"</div>" +
"</body>" +
"</html>";
                    enviar_email.EnviarEmail(email, assunto, corpo, caminho, caminho_danfe, "", email_nfe_empresa, senha_email_nfe_empresa, smtp_nfe_empresa, out _erro, "");
                    if (_erro == false)
                    {
                        MessageBox.Show("Email enviado com sucesso. ");
                    }
                    else
                    {
                        MessageBox.Show("Email não enviado. Favor verificar dados. ");
                    }
                }
            }
        }

        
    }
}
