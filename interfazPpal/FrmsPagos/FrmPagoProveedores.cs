using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interfazPpal
{
    public partial class FrmPagoProveedores : Form
    {
        public FrmPagoProveedores(int a)
        {
            InitializeComponent();
            if (a == 0)
            {
                btnEliminar.Enabled = false;

            }
            
        }
        public FrmPagoProveedores(int a, int b)
        {
            InitializeComponent();
            if (a == 0 && b==1)
            {
                btnGuardar.Enabled = false;
                btnEditar.Enabled = false;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
