﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using PagoElectronico.ABM_Cliente;
namespace PagoElectronico.ABM_de_Usuario
{


    public partial class EliminacionUsuario : Form,FrmGenericIBusCli

    {
        private Int32 clienteID;

        public EliminacionUsuario()
        {
            InitializeComponent();
            llenarcombo();
            
        }

        private void llenarcombo()
        {
            String strSql = "Select id_rol,nombre from datiados.roles where estado = 1 ";

            DataSet ds = Utiles.ConectionManager.getInstance().consultarDataSet(strSql);

          


        }

        private void txbxUsrName_Leave(object sender, EventArgs e)
        {
           

            String strSql = "Select username from datiados.usuarios where username =  "+"'"+txbxUsrName.Text+"'" ;

            DataSet ds = Utiles.ConectionManager.getInstance().consultarDataSet(strSql);

            if(ds.Tables[0].Rows.Count > 0)
            {
                MessageBox.Show("Ya existe un usuario con ese nombre");
                txbxUsrName.Focus();
                
            }
                 
     
    }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();




        }

        private void limpiar()
        {
            txbxUsrName.Text = null;
            txbxPregunta.Text = null;
            txbxPass.Text = null;
            txbxResp.Text = null;
            txbxCliente.Text = null;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
        
            grabar();
                 
            limpiar();

            

        }

        private void grabar()
        {
            String pass = Utiles.Encript.encriptar(txbxPass.Text);
            String respSecre = Utiles.Encript.encriptar(txbxResp.Text);


            SqlParameter[] parametros = new SqlParameter[] {
            


                new SqlParameter("@username",txbxUsrName.Text),
                
                
            };


            Utiles.ConectionManager.getInstance().ejecutarStoreProcedure("datiados.Usuario_baja", parametros);

            if (!Program.HayError)
            {
                MessageBox.Show("Grabacion Exitosa!! ");

            }
        }




     

        void FrmGenericIBusCli.llenarDatos(DataTable dt)
        {
            DataRow r = dt.Rows[0];

            txbxUsrName.Text = r.Field<String>("username");
            txbxBusUsername.Text =r.Field<String>("username");
            txbxPass.Text = r.Field<String>("pwd");
            txbxPregunta.Text = r.Field<String>("preg_secr");
            txbxResp.Text = r.Field<String>("rta_secr");
            llenarCliente(r.Field<int?>("clienteID"));
            ckbxHabilitado.Checked = r.Field<bool>("estado");

            if (!ckbxHabilitado.Checked)
            {
                ckbxHabilitado.Enabled = true;

            }

        
            





           
        }

        private void llenarCliente(int? clienteID)
        {
            

            if (clienteID != null )
            {

                this.clienteID = (int)clienteID;

               DataSet ds = Utiles.ConectionManager.getInstance().consultarDataSet("select nombre,apellido from datiados.clientes where id = "+clienteID );

                DataRow r  = ds.Tables[0].Rows[0];
                txbxCliente.Text = r.Field<String>("nombre") + "  " + r.Field<String>("apellido");

            }
        }

        void FrmGenericIBusCli.setClienteID(int clienteID)
        {
            if (verificarQueNoEsteAsociado(clienteID))
            {
                this.clienteID = clienteID;
                llenarTextBoxCliente(clienteID);


            }


        }

        private void llenarTextBoxCliente(int clienteID)
        {
            String strQry = "select nombre, apellido from datiados.clientes where id = " + clienteID;

            DataSet ds = Utiles.ConectionManager.getInstance().consultarDataSet(strQry);
            DataRow dr = ds.Tables[0].Rows[0];

            String nombre = dr.Field<String>("nombre");
            String apellido = dr.Field<String>("apellido");

            this.txbxCliente.Text = nombre + " " + apellido; 

        }

        private bool verificarQueNoEsteAsociado(int clienteID)
        {
            String strQry = "select username from datiados.usuarios where clienteID = "+clienteID;

            DataSet ds = Utiles.ConectionManager.getInstance().consultarDataSet(strQry);

            if (ds.Tables[0].Rows.Count > 0)
            {
                MessageBox.Show("Debe Elegir un cliente que no se encuentre asociado a un Usuario");

                return false;
            }

            return true;



        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            ABM_Cliente.BusCliente busCli = new ABM_Cliente.BusCliente(this);

            busCli.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BusUsuario busUser = new BusUsuario(this);
            busUser.Show();

        }

       
       
    }


}
