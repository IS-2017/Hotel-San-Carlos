﻿using System;
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
     //   Reporte_de_Movimientos_de_inventarios rep_movs = new Reporte_de_Movimientos_de_inventarios();
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
        FormMovimientos mov = new FormMovimientos();
        FormDevolucionCompra devc = new FormDevolucionCompra();
        FormDocumento doc = new FormDocumento();
        FormExistenciasPorBodega exbod = new FormExistenciasPorBodega();
        FormFacturasPendientes fac = new FormFacturasPendientes();
        Formkardex kar = new Formkardex();
        


        private void mantenimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }



        private void contenedor_Load(object sender, EventArgs e)
        {

            Conexion.DSN = "prueba2";
            MdiClient Chld;

            inv_ini = null;
          //  rep_movs = null;
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
            mov = null;
            devc = null;
            doc = null;
            exbod = null;
            fac = null;
            kar = null;
           

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
            if (mov == null)
            {
                mov = new FormMovimientos();
                mov.MdiParent = this;

                mov.FormClosed += new FormClosedEventHandler(FormMovimientos_FormClosed);
                mov.Show();
            }
        }

        private void FormMovimientos_FormClosed(object sender, FormClosedEventArgs e)
        {
            mov = null;
        }

        private void Reporte_de_Movimientos_de_inventarios_FormClosed(object sender, FormClosedEventArgs e)
        {
           
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

        private void devSobreCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (devc == null)
            {
                devc = new FormDevolucionCompra();
                devc.MdiParent = this;

                devc.FormClosed += new FormClosedEventHandler(FormDevolucionCommpra_FormClosed);
                devc.Show();
            }
        }

        private void FormDevolucionCommpra_FormClosed(object sender, FormClosedEventArgs e)
        {
            devc = null;
        }

        private void existenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (exbod == null)
            {
                exbod = new FormExistenciasPorBodega();
                exbod.MdiParent = this;

                exbod.FormClosed += new FormClosedEventHandler(FormExistenciasPorBodega_FormClosed);
                exbod.Show();
            }
        }

        private void FormExistenciasPorBodega_FormClosed(object sender, FormClosedEventArgs e)
        {
            exbod = null;
        }

        private void btn_exist_Click(object sender, EventArgs e)
        {
            if (exbod == null)
            {
                exbod = new FormExistenciasPorBodega();
                exbod.MdiParent = this;

                exbod.FormClosed += new FormClosedEventHandler(FormExistenciasPorBodega_FormClosed);
                exbod.Show();
            }
        }

        private void btn_mov_Click(object sender, EventArgs e)
        {
            if (mov == null)
            {
                mov = new FormMovimientos();
                mov.MdiParent = this;

                mov.FormClosed += new FormClosedEventHandler(FormMovimientos_FormClosed);
                mov.Show();
            }
        }

        private void facturasPendientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fac == null)
            {
                fac = new FormFacturasPendientes();
                fac.MdiParent = this;

                fac.FormClosed += new FormClosedEventHandler(FormFacturasPendientes_FormClosed);
                fac.Show();
            }
        }

        private void FormFacturasPendientes_FormClosed(object sender, FormClosedEventArgs e)
        {
            fac = null;
        }

        private void kardexToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (kar == null)
            {
                kar = new Formkardex();
                kar.MdiParent = this;

                kar.FormClosed += new FormClosedEventHandler(Formkardex_FormClosed);
                kar.Show();
            }
        }

        private void Formkardex_FormClosed(object sender, FormClosedEventArgs e)
        {
            kar = null;
        }

        private void btn_kardex_Click(object sender, EventArgs e)
        {
            if (kar == null)
            {
                kar = new Formkardex();
                kar.MdiParent = this;

                kar.FormClosed += new FormClosedEventHandler(Formkardex_FormClosed);
                kar.Show();
            }
        }

        private void reporteadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrir.Form2 f2 = new Abrir.Form2();
            f2.Show();
        }
    }
}
