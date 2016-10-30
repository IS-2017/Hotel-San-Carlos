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
    public partial class frm_Devengados : Form
    {
        public frm_Devengados()
        {
            InitializeComponent();
        }

        String Codigo;
        Boolean Editar;
        String atributo;
        CapaNegocio fn = new CapaNegocio();
        DataGridView dg;

        public frm_Devengados(DataGridView dgv, String id_devengos_pk, String nombre, String detalle, String cantidad_debengado, String cuotas, String fecha, String id_empleados_pk, String estado, Boolean Editar1, Boolean tipo_accion)
        {
            this.dg = dgv;
            this.Editar = Editar1;
            InitializeComponent();
            atributo = "id_devengos_pk";
            this.Codigo = id_devengos_pk;
            if (tipo_accion == true)
            {
                this.txt_nom_deveng.Text = nombre;
                this.txt_detall_deveng.Text = detalle;
                //this.txt_cbo_id_emps.Text = id_empleados_pk; cbo_id_emps.Text = txt_cbo_id_emps.Text; 
                this.txt_cantid_deveng.Text = cantidad_debengado;
                this.txt_dtp_fecha_deveng.Text = fecha; dtp_fecha_deveng.Text = txt_dtp_fecha_deveng.Text;
            }
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            try
            {
                Editar = false;
                fn.ActivarControles(gpb_devengado);
                fn.LimpiarComponentes(gpb_devengado);
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
                fn.LimpiarComponentes(gpb_devengado);
                fn.InhabilitarComponentes(gpb_devengado);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frm_prestaciones_lab_Load(object sender, EventArgs e)
        {
            fn.InhabilitarComponentes(gpb_devengado);
            fn.InhabilitarComponentes(this);
            llenarCbo1();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                txt_cbo_tip_devenga.Text = cbo_tip_devenga.Text;
                txt_cbo_id_emps.Text = cbo_id_emps.SelectedValue.ToString();
                txt_dtp_fecha_deveng.Text = dtp_fecha_deveng.Value.ToString("yyyy-MM-dd");
                TextBox[] textbox = { txt_nom_deveng, txt_detall_deveng, txt_cbo_id_emps, txt_cantid_deveng, txt_cuota_deveng, txt_dtp_fecha_deveng };
                DataTable datos = fn.construirDataTable(textbox);
                if (datos.Rows.Count == 0)
                {
                    MessageBox.Show("Hay campos vacios", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string tabla = "devengos";
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
            cbo_id_emps = fn.llenarCbo(query, tabla, cbo_id_emps, valor, mostrar);
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                Editar = true;
                atributo = "id_devengos_pk";
                this.Codigo = this.dg.CurrentRow.Cells[0].Value.ToString();

                this.txt_nom_deveng.Text = this.dg.CurrentRow.Cells[1].Value.ToString();
                this.txt_detall_deveng.Text= this.dg.CurrentRow.Cells[2].Value.ToString();
                this.txt_cantid_deveng.Text = this.dg.CurrentRow.Cells[3].Value.ToString();
                this.txt_cuota_deveng.Text = this.dg.CurrentRow.Cells[4].Value.ToString();
                this.txt_dtp_fecha_deveng.Text = this.dg.CurrentRow.Cells[5].Value.ToString(); dtp_fecha_deveng.Text = txt_dtp_fecha_deveng.Text;
                //this.txt_cbo_id_emps.Text = this.dg.CurrentRow.Cells[6].Value.ToString(); cbo_id_emps.Text = txt_cbo_id_emps.Text;
                this.txt_cbo_id_emps.Text = this.dg.CurrentRow.Cells[6].Value.ToString(); cbo_id_emps.SelectedValue = txt_cbo_id_emps.Text;
                fn.ActivarControles(gpb_devengado);
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
                String atributo2 = "id_devengos_pk";
                //String campo = "estado";
                var resultado = MessageBox.Show("DESEA BORRAR EL REGISTRO SELECCIONADO", "CONFIRME SU ACCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {

                    CapaNegocio fn = new CapaNegocio();
                    string tabla = "devengos";
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
            string tabla = "devengos";
            fn.ActualizarGrid(this.dg, "Select id_devengos_pk, nombre, detalle, cantidad_debengado, cuotas, fecha, id_empleados_pk, estado from devengos WHERE estado <> 'INACTIVO' ", tabla);
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            fn.Anterior(dg);
           /* TextBox[] textbox = { txt_nom_deveng, txt_detall_deveng, txt_cbo_id_emps, txt_cantid_deveng, txt_cuota_deveng, txt_dtp_fecha_deveng };
            fn.llenartextbox(textbox, dgv_devengos);
            dtp_fecha_deveng.Text = txt_dtp_fecha_deveng.Text;
            cbo_id_emps.Text = txt_cbo_id_emps.Text;
            cbo_tip_devenga.Text = txt_cbo_tip_devenga.Text; */
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            fn.Siguiente(dg);
           /* TextBox[] textbox = { txt_nom_deveng, txt_detall_deveng, txt_cbo_id_emps, txt_cantid_deveng, txt_cuota_deveng, txt_dtp_fecha_deveng };
            fn.llenartextbox(textbox, dgv_devengos);
            dtp_fecha_deveng.Text = txt_dtp_fecha_deveng.Text;
            cbo_id_emps.Text = txt_cbo_id_emps.Text;
            cbo_tip_devenga.Text = txt_cbo_tip_devenga.Text; */
        }

        private void btn_primero_Click(object sender, EventArgs e)
        {
            fn.Primero(dg);
           /* TextBox[] textbox = { txt_nom_deveng, txt_detall_deveng, txt_cbo_id_emps, txt_cantid_deveng, txt_cuota_deveng, txt_dtp_fecha_deveng };
            fn.llenartextbox(textbox, dgv_devengos);
            dtp_fecha_deveng.Text = txt_dtp_fecha_deveng.Text;
            cbo_id_emps.Text = txt_cbo_id_emps.Text;
            cbo_tip_devenga.Text = txt_cbo_tip_devenga.Text; */
        }

        private void btn_ultimo_Click(object sender, EventArgs e)
        {
            fn.Ultimo(dg);
           /* TextBox[] textbox = { txt_nom_deveng, txt_detall_deveng, txt_cbo_id_emps, txt_cantid_deveng, txt_cuota_deveng, txt_dtp_fecha_deveng };
            fn.llenartextbox(textbox, dgv_devengos);
            dtp_fecha_deveng.Text = txt_dtp_fecha_deveng.Text;
            cbo_id_emps.Text = txt_cbo_id_emps.Text;
            cbo_tip_devenga.Text = txt_cbo_tip_devenga.Text; */
        }
    }
}
