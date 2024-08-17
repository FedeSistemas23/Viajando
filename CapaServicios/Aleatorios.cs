using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;

namespace CapaServicios
{
    public static class Aleatorios
    {            /*
            El siguiente metodo recibirá 3 parametros:
            El primero (booleano) = true si es alfanumerico / false si es solo numerico
            El segundo Parametro (entero) corresponde a la cantidad minima de digitos que devolvera el metodo de la clase
            El tercer parametro (eltero) es opcional, y se refiere a la cantidad de caracteres especiales que contendra el string devuelto
             */

            public static string Armar( int Cant=6, int CantCaractEspeciales = 0)
            {
                bool EsCaracteres = false;   
                string caracteres = "012345", resultado = "";
                if (!EsCaracteres)
                {
                    char[] arrayCaracteres = new char[Cant];
                    Random random = new Random();
                    for (int i = 0; i < arrayCaracteres.Length; i++)
                    {
                        arrayCaracteres[i] = caracteres[random.Next(caracteres.Length)];
                    }
                    resultado = new String(arrayCaracteres);
                }
                else
                {
                    resultado = Membership.GeneratePassword(Cant, CantCaractEspeciales);
                }
                return resultado;
            }
        
    }
}
