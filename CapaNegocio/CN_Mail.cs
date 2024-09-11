using CapaDatos.Servicios_Mail;

namespace CapaNegocio
{
    public class EnviarMail
    {

        ServidorCorreo CN_ServidorCorreo = new ServidorCorreo();

        //ingresar un mail, envia contraseña.
        public void SendMail(string contraseña, string Email, string body, string recipientMail)
        {
            body = "la contraseña de su usuario es " + contraseña;
            recipientMail = "CONTRASEÑA DE USUARIO ";
            CN_ServidorCorreo.sendMail(Email, body, recipientMail);


        }
    }
}
