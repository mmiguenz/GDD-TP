namespace PagoElectronico.ABM_de_Usuario
{
    partial class EliminacionUsuario
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
            this.txbxUsrName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbxPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbxPregunta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbxResp = new System.Windows.Forms.TextBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckbxHabilitado = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.txbxCliente = new System.Windows.Forms.TextBox();
            this.txbxBusUsername = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // txbxUsrName
            // 
            this.txbxUsrName.Location = new System.Drawing.Point(120, 36);
            this.txbxUsrName.Name = "txbxUsrName";
            this.txbxUsrName.Size = new System.Drawing.Size(137, 20);
            this.txbxUsrName.TabIndex = 0;
            this.txbxUsrName.Leave += new System.EventHandler(this.txbxUsrName_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password";
            // 
            // txbxPass
            // 
            this.txbxPass.Location = new System.Drawing.Point(120, 95);
            this.txbxPass.Name = "txbxPass";
            this.txbxPass.PasswordChar = '*';
            this.txbxPass.Size = new System.Drawing.Size(137, 20);
            this.txbxPass.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Pregunta Secreta";
            // 
            // txbxPregunta
            // 
            this.txbxPregunta.Location = new System.Drawing.Point(120, 167);
            this.txbxPregunta.Name = "txbxPregunta";
            this.txbxPregunta.Size = new System.Drawing.Size(137, 20);
            this.txbxPregunta.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Respuesta  Secreta";
            // 
            // txbxResp
            // 
            this.txbxResp.Location = new System.Drawing.Point(120, 235);
            this.txbxResp.Name = "txbxResp";
            this.txbxResp.PasswordChar = '*';
            this.txbxResp.Size = new System.Drawing.Size(137, 20);
            this.txbxResp.TabIndex = 3;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(26, 390);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(96, 28);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(441, 390);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(96, 28);
            this.btnGrabar.TabIndex = 2;
            this.btnGrabar.Text = "Eliminar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckbxHabilitado);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnBuscarCliente);
            this.groupBox1.Controls.Add(this.txbxCliente);
            this.groupBox1.Controls.Add(this.txbxResp);
            this.groupBox1.Controls.Add(this.txbxPregunta);
            this.groupBox1.Controls.Add(this.txbxPass);
            this.groupBox1.Controls.Add(this.txbxUsrName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(12, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(587, 314);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Usuario";
            // 
            // ckbxHabilitado
            // 
            this.ckbxHabilitado.Enabled = false;
            this.ckbxHabilitado.Location = new System.Drawing.Point(411, 267);
            this.ckbxHabilitado.Name = "ckbxHabilitado";
            this.ckbxHabilitado.Size = new System.Drawing.Size(104, 24);
            this.ckbxHabilitado.TabIndex = 8;
            this.ckbxHabilitado.Text = "Habilitado";
            this.ckbxHabilitado.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(363, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Asociar Cliente";
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(488, 172);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(65, 22);
            this.btnBuscarCliente.TabIndex = 6;
            this.btnBuscarCliente.Text = "Buscar ";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // txbxCliente
            // 
            this.txbxCliente.Enabled = false;
            this.txbxCliente.Location = new System.Drawing.Point(346, 174);
            this.txbxCliente.Name = "txbxCliente";
            this.txbxCliente.Size = new System.Drawing.Size(136, 20);
            this.txbxCliente.TabIndex = 5;
            // 
            // txbxBusUsername
            // 
            this.txbxBusUsername.Enabled = false;
            this.txbxBusUsername.Location = new System.Drawing.Point(26, 12);
            this.txbxBusUsername.Name = "txbxBusUsername";
            this.txbxBusUsername.Size = new System.Drawing.Size(192, 20);
            this.txbxBusUsername.TabIndex = 6;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(262, 10);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // EliminacionUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 430);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txbxBusUsername);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnCerrar);
            this.Name = "EliminacionUsuario";
            this.Text = "Eliminacion  Usuarios";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbxUsrName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbxPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbxPregunta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbxResp;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.TextBox txbxCliente;
        private System.Windows.Forms.CheckBox ckbxHabilitado;
        private System.Windows.Forms.TextBox txbxBusUsername;
        private System.Windows.Forms.Button btnBuscar;
    }
}