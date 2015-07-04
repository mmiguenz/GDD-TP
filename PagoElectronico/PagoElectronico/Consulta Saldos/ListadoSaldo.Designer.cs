namespace PagoElectronico.Consulta_Saldos
{
    partial class ListadoSaldo
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
            this.gridSaldo = new System.Windows.Forms.DataGridView();
            this.gridDepositos = new System.Windows.Forms.DataGridView();
            this.gridRetiros = new System.Windows.Forms.DataGridView();
            this.gridTransferencias = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridSaldo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDepositos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRetiros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTransferencias)).BeginInit();
            this.SuspendLayout();
            // 
            // gridSaldo
            // 
            this.gridSaldo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSaldo.Location = new System.Drawing.Point(28, 75);
            this.gridSaldo.Name = "gridSaldo";
            this.gridSaldo.ReadOnly = true;
            this.gridSaldo.Size = new System.Drawing.Size(961, 56);
            this.gridSaldo.TabIndex = 0;
            // 
            // gridDepositos
            // 
            this.gridDepositos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDepositos.Location = new System.Drawing.Point(28, 174);
            this.gridDepositos.Name = "gridDepositos";
            this.gridDepositos.ReadOnly = true;
            this.gridDepositos.Size = new System.Drawing.Size(961, 117);
            this.gridDepositos.TabIndex = 1;
            // 
            // gridRetiros
            // 
            this.gridRetiros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRetiros.Location = new System.Drawing.Point(28, 313);
            this.gridRetiros.Name = "gridRetiros";
            this.gridRetiros.ReadOnly = true;
            this.gridRetiros.Size = new System.Drawing.Size(961, 117);
            this.gridRetiros.TabIndex = 1;
            // 
            // gridTransferencias
            // 
            this.gridTransferencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTransferencias.Location = new System.Drawing.Point(28, 453);
            this.gridTransferencias.Name = "gridTransferencias";
            this.gridTransferencias.ReadOnly = true;
            this.gridTransferencias.Size = new System.Drawing.Size(961, 117);
            this.gridTransferencias.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(294, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "LISTADO DE SALDOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Saldo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ultimos 5 Depositos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ultimos 5 retiros";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 437);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ultimas 10 transferencias";
            // 
            // ListadoSaldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 582);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridTransferencias);
            this.Controls.Add(this.gridRetiros);
            this.Controls.Add(this.gridDepositos);
            this.Controls.Add(this.gridSaldo);
            this.Name = "ListadoSaldo";
            this.Text = "ListadoSaldo";
            ((System.ComponentModel.ISupportInitialize)(this.gridSaldo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDepositos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRetiros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTransferencias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridSaldo;
        private System.Windows.Forms.DataGridView gridDepositos;
        private System.Windows.Forms.DataGridView gridRetiros;
        private System.Windows.Forms.DataGridView gridTransferencias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}