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
    public class CN_TraerPreguntasYRespuestas
    {
        CD_TraePreguntasYRespuestas preguntasYrespuestas = new CD_TraePreguntasYRespuestas();
        public void TraerPreguntas()
        {
            preguntasYrespuestas.TraerPreguntasyRespuestas();            
        }
    }
}
