using System;
using System.Collections.Generic;
using System.Text;
using System.Web;
using System.Configuration;
using System.Net.Mail;
using System.Net;


namespace Evolucao
{
    public class Email_orcamento
    {
        public void EnviarEmail(string emailDestinatario, string assunto, string corpo, string caminho_arquivo, out bool erro)
        {

            //Cria o objeto que envia o e-mail 

            SmtpClient client = new SmtpClient();

            //Cria o endereço de email do remetente 

           // MailAddress de = new MailAddress(ConfigurationSettings.AppSettings["gpsilvainfo@yahoo.com.br"]);

            MailAddress de = new MailAddress("tecnicausinagem@yahoo.com.br");
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
                client.Host = "smtp.mail.yahoo.com.br";
                client.Port = 25;
                client.Credentials = new NetworkCredential("tecnicausinagem@yahoo.com.br", "1q2w3e");
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
