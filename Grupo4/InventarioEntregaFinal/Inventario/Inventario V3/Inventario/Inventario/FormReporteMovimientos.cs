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
    public partial class FormReporteMovimientos : Form
    {
        public FormReporteMovimientos()
        {
            InitializeComponent();
        }

        public DataTable dtamo = new DataTable();
        private void FormReporteMovimientos_Load(object sender, EventArgs e)
        {
            try
            {
                //    DataColumn col;
                //    col = new DataColumn();
                //    col.DataType = System.Type.GetType("System.String");
                //    col.ColumnName = "Movimiento";
                //    dtamo.Columns.Add(col);

                //    //2 columna
                //    col = new DataColumn();
                //    col.DataType = System.Type.GetType("System.String");
                //    col.ColumnName = "Descripcion";
                //    dtamo.Columns.Add(col);
                //    //3 columna
                //    col = new DataColumn();
                //    col.DataType = System.Type.GetType("System.String");
                //    col.ColumnName = "Categoria";
                //    dtamo.Columns.Add(col);
                //    //4 columna
                //    col = new DataColumn();
                //    col.DataType = System.Type.GetType("System.String");
                //    col.ColumnName = "Existencias";
                //    dtamo.Columns.Add(col);
                //    //5 columna
                //    col = new DataColumn();
                //    col.DataType = System.Type.GetType("System.String");
                //    col.ColumnName = "Precio";
                //    dtamo.Columns.Add(col);

                //    col = new DataColumn();
                //    col.DataType = System.Type.GetType("System.String");
                //    col.ColumnName = "Costo";
                //    dtamo.Columns.Add(col);

                //    col = new DataColumn();
                //    col.DataType = System.Type.GetType("System.String");
                //    col.ColumnName = "Medida";
                //    dtamo.Columns.Add(col);

                //    col = new DataColumn();
                //    col.DataType = System.Type.GetType("System.String");
                //    col.ColumnName = "Linea";
                //    dtamo.Columns.Add(col);

                //    col = new DataColumn();
                //    col.DataType = System.Type.GetType("System.String");
                //    col.ColumnName = "Marca";
                //    dtamo.Columns.Add(col);

                //    col = new DataColumn();
                //    col.DataType = System.Type.GetType("System.String");
                //    col.ColumnName = "Aplicación";
                //    dtamo.Columns.Add(col);

                //    DataSet dsd = new DataSet();

                //    foreach (DataGridViewRow dg_col in dgw_rep.Rows)
                //    {
                //        dtamo.Rows.Add(dg_col.Cells[0].Value, dg_col.Cells[1].Value, dg_col.Cells[2].Value, dg_col.Cells[3].Value, dg_col.Cells[4].Value, dg_col.Cells[5].Value, dg_col.Cells[6].Value, dg_col.Cells[7].Value, dg_col.Cells[8].Value);
                //    }

                //    dsd.Tables.Add(dtamo);
                //    dsd.WriteXmlSchema("existrep.xml");

                //    repexistencias rp = new repexistencias();

                //    rp.SetDataSource(dsd);
                //    // rp.SetParameterValue("usuarinho", usuario);
                //    crystalReportViewer1.ReportSource = rp;


                //}
                //catch (Exception ex) { MessageBox.Show(ex.Message); }

                datasetrep Ds = new datasetrep();
                int filas = dgw_rep.Rows.Count;
                for (int i = 0; i < filas - 1; i++)
                {
                    Ds.Tables[0].Rows.Add(new object[] {

                    dgw_rep[0,i].Value.ToString(),

                    dgw_rep[1,i].Value.ToString(),
                    dgw_rep[2,i].Value.ToString(),

                    dgw_rep[3,i].Value.ToString(),
                    dgw_rep[4,i].Value.ToString(),

                    dgw_rep[5,i].Value.ToString(),


                    dgw_rep[6, i].Value.ToString(),

                    dgw_rep[7,i].Value.ToString(),
                    dgw_rep[8,i].Value.ToString()
                });
                    reporteMovimiento cRep = new reporteMovimiento();
                    cRep.Load(@"C:\Users\Chrix\Desktop\Inventario\Inventario V3\Inventario\Inventario\reporteMovimiento.rpt");
                    cRep.SetDataSource(Ds);
                    crystalReportViewer1.ReportSource = cRep;

                }


            }
            catch (Exception ex){ MessageBox.Show(ex.Message); }


        }




    }
}
