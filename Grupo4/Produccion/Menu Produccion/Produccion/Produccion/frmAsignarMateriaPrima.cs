using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace produccion
{
    public partial class frmAsignarMateriaPrima : Form
    {
        public frmAsignarMateriaPrima()
        {
            InitializeComponent();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            string cantidad_pedido = dgv_pedido.Rows[0].Cells[2].Value.ToString();
            lbl_cantidad_pedido.Text = cantidad_pedido;
                //dgv_pedido.Rows[0].Cells[2].ToString();
        }

        private void frmAsignarMateriaPrima_Load(object sender, EventArgs e)
        {
            CapaDatos cd = new CapaDatos();
            DataTable dt = cd.ConsultarPedidos();

            cmb_pedido.DataSource = dt;
            cmb_pedido.DisplayMember = "id_encabezado_pedido_pk";
            cmb_pedido.ValueMember = "id_encabezado_pedido_pk";
        }

        private void cmb_pedido_SelectedIndexChanged(object sender, EventArgs e)
        {
            CapaDatos cd = new CapaDatos();
            DataTable dt = cd.ConsultarPedidoDetalle(cmb_pedido.SelectedValue.ToString());
            //MessageBox.Show(cmb_pedido.SelectedValue.ToString());

            dgv_pedido.DataSource = dt;
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            //CapaDatos cd = new CapaDatos();
            //DataTable dt = cd.ConsultarPedidoDetalle(cmb_pedido.SelectedValue.ToString());
            //MessageBox.Show(cmb_pedido.SelectedValue.ToString());

            //dgv_pedido.DataSource = dt;
        }

        private void dgv_pedido_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // envia parametro para determinar que materia prima se va a utilizar
            string parametro = Convert.ToString(dgv_pedido.CurrentRow.Cells["id_menu_pk"].Value.ToString().Trim());
            CapaDatos cd = new CapaDatos();
            DataTable dt = cd.ConsultarMateriaPrimaSegunPedido(parametro);
            MessageBox.Show(parametro);
            // recorre el datatable para ingresar detalle de materia prima a utilizarse segun detalle de pedido
            foreach (DataRow row in dt.Rows)
            {
                //int cantidad_total = 0;
                //int contador = 0;
                //string cantidad_pedido = dgv_pedido.Rows[contador].Cells[2].Value.ToString();
                

                //string cantidad_mp = row[2].ToString();

                //cantidad_total = Convert.ToInt32(cantidad_pedido) * Convert.ToInt32(cantidad_mp);

                ////dgv_detalle_mp.Rows.Add(row[0].ToString(), row[1].ToString(), cantidad_total.ToString(), row[5].ToString(), row[4].ToString(), row[3].ToString());

                dgv_detalle_mp.Rows.Add(row[0].ToString(), row[1].ToString(), row[4].ToString(), row[5].ToString(), row[2].ToString(), row[3].ToString());



                //contador += 1;
            }
            
        }

        private void dgv_detalle_mp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //foreach (DataGridViewRow id_menu in ) voy a recorrer todo el datagrid para agregar toda la materia prima
            //{
            
            //}
        }
    }
}
