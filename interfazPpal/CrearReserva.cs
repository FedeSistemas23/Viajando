﻿using interfazPpal;
using System;
<<<<<<< HEAD
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
=======
>>>>>>> d8c6b8bcf5034cb5e6d38c90e56245adc0d5da0c
using System.Windows.Forms;

namespace Loggin
{
    public partial class CrearReserva : Form
    {
        public CrearReserva()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CargaPasajeros FRM = new CargaPasajeros();
            FRM.Show();
        }
    }
}
