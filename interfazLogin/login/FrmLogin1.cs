using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using CapaNegocio;
using CapaServicios;
using interfazLogin.Presentacion;
using interfazPpal;
using CapaSesion;
using System.Diagnostics.Eventing.Reader;
using interfazLogin;
using Loggin;

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
            string username = txtUsuario.Text;
            string password = txtPass.Text;
            string userpass = username + password;
            string hasheo2 = Seguridad.SHA256(userpass);
            int digito = CreaDigitoVerificador.Calcular(hasheo2);
            interfazPpal.Menu menu = new interfazPpal.Menu();
            
            if (txtUsuario.Text != "Ej.: ejemplo@gmail.com")
            {
                if (txtPass.Text != "Contraseña")
                {
                    bool userexist = validarusuario.ValidarUsuarioL(username);
                    if (userexist)
                    {
                        if (hasheo2 == CS_Usuario.password/*&& digito== CS_usuario.digito*/)
                        {
                            if (CS_Usuario.fechaPrimerIngreso == DateTime.Now)
                            {
                                this.Hide();
                                frmPrimerIngreso.Show();
                            }
                            else //if (hasheo2 == password)                                                                      
                            {
                                this.Hide();
                                bienvenida saludo = new bienvenida();
                                saludo.ShowDialog();
                                menu1.Show();
                            }
                        }
                        //else if (frm1.aleatorio == txtPass.Text)
                        /*{
                            MessageBox.Show("La contraseña es incorrecta. Ingrese de nuevo la contraseña:");
                            txtPass.Focus();
                            int intentos = CS_Usuario.intentos++;
                            CS_Usuario.intentos = intentos;
                            if (CS_Usuario.intentos == 3)
                            {
                                MessageBox.Show("El usuario ha sido bloqueado");
                            }
                        }*/
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
    }
}
