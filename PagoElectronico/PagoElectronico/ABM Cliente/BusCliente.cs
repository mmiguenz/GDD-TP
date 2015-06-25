using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PagoElectronico.ABM_Cliente
{
    public partial class BusCliente : Form
    {
        private ModifCliente frm;
        private EliminaCliente frm2;

        public BusCliente()
        {
            InitializeComponent();
        }

        public BusCliente(ModifCliente modif)
        {
            this.frm = modif;
            InitializeComponent();
            llenarCombos();
        }

        public BusCliente(EliminaCliente elim)
        {
            this.frm2 = elim;
            InitializeComponent();
            llenarCombos();
        }

        private void llenarCombos()
        {
            DataTable dt = Utiles.ConectionManager.getInstance().consultarDataSet("select * from datiados.tipodoc ").Tables[0];
            cmbTipoDoc.DataSource = dt;
            cmbTipoDoc.DisplayMember = "descripcion";
            cmbTipoDoc.ValueMember = "cod_doc";
        }

        private void groupFiltrosBus_Enter(object sender, EventArgs e)
        {
            
        }

        private void btnBus_Click(object sender, EventArgs e)
        {
          
            SqlParameter[] parametrosEntrada = new SqlParameter[] {
                          
                new SqlParameter("@nombre", txbxNombre.Text),
                new SqlParameter("@apellido", txbxApellido.Text),
                new SqlParameter("@mail", txbxMail.Text),
                new SqlParameter("@codTipoDoc",(cmbTipoDoc.SelectedValue==null )? DBNull.Value : cmbTipoDoc.SelectedValue ), 
                new SqlParameter("@nroDoc", (txbxNroDoc.Text == "")? (object)DBNull.Value : Int32.Parse(txbxNroDoc.Text.ToString()) )
                
            };

           

            DataTable dt = Utiles.ConectionManager.getInstance().ejecutarStoreProcedureDevuelveDataSet("datiados.cliente_buscar", parametrosEntrada).Tables[0];


            dgvcli.DataSource = dt;
            
            

          //  dgvcli.DataMember = "clientes";


        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txbxApellido.Text = null;
            txbxMail.Text = null;
            txbxNombre.Text = null;
            txbxNroDoc.Text = null;
            cmbTipoDoc.SelectedItem = null;
            dgvcli.DataSource = null;

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Int32 clienteID = Convert.ToInt32(dgvcli.CurrentRow.Cells[0].Value);


            SqlParameter[] parametrosEntrada = new SqlParameter[] {
                          
                new SqlParameter("@clienteID", clienteID),
               
            };

            DataTable dt = Utiles.ConectionManager.
                                getInstance().
                                ejecutarStoreProcedureDevuelveDataSet("datiados.cliente_buscar_ID", parametrosEntrada)
                                .Tables[0];


            if (frm == null)
            {
                frm2.clienteID = clienteID;
                frm2.llenarDatos(dt);
            }
            else
            {
                frm.clienteID = clienteID;
                frm.llenarDatos(dt);
            }
            this.Hide();

            
        }

    }
}
