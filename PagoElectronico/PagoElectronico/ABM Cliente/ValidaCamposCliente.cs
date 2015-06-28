using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PagoElectronico.ABM_Cliente
{
    class ValidaCamposCliente
    {

        public static void validaNroDoc(TextBox t )
        {

            if (t.Text != "" &&  !System.Text.RegularExpressions.Regex.IsMatch(t.Text, "^[0-9]+$") )
            {
                MessageBox.Show("El camp Numero de documento debe contener solo numeros");

                t.Focus();
            }
          
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
    }
}
