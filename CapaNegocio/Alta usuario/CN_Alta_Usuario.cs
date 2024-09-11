using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaNegocio;
using CapaSesion;
using System.Data;

namespace CapaNegocio
{
    public class CN_Alta_Usuario

    {
        CD_AltaUsuario usuarioD = new CD_AltaUsuario();


       // public void AñadirAtributos(AtributosUsuario usuario)

        public DataTable AñadirAtributos(CS_AtributosNuevoUsuario usuario)
        {
            
            try
            {
                DataTable dt = new DataTable();
                dt = usuarioD.AltaUsuarioD(usuario);
                return dt;
               
            }
            catch (Exception ex)
            {
                Console.WriteLine( "Error al obtener datos " + ex.Message);
                return usuarioD.AltaUsuarioD(usuario); ;
            }
        }
    }
}
