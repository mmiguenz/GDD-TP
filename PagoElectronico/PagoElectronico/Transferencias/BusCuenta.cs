using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PagoElectronico.Transferencias
{
    public partial class BusCuenta : Form
    {
        private Transferencia frmTran;

        public BusCuenta(Transferencia t)
        {
            InitializeComponent();
            frmTran = t;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            gridCuentas.DataSource = null;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            buscarCuentas();


        }

        private void buscarCuentas()
        {
            String nombre = txbxNom.Text.Trim();
            String apellido = txbxApe.Text.Trim();

            ;
             
            SqlParameter[] parametros = new SqlParameter[] {new SqlParameter("@nombre",nombre),
                                                            new SqlParameter("@apellido",apellido)};

            DataSet ds = Utiles.ConectionManager.getInstance().ejecutarStoreProcedureDevuelveDataSet("datiados.buscarCuentas", parametros);

            gridCuentas.DataSource = ds.Tables[0];



        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            String  nroCta = gridCuentas.CurrentRow.Cells[0].Value.ToString();
            frmTran.llenarCuentaDestino(nroCta);
            this.Hide();
        }
    }
}
