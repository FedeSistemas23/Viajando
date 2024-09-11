
using CapaDatos;
using CapaSesion;
using System.Data;

namespace CapaNegocio
{
    // Esta clase agrega en una lista, los datos provenientes del formulario de Ingresar Paquete
    // y luego los envia a la capa de datos para guardarlos en la base de datos
    public class CN_Paquete
    {
        private CD_Paquete NuevoPaquete;
        public CN_Paquete()
        {
            NuevoPaquete = new CD_Paquete();
        }

        public void GuardarPaqueteL(CS_Paquete paquete)
        {
            
            NuevoPaquete.GuardarPaqueteD(paquete);
        }



        public DataTable MostrarPaquetes()
        {
            DataTable tabla = new DataTable();
            tabla = NuevoPaquete.Mostrar();
            return tabla;
        }

    }
}
