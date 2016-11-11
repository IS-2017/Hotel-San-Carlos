using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Odbc;

namespace Abrir
{
    public partial class modificar : Form
    {
        public modificar()
        {
            InitializeComponent();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                txt_ubicacion.Text = txt_ubicacion.Text.Replace("\\", "\\\\");
                string quey = "update reporteador set nombre=  '" + txt_nombre.Text + "' , ubicacion='" +txt_ubicacion.Text + "' where id_reporteador = '" + txt_id.Text + "';";
                OdbcCommand comando = new OdbcCommand(quey, seguridad.Conexion.ObtenerConexionODBC());
                OdbcDataReader dr;
                dr = comando.ExecuteReader();
                MessageBox.Show("Actualizacion Exitosa");
                          
            }
            catch 
            {
                MessageBox.Show("Error en modificar");
            }
        }

        private void txt_ubicacion_Enter(object sender, EventArgs e)
        {
            try
            {
                this.ofp_rtp.ShowDialog();
                if (!string.IsNullOrEmpty(this.ofp_rtp.FileName))
                {
                    txt_ubicacion.Text = this.ofp_rtp.FileName;
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void modificar_Load(object sender, EventArgs e)
        {

        }
    }
    }

