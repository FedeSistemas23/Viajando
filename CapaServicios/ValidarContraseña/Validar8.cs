using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaServicios
{
    public static class Validar8
    {
        public static bool V8caracteres(string contraseña)
        {
            bool validado8 = false;
            for (int i = 1; i < contraseña.Length; i++)
            {

                if (i >= 7) { validado8 = true; } else { validado8 = false; }



            };


            return validado8;
        }
    }
}
