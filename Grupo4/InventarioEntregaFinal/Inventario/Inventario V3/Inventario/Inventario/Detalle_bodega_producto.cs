using CrystalDecisions.CrystalReports.Engine;
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
    public partial class Detalle_bodega_producto : Form
    {
        public Detalle_bodega_producto()
        {
            InitializeComponent();
        }
        public string id_bien;
        public string id_bodega;
        public string id_categoria;
        private void Detalle_bodega_producto_Load(object sender, EventArgs e)
        {
           // crystalReportViewer1.Visible = false;

            SistemaInventarioDatos si = new SistemaInventarioDatos();
            DataTable dtt = si.CongelarExistencias("select * from producto_bodega where existencia>0");
            dataGridView1.DataSource = dtt;
            dataGridView1.Columns[0].HeaderText = "ID Bien ";
            dataGridView1.Columns[1].HeaderText = "ID Bodega";
            dataGridView1.Columns[2].HeaderText = "ID Categoria ";
            dataGridView1.Columns[3].HeaderText = "existencia";
            dataGridView1.Columns[4].HeaderText = "existencia congelada ";
            dataGridView1.Columns[5].HeaderText = "Existencia auditada";
            dataGridView1.Columns[6].HeaderText = "Estado";
           // dataGridView1.Columns[7].HeaderText = "Existencia Auditada ";

            // dataGridView1.Columns[2].Width = 70;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SistemaInventarioDatos si = new SistemaInventarioDatos();
            DataTable dtt = si.CongelarExistencias("select * from producto_bodega where existencia>0");
            dataGridView1.DataSource = dtt;
            string existencia = dtt.Rows[0][3].ToString();
            string existencia_auditada = dtt.Rows[0][5].ToString();
            int existencia2 = Convert.ToInt32(existencia);
            int existencia_auditada2 = Convert.ToInt32(existencia_auditada);
            int operacion = existencia2 - existencia_auditada2;


            if (existencia == existencia_auditada)
            {
                label1.Text = "Hay Coincidencia entre las existencias en Bodega y las Auditadas";

            }
            else
            {
                label1.Text = " No hay Coincidencias entre existencias de Bodega y existencias Auditadas , la diferencia es de :'" + operacion + "' ";
            }

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                string existencia = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);

                string existencia_Auditada = Convert.ToString(dataGridView1.CurrentRow.Cells[5].Value);

                int existencia2 = Convert.ToInt32(existencia);
                int existencia_auditada2 = Convert.ToInt32(existencia_Auditada);
                int operacion = existencia2 - existencia_auditada2;


                if (existencia == existencia_Auditada)
                {
                    label1.Text = "Hay Coincidencia entre las existencias en Bodega y las Auditadas";

                }
                else
                {
                    label1.Text = " No hay Coincidencias entre existencias de Bodega y existencias Auditadas , la diferencia es de :'" + operacion + "' ";
                }
            }
            catch{ MessageBox.Show("no hay muestreo de ese producto"); }
        }





        public void reporte_muestreo()
        {
            //DataSet_detallemuestreo Ds = new DataSet_detallemuestreo();
            //int filas = dataGridView1.Rows.Count;
            //for (int i = 0; i < filas - 1; i++)
            //{
            //    Ds.Tables[0].Rows.Add(new object[] {

            //        dataGridView1[0,i].Value.ToString(),

            //        dataGridView1[1,i].Value.ToString(),
            //        dataGridView1[2,i].Value.ToString(),

            //        dataGridView1[3,i].Value.ToString(),
            //        dataGridView1[4,i].Value.ToString(),

            //        dataGridView1[5,i].Value.ToString(),


            //        dataGridView1[6, i].Value.ToString(),

            //    });
            //    ReportDocument cRep = new ReportDocument();
            //    cRep.Load(@"C:\Users\GABRIELA\Dropbox\03 - 11 -16\Modulo de Inventarios\Inventario V2\Inventario\Inventario\muestreo.rpt");
            //    cRep.SetDataSource(Ds);
            //    crystalReportViewer1.ReportSource = cRep;

            //}
        }

    }
}
