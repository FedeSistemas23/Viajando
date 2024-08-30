using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaServicios
{
    public static class ValidarMinus
    {
        public static bool Vminus(string contraseña)
        {
            bool validado = false;
            for (int i = 0; i < contraseña.Length; i++)
            {
                if (char.IsLower(contraseña[i]))
                {
                    
                    validado = true;
                    return validado;
                }
            }
            return validado;
        }

    }
}
