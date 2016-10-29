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

namespace WindowsFormsApplication5
{
    public partial class InsertarCompra : Form
    {
        String Codigo;
        Boolean Editar;
        String atributo;
        public string[] codigo;
        public InsertarCompra()
        {
            InitializeComponent();
            gpb_importacion.Enabled = false;
            btn_agregar.Enabled = false;    
        }

        public void llenarCbo1()
        {
            CapaNegocio obj = new CapaNegocio();
            string query = "select id_pedido_compra_pk from pedido_compra;";
            string tabla = "pedido_compra";
            string valor = "id_pedido_compra_pk";
            string mostrar = "id_pedido_compra_pk";
            cmb_orden_pedido = obj.llenarCbo(query, tabla, cmb_orden_pedido, valor, mostrar);
        }

        public void llenarCbo2()
        {
            CapaNegocio obj = new CapaNegocio();
            string query = "select id_forma_pk,tipo_pago from forma_pago;";
            string tabla = "forma_pago";
            string valor = "tipo_pago";
            string mostrar = "tipo_pago";
            cmb_forma_pago = obj.llenarCbo(query, tabla, cmb_forma_pago, valor, mostrar);
        }

        public void llenarCbo3()
        {
            CapaNegocio obj = new CapaNegocio();
            string query = "select id_proveedor_pk,nombre_proveedor from proveedor;";
            string tabla = "proveedor";
            string valor = "nombre_proveedor";
            string mostrar = "nombre_proveedor";
            cmb_proveedor = obj.llenarCbo(query, tabla, cmb_proveedor, valor, mostrar);
        }

        public void llenarCbo4()
        {
            CapaNegocio obj = new CapaNegocio();
            string query = "select id_cuenta_pk from cuenta_corriente_por_pagar;";
            string tabla = "cuenta_corriente_por_pagar";
            string valor = "id_cuenta_pk";
            string mostrar = "id_cuenta_pk";
            cmb_cuenta_corriente = obj.llenarCbo(query, tabla, cmb_cuenta_corriente, valor, mostrar);
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            InsertarGastosImportacion abrir = new InsertarGastosImportacion();
            abrir.Show();
        }

        private void rbtn_si_CheckedChanged(object sender, EventArgs e)
        {
            gpb_importacion.Enabled = true;
            btn_agregar.Enabled = true;
        }

        private void rbtn_no_CheckedChanged(object sender, EventArgs e)
        {
            gpb_importacion.Enabled = false;
            btn_agregar.Enabled = false;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                String txt_estado = "ACTIVO";
                dtp_fecha_recibida.Format = DateTimePickerFormat.Custom;
                dtp_fecha_recibida.CustomFormat = "yyyy-MM-dd";
                int resultado = Manejo.compra(txt_factura.Text.Trim(), cmb_orden_pedido.SelectedValue.ToString().Trim(), txt_serie.Text.Trim(), dtp_fecha_recibida.Text.Trim(), txt_encargado.Text.Trim(), txt_total.Text.Trim(), txt_estado, cmb_cuenta_corriente.Text.Trim(), cmb_proveedor.Text.Trim(), cmb_forma_pago.Text.Trim());
                if (resultado > 0)
                {
                    MessageBox.Show("Agregada Exitosamente");
                }
                else
                {
                    MessageBox.Show("No se pudo Ingresar");
                }
            }
            catch
            {
                MessageBox.Show("Ocurrio un error durante el proceso...", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                String codigo2 = this.dgv_detalle_compra.CurrentRow.Cells[0].Value.ToString();
                String atributo2 = "id_detalle_pedido_pk";
                //String campo = "estado";
                var resultado = MessageBox.Show("DESEA BORRAR EL REGISTRO SELECCIONADO", "CONFIRME SU ACCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {

                    CapaNegocio fn = new CapaNegocio();
                    string tabla = "detalle_pedido_compra";
                    fn.eliminar(tabla, atributo2, codigo2);

                }
            }
            catch
            {
                MessageBox.Show("No se ha seleccionado ningun registro a eliminar", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InsertarCompra_Load(object sender, EventArgs e)
        {
            CapaNegocio fn = new CapaNegocio();
            fn.InhabilitarComponentes(this);
            llenarCbo1();
            llenarCbo2();
            llenarCbo3();
            llenarCbo4();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            Editar = false;
            CapaNegocio fn = new CapaNegocio();
            fn.ActivarControles(this);
            fn.LimpiarComponentes(this);
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Editar = false;
            CapaNegocio fn = new CapaNegocio();
            fn.LimpiarComponentes(this);
            fn.InhabilitarComponentes(this);
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            CapaNegocio fn = new CapaNegocio();
            string tabla = "detalle_pedido_compra";
            fn.ActualizarGrid(this.dgv_detalle_compra, "select * from detalle_pedido_compra where id_pedido_compra_pk = '"+ cmb_orden_pedido.SelectedValue + "'", tabla);
        }
    }
}
