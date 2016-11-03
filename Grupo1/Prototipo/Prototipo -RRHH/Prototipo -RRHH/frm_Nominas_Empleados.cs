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
        DataGridView dg;

        public frm_Nominas_Empleados(DataGridView dgv, String id_nomina_pk, String nombre_nomina, String fecha_inicio_pago, String fecha_de_corte, String id_empresa_pk, String estado, Boolean Editar1, Boolean tipo_accion)
        {
            this.dg = dgv;
            this.Editar = Editar1;
            InitializeComponent();
            atributo = "id_nomina_pk";
            this.Codigo = id_nomina_pk;
            if (tipo_accion == true)
            {
                this.txt_nomb_nomina.Text = nombre_nomina;
                this.txt_cbo_id_empresa.Text = id_empresa_pk;

                this.txt_dtp_fech_inicio.Text = fecha_inicio_pago; dtp_fech_inicio.Text = txt_dtp_fech_inicio.Text;
                this.txt_dtp_fecha_corte.Text = fecha_de_corte; dtp_fecha_corte.Text = txt_dtp_fecha_corte.Text;
            }
        }

        private void frm_Nominas_Empleados_Load(object sender, EventArgs e)
        {
            fn.InhabilitarComponentes(gpb_regist_nominas);
            fn.InhabilitarComponentes(this);
            llenarCbo1();

        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
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
            string mostrar = "nombre";
            cbo_id_empresa = fn.llenarCbo(query, tabla, cbo_id_empresa, valor, mostrar);
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            //try
            //{
            txt_cbo_id_empresa.Text = cbo_id_empresa.SelectedValue.ToString();
            txt_dtp_fech_inicio.Text = dtp_fech_inicio.Value.ToString("yyyy-MM-dd");
            txt_dtp_fecha_corte.Text = dtp_fecha_corte.Value.ToString("yyyy-MM-dd");
            TextBox[] textbox = { txt_nomb_nomina, txt_cbo_id_empresa, txt_dtp_fech_inicio, txt_dtp_fecha_corte };
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
            //}
            //catch
            // {
            //    MessageBox.Show("Ocurrio un error durante el proceso...", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            // }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                String codigo2 = this.dg.CurrentRow.Cells[0].Value.ToString();
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
            fn.ActualizarGrid(this.dg, "Select id_nomina_pk, nombre_nomina, fecha_inicio_pago, fecha_de_corte, id_empresa_pk, estado from nomina WHERE estado <> 'INACTIVO' ", tabla);
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                Editar = true;
                atributo = "id_nomina_pk";

                this.Codigo = this.dg.CurrentRow.Cells[0].Value.ToString();
                this.txt_nomb_nomina.Text = this.dg.CurrentRow.Cells[1].Value.ToString();
                this.txt_dtp_fech_inicio.Text = this.dg.CurrentRow.Cells[2].Value.ToString(); dtp_fech_inicio.Text = txt_dtp_fech_inicio.Text;
                this.txt_dtp_fecha_corte.Text = this.dg.CurrentRow.Cells[3].Value.ToString(); dtp_fecha_corte.Text = txt_dtp_fecha_corte.Text;
                this.txt_cbo_id_empresa.Text = this.dg.CurrentRow.Cells[4].Value.ToString(); cbo_id_empresa.SelectedValue = txt_cbo_id_empresa.Text;
                fn.ActivarControles(gpb_regist_nominas);
            }
            catch
            {
                MessageBox.Show("No se ha seleccionado ningun registro a editar", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            fn.Anterior(dg);

        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            fn.Siguiente(dg);

        }

        private void btn_primero_Click(object sender, EventArgs e)
        {
            fn.Primero(dg);

        }

        private void btn_ultimo_Click(object sender, EventArgs e)
        {
            fn.Ultimo(dg);
        }

        private void dgv_datos_nominas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
