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
    public partial class FormReporteKardex : Form
    {
        public FormReporteKardex()
        {
            InitializeComponent();
        }

        private void FormReporteKardex_Load(object sender, EventArgs e)
        {
            try
            {
                datasetrep Ds = new datasetrep();
                int filas = dataGridView1.Rows.Count;
                for (int i = 0; i < filas - 1; i++)
                {
                    Ds.Tables[0].Rows.Add(new object[] {

                    dataGridView1[0,i].Value.ToString(),

                    dataGridView1[1,i].Value.ToString(),
                    dataGridView1[2,i].Value.ToString(),

                    dataGridView1[3,i].Value.ToString(),
                    dataGridView1[4,i].Value.ToString(),

                    dataGridView1[5,i].Value.ToString(),


                    dataGridView1[6, i].Value.ToString(),

                    

                });
                    reporteMovimiento cRep = new reporteMovimiento();
                    cRep.Load(@"‪C:\Users\Chrix\Desktop\Inventario\Inventario V3\Inventario\Inventario\crystal_kardexx.rpt");
                    cRep.SetDataSource(Ds);
                    crystalReportViewer1.ReportSource = cRep;

                }

            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }


        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
