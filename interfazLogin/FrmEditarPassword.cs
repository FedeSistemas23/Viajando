using CapaNegocio;
using CapaSesion;
using interfazLogin;
using System;
using System.Windows.Forms;

namespace interfazPpal
{
    public partial class FrmEditarPassword : Form
    {

        FrmPreguntasSeguridad SegPass = new FrmPreguntasSeguridad();
        CN_EditarPassword cn_usuario = new CN_EditarPassword();
        public string contraseña;

        public FrmEditarPassword()
        {
            InitializeComponent();
            btnCambiar.Enabled = false;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ValidarPassword(txtPass.Text);

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            contraseña = txtPasswordAnterior.Text;
            if (contraseña == CS_Usuario.password)
            {
                btnCambiar.Enabled = true;
            }
            else { btnCambiar.Enabled = false; }

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (txtRepetir.Text == txtPass.Text)

                btnCambiar.Enabled = true;

            else btnCambiar.Enabled = false;
        }

        public bool ValidarPassword(string password)
        {

            for (int i = 0; i < password.Length; i++)
            {
                if (Char.IsUpper(password[i]))
                {
                    ckbMayuscula.Checked = true;

                }
                else if (char.IsLower(password[i]))
                {
                    ckbMinuscula.Checked = true;
                }
                else if (char.IsDigit(password[i]))
                {
                    ckbNumero.Checked = true;
                }
                else if (password.Length >= 8)
                {
                    ckbMinimo.Checked = true;
                }
                else if (char.IsSymbol(password[i]) || char.IsSeparator(password[i]) || char.IsPunctuation(password[i]))
                {
                    ckbEspecial.Checked = true;
                }
            }

            if (ckbMayuscula.Checked && ckbMinuscula.Checked && ckbNumero.Checked && ckbEspecial.Checked && ckbMinimo.Checked)
            {
                return true;

            }
            else return false;
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            FrmLogin1 log = new FrmLogin1();
            string usuario = CS_Usuario.Username;
            //pass es la contraseña vieja generada
            string aleatorio = txtPasswordAnterior.Text + usuario;
            string hasheoaleatorio = Seguridad.SHA256(aleatorio);
            //string pass = CS_Usuario.password;
            string newpass = txtPass.Text;
            string concatenados = usuario + newpass;
            string jasheo = Seguridad.SHA256(concatenados);

            try
            {
                if (/*hasheoaleatorio == pass*/ contraseña == CS_Usuario.password)
                {
                    if (ValidarPassword(newpass) == true)//&& newpass==txtRepetir.Text) esto es una validacion extra de txtRepetir
                    {
                        if (newpass == txtRepetir.Text)
                        {
                            cn_usuario.EditarPassword(jasheo, usuario);
                            lblError.Text = "La contraseña se ha cambiado con exito.";
<<<<<<< HEAD
<<<<<<< Updated upstream
                            this.Dispose();
=======
>>>>>>> Stashed changes
                            log.ShowDialog();
                            this.Dispose();
                            
=======
                            log.ShowDialog();
                            this.Dispose();

>>>>>>> d8c6b8bcf5034cb5e6d38c90e56245adc0d5da0c
                        }
                        else
                        {
                            lblError.Text = "Las nuevas contraseñas no coinciden.Reingrese las contraseñas.";
                            txtPass.Focus();
                        }
                    }
                    else
                    {
                        lblError.Text = "Todavia no cumple con los requisitos de seguridad";
                    }
                }
                else
                {
                    lblError.Text = "La contraseña anterior no es la correcta";
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar " + ex.Message);
            }
        }

        private void ckbMinimo_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
