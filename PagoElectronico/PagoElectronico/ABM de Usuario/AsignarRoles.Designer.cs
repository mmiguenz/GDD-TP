namespace PagoElectronico.ABM_de_Usuario
{
    partial class AsignarRoles
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.cklstbxRoles = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(673, 508);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(136, 36);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // cklstbxRoles
            // 
            this.cklstbxRoles.FormattingEnabled = true;
            this.cklstbxRoles.Location = new System.Drawing.Point(79, 71);
            this.cklstbxRoles.Name = "cklstbxRoles";
            this.cklstbxRoles.Size = new System.Drawing.Size(689, 379);
            this.cklstbxRoles.TabIndex = 1;
            // 
            // AsignarRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 556);
            this.Controls.Add(this.cklstbxRoles);
            this.Controls.Add(this.btnAceptar);
            this.Name = "AsignarRoles";
            this.Text = "AsignarRoles";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.CheckedListBox cklstbxRoles;
    }
}