<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaServicios
=======
﻿namespace CapaServicios
>>>>>>> d8c6b8bcf5034cb5e6d38c90e56245adc0d5da0c
{
    public static class ValidarDigito
    {
        public static bool Vdigito(string contraseña)
        {
            bool validado = false;

            //lo mismo que con mayusculas/minusculas
            for (int i = 0; i < contraseña.Length; i++)
            {
                if (char.IsDigit(contraseña[i]))
                {
                    validado = true;
                    return validado;
                }
            }
            return validado;
        }
    }
}
