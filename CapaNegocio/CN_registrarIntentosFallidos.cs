using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_registrarIntentosFallidos
    {
        CD_IntentosFallidos intentoFallido = new CD_IntentosFallidos(); 
        public bool  registraIntentofallido(string username)
        {
           intentoFallido.ActualizaIntentosFallidos(username);

            Console.WriteLine(  "MEnsaje desde CN_registrarIntentosFallidos linea 17: Intendo fallido registrado con exito");
            return true;
        }

    }
}
