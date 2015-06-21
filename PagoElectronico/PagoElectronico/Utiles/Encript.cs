using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace PagoElectronico.Utiles
{
    class Encript
    {

        public static string encriptar(string input)
        {
            if (input.Length > 0)
            {
                //SHA256Managed provider = new SHA256Managed();
                SHA256CryptoServiceProvider provider = new SHA256CryptoServiceProvider();

                //LA primer sentencia es Para usuarios de Windows XP, si no funciona, comentarla y usar la segunda.

                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hashedBytes = provider.ComputeHash(inputBytes);

                StringBuilder output = new StringBuilder();

                for (int i = 0; i < hashedBytes.Length; i++)
                    output.Append(hashedBytes[i].ToString("x2").ToLower());

                return output.ToString();
            }
            else
                return input;
            
        }
    }
}
