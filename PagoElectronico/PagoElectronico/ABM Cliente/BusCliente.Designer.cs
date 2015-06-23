namespace PagoElectronico.ABM_Cliente
{
    partial class BusCliente
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
            this.groupFiltrosBus = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbxNroDoc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbTipoDoc = new System.Windows.Forms.ComboBox();
            this.txbxMail = new System.Windows.Forms.TextBox();
            this.txbxNombre = new System.Windows.Forms.TextBox();
            this.txbxApellido = new System.Windows.Forms.TextBox();
            this.btnBus = new System.Windows.Forms.Button();
            this.lstbxClientes = new System.Windows.Forms.ListBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.groupFiltrosBus.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupFiltrosBus
            // 
            this.groupFiltrosBus.Controls.Add(this.btnAceptar);
            this.groupFiltrosBus.Controls.Add(this.btnLimpiar);
            this.groupFiltrosBus.Controls.Add(this.btnBus);
            this.groupFiltrosBus.Controls.Add(this.cmbTipoDoc);
            this.groupFiltrosBus.Controls.Add(this.label5);
            this.groupFiltrosBus.Controls.Add(this.txbxApellido);
            this.groupFiltrosBus.Controls.Add(this.txbxNombre);
            this.groupFiltrosBus.Controls.Add(this.txbxMail);
            this.groupFiltrosBus.Controls.Add(this.txbxNroDoc);
            this.groupFiltrosBus.Controls.Add(this.label4);
            this.groupFiltrosBus.Controls.Add(this.label3);
            this.groupFiltrosBus.Controls.Add(this.label2);
            this.groupFiltrosBus.Controls.Add(this.label1);
            this.groupFiltrosBus.Location = new System.Drawing.Point(4, 10);
            this.groupFiltrosBus.Name = "groupFiltrosBus";
            this.groupFiltrosBus.Size = new System.Drawing.Size(744, 231);
            this.groupFiltrosBus.TabIndex = 0;
            this.groupFiltrosBus.TabStop = false;
            this.groupFiltrosBus.Text = "Filtros De Busqueda";
            this.groupFiltrosBus.Enter += new System.EventHandler(this.groupFiltrosBus_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "E-Mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(430, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Numero Doc";
            // 
            // txbxNroDoc
            // 
            this.txbxNroDoc.Location = new System.Drawing.Point(501, 32);
            this.txbxNroDoc.Name = "txbxNroDoc";
            this.txbxNroDoc.Size = new System.Drawing.Size(150, 20);
            this.txbxNroDoc.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(429, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tipo Doc";
            // 
            // cmbTipoDoc
            // 
            this.cmbTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDoc.FormattingEnabled = true;
            this.cmbTipoDoc.Location = new System.Drawing.Point(501, 82);
            this.cmbTipoDoc.Name = "cmbTipoDoc";
            this.cmbTipoDoc.Size = new System.Drawing.Size(150, 21);
            this.cmbTipoDoc.TabIndex = 3;
            // 
            // txbxMail
            // 
            this.txbxMail.Location = new System.Drawing.Point(85, 154);
            this.txbxMail.Name = "txbxMail";
            this.txbxMail.Size = new System.Drawing.Size(150, 20);
            this.txbxMail.TabIndex = 1;
            // 
            // txbxNombre
            // 
            this.txbxNombre.Location = new System.Drawing.Point(85, 36);
            this.txbxNombre.Name = "txbxNombre";
            this.txbxNombre.Size = new System.Drawing.Size(150, 20);
            this.txbxNombre.TabIndex = 1;
            // 
            // txbxApellido
            // 
            this.txbxApellido.Location = new System.Drawing.Point(85, 87);
            this.txbxApellido.Name = "txbxApellido";
            this.txbxApellido.Size = new System.Drawing.Size(150, 20);
            this.txbxApellido.TabIndex = 1;
            // 
            // btnBus
            // 
            this.btnBus.Location = new System.Drawing.Point(622, 167);
            this.btnBus.Name = "btnBus";
            this.btnBus.Size = new System.Drawing.Size(107, 33);
            this.btnBus.TabIndex = 4;
            this.btnBus.Text = "Buscar";
            this.btnBus.UseVisualStyleBackColor = true;
            // 
            // lstbxClientes
            // 
            this.lstbxClientes.FormattingEnabled = true;
            this.lstbxClientes.Location = new System.Drawing.Point(5, 248);
            this.lstbxClientes.Name = "lstbxClientes";
            this.lstbxClientes.ScrollAlwaysVisible = true;
            this.lstbxClientes.Size = new System.Drawing.Size(742, 303);
            this.lstbxClientes.TabIndex = 1;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(472, 167);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(107, 33);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(328, 167);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(107, 33);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // BusCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 566);
            this.Controls.Add(this.lstbxClientes);
            this.Controls.Add(this.groupFiltrosBus);
            this.Name = "BusCliente";
            this.Text = "BusCliente";
            this.groupFiltrosBus.ResumeLayout(false);
            this.groupFiltrosBus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupFiltrosBus;
        private System.Windows.Forms.ComboBox cmbTipoDoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbxNroDoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbxApellido;
        private System.Windows.Forms.TextBox txbxNombre;
        private System.Windows.Forms.TextBox txbxMail;
        private System.Windows.Forms.Button btnBus;
        private System.Windows.Forms.ListBox lstbxClientes;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnLimpiar;
    }
}