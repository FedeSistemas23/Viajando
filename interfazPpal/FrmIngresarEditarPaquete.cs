using CapaNegocio;
using CapaSesion;
using System;
using System.Windows.Forms;

namespace Loggin
{
    public partial class FrmIngresarEditarPaquete : Form
    {
        CN_GuardarPaquete NuevoPaquete = new CN_GuardarPaquete();
        public FrmIngresarEditarPaquete()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {

            CS_Paquete paquete = new CS_Paquete()
            {
                FechaSalida = dtpFechaSalida.Value,
                FechaRegreso = dtpFechaRegreso.Value,
                Destino = txtDestino.Text,
                CantidadDias = Convert.ToInt32(npdCantidadDias.Value),
                CantidadNoches = Convert.ToInt32(npdCantidadNoches.Value),
                Regimen = txtRegimen.Text,
<<<<<<< HEAD
                Excursion = txtExcursion.Text,
                ProveedorHotel = txtProveedorHotel.Text,



            };
            NuevoPaquete.GuardarPaqueteL(paquete);

        }

        private void label15_Click(object sender, EventArgs e)
        {

=======
                ProveedorHotel = cmbHoteles.SelectedItem.ToString(),
                Single = Convert.ToInt32(npdSingle.Value),
                Doble = Convert.ToInt32(npdDoble.Value),
                Triple = Convert.ToInt32(npdTriple.Value),
                Cuadruple = Convert.ToInt32(npdCuadruple.Value),
                ProveedorBus = cmbBuses.SelectedItem.ToString(),
                Semicamas = Convert.ToInt32(npdSemicamas.Value),
                Camas = Convert.ToInt32(npdCamas.Value),
                GastosAdministrativos = Convert.ToInt32(txtGastosAdministrativos.Text),
                PrecioLista = Convert.ToInt32(txtPrecioLista.Text),
                PrecioEfectivo = Convert.ToInt32(txtPrecioEfectivo.Text),
                Descuento = Convert.ToInt32(txtDescuento.Text),
                Disponibilidad=Convert.ToInt32(npdDisponibilidad.Value),
            };
            NuevoPaquete.GuardarPaqueteL(paquete);
>>>>>>> 99cambios
        }
    }
}
