using CapaDatos;
using CapaSesion;
using System;
using System.Data;

namespace CapaNegocio
{
    public class CN_Alta_Usuario

    {
        CD_AltaUsuario usuarioD = new CD_AltaUsuario();


        // public void AñadirAtributos(AtributosUsuario usuario)

        public DataTable AñadirAtributos(AtributosUsuario usuario)
        {

            try
            {
                DataTable dt = new DataTable();
                dt = usuarioD.AltaUsuarioD(usuario);
                return dt;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener datos " + ex.Message);
                return usuarioD.AltaUsuarioD(usuario); ;
            }
        }
    }
}
