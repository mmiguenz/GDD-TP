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
        public String  nombreUsuario;
        public Rol rol;


        public Usuario(String usuarioN)
        {
            this.nombreUsuario = usuarioN;
            this.clienteID = leerCliente(usuarioN);
          




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
