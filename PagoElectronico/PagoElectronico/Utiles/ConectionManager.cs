
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace PagoElectronico.Utiles
{
    public class ConectionManager
    {
          private static ConectionManager INSTANCE;

        private SqlConnection cnn;

        public static ConectionManager getInstance()
        {
            if (INSTANCE == null)
            {
                INSTANCE = new ConectionManager();
                INSTANCE.conectar();
            }

            return INSTANCE;
        }


        protected void conectar()
        {
            cnn = new SqlConnection((@"Server=.\sqlServer2008;  user=sa ;  password=gestiondedatos; database=Migracion;"));
           // cnn.ConnectionString = Properties.Settings.Default.cadenaConexion;
          
            try
            {
                cnn.Open();
                //System.Windows.Forms.MessageBox.Show("Conectado");
            }

            catch (Exception e)
            {
                //throw new Exception(e.Message);
                MessageBox.Show("Error: " + e.Message);
            }
        }


        public SqlDataReader consultar(String query)
        {
            SqlDataReader objReader = null;
            SqlCommand objCommand = new SqlCommand(query, cnn);
            objReader = objCommand.ExecuteReader();
            return objReader;
        }

        public DataSet consultarDataSet(String query)
        {
            SqlCommand objCommand = new SqlCommand(query, cnn);
            SqlDataAdapter adapter = new SqlDataAdapter(objCommand);
            DataSet datos = new DataSet();
            adapter.Fill(datos);
            return datos;
        }

        /*
         * Sirve tanto para insert, update como delete. 
         */
        public void insertar(String updateSql)
        {
            try
            {
                SqlCommand objCommand = new SqlCommand(updateSql, cnn);
                objCommand.ExecuteNonQuery();
            }

            catch (SqlException ex)
            {
                // Display error
                Console.WriteLine("Error: " + ex.ToString());
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        /* 
         * Sirve para ejecutar un store procedure con parámetro de salida (sólo uno, se podría ampliar si es necesario).
         * @nombreSp: nombre del store procedure a llamar.
         * @parametrosEntrada: rango de parámetros de entrada creados previamente, de tipo SqlParameter[].
         * @parametroSalida: parametro de salida creado previamente, de tipo SqlParameter.
         * Retorna: el valor del parámetro de salida de tipo object (castear al tipo adecuado).
         */
        public object ejecutarStoreProcedureConParametroDeSalida(String nombreSp, SqlParameter[] parametrosEntrada, SqlParameter parametroSalida)
        {
            SqlCommand cmd = null;
            try
            {                
                cmd = new SqlCommand(nombreSp, cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(parametrosEntrada);
                parametroSalida.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(parametroSalida);
                cmd.ExecuteNonQuery();                         
            }
            catch (SqlException ex)
            {
                
                Console.WriteLine("Error: " + ex.ToString());
                MessageBox.Show("Error: " + ex.Message);
                Program.hayError = true;
               
            }
            return cmd.Parameters[parametroSalida.ParameterName].Value;
        }

        public void ejecutarStoreProcedure(String nombreSp, SqlParameter[] parametrosEntrada)
        {
            SqlCommand cmd = null;
            try
            {
                cmd = new SqlCommand(nombreSp, cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(parametrosEntrada);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error: " + ex.ToString());
                MessageBox.Show("Error: " + ex.Message);
                Program.hayError = true;


            }
        }
    }
 }
