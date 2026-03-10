using System;
using System.Collections.Generic;
using System.Text;
using System.Web;
using System.Configuration;
using System.Net.Mail;
using System.Net;


namespace Evolucao
{
    public class Email
    {
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
