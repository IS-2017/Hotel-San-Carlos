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
    public partial class frm_Devengados_grid : Form
    {
        public frm_Devengados_grid()
        {
            InitializeComponent();
        }

        CapaNegocio fn = new CapaNegocio();
        operaciones op = new operaciones();
        Boolean Editar1;
        Boolean tipo_accion;
        String id_devengos_pk, nombre, detalle, cantidad_debengado, cuotas, fecha, id_empleados_pk, estado;

        private void dgv_lista_deveng_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Editar1 = true;
            tipo_accion = true;
            id_devengos_pk = this.dgv_lista_deveng.CurrentRow.Cells[0].Value.ToString(); 
            nombre = this.dgv_lista_deveng.CurrentRow.Cells[1].Value.ToString();
            detalle = this.dgv_lista_deveng.CurrentRow.Cells[2].Value.ToString();
            cantidad_debengado = this.dgv_lista_deveng.CurrentRow.Cells[3].Value.ToString();
            cuotas = this.dgv_lista_deveng.CurrentRow.Cells[4].Value.ToString();
            fecha = this.dgv_lista_deveng.CurrentRow.Cells[5].Value.ToString();
            id_empleados_pk = this.dgv_lista_deveng.CurrentRow.Cells[6].Value.ToString();
            estado = this.dgv_lista_deveng.CurrentRow.Cells[7].Value.ToString();
            frm_Devengados frm_deveng = new frm_Devengados(dgv_lista_deveng, id_devengos_pk, nombre, detalle, cantidad_debengado, cuotas, fecha, id_empleados_pk, estado, Editar1, tipo_accion);
            frm_deveng.MdiParent = this.ParentForm;
            frm_deveng.Show();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            Editar1 = false;
            frm_Devengados frm_deveng = new frm_Devengados(dgv_lista_deveng, id_devengos_pk, nombre, detalle, cantidad_debengado, cuotas, fecha, id_empleados_pk, estado, Editar1, tipo_accion); 
            frm_deveng.MdiParent = this.ParentForm;
            frm_deveng.Show();
        }

        private void btn_ultimo_Click(object sender, EventArgs e)
        {
            fn.Ultimo(dgv_lista_deveng);
        }

        private void btn_primero_Click(object sender, EventArgs e)
        {
            fn.Primero(dgv_lista_deveng);
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            fn.Siguiente(dgv_lista_deveng);
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            fn.Anterior(dgv_lista_deveng);
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            string tabla = "devengos";
            fn.ActualizarGrid(this.dgv_lista_deveng, "Select id_devengos_pk, nombre, detalle, cantidad_debengado, cuotas, fecha, id_empleados_pk, estado from devengos WHERE estado <> 'INACTIVO' ", tabla);

        }

        private void frm_Devengados_grid_Load(object sender, EventArgs e)
        {
            string tabla = "devengos";
            fn.ActualizarGrid(this.dgv_lista_deveng, "Select id_devengos_pk, nombre, detalle, cantidad_debengado, cuotas, fecha, id_empleados_pk, estado from devengos WHERE estado <> 'INACTIVO' ", tabla);

        }
    }
}
