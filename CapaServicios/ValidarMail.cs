using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Data;


namespace CapaServicios
{
    public static class ValidarMail
    {
        /*
      
        if (!ValidaMail.Valid(txtCorreo.Text))
        {
            txtCorreo.ForeColor = Color.Red;
        }
        else
        {
            txtCorreo.ForeColor = Color.Black;
        }
        */


        public static bool Valid(string Correo)
        {
            String validacion;
            validacion = @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                            @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$";

            if (Regex.IsMatch(Correo, validacion))
            {
                if (Regex.Replace(Correo, validacion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        /*public static string EnviarPasswordAleatorio(string correo, string aleatorio)
        {
             var mailService = new ValidarMail.SystemSupportMail();
                mailService.sendMail(
                    subject: "SYSTEMA  VIAJANDO: Cambio de Password",
                    body: "Hola ya puedes cambiar tu contraseña,    TE LLEGO FEDE??" + aleatorio,
                    recipientMail: correo);
            
                return "Hola, su peticion para cambiar la contraseña se há generado. \n" + "Verifique su correo electrónico"; 
           
        }*/
        
        public static void SystemSupportMail(string correo, string aleatorio)
        {     
            
            using (MailMessage mail = new MailMessage())
            {
                mail.From = new MailAddress(correo);
                mail.To.Add(correo);
                mail.Subject = "";
                mail.Body = aleatorio;
                mail.IsBodyHtml = true; // Si el cuerpo del correo está en HTML

                using (SmtpClient smtp = new SmtpClient(correo))
                {
                    smtp.Credentials = new NetworkCredential();
                    

                    try
                    {
                        smtp.Send(mail);
                        Console.WriteLine("Correo enviado exitosamente.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error al enviar el correo: " + ex.Message);
                    }
                }
            }
        }
    }
} 




