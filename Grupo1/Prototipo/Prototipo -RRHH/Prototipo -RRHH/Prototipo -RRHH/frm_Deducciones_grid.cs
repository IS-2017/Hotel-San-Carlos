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
    public partial class frm_Deducciones_grid : Form
    {
        public frm_Deducciones_grid()
        {
            InitializeComponent();
        }

        CapaNegocio fn = new CapaNegocio();
        operaciones op = new operaciones();
        Boolean Editar1;
        Boolean tipo_accion;
        String id_presamo_pk, nombre, detalle, cantidad_deduccion, cuotas, fecha, estado, id_planilla_igss_pk, id_empleados_pk;

        private void frm_Deducciones_grid_Load(object sender, EventArgs e)
        {
            string tabla = "deducciones";
            fn.ActualizarGrid(this.dgv_lista_deducc, "Select id_presamo_pk, nombre, detalle, cantidad_deduccion, cuotas, fecha, estado, id_planilla_igss_pk, id_empleados_pk from deducciones WHERE estado <> 'INACTIVO' ", tabla);
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            string tabla = "deducciones";
            fn.ActualizarGrid(this.dgv_lista_deducc, "Select id_presamo_pk, nombre, detalle, cantidad_deduccion, cuotas, fecha, estado, id_planilla_igss_pk, id_empleados_pk from deducciones WHERE estado <> 'INACTIVO' ", tabla);
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string tabla = "deducciones";
            op.ejecutar(dgv_lista_deducc, tabla);
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            fn.Anterior(dgv_lista_deducc);
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            fn.Siguiente(dgv_lista_deducc);
        }

        private void btn_primero_Click(object sender, EventArgs e)
        {
            fn.Primero(dgv_lista_deducc);
        }

        private void btn_ultimo_Click(object sender, EventArgs e)
        {
            fn.Ultimo(dgv_lista_deducc);
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            Editar1 = false;
            frm_Deducciones frm_deducc = new frm_Deducciones(dgv_lista_deducc, id_presamo_pk, nombre, detalle, cantidad_deduccion, cuotas, fecha, estado, id_planilla_igss_pk, id_empleados_pk, Editar1, tipo_accion); 
            frm_deducc.MdiParent = this.ParentForm;
            frm_deducc.Show();
        }

        private void dgv_lista_deducc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Editar1 = true;
            tipo_accion = true;
            id_presamo_pk = this.dgv_lista_deducc.CurrentRow.Cells[0].Value.ToString();
            nombre = this.dgv_lista_deducc.CurrentRow.Cells[1].Value.ToString();
            detalle = this.dgv_lista_deducc.CurrentRow.Cells[2].Value.ToString();
            cantidad_deduccion = this.dgv_lista_deducc.CurrentRow.Cells[3].Value.ToString();
            cuotas = this.dgv_lista_deducc.CurrentRow.Cells[4].Value.ToString();
            fecha = this.dgv_lista_deducc.CurrentRow.Cells[5].Value.ToString();
            estado = this.dgv_lista_deducc.CurrentRow.Cells[6].Value.ToString();
            id_planilla_igss_pk = this.dgv_lista_deducc.CurrentRow.Cells[7].Value.ToString();
            id_empleados_pk = this.dgv_lista_deducc.CurrentRow.Cells[8].Value.ToString();
            frm_Deducciones frm_deducc = new frm_Deducciones(dgv_lista_deducc, id_presamo_pk, nombre, detalle, cantidad_deduccion, cuotas, fecha, estado, id_planilla_igss_pk, id_empleados_pk, Editar1, tipo_accion);
            frm_deducc.MdiParent = this.ParentForm;
            frm_deducc.Show();
        }
    }
}
