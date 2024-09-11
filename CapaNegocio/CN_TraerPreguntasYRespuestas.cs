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
