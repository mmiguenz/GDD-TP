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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            if (Program.usr != null)
            {
                this.txtUsuario.Text = Program.usr.nombreUsuario;

            }
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


                ConectionManager.getInstance().ejecutarStoreProcedure("datiados.loguear", parametrosEntrada);

                if (Program.HayError)
                {
                    txtContraseña.Text = null;

                    Program.HayError = false;

                }
                else
                {
                    this.Hide();
                    Program.InstanciarUsuario(usuario);
                    verificaRol(usuario);

                 
            
                }




        }



        private void verificaRol(String usuario)
        {
            String sqlQuery;

            sqlQuery = "Select  us.id_rol, r.nombre  from Datiados.Usuarios_Roles us ";
            sqlQuery += "inner join datiados.roles r on r.id_rol = us.id_rol ";
           sqlQuery += " where usr =  " + "'"+usuario+"'";
           sqlQuery += "and estado = 1  ";

           

            DataSet da = ConectionManager.getInstance().consultarDataSet(sqlQuery);
 
            try {
            if (da.Tables[0].Rows.Count > 1)
            {
                FrmRol rol = new FrmRol();
                rol.llenarCombo(da.Tables[0]);
                rol.Show();
                


            }
            else
            {
                if (da.Tables[0].Rows.Count == 0)
                {
                    throw new ApplicationException("No posee rol asignado, contactese con su administrador");
                }
                else{
                int rolID  =  da.Tables[0].Rows[0].Field<int>("id_rol");

                Program.InstanciarUsuario(usuario);
                Program.setiarRol(rolID);
                FrmMain menu = new FrmMain();
                menu.Show();
                }

            }






                                    
            }
            catch(ApplicationException e)
            {
                MessageBox.Show(e.Message);
                Application.Exit();

            }
        
        
        }

        private void FrmLogin_Enter(object sender, EventArgs e)
        {
            this.btnAceptar_Click(sender, e);
        }

        





    }
}
