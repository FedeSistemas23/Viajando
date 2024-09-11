using System;
<<<<<<< HEAD
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaSesion;
=======
>>>>>>> d8c6b8bcf5034cb5e6d38c90e56245adc0d5da0c

//ordenar los atributos entre los datos de usuario y persona
namespace CapaSesion
{

<<<<<<< HEAD
  

   public class AtributosUsuario
=======


    public class AtributosUsuario
>>>>>>> d8c6b8bcf5034cb5e6d38c90e56245adc0d5da0c

    {
        public string Username { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }

        public string Apellidos { get; set; }

        public string TipoDocumento { get; set; }
        public int NumDocumento { get; set; }

        public int Telefono { get; set; }
        public int Celular { get; set; }

        public string Calle { get; set; }
        public int NumCalle { get; set; }

        //public string Barrio { get; set; } //tenemos barrio en la base de datos?
        public string Localidad { get; set; }
<<<<<<< HEAD
        public DateTime BloqueadoHastal { get; set; }
        

        public  string password { get; set; } // se genera con el Aleatorio en Servicios
        public  int digito { get; set; }      // se genera con su metodo usando el aleatorio Todo esto en la capa
        public  int Id_flia { get; set; }
        public string familia{ get; set; }
        public  int intentos { get; set; }
        public  int VenceCada { get; set; }
        public bool Bloqueado { get; set; }
        public DateTime FechaUltimoCambio { get; set; }

        public string pass{ get; set; }
        
=======
        public bool UsuarioTemporal { get; set; }
        public DateTime BloqueadoHastal { get; set; }


        public string password { get; set; } // se genera con el Aleatorio en Servicios
        public int digito { get; set; }      // se genera con su metodo usando el aleatorio Todo esto en la capa
        public int Id_flia { get; set; }

        public string familia { get; set; }
        public int intentos { get; set; }
        public int VenceCada { get; set; }
        public bool Bloqueado { get; set; }
        public DateTime FechaUltimoCambio { get; set; }

        public string pass { get; set; }

>>>>>>> d8c6b8bcf5034cb5e6d38c90e56245adc0d5da0c

    }
}
