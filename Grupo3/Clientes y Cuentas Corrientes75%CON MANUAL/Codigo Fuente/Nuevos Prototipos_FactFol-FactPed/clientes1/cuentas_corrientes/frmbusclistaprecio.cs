using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using seguridad;

namespace cuentas_corrientes
{
    public partial class frmbusclistaprecio : Form
    {
        public frmbusclistaprecio(int codi)
        {
            InitializeComponent();
            this.codigo = codi;
            llenar_encabezado();
            mostrar();
        }
        public int codigo;

        public void llenar_encabezado()
        {
            DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
            c1.HeaderText = "Cod-Bien";
            c1.Width = 100;
            c1.ReadOnly = true;

            dgv_bien.Columns.Add(c1);

            DataGridViewTextBoxColumn c2 = new DataGridViewTextBoxColumn();
            c2.HeaderText = "Nombre";
            c2.Width = 50;
            c2.ReadOnly = true;

            dgv_bien.Columns.Add(c2);

            DataGridViewTextBoxColumn c3 = new DataGridViewTextBoxColumn();
            c3.HeaderText = "Costo";
            c3.Width = 50;
            c3.ReadOnly = true;

            dgv_bien.Columns.Add(c3);

            DataGridViewTextBoxColumn c4 = new DataGridViewTextBoxColumn();
            c4.HeaderText = "Precio";
            c4.Width = 50;
            c4.ReadOnly = true;

            dgv_bien.Columns.Add(c4);

            DataGridViewTextBoxColumn c5 = new DataGridViewTextBoxColumn();
            c5.HeaderText = "Tipo";
            c5.Width = 50;
            c5.ReadOnly = true;

            dgv_bien.Columns.Add(c5);

        }


        private void frmbusclistaprecio_Load(object sender, EventArgs e)
        {

        }

        private void btn_buscbien_Click(object sender, EventArgs e)
        {
            /*OdbcConnection conexion = seguridad.Conexion.ObtenerConexionODBC();
            OdbcDataAdapter dausuario = new OdbcDataAdapter("SELECT bien.id_bien_pk, bien.descripcion, bien.costo, precio.precio, tipo_precio.tipo FROM precio INNER JOIN bien INNER JOIN tipo_precio ON bien.id_bien_pk = precio.id_bien_pk and precio.id_tprecio_pk = tipo_precio.id_tprecio_pk and precio.id_tprecio_pk="+codigo+" and bien.descripcion='"+txt_bien.Text+"'", conexion);
            DataSet dsuario = new DataSet();
            dausuario.Fill(dsuario, "precio");
            dgv_bien.DataSource = dsuario;
            dgv_bien.DataMember = "precio";*/

            string scad2 = "SELECT bien.id_bien_pk, bien.descripcion, bien.costo, precio.precio, tipo_precio.tipo FROM precio INNER JOIN bien INNER JOIN tipo_precio ON bien.id_bien_pk = precio.id_bien_pk and precio.id_tprecio_pk = tipo_precio.id_tprecio_pk and precio.id_tprecio_pk=" + codigo + " and bien.descripcion='" + txt_bien.Text + "'";
            OdbcCommand mcd2 = new OdbcCommand(scad2, seguridad.Conexion.ObtenerConexionODBC());
            OdbcDataReader mdr2 = mcd2.ExecuteReader();

            while (mdr2.Read())
            {
                dgv_bien.Rows.Add(mdr2.GetInt32(0), mdr2.GetString(1), mdr2.GetDecimal(2), mdr2.GetDecimal(3), mdr2.GetString(4));
            }

        }

        public void mostrar()
        {

            //MessageBox.Show(Convert.ToString(codigo));

            /* OdbcConnection conexion = seguridad.Conexion.ObtenerConexionODBC();
             OdbcDataAdapter dausuario = new OdbcDataAdapter("SELECT bien.id_bien_pk, bien.descripcion, bien.costo, precio.precio, tipo_precio.tipo FROM precio INNER JOIN bien INNER JOIN tipo_precio ON bien.id_bien_pk = precio.id_bien_pk and precio.id_tprecio_pk = tipo_precio.id_tprecio_pk and precio.id_tprecio_pk=" + codigo, conexion); 
                 DataSet dsuario = new DataSet();
                 dausuario.Fill(dsuario, "precio");
                 dgv_bien.DataSource = dsuario;
                 dgv_bien.DataMember = "precio";*/

            
            
            OdbcCommand mcd2 = new OdbcCommand(String.Format("SELECT bien.id_bien_pk, bien.descripcion, bien.costo, precio.precio, tipo_precio.tipo FROM precio INNER JOIN bien INNER JOIN tipo_precio ON bien.id_bien_pk = precio.id_bien_pk and precio.id_tprecio_pk = tipo_precio.id_tprecio_pk and precio.id_tprecio_pk={0}",codigo), seguridad.Conexion.ObtenerConexionODBC());
            OdbcDataReader mdr2 = mcd2.ExecuteReader();

            while (mdr2.Read())
            {
                dgv_bien.Rows.Add(mdr2.GetInt32(0), mdr2.GetString(1), mdr2.GetDecimal(2), mdr2.GetDecimal(3), mdr2.GetString(4));
            }

        }

        public ClsListadoPrecio listpr { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_bien.SelectedRows.Count == 1)
                {
                    int id = Convert.ToInt32(dgv_bien.CurrentRow.Cells[0].Value);
                    listpr = clsOlistaprecios.Obtenerbien(id,codigo);

                    this.Close();
                }
                else
                    MessageBox.Show("Debe de seleccionar una fila");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
