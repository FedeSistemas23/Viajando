using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CapaSesion
{
    public static class Seguridad
    {

        // Encripta una cadena
        // No se usara en el sistema de Login, sino para algunos requerimientos de la practica.
        /*public static string Encriptar(this string _cadenaAencriptar)
        {
            byte[] encryted = System.Text.Encoding.Unicode.GetBytes(_cadenaAencriptar);
            string result = Convert.ToBase64String(encryted);
            return result;
        }

        // Esta función desencripta la cadena que le envíamos en el parámentro de entrada.
        public static string DesEncriptar(this string _cadenaAdesencriptar)
        {
            byte[] decryted = Convert.FromBase64String(_cadenaAdesencriptar);
            string result = Encoding.Unicode.GetString(decryted);
            return result;
        }*/

        public static string SHA256(string str)
        {
            SHA256 sha256 = SHA256Managed.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            StringBuilder sb = new StringBuilder();
            byte[] stream = sha256.ComputeHash(encoding.GetBytes(str));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();


        }
        public static string hasheo2(string username, string pass) {
            string userpass =username+pass ;
            string hasheo2 = Seguridad.SHA256(userpass);
            return hasheo2;
        }
    }
}

