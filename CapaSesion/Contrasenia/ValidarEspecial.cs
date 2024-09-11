<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
=======
﻿using System.Linq;
>>>>>>> d8c6b8bcf5034cb5e6d38c90e56245adc0d5da0c

namespace CapaServicios
{
    public static class ValidarEspecial
    {
        public static bool Vespecial(string contraseña)
        {
            bool validado = false;
            string especiales = "!#$%&/()=*+~?'¡¿-_@,.{}[]¨´`'|°^";
            int retorno = especiales.Intersect(contraseña).Count();

            if (retorno > 0) { validado = true; }



            return validado;
        }
    }
}
