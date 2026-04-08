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
    public class Email_cte
    {

        private string[] detectar_dados_email()
        {
            string[] retorno = new string[2];
            FbConnection fbConnection1 = new FbConnection();
            try
            {
                FbCommand comando = new FbCommand();
                FbDataAdapter datEmpresa = new FbDataAdapter();
                DataSet empresa = new DataSet();
                comando.Connection = fbConnection1;
                fbConnection1.ConnectionString = @"User=SYSDBA;Password=masterkey;Database=c:\\evolucao\\evolucao.fdb;DataSource=10.3.3.4;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;Connection timeout=15;Pooling=True;Packet Size=8192;Server Type=0";
                comando.CommandText = "SELECT * FROM EMPRESA";
                fbConnection1.Open();
                datEmpresa.SelectCommand = comando;
                datEmpresa.Fill(empresa);
                fbConnection1.Close(); 
                foreach (DataRow dr in empresa.Tables[0].Rows)
                {
                    retorno[0] = dr["PORTA_EMAIL_EMP"].ToString();
                    retorno[1] = dr["SSL_EMP"].ToString();
                }

                return retorno;
            }
            catch(Exception a)
            {
                form_erro _erro = new form_erro();
                _erro.erro = a.ToString();
                _erro.ShowDialog();
                fbConnection1.Close(); 
                return retorno;
            }
        }

        public void EnviarEmail(string emailDestinatario, string assunto, string corpo, string caminho_arquivo, string caminho_danfe, string email_remetente, string senha_email_remetente, string smtp_email_remetente, out bool erro)
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
            AlternateView av1 = AlternateView.CreateAlternateViewFromString(mensagem.Body, null, System.Net.Mime.MediaTypeNames.Text.Html);
            //string strImageUrl = System.Web.HttpContext.Current.Server.MapPath("~/michele.jpg"); 
            //LinkedResource logo = new LinkedResource(@"c:\\evolucao\\atual.jpg", System.Net.Mime.MediaTypeNames.Image.Jpeg);
            //logo.ContentId = "atual";
            //To refer to this image in the html body, use <img src="cid:companylogo"/>  12.   
            //av1.LinkedResources.Add(logo);
           // mensagem.AlternateViews.Add(av1);  

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

                string[] dadosEmail = new string[2];
                dadosEmail = detectar_dados_email();

                //Envia o email 
                client.Host = smtp_email_remetente;
                client.Port = Convert.ToInt32(dadosEmail[0]);

                if (dadosEmail[1] == "")
                    dadosEmail[1] = "0";

                if (Convert.ToInt32(dadosEmail[1]) == 1)
                {
                    client.EnableSsl = true;
                }
                //Envia o email 
               
                client.Credentials = new NetworkCredential(email_remetente, senha_email_remetente);
                client.Send(mensagem);
                erro = false;

            }

            catch(Exception a)
            {
               
                form_erro _erro = new form_erro();
                _erro.erro = a.ToString();
                _erro.ShowDialog();
                erro = true;
            }

        }


    }
}
