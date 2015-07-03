namespace PagoElectronico.ABM_Cuenta
{
    partial class AltaCuenta
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
            this.txbxNroCta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbxTipoCta = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbxPais = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbxMoneda = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbxNombreCli = new System.Windows.Forms.TextBox();
            this.NombreYApellido = new System.Windows.Forms.Label();
            this.btnBuscarCli = new System.Windows.Forms.Button();
            this.gpbxCli = new System.Windows.Forms.GroupBox();
            this.gpbxCta = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.gpbxCli.SuspendLayout();
            this.gpbxCta.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbxNroCta
            // 
            this.txbxNroCta.Enabled = false;
            this.txbxNroCta.Location = new System.Drawing.Point(103, 28);
            this.txbxNroCta.Name = "txbxNroCta";
            this.txbxNroCta.Size = new System.Drawing.Size(162, 20);
            this.txbxNroCta.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nro Cta";
            // 
            // cmbxTipoCta
            // 
            this.cmbxTipoCta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxTipoCta.FormattingEnabled = true;
            this.cmbxTipoCta.Location = new System.Drawing.Point(103, 109);
            this.cmbxTipoCta.Name = "cmbxTipoCta";
            this.cmbxTipoCta.Size = new System.Drawing.Size(162, 21);
            this.cmbxTipoCta.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tipo Cuenta";
            // 
            // cmbxPais
            // 
            this.cmbxPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxPais.FormattingEnabled = true;
            this.cmbxPais.Location = new System.Drawing.Point(464, 28);
            this.cmbxPais.Name = "cmbxPais";
            this.cmbxPais.Size = new System.Drawing.Size(162, 21);
            this.cmbxPais.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(384, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Pais";
            // 
            // cmbxMoneda
            // 
            this.cmbxMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxMoneda.FormattingEnabled = true;
            this.cmbxMoneda.Location = new System.Drawing.Point(464, 109);
            this.cmbxMoneda.Name = "cmbxMoneda";
            this.cmbxMoneda.Size = new System.Drawing.Size(162, 21);
            this.cmbxMoneda.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(384, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Moneda";
            // 
            // txbxNombreCli
            // 
            this.txbxNombreCli.Enabled = false;
            this.txbxNombreCli.Location = new System.Drawing.Point(160, 29);
            this.txbxNombreCli.Name = "txbxNombreCli";
            this.txbxNombreCli.Size = new System.Drawing.Size(162, 20);
            this.txbxNombreCli.TabIndex = 0;
            // 
            // NombreYApellido
            // 
            this.NombreYApellido.AutoSize = true;
            this.NombreYApellido.Location = new System.Drawing.Point(46, 33);
            this.NombreYApellido.Name = "NombreYApellido";
            this.NombreYApellido.Size = new System.Drawing.Size(88, 13);
            this.NombreYApellido.TabIndex = 1;
            this.NombreYApellido.Text = "NombreYApellido";
            // 
            // btnBuscarCli
            // 
            this.btnBuscarCli.Location = new System.Drawing.Point(361, 28);
            this.btnBuscarCli.Name = "btnBuscarCli";
            this.btnBuscarCli.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarCli.TabIndex = 4;
            this.btnBuscarCli.Text = "Buscar";
            this.btnBuscarCli.UseVisualStyleBackColor = true;
            this.btnBuscarCli.Click += new System.EventHandler(this.btnBuscarCli_Click);
            // 
            // gpbxCli
            // 
            this.gpbxCli.Controls.Add(this.btnBuscarCli);
            this.gpbxCli.Controls.Add(this.NombreYApellido);
            this.gpbxCli.Controls.Add(this.txbxNombreCli);
            this.gpbxCli.Location = new System.Drawing.Point(14, 12);
            this.gpbxCli.Name = "gpbxCli";
            this.gpbxCli.Size = new System.Drawing.Size(676, 88);
            this.gpbxCli.TabIndex = 5;
            this.gpbxCli.TabStop = false;
            this.gpbxCli.Text = "Cliente";
            // 
            // gpbxCta
            // 
            this.gpbxCta.Controls.Add(this.label4);
            this.gpbxCta.Controls.Add(this.cmbxMoneda);
            this.gpbxCta.Controls.Add(this.label3);
            this.gpbxCta.Controls.Add(this.cmbxPais);
            this.gpbxCta.Controls.Add(this.label2);
            this.gpbxCta.Controls.Add(this.cmbxTipoCta);
            this.gpbxCta.Controls.Add(this.label1);
            this.gpbxCta.Controls.Add(this.txbxNroCta);
            this.gpbxCta.Enabled = false;
            this.gpbxCta.Location = new System.Drawing.Point(15, 166);
            this.gpbxCta.Name = "gpbxCta";
            this.gpbxCta.Size = new System.Drawing.Size(674, 166);
            this.gpbxCta.TabIndex = 6;
            this.gpbxCta.TabStop = false;
            this.gpbxCta.Text = "Datos Cuenta";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(36, 400);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(107, 36);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(290, 400);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(107, 36);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(544, 400);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(107, 36);
            this.btnGrabar.TabIndex = 7;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // AltaCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 465);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.gpbxCta);
            this.Controls.Add(this.gpbxCli);
            this.Name = "AltaCuenta";
            this.Text = "Alta Cuenta";
            this.gpbxCli.ResumeLayout(false);
            this.gpbxCli.PerformLayout();
            this.gpbxCta.ResumeLayout(false);
            this.gpbxCta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txbxNroCta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbxTipoCta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbxPais;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbxMoneda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbxNombreCli;
        private System.Windows.Forms.Label NombreYApellido;
        private System.Windows.Forms.Button btnBuscarCli;
        private System.Windows.Forms.GroupBox gpbxCli;
        private System.Windows.Forms.GroupBox gpbxCta;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGrabar;
    }
}