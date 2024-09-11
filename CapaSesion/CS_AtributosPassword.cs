namespace CapaSesion
{
    public class CS_AtributosPassword
    {
        public string password { get; set; } // se genera con el Aleatorio en Servicios
        public int Digito { get; set; }
        public int intentos { get; set; }
        public int VencePass { get; set; }
        public bool AvisarVencimientoPassword { get; set; }
        public bool ContraseñasAnteriores { get; set; }
        public bool Minuscula { get; set; }
        public bool Mayuscula { get; set; }
        public bool Numeros { get; set; }
        public bool CaracterEspecial { get; set; }
        public bool Minimo8Caracteres { get; set; }
        public bool RealizarPreguntasSeguridad { get; set; }
        public bool Autenticacion2pasos { get; set; }
    }
}
