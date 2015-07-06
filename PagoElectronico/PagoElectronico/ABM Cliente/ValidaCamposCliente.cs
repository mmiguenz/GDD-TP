using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;

namespace PagoElectronico.ABM_Cliente
{
    class ValidaCamposCliente
    {

        

        public static void validaNroDoc(TextBox t)
        {

            if (t.Text != "" && !System.Text.RegularExpressions.Regex.IsMatch(t.Text, "^[0-9]+$"))
            {
                MessageBox.Show("El camp Numero de documento debe contener solo numeros");

                t.Focus();
            }
            
          
        }


        public static bool validaNroDocBool(TextBox t)
        {

            if (t.Text != "" && !System.Text.RegularExpressions.Regex.IsMatch(t.Text, "^[0-9]+$"))
            {
                return false;
            }
            else 
                return true ;


        }



       


        public static void validaMail(TextBox t)
        {
            // return System.Text.RegularExpressions.Regex.IsMatch(p,"^ \w @ \w");
            if (t.Text != "" && !t.Text.Contains("@"))
            {
                MessageBox.Show("formato de mail incorrecto");
                t.Focus();


            }
        }



        public static void  validaExistenciaCliente(TextBox nrodoc ,ComboBox tipodoc)



        {


            if (nrodoc.Text.Trim() != "" && validaNroDocBool(nrodoc))
            {

                String qrySql = "select * from datiados.clientes ";
                qrySql += " where nro_doc = " + nrodoc.Text;
                qrySql += " and cod_tipo_doc= " + tipodoc.SelectedValue;


                DataSet ds = Utiles.ConectionManager.getInstance().consultarDataSet(qrySql);

                if (ds.Tables[0].Rows.Count == 1)
                {
                    MessageBox.Show("El cliente ya existe en el sistema!");
                    nrodoc.Text = null;


                }


            }
        }



     
    }
}
