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
    public partial class frm_Empleados_grid : Form
    {
        public frm_Empleados_grid()
        {
            InitializeComponent();
        }

        CapaNegocio fn = new CapaNegocio();
        operaciones op = new operaciones();
        Boolean Editar1;
        Boolean tipo_accion;
        String id_empleados_pk, nombre, telefono, direccion, genero, fecha_nacimiento, fecha_ingreso, fecha_egreso, dpi, no_afiliacion_igss, estado, edad, nacionalidad, estado_civil, cargo, sueldo, tipo_sueldo, id_empresa_pk;



        private void frm_Empleados_grid_Load(object sender, EventArgs e)
        {
                string tabla = "empleado";
                fn.ActualizarGrid(this.dgv_lista_emps, "Select `id_empleados_pk`, `nombre`, `telefono`, `direccion`, `genero`, `fecha_nacimiento`, `fecha_ingreso`, `fecha_egreso`, `dpi`, `no_afiliacion_igss`, `estado`, `edad`, `nacionalidad`, `estado_civil`, `cargo`, `sueldo`, `tipo_sueldo`, `id_empresa_pk` from empleado WHERE estado <> 'INACTIVO' ", tabla);

        }



        private void dgv_lista_emps_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Editar1 = true;
            tipo_accion = true;
            /* frm_empleados.txt_cod_emp.Text = this.dgv_lista_emps.CurrentRow.Cells[0].Value.ToString();
             frm_empleados.txt_nomb_emp.Text = this.dgv_lista_emps.CurrentRow.Cells[1].Value.ToString();
             frm_empleados.txt_telef_emp.Text = this.dgv_lista_emps.CurrentRow.Cells[2].Value.ToString();
             frm_empleados.txt_direc_emp.Text = this.dgv_lista_emps.CurrentRow.Cells[3].Value.ToString();
             frm_empleados.cbo_gener_emp.Text = this.dgv_lista_emps.CurrentRow.Cells[4].Value.ToString();
             frm_empleados.dtp_fecha_nacim.Text = this.dgv_lista_emps.CurrentRow.Cells[5].Value.ToString();
             frm_empleados.dtp_fecha_ingr_emp.Text = this.dgv_lista_emps.CurrentRow.Cells[6].Value.ToString();
             frm_empleados.dtp_fecha_egre_emp.Text = this.dgv_lista_emps.CurrentRow.Cells[7].Value.ToString();
             frm_empleados.txt_dpi_emp.Text = this.dgv_lista_emps.CurrentRow.Cells[8].Value.ToString();
             frm_empleados.txt_carne_igss_emp.Text = this.dgv_lista_emps.CurrentRow.Cells[9].Value.ToString();
             frm_empleados.txt_edad_emp.Text = this.dgv_lista_emps.CurrentRow.Cells[11].Value.ToString();
             frm_empleados.cbo_nacional_emp.Text = this.dgv_lista_emps.CurrentRow.Cells[12].Value.ToString();
             frm_empleados.cbo_estad_civ_emp.Text = this.dgv_lista_emps.CurrentRow.Cells[13].Value.ToString();
             frm_empleados.cbo_cargo_emp.Text = this.dgv_lista_emps.CurrentRow.Cells[14].Value.ToString();
             frm_empleados.txt_sueldo_emp.Text = this.dgv_lista_emps.CurrentRow.Cells[15].Value.ToString();*/

            id_empleados_pk = this.dgv_lista_emps.CurrentRow.Cells[0].Value.ToString();
            nombre = this.dgv_lista_emps.CurrentRow.Cells[1].Value.ToString();
            telefono = this.dgv_lista_emps.CurrentRow.Cells[2].Value.ToString();
            direccion = this.dgv_lista_emps.CurrentRow.Cells[3].Value.ToString();
            genero = this.dgv_lista_emps.CurrentRow.Cells[4].Value.ToString();
            fecha_nacimiento = this.dgv_lista_emps.CurrentRow.Cells[5].Value.ToString();
            fecha_ingreso = this.dgv_lista_emps.CurrentRow.Cells[6].Value.ToString();
            fecha_egreso = this.dgv_lista_emps.CurrentRow.Cells[7].Value.ToString();
            dpi = this.dgv_lista_emps.CurrentRow.Cells[8].Value.ToString();
            no_afiliacion_igss = this.dgv_lista_emps.CurrentRow.Cells[9].Value.ToString();
            estado = this.dgv_lista_emps.CurrentRow.Cells[10].Value.ToString();
            edad = this.dgv_lista_emps.CurrentRow.Cells[11].Value.ToString();
            nacionalidad = this.dgv_lista_emps.CurrentRow.Cells[12].Value.ToString();
            estado_civil = this.dgv_lista_emps.CurrentRow.Cells[13].Value.ToString();
            cargo = this.dgv_lista_emps.CurrentRow.Cells[14].Value.ToString();
            sueldo = this.dgv_lista_emps.CurrentRow.Cells[15].Value.ToString();
            tipo_sueldo = this.dgv_lista_emps.CurrentRow.Cells[16].Value.ToString();
            id_empresa_pk = this.dgv_lista_emps.CurrentRow.Cells[17].Value.ToString();
            Empleados frm_empleados = new Empleados(dgv_lista_emps, id_empleados_pk, nombre, telefono, direccion, genero, fecha_nacimiento, fecha_ingreso, fecha_egreso, dpi, no_afiliacion_igss, estado, edad, nacionalidad, estado_civil, cargo, sueldo, tipo_sueldo, id_empresa_pk, Editar1, tipo_accion);
            frm_empleados.MdiParent = this.ParentForm;
            frm_empleados.Show();           
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {

        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            Editar1 = false;
            Empleados frm_empleados = new Empleados(dgv_lista_emps, id_empleados_pk, nombre, telefono, direccion, genero, fecha_nacimiento, fecha_ingreso, fecha_egreso, dpi, no_afiliacion_igss, estado, edad, nacionalidad, estado_civil, cargo, sueldo, tipo_sueldo, id_empresa_pk, Editar1, tipo_accion); 
            frm_empleados.MdiParent = this.ParentForm;
            frm_empleados.Show();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string tabla = "deducciones";
            op.ejecutar(dgv_lista_emps, tabla);
        }

        private void btn_actualizar_Click_1(object sender, EventArgs e)
        {
            string tabla = "empleado";
            fn.ActualizarGrid(this.dgv_lista_emps, "Select id_empleados_pk, nombre, telefono, direccion, genero, fecha_nacimiento, fecha_ingreso, fecha_egreso, dpi, no_afiliacion_igss, estado, edad, nacionalidad, estado_civil, cargo, sueldo, tipo_sueldo, id_empresa_pk from empleado WHERE estado <> 'INACTIVO' ", tabla);
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            fn.Anterior(dgv_lista_emps);
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            fn.Siguiente(dgv_lista_emps);
        }

        private void btn_primero_Click(object sender, EventArgs e)
        {
            fn.Primero(dgv_lista_emps);
        }

        private void btn_ultimo_Click(object sender, EventArgs e)
        {
            fn.Ultimo(dgv_lista_emps);
        }
    }
}
