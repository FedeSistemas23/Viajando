using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaSesion;

//ordenar los atributos entre los datos de usuario y persona
namespace CapaSesion
{

  

   public class CS_AtributosNuevoUsuario

    {
        public string Username { get; set; }
        public string password { get; set; } // se genera con el Aleatorio en Servicios
        public int Digito { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Apellidos { get; set; }
        public string TipoDocumento { get; set; }
        public string NumDocumento { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Calle { get; set; }
        public int NumCalle { get; set; }
        public string Localidad { get; set; }
        public string Partido { get; set; }
        public string Provincia { get; set; }
        public int Id_Flia { get; set; }
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
        public bool Bloqueado { get; set; }
        public int BloqueadoHasta { get; set; }
        public bool UsuarioTemporal { get; set; }
        public int VenceUsuario { get; set; }
        public int VencenPermisos { get; set; }
    }

}

