using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PagoElectronico.Consulta_Saldos
{
    public partial class ConsultaSaldos : Form
    {
        int ClienteID;
        public ConsultaSaldos(int ClienteID)
        {
            InitializeComponent();
            this.ClienteID = ClienteID;
            cargarDatos();
        }

        private void cargarDatos()
        {
            String query ; 
            query  = "select nombre,apellido from datiados.clientes where id = "+ClienteID;
            query += "; select nro_cuenta from datiados.cuentas where cliente_ID = "+ClienteID;



            DataSet ds = Utiles.ConectionManager.getInstance().consultarDataSet(query);

            DataRow rCli = ds.Tables[0].Rows[0];

            txbxNombreCli.Text =  rCli.Field<String>("nombre") + "  "+ rCli.Field<String>("apellido");
            cmbxCuentas.DataSource = ds.Tables[1];
            cmbxCuentas.DisplayMember = "nro_cuenta";



        }

        private void btnListar_Click(object sender, EventArgs e)
        {

            SqlParameter[] parametros = new SqlParameter[] {new SqlParameter("@nroCta",cmbxCuentas.Text),
                                                            new SqlParameter("@fechaTope",DateTime.Parse(datepick.Text))  };


            DataSet ds = Utiles.ConectionManager.getInstance().ejecutarStoreProcedureDevuelveDataSet("datiados.consultaSaldo", parametros);

            ListadoSaldo list = new ListadoSaldo(ds);

            list.Show();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


    }
}

