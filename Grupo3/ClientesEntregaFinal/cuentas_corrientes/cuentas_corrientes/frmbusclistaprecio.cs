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
         
            mostrar();
        }
        public int codigo;

        

        private void frmbusclistaprecio_Load(object sender, EventArgs e)
        {

        }

        private void btn_buscbien_Click(object sender, EventArgs e)
        {
            OdbcConnection conexion = seguridad.Conexion.ObtenerConexionODBC();
            OdbcDataAdapter dausuario = new OdbcDataAdapter("SELECT bien.id_bien_pk, bien.descripcion, bien.costo, precio.precio, tipo_precio.tipo FROM precio INNER JOIN bien INNER JOIN tipo_precio ON bien.id_bien_pk = precio.id_bien_pk and precio.id_tprecio_pk = tipo_precio.id_tprecio_pk and precio.id_tprecio_pk="+codigo+" and bien.descripcion='"+txt_bien.Text+"' and bien.id_categoria_pk='PT'", conexion);
            DataSet dsuario = new DataSet();
            dausuario.Fill(dsuario, "precio");
            dgv_bien.DataSource = dsuario;
            dgv_bien.DataMember = "precio";
        }

        public void mostrar()
        {

            //MessageBox.Show(Convert.ToString(codigo));

            OdbcConnection conexion = seguridad.Conexion.ObtenerConexionODBC();
            OdbcDataAdapter dausuario = new OdbcDataAdapter("SELECT bien.id_bien_pk, bien.descripcion, bien.costo, precio.precio, tipo_precio.tipo FROM precio INNER JOIN bien INNER JOIN tipo_precio ON bien.id_bien_pk = precio.id_bien_pk and precio.id_tprecio_pk = tipo_precio.id_tprecio_pk and bien.id_categoria_pk='PT' and precio.id_tprecio_pk=" + codigo, conexion); 
                DataSet dsuario = new DataSet();
                dausuario.Fill(dsuario, "precio");
                dgv_bien.DataSource = dsuario;
                dgv_bien.DataMember = "precio";
            
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
