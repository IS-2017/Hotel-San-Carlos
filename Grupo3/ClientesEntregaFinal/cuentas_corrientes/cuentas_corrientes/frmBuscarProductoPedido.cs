//using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cuentas_corrientes
{
    public partial class frmBuscarProductoPedido : Form
    {
        public frmBuscarProductoPedido()
        {
            InitializeComponent();
        }

        public void mostrar()
        {
            OdbcConnection conexion = seguridad.Conexion.ObtenerConexionODBC();
            OdbcDataAdapter dausuario = new OdbcDataAdapter("select bien.id_bien_pk, bien.descripcion, pre.precio, cat.id_categoria_pk, pre.id_precio,  pro.existencia,  cat.tipo_categoria from precio as pre Inner Join bien as bien Inner Join categoria as cat Inner Join producto_bodega as pro Inner Join bodega as bod on pre.id_precio = bien.id_bien_pk and pro.id_bien_pk = bien.id_bien_pk and pre.id_bien_pk = pre.id_bien_pk and bien.id_categoria_pk = cat.id_categoria_pk and pro.id_bodega_pk = bod.id_bodega_pk where bod.ubicacion='Estante 1' and cat.id_categoria_pk = 1 ", conexion);
            DataSet dsuario = new DataSet();
            dausuario.Fill(dsuario, "Producto");
            Data_Producto.DataSource = dsuario;
            Data_Producto.DataMember = "Producto";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Data_Producto.DataSource = clsOpProducto.Buscar(txt_pro.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmBuscarProducto_Load(object sender, EventArgs e)
        {
            mostrar();
        }

        public cls_Producto busq { get; set; }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (Data_Producto.SelectedRows.Count == 1)
                {
                    int id = Convert.ToInt16(Data_Producto.CurrentRow.Cells[0].Value);
                    busq = clsOpProducto.Obtenerclte(id);

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
