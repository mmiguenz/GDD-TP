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
   

    public partial class AltaCuenta : Form, FrmGenericIBusCli
    {
        int clienteID;


        public AltaCuenta()
        {
            InitializeComponent();
            llenarCombos();
        }

        private void llenarCombos()
        {
            String queryCombos = "";

             queryCombos+="select id_categoria,descripcion from datiados.cuentaCategorias order by 1 ;";
              queryCombos+="select codigo,descripcion from datiados.paises order by 2;";
              queryCombos+="select moneda_id,descripcion from datiados.monedas ;";


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


            cmbxMoneda.SelectedItem = null;
            cmbxPais.SelectedItem = null;
            cmbxTipoCta.SelectedItem = null;







        }

        #region Miembros de FrmGenericIBusCli

        public void llenarDatos(DataTable dt)
        {
            DataRow r =  dt.Rows[0];
            txbxNombreCli.Text = r.Field<String>("nombre") + "  " + r.Field<String>("apellido");
            sugerirCta();
            gpbxCta.Enabled = true;

        }

        private void sugerirCta()
        {
            SqlParameter[] parametros = new SqlParameter[] {};

           DataSet ds =   Utiles.ConectionManager.getInstance().ejecutarStoreProcedureDevuelveDataSet("datiados.proximoNroCta", parametros);

           txbxNroCta.Text = ds.Tables[0].Rows[0].Field<String>("ProximoNro");
           


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
            txbxNroCta.Text = null;
            txbxNombreCli.Text = null;
            cmbxMoneda.SelectedItem = null;
            cmbxPais.SelectedItem = null;
            cmbxTipoCta.SelectedItem = null;
            gpbxCta.Enabled = false;
            Program.HayError = false;
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

             limpiar();
        }


        private void grabar()
        {
           

                SqlParameter[] parametros = new SqlParameter[] {new SqlParameter("@NroCta", txbxNroCta.Text),
                                                            new SqlParameter("@Categoria",cmbxTipoCta.SelectedValue),
                                                            new SqlParameter("@pais",cmbxPais.SelectedValue),
                                                            new SqlParameter("@moneda",cmbxMoneda.SelectedValue),
                                                            new SqlParameter("@FechaCreac",DateTime.Parse(Program.getDate())),
                                                            new SqlParameter("@clienteID",clienteID)  
                                                                };
                Utiles.ConectionManager.getInstance().ejecutarStoreProcedure("datiados.Cuenta_agregar", parametros);


            
           
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
    }
}
