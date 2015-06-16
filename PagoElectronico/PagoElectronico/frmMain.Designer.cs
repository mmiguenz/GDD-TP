namespace PagoElectronico
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.aBMClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saldosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depositosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depositosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.retirosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transferenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarDeRolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripSplitButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1267, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(38, 22);
            this.toolStripLabel1.Text = "Menu";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aBMClienteToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.depositosToolStripMenuItem,
            this.facturacionToolStripMenuItem,
            this.listadosToolStripMenuItem,
            this.cambiarDeRolToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(32, 22);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            this.toolStripSplitButton1.ButtonClick += new System.EventHandler(this.toolStripSplitButton1_ButtonClick);
            // 
            // aBMClienteToolStripMenuItem
            // 
            this.aBMClienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.cuentasToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.rolToolStripMenuItem});
            this.aBMClienteToolStripMenuItem.Name = "aBMClienteToolStripMenuItem";
            this.aBMClienteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aBMClienteToolStripMenuItem.Text = "ABM";
            this.aBMClienteToolStripMenuItem.Click += new System.EventHandler(this.aBMClienteToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // cuentasToolStripMenuItem
            // 
            this.cuentasToolStripMenuItem.Name = "cuentasToolStripMenuItem";
            this.cuentasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cuentasToolStripMenuItem.Text = "Cuentas";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // rolToolStripMenuItem
            // 
            this.rolToolStripMenuItem.Name = "rolToolStripMenuItem";
            this.rolToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.rolToolStripMenuItem.Text = "Rol";
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saldosToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // saldosToolStripMenuItem
            // 
            this.saldosToolStripMenuItem.Name = "saldosToolStripMenuItem";
            this.saldosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saldosToolStripMenuItem.Text = "Saldos";
            // 
            // depositosToolStripMenuItem
            // 
            this.depositosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.depositosToolStripMenuItem1,
            this.retirosToolStripMenuItem,
            this.transferenciasToolStripMenuItem});
            this.depositosToolStripMenuItem.Name = "depositosToolStripMenuItem";
            this.depositosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.depositosToolStripMenuItem.Text = "Movimientos";
            this.depositosToolStripMenuItem.Click += new System.EventHandler(this.depositosToolStripMenuItem_Click);
            // 
            // depositosToolStripMenuItem1
            // 
            this.depositosToolStripMenuItem1.Name = "depositosToolStripMenuItem1";
            this.depositosToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.depositosToolStripMenuItem1.Text = "Depositos";
            // 
            // retirosToolStripMenuItem
            // 
            this.retirosToolStripMenuItem.Name = "retirosToolStripMenuItem";
            this.retirosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.retirosToolStripMenuItem.Text = "Retiros";
            // 
            // transferenciasToolStripMenuItem
            // 
            this.transferenciasToolStripMenuItem.Name = "transferenciasToolStripMenuItem";
            this.transferenciasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.transferenciasToolStripMenuItem.Text = "Transferencias";
            // 
            // facturacionToolStripMenuItem
            // 
            this.facturacionToolStripMenuItem.Name = "facturacionToolStripMenuItem";
            this.facturacionToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.facturacionToolStripMenuItem.Text = "Facturacion";
            // 
            // listadosToolStripMenuItem
            // 
            this.listadosToolStripMenuItem.Name = "listadosToolStripMenuItem";
            this.listadosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.listadosToolStripMenuItem.Text = "Listados";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // cambiarDeRolToolStripMenuItem
            // 
            this.cambiarDeRolToolStripMenuItem.Name = "cambiarDeRolToolStripMenuItem";
            this.cambiarDeRolToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cambiarDeRolToolStripMenuItem.Text = "CambiarDeRol";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 582);
            this.Controls.Add(this.toolStrip1);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem aBMClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saldosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depositosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depositosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem retirosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transferenciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarDeRolToolStripMenuItem;
    }
}