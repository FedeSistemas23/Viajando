using interfazPpal;
using System;
using System.Windows.Forms;

namespace Loggin
{
    public partial class MenuPpal : Form
    {
        public MenuPpal()
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
            Alta_de_Usuarios form = new Alta_de_Usuarios();
            // form.Show();
            AbrirFormuEnPanelMenu(form);

            //Alta_de_Usuarios frm = new Alta_de_Usuarios();
            //nuContenedor.Show();
        }

        private void preguntasSeguridadToolStripMenuItem_Click(object sender, EventArgs e)
        {



        }

        private void menuContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void editarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmIngresarEditarReseerva frm = new FrmIngresarEditarReseerva();
            AbrirFormuEnPanelMenu(frm);
        }

        private void crearNuevaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarReserva frm = new BuscarReserva();
            AbrirFormuEnPanelMenu(frm);


        }

        private void crearNuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmIngresarEditarPaquete frm = new FrmIngresarEditarPaquete();
            AbrirFormuEnPanelMenu(frm);
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void resultadosComercialesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pagoAVendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPagoVendedor pagoVendedor = new FrmPagoVendedor();
            pagoVendedor.Show();
        }

        private void darDeBajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmIngresarEditarVendedor vendedor = new FrmIngresarEditarVendedor();
            vendedor.Show();
        }

        private void ingresarEditarPagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPagoRecibidos pagoRecibidos = new FrmPagoRecibidos(1, 1);
            pagoRecibidos.Show();
        }

        private void eliminarPagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPagoRecibidos pagoRecibidos = new FrmPagoRecibidos(1, 1);
            pagoRecibidos.Show();
        }

        private void buscarPagoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ingresarEditarPagoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmPagoProveedores pagoProveedores = new FrmPagoProveedores(0);
            pagoProveedores.Show();
        }

        private void eliminarPagoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmPagoProveedores pagoProveedores = new FrmPagoProveedores(0, 1);
            pagoProveedores.Show();
        }

        private void pagosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmPagoRecibidos pagoRecibidos = new FrmPagoRecibidos(1, 1);
            pagoRecibidos.Show();
        }

        private void darDeBajaCoordinadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmIngresarEditarCoordinador coordinador = new FrmIngresarEditarCoordinador(0);
            coordinador.Show();
        }

        private void nuevoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmIngresarEditarVendedor vendedor = new FrmIngresarEditarVendedor(0);
            vendedor.Show();
        }

        private void ingresarEditarCoordinadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmIngresarEditarCoordinador cordinador = new FrmIngresarEditarCoordinador();
            cordinador.Show();
        }

        private void hotelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmIngresarEditarProveedor proveedor = new FrmIngresarEditarProveedor(0);
            proveedor.Show();
        }

        private void busesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmIngresarEditarProveedor proveedor = new FrmIngresarEditarProveedor(0, 1);
            proveedor.Show();
        }

        private void editarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmIngresarEditarProveedor proveedor = new FrmIngresarEditarProveedor();
            proveedor.Show();
        }

        private void paquetesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmBuscarPaquete paquete = new FrmBuscarPaquete();
            paquete.FormBorderStyle = FormBorderStyle.None;
            AbrirFormuEnPanelMenu(paquete);
        }

        private void reservasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmBuscarReserva reserva = new FrmBuscarReserva();
            reserva.Show();
        }

        private void vendedoresToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmBuscarVendedor vendedor = new FrmBuscarVendedor();
            vendedor.Show();
        }

        private void coordinadoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmBuscarCoordinador coordinador = new FrmBuscarCoordinador();
            coordinador.Show();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void deHotelesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void usuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

<<<<<<< HEAD
        private void ingresarEditarPasajeroToolStripMenuItem_Click(object sender, EventArgs e)
        {

=======
        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Application.Exit();

>>>>>>> 99cambios
        }
    }
}
