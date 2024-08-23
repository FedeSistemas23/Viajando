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
            this.lblIngreseVendedor = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblNomApe = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblEnConcepto = new System.Windows.Forms.Label();
            this.txtNomApe = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservasPagas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIngreseVendedor
            // 
            this.lblIngreseVendedor.AutoSize = true;
            this.lblIngreseVendedor.Location = new System.Drawing.Point(36, 31);
            this.lblIngreseVendedor.Name = "lblIngreseVendedor";
            this.lblIngreseVendedor.Size = new System.Drawing.Size(206, 16);
            this.lblIngreseVendedor.TabIndex = 0;
            this.lblIngreseVendedor.Text = "Ingrese el nombre del Vendedor :";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(248, 25);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(380, 22);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(673, 25);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // lblNomApe
            // 
            this.lblNomApe.AutoSize = true;
            this.lblNomApe.Location = new System.Drawing.Point(36, 93);
            this.lblNomApe.Name = "lblNomApe";
            this.lblNomApe.Size = new System.Drawing.Size(119, 16);
            this.lblNomApe.TabIndex = 3;
            this.lblNomApe.Text = "Nombre y Apellido";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(36, 129);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(51, 16);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "E-mail :";
            this.lblEmail.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(36, 172);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(70, 16);
            this.lblTelefono.TabIndex = 5;
            this.lblTelefono.Text = "Telefono : ";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(36, 216);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(106, 16);
            this.lblFecha.TabIndex = 6;
            this.lblFecha.Text = "Fecha de Pago :";
            // 
            // lblEnConcepto
            // 
            this.lblEnConcepto.AutoSize = true;
            this.lblEnConcepto.Location = new System.Drawing.Point(35, 304);
            this.lblEnConcepto.Name = "lblEnConcepto";
            this.lblEnConcepto.Size = new System.Drawing.Size(110, 16);
            this.lblEnConcepto.TabIndex = 7;
            this.lblEnConcepto.Text = "En concepto de : ";
            // 
            // txtNomApe
            // 
            this.txtNomApe.Location = new System.Drawing.Point(248, 87);
            this.txtNomApe.Name = "txtNomApe";
            this.txtNomApe.Size = new System.Drawing.Size(380, 22);
            this.txtNomApe.TabIndex = 3;
            // 
            // lblFormaPago
            // 
            this.lblFormaPago.AutoSize = true;
            this.lblFormaPago.Location = new System.Drawing.Point(35, 261);
            this.lblFormaPago.Name = "lblFormaPago";
            this.lblFormaPago.Size = new System.Drawing.Size(107, 16);
            this.lblFormaPago.TabIndex = 9;
            this.lblFormaPago.Text = "Forma de Pago :";
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(476, 604);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(295, 604);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(248, 129);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(380, 22);
            this.txtEmail.TabIndex = 4;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(248, 166);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(380, 22);
            this.txtTelefono.TabIndex = 5;
            // 
            // txtEnConcepto
            // 
            this.txtEnConcepto.Location = new System.Drawing.Point(248, 301);
            this.txtEnConcepto.Name = "txtEnConcepto";
            this.txtEnConcepto.Size = new System.Drawing.Size(380, 22);
            this.txtEnConcepto.TabIndex = 8;
            // 
            // txtNumeroReserva
            // 
            this.txtNumeroReserva.Location = new System.Drawing.Point(248, 354);
            this.txtNumeroReserva.Name = "txtNumeroReserva";
            this.txtNumeroReserva.Size = new System.Drawing.Size(156, 22);
            this.txtNumeroReserva.TabIndex = 9;
            // 
            // dtpFechaPago
            // 
            this.dtpFechaPago.Location = new System.Drawing.Point(248, 210);
            this.dtpFechaPago.Name = "dtpFechaPago";
            this.dtpFechaPago.Size = new System.Drawing.Size(360, 22);
            this.dtpFechaPago.TabIndex = 5;
            // 
            // lblNumeroReserva
            // 
            this.lblNumeroReserva.AutoSize = true;
            this.lblNumeroReserva.Location = new System.Drawing.Point(35, 357);
            this.lblNumeroReserva.Name = "lblNumeroReserva";
            this.lblNumeroReserva.Size = new System.Drawing.Size(194, 16);
            this.lblNumeroReserva.TabIndex = 18;
            this.lblNumeroReserva.Text = "Ingrese el numero de Reserva :";
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(449, 350);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 10;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            // 
            // dgvReservasPagas
            // 
            this.dgvReservasPagas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservasPagas.Location = new System.Drawing.Point(54, 394);
            this.dgvReservasPagas.Name = "dgvReservasPagas";
            this.dgvReservasPagas.RowHeadersWidth = 51;
            this.dgvReservasPagas.RowTemplate.Height = 24;
            this.dgvReservasPagas.Size = new System.Drawing.Size(730, 71);
            this.dgvReservasPagas.TabIndex = 20;
            // 
            // chbEfectivo
            // 
            this.chbEfectivo.AutoSize = true;
            this.chbEfectivo.Location = new System.Drawing.Point(248, 261);
            this.chbEfectivo.Name = "chbEfectivo";
            this.chbEfectivo.Size = new System.Drawing.Size(77, 20);
            this.chbEfectivo.TabIndex = 6;
            this.chbEfectivo.Text = "Efectivo";
            this.chbEfectivo.UseVisualStyleBackColor = true;
            // 
            // chbTransferencia
            // 
            this.chbTransferencia.AutoSize = true;
            this.chbTransferencia.Location = new System.Drawing.Point(396, 261);
            this.chbTransferencia.Name = "chbTransferencia";
            this.chbTransferencia.Size = new System.Drawing.Size(112, 20);
            this.chbTransferencia.TabIndex = 7;
            this.chbTransferencia.Text = "Transferencia";
            this.chbTransferencia.UseVisualStyleBackColor = true;
            // 
            // lblMontoPagado
            // 
            this.lblMontoPagado.AutoSize = true;
            this.lblMontoPagado.Location = new System.Drawing.Point(48, 503);
            this.lblMontoPagado.Name = "lblMontoPagado";
            this.lblMontoPagado.Size = new System.Drawing.Size(102, 16);
            this.lblMontoPagado.TabIndex = 23;
            this.lblMontoPagado.Text = "Monto Pagado :";
            this.lblMontoPagado.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtMontoPagado
            // 
            this.txtMontoPagado.Location = new System.Drawing.Point(231, 500);
            this.txtMontoPagado.Name = "txtMontoPagado";
            this.txtMontoPagado.Size = new System.Drawing.Size(156, 22);
            this.txtMontoPagado.TabIndex = 11;
            // 
            // FrmPagoVendedor
            // 
            this.AcceptButton = this.btnGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(864, 662);
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
            this.Controls.Add(this.txtNomApe);
            this.Controls.Add(this.lblEnConcepto);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNomApe);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblIngreseVendedor);
            this.Name = "FrmPagoVendedor";
            this.Text = "FrmPagoVendedor";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservasPagas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIngreseVendedor;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblNomApe;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblEnConcepto;
        private System.Windows.Forms.TextBox txtNomApe;
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
    }
}