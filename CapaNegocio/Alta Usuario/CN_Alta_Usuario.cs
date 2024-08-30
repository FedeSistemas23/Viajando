using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaNegocio;

namespace CapaNegocio.CN_usuarios
{
    public class CN_Alta_Usuario
    {
        CD_AltaUsuario usuarioD = new CD_AltaUsuario();
        public void AñadirAtributos(AtributosUsuario usuario)
        {
            usuarioD.AltaUsuarioD(usuario);
        }
    }
}
