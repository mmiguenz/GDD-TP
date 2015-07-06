using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PagoElectronico.Facturacion
{
    public partial class Facturacion : Form
    {
        public Facturacion()
        {
            InitializeComponent();
            llenarNombre();
        }

        private void llenarNombre()
        {
            txbxNombreCli.Text = Program.usr.nombreCompletoCliente;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            facturar();
            Program.HayError = false;
        }

        private void facturar()
        {
            SqlParameter[] parametros = new SqlParameter[] { new SqlParameter("@clienteID", Program.usr.clienteID),
                                                             new SqlParameter("@fecha",DateTime.Parse(Program.getDate()))};

            Utiles.ConectionManager.getInstance().ejecutarStoreProcedure("datiados.facturar", parametros);

            if (!Program.HayError)
            {
                MessageBox.Show("Grabacion Exitosa !");

            }



        }
    }
}
