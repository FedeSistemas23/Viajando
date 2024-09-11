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

namespace interfazLogin
{
    public partial class FrmLogin1 : Form
    {
<<<<<<< Updated upstream
        CN_GuardaRespuestas guardaRespuestas = new CN_GuardaRespuestas();        
=======
        MenuPpal menu1 = new MenuPpal();
        CN_GuardaRespuestas guardaRespuestas = new CN_GuardaRespuestas();
>>>>>>> Stashed changes
        CN_ValidarUsuario validarusuario = new CN_ValidarUsuario();
        CN_UsuarioEnSesion usuario = new CN_UsuarioEnSesion();
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
        interfazPpal.MenuPrincipal menu = new interfazPpal.MenuPrincipal();

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
<<<<<<< Updated upstream
            MenuPrincipal menu = new MenuPrincipal();
=======
            int digito = CreaDigitoVerificador.Calcular(hasheo2);
            btnIngresar.Enabled = true; ;

            // interfazPpal.Menu menu = new interfazPpal.Menu();

            Console.WriteLine("Contraseña de  " + username + " " + hasheo2);

>>>>>>> Stashed changes
            if (txtUsuario.Text != "Ej.: ejemplo@gmail.com")
            {
                if (txtPass.Text != "Contraseña")
                {
                    bool userexist = validarusuario.ValidarUsuarioL(username);

                    
                   
                    if (userexist)
                    {
<<<<<<< Updated upstream
                        if (hasheo2 == CS_Usuario.password)
=======
                        if (hasheo2 == CS_Usuario.password)/* digito== CS_usuario.digito*/
>>>>>>> Stashed changes
                        {
                            Console.WriteLine("Mensaje desde frm_login linea- 125 : intentos fallidos de" + username + " " + CS_Usuario.intentos);
                            if (CS_Usuario.intentos < 3)
                            {
                                Console.WriteLine("MENSAJE DESDE FORM-LOGIN L128 : Fecha Ultimi cambio " + CS_Usuario.fechaUltimoCambio);
                                Console.WriteLine("MENSAJE DESDE FORM-LOGIN L129 : VECE CADA " + CS_Usuario.venceCada);
                                int dias = CS_VencimientoPassword.CalcularDiasRestantes(CS_Usuario.fechaUltimoCambio, CS_Usuario.venceCada);
                                if (dias < 10)
                                {
                                    DialogResult resultado = MessageBox.Show("Su contraseña esta por vencer en " + " " +dias +" "+ "dias. " + " " + "Desea cambiarla ahora?", "Contraseña por Vencer", MessageBoxButtons.OKCancel);

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
                                Console.WriteLine("Mensaje de FormLogin Linea 136 : La cantidad de intentos fallidos es menor a 3");
                                Console.WriteLine();
                                Console.WriteLine("Mensaje de FormLogin Linea 138 : fecha de primer ingreso =  " + CS_Usuario.fechaPrimerIngreso);

                            }
<<<<<<< Updated upstream
                            else //if (hasheo2 == password)                                                                      
                            {
                                this.Hide();
                                bienvenida saludo = new bienvenida();
                                saludo.ShowDialog();
                                menu.Show();
                            }
                        }
                        //else if (frm1.aleatorio == txtPass.Text)
                        {
                            MessageBox.Show("La contraseña es incorrecta. Ingrese de nuevo la contraseña:");
                            txtPass.Focus();
                            int intentos = CS_Usuario.intentos++;
                            CS_Usuario.intentos = intentos;
                            if (CS_Usuario.intentos == 3)
                            {
                                MessageBox.Show("El usuario ha sido bloqueado");
                            }
=======
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
>>>>>>> Stashed changes
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
    


    /*
        int intentos = CS_Usuario.intentos++;
        CS_Usuario.intentos = intentos;
        if (CS_Usuario.intentos == 3)
        {
            MessageBox.Show("El usuario ha sido bloqueado");
        }
    }*/

        
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
