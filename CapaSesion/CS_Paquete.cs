using System;

namespace CapaSesion
{
<<<<<<< HEAD
=======
    // Es esta clase estan los atributos de la clase paquete, que se cargan con los valores que se ingresan por el formulario
    // Luego, el objeto es enviado a la clase Guardar Paquete de la Capa Negocio
>>>>>>> d8c6b8bcf5034cb5e6d38c90e56245adc0d5da0c
    public class CS_Paquete
    {
        public DateTime FechaSalida { get; set; }
        public DateTime FechaRegreso { get; set; }
        public string Destino { get; set; }
        public int CantidadDias { get; set; }
        public int CantidadNoches { get; set; }
        public string Regimen { get; set; }
<<<<<<< HEAD
        public string ProveedorHotel { get; set; }
        public string ProveedorBus { get; set; }
        public double GastosAdministrativos { get; set; }
        public double PrecioLista { get; set; }
        public double PrecioEfectivo { get; set; }
        public double Coste { get; set; }
        public int Disponibilidad { get; set; }
        public int CantidadDeHab { get; set; }
=======
        public string Excursion { get; set; }
        public string ProveedorHotel { get; set; }
>>>>>>> d8c6b8bcf5034cb5e6d38c90e56245adc0d5da0c
        public int Single { get; set; }
        public int Doble { get; set; }
        public int Triple { get; set; }
        public int Cuadruple { get; set; }
<<<<<<< HEAD
        public string TipoBus { get; set; }
        public int CantidadAsientos { get; set; }
        public int AsientosCama { get; set; }
        public int AsientosSemicama { get; set; }
=======
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
>>>>>>> d8c6b8bcf5034cb5e6d38c90e56245adc0d5da0c
    }
}
