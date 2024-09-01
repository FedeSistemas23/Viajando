using CapaNegocio;
using CapaSesion;
using interfazPpal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaServicios;


namespace interfazLogin
{
    public partial class FrmPrimerIngreso : Form
    {
        
        CN_TrarPreguntasAleatorios usuario = new CN_TrarPreguntasAleatorios();
        string[] preguntas;
        CN_GuardaRespuestas guardarrespuestas = new CN_GuardaRespuestas();
        CN_GuardarPrimerIngreso primerIngreso = new CN_GuardarPrimerIngreso();
        
     
        public FrmPrimerIngreso()
        {
            InitializeComponent();
        }

        private void PrimerIngreso_Load(object sender, EventArgs e)
        {
            //btnEnviar.Enabled = false;          
            FrmEditarPassword cambioContraseña = new FrmEditarPassword();  
            preguntas = usuario.PreguntasAleatoriasL();
            for (int i = 0; i < 1; i++)
            {
                lblPregunta1.Text = preguntas[0];
                lblPregunta2.Text = preguntas[1];
                lblPregunta3.Text = preguntas[2];               
            }
            
        }
        public void Txtvacios(string txtRespuesta1, string txtRespuesta2, string txtRespuesta3)
        {
            if (txtRespuesta1 != "" & txtRespuesta2 != "" & txtRespuesta3!="")
            {
                btnEnviar.Enabled = true;
            }
            else
            {
               btnEnviar.Enabled = false;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmLogin1 frm = new FrmLogin1();
            frm.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void txtRespuesta1_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void btnEnviar_Click_1(object sender, EventArgs e)
        {
            CS_GuardaPreguntasRespuestas.respuesta1 = txtRespuesta1.Text;
            CS_GuardaPreguntasRespuestas.respuesta2= txtRespuesta2.Text;
            CS_GuardaPreguntasRespuestas.respuesta3 = txtRespuesta3.Text;
            FrmEditarPassword cambioContraseña = new FrmEditarPassword();
            guardarrespuestas.GuardarRespuestas();
            primerIngreso.GuardarPrimerIngreso();
            this.Close();
            cambioContraseña.Show();
        }
        
        

        private void lblError2_Click(object sender, EventArgs e)
        {
            
        }

        private void txtRespuesta3_TextChanged(object sender, EventArgs e)
        {
            Txtvacios (txtRespuesta1.Text, txtRespuesta2.Text, txtRespuesta3.Text);
        }
    }
}
