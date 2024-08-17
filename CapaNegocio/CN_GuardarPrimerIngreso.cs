using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaServicios;
using CapaSesion;

namespace CapaNegocio
{
    public class CN_GuardarPrimerIngreso
    {
        CD_GuardarPrimerIngreso cd_primeringreso = new CD_GuardarPrimerIngreso();
        public void GuardarPrimerIngreso()
        {
            cd_primeringreso.GuardarPrimerIngreso();
        }
    }
}
