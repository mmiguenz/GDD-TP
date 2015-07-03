using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PagoElectronico.ABM_Rol
{
    public partial class AltaRol : Form
    {

        private Dictionary<String,int> funcDict = new Dictionary<String,int>();

        public AltaRol()
        {
            InitializeComponent();
            llenarFuncionalidades();
            grbxListas.Enabled = false;
            btnGrabar.Enabled = false;
        }

        private void llenarFuncionalidades()
        {
          
            
            DataSet  ds = Utiles.ConectionManager.getInstance().consultarDataSet("select * from datiados.Funcionalidades order by id_func");

            llenarDiccionario(ds);
            
            llenarListBox(ds);
            
            


            /* lstBxFunc.DataSource = ds.Tables[0];
            lstBxFunc.DisplayMember = "descripcion";
            lstBxFunc.ValueMember = "id_func";*/



        }

        private void llenarListBox(DataSet ds)
        {
            foreach (DataRow r in ds.Tables[0].Rows)
            {
                lstBxFunc.Items.Add(r.Field<String>("descripcion"));
            }

        }

        private void llenarDiccionario(DataSet ds)
        {
           foreach (DataRow r in ds.Tables[0].Rows)
           {
               funcDict.Add(r.Field<String>("descripcion"),r.Field<int>("id_func"));

           }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txbxNombre_Leave(object sender, EventArgs e)
        {
           txbxNombre.Text = txbxNombre.Text.Trim();

           if (txbxNombre.Text == "")
           {
               btnGrabar.Enabled = false;
           }

           else 
           {           
                  DataSet ds = Utiles.ConectionManager.getInstance().consultarDataSet("select * from datiados.roles where nombre = " + "'" + txbxNombre.Text + "'");

                   if (ds.Tables[0].Rows.Count > 0)
                   {
                       MessageBox.Show("Ya existe un rol con ese nombre");
                       txbxNombre.Focus();

                   }
                   else
                   {
                       grbxListas.Enabled = true;
                       btnGrabar.Enabled = true;

                   }

               }
           }

            
        

        private void btnAgregarTodas_Click(object sender, EventArgs e)
        {
            lstbxFunAgre.Items.AddRange(lstBxFunc.Items);
            lstBxFunc.Items.Clear();

           
         
            

        }


        private void btnQuitarTodas_Click(object sender, EventArgs e)
        {
            lstBxFunc.Items.AddRange(lstbxFunAgre.Items);
            lstbxFunAgre.Items.Clear();
            
           

        }

        private void bntAgregar_Click(object sender, EventArgs e)
        {
            if (lstBxFunc.SelectedItem != null)
            {
                lstbxFunAgre.Items.Add(lstBxFunc.SelectedItem);
                lstBxFunc.Items.Remove(lstBxFunc.SelectedItem);
            }

        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (lstbxFunAgre.SelectedItem != null)
            {
                lstBxFunc.Items.Add(lstbxFunAgre.SelectedItem);
                lstbxFunAgre.Items.Remove(lstbxFunAgre.SelectedItem);
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            grabar();
        }

        private void grabar()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = Properties.Settings.Default.ConnectionString;
            connection.Open();
            SqlTransaction trans = connection.BeginTransaction("t");
            try
            {


                darDeAltaRol(connection,trans);
                agregarFuncionalidades(connection,trans);

                trans.Commit();
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message);
                trans.Rollback();



            }
            finally
            {
                connection.Close();
                txbxNombre.Text = null;
                lstBxFunc.Items.AddRange(lstbxFunAgre.Items);
                lstbxFunAgre.Items.Clear();
                grbxListas.Enabled = false;

            }


        }



        private void darDeAltaRol(SqlConnection connection, SqlTransaction trans)
        {
            String strSql;
            strSql = "insert into datiados.roles values (" + "'" + txbxNombre.Text + "'" + "," + "1" + " )";

            SqlCommand objCommand = new SqlCommand(strSql, connection);
            objCommand.Transaction = trans;
            objCommand.ExecuteNonQuery(); 

        }

        private void agregarFuncionalidades(SqlConnection connection, SqlTransaction trans)
        {
            int idRol;

             String strSql;
            strSql = "select id_rol from datiados.roles with (nolock) where nombre= "+"'"+txbxNombre.Text+"'" ;

            DataSet ds = Utiles.ConectionManager.getInstance().consultarDataSet(strSql);

            idRol = ds.Tables[0].Rows[0].Field<int>("id_rol");

            
            
            foreach (Object item in lstbxFunAgre.Items)
            {
                String insertSql;
                int idFunc;

                 funcDict.TryGetValue(item.ToString(), out idFunc);

                

                insertSql = "insert into datiados.roles_funcionalidades values ("+idRol+","+idFunc+")";


                SqlCommand objCommand = new SqlCommand(insertSql, connection);
                objCommand.Transaction = trans;
                objCommand.ExecuteNonQuery();

                



            }






        }




        
    }
}
