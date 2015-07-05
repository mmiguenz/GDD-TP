using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using PagoElectronico.Utiles;

namespace PagoElectronico.Clases
{
    class Usuario
    {
        public int clienteID ;
        public String nombreCompletoCliente;
        public String  nombreUsuario;
        public Rol rol;
        public  Decimal  nroDoc ;


        public Usuario(String usuarioN)
        {
            this.nombreUsuario = usuarioN;
            this.clienteID = leerCliente(usuarioN);
            llenarAtributos();

          




        }

        private void llenarAtributos()
        {
            String sqlQuery;

            sqlQuery = " select nombre, apellido,nro_doc from datiados.clientes  where id =  " + clienteID;

                DataSet ds = Utiles.ConectionManager.getInstance().consultarDataSet(sqlQuery);

                DataRow r = ds.Tables[0].Rows[0];

                nombreCompletoCliente = r.Field<String>("nombre") + " " + r.Field<String>("apellido");
                nroDoc = r.Field<Decimal>("nro_doc");





        }


        

        

        private int leerCliente(String usr)
        {
            String sqlQuery;

            sqlQuery = "Select  clienteID  from Datiados.Usuarios";
            sqlQuery += " where username =  " +"'"+usr+"'";
            


           



            DataSet da = ConectionManager.getInstance().consultarDataSet(sqlQuery);

            return da.Tables[0].Rows[0].Field<int>("clienteID");


        }

        public void setiarRol(int  rolID)
        {
            rol= new Rol(rolID);

        }

    }
}
