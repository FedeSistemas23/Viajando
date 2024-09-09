using System;
using System.Windows.Forms;

namespace interfazPpal
{
    public partial class FrmPagoVendedor : Form
    {
        public FrmPagoVendedor()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarReserva_Click(object sender, EventArgs e)
        {
            FrmBuscarReserva reserva = new FrmBuscarReserva();
            reserva.Show();
        }
    }
}
