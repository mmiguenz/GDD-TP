using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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

       
    }
}
