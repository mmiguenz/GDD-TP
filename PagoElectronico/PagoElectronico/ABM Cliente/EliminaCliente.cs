﻿using System;
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
    public partial class EliminaCliente : Form,FrmGenericIBusCli
    {
        public Int32 clienteID;

        public EliminaCliente()
        {
            InitializeComponent();
            llenarCombos();
        }

        private void llenarCombos()
        {
            DataTable dtPaises = Utiles.ConectionManager.getInstance().consultarDataSet("select * from datiados.paises order by descripcion").Tables[0];
            DataTable dtTipoDoc = Utiles.ConectionManager.getInstance().consultarDataSet("select * from datiados.tipoDoc").Tables[0];


            this.cmbTipoDoc.DataSource = dtTipoDoc;
            this.cmbTipoDoc.DisplayMember = "descripcion";
            this.cmbTipoDoc.ValueMember = "cod_doc";

            this.cmbPais.DataSource = dtPaises;
            this.cmbPais.DisplayMember = "descripcion";
            this.cmbPais.ValueMember = "codigo";

            this.cmbPais.SelectedItem = null;
            this.cmbTipoDoc.SelectedItem = null;

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {

            if (validaCamposVacios())
            {


                SqlParameter[] parametrosEntrada = new SqlParameter[] {
            
                new SqlParameter("@clienteID", clienteID)
                
            };




                Utiles.ConectionManager.getInstance().ejecutarStoreProcedure("datiados.cliente_Eliminar", parametrosEntrada);

                if (!Program.HayError)
                {
                    MessageBox.Show("Grabacion Exitosa!");
                    limpiarControles();
                    groupBoxDomicilio.Enabled = false;
                    groupDatosGenerales.Enabled = false;
                }


            }
            else
            {
                MessageBox.Show("El formulario esta vacio!!");
            }
        }

        private bool validaCamposVacios()
        {
            return (txbxNroDoc.Text != null
              && cmbTipoDoc.SelectedItem != null
              && cmbPais.SelectedItem != null
              && txbxNombre.Text != null
              && txbxApellido.Text != null
              && txbxCalle.Text != null
              && txbxAltura.Text != null
              && txbxPiso.Text != null
              && txbxDto.Text != null
              && txbxMail.Text != null
              && Calendario.Text != null
              && txbxLocalidad.Text != null);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarControles();


        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


        private void limpiarControles()
        {

            txbxNroDoc.Text = null;
            cmbTipoDoc.SelectedItem = null;
            cmbPais.SelectedItem = null;
            txbxNombre.Text = null;
            txbxApellido.Text = null;
            txbxCalle.Text = null;
            txbxAltura.Text = null;
            txbxPiso.Text = null;
            txbxDto.Text = null;
            txbxMail.Text = null;
            Calendario.Text = null;
            txbxLocalidad.Text = null;
            txbxNombreCli.Text = null;
            



        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            BusCliente busqueda = new BusCliente(this);
            busqueda.Show();
            
        }
        
        public  void llenarDatos(DataTable dt)
            {
                DataRow dr = dt.Rows[0];

                
                txbxNombre.Text = dr.Field<String>("nombre");
                txbxApellido.Text = dr.Field<String>("apellido");
                txbxNombreCli.Text = txbxNombre.Text + "  " + txbxApellido.Text;               
                cmbTipoDoc.SelectedValue = dr.Field<decimal>("codtipodoc");
                cmbPais.SelectedValue = dr.Field<decimal>("codpais");
                txbxNroDoc.Text = dr.Field<decimal>("nrodoc").ToString();
                txbxMail.Text = dr.Field<String>("mail");
                txbxAltura.Text = dr.Field<decimal>("altura").ToString(); 
                txbxCalle.Text = dr.Field<String>("Calle");
                txbxDto.Text = dr.Field<String>("dto");                            
                txbxPiso.Text = dr.Field<decimal>("piso").ToString();
                txbxLocalidad.Text = dr.Field<String>("localidad");
                Calendario.Value = dr.Field<DateTime>("fechanacimiento");
              
           
            

                }

        public ComboBox getComboTipoDoc()
        {
            return cmbTipoDoc;
            }



     

        public void setClienteID(int clienteID)
        {
            this.clienteID = clienteID;
        }

    

        
       
       
    }
}
