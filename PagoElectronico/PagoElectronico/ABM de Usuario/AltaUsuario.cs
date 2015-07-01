using System;
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


    public partial class AltaUsuario : Form,FrmGenericIBusCli

    {
        private Int32 clienteID=0;

        public AltaUsuario()
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
            AsignarRoles asigR = new AsignarRoles(txbxUsrName.Text);
            asigR.Show();            
            limpiar();

            

        }

        private void grabar()
        {
            String pass = Utiles.Encript.encriptar(txbxPass.Text);
            String respSecre = Utiles.Encript.encriptar(txbxResp.Text);


            SqlParameter[] parametros = new SqlParameter[] {
            


                new SqlParameter("@username",txbxUsrName.Text),
                new SqlParameter("@pass",pass),
                new SqlParameter("@pregunta",txbxPregunta.Text),
                new SqlParameter("@resp", respSecre),
                new SqlParameter("@clienteID",(this.clienteID == 0)?(object) DBNull.Value: clienteID ),
                new SqlParameter("@fechaCreacion",DateTime.Parse(Program.getDate())),
                new SqlParameter("@fechaModif",DateTime.Parse( Program.getDate()))
                
            };


            Utiles.ConectionManager.getInstance().ejecutarStoreProcedure("datiados.Usuario_agregar", parametros);

            if (!Program.HayError)
            {
                MessageBox.Show("Grabacion Exitosa!! ");

            }
        }




     

        void FrmGenericIBusCli.llenarDatos(DataTable dt)
        {
           
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

       
       
    }


}
