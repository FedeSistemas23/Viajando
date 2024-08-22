namespace interfazPpal
{
    partial class FrmEditarPassword
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCambiar = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtRepetir = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ckbMinimo = new System.Windows.Forms.CheckBox();
            this.ckbMinuscula = new System.Windows.Forms.CheckBox();
            this.ckbMayuscula = new System.Windows.Forms.CheckBox();
            this.ckbNumero = new System.Windows.Forms.CheckBox();
            this.ckbEspecial = new System.Windows.Forms.CheckBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblError = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.txtPasswordAnterior = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(298, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(423, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cambio Contraseña";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(175, 143);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(371, 60);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese su contraseña anterior\r\n/aleatoria";
            // 
            // btnCambiar
            // 
            this.btnCambiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnCambiar.Enabled = false;
            this.btnCambiar.FlatAppearance.BorderSize = 0;
            this.btnCambiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnCambiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCambiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiar.ForeColor = System.Drawing.Color.White;
            this.btnCambiar.Location = new System.Drawing.Point(176, 725);
            this.btnCambiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.Size = new System.Drawing.Size(545, 49);
            this.btnCambiar.TabIndex = 26;
            this.btnCambiar.Text = "Cambiar";
            this.btnCambiar.UseVisualStyleBackColor = false;
            this.btnCambiar.Click += new System.EventHandler(this.btnCambiar_Click);
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.SystemColors.Control;
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPass.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.ForeColor = System.Drawing.Color.Black;
            this.txtPass.Location = new System.Drawing.Point(176, 276);
            this.txtPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(545, 30);
            this.txtPass.TabIndex = 27;
            this.txtPass.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtRepetir
            // 
            this.txtRepetir.BackColor = System.Drawing.SystemColors.Control;
            this.txtRepetir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRepetir.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRepetir.ForeColor = System.Drawing.Color.Black;
            this.txtRepetir.Location = new System.Drawing.Point(176, 357);
            this.txtRepetir.Margin = new System.Windows.Forms.Padding(4);
            this.txtRepetir.Name = "txtRepetir";
            this.txtRepetir.Size = new System.Drawing.Size(545, 30);
            this.txtRepetir.TabIndex = 28;
            this.txtRepetir.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(169, 322);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(348, 30);
            this.label3.TabIndex = 29;
            this.label3.Text = "Repita su nueva contraseña";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(173, 242);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(396, 30);
            this.label4.TabIndex = 30;
            this.label4.Text = "Introduzca su nueva contraseña";
            // 
            // ckbMinimo
            // 
            this.ckbMinimo.AutoSize = true;
            this.ckbMinimo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbMinimo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ckbMinimo.Location = new System.Drawing.Point(180, 402);
            this.ckbMinimo.Margin = new System.Windows.Forms.Padding(4);
            this.ckbMinimo.Name = "ckbMinimo";
            this.ckbMinimo.Size = new System.Drawing.Size(231, 27);
            this.ckbMinimo.TabIndex = 31;
            this.ckbMinimo.Text = "Mínimo 8 caracteres";
            this.ckbMinimo.UseVisualStyleBackColor = true;
            // 
            // ckbMinuscula
            // 
            this.ckbMinuscula.AutoSize = true;
            this.ckbMinuscula.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbMinuscula.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ckbMinuscula.Location = new System.Drawing.Point(180, 442);
            this.ckbMinuscula.Margin = new System.Windows.Forms.Padding(4);
            this.ckbMinuscula.Name = "ckbMinuscula";
            this.ckbMinuscula.Size = new System.Drawing.Size(322, 27);
            this.ckbMinuscula.TabIndex = 32;
            this.ckbMinuscula.Text = "Al menos una letra minúscula";
            this.ckbMinuscula.UseVisualStyleBackColor = true;
            // 
            // ckbMayuscula
            // 
            this.ckbMayuscula.AutoSize = true;
            this.ckbMayuscula.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbMayuscula.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ckbMayuscula.Location = new System.Drawing.Point(180, 481);
            this.ckbMayuscula.Margin = new System.Windows.Forms.Padding(4);
            this.ckbMayuscula.Name = "ckbMayuscula";
            this.ckbMayuscula.Size = new System.Drawing.Size(332, 27);
            this.ckbMayuscula.TabIndex = 33;
            this.ckbMayuscula.Text = "Al menos una letra mayúscula";
            this.ckbMayuscula.UseVisualStyleBackColor = true;
            // 
            // ckbNumero
            // 
            this.ckbNumero.AutoSize = true;
            this.ckbNumero.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbNumero.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ckbNumero.Location = new System.Drawing.Point(180, 521);
            this.ckbNumero.Margin = new System.Windows.Forms.Padding(4);
            this.ckbNumero.Name = "ckbNumero";
            this.ckbNumero.Size = new System.Drawing.Size(234, 27);
            this.ckbNumero.TabIndex = 34;
            this.ckbNumero.Text = "Al menos un número";
            this.ckbNumero.UseVisualStyleBackColor = true;
            // 
            // ckbEspecial
            // 
            this.ckbEspecial.AutoSize = true;
            this.ckbEspecial.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbEspecial.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ckbEspecial.Location = new System.Drawing.Point(180, 561);
            this.ckbEspecial.Margin = new System.Windows.Forms.Padding(4);
            this.ckbEspecial.Name = "ckbEspecial";
            this.ckbEspecial.Size = new System.Drawing.Size(334, 27);
            this.ckbEspecial.TabIndex = 35;
            this.ckbEspecial.Text = "Al menos un caracter especial";
            this.ckbEspecial.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(177, 633);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 21);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 37;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblError.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblError.Location = new System.Drawing.Point(208, 633);
            this.lblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(127, 22);
            this.lblError.TabIndex = 36;
            this.lblError.Text = "Error Message";
            this.lblError.Visible = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.ErrorImage = null;
            this.btnCerrar.Location = new System.Drawing.Point(829, 15);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(24, 22);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 39;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // txtPasswordAnterior
            // 
            this.txtPasswordAnterior.BackColor = System.Drawing.SystemColors.Control;
            this.txtPasswordAnterior.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPasswordAnterior.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordAnterior.ForeColor = System.Drawing.Color.Black;
            this.txtPasswordAnterior.Location = new System.Drawing.Point(176, 201);
            this.txtPasswordAnterior.Margin = new System.Windows.Forms.Padding(4);
            this.txtPasswordAnterior.Name = "txtPasswordAnterior";
            this.txtPasswordAnterior.Size = new System.Drawing.Size(545, 30);
            this.txtPasswordAnterior.TabIndex = 25;
            this.txtPasswordAnterior.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            // 
            // FrmEditarPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(869, 837);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.ckbEspecial);
            this.Controls.Add(this.ckbNumero);
            this.Controls.Add(this.ckbMayuscula);
            this.Controls.Add(this.ckbMinuscula);
            this.Controls.Add(this.ckbMinimo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRepetir);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.btnCambiar);
            this.Controls.Add(this.txtPasswordAnterior);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmEditarPassword";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CambioPassword";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCambiar;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtRepetir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox ckbMinimo;
        private System.Windows.Forms.CheckBox ckbMinuscula;
        private System.Windows.Forms.CheckBox ckbMayuscula;
        private System.Windows.Forms.CheckBox ckbNumero;
        private System.Windows.Forms.CheckBox ckbEspecial;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.TextBox txtPasswordAnterior;
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
   

    #endregion
}
