using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PagoElectronico
{
    public partial class FrmRol : Form
    {
        public FrmRol()
        {
            InitializeComponent();

        }


        public void llenarCombo(DataTable dt)
        {

            this.cmbRoles.DataSource = dt;
            this.cmbRoles.DisplayMember = "nombre";
            this.cmbRoles.ValueMember = "id_rol";




        }




        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Program.setiarRol(Int32.Parse(this.cmbRoles.SelectedValue.ToString()));
            FrmMain menu = new FrmMain();
            menu.Show();
            this.Hide();
              
          

           

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}