using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoElectronico.ABM_Cliente
{
    class ValidaCamposCliente
    {

        public static bool validaNroDoc(char[]  n)
        {
           foreach (char c in n) {

               if ( ! char.IsDigit(c)){

                   return false;

               }

           }

           return true;
        }



        public  static bool validaMail(string p)
        {
          // return System.Text.RegularExpressions.Regex.IsMatch(p,"^ \w @ \w");

           return  p.Contains("@");
        }
    }
}
