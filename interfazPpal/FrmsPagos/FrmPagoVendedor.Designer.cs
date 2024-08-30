namespace interfazPpal
{
    partial class FrmPagoVendedor
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
            this.btnBuscarVendedor = new System.Windows.Forms.Button();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblEnConcepto = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblFormaPago = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtEnConcepto = new System.Windows.Forms.TextBox();
            this.txtNumeroReserva = new System.Windows.Forms.TextBox();
            this.dtpFechaPago = new System.Windows.Forms.DateTimePicker();
            this.lblNumeroReserva = new System.Windows.Forms.Label();
            this.btnCargar = new System.Windows.Forms.Button();
            this.dgvReservasPagas = new System.Windows.Forms.DataGridView();
            this.chbEfectivo = new System.Windows.Forms.CheckBox();
            this.chbTransferencia = new System.Windows.Forms.CheckBox();
            this.lblMontoPagado = new System.Windows.Forms.Label();
            this.txtMontoPagado = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscarReserva = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.lblNumeroDePago = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservasPagas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscarVendedor
            // 
            this.btnBuscarVendedor.Location = new System.Drawing.Point(525, 81);
            this.btnBuscarVendedor.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarVendedor.Name = "btnBuscarVendedor";
            this.btnBuscarVendedor.Size = new System.Drawing.Size(98, 31);
            this.btnBuscarVendedor.TabIndex = 1;
            this.btnBuscarVendedor.Text = "Buscar Vendedor";
            this.btnBuscarVendedor.UseVisualStyleBackColor = true;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(27, 57);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 3;
            this.lblApellido.Text = "Apellido";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(27, 81);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 13);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "E-mail :";
            this.lblEmail.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(27, 105);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(58, 13);
            this.lblTelefono.TabIndex = 5;
            this.lblTelefono.Text = "Telefono : ";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(27, 129);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(86, 13);
            this.lblFecha.TabIndex = 6;
            this.lblFecha.Text = "Fecha de Pago :";
            // 
            // lblEnConcepto
            // 
            this.lblEnConcepto.AutoSize = true;
            this.lblEnConcepto.Location = new System.Drawing.Point(27, 185);
            this.lblEnConcepto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEnConcepto.Name = "lblEnConcepto";
            this.lblEnConcepto.Size = new System.Drawing.Size(92, 13);
            this.lblEnConcepto.TabIndex = 7;
            this.lblEnConcepto.Text = "En concepto de : ";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(186, 57);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(2);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(286, 20);
            this.txtApellido.TabIndex = 2;
            // 
            // lblFormaPago
            // 
            this.lblFormaPago.AutoSize = true;
            this.lblFormaPago.Location = new System.Drawing.Point(27, 158);
            this.lblFormaPago.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFormaPago.Name = "lblFormaPago";
            this.lblFormaPago.Size = new System.Drawing.Size(85, 13);
            this.lblFormaPago.TabIndex = 9;
            this.lblFormaPago.Text = "Forma de Pago :";
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(376, 378);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(63, 28);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(94, 378);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(56, 28);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(186, 81);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(286, 20);
            this.txtEmail.TabIndex = 3;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(186, 105);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(286, 20);
            this.txtTelefono.TabIndex = 4;
            // 
            // txtEnConcepto
            // 
            this.txtEnConcepto.Location = new System.Drawing.Point(186, 185);
            this.txtEnConcepto.Margin = new System.Windows.Forms.Padding(2);
            this.txtEnConcepto.Name = "txtEnConcepto";
            this.txtEnConcepto.Size = new System.Drawing.Size(286, 20);
            this.txtEnConcepto.TabIndex = 8;
            // 
            // txtNumeroReserva
            // 
            this.txtNumeroReserva.Location = new System.Drawing.Point(186, 209);
            this.txtNumeroReserva.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumeroReserva.Name = "txtNumeroReserva";
            this.txtNumeroReserva.Size = new System.Drawing.Size(118, 20);
            this.txtNumeroReserva.TabIndex = 9;
            // 
            // dtpFechaPago
            // 
            this.dtpFechaPago.Location = new System.Drawing.Point(186, 129);
            this.dtpFechaPago.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechaPago.Name = "dtpFechaPago";
            this.dtpFechaPago.Size = new System.Drawing.Size(271, 20);
            this.dtpFechaPago.TabIndex = 5;
            // 
            // lblNumeroReserva
            // 
            this.lblNumeroReserva.AutoSize = true;
            this.lblNumeroReserva.Location = new System.Drawing.Point(27, 209);
            this.lblNumeroReserva.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumeroReserva.Name = "lblNumeroReserva";
            this.lblNumeroReserva.Size = new System.Drawing.Size(155, 13);
            this.lblNumeroReserva.TabIndex = 18;
            this.lblNumeroReserva.Text = "Ingrese el numero de Reserva :";
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(335, 210);
            this.btnCargar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(56, 29);
            this.btnCargar.TabIndex = 10;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            // 
            // dgvReservasPagas
            // 
            this.dgvReservasPagas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservasPagas.Location = new System.Drawing.Point(30, 243);
            this.dgvReservasPagas.Margin = new System.Windows.Forms.Padding(2);
            this.dgvReservasPagas.Name = "dgvReservasPagas";
            this.dgvReservasPagas.RowHeadersWidth = 51;
            this.dgvReservasPagas.RowTemplate.Height = 24;
            this.dgvReservasPagas.Size = new System.Drawing.Size(548, 91);
            this.dgvReservasPagas.TabIndex = 12;
            // 
            // chbEfectivo
            // 
            this.chbEfectivo.AutoSize = true;
            this.chbEfectivo.Location = new System.Drawing.Point(186, 158);
            this.chbEfectivo.Margin = new System.Windows.Forms.Padding(2);
            this.chbEfectivo.Name = "chbEfectivo";
            this.chbEfectivo.Size = new System.Drawing.Size(65, 17);
            this.chbEfectivo.TabIndex = 6;
            this.chbEfectivo.Text = "Efectivo";
            this.chbEfectivo.UseVisualStyleBackColor = true;
            // 
            // chbTransferencia
            // 
            this.chbTransferencia.AutoSize = true;
            this.chbTransferencia.Location = new System.Drawing.Point(290, 157);
            this.chbTransferencia.Margin = new System.Windows.Forms.Padding(2);
            this.chbTransferencia.Name = "chbTransferencia";
            this.chbTransferencia.Size = new System.Drawing.Size(91, 17);
            this.chbTransferencia.TabIndex = 7;
            this.chbTransferencia.Text = "Transferencia";
            this.chbTransferencia.UseVisualStyleBackColor = true;
            // 
            // lblMontoPagado
            // 
            this.lblMontoPagado.AutoSize = true;
            this.lblMontoPagado.Location = new System.Drawing.Point(27, 345);
            this.lblMontoPagado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMontoPagado.Name = "lblMontoPagado";
            this.lblMontoPagado.Size = new System.Drawing.Size(83, 13);
            this.lblMontoPagado.TabIndex = 23;
            this.lblMontoPagado.Text = "Monto Pagado :";
            this.lblMontoPagado.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtMontoPagado
            // 
            this.txtMontoPagado.Location = new System.Drawing.Point(186, 345);
            this.txtMontoPagado.Margin = new System.Windows.Forms.Padding(2);
            this.txtMontoPagado.Name = "txtMontoPagado";
            this.txtMontoPagado.Size = new System.Drawing.Size(118, 20);
            this.txtMontoPagado.TabIndex = 13;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(186, 378);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(56, 28);
            this.btnEditar.TabIndex = 15;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(281, 378);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(56, 28);
            this.btnEliminar.TabIndex = 16;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnBuscarReserva
            // 
            this.btnBuscarReserva.Location = new System.Drawing.Point(409, 209);
            this.btnBuscarReserva.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarReserva.Name = "btnBuscarReserva";
            this.btnBuscarReserva.Size = new System.Drawing.Size(112, 29);
            this.btnBuscarReserva.TabIndex = 11;
            this.btnBuscarReserva.Text = "Buscar Reserva";
            this.btnBuscarReserva.UseVisualStyleBackColor = true;
            this.btnBuscarReserva.Click += new System.EventHandler(this.btnBuscarReserva_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExportar.Location = new System.Drawing.Point(484, 378);
            this.btnExportar.Margin = new System.Windows.Forms.Padding(2);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(63, 28);
            this.btnExportar.TabIndex = 24;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            // 
            // lblNumeroDePago
            // 
            this.lblNumeroDePago.AutoSize = true;
            this.lblNumeroDePago.Location = new System.Drawing.Point(27, 9);
            this.lblNumeroDePago.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumeroDePago.Name = "lblNumeroDePago";
            this.lblNumeroDePago.Size = new System.Drawing.Size(93, 13);
            this.lblNumeroDePago.TabIndex = 25;
            this.lblNumeroDePago.Text = "Numero de Pago :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Nombre y Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(27, 34);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(50, 13);
            this.lblNombre.TabIndex = 27;
            this.lblNombre.Text = "Nombre :";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(186, 34);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(286, 20);
            this.txtNombre.TabIndex = 28;
            // 
            // FrmPagoVendedor
            // 
            this.AcceptButton = this.btnGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(648, 455);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNumeroDePago);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnBuscarReserva);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.txtMontoPagado);
            this.Controls.Add(this.lblMontoPagado);
            this.Controls.Add(this.chbTransferencia);
            this.Controls.Add(this.chbEfectivo);
            this.Controls.Add(this.dgvReservasPagas);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.lblNumeroReserva);
            this.Controls.Add(this.dtpFechaPago);
            this.Controls.Add(this.txtNumeroReserva);
            this.Controls.Add(this.txtEnConcepto);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblFormaPago);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblEnConcepto);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.btnBuscarVendedor);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmPagoVendedor";
            this.Text = "FrmPagoVendedor";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservasPagas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBuscarVendedor;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblEnConcepto;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblFormaPago;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtEnConcepto;
        private System.Windows.Forms.TextBox txtNumeroReserva;
        private System.Windows.Forms.DateTimePicker dtpFechaPago;
        private System.Windows.Forms.Label lblNumeroReserva;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.DataGridView dgvReservasPagas;
        private System.Windows.Forms.CheckBox chbEfectivo;
        private System.Windows.Forms.CheckBox chbTransferencia;
        private System.Windows.Forms.Label lblMontoPagado;
        private System.Windows.Forms.TextBox txtMontoPagado;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscarReserva;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Label lblNumeroDePago;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
    }
}