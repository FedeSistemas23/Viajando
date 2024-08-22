using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loggin
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Name = "Sistema de reservas Viajando";
        }

        private void cancelarToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void AbrirFormuEnPanelMenu(object formHijo)
        {
            if (this.menuContenedor.Controls.Count > 0)
            
                this.menuContenedor.Controls.RemoveAt(0);
            Form form = formHijo as Form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.menuContenedor.Controls.Add(form);
            this.menuContenedor.Tag = form;
            form.Show();
        }
        private void altaUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alta_de_Usuarios formAlta = new Alta_de_Usuarios();

            AbrirFormuEnPanelMenu(formAlta);
            
            //Alta_de_Usuarios frm = new Alta_de_Usuarios();
            //nuContenedor.Show();
        }

        private void preguntasSeguridadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Preguntas_Seguridad frm = new Preguntas_Seguridad();
            AbrirFormuEnPanelMenu(frm);
            
            
        }

        private void menuContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void editarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CrearReserva frm = new CrearReserva();
            AbrirFormuEnPanelMenu(frm);
        }

        private void crearNuevaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarReserva frm = new BuscarReserva();
            AbrirFormuEnPanelMenu(frm);

            
        }

        private void crearNuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearPaquete frm = new CrearPaquete();
            AbrirFormuEnPanelMenu(frm);
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Disponibilidad frm = new Disponibilidad();
            AbrirFormuEnPanelMenu(frm);
        }

        private void resultadosComercialesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
