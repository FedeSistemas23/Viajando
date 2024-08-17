using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaNegocio;
using CapaServicios;
using CapaSesion;

namespace CapaNegocio
{
    public class CN_EditarPassword
    {
        CD_EditarPassword usuario = new CD_EditarPassword();
        public void EditarPassword(string hasheo2, string username)
        {            
            usuario.EditarPassword (hasheo2, username);
        }
    }
}
