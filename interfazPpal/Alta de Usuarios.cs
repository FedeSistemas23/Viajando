﻿using CapaServicios;
using CapaSesion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;




namespace Loggin
{
    public partial class Alta_de_Usuarios : Form
    {
        CN_Alta_Usuario AltaUsuario = new CN_Alta_Usuario();
        public Alta_de_Usuarios()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string pass = Aleatorios.Armar();
            string concatenados = pass + txtNombreUsuario.Text;
            string hasheo = Seguridad.SHA256(concatenados);
<<<<<<< HEAD
<<<<<<< HEAD
            AtributosUsuario NuevoUsuario = new AtributosUsuario()
=======
            CN_Nuevo_Usuario NuevoUsuario = new CN_Nuevo_Usuario()
>>>>>>> 07b1e3b662095515a706efd4e52b4d56a011117a
=======
            AtributosUsuario NuevoUsuario = new AtributosUsuario()
>>>>>>> Alta Usuario
            {
                Username = txtNombreUsuario.Text,
                nombre = txtNombre.Text,
                email = txtEmail.Text,
                Apellidos = txtApellido.Text,
                TipoDocumento = txtTipoDoc.Text,
                NumDocumento = txtNumDoc.Text,
                Telefono = txtTelefono.Text,
                Celular = txtCelular.Text,
                Calle = txtCalle.Text,
                NumCalle = txtNumCalle.Text,
                //Barrio = txtBarrio.Text,
                password = pass,
                digito = CreaDigitoVerificador.Calcular(hasheo),
                familia = int.Parse(cmbFamilias.SelectedItem.ToString()),
                intentos = int.Parse(npdIntentos.ToString()),
                venceCada = int.Parse(npdVenceCada.ToString()),
                Bloqueado = chbBloqueado.Checked,
            };
            AltaUsuario.AñadirAtributos(NuevoUsuario);
        }
    }
}
