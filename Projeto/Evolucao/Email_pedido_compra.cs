using System;
using System.Collections.Generic;
using System.Text;
using System.Web;
using System.Configuration;
using System.Net.Mail;
using System.Net;
using FirebirdSql.Data.FirebirdClient;
using System.Data;


namespace Evolucao
{
    public class Email_pedido_compra
    {
        public string cnpj_empresa;
        public string _email, _senha_email;
        FbConnection fbConnection1 = new FbConnection(@"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=10.3.3.4;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=True;Packet Size=8192;Server Type=0");
        //public string cnpj_empresa;
        //empresa
        string razao_social_empresa = "", nome_fantasia_empresa = "", /*cnpj_empresa = "",*/ ie_empresa = "", im_empresa = "", cnae_empresa = "", endereco_empresa = "", n_endereco_empresa = "",
           complemento_empresa = "", bairro_empresa = "", cidade_empresa = "", estado_empresa = "", cep_empresa = "", telefone_empresa = "", cod_cidade_empresa = "", pais_empresa = "",
           cod_pais_empresa = "", licenca_dll_nfe_empresa = "", nome_certificado_nfe_empresa = "", assunto_nfe_email_empresa = "", smtp_nfe_empresa = "", email_nfe_empresa = "",
           senha_email_nfe_empresa = "", logotipo_empresa = "", proxy_empresa = "", usuario_proxy_empresa = "", senha_proxy_empresa = "", crt_empresa = "", portaEmailEmpresa = "",
           sslEmpresa = "", serie_empresa = "", boleto_pedido_empresa = "", saida_estoque_pedido_empresa = "", cod_forn_empresa = "";


        private void detectar_dados_empresa(out string razao_social_empresa, out string nome_fantasia_empresa, out string cnpj_empresa, out string ie_empresa, out string im_empresa, out string cnae_empresa, out string endereco_empresa, out string n_endereco_empresa,
                    out string complemento_empresa, out string bairro_empresa, out string cidade_empresa, out string estado_empresa, out string cep_empresa, out string telefone_empresa, out string cod_cidade_empresa, out string pais_empresa,
                    out string cod_pais_empresa, out string licenca_dll_nfe_empresa, out string nome_certificado_nfe_empresa, out string assunto_nfe_email_empresa, out string smtp_nfe_empresa, out string email_nfe_empresa,
                    out string senha_email_nfe_empresa, out string logotipo_empresa, out string proxy_empresa, out string usuario_proxy_empresa, out string senha_proxy_empresa,
            out string crt_empresa, out string portaEmailEmpresa, out string sslEmpresa, out string serie_empresa, out string boleto_pedido_empresa, out string saida_estoque_pedido_empresa, out string cod_forn_empresa)
        {
            razao_social_empresa = ""; nome_fantasia_empresa = ""; cnpj_empresa = this.cnpj_empresa; ie_empresa = ""; im_empresa = ""; cnae_empresa = ""; endereco_empresa = ""; n_endereco_empresa = "";
            complemento_empresa = ""; bairro_empresa = ""; cidade_empresa = ""; estado_empresa = ""; cep_empresa = ""; telefone_empresa = ""; cod_cidade_empresa = ""; pais_empresa = "";
            cod_pais_empresa = ""; licenca_dll_nfe_empresa = ""; nome_certificado_nfe_empresa = ""; assunto_nfe_email_empresa = ""; smtp_nfe_empresa = ""; email_nfe_empresa = "";
            senha_email_nfe_empresa = ""; logotipo_empresa = ""; proxy_empresa = ""; usuario_proxy_empresa = ""; senha_proxy_empresa = ""; crt_empresa = ""; portaEmailEmpresa = "";
            sslEmpresa = ""; serie_empresa = ""; boleto_pedido_empresa = ""; saida_estoque_pedido_empresa = ""; cod_forn_empresa = "";
            try
            {
                FbCommand comando = new FbCommand();
                comando.Connection = fbConnection1;
                comando.CommandText = "SELECT * FROM EMPRESA where LICENCA_DLL_NFE_EMPRESA is not null AND CNPJ_EMPRESA = '" + cnpj_empresa + "' ";
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
                    //tb_cnpj_empresa.Text = cnpj_empresa;
                    //tb_razao_empresa.Text = razao_social_empresa;
                }

            }
            catch (Exception a)
            {
                fbConnection1.Close();
               // MessageBox.Show(a.Message);
            }
        }

        public void EnviarEmail(string emailDestinatario, string assunto, string corpo, string caminho_arquivo, out bool erro)
        {
            
            detectar_dados_empresa(out razao_social_empresa, out nome_fantasia_empresa, out cnpj_empresa, out ie_empresa, out im_empresa, out cnae_empresa, out endereco_empresa, out n_endereco_empresa,
      out complemento_empresa, out bairro_empresa, out cidade_empresa, out estado_empresa, out cep_empresa, out telefone_empresa, out cod_cidade_empresa, out pais_empresa,
      out cod_pais_empresa, out licenca_dll_nfe_empresa, out nome_certificado_nfe_empresa, out assunto_nfe_email_empresa, out smtp_nfe_empresa, out email_nfe_empresa,
      out senha_email_nfe_empresa, out logotipo_empresa, out proxy_empresa, out usuario_proxy_empresa, out senha_proxy_empresa, out crt_empresa, out portaEmailEmpresa, out sslEmpresa,
out serie_empresa, out boleto_pedido_empresa, out saida_estoque_pedido_empresa, out cod_forn_empresa);

            //Cria o objeto que envia o e-mail 

            SmtpClient client = new SmtpClient();

            //Cria o endereço de email do remetente 

           // MailAddress de = new MailAddress(ConfigurationSettings.AppSettings["gpsilvainfo@yahoo.com.br"]);

            MailAddress de = new MailAddress(_email);
            //Cria o endereço de email do destinatário -->

            MailAddress para = new MailAddress(emailDestinatario);

            

            MailMessage mensagem = new MailMessage(de, para);

            mensagem.IsBodyHtml = true;

            mensagem.DeliveryNotificationOptions = DeliveryNotificationOptions.OnSuccess;


            //Assunto do email 

            mensagem.Subject = assunto;

            //Conteúdo do email 

            mensagem.Body = corpo;
            System.Net.Mail.Attachment inline = new System.Net.Mail.Attachment(@caminho_arquivo);
            inline.ContentDisposition.Inline = true;
            mensagem.Attachments.Add(inline);
            



            try
            {
                
                //Envia o email   
                bool _ssl = false;
                if (sslEmpresa == "1")
                      _ssl = true;
                client.EnableSsl = _ssl;
                client.Host = smtp_nfe_empresa;
                client.Port = Convert.ToInt16(portaEmailEmpresa);

                client.Credentials = new NetworkCredential(_email, _senha_email);
                client.Send(mensagem);
                erro = false;

            }

            catch
            {
                erro = true;
            }

        }


    }
}
