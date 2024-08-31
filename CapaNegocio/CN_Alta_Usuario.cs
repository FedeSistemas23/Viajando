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
<<<<<<<< HEAD:CapaNegocio/Alta Usuario/CN_Alta_Usuario.cs
        public void AñadirAtributos(AtributosUsuario usuario)
========
        public void AñadirAtributos(CN_Nuevo_Usuario usuario)
>>>>>>>> 07b1e3b662095515a706efd4e52b4d56a011117a:CapaNegocio/CN_Alta_Usuario.cs
        {
            usuarioD.AltaUsuarioD(usuario);
        }
    }
}
