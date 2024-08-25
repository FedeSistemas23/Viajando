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
                btnDarDeBaja.Enabled = false;
            }
        }
        public FrmIngresarEditarVendedor()
        {
            InitializeComponent();
            btnGuardar.Enabled = false;
            btnEditar.Enabled = false;
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
            {

            }

        private void btnAceptarVendedor_Click(object sender, EventArgs e)
        {

        }
    }
    }
