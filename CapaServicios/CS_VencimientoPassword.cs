using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace CapaSesion
{
    public class CS_VencimientoPassword
 
    {
        public static int CalcularDiasRestantes(DateTime fechaUltimoCambio, int venceCada)
        {
            // Calcula la fecha en la que expira la contraseña
            DateTime fechaVencimiento = fechaUltimoCambio.AddDays(venceCada);
            Console.WriteLine("mensaje desde CS_VencimnientoPassword: fecha de vencimiento = " + fechaVencimiento);

            // Calcula la diferencia entre la fecha de vencimiento y la fecha actual
            TimeSpan difFechas = fechaVencimiento - DateTime.Now;

            // Retorna los días restantes
            return difFechas.Days;
        }
    }
}
