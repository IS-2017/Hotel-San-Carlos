using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using MySql.Data.MySqlClient;
using System.Data.Odbc;
using seguridad;

namespace cuentas_corrientes
{
    public partial class TipoPrecio : Form
    {
        public TipoPrecio()
        {
            InitializeComponent();
            llenar_encabezado();
            llenar();
        }

        public void llenar_encabezado()
        {
            DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
            c1.HeaderText = "Tipo de Catalogo";
            c1.Width = 100;
            c1.ReadOnly = true;

            dgv_tipo.Columns.Add(c1);
        }

        public void llenar()
        {

            dgv_tipo.Rows.Clear();
            string scad = "Select * from tipo_precio";
            OdbcCommand mcd = new OdbcCommand(scad, seguridad.Conexion.ObtenerConexionODBC());
            OdbcDataReader mdr = mcd.ExecuteReader();

            while (mdr.Read())
            {

                dgv_tipo.Rows.Add(mdr.GetString(1));

            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            string scad = "insert into tipo_precio (tipo) values ('"+txt_tipo.Text+"')";
            OdbcCommand mcd = new OdbcCommand(scad, seguridad.Conexion.ObtenerConexionODBC());
            OdbcDataReader mdr = mcd.ExecuteReader();
        }

        private void TipoPrecio_Load(object sender, EventArgs e)
        {

        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            string scad = "select * from tipo_precio (tipo)";
            OdbcCommand mcd = new OdbcCommand(scad, seguridad.Conexion.ObtenerConexionODBC());
            OdbcDataReader mdr = mcd.ExecuteReader();
        }
    }
}
