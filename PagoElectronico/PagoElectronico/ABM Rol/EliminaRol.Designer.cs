namespace PagoElectronico.ABM_Rol
{
    partial class EliminaRol
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
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lstBxFunc = new System.Windows.Forms.ListBox();
            this.lstbxFunAgre = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bntAgregar = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnAgregarTodas = new System.Windows.Forms.Button();
            this.btnQuitarTodas = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.cmbxRol = new System.Windows.Forms.ComboBox();
            this.grbxListas = new System.Windows.Forms.GroupBox();
            this.ckbxHabilitado = new System.Windows.Forms.CheckBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grbxListas.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(790, 554);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(139, 32);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(60, 554);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(139, 32);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lstBxFunc
            // 
            this.lstBxFunc.FormattingEnabled = true;
            this.lstBxFunc.Location = new System.Drawing.Point(6, 81);
            this.lstBxFunc.Name = "lstBxFunc";
            this.lstBxFunc.Size = new System.Drawing.Size(429, 290);
            this.lstBxFunc.Sorted = true;
            this.lstBxFunc.TabIndex = 0;
            // 
            // lstbxFunAgre
            // 
            this.lstbxFunAgre.FormattingEnabled = true;
            this.lstbxFunAgre.Location = new System.Drawing.Point(531, 81);
            this.lstbxFunAgre.Name = "lstbxFunAgre";
            this.lstbxFunAgre.Size = new System.Drawing.Size(429, 290);
            this.lstbxFunAgre.Sorted = true;
            this.lstbxFunAgre.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Funcionalidades";
            // 
            // bntAgregar
            // 
            this.bntAgregar.Location = new System.Drawing.Point(441, 127);
            this.bntAgregar.Name = "bntAgregar";
            this.bntAgregar.Size = new System.Drawing.Size(75, 23);
            this.bntAgregar.TabIndex = 4;
            this.bntAgregar.Text = "Agregar >>";
            this.bntAgregar.UseVisualStyleBackColor = true;
            this.bntAgregar.Click += new System.EventHandler(this.bntAgregar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(441, 315);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(75, 23);
            this.btnQuitar.TabIndex = 5;
            this.btnQuitar.Text = "<< Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnAgregarTodas
            // 
            this.btnAgregarTodas.Location = new System.Drawing.Point(547, 39);
            this.btnAgregarTodas.Name = "btnAgregarTodas";
            this.btnAgregarTodas.Size = new System.Drawing.Size(99, 23);
            this.btnAgregarTodas.TabIndex = 5;
            this.btnAgregarTodas.Text = "Agregar Todas";
            this.btnAgregarTodas.UseVisualStyleBackColor = true;
            this.btnAgregarTodas.Click += new System.EventHandler(this.btnAgregarTodas_Click);
            // 
            // btnQuitarTodas
            // 
            this.btnQuitarTodas.Location = new System.Drawing.Point(684, 39);
            this.btnQuitarTodas.Name = "btnQuitarTodas";
            this.btnQuitarTodas.Size = new System.Drawing.Size(99, 23);
            this.btnQuitarTodas.TabIndex = 5;
            this.btnQuitarTodas.Text = "Quitar Todas";
            this.btnQuitarTodas.UseVisualStyleBackColor = true;
            this.btnQuitarTodas.Click += new System.EventHandler(this.btnQuitarTodas_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAceptar);
            this.groupBox1.Controls.Add(this.cmbxRol);
            this.groupBox1.Controls.Add(this.grbxListas);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(2, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(990, 526);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rol";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(445, 11);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(117, 27);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // cmbxRol
            // 
            this.cmbxRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxRol.FormattingEnabled = true;
            this.cmbxRol.Location = new System.Drawing.Point(131, 15);
            this.cmbxRol.Name = "cmbxRol";
            this.cmbxRol.Size = new System.Drawing.Size(155, 21);
            this.cmbxRol.TabIndex = 7;
            // 
            // grbxListas
            // 
            this.grbxListas.Controls.Add(this.ckbxHabilitado);
            this.grbxListas.Controls.Add(this.btnQuitarTodas);
            this.grbxListas.Controls.Add(this.btnAgregarTodas);
            this.grbxListas.Controls.Add(this.btnQuitar);
            this.grbxListas.Controls.Add(this.bntAgregar);
            this.grbxListas.Controls.Add(this.label2);
            this.grbxListas.Controls.Add(this.lstbxFunAgre);
            this.grbxListas.Controls.Add(this.lstBxFunc);
            this.grbxListas.Enabled = false;
            this.grbxListas.Location = new System.Drawing.Point(4, 57);
            this.grbxListas.Name = "grbxListas";
            this.grbxListas.Size = new System.Drawing.Size(970, 450);
            this.grbxListas.TabIndex = 6;
            this.grbxListas.TabStop = false;
            this.grbxListas.Text = "Listas";
            // 
            // ckbxHabilitado
            // 
            this.ckbxHabilitado.AutoSize = true;
            this.ckbxHabilitado.Location = new System.Drawing.Point(804, 411);
            this.ckbxHabilitado.Name = "ckbxHabilitado";
            this.ckbxHabilitado.Size = new System.Drawing.Size(73, 17);
            this.ckbxHabilitado.TabIndex = 6;
            this.ckbxHabilitado.Text = "Habilitado";
            this.ckbxHabilitado.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(447, 558);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(139, 32);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // EliminaRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 602);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminar);
            this.Name = "EliminaRol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Eliminacion Roles";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbxListas.ResumeLayout(false);
            this.grbxListas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ListBox lstBxFunc;
        private System.Windows.Forms.ListBox lstbxFunAgre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bntAgregar;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnAgregarTodas;
        private System.Windows.Forms.Button btnQuitarTodas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grbxListas;
        private System.Windows.Forms.CheckBox ckbxHabilitado;
        private System.Windows.Forms.ComboBox cmbxRol;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}