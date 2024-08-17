﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CapaServicios
{
    public static class EnviarMail
    {
        public static void sendMail(string to, string asunto, string body)
        {
            string from = "fededelveliz2017@Gmail.com"; //correo de la empresa
            string displayName = "Recuperacion de Cuenta"; //Lo que se ve al recibir el mail
            try
            {
                MailMessage mail = new MailMessage
                {
                    From = new MailAddress(from, displayName)
                };
                mail.To.Add(to);

                mail.Subject = asunto;
                mail.Body = body;
                mail.IsBodyHtml = true;

                SmtpClient client = new SmtpClient("smtp.gmail.com", 587)//Aquí debes sustituir tu servidor SMTP y el puerto
                {
                    Credentials = new NetworkCredential(from, "zsrwamtdjhlaruum"), //correo , contraseña de la cuenta de la empresa
                    EnableSsl = true//En caso de que tu servidor de correo no utilice cifrado SSL,poner en false
                };
                client.Send(mail);
            }
            catch
            {
                throw new Exception("ERROR AL ENVIAR EL MENSAJE. \n \n " +
                    "Por favor verifica tu conexión a internet y que tus datos sean correctos e intenta nuevamente.");
            }
        }
    }
}
