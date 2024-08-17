namespace interfazLogin
{
    partial class FrmPrimerIngreso
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.lblError2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panelCambioPass = new System.Windows.Forms.Panel();
            this.txtConfirmPass = new System.Windows.Forms.TextBox();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.txtRespuesta1 = new System.Windows.Forms.TextBox();
            this.lblPregunta3 = new System.Windows.Forms.Label();
            this.lblPregunta2 = new System.Windows.Forms.Label();
            this.lblPregunta1 = new System.Windows.Forms.Label();
            this.lblrecordarRespuestas = new System.Windows.Forms.Label();
            this.lblcontestarPreguntas = new System.Windows.Forms.Label();
            this.txtRespuesta2 = new System.Windows.Forms.TextBox();
            this.txtRespuesta3 = new System.Windows.Forms.TextBox();
            this.lblprimerIngreso = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            this.panelCambioPass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.ErrorImage = null;
            this.btnCerrar.Image = global::interfazLogin.Properties.Resources.cerrar;
            this.btnCerrar.Location = new System.Drawing.Point(921, 15);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(24, 22);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 59;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Image = global::interfazLogin.Properties.Resources.minimazar;
            this.btnMinimizar.Location = new System.Drawing.Point(884, 15);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(24, 22);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 58;
            this.btnMinimizar.TabStop = false;
            // 
            // lblError2
            // 
            this.lblError2.AutoSize = true;
            this.lblError2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblError2.Location = new System.Drawing.Point(39, 432);
            this.lblError2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError2.Name = "lblError2";
            this.lblError2.Size = new System.Drawing.Size(79, 23);
            this.lblError2.TabIndex = 74;
            this.lblError2.Text = "Error2 !!";
            this.lblError2.Click += new System.EventHandler(this.lblError2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(48, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 23);
            this.label3.TabIndex = 20;
            this.label3.Text = "Contraseña nueva";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(43, 169);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(417, 23);
            this.label5.TabIndex = 78;
            this.label5.Text = "Deberá indicarlas si olvida su contraseña.";
            // 
            // panelCambioPass
            // 
            this.panelCambioPass.Controls.Add(this.txtConfirmPass);
            this.panelCambioPass.Controls.Add(this.txtNewPass);
            this.panelCambioPass.Controls.Add(this.label3);
            this.panelCambioPass.Controls.Add(this.label2);
            this.panelCambioPass.Location = new System.Drawing.Point(-8, 498);
            this.panelCambioPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelCambioPass.Name = "panelCambioPass";
            this.panelCambioPass.Size = new System.Drawing.Size(599, 153);
            this.panelCambioPass.TabIndex = 76;
            this.panelCambioPass.Visible = false;
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirmPass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPass.Location = new System.Drawing.Point(52, 108);
            this.txtConfirmPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.Size = new System.Drawing.Size(499, 25);
            this.txtConfirmPass.TabIndex = 23;
            // 
            // txtNewPass
            // 
            this.txtNewPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNewPass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPass.Location = new System.Drawing.Point(53, 48);
            this.txtNewPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(497, 25);
            this.txtNewPass.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(51, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 23);
            this.label2.TabIndex = 21;
            this.label2.Text = "Confirmar Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(41, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 31);
            this.label1.TabIndex = 75;
            this.label1.Text = "Bienvenido ...!!";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblError.Location = new System.Drawing.Point(40, 469);
            this.lblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(72, 23);
            this.lblError.TabIndex = 73;
            this.lblError.Text = "Error..!!";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(48, 668);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(243, 58);
            this.button1.TabIndex = 72;
            this.button1.Text = "CANCELAR";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEnviar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEnviar.Location = new System.Drawing.Point(324, 673);
            this.btnEnviar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(244, 48);
            this.btnEnviar.TabIndex = 71;
            this.btnEnviar.Text = "ENVIAR";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click_1);
            // 
            // txtRespuesta1
            // 
            this.txtRespuesta1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRespuesta1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRespuesta1.Location = new System.Drawing.Point(40, 254);
            this.txtRespuesta1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRespuesta1.Name = "txtRespuesta1";
            this.txtRespuesta1.Size = new System.Drawing.Size(509, 25);
            this.txtRespuesta1.TabIndex = 68;
            this.txtRespuesta1.TextChanged += new System.EventHandler(this.txtRespuesta1_TextChanged_1);
            // 
            // lblPregunta3
            // 
            this.lblPregunta3.AutoSize = true;
            this.lblPregunta3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPregunta3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPregunta3.Location = new System.Drawing.Point(39, 357);
            this.lblPregunta3.Name = "lblPregunta3";
            this.lblPregunta3.Size = new System.Drawing.Size(110, 23);
            this.lblPregunta3.TabIndex = 67;
            this.lblPregunta3.Text = "Pregunta3";
            // 
            // lblPregunta2
            // 
            this.lblPregunta2.AutoSize = true;
            this.lblPregunta2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPregunta2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPregunta2.Location = new System.Drawing.Point(40, 289);
            this.lblPregunta2.Name = "lblPregunta2";
            this.lblPregunta2.Size = new System.Drawing.Size(110, 23);
            this.lblPregunta2.TabIndex = 66;
            this.lblPregunta2.Text = "Pregunta2";
            // 
            // lblPregunta1
            // 
            this.lblPregunta1.AutoSize = true;
            this.lblPregunta1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPregunta1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPregunta1.Location = new System.Drawing.Point(41, 223);
            this.lblPregunta1.Name = "lblPregunta1";
            this.lblPregunta1.Size = new System.Drawing.Size(110, 23);
            this.lblPregunta1.TabIndex = 65;
            this.lblPregunta1.Text = "Pregunta1";
            // 
            // lblrecordarRespuestas
            // 
            this.lblrecordarRespuestas.AutoSize = true;
            this.lblrecordarRespuestas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrecordarRespuestas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblrecordarRespuestas.Location = new System.Drawing.Point(41, 138);
            this.lblrecordarRespuestas.Name = "lblrecordarRespuestas";
            this.lblrecordarRespuestas.Size = new System.Drawing.Size(227, 25);
            this.lblrecordarRespuestas.TabIndex = 64;
            this.lblrecordarRespuestas.Text = "Recuerde las respuestas";
            // 
            // lblcontestarPreguntas
            // 
            this.lblcontestarPreguntas.AutoSize = true;
            this.lblcontestarPreguntas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcontestarPreguntas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblcontestarPreguntas.Location = new System.Drawing.Point(33, 107);
            this.lblcontestarPreguntas.Name = "lblcontestarPreguntas";
            this.lblcontestarPreguntas.Size = new System.Drawing.Size(479, 25);
            this.lblcontestarPreguntas.TabIndex = 63;
            this.lblcontestarPreguntas.Text = " Conteste las 3 preguntas de seguridad y pulse Enviar";
            // 
            // txtRespuesta2
            // 
            this.txtRespuesta2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRespuesta2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRespuesta2.Location = new System.Drawing.Point(40, 321);
            this.txtRespuesta2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRespuesta2.Name = "txtRespuesta2";
            this.txtRespuesta2.Size = new System.Drawing.Size(509, 25);
            this.txtRespuesta2.TabIndex = 69;
            // 
            // txtRespuesta3
            // 
            this.txtRespuesta3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRespuesta3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRespuesta3.Location = new System.Drawing.Point(40, 384);
            this.txtRespuesta3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRespuesta3.Name = "txtRespuesta3";
            this.txtRespuesta3.Size = new System.Drawing.Size(508, 25);
            this.txtRespuesta3.TabIndex = 70;
            this.txtRespuesta3.TextChanged += new System.EventHandler(this.txtRespuesta3_TextChanged);
            // 
            // lblprimerIngreso
            // 
            this.lblprimerIngreso.AutoSize = true;
            this.lblprimerIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprimerIngreso.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblprimerIngreso.Location = new System.Drawing.Point(41, 76);
            this.lblprimerIngreso.Name = "lblprimerIngreso";
            this.lblprimerIngreso.Size = new System.Drawing.Size(446, 25);
            this.lblprimerIngreso.TabIndex = 62;
            this.lblprimerIngreso.Text = "Es su primer Ingreso, debe cambiar su contraseña";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::interfazLogin.Properties.Resources.cerrar;
            this.pictureBox1.Location = new System.Drawing.Point(600, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 80;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::interfazLogin.Properties.Resources.minimazar;
            this.pictureBox2.Location = new System.Drawing.Point(563, 15);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 79;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // PrimerIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(640, 736);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblError2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panelCambioPass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtRespuesta1);
            this.Controls.Add(this.lblPregunta3);
            this.Controls.Add(this.lblPregunta2);
            this.Controls.Add(this.lblPregunta1);
            this.Controls.Add(this.lblrecordarRespuestas);
            this.Controls.Add(this.lblcontestarPreguntas);
            this.Controls.Add(this.txtRespuesta2);
            this.Controls.Add(this.txtRespuesta3);
            this.Controls.Add(this.lblprimerIngreso);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnMinimizar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PrimerIngreso";
            this.Opacity = 0.9D;
            this.Text = "PrimerIngreso";
            this.Load += new System.EventHandler(this.PrimerIngreso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            this.panelCambioPass.ResumeLayout(false);
            this.panelCambioPass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.Label lblError2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelCambioPass;
        private System.Windows.Forms.TextBox txtConfirmPass;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.TextBox txtRespuesta1;
        private System.Windows.Forms.Label lblPregunta3;
        private System.Windows.Forms.Label lblPregunta2;
        private System.Windows.Forms.Label lblPregunta1;
        private System.Windows.Forms.Label lblrecordarRespuestas;
        private System.Windows.Forms.Label lblcontestarPreguntas;
        private System.Windows.Forms.TextBox txtRespuesta2;
        private System.Windows.Forms.TextBox txtRespuesta3;
        private System.Windows.Forms.Label lblprimerIngreso;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}