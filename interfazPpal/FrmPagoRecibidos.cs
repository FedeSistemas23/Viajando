using System.Windows.Forms;

namespace interfazPpal
{
    public partial class FrmPagoRecibidos : Form
    {
        public FrmPagoRecibidos(int a)
        {
            InitializeComponent();
            if (a == 0)
            {
                btnEliminar.Enabled = false;
                
            }
        }
        public FrmPagoRecibidos(int b, int a)
        {
            InitializeComponent();
            if (b == 1 && a==1)
            {
                btnGuardar.Enabled = false;
                btnEliminar.Enabled = true;
                btnEditar.Enabled = false;
                btnBuscarPago.Enabled = true;
               
            }
        }

        private void label3_Click(object sender, System.EventArgs e)
        {

        }

        private void button4_Click(object sender, System.EventArgs e)
        {

        }
    }
}
