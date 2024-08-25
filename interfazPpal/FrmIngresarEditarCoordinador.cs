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
    }
}
