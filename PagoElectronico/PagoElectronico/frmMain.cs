using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PagoElectronico.ABM_Cliente;

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
            menus.Add(CuentasBaja);
            menus.Add(CuentasModificacion);
            menus.Add(UsuariosMenu);
            menus.Add(UsuariosAlta);
            menus.Add(UsuariosBaja);
            menus.Add(UsuariosModificacion);
            menus.Add(RolMenu);
            menus.Add(RolAlta);
            menus.Add(RolBaja);
            menus.Add(RolModificacion);
            menus.Add(FuncionalidadesMenu);
            menus.Add(FuncionalidadesAlta);
            menus.Add(FuncionalidadesBaja);
            menus.Add(FuncionalidadesModificacion);
            menus.Add(ConsultasMenu);
            menus.Add(MovimientosMenu);
            menus.Add(FacturacionMenu);
            menus.Add(ListadosMenu);
            menus.Add(CambiarRolMenu);
            


                






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

        private void UsuariosModificacion_Click(object sender, EventArgs e)
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

       
       

       
    }
}
