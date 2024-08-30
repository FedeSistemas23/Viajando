using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaServicios
{
    public static class ValidarMayus
    {
        public static bool Vmayus(string contraseña)
        {

            bool validado = false;


            for (int i = 0; i < contraseña.Length; i++)
            {
                if (char.IsUpper(contraseña[i]))
                {
                    validado = true;
                    return validado;
                }
            }
            return validado;
        }
    }
}
