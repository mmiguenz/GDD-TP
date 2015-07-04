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
            this.btnMenu = new System.Windows.Forms.ToolStripSplitButton();
            this.ABMmenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ClientesMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ClientesAlta = new System.Windows.Forms.ToolStripMenuItem();
            this.ClientesBaja = new System.Windows.Forms.ToolStripMenuItem();
            this.ClientesModificacion = new System.Windows.Forms.ToolStripMenuItem();
            this.CuentasMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.CuentasAlta = new System.Windows.Forms.ToolStripMenuItem();
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
            this.MovimientosMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.depositos = new System.Windows.Forms.ToolStripMenuItem();
            this.retiros = new System.Windows.Forms.ToolStripMenuItem();
            this.transferencias = new System.Windows.Forms.ToolStripMenuItem();
            this.FacturacionMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ListadosMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CambiarRolMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Salir = new System.Windows.Forms.ToolStripLabel();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.btnCambiarPass = new System.Windows.Forms.ToolStripLabel();
            this.btnCambiarPwd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.btnMenu,
            this.toolStripSeparator1,
            this.Salir,
            this.btnSalir,
            this.toolStripSeparator3,
            this.btnCambiarPass,
            this.btnCambiarPwd,
            this.toolStripSeparator2});
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
            // btnMenu
            // 
            this.btnMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ABMmenu,
            this.MovimientosMenu,
            this.FacturacionMenu,
            this.ConsultasMenu,
            this.ListadosMenu,
            this.salirToolStripMenuItem,
            this.CambiarRolMenu});
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(32, 22);
            this.btnMenu.Text = "toolStripSplitButton1";
            this.btnMenu.ButtonClick += new System.EventHandler(this.toolStripSplitButton1_ButtonClick);
            // 
            // ABMmenu
            // 
            this.ABMmenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClientesMenu,
            this.CuentasMenu,
            this.UsuariosMenu,
            this.RolMenu});
            this.ABMmenu.Name = "ABMmenu";
            this.ABMmenu.Size = new System.Drawing.Size(171, 22);
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
            this.ClientesAlta.Size = new System.Drawing.Size(144, 22);
            this.ClientesAlta.Text = "Alta";
            this.ClientesAlta.Visible = false;
            this.ClientesAlta.Click += new System.EventHandler(this.ClientesAlta_Click);
            // 
            // ClientesBaja
            // 
            this.ClientesBaja.Name = "ClientesBaja";
            this.ClientesBaja.Size = new System.Drawing.Size(144, 22);
            this.ClientesBaja.Text = "Baja";
            this.ClientesBaja.Visible = false;
            this.ClientesBaja.Click += new System.EventHandler(this.ClientesBaja_Click);
            // 
            // ClientesModificacion
            // 
            this.ClientesModificacion.Name = "ClientesModificacion";
            this.ClientesModificacion.Size = new System.Drawing.Size(144, 22);
            this.ClientesModificacion.Text = "Modificacion";
            this.ClientesModificacion.Visible = false;
            this.ClientesModificacion.Click += new System.EventHandler(this.ClientesModificacion_Click);
            // 
            // CuentasMenu
            // 
            this.CuentasMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CuentasAlta,
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
            this.CuentasAlta.Click += new System.EventHandler(this.CuentasAlta_Click);
            // 
            // CuentasModificacion
            // 
            this.CuentasModificacion.Name = "CuentasModificacion";
            this.CuentasModificacion.Size = new System.Drawing.Size(144, 22);
            this.CuentasModificacion.Text = "Modificacion";
            this.CuentasModificacion.Visible = false;
            this.CuentasModificacion.Click += new System.EventHandler(this.CuentasModificacion_Click);
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
            this.UsuariosAlta.Click += new System.EventHandler(this.UsuariosAlta_Click);
            // 
            // UsuariosBaja
            // 
            this.UsuariosBaja.Name = "UsuariosBaja";
            this.UsuariosBaja.Size = new System.Drawing.Size(144, 22);
            this.UsuariosBaja.Text = "Baja";
            this.UsuariosBaja.Visible = false;
            this.UsuariosBaja.Click += new System.EventHandler(this.UsuariosBaja_Click);
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
            this.RolAlta.Size = new System.Drawing.Size(144, 22);
            this.RolAlta.Text = "Alta";
            this.RolAlta.Visible = false;
            this.RolAlta.Click += new System.EventHandler(this.RolAlta_Click);
            // 
            // RolBaja
            // 
            this.RolBaja.Name = "RolBaja";
            this.RolBaja.Size = new System.Drawing.Size(144, 22);
            this.RolBaja.Text = "Baja";
            this.RolBaja.Visible = false;
            this.RolBaja.Click += new System.EventHandler(this.RolBaja_Click);
            // 
            // RolModificacion
            // 
            this.RolModificacion.Name = "RolModificacion";
            this.RolModificacion.Size = new System.Drawing.Size(144, 22);
            this.RolModificacion.Text = "Modificacion";
            this.RolModificacion.Visible = false;
            this.RolModificacion.Click += new System.EventHandler(this.RolModificacion_Click);
            // 
            // ConsultasMenu
            // 
            this.ConsultasMenu.Name = "ConsultasMenu";
            this.ConsultasMenu.Size = new System.Drawing.Size(171, 22);
            this.ConsultasMenu.Text = "Consulta De Saldo";
            this.ConsultasMenu.Visible = false;
            this.ConsultasMenu.Click += new System.EventHandler(this.ConsultasMenu_Click);
            // 
            // MovimientosMenu
            // 
            this.MovimientosMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.depositos,
            this.retiros,
            this.transferencias});
            this.MovimientosMenu.Name = "MovimientosMenu";
            this.MovimientosMenu.Size = new System.Drawing.Size(171, 22);
            this.MovimientosMenu.Text = "Movimientos";
            this.MovimientosMenu.Visible = false;
            this.MovimientosMenu.Click += new System.EventHandler(this.depositosToolStripMenuItem_Click);
            // 
            // depositos
            // 
            this.depositos.Name = "depositos";
            this.depositos.Size = new System.Drawing.Size(152, 22);
            this.depositos.Text = "Depositos";
            this.depositos.Visible = false;
            // 
            // retiros
            // 
            this.retiros.Name = "retiros";
            this.retiros.Size = new System.Drawing.Size(152, 22);
            this.retiros.Text = "Retiros";
            this.retiros.Visible = false;
            // 
            // transferencias
            // 
            this.transferencias.Name = "transferencias";
            this.transferencias.Size = new System.Drawing.Size(152, 22);
            this.transferencias.Text = "Transferencias";
            this.transferencias.Visible = false;
            // 
            // FacturacionMenu
            // 
            this.FacturacionMenu.Name = "FacturacionMenu";
            this.FacturacionMenu.Size = new System.Drawing.Size(171, 22);
            this.FacturacionMenu.Text = "Facturacion";
            this.FacturacionMenu.Visible = false;
            // 
            // ListadosMenu
            // 
            this.ListadosMenu.Name = "ListadosMenu";
            this.ListadosMenu.Size = new System.Drawing.Size(171, 22);
            this.ListadosMenu.Text = "Listado Estadistico";
            this.ListadosMenu.Visible = false;
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Visible = false;
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // CambiarRolMenu
            // 
            this.CambiarRolMenu.Name = "CambiarRolMenu";
            this.CambiarRolMenu.Size = new System.Drawing.Size(171, 22);
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
            // btnCambiarPass
            // 
            this.btnCambiarPass.Name = "btnCambiarPass";
            this.btnCambiarPass.Size = new System.Drawing.Size(102, 22);
            this.btnCambiarPass.Text = "CambiarPassword";
            // 
            // btnCambiarPwd
            // 
            this.btnCambiarPwd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCambiarPwd.Image = ((System.Drawing.Image)(resources.GetObject("btnCambiarPwd.Image")));
            this.btnCambiarPwd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCambiarPwd.Name = "btnCambiarPwd";
            this.btnCambiarPwd.Size = new System.Drawing.Size(23, 22);
            this.btnCambiarPwd.Text = "toolStripButton1";
            this.btnCambiarPwd.Click += new System.EventHandler(this.btnCambiarPwd_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            this.toolStripSeparator3.Click += new System.EventHandler(this.toolStripSeparator2_Click);
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
        private System.Windows.Forms.ToolStripSplitButton btnMenu;
        private System.Windows.Forms.ToolStripMenuItem ABMmenu;
        private System.Windows.Forms.ToolStripMenuItem ClientesMenu;
        private System.Windows.Forms.ToolStripMenuItem CuentasMenu;
        private System.Windows.Forms.ToolStripMenuItem UsuariosMenu;
        private System.Windows.Forms.ToolStripMenuItem RolMenu;
        private System.Windows.Forms.ToolStripMenuItem ConsultasMenu;
        private System.Windows.Forms.ToolStripMenuItem MovimientosMenu;
        private System.Windows.Forms.ToolStripMenuItem depositos;
        private System.Windows.Forms.ToolStripMenuItem retiros;
        private System.Windows.Forms.ToolStripMenuItem transferencias;
        private System.Windows.Forms.ToolStripMenuItem FacturacionMenu;
        private System.Windows.Forms.ToolStripMenuItem ListadosMenu;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClientesAlta;
        private System.Windows.Forms.ToolStripMenuItem ClientesBaja;
        private System.Windows.Forms.ToolStripMenuItem ClientesModificacion;
        private System.Windows.Forms.ToolStripMenuItem CuentasAlta;
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
        private System.Windows.Forms.ToolStripLabel btnCambiarPass;
        private System.Windows.Forms.ToolStripButton btnCambiarPwd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}