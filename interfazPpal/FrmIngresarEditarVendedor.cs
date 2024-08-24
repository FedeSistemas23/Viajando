using System;
using System.Windows.Forms;

namespace interfazPpal
{
    public partial class FrmIngresarEditarVendedor : Form
    {
        public FrmIngresarEditarVendedor(int a)
        {
            InitializeComponent();
            if (a == 0)
            {
                btnGuardar.Visible = false;

            }
        }

            private void textBox1_TextChanged(object sender, EventArgs e)
            {

            }
        }
    }
