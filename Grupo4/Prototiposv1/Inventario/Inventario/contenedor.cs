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
    public partial class contenedor : Form
    {
        public contenedor()
        {
            InitializeComponent();
        }

        private void mantenimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void paginaPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInventarioInicio fii = new FormInventarioInicio();
            fii.MdiParent = this;
            fii.Show();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Categoria ct = new Categoria();
            ct.MdiParent = this;
            ct.Show();

        }

        private void bodegaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bodega bod = new Bodega();
            bod.MdiParent = this;
            bod.Show();
        }

        private void productoTerminadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Producto_terminado pt = new Producto_terminado();
            pt.MdiParent = this;
            pt.Show();
        }

        private void materiaPrimaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Materia_prima mp = new Materia_prima();
            mp.MdiParent = this;
            mp.Show();
        }

        private void muestreoMateriaPrimaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Muestreo_materia_prima mmp = new Muestreo_materia_prima();
            mmp.MdiParent = this;
            mmp.Show();
        }

        private void materiaProductoTerminadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Muestreo   mpt = new Muestreo();
            mpt.MdiParent = this;
            mpt.Show();
        }

        private void reporteDeExistenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reporte_de_existencias re = new Reporte_de_existencias();
            re.MdiParent = this;
            re.Show();
        }

        private void marcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            marca marc = new marca();
            marc.MdiParent = this;
            marc.Show();
        }

        private void contenedor_Load(object sender, EventArgs e)
        {
            FormInventarioInicio fi = new FormInventarioInicio();
            fi.MdiParent = this;
            fi.Show();
        }
    }
}
