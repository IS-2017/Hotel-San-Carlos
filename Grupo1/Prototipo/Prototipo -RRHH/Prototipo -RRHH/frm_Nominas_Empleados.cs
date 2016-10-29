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
using System.Data.Odbc;

namespace Prototipo__RRHH
{
    public partial class frm_Nominas_Empleados : Form
    {
        public frm_Nominas_Empleados()
        {
            InitializeComponent();
        }

        String Codigo;
        Boolean Editar;
        String atributo;
        CapaNegocio fn = new CapaNegocio();
        string imgLoc;

        private void frm_Nominas_Empleados_Load(object sender, EventArgs e)
        {
            fn.InhabilitarComponentes(gpb_regist_nominas);
            fn.InhabilitarComponentes(this);
            llenarCbo1();
            string tabla = "nomina";
            fn.ActualizarGrid(this.dgv_datos_nominas, "Select * from nomina WHERE estado <> 'INACTIVO' ", tabla);

        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            CapaNegocio cn = new CapaNegocio();
            try
            {
                Editar = false;
                fn.ActivarControles(gpb_regist_nominas);
                fn.LimpiarComponentes(gpb_regist_nominas);
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
                fn.LimpiarComponentes(gpb_regist_nominas);
                fn.InhabilitarComponentes(gpb_regist_nominas);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void llenarCbo1()
        {
            string query = "select id_empresa_pk, nombre from Empresa;";
            string tabla = "Empresa";
            string valor = "id_empresa_pk";
            string mostrar = "id_empresa_pk";
            cbo_id_empresa = fn.llenarCbo(query, tabla, cbo_id_empresa, valor, mostrar);
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                txt_cbo_sueldo_bs.Text = cbo_id_empresa.SelectedValue.ToString();
                txt_dtp_fech_nacimient.Text = dtp_fecha_nomina.Value.ToString("yyyy-MM-dd");
                TextBox[] textbox = { txt_cbo_sueldo_bs, txt_dtp_fech_nacimient, txt_estado};
                DataTable datos = fn.construirDataTable(textbox);
                if (datos.Rows.Count == 0)
                {
                    MessageBox.Show("Hay campos vacios", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string tabla = "nomina";
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

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                String codigo2 = this.dgv_datos_nominas.CurrentRow.Cells[0].Value.ToString();
                String atributo2 = "id_nomina_pk";
                //String campo = "estado";
                var resultado = MessageBox.Show("DESEA BORRAR EL REGISTRO SELECCIONADO", "CONFIRME SU ACCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    string tabla = "nomina";
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
            string tabla = "nomina";
            fn.ActualizarGrid(this.dgv_datos_nominas, "Select * from nomina WHERE estado <> 'INACTIVO' ", tabla);
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                Editar = true;
                atributo = "id_nomina_pk";
                Codigo = this.dgv_datos_nominas.CurrentRow.Cells[0].Value.ToString();
                TextBox[] textbox = { txt_cbo_sueldo_bs, txt_dtp_fech_nacimient, txt_estado };
                fn.llenartextbox(textbox, dgv_datos_nominas);
                dtp_fecha_nomina.Text = this.dgv_datos_nominas.CurrentRow.Cells[1].Value.ToString();
                cbo_id_empresa.Text = this.dgv_datos_nominas.CurrentRow.Cells[2].Value.ToString();
                txt_estado.Text = this.dgv_datos_nominas.CurrentRow.Cells[3].Value.ToString();
                fn.ActivarControles(gpb_regist_nominas);
            }
            catch
            {
                MessageBox.Show("No se ha seleccionado ningun registro a editar", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            fn.Anterior(dgv_datos_nominas);
            TextBox[] textbox = { txt_cbo_sueldo_bs, txt_dtp_fech_nacimient, txt_estado };
            fn.llenartextbox(textbox, dgv_datos_nominas);
            dtp_fecha_nomina.Text = txt_dtp_fech_nacimient.Text;
            cbo_id_empresa.Text = txt_cbo_sueldo_bs.Text;
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            fn.Siguiente(dgv_datos_nominas);
            TextBox[] textbox = { txt_cbo_sueldo_bs, txt_dtp_fech_nacimient, txt_estado };
            fn.llenartextbox(textbox, dgv_datos_nominas);
            dtp_fecha_nomina.Text = txt_dtp_fech_nacimient.Text;
            cbo_id_empresa.Text = txt_cbo_sueldo_bs.Text;
        }

        private void btn_primero_Click(object sender, EventArgs e)
        {
            fn.Primero(dgv_datos_nominas);
            TextBox[] textbox = { txt_cbo_sueldo_bs, txt_dtp_fech_nacimient, txt_estado };
            fn.llenartextbox(textbox, dgv_datos_nominas);
            dtp_fecha_nomina.Text = txt_dtp_fech_nacimient.Text;
            cbo_id_empresa.Text = txt_cbo_sueldo_bs.Text;
        }

        private void btn_ultimo_Click(object sender, EventArgs e)
        {
            fn.Ultimo(dgv_datos_nominas);
            TextBox[] textbox = { txt_cbo_sueldo_bs, txt_dtp_fech_nacimient, txt_estado };
            fn.llenartextbox(textbox, dgv_datos_nominas);
            dtp_fecha_nomina.Text = txt_dtp_fech_nacimient.Text;
            cbo_id_empresa.Text = txt_cbo_sueldo_bs.Text;
        }

        private void dgv_datos_nominas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
