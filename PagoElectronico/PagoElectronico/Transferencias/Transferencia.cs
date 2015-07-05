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
    public partial class Transferencia : Form
    {


        public Transferencia()
        {
            InitializeComponent();
            llenarNombreCli();
            llenarCombos();
            limpiar();
        }

        private void llenarCombos()
        {
            String query = "select nro_cuenta from datiados.cuentas where cliente_id = " + Program.usr.clienteID;
            query += ";  select moneda_id,descripcion from datiados.monedas";


            DataSet ds = Utiles.ConectionManager.getInstance().consultarDataSet(query);

            cmbxCuentaOrg.DataSource = ds.Tables[0];
            cmbxCuentaOrg.DisplayMember = "nro_cuenta";

            cmbxMoneda.DataSource = ds.Tables[1];
            cmbxMoneda.DisplayMember = "descripcion";
            cmbxMoneda.ValueMember = "moneda_id";

        }

        private void llenarNombreCli()
        {
            txbxClieNom.Text = Program.usr.nombreCompletoCliente;



        }

      

       

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
            txbxImporte.Clear();
            cmbxCuentaOrg.SelectedItem = null;
            cmbxMoneda.SelectedItem = null;
            txbxImporte.Enabled = false;
            Program.HayError = false;
         

        }

        private void txbxImporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                //Para obligar a que sólo se introduzcan números 
                if (Char.IsDigit(e.KeyChar) || (Char.IsPunctuation(e.KeyChar) && e.KeyChar.ToString().Contains(",") || e.KeyChar.ToString().Contains(".")))
                {
                    e.Handled = false;
                }
                else
                    if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        //el resto de teclas pulsadas se desactivan 
                        e.Handled = true;
                    }
            }

            if (e.KeyChar.ToString() == ".")
            {
                e.KeyChar = char.Parse(",");

            }


        }

        private void txbxImporte_Leave(object sender, EventArgs e)
        {
            if (txbxImporte.Text != "")
            {


                if (Decimal.Parse(txbxImporte.Text) < 0)
                {

                    MessageBox.Show("El importe debe ser mayor o igual a 0");
                    txbxImporte.Focus();

                }
                else
                {
                    
                    if (!validaSaldoSuficiente())
                    {
                    
                        MessageBox.Show("No posee saldo suficiente en la cuenta");
                        txbxImporte.Focus();


                    }
                    
                }
            }

        }

        private bool validaSaldoSuficiente()
        {


            SqlParameter[] parametros = new SqlParameter[]{new SqlParameter("@nroCta",cmbxCuentaOrg.Text),
                                                           new SqlParameter("@fechaTope",DateTime.Parse(Program.getDate()))};


            DataSet ds = Utiles.ConectionManager.getInstance().ejecutarStoreProcedureDevuelveDataSet("datiados.consultaSaldo", parametros);

            DataRow r = ds.Tables[0].Rows[0];

            return (r.Field<Decimal>("saldo") >= Decimal.Parse(txbxImporte.Text));


        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
         
        }

     
        private void grabar()
        {
            SqlParameter[] parametros = new SqlParameter[] {new SqlParameter("@nroCta",cmbxCuentaOrg.Text),   
                                                            new SqlParameter("@importe",Decimal.Parse(txbxImporte.Text)),
                                                            new SqlParameter("@moneda",cmbxMoneda.SelectedValue),
                                                            new SqlParameter("@Fecha",DateTime.Parse(Program.getDate()))};

            Utiles.ConectionManager.getInstance().ejecutarStoreProcedure("datiados.Retiro_agregar", parametros);

            if (!Program.HayError)
                MessageBox.Show("Grabacion Exitosa!");


        }



        

        private void txbxImporte_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BusCuenta bus = new BusCuenta(this);
            bus.Show();
        }

       


    }
}
