using CapaNegocio;
using CapaServicios;
using CapaSesion;

using System;
using System.Windows.Forms;

namespace interfazPpal
{
    public partial class Usuario : Form
    {
        //EnviarMail CV_enviarmail = new EnviarMail();


        public Usuario()
        {
            InitializeComponent();
        }



        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }


        private void button7_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombreUsuario.Text) || string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtApellido.Text) || string.IsNullOrEmpty(txtEmailAlta.Text))
            {
                lblLeyenda.Text = "Todos los campos son obligatorios.";
            }
            else
            {
                CN_UsuarioEnSesion Usuario = new CN_UsuarioEnSesion();
                string aleatorio = Aleatorios.Armar();
                ArmarMail.Preparar(txtNombreUsuario.Text, txtEmailAlta.Text, aleatorio);
                string concatenacion = txtNombreUsuario.Text + aleatorio;
                string hasheo2 = Seguridad.SHA256(concatenacion);
                Usuario.ALtaUsuarioL(txtNombre.Text, txtApellido.Text, txtNombreUsuario.Text, txtEmailAlta.Text, aleatorio);

                //CV_enviarmail.SendMail(aleatorio,txtEmailAlta.Text,null,null);

                //bool resultado = Usuario.ValidarUsuarioL(txtNombreUsuario.Text);
                /*if (resultado == true)
                {           
                    Usuario.ALtaUsuarioL(txtNombre.Text, txtApellido.Text, txtNombreUsuario.Text, txtEmailAlta.Text, aleatorio);
                    MessageBox.Show("El usuario fue creado con exito. Se envio la contraseña aleatoria al email registrado");
                }
                else
                {
                    lblLeyenda.Text = "El nombre de Usuario ya existe";
                }*/
            }

        }


        private void lblLeyenda_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
