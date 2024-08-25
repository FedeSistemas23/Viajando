using System;
using System.Windows.Forms;

namespace interfazPpal
{
    public partial class FrmIngresarEditarProveedor : Form
    {
        public FrmIngresarEditarProveedor()
        {
            InitializeComponent();
            btnEditar.Visible = false;
            btnGuardar.Visible = false;
        }
        public FrmIngresarEditarProveedor(int a)
        {
            InitializeComponent();
            if (a == 0)
            {
                lblCAntidadAsientos.Visible = false;
                lblTIpoDeAsiento.Visible = false;
                npdCantidadAsientos.Visible=false;
                chbCama.Visible = false;
                chbSemicama.Visible = false;
                chbSuites.Visible = false;
            }
        }
        public FrmIngresarEditarProveedor(int a, int b)
        {
            InitializeComponent();
            if (a == 0 && b == 1)
            {
                lblCantidadHabitaciones.Visible = false;
                lblTipoDeHabitacion.Visible = false;
                lblDoble.Visible = false;
                lblTriple.Visible = false;
                lblCuadruple.Visible = false;
                chbDesayuno.Visible = false;
                chbMediaPension.Visible = false;
                chbPensionCompleta.Visible = false;
                npdCantidadHabitaciones.Visible = false;
                npdDoble.Visible = false;
                npdTriple.Visible = false;
                npdCuadruple.Visible = false;
                lblRegimen.Visible = false;

            }
        }

        private void FrmIngresarEditarProveedor_Load(object sender, EventArgs e)
        {

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
