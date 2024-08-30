using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.CN_usuarios
{
    public class CN_Alta_Usuario
    {
        CD_AltaUsuario usuarioD = new CD_AltaUsuario();
        public void AñadirAtributos(CN_Nuevo_Usuario usuario)
        {
            usuarioD.AltaUsuarioD(usuario);
        }
    }
}
