using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BoletoNet;
using System.IO;
using System.Web;
using DFW;
using CrystalDecisions.Shared;
using System.Runtime.InteropServices;
using System.Drawing.Printing;
using System.Globalization;
using System.Data.OleDb;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.CSharp.RuntimeBinder;


namespace Evolucao
{
    public partial class form_pedidos : Form
    {
        //variaveis detecta_fatura
        string[] _datas = new string[50];
        string[] _valores = new string[50];
        string[] _cod = new string[50];

        public bool abrir;
        public bool fechar;
        public bool novo;
        public bool novo_pedido;
        public bool imprimir_direto;
        public string cod_a_abrir;
        public int n_orc;

        public string cod_usuario;
        public string cnpj_empresa;
        public form_pedidos(string cnpj_empresa)
        {
            this.cnpj_empresa = cnpj_empresa;
            InitializeComponent();
        }

        private void tb_descricao_peca_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F2:
                    if (cbTipo.Text.Trim() != "" && cbStatus.Text.Trim() != "")
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
                                localizar_item(localiza_item.cod_produto_escolhido);
                            }

                        }
                    }
                    else
                    {
                        MessageBox.Show("Preencha o Status e o Tipo do Pedido antes de selecionar os itens.");
                    }

                    break;
            }

        }
        private void localizar_item_fornecedor(string cod)
        {

            try
            {
                comando_select.CommandText = "SELECT * FROM PRODUTOS WHERE COD_FORNECEDOR_PRODUTO = '" + cod + "'";
                DataSet prod = new DataSet();
                fbConnection1.Open();
                datProdutos.SelectCommand = comando_select;
                datProdutos.Fill(prod);
                fbConnection1.Close();
                if (prod.Tables[0].Rows.Count > 1)
                {
                    MessageBox.Show("Esse item tem vários cadastros para o mesmo código. Nesse caso você tem que selecioná-lo pelo F2");
                }
                else
                {
                    foreach (DataRow dr in prod.Tables[0].Rows)
                    {
                        tb_ncm.Text = dr["NCM_PRODUTO"].ToString();
                        tb_cod_fornecedor.Text = dr["COD_FORNECEDOR_PRODUTO"].ToString();
                        tb_descricao_produto.Text = dr["DESCRICAO_PRODUTO"].ToString();
                        tb_unid_item.Text = dr["COD_UNIDADE_PRODUTO"].ToString();
                        tb_preco_unit_item.Text = dr["VALOR_VENDA_REVEND_PRODUTO"].ToString();
                        double valor_desconto = buscar_desconto_cliente(tb_cnpj_cliente.Text);
                        double acrescimo = 1;
                        double valor_icms_pis_cofins = buscar_valor_icms_pis_cofins(tb_cnpj_cliente.Text, dr["COD_PRODUTO"].ToString(), out acrescimo);
                        if (dr["NOME_FORNECEDOR_PRODUTO"].ToString().ToUpper() != "ENTRELUX")
                            valor_icms_pis_cofins = 1;
                        double valor_correto = 0;
                        try
                        {
                            valor_correto = Convert.ToDouble(tb_preco_unit_item.Text) * valor_icms_pis_cofins * acrescimo;
                            if (valor_desconto > 0)
                            {
                                valor_correto = Convert.ToDouble(tb_preco_unit_item.Text) - Convert.ToDouble(tb_preco_unit_item.Text) * valor_desconto / 100;
                            }
                        }
                        catch { }



                        tb_preco_unit_item.Text = valor_correto.ToString();
                        tb_descricao_item.Text = dr["DESCRICAO_ITEM_PRODUTO"].ToString();
                        tb_marca.Text = dr["MARCA_PRODUTO"].ToString();
                        tb_cod_sistema.Text = dr["COD_PRODUTO"].ToString();

                        double preco_unit = buscar_tabela_preco(tb_cod_sistema.Text);
                        if (preco_unit != 0)
                            tb_preco_unit_item.Text = preco_unit.ToString();

                    }
                }
            }
            catch
            {

                fbConnection1.Close();
            }





        }

        private double buscar_valor_icms_pis_cofins(string cnpj, string cod_produto, out double acrescimo)
        {
            double retorno = 1;
            acrescimo = 1;
            try
            {
                string _origem, _cst, _modalidade, _icms, _icms_st, _reducao, _reducao_st, _iva, _ipi, _pis,
                 _cofins, _iss, _crt, _aliquota_credito, _modalidade_st, _bc_com_ipi, _ipi_tributado,
                 _ipi_n_tributado, _cst_ipi_tributado, _cst_ipi_n_tributado, _tipo_pis, _cst_pis,
                 _tipo_cofins, _cst_cofins, _pCredICMS, _preco_minimo, _custo_produto, _cfop_produto, _cest_produto;

                double icmsCliente = 1, icmsStCliente = 1;
                string estado = buscar_estado_cliente(cnpj, out icmsCliente, out icmsStCliente);

                double preco_produto = 0;
                string ncm = tb_ncm.Text;
                try
                {

                    buscar_informacoes_produto(cod_produto,
                    out _origem, out _cst, out _modalidade, out _icms,
                    out _icms_st, out _reducao, out _reducao_st, out _iva, out _ipi, out _pis, out _cofins,
                    out _iss, out _crt, out _aliquota_credito, out _modalidade_st, out _bc_com_ipi,
                    out _ipi_tributado, out _ipi_n_tributado, out _cst_ipi_tributado,
                    out _cst_ipi_n_tributado, out _tipo_pis, out _cst_pis, out _tipo_cofins, out _cst_cofins,
                    out _pCredICMS, out _preco_minimo, out _custo_produto, out _cfop_produto, out _cest_produto, cbTipo.Text, estado, ncm);


                    /*39259090
85365090
85366910
85177900
*/
                    if (icmsCliente == 0)
                        _icms = "0";


                    if (ncm == "39259090" ||
                        ncm == "85365090" ||
                        ncm == "85366910" ||
                        ncm == "85177900")
                    {
                        if (cbTipo.Text.Contains("Consumidor"))
                            acrescimo = 1.28;
                        if (cbTipo.Text.Contains("Atacadista"))
                            acrescimo = 0.80;

                        retorno = (1 + (Convert.ToDouble(_icms) / 100 + Convert.ToDouble(_pis) / 100 +
                            Convert.ToDouble(_cofins) / 100));
                    }


                    return retorno;


                }
                catch { return retorno; }
            }
            catch { return retorno; }
        }


        private double buscar_desconto_cliente(string cnpj)
        {
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                select.CommandText =
                    "SELECT DESCONTO_PONTUALIDADE_CLIENTE FROM CLIENTES WHERE CNPJ = '" + cnpj + "'";
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();
                foreach (DataRow dr in dtSelect.Rows)
                {
                    return Convert.ToDouble(dr[0].ToString());
                }
                return 0;

            }
            catch (Exception a)
            {
                fbConnection1.Close();
                return 0;
            }
        }

        private double buscar_tabela_preco(string cod)
        {
            if (razao_social_empresa.ToUpper().Contains("DEBORA") || razao_social_empresa.ToUpper().Contains("DANIEL"))
                cod = cod.Substring(0, 3);
            string _select = "SELECT PRECO_PRODUTO_ITEM_TP FROM ITENS_TP itens " +
                    "INNER JOIN CLIENTES cli ON itens.COD_TABELA_ITEM_TP = cli.COD_TP_CLIENTE " +
                    " WHERE COD_PRODUTO_ITEM_TP = '" + cod + "' and cli.CNPJ = '" + tb_cnpj_cliente.Text + "'";
            if (tb_cod_tabela.Text != "")
                _select = "SELECT PRECO_PRODUTO_ITEM_TP FROM ITENS_TP itens " +
                   " WHERE COD_PRODUTO_ITEM_TP = '" + cod + "' and itens.COD_TABELA_ITEM_TP = '" + tb_cod_tabela.Text + "'"; ;
            try
            {
                FbCommand select = new FbCommand(); select.Connection = fbConnection1;
                select.CommandText = _select;
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();
                foreach (DataRow dr in dtSelect.Rows)
                {
                    double preco = 0;
                    try
                    {
                        preco = Convert.ToDouble(dr[0].ToString());
                    }
                    catch { }
                    return preco;
                }
                return 0;
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                return 0;
            }
        }

        private void localizar_item(string cod)
        {

            try
            {
                comando_select.CommandText = "SELECT * FROM PRODUTOS WHERE COD_PRODUTO = '" + cod + "'";
                DataSet prod = new DataSet();
                fbConnection1.Open();
                datProdutos.SelectCommand = comando_select;
                datProdutos.Fill(prod);
                fbConnection1.Close();

                foreach (DataRow dr in prod.Tables[0].Rows)
                {
                    tb_ncm.Text = dr["NCM_PRODUTO"].ToString();
                    tb_cod_fornecedor.Text = dr["COD_FORNECEDOR_PRODUTO"].ToString();
                    tb_descricao_produto.Text = dr["DESCRICAO_PRODUTO"].ToString();
                    tb_unid_item.Text = dr["COD_UNIDADE_PRODUTO"].ToString();
                    tb_preco_unit_item.Text = dr["VALOR_VENDA_REVEND_PRODUTO"].ToString();
                    double valor_desconto = buscar_desconto_cliente(tb_cnpj_cliente.Text);
                    double acrescimo = 1;
                    double valor_icms_pis_cofins = buscar_valor_icms_pis_cofins(tb_cnpj_cliente.Text, dr["COD_PRODUTO"].ToString(), out acrescimo);
                    if (dr["NOME_FORNECEDOR_PRODUTO"].ToString().ToUpper() != "ENTRELUX")
                        valor_icms_pis_cofins = 1;
                    double valor_correto = 0;
                    try
                    {
                        valor_correto = Convert.ToDouble(tb_preco_unit_item.Text) * valor_icms_pis_cofins * acrescimo;
                        if (valor_desconto > 0)
                        {
                            valor_correto = Convert.ToDouble(tb_preco_unit_item.Text) - Convert.ToDouble(tb_preco_unit_item.Text) * valor_desconto / 100;
                        }
                    }
                    catch { }



                    tb_preco_unit_item.Text = valor_correto.ToString();
                    tb_descricao_item.Text = dr["DESCRICAO_ITEM_PRODUTO"].ToString();
                    tb_marca.Text = dr["MARCA_PRODUTO"].ToString();
                    tb_cod_sistema.Text = dr["COD_PRODUTO"].ToString();

                    double preco_unit = buscar_tabela_preco(tb_cod_sistema.Text);
                    if (preco_unit != 0)
                        tb_preco_unit_item.Text = preco_unit.ToString();
                    //tb_cod_fornecedor.Text = dr["COD_FORNECEDOR_PRODUTO"].ToString();
                    //tb_descricao_produto.Text = dr["DESCRICAO_PRODUTO"].ToString();
                    //tb_unid_item.Text = dr["COD_UNIDADE_PRODUTO"].ToString();
                    //tb_ncm.Text = dr["NCM_PRODUTO"].ToString();

                    //if (cbPrecominimo.Checked)
                    //{
                    //    tb_preco_unit_item.Text = dr["VALOR_PROMOCAO_PRODUTO"].ToString();
                    //}
                    //else
                    //{
                    //    tb_preco_unit_item.Text = dr["VALOR_VENDA_REVEND_PRODUTO"].ToString();
                    //}
                    //tb_descricao_item.Text = dr["DESCRICAO_ITEM_PRODUTO"].ToString();
                    //tb_marca.Text = dr["MARCA_PRODUTO"].ToString();
                    //tb_cod_sistema.Text = dr["COD_PRODUTO"].ToString();
                    //tb_ean.Text = dr["COD_BARRAS_PRODUTO"].ToString();

                    //double preco_unit = buscar_tabela_preco(tb_cod_sistema.Text);
                    ////double valor_st = 
                    //if (preco_unit != 0)
                    //    tb_preco_unit_item.Text = preco_unit.ToString();

                }
            }
            catch
            {

                fbConnection1.Close();
            }





        }
        string razao_social_empresa = "", nome_fantasia_empresa = "", ie_empresa = "", im_empresa = "", cnae_empresa = "", endereco_empresa = "", n_endereco_empresa = "",
          complemento_empresa = "", bairro_empresa = "", cidade_empresa = "", estado_empresa = "", cep_empresa = "", telefone_empresa = "", cod_cidade_empresa = "", pais_empresa = "",
          cod_pais_empresa = "", licenca_dll_nfe_empresa = "", nome_certificado_nfe_empresa = "", assunto_nfe_email_empresa = "", smtp_nfe_empresa = "", email_nfe_empresa = "",
          senha_email_nfe_empresa = "", logotipo_empresa = "", proxy_empresa = "", usuario_proxy_empresa = "", senha_proxy_empresa = "", crt_empresa = "", portaEmailEmpresa = "",
          sslEmpresa = "", serie_empresa = "", boleto_pedido_empresa = "", cliente_inadimplente_empresa = "", _cod_transmissao = "";

        private void detectar_dados_empresa(out string razao_social_empresa, out string nome_fantasia_empresa, out string cnpj_empresa, out string ie_empresa, out string im_empresa, out string cnae_empresa, out string endereco_empresa, out string n_endereco_empresa,
               out string complemento_empresa, out string bairro_empresa, out string cidade_empresa, out string estado_empresa, out string cep_empresa, out string telefone_empresa, out string cod_cidade_empresa, out string pais_empresa,
               out string cod_pais_empresa, out string licenca_dll_nfe_empresa, out string nome_certificado_nfe_empresa, out string assunto_nfe_email_empresa, out string smtp_nfe_empresa, out string email_nfe_empresa,
               out string senha_email_nfe_empresa, out string logotipo_empresa, out string proxy_empresa, out string usuario_proxy_empresa, out string senha_proxy_empresa,
       out string crt_empresa, out string portaEmailEmpresa, out string sslEmpresa, out string serie_empresa, out string boleto_pedido_empresa, out string cliente_inadimplente_empresa)
        {
            razao_social_empresa = ""; nome_fantasia_empresa = ""; cnpj_empresa = this.cnpj_empresa; ie_empresa = ""; im_empresa = ""; cnae_empresa = ""; endereco_empresa = ""; n_endereco_empresa = "";
            complemento_empresa = ""; bairro_empresa = ""; cidade_empresa = ""; estado_empresa = ""; cep_empresa = ""; telefone_empresa = ""; cod_cidade_empresa = ""; pais_empresa = "";
            cod_pais_empresa = ""; licenca_dll_nfe_empresa = ""; nome_certificado_nfe_empresa = ""; assunto_nfe_email_empresa = ""; smtp_nfe_empresa = ""; email_nfe_empresa = "";
            senha_email_nfe_empresa = ""; logotipo_empresa = ""; proxy_empresa = ""; usuario_proxy_empresa = ""; senha_proxy_empresa = ""; crt_empresa = ""; portaEmailEmpresa = "";
            sslEmpresa = ""; serie_empresa = ""; boleto_pedido_empresa = ""; cliente_inadimplente_empresa = "";
            try
            {
                FbCommand comando = new FbCommand();
                comando.Connection = fbConnection1;
                comando.CommandText = "SELECT * FROM EMPRESA where LICENCA_DLL_NFE_EMPRESA is not null and cnpj_empresa = '" + cnpj_empresa + "'";
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
                    // cnpj_empresa = dr["CNPJ_EMPRESA"].ToString().Replace(".", "").Replace("/", "").Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "");
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
                    if (tb_cnpj_empresa.Text == "")
                    {
                        tb_cnpj_empresa.Text = cnpj_empresa;
                        tb_descricao_empresa.Text = razao_social_empresa;
                    }
                }

            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }
        private void buscar_ncm_cst()
        {
            if (razao_social_empresa.Contains("COMPANY"))
            {
                try
                {
                    //OleDbConnection theConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;data source='c:\\evolucao\\excel\\ncm_cst.xlsx';Extended Properties=\"Excel 12.0 Xml;HDR=Yes;IMEX=1;\"");
                    //OleDbConnection theConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;data source='c:\\evolucao\\excel\\ncm_cst_antigo.xls';Extended Properties=\"Excel 12.0 Xml;HDR=Yes;IMEX=1;\"");
                    OleDbConnection theConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;data source='c:\\evolucao\\excel\\ncm_cst_company.xls';Extended Properties=\"Excel 12.0 Xml;HDR=Yes;IMEX=1;\"");
                    theConnection.Open();
                    OleDbDataAdapter theDataAdapter = new OleDbDataAdapter("SELECT * FROM [ncm$]", theConnection);
                    DataSet theDS = new DataSet();
                    theDataAdapter.Fill(dtNcm_cst);
                    theConnection.Close();
                }
                catch
                {
                    MessageBox.Show("Erro ao ler arquivo NCM_CST_COMPANY");

                }
            }
            else if (razao_social_empresa.Contains("MECANICA"))
            {
                try
                {
                    //OleDbConnection theConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;data source='c:\\evolucao\\excel\\ncm_cst.xlsx';Extended Properties=\"Excel 12.0 Xml;HDR=Yes;IMEX=1;\"");
                    //OleDbConnection theConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;data source='c:\\evolucao\\excel\\ncm_cst_antigo.xls';Extended Properties=\"Excel 12.0 Xml;HDR=Yes;IMEX=1;\"");
                    OleDbConnection theConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;data source='c:\\evolucao\\excel\\ncm_cst_mecanica.xls';Extended Properties=\"Excel 12.0 Xml;HDR=Yes;IMEX=1;\"");
                    theConnection.Open();
                    OleDbDataAdapter theDataAdapter = new OleDbDataAdapter("SELECT * FROM [ncm$]", theConnection);
                    DataSet theDS = new DataSet();
                    theDataAdapter.Fill(dtNcm_cst);
                    theConnection.Close();
                }
                catch
                {
                    MessageBox.Show("Erro ao ler arquivo NCM_CST_MECANICA");

                }
            }
            else if (cnpj_empresa.Contains("47755820000157")) //claratec
            {
                try
                {
                    //OleDbConnection theConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;data source='c:\\evolucao\\excel\\ncm_cst.xlsx';Extended Properties=\"Excel 12.0 Xml;HDR=Yes;IMEX=1;\"");
                    //OleDbConnection theConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;data source='c:\\evolucao\\excel\\ncm_cst_antigo.xls';Extended Properties=\"Excel 12.0 Xml;HDR=Yes;IMEX=1;\"");
                    OleDbConnection theConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;data source='c:\\evolucao\\excel\\ncm_cst_claratec.xls';Extended Properties=\"Excel 12.0 Xml;HDR=Yes;IMEX=1;\"");
                    theConnection.Open();
                    OleDbDataAdapter theDataAdapter = new OleDbDataAdapter("SELECT * FROM [ncm$]", theConnection);
                    DataSet theDS = new DataSet();
                    theDataAdapter.Fill(dtNcm_cst);
                    theConnection.Close();
                }
                catch
                {
                    MessageBox.Show("Erro ao ler arquivo NCM_CST_MECANICA");

                }
            }
            else
            {
                try
                {
                    //OleDbConnection theConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;data source='c:\\evolucao\\excel\\ncm_cst.xlsx';Extended Properties=\"Excel 12.0 Xml;HDR=Yes;IMEX=1;\"");
                    //OleDbConnection theConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;data source='c:\\evolucao\\excel\\ncm_cst_antigo.xls';Extended Properties=\"Excel 12.0 Xml;HDR=Yes;IMEX=1;\"");
                    OleDbConnection theConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;data source='c:\\evolucao\\excel\\ncm_cst.xls';Extended Properties=\"Excel 12.0 Xml;HDR=Yes;IMEX=1;\"");
                    theConnection.Open();
                    OleDbDataAdapter theDataAdapter = new OleDbDataAdapter("SELECT * FROM [ncm$]", theConnection);
                    DataSet theDS = new DataSet();
                    theDataAdapter.Fill(dtNcm_cst);
                    theConnection.Close();

                    foreach (DataRow row in dtNcm_cst.Rows)
                    {
                        // Verifique se a coluna CFOP não é nula antes de converter para string
                        if (!row.IsNull("CFOP"))
                        {
                            // Converta o valor da coluna CFOP para string
                            row["CFOP"] = row["CFOP"].ToString();
                        }
                        else
                        {
                            // Se a coluna CFOP for nula, você pode atribuir uma string vazia ou outro valor padrão, se necessário
                            row["CFOP"] = string.Empty; // Ou qualquer outro valor padrão desejado
                        }
                    }
                }
                catch
                {
                    // MessageBox.Show("Erro ao ler arquivo NCM_CST");

                }
            }
        }

        //private void buscar_ncm_cst()
        //{
        //    if (razao_social_empresa.Contains("COMPANY"))
        //    {
        //        try
        //        {
        //            //OleDbConnection theConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;data source='c:\\evolucao\\excel\\ncm_cst.xlsx';Extended Properties=\"Excel 12.0 Xml;HDR=Yes;IMEX=1;\"");
        //            //OleDbConnection theConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;data source='c:\\evolucao\\excel\\ncm_cst_antigo.xls';Extended Properties=\"Excel 12.0 Xml;HDR=Yes;IMEX=1;\"");
        //            OleDbConnection theConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;data source='c:\\evolucao\\excel\\ncm_cst_company.xls';Extended Properties=\"Excel 12.0 Xml;HDR=Yes;IMEX=1;\"");
        //            theConnection.Open();
        //            OleDbDataAdapter theDataAdapter = new OleDbDataAdapter("SELECT * FROM [ncm$]", theConnection);
        //            DataSet theDS = new DataSet();
        //            theDataAdapter.Fill(dtNcm_cst);
        //            theConnection.Close();
        //        }
        //        catch
        //        {
        //            MessageBox.Show("Erro ao ler arquivo NCM_CST_COMPANY");

        //        }
        //    }
        //    else if (razao_social_empresa.Contains("MECANICA"))
        //    {
        //        try
        //        {
        //            //OleDbConnection theConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;data source='c:\\evolucao\\excel\\ncm_cst.xlsx';Extended Properties=\"Excel 12.0 Xml;HDR=Yes;IMEX=1;\"");
        //            //OleDbConnection theConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;data source='c:\\evolucao\\excel\\ncm_cst_antigo.xls';Extended Properties=\"Excel 12.0 Xml;HDR=Yes;IMEX=1;\"");
        //            OleDbConnection theConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;data source='c:\\evolucao\\excel\\ncm_cst_mecanica.xls';Extended Properties=\"Excel 12.0 Xml;HDR=Yes;IMEX=1;\"");
        //            theConnection.Open();
        //            OleDbDataAdapter theDataAdapter = new OleDbDataAdapter("SELECT * FROM [ncm$]", theConnection);
        //            DataSet theDS = new DataSet();
        //            theDataAdapter.Fill(dtNcm_cst);
        //            theConnection.Close();
        //        }
        //        catch
        //        {
        //            MessageBox.Show("Erro ao ler arquivo NCM_CST_MECANICA");

        //        }
        //    }
        //    else if (cnpj_empresa.Contains("47755820000157")) //claratec
        //    {
        //        try
        //        {
        //            //OleDbConnection theConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;data source='c:\\evolucao\\excel\\ncm_cst.xlsx';Extended Properties=\"Excel 12.0 Xml;HDR=Yes;IMEX=1;\"");
        //            //OleDbConnection theConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;data source='c:\\evolucao\\excel\\ncm_cst_antigo.xls';Extended Properties=\"Excel 12.0 Xml;HDR=Yes;IMEX=1;\"");
        //            OleDbConnection theConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;data source='c:\\evolucao\\excel\\ncm_cst_claratec.xls';Extended Properties=\"Excel 12.0 Xml;HDR=Yes;IMEX=1;\"");
        //            theConnection.Open();
        //            OleDbDataAdapter theDataAdapter = new OleDbDataAdapter("SELECT * FROM [ncm$]", theConnection);
        //            DataSet theDS = new DataSet();
        //            theDataAdapter.Fill(dtNcm_cst);
        //            theConnection.Close();
        //        }
        //        catch
        //        {
        //            MessageBox.Show("Erro ao ler arquivo NCM_CST_MECANICA");

        //        }
        //    }
        //    else
        //    {
        //        try
        //        {
        //            //OleDbConnection theConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;data source='c:\\evolucao\\excel\\ncm_cst.xlsx';Extended Properties=\"Excel 12.0 Xml;HDR=Yes;IMEX=1;\"");
        //            //OleDbConnection theConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;data source='c:\\evolucao\\excel\\ncm_cst_antigo.xls';Extended Properties=\"Excel 12.0 Xml;HDR=Yes;IMEX=1;\"");
        //            OleDbConnection theConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;data source='c:\\evolucao\\excel\\ncm_cst.xls';Extended Properties=\"Excel 12.0 Xml;HDR=Yes;IMEX=1;\"");
        //            theConnection.Open();
        //            OleDbDataAdapter theDataAdapter = new OleDbDataAdapter("SELECT * FROM [ncm$]", theConnection);
        //            DataSet theDS = new DataSet();
        //            theDataAdapter.Fill(dtNcm_cst);
        //            theConnection.Close();
        //        }
        //        catch
        //        {
        //            //MessageBox.Show("Erro ao ler arquivo");

        //        }
        //    }
        //    //try
        //    //{
        //    //    OleDbConnection theConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;data source='c:\\evolucao\\excel\\ncm_cst_antigo.xls';Extended Properties=\"Excel 12.0 Xml;HDR=Yes;IMEX=1;\"");
        //    //    theConnection.Open();
        //    //    OleDbDataAdapter theDataAdapter = new OleDbDataAdapter("SELECT * FROM [ncm$]", theConnection);
        //    //    DataSet theDS = new DataSet();
        //    //    theDataAdapter.Fill(dtNcm_cst);
        //    //    theConnection.Close();
        //    //}
        //    //catch (Exception ex)
        //    //{
        //    //    OleDbConnection theConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;data source='c:\\evolucao\\excel\\ncm_cst.xlsx';Extended Properties=\"Excel 12.0 Xml;HDR=Yes;IMEX=1;\"");
        //    //    theConnection.Open();
        //    //    OleDbDataAdapter theDataAdapter = new OleDbDataAdapter("SELECT * FROM [ncm$]", theConnection);
        //    //    DataSet theDS = new DataSet();
        //    //    theDataAdapter.Fill(dtNcm_cst);
        //    //    theConnection.Close();
        //    //}
        //}

        DataTable dtNcm_cst = new DataTable();
        private void form_pedidos_Load(object sender, EventArgs e)
        {


            detectar_dados_empresa(out razao_social_empresa, out nome_fantasia_empresa, out cnpj_empresa, out ie_empresa, out im_empresa, out cnae_empresa, out endereco_empresa, out n_endereco_empresa,
      out complemento_empresa, out bairro_empresa, out cidade_empresa, out estado_empresa, out cep_empresa, out telefone_empresa, out cod_cidade_empresa, out pais_empresa,
      out cod_pais_empresa, out licenca_dll_nfe_empresa, out nome_certificado_nfe_empresa, out assunto_nfe_email_empresa, out smtp_nfe_empresa, out email_nfe_empresa,
      out senha_email_nfe_empresa, out logotipo_empresa, out proxy_empresa, out usuario_proxy_empresa, out senha_proxy_empresa, out crt_empresa, out portaEmailEmpresa, out sslEmpresa, out serie_empresa,
      out boleto_pedido_empresa, out cliente_inadimplente_empresa);
            buscar_ncm_cst();
            buscar_dados_bancarios();
            if (razao_social_empresa.Contains("IMPÉRIO"))
            {
                tb_ncm.Visible = true;
                lblNCM.Visible = true;
                tb_descricao_item.Visible = true;
                label14.Visible = true;
                label14.Text = "Ferramenta";
                label12.Text = "Descrição do Item";
            }
            try
            {
                CodigoBanco = Convert.ToInt16(_cod_banco);
            }
            catch { }

            // if (boleto_pedido_empresa == "1")
            //    panel_cobranca.Visible = true;

            if (abrir == true)
            {
                localizar_pedido(cod_a_abrir);
            }

            if (fechar == true)
            {
                fechar_pedido();
                salvar();
                this.Close();
            }

            if (imprimir_direto == true)
            {
                imprimir(false);
                this.Close();

            }
            try
            {

                tb_time_correto.Text = Convert.ToDateTime(tb_time_correto.Text).ToShortTimeString();
            }
            catch { }
            #region Codigo Exclusivo Artesanal Doces
            if (form_principal.cnpjArtesanal == "04379165000177")
            {
                labelTitulo.Text = "Orçamento";
                labelNPedidos.Text = "N.º do orçamento:";
                labelDataPedido.Text = "Data Orç.";
                this.Text = "Orçamento";

            }
            #endregion

            try
            {
                if (novo_pedido)
                {
                    criar_item();
                    buscar_orcamento(n_orc);
                    bool ok = false;
                }
            }
            catch { }

        }

        private void buscar_orcamento(int n_orc)
        {
            form_orcamentos orc = new form_orcamentos(cnpj_empresa);
            try
            {
                if (n_orc == 0)
                {
                    orc.selecao_ped = true;
                    orc.ShowDialog();
                }
                else
                {
                    orc.numero_orcamento = 1;
                    orc.orcamentos_selecionados[0] = n_orc.ToString();
                }
            }
            finally
            {

                for (int i = 0; i < orc.numero_orcamento; i++)
                {
                    try
                    {
                        FbCommand comando = new FbCommand();
                        comando.Connection = fbConnection1;
                        comando.CommandText =
                            "SELECT * FROM ORCAMENTOS WHERE COD_ORCAMENTO = '" + n_orc + "'";
                        DataSet orcamento = new DataSet();
                        fbConnection1.Open();
                        datOrcamentos.SelectCommand = comando;
                        datOrcamentos.Fill(orcamento);
                        string _cliente = "";
                        string _cnpj = "";
                        string _observacoes = "";
                        double _valor_total = 0;
                        double _valor_outras_despesas = 0;
                        double _valor_mat_prima = 0;
                        double _valor_impostos = 0;
                        double _valor_outros = 0;
                        tb_n_orcamento.Text = n_orc.ToString();

                        foreach (DataRow dr in orcamento.Tables[0].Rows)
                        {

                            _cliente = dr["CLIENTE_ORCAMENTO"].ToString();
                            _cnpj = dr["CNPJ_CLIENTE_ORCAMENTO"].ToString();
                            try
                            {
                                _observacoes = dr["OBS_ORCAMENTO"].ToString();
                            }
                            catch
                            { }
                            try
                            {
                                _valor_mat_prima = Convert.ToDouble(dr["VALORES_IMPOSTOS_ORCAMENTOS"].ToString());
                            }
                            catch
                            {
                                _valor_mat_prima = 0;
                            }
                            try
                            {
                                _valor_impostos = Convert.ToDouble(dr["VALOR_MAT_PRI_ORCAMENTO"].ToString());
                            }
                            catch
                            {
                                _valor_impostos = 0;
                            }
                            try
                            {
                                _valor_outros = Convert.ToDouble(dr["VALOR_OUTROS_SERV"].ToString());
                            }
                            catch
                            {
                                _valor_outros = 0;
                            }

                            //try
                            //{
                            //    try
                            //    {
                            //        _valor_outras_despesas = _valor_mat_prima + _valor_impostos + _valor_outros;
                            //    }
                            //    catch { }
                            //    if (_valor_outras_despesas > 0)
                            //    {
                            //        _valor_total = Convert.ToDouble(dr["VALOR_TOTAL_ORCAMENTO"].ToString()) + _valor_outras_despesas;
                            //    }
                            //    else
                            //    {
                            //        _valor_total = Convert.ToDouble(dr["VALOR_TOTAL_ORCAMENTO"].ToString());
                            //    }
                            //}
                            //catch { }
                        }
                        fbConnection1.Close();
                        tb_cnpj_cliente.Text = _cnpj;
                        tb_cliente.Text = _cliente;

                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.ToString());
                        fbConnection1.Close();
                    }

                    try
                    {
                        FbCommand comand = new FbCommand();
                        comand.Connection = fbConnection1;
                        comand.CommandText =
                            "SELECT * FROM ITENS_ORCAMENTO io" +
                            " INNER JOIN ORCAMENTOS o ON io.COD_ORCAMENTO_ITEM_ORC = o.COD_ORCAMENTO " +
                            " WHERE io.COD_ORCAMENTO_ITEM_ORC = '" + orc.orcamentos_selecionados[i] + "'" +
                            " AND io.STATUS_ITEM_ORC = 'APROVADO'";
                        DataSet itens = new DataSet();
                        fbConnection1.Open();
                        datItens_orcamento.SelectCommand = comand;
                        datItens_orcamento.Fill(itens);
                        fbConnection1.Close();
                        string[] _cod = new string[200];
                        string[] _descricao = new string[200];
                        string[] _ferramenta = new string[200];
                        string[] _unidade = new string[200];
                        string[] _qtde = new string[200];
                        string[] _valor_unit = new string[200];
                        string[] _qtde_item_orc = new string[200];
                        string[] _orcamento = new string[200];
                        string[] _item_orcamento = new string[200];
                        string[] _prazo_entrega_orcamento = new string[200];
                        string[] _ncm = new string[200];
                        string[] _outras_despesas = new string[200]; ;


                        int k = 0;
                        foreach (DataRow dr in itens.Tables[0].Rows)
                        {

                            _descricao[k] = dr["NOME_ITEM_ORC"].ToString();
                            _ferramenta[k] = dr["FERRAMENTA_ORCAMENTO"].ToString();
                            _qtde_item_orc[k] = dr["QTDE_ITEM_ORC"].ToString();
                            _valor_unit[k] = dr["VALOR_UNIT_ITEM_ORC"].ToString();
                            _prazo_entrega_orcamento[k] = dr["PRAZO_ENTREGA_ITEM_ORC"].ToString();
                            _ncm[k] = dr["NCM_ITEM_ORC"].ToString();
                            _outras_despesas[k] = dr["VALOR_OUTROS_SERV"].ToString();
                            k++;
                        }

                        for (int j = 0; j < k; j++)
                        {
                            tb_descricao_produto.Text = _descricao[j];
                            tb_descricao_item.Text = _ferramenta[j];
                            tb_unid_item.Text = "PC";
                            tb_qtde_item.Text = _qtde_item_orc[j];
                            tb_preco_unit_item.Text = _valor_unit[j];
                            tb_data_entrega.Text = _prazo_entrega_orcamento[j];
                            tb_ncm.Text = _ncm[j];
                            //tb_outros_valores.Text = _outras_despesas[j];

                            double valor_total_item = 0;

                            try
                            {
                                valor_total_item = Convert.ToDouble(tb_qtde_item.Text) * Convert.ToDouble(tb_preco_unit_item.Text);

                            }
                            catch { }


                            if (tb_descricao_produto.Text != "")
                            {

                                string cod_item = "", valor_total = valor_total_item.ToString(), ncm_item = tb_ncm.Text, descricao_item = tb_descricao_produto.Text, unid_item = tb_unid_item.Text, qtde_item = tb_qtde_item.Text, valor_unit_item = tb_preco_unit_item.Text;
                                cod_item = tb_cod_fornecedor.Text;
                                string ferramenta_item = tb_descricao_item.Text;
                                if (cod_item == "")
                                    cod_item = "null";
                                else
                                    cod_item = "'" + cod_item + "'";
                                valor_unit_item = tb_preco_unit_item.Text;
                                if (valor_unit_item == "")
                                    valor_unit_item = "null";
                                else
                                    valor_unit_item = "'" + valor_unit_item.Replace(".", "").Replace(",", ".") + "'";
                                //valor_unit_item = tb_preco_unit_item.Text;
                                if (valor_total == "")
                                    valor_total = "null";
                                else
                                    valor_total = "'" + valor_total.Replace(".", "").Replace(",", ".") + "'";
                                qtde_item = tb_qtde_item.Text;
                                if (qtde_item == "")
                                    qtde_item = "null";
                                else
                                    qtde_item = "'" + qtde_item.Replace(",", ".") + "'";
                                descricao_item = tb_descricao_produto.Text;
                                if (descricao_item == "")
                                    descricao_item = "null";
                                else
                                    descricao_item = "'" + descricao_item + "'";
                                if (ferramenta_item == "")
                                    ferramenta_item = "null";
                                else
                                    ferramenta_item = "'" + ferramenta_item + "'";

                                unid_item = tb_unid_item.Text;
                                if (unid_item == "")
                                    unid_item = "null";
                                else
                                    unid_item = "'" + unid_item + "'";
                                if (ncm_item == "")
                                    ncm_item = "00000000";
                                else
                                    ncm_item = "'" + ncm_item + "'";
                                string data_entrega = "null";
                                if (tb_data_entrega.Text != "")
                                {
                                    try
                                    {
                                        data_entrega = "'" + Convert.ToDateTime(tb_data_entrega.Text).ToShortDateString().Replace("/", ".") + "'";
                                    }
                                    catch { data_entrega = "null"; }
                                }
                                else
                                {
                                    tb_data_entrega.Text = "null";
                                }
                                try
                                {

                                    //cadastrar_produto(out cod_forn);
                                }
                                catch { }
                                // try
                                // {
                                //     this.datPedidos_venda.InsertCommand.CommandText =
                                //"INSERT INTO PEDIDOS_VENDA (COD_ORCAMENTO_PED_VENDA) " +
                                //"VALUES (" + n_orc + ")";
                                //     this.fbConnection1.Open();
                                //     this.datPedidos_venda.InsertCommand.Connection = fbConnection1;
                                //     this.datPedidos_venda.InsertCommand.ExecuteNonQuery();
                                //     this.fbConnection1.Close();
                                // }
                                // catch { }

                                FbCommand insert = new FbCommand();
                                insert.Connection = fbConnection1;
                                insert.CommandText = @"INSERT INTO PRODUTOS (DESCRICAO_PRODUTO, DESCRICAO_ITEM_PRODUTO,  
                                                                ST_SAIDA_PRODUTO, ALIQUOTA_ICMS_PRODUTO, REDUCAO_ICMS_PRODUTO, 
                                                                ESTOQUE_ATUAL_PRODUTO, ESTOQUE_MEDIO_PRODUTO, NCM_PRODUTO, COD_UNIDADE_PRODUTO, DESCRICAO_UNIDADE_PRODUTO) 
                                                                VALUES (" + descricao_item + ", " + ferramenta_item + "," +
                                                     "101,0,0,0,0, " + ncm_item + ", 'PC', 'PC') RETURNING COD_PRODUTO";
                                fbConnection1.Open();
                                FbDataAdapter datInsert = new FbDataAdapter();
                                datInsert.InsertCommand = insert;
                                object cod_produto = datInsert.InsertCommand.ExecuteScalar();
                                fbConnection1.Close();




                                FbCommand update = new FbCommand();
                                update.Connection = fbConnection1;
                                fbConnection1.Open();
                                update.CommandText =
                                    "UPDATE PRODUTOS SET COD_FORNECEDOR_PRODUTO = '" + cod_produto.ToString() + "',  COD_BARRAS_CAIXA_PRODUTO = '" + cod_produto.ToString() + "', COD_BARRAS_PRODUTO = '" + cod_produto.ToString() + "', STATUS_PRODUTO = 1 " +
                                    " WHERE COD_PRODUTO = '" + cod_produto + "' ";
                                FbDataAdapter datUpdate = new FbDataAdapter();
                                datUpdate.UpdateCommand = update;
                                datUpdate.UpdateCommand.ExecuteNonQuery();
                                fbConnection1.Close();

                                //FbCommand ativo = new FbCommand();
                                //ativo.Connection = fbConnection1;
                                //fbConnection1.Open();
                                //update.CommandText =
                                //    "UPDATE PRODUTOS SET STATUS_PRODUTO = 1 " +
                                //    "WHERE COD_PRODUTO = '" + cod_produto + "' ";
                                //FbDataAdapter datAtivo = new FbDataAdapter();
                                //datAtivo.UpdateCommand = ativo;
                                //datAtivo.UpdateCommand.ExecuteNonQuery();
                                //fbConnection1.Close();

                                try
                                {
                                    this.datItens_ped_venda.InsertCommand.CommandText =
                               "INSERT INTO ITENS_PEDIDO_VENDA (DESCRICAO_PROD_ITEM_VENDA, UNIDADE_PROD_ITEM_VENDA, QTDE_ITEM_VENDA, VALOR_UNIT_PROD_ITEM_VENDA, " +
                               "VALOR_TOTAL_PROD_ITEM_VENDA, DATA_PEDIDO_ITEM_VENDA, COD_PEDIDO_ITEM_VENDA, COD_SISTEMA_PROD_ITEM_VENDA, COD_PROD_ITEM_VENDA, NCM_ITEM_VENDA, DATA_ENTREGA_ITEM_VENDA, DESCRICAO_ITEM_PROD_ITEM_VENDA) " +
                               "VALUES (" + descricao_item + "," + unid_item + "," + qtde_item + "," + valor_unit_item + "," + valor_total + ",'" +
                               Convert.ToDateTime(tb_data_pedido.Text).ToShortDateString().Replace("/", ".") + "'," + tb_n_pedido.Text + ", " + cod_produto + ", " + cod_produto + ", " + ncm_item + ", " + data_entrega + ", " + ferramenta_item + ")";
                                    this.fbConnection1.Open();
                                    this.datItens_ped_venda.InsertCommand.Connection = fbConnection1;
                                    this.datItens_ped_venda.InsertCommand.ExecuteNonQuery();
                                    this.fbConnection1.Close();
                                }
                                catch (Exception e)
                                {
                                    MessageBox.Show(e.ToString());
                                    fbConnection1.Close();
                                }

                                try
                                {
                                    dsItens_ped_venda.Clear();
                                    this.datItens_ped_venda.SelectCommand.CommandText =
                                    "SELECT * FROM ITENS_PEDIDO_VENDA WHERE COD_PEDIDO_ITEM_VENDA = '" + tb_n_pedido.Text + "'";
                                    this.fbConnection1.Open();
                                    this.datItens_ped_venda.SelectCommand.Connection = fbConnection1;
                                    this.datItens_ped_venda.SelectCommand.ExecuteNonQuery();
                                    datItens_ped_venda.Fill(ITENS_PEDIDO_VENDA);
                                    this.fbConnection1.Close();
                                    limpar();
                                    colocar_numero_nos_itens();
                                    calcular();

                                }
                                catch (Exception e)
                                {
                                    MessageBox.Show(e.ToString());
                                    fbConnection1.Close();
                                }

                                try
                                {

                                    //  cod_forn = cadastrar_produto();
                                }
                                catch { }

                                // try
                                // {
                                //     this.datItens_ped_venda.InsertCommand.CommandText =
                                //"INSERT INTO ITENS_PEDIDO_VENDA (COD_PROD_ITEM_VENDA) " +
                                //"VALUES (" + cod_forn + ")";
                                //     this.fbConnection1.Open();
                                //     this.datItens_ped_venda.InsertCommand.Connection = fbConnection1;
                                //     this.datItens_ped_venda.InsertCommand.ExecuteNonQuery();
                                //     this.fbConnection1.Close();
                                // }
                                // catch (Exception e)
                                // {
                                //     MessageBox.Show(e.ToString());
                                //     fbConnection1.Close();
                                // }


                                try
                                {
                                    classeEstoque estoque = new classeEstoque();
                                    estoque.fbConnection1.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=10.3.3.4;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=True;Packet Size=8192;Server Type=0";
                                    estoque.calcular_estoque(cod_item.Replace("'", ""));
                                }
                                catch { }

                                //try
                                //{
                                //    dsPedidos_venda.Clear();
                                //    this.datPedidos_venda.SelectCommand.CommandText =
                                //    "SELECT * FROM PEDIDOS_VENDA WHERE COD_ORCAMENTO_PED_VENDA = " + n_orc;
                                //    this.fbConnection1.Open();
                                //    this.datPedidos_venda.SelectCommand.Connection = fbConnection1;
                                //    this.datPedidos_venda.SelectCommand.ExecuteNonQuery();
                                //    datPedidos_venda.Fill(PEDIDOS_VENDA);
                                //    this.fbConnection1.Close();
                                //}
                                //catch { }
                            }


                        }
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.ToString());
                        fbConnection1.Close();
                    }
                }
            }
        }



        private void cadastrar_produto()
        {
            //            int produto_atual = 0;
            //            for (int i = 0; i < dgvItens_nota.RowCount; i++)
            //            {
            //                try
            //                {
            //                    int encontrada = 0;
            //                     produto_atual = buscar_ultimo_produto(out encontrada);
            //                    produto_atual++;
            //                    string descricao_produto, ncm;
            //                    descricao_produto = dgvItens_nota.Rows[i].Cells["col_descricao"].Value.ToString();
            //                    ncm = "00000000";
            //                    FbCommand insert = new FbCommand();
            //                    insert.Connection = fbConnection1;
            //                    insert.CommandText = @"INSERT INTO PRODUTOS (COD_PRODUTO, COD_FORNECEDOR_PRODUTO, DESCRICAO_PRODUTO, 
            //                                                                NCM_PRODUTO, COD_BARRAS_PRODUTO, COD_BARRAS_CAIXA_PRODUTO, ST_SAIDA_PRODUTO, ALIQUOTA_ICMS_PRODUTO, REDUCAO_ICMS_PRODUTO, 
            //                                                                ESTOQUE_ATUAL_PRODUTO, ESTOQUE_MEDIO_PRODUTO) 
            //                                                                VALUES ('" + produto_atual + "','" + produto_atual + "','" + descricao_produto + "','" +
            //                                        ncm + "','" + produto_atual + "','" + produto_atual + "', 101,0,0,0,0)";
            //                    fbConnection1.Open();
            //                    FbDataAdapter datInsert = new FbDataAdapter();
            //                    datInsert.InsertCommand = insert;
            //                    datInsert.InsertCommand.ExecuteNonQuery();
            //                    fbConnection1.Close();
            //                    return produto_atual;
            //                }
            //                catch (Exception e)
            //                {
            //                    MessageBox.Show(e.ToString());
            //                    fbConnection1.Close();
            //                    return produto_atual;
            //                }

            //                //return produto_atual;
            //            }

            //            return produto_atual;
        }

        private void buscar_ultimo_produto()//out int encontrada)
        {
            //encontrada = 0;
            //try
            //{
            //    FbCommand comando = new FbCommand();
            //    comando.Connection = fbConnection1;
            //    comando.CommandText =
            //        "SELECT first(1) COD_PRODUTO FROM PRODUTOS ORDER BY COD_PRODUTO DESC";
            //    DataSet produto = new DataSet();
            //    fbConnection1.Open();
            //    datProdutos.SelectCommand = comando;
            //    datProdutos.Fill(produto);

            //    if (produto.Tables[0].Rows.Count > 0)
            //    {
            //        DataRow dr = produto.Tables[0].Rows[0];
            //        encontrada = Convert.ToInt32(dr[0].ToString());
            //    }
            //    else
            //    { encontrada = 1; }
            //    fbConnection1.Close();
            //    return encontrada;
            //}
            //catch (Exception a)
            //{
            //    MessageBox.Show(a.ToString());
            //    fbConnection1.Close();
            //    return encontrada;
            //}
        }

        private void limpar()
        {
            tb_descricao_produto.Text = "";
            tb_unid_item.Text = "";
            tb_qtde_item.Text = "";
            tb_preco_unit_item.Text = "";
            tb_data_entrega.Text = "";
            tb_ncm.Text = "";
            tb_descricao_item.Text = "";
        }

        private void selecionar_orcamento()
        {
            throw new NotImplementedException();
        }

        private void buscar_dados_bancarios()
        {
            _cod_banco = ""; _agencia = ""; _dig_agencia = "";
            _cc = ""; _dig_cc = "";
            _carteira = ""; _multa = "";
            _mora = ""; _dias_protesto = "";
            _codigo_no_banco = ""; _cod_transmissao = "";

            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                select.CommandText =
                    "SELECT * FROM CONTAS_CORRENTES WHERE BOLETO_CC = '1'";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();
                foreach (DataRow dr in dtSelect.Rows)
                {
                    _cod_banco = dr["CODIGO_BANCO_CC"].ToString();
                    _agencia = dr["AGENCIA_CC"].ToString();
                    _dig_agencia = dr["DIG_AGENCIA_CC"].ToString();
                    _cc = dr["CONTA_CC"].ToString();
                    _dig_cc = dr["DIG_CONTA_CC"].ToString();
                    _multa = dr["MULTA_CC"].ToString();
                    _mora = dr["MORA_DIA_CC"].ToString();
                    _dias_protesto = dr["DIAS_PROTESTO_CC"].ToString();
                    _carteira = dr["CARTEIRA_CC"].ToString();
                    _codigo_no_banco = dr["CODIGO_NO_BANCO_CC"].ToString();
                    _cod_transmissao = dr["COD_TRANSMISSAO"].ToString();
                }

            }
            catch { fbConnection1.Close(); }
        }
        private bool verificarDuplicidadeItemPedido()
        {
            for (int i = 0; i < dgvItens_nota.RowCount; i++)
            {
                if (tb_cod_sistema.Text == dgvItens_nota.Rows[i].Cells["col_cod"].Value.ToString())
                {
                    return true;
                }
            }
            return false;
        }
        private bool verificarDuplicidadeItemPedidoCompleto()
        {
            return false;
            //int duplicados = 0;
            //for (int i = 0; i < dgvItens_nota.RowCount; i++)
            //{
            //    for (int j = i + 1; j < dgvItens_nota.RowCount; j++)
            //    {
            //        if (j < dgvItens_nota.RowCount)
            //        {
            //            if (dgvItens_nota.Rows[i].Cells["col_cod"].Value.ToString() == dgvItens_nota.Rows[j].Cells["col_cod"].Value.ToString())
            //            {
            //                dgvItens_nota.Rows[i].DefaultCellStyle.BackColor = Color.Red;
            //                dgvItens_nota.Rows[j].DefaultCellStyle.BackColor = Color.Red;
            //                duplicados++;
            //            }
            //        }
            //    }
            //}
            //if (duplicados > 0) return true;
            //else return false;
        }

        private void buscar_informacoes_produto(string cod_peca, out string _origem, out string _cst,
          out string _modalidade, out string _icms, out string _icms_st, out string _reducao, out string _reducao_st,
          out string _iva, out string _ipi, out string _pis, out string _cofins, out string _iss,
          out string _crt, out string _aliquota_credito, out string _modalidade_st, out string _bc_com_ipi,
          out string _ipi_tributado, out string _ipi_n_tributado, out string _cst_ipi_tributado,
          out string _cst_ipi_n_tributado, out string _tipo_pis, out string _cst_pis, out string _tipo_cofins,
          out string _cst_cofins, out string _pCredICMS, out string _preco_minimo, out string _custo,
          out string cfop_produto, out string cest_produto, string tipo, string estado, string ncm)
        {
            _cst = ""; _origem = ""; _modalidade = ""; _icms = ""; _icms_st = ""; _reducao = ""; _reducao_st = ""; _iva = ""; _ipi = "";
            _pis = ""; _cofins = ""; _iss = ""; _crt = ""; _aliquota_credito = ""; _modalidade_st = ""; _bc_com_ipi = "";
            _ipi_tributado = ""; _ipi_n_tributado = ""; _cst_ipi_tributado = ""; _cst_ipi_n_tributado = "";
            _tipo_pis = ""; _cst_pis = ""; _tipo_cofins = ""; _cst_cofins = ""; _pCredICMS = ""; _preco_minimo = ""; _custo = "";
            cfop_produto = ""; cest_produto = "";
            try
            {

                bool ncm_encontrado = false;
                string tipo_cliente = tipo;

                if (tipo == "Industrialização")
                {
                    tipo = "Mao de obra";
                }
                if (tipo == "Atacadista")
                    tipo = "Revenda";
                foreach (DataRow dr_ncm in dtNcm_cst.Select("Convert(NCM, 'System.String') like '%" + ncm + "%' AND ESTADO like '" +
                    estado + "' AND Tipo like '" + tipo + "' AND Convert(CNPJ, 'System.String') = '" + cnpj_empresa + "'"))
                {
                    if (dr_ncm["CST_ICMS"].ToString() == "")
                        break;
                    else
                    {
                        try
                        {
                            /* icms */
                            ncm_encontrado = true;


                            cfop_produto = dr_ncm["CFOP"].ToString();
                            _cst = dr_ncm["CST_ICMS"].ToString();

                            _icms = dr_ncm["ICMS"].ToString();
                            _icms_st = dr_ncm["ICMS_ST"].ToString();

                            _reducao = dr_ncm["REDUÇÃO"].ToString();
                            _reducao_st = dr_ncm["REDUÇÃO_ST"].ToString();
                            _iva = dr_ncm["MVA"].ToString();

                            /* pis cofins */
                            _pis = "0,00"; _cofins = "0,00";
                            _ipi = "0,00";
                            try
                            {
                                try
                                {
                                    _ipi = Convert.ToDouble(dr_ncm["IPI"].ToString()).ToString();
                                }
                                catch { };
                                if (dr_ncm["CST_IPI"].ToString().Substring(0, 2) != "50")
                                {
                                    _cst_ipi_n_tributado = dr_ncm["CST_IPI"].ToString();
                                    _ipi_tributado = "0";
                                    _ipi_n_tributado = "1";
                                }
                                else
                                {
                                    _cst_ipi_tributado = dr_ncm["CST_IPI"].ToString();
                                    _ipi_tributado = "1";
                                    _ipi_n_tributado = "0";
                                }
                            }
                            catch
                            {
                                _cst_ipi_n_tributado = "53";
                                _ipi_tributado = "0";
                                _ipi_n_tributado = "1";
                            }
                            try
                            {
                                _pis = Convert.ToDouble(dr_ncm["PIS"].ToString()).ToString();
                                _cofins = Convert.ToDouble(dr_ncm["COFINS"].ToString()).ToString();


                            }
                            catch { }

                            if (dr_ncm["CST_COFINS"].ToString() != "")
                            {
                                _cst_cofins = dr_ncm["CST_COFINS"].ToString();
                            }
                            if (dr_ncm["CST_PIS"].ToString() != "")
                            {
                                _cst_pis = dr_ncm["CST_PIS"].ToString();
                            }
                            if (dr_ncm["TIPO_COFINS"].ToString() != "")
                            {
                                _tipo_cofins = dr_ncm["TIPO_COFINS"].ToString();
                            }
                            if (dr_ncm["TIPO_PIS"].ToString() != "")
                            {
                                _tipo_pis = dr_ncm["TIPO_PIS"].ToString();
                            }
                        }
                        catch { }
                    }
                }
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        //private void buscar_informacoes_produto(string cod_peca, out string _origem, out string _cst,
        //   out string _modalidade, out string _icms, out string _icms_st, out string _reducao, out string _reducao_st,
        //   out string _iva, out string _ipi, out string _pis, out string _cofins, out string _iss,
        //   out string _crt, out string _aliquota_credito, out string _modalidade_st, out string _bc_com_ipi,
        //   out string _ipi_tributado, out string _ipi_n_tributado, out string _cst_ipi_tributado,
        //   out string _cst_ipi_n_tributado, out string _tipo_pis, out string _cst_pis, out string _tipo_cofins,
        //   out string _cst_cofins, out string _pCredICMS, out string _preco_minimo, out string _custo, 
        //   out string cfop_produto, out string cest_produto, string tipo, string estado)
        //{
        //    _cst = ""; _origem = ""; _modalidade = ""; _icms = ""; _icms_st = ""; _reducao = ""; _reducao_st = ""; _iva = ""; _ipi = "";
        //    _pis = ""; _cofins = ""; _iss = ""; _crt = ""; _aliquota_credito = ""; _modalidade_st = ""; _bc_com_ipi = "";
        //    _ipi_tributado = ""; _ipi_n_tributado = ""; _cst_ipi_tributado = ""; _cst_ipi_n_tributado = "";
        //    _tipo_pis = ""; _cst_pis = ""; _tipo_cofins = ""; _cst_cofins = ""; _pCredICMS = ""; _preco_minimo = ""; _custo = ""; cfop_produto = ""; cest_produto = "";
        //    try
        //    {
        //        //SE NÃO TIVER INFORMAÇÃO NO PRODUTO PEGARÁ A INFORMAÇÃO PADRÃO
        //        buscar_informacoes_padrao(out _origem, out _cst, out _modalidade, out _icms,
        //                    out _icms_st, out _reducao, out _reducao_st, out _iva, out _ipi, out _pis, out _cofins,
        //                    out _iss, out _crt, out _aliquota_credito, out _modalidade_st, out _bc_com_ipi,
        //                    out _ipi_tributado, out _ipi_n_tributado, out _cst_ipi_tributado,
        //                    out _cst_ipi_n_tributado, out _tipo_pis, out _cst_pis, out _tipo_cofins, out _cst_cofins, out _pCredICMS);

        //        FbCommand select = new FbCommand();
        //        select.Connection = fbConnection1;
        //        select.CommandText =
        //            "SELECT * FROM PRODUTOS WHERE COD_PRODUTO = '" + cod_peca + "'";
        //        fbConnection1.Open();
        //        FbDataAdapter produtosDataAdapter = new FbDataAdapter();
        //        produtosDataAdapter.SelectCommand = select;
        //        DataSet produtosDataSet = new DataSet();
        //        produtosDataAdapter.Fill(produtosDataSet);
        //        fbConnection1.Close();
        //        foreach (DataRow dr in produtosDataSet.Tables[0].Rows)
        //        {

        //            try
        //            {
        //                _preco_minimo = dr["VALOR_PROMOCAO_PRODUTO"].ToString();
        //            }
        //            catch { }
        //            try
        //            {
        //                _custo = dr["CUSTO_PRODUTO"].ToString();
        //            }
        //            catch { }
        //            try
        //            {
        //                cest_produto = dr["CEST_PRODUTO"].ToString();
        //            }
        //            catch { }

        //            bool ncm_encontrado = false;

        //            string tipo_cliente = cbTipo.Text;// buscar_tipo_pedido(dgvPedidos.Rows[0].Cells["col_pedido"].Value.ToString());// buscar_tipo_cliente(tb_cnpj_cliente.Text);

        //            if (tipo_cliente == "")
        //            {
        //                MessageBox.Show("Por favor, selecione o tipo de pedido antes de faturar");
        //            }
        //            else
        //            {
        //                if (tipo_cliente == "Industrialização")
        //                {
        //                    ncm_encontrado = true;
        //                    cfop_produto = "5124";
        //                    if (estado != "SP")
        //                        cfop_produto = "6124";
        //                    if (crt_empresa == "1")
        //                        _cst = "101";
        //                    else
        //                    { //QUANDO É INDUSTRIALIZAÇÃO
        //                        _cst = "51";
        //                        foreach (DataRow dr_ncm in dtNcm_cst.Select("TIPO = '" + tipo + "' AND NCM = '" + dr["NCM_PRODUTO"].ToString() + "' AND ESTADO = '" + estado + "' AND (CFOP = '5124' OR CFOP = '6124')"))
        //                        {

        //                            if (dr_ncm["CST_ICMS"].ToString() == "")
        //                                break;
        //                            else
        //                            {
        //                                try
        //                                {
        //                                    /* icms */
        //                                    ncm_encontrado = true;


        //                                    cfop_produto = dr_ncm["CFOP"].ToString();
        //                                    _cst = dr_ncm["CST_ICMS"].ToString();

        //                                    _icms = dr_ncm["ICMS"].ToString();
        //                                    _icms_st = dr_ncm["ICMS_ST"].ToString();

        //                                    _reducao = dr_ncm["REDUÇÃO"].ToString();
        //                                    _reducao_st = dr_ncm["REDUÇÃO_ST"].ToString();
        //                                    _iva = dr_ncm["MVA"].ToString();

        //                                    /* pis cofins */
        //                                    _pis = "0,00"; _cofins = "0,00";
        //                                    _ipi = "0,00";
        //                                    try
        //                                    {
        //                                        try
        //                                        {
        //                                            _ipi = Convert.ToDouble(dr_ncm["IPI"].ToString()).ToString();
        //                                        }
        //                                        catch { };
        //                                        if (dr_ncm["CST_IPI"].ToString().Substring(0, 2) != "50")
        //                                        {
        //                                            _cst_ipi_n_tributado = dr_ncm["CST_IPI"].ToString();
        //                                            _ipi_tributado = "0";
        //                                            _ipi_n_tributado = "1";
        //                                        }
        //                                        else
        //                                        {
        //                                            _cst_ipi_tributado = dr_ncm["CST_IPI"].ToString();
        //                                            _ipi_tributado = "1";
        //                                            _ipi_n_tributado = "0";
        //                                        }
        //                                    }
        //                                    catch
        //                                    {
        //                                        _cst_ipi_n_tributado = "53";
        //                                        _ipi_tributado = "0";
        //                                        _ipi_n_tributado = "1";
        //                                    }
        //                                    try
        //                                    {
        //                                        _pis = Convert.ToDouble(dr_ncm["PIS"].ToString()).ToString();
        //                                        _cofins = Convert.ToDouble(dr_ncm["COFINS"].ToString()).ToString();


        //                                    }
        //                                    catch { }

        //                                    if (dr_ncm["CST_COFINS"].ToString() != "")
        //                                    {
        //                                        _cst_cofins = dr_ncm["CST_COFINS"].ToString();
        //                                    }
        //                                    if (dr_ncm["CST_PIS"].ToString() != "")
        //                                    {
        //                                        _cst_pis = dr_ncm["CST_PIS"].ToString();
        //                                    }
        //                                    if (dr_ncm["TIPO_COFINS"].ToString() != "")
        //                                    {
        //                                        _tipo_cofins = dr_ncm["TIPO_COFINS"].ToString();
        //                                    }
        //                                    if (dr_ncm["TIPO_PIS"].ToString() != "")
        //                                    {
        //                                        _tipo_pis = dr_ncm["TIPO_PIS"].ToString();
        //                                    }
        //                                }
        //                                catch { }
        //                                //try
        //                                //{
        //                                //    /* icms */
        //                                //    ncm_encontrado = true;
        //                                //    cfop_produto = dr_ncm["CFOP"].ToString();
        //                                //    _cst = dr_ncm["CST ICMS"].ToString();
        //                                //    _icms = dr_ncm["ICMS"].ToString();
        //                                //    _icms_st = dr_ncm["ICMS_ST"].ToString();
        //                                //    _reducao = dr_ncm["REDUÇÃO"].ToString();
        //                                //    _reducao_st = dr_ncm["REDUÇÃO ST"].ToString();
        //                                //    _iva = dr_ncm["MVA"].ToString();
        //                                //    /* pis cofins */
        //                                //    _pis = "0,00"; _cofins = "0,00";
        //                                //    _ipi = "0,00";
        //                                //    try
        //                                //    {
        //                                //        _ipi = Convert.ToDouble(dr_ncm["IPI"].ToString()).ToString();
        //                                //        if (_ipi == "0")
        //                                //        {
        //                                //            _ipi_tributado = "0";
        //                                //            _ipi_n_tributado = "1";
        //                                //        }
        //                                //        else
        //                                //        {
        //                                //            _ipi_tributado = "1";
        //                                //            _ipi_n_tributado = "0";
        //                                //        }
        //                                //    }
        //                                //    catch
        //                                //    {
        //                                //        _ipi_tributado = "0";
        //                                //        _ipi_n_tributado = "1";
        //                                //    }
        //                                //    try
        //                                //    {
        //                                //        _pis = Convert.ToDouble(dr_ncm["PIS"].ToString()).ToString();
        //                                //        _cofins = Convert.ToDouble(dr_ncm["COFINS"].ToString()).ToString();


        //                                //    }
        //                                //    catch { }

        //                                //    if (dr_ncm["CST_COFINS"].ToString() != "")
        //                                //    {
        //                                //        _cst_cofins = dr_ncm["CST_COFINS"].ToString();
        //                                //    }
        //                                //    if (dr_ncm["CST_PIS"].ToString() != "")
        //                                //    {
        //                                //        _cst_pis = dr_ncm["CST_PIS"].ToString();
        //                                //    }
        //                                //    if (dr_ncm["TIPO_COFINS"].ToString() != "")
        //                                //    {
        //                                //        _tipo_cofins = dr_ncm["TIPO_COFINS"].ToString();
        //                                //    }
        //                                //    if (dr_ncm["TIPO_PIS"].ToString() != "")
        //                                //    {
        //                                //        _tipo_pis = dr_ncm["TIPO_PIS"].ToString();
        //                                //    }
        //                                //}
        //                                //catch { }
        //                            }
        //                        }
        //                    }
        //                }
        //                else if (tipo_cliente == "CONSUMO")
        //                {
        //                    ncm_encontrado = true;
        //                    cfop_produto = "5101";
        //                    if (estado != "SP")
        //                        cfop_produto = "6101";
        //                    if (crt_empresa == "1")
        //                        _cst = "102";
        //                    else
        //                        _cst = "00";
        //                }
        //                else if (tipo_cliente == "Vendas")
        //                {
        //                    foreach (DataRow dr_ncm in dtNcm_cst.Select("NCM = '" + dr["NCM_PRODUTO"].ToString() + "' AND ESTADO = '" +
        //                        estado + "' AND (CFOP = '5101' OR CFOP = '5401' OR CFOP = '6101' OR CFOP = '6401')"))
        //                    {

        //                        if (dr_ncm["CST_ICMS"].ToString() == "")
        //                            break;
        //                        else
        //                        {
        //                            try
        //                            {
        //                                /* icms */
        //                                ncm_encontrado = true;


        //                                cfop_produto = dr_ncm["CFOP"].ToString();
        //                                _cst = dr_ncm["CST_ICMS"].ToString();

        //                                _icms = dr_ncm["ICMS"].ToString();
        //                                _icms_st = dr_ncm["ICMS_ST"].ToString();

        //                                _reducao = dr_ncm["REDUÇÃO"].ToString();
        //                                _reducao_st = dr_ncm["REDUÇÃO_ST"].ToString();
        //                                _iva = dr_ncm["MVA"].ToString();

        //                                /* pis cofins */
        //                                _pis = "0,00"; _cofins = "0,00";
        //                                _ipi = "0,00";
        //                                try
        //                                {
        //                                    try
        //                                    {
        //                                        _ipi = Convert.ToDouble(dr_ncm["IPI"].ToString()).ToString();
        //                                    }
        //                                    catch { };
        //                                    if (dr_ncm["CST_IPI"].ToString().Substring(0, 2) != "50")
        //                                    {
        //                                        _cst_ipi_n_tributado = dr_ncm["CST_IPI"].ToString();
        //                                        _ipi_tributado = "0";
        //                                        _ipi_n_tributado = "1";
        //                                    }
        //                                    else
        //                                    {
        //                                        _cst_ipi_tributado = dr_ncm["CST_IPI"].ToString();
        //                                        _ipi_tributado = "1";
        //                                        _ipi_n_tributado = "0";
        //                                    }
        //                                }
        //                                catch
        //                                {
        //                                    _cst_ipi_n_tributado = "53";
        //                                    _ipi_tributado = "0";
        //                                    _ipi_n_tributado = "1";
        //                                }
        //                                try
        //                                {
        //                                    _pis = Convert.ToDouble(dr_ncm["PIS"].ToString()).ToString();
        //                                    _cofins = Convert.ToDouble(dr_ncm["COFINS"].ToString()).ToString();


        //                                }
        //                                catch { }

        //                                if (dr_ncm["CST_COFINS"].ToString() != "")
        //                                {
        //                                    _cst_cofins = dr_ncm["CST_COFINS"].ToString();
        //                                }
        //                                if (dr_ncm["CST_PIS"].ToString() != "")
        //                                {
        //                                    _cst_pis = dr_ncm["CST_PIS"].ToString();
        //                                }
        //                                if (dr_ncm["TIPO_COFINS"].ToString() != "")
        //                                {
        //                                    _tipo_cofins = dr_ncm["TIPO_COFINS"].ToString();
        //                                }
        //                                if (dr_ncm["TIPO_PIS"].ToString() != "")
        //                                {
        //                                    _tipo_pis = dr_ncm["TIPO_PIS"].ToString();
        //                                }
        //                            }
        //                            catch { }

        //                        }
        //                    }
        //                }
        //                if (!ncm_encontrado)
        //                {
        //                    MessageBox.Show("NCM não encontrado")
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception a)
        //    {
        //        fbConnection1.Close();
        //        MessageBox.Show(a.ToString());
        //    }
        //}
        private void button5_Click(object sender, EventArgs e)
        {
            if (tb_cnpj_cliente.Text == "" || cbTipo.Text == "")
            {
                MessageBox.Show("Selecione o cliente e coloque o tipo do Pedido/Orçamento antes de inserir os itens.");
            }
            else
            {

                string aliq_ipi = "", aliq_icms = "", iva_item = "", perc_red_icms = "", aliq_icms_st = "", st_item = "", cod_item = "", descricao_item = "", unid_item = "", qtde_item = "", qtde_disponivel = "", valor_unit_item = "",
                    valor_total_item = "", ncm_item = "", valor_bc_icms_item = "", valor_bc_ipi_item = "", valor_icms_item = "", valor_ipi_item = "", cod_vendedor = "", custo_produto = "";

                string _origem, _cst, _modalidade, _icms, _icms_st, _reducao, _reducao_st, _iva, _ipi, _pis,
                                  _cofins, _iss, _crt, _aliquota_credito, _modalidade_st, _bc_com_ipi, _ipi_tributado,
                                  _ipi_n_tributado, _cst_ipi_tributado, _cst_ipi_n_tributado, _tipo_pis, _cst_pis,
                                  _tipo_cofins, _cst_cofins, _pCredICMS, _preco_minimo, _custo_produto, _cfop_produto, _cest_produto;

                double icmsCliente = 1, icmsStCliente = 1;
                string estado = buscar_estado_cliente(tb_cnpj_cliente.Text, out icmsCliente, out icmsStCliente);


                buscar_informacoes_produto(tb_cod_sistema.Text, out _origem, out _cst, out _modalidade, out _icms,
                    out _icms_st, out _reducao, out _reducao_st, out _iva, out _ipi, out _pis, out _cofins,
                    out _iss, out _crt, out _aliquota_credito, out _modalidade_st, out _bc_com_ipi,
                    out _ipi_tributado, out _ipi_n_tributado, out _cst_ipi_tributado,
                    out _cst_ipi_n_tributado, out _tipo_pis, out _cst_pis, out _tipo_cofins, out _cst_cofins,
                    out _pCredICMS, out _preco_minimo, out _custo_produto, out _cfop_produto, out _cest_produto, cbTipo.Text, estado, tb_ncm.Text);


                double _valor_total = 0, _bc_icms = 0, _bc_ipi = 0, _red_bc_icms = 0, _valor_ipi = 0, _valor_icms = 0, _valor_st = 0;
                try
                {
                    _valor_total = Convert.ToDouble(tb_preco_unit_item.Text) * Convert.ToDouble(tb_qtde_item.Text);
                }
                catch { }
                //calcular aqui a redução por estado
                _bc_icms = _valor_total;
                _bc_ipi = _valor_total;
                _bc_icms = _valor_total;

                if (icmsCliente == 0)
                {
                    _icms = "0";
                }
                if (icmsStCliente == 0)
                {
                    _icms_st = "0";
                }

                double reducao = 0;
                try { reducao = Convert.ToDouble(_reducao); } catch { }
                try
                {
                    _bc_icms = _bc_icms - (_bc_icms * (reducao / 100));
                }
                catch { }

                try
                {
                    _valor_ipi = _bc_ipi * (Convert.ToDouble(_ipi) / 100);
                }
                catch { }

                try
                {
                    double pICMS = Convert.ToDouble(_icms);
                    double pICMSST = Convert.ToDouble(_icms_st);
                    double pMVAST = Convert.ToDouble(_iva);
                    double vICMS = _bc_icms * (pICMS / 100);
                    double vBCST = _bc_icms + (_bc_icms * (pMVAST / 100));
                    double valor_temp_icms_st = vBCST * (pICMSST / 100);
                    if (icmsStCliente != 0)
                        _valor_st = valor_temp_icms_st - vICMS;
                }
                catch { }
                try
                {
                    _valor_icms = _bc_icms * (Convert.ToDouble(_icms) / 100);
                }
                catch { }
                if (aliq_ipi == "")
                    aliq_ipi = "null";
                else
                    aliq_ipi = "'" + aliq_ipi.Replace(".", "").Replace(",", ".") + "'";

                if (aliq_icms == "")
                    aliq_icms = "null";
                else
                    aliq_icms = "'" + aliq_icms.Replace(".", "").Replace(",", ".") + "'";

                cod_item = tb_cod_fornecedor.Text;
                if (cod_item == "")
                    cod_item = "null";
                else
                    cod_item = "'" + cod_item + "'";

                descricao_item = tb_descricao_produto.Text;
                if (descricao_item == "")
                    descricao_item = "null";
                else
                    descricao_item = "'" + descricao_item + "'";

                unid_item = tb_unid_item.Text;
                if (unid_item == "")
                    unid_item = "null";
                else
                    unid_item = "'" + unid_item + "'";

                qtde_item = tb_qtde_item.Text;
                if (qtde_item == "")
                    qtde_item = "null";
                else
                    qtde_item = "'" + qtde_item.Replace(",", ".") + "'";

                cod_vendedor = tb_cod_vendedor.Text;
                if (cod_vendedor == "")
                    cod_vendedor = "null";
                else
                    cod_vendedor = "'" + cod_vendedor + "'";

                valor_unit_item = tb_preco_unit_item.Text;
                if (valor_unit_item == "")
                    valor_unit_item = "null";
                else
                    valor_unit_item = "'" + valor_unit_item.Replace(".", "").Replace(",", ".") + "'";

                valor_total_item = _valor_total.ToString("n2");
                if (valor_total_item == "")
                    valor_total_item = "null";
                else
                    valor_total_item = "'" + valor_total_item.Replace(".", "").Replace(",", ".") + "'";

                valor_bc_icms_item = _bc_icms.ToString("n2");
                if (valor_bc_icms_item == "")
                    valor_bc_icms_item = "null";
                else
                    valor_bc_icms_item = "'" + valor_bc_icms_item.Replace(".", "").Replace(",", ".") + "'";

                valor_bc_ipi_item = _bc_ipi.ToString("n2");
                if (valor_bc_ipi_item == "")
                    valor_bc_ipi_item = "null";
                else
                    valor_bc_ipi_item = "'" + valor_bc_ipi_item.Replace(".", "").Replace(",", ".") + "'";

                valor_icms_item = _valor_icms.ToString("n3");
                if (valor_icms_item == "")
                    valor_icms_item = "null";
                else
                    valor_icms_item = "'" + valor_icms_item.Replace(".", "").Replace(",", ".") + "'";

                valor_ipi_item = _valor_ipi.ToString("n3");
                if (valor_ipi_item == "")
                    valor_ipi_item = "null";
                else
                    valor_ipi_item = "'" + valor_ipi_item.Replace(".", "").Replace(",", ".") + "'";
                string cod_sistema = "null";
                if (tb_cod_sistema.Text != "")
                    cod_sistema = "'" + tb_cod_sistema.Text + "'";
                string descricao_item_produto = "null";
                if (tb_descricao_item.Text != "")
                    descricao_item_produto = "'" + tb_descricao_item.Text + "'";
                string marca = "null";
                if (tb_marca.Text != "")
                    marca = "'" + tb_marca.Text + "'";
                string prazo = "null";
                if (tb_prazo.Text != "")
                    prazo = "'" + tb_prazo.Text + "'";
                string ean = "null";
                // if (tb_ean.Text != "")
                //      ean = "'" + tb_ean.Text + "'";
                string _dun, _qtde, _cnpj, _cod;

                ean = buscar_ean_produto(cod_item.Replace("'", ""), out _dun, out _qtde, out _cnpj, out _cod);
                if (tb_ean.Text != "") ean = tb_ean.Text;
                double custo = 0;
                try
                {
                    custo = Convert.ToDouble(custo_produto) * Convert.ToDouble(qtde_item.Replace("'", ""));
                }
                catch { }

                string data_entrega = "null";
                if (tb_data_entrega.Text != "")
                {
                    try
                    {
                        data_entrega = "'" + Convert.ToDateTime(tb_data_entrega.Text).ToShortDateString().Replace("/", ".") + "'";
                    }
                    catch { data_entrega = "null"; }
                }
                try
                {
                    //if (Convert.ToDouble(qtde_item.Replace("'","")) <= Convert.ToDouble(qtde_disponivel) || fbConnection1.DataSource == "10.3.3.4")
                    // {
                    this.datItens_ped_venda.InsertCommand.CommandText =
                       "INSERT INTO ITENS_PEDIDO_VENDA (COD_PROD_ITEM_VENDA, DESCRICAO_PROD_ITEM_VENDA, UNIDADE_PROD_ITEM_VENDA, QTDE_ITEM_VENDA, VALOR_UNIT_PROD_ITEM_VENDA, " +
                       "VALOR_TOTAL_PROD_ITEM_VENDA, BC_ICMS_PROD_ITEM_VENDA, ALIQ_ICMS_PROD_ITEM_VENDA, VALOR_ICMS_ITEM_VENDA, " +
                       "BC_IPI_PROD_ITEM_VENDA, ALIQ_IPI_PROD_ITEM_VENDA, VALOR_IPI_ITEM_VENDA, COD_PEDIDO_ITEM_VENDA, COD_VENDEDOR_ITEM_VENDA, DATA_PEDIDO_ITEM_VENDA, " +
                       "COD_SISTEMA_PROD_ITEM_VENDA, DESCRICAO_ITEM_PROD_ITEM_VENDA, MARCA_ITEM_VENDA, PRAZO_ITEM_VENDA, EAN_ITEM_VENDA, CUSTO_ITEM_VENDA, OP_CLIENTE_ITEM_VENDA, " +
                       "PEDIDO_CLIENTE_ITEM_VENDA, ITEM_PED_CLIENTE_ITEM_VENDA, DATA_ENTREGA_ITEM_VENDA, QTDE_FATURADA_ITEM_VENDA, VALOR_ST_ITEM_VENDA, NCM_ITEM_VENDA) " +
                       "VALUES (" + cod_item + "," + descricao_item + "," + unid_item + "," + qtde_item + "," + valor_unit_item + "," + valor_total_item + "," + valor_bc_icms_item + "," + aliq_icms + "," + valor_icms_item + "," +
                       valor_bc_ipi_item + "," + aliq_ipi + "," + valor_ipi_item + "," + tb_n_pedido.Text + "," + cod_vendedor + ",'" + Convert.ToDateTime(tb_data_pedido.Text).ToShortDateString().Replace("/", ".") + "'," + cod_sistema + "," + descricao_item_produto + "," + marca + "," + prazo + "," + ean + "," +
                       custo.ToString("n2").Replace(".", "").Replace(",", ".") + ",'" + tb_op_cliente.Text + "','" + tb_pedido_cliente.Text + "','" + tb_item_ped.Text + "'," + data_entrega + ",0, '" + _valor_st.ToString("n2").Replace(".", "").Replace(",", ".") + "','" + tb_ncm.Text + "')";
                    this.fbConnection1.Open();
                    this.datItens_ped_venda.InsertCommand.Connection = fbConnection1;
                    this.datItens_ped_venda.InsertCommand.ExecuteNonQuery();
                    this.fbConnection1.Close();

                    //recalculando estoque
                    try
                    {
                        classeEstoque estoque = new classeEstoque();
                        estoque.fbConnection1.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=10.3.3.4;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=True;Packet Size=8192;Server Type=0";
                        estoque.calcular_estoque(cod_item.Replace("'", ""));
                    }
                    catch { }


                    dsItens_ped_venda.Clear();
                    this.datItens_ped_venda.SelectCommand.CommandText =
                    "SELECT * FROM ITENS_PEDIDO_VENDA WHERE COD_PEDIDO_ITEM_VENDA = '" + tb_n_pedido.Text + "' ORDER BY COD_ITEM_VENDA";
                    this.fbConnection1.Open();
                    this.datItens_ped_venda.SelectCommand.Connection = fbConnection1;
                    this.datItens_ped_venda.SelectCommand.ExecuteNonQuery();
                    datItens_ped_venda.Fill(ITENS_PEDIDO_VENDA);
                    this.fbConnection1.Close();
                    colocar_numero_nos_itens();
                    tb_cod_fornecedor.Text = ""; tb_descricao_produto.Text = ""; tb_descricao_item.Text = "";
                    tb_unid_item.Text = ""; tb_qtde_item.Text = ""; tb_preco_unit_item.Text = "";
                    tb_marca.Text = ""; tb_prazo.Text = ""; tb_cod_sistema.Text = "";
                    tb_op_cliente.Text = ""; tb_pedido_cliente.Text = ""; tb_item_ped.Text = ""; tb_data_entrega.Text = "";
                    calcular();
                    tb_cod_fornecedor.Focus();
                    int rowIndex = dgvItens_nota.Rows.Count - 1;
                    dgvItens_nota.FirstDisplayedScrollingRowIndex = rowIndex;
                    // }
                    //else
                    // {
                    //      MessageBox.Show("Este produto está com saldo insuficiente no estoque!");
                    //  }
                }
                catch (Exception a)
                {
                    fbConnection1.Close();
                    MessageBox.Show(a.ToString());
                }
                //   }
                //    else
                //    {
                //       MessageBox.Show("Item já inserido no pedido!");
                //   }
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
                conexao.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=10.3.3.4;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=True;Packet Size=8192;Server Type=0";
                select.CommandText =
                    "SELECT COD_BARRAS_PRODUTO, COD_BARRAS_CAIXA_PRODUTO, QTDE_UNIDADE_PRODUTO, " +
                    "CNPJ_FORNECEDOR_PRODUTO, COD_PRODUTO FROM PRODUTOS WHERE COD_PRODUTO like '" + idProduto + "' OR COD_FORNECEDOR_PRODUTO = '" + idProduto + "'";
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

        private void button6_Click(object sender, EventArgs e)
        {
            salvar();
            calcular_desconto();
            selecionar_itens();
            acertar_impostos();
            selecionar_itens();
            calcular();

            // baixar_do_estoque();

        }

        private void calcular_desconto()
        {
            double _valor_total = 0, _porc_desconto = 0;
            for (int i = 0; i < dgvItens_nota.RowCount; i++)
            {

                try
                {
                    _valor_total += Convert.ToDouble(dgvItens_nota.Rows[i].Cells["col_valor_unit"].Value.ToString()) *
                        Convert.ToDouble(dgvItens_nota.Rows[i].Cells["col_qtde"].Value.ToString());
                }
                catch { }

            }
            double total_desconto = 0;
            try
            {
                _porc_desconto = 0;
                try { _porc_desconto = Convert.ToDouble(tb_porc_desconto.Text); }
                catch { }

                if (_porc_desconto > 0)
                {
                    total_desconto = (_valor_total) * Convert.ToDouble(tb_porc_desconto.Text) / 100;
                }
                else
                {
                    total_desconto = 0;
                    try
                    {
                        total_desconto = Convert.ToDouble(tb_valor_desconto.Text);
                        _porc_desconto = total_desconto / (_valor_total) * 100;
                        tb_porc_desconto.Text = _porc_desconto.ToString();
                    }
                    catch { }
                }
            }
            catch
            {
                total_desconto = Convert.ToDouble(tb_valor_desconto.Text);
                _porc_desconto = total_desconto / (_valor_total) * 100;
                tb_porc_desconto.Text = _porc_desconto.ToString();
            }
            tb_valor_desconto.Text = total_desconto.ToString("n2");
            try
            {

                if (_porc_desconto > 0)
                {
                    FbCommand command = new FbCommand();
                    command.CommandText = @"UPDATE ITENS_PEDIDO_VENDA
                        SET 
                            VALOR_DESCONTO_ITEM_VENDA = VALOR_TOTAL_PROD_ITEM_VENDA * " + (_porc_desconto / 100).ToString().Replace(".", "").Replace(",", ".") +
                        " WHERE COD_PEDIDO_ITEM_VENDA = '" + tb_n_pedido.Text + "'";
                    command.Connection = fbConnection1;
                    fbConnection1.Open();
                    command.ExecuteNonQuery();
                    fbConnection1.Close();
                }
            }
            catch(Exception ex)
            {
                fbConnection1.Close();
            }



        }

    

        private void acertar_impostos()
        {
            for (int i = 0; i < dgvItens_nota.RowCount; i++)
            {
                try
                {
                    string aliq_ipi = "", aliq_icms = "", iva_item = "", perc_red_icms = "", aliq_icms_st = "", st_item = "", cod_item = "", descricao_item = "", unid_item = "", qtde_item = "", qtde_disponivel = "", valor_unit_item = "",
                    valor_total_item = "", ncm_item = "", valor_bc_icms_item = "", valor_bc_ipi_item = "", valor_icms_item = "", valor_ipi_item = "", cod_vendedor = "", custo_produto = "";

                    string _origem, _cst, _modalidade, _icms, _icms_st, _reducao, _reducao_st, _iva, _ipi, _pis,
                                      _cofins, _iss, _crt, _aliquota_credito, _modalidade_st, _bc_com_ipi, _ipi_tributado,
                                      _ipi_n_tributado, _cst_ipi_tributado, _cst_ipi_n_tributado, _tipo_pis, _cst_pis,
                                      _tipo_cofins, _cst_cofins, _pCredICMS, _preco_minimo, _custo_produto, _cfop_produto, _cest_produto;

                    double icmsCliente = 1, icmsStCliente = 1;
                    string estado = buscar_estado_cliente(tb_cnpj_cliente.Text, out icmsCliente, out icmsStCliente);


                    buscar_informacoes_produto(dgvItens_nota.Rows[i].Cells["col_cod"].Value.ToString(), out _origem, out _cst, out _modalidade, out _icms,
                        out _icms_st, out _reducao, out _reducao_st, out _iva, out _ipi, out _pis, out _cofins,
                        out _iss, out _crt, out _aliquota_credito, out _modalidade_st, out _bc_com_ipi,
                        out _ipi_tributado, out _ipi_n_tributado, out _cst_ipi_tributado,
                        out _cst_ipi_n_tributado, out _tipo_pis, out _cst_pis, out _tipo_cofins, out _cst_cofins,
                        out _pCredICMS, out _preco_minimo, out _custo_produto, out _cfop_produto, out _cest_produto, cbTipo.Text, estado,
                        dgvItens_nota.Rows[i].Cells["col_ncm"].Value.ToString());


                    double _valor_total = 0, _bc_icms = 0, _bc_ipi = 0, _red_bc_icms = 0, _valor_ipi = 0, _valor_icms = 0, _valor_st = 0;
                    try
                    {
                        double desconto = 0;
                        try
                        {
                            desconto =  Convert.ToDouble(dgvItens_nota.Rows[i].Cells["col_valor_desconto"].Value.ToString());
                        }
                        catch { }
                        _valor_total = (Convert.ToDouble(dgvItens_nota.Rows[i].Cells["col_valor_unit"].Value.ToString()) *
                            Convert.ToDouble(dgvItens_nota.Rows[i].Cells["col_qtde"].Value.ToString())) - desconto;

                    }
                    catch { }
                    //calcular aqui a redução por estado
                    _bc_icms = _valor_total;
                    _bc_ipi = _valor_total;
                    _bc_icms = _valor_total;

                    if (icmsCliente == 0)
                    {
                        _icms = "0";
                    }
                    if (icmsStCliente == 0)
                    {
                        _icms_st = "0";
                    }

                    double reducao = 0;
                    try { reducao = Convert.ToDouble(_reducao); } catch { }
                    try
                    {
                        _bc_icms = _bc_icms - (_bc_icms * (reducao / 100));
                    }
                    catch { }

                    try
                    {
                        _valor_ipi = _bc_ipi * (Convert.ToDouble(_ipi) / 100);
                    }
                    catch { }

                    try
                    {
                        double pICMS = Convert.ToDouble(_icms);
                        double pICMSST = Convert.ToDouble(_icms_st);
                        double pMVAST = Convert.ToDouble(_iva);
                        double vICMS = _bc_icms * (pICMS / 100);
                        double vBCST = _bc_icms + (_bc_icms * (pMVAST / 100));
                        double valor_temp_icms_st = vBCST * (pICMSST / 100);
                        if (icmsStCliente != 0)
                            _valor_st = valor_temp_icms_st - vICMS;
                    }
                    catch { }
                    try
                    {
                        _valor_icms = _bc_icms * (Convert.ToDouble(_icms) / 100);
                    }
                    catch { }
                   

                    

                    valor_unit_item = dgvItens_nota.Rows[i].Cells["col_valor_unit"].Value.ToString();

                    string valor_total_item2 = _valor_total.ToString("n2");

                    valor_bc_icms_item = _bc_icms.ToString("n2");


                    valor_bc_ipi_item = _bc_ipi.ToString("n2");

                    valor_icms_item = _valor_icms.ToString("n3");

                    valor_ipi_item = _valor_ipi.ToString("n3");


                    double custo = 0;
                    try
                    {
                        custo = Convert.ToDouble(custo_produto) * Convert.ToDouble(qtde_item.Replace("'", ""));
                    }
                    catch { }

                    FbCommand command = new FbCommand();
                    command.CommandText = @"UPDATE ITENS_PEDIDO_VENDA
                        SET 
                            VALOR_TOTAL_PROD_ITEM_VENDA = @valor_total_item,
                            BC_ICMS_PROD_ITEM_VENDA = @valor_bc_icms_item,
                            ALIQ_ICMS_PROD_ITEM_VENDA = @aliq_icms,
                            VALOR_ICMS_ITEM_VENDA = @valor_icms_item,
                            BC_IPI_PROD_ITEM_VENDA = @valor_bc_ipi_item,
                            ALIQ_IPI_PROD_ITEM_VENDA = @aliq_ipi,
                            VALOR_IPI_ITEM_VENDA = @valor_ipi_item,
                            CUSTO_ITEM_VENDA = @custo,
                            VALOR_ST_ITEM_VENDA = @valor_st 
                        WHERE COD_ITEM_VENDA = @cod_item";

                    // Adicionando todos os parâmetros
                    command.Parameters.AddWithValue("@valor_total_item", valor_total_item2.Replace(".", "").Replace(",", "."));
                    command.Parameters.AddWithValue("@valor_bc_icms_item", valor_bc_icms_item.Replace(".", "").Replace(",", "."));
                    command.Parameters.AddWithValue("@aliq_icms", _icms);
                    command.Parameters.AddWithValue("@valor_icms_item", valor_icms_item.Replace(".", "").Replace(",", "."));
                    command.Parameters.AddWithValue("@valor_bc_ipi_item", valor_bc_ipi_item.Replace(".", "").Replace(",", "."));
                    command.Parameters.AddWithValue("@aliq_ipi", _ipi);
                    command.Parameters.AddWithValue("@valor_ipi_item", valor_ipi_item.Replace(".","").Replace(",","."));
                    command.Parameters.AddWithValue("@custo", custo.ToString("n2"));
                    command.Parameters.AddWithValue("@valor_st", _valor_st.ToString("n3").Replace(".", "").Replace(",", "."));
                    command.Parameters.AddWithValue("@cod_item", dgvItens_nota.Rows[i].Cells["col_cod_item_venda"].Value.ToString());
                    command.Connection = fbConnection1;
                    fbConnection1.Open();
                    command.ExecuteNonQuery();
                    fbConnection1.Close();
                }
                catch(Exception ex)
                {
                    fbConnection1.Close();
                    //MessageBox.Show(ex.Message);
                }
            }



        }

        
        private void calcular()
        {
           
            double valor_total = 0;
            double valor_total_st = 0;
            double qtde_total = 0;
            double valor_total_ipi = 0;
            double valor_desejado = 0;
            bool isento = false;
            if (verificar_se_cliente_e_isento(tb_cnpj_cliente.Text))
            {
                isento = true;
            }

            double valor_produtos = 0;

            for (int i = 0; i < dgvItens_nota.RowCount; i++)
            {







                double valor_parcial = 0;
                double desconto = 0;
                try
                {
                    try
                    {
                        desconto = Convert.ToDouble(dgvItens_nota.Rows[i].Cells["col_valor_desconto"].Value.ToString());
                    }
                    catch { }
                    qtde_total = qtde_total + Convert.ToDouble(dgvItens_nota.Rows[i].Cells["col_qtde"].Value);
                    valor_parcial = (Convert.ToDouble(dgvItens_nota.Rows[i].Cells["col_valor_unit"].Value.ToString()) * 
                        Convert.ToDouble(dgvItens_nota.Rows[i].Cells["col_qtde"].Value.ToString()));
                    try
                    {
                        valor_desejado += Convert.ToDouble(dgvItens_nota.Rows[i].Cells["col_valor_unit"].Value.ToString()) * Convert.ToDouble(dgvItens_nota.Rows[i].Cells["col_qtde_fat"].Value.ToString());

                    }
                    catch { }
                    valor_total = valor_total + valor_parcial;
                    valor_produtos += valor_parcial - desconto;
                    dgvItens_nota.Rows[i].Cells["col_valor_total"].Value = valor_parcial;







                    double valor_st_item = 0;
                    try
                    {
                        
                           // valor_st_item = calcular_st_item(valor_parcial, tb_cnpj_cliente.Text, dgvItens_nota.Rows[i].Cells["col_cod"].Value.ToString());
                            // dgvItens_nota.Rows[i].Cells["col_valor_st"].Value = valor_st_item.ToString();
                            valor_total_st += Convert.ToDouble(dgvItens_nota.Rows[i].Cells["col_valor_st"].Value.ToString());
                        

                    }
                    catch { }
                    
                    try
                    {

                        // valor_st_item = calcular_st_item(valor_parcial, tb_cnpj_cliente.Text, dgvItens_nota.Rows[i].Cells["col_cod"].Value.ToString());
                        // dgvItens_nota.Rows[i].Cells["col_valor_st"].Value = valor_st_item.ToString();
                        valor_total_ipi += Convert.ToDouble(dgvItens_nota.Rows[i].Cells["col_valor_ipi"].Value.ToString());


                    }
                    catch { }

                }
                catch { }

            }
            tb_valor_desejado.Text = valor_desejado.ToString("n2");
            tb_total_prod.Text = valor_produtos.ToString("n2");// valor_total.ToString("n2");
            tb_valor_st.Text = valor_total_st.ToString("n2");
            tbIpi.Text = valor_total_ipi.ToString("n2");



            //double outras_despesas = 0;
            //try
            //{
            //    outras_despesas = Convert.ToDouble(tb_outros_valores.Text);
            //}
            //catch
            //{
            //    outras_despesas = 0;
            //}
            double valor_total_pedido = valor_produtos + valor_total_ipi + valor_total_st;// - total_desconto;
            tb_total_pedido.Text = valor_total_pedido.ToString("n2");
            tb_qtde_itens.Text = dgvItens_nota.RowCount.ToString();

            double valor = qtde_total;
            int parteInteira = (int)valor;
            double parteFracionaria = valor - parteInteira;
            int _qtde = 0;
            if (parteFracionaria > 0)
                _qtde = parteInteira + 1;
            else
                _qtde = parteInteira;

            if (razao_social_empresa.Contains("DALE"))
                tb_qtde_caixas.Text = _qtde.ToString();
            colocar_numero_nos_itens();
        }

        private void buscar_informacoes_produto_antigo(string cod_peca, out string _origem, out string _cst,
           out string _modalidade, out string _icms, out string _icms_st, out string _reducao, out string _reducao_st,
           out string _iva, out string _ipi, out string _pis, out string _cofins, out string _iss,
           out string _crt, out string _aliquota_credito, out string _modalidade_st, out string _bc_com_ipi,
           out string _ipi_tributado, out string _ipi_n_tributado, out string _cst_ipi_tributado,
           out string _cst_ipi_n_tributado, out string _tipo_pis, out string _cst_pis, out string _tipo_cofins,
           out string _cst_cofins, out string _pCredICMS, out string _preco_minimo, out string _custo, out string cfop_produto, out string cest_produto, string estado)
        {
            _cst = ""; _origem = ""; _modalidade = ""; _icms = ""; _icms_st = ""; _reducao = ""; _reducao_st = ""; _iva = ""; _ipi = "";
            _pis = ""; _cofins = ""; _iss = ""; _crt = ""; _aliquota_credito = ""; _modalidade_st = ""; _bc_com_ipi = "";
            _ipi_tributado = ""; _ipi_n_tributado = ""; _cst_ipi_tributado = ""; _cst_ipi_n_tributado = "";
            _tipo_pis = ""; _cst_pis = ""; _tipo_cofins = ""; _cst_cofins = ""; _pCredICMS = ""; _preco_minimo = ""; _custo = ""; cfop_produto = ""; cest_produto = "";
            try
            {
                //SE NÃO TIVER INFORMAÇÃO NO PRODUTO PEGARÁ A INFORMAÇÃO PADRÃO
                buscar_informacoes_padrao(out _origem, out _cst, out _modalidade, out _icms,
                            out _icms_st, out _reducao, out _reducao_st, out _iva, out _ipi, out _pis, out _cofins,
                            out _iss, out _crt, out _aliquota_credito, out _modalidade_st, out _bc_com_ipi,
                            out _ipi_tributado, out _ipi_n_tributado, out _cst_ipi_tributado,
                            out _cst_ipi_n_tributado, out _tipo_pis, out _cst_pis, out _tipo_cofins, out _cst_cofins, out _pCredICMS);

                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                select.CommandText =
                    "SELECT * FROM PRODUTOS WHERE COD_FORNECEDOR_PRODUTO = '" + cod_peca + "'";
                fbConnection1.Open();
                FbDataAdapter produtosDataAdapter = new FbDataAdapter();
                produtosDataAdapter.SelectCommand = select;
                DataSet produtosDataSet = new DataSet();
                produtosDataAdapter.Fill(produtosDataSet);
                fbConnection1.Close();
                foreach (DataRow dr in produtosDataSet.Tables[0].Rows)
                {

                    try
                    {
                        _preco_minimo = dr["VALOR_PROMOCAO_PRODUTO"].ToString();
                    }
                    catch { }
                    try
                    {
                        _custo = dr["CUSTO_PRODUTO"].ToString();
                    }
                    catch { }
                    try
                    {
                        cest_produto = dr["CEST_PRODUTO"].ToString();
                    }
                    catch { }

                    bool ncm_encontrado = false;
                    string tipo_cliente = buscar_tipo_cliente(tb_cnpj_cliente.Text);
                    if (tipo_cliente == "INDUSTRIALIZACAO")
                    {
                        cfop_produto = "5101";
                        if (estado != estado_empresa)
                            cfop_produto = "6101";
                        _cst = "101";
                    }
                    else if (tipo_cliente == "CONSUMO")
                    {
                        cfop_produto = "5101";
                        if (estado != estado_empresa)
                            cfop_produto = "6101";
                        _cst = "102";
                    }
                    else if (tipo_cliente == "REVENDA")
                    {
                        foreach (DataRow dr_ncm in dtNcm_cst.Select("NCM = '" + dr["NCM_PRODUTO"].ToString() + "' AND ESTADO = '" + estado + "'"))
                        {

                            if (dr_ncm["CST ICMS"].ToString() == "")
                                break;
                            else
                            {
                                try
                                {
                                    /* icms */
                                    ncm_encontrado = true;


                                    cfop_produto = dr_ncm["CFOP"].ToString();
                                    _cst = dr_ncm["CST ICMS"].ToString();

                                    _icms = dr_ncm["ICMS"].ToString();
                                    _icms_st = dr_ncm["ICMS_ST"].ToString();

                                    _reducao = dr_ncm["REDUÇÃO"].ToString();
                                    _reducao_st = dr_ncm["REDUÇÃO ST"].ToString();
                                    _iva = dr_ncm["MVA"].ToString();

                                    /* pis cofins */
                                    _pis = "0,00"; _cofins = "0,00";
                                    _ipi = "0,00";
                                    try
                                    {
                                        _ipi = Convert.ToDouble(dr_ncm["IPI"].ToString()).ToString();
                                    }
                                    catch { }
                                    try
                                    {
                                        _pis = Convert.ToDouble(dr_ncm["PIS"].ToString()).ToString();
                                        _cofins = Convert.ToDouble(dr_ncm["COFINS"].ToString()).ToString();
                                    }
                                    catch { }


                                    if (dr_ncm["CST_COFINS"].ToString() != "")
                                    {
                                        _cst_cofins = dr_ncm["CST_COFINS"].ToString();
                                    }
                                    if (dr_ncm["CST_PIS"].ToString() != "")
                                    {
                                        _cst_pis = dr_ncm["CST_PIS"].ToString();
                                    }
                                    if (dr_ncm["TIPO_COFINS"].ToString() != "")
                                    {
                                        _tipo_cofins = dr_ncm["TIPO_COFINS"].ToString();
                                    }
                                    if (dr_ncm["TIPO_PIS"].ToString() != "")
                                    {
                                        _tipo_pis = dr_ncm["TIPO_PIS"].ToString();
                                    }



                                }
                                catch { }

                            }






                        }
                    }
                    if (!ncm_encontrado)
                    {
                        //MessageBox.Show("NCM do produto " + dr["COD_FORNECEDOR_PRODUTO"].ToString() + " - " +  dr["DESCRICAO_PRODUTO"].ToString() + " não encontrado, por favor verifica antes de faturar");
                        if (!pessoa_fisica(tb_cnpj_cliente.Text))
                        {
                            if (estado == estado_empresa)
                            {
                                _cst = dr["ST_SAIDA_PRODUTO"].ToString();
                                _icms = dr["ALIQUOTA_ICMS_PRODUTO"].ToString();
                                string _icms_cliente = "";
                                if (verificar_icms_cliente(out _icms_cliente))
                                {
                                    _icms = _icms_cliente;
                                }
                                _icms_st = dr["ALIQUOTA_ICMS_ST_PRODUTO"].ToString();
                                _reducao = dr["REDUCAO_ICMS_PRODUTO"].ToString();
                                _reducao_st = dr["REDUCAO_ST_PRODUTO"].ToString();
                                _iva = dr["IVA_PRODUTO"].ToString();
                            }
                            else  //FORA DO ESTADO
                            {
                                _cst = dr["ST_SAIDA_FORA_PRODUTO"].ToString();
                                _icms = dr["ALIQUOTA_FORA_ICMS_PRODUTO"].ToString();
                                string _icms_cliente = "";
                                if (verificar_icms_cliente(out _icms_cliente))
                                {
                                    _icms = _icms_cliente;
                                }
                                _icms_st = dr["ALIQUOTA_ICMS_ST_FORA_PRODUTO"].ToString();
                                _reducao = dr["REDUCAO_FORA_PRODUTO"].ToString();
                                _reducao_st = dr["REDUCAO_ST_FORA_PRODUTO"].ToString();
                                _iva = dr["IVA_FORA_PRODUTO"].ToString();
                            }
                        }
                        else
                        {
                            //_cst = "00";
                            _cst = dr["ST_SAIDA_PRODUTO"].ToString();
                            if (_cst != "60" && _cst != "500" && _cst != "101")
                            {
                                _cst = "102";
                                _icms = dr["ALIQUOTA_ICMS_PRODUTO"].ToString();
                            }
                        }
                        if (estado == estado_empresa)
                        {
                            try
                            {
                                _pis = "0,00"; _cofins = "0,00";
                                _ipi = "0,00";
                                try
                                {
                                    _ipi = Convert.ToDouble(dr["ALIQUOTA_IPI_PRODUTO"].ToString()).ToString();
                                }
                                catch { }
                                try
                                {
                                    _pis = Convert.ToDouble(dr["ALIQUOTA_PIS_PRODUTO"].ToString()).ToString();
                                    _cofins = Convert.ToDouble(dr["ALIQUOTA_COFINS_PRODUTO"].ToString()).ToString();
                                }
                                catch { }


                                if (dr["CST_COFINS_PRODUTO"].ToString() != "")
                                {
                                    _cst_cofins = dr["CST_COFINS_PRODUTO"].ToString();
                                    _cst_pis = dr["CST_PIS_PRODUTO"].ToString();
                                    _tipo_cofins = dr["TIPO_COFINS_PRODUTO"].ToString();
                                    _tipo_pis = dr["TIPO_PIS_PRODUTO"].ToString();
                                }
                                else
                                {
                                    string pis_cofins = dr["PIS_COFINS_PRODUTO"].ToString();

                                    if (pis_cofins == "0" || pis_cofins == "")
                                    {
                                        _cst_cofins = "06-";
                                        _cst_pis = "06-";
                                        _pis = "";
                                        _cofins = "";
                                    }
                                }
                            }
                            catch { }
                        }
                        else
                        {
                            try
                            {
                                _pis = "0,00"; _cofins = "0,00";
                                _ipi = "0,00";
                                try
                                {
                                    _ipi = Convert.ToDouble(dr["ALIQUOTA_IPI_FORA_PRODUTO"].ToString()).ToString();
                                    if (Convert.ToDouble(_ipi) == 0)
                                        _cst_ipi_n_tributado = "51 - Saída tributada com alíquota zero";
                                    else
                                        _cst_ipi_n_tributado = "50 - Saída tributada";
                                }
                                catch
                                {
                                    _cst_ipi_n_tributado = "53 - Saída tributada";
                                    _ipi_n_tributado = "1";
                                }
                                try
                                {
                                    _pis = Convert.ToDouble(dr["ALIQUOTA_PIS_PRODUTO"].ToString()).ToString();
                                    _cofins = Convert.ToDouble(dr["ALIQUOTA_COFINS_PRODUTO"].ToString()).ToString();
                                }
                                catch { }


                                if (dr["CST_COFINS_PRODUTO"].ToString() != "")
                                {
                                    _cst_cofins = dr["CST_COFINS_PRODUTO"].ToString();
                                    _cst_pis = dr["CST_PIS_PRODUTO"].ToString();
                                    _tipo_cofins = dr["TIPO_COFINS_PRODUTO"].ToString();
                                    _tipo_pis = dr["TIPO_PIS_PRODUTO"].ToString();
                                }
                                else
                                {
                                    string pis_cofins = dr["PIS_COFINS_PRODUTO"].ToString();

                                    if (pis_cofins == "0" || pis_cofins == "")
                                    {
                                        _cst_cofins = "08-";
                                        _cst_pis = "08-";
                                        _pis = "";
                                        _cofins = "";
                                    }
                                }
                            }
                            catch { }
                        }
                    }
                    if (verificar_se_cliente_e_isento(tb_cnpj_cliente.Text))
                    {
                        if (estado != estado_empresa)
                        {
                            cfop_produto = "6101";
                            _cst = "102";
                        }
                        else
                        {
                            cfop_produto = "5101";
                            _cst = "102";

                            //if(
                            // _cst = "20";
                            //_icms_st = "0,00"; //pega icms do padrão da empresa;
                        }

                    }
                }
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private bool verificar_se_cliente_e_isento(string cnpj)
        {
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                select.CommandText =
                    "SELECT IE, PESSOA_FISICA_CLIENTE FROM CLIENTES WHERE CNPJ = '" + cnpj + "'";
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();
                foreach (DataRow dr in dtSelect.Rows)
                {
                    if (dr[0].ToString().ToUpper().Contains("ISENTO"))
                    {
                        return true;
                    }
                    if (dr[1].ToString() == "1")
                    {
                        return true;
                    }
                }
                return false;
            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
                fbConnection1.Close();
                return false;
            }
        }

        private bool verificar_icms_cliente(out string _icms_cliente)
        {
            _icms_cliente = "";
            try
            {
                FbCommand select = new FbCommand();
                select.CommandText =
                    "SELECT ICMS_CLIENTE FROM CLIENTES WHERE CNPJ = '" + tb_cnpj_cliente.Text + "'";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();
                foreach (DataRow dr in dtSelect.Rows)
                {
                    if (dr[0].ToString() != "")
                    {
                        _icms_cliente = Convert.ToDouble(dr[0].ToString()).ToString();
                        return true;
                    }
                }

                return false;
            }
            catch
            {
                fbConnection1.Close();
                return false;
            }
        }

        private bool pessoa_fisica(string cnpj)
        {
            bool retorno = false;
            try
            {

                FbCommand comando = new FbCommand();
                comando.Connection = fbConnection1;
                comando.CommandText =
                    "SELECT * FROM CLIENTES WHERE CNPJ = '" + cnpj + "'";
                fbConnection1.Open();
                //comando_select.Connection = fbConnection1;
                FbDataAdapter cli = new FbDataAdapter();
                cli.SelectCommand = comando;
                DataSet cliente = new DataSet();
                cli.Fill(cliente);
                fbConnection1.Close();
                DataRow dr = cliente.Tables[0].Rows[0];
                if (dr["PESSOA_FISICA_CLIENTE"].ToString() == "1")
                    retorno = true;
                else
                    retorno = false;
                return retorno;
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
                return retorno;
            }
        }

        private string buscar_tipo_cliente(string cnpj)
        {
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                select.CommandText =
                    "SELECT TIPO_CLIENTE, PESSOA_FISICA_CLIENTE FROM CLIENTES WHERE CNPJ = '" + cnpj + "'";
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();
                foreach (DataRow dr in dtSelect.Rows)
                {
                    if (dr[0].ToString().ToUpper().Contains("INDUSTRIA"))
                    {
                        return "INDUSTRIALIZACAO";
                    }
                    if (dr[0].ToString().ToUpper().Contains("REVENDA"))
                    {
                        return "REVENDA";
                    }
                    if (dr[0].ToString().ToUpper().Contains("CONSUMO"))
                    {
                        return "CONSUMO";
                    }
                }
                return "";
            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
                fbConnection1.Close();
                return "";
            }
        }

        private void buscar_informacoes_padrao(out string _origem, out string _cst, out string _modalidade,
          out string _icms, out string _icms_st, out string _reducao, out string _reducao_st, out string _iva, out string _ipi,
          out string _pis, out string _cofins, out string _iss, out string _crt, out string _aliquota_credito,
          out string _modalidade_st, out string _bc_com_ipi,
          out string _ipi_tributado, out string _ipi_n_tributado,
          out string _cst_ipi_tributado, out string _cst_ipi_n_tributado, out string _tipo_pis, out string _cst_pis,
          out string _tipo_cofins, out string _cst_cofins, out string _pCredICMS)
        {
            _origem = "";
            _cst = "";
            _modalidade = "";
            _icms = "";
            _icms_st = "";
            _reducao = "";
            _reducao_st = "";
            _iva = "";
            _ipi = "";
            _pis = "";
            _cofins = "";
            _iss = "";
            _crt = "";
            _aliquota_credito = "";
            _modalidade_st = "";
            _bc_com_ipi = "";
            _ipi_tributado = "";
            _ipi_n_tributado = "";
            _cst_ipi_tributado = "";
            _cst_ipi_n_tributado = "";
            _tipo_pis = "";
            _cst_pis = "";
            _tipo_cofins = "";
            _cst_cofins = "";
            _pCredICMS = "";
            try
            {
                FbCommand comando = new FbCommand();
                comando.Connection = fbConnection1;
                comando.CommandText =
                   "SELECT * FROM EMPRESA where LICENCA_DLL_NFE_EMPRESA is not null AND CNPJ_EMPRESA = '" + cnpj_empresa + "' ";
                fbConnection1.Open();
                DataSet inf_padrao = new DataSet();
                FbDataAdapter datEmpresa = new FbDataAdapter();
                datEmpresa.SelectCommand = comando;
                datEmpresa.Fill(inf_padrao);
                fbConnection1.Close();
                foreach (DataRow dr in inf_padrao.Tables[0].Rows)
                {
                    _origem = dr["ORIGEM_EMPRESA"].ToString();
                    _cst = dr["CST_EMPRESA"].ToString();
                    _modalidade = dr["MOD_BC_EMPRESA"].ToString();
                    _icms = dr["ICMS_EMPRESA"].ToString();
                    _icms_st = dr["ICMS_ST_EMPRESA"].ToString();
                    _reducao = dr["REDUCAO_EMPRESA"].ToString();
                    _reducao_st = dr["REDUCAO_ST_EMPRESA"].ToString();
                    _iva = dr["IVA_EMPRESA"].ToString();
                    _ipi = dr["IPI_EMPRESA"].ToString();
                    _pis = dr["PIS_EMPRESA"].ToString();
                    _cofins = dr["COFINS_EMPRESA"].ToString();
                    _iss = dr["ISS_EMPRESA"].ToString();
                    _crt = dr["CRT_EMPRESA"].ToString();
                    _aliquota_credito = dr["ALIQUOTA_CREDITO_EMPRESA"].ToString();
                    _modalidade_st = dr["MOD_BC_ST_EMPRESA"].ToString();
                    _bc_com_ipi = dr["BC_COM_IPI_EMPRESA"].ToString();
                    _ipi_tributado = dr["IPI_TRIB_EMPRESA"].ToString();
                    _ipi_n_tributado = dr["IPI_N_TRIB_EMPRESA"].ToString();
                    _cst_ipi_tributado = dr["CST_IPI_TRIB_EMPRESA"].ToString();
                    _cst_ipi_n_tributado = dr["CST_IPI_N_TRIB_EMPRESA"].ToString();
                    _tipo_pis = dr["TIPO_PIS_EMPRESA"].ToString();
                    _cst_pis = dr["CST_PIS_EMPRESA"].ToString();
                    _tipo_cofins = dr["TIPO_COFINS_EMPRESA"].ToString();
                    _cst_cofins = dr["CST_COFINS_EMPRESA"].ToString();
                    _pCredICMS = dr["ALIQUOTA_CREDITO_EMPRESA"].ToString();
                }
            }
            catch
            {
                fbConnection1.Close();
            }
        }

        private double calcular_st_item(double valor_total, string cnpj_cliente, string cod_produto)
        {
            /* vCredICMSSN = pCredSN * vBC / 100;
            vICMS = vBC * pICMS / 100;
            vBCST = vBC + (vBC * pMVAST / 100);
            double valor_temp_icms_st = vBCST * pICMSST / 100;
            vICMSST = valor_temp_icms_st - vICMS;
            pICMS = 0;
            vICMS = 0; //ZERAR O ICMS PORQUE QUANDO É SIMPLES NACIONAL NÃO DESTACA NA NF O ICMS QUANDO TEM ST
            vBC = 0; //IDEM, NÃO TEM BASE DE CALCULO ICMS QUANDO É SIMPLES*/
            try
            {
                string _origem, _cst, _modalidade, _icms, _icms_st, _reducao, _reducao_st, _iva, _ipi, _pis,
                             _cofins, _iss, _crt, _aliquota_credito, _modalidade_st, _bc_com_ipi, _ipi_tributado,
                             _ipi_n_tributado, _cst_ipi_tributado, _cst_ipi_n_tributado, _tipo_pis, _cst_pis,
                             _tipo_cofins, _cst_cofins, _pCredICMS, _preco_minimo, _custo_produto, _cfop_produto, _cest_produto;

                string ncm = buscar_ncm_produto(cod_produto);
                double icmsCliente = 1, icmsStCliente = 1;
                string estado_cliente = buscar_estado_cliente(tb_cnpj_cliente.Text, out icmsCliente, out icmsStCliente);

               // string estado_cliente = buscar_estado_cliente(cnpj_cliente);

                buscar_informacoes_produto(cod_produto, out _origem, out _cst, out _modalidade, out _icms,
                    out _icms_st, out _reducao, out _reducao_st, out _iva, out _ipi, out _pis, out _cofins,
                    out _iss, out _crt, out _aliquota_credito, out _modalidade_st, out _bc_com_ipi,
                    out _ipi_tributado, out _ipi_n_tributado, out _cst_ipi_tributado,
                    out _cst_ipi_n_tributado, out _tipo_pis, out _cst_pis, out _tipo_cofins, out _cst_cofins,
                    out _pCredICMS, out _preco_minimo, out _custo_produto, out _cfop_produto, out _cest_produto, cbTipo.Text, estado_cliente, ncm);



                // double icms_st = 0, mva = 0, icms = 0;
                //buscar_impostos(ncm, estado_cliente, out icms_st, out mva, out icms);
                double icms_st = 0, icms = 0, mva = 0;

                if(icmsCliente == 0)
                {
                    _icms = "0";
                }
                if(icmsStCliente == 0)
                {
                    _icms_st = "0";
                }

                try
                {
                    icms_st = Convert.ToDouble(_icms_st);
                    icms = Convert.ToDouble(_icms);
                    mva = Convert.ToDouble(_iva);
                }
                catch { }


                if (icms_st > 0)
                {
                    double vICMS = valor_total * icms / 100;
                    double vBCST = valor_total + (valor_total * mva / 100);
                    double valor_temp_icms_st = vBCST * icms_st / 100;
                    double vICMSST = valor_temp_icms_st - vICMS;
                    return vICMSST;
                }
                else
                    return 0;
            }
            catch (Exception ex)
            {
                fbConnection1.Close();
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        private string buscar_estado_cliente(string cnpj_cliente, out double icms, out double icmsSt)
        {
            icms = 1; icmsSt = 1;
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                        "SELECT ESTADO, ICMS_CLIENTE, ICMS_ST_CLIENTE FROM CLIENTES WHERE CNPJ = '" + cnpj_cliente + "'";
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();
                foreach (DataRow dr in dtSelect.Rows)
                {
                    try
                    {
                        icms = Convert.ToDouble(dr["ICMS_CLIENTE"].ToString());
                    }
                    catch { }
                    try
                    {
                        icmsSt = Convert.ToDouble(dr["ICMS_ST_CLIENTE"].ToString());
                    }
                    catch { }
                    return dr[0].ToString();
                }
                return "";
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                return "";
            }
        }

        private void buscar_impostos(string ncm, string estado_cliente, out double icms_st, out double mva, out double icms)
        {
            icms_st = 0; mva = 0; icms = 0;
            try
            {

                foreach (DataRow dr in dtNcm_cst.Select("NCM = '" + ncm + "' AND ESTADO = '" + estado_cliente + "'"))
                {
                    try
                    {
                        icms_st = Convert.ToDouble(dr["ICMS_ST"].ToString());
                        icms = Convert.ToDouble(dr["ICMS"].ToString());
                        mva = Convert.ToDouble(dr["MVA"].ToString());
                    }
                    catch { }
                }
            }
            catch (Exception ex)
            {
                fbConnection1.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private string buscar_ncm_produto(string cod_produto)
        {
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                        "SELECT NCM_PRODUTO FROM PRODUTOS WHERE COD_PRODUTO = '" + cod_produto + "'";
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();
                foreach (DataRow dr in dtSelect.Rows)
                {
                    return dr[0].ToString();
                }
                return "99999999";
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                return "99999999";
            }
        }


        private void bt_salvar_Click(object sender, EventArgs e)
        {
            if (cbStatus.Text != "Faturado")
            {
                if (cbStatus.Text != "Confirmado")
                {

                    calcular();
                    if (cbStatus.Text != "" && cbTipo.Text != "")
                    {

                        salvar();

                        MessageBox.Show("Salvo");
                    }
                    else
                    {
                        MessageBox.Show("Para salvar é obrigatório colocar o Status e o Tipo do Pedido");

                    }
                }
                else
                {
                    MessageBox.Show("Não é possivel editar um pedido confirmado!");
                }
            }
            else
            {
                MessageBox.Show("Não é possivel editar um pedido Faturado!");
            }
        }

        private void salvar()
        {
            //baixar_do_estoque();
            try
            {
                if (tb_vendedor.Text != "")
                {
                    this.BindingContext[dsPedidos_venda, "PEDIDOS_VENDA"].EndCurrentEdit();
                    if (dsPedidos_venda.HasChanges())
                    {
                        fbConnection1.Open();
                        datPedidos_venda.UpdateCommand = cbPedidos_venda.GetUpdateCommand();
                        datPedidos_venda.InsertCommand = cbPedidos_venda.GetInsertCommand();
                        datPedidos_venda.DeleteCommand = cbPedidos_venda.GetDeleteCommand();
                        datPedidos_venda.Update(dsPedidos_venda, "PEDIDOS_VENDA");
                        dsPedidos_venda.AcceptChanges();
                        fbConnection1.Close();
                    }
                    this.BindingContext[dsItens_ped_venda, "ITENS_PEDIDO_VENDA"].EndCurrentEdit();
                    if (dsItens_ped_venda.HasChanges())
                    {
                        //baixar_do_estoque();
                        fbConnection1.Open();
                        datItens_ped_venda.UpdateCommand = cbItens_ped_venda.GetUpdateCommand();
                        datItens_ped_venda.InsertCommand = cbItens_ped_venda.GetInsertCommand();
                        datItens_ped_venda.DeleteCommand = cbItens_ped_venda.GetDeleteCommand();
                        datItens_ped_venda.Update(dsItens_ped_venda, "ITENS_PEDIDO_VENDA");
                        dsItens_ped_venda.AcceptChanges();
                        fbConnection1.Close();
                    }
                    this.BindingContext[dsFped, "FATURA_PEDIDO"].EndCurrentEdit();
                    if (dsFped.HasChanges())
                    {
                        fbConnection1.Open();
                        datFped.UpdateCommand = cbFped.GetUpdateCommand();
                        datFped.InsertCommand = cbFped.GetInsertCommand();
                        datFped.DeleteCommand = cbFped.GetDeleteCommand();
                        datFped.Update(dsFped, "FATURA_PEDIDO");
                        dsFped.AcceptChanges();
                        fbConnection1.Close();
                    }
                    try
                    {

                        tb_time_correto.Text = Convert.ToDateTime(tb_time_correto.Text).ToShortTimeString();
                    }
                    catch { }
                    // MessageBox.Show("Salvo!");
                    /*ATUALIZAR COD DO VENDEDOR NOS ITENS DO PEDIDO*/
                    //atualizarVendedorNosItens(tb_n_pedido.Text);
                }
                else
                {
                    if (!novo)
                    {
                        MessageBox.Show("É necessário informar um vendedor para o pedido!");
                    }
                    novo = false;
                }
            }
            catch (Exception ex)
            {
                fbConnection1.Close();
                MessageBox.Show(ex.Message);
            }

        }

        private void atualizarVendedorNosItens(string codPedido)
        {
            bool itemSemVendedor = false;

            try
            {
                DataTable dtItensPedido = new DataTable();
                datItens_ped_venda.SelectCommand.CommandText = "SELECT * FROM itens_pedido_venda WHERE cod_pedido_item_venda = " + codPedido;
                datItens_ped_venda.SelectCommand.Connection = fbConnection1;
                fbConnection1.Open();
                datItens_ped_venda.SelectCommand.ExecuteNonQuery();
                datItens_ped_venda.Fill(dtItensPedido);
                fbConnection1.Close();

                foreach (DataRow dr in dtItensPedido.Rows)
                {
                    if (dr["cod_vendedor_item_venda"].ToString() == "")
                    {
                        itemSemVendedor = true;
                    }
                }

                if (itemSemVendedor)
                {
                    datItens_ped_venda.UpdateCommand.CommandText =
                        "UPDATE itens_pedido_venda SET cod_vendedor_item_venda = " + tb_vendedor.Text + " WHERE cod_pedido_item_venda  = " + codPedido;
                    datItens_ped_venda.UpdateCommand.Connection = fbConnection1;
                    fbConnection1.Open();
                    datItens_ped_venda.UpdateCommand.ExecuteNonQuery();
                    fbConnection1.Close();
                }
            }
            catch
            {
                fbConnection1.Close();
            }
        }


        private void bt_novo_Click(object sender, EventArgs e)
        {
            criar_item();
        }

        private void criar_item()
        {


            try
            {
                tb_ncm.Text = "";
                string ultimo_pedido = buscar_ultimo_pedido_empresa(cnpj_empresa);
                int proximo_pedido = 0;
                formInput input = new formInput();
                try
                {
                    input.texto = "Digite o número do pedido que você deseja criar";
                    input.titulo = "Número do Pedido";
                    input.ShowDialog();

                }
                finally
                {
                    try
                    {
                        proximo_pedido = Convert.ToInt32(input.retorno);
                    }
                    catch { }
                }
                if (proximo_pedido == 0)
                {
                    proximo_pedido = Convert.ToInt32(ultimo_pedido) + 1;
                }
                // tb_n_ped_novo.Text = proximo_pedido.ToString();

                this.datPedidos_venda.InsertCommand.CommandText =
                   "INSERT INTO PEDIDOS_VENDA (CLIENTE_PED_VENDA, DATA_PED_VENDA, CNPJ_EMISSOR_PED_VENDA, RAZAO_EMISSOR_PED_VENDA, N_PED_VENDA, BOMBAS_PED_VENDA)" +
                   "VALUES ('NOVO', CURRENT_DATE, '" + cnpj_empresa + "','" + razao_social_empresa + "','" + proximo_pedido.ToString() + "',0) RETURNING COD_PED_VENDA";
                this.fbConnection1.Open();
                this.datPedidos_venda.InsertCommand.Connection = fbConnection1;
                int cod_ped = Convert.ToInt32(datPedidos_venda.InsertCommand.ExecuteScalar());
                this.fbConnection1.Close();


                dsPedidos_venda.Clear();
                dsItens_ped_venda.Clear();
                dsFped.Clear();
                this.datPedidos_venda.SelectCommand.CommandText =
                    "SELECT * FROM PEDIDOS_VENDA where cod_ped_venda = '" + cod_ped.ToString() + "'";
                this.fbConnection1.Open();
                this.datPedidos_venda.SelectCommand.Connection = fbConnection1;
                this.datPedidos_venda.SelectCommand.ExecuteNonQuery();
                datPedidos_venda.Fill(PEDIDOS_VENDA);
                this.fbConnection1.Close();


                tb_data_pedido.Text = DateTime.Now.ToShortDateString();
                tb_data_prevista.Text = DateTime.Now.AddDays(60).ToShortDateString();
                tb_pedido_pai.Text = cod_ped.ToString();
                cbStatus.Text = "Aguardando Confirmação";
                novo = true;
                salvar();

            }
            catch
            {
                fbConnection1.Close();
                MessageBox.Show("Erro");
            }
        }

        private string buscar_ultimo_pedido_empresa(string cnpj_empresa)
        {
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                        "SELECT FIRST(1) N_PED_VENDA FROM PEDIDOS_VENDA pv WHERE CNPJ_EMISSOR_PED_VENDA = '" + cnpj_empresa + "' ORDER BY pv.N_PED_VENDA DESC";
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
            catch (Exception a)
            {
                fbConnection1.Close();
                return "0";
            }
        }

        private void bt_localizar_Click(object sender, EventArgs e)
        {
            form_pesquisa_pedido localiza_item = new form_pesquisa_pedido(false, cnpj_empresa);
            try
            {
                localiza_item.consulta = true;
                localiza_item.ShowDialog();
            }
            finally
            {
                localiza_item.Dispose();
                if (localiza_item.cod_ped_escolhido == "")
                { }
                else
                {
                    localizar_pedido(localiza_item.cod_ped_escolhido);
                }

            }
        }

        private void buscar_forma_pgto(string cnpj)
        {
            try
            {
                FbCommand select = new FbCommand();
                select.CommandText =
                    @"SELECT FORMA_PAGAMENTO_CLIENTE, FORMA_PGTO_TABELA_PRECO FROM CLIENTES cli
                    LEFT JOIN TABELA_PRECO tp on cli.COD_TP_CLIENTE = tp.COD_TABELA_PRECO 
                    WHERE CNPJ = '" + cnpj + "'";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.SelectCommand = select;
                datSelect.Fill(dtSelect);

                fbConnection1.Close();
                foreach (DataRow dr in dtSelect.Rows)
                {
                    if (cbDevolucao.Checked)
                    {
                        tb_forma_pgto.Text = "2 - Outros";
                    }
                    else
                    {
                        if (dr[1].ToString() != "")
                        {
                            inserir_nova_forma_pgto(selecionar_cod_forma_pgto(dr[1].ToString()));
                        }
                        if (dr[0].ToString() != "")
                        {
                            inserir_nova_forma_pgto(dr[0].ToString());
                        }
                    }
                }

            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private string selecionar_cod_forma_pgto(string descricao)
        {
            try
            {
                FbCommand select = new FbCommand();
                select.CommandText =
                    "SELECT COD_FORMA_PGTO FROM FORMA_PGTO WHERE DESCRICAO_FORMA_PGTO = '" + descricao + "'";
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
                return "";
            }
            catch
            {
                fbConnection1.Close();
                return "";
            }
        }

        public string _cod_banco, _agencia, _dig_agencia, _cc, _dig_cc, _carteira, _multa, _mora, _dias_protesto, _codigo_no_banco;

        private void definir_banco(int i)
        {

            switch (CodigoBanco)
            {
                case 1: // Banco do Brasil
                    GeraBoletoBB(i);
                    break;

                case 409: // Unibanco
                    GeraBoletoUnibanco(i);
                    break;

                case 347: // Sudameris
                    GeraBoletoSudameris(i);
                    break;

                case 422: // Safra
                    GeraBoletoSafra(i);
                    break;

                case 341: // Itau
                    GeraBoletoItau(i);
                    break;

                case 356: // Real
                    GeraBoletoReal(i);
                    break;

                case 399: // Hsbc
                    GeraBoletoItau(i);
                    break;

                case 237: // Bradesco
                    GeraBoletoBradesco(i);
                    break;

                case 104: // Caixa
                    GeraBoletoCaixa(i);
                    break;

                case 33: // Caixa
                    GeraBoletoSantander(i);
                    break;
            }

        }
        private void selecionar_dados_cliente(string cnpj, out string logradouro, out string bairro, out string cep, out string cidade,
             out string complemento, out string numero, out string uf, out double desconto)
        {
            logradouro = ""; bairro = ""; cep = ""; cidade = ""; complemento = ""; numero = ""; uf = "";
            desconto = 0;
            try
            {
                FbCommand select = new FbCommand();
                select.CommandText =
                    "SELECT * FROM CLIENTES " +
                    " WHERE CNPJ = '" + cnpj + "'";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();
                foreach (DataRow dr in dtSelect.Rows)
                {
                    logradouro = dr["ENDERECO"].ToString();
                    bairro = dr["BAIRRO"].ToString();
                    cep = dr["CEP_CLIENTE"].ToString();
                    cidade = dr["CIDADE"].ToString();
                    complemento = dr["COMPLEMENTO_CLIENTE"].ToString();
                    numero = dr["NUMERO_CLIENTE"].ToString();
                    uf = dr["ESTADO"].ToString();
                    try
                    {
                        desconto = Convert.ToDouble(dr["DESCONTO_PONTUALIDADE_CLIENTE"].ToString());
                    }
                    catch { }
                }


            }
            catch (Exception a)
            {
                fbConnection1.Close();
            }
        }
        #region BOLETO SANTANDER
        public void GeraBoletoSantander(int i)
        {

            // Cria o boleto, e passa os parâmetros usuais
            BoletoBancario bb;

            List<BoletoBancario> boletos = new List<BoletoBancario>();


            bb = new BoletoBancario();
            bb.CodigoBanco = _codigoBanco;
            bb.OcultarInstrucoes = true;
            bb.MostrarComprovanteEntrega = true;
            DateTime vencimento = Convert.ToDateTime(dgvFatura_pedido.Rows[i].Cells["col_data"].Value);

            int dias_protesto = 0;
            try
            {
                dias_protesto = Convert.ToInt32(_dias_protesto);

            }
            catch { }
            Instrucao_Santander item = new Instrucao_Santander(6, dias_protesto);
            if (Convert.ToInt32(_dias_protesto) == 0)
            {
                item = new Instrucao_Santander(7);
            }
            //CEDENTE


            Cedente c = new Cedente(cnpj_empresa, razao_social_empresa, _agencia, _dig_agencia, _cc, _dig_cc);
            c.Codigo = _codigo_no_banco;// "13000";
            c.CodigoTransmissao = _cod_transmissao;
            c.MostrarCNPJnoBoleto = true;

            //cliente
            string logradouro, bairro, cep, cidade, complemento, numero, uf;
            double desconto;
            selecionar_dados_cliente(tb_cnpj_cliente.Text, out logradouro, out bairro, out cep, out cidade, out complemento, out numero, out uf, out desconto);

            Endereco end = new Endereco();
            end.Bairro = bairro;
            end.CEP = cep;
            end.Cidade = cidade;
            end.Complemento = complemento;
            end.End = logradouro + ", " + numero + " - " + complemento;
            //end.Logradouro = logradouro;
            end.Numero = numero;
            end.UF = estado_empresa;

            int cr = Convert.ToInt32(dgvFatura_pedido.Rows[i].Cells["col_cr_fatura"].Value.ToString());
            string nosso_numero = cr.ToString();

            int digito = i + 1;
            Boleto b = new Boleto(vencimento, Convert.ToDecimal(dgvFatura_pedido.Rows[i].Cells["col_valor"].Value.ToString()), _carteira, nosso_numero, c);
            b.NumeroDocumento = nosso_numero;

            b.Sacado = new Sacado(tb_cnpj_cliente.Text, tb_cliente.Text);
            b.Sacado.Endereco = end;
            b.DataDocumento = DateTime.Now;
            item.Descricao += " <br>Carteira 101 - Cobrança Simples Rápida com Registro - RCR<br>";
            item.Descricao += " <br> *** VALORES EXPRESSOS EM REAIS *** <br>";

            //NOVO
            EspecieDocumento especie = new EspecieDocumento(Convert.ToInt32(_cod_banco));
            especie.Codigo = "01";
            b.EspecieDocumento = especie;
            //NOVO

            double mora = Convert.ToDouble(dgvFatura_pedido.Rows[i].Cells["col_valor"].Value.ToString()) * Convert.ToDouble(_mora) / 100;
            double multa = Convert.ToDouble(dgvFatura_pedido.Rows[i].Cells["col_valor"].Value.ToString()) * Convert.ToDouble(_multa) / 100;

            item.Descricao += " MORA DIA/COM. PERMANÊNCIA ................................. " + mora.ToString("n2") + "<br>";
            item.Descricao += " APÓS " + vencimento.ToShortDateString() + " MULTA ................................. " + multa.ToString("n2") + "<br>";
            // item.Descricao += " DEPÓSITO BANCÁRIO NÃO QUITA O BOLETO" + "<br>";

            if (item.QuantidadeDias <= 0)
            {
                item.Descricao += " SUJEITO A PROTESTO" + "<br>";
            }
            else
            {
                item.Descricao += " PROTESTO AUTOMÁTICO APÓS " + item.QuantidadeDias.ToString() + " DIAS" + "<br>";
            }

            b.Instrucoes.Add(item); //"Não Receber após o vencimento");

            bb.Boleto = b;
            bb.Boleto.Valida();

            boletos.Add(bb);

            GeraLayout(boletos);
        }
        #endregion


        private string zero_a_esquerda_santander(int tamanho_pretendido, string valor)
        {
            tamanho_pretendido = tamanho_pretendido; //por causa do 14 na frente (Caixa) 
            int tamanho = valor.Length;
            for (int p = 0; p < tamanho_pretendido - tamanho; p++)
            {
                valor = "0" + valor;
            }

            return valor;
        }

        private void gerar_boletos()
        {
            if (cbStatus.Text != "Confirmado")
            {
                MessageBox.Show("Não é possível gerar boleto de um pedido não Confirmado");
            }
            else
            {
                //BackgroundWorker backgroundWorker = new BackgroundWorker();
                //backgroundWorker.DoWork += new DoWorkEventHandler(backgroundWorker_DoWork);
                //backgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorker_RunWorkerCompleted);
                //backgroundWorker.RunWorkerAsync();
                double prazo = 0;

                for (int i = 0; i < dgvFatura_pedido.RowCount; i++)
                {
                    if (dgvFatura_pedido.Rows[i].Cells["col_cr_fatura"].Value.ToString() != "")
                    {
                        definir_banco(i);
                        imprimir_boleto();
                    }
                    else
                    {
                        MessageBox.Show("Antes de gerar o boleto, é necessário gerar o Contas a Receber");
                    }
                }
                //  _progresso = new Progresso();
                //   _progresso.ShowDialog();
                //gerar_pdf(_arquivo);
            }
            /*
            BackgroundWorker backgroundWorker = new BackgroundWorker();
            backgroundWorker.DoWork += new DoWorkEventHandler(backgroundWorker_DoWork);
            backgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorker_RunWorkerCompleted);
            backgroundWorker.RunWorkerAsync();
            //_progresso = new Progresso();
            //_progresso.ShowDialog();
            */
        }

        private void imprimir_boleto()
        {
            //_progresso.Close();

            // Cria um formulário com um componente WebBrowser dentro

            _impressaoBoleto.webBrowser.Navigate(_arquivo);



            _impressaoBoleto.ShowDialog();
            GerarPdf(_impressaoBoleto.bmp, _impressaoBoleto.n_nf);


        }

        private void GerarPdf(Bitmap bmp, string nf)
        {
            ImageConverter converter = new ImageConverter();
            byte[] _bmp = (byte[])converter.ConvertTo(bmp, typeof(byte[]));
            dsBoleto ds = new dsBoleto();
            ds.Informacoes.AddInformacoesRow(_bmp);
            crBoleto cr = new crBoleto();
            cr.SetDataSource(ds);
            form_imprimir imp = new form_imprimir(cr);
            imp.boleto = true;
            imp.n_nfe = tb_n_pedido.Text;
            imp.imprimir_direto = false;
            imp.Show();

        }

        public short _codigoBanco;
        // private Progresso _progresso;
        string _arquivo = string.Empty;
        private ImpressaoBoleto _impressaoBoleto = new ImpressaoBoleto();

        public short CodigoBanco
        {
            get { return _codigoBanco; }
            set { _codigoBanco = value; }
        }

        private string remover_acentos(string text)
        {
            StringBuilder sbReturn = new StringBuilder();
            var arrayText = text.Normalize(NormalizationForm.FormD).ToCharArray();
            foreach (char letter in arrayText)
            {
                if (CharUnicodeInfo.GetUnicodeCategory(letter) != UnicodeCategory.NonSpacingMark)
                    sbReturn.Append(letter);
            }
            return sbReturn.ToString();
        }


        #region GERA LAYOUT DO BOLETO
        private void GeraLayout(List<BoletoBancario> boletos)
        {
            StringBuilder html = new StringBuilder();
            foreach (BoletoBancario o in boletos)
            {
                html.Append(remover_acentos(o.MontaHtml()));
                //html.Append(o.MontaHtmlNoArquivoLocal("c:\\evolucao\\BOLETOS\\" + tb_n_pedido.Text + ".html"));
                html.Append("</br></br></br></br></br></br></br></br></br></br>");
            }


            //_arquivo = HttpContext.Current.Server.MapPath("/");
            _arquivo = System.IO.Path.GetTempFileName();
            using (FileStream f = new FileStream(_arquivo, FileMode.Create))
            {
                StreamWriter w = new StreamWriter(f, System.Text.Encoding.Default);
                w.Write(html.ToString());
                w.Close();
                f.Close();

            }

            /*
             * string caminho = HttpContext.Current.Server.MapPath("/"); estou gravando no raiz

StringBuilder html = new StringBuilder();
html.Append(bb.MontaHtml());
string boletoPathHTML = System.IO.Path.Combine(caminho, + ".html");
                FileStream f = new FileStream(boletoPathHTML, FileMode.Create);
                using (f)
                {
                    StreamWriter w = new StreamWriter(f, System.Text.Encoding.Default);
                    w.Write(html.ToString());
                    w.Close();
                    f.Close();
                    // System.Diagnostics.Process.Start() ' Exibe o boleto na página
                }
string imagePath = GerarImagem(boletoPathHTML);
                Document doc = new Document(PageSize.A4, 46, 0, 40, 0);
                PdfWriter.GetInstance(doc, new FileStream(boletoPathPDF, FileMode.Create));
                doc.Open();
                iTextSharp.text.Image gif = iTextSharp.text.Image.GetInstance(imagePath);
                gif.ScaleAbsolute(494.0F, 785.0F);
                doc.Add(gif);
                doc.CloseDocument();
                //System.Diagnostics.Process.Start(); // Exibindo o boleto no pdf
                bb.MostrarComprovanteEntrega = false;
             * */

        }
        #endregion


        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //_progresso.Close();

            // Cria um formulário com um componente WebBrowser dentro
            _impressaoBoleto.webBrowser.Navigate(_arquivo);
            _impressaoBoleto.ShowDialog();

        }
        //#endregion Eventos do BackgroundWorker




        #region BOLETO BRADESCO
        public void GeraBoletoBradesco(int i)
        {

            // Cria o boleto, e passa os parâmetros usuais
            BoletoBancario bb;

            List<BoletoBancario> boletos = new List<BoletoBancario>();


            bb = new BoletoBancario();
            bb.CodigoBanco = _codigoBanco;
            bb.OcultarInstrucoes = true;
            bb.MostrarComprovanteEntrega = true;
            DateTime vencimento = Convert.ToDateTime(dgvFatura_pedido.Rows[i].Cells["col_data"].Value);

            Instrucao_Bradesco item = new Instrucao_Bradesco(10, 0);

            //CEDENTE


            Cedente c = new Cedente(cnpj_empresa, razao_social_empresa, _agencia, _dig_agencia, _cc, _dig_cc);
            c.Codigo = _codigo_no_banco;

            //cliente
            string logradouro, bairro, cep, cidade, complemento, numero, uf;
            selecionar_dados_cliente(tb_cnpj_cliente.Text, out logradouro, out bairro, out cep, out cidade, out complemento, out numero, out uf);

            Endereco end = new Endereco();
            end.Bairro = bairro;
            end.CEP = cep;
            end.Cidade = cidade;
            end.Complemento = complemento;
            end.End = logradouro + ", " + numero + " - " + complemento;
            // end.Logradouro = logradouro;
            end.Numero = numero;
            end.UF = estado_empresa;

            string nosso_numero = "";
            DateTime data_nota = Convert.ToDateTime(tb_data_pedido.Text);
            if (data_nota <= Convert.ToDateTime("02.02.2016"))
            {
                nosso_numero = "900000" + tb_n_pedido.Text;
            }
            else
            {//cliente + duplicata + nf(pedido)
                int duplicata = i + 1;
                nosso_numero = duplicata.ToString() + tb_n_pedido.Text;
            }
            int digito = i + 1;
            Boleto b = new Boleto(vencimento, Convert.ToDecimal(dgvFatura_pedido.Rows[i].Cells["col_valor"].Value.ToString()), _carteira, nosso_numero, c);
            b.NumeroDocumento = nosso_numero;
            b.DataDocumento = Convert.ToDateTime(tb_data_pedido.Text);
            b.DataProcessamento = Convert.ToDateTime(tb_data_pedido.Text);

            b.Sacado = new Sacado(tb_cnpj_cliente.Text, tb_cliente.Text);
            b.Sacado.Endereco = end;


            item.Descricao += " *** VALORES EXPRESSOS EM REAIS *** <br>";

            double mora = Convert.ToDouble(dgvFatura_pedido.Rows[i].Cells["col_valor"].Value.ToString()) * Convert.ToDouble(_mora);
            double multa = Convert.ToDouble(dgvFatura_pedido.Rows[i].Cells["col_valor"].Value.ToString()) * Convert.ToDouble(_multa);

            item.Descricao += " MORA DIA/COM. PERMANÊNCIA ................................. " + mora.ToString("n2") + "<br>";
            item.Descricao += " APÓS " + vencimento.ToShortDateString() + " MULTA ................................. " + multa.ToString("n2") + "<br>";
            item.Descricao += " DEPÓSITO BANCÁRIO NÃO QUITA O BOLETO" + "<br>";
            // item.Descricao += " PROTESTO AUTOMÁTICO APÓS " + item.QuantidadeDias.ToString() + " DIAS" + "<br>";
            item.Descricao += " TÍTULO SUJEITO A PROTESTO";
            b.Instrucoes.Add(item); //"Não Receber após o vencimento");

            bb.Boleto = b;
            bb.Boleto.Valida();

            boletos.Add(bb);


            GeraLayout(boletos);
        }

        private void selecionar_dados_cliente(string cnpj, out string logradouro, out string bairro, out string cep, out string cidade,
            out string complemento, out string numero, out string uf)
        {
            logradouro = ""; bairro = ""; cep = ""; cidade = ""; complemento = ""; numero = ""; uf = "";
            try
            {
                FbCommand select = new FbCommand(); select.Connection = fbConnection1;
                select.CommandText =
                    "SELECT ENDERECO, BAIRRO, CEP_CLIENTE, CIDADE, COMPLEMENTO_CLIENTE, NUMERO_CLIENTE, ESTADO FROM CLIENTES " +
                    " WHERE CNPJ = '" + cnpj + "'";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();
                foreach (DataRow dr in dtSelect.Rows)
                {
                    logradouro = dr[0].ToString();
                    bairro = dr[1].ToString();
                    cep = dr[2].ToString();
                    cidade = dr[3].ToString();
                    complemento = dr[4].ToString();
                    numero = dr[5].ToString();
                    uf = dr[6].ToString();
                }

            }
            catch (Exception a)
            {
                fbConnection1.Close();
            }
        }
        #endregion

        #region BOLETO BANCO DO BRASIL
        public void GeraBoletoBB(int i)
        {

            // Cria o boleto, e passa os parâmetros usuais
            BoletoBancario bb;

            List<BoletoBancario> boletos = new List<BoletoBancario>();


            bb = new BoletoBancario();
            bb.CodigoBanco = _codigoBanco;

            DateTime vencimento = new DateTime(2007, 9, 10);
            Cedente c = new Cedente("00.000.000/0000-00", "Empresa de Atacado", "1234", "5", "12345678", "9");

            c.Codigo = "00000000504";
            Boleto b = new Boleto(vencimento, 45.50m, "11", "12345678901", c);

            b.Sacado = new Sacado("000.000.000-00", "Fulano de Silva");
            b.Sacado.Endereco.End = "SSS 154 Bloco J Casa 23";
            b.Sacado.Endereco.Bairro = "Testando";
            b.Sacado.Endereco.Cidade = "Testelândia";
            b.Sacado.Endereco.CEP = "70000000";
            b.Sacado.Endereco.UF = "DF";

            //Adiciona as instruções ao boleto
            //Protestar
            Instrucao_BancoBrasil item = new Instrucao_BancoBrasil(9, 5);
            b.Instrucoes.Add(item);
            //ImportanciaporDiaDesconto
            item = new Instrucao_BancoBrasil(30, 0);
            b.Instrucoes.Add(item);
            //ProtestarAposNDiasCorridos
            item = new Instrucao_BancoBrasil(81, 15);
            b.Instrucoes.Add(item);

            b.NumeroDocumento = "12345678901";

            bb.Boleto = b;
            bb.Boleto.Valida();

            boletos.Add(bb);


            GeraLayout(boletos);
        }
        #endregion

        #region BOLETO Caixa
        private void GeraBoletoCaixa(int i)
        {
            // Cria o boleto, e passa os parâmetros usuais
            BoletoBancario bb;

            List<BoletoBancario> boletos = new List<BoletoBancario>();


            bb = new BoletoBancario();
            bb.CodigoBanco = _codigoBanco;
            bb.MostrarEnderecoCedente = true;
            DateTime vencimento = new DateTime(2010, 2, 28);

            Instrucao_Caixa item1 = new Instrucao_Caixa(9, 5);
            Instrucao_Caixa item2 = new Instrucao_Caixa(81, 10);
            Cedente c = new Cedente("00.000.000/0000-00", "Empresa de Atacado", "0132", "00542");

            Boleto b = new Boleto(vencimento, 460, "SR", "00000000010001", c);
            Endereco endCed = new Endereco();

            endCed.End = "Rua Testando o Boleto";
            endCed.Bairro = "BairroTest";
            endCed.Cidade = "CidadeTes";
            endCed.CEP = "70000000";
            endCed.UF = "MG";
            b.Cedente.Endereco = endCed;

            b.NumeroDocumento = Convert.ToString(1000 + i);

            b.Sacado = new Sacado("000.000.000-00", "Fulano de Silva");
            b.Sacado.Endereco.End = "SSS 154 Bloco J Casa 23ddddddddddddddddddddddddddd";
            b.Sacado.Endereco.Bairro = "Testando";
            b.Sacado.Endereco.Cidade = "Testelândia";
            b.Sacado.Endereco.CEP = "70000000";
            b.Sacado.Endereco.UF = "DF";

            item2.Descricao += " " + item2.QuantidadeDias.ToString() + " dias corridos do vencimento.";
            b.Instrucoes.Add(item1);
            b.Instrucoes.Add(item2);

            // juros/descontos

            if (b.ValorDesconto == 0)
            {
                Instrucao_Caixa item3 = new Instrucao_Caixa(999, 1);
                item3.Descricao += ("1,00 por dia de antecipação.");
                b.Instrucoes.Add(item3);
            }

            bb.Boleto = b;
            bb.Boleto.Valida();

            boletos.Add(bb);


            GeraLayout(boletos);
        }
        #endregion

        #region BOLETO ITAÚ

        private void GeraBoletoItau(int i)
        {
            // Cria o boleto, e passa os parâmetros usuais
            BoletoBancario bb;

            List<BoletoBancario> boletos = new List<BoletoBancario>();
            // for (int i = 0; i < dgvFatura_nf.RowCount; i++)
            // {

            bb = new BoletoBancario();
            bb.CodigoBanco = _codigoBanco;

            bb.OcultarInstrucoes = true;

            DateTime vencimento = Convert.ToDateTime(dgvFatura_pedido.Rows[i].Cells["col_data"].Value);

            //CEDENTE

            Instrucao_Itau item = new Instrucao_Itau(10); //sem protesto

            Cedente c = new Cedente(cnpj_empresa, razao_social_empresa, _agencia, _dig_agencia, _cc, _dig_cc);
            c.Codigo = _codigo_no_banco;// "13000";

            //cliente
            string logradouro, bairro, cep, cidade, complemento, numero, uf;
            double desconto;
            selecionar_dados_cliente(tb_cnpj_cliente.Text, out logradouro, out bairro, out cep, out cidade, out complemento, out numero, out uf, out desconto);
            Instrucao_Itau item3 = new Instrucao_Itau(999, desconto);

            Endereco end = new Endereco();
            end.Bairro = bairro;
            end.CEP = cep;
            end.Cidade = cidade;
            end.Complemento = complemento;
            end.End = logradouro + ", " + numero + " - " + complemento;
            //end.Logradouro = logradouro;
            end.Numero = numero;
            end.UF = estado_empresa;

            //  Cedente c = new Cedente("00.000.000/0000-00", "Empresa de Atacado", "0542", "13000");
            //Na carteira 198 o código do Cedente é a conta bancária
            //c.Codigo = "13000";
            string nosso_numero = "";
            string cliente = "";
            DateTime data_nota = Convert.ToDateTime(tb_data_pedido.Text);

            int duplicata = Convert.ToInt32(dgvFatura_pedido.Rows[i].Cells["col_cr_fatura"].Value.ToString());
            nosso_numero = duplicata.ToString();

            int digito = i + 1;
            Boleto b = new Boleto(vencimento, Convert.ToDecimal(dgvFatura_pedido.Rows[i].Cells["col_valor"].Value.ToString()), _carteira, nosso_numero, c);
            b.NumeroDocumento = nosso_numero;
            b.DataDocumento = Convert.ToDateTime(tb_data_pedido.Text);
            b.DataProcessamento = Convert.ToDateTime(tb_data_pedido.Text);
            b.Sacado = new Sacado(tb_cnpj_cliente.Text, tb_cliente.Text);
            b.Sacado.Endereco = end;




            item.Descricao += " *** VALORES EXPRESSOS EM REAIS *** <br>";

            double mora = 0;
            try
            {
                mora = Convert.ToDouble(dgvFatura_pedido.Rows[i].Cells["col_valor"].Value.ToString()) * Convert.ToDouble(_mora) / 100;
            }
            catch { }
            double multa = 0;
            try
            {
                multa = Convert.ToDouble(dgvFatura_pedido.Rows[i].Cells["col_valor"].Value.ToString()) * Convert.ToDouble(_multa) / 100;
            }
            catch { }

            b.JurosMora = Convert.ToDecimal(mora);
            b.PercJurosMora = Convert.ToDecimal(_mora) * 100;
            b.DataJurosMora = vencimento;

            b.DataMulta = vencimento;
            b.PercMulta = Convert.ToDecimal(_multa);
            // b.ValorMulta = Convert.ToDecimal(multa);

            // Instrucao_Itau item4 = new Instrucao_Itau(999, 1);
            //  item3.Descricao += ("1,00 por dia de antecipação.");
            // b.Instrucoes.Add(item4);
            string descricao_desconto = "";
            if (desconto > 0)
            {

                b.DataDesconto = vencimento;
                decimal _desconto = Convert.ToDecimal(dgvFatura_pedido.Rows[i].Cells["col_valor"].Value.ToString()) * Convert.ToDecimal(desconto) / 100;
                descricao_desconto = " CONCEDER DESCONTO DE R$ " + _desconto.ToString("n2") + " ATÉ DIA: " + vencimento.ToShortDateString();
                b.OutrosDescontos = Convert.ToDecimal(dgvFatura_pedido.Rows[i].Cells["col_valor"].Value.ToString()) * Convert.ToDecimal(desconto) / 100;
                b.DataOutrosDescontos = vencimento;

            }

            item.Descricao += " MORA DIA/COM. PERMANÊNCIA ................................. " + mora.ToString("n2") + "<br>";
            item.Descricao += " APÓS " + vencimento.ToShortDateString() + " MULTA ................................. " + multa.ToString("n2") + "<br>";
            item.Descricao += " DEPÓSITO BANCÁRIO NÃO QUITA O BOLETO" + "<br>";
            // item.Descricao += " PROTESTO AUTOMÁTICO APÓS " + item.QuantidadeDias.ToString() + " DIAS" + "<br>";
            item.Descricao += descricao_desconto;

            b.Instrucoes.Add(item); //"Não Receber após o vencimento");
            if (desconto > 0)
                b.Instrucoes.Add(item3);
            bb.Boleto = b;
            bb.Boleto.Valida();

            boletos.Add(bb);
            // }

            GeraLayout(boletos);
            //   item2.Descricao += " " + item2.QuantidadeDias.ToString() + " dias corridos do vencimento.";
            //  b.Instrucoes.Add(item1);
            // b.Instrucoes.Add(item2);

            // juros/descontos

            //if (b.ValorDesconto == 0)
            //{
            //   Instrucao_Itau item3 = new Instrucao_Itau(999, 1);
            //  item3.Descricao += ("1,00 por dia de antecipação.");
            // b.Instrucoes.Add(item3);
            //}

            // bb.Boleto = b;
            // bb.Boleto.Valida();

            //                 boletos.Add(bb);
            //           }

            //         GeraLayout(boletos);
        }
        #endregion


        #region BOLETO UNIBANCO
        public void GeraBoletoUnibanco(int i)
        {

            // Cria o boleto, e passa os parâmetros usuais
            BoletoBancario bb;

            List<BoletoBancario> boletos = new List<BoletoBancario>();


            bb = new BoletoBancario();
            bb.CodigoBanco = _codigoBanco;

            DateTime vencimento = new DateTime(2007, 9, 10);

            Instrucao instr = new Instrucao(001);
            Cedente c = new Cedente("00.000.000/0000-00", "Next Consultoria Ltda.", "0123", "100618", "9");
            c.Codigo = "203167";

            Boleto b = new Boleto(vencimento, 2952.95m, "20", "1803029901", c);
            b.NumeroDocumento = b.NossoNumero;

            b.Sacado = new Sacado("000.000.000-00", "Marlon Oliveira");
            b.Sacado.Endereco.End = "Rua Dr. Henrique Portugal, XX";
            b.Sacado.Endereco.Bairro = "São Francisco";
            b.Sacado.Endereco.Cidade = "Niterói";
            b.Sacado.Endereco.CEP = "24360080";
            b.Sacado.Endereco.UF = "RJ";
            //  b.Sacado.Endereco.Logradouro = "Rua Dr. Henrique Portugal";
            b.Sacado.Endereco.Numero = "XX";
            b.Sacado.Endereco.Complemento = "Casa";

            instr.Descricao = "Não Receber após o vencimento";
            b.Instrucoes.Add(instr);

            bb.Boleto = b;
            bb.Boleto.Valida();

            boletos.Add(bb);


            GeraLayout(boletos);
        }
        #endregion


        #region BOLETO SUDAMERIS
        public void GeraBoletoSudameris(int i)
        {

            // Cria o boleto, e passa os parâmetros usuais
            BoletoBancario bb;

            List<BoletoBancario> boletos = new List<BoletoBancario>();


            bb = new BoletoBancario();
            bb.CodigoBanco = _codigoBanco;

            DateTime vencimento = new DateTime(2007, 9, 10);
            Instrucao instr = new Instrucao(001);

            Cedente c = new Cedente("00.000.000/0000-00", "Empresa de Atacado", "0501", "6703255");
            c.Codigo = "13000";

            //Nosso número com 7 dígitos
            string nn = "0003020";
            //Nosso número com 13 dígitos
            //nn = "0000000003025";

            Boleto b = new Boleto(vencimento, 1642, "198", nn, c);// EnumEspecieDocumento_Sudameris.DuplicataMercantil);
            b.NumeroDocumento = "1008073";

            b.Sacado = new Sacado("000.000.000-00", "Fulano de Silva");
            b.Sacado.Endereco.End = "SSS 154 Bloco J Casa 23";
            b.Sacado.Endereco.Bairro = "Testando";
            b.Sacado.Endereco.Cidade = "Testelândia";
            b.Sacado.Endereco.CEP = "70000000";
            b.Sacado.Endereco.UF = "DF";

            instr.Descricao = "Não Receber após o vencimento";
            b.Instrucoes.Add(instr);

            bb.Boleto = b;
            bb.Boleto.Valida();

            boletos.Add(bb);


            GeraLayout(boletos);
        }
        #endregion


        #region BOLETO SAFRA
        public void GeraBoletoSafra(int i)
        {

            // Cria o boleto, e passa os parâmetros usuais
            BoletoBancario bb;

            List<BoletoBancario> boletos = new List<BoletoBancario>();


            bb = new BoletoBancario();
            bb.CodigoBanco = _codigoBanco;

            DateTime vencimento = new DateTime(2007, 9, 10);
            Instrucao instr = new Instrucao(001);

            Cedente c = new Cedente("00.000.000/0000-00", "Empresa de Atacado", "0542", "5413000");
            c.Codigo = "13000";

            Boleto b = new Boleto(vencimento, 1642, "198", "02592082835", c);
            b.NumeroDocumento = "1008073";

            b.Sacado = new Sacado("000.000.000-00", "Eduardo Frare");
            b.Sacado.Endereco.End = "SSS 154 Bloco J Casa 23";
            b.Sacado.Endereco.Bairro = "Testando";
            b.Sacado.Endereco.Cidade = "Testelândia";
            b.Sacado.Endereco.CEP = "70000000";
            b.Sacado.Endereco.UF = "DF";

            instr.Descricao = "Não Receber após o vencimento";
            b.Instrucoes.Add(instr);

            bb.Boleto = b;
            bb.Boleto.Valida();
            boletos.Add(bb);


            GeraLayout(boletos);
        }
        #endregion


        #region BOLETO REAL
        public void GeraBoletoReal(int i)
        {

            // Cria o boleto, e passa os parâmetros usuais
            BoletoBancario bb;

            List<BoletoBancario> boletos = new List<BoletoBancario>();


            bb = new BoletoBancario();
            bb.CodigoBanco = _codigoBanco;

            DateTime vencimento = new DateTime(2007, 9, 10);
            Instrucao instr = new Instrucao(001);
            Cedente c = new Cedente("00.000.000/0000-00", "Empresa de Atacado", "0542", "13000");
            c.Codigo = "13000";

            Boleto b = new Boleto(vencimento, 1642, "57", "92082835", c);
            b.NumeroDocumento = "1008073";

            b.Sacado = new Sacado("000.000.000-00", "Fulano de Silva");
            b.Sacado.Endereco.End = "SSS 154 Bloco J Casa 23";
            b.Sacado.Endereco.Bairro = "Testando";
            b.Sacado.Endereco.Cidade = "Testelândia";
            b.Sacado.Endereco.CEP = "70000000";
            b.Sacado.Endereco.UF = "DF";

            instr.Descricao = "Não Receber após o vencimento";
            b.Instrucoes.Add(instr);

            bb.Boleto = b;
            bb.Boleto.Valida();

            boletos.Add(bb);


            GeraLayout(boletos);
        }
        #endregion


        #region BOLETO HSBC
        public void GeraBoletoHsbc(int qtde)
        {

            // Cria o boleto, e passa os parâmetros usuais
            BoletoBancario bb;

            List<BoletoBancario> boletos = new List<BoletoBancario>();
            for (int i = 0; i < qtde; i++)
            {

                bb = new BoletoBancario();
                bb.CodigoBanco = _codigoBanco;

                DateTime vencimento = new DateTime(2007, 9, 10);
                Instrucao instr = new Instrucao(001);
                Cedente c = new Cedente("00.000.000/0000-00", "Minha empresa", "0000", "", "00000", "00");
                // Código fornecido pela agencia, NÃO é o numero da conta
                c.Codigo = "0000000"; // 7 posicoes

                Boleto b = new Boleto(vencimento, 2, "CNR", "888888888", c); //cod documento
                b.NumeroDocumento = "9999999999999"; // nr documento

                b.Sacado = new Sacado("000.000.000-00", "Fulano de Tal");
                b.Sacado.Endereco.End = "lala";
                b.Sacado.Endereco.Bairro = "lala";
                b.Sacado.Endereco.Cidade = "Curitiba";
                b.Sacado.Endereco.CEP = "82000000";
                b.Sacado.Endereco.UF = "PR";

                instr.Descricao = "Não Receber após o vencimento";
                b.Instrucoes.Add(instr);

                bb.Boleto = b;
                bb.Boleto.Valida();

                boletos.Add(bb);
            }

            GeraLayout(boletos);
        }
        #endregion

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {

            switch (CodigoBanco)
            {
                case 1: // Banco do Brasil
                    GeraBoletoBB(1);
                    break;

                case 409: // Unibanco
                    GeraBoletoUnibanco(1);
                    break;

                case 347: // Sudameris
                    GeraBoletoSudameris(1);
                    break;

                case 422: // Safra
                    GeraBoletoSafra(1);
                    break;

                case 341: // Itau
                    GeraBoletoItau(1);
                    break;

                case 356: // Real
                    GeraBoletoReal(1);
                    break;

                case 399: // Hsbc
                    GeraBoletoItau(1);
                    break;

                case 237: // Bradesco
                    GeraBoletoBradesco(1);
                    break;

                case 104: // Caixa
                    GeraBoletoCaixa(1);
                    break;
            }

        }

        private void inserir_nova_forma_pgto(string ja_escolhida)
        {
            if (dgvFatura_pedido.RowCount > 0 && dgvFatura_pedido.Rows[0].Cells["col_cr_fatura"].Value.ToString() != "")
                MessageBox.Show("Já existem Faturas registradas para esse pedido. Para gerar novas faturas você deve cancelá-las antes.");
            else
            {
                if (tb_total_prod.Text != "")
                {

                    form_forma_pgto localiza_forma = new form_forma_pgto();
                    try
                    {
                        localiza_forma.cod_forma_pgto_ja_escolhida = ja_escolhida;
                        localiza_forma.busca_forma_escolhida = true;
                        localiza_forma.ShowDialog();
                    }
                    finally
                    {
                        localiza_forma.Dispose();
                        //MessageBox.Show(localiza_peca.peca_escolhida);
                        tb_forma_pgto.Text = localiza_forma.forma_pgto_escolhida;
                        apaga_faturas_anteriores();
                        acertar_faturas(localiza_forma.n_parcelas, localiza_forma.prazo_1, localiza_forma.prazo_2, localiza_forma.prazo_3,
                                        localiza_forma.prazo_4, localiza_forma.prazo_5, localiza_forma.prazo_6,
                                        localiza_forma.prazo_7, localiza_forma.prazo_8, localiza_forma.prazo_9,
                                        localiza_forma.prazo_10, localiza_forma.prazo_11, localiza_forma.prazo_12);
                        try
                        {
                            dsFped.Clear();
                            this.datFped.SelectCommand.CommandText =
                           "SELECT * FROM FATURA_PEDIDO WHERE N_PEDIDO_FATURA_PED = '" + tb_n_pedido.Text + "'";
                            this.fbConnection1.Open();
                            this.datFped.SelectCommand.Connection = fbConnection1;
                            this.datFped.SelectCommand.ExecuteNonQuery();
                            datFped.Fill(FATURA_PEDIDO);
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
        }
        private void localizar_pedido(string cod)
        {
            try
            {
                dsPedidos_venda.Clear();
                dsItens_ped_venda.Clear();
                this.datPedidos_venda.SelectCommand.CommandText =
                "SELECT * FROM PEDIDOS_VENDA WHERE COD_PED_VENDA = '" + cod + "'";
                this.fbConnection1.Open();
                this.datPedidos_venda.SelectCommand.Connection = fbConnection1;
                this.datPedidos_venda.SelectCommand.ExecuteNonQuery();
                datPedidos_venda.Fill(PEDIDOS_VENDA);
                this.fbConnection1.Close();



                this.datItens_ped_venda.SelectCommand.CommandText =
                "SELECT * FROM ITENS_PEDIDO_VENDA WHERE COD_PEDIDO_ITEM_VENDA = '" + cod + "' ORDER BY COD_ITEM_VENDA";
                this.fbConnection1.Open();
                this.datItens_ped_venda.SelectCommand.Connection = fbConnection1;
                this.datItens_ped_venda.SelectCommand.ExecuteNonQuery();
                datItens_ped_venda.Fill(ITENS_PEDIDO_VENDA);
                this.fbConnection1.Close();

                colocar_numero_nos_itens();

                dsFped.Clear();
                this.datFped.SelectCommand.CommandText =
               "SELECT * FROM FATURA_PEDIDO WHERE N_PEDIDO_FATURA_PED = '" + cod + "'";
                this.fbConnection1.Open();
                this.datFped.SelectCommand.Connection = fbConnection1;
                this.datFped.SelectCommand.ExecuteNonQuery();
                datFped.Fill(FATURA_PEDIDO);
                this.fbConnection1.Close();
                //calcular();
                // if (tb_forma_pgto.Text == "")
                //// {
                //     buscar_forma_pgto(tb_cnpj_cliente.Text);
                // }
                DataRow dr = dsPedidos_venda.Tables[0].Rows[0];
                try
                {
                    int qtd = Convert.ToInt32(dr["QTDE_ITENS_PED_VENDA"].ToString());
                    if (qtd > 0)
                    {
                        if (qtd > dsItens_ped_venda.Tables[0].Rows.Count && !imprimir_direto && !fechar)
                        {
                            MessageBox.Show("Quantidade de itens divergentes, Qtd Cel: " + qtd + ", Qtd Sistema: " + dsItens_ped_venda.Tables[0].Rows.Count +
                                " peça para o vendedor reenviar o pedido");
                        }
                    }
                }
                catch { }
                try
                {
                    tb_time_correto.Text = Convert.ToDateTime(tb_time.Text).ToShortTimeString();
                }
                catch { }
            }
            catch
            {
                fbConnection1.Close();
            }




        }

        private void colocar_numero_nos_itens()
        {
            for (int i = 0; i < dgvItens_nota.RowCount; i++)
            {
                int n = i + 1;
                dgvItens_nota.Rows[i].Cells["col_item"].Value = n.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form_localiza_cliente localiza_cliente = new form_localiza_cliente(true, cnpj_empresa);
            string limite_credito = "";
            try
            {
                localiza_cliente.ShowDialog();
            }
            finally
            {
                localiza_cliente.Dispose();
                tb_cnpj_cliente.Text = localiza_cliente.cnpj_escolhido;
                tb_cliente.Text = localiza_cliente.cliente_escolhido;
                limite_credito = buscar_limite_credito_cliente(tb_cnpj_cliente.Text);
                string _cod, _descricao;
                if (tb_cod_tabela.Text == "")
                {
                    buscar_tabela_preco_cliente(tb_cnpj_cliente.Text, out _cod, out _descricao);
                    tb_cod_tabela.Text = _cod;
                    tb_nome_tabela_preco.Text = _descricao;
                }
                form_busca_contato cont = new form_busca_contato();
                try
                {
                    cont.cod_cli_forn = localiza_cliente.cod_escolhido;
                    cont.cli_forn = "CLIENTE";
                    cont.ShowDialog();
                }
                finally
                {
                    contatotextBox.Text = cont.valores[0, 1];
                    emailtextBox.Text = cont.valores[0, 0];
                    teltextBox.Text = cont.valores[0, 2];
                    buscar_vendedor(tb_cnpj_cliente.Text);
                }
                if (cliente_inadimplente_empresa == "1" && verificar_inadimplencia())
                {
                    tb_cliente.Text = "";
                    tb_cnpj_cliente.Text = "";
                    contatotextBox.Text = "";
                    emailtextBox.Text = "";
                    teltextBox.Text = "";
                    tb_vendedor.Text = "";
                    tb_cod_vendedor.Text = "";
                    MessageBox.Show("Esse cliente está com parcelas atrasadas. Verifique os pagamentos.");
                }
                if (limite_credito != "")
                {
                    double total_aberto = buscar_total_aberto(tb_cliente.Text);
                    if (total_aberto > Convert.ToDouble(limite_credito))
                    {
                        tb_cliente.Text = "";
                        tb_cnpj_cliente.Text = "";
                        contatotextBox.Text = "";
                        emailtextBox.Text = "";
                        teltextBox.Text = "";
                        tb_vendedor.Text = "";
                        tb_cod_vendedor.Text = "";
                        MessageBox.Show("O limite de crédito é menor que o valor pendente a pagar. Verifique o limite de crédito.");
                    }
                }
                //tb_dados_adicionais.Text = "#C.FISC.: " + tb_class_fiscal.Text + "#" + tb_dados_adicionais.Text;

            }
        }

        private void buscar_tabela_preco_cliente(string cnpj, out string cod, out string descricao)
        {
            cod = "";
            descricao = "";
            try
            {
                FbCommand select = new FbCommand();
                select.CommandText =
                    "SELECT COD_TP_CLIENTE, DESCRICAO_TP_CLIENTE FROM CLIENTES WHERE CNPJ = '" + cnpj + "'";
                select.Connection = fbConnection1;
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();
                foreach (DataRow dr in dtSelect.Rows)
                {
                    cod = dr[0].ToString();
                    descricao = dr[1].ToString();
                }
            }
            catch (Exception a)
            {
                fbConnection1.Close();
            }
        }

        private double buscar_total_aberto(string razao)
        {
            double total = 0;
            try
            {
                FbCommand sel = new FbCommand();
                FbDataAdapter datSel = new FbDataAdapter();
                DataTable dt = new DataTable();
                sel.Connection = fbConnection1;
                sel.CommandText =
                    "SELECT VALOR_CR FROM CONTAS_A_RECEBER WHERE RAZAO_CLIENTE_CR = '" + razao + "' " +
                    "AND RECEBIDO_CR IS NULL AND DATA_PREVISTA_CR >= CURRENT_DATE";
                datSel.SelectCommand = sel;
                fbConnection1.Open();
                datSel.Fill(dt);
                fbConnection1.Close();
                foreach (DataRow dr in dt.Rows)
                {
                    total = total + Convert.ToDouble(dr[0].ToString());
                }
                return total;
            }
            catch
            {
                fbConnection1.Close();
                return total;
            }
        }

        private string buscar_limite_credito_cliente(string cnpj)
        {
            string limite_credito = "";
            try
            {
                FbCommand sel = new FbCommand();
                FbDataAdapter datSel = new FbDataAdapter();
                DataTable dt = new DataTable();
                sel.Connection = fbConnection1;
                sel.CommandText = "SELECT LIMITE_CREDITO_CLIENTE FROM CLIENTES WHERE CNPJ = '" + cnpj + "'";
                datSel.SelectCommand = sel;
                fbConnection1.Open();
                datSel.Fill(dt);
                fbConnection1.Close();
                foreach (DataRow dr in dt.Rows)
                {
                    limite_credito = dr[0].ToString();
                    return limite_credito;
                }
                return limite_credito;
            }
            catch
            {
                fbConnection1.Close();
                return limite_credito;
            }

        }

        private void buscar_vendedor(string cnpj)
        {
            try
            {
                FbCommand select = new FbCommand();
                select.CommandText =
                    "SELECT v.COD_VENDEDOR_VC, v.NOME_VENDEDOR_VC, c.COD_TP_CLIENTE, C.DESCRICAO_TP_CLIENTE FROM CLIENTES c " +
                    " INNER JOIN VENDEDORES_CLIENTE v on c.COD_CLIENTE = v.COD_CLIENTE_VC " +
                    " WHERE c.CNPJ = '" + cnpj + "'";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.SelectCommand = select;
                datSelect.Fill(dtSelect);

                fbConnection1.Close();
                foreach (DataRow dr in dtSelect.Rows)
                {
                    tb_cod_vendedor.Text = dr[0].ToString();
                    tb_vendedor.Text = dr[1].ToString();
                    tb_cod_tabela.Text = dr[2].ToString();
                    tb_nome_tabela_preco.Text = dr[3].ToString();

                }

            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            fechar_pedido();
        }

        private void fechar_pedido()
        {

            if (verificar_se_precisa_de_autorizacao())
            {
                if (verificarDuplicidadeItemPedidoCompleto() == false)
                {
                    if (!verificar_se_valor_pedido_igual_valor_boletos())
                    {
                        MessageBox.Show("Os valores do pedido não batem com os valores das duplicatas. Verifique.");
                    }
                    else
                    {
                        List<Modelos.ModeloProduto> prod = new List<Modelos.ModeloProduto>();
                                    
                        if (!verificar_se_todos_os_codigos_estao_preenchidos(out prod))
                        {
                          //  MessageBox.Show("Existem códigos de produto e Cliente em Branco. Verifique.");

                            if (DialogResult.Yes == MessageBox.Show("Existem códigos de produto e/ou Cliente em Branco. Gostaria de Cadastrar? ",
                        "Confirmação", MessageBoxButtons.YesNo))
                            {
                                //  dgvItens_nota.Rows[i].Cells["col_cod_forn"].Value.ToString() == "" ||
                                // dgvItens_nota.Rows[i].Cells["col_cod"].Value.ToString() == ""
                                try
                                {
                                    foreach (Modelos.ModeloProduto _prod in prod)
                                    {
                                        FbCommand insert = new FbCommand();
                                        FbCommand update = new FbCommand();
                                        try
                                        {

                                            insert.CommandText =
                                                @"INSERT INTO PRODUTOS (COD_FORNECEDOR_PRODUTO, DESCRICAO_PRODUTO, COD_UNIDADE_PRODUTO, NCM_PRODUTO, STATUS_PRODUTO) values 
                                                    ('" + _prod.COD_FORNECEDOR_PRODUTO + "','" + _prod.DESCRICAO_PRODUTO + "','" + _prod.COD_UNIDADE_PRODUTO + "','" +
                                                        _prod.NCM_PRODUTO + "','1') returning cod_produto";
                                            insert.Connection = fbConnection1;
                                            fbConnection1.Open();
                                            FbDataAdapter datInsert = new FbDataAdapter();
                                            datInsert.InsertCommand = insert;
                                            object codProd = datInsert.InsertCommand.ExecuteScalar();
                                            fbConnection1.Close();


                                            update.CommandText =
                                                @"UPDATE ITENS_PEDIDO_VENDA SET COD_SISTEMA_PROD_ITEM_VENDA = '" + codProd.ToString() + "' WHERE COD_ITEM_VENDA = '" + _prod.COD_ITEM_PEDIDO + "'";
                                            update.Connection = fbConnection1;
                                            fbConnection1.Open();
                                            FbDataAdapter datUpdate = new FbDataAdapter();
                                            datUpdate.UpdateCommand = update;
                                            datUpdate.UpdateCommand.ExecuteNonQuery();
                                            fbConnection1.Close();

                                            try
                                            {
                                                form_produto _prod1 = new form_produto(cnpj_empresa);
                                                bool erro = false;
                                                _prod1.modificar = true;
                                                _prod1.cod_prod = codProd.ToString();
                                                _prod1.ShowDialog();
                                            }
                                            finally
                                            {
                                                selecionar_itens();
                                            }

                                        }
                                        catch(Exception ex)
                                        {
                                            fbConnection1.Close();
                                            MessageBox.Show(ex.Message);
                                        }
                                    }
                                }
                                catch (Exception ex)
                                {
                                    fbConnection1.Close();
                                    MessageBox.Show(ex.Message);
                                }
                            }
                       
                        }
                        else
                        {
                            string[] cods = new string[200]; int numero_acima = 0;
                            bool preco_abaixo = verificar_precos_abaixo(out cods, out numero_acima);
                            bool liberado = false;
                            string limite_credito = buscar_limite_credito_cliente(tb_cnpj_cliente.Text);
                            if (limite_credito == "")
                            {
                                limite_credito = "99999999";
                            }

                            if (preco_abaixo)
                            {
                                if (DialogResult.Yes == MessageBox.Show("Existem preços que estão abaixo do preço mínimo. \n É necessário colocar uma senha para essa situação.",
                         "Confirmação", MessageBoxButtons.YesNo))
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
                                            if (usuario._cod_usuario == "1" || usuario._cod_usuario == "2" || usuario._cod_usuario == "4")
                                            {
                                                liberado = true;
                                            }
                                        }
                                    }
                                }

                            }

                            if (liberado || !preco_abaixo)
                            {
                                if (cbStatus.Text != "Confirmado")
                                {
                                    if (cliente_inadimplente_empresa == "1" && verificar_inadimplencia())
                                    {
                                        MessageBox.Show("Esse cliente está com parcelas atrasadas. Impossível fechar o pedido");
                                    }
                                    else
                                    {
                                        double total_aberto = buscar_total_aberto(tb_cliente.Text) + Convert.ToDouble(tb_total_pedido.Text);
                                        if (total_aberto > Convert.ToDouble(limite_credito))
                                        {
                                            MessageBox.Show("O limite de crédito é menor que o valor pendente a pagar. Verifique o limite de crédito.");
                                        }
                                        else
                                        {
                                            //if (MessageBox.Show("Tem certeza que deseja fechar o pedido?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                                            // {
                                            DataTable dtItens = new DataTable();
                                            if (verificar_se_existe_estoque(out dtItens))
                                            {
                                                form_corte_estoque est = new form_corte_estoque();
                                                est.dtItens = dtItens;
                                                try
                                                {

                                                    est.ShowDialog();
                                                }
                                                finally
                                                {
                                                    retirar_itens_do_pedido(est.retorno);
                                                    calcular();
                                                    if (fechar) //se for fechamento automatico
                                                    {
                                                        if (tb_forma_pgto.Text == "")
                                                        {
                                                            buscar_forma_pgto(tb_cnpj_cliente.Text);
                                                        }
                                                        //if (boleto_pedido_empresa == "1")
                                                        //    inserir_duplicatas_cr();
                                                        calcular();
                                                        tb_data_entrega_realizada.Text = DateTime.Now.ToShortDateString();
                                                        cbStatus.Text = "Confirmado";
                                                        confirmar_todos_itens();
                                                        salvar();
                                                        baixar_do_estoque();
                                                    }

                                                }

                                            }
                                            else
                                            {
                                                if (tb_forma_pgto.Text == "")
                                                {
                                                    buscar_forma_pgto(tb_cnpj_cliente.Text);
                                                }
                                                //if (boleto_pedido_empresa == "1")
                                                //    inserir_duplicatas_cr();
                                                calcular();
                                                tb_data_entrega_realizada.Text = DateTime.Now.ToShortDateString();
                                                cbStatus.Text = "Confirmado";
                                                confirmar_todos_itens();
                                                salvar();
                                                baixar_do_estoque();
                                            }
                                            // }
                                        }
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Este pedido já foi confirmado!");
                                }
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Existem itens duplicados no pedido, por favor verifique!");
                }
            }
            else
            {
                MessageBox.Show("Esse pedido precisa de autorização, por favor verifique!");
            }

        }

        private void confirmar_todos_itens()
        {
            try
            {
                FbCommand update = new FbCommand();
                update.Connection = fbConnection1;
                update.CommandText = "UPDATE ITENS_PEDIDO_VENDA SET CONFIRMADO_ITEM_VENDA = 1 WHERE COD_PEDIDO_ITEM_VENDA = '" + tb_n_pedido.Text + "'";
                fbConnection1.Open();
                FbDataAdapter datUpdate = new FbDataAdapter();
                datUpdate.UpdateCommand = update;
                datUpdate.UpdateCommand.ExecuteNonQuery();
                fbConnection1.Close();
                selecionar_itens();

            }
            catch(Exception ex)
            {
                fbConnection1.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void desconfirmar_todos_itens()
        {
            try
            {
                FbCommand update = new FbCommand();
                update.Connection = fbConnection1;
                update.CommandText = "UPDATE ITENS_PEDIDO_VENDA SET CONFIRMADO_ITEM_VENDA = null WHERE COD_PEDIDO_ITEM_VENDA = '" + tb_n_pedido.Text + "'";
                fbConnection1.Open();
                FbDataAdapter datUpdate = new FbDataAdapter();
                datUpdate.UpdateCommand = update;
                datUpdate.UpdateCommand.ExecuteNonQuery();
                fbConnection1.Close();
                selecionar_itens();

            }
            catch (Exception ex)
            {
                fbConnection1.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private bool verificar_se_precisa_de_autorizacao()
        {
            if ((razao_social_empresa.ToUpper().Contains("DALE")))
            {
                bool _retorno = false;
                if (DialogResult.Yes == MessageBox.Show("Essa operação irá fechar o Pedido. Tem certeza?",
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
                            if (usuario._cod_usuario == "1" || usuario._cod_usuario == "4")
                            {
                                _retorno = true;
                            }
                        }
                    }
                }
                return _retorno;
            }
            else
            {
                return true;
            }
        }

        private bool verificar_se_valor_pedido_igual_valor_boletos()
        {
            try
            {
                if (tb_forma_pgto.Text[0].ToString() == "2")
                    return true;
                else if (tb_forma_pgto.Text[0].ToString() == "0")
                    return true;
                else
                {
                    double soma = 0;
                    for (int i = 0; i < dgvFatura_pedido.RowCount; i++)
                    {
                        try
                        {
                            soma += Convert.ToDouble(dgvFatura_pedido.Rows[i].Cells["col_valor"].Value.ToString());
                        }
                        catch { }
                    }
                    // if (razao_social_empresa.ToUpper().Contains("DEBORA") || razao_social_empresa.ToUpper().Contains("DANIEL"))
                    //  {
                    double valor_pedido = Convert.ToDouble(tb_total_pedido.Text);// Convert.ToDecimal(tb_total_prod.Text) - Convert.ToDecimal(tb_valor_desconto.Text);
                    if (soma == valor_pedido)
                    {

                        return true;
                    }
                    else
                    {
                        if ((valor_pedido + 0.02) >= soma && valor_pedido - 0.02 <= soma)
                            return true;
                        else
                            return false;
                    }
                    // }
                    /*
                    else
                    {
                        if (soma == Convert.ToDecimal(tb_total_pedido.Text))
                        {

                            return true;
                        }
                        else
                        {
                            if (Convert.ToDecimal(tb_total_pedido.Text) + 1 >= soma && Convert.ToDecimal(tb_total_pedido.Text) - 1 <= soma)
                                return true;
                            else
                                return false;
                        }
                     
                    }* */
                }

            }
            catch { return false; }


        }

        private bool verificar_se_todos_os_codigos_estao_preenchidos(out List<Modelos.ModeloProduto> listProd)
        {
            listProd = new List<Modelos.ModeloProduto>();
            bool retorno = true;
            for (int i = 0; i < dgvItens_nota.RowCount; i++)
            {
                if (dgvItens_nota.Rows[i].Cells["col_cod_forn"].Value.ToString() == "" ||
                    dgvItens_nota.Rows[i].Cells["col_cod"].Value.ToString() == "")
                {
                    Modelos.ModeloProduto prod = new Modelos.ModeloProduto();
                    prod.COD_FORNECEDOR_PRODUTO = dgvItens_nota.Rows[i].Cells["col_cod_forn"].Value.ToString();
                    prod.DESCRICAO_PRODUTO = dgvItens_nota.Rows[i].Cells["col_descricao"].Value.ToString();
                    prod.UNIDADE_PRODUTO = dgvItens_nota.Rows[i].Cells["col_unidade"].Value.ToString();
                    prod.COD_ITEM_PEDIDO = dgvItens_nota.Rows[i].Cells["col_cod_item_venda"].Value.ToString();
                    prod.NCM_PRODUTO = "99999999";
                    //falta finalizar a inserção no Modelo e retornar para inserção

                    listProd.Add(prod);
                    
                    retorno = false;
                    return retorno;
                }
            }
            return true;
        }

        private bool verificar_precos_abaixo(out string[] cods, out int numero)
        {
            bool retorno = false;
            cods = new string[200];
            numero = 0;
            for (int i = 0; i < dgvItens_nota.Rows.Count; i++)
            {
                try
                {
                    string _valor = dgvItens_nota.Rows[i].Cells["col_valor_unit"].Value.ToString();
                    double valor_unit = Convert.ToDouble(_valor);
                    double valor_produto = Convert.ToDouble(buscar_preco_produto_item(dgvItens_nota.Rows[i].Cells["col_cod"].Value.ToString()));
                    if (valor_unit < valor_produto)
                    {
                        cods[numero] = dgvItens_nota.Rows[i].Cells["col_cod"].Value.ToString();
                        numero++;
                        dgvItens_nota.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                        retorno = true;
                    }

                }
                catch { }
            }
            return retorno;
        }

        private bool verificar_inadimplencia()
        {
            try
            {
                /*
                 * "SELECT cr.COD_CLIENTE_CR, cr.DATA_PREVISTA_CR FROM CONTAS_A_RECEBER cr " +
                    " INNER JOIN FORMA_PGTO fp ON cr.FORMA_PGTO_CR = fp.DESCRICAO_FORMA_PGTO " + 
                    "WHERE (cr.RECEBIDO_CR IS NULL OR cr.RECEBIDO_CR = 0) " +
                    "AND fp.BOLETO_FORMA_PGTO = 1 " +
                    "and cr.DATA_PREVISTA_CR < CURRENT_DATE";*/
                FbCommand select = new FbCommand();
                select.CommandText =
                    "SELECT cr.COD_CLIENTE_CR, cr.DATA_PREVISTA_CR FROM CONTAS_A_RECEBER cr " +
                    " INNER JOIN FORMA_PGTO fp ON cr.FORMA_PGTO_CR = fp.DESCRICAO_FORMA_PGTO " +
                    "WHERE COD_CLIENTE_CR = '" +
                    detectar_cod_cliente(tb_cnpj_cliente.Text) + "' AND (cr.RECEBIDO_CR IS NULL OR cr.RECEBIDO_CR = 0) " +
                    "AND fp.BOLETO_FORMA_PGTO = 1 " +
                    "and cr.DATA_PREVISTA_CR < CURRENT_DATE";
                //"SELECT * FROM CONTAS_A_RECEBER WHERE COD_CLIENTE_CR = '" + 
                //detectar_cod_cliente(tb_cnpj_cliente.Text) + "' AND (RECEBIDO_CR IS NULL OR RECEBIDO_CR = 0) AND " + 
                //"DATA_PREVISTA_CR < CURRENT_DATE";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();
                foreach (DataRow dr in dtSelect.Rows)
                {
                    try
                    {
                        bool inadimplente = true;
                        if ((Convert.ToDateTime(dr[1].ToString()).DayOfWeek == DayOfWeek.Saturday ||
                            Convert.ToDateTime(dr[1].ToString()).DayOfWeek == DayOfWeek.Sunday) && DateTime.Now.DayOfWeek == DayOfWeek.Monday)
                        {
                            inadimplente = false;
                        }
                        if (inadimplente)
                        {
                            return true;
                        }
                    }
                    catch { }
                }
                return false;
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                return false;
            }
        }

        private void retirar_itens_do_pedido(DataTable dataTable)
        {
            foreach (DataRow dr in dataTable.Rows)
            {
                try
                {
                    //inserindo_tabela_de_exclusoes
                    FbCommand insert = new FbCommand();
                    insert.CommandText =
                        "INSERT INTO DESCARTE_PEDIDO_VENDA (COD_ITEM_PEDIDO_DPV, QTDE_DPV, REINSERIDO_DPV) " +
                        "VALUES ('" + dr[0].ToString() + "',null,'0')";
                    insert.Connection = fbConnection1;
                    fbConnection1.Open();
                    FbDataAdapter datInsert = new FbDataAdapter();
                    datInsert.InsertCommand = insert;
                    datInsert.InsertCommand.ExecuteNonQuery();
                    fbConnection1.Close();

                    string _dun, _qtde, _cnpj, _cod, cod;
                    _cod = buscar_cod_produto_item(dr[0].ToString());
                    string ean = buscar_ean_produto(_cod, out _dun, out _qtde, out _cnpj, out cod);

                    FbCommand delete = new FbCommand();
                    delete.CommandText =
                        "DELETE FROM ITENS_PEDIDO_VENDA WHERE COD_ITEM_VENDA = '" + dr[0].ToString() + "'";
                    delete.Connection = fbConnection1;
                    fbConnection1.Open();
                    FbDataAdapter datDelete = new FbDataAdapter();
                    datDelete.DeleteCommand = delete;
                    datDelete.DeleteCommand.ExecuteNonQuery();
                    fbConnection1.Close();



                    try
                    {
                        classeEstoque estoque = new classeEstoque();
                        estoque.fbConnection1.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=10.3.3.4;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=True;Packet Size=8192;Server Type=0";
                        estoque.calcular_estoque(dr[0].ToString());
                    }
                    catch { }


                }
                catch (Exception a)
                {
                    fbConnection1.Close();
                    MessageBox.Show(a.ToString());
                }


            }
            selecionar_itens();


        }

        private string buscar_preco_produto_item(string cod_item_venda)
        { //ITENS_PEDIDO_VENDA WHERE COD_ITEM_VENDA = '" + dr[0].ToString() + "'"
            try
            {
                try
                {
                    FbCommand select_tabela = new FbCommand();
                    select_tabela.CommandText =
                        "SELECT itp.PRECO_MINIMO_ITEM_TP FROM ITENS_TP itp " +
                        "INNER JOIN CLIENTES cli ON itp.COD_TABELA_ITEM_TP = cli.COD_TP_CLIENTE " +
                        "WHERE COD_PRODUTO_ITEM_TP = '" + cod_item_venda + "' AND cli.CNPJ = '" + tb_cnpj_cliente.Text + "'";
                    select_tabela.Connection = fbConnection1;
                    fbConnection1.Open();
                    FbDataAdapter datSelect_tabela = new FbDataAdapter();
                    datSelect_tabela.SelectCommand = select_tabela;
                    DataTable dtSelect_tabela = new DataTable();
                    datSelect_tabela.Fill(dtSelect_tabela);
                    fbConnection1.Close();
                    foreach (DataRow dr in dtSelect_tabela.Rows)
                    {
                        return dr[0].ToString();
                    }
                }

                catch { fbConnection1.Close(); }
                try
                {
                    FbCommand select = new FbCommand();
                    select.CommandText =
                        "SELECT VALOR_PROMOCAO_PRODUTO FROM PRODUTOS WHERE COD_PRODUTO = '" + cod_item_venda + "'";
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
                }
                catch
                {
                    fbConnection1.Close();
                }
                return "0";

            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
                return "0";
            }
        }

        private string buscar_cod_produto_item(string cod_item_venda)
        { //ITENS_PEDIDO_VENDA WHERE COD_ITEM_VENDA = '" + dr[0].ToString() + "'"
            try
            {
                FbCommand select = new FbCommand();
                select.CommandText =
                    "SELECT COD_SISTEMA_PROD_ITEM_VENDA FROM ITENS_PEDIDO_VENDA WHERE COD_ITEM_VENDA = '" + cod_item_venda + "'";
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
                return "0";

            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
                return "0";
            }
        }

        private void selecionar_itens()
        {
            try
            {
                dsItens_ped_venda.Clear();
                this.datItens_ped_venda.SelectCommand.CommandText =
                "SELECT * FROM ITENS_PEDIDO_VENDA WHERE COD_PEDIDO_ITEM_VENDA = '" + tb_n_pedido.Text + "'";
                this.fbConnection1.Open();
                this.datItens_ped_venda.SelectCommand.Connection = fbConnection1;
                this.datItens_ped_venda.SelectCommand.ExecuteNonQuery();
                datItens_ped_venda.Fill(ITENS_PEDIDO_VENDA);
                this.fbConnection1.Close();
                colocar_numero_nos_itens();
            }
            catch (Exception a)
            {
                fbConnection1.Close();
            }
        }

        private bool verificar_se_existe_estoque(out DataTable itens)
        {
            bool retorno = false;

            DataTable dt = new DataTable();
            itens = dt;

            //DataTable cnpjs = new DataTable();
            DataColumn novaColuna = new DataColumn();
            itens.Columns.Add(novaColuna);
            DataColumn novaColuna2 = new DataColumn();
            itens.Columns.Add(novaColuna2);
            DataColumn novaColuna3 = new DataColumn();
            itens.Columns.Add(novaColuna3);
            DataColumn novaColuna4 = new DataColumn();
            itens.Columns.Add(novaColuna4);

            //itens.Rows.Add("");

            for (int i = 0; i < dgvItens_nota.RowCount; i++)
            {
                try
                {
                    FbCommand select = new FbCommand();
                    select.CommandText =
                        "SELECT CORTAR_SEM_ESTOQUE_PRODUTO, ESTOQUE_ATUAL_PRODUTO, ESTOQUE_DISPONIVEL_PRODUTO, ESTOQUE_RESERVA_FECHADA_PRODUTO  " +
                        "FROM PRODUTOS WHERE COD_PRODUTO = '" + dgvItens_nota.Rows[i].Cells["col_cod"].Value.ToString() + "'";
                    select.Connection = fbConnection1;
                    fbConnection1.Open();
                    FbDataAdapter datSelect = new FbDataAdapter();
                    datSelect.SelectCommand = select;
                    DataTable dtSelect = new DataTable();
                    datSelect.Fill(dtSelect);
                    fbConnection1.Close();
                    foreach (DataRow dr in dtSelect.Rows)
                    {
                        double estoque_atual = 0, qtde_pedido = 0, estoque_disponivel = 0, estoque_reserva_fechada = 0;
                        /*
                         if (cnpj_empresa == "01109364000177")
                         {
                             try
                             {
                                 estoque_atual = Convert.ToDouble(dr[1].ToString());
                             }
                             catch { }
                             try
                             {
                                 qtde_pedido = Convert.ToDouble(dgvItens_nota.Rows[i].Cells["col_qtde"].Value.ToString());
                             }
                             catch { }

                             if (dr[0].ToString() == "1")
                             {
                                 if (qtde_pedido > estoque_atual)
                                 {
                                     itens.Rows.Add(dgvItens_nota.Rows[i].Cells["col_cod_item_venda"].Value.ToString(), dr[1].ToString());
                                     retorno = true;
                                 }
                             }
                         }
                         else
                         {
                         * */
                        // double estoque_disponivel = 0, qtde_pedido = 0;
                        try
                        {
                            qtde_pedido = Convert.ToDouble(dgvItens_nota.Rows[i].Cells["col_qtde"].Value.ToString());
                        }
                        catch { }

                        try
                        {
                            estoque_atual = Convert.ToDouble(dr[1].ToString());
                        }
                        catch { }

                        double reserva_fechada_mais_pedido = 0;
                        try
                        {
                            estoque_disponivel = Convert.ToDouble(dr[2].ToString());
                        }
                        catch { }
                        try
                        {
                            estoque_reserva_fechada = Convert.ToDouble(dr[3].ToString());
                            reserva_fechada_mais_pedido = estoque_reserva_fechada + qtde_pedido;
                        }
                        catch { }
                        //CALCULANDO O DISPONIVEL COM FECHADA
                        double disponivel_com_fechada = 0;
                        try
                        {
                            disponivel_com_fechada = estoque_atual - estoque_reserva_fechada;
                        }
                        catch { }
                        if (dr[0].ToString() == "1")
                        {
                            if (reserva_fechada_mais_pedido > estoque_atual)
                            {
                                itens.Rows.Add(dgvItens_nota.Rows[i].Cells["col_cod_item_venda"].Value.ToString(), dr[1].ToString(), disponivel_com_fechada.ToString("n2"), dr[3].ToString());
                                retorno = true;
                            }
                        }
                        // }
                    }
                }
                catch (Exception a)
                {
                    fbConnection1.Close();
                   // MessageBox.Show(a.ToString());
                }

            }
            return retorno;
        }
        private void apagar_itens_cr()
        {
            try
            {


                this.datContas_a_receber.UpdateCommand.CommandText =
                "UPDATE CONTAS_A_RECEBER SET CANCELADO_CR = 1, OBSERVACOES_CR = 'CANCELADA PELO PEDIDO' WHERE NF_CR = '" + tb_n_pedido.Text + "' AND ORIGEM_CR = 'PEDIDO'";
                this.fbConnection1.Open();
                this.datContas_a_receber.UpdateCommand.Connection = fbConnection1;
                this.datContas_a_receber.UpdateCommand.ExecuteNonQuery();
                this.fbConnection1.Close();

                FbCommand update = new FbCommand();
                update.Connection = fbConnection1;
                update.CommandText =
                "UPDATE FATURA_PEDIDO SET CR_FATURA_PED = NULL WHERE N_PEDIDO_FATURA_PED = '" + tb_n_pedido.Text + "'";
                fbConnection1.Open();
                FbDataAdapter datUpdate = new FbDataAdapter();
                datUpdate.UpdateCommand = update;
                datUpdate.UpdateCommand.ExecuteNonQuery();
                fbConnection1.Close();



            }
            catch (Exception a)
            {
                fbConnection1.Close();
            }
        }

        private void inserir_duplicatas_cr()
        {
            apagar_itens_cr();
            int _n_vencimentos;
            //a parada é 6 pois é o numero máximo de parcelas
            for (int i = 0; i < 6; i++)
            {
                _cod[i] = ""; _datas[i] = ""; _valores[i] = "";
            }
            detectar_numero_vencimentos_fatura(out _n_vencimentos);

            for (int i = 0; i < _n_vencimentos; i++)
            {
                try
                {
                    int parcela_n = i + 1;
                    this.datContas_a_receber.InsertCommand.CommandText =
                    "INSERT INTO CONTAS_A_RECEBER (VALOR_CR, DATA_PREVISTA_CR, COD_CLIENTE_CR, " +
                    "RAZAO_CLIENTE_CR, DESCRICAO_CR, DUPLICATA_CR, NF_CR, ORIGEM_CR, FORMA_PGTO_CR, STATUS_CR) " +
                    "VALUES ('" + _valores[i].Replace(".", "").Replace(",", ".") + "', '" + Convert.ToDateTime(_datas[i]).ToShortDateString().Replace("/", ".") +
                    "', '" + detectar_cod_cliente(tb_cnpj_cliente.Text) + "','" + tb_cliente.Text +
                    "', 'PARCELA " + parcela_n.ToString() + "/" + _n_vencimentos.ToString() + " REF. AO PEDIDO Nº " + tb_n_ped_novo.Text + 
                    "', '" + parcela_n.ToString() + "','" + tb_n_pedido.Text + "','PEDIDO', '" + tb_forma_pgto.Text + "','PROVISIONADO') RETURNING COD_CR";
                    this.fbConnection1.Open();
                    this.datContas_a_receber.InsertCommand.Connection = fbConnection1;
                    object _cod_cr = datContas_a_receber.InsertCommand.ExecuteScalar();
                    this.fbConnection1.Close();

                    update_cr_fatura(_cod[i], _cod_cr);
                }
                catch
                {
                    MessageBox.Show("Erro na inserção da duplicata " + _cod[i].ToString());
                    fbConnection1.Close();
                }
            }
            selecionar_faturas();

        }

        private void selecionar_faturas()
        {
            try
            {
                dsFped.Clear();
                dsFatura_nf.Clear();
                FbCommand select = new FbCommand();
                select.CommandText = "SELECT * FROM FATURA_PEDIDO WHERE  N_PEDIDO_FATURA_PED = '" + tb_n_pedido.Text + "'";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                datSelect.Fill(FATURA_PEDIDO);
                fbConnection1.Close();

            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private void update_cr_fatura(string cod_fatura, object _cod_cr)
        {
            try
            {
                FbCommand update = new FbCommand();
                update.Connection = fbConnection1;
                fbConnection1.Open();
                update.CommandText =
                    "UPDATE FATURA_PEDIDO SET CR_FATURA_PED = '" + _cod_cr.ToString() + "' WHERE COD_FATURA_PED = '" + cod_fatura + "'";
                FbDataAdapter datUpdate = new FbDataAdapter();
                datUpdate.UpdateCommand = update;
                datUpdate.UpdateCommand.ExecuteNonQuery();
                fbConnection1.Close();
            }
            catch (Exception a)
            {
                fbConnection1.Close();
            }
        }

        private string detectar_cod_cliente(string _cnpj)
        {
            string _cod = "0";
            try
            {
                comando_select.CommandText = "SELECT * " +
                    "FROM CLIENTES WHERE CNPJ = '" + _cnpj + "'";
                DataSet nf = new DataSet();
                fbConnection1.Open();
                datClientes.SelectCommand = comando_select;
                datClientes.Fill(nf);
                int n = 0;
                foreach (DataRow dr in nf.Tables[0].Rows)
                {
                    _cod = dr["COD_CLIENTE"].ToString();
                }
                fbConnection1.Close();
                return _cod;
            }
            catch
            {
                fbConnection1.Close();
                return _cod;
            }

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
                    numero = Convert.ToDouble(numero).ToString("n2");
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
            /*
            int pos_virgula = 0;
            string n = numero;
            if (numero.Contains(","))
            {
                while (numero[pos_virgula].ToString() != ",")
                {
                    pos_virgula++;
                }
                n = numero.Remove(pos_virgula);
                pos_virgula++; //por que começa com 0
                
                //MessageBox.Show(tamanho_atual.ToString());
                //MessageBox.Show(pos_virgula.ToString());
            }
            
            int numero_inteiro = Convert.ToInt32(n);
            decimal numero_decimal_1 = new decimal();
            decimal numero_decimal_2 = new decimal();
            numero_decimal_1 = Convert.ToDecimal(numero);
            numero_decimal_2 = Convert.ToDecimal(n);
            decimal numero_decimal = numero_decimal_1 - numero_decimal_2;
            int qtde_decimais = numero_decimal.ToString().Length - 2; //TIRANDO O 0.
            if (numero_decimal == 0)
                qtde_decimais = 0;
            else
            {
                if (qtde_decimais > qtde_depois_virg)
                    qtde_decimais = qtde_depois_virg + 2;
                string numero_decimal_string = numero_decimal.ToString();
                for (int p = 0; p < qtde_decimais; p++)
                {
                    decimal_correto = decimal_correto + numero_decimal_string[p].ToString();

                }
            }
            for (int j = 0; j < qtde_depois_virg - qtde_decimais; j++)
            {
                decimal_correto = decimal_correto + "0";
            }
            string numero_correto = numero_inteiro.ToString() + "." + decimal_correto;
            decimal_correto = "";
             * return numero_correto;
            //int tamanho = numero_correto.Length;
            /*
            for (int j = numero_correto.Length; j < n_caracteres; j++)
            {
                numero_correto = "0" + numero_correto;

            }
             * */

            /*
            int numero_inteiro = Convert.ToInt32(numero);
            int numero_decimal = Convert.ToInt32(numero) - numero_inteiro;
            int qtde_decimais = numero_decimal.ToString().Length;
            if (numero_decimal == 0)
                qtde_decimais = 0;
            else
            {
                for (int p = 2; p < qtde_decimais; p++)
                {
                    decimal_correto = decimal_correto + decimal_correto[p].ToString();

                }
            }
            for (int j = 0; j < qtde_depois_virg - qtde_decimais; j++)
            {
                decimal_correto = decimal_correto + "0";
            }
            string numero_correto = numero_inteiro.ToString() + "." + decimal_correto;
            decimal_correto = "";
            int tamanho = numero_correto.Length;
            for (int j = numero_correto.Length; j < tamanho; j++)
            {
                numero_correto = "0" + numero_correto;

            }
            return numero_correto;

            */
        }

        private void detectar_numero_vencimentos_fatura(out int n_venc)
        {
            try
            {
                comando_select.CommandText = "SELECT * " +
                    "FROM FATURA_PEDIDO WHERE N_PEDIDO_FATURA_PED = '" + tb_n_pedido.Text + "'";
                DataSet fatura = new DataSet();
                fbConnection1.Open();
                datFatura_nf.SelectCommand = comando_select;
                datFatura_nf.Fill(fatura);
                int n = 0;
                foreach (DataRow dr in fatura.Tables[0].Rows)
                {

                    _cod[n] = dr["COD_FATURA_PED"].ToString();
                    _valores[n] = dr["VALOR_FATURA_PED"].ToString();
                    _datas[n] = dr["DATA_VENC_FATURA_PED"].ToString();
                    n++;

                }

                this.fbConnection1.Close();
                n_venc = n;
            }
            catch
            {
                fbConnection1.Close();
                n_venc = 0;
            }

        }

        private void acertar_imp_duplicatas()
        {
            try
            {
                string valor_total = transforma_decimal(2, tb_total_pedido.Text, 15);
                int _n_vencimentos;
                //a parada é 6 pois é o numero máximo de parcelas
                for (int i = 0; i < 6; i++)
                {
                    _cod[i] = ""; _datas[i] = ""; _valores[i] = "";
                }
                detectar_numero_vencimentos_fatura(out _n_vencimentos);
                string cod1 = "0", cod2 = "0", cod3 = "0", cod4 = "0", cod5 = "0", cod6 = "0";
                string data1 = "01/01/2001", data2 = "01/01/2001", data3 = "01/01/2001", data4 = "01/01/2001", data5 = "01/01/2001", data6 = "01/01/2001";
                string valor1 = "0.0", valor2 = "0.0", valor3 = "0.0", valor4 = "0.0", valor5 = "0.0", valor6 = "0.0";
                try { cod1 = Convert.ToInt32(_cod[0]).ToString(); data1 = Convert.ToDateTime(_datas[0]).ToShortDateString().Replace("/", "."); valor1 = _valores[0].Replace(",", "."); }
                catch { }
                try { cod2 = Convert.ToInt32(_cod[1]).ToString(); data2 = Convert.ToDateTime(_datas[1]).ToShortDateString().Replace("/", "."); valor2 = _valores[1].Replace(",", "."); }
                catch { }
                try { cod3 = Convert.ToInt32(_cod[2]).ToString(); data3 = Convert.ToDateTime(_datas[2]).ToShortDateString().Replace("/", "."); valor3 = _valores[2].Replace(",", "."); }
                catch { }
                try { cod4 = Convert.ToInt32(_cod[3]).ToString(); data4 = Convert.ToDateTime(_datas[3]).ToShortDateString().Replace("/", "."); valor4 = _valores[3].Replace(",", "."); }
                catch { }
                try { cod5 = Convert.ToInt32(_cod[4]).ToString(); data5 = Convert.ToDateTime(_datas[4]).ToShortDateString().Replace("/", "."); valor5 = _valores[4].Replace(",", "."); }
                catch { }
                try { cod6 = Convert.ToInt32(_cod[5]).ToString(); data6 = Convert.ToDateTime(_datas[5]).ToShortDateString().Replace("/", "."); valor6 = _valores[5].Replace(",", "."); }
                catch { }
                this.datImp_duplicatas.DeleteCommand.CommandText =
                    "DELETE FROM IMP_DUPLICATAS";
                this.fbConnection1.Open();
                this.datImp_duplicatas.DeleteCommand.Connection = fbConnection1;
                this.datImp_duplicatas.DeleteCommand.ExecuteNonQuery();
                this.fbConnection1.Close();

                this.datImp_duplicatas.InsertCommand.CommandText =
                "INSERT INTO IMP_DUPLICATAS (COD_1_IMP_DUPLICATA, DATA_1_IMP_DUPLICATA, VALOR_1_IMP_DUPLICATA, " +
                "COD_2_IMP_DUPLICATA, DATA_2_IMP_DUPLICATA, VALOR_2_IMP_DUPLICATA, " +
                "COD_3_IMP_DUPLICATA, DATA_3_IMP_DUPLICATA, VALOR_3_IMP_DUPLICATA, " +
                "COD_4_IMP_DUPLICATA, DATA_4_IMP_DUPLICATA, VALOR_4_IMP_DUPLICATA, " +
                "COD_5_IMP_DUPLICATA, DATA_5_IMP_DUPLICATA, VALOR_5_IMP_DUPLICATA, " +
                "COD_6_IMP_DUPLICATA, DATA_6_IMP_DUPLICATA, VALOR_6_IMP_DUPLICATA) " +
                "VALUES ('" + cod1 + "', '" + data1 + "', '" + valor1 + "'," +
                "'" + cod2 + "', '" + data2 + "', '" + valor2 + "'," +
                "'" + cod3 + "', '" + data3 + "', '" + valor3 + "'," +
                "'" + cod4 + "', '" + data4 + "', '" + valor4 + "'," +
                "'" + cod5 + "', '" + data5 + "', '" + valor5 + "'," +
                "'" + cod6 + "', '" + data6 + "', '" + valor6 + "')";
                this.fbConnection1.Open();
                this.datImp_duplicatas.InsertCommand.Connection = fbConnection1;
                this.datImp_duplicatas.InsertCommand.ExecuteNonQuery();
                this.fbConnection1.Close();


                datImp_duplicatas.Fill(IMP_DUPLICATAS);
            }
            catch
            {
                MessageBox.Show("Erro na inserção das duplicatas");
                fbConnection1.Close();
            }
        }

        private void imprimir_op()
        {
            try
            {
                localizar_pedido(tb_n_pedido.Text);

                acertar_imp_duplicatas();
                dsPedidos imprimir = new dsPedidos();
                fbConnection1.Open();

                datPedidos_venda.Fill(imprimir.PEDIDOS_VENDA);

                this.datClientes.SelectCommand.CommandText =
                "SELECT * FROM CLIENTES WHERE CNPJ = '" + tb_cnpj_cliente.Text + "'";
                //this.fbConnection1.Open();
                this.datClientes.SelectCommand.Connection = fbConnection1;
                this.datClientes.SelectCommand.ExecuteNonQuery();
                //datClientes.Fill(CLIENTES);
                //this.fbConnection1.Close(); 
                datClientes.Fill(imprimir.CLIENTES);
                datImp_duplicatas.Fill(imprimir.IMP_DUPLICATAS);
                datItens_ped_venda.Fill(imprimir.ITENS_PEDIDO_VENDA);


                FbDataAdapter datEmpresa = new FbDataAdapter();
                FbCommand sel = new FbCommand();
                sel.Connection = fbConnection1;
                sel.CommandText = "SELECT FIRST(1) * FROM EMPRESA WHERE CNPJ_EMPRESA = '" + tb_cnpj_empresa.Text + "' ORDER BY COD_EMPRESA";
                datEmpresa.SelectCommand = sel;
                datEmpresa.Fill(imprimir.EMPRESA);

                try
                {
                    FbCommand select = new FbCommand();
                    select.Connection = fbConnection1;
                    // fbConnection1.Open();
                    select.CommandText =
                            "SELECT * FROM TRANSPORTADORAS WHERE RAZAO_SOCIAL_TRANSPORTADORA = '" + tb_transportadora.Text + "'";
                    FbDataAdapter datSelect = new FbDataAdapter();
                    datSelect.SelectCommand = select;
                    DataTable dtSelect = new DataTable();
                    datSelect.Fill(imprimir.TRANSPORTADORAS);
                    //fbConnection1.Close();
                }
                catch (Exception a)
                {

                }


                FbCommand selectP = new FbCommand();
                selectP.Connection = fbConnection1;
                selectP.CommandText =
                   "SELECT COD_PRODUTO, COD_FORNECEDOR_PRODUTO, DESCRICAO_GRUPO_PRODUTO, " +
                   "DESCRICAO_SUB_GRUPO_PRODUTO, NOME_FAMILIA_PRODUTO FROM PRODUTOS WHERE NOME_FORNECEDOR_PRODUTO = 'ENTRELUX'";
                FbDataAdapter datSelectP = new FbDataAdapter();
                datSelectP.SelectCommand = selectP;
                DataTable dtSelectP = new DataTable();
                datSelectP.Fill(dtSelectP);
                foreach (DataRow dr in dtSelectP.Rows)
                {
                    try
                    {
                        imprimir.Caracteristicas.AddCaracteristicasRow(Convert.ToInt32(dr[0].ToString()), dr[4].ToString(), dr[2].ToString(), dr[3].ToString());
                    }
                    catch (Exception ex) { }
                }

                fbConnection1.Close();

                string _email, _senha_email;
                buscar_email(cod_usuario, out _email, out _senha_email);

                imprimir.Cabecalho.AddCabecalhoRow("Ordem de Produção", _email);

                
                crPedido_venda novo_ped = new crPedido_venda();
                
                novo_ped.SetDataSource(imprimir);
                
                
              
                form_imprimir imprime = new form_imprimir(novo_ped);

                int n_copias = 0;
                try
                {
                    n_copias = Convert.ToInt16(tb_n_copias.Text);
                }
                catch { }
                //imprime.n_copias = n_copias;
                imprime.orcamento = true;
                imprime.n_orcamento = tb_n_pedido.Text;
                if (imprimir_direto)
                    imprime.imprimir_direto = true;
                imprime.Show();
               // cbxImpresso.Checked = true;
                salvar();
            }
            catch
            {
                fbConnection1.Close();
            }
        }
        private void imprimir(bool fechar_direto)
        {
            try
            {
                localizar_pedido(tb_n_pedido.Text);

                acertar_imp_duplicatas();
                dsPedidos imprimir = new dsPedidos();
                fbConnection1.Open();

                datPedidos_venda.Fill(imprimir.PEDIDOS_VENDA);

                this.datClientes.SelectCommand.CommandText =
                "SELECT * FROM CLIENTES WHERE CNPJ = '" + tb_cnpj_cliente.Text + "'";
                //this.fbConnection1.Open();
                this.datClientes.SelectCommand.Connection = fbConnection1;
                this.datClientes.SelectCommand.ExecuteNonQuery();
                try
                {
                    FbCommand select = new FbCommand();
                    select.Connection = fbConnection1;
                    // fbConnection1.Open();
                    select.CommandText =
                            "SELECT * FROM TRANSPORTADORAS WHERE RAZAO_SOCIAL_TRANSPORTADORA = '" + tb_transportadora.Text + "'";
                    FbDataAdapter datSelect = new FbDataAdapter();
                    datSelect.SelectCommand = select;
                    DataTable dtSelect = new DataTable();
                    datSelect.Fill(imprimir.TRANSPORTADORAS);
                    //fbConnection1.Close();
                }
                catch (Exception a)
                {

                }

                //datClientes.Fill(CLIENTES);
                //this.fbConnection1.Close(); 
                datClientes.Fill(imprimir.CLIENTES);
                datImp_duplicatas.Fill(imprimir.IMP_DUPLICATAS);
                datItens_ped_venda.Fill(imprimir.ITENS_PEDIDO_VENDA);

                FbDataAdapter datEmpresa = new FbDataAdapter();
                FbCommand sel = new FbCommand();
                sel.Connection = fbConnection1;
                sel.CommandText = "SELECT FIRST(1) * FROM EMPRESA WHERE CNPJ_EMPRESA = '" + tb_cnpj_empresa.Text + "' ORDER BY COD_EMPRESA";
                datEmpresa.SelectCommand = sel;
                datEmpresa.Fill(imprimir.EMPRESA);

                DataTable dtFaturaPedido = new DataTable();
                datFped.Fill(imprimir.FATURA_PEDIDO);

                FbCommand selectP = new FbCommand();
                selectP.Connection = fbConnection1;
                selectP.CommandText =
                   "SELECT COD_PRODUTO, COD_FORNECEDOR_PRODUTO, DESCRICAO_GRUPO_PRODUTO, " +
                   "DESCRICAO_SUB_GRUPO_PRODUTO, NOME_FAMILIA_PRODUTO FROM PRODUTOS WHERE NOME_FORNECEDOR_PRODUTO = 'ENTRELUX'";
                FbDataAdapter datSelectP = new FbDataAdapter();
                datSelectP.SelectCommand = selectP;
                DataTable dtSelectP = new DataTable();
                datSelectP.Fill(dtSelectP);
                foreach(DataRow dr in dtSelectP.Rows)
                {
                    try
                    {
                        imprimir.Caracteristicas.AddCaracteristicasRow(Convert.ToInt32(dr[0].ToString()), dr[4].ToString(), dr[2].ToString(), dr[3].ToString());
                    }
                    catch(Exception ex) { }
                }
                //datSelectP.Fill(imprimir.PRODUTOS);


                fbConnection1.Close();
                crPedido_venda novo_ped = new crPedido_venda();
                crPedido_orcamentoPaisagem orc = new crPedido_orcamentoPaisagem();
                crPedido_orcamentoPaisagemEntre orc_entrelux = new crPedido_orcamentoPaisagemEntre();
                crPedido_orcamentoPaisagemUS orc_us = new crPedido_orcamentoPaisagemUS();
                //crPedido_vendaBeitute novo_ped_beitute = new crPedido_vendaBeitute();
                //  novo_ped.PrintOptions.PaperSize = PaperSize.PaperA4;
                 string _email, _senha_email;
                buscar_email(cod_usuario, out _email, out _senha_email);
                if (cbStatus.Text.Contains("Orçamento"))
                {
                    
                    imprimir.Cabecalho.AddCabecalhoRow("Orçamento", _email);
                    novo_ped.SetDataSource(imprimir);
                    orc_entrelux.SetDataSource(imprimir);
                    orc_us.SetDataSource(imprimir);
                }
                else
                {
                    novo_ped.SetDataSource(imprimir);
                    imprimir.Cabecalho.AddCabecalhoRow("Pedido de Venda", _email);
                }

                // novo_ped_beitute.SetDataSource(imprimir);

                form_imprimir imprime;
                int n_copias = 0;
                try
                {
                    n_copias = Convert.ToInt16(tb_n_copias.Text);
                }
                catch { }
                if (cbStatus.Text.Contains("Orçamento"))
                {
                    if (cbStatus.Text.Contains("Entrelux"))
                    {
                        imprime = new form_imprimir(orc_entrelux);
                    }
                    else
                    {
                        double icms = 0, icms_st = 0;
                        if (buscar_estado_cliente(tb_cnpj_cliente.Text, out icms, out icms_st) == "EX")
                            imprime = new form_imprimir(orc_us);
                        else
                        {
                            imprime = new form_imprimir(novo_ped);
                        }
                    }

                }
                else
                {
                    imprime = new form_imprimir(novo_ped);
                }
                imprime.n_copias = n_copias;
                imprime.orcamento = true;
                imprime.n_orcamento = tb_n_ped_novo.Text;
                if (cbStatus.Text.Contains("Orçamento"))
                    imprime.ainda_e_orcamento = true;
                imprime.fechar_direto = fechar_direto;
                if (imprimir_direto)
                    imprime.imprimir_direto = true;
                
                imprime.ShowDialog();
                //cbxImpresso.Checked = true;
                //salvar();
            }
            catch
            {
                fbConnection1.Close();
            }
        }

        private void buscar_email(string usuario_atual, out string _email, out string _senha_email)
        {
            _email = "";
            _senha_email = "";

            try
            {
                FbCommand select = new FbCommand();
                select.CommandText =
                    "SELECT EMAIL_USUARIO, SENHA_EMAIL_USUARIO FROM USUARIOS " +
                    " WHERE COD_USUARIO = '" + usuario_atual + "'";
                select.Connection = fbConnection1;
                
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();
                foreach (DataRow dr in dtSelect.Rows)
                {
                    _email = dr[0].ToString();
                    _senha_email = dr[1].ToString();
                }

            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }

        }
        private void imprimirDesejada(bool fechar_direto)
        {
            try
            {
                localizar_pedido(tb_n_pedido.Text);

                //acertar_imp_duplicatas();
                dsPedidos imprimir = new dsPedidos();
                fbConnection1.Open();

                datPedidos_venda.Fill(imprimir.PEDIDOS_VENDA);

                this.datClientes.SelectCommand.CommandText =
                "SELECT * FROM CLIENTES WHERE CNPJ = '" + tb_cnpj_cliente.Text + "'";
                //this.fbConnection1.Open();
                this.datClientes.SelectCommand.Connection = fbConnection1;
                this.datClientes.SelectCommand.ExecuteNonQuery();
                //datClientes.Fill(CLIENTES);
                //this.fbConnection1.Close(); 
                datClientes.Fill(imprimir.CLIENTES);
                datImp_duplicatas.Fill(imprimir.IMP_DUPLICATAS);
                datItens_ped_venda.Fill(imprimir.ITENS_PEDIDO_VENDA);

                FbDataAdapter datEmpresa = new FbDataAdapter();
                FbCommand sel = new FbCommand();
                sel.Connection = fbConnection1;
                sel.CommandText = "SELECT FIRST(1) * FROM EMPRESA WHERE CNPJ_EMPRESA = '" + tb_cnpj_empresa.Text + "' ORDER BY COD_EMPRESA";
                datEmpresa.SelectCommand = sel;
                datEmpresa.Fill(imprimir.EMPRESA);

                try
                {
                    FbCommand select = new FbCommand();
                    select.Connection = fbConnection1;
                    // fbConnection1.Open();
                    select.CommandText =
                            "SELECT * FROM TRANSPORTADORAS WHERE RAZAO_SOCIAL_TRANSPORTADORA = '" + tb_transportadora.Text + "'";
                    FbDataAdapter datSelect = new FbDataAdapter();
                    datSelect.SelectCommand = select;
                    DataTable dtSelect = new DataTable();
                    datSelect.Fill(imprimir.TRANSPORTADORAS);
                    //fbConnection1.Close();
                }
                catch (Exception a)
                {

                }

                // DataTable dtFaturaPedido = new DataTable();
                // datFped.Fill(imprimir.FATURA_PEDIDO);
                /*
                foreach (DataRow dr in dtFaturaPedido.Rows)
                {
                    try
                    {
                        double percentual = 0;
                        double valor = Convert.ToDouble(dr["VALOR_FATURA_PED"].ToString());
                        int cr = 0;
                        try
                        {
                            percentual = 0;// Convert.ToDouble(tb_porc_desejada.Text);
                            valor = Convert.ToDouble(dr["VALOR_FATURA_PED"].ToString()) - (Convert.ToDouble(dr["VALOR_FATURA_PED"].ToString()) * percentual / 100);
                            cr = Convert.ToInt32(dr["COD_FATURA_PED"].ToString());
                        }
                        catch { }
                        imprimir.FATURA_PEDIDO.AddFATURA_PEDIDORow(Convert.ToInt32(dr["COD_FATURA_PED"].ToString()), Convert.ToInt32(dr["PRAZO_FATURA_PED"].ToString()),
                            Convert.ToDateTime(dr["DATA_VENC_FATURA_PED"].ToString()), valor, Convert.ToInt32(dr["N_PEDIDO_FATURA_PED"].ToString()),
                            cr);
                            
                    }
                    catch { }
                }
                */
                string _email, _senha_email;
                buscar_email(cod_usuario, out _email, out _senha_email);
                if (cbStatus.Text == "Orçamento")
                {
                    imprimir.Cabecalho.AddCabecalhoRow("Orçamento", _email);
                }
                else
                {
                    imprimir.Cabecalho.AddCabecalhoRow("Pedido de Venda", _email);
                }

                fbConnection1.Close();
                crPedido_vendaDesejado novo_ped = new crPedido_vendaDesejado();
                //crPedido_vendaBeitute novo_ped_beitute = new crPedido_vendaBeitute();
                //  novo_ped.PrintOptions.PaperSize = PaperSize.PaperA4;
                novo_ped.SetDataSource(imprimir);
                // novo_ped_beitute.SetDataSource(imprimir);

                form_imprimir imprime;
                int n_copias = 0;
                try
                {
                    n_copias = Convert.ToInt16(tb_n_copias.Text);
                }
                catch { }


                imprime = new form_imprimir(novo_ped);
                imprime.n_copias = n_copias;
                imprime.orcamento = true;
                imprime.n_orcamento = tb_n_pedido.Text;
                imprime.fechar_direto = fechar_direto;
                if (imprimir_direto)
                    imprime.imprimir_direto = true;
                imprime.ShowDialog();
               // cbxImpresso.Checked = true;
                //salvar();
            }
            catch
            {
                fbConnection1.Close();
            }
        }
        //CONTAS A RECEBER ATRAVÉS DO PEDIDO
        /*
        private void apagar_itens_cr()
        {
            this.datContas_a_receber.DeleteCommand.CommandText =
            "DELETE FROM CONTAS_A_RECEBER WHERE NF_CR = '" + tb_n_nf.Text + "'";
            this.fbConnection1.Open();
            this.datContas_a_receber.DeleteCommand.Connection = fbConnection1;
            this.datContas_a_receber.DeleteCommand.ExecuteNonQuery();
            this.fbConnection1.Close(); 
        }

        
        private void inserir_duplicatas_cr()
        {
            apagar_itens_cr();
            int _n_vencimentos;
            //a parada é 6 pois é o numero máximo de parcelas
            for (int i = 0; i < 6; i++)
            {
                _cod[i] = ""; _datas[i] = ""; _valores[i] = "";
            }
            detectar_numero_vencimentos_fatura(out _n_vencimentos);

            for (int i = 0; i < _n_vencimentos; i++)
            {
                try
                {
                    int parcela_n = i + 1;
                    this.datContas_a_receber.InsertCommand.CommandText =
                    "INSERT INTO CONTAS_A_RECEBER (VALOR_CR, DATA_PREVISTA_CR, COD_CLIENTE_CR, " +
                    "RAZAO_CLIENTE_CR, DESCRICAO_CR, DUPLICATA_CR, NF_CR) " +
                    "VALUES ('" + _valores[i].Replace(".", "").Replace(",", ".") + "', '" + Convert.ToDateTime(_datas[i]).ToShortDateString().Replace("/", ".") +
                    "', '" + detectar_cod_cliente(tb_cnpj_cliente.Text) + "','" + tb_cliente.Text +
                    "', 'PARCELA " + parcela_n.ToString() + "/" + _n_vencimentos.ToString() + " REF. A NF Nº " + tb_n_nf.Text +
                    "', '" + parcela_n.ToString() + "/" + _n_vencimentos.ToString() + "','" + tb_n_nf.Text + "')";
                    this.fbConnection1.Open();
                    this.datContas_a_receber.InsertCommand.Connection = fbConnection1;
                    this.datContas_a_receber.InsertCommand.ExecuteNonQuery();
                    this.fbConnection1.Close(); 
                }
                catch
                {
                    MessageBox.Show("Erro na inserção da duplicata " + _cod[i].ToString());
                    fbConnection1.Close(); 
                }
            }

        }
        */
        private void baixar_do_estoque()
        {
            // bool erro = false;
            for (int i = 0; i < dgvItens_nota.RowCount; i++)
            {
                try
                {
                    try
                    {
                        string _dun, _qtde, _cnpj, _cod;
                       // string ean = buscar_ean_produto(dgvItens_nota.Rows[i].Cells["col_cod"].Value.ToString(), out _dun, out _qtde, out _cnpj, out _cod);

                        classeEstoque estoque = new classeEstoque();
                        estoque.fbConnection1.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=10.3.3.4;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=True;Packet Size=8192;Server Type=0";
                        estoque.calcular_estoque(dgvItens_nota.Rows[i].Cells["col_cod_forn"].Value.ToString());
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
            //if (erro == false)
            // {
            //     cb_baixado_est.Checked = true;
            //    salvar();                
            // }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.datItens_ped_venda.SelectCommand.CommandText =
                "SELECT * FROM ITENS_PEDIDO_VENDA";
            this.fbConnection1.Open();
            this.datItens_ped_venda.SelectCommand.Connection = fbConnection1;
            this.datItens_ped_venda.SelectCommand.ExecuteNonQuery();
            datItens_ped_venda.Fill(ITENS_PEDIDO_VENDA);
            this.fbConnection1.Close();
        }

        private void bt_excluir_Click(object sender, EventArgs e)
        {
            if (cbStatus.Text != "Faturado")
            {
                try
                {
                    if (dgvFatura_pedido.Rows.Count > 0 && dgvFatura_pedido.Rows[0].Cells["col_cr_fatura"].Value.ToString() != "")
                        MessageBox.Show("Existem Faturas registradas para esse pedido. Para excluir o pedido você deve cancelá-las antes.");
                    else
                    {
                        if (MessageBox.Show("Tem certeza que deseja excluir o pedido?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {

                            for (int i = 0; i < dgvItens_nota.Rows.Count; i++)
                            {
                                try
                                {
                                    string cod = dgvItens_nota.Rows[i].Cells["col_cod"].Value.ToString();

                                    FbCommand delete = new FbCommand();
                                    delete.CommandText =
                                        "DELETE FROM ITENS_PEDIDO_VENDA WHERE COD_ITEM_VENDA = '" + dgvItens_nota.Rows[i].Cells["col_cod_item_venda"].Value.ToString() + "'";
                                    delete.Connection = fbConnection1;
                                    fbConnection1.Open();
                                    FbDataAdapter datDelete = new FbDataAdapter();
                                    datDelete.DeleteCommand = delete;
                                    datDelete.DeleteCommand.ExecuteNonQuery();
                                    fbConnection1.Close();

                                    string _dun, _qtde, _cnpj, _cod;
                                    string ean = buscar_ean_produto(cod, out _dun, out _qtde, out _cnpj, out _cod);

                                    try
                                    {
                                        classeEstoque estoque = new classeEstoque();
                                        estoque.fbConnection1.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=10.3.3.4;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=True;Packet Size=8192;Server Type=0";
                                        estoque.calcular_estoque(dgvItens_nota.Rows[i].Cells["col_cod_forn"].Value.ToString());
                                    }
                                    catch { }
                                }
                                catch (Exception a)
                                {
                                    fbConnection1.Close();
                                    MessageBox.Show(a.ToString());
                                }
                            }
                            /*
                            //Excluir itens do pedido de venda---------------------------------------------------//
                            datItens_ped_venda.DeleteCommand.CommandText =
                            "DELETE FROM itens_pedido_venda WHERE cod_pedido_item_venda = " + tb_n_pedido.Text;
                            datItens_ped_venda.DeleteCommand.Connection = fbConnection1;
                            fbConnection1.Open();
                            datItens_ped_venda.DeleteCommand.ExecuteNonQuery();
                            fbConnection1.Close(); 
                            */
                            dsItens_ped_venda.Clear();
                            //-----------------------------------------------------------------------------------//

                            //Excluir o pedido de venda----------------------------------------------------------//
                            datPedidos_venda.DeleteCommand.CommandText =
                                "DELETE FROM pedidos_venda WHERE cod_ped_venda = " + tb_n_pedido.Text;
                            datPedidos_venda.DeleteCommand.Connection = fbConnection1;
                            fbConnection1.Open();
                            datPedidos_venda.DeleteCommand.ExecuteNonQuery();
                            fbConnection1.Close();

                            dsPedidos_venda.Clear();
                            //-----------------------------------------------------------------------------------//

                            MessageBox.Show("Pedido excluído com sucesso!");
                        }
                    }
                }
                catch (Exception a)
                {
                    fbConnection1.Close();
                    MessageBox.Show("Não foi possível excluir o pedido de venda!\nErro: " + a.Message);
                }
            }
            else
            {
                MessageBox.Show("Não é possivel excluir um pedido Faturado!");
            }
        }

        private void apaga_faturas_anteriores()
        {
            try
            {
                this.datFped.DeleteCommand.CommandText =
                        "DELETE FROM FATURA_PEDIDO WHERE N_PEDIDO_FATURA_PED = '" + tb_n_pedido.Text + "'";
                this.fbConnection1.Open();
                this.datFped.DeleteCommand.Connection = fbConnection1;
                this.datFped.DeleteCommand.ExecuteNonQuery();
                this.fbConnection1.Close();
            }
            catch
            {
                fbConnection1.Close();
                MessageBox.Show("Erro ao apagar faturas");
            }
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
                double valor_total = Convert.ToDouble(tb_total_pedido.Text);
                double valor_base = Math.Floor((valor_total / numero_parcelas) * 100) / 100; // Valor de cada parcela truncado para 2 casas decimais
                double valor_restante = valor_total - (valor_base * numero_parcelas); // Calcula a diferença para compensar a dízima

                string[] prazos = { prazo_1, prazo_2, prazo_3, prazo_4, prazo_5, prazo_6, prazo_7, prazo_8, prazo_9, prazo_10, prazo_11, prazo_12 };

                for (int i = 0; i < numero_parcelas; i++)
                {
                    double valor_parcela = valor_base;
                    if (i == 0) // A primeira parcela recebe o valor adicional
                    {
                        valor_parcela += valor_restante;
                    }

                    double prazo = Convert.ToDouble(prazos[i]);
                    DateTime data1 = hoje.AddDays(prazo);
                    insere_fatura(prazos[i].ToString(), data1.ToShortDateString().Replace("/", "."), valor_parcela.ToString("F2").Replace(",", "."), tb_n_pedido.Text);
                }
                //double valor = 0;// buscar_valor_faturado() / numero_parcelas;
                //double valor_total = Convert.ToDouble(tb_total_pedido.Text);
                //valor = (valor_total / numero_parcelas);
                //string[] prazos = { prazo_1, prazo_2, prazo_3, prazo_4, prazo_5, prazo_6, prazo_7, prazo_8, prazo_9, prazo_10, prazo_11, prazo_12 };

                //for (int i = 0; i < numero_parcelas; i++)
                //{
                //    double prazo = 0;
                //    prazo = Convert.ToDouble(prazos[i]);
                //    DateTime data1 = hoje.AddDays(prazo);
                //    insere_fatura(prazos[i].ToString(), data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), tb_n_pedido.Text);
                //}




            }
            catch { }

        }

        /*
        private void acertar_faturas(string n_parcelas, string prazo_1, string prazo_2, string prazo_3,
            string prazo_4, string prazo_5, string prazo_6)
        {

            int numero_parcelas = 0;
            DateTime hoje = Convert.ToDateTime(tb_data_prevista.Text);
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
            decimal valor = 0;
            try
            {
                //if (razao_social_empresa.ToUpper().Contains("DEBORA") || razao_social_empresa.ToUpper().Contains("DANIEL"))
                // {
                valor = Convert.ToDecimal(Convert.ToDecimal((Convert.ToDecimal(tb_total_prod.Text) - Convert.ToDecimal(tb_valor_desconto.Text)) / numero_parcelas).ToString("n2"));
                //  }
                ///  else
                //  {
                //      valor = Convert.ToDecimal(Convert.ToDecimal((Convert.ToDecimal(tb_total_pedido.Text)) / numero_parcelas).ToString("n2"));
                //  }
            }
            catch { }

            switch (numero_parcelas)
            {

                case 1:
                    {
                        double prazo = Convert.ToDouble(prazo_1);
                        decimal diferenca = 0;
                        try
                        {
                            decimal valorProdutos = Convert.ToDecimal(tb_total_prod.Text) - Convert.ToDecimal(tb_valor_desconto.Text);
                            decimal somaParcelas = valor * numero_parcelas;
                            diferenca = valorProdutos - somaParcelas;
                        }
                        catch { }
                        decimal valor1 = valor + diferenca;
                        DateTime data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_1, data1.ToShortDateString().Replace("/", "."), valor1.ToString().Replace(",", "."), tb_n_pedido.Text);
                        break;
                    }

                case 2:
                    {
                        double prazo = Convert.ToDouble(prazo_1);
                        decimal diferenca = 0;
                        try
                        {
                            decimal valorProdutos = Convert.ToDecimal(tb_total_prod.Text) - Convert.ToDecimal(tb_valor_desconto.Text);
                            decimal somaParcelas = valor * numero_parcelas;
                            diferenca = valorProdutos - somaParcelas;
                        }
                        catch { }
                        decimal valor1 = valor + diferenca;
                        DateTime data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_1, data1.ToShortDateString().Replace("/", "."), valor1.ToString().Replace(",", "."), tb_n_pedido.Text);
                        prazo = Convert.ToDouble(prazo_2);
                        data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_2, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), tb_n_pedido.Text);
                        break;
                    }
                case 3:
                    {
                        double prazo = Convert.ToDouble(prazo_1);
                        decimal diferenca = 0;
                        try
                        {
                            decimal valorProdutos = Convert.ToDecimal(tb_total_prod.Text) - Convert.ToDecimal(tb_valor_desconto.Text);
                            decimal somaParcelas = valor * numero_parcelas;
                            diferenca = valorProdutos - somaParcelas;
                        }
                        catch { }
                        decimal valor1 = valor + diferenca;
                        DateTime data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_1, data1.ToShortDateString().Replace("/", "."), valor1.ToString().Replace(",", "."), tb_n_pedido.Text);
                        prazo = Convert.ToDouble(prazo_2);
                        data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_2, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), tb_n_pedido.Text);
                        prazo = Convert.ToDouble(prazo_3);
                        data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_3, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), tb_n_pedido.Text);
                        break;
                    }
                case 4:
                    {
                        double prazo = Convert.ToDouble(prazo_1);
                        decimal diferenca = 0;
                        try
                        {
                            decimal valorProdutos = Convert.ToDecimal(tb_total_prod.Text) - Convert.ToDecimal(tb_valor_desconto.Text) ;
                            decimal somaParcelas = valor * numero_parcelas;
                            diferenca = valorProdutos - somaParcelas;
                        }
                        catch { }
                        decimal valor1 = valor + diferenca;
                        DateTime data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_1, data1.ToShortDateString().Replace("/", "."), valor1.ToString().Replace(",", "."), tb_n_pedido.Text);
                        prazo = Convert.ToDouble(prazo_2);
                        data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_2, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), tb_n_pedido.Text);
                        prazo = Convert.ToDouble(prazo_3);
                        data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_3, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), tb_n_pedido.Text);
                        prazo = Convert.ToDouble(prazo_4);
                        data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_4, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), tb_n_pedido.Text);
                        break;
                    }
                case 5:
                    {
                        double prazo = Convert.ToDouble(prazo_1);
                        decimal diferenca = 0;
                        try
                        {
                            decimal valorProdutos = Convert.ToDecimal(tb_total_prod.Text) - Convert.ToDecimal(tb_valor_desconto.Text);
                            decimal somaParcelas = valor * numero_parcelas;
                            diferenca = valorProdutos - somaParcelas;
                        }
                        catch { }
                        decimal valor1 = valor + diferenca;
                        DateTime data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_1, data1.ToShortDateString().Replace("/", "."), valor1.ToString().Replace(",", "."), tb_n_pedido.Text);
                        prazo = Convert.ToDouble(prazo_2);
                        data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_2, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), tb_n_pedido.Text);
                        prazo = Convert.ToDouble(prazo_3);
                        data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_3, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), tb_n_pedido.Text);
                        prazo = Convert.ToDouble(prazo_4);
                        data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_4, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), tb_n_pedido.Text);
                        prazo = Convert.ToDouble(prazo_5);
                        data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_5, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), tb_n_pedido.Text);
                        break;
                    }
                case 6:
                    {
                        double prazo = Convert.ToDouble(prazo_1);
                        decimal diferenca = 0;
                        try
                        {
                            decimal valorProdutos = Convert.ToDecimal(tb_total_prod.Text) - Convert.ToDecimal(tb_valor_desconto.Text) ;
                            decimal somaParcelas = valor * numero_parcelas;
                            diferenca = valorProdutos - somaParcelas;
                        }
                        catch { }
                        decimal valor1 = valor + diferenca;
                        DateTime data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_1, data1.ToShortDateString().Replace("/", "."), valor1.ToString().Replace(",", "."), tb_n_pedido.Text);
                        prazo = Convert.ToDouble(prazo_2);
                        data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_2, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), tb_n_pedido.Text);
                        prazo = Convert.ToDouble(prazo_3);
                        data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_3, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), tb_n_pedido.Text);
                        prazo = Convert.ToDouble(prazo_4);
                        data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_4, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), tb_n_pedido.Text);
                        prazo = Convert.ToDouble(prazo_5);
                        data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_5, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), tb_n_pedido.Text);
                        prazo = Convert.ToDouble(prazo_6);
                        data1 = hoje.AddDays(prazo);
                        insere_fatura(prazo_6, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), tb_n_pedido.Text);
                        break;
                    }



            }
        }
        */
        private void insere_fatura(string prazo, string data, string valor, string nf)
        {
            try
            {
                this.datFped.InsertCommand.CommandText =
                        "INSERT INTO FATURA_PEDIDO (PRAZO_FATURA_PED, DATA_VENC_FATURA_PED, VALOR_FATURA_PED, N_PEDIDO_FATURA_PED)" +
                        "VALUES ('" + prazo + "','" + data + "','" + valor + "','" + nf + "')";
                this.fbConnection1.Open();
                this.datFped.InsertCommand.Connection = fbConnection1;
                this.datFped.InsertCommand.ExecuteNonQuery();
                this.fbConnection1.Close();
            }
            catch
            {
                fbConnection1.Close();
                MessageBox.Show("erro na inserção da fatura");
            }


        }

        private void tb_forma_pgto_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (tb_total_pedido.Text != "")
            {
                if (DialogResult.Yes == MessageBox.Show("Você quer inserir uma nova forma de pagamento?",
               "Confirmação?", MessageBoxButtons.YesNo))
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
                        tb_forma_pgto.Text = localiza_forma.forma_pgto_escolhida;
                        apaga_faturas_anteriores();
                        acertar_faturas(localiza_forma.n_parcelas, localiza_forma.prazo_1, localiza_forma.prazo_2, localiza_forma.prazo_3,
                                        localiza_forma.prazo_4, localiza_forma.prazo_5, localiza_forma.prazo_6,
                                        localiza_forma.prazo_7, localiza_forma.prazo_8, localiza_forma.prazo_9,
                                        localiza_forma.prazo_10, localiza_forma.prazo_11, localiza_forma.prazo_12);
                    }
                }
                form_fatura fatura = new form_fatura();
                try
                {

                    fatura.nf = tb_n_pedido.Text;
                    fatura.ShowDialog();
                }
                finally { }
            }
            else
                MessageBox.Show("Calcule o valor do Pedido antes de inserir a forma de pagamento.");

        }

        private void button4_Click(object sender, EventArgs e)
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

        private void button7_Click(object sender, EventArgs e)
        {
            if (cbStatus.Text == "Confirmado")
            {
                voltar_para_estoque();
            }

        }

        private void voltar_para_estoque()
        { }


        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                imprimir(true);
            }
            finally
            {
                enviar_email();
            }

        }
        private void enviar_email()
        {
            try
            {

                //FbCommand select = new FbCommand();
                //select.Connection = fbConnection1;
                //select.CommandText =
                //    "SELECT EMAIL_CONTATO FROM CONTATOS c " +
                //    "INNER JOIN CLIENTES cl ON c.COD_CLIENTE_FORN_CONTATO = cl.COD_CLIENTE " +
                //    "WHERE cl.CNPJ = '" + tb_cnpj_cliente.Text + "' AND c.CLIENTE_FORN_CONTATO = 'CLIENTE' " +
                //    "AND UPPER(c.TIPO_CONTATO) LIKE 'PEDIDO'";
                //fbConnection1.Open();
                //FbDataAdapter datSelect = new FbDataAdapter();
                //datSelect.SelectCommand = select;
                //DataTable dtSelect = new DataTable();
                //datSelect.Fill(dtSelect);
                //fbConnection1.Close();
                string _email, _senha_email;
                buscar_email(cod_usuario, out _email, out _senha_email);
                string descricao = "Pedido de Venda";
                string descricao_impressao = "PEDIDO_VENDA";
                if (cbStatus.Text == "Orçamento")
                {
                    descricao = "Orçamento";
                    descricao_impressao = "ORCAMENTO";
                }
                //foreach (DataRow dr in dtSelect.Rows)
                //{
                    string _caminho_arquivo = "c:\\evolucao\\ORCAMENTOS\\" + descricao_impressao + "_" + tb_n_pedido.Text + ".pdf";
                    string _assunto = "Novo " + descricao + ": " + tb_n_pedido.Text + " " + razao_social_empresa;
                    string _mensagem = "Segue anexo " + descricao + " sob n.º " + tb_n_pedido.Text + " emitido em " + Convert.ToDateTime(tb_data_pedido.Text).ToShortDateString();
                    
                    Email_orcamento novo_email = new Email_orcamento();
                    novo_email._email = _email;
                    novo_email._senha_email = _senha_email;
                    bool _erro;
                    novo_email.EnviarEmail(emailtextBox.Text, _assunto, _mensagem, _caminho_arquivo, "", _email , _senha_email , smtp_nfe_empresa,  out _erro);
                    if (_erro == false)
                    {
                        if (barra_status.Text == "Status Atual")
                            barra_status.Text = "";
                        toolStripStatusLabel1.Text = " Email enviado com sucesso. ";
                        inserir_historico_email(emailtextBox.Text, _caminho_arquivo, _assunto);
                    }
                    else
                    {
                        if (barra_status.Text == "Status Atual")
                            barra_status.Text = "";
                        toolStripStatusLabel1.Text = "Email não enviado. Favor verificar dados. ";
                    }
                //}
            }
            catch (Exception a) { MessageBox.Show(a.ToString()); }
        }

        private string detectar_email()
        {
            comando_select.CommandText = "SELECT EMAIL " +
                "FROM CLIENTES WHERE CNPJ = '" + tb_cnpj_cliente.Text + "'";
            DataSet cliente = new DataSet();
            fbConnection1.Open();
            datClientes.SelectCommand = comando_select;
            datClientes.Fill(cliente);
            string cliente_atual = "";
            foreach (DataRow dr in cliente.Tables[0].Rows)
            {

                cliente_atual = dr["EMAIL"].ToString();
            }

            this.fbConnection1.Close();
            return cliente_atual;

        }
        private void inserir_historico_email(string destinatario, string caminho, string tipo)
        {
            try
            {
                this.datEmails_enviados.InsertCommand.CommandText =
                           "INSERT INTO EMAILS_ENVIADOS (DESTINATARIO_EMAIL_ENVIADO, DATA_EMAIL_ENVIADO, TIPO_EMAIL_ENVIADO, HORA_EMAIL_ENVIADO, CAMINHO_ARQUIVO_EMAIL_ENVIADO)" +
                           "VALUES ('" + destinatario + "','" + DateTime.Now.ToShortDateString().Replace("/", ".") + "','" + tipo + "','" + DateTime.Now.ToShortTimeString() + "','" + caminho + "')";
                this.fbConnection1.Open();
                this.datEmails_enviados.InsertCommand.Connection = fbConnection1;
                this.datEmails_enviados.InsertCommand.ExecuteNonQuery();
                this.fbConnection1.Close();
            }
            catch
            {
                MessageBox.Show("Erro na inserção do histórico de emails enviados");
                fbConnection1.Close();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            salvar();
            imprimir(false);
        }

        private void tb_cod_sistema_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                if (tb_cod_sistema.Text == "")
                { }
                else
                {
                    localizar_item(tb_cod_sistema.Text);
                    // tb_qtde_item.Focus();
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (tb_n_pedido.Text != "")
            {
                if (MessageBox.Show("Deseja gerar um novo pedido a partir deste pedido?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    criar_copia();
                }
            }
            else
            {
                MessageBox.Show("É necessário selecionar um pedido para fazer a cópia!");
            }
        }

        private void criar_copia()
        {
            try
            {
                string cod_tp = "null";
                if (tb_cod_tabela.Text != "")
                    cod_tp = tb_cod_tabela.Text;
                string ultimo_pedido = buscar_ultimo_pedido_empresa(cnpj_empresa);
                int proximo_pedido = Convert.ToInt32(ultimo_pedido) + 1;

                //this.datPedidos_venda.InsertCommand.CommandText =

                //  "INSERT INTO PEDIDOS_VENDA (CLIENTE_PED_VENDA, CNPJ_PED_VENDA, COD_TP_PED_VENDA, DESCRICAO_TP_PED_VENDA, DATA_PED_VENDA, CNPJ_EMISSOR_PED_VENDA, RAZAO_EMISSOR_PED_VENDA, " +
                // "COD_VENDEDOR_PED_VENDA, VENDEDOR_PED_VENDA, N_PED_VENDA, TRANSPORTADORA_PED_VENDA)" +
                //   "VALUES ('" + tb_cliente.Text + "','" + tb_cnpj_cliente.Text + "'," + cod_tp + ",'" + tb_nome_tabela_preco.Text + "','" +
                //DateTime.Now.ToShortDateString().Replace("/", ".") + "','" + tb_cnpj_empresa.Text + "','" + tb_descricao_empresa.Text + "','" +
                //tb_cod_vendedor.Text + "','" + tb_vendedor.Text + "','" + proximo_pedido.ToString() + "','" + tb_transportadora.Text + "') RETURNING COD_PED_VENDA";
                FbCommand insertPedido = new FbCommand();
                insertPedido.Connection = fbConnection1;
                insertPedido.CommandText =
                @" INSERT INTO PEDIDOS_VENDA(
    N_PED_VENDA,
    DATA_PED_VENDA,
    DATA_BAIXA_PED_VENDA,
    CLIENTE_PED_VENDA,
    CNPJ_PED_VENDA,
    COND_PGTO_PED_VENDA,
    VALOR_TOTAL_PROD_PED_VENDA,
    VALOR_TOTAL_PED_VENDA,
    VALOR_TOTAL_ICMS_PED_VENDA,
    VALOR_TOTAL_IPI_PED_VENDA,
    VALOR_DESCONTO_PED_VENDA,
    OBS_PED_VENDA,
    PAGO_PED_VENDA,
    COD_CAIXA_PGTO_PED_VENDA,
    VENDEDOR_PED_VENDA,
    COD_VENDEDOR_PED_VENDA,
    CANCELADO_PED_VENDA,
    NOME_CONTATO_PED_VENDA,
    TELEFONE_CONTATO_PED_VENDA,
    EMAIL_CONTATO_PED_VENDA,
    PORC_DESCONTO_PED_VENDA,
    N_NF_PED_VENDA,
    ID_PEDIDO_CEL_PED_VENDA,
    IMPRESSO_PED_VENDA,
    DATA_ENTREGA_PED_VENDA,
    QTDE_ITENS_PED_VENDA,
    TROCA_PED_VENDA,
    BONIFICACAO_PED_VENDA,
    SAIDA_VENDA_DIRETA_PED_VENDA,
    VENDA_DIRETA_PED_VENDA,
    NF_ENTRADA_PED_VENDA,
    COD_PEDIDO_PAI_PED_VENDA,
    ORCAMENTO_PED_VENDA,
    COD_LRW_PED_VENDA,
    COD_CAIXA_PED_VENDA,
    DATA_NF_PED_VENDA,
    QTDE_TOTAL_PED_VENDA,
    DATA_EXPORTACAO_PED_VENDA,
    HORA_EXPORTACAO_PED_VENDA,
    DEGUSTACAO_PED_VENDA,
    DEVOLUCAO_PED_VENDA,
    PV_PED_VENDA,
    COD_TP_PED_VENDA,
    DESCRICAO_TP_PED_VENDA,
    TRANSPORTADORA_PED_VENDA,
    PLACA_TRANSP_PED_VENDA,
    CNPJ_EMISSOR_PED_VENDA,
    RAZAO_EMISSOR_PED_VENDA,
    VALOR_ST_PED_VENDA,
    VALOR_TOTAL_DESEJADO_PED_VENDA,
    PERC_DESEJADO_PED_VENDA,
    BOLETO_VD_PED_VENDA,
    NF_VD_PED_VENDA,
    COD_WEB_PED_VENDA,
    INDUST_PED_VENDA,
    VENDAS_PED_VENDA,
    FRETE_PED_VENDA,
    ICMS_PED_VENDA,
    IPI_PED_VENDA,
    VALIDADE_PED_VENDA,
    BOMBAS_PED_VENDA,
    TIPO_PED_VENDA,
    COD_ORCAMENTO_PED_VENDA,
    OUTROS_VALORES_PED_VENDA,
    HORA_PED_VENDA,
    LATITUDE_PED_VENDA,
    LONGITUDE_PED_VENDA
)
SELECT " + 
    proximo_pedido + @",         
    CURRENT_DATE,             
    DATA_BAIXA_PED_VENDA,
    CLIENTE_PED_VENDA,
    CNPJ_PED_VENDA,
    COND_PGTO_PED_VENDA,
    VALOR_TOTAL_PROD_PED_VENDA,
    VALOR_TOTAL_PED_VENDA,
    VALOR_TOTAL_ICMS_PED_VENDA,
    VALOR_TOTAL_IPI_PED_VENDA,
    VALOR_DESCONTO_PED_VENDA,
    OBS_PED_VENDA,
    PAGO_PED_VENDA,
    COD_CAIXA_PGTO_PED_VENDA,
    VENDEDOR_PED_VENDA,
    COD_VENDEDOR_PED_VENDA,
    CANCELADO_PED_VENDA,
    NOME_CONTATO_PED_VENDA,
    TELEFONE_CONTATO_PED_VENDA,
    EMAIL_CONTATO_PED_VENDA,
    PORC_DESCONTO_PED_VENDA,
    N_NF_PED_VENDA,
    ID_PEDIDO_CEL_PED_VENDA,
    IMPRESSO_PED_VENDA,
    DATA_ENTREGA_PED_VENDA,
    QTDE_ITENS_PED_VENDA,
    TROCA_PED_VENDA,
    BONIFICACAO_PED_VENDA,
    SAIDA_VENDA_DIRETA_PED_VENDA,
    VENDA_DIRETA_PED_VENDA,
    NF_ENTRADA_PED_VENDA,
    COD_PEDIDO_PAI_PED_VENDA,
    ORCAMENTO_PED_VENDA,
    COD_LRW_PED_VENDA,
    COD_CAIXA_PED_VENDA,
    DATA_NF_PED_VENDA,
    QTDE_TOTAL_PED_VENDA,
    DATA_EXPORTACAO_PED_VENDA,
    HORA_EXPORTACAO_PED_VENDA,
    DEGUSTACAO_PED_VENDA,
    DEVOLUCAO_PED_VENDA,
    PV_PED_VENDA,
    COD_TP_PED_VENDA,
    DESCRICAO_TP_PED_VENDA,
    TRANSPORTADORA_PED_VENDA,
    PLACA_TRANSP_PED_VENDA,
    CNPJ_EMISSOR_PED_VENDA,
    RAZAO_EMISSOR_PED_VENDA,
    VALOR_ST_PED_VENDA,
    VALOR_TOTAL_DESEJADO_PED_VENDA,
    PERC_DESEJADO_PED_VENDA,
    BOLETO_VD_PED_VENDA,
    NF_VD_PED_VENDA,
    COD_WEB_PED_VENDA,
    INDUST_PED_VENDA,
    VENDAS_PED_VENDA,
    FRETE_PED_VENDA,
    ICMS_PED_VENDA,
    IPI_PED_VENDA,
    VALIDADE_PED_VENDA,
    BOMBAS_PED_VENDA,
    TIPO_PED_VENDA,
    COD_ORCAMENTO_PED_VENDA,
    OUTROS_VALORES_PED_VENDA,
    HORA_PED_VENDA,
    LATITUDE_PED_VENDA,
    LONGITUDE_PED_VENDA
FROM PEDIDOS_VENDA
WHERE COD_PED_VENDA = " + tb_n_pedido.Text + " RETURNING COD_PED_VENDA";
                fbConnection1.Open();
                FbDataAdapter datinsertPedido = new FbDataAdapter();
                datinsertPedido.InsertCommand = insertPedido;
                object cod_ped = datinsertPedido.InsertCommand.ExecuteScalar();
                fbConnection1.Close();

                //this.fbConnection1.Open();
                //this.datPedidos_venda.InsertCommand.Connection = fbConnection1;
                //int cod_ped = Convert.ToInt32(datPedidos_venda.InsertCommand.ExecuteScalar());
                //this.fbConnection1.Close();


                FbCommand insertItens = new FbCommand();
                insertItens.Connection = fbConnection1;
                insertItens.CommandText = 

                @"INSERT INTO ITENS_PEDIDO_VENDA(
    QTDE_ITEM_VENDA,
    COD_PROD_ITEM_VENDA,
    DESCRICAO_PROD_ITEM_VENDA,
    VALOR_UNIT_PROD_ITEM_VENDA,
    VALOR_TOTAL_PROD_ITEM_VENDA,
    UNIDADE_PROD_ITEM_VENDA,
    BC_ICMS_PROD_ITEM_VENDA,
    ALIQ_ICMS_PROD_ITEM_VENDA,
    VALOR_ICMS_ITEM_VENDA,
    BC_IPI_PROD_ITEM_VENDA,
    ALIQ_IPI_PROD_ITEM_VENDA,
    VALOR_IPI_ITEM_VENDA,
    NF_PROD_ITEM_VENDA,
    N_NF_PROD_ITEM_VENDA,
    OBS_ITEM_VENDA,
    COD_PEDIDO_ITEM_VENDA, 
    COD_VENDEDOR_ITEM_VENDA,
    DATA_PEDIDO_ITEM_VENDA,
    CANCELADO_ITEM_VENDA,
    DESCRICAO_ITEM_PROD_ITEM_VENDA,
    MARCA_ITEM_VENDA,
    PRAZO_ITEM_VENDA,
    COD_SISTEMA_PROD_ITEM_VENDA,
    PORC_DESC_ITEM_VENDA,
    EAN_ITEM_VENDA,
    CUSTO_ITEM_VENDA,
    QTDE_FAT_ITEM_VENDA,
    VALOR_ST_ITEM_VENDA,
    PEDIDO_COMPRA_PED_VENDA,
    ITEM_PEDIDO_COMPRA_PED_VENDA,
    COD_KIT_PROMOCAO_ITEM_VENDA,
    OP_CLIENTE_ITEM_VENDA,
    PEDIDO_CLIENTE_ITEM_VENDA,
    ITEM_PED_CLIENTE_ITEM_VENDA,
    DATA_ENTREGA_ITEM_VENDA,
    CONFIRMADO_ITEM_VENDA,
    OP_INTERNA_ITEM_VENDA,
    ITEM_LIBERACAO_ITEM_VENDA,
    ITEM_NOTA_ITEM_VENDA,
    FINALIZADO_ITEM_VENDA,
    QTDE_FATURADA_ITEM_VENDA,
    NCM_ITEM_VENDA
)
SELECT
    QTDE_ITEM_VENDA,
    COD_PROD_ITEM_VENDA,
    DESCRICAO_PROD_ITEM_VENDA,
    VALOR_UNIT_PROD_ITEM_VENDA,
    VALOR_TOTAL_PROD_ITEM_VENDA,
    UNIDADE_PROD_ITEM_VENDA,
    BC_ICMS_PROD_ITEM_VENDA,
    ALIQ_ICMS_PROD_ITEM_VENDA,
    VALOR_ICMS_ITEM_VENDA,
    BC_IPI_PROD_ITEM_VENDA,
    ALIQ_IPI_PROD_ITEM_VENDA,
    VALOR_IPI_ITEM_VENDA,
    NF_PROD_ITEM_VENDA,
    N_NF_PROD_ITEM_VENDA,
    OBS_ITEM_VENDA, " + cod_ped.ToString() + ", " +          
    @"COD_VENDEDOR_ITEM_VENDA,
    DATA_PEDIDO_ITEM_VENDA,
    CANCELADO_ITEM_VENDA,
    DESCRICAO_ITEM_PROD_ITEM_VENDA,
    MARCA_ITEM_VENDA,
    PRAZO_ITEM_VENDA,
    COD_SISTEMA_PROD_ITEM_VENDA,
    PORC_DESC_ITEM_VENDA,
    EAN_ITEM_VENDA,
    CUSTO_ITEM_VENDA,
    QTDE_FAT_ITEM_VENDA,
    VALOR_ST_ITEM_VENDA,
    PEDIDO_COMPRA_PED_VENDA,
    ITEM_PEDIDO_COMPRA_PED_VENDA,
    COD_KIT_PROMOCAO_ITEM_VENDA,
    OP_CLIENTE_ITEM_VENDA,
    PEDIDO_CLIENTE_ITEM_VENDA,
    ITEM_PED_CLIENTE_ITEM_VENDA,
    DATA_ENTREGA_ITEM_VENDA,
    CONFIRMADO_ITEM_VENDA,
    OP_INTERNA_ITEM_VENDA,
    ITEM_LIBERACAO_ITEM_VENDA,
    ITEM_NOTA_ITEM_VENDA,
    FINALIZADO_ITEM_VENDA,
    QTDE_FATURADA_ITEM_VENDA,
    NCM_ITEM_VENDA
FROM ITENS_PEDIDO_VENDA
WHERE COD_PEDIDO_ITEM_VENDA = " + tb_n_pedido.Text;
                fbConnection1.Open();
                FbDataAdapter datinsertItens = new FbDataAdapter();
                datinsertItens.InsertCommand = insertItens;
                datinsertItens.InsertCommand.ExecuteNonQuery();
                fbConnection1.Close();





                //foreach (DataRow dr in dsItens_ped_venda.Tables[0].Rows)
                //{
                //    inserirItem(cod_ped.ToString(), dr["cod_prod_item_venda"].ToString(),
                //        dr["descricao_prod_item_venda"].ToString(), dr["descricao_item_prod_item_venda"].ToString(),
                //        dr["marca_item_venda"].ToString(), dr["unidade_prod_item_venda"].ToString(), dr["prazo_item_venda"].ToString(),
                //        dr["qtde_item_venda"].ToString(), dr["valor_unit_prod_item_venda"].ToString(), dr["cod_sistema_prod_item_venda"].ToString(),
                //        dr["QTDE_FAT_ITEM_VENDA"].ToString(), dr["EAN_ITEM_VENDA"].ToString());
                //}
                //calcular();
                //salvar();

                MessageBox.Show("Pedido copiado com sucesso!\nLocalize o pedido novo.");

            }
            catch(Exception ex)
            {
                fbConnection1.Close();
                MessageBox.Show("Erro:" + ex.Message);
            }
        }

        private void inserirItem(string codPedido, string codFornecedor, string descricaoProduto, string descricaoItem, string marcaItem,
            string unidade, string prazoItem, string qtde, string valorUnitario, string codProduto, string qtdeFat, string ean)
        {
            string aliq_ipi = "", aliq_icms = "", iva_item = "", perc_red_icms = "", aliq_icms_st = "", st_item = "", cod_item = "", descricao_item = "", unid_item = "", qtde_item = "", qtde_disponivel = "", valor_unit_item = "",
                valor_total_item = "", valor_bc_icms_item = "", valor_bc_ipi_item = "", valor_icms_item = "", valor_ipi_item = "", cod_vendedor = "";
            try
            {
                comando_select.CommandText = "SELECT * FROM PRODUTOS WHERE COD_PRODUTO = '" + codProduto + "'";
                DataSet prod = new DataSet();
                fbConnection1.Open();
                datProdutos.SelectCommand = comando_select;
                datProdutos.Fill(prod);
                fbConnection1.Close();

                foreach (DataRow dr in prod.Tables[0].Rows)
                {
                    aliq_ipi = dr["ALIQUOTA_IPI_PRODUTO"].ToString();
                    aliq_icms = dr["ALIQUOTA_ICMS_PRODUTO"].ToString();
                    perc_red_icms = dr["REDUCAO_FORA_PRODUTO"].ToString();
                    qtde_disponivel = dr["ESTOQUE_ATUAL_PRODUTO"].ToString();
                }
            }
            catch
            {

                fbConnection1.Close();
            }

            double _valor_total = 0, _bc_icms = 0, _bc_ipi = 0, _red_bc_icms = 0, _valor_ipi = 0, _valor_icms = 0;
            try
            {
                _valor_total = Convert.ToDouble(valorUnitario) * Convert.ToDouble(qtde);
            }
            catch { }
            //calcular aqui a redução por estado
            _bc_icms = _valor_total;
            _bc_ipi = _valor_total;
            _bc_icms = _valor_total;

            try
            {
                _valor_ipi = _bc_ipi * Convert.ToDouble(aliq_ipi);
            }
            catch { }
            try
            {
                _valor_icms = _bc_icms * Convert.ToDouble(aliq_icms);

            }
            catch { }



            if (aliq_ipi == "")
                aliq_ipi = "null";
            else
                aliq_ipi = "'" + aliq_ipi.Replace(".", "").Replace(",", ".") + "'";

            if (aliq_icms == "")
                aliq_icms = "null";
            else
                aliq_icms = "'" + aliq_icms.Replace(".", "").Replace(",", ".") + "'";

            cod_item = codFornecedor;
            if (cod_item == "")
                cod_item = "null";
            else
                cod_item = "'" + cod_item + "'";

            descricao_item = descricaoProduto;
            if (descricao_item == "")
                descricao_item = "null";
            else
                descricao_item = "'" + descricao_item + "'";

            unid_item = unidade;
            if (unid_item == "")
                unid_item = "null";
            else
                unid_item = "'" + unid_item + "'";

            qtde_item = qtde;
            if (qtde_item == "")
                qtde_item = "null";
            else
                qtde_item = "'" + qtde_item.Replace(",", ".") + "'";

            cod_vendedor = "";
            if (cod_vendedor == "")
                cod_vendedor = "null";
            else
                cod_vendedor = "'" + cod_vendedor + "'";

            valor_unit_item = valorUnitario;
            if (valor_unit_item == "")
                valor_unit_item = "null";
            else
                valor_unit_item = "'" + valor_unit_item.Replace(".", "").Replace(",", ".") + "'";

            valor_total_item = _valor_total.ToString("n2");
            if (valor_total_item == "")
                valor_total_item = "null";
            else
                valor_total_item = "'" + valor_total_item.Replace(".", "").Replace(",", ".") + "'";

            valor_bc_icms_item = _bc_icms.ToString("n2");
            if (valor_bc_icms_item == "")
                valor_bc_icms_item = "null";
            else
                valor_bc_icms_item = "'" + valor_bc_icms_item.Replace(".", "").Replace(",", ".") + "'";

            valor_bc_ipi_item = _bc_ipi.ToString("n2");
            if (valor_bc_ipi_item == "")
                valor_bc_ipi_item = "null";
            else
                valor_bc_ipi_item = "'" + valor_bc_ipi_item.Replace(".", "").Replace(",", ".") + "'";

            valor_icms_item = _valor_icms.ToString("n2");
            if (valor_icms_item == "")
                valor_icms_item = "null";
            else
                valor_icms_item = "'" + valor_icms_item.Replace(".", "").Replace(",", ".") + "'";

            valor_ipi_item = _valor_ipi.ToString("n2");
            if (valor_ipi_item == "")
                valor_ipi_item = "null";
            else
                valor_ipi_item = "'" + valor_ipi_item.Replace(".", "").Replace(",", ".") + "'";
            string cod_sistema = "null";
            if (codProduto != "")
                cod_sistema = "'" + codProduto + "'";
            string descricao_item_produto = "null";
            if (descricaoItem != "")
                descricao_item_produto = "'" + descricaoItem + "'";
            string marca = "null";
            if (marcaItem != "")
                marca = "'" + marcaItem + "'";
            string prazo = "null";
            if (prazoItem != "")
                prazo = "'" + prazoItem + "'";


            string _qtdeFat = "null";
            try
            {
                _qtdeFat = Convert.ToDouble(qtdeFat).ToString("n2").Replace(".", "").Replace(",", ".");
            }
            catch { }

            try
            {
                this.datItens_ped_venda.InsertCommand.CommandText =
                   "INSERT INTO ITENS_PEDIDO_VENDA (COD_PROD_ITEM_VENDA, DESCRICAO_PROD_ITEM_VENDA, UNIDADE_PROD_ITEM_VENDA, QTDE_ITEM_VENDA, VALOR_UNIT_PROD_ITEM_VENDA, VALOR_TOTAL_PROD_ITEM_VENDA, BC_ICMS_PROD_ITEM_VENDA, ALIQ_ICMS_PROD_ITEM_VENDA, VALOR_ICMS_ITEM_VENDA, " +
                   "BC_IPI_PROD_ITEM_VENDA, ALIQ_IPI_PROD_ITEM_VENDA, VALOR_IPI_ITEM_VENDA, COD_PEDIDO_ITEM_VENDA, COD_VENDEDOR_ITEM_VENDA, DATA_PEDIDO_ITEM_VENDA, " +
                   "COD_SISTEMA_PROD_ITEM_VENDA, DESCRICAO_ITEM_PROD_ITEM_VENDA, MARCA_ITEM_VENDA, PRAZO_ITEM_VENDA, QTDE_FAT_ITEM_VENDA, EAN_ITEM_VENDA) " +
                   "VALUES (" + cod_item + "," + descricao_item + "," + unid_item + "," + qtde_item + "," + valor_unit_item + "," + valor_total_item + "," + valor_bc_icms_item + "," + aliq_icms + "," + valor_icms_item + "," +
                   valor_bc_ipi_item + "," + aliq_ipi + "," + valor_ipi_item + "," + codPedido + "," + cod_vendedor + ",'" +
                   Convert.ToDateTime(tb_data_pedido.Text).ToShortDateString().Replace("/", ".") + "'," + cod_sistema + "," + descricao_item_produto + "," +
                   marca + "," + prazo + "," + _qtdeFat + ",'" + ean + "')";
                this.fbConnection1.Open();
                this.datItens_ped_venda.InsertCommand.Connection = fbConnection1;
                this.datItens_ped_venda.InsertCommand.ExecuteNonQuery();
                this.fbConnection1.Close();
            }
            catch (Exception ex)
            {
                fbConnection1.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelarPedido_Click(object sender, EventArgs e)
        {
            if (cbStatus.Text != "Confirmado")
            {
                if (cbStatus.Text == "Faturado")
                {
                    MessageBox.Show("Não é possível cancelar um pedido que já foi faturado!");
                }
                else
                {
                    if (dgvFatura_pedido.Rows[0].Cells["col_cr_fatura"].Value.ToString() != "")
                        MessageBox.Show("Existem Faturas registradas para esse pedido. Para cancelar o pedido você deve cancelá-las antes.");
                    else
                    {
                        if (MessageBox.Show("Tem certeza que deseja cancelar o pedido?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            try
                            {
                                datPedidos_venda.UpdateCommand.CommandText = "UPDATE pedidos_venda SET cancelado_ped_venda = 1 WHERE cod_ped_venda = " + tb_n_pedido.Text;
                                datPedidos_venda.UpdateCommand.Connection = fbConnection1;
                                fbConnection1.Open();
                                datPedidos_venda.UpdateCommand.ExecuteNonQuery();
                                fbConnection1.Close();

                                cbStatus.Text = "Cancelado";

                                MessageBox.Show("Pedido cancelado com sucesso!");
                            }
                            catch (Exception a)
                            {
                                fbConnection1.Close();
                                MessageBox.Show("Houve um erro ao cancelar o pedido!\nErro: " + a.Message);
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Não é possível cancelar um pedido confirmado!");
            }
        }

        private void tb_cod_fornecedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                if (tb_cod_fornecedor.Text == "")
                { }
                else
                {
                    if (cbTipo.Text.Trim() != "" && cbStatus.Text.Trim() != "")
                    {
                        localizar_item_fornecedor(tb_cod_fornecedor.Text);
                    }
                    else
                    {
                        MessageBox.Show("Preencha o Status e o Tipo do Pedido antes de selecionar os itens.");
                    }

                   
                    // tb_qtde_item.Focus();
                }
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (dgvItens_nota.SelectedRows.Count > 0)
            {
                try
                {
                    if (MessageBox.Show("Tem certeza que deseja excluir o(s) item(ns) do pedido?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        for (int i = 0; i < dgvItens_nota.SelectedRows.Count; i++)
                        {
                            try
                            {
                                FbCommand delete = new FbCommand();
                                delete.CommandText =
                                    "DELETE FROM ITENS_PEDIDO_VENDA WHERE COD_ITEM_VENDA = '" + dgvItens_nota.SelectedRows[i].Cells["col_cod_item_venda"].Value.ToString() + "'";
                                delete.Connection = fbConnection1;
                                fbConnection1.Open();
                                FbDataAdapter datDelete = new FbDataAdapter();
                                datDelete.DeleteCommand = delete;
                                datDelete.DeleteCommand.ExecuteNonQuery();
                                fbConnection1.Close();

                                string _dun, _qtde, _cnpj, _cod;
                                string ean = buscar_ean_produto(dgvItens_nota.SelectedRows[i].Cells["col_cod"].Value.ToString(), out _dun, out _qtde, out _cnpj, out _cod);

                                try
                                {
                                    classeEstoque estoque = new classeEstoque();
                                    estoque.fbConnection1.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=10.3.3.4;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=True;Packet Size=8192;Server Type=0";
                                    estoque.calcular_estoque(dgvItens_nota.SelectedRows[i].Cells["col_cod_forn"].Value.ToString());
                                }
                                catch { }
                            }
                            catch (Exception a)
                            {
                                fbConnection1.Close();
                                MessageBox.Show(a.ToString());
                            }
                        }
                        selecionar_itens();
                    }
                }
                catch (Exception a)
                {
                    fbConnection1.Close();
                }
            }
            else
                MessageBox.Show("Selecione a linha inteira para excluir");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private bool verificar_se_pedido_ja_esta_em_uma_nota(out string n_nf, out string razao_emissor)
        {
            n_nf = ""; razao_emissor = "";
            try
            {

                string cod_ped = tb_n_pedido.Text;
                try
                {
                    FbCommand select = new FbCommand();
                    select.CommandText =
                        "SELECT nf.STATUS_NFE, nf.N_NF, nf.RAZAO_EMISSOR_NF FROM NOTA_FISCAL nf " +
                        " INNER JOIN PEDIDOS_NF pnf ON nf.COD_SISTEMA_NF = pnf.COD_SISTEMA_PEDIDO_NF " +
                        " WHERE pnf.N_PEDIDO_NF = '" + cod_ped + "'";
                    select.Connection = fbConnection1;
                    fbConnection1.Open();
                    FbDataAdapter datSelect = new FbDataAdapter();
                    datSelect.SelectCommand = select;
                    DataTable dtSelect = new DataTable();
                    datSelect.Fill(dtSelect);
                    fbConnection1.Close();
                    foreach (DataRow dr in dtSelect.Rows)
                    {
                        if (!dr[0].ToString().Contains("Cancelada"))
                        {
                            n_nf = dr[1].ToString();
                            razao_emissor = dr[2].ToString();
                            //MessageBox.Show("O Pedido " + cod_ped + " já foi inserido na Nota Fiscal número " + dr[1].ToString());
                            return true;
                        }
                    }
                    //return false;
                }
                catch (Exception a)
                {
                    fbConnection1.Close();
                    MessageBox.Show(a.ToString());
                }


                return false;
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                return false;
            }
        }


        private void button7_Click_1(object sender, EventArgs e)
        {
            string n_nf, razao_emissor;
            if (!verificar_se_pedido_ja_esta_em_uma_nota(out n_nf, out razao_emissor))
            {
                if (cbStatus.Text == "Confirmado")
                {
                    form_faturamento nf = new form_faturamento(cnpj_empresa);
                    try
                    {
                        nf.nova_nota = true;
                        nf.n_pedido = Convert.ToInt32(tb_n_pedido.Text);
                        nf.transportadora = tb_transportadora.Text;
                        nf.qtde_caixa = tb_qtde_caixas.Text;
                        nf.ShowDialog();
                    }
                    finally
                    {

                    }
                }
                else
                    MessageBox.Show("O pedido deve estar confirmado para faturar.");
            }
            else
                MessageBox.Show("Esse pedido já está lançado na nota " + n_nf + " da Empresa: " + razao_emissor);
        }

        private void form_pedidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*
            if (e.KeyChar == 13)
            {

                //  e.Handled = true;

                SendKeys.Send("{tab}");

            }
            */
        }

        private void tb_cod_fornecedor_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void tb_cod_fornecedor_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void button33_Click(object sender, EventArgs e)
        {
            double valor_total = 0;
            double valor_total_st = 0;
            double qtde_total = 0;
            double valor_total_ipi = 0;
            double valor_desejado = 0;
            for (int i = 0; i < dgvItens_nota.RowCount; i++)
            {
                double valor_parcial = 0;
                try
                {

                    qtde_total = qtde_total + Convert.ToDouble(dgvItens_nota.Rows[i].Cells["col_qtde"].Value);



                    valor_parcial = Convert.ToDouble(dgvItens_nota.Rows[i].Cells["col_valor_unit"].Value.ToString()) * Convert.ToDouble(dgvItens_nota.Rows[i].Cells["col_qtde"].Value.ToString());
                    try
                    {
                        valor_desejado += Convert.ToDouble(dgvItens_nota.Rows[i].Cells["col_valor_unit"].Value.ToString()) * Convert.ToDouble(dgvItens_nota.Rows[i].Cells["col_qtde_fat"].Value.ToString());

                    }
                    catch { }
                    valor_total = valor_total + valor_parcial;
                    dgvItens_nota.Rows[i].Cells["col_valor_total"].Value = valor_parcial;
                    double valor_st_item = 0;
                    try
                    {

                        // valor_st_item = calcular_st_item(valor_parcial, tb_cnpj_cliente.Text, dgvItens_nota.Rows[i].Cells["col_cod"].Value.ToString());
                        // dgvItens_nota.Rows[i].Cells["col_valor_st"].Value = valor_st_item.ToString();
                        valor_total_st += Convert.ToDouble(dgvItens_nota.Rows[i].Cells["col_valor_st"].Value.ToString());


                    }
                    catch { }

                    try
                    {

                        // valor_st_item = calcular_st_item(valor_parcial, tb_cnpj_cliente.Text, dgvItens_nota.Rows[i].Cells["col_cod"].Value.ToString());
                        // dgvItens_nota.Rows[i].Cells["col_valor_st"].Value = valor_st_item.ToString();
                        valor_total_ipi += Convert.ToDouble(dgvItens_nota.Rows[i].Cells["col_valor_ipi"].Value.ToString());


                    }
                    catch { }

                }
                catch { }

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (tb_data_prevista.Text != "")
            {
                if (dgvFatura_pedido.RowCount > 0 && dgvFatura_pedido.Rows[0].Cells["col_cr_fatura"].Value.ToString() != "")
                    MessageBox.Show("Já existem Faturas registradas para esse pedido. Para gerar novas faturas você deve cancelá-las antes.");
                else
                {
                    if (tb_total_pedido.Text != "")
                    {

                        form_forma_pgto localiza_forma = new form_forma_pgto();
                        try
                        {
                            localiza_forma.forma_pgto_ja_escolhida = "";
                            localiza_forma.busca_forma_escolhida = true;
                            localiza_forma.ShowDialog();
                        }
                        finally
                        {
                            localiza_forma.Dispose();
                            //MessageBox.Show(localiza_peca.peca_escolhida);
                            tb_forma_pgto.Text = localiza_forma.forma_pgto_escolhida;
                            apaga_faturas_anteriores();
                            acertar_faturas(localiza_forma.n_parcelas, localiza_forma.prazo_1, localiza_forma.prazo_2, localiza_forma.prazo_3,
                                        localiza_forma.prazo_4, localiza_forma.prazo_5, localiza_forma.prazo_6,
                                        localiza_forma.prazo_7, localiza_forma.prazo_8, localiza_forma.prazo_9,
                                        localiza_forma.prazo_10, localiza_forma.prazo_11, localiza_forma.prazo_12);
                            try
                            {

                                dsFped.Clear();
                                this.datFped.SelectCommand.CommandText =
                               "SELECT * FROM FATURA_PEDIDO WHERE N_PEDIDO_FATURA_PED = '" + tb_n_pedido.Text + "'";
                                this.fbConnection1.Open();
                                this.datFped.SelectCommand.Connection = fbConnection1;
                                this.datFped.SelectCommand.ExecuteNonQuery();
                                datFped.Fill(FATURA_PEDIDO);
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
            }
            else
            {
                MessageBox.Show("Para gerar as datas de provisionamento, digite a data de entrega prevista");
                tb_data_prevista.BackColor = Color.Orange;
                tb_data_prevista.Focus();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            gerar_boletos();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string cr = "";
            try
            {
                cr = dgvFatura_pedido.Rows[0].Cells["col_cr_fatura"].Value.ToString();
            }
            catch { }
            if (cr != "")
                MessageBox.Show("Já existem Faturas registradas para esse pedido. Para gerar novas faturas você deve cancelá-las antes.");
            else
            {
                if (tb_forma_pgto.Text == "")
                {
                    buscar_forma_pgto(tb_cnpj_cliente.Text);
                }
            }
        }

        private void Reabrir_Click(object sender, EventArgs e)
        {
            if (cbStatus.Text != "Faturado")
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
                        if (usuario._cod_usuario == "1" || usuario._cod_usuario == "2" || usuario._cod_usuario == "3" || usuario._cod_usuario == "4")
                        {
                            cbStatus.Text = "Aguardando Confirmação";

                            salvar();
                            try
                            {
                                FbCommand update = new FbCommand();
                                update.CommandText =
                                    "UPDATE PEDIDOS_VENDA SET BAIXADO_ESTOQUE_PED_VENDA = 0 where COD_PED_VENDA = '" + tb_n_pedido.Text + "'";
                                update.Connection = fbConnection1;
                                fbConnection1.Open();
                                FbDataAdapter datUpdate = new FbDataAdapter();
                                datUpdate.UpdateCommand = update;
                                datUpdate.UpdateCommand.ExecuteNonQuery();
                                fbConnection1.Close();

                                desconfirmar_todos_itens();



                            }
                            catch { fbConnection1.Close(); }
                            // System.Threading.Thread.Sleep(1000);
                            baixar_do_estoque();
                            salvar();
                        }
                        else
                        {
                            MessageBox.Show("Usuário não autorizado");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Não é possivel editar um pedido Faturado!");
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            imprimir_pedido();
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

                Declaracoes.iRetorno = Declaracoes.iImprimirBMP_DUAL_DarumaFramework(@"e:c:\\evolucao\\logo_nfce.bmp");
                //Declaracoes.iRetorno = Declaracoes.iImprimirTexto_DUAL_DarumaFramework(@"<tb>texto1</tb><tb><ibmp>e:c:\\evolucao\\logo_nfce.bmp</ibmp></tb><tb>texto</tb>", 0);



                string itens = "";
                for (int i = 0; i < dgvItens_nota.RowCount; i++)
                {
                    string codigo = zero(6, dgvItens_nota.Rows[i].Cells["col_cod"].Value.ToString());
                    if (codigo == "")
                        codigo = zero(6, dgvItens_nota.Rows[i].Cells["col_cod"].Value.ToString());
                    string descricao = dgvItens_nota.Rows[i].Cells["col_descricao"].Value.ToString();
                    if (descricao.Length > 30)
                        descricao = descricao.Remove(30);
                    else
                    {
                        while (descricao.Length != 30)
                            descricao = descricao + " ";
                    }
                    int item = i + 1;
                    itens = itens + "<l>" + codigo + "   " + descricao + " " +
                        "<tb> " + Convert.ToDouble(dgvItens_nota.Rows[i].Cells["col_qtde"].Value.ToString()).ToString("n3") + " </ad></l>" +
                        "<l></l>" +
                        "<l></l>" +
                        "<l><tc>_</tc></l>";
                    // i++;
                }
                Declaracoes.iRetorno = Declaracoes.iImprimirTexto_DUAL_DarumaFramework(@"<e><ce>SEPARAÇÃO DE PEDIDO</e></ce>" +
@"<l><tc>-</tc></l><b>" +
razao_social_empresa + @"<l>" +
@"CNPJ: " + cnpj_empresa + @"/IE: " + ie_empresa + @"</l></b>" +
@"<l><tc>-</tc></l><b>" +
@"<l><tc>-</tc></l><b>" +
@"<l><b>CLIENTE:</b> " + tb_cliente.Text + "</l>" +
@"<l><tc>-</tc></l><b>" +
@"<l><tc>-</tc></l><b>" +
@"<l>Pedido n.: " + tb_n_pedido.Text + " " + @" Data:<dt></dt> Hora:<hr></hr></l>" +
@"<l><tc>-</tc></l><b>" +
@"<l><b>Código   Descrição" +
@"<tb><tb><tb>Qtde </l></b>" +
@"<l><tc>-</tc></l><b>" +
@"</b></c>" + itens +
@"<l><tc>-</tc></l>" +
@"<l>" + tb_obs.Text + "</l>" +
@"<l><tc>-</tc></l>" +
@"<l></l>" +
@"<l></l>" +
@"<l></l>" +
@"<l></l>" +
@"<l></l>" +
@"<l></l>" +
@"<l></l>" +
@"<gui></gui>", 0);

                if (Declaracoes.iRetorno == 1)
                {
                    MessageBox.Show("Impressao Concluida!", "Daruma_Framework_CSharp", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Erro ao realizar a impressão do BUFFER!", "Daruma_Framework_CSharp", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }

        }

        private void button15_Click(object sender, EventArgs e)
        {
            imprimir_op();
        }

        public string retornaImpressoraPadrao()
        {
            PrintDocument pd = new PrintDocument();
            return pd.PrinterSettings.PrinterName;
        }

        [DllImport("winspool.drv", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetDefaultPrinter(string Name);

        private void button16_Click(object sender, EventArgs e)
        {
            string impressoraPadraoOriginal = retornaImpressoraPadrao();
            string impressoraEtiqueta = "ZDesigner TLP 2844";
            try
            {

                SetDefaultPrinter(impressoraEtiqueta);



                dsEtiquetas ds = new dsEtiquetas();
                try
                {
                    FbCommand select = new FbCommand();
                    select.CommandText =
                        "SELECT * FROM EMPRESA WHERE LICENCA_DLL_NFE_EMPRESA IS NOT NULL";
                    select.Connection = fbConnection1;
                    fbConnection1.Open();
                    FbDataAdapter datSelect = new FbDataAdapter();
                    datSelect.SelectCommand = select;
                    DataTable dtSelect = new DataTable();
                    datSelect.Fill(ds.EMPRESA);
                    fbConnection1.Close();

                }
                catch (Exception a)
                {
                    fbConnection1.Close();
                    MessageBox.Show(a.ToString());
                }
                for (int i = 0; i < dgvItens_nota.SelectedRows.Count; i++)
                {
                    try
                    {
                        for (int j = 0; j < Convert.ToInt32(dgvItens_nota.SelectedRows[i].Cells["col_qtde"].Value.ToString()); j++)
                        {
                            ds.Produtos.AddProdutosRow(dgvItens_nota.SelectedRows[i].Cells["col_cod_forn"].Value.ToString(),
                                dgvItens_nota.SelectedRows[i].Cells["col_descricao"].Value.ToString(),
                                DateTime.Now, Convert.ToInt32(tb_n_pedido.Text), "");
                        }
                    }
                    catch { }
                }
                crEtiquetas cr = new crEtiquetas();
                cr.SetDataSource(ds);
                form_imprimir print = new form_imprimir(cr);
                print.Show();
            }
            finally
            {
                SetDefaultPrinter(impressoraPadraoOriginal);
            }

        }

        private void criar_copia_filho()
        {
            try
            {
                string ultimo_pedido = buscar_ultimo_pedido_empresa(cnpj_empresa);
                int proximo_pedido = Convert.ToInt32(ultimo_pedido) + 1;

                FbCommand insert = new FbCommand();
                insert.Connection = fbConnection1;
                insert.CommandText =
                 "INSERT INTO PEDIDOS_VENDA " +
                                    "(DATA_PED_VENDA," +
                                    "CLIENTE_PED_VENDA, " +
                                    "CNPJ_PED_VENDA, " +
                                    "VENDEDOR_PED_VENDA, " +
                                    "COD_VENDEDOR_PED_VENDA, " +
                                    "COD_PEDIDO_PAI_PED_VENDA, " +
                                    "NOME_CONTATO_PED_VENDA, " +
                                    "TELEFONE_CONTATO_PED_vENDA, " +
                                    "EMAIL_CONTATO_PED_VENDA, CNPJ_EMISSOR_PED_VENDA, RAZAO_EMISSOR_PED_VENDA, N_PED_VENDA" +
                                    ")" +
                                    "VALUES ('" + DateTime.Now.ToShortDateString().Replace("/", ".") + "'," +
                                    "'" + tb_cliente.Text + "'," +
                                    "'" + tb_cnpj_cliente.Text + "'," +
                                   "'" + tb_vendedor.Text + "'," +
                                    tb_cod_vendedor.Text + ", " +
                                    "'" + tb_n_ped_novo.Text + "', " +
                                    "'" + contatotextBox.Text + "', " +
                                    "'" + teltextBox.Text + "', " +
                                    "'" + emailtextBox.Text + "','" + tb_cnpj_empresa.Text + "','" + tb_descricao_empresa.Text + "','" + proximo_pedido.ToString() + "'" + 
                                    ") returning cod_ped_venda";
                fbConnection1.Open();
                FbDataAdapter datInsert = new FbDataAdapter();
                datInsert.InsertCommand = insert;
                int cod_ped = Convert.ToInt32(datInsert.InsertCommand.ExecuteScalar());
                fbConnection1.Close();

                for (int i = 0; i < dgvItens_nota.RowCount; i++)
                {
                    try
                    {
                        if (Convert.ToDouble(dgvItens_nota.Rows[i].Cells["col_qtde_ped_filho"].Value.ToString()) <= Convert.ToDouble(dgvItens_nota.Rows[i].Cells["col_qtde"].Value.ToString()))
                        {
                            string ean = dgvItens_nota.Rows[i].Cells["col_ean"].Value.ToString();
                            double custo = 0;

                            if (ean == "")
                                ean = "null";
                            else
                                ean = "'" + ean + "'";

                            try
                            {
                                custo = Convert.ToDouble(dgvItens_nota.Rows[i].Cells["col_custo"].Value.ToString());
                            }
                            catch { }
                            FbCommand insert_itens = new FbCommand();
                            insert_itens.Connection = fbConnection1;
                            insert_itens.CommandText =
                             "INSERT INTO ITENS_PEDIDO_VENDA " +
                                                                "(QTDE_ITEM_VENDA," +
                                                                "DESCRICAO_PROD_ITEM_VENDA, " +
                                                                "VALOR_UNIT_PROD_ITEM_VENDA, " +
                                                                "UNIDADE_PROD_ITEM_VENDA, " +
                                                                "COD_PEDIDO_ITEM_VENDA, " +
                                                                "COD_VENDEDOR_ITEM_VENDA, " +
                                                                "COD_SISTEMA_PROD_ITEM_VENDA, " +
                                                                "COD_PROD_ITEM_VENDA, " +
                                                                "EAN_ITEM_VENDA, CUSTO_ITEM_VENDA) " +
                                                                "VALUES ('" + dgvItens_nota.Rows[i].Cells["col_qtde_ped_filho"].Value.ToString().Replace(".", "").Replace(",", ".")
                                                                + "'," +
                                                                "'" + dgvItens_nota.Rows[i].Cells["col_descricao"].Value.ToString() + "','" +
                                                                dgvItens_nota.Rows[i].Cells["col_valor_unit"].Value.ToString().Replace(".", "").Replace(",", ".") + "'," +
                                                               "'" + dgvItens_nota.Rows[i].Cells["col_unidade"].Value.ToString() + "'," +
                                                                cod_ped.ToString() + "," +
                                                                tb_cod_vendedor.Text + "," +
                                                                dgvItens_nota.Rows[i].Cells["col_cod"].Value.ToString() + ", '" +
                                                                dgvItens_nota.Rows[i].Cells["col_cod_forn"].Value.ToString() +
                                                                "', " + ean + ",'" +
                                                                custo.ToString().Replace(".", "").Replace(",", ".") + "')";
                            fbConnection1.Open();
                            FbDataAdapter datInsert_itens = new FbDataAdapter();
                            datInsert_itens.InsertCommand = insert_itens;
                            datInsert_itens.InsertCommand.ExecuteNonQuery();
                            fbConnection1.Close();


                            FbCommand update = new FbCommand();
                            update.Connection = fbConnection1;
                            update.CommandText =
                                "UPDATE ITENS_PEDIDO_VENDA SET QTDE_ITEM_VENDA = QTDE_ITEM_VENDA - " + dgvItens_nota.Rows[i].Cells["col_qtde_ped_filho"].Value.ToString().Replace(".", "").Replace(",", ".") + " WHERE " +
                                " COD_ITEM_VENDA = '" + dgvItens_nota.Rows[i].Cells["col_cod_item_venda"].Value.ToString() + "'";
                            fbConnection1.Open();
                            FbDataAdapter datUpdate = new FbDataAdapter();
                            datUpdate.UpdateCommand = update;
                            datUpdate.UpdateCommand.ExecuteNonQuery();
                            fbConnection1.Close();
                        }
                        else
                        {
                            MessageBox.Show("A quantidade do pedido filho tem que ser menor ou igual a quantidade do pedido pai.");
                        }
                    }
                    catch { fbConnection1.Close(); }
                }

                form_pedidos ped_filho = new form_pedidos(cnpj_empresa);
                ped_filho.abrir = true;
                ped_filho.cod_a_abrir = cod_ped.ToString();
                try
                {
                    ped_filho.ShowDialog();
                }
                finally
                {
                    localizar_pedido(tb_n_pedido.Text);
                }



            }
            catch
            {
                fbConnection1.Close();
                MessageBox.Show("Erro");
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (tb_n_pedido.Text != "")
            {
                if (MessageBox.Show("Deseja gerar um novo pedido a partir deste pedido?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    criar_copia_filho();
                }
            }
            else
            {
                MessageBox.Show("É necessário selecionar um pedido para fazer a cópia!");
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (tb_n_pedido.Text != "")
            {
                if (MessageBox.Show("Deseja gerar um novo pedido a partir deste pedido?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    transferir_filho();
                }
            }
            else
            {
                MessageBox.Show("É necessário selecionar um pedido para fazer a cópia!");
            }
        }

        private void transferir_filho()
        {
            try
            {

                int cod_ped = Convert.ToInt32(tb_pedido_destino.Text);

                for (int i = 0; i < dgvItens_nota.RowCount; i++)
                {
                    try
                    {
                        if (Convert.ToDouble(dgvItens_nota.Rows[i].Cells["col_qtde_ped_filho"].Value.ToString()) <= Convert.ToDouble(dgvItens_nota.Rows[i].Cells["col_qtde"].Value.ToString()))
                        {

                            FbCommand insert_itens = new FbCommand();
                            insert_itens.Connection = fbConnection1;
                            insert_itens.CommandText =
                             "INSERT INTO ITENS_PEDIDO_VENDA " +
                                                                "(QTDE_ITEM_VENDA," +
                                                                "DESCRICAO_PROD_ITEM_VENDA, " +
                                                                "VALOR_UNIT_PROD_ITEM_VENDA, " +
                                                                "UNIDADE_PROD_ITEM_VENDA, " +
                                                                "COD_PEDIDO_ITEM_VENDA, " +
                                                                "COD_VENDEDOR_ITEM_VENDA, " +
                                                                "COD_SISTEMA_PROD_ITEM_VENDA, " +
                                                                "COD_PROD_ITEM_VENDA, " +
                                                                "EAN_ITEM_VENDA, CUSTO_ITEM_VENDA) " +
                                                                "VALUES ('" + dgvItens_nota.Rows[i].Cells["col_qtde_ped_filho"].Value.ToString().Replace(".", "").Replace(",", ".")
                                                                + "'," +
                                                                "'" + dgvItens_nota.Rows[i].Cells["col_descricao"].Value.ToString() + "','" +
                                                                dgvItens_nota.Rows[i].Cells["col_valor_unit"].Value.ToString().Replace(".", "").Replace(",", ".") + "'," +
                                                               "'" + dgvItens_nota.Rows[i].Cells["col_unidade"].Value.ToString() + "'," +
                                                                cod_ped.ToString() + "," +
                                                                tb_cod_vendedor.Text + "," +
                                                                dgvItens_nota.Rows[i].Cells["col_cod"].Value.ToString() + ", '" +
                                                                dgvItens_nota.Rows[i].Cells["col_cod_forn"].Value.ToString() +
                                                                "','" + dgvItens_nota.Rows[i].Cells["col_ean"].Value.ToString() + "','" +
                                                                dgvItens_nota.Rows[i].Cells["col_custo"].Value.ToString().Replace(".", "").Replace(",", ".") + "')";
                            fbConnection1.Open();
                            FbDataAdapter datInsert_itens = new FbDataAdapter();
                            datInsert_itens.InsertCommand = insert_itens;
                            datInsert_itens.InsertCommand.ExecuteNonQuery();
                            fbConnection1.Close();


                            FbCommand update = new FbCommand();
                            update.Connection = fbConnection1;
                            update.CommandText =
                                "UPDATE ITENS_PEDIDO_VENDA SET QTDE_ITEM_VENDA = QTDE_ITEM_VENDA - " + dgvItens_nota.Rows[i].Cells["col_qtde_ped_filho"].Value.ToString().Replace(".", "").Replace(",", ".") + " WHERE " +
                                " COD_ITEM_VENDA = '" + dgvItens_nota.Rows[i].Cells["col_cod_item_venda"].Value.ToString() + "'";
                            fbConnection1.Open();
                            FbDataAdapter datUpdate = new FbDataAdapter();
                            datUpdate.UpdateCommand = update;
                            datUpdate.UpdateCommand.ExecuteNonQuery();
                            fbConnection1.Close();
                        }
                        else
                        {
                            MessageBox.Show("A quantidade do pedido filho tem que ser menor ou igual a quantidade do pedido pai.");
                        }
                    }
                    catch { fbConnection1.Close(); }
                }

                form_pedidos ped_filho = new form_pedidos(cnpj_empresa);
                ped_filho.abrir = true;
                ped_filho.cod_a_abrir = cod_ped.ToString();
                try
                {
                    ped_filho.ShowDialog();
                }
                finally
                {
                    localizar_pedido(tb_n_pedido.Text);
                }



            }
            catch
            {
                fbConnection1.Close();
                MessageBox.Show("Erro");
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            //if (DialogResult.Yes == MessageBox.Show("Essa operação irá criar um novo boleto de Pedido. Não será permitido criar um Nota Fiscal nesse caso. Tem certeza?",
            // "Confirma?", MessageBoxButtons.YesNo))
            // {
            if (dgvFatura_pedido.Rows[0].Cells["col_cr_fatura"].Value.ToString() != "")
                MessageBox.Show("Já existem Faturas registradas para esse pedido. Para gerar novas faturas você deve cancelá-las antes.");
            else
            {
                //form_usuario usuario = new form_usuario();

                //try
                //{
                //    usuario.ShowDialog();
                //}
                //finally
                //{
                //    if (usuario.confirmado == true)
                //    {
                //        if 
                //           (usuario._cod_usuario == "1" || usuario._cod_usuario == "2")
                //        {
                //            inserir_duplicatas_cr();
                //        }
                //        else
                //        {
                //            MessageBox.Show("Usuário não autorizado");
                //        }
                //    }
                //}

                inserir_duplicatas_cr();
            }
            //}
        }

        private void button20_Click(object sender, EventArgs e)
        {
            form_localiza_tabela_preco tab = new form_localiza_tabela_preco();
            try
            {
                tab.ShowDialog();
            }
            finally
            {
                tb_cod_tabela.Text = tab._cod;
                tb_nome_tabela_preco.Text = tab._descricao;

            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Essa operação irá cancelar o boleto do Pedido. Tem certeza?",
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
                        if (usuario._cod_usuario == "1" || usuario._nivel_acesso_usuario == "1")
                        {
                            apagar_itens_cr();
                            selecionar_faturas();

                        }
                    }
                }
            }
        }

        private void tb_time_correto_Validated(object sender, EventArgs e)
        {
            try
            {

                tb_time_correto.Text = Convert.ToDateTime(tb_time_correto.Text).ToShortTimeString();
            }
            catch { }
        }

        private void tb_time_correto_Validating(object sender, CancelEventArgs e)
        {
            try
            {

                tb_time_correto.Text = Convert.ToDateTime(tb_time_correto.Text).ToShortTimeString();
            }
            catch { }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Essa operação irá marcar PV. Tem certeza?",
            "Confirma?", MessageBoxButtons.YesNo))
            {
                //form_usuario usuario = new form_usuario();

                //try
                //{
                //    usuario.ShowDialog();
                //}
                //finally
                //{
                //    if (usuario.confirmado == true)
                //    {
                //        if (usuario._cod_usuario == "1" || usuario._cod_usuario == "2")
                //        {
                //            cbPv.Checked = true;
                //            salvar();
                //        }
                //    }
                //}
                cbPv.Checked = true;
                salvar();
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            form_localiza_transportadora localiza_transportadora = new form_localiza_transportadora();
            try
            {
                localiza_transportadora.ShowDialog();
            }
            finally
            {
                localiza_transportadora.Dispose();
                tb_transportadora.Text = localiza_transportadora.transportadora_escolhida;
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (tb_porc_desejada.Text != "")
            {
                for (int i = 0; i < dgvItens_nota.RowCount; i++)
                {
                    decimal qtde_desejada = Convert.ToInt32(dgvItens_nota.Rows[i].Cells["col_qtde"].Value.ToString()) * Convert.ToDecimal(tb_porc_desejada.Text) / 100;
                    int int_qtde = Convert.ToInt32(qtde_desejada);
                    dgvItens_nota.Rows[i].Cells["col_qtde_fat"].Value = int_qtde.ToString();

                }
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            salvar();
            imprimirDesejada(false);
        }

        private void dgvItens_nota_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void button26_Click(object sender, EventArgs e)
        {
            string ultimo_pedido;
            int proximo_pedido;
            form_selecionar_empresa emp = new form_selecionar_empresa();
            try
            {
                emp.busca_dentro = true;
                emp.ShowDialog();
            }
            finally
            {
                if (!verificar_se_tem_pedido_com_mesmo_numero(emp.cnpj_empresa_emissora))
                {
                    tb_cnpj_empresa.Text = emp.cnpj_empresa_emissora;
                    tb_descricao_empresa.Text = emp.empresa_emissora;
                    salvar();
                }
                else
                {
                    ultimo_pedido = buscar_ultimo_pedido_empresa(emp.cnpj_empresa_emissora);
                    proximo_pedido = Convert.ToInt32(ultimo_pedido) + 1;
                    tb_n_ped_novo.Text = proximo_pedido.ToString();
                    tb_cnpj_empresa.Text = emp.cnpj_empresa_emissora;
                    tb_descricao_empresa.Text = emp.empresa_emissora;
                    salvar();

                }
            }
        }

        private bool verificar_se_tem_pedido_com_mesmo_numero(string cnpj_novo)
        {
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                        "SELECT FIRST(1) N_PED_VENDA FROM PEDIDOS_VENDA pv WHERE CNPJ_EMISSOR_PED_VENDA = '" + cnpj_novo + "' and N_PED_VENDA = '" + tb_n_ped_novo.Text + "'";
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
            catch (Exception a)
            {
                fbConnection1.Close();
                return false;
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            try
            {
                FbCommand update = new FbCommand();
                update.Connection = fbConnection1;
                fbConnection1.Open();
                update.CommandText =
                        "UPDATE PEDIDOS_VENDA SET DATA_BAIXA_PED_VENDA = '" + Convert.ToDateTime(tb_data_entrega_realizada.Text).ToShortDateString().Replace("/", ".") + "' " +
                        "WHERE COD_PED_VENDA = '" + tb_n_pedido.Text + "'";
                FbDataAdapter datUpdate = new FbDataAdapter();
                datUpdate.UpdateCommand = update;
                datUpdate.UpdateCommand.ExecuteNonQuery();
                fbConnection1.Close();
            }
            catch (Exception a)
            {
                fbConnection1.Close();
            }
        }

        private void buscar_dados_estoque(string cod_estoque, out string cod_item, out string descricao_item, out string ncm_item, out string unidade_item)
        {
            cod_item = ""; descricao_item = ""; ncm_item = ""; unidade_item = "";
            try
            {
                FbCommand selectLotes = new FbCommand();
                selectLotes.Connection = fbConnection1;
                selectLotes.CommandText =
                    @"SELECT * FROM ESTOQUE 
                    WHERE COD_ESTOQUE = '" + cod_estoque + "'";
                FbDataAdapter datSelectLotes = new FbDataAdapter();
                datSelectLotes.SelectCommand = selectLotes;
                DataTable dtSelectLotes = new DataTable();
                datSelectLotes.Fill(dtSelectLotes);
                fbConnection1.Close();
                foreach (DataRow dr in dtSelectLotes.Rows)
                {
                    cod_item = dr["item_estoque"].ToString();
                    descricao_item = dr["DESCRICAO_ESTOQUE"].ToString();
                    ncm_item = dr["NCM_ESTOQUE"].ToString();
                    unidade_item = dr["UNIDADE_ESTOQUE"].ToString();
                }

            }
            catch { fbConnection1.Close(); }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            DataTable dtFaltantes = new DataTable();
            DataColumn col_cod = new DataColumn();
            col_cod.ColumnName = "COD";
            DataColumn col_qtde_faltante = new DataColumn();
            col_qtde_faltante.ColumnName = "QTDE";
            dtFaltantes.Columns.Add(col_cod);
            dtFaltantes.Columns.Add(col_qtde_faltante);

            bool falta_material = false;
            for (int i = 0; i < dgvItens_nota.Rows.Count; i++)
            {
                FbCommand selectItens = new FbCommand();
                selectItens.Connection = fbConnection1;
                fbConnection1.Open();
                selectItens.CommandText =
                   @"select  sum(QTDE_ITEM_VENDA) 
from itens_pedido_venda iped
inner join pedidos_venda pv on iped.COD_PEDIDO_ITEM_VENDA = pv.COD_PED_VENDA 
where COD_PROD_ITEM_VENDA = '" + dgvItens_nota.Rows[i].Cells["col_cod_forn"].Value.ToString() + @"' and (pv.BAIXADO_ESTOQUE_PED_VENDA IS NULL OR pv.BAIXADO_ESTOQUE_PED_VENDA = 0)";

                FbDataAdapter datSelectItens = new FbDataAdapter();
                datSelectItens.SelectCommand = selectItens;
                DataTable dtSelectItens = new DataTable();
                datSelectItens.Fill(dtSelectItens);
                fbConnection1.Close();

                double qtde = 0; // Convert.ToDouble(dgvItens_nota.Rows[i].Cells["col_qtde"].Value.ToString());
                foreach (DataRow dr in dtSelectItens.Rows)
                {
                    try
                    {
                        qtde = Convert.ToDouble(dr[0].ToString());
                    }
                    catch { }
                }
                try
                {
                    FbCommand select = new FbCommand();
                    select.Connection = fbConnection1;
                    fbConnection1.Open();
                    select.CommandText =
                       @"select iprod.cod_estoque_ip, sum(iprod.qtde_ip * prok.qtde_pk) as qtde_mp
from produtos prod
left join produtos_kit prok on prod.cod_produto = prok.cod_kit_pk
left join itens_produto iprod on prok.cod_produto_pk = iprod.cod_produto_ip
where  prod.cod_fornecedor_produto = '" + dgvItens_nota.Rows[i].Cells["col_cod_forn"].Value.ToString() + @"'
group by iprod.cod_estoque_ip";
                    FbDataAdapter datSelect = new FbDataAdapter();
                    datSelect.SelectCommand = select;
                    DataTable dtSelect = new DataTable();
                    datSelect.Fill(dtSelect);
                    fbConnection1.Close();
                    foreach (DataRow dr in dtSelect.Rows)
                    {
                        if (dr["cod_estoque_ip"].ToString() != "")
                        {
                            try
                            {
                                FbCommand selectLotes = new FbCommand();
                                selectLotes.Connection = fbConnection1;
                                selectLotes.CommandText =
                                    @"SELECT SUM(lr.QTDE_LR) as QTDE_LR FROM LOTE_RECEBIMENTO lr 
                    inner join ITENS_NOTA_ENT inf on lr.COD_LR = inf.LOTE_ITEM_ENT 
                    WHERE COD_PRODUTO_LR = '" + dr["cod_estoque_ip"].ToString() + "'";
                                FbDataAdapter datSelectLotes = new FbDataAdapter();
                                datSelectLotes.SelectCommand = selectLotes;
                                DataTable dtSelectLotes = new DataTable();
                                datSelectLotes.Fill(dtSelectLotes);

                                fbConnection1.Close();
                                decimal qtde_necessaria = Convert.ToDecimal(qtde) * Convert.ToDecimal(dr["qtde_mp"].ToString());
                                decimal qtde_mp = Convert.ToDecimal(qtde) * Convert.ToDecimal(dr["qtde_mp"].ToString());
                                decimal qtde_empenhada = 0;
                                decimal qtde_encontrada = 0;
                                bool finalizado = false;
                                string cod_item = "", descricao_item = "", qtde_item = "", ncm_item = "", valor_item = "", cfop_item = "", unidade_item = "";
                                buscar_dados_estoque(dr["cod_estoque_ip"].ToString(), out cod_item, out descricao_item, out ncm_item, out unidade_item);
                                foreach (DataRow drLotes in dtSelectLotes.Rows)
                                {
                                    try
                                    {

                                        decimal qtde_a_inserir_do_lote = 0;
                                        qtde_encontrada = Convert.ToDecimal(drLotes["QTDE_LR"].ToString());
                                        if (qtde_encontrada >= qtde_necessaria)
                                        {
                                            qtde_empenhada = qtde_necessaria;
                                            qtde_a_inserir_do_lote = qtde_necessaria;

                                            finalizado = true;
                                        }
                                        else
                                        {
                                            qtde_a_inserir_do_lote = qtde_encontrada;
                                            qtde_empenhada += qtde_encontrada;
                                            qtde_necessaria = qtde_necessaria - qtde_encontrada;

                                        }

                                        qtde_item = qtde_a_inserir_do_lote.ToString();


                                        //    unidade_item = "KG";
                                        //if (tb_estado_cliente.Text == estado_empresa)
                                        //    cfop_item = "5902";
                                        //if (tb_estado_cliente.Text != estado_empresa)
                                        //    cfop_item = "6902";

                                        //inserir_itens_retorno(cod_item, descricao_item + " NF: " + drLotes["NOTA_FISCAL_LR"].ToString(), qtde_item, ncm_item, valor_item, cfop_item, drLotes["COD_LR"].ToString(), unidade_item);
                                    }

                                    catch { }

                                }
                                if (!finalizado)
                                {
                                    falta_material = true;
                                    dtFaltantes.Rows.Add(cod_item, qtde_necessaria);
                                    // MessageBox.Show("O material " + cod_item + " não tem o estoque necessário. Disponível: " + qtde_empenhada.ToString("n3") + ". Necessária: " + qtde_mp.ToString("n3") + ". Por favor verifique antes de continuar");
                                }
                            }
                            catch (Exception ex)
                            {
                                fbConnection1.Close();
                                MessageBox.Show(ex.Message);
                            }
                        }
                        else
                        {
                            MessageBox.Show("O Produto " + dgvItens_nota.Rows[i].Cells["col_cod_forn"].Value.ToString() + " não tem material cadastrado");
                        }
                    }
                }
                catch(Exception ex)
                {
                    fbConnection1.Close();
                    MessageBox.Show(ex.Message);
                }

            }
            if (dtFaltantes.Rows.Count > 0)
            {
                MessageBox.Show("Para atender esse pedido serão necessários os materiais adicionais a seguir.");
                dtFaltantes.TableName = "MaterialFaltantePedido" + tb_n_ped_novo.Text;
                gerarExcel(dtFaltantes, @"e:c:\\evolucao\\excel\" + dtFaltantes.TableName + ".xlsx");
                System.Diagnostics.Process.Start(@"e:c:\\evolucao\\excel\" + dtFaltantes.TableName + ".xlsx");
            }
            if (!falta_material)
            {
                MessageBox.Show("Os materiais necessários nesse pedido estão disponíveis");
            }
        }

        private void gerarExcel(DataTable table, string nomeArquivo)
        {
            if (!Directory.Exists(@"e:c:\\evolucao\\excel\"))
            {
                Directory.CreateDirectory(@"e:c:\\evolucao\\excel\");
            }

            //Creae an Excel application instance
            Excel.Application excelApp = new Excel.Application();
            if (criarArquivoExcel(nomeArquivo))
            {
                //Create an Excel workbook instance and open it from the predefined location
                Excel.Workbook excelWorkBook = excelApp.Workbooks.Open(nomeArquivo);

                // foreach (DataTable table in tb)
                // {
                //Add a new worksheet to workbook with the Datatable name
                Excel.Worksheet excelWorkSheet = excelWorkBook.Sheets.Add();
                excelWorkSheet.Name = table.TableName;

                for (int i = 1; i < table.Columns.Count + 1; i++)
                {
                    excelWorkSheet.Cells[1, i] = table.Columns[i - 1].ColumnName;
                }

                for (int j = 0; j < table.Rows.Count; j++)
                {
                    for (int k = 0; k < table.Columns.Count; k++)
                    {
                        bool _double = false;
                        try
                        {
                            Convert.ToDouble(table.Rows[j].ItemArray[k].ToString());
                            _double = true;
                        }
                        catch { }
                        bool _data = false;
                        try
                        {
                            Convert.ToDateTime(table.Rows[j].ItemArray[k].ToString());
                            _data = true;
                        }
                        catch { }
                        if (_double)
                        {
                            excelWorkSheet.Cells[j + 2, k + 1] = Convert.ToDouble(table.Rows[j].ItemArray[k].ToString()).ToString("n2");
                        }
                        else
                        {
                            if (_data)
                            {
                                excelWorkSheet.Cells[j + 2, k + 1] = Convert.ToDateTime(table.Rows[j].ItemArray[k].ToString()).ToShortDateString();
                            }
                            else
                            {
                                excelWorkSheet.Cells[j + 2, k + 1] = table.Rows[j].ItemArray[k].ToString();
                            }
                        }


                    }
                }
                // }

                excelWorkBook.Save();
                excelWorkBook.Close();
                excelApp.Quit();
            }
        }

        private bool criarArquivoExcel(string nomeArquivo)
        {
            try
            {
                Excel.Application xlApp;
                Excel.Workbook xlWorkBook;
                Excel.Worksheet xlWorkSheet;
                object misValue = System.Reflection.Missing.Value;

                xlApp = new Excel.Application();
                xlWorkBook = xlApp.Workbooks.Add(misValue);

                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                // xlWorkSheet.Cells[1, 1] = "http://www.macoratti.net";

                xlWorkBook.SaveAs(nomeArquivo, Excel.XlFileFormat.xlOpenXMLWorkbook,
    System.Reflection.Missing.Value, System.Reflection.Missing.Value, false, false,
    Excel.XlSaveAsAccessMode.xlShared, false, false, System.Reflection.Missing.Value,
    System.Reflection.Missing.Value, System.Reflection.Missing.Value);
                xlWorkBook.Close(true, misValue, misValue);
                xlApp.Quit();

                liberarObjetos(xlWorkSheet);
                liberarObjetos(xlWorkBook);
                liberarObjetos(xlApp);
                return true;
                // MessageBox.Show("O arquivo Excel foi criado com sucesso. Você pode encontrá-lo em : " + nomeArquivo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
                return false;
            }
        }

        private void liberarObjetos(Object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Ocorreu um erro durante a liberação do objeto " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        private void button29_Click(object sender, EventArgs e)
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
                    if (usuario._cod_usuario == "1" || usuario._cod_usuario == "3" || usuario._cod_usuario == "4")
                    {
                        tb_obs.Text = tb_obs.Text + "{Salvo incondicionalmente por: " + usuario._cod_usuario +  " - " + usuario._nome_usuario + " em: " + DateTime.Now.ToString() + "} ";
                        salvar();
                        for (int i = 0; i < dgvItens_nota.Rows.Count; i++)
                        {
                            try
                            {
                                classeEstoque estoque = new classeEstoque();
                                estoque.fbConnection1.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=10.3.3.4;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=True;Packet Size=8192;Server Type=0";
                                estoque.calcular_estoque(dgvItens_nota.Rows[i].Cells["col_cod_forn"].Value.ToString());
                            }
                            catch { }
                        }
                    }
                }
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < dgvItens_nota.SelectedRows.Count; i++)
                {
                    datItens_ped_venda.UpdateCommand.CommandText =
                       "UPDATE itens_pedido_venda SET OP_INTERNA_ITEM_VENDA = NULL WHERE cod_item_venda  = " + dgvItens_nota.SelectedRows[i].Cells["col_cod_item_venda"].Value.ToString();
                    datItens_ped_venda.UpdateCommand.Connection = fbConnection1;
                    fbConnection1.Open();
                    datItens_ped_venda.UpdateCommand.ExecuteNonQuery();
                    fbConnection1.Close();

                    try
                    {
                        classeEstoque estoque = new classeEstoque();
                        estoque.fbConnection1.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=10.3.3.4;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=True;Packet Size=8192;Server Type=0";
                        estoque.calcular_estoque(dgvItens_nota.SelectedRows[i].Cells["col_cod_forn"].Value.ToString());
                    }
                    catch { }

                }
                selecionar_itens();
            }
            catch(Exception ex)
            {
                fbConnection1.Close();
                MessageBox.Show(ex.Message);
            }

            
        }

        private void button31_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < dgvItens_nota.SelectedRows.Count; i++)
                {
                    datItens_ped_venda.UpdateCommand.CommandText =
                       "UPDATE itens_pedido_venda SET ITEM_LIBERACAO_ITEM_VENDA = NULL WHERE cod_item_venda  = " + dgvItens_nota.SelectedRows[i].Cells["col_cod_item_venda"].Value.ToString();
                    datItens_ped_venda.UpdateCommand.Connection = fbConnection1;
                    fbConnection1.Open();
                    datItens_ped_venda.UpdateCommand.ExecuteNonQuery();
                    fbConnection1.Close();

                    try
                    {
                        classeEstoque estoque = new classeEstoque();
                        estoque.fbConnection1.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=10.3.3.4;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=True;Packet Size=8192;Server Type=0";
                        estoque.calcular_estoque(dgvItens_nota.SelectedRows[i].Cells["col_cod_forn"].Value.ToString());
                    }
                    catch { }

                }
                selecionar_itens();
            }
            catch (Exception ex)
            {
                fbConnection1.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < dgvItens_nota.SelectedRows.Count; i++)
                {
                    datItens_ped_venda.UpdateCommand.CommandText =
                       "UPDATE itens_pedido_venda SET ITEM_NOTA_ITEM_VENDA = NULL WHERE cod_item_venda  = " + dgvItens_nota.SelectedRows[i].Cells["col_cod_item_venda"].Value.ToString();
                    datItens_ped_venda.UpdateCommand.Connection = fbConnection1;
                    fbConnection1.Open();
                    datItens_ped_venda.UpdateCommand.ExecuteNonQuery();
                    fbConnection1.Close();

                    try
                    {
                        classeEstoque estoque = new classeEstoque();
                        estoque.fbConnection1.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=10.3.3.4;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=True;Packet Size=8192;Server Type=0";
                        estoque.calcular_estoque(dgvItens_nota.SelectedRows[i].Cells["col_cod_forn"].Value.ToString());
                    }
                    catch { }

                }
                selecionar_itens();
            }
            catch (Exception ex)
            {
                fbConnection1.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void labelTitulo_Click(object sender, EventArgs e)
        {

        }

        private void dgvItens_nota_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int cod_produto = 0;
            if (dgvItens_nota.Columns[e.ColumnIndex].Name == "col_desenho")
            {
                form_produto prod = new form_produto(cnpj_empresa);
                prod.modificar = true;
                try
                {

                    prod.cod_prod = dgvItens_nota.Rows[e.RowIndex].Cells["col_cod"].Value.ToString();

                    prod.Show();
                }
                catch
                { }
            }
        }

        private void dgvItens_nota_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void cbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}