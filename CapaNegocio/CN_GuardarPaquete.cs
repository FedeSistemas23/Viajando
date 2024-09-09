using CapaDatos;
using CapaSesion;

namespace CapaNegocio
{

    public class CN_GuardarPaquete
    {
<<<<<<< HEAD
        CD_GuardarPaquete paqueteD = new CD_GuardarPaquete();
        private List<Paquete> nuevoPaquete = new List<Paquete>();

/*public void AgregarPaquete (Paquete paquete)
        {
            nuevoPaquete.Add(paquete);           
        }*/
        public void GuardarPaqueteL(Paquete paquete)
        {
            //paqueteD.GuardarPaqueteD(paquete);
        }

        /*public List<Paquete> EditarPaquete()
        {
            return nuevoPaquete;
        }*/

=======
        CD_GuardarPaquete paquete = new CD_GuardarPaquete();

        public void GuardarPaqueteL(CS_Paquete paquete)
        {
            paquete.GuardarPaqueteD(paquete);
        }
>>>>>>> 99cambios
    }
}
