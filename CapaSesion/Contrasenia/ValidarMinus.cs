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
    public static class ValidarMinus
    {
        public static bool Vminus(string contraseña)
        {
            bool validado = false;
            for (int i = 0; i < contraseña.Length; i++)
            {
                if (char.IsLower(contraseña[i]))
                {
<<<<<<< HEAD
                    
=======

>>>>>>> d8c6b8bcf5034cb5e6d38c90e56245adc0d5da0c
                    validado = true;
                    return validado;
                }
            }
            return validado;
        }

    }
}
