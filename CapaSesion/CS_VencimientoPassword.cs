using System;
<<<<<<< HEAD
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Security.Cryptography.X509Certificates;
=======
>>>>>>> d8c6b8bcf5034cb5e6d38c90e56245adc0d5da0c

namespace CapaSesion
{
    public class CS_VencimientoPassword
<<<<<<< HEAD
 
=======

>>>>>>> d8c6b8bcf5034cb5e6d38c90e56245adc0d5da0c
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
