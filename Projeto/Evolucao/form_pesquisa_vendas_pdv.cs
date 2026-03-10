using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using Epson;
using System.Text;

using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace Evolucao
{
    public partial class form_pesquisa_vendas_pdv : Form
    {
        DataTable dtSelect = new DataTable();
        DataTable dtImpressoras = new DataTable();
        public string cnpj;
        public form_pesquisa_vendas_pdv(string cnpj)
        {
            this.cnpj = cnpj;
            InitializeComponent();
        }
        string razao_social_empresa = "", nome_fantasia_empresa = "", cnpj_empresa = "", ie_empresa = "", im_empresa = "", cnae_empresa = "", endereco_empresa = "", n_endereco_empresa = "",
                      complemento_empresa = "", bairro_empresa = "", cidade_empresa = "", estado_empresa = "", cep_empresa = "", telefone_empresa = "", cod_cidade_empresa = "", pais_empresa = "",
                      cod_pais_empresa = "", licenca_dll_nfe_empresa = "", nome_certificado_nfe_empresa = "", assunto_nfe_email_empresa = "", smtp_nfe_empresa = "", email_nfe_empresa = "",
                      senha_email_nfe_empresa = "", logotipo_empresa = "", proxy_empresa = "", usuario_proxy_empresa = "", senha_proxy_empresa = "", crt_empresa = "", serie_nfce_empresa = "";



        private void btnAddVendedor_Click(object sender, EventArgs e)
        {
            form_vendedores vend = new form_vendedores();
            try
            {
                vend.ShowDialog();
            }
            finally
            {
                vend.Dispose();
                tb_cod_vendedor.Text = vend.cod_vendedor_escolhido;
                tb_nome_vendedor.Text = vend.vendedor_escolhido;
            }
        }

        //private void btnAddCliente_Click(object sender, EventArgs e)
        //{
        //    form_localiza_cliente localiza_cliente = new form_localiza_cliente(true, "");
        //    try
        //    {
        //        localiza_cliente.ShowDialog();
        //    }
        //    finally
        //    {
        //        localiza_cliente.Dispose();
        //        tb_nome_cliente.Text = localiza_cliente.cliente_escolhido;
        //        tb_cod_cliente.Text = localiza_cliente.cnpj_escolhido;
        //    }
        //}

        private void button2_Click(object sender, EventArgs e)
        {
            form_localiza_produto localiza_item = new form_localiza_produto(false, cnpj);
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
                   localizar_item(localiza_item.cod_produto_escolhido);
                }

            }
        }

        private void localizar_item(string cod)
        {

            try
            {
                FbCommand comando_select = new FbCommand();
                comando_select.CommandText = "SELECT * FROM PRODUTOS WHERE COD_PRODUTO = '" + cod + "'";
                comando_select.Connection = fbConnection1;
                DataSet prod = new DataSet();
                fbConnection1.Open();
                FbDataAdapter datProdutos = new FbDataAdapter();
                datProdutos.SelectCommand = comando_select;
                datProdutos.Fill(prod);
                fbConnection1.Close(); 

                foreach (DataRow dr in prod.Tables[0].Rows)
                {
                    tb_cod_produto.Text = dr["COD_PRODUTO"].ToString();
                    tb_descricao_produto.Text = dr["DESCRICAO_PRODUTO"].ToString();
                }
            }
            catch
            {

                fbConnection1.Close(); 
            }





        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                dtSelect.Clear();

                string produto = "";
                if (cbProduto.Checked)
                    produto = " AND IPED.COD_ESTOQUE_INFCE = '" + tb_cod_produto.Text + "' ";

                string vendedor = "";
                if (cb_vendedor.Checked)
                    vendedor = " AND IPED.COD_VENDEDOR_INFCE = " + tb_cod_vendedor.Text;

                string nfce = "";
                if (cbNfce.Checked)
                    nfce = " AND ped.PROTOCOLO_NFCE IS NOT NULL ";
               


                    FbCommand select = new FbCommand();
                    select.CommandText =
                        "SELECT prod.COD_PRODUTO as COD, prod.DESCRICAO_PRODUTO, cast(sum(iped.QTDE_INFCE) AS NUMERIC(15,3)) " + 
                        "as QTDE_TOTAL, cast(sum(iped.VALOR_TOTAL_INFCE) AS NUMERIC(15,2)) AS VALOR_TOTAL FROM PRODUTOS prod " +
                        "INNER JOIN ITENS_NFCE iped ON prod.COD_PRODUTO = iped.COD_ESTOQUE_INFCE " +
                        "INNER JOIN NFCE ped ON ped.PEDIDO_NFCE = iped.COD_PEDIDO_INFCE " +
                        "WHERE ped.DATA_EMISSAO_NFCE >= '" + Convert.ToDateTime(dtInicial.Text).ToShortDateString().Replace("/", ".") + "' AND " +
                        "ped.DATA_EMISSAO_NFCE <= '" + Convert.ToDateTime(dtFinal.Text).ToShortDateString().Replace("/", ".") + "' AND " +
                        "ped.PEDIDO_FECHADO_NFCE = '1' " + produto + vendedor + nfce +
                        "group by prod.COD_PRODUTO, prod.DESCRICAO_PRODUTO";
                    select.Connection = fbConnection1;
                    fbConnection1.Open();
                    FbDataAdapter datSelect = new FbDataAdapter();
                    datSelect.SelectCommand = select;
                    datSelect.Fill(dtSelect);
                    fbConnection1.Close();
                    somar();
                
            }

            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private void somar()
        {
            double qtde = 0, valor = 0;
            for(int i = 0; i < dgvSelect.RowCount; i++)
            {
                try
                {
                    qtde = qtde + Convert.ToDouble(dgvSelect.Rows[i].Cells["QTDE_TOTAL"].Value.ToString());
                }
                catch{}
                  try
                {
                    valor = valor + Convert.ToDouble(dgvSelect.Rows[i].Cells["VALOR_TOTAL"].Value.ToString());
                }
                catch{}
            }
            tb_qtde.Text = qtde.ToString();
            tb_valor.Text = valor.ToString("n2");
        }

        private void form_pesquisa_vendas_Load(object sender, EventArgs e)
        {
            dgvSelect.DataSource = dtSelect;

            detectar_dados_empresa(out razao_social_empresa, out nome_fantasia_empresa, out cnpj_empresa, out ie_empresa, out im_empresa, out cnae_empresa, out endereco_empresa, out n_endereco_empresa,
                              out complemento_empresa, out bairro_empresa, out cidade_empresa, out estado_empresa, out cep_empresa, out telefone_empresa, out cod_cidade_empresa, out pais_empresa,
                              out cod_pais_empresa, out licenca_dll_nfe_empresa, out nome_certificado_nfe_empresa, out assunto_nfe_email_empresa, out smtp_nfe_empresa, out email_nfe_empresa,
                              out senha_email_nfe_empresa, out logotipo_empresa, out proxy_empresa, out usuario_proxy_empresa, out senha_proxy_empresa, out crt_empresa, out serie_nfce_empresa);
            
            carregar_impressoras();
        }

        private void carregar_impressoras()
        {
            try
            {
                dtImpressoras.Clear();
                FbCommand select = new FbCommand();
                select.CommandText = "SELECT * FROM IMPRESSORAS";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datImpressora = new FbDataAdapter();
                datImpressora.SelectCommand = select;
                datImpressora.Fill(dtImpressoras);
                fbConnection1.Close();
            }
            catch
            {
                fbConnection1.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string relatorio = "";
            double valor_total = 0;

            foreach (DataRow dr in dtSelect.Rows)
            {
                try
                {
                    string cod = dr["COD"].ToString();
                    if (cod.Length > 3)
                        cod = cod.Remove(3);
                    cod = tamanho_ideal(3, cod);

                    string descricao = dr["DESCRICAO_PRODUTO"].ToString();
                    if (descricao.Length > 25)
                        descricao = descricao.Remove(25);
                    descricao = tamanho_ideal(25, descricao);

                    string qtde = dr["QTDE_TOTAL"].ToString();
                    if (qtde.Length > 4)
                        qtde = qtde.Remove(4);
                    qtde = tamanho_ideal(4, qtde);

                    string valor = Convert.ToDouble(dr["VALOR_TOTAL"]).ToString("n2");

                    valor_total = valor_total + Convert.ToDouble(valor);
                    
                    if (valor.Length > 10)
                        valor = valor.Remove(10);
                    valor = tamanho_ideal_esquerda(10, valor);
                    

                    relatorio = relatorio + 
                            "<b>" + cod + "| " + descricao + "| " + qtde + "|" + valor + "</b>\n";

                 }
                 catch { }
            }

            string szTexto = new String(' ', 4096);

            szTexto = "<b>-----------------------------------------------</b>\n";
            szTexto += "<b><ce>************  VENDAS POR ITENS  ************</ce></b>\n";
            szTexto += "<b><ce>DATA: " + dtInicial.Text + "</ce></b>\n";
            szTexto += "<b>-----------------------------------------------</b>\n";
            szTexto += "<b> COD|         DESCRICAO        | QTD |   VALOR  </b> \n";
            szTexto += "<b>-----------------------------------------------</b>\n";
            szTexto += "" + relatorio;
            szTexto += "<b>-----------------------------------------------</b>\n";
            szTexto += "<b>**TOTAL DE VENDAS**  -  R$ " + valor_total.ToString("n2") + "</b>\n";
            szTexto += "<b>-----------------------------------------------</b>\n";
            szTexto += "<b></b>\n";
            szTexto += "<b></b>\n";
            szTexto += "<gui></gui>";

            string porta_principal = "";

            foreach (DataRow dr in dtImpressoras.Select("NOME_IMPRESSORA = 'CAIXA'"))
            {
                porta_principal = dr["PORTA_IMPRESSORA"].ToString();
            }
            int iRetorno;

            try
            {
                iRetorno = InterfaceEpsonNF.FechaPorta();
                Thread.Sleep(1000);
            }
            catch { }
            iRetorno = InterfaceEpsonNF.IniciaPorta(porta_principal);
            iRetorno = InterfaceEpsonNF.ImprimeTextoTag(szTexto);

            if (iRetorno == 1)
            { }

            else
            {
                System.Windows.Forms.MessageBox.Show("Erro ao imprimir pedido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                iRetorno = InterfaceEpsonNF.FechaPorta();
            }
                
            
        }

        private string tamanho_ideal(int tamanho, string descricao)
        {
            int tamanho_atual = descricao.Length;
            int espacos_depois = tamanho - tamanho_atual;
            for (int i = 0; i < espacos_depois; i++)
            {
                descricao = descricao + " ";
            }
            return descricao;
        }

        private string tamanho_ideal_esquerda(int tamanho, string descricao)
        {
            int tamanho_atual = descricao.Length;
            int espacos_depois = tamanho - tamanho_atual;
            for (int i = 0; i < espacos_depois; i++)
            {
                descricao = " " + descricao;
            }
            return descricao;
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
                comando.CommandText = "SELECT * FROM EMPRESA";
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

                    //byte[] data = (byte[])dt.Rows[0]["IMAGE"];
                    //MemoryStream ms = new MemoryStream(figura);
                    //pictureBox1.Image = Image.FromStream(ms);

                    //pbLogo.Image = Image.FromStream(ms);'
                    logotipo_empresa = dr["LOGOTIPO_EMPRESA"].ToString();
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
        
    }
}
