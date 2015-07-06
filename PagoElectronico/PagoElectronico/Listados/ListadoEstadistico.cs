using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PagoElectronico.Listados
{
    public partial class ListadoEstadistico : Form
    {
        public ListadoEstadistico()
        {
            InitializeComponent();
            llenarDatos();
          
        }

        private void llenarDatos()
        {
            pickYear.Minimum = 1900;
            pickYear.Maximum = 2200;
            String query;
            query = "select trimestre from datiados.trimestre";
            query += "; select id,descripcion from datiados.tiposListados";

            DataSet ds = Utiles.ConectionManager.getInstance().consultarDataSet(query);

            cmbxTrimestre.DataSource = ds.Tables[0];
            cmbxTrimestre.DisplayMember = "trimestre";

            cmbxTipoListados.DataSource = ds.Tables[1];
            cmbxTipoListados.DisplayMember = "descripcion";
            cmbxTipoListados.ValueMember = "id";

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        private void cmbxTrimestre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnListar_Click(object sender, EventArgs e)
        {

            listar();


        }

        private void listar()
        {

            SqlParameter[] parametros = new SqlParameter[] { new SqlParameter("@anio",Int32.Parse(pickYear.Text.ToString())),
                                                              new SqlParameter("@trimestre",cmbxTrimestre.Text)};

            Int32 tipoListado = Int32.Parse( cmbxTipoListados.SelectedValue.ToString());
            String store ;
            
            
            switch (tipoListado){

                case 1:
                    store = "datiados.listado1";
                    break;

                case 2:
                    store = "datiados.listado2";
                    break;
                case 3:
                    store = "datiados.listado3";
                    break;
                case 4:
                    store = "datiados.listado4";
                    break;
                case 5:
                    store = "datiados.listado5";
                    break;
                default:
                    store = "";
                    break;

             }

            DataSet ds = Utiles.ConectionManager.getInstance().ejecutarStoreProcedureDevuelveDataSet(store, parametros);


            if (ds.Tables[0].Rows.Count > 0)
            {
                Listado list = new Listado(ds.Tables[0]);
                list.Show();
            }
            else
            {
                MessageBox.Show("No hay datos para listar");

            }




        }

       
    }
}
