using CapaSesion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loggin
{
    public partial class FrmIngresarEditarPaquete : Form
    {
        public FrmIngresarEditarPaquete()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Paquete paquete = new Paquete()
            {
                FechaSalida = dtpFechaSalida.Value,
                FechaRegreso = dtpFechaRegreso.Value,
                Destino = txtDestino.Text,
                CantidadDias = int.Parse(txtCantidadDias.Text),
                CantidadNoches = int.Parse(txtCantidadNoches.Text),
                Regimen = txtRegimen.Text,
                Excursion = txtExcursion.Text,
                ProveedorHotel = txtProveedorHotel.Text



            };

        }
    }
}
