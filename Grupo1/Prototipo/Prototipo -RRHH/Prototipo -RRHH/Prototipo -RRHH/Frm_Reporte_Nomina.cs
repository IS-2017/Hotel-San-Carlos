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
using CrystalDecisions.CrystalReports.Engine;

namespace Prototipo__RRHH
{
    public partial class Frm_Reporte_Nomina : Form
    {
        public Frm_Reporte_Nomina()
        {
            InitializeComponent();
        }

        CapaNegocio fn = new CapaNegocio();
        String fecha_inicio, fecha_fin;

        private void Frm_Reporte_Nomina_Load(object sender, EventArgs e)
        {
            llenarCbo1();
            txt_cbo_empresa_rep.Text = cbo_empresa_rep.SelectedValue.ToString();
            txt_dtp_fecha_inicio_repor.Text = dtp_fecha_inicio_repor.Value.ToString("yyyy-MM-dd");
            txt_dtp_fecha_fin_repor.Text = dtp_fecha_fin_repor.Value.ToString("yyyy-MM-dd");

            string tabla = "detalle_nomina";
            fn.ActualizarGrid(this.dataGridView1, "select E.nombre, E.dpi, E.telefono, N.Sueldo_base, N.total_devengos, N.total_deduccion, p.igss_pagar, N.sueldo_liquido from empleado E, detalle_nomina N, detalle_planilla_igss P, empresa S where E.id_empleados_pk = N.id_empleados_pk and E.id_empleados_pk = N.id_empleados_pk and E.id_empleados_pk = P.id_empleados_pk and E.id_empresa_pk = S.id_empresa_pk and E.id_empresa_pk = '"+ txt_cbo_empresa_rep.Text +"' and N.fecha BETWEEN '"+ txt_dtp_fecha_inicio_repor.Text +"' and '"+ txt_dtp_fecha_fin_repor.Text +"' ", tabla);

        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            txt_cbo_empresa_rep.Text = cbo_empresa_rep.SelectedValue.ToString();
            txt_dtp_fecha_inicio_repor.Text = dtp_fecha_inicio_repor.Value.ToString("yyyy-MM-dd");
            txt_dtp_fecha_fin_repor.Text = dtp_fecha_fin_repor.Value.ToString("yyyy-MM-dd");

            string tabla = "detalle_nomina";
            fn.ActualizarGrid(this.dataGridView1, "select E.nombre, E.dpi, E.telefono, N.Sueldo_base, N.total_devengos, N.total_deduccion, p.igss_pagar, N.sueldo_liquido from empleado E, detalle_nomina N, detalle_planilla_igss P, empresa S where E.id_empleados_pk = N.id_empleados_pk and E.id_empleados_pk = N.id_empleados_pk and E.id_empleados_pk = P.id_empleados_pk and E.id_empresa_pk = S.id_empresa_pk and E.id_empresa_pk = '" + txt_cbo_empresa_rep.Text + "' and N.fecha BETWEEN '" + txt_dtp_fecha_inicio_repor.Text + "' and '" + txt_dtp_fecha_fin_repor.Text + "' ", tabla);

        }

        private void cbo_empresa_rep_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_cbo_empresa_rep.Text = cbo_empresa_rep.SelectedValue.ToString();
            txt_dtp_fecha_inicio_repor.Text = dtp_fecha_inicio_repor.Value.ToString("yyyy-MM-dd");
            txt_dtp_fecha_fin_repor.Text = dtp_fecha_fin_repor.Value.ToString("yyyy-MM-dd");

            string tabla = "detalle_nomina";
            fn.ActualizarGrid(this.dataGridView1, "select E.nombre, E.dpi, E.telefono, N.Sueldo_base, N.total_devengos, N.total_deduccion, p.igss_pagar, N.sueldo_liquido from empleado E, detalle_nomina N, detalle_planilla_igss P, empresa S where E.id_empleados_pk = N.id_empleados_pk and E.id_empleados_pk = N.id_empleados_pk and E.id_empleados_pk = P.id_empleados_pk and E.id_empresa_pk = S.id_empresa_pk and E.id_empresa_pk = '" + txt_cbo_empresa_rep.Text + "' and N.fecha BETWEEN '" + txt_dtp_fecha_inicio_repor.Text + "' and '" + txt_dtp_fecha_fin_repor.Text + "' ", tabla);

        }

        public void llenarCbo1()
        {
            string query = "select id_empresa_pk, nombre from empresa;";
            string tabla = "empresa";
            string valor = "id_empresa_pk";
            string mostrar = "nombre";
            cbo_empresa_rep = fn.llenarCbo(query, tabla, cbo_empresa_rep, valor, mostrar);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reporte();
        }

        public void Reporte()
        {
            DataSet1 Ds = new DataSet1();
            int filas = dataGridView1.Rows.Count;
            for(int i = 0; i < filas - 1; i++)
            {
                Ds.Tables[0].Rows.Add(new object[]
                {
                    dataGridView1[0,i].Value.ToString(),
                    dataGridView1[1,i].Value.ToString(),
                    dataGridView1[2,i].Value.ToString(),
                    dataGridView1[3,i].Value.ToString(),
                    dataGridView1[4,i].Value.ToString(),
                    dataGridView1[5,i].Value.ToString(),
                    dataGridView1[6,i].Value.ToString(),
                    dataGridView1[7,i].Value.ToString()
                    

                });
                ReportDocument cRep = new ReportDocument();

                string file = Application.StartupPath + "\\ReporteNomina.rpt";
                cRep.Load(file);
                cRep.SetDataSource(Ds);
                crystalReportViewer1.ReportSource = cRep;
            }
        }
    }
}
