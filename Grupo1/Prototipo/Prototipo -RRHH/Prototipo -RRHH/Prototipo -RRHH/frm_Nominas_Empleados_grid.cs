using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using FuncionesNavegador;
using dllconsultas;

namespace Prototipo__RRHH
{
    public partial class frm_Nominas_Empleados_grid : Form
    {
        public frm_Nominas_Empleados_grid()
        {
            InitializeComponent();
        }

        CapaNegocio fn = new CapaNegocio();
        operaciones op = new operaciones();
        Boolean Editar1;
        Boolean tipo_accion;
        String id_nomina_pk, nombre_nomina, fecha_inicio_pago, fecha_de_corte, id_empresa_pk, estado;

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            fn.Siguiente(dgv_lista_nomias);
        }

        private void btn_primero_Click(object sender, EventArgs e)
        {
            fn.Primero(dgv_lista_nomias);
        }

        private void btn_ultimo_Click(object sender, EventArgs e)
        {
            fn.Ultimo(dgv_lista_nomias);
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            Editar1 = false;
            frm_Nominas_Empleados frm_nom_emp = new frm_Nominas_Empleados(dgv_lista_nomias, id_nomina_pk, nombre_nomina, fecha_inicio_pago, fecha_de_corte, id_empresa_pk, estado, Editar1, tipo_accion, cbo_lista_nom);
            frm_nom_emp.MdiParent = this.ParentForm;
            frm_nom_emp.Show();
        }



        private void cbo_lista_nom_SelectedValueChanged(object sender, EventArgs e)
        {
            string tabla = "nomina";
            fn.ActualizarGrid(this.dgv_lista_nomias, "Select id_nomina_pk, nombre_nomina, fecha_inicio_pago, fecha_de_corte, id_empresa_pk, estado from nomina WHERE estado <> 'INACTIVO' and id_empresa_pk = '" + cbo_lista_nom.SelectedValue + "' ", tabla);
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            Editar1 = true;
            frm_Nominas_Empleados frm_nom_emp = new frm_Nominas_Empleados(dgv_lista_nomias, id_nomina_pk, nombre_nomina, fecha_inicio_pago, fecha_de_corte, id_empresa_pk, estado, Editar1, tipo_accion, cbo_lista_nom);
            frm_nom_emp.MdiParent = this.ParentForm;
            frm_nom_emp.Show();
        }

        private void dgv_lista_nomias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id_nomina_pk = this.dgv_lista_nomias.CurrentRow.Cells[0].Value.ToString();
            fecha_inicio_pago = this.dgv_lista_nomias.CurrentRow.Cells[2].Value.ToString();
            fecha_de_corte = this.dgv_lista_nomias.CurrentRow.Cells[3].Value.ToString();
            id_empresa_pk = this.dgv_lista_nomias.CurrentRow.Cells[4].Value.ToString();
            

            frm_Nomina frm_nomina = new frm_Nomina(id_empresa_pk, fecha_inicio_pago, fecha_de_corte, id_nomina_pk);
            frm_nomina.MdiParent = this.ParentForm;
            frm_nomina.Show();
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            fn.Anterior(dgv_lista_nomias);
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            string tabla = "nomina";
            fn.ActualizarGrid(this.dgv_lista_nomias, "Select id_nomina_pk, nombre_nomina, fecha_inicio_pago, fecha_de_corte, id_empresa_pk, estado from nomina WHERE estado <> 'INACTIVO' and id_empresa_pk = '" + cbo_lista_nom.SelectedValue + "' ", tabla);

        }

        private void frm_Nominas_Empleados_grid_Load(object sender, EventArgs e)
        {
            llenaridempresa();
            string tabla = "nomina";
            fn.ActualizarGrid(this.dgv_lista_nomias, "Select id_nomina_pk, nombre_nomina, fecha_inicio_pago, fecha_de_corte, id_empresa_pk, estado from nomina WHERE estado <> 'INACTIVO' and id_empresa_pk = '" + cbo_lista_nom.SelectedValue + "' ", tabla);
        }

        public void llenaridempresa()
        {

            Conexionmysql.ObtenerConexion();
            DataSet ds = new DataSet();

            String Query = "select id_empresa_pk, nombre from empresa Where estado <>'INACTIVO'";
            OdbcDataAdapter dad = new OdbcDataAdapter(Query, Conexionmysql.ObtenerConexion());

            dad.Fill(ds, "empresa");
            cbo_lista_nom.DataSource = ds.Tables[0].DefaultView;

            cbo_lista_nom.ValueMember = ("id_empresa_pk");
            cbo_lista_nom.DisplayMember = ("nombre");

            Conexionmysql.Desconectar();
        }



    }
}
