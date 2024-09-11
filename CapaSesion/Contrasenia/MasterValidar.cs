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
    public static class ValidarPass
    {

        public static bool MasterValidarPass(string contraseña)
        {


            bool validado = false;

            if (Validar8.V8caracteres(contraseña) == true && ValidarMinus.Vminus(contraseña) && ValidarMayus.Vmayus(contraseña) && ValidarDigito.Vdigito(contraseña) && ValidarEspecial.Vespecial(contraseña)) { validado = true; }

            return validado;
        }

    }
}
