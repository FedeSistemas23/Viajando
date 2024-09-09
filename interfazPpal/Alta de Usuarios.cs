using CapaNegocio;
using CapaServicios;
using CapaSesion;
using System;
using System.Data;
using System.Windows.Forms;

namespace Loggin
{
    public partial class Alta_de_Usuarios : Form
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
    }
}
