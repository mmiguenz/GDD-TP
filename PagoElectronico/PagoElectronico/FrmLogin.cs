using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using PagoElectronico.Utiles;
using System.Data.SqlClient;

namespace PagoElectronico
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

     

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Trim().Length == 0)
            {
                MessageBox.Show("El Campo Usuario no debe estar vacio");
            }
            else
            {
               
                login();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }



        private void login()
        {
          
            String usuario;
            String contraseña;
           

            usuario = txtUsuario.Text.ToString();
            contraseña =Encript.encriptar(txtContraseña.Text.ToString());

            SqlParameter[] parametrosEntrada = new SqlParameter[] {
                new SqlParameter("@USUARIO", usuario),
                new SqlParameter("@Contraseña", contraseña)

            };


                ConectionManager.getInstance().ejecutarStoreProcedure("loguear", parametrosEntrada);

                if (Program.hayError)
                {
                    txtContraseña.Text = null;

                    Program.hayError = false;

                }
                else
                {
                    this.Hide();
                   frmMain main = new frmMain();
                   main.Show();




                }




        }



    }
}
