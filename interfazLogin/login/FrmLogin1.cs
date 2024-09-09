using CapaNegocio;
using CapaServicios;
using CapaSesion;
using interfazLogin.Presentacion;
using interfazPpal;
using Loggin;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace interfazLogin
{
    public partial class FrmLogin1 : Form
    {
        MenuPpal menu1 = new MenuPpal();
        CN_GuardaRespuestas guardaRespuestas = new CN_GuardaRespuestas();
        CN_ValidarUsuario validarusuario = new CN_ValidarUsuario();
        CN_Usuario usuario = new CN_Usuario();
        public FrmLogin1()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Ej.: ejemplo@gmail.com")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.White;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Ej.: ejemplo@gmail.com";
                txtUsuario.ForeColor = Color.Silver;
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "Contraseña")
            {
                txtPass.Text = "";
                txtPass.ForeColor = Color.Silver;
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "Contraseña";
                txtPass.ForeColor = Color.Silver;
                txtPass.UseSystemPasswordChar = false;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        /*      
         Validar que las letras sean minusculas
        // no esta discriminando de mayusculas y minusculas         
         */
        interfazPpal.Menu menu = new interfazPpal.Menu();
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            FrmPreguntasSeguridad frm1 = new FrmPreguntasSeguridad();
            FrmEditarPassword editar = new FrmEditarPassword();
            FrmPrimerIngreso frmPrimerIngreso = new FrmPrimerIngreso();
            CN_registrarIntentosFallidos intentosFallidos = new CN_registrarIntentosFallidos();

            string username = txtUsuario.Text;
            string password = txtPass.Text;
            string userpass = username + password;
            string hasheo2 = Seguridad.SHA256(userpass);
            int digito = CreaDigitoVerificador.Calcular(hasheo2);
            btnIngresar.Enabled = true; ;

            if (txtUsuario.Text != "Ej.: ejemplo@gmail.com")
            {
                if (txtPass.Text != "Contraseña")
                {
                    bool userexist = validarusuario.ValidarUsuarioL(username);
                    if (userexist)
                    {
                        if (hasheo2 == CS_Usuario.password)/* digito== CS_usuario.digito*/
                        {
                            if (CS_Usuario.intentos < 3)
                            {

                                int dias = CS_VencimientoPassword.CalcularDiasRestantes(CS_Usuario.fechaUltimoCambio, CS_Usuario.venceCada);
                                if (dias < 10)
                                {
                                    DialogResult resultado = MessageBox.Show("Su contraseña esta por vencer en " + " " + dias + " " + "dias. " + " " + "Desea cambiarla ahora?", "Contraseña por Vencer", MessageBoxButtons.OKCancel);

                                    if (resultado == DialogResult.OK)
                                    {

                                        FrmPreguntasSeguridad frm = new FrmPreguntasSeguridad();
                                        frm.ShowDialog();
                                    }
                                }
                                if (CS_Usuario.fechaPrimerIngreso == DateTime.Now || CS_Usuario.fechaPrimerIngreso == null)
                                {
                                    frmPrimerIngreso.Show();
                                    this.Hide();

                                }
                                else //if (hasheo2 == password)                                                                      
                                {
                                    this.Hide();
                                    bienvenida saludo = new bienvenida();
                                    saludo.ShowDialog();
                                    menu1.Show();
                                }
                                ;

                            }
                            else
                            {
                                //btnIngresar.Enabled = false;
                                MessageBox.Show("Usuario Bloqueado \n Comuniquese con el administrador");
                                txtPass.Clear();
                                txtUsuario.Clear();
                            }
                        }
                        else
                        {
                            MessageBox.Show("La contraseña es incorrecta. Intente de nuevo:");
                            intentosFallidos.registraIntentofallido(txtUsuario.Text);
                            MessageBox.Show("Intentos fallidos:  " + intentosFallidos);
                            txtPass.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("EL usuario no existe");
                        txtUsuario.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Debe ingresae una contraseña");
                    txtPass.Focus();
                }
            }
            else
            {
                MessageBox.Show("debe ingresar un Usuario");
                txtUsuario.Focus();
            }



        }

        private void txtPass_TextChanged_1(object sender, EventArgs e)
        {
            btnIngresar.Enabled = true;
        }

        private void lnkOlvidar_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmPreguntasSeguridad preguntas = new FrmPreguntasSeguridad();
            this.Hide();
            preguntas.Show();

        }

        private void FrmLogin1_Load(object sender, EventArgs e)
        {

        }
    }
}
