using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Xml;
using FirebirdSql.Data.FirebirdClient;
using System.Data.OleDb;
using BoletoNet;
using TheArtOfDev.HtmlRenderer.PdfSharp;
using TheArtOfDev.HtmlRenderer.Demo.Common;
//using TheArtOfDev.HtmlRenderer.Demo.WinForms;
using TheArtOfDev.HtmlRenderer.WinForms;
using TheArtOfDev.HtmlRenderer.PdfSharp;
using System.Diagnostics;
using CrystalDecisions.CrystalReports.Engine;
//using ColorCode;
using System.Drawing.Printing;
using System.Web;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Evolucao
{
    public partial class form_faturamento : Form
    {
        classeNfe40 nfe40 = new classeNfe40();
        public bool nova_nota;
        public bool apenas_xml;
        public int n_pedido;
        public bool teste;
        public string transportadora = "";
        public string qtde_caixa = "";

        public string nota_a_abrir = "";
        public bool imprimir_nota_e_boleto;
        public bool imprimir_nota;

        public bool importar_xml = false;
        public string _cod_banco, _agencia, _dig_agencia, _cc, _dig_cc, _carteira, _multa, _mora, _dias_protesto, _codigo_no_banco, _descricao_banco, _cod_interno_banco, _cod_transmissao;

        //variaveis detecta_fatura
        string[] _datas = new string[50];
        string[] _valores = new string[50];
        string[] _cod = new string[50];
        string nomeFantasia = "";
        bool _enviar = false;

        //variaveis da NFe

        string decimal_correto;
        //NFe_Util_PL005a.Util util = new NFe_Util_PL005a.Util();
        //NFe_Util_PL005a.Util util = new NFe_Util_PL005a.Util();
        NFe_Util_2G.Util util2 = new NFe_Util_2G.Util();
        public bool erro;
        public bool abre_nf;
        public string nf_atual = "";
        string novo_valor;
        string dia;
        string mes;
        int pedido;
        bool primeiro_pedido = true;
        bool unico;

        public string data_saida_nf;
        //empresa
        string cod_empresa = "", razao_social_empresa = "", nome_fantasia_empresa = "", /*cnpj_empresa = "",*/ ie_empresa = "", im_empresa = "", cnae_empresa = "", endereco_empresa = "", n_endereco_empresa = "",
           complemento_empresa = "", bairro_empresa = "", cidade_empresa = "", estado_empresa = "", cep_empresa = "", telefone_empresa = "", cod_cidade_empresa = "", pais_empresa = "",
           cod_pais_empresa = "", licenca_dll_nfe_empresa = "", nome_certificado_nfe_empresa = "", assunto_nfe_email_empresa = "", smtp_nfe_empresa = "", email_nfe_empresa = "",
           senha_email_nfe_empresa = "", logotipo_empresa = "", proxy_empresa = "", usuario_proxy_empresa = "", senha_proxy_empresa = "", crt_empresa = "", portaEmailEmpresa = "",
           sslEmpresa = "", serie_empresa = "", boleto_pedido_empresa = "", saida_estoque_pedido_empresa = "", cod_forn_empresa = "";

        //MainControl _mainControl = new MainControl();
        public string cnpj_empresa;
        public form_faturamento(string cnpj_empresa)
        {
            this.cnpj_empresa = cnpj_empresa;
            InitializeComponent();
        }

        private void inserir_campos_empresa()
        {
            try
            {

                FbCommand comando_alter = new FbCommand();
                comando_alter.Connection = fbConnection1;
                int erros = 0;
                int n_campos = 3;
                string[] campos = new string[n_campos];
                campos[0] = "ADD    PORTA_EMAIL_EMP             INTEGER";
                campos[1] = "ADD    SSL_EMP                     INTEGER";
                campos[2] = "ADD    SERIE_NF_EMPRESA               INTEGER";

                string[] campos_u = new string[n_campos];
                campos_u[0] = "UPDATE EMPRESA SET PORTA_EMAIL_EMP = '587' WHERE PORTA_EMAIL_EMP IS NULL";
                campos_u[1] = "UPDATE EMPRESA SET SSL_EMP = '0' WHERE SSL_EMP IS NULL";
                campos_u[2] = "UPDATE EMPRESA SET SERIE_NF_EMPRESA = '1' WHERE SERIE_NF_EMPRESA IS NULL";

                for (int i = 0; i < n_campos; i++)
                {
                    try
                    {
                        comando_alter.CommandText =
                            "ALTER TABLE EMPRESA " +
                            campos[i];
                        comando_alter.Connection = fbConnection1;
                        fbConnection1.Open();
                        comando_alter.ExecuteNonQuery();
                        fbConnection1.Close();

                        FbCommand update = new FbCommand();
                        update.CommandText = campos_u[i];
                        update.Connection = fbConnection1;
                        fbConnection1.Open();
                        FbDataAdapter datUpdate = new FbDataAdapter();
                        datUpdate.UpdateCommand = update;
                        datUpdate.UpdateCommand.ExecuteNonQuery();
                        fbConnection1.Close();


                    }
                    catch
                    {
                        fbConnection1.Close();
                        erros++;
                    }

                }
            }
            catch { }
        }

        private void inserir_campos_nf()
        {
            try
            {

                FbCommand comando_alter = new FbCommand();
                comando_alter.Connection = fbConnection1;
                int erros = 0;
                int n_campos = 4;
                string[] campos = new string[n_campos];
                campos[0] = "ADD    XML_GERADO_NF               BLOB SUB_TYPE 1 SEGMENT SIZE 16384";
                campos[1] = "ADD    LOTE_ENVIO_NF               INTEGER";
                campos[2] = "ADD    XML_AUTORIZADO_NF           BLOB SUB_TYPE 1 SEGMENT SIZE 16384";
                campos[3] = "ADD    XML_CANCELADO_NF            BLOB SUB_TYPE 1 SEGMENT SIZE 16384";
                /*XML_GERADO_NF               BLOB SUB_TYPE 1 SEGMENT SIZE 16384,
      LOTE_ENVIO_NF               INTEGER,
      XML_AUTORIZADO_NF           BLOB SUB_TYPE 1 SEGMENT SIZE 16384,
      XML_CANCELADO_NF            BLOB SUB_TYPE 1 SEGMENT SIZE 16384
                 * */
                for (int i = 0; i < n_campos; i++)
                {
                    try
                    {
                        comando_alter.CommandText =
                            "ALTER TABLE NOTA_FISCAL " +
                            campos[i];
                        comando_alter.Connection = fbConnection1;
                        fbConnection1.Open();
                        comando_alter.ExecuteNonQuery();
                        fbConnection1.Close();

                    }
                    catch
                    {
                        fbConnection1.Close();
                        erros++;
                    }

                }
            }
            catch { }
        }
        DataTable dtNcm_cst = new DataTable();


        private void form_faturamento_Load(object sender, EventArgs e)
        {
           // cbNfe_teste.Checked = true;
           
           // inserir_campos_empresa();
            inserir_campos_nf();
            detectar_dados_empresa(out razao_social_empresa, out nome_fantasia_empresa, out cnpj_empresa, out ie_empresa, out im_empresa, out cnae_empresa, out endereco_empresa, out n_endereco_empresa,
       out complemento_empresa, out bairro_empresa, out cidade_empresa, out estado_empresa, out cep_empresa, out telefone_empresa, out cod_cidade_empresa, out pais_empresa,
       out cod_pais_empresa, out licenca_dll_nfe_empresa, out nome_certificado_nfe_empresa, out assunto_nfe_email_empresa, out smtp_nfe_empresa, out email_nfe_empresa,
       out senha_email_nfe_empresa, out logotipo_empresa, out proxy_empresa, out usuario_proxy_empresa, out senha_proxy_empresa, out crt_empresa, out portaEmailEmpresa, out sslEmpresa,
out serie_empresa, out boleto_pedido_empresa, out saida_estoque_pedido_empresa, out cod_forn_empresa, out cod_empresa);

            if (boleto_pedido_empresa == "1")
                bt_boleto.Visible = false;
            buscar_ncm_cst();

            buscar_dados_bancarios();
            try
            {
                CodigoBanco = Convert.ToInt16(_cod_banco);
            }
            catch { }

            /*
            FbCommand comando = new FbCommand();
            comando.Connection = fbConnection1;
            comando.CommandText = "SELECT * FROM EMPRESA where LICENCA_DLL_NFE_EMPRESA is not null";
            DataSet empresa = new DataSet();
            fbConnection1.Open();
            FbDataAdapter datEmpresa = new FbDataAdapter();
            datEmpresa.SelectCommand = comando;
            datEmpresa.Fill(EMPRESA);
            fbConnection1.Close();
            */
            try
            {
                if (nova_nota)
                {
                    criar_novo();
                    if (data_saida_nf != "")
                        tb_saida.Text = data_saida_nf;
                    buscar_pedido(n_pedido);
                    bool ok = false;
                    
                    //gerar_xml(out ok);
                   /*
                    if (ok)
                    {
                        if (!apenas_xml)
                        {
                            enviar_nfe(out ok);
                            if (ok)
                            {
                                consulta_status(out ok);
                               // if (ok && boleto_pedido_empresa != "1")
                                //    gerar_boletos();
                            }
                        }
                        else
                        {
                            this.Close();
                        }

                    }
                    */
                    

                }
                else
                {
                    if (nota_a_abrir == "")
                    {
                        string cod_sistema = "";
                        string ultima_nota = buscar_ultima_nf(cnpj_empresa, out cod_sistema).ToString();
                        if (cod_sistema != "")
                        {
                            this.datNota_fiscal.SelectCommand.CommandText =
                            "SELECT * FROM NOTA_FISCAL WHERE COD_SISTEMA_NF = '" + cod_sistema + "'";
                            this.fbConnection1.Open();
                            this.datNota_fiscal.SelectCommand.Connection = fbConnection1;
                            this.datNota_fiscal.SelectCommand.ExecuteNonQuery();
                            datNota_fiscal.Fill(NOTA_FISCAL);
                            this.fbConnection1.Close();
                        }
                    }
                    else
                    {
                        this.datNota_fiscal.SelectCommand.CommandText =
                        "SELECT * FROM NOTA_FISCAL WHERE N_NF = '" + nota_a_abrir + "' AND CNPJ_EMISSOR_NF = '" + cnpj_empresa + "'";
                        this.fbConnection1.Open();
                        this.datNota_fiscal.SelectCommand.Connection = fbConnection1;
                        this.datNota_fiscal.SelectCommand.ExecuteNonQuery();
                        datNota_fiscal.Fill(NOTA_FISCAL);
                        this.fbConnection1.Close();
                    }
                    this.datItens_nota.SelectCommand.CommandText =
                    //"SELECT * FROM ITENS_NOTA WHERE NF_ITEM = '" + tb_n_nf.Text + "' order by cod_itens_nota";
                    "SELECT * FROM ITENS_NOTA WHERE COD_SISTEMA_NF_ITEM = '" + tb_cod_interno.Text + "' order by cod_itens_nota";
                    this.fbConnection1.Open();
                    this.datItens_nota.SelectCommand.Connection = fbConnection1;
                    this.datItens_nota.SelectCommand.ExecuteNonQuery();
                    datItens_nota.Fill(ITENS_NOTA);
                    this.fbConnection1.Close();

                    this.datFatura_nf.SelectCommand.CommandText =
                    //"SELECT * FROM FATURA_NF WHERE NF_FATURA = '" + tb_n_nf.Text + "'";
                    "SELECT * FROM FATURA_NF WHERE COD_SISTEMA_NF_FATURA = '" + tb_cod_interno.Text + "'";
                    this.fbConnection1.Open();
                    this.datFatura_nf.SelectCommand.Connection = fbConnection1;
                    this.datFatura_nf.SelectCommand.ExecuteNonQuery();
                    datFatura_nf.Fill(FATURA_NF);
                    this.fbConnection1.Close();

                    dsPedidos_nf.Clear();
                    this.datPedidos_nf.SelectCommand.CommandText =
                        "SELECT * FROM PEDIDOS_NF WHERE COD_SISTEMA_PEDIDO_NF = '" + tb_cod_interno.Text + "'";
                        // "SELECT * FROM PEDIDOS_NF WHERE NF_PEDIDO_NF = '" + tb_n_nf.Text + "'"; COD_SISTEMA_PEDIDO_NF
                    /*"SELECT pnf.*, pv.vendedor_ped_venda " + 
                    "FROM PEDIDOS_NF pnf " + 
                    "INNER JOIN pedidos_venda pv " + 
                    "ON pv.cod_ped_venda = pnf.n_pedido_nf " + 
                    "WHERE NF_PEDIDO_NF = '" + tb_n_nf.Text + "'";*/
                    this.fbConnection1.Open();
                    this.datPedidos_nf.SelectCommand.Connection = fbConnection1;
                    this.datPedidos_nf.SelectCommand.ExecuteNonQuery();
                    datPedidos_nf.Fill(PEDIDOS_NF);
                    this.fbConnection1.Close();
                    dgvItens_nota.AutoGenerateColumns = false;
                    dgvItens_nota.DataSource = dsItens_nota.Tables["ITENS_NOTA"];
                }

                if (imprimir_nota_e_boleto)
                {
                    try
                    {
                        try
                        {
                            gerar_boletos();
                        }
                        finally { }

                        int imp = 3;
                       
                        for (int i = 0; i < imp; i++)
                        {
                            try
                            {
                                imprimir();
                            }
                            finally { }
                        }

                    }
                    finally
                    {
                        this.Close();
                    }


                }
                if (imprimir_nota)
                {
                    imprimir();
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                fbConnection1.Close();
            }

        }

        private void buscar_ncm_cst()
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

        private void buscar_dados_bancarios()
        {
            _cod_banco = ""; _agencia = ""; _dig_agencia = "";
            _cc = ""; _dig_cc = "";
            _carteira = ""; _multa = "";
            _mora = ""; _dias_protesto = "";
            _codigo_no_banco = ""; _descricao_banco = ""; _cod_interno_banco = "";
           _cod_transmissao = "";
            try
            {
                FbCommand select = new FbCommand();
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
                    _descricao_banco = dr["DESCRICAO_CC"].ToString();
                    _cod_interno_banco = dr["COD_CC"].ToString();
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

        private void tb_descricao_DoubleClick(object sender, EventArgs e)
        {

        }

        private string diminue_casas_decimais(string valor_double)
        {
            int m = 0;
            string novo_valor = "";
            try
            {
                while (valor_double[m].ToString() != ",")
                {
                    m++;
                }
                try
                {
                    for (int n = 0; n <= m + 2; n++)
                    {
                        novo_valor = novo_valor + valor_double[n];
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    novo_valor = novo_valor + "0";
                }
            }
            catch (IndexOutOfRangeException)
            {
                novo_valor = valor_double + ",00";
            }


            //MessageBox.Show(novo_valor);
            return novo_valor;

        }

        private void novo_registro_Click(object sender, EventArgs e)
        {
            criar_novo();

        }

        private void criar_novo()
        {
            HasTextBox(this);
            dsDesenhos.Clear();
            dsItens_nota.Clear();
            dsFatura_nf.Clear();
            dsPedidos_nf.Clear();
            gbNfe.BackColor = SystemColors.Control;
            string cod_sistema = "";

            int n_nf_atual = buscar_ultima_nf(cnpj_empresa, out cod_sistema);
            n_nf_atual++;
            this.datNota_fiscal.InsertCommand.CommandText =
                "INSERT INTO NOTA_FISCAL (N_NF, OBS_NF, VALOR_TOT_PROD_NF, VALOR_NOTA_NF, cnpj_emissor_nf, razao_emissor_nf)" +
                "VALUES ('" + n_nf_atual.ToString() + "', 'NOVO', 0, 0,'" + cnpj_empresa + "','" + razao_social_empresa + "') returning COD_SISTEMA_NF ";
            this.fbConnection1.Open();
            this.datNota_fiscal.InsertCommand.Connection = fbConnection1;
            object _cod_sistema = datNota_fiscal.InsertCommand.ExecuteScalar();
            this.fbConnection1.Close();

            try
            {
                dsNota_fiscal.Clear();
                this.datNota_fiscal.SelectCommand.CommandText =
                    "SELECT * FROM NOTA_FISCAL WHERE COD_SISTEMA_NF = '" + _cod_sistema.ToString() + "'";
                this.fbConnection1.Open();
                this.datNota_fiscal.SelectCommand.Connection = fbConnection1;
                this.datNota_fiscal.SelectCommand.ExecuteNonQuery();
                datNota_fiscal.Fill(NOTA_FISCAL);
                this.fbConnection1.Close();
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
            //this.BindingContext[dsNota_fiscal, "NOTA_FISCAL"].Position = 100000000;
            radioSaida.Checked = true;
            tb_data_emissao.Text = Convert.ToDateTime(DateTime.Now).ToShortDateString();
            tb_frete.Text = "0";
            tb_transportadora.Text = transportadora;
            tb_qtde_volume.Text = qtde_caixa;
            if (!String.IsNullOrEmpty(tb_qtde_volume.Text))
                tb_especie.Text = "";
            if (teste)
                cbNfe_teste.Checked = true;
            Atualizar(false);
        }

        private int buscar_ultima_nf(string cnpj_empresa, out string cod_sistema)
        {
            int encontrada = 0; cod_sistema = "";
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                select.CommandText =
                    "SELECT first(1) N_NF, COD_SISTEMA_NF FROM NOTA_FISCAL WHERE CNPJ_EMISSOR_NF = '" + cnpj_empresa + "' ORDER BY COD_SISTEMA_NF DESC";
                fbConnection1.Open();
                DataSet notas = new DataSet();
                datNota_fiscal.SelectCommand = select;
                datNota_fiscal.Fill(notas);

                if (notas.Tables[0].Rows.Count > 0)
                {
                    DataRow dr = notas.Tables[0].Rows[0];
                    encontrada = Convert.ToInt32(dr[0].ToString());
                    cod_sistema = dr[1].ToString();
                }
                else
                {
                    MessageBox.Show("Nenhuma nota encontrada");
                }
                fbConnection1.Close();
                return encontrada;

            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
                fbConnection1.Close();
                return encontrada;
            }

        }

        private void salva_registro_Click(object sender, EventArgs e)
        {
            //calcular();
            // MessageBox.Show(Extenso_Valor(Convert.ToDecimal(tb_total_nota.Text)));
            //tb_total_nota.Text = diminue_casas_decimais(tb_total_nota.Text);
            //label_valor_extenso.Visible = true;
            //label_valor_extenso.Text = Extenso_Valor(Convert.ToDecimal(tb_total_nota.Text)) + "#############";
            //tb_total_prod.Text = diminue_casas_decimais(tb_total_prod.Text);

            Atualizar(false);
            MessageBox.Show("Salvo");
        }

        private void Atualizar(bool excecao)
        {
            if (tb_protocolo_autorizacao.Text != "" && excecao == false)
            {
                MessageBox.Show("Impossível salvar, pois a NFe já foi autorizada");
            }
            else
            {
                try
                {
                    this.BindingContext[dsNota_fiscal, "NOTA_FISCAL"].EndCurrentEdit();
                    if (dsNota_fiscal.HasChanges())
                    {
                        //MessageBox.Show("CHEGOU AQUI");
                        fbConnection1.Open();
                        datNota_fiscal.UpdateCommand = cbNota_fiscal.GetUpdateCommand();
                        datNota_fiscal.InsertCommand = cbNota_fiscal.GetInsertCommand();
                        datNota_fiscal.DeleteCommand = cbNota_fiscal.GetDeleteCommand();
                        datNota_fiscal.Update(dsNota_fiscal, "NOTA_FISCAL");
                        dsNota_fiscal.AcceptChanges();
                        //datNota_fiscal.Fill(NOTA_FISCAL);
                        fbConnection1.Close();
                    }
                    this.BindingContext[dsItens_nota, "ITENS_NOTA"].EndCurrentEdit();
                    if (dsItens_nota.HasChanges())
                    {
                        //MessageBox.Show("CHEGOU AQUI");
                        fbConnection1.Open();
                        datItens_nota.UpdateCommand = cbItens_nota.GetUpdateCommand();
                        datItens_nota.InsertCommand = cbItens_nota.GetInsertCommand();
                        datItens_nota.DeleteCommand = cbItens_nota.GetDeleteCommand();
                        datItens_nota.Update(dsItens_nota, "ITENS_NOTA");
                        dsItens_nota.AcceptChanges();
                        //datItens_nota.Fill(NOTA_FISCAL);
                        fbConnection1.Close();
                    }

                    this.BindingContext[dsFatura_nf, "FATURA_NF"].EndCurrentEdit();
                    if (dsFatura_nf.HasChanges())
                    {
                        fbConnection1.Open();
                        datFatura_nf.UpdateCommand = cbFatura_nf.GetUpdateCommand();
                        datFatura_nf.InsertCommand = cbFatura_nf.GetInsertCommand();
                        datFatura_nf.DeleteCommand = cbFatura_nf.GetDeleteCommand();
                        datFatura_nf.Update(dsFatura_nf, "FATURA_NF");
                        dsFatura_nf.AcceptChanges();
                        fbConnection1.Close();
                    }
                    this.BindingContext[dsPedidos_nf, "PEDIDOS_NF"].EndCurrentEdit();
                    if (dsPedidos_nf.HasChanges())
                    {
                        //MessageBox.Show("CHEGOU AQUI");
                        fbConnection1.Open();
                        datPedidos_nf.UpdateCommand = cbPedidos_nf.GetUpdateCommand();
                        datPedidos_nf.InsertCommand = cbPedidos_nf.GetInsertCommand();
                        datPedidos_nf.DeleteCommand = cbPedidos_nf.GetDeleteCommand();
                        datPedidos_nf.Update(dsPedidos_nf, "PEDIDOS_NF");
                        dsPedidos_nf.AcceptChanges();
                        fbConnection1.Close();
                    }
                   // MessageBox.Show("Salvo!");

                }
                catch (Exception a)
                {
                    fbConnection1.Close();
                    MessageBox.Show(a.ToString());
                }
            }


        }

        public string Extenso_Valor(decimal pdbl_Valor)
        {
            //MessageBox.Show(pdbl_Valor.ToString());
            string strValorExtenso = ""; //Variável que irá armazenar o valor por extenso do número informado

            string strNumero = ""; //Irá armazenar o número para exibir por extenso

            string strCentena = "";

            string strDezena = "";

            string strUnidade = "";

            decimal dblCentavos = 0;

            decimal dblValorInteiro = 0;

            int intContador = 0;

            bool bln_Bilhao = false;

            bool bln_Milhao = false;

            bool bln_Mil = false;

            bool bln_Real = false;

            bool bln_Unidade = false;

            //Verificar se foi informado um dado indevido

            if (pdbl_Valor == 0 || pdbl_Valor <= 0)
            {

                strValorExtenso = "Verificar se há valor negativo ou nada foi informado";

            }

            if (pdbl_Valor > (decimal)9999999999.99)
            {

                strValorExtenso = "Valor não suportado pela Função";

            }

            else //Entrada padrão do método
            {

                //Gerar Extenso Centavos

                dblCentavos = pdbl_Valor - (int)pdbl_Valor;
                //MessageBox.Show(dblCentavos.ToString());
                //Gerar Extenso parte Inteira

                dblValorInteiro = (int)pdbl_Valor;

                if (dblValorInteiro > 0)
                {

                    if (dblValorInteiro > 999)
                    {

                        bln_Mil = true;

                    }

                    if (dblValorInteiro > 999999)
                    {

                        bln_Milhao = true;

                        bln_Mil = false;

                    }

                    if (dblValorInteiro > 999999999)
                    {

                        bln_Mil = false;

                        bln_Milhao = false;

                        bln_Bilhao = true;

                    }

                    for (int i = (dblValorInteiro.ToString().Trim().Length) - 1; i >= 0; i--)
                    {

                        // strNumero = Mid(dblValorInteiro.ToString().Trim(), (dblValorInteiro.ToString().Trim().Length - i) + 1, 1);

                        strNumero = Mid(dblValorInteiro.ToString().Trim(), (dblValorInteiro.ToString().Trim().Length - i) - 1, 1);

                        switch (i)
                        { /*******/

                            case 9: /*Bilhão*

/*******/
                                {

                                    strValorExtenso = fcn_Numero_Unidade(strNumero) + ((int.Parse(strNumero) > 1) ? " BILHÕES DE" : " BILHÃO DE");

                                    bln_Bilhao = true;

                                    break;

                                }

                            case 8: /********/

                            case 5: //Centena*

                            case 2: /********/
                                {

                                    if (int.Parse(strNumero) > 0)
                                    {

                                        strCentena = Mid(dblValorInteiro.ToString().Trim(), (dblValorInteiro.ToString().Trim().Length - i) - 1, 3);

                                        if (int.Parse(strCentena) > 100 && int.Parse(strCentena) < 200)
                                        {

                                            strValorExtenso = strValorExtenso + " CENTO E ";

                                        }

                                        else
                                        {

                                            strValorExtenso = strValorExtenso + " " + fcn_Numero_Centena(strNumero);

                                        }

                                        if (intContador == 8)
                                        {

                                            bln_Milhao = true;

                                        }

                                        else if (intContador == 5)
                                        {

                                            bln_Mil = true;

                                        }

                                    }

                                    break;

                                }

                            case 7: /*****************/

                            case 4: //Dezena de Milhão*

                            case 1: /*****************/
                                {

                                    if (int.Parse(strNumero) > 0)
                                    {

                                        strDezena = Mid(dblValorInteiro.ToString().Trim(), (dblValorInteiro.ToString().Trim().Length - i) - 1, 2);//

                                        if (int.Parse(strDezena) > 10 && int.Parse(strDezena) < 20)
                                        {

                                            strValorExtenso = strValorExtenso + (Right(strValorExtenso, 5).Trim() == "ENTOS" ? " E " : " ")

                                            + fcn_Numero_Dezena0(Right(strDezena, 1));//corrigido

                                            bln_Unidade = true;

                                        }

                                        else
                                        {

                                            strValorExtenso = strValorExtenso + (Right(strValorExtenso, 5).Trim() == "ENTOS" ? " E " : " ")

                                            + fcn_Numero_Dezena1(Left(strDezena, 1));//corrigido

                                            bln_Unidade = false;

                                        }

                                        if (intContador == 7)
                                        {

                                            bln_Milhao = true;

                                        }

                                        else if (intContador == 4)
                                        {

                                            bln_Mil = true;

                                        }

                                    }

                                    break;

                                }

                            case 6: /******************/

                            case 3: //Unidade de Milhão*

                            case 0: /******************/
                                {

                                    if (int.Parse(strNumero) > 0 && !bln_Unidade)
                                    {

                                        if ((Right(strValorExtenso, 5).Trim()) == "ENTOS"

                                        || (Right(strValorExtenso, 3).Trim()) == "NTE"

                                        || (Right(strValorExtenso, 3).Trim()) == "NTA")
                                        {

                                            strValorExtenso = strValorExtenso + " E ";

                                        }

                                        else
                                        {

                                            strValorExtenso = strValorExtenso + " ";

                                        }

                                        strValorExtenso = strValorExtenso + fcn_Numero_Unidade(strNumero);

                                    }

                                    if (i == 6)
                                    {

                                        if (bln_Milhao || int.Parse(strNumero) > 0)
                                        {

                                            strValorExtenso = strValorExtenso + ((int.Parse(strNumero) == 1) && !bln_Unidade ? " MILHÃO DE" : " MILHÕES DE");

                                            bln_Milhao = true;

                                        }

                                    }

                                    if (i == 3)
                                    {

                                        if (bln_Mil || int.Parse(strNumero) > 0)
                                        {

                                            strValorExtenso = strValorExtenso + " MIL";

                                            bln_Mil = true;

                                        }

                                    }

                                    if (i == 0)
                                    {

                                        if ((bln_Bilhao && !bln_Milhao && !bln_Mil

                                        && Right((dblValorInteiro.ToString().Trim()), 3) == "0")

                                        || (!bln_Bilhao && bln_Milhao && !bln_Mil

                                        && Right((dblValorInteiro.ToString().Trim()), 3) == "0"))
                                        {

                                            strValorExtenso = strValorExtenso + " DE ";

                                        }

                                        strValorExtenso = strValorExtenso + ((int.Parse(dblValorInteiro.ToString())) > 1 ? " REAIS " : " REAL ");

                                    }

                                    bln_Unidade = false;

                                    break;

                                }

                        }

                    }//

                }

                if (dblCentavos > 0)
                {

                    if ((Decimal.Parse(dblCentavos.ToString()) > 0) && (dblCentavos < (decimal)0.1))
                    {

                        strNumero = Right((Decimal.Round(dblCentavos, 2)).ToString().Trim(), 1);

                        strValorExtenso = strValorExtenso + ((Decimal.Parse(dblCentavos.ToString()) > 0) ? " E " : " ")

                        + fcn_Numero_Unidade(strNumero) + ((Decimal.Parse(strNumero) > 1) ? " CENTAVOS " : " CENTAVO ");

                    }

                    else if (dblCentavos > (decimal)0.1 && dblCentavos < (decimal)0.2)
                    {

                        strNumero = Right(((Decimal.Round(dblCentavos, 2) - (decimal)0.1).ToString().Trim()), 1);

                        strValorExtenso = strValorExtenso + ((Decimal.Parse(dblCentavos.ToString()) > 0) ? " E " : " ")

                        + fcn_Numero_Dezena0(strNumero) + " CENTAVOS ";

                    }

                    else
                    {

                        if (dblCentavos > 0) //0#
                        {

                            strNumero = Right(dblCentavos.ToString().Trim(), 2);//Mid(dblCentavos.ToString().Trim(), 0, 1);//
                            //MessageBox.Show(strNumero);
                            strValorExtenso = strValorExtenso + ((int.Parse(strNumero) > 0) ? " E " : "")//((int.Parse(dblCentavos.ToString()) > 0) ? " e " : " ")

                            + fcn_Numero_Dezena1(Left(strNumero, 1));

                            if ((dblCentavos.ToString().Trim().Length) > 2)
                            {

                                strNumero = Right((Decimal.Round(dblCentavos, 2)).ToString().Trim(), 1);

                                if (int.Parse(strNumero) > 0)
                                {

                                    if (Mid(strValorExtenso.Trim(), strValorExtenso.Trim().Length - 2, 1) == "E")
                                    {

                                        strValorExtenso = strValorExtenso + " " + fcn_Numero_Unidade(strNumero);

                                    }

                                    else
                                    {

                                        strValorExtenso = strValorExtenso + " E " + fcn_Numero_Unidade(strNumero);

                                    }

                                }

                            }

                            strValorExtenso = strValorExtenso + " CENTAVOS ";

                        }

                    }

                }

                if (dblValorInteiro < 1) strValorExtenso = Mid(strValorExtenso.Trim(), 2, strValorExtenso.Trim().Length -

                2);

            }

            return strValorExtenso.Trim();

        }

        private string fcn_Numero_Dezena0(string pstrDezena0)
        {

            //Vetor que irá conter o número por extenso

            try
            {
                String[] array_Dezena0 = new String[10];

                array_Dezena0[1] = "ONZE";

                array_Dezena0[2] = "DOZE";

                array_Dezena0[3] = "TREZE";

                array_Dezena0[4] = "QUATORZE";

                array_Dezena0[5] = "QUINZE";

                array_Dezena0[6] = "DEZESSEIS";

                array_Dezena0[7] = "DEZESSETE";

                array_Dezena0[8] = "DEZOITO";

                array_Dezena0[9] = "DEZENOVE";

                return array_Dezena0[(Convert.ToInt32(pstrDezena0))].ToString();
            }
            catch
            {
                MessageBox.Show("Não foi possível colocar o valor por extenso");
                string erro = "erro";
                return erro;
            }
        }

        private string fcn_Numero_Dezena1(string pstrDezena1)
        {

            //Vetor que irá conter o número por extenso

            String[] array_Dezena1 = new String[10];

            array_Dezena1[1] = "DEZ";

            array_Dezena1[2] = "VINTE";

            array_Dezena1[3] = "TRINTA";

            array_Dezena1[4] = "QUARENTA";

            array_Dezena1[5] = "CINQUENTA";

            array_Dezena1[6] = "SESSENTA";

            array_Dezena1[7] = "SETENTA";

            array_Dezena1[8] = "OITENTA";

            array_Dezena1[9] = "NOVENTA";

            return array_Dezena1[Convert.ToInt32(pstrDezena1)].ToString();

        }

        private string fcn_Numero_Centena(string pstrCentena)
        {

            //Vetor que irá conter o número por extenso

            String[] array_Centena = new String[10];

            array_Centena[1] = "CEM";

            array_Centena[2] = "DUZENTOS";

            array_Centena[3] = "TREZENTOS";

            array_Centena[4] = "QUATROCENTOS";

            array_Centena[5] = "QUINHENTOS";

            array_Centena[6] = "SEISCENTOS";

            array_Centena[7] = "SETECENTOS";

            array_Centena[8] = "OITOCENTOS";

            array_Centena[9] = "NOVECENTOS";

            return array_Centena[(Convert.ToInt32(pstrCentena))].ToString();

        }

        private string fcn_Numero_Unidade(string pstrUnidade)
        {

            //Vetor que irá conter o número por extenso
            String[] array_Unidade = new String[10];
            //ArrayList array_Unidade = new ArrayList();

            array_Unidade[1] = "UM";

            array_Unidade[2] = "DOIS";

            array_Unidade[3] = "TRÊS";

            array_Unidade[4] = "QUATRO";

            array_Unidade[5] = "CINCO";

            array_Unidade[6] = "SEIS";

            array_Unidade[7] = "SETE";

            array_Unidade[8] = "OITO";

            array_Unidade[9] = "NOVE";

            return array_Unidade[(Convert.ToInt32(pstrUnidade))].ToString();

        }

        //Começa aqui os Métodos de Compatibilazação com VB 6 .........Left() Right() Mid()

        public static string Left(string param, int length)
        {

            //we start at 0 since we want to get the characters starting from the

            //left and with the specified lenght and assign it to a variable

            if (param == "")

                return "";

            string result = param.Substring(0, length);

            //return the result of the operation

            return result;

        }

        public static string Right(string param, int length)
        {

            //start at the index based on the lenght of the sting minus

            //the specified lenght and assign it a variable

            if (param == "")

                return "";

            string result = param.Substring(param.Length - length, length);

            //return the result of the operation

            return result;

        }

        public static string Mid(string param, int startIndex, int length)
        {

            //start at the specified index in the string ang get N number of

            //characters depending on the lenght and assign it to a variable

            string result = param.Substring(startIndex, length);

            //return the result of the operation

            return result;

        }

        public static string Mid(string param, int startIndex)
        {

            //start at the specified index and return all characters after it

            //and assign it to a variable

            string result = param.Substring(startIndex);

            //return the result of the operation

            return result;

        }

        private void tb_cliente_DoubleClick(object sender, EventArgs e)
        {

        }

        public Boolean criar_arquivo(String Name)
        {
            StreamWriter Arquivo;

            try
            {

                Arquivo = new StreamWriter("c:\\evolucao\\NFE\\TXT\\" + Name);


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

        private string transforma_zero(int tamanho_pretendido, int casas_decimais, string valor)
        {
            novo_valor = "";
            int tamanho_atual = valor.Length;
            int pos_virgula = 0;
            //int qtde_zeros_antes = 0;
            int qtde_zeros_depois = 0;
            if (valor.Contains(","))
            {
                while (valor[pos_virgula].ToString() != ",")
                {
                    pos_virgula++;
                }
                pos_virgula++; //por que começa com 0
                qtde_zeros_depois = casas_decimais - (tamanho_atual - pos_virgula);
                //MessageBox.Show(tamanho_atual.ToString());
                //MessageBox.Show(pos_virgula.ToString());
            }
            else
                qtde_zeros_depois = 4;
            if (casas_decimais == 0)
                qtde_zeros_depois = 0;
            for (int qtde_zeros = 0; qtde_zeros < qtde_zeros_depois; qtde_zeros++)
                valor = valor + "0";

            valor = valor.Replace(",", "");
            //MessageBox.Show(valor);
            return zero(tamanho_pretendido, valor);




        }

        private string depois(int tamanho_pretendido, string valor)
        {
            int tamanho = valor.Length;
            for (int p = 0; p < tamanho_pretendido - tamanho; p++)
            {
                valor = valor + " ";
            }
            return valor;
        }

        private string transforma(int tamanho_pretendido, string valor)
        {
            valor = zero(tamanho_pretendido, valor);
            novo_valor = "";
            int tamanho = valor.Length;
            for (int p = 0; p < tamanho_pretendido; p++)
            {

                novo_valor = novo_valor + valor[p].ToString();
                //MessageBox.Show(novo_valor);
            }

            return novo_valor;

        }

        private string espaco_depois(int tamanho_pretendido, string valor)
        {

            int tamanho = valor.Length;
            for (int p = 0; p < tamanho_pretendido - tamanho; p++)
            {
                valor = valor + " ";
            }
            return valor;
        }

       


        private string zero_a_esquerda_caixa(int tamanho_pretendido, string valor)
        {
            tamanho_pretendido = tamanho_pretendido - 2; //por causa do 14 na frente (Caixa) 
            int tamanho = valor.Length;
            for (int p = 0; p < tamanho_pretendido - tamanho; p++)
            {
                valor = "0" + valor;
            }
            valor = "14" + valor;
            return valor;
        }

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

        private string zero(int tamanho_pretendido, string valor)
        {

            int tamanho = valor.Length;
            for (int p = 0; p < tamanho_pretendido - tamanho; p++)
            {
                valor = " " + valor;
            }
            return valor;
        }

        private void vai_primeiro_Click(object sender, EventArgs e)
        {
            this.BindingContext[dsNota_fiscal, "NOTA_FISCAL"].Position = 0;
        }

        private void vai_anterior_Click(object sender, EventArgs e)
        {
            this.BindingContext[dsNota_fiscal, "NOTA_FISCAL"].Position--;
        }

        private void vai_proximo_Click(object sender, EventArgs e)
        {
            this.BindingContext[dsNota_fiscal, "NOTA_FISCAL"].Position++;
        }

        private void vai_ultimo_Click(object sender, EventArgs e)
        {
            this.BindingContext[dsNota_fiscal, "NOTA_FISCAL"].Position = 100000000;
        }

        private void b(object sender, EventArgs e)
        {

        }

        private void tb_n_nf_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_n_nf_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            abre_nova();
        }

        private void abre_nova()
        {
            form_pesquisa_nf abre_nf = new form_pesquisa_nf(cnpj_empresa);
            try
            {
                //this.Close();
                abre_nf.ShowDialog();
            }
            finally
            {
                abre_nf.Dispose();
                try
                {
                    dsNota_fiscal.Clear();
                    dsItens_nota.Clear();
                    dsFatura_nf.Clear();

                    nf_atual = abre_nf.nf_escolhida;

                    if (nf_atual != null)
                    {
                        this.datNota_fiscal.SelectCommand.CommandText =
                       "SELECT * FROM NOTA_FISCAL WHERE N_NF = '" + nf_atual + "' AND CNPJ_EMISSOR_NF = '" + cnpj_empresa + "'";
                        /*"SELECT n.*, pv.vendedor_ped_venda " + 
                        "FROM NOTA_FISCAL n " + 
                        "INNER JOIN pedidos_nf pnf " + 
                        "ON pnf.nf_pedido_nf = n.n_nf " + 
                        "INNER JOIN pedidos_venda pv " + 
                        "ON pv.cod_ped_venda = pnf.n_pedido_nf " + 
                        "WHERE n.n_nf = '" + nf_atual + "'";*/
                        this.fbConnection1.Open();
                        this.datNota_fiscal.SelectCommand.Connection = fbConnection1;
                        this.datNota_fiscal.SelectCommand.ExecuteNonQuery();
                        datNota_fiscal.Fill(NOTA_FISCAL);
                        this.fbConnection1.Close();

                        this.datItens_nota.SelectCommand.CommandText =
                       // "SELECT * FROM ITENS_NOTA WHERE NF_ITEM = '" + tb_n_nf.Text + "' ORDER BY COD_ITENS_NOTA";
                        "SELECT * FROM ITENS_NOTA WHERE COD_SISTEMA_NF_ITEM = '" + tb_cod_interno.Text + "' order by cod_itens_nota";
                        this.fbConnection1.Open();
                        this.datItens_nota.SelectCommand.Connection = fbConnection1;
                        this.datItens_nota.SelectCommand.ExecuteNonQuery();
                        datItens_nota.Fill(ITENS_NOTA);
                        this.fbConnection1.Close();

                        this.datFatura_nf.SelectCommand.CommandText =
                        "SELECT * FROM FATURA_NF WHERE COD_SISTEMA_NF_FATURA = '" + tb_cod_interno.Text + "'";
                        this.fbConnection1.Open();
                        this.datFatura_nf.SelectCommand.Connection = fbConnection1;
                        this.datFatura_nf.SelectCommand.ExecuteNonQuery();
                        datFatura_nf.Fill(FATURA_NF);
                        this.fbConnection1.Close();


                        dsPedidos_nf.Clear();
                        this.datPedidos_nf.SelectCommand.CommandText =
                        "SELECT * FROM PEDIDOS_NF WHERE COD_SISTEMA_PEDIDO_NF = '" + tb_cod_interno.Text + "'";
                        /*"SELECT pnf.*, pv.vendedor_ped_venda " + 
                        "FROM PEDIDOS_NF pnf " + 
                        "INNER JOIN pedidos_venda pv " + 
                        "ON pv.cod_ped_venda = pnf.n_pedido_nf " + 
                        "WHERE NF_PEDIDO_NF = '" + tb_n_nf.Text + "'";*/
                        this.fbConnection1.Open();
                        this.datPedidos_nf.SelectCommand.Connection = fbConnection1;
                        this.datPedidos_nf.SelectCommand.ExecuteNonQuery();
                        datPedidos_nf.Fill(PEDIDOS_NF);
                        this.fbConnection1.Close();
                    }

                }
                catch (Exception a)
                {
                    fbConnection1.Close();
                    MessageBox.Show(a.ToString());
                }

            }
        }


        private bool verificarDuplicidadeItemPedido()
        {
            //for (int i = 0; i < dgvItens_nota.RowCount; i++)
            //{
            //    if (tb_cod_peca.Text == dgvItens_nota.Rows[i].Cells["col_cod_op"].Value.ToString())
            //    {
            //        return true;
            //    }
            //}
            return false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string tipo = verificarRateio(tb_cod_peca.Text);
            inserir_itens(false, tipo, "");
        }

        private string verificarRateio(string codProduto)
        {
            return "";
            
        }
        private void inserir_itens(bool retorno, string tipo, string cod_sistema)
        {
            if (verificarDuplicidadeItemPedido() == false || tb_cfo_peca.Text == "5902" || tb_cfo_peca.Text == "6902")
            {

                if (tb_protocolo_autorizacao.Text == "")
                {
                    Atualizar(false);

                    try
                    {

                        if (tb_qtde_peca.Text == "" || tb_descricao_peca.Text == "" || tb_unid_peca.Text == "" ||
                            tb_ncm_peca.Text == "" || tb_preco_unit_peca.Text == "")
                        {
                            MessageBox.Show("Os itens: Descrição, Unidade, Qtde, Preço Unitário, NCM e CFOP são obrigatórios");
                            //tb_qtde_peca.Focus();

                        }

                        else
                        {
                            double porcTotTrib = 0;
                            double vTotalTribItem = 0;
                            double preco_unit = Convert.ToDouble(tb_preco_unit_peca.Text);
                            double qtde = Convert.ToDouble(tb_qtde_peca.Text);

                            double preco_total = preco_unit * qtde;
                            string preco_unit_ponto = preco_unit.ToString().Replace(',', '.');
                            string preco_total_ponto = preco_total.ToString().Replace(".", "").Replace(',', '.');
                            string qtde_ponto = qtde.ToString().Replace(".", "").Replace(",", ".");
                            string prestacao_servico = "0";
                            string cfop;

                            //Se não for zero, então o sistema deverá deixar o campo vazio para buscar a CFOP automaticamente
                            if (tb_cfo_peca.Text == "0")
                            {
                                tb_cfo_peca.Text = "";
                            }

                            if (cb_prestacao_servico.Checked == true)
                            {
                                prestacao_servico = "1";
                            }

                            string cod = "null", frete = "null", desconto = "null", outras_desp = "null", seguro = "null", ean = "null";
                            if (tb_cod_peca.Text != "")
                                cod = tb_cod_peca.Text;
                            //if (tb_ean.Text.Length < 13)
                            //    tb_ean.Text = "";
                            if (tb_ean.Text != "")
                                ean = "'" + tb_ean.Text + "'";
                            if (tb_frete_item.Text != "")
                                frete = "'" + tb_frete_item.Text.Replace(".", "").Replace(",", ".") + "'";
                            if (tb_desconto_item.Text != "")
                                desconto = "'" + tb_desconto_item.Text.Replace(".", "").Replace(",", ".") + "'";
                            if (tb_outras_desp_item.Text != "")
                                outras_desp = "'" + tb_outras_desp_item.Text.Replace(".", "").Replace(",", ".") + "'";
                            if (tb_seguro_item.Text != "")
                                seguro = "'" + tb_seguro_item.Text.Replace(".", "").Replace(",", ".") + "'";
                            string pedido_compra = "null", item_pedido_compra = "null";
                            if (tb_pedido_compra.Text != "")
                                pedido_compra = "'" + tb_pedido_compra.Text + "'";
                            if (tb_n_item_pedido_compra.Text != "")
                                item_pedido_compra = "'" + tb_n_item_pedido_compra.Text + "'";
                            string _origem, _cst, _modalidade, _icms, _icms_st, _reducao, _reducao_st, _iva, _ipi, _pis,
                               _cofins, _iss, _crt, _aliquota_credito, _modalidade_st, _bc_com_ipi, _ipi_tributado,
                               _ipi_n_tributado, _cst_ipi_tributado, _cst_ipi_n_tributado, _tipo_pis, _cst_pis,
                               _tipo_cofins, _cst_cofins, _pCredICMS, _preco_minimo, _custo_produto, _cfop_produto, _cest_produto,
                                _cst_ibscbs, _classificacao_ibscbs, _aliquota_ibs, _aliquota_cbs;




                            buscar_informacoes_produto(cod_sistema, out _origem, out _cst, out _modalidade, out _icms,
                                    out _icms_st, out _reducao, out _reducao_st, out _iva, out _ipi, out _pis, out _cofins,
                                    out _iss, out _crt, out _aliquota_credito, out _modalidade_st, out _bc_com_ipi,
                                    out _ipi_tributado, out _ipi_n_tributado, out _cst_ipi_tributado,
                                    out _cst_ipi_n_tributado, out _tipo_pis, out _cst_pis, out _tipo_cofins, out _cst_cofins,
                                    out _pCredICMS, out _preco_minimo, out _custo_produto, out _cfop_produto, out _cest_produto, tipo, tb_estado_cliente.Text, tb_ncm_peca.Text,
                                    out _cst_ibscbs, out _classificacao_ibscbs, out _aliquota_ibs, out _aliquota_cbs);
                            if (tb_cfo_peca.Text != "")
                                {

                                }

                                else
                                {
                                    tb_cfo_peca.Text = _cfop_produto;
                                }
                            if (!retorno && (rb_1410.Checked || rb_5904.Checked || rb_5910.Checked || rb_5202.Checked || 
                                rb_5949.Checked || rb_5917.Checked || rb5101.Checked || rb5124.Checked))
                            {
                                
                                if (rb_1410.Checked)
                                    tb_cfo_peca.Text = "1410";
                                if (rb_5904.Checked)
                                    tb_cfo_peca.Text = "5904";
                                if (rb_5910.Checked)
                                    tb_cfo_peca.Text = "5910";
                                if (rb_5202.Checked)
                                    tb_cfo_peca.Text = "5202";
                                if (rb_5949.Checked)
                                    tb_cfo_peca.Text = "5949";
                                if (rb_5917.Checked)
                                    tb_cfo_peca.Text = "5917";
                                if (rb5101.Checked)
                                    tb_cfo_peca.Text = "5101";
                                if (rb5124.Checked)
                                    tb_cfo_peca.Text = "5124";
                                if (tb_estado_cliente.Text != estadolabel.Text)
                                {
                                    
                                        if (rb_1410.Checked)
                                            tb_cfo_peca.Text = "1410";
                                        if (rb_5904.Checked)
                                            tb_cfo_peca.Text = "5904";
                                        if (rb_5910.Checked)
                                            tb_cfo_peca.Text = "5910";
                                        if (rb_5202.Checked)
                                            tb_cfo_peca.Text = "5202";
                                        if (rb_5949.Checked)
                                            tb_cfo_peca.Text = "5949";
                                        if (rb_5917.Checked)
                                            tb_cfo_peca.Text = "5917";
                                        if (rb5101.Checked)
                                            tb_cfo_peca.Text = "6101";
                                        if (rb5124.Checked)
                                            tb_cfo_peca.Text = "6124";
                                    
                                }
                            }
                            if (tb_cfo_peca.Text == "")
                            {
                                if (tb_estado_cliente.Text == estadolabel.Text)
                                {
                                    if (rb_1410.Checked || rb_5904.Checked || rb_5910.Checked || rb_5202.Checked || rb_5949.Checked || rb_5917.Checked || rb5124.Checked)
                                    {
                                        if (rb_1410.Checked)
                                            tb_cfo_peca.Text = "1410";
                                        if (rb_5904.Checked)
                                            tb_cfo_peca.Text = "5904";
                                        if (rb_5910.Checked)
                                            tb_cfo_peca.Text = "5910";
                                        if (rb_5202.Checked)
                                            tb_cfo_peca.Text = "5202";
                                        if (rb_5949.Checked)
                                            tb_cfo_peca.Text = "5949";
                                        if (rb_5917.Checked)
                                            tb_cfo_peca.Text = "5917";
                                        if (rb5124.Checked)
                                            tb_cfo_peca.Text = "5124";
                                    }
                                    else
                                    {
                                        if (_cst == "40")
                                        {
                                            tb_cfo_peca.Text = "5101";
                                        }
                                        if (_cst == "90")
                                        {
                                            tb_cfo_peca.Text = "5101";
                                        }
                                        if (_cst == "60")
                                        {
                                            tb_cfo_peca.Text = "5405";
                                        }
                                        if (_cst == "20")
                                        {
                                            tb_cfo_peca.Text = "5102";
                                        }
                                        if (_cst == "51")
                                        {
                                            tb_cfo_peca.Text = "5101";
                                        }
                                        if (_cst == "00")
                                        {
                                            tb_cfo_peca.Text = "5101";
                                        }
                                        if (_cst == "10")
                                        {
                                            tb_cfo_peca.Text = "5401";
                                        }
                                        if (_cst == "400")
                                        {
                                            tb_cfo_peca.Text = "5405";
                                        }
                                        if (_cst == "500")
                                        {
                                            tb_cfo_peca.Text = "5405";
                                        }
                                        if (_cst == "101")
                                        {
                                            tb_cfo_peca.Text = "5101";
                                            if (razao_social_empresa.Contains("RUSSO") || razao_social_empresa.Contains("BR LUDICA"))
                                                tb_cfo_peca.Text = "5104";
                                        }
                                        if (_cst == "201")
                                        {
                                            tb_cfo_peca.Text = "5401";
                                        }
                                    }
                                }
                                else
                                {
                                    if (tb_estado_cliente.Text != estadolabel.Text)
                                    {
                                        if (rb_1410.Checked || rb_5904.Checked || rb_5910.Checked || rb_5202.Checked || rb_5949.Checked || rb5124.Checked)
                                        {
                                            if (rb_1410.Checked)
                                                tb_cfo_peca.Text = "2410";
                                            if (rb_5904.Checked)
                                                tb_cfo_peca.Text = "6904";
                                            if (rb_5910.Checked)
                                                tb_cfo_peca.Text = "6910";
                                            if (rb_5202.Checked)
                                                tb_cfo_peca.Text = "6202";
                                            if (rb_5949.Checked)
                                                tb_cfo_peca.Text = "6949";
                                            if (rb_5917.Checked)
                                                tb_cfo_peca.Text = "6917";
                                            if (rb5124.Checked)
                                                tb_cfo_peca.Text = "6124";
                                    
                                        }
                                        else
                                        {
                                            if (_cst == "60")
                                            {
                                                tb_cfo_peca.Text = "6404";
                                            }
                                            if (_cst == "90")
                                            {
                                                tb_cfo_peca.Text = "5101";
                                            }
                                            if (_cst == "20")
                                            {
                                                tb_cfo_peca.Text = "6102";
                                            }
                                            if (_cst == "00")
                                            {
                                                tb_cfo_peca.Text = "6101";
                                            }
                                            if (_cst == "10")
                                            {
                                                tb_cfo_peca.Text = "6401";
                                            }
                                            if (_cst == "400")
                                            {
                                                tb_cfo_peca.Text = "6404";
                                            }
                                            if (_cst == "500")
                                            {
                                                tb_cfo_peca.Text = "6404";
                                            }
                                            if (_cst == "101")
                                            {
                                                tb_cfo_peca.Text = "6101";
                                                if (razao_social_empresa.Contains("RUSSO") || razao_social_empresa.Contains("BR LUDICA"))
                                                    tb_cfo_peca.Text = "6104";
                                            }
                                            if (_cst == "201")
                                            {
                                                tb_cfo_peca.Text = "6401";
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (empresa_simples())
                                            tb_cfo_peca.Text = "6401";
                                        else
                                            tb_cfo_peca.Text = "6404";
                                    }
                                }
                            }

                            if (verificar_se_e_tributada(tb_cfo_peca.Text))
                            {

                                tabControl1.SelectedTab = tabPage5;
                                cbTributada.Checked = true;
                                tabControl1.SelectedTab = tabPage1;
                                bool ext = false;
                                if (tb_cfo_peca.Text.Trim().Substring(0, 1) == "3")
                                {
                                    ext = true;
                                }
                                else
                                {
                                    ext = false;
                                }

                                try
                                {
                                    porcTotTrib = buscarTotalTribPorItem(tb_ncm_peca.Text, ext);
                                    vTotalTribItem = (preco_total * porcTotTrib) / 100;
                                    vTotalTribItem = Convert.ToDouble(transforma_decimal(2, vTotalTribItem.ToString(), 15).Replace(".", ","));
                                    if (vTotalTribItem == 0)
                                    {
                                        {
                                           // MessageBox.Show("NCM Não encontrado na tabela");
                                        }
                                    }
                                }
                                catch
                                { }
                            }
                            else
                            {
                                tabControl1.SelectedTab = tabPage5;
                                cbNaoTributada.Checked = true;
                                rb_ipi_nao_tributado.Checked = true;
                                tabControl1.SelectedTab = tabPage1;
                            }
                            double preco_minimo = 0;
                            try
                            {
                                preco_minimo = Convert.ToDouble(_preco_minimo) * qtde;
                            }
                            catch
                            {

                            }

                            double custo_produto = 0;
                            try
                            {
                                custo_produto = Convert.ToDouble(_custo_produto) * qtde;
                            }
                            catch
                            {

                            }
                            string cl = "null";
                            if (!retorno && tb_cl.Text != "")
                            {
                                cl = tb_cl.Text;
                            }

                            this.datItens_nota.InsertCommand.CommandText =
                            "INSERT INTO ITENS_NOTA (DESCRICAO_ITEM, UNIDADE_ITEM, QTDE_ITEM, PRECO_UNIT_ITEM," +
                            "PRECO_TOTAL_ITEM, NF_ITEM, NCM_ITEM, CFOP_ITEM, PRESTACAO_SERVICO_ITEM, COD_ITEM," +
                            "PEDIDO_COMPRA_ITEM, ITEM_PEDIDO_COMPRA_ITEM, VALOR_FRETE_ITEM, VALOR_DESCONTO_ITEM," +
                            "VALOR_OUTRAS_DESP_ITEM, VALOR_SEGURO_ITEM, COD_EAN_ITEM, PORC_TRIB_ITEM, TOTAL_TRIB_ITEM, " + 
                            "PRECO_MINIMO_ITEM, CUSTO_ITEM, CEST_ITEM, COD_SISTEMA_NF_ITEM, COD_ITEM_LIBERACAO_ITEM)" +
                            "VALUES ('" + tb_descricao_peca.Text.Replace("\t", "").Replace("'", "''") + "','" + tb_unid_peca.Text + "','" + qtde_ponto +
                            "','" + preco_unit_ponto + "','" + preco_total_ponto + "','" + tb_n_nf.Text + "','" +
                            tb_ncm_peca.Text + "','" + tb_cfo_peca.Text + "','" + prestacao_servico + "','" + cod +
                            "'," + pedido_compra + "," + item_pedido_compra + "," + frete + "," + desconto + "," +
                            outras_desp + "," + seguro + "," + ean + "," + porcTotTrib.ToString().Replace(",", ".") + "," + vTotalTribItem.ToString().Replace(",", ".") +
                            "," + preco_minimo.ToString("n2").Replace(".", "").Replace(",", ".") + "," + custo_produto.ToString("n2").Replace(".", "").Replace(",", ".") + ",'" +
                            _cest_produto + "','" + tb_cod_interno.Text + "'," + cl + ") RETURNING COD_ITENS_NOTA";
                            this.fbConnection1.Open();
                            this.datItens_nota.InsertCommand.Connection = fbConnection1;
                            object cod_item_nota = datItens_nota.InsertCommand.ExecuteScalar();
                            this.fbConnection1.Close();
                            // dsItens_nota.Clear();
                            // this.datItens_nota.SelectCommand.CommandText =
                            //// "SELECT * FROM ITENS_NOTA WHERE NF_ITEM = '" + tb_n_nf.Text + "' order by cod_itens_nota";
                            // "SELECT * FROM ITENS_NOTA WHERE COD_SISTEMA_NF_ITEM = '" + tb_cod_interno.Text + "' order by cod_itens_nota";
                            // this.fbConnection1.Open();
                            // this.datItens_nota.SelectCommand.Connection = fbConnection1;
                            // this.datItens_nota.SelectCommand.ExecuteNonQuery();
                            // datItens_nota.Fill(ITENS_NOTA);
                            // this.fbConnection1.Close();


                            /*
                            buscar_informacoes_padrao(out _origem, out _cst, out _modalidade, out _icms,
                                out _icms_st, out _reducao, out _iva, out _ipi, out _pis, out _cofins,
                                out _iss, out _crt, out _aliquota_credito, out _modalidade_st, out _bc_com_ipi,
                                out _ipi_tributado, out _ipi_n_tributado, out _cst_ipi_tributado,
                                out _cst_ipi_n_tributado, out _tipo_pis, out _cst_pis, out _tipo_cofins, out _cst_cofins, out _pCredICMS);
                            */


                            classeTributacao trib = new classeTributacao();
                            //PREENCHENDO VALORES SE ELES NÃO TIVEREM SIDO PREENCHIDOS JÁ
                            if (tb_cst.Text == "")
                                tb_cst.Text = _cst;
                            if (tb_mod_bc_item.Text == "")
                                tb_mod_bc_item.Text = _modalidade;
                            if (tb_mod_bc_st_item.Text == "")
                                tb_mod_bc_st_item.Text = _modalidade_st;
                            if (tb_origem_peca.Text == "")
                                tb_origem_peca.Text = _origem;
                            if (tb_icms_item.Text == "")
                                tb_icms_item.Text = _icms;
                            if (tb_icms_st.Text == "")
                                tb_icms_st.Text = _icms_st;
                            if (tb_reducao_item.Text == "")
                                tb_reducao_item.Text = _reducao;
                            if (tb_reducao_st_item.Text == "")
                                tb_reducao_st_item.Text = _reducao_st;
                            if (tb_iva_item.Text == "")
                                tb_iva_item.Text = _iva;
                            if (tb_ipi_item.Text == "")
                                tb_ipi_item.Text = _ipi;
                            if (tb_pis_item.Text == "")
                                tb_pis_item.Text = _pis;
                            if (tb_cofins_item.Text == "")
                                tb_cofins_item.Text = _cofins;
                            if (tb_iss_item.Text == "")
                                tb_iss_item.Text = _iss;
                            if (tb_origem_peca.Text == "")
                                tb_origem_peca.Text = _origem;
                            //IBS CBS
                            if (tb_cst_ibscbs.Text == "")
                                tb_cst_ibscbs.Text = _cst_ibscbs;
                            if (tb_classificacao_ibscbs.Text == "")
                                tb_classificacao_ibscbs.Text = _classificacao_ibscbs;
                            if (tb_aliquota_ibs.Text == "")
                                tb_aliquota_ibs.Text = _aliquota_ibs;
                            if (tb_aliquota_cbs.Text == "")
                                tb_aliquota_cbs.Text = _aliquota_cbs;

                            if (tb_aliquota_credito.Text == "")
                            {
                                tb_aliquota_credito.Text = _pCredICMS;
                            }
                            if (cbBC_com_ipi.Checked == false)
                            {
                                if (_bc_com_ipi == "1")
                                    cbBC_com_ipi.Checked = true;
                            }
                            if ((rb_ipi_tributado.Checked == false && rb_ipi_nao_tributado.Checked == false))
                            {
                                if (_ipi_tributado == "1")
                                {
                                    rb_ipi_tributado.Checked = true;
                                }
                                if (_ipi_n_tributado == "1" || !verificar_se_e_tributada(tb_cfo_peca.Text))
                                {
                                    rb_ipi_nao_tributado.Checked = true;
                                }
                            }
                            if ((tb_cst_ipi_tributado.Text == "" || tb_cst_ipi_n_tributado.Text == ""))
                            {
                                if (_ipi_tributado == "1")
                                {
                                    tb_cst_ipi_tributado.Text = _cst_ipi_tributado;
                                }
                                if (_ipi_n_tributado == "1" || !verificar_se_e_tributada(tb_cfo_peca.Text))
                                {
                                    tb_cst_ipi_n_tributado.Text = _cst_ipi_n_tributado;
                                }
                            }
                            if (tb_tipo_pis.Text == "")
                            {
                                tb_tipo_pis.Text = _tipo_pis;
                            }
                            if (tb_cst_pis.Text == "")
                            {
                                tb_cst_pis.Text = _cst_pis;
                            }
                            if (tb_tipo_cofins.Text == "")
                            {
                                tb_tipo_cofins.Text = _tipo_cofins;
                            }
                            if (tb_cst_cofins.Text == "")
                            {
                                tb_cst_cofins.Text = _cst_cofins;
                            }


                            //SE FOR CFOP TRIBUTADA
                            if (cbTributada.Checked == true)
                            {



                                //TRIBUTACAO
                                //VALORES PADROES


                                trib.modBC = tb_mod_bc_item.Text[0].ToString();
                                trib.orig = tb_origem_peca.Text[0].ToString();
                                // SE FOR SIMPLES NACIONAL
                                if (_crt == "1")
                                {
                                    double valor_ipi = 0;
                                    trib.vBC = calcular_bc(tb_frete_item.Text, tb_desconto_item.Text,
                                    tb_outras_desp_item.Text, tb_seguro_item.Text, preco_total_ponto.Replace(".", ","), valor_ipi);
                                    if (tb_cst.Text == "101")
                                    {
                                        trib.CST = "101";
                                        if (tb_aliquota_credito.Text == "")
                                            tb_aliquota_credito.Text = "0";
                                        trib.pCredSN = Convert.ToDouble(tb_aliquota_credito.Text);
                                        tb_aliquota_simples.Text = tb_aliquota_credito.Text;

                                        trib.cst101();
                                        trib.vBC = 0;
                                    }
                                    if (tb_cst.Text == "102")
                                    {
                                        trib.CST = "102";
                                        trib.vBC = 0;
                                        //NÃO PRECISA DE MAIS NENHUMA INFORMAÇÃO
                                    }
                                    if (tb_cst.Text == "201")
                                    {
                                        trib.CST = "201";
                                        trib.pCredSN = Convert.ToDouble(tb_aliquota_credito.Text);
                                        tb_aliquota_simples.Text = tb_aliquota_credito.Text;
                                        trib.pICMS = Convert.ToDouble(tb_icms_item.Text);
                                        trib.pICMSST = Convert.ToDouble(tb_icms_st.Text);
                                        trib.pMVAST = Convert.ToDouble(tb_iva_item.Text);
                                        trib.modBCST = tb_mod_bc_st_item.Text[0].ToString();
                                        trib.cst201();
                                    }
                                    if (tb_cst.Text == "202")
                                    {
                                        trib.CST = "202";
                                        trib.pICMS = Convert.ToDouble(tb_icms_item.Text);
                                        trib.pICMSST = Convert.ToDouble(tb_icms_st.Text);
                                        trib.pMVAST = Convert.ToDouble(tb_iva_item.Text);
                                        trib.modBCST = tb_mod_bc_st_item.Text[0].ToString();
                                        trib.cst202();
                                    }
                                    if (tb_cst.Text == "500")
                                    {
                                        trib.CST = "500";
                                        try
                                        {
                                            trib.pICMSST = Convert.ToDouble(tb_icms_st.Text);
                                            trib.pMVAST = Convert.ToDouble(tb_iva_item.Text);
                                        }
                                        catch
                                        {
                                            trib.pICMSST = Convert.ToDouble("0");
                                            trib.pMVAST = Convert.ToDouble("0");
                                        }

                                        trib.cst500();
                                    }
                                    if (tb_cst.Text == "900")
                                    {
                                        trib.CST = "900";
                                        try
                                        {
                                            trib.pICMS = Convert.ToDouble(tb_icms_item.Text);
                                        }
                                        catch
                                        {
                                            trib.pICMS = 0;
                                        }
                                        try
                                        {
                                            trib.pICMSST = Convert.ToDouble(tb_icms_st.Text);

                                        }
                                        catch
                                        {
                                            trib.pICMSST = 0;
                                        }
                                        trib.modBCST = tb_mod_bc_st_item.Text[0].ToString();
                                        try
                                        {
                                            trib.pMVAST = Convert.ToDouble(tb_iva_item.Text);
                                        }
                                        catch
                                        {
                                            trib.pMVAST = 0;
                                        }
                                        try
                                        {
                                            trib.pRedBCST = Convert.ToDouble(tb_reducao_st_item.Text);
                                        }
                                        catch
                                        {
                                            trib.pRedBCST = 0;
                                        }
                                        try
                                        {
                                            trib.pRedBC = Convert.ToDouble(tb_reducao_item.Text);
                                        }
                                        catch
                                        {
                                            trib.pRedBC = 0;
                                        }

                                        trib.cst900();

                                    }
                                    //IPI
                                    //if (tb_cst_ipi_n_tributado.Text == "")
                                    //    tb_cst_ipi_n_tributado.Text = "53 - Saída não tributada";
                                    //trib.cstIPINaoTributado = tb_cst_ipi_n_tributado.Text.Remove(2);
                                    //trib.ipiNaoTributado = true;
                                    //double valor_ipi = 0;
                                    //IPI
                                    if (rb_ipi_tributado.Checked == true)
                                    {
                                        trib.BCIPI = calcular_bc(tb_frete_item.Text, tb_desconto_item.Text,
                                    tb_outras_desp_item.Text, tb_seguro_item.Text, preco_total_ponto.Replace(".", ","), valor_ipi);
                                        trib.pIPI = Convert.ToDouble(tb_ipi_item.Text);
                                        trib.cstIPITributado = tb_cst_ipi_tributado.Text.Substring(0, 2);
                                        trib.ipiTributado = true;
                                        trib.calcular_ipi();
                                    }
                                    else
                                    {
                                        trib.cstIPINaoTributado = tb_cst_ipi_n_tributado.Text.Substring(0, 2);
                                        trib.ipiNaoTributado = true;
                                    }
                                    //PIS
                                    trib.cstPIS = tb_cst_pis.Text.Remove(2);
                                    trib.tipoPIS = tb_tipo_pis.Text;
                                    //COFINS
                                    trib.cstCOFINS = tb_cst_cofins.Text.Remove(2);
                                    trib.tipoCOFINS = tb_tipo_cofins.Text;
                                    //ISS
                                    if (tb_iss_item.Text != "")
                                    {
                                        trib.BCISS = calcular_bc(tb_frete_item.Text, tb_desconto_item.Text,
                                    tb_outras_desp_item.Text, tb_seguro_item.Text, preco_total_ponto.Replace(".", ","), valor_ipi);
                                        trib.pISS = Convert.ToDouble(tb_iss_item.Text);
                                        trib.tipoISS = tb_tipo_servico.Text;
                                        trib.calcular_iss();
                                    }
                                }
                                //SE FOR REGIME NORMAL
                                if (_crt == "3" || _crt == "2")
                                {
                                    double valor_ipi = 0;
                                    //IPI
                                    if (rb_ipi_tributado.Checked == true)
                                    {
                                        trib.BCIPI = calcular_bc(tb_frete_item.Text, tb_desconto_item.Text,
                                    tb_outras_desp_item.Text, tb_seguro_item.Text, preco_total_ponto.Replace(".", ","), valor_ipi);
                                        trib.pIPI = Convert.ToDouble(tb_ipi_item.Text);
                                        trib.cstIPITributado = tb_cst_ipi_tributado.Text.Substring(0, 2);
                                        trib.ipiTributado = true;
                                        trib.calcular_ipi();
                                    }
                                    else
                                    {
                                        trib.cstIPINaoTributado = tb_cst_ipi_n_tributado.Text.Substring(0, 2);
                                        trib.ipiNaoTributado = true;
                                    }
                                    
                                    //ISS
                                    if (tb_iss_item.Text != "")
                                    {
                                        trib.BCISS = calcular_bc(tb_frete_item.Text, tb_desconto_item.Text,
                                    tb_outras_desp_item.Text, tb_seguro_item.Text, preco_total_ponto.Replace(".", ","), valor_ipi);
                                        trib.pISS = Convert.ToDouble(tb_iss_item.Text);
                                        trib.tipoISS = tb_tipo_servico.Text;
                                        trib.calcular_iss();
                                    }
                                    //ICMS

                                    if (cbBC_com_ipi.Checked == true) //SE O IPI VIER EMBUTIDO NA BC DO ICMS
                                        valor_ipi = trib.vIPI;
                                    trib.vBC = calcular_bc(tb_frete_item.Text, tb_desconto_item.Text,
                                    tb_outras_desp_item.Text, tb_seguro_item.Text, preco_total_ponto.Replace(".", ","), valor_ipi);

                                    if (tb_cst.Text == "00")//TRIBUTADA INTEGRALMENTE
                                    {
                                        trib.CST = "00";
                                        trib.pICMS = Convert.ToDouble(tb_icms_item.Text);
                                        trib.cst00();
                                    }
                                    if (tb_cst.Text == "10")//SUBST. TRIBUTARIA
                                    {
                                        trib.CST = "10";
                                        trib.pICMS = Convert.ToDouble(tb_icms_item.Text);
                                        trib.pICMSST = Convert.ToDouble(tb_icms_st.Text);
                                        trib.pMVAST = Convert.ToDouble(tb_iva_item.Text);
                                        trib.modBCST = tb_mod_bc_st_item.Text[0].ToString();
                                        trib.cst10();
                                    }
                                    if (tb_cst.Text == "20")//REDUCAO DE BC
                                    {
                                        trib.CST = "20";
                                        trib.pICMS = Convert.ToDouble(tb_icms_item.Text);
                                        trib.pRedBC = Convert.ToDouble(tb_reducao_item.Text);
                                        trib.cst20();
                                    }
                                    if (tb_cst.Text == "40")
                                    {
                                        trib.CST = "40";

                                    }
                                    if (tb_cst.Text == "51")
                                    {
                                        trib.CST = "51";
                                        try
                                        {
                                            trib.pICMS = Convert.ToDouble(tb_icms_item.Text);
                                        }
                                        catch { }
                                        try
                                        {
                                            trib.pRedBC = Convert.ToDouble(tb_reducao_item.Text);
                                        }
                                        catch { }
                                        trib.cst51();

                                    }
                                    if (tb_cst.Text == "60")//ST COBRADA ANTERIORMENTE
                                    {
                                        trib.CST = "60";
                                        trib.pICMS = 0;
                                        trib.pICMSST = 0;
                                        trib.vBC = 0;
                                        trib.cst60();
                                    }
                                    if (tb_cst.Text == "70")//SUBST. TRIBUTARIA
                                    {
                                        trib.CST = "70";
                                        trib.pICMS = tb_icms_item.Text != "" ? Convert.ToDouble(tb_icms_item.Text) : 0;
                                        trib.pICMSST = tb_icms_st.Text != "" ? Convert.ToDouble(tb_icms_st.Text) : 0;
                                        trib.pMVAST = tb_iva_item.Text != "" ? Convert.ToDouble(tb_iva_item.Text) : 0;
                                        trib.pRedBC = tb_reducao_item.Text != "" ? Convert.ToDouble(tb_reducao_item.Text) : 0;
                                        trib.pRedBCST = tb_reducao_st_item.Text != "" ? Convert.ToDouble(tb_reducao_st_item.Text) : 0;
                                        trib.modBCST = tb_mod_bc_st_item.Text[0].ToString();
                                        trib.cst70();
                                        
                                    }
                                    if (tb_cst.Text == "90")
                                    {
                                        trib.CST = "90";
                                        try
                                        {
                                            trib.pICMS = Convert.ToDouble(tb_icms_item.Text);
                                        }
                                        catch
                                        {
                                            trib.pICMS = 0;
                                        }
                                        try
                                        {
                                            trib.pICMSST = Convert.ToDouble(tb_icms_st.Text);

                                        }
                                        catch
                                        {
                                            trib.pICMSST = 0;
                                        }
                                        
                                        trib.modBCST = tb_mod_bc_st_item.Text[0].ToString();
                                        if (trib.modBCST == "")
                                            trib.modBCST = "4";
                                        try
                                        {
                                            trib.pMVAST = Convert.ToDouble(tb_iva_item.Text);
                                        }
                                        catch
                                        {
                                            trib.pMVAST = 0;
                                        }
                                        try
                                        {
                                            trib.pRedBCST = Convert.ToDouble(tb_reducao_st_item.Text);
                                        }
                                        catch
                                        {
                                            trib.pRedBCST = 0;
                                        }
                                        try
                                        {
                                            trib.pRedBC = Convert.ToDouble(tb_reducao_item.Text);
                                        }
                                        catch
                                        {
                                            trib.pRedBC = 0;
                                        }

                                        trib.cst90();
                                    }

                                    //ICS CBS
                                    if (tb_cst_ibscbs.Text != "")
                                    {
                                        try
                                        {
                                            trib.cstIBSCBS = tb_cst_ibscbs.Text;
                                            trib.classificacaoIBSCBS = tb_classificacao_ibscbs.Text;
                                            //trib.BCIBS = calcular_bc_rt(tb_frete_item.Text, tb_desconto_item.Text,
                                            //    tb_outras_desp_item.Text, tb_seguro_item.Text, preco_total_ponto.Replace(".", ","), valor_ipi, trib.vICMS, trib.vPIS, trib.vCOFINS);
                                            trib.BCIBS = Math.Round(calcular_bc_rt(tb_frete_item.Text, tb_desconto_item.Text, tb_outras_desp_item.Text, tb_seguro_item.Text, preco_total_ponto.Replace(".", ","), valor_ipi, trib.vICMS, trib.vPIS, trib.vCOFINS), 2, MidpointRounding.AwayFromZero);
                                            trib.pIBS = Convert.ToDouble(tb_aliquota_ibs.Text);
                                            trib.pCBS = Convert.ToDouble(tb_aliquota_cbs.Text);
                                            trib.calcular_IBSCBS();
                                        }
                                        catch { }
                                    }
                                    //PIS

                                    if (tb_pis_item.Text != "" && tb_pis_item.Text != "0")
                                    {

                                        trib.cstPIS = tb_cst_pis.Text.Remove(2);
                                        trib.tipoPIS = tb_tipo_pis.Text;
                                        if (trib.cstPIS == "01" || trib.cstPIS == "02" || trib.cstPIS == "03")
                                        {
                                            trib.BCPIS = calcular_bc_pis_cofins(tb_frete_item.Text, tb_desconto_item.Text,
                                       tb_outras_desp_item.Text, tb_seguro_item.Text, preco_total_ponto.Replace(".", ","), valor_ipi, trib.vICMS);
                                            trib.pPIS = Convert.ToDouble(tb_pis_item.Text);
                                            trib.calcular_pis();
                                        }
                                    }
                                    else
                                    {
                                        trib.cstPIS = tb_cst_pis.Text.Remove(2);
                                        trib.tipoPIS = tb_tipo_pis.Text;
                                    }
                                    //COFINS
                                    if (tb_cofins_item.Text != "" && tb_cofins_item.Text != "0")
                                    {


                                        trib.cstCOFINS = tb_cst_cofins.Text.Remove(2);
                                        trib.tipoCOFINS = tb_tipo_cofins.Text;
                                        if (trib.cstCOFINS == "01" || trib.cstCOFINS == "02" || trib.cstCOFINS == "03")
                                        {
                                            trib.BCCOFINS = calcular_bc_pis_cofins(tb_frete_item.Text, tb_desconto_item.Text,
                                       tb_outras_desp_item.Text, tb_seguro_item.Text, preco_total_ponto.Replace(".", ","), valor_ipi, trib.vICMS);
                                            trib.pCOFINS = Convert.ToDouble(tb_cofins_item.Text);
                                            trib.calcular_cofins();
                                        }
                                    }
                                    else
                                    {
                                        trib.cstCOFINS = tb_cst_cofins.Text.Remove(2);
                                        trib.tipoCOFINS = tb_tipo_cofins.Text;
                                    }

                                }
                            }
                            else
                            {
                                trib.modBC = tb_mod_bc_item.Text[0].ToString();
                                trib.orig = tb_origem_peca.Text[0].ToString();
                                if (_crt == "1") //NÃO TRIBUTADA SIMPLES
                                {
                                    tb_cst.Text = "400"; //NÃO TRIBUTADA
                                    if (tb_mod_bc_item.Text == "")
                                        tb_mod_bc_item.Text = _modalidade;
                                    if (tb_origem_peca.Text == "")
                                        tb_origem_peca.Text = _origem;
                                    trib.CST = "400";
                                }
                                else //NÃO TRIBUTADA REGIME NORMAL
                                {

                                    if (tb_cst.Text == "41")
                                        trib.CST = "41";
                                    else
                                    {
                                        if (tb_cst.Text == "40")
                                            trib.CST = "40";
                                        else
                                        {
                                            if (tb_cst.Text == "50")
                                                trib.CST = "50";
                                            else
                                                trib.CST = "41";
                                        }
                                    }



                                }
                                trib.cstIPINaoTributado = tb_cst_ipi_n_tributado.Text.Remove(2);
                                trib.ipiNaoTributado = true;
                                trib.cstPIS = tb_cst_pis.Text.Remove(2);
                                trib.tipoPIS = tb_tipo_pis.Text;
                                trib.cstCOFINS = tb_cst_cofins.Text.Remove(2);
                                trib.tipoCOFINS = tb_tipo_cofins.Text;

                            }
                            //UPDATE NO BANCO
                            trib.inserir_informacoes_item(cod_item_nota.ToString(), tb_cfo_peca.Text);
                            dsItens_nota.Clear();
                            this.datItens_nota.SelectCommand.CommandText =
                                 "SELECT * FROM ITENS_NOTA WHERE COD_SISTEMA_NF_ITEM = '" + tb_cod_interno.Text + "' order by cod_itens_nota";
                              //  "SELECT * FROM ITENS_NOTA WHERE NF_ITEM = '" + tb_n_nf.Text + "' ORDER BY COD_ITENS_NOTA";
                            this.fbConnection1.Open();
                            this.datItens_nota.SelectCommand.Connection = fbConnection1;
                            this.datItens_nota.SelectCommand.ExecuteNonQuery();
                            datItens_nota.Fill(ITENS_NOTA);
                            this.fbConnection1.Close();
                        }
                        inserir_natureza();

                        HasTextBox(itemPanel);

                        calcular();
                        tb_descricao_peca.Focus();
                        Atualizar(false);
                    }
                    catch (Exception a)
                    {
                        MessageBox.Show(a.ToString());
                        fbConnection1.Close();
                    }
                }
                else
                {
                    MessageBox.Show("NFe já autorizada");
                }
            }
            else
            {
                MessageBox.Show("Item já inserido na nota fiscal!");
            }

        }

        private double calcular_bc_rt(string frete, string desconto,
          string outras_desp, string seguro, string preco_total_ponto, double valor_ipi, double valor_icms, double valor_pis, double valor_cofins)
        {
            double _frete = 0, _desconto = 0, _outras_desp = 0, _seguro = 0, _preco_total = 0, _valor_icms = 0, _valor_pis = 0, _valor_cofins = 0;
            try
            {
                _frete = Convert.ToDouble(frete);
            }
            catch { }
            try
            {
                _desconto = Convert.ToDouble(desconto);
            }
            catch { }
            try
            {
                _valor_icms = Convert.ToDouble(valor_icms);
            }
            catch { }
            try
            {
                _valor_pis = Convert.ToDouble(valor_pis);
            }
            catch { }
            try
            {
                _valor_cofins = Convert.ToDouble(valor_cofins);
            }
            catch { }
            try
            {
                _outras_desp = Convert.ToDouble(outras_desp);
            }
            catch { }
            try
            {
                _seguro = Convert.ToDouble(seguro);
            }
            catch { }
            try
            {
                _preco_total = Convert.ToDouble(preco_total_ponto);
            }
            catch { }
            return (_preco_total + _frete + _outras_desp + _seguro - _desconto + valor_ipi) - _valor_icms - _valor_pis - _valor_cofins;

        }
        private double buscarTotalTribPorItem(string ncm, bool ext)
        {
            OleDbConnection _olecon;
            OleDbCommand _oleCmd;
            String _Arquivo = @"c:/evolucao/Excel/ncm.xls";
            //     String _StringConexao = String.Format(@"provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0 Xml;HDR=YES;ReadOnly=False';", _Arquivo);
            String _StringConexao = String.Format("provider=Microsoft.ACE.OLEDB.12.0;data source='" + _Arquivo + "';Extended Properties=\"Excel 8.0;HDR=YES;IMEX=1;ReadOnly=False\"");
            String _Consulta;
            double porcTrib = 0;

            _olecon = new OleDbConnection(_StringConexao);
            _olecon.Open();

            _oleCmd = new OleDbCommand();
            _oleCmd.Connection = _olecon;
            _oleCmd.CommandType = CommandType.Text;

            _oleCmd.CommandText = "SELECT * FROM [ncm$] WHERE ncm = '" + ncm + "'";
            OleDbDataReader reader = _oleCmd.ExecuteReader();
            int i = 3;
            if (ext)
            {
                i = 4;
            }
            else
            {
                i = 3;
            }
            while (reader.Read())
            {
                porcTrib = Convert.ToDouble(reader.GetString(i).Replace(".", ","));
            }

            reader.Close();

            return porcTrib;
        }

        private string buscar_ultimo_produto_inserido()
        {
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    "SELECT first(1) COD_ITENS_NOTA FROM ITENS_NOTA WHERE NF_ITEM = '" + tb_n_nf.Text +
                    "' ORDER BY COD_ITENS_NOTA DESC";
                FbDataAdapter datSelect = new FbDataAdapter();
                DataSet dsSelect = new DataSet();
                datSelect.SelectCommand = select;
                datSelect.Fill(dsSelect);
                DataRow dr = dsSelect.Tables[0].Rows[0];
                fbConnection1.Close();
                if (dsSelect.Tables[0].Rows.Count > 0)
                    return dr[0].ToString();
                else
                {
                    MessageBox.Show("Não encontrado ultimo registro");
                    return "NÃO ENCONTRADO";
                }
            }
            catch
            {
                fbConnection1.Close();
                MessageBox.Show("Erro ao buscar ultimo item");
                return "ERRO";

            }
        }



        //        private void buscar_informacoes_produto(string cod_peca, out string _origem, out string _cst,
        //    out string _modalidade, out string _icms, out string _icms_st, out string _reducao, out string _reducao_st,
        //    out string _iva, out string _ipi, out string _pis, out string _cofins, out string _iss,
        //    out string _crt, out string _aliquota_credito, out string _modalidade_st, out string _bc_com_ipi,
        //    out string _ipi_tributado, out string _ipi_n_tributado, out string _cst_ipi_tributado,
        //    out string _cst_ipi_n_tributado, out string _tipo_pis, out string _cst_pis, out string _tipo_cofins,
        //    out string _cst_cofins, out string _pCredICMS, out string _preco_minimo, out string _custo)
        //{
        //    _cst =  ""; _origem =  ""; _modalidade =  ""; _icms =  ""; _icms_st =  ""; _reducao =  ""; _reducao_st =  ""; _iva =  ""; _ipi =  "";
        //    _pis =  ""; _cofins =  ""; _iss =  ""; _crt =  ""; _aliquota_credito =  ""; _modalidade_st =  ""; _bc_com_ipi =  "";
        //    _ipi_tributado =  ""; _ipi_n_tributado =  ""; _cst_ipi_tributado =  ""; _cst_ipi_n_tributado =  "";
        //    _tipo_pis =  ""; _cst_pis =  ""; _tipo_cofins =  ""; _cst_cofins =  ""; _pCredICMS =  ""; _preco_minimo =  ""; _custo =  "";
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
        //            "SELECT * FROM PRODUTOS WHERE COD_PRODUTO = '" + cod_peca + "'"; //COD_FORNECEDOR_PRODUTO = '" + cod_peca + "'";
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
        //                if (dr["ORIGEM_PRODUTO"].ToString() != "")
        //                    _origem = dr["ORIGEM_PRODUTO"].ToString();
        //            }
        //            catch { }

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
        //            string ie =  "";
        //            if (!pessoa_fisica(tb_cnpj_cliente.Text, out ie))
        //            {
        //                if (tb_estado_cliente.Text == estadolabel.Text)
        //                {
        //                    _cst = dr["ST_SAIDA_PRODUTO"].ToString();
        //                    _icms = dr["ALIQUOTA_ICMS_PRODUTO"].ToString();
        //                    string _icms_cliente =  "";
        //                    if (verificar_icms_cliente(out _icms_cliente))
        //                    {
        //                        _icms = _icms_cliente;
        //                    }
        //                    _icms_st = dr["ALIQUOTA_ICMS_ST_PRODUTO"].ToString();
        //                    _reducao = dr["REDUCAO_ICMS_PRODUTO"].ToString();
        //                    _reducao_st = dr["REDUCAO_ST_PRODUTO"].ToString();
        //                    _iva = dr["IVA_PRODUTO"].ToString();

        //                    if (_icms_cliente == "12" && _cst == "00") //retirei no dia 03/08/2021 pq estava dando erro no Transdoni
        //                    {
        //                        _cst = "20";
        //                        _icms = "18";
        //                        _reducao = "33,33";
        //                    }
        //                    if (ie.ToUpper() == "ISENTO" && _cst == "101")
        //                    {
        //                        _cst = "102";
        //                    }

        //                }
        //                else  //FORA DO ESTADO
        //                {
        //                    _cst = dr["ST_SAIDA_FORA_PRODUTO"].ToString();
        //                    _icms = dr["ALIQUOTA_FORA_ICMS_PRODUTO"].ToString();
        //                    string _icms_cliente =  "";
        //                    if (verificar_icms_cliente(out _icms_cliente))
        //                    {
        //                        _icms = _icms_cliente;
        //                    }
        //                    _icms_st = dr["ALIQUOTA_ICMS_ST_FORA_PRODUTO"].ToString();
        //                    _reducao = dr["REDUCAO_FORA_PRODUTO"].ToString();
        //                    _reducao_st = dr["REDUCAO_ST_FORA_PRODUTO"].ToString();
        //                    _iva = dr["IVA_FORA_PRODUTO"].ToString();
        //                    if (_icms_cliente == "12" && _cst == "00")
        //                    {
        //                        _cst = "20";
        //                        _icms = "12";
        //                        _reducao = "33,33";
        //                    }
        //                    if (ie.ToUpper() == "ISENTO" && _cst == "101")
        //                    {
        //                        _cst = "102";
        //                    }
        //                }
        //            }
        //            else
        //            {
        //                //_cst = "00";
        //                _cst = dr["ST_SAIDA_PRODUTO"].ToString();
        //                if (_cst != "60" && _cst != "500" && _cst != "101")
        //                {
        //                    _cst = "00";
        //                    _icms = dr["ALIQUOTA_ICMS_PRODUTO"].ToString();
        //                }
        //                if (_cst == "101")
        //                    _cst = "102";

        //            }
        //            try
        //            {
        //                string pis_cofins = dr["PIS_COFINS_PRODUTO"].ToString();

        //                if(pis_cofins == "1")
        //                {
        //                    _cst_cofins = dr["CST_COFINS_PRODUTO"].ToString();
        //                    _cst_pis = dr["CST_PIS_PRODUTO"].ToString();
        //                    _tipo_cofins = dr["TIPO_COFINS_PRODUTO"].ToString();
        //                    _tipo_pis = dr["TIPO_PIS_PRODUTO"].ToString();
        //                    try
        //                    {
        //                        double pis = Convert.ToDouble(dr["ALIQUOTA_PIS_PRODUTO"].ToString());
        //                        _pis = dr["ALIQUOTA_PIS_PRODUTO"].ToString();
        //                        _cofins = dr["ALIQUOTA_COFINS_PRODUTO"].ToString();
        //                    }
        //                    catch { }
        //                }

        //                if (dr["CST_COFINS_PRODUTO"].ToString() != "")
        //                {
        //                    _cst_cofins = dr["CST_COFINS_PRODUTO"].ToString();
        //                    _cst_pis = dr["CST_PIS_PRODUTO"].ToString();
        //                    _tipo_cofins = dr["TIPO_COFINS_PRODUTO"].ToString();
        //                    _tipo_pis = dr["TIPO_PIS_PRODUTO"].ToString();
        //                }
        //                else
        //                {


        //                    if (pis_cofins == "0" || pis_cofins == "")
        //                    {
        //                        _cst_cofins = "06-";
        //                        _cst_pis = "06-";
        //                        _pis =  "";
        //                        _cofins =  "";
        //                    }
        //                }

        //                if(dr["ORIGEM_PRODUTO"].ToString() != "")
        //                {
        //                    tb_origem_peca.Text = dr["ORIGEM_PRODUTO"].ToString();
        //                }
        //            }
        //            catch { }
        //            //if (_cst_cofins == "")
        //            //{
        //            //    string pis_cofins = dr["PIS_COFINS_PRODUTO"].ToString();

        //            //    if (pis_cofins == "0" || pis_cofins == "")
        //            //    {
        //            //        _cst_cofins = "06-";
        //            //        _cst_pis = "06-";
        //            //        _pis =  "";
        //            //        _cofins =  "";
        //            //    }
        //            //}


        //        }

        //    }
        //    catch (Exception a)
        //    {
        //        fbConnection1.Close();
        //        MessageBox.Show(a.ToString());
        //    }
        //}
        private void buscar_informacoes_produto(string cod_peca, out string _origem, out string _cst,
     out string _modalidade, out string _icms, out string _icms_st, out string _reducao, out string _reducao_st,
     out string _iva, out string _ipi, out string _pis, out string _cofins, out string _iss,
     out string _crt, out string _aliquota_credito, out string _modalidade_st, out string _bc_com_ipi,
     out string _ipi_tributado, out string _ipi_n_tributado, out string _cst_ipi_tributado,
     out string _cst_ipi_n_tributado, out string _tipo_pis, out string _cst_pis, out string _tipo_cofins,
     out string _cst_cofins, out string _pCredICMS, out string _preco_minimo, out string _custo,
     out string cfop_produto, out string cest_produto, string tipo, string estado, string ncm,
     out string _cst_ibscbs, out string _classificacao_ibscbs, out string _aliquota_ibs, out string _aliquota_cbs)
        {
            _cst = ""; _origem = ""; _modalidade = ""; _icms = ""; _icms_st = ""; _reducao = ""; _reducao_st = ""; _iva = ""; _ipi = "";
            _pis = ""; _cofins = ""; _iss = ""; _crt = ""; _aliquota_credito = ""; _modalidade_st = ""; _bc_com_ipi = "";
            _ipi_tributado = ""; _ipi_n_tributado = ""; _cst_ipi_tributado = ""; _cst_ipi_n_tributado = "";
            _tipo_pis = ""; _cst_pis = ""; _tipo_cofins = ""; _cst_cofins = ""; _pCredICMS = ""; _preco_minimo = ""; _custo = "";
            cfop_produto = ""; cest_produto = "";

            _cst_ibscbs = ""; _classificacao_ibscbs = ""; _aliquota_ibs = ""; _aliquota_cbs = "";
            try
            {
                buscar_informacoes_padrao(out _origem, out _cst, out _modalidade, out _icms,
                           out _icms_st, out _reducao, out _reducao_st, out _iva, out _ipi, out _pis, out _cofins,
                           out _iss, out _crt, out _aliquota_credito, out _modalidade_st, out _bc_com_ipi,
                           out _ipi_tributado, out _ipi_n_tributado, out _cst_ipi_tributado,
                           out _cst_ipi_n_tributado, out _tipo_pis, out _cst_pis, out _tipo_cofins, out _cst_cofins, out _pCredICMS,
                           out _cst_ibscbs, out _classificacao_ibscbs, out _aliquota_ibs, out _aliquota_cbs);

                bool ncm_encontrado = false;
                string tipo_cliente = tipo;
                if (tipo == "Atacadista")
                    tipo = "Revenda";
                //string cnpjLimpo = Regex.Replace(cnpj_empresa, @"[^\d]", "");
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
                            try
                            {
                                if (dr_ncm["CST_IBSCBS"].ToString() != "")
                                {
                                    _cst_ibscbs = dr_ncm["CST_IBSCBS"].ToString();
                                    _classificacao_ibscbs = dr_ncm["CCLASSTRIB"].ToString();
                                    _aliquota_ibs = dr_ncm["ALIQ_IBS"].ToString();
                                    _aliquota_cbs = dr_ncm["ALIQ_CBS"].ToString();
                                }
                            }
                            catch { }
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
        //  private void buscar_informacoes_produto_old2(string cod_peca, out string _origem, out string _cst,
        //out string _modalidade, out string _icms, out string _icms_st, out string _reducao, out string _reducao_st,
        //out string _iva, out string _ipi, out string _pis, out string _cofins, out string _iss,
        //out string _crt, out string _aliquota_credito, out string _modalidade_st, out string _bc_com_ipi,
        //out string _ipi_tributado, out string _ipi_n_tributado, out string _cst_ipi_tributado,
        //out string _cst_ipi_n_tributado, out string _tipo_pis, out string _cst_pis, out string _tipo_cofins,
        //out string _cst_cofins, out string _pCredICMS, out string _preco_minimo, out string _custo,
        //out string cfop_produto, out string cest_produto, string tipo, string estado, string ncm)
        //  {
        //      _cst = ""; _origem = ""; _modalidade = ""; _icms = ""; _icms_st = ""; _reducao = ""; _reducao_st = ""; _iva = ""; _ipi = "";
        //      _pis = ""; _cofins = ""; _iss = ""; _crt = ""; _aliquota_credito = ""; _modalidade_st = ""; _bc_com_ipi = "";
        //      _ipi_tributado = ""; _ipi_n_tributado = ""; _cst_ipi_tributado = ""; _cst_ipi_n_tributado = "";
        //      _tipo_pis = ""; _cst_pis = ""; _tipo_cofins = ""; _cst_cofins = ""; _pCredICMS = ""; _preco_minimo = ""; _custo = "";
        //      cfop_produto = ""; cest_produto = "";
        //      try
        //      {
        //          buscar_informacoes_padrao(out _origem, out _cst, out _modalidade, out _icms,
        //                     out _icms_st, out _reducao, out _reducao_st, out _iva, out _ipi, out _pis, out _cofins,
        //                     out _iss, out _crt, out _aliquota_credito, out _modalidade_st, out _bc_com_ipi,
        //                     out _ipi_tributado, out _ipi_n_tributado, out _cst_ipi_tributado,
        //                     out _cst_ipi_n_tributado, out _tipo_pis, out _cst_pis, out _tipo_cofins, out _cst_cofins, out _pCredICMS);

        //          bool ncm_encontrado = false;
        //          string tipo_cliente = tipo;
        //          if (tipo == "Atacadista")
        //              tipo = "Revenda";
        //          //string cnpjLimpo = Regex.Replace(cnpj_empresa, @"[^\d]", "");
        //          foreach (DataRow dr_ncm in dtNcm_cst.Select("Convert(NCM, 'System.String') like '%" + ncm + "%' AND ESTADO like '" +
        //              estado + "' AND Tipo like '" + tipo + "' AND Convert(CNPJ, 'System.String') = '" + cnpj_empresa + "'"))
        //          {
        //              if (dr_ncm["CST_ICMS"].ToString() == "")
        //                  break;
        //              else
        //              {
        //                  try
        //                  {
        //                      /* icms */
        //                      ncm_encontrado = true;


        //                      cfop_produto = dr_ncm["CFOP"].ToString();
        //                      _cst = dr_ncm["CST_ICMS"].ToString();

        //                      _icms = dr_ncm["ICMS"].ToString();
        //                      _icms_st = dr_ncm["ICMS_ST"].ToString();

        //                      _reducao = dr_ncm["REDUÇÃO"].ToString();
        //                      _reducao_st = dr_ncm["REDUÇÃO_ST"].ToString();
        //                      _iva = dr_ncm["MVA"].ToString();

        //                      /* pis cofins */
        //                      _pis = "0,00"; _cofins = "0,00";
        //                      _ipi = "0,00";
        //                      try
        //                      {
        //                          try
        //                          {
        //                              _ipi = Convert.ToDouble(dr_ncm["IPI"].ToString()).ToString();
        //                          }
        //                          catch { };
        //                          if (dr_ncm["CST_IPI"].ToString().Substring(0, 2) != "50")
        //                          {
        //                              _cst_ipi_n_tributado = dr_ncm["CST_IPI"].ToString();
        //                              _ipi_tributado = "0";
        //                              _ipi_n_tributado = "1";
        //                          }
        //                          else
        //                          {
        //                              _cst_ipi_tributado = dr_ncm["CST_IPI"].ToString();
        //                              _ipi_tributado = "1";
        //                              _ipi_n_tributado = "0";
        //                          }
        //                      }
        //                      catch
        //                      {
        //                          _cst_ipi_n_tributado = "53";
        //                          _ipi_tributado = "0";
        //                          _ipi_n_tributado = "1";
        //                      }
        //                      try
        //                      {
        //                          _pis = Convert.ToDouble(dr_ncm["PIS"].ToString()).ToString();
        //                          _cofins = Convert.ToDouble(dr_ncm["COFINS"].ToString()).ToString();


        //                      }
        //                      catch { }

        //                      if (dr_ncm["CST_COFINS"].ToString() != "")
        //                      {
        //                          _cst_cofins = dr_ncm["CST_COFINS"].ToString();
        //                      }
        //                      if (dr_ncm["CST_PIS"].ToString() != "")
        //                      {
        //                          _cst_pis = dr_ncm["CST_PIS"].ToString();
        //                      }
        //                      if (dr_ncm["TIPO_COFINS"].ToString() != "")
        //                      {
        //                          _tipo_cofins = dr_ncm["TIPO_COFINS"].ToString();
        //                      }
        //                      if (dr_ncm["TIPO_PIS"].ToString() != "")
        //                      {
        //                          _tipo_pis = dr_ncm["TIPO_PIS"].ToString();
        //                      }
        //                  }
        //                  catch { }
        //              }
        //          }
        //      }
        //      catch (Exception a)
        //      {
        //          fbConnection1.Close();
        //          MessageBox.Show(a.ToString());
        //      }
        //  }
        //private void buscar_informacoes_produto_old(string cod_peca, out string _origem, out string _cst,
        //    out string _modalidade, out string _icms, out string _icms_st, out string _reducao, out string _reducao_st,
        //    out string _iva, out string _ipi, out string _pis, out string _cofins, out string _iss,
        //    out string _crt, out string _aliquota_credito, out string _modalidade_st, out string _bc_com_ipi,
        //    out string _ipi_tributado, out string _ipi_n_tributado, out string _cst_ipi_tributado,
        //    out string _cst_ipi_n_tributado, out string _tipo_pis, out string _cst_pis, out string _tipo_cofins,
        //    out string _cst_cofins, out string _pCredICMS, out string _preco_minimo, out string _custo, out string cfop_produto, out string cest_produto, string tipo)
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

        //            string tipo_cliente = buscar_tipo_pedido(dgvPedidos.Rows[0].Cells["col_pedido"].Value.ToString());// buscar_tipo_cliente(tb_cnpj_cliente.Text);

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
        //                    if (tb_estado_cliente.Text != estadolabel.Text)
        //                        cfop_produto = "6124";
        //                    if (crt_empresa == "1")
        //                        _cst = "101";
        //                    else
        //                    { //QUANDO É INDUSTRIALIZAÇÃO
        //                        _cst = "51";
        //                        foreach (DataRow dr_ncm in dtNcm_cst.Select("TIPO = '" + tipo + "' AND NCM = '" + dr["NCM_PRODUTO"].ToString() + "' AND ESTADO = '" + tb_estado_cliente.Text + "' AND (CFOP = '5124' OR CFOP = '6124')"))
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
        //                    if (tb_estado_cliente.Text != estadolabel.Text)
        //                        cfop_produto = "6101";
        //                    if (crt_empresa == "1")
        //                        _cst = "102";
        //                    else
        //                        _cst = "00";
        //                }
        //                else if (tipo_cliente == "Vendas")
        //                {
        //                    foreach (DataRow dr_ncm in dtNcm_cst.Select("NCM = '" + dr["NCM_PRODUTO"].ToString() + "' AND ESTADO = '" + 
        //                        tb_estado_cliente.Text + "' AND (CFOP = '5101' OR CFOP = '5401' OR CFOP = '6101' OR CFOP = '6401')"))
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
        //                                    if (dr_ncm["CST_IPI"].ToString().Substring(0,2) != "50")
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
        //                    if (!razao_social_empresa.ToUpper().Contains("SILMAR"))
        //                    {
        //                        //MessageBox.Show("NCM do produto " + dr["COD_FORNECEDOR_PRODUTO"].ToString() + " - " +  dr["DESCRICAO_PRODUTO"].ToString() + " não encontrado, por favor verifica antes de faturar");
        //                        if (!pessoa_fisica(tb_cnpj_cliente.Text))
        //                        {
        //                            if (tb_estado_cliente.Text == estadolabel.Text)
        //                            {
        //                                _cst = dr["ST_SAIDA_PRODUTO"].ToString();
        //                                _icms = dr["ALIQUOTA_ICMS_PRODUTO"].ToString();
        //                                string _icms_cliente = "";
        //                                if (verificar_icms_cliente(out _icms_cliente))
        //                                {
        //                                    _icms = _icms_cliente;
        //                                }
        //                                _icms_st = dr["ALIQUOTA_ICMS_ST_PRODUTO"].ToString();
        //                                _reducao = dr["REDUCAO_ICMS_PRODUTO"].ToString();
        //                                _reducao_st = dr["REDUCAO_ST_PRODUTO"].ToString();
        //                                _iva = dr["IVA_PRODUTO"].ToString();
        //                            }
        //                            else  //FORA DO ESTADO
        //                            {
        //                                _cst = dr["ST_SAIDA_FORA_PRODUTO"].ToString();
        //                                _icms = dr["ALIQUOTA_FORA_ICMS_PRODUTO"].ToString();
        //                                string _icms_cliente = "";
        //                                if (verificar_icms_cliente(out _icms_cliente))
        //                                {
        //                                    _icms = _icms_cliente;
        //                                }
        //                                _icms_st = dr["ALIQUOTA_ICMS_ST_FORA_PRODUTO"].ToString();
        //                                _reducao = dr["REDUCAO_FORA_PRODUTO"].ToString();
        //                                _reducao_st = dr["REDUCAO_ST_FORA_PRODUTO"].ToString();
        //                                _iva = dr["IVA_FORA_PRODUTO"].ToString();
        //                            }
        //                        }
        //                        else
        //                        {
        //                            //_cst = "00";
        //                            _cst = dr["ST_SAIDA_PRODUTO"].ToString();
        //                            if (_cst != "60" && _cst != "500" && _cst != "101")
        //                            {
        //                                _cst = "102";
        //                                _icms = dr["ALIQUOTA_ICMS_PRODUTO"].ToString();
        //                            }
        //                        }
        //                        if (tb_estado_cliente.Text == estadolabel.Text)
        //                        {
        //                            try
        //                            {
        //                                _pis = "0,00"; _cofins = "0,00";
        //                                _ipi = "0,00";
        //                                try
        //                                {
        //                                    _ipi = Convert.ToDouble(dr["ALIQUOTA_IPI_PRODUTO"].ToString()).ToString();
        //                                }
        //                                catch { }
        //                                try
        //                                {
        //                                    _pis = Convert.ToDouble(dr["ALIQUOTA_PIS_PRODUTO"].ToString()).ToString();
        //                                    _cofins = Convert.ToDouble(dr["ALIQUOTA_COFINS_PRODUTO"].ToString()).ToString();
        //                                }
        //                                catch { }


        //                                if (dr["CST_COFINS_PRODUTO"].ToString() != "")
        //                                {
        //                                    _cst_cofins = dr["CST_COFINS_PRODUTO"].ToString();
        //                                    _cst_pis = dr["CST_PIS_PRODUTO"].ToString();
        //                                    _tipo_cofins = dr["TIPO_COFINS_PRODUTO"].ToString();
        //                                    _tipo_pis = dr["TIPO_PIS_PRODUTO"].ToString();
        //                                }
        //                                else
        //                                {
        //                                    string pis_cofins = dr["PIS_COFINS_PRODUTO"].ToString();

        //                                    if (pis_cofins == "0" || pis_cofins == "")
        //                                    {
        //                                        _cst_cofins = "06-";
        //                                        _cst_pis = "06-";
        //                                        _pis = "";
        //                                        _cofins = "";
        //                                    }
        //                                }
        //                            }
        //                            catch { }
        //                        }
        //                        else
        //                        {
        //                            try
        //                            {
        //                                _pis = "0,00"; _cofins = "0,00";
        //                                _ipi = "0,00";
        //                                try
        //                                {
        //                                    _ipi = Convert.ToDouble(dr["ALIQUOTA_IPI_FORA_PRODUTO"].ToString()).ToString();
        //                                    if (Convert.ToDouble(_ipi) == 0)
        //                                        _cst_ipi_n_tributado = "51 - Saída tributada com alíquota zero";
        //                                    else
        //                                        _cst_ipi_n_tributado = "50 - Saída tributada";
        //                                }
        //                                catch
        //                                {
        //                                    _cst_ipi_n_tributado = "53 - Saída tributada";
        //                                    _ipi_n_tributado = "1";
        //                                }
        //                                try
        //                                {
        //                                    _pis = Convert.ToDouble(dr["ALIQUOTA_PIS_PRODUTO"].ToString()).ToString();
        //                                    _cofins = Convert.ToDouble(dr["ALIQUOTA_COFINS_PRODUTO"].ToString()).ToString();
        //                                }
        //                                catch { }


        //                                if (dr["CST_COFINS_PRODUTO"].ToString() != "")
        //                                {
        //                                    _cst_cofins = dr["CST_COFINS_PRODUTO"].ToString();
        //                                    _cst_pis = dr["CST_PIS_PRODUTO"].ToString();
        //                                    _tipo_cofins = dr["TIPO_COFINS_PRODUTO"].ToString();
        //                                    _tipo_pis = dr["TIPO_PIS_PRODUTO"].ToString();
        //                                }
        //                                else
        //                                {
        //                                    string pis_cofins = dr["PIS_COFINS_PRODUTO"].ToString();

        //                                    if (pis_cofins == "0" || pis_cofins == "")
        //                                    {
        //                                        _cst_cofins = "08-";
        //                                        _cst_pis = "08-";
        //                                        _pis = "";
        //                                        _cofins = "";
        //                                    }
        //                                }
        //                            }
        //                            catch { }
        //                        }
        //                    }
        //                    if (verificar_se_cliente_e_isento(tb_cnpj_cliente.Text))
        //                    {
        //                        if (tb_estado_cliente.Text != estadolabel.Text)
        //                        {
        //                            cfop_produto = "6101";
        //                            if (crt_empresa == "1")
        //                                _cst = "102";
        //                            else
        //                                _cst = "00";
        //                        }
        //                        else
        //                        {
        //                            cfop_produto = "5101";
        //                            if (crt_empresa == "1")
        //                                _cst = "102";
        //                            else
        //                                _cst = "00";

        //                            //if(
        //                            // _cst = "20";
        //                            //_icms_st = "0,00"; //pega icms do padrão da empresa;
        //                        }

        //                    }
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

        private string buscar_tipo_pedido(string cod)
        {
            try
            {

                FbCommand comando = new FbCommand();
                comando.Connection = fbConnection1;
                comando.CommandText =
                    "SELECT TIPO_PED_VENDA FROM PEDIDOS_VENDA WHERE COD_PED_VENDA = '" + cod + "'";
                fbConnection1.Open();
                //comando_select.Connection = fbConnection1;
                FbDataAdapter cli = new FbDataAdapter();
                cli.SelectCommand = comando;
                DataTable cliente = new  DataTable();
                cli.Fill(cliente);
                fbConnection1.Close();
                foreach(DataRow dr in cliente.Rows)
                {
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

        
        private bool pessoa_fisica(string cnpj, out string ie)
        {
            bool retorno = false;
            ie =  "";
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
                ie = dr["IE"].ToString();
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
                    "SELECT TIPO_CLIENTE, PESSOA_FISICA_CLIENTE FROM CLIENTES WHERE CNPJ = '" + cnpj +"'";
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
                    if(dr[0].ToString() != "")
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


        protected void HasTextBox(Control ctrl)
        {
            foreach (Control c in ctrl.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }

                if (c.HasChildren)
                {
                    HasTextBox(c);
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
                    HasTextBox(d);
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
                    HasTextBox(e);
                }
            }
        }



        private void LimpaCampos(Control controls)
        {
            foreach (Control ctrl in controls.Controls)
            {
                if (ctrl is System.Windows.Forms.TextBox)
                {
                    ((System.Windows.Forms.TextBox)(ctrl)).Text = string.Empty;
                }
                if (ctrl is System.Windows.Forms.CheckBox)
                {
                    ((System.Windows.Forms.CheckBox)(ctrl)).Checked = false;
                }
                if (ctrl is System.Windows.Forms.RadioButton)
                {
                    ((System.Windows.Forms.RadioButton)(ctrl)).Checked = false;
                }

            }
        }



        private double calcular_bc(string frete, string desconto,
            string outras_desp, string seguro, string preco_total_ponto, double valor_ipi)
        {
            double _frete = 0, _desconto = 0, _outras_desp = 0, _seguro = 0, _preco_total = 0;
            try
            {
                _frete = Convert.ToDouble(frete);
            }
            catch { }
            try
            {
                _desconto = Convert.ToDouble(desconto);
            }
            catch { }
            try
            {
                _outras_desp = Convert.ToDouble(outras_desp);
            }
            catch { }
            try
            {
                _seguro = Convert.ToDouble(seguro);
            }
            catch { }
            try
            {
                _preco_total = Convert.ToDouble(preco_total_ponto);
            }
            catch { }
            return _preco_total + _frete + _outras_desp + _seguro - _desconto + valor_ipi;

        }

        private double calcular_bc_pis_cofins(string frete, string desconto,
           string outras_desp, string seguro, string preco_total_ponto, double valor_ipi, double valor_icms)
        {
            double _frete = 0, _desconto = 0, _outras_desp = 0, _seguro = 0, _preco_total = 0;
            try
            {
                _frete = Convert.ToDouble(frete);
            }
            catch { }
            try
            {
                _desconto = Convert.ToDouble(desconto);
            }
            catch { }
            try
            {
                _outras_desp = Convert.ToDouble(outras_desp);
            }
            catch { }
            try
            {
                _seguro = Convert.ToDouble(seguro);
            }
            catch { }
            try
            {
                _preco_total = Convert.ToDouble(preco_total_ponto);
            }
            catch { }
            return _preco_total + _frete + _outras_desp + _seguro - _desconto + valor_ipi - valor_icms;

        }

        private void buscar_informacoes_padrao(out string _origem, out string _cst, out string _modalidade,
          out string _icms, out string _icms_st, out string _reducao, out string _reducao_st, out string _iva, out string _ipi,
          out string _pis, out string _cofins, out string _iss, out string _crt, out string _aliquota_credito,
          out string _modalidade_st, out string _bc_com_ipi,
          out string _ipi_tributado, out string _ipi_n_tributado,
          out string _cst_ipi_tributado, out string _cst_ipi_n_tributado, out string _tipo_pis, out string _cst_pis,
          out string _tipo_cofins, out string _cst_cofins, out string _pCredICMS,
          out string _cst_ibscbs, out string _classificacao_ibscbs, out string _aliquota_ibs, out string _aliquota_cbs)
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
            _cst_ibscbs = "";
            _classificacao_ibscbs = "";
            _aliquota_ibs = "";
            _aliquota_cbs = "";
            try
            {
                FbCommand comando = new FbCommand();
                comando.Connection = fbConnection1;
                comando.CommandText =
                   "SELECT * FROM EMPRESA where LICENCA_DLL_NFE_EMPRESA is not null AND CNPJ_EMPRESA = '" + cnpj_empresa + "' ";
                fbConnection1.Open();
                DataSet inf_padrao = new DataSet();
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
                    try
                    {
                        _cst_ibscbs = dr["CST_IBSCBS_EMPRESA"].ToString(); ;
                        _classificacao_ibscbs = dr["CCLASSTRIB_EMPRESA"].ToString(); ;
                        _aliquota_ibs = dr["ALIQ_IBS_EMPRESA"].ToString();
                        _aliquota_cbs = dr["ALIQ_CBS_EMPRESA"].ToString();
                    }
                    catch { }
                }
            }
            catch
            {
                fbConnection1.Close();
            }
        }
        //private void buscar_informacoes_padrao(out string _origem, out string _cst, out string _modalidade,
        //    out string _icms, out string _icms_st, out string _reducao, out string _reducao_st, out string _iva, out string _ipi,
        //    out string _pis, out string _cofins, out string _iss, out string _crt, out string _aliquota_credito,
        //    out string _modalidade_st, out string _bc_com_ipi,
        //    out string _ipi_tributado, out string _ipi_n_tributado,
        //    out string _cst_ipi_tributado, out string _cst_ipi_n_tributado, out string _tipo_pis, out string _cst_pis,
        //    out string _tipo_cofins, out string _cst_cofins, out string _pCredICMS)
        //{
        //    _origem = "";
        //    _cst = "";
        //    _modalidade = "";
        //    _icms = "";
        //    _icms_st = "";
        //    _reducao = "";
        //    _reducao_st = "";
        //    _iva = "";
        //    _ipi = "";
        //    _pis = "";
        //    _cofins = "";
        //    _iss = "";
        //    _crt = "";
        //    _aliquota_credito = "";
        //    _modalidade_st = "";
        //    _bc_com_ipi = "";
        //    _ipi_tributado = "";
        //    _ipi_n_tributado = "";
        //    _cst_ipi_tributado = "";
        //    _cst_ipi_n_tributado = "";
        //    _tipo_pis = "";
        //    _cst_pis = "";
        //    _tipo_cofins = "";
        //    _cst_cofins = "";
        //    _pCredICMS = "";
        //    try
        //    {
        //        FbCommand comando = new FbCommand();
        //        comando.Connection = fbConnection1;
        //        comando.CommandText =
        //           "SELECT * FROM EMPRESA where LICENCA_DLL_NFE_EMPRESA is not null AND CNPJ_EMPRESA = '" + cnpj_empresa + "' ";
        //        fbConnection1.Open();
        //        DataSet inf_padrao = new DataSet();
        //        datEmpresa.SelectCommand = comando;
        //        datEmpresa.Fill(inf_padrao);
        //        fbConnection1.Close();
        //        foreach (DataRow dr in inf_padrao.Tables[0].Rows)
        //        {
        //            _origem = dr["ORIGEM_EMPRESA"].ToString();
        //            _cst = dr["CST_EMPRESA"].ToString();
        //            _modalidade = dr["MOD_BC_EMPRESA"].ToString();
        //            _icms = dr["ICMS_EMPRESA"].ToString();
        //            _icms_st = dr["ICMS_ST_EMPRESA"].ToString();
        //            _reducao = dr["REDUCAO_EMPRESA"].ToString();
        //            _reducao_st = dr["REDUCAO_ST_EMPRESA"].ToString();
        //            _iva = dr["IVA_EMPRESA"].ToString();
        //            _ipi = dr["IPI_EMPRESA"].ToString();
        //            _pis = dr["PIS_EMPRESA"].ToString();
        //            _cofins = dr["COFINS_EMPRESA"].ToString();
        //            _iss = dr["ISS_EMPRESA"].ToString();
        //            _crt = dr["CRT_EMPRESA"].ToString();
        //            _aliquota_credito = dr["ALIQUOTA_CREDITO_EMPRESA"].ToString();
        //            _modalidade_st = dr["MOD_BC_ST_EMPRESA"].ToString();
        //            _bc_com_ipi = dr["BC_COM_IPI_EMPRESA"].ToString();
        //            _ipi_tributado = dr["IPI_TRIB_EMPRESA"].ToString();
        //            _ipi_n_tributado = dr["IPI_N_TRIB_EMPRESA"].ToString();
        //            _cst_ipi_tributado = dr["CST_IPI_TRIB_EMPRESA"].ToString();
        //            _cst_ipi_n_tributado = dr["CST_IPI_N_TRIB_EMPRESA"].ToString();
        //            _tipo_pis = dr["TIPO_PIS_EMPRESA"].ToString();
        //            _cst_pis = dr["CST_PIS_EMPRESA"].ToString();
        //            _tipo_cofins = dr["TIPO_COFINS_EMPRESA"].ToString();
        //            _cst_cofins = dr["CST_COFINS_EMPRESA"].ToString();
        //            _pCredICMS = dr["ALIQUOTA_CREDITO_EMPRESA"].ToString();
        //        }
        //    }
        //    catch
        //    {
        //        fbConnection1.Close();
        //    }
        //}
        private bool verificar_se_e_tributada(string n_cfo)
        {
            try
            {
                FbCommand comando = new FbCommand();
                comando.Connection = fbConnection1;
                comando.CommandText =
                    "SELECT TRIBUTADA_CFO FROM CFO WHERE N_CFO = '" + n_cfo + "'";
                fbConnection1.Open();
                DataSet cfo = new DataSet();
                datCfo.SelectCommand = comando;
                datCfo.Fill(cfo);
                fbConnection1.Close();
                if (cfo.Tables[0].Rows.Count > 1)
                {
                    MessageBox.Show("Existem 2 CFOPs com o mesmo código, verifique.");
                    return false;
                }
                else
                {
                    DataRow dr = cfo.Tables[0].Rows[0];
                    if (dr[0].ToString() == "1")
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }

            }
            catch (Exception a)
            {
                MessageBox.Show(abre_nf.ToString());
                fbConnection1.Close();
                return false;
            }

        }

        private void inserir_natureza()
        {
            FbCommand comando = new FbCommand();
            comando.Connection = fbConnection1;
            comando.CommandText =
                "SELECT * FROM CFO WHERE N_CFO = '" + tb_cfo_peca.Text + "'";
            DataSet cfo = new DataSet();
            fbConnection1.Open();
            datCfo.SelectCommand = comando;
            datCfo.Fill(cfo);
            string descricao = "";
            string observacao = "";
            foreach (DataRow dr in cfo.Tables[0].Rows)
            {
                descricao = dr["DESCRICAO_CFO"].ToString();
                observacao = dr["OBSERVACAO_CFO"].ToString();
            }

            this.fbConnection1.Close();
            if (tb_natureza_operacao.Text.Contains(descricao) == false)
            {
                if (tb_natureza_operacao.Text == "")
                    tb_natureza_operacao.Text = descricao;
                else
                    tb_natureza_operacao.Text = tb_natureza_operacao.Text + "/" + descricao;
            }

            if (tb_dados_adicionais.Text.Contains(observacao) == false)
            {

                if (tb_dados_adicionais.Text == "")
                    tb_dados_adicionais.Text = observacao;
                else
                    tb_dados_adicionais.Text = tb_dados_adicionais.Text + " / " + observacao;

            }
        }
        /*
        private string verificar_variavel_trib()
        {
            comando_select.CommandText = "SELECT * FROM EMPRESA";
            DataSet empresa = new DataSet();
            fbConnection1.Open();
            datTributacao.SelectCommand = comando_select;
            datTributacao.Fill(empresa);
            string _proprio = "", _cliente = "", _produto = "";
            foreach (DataRow dr in empresa.Tables[0].Rows)
            {

                _proprio = dr["TRIB_PROPRIA_EMPRESA"].ToString();
                _cliente = dr["TRIB_CLIENTE_EMPRESA"].ToString();
                _produto = dr["TRIB_PRODUTO_EMPRESA"].ToString();

            }
            fbConnection1.Close(); 

            if (_proprio == "1")
            {
                return "PROPRIA";
            }
            else
            {
                if (_cliente == "1")
                {
                    return "CLIENTE";
                }
                else
                {
                    if (_produto == "1")
                    {
                        return "PRODUTO";
                    }
                    else
                    {
                        MessageBox.Show("Você tem que escolher um tipo de tributação no cadastro da empresa");
                        return "ERRO";
                    }
                }
            }
        }

        private string verificar_cod_variavel_trib(string variavel, int linha_atual)
        {
            if (variavel == "PROPRIA")
            {
                return "1";
            }
            else
            {
                if (variavel == "CLIENTE")
                {
                    try
                    {
                        comando_select.CommandText = "SELECT COD_CLIENTE " +
                        "FROM CLIENTES WHERE CNPJ = '" + tb_cnpj_cliente.Text + "'";
                        DataSet cliente = new DataSet();
                        fbConnection1.Open();
                        datClientes.SelectCommand = comando_select;
                        datClientes.Fill(cliente);
                        string cliente_atual = "";
                        foreach (DataRow dr in cliente.Tables[0].Rows)
                        {

                            cliente_atual = dr["COD_CLIENTE"].ToString();
                        }

                        this.fbConnection1.Close(); 
                        return cliente_atual;
                    }
                    catch
                    {
                        fbConnection1.Close(); 
                        MessageBox.Show("Coloque um cliente válido");
                        return "0";
                    }
                }
                else
                {
                    if (variavel == "PRODUTO")
                    {
                        return dgvItens_nota.Rows[linha_atual].Cells["col_cod"].Value.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Você tem que escolher um tipo de tributação no cadastro da empresa");
                        return "0";
                    }
                }
            }
        }

        private void inserir_tributacao()
        {
            if (dgvItens_nota.Rows[dgvItens_nota.RowCount - 1].Cells["col_prestacao_servico"].Value.ToString() == "1")
            {
                form_tributacao trib = new form_tributacao();
                try
                {

                    double preco_unit = Convert.ToDouble(dgvItens_nota.Rows[dgvItens_nota.RowCount - 1].Cells["col_preco_unit"].Value.ToString());
                    double qtde = Convert.ToDouble(dgvItens_nota.Rows[dgvItens_nota.RowCount - 1].Cells["col_qtde"].Value.ToString());
                    double preco_total = preco_unit * qtde;
                    trib.valor_total_prod = preco_total.ToString("n2");
                    trib.item_selecionado = dgvItens_nota.Rows[dgvItens_nota.RowCount - 1].Cells["col_cod"].Value.ToString();
                    trib.inserir_nova = true;
                    trib.prestacao_servico = true;
                    
                    trib.ShowDialog();

                }
                finally
                {
                    try
                    {
                        dgvItens_nota.Rows[dgvItens_nota.RowCount - 1].Cells["col_valor_iss"].Value = trib.valor_iss_item_2;
                    }
                    catch { }
                    string _st = "", _valor_bc_st = "", _valor_st = ""; 
                    comando_select.CommandText = "SELECT * FROM TRIBUTACAO WHERE COD_NF_TRIB = '" + trib.item_selecionado + "'";
                    DataSet _trib = new DataSet();
                    fbConnection1.Open();
                    datTributacao.SelectCommand = comando_select;
                    datTributacao.Fill(_trib);
                    int n = 0;
                    foreach (DataRow dr in _trib.Tables[0].Rows)
                    {

                        _st = dr["ICMS_TRI_ICM"].ToString();
                        _valor_bc_st = dr["ICMS_ST_VAL_BC_ICM"].ToString();
                        _valor_st = dr["ICMS_ST_VAL_ICM"].ToString();

                    }
                    fbConnection1.Close(); 
                    try
                    {
                        dgvItens_nota.Rows[dgvItens_nota.RowCount - 1].Cells["col_st"].Value = _st;
                        dgvItens_nota.Rows[dgvItens_nota.RowCount - 1].Cells["col_valor_bc_st"].Value = _valor_bc_st;

                        dgvItens_nota.Rows[dgvItens_nota.RowCount - 1].Cells["col_valor_st"].Value = _valor_st;
                    }
                    catch { }
                    Atualizar(false);
                    //dsItens_nota.Clear();
                    //datItens_nota.Fill(ITENS_NOTA);
                    trib.Dispose();
                   
                }
            }
            else
            {
                form_tributacao trib = new form_tributacao();
                try
                {
                    double preco_unit = Convert.ToDouble(dgvItens_nota.Rows[dgvItens_nota.RowCount - 1].Cells["col_preco_unit"].Value.ToString());
                    double qtde = Convert.ToDouble(dgvItens_nota.Rows[dgvItens_nota.RowCount - 1].Cells["col_qtde"].Value.ToString());
                    double preco_total = preco_unit * qtde;
                    int linha_atual = dgvItens_nota.RowCount - 1;
                    
                    //trib.Opacity = 0;
                    trib.variavel_trib = verificar_variavel_trib();
                    trib.cod_variavel_trib = verificar_cod_variavel_trib(verificar_variavel_trib(), linha_atual);
                    trib.valor_total_prod = preco_total.ToString("n2");
                    trib.item_selecionado = dgvItens_nota.Rows[dgvItens_nota.RowCount - 1].Cells["col_cod"].Value.ToString();
                    trib.inserir_nova = true;
                   
                    trib.ShowDialog();

                }
                finally
                {
                    try
                    {
                        string valor_ic = trib.valor_icm_item_2;
                        dgvItens_nota.Rows[dgvItens_nota.RowCount - 1].Cells["col_valor_icm"].Value = valor_ic;
                    }
                    catch
                    {
                        dgvItens_nota.Rows[dgvItens_nota.RowCount - 1].Cells["col_valor_icm"].Value = "0";
                    }
                    try
                    {
                        dgvItens_nota.Rows[dgvItens_nota.RowCount - 1].Cells["col_ipi"].Value = trib.ipi_item_2;
                    }
                    catch
                    {
                        dgvItens_nota.Rows[dgvItens_nota.RowCount - 1].Cells["col_ipi"].Value = "0";
                    }
                    try
                    {
                        dgvItens_nota.Rows[dgvItens_nota.RowCount - 1].Cells["col_icms"].Value = trib.icm_item_2;
                    }
                    catch
                    {
                        dgvItens_nota.Rows[dgvItens_nota.RowCount - 1].Cells["col_icms"].Value = "0";
                    }
                    try
                    {
                        dgvItens_nota.Rows[dgvItens_nota.RowCount - 1].Cells["col_valor_bc"].Value = trib.valor_bc_item_2;
                    }
                    catch
                    {
                        dgvItens_nota.Rows[dgvItens_nota.RowCount - 1].Cells["col_valor_bc"].Value = "0";
                    }
                    string _st = "", _valor_bc_st = "", _valor_st = "", _valor_ipi = "" ;
                    comando_select.CommandText = "SELECT * FROM TRIBUTACAO WHERE COD_NF_TRIB = '" + trib.item_selecionado + "'";
                    DataSet _trib = new DataSet();
                    fbConnection1.Open();
                    datTributacao.SelectCommand = comando_select;
                    datTributacao.Fill(_trib);
                    int n = 0;
                    foreach (DataRow dr in _trib.Tables[0].Rows)
                    {

                        _st = dr["ICMS_TRI_ICM"].ToString();
                        _valor_bc_st = dr["ICMS_ST_VAL_BC_ICM"].ToString();
                        _valor_st = dr["ICMS_ST_VAL_ICM"].ToString();
                        _valor_ipi = dr["IPI_VAL_IPI"].ToString();

                    }
                    fbConnection1.Close(); 
                    try
                    {
                        dgvItens_nota.Rows[dgvItens_nota.RowCount - 1].Cells["col_st"].Value = _st;
                    }
                    catch { }
                    try
                    {
                        if (_valor_bc_st != "")
                        {
                            dgvItens_nota.Rows[dgvItens_nota.RowCount - 1].Cells["col_valor_bc_st"].Value = _valor_bc_st;
                        }
                    }
                    catch { }
                    try
                    {
                        if (_valor_st != "")
                        {
                            dgvItens_nota.Rows[dgvItens_nota.RowCount - 1].Cells["col_valor_st"].Value = _valor_st;
                        }
                        
                    }
                    catch { }
                    try
                    {
                        if (_valor_ipi != "")
                        {
                            dgvItens_nota.Rows[dgvItens_nota.RowCount - 1].Cells["col_valor_ipi"].Value = _valor_ipi;
                        }

                    }
                    catch { }
                    
                    Atualizar(false);
                    //dsItens_nota.Clear();
                    //datItens_nota.Fill(ITENS_NOTA);
                    trib.Dispose();
                }
            }
                    
        }
         * */
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (tb_protocolo_autorizacao.Text == "")
            {
                if (DialogResult.Yes == MessageBox.Show("O registro será excluído permanentemente, tem certeza?",
                   "Confirma a exclusão?", MessageBoxButtons.YesNo))
                {
                    try
                    {

                        this.datPedidos_nf.DeleteCommand.CommandText =
                          "DELETE FROM PEDIDOS_NF WHERE COD_SISTEMA_PEDIDO_NF = '" + tb_cod_interno.Text + "'";
                        this.fbConnection1.Open();
                        this.datPedidos_nf.DeleteCommand.Connection = fbConnection1;
                        this.datPedidos_nf.DeleteCommand.ExecuteNonQuery();
                        this.fbConnection1.Close();

                        this.datFatura_nf.DeleteCommand.CommandText =
                           "DELETE FROM FATURA_NF WHERE COD_SISTEMA_NF_FATURA = '" + tb_cod_interno.Text + "'";
                        this.fbConnection1.Open();
                        this.datFatura_nf.DeleteCommand.Connection = fbConnection1;
                        this.datFatura_nf.DeleteCommand.ExecuteNonQuery();
                        this.fbConnection1.Close();

                        this.datItens_nota.DeleteCommand.CommandText =
                            "DELETE FROM ITENS_NOTA WHERE COD_SISTEMA_NF_ITEM = '" + tb_cod_interno.Text + "'";
                        this.fbConnection1.Open();
                        this.datItens_nota.DeleteCommand.Connection = fbConnection1;
                        this.datItens_nota.DeleteCommand.ExecuteNonQuery();
                        this.fbConnection1.Close();

                        this.datNota_fiscal.DeleteCommand.CommandText =
                            "DELETE FROM NOTA_FISCAL WHERE COD_SISTEMA_NF = '" + tb_cod_interno.Text + "'";
                        this.fbConnection1.Open();
                        this.datNota_fiscal.DeleteCommand.Connection = fbConnection1;
                        this.datNota_fiscal.DeleteCommand.ExecuteNonQuery();
                        this.fbConnection1.Close();


                        dsNota_fiscal.Clear();
                        dsItens_nota.Clear();
                        dsFatura_nf.Clear();

                        abre_nova();
                    }
                    catch (Exception a)
                    {
                        fbConnection1.Close();
                        MessageBox.Show(a.ToString());
                    }
                }
            }
            else
            {
                MessageBox.Show("Impossível excluir, NFe já foi autorizada");

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            calcular();
        }

        private void calcular()
        {
            double valor_produtos = 0, ipi_total, icm_total = 0, valor_total = 0, valor_ipi_total = 0, valor_icm_total = 0,
                valor_bc_total = 0, valor_iss_total = 0, base_calculo_iss_total = 0, valor_bc_st_total = 0, valor_st_total = 0,
                valor_frete = 0, valor_desconto = 0, valor_outras_desp = 0, valor_seguro = 0, valor_simples = 0, totalTribNota = 0, qtde_volume = 0;


            for (int i = 0; i <= dgvItens_nota.RowCount - 1 && !importar_xml; i++)
            {
                if (verificar_se_e_tributada(dgvItens_nota.Rows[i].Cells["col_cfo"].Value.ToString()))
                {
                    try
                    {
                        double porcTotTrib = Convert.ToDouble(dgvItens_nota.Rows[i].Cells["col_porc_trib"].Value.ToString());
                        double preco_total = Convert.ToDouble(dgvItens_nota.Rows[i].Cells["col_preco_total"].Value.ToString());
                        double vTotalTribItem = (preco_total * porcTotTrib) / 100;
                        dgvItens_nota.Rows[i].Cells["col_tot_trib"].Value = Convert.ToDouble(transforma_decimal(2, vTotalTribItem.ToString(), 15).Replace(".", ",")).ToString();

                    }
                    catch
                    {
                        dgvItens_nota.Rows[i].Cells["col_tot_trib"].Value = "0";
                    }

                }
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
                    qtde_volume = qtde_volume + Convert.ToDouble(dgvItens_nota.Rows[i].Cells["col_qtde"].Value.ToString());
                    //-----------------------------------------------------------------------------------------//
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
                    //----------------------------------------------------------------------------------------//


                    try
                    {
                        valor_icm_total = valor_icm_total + (Convert.ToDouble(Convert.ToDouble(dgvItens_nota.Rows[i].Cells["col_valor_icm"].Value.ToString()).ToString("n2")));
                    }
                    catch { }
                    try
                    {
                        valor_ipi_total = valor_ipi_total + (Convert.ToDouble(dgvItens_nota.Rows[i].Cells["col_valor_ipi"].Value.ToString()));
                    }
                    catch { }
                    try
                    {
                        valor_bc_total = valor_bc_total + (Convert.ToDouble(Convert.ToDouble(dgvItens_nota.Rows[i].Cells["col_valor_bc"].Value.ToString()).ToString("n2")));
                    }
                    catch { }
                    try
                    {
                        valor_bc_st_total = valor_bc_st_total + (Convert.ToDouble(Convert.ToDouble(dgvItens_nota.Rows[i].Cells["col_valor_bc_st"].Value.ToString()).ToString("n2")));
                    }
                    catch { }
                    try
                    {
                        valor_st_total = valor_st_total + (Convert.ToDouble(Convert.ToDouble(dgvItens_nota.Rows[i].Cells["col_valor_st"].Value.ToString()).ToString("n2")));
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
                    try
                    {
                        totalTribNota += Convert.ToDouble(dgvItens_nota.Rows[i].Cells["col_tot_trib"].Value.ToString());
                    }
                    catch { }
                }
            }
             double valor = qtde_volume;
             int parteInteira = (int)valor;
             double parteFracionaria = valor - parteInteira;
             int _qtde = 0;
             if (parteFracionaria > 0)
                  _qtde = parteInteira + 1;
             else
                  _qtde = parteInteira;
            if(razao_social_empresa.Contains("DALE"))
            {
                tb_qtde_volume.Text = _qtde.ToString();
            }
           
            if(razao_social_empresa.Contains("CLERMANN"))
            {
                try
                {
                    tb_qtde_volume.Text = buscar_qtde_volumes(dgvPedidos.Rows[0].Cells["col_pedido"].Value.ToString());
                }
                catch { }
            }

            double ipi_devolvido = buscar_total_ipi_devolvido();
            //tb_especie.Text = "CAIXAS";
            tb_vtrib.Text = totalTribNota.ToString("n2");
            valor_total = valor_produtos + valor_ipi_total + base_calculo_iss_total +
                valor_st_total + valor_frete - valor_desconto + valor_seguro + valor_outras_desp + ipi_devolvido;
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

        private double buscar_total_ipi_devolvido()
        {
            try
            {
                  FbCommand select_itens = new FbCommand();
                    select_itens.Connection = fbConnection1;
                    fbConnection1.Open();
                    select_itens.CommandText =
                        "SELECT sum(VALOR_IPI_DEV_ITEM) " +
                        "FROM ITENS_NOTA i " +
                        "INNER JOIN NOTA_FISCAL n on i.NF_ITEM = n.N_NF " +
                        "WHERE n.COD_SISTEMA_NF = '" + tb_cod_interno.Text + "' ";
                    FbDataAdapter datSelect_itens = new FbDataAdapter();
                    datSelect_itens.SelectCommand = select_itens;
                    DataTable dtSelect_itens = new DataTable();
                    datSelect_itens.Fill(dtSelect_itens);
                    fbConnection1.Close();
                    int n_item = 1;
                    foreach (DataRow dr_itens in dtSelect_itens.Rows)
                    {
                        return Convert.ToDouble(dr_itens[0].ToString());
                    }
                return 0;

            }
            catch
            {
                fbConnection1.Close();
                return 0;
            }
        }
        private string buscar_qtde_volumes(string cod_ped)
        {
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                select.CommandText =
                    "SELECT QTDE_TOTAL_PED_VENDA FROM PEDIDOS_VENDA WHERE COD_PED_VENDA = '" + cod_ped + "'";
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = new FbCommand();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();
                foreach (DataRow dr in dtSelect.Rows)
                    return dr[0].ToString();
                return "";

            }
            catch { fbConnection1.Close(); return ""; }

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



        private void tb_data_emissao_TextChanged(object sender, EventArgs e)
        {

        }



        private void bt_finalizar_Click(object sender, EventArgs e)
        {
            finalizar_nf();
        }

        private void finalizar_nf()
        {
            for (int k = 0; k < dgvItens_nota.RowCount - 1; k++)
            {
                try
                {

                    this.datOp.UpdateCommand.CommandText =
                    "UPDATE OP SET SIT_ATUAL_OP = 'FATURADA' WHERE COD_OP = " + dgvItens_nota.Rows[k].Cells["col_cod"].Value + "";
                    this.fbConnection1.Open();
                    this.datOp.UpdateCommand.Connection = fbConnection1;
                    this.datOp.UpdateCommand.ExecuteNonQuery();
                    this.fbConnection1.Close();

                    this.datOp.UpdateCommand.CommandText =
                    "UPDATE OP SET NF_N = '" + tb_n_nf.Text + "' WHERE COD_OP = " + dgvItens_nota.Rows[k].Cells["col_cod"].Value + "";
                    this.fbConnection1.Open();
                    this.datOp.UpdateCommand.Connection = fbConnection1;
                    this.datOp.UpdateCommand.ExecuteNonQuery();
                    this.fbConnection1.Close();

                    this.datOp.UpdateCommand.CommandText =
                    "UPDATE OP SET ENTREGOU_DIA = '" + tb_data_emissao.Text.Replace("/", ".") + "' WHERE COD_OP = " + dgvItens_nota.Rows[k].Cells["col_cod"].Value + "";
                    this.fbConnection1.Open();
                    this.datOp.UpdateCommand.Connection = fbConnection1;
                    this.datOp.UpdateCommand.ExecuteNonQuery();
                    this.fbConnection1.Close();

                    this.datOp.UpdateCommand.CommandText =
                    "UPDATE OP SET SIT_ATUAL_OP = 'SEMI-FATURADA' WHERE COD_OP = " + dgvItens_nota.Rows[k].Cells["col_mae"].Value + "";
                    this.fbConnection1.Open();
                    this.datOp.UpdateCommand.Connection = fbConnection1;
                    this.datOp.UpdateCommand.ExecuteNonQuery();
                    this.fbConnection1.Close();
                }
                catch { }

            }
        }

        private void tb_NFe_Click(object sender, EventArgs e)
        {
            criar_arquivo("NFE" + tb_n_nf.Text + ".txt");
            escrever_no_arquivo_nfe();
        }

        private void detectar_dados_empresa(out string razao_social_empresa, out string nome_fantasia_empresa, out string cnpj_empresa, out string ie_empresa, out string im_empresa, out string cnae_empresa, out string endereco_empresa, out string n_endereco_empresa,
                    out string complemento_empresa, out string bairro_empresa, out string cidade_empresa, out string estado_empresa, out string cep_empresa, out string telefone_empresa, out string cod_cidade_empresa, out string pais_empresa,
                    out string cod_pais_empresa, out string licenca_dll_nfe_empresa, out string nome_certificado_nfe_empresa, out string assunto_nfe_email_empresa, out string smtp_nfe_empresa, out string email_nfe_empresa,
                    out string senha_email_nfe_empresa, out string logotipo_empresa, out string proxy_empresa, out string usuario_proxy_empresa, out string senha_proxy_empresa,
            out string crt_empresa, out string portaEmailEmpresa, out string sslEmpresa, out string serie_empresa, out string boleto_pedido_empresa, out string saida_estoque_pedido_empresa, out string cod_forn_empresa, out string cod_empresa)
        {
            razao_social_empresa = ""; nome_fantasia_empresa = ""; cnpj_empresa = this.cnpj_empresa; ie_empresa = ""; im_empresa = ""; cnae_empresa = ""; endereco_empresa = ""; n_endereco_empresa = "";
            complemento_empresa = ""; bairro_empresa = ""; cidade_empresa = ""; estado_empresa = ""; cep_empresa = ""; telefone_empresa = ""; cod_cidade_empresa = ""; pais_empresa = "";
            cod_pais_empresa = ""; licenca_dll_nfe_empresa = ""; nome_certificado_nfe_empresa = ""; assunto_nfe_email_empresa = ""; smtp_nfe_empresa = ""; email_nfe_empresa = "";
            senha_email_nfe_empresa = ""; logotipo_empresa = ""; proxy_empresa = ""; usuario_proxy_empresa = ""; senha_proxy_empresa = ""; crt_empresa = ""; portaEmailEmpresa = "";
            sslEmpresa = ""; serie_empresa = ""; boleto_pedido_empresa = ""; saida_estoque_pedido_empresa = ""; cod_forn_empresa = ""; cod_empresa = "";
            try
            {
                FbCommand comando = new FbCommand();
                comando.Connection = fbConnection1;
                comando.CommandText = "SELECT * FROM EMPRESA where LICENCA_DLL_NFE_EMPRESA is not null AND CNPJ_EMPRESA = '" + cnpj_empresa + "' ";
                DataSet empresa = new DataSet();
                fbConnection1.Open();
                datEmpresa.SelectCommand = comando;
                datEmpresa.Fill(empresa);
                datEmpresa.Fill(EMPRESA);
                fbConnection1.Close();
                foreach (DataRow dr in empresa.Tables[0].Rows)
                {
                    cod_empresa = dr["COD_EMPRESA"].ToString();
                    razao_social_empresa = dr["RAZAO_SOCIAL_EMPRESA"].ToString();
                    nome_fantasia_empresa = dr["NOME_FANTASIA_EMPRESA"].ToString();
                    //cnpj_empresa = dr["CNPJ_EMPRESA"].ToString().Replace(".", "").Replace("/", "").Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "");
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

                    serie_empresa = dr["SERIE_NF_EMPRESA"].ToString();

                    try
                    {
                        boleto_pedido_empresa = dr["BOLETO_PEDIDO_EMPRESA"].ToString();
                    }
                    catch { }
                    try
                    {
                        saida_estoque_pedido_empresa = dr["SAIDA_ESTOQUE_PEDIDO_EMPRESA"].ToString();
                    }
                    catch { }
                    try
                    {
                        cod_forn_empresa = dr["COD_FORN_EMPRESA"].ToString();
                    }
                    catch { }
                    tb_cnpj_empresa.Text = cnpj_empresa;
                    tb_razao_empresa.Text = razao_social_empresa;
                }

            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.Message);
            }
        }
        private string verificar_operacao()
        {
            for (int i = 0; i < dgvItens_nota.RowCount; i++)
            {
                try
                {
                    if (dgvItens_nota.Rows[i].Cells["col_cfo"].Value.ToString()[0].ToString() == "5")
                        return "1";
                    if (dgvItens_nota.Rows[i].Cells["col_cfo"].Value.ToString()[0].ToString() == "1")
                        return "1";
                    if (dgvItens_nota.Rows[i].Cells["col_cfo"].Value.ToString()[0].ToString() == "6")
                        return "2";
                    if (dgvItens_nota.Rows[i].Cells["col_cfo"].Value.ToString()[0].ToString() == "2")
                        return "2";
                    if (dgvItens_nota.Rows[i].Cells["col_cfo"].Value.ToString()[0].ToString() == "7")
                        return "3";
                    if (dgvItens_nota.Rows[i].Cells["col_cfo"].Value.ToString()[0].ToString() == "3")
                        return "3";
                }
                catch { }
            }
            return "1";

        }
        private void escrever_no_arquivo_nfe()
        {

            int nfe = 2;
            if (cbNfe_teste.Checked == false)
                nfe = 1;

            DateTime emissao = Convert.ToDateTime(tb_data_emissao.Text);

            int tipo_doc_fiscal;
            if (radioEntrada.Checked == true)
                tipo_doc_fiscal = 0;
            else
                tipo_doc_fiscal = 1;

            FileInfo t = new FileInfo("c:\\evolucao\\NFE\\TXT\\" + "NFE" + tb_n_nf.Text + ".txt");
            using (StreamWriter texto = t.CreateText())
            {
                texto.WriteLine("NOTA FISCAL |1|");
                string ano = Convert.ToDateTime(tb_data_emissao.Text).Year.ToString();
                ano = ano.Remove(0, 2);
                string mes = Convert.ToDateTime(tb_data_emissao.Text).Month.ToString();
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
                    sai_ent = Convert.ToDateTime(tb_saida.Text);
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
                 uf_cliente_2, cep_cliente_2, cod_pais_cliente_2, pais_cliente_2, telefone_cliente_2, cidade_cliente_2, email_cliente_2;
                buscar_dados_cliente(tb_cnpj_cliente.Text, out ie_cliente_2, out cnpj_cliente_2, out logradouro_cliente_2,
                    out n_logradouro_cliente_2, out complemento_cliente_2, out bairro_cliente_2,
                    out cod_municipio_cliente_2, out uf_cliente_2, out cep_cliente_2, out cod_pais_cliente_2,
                    out pais_cliente_2, out telefone_cliente_2, out cidade_cliente_2, out pessoa_fisica, out email_cliente_2);

                //NFE 3.0
                string _dhEvento = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:sszzz");

                string _data_completa = Convert.ToDateTime(tb_data_emissao.Text).ToString("yyyy-MM-ddTHH:mm:sszzz");

                string tipo_operacao = verificar_operacao();
                string form_pgto = "2";
                if (cb_forma_pgto.Text != "")
                    form_pgto = cb_forma_pgto.Text[0].ToString();

                string serie = "1";
                if (serie_empresa != "")
                    serie = serie_empresa;

                string indFinal = "0";
                string indIe = "1";

                if (ie_cliente_2 == "ISENTO" || pessoa_fisica)
                {
                    indIe = "9";
                    indFinal = "1";
                    ie_cliente_2 = "";
                }

                //if (tb_estado_cliente.Text == "EX")
                //    indIe = "9";

                if (tb_estado_cliente.Text == "EX")
                {
                    indIe = "9";
                    ie_cliente_2 = "";
                    tipo_operacao = "3";
                }


                string suframa = "";


                string finalidade = "1";
                if (tb_natureza_operacao.Text.Contains("DEV"))
                    finalidade = "4";
                if (tb_finalidade.Text != "")
                    finalidade = tb_finalidade.Text;

                //////////////////////////////////////////////////
                string estado = "";
                try
                {
                    estado = cod_cidade_empresa.Remove(2);
                }
                catch { }

                texto.WriteLine("B|" + estado + "||" + tb_natureza_operacao.Text + "|" + form_pgto + "|55|" + serie + "|" + tb_n_nf.Text +
                    "|" + _dhEvento + "|" + _dhEvento + "|" + tipo_doc_fiscal + "|" + tipo_operacao + "|" + cod_cidade_empresa +
                    "|1|1||" + nfe.ToString() + "|" + finalidade + "|" + indFinal + "|1|0|3.0|||");
                //if (tb_Nfe_refer.Text != "")
                //{
                //    texto.WriteLine("BA02|" + tb_Nfe_refer.Text + "|");
                //}
                try
                {
                    FbCommand select = new FbCommand();
                    select.Connection = fbConnection1;
                    fbConnection1.Open();
                    select.CommandText =
                        "SELECT distinct(CHAVE_NFENT_NFR) FROM NFS_REFERENCIADAS WHERE COD_SISTEMA_NF_SAIDA_NFR = '" + tb_cod_interno.Text + "'";
                    FbDataAdapter datSelect = new FbDataAdapter();
                    datSelect.SelectCommand = select;
                    DataTable dtSelect = new DataTable();
                    datSelect.Fill(dtSelect);
                    fbConnection1.Close();
                    foreach (DataRow dr in dtSelect.Rows)
                    {
                        texto.WriteLine("BA02|" + dr["CHAVE_NFENT_NFR"].ToString() + "|");
                    }
                }
                catch(Exception ex) 
                {
                    fbConnection1.Close();
                    MessageBox.Show("Erro nas Referenciadas:" + ex.Message);
                }


                texto.WriteLine("C|" + razao_social_empresa + "||" + ie_empresa + "||" + im_empresa + "|" + cnae_empresa + "|" + crt_empresa + "|");
                texto.WriteLine("C02|" + cnpj_empresa.Replace(".", "").Replace("/", "").Replace("-", "") + "|");
                //texto.WriteLine("C02a|" + tb_cpf.Text + "|");
                texto.WriteLine("C05|" + endereco_empresa + "|" + n_endereco_empresa + "|" + complemento_empresa + "|" + bairro_empresa + "|" + cod_cidade_empresa + "|" + cidade_empresa + "|" + estado_empresa + "|" + cep_empresa + "|||" + telefone_empresa + "|");

                //texto.WriteLine("E|" + tb_cliente.Text + "|" + ie_cliente_2.Replace(".", "").Replace("-", "") + "||" + email_cliente_2 + "|");
                string cliente = tb_cliente.Text;
                if (cbNfe_teste.Checked)
                    cliente = "NF-E EMITIDA EM AMBIENTE DE HOMOLOGACAO - SEM VALOR FISCAL";
                texto.WriteLine("E|" + cliente + "|" + indIe + "|" + ie_cliente_2.Replace(".", "").Replace("-", "") + "|" + suframa + "||" + email_cliente_2 + "|");
                if (cbExportacao.Checked == true || tb_estado_cliente.Text == "EX")
                    cnpj_cliente_2 = "";
                if (pessoa_fisica == false)
                {
                    texto.WriteLine("E02|" + cnpj_cliente_2.Replace(".", "").Replace("/", "").Replace("-", "") + "|");
                }
                else
                {
                    texto.WriteLine("E03|" + cnpj_cliente_2.Replace(".", "").Replace("/", "").Replace("-", "") + "|");
                }
                texto.WriteLine("E05|" + logradouro_cliente_2 + "|" + n_logradouro_cliente_2 + "|" + complemento_cliente_2 + "|" + bairro_cliente_2 + "|" + cod_municipio_cliente_2 + "|" + cidade_cliente_2 + "|" + uf_cliente_2 + "|" + cep_cliente_2.Replace("-", "") + "|" + cod_pais_cliente_2 + "||" + telefone_cliente_2.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", "") + "|");
                texto.WriteLine("GA|");
                texto.WriteLine("GA02|14849505000130|"); //PEDIDO MONICA ZAP EM 07/11/2024
                
                double totalTribNota = 0;
                for (int i = 0; i < dgvItens_nota.RowCount; i++)
                {
                    //preparando campos
                    int numero = i + 1;
                    string qtde_prod = transforma_decimal(4, dgvItens_nota.Rows[i].Cells["col_qtde"].Value.ToString(), 15);
                    string valor_unit_item = transforma_decimal(6, dgvItens_nota.Rows[i].Cells["col_preco_unit"].Value.ToString(), 21);
                    string cod_prod = dgvItens_nota.Rows[i].Cells["col_cod_op"].Value.ToString();
                    if (cod_prod == "")
                        cod_prod = "000000";


                    string valor_total_item = transforma_decimal(2, dgvItens_nota.Rows[i].Cells["col_preco_total"].Value.ToString(), 15);
                    string frete = transforma_decimal(2, dgvItens_nota.Rows[i].Cells["col_frete"].Value.ToString(), 15);
                    string seguro = transforma_decimal(2, dgvItens_nota.Rows[i].Cells["col_seguro"].Value.ToString(), 15);
                    string desconto = transforma_decimal(2, dgvItens_nota.Rows[i].Cells["col_desconto"].Value.ToString(), 15);
                    string outras_desp = transforma_decimal(2, dgvItens_nota.Rows[i].Cells["col_outras_desp"].Value.ToString(), 15);
                    string vTotalTrib = transforma_decimal(2, dgvItens_nota.Rows[i].Cells["col_tot_trib"].Value.ToString(), 15);


                    texto.WriteLine("H|" + numero.ToString() + "|.|");

                    string cest = dgvItens_nota.Rows[i].Cells["col_cest"].Value.ToString();
                 
                    if (cest == "")
                    {
                        cest = buscar_cest_produto(dgvItens_nota.Rows[i].Cells["col_cod_op"].Value.ToString());

                        if (cest == "")
                        {
                            cest = buscar_cest(dgvItens_nota.Rows[i].Cells["col_ncm"].Value.ToString());

                            if (cest == "")
                            {
                                cest = "0000000";
                            }

                        }

                        //}
                    }
                    string ean = dgvItens_nota.Rows[i].Cells["col_ean"].Value.ToString();
                    if (ean.Length < 5)
                        ean = "";
                    try
                    {
                        if (ean.Length < 13 && ean.Substring(0, 3) != "789")
                            ean = "";
                    }
                    catch { ean = ""; }
                    texto.WriteLine("I|" + cod_prod + "|" +
                        ean + "|" +
                        dgvItens_nota.Rows[i].Cells["col_descricao"].Value.ToString().Replace("Á", "A").Replace("Ã", "A") +
                        "|" + dgvItens_nota.Rows[i].Cells["col_ncm"].Value.ToString() +
                        "|" + cest +
                        "||" + dgvItens_nota.Rows[i].Cells["col_cfo"].Value.ToString() +
                        "|" + dgvItens_nota.Rows[i].Cells["col_unidade"].Value.ToString() +
                        "|" + qtde_prod + "|" + valor_unit_item + "|" + valor_total_item +
                        "|" + ean +
                        "|" + dgvItens_nota.Rows[i].Cells["col_unidade"].Value.ToString() +
                        "|" + qtde_prod + "|" + valor_unit_item + "|" + frete +
                        "|" + seguro + "|" + desconto + "|" + outras_desp +
                        //ACREDITO QUE TODOS OS ITENS COMPOE O VALOR TOTAL DA NOTA, PORTANTO ABAIXO EM indTot é "0"
                        "|1" +
                        "|" + dgvItens_nota.Rows[i].Cells["col_pedido_compra"].Value.ToString() +
                        "|" + dgvItens_nota.Rows[i].Cells["col_item_pedido_compra"].Value.ToString() + "||");

                    if (dgvItens_nota.Rows[i].Cells["col_cfo"].Value.ToString()[0].ToString() == "3")
                    {
                        texto.WriteLine("I18|" + dgvItens_nota.Rows[i].Cells["DI_ITEM"].Value.ToString() +
                            "|" + Convert.ToDateTime(dgvItens_nota.Rows[i].Cells["DATA_DI_ITEM"].Value.ToString()).ToString("yyyy") + "-" + Convert.ToDateTime(dgvItens_nota.Rows[i].Cells["DATA_DI_ITEM"].Value.ToString()).ToString("MM") + "-" + Convert.ToDateTime(dgvItens_nota.Rows[i].Cells["DATA_DI_ITEM"].Value.ToString()).ToString("dd") +
                            "|" + dgvItens_nota.Rows[i].Cells["LOCAL_DES_ITEM"].Value.ToString() +
                            "|" + dgvItens_nota.Rows[i].Cells["UF_DES_ITEM"].Value.ToString() +
                            "|" + Convert.ToDateTime(dgvItens_nota.Rows[i].Cells["DATA_DES_ITEM"].Value.ToString()).ToString("yyyy") + "-" + Convert.ToDateTime(dgvItens_nota.Rows[i].Cells["DATA_DES_ITEM"].Value.ToString()).ToString("MM") + "-" + Convert.ToDateTime(dgvItens_nota.Rows[i].Cells["DATA_DES_ITEM"].Value.ToString()).ToString("dd") +
                             "|4|0|1|" + cnpj_empresa.Replace(".","").Replace("-","").Replace("/","") + "|" + estado_empresa +
                            "|" + dgvItens_nota.Rows[i].Cells["COD_EXP_ITEM"].Value.ToString() +
                            "|");
                        texto.WriteLine("I25|1|1|1|||");
                    }

                    //COLOCAR AQUI QUANDO FOR IMPORTACAO EX: UNIMAGNA 
                    //I18|.....
                    //COLOCAR AQUI L01 EUROPA ****VERIFICAR MODIFICAÇÕES CONFORME ITEM 9.28 DA NT
                    int linhas;
                    string[] tributacao = new string[200];
                    tributacao = txt_tributacao(dgvItens_nota.Rows[i].Cells["col_cod"].Value.ToString(),
                        out linhas, cod_municipio_cliente_2,
                        dgvItens_nota.Rows[i].Cells["col_tipo_servico"].ToString(), vTotalTrib);
                    for (int l = 0; l < linhas; l++)
                    {
                        texto.WriteLine(tributacao[l]);
                    }
                }
                texto.WriteLine("W|");
                string base_cal_icm = transforma_decimal(2, tb_base_calc_icm.Text, 15);
                string valor_tot_icm = transforma_decimal(2, tb_valor_icm.Text, 15);
                string base_cal_icm_st = transforma_decimal(2, tb_base_cal_icm_st.Text, 15);
                string valor_tot_icm_st = transforma_decimal(2, tb_valor_icm_st.Text, 15);
                string valor_total_prod = transforma_decimal(2, tb_total_prod.Text, 15);
                string valor_total_frete = transforma_decimal(2, tb_valor_fre.Text, 15);
                string valor_total_seguro = transforma_decimal(2, tb_valor_seg.Text, 15);
                string valor_total_desc = transforma_decimal(2, tb_desconto.Text, 15);
                string valot_total_II = buscar_total_II();
                string valor_total_ipi = transforma_decimal(2, tb_valor_ipi.Text, 15);
                string valor_pis = buscar_total_pis();
                string valor_cofins = buscar_total_cofins();
                string outras_des_ace = transforma_decimal(2, tb_outras_des_ace.Text, 15);
                string valor_total_nfe = transforma_decimal(2, tb_total_nota.Text, 15);
                string vTotTribNf = transforma_decimal(2, tb_vtrib.Text, 15);
                string icmsDeson = buscar_total_icms_desonerado();
                texto.WriteLine("W02|" + base_cal_icm + "|" + valor_tot_icm + "|" + icmsDeson + "|0.00|0.00|0.00|" + base_cal_icm_st + "|" + valor_tot_icm_st + "|" + valor_total_prod + "|" + valor_total_frete +
                     "|" + valor_total_seguro + "|" + valor_total_desc + "|" + valot_total_II + "|" + valor_total_ipi + "|" + valor_pis + "|" + valor_cofins + "|" + outras_des_ace + "|" + valor_total_nfe + "|" + vTotTribNf + "|");
                double valor_iss = 0;
                try
                {
                    valor_iss = Convert.ToDouble(tb_valor_total_iss.Text);
                }
                catch { }
                if (valor_iss > 0)
                    texto.WriteLine("W17|" + transforma_decimal(2, tb_base_calc_iss.Text, 15) + "|" + transforma_decimal(2, tb_base_calc_iss.Text, 15) + "|" + transforma_decimal(2, tb_valor_total_iss.Text, 15) + "|||");
                texto.WriteLine("X|" + tb_frete.Text + "|");
                string _endereco_transp, _ie_transp, _uf_transp, _municipio_transp, _cnpj_transp;
                detectar_transportadora(tb_transportadora.Text, out _ie_transp, out _cnpj_transp, out _municipio_transp, out _uf_transp, out _endereco_transp);
                texto.WriteLine("X03|" + tb_transportadora.Text + "|" + _ie_transp.Replace(".", "").Replace("-", "") + "|" + _endereco_transp + "|" + _uf_transp + "|" + _municipio_transp + "|");
                texto.WriteLine("X04|" + _cnpj_transp.Replace(".", "").Replace("/", "").Replace("-", "") + "|");
                string peso_liquido = transforma_decimal(3, tb_peso_liquido.Text, 15);
                string peso_bruto = transforma_decimal(3, tb_peso_bruto.Text, 15);
                texto.WriteLine("X26|" + tb_qtde_volume.Text + "|" + tb_especie.Text + "|" + tb_marca.Text + "||" + peso_liquido + "|" + peso_bruto + "|");
                try
                {
                    if (cb_forma_pgto.Text[0].ToString() == "1" || cb_forma_pgto.Text[0].ToString() == "0")
                    {
                        nfe40.cod_nf_sistema = tb_cod_interno.Text;
                        double valor_faturas = 0;
                        valor_faturas = nfe40.buscar_valor_pagamentos();
                        string valor_total = transforma_decimal(2, valor_faturas.ToString(), 15);
                        texto.WriteLine("Y|");
                        texto.WriteLine("Y02|001|" + valor_total + "||" + valor_total + "|");
                        int _n_vencimentos;

                        detectar_numero_vencimentos_fatura(out _n_vencimentos);
                        for (int v = 0; v < _n_vencimentos; v++)
                        {
                            DateTime venc = new DateTime();
                            venc = Convert.ToDateTime(_datas[v].ToString());
                            string mes_venc = venc.Month.ToString();
                            if (mes_venc.Length == 1)
                                mes_venc = "0" + mes_venc;
                            string dia_venc = venc.Day.ToString();
                            if (dia_venc.Length == 1)
                                dia_venc = "0" + dia_venc;
                            int dup = v + 1;
                            string codigo = zero_a_esquerda(3, dup.ToString());
                            texto.WriteLine("Y07|" + codigo + "|" + venc.Year.ToString() + "-" + mes_venc + "-" + dia_venc + "|" + transforma_decimal(2, _valores[v], 15) + "|");
                           // texto.WriteLine("Y07|" + _cod[v] + "|" + venc.Year.ToString() + "-" + mes_venc + "-" + dia_venc + "|" + transforma_decimal(2, _valores[v], 15) + "|");
                        }
                    }



                }
                catch { }
                texto.WriteLine("Z|" + tb_informacoes_fisco.Text + "|" + tb_dados_adicionais.Text.Replace("\r\n", " ").Replace("\n", " ") + "|"); //tirando os enter do textbox
                if (cbExportacao.Checked == true)
                {
                    //texto.WriteLine("ZA|" + tb_uf_exportacao.Text + "|" + tb_local_exportacao.Text + "|");
                    texto.WriteLine("ZA|" + tb_uf_exportacao.Text + "|" + tb_local_exportacao.Text + "|RECINTO ALFANDEGARIO|");
                }
            }
        }

        private string buscar_total_icms_desonerado()
        {
            double total_desonerado = 0;
            try
            {
                for (int p = 0; p < dgvItens_nota.RowCount; p++)
                {
                    if (dgvItens_nota.Rows[p].Cells["col_st"].Value.ToString() == "51")
                    {
                        try
                        {
                            total_desonerado = total_desonerado + Convert.ToDouble(dgvItens_nota.Rows[p].Cells["col_valor_icm"].Value.ToString());
                        }
                        catch { }
                    }
                }
            }
            catch { }
            return transforma_decimal(2, total_desonerado.ToString(), 15);
        }

        private string zero_a_esquerda(int tamanho_pretendido, string valor)
        {
            
            int tamanho = valor.Length;
            for (int p = 0; p < tamanho_pretendido - tamanho; p++)
            {
                valor = "0" + valor;
            }

            return valor;
        }

        private string buscar_cest_produto(string cod_produto)
        {
            string cest = "";
            try
            {
                FbCommand sel = new FbCommand();
                FbDataAdapter datSel = new FbDataAdapter();
                DataTable dt = new DataTable();
                sel.Connection = fbConnection1;
                sel.CommandText = "SELECT CEST_PRODUTO FROM PRODUTOS WHERE COD_FORNECEDOR_PRODUTO = '" + cod_produto + "'";
                datSel.SelectCommand = sel;
                fbConnection1.Open();
                datSel.Fill(dt);
                fbConnection1.Close();
                foreach (DataRow dr in dt.Rows)
                {
                    cest = dr[0].ToString();
                }
                return cest;
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
                return cest;
            }
        }

        private string buscar_cest(string ncm)
        {
            try
            {
                ncm = Convert.ToInt64(ncm).ToString();
                OleDbConnection theConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;data source='c:\\evolucao\\excel\\cest.xls';Extended Properties=\"Excel 12.0 Xml;HDR=Yes;IMEX=1;\"");
                theConnection.Open();
                OleDbDataAdapter theDataAdapter = new OleDbDataAdapter("SELECT * FROM [cest$]", theConnection);
                DataSet theDS = new DataSet();
                theDataAdapter.Fill(theDS);
                theConnection.Close();
                foreach (DataRow dr in theDS.Tables[0].Select("ncm = '" + ncm + "'"))
                {
                    return dr[1].ToString();
                }
                foreach (DataRow dr in theDS.Tables[0].Select("ncm = '" + ncm.Remove(ncm.Length - 1) + "'"))
                {
                    return dr[1].ToString();
                }
                foreach (DataRow dr in theDS.Tables[0].Select("ncm = '" + ncm.Remove(ncm.Length - 2) + "'"))
                {
                    return dr[1].ToString();
                }
                foreach (DataRow dr in theDS.Tables[0].Select("ncm = '" + ncm.Remove(ncm.Length - 3) + "'"))
                {
                    return dr[1].ToString();
                }
                foreach (DataRow dr in theDS.Tables[0].Select("ncm = '" + ncm.Remove(ncm.Length - 4) + "'"))
                {
                    return dr[1].ToString();
                }
                foreach (DataRow dr in theDS.Tables[0].Select("ncm = '" + ncm.Remove(ncm.Length - 5) + "'"))
                {
                    return dr[1].ToString();
                }
                foreach (DataRow dr in theDS.Tables[0].Select("ncm = '" + ncm.Remove(ncm.Length - 6) + "'"))
                {
                    return dr[1].ToString();
                }
                return "0000000";
            }
            catch { return "0000000"; }

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
                    "SELECT * FROM ITENS_NOTA WHERE COD_ITENS_NOTA = " + cod;
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
                    texto[linhas] = "N04|" + origem_merc + "|20|" + mod_det_bc_icms + "|" + per_red_bc + "|" +
                        valor_bc_icms + "|" + aliq_imp + "|" + valor_icms + "|0.00||";
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
                    //ESTÁ PARA DIFERIMENTO 100%
                    string origem_merc = dr["ORIGEM_ITEM"].ToString();
                    string mod_det_bc_icms = dr["MOD_BC_ITEM"].ToString();
                    string per_red_bc =  transforma_decimal(2, dr["REDUCAO_ITEM"].ToString(), 5);
                    string valor_bc_icms =  transforma_decimal(2, dr["PRECO_TOTAL_ITEM"].ToString(), 15);
                    string aliq_imp = "18.00";// transforma_decimal(2, dr["ICM_ITEM"].ToString(), 5);
                    double _valor_icms = Convert.ToDouble(dr["PRECO_TOTAL_ITEM"].ToString()) * Convert.ToDouble("0,18");
                    string valor_icms = transforma_decimal(2, _valor_icms.ToString(), 15);
                   //texto[linhas] = "N07|" + origem_merc + "|51|" + mod_det_bc_icms + "|" + per_red_bc + "|" + valor_bc_icms + "|" + aliq_imp + 
                   //     "|0.00|" + valor_icms + "|100.00|" + valor_icms + "|";
                    texto[linhas] = "N07|" + origem_merc + "|51|" + mod_det_bc_icms + "|0.00|0.00|0.00|0.00|0.00|0.00|0.00|";
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
                    texto[linhas] = "N09|" + origem_merc + "|70|" + mod_det_bc_icms + "|" + per_red_bc + "|" + valor_bc_icms + "|" + aliq_imp + "|" + valor_icms + "|" + st_mod_det_bc_icms + "|" + st_per_mar_val_adi_icm + "|" + st_per_red_bc_icm + "|" + st_val_bc_icm + "|" + st_ali_imp_icm + "|" + st_valor_icms + "|||";
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
                    texto[linhas] = "N10|" + origem_merc + "|90|" + mod_det_bc_icms + "|" + per_red_bc + "|" + valor_bc_icms + "|" + aliq_imp + "|" + 
                        valor_icms + "|" + st_mod_det_bc_icms + "|" + st_per_mar_val_adi_icm + "|" + st_per_red_bc_icm + "|" + st_val_bc_icm + "|" + st_ali_imp_icm + "|" + st_valor_icms + 
                        "|0.00|16|";//0.00|0.00|0.00|0.00|0.00|0.00|";
                                            //N10|orig|CST|modBC|pRedBC|vBC|pICMS|vICMS|modBCST|pMVAST|pRedBCST|vBCST|pICMSST|vICMSST
//vICMSDeson|motDesICMS|vBCFCP|pFCP|vFCP|vBCFCPST|pFCPST|vFCPST
                    linhas++;
                }

                if (dr["ST_ITEM"].ToString() == "101")
                {
                    string origem_merc = dr["ORIGEM_ITEM"].ToString();
                    string mod_det_bc_icms = dr["MOD_BC_ITEM"].ToString();
                    string aliq_simples = transforma_decimal(2, dr["ALIQUOTA_CREDITO_ITEM"].ToString(), 5);
                    string valor_credito = transforma_decimal(2, dr["VALOR_CREDITO_ITEM"].ToString(), 15);
                    texto[linhas] = "N10c|" + origem_merc + "|101|" + aliq_simples + "|" + valor_credito + "|";
                    linhas++;
                }
                if (dr["ST_ITEM"].ToString() == "102" || dr["ST_ITEM"].ToString() == "103" ||
                    dr["ST_ITEM"].ToString() == "300" || dr["ST_ITEM"].ToString() == "400")
                {
                    string origem_merc = dr["ORIGEM_ITEM"].ToString();
                    string mod_det_bc_icms = dr["MOD_BC_ITEM"].ToString();
                    texto[linhas] = "N10d|" + origem_merc + "|" + dr["ST_ITEM"].ToString() + "|";
                    linhas++;
                }
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
                    texto[linhas] = "N10h|" + origem_merc + "|900|" + mod_det_bc_icms + "|" + per_red_bc + "|" + valor_bc_icms +
                           "|" + aliq_imp + "|" + valor_icms + "|" + st_mod_det_bc_icms + "|" + st_per_mar_val_adi_icm +
                           "|" + st_per_red_bc_icm + "|" + st_val_bc_icm + "|" + st_ali_imp_icm + "|" + st_valor_icms +
                           "|" + aliq_simples + "|" + valor_credito + "|";

                    linhas++;
                }
                //IPI
                texto[linhas] = ("O|||||999|");
                linhas++;
                string cod_sit_tri_ipi = "";
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
                    /* SE TIVER ALGUMA EMPRESA QUE COBRA IPI POR UNIDADE AVISAR
                    if (rb_por_alíquota.Checked == true)
                    {
                        string val_bc_ipi = transforma_decimal(2, tb_val_bc_ipi.Text, 15);
                        string ali_ipi = transforma_decimal(2, tb_ali_ipi.Text, 5);
                        texto.WriteLine("O10|" + val_bc_ipi + "|" + ali_ipi + "|");
                    }
                    if (rb_por_unidade.Checked == true)
                    {
                        string val_uni_trib = transforma_decimal(4, tb_val_uni_tri.Text, 15);
                        string qtd_tot_unit_pad = transforma_decimal(4, tb_qtd_uni_pad.Text, 16);
                        texto.WriteLine("O11|" + val_uni_trib + "|" + qtd_tot_unit_pad + "|");
                    }
                     * */
                }
                if (dr["IPI_N_TRIB_ITEM"].ToString() == "1")
                {
                    cod_sit_tri_ipi = dr["CST_IPI_N_TRIB_ITEM"].ToString();
                    texto[linhas] = "O08|" + cod_sit_tri_ipi + "|";
                    linhas++;
                }
                if (dr["CFOP_ITEM"].ToString()[0].ToString() == "3") //quando for importação
                {
                    texto[linhas] = "P|" + transforma_decimal(2, dr["BC_II_ITEM"].ToString(), 15) + "|" +
                        transforma_decimal(2, dr["DESP_ADUANEIRAS_ITEM"].ToString(), 15) + "|" +
                        transforma_decimal(2, dr["VALOR_II_ITEM"].ToString(), 15) + "|" +
                        transforma_decimal(2, dr["IOF_II_ITEM"].ToString(), 15) + "|";
                    linhas++;
                }
                //PIS
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
                if (dr["CST_PIS_ITEM"].ToString() == "04" || dr["CST_PIS_ITEM"].ToString() == "06" ||
                    dr["CST_PIS_ITEM"].ToString() == "07" || dr["CST_PIS_ITEM"].ToString() == "08" ||
                    dr["CST_PIS_ITEM"].ToString() == "09" )
                {
                    texto[linhas] = "Q|"; linhas++;
                    texto[linhas] = "Q04|" + dr["CST_PIS_ITEM"].ToString() + "|";
                    linhas++;
                }
                if (dr["CST_PIS_ITEM"].ToString() == "99" )
                {
                    texto[linhas] = "Q|"; linhas++;
                    texto[linhas] = "Q05|" + dr["CST_PIS_ITEM"].ToString() + "|" + transforma_decimal(2, dr["VALOR_PIS_ITEM"].ToString(), 15) + "|"; linhas++;
                    texto[linhas] = "Q07|" + transforma_decimal(2, dr["PIS_ITEM"].ToString(), 5) + "|" + transforma_decimal(2, dr["BC_PIS_ITEM"].ToString(), 15) + "|";
                    linhas++;
                }
                //COFINS
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
                if (dr["CST_COFINS_ITEM"].ToString() == "04" || dr["CST_COFINS_ITEM"].ToString() == "06" ||
                    dr["CST_COFINS_ITEM"].ToString() == "07" || dr["CST_COFINS_ITEM"].ToString() == "08" ||
                    dr["CST_COFINS_ITEM"].ToString() == "09")
                {
                    texto[linhas] = "S|"; linhas++;
                    texto[linhas] = "S04|" + dr["CST_COFINS_ITEM"].ToString() + "|";
                    linhas++;
                }
                if (dr["CST_COFINS_ITEM"].ToString() == "99" )
                {
                    texto[linhas] = "S|"; linhas++;
                    texto[linhas] = "S05|" + dr["CST_COFINS_ITEM"].ToString() + "|" + transforma_decimal(2, dr["VALOR_COFINS_ITEM"].ToString(), 15) + "|"; linhas++;
                    texto[linhas] = "S07|" + transforma_decimal(2, dr["COFINS_ITEM"].ToString(), 5) + "|" + transforma_decimal(2, dr["BC_COFINS_ITEM"].ToString(), 15) + "|";
                    linhas++;
                }
                if (dr["PRESTACAO_SERVICO_ITEM"].ToString() == "1")
                {
                    texto[linhas] = "U|" + transforma_decimal(2, dr["BC_ISS_ITEM"].ToString(), 15) + "|" + transforma_decimal(2, dr["ISS_ITEM"].ToString(), 15) + "|" + transforma_decimal(2, dr["VALOR_ISS_ITEM"].ToString(), 15) + "|" + cod_municipio + "|" + cod_servico + "|N|";
                }

                texto[linhas] = "UA|" + transforma_decimal(2, dr["PORC_IPI_DEV_ITEM"].ToString(), 15) + "|" + transforma_decimal(2, dr["VALOR_IPI_DEV_ITEM"].ToString(), 15) + "|"; linhas++;
               // texto[linhas] = "UA03|" + transforma_decimal(2, "50,00", 15) + "|"; linhas++;


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
            out bool pessoa_fisica, out string email_cliente)
        {
            ie_cliente = ""; cnpj_cliente = ""; logradouro_cliente = ""; n_logradouro_cliente = "";
            complemento_cliente = ""; bairro_cliente = ""; cod_municipio_cliente = "";
            uf_cliente = ""; cep_cliente = ""; cod_pais_cliente = ""; pais_cliente = "";
            telefone_cliente = ""; cidade_cliente = ""; pessoa_fisica = false; email_cliente = "";
            try
            {
                FbCommand comando = new FbCommand();
                comando.Connection = fbConnection1;
                comando.CommandText =
                    "SELECT * FROM CLIENTES WHERE CNPJ = '" + cnpj + "'";
                fbConnection1.Open();
                //comando_select.Connection = fbConnection1;
                datClientes.SelectCommand = comando;
                DataSet cliente = new DataSet();
                datClientes.Fill(cliente);
                fbConnection1.Close();
                DataRow dr = cliente.Tables[0].Rows[0];
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
                if (dr["PESSOA_FISICA_CLIENTE"].ToString() == "1")
                    pessoa_fisica = true;
                else
                    pessoa_fisica = false;
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private string buscar_total_II()
        {
            double total_pis = 0;
            for (int p = 0; p < dgvItens_nota.RowCount; p++)
            {
                try
                {
                    total_pis = total_pis + Convert.ToDouble(dgvItens_nota.Rows[p].Cells["VALOR_II_ITEM"].Value.ToString());
                }
                catch { }
            }
            return transforma_decimal(2, total_pis.ToString("n2").Replace(".", ""), 15);
        }

        private string buscar_total_pis()
        {
            double total_pis = 0;
            for (int p = 0; p < dgvItens_nota.RowCount; p++)
            {
                try
                {
                    total_pis = total_pis + Convert.ToDouble(dgvItens_nota.Rows[p].Cells["col_valor_pis"].Value.ToString());
                }
                catch { }
            }
            return transforma_decimal(2, total_pis.ToString("n2").Replace(".",""), 15);
        }

        private string buscar_total_cofins()
        {
            double total_cofins = 0;
            for (int p = 0; p < dgvItens_nota.RowCount; p++)
            {
                try
                {
                    total_cofins = total_cofins + Convert.ToDouble(dgvItens_nota.Rows[p].Cells["col_valor_cofins"].Value.ToString());
                }
                catch { }
            }
            return transforma_decimal(2, total_cofins.ToString("n2").Replace(".", ""), 15);
        }

        private void detectar_numero_vencimentos_fatura(out int n_venc)
        {
            try
            {
                FbCommand comando = new FbCommand();
                comando.Connection = fbConnection1;
                comando.CommandText =
                    "SELECT * " +
                    "FROM FATURA_NF WHERE NF_FATURA = '" + tb_n_nf.Text + "'";
                DataSet fatura = new DataSet();
                fbConnection1.Open();
                datFatura_nf.SelectCommand = comando;
                datFatura_nf.Fill(fatura);
                int n = 0;
                foreach (DataRow dr in fatura.Tables[0].Rows)
                {

                    _cod[n] = dr["COD_FATURA"].ToString();
                    _valores[n] = dr["VALOR_FATURA"].ToString();
                    _datas[n] = dr["DATA_VENC_FATURA"].ToString();
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
        private void detectar_transportadora(string nome, out string ie, out string cnpj, out string municipio, out string uf, out string endereco)
        {

            FbCommand comando = new FbCommand();
            comando.Connection = fbConnection1;
            comando.CommandText =
                "SELECT RAZAO_SOCIAL_TRANSPORTADORA, ENDERECO_TRANSPORTADORA, IE_TRANSPORTADORA, " +
                "CNPJ_TRANSPORTADORA, CIDADE_TRANSPORTADORA, ESTADO_TRANSPORTADORA FROM TRANSPORTADORAS WHERE RAZAO_SOCIAL_TRANSPORTADORA = '" + nome + "'";
            DataSet transp = new DataSet();
            fbConnection1.Open();
            datTransportadoras.SelectCommand = comando;
            datTransportadoras.Fill(transp);
            endereco = ""; ie = ""; cnpj = ""; municipio = ""; uf = "";
            foreach (DataRow dr in transp.Tables[0].Rows)
            {
                nome = dr["RAZAO_SOCIAL_TRANSPORTADORA"].ToString();
                endereco = dr["ENDERECO_TRANSPORTADORA"].ToString();
                ie = dr["IE_TRANSPORTADORA"].ToString();
                cnpj = dr["CNPJ_TRANSPORTADORA"].ToString();
                municipio = dr["CIDADE_TRANSPORTADORA"].ToString();
                uf = dr["ESTADO_TRANSPORTADORA"].ToString();
            }

            this.fbConnection1.Close();
            //return nome_transp;


        }

        private void ler_arquivo_tributacao()
        {

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

        private void button2_Click(object sender, EventArgs e)
        {
            form_localiza_transportadora localiza_transportadora = new form_localiza_transportadora();
            try
            {
                localiza_transportadora.ShowDialog();
            }
            finally
            {
                localiza_transportadora.Dispose();
                //MessageBox.Show(localiza_peca.peca_escolhida);
                dsTransportadoras.Clear();
                tb_transportadora.Text = localiza_transportadora.transportadora_escolhida;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
           
            Atualizar(true);
            bool ok = false;
            nfe40.cod_nf_sistema = tb_cod_interno.Text;
            string erros = nfe40.verificar_erros_comuns();
            
            if (erros != "")
            {
                MessageBox.Show(erros);
            }
            else
            {
                gerar_xml(out ok);
            }
          //  bool ok = false;
           // gerar_xml(out ok);

        }

        private void verificar_retornos_mp()
        {
            if (dgvItens_nota.RowCount < 100)
            {
                string dados_adicionais = "";
                try
                {
                    FbCommand select = new FbCommand();
                    select.CommandText = @"SELECT inf.COD_ITEM, nfe.N_NF_ent, nfe.DATA_EMISSAO_NF_ENT  FROM ITENS_NOTA inf
                    inner join ITENS_NOTA_ENT infe on inf.COD_EAN_ITEM = infe.LOTE_ITEM_ENT 
                    inner join NOTA_FISCAL_ENT nfe on infe.COD_SISTEMA_NF_ITEM_ENT = nfe.COD_SISTEMA_NF_ENT 
                    WHERE cfop_item like '_902' and nf_item = '" + tb_n_nf.Text + "' ORDER BY COD_ITEM";
                    select.Connection = fbConnection1;
                    fbConnection1.Open();
                    FbDataAdapter datSelect = new FbDataAdapter();
                    datSelect.SelectCommand = select;
                    DataTable dt = new DataTable();
                    datSelect.Fill(dt);
                    fbConnection1.Close();
                    foreach (DataRow dr in dt.Rows)
                    {
                        dados_adicionais += " MP:" + dr["COD_ITEM"].ToString() + "-NF:" + dr[1].ToString() +
                            "-Data NF:" + Convert.ToDateTime(dr["DATA_EMISSAO_NF_ENT"].ToString()).ToShortDateString() + "**";
                    }
                    if (!tb_dados_adicionais.Text.Contains(dados_adicionais))
                    {
                        tb_dados_adicionais.Text = tb_dados_adicionais.Text + dados_adicionais;
                    }
                }
                catch
                {
                    fbConnection1.Close();
                }
            }
        }

        private void salvar_na_pasta(string cte, string caminho)
        {
            try
            {
                FileInfo t = new FileInfo(caminho);
                using (StreamWriter texto = t.CreateText())
                {
                    texto.WriteLine(cte);
                }
            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
            }
        }

        private void update_coluna_xml_gerado(string nfe, string cod, string Nome)
        {
            try
            {
                string xmlAssinado = "", msgResultado = "";
                int resultado;

                xmlAssinado = util2.Assinar(nfe, "infNFe", Nome, out resultado, out msgResultado);
                //    util.Assinar(dr[0].ToString(), "infCte", Nome, out xmlAssinado, out msgResultado);
                if (resultado == 5300)
                {
                    salvar_na_pasta(xmlAssinado, @"c:\\evolucao\\NFE\ASSINADAS\NFE" + tb_chave_acesso_nfe.Text + "_ANTES.xml");

                    fbConnection1.Open();
                    FbTransaction trans = fbConnection1.BeginTransaction();
                    fbConnection1.Close();
                    FbCommand update = new FbCommand("UPDATE NOTA_FISCAL SET XML_GERADO_NF = ? " +
                        "WHERE N_NF = ?", fbConnection1, trans);
                    update.Parameters.AddWithValue("XML_GERADO_NF", xmlAssinado);
                    update.Parameters.AddWithValue("N_NF", cod);
                    fbConnection1.Open();
                    FbDataAdapter datTabela = new FbDataAdapter();
                    datTabela.UpdateCommand = update;
                    datTabela.UpdateCommand.ExecuteNonQuery();
                    fbConnection1.Close();
                }
                else
                {
                    // MessageBox.Show(msgResultado);
                }
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
                fbConnection1.Close();
            }
        }

        private void gerar_xml(out bool ok)
        {
            //cbNfe_teste.Checked = true;
            if (tb_dados_adicionais.Text == "")
                tb_dados_adicionais.Text = ".";


            ok = false;
            if (dgvPedidos.RowCount > 1)
            {
                MessageBox.Show("Não é possível inserir 2 pedidos na mesma nota. Exclua o pedido incorreto.");
            }
            else
            {
                //Classe e chamada de método para calcular o volume em caixas
                /*
                classe_calcula_volume ccv = new classe_calcula_volume();
                int numero_nota_fiscal = Convert.ToInt32(tb_n_nf.Text);
                int qtde = 0;
                string produto_sem_unidade;
                bool resposta = ccv.calcula_volume_peso(numero_nota_fiscal, out qtde, out produto_sem_unidade);

                if (resposta == true)
                {
                    tb_qtde_volume.Text = qtde.ToString();
                    tb_especie.Text = "CX";
                }
                else
                {
                    // MessageBox.Show("Para calcular o volume, ajuste o cadastro de produtos na caixa: " + produto_sem_unidade);
                }
                 * */

                if (cb_forma_pgto.Text != "")
                {
                    if (tb_qtde_volume.Text == "")
                    {
                        // MessageBox.Show("O volume da nota não foi preenchido!\nSe for necessário informar o volume, digite-o e gere o xml novamente.");
                    }
                    //buscar_peso_dos_produtos();
                    verificar_retornos_mp();
                    verificar_aproveitamento_credito();
                    verificar_se_simples();
                    verificar_cfop();
                  //  colocar_form_pgto_no_dados_adicionais();
                    Atualizar(false);
                    criar_arquivo("NFE" + tb_n_nf.Text + ".txt");
                    escrever_no_arquivo_nfe();
                    string arquivo;
                    string caminho = "c:\\evolucao\\NFE\\TXT\\NFE" + tb_n_nf.Text + ".txt";
                    StreamReader objReader = new StreamReader(caminho);
                    ArrayList arrText = new ArrayList();
                    arquivo = objReader.ReadToEnd();
                    objReader.Close();
                    string _txtNumerado, _erros, _msgResultado;
                    int _qtErros;
                    int resultado = 0;
                    //string _XML = util2.Txt2XML2G(arquivo, 1, "Evolucao", out _txtNumerado, out resultado, out _erros, out _qtErros, out _msgResultado);
                    // string _XML = util2.Txt2XML310(arquivo, 1, "Evolucao", out _txtNumerado, out resultado, out _erros, out _qtErros, out _msgResultado);
                    string _XML = util2.Txt2XML2015003(arquivo.Replace("'",""), 1, "Evolucao", out _txtNumerado, out resultado, out _erros, out _qtErros, out _msgResultado);
                    if (resultado == 6901)
                    {
                        nfe40.cod_nf_sistema = tb_cod_interno.Text;
                        _XML = nfe40.acertos_diversos(_XML);
                        //MessageBox.Show(_XML);
                        try
                        {
                            criar_arquivo_xml("NFE" + tb_n_nf.Text + ".xml");
                            FileInfo t = new FileInfo("c:\\evolucao\\NFE\\XML\\" + "NFE" + tb_n_nf.Text + ".xml");
                            using (StreamWriter texto = t.CreateText())
                            {
                                texto.WriteLine(_XML);
                            }
                            update_coluna_xml_gerado(_XML, tb_n_nf.Text, nome_certificado_nfe_empresa);

                            barra_status.Text = "Arquivo XML gerado com sucesso";
                            tb_status_nfe.Text = "Arquivo XML gerado com sucesso";
                            gbNfe.BackColor = Color.Yellow;

                            tb_chave_acesso_nfe.Text = buscar_chave("c:\\evolucao\\NFE\\xml\\" + "NFE" + tb_n_nf.Text + ".xml");
                            Atualizar(false);
                            criar_codigo_barras();
                            Atualizar(false);
                            ok = true;

                        }
                        catch
                        {
                            barra_status.Text = "Erro, tente outra vez";
                            tb_status_nfe.Text = "Erro, tente outra vez";
                            gbNfe.BackColor = Color.Red;
                        }
                    }
                    else
                    {
                        MessageBox.Show(_erros);
                        MessageBox.Show(_msgResultado);
                    }
                }
                else
                    MessageBox.Show("A forma de pagamento é um campo obrigatório. Se não for uma nota de vendas, selecione a opção Outros");
            }
        }

        private void colocar_form_pgto_no_dados_adicionais()
        {
            try
            {
                int tamanho = cb_forma_pgto.Text.Length - 2;
                tb_dados_adicionais.Text = tb_dados_adicionais.Text.Replace(cb_forma_pgto.Text.Substring(2, tamanho), "") + " " + cb_forma_pgto.Text.Substring(2, tamanho);
            }
            catch { }
        }

        private void buscar_peso_dos_produtos()
        {
            double peso_total = 0;
            for (int i = 0; i < dgvItens_nota.RowCount; i++)
            {
                try
                {
                    FbCommand select = new FbCommand();
                    select.CommandText = "SELECT PESO_UNIT_PRODUTO FROM PRODUTOS WHERE COD_FORNECEDOR_PRODUTO = '" + dgvItens_nota.Rows[i].Cells["col_cod_op"].Value.ToString() + "'";
                    select.Connection = fbConnection1;
                    fbConnection1.Open();
                    FbDataAdapter datSelect = new FbDataAdapter();
                    datSelect.SelectCommand = select;
                    DataTable dt = new DataTable();
                    datSelect.Fill(dt);
                    fbConnection1.Close();
                    foreach (DataRow dr in dt.Rows)
                    {
                        peso_total = peso_total + (Convert.ToDouble(dgvItens_nota.Rows[i].Cells["col_qtde"].Value.ToString()) *
                            Convert.ToDouble(dr[0].ToString()));
                    }
                }
                catch
                {
                    fbConnection1.Close();
                }
            }
            tb_peso_liquido.Text = peso_total.ToString("n2");

        }

        private void verificar_cfop()
        {
            string texto = "";
            if (!pessoa_fisica(tb_cnpj_cliente.Text))
            {
                for (int j = 0; j < dgvItens_nota.RowCount; j++)
                {
                    if (dgvItens_nota.Rows[j].Cells["col_cfo"].Value.ToString() == "5102" ||
                        dgvItens_nota.Rows[j].Cells["col_cfo"].Value.ToString() == "6102")
                    {
                        int linha = j + 1;
                        if (!tb_dados_adicionais.Text.Contains("Linha " + linha.ToString()) && empresalabel.Text.Contains("DOKINOS"))
                            texto = texto + " Linha " + linha.ToString() + " Red: " + dgvItens_nota.Rows[j].Cells["col_reducao"].Value.ToString() +
                            " Aliq.: " + dgvItens_nota.Rows[j].Cells["col_icms"].Value.ToString() + "/";
                    }

                }
                string texto_anterior = tb_dados_adicionais.Text;
                string[] newLines = new string[2];
                newLines[0] = texto_anterior;
                newLines[1] = texto;
                tb_dados_adicionais.Lines = newLines;
            }
        }

        private void verificar_se_simples()
        {
            if (tb_dados_adicionais.Text.Contains("I - DOCUMENTO EMITIDO POR ME OU EPP OPTANTE PELO SIMPLES NACIONAL") == false)
            {
                if (empresa_simples())
                {
                    string texto_anterior = tb_dados_adicionais.Text;
                    string[] newLines = new string[3];
                    newLines[0] = "I - DOCUMENTO EMITIDO POR ME OU EPP OPTANTE PELO SIMPLES NACIONAL";
                    newLines[1] = "II - NÃO GERA DIREITO A CRÉDITO FISCAL DE ISS E DE IPI";
                    newLines[2] = texto_anterior;
                    tb_dados_adicionais.Lines = newLines;
                }
            }
        }

        private void verificar_aproveitamento_credito()
        {
            if (tb_dados_adicionais.Text.Contains("III - PERMITE O APROVEITAMENTO DO CRÉDITO DE ICMS") == false)
            {
                if (aproveita_credito())
                {
                    string texto_anterior = tb_dados_adicionais.Text;
                    string[] newLines = new string[2];
                    newLines[0] = "III - PERMITE O APROVEITAMENTO DO CRÉDITO DE ICMS NO VALOR DE R$ " + tb_valor_simples.Text +
                        ", CORRESPONDENTE À ALIQUOTA DE " + tb_aliquota_simples.Text + " % NOS TERMOS DO ART. 23 DA LC 123";
                    newLines[1] = texto_anterior;
                    tb_dados_adicionais.Lines = newLines;
                }
            }


        }

        private bool aproveita_credito()
        {
            try
            {
                FbCommand select_empresa = new FbCommand();
                select_empresa.Connection = fbConnection1;
                fbConnection1.Open();
                select_empresa.CommandText = "SELECT ST_ITEM FROM ITENS_NOTA WHERE NF_ITEM = " + tb_n_nf.Text;
                DataSet empresa = new DataSet();
                FbDataAdapter datEmpresa2 = new FbDataAdapter();
                datEmpresa2.SelectCommand = select_empresa;
                datEmpresa2.Fill(empresa);
                bool resultado = false;
                foreach (DataRow dr in empresa.Tables[0].Rows)
                {
                    if (dr[0].ToString() == "101" || dr[0].ToString() == "201")
                        resultado = true;
                }
                fbConnection1.Close();
                return resultado;
            }
            catch
            {
                fbConnection1.Close();
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

        public void criar_codigo_barras()
        {
            try
            {
                SaveFileDialog file = new SaveFileDialog();
                file.FileName = "c:\\evolucao\\NFE\\COD_BARRAS\\bar.jpg";
                BarcodeLib.Barcode bar = new BarcodeLib.Barcode();
                bar.Encode(BarcodeLib.TYPE.CODE128, tb_chave_acesso_nfe.Text);
                pb_codigo.Image = bar.Encode(BarcodeLib.TYPE.CODE128, tb_chave_acesso_nfe.Text, 300, 150);
                bar.SaveImage(file.FileName, BarcodeLib.SaveTypes.JPG);
            }
            catch
            {
                MessageBox.Show("1");
            }
        }

        public Boolean criar_arquivo_xml(String Name)
        {
            StreamWriter Arquivo;

            try
            {

                Arquivo = new StreamWriter("c:\\evolucao\\NFE\\XML\\" + Name);


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

        private void button10_Click(object sender, EventArgs e)
        {
            string _msgResultado, _erroXML;
            int _qtdErros;
            string arquivo;
            string caminho = "c:\\evolucao\\NFE\\XML\\NFE" + tb_n_nf.Text + ".xml";
            StreamReader objReader = new StreamReader(caminho);
            ArrayList arrText = new ArrayList();
            arquivo = objReader.ReadToEnd();
            objReader.Close();
            int resultado = util2.ValidaXML(arquivo, 1, out _msgResultado, out _qtdErros, out _erroXML);
            MessageBox.Show(resultado.ToString());
            MessageBox.Show(_msgResultado + " - " + _qtdErros.ToString() + " - " + _erroXML);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            bool ok = false;
            enviar_nfe(out ok);

        }
        private void enviar_nfe(out bool ok)
        {
            ok = false;
            if (tb_chave_acesso_nfe.Text != "")
            {
                bt_enviarNFe.Enabled = false;
                if (_enviar == false)
                {
                    if (tb_recibo.Text == "")
                    {
                        _enviar = true;

                        string proxy = proxy_empresa;
                        string usuario = usuario_proxy_empresa;
                        string senha = senha_proxy_empresa;
                        string licenca = licenca_dll_nfe_empresa;
                        string nomeCertificado = nome_certificado_nfe_empresa;
                        string _nroRecibo, _msgCabec, _msgDados, _msgRetWS, _msgResultado, _NFeAssinada;
                        string arquivo = "";
                        string caminho = "c:\\evolucao\\NFE\\XML\\NFE" + tb_n_nf.Text + ".xml";
                        StreamReader objReader = new StreamReader(caminho);
                        ArrayList arrText = new ArrayList();
                        arquivo = objReader.ReadToEnd();
                        objReader.Close();
                        int resultado = 0;
                        int _cStat = 0;
                        string _dhRecbto = "";
                        string tMed = "";

                        string wsuf = "SP";// "SP3";
                        if (estado_empresa != "SP")
                            wsuf = "SVRS";
                        string _xml = util2.EnviaNFe2G(wsuf, ref arquivo, nomeCertificado, "4.00" /*("3.10"*/, out _msgDados,
                        out _msgRetWS, out _cStat, out _msgResultado, out _nroRecibo, out _dhRecbto, out tMed,
                        proxy, usuario, senha, licenca);
                        resultado = _cStat;
                        /*
                        string wsuf = "SP3";
                        if (estado_empresa != "SP")
                            wsuf = "SVRS";

                        string _xml = util2.EnviaNFe2G(wsuf, ref arquivo, nomeCertificado, "3.10", out _msgDados,
                            out _msgRetWS, out _cStat, out _msgResultado, out _nroRecibo, out _dhRecbto, out tMed,
                            proxy, usuario, senha, licenca);
                        resultado = _cStat;*/
                        //int resultado = util.EnviaNFeSCAN(estado_empresa, ref arquivo, out _nroRecibo, nomeCertificado, out _msgCabec, out _msgDados, out _msgRetWS, out _msgResultado, out _NFeAssinada, proxy, usuario, senha, licenca);

                        if (resultado == 103)
                        {
                            barra_status.Text = "NFe enviada com sucesso. Consulte o Status para autorizá-la";
                            gbNfe.BackColor = Color.Orange;
                            tb_status_nfe.Text = "NFe enviada com sucesso. Consulte o Status para autorizá-la";
                            salvar_xml_assinado(_xml);
                            tb_recibo.Text = _nroRecibo;
                            //DateTime data_hora = new DateTime();


                            Atualizar(false);
                            _enviar = false;
                            ok = true;
                        }
                        else
                        {
                            MessageBox.Show(_msgResultado, resultado.ToString());
                            _enviar = false;
                        }

                    }
                    else
                    {
                        MessageBox.Show("Essa NF já foi enviada");
                    }
                }
                else
                {
                    MessageBox.Show("Aguarde");
                }
                bt_enviarNFe.Enabled = true;
            }
            else
                MessageBox.Show("É necessário gerar o XML para enviar o arquivo");
        }
        private void apagar_itens_cr()
        {
            try
            {
                //VERIFICAR EMPRESA QUE ESTÁ EXCLUINDO O CR URGENTE!!!
                this.datContas_a_receber.UpdateCommand.CommandText =
                "UPDATE CONTAS_A_RECEBER SET CANCELADO_CR = 1, OBSERVACOES_CR = 'CANCELADA PELA NF' WHERE NF_CR = '" + tb_n_nf.Text + "' AND ORIGEM_CR = 'NF' AND PESSOA_CR = '" + cod_empresa + "' ";
                this.fbConnection1.Open();
                this.datContas_a_receber.UpdateCommand.Connection = fbConnection1;
                this.datContas_a_receber.UpdateCommand.ExecuteNonQuery();
                this.fbConnection1.Close();

                FbCommand update = new FbCommand();
                update.Connection = fbConnection1;
                update.CommandText =
                "UPDATE FATURA_NF SET CR_FATURA = NULL WHERE NF_FATURA = '" + tb_n_nf.Text + "'";
                fbConnection1.Open();
                FbDataAdapter datUpdate = new FbDataAdapter();
                datUpdate.UpdateCommand = update;
                datUpdate.UpdateCommand.ExecuteNonQuery();
                fbConnection1.Close();
                
                /*
                this.datContas_a_receber.DeleteCommand.CommandText =
                "DELETE FROM CONTAS_A_RECEBER WHERE NF_CR = '" + tb_n_nf.Text + "' AND ORIGEM_CR = 'NF'";
                this.fbConnection1.Open();
                this.datContas_a_receber.DeleteCommand.Connection = fbConnection1;
                this.datContas_a_receber.DeleteCommand.ExecuteNonQuery();
                this.fbConnection1.Close();
                 * */
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }
        private void cancelar_cr_origem(string n_nf_origem)
        {
            try
            {
                this.datContas_a_receber.UpdateCommand.CommandText =
                "UPDATE CONTAS_A_RECEBER SET CANCELADO_CR = 1, OBSERVACOES_CR = 'CANCELADA PELA NF', STATUS_CR = 'CANCELADO' WHERE NF_CR = '" + n_nf_origem + "' AND ORIGEM_CR = 'NF' AND PESSOA_CR = '" + cod_empresa + "'";
                this.fbConnection1.Open();
                this.datContas_a_receber.UpdateCommand.Connection = fbConnection1;
                this.datContas_a_receber.UpdateCommand.ExecuteNonQuery();
                this.fbConnection1.Close();
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }


        private void inserir_duplicatas_cr()
        {
            apagar_itens_cr();
            apagar_itens_cr_pedido();
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
                    if (_cod_interno_banco != "" && _cod_interno_banco != "null")
                        _cod_interno_banco = "'" + _cod_interno_banco.Replace("'","") + "'";
                    else
                        _cod_interno_banco = "null";

                    if (_descricao_banco != "" && _descricao_banco != "null")
                        _descricao_banco = "'" + _descricao_banco.Replace("'", "") + "'";
                    else
                        _descricao_banco = "null";

                    int parcela_n = i + 1;

                    string logradouro, bairro, cep, cidade, complemento, numero, uf;
                    double desconto;
                    int desconto_valor, desconto_pontualidade;
                    selecionar_dados_cliente(tb_cnpj_cliente.Text, out logradouro, out bairro, out cep, out cidade,
                        out complemento, out numero, out uf, out desconto, out desconto_valor, out desconto_pontualidade);


                    double valor_boleto = Convert.ToDouble(dgvFatura_nf.Rows[i].Cells["col_valor"].Value.ToString());

                    if (desconto > 0 && desconto_valor == 1)
                    {
                        valor_boleto = valor_boleto - (valor_boleto * desconto / 100);
                    }

                    DateTime data = Convert.ToDateTime(_datas[i]);
                    if (data.DayOfWeek == DayOfWeek.Friday)
                        data = data.AddDays(3);
                    else
                    {
                        if (data.DayOfWeek == DayOfWeek.Saturday)
                            data = data.AddDays(3);

                        else
                        {
                            if (data.DayOfWeek == DayOfWeek.Sunday)
                                data = data.AddDays(2);
                            else
                            {
                                data = data.AddDays(1);
                            }
                        }

                    }



                    this.datContas_a_receber.InsertCommand.CommandText =
                    "INSERT INTO CONTAS_A_RECEBER (VALOR_CR, DATA_PREVISTA_CR, COD_CLIENTE_CR, " +
                    "RAZAO_CLIENTE_CR, DESCRICAO_CR, DUPLICATA_CR, NF_CR, CC_CR, DESCRICAO_CC_CR, ORIGEM_CR, FORMA_PGTO_CR, COD_PLANO_CR, PLANO_CR, PESSOA_CR, STATUS_CR) " +
                      "VALUES ('" + valor_boleto.ToString().Replace(".", "").Replace(",", ".") + "', '" + data.ToShortDateString().Replace("/", ".") +
                  //  "VALUES ('" + _valores[i].Replace(".", "").Replace(",", ".") + "', '" + Convert.ToDateTime(_datas[i]).ToShortDateString().Replace("/", ".") +
                    "', '" + detectar_cod_cliente(tb_cnpj_cliente.Text) + "','" + tb_cliente.Text +
                    "', 'PARCELA " + parcela_n.ToString() + "/" + _n_vencimentos.ToString() + " REF. A NF Nº " + tb_n_nf.Text +
                    "', '" + parcela_n.ToString() + "','" + tb_n_nf.Text + "'," + _cod_interno_banco + "," + _descricao_banco + ",'NF', '" + cb_forma_pgto.Text + "','4101', 'RECEBIMENTO DE CLIENTES','" + cod_empresa + "','LANÇADO') RETURNING COD_CR";
                    this.fbConnection1.Open();
                    this.datContas_a_receber.InsertCommand.Connection = fbConnection1;
                    object _cod_cr = datContas_a_receber.InsertCommand.ExecuteScalar();
                    this.fbConnection1.Close();

                    _descricao_banco = _descricao_banco.Replace("'", "");
                    _cod_interno_banco = _cod_interno_banco.Replace("'", "");

                    update_cr_fatura(_cod[i], _cod_cr);

                }
                catch(Exception a)
                {
                    MessageBox.Show("Erro na inserção da duplicata " + _cod[i].ToString() + ". " + a.Message);
                    fbConnection1.Close();
                }
            }

            selecionar_faturas();

        }

        private void apagar_itens_cr_pedido()
        {
            try
            {
                for (int i = 0; i < dgvPedidos.RowCount; i++)
                {
                    this.datContas_a_receber.DeleteCommand.CommandText =
                    "DELETE FROM CONTAS_A_RECEBER WHERE NF_CR = '" + dgvPedidos.Rows[i].Cells["col_pedido"].Value.ToString() + "' AND ORIGEM_CR = 'PEDIDO'";
                    this.fbConnection1.Open();
                    this.datContas_a_receber.DeleteCommand.Connection = fbConnection1;
                    this.datContas_a_receber.DeleteCommand.ExecuteNonQuery();
                    this.fbConnection1.Close();
                }
                
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }

        private void selecionar_faturas()
        {
            try
            {
                dsFatura_nf.Clear();
                FbCommand select = new FbCommand();
                select.CommandText = "SELECT * FROM FATURA_NF WHERE COD_SISTEMA_NF_FATURA = '" + tb_cod_interno.Text + "'";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                datSelect.Fill(FATURA_NF);
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
                    "UPDATE FATURA_NF SET CR_FATURA = '" + _cod_cr.ToString() + "' WHERE COD_FATURA = '" + cod_fatura + "'";
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

        private void salvar_xml_assinado(string xml_autorizado)
        {

            criar_arquivo_xml("NFE" + tb_n_nf.Text + "_assinadas.xml");
            FileInfo t = new FileInfo("c:\\evolucao\\NFE\\assinadas\\" + "NFE" + tb_n_nf.Text + "_assinadas.xml");
            using (StreamWriter texto = t.CreateText())
            {
                texto.WriteLine(xml_autorizado);
            }


        }

        private void radioEntrada_CheckedChanged(object sender, EventArgs e)
        {
            if (radioEntrada.Checked == true)
                tb_ent_sai_nfe.Text = "0";
        }

        private void radioSaida_CheckedChanged(object sender, EventArgs e)
        {
            if (radioSaida.Checked == true)
                tb_ent_sai_nfe.Text = "1";
        }

        private void inserir_nova_forma_pgto(string ja_escolhida)
        {
            if (tb_total_nota.Text != "")
            {
                if (rb_1410.Checked || rb_5904.Checked || rb_5910.Checked || rb_5949.Checked)
                {
                    cb_forma_pgto.Text = "2 - Outros";
                }
                else
                {
                    form_forma_pgto localiza_forma = new form_forma_pgto();
                    try
                    {
                        localiza_forma.forma_pgto_ja_escolhida = ja_escolhida;
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
                                        localiza_forma.prazo_4, localiza_forma.prazo_5, localiza_forma.prazo_6, localiza_forma.prazo_7, localiza_forma.prazo_8, 
                                        localiza_forma.prazo_9, localiza_forma.prazo_10, localiza_forma.prazo_11, localiza_forma.prazo_12);
                        try
                        {
                            dsFatura_nf.Clear();
                            this.datFatura_nf.SelectCommand.CommandText =
                            //"SELECT * FROM FATURA_NF WHERE NF_FATURA = '" + tb_n_nf.Text + "'";
                            "SELECT * FROM FATURA_NF WHERE COD_SISTEMA_NF_FATURA = '" + tb_cod_interno.Text + "'";
                            this.fbConnection1.Open();
                            this.datFatura_nf.SelectCommand.Connection = fbConnection1;
                            this.datFatura_nf.SelectCommand.ExecuteNonQuery();
                            datFatura_nf.Fill(FATURA_NF);
                            this.fbConnection1.Close();
                        }
                        catch
                        {
                            fbConnection1.Close();
                        }

                    }
                }

            }
            else
                MessageBox.Show("Calcule o valor da Nota antes de inserir a forma de pagamento.");
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
                    MessageBox.Show("Número de parcelas incorreto");
                }
               

                double valor_total = Convert.ToDouble(buscar_valor_faturado());
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

                    double prazo = 0;
                    prazo = Convert.ToDouble(prazos[i]);
                    DateTime data1 = hoje.AddDays(prazo);

                    insere_fatura(prazos[i].ToString(), data1.ToShortDateString().Replace("/", "."), valor_parcela.ToString().Replace(",", "."), tb_n_nf.Text);
                }
                            
                        
                
                //switch (numero_parcelas)
                //{

                //    case 1:
                //        {
                //            double prazo = Convert.ToDouble(prazo_1);
                //            DateTime data1 = hoje.AddDays(prazo);
                //            insere_fatura(prazo_1, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), tb_n_nf.Text);
                //            break;
                //        }

                //    case 2:
                //        {
                //            double prazo = Convert.ToDouble(prazo_1);
                //            DateTime data1 = hoje.AddDays(prazo);
                //            insere_fatura(prazo_1, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), tb_n_nf.Text);
                //            prazo = Convert.ToDouble(prazo_2);
                //            data1 = hoje.AddDays(prazo);
                //            insere_fatura(prazo_2, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), tb_n_nf.Text);
                //            break;
                //        }
                //    case 3:
                //        {
                //            double prazo = Convert.ToDouble(prazo_1);
                //            DateTime data1 = hoje.AddDays(prazo);
                //            insere_fatura(prazo_1, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), tb_n_nf.Text);
                //            prazo = Convert.ToDouble(prazo_2);
                //            data1 = hoje.AddDays(prazo);
                //            insere_fatura(prazo_2, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), tb_n_nf.Text);
                //            prazo = Convert.ToDouble(prazo_3);
                //            data1 = hoje.AddDays(prazo);
                //            insere_fatura(prazo_3, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), tb_n_nf.Text);
                //            break;
                //        }
                //    case 4:
                //        {
                //            double prazo = Convert.ToDouble(prazo_1);
                //            DateTime data1 = hoje.AddDays(prazo);
                //            insere_fatura(prazo_1, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), tb_n_nf.Text);
                //            prazo = Convert.ToDouble(prazo_2);
                //            data1 = hoje.AddDays(prazo);
                //            insere_fatura(prazo_2, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), tb_n_nf.Text);
                //            prazo = Convert.ToDouble(prazo_3);
                //            data1 = hoje.AddDays(prazo);
                //            insere_fatura(prazo_3, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), tb_n_nf.Text);
                //            prazo = Convert.ToDouble(prazo_4);
                //            data1 = hoje.AddDays(prazo);
                //            insere_fatura(prazo_4, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), tb_n_nf.Text);
                //            break;
                //        }
                //    case 5:
                //        {
                //            double prazo = Convert.ToDouble(prazo_1);
                //            DateTime data1 = hoje.AddDays(prazo);
                //            insere_fatura(prazo_1, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), tb_n_nf.Text);
                //            prazo = Convert.ToDouble(prazo_2);
                //            data1 = hoje.AddDays(prazo);
                //            insere_fatura(prazo_2, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), tb_n_nf.Text);
                //            prazo = Convert.ToDouble(prazo_3);
                //            data1 = hoje.AddDays(prazo);
                //            insere_fatura(prazo_3, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), tb_n_nf.Text);
                //            prazo = Convert.ToDouble(prazo_4);
                //            data1 = hoje.AddDays(prazo);
                //            insere_fatura(prazo_4, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), tb_n_nf.Text);
                //            prazo = Convert.ToDouble(prazo_5);
                //            data1 = hoje.AddDays(prazo);
                //            insere_fatura(prazo_5, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), tb_n_nf.Text);
                //            break;
                //        }
                //    case 6:
                //        {
                //            double prazo = Convert.ToDouble(prazo_1);
                //            DateTime data1 = hoje.AddDays(prazo);
                //            insere_fatura(prazo_1, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), tb_n_nf.Text);
                //            prazo = Convert.ToDouble(prazo_2);
                //            data1 = hoje.AddDays(prazo);
                //            insere_fatura(prazo_2, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), tb_n_nf.Text);
                //            prazo = Convert.ToDouble(prazo_3);
                //            data1 = hoje.AddDays(prazo);
                //            insere_fatura(prazo_3, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), tb_n_nf.Text);
                //            prazo = Convert.ToDouble(prazo_4);
                //            data1 = hoje.AddDays(prazo);
                //            insere_fatura(prazo_4, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), tb_n_nf.Text);
                //            prazo = Convert.ToDouble(prazo_5);
                //            data1 = hoje.AddDays(prazo);
                //            insere_fatura(prazo_5, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), tb_n_nf.Text);
                //            prazo = Convert.ToDouble(prazo_6);
                //            data1 = hoje.AddDays(prazo);
                //            insere_fatura(prazo_6, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), tb_n_nf.Text);
                //            break;
                //        }



                //}
            }
            catch { }

        }

        //comentei pois estava dando probblema quando fazia nota de industrializacao e retorno juntas 03/02/2021
        //private void acertar_faturas(string n_parcelas, string prazo_1, string prazo_2, string prazo_3,
        //    string prazo_4, string prazo_5, string prazo_6)
        //{

        //    int numero_parcelas = 0;
        //    DateTime hoje = DateTime.Now;
        //    if (tb_saida.Text != "")
        //        hoje = Convert.ToDateTime(tb_saida.Text);
        //    //hoje = DateTime.Now;
        //    try
        //    {
        //        numero_parcelas = Convert.ToInt32(n_parcelas);
        //    }
        //    catch
        //    {
        //        numero_parcelas = 0;
        //        //MessageBox.Show("Número de parcelas incorreto");
        //    }

        //    decimal valor = 0;
        //    try
        //    {
        //        valor = Convert.ToDecimal(((Convert.ToDecimal(tb_total_nota.Text) - Convert.ToDecimal(tb_valor_icm_st.Text)) / numero_parcelas).ToString("n2")); // buscar_valor_faturado() / numero_parcelas;
        //    }
        //    catch { }
        //    switch (numero_parcelas)
        //    {

        //        case 1:
        //            {
        //                decimal st = 0;
        //                try
        //                {
        //                    st = Convert.ToDecimal(tb_valor_icm_st.Text);
        //                }
        //                catch { }
        //                double prazo = Convert.ToDouble(prazo_1);
        //                decimal diferenca = 0;
                       
        //                //try
        //                //{
        //                //    decimal valorProdutos = (Convert.ToDecimal(tb_total_nota.Text) - Convert.ToDecimal(tb_valor_icm_st.Text));
        //                //    decimal somaParcelas = valor * numero_parcelas;
        //                //    diferenca = valorProdutos - somaParcelas;
        //                //}
        //                //catch { }
        //                decimal valor1 = valor + st + diferenca;
        //                DateTime data1 = hoje.AddDays(prazo);
        //                insere_fatura(prazo_1, data1.ToShortDateString().Replace("/", "."), valor1.ToString().Replace(",", "."), tb_n_nf.Text);
        //                break;
        //            }

        //        case 2:
        //            {

        //                decimal st = 0;
        //                try
        //                {
        //                    st = Convert.ToDecimal(tb_valor_icm_st.Text);
        //                }
        //                catch { }
        //                double prazo = Convert.ToDouble(prazo_1);
        //                decimal diferenca = 0;
        //                //try
        //                //{
        //                //    decimal valorProdutos = Convert.ToDecimal(tb_total_prod.Text);
        //                //    decimal somaParcelas = valor * numero_parcelas;
        //                //    diferenca = valorProdutos - somaParcelas;
        //                //}
        //                //catch { }
        //                decimal valor1 = valor + st + diferenca;
        //                DateTime data1 = hoje.AddDays(prazo);
        //                insere_fatura(prazo_1, data1.ToShortDateString().Replace("/", "."), valor1.ToString().Replace(",", "."), tb_n_nf.Text);
        //                prazo = Convert.ToDouble(prazo_2);
        //                data1 = hoje.AddDays(prazo);
        //                insere_fatura(prazo_2, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), tb_n_nf.Text);
        //                break;
        //            }
        //        case 3:
        //            {
        //                decimal st = 0;
        //                try
        //                {
        //                    st = Convert.ToDecimal(tb_valor_icm_st.Text);
        //                }
        //                catch { }
        //                double prazo = Convert.ToDouble(prazo_1);
        //                decimal diferenca = 0;
        //                //try
        //                //{
        //                //    decimal valorProdutos = Convert.ToDecimal(tb_total_prod.Text);
        //                //    decimal somaParcelas = valor * numero_parcelas;
        //                //    diferenca = valorProdutos - somaParcelas;
        //                //}
        //                //catch { }
        //                decimal valor1 = valor + st + diferenca;
        //                DateTime data1 = hoje.AddDays(prazo);
        //                insere_fatura(prazo_1, data1.ToShortDateString().Replace("/", "."), valor1.ToString().Replace(",", "."), tb_n_nf.Text);
        //                prazo = Convert.ToDouble(prazo_2);
        //                data1 = hoje.AddDays(prazo);
        //                insere_fatura(prazo_2, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), tb_n_nf.Text);
        //                prazo = Convert.ToDouble(prazo_3);
        //                data1 = hoje.AddDays(prazo);
        //                insere_fatura(prazo_3, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), tb_n_nf.Text);
        //                break;
        //            }
        //        case 4:
        //            {
        //                decimal st = 0;
        //                try
        //                {
        //                    st = Convert.ToDecimal(tb_valor_icm_st.Text);
        //                }
        //                catch { }
        //                double prazo = Convert.ToDouble(prazo_1);
        //                decimal diferenca = 0;
        //                try
        //                {
        //                    decimal valorProdutos = Convert.ToDecimal(tb_total_prod.Text);
        //                    decimal somaParcelas = valor * numero_parcelas;
        //                    diferenca = valorProdutos - somaParcelas;
        //                }
        //                catch { }
        //                decimal valor1 = valor + st + diferenca;
        //                DateTime data1 = hoje.AddDays(prazo);
        //                insere_fatura(prazo_1, data1.ToShortDateString().Replace("/", "."), valor1.ToString().Replace(",", "."), tb_n_nf.Text);
        //                prazo = Convert.ToDouble(prazo_2);
        //                data1 = hoje.AddDays(prazo);
        //                insere_fatura(prazo_2, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), tb_n_nf.Text);
        //                prazo = Convert.ToDouble(prazo_3);
        //                data1 = hoje.AddDays(prazo);
        //                insere_fatura(prazo_3, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), tb_n_nf.Text);
        //                prazo = Convert.ToDouble(prazo_4);
        //                data1 = hoje.AddDays(prazo);
        //                insere_fatura(prazo_4, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), tb_n_nf.Text);
        //                break;
        //            }
        //        case 5:
        //            {
        //                decimal st = 0;
        //                try
        //                {
        //                    st = Convert.ToDecimal(tb_valor_icm_st.Text);
        //                }
        //                catch { }
        //                double prazo = Convert.ToDouble(prazo_1);
        //                decimal diferenca = 0;
        //                try
        //                {
        //                    decimal valorProdutos = Convert.ToDecimal(tb_total_prod.Text);
        //                    decimal somaParcelas = valor * numero_parcelas;
        //                    diferenca = valorProdutos - somaParcelas;
        //                }
        //                catch { }
        //                decimal valor1 = valor + st + diferenca;
        //                DateTime data1 = hoje.AddDays(prazo);
        //                insere_fatura(prazo_1, data1.ToShortDateString().Replace("/", "."), valor1.ToString().Replace(",", "."), tb_n_nf.Text);
        //                prazo = Convert.ToDouble(prazo_2);
        //                data1 = hoje.AddDays(prazo);
        //                insere_fatura(prazo_2, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), tb_n_nf.Text);
        //                prazo = Convert.ToDouble(prazo_3);
        //                data1 = hoje.AddDays(prazo);
        //                insere_fatura(prazo_3, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), tb_n_nf.Text);
        //                prazo = Convert.ToDouble(prazo_4);
        //                data1 = hoje.AddDays(prazo);
        //                insere_fatura(prazo_4, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), tb_n_nf.Text);
        //                prazo = Convert.ToDouble(prazo_5);
        //                data1 = hoje.AddDays(prazo);
        //                insere_fatura(prazo_5, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), tb_n_nf.Text);
        //                break;
        //            }
        //        case 6:
        //            {
        //                decimal st = 0;
        //                try
        //                {
        //                    st = Convert.ToDecimal(tb_valor_icm_st.Text);
        //                }
        //                catch { }
        //                double prazo = Convert.ToDouble(prazo_1);
        //                decimal diferenca = 0;
        //                try
        //                {
        //                    decimal valorProdutos = Convert.ToDecimal(tb_total_prod.Text);
        //                    decimal somaParcelas = valor * numero_parcelas;
        //                    diferenca = valorProdutos - somaParcelas;
        //                }
        //                catch { }
        //                decimal valor1 = valor + st + diferenca;
        //                DateTime data1 = hoje.AddDays(prazo);
        //                insere_fatura(prazo_1, data1.ToShortDateString().Replace("/", "."), valor1.ToString().Replace(",", "."), tb_n_nf.Text);
        //                prazo = Convert.ToDouble(prazo_2);
        //                data1 = hoje.AddDays(prazo);
        //                insere_fatura(prazo_2, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), tb_n_nf.Text);
        //                prazo = Convert.ToDouble(prazo_3);
        //                data1 = hoje.AddDays(prazo);
        //                insere_fatura(prazo_3, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), tb_n_nf.Text);
        //                prazo = Convert.ToDouble(prazo_4);
        //                data1 = hoje.AddDays(prazo);
        //                insere_fatura(prazo_4, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), tb_n_nf.Text);
        //                prazo = Convert.ToDouble(prazo_5);
        //                data1 = hoje.AddDays(prazo);
        //                insere_fatura(prazo_5, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), tb_n_nf.Text);
        //                prazo = Convert.ToDouble(prazo_6);
        //                data1 = hoje.AddDays(prazo);
        //                insere_fatura(prazo_6, data1.ToShortDateString().Replace("/", "."), valor.ToString().Replace(",", "."), tb_n_nf.Text);
        //                break;
        //            }



        //    }

        //}

        

        private decimal buscar_valor_faturado()
        {
            decimal valor_faturado = 0;
            for (int i = 0; i < dgvItens_nota.RowCount; i++)
            {
                try
                {
                    if (verificar_se_e_faturado(dgvItens_nota.Rows[i].Cells["col_cfo"].Value.ToString()) || rb_5202.Checked)
                    {
                        decimal preco_total = 0, ipi = 0, st = 0, frete = 0, desconto = 0, seguro = 0, outras_desp = 0;
                        try
                        {
                            preco_total = Convert.ToDecimal(dgvItens_nota.Rows[i].Cells["col_preco_total"].Value.ToString());
                        }
                        catch { }
                        try
                        {
                            ipi = Convert.ToDecimal(dgvItens_nota.Rows[i].Cells["col_valor_ipi"].Value.ToString());
                        }
                        catch { }
                        try
                        {
                            st = Convert.ToDecimal(dgvItens_nota.Rows[i].Cells["col_valor_st"].Value.ToString());
                        }
                        catch { }
                        try
                        {
                            frete = Convert.ToDecimal(dgvItens_nota.Rows[i].Cells["col_frete"].Value.ToString());
                        }
                        catch
                        { }
                        try
                        {
                            desconto = Convert.ToDecimal(dgvItens_nota.Rows[i].Cells["col_desconto"].Value.ToString());
                        }
                        catch { }
                        try
                        {
                            seguro = Convert.ToDecimal(dgvItens_nota.Rows[i].Cells["col_seguro"].Value.ToString());
                        }
                        catch { }
                        try
                        {
                            outras_desp = Convert.ToDecimal(dgvItens_nota.Rows[i].Cells["col_outras_desp"].Value.ToString());
                        }
                        catch { }
                        valor_faturado = valor_faturado + preco_total + ipi + st + frete + seguro + outras_desp - desconto;

                    }
                }
                catch { }


            }
            return valor_faturado;
        }

        private bool verificar_se_e_faturado(string cfo)
        {
            if (verificar_se_e_tributada(cfo))
                return true;
            else
                return false;
        }
        private void insere_fatura(string prazo, string data, string valor, string nf)
        {



            
            try
            {
                this.datFatura_nf.InsertCommand.CommandText =
                        "INSERT INTO FATURA_NF (PRAZO_FATURA, DATA_VENC_FATURA, VALOR_FATURA, NF_FATURA, COD_SISTEMA_NF_FATURA)" +
                        "VALUES ('" + prazo + "','" + data + "','" + valor + "','" + nf + "','" + tb_cod_interno.Text + "')";
                this.fbConnection1.Open();
                this.datFatura_nf.InsertCommand.Connection = fbConnection1;
                this.datFatura_nf.InsertCommand.ExecuteNonQuery();
                this.fbConnection1.Close();
            }
            catch { fbConnection1.Close(); }


        }

        private void apaga_faturas_anteriores()
        {
            try
            {
                this.datFatura_nf.DeleteCommand.CommandText =
                        "DELETE FROM FATURA_NF WHERE NF_FATURA = '" + tb_n_nf.Text + "'";
                this.fbConnection1.Open();
                this.datFatura_nf.DeleteCommand.Connection = fbConnection1;
                this.datFatura_nf.DeleteCommand.ExecuteNonQuery();
                this.fbConnection1.Close();
            }
            catch { fbConnection1.Close(); }
        }
        /*
        private void dgvItens_nota_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvItens_nota.Columns[e.ColumnIndex].Name == "Trib")
            {
                abrir_tributacao(dgvItens_nota.Rows[e.RowIndex].Cells["col_cod"].Value.ToString(),
                    dgvItens_nota.Rows[e.RowIndex].Cells["col_preco_total"].Value.ToString(),
                    dgvItens_nota.Rows[e.RowIndex].Cells["col_prestacao_servico"].Value.ToString(), e.RowIndex);
            }
            
        }

        private void abrir_tributacao(string item, string valor, string prestacao, int linha)
        {
            form_tributacao trib = new form_tributacao();
            try
            {
                trib.variavel_trib = verificar_variavel_trib();
                trib.cod_variavel_trib = verificar_cod_variavel_trib(verificar_variavel_trib(), linha);
                trib.item_selecionado = item;
                trib.valor_total_prod = valor;
                if (prestacao == "1")
                    trib.prestacao_servico = true;
                trib.selecionar = true;
                
                trib.ShowDialog();

            }
            finally {
                try
                {
                    string valor_ic = trib.valor_icm_item_2;
                    dgvItens_nota.Rows[dgvItens_nota.RowCount - 1].Cells["col_valor_icm"].Value = valor_ic;
                }
                catch
                {
                    dgvItens_nota.Rows[dgvItens_nota.RowCount - 1].Cells["col_valor_icm"].Value = "0";
                }
                try
                {
                    dgvItens_nota.Rows[dgvItens_nota.RowCount - 1].Cells["col_ipi"].Value = trib.ipi_item_2;
                }
                catch
                {
                    dgvItens_nota.Rows[dgvItens_nota.RowCount - 1].Cells["col_ipi"].Value = "0";
                }
                try
                {
                    dgvItens_nota.Rows[dgvItens_nota.RowCount - 1].Cells["col_icms"].Value = trib.icm_item_2;
                }
                catch
                {
                    dgvItens_nota.Rows[dgvItens_nota.RowCount - 1].Cells["col_icms"].Value = "0";
                }
                try
                {
                    dgvItens_nota.Rows[dgvItens_nota.RowCount - 1].Cells["col_valor_bc"].Value = trib.valor_bc_item_2;
                }
                catch
                {
                    dgvItens_nota.Rows[dgvItens_nota.RowCount - 1].Cells["col_valor_bc"].Value = "0";
                }
                string _st = "", _valor_bc_st = "", _valor_st = "", _valor_ipi = "";
                comando_select.CommandText = "SELECT * FROM TRIBUTACAO WHERE COD_NF_TRIB = '" + trib.item_selecionado + "'";
                DataSet _trib = new DataSet();
                fbConnection1.Open();
                datTributacao.SelectCommand = comando_select;
                datTributacao.Fill(_trib);
                int n = 0;
                foreach (DataRow dr in _trib.Tables[0].Rows)
                {

                    _st = dr["ICMS_TRI_ICM"].ToString();
                    _valor_bc_st = dr["ICMS_ST_VAL_BC_ICM"].ToString();
                    _valor_st = dr["ICMS_ST_VAL_ICM"].ToString();
                    _valor_ipi = dr["IPI_VAL_IPI"].ToString();

                }
                fbConnection1.Close(); 
                try
                {
                    dgvItens_nota.Rows[dgvItens_nota.RowCount - 1].Cells["col_st"].Value = _st;
                }
                catch { }
                try
                {
                    if (_valor_bc_st != "")
                    {
                        dgvItens_nota.Rows[dgvItens_nota.RowCount - 1].Cells["col_valor_bc_st"].Value = _valor_bc_st;
                    }
                }
                catch { }
                try
                {
                    if (_valor_st != "")
                    {
                        dgvItens_nota.Rows[dgvItens_nota.RowCount - 1].Cells["col_valor_st"].Value = _valor_st;
                    }

                }
                catch { }
                try
                {
                    if (_valor_ipi != "")
                    {
                        dgvItens_nota.Rows[dgvItens_nota.RowCount - 1].Cells["col_valor_ipi"].Value = _valor_ipi;
                    }

                }
                catch { }

                Atualizar(false);
                //dsItens_nota.Clear();
                //datItens_nota.Fill(ITENS_NOTA);
                trib.Dispose();
                /*
                if (dgvItens_nota.Rows[linha].Cells["col_prestacao_servico"].Value.ToString() == "1")
                {
                    dgvItens_nota.Rows[linha].Cells["col_valor_iss"].Value = trib.valor_iss_item_2;
                }
                else
                {
                    try
                    {
                        string valor_ic = trib.valor_icm_item_2;
                        dgvItens_nota.Rows[linha].Cells["col_valor_icm"].Value = valor_ic;
                    }
                    catch {
                        dgvItens_nota.Rows[linha].Cells["col_valor_icm"].Value = "0";
                    }
                    try
                    {
                        dgvItens_nota.Rows[linha].Cells["col_ipi"].Value = trib.ipi_item_2;
                    }
                    catch {
                        dgvItens_nota.Rows[linha].Cells["col_ipi"].Value = "0";
                    }
                    try
                    {
                        dgvItens_nota.Rows[linha].Cells["col_icms"].Value = trib.icm_item_2;
                    }
                    catch {
                        dgvItens_nota.Rows[linha].Cells["col_icms"].Value = "0";
                    }
                    try
                    {
                        dgvItens_nota.Rows[linha].Cells["col_valor_bc"].Value = trib.valor_bc_item_2;
                    }
                    catch {
                        dgvItens_nota.Rows[linha].Cells["col_valor_bc"].Value = "0";
                    }
                    string _st = "";
                    comando_select.CommandText = "SELECT * FROM TRIBUTACAO WHERE COD_NF_TRIB = '" + trib.item_selecionado + "'";
                    DataSet _trib = new DataSet();
                    fbConnection1.Open();
                    datTributacao.SelectCommand = comando_select;
                    datTributacao.Fill(_trib);
                    int n = 0;
                    foreach (DataRow dr in _trib.Tables[0].Rows)
                    {

                        _st = dr["ICMS_TRI_ICM"].ToString();

                    }
                    fbConnection1.Close(); 
                    dgvItens_nota.Rows[linha].Cells["col_st"].Value = _st;
                    Atualizar(false);
                    //dsItens_nota.Clear();
                   //datItens_nota.Fill(ITENS_NOTA);
                    trib.Dispose();
                }
                 
            }
        }
        */
        private void tb_cfo_peca_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            form_localiza_cfo localiza_cfo = new form_localiza_cfo();
            try
            {
                localiza_cfo.ShowDialog();
            }
            finally
            {
                localiza_cfo.Dispose();
                //MessageBox.Show(localiza_peca.peca_escolhida);
                tb_cfo_peca.Text = localiza_cfo.cfo_escolhida;


            }
        }

        private void br_consultaStatus_Click(object sender, EventArgs e)
        {
            bool ok = false;
            consulta_status(out ok);
        }
        private void consulta_status(out bool ok)
        {
            ok = false;
            if (tb_recibo.Text != "")
            {
                if (tb_protocolo_autorizacao.Text == "")
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
                    string caminho = "c:\\evolucao\\NFE\\assinadas\\" + "NFE" + tb_n_nf.Text + "_assinadas.xml";
                    StreamReader objReader = new StreamReader(caminho);
                    ArrayList arrText = new ArrayList();
                    arquivo = objReader.ReadToEnd();
                    string recibo = tb_recibo.Text;
                    string _dhProtocolo = "";
                    string _nroProtocolo = "";
                    string _cMsg = ""; string _xMsg = "";
                    int cStat = 0;
                    objReader.Close();

                    string wsuf = "SP";// "SP3";
                    if (estado_empresa != "SP")
                        wsuf = "SVRS";
                    string _procNF = util2.BuscaNFe2G(wsuf, ambiente, ref arquivo, recibo, nomeCertificado, "4.00" /*"3.10"*/, out _msgDados,
                    out _msgRetWS, out cStat, out _msgResultado, out _nroProtocolo, out _dhProtocolo, out _cMsg, out _xMsg, proxy, usuario,
                    senha, licenca);
                    /*
                    string wsuf = "SP3";
                    if (estado_empresa != "SP")
                        wsuf = "SVRS";

                    string _procNF = util2.BuscaNFe2G(wsuf, ambiente, ref arquivo, recibo, nomeCertificado, "3.10", out _msgDados,
                        out _msgRetWS, out cStat, out _msgResultado, out _nroProtocolo, out _dhProtocolo, out _cMsg, out _xMsg, proxy, usuario,
                        senha, licenca);*/
                    //int resultado = util2.ConsultaNF2G(estado_empresa, ambiente, nome_certificado_nfe_empresa,"2.00", out _msgDados, out _msgRetWS, out _msgResultado, tb_chave_acesso_nfe.Text, proxy, usuario, senha);
                    //int resultado = util.BuscaNFeSCAN(estado_empresa, ambiente, estado_empresa, ref arquivo, ref recibo, out _procNF, nomeCertificado, out _msgCabec, out _msgDados, out _msgRetWS, out _msgResultado, proxy, usuario, senha, licenca);
                    if (cStat == 0)
                    {
                        barra_status.Text = "Ok";
                        tb_status_nfe.Text = "Ok";
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
                                        criar_codigo_barras();
                                        gerar_xml_autorizada(_procNF);
                                        barra_status.Text = "NFe Autorizada. ";
                                        tb_status_nfe.Text = "NFe Autorizada.";
                                        tb_protocolo_autorizacao.Text = _nroProtocolo;
                                        update_coluna_xml_aut(_procNF, _nroProtocolo, tb_status_nfe.Text, tb_chave_acesso_nfe.Text);
                                        Atualizar(true);
                                        calcular_estoque_mp();
                                        if (tb_ent_sai_nfe.Text == "0" && tb_Nfe_refer.Text != "")
                                        {
                                            cancelar_lotes_nf_origem();
                                            string nf_origem = buscar_nf_origem(tb_Nfe_refer.Text);
                                            cancelar_cr_origem(nf_origem);
                                        }
                                        if (boleto_pedido_empresa != "1")
                                            inserir_duplicatas_cr();
                                        try
                                        {
                                            if (Convert.ToDouble(dgvPedidos.Rows[0].Cells["col_pedido"].Value.ToString()) > 1000000)
                                            { //vem do romaneio
                                                acertar_status_romaneio();
                                            }
                                            else
                                            {
                                                inserir_status_pedido();
                                            }
                                        }
                                        catch { }
                                        //acertarEstoque();


                                        classe_particularidades part = new classe_particularidades();
                                        part.cod_sistema_nf = tb_cod_interno.Text;
                                        part.executar_particularidades(tb_n_nf.Text); //aqui dá baixa nos romaneios e itens_pedido
                                        part.baixar_do_estoque();


                                        gbNfe.BackColor = Color.GreenYellow;
                                        Atualizar(true);
                                        ok = true;
                                        try
                                        {
                                            imprimir();
                                            if (boleto_pedido_empresa != "1")
                                                gerar_boletos();
                                        }
                                        finally
                                        {
                                            enviar_email();
                                            Atualizar(true);
                                            ok = true;
                                        }


                                    }
                                    else
                                    {
                                        MessageBox.Show(_msgResultado, cStat.ToString());
                                        tb_recibo.Text = "";

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
            else
                MessageBox.Show("Antes de Consultar, favor enviar a NFe");
        }

        private void acertar_status_romaneio()
        {
            if (tb_status_nfe.Text.Contains("Autorizad"))
            {
                try
                {
                    FbCommand update = new FbCommand();
                    update.CommandText = "UPDATE LIBERACAO SET BAIXADO_LIB = 1, PEDIDO_BAIXA_LIB = '" + tb_cod_interno.Text + 
                        "' WHERE COD_LIB = '" + dgvPedidos.Rows[0].Cells["col_pedido"].Value.ToString() + "'";
                    update.Connection = fbConnection1;
                    fbConnection1.Open();
                    FbDataAdapter datUpdate = new FbDataAdapter();
                    datUpdate.UpdateCommand = update;
                    datUpdate.UpdateCommand.ExecuteNonQuery();
                    fbConnection1.Close();



                }
                catch(Exception ex)
                {
                    fbConnection1.Close();
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private string buscar_nf_origem(string chave)
        {
            try
            {
                FbCommand selectSaidas = new FbCommand();
                selectSaidas.CommandText = @"SELECT N_NF FROM NOTA_FISCAL WHERE CHAVE_ACESSO_NFE = '" + chave + "'" ;
                selectSaidas.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelectSaidas = new FbDataAdapter();
                datSelectSaidas.SelectCommand = selectSaidas;
                DataTable dtSaidas = new DataTable();
                datSelectSaidas.Fill(dtSaidas);
                fbConnection1.Close();
                foreach (DataRow dr in dtSaidas.Rows)
                {
                    return dr[0].ToString();
                }
                return "";

            }
            catch(Exception ex)
            {
                fbConnection1.Close();
                MessageBox.Show(ex.Message);
                return "";
            }
        }

        private void calcular_estoque_mp()
        {
            try
            {
                FbCommand select = new FbCommand();
                select.CommandText = @"SELECT lr.COD_LR, infent.COD_ITEM_EST_ITEM_ENT FROM ITENS_NOTA inf
                    inner join LOTE_RECEBIMENTO lr on inf.COD_EAN_ITEM = lr.COD_LR 
                    inner join ITENS_NOTA_ENT infent on lr.COD_LR = infent.LOTE_ITEM_ENT 
                    WHERE cfop_item like '_902' and nf_item = '" + tb_n_nf.Text + "'  ORDER BY COD_ITEM";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dt = new DataTable();
                datSelect.Fill(dt);
                fbConnection1.Close();
                foreach (DataRow dr in dt.Rows)
                {
                    calcular_estoque_lote(dr[0].ToString());
                    classeEstoque_material est = new classeEstoque_material();
                    est.fbConnection1.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=10.3.3.4;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=True;Packet Size=8192;Server Type=0";
                    est.calcular_estoque(dr[1].ToString());
                }
               
            }
            catch
            {
                fbConnection1.Close();
            }
        }

        private void calcular_estoque_lote(string lote)
        {
            try
            {
                decimal entrada = 0, saidas = 0, estoque = 0;
                FbCommand select = new FbCommand();
                select.CommandText = @"SELECT infe.QTDE_ITEM_ENT FROM ITENS_NOTA_ENT infe 
                    WHERE lote_item_ent = '" + lote + "'";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dt = new DataTable();
                datSelect.Fill(dt);
                fbConnection1.Close();
                foreach (DataRow dr in dt.Rows)
                {
                    entrada = Convert.ToDecimal(dr[0].ToString());
                }

                FbCommand selectSaidas = new FbCommand();
                selectSaidas.CommandText = @"SELECT sum(infe.QTDE_ITEM) FROM ITENS_NOTA infe 
                    WHERE cod_ean_item = '" + lote + "'";
                selectSaidas.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelectSaidas = new FbDataAdapter();
                datSelectSaidas.SelectCommand = selectSaidas;
                DataTable dtSaidas = new DataTable();
                datSelectSaidas.Fill(dtSaidas);
                fbConnection1.Close();
                foreach (DataRow dr in dtSaidas.Rows)
                {
                    saidas = Convert.ToDecimal(dr[0].ToString());
                }
                estoque = entrada - saidas;

                FbCommand update = new FbCommand();
                update.CommandText = @"UPDATE LOTE_RECEBIMENTO SET QTDE_LR = '" + estoque.ToString().Replace(".", "").Replace(",", ".") + @"' 
                                            WHERE COD_LR = '" + lote + "'";
                update.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datUpdate = new FbDataAdapter();
                datUpdate.UpdateCommand = update;
                datUpdate.UpdateCommand.ExecuteNonQuery();
                fbConnection1.Close();

                FbCommand updateItens = new FbCommand();
                updateItens.CommandText = @"UPDATE ITENS_NOTA_ENT SET QTDE_LOTE_ITEM_ENT = '" + estoque.ToString().Replace(".", "").Replace(",", ".") + @"' 
                                            WHERE LOTE_ITEM_ENT = '" + lote + "'";
                updateItens.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datUpdateItens = new FbDataAdapter();
                datUpdateItens.UpdateCommand = updateItens;
                datUpdateItens.UpdateCommand.ExecuteNonQuery();
                fbConnection1.Close();

            }
            catch(Exception ex)
            {
                fbConnection1.Close();
                MessageBox.Show(ex.Message);
            }
        }


        private void update_coluna_xml_cancelado(string procCTe, string chave_acesso)
        {
            try
            {
                fbConnection1.Open();
                FbTransaction trans = fbConnection1.BeginTransaction();
                fbConnection1.Close();
                FbCommand update = new FbCommand("UPDATE NOTA_FISCAL SET XML_CANCELADO_NF = ? " +
                    "WHERE CHAVE_ACESSO_NFE = ?", fbConnection1, trans);
                update.Parameters.AddWithValue("XML_CANCELADO_NF", procCTe);
                update.Parameters.AddWithValue("CHAVE_ACESSO_NFE", chave_acesso);
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

        private void update_coluna_xml_aut(string procCTe, string nroProtocolo, string status, string chave_acesso)
        {
            try
            {
                try
                {
                    nroProtocolo = nroProtocolo.Remove(15);
                }
                catch { }

                fbConnection1.Open();
                FbTransaction trans = fbConnection1.BeginTransaction();
                fbConnection1.Close();
                FbCommand update = new FbCommand("UPDATE NOTA_FISCAL SET XML_AUTORIZADO_NF = ?, STATUS_NFE = ?, N_PROTOCOLO_AUTORIZACAO_NF = ? " +
                    "WHERE CHAVE_ACESSO_NFE = ?", fbConnection1, trans);
                update.Parameters.AddWithValue("XML_AUTORIZADO_NF", procCTe);
                update.Parameters.AddWithValue("STATUS_NFE", status);
                update.Parameters.AddWithValue("N_PROTOCOLO_AUTORIZACAO_NF", nroProtocolo);
                update.Parameters.AddWithValue("CHAVE_ACESSO_NFE", chave_acesso);
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

        private void acertarEstoque()
        {
            classeEstoque estoque = new classeEstoque();

            for (int i = 0; i < dgvItens_nota.Rows.Count; i++)
            {
                estoque.acertarEstoqueProdutos(dgvItens_nota.Rows[i].Cells["col_ean"].Value.ToString());
            }
        }

        private void inserir_status_pedido()
        {
            for (int p = 0; p < dgvPedidos.RowCount; p++)
            {
                if (tb_status_nfe.Text.Contains("Autorizada"))
                {
                    try
                    {
                        FbCommand update = new FbCommand();
                        update.Connection = fbConnection1;
                        update.CommandText =
                            "UPDATE PEDIDOS_VENDA SET NF_PED_VENDA = '1', N_NF_PED_VENDA = '" + tb_n_nf.Text + "', DATA_NF_PED_VENDA = '" + 
                            DateTime.Now.ToShortDateString().Replace("/",".") + "', STATUS_PED_VENDA = 'Faturado' WHERE COD_PED_VENDA = '" + dgvPedidos.Rows[p].Cells["col_pedido"].Value.ToString() + "'";
                        FbDataAdapter datUpdate = new FbDataAdapter();
                        fbConnection1.Open();
                        datUpdate.UpdateCommand = update;
                        datUpdate.UpdateCommand.ExecuteNonQuery();
                        fbConnection1.Close();
                    }
                    catch
                    {
                        fbConnection1.Close();
                        MessageBox.Show("Erro na baixa do pedido");
                    }
                }
                else
                {
                    try
                    {
                        FbCommand update = new FbCommand();
                        update.Connection = fbConnection1;
                        update.CommandText =
                            "UPDATE PEDIDOS_VENDA SET NF_PED_VENDA = '0', N_NF_PED_VENDA = null, DATA_NF_PED_VENDA = null, STATUS_PED_VENDA = 'Confirmado' WHERE COD_PED_VENDA = '" + dgvPedidos.Rows[p].Cells["col_pedido"].Value.ToString() + "'";
                        FbDataAdapter datUpdate = new FbDataAdapter();
                        fbConnection1.Open();
                        datUpdate.UpdateCommand = update;
                        datUpdate.UpdateCommand.ExecuteNonQuery();
                        fbConnection1.Close();
                    }
                    catch
                    {
                        fbConnection1.Close();
                        MessageBox.Show("Erro no cancelamento da baixa do pedido");
                    }
                }
            }
        }

        private void gerar_xml_autorizada(string xml_autorizado)
        {
            FileInfo t = new FileInfo("c:\\evolucao\\NFE\\autorizadas\\" + "NFE" + tb_chave_acesso_nfe.Text + ".xml");
            using (StreamWriter texto = t.CreateText())
            {
                texto.WriteLine(xml_autorizado);
            }
        }

        private void enviar_email()
        {


            string _caminho_arquivo = "c:\\evolucao\\NFE\\autorizadas\\" + "NFE" + tb_chave_acesso_nfe.Text + ".xml";
            if (!File.Exists(_caminho_arquivo))
            {
                string _xml_autorizado = buscar_xml_autorizado(tb_chave_acesso_nfe.Text);
                if (_xml_autorizado != "")
                    gerar_xml_autorizada(_xml_autorizado);
                else
                    MessageBox.Show("XML não encontrado");
            }
            string _caminho_danfe = "c:\\evolucao\\NFE\\DANFES\\DANFE_NFE_" + tb_n_nf.Text + ".pdf";
            string _caminho_boleto = @"c:\\evolucao\\NFE\\BOLETOS\\BOLETO_NFE_" + tb_n_nf.Text + ".pdf";

            if (empresalabel.Text.ToUpper().Contains("LLOC"))
            {
                _caminho_boleto = "";
            }
            //var assunto
            string _assunto = assunto_nfe_email_empresa + " " + tb_chave_acesso_nfe.Text;
            double _valor_total = Convert.ToDouble(tb_total_nota.Text);
            string _mensagem = "<html xmlns:v='urn:schemas-microsoft-com:vml'" +
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
"<p class=MsoPlainText><span style='font-family:'Comic Sans MS''>Prezado cliente,<o:p></o:p></span></p> " +
"<p class=MsoPlainText><span style='font-family:'Comic Sans MS''><o:p>&nbsp;</o:p></span></p>" +
"<p class=MsoPlainText><span style='font-family:'Comic Sans MS''>Segue anexo a Nota Fiscal Eletrônica em XML sob n.: <o:p></o:p></span></p>" +
"<p class=MsoPlainText><span class=GramE><span style='font-family:'Comic Sans MS';color:red'>" + tb_chave_acesso_nfe.Text + "</span><span" +
"style='font-family:'Comic Sans MS''>, série " + serie_empresa + "</span></span><span style='font-family:'Comic Sans MS''> de " + razao_social_empresa + ", no valor de R$ <span style='color:red'>" + _valor_total.ToString("n2") + ". </span><br> O DANFE segue em PDF e fisicamente com a mercadoria.<br><br><o:p></o:p></span></p>" +
        "<p class=MsoPlainText><span style='font-family:'Comic Sans MS''>Atenciosamente,<o:p></o:p></span></p>" +
"<p class=MsoNormal><span style='font-size:10.0pt;font-family:'Comic Sans MS';" +
"mso-bidi-font-family:Arial'><o:p>&nbsp;</o:p></span></p>" +
"<p class=MsoNormal><span style='font-size:10.0pt;font-family:'Comic Sans MS';" +
"mso-no-proof:yes'>_________________________<br>" +
"Setor de Faturamento<br>" +
"Tel: " + telefone_empresa + "<br>" +
"e-mail: <a href='mailto:" + email_nfe_empresa + "'>" + email_nfe_empresa + "</a><br>" +
"</div>" +
"</body>" +
"</html>";
            Email novo_email = new Email();
            bool _erro;
            //var smtp, email, senha_email
            novo_email.EnviarEmail(detectar_email(), _assunto, _mensagem, _caminho_arquivo, _caminho_danfe, _caminho_boleto,
            email_nfe_empresa, senha_email_nfe_empresa, smtp_nfe_empresa, out _erro, tb_cnpj_cliente.Text);

            if (_erro == false)
            {
                barra_status.Text = barra_status.Text + "Email enviado com sucesso. ";
            }
            else
            {
                barra_status.Text = barra_status.Text + "Email não enviado. Favor verificar dados. ";
            }
        }

        private string buscar_xml_autorizado(string chave)
        {
            try
            {
                FbCommand select = new FbCommand();
                select.CommandText =
                    "SELECT XML_AUTORIZADO_NF FROM NOTA_FISCAL WHERE CHAVE_ACESSO_NFE = '" + chave + "'";
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
            catch (Exception a)
            {
                fbConnection1.Close();
                return "";
            }
        }


        private string detectar_email()
        {
            FbCommand comando = new FbCommand();
            comando.Connection = fbConnection1;
            comando.CommandText =
                "SELECT EMAIL " +
                "FROM CLIENTES WHERE CNPJ = '" + tb_cnpj_cliente.Text + "'";
            DataSet cliente = new DataSet();
            fbConnection1.Open();
            datClientes.SelectCommand = comando;
            datClientes.Fill(cliente);
            string cliente_atual = "";
            foreach (DataRow dr in cliente.Tables[0].Rows)
            {

                cliente_atual = dr["EMAIL"].ToString();
            }

            this.fbConnection1.Close();
            return cliente_atual;

        }

        private void bt_imprimirNFe_Click(object sender, EventArgs e)
        {
            imprimir();

            // imprimir_boleto();
        }

        private void imprimir()
        {
            
            crNfe nova_nota = new crNfe();
            crNfe_paisagemMorais nova_nota_morais = new crNfe_paisagemMorais();
            crNfe_paisagemEntrelux nova_nota_entrelux = new crNfe_paisagemEntrelux();
            form_imprimir imprime;// = new form_imprimir(nova_nota);
            if (razao_social_empresa.Contains("MORAIS"))
                imprime = new form_imprimir(nova_nota_morais);
            else
            {
                if (verificarSeNotaEntrelux(dgvItens_nota.Rows[0].Cells["col_cod_op"].Value.ToString()))
                {
                    imprime = new form_imprimir(nova_nota_entrelux);
                }
                else
                {
                    imprime = new form_imprimir(nova_nota);
                }
            }
            try
            {

                if (tb_protocolo_autorizacao.Text == "")
                {
                    MessageBox.Show("Não é possível imprimir uma nota que não está autorizada");
                }
                else
                {

                    if (cb_forma_pgto.Text[0].ToString() == "1" || cb_forma_pgto.Text[0].ToString() == "0")
                    {
                        string valor_total = buscar_valor_faturado().ToString("n2");
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

                    inserir_cst_impressao();

                    this.datNota_fiscal.UpdateCommand.CommandText =
                                "UPDATE NOTA_FISCAL SET NOTA_STRING_NF = '" + numero_nf(9, tb_n_nf.Text) + "' WHERE N_NF = " + tb_n_nf.Text + "";
                    this.fbConnection1.Open();
                    this.datNota_fiscal.UpdateCommand.Connection = fbConnection1;
                    this.datNota_fiscal.UpdateCommand.ExecuteNonQuery();
                    this.fbConnection1.Close();

                    detectar_dados_cliente(tb_cnpj_cliente.Text);
                    /*
                    if (tb_natureza_operacao.Text.Contains("VENDA") == true )
                    {
                        inserir_simples(tb_n_nf.Text);
                    }

                    else
                    {
                        apagar_simples(tb_n_nf.Text);
                    }
                    */
                    dsCfo.Clear();
                    dsTransportadoras.Clear();
                    this.datTransportadoras.SelectCommand.CommandText =
                        "SELECT * FROM TRANSPORTADORAS WHERE RAZAO_SOCIAL_TRANSPORTADORA = '" + tb_transportadora.Text + "'";
                    this.fbConnection1.Open();
                    this.datTransportadoras.SelectCommand.Connection = fbConnection1;
                    this.datTransportadoras.SelectCommand.ExecuteNonQuery();
                    this.fbConnection1.Close();
                    dsImprimir_op imprimir = new dsImprimir_op();
                    fbConnection1.Open();
                    datTransportadoras.Fill(imprimir.TRANSPORTADORAS);


                    fbConnection1.Close();

                    FbCommand comando = new FbCommand();
                    comando.Connection = fbConnection1;
                    comando.CommandText = "SELECT * FROM EMPRESA where LICENCA_DLL_NFE_EMPRESA is not null AND CNPJ_EMPRESA = '" + cnpj_empresa + "' ";
                    DataSet empresa = new DataSet();
                    fbConnection1.Open();
                    datEmpresa.SelectCommand = comando;
                    datEmpresa.Fill(imprimir.EMPRESA);
                    fbConnection1.Close();

                    FbCommand comando1 = new FbCommand();
                    comando1.Connection = fbConnection1;
                    comando1.CommandText = "SELECT * FROM CLIENTES where CNPJ = '" + tb_cnpj_cliente.Text + "'";
                    fbConnection1.Open();
                    FbDataAdapter datClientes1 = new FbDataAdapter();
                    datClientes1.SelectCommand = comando1;
                    datClientes1.Fill(imprimir.CLIENTES);
                    fbConnection1.Close();

                    //FbCommand comando2 = new FbCommand();
                    //comando2.Connection = fbConnection1;
                    //comando2.CommandText = "SELECT * FROM PRODUTOS";
                    //fbConnection1.Open();
                    //FbDataAdapter datProdutos = new FbDataAdapter();
                    //datProdutos.SelectCommand = comando2;
                    //datProdutos.Fill(imprimir.PRODUTOS);
                    //fbConnection1.Close();

                    //datEmpresa.Fill(imprimir.EMPRESA);
                    //Pedidos da nota
                    //   "SELECT * FROM PEDIDOS_NF WHERE COD_SISTEMA_PEDIDO_NF = '" + tb_cod_interno.Text + "'";
                    imprimir.PEDIDOS_NF.Clear();
                    try
                    {
                        datPedidos_nf.SelectCommand.CommandText =
                            "SELECT pnf.*, pv.vendedor_ped_venda, pv.N_PED_VENDA " +
                            "FROM PEDIDOS_NF pnf " +
                            "INNER JOIN pedidos_venda pv " +
                            "ON pv.cod_ped_venda = pnf.COD_SISTEMA_PEDIDO_NF " +
                            "WHERE COD_SISTEMA_PEDIDO_NF = '" + tb_cod_interno.Text + "'";
                        datPedidos_nf.SelectCommand.Connection = fbConnection1;
                        fbConnection1.Open();
                        datPedidos_nf.SelectCommand.ExecuteNonQuery();
                        datPedidos_nf.Fill(imprimir.PEDIDOS_NF);
                        fbConnection1.Close();
                    }
                    catch (Exception a)
                    {
                        fbConnection1.Close();
                        MessageBox.Show("Não foi possível selecionar os pedidos para a impressão!\nErro: " + a.Message);
                    }


                    this.datNota_fiscal.SelectCommand.CommandText =
                            "SELECT * FROM NOTA_FISCAL WHERE COD_SISTEMA_NF = '" + tb_cod_interno.Text + "'";
                    this.fbConnection1.Open();
                    this.datNota_fiscal.SelectCommand.Connection = fbConnection1;
                    this.datNota_fiscal.SelectCommand.ExecuteNonQuery();
                    datNota_fiscal.Fill(imprimir.NOTA_FISCAL);
                    this.fbConnection1.Close();

                    
                    this.datItens_nota.SelectCommand.CommandText =
                    //"SELECT * FROM ITENS_NOTA WHERE NF_ITEM = '" + tb_n_nf.Text + "' order by cod_itens_nota";
                    "SELECT * FROM ITENS_NOTA WHERE COD_SISTEMA_NF_ITEM = '" + tb_cod_interno.Text + "' order by cod_itens_nota";
                    this.fbConnection1.Open();
                    this.datItens_nota.SelectCommand.Connection = fbConnection1;
                    this.datItens_nota.SelectCommand.ExecuteNonQuery();
                    datItens_nota.Fill(imprimir.ITENS_NOTA);
                    this.fbConnection1.Close();

                    FbCommand select_Nfs = new FbCommand();
                    select_Nfs.Connection = fbConnection1;
                    select_Nfs.CommandText =
                        "SELECT * FROM NFS_REFERENCIADAS WHERE COD_SISTEMA_NF_SAIDA_NFR = '" + tb_cod_interno.Text + "'";
                    FbDataAdapter datSelect = new FbDataAdapter();
                    datSelect.SelectCommand = select_Nfs;
                    datSelect.Fill(imprimir.NFS_REFERENCIADAS);
                    fbConnection1.Close();

                    if (cb_forma_pgto.Text[0].ToString() == "1" || cb_forma_pgto.Text[0].ToString() == "0")
                        datImp_duplicatas.Fill(imprimir.IMP_DUPLICATAS);
                    fbConnection1.Close();
                    //crNfe nova_nota = new crNfe();
                    nova_nota.SetDataSource(imprimir);
                    nova_nota_morais.SetDataSource(imprimir);
                    nova_nota_entrelux.SetDataSource(imprimir);

                    int n_copias = 0;
                    try
                    {
                        n_copias = Convert.ToInt16(tb_n_copias.Text);
                    }
                    catch { }
                    

                    imprime.n_copias = n_copias;
                    imprime.n_nfe = tb_n_nf.Text;
                    imprime.nfe = true;
                    imprime.imprimir_direto = imprimir_nota_e_boleto;
                    // imprime.imprimir_direto = imprimir_nota;
                    if (imprimir_nota_e_boleto)
                    {

                        imprime.ShowDialog();
                    }
                    else
                    {
                        imprime.Show();
                    }
                }
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
            finally
            {
                if (imprimir_nota_e_boleto)
                {
                    nova_nota.Close();
                    nova_nota.Dispose();
                    nova_nota = null;

                    //imprime.Dispose();
                    //imprime.Close();
                    //imprime = null;
                    //Cleanup crystal report's mess in memory
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                }
            }
        }

        private bool verificarSeNotaEntrelux(string cod)
        {
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                select.CommandText =
                    "SELECT NOME_FORNECEDOR_PRODUTO FROM PRODUTOS WHERE COD_FORNECEDOR_PRODUTO = '" + cod + "'";
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();
                foreach(DataRow dr in dtSelect.Rows)
                {
                    if(dr[0].ToString().ToUpper().Contains("ENTRELUX"))
                    {
                        return true;
                    }
                   
                }
                return false;

            }
            catch(Exception ex)
            {
                return false;
            }

            
        }

        private void inserir_cst_impressao()
        {
            if (!empresa_simples())
            {
                for (int q = 0; q < dgvItens_nota.RowCount; q++)
                {
                    try
                    {
                        datItens_nota.UpdateCommand.CommandText =
                            "UPDATE ITENS_NOTA SET ST_IMPRESSAO_ITEM = '" +
                            dgvItens_nota.Rows[q].Cells["col_origem"].Value.ToString() +
                            dgvItens_nota.Rows[q].Cells["col_st"].Value.ToString() +
                            "' WHERE COD_ITENS_NOTA = '" + dgvItens_nota.Rows[q].Cells["col_cod"].Value.ToString() + "'";
                        fbConnection1.Open();
                        datItens_nota.UpdateCommand.Connection = fbConnection1;
                        datItens_nota.UpdateCommand.ExecuteNonQuery();
                        fbConnection1.Close();

                    }
                    catch
                    {
                        fbConnection1.Close();
                    }
                }
            }
            else
            {
                for (int q = 0; q < dgvItens_nota.RowCount; q++)
                {
                    try
                    {
                        datItens_nota.UpdateCommand.CommandText =
                            "UPDATE ITENS_NOTA SET ST_IMPRESSAO_ITEM = '" +
                            dgvItens_nota.Rows[q].Cells["col_st"].Value.ToString() +
                            "' WHERE COD_ITENS_NOTA = '" + dgvItens_nota.Rows[q].Cells["col_cod"].Value.ToString() + "'";
                        fbConnection1.Open();
                        datItens_nota.UpdateCommand.Connection = fbConnection1;
                        datItens_nota.UpdateCommand.ExecuteNonQuery();
                        fbConnection1.Close();

                    }
                    catch
                    {
                        fbConnection1.Close();
                    }
                }
            }
        }

        private bool empresa_simples()
        {
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText = "SELECT CRT_EMPRESA FROM EMPRESA";
                DataSet empresa = new DataSet();
                FbDataAdapter datEmpresa2 = new FbDataAdapter();
                datEmpresa2.SelectCommand = select;
                datEmpresa2.Fill(empresa);
                DataRow dr = empresa.Tables[0].Rows[0];
                fbConnection1.Close();
                if (dr[0].ToString() == "1")
                    return true;
                else
                    return false;
            }
            catch
            {
                fbConnection1.Close();
                return false;
            }
        }

        private void inserir_simples(string numero)
        {
            string _aliquota = "";
            FbCommand comando = new FbCommand();
            comando.Connection = fbConnection1;
            comando.CommandText =
                "SELECT * " +
                "FROM ALIQUOTA_SIMPLES";
            DataSet ali = new DataSet();
            fbConnection1.Open();
            datAliquota.SelectCommand = comando;
            datAliquota.Fill(ali);

            foreach (DataRow dr in ali.Tables[0].Rows)
            {
                _aliquota = dr["VALOR_ALIQUOTA"].ToString();
            }
            fbConnection1.Close();
            double _valor_prod = 0;
            double _valor_aliquota = 0;
            double _valor_com_aliquota = 0;
            try
            {
                _valor_prod = Convert.ToDouble(tb_total_prod.Text);
                _valor_aliquota = Convert.ToDouble(_aliquota); //falta calcular valor com aliquota e inserir no NOTAS_FISCAIS
                _valor_com_aliquota = (_valor_prod * _valor_aliquota) / 100;
            }
            catch
            {

            }

            this.datNota_fiscal.UpdateCommand.CommandText =
                        "UPDATE NOTA_FISCAL SET ALIQUOTA_SIMPLES_NF = '" + _valor_aliquota.ToString("n2").Replace(",", ".") + "' WHERE N_NF = " + numero + "";
            this.fbConnection1.Open();
            this.datNota_fiscal.UpdateCommand.Connection = fbConnection1;
            this.datNota_fiscal.UpdateCommand.ExecuteNonQuery();
            this.fbConnection1.Close();

            this.datNota_fiscal.UpdateCommand.CommandText =
                        "UPDATE NOTA_FISCAL SET VALOR_SIMPLES_NF = '" + _valor_com_aliquota.ToString("n2").Replace(".", "").Replace(",", ".") + "' WHERE N_NF = " + numero + "";
            this.fbConnection1.Open();
            this.datNota_fiscal.UpdateCommand.Connection = fbConnection1;
            this.datNota_fiscal.UpdateCommand.ExecuteNonQuery();
            this.fbConnection1.Close();



        }

        private void apagar_simples(string numero)
        {


            this.datNota_fiscal.UpdateCommand.CommandText =
                        "UPDATE NOTA_FISCAL SET ALIQUOTA_SIMPLES_NF = null WHERE N_NF = " + numero + "";
            this.fbConnection1.Open();
            this.datNota_fiscal.UpdateCommand.Connection = fbConnection1;
            this.datNota_fiscal.UpdateCommand.ExecuteNonQuery();
            this.fbConnection1.Close();

            this.datNota_fiscal.UpdateCommand.CommandText =
                        "UPDATE NOTA_FISCAL SET VALOR_SIMPLES_NF = null WHERE N_NF = " + numero + "";
            this.fbConnection1.Open();
            this.datNota_fiscal.UpdateCommand.Connection = fbConnection1;
            this.datNota_fiscal.UpdateCommand.ExecuteNonQuery();
            this.fbConnection1.Close();



        }

        private string detectar_cod_cliente(string _cnpj)
        {
            string _cod = "";
            FbCommand comando = new FbCommand();
            comando.Connection = fbConnection1;
            comando.CommandText =
                "SELECT * " +
                "FROM CLIENTES WHERE CNPJ = '" + _cnpj + "'";
            DataSet nf = new DataSet();
            fbConnection1.Open();
            datClientes.SelectCommand = comando;
            datClientes.Fill(nf);
            int n = 0;
            foreach (DataRow dr in nf.Tables[0].Rows)
            {

                _cod = dr["COD_CLIENTE"].ToString();

            }
            fbConnection1.Close();
            return _cod;

        }
        private void detectar_dados_cliente(string _cnpj)
        {
            try
            {
                string _endereco = "", _numero = "", _complemento = "", _razao_social = "", _ie = "", _bairro = "", _cidade = "", _estado = "", _pais = "", _cep = "", _fone = "", _email = "";
                FbCommand comando = new FbCommand();
                comando.Connection = fbConnection1;
                comando.CommandText =
                    "SELECT * " +
                    "FROM CLIENTES WHERE CNPJ = '" + _cnpj + "'";
                DataSet nf = new DataSet();
                fbConnection1.Open();
                FbDataAdapter cliente = new FbDataAdapter();
                cliente.SelectCommand = comando;
                cliente.Fill(nf);

                int n = 0;
                foreach (DataRow dr in nf.Tables[0].Rows)
                {

                    _endereco = dr["ENDERECO"].ToString();
                    _numero = dr["NUMERO_CLIENTE"].ToString();
                    _complemento = dr["COMPLEMENTO_CLIENTE"].ToString();
                    _razao_social = dr["RAZAO_SOCIAL"].ToString();
                    _ie = dr["IE"].ToString();
                    _bairro = dr["BAIRRO"].ToString();
                    _cidade = dr["CIDADE"].ToString();
                    _estado = dr["ESTADO"].ToString();
                    _pais = dr["PAIS"].ToString();
                    _cep = dr["CEP_CLIENTE"].ToString();
                    _fone = dr["FONE"].ToString();
                    _email = dr["EMAIL"].ToString();
                }
                fbConnection1.Close();
                this.datNota_fiscal.UpdateCommand.CommandText =
                            "UPDATE NOTA_FISCAL SET END_NUMERO_STRING_NF = '" + _endereco + ", " + _numero + " " + _complemento + "' WHERE N_NF = " + tb_n_nf.Text + "";
                this.fbConnection1.Open();
                this.datNota_fiscal.UpdateCommand.Connection = fbConnection1;
                this.datNota_fiscal.UpdateCommand.ExecuteNonQuery();
                this.fbConnection1.Close();

                this.datNota_fiscal.UpdateCommand.CommandText =
                            "UPDATE NOTA_FISCAL SET RAZAO_SOCIAL_CL_NF = '" + _razao_social + "' WHERE N_NF = " + tb_n_nf.Text + "";
                this.fbConnection1.Open();
                this.datNota_fiscal.UpdateCommand.Connection = fbConnection1;
                this.datNota_fiscal.UpdateCommand.ExecuteNonQuery();
                this.fbConnection1.Close();

                this.datNota_fiscal.UpdateCommand.CommandText =
                            "UPDATE NOTA_FISCAL SET IE_CL_NF = '" + _ie + "' WHERE N_NF = " + tb_n_nf.Text + "";
                this.fbConnection1.Open();
                this.datNota_fiscal.UpdateCommand.Connection = fbConnection1;
                this.datNota_fiscal.UpdateCommand.ExecuteNonQuery();
                this.fbConnection1.Close();

                this.datNota_fiscal.UpdateCommand.CommandText =
                            "UPDATE NOTA_FISCAL SET CNPJ_CL_NF = '" + _cnpj + "' WHERE N_NF = " + tb_n_nf.Text + "";
                this.fbConnection1.Open();
                this.datNota_fiscal.UpdateCommand.Connection = fbConnection1;
                this.datNota_fiscal.UpdateCommand.ExecuteNonQuery();
                this.fbConnection1.Close();

                this.datNota_fiscal.UpdateCommand.CommandText =
                            "UPDATE NOTA_FISCAL SET BAIRRO_CL_NF = '" + _bairro + "' WHERE N_NF = " + tb_n_nf.Text + "";
                this.fbConnection1.Open();
                this.datNota_fiscal.UpdateCommand.Connection = fbConnection1;
                this.datNota_fiscal.UpdateCommand.ExecuteNonQuery();
                this.fbConnection1.Close();

                this.datNota_fiscal.UpdateCommand.CommandText =
                            "UPDATE NOTA_FISCAL SET CIDADE_CL_NF = '" + _cidade + "' WHERE N_NF = " + tb_n_nf.Text + "";
                this.fbConnection1.Open();
                this.datNota_fiscal.UpdateCommand.Connection = fbConnection1;
                this.datNota_fiscal.UpdateCommand.ExecuteNonQuery();
                this.fbConnection1.Close();

                this.datNota_fiscal.UpdateCommand.CommandText =
                            "UPDATE NOTA_FISCAL SET ESTADO_CL_NF = '" + _estado + "' WHERE N_NF = " + tb_n_nf.Text + "";
                this.fbConnection1.Open();
                this.datNota_fiscal.UpdateCommand.Connection = fbConnection1;
                this.datNota_fiscal.UpdateCommand.ExecuteNonQuery();
                this.fbConnection1.Close();

                this.datNota_fiscal.UpdateCommand.CommandText =
                            "UPDATE NOTA_FISCAL SET PAIS_CL_NF = '" + _pais + "' WHERE N_NF = " + tb_n_nf.Text + "";
                this.fbConnection1.Open();
                this.datNota_fiscal.UpdateCommand.Connection = fbConnection1;
                this.datNota_fiscal.UpdateCommand.ExecuteNonQuery();
                this.fbConnection1.Close();

                this.datNota_fiscal.UpdateCommand.CommandText =
                            "UPDATE NOTA_FISCAL SET CEP_CL_NF = '" + _cep + "' WHERE N_NF = " + tb_n_nf.Text + "";
                this.fbConnection1.Open();
                this.datNota_fiscal.UpdateCommand.Connection = fbConnection1;
                this.datNota_fiscal.UpdateCommand.ExecuteNonQuery();
                this.fbConnection1.Close();

                this.datNota_fiscal.UpdateCommand.CommandText =
                            "UPDATE NOTA_FISCAL SET FONE_CL_NF = '" + _fone + "' WHERE N_NF = " + tb_n_nf.Text + "";
                this.fbConnection1.Open();
                this.datNota_fiscal.UpdateCommand.Connection = fbConnection1;
                this.datNota_fiscal.UpdateCommand.ExecuteNonQuery();
                this.fbConnection1.Close();
            }
            catch (Exception a)
            {
                fbConnection1.Close();
            }
        }
        private string end_nf(string _cnpj)
        {
            string _endereco = "", _numero = "";
            FbCommand comando = new FbCommand();
            comando.Connection = fbConnection1;
            comando.CommandText =
                "SELECT ENDERECO, NUMERO_CLIENTE " +
                "FROM CLIENTES WHERE CNPJ = '" + _cnpj + "'";
            DataSet nf = new DataSet();
            fbConnection1.Open();
            FbDataAdapter cliente = new FbDataAdapter();
            cliente.SelectCommand = comando;
            cliente.Fill(nf);
            int n = 0;
            foreach (DataRow dr in nf.Tables[0].Rows)
            {

                _endereco = dr["ENDERECO"].ToString();
                _numero = dr["NUMERO_CLIENTE"].ToString();


            }

            fbConnection1.Close();
            return _endereco + ", " + _numero;
        }


        private string numero_nf(int tamanho_pretendido, string valor)
        {

            int tamanho = valor.Length;
            for (int p = 0; p < tamanho_pretendido - tamanho; p++)
            {
                valor = "0" + valor;
            }
            return valor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form_localiza_cliente localiza_cliente = new form_localiza_cliente(true, cnpj_empresa);
            try
            {
                localiza_cliente.nf = true;
                localiza_cliente.ShowDialog();
            }
            finally
            {
                localiza_cliente.Dispose();
                //MessageBox.Show(localiza_peca.peca_escolhida);
                tb_cnpj_cliente.Text = localiza_cliente.cnpj_escolhido;
                tb_cliente.Text = localiza_cliente.cliente_escolhido;
                tb_estado_cliente.Text = localiza_cliente.estado_escolhido;
                //tb_dados_adicionais.Text = "#C.FISC.: " + tb_class_fiscal.Text + "#" + tb_dados_adicionais.Text;

            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            enviar_email();
        }

        private void bt_cancelarNFe_Click(object sender, EventArgs e)
        {
            if (tb_motivo_cancelamento.Text.Length < 15)
                MessageBox.Show("Digite o motivo do cancelamento com pelo menos 15 caracteres");
            else
            {


                if (tb_protocolo_autorizacao.Text == "")
                    tb_protocolo_autorizacao.Text = buscar_no_xml("c:\\evolucao\\NFE\\autorizadas\\" + "NFE" + tb_chave_acesso_nfe.Text + ".xml", "nProt");
                int ambiente = 2;
                if (cbNfe_teste.Checked == false)
                    ambiente = 1;
                string proxy = proxy_empresa;
                string usuario = usuario_proxy_empresa;
                string senha = senha_proxy_empresa;
                string licenca = licenca_dll_nfe_empresa;
                string nomeCertificado = nome_certificado_nfe_empresa;
                string _msgCabec, _msgDados, _msgRetWS, _msgResultado, _retWS,
                    _nProtocolo_cancelamento, _dProtocolo_cancelamento;
                int resultado = 0;
                /*
                string wsuf = "SP3";
                if (estado_empresa != "SP")
                    wsuf = "SVRS";

                string _xml = util2.CancelaNF2G(wsuf, ambiente, nomeCertificado, "1.00", out _msgDados,
                    out _retWS, out resultado, out _msgResultado, tb_chave_acesso_nfe.Text, tb_protocolo_autorizacao.Text,
                    tb_motivo_cancelamento.Text, out _nProtocolo_cancelamento, out _dProtocolo_cancelamento,
                    proxy, usuario, senha, licenca);
                //int resultado = util.CancelaNFSCAN(estado_empresa, ambiente, nomeCertificado, out _msgCabec, out _msgDados, out _msgRetWS, out _msgResultado, tb_chave_acesso_nfe.Text, tb_protocolo_autorizacao.Text, tb_motivo_cancelamento.Text, proxy, usuario, senha, licenca);
                if (resultado == 101 || resultado == 151 || resultado == 135 || resultado == 155)
                {
                 */
                int cstat = 0;
                string dhEvento = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                string wsuf = "SP";
                if (estado_empresa != "SP")
                    wsuf = "SVRS";
                string _xml = util2.CancelaNFEvento(wsuf, ambiente, nomeCertificado, "4.00"/*"1.00"*/, out _msgDados,
                out _retWS, out cstat, out _msgResultado, tb_chave_acesso_nfe.Text, tb_protocolo_autorizacao.Text,
                tb_motivo_cancelamento.Text, dhEvento, out _nProtocolo_cancelamento, out _dProtocolo_cancelamento,
                proxy, usuario, senha, licenca);
                if (cstat == 135 || cstat == 155)
                {
                    gerar_xml_cancelada(_xml);
                    barra_status.Text = "NFe Cancelada com sucesso";
                    tb_status_nfe.Text = "NFe Cancelada com sucesso";
                    update_coluna_xml_cancelado(_xml, tb_chave_acesso_nfe.Text);
                    cancelar_lotes();
                    inserir_status_pedido();
                    apagar_itens_cr();
                    gbNfe.BackColor = Color.Red;
                    Atualizar(true);
                    /*
                    classe_particularidades part = new classe_particularidades();
                    part.executar_particularidades(tb_n_nf.Text);
                    part.baixar_do_estoque();*/
                }
                else
                {
                    MessageBox.Show(_msgResultado, cstat.ToString());
                    gerar_xml_cancelada(_xml);
                    barra_status.Text = "NFe não foi cancelada. Motivo da rejeição: " + buscar_no_xml("c:\\evolucao\\NFE\\canceladas\\" + "NFE" + tb_chave_acesso_nfe.Text + ".xml", "xMotivo");
                    tb_status_nfe.Text = "NFe não foi cancelada. Motivo da rejeição: " + buscar_no_xml("c:\\evolucao\\NFE\\canceladas\\" + "NFE" + tb_chave_acesso_nfe.Text + ".xml", "xMotivo"); ;

                }
            }
        }

        private void cancelar_lotes_nf_origem()
        {
            try
            {

                FbCommand select = new FbCommand();
                select.CommandText = @"SELECT inf.cod_ean_item, nf.COD_SISTEMA_NF FROM ITENS_NOTA inf 
                    inner join NOTA_FISCAL nf on inf.COD_SISTEMA_NF_ITEM = nf.COD_SISTEMA_NF
                    where nf.CHAVE_ACESSO_NFE = '" + tb_Nfe_refer.Text + "' AND inf.cod_ean_item is not null";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dt = new DataTable();
                datSelect.Fill(dt);
                fbConnection1.Close();

                DataRow dr1 = dt.Rows[0];

                FbCommand update = new FbCommand();
                update.CommandText =
                    "update itens_nota inf set inf.cod_ean_item = null where inf.COD_SISTEMA_NF_ITEM = '" + dr1[1].ToString() + "'";
                update.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datUpdate = new FbDataAdapter();
                datUpdate.UpdateCommand = update;
                datUpdate.UpdateCommand.ExecuteNonQuery();
                fbConnection1.Close();

                foreach (DataRow dr in dt.Rows)
                {
                    calcular_estoque_lote(dr[0].ToString());
                }
            }
            catch (Exception ex)
            {
                fbConnection1.Close();
            }
        }

        private void cancelar_lotes()
        {
            try
            {

                FbCommand select = new FbCommand();
                select.CommandText = @"SELECT cod_ean_item FROM ITENS_NOTA where COD_SISTEMA_NF_ITEM = '" + tb_cod_interno.Text + "' where cod_ean_item is not null";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dt = new DataTable();
                datSelect.Fill(dt);
                fbConnection1.Close();

                FbCommand update = new FbCommand();
                update.CommandText =
                    "update itens_nota inf set inf.cod_ean_item = null where inf.COD_SISTEMA_NF_ITEM = '" + tb_cod_interno.Text + "'";
                update.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datUpdate = new FbDataAdapter();
                datUpdate.UpdateCommand = update;
                datUpdate.UpdateCommand.ExecuteNonQuery();
                fbConnection1.Close();

                foreach (DataRow dr in dt.Rows)
                {
                    calcular_estoque_lote(dr[0].ToString());
                }
               


            }
            catch (Exception ex)
            {
                fbConnection1.Close();
            }
        }

        private void gerar_xml_cancelada(string xml_cancelada)
        {
            FileInfo t = new FileInfo("c:\\evolucao\\NFE\\canceladas\\" + "NFE" + tb_chave_acesso_nfe.Text + ".xml");
            using (StreamWriter texto = t.CreateText())
            {
                texto.WriteLine(xml_cancelada);
            }
        }

        private string buscar_no_xml(string caminho, string no)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(caminho);
            string data;
            XmlNode elementoData;
            //Usar para quando tiver links porque dá senão o xml não lê
            XmlNamespaceManager nsmgr = new XmlNamespaceManager(doc.NameTable);
            nsmgr.AddNamespace("ab", "http://www.portalfiscal.item.br/nfe");
            elementoData = doc.SelectSingleNode("//ab:" + no, nsmgr);
            data = elementoData.InnerText;
            return data;

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            inserir_duplicatas_cr();
        }

        private void button7_Click_2(object sender, EventArgs e)
        {
            tb_recibo.Text = "";
        }

        private void tb_cod_peca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                //string cod = tb_cod_peca.Text;
               // if (cod_forn_empresa == "1")
                string cod = buscar_produto_pelo_cod_fornecedor(tb_cod_peca.Text);
                buscar_produto(cod);
            }
        }

        private string buscar_produto_pelo_cod_fornecedor(string cod)
        {

            try
            {
                FbCommand select = new FbCommand();
                select.CommandText =
                    "SELECT COD_PRODUTO FROM PRODUTOS WHERE COD_FORNECEDOR_PRODUTO = '" + cod + "'";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();
                if (dtSelect.Rows.Count > 1)
                    MessageBox.Show("Existem mais de 1 produto com esse código. Verifique");
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


        private void tb_cod_peca_DoubleClick(object sender, EventArgs e)
        {
            /*
            form_produtos prod = new form_produtos();
            try
            {
                prod.busca = true;
                prod.ShowDialog();
            }
            finally
            {
                prod.Dispose();
                buscar_produto(prod.cod_escolhido);
            }
             * */
        }

        private void rb_nao_tributada_CheckedChanged(object sender, EventArgs e)
        {

            //Atualizar(false);
        }

        private void rb_pecas_CheckedChanged(object sender, EventArgs e)
        {
            //Atualizar(false);
            tb_ncm_peca.Text = "84669410";
        }

        private void rb_terminal_CheckedChanged(object sender, EventArgs e)
        {
            tb_ncm_peca.Text = "85369090";
            // Atualizar(false);
        }

        private void cb_ipi_suspenso_CheckedChanged(object sender, EventArgs e)
        {
            // Atualizar(false);
        }


        private void button8_Click_1(object sender, EventArgs e)
        {
            abre_nova();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (dgvFatura_nf.RowCount > 0 && dgvFatura_nf.Rows[0].Cells["col_cr_fatura"].Value.ToString() != "")
                MessageBox.Show("Já existem Faturas registradas para esse pedido. Para gerar novas faturas você deve cancelá-las antes.");
            else
            {
                inserir_nova_forma_pgto("");
            }
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            buscar_pedido(0);
        }

        private void buscar_pedido(int n_pedido)
        {
            if (dgvPedidos.RowCount > 0)
            {
                MessageBox.Show("Não é possível inserir 2 pedidos na mesma nota. Exclua o outro pedido.");
            }
            else
            {
                if (tb_protocolo_autorizacao.Text != "")
                {
                    MessageBox.Show("Essa nota já está autorizada. Impossível inserir outro pedido");
                }
                else
                {

                    form_pesquisa_pedido ped = new form_pesquisa_pedido(true, cnpj_empresa);
                    try
                    {
                        if (n_pedido == 0)
                        {
                            ped.selecao_nf = true;
                            ped.ShowDialog();
                        }
                        else
                        {
                            ped.numero_pedidos = 1;
                            ped.pedidos_selecionados[0] = n_pedido.ToString();
                        }
                    }
                    finally
                    {
                        string tipo_cliente = buscar_tipo_cliente(tb_cnpj_cliente.Text);

                        if (tipo_cliente == "9999") //não vou usar isso no Silmar
                        {
                            MessageBox.Show("Por favor, selecione o tipo de cliente antes de faturar");
                        }
                        else
                        {
                            string cfop = "";
                            string _forma_pgto_pedido = "";
                            double _porc_desconto = 0;
                            for (int i = 0; i < ped.numero_pedidos; i++)
                            {

                                //Zerando cfop para novo pedido
                                cfop = "0";

                                //Vinculando nf com pedido
                                try
                                {
                                    this.datPedidos_nf.InsertCommand.CommandText =
                                    "INSERT INTO PEDIDOS_NF (NF_PEDIDO_NF, N_PEDIDO_NF, COD_SISTEMA_PEDIDO_NF)" +
                                    "VALUES ('" + tb_n_nf.Text + "','" + ped.pedidos_selecionados[i] + "', " + tb_cod_interno.Text + ")";
                                    this.fbConnection1.Open();
                                    this.datPedidos_nf.InsertCommand.Connection = fbConnection1;
                                    this.datPedidos_nf.InsertCommand.ExecuteNonQuery();
                                    this.fbConnection1.Close();
                                    dsPedidos_nf.Clear();
                                    this.datPedidos_nf.SelectCommand.CommandText =
                                   "SELECT * FROM PEDIDOS_NF WHERE COD_SISTEMA_PEDIDO_NF = '" + tb_cod_interno.Text + "'";
                                    /*"SELECT pnf.*, pv.vendedor_ped_venda " +
                                    "FROM PEDIDOS_NF pnf " +
                                    "INNER JOIN pedidos_venda pv " +
                                    "ON pv.cod_ped_venda = pnf.n_pedido_nf " +
                                    "WHERE NF_PEDIDO_NF = '" + tb_n_nf.Text + "'"; */
                                    this.fbConnection1.Open();
                                    this.datPedidos_nf.SelectCommand.Connection = fbConnection1;
                                    this.datPedidos_nf.SelectCommand.ExecuteNonQuery();
                                    datPedidos_nf.Fill(PEDIDOS_NF);
                                    this.fbConnection1.Close();
                                }
                                catch
                                {
                                    MessageBox.Show("erro na inserção do pedido-nf.");
                                    fbConnection1.Close();
                                }

                                //inserindo o cliente
                                string _indust = "";
                                string _tipo_pedido = "";
                                try
                                {
                                    FbCommand comando = new FbCommand();
                                    comando.Connection = fbConnection1;
                                    comando.CommandText =
                                        "SELECT * FROM PEDIDOS_VENDA WHERE COD_PED_VENDA = '" + ped.pedidos_selecionados[i] + "'";
                                    DataSet pedido = new DataSet();
                                    fbConnection1.Open();
                                    datPedidos_venda.SelectCommand = comando;
                                    datPedidos_venda.Fill(pedido);
                                    string _cnpj = "";
                                    string _cliente = "";
                                    string _estado = "";
                                    string _observacoes = "";
                                    string _troca = "";
                                    string _bonificacao = "";
                                    string _degustacao = "";
                                    string _devolucao = "";

                                    string _vendas = "";
                                    double _desconto = 0;
                                    double _valor_total = 0;


                                    foreach (DataRow dr in pedido.Tables[0].Rows)
                                    {
                                        _cnpj = dr["CNPJ_PED_VENDA"].ToString();
                                        _cliente = dr["CLIENTE_PED_VENDA"].ToString();
                                        _tipo_pedido = dr["TIPO_PED_VENDA"].ToString();
                                       

                                        if (cnpj_empresa == "10696210000110")
                                        {
                                            _observacoes = "";
                                        }
                                        else
                                        {
                                            _observacoes = dr["OBS_PED_VENDA"].ToString();
                                        }
                                        if (_cliente.Contains("CR FERRAMENTAS INDÚSTRIA E COMÉRCIO LTDA.- EPP"))
                                        {
                                            _observacoes = dr["OBS_PED_VENDA"].ToString();
                                        }
                                            _troca = dr["TROCA_PED_VENDA"].ToString();
                                        _bonificacao = dr["BONIFICACAO_PED_VENDA"].ToString();
                                        _degustacao = dr["DEGUSTACAO_PED_VENDA"].ToString();
                                        _devolucao = dr["DEVOLUCAO_PED_VENDA"].ToString();
                                        _indust = dr["INDUST_PED_VENDA"].ToString();
                                        _vendas = dr["VENDAS_PED_VENDA"].ToString();
                                        try
                                        {
                                            _forma_pgto_pedido = dr["COND_PGTO_PED_VENDA"].ToString();
                                        }
                                        catch { }
                                        try
                                        {
                                            _valor_total = Convert.ToDouble(dr["VALOR_TOTAL_PROD_PED_VENDA"].ToString());
                                        }
                                        catch { }
                                        try
                                        {
                                            _desconto = Convert.ToDouble(dr["VALOR_DESCONTO_PED_VENDA"].ToString());
                                        }
                                        catch { }
                                        if (_desconto > 0)
                                        {
                                            _porc_desconto = _desconto / _valor_total;
                                        }

                                    }
                                    fbConnection1.Close();
                                    tb_cnpj_cliente.Text = _cnpj;
                                    tb_cliente.Text = _cliente;
                                    //tb_dados_adicionais.Text = _observacoes;
                                    //if (_bonificacao == "1")
                                    //    rb_5910.Checked = true;
                                    //if (_degustacao == "1")
                                    //    rb_5910.Checked = true;
                                    //if (_troca == "1")
                                    //    rb_5949.Checked = true;
                                    //if (_devolucao == "1")
                                    //    rb_1410.Checked = true;

                                    /* retirado em 27/02/2024 - Guilherme
                                    //if (_tipo == "Industrialização")
                                    //    rb5124.Checked = true;
                                    //if (_tipo == "Vendas" || _tipo == "Bombas")
                                    //    rb5101.Checked = true;
                                    */
                                    bool pessoa_fisica;
                                    string ie_cliente_2, cnpj_cliente_2, logradouro_cliente_2, n_logradouro_cliente_2, complemento_cliente_2, bairro_cliente_2, cod_municipio_cliente_2,
                             uf_cliente_2, cep_cliente_2, cod_pais_cliente_2, pais_cliente_2, telefone_cliente_2, cidade_cliente_2, email_cliente_2;
                                    buscar_dados_cliente(tb_cnpj_cliente.Text, out ie_cliente_2, out cnpj_cliente_2, out logradouro_cliente_2,
                                out n_logradouro_cliente_2, out complemento_cliente_2, out bairro_cliente_2,
                                out cod_municipio_cliente_2, out uf_cliente_2, out cep_cliente_2, out cod_pais_cliente_2,
                                out pais_cliente_2, out telefone_cliente_2, out cidade_cliente_2, out pessoa_fisica, out email_cliente_2);
                                    _estado = uf_cliente_2;
                                    tb_estado_cliente.Text = _estado;
                                }
                                catch
                                {
                                    MessageBox.Show("Erro na inserção do cliente");
                                    fbConnection1.Close();
                                }


                                //inserindo os itens
                                try
                                {
                                    FbCommand comando = new FbCommand();
                                    comando.Connection = fbConnection1;
                                    comando.CommandText =
                                        "SELECT * FROM ITENS_PEDIDO_VENDA WHERE COD_PEDIDO_ITEM_VENDA = '" + ped.pedidos_selecionados[i] + "'";
                                    DataSet itens = new DataSet();
                                    fbConnection1.Open();
                                    datItens_pedido_venda.SelectCommand = comando;
                                    datItens_pedido_venda.Fill(itens);
                                    fbConnection1.Close();
                                    string[] _cod = new string[200];
                                    string[] _descricao = new string[200];
                                    string[] _unidade = new string[200];
                                    string[] _qtde = new string[200];
                                    string[] _valor_unit = new string[200];
                                    string[] _qtde_fat = new string[200];
                                    string[] _pedido = new string[200];
                                    string[] _item_pedido = new string[200];
                                    string[] _descricao_adicional = new string[200];
                                    string[] _tipo = new string[200];
                                    string[] _cod_sistema = new string[200];
                                    int k = 0;
                                    foreach (DataRow dr in itens.Tables[0].Rows)
                                    {
                                        double porc_rateio;
                                        string rateio = buscar_rateio_produto(dr["COD_SISTEMA_PROD_ITEM_VENDA"].ToString(), out porc_rateio);
                                        if (rateio == "1")
                                        {
                                            for (int x = 0; x < 2; x++)
                                            {
                                                string codigo = "";
                                                codigo = dr["COD_PROD_ITEM_VENDA"].ToString();
                                                if (codigo == "")
                                                {
                                                    codigo = buscarCodFornecedor(dr["COD_SISTEMA_PROD_ITEM_VENDA"].ToString());
                                                }
                                                _cod_sistema[k] = dr["COD_SISTEMA_PROD_ITEM_VENDA"].ToString();
                                                _cod[k] = codigo;
                                                _descricao[k] = dr["DESCRICAO_PROD_ITEM_VENDA"].ToString() + " " + dr["DESCRICAO_ITEM_PROD_ITEM_VENDA"].ToString();
                                                _unidade[k] = dr["UNIDADE_PROD_ITEM_VENDA"].ToString();
                                                _qtde[k] = dr["QTDE_ITEM_VENDA"].ToString();
                                                double porc_menor = 0, porc_maior = 0;
                                                porc_menor = porc_rateio / 100;
                                                porc_maior = 1 - porc_menor;
                                                if (x == 0)
                                                {
                                                    _valor_unit[k] = (Convert.ToDouble(dr["VALOR_UNIT_PROD_ITEM_VENDA"].ToString()) * porc_menor).ToString();
                                                    _descricao_adicional[k] = "Materia-prima aplicada";
                                                    _tipo[k] = "Materia prima";
                                                }
                                                else 
                                                {
                                                    _valor_unit[k] = (Convert.ToDouble(dr["VALOR_UNIT_PROD_ITEM_VENDA"].ToString()) * porc_maior).ToString();
                                                    _descricao_adicional[k] = "Mao de Obra";
                                                    _tipo[k] = "Mao de Obra";
                                                }
                                                _qtde_fat[k] = dr["QTDE_FAT_ITEM_VENDA"].ToString();
                                                _pedido[k] = dr["PEDIDO_CLIENTE_ITEM_VENDA"].ToString();
                                                _item_pedido[k] = dr["ITEM_PED_CLIENTE_ITEM_VENDA"].ToString();
                                                k++;
                                            }
                                        }
                                        else
                                        {
                                            string codigo = "";
                                            codigo = dr["COD_PROD_ITEM_VENDA"].ToString();
                                            if (codigo == "")
                                            {
                                                codigo = buscarCodFornecedor(dr["COD_SISTEMA_PROD_ITEM_VENDA"].ToString());
                                            }
                                            _cod_sistema[k] = dr["COD_SISTEMA_PROD_ITEM_VENDA"].ToString();
                                            _cod[k] = codigo;
                                            _descricao[k] = dr["DESCRICAO_PROD_ITEM_VENDA"].ToString() + " " + dr["DESCRICAO_ITEM_PROD_ITEM_VENDA"].ToString();
                                            _unidade[k] = dr["UNIDADE_PROD_ITEM_VENDA"].ToString();
                                            _qtde[k] = dr["QTDE_ITEM_VENDA"].ToString();
                                            _valor_unit[k] = dr["VALOR_UNIT_PROD_ITEM_VENDA"].ToString();
                                            _qtde_fat[k] = dr["QTDE_FAT_ITEM_VENDA"].ToString();
                                            _pedido[k] = dr["PEDIDO_CLIENTE_ITEM_VENDA"].ToString();
                                            _item_pedido[k] = dr["ITEM_PED_CLIENTE_ITEM_VENDA"].ToString();
                                            if (_tipo_pedido == "Industrialização")
                                            {
                                                _tipo[k] = "Mao de obra";
                                            }
                                            else
                                            {
                                                _tipo[k] = _tipo_pedido;
                                            }
                                            k++;
                                        }
                                    }


                                    //Verificando se tem CFOP padrão
                                    if (cbxCfopPadrao.Checked)
                                    {
                                        if (tb_cfo_peca.Text != "")
                                        {
                                            cfop = tb_cfo_peca.Text;
                                        }
                                    }

                                    for (int j = 0; j < k; j++)
                                    {
                                        tb_cod_peca.Text = _cod[j];
                                        if (_descricao_adicional[j] != "")
                                        {
                                            _descricao[j] = _descricao[j] + " - " + _descricao_adicional[j];
                                        }
                                        tb_descricao_peca.Text = _descricao[j];
                                        

                                        tb_unid_peca.Text = _unidade[j];
                                        tb_qtde_peca.Text = _qtde[j];
                                        tb_preco_unit_peca.Text = _valor_unit[j];
                                        tb_pedido_compra.Text = _pedido[j];
                                        tb_n_item_pedido_compra.Text = _item_pedido[j];
                                       // if (_qtde_fat[j] != "")
                                       //     tb_qtde_peca.Text = _qtde_fat[j];

                                        double valor_total_item = 0;
                                        double desconto_item = 0;
                                        try
                                        {
                                            valor_total_item = Convert.ToDouble(tb_qtde_peca.Text) * Convert.ToDouble(tb_preco_unit_peca.Text);
                                            desconto_item = valor_total_item * _porc_desconto;
                                        }
                                        catch { }

                                        string origem = "";
                                        string cst = "";
                                        string ean = "";
                                        tb_ncm_peca.Text = buscar_ncm_cfop_origem(_cod_sistema[j], tb_estado_cliente.Text, out origem, out cst, out ean, out cfop);
                                        if (tb_ncm_peca.Text == "")
                                            tb_ncm_peca.Text = "99999999";
                                        tb_desconto_item.Text = desconto_item.ToString("n3");
                                        tb_cfo_peca.Text = cfop;

                                        tb_origem_peca.Text = "0"; //só tem produto nacional
                                        //tb_ean.Text = ean;
                                        //if (tb_ean.Text.Length < 5)
                                        //    tb_ean.Text = "";
                                        //tb_cst.Text = cst;
                                        if (tb_descricao_peca.Text != "")
                                        {
                                            string cod_peca = tb_cod_peca.Text;
                                            string qtde = tb_qtde_peca.Text;
                                            inserir_itens(false, _tipo[j], _cod_sistema[j]);
                                           
                                            if (_tipo[j] == "Mao de Obra")
                                            {
                                                //buscar_itens_nota
                                                //fazer quando a OS estiver rodando
                                                //inserir_retorno(cod_peca, qtde);
                                            }
                                        }




                                    }



                                }
                                catch
                                {
                                    MessageBox.Show("erro na inserção do item");
                                    fbConnection1.Close();
                                }

                            }
                            buscar_forma_pgto(tb_cnpj_cliente.Text, _forma_pgto_pedido);
                            rb5124.Checked = false;
                            rb5101.Checked = false;
                        }
                    }
                }
            }
        }

        private string buscar_rateio_produto(string cod, out double porc)
        {
            porc = 90;
            try
            {
                FbCommand selectLotes = new FbCommand();
                selectLotes.Connection = fbConnection1;
                selectLotes.CommandText =
                    @"SELECT RATEIO_PRODUTO, PORC_RATEIO_PRODUTO FROM PRODUTOS 
                    WHERE COD_PRODUTO = '" + cod + "'";
                FbDataAdapter datSelectLotes = new FbDataAdapter();
                datSelectLotes.SelectCommand = selectLotes;
                DataTable dtSelectLotes = new DataTable();
                datSelectLotes.Fill(dtSelectLotes);
                fbConnection1.Close();
                foreach (DataRow dr in dtSelectLotes.Rows)
                {
                    try
                    {
                        porc = Convert.ToDouble(dr[1].ToString());
                    }
                    catch
                    { }
                    return dr[0].ToString();
                }
                return "";
            }
            catch { fbConnection1.Close(); return ""; }
        }

        private void inserir_retorno(string cod_peca, string qtde)
        {
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
where  prod.cod_fornecedor_produto = '" + cod_peca + @"'
group by iprod.cod_estoque_ip";
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();
                foreach (DataRow dr in dtSelect.Rows)
                {
                    try
                    {
                        FbCommand selectLotes = new FbCommand();
                        selectLotes.Connection = fbConnection1;
                        selectLotes.CommandText =
                            @"SELECT * FROM LOTE_RECEBIMENTO lr 
                    inner join ITENS_NOTA_ENT inf on lr.COD_LR = inf.LOTE_ITEM_ENT 
                    WHERE COD_PRODUTO_LR = '" + dr["cod_estoque_ip"].ToString() + "' and QTDE_LR > 0 order by DATA_LIBERACAO_LR";
                        FbDataAdapter datSelectLotes = new FbDataAdapter();
                        datSelectLotes.SelectCommand = selectLotes;
                        DataTable dtSelectLotes = new DataTable();
                        datSelectLotes.Fill(dtSelectLotes);

                        fbConnection1.Close();
                        decimal qtde_necessaria = 0, qtde_mp = 0, qtde_empenhada = 0, qtde_encontrada = 0;
                        try
                        {
                            qtde_necessaria = Convert.ToDecimal(qtde) * Convert.ToDecimal(dr["qtde_mp"].ToString());
                            qtde_mp = Convert.ToDecimal(qtde) * Convert.ToDecimal(dr["qtde_mp"].ToString());
                        }
                        catch { }
                        bool finalizado = false;
                        string cod_item = "", descricao_item = "", qtde_item = "", ncm_item = "", valor_item = "", cfop_item = "", unidade_item = "";
                        buscar_dados_estoque(dr["cod_estoque_ip"].ToString(), out cod_item, out descricao_item, out ncm_item, out unidade_item);
                        foreach (DataRow drLotes in dtSelectLotes.Rows)
                        {
                            if (cod_item == "TA0180") 
                            {

                            }
                            try
                            {
                                if (!finalizado)
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
                                            ;
                                    }
                                    
                                    qtde_item = qtde_a_inserir_do_lote.ToString();
                                   
                                   
                                    valor_item = Convert.ToDecimal(drLotes["PRECO_UNIT_ITEM_ENT"].ToString()).ToString();
                                     if (ncm_item == "")
                                        ncm_item = "99999999";
                                     if (unidade_item == "")
                                         unidade_item = "KG";
                                    if(tb_estado_cliente.Text == estado_empresa)
                                        cfop_item = "5902";
                                    if (tb_estado_cliente.Text != estado_empresa)
                                        cfop_item = "6902";

                                    inserir_itens_retorno(cod_item, descricao_item + " NF: " + drLotes["NOTA_FISCAL_LR"].ToString(), qtde_item, ncm_item, valor_item, cfop_item, drLotes["COD_LR"].ToString(), unidade_item);
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                        if (!finalizado)
                        {
                            MessageBox.Show("O material " + cod_item + " não tem o estoque necessário para todos os pedidos abertos. Disponível: " + qtde_empenhada.ToString("n3") + ". Necessária: " + qtde_mp.ToString("n3") + ". Por favor verifique antes de continuar");
                        }
                    }
                    catch (Exception ex)
                    {
                        fbConnection1.Close();
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            catch(Exception ex)
            {
                fbConnection1.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void inserir_retorno_manual()
        {
            try
            {

                string cod_item = "", descricao_item = "", qtde_item = "",
                    ncm_item = "", valor_item = "", cfop_item = "",
                    unidade_item = "", nf = "", lote = "", chave_acesso = "";


                qtde_item = "0";
                valor_item = "0";
                if (ncm_item == "")
                    ncm_item = "99999999";
                if (unidade_item == "")
                    unidade_item = "KG";
                if (tb_estado_cliente.Text == estado_empresa)
                    cfop_item = "5902";
                if (tb_estado_cliente.Text != estado_empresa)
                    cfop_item = "6902";

                // inserir_itens_retorno(cod_item, descricao_item + " NF: " + drLotes["NOTA_FISCAL_LR"].ToString(), qtde_item, ncm_item, valor_item, cfop_item, drLotes["COD_LR"].ToString(), unidade_item);
                inserir_itens_retorno(cod_item, descricao_item + " NF: " + nf, qtde_item, ncm_item, valor_item, cfop_item, lote, unidade_item);


            }
            catch (Exception ex)
            {
                fbConnection1.Close();
                MessageBox.Show(ex.Message);
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

        private void buscar_dados_estoque_item(string cod_item, out string descricao_item, out string ncm_item, out string unidade_item)
        {
            descricao_item = ""; ncm_item = ""; unidade_item = "";
            try
            {
                FbCommand selectLotes = new FbCommand();
                selectLotes.Connection = fbConnection1;
                selectLotes.CommandText =
                    @"SELECT * FROM ESTOQUE 
                    WHERE ITEM_ESTOQUE = '" + cod_item + "'";
                FbDataAdapter datSelectLotes = new FbDataAdapter();
                datSelectLotes.SelectCommand = selectLotes;
                DataTable dtSelectLotes = new DataTable();
                datSelectLotes.Fill(dtSelectLotes);
                fbConnection1.Close();
                foreach (DataRow dr in dtSelectLotes.Rows)
                {
                    //cod_item = dr["item_estoque"].ToString();
                    descricao_item = dr["DESCRICAO_ESTOQUE"].ToString();
                    ncm_item = dr["NCM_ESTOQUE"].ToString();
                    unidade_item = dr["UNIDADE_ESTOQUE"].ToString();
                }

            }
            catch { fbConnection1.Close(); }
        }
        private void inserir_itens_retorno(string cod_item, string descricao_item, string qtde_item, string ncm_item, 
            string valor_item, string cfop_item, string lote, string unidade)
        {
            tb_cod_peca.Text = cod_item;
            tb_descricao_peca.Text = descricao_item;
            tb_qtde_peca.Text = qtde_item;
            tb_ncm_peca.Text = ncm_item;
            tb_preco_unit_peca.Text = valor_item;
            tb_cfo_peca.Text = cfop_item;
            tb_ean.Text = lote;
            tb_unid_peca.Text = unidade;
            inserir_itens(true, "", cod_item);

        }
        private void buscar_forma_pgto(string cnpj, string forma_pgto_pedido)
        {
            try
            {
                if (forma_pgto_pedido != "")
                {
                    inserir_nova_forma_pgto(forma_pgto_pedido);
                }
                else
                {
                    FbCommand select = new FbCommand();
                    select.CommandText =
                        "SELECT FORMA_PAGAMENTO_CLIENTE FROM CLIENTES WHERE CNPJ = '" + cnpj + "'";
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
                        if (rb_1410.Checked || rb_5904.Checked || rb_5910.Checked || rb_5949.Checked || rb_5917.Checked)
                        {
                            cb_forma_pgto.Text = "2 - Outros";
                        }
                        else
                        {
                            if (dr[0].ToString() != "")
                            {
                                inserir_nova_forma_pgto(dr[0].ToString());
                            }
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

        private string buscarCodFornecedor(string codigo)
        {
            try
            {
                FbCommand select = new FbCommand();
                string codForn;
                select = new FbCommand();
                select.CommandText =
                    "SELECT COD_FORNECEDOR_PRODUTO FROM PRODUTOS WHERE COD_PRODUTO = '" + codigo + "'";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                DataTable dtSelect2 = new DataTable();
                FbDataAdapter datSelect2 = new FbDataAdapter();
                datSelect2.SelectCommand = select;
                datSelect2.Fill(dtSelect2);
                fbConnection1.Close();
                DataRow dr2 = dtSelect2.Rows[0];
                codForn = dr2[0].ToString();
                return codForn;
            }
            catch
            {
                MessageBox.Show("Erro ao buscar codigo fornecedor");
                fbConnection1.Close();
                return "";
            }
        }

        private string buscar_ncm_cfop_origem(string codigo, string estado, out string origem, out string cst, out string ean, out string cfop)
        {
            if (codigo == "1392")
            {
                int a = 1;
            }
            cfop = "";
            origem = "ERRO";
            cst = "ERRO";
            ean = "ERRO";
            try
            {

                FbCommand comando = new FbCommand();
                comando.Connection = fbConnection1;
                comando.CommandText =
                    "SELECT NCM_PRODUTO, CFOP_ENTRADA_PRODUTO, ORIGEM_PRODUTO, IVA_PRODUTO, COD_BARRAS_PRODUTO FROM PRODUTOS WHERE " +
                    "COD_PRODUTO = '" + codigo + "' ";
                DataSet itens = new DataSet();
                fbConnection1.Open();
                datProdutos.SelectCommand = comando;
                datProdutos.Fill(itens);
                fbConnection1.Close();
                string ncm = "ERRO", cfop_entrada = "ERRO";
                string iva = "";
                foreach (DataRow dr in itens.Tables[0].Rows)
                {
                    ncm = dr["NCM_PRODUTO"].ToString();
                    cfop_entrada = dr["CFOP_ENTRADA_PRODUTO"].ToString();
                    origem = dr["ORIGEM_PRODUTO"].ToString();
                    iva = dr["IVA_PRODUTO"].ToString();
                    ean = dr["COD_BARRAS_PRODUTO"].ToString();

                }
                if (cfop_entrada == "5101" || cfop_entrada == "6101")
                {
                    if (estado == estadolabel.Text)
                        cfop = "5102";
                    else
                        cfop = "6102";
                }
                if (cfop_entrada == "5102" || cfop_entrada == "6102")
                {
                    if (estado == estadolabel.Text)
                        cfop = "5102";
                    else
                        cfop = "6102";
                }
                if (cfop_entrada == "5403")
                {
                    if (estado == estadolabel.Text)
                        cfop = "5405";
                    else
                        cfop = "6404";
                }
                if (cfop_entrada == "5401")
                {
                    if (estado == estadolabel.Text)
                        cfop = "5405";
                    else
                        cfop = "6404";
                }
                double _iva = 0;
                try
                {
                    _iva = Convert.ToDouble(iva);
                }
                catch { }
                if (_iva > 0)
                {
                    //cst = "500";
                }
                else
                {
                    cst = "101";
                }
                //cfop = "";
                return ncm;
            }
            catch
            {
                fbConnection1.Close();
                return "ERRO";
            }
            //if(cfop_entrada == 
        }

        private void buscar_produto(string prod)
        {
            try
            {
                string _origem, _cst, _modalidade, _icms, _icms_st, _reducao, _reducao_st, _iva, _ipi, _pis,
                     _cofins, _iss, _crt, _aliquota_credito, _modalidade_st, _bc_com_ipi, _ipi_tributado,
                     _ipi_n_tributado, _cst_ipi_tributado, _cst_ipi_n_tributado, _tipo_pis, _cst_pis,
                     _tipo_cofins, _cst_cofins, _pCredICMS, _cst_ibscbs, _classificacao_ibscbs, _aliquota_ibs, _aliquota_cbs;
                buscar_informacoes_padrao(out _origem, out _cst, out _modalidade, out _icms,
                            out _icms_st, out _reducao, out _reducao_st, out _iva, out _ipi, out _pis, out _cofins,
                            out _iss, out _crt, out _aliquota_credito, out _modalidade_st, out _bc_com_ipi,
                            out _ipi_tributado, out _ipi_n_tributado, out _cst_ipi_tributado,
                            out _cst_ipi_n_tributado, out _tipo_pis, out _cst_pis, out _tipo_cofins, out _cst_cofins, out _pCredICMS,
                            out _cst_ibscbs, out _classificacao_ibscbs, out _aliquota_ibs, out _aliquota_cbs);


                string select = "SELECT * FROM PRODUTOS WHERE COD_PRODUTO = '" + prod + "'";

                FbCommand comando = new FbCommand();
                comando.Connection = fbConnection1;
                comando.CommandText = select;

                fbConnection1.Open();
                DataSet produto = new DataSet();
                datProdutos.SelectCommand = comando;
                datProdutos.Fill(produto);
                fbConnection1.Close();
                if (produto.Tables[0].Rows.Count > 0)
                {
                    DataRow dr = produto.Tables[0].Rows[0];
                    //tb_cod_peca.Text = dr["COD_PRODUTO"].ToString();
                   // if (cod_forn_empresa == "1")
                    tb_cod_peca.Text = dr["COD_FORNECEDOR_PRODUTO"].ToString();
                    tb_descricao_peca.Text = dr["DESCRICAO_PRODUTO"].ToString();
                    tb_unid_peca.Text = dr["COD_UNIDADE_PRODUTO"].ToString();
                    tb_preco_unit_peca.Text = dr["VALOR_VENDA_REVEND_PRODUTO"].ToString();
                    tb_ncm_peca.Text = dr["NCM_PRODUTO"].ToString();
                    tb_origem_peca.Text = dr["ORIGEM_PRODUTO"].ToString();
                    tb_mod_bc_item.Text = dr["MOD_BC_PRODUTO"].ToString();
                    tb_mod_bc_st_item.Text = dr["MOD_BC_ST_PRODUTO"].ToString();
                    tb_cst.Text = dr["ST_SAIDA_PRODUTO"].ToString();
                    tb_iva_item.Text = dr["IVA_PRODUTO"].ToString();
                    tb_ean.Text = dr["COD_BARRAS_PRODUTO"].ToString();
                    if (_crt == "3") //SE NÃO FOR SIMPLES NACIONAL
                    {
                        //ICMS
                        tb_icms_item.Text = dr["ALIQUOTA_ICMS_PRODUTO"].ToString();
                        if (dr["BC_COM_IPI_PRODUTO"].ToString() == "1")
                            cbBC_com_ipi.Checked = true;
                        if (tb_estado_cliente.Text != estadolabel.Text)
                        {
                            string icms_st, iva, reducao, reducao_st, icms;
                            verificar_tributacao_cliente(tb_cnpj_cliente.Text, out icms_st, out iva,
                                out reducao, out reducao_st, out icms);
                            tb_cst.Text = _cst;
                            tb_icms_item.Text = icms;
                            if (tb_cst.Text == "00") //SUBST. TRIB
                            {
                                tb_icms_item.Text = icms;
                            }
                            if (tb_cst.Text == "10") //SUBST. TRIB
                            {
                                tb_icms_item.Text = icms_st;
                                tb_icms_st.Text = dr["ALIQUOTA_ICMS_ST_PRODUTO"].ToString();
                                tb_iva_item.Text = iva;
                            }
                            if (tb_cst.Text == "20") //REDUCAO
                            {
                                tb_reducao_item.Text = reducao;
                            }
                            if (tb_cst.Text == "30") //SUBST. TRIB NÃO TRIB
                            {
                                tb_icms_item.Text = icms_st;
                                tb_icms_st.Text = dr["ALIQUOTA_ICMS_ST_PRODUTO"].ToString();
                                tb_iva_item.Text = iva;
                            }
                            if (tb_cst.Text == "70") //SUBST. TRIB NÃO TRIB
                            {
                                tb_icms_item.Text = icms_st;
                                tb_icms_st.Text = dr["ALIQUOTA_ICMS_ST_PRODUTO"].ToString();
                                tb_iva_item.Text = iva;
                                tb_reducao_st_item.Text = reducao_st;
                            }
                        }
                        else //DENTRO DO ESTADO
                        {
                            if (tb_cst.Text == "10") //SUBST. TRIB
                            {
                                tb_icms_st.Text = dr["ALIQUOTA_ICMS_ST_PRODUTO"].ToString();//PEGA DA INFORMAÇÃO PADRAO
                                tb_iva_item.Text = dr["IVA_PRODUTO"].ToString();
                            }
                            if (tb_cst.Text == "20") //REDUCAO
                            {
                                tb_reducao_item.Text = dr["REDUCAO_PRODUTO"].ToString();
                            }
                            if (tb_cst.Text == "30") //SUBST. TRIB NÃO TRIB
                            {
                                tb_icms_st.Text = dr["ALIQUOTA_ICMS_ST_PRODUTO"].ToString();//PEGA DA INFORMAÇÃO PADRAO
                                tb_iva_item.Text = dr["IVA_PRODUTO"].ToString();
                            }
                            if (tb_cst.Text == "70") //SUBST. TRIB NÃO TRIB
                            {
                                tb_icms_st.Text = dr["ALIQUOTA_ICMS_ST_PRODUTO"].ToString();//PEGA DA INFORMAÇÃO PADRAO
                                tb_iva_item.Text = dr["IVA_PRODUTO"].ToString();
                                tb_reducao_st_item.Text = dr["REDUCAO_ST_PRODUTO"].ToString();
                            }
                        }
                        //IPI
                        if (dr["IPI_TRIB_PRODUTO"].ToString() == "1")
                        {
                            rb_ipi_tributado.Checked = true;
                            tb_cst_ipi_tributado.Text = dr["CST_IPI_TRIB_PRODUTO"].ToString();
                            tb_ipi_item.Text = dr["IPI_PRODUTO"].ToString();
                        }
                        else
                        {
                            rb_ipi_nao_tributado.Checked = true;
                            tb_cst_ipi_n_tributado.Text = dr["CST_IPI_N_TRIB_PRODUTO"].ToString();
                        }

                        //PIS
                        tb_tipo_pis.Text = dr["TIPO_PIS_PRODUTO"].ToString();
                        tb_cst_pis.Text = dr["CST_PIS_PRODUTO"].ToString();
                        tb_pis_item.Text = dr["PIS_PRODUTO"].ToString();

                        //COFINS
                        tb_tipo_cofins.Text = dr["TIPO_COFINS_PRODUTO"].ToString();
                        tb_cst_cofins.Text = dr["CST_COFINS_PRODUTO"].ToString();
                        tb_cofins_item.Text = dr["COFINS_PRODUTO"].ToString();

                    }
                    else //SE FOR SIMPLES NACIONAL - PEGAR INFORMAÇÕES PADROES DA EMPRESA
                    {
                        tb_aliquota_credito.Text = _pCredICMS;
                        if (tb_estado_cliente.Text != estadolabel.Text) //FORA DO ESTADO
                        {//FORA DO ESTADO PEGA ALGUMAS INFORMAÇÕES DO CLIENTE
                            string icms_st, iva, reducao, reducao_st, icms;
                            verificar_tributacao_cliente(tb_cnpj_cliente.Text, out icms_st,
                                out iva, out reducao, out reducao_st, out icms);
                            if (tb_cst.Text == "201") //SUBST. TRIB
                            {
                                tb_icms_st.Text = icms_st;
                                if (tb_iva_item.Text == "")
                                    tb_iva_item.Text = iva;
                                tb_icms_item.Text = _icms;
                            }
                            if (tb_cst.Text == "202") //SUBST. TRIB NÃO TRIB
                            {
                                tb_icms_st.Text = icms_st;
                                if (tb_iva_item.Text == "")
                                    tb_iva_item.Text = iva;
                                tb_icms_item.Text = _icms;
                            }
                        }
                        else
                        {//SE FOR DENTRO DO ESTADO PEGA INFORMAÇÃO PADRÃO DO EMITENTE
                            if (tb_cst.Text == "201") //SUBST. TRIB
                            {
                                tb_icms_st.Text = _icms_st;
                                if (tb_iva_item.Text == "")
                                    tb_iva_item.Text = _iva;
                                tb_icms_item.Text = _icms;
                            }
                            if (tb_cst.Text == "202") //SUBST. TRIB
                            {
                                tb_icms_st.Text = _icms_st;
                                if (tb_iva_item.Text == "")
                                    tb_iva_item.Text = _iva;
                                tb_icms_item.Text = _icms;
                            }
                        }
                        //IPI
                        rb_ipi_nao_tributado.Checked = true;
                        tb_cst_ipi_n_tributado.Text = dr["CST_IPI_N_TRIB_PRODUTO"].ToString();

                        //PIS
                        tb_tipo_pis.Text = dr["TIPO_PIS_PRODUTO"].ToString();
                        tb_cst_pis.Text = dr["CST_PIS_PRODUTO"].ToString();
                        tb_pis_item.Text = dr["PIS_PRODUTO"].ToString();

                        //COFINS
                        tb_tipo_cofins.Text = dr["TIPO_COFINS_PRODUTO"].ToString();
                        tb_cst_cofins.Text = dr["CST_COFINS_PRODUTO"].ToString();
                        tb_cofins_item.Text = dr["COFINS_PRODUTO"].ToString();

                    }


                    //ISS
                    if (dr["PRESTACAO_SERVICO_PRODUTO"].ToString() == "1")
                    {
                        tb_iss_item.Text = dr["ISS_PRODUTO"].ToString();
                        tb_tipo_servico.Text = dr["TIPO_SERVICO_PRODUTO"].ToString();
                        cb_prestacao_servico.Checked = true;
                    }
                }
                if (tb_cst.Text == "400")
                    tb_cfo_peca.Text = "5405";
                if (tb_cst.Text == "101")
                    tb_cfo_peca.Text = "5102";

                if (razao_social_empresa == "Daniel A. Bezera - ME")
                {
                    tb_cfo_peca.Text = "5101";
                }
            }


            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
                fbConnection1.Close();
            }

        }

        private void verificar_tributacao_cliente(string cnpj, out string icms_st, out string iva,
            out string reducao, out string reducao_st, out string icms)
        {
            icms_st = ""; iva = ""; reducao = ""; reducao_st = ""; icms = "";
            try
            {
                FbCommand comando = new FbCommand();
                comando.Connection = fbConnection1;
                comando.CommandText =
                    "SELECT ICMS_ST_CLIENTE, IVA_CLIENTE, REDUCAO_CLIENTE, REDUCAO_ST_CLIENTE, ICMS_CLIENTE FROM CLIENTES " +
                    "WHERE CNPJ = '" + cnpj + "'";
                fbConnection1.Open();
                DataSet inf = new DataSet();
                datClientes.SelectCommand = comando;
                datClientes.Fill(inf);
                fbConnection1.Close();
                foreach (DataRow dr in inf.Tables[0].Rows)
                {
                    icms_st = dr[0].ToString();
                    iva = dr[1].ToString();
                    reducao = dr[2].ToString();
                    reducao_st = dr[3].ToString();
                    icms = dr[4].ToString();
                }
            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
                fbConnection1.Close();
            }


        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            tb_protocolo_autorizacao.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            classe_particularidades part = new classe_particularidades();
            part.executar_particularidades(tb_n_nf.Text);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Atualizar(false);
            form_localiza_produto prod = new form_localiza_produto(false, cnpj_empresa);
            try
            {
                prod.buscar = true;
                prod.ShowDialog();
            }
            finally
            {
                try
                {
                    if (prod.cod_produto_escolhido != null)
                    {
                        buscar_produto(prod.cod_produto_escolhido);
                    }
                }
                catch { }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (tb_protocolo_autorizacao.Text == "")
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
                string caminho = "c:\\evolucao\\NFE\\assinadas\\" + "NFE" + tb_n_nf.Text + "_assinadas.xml";
                StreamReader objReader = new StreamReader(caminho);
                ArrayList arrText = new ArrayList();
                arquivo = objReader.ReadToEnd();
                string recibo = tb_recibo.Text;
                string _dhProtocolo = "";
                string _nroProtocolo = "";
                string _retCancNFe = "";
                string _cMsg = ""; string _xMsg = "";
                int resultado;
                int cStat = 0;
                objReader.Close();
                string wsuf = "SP";// "SP3";
                if (estado_empresa != "SP")
                    wsuf = "SVRS";
                string _procNF = util2.CriaProcNFe2G(wsuf, ref arquivo, out _nroProtocolo, out _retCancNFe, out resultado, nomeCertificado,
                out _msgResultado, proxy, usuario, senha);

               // string _procNF = util2.CriaProcNFe2G("SP3", ref arquivo, out _nroProtocolo, out _retCancNFe, out resultado, nomeCertificado, out _msgResultado, proxy, usuario, senha);
                if (resultado == 6201)
                {
                    criar_codigo_barras();
                    gerar_xml_autorizada(_procNF);
                    barra_status.Text = "NFe Autorizada. ";
                    tb_status_nfe.Text = "NFe Autorizada.";
                    string protocolo = _nroProtocolo;
                    try
                    {
                        protocolo = _nroProtocolo.Remove(15);
                    }
                    catch { }
                    tb_protocolo_autorizacao.Text = protocolo;
                    update_coluna_xml_aut(_procNF, _nroProtocolo, tb_status_nfe.Text, tb_chave_acesso_nfe.Text);
                    calcular_estoque_mp();
                    Atualizar(true);
                    inserir_duplicatas_cr();
                    /*
                    classe_particularidades part = new classe_particularidades();
                    part.executar_particularidades(tb_n_nf.Text);
                    part.baixar_do_estoque();
                     * */
                    gbNfe.BackColor = Color.GreenYellow;

                    Atualizar(true);
                    try
                    {
                        imprimir();
                        gerar_boletos();
                    }
                    finally
                    {
                        if (razao_social_empresa.Contains("LLOC"))
                        {
                        }
                        else
                        {
                            enviar_email();
                        }
                        Atualizar(true);
                    }
                }
                else
                {
                    //MessageBox.Show(_msgResultado, cStat.ToString());
                    form_erro_texto msg = new form_erro_texto();
                    msg.mensagem = _msgResultado;
                    try
                    {
                        msg.ShowDialog();
                    }
                    finally { }
                }
            }
            else
            {
                MessageBox.Show("Essa NF já foi autorizada");
            }

        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (tb_protocolo_autorizacao.Text != "")
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
                string recibo = tb_recibo.Text;
                string _dhProtocolo = "";
                string _nroProtocolo = "";
                string _retCancNFe = "";
                string _cMsg = ""; string _xMsg = "";
                int resultado;
                int cStat = 0;
                if (tb_sequencial_correcao.Text == "")
                    tb_sequencial_correcao.Text = "1";
                else
                {
                    int seq = Convert.ToInt32(tb_sequencial_correcao.Text);
                    seq++;
                    tb_sequencial_correcao.Text = seq.ToString();
                }

                /*
                string wsuf = "SP3";
                if (estado_empresa != "SP")
                    wsuf = "SVRS";

                string _procNF = util2.EnviaCCe2G(wsuf, ambiente, nomeCertificado, "1.00", out _msgDados, out _msgRetWS, out cStat, out _msgResultado,
                    tb_chave_acesso_nfe.Text, tb_texto_correcao.Text, 0, Convert.ToInt32(tb_sequencial_correcao.Text), DateTime.Now.ToString(), out _nroProtocolo,
                    out _dhProtocolo, proxy, usuario, senha, licenca);
                 */
                string wsuf = "SP";
                if (estado_empresa != "SP")
                    wsuf = "SVRS";
                string _procNF = util2.EnviaCCe2G(wsuf, ambiente, nomeCertificado, "4.00", out _msgDados, out _msgRetWS, out cStat, out _msgResultado,
                tb_chave_acesso_nfe.Text, tb_texto_correcao.Text, 0, Convert.ToInt32(tb_sequencial_correcao.Text), DateTime.Now.ToString(), out _nroProtocolo,
                out _dhProtocolo, proxy, usuario, senha, licenca);



                if (cStat == 135)
                {
                    gerar_xml_corrigida(_procNF);
                    barra_status.Text = "NFe Corrigida. ";
                    Atualizar(true);
                    try
                    {
                        imprimir_corrigida();
                    }
                    finally
                    {
                        enviar_email_corrigida();
                        Atualizar(true);
                    }
                }
                else
                {
                    MessageBox.Show(_msgResultado, cStat.ToString());
                }
            }
            else
            {
                MessageBox.Show("Essa NF não foi autorizada, portanto não pode ser corrigida");
            }
        }

        private void enviar_email_corrigida()
        {


            string _caminho_arquivo = "c:\\evolucao\\NFE\\CORRIGIDAS\\NFE" + tb_chave_acesso_nfe.Text + " - " + tb_sequencial_correcao.Text + ".xml";
            string _caminho_danfe = "c:\\evolucao\\NFE\\CORRIGIDAS\\NFE_CORRIGIDA_" + tb_n_nf.Text + ".pdf";
            //var assunto
            string _assunto = "Correção da NFe nº" + tb_n_nf.Text;
            string _mensagem = "<html xmlns:v='urn:schemas-microsoft-com:vml'" +
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
"<p class=MsoPlainText><span style='font-family:'Comic Sans MS''>Prezado cliente,<o:p></o:p></span></p> " +
"<p class=MsoPlainText><span style='font-family:'Comic Sans MS''><o:p>&nbsp;</o:p></span></p>" +
"<p class=MsoPlainText><span style='font-family:'Comic Sans MS''>Segue anexo a Correção da Nota Fiscal Eletrônica em XML" +
"style='font-family:'Comic Sans MS''>, série 001</span></span><span style='font-family:'Comic Sans MS''> de " + razao_social_empresa +
". </span><br> A Carta de Correção segue em PDF.<br><br><o:p></o:p></span></p>" +
        "<p class=MsoPlainText><span style='font-family:'Comic Sans MS''>Atenciosamente,<o:p></o:p></span></p>" +
"<p class=MsoNormal><span style='font-size:10.0pt;font-family:'Comic Sans MS';" +
"mso-bidi-font-family:Arial'><o:p>&nbsp;</o:p></span></p>" +
"<p class=MsoNormal><span style='font-size:10.0pt;font-family:'Comic Sans MS';" +
"mso-no-proof:yes'>_________________________<br>" +
"Setor de Faturamento<br>" +
"Tel: " + telefone_empresa + "<br>" +
"e-mail: <a href='mailto:" + email_nfe_empresa + "'>" + email_nfe_empresa + "</a><br>" +
"</div>" +
"</body>" +
"</html>";
            Email novo_email = new Email();
            bool _erro;
            //var smtp, email, senha_email
            novo_email.EnviarEmail(detectar_email(), _assunto, _mensagem, _caminho_arquivo, _caminho_danfe, "", email_nfe_empresa, senha_email_nfe_empresa, smtp_nfe_empresa, out _erro, tb_cnpj_cliente.Text);

            if (_erro == false)
            {
                barra_status.Text = barra_status.Text + "Email enviado com sucesso. ";
            }
            else
            {
                barra_status.Text = barra_status.Text + "Email não enviado. Favor verificar dados. ";
            }
        }

        private void gerar_xml_corrigida(string _procNF)
        {
            FileInfo t = new FileInfo("c:\\evolucao\\NFE\\CORRIGIDAS\\NFE" + tb_chave_acesso_nfe.Text + " - " + tb_sequencial_correcao.Text + ".xml");
            using (StreamWriter texto = t.CreateText())
            {
                texto.WriteLine(_procNF);
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            imprimir_corrigida();

        }
        private void imprimir_corrigida()
        {
            if (tb_protocolo_autorizacao.Text == "")
            {
                MessageBox.Show("Não esqueça de Consultar o Status da NFe");
            }

            this.datNota_fiscal.UpdateCommand.CommandText =
                        "UPDATE NOTA_FISCAL SET NOTA_STRING_NF = '" + numero_nf(9, tb_n_nf.Text) + "' WHERE N_NF = " + tb_n_nf.Text + "";
            this.fbConnection1.Open();
            this.datNota_fiscal.UpdateCommand.Connection = fbConnection1;
            this.datNota_fiscal.UpdateCommand.ExecuteNonQuery();
            this.fbConnection1.Close();

            dsImprimir_op imprimir = new dsImprimir_op();
            // fbConnection1.Open();


            FbCommand comando = new FbCommand();
            comando.Connection = fbConnection1;
            comando.CommandText = "SELECT * FROM EMPRESA where LICENCA_DLL_NFE_EMPRESA is not null AND CNPJ_EMPRESA = '" + cnpj_empresa + "' ";
            DataSet empresa = new DataSet();
            fbConnection1.Open();
            FbDataAdapter datEmpresa = new FbDataAdapter();
            datEmpresa.SelectCommand = comando;
            datEmpresa.Fill(imprimir.EMPRESA);
            fbConnection1.Close();


            datNota_fiscal.Fill(imprimir.NOTA_FISCAL);
            fbConnection1.Close();
            crCorrecao nova_nota = new crCorrecao();
            nova_nota.SetDataSource(imprimir);
            form_imprimir imprime = new form_imprimir(nova_nota);
            imprime.n_nfe_correcao = tb_n_nf.Text;
            imprime.nome_fantasia = nomeFantasia;
            imprime.dataEmissao = tb_data_emissao.Text.Replace("/", "-");
            imprime.correcao = true;
            imprime.Show();
        }

        private void gbNfe_Enter(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

            gerar_boletos();

        }

        private void gerar_boletos()
        {
            string banco = "";
            if (verificar_se_e_boleto())
            {
                if (verificar_se_e_mesmo_banco(out banco))
                {
                    if (tb_protocolo_autorizacao.Text == "")
                    {
                        MessageBox.Show("Não é possível gerar boleto de uma nota não autorizada");
                    }
                    else
                    {
                        //BackgroundWorker backgroundWorker = new BackgroundWorker();
                        //backgroundWorker.DoWork += new DoWorkEventHandler(backgroundWorker_DoWork);
                        //backgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorker_RunWorkerCompleted);
                        //backgroundWorker.RunWorkerAsync();
                        double prazo = 0;
                        try
                        {
                            prazo = Convert.ToDouble(dgvFatura_nf.Rows[0].Cells["col_prazo"].Value.ToString());
                        }
                        catch { }
                        string _banco_da_nota = buscar_banco_nota(tb_n_nf.Text);
                        if (_banco_da_nota != _cod_interno_banco && _banco_da_nota != "0" && _banco_da_nota != "" && 0 == 1)
                        {
                            MessageBox.Show("O Boleto dessa nota foi tirado em um banco diferente de " + _descricao_banco + ". \n Por favor verifique. ");
                        }
                        else
                        {
                            if (dgvFatura_nf.RowCount > 0 && prazo != 0)
                            {
                                for (int i = 0; i < dgvFatura_nf.RowCount; i++)
                                {
                                    if (dgvFatura_nf.Rows[i].Cells["col_cr_fatura"].Value.ToString() != "")
                                    {
                                        definir_banco(i);
                                        imprimir_boleto();
                                    }
                                    else
                                        MessageBox.Show("É preciso ter uma conta a receber cadastrada para gerar o boleto");
                                }
                            }
                            //  _progresso = new Progresso();
                            //   _progresso.ShowDialog();
                            //gerar_pdf(_arquivo);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("O Boleto da nota " + tb_n_nf.Text + " foi impresso no " + banco + ". Mude a seleção do Banco antes de imprimir o boleto.");
                }
            }

        }

        private bool verificar_se_e_boleto()
        {
            try
            {
                FbCommand select = new FbCommand();
                select.CommandText =
                    "SELECT TIPO_FORMA_PGTO FROM FORMA_PGTO WHERE DESCRICAO_FORMA_PGTO = '" + cb_forma_pgto.Text + "'";
                select.Connection = fbConnection1;
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();
                foreach (DataRow dr in dtSelect.Rows)
                {
                    if (dr[0].ToString() == "BOLETO")
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

        private bool verificar_se_e_mesmo_banco(out string banco)
        {
            banco = "";
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                select.CommandText = "SELECT first(1) DESCRICAO_CC_CR FROM CONTAS_A_RECEBER WHERE NF_CR = '" + tb_n_nf.Text + "' order by cod_cr desc";
                fbConnection1.Open();
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();
                foreach (DataRow dr in dtSelect.Rows)
                {
                    
                    banco = dr[0].ToString();
                    if (banco == _descricao_banco || banco == "")
                        return true;
                    else
                        return false;
                     
                   // return true;
                }
                return true;
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                return true;
            }
        }


        // private Progresso _progresso;
        string _arquivo = string.Empty;
        private ImpressaoBoleto _impressaoBoleto = new ImpressaoBoleto();
        public short _codigoBanco;
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
                html.Append("</br></br></br></br></br></br></br></br></br></br>");
            }

            _arquivo = System.IO.Path.GetTempFileName();

            using (FileStream f = new FileStream(_arquivo, FileMode.Create))
            {
                StreamWriter w = new StreamWriter(f, System.Text.Encoding.Default);
             // string  _html = HttpUtility.UrlEncode(html.ToString(), Encoding.GetEncoding(28597)).Replace("+", " ");
               // html = HttpUtility.UrlEncode(html.ToString(), Encoding.GetEncoding(28597)).Replace("+", " ");
                w.Write(html);
                w.Close();
                f.Close();

            }


            //// instantiate the html to pdf converter 
            // HtmlToPdf converter = new HtmlToPdf();

            //// convert the url to pdf 
            //PdfDocument doc = converter.ConvertUrl(url);

            //// save pdf document 
            //doc.Save(file);

            //// close pdf document 
            //doc.Close();

            //// lbl.Text = txt.Text;//.Content;
            // DataTable dt = new DataTable();
            // dt.Columns.Add("Data", typeof(string));
            // dt.Rows.Add(html.ToString());
            // dt.TableName = "DataTable1";

            // //ReportDocument cryRpt = new ReportDocument();
            //// cryRpt.Load(Server.MapPath("~/Report/CrystalReport.rpt"));
            // //cryRpt.SetDataSource(dt);
            // //CrystalReportViewer1.ReportSource = cryRpt;

            // crBoleto cr = new crBoleto();
            // cr.SetDataSource(dt);
            // form_imprimir imp = new form_imprimir(cr);
            // imp.Show();


        }
        #endregion


        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //_progresso.Close();

            // Cria um formulário com um componente WebBrowser dentro

            _impressaoBoleto.webBrowser.Navigate(_arquivo);



            _impressaoBoleto.ShowDialog();
            GerarPdf(_impressaoBoleto.bmp, _impressaoBoleto.n_nf);


        }

        private void imprimir_boleto()
        {
            //_progresso.Close();

            // Cria um formulário com um componente WebBrowser dentro

            _impressaoBoleto.webBrowser.Navigate(_arquivo);
            


            _impressaoBoleto.ShowDialog();
            GerarPdf(_impressaoBoleto.bmp, _impressaoBoleto.n_nf);


        }

        private void button26_Click(object sender, EventArgs e)
        { 
            form_itens_nf_ent infe = new form_itens_nf_ent();
            try
            {
               
                infe.ShowDialog();
            }
            finally
            {
                double saldo = infe.saldo;
                bool continuar = true;
                object ultimoItem = new object();
                string n_nf_ent = "", cod_sistema_nf_ent = "";
                string chave_acesso = buscar_chave_item_ent(infe.cod_item_nota_ent, out n_nf_ent, out cod_sistema_nf_ent);
                form_qtde_devolucao dev = new form_qtde_devolucao();
                try
                {
                    dev.ShowDialog();
                }
                finally
                {
                    
                    if (dev.qtde > saldo)
                    {
                        continuar = false;
                        MessageBox.Show("Saldo insuficiente para essa quantidade de devolução.");
                    }
                    else
                    {
                        FbCommand selectItens = new FbCommand();
                        selectItens.Connection = fbConnection1;
                        selectItens.CommandText =
                               @"SELECT DESCRICAO_ITEM_ENT, CFOP_ITEM_ENT, CST_IPI_TRIB_ITEM_ENT, CST_IPI_N_TRIB_ITEM_ENT, UNIDADE_ITEM_ENT, QTDE_ITEM_ENT, ST_ITEM_ENT, PRECO_UNIT_ITEM_ENT, PRECO_TOTAL_ITEM_ENT, IPI_ITEM_ENT, ICM_ITEM_ENT, 
                                                VALOR_IPI_ITEM_ENT, PEDIDO_COMPRA_ITEM_ENT, MAE_ITEM_ENT, COD_ITEM_ENT, NCM_ITEM_ENT, VALOR_ICM_ITEM_ENT, 
                                                VALOR_ISS_ITEM_ENT, PRESTACAO_SERVICO_ITEM_ENT, VALOR_BC_ITEM_ENT, VALOR_BC_ICMS_ST_ITEM_ENT, VALOR_ICMS_ST_ITEM_ENT,
                                                VALOR_FRETE_ITEM_ENT, VALOR_DESCONTO_ITEM_ENT, VALOR_SEGURO_ITEM_ENT, VALOR_OUTRAS_DESP_ITEM_ENT, IVA_ITEM_ENT, REDUCAO_ITEM_ENT, 
                                                COFINS_ITEM_ENT, VALOR_COFINS_ITEM_ENT, PIS_ITEM_ENT, VALOR_PIS_ITEM_ENT, ORIGEM_ITEM_ENT, MOD_BC_ITEM_ENT, ISS_ITEM_ENT, MOD_BC_ST_ITEM_ENT, 
                                                REDUCAO_ST_ITEM_ENT, ICMS_ST_ITEM_ENT, ALIQUOTA_CREDITO_ITEM_ENT, VALOR_CREDITO_ITEM_ENT, IPI_TRIB_ITEM_ENT, IPI_N_TRIB_ITEM_ENT, 
                                                TIPO_PIS_ITEM_ENT, CST_PIS_ITEM_ENT, TIPO_COFINS_ITEM_ENT, CST_COFINS_ITEM_ENT, 
                                                TIPO_SERVICO_ITEM_ENT, BC_IPI_ITEM_ENT, BC_PIS_ITEM_ENT, BC_COFINS_ITEM_ENT, BC_ISS_ITEM_ENT, BC_COM_IPI_ITEM_ENT, 
                                                ST_IMPRESSAO_ITEM_ENT, COD_EAN_ITEM_ENT FROM ITENS_NOTA_ENT WHERE COD_ITENS_NOTA_ENT = '" + infe.cod_item_nota_ent + "' ";
                        FbDataAdapter datTable = new FbDataAdapter();
                        DataSet dsTable = new DataSet();
                        datTable.SelectCommand = selectItens;
                        fbConnection1.Open();
                        datTable.Fill(dsTable);
                        fbConnection1.Close();

                        foreach (DataRow dr in dsTable.Tables[0].Rows)
                        {
                            try
                            {
                                string DESCRICAO_ITEM_ENT = dr["DESCRICAO_ITEM_ENT"].ToString(),
                                UNIDADE_ITEM_ENT = dr["UNIDADE_ITEM_ENT"].ToString(),
                                ST_ITEM_ENT = dr["ST_ITEM_ENT"].ToString(),
                                COD_ITEM_ENT = dr["COD_ITEM_ENT"].ToString(),
                                NCM_ITEM_ENT = dr["NCM_ITEM_ENT"].ToString(),
                                CFOP_ITEM_ENT = dr["CFOP_ITEM_ENT"].ToString(),
                                ORIGEM_ITEM_ENT = dr["ORIGEM_ITEM_ENT"].ToString(),
                                CST_IPI_TRIB_ITEM_ENT = dr["CST_IPI_TRIB_ITEM_ENT"].ToString(),
                                CST_IPI_N_TRIB_ITEM_ENT = dr["CST_IPI_N_TRIB_ITEM_ENT"].ToString(),
                                COD_EAN_ITEM_ENT = dr["COD_EAN_ITEM_ENT"].ToString();

                                if (DESCRICAO_ITEM_ENT.Length > 60)
                                    DESCRICAO_ITEM_ENT = DESCRICAO_ITEM_ENT.Remove(59);

                                double QTDE_DEV_ITEM_ENT = 0, QTDE_ITEM_ENT = 0, PRECO_UNIT_ITEM_ENT = 0, PRECO_TOTAL_ITEM_ENT = 0, IPI_ITEM_ENT = 0, ICM_ITEM_ENT = 0,
                                    VALOR_IPI_ITEM_ENT = 0, VALOR_ICM_ITEM_ENT = 0,
                                    VALOR_BC_ITEM_ENT = 0, VALOR_BC_ICMS_ST_ITEM_ENT = 0, VALOR_ICMS_ST_ITEM_ENT = 0,
                                    VALOR_FRETE_ITEM_ENT = 0, VALOR_DESCONTO_ITEM_ENT = 0, VALOR_SEGURO_ITEM_ENT = 0, VALOR_OUTRAS_DESP_ITEM_ENT = 0, IVA_ITEM_ENT = 0, REDUCAO_ITEM_ENT = 0,
                                    REDUCAO_ST_ITEM_ENT = 0, ICMS_ST_ITEM_ENT = 0, BC_IPI_ITEM_ENT = 0, IPI_TRIB_ITEM_ENT = 0, IPI_N_TRIB_ITEM_ENT = 0;

                                try { QTDE_DEV_ITEM_ENT = dev.qtde; }
                                catch { QTDE_DEV_ITEM_ENT = 0; }
                                try { QTDE_ITEM_ENT = Convert.ToDouble(dr["QTDE_ITEM_ENT"].ToString()); }
                                catch { QTDE_ITEM_ENT = 0; }
                                try { PRECO_UNIT_ITEM_ENT = Convert.ToDouble(dr["PRECO_UNIT_ITEM_ENT"].ToString()); }
                                catch { PRECO_UNIT_ITEM_ENT = 0; }
                                try { PRECO_TOTAL_ITEM_ENT = Convert.ToDouble(dr["PRECO_TOTAL_ITEM_ENT"].ToString()); }
                                catch { PRECO_TOTAL_ITEM_ENT = 0; }
                                try { IPI_ITEM_ENT = Convert.ToDouble(dr["IPI_ITEM_ENT"].ToString()); }
                                catch { IPI_ITEM_ENT = 0; }
                                try { ICM_ITEM_ENT = Convert.ToDouble(dr["ICM_ITEM_ENT"].ToString()); }
                                catch { ICM_ITEM_ENT = 0; }
                                try { VALOR_IPI_ITEM_ENT = Convert.ToDouble(dr["VALOR_IPI_ITEM_ENT"].ToString()); }
                                catch { VALOR_IPI_ITEM_ENT = 0; }
                                try { VALOR_ICM_ITEM_ENT = Convert.ToDouble(dr["VALOR_ICM_ITEM_ENT"].ToString()); }
                                catch { VALOR_ICM_ITEM_ENT = 0; }
                                try { VALOR_BC_ITEM_ENT = Convert.ToDouble(dr["VALOR_BC_ITEM_ENT"].ToString()); }
                                catch { VALOR_BC_ITEM_ENT = 0; }
                                try { VALOR_BC_ICMS_ST_ITEM_ENT = Convert.ToDouble(dr["VALOR_BC_ICMS_ST_ITEM_ENT"].ToString()); }
                                catch { VALOR_BC_ICMS_ST_ITEM_ENT = 0; }
                                try { VALOR_ICMS_ST_ITEM_ENT = Convert.ToDouble(dr["VALOR_ICMS_ST_ITEM_ENT"].ToString()); }
                                catch { VALOR_ICMS_ST_ITEM_ENT = 0; }
                                try { VALOR_FRETE_ITEM_ENT = Convert.ToDouble(dr["VALOR_FRETE_ITEM_ENT"].ToString()); }
                                catch { VALOR_FRETE_ITEM_ENT = 0; }
                                try { VALOR_DESCONTO_ITEM_ENT = Convert.ToDouble(dr["VALOR_DESCONTO_ITEM_ENT"].ToString()); }
                                catch { VALOR_DESCONTO_ITEM_ENT = 0; }
                                try { VALOR_SEGURO_ITEM_ENT = Convert.ToDouble(dr["VALOR_SEGURO_ITEM_ENT"].ToString()); }
                                catch { VALOR_SEGURO_ITEM_ENT = 0; }
                                try { VALOR_OUTRAS_DESP_ITEM_ENT = Convert.ToDouble(dr["VALOR_OUTRAS_DESP_ITEM_ENT"].ToString()); }
                                catch { VALOR_OUTRAS_DESP_ITEM_ENT = 0; }
                                try { IVA_ITEM_ENT = Convert.ToDouble(dr["IVA_ITEM_ENT"].ToString()); }
                                catch { IVA_ITEM_ENT = 0; }
                                try { REDUCAO_ITEM_ENT = Convert.ToDouble(dr["REDUCAO_ITEM_ENT"].ToString()); }
                                catch { REDUCAO_ITEM_ENT = 0; }
                                try { REDUCAO_ST_ITEM_ENT = Convert.ToDouble(dr["REDUCAO_ST_ITEM_ENT"].ToString()); }
                                catch { REDUCAO_ST_ITEM_ENT = 0; }
                                try { ICMS_ST_ITEM_ENT = Convert.ToDouble(dr["ICMS_ST_ITEM_ENT"].ToString()); }
                                catch { ICMS_ST_ITEM_ENT = 0; }
                                try { BC_IPI_ITEM_ENT = Convert.ToDouble(dr["BC_IPI_ITEM_ENT"].ToString()); }
                                catch { BC_IPI_ITEM_ENT = 0; }
                                try { IPI_TRIB_ITEM_ENT = Convert.ToDouble(dr["IPI_TRIB_ITEM_ENT"].ToString()); }
                                catch { IPI_TRIB_ITEM_ENT = 0; }
                                try { IPI_N_TRIB_ITEM_ENT = Convert.ToDouble(dr["IPI_N_TRIB_ITEM_ENT"].ToString()); }
                                catch { IPI_N_TRIB_ITEM_ENT = 0; }

                                if (QTDE_DEV_ITEM_ENT == 0)
                                    QTDE_DEV_ITEM_ENT = QTDE_ITEM_ENT;


                                try { PRECO_TOTAL_ITEM_ENT = PRECO_UNIT_ITEM_ENT * QTDE_DEV_ITEM_ENT; }
                                catch { PRECO_TOTAL_ITEM_ENT = 0; }

                                try { VALOR_IPI_ITEM_ENT = VALOR_IPI_ITEM_ENT * QTDE_DEV_ITEM_ENT / QTDE_ITEM_ENT; }
                                catch { VALOR_IPI_ITEM_ENT = 0; }
                                try { VALOR_ICM_ITEM_ENT = VALOR_ICM_ITEM_ENT * QTDE_DEV_ITEM_ENT / QTDE_ITEM_ENT; }
                                catch { VALOR_ICM_ITEM_ENT = 0; }
                                try { VALOR_BC_ITEM_ENT = VALOR_BC_ITEM_ENT * QTDE_DEV_ITEM_ENT / QTDE_ITEM_ENT; }
                                catch { VALOR_BC_ITEM_ENT = 0; }
                                try { VALOR_BC_ICMS_ST_ITEM_ENT = VALOR_BC_ICMS_ST_ITEM_ENT * QTDE_DEV_ITEM_ENT / QTDE_ITEM_ENT; }
                                catch { VALOR_BC_ICMS_ST_ITEM_ENT = 0; }
                                try { VALOR_ICMS_ST_ITEM_ENT = VALOR_ICMS_ST_ITEM_ENT * QTDE_DEV_ITEM_ENT / QTDE_ITEM_ENT; }
                                catch { VALOR_ICMS_ST_ITEM_ENT = 0; }
                                try { VALOR_FRETE_ITEM_ENT = VALOR_FRETE_ITEM_ENT * QTDE_DEV_ITEM_ENT / QTDE_ITEM_ENT; }
                                catch { VALOR_FRETE_ITEM_ENT = 0; }
                                try { VALOR_DESCONTO_ITEM_ENT = VALOR_DESCONTO_ITEM_ENT * QTDE_DEV_ITEM_ENT / QTDE_ITEM_ENT; }
                                catch { VALOR_DESCONTO_ITEM_ENT = 0; }
                                try { VALOR_SEGURO_ITEM_ENT = VALOR_SEGURO_ITEM_ENT * QTDE_DEV_ITEM_ENT / QTDE_ITEM_ENT; }
                                catch { VALOR_SEGURO_ITEM_ENT = 0; }
                                try { VALOR_OUTRAS_DESP_ITEM_ENT = VALOR_OUTRAS_DESP_ITEM_ENT * QTDE_DEV_ITEM_ENT / QTDE_ITEM_ENT; }
                                catch { VALOR_OUTRAS_DESP_ITEM_ENT = 0; }
                                try { BC_IPI_ITEM_ENT = BC_IPI_ITEM_ENT * QTDE_DEV_ITEM_ENT / QTDE_ITEM_ENT; }
                                catch { BC_IPI_ITEM_ENT = 0; }

                                if (CST_IPI_N_TRIB_ITEM_ENT == "55")
                                {
                                    CST_IPI_N_TRIB_ITEM_ENT = "53";
                                }
                                FbCommand insertItens = new FbCommand();
                                insertItens.Connection = fbConnection1;
                                insertItens.CommandText =
                                       "INSERT INTO ITENS_NOTA(" +
                                    "DESCRICAO_ITEM, UNIDADE_ITEM, QTDE_ITEM, ST_ITEM, PRECO_UNIT_ITEM, PRECO_TOTAL_ITEM, IPI_ITEM, ICM_ITEM, " +
                                    "VALOR_IPI_ITEM, COD_ITEM, NCM_ITEM, CFOP_ITEM, VALOR_ICM_ITEM, " +
                                    "VALOR_BC_ITEM, VALOR_BC_ICMS_ST_ITEM, VALOR_ICMS_ST_ITEM, " +
                                    "VALOR_FRETE_ITEM, VALOR_DESCONTO_ITEM, VALOR_SEGURO_ITEM, VALOR_OUTRAS_DESP_ITEM, IVA_ITEM, REDUCAO_ITEM, " +
                                    "ORIGEM_ITEM, " +
                                    "REDUCAO_ST_ITEM, ICMS_ST_ITEM, IPI_TRIB_ITEM, IPI_N_TRIB_ITEM, " +
                                    "CST_IPI_TRIB_ITEM, CST_IPI_N_TRIB_ITEM, " +
                                    "BC_IPI_ITEM, " +
                                    "COD_EAN_ITEM) VALUES ('" +
                                    DESCRICAO_ITEM_ENT + "','" + UNIDADE_ITEM_ENT + "','" + QTDE_DEV_ITEM_ENT.ToString().Replace(".", "").Replace(",", ".") + "','" +
                                    ST_ITEM_ENT + "','" + PRECO_UNIT_ITEM_ENT.ToString().Replace(".", "").Replace(",", ".") + "','" +
                                    PRECO_TOTAL_ITEM_ENT.ToString().Replace(".", "").Replace(",", ".") + "','" + IPI_ITEM_ENT.ToString().Replace(".", "").Replace(",", ".") + "','" +
                                    ICM_ITEM_ENT.ToString().Replace(".", "").Replace(",", ".") + "','" + VALOR_IPI_ITEM_ENT.ToString().Replace(".", "").Replace(",", ".") + "','" +
                                    COD_ITEM_ENT + "','" + NCM_ITEM_ENT + "','" + CFOP_ITEM_ENT + "','" + VALOR_ICM_ITEM_ENT.ToString().Replace(".", "").Replace(",", ".") + "','" +
                                    VALOR_BC_ITEM_ENT.ToString().Replace(".", "").Replace(",", ".") + "','" + VALOR_BC_ICMS_ST_ITEM_ENT.ToString().Replace(".", "").Replace(",", ".") + "','" +
                                    VALOR_ICMS_ST_ITEM_ENT.ToString().Replace(".", "").Replace(",", ".") + "','" + VALOR_FRETE_ITEM_ENT.ToString().Replace(".", "").Replace(",", ".") + "','" +
                                    VALOR_DESCONTO_ITEM_ENT.ToString().Replace(".", "").Replace(",", ".") + "','" + VALOR_SEGURO_ITEM_ENT.ToString().Replace(".", "").Replace(",", ".") + "','" +
                                    VALOR_OUTRAS_DESP_ITEM_ENT.ToString().Replace(".", "").Replace(",", ".") + "','" + IVA_ITEM_ENT.ToString().Replace(".", "").Replace(",", ".") + "','" +
                                    REDUCAO_ITEM_ENT.ToString().Replace(".", "").Replace(",", ".") + "','" + ORIGEM_ITEM_ENT + "','" + REDUCAO_ST_ITEM_ENT.ToString().Replace(".", "").Replace(",", ".") + "','" +
                                    ICMS_ST_ITEM_ENT.ToString().Replace(".", "").Replace(",", ".") + "','" + IPI_TRIB_ITEM_ENT + "','" + IPI_N_TRIB_ITEM_ENT + "','" +
                                    CST_IPI_TRIB_ITEM_ENT + "','" + CST_IPI_N_TRIB_ITEM_ENT + "','" + BC_IPI_ITEM_ENT.ToString().Replace(".", "").Replace(",", ".") + "','" + COD_EAN_ITEM_ENT + "') RETURNING COD_ITENS_NOTA";

                                FbDataAdapter datItensNota = new FbDataAdapter();
                                datItensNota.InsertCommand = insertItens;
                                fbConnection1.Open();
                                ultimoItem = datItensNota.InsertCommand.ExecuteScalar();
                                fbConnection1.Close();

                                // string ultimoItem = buscarUltimoItem();
                                string _cod_barras;
                                string _cst = buscar_cst_item(ultimoItem, out _cod_barras);
                                try
                                { //FINALIZAR ISSO
                                    string cfop_entrada = dr[1].ToString();
                                    string cfop = "5202";
                                    if (cfop_entrada == "5917")
                                        cfop = "5918";
                                    if (cfop_entrada.Substring(2, 1) == "4")
                                        cfop = "5411";
                                    if (cfop_entrada == "5901")
                                    {
                                        cfop = "5902";
                                        if (!tb_natureza_operacao.Text.Contains("RETORNO"))
                                            tb_natureza_operacao.Text += " / RETORNO DE INDUSTRIALIZACAO";
                                    }


                                    string ipi_trib = "null", ipi_n_trib = "null";
                                    if (dr["IPI_TRIB_ITEM_ENT"].ToString() != "" || dr["IPI_TRIB_ITEM_ENT"].ToString() == null)
                                        ipi_trib = "1";
                                    else
                                    {
                                        ipi_n_trib = "1";

                                    }

                                    string cst = " ST_ITEM = '900', ";
                                    if (crt_empresa != "1")
                                    {
                                        cst = "";
                                    }

                                    //if (cnpj_nf_entrada != "" && cnpj_cliente_entrada == cnpj_empresa)
                                    //{
                                    //    cfop = "1949";
                                    //    if (_cst == "101")
                                    //    {
                                    //        cfop = "1202";
                                    //        cst = " ST_ITEM = '900', ";
                                    //    }

                                    //    if (_cst == "500")
                                    //    {
                                    //        cfop = "1411";
                                    //        cst = " ST_ITEM = '900', ";
                                    //    }


                                    //}


                                    FbCommand update = new FbCommand();
                                    update.Connection = fbConnection1;
                                    update.CommandText = "UPDATE ITENS_NOTA SET COD_SISTEMA_NF_ITEM = '" + tb_cod_interno.Text + "', NF_ITEM = '" + tb_n_nf.Text + "', " + cst + " MOD_BC_ST_ITEM = '4', MOD_BC_ITEM = 3, " +
                                        "CFOP_ITEM = '" + cfop + "', IPI_TRIB_ITEM = " + ipi_trib + ", IPI_N_TRIB_ITEM = " + ipi_n_trib + ", " +
                                        "CST_PIS_ITEM = '06', CST_COFINS_ITEM = '06', TIPO_PIS_ITEM = '3 - Não Tributado', " +
                                        "TIPO_COFINS_ITEM = '3 - Não Tributado', COD_EAN_ITEM = '" + _cod_barras + "', N_NF_ENT_ITEM = " + n_nf_ent + " " +
                                        "WHERE COD_ITENS_NOTA = '" + ultimoItem + "'";
                                    FbDataAdapter datUpdate = new FbDataAdapter();
                                    datUpdate.UpdateCommand = update;
                                    fbConnection1.Open();
                                    datUpdate.UpdateCommand.ExecuteNonQuery();
                                    fbConnection1.Close();
                                }
                                catch (Exception a)
                                {
                                    fbConnection1.Close();
                                    MessageBox.Show(a.Message, "Erro Update Item");
                                }


                            }
                            catch (Exception a)
                            {
                                MessageBox.Show(a.Message, "Erro ao inserir item");
                                fbConnection1.Close();
                            }

                        }
                    }
                }
                if (continuar)
                {
                    form_nfs_referenciadas nf = new form_nfs_referenciadas();
                    try
                    {
                        //colocar os dados da nf_referenciada e testar o xml
                        nf.chave_referenciada = chave_acesso;
                        nf.cod_itens_nota_ent = infe.cod_item_nota_ent;
                        nf.cod_itens_nota_saida = ultimoItem.ToString();
                        nf.cod_sistema_nfent = cod_sistema_nf_ent;
                        nf.n_nf_referenciada = n_nf_ent;
                        nf.cod_sistema_n_nf_saida = tb_cod_interno.Text;
                        nf.ShowDialog();
                    }
                    finally
                    {
                        selecionar_itens();
                        calcular();
                    }
                }
            }
        }

        private void selecionar_itens()
        {
            try
            {
                dsItens_nota.Clear();
                this.datItens_nota.SelectCommand.CommandText =
                     "SELECT * FROM ITENS_NOTA WHERE COD_SISTEMA_NF_ITEM = '" + tb_cod_interno.Text + "' order by cod_itens_nota";
                this.fbConnection1.Open();
                this.datItens_nota.SelectCommand.Connection = fbConnection1;
                this.datItens_nota.SelectCommand.ExecuteNonQuery();
                datItens_nota.Fill(ITENS_NOTA);
                this.fbConnection1.Close();
            }
            catch(Exception ex)
            {
                fbConnection1.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private string buscar_chave_item_ent(string cod_item_nota_ent, out string n_nf_ent, out string cod_sistema_nf_ent)
        {
            n_nf_ent = ""; cod_sistema_nf_ent = "";
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                fbConnection1.Open();
                select.CommandText =
                    @"SELECT CHAVE_ACESSO_NF_ENT, N_NF_ENT, COD_SISTEMA_NF_ENT FROM NOTA_FISCAL_ENT nfent 
                        INNER JOIN ITENS_NOTA_ENT infent on nfent.COD_SISTEMA_NF_ENT = infent.COD_SISTEMA_NF_ITEM_ENT 
                        where COD_ITENS_NOTA_ENT = '" + cod_item_nota_ent + "'";
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();
                foreach(DataRow dr in dtSelect.Rows)
                {
                    n_nf_ent = dr[1].ToString();
                    cod_sistema_nf_ent = dr[2].ToString();
                    return dr[0].ToString();
                }
                return "";
            }
            catch(Exception ex)
            {
                fbConnection1.Close();
                MessageBox.Show(ex.Message);
                return "";
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            form_nfs_referenciadas nf = new form_nfs_referenciadas();
            try
            {
                //colocar os dados da nf_referenciada e testar o xml
                
                nf.cod_sistema_n_nf_saida = tb_cod_interno.Text;
                nf.ShowDialog();
            }
            finally
            {
               
            }
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
            try
            {
                imp.boleto = true;
                imp.n_nfe = tb_n_nf.Text;
                imp.imprimir_direto = imprimir_nota_e_boleto;
                if (imprimir_nota_e_boleto)
                {
                    imp.ShowDialog();
                }
                else
                {
                    imp.Show();
                }
            }
            catch { }
            finally
            {
                if (imprimir_nota_e_boleto)
                {
                    cr.Close();
                    cr.Dispose();
                    cr = null;

                    imp.Dispose();
                    imp.Close();
                    imp = null;

                    ds.Dispose();
                    ds.Clear();

                    //Cleanup crystal report's mess in memory
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                }
            }

        }
        //#endregion Eventos do BackgroundWorker

        public void gerar_pdf(string _html)
        {
            /*
            Byte[] res = null;
            using (MemoryStream ms = new MemoryStream())
            {

                var pdf = TheArtOfDev.HtmlRenderer.PdfSharp.PdfGenerator.GeneratePdf(_html, PdfSharp.PageSize.A4);
                pdf.Save(ms);
                res = ms.ToArray();
            }
             * */
            //return res;
            /*
            
            PdfGenerateConfig config = new PdfGenerateConfig();
            config.PageSize = PageSize.A4;
            config.SetMargins(20);
            //_mainControl.SetHtml(_html);
            var doc = PdfGenerator.GeneratePdf(_html, config, null, DemoUtils.OnStylesheetLoad, HtmlRenderingHelper.OnImageLoadPdfSharp);
            var tmpFile = Path.GetTempFileName();
            tmpFile = Path.GetFileNameWithoutExtension(tmpFile) + ".pdf";
            doc.Save(tmpFile);
            Process.Start(tmpFile);
            */
        }



        #region BOLETO BRADESCO
        public void GeraBoletoBradesco(int qtde, int i)
        {

            // Cria o boleto, e passa os parâmetros usuais
            BoletoBancario bb;

            List<BoletoBancario> boletos = new List<BoletoBancario>();


            bb = new BoletoBancario();
            bb.CodigoBanco = _codigoBanco;
            bb.OcultarInstrucoes = true;
            bb.MostrarComprovanteEntrega = true;
            DateTime vencimento = Convert.ToDateTime(dgvFatura_nf.Rows[i].Cells["col_data"].Value);

            int dias_protesto = 0;
            try
            {
                dias_protesto = Convert.ToInt32(_dias_protesto);
            }
            catch { }
            Instrucao_Bradesco item = new Instrucao_Bradesco(81, dias_protesto);

            item.QuantidadeDias = dias_protesto;

            //CEDENTE


            Cedente c = new Cedente(cnpj_empresa, razao_social_empresa, _agencia, _dig_agencia, _cc, _dig_cc);
            c.Codigo = _codigo_no_banco;// "13000";

            //cliente
            string logradouro, bairro, cep, cidade, complemento, numero, uf;
            double desconto;
            int desconto_valor, desconto_pontualidade;
            selecionar_dados_cliente(tb_cnpj_cliente.Text, out logradouro, out bairro, out cep, out cidade,
                out complemento, out numero, out uf, out desconto, out desconto_valor, out desconto_pontualidade);

            Endereco end = new Endereco();
            end.Bairro = bairro;
            end.CEP = cep;
            end.Cidade = cidade;
            end.Complemento = complemento;
            end.End = logradouro + ", " + numero + " - " + complemento;
           // end.End = logradouro;
            end.Numero = numero;
            end.UF = estado_empresa;
            string nosso_numero = "";
            DateTime data_nota = Convert.ToDateTime(tb_data_emissao.Text);
            if (data_nota <= Convert.ToDateTime("23.12.2015"))
            {
                nosso_numero = tb_n_nf.Text;
            }
            else
            {//cliente + duplicata + nf(pedido)
                int duplicata = i + 1;
                nosso_numero = detectar_cod_cliente(tb_cnpj_cliente.Text) + duplicata.ToString() +
                    tb_n_nf.Text;
            }
            int digito = i + 1;
            Boleto b = new Boleto(vencimento, Convert.ToDecimal(dgvFatura_nf.Rows[i].Cells["col_valor"].Value.ToString()), _carteira, nosso_numero, c);
            b.NumeroDocumento = nosso_numero;
            b.DataDocumento = Convert.ToDateTime(tb_data_emissao.Text);
            b.DataProcessamento = Convert.ToDateTime(tb_data_emissao.Text);
            b.Sacado = new Sacado(tb_cnpj_cliente.Text, tb_cliente.Text);
            b.Sacado.Endereco = end;


            item.Descricao += " *** VALORES EXPRESSOS EM REAIS *** <br>";

            double mora = Convert.ToDouble(dgvFatura_nf.Rows[i].Cells["col_valor"].Value.ToString()) * Convert.ToDouble(_mora);
            double multa = Convert.ToDouble(dgvFatura_nf.Rows[i].Cells["col_valor"].Value.ToString()) * Convert.ToDouble(_multa);



            item.Descricao += " MORA DIA/COM. PERMANÊNCIA ................................. " + mora.ToString("n2") + "<br>";
            item.Descricao += " APÓS " + vencimento.ToShortDateString() + " MULTA ................................. " + multa.ToString("n2") + "<br>";
            item.Descricao += " DEPÓSITO BANCÁRIO NÃO QUITA O BOLETO" + "<br>";
            item.Descricao += " PROTESTO AUTOMÁTICO APÓS " + item.QuantidadeDias.ToString() + " DIAS" + "<br>";
            b.Instrucoes.Add(item); //"Não Receber após o vencimento");

            bb.Boleto = b;
            bb.Boleto.Valida();

            boletos.Add(bb);


            GeraLayout(boletos);
        }
        #endregion
        #region BOLETO SANTANDER
        public void GeraBoletoSantander(int qtde)
        {

            // Cria o boleto, e passa os parâmetros usuais
            BoletoBancario bb;

            List<BoletoBancario> boletos = new List<BoletoBancario>();
            for (int i = 0; i < dgvFatura_nf.RowCount; i++)
            {

                bb = new BoletoBancario();
                bb.CodigoBanco = _codigoBanco;
                bb.OcultarInstrucoes = true;
                bb.MostrarComprovanteEntrega = true;
                DateTime vencimento = Convert.ToDateTime(dgvFatura_nf.Rows[i].Cells["col_data"].Value);

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
                int desconto_valor, desconto_pontualidade;
                selecionar_dados_cliente(tb_cnpj_cliente.Text, out logradouro, out bairro, out cep, out cidade,
                    out complemento, out numero, out uf, out desconto, out desconto_valor, out desconto_pontualidade);

                Endereco end = new Endereco();
                end.Bairro = bairro;
                end.CEP = cep;
                end.Cidade = cidade;
                end.Complemento = complemento;
                end.End = logradouro + ", " + numero + " - " + complemento;
                //end.Logradouro = logradouro;
                end.Numero = numero;
                end.UF = estado_empresa;
                string  nosso_numero = dgvFatura_nf.Rows[i].Cells["col_cr_fatura"].Value.ToString();
                
                int digito = i + 1;
                Boleto b = new Boleto(vencimento, Convert.ToDecimal(dgvFatura_nf.Rows[i].Cells["col_valor"].Value.ToString()), _carteira, nosso_numero, c);
                b.NumeroDocumento = tb_n_nf.Text;

                b.Sacado = new Sacado(tb_cnpj_cliente.Text, tb_cliente.Text);
                b.Sacado.Endereco = end;
                b.DataDocumento = Convert.ToDateTime(tb_data_emissao.Text);
                b.DataProcessamento = Convert.ToDateTime(tb_data_emissao.Text);
                item.Descricao += " <br>Carteira 101 - Cobrança Simples Rápida com Registro - RCR<br>";
                item.Descricao += " <br> *** VALORES EXPRESSOS EM REAIS *** <br>";

                //NOVO
                EspecieDocumento especie = new EspecieDocumento(Convert.ToInt32(_cod_banco));
                especie.Codigo = "01";
                b.EspecieDocumento = especie;
                //NOVO

                double mora = Convert.ToDouble(dgvFatura_nf.Rows[i].Cells["col_valor"].Value.ToString()) * Convert.ToDouble(_mora) / 100;
                double multa = Convert.ToDouble(dgvFatura_nf.Rows[i].Cells["col_valor"].Value.ToString()) * Convert.ToDouble(_multa) / 100;

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
            }

            GeraLayout(boletos);
        }
        #endregion
        private void selecionar_dados_cliente(string cnpj, out string logradouro, out string bairro, out string cep, out string cidade,
            out string complemento, out string numero, out string uf, out double desconto, out int desconto_valor, out int desconto_pontualidade)
        {
            logradouro = ""; bairro = ""; cep = ""; cidade = ""; complemento = ""; numero = ""; uf = "";
            desconto = 0; desconto_valor = 0; desconto_pontualidade = 0;
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
                    try
                    {
                        desconto_valor = Convert.ToInt32(dr["DESCONTO_VALOR_CLIENTE"].ToString());
                    }
                    catch { }
                    try
                    {
                        desconto_pontualidade = Convert.ToInt32(dr["DESCONTO_INSTRUCAO_CLIENTE"].ToString());
                    }
                    catch { }
                }


            }
            catch (Exception a)
            {
                fbConnection1.Close();
            }
        }


        #region BOLETO BANCO DO BRASIL
        public void GeraBoletoBB(int qtde)
        {

            // Cria o boleto, e passa os parâmetros usuais
            BoletoBancario bb;

            List<BoletoBancario> boletos = new List<BoletoBancario>();
            for (int i = 0; i < qtde; i++)
            {

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
            }

            GeraLayout(boletos);
        }
        #endregion

        #region BOLETO Caixa
        private void GeraBoletoCaixa(int qtde)
        {
            // qtde = 0;
            // Cria o boleto, e passa os parâmetros usuais
            BoletoBancario bb;

            List<BoletoBancario> boletos = new List<BoletoBancario>();
            for (int i = 0; i < dgvFatura_nf.RowCount; i++)
            {

                bb = new BoletoBancario();
                bb.CodigoBanco = _codigoBanco;
                bb.OcultarInstrucoes = true;


                // Instrucao_Caixa item = new Instrucao_Caixa(
                // bb.Instrucoes.Add(
                bb.MostrarComprovanteEntrega = true;

                DateTime vencimento = Convert.ToDateTime(dgvFatura_nf.Rows[i].Cells["col_data"].Value);

                //Instrucao_Bradesco item = new Instrucao_Bradesco(6, 5);

                Instrucao_Caixa item = new Instrucao_Caixa(10, 0);
                if (Convert.ToInt16(_dias_protesto) > 0)
                {
                    Instrucao_Caixa item2 = new Instrucao_Caixa(9, Convert.ToInt16(_dias_protesto));
                    item = item2;
                }

                //Instrucao_Caixa item2 = new Instrucao_Caixa(81, 10);
                //CEDENTE


                Cedente c = new Cedente(cnpj_empresa, razao_social_empresa + " " + cnpj_empresa + " " + endereco_empresa + ", " + n_endereco_empresa +
                    " " + cidade_empresa + " " + estado_empresa, _agencia, _dig_agencia, _cc, _dig_cc);
                c.Codigo = _codigo_no_banco;// "13000";
                // _carteira = "SR-14";
                c.Carteira = _carteira;
                //cliente
                string logradouro, bairro, cep, cidade, complemento, numero, uf;
                double desconto;
                int desconto_valor, desconto_pontualidade;
                selecionar_dados_cliente(tb_cnpj_cliente.Text, out logradouro, out bairro, out cep, out cidade,
                    out complemento, out numero, out uf, out desconto, out desconto_valor, out desconto_pontualidade);

                Endereco end = new Endereco();
                end.Bairro = bairro;
                end.CEP = cep;
                end.Cidade = cidade;
                end.Complemento = complemento;
                end.End = logradouro + ", " + numero + " - " + complemento;
             //   end.Logradouro = logradouro;
                end.Numero = numero;
                end.UF = estado_empresa;
                string nosso_numero = "";
                DateTime data_nota = Convert.ToDateTime(tb_data_emissao.Text);
                if (data_nota <= Convert.ToDateTime("23.12.2015"))
                {
                    nosso_numero = tb_n_nf.Text;
                }
                else
                {//cliente + duplicata + nf(pedido)
                    int duplicata = i + 1;
                    nosso_numero = detectar_cod_cliente(tb_cnpj_cliente.Text) + duplicata.ToString() +
                        tb_n_nf.Text;
                    if (nosso_numero.Length < 17)
                    {
                        nosso_numero = zero_a_esquerda_caixa(17, nosso_numero);
                    }
                }
                int digito = i + 1;
                Boleto b = new Boleto(vencimento, Convert.ToDecimal(dgvFatura_nf.Rows[i].Cells["col_valor"].Value.ToString()), _carteira, nosso_numero, c);
                b.NumeroDocumento = tb_n_nf.Text;
                b.NossoNumero = nosso_numero;
                b.Carteira = "1";
                b.DataDocumento = Convert.ToDateTime(tb_data_emissao.Text);
                b.DataProcessamento = Convert.ToDateTime(tb_data_emissao.Text);
                b.EspecieDocumento = new EspecieDocumento_Caixa("01");
                // b.EspecieDocumento = 
                b.Sacado = new Sacado(tb_cnpj_cliente.Text, tb_cliente.Text);
                b.Sacado.Endereco = end;


                item.Descricao += " *** VALORES EXPRESSOS EM REAIS *** <br>";

                double mora = Convert.ToDouble(dgvFatura_nf.Rows[i].Cells["col_valor"].Value.ToString()) * Convert.ToDouble(_mora);
                double multa = Convert.ToDouble(dgvFatura_nf.Rows[i].Cells["col_valor"].Value.ToString()) * Convert.ToDouble(_multa);

                item.Descricao += " MORA DIA/COM. PERMANÊNCIA ................................. " + mora.ToString("n2") + "<br>";
                item.Descricao += " APÓS " + vencimento.ToShortDateString() + " MULTA ................................. " + multa.ToString("n2") + "<br>";
                //item.Descricao += " PROTESTO AUTOMÁTICO APÓS " + item.QuantidadeDias.ToString() + " DIAS" + "<br>";
                item.Descricao += " SAC CAIXA: 0800 726 0101 (informações, reclamações, sugestões e elogios)";
                item.Descricao += " Para pessoas com deficiência auditiva ou de fala: 0800 726 2492";
                item.Descricao += " Ouvidoria: 0800 725 7474";
                item.Descricao += " caixa.gov.br";
                b.Instrucoes.Add(item); //"Não Receber após o vencimento");
                // b.Instrucoes.Add(item2);
                bb.Boleto = b;
                bb.Boleto.QuantidadeMoeda = 0;
                try
                {
                    bb.Boleto.Valida();
                    boletos.Add(bb);
                }
                catch { }
            }

            GeraLayout(boletos);

            /*
            // Cria o boleto, e passa os parâmetros usuais
            BoletoBancario bb;

            List<BoletoBancario> boletos = new List<BoletoBancario>();
            for (int i = 0; i < qtde; i++)
            {

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
            }

            GeraLayout(boletos);
             * */
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
            bb.MostrarComprovanteEntrega = true;
            bb.OcultarInstrucoes = true;
            DateTime vencimento = Convert.ToDateTime(dgvFatura_nf.Rows[i].Cells["col_data"].Value);
            int p = 0;
            //CEDENTE

           // Instrucao_Itau item = new Instrucao_Itau(10); //sem protesto

            int dias = Convert.ToInt16(_dias_protesto);
            Instrucao_Itau item;
            if (dias > 0)
                item = new Instrucao_Itau(9, dias); //protesto apenas para o boleto
            else
                item = new Instrucao_Itau(10); //sem protesto
            Cedente c = new Cedente(cnpj_empresa, razao_social_empresa, _agencia, _dig_agencia, _cc, _dig_cc);
            c.Codigo = _codigo_no_banco;// "13000";

            //cliente
            string logradouro, bairro, cep, cidade, complemento, numero, uf;
            double desconto;
            int desconto_valor, desconto_pontualidade;
            selecionar_dados_cliente(tb_cnpj_cliente.Text, out logradouro, out bairro, out cep, out cidade,
                out complemento, out numero, out uf, out desconto, out desconto_valor, out desconto_pontualidade);

            Instrucao_Itau item3 = new Instrucao_Itau(999, desconto);

            Endereco end = new Endereco();
            end.Bairro = bairro;
            end.CEP = cep;
            end.Cidade = cidade;
            end.Complemento = complemento;
            end.End = logradouro + ", " + numero + " - " + complemento;
            
            end.Numero = numero;
            end.UF = estado_empresa;

            //  Cedente c = new Cedente("00.000.000/0000-00", "Empresa de Atacado", "0542", "13000");
            //Na carteira 198 o código do Cedente é a conta bancária
            //c.Codigo = "13000";
            string nosso_numero = "";
            string cliente = "";
            DateTime data_nota = Convert.ToDateTime(tb_data_emissao.Text);
           
            int duplicata = i;
            nosso_numero = dgvFatura_nf.Rows[i].Cells["col_cr_fatura"].Value.ToString();
            
            int digito = i + 1;

            double valor_boleto = Convert.ToDouble(dgvFatura_nf.Rows[i].Cells["col_valor"].Value.ToString());
           
            if (desconto > 0)
            {
                if (desconto_valor == 1)
                    valor_boleto = valor_boleto - (valor_boleto * desconto / 100);
            }

            Boleto b = new Boleto(vencimento, Convert.ToDecimal(valor_boleto), _carteira, nosso_numero, c);
            b.NumeroDocumento = tb_n_nf.Text;
            b.DataDocumento = Convert.ToDateTime(tb_data_emissao.Text);
            b.DataProcessamento = Convert.ToDateTime(tb_data_emissao.Text);
            b.Sacado = new Sacado(tb_cnpj_cliente.Text, tb_cliente.Text);
            b.Sacado.Endereco = end;

          


            item.Descricao += "<br> *** VALORES EXPRESSOS EM REAIS *** <br>";

            double mora = 0;
            try
            {
                mora = Convert.ToDouble(dgvFatura_nf.Rows[i].Cells["col_valor"].Value.ToString()) * Convert.ToDouble(_mora)/100;
            }
            catch { }
            double multa = 0;
            try
            {
                multa = Convert.ToDouble(dgvFatura_nf.Rows[i].Cells["col_valor"].Value.ToString()) * Convert.ToDouble(_multa)/100;
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
            if (desconto > 0 && desconto_pontualidade == 1)
            {
               
                b.DataDesconto = vencimento;
                decimal _desconto = Convert.ToDecimal(dgvFatura_nf.Rows[i].Cells["col_valor"].Value.ToString()) * Convert.ToDecimal(desconto) / 100;
                descricao_desconto = " CONCEDER DESCONTO DE R$ " + _desconto.ToString("n2") + " ATÉ DIA: " + vencimento.ToShortDateString();
                b.OutrosDescontos = Convert.ToDecimal(dgvFatura_nf.Rows[i].Cells["col_valor"].Value.ToString()) * Convert.ToDecimal(desconto) / 100;
                b.DataOutrosDescontos = vencimento;
                b.ValorDesconto = _desconto;
            }

            item.Descricao += " MORA DIA/COM. PERMANÊNCIA ................................. " + mora.ToString("n2") + "<br>";
            item.Descricao += " APÓS " + vencimento.ToShortDateString() + " MULTA ................................. " + multa.ToString("n2") + "<br>";
            item.Descricao += " DEPÓSITO BANCÁRIO NÃO QUITA O BOLETO" + "<br>";
          //  item.Descricao += " PROTESTO AUTOMÁTICO APÓS " + item.QuantidadeDias.ToString() + " DIAS" + "<br>";
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

        #region BOLETO SICREDI
        private void GeraBoletoSicredi(int i)
        {
            // Cria o boleto, e passa os parâmetros usuais
            BoletoBancario bb;

            List<BoletoBancario> boletos = new List<BoletoBancario>();
            // for (int i = 0; i < dgvFatura_nf.RowCount; i++)
            // {

            bb = new BoletoBancario();
            bb.CodigoBanco = _codigoBanco;
            bb.MostrarComprovanteEntrega = true;
            bb.OcultarInstrucoes = true;
            DateTime vencimento = Convert.ToDateTime(dgvFatura_nf.Rows[i].Cells["col_data"].Value);
            Instrucao_Sicredi item = new Instrucao_Sicredi(9, 5);
       //     Instrucao_Itau item2 = new Instrucao_Itau(81, 10);

            //CEDENTE

          //  Instrucao_Itau item = new Instrucao_Itau(9, 5);
            // Instrucao_Itau item1 = new Instrucao_Itau(9, 5);
            // Instrucao_Itau item2 = new Instrucao_Itau(81, 10);
            Cedente c = new Cedente(cnpj_empresa, razao_social_empresa, _agencia, _dig_agencia, _cc, _dig_cc);
            c.Codigo = _codigo_no_banco;// "13000";

            //cliente
            string logradouro, bairro, cep, cidade, complemento, numero, uf;
            double desconto;
            int desconto_valor, desconto_pontualidade;
            selecionar_dados_cliente(tb_cnpj_cliente.Text, out logradouro, out bairro, out cep, out cidade,
                out complemento, out numero, out uf, out desconto, out desconto_valor, out desconto_pontualidade);
           
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
            DateTime data_nota = Convert.ToDateTime(tb_data_emissao.Text);
           
                int duplicata = i + 1;
                nosso_numero = duplicata.ToString() +
                    tb_n_nf.Text;

            nosso_numero =  zero_a_esquerda_santander(9, nosso_numero);
            
            int digito = i + 1;
            Boleto b = new Boleto(vencimento, Convert.ToDecimal(dgvFatura_nf.Rows[i].Cells["col_valor"].Value.ToString()), _carteira, nosso_numero, c);
            b.NumeroDocumento = nosso_numero;
            b.DataDocumento = Convert.ToDateTime(tb_data_emissao.Text);
            b.DataProcessamento = Convert.ToDateTime(tb_data_emissao.Text);
            b.Sacado = new Sacado(tb_cnpj_cliente.Text, tb_cliente.Text);
            b.Sacado.Endereco = end;

            //Boleto b = new Boleto(vencimento, 1642, "198", "92082835", c, new EspecieDocumento(341, "1"));
            //b.NumeroDocumento = Convert.ToString(10000 + i);

            //b.Sacado = new Sacado("000.000.000-00", "Fulano de Silva");
            // b.Sacado.Endereco.End = "SSS 154 Bloco J Casa 23";
            //b.Sacado.Endereco.Bairro = "Testando";
            //b.Sacado.Endereco.Cidade = "Testelândia";
            //b.Sacado.Endereco.CEP = "70000000";
            //b.Sacado.Endereco.UF = "DF";


            item.Descricao += " *** VALORES EXPRESSOS EM REAIS *** <br>";

            double mora = 0;
            try
            {
                mora = Convert.ToDouble(dgvFatura_nf.Rows[i].Cells["col_valor"].Value.ToString()) * Convert.ToDouble(_mora) / 100;
            }
            catch { }
            double multa = 0;
            try
            {
                multa = Convert.ToDouble(dgvFatura_nf.Rows[i].Cells["col_valor"].Value.ToString()) * Convert.ToDouble(_multa) / 100;
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
                decimal _desconto = Convert.ToDecimal(dgvFatura_nf.Rows[i].Cells["col_valor"].Value.ToString()) * Convert.ToDecimal(desconto) / 100;
                descricao_desconto = " CONCEDER DESCONTO DE R$ " + _desconto.ToString("n2") + " ATÉ DIA: " + vencimento.ToShortDateString();
                b.OutrosDescontos = Convert.ToDecimal(dgvFatura_nf.Rows[i].Cells["col_valor"].Value.ToString()) * Convert.ToDecimal(desconto) / 100;
                b.DataOutrosDescontos = vencimento;

            }

            item.Descricao += " MORA DIA/COM. PERMANÊNCIA ................................. " + mora.ToString("n2") + "<br>";
            item.Descricao += " APÓS " + vencimento.ToShortDateString() + " MULTA ................................. " + multa.ToString("n2") + "<br>";
            item.Descricao += " DEPÓSITO BANCÁRIO NÃO QUITA O BOLETO" + "<br>";
            item.Descricao += " PROTESTO AUTOMÁTICO APÓS " + item.QuantidadeDias.ToString() + " DIAS" + "<br>";
            item.Descricao += descricao_desconto;

            b.Instrucoes.Add(item); //"Não Receber após o vencimento");
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
        public void GeraBoletoUnibanco(int qtde)
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
                //b.Sacado.Endereco.Logradouro = "Rua Dr. Henrique Portugal";
                b.Sacado.Endereco.Numero = "XX";
                b.Sacado.Endereco.Complemento = "Casa";

                instr.Descricao = "Não Receber após o vencimento";
                b.Instrucoes.Add(instr);

                bb.Boleto = b;
                bb.Boleto.Valida();

                boletos.Add(bb);
            }

            GeraLayout(boletos);
        }
        #endregion


        #region BOLETO SUDAMERIS
        public void GeraBoletoSudameris(int qtde)
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
            }

            GeraLayout(boletos);
        }
        #endregion


        #region BOLETO SAFRA
        public void GeraBoletoSafra(int qtde)
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
            }

            GeraLayout(boletos);
        }
        #endregion


        #region BOLETO REAL
        public void GeraBoletoReal(int qtde)
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
            }

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
                    GeraBoletoBradesco(1, 0);
                    break;

                case 104: // Caixa
                    GeraBoletoCaixa(1);
                    break;

                case 33: // Caixa
                    GeraBoletoSantander(1);
                    break;
            }

        }

        private void definir_banco(int i)
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
                    GeraBoletoItau(i);
                    break;

                case 356: // Real
                    GeraBoletoReal(1);
                    break;

                case 399: // Hsbc
                    GeraBoletoItau(1);
                    break;

                case 237: // Bradesco
                    GeraBoletoBradesco(1, i);
                    break;

                case 104: // Caixa
                    GeraBoletoCaixa(1);
                    break;

                case 33: // Caixa
                    GeraBoletoSantander(1);
                    break;

                case 748: // Caixa
                    GeraBoletoSicredi(i);
                    break;
            }


        }

        private string buscar_banco_nota(string n_nf)
        {
            try
            {
                FbCommand select = new FbCommand();
                select.CommandText =
                    "SELECT CC_CR FROM CONTAS_A_RECEBER WHERE NF_CR = '" + n_nf + "'";
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
            catch
            {
                fbConnection1.Close();
                return "0";
            }
        }

        private void dgvPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(dgvPedidos.Rows[0].Cells["col_pedido"].Value.ToString()) > 1000000)
                { //vem do romaneio
                    acertar_status_romaneio();
                }
                else
                {
                    inserir_status_pedido();
                }
            }
            catch { }
            //acertarEstoque();

            classe_particularidades part = new classe_particularidades();
            part.cod_sistema_nf = tb_cod_interno.Text;
            part.executar_particularidades(tb_n_nf.Text); //aqui dá baixa nos romaneios e itens_pedido
            part.baixar_do_estoque();

            //inserir_status_pedido();
        }

        private void dgvItens_nota_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button17_Click_1(object sender, EventArgs e)
        {
            //apaga_faturas_anteriores();
            inserir_duplicatas_cr();
        }

        private void rb_5949_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button17_Click_2(object sender, EventArgs e)
        {
            if (dgvFatura_nf.RowCount > 0 && dgvFatura_nf.Rows[0].Cells["col_cr_fatura"].Value.ToString() != "")
                MessageBox.Show("Já existem Faturas registradas para essa NF. Para gerar novas faturas você deve cancelá-las antes.");
            else
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
                            Atualizar(true);
                            if (boleto_pedido_empresa != "1")
                                inserir_duplicatas_cr();
                            gerar_boletos();
                        }
                        else
                        {
                            MessageBox.Show("Usuário não autorizado");
                        }
                    }
                }
            }

        }

        private string buscarUltimoItem()
        {
            string encontrada = "";
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                select.CommandText =
                    "SELECT first(1) COD_ITENS_NOTA FROM ITENS_NOTA ORDER BY COD_ITENS_NOTA DESC";
                fbConnection1.Open();
                DataSet notas = new DataSet();
                datNota_fiscal.SelectCommand = select;
                datNota_fiscal.Fill(notas);
                if (notas.Tables[0].Rows.Count > 0)
                {
                    DataRow dr = notas.Tables[0].Rows[0];
                    encontrada = dr[0].ToString();
                }
                else
                {
                    MessageBox.Show("Nenhuma nota encontrada");
                }
                fbConnection1.Close();
                return encontrada;

            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
                fbConnection1.Close();
                return encontrada;
            }
        }

        private void carregaNf(string nf)
        {
            try
            {
                dsNota_fiscal.Clear();
                dsItens_nota.Clear();
                dsFatura_nf.Clear();

                this.datNota_fiscal.SelectCommand.CommandText =
                "SELECT * FROM NOTA_FISCAL WHERE N_NF = '" + nf + "' and CNPJ_EMISSOR_NF = '" + cnpj_empresa + "'";
                this.fbConnection1.Open();
                this.datNota_fiscal.SelectCommand.Connection = fbConnection1;
                this.datNota_fiscal.SelectCommand.ExecuteNonQuery();
                datNota_fiscal.Fill(NOTA_FISCAL);
                this.fbConnection1.Close();

                this.datItens_nota.SelectCommand.CommandText =
                    //"SELECT * FROM ITENS_NOTA WHERE NF_ITEM = '" + tb_n_nf.Text + "' order by cod_itens_nota";
                     "SELECT * FROM ITENS_NOTA WHERE COD_SISTEMA_NF_ITEM = '" + tb_cod_interno.Text + "' order by cod_itens_nota";
                this.fbConnection1.Open();
                this.datItens_nota.SelectCommand.Connection = fbConnection1;
                this.datItens_nota.SelectCommand.ExecuteNonQuery();
                datItens_nota.Fill(ITENS_NOTA);
                this.fbConnection1.Close();

                this.datFatura_nf.SelectCommand.CommandText =
                    //"SELECT * FROM FATURA_NF WHERE NF_FATURA = '" + tb_n_nf.Text + "'";
                "SELECT * FROM FATURA_NF WHERE COD_SISTEMA_NF_FATURA = '" + tb_cod_interno.Text + "'";
                this.fbConnection1.Open();
                this.datFatura_nf.SelectCommand.Connection = fbConnection1;
                this.datFatura_nf.SelectCommand.ExecuteNonQuery();
                datFatura_nf.Fill(FATURA_NF);
                this.fbConnection1.Close();

                dsPedidos_nf.Clear();
                this.datPedidos_nf.SelectCommand.CommandText =
                    "SELECT * FROM PEDIDOS_NF WHERE COD_SISTEMA_PEDIDO_NF = '" + tb_cod_interno.Text + "'";
                // "SELECT * FROM PEDIDOS_NF WHERE NF_PEDIDO_NF = '" + tb_n_nf.Text + "'"; COD_SISTEMA_PEDIDO_NF
                /*"SELECT pnf.*, pv.vendedor_ped_venda " + 
                "FROM PEDIDOS_NF pnf " + 
                "INNER JOIN pedidos_venda pv " + 
                "ON pv.cod_ped_venda = pnf.n_pedido_nf " + 
                "WHERE NF_PEDIDO_NF = '" + tb_n_nf.Text + "'";*/
                this.fbConnection1.Open();
                this.datPedidos_nf.SelectCommand.Connection = fbConnection1;
                this.datPedidos_nf.SelectCommand.ExecuteNonQuery();
                datPedidos_nf.Fill(PEDIDOS_NF);
                this.fbConnection1.Close();
            }
            catch (Exception a)
            {
                fbConnection1.Close();
                MessageBox.Show(a.ToString());
            }
        }


        private void button20_Click(object sender, EventArgs e)
        {
            replicar_nota_devolucao(false);
        }

        private string ultimaSistema()
        {
            string encontrada = "";
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                select.CommandText =
                    "SELECT first(1) COD_SISTEMA_NF FROM NOTA_FISCAL ORDER BY COD_SISTEMA_NF DESC";
                fbConnection1.Open();
                DataSet notas = new DataSet();

                    FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                datSelect.Fill(notas);

                if (notas.Tables[0].Rows.Count > 0)
                {
                    DataRow dr = notas.Tables[0].Rows[0];
                    encontrada = dr[0].ToString();
                }
                else
                {
                    MessageBox.Show("Nenhuma nota encontrada");
                }
                fbConnection1.Close();
                return encontrada;

            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
                fbConnection1.Close();
                return encontrada;
            }
        }

        private int buscar_ultima_nf()
        {
            int encontrada = 0;
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                select.CommandText =
                    "SELECT first(1) N_NF FROM NOTA_FISCAL ORDER BY N_NF DESC";
                fbConnection1.Open();
                DataSet notas = new DataSet();
                datNota_fiscal.SelectCommand = select;
                datNota_fiscal.Fill(notas);

                if (notas.Tables[0].Rows.Count > 0)
                {
                    DataRow dr = notas.Tables[0].Rows[0];
                    encontrada = Convert.ToInt32(dr[0].ToString());
                }
                else
                {
                    MessageBox.Show("Nenhuma nota encontrada");
                }
                fbConnection1.Close();
                return encontrada;

            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
                fbConnection1.Close();
                return encontrada;
            }

        }

        private void buscar_informacoes_nota_entrada(string n_nf, out string cnpj_nf_entrada, out string razao_social_entrada, out string cnpj_cliente_forn, out string natureza_entrada)
        {
            cnpj_nf_entrada = ""; razao_social_entrada = ""; cnpj_cliente_forn = ""; natureza_entrada = "";
            try
            {
                FbCommand select = new FbCommand();
                fbConnection1.Open();
                select.Connection = fbConnection1;
                select.CommandText =
                    "SELECT RAZAO_DESTINATARIO_NF_ENT, CNPJ_DESTINATARIO_NF_ENT, CNPJ_CLIENTE_FORN_ENT, NATUREZA_OPERACAO_NF_ENT FROM NOTA_FISCAL_ENT WHERE COD_SISTEMA_NF_ENT = '" + n_nf + "'";
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();

                foreach (DataRow dr in dtSelect.Rows)
                {
                    cnpj_nf_entrada = dr[1].ToString();
                    razao_social_entrada = dr[0].ToString();
                    cnpj_cliente_forn = dr[2].ToString();
                    natureza_entrada = dr[3].ToString();
                }
            }
            catch (Exception a)
            {
                fbConnection1.Close();
            }
        }

        private string buscar_cfop(string natureza_entrada)
        {

            string encontrada = "";
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                select.CommandText =
                    "SELECT N_CFO FROM CFO WHERE DESCRICAO_CFO = '" + natureza_entrada + "'";
                fbConnection1.Open();
                DataSet notas = new DataSet();
                datNota_fiscal.SelectCommand = select;
                datNota_fiscal.Fill(notas);
                fbConnection1.Close();
                foreach (DataRow dr in notas.Tables[0].Rows)
                {
                    return dr[0].ToString();
                }
                return encontrada;
            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
                fbConnection1.Close();
                return encontrada;
            }


        }

        private string buscar_natureza(string cfop)
        {
            string encontrada = "";
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                select.CommandText =
                    "SELECT DESCRICAO_CFO FROM CFO WHERE N_CFO = '" + cfop + "'";
                fbConnection1.Open();
                DataSet notas = new DataSet();
                datNota_fiscal.SelectCommand = select;
                datNota_fiscal.Fill(notas);
                fbConnection1.Close();
                foreach (DataRow dr in notas.Tables[0].Rows)
                {
                    return dr[0].ToString();
                }
                return encontrada;
            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
                fbConnection1.Close();
                return encontrada;
            }
        }

        private void buscar_estado_cliente(string cnpj_nf_entrada, out string estado_cliente)
        {
            estado_cliente = "";
            try
            {
                FbCommand select = new FbCommand();
                fbConnection1.Open();
                select.Connection = fbConnection1;
                select.CommandText =
                    "SELECT ESTADO FROM CLIENTES WHERE CNPJ = '" + cnpj_nf_entrada + "'";
                FbDataAdapter datSelect = new FbDataAdapter();
                datSelect.SelectCommand = select;
                DataTable dtSelect = new DataTable();
                datSelect.Fill(dtSelect);
                fbConnection1.Close();

                foreach (DataRow dr in dtSelect.Rows)
                {
                    estado_cliente = dr[0].ToString();
                }
            }
            catch (Exception a)
            {
                fbConnection1.Close();
            }
        }

        private string buscar_cst_item(object ultimoItem, out string _cod_barra_item)
        {
            string encontrada = "";
            _cod_barra_item = "";
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                select.CommandText =
                    "SELECT ST_ITEM, COD_EAN_ITEM FROM ITENS_NOTA WHERE COD_ITENS_NOTA = '" + ultimoItem + "' ORDER BY COD_ITENS_NOTA DESC";
                fbConnection1.Open();
                DataSet notas = new DataSet();
                datNota_fiscal.SelectCommand = select;
                datNota_fiscal.Fill(notas);
                fbConnection1.Close();
                foreach (DataRow dr in notas.Tables[0].Rows)
                {
                    _cod_barra_item = buscarEanProduto(dr[1].ToString());
                    return dr[0].ToString();
                }
                return encontrada;
            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
                fbConnection1.Close();
                return encontrada;
            }
        }

        private string buscarEanProduto(string cod)
        {
            try
            {
                FbCommand comando = new FbCommand();
                comando.Connection = fbConnection1;
                comando.CommandText =
                    "SELECT COD_BARRAS_PRODUTO FROM PRODUTOS WHERE " +
                    "(COD_BARRAS_PRODUTO = '" + cod + "' or COD_BARRAS_CAIXA_PRODUTO = '" + cod + "')";
                DataSet itens = new DataSet();
                fbConnection1.Open();
                datProdutos.SelectCommand = comando;
                datProdutos.Fill(itens);
                fbConnection1.Close();

                foreach (DataRow dr in itens.Tables[0].Rows)
                {
                    return dr[0].ToString();
                }
                return cod;
            }
            catch
            {
                fbConnection1.Close();
                return cod;
            }

        }
        /*
        private void replicar_nota_devolucao(bool complemento)
        {
            if (DialogResult.Yes == MessageBox.Show("Uma nova NF será criada",
                "Deseja Continuar?", MessageBoxButtons.YesNo))
            {
                form_localiza_nf_ent abre_nf = new form_localiza_nf_ent();
                try
                {
                    //this.Close();
                    abre_nf.ShowDialog();
                }
                finally
                {
                    if (abre_nf.n_nf.Trim() != "")
                    {
                        string dataAtual = Convert.ToDateTime(DateTime.Now).ToShortDateString().Replace("/", ".");
                        string notaUltima = "";
                        string n_nf_entrada = abre_nf.numero_nota_correto;
                        try
                        {
                            double valor_nota_complemento = 0;
                            if (complemento)
                            {
                                try
                                {
                                    FbCommand selectItens = new FbCommand();
                                    selectItens.Connection = fbConnection1;
                                    selectItens.CommandText =
                                        "SELECT SUM(PRECO_TOTAL_ITEM_ENT) " +
                                        "FROM ITENS_NOTA_ENT WHERE COD_SISTEMA_NF_item_ENT = '" + abre_nf.n_nf + "' AND CFOP_ITEM_ENT = '5102' ";
                                    FbDataAdapter datTable = new FbDataAdapter();
                                    DataSet dsTable = new DataSet();
                                    datTable.SelectCommand = selectItens;
                                    fbConnection1.Open();
                                    datTable.Fill(dsTable);
                                    fbConnection1.Close();
                                    foreach (DataRow dr in dsTable.Tables[0].Rows)
                                    {
                                        try
                                        {
                                            valor_nota_complemento = Convert.ToDouble(dr[0].ToString());
                                        }
                                        catch { }
                                    }
                                }
                                catch (Exception a)
                                {
                                    fbConnection1.Close();
                                }
                            }

                            bool continua = false;
                            if (!complemento)
                                continua = true;
                            else
                            {
                                if (valor_nota_complemento > 0)
                                    continua = true;
                            }

                            if (continua)
                            {
                                int nf = 0;
                                FbCommand insertNf = new FbCommand();
                                insertNf.Connection = fbConnection1;
                                insertNf.CommandText =
                                    "INSERT INTO NOTA_FISCAL(" +
                                    "ALIQUOTA_SIMPLES_NF, BAIRRO_CL_NF, BASE_CALC_ICM_SUBS, BASE_CALC_ICMS_NF, BASE_CALCULO_ISS_NF, " +
                                    "BENEFICIAMENTO_NF, CEP_CL_NF, CFO_2_NF, CFO_NF, CIDADE_CL_NF, CLIENTE_FORN_NF, CNPJ_CL_NF, " +
                                    "CNPJ_CLIENTE_FORN, COBRANCA_NF, " +
                                    "DATA_VENCIMENTO_NF, EMAIL_CL_NF, END_NUMERO_STRING_NF, ENDERECO_ENTREGA_NF, ENTRADA_NF, " +
                                    "ENTRADA_SAIDA_NF, ESPECIE_NF, ESTADO_CL_NF, ESTADO_CLIENTE_NF, ESTADO_VEICULO_NF, EXPORTACAO_NF, " +
                                    "FONE_CL_NF, FRETE_CONTA_NF, IE_CL_NF, INF_COMPL_NF, LOCAL_EMBARQUE_EXPORTACAO, MARCA_NF, " +
                                    "N_NF_REFERENCIADA_NF, NATUREZA_OPERACAO_NF, NFE_TESTE, OBS_NF, OUTRAS_DESP_NF, " +
                                    "PAIS_CL_NF, PESO_BRUTO_NF, PESO_LIQUIDO_NF, PLACA_VEICULO_NF, QTDE_NF, RAZAO_SOCIAL_CL_NF, " +
                                    "REFERENCIADA_NF, SAIDA_NF, TIPO_MVTO_NF, TRANSPORTADORA_NF, TRIBUTADA_NF, " +
                                    "UF_EMBARQUE_EXPORTACAO, VALOR_EXTENSO_NF, VALOR_FRETE_NF, VALOR_ICM_SUBS, VALOR_ICMS_NF, " +
                                    "VALOR_IPI_NF, VALOR_ISS_NF, VALOR_NOTA_NF, VALOR_SEGURO_NF, VALOR_SIMPLES_NF, " +
                                    "VALOR_TOT_PROD_NF, VALOR_TOTAL_SERVICOS_NF) " +
                                    "SELECT ALIQUOTA_SIMPLES_NF_ENT, BAIRRO_CL_NF_ENT, BASE_CALC_ICM_SUBS_ENT, BASE_CALC_ICMS_NF_ENT, BASE_CALCULO_ISS_NF_ENT, " +
                                    "BENEFICIAMENTO_NF_ENT, CEP_CL_NF_ENT, CFO_2_NF_ENT, CFO_NF_ENT, CIDADE_CL_NF_ENT, CLIENTE_FORN_NF_ENT, CNPJ_CL_NF_ENT, " +
                                    "CNPJ_CLIENTE_FORN_ENT, COBRANCA_NF_ENT, " +
                                    "DATA_VENCIMENTO_NF_ENT, EMAIL_CL_NF_ENT, END_NUMERO_STRING_NF_ENT, ENDERECO_ENTREGA_NF_ENT, ENTRADA_NF_ENT, " +
                                    "ENTRADA_SAIDA_NF_ENT, ESPECIE_NF_ENT, ESTADO_CL_NF_ENT, ESTADO_CLIENTE_NF_ENT, ESTADO_VEICULO_NF_ENT, EXPORTACAO_NF_ENT, " +
                                    "FONE_CL_NF_ENT, FRETE_CONTA_NF_ENT, IE_CL_NF_ENT, INF_COMPL_NF_ENT, LOCAL_EMBARQUE_EXPORTACAO_ENT, MARCA_NF_ENT, " +
                                    "CHAVE_ACESSO_NF_ENT, NATUREZA_OPERACAO_NF_ENT, NFE_TESTE_ENT, OBS_NF_ENT, OUTRAS_DESP_NF_ENT, " +
                                    "PAIS_CL_NF_ENT, PESO_BRUTO_NF_ENT, PESO_LIQUIDO_NF_ENT, PLACA_VEICULO_NF_ENT, QTDE_NF_ENT, RAZAO_SOCIAL_CL_NF_ENT, " +
                                    "REFERENCIADA_NF_ENT, SAIDA_NF_ENT, TIPO_MVTO_NF_ENT, TRANSPORTADORA_NF_ENT, TRIBUTADA_NF_ENT, " +
                                    "UF_EMBARQUE_EXPORTACAO_ENT, VALOR_EXTENSO_NF_ENT, VALOR_FRETE_NF_ENT, VALOR_ICM_SUBS_ENT, VALOR_ICMS_NF_ENT, " +
                                    "VALOR_IPI_NF_ENT, VALOR_ISS_NF_ENT, VALOR_NOTA_NF_ENT, VALOR_SEGURO_NF_ENT, VALOR_SIMPLES_NF_ENT, " +
                                    "VALOR_TOT_PROD_NF_ENT, VALOR_TOTAL_SERVICOS_NF_ENT FROM NOTA_FISCAL_ENT WHERE COD_SISTEMA_NF_ENT = '" + abre_nf.n_nf + "'";
                                FbDataAdapter datIns = new FbDataAdapter();
                                datIns.InsertCommand = insertNf;
                                fbConnection1.Open();
                                datIns.InsertCommand.ExecuteNonQuery();
                                fbConnection1.Close();

                                nf = buscar_ultima_nf();
                                nf++;
                                notaUltima = nf.ToString();
                                string cnpj_cliente_entrada = "", cnpj_nf_entrada = "", razao_social_entrada = "", natureza_entrada = "", inf_compl = "REFERENTE A SUA NF No: ", natureza = "DEVOLUCAO";
                                buscar_informacoes_nota_entrada(abre_nf.n_nf.Trim(), out cnpj_nf_entrada, out razao_social_entrada, out cnpj_cliente_entrada, out natureza_entrada);
                                string _cfop = buscar_cfop(natureza_entrada);
                                if (_cfop == "5949")
                                {
                                    natureza = "OUTRAS ENTRADAS";
                                }
                                string estado_cliente = "";
                                string mudar_cliente = "";
                                if (cnpj_nf_entrada != "" && cnpj_cliente_entrada == cnpj_empresa)
                                {
                                    buscar_estado_cliente(cnpj_nf_entrada, out estado_cliente);
                                    inf_compl = "REFERENTE A NOSSA NF No:";
                                    if (complemento)
                                        inf_compl = " COMPLEMENTO DE ICMS " + inf_compl;
                                    mudar_cliente = ", CLIENTE_FORN_NF = '" + razao_social_entrada + "', CNPJ_CLIENTE_FORN = '" + cnpj_nf_entrada +
                                        "', ESTADO_CLIENTE_NF = '" + estado_cliente + "', ENTRADA_SAIDA_NF = '0'";
                                    //   radioEntrada.Checked = true;

                                }
                                // falta colocar o nome que aparece embaixo da nota, acertar cfops e colocar que é entrada
                                //CLIENTE_FORN_NF, CNPJ_CL_NF, " +
                                //   "CNPJ_CLIENTE_FORN
                                try
                                {
                                    FbCommand update = new FbCommand();
                                    update.Connection = fbConnection1;
                                    update.CommandText =
                                        "UPDATE NOTA_FISCAL SET N_NF = '" + notaUltima + "', DATA_EMISSAO_NF = '" + dataAtual + "', NATUREZA_OPERACAO_NF = '" + natureza + "',  " +
                                        "SAIDA_NF = '1', FORMA_PGTO_NF = '2 - Outros', FRETE_CONTA_NF = '0', INF_COMPL_NF = '" + inf_compl + n_nf_entrada + "'" + mudar_cliente +
                                        "  WHERE COD_SISTEMA_NF = '" + ultimaSistema() + "'";
                                    FbDataAdapter datUpdate = new FbDataAdapter();
                                    datUpdate.UpdateCommand = update;
                                    fbConnection1.Open();
                                    datUpdate.UpdateCommand.ExecuteNonQuery();
                                    fbConnection1.Close();
                                }
                                catch (Exception a)
                                {
                                    fbConnection1.Close();
                                    MessageBox.Show(a.Message, "Erro Update Item");
                                }


                                if (complemento)
                                {
                                    FbCommand selectItens = new FbCommand();
                                    selectItens.Connection = fbConnection1;
                                    selectItens.CommandText =
                                        "SELECT FIRST(1) COD_ITENS_NOTA_ENT, CFOP_ITEM_ENT, CST_IPI_TRIB_ITEM_ENT, CST_IPI_N_TRIB_ITEM_ENT, CFOP_ITEM_ENT " +
                                        "FROM ITENS_NOTA_ENT WHERE COD_SISTEMA_NF_item_ENT = '" + abre_nf.n_nf + "' and CFOP_ITEM_ENT = '5102' ORDER BY COD_ITENS_NOTA_ENT";
                                    FbDataAdapter datTable = new FbDataAdapter();
                                    DataSet dsTable = new DataSet();
                                    datTable.SelectCommand = selectItens;
                                    fbConnection1.Open();
                                    datTable.Fill(dsTable);
                                    fbConnection1.Close();
                                    foreach (DataRow dr in dsTable.Tables[0].Rows)
                                    {

                                        try
                                        {
                                            string codItens = dr[0].ToString();
                                            FbCommand insertItens = new FbCommand();
                                            insertItens.Connection = fbConnection1;
                                            insertItens.CommandText =
                                                "INSERT INTO ITENS_NOTA(" +
                                                "DESCRICAO_ITEM, UNIDADE_ITEM, QTDE_ITEM, ST_ITEM, PRECO_UNIT_ITEM, PRECO_TOTAL_ITEM, IPI_ITEM, ICM_ITEM, " +
                                                "VALOR_IPI_ITEM, PEDIDO_COMPRA_ITEM, MAE_ITEM, COD_ITEM, NCM_ITEM, CFOP_ITEM, VALOR_ICM_ITEM, " +
                                                "VALOR_ISS_ITEM, PRESTACAO_SERVICO_ITEM, VALOR_BC_ITEM, VALOR_BC_ICMS_ST_ITEM, VALOR_ICMS_ST_ITEM, " +
                                                "VALOR_FRETE_ITEM, VALOR_DESCONTO_ITEM, VALOR_SEGURO_ITEM, VALOR_OUTRAS_DESP_ITEM, IVA_ITEM, REDUCAO_ITEM, " +
                                                "COFINS_ITEM, VALOR_COFINS_ITEM, PIS_ITEM, VALOR_PIS_ITEM, ORIGEM_ITEM, MOD_BC_ITEM, ISS_ITEM, MOD_BC_ST_ITEM, " +
                                                "REDUCAO_ST_ITEM, ICMS_ST_ITEM, ALIQUOTA_CREDITO_ITEM, VALOR_CREDITO_ITEM, IPI_TRIB_ITEM, IPI_N_TRIB_ITEM, " +
                                                "CST_IPI_TRIB_ITEM, CST_IPI_N_TRIB_ITEM, TIPO_PIS_ITEM, CST_PIS_ITEM, TIPO_COFINS_ITEM, CST_COFINS_ITEM, " +
                                                "TIPO_SERVICO_ITEM, BC_IPI_ITEM, BC_PIS_ITEM, BC_COFINS_ITEM, BC_ISS_ITEM, BC_COM_IPI_ITEM, " +
                                                "ST_IMPRESSAO_ITEM, COD_EAN_ITEM) " +
                                                "SELECT DESCRICAO_ITEM_ENT, UNIDADE_ITEM_ENT, QTDE_ITEM_ENT, ST_ITEM_ENT, PRECO_UNIT_ITEM_ENT, PRECO_TOTAL_ITEM_ENT, IPI_ITEM_ENT, ICM_ITEM_ENT, " +
                                                "VALOR_IPI_ITEM_ENT, PEDIDO_COMPRA_ITEM_ENT, MAE_ITEM_ENT, COD_ITEM_ENT, NCM_ITEM_ENT, CFOP_ITEM_ENT, VALOR_ICM_ITEM_ENT, " +
                                                "VALOR_ISS_ITEM_ENT, PRESTACAO_SERVICO_ITEM_ENT, VALOR_BC_ITEM_ENT, VALOR_BC_ICMS_ST_ITEM_ENT, VALOR_ICMS_ST_ITEM_ENT, " +
                                                "VALOR_FRETE_ITEM_ENT, VALOR_DESCONTO_ITEM_ENT, VALOR_SEGURO_ITEM_ENT, VALOR_OUTRAS_DESP_ITEM_ENT, IVA_ITEM_ENT, REDUCAO_ITEM_ENT, " +
                                                "COFINS_ITEM_ENT, VALOR_COFINS_ITEM_ENT, PIS_ITEM_ENT, VALOR_PIS_ITEM_ENT, ORIGEM_ITEM_ENT, MOD_BC_ITEM_ENT, ISS_ITEM_ENT, MOD_BC_ST_ITEM_ENT, " +
                                                "REDUCAO_ST_ITEM_ENT, ICMS_ST_ITEM_ENT, ALIQUOTA_CREDITO_ITEM_ENT, VALOR_CREDITO_ITEM_ENT, IPI_TRIB_ITEM_ENT, IPI_N_TRIB_ITEM_ENT, " +
                                                "CST_IPI_TRIB_ITEM_ENT, CST_IPI_N_TRIB_ITEM_ENT, TIPO_PIS_ITEM_ENT, CST_PIS_ITEM_ENT, TIPO_COFINS_ITEM_ENT, CST_COFINS_ITEM_ENT, " +
                                                "TIPO_SERVICO_ITEM_ENT, BC_IPI_ITEM_ENT, BC_PIS_ITEM_ENT, BC_COFINS_ITEM_ENT, BC_ISS_ITEM_ENT, BC_COM_IPI_ITEM_ENT, " +
                                                "ST_IMPRESSAO_ITEM_ENT, COD_EAN_ITEM_ENT FROM ITENS_NOTA_ENT WHERE COD_ITENS_NOTA_ENT = '" + codItens + "' RETURNING COD_ITENS_NOTA";
                                            FbDataAdapter datItensNota = new FbDataAdapter();
                                            datItensNota.InsertCommand = insertItens;
                                            fbConnection1.Open();
                                            object ultimoItem = datItensNota.InsertCommand.ExecuteScalar();
                                            fbConnection1.Close();

                                            // string ultimoItem = buscarUltimoItem();
                                            string _cod_barras_saida = "";
                                            string _cst = buscar_cst_item(ultimoItem, out _cod_barras_saida);
                                            try
                                            { //FINALIZAR ISSO

                                                string cfop = "5102";

                                                string ipi_trib = "null", ipi_n_trib = "null";
                                                if (dr[2].ToString() != "")
                                                    ipi_trib = "1";
                                                if (dr[3].ToString() != "")
                                                    ipi_n_trib = "1";


                                                string cst = " ST_ITEM = '900', ";
                                                if (crt_empresa != "1")
                                                {
                                                    cst = "";
                                                }



                                                double valor_icms_item = valor_nota_complemento * 18 / 100;
                                                FbCommand update = new FbCommand();
                                                update.Connection = fbConnection1;
                                                update.CommandText = "UPDATE ITENS_NOTA SET COD_ITEM = '1', DESCRICAO_ITEM = 'COMPLEMENTO DE ICMS', ST_ITEM = '00', PRECO_UNIT_ITEM = 0, PRECO_TOTAL_ITEM = 0, QTDE_ITEM = 1, " +
                                                    "ICM_ITEM = 18, VALOR_BC_ITEM = '" + valor_nota_complemento.ToString().Replace(".", "").Replace(",", ".") + "', " +
                                                    "VALOR_ICM_ITEM = '" + valor_icms_item.ToString().Replace(".", "").Replace(",", ".") + "', " +
                                                    "NF_ITEM = '" + notaUltima + "', " + cst + " MOD_BC_ST_ITEM = '4', MOD_BC_ITEM = 3, " +
                                                    "CFOP_ITEM = '" + cfop + "', IPI_TRIB_ITEM = " + ipi_trib + ", IPI_N_TRIB_ITEM = " + ipi_n_trib + ", " +
                                                    "CST_PIS_ITEM = '06', CST_COFINS_ITEM = '06', TIPO_PIS_ITEM = '3 - Não Tributado', TIPO_COFINS_ITEM = '3 - Não Tributado' " +
                                                    "WHERE COD_ITENS_NOTA = '" + ultimoItem + "'";
                                                FbDataAdapter datUpdate = new FbDataAdapter();
                                                datUpdate.UpdateCommand = update;
                                                fbConnection1.Open();
                                                datUpdate.UpdateCommand.ExecuteNonQuery();
                                                fbConnection1.Close();
                                            }
                                            catch (Exception a)
                                            {
                                                fbConnection1.Close();
                                                MessageBox.Show(a.Message, "Erro Update Item");
                                            }

                                        }
                                        catch (Exception a)
                                        {
                                            MessageBox.Show(a.Message, "Erro ao inserir item");
                                            fbConnection1.Close();
                                        }

                                    }


                                }
                                else
                                {

                                    FbCommand selectItens = new FbCommand();
                                    selectItens.Connection = fbConnection1;
                                    selectItens.CommandText =
                                        "SELECT COD_ITENS_NOTA_ENT, CFOP_ITEM_ENT, CST_IPI_TRIB_ITEM_ENT, CST_IPI_N_TRIB_ITEM_ENT, CFOP_ITEM_ENT " +
                                        "FROM ITENS_NOTA_ENT WHERE COD_SISTEMA_NF_item_ENT = '" + abre_nf.n_nf + "' ORDER BY COD_ITENS_NOTA_ENT";
                                    FbDataAdapter datTable = new FbDataAdapter();
                                    DataSet dsTable = new DataSet();
                                    datTable.SelectCommand = selectItens;
                                    fbConnection1.Open();
                                    datTable.Fill(dsTable);
                                    fbConnection1.Close();
                                    foreach (DataRow dr in dsTable.Tables[0].Rows)
                                    {

                                        try
                                        {
                                            string codItens = dr[0].ToString();
                                            FbCommand insertItens = new FbCommand();
                                            insertItens.Connection = fbConnection1;
                                            insertItens.CommandText =
                                                "INSERT INTO ITENS_NOTA(" +
                                                "DESCRICAO_ITEM, UNIDADE_ITEM, QTDE_ITEM, ST_ITEM, PRECO_UNIT_ITEM, PRECO_TOTAL_ITEM, IPI_ITEM, ICM_ITEM, " +
                                                "VALOR_IPI_ITEM, PEDIDO_COMPRA_ITEM, MAE_ITEM, COD_ITEM, NCM_ITEM, CFOP_ITEM, VALOR_ICM_ITEM, " +
                                                "VALOR_ISS_ITEM, PRESTACAO_SERVICO_ITEM, VALOR_BC_ITEM, VALOR_BC_ICMS_ST_ITEM, VALOR_ICMS_ST_ITEM, " +
                                                "VALOR_FRETE_ITEM, VALOR_DESCONTO_ITEM, VALOR_SEGURO_ITEM, VALOR_OUTRAS_DESP_ITEM, IVA_ITEM, REDUCAO_ITEM, " +
                                                "COFINS_ITEM, VALOR_COFINS_ITEM, PIS_ITEM, VALOR_PIS_ITEM, ORIGEM_ITEM, MOD_BC_ITEM, ISS_ITEM, MOD_BC_ST_ITEM, " +
                                                "REDUCAO_ST_ITEM, ICMS_ST_ITEM, ALIQUOTA_CREDITO_ITEM, VALOR_CREDITO_ITEM, IPI_TRIB_ITEM, IPI_N_TRIB_ITEM, " +
                                                "CST_IPI_TRIB_ITEM, CST_IPI_N_TRIB_ITEM, TIPO_PIS_ITEM, CST_PIS_ITEM, TIPO_COFINS_ITEM, CST_COFINS_ITEM, " +
                                                "TIPO_SERVICO_ITEM, BC_IPI_ITEM, BC_PIS_ITEM, BC_COFINS_ITEM, BC_ISS_ITEM, BC_COM_IPI_ITEM, " +
                                                "ST_IMPRESSAO_ITEM, COD_EAN_ITEM) " +
                                                "SELECT DESCRICAO_ITEM_ENT, UNIDADE_ITEM_ENT, QTDE_ITEM_ENT, ST_ITEM_ENT, PRECO_UNIT_ITEM_ENT, PRECO_TOTAL_ITEM_ENT, IPI_ITEM_ENT, ICM_ITEM_ENT, " +
                                                "VALOR_IPI_ITEM_ENT, PEDIDO_COMPRA_ITEM_ENT, MAE_ITEM_ENT, COD_ITEM_ENT, NCM_ITEM_ENT, CFOP_ITEM_ENT, VALOR_ICM_ITEM_ENT, " +
                                                "VALOR_ISS_ITEM_ENT, PRESTACAO_SERVICO_ITEM_ENT, VALOR_BC_ITEM_ENT, VALOR_BC_ICMS_ST_ITEM_ENT, VALOR_ICMS_ST_ITEM_ENT, " +
                                                "VALOR_FRETE_ITEM_ENT, VALOR_DESCONTO_ITEM_ENT, VALOR_SEGURO_ITEM_ENT, VALOR_OUTRAS_DESP_ITEM_ENT, IVA_ITEM_ENT, REDUCAO_ITEM_ENT, " +
                                                "COFINS_ITEM_ENT, VALOR_COFINS_ITEM_ENT, PIS_ITEM_ENT, VALOR_PIS_ITEM_ENT, ORIGEM_ITEM_ENT, MOD_BC_ITEM_ENT, ISS_ITEM_ENT, MOD_BC_ST_ITEM_ENT, " +
                                                "REDUCAO_ST_ITEM_ENT, ICMS_ST_ITEM_ENT, ALIQUOTA_CREDITO_ITEM_ENT, VALOR_CREDITO_ITEM_ENT, IPI_TRIB_ITEM_ENT, IPI_N_TRIB_ITEM_ENT, " +
                                                "CST_IPI_TRIB_ITEM_ENT, CST_IPI_N_TRIB_ITEM_ENT, TIPO_PIS_ITEM_ENT, CST_PIS_ITEM_ENT, TIPO_COFINS_ITEM_ENT, CST_COFINS_ITEM_ENT, " +
                                                "TIPO_SERVICO_ITEM_ENT, BC_IPI_ITEM_ENT, BC_PIS_ITEM_ENT, BC_COFINS_ITEM_ENT, BC_ISS_ITEM_ENT, BC_COM_IPI_ITEM_ENT, " +
                                                "ST_IMPRESSAO_ITEM_ENT, COD_EAN_ITEM_ENT FROM ITENS_NOTA_ENT WHERE COD_ITENS_NOTA_ENT = '" + codItens + "' RETURNING COD_ITENS_NOTA";
                                            FbDataAdapter datItensNota = new FbDataAdapter();
                                            datItensNota.InsertCommand = insertItens;
                                            fbConnection1.Open();
                                            object ultimoItem = datItensNota.InsertCommand.ExecuteScalar();
                                            fbConnection1.Close();

                                            // string ultimoItem = buscarUltimoItem();
                                            string _cod_barras;
                                            string _cst = buscar_cst_item(ultimoItem, out _cod_barras);
                                            try
                                            { //FINALIZAR ISSO
                                                string cfop_entrada = dr[1].ToString();
                                                string cfop = "5202";
                                                if (cfop_entrada == "5917")
                                                    cfop = "5918";

                                                string ipi_trib = "null", ipi_n_trib = "null";
                                                if (dr[2].ToString() != "")
                                                    ipi_trib = "1";
                                                if (dr[3].ToString() != "")
                                                    ipi_n_trib = "1";


                                                string cst = " ST_ITEM = '900', ";
                                                if (crt_empresa != "1")
                                                {
                                                    cst = "";
                                                }

                                                if (cnpj_nf_entrada != "" && cnpj_cliente_entrada == cnpj_empresa)
                                                {
                                                    cfop = "1949";
                                                    if (_cst == "101")
                                                    {
                                                        cfop = "1202";
                                                        cst = " ST_ITEM = '900', ";
                                                    }

                                                    if (_cst == "500")
                                                    {
                                                        cfop = "1411";
                                                        cst = " ST_ITEM = '900', ";
                                                    }

                                                    //   radioEntrada.Checked = true;
                                                    //Atualizar(false);
                                                }


                                                FbCommand update = new FbCommand();
                                                update.Connection = fbConnection1;
                                                update.CommandText = "UPDATE ITENS_NOTA SET NF_ITEM = '" + notaUltima + "', " + cst + " MOD_BC_ST_ITEM = '4', MOD_BC_ITEM = 3, " +
                                                    "CFOP_ITEM = '" + cfop + "', IPI_TRIB_ITEM = " + ipi_trib + ", IPI_N_TRIB_ITEM = " + ipi_n_trib + ", " +
                                                    "CST_PIS_ITEM = '06', CST_COFINS_ITEM = '06', TIPO_PIS_ITEM = '3 - Não Tributado', TIPO_COFINS_ITEM = '3 - Não Tributado', COD_EAN_ITEM = '" + _cod_barras + "' " +
                                                    "WHERE COD_ITENS_NOTA = '" + ultimoItem + "'";
                                                FbDataAdapter datUpdate = new FbDataAdapter();
                                                datUpdate.UpdateCommand = update;
                                                fbConnection1.Open();
                                                datUpdate.UpdateCommand.ExecuteNonQuery();
                                                fbConnection1.Close();
                                            }
                                            catch (Exception a)
                                            {
                                                fbConnection1.Close();
                                                MessageBox.Show(a.Message, "Erro Update Item");
                                            }

                                        }
                                        catch (Exception a)
                                        {
                                            MessageBox.Show(a.Message, "Erro ao inserir item");
                                            fbConnection1.Close();
                                        }

                                    }
                                }
                            }
                        }
                        catch (Exception a)
                        {
                            MessageBox.Show(a.Message, "Erro ao inserir nota");
                            fbConnection1.Close();
                        }
                        if (notaUltima != "")
                        {
                            carregaNf(notaUltima);
                            calcular();
                        }

                    }
                }
            }
            /*
            if (DialogResult.Yes == MessageBox.Show("Uma nova NF será criada",
                "Deseja Continuar?", MessageBoxButtons.YesNo))
            {
                form_pesquisa_nf abre_nf = new form_pesquisa_nf(cnpj_empresa);
                try
                {
                    //this.Close();
                    abre_nf.ShowDialog();
                }
                finally
                {
                    if (abre_nf.nf_escolhida.Trim() != "")
                    {
                        string dataAtual = Convert.ToDateTime(DateTime.Now).ToShortDateString().Replace("/", ".");
                        string notaUltima = "";
                        try
                        {
                            int nf = 0;
                            FbCommand insertNf = new FbCommand();
                            insertNf.Connection = fbConnection1;
                            insertNf.CommandText =
                                "INSERT INTO NOTA_FISCAL(" +
                                "ALIQUOTA_SIMPLES_NF, BAIRRO_CL_NF, BASE_CALC_ICM_SUBS, BASE_CALC_ICMS_NF, BASE_CALCULO_ISS_NF, " +
                                "BENEFICIAMENTO_NF, CEP_CL_NF, CFO_2_NF, CFO_NF, CIDADE_CL_NF, CLIENTE_FORN_NF, CNPJ_CL_NF, " +
                                "CNPJ_CLIENTE_FORN, COBRANCA_NF, " +
                                "DATA_VENCIMENTO_NF, DESCONTO_NF, EMAIL_CL_NF, END_NUMERO_STRING_NF, ENDERECO_ENTREGA_NF, ENTRADA_NF, " +
                                "ENTRADA_SAIDA_NF, ESPECIE_NF, ESTADO_CL_NF, ESTADO_CLIENTE_NF, ESTADO_VEICULO_NF, EXPORTACAO_NF, " +
                                "FONE_CL_NF, FRETE_CONTA_NF, IE_CL_NF, INF_COMPL_NF, LOCAL_EMBARQUE_EXPORTACAO, MARCA_NF, " +
                                "N_NF_REFERENCIADA_NF, NATUREZA_OPERACAO_NF, NFE_TESTE, OBS_NF, OUTRAS_DESP_NF, " +
                                "PAIS_CL_NF, PESO_BRUTO_NF, PESO_LIQUIDO_NF, PLACA_VEICULO_NF, QTDE_NF, RAZAO_SOCIAL_CL_NF, " +
                                "REFERENCIADA_NF, SAIDA_NF, TIPO_MVTO_NF, TR_CIDADE_CL_NF, TR_CNPJ_CL_NF, TR_END_NUMERO_STRING_NF, " +
                                "TR_ESTADO_CL_NF, TR_IE_CL_NF, TR_RAZAO_SOCIAL_CL_NF, TRANSPORTADORA_NF, TRIBUTADA_NF, " +
                                "UF_EMBARQUE_EXPORTACAO, VALOR_EXTENSO_NF, VALOR_FRETE_NF, VALOR_ICM_SUBS, VALOR_ICMS_NF, " +
                                "VALOR_II_NF, VALOR_IPI_NF, VALOR_ISS_NF, VALOR_NOTA_NF, VALOR_SEGURO_NF, VALOR_SIMPLES_NF, " +
                                "VALOR_TOT_PROD_NF, VALOR_TOTAL_SERVICOS_NF) " +
                                "SELECT ALIQUOTA_SIMPLES_NF, BAIRRO_CL_NF, BASE_CALC_ICM_SUBS, BASE_CALC_ICMS_NF, BASE_CALCULO_ISS_NF, " +
                                "BENEFICIAMENTO_NF, CEP_CL_NF, CFO_2_NF, CFO_NF, CIDADE_CL_NF, CLIENTE_FORN_NF, CNPJ_CL_NF, " +
                                "CNPJ_CLIENTE_FORN, COBRANCA_NF, " +
                                "DATA_VENCIMENTO_NF, DESCONTO_NF, EMAIL_CL_NF, END_NUMERO_STRING_NF, ENDERECO_ENTREGA_NF, ENTRADA_NF, " +
                                "ENTRADA_SAIDA_NF, ESPECIE_NF, ESTADO_CL_NF, ESTADO_CLIENTE_NF, ESTADO_VEICULO_NF, EXPORTACAO_NF, " +
                                "FONE_CL_NF, FRETE_CONTA_NF, IE_CL_NF, INF_COMPL_NF, LOCAL_EMBARQUE_EXPORTACAO, MARCA_NF, " +
                                "N_NF_REFERENCIADA_NF, NATUREZA_OPERACAO_NF, NFE_TESTE, OBS_NF, OUTRAS_DESP_NF, " +
                                "PAIS_CL_NF, PESO_BRUTO_NF, PESO_LIQUIDO_NF, PLACA_VEICULO_NF, QTDE_NF, RAZAO_SOCIAL_CL_NF, " +
                                "REFERENCIADA_NF, SAIDA_NF, TIPO_MVTO_NF, TR_CIDADE_CL_NF, TR_CNPJ_CL_NF, TR_END_NUMERO_STRING_NF, " +
                                "TR_ESTADO_CL_NF, TR_IE_CL_NF, TR_RAZAO_SOCIAL_CL_NF, TRANSPORTADORA_NF, TRIBUTADA_NF, " +
                                "UF_EMBARQUE_EXPORTACAO, VALOR_EXTENSO_NF, VALOR_FRETE_NF, VALOR_ICM_SUBS, VALOR_ICMS_NF, " +
                                "VALOR_II_NF, VALOR_IPI_NF, VALOR_ISS_NF, VALOR_NOTA_NF, VALOR_SEGURO_NF, VALOR_SIMPLES_NF, " +
                                "VALOR_TOT_PROD_NF, VALOR_TOTAL_SERVICOS_NF FROM NOTA_FISCAL WHERE N_NF = '" + abre_nf.nf_escolhida + "' AND CNPJ_EMISSOR_NF = '" + cnpj_empresa + "'";
                            FbDataAdapter datIns = new FbDataAdapter();
                            datIns.InsertCommand = insertNf;
                            fbConnection1.Open();
                            datIns.InsertCommand.ExecuteNonQuery();
                            fbConnection1.Close();
                            string cod_sistema = "";

                           nf = buscar_ultima_nf(cnpj_empresa, out cod_sistema);
                           // nf = buscar_ultima_nf(cnpj_empresa);
                            nf++;
                            notaUltima = nf.ToString();
                            try
                            {
                                FbCommand update = new FbCommand();
                                update.Connection = fbConnection1;
                                update.CommandText =
                                    "UPDATE NOTA_FISCAL SET N_NF = '" + notaUltima + "', DATA_EMISSAO_NF = '" + dataAtual + "' WHERE COD_SISTEMA_NF = '" + ultimaSistema() + "'";
                                FbDataAdapter datUpdate = new FbDataAdapter();
                                datUpdate.UpdateCommand = update;
                                fbConnection1.Open();
                                datUpdate.UpdateCommand.ExecuteNonQuery();
                                fbConnection1.Close();
                            }
                            catch (Exception a)
                            {
                                fbConnection1.Close();
                                MessageBox.Show(a.Message, "Erro Update Item");
                            }

                            FbCommand selectItens = new FbCommand();
                            selectItens.Connection = fbConnection1;
                            selectItens.CommandText =
                                "SELECT COD_ITENS_NOTA FROM ITENS_NOTA WHERE COD_SISTEMA_NF_ITEM = '" + abre_nf.cod_nf_escolhida + "' ORDER BY COD_ITENS_NOTA";
                            FbDataAdapter datTable = new FbDataAdapter();
                            DataSet dsTable = new DataSet();
                            datTable.SelectCommand = selectItens;
                            fbConnection1.Open();
                            datTable.Fill(dsTable);
                            fbConnection1.Close();
                            foreach (DataRow dr in dsTable.Tables[0].Rows)
                            {
                                try
                                {
                                    string codItens = dr[0].ToString();
                                    FbCommand insertItens = new FbCommand();
                                    insertItens.Connection = fbConnection1;
                                    insertItens.CommandText =
                                        "INSERT INTO ITENS_NOTA(" +
                                        "DESCRICAO_ITEM, UNIDADE_ITEM, QTDE_ITEM, ST_ITEM, PRECO_UNIT_ITEM, PRECO_TOTAL_ITEM, IPI_ITEM, ICM_ITEM, " +
                                        "VALOR_IPI_ITEM, PEDIDO_COMPRA_ITEM, MAE_ITEM, COD_ITEM, NCM_ITEM, CFOP_ITEM, VALOR_ICM_ITEM, " +
                                        "VALOR_ISS_ITEM, PRESTACAO_SERVICO_ITEM, VALOR_BC_ITEM, VALOR_BC_ICMS_ST_ITEM, VALOR_ICMS_ST_ITEM, " +
                                        "VALOR_FRETE_ITEM, VALOR_DESCONTO_ITEM, VALOR_SEGURO_ITEM, VALOR_OUTRAS_DESP_ITEM, IVA_ITEM, REDUCAO_ITEM, " +
                                        "COFINS_ITEM, VALOR_COFINS_ITEM, PIS_ITEM, VALOR_PIS_ITEM, ORIGEM_ITEM, MOD_BC_ITEM, ISS_ITEM, MOD_BC_ST_ITEM, " +
                                        "REDUCAO_ST_ITEM, ICMS_ST_ITEM, ALIQUOTA_CREDITO_ITEM, VALOR_CREDITO_ITEM, IPI_TRIB_ITEM, IPI_N_TRIB_ITEM, " +
                                        "CST_IPI_TRIB_ITEM, CST_IPI_N_TRIB_ITEM, TIPO_PIS_ITEM, CST_PIS_ITEM, TIPO_COFINS_ITEM, CST_COFINS_ITEM, " +
                                        "TIPO_SERVICO_ITEM, ITEM_PEDIDO_COMPRA_ITEM, BC_IPI_ITEM, BC_PIS_ITEM, BC_COFINS_ITEM, BC_ISS_ITEM, BC_COM_IPI_ITEM, " +
                                        "ST_IMPRESSAO_ITEM, DI_ITEM, DATA_DI_ITEM, LOCAL_DES_ITEM, UF_DES_ITEM, DATA_DES_ITEM, COD_EXP_ITEM, " +
                                        "VALOR_BC_II_ITEM, VALOR_DESP_AD_ITEM, VALOR_IMPOSTO_IMP_ITEM, VALOR_IMPOSTO_OP_FINAN_ITEM, COD_OP_ITEM, " +
                                        "CNPJ_CLIENTE_ITEM) " +
                                        "SELECT DESCRICAO_ITEM, UNIDADE_ITEM, QTDE_ITEM, ST_ITEM, PRECO_UNIT_ITEM, PRECO_TOTAL_ITEM, IPI_ITEM, ICM_ITEM, " +
                                        "VALOR_IPI_ITEM, PEDIDO_COMPRA_ITEM, MAE_ITEM, COD_ITEM, NCM_ITEM, CFOP_ITEM, VALOR_ICM_ITEM, " +
                                        "VALOR_ISS_ITEM, PRESTACAO_SERVICO_ITEM, VALOR_BC_ITEM, VALOR_BC_ICMS_ST_ITEM, VALOR_ICMS_ST_ITEM, " +
                                        "VALOR_FRETE_ITEM, VALOR_DESCONTO_ITEM, VALOR_SEGURO_ITEM, VALOR_OUTRAS_DESP_ITEM, IVA_ITEM, REDUCAO_ITEM, " +
                                        "COFINS_ITEM, VALOR_COFINS_ITEM, PIS_ITEM, VALOR_PIS_ITEM, ORIGEM_ITEM, MOD_BC_ITEM, ISS_ITEM, MOD_BC_ST_ITEM, " +
                                        "REDUCAO_ST_ITEM, ICMS_ST_ITEM, ALIQUOTA_CREDITO_ITEM, VALOR_CREDITO_ITEM, IPI_TRIB_ITEM, IPI_N_TRIB_ITEM, " +
                                        "CST_IPI_TRIB_ITEM, CST_IPI_N_TRIB_ITEM, TIPO_PIS_ITEM, CST_PIS_ITEM, TIPO_COFINS_ITEM, CST_COFINS_ITEM, " +
                                        "TIPO_SERVICO_ITEM, ITEM_PEDIDO_COMPRA_ITEM, BC_IPI_ITEM, BC_PIS_ITEM, BC_COFINS_ITEM, BC_ISS_ITEM, BC_COM_IPI_ITEM, " +
                                        "ST_IMPRESSAO_ITEM, DI_ITEM, DATA_DI_ITEM, LOCAL_DES_ITEM, UF_DES_ITEM, DATA_DES_ITEM, COD_EXP_ITEM, " +
                                        "VALOR_BC_II_ITEM, VALOR_DESP_AD_ITEM, VALOR_IMPOSTO_IMP_ITEM, VALOR_IMPOSTO_OP_FINAN_ITEM, COD_OP_ITEM, " +
                                        "CNPJ_CLIENTE_ITEM FROM ITENS_NOTA WHERE COD_ITENS_NOTA = '" + codItens + "'";
                                    FbDataAdapter datItensNota = new FbDataAdapter();
                                    datItensNota.InsertCommand = insertItens;
                                    fbConnection1.Open();
                                    datItensNota.InsertCommand.ExecuteNonQuery();
                                    fbConnection1.Close();

                                    string ultimoItem = buscarUltimoItem();
                                    try
                                    { //FINALIZAR ISSO
                                        string cfop = "1410";
                                        FbCommand update = new FbCommand();
                                        update.Connection = fbConnection1;
                                        update.CommandText =
                                            "UPDATE ITENS_NOTA SET NF_ITEM = '" + notaUltima + "', DATA_INSERCAO_ITEM_NOTA = '" + dataAtual + "', " + 
                                            "CFOP_ITEM = '" + cfop + "' WHERE COD_ITENS_NOTA = '" + ultimoItem + "'";
                                        FbDataAdapter datUpdate = new FbDataAdapter();
                                        datUpdate.UpdateCommand = update;
                                        fbConnection1.Open();
                                        datUpdate.UpdateCommand.ExecuteNonQuery();
                                        fbConnection1.Close();
                                    }
                                    catch (Exception a)
                                    {
                                        fbConnection1.Close();
                                        MessageBox.Show(a.Message, "Erro Update Item");
                                    }

                                }
                                catch (Exception a)
                                {
                                    MessageBox.Show(a.Message, "Erro ao inserir item");
                                    fbConnection1.Close();
                                }
                            }
                        }
                        catch (Exception a)
                        {
                            MessageBox.Show(a.Message, "Erro ao inserir nota");
                            fbConnection1.Close();
                        }
                        carregaNf(notaUltima);
                    }
                }
            }
             */
        /*
        }
        */

        private void replicar_nota_devolucao(bool complemento)
        {
            if (DialogResult.Yes == MessageBox.Show("Uma nova NF será criada",
                "Deseja Continuar?", MessageBoxButtons.YesNo))
            {
                form_localiza_nf_ent abre_nf = new form_localiza_nf_ent();
                try
                {
                    //this.Close();
                    abre_nf.ShowDialog();
                }
                finally
                {
                    if (abre_nf.n_nf.Trim() != "")
                    {
                        string dataAtual = Convert.ToDateTime(DateTime.Now).ToShortDateString().Replace("/", ".");
                        string notaUltima = "";
                        string n_nf_entrada = abre_nf.numero_nota_correto;
                        try
                        {
                            double valor_nota_complemento = 0;
                            if (complemento)
                            {
                                try
                                {
                                    FbCommand selectItens = new FbCommand();
                                    selectItens.Connection = fbConnection1;
                                    selectItens.CommandText =
                                        "SELECT SUM(PRECO_TOTAL_ITEM_ENT) " +
                                        "FROM ITENS_NOTA_ENT WHERE COD_SISTEMA_NF_item_ENT = '" + abre_nf.n_nf + "' AND CFOP_ITEM_ENT = '5102' ";
                                    FbDataAdapter datTable = new FbDataAdapter();
                                    DataSet dsTable = new DataSet();
                                    datTable.SelectCommand = selectItens;
                                    fbConnection1.Open();
                                    datTable.Fill(dsTable);
                                    fbConnection1.Close();
                                    foreach (DataRow dr in dsTable.Tables[0].Rows)
                                    {
                                        try
                                        {
                                            valor_nota_complemento = Convert.ToDouble(dr[0].ToString());
                                        }
                                        catch { }
                                    }
                                }
                                catch (Exception a)
                                {
                                    fbConnection1.Close();
                                }
                            }

                            bool continua = false;
                            if (!complemento)
                                continua = true;
                            else
                            {
                                if (valor_nota_complemento > 0)
                                    continua = true;
                            }

                            if (continua)
                            {
                                int nf = 0;
                                FbCommand insertNf = new FbCommand();
                                insertNf.Connection = fbConnection1;
                                insertNf.CommandText =
                                    "INSERT INTO NOTA_FISCAL(" +
                                    "ALIQUOTA_SIMPLES_NF, BAIRRO_CL_NF, BASE_CALC_ICM_SUBS, BASE_CALC_ICMS_NF, BASE_CALCULO_ISS_NF, " +
                                    "BENEFICIAMENTO_NF, CEP_CL_NF, CFO_2_NF, CFO_NF, CIDADE_CL_NF, CLIENTE_FORN_NF, CNPJ_CL_NF, " +
                                    "CNPJ_CLIENTE_FORN, COBRANCA_NF, " +
                                    "DATA_VENCIMENTO_NF, EMAIL_CL_NF, END_NUMERO_STRING_NF, ENDERECO_ENTREGA_NF, ENTRADA_NF, " +
                                    "ENTRADA_SAIDA_NF, ESPECIE_NF, ESTADO_CL_NF, ESTADO_CLIENTE_NF, ESTADO_VEICULO_NF, EXPORTACAO_NF, " +
                                    "FONE_CL_NF, FRETE_CONTA_NF, IE_CL_NF, INF_COMPL_NF, LOCAL_EMBARQUE_EXPORTACAO, MARCA_NF, " +
                                    "N_NF_REFERENCIADA_NF, NATUREZA_OPERACAO_NF, NFE_TESTE, OBS_NF, OUTRAS_DESP_NF, " +
                                    "PAIS_CL_NF, PESO_BRUTO_NF, PESO_LIQUIDO_NF, PLACA_VEICULO_NF, QTDE_NF, RAZAO_SOCIAL_CL_NF, " +
                                    "REFERENCIADA_NF, SAIDA_NF, TIPO_MVTO_NF, TRANSPORTADORA_NF, TRIBUTADA_NF, " +
                                    "UF_EMBARQUE_EXPORTACAO, VALOR_EXTENSO_NF, VALOR_FRETE_NF, VALOR_ICM_SUBS, VALOR_ICMS_NF, " +
                                    "VALOR_IPI_NF, VALOR_ISS_NF, VALOR_NOTA_NF, VALOR_SEGURO_NF, VALOR_SIMPLES_NF, " +
                                    "VALOR_TOT_PROD_NF, VALOR_TOTAL_SERVICOS_NF, cnpj_emissor_nf, razao_emissor_nf) " +
                                    "SELECT ALIQUOTA_SIMPLES_NF_ENT, BAIRRO_CL_NF_ENT, BASE_CALC_ICM_SUBS_ENT, BASE_CALC_ICMS_NF_ENT, BASE_CALCULO_ISS_NF_ENT, " +
                                    "BENEFICIAMENTO_NF_ENT, CEP_CL_NF_ENT, CFO_2_NF_ENT, CFO_NF_ENT, CIDADE_CL_NF_ENT, CLIENTE_FORN_NF_ENT, CNPJ_CL_NF_ENT, " +
                                    "CNPJ_CLIENTE_FORN_ENT, COBRANCA_NF_ENT, " +
                                    "DATA_VENCIMENTO_NF_ENT, EMAIL_CL_NF_ENT, END_NUMERO_STRING_NF_ENT, ENDERECO_ENTREGA_NF_ENT, ENTRADA_NF_ENT, " +
                                    "ENTRADA_SAIDA_NF_ENT, ESPECIE_NF_ENT, ESTADO_CL_NF_ENT, ESTADO_CLIENTE_NF_ENT, ESTADO_VEICULO_NF_ENT, EXPORTACAO_NF_ENT, " +
                                    "FONE_CL_NF_ENT, FRETE_CONTA_NF_ENT, IE_CL_NF_ENT, INF_COMPL_NF_ENT, LOCAL_EMBARQUE_EXPORTACAO_ENT, MARCA_NF_ENT, " +
                                    "CHAVE_ACESSO_NF_ENT, NATUREZA_OPERACAO_NF_ENT, NFE_TESTE_ENT, OBS_NF_ENT, OUTRAS_DESP_NF_ENT, " +
                                    "PAIS_CL_NF_ENT, PESO_BRUTO_NF_ENT, PESO_LIQUIDO_NF_ENT, PLACA_VEICULO_NF_ENT, QTDE_NF_ENT, RAZAO_SOCIAL_CL_NF_ENT, " +
                                    "REFERENCIADA_NF_ENT, SAIDA_NF_ENT, TIPO_MVTO_NF_ENT, TRANSPORTADORA_NF_ENT, TRIBUTADA_NF_ENT, " +
                                    "UF_EMBARQUE_EXPORTACAO_ENT, VALOR_EXTENSO_NF_ENT, VALOR_FRETE_NF_ENT, VALOR_ICM_SUBS_ENT, VALOR_ICMS_NF_ENT, " +
                                    "VALOR_IPI_NF_ENT, VALOR_ISS_NF_ENT, VALOR_NOTA_NF_ENT, VALOR_SEGURO_NF_ENT, VALOR_SIMPLES_NF_ENT, " +
                                    "VALOR_TOT_PROD_NF_ENT, VALOR_TOTAL_SERVICOS_NF_ENT, '" + cnpj_empresa + "','" + razao_social_empresa + "' FROM NOTA_FISCAL_ENT WHERE COD_SISTEMA_NF_ENT = '" + abre_nf.n_nf + "'";
                                FbDataAdapter datIns = new FbDataAdapter();
                                datIns.InsertCommand = insertNf;
                                fbConnection1.Open();
                                datIns.InsertCommand.ExecuteNonQuery();
                                fbConnection1.Close();
                                string cod_sistema;
                                nf = buscar_ultima_nf(cnpj_empresa, out cod_sistema);
                                nf++;
                                notaUltima = nf.ToString();
                                string cnpj_cliente_entrada = "", cnpj_nf_entrada = "", razao_social_entrada = "", natureza_entrada = "", inf_compl = "REFERENTE A SUA NF No: ", natureza = "DEVOLUCAO";
                                buscar_informacoes_nota_entrada(abre_nf.n_nf.Trim(), out cnpj_nf_entrada, out razao_social_entrada, out cnpj_cliente_entrada, out natureza_entrada);
                                string _cfop = buscar_cfop(natureza_entrada);
                                //if (_cfop == "5902")
                                //    natureza = 
                                if (_cfop == "5949")
                                {
                                    natureza = "OUTRAS ENTRADAS";
                                }
                                string estado_cliente = "";
                                string mudar_cliente = "";
                                if (cnpj_nf_entrada != "" && cnpj_cliente_entrada == cnpj_empresa)
                                {
                                    buscar_estado_cliente(cnpj_nf_entrada, out estado_cliente);
                                    inf_compl = "REFERENTE A NOSSA NF No:";
                                    if (complemento)
                                        inf_compl = " COMPLEMENTO DE ICMS " + inf_compl;
                                    mudar_cliente = ", CLIENTE_FORN_NF = '" + razao_social_entrada + "', CNPJ_CLIENTE_FORN = '" + cnpj_nf_entrada +
                                        "', ESTADO_CLIENTE_NF = '" + estado_cliente + "'";

                                    //   radioEntrada.Checked = true;

                                }
                                // falta colocar o nome que aparece embaixo da nota, acertar cfops e colocar que é entrada
                                //CLIENTE_FORN_NF, CNPJ_CL_NF, " +
                                //   "CNPJ_CLIENTE_FORN
                                try
                                {
                                    string entrada_saida = "1";
                                    string entrada = "0";
                                    string saida = "1";
                                    if (cnpj_nf_entrada != "" && cnpj_cliente_entrada == cnpj_empresa)
                                    {
                                        entrada_saida = "0";
                                        entrada = "1";
                                        saida = "0";
                                    }

                                    FbCommand update = new FbCommand();
                                    update.Connection = fbConnection1;
                                    update.CommandText =
                                        "UPDATE NOTA_FISCAL SET N_NF = '" + notaUltima + "', DATA_EMISSAO_NF = '" + dataAtual + "', NATUREZA_OPERACAO_NF = '" + natureza + "',  " +
                                        "SAIDA_NF = '" + saida + "', entrada_NF = '" + entrada + "', ENTRADA_SAIDA_NF = '" + entrada_saida + 
                                        "',  FORMA_PGTO_NF = '2 - Outros', FRETE_CONTA_NF = '0', INF_COMPL_NF = '" + inf_compl + n_nf_entrada + "'" + mudar_cliente +
                                        "  WHERE COD_SISTEMA_NF = '" + ultimaSistema() + "'";

                                    FbDataAdapter datUpdate = new FbDataAdapter();
                                    datUpdate.UpdateCommand = update;
                                    fbConnection1.Open();
                                    datUpdate.UpdateCommand.ExecuteNonQuery();
                                    fbConnection1.Close();
                                   
                                }
                                catch (Exception a)
                                {
                                    fbConnection1.Close();
                                    MessageBox.Show(a.Message, "Erro Update Item");
                                }

                                string cst_ipi_n_tributado = "null";
                                if (complemento)
                                {
                                    FbCommand selectItens = new FbCommand();
                                    selectItens.Connection = fbConnection1;
                                    selectItens.CommandText =
                                        "SELECT FIRST(1) COD_ITENS_NOTA_ENT, CFOP_ITEM_ENT, CST_IPI_TRIB_ITEM_ENT, CST_IPI_N_TRIB_ITEM_ENT, CFOP_ITEM_ENT " +
                                        "FROM ITENS_NOTA_ENT WHERE COD_SISTEMA_NF_item_ENT = '" + abre_nf.n_nf + "' and CFOP_ITEM_ENT = '5102' ORDER BY COD_ITENS_NOTA_ENT";
                                    FbDataAdapter datTable = new FbDataAdapter();
                                    DataSet dsTable = new DataSet();
                                    datTable.SelectCommand = selectItens;
                                    fbConnection1.Open();
                                    datTable.Fill(dsTable);
                                    fbConnection1.Close();
                                    foreach (DataRow dr in dsTable.Tables[0].Rows)
                                    {

                                        try
                                        {
                                            string codItens = dr[0].ToString();
                                            FbCommand insertItens = new FbCommand();
                                            insertItens.Connection = fbConnection1;
                                            insertItens.CommandText =
                                                "INSERT INTO ITENS_NOTA (" +
                                                "DESCRICAO_ITEM, UNIDADE_ITEM, QTDE_ITEM, ST_ITEM, PRECO_UNIT_ITEM, PRECO_TOTAL_ITEM, IPI_ITEM, ICM_ITEM, " +
                                                "VALOR_IPI_ITEM, PEDIDO_COMPRA_ITEM, MAE_ITEM, COD_ITEM, NCM_ITEM, CFOP_ITEM, VALOR_ICM_ITEM, " +
                                                "VALOR_ISS_ITEM, PRESTACAO_SERVICO_ITEM, VALOR_BC_ITEM, VALOR_BC_ICMS_ST_ITEM, VALOR_ICMS_ST_ITEM, " +
                                                "VALOR_FRETE_ITEM, VALOR_DESCONTO_ITEM, VALOR_SEGURO_ITEM, VALOR_OUTRAS_DESP_ITEM, IVA_ITEM, REDUCAO_ITEM, " +
                                                "COFINS_ITEM, VALOR_COFINS_ITEM, PIS_ITEM, VALOR_PIS_ITEM, ORIGEM_ITEM, MOD_BC_ITEM, ISS_ITEM, MOD_BC_ST_ITEM, " +
                                                "REDUCAO_ST_ITEM, ICMS_ST_ITEM, ALIQUOTA_CREDITO_ITEM, VALOR_CREDITO_ITEM, IPI_TRIB_ITEM, IPI_N_TRIB_ITEM, " +
                                                "CST_IPI_TRIB_ITEM, CST_IPI_N_TRIB_ITEM, TIPO_PIS_ITEM, CST_PIS_ITEM, TIPO_COFINS_ITEM, CST_COFINS_ITEM, " +
                                                "TIPO_SERVICO_ITEM, BC_IPI_ITEM, BC_PIS_ITEM, BC_COFINS_ITEM, BC_ISS_ITEM, BC_COM_IPI_ITEM, " +
                                                "ST_IMPRESSAO_ITEM, COD_EAN_ITEM) " +
                                                "SELECT DESCRICAO_ITEM_ENT, UNIDADE_ITEM_ENT, QTDE_ITEM_ENT, ST_ITEM_ENT, PRECO_UNIT_ITEM_ENT, PRECO_TOTAL_ITEM_ENT, IPI_ITEM_ENT, ICM_ITEM_ENT, " +
                                                "VALOR_IPI_ITEM_ENT, PEDIDO_COMPRA_ITEM_ENT, MAE_ITEM_ENT, COD_ITEM_ENT, NCM_ITEM_ENT, CFOP_ITEM_ENT, VALOR_ICM_ITEM_ENT, " +
                                                "VALOR_ISS_ITEM_ENT, PRESTACAO_SERVICO_ITEM_ENT, VALOR_BC_ITEM_ENT, VALOR_BC_ICMS_ST_ITEM_ENT, VALOR_ICMS_ST_ITEM_ENT, " +
                                                "VALOR_FRETE_ITEM_ENT, VALOR_DESCONTO_ITEM_ENT, VALOR_SEGURO_ITEM_ENT, VALOR_OUTRAS_DESP_ITEM_ENT, IVA_ITEM_ENT, REDUCAO_ITEM_ENT, " +
                                                "COFINS_ITEM_ENT, VALOR_COFINS_ITEM_ENT, PIS_ITEM_ENT, VALOR_PIS_ITEM_ENT, ORIGEM_ITEM_ENT, MOD_BC_ITEM_ENT, ISS_ITEM_ENT, MOD_BC_ST_ITEM_ENT, " +
                                                "REDUCAO_ST_ITEM_ENT, ICMS_ST_ITEM_ENT, ALIQUOTA_CREDITO_ITEM_ENT, VALOR_CREDITO_ITEM_ENT, IPI_TRIB_ITEM_ENT, IPI_N_TRIB_ITEM_ENT, " +
                                                "CST_IPI_TRIB_ITEM_ENT, CST_IPI_N_TRIB_ITEM_ENT, TIPO_PIS_ITEM_ENT, CST_PIS_ITEM_ENT, TIPO_COFINS_ITEM_ENT, CST_COFINS_ITEM_ENT, " +
                                                "TIPO_SERVICO_ITEM_ENT, BC_IPI_ITEM_ENT, BC_PIS_ITEM_ENT, BC_COFINS_ITEM_ENT, BC_ISS_ITEM_ENT, BC_COM_IPI_ITEM_ENT, " +
                                                "ST_IMPRESSAO_ITEM_ENT, COD_EAN_ITEM_ENT FROM ITENS_NOTA_ENT WHERE COD_ITENS_NOTA_ENT = '" + codItens + "' RETURNING COD_ITENS_NOTA";
                                            FbDataAdapter datItensNota = new FbDataAdapter();
                                            datItensNota.InsertCommand = insertItens;
                                            fbConnection1.Open();
                                            object ultimoItem = datItensNota.InsertCommand.ExecuteScalar();
                                            fbConnection1.Close();

                                            // string ultimoItem = buscarUltimoItem();
                                            string _cod_barras_saida = "";
                                            string _cst = buscar_cst_item(ultimoItem, out _cod_barras_saida);
                                            try
                                            { //FINALIZAR ISSO

                                                string cfop = "5102";

                                                string ipi_trib = "null", ipi_n_trib = "null";
                                                if (dr[2].ToString() != "")
                                                    ipi_trib = "1";
                                                if (dr[3].ToString() != "")
                                                    ipi_n_trib = "1";

                                                if (dr[3].ToString() == "55")
                                                    cst_ipi_n_tributado = "53";
                                                else
                                                    cst_ipi_n_tributado = dr[3].ToString();

                                                string cst = " ST_ITEM = '900', ";
                                                if (crt_empresa != "1")
                                                {
                                                    cst = "";
                                                }

                                              

                                                double valor_icms_item = valor_nota_complemento * 18 / 100;
                                                FbCommand update = new FbCommand();
                                                update.Connection = fbConnection1;
                                                update.CommandText = "UPDATE ITENS_NOTA SET COD_ITEM = '1', DESCRICAO_ITEM = 'COMPLEMENTO DE ICMS', ST_ITEM = '00', PRECO_UNIT_ITEM = 0, PRECO_TOTAL_ITEM = 0, QTDE_ITEM = 1, " +
                                                    "ICM_ITEM = 18, VALOR_BC_ITEM = '" + valor_nota_complemento.ToString().Replace(".", "").Replace(",", ".") + "', " +
                                                    "VALOR_ICM_ITEM = '" + valor_icms_item.ToString().Replace(".", "").Replace(",", ".") + "', " +
                                                    "NF_ITEM = '" + notaUltima + "', " + cst + " MOD_BC_ST_ITEM = '4', MOD_BC_ITEM = 3, " +
                                                    "CFOP_ITEM = '" + cfop + "', IPI_TRIB_ITEM = " + ipi_trib + ", IPI_N_TRIB_ITEM = " + ipi_n_trib + ", CST_IPI_N_TRIB_ITEM = " + cst_ipi_n_tributado + ", " +
                                                    "CST_PIS_ITEM = '06', CST_COFINS_ITEM = '06', TIPO_PIS_ITEM = '3 - Não Tributado', TIPO_COFINS_ITEM = '3 - Não Tributado' " +
                                                    "WHERE COD_ITENS_NOTA = '" + ultimoItem + "'";
                                                FbDataAdapter datUpdate = new FbDataAdapter();
                                                datUpdate.UpdateCommand = update;
                                                fbConnection1.Open();
                                                datUpdate.UpdateCommand.ExecuteNonQuery();
                                                fbConnection1.Close();
                                            }
                                            catch (Exception a)
                                            {
                                                fbConnection1.Close();
                                                MessageBox.Show(a.Message, "Erro Update Item");
                                            }

                                        }
                                        catch (Exception a)
                                        {
                                            MessageBox.Show(a.Message, "Erro ao inserir item");
                                            fbConnection1.Close();
                                        }

                                    }


                                }
                                else
                                {

                                    FbCommand selectItens = new FbCommand();
                                    selectItens.Connection = fbConnection1;
                                    selectItens.CommandText =
                                        "SELECT COD_ITENS_NOTA_ENT, CFOP_ITEM_ENT, CST_IPI_TRIB_ITEM_ENT, CST_IPI_N_TRIB_ITEM_ENT, CFOP_ITEM_ENT " +
                                        "FROM ITENS_NOTA_ENT WHERE COD_SISTEMA_NF_item_ENT = '" + abre_nf.n_nf + "' ORDER BY COD_ITENS_NOTA_ENT";
                                    FbDataAdapter datTable = new FbDataAdapter();
                                    DataSet dsTable = new DataSet();
                                    datTable.SelectCommand = selectItens;
                                    fbConnection1.Open();
                                    datTable.Fill(dsTable);
                                    fbConnection1.Close();
                                    string cfop = "5202";
                                    foreach (DataRow dr in dsTable.Tables[0].Rows)
                                    {

                                        try
                                        {

                                            string codItens = dr[0].ToString();
                                            FbCommand insertItens = new FbCommand();
                                            insertItens.Connection = fbConnection1;
                                            insertItens.CommandText =
                                                "INSERT INTO ITENS_NOTA(" +
                                                "DESCRICAO_ITEM, UNIDADE_ITEM, QTDE_ITEM, ST_ITEM, PRECO_UNIT_ITEM, PRECO_TOTAL_ITEM, IPI_ITEM, ICM_ITEM, " +
                                                "VALOR_IPI_ITEM, PEDIDO_COMPRA_ITEM, MAE_ITEM, COD_ITEM, NCM_ITEM, CFOP_ITEM, VALOR_ICM_ITEM, " +
                                                "VALOR_ISS_ITEM, PRESTACAO_SERVICO_ITEM, VALOR_BC_ITEM, VALOR_BC_ICMS_ST_ITEM, VALOR_ICMS_ST_ITEM, " +
                                                "VALOR_FRETE_ITEM, VALOR_DESCONTO_ITEM, VALOR_SEGURO_ITEM, VALOR_OUTRAS_DESP_ITEM, IVA_ITEM, REDUCAO_ITEM, " +
                                                "COFINS_ITEM, VALOR_COFINS_ITEM, PIS_ITEM, VALOR_PIS_ITEM, ORIGEM_ITEM, MOD_BC_ITEM, ISS_ITEM, MOD_BC_ST_ITEM, " +
                                                "REDUCAO_ST_ITEM, ICMS_ST_ITEM, ALIQUOTA_CREDITO_ITEM, VALOR_CREDITO_ITEM, IPI_TRIB_ITEM, IPI_N_TRIB_ITEM, " +
                                                "CST_IPI_TRIB_ITEM, CST_IPI_N_TRIB_ITEM, TIPO_PIS_ITEM, CST_PIS_ITEM, TIPO_COFINS_ITEM, CST_COFINS_ITEM, " +
                                                "TIPO_SERVICO_ITEM, BC_IPI_ITEM, BC_PIS_ITEM, BC_COFINS_ITEM, BC_ISS_ITEM, BC_COM_IPI_ITEM, " +
                                                "ST_IMPRESSAO_ITEM, COD_EAN_ITEM) " +
                                                "SELECT DESCRICAO_ITEM_ENT, UNIDADE_ITEM_ENT, QTDE_ITEM_ENT, ST_ITEM_ENT, PRECO_UNIT_ITEM_ENT, PRECO_TOTAL_ITEM_ENT, IPI_ITEM_ENT, ICM_ITEM_ENT, " +
                                                "VALOR_IPI_ITEM_ENT, PEDIDO_COMPRA_ITEM_ENT, MAE_ITEM_ENT, COD_ITEM_ENT, NCM_ITEM_ENT, CFOP_ITEM_ENT, VALOR_ICM_ITEM_ENT, " +
                                                "VALOR_ISS_ITEM_ENT, PRESTACAO_SERVICO_ITEM_ENT, VALOR_BC_ITEM_ENT, VALOR_BC_ICMS_ST_ITEM_ENT, VALOR_ICMS_ST_ITEM_ENT, " +
                                                "VALOR_FRETE_ITEM_ENT, VALOR_DESCONTO_ITEM_ENT, VALOR_SEGURO_ITEM_ENT, VALOR_OUTRAS_DESP_ITEM_ENT, IVA_ITEM_ENT, REDUCAO_ITEM_ENT, " +
                                                "COFINS_ITEM_ENT, VALOR_COFINS_ITEM_ENT, PIS_ITEM_ENT, VALOR_PIS_ITEM_ENT, ORIGEM_ITEM_ENT, MOD_BC_ITEM_ENT, ISS_ITEM_ENT, MOD_BC_ST_ITEM_ENT, " +
                                                "REDUCAO_ST_ITEM_ENT, ICMS_ST_ITEM_ENT, ALIQUOTA_CREDITO_ITEM_ENT, VALOR_CREDITO_ITEM_ENT, IPI_TRIB_ITEM_ENT, IPI_N_TRIB_ITEM_ENT, " +
                                                "CST_IPI_TRIB_ITEM_ENT, CST_IPI_N_TRIB_ITEM_ENT, TIPO_PIS_ITEM_ENT, CST_PIS_ITEM_ENT, TIPO_COFINS_ITEM_ENT, CST_COFINS_ITEM_ENT, " +
                                                "TIPO_SERVICO_ITEM_ENT, BC_IPI_ITEM_ENT, BC_PIS_ITEM_ENT, BC_COFINS_ITEM_ENT, BC_ISS_ITEM_ENT, BC_COM_IPI_ITEM_ENT, " +
                                                "ST_IMPRESSAO_ITEM_ENT, COD_EAN_ITEM_ENT FROM ITENS_NOTA_ENT WHERE COD_ITENS_NOTA_ENT = '" + codItens + "' RETURNING COD_ITENS_NOTA";
                                            FbDataAdapter datItensNota = new FbDataAdapter();
                                            datItensNota.InsertCommand = insertItens;
                                            fbConnection1.Open();
                                            object ultimoItem = datItensNota.InsertCommand.ExecuteScalar();
                                            fbConnection1.Close();

                                            // string ultimoItem = buscarUltimoItem();
                                            string _cod_barras;
                                            string _cst = buscar_cst_item(ultimoItem, out _cod_barras);
                                            try
                                            { //FINALIZAR ISSO
                                                string cfop_entrada = dr[1].ToString();
                                                //string cfop = "5202";
                                                if (cfop_entrada == "5917")
                                                    cfop = "5918";

                                                if (cfop_entrada == "5901")
                                                {
                                                    cfop = "5902";
                                                    natureza = "RETORNO";
                                                }

                                                

                                                string ipi_trib = "null", ipi_n_trib = "null";
                                                if (dr[2].ToString() != "")
                                                    ipi_trib = "1";
                                                if (dr[3].ToString() != "")
                                                    ipi_n_trib = "1";

                                                if (dr[3].ToString() == "55")
                                                    cst_ipi_n_tributado = "53";
                                                else
                                                    cst_ipi_n_tributado = dr[3].ToString();

                                                string cst = " ST_ITEM = '900', ";
                                                if (crt_empresa != "1")
                                                {
                                                    cst = _cst;
                                                }

                                                if (cnpj_nf_entrada != "" && cnpj_cliente_entrada == cnpj_empresa)
                                                {
                                                    cfop = "1949";
                                                    if (_cst == "101")
                                                    {

                                                        cfop = "1201";
                                                        if (tb_estado_cliente.Text != estado_empresa)
                                                            cfop = "2201";
                                                        cst = " ST_ITEM = '101', ";
                                                    }
                                                    if (_cst == "102")
                                                    {

                                                        cfop = "1201";
                                                        if (tb_estado_cliente.Text != estado_empresa)
                                                            cfop = "2201";
                                                        cst = " ST_ITEM = '102', ";
                                                    }

                                                    if (_cst == "201")
                                                    {
                                                        cfop = "1410";
                                                        if (tb_estado_cliente.Text != estado_empresa)
                                                            cfop = "2410";
                                                        cst = " ST_ITEM = '201', ";
                                                    }
                                                    if (_cst == "202")
                                                    {
                                                        cfop = "1410";
                                                        if (tb_estado_cliente.Text != estado_empresa)
                                                            cfop = "2410";
                                                        cst = " ST_ITEM = '202', ";
                                                    }
                                                    if (tb_ent_sai_nfe.Text == "0")
                                                        cfop = "1949";
                                                    if (tb_estado_cliente.Text != estado_empresa)
                                                        cfop = "2949";
                                                   // radioEntrada.Checked = true;
                                                  //  tb_ent_sai_nfe.Text = "0";
                                                    /*
                                                    try
                                                    {
                                                        FbCommand update = new FbCommand();
                                                        update.Connection = fbConnection1;
                                                        update.CommandText =
                                                            "UPDATE NOTA_FISCAL SET ENTRADA_SAIDA_NF = '0' " + 
                                                            "  WHERE COD_SISTEMA_NF = '" + ultimaSistema() + "'";
                                                        FbDataAdapter datUpdate = new FbDataAdapter();
                                                        datUpdate.UpdateCommand = update;
                                                        fbConnection1.Open();
                                                        datUpdate.UpdateCommand.ExecuteNonQuery();
                                                        fbConnection1.Close();
                                                    }
                                                    catch (Exception ex)
                                                    {
                                                         fbConnection1.Close();
                                                         MessageBox.Show(ex.Message);
                                                    
                                                    }
                                                    */
                                                    //Atualizar(false);
                                                }
                                                if (ipi_n_trib == "")
                                                    ipi_n_trib = "null";
                                                if (ipi_trib == "")
                                                    ipi_trib = "null";

                                                if (cst_ipi_n_tributado == "")
                                                    cst_ipi_n_tributado = "null";
                                              //  if (cst_ipi_tributado == "")
                                               //     cst_ipi_tributado = "null";


                                                FbCommand update = new FbCommand();
                                                update.Connection = fbConnection1;
                                                update.CommandText = "UPDATE ITENS_NOTA SET COD_SISTEMA_NF_ITEM = '" + ultimaSistema() + "',  NF_ITEM = '" + notaUltima + "', MOD_BC_ST_ITEM = '4', MOD_BC_ITEM = 3, " +
                                                    "CFOP_ITEM = '" + cfop + "', IPI_TRIB_ITEM = " + ipi_trib + ", IPI_N_TRIB_ITEM = " + ipi_n_trib + ", CST_IPI_N_TRIB_ITEM = " + cst_ipi_n_tributado + ", " +
                                                    "CST_PIS_ITEM = '06', CST_COFINS_ITEM = '06', TIPO_PIS_ITEM = '3 - Não Tributado', TIPO_COFINS_ITEM = '3 - Não Tributado', COD_EAN_ITEM = '" + _cod_barras + "' " +
                                                    "WHERE COD_ITENS_NOTA = '" + ultimoItem + "'";
                                                FbDataAdapter datUpdate = new FbDataAdapter();
                                                datUpdate.UpdateCommand = update;
                                                fbConnection1.Open();
                                                datUpdate.UpdateCommand.ExecuteNonQuery();
                                                fbConnection1.Close();

                                            
                                            }
                                            catch (Exception a)
                                            {
                                                fbConnection1.Close();
                                                MessageBox.Show(a.Message, "Erro Update Item");
                                            }

                                        }
                                        catch (Exception a)
                                        {
                                            MessageBox.Show(a.Message, "Erro ao inserir item");
                                            fbConnection1.Close();
                                        }

                                    }
                                    if (natureza != "DEVOLUCAO" && natureza != "OUTRAS ENTRADAS")
                                    {
                                        natureza = buscar_natureza(cfop);
                                        try
                                        {
                                            FbCommand updateNatureza = new FbCommand();
                                            updateNatureza.Connection = fbConnection1;
                                            updateNatureza.CommandText =
                                                "UPDATE NOTA_FISCAL SET NATUREZA_OPERACAO_NF = '" + natureza + "'" +
                                                " WHERE COD_SISTEMA_NF = '" + ultimaSistema() + "'";

                                            FbDataAdapter datUpdateNatureza = new FbDataAdapter();
                                            datUpdateNatureza.UpdateCommand = updateNatureza;
                                            fbConnection1.Open();
                                            datUpdateNatureza.UpdateCommand.ExecuteNonQuery();
                                            fbConnection1.Close();
                                        }
                                        catch (Exception a)
                                        {
                                            fbConnection1.Close();
                                            MessageBox.Show(a.Message, "Erro Update Item");
                                        }
                                    }
                                }
                            }
                        }
                        catch (Exception a)
                        {
                            MessageBox.Show(a.Message, "Erro ao inserir nota");
                            fbConnection1.Close();
                        }
                        if (notaUltima != "")
                        {
                            carregaNf(notaUltima);
                            calcular();
                        }

                    }
                }
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Essa operação irá cancelar o boleto da NF. Tem certeza?",
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
                            apagar_itens_cr();
                            selecionar_faturas();

                        }
                    }
                }
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.Description = "Selecione uma pasta para realizar o Backup";
            folderBrowserDialog1.RootFolder = Environment.SpecialFolder.MyComputer;
            folderBrowserDialog1.ShowNewFolderButton = true;

            //Exibe a caixa de diálogo
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                //Exibe a pasta selecionada
                string pasta = folderBrowserDialog1.SelectedPath;
                classe_geracao_xml xml = new classe_geracao_xml();
                xml.caminho_pasta = pasta;



                if (tb_status_nfe.Text.Contains("Autorizad"))
                {
                    xml.gerar_autorizada_unica(tb_chave_acesso_nfe.Text);
                }
                if (tb_status_nfe.Text.Contains("Cancelad"))
                {
                    xml.gerar_canceladas_unica(tb_chave_acesso_nfe.Text);
                }
                Process.Start("Explorer", pasta);
            }
           
        }

        private void button19_Click(object sender, EventArgs e)
        {
            inserir_duplicatas_cr();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(dgvPedidos.Rows[0].Cells["col_pedido"].Value.ToString()) > 1000000)
                { //vem do romaneio
                    acertar_status_romaneio();
                }
                else
                {
                    inserir_status_pedido();
                }
            }
            catch { }
            //acertarEstoque();


            classe_particularidades part = new classe_particularidades();
            part.executar_particularidades(tb_n_nf.Text);
            part.baixar_do_estoque();

            //calcular_estoque_mp();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            try
            {
                importar_xml = true;
                 OpenFileDialog openFileDialog2 = new OpenFileDialog();
             openFileDialog2.Multiselect = true;
             if (openFileDialog2.ShowDialog() == DialogResult.OK)
             {

                 DateTime inicio = DateTime.Now;
                 if (openFileDialog2.FileNames.Length > 0)
                 {


                     List<string> nf_importadas = new List<string>();



                     string caminho;

                     caminho = openFileDialog2.FileNames[0];

                     OleDbConnection theConnection = new OleDbConnection(@"provider=Microsoft.ACE.OLEDB.12.0;data source='" + caminho + "';Extended Properties=\"Excel 12.0;HDR=NO;IMEX=1;\"");
                     theConnection.Open();
                     OleDbDataAdapter theDataAdapter = new OleDbDataAdapter("SELECT * FROM [Planilha1$]", theConnection);
                     DataSet theDS = new DataSet();
                     theDataAdapter.Fill(theDS);
                     theConnection.Close(); FbCommand insert = new FbCommand();
                     foreach (DataRow dr in theDS.Tables[0].Rows)
                     {
                         string cod_item = "", descricao_item = "", qtde_item = "", ncm_item = "", valor_item = "", cfop_item = "", unidade_item = "", valor_unitario = "";
                         buscar_dados_estoque_item(dr[0].ToString(), out descricao_item, out ncm_item, out unidade_item);
                         if (descricao_item == "")
                             descricao_item = dr[0].ToString();
                         if (ncm_item == "")
                             ncm_item = "99999999";
                         if (unidade_item == "")
                             unidade_item = "KG";
                         if (tb_estado_cliente.Text == estado_empresa)
                             cfop_item = "5902";
                         if (tb_estado_cliente.Text != estado_empresa)
                             cfop_item = "6902";

                         descricao_item = descricao_item + "NF:" + dr[1].ToString();
                         qtde_item = dr[2].ToString();
                         valor_item = dr[3].ToString();

                         inserir_itens_retorno(dr[0].ToString(), descricao_item, qtde_item, ncm_item, valor_item, cfop_item, "0", unidade_item);


                     }
                 }
             }

            }
            catch (Exception ex)
            {
                fbConnection1.Close();
                MessageBox.Show(ex.Message);
            }
            importar_xml = false;
        }

        private void buscar_descricao(string p, string descricao, string unidade, string ncm)
        {
            throw new NotImplementedException();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            buscar_romaneio("0");
        }


        private bool verificar_se_pedido_ja_esta_em_uma_nota(string cod_ped)
        {
           

                
                try
                {
                    FbCommand select = new FbCommand();
                    select.CommandText =
                        "SELECT nf.STATUS_NFE, nf.N_NF FROM NOTA_FISCAL nf " +
                        " INNER JOIN PEDIDOS_NF pnf ON nf.N_NF = pnf.NF_PEDIDO_NF " +
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
                            MessageBox.Show("O Pedido " + cod_ped + " já foi inserido na Nota Fiscal número " + dr[1].ToString());
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
        private void buscar_romaneio(string cod_liberacao)
        {
            string forma_pgto = "";
            if (cod_liberacao == "0")
            {
                form_localiza_liberacao lib = new form_localiza_liberacao(cnpj_empresa);
                try
                {
                    lib.liberado_faturamento = true;
                    lib.ShowDialog();
                }
                finally
                {

                    cod_liberacao = lib.cod_selecionado;

                }
            }
            if (verificar_se_pedido_ja_esta_em_uma_nota(cod_liberacao))
            {
                MessageBox.Show("Essa liberação já foi usada");
            }
            else
            {
                string tipo_cliente = buscar_tipo_cliente_romaneio(cod_liberacao);

                if (tipo_cliente == "")
                {
                    MessageBox.Show("Por favor, selecione o tipo de cliente antes de faturar");
                }
                else
                {
                    try
                    {
                        this.datPedidos_nf.InsertCommand.CommandText =
                        "INSERT INTO PEDIDOS_NF (NF_PEDIDO_NF, N_PEDIDO_NF, COD_SISTEMA_PEDIDO_NF)" +
                        "VALUES ('" + tb_n_nf.Text + "', " + cod_liberacao + ", " + tb_cod_interno.Text + ")";
                        this.fbConnection1.Open();
                        this.datPedidos_nf.InsertCommand.Connection = fbConnection1;
                        this.datPedidos_nf.InsertCommand.ExecuteNonQuery();
                        this.fbConnection1.Close();
                        dsPedidos_nf.Clear();
                        this.datPedidos_nf.SelectCommand.CommandText =
                       "SELECT * FROM PEDIDOS_NF WHERE COD_SISTEMA_PEDIDO_NF = '" + tb_cod_interno.Text + "'";
                        this.fbConnection1.Open();
                        this.datPedidos_nf.SelectCommand.Connection = fbConnection1;
                        this.datPedidos_nf.SelectCommand.ExecuteNonQuery();
                        datPedidos_nf.Fill(PEDIDOS_NF);
                        this.fbConnection1.Close();
                    }
                    catch
                    {
                        MessageBox.Show("erro na inserção do pedido-nf.");
                        fbConnection1.Close();
                    }

                    //inserindo o cliente
                    string _indust = "";
                    string _tipo = "";
                    try
                    {
                        FbCommand comando = new FbCommand();
                        comando.Connection = fbConnection1;
                        comando.CommandText =
                            "SELECT * FROM LIBERACAO WHERE COD_LIB = '" + cod_liberacao + "'";
                        DataSet pedido = new DataSet();
                        fbConnection1.Open();
                        FbDataAdapter datSelect = new FbDataAdapter();
                        datSelect.SelectCommand = comando;

                        datSelect.Fill(pedido);
                        string _cnpj = "";
                        string _cliente = "";
                        string _estado = "";
                        string _observacoes = "";
                        string _troca = "";
                        string _bonificacao = "";
                        string _degustacao = "";
                        string _devolucao = "";

                        string _vendas = "";
                        double _desconto = 0;
                        double _valor_total = 0;


                        foreach (DataRow dr in pedido.Tables[0].Rows)
                        {
                            _cnpj = dr["CNPJ_CLIENTE_LIB"].ToString();
                            _cliente = dr["RAZAO_CLIENTE_LIB"].ToString();
                            _tipo = dr["TIPO_LIB"].ToString();

                        }
                        fbConnection1.Close();
                        tb_cnpj_cliente.Text = _cnpj;
                        tb_cliente.Text = _cliente;
                        //tb_dados_adicionais.Text = _observacoes;
                        //if (_bonificacao == "1")
                        //    rb_5910.Checked = true;
                        //if (_degustacao == "1")
                        //    rb_5910.Checked = true;
                        //if (_troca == "1")
                        //    rb_5949.Checked = true;
                        //if (_devolucao == "1")
                        //    rb_1410.Checked = true;
                        if (_tipo == "Industrialização")
                            rb5124.Checked = true;
                        if (_tipo == "Vendas" || _tipo == "Bombas")
                            rb5101.Checked = true;

                        bool pessoa_fisica;
                        string ie_cliente_2, cnpj_cliente_2, logradouro_cliente_2, n_logradouro_cliente_2, complemento_cliente_2, bairro_cliente_2, cod_municipio_cliente_2,
                 uf_cliente_2, cep_cliente_2, cod_pais_cliente_2, pais_cliente_2, telefone_cliente_2, cidade_cliente_2, email_cliente_2;
                        buscar_dados_cliente(tb_cnpj_cliente.Text, out ie_cliente_2, out cnpj_cliente_2, out logradouro_cliente_2,
                    out n_logradouro_cliente_2, out complemento_cliente_2, out bairro_cliente_2,
                    out cod_municipio_cliente_2, out uf_cliente_2, out cep_cliente_2, out cod_pais_cliente_2,
                    out pais_cliente_2, out telefone_cliente_2, out cidade_cliente_2, out pessoa_fisica, out email_cliente_2);
                        _estado = uf_cliente_2;
                        tb_estado_cliente.Text = _estado;
                    }
                    catch
                    {
                        MessageBox.Show("Erro na inserção do cliente");
                        fbConnection1.Close();
                    }


                    //inserindo os itens
                    try
                    {
                        FbCommand comando = new FbCommand();
                        comando.Connection = fbConnection1;
                        comando.CommandText =
                            @"SELECT ipv.*, il.*, pv.COND_PGTO_PED_VENDA FROM ITENS_PEDIDO_VENDA ipv  
                    inner join PEDIDOS_VENDA pv on ipv.COD_PEDIDO_ITEM_VENDA = pv.COD_PED_VENDA 
                    inner join ITENS_LIBERACAO il on ipv.ITEM_LIBERACAO_ITEM_VENDA = il.COD_ITEM_LIB 
                    WHERE il.COD_LIB_ITEM_LIB = '" + cod_liberacao + "'";
                        DataSet itens = new DataSet();
                        fbConnection1.Open();
                        FbDataAdapter datSelect = new FbDataAdapter();
                        datSelect.SelectCommand = comando;
                        datSelect.Fill(itens);
                        // datItens_pedido_venda.SelectCommand = comando;

                        // datItens_pedido_venda.Fill(itens);
                        fbConnection1.Close();
                        string[] _cod = new string[200];
                        string[] _descricao = new string[200];
                        string[] _unidade = new string[200];
                        string[] _qtde = new string[200];
                        string[] _valor_unit = new string[200];
                        string[] _qtde_fat = new string[200];
                        string[] _pedido = new string[200];
                        string[] _item_pedido = new string[200];
                        string[] _cod_item_liberacao = new string[200];
                        int k = 0;
                        foreach (DataRow dr in itens.Tables[0].Rows)
                        {
                            string codigo = "";
                            codigo = dr["COD_PROD_ITEM_VENDA"].ToString();
                            if (codigo == "")
                            {
                                codigo = buscarCodFornecedor(dr["COD_SISTEMA_PROD_ITEM_VENDA"].ToString());
                            }

                            _cod[k] = codigo;
                            _descricao[k] = dr["DESCRICAO_PROD_ITEM_VENDA"].ToString() + " " + dr["DESCRICAO_ITEM_PROD_ITEM_VENDA"].ToString();
                            _unidade[k] = dr["UNIDADE_PROD_ITEM_VENDA"].ToString();
                            _qtde[k] = dr["QTDE_ITEM_LIB"].ToString();
                            _valor_unit[k] = dr["VALOR_UNIT_PROD_ITEM_VENDA"].ToString();
                            _qtde_fat[k] = "";// dr["QTDE_FAT_ITEM_VENDA"].ToString();
                            _pedido[k] = dr["PEDIDO_CLIENTE_ITEM_VENDA"].ToString();
                            _item_pedido[k] = dr["ITEM_PED_CLIENTE_ITEM_VENDA"].ToString();
                            _cod_item_liberacao[k] = dr["COD_ITEM_LIB"].ToString();
                            forma_pgto = dr["COND_PGTO_PED_VENDA"].ToString();
                            k++;
                        }


                        double _porc_desconto = 0;

                        for (int j = 0; j < k; j++)
                        {
                            tb_cl.Text = _cod_item_liberacao[j];
                            tb_cod_peca.Text = _cod[j];
                            tb_descricao_peca.Text = _descricao[j];
                            tb_unid_peca.Text = _unidade[j];
                            tb_qtde_peca.Text = _qtde[j];
                            tb_preco_unit_peca.Text = _valor_unit[j];
                            tb_pedido_compra.Text = _pedido[j];
                            tb_n_item_pedido_compra.Text = _item_pedido[j];
                            if (_qtde_fat[j] != "")
                                tb_qtde_peca.Text = _qtde_fat[j];

                            double valor_total_item = 0;
                            double desconto_item = 0;
                            try
                            {
                                valor_total_item = Convert.ToDouble(tb_qtde_peca.Text) * Convert.ToDouble(tb_preco_unit_peca.Text);
                                desconto_item = valor_total_item * _porc_desconto;
                            }
                            catch { }

                            string origem = "";
                            string cst = "";
                            string ean = "";
                            string cfop = "";
                            tb_ncm_peca.Text = buscar_ncm_cfop_origem(_cod[j], tb_estado_cliente.Text, out origem, out cst, out ean, out cfop);

                            tb_desconto_item.Text = desconto_item.ToString("n3");
                            tb_cfo_peca.Text = cfop;

                            tb_origem_peca.Text = "0"; //só tem produto nacional
                            //tb_ean.Text = ean;
                            //if (tb_ean.Text.Length < 5)
                            //    tb_ean.Text = "";
                            //tb_cst.Text = cst;
                            if (tb_descricao_peca.Text != "")
                            {
                                string cod_peca = tb_cod_peca.Text;
                                string qtde = tb_qtde_peca.Text;
                                inserir_itens(false, "", ""); //validar isso quando for usar romaneio
                                if (_tipo == "Industrialização" && tb_cliente.Text.Contains("BRALYX"))
                                {
                                    if (razao_social_empresa.Contains("MECANICA"))
                                        inserir_retorno(cod_peca, qtde);
                                }
                            }




                        }
                        buscar_forma_pgto(tb_cnpj_cliente.Text, forma_pgto);



                    }
                    catch
                    {
                        MessageBox.Show("erro na inserção do item");
                        fbConnection1.Close();
                    }
                }
            }
        }

        private string buscar_tipo_cliente_romaneio(string cod_liberacao)
        {
            try
            {
                FbCommand select = new FbCommand();
                select.Connection = fbConnection1;
                select.CommandText =
                    "SELECT TIPO_CLIENTE, PESSOA_FISICA_CLIENTE FROM CLIENTES c " +
                    "INNER JOIN LIBERACAO l ON l.CNPJ_CLIENTE_LIB = c.CNPJ " +
                    " WHERE l.COD_LIB = '" + cod_liberacao + "'";
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
    }
}


