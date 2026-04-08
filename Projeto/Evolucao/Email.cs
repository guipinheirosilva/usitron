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
    public class Email
    {
        private void detectar_dados_empresa(out string razao_social_empresa, out string nome_fantasia_empresa, out string cnpj_empresa, out string ie_empresa, out string im_empresa, out string cnae_empresa, out string endereco_empresa, out string n_endereco_empresa,
                 out string complemento_empresa, out string bairro_empresa, out string cidade_empresa, out string estado_empresa, out string cep_empresa, out string telefone_empresa, out string cod_cidade_empresa, out string pais_empresa,
                 out string cod_pais_empresa, out string licenca_dll_nfe_empresa, out string nome_certificado_nfe_empresa, out string assunto_nfe_email_empresa, out string smtp_nfe_empresa, out string email_nfe_empresa,
                 out string senha_email_nfe_empresa, out string logotipo_empresa, out string proxy_empresa, out string usuario_proxy_empresa, out string senha_proxy_empresa,
         out string crt_empresa, out string portaEmailEmpresa, out string sslEmpresa, out string serie_empresa)
        {
            razao_social_empresa = ""; nome_fantasia_empresa = ""; cnpj_empresa = ""; ie_empresa = ""; im_empresa = ""; cnae_empresa = ""; endereco_empresa = ""; n_endereco_empresa = "";
            complemento_empresa = ""; bairro_empresa = ""; cidade_empresa = ""; estado_empresa = ""; cep_empresa = ""; telefone_empresa = ""; cod_cidade_empresa = ""; pais_empresa = "";
            cod_pais_empresa = ""; licenca_dll_nfe_empresa = ""; nome_certificado_nfe_empresa = ""; assunto_nfe_email_empresa = ""; smtp_nfe_empresa = ""; email_nfe_empresa = "";
            senha_email_nfe_empresa = ""; logotipo_empresa = ""; proxy_empresa = ""; usuario_proxy_empresa = ""; senha_proxy_empresa = ""; crt_empresa = ""; portaEmailEmpresa = "";
            sslEmpresa = ""; serie_empresa = "";
            try
            {
                FbCommand comando = new FbCommand();
                FbConnection fbConnection1 = new FbConnection();
                fbConnection1.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=10.3.3.4;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=True;Packet Size=8192;Server Type=0";
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

                    serie_empresa = dr["SERIE_NF_EMPRESA"].ToString();
                }

            }
            catch (Exception a)
            {
                
            }
        }
        public void EnviarEmail(string emailDestinatario, string assunto, string corpo, string caminho_arquivo, string caminho_danfe, string caminho_boleto,
            string email_remetente, string senha_email_remetente, string smtp_email_remetente, out bool erro, string cnpj_cliente)
        {
            //empresa
            string razao_social_empresa = "", nome_fantasia_empresa = "", cnpj_empresa = "", ie_empresa = "", im_empresa = "", cnae_empresa = "", endereco_empresa = "", n_endereco_empresa = "",
               complemento_empresa = "", bairro_empresa = "", cidade_empresa = "", estado_empresa = "", cep_empresa = "", telefone_empresa = "", cod_cidade_empresa = "", pais_empresa = "",
               cod_pais_empresa = "", licenca_dll_nfe_empresa = "", nome_certificado_nfe_empresa = "", assunto_nfe_email_empresa = "", smtp_nfe_empresa = "", email_nfe_empresa = "",
               senha_email_nfe_empresa = "", logotipo_empresa = "", proxy_empresa = "", usuario_proxy_empresa = "", senha_proxy_empresa = "", crt_empresa = "", portaEmailEmpresa = "", sslEmpresa = "", serie_empresa = "";

            detectar_dados_empresa(out razao_social_empresa, out nome_fantasia_empresa, out cnpj_empresa, out ie_empresa, out im_empresa, out cnae_empresa, out endereco_empresa, out n_endereco_empresa,
       out complemento_empresa, out bairro_empresa, out cidade_empresa, out estado_empresa, out cep_empresa, out telefone_empresa, out cod_cidade_empresa, out pais_empresa,
       out cod_pais_empresa, out licenca_dll_nfe_empresa, out nome_certificado_nfe_empresa, out assunto_nfe_email_empresa, out smtp_nfe_empresa, out email_nfe_empresa,
       out senha_email_nfe_empresa, out logotipo_empresa, out proxy_empresa, out usuario_proxy_empresa, out senha_proxy_empresa, out crt_empresa, out portaEmailEmpresa, out sslEmpresa, out serie_empresa);

            try
            {
                //Cria o objeto que envia o e-mail 

                SmtpClient client = new SmtpClient();

                //Cria o endereço de email do remetente 

                // MailAddress de = new MailAddress(ConfigurationSettings.AppSettings["gpsilvainfo@yahoo.com.br"]);

                MailAddress de = new MailAddress(email_remetente);
                //Cria o endereço de email do destinatário -->

                if (emailDestinatario != "")
                {
                    MailAddress para = new MailAddress(emailDestinatario);



                    MailMessage mensagem = new MailMessage(de, para);

                    mensagem.IsBodyHtml = true;

                    try
                    {
                        FbCommand select = new FbCommand();
                        select.CommandText =
                            @"SELECT EMAIL_CONTATO FROM CONTATOS c 
                        inner join CLIENTES cl on c.COD_CLIENTE_FORN_CONTATO = cl.COD_CLIENTE 
                        where c.TIPO_CONTATO = 'NF' AND cl.CNPJ = '" + cnpj_cliente + "'";
                        FbConnection fbConnection1 = new FbConnection();
                        fbConnection1.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=10.3.3.4;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=True;Packet Size=8192;Server Type=0";
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
                                mensagem.CC.Add(dr[0].ToString());
                            }
                            catch { }
                        }
                    }
                    catch { }

                    //Assunto do email 

                    mensagem.Subject = assunto;

                    //Cópia para a prórpria Usitron.
                    mensagem.CC.Add(email_remetente);

                    mensagem.Body = corpo;
                    try
                    {
                        System.Net.Mail.Attachment inline = new System.Net.Mail.Attachment(@caminho_arquivo);
                        inline.ContentDisposition.Inline = true;
                        mensagem.Attachments.Add(inline);
                    }
                    catch { }
                    try
                    {
                        System.Net.Mail.Attachment danfe = new System.Net.Mail.Attachment(@caminho_danfe);
                        danfe.ContentDisposition.Inline = true;
                        mensagem.Attachments.Add(danfe);
                    }
                    catch { }

                    try
                    {
                        System.Net.Mail.Attachment boleto = new System.Net.Mail.Attachment(caminho_boleto);
                        boleto.ContentDisposition.Inline = true;
                        mensagem.Attachments.Add(boleto);
                    }
                    catch { }





                    try
                    {

                        System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                        //Envia o email 
                        bool _ssl = false;
                        if (sslEmpresa == "1")
                            _ssl = true;
                        client.EnableSsl = _ssl;
                        client.Host = smtp_email_remetente;
                        client.Port = Convert.ToInt32(portaEmailEmpresa);
                        client.UseDefaultCredentials = false;
                        client.Credentials = new NetworkCredential(email_remetente, senha_email_remetente);
                        client.DeliveryMethod = SmtpDeliveryMethod.Network;

                        mensagem.From = new MailAddress(email_remetente);

                       // client.Credentials = new NetworkCredential(email_remetente, senha_email_remetente);
                        client.Send(mensagem);

                       

                        erro = false;

                    }

                    catch(Exception ex)
                    {
                        erro = true;
                    }
                }
                else
                {
                    erro = true;
                }
            }
            catch
            {
                erro = true;
            }

        }
        public void EnviarEmailCte(string emailDestinatario, string assunto, string corpo, string caminho_autorizadas, string caminho_canceladas, string caminho_inutilizadas, string email_remetente, string senha_email_remetente, string smtp_email_remetente, out bool erro)
        {

            //Cria o objeto que envia o e-mail 

            SmtpClient client = new SmtpClient();

            //Cria o endereço de email do remetente 

            // MailAddress de = new MailAddress(ConfigurationSettings.AppSettings["gpsilvainfo@yahoo.com.br"]);

            MailAddress de = new MailAddress(email_remetente);
            //Cria o endereço de email do destinatário -->

            MailAddress para = new MailAddress(emailDestinatario);



            MailMessage mensagem = new MailMessage(de, para);

            mensagem.IsBodyHtml = true;



            //Assunto do email 

            mensagem.Subject = assunto;

            //Conteúdo do email 

            mensagem.Body = corpo;
            try
            {
                System.Net.Mail.Attachment inline = new System.Net.Mail.Attachment(@caminho_autorizadas);
                inline.ContentDisposition.Inline = true;
                mensagem.Attachments.Add(inline);
            }
            catch { }
            try
            {
                System.Net.Mail.Attachment danfe = new System.Net.Mail.Attachment(@caminho_canceladas);
                danfe.ContentDisposition.Inline = true;
                mensagem.Attachments.Add(danfe);
            }
            catch { }
            try
            {
                System.Net.Mail.Attachment danfe = new System.Net.Mail.Attachment(@caminho_inutilizadas);
                danfe.ContentDisposition.Inline = true;
                mensagem.Attachments.Add(danfe);
            }
            catch { }



            try
            {

                //Envia o email 
                client.Host = smtp_email_remetente;
                client.Port = 587;
                client.Credentials = new NetworkCredential(email_remetente, senha_email_remetente);
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
