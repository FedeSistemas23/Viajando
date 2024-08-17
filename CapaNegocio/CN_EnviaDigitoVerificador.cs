using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaServicios;
using CapaSesion;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_EnviaDigitoVerificador
    {
        CD_GuardaDigito digitoVerificador = new CD_GuardaDigito();
        //int dig = ArmarMail.digito;

        public void EnviarDigito()
        {
           // digitoVerificador.GuardarDigito(dig);
        }
    }
}
