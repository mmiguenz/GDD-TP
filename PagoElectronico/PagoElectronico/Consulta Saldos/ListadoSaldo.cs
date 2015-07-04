using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PagoElectronico.Consulta_Saldos
{
    public partial class ListadoSaldo : Form
    {
        public ListadoSaldo(DataSet ds)
        {
            InitializeComponent();
            gridSaldo.DataSource = ds.Tables[0];
            gridDepositos.DataSource = ds.Tables[1];
            gridRetiros.DataSource = ds.Tables[2];
            gridTransferencias.DataSource = ds.Tables[3];




        }
    }
}
