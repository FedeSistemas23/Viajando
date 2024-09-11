using System;
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
            DataTable DT = new DataTable();
            dataGrid.DataSource = null;
            DT = AltaUsuario.AñadirAtributos(NuevoUsuario);
            dataGrid.DataSource = DT;
           
                

           //if (resultado) MessageBox.Show( "Usuario " + NuevoUsuario.Username +  "" + " ingresado correctamente");
        }
    

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtPartido_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
