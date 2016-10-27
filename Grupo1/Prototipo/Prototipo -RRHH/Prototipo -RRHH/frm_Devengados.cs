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
                CapaNegocio fn = new CapaNegocio();
                TextBox[] textbox = { txt_nom_deveng, txt_detall_deveng, txt_cbo_id_emps, txt_cantid_deveng, txt_canti_deveng, txt_dtp_fecha_deveng, txt_estado };
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
                Codigo = this.dgv_devengos.CurrentRow.Cells[0].Value.ToString();
                TextBox[] textbox = { txt_nom_deveng, txt_detall_deveng, txt_cbo_id_emps, txt_cantid_deveng, txt_canti_deveng, txt_dtp_fecha_deveng, txt_estado };
                fn.llenartextbox(textbox, dgv_devengos);
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
                String codigo2 = this.dgv_devengos.CurrentRow.Cells[0].Value.ToString();
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
            fn.ActualizarGrid(this.dgv_devengos, "Select * from devengos WHERE estado <> 'INACTIVO' ", tabla);
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            fn.Anterior(dgv_devengos);
            TextBox[] textbox = { txt_nom_deveng, txt_detall_deveng, txt_cbo_id_emps, txt_cantid_deveng, txt_canti_deveng, txt_dtp_fecha_deveng, txt_estado };
            fn.llenartextbox(textbox, dgv_devengos);
            dtp_fecha_deveng.Text = txt_dtp_fecha_deveng.Text;
            cbo_id_emps.Text = txt_cbo_id_emps.Text;
            cbo_tip_devenga.Text = txt_cbo_tip_devenga.Text;
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            fn.Siguiente(dgv_devengos);
            TextBox[] textbox = { txt_nom_deveng, txt_detall_deveng, txt_cbo_id_emps, txt_cantid_deveng, txt_canti_deveng, txt_dtp_fecha_deveng, txt_estado };
            fn.llenartextbox(textbox, dgv_devengos);
            dtp_fecha_deveng.Text = txt_dtp_fecha_deveng.Text;
            cbo_id_emps.Text = txt_cbo_id_emps.Text;
            cbo_tip_devenga.Text = txt_cbo_tip_devenga.Text;
        }

        private void btn_primero_Click(object sender, EventArgs e)
        {
            fn.Primero(dgv_devengos);
            TextBox[] textbox = { txt_nom_deveng, txt_detall_deveng, txt_cbo_id_emps, txt_cantid_deveng, txt_canti_deveng, txt_dtp_fecha_deveng, txt_estado };
            fn.llenartextbox(textbox, dgv_devengos);
            dtp_fecha_deveng.Text = txt_dtp_fecha_deveng.Text;
            cbo_id_emps.Text = txt_cbo_id_emps.Text;
            cbo_tip_devenga.Text = txt_cbo_tip_devenga.Text;
        }

        private void btn_ultimo_Click(object sender, EventArgs e)
        {
            fn.Ultimo(dgv_devengos);
            TextBox[] textbox = { txt_nom_deveng, txt_detall_deveng, txt_cbo_id_emps, txt_cantid_deveng, txt_canti_deveng, txt_dtp_fecha_deveng, txt_estado };
            fn.llenartextbox(textbox, dgv_devengos);
            dtp_fecha_deveng.Text = txt_dtp_fecha_deveng.Text;
            cbo_id_emps.Text = txt_cbo_id_emps.Text;
            cbo_tip_devenga.Text = txt_cbo_tip_devenga.Text;
        }
    }
}
