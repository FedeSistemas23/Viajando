using CapaDatos;
<<<<<<< HEAD
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaNegocio;
using CapaSesion;
=======
using CapaSesion;
using System;
>>>>>>> d8c6b8bcf5034cb5e6d38c90e56245adc0d5da0c
using System.Data;

namespace CapaNegocio
{
    public class CN_Alta_Usuario

    {
        CD_AltaUsuario usuarioD = new CD_AltaUsuario();


<<<<<<< HEAD
       // public void AñadirAtributos(AtributosUsuario usuario)

        public DataTable AñadirAtributos(CS_AtributosNuevoUsuario usuario)
        {
            
=======
        // public void AñadirAtributos(AtributosUsuario usuario)

        public DataTable AñadirAtributos(AtributosUsuario usuario)
        {

>>>>>>> d8c6b8bcf5034cb5e6d38c90e56245adc0d5da0c
            try
            {
                DataTable dt = new DataTable();
                dt = usuarioD.AltaUsuarioD(usuario);
                return dt;
<<<<<<< HEAD
               
            }
            catch (Exception ex)
            {
                Console.WriteLine( "Error al obtener datos " + ex.Message);
=======

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener datos " + ex.Message);
>>>>>>> d8c6b8bcf5034cb5e6d38c90e56245adc0d5da0c
                return usuarioD.AltaUsuarioD(usuario); ;
            }
        }
    }
}
