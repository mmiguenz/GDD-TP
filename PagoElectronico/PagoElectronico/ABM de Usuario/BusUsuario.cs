using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PagoElectronico.ABM_Cliente;

namespace PagoElectronico.ABM_de_Usuario
{
    public partial class BusUsuario : Form
    {
        FrmGenericIBusCli frm;

        public BusUsuario(FrmGenericIBusCli frm)
        {
            InitializeComponent();
            this.frm = frm;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            String sqlQuery = "select * from datiados.usuarios where username like  " + "'" + txbxUsername.Text + "%'";

            DataSet ds = Utiles.ConectionManager.getInstance().consultarDataSet(sqlQuery);


            grid.DataSource = ds.Tables[0];



        }

        private void button3_Click(object sender, EventArgs e)
        {
            String username = grid.CurrentRow.Cells[0].Value.ToString();

            DataSet ds = Utiles.ConectionManager.getInstance().consultarDataSet("select * from datiados.usuarios where username = "+"'"+username+"'");

            frm.llenarDatos (ds.Tables[0]);

            this.Hide();



              



        }

        private void button2_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void limpiar()
        {
            grid.DataSource = null; 
            
        }









    }
}
