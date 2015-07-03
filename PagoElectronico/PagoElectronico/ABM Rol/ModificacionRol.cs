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
    public partial class ModificacionRol : Form
    {

        private Dictionary<String,int> funcDict = new Dictionary<String,int>();
        private List<String> funcAnteriores = new List<string>();

        public ModificacionRol()
        {
            InitializeComponent();
            llenarComboRoles();
            grbxListas.Enabled = false;
            btnGrabar.Enabled = false;
        }

        private void llenarComboRoles()
        {
            DataSet ds = Utiles.ConectionManager.getInstance().consultarDataSet("select * from datiados.roles");

            cmbxRol.DataSource = ds.Tables[0];
            cmbxRol.DisplayMember = "nombre";
            cmbxRol.ValueMember = "id_rol";



                        
        }

        private void llenarFuncionalidades()
        {
          
            
            DataSet  ds = Utiles.ConectionManager.getInstance().consultarDataSet("select * from datiados.Funcionalidades order by id_func");

            llenarDiccionario(ds);
         

            SqlParameter[] parametros = new SqlParameter[] {new SqlParameter("@id_rol",cmbxRol.SelectedValue) };


            DataSet dsF = Utiles.ConectionManager.getInstance().ejecutarStoreProcedureDevuelveDataSet("datiados.funcionalidades_buscar", parametros);

            llenarListBox(dsF);


            DataSet dsRol = Utiles.ConectionManager.getInstance().consultarDataSet("select estado from datiados.roles where id_rol= "+cmbxRol.SelectedValue);

            ckbxHabilitado.Checked = dsRol.Tables[0].Rows[0].Field<bool>("estado");


            ckbxHabilitado.Enabled = true;

            if (ckbxHabilitado.Checked)
            {
                ckbxHabilitado.Enabled = false;

            }

            
            


            /* lstBxFunc.DataSource = ds.Tables[0];
            lstBxFunc.DisplayMember = "descripcion";
            lstBxFunc.ValueMember = "id_func";*/



        }

        private void llenarListBox(DataSet ds)
        {
                       
            foreach (DataRow r in ds.Tables[0].Rows)
            {
                lstbxFunAgre.Items.Add(r.Field<String>("descripcion"));
                funcAnteriores.Add(r.Field<String>("descripcion"));
                
            }

            foreach (DataRow r in ds.Tables[1].Rows)
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
            limpiar();
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

            if (!Program.HayError)
            {
                MessageBox.Show("Grabacion Exitosa!");

            }

            limpiar();
        }

        private void grabar()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = Properties.Settings.Default.ConnectionString;
            connection.Open();
            SqlTransaction trans = connection.BeginTransaction("t");
            try
            {


                eliminarAnteriores(connection,trans);
                agregarFuncionalidades(connection,trans);
                grabarEstadoRol(connection, trans);

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
                lstBxFunc.Items.AddRange(lstbxFunAgre.Items);
                lstbxFunAgre.Items.Clear();
                grbxListas.Enabled = false;

            }


        }



        private void eliminarAnteriores(SqlConnection connection, SqlTransaction trans)
        {
            foreach (String func in funcAnteriores)
            {
                String strSql;
                int idfun;
                funcDict.TryGetValue(func, out idfun);
                strSql = "delete from datiados.roles_funcionalidades " ;
                strSql += "where id_func= " + idfun;
                strSql += " and id_rol = " + cmbxRol.SelectedValue;




              SqlCommand objCommand = new SqlCommand(strSql, connection);
               objCommand.Transaction = trans;
               objCommand.ExecuteNonQuery(); 


            }


            

          

        }

        private void agregarFuncionalidades(SqlConnection connection, SqlTransaction trans)
        {
            
            
            
            foreach (Object item in lstbxFunAgre.Items)
            {
                String insertSql;
                int idFunc;

                 funcDict.TryGetValue(item.ToString(), out idFunc);

                

                insertSql = "insert into datiados.roles_funcionalidades values ("+cmbxRol.SelectedValue+","+idFunc+")";


                SqlCommand objCommand = new SqlCommand(insertSql, connection);
                objCommand.Transaction = trans;
                objCommand.ExecuteNonQuery();

                



            }

          

        }


        private void grabarEstadoRol(SqlConnection connection, SqlTransaction trans)
        {
            String UpdateSql;
            int habilitado;

            if (ckbxHabilitado.Checked)
                habilitado = 1;
            else habilitado = 0;


            UpdateSql = "update datiados.roles set estado = " + habilitado;
            UpdateSql += " where id_rol= " + cmbxRol.SelectedValue;



            SqlCommand objCommand = new SqlCommand(UpdateSql, connection);
            objCommand.Transaction = trans;
            objCommand.ExecuteNonQuery();

                




        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            cmbxRol.Enabled = false;
            llenarFuncionalidades();
            grbxListas.Enabled = true;
            btnGrabar.Enabled = true;
        }

        private void limpiar()
        {
            funcDict.Clear();
            funcAnteriores.Clear();
            lstbxFunAgre.Items.Clear();
            lstBxFunc.Items.Clear();
            funcAnteriores.Clear();
            lstBxFunc.Items.Clear();
            cmbxRol.Enabled = true;
            grbxListas.Enabled = false;
            btnGrabar.Enabled = false;




        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        
    }
}
