using System;

namespace CapaSesion
{
    public class CS_Paquete
    {
        public DateTime FechaSalida { get; set; }
        public DateTime FechaRegreso { get; set; }
        public string Destino { get; set; }
        public int CantidadDias { get; set; }
        public int CantidadNoches { get; set; }
        public string Regimen { get; set; }
        public string ProveedorHotel { get; set; }
        public string ProveedorBus { get; set; }
        public double GastosAdministrativos { get; set; }
        public double PrecioLista { get; set; }
        public double PrecioEfectivo { get; set; }
        public double Coste { get; set; }
        public int Disponibilidad { get; set; }
        public int CantidadDeHab { get; set; }
        public int Single { get; set; }
        public int Doble { get; set; }
        public int Triple { get; set; }
        public int Cuadruple { get; set; }
        public string TipoBus { get; set; }
        public int CantidadAsientos { get; set; }
        public int AsientosCama { get; set; }
        public int AsientosSemicama { get; set; }
    }
}
