namespace PagoElectronico.ABM_Cliente
{
    partial class AltaCliente
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
            this.groupDatosGenerales = new System.Windows.Forms.GroupBox();
            this.Calendario = new System.Windows.Forms.DateTimePicker();
            this.cmbPais = new System.Windows.Forms.ComboBox();
            this.cmbTipoDoc = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbxNroDoc = new System.Windows.Forms.TextBox();
            this.txbxApellido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbxMail = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txbxNombre = new System.Windows.Forms.TextBox();
            this.groupBoxDomicilio = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txbxLocalidad = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txbxDto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbxAltura = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txbxPiso = new System.Windows.Forms.TextBox();
            this.Calle = new System.Windows.Forms.Label();
            this.txbxCalle = new System.Windows.Forms.TextBox();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupDatosGenerales.SuspendLayout();
            this.groupBoxDomicilio.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupDatosGenerales
            // 
            this.groupDatosGenerales.Controls.Add(this.button1);
            this.groupDatosGenerales.Controls.Add(this.Calendario);
            this.groupDatosGenerales.Controls.Add(this.cmbPais);
            this.groupDatosGenerales.Controls.Add(this.cmbTipoDoc);
            this.groupDatosGenerales.Controls.Add(this.label7);
            this.groupDatosGenerales.Controls.Add(this.label3);
            this.groupDatosGenerales.Controls.Add(this.label2);
            this.groupDatosGenerales.Controls.Add(this.label5);
            this.groupDatosGenerales.Controls.Add(this.label1);
            this.groupDatosGenerales.Controls.Add(this.txbxNroDoc);
            this.groupDatosGenerales.Controls.Add(this.txbxApellido);
            this.groupDatosGenerales.Controls.Add(this.label4);
            this.groupDatosGenerales.Controls.Add(this.txbxMail);
            this.groupDatosGenerales.Controls.Add(this.lblNombre);
            this.groupDatosGenerales.Controls.Add(this.txbxNombre);
            this.groupDatosGenerales.Location = new System.Drawing.Point(7, 25);
            this.groupDatosGenerales.Name = "groupDatosGenerales";
            this.groupDatosGenerales.Size = new System.Drawing.Size(959, 259);
            this.groupDatosGenerales.TabIndex = 0;
            this.groupDatosGenerales.TabStop = false;
            this.groupDatosGenerales.Text = "Datos Generales";
            // 
            // Calendario
            // 
            this.Calendario.Location = new System.Drawing.Point(626, 184);
            this.Calendario.Name = "Calendario";
            this.Calendario.Size = new System.Drawing.Size(200, 20);
            this.Calendario.TabIndex = 6;
            // 
            // cmbPais
            // 
            this.cmbPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPais.FormattingEnabled = true;
            this.cmbPais.Location = new System.Drawing.Point(584, 76);
            this.cmbPais.Name = "cmbPais";
            this.cmbPais.Size = new System.Drawing.Size(121, 21);
            this.cmbPais.TabIndex = 5;
            // 
            // cmbTipoDoc
            // 
            this.cmbTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDoc.FormattingEnabled = true;
            this.cmbTipoDoc.Location = new System.Drawing.Point(89, 129);
            this.cmbTipoDoc.Name = "cmbTipoDoc";
            this.cmbTipoDoc.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoDoc.TabIndex = 2;
            this.cmbTipoDoc.Leave += new System.EventHandler(this.cmbTipoDoc_Leave);
            this.cmbTipoDoc.TextChanged += new System.EventHandler(this.cmbTipoDoc_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(512, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Fecha Nacimiento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Numero Doc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo Doc";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(512, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Pais";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Apellido";
            // 
            // txbxNroDoc
            // 
            this.txbxNroDoc.Enabled = false;
            this.txbxNroDoc.Location = new System.Drawing.Point(89, 177);
            this.txbxNroDoc.Name = "txbxNroDoc";
            this.txbxNroDoc.Size = new System.Drawing.Size(149, 20);
            this.txbxNroDoc.TabIndex = 3;
            this.txbxNroDoc.TextChanged += new System.EventHandler(this.txbxNroDoc_TextChanged);
            this.txbxNroDoc.Leave += new System.EventHandler(this.txbxNroDoc_Leave);
            // 
            // txbxApellido
            // 
            this.txbxApellido.Location = new System.Drawing.Point(89, 84);
            this.txbxApellido.Name = "txbxApellido";
            this.txbxApellido.Size = new System.Drawing.Size(149, 20);
            this.txbxApellido.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(512, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mail";
            // 
            // txbxMail
            // 
            this.txbxMail.Location = new System.Drawing.Point(584, 30);
            this.txbxMail.Name = "txbxMail";
            this.txbxMail.Size = new System.Drawing.Size(167, 20);
            this.txbxMail.TabIndex = 4;
            this.txbxMail.Leave += new System.EventHandler(this.txbxMail_Leave);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(17, 44);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // txbxNombre
            // 
            this.txbxNombre.Location = new System.Drawing.Point(89, 37);
            this.txbxNombre.Name = "txbxNombre";
            this.txbxNombre.Size = new System.Drawing.Size(149, 20);
            this.txbxNombre.TabIndex = 0;
            // 
            // groupBoxDomicilio
            // 
            this.groupBoxDomicilio.Controls.Add(this.label10);
            this.groupBoxDomicilio.Controls.Add(this.txbxLocalidad);
            this.groupBoxDomicilio.Controls.Add(this.label9);
            this.groupBoxDomicilio.Controls.Add(this.txbxDto);
            this.groupBoxDomicilio.Controls.Add(this.label6);
            this.groupBoxDomicilio.Controls.Add(this.txbxAltura);
            this.groupBoxDomicilio.Controls.Add(this.label8);
            this.groupBoxDomicilio.Controls.Add(this.txbxPiso);
            this.groupBoxDomicilio.Controls.Add(this.Calle);
            this.groupBoxDomicilio.Controls.Add(this.txbxCalle);
            this.groupBoxDomicilio.Location = new System.Drawing.Point(8, 294);
            this.groupBoxDomicilio.Name = "groupBoxDomicilio";
            this.groupBoxDomicilio.Size = new System.Drawing.Size(957, 253);
            this.groupBoxDomicilio.TabIndex = 1;
            this.groupBoxDomicilio.TabStop = false;
            this.groupBoxDomicilio.Text = "Domicilio";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(448, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Localidad";
            // 
            // txbxLocalidad
            // 
            this.txbxLocalidad.Location = new System.Drawing.Point(517, 93);
            this.txbxLocalidad.Name = "txbxLocalidad";
            this.txbxLocalidad.Size = new System.Drawing.Size(114, 20);
            this.txbxLocalidad.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(448, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Dto";
            // 
            // txbxDto
            // 
            this.txbxDto.Location = new System.Drawing.Point(517, 29);
            this.txbxDto.Name = "txbxDto";
            this.txbxDto.Size = new System.Drawing.Size(114, 20);
            this.txbxDto.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Altura";
            // 
            // txbxAltura
            // 
            this.txbxAltura.Location = new System.Drawing.Point(88, 100);
            this.txbxAltura.Name = "txbxAltura";
            this.txbxAltura.Size = new System.Drawing.Size(149, 20);
            this.txbxAltura.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Piso";
            // 
            // txbxPiso
            // 
            this.txbxPiso.Location = new System.Drawing.Point(88, 165);
            this.txbxPiso.Name = "txbxPiso";
            this.txbxPiso.Size = new System.Drawing.Size(149, 20);
            this.txbxPiso.TabIndex = 9;
            // 
            // Calle
            // 
            this.Calle.AutoSize = true;
            this.Calle.Location = new System.Drawing.Point(19, 40);
            this.Calle.Name = "Calle";
            this.Calle.Size = new System.Drawing.Size(30, 13);
            this.Calle.TabIndex = 0;
            this.Calle.Text = "Calle";
            // 
            // txbxCalle
            // 
            this.txbxCalle.Location = new System.Drawing.Point(88, 33);
            this.txbxCalle.Name = "txbxCalle";
            this.txbxCalle.Size = new System.Drawing.Size(149, 20);
            this.txbxCalle.TabIndex = 7;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(733, 566);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(198, 35);
            this.btnGrabar.TabIndex = 2;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(19, 565);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(198, 35);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(358, 565);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(198, 35);
            this.btnLimpiar.TabIndex = 2;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(271, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 22);
            this.button1.TabIndex = 12;
            this.button1.Text = "AsociarTarjeta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AltaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 612);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.groupBoxDomicilio);
            this.Controls.Add(this.groupDatosGenerales);
            this.Name = "AltaCliente";
            this.Text = "Alta Clientes";
            this.groupDatosGenerales.ResumeLayout(false);
            this.groupDatosGenerales.PerformLayout();
            this.groupBoxDomicilio.ResumeLayout(false);
            this.groupBoxDomicilio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupDatosGenerales;
        private System.Windows.Forms.ComboBox cmbTipoDoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbxApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txbxNombre;
        private System.Windows.Forms.ComboBox cmbPais;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbxNroDoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbxMail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBoxDomicilio;
        private System.Windows.Forms.Label Calle;
        private System.Windows.Forms.TextBox txbxCalle;
        private System.Windows.Forms.DateTimePicker Calendario;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txbxLocalidad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbxDto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbxPiso;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbxAltura;
        private System.Windows.Forms.Button button1;
    }
}