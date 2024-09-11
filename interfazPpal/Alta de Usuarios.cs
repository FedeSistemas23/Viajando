<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaServicios;
using CapaSesion;
using interfazPpal;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Loggin
{
    public  partial class Alta_de_Usuarios : Form
=======
﻿using CapaNegocio;
using CapaServicios;
using CapaSesion;
using System;
using System.Data;
using System.Windows.Forms;

namespace Loggin
{
    public partial class Alta_de_Usuarios : Form
>>>>>>> d8c6b8bcf5034cb5e6d38c90e56245adc0d5da0c
    {
        CN_Alta_Usuario AltaUsuario = new CN_Alta_Usuario();
        public Alta_de_Usuarios()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string pass = Aleatorios.Armar();
<<<<<<< HEAD
            Console.WriteLine( pass);
            string concatenados = pass + txtNombreUsuario.Text;
            string hasheo = Seguridad.SHA256(concatenados);

            CS_AtributosNuevoUsuario NuevoUsuario = new CS_AtributosNuevoUsuario()

            {
                Username = txtNombreUsuario.Text,
                Nombre = txtNombre.Text,
                Apellidos = txtApellido.Text,
                Email = txtEmail.Text,
                TipoDocumento = txtTipoDoc.SelectedItem.ToString(),
                NumDocumento = txtNumDoc.Text,
                Telefono = txtTelefono.Text,
                Celular = txtCelular.Text,
                Calle = txtCalle.Text,
                NumCalle = Convert.ToInt32(txtNumCalle.Text),
                Localidad = txtLocalidad.Text,
                Partido = txtProvincia.Text,
                Provincia = txtProvincia.Text,
                Id_Flia = Convert.ToInt32(cmbFamilias.SelectedItem.ToString()),
                password = pass,
                Digito = CreaDigitoVerificador.Calcular(hasheo),
                intentos = Convert.ToInt32(npdIntentos.Value), // Usar Value para obtener el valor numérico de NumericUpDown.
                VencePass = Convert.ToInt32(npdVenceCada.Value),
                UsuarioTemporal = ckbUsuarioTemporal.Checked,
                Bloqueado = Convert.ToBoolean(chbBloqueado.Checked),
                BloqueadoHasta = Convert.ToInt32(npdBloqueadoPorDias.Value),
                VenceUsuario = Convert.ToInt32(npdVenceUsuario.Value),
                VencenPermisos = Convert.ToInt32(npdVencePermisos.Value),
            };
                 //AltaUsuario.AñadirAtributos(NuevoUsuario);
=======
            Console.WriteLine(pass);
            string concatenados = pass + txtNombreUsuario.Text;
            string hasheo = Seguridad.SHA256(concatenados);

            AtributosUsuario NuevoUsuario = new AtributosUsuario()

            {
                Username = txtNombreUsuario.Text,
                password = pass,
                Nombre = txtNombre.Text,
                // Id_flia = Convert.ToInt32(cmbFamilias.SelectedItem.ToString()),
                Apellidos = txtApellido.Text,
                Email = txtEmail.Text,
                VenceCada = (int)npdVenceCada.Value,
                TipoDocumento = txtTipoDoc.SelectedItem.ToString(),
                NumDocumento = Convert.ToInt32(txtNumDoc.Text),
                Telefono = Convert.ToInt32(txtTelefono.Text),
                Celular = Convert.ToInt32(txtCelular.Text),
                Calle = txtCalle.Text,
                NumCalle = Convert.ToInt32(txtNumCalle.Text),
                Localidad = txtLocalidad.Text,

                digito = CreaDigitoVerificador.Calcular(hasheo),

                familia = cmbFamilias.SelectedItem.ToString(),
                intentos = Convert.ToInt32(npdIntentos.Value), // Usar Value para obtener el valor numérico de NumericUpDown.
                UsuarioTemporal = ckbUsuarioTemporal.Checked,
                //VenceCada = Convert.ToInt32(npdVenceCada.Value),
                //intentos = int.Parse(npdIntentos.ToString()),
                Bloqueado = chbBloqueado.Checked,
            };
            //AltaUsuario.AñadirAtributos(NuevoUsuario);
>>>>>>> d8c6b8bcf5034cb5e6d38c90e56245adc0d5da0c
            DataTable DT = new DataTable();
            dataGrid.DataSource = null;
            DT = AltaUsuario.AñadirAtributos(NuevoUsuario);
            dataGrid.DataSource = DT;
<<<<<<< HEAD
           
                

           //if (resultado) MessageBox.Show( "Usuario " + NuevoUsuario.Username +  "" + " ingresado correctamente");
        }
    
=======



            //if (resultado) MessageBox.Show( "Usuario " + NuevoUsuario.Username +  "" + " ingresado correctamente");
        }

>>>>>>> d8c6b8bcf5034cb5e6d38c90e56245adc0d5da0c

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
<<<<<<< HEAD

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtPartido_TextChanged(object sender, EventArgs e)
        {

        }
=======
>>>>>>> d8c6b8bcf5034cb5e6d38c90e56245adc0d5da0c
    }
}
