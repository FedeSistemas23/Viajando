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
<<<<<<< HEAD
                
=======

>>>>>>> d8c6b8bcf5034cb5e6d38c90e56245adc0d5da0c
            }
        }
        public FrmPagoRecibidos(int b, int a)
        {
            InitializeComponent();
<<<<<<< HEAD
            if (b == 1 && a==1)
=======
            if (b == 1 && a == 1)
>>>>>>> d8c6b8bcf5034cb5e6d38c90e56245adc0d5da0c
            {
                btnGuardar.Enabled = false;
                btnEliminar.Enabled = true;
                btnEditar.Enabled = false;
                btnBuscarPago.Enabled = true;
<<<<<<< HEAD
               
=======

>>>>>>> d8c6b8bcf5034cb5e6d38c90e56245adc0d5da0c
            }
        }

        private void label3_Click(object sender, System.EventArgs e)
        {

        }

        private void button4_Click(object sender, System.EventArgs e)
        {

        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            FrmBuscarReserva reserva = new FrmBuscarReserva();
            reserva.Show();
        }

        private void FrmPagoRecibidos_Load(object sender, System.EventArgs e)
        {

        }
    }
}
