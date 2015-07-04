namespace PagoElectronico.Consulta_Saldos
{
    partial class ConsultaSaldos
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
            this.txbxNombreCli = new System.Windows.Forms.TextBox();
            this.datepick = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbxCuentas = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbxNombreCli
            // 
            this.txbxNombreCli.Enabled = false;
            this.txbxNombreCli.Location = new System.Drawing.Point(12, 12);
            this.txbxNombreCli.Name = "txbxNombreCli";
            this.txbxNombreCli.Size = new System.Drawing.Size(233, 20);
            this.txbxNombreCli.TabIndex = 0;
            // 
            // datepick
            // 
            this.datepick.Location = new System.Drawing.Point(113, 61);
            this.datepick.Name = "datepick";
            this.datepick.Size = new System.Drawing.Size(200, 20);
            this.datepick.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fecha Tope";
            // 
            // cmbxCuentas
            // 
            this.cmbxCuentas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxCuentas.FormattingEnabled = true;
            this.cmbxCuentas.Location = new System.Drawing.Point(113, 109);
            this.cmbxCuentas.Name = "cmbxCuentas";
            this.cmbxCuentas.Size = new System.Drawing.Size(200, 21);
            this.cmbxCuentas.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cuenta";
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(244, 186);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(123, 32);
            this.btnListar.TabIndex = 4;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(38, 186);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(123, 32);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // ConsultaSaldos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 230);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.cmbxCuentas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datepick);
            this.Controls.Add(this.txbxNombreCli);
            this.Name = "ConsultaSaldos";
            this.Text = "Consulta Saldo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbxNombreCli;
        private System.Windows.Forms.DateTimePicker datepick;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbxCuentas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnSalir;
    }
}