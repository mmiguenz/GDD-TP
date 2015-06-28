using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using PagoElectronico.Clases;

namespace PagoElectronico
{
    static class Program
    {

        public static bool HayError ;
        public static Usuario usr;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmLogin());
        }


        public static void InstanciarUsuario(String username )
        {
            usr = new Usuario(username);




        }

        public static void setiarRol(int rolID)
        {
            usr.setiarRol(rolID);

        }


        public static String getDate()
        {
            
            return Properties.Settings.Default.FechaSistema;
            
        }





    }
}
