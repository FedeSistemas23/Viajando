using System;

namespace CapaSesion
{
    // Es esta clase estan los atributos de la clase paquete, que se cargan con los valores que se ingresan por el formulario
    // Luego, el objeto es enviado a la clase Guardar Paquete de la Capa Negocio
    public class CS_Paquete
    {
        public DateTime FechaSalida { get; set; }
        public DateTime FechaRegreso { get; set; }
        public string Destino { get; set; }
        public int CantidadDias { get; set; }
        public int CantidadNoches { get; set; }
        public string Regimen { get; set; }
        public string Excursion { get; set; }
        public string ProveedorHotel { get; set; }
        public int Single { get; set; }
        public int Doble { get; set; }
        public int Triple { get; set; }
        public int Cuadruple { get; set; }
        public string ProveedorBus { get; set; }
        public int Semicamas { get; set; }
        public int Camas { get; set; }
        public double GastosAdministrativos { get; set; }
        public double PrecioLista { get; set; }
        public double PrecioEfectivo { get; set; }
        public int Descuento { get; set; }
        public int Disponibilidad { get; set; }

        public void GuardarNuevoPaquete(CS_Paquete paquete)
        {
            throw new NotImplementedException();
        }

        public void GuardarPaqueteD(CS_Paquete paquete)
        {
            throw new NotImplementedException();
        }
    }
}
