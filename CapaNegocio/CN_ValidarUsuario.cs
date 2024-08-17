using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_ValidarUsuario
    {
        CD_ValidarUsuario validarusuario = new CD_ValidarUsuario();
        public bool ValidarUsuarioL(string username)
        {
            bool existe = validarusuario.ValidarUsuarioD(username);
            if (existe)
            { 
                return true;
            }
            else 
            { 
                return false; 
            }
        }
    }
}
