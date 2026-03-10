using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evolucao
{
    public partial class form_geracao_tp : Form
    {
        string cnpj_empresa;
        DataTable dtNcm_cst = new DataTable();
        string razao_social_empresa = "", nome_fantasia_empresa = "", ie_empresa = "", im_empresa = "", cnae_empresa = "", endereco_empresa = "", n_endereco_empresa = "",
         complemento_empresa = "", bairro_empresa = "", cidade_empresa = "", estado_empresa = "", cep_empresa = "", telefone_empresa = "", cod_cidade_empresa = "", pais_empresa = "",
         cod_pais_empresa = "", licenca_dll_nfe_empresa = "", nome_certificado_nfe_empresa = "", assunto_nfe_email_empresa = "", smtp_nfe_empresa = "", email_nfe_empresa = "",
         senha_email_nfe_empresa = "", logotipo_empresa = "", proxy_empresa = "", usuario_proxy_empresa = "", senha_proxy_empresa = "", crt_empresa = "", portaEmailEmpresa = "",
         sslEmpresa = "", serie_empresa = "", boleto_pedido_empresa = "", cliente_inadimplente_empresa = "", _cod_transmissao = "";

        private void button4_Click(object sender, EventArgs e)
        {
            gerar_tabelas();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Essa operação irá apagar todas as tabelas de preço, tem certeza?",
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
                        if (usuario._cod_usuario == "1")
                        {
                            try
                            {
                                FbCommand delete_tabelas = new FbCommand();
                                delete_tabelas.Connection = fbConnection2;
                                fbConnection2.Open();
                                delete_tabelas.CommandText =
                                    "DELETE FROM ITENS_TP";
                                delete_tabelas.ExecuteNonQuery();
                                fbConnection2.Close();

                            }
                            catch (Exception ex)
                            {
                                fbConnection2.Close();
                                MessageBox.Show(ex.Message);
                            }
                            try
                            {
                                FbCommand delete_tabelas = new FbCommand();
                                delete_tabelas.Connection = fbConnection2;
                                fbConnection2.Open();
                                delete_tabelas.CommandText =
                                    "DELETE FROM TABELA_PRECO";
                                delete_tabelas.ExecuteNonQuery();
                                fbConnection2.Close();

                            }
                            catch (Exception ex)
                            {
                                fbConnection2.Close();
                                MessageBox.Show(ex.Message);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Usuário não autorizado");
                        }


                    }
                    MessageBox.Show("Acerto Realizado!");
                    //selecionar_itens();
                }
            }
        }

        private void form_geracao_tp_Load(object sender, EventArgs e)
        {
            detectar_dados_empresa(out razao_social_empresa, out nome_fantasia_empresa, out cnpj_empresa, out ie_empresa, out im_empresa, out cnae_empresa, out endereco_empresa, out n_endereco_empresa,
     out complemento_empresa, out bairro_empresa, out cidade_empresa, out estado_empresa, out cep_empresa, out telefone_empresa, out cod_cidade_empresa, out pais_empresa,
     out cod_pais_empresa, out licenca_dll_nfe_empresa, out nome_certificado_nfe_empresa, out assunto_nfe_email_empresa, out smtp_nfe_empresa, out email_nfe_empresa,
     out senha_email_nfe_empresa, out logotipo_empresa, out proxy_empresa, out usuario_proxy_empresa, out senha_proxy_empresa, out crt_empresa, out portaEmailEmpresa, out sslEmpresa, out serie_empresa,
     out boleto_pedido_empresa, out cliente_inadimplente_empresa);
            buscar_ncm_cst();
        }

        public form_geracao_tp(string cnpj_empresa)
        {
            InitializeComponent();
            this.cnpj_empresa = cnpj_empresa;
        }

        private void button1_Click(object sender, EventArgs e)
        {

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
            _tipo_pis = ""; _cst_pis = ""; _tipo_cofins = ""; _cst_cofins = ""; _pCredICMS = ""; _preco_minimo = ""; _custo = ""; cfop_produto = ""; cest_produto = "";
            try
            {

                bool ncm_encontrado = false;
                string tipo_cliente = tipo;
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
                fbConnection2.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private void gerar_tabelas()
        {
            List<string> estados = new List<string>
            {
                
                "AC", // Acre
                "AL", // Alagoas
                "AP", // Amapá
                "AM", // Amazonas
                "BA", // Bahia
                "CE", // Ceará
                "DF", // Distrito Federal
                "ES", // Espírito Santo
                "GO", // Goiás
                "MA", // Maranhão
                "MT", // Mato Grosso
                "MS", // Mato Grosso do Sul
                "MG", // Minas Gerais
                "PA", // Pará
                "PB", // Paraíba
                "PR", // Paraná
                "PE", // Pernambuco
                "PI", // Piauí
                "RJ", // Rio de Janeiro
                "RN", // Rio Grande do Norte
                "RS", // Rio Grande do Sul
                "RO", // Rondônia
                "RR", // Roraima
                "SC", // Santa Catarina
                "SP", // São Paulo
                "SE", // Sergipe
                "TO"  // Tocantins
                
                 
            };

            // Usando um loop foreach para percorrer a lista
            foreach (string estado in estados)
            {
                Console.WriteLine(estado);



                List<string> tiposCliente = new List<string>
                {
                "Revenda",
                "ConsumidorContribuinte",
                "ConsumidorNaoContribuinte",
                "Atacadista"
                };

                // Usando um loop foreach para percorrer a lista
                foreach (string tipo in tiposCliente)
                {
                    string nomeTabela = estado + " - " + tipo;
                    FbCommand insertTabela = new FbCommand();
                    insertTabela.Connection = fbConnection2;
                    fbConnection2.Open();
                    insertTabela.CommandText =
                           "INSERT INTO TABELA_PRECO(NOME_TABELA_PRECO, TIPO_TABELA_PRECO, ESTADO_TABELA_PRECO)" +
                           "VALUES ('" + nomeTabela + "','" + tipo + "','" + estado + "') RETURNING COD_TABELA_PRECO";
                    object cod_tabela = insertTabela.ExecuteScalar();
                    fbConnection2.Close();
                    //Console.WriteLine(tipo);



                    dsTabelaPreco dsTp = new dsTabelaPreco();

                    FbCommand comando_select = new FbCommand();
                    comando_select.Connection = fbConnection2;
                    comando_select.CommandText = @"SELECT COD_PRODUTO, NCM_PRODUTO, NOME_FAMILIA_PRODUTO, 
                            DESCRICAO_GRUPO_PRODUTO, DESCRICAO_SUB_GRUPO_PRODUTO, VALOR_VENDA_REVEND_PRODUTO, 
                        COD_FORNECEDOR_PRODUTO, DESCRICAO_PRODUTO FROM PRODUTOS WHERE UPPER(NOME_FORNECEDOR_PRODUTO) = 'ENTRELUX'";
                    DataTable prod = new DataTable();
                    fbConnection2.Open();
                    FbDataAdapter datProdutos = new FbDataAdapter();
                    datProdutos.SelectCommand = comando_select;
                    datProdutos.Fill(prod);
                    fbConnection2.Close();

                    foreach (DataRow dr in prod.Rows)
                    {
                        try
                        {
                            string _origem, _cst, _modalidade, _icms, _icms_st, _reducao, _reducao_st, _iva, _ipi, _pis,
                             _cofins, _iss, _crt, _aliquota_credito, _modalidade_st, _bc_com_ipi, _ipi_tributado,
                             _ipi_n_tributado, _cst_ipi_tributado, _cst_ipi_n_tributado, _tipo_pis, _cst_pis,
                             _tipo_cofins, _cst_cofins, _pCredICMS, _preco_minimo, _custo_produto, _cfop_produto, _cest_produto;



                            string cod_produto = dr["COD_PRODUTO"].ToString();



                            double preco_produto = 0;
                            string ncm = "", familia = "", linha = "", cor = "";
                            try
                            {


                                FbCommand insertItensTp = new FbCommand();
                                try
                                {
                                    ncm = dr["NCM_PRODUTO"].ToString();
                                    buscar_informacoes_produto(cod_produto,
                                out _origem, out _cst, out _modalidade, out _icms,
                                out _icms_st, out _reducao, out _reducao_st, out _iva, out _ipi, out _pis, out _cofins,
                                out _iss, out _crt, out _aliquota_credito, out _modalidade_st, out _bc_com_ipi,
                                out _ipi_tributado, out _ipi_n_tributado, out _cst_ipi_tributado,
                                out _cst_ipi_n_tributado, out _tipo_pis, out _cst_pis, out _tipo_cofins, out _cst_cofins,
                                out _pCredICMS, out _preco_minimo, out _custo_produto, out _cfop_produto, out _cest_produto, tipo, estado, ncm);


                                    familia = dr["NOME_FAMILIA_PRODUTO"].ToString();
                                    linha = dr["DESCRICAO_GRUPO_PRODUTO"].ToString();
                                    cor = dr["DESCRICAO_SUB_GRUPO_PRODUTO"].ToString();
                                    
                                    double acrescimo = 1;
                                    if (tipo.Contains("Consumidor"))
                                        acrescimo = 1.28;
                                    if (tipo.Contains("Atacadista"))
                                        acrescimo = 0.80;
                                    preco_produto = Convert.ToDouble(dr["VALOR_VENDA_REVEND_PRODUTO"].ToString());
                                    double icms = 0;
                                    double impostos = 0;
                                    try
                                    {
                                        icms = (Convert.ToDouble(_icms) / 100);
                                        impostos = (1 + icms + (Convert.ToDouble(_pis) / 100) +
                                        (Convert.ToDouble(_cofins) / 100));
                                    }
                                    catch { }

                                    preco_produto = (preco_produto * impostos );
                                    preco_produto = preco_produto * acrescimo;




                                    double _valor_total = 0, _bc_icms = 0, _bc_ipi = 0, _red_bc_icms = 0, _valor_ipi = 0, _valor_icms = 0, _valor_st = 0;

                                    try
                                    {
                                        _valor_total = preco_produto;
                                    }
                                    catch { }
                                    //calcular aqui a redução por estado
                                    _bc_icms = _valor_total;
                                    _bc_ipi = _valor_total;
                                    _bc_icms = _valor_total;

                                    try
                                    {
                                        _valor_ipi = _bc_ipi * Convert.ToDouble(_ipi) / 100;
                                    }
                                    catch { }
                                    try
                                    {

                                        double pICMS = 0;
                                        try
                                        {
                                            pICMS = Convert.ToDouble(_icms);
                                        }
                                        catch { }
                                        double pICMSST = 0;
                                        try
                                        {
                                            pICMSST = Convert.ToDouble(_icms_st);
                                        }
                                        catch
                                        {

                                        }
                                        double pMVAST = 0;
                                        try
                                        {
                                            pMVAST = Convert.ToDouble(_iva);
                                        }
                                        catch { }
                                        double vICMS = 0;
                                        try
                                        {
                                            vICMS = _bc_icms * pICMS / 100;
                                        }
                                        catch { }
                                        try
                                        {
                                            if (pMVAST > 0)
                                            {
                                                double vBCST = _bc_icms + (_bc_icms * (pMVAST / 100));
                                                double valor_temp_icms_st = vBCST * (pICMSST / 100);
                                                _valor_st = valor_temp_icms_st - vICMS;
                                            }
                                        }
                                        catch { }


                                    }


                                    catch { }
                                    try
                                    {
                                        _valor_icms = _bc_icms * (Convert.ToDouble(_icms) / 100);

                                    }
                                    catch { }

                                    
                                    
                                    
                                    
                                    insertItensTp.Connection = fbConnection2;
                                    fbConnection2.Open();
                                    insertItensTp.CommandText =
                                            "INSERT INTO ITENS_TP (COD_TABELA_ITEM_TP, COD_PRODUTO_ITEM_TP, DESCRICAO_PRODUTO_ITEM_TP, " +
                                            "PRECO_PRODUTO_ITEM_TP, PRECO_MINIMO_ITEM_TP, VALOR_IPI_ITEM_TP, VALOR_ST_ITEM_TP)" +
                                   "VALUES ('" + cod_tabela.ToString() + "','" + dr["COD_PRODUTO"].ToString() + "','" + dr["DESCRICAO_PRODUTO"].ToString() + 
                                   "'," + _valor_total.ToString("n2").Replace(".","").Replace(",",".") + "," + 
                                   _valor_total.ToString("n2").Replace(".", "").Replace(",", ".") + "," + 
                                   _valor_ipi.ToString("n2").Replace(".", "").Replace(",", ".") + "," + 
                                   _valor_st.ToString("n2").Replace(".", "").Replace(",", ".") + ")";
                                    insertItensTp.ExecuteScalar();
                                    fbConnection2.Close();



                                }
                                catch(Exception ex)
                                {
                                    fbConnection2.Close();
                                }




                            }
                            catch { fbConnection2.Close(); }
                        }
                        catch { fbConnection2.Close(); }
                    }



                    
                }
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
                comando.Connection = fbConnection2;
                comando.CommandText = "SELECT * FROM EMPRESA where LICENCA_DLL_NFE_EMPRESA is not null and cnpj_empresa = '" + cnpj_empresa + "'";
                DataSet empresa = new DataSet();
                fbConnection2.Open();
                FbDataAdapter datEmpresa = new FbDataAdapter();

                datEmpresa.SelectCommand = comando;
                datEmpresa.Fill(empresa);
                fbConnection2.Close();
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
                    //if (tb_cnpj_empresa.Text == "")
                    //{
                    //    tb_cnpj_empresa.Text = cnpj_empresa;
                    //    tb_descricao_empresa.Text = razao_social_empresa;
                    //}
                }

            }
            catch (Exception a)
            {
                fbConnection2.Close();
                MessageBox.Show(a.ToString());
            }
        }

    }
}
