using interfazPpal;
using System;
using System.Windows.Forms;

namespace Loggin
{
    public partial class CrearReserva : Form
    {
        public CrearReserva()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CargaPasajeros FRM = new CargaPasajeros();
            FRM.Show();
        }
    }
}
