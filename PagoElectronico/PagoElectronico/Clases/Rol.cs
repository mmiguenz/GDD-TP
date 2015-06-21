using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using PagoElectronico.Utiles;

namespace PagoElectronico.Clases
{
    class Rol
    {

        public List<String> funcionalidades = new List<string>();

        public  Rol(int rolID)
        {
             cargarFuncionalidades(rolID);
        
        }

            private void  cargarFuncionalidades(int rolID)
        {
           

            SqlParameter[] parametrosEntrada = new SqlParameter[] {
                new SqlParameter("@RolID", rolID),              

            };
            
            DataSet  funcionalidadesDT = ConectionManager.getInstance().ejecutarStoreProcedureDevuelveDataSet( "datiados.FuncionalidadesDelRol_buscar", parametrosEntrada);
            
                foreach(DataRow r in funcionalidadesDT.Tables[0].Rows)
                {
                    funcionalidades.Add(r.Field<String>("funcionalidad"));


                }






        }

    }
}
