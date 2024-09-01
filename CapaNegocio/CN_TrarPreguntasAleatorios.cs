using CapaDatos;


namespace CapaNegocio
{
    public class CN_TrarPreguntasAleatorios
    {
        CD_Usuario cdUsuario = new CD_Usuario();      
        public string[] PreguntasAleatoriasL()
        {
            string[] PreguntasAleatorias = cdUsuario.PreguntasAleatorias();
            return PreguntasAleatorias;
        }
    }
}
