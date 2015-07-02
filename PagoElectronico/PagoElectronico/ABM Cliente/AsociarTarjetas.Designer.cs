namespace PagoElectronico.ABM_Cliente
{
    partial class AsociarTarjetas
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
            this.txbxTarjNumE = new System.Windows.Forms.TextBox();
            this.cmbxEmisor = new System.Windows.Forms.ComboBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnDesasociar = new System.Windows.Forms.Button();
            this.btnAsociar = new System.Windows.Forms.Button();
            this.txbxTarjNumD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gpbxDatos = new System.Windows.Forms.GroupBox();
            this.txbxCodSeg = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateFechaEmi = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dateFechaVenc = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.gpbxDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbxTarjNumE
            // 
            this.txbxTarjNumE.Enabled = false;
            this.txbxTarjNumE.Location = new System.Drawing.Point(220, 25);
            this.txbxTarjNumE.Name = "txbxTarjNumE";
            this.txbxTarjNumE.PasswordChar = '*';
            this.txbxTarjNumE.Size = new System.Drawing.Size(124, 20);
            this.txbxTarjNumE.TabIndex = 1;
            this.txbxTarjNumE.Leave += new System.EventHandler(this.txbxTarjNumE_Leave);
            // 
            // cmbxEmisor
            // 
            this.cmbxEmisor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxEmisor.FormattingEnabled = true;
            this.cmbxEmisor.Location = new System.Drawing.Point(12, 25);
            this.cmbxEmisor.Name = "cmbxEmisor";
            this.cmbxEmisor.Size = new System.Drawing.Size(183, 21);
            this.cmbxEmisor.TabIndex = 0;
            this.cmbxEmisor.Leave += new System.EventHandler(this.cmbxEmisor_Leave);
            this.cmbxEmisor.SelectedValueChanged += new System.EventHandler(this.cmbxEmisor_SelectedValueChanged);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(12, 192);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnDesasociar
            // 
            this.btnDesasociar.Enabled = false;
            this.btnDesasociar.Location = new System.Drawing.Point(163, 192);
            this.btnDesasociar.Name = "btnDesasociar";
            this.btnDesasociar.Size = new System.Drawing.Size(75, 23);
            this.btnDesasociar.TabIndex = 2;
            this.btnDesasociar.Text = "DesAsociar";
            this.btnDesasociar.UseVisualStyleBackColor = true;
            // 
            // btnAsociar
            // 
            this.btnAsociar.Enabled = false;
            this.btnAsociar.Location = new System.Drawing.Point(355, 192);
            this.btnAsociar.Name = "btnAsociar";
            this.btnAsociar.Size = new System.Drawing.Size(75, 23);
            this.btnAsociar.TabIndex = 2;
            this.btnAsociar.Text = "Asociar";
            this.btnAsociar.UseVisualStyleBackColor = true;
            // 
            // txbxTarjNumD
            // 
            this.txbxTarjNumD.Enabled = false;
            this.txbxTarjNumD.Location = new System.Drawing.Point(368, 25);
            this.txbxTarjNumD.Name = "txbxTarjNumD";
            this.txbxTarjNumD.Size = new System.Drawing.Size(62, 20);
            this.txbxTarjNumD.TabIndex = 2;
            this.txbxTarjNumD.Leave += new System.EventHandler(this.txbxTarjNumD_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(350, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "-";
            // 
            // gpbxDatos
            // 
            this.gpbxDatos.Controls.Add(this.label4);
            this.gpbxDatos.Controls.Add(this.label3);
            this.gpbxDatos.Controls.Add(this.dateFechaVenc);
            this.gpbxDatos.Controls.Add(this.dateFechaEmi);
            this.gpbxDatos.Controls.Add(this.label2);
            this.gpbxDatos.Controls.Add(this.txbxCodSeg);
            this.gpbxDatos.Enabled = false;
            this.gpbxDatos.Location = new System.Drawing.Point(8, 68);
            this.gpbxDatos.Name = "gpbxDatos";
            this.gpbxDatos.Size = new System.Drawing.Size(479, 114);
            this.gpbxDatos.TabIndex = 5;
            this.gpbxDatos.TabStop = false;
            this.gpbxDatos.Text = "Datos";
            // 
            // txbxCodSeg
            // 
            this.txbxCodSeg.Location = new System.Drawing.Point(90, 19);
            this.txbxCodSeg.Name = "txbxCodSeg";
            this.txbxCodSeg.Size = new System.Drawing.Size(100, 20);
            this.txbxCodSeg.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cod Seguridad";
            // 
            // dateFechaEmi
            // 
            this.dateFechaEmi.Location = new System.Drawing.Point(90, 70);
            this.dateFechaEmi.Name = "dateFechaEmi";
            this.dateFechaEmi.Size = new System.Drawing.Size(148, 20);
            this.dateFechaEmi.TabIndex = 2;
            this.dateFechaEmi.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fecha Emision";
            // 
            // dateFechaVenc
            // 
            this.dateFechaVenc.Location = new System.Drawing.Point(325, 25);
            this.dateFechaVenc.Name = "dateFechaVenc";
            this.dateFechaVenc.Size = new System.Drawing.Size(148, 20);
            this.dateFechaVenc.TabIndex = 2;
            this.dateFechaVenc.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(221, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha Vencimiento";
            // 
            // AsociarTarjetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 227);
            this.Controls.Add(this.gpbxDatos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbxTarjNumD);
            this.Controls.Add(this.btnAsociar);
            this.Controls.Add(this.btnDesasociar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.cmbxEmisor);
            this.Controls.Add(this.txbxTarjNumE);
            this.Name = "AsociarTarjetas";
            this.Text = "AsociarTarjetas";
            this.Load += new System.EventHandler(this.AsociarTarjetas_Load);
            this.gpbxDatos.ResumeLayout(false);
            this.gpbxDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbxTarjNumE;
        private System.Windows.Forms.ComboBox cmbxEmisor;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnDesasociar;
        private System.Windows.Forms.Button btnAsociar;
        private System.Windows.Forms.TextBox txbxTarjNumD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpbxDatos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateFechaEmi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbxCodSeg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateFechaVenc;
    }
}