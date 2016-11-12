using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace produccion
{
    public partial class frm_reporte_requisicion : Form
    {
      

        public frm_reporte_requisicion()
        {
            InitializeComponent();
        }


        public DataTable dtamo = new DataTable();
        DataSet ds = new DataSet();

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            
            
            dtamo.Columns.Add("Categoria", typeof(string));
            dtamo.Columns.Add("Materia_prima", typeof(string));
            dtamo.Columns.Add("Cantidad", typeof(string));
            dtamo.Columns.Add("Medida", typeof(string));

            
            foreach (DataGridViewRow dg_col in dgv_cen.Rows)
            {
                dtamo.Rows.Add(dg_col.Cells[0].Value, dg_col.Cells[1].Value, dg_col.Cells[2].Value, dg_col.Cells[3].Value);
                
            }

            ds.Tables.Add(dtamo);
            ds.WriteXmlSchema("requisicion.xml");

            ReporteRequisicion rp = new ReporteRequisicion();

            rp.SetDataSource(ds);
            //rp.SetParameterValue("usuarinho", usuario);
            crystalReportViewer1.ReportSource = rp;
        }

        private void frm_reporte_requisicion_Load(object sender, EventArgs e)
        {

        }
    }
}
