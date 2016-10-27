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


namespace Prototipo__RRHH
{
    public partial class frm_Empleados_grid : Form
    {
        public frm_Empleados_grid()
        {
            InitializeComponent();
        }

        CapaNegocio fn = new CapaNegocio();

        private void dgv_datos_emp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frm_Empleados_grid_Load(object sender, EventArgs e)
        {
                string tabla = "empleado";
                fn.ActualizarGrid(this.dgv_lista_emps, "Select `id_empleados_pk`, `nombre`, `telefono`, `direccion`, `genero`, `fecha_nacimiento`, `fecha_ingreso`, `fecha_egreso`, `dpi`, `no_afiliacion_igss`, `estado`, `edad`, `nacionalidad`, `estado_civil`, `cargo`, `sueldo`, `tipo_sueldo` from empleado WHERE estado <> 'INACTIVO' ", tabla);

        }

        public void GridViewActualizar(DataGridView dgv, String Query)
        {
            //Establecemos la conexion
            Conexionmysql.ObtenerConexion();
            //creamos el DataSet a utilizar
            System.Data.DataSet newDataSet = new System.Data.DataSet();
            //Creamos un nuevo adaptador de datos
            OdbcDataAdapter newDataAdapter = new OdbcDataAdapter(Query, Conexionmysql.ObtenerConexion());
            //LLenamos el DataSet
            newDataAdapter.Fill(newDataSet, "empleado");
            //Asignando valores al DataGrid
            dgv.DataSource = newDataSet;
            dgv.DataMember = "empleado";
            Conexionmysql.Desconectar();
        }

        private void txt_buscar_KeyUp(object sender, KeyEventArgs e)
        {
            Conexionmysql.ObtenerConexion();
            String Query = ("select `id_empleados_pk`, `nombre`, `telefono`, `direccion`, `genero`, `fecha_nacimiento`, `fecha_ingreso`, `fecha_egreso`, `dpi`, `no_afiliacion_igss`, `estado`, `edad`, `nacionalidad`, `estado_civil`, `cargo`, `sueldo`, `tipo_sueldo`, `id_empresa_pk` from empleado WHERE nombre like '%" + txt_buscar.Text + "%'");
            Conexionmysql.EjecutarMySql(Query);
            GridViewActualizar(this.dgv_lista_emps, Query);
            Conexionmysql.Desconectar();
        }

        private void dgv_lista_emps_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Empleados frm_emp = new Empleados();
            frm_emp.txt_cod_emp.Text = this.dgv_lista_emps.CurrentRow.Cells[0].Value.ToString();
            frm_emp.txt_nomb_emp.Text = this.dgv_lista_emps.CurrentRow.Cells[1].Value.ToString();
            frm_emp.txt_telef_emp.Text = this.dgv_lista_emps.CurrentRow.Cells[2].Value.ToString();
            frm_emp.txt_direc_emp.Text = this.dgv_lista_emps.CurrentRow.Cells[3].Value.ToString();
            frm_emp.cbo_gener_emp.Text = this.dgv_lista_emps.CurrentRow.Cells[4].Value.ToString();
            frm_emp.dtp_fecha_nacim.Text = this.dgv_lista_emps.CurrentRow.Cells[5].Value.ToString();
            frm_emp.dtp_fecha_ingr_emp.Text = this.dgv_lista_emps.CurrentRow.Cells[6].Value.ToString();
            frm_emp.dtp_fecha_egre_emp.Text = this.dgv_lista_emps.CurrentRow.Cells[7].Value.ToString();
            frm_emp.txt_dpi_emp.Text = this.dgv_lista_emps.CurrentRow.Cells[8].Value.ToString();
            frm_emp.txt_carne_igss_emp.Text = this.dgv_lista_emps.CurrentRow.Cells[9].Value.ToString();
            frm_emp.txt_edad_emp.Text = this.dgv_lista_emps.CurrentRow.Cells[11].Value.ToString();
            frm_emp.cbo_nacional_emp.Text = this.dgv_lista_emps.CurrentRow.Cells[12].Value.ToString();
            frm_emp.cbo_estad_civ_emp.Text = this.dgv_lista_emps.CurrentRow.Cells[13].Value.ToString();
            frm_emp.cbo_cargo_emp.Text = this.dgv_lista_emps.CurrentRow.Cells[14].Value.ToString();
            frm_emp.txt_sueldo_emp.Text = this.dgv_lista_emps.CurrentRow.Cells[15].Value.ToString();
            frm_emp.ShowDialog();
        }

        private void dgv_lista_emps_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
