using Loggin;
using System;
using System.Windows.Forms;

namespace interfazPpal
{
    public partial class FrmBuscarPaquete : Form
    {
        public FrmBuscarPaquete()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {

        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            CrearReserva frm = new CrearReserva();
            frm.ShowDialog();
        }
    }
}
