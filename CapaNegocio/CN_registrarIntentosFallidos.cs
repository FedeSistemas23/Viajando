using CapaDatos;
using System;
<<<<<<< HEAD
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
=======
>>>>>>> d8c6b8bcf5034cb5e6d38c90e56245adc0d5da0c

namespace CapaNegocio
{
    public class CN_registrarIntentosFallidos
    {
<<<<<<< HEAD
        CD_IntentosFallidos intentoFallido = new CD_IntentosFallidos(); 
        public bool  registraIntentofallido(string username)
        {
           intentoFallido.ActualizaIntentosFallidos(username);

            Console.WriteLine(  "MEnsaje desde CN_registrarIntentosFallidos linea 17: Intendo fallido registrado con exito");
=======
        CD_IntentosFallidos intentoFallido = new CD_IntentosFallidos();
        public bool registraIntentofallido(string username)
        {
            intentoFallido.ActualizaIntentosFallidos(username);

            Console.WriteLine("MEnsaje desde CN_registrarIntentosFallidos linea 17: Intendo fallido registrado con exito");
>>>>>>> d8c6b8bcf5034cb5e6d38c90e56245adc0d5da0c
            return true;
        }

    }
}
