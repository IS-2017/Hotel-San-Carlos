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
    public partial class frm_Deducciones : Form
    {
        public frm_Deducciones()
        {
            InitializeComponent();
        }

        String Codigo;
        Boolean Editar;
        String atributo;
        CapaNegocio fn = new CapaNegocio();
        DataGridView dg;

        public frm_Deducciones(DataGridView dgv,String id_presamo_pk,String nombre, String detalle,String cantidad_deduccion, String cuotas, String fecha, String estado, String id_planilla_igss_pk, String id_empleados_pk, Boolean Editar1, Boolean tipo_accion)
        {
            this.dg = dgv;
            this.Editar = Editar1;
            InitializeComponent();
            atributo = "id_presamo_pk";
            this.Codigo = id_presamo_pk;
            if (tipo_accion == true)
            {
                //this.txt_cbo_tipo_deduccion.Text = tipo_deduccion;
                this.txt_nom_deduccion.Text = nombre;
                this.txt_detall_deduccion.Text = detalle;
                //this.txt_cbo_emp_deduccion.Text = id_empleados_pk; cbo_emp_deduccion.Text = txt_cbo_emp_deduccion.Text;
                //this.txt_cbo_id_plan_IGSS.Text = id_planilla_igss_pk; cbo_id_plan_IGSS.Text = txt_cbo_id_plan_IGSS.Text;
                this.txt_cantid_deduccion.Text = cantidad_deduccion;
                this.txt_cuot_deduccion.Text = cuotas;
                this.txt_dtp_fecha_deduccion.Text = fecha; dtp_fecha_deduccion.Text = txt_dtp_fecha_deduccion.Text;

            }
            else
            {

            }
        }

        private void frm_Prestamos_Load(object sender, EventArgs e)
        {
            fn.InhabilitarComponentes(gpb_deduccion);
            fn.InhabilitarComponentes(this);
            string tabla = "deducciones";
            llenarCbo1();
            llenarCbo2();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            try
            {
                Editar = false;
                fn.LimpiarComponentes(gpb_deduccion);
                fn.InhabilitarComponentes(gpb_deduccion);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            try
            {
                Editar = false;
                fn.ActivarControles(gpb_deduccion);
                fn.LimpiarComponentes(gpb_deduccion);
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
                txt_cbo_tipo_deduccion.Text = cbo_tipo_deduccion.Text;
                txt_cbo_emp_deduccion.Text = cbo_emp_deduccion.SelectedValue.ToString();
                txt_cbo_id_plan_IGSS.Text = cbo_id_plan_IGSS.SelectedValue.ToString();
                txt_dtp_fecha_deduccion.Text = dtp_fecha_deduccion.Value.ToString("yyyy-MM-dd");
                TextBox[] textbox = { txt_nom_deduccion, txt_detall_deduccion, txt_cbo_emp_deduccion, txt_cbo_id_plan_IGSS, txt_cantid_deduccion, txt_cuot_deduccion, txt_dtp_fecha_deduccion };
                DataTable datos = fn.construirDataTable(textbox);
                if (datos.Rows.Count == 0)
                {
                    MessageBox.Show("Hay campos vacios", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string tabla = "deducciones";
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

        public void llenarCbo1()
        {
            string query = "select id_empleados_pk, nombre from empleado;";
            string tabla = "empleado";
            string valor = "id_empleados_pk";
            string mostrar = "nombre";
            cbo_emp_deduccion = fn.llenarCbo(query, tabla, cbo_emp_deduccion, valor, mostrar);
        }

        public void llenarCbo2()
        {
            string query = "select id_planilla_igss_pk from planilla_igss;";
            string tabla = "planilla_igss";
            string valor = "id_planilla_igss_pk";
            string mostrar = "id_planilla_igss_pk";
            cbo_id_plan_IGSS = fn.llenarCbo(query, tabla, cbo_id_plan_IGSS, valor, mostrar);
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            //id_presamo_pk, nombre, detalle, cantidad_deduccion, cuotas, fecha, estado, id_planilla_igss_pk, id_empleados_pk
            try
            {
                Editar = true;
                atributo = "id_presamo_pk";
                this.Codigo = this.dg.CurrentRow.Cells[0].Value.ToString();
                this.txt_nom_deduccion.Text = this.dg.CurrentRow.Cells[1].Value.ToString();
                this.txt_detall_deduccion.Text = this.dg.CurrentRow.Cells[2].Value.ToString();
                this.txt_cantid_deduccion.Text = this.dg.CurrentRow.Cells[3].Value.ToString();
                this.txt_cuot_deduccion.Text = this.dg.CurrentRow.Cells[4].Value.ToString();
                this.txt_dtp_fecha_deduccion.Text = this.dg.CurrentRow.Cells[5].Value.ToString(); dtp_fecha_deduccion.Text = txt_dtp_fecha_deduccion.Text;
                fn.ActivarControles(gpb_deduccion);
                

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
                String codigo2 = this.dg.CurrentRow.Cells[0].Value.ToString();
                String atributo2 = "id_presamo_pk";
                //String campo = "estado";
                var resultado = MessageBox.Show("DESEA BORRAR EL REGISTRO SELECCIONADO", "CONFIRME SU ACCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    string tabla = "deducciones";
                    fn.eliminar(tabla, atributo2, codigo2);

                }
            }
            catch
            {
                MessageBox.Show("No se ha seleccionado ningun registro a eliminar", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            string tabla = "deducciones";
            fn.ActualizarGrid(this.dg, "Select id_presamo_pk, nombre, detalle, cantidad_deduccion, cuotas, fecha, estado, id_planilla_igss_pk, id_empleados_pk from deducciones WHERE estado <> 'INACTIVO' ", tabla);
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            fn.Anterior(dg);
            /*TextBox[] textbox = { txt_cbo_tipo_deduccion, txt_nom_deduccion, txt_detall_deduccion, txt_cbo_emp_deduccion, txt_cbo_id_plan_IGSS, txt_cantid_deduccion, txt_cuot_deduccion, txt_dtp_fecha_deduccion, txt_estado };
            fn.llenartextbox(textbox, dgv_deducciones);
            cbo_tipo_deduccion.Text = txt_cbo_tipo_deduccion.Text;
            cbo_emp_deduccion.Text = txt_cbo_emp_deduccion.Text;
            cbo_id_plan_IGSS.Text = txt_cbo_id_plan_IGSS.Text;
            dtp_fecha_deduccion.Text = txt_dtp_fecha_deduccion.Text; */
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            fn.Siguiente(dg);
           /* TextBox[] textbox = { txt_cbo_tipo_deduccion, txt_nom_deduccion, txt_detall_deduccion, txt_cbo_emp_deduccion, txt_cbo_id_plan_IGSS, txt_cantid_deduccion, txt_cuot_deduccion, txt_dtp_fecha_deduccion, txt_estado };
            fn.llenartextbox(textbox, dgv_deducciones);
            cbo_tipo_deduccion.Text = txt_cbo_tipo_deduccion.Text;
            cbo_emp_deduccion.Text = txt_cbo_emp_deduccion.Text;
            cbo_id_plan_IGSS.Text = txt_cbo_id_plan_IGSS.Text;
            dtp_fecha_deduccion.Text = txt_dtp_fecha_deduccion.Text; */
        }

        private void btn_primero_Click(object sender, EventArgs e)
        {
            fn.Primero(dg);
           /* TextBox[] textbox = { txt_cbo_tipo_deduccion, txt_nom_deduccion, txt_detall_deduccion, txt_cbo_emp_deduccion, txt_cbo_id_plan_IGSS, txt_cantid_deduccion, txt_cuot_deduccion, txt_dtp_fecha_deduccion, txt_estado };
            fn.llenartextbox(textbox, dgv_deducciones);
            cbo_tipo_deduccion.Text = txt_cbo_tipo_deduccion.Text;
            cbo_emp_deduccion.Text = txt_cbo_emp_deduccion.Text;
            cbo_id_plan_IGSS.Text = txt_cbo_id_plan_IGSS.Text;
            dtp_fecha_deduccion.Text = txt_dtp_fecha_deduccion.Text; */
        }

        private void btn_ultimo_Click(object sender, EventArgs e)
        {
            fn.Ultimo(dg);
           /* TextBox[] textbox = { txt_cbo_tipo_deduccion, txt_nom_deduccion, txt_detall_deduccion, txt_cbo_emp_deduccion, txt_cbo_id_plan_IGSS, txt_cantid_deduccion, txt_cuot_deduccion, txt_dtp_fecha_deduccion, txt_estado };
            fn.llenartextbox(textbox, dgv_deducciones);
            cbo_tipo_deduccion.Text = txt_cbo_tipo_deduccion.Text;
            cbo_emp_deduccion.Text = txt_cbo_emp_deduccion.Text;
            cbo_id_plan_IGSS.Text = txt_cbo_id_plan_IGSS.Text;
            dtp_fecha_deduccion.Text = txt_dtp_fecha_deduccion.Text; */
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {

        }
    }
}
