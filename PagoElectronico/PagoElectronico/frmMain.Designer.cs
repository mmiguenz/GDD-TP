namespace PagoElectronico
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.ABMmenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ClientesMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ClientesAlta = new System.Windows.Forms.ToolStripMenuItem();
            this.ClientesBaja = new System.Windows.Forms.ToolStripMenuItem();
            this.ClientesModificacion = new System.Windows.Forms.ToolStripMenuItem();
            this.CuentasMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.CuentasAlta = new System.Windows.Forms.ToolStripMenuItem();
            this.CuentasBaja = new System.Windows.Forms.ToolStripMenuItem();
            this.CuentasModificacion = new System.Windows.Forms.ToolStripMenuItem();
            this.UsuariosMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.UsuariosAlta = new System.Windows.Forms.ToolStripMenuItem();
            this.UsuariosBaja = new System.Windows.Forms.ToolStripMenuItem();
            this.UsuariosModificacion = new System.Windows.Forms.ToolStripMenuItem();
            this.RolMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.RolAlta = new System.Windows.Forms.ToolStripMenuItem();
            this.RolBaja = new System.Windows.Forms.ToolStripMenuItem();
            this.RolModificacion = new System.Windows.Forms.ToolStripMenuItem();
            this.ConsultasMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.saldosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MovimientosMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.depositosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.retirosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transferenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FacturacionMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ListadosMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CambiarRolMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Salir = new System.Windows.Forms.ToolStripLabel();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripSplitButton1,
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.Salir,
            this.btnSalir});
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
            this.ABMmenu,
            this.ConsultasMenu,
            this.MovimientosMenu,
            this.FacturacionMenu,
            this.ListadosMenu,
            this.salirToolStripMenuItem,
            this.CambiarRolMenu});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(32, 22);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            this.toolStripSplitButton1.ButtonClick += new System.EventHandler(this.toolStripSplitButton1_ButtonClick);
            // 
            // ABMmenu
            // 
            this.ABMmenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClientesMenu,
            this.CuentasMenu,
            this.UsuariosMenu,
            this.RolMenu});
            this.ABMmenu.Name = "ABMmenu";
            this.ABMmenu.Size = new System.Drawing.Size(152, 22);
            this.ABMmenu.Text = "ABM";
            this.ABMmenu.Visible = false;
            this.ABMmenu.Click += new System.EventHandler(this.aBMClienteToolStripMenuItem_Click);
            // 
            // ClientesMenu
            // 
            this.ClientesMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClientesAlta,
            this.ClientesBaja,
            this.ClientesModificacion});
            this.ClientesMenu.Name = "ClientesMenu";
            this.ClientesMenu.Size = new System.Drawing.Size(152, 22);
            this.ClientesMenu.Text = "Clientes";
            this.ClientesMenu.Visible = false;
            // 
            // ClientesAlta
            // 
            this.ClientesAlta.Name = "ClientesAlta";
            this.ClientesAlta.Size = new System.Drawing.Size(152, 22);
            this.ClientesAlta.Text = "Alta";
            this.ClientesAlta.Visible = false;
            this.ClientesAlta.Click += new System.EventHandler(this.ClientesAlta_Click);
            // 
            // ClientesBaja
            // 
            this.ClientesBaja.Name = "ClientesBaja";
            this.ClientesBaja.Size = new System.Drawing.Size(152, 22);
            this.ClientesBaja.Text = "Baja";
            this.ClientesBaja.Visible = false;
            this.ClientesBaja.Click += new System.EventHandler(this.ClientesBaja_Click);
            // 
            // ClientesModificacion
            // 
            this.ClientesModificacion.Name = "ClientesModificacion";
            this.ClientesModificacion.Size = new System.Drawing.Size(152, 22);
            this.ClientesModificacion.Text = "Modificacion";
            this.ClientesModificacion.Visible = false;
            this.ClientesModificacion.Click += new System.EventHandler(this.ClientesModificacion_Click);
            // 
            // CuentasMenu
            // 
            this.CuentasMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CuentasAlta,
            this.CuentasBaja,
            this.CuentasModificacion});
            this.CuentasMenu.Name = "CuentasMenu";
            this.CuentasMenu.Size = new System.Drawing.Size(152, 22);
            this.CuentasMenu.Text = "Cuentas";
            this.CuentasMenu.Visible = false;
            // 
            // CuentasAlta
            // 
            this.CuentasAlta.Name = "CuentasAlta";
            this.CuentasAlta.Size = new System.Drawing.Size(144, 22);
            this.CuentasAlta.Text = "Alta";
            this.CuentasAlta.Visible = false;
            // 
            // CuentasBaja
            // 
            this.CuentasBaja.Name = "CuentasBaja";
            this.CuentasBaja.Size = new System.Drawing.Size(144, 22);
            this.CuentasBaja.Text = "Baja";
            this.CuentasBaja.Visible = false;
            this.CuentasBaja.Click += new System.EventHandler(this.bToolStripMenuItem_Click);
            // 
            // CuentasModificacion
            // 
            this.CuentasModificacion.Name = "CuentasModificacion";
            this.CuentasModificacion.Size = new System.Drawing.Size(144, 22);
            this.CuentasModificacion.Text = "Modificacion";
            this.CuentasModificacion.Visible = false;
            // 
            // UsuariosMenu
            // 
            this.UsuariosMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UsuariosAlta,
            this.UsuariosBaja,
            this.UsuariosModificacion});
            this.UsuariosMenu.Name = "UsuariosMenu";
            this.UsuariosMenu.Size = new System.Drawing.Size(152, 22);
            this.UsuariosMenu.Text = "Usuarios";
            this.UsuariosMenu.Visible = false;
            // 
            // UsuariosAlta
            // 
            this.UsuariosAlta.Name = "UsuariosAlta";
            this.UsuariosAlta.Size = new System.Drawing.Size(144, 22);
            this.UsuariosAlta.Text = "Alta";
            this.UsuariosAlta.Visible = false;
            // 
            // UsuariosBaja
            // 
            this.UsuariosBaja.Name = "UsuariosBaja";
            this.UsuariosBaja.Size = new System.Drawing.Size(144, 22);
            this.UsuariosBaja.Text = "Baja";
            this.UsuariosBaja.Visible = false;
            // 
            // UsuariosModificacion
            // 
            this.UsuariosModificacion.Name = "UsuariosModificacion";
            this.UsuariosModificacion.Size = new System.Drawing.Size(144, 22);
            this.UsuariosModificacion.Text = "Modificacion";
            this.UsuariosModificacion.Visible = false;
            this.UsuariosModificacion.Click += new System.EventHandler(this.UsuariosModificacion_Click);
            // 
            // RolMenu
            // 
            this.RolMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RolAlta,
            this.RolBaja,
            this.RolModificacion});
            this.RolMenu.Name = "RolMenu";
            this.RolMenu.Size = new System.Drawing.Size(152, 22);
            this.RolMenu.Text = "Roles";
            this.RolMenu.Visible = false;
            // 
            // RolAlta
            // 
            this.RolAlta.Name = "RolAlta";
            this.RolAlta.Size = new System.Drawing.Size(152, 22);
            this.RolAlta.Text = "Alta";
            this.RolAlta.Visible = false;
            this.RolAlta.Click += new System.EventHandler(this.RolAlta_Click);
            // 
            // RolBaja
            // 
            this.RolBaja.Name = "RolBaja";
            this.RolBaja.Size = new System.Drawing.Size(152, 22);
            this.RolBaja.Text = "Baja";
            this.RolBaja.Visible = false;
            // 
            // RolModificacion
            // 
            this.RolModificacion.Name = "RolModificacion";
            this.RolModificacion.Size = new System.Drawing.Size(152, 22);
            this.RolModificacion.Text = "Modificacion";
            this.RolModificacion.Visible = false;
            // 
            // ConsultasMenu
            // 
            this.ConsultasMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saldosToolStripMenuItem});
            this.ConsultasMenu.Name = "ConsultasMenu";
            this.ConsultasMenu.Size = new System.Drawing.Size(152, 22);
            this.ConsultasMenu.Text = "Consultas";
            this.ConsultasMenu.Visible = false;
            // 
            // saldosToolStripMenuItem
            // 
            this.saldosToolStripMenuItem.Name = "saldosToolStripMenuItem";
            this.saldosToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.saldosToolStripMenuItem.Text = "Saldos";
            this.saldosToolStripMenuItem.Visible = false;
            // 
            // MovimientosMenu
            // 
            this.MovimientosMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.depositosToolStripMenuItem1,
            this.retirosToolStripMenuItem,
            this.transferenciasToolStripMenuItem});
            this.MovimientosMenu.Name = "MovimientosMenu";
            this.MovimientosMenu.Size = new System.Drawing.Size(152, 22);
            this.MovimientosMenu.Text = "Movimientos";
            this.MovimientosMenu.Visible = false;
            this.MovimientosMenu.Click += new System.EventHandler(this.depositosToolStripMenuItem_Click);
            // 
            // depositosToolStripMenuItem1
            // 
            this.depositosToolStripMenuItem1.Name = "depositosToolStripMenuItem1";
            this.depositosToolStripMenuItem1.Size = new System.Drawing.Size(150, 22);
            this.depositosToolStripMenuItem1.Text = "Depositos";
            this.depositosToolStripMenuItem1.Visible = false;
            // 
            // retirosToolStripMenuItem
            // 
            this.retirosToolStripMenuItem.Name = "retirosToolStripMenuItem";
            this.retirosToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.retirosToolStripMenuItem.Text = "Retiros";
            this.retirosToolStripMenuItem.Visible = false;
            // 
            // transferenciasToolStripMenuItem
            // 
            this.transferenciasToolStripMenuItem.Name = "transferenciasToolStripMenuItem";
            this.transferenciasToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.transferenciasToolStripMenuItem.Text = "Transferencias";
            this.transferenciasToolStripMenuItem.Visible = false;
            // 
            // FacturacionMenu
            // 
            this.FacturacionMenu.Name = "FacturacionMenu";
            this.FacturacionMenu.Size = new System.Drawing.Size(152, 22);
            this.FacturacionMenu.Text = "Facturacion";
            this.FacturacionMenu.Visible = false;
            // 
            // ListadosMenu
            // 
            this.ListadosMenu.Name = "ListadosMenu";
            this.ListadosMenu.Size = new System.Drawing.Size(152, 22);
            this.ListadosMenu.Text = "Listados";
            this.ListadosMenu.Visible = false;
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Visible = false;
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // CambiarRolMenu
            // 
            this.CambiarRolMenu.Name = "CambiarRolMenu";
            this.CambiarRolMenu.Size = new System.Drawing.Size(152, 22);
            this.CambiarRolMenu.Text = "CambiarRol";
            this.CambiarRolMenu.Visible = false;
            this.CambiarRolMenu.Click += new System.EventHandler(this.cambiarRolToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            this.toolStripSeparator1.Visible = false;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            this.toolStripSeparator2.Click += new System.EventHandler(this.toolStripSeparator2_Click);
            // 
            // Salir
            // 
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(29, 22);
            this.Salir.Text = "Salir";
            // 
            // btnSalir
            // 
            this.btnSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(23, 22);
            this.btnSalir.Text = "btnSalir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 582);
            this.Controls.Add(this.toolStrip1);
            this.IsMdiContainer = true;
            this.Name = "FrmMain";
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
        private System.Windows.Forms.ToolStripMenuItem ABMmenu;
        private System.Windows.Forms.ToolStripMenuItem ClientesMenu;
        private System.Windows.Forms.ToolStripMenuItem CuentasMenu;
        private System.Windows.Forms.ToolStripMenuItem UsuariosMenu;
        private System.Windows.Forms.ToolStripMenuItem RolMenu;
        private System.Windows.Forms.ToolStripMenuItem ConsultasMenu;
        private System.Windows.Forms.ToolStripMenuItem saldosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MovimientosMenu;
        private System.Windows.Forms.ToolStripMenuItem depositosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem retirosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transferenciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FacturacionMenu;
        private System.Windows.Forms.ToolStripMenuItem ListadosMenu;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClientesAlta;
        private System.Windows.Forms.ToolStripMenuItem ClientesBaja;
        private System.Windows.Forms.ToolStripMenuItem ClientesModificacion;
        private System.Windows.Forms.ToolStripMenuItem CuentasAlta;
        private System.Windows.Forms.ToolStripMenuItem CuentasBaja;
        private System.Windows.Forms.ToolStripMenuItem CuentasModificacion;
        private System.Windows.Forms.ToolStripMenuItem UsuariosAlta;
        private System.Windows.Forms.ToolStripMenuItem UsuariosBaja;
        private System.Windows.Forms.ToolStripMenuItem UsuariosModificacion;
        private System.Windows.Forms.ToolStripMenuItem RolAlta;
        private System.Windows.Forms.ToolStripMenuItem RolBaja;
        private System.Windows.Forms.ToolStripMenuItem RolModificacion;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel Salir;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.ToolStripMenuItem CambiarRolMenu;
    }
}