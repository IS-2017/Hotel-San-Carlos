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
    public partial class Buscar_planilla : Form
    {
        public Buscar_planilla()
        {
            InitializeComponent();
        }
        CapaNegocio fn = new CapaNegocio();
        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            Planilla_IGSS a = new Planilla_IGSS(dataGridView1);
            a.MdiParent = this.ParentForm;
            a.Show();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Planilla_IGSS a = new Planilla_IGSS(dataGridView1);
            a.MdiParent = this.ParentForm;
            a.Show();
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            string tabla = "detalle_planilla_igss";
            fn.ActualizarGrid(this.dataGridView1, "SELECT DISTINCT E.id_empresa_pk, E.nombre, DP.fecha FROM empresa E, planilla_igss P, detalle_planilla_igss DP WHERE(E.id_empresa_pk = P.id_empresa_pk AND P.id_planilla_igss_pk = DP.id_planilla_igss_pk);", tabla);
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            fn.Anterior(dataGridView1);
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            fn.Siguiente(dataGridView1);
        }

        private void btn_primero_Click(object sender, EventArgs e)
        {
            fn.Primero(dataGridView1);
        }

        private void btn_ultimo_Click(object sender, EventArgs e)
        {
            fn.Ultimo(dataGridView1);
        }

        private void Buscar_planilla_Load(object sender, EventArgs e)
        {
            string tabla = "detalle_planilla_igss";
            fn.ActualizarGrid(this.dataGridView1, "SELECT DISTINCT E.id_empresa_pk, E.nombre, DP.fecha FROM empresa E, planilla_igss P, detalle_planilla_igss DP WHERE(E.id_empresa_pk = P.id_empresa_pk AND P.id_planilla_igss_pk = DP.id_planilla_igss_pk);", tabla);
        }
    }
}
