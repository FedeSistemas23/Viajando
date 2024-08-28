using CapaDatos;
using CapaSesion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    // Esta clase agrega en una lista, los datos provenientes del formulario de Ingresar Paquete
    // y luego los envia a la capa de datos para guardarlos en la base de datos
    public class CN_GuardarPaquete
    {
        CD_GuardarPaquete paquete = new CD_GuardarPaquete();
        private List<Paquete> nuevoPaquete = new List<Paquete>();

        public void AgregarPaquete (Paquete paquete)
        {
            nuevoPaquete.Add(paquete);           
        }
        public void GuardarPaqueteL(Paquete paquete)
        {
            
           // paquete.GuardarPaquete(paquete);
        }



        public List<Paquete> EditarPaquete()
        {
            return nuevoPaquete;
        }

    }
}
