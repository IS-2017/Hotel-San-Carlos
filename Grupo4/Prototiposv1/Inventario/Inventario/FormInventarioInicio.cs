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
    public partial class FormInventarioInicio : Form
    {
        public FormInventarioInicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hola");
        }

        private void holaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bodegaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Materia_prima mp = new Materia_prima();
            mp.Show();
            this.Hide();
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            marca mr = new marca();
            mr.MdiParent = this;
            mr.Show();
          
        }

        private void categoríaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Categoria ct = new Categoria();
            ct.MdiParent = this;
            ct.Show();
            this.Hide();
        }

        private void productoTerminadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Producto_terminado pt = new Producto_terminado();
            pt.Show();
            this.Hide();
        }

        private void muestreoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Muestreo_materia_prima mmp = new Muestreo_materia_prima();
            mmp.Show();
            this.Hide();
        }

        private void toolStripDropDownButton3_Click(object sender, EventArgs e)
        {

        }

        private void muestreoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Muestreo mpt = new Muestreo();
            mpt.Show();
            this.Hide();
        }

        private void reporteDeExistenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reporte_de_existencias re = new Reporte_de_existencias();
            re.Show();
            this.Hide();
        }

        private void kardexDeMateriaPRimaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kardex kmp = new Kardex();
            kmp.Show();
            this.Show();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripDropDownButton2_Click(object sender, EventArgs e)
        {

        }

        private void FormInventarioInicio_Load(object sender, EventArgs e)
        {

        }
    }
}
