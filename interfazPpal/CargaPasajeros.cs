﻿using System;
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
    public partial class CargaPasajeros : Form
    {
        public CargaPasajeros()
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
