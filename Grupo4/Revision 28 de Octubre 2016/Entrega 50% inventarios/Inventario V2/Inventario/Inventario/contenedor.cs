using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using seguridad;

namespace Inventario
{
    public partial class contenedor : Form
    {
        public contenedor()
        {
            InitializeComponent();
        }

        FormInventarioInicio inv_ini = new FormInventarioInicio();
        Reporte_de_Movimientos_de_inventarios rep_movs = new Reporte_de_Movimientos_de_inventarios();
        FormNuevoProducto np = new FormNuevoProducto();
        Categoria cat = new Categoria();
        FormMedidas fm = new  FormMedidas();
        marca mar = new marca();
        FormRecibirStock rstck = new FormRecibirStock();
        FormBodega bod = new FormBodega();
        FormLinea fl = new FormLinea();
        FormRequisicion gr = new FormRequisicion();
        Detalle_muestreo dm = new Detalle_muestreo();
        Detalle_bodega_producto dbp = new Detalle_bodega_producto();
        FormMuestreo fmu = new FormMuestreo();
        Modificar_encabezado_muestreo mem= new Modificar_encabezado_muestreo();
        


        private void mantenimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }



        private void contenedor_Load(object sender, EventArgs e)
        {

            Conexion.DSN = "prueba2";
            MdiClient Chld;

            inv_ini = null;
            rep_movs = null;
            np = null;
            cat = null;
            fm = null;
            mar = null;
            rstck = null;
            bod = null;
            fl = null;
            gr = null;
            dm = null;
            dbp = null;
            fmu = null;
            mem = null;

            foreach (Control crtl in this.Controls)
            {
                try
                {
                    Chld = (MdiClient)crtl;
                    Chld.BackColor = this.BackColor;
                }
                catch (InvalidCastException exe)
                { }
            }



            if (inv_ini == null)
            {
                inv_ini = new FormInventarioInicio();
                inv_ini.MdiParent = this;

                inv_ini.FormClosed += new FormClosedEventHandler(FormInventarioInicio_FormCLosed);
                inv_ini.Show();
            }

        }

        private void listadoDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (inv_ini == null)
            {
                inv_ini = new FormInventarioInicio();
                inv_ini.MdiParent = this;

                inv_ini.FormClosed += new FormClosedEventHandler(FormInventarioInicio_FormCLosed);
                inv_ini.Show();
            }
        }

        private void FormInventarioInicio_FormCLosed(object sender, FormClosedEventArgs e)
        {
            inv_ini = null;
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (np == null)
            {
                np = new FormNuevoProducto();
                np.MdiParent = this;

                np.FormClosed += new FormClosedEventHandler(FormNuevoProducto_formclosed);
                np.Show();
            }
        }

        private void btn_nuevoprod_Click(object sender, EventArgs e)
        {
            //FormNuevoProducto np = new FormNuevoProducto();
            //np.Show();
            //if (np == null)
            //{
            //    np = new FormNuevoProducto();
            //    np.MdiParent = this;

            //    np.FormClosed += new FormClosedEventHandler(FormNuevoProducto_formclosed);
            //    np.Show();
            //}

            if (inv_ini == null)
            {
                inv_ini = new FormInventarioInicio();
                inv_ini.MdiParent = this;

                inv_ini.FormClosed += new FormClosedEventHandler(FormInventarioInicio_FormCLosed);
                inv_ini.Show();
            }

        }

        private void FormNuevoProducto_formclosed(object sender, FormClosedEventArgs e)
        {
            np = null;
        }

        private void movimientosDeInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rep_movs == null)
            {
                rep_movs = new Reporte_de_Movimientos_de_inventarios();
                rep_movs.MdiParent = this;

                rep_movs.FormClosed += new FormClosedEventHandler(Reporte_de_Movimientos_de_inventarios_FormClosed);
                rep_movs.Show();
            }
        }

        private void Reporte_de_Movimientos_de_inventarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            rep_movs = null;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cat == null)
            {
                cat = new Categoria();
                cat.MdiParent = this;

                cat.FormClosed += new FormClosedEventHandler(Formcategoria_FormClosed);
                cat.Show();
            }
        }

        private void Formcategoria_FormClosed(object sender, FormClosedEventArgs e)
        {
            cat = null;
        }

        private void medidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fm == null)
            {
                fm = new FormMedidas();
                fm.MdiParent = this;

                fm.FormClosed += new FormClosedEventHandler(FormMedidas_FormCLosed);
                fm.Show();
            }
        }

        private void FormMedidas_FormCLosed(object sender, FormClosedEventArgs e)
        {
            fm = null;
        }

        private void marcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mar == null)
            {
                mar = new marca();
                mar.MdiParent = this;

                mar.FormClosed += new FormClosedEventHandler(FormMarca_FormCLosed);
                mar.Show();
            }
        }

        private void FormMarca_FormCLosed(object sender, FormClosedEventArgs e)
        {
            mar = null;
        }

        private void recibirStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rstck == null)
            {
                rstck = new FormRecibirStock();
                rstck.MdiParent = this;

                rstck.FormClosed += new FormClosedEventHandler(FormRecibirStock_FormClosed);
                rstck.Show();
            }
        }

        private void FormRecibirStock_FormClosed(object sender, FormClosedEventArgs e)
        {
            rstck = null;
        }

        private void bodegaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bod == null)
            {
                bod = new FormBodega();
                bod.MdiParent = this;

                bod.FormClosed += new FormClosedEventHandler(FormBodega_FormClosed);
                bod.Show();
            }
        }

        private void FormBodega_FormClosed(object sender, FormClosedEventArgs e)
        {
            bod = null;
        }

        private void líneasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fl == null)
            {
                fl = new FormLinea();
                fl.MdiParent = this;

                fl.FormClosed += new FormClosedEventHandler(FormLinea_FormClosed );
                fl.Show();
            }
        }

        private void FormLinea_FormClosed(object sender, FormClosedEventArgs e)
        {
            fl = null;
        }

        private void generarRequisiciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gr == null)
            {
                gr = new FormRequisicion();
                gr.MdiParent = this;

                gr.FormClosed += new FormClosedEventHandler(FormRequisicion_FormClosed);
                gr.Show();
            }
        }

        private void FormRequisicion_FormClosed(object sender, FormClosedEventArgs e)
        {
            gr = null;
        }

        private void muestreoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fmu == null)
            {
                fmu = new FormMuestreo();
                fmu.MdiParent = this;

                fmu.FormClosed += new FormClosedEventHandler(FormMuestreo_FormClosed);
                fmu.Show();
            }
        }

        private void FormMuestreo_FormClosed(object sender, FormClosedEventArgs e)
        {
            fmu = null;
        }
    }
}
