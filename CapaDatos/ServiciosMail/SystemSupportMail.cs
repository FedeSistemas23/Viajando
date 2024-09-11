namespace CapaDatos.Servicios_Mail
{
    class SystemSupportMail : ServidorCorreo
    {
        public SystemSupportMail()
        {
            senderMail = "bandas.castel@gmail.com";
            password = "bfwawdjycldhdjbd";
            host = "smtp.gmail.com";
            port = 587;
            ssl = true;
            inicializarSmtpClient();
        }
    }
}
