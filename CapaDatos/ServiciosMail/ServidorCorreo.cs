using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace CapaDatos.Servicios_Mail
{
    public class ServidorCorreo
    {
        private SmtpClient smptClient;
        protected string senderMail {  get; set; }
        protected string password { get; set; } 
        protected string host { get; set; } 
        protected int port { get; set; }
        protected bool ssl { get; set; }


        protected void inicializarSmtpClient()
        {
            smptClient = new SmtpClient();
            smptClient.Credentials = new NetworkCredential(senderMail, password);
            smptClient.Host = host;
            smptClient.Port = port;
            smptClient.EnableSsl = ssl;

        }

        public void sendMail (string subject, string body, string recipientMail)
        {
            var mensajeMail = new MailMessage();
            try
            {
                mensajeMail.From = new MailAddress(senderMail);
                mensajeMail.To.Add(recipientMail);
                mensajeMail.Subject = subject;
                mensajeMail.Body = body;
                mensajeMail.Priority = MailPriority.Normal;
                smptClient.Send(mensajeMail);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error al enviar email" + ex);
            }

            finally
            {
                mensajeMail.Dispose();
                //smptClient.Dispose();
            }

        }
    }
}
