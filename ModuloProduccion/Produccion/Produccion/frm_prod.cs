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
    public partial class frm_prod : Form
    {
        public frm_prod()
        {
            InitializeComponent();
        }

        // cargar el combobox con todos los pedidos
        private void frm_prod_Load(object sender, EventArgs e)
        {
            CapaDatos cd = new CapaDatos();
            DataTable dt = cd.ConsultarPedidos();

            cmb_pedido.DataSource = dt;
            cmb_pedido.DisplayMember = "id_encabezado_pedido_pk";
            cmb_pedido.ValueMember = "id_encabezado_pedido_pk";
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
           
        }

        // boton recorrer datagridview del detalle de pedido y mandar como resultado un nuevo detalle de materia prima a utilizarse
        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            int contador2 = 0;
            while (contador2 < dgv_pedido.RowCount - 1)
            {
                
                
                string llave = dgv_pedido.Rows[contador2].Cells["id_menu_pk"].Value.ToString();
                string correlativo = dgv_pedido.Rows[contador2].Cells["correlativo"].Value.ToString();

                CapaDatos cd = new CapaDatos();
                DataTable dt = cd.ConsultarMateriaPrimaSegunPedido(llave, correlativo);


                // recorre el datatable para ingresar detalle de materia prima a utilizarse segun detalle de pedido
                foreach (DataRow row in dt.Rows)
                {


                    int cantidad_total = 0;
                    int contador = 0;
                    string cantidad_pedido = dgv_pedido.Rows[contador].Cells["cantidad"].Value.ToString();
                    //string cantidad_pedido = row["cantidad"].ToString();

                    string cantidad_mp = row[3].ToString();

                    cantidad_total = Convert.ToInt32(cantidad_pedido) * Convert.ToInt32(cantidad_mp);

                    // nombre de menu, receta, cantidad, medida, id_bien, descripcion
                    dgv_detalle_mp.Rows.Add(row[0].ToString(), row[1].ToString(), cantidad_total.ToString(), row[4].ToString(), row[2].ToString(), row[5].ToString());

                    contador += 1;
                }



                //MessageBox.Show(llave);
                contador2 += 1;
            }

        
        }


        // gridview con todo el cuerpo del pedido
        private void cmb_pedido_SelectedIndexChanged(object sender, EventArgs e)
        {
            CapaDatos cd = new CapaDatos();
            DataTable dt = cd.ConsultarPedidoDetalle(cmb_pedido.SelectedValue.ToString());
            //MessageBox.Show(cmb_pedido.SelectedValue.ToString());

            dgv_pedido.DataSource = dt;
            dgv_pedido.Columns["id_menu_pk"].Visible = false;
            dgv_pedido.Columns["orden"].Visible = false;
            dgv_pedido.Columns["correlativo"].Visible = false;
        }

        private void dgv_pedido_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //// envia parametro para determinar que materia prima se va a utilizar
            //string llave = Convert.ToString(dgv_pedido.CurrentRow.Cells["id_menu_pk"].Value.ToString().Trim());
            //string correlativo = Convert.ToString(dgv_pedido.CurrentRow.Cells["correlativo"].Value.ToString().Trim());
            //CapaDatos cd = new CapaDatos();
            //DataTable dt = cd.ConsultarMateriaPrimaSegunPedido(llave, correlativo);
            //MessageBox.Show(llave);


            //// recorre el datatable para ingresar detalle de materia prima a utilizarse segun detalle de pedido
            //foreach (DataRow row in dt.Rows)
            //{
            //    int cantidad_total = 0;
            //    int contador = 0;
            //    string cantidad_pedido = dgv_pedido.Rows[contador].Cells["cantidad"].Value.ToString();


            //    string cantidad_mp = row[3].ToString();

            //    cantidad_total = Convert.ToInt32(cantidad_pedido) * Convert.ToInt32(cantidad_mp);

            //    // nombre de menu, receta, cantidad, medida, id_bien, descripcion
            //    dgv_detalle_mp.Rows.Add(row[0].ToString(), row[1].ToString(), cantidad_total.ToString(), row[4].ToString(), row[2].ToString(), row[5].ToString());

            //    contador += 1;
            //}
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            double costo = 0;
            double hrs_hombre = 0;

            foreach (DataGridViewRow columna in dgv_pedido.Rows)
            {
                costo += Convert.ToDouble(columna.Cells["costo_receta"].Value);
                hrs_hombre += Convert.ToDouble(columna.Cells["horas_hombre"].Value);
            }

            lbl_costo_total.Text = costo.ToString();
            lbl_hrs_hombre_total.Text = hrs_hombre.ToString();
        }

        // boton de cancelar para limpiar ambos datagridview
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            //dgv_detalle_mp.DataSource =  ;

            //dgv_pedido.DataSource = "";
            dgv_detalle_mp.Rows.Clear();
            dgv_pedido.DataSource = "";
        }
    }
}
