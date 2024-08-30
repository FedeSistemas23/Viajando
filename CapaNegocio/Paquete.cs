using System;

namespace CapaSesion
{
    public class Paquete
    {
        public DateTime FechaSalida { get; set; }
        public DateTime FechaRegreso { get; set; }
        public string Destino { get; set; }
        public int CantidadDias { get; set; }
        public int CantidadNoches { get; set; }
        public string Regimen { get; set; }
        public string Excursion { get; set; }
        public string ProveedorHotel { get; set; }
        public string ProveedorBus { get; set; }
        public double GastosAdministrativos { get; set; }
        public double PrecioLista { get; set; }
        public double PrecioEfectivo { get; set; }
        public int Descuento { get; set; }
        public int Disponibilidad { get; set; }

    }
}
