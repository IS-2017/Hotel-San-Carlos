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
    public partial class frm_Nomina : Form
    {
        public frm_Nomina()
        {
            InitializeComponent();
        }

        CapaNegocio fn = new CapaNegocio();
        operaciones op = new operaciones();
        Boolean Editar1;
        Boolean tipo_accion;

        private void frm_Nomina_Load(object sender, EventArgs e)
        {
            string tabla = "empleado";
            fn.ActualizarGrid(this.dgv_datos_emp, "Select `id_empleados_pk`, `nombre`, `direccion`,  `fecha_ingreso`, `dpi`, `no_afiliacion_igss`, `estado`, `nacionalidad`,  `cargo`, `sueldo`,  `id_empresa_pk` from empleado WHERE estado <> 'INACTIVO' ", tabla);
        }

        private void dgv_datos_emp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            fn.Anterior(dgv_datos_emp);
            TextBox[] textbox = { txt_nom_emp_nom, txt_cargo_emp_nom, txt_num_afiliac_nom, txt_fecha_ingre_emp_nom, txt_nacion_emp_nom };
            fn.llenartextbox(textbox, dgv_datos_emp);
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            fn.Siguiente(dgv_datos_emp);
            TextBox[] textbox = { txt_nom_emp_nom, txt_cargo_emp_nom, txt_num_afiliac_nom, txt_fecha_ingre_emp_nom, txt_nacion_emp_nom };
            fn.llenartextbox(textbox, dgv_datos_emp);
        }
    }
}
