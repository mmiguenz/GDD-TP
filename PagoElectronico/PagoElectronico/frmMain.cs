using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PagoElectronico.ABM_Cliente;
using System.Data.SqlClient;

namespace PagoElectronico
{
    public partial class FrmMain : Form
    {
        private List<ToolStripMenuItem> menus = new List<ToolStripMenuItem>();


        public FrmMain()
        {
    

            InitializeComponent();

            cargarBotones();
            asignarPermisos();
            gestionarCuentas();
            Program.HayError = false;

        }

        private void gestionarCuentas()
        {
            SqlParameter[] parametros = new SqlParameter[] { new SqlParameter("@fecha", DateTime.Parse(Program.getDate())) };

            Utiles.ConectionManager.getInstance().ejecutarStoreProcedure("datiados.gestionarCuentas",parametros);
        }

        private void asignarPermisos()
        {
           List<String> funcionalidades =  Program.usr.rol.funcionalidades;

            foreach (ToolStripMenuItem btnMenu in menus)
            {
                if (funcionalidades.Contains(btnMenu.Name))
                {
                    btnMenu.Visible = true;


                }



            }


      

  






        }

        private void cargarBotones()
        {
            menus.Add(ABMmenu);
            menus.Add(ClientesMenu);
            menus.Add(ClientesAlta);
            menus.Add(ClientesBaja);
            menus.Add(ClientesModificacion);
            menus.Add(CuentasMenu);
            menus.Add(CuentasAlta);
            menus.Add(CuentasModificacion);
            menus.Add(UsuariosMenu);
            menus.Add(UsuariosAlta);
            menus.Add(UsuariosBaja);
            menus.Add(UsuariosModificacion);
            menus.Add(RolMenu);
            menus.Add(RolAlta);
            menus.Add(RolBaja);
            menus.Add(RolModificacion);
            menus.Add(ConsultasMenu);
            menus.Add(MovimientosMenu);
            menus.Add(FacturacionMenu);
            menus.Add(ListadosMenu);
            menus.Add(CambiarRolMenu);
            menus.Add(depositos);
            menus.Add(retiros);
            menus.Add(transferencias);
            


                






        }

        private void frmMain_Load(object sender, EventArgs e)
        {


        }

        private void aBMClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void depositosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
            

        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {
           

        }

        private void bToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

   

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void cambiarRolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            this.Hide();
            login.Show();

        }

        private void ClientesAlta_Click(object sender, EventArgs e)
        {
           AltaCliente alta = new AltaCliente();

            alta.MdiParent = this;
            alta.Show();
        }

        private void ClientesModificacion_Click(object sender, EventArgs e)
        {
            ModifCliente modifCli = new ModifCliente();

            modifCli.MdiParent = this;
            modifCli.Show();
        }

        private void ClientesBaja_Click(object sender, EventArgs e)
        {
            EliminaCliente elim = new EliminaCliente();
            elim.MdiParent = this;

            elim.Show();
        }

        private void toolStripSeparator2_Click(object sender, EventArgs e)
        {

        }

        private void RolAlta_Click(object sender, EventArgs e)
        {
            ABM_Rol.AltaRol altaRol = new ABM_Rol.AltaRol();

            altaRol.MdiParent = this;

            altaRol.Show();
        }

        private void RolModificacion_Click(object sender, EventArgs e)
        {
            ABM_Rol.ModificacionRol modifRol = new ABM_Rol.ModificacionRol();
            modifRol.MdiParent = this;

            modifRol.Show();
        }

        private void RolBaja_Click(object sender, EventArgs e)
        {

            ABM_Rol.EliminaRol elimRol = new ABM_Rol.EliminaRol();
            elimRol.MdiParent = this;

            elimRol.Show();


        }

        private void UsuariosAlta_Click(object sender, EventArgs e)
        {
            ABM_de_Usuario.AltaUsuario altaUsr = new ABM_de_Usuario.AltaUsuario();
            altaUsr.MdiParent = this;

            altaUsr.Show();

        }

        private void UsuariosModificacion_Click(object sender, EventArgs e)
        {
            ABM_de_Usuario.ModificacionUsuario mofifUsr = new ABM_de_Usuario.ModificacionUsuario();
            mofifUsr.MdiParent = this;

            mofifUsr.Show();


        }

        private void UsuariosBaja_Click(object sender, EventArgs e)
        {

            ABM_de_Usuario.EliminacionUsuario elimUsr = new ABM_de_Usuario.EliminacionUsuario();
            elimUsr.MdiParent = this;

            elimUsr.Show();


        }

        private void CuentasAlta_Click(object sender, EventArgs e)
        {
             ABM_Cuenta.AltaCuenta altaCta =  new ABM_Cuenta.AltaCuenta();
             altaCta.MdiParent = this;
             altaCta.Show();
        }

        private void CuentasModificacion_Click(object sender, EventArgs e)
        {

            ABM_Cuenta.ModificacionCuenta modif = new ABM_Cuenta.ModificacionCuenta();
            modif.MdiParent = this;
            modif.Show();

        }

        

        private void ConsultasMenu_Click(object sender, EventArgs e)
        {
            Consulta_Saldos.ConsultaSaldos cons = new PagoElectronico.Consulta_Saldos.ConsultaSaldos(Program.usr.clienteID);
            cons.Show();

        }

        private void btnCambiarPwd_Click(object sender, EventArgs e)
        {

            ABM_de_Usuario.ModificacionUsuario modifPWD = new ABM_de_Usuario.ModificacionUsuario();
            ABM_de_Usuario.BusUsuario bus = new ABM_de_Usuario.BusUsuario(modifPWD);
            modifPWD.setAtCambioPass();

            bus.seleccionar(Program.usr.nombreUsuario);

            modifPWD.MdiParent = this;
            modifPWD.Show();

            



        }

        private void depositos_Click(object sender, EventArgs e)
        {
            Depositos.Deposito depo = new Depositos.Deposito();

            depo.MdiParent = this;
            depo.Show();
        }

        private void retiros_Click(object sender, EventArgs e)
        {
            Retiros.Retiro retiro = new Retiros.Retiro();
            retiro.MdiParent = this;
            retiro.Show();
            
        }

        private void transferencias_Click(object sender, EventArgs e)
        {
            Transferencias.Transferencia transf = new Transferencias.Transferencia();
            transf.MdiParent = this;
            transf.Show();
        }

        private void FacturacionMenu_Click(object sender, EventArgs e)
        {
            Facturacion.Facturacion fact = new Facturacion.Facturacion();
            fact.MdiParent = this;
            fact.Show();
        }

        private void btnAsocTarj_Click(object sender, EventArgs e)
        {
            ABM_Cliente.AsociarTarjetas asoc = new ABM_Cliente.AsociarTarjetas(Program.usr.clienteID);
            asoc.MdiParent = this;
            asoc.Show();
        }


       
       

       
    }
}
