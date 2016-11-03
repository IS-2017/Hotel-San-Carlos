using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FuncionesNavegador;
using MySql.Data.MySqlClient;
using dllconsultas;


namespace WindowsFormsApplication5
{
    public partial class CompraProveedores : Form
    {
        public CompraProveedores()
        {
            InitializeComponent();         
        }
        String Codigo;
        Boolean Editar;
        String atributo;
        public string[] codigo;

        public void llenarCbo1()
        {
            CapaNegocio obj = new CapaNegocio();
            string query = "select id_forma_pk from forma_pago;";
            string tabla = "forma_pago";
            string valor = "id_forma_pk";
            string mostrar = "id_forma_pk";
            cbm_forma_pago = obj.llenarCbo(query, tabla, cbm_forma_pago, valor, mostrar);
        }

        public void llenarCbo2()
        {
            CapaNegocio obj = new CapaNegocio();
            string query = "select id_proveedor_pk,nombre_proveedor from proveedor;";
            string tabla = "proveedor";
            string valor = "nombre_proveedor";
            string mostrar = "nombre_proveedor";
            cbm_proveedor = obj.llenarCbo(query, tabla, cbm_proveedor, valor, mostrar);
        }

        public void llenarCbo3()
        {
            CapaNegocio obj = new CapaNegocio();
            string query = "select id_cuenta_pk from cuenta_corriente_por_pagar;";
            string tabla = "cuenta_corriente_por_pagar";
            string valor = "id_cuenta_pk";
            string mostrar = "id_cuenta_pk";
            cbm_cuenta_por_pagar = obj.llenarCbo(query, tabla, cbm_cuenta_por_pagar, valor, mostrar);
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            InsertarCompra abrir = new InsertarCompra();
            abrir.Show();
        }

        public void dgv_compras_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DetalleCompra veta = new DetalleCompra();
                CapaNegocio fs = new CapaNegocio();
                string tabla = "detalle_compra";
                fs.ActualizarGrid(veta.dgv_detalle_compra, "Select * from detalle_compra where id_factura_pk ='" + this.dgv_compras.CurrentRow.Cells[0].Value.ToString() + "'", tabla);
             
                string factura = this.dgv_compras.CurrentRow.Cells[0].Value.ToString();
                string orden_pedido = this.dgv_compras.CurrentRow.Cells[1].Value.ToString();
                string serie_factura = this.dgv_compras.CurrentRow.Cells[2].Value.ToString();
                string fecha = this.dgv_compras.CurrentRow.Cells[3].Value.ToString();
                string encargado = this.dgv_compras.CurrentRow.Cells[4].Value.ToString();
                string total = this.dgv_compras.CurrentRow.Cells[5].Value.ToString();
                string estado = this.dgv_compras.CurrentRow.Cells[6].Value.ToString();
                string cuenta = this.dgv_compras.CurrentRow.Cells[7].Value.ToString();
                string proveedor = this.dgv_compras.CurrentRow.Cells[8].Value.ToString();
                string forma = this.dgv_compras.CurrentRow.Cells[9].Value.ToString();

                veta.txt_factura.Text = factura.ToString();
                veta.txt_orde_pedido.Text = orden_pedido.ToString();
                veta.txt_serie_factura.Text = serie_factura.Trim();
                veta.txt_fecha_recibida.Text = fecha.Trim();
                veta.txt_encargado.Text = encargado.Trim();
                veta.txt_total.Text = total.Trim();
                veta.txt_estado.Text = estado.Trim();
                veta.txt_cuenta_corriente.Text = cuenta.Trim();
                veta.txt_proveedor.Text = proveedor.Trim();
                veta.txt_forma_pago.Text = forma.Trim();

                veta.Show();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                String codigo2 = this.dgv_compras.CurrentRow.Cells[0].Value.ToString();
                String atributo2 = "id_factura_pk";
                //String campo = "estado";
                var resultado = MessageBox.Show("DESEA BORRAR EL REGISTRO SELECCIONADO", "CONFIRME SU ACCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {

                    CapaNegocio fn = new CapaNegocio();
                    string tabla = "compra";
                    fn.eliminar(tabla, atributo2, codigo2);

                }
            }
            catch
            {
                MessageBox.Show("No se ha seleccionado ningun registro a eliminar", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            CapaNegocio fn = new CapaNegocio();
            fn.Anterior(dgv_compras);
            //TextBox[] textbox = { lbl_fecha_recibida_mostrar };
            //fn.llenartextbox(textbox, dgv_compras);
            //dateTimePicker1.Text = textBox5.Text;
            //comboBox1.Text = textBox4.Text;
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            CapaNegocio fn = new CapaNegocio();
            fn.Siguiente(dgv_compras);
            //TextBox[] textbox = { textBox4, textBox3, textBox2, textBox5, textbox6, textBox7 };
            //fn.llenartextbox(textbox, dataGridView1);
            //dateTimePicker1.Text = textBox5.Text;
            //comboBox1.Text = textBox4.Text;
        }

        private void btn_primero_Click(object sender, EventArgs e)
        {
            CapaNegocio fn = new CapaNegocio();
            fn.Primero(dgv_compras);
            //TextBox[] textbox = { textBox4, textBox3, textBox2, textBox5, textbox6, textBox7 };
            //fn.llenartextbox(textbox, dataGridView1);
            //dateTimePicker1.Text = textBox5.Text;
            //comboBox1.Text = textBox4.Text;
        }

        private void btn_ultimo_Click(object sender, EventArgs e)
        {
            CapaNegocio fn = new CapaNegocio();
            fn.Ultimo(dgv_compras);

            //TextBox[] textbox = { txt_no_factura, txt_serie_factura, txt_pedido_compra, textBox5, textbox6, textBox7 };
            //fn.llenartextbox(textbox, dataGridView1);
            //dateTimePicker1.Text = textBox5.Text;
            //comboBox1.Text = textBox4.Text;
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            CapaNegocio fn = new CapaNegocio();
            string tabla = "compra";
            fn.ActualizarGrid(this.dgv_compras, "Select * from compra ", tabla);
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string tabla = "compra";
            operaciones op = new operaciones();
            op.ejecutar(dgv_compras, tabla);
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                CapaNegocio hab = new CapaNegocio();
                hab.ActivarControles(this);
                txt_no_factura.Enabled = false;
                txt_pedido_compra.Enabled = false;
                /*                Editar = true;
                                atributo = "id_factura_pk";
                                Codigo = this.dgv_compras.CurrentRow.Cells[0].Value.ToString();
                                lbl_id_factura_compra_pk.Text = Codigo;
                                TextBox[] textbox = { txt_no_factura, txt_pedido_compra, txt_serie_factura, txt_invisible_fecha_recibida ,txt_encargado, txt_total,txt_estado, txt_invisible_cuenta_por_pagar, txt_invisible_proveedor, txt_invisible_forma_pago };
                                CapaNegocio fn = new CapaNegocio();
                                fn.ActivarControles(this);
                                fn.llenartextbox(textbox, dgv_compras);
                */
                string factura = this.dgv_compras.CurrentRow.Cells[0].Value.ToString();
                string orden_pedido = this.dgv_compras.CurrentRow.Cells[1].Value.ToString();
                string serie_factura = this.dgv_compras.CurrentRow.Cells[2].Value.ToString();
                string fecha = this.dgv_compras.CurrentRow.Cells[3].Value.ToString();
                string encargado = this.dgv_compras.CurrentRow.Cells[4].Value.ToString();
                string total = this.dgv_compras.CurrentRow.Cells[5].Value.ToString();
                string estado = this.dgv_compras.CurrentRow.Cells[6].Value.ToString();
                string cuenta = this.dgv_compras.CurrentRow.Cells[7].Value.ToString();
                string proveedor = this.dgv_compras.CurrentRow.Cells[8].Value.ToString();
                string forma = this.dgv_compras.CurrentRow.Cells[9].Value.ToString();

                txt_no_factura.Text = factura.Trim();
                txt_pedido_compra.Text = orden_pedido.Trim();
                txt_serie_factura.Text = serie_factura.Trim();
                txt_invisible_fecha_recibida.Text = fecha.Trim();
                txt_encargado.Text = encargado.Trim();
                txt_total.Text = total.Trim();
                txt_estado.Text = estado.Trim();
                cbm_cuenta_por_pagar.Text = cuenta.Trim();
                cbm_proveedor.Text = proveedor.Trim();
                cbm_forma_pago.Text = forma.Trim();

            }
            catch (Exception ex)
            {
                //MessageBox.Show("No se ha seleccionado ningun registro a editar", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.Message);
            }

        }

        private void CompraProveedores_Load(object sender, EventArgs e)
        {

            CapaNegocio fn = new CapaNegocio();
            fn.InhabilitarComponentes(this);
            string tabla = "compra";
            fn.ActualizarGrid(this.dgv_compras, "Select * from compra ", tabla);

            llenarCbo1();
            llenarCbo2();
            llenarCbo3();
            txt_buscar.Enabled = true;
            lbl_buscar.Enabled = true;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Editar = false;
            CapaNegocio fn = new CapaNegocio();
            fn.LimpiarComponentes(this);
            fn.InhabilitarComponentes(this);
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection("server=localhost; database=hotelsancarlos; Uid=root; pwd=;");
                con.Open();
                dtp_fecha_recibida.Format = DateTimePickerFormat.Custom;
                dtp_fecha_recibida.CustomFormat = "yyyy-MM-dd";
                MySqlCommand comando = new MySqlCommand(" update compra set serie_factura = '" + txt_serie_factura.Text + "' ,fecha_recibida = '" + dtp_fecha_recibida.Text + "' ,encargado = '" + txt_encargado.Text + "',total = '" + txt_total.Text + "' ,estado = '" + txt_estado.Text + "' ,id_cuenta_pk = '" + cbm_cuenta_por_pagar.Text + "' ,id_proveedor_pk = '" +cbm_proveedor.Text + "', id_forma_pk = '" +cbm_forma_pago+ "' where id_factura_pk = '" + txt_no_factura.Text + "'", con);
                comando.ExecuteNonQuery();
              
                MessageBox.Show("actualizado con exito");              
                con.Close();
                CapaNegocio fv = new CapaNegocio();
                fv.InhabilitarComponentes(this);
                fv.LimpiarComponentes(this);            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
