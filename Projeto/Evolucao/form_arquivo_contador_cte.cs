using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ICSharpCode.SharpZipLib.Zip;
using System.IO;

namespace Evolucao
{
    public partial class form_arquivo_contador_cte : Form
    {
        string[] _chave = new string[2000];
        string[] _n_nf = new string[2000];
        string[] _status = new string[2000];

        public form_arquivo_contador_cte()
        {
            InitializeComponent();
        }

        private void form_arquivo_contador_cte_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ZipOutputStream zipOutPut = new ZipOutputStream(File.Create(@"c:\\evolucao\\cte\zip\ctes_autorizadas.zip"));
            //Compactação level 9
            zipOutPut.SetLevel(9);
            zipOutPut.Finish();
            zipOutPut.Close();

            ZipOutputStream zipOutPut2 = new ZipOutputStream(File.Create(@"c:\\evolucao\\cte\zip\ctes_canceladas.zip"));
            //Compactação level 9
            zipOutPut2.SetLevel(9);
            zipOutPut2.Finish();
            zipOutPut2.Close();

            ZipOutputStream zipOutPut3 = new ZipOutputStream(File.Create(@"c:\\evolucao\\cte\zip\ctes_inutilizadas.zip"));
            //Compactação level 9
            zipOutPut3.SetLevel(9);
            zipOutPut3.Finish();
            zipOutPut3.Close();


            ZipFile zip_autorizadas = new ZipFile(@"c:\\evolucao\\cte\zip\ctes_autorizadas.zip");
            //Inicia a criação do ZIP
            zip_autorizadas.BeginUpdate();

            ZipFile zip_canceladas = new ZipFile(@"c:\\evolucao\\cte\zip\ctes_canceladas.zip");
            //Inicia a criação do ZIP
            zip_canceladas.BeginUpdate();

            ZipFile zip_inutilizadas = new ZipFile(@"c:\\evolucao\\cte\zip\ctes_inutilizadas.zip");
            //Inicia a criação do ZIP
            zip_inutilizadas.BeginUpdate();


            comando_select.CommandText = "SELECT * FROM CTE WHERE DATA_EMISSAO_CTE >= '" + Convert.ToDateTime(dt_inicial.Text).ToShortDateString().Replace("/",".") + "'" +
                "AND DATA_EMISSAO_CTE <= '" + Convert.ToDateTime(dt_final.Text).ToShortDateString().Replace("/", ".") + "'";
            DataSet nfs = new DataSet();
            fbConnection1.Open();
            datCte.SelectCommand = comando_select;
            datCte.Fill(nfs);
            int i = 0;
            foreach (DataRow dr in nfs.Tables[0].Rows)
            {
                _chave[i] = dr["CHAVE_ACESSO_CTE"].ToString();
                _n_nf[i] = dr["N_CTE"].ToString();
                _status[i] = dr["STATUS_CTE"].ToString();
                i++;
            }
            fbConnection1.Close(); 
            for (int j = 0; j < i; j++)
            {
                try
                {
                    if (_status[j].Contains("CTe Cancelada"))
                    {
                        string caminho = @"c:\\evolucao\\cte\canceladas\" + "CTE" + _chave[j] + ".xml";

                        if (System.IO.File.Exists(caminho))
                        {
                            zip_canceladas.NameTransform = new ZipNameTransform(caminho.Substring(0, caminho.LastIndexOf(@"\")));
                            zip_canceladas.Add(caminho);
                        }
                    }

                    else
                    {
                        if (_status[j].Contains("CTe Autorizada"))
                        {
                            string caminho = @"c:\\evolucao\\cte\autorizadas\" + "CTE" + _chave[j] + ".xml";

                            if (System.IO.File.Exists(caminho))
                            {
                                zip_autorizadas.NameTransform = new ZipNameTransform(caminho.Substring(0, caminho.LastIndexOf(@"\")));
                                zip_autorizadas.Add(caminho);
                            }
                        }
                        else
                            if (_status[j].Contains("CTe Inutilizada"))
                            {
                                string caminho = @"c:\\evolucao\\cte\inutilizadas\" + "CTE" + _chave[j] + ".xml";

                                if (System.IO.File.Exists(caminho))
                                {
                                    zip_inutilizadas.NameTransform = new ZipNameTransform(caminho.Substring(0, caminho.LastIndexOf(@"\")));
                                    zip_inutilizadas.Add(caminho);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Existem ctes que não foram autorizados nesse periodo, por favor verifique");
                            }
                    }
                }
                catch {
                    MessageBox.Show("erro");
                }

            }
            try
            {
                zip_autorizadas.CommitUpdate();
                zip_autorizadas.Close();
            }
            catch { }
            try
            {
                zip_canceladas.CommitUpdate();
                zip_canceladas.Close();
            }
            catch { }
            try
            {
                zip_inutilizadas.CommitUpdate();
                zip_inutilizadas.Close();
            }
            catch { }

            enviar_email();


        }
        private void enviar_email()
        {

            string razao_social_empresa = "", nome_fantasia_empresa = "", cnpj_empresa = "", ie_empresa = "", im_empresa = "", endereco_empresa = "", n_endereco_empresa = "",
        complemento_empresa = "", bairro_empresa = "", cidade_empresa = "", estado_empresa = "", cep_empresa = "", telefone_empresa = "", cod_cidade_empresa = "", pais_empresa = "",
        cod_pais_empresa = "", licenca_dll_nfe_empresa = "", nome_certificado_nfe_empresa = "", assunto_nfe_email_empresa = "", smtp_nfe_empresa = "", email_nfe_empresa = "",
        senha_email_nfe_empresa = "", logotipo_empresa = "", proxy_empresa = "", usuario_proxy_empresa = "", senha_proxy_empresa = "";

            detectar_dados_empresa(out razao_social_empresa, out nome_fantasia_empresa, out cnpj_empresa, out ie_empresa, out im_empresa, out endereco_empresa, out n_endereco_empresa,
                    out complemento_empresa, out bairro_empresa, out cidade_empresa, out estado_empresa, out cep_empresa, out telefone_empresa, out cod_cidade_empresa, out pais_empresa,
                    out cod_pais_empresa, out licenca_dll_nfe_empresa, out nome_certificado_nfe_empresa, out assunto_nfe_email_empresa, out smtp_nfe_empresa, out email_nfe_empresa,
                    out senha_email_nfe_empresa, out logotipo_empresa, out proxy_empresa, out usuario_proxy_empresa, out senha_proxy_empresa);

            string _caminho_autorizadas = "c:\\evolucao\\CTE\\zip\\" + "ctes_autorizadas.zip";
            string _caminho_canceladas = "c:\\evolucao\\CTE\\zip\\" + "ctes_canceladas.zip";
            string _caminho_inutilizadas = "c:\\evolucao\\CTE\\zip\\" + "ctes_inutilizadas.zip";
            //var assunto
            string _assunto = "CTes da Empresa: " + razao_social_empresa;
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
"<title>Prezado,</title>" +
"</head>" +
"<body lang=PT-BR link=blue vlink=purple style='tab-interval:35.4pt' fontface = 'Arial'> " +
"<div class=Section1> " +
"<p class=MsoPlainText><span style='font-family:'Comic Sans MS''>Seguem CTes em anexo. Data Inicial: " + dt_inicial.Text + " Data Final: " + dt_final.Text  + " <o:p></o:p></span></p> " +
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
            novo_email.EnviarEmailCte(tb_email.Text, _assunto, _mensagem, _caminho_autorizadas, _caminho_canceladas, _caminho_inutilizadas, email_nfe_empresa, senha_email_nfe_empresa, smtp_nfe_empresa, out _erro);
            if (_erro == false)
            {
                barra_status.Text = "Email enviado com sucesso. ";
            }
            else
            {
                barra_status.Text = "Email não enviado. Favor verificar dados. ";
            }
        }

        

        private void detectar_dados_empresa(out string razao_social_empresa, out string nome_fantasia_empresa, out string cnpj_empresa, out string ie_empresa, out string im_empresa, out string endereco_empresa, out string n_endereco_empresa,
                    out string complemento_empresa, out string bairro_empresa, out string cidade_empresa, out string estado_empresa, out string cep_empresa, out string telefone_empresa, out string cod_cidade_empresa, out string pais_empresa,
                    out string cod_pais_empresa, out string licenca_dll_nfe_empresa, out string nome_certificado_nfe_empresa, out string assunto_nfe_email_empresa, out string smtp_nfe_empresa, out string email_nfe_empresa,
                    out string senha_email_nfe_empresa, out string logotipo_empresa, out string proxy_empresa, out string usuario_proxy_empresa, out string senha_proxy_empresa)
        {
            razao_social_empresa = ""; nome_fantasia_empresa = ""; cnpj_empresa = ""; ie_empresa = ""; im_empresa = ""; endereco_empresa = ""; n_endereco_empresa = "";
            complemento_empresa = ""; bairro_empresa = ""; cidade_empresa = ""; estado_empresa = ""; cep_empresa = ""; telefone_empresa = ""; cod_cidade_empresa = ""; pais_empresa = "";
            cod_pais_empresa = ""; licenca_dll_nfe_empresa = ""; nome_certificado_nfe_empresa = ""; assunto_nfe_email_empresa = ""; smtp_nfe_empresa = ""; email_nfe_empresa = "";
            senha_email_nfe_empresa = ""; logotipo_empresa = ""; proxy_empresa = ""; usuario_proxy_empresa = ""; senha_proxy_empresa = "";
            try
            {
                comando_select.CommandText = "SELECT * FROM EMPRESA where LICENCA_DLL_NFE_EMPRESA is not null";
                DataSet empresa = new DataSet();
                fbConnection1.Open();
                datEmpresa.SelectCommand = comando_select;
                datEmpresa.Fill(empresa);

                foreach (DataRow dr in empresa.Tables[0].Rows)
                {
                    razao_social_empresa = dr["RAZAO_SOCIAL_EMPRESA"].ToString();
                    nome_fantasia_empresa = dr["NOME_FANTASIA_EMPRESA"].ToString();
                    cnpj_empresa = dr["CNPJ_EMPRESA"].ToString();
                    ie_empresa = dr["IE_EMPRESA"].ToString();
                    im_empresa = dr["IM_EMPRESA"].ToString();
                    endereco_empresa = dr["ENDERECO_EMPRESA"].ToString();
                    n_endereco_empresa = dr["N_ENDERECO_EMPRESA"].ToString();
                    complemento_empresa = dr["COMPLEMENTO_EMPRESA"].ToString();
                    bairro_empresa = dr["BAIRRO_EMPRESA"].ToString();
                    cidade_empresa = dr["CIDADE_EMPRESA"].ToString();
                    estado_empresa = dr["ESTADO_EMPRESA"].ToString();
                    cep_empresa = dr["CEP_EMPRESA"].ToString();
                    telefone_empresa = dr["TELEFONE_EMPRESA"].ToString();
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
                }
                this.fbConnection1.Close(); 
            }
            catch
            {
                fbConnection1.Close(); 
                MessageBox.Show("Erro ao buscar dados da empresa");
            }
        }
       
    }
}