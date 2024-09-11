using CapaNegocio;
using CapaSesion;
using System;
using System.Windows.Forms;

namespace interfazPpal
{
    public partial class FrmIngresarEditarPaquetes : Form
    {
        CN_Paquete NuevoPaquete;
        public FrmIngresarEditarPaquetes()
        {
            InitializeComponent();
            NuevoPaquete = new CN_Paquete();
        }
        private void MostrarProdctos()
        {
            dgvPaquetes.DataSource = NuevoPaquete.MostrarPaquetes();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
                CS_Paquete Paquete = new CS_Paquete()
                {
                FechaSalida = dtpFechaSalida.Value,
                FechaRegreso = dtpFechaRegreso.Value,
                Destino = txtDestino.Text,
                CantidadDias = Convert.ToInt32(npdCantidasDias.Value),
                CantidadNoches = Convert.ToInt32(npdCantidadNoches.Value),
                Regimen = txtRegimen.Text,
                ProveedorHotel = txtProveedorHotel.Text,
                ProveedorBus = txtTransporte.Text,
                GastosAdministrativos = Convert.ToDouble(txtGastosAdministrativos.Text),
                PrecioLista = Convert.ToDouble(txtPrecioLista.Text),
                PrecioEfectivo = Convert.ToDouble(txtPrecioEfectivo.Text),
                Coste = Convert.ToDouble(txtCoste.Text),
                Disponibilidad = Convert.ToInt32(npdDisponibilidad.Value),
                CantidadDeHab = Convert.ToInt32(npdCantidadHabitaciones.Value),
                Single = Convert.ToInt32(npdSIngle.Value),
                Doble = Convert.ToInt32(npdDobles.Value),
                Triple = Convert.ToInt32(npdTriple.Value),
                Cuadruple = Convert.ToInt32(npdCuadruple.Value),
                TipoBus = txtTipoBus.Text,
                CantidadAsientos = Convert.ToInt32(npdCantidadAsientos.Value),
                AsientosCama = Convert.ToInt32(npdAsientosCama.Value),
                AsientosSemicama = Convert.ToInt32(npdAsientosSemicama.Value),
                };
               NuevoPaquete.GuardarPaqueteL(Paquete);
            
                   
        }

        private void FrmIngresarEditarPaquetes_Load(object sender, EventArgs e)
        {
           // MostrarPaquetes();
        }
    }
}
