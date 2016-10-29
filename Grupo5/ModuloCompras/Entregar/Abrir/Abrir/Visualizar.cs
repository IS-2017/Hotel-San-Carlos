using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;

namespace Abrir
{
    public partial class Visualizar : Form
    {
        public Visualizar()
        {
            InitializeComponent();
        }

        private void crystalReportViewer2_Load(object sender, EventArgs e)
        {

        }

        private void Visualizar_Load(object sender, EventArgs e)
        {
            

        }
        public void Menu_General(string Ruta)
        {
            try
            {
                ReportDocument rDocument = new ReportDocument();
                rDocument.Load(Ruta);
                crystalReportViewer1.ReportSource = rDocument;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Modulo(string Crystal)
        {
            try
            {
                ReportDocument rDocument = new ReportDocument();
                string FilePath = Crystal;
                rDocument.Load(FilePath);
                crystalReportViewer1.ReportSource = rDocument;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
