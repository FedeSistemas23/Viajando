namespace CapaServicios
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
