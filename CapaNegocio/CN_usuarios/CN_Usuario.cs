using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaServicios;
using System.Data;
using CapaSesion;
using System.Web;


namespace CapaNegocio
{
    public class CN_Usuario
    {
        CD_Usuario cdUsuario = new CD_Usuario();

        public bool Login(string username, string password)
        {
            bool existe = cdUsuario.Login(username, password);
            if (existe) 
            {    
                return true;
            }
            else
            {
                return false;
            }
        }

        public string[] PreguntasAleatoriasL()
        {
            string[] PreguntasAleatorias = cdUsuario.PreguntasAleatorias();
            return PreguntasAleatorias;
        }

        public bool ValidarCorreo(string correo)
        {
            return cdUsuario.ValidarMail(correo);
        }

    //- Funcion para recuperar la contraseña, llama a recuperarPasword() de CD_Usuario, pasando como argumento el email
        public string recoverPassword(string correo, string aleatorio)
        {
            string mensaje; 
            mensaje = cdUsuario.recuperoPassword(correo, aleatorio);
            return mensaje;
        }
        

        
        public void ALtaUsuarioL(string nombre, string apellido, string usuario, string email, string password)
        {
            cdUsuario.AltaUsuario(nombre, apellido, usuario, email, password);
        }

        
    }
}
