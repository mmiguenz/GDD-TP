using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PagoElectronico.Depositos
{
    public partial class BusTarjeta : Form
    {
        Deposito frmDeposito;
        DataTable dtTarjet;

        public BusTarjeta(Deposito frmDeposito)
        {
            InitializeComponent();
            this.frmDeposito = frmDeposito;
            llenarGrid();
        }


        public void llenarGrid()
        {
            SqlParameter[] parametros = new SqlParameter[] { new SqlParameter("@ClienteID", Program.usr.clienteID) };

            DataSet ds = Utiles.ConectionManager.getInstance().ejecutarStoreProcedureDevuelveDataSet("datiados.Tarjetas_buscar", parametros);
            dtTarjet = ds.Tables[0];

            gridTarjetas.DataSource = dtTarjet;

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {


            frmDeposito.llenar(gridTarjetas.CurrentRow.Cells);
            this.Hide();
          


        }

 


    }
}
