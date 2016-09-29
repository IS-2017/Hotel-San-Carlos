using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Report
{
    public partial class FVisor : Form
    {
        crystal MisDatos;
        public FVisor()
        {
            InitializeComponent();
            
        }

        private void crystalReportViewer2_Load(object sender, EventArgs e)
        {

        }
        public FVisor(crystal Datos)
        {
            InitializeComponent();
            MisDatos = Datos;
        }
        private void FVisor_Load(object sender, EventArgs e)
        {
            C_R_1 informe = new C_R_1();
            informe.SetDataSource(MisDatos);
            this.crystalReportViewer2.ReportSource = informe;

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
