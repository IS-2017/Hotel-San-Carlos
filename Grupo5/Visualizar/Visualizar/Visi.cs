using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visualizar
{
    public partial class Visi : Form
    {
        dt MisDatos;
       // public Visi()
        //{
          //  InitializeComponent();
        //}
        public Visi(dt Datos)
        {
            InitializeComponent();
            MisDatos = Datos;
        }

        private void Visi_Load(object sender, EventArgs e)
        {
            CrystalReport1 informe = new CrystalReport1();
            informe.SetDataSource(MisDatos);
            this.crystalReportViewer1.ReportSource = informe;
        }
    }
}
