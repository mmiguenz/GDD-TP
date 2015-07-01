using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PagoElectronico.ABM_de_Usuario
{
    public partial class AsignarRoles : Form
    {
        Dictionary<String, int> rolesDict;
        List<int> rolesViejos;
        List<int> rolesRolesNuevos;
        String username; 

        public AsignarRoles(String   username)
        {
            InitializeComponent();
            rolesDict = new Dictionary<string,int>();
            rolesRolesNuevos = new List<int>();
            rolesViejos =  new List<int>();
            this.username = username;
            leerRoles();
        }


        private void leerRoles()
        {

            SqlParameter[] parametros = new SqlParameter[] { new SqlParameter("@username", username) };

            DataSet ds = Utiles.ConectionManager.getInstance().ejecutarStoreProcedureDevuelveDataSet("datiados.RolesBuscar",parametros);

            llenarDiccionario(ds.Tables[0]);
            llenarRolesViejos(ds.Tables[1]);
            llenarListBox(ds.Tables[0]);



        }


        private void llenarRolesViejos(DataTable dataTable)
        {
            if (dataTable.Rows.Count > 0)
            {

                foreach (DataRow r in dataTable.Rows)
                {

                    rolesViejos.Add(r.Field<int>("id_rol"));




                }




            }




        }

        private void llenarDiccionario(DataTable dataTable)
        {

            if (dataTable.Rows.Count > 0)
            {

                foreach (DataRow r in dataTable.Rows)
                {
                    rolesDict.Add(r.Field<String>("nombre"), r.Field<int>("id_rol"));

                                       


                }


            }



        }


        private void llenarListBox(DataTable dt)
        {
            int pos = 0;
            foreach (DataRow r in dt.Rows)
            {
                String rol = r.Field<String>("nombre");
                int rolID ;
                cklstbxRoles.Items.Add(rol);

                rolesDict.TryGetValue(rol,out rolID );


                if (rolesViejos.Contains(rolID))
                {
                    cklstbxRoles.SetItemChecked(pos, true);
                    
                }


                pos++;

            }


            



        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            if (cklstbxRoles.CheckedItems.Count > 0)
            {
                grabarRoles();
                this.Hide();



            }else {

                MessageBox.Show("Debe Seleccionar al menos un Rol");    
            }

          





        }

        private void grabarRoles()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = Properties.Settings.Default.ConnectionString;
            connection.Open();
            SqlTransaction trans = connection.BeginTransaction("t");
            try
            {


                eliminarAnteriores(connection, trans);
                agregarRoles(connection, trans);
                

                trans.Commit();
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message);
                trans.Rollback("t");



            }
            finally
            {
                connection.Close();
                
            }

        }


        private void eliminarAnteriores(SqlConnection connection, SqlTransaction trans)
        {
            
            foreach( int id in rolesViejos)
                
            {
                String srtSql = "delete from datiados.usuarios_roles  ";
                srtSql += "where id_rol = " + id;


             SqlCommand objCommand = new SqlCommand(srtSql, connection);
            objCommand.Transaction = trans;
            objCommand.ExecuteNonQuery(); 

            }



        }


        private void agregarRoles(SqlConnection connection, SqlTransaction trans)
        {



            foreach (String  rol in cklstbxRoles.CheckedItems)
            {
                            int rolID;
                        rolesDict.TryGetValue(rol, out rolID);

                String srtSql = "insert into  datiados.usuarios_roles  ";
                srtSql += "values("+"'"+username+"'"+","+rolID+" )";


                SqlCommand objCommand = new SqlCommand(srtSql, connection);
                objCommand.Transaction = trans;
                objCommand.ExecuteNonQuery(); 



            }




        }











    }
}
