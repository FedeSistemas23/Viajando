﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaSesion;

//ordenar los atributos entre los datos de usuario y persona
namespace CapaSesion
{
<<<<<<< HEAD:CapaNegocio/CN_Nuevo_Usuario.cs
<<<<<<<< HEAD:CapaNegocio/Alta Usuario/AtributosUsuario.cs
   public class AtributosUsuario
========
   public class CN_Nuevo_Usuario
>>>>>>>> 07b1e3b662095515a706efd4e52b4d56a011117a:CapaNegocio/CN_Nuevo_Usuario.cs
=======
   public class AtributosUsuario
>>>>>>> Alta Usuario:CapaSesion/AtributosUsuario.cs
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

        //public string Barrio { get; set; } //tenemos barrio en la base de datos?
        public string Localidad { get; set; }

        

        public  string password { get; set; } // se genera con el Aleatorio en Servicios
        public  int digito { get; set; }      // se genera con su metodo usando el aleatorio Todo esto en la capa
        public  int id_flia { get; set; }
        
        public  int intentos { get; set; }
        public  int venceCada { get; set; }
        public bool Bloqueado { get; set; }

        

    }
}