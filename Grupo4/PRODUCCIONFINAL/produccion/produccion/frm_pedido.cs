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
    public partial class frm_pedido : Form
    {
        pedido pedido = new pedido();
        public frm_pedido()
        {
            InitializeComponent();
        }
        info_cte info_cte = new info_cte();
        private void frm_pedido_Load(object sender, EventArgs e)
        {
            //txt_nopedido.Text = pedido.generador_correlativo();
            timer1.Start();
            try
            {
                DataTable dt = new DataTable();
                dt = pedido.Carga_datos(seguridad.Conexion.User);
                if (dt.Rows.Count != 0)
                {
                        cmb_emp.DataSource = dt;
                        cmb_colab.DataSource = dt;
                        cmb_colab.DisplayMember = "nombre_colab";
                        cmb_colab.ValueMember = "id_empleado";
                        cmb_emp.ValueMember = "id_empresa";
                        cmb_emp.DisplayMember = "nombre_emp";
                    
                     
                }
                else
                {
                    cmb_colab.SelectedIndex = -1;
                    cmb_emp.SelectedIndex = -1;
                }
            }
            catch
            { 
                
            }

            //Cargando el menú disponible
            try
            {
                DataTable dt = new DataTable();
                dt = pedido.Carga_tipo();
                if(dt.Rows.Count!=0)
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();
            txt_fechaing.Text = DateTime.Now.ToString("yyyy-MM-dd");
            txt_horaing.Text = DateTime.Now.ToString("HH:mm:ss");
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cmb_colab_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            frm_buscacliente buscte = new frm_buscacliente();
            buscte.ShowDialog();
            if (buscte.cte_seleccionado.id_cliente!= null)
            {
                txt_cte.Text = buscte.cte_seleccionado.id_cliente;
            }
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
                MessageBox.Show("Error en carga de productos", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error); ; 
            }
            cargar_precio();



        }

        private void cmb_tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void cmb_prod_SelectedValueChanged(object sender, EventArgs e)
        {
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
            if(string.IsNullOrEmpty(txt_cant.Text))
            {
                txt_cant.Text = "1";
            }
            if(string.IsNullOrEmpty(txt_desc.Text))
            {
                txt_desc.Text = "0.00";
            }
            double importe;
            double cantidad = Convert.ToDouble(txt_cant.Text);
            double precio = Convert.ToDouble(txt_precio.Text);
            importe = precio * cantidad;
     
            dgv_det_ped.Rows.Add(new string[] { cmb_tipo.SelectedValue.ToString(), cmb_prod.SelectedValue.ToString(), txt_cant.Text.Trim(), importe.ToString(),txt_desc.Text.Trim(),"X" });
            txt_cant.Clear();
            txt_desc.Clear();
            foreach(DataGridViewRow row in dgv_det_ped.Rows)
            {
                subtotal += Convert.ToDouble(row.Cells[3].Value);
                descuento += Convert.ToDouble(row.Cells[4].Value);
                total = subtotal - descuento;
            }
            txt_sub.Text = Convert.ToString(subtotal);
            txt_totdesc.Text = Convert.ToString(descuento);
            txt_total.Text = Convert.ToString(total);
            btn_aceptar.Enabled = true;


        }

        private void dgv_det_ped_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            double subtotal = 0.00;
            double total = 0.00;
            double descuento = 0.00;
            if (dgv_det_ped.Rows.Count > 1)
            {
                if (dgv_det_ped.CurrentCell.ColumnIndex == 5)
                {
                    var row = dgv_det_ped.CurrentRow;
                    dgv_det_ped.Rows.Remove(row);
                    foreach (DataGridViewRow row1 in dgv_det_ped.Rows)
                    {
                        subtotal += Convert.ToDouble(row1.Cells[3].Value);
                        descuento += Convert.ToDouble(row1.Cells[4].Value);
                        total = subtotal - descuento;
                    }
                    txt_sub.Text = Convert.ToString(subtotal);
                    txt_totdesc.Text = Convert.ToString(descuento);
                    txt_total.Text = Convert.ToString(total);
                }
            }
            else
            {
                MessageBox.Show("No hay datos para eliminar");
            }
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            int conteo = 1;
            if (dgv_det_ped.Rows.Count <= 1)
            {
                MessageBox.Show("Debe ingresar datos al pedido", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
            else
            {
                try
                {
                    txt_nopedido.Text = pedido.generador_correlativo();
                    DateTime fecha_e = Convert.ToDateTime(dateTimePicker1.Value);
                    int resultado = pedido.inserta_encabezado(txt_nopedido.Text.Trim(), txt_horaing.Text.Trim(), txt_fechaing.Text.Trim(), txt_cte.Text.Trim(), fecha_e.ToString("yyyy-MM-dd"), txt_hora.Text.Trim(), cmb_emp.SelectedValue.ToString(), cmb_colab.SelectedValue.ToString());
                    if (resultado == 1)
                    {
                        MessageBox.Show("Guardado con exito");
                    }
                }
                catch
                {
                    MessageBox.Show("Error en almacenamiento de pedido", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                }
                try
                {

                    foreach (DataGridViewRow row1 in dgv_det_ped.Rows)
                    {
                        if (conteo < dgv_det_ped.Rows.Count)
                        {

                            string id_menu = Convert.ToString(row1.Cells[0].Value);
                            int correlativo = Convert.ToInt16(row1.Cells[1].Value);
                            double cantidad = Convert.ToDouble(row1.Cells[2].Value);
                            double descuento = Convert.ToDouble(row1.Cells[4].Value);
                            int resultado = pedido.inserta_detalle(txt_nopedido.Text.Trim(), id_menu, correlativo, cantidad, descuento);
                            conteo = conteo + 1;
                        }
                        else
                        { break; }
                    }
                }
                catch
                {
                    //MessageBox.Show(ex.Message);
                    MessageBox.Show("Error en el pedido", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                }
                string codigo = txt_nopedido.Text;
                
                MessageBox.Show("Su número de pedido es: " + codigo, "Datos de Pedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();
            }
        }
        public void limpiar()
        {
            txt_cte.Clear();
            txt_hora.Clear();
            txt_sub.Clear();
            txt_desc.Clear();
            txt_total.Clear();
            txt_totdesc.Clear();
            txt_nopedido.Clear();
            dgv_det_ped.Rows.Clear();
            dgv_det_ped.Refresh();
        }

        private void txt_cte_TextChanged(object sender, EventArgs e)
        {
            groupBox3.Enabled = true;
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_mo frm = new frm_mo();
            frm.Show();
            this.Close();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            int conteo = 1;
            if (dgv_det_ped.Rows.Count <= 1)
            {
                MessageBox.Show("Debe ingresar datos al pedido", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
            else
            {
                try
                {
                    txt_nopedido.Text = pedido.generador_correlativo();
                    DateTime fecha_e = Convert.ToDateTime(dateTimePicker1.Value);
                    int resultado = pedido.inserta_encabezado(txt_nopedido.Text.Trim(), txt_horaing.Text.Trim(), txt_fechaing.Text.Trim(), txt_cte.Text.Trim(), fecha_e.ToString("yyyy-MM-dd"), txt_hora.Text.Trim(), cmb_emp.SelectedValue.ToString(), cmb_colab.SelectedValue.ToString());
                    if (resultado == 1)
                    {
                        MessageBox.Show("Guardado con exito");
                    }
                }
                catch
                {
                    MessageBox.Show("Error en encabezado pedido", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                }
                try
                {

                    foreach (DataGridViewRow row1 in dgv_det_ped.Rows)
                    {
                        if (conteo < dgv_det_ped.Rows.Count)
                        {

                            string id_menu = Convert.ToString(row1.Cells[0].Value);
                            int correlativo = Convert.ToInt16(row1.Cells[1].Value);
                            double cantidad = Convert.ToDouble(row1.Cells[2].Value);
                            double descuento = Convert.ToDouble(row1.Cells[4].Value);
                            int resultado = pedido.inserta_detalle(txt_nopedido.Text.Trim(), id_menu, correlativo, cantidad, descuento);
                            conteo = conteo + 1;
                        }
                        else
                        { break; }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("Error en el detalle pedido", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                }
                string codigo = txt_nopedido.Text;

                MessageBox.Show("Su número de pedido es: " + codigo, "Datos de Pedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
