using System;
using System.Windows.Forms;

namespace interfazPpal
{
    public partial class FrmIngresarEditarCoordinador : Form
    {
        public FrmIngresarEditarCoordinador()
        {
            InitializeComponent();
            btnDarDeBaja.Visible = false;
        }
        public FrmIngresarEditarCoordinador(int a)
        {
            InitializeComponent();
            if (a == 0)
            {
                btnGuardar.Visible = false;
                btnEditar.Visible = false;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FrmBuscarCoordinador coordinador = new FrmBuscarCoordinador();
            coordinador.Show();
        }
    }
}
