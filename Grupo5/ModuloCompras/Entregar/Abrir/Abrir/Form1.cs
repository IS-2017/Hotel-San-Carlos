using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Abrir
{
    public partial class Form1 : Form
    {
        public string Crystal;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_crystal_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_reporte_Click(object sender, EventArgs e)
        {
            try
            {
                Visualizar vz = new Visualizar();
                vz.Modulo(Crystal);
                vz.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_pdf_Click(object sender, EventArgs e)
        {
            try
            {
                PrintDocument print = new PrintDocument();
                ReportDocument rDocument = new ReportDocument();

                rDocument.Load(Crystal);

                printPreviewDialog1.Document = print;
                printPreviewDialog1.ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
