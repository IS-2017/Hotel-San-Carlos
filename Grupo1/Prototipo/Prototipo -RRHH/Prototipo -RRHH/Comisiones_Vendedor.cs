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
using dllconsultas;

namespace Prototipo__RRHH
{
    public partial class Comisiones_Vendedor : Form
    {
        public Comisiones_Vendedor()
        {
            InitializeComponent();
        }

        CapaNegocio fn = new CapaNegocio();
        String Codigo;
        Boolean Editar;
        String atributo;

        private void Comisiones_Vendedor_Load(object sender, EventArgs e)
        {
            fn.InhabilitarComponentes(gpb_com_ven);
            fn.InhabilitarComponentes(this);
            llenarCbo1();
            llenarCbo2();
            llenarCbo3();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            try
            {
                Editar = false;
                fn.ActivarControles(gpb_com_ven);
                fn.LimpiarComponentes(gpb_com_ven);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            try
            {
                Editar = false;
                fn.LimpiarComponentes(gpb_com_ven);
                fn.InhabilitarComponentes(gpb_com_ven);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            string tabla = "com_venta";
            fn.ActualizarGrid(this.dgb_comis_ventas, "Select * from com_venta WHERE estado <> 'INACTIVO' ", tabla);
        }

        public void llenarCbo1()
        {
            string query = "select id_devengos_pk, nombre from devengos;";
            string tabla = "devengos";
            string valor = "id_devengos_pk";
            string mostrar = "nombre";
            cbo_cod_deveng = fn.llenarCbo(query, tabla, cbo_cod_deveng, valor, mostrar);
        }

        public void llenarCbo2()
        {
            string query = "select id_empresa_pk, nombre from empresa;";
            string tabla = "empresa";
            string valor = "id_empresa_pk";
            string mostrar = "nombre";
            cbo_id_empresa = fn.llenarCbo(query, tabla, cbo_id_empresa, valor, mostrar);
        }

        public void llenarCbo3()
        {
            string query = "select id_empleados_pk, nombre from empleado;";
            string tabla = "empleado";
            string valor = "id_empleados_pk";
            string mostrar = "nombre";
            cbo_id_empl = fn.llenarCbo(query, tabla, cbo_id_empl, valor, mostrar);
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                string tabla = "empleado";
                operaciones op = new operaciones();
                op.ejecutar(dgb_comis_ventas, tabla);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                txt_dtp_fecha_com_vent.Text = dtp_fecha_com_vent.Value.ToString("yyyy-MM-dd");
                txt_cbo_cod_deveng.Text = cbo_cod_deveng.SelectedValue.ToString();
                txt_cbo_id_empresa.Text = cbo_id_empresa.SelectedValue.ToString();
                txt_cbo_id_empl.Text = cbo_id_empl.SelectedValue.ToString();

                TextBox[] textbox = { txt_nom_ved, txt_dtp_fecha_com_vent, txt_cbo_cod_deveng, txt_cbo_id_empresa, txt_comision, txt_total_com, txt_cbo_id_empl, txt_estado };
                DataTable datos = fn.construirDataTable(textbox);
                if (datos.Rows.Count == 0)
                {
                    MessageBox.Show("Hay campos vacios", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string tabla = "com_venta";
                    if (Editar)
                    {
                        fn.modificar(datos, tabla, atributo, Codigo);
                    }
                    else
                    {
                        fn.insertar(datos, tabla);
                    }
                    fn.LimpiarComponentes(this);
                }
            }
            catch
            {
                MessageBox.Show("Ocurrio un error durante el proceso...", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                Editar = true;
                atributo = "id_com_venta_pk";
                Codigo = this.dgb_comis_ventas.CurrentRow.Cells[0].Value.ToString();
                TextBox[] textbox = { txt_nom_ved, txt_dtp_fecha_com_vent, txt_cbo_cod_deveng, txt_cbo_id_empresa, txt_comision, txt_total_com, txt_cbo_id_empl, txt_estado };
                fn.llenartextbox(textbox, dgb_comis_ventas);
            }
            catch
            {
                MessageBox.Show("No se ha seleccionado ningun registro a editar", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                String codigo2 = this.dgb_comis_ventas.CurrentRow.Cells[0].Value.ToString();
                String atributo2 = "id_com_venta_pk";
                //String campo = "estado";
                var resultado = MessageBox.Show("DESEA BORRAR EL REGISTRO SELECCIONADO", "CONFIRME SU ACCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {

                    CapaNegocio fn = new CapaNegocio();
                    string tabla = "com_venta";
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
            fn.Anterior(dgb_comis_ventas);
            TextBox[] textbox = { txt_nom_ved, txt_dtp_fecha_com_vent, txt_cbo_cod_deveng, txt_cbo_id_empresa, txt_comision, txt_total_com, txt_cbo_id_empl, txt_estado };
            fn.llenartextbox(textbox, dgb_comis_ventas);
            dtp_fecha_com_vent.Text = txt_dtp_fecha_com_vent.Text;
            cbo_cod_deveng.Text = txt_cbo_cod_deveng.Text;
            cbo_id_empresa.Text = txt_cbo_id_empresa.Text;
            cbo_id_empl.Text = txt_cbo_id_empl.Text;

        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            fn.Siguiente(dgb_comis_ventas);
            TextBox[] textbox = { txt_nom_ved, txt_dtp_fecha_com_vent, txt_cbo_cod_deveng, txt_cbo_id_empresa, txt_comision, txt_total_com, txt_cbo_id_empl, txt_estado };
            fn.llenartextbox(textbox, dgb_comis_ventas);
            dtp_fecha_com_vent.Text = txt_dtp_fecha_com_vent.Text;
            cbo_cod_deveng.Text = txt_cbo_cod_deveng.Text;
            cbo_id_empresa.Text = txt_cbo_id_empresa.Text;
            cbo_id_empl.Text = txt_cbo_id_empl.Text;
        }

        private void btn_primero_Click(object sender, EventArgs e)
        {
            fn.Primero(dgb_comis_ventas);
            TextBox[] textbox = { txt_nom_ved, txt_dtp_fecha_com_vent, txt_cbo_cod_deveng, txt_cbo_id_empresa, txt_comision, txt_total_com, txt_cbo_id_empl, txt_estado };
            fn.llenartextbox(textbox, dgb_comis_ventas);
            dtp_fecha_com_vent.Text = txt_dtp_fecha_com_vent.Text;
            cbo_cod_deveng.Text = txt_cbo_cod_deveng.Text;
            cbo_id_empresa.Text = txt_cbo_id_empresa.Text;
            cbo_id_empl.Text = txt_cbo_id_empl.Text;
        }

        private void btn_ultimo_Click(object sender, EventArgs e)
        {
            fn.Ultimo(dgb_comis_ventas);
            TextBox[] textbox = { txt_nom_ved, txt_dtp_fecha_com_vent, txt_cbo_cod_deveng, txt_cbo_id_empresa, txt_comision, txt_total_com, txt_cbo_id_empl, txt_estado };
            fn.llenartextbox(textbox, dgb_comis_ventas);
            dtp_fecha_com_vent.Text = txt_dtp_fecha_com_vent.Text;
            cbo_cod_deveng.Text = txt_cbo_cod_deveng.Text;
            cbo_id_empresa.Text = txt_cbo_id_empresa.Text;
            cbo_id_empl.Text = txt_cbo_id_empl.Text;
        }
    }
}
