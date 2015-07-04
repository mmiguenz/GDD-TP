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
    public partial class Deposito : Form
    {
        int tarjetaID; 

        public Deposito()
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

            cmbxCuenta.DataSource = ds.Tables[0];
            cmbxCuenta.DisplayMember = "nro_cuenta";

            cmbxMoneda.DataSource = ds.Tables[1];
            cmbxMoneda.DisplayMember = "descripcion";
            cmbxMoneda.ValueMember = "moneda_id";
            
        }

        private void llenarNombreCli()
        {
            txbxClieNom.Text = Program.usr.nombreCompletoCliente;



        }

        public void llenar(DataGridViewCellCollection celdas)
        {

            if (DateTime.Parse(celdas[3].Value.ToString()) >= DateTime.Parse(Program.getDate()))
            {
                txbxTarjeta.Text = celdas[1].Value.ToString();
                tarjetaID = (int)celdas[0].Value;

            }
            else
            {
                MessageBox.Show("La tarjeta seleccionada no debe estar vencida");

            }






        }

        private void button1_Click(object sender, EventArgs e)
        {
            BusTarjeta busT = new BusTarjeta(this);
            busT.Show();
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
            txbxTarjeta.Clear();
            cmbxCuenta.SelectedItem = null;
            cmbxMoneda.SelectedItem = null;
            txbxImporte.Enabled = false;
            
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
                
               
                if (Decimal.Parse(txbxImporte.Text) < 1)
                {
                  
                    MessageBox.Show("El importe debe ser mayor o igual a 1");
                    txbxImporte.Focus();

                }
                else
                {
                    /*
                    if (!validaSaldoSuficiente())
                    {
                    
                        MessageBox.Show("No posee saldo suficiente en la cuenta");
                        txbxImporte.Focus();


                    }
                    */
                }
            }

        }

        private bool validaSaldoSuficiente()
        {


            SqlParameter[] parametros = new SqlParameter[]{new SqlParameter("@nroCta",cmbxCuenta.Text),
                                                           new SqlParameter("@fechaTope",DateTime.Parse(Program.getDate()))};


            DataSet ds = Utiles.ConectionManager.getInstance().ejecutarStoreProcedureDevuelveDataSet("datiados.consultaSaldo", parametros);

            DataRow r = ds.Tables[0].Rows[0];

            return (r.Field<Decimal>("saldo") >= Decimal.Parse(txbxImporte.Text));
           

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {

            if (txbxImporte.Text != "" && txbxTarjeta.Text != "" && cmbxCuenta.Text != "" && cmbxMoneda.Text != "")
            {
                grabar();


            }
            else
            {
                MessageBox.Show("Ningun Campo debe estar vacio ");

            }


        }

        private void grabar()
        {
            SqlParameter[] parametros = new SqlParameter[] {new SqlParameter("@nroCta",cmbxCuenta.Text),   
                                                            new SqlParameter("@importe",Decimal.Parse(txbxImporte.Text)),
                                                            new SqlParameter("@moneda",cmbxMoneda.SelectedValue),
                                                            new SqlParameter("@tarjetaID",tarjetaID),
                                                            new SqlParameter("@Fecha",DateTime.Parse(Program.getDate()))};

            Utiles.ConectionManager.getInstance().ejecutarStoreProcedure("datiados.Deposito_agregar", parametros);

            if (!Program.HayError)
                MessageBox.Show("Grabacion Exitosa!");


        }



        private void cmbxCuenta_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txbxImporte.Enabled = true;
        }

       
    }
}
