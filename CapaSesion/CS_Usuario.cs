using System;

namespace CapaSesion
{
    public static class CS_Usuario
    {

        public static int Id_Usuario { get; set; }
        public static string Username { get; set; }
        public static string password { get; set; }
        public static int digito { get; set; }
        public static string familia { get; set; }
        public static int idRolasignado { get; set; }
        public static string email { get; set; }
        public static int intentos { get; set; }
        public static DateTime bloqueadoHasta { get; set; }
        public static DateTime fechaPrimerIngreso { get; set; }
        public static DateTime fechaUltimoCambio { get; set; }
        public static int venceCada { get; set; }

        public static string nombre { get; set; }

        public static bool Bloqueado { get; set; }
<<<<<<< HEAD
        public static bool UsuarioTemporal { get; set; }   
       
=======
        public static bool UsuarioTemporal { get; set; }

>>>>>>> d8c6b8bcf5034cb5e6d38c90e56245adc0d5da0c
    }

}
