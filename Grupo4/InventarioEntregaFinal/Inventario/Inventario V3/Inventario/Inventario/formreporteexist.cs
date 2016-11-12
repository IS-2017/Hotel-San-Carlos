using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario
{
    public partial class formreporteexist : Form
    {
        public formreporteexist()
        {
            InitializeComponent();
        }
        public DataTable dtamo = new DataTable();
        private void formreporteexist_Load(object sender, EventArgs e)
        {
            try
            {
                DataColumn col;
                col = new DataColumn();
                col.DataType = System.Type.GetType("System.String");
                col.ColumnName = "Codigo";
                dtamo.Columns.Add(col);

                //2 columna
                col = new DataColumn();
                col.DataType = System.Type.GetType("System.String");
                col.ColumnName = "Descripcion";
                dtamo.Columns.Add(col);
                //3 columna
                col = new DataColumn();
                col.DataType = System.Type.GetType("System.String");
                col.ColumnName = "Categoria";
                dtamo.Columns.Add(col);
                //4 columna
                col = new DataColumn();
                col.DataType = System.Type.GetType("System.String");
                col.ColumnName = "Existencias";
                dtamo.Columns.Add(col);
                //5 columna
                col = new DataColumn();
                col.DataType = System.Type.GetType("System.String");
                col.ColumnName = "Precio";
                dtamo.Columns.Add(col);

                col = new DataColumn();
                col.DataType = System.Type.GetType("System.String");
                col.ColumnName = "Costo";
                dtamo.Columns.Add(col);

                col = new DataColumn();
                col.DataType = System.Type.GetType("System.String");
                col.ColumnName = "Medida";
                dtamo.Columns.Add(col);

                col = new DataColumn();
                col.DataType = System.Type.GetType("System.String");
                col.ColumnName = "Linea";
                dtamo.Columns.Add(col);

                col = new DataColumn();
                col.DataType = System.Type.GetType("System.String");
                col.ColumnName = "Marca";
                dtamo.Columns.Add(col);

                col = new DataColumn();
                col.DataType = System.Type.GetType("System.String");
                col.ColumnName = "Aplicación";
                dtamo.Columns.Add(col);

                DataSet ds = new DataSet();

                foreach (DataGridViewRow dg_col in dgw_rep.Rows)
                {
                    dtamo.Rows.Add(dg_col.Cells[0].Value, dg_col.Cells[1].Value, dg_col.Cells[2].Value, dg_col.Cells[3].Value, dg_col.Cells[4].Value, dg_col.Cells[5].Value, dg_col.Cells[6].Value, dg_col.Cells[7].Value, dg_col.Cells[8].Value);
                }

                ds.Tables.Add(dtamo);
                ds.WriteXmlSchema("existrep.xml");

                repexistencias rp = new repexistencias();

                rp.SetDataSource(ds);
                // rp.SetParameterValue("usuarinho", usuario);
                crystalReportViewer1.ReportSource = rp;
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }

        }
    }
}
