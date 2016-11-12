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
    public partial class modifica_pedido : Form
    {
        public modifica_pedido()
        {
            InitializeComponent();
        }
        pedido pedido = new pedido();
        private void modifica_pedido_Load(object sender, EventArgs e)
        {

            try
            {
                DataTable dt = new DataTable();
                dt = pedido.carga_pedidos();
                cmb_pedido.DataSource = dt;
                cmb_pedido.DisplayMember = "id_encabezado_pedido_pk";
                cmb_pedido.ValueMember = "id_encabezado_pedido_pk";
            }
            catch
            {
                MessageBox.Show("Error en carga de datos", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                DataTable dt = new DataTable();
                dt = pedido.Carga_tipo();
                if (dt.Rows.Count != 0)
                {
                    cmb_tipo.DataSource = dt;
                    cmb_tipo.ValueMember = "id_menu_pk";
                }
                else
                {
                    cmb_tipo.SelectedIndex = -1;
                    //MessageBox.Show("Sin datos");
                }
            }
            catch
            { MessageBox.Show("Error en carga de Menú", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error); ; }


        }

        private void cmb_pedido_SelectedValueChanged(object sender, EventArgs e)
        {

            txt_fecentrega.Clear();
            txt_Hentrega.Clear();
            txt_cte.Clear();
            try
            {
                DataTable dt = new DataTable();
                dt = pedido.carga_dped(cmb_pedido.SelectedValue.ToString());
                if (dt.Rows.Count != 0)
                {
                    DataRow row = dt.Rows[0];
                    DateTime fecha = Convert.ToDateTime(row["fecha"].ToString());
                    txt_fecentrega.Text = fecha.ToString("dd/MM/yyyy");
                    txt_Hentrega.Text = row["hora"].ToString();
                    txt_cte.Text = row["nombre"].ToString();
                }

            }
            catch
            {
                MessageBox.Show("Error en carga de datos", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            carga_dgv();
            


        }

        private void cmb_pedido_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {

        }

        private void dgv_pedido_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            double subtotal = 0.00;
            double total = 0.00;
            double descuento = 0.00;
           if(dgv_pedido.Rows.Count>1)
            {
                if (dgv_pedido.CurrentCell.ColumnIndex == 0)
                {
                    if (MessageBox.Show("¿Esta seguro que desea eliminar esta orden?", "Eliminar registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        int no_orden = Convert.ToInt16(dgv_pedido.Rows[dgv_pedido.CurrentRow.Index].Cells[1].Value); //obteniendo el numero de orden de la columna oculta
                        int resultado = pedido.elimina_detalle(cmb_pedido.SelectedValue.ToString(), no_orden);
                        var row = dgv_pedido.CurrentRow;
                        dgv_pedido.Rows.Remove(row);


                        dgv_pedido.Refresh();
                        if (resultado == 1)
                        {
                            foreach (DataGridViewRow row1 in dgv_pedido.Rows)
                            {
                                subtotal += Convert.ToDouble(row1.Cells[8].Value);
                                descuento += Convert.ToDouble(row1.Cells[7].Value);
                                total = subtotal - descuento;
                            }
                        }
                        else
                        {

                        }

                        txt_sub.Text = Convert.ToString(subtotal);
                        txt_totdesc.Text = Convert.ToString(descuento);
                        txt_total.Text = Convert.ToString(total);
                        MessageBox.Show("Orden eliminada","Nota",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar una celda válida", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                }
            }
        
        }

        private void cmb_tipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb_tipo_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = pedido.carga_productos(Convert.ToString(cmb_tipo.SelectedValue));
                if (dt.Rows.Count != 0)
                {
                    DataRow dr = dt.NewRow();

                    cmb_prod.DataSource = dt;
                    cmb_prod.DisplayMember = "nombre";
                    cmb_prod.ValueMember = "ID";

                }

                else
                {
                    cmb_prod.SelectedIndex = -1;
                    //MessageBox.Show("Sin datos");
                }
            }

            catch
            {
                MessageBox.Show("Error en carga de productos", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
            cargar_precio();
        }
        public void cargar_precio()
        {
            txt_precio.Clear();
            try
            {
                string precio = "";
                DataTable dt = new DataTable();
                dt = pedido.carga_precio(cmb_tipo.SelectedValue.ToString(), cmb_prod.SelectedValue.ToString());
                if (dt.Rows.Count != 0)
                {

                    foreach (DataRow dr in dt.Rows)
                    {
                        precio = Convert.ToString(dr["precio"]);
                    }

                }
                else
                {

                }
                txt_precio.Text = precio;
            }
            catch
            {
                //MessageBox.Show("Error en carga de precios", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
            btn_agregar.Enabled = true;
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            double subtotal = 0.00;
            double total = 0.00;
            double descuento = 0.00;
            if (string.IsNullOrEmpty(txt_cant.Text))
            {
                txt_cant.Text = "1";
            }
            if (string.IsNullOrEmpty(txt_desc.Text))
            {
                txt_desc.Text = "0.00";
            }
            
            
            try
            {
                string id_menu = Convert.ToString(cmb_tipo.SelectedValue.ToString());
                int correlativo = Convert.ToInt16(cmb_prod.SelectedValue.ToString());
                double cantidad = Convert.ToDouble(txt_cant.Text.Trim());
                double desc = Convert.ToDouble(txt_desc.Text.Trim());
                int resultado = pedido.inserta_detalle(cmb_pedido.SelectedValue.ToString(), id_menu, correlativo, cantidad, desc);
                if (resultado == 1)
                {
                    foreach (DataGridViewRow row in dgv_pedido.Rows)
                    {
                        subtotal += Convert.ToDouble(row.Cells[8].Value);
                        descuento += Convert.ToDouble(row.Cells[7].Value);
                        total = subtotal - descuento;
                    }
                    txt_sub.Text = Convert.ToString(subtotal);
                    txt_totdesc.Text = Convert.ToString(descuento);
                    txt_total.Text = Convert.ToString(total);
                    
                    txt_cant.Clear();
                    txt_desc.Clear();
                    carga_dgv();
                }
            }
            catch
            {
                MessageBox.Show("Error al agregar orden", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        public void carga_dgv()
        {
            try
            {
                double subtotal = 0.00;
                double total = 0.00;
                double descuento = 0.00;
                DataTable dt = new DataTable();
                dt = pedido.carga_detalle_pedido(cmb_pedido.SelectedValue.ToString());
                dgv_pedido.DataSource = dt;
                dgv_pedido.Refresh();
                dgv_pedido.Columns["id_menu_pk"].Visible = false;
                dgv_pedido.Columns["correlativo"].Visible = false;
                //dgv_pedido.Columns["Orden"].Visible = false;
                foreach (DataGridViewRow row in dgv_pedido.Rows)
                {
                    subtotal += Convert.ToDouble(row.Cells[8].Value);
                    descuento += Convert.ToDouble(row.Cells[7].Value);
                    total = subtotal - descuento;
                }
                txt_sub.Text = Convert.ToString(subtotal);
                txt_totdesc.Text = Convert.ToString(descuento);
                txt_total.Text = Convert.ToString(total);
            }
            catch
            {
                MessageBox.Show("Error en carga de datos", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_editar_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
