using System;
using System.Windows.Forms;

namespace interfazPpal
{
    public partial class FrmCargaPasajeros : Form
    {
        public FrmCargaPasajeros()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmPagoRecibidos frm = new FrmPagoRecibidos(1, 1);
            frm.ShowDialog();
        }
    }
}
