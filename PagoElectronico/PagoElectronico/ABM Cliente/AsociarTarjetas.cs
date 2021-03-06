﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PagoElectronico.ABM_Cliente
{
    public partial class AsociarTarjetas : Form
    {
        DataRow r;
        int clienteID;

        public AsociarTarjetas(int clienteID)
        {
            InitializeComponent();
            txbxTarjNumE.MaxLength = 12;
            txbxTarjNumD.MaxLength = 4;
            llernarCombo();
            this.clienteID = clienteID;
            cmbxEmisor.SelectedItem = null;
            txbxTarjNumE.Enabled = false;

        }

        private void llernarCombo()
        {
            DataSet ds = Utiles.ConectionManager.getInstance().consultarDataSet("select * from datiados.emisoresTarjetas");

            cmbxEmisor.DataSource = ds.Tables[0];
            cmbxEmisor.DisplayMember = "descripcion";
            cmbxEmisor.ValueMember = "codEmisor";
            cmbxEmisor.SelectedText = null;
        }


        private void AsociarTarjetas_Load(object sender, EventArgs e)
        {

        }

        private void cmbxEmisor_Leave(object sender, EventArgs e)
        {

        }

        private void txbxTarjNumE_Leave(object sender, EventArgs e)
        {
            if (txbxTarjNumE.Text.Length == 12)
            {
                txbxTarjNumD.Enabled = true;
                txbxTarjNumD.Focus();

            }
            else
            {
                if (txbxTarjNumE.Text != "")
                {
                    MessageBox.Show("debe ingresar los 12 primeros numeros de la tarjeta");
                    txbxTarjNumE.Focus();
                }

            }
        }

        private void txbxTarjNumD_Leave(object sender, EventArgs e)
        {
            if (txbxTarjNumD.Text.Length == 4)
            {



                if (existe())
                {

                    recuperarDatosTarjeta();
                    btnDesasociar.Enabled = true;
                }
                else
                {
                    btnDesasociar.Enabled = false;

                }

                gpbxDatos.Enabled = true;
                btnAsociar.Enabled = true;


            }


            else
            {
                MessageBox.Show("debe ingresar los 4 numeros de la tarjeta");
                txbxTarjNumD.Focus();

            }
        }

        private void recuperarDatosTarjeta()
        {

            txbxCodSeg.Text = r.Field<String>("cod_Seg").ToString();
            dateFechaEmi.Value = r.Field<DateTime>("fecha_emision");
            dateFechaVenc.Value = r.Field<DateTime>("fecha_venc");

        }

        private bool existe()
        {

            String query = "select * from datiados.tarjetas where numero = " + "'" + txbxTarjNumE.Text.Trim() + txbxTarjNumD.Text.Trim() + "'" + " and codEmisor= " + cmbxEmisor.SelectedValue;

            DataSet ds = Utiles.ConectionManager.getInstance().consultarDataSet(query);

            if (ds.Tables[0].Rows.Count > 0)
            {
                r = ds.Tables[0].Rows[0];
                return true;
            }
            else
            {
                return false;

            }


        }

        private void cmbxEmisor_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbxEmisor.SelectedText != null && cmbxEmisor.Text != "")
            {
                txbxTarjNumE.Enabled = true;


            }


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        private void limpiar()
        {

            
            cmbxEmisor.SelectedItem = null;
         
            txbxTarjNumE.Text = null;
            txbxTarjNumD.Text = null;
            dateFechaEmi.Text = null;
            dateFechaVenc.Text = null;
            gpbxDatos.Enabled = false;
            txbxCodSeg.Text = null;
            txbxTarjNumE.Enabled = false;
            txbxTarjNumD.Enabled = false;

            



        }

        private void btnAsociar_Click(object sender, EventArgs e)
        {

            asociar();

            if (!Program.HayError)
            {

                MessageBox.Show("Grabacion Exitosa");
                limpiar();

            }



        }

        private void asociar()
        {
            SqlParameter[] parametros = new SqlParameter[] {new SqlParameter("@NumeroTarj",txbxTarjNumE.Text.Trim()+txbxTarjNumD.Text.Trim()),
                                                            new SqlParameter("@Emisor",cmbxEmisor.SelectedValue),
                                                            new SqlParameter("@codSeg",txbxCodSeg.Text),
                                                            new SqlParameter("@fechaEmi",DateTime.Parse(dateFechaEmi.Text)),
                                                            new SqlParameter("@fechaVenc",DateTime.Parse(dateFechaVenc.Text)),
                                                            new SqlParameter("@clienteID",clienteID)};

            Utiles.ConectionManager.getInstance().ejecutarStoreProcedure("datiados.Tarjeta_asociar",parametros);

            
        }

        private void desAsociar()
        {

            SqlParameter[] parametros = new SqlParameter[] {new SqlParameter("@NumeroTarj","'"+txbxTarjNumE.Text.Trim()+txbxTarjNumD.Text.Trim()+"'"),
                                                            new SqlParameter("@Emisor",cmbxEmisor.SelectedValue),
                                                            new SqlParameter("@clienteID",clienteID)};

            Utiles.ConectionManager.getInstance().ejecutarStoreProcedure("datiados.Tarjeta_desasociar",parametros);

        }

        private void btnDesasociar_Click(object sender, EventArgs e)
        {
            desAsociar();
            limpiar();
        }


    }
}
