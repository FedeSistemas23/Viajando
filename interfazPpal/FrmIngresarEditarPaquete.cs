<<<<<<< HEAD
﻿using CapaSesion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
=======
﻿using CapaNegocio;
using CapaSesion;
using System;
>>>>>>> d8c6b8bcf5034cb5e6d38c90e56245adc0d5da0c
using System.Windows.Forms;

namespace Loggin
{
    public partial class FrmIngresarEditarPaquete : Form
    {
<<<<<<< HEAD
=======
        CN_GuardarPaquete NuevoPaquete = new CN_GuardarPaquete();
>>>>>>> d8c6b8bcf5034cb5e6d38c90e56245adc0d5da0c
        public FrmIngresarEditarPaquete()
        {
            InitializeComponent();
        }

<<<<<<< HEAD
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Paquete paquete = new Paquete()
=======
        private void btnCrear_Click(object sender, EventArgs e)
        {

            CS_Paquete paquete = new CS_Paquete()
>>>>>>> d8c6b8bcf5034cb5e6d38c90e56245adc0d5da0c
            {
                FechaSalida = dtpFechaSalida.Value,
                FechaRegreso = dtpFechaRegreso.Value,
                Destino = txtDestino.Text,
<<<<<<< HEAD
                CantidadDias = int.Parse(txtCantidadDias.Text),
                CantidadNoches = int.Parse(txtCantidadNoches.Text),
                Regimen = txtRegimen.Text,
                Excursion = txtExcursion.Text,
                ProveedorHotel = txtProveedorHotel.Text
=======
                CantidadDias = Convert.ToInt32(npdCantidadDias.Value),
                CantidadNoches = Convert.ToInt32(npdCantidadNoches.Value),
                Regimen = txtRegimen.Text,
<<<<<<< HEAD
                Excursion = txtExcursion.Text,
                ProveedorHotel = txtProveedorHotel.Text,
>>>>>>> d8c6b8bcf5034cb5e6d38c90e56245adc0d5da0c



            };
<<<<<<< HEAD

        }
=======
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
>>>>>>> d8c6b8bcf5034cb5e6d38c90e56245adc0d5da0c
    }
}
