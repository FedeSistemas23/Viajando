using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ordenar los atributos entre los datos de usuario y persona
namespace CapaNegocio
{

  
   public class CN_Nuevo_Usuario

    {
        public string Username { get; set; }
        public string nombre { get; set; }
        public string email { get; set; }

        public string Apellidos { get; set; }

        public string TipoDocumento { get; set; }
        public string NumDocumento { get; set; }

        public string Telefono { get; set; }
        public string Celular { get; set; }

        public string Calle { get; set; }
        public string NumCalle { get; set; }

        public string Barrio { get; set; } //tenemos barrio en la base de datos?
        public string Localidad { get; set; }

        

        public  string password { get; set; } // se genera con el Aleatorio en Servicios
        public  int digito { get; set; }      // se genera con su metodo usando el aleatorio Todo esto en la capa
        public  int familia { get; set; }
        
        public  int intentos { get; set; }
        public  int venceCada { get; set; }
        public bool Bloqueado { get; set; }

        

    }
}
