﻿namespace CapaServicios
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
