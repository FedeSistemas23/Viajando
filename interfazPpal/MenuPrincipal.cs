using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using CapaSesion;





namespace interfazPpal
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void button1_Click(object sender, EventArgs e)
        {

        }

        Panel p = new Panel();

        private void btnMouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            panelLateral.Controls.Add(p);
            p.BackColor = Color.FromArgb(0, 121, 255);
            p.Size = new Size(120, 5);
            p.Location = new Point(btn.Location.X, btn.Location.Y + 32);
        }

        private void btnMouseLeave(object sender, EventArgs e)
        {
            
            //panel2.Controls.Remove(p);

            //if(panel2.Visible)
              //  panel2.Visible = false;
        }

        private void btnMouseLeaveConfig(object sender, EventArgs e)
        {
            
            panelConfiguracion.Controls.Remove(p);

            if (panelConfiguracion.Visible)
                panelConfiguracion.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Esta seguro que quiere cerrar la aplicación?", "warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            Application.Exit();
        }

        private void btnMaxi_Click(object sender, EventArgs e)
        {

            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                btnRest.Visible = true;
            }
        }

        private void btnRest_Click(object sender, EventArgs e)
        {
            //else btnRest.Visible = false;   
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelLateral_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

            if (MessageBox.Show("¿Esta seguro que quiere cerrar sesión?", "warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();

                
            
        }



        private void btnPagos_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void btnPagos_MouseLeave(object sender, EventArgs e)
        {
            
        }
        private void btnReportes_MouseHover(object sender, EventArgs e)
        {
           
        }

       

        private void btnReservas_MouseHover_1(object sender, EventArgs e)
        {
           

        }
        private void btnReservas_MouseLeave(object sender, EventArgs e)
        {
        }

        private void btnProveedores_MouseHover_1(object sender, EventArgs e)
        {
           

        }
        private void btnProveedores_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void btnDestinos_MouseHover_1(object sender, EventArgs e)
        {
           

        }
        private void btnVentas_MouseLeave(object sender, EventArgs e)
        {
        }  

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarDatosUsuario();
            timer2.Enabled = true;
        }

        private void CargarDatosUsuario()
        {
           // lblNombre.Text = CS_Usuario.nombreUsuario;
            lblRol.Text = CS_Usuario.familia;
            
        }

        private void panelLateral_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {

        }

        private void panelVertical_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblDuracion_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void tetxGastosAdmin_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;

                 btnMaxi.Enabled = true;
                 btnRest.Visible = false;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss");
            lblFeActual.Text = DateTime.Now.ToLongDateString();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {

            // Esta instruccion if, indica que al apretar el btnUsuarios se muestren los tres botones del submenu Usuarios

            // IMPLEMENTARLA !!!

         // if (!panel2.Visible)
           //     panel2.Visible = true;
            //else
              //  panel2.Visible = false;


            //Usuario frmUsuario= new Usuario();
            /*contendedor.Dock= DockStyle.Fill;
            frm.ShowDialog();
            this.Close();*/


            //AbrirFormDestinos(frmUsuario);
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnDestinos_Click(object sender, EventArgs e)
        {
           

            AbrirFormDestinos(new GestionAdministratioContable());

        }

        private void AbrirFormDestinos(object formDestinos)
        {
            if (this.contendedor.Controls.Count > 0)
                this.contendedor.Controls.RemoveAt(0);
            Form frm = formDestinos as Form;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;  
            this.contendedor.Controls.Add(frm);
            this.contendedor.Tag = frm;
            frm.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnReservas_Click(object sender, EventArgs e)
        {
            GestionDeReservas frm = new GestionDeReservas();
            AbrirFormDestinos(frm);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!panelConfiguracion.Visible)
                panelConfiguracion.Visible = true;
            else
                panelConfiguracion.Visible = false; 
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {

        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {


        }

        Panel btnConfig = new Panel();
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!panelReportes.Visible)
                panelReportes.Visible = true;
            else
                panelReportes.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Esta instruccion if, indica que al apretar el btnUsuarios se muestren los tres botones del submenu Usuarios

            // IMPLEMENTARLA !!!

            /* if (!panel2.Visible)
                 panel2.Visible = true;
             else
                 panel2.Visible = false;*/


            Usuario frmUsuario = new Usuario();
            /*contendedor.Dock= DockStyle.Fill;
            frm.ShowDialog();
            this.Close();*/


            AbrirFormDestinos(frmUsuario);
        }

        private void btnCinfig_MouseHover(object sender, EventArgs e)
        {/*
            if (!panelConfiguracion.Visible)
                panelConfiguracion.Visible = true;
            else
                panelConfiguracion.Visible = false;
            */
        }

        private void btnCinfig_Click(object sender, EventArgs e)
        {
            if (!panelConfiguracion.Visible)
                panelConfiguracion.Visible = true;
            else
                panelConfiguracion.Visible = false;
        }

        private void btnUsuarios_MouseHover(object sender, EventArgs e)
        {
           // if(!panel2.Visible)
                //panel2.Visible = true;
        }
    }
}
