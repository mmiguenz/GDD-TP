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

namespace PagoElectronico.ABM_Cuenta
{
   

    public partial class ModificacionCuenta : Form, FrmGenericIBusCli
    {
        int clienteID;


        public ModificacionCuenta()
        {
            InitializeComponent();
            
        }

        private void llenarCombos()
        {
            String queryCombos = "";

             queryCombos+="select id_categoria,descripcion from datiados.cuentaCategorias order by 1 ;";
              queryCombos+="select codigo,descripcion from datiados.paises order by 2;";
              queryCombos+="select moneda_id,descripcion from datiados.monedas ;";
              queryCombos += "select id_estado,descripcion from datiados.cuentaEstados;";
              queryCombos += "select nro_cuenta from datiados.cuentas where cliente_ID = " + clienteID;
    



              DataSet ds = Utiles.ConectionManager.getInstance().consultarDataSet(queryCombos);

            cmbxTipoCta.DataSource= ds.Tables[0];
            cmbxTipoCta.DisplayMember = "descripcion";
            cmbxTipoCta.ValueMember = "id_categoria";
            
            cmbxPais.DataSource = ds.Tables[1];
            cmbxPais.DisplayMember = "descripcion";
            cmbxPais.ValueMember = "codigo";

            cmbxMoneda.DataSource = ds.Tables[2];
            cmbxMoneda.DisplayMember = "descripcion";
            cmbxMoneda.ValueMember = "moneda_id";


            cmbxCtas.DataSource = ds.Tables[4];
            cmbxCtas.DisplayMember = "nro_cuenta";
            
         

            cmbxEstadoCta.DataSource = ds.Tables[3];
            cmbxEstadoCta.DisplayMember = "descripcion";
            cmbxEstadoCta.ValueMember = "id_estado";


            cmbxMoneda.SelectedItem = null;
            cmbxPais.SelectedItem = null;
            cmbxTipoCta.SelectedItem = null;
            cmbxCtas.SelectedItem = null;
            cmbxEstadoCta.SelectedItem = null;
            







        }

        #region Miembros de FrmGenericIBusCli

        public void llenarDatos(DataTable dt)
        {
            DataRow r =  dt.Rows[0];
            txbxNombreCli.Text = r.Field<String>("nombre") + "  " + r.Field<String>("apellido");
            llenarCombos();
          
            gpbxCta.Enabled = true;

        }

 

        public void setClienteID(int clienteID)
        {
            this.clienteID = clienteID;
        }

        #endregion

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void limpiar()
        {
            cmbxCtas.SelectedItem = null;
            txbxNombreCli.Text = null;
            cmbxMoneda.SelectedItem = null;
            cmbxPais.SelectedItem = null;
            cmbxTipoCta.SelectedItem = null;
            gpbxCta.Enabled = false;
            cmbxEstadoCta.SelectedItem = null;
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
             if (valida())
            {
                grabar();


                   if (!Program.HayError)
            {
                MessageBox.Show("Grabacion Exitosa !!");
                limpiar();
            }

             }
                 

                 else
            {
                MessageBox.Show("Debe Completar Todos Los Campos");

            }

            
        }


        private void grabar()
        {


            SqlParameter[] parametros = new SqlParameter[] {new SqlParameter("@NroCta", cmbxCtas.Text),
                                                            new SqlParameter("@Categoria",cmbxTipoCta.SelectedValue),
                                                            new SqlParameter("@estadoCuenta",cmbxEstadoCta.SelectedValue),
                                                            new SqlParameter("@pais",cmbxPais.SelectedValue),
                                                            new SqlParameter("@moneda",cmbxMoneda.SelectedValue),
                                                             new SqlParameter("@fecha",DateTime.Parse(Program.getDate()))
                                                           
                                                                };
                Utiles.ConectionManager.getInstance().ejecutarStoreProcedure("datiados.Cuenta_modif", parametros);


            
           
        }

        private void btnBuscarCli_Click(object sender, EventArgs e)
        {
            BusCliente busCli = new BusCliente(this);
            busCli.Show();
        }

        private bool valida()
        {
            return cmbxTipoCta.SelectedItem != null && cmbxPais.SelectedItem != null && cmbxMoneda.SelectedItem != null;


        }

        private void cmbxCtas_SelectionChangeCommitted(object sender, EventArgs e)
        {
            String Query = "select cod_estado,cod_pais,categoria,cod_moneda from datiados.cuentas where nro_cuenta = " + "'" + cmbxCtas.Text + "'";

            DataSet ds = Utiles.ConectionManager.getInstance().consultarDataSet(Query);

            DataRow r = ds.Tables[0].Rows[0];

            cmbxEstadoCta.SelectedValue = r.Field<int>("cod_estado");
            cmbxMoneda.SelectedValue = r.Field<int>("cod_moneda");
            cmbxPais.SelectedValue =  r.Field<Decimal>("cod_pais");
            cmbxTipoCta.SelectedValue = r.Field<int>("categoria");




        }
    }
}
