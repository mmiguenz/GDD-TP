using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace PagoElectronico.ABM_Cliente
{
   public  interface FrmGenericIBusCli
    {
       
         void llenarDatos(DataTable dt);



         void setClienteID(int clienteID);
    }
}
