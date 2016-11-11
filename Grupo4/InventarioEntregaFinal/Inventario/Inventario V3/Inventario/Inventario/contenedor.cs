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
        string no_form = "10100";
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
        Kardex_inventarios kar = new Kardex_inventarios();
        Historial his = new Historial();
        FormAsignarPermisosUsuario crearu = new FormAsignarPermisosUsuario();
        agregarapp app = new agregarapp();
        Form_EditarPrivilegios edi = new Form_EditarPrivilegios();
        CambioPass camb = new CambioPass();
        Modificar_aplicacion modap = new Modificar_aplicacion();
        FormDeshabilitarUsuario desh =  new FormDeshabilitarUsuario();
        FormAsignacionPerfil asper = new FormAsignacionPerfil();
        Form_EditarPerfil edper = new Form_EditarPerfil();
        FormEliminarPerfil elper = new FormEliminarPerfil();
        


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
            his = null;
            crearu = null;
            app = null;
            edi = null;
            camb = null;
            modap = null;
            desh = null;
            asper = null;
            edper = null;
            elper = null;
           

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
                kar = new Kardex_inventarios();
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
                kar = new Kardex_inventarios();
                kar.MdiParent = this;

                kar.FormClosed += new FormClosedEventHandler(Formkardex_FormClosed);
                kar.Show();
            }
        }

        private void reporteadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Abrir.Form2 f2 = new Abrir.Form2();
            //f2.Show();
        }

        private void btn_bitacora_Click(object sender, EventArgs e)
        {
            if (his == null)
            {
                his = new Historial();
                his.MdiParent = this;

                his.FormClosed += new FormClosedEventHandler(FormHistorial_FormClosed);
                his.Show();
            }
        }

        private void FormHistorial_FormClosed(object sender, FormClosedEventArgs e)
        {
            his = null;
        }

        private void asignacionPermisosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (crearu == null)
            //{
            //    crearu = new FormAsignarPermisosUsuario();
            //    crearu.MdiParent = this;

            //    crearu.FormClosed += new FormClosedEventHandler(FormAsignarPermisosUsuario_FormClosed);
            //    crearu.Show();
            //}
        }

        private void FormAsignarPermisosUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            crearu = null;
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formlogin f = new Formlogin();
            f.Show();
            this.Close();
        }

        private void agregarAplicaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (app == null)
            {
                app = new agregarapp();
                app.MdiParent = this;

                app.FormClosed += new FormClosedEventHandler(agregarapp_FormClosed);
                app.Show();
            }
        }

        private void agregarapp_FormClosed(object sender, FormClosedEventArgs e)
        {
            app = null;
        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (crearu == null)
            {
                crearu = new FormAsignarPermisosUsuario();
                crearu.MdiParent = this;

                crearu.FormClosed += new FormClosedEventHandler(FormAsignarPermisosUsuario_FormClosed);
                crearu.Show();
            }
        }

        private void editarPermisosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (edi == null)
            {
                edi = new Form_EditarPrivilegios();
                edi.MdiParent = this;

                edi.FormClosed += new FormClosedEventHandler(FormEditarPrivilegios_FormClosed);
                edi.Show();
            }
        }

        private void FormEditarPrivilegios_FormClosed(object sender, FormClosedEventArgs e)
        {
            edi = null;
        }

        private void cambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (camb == null)
            {
                camb = new CambioPass();
                camb.MdiParent = this;
                camb.FormClosed += new FormClosedEventHandler(CambioPass_FormClosed);
                camb.Show();
            }
        }

        private void CambioPass_FormClosed(object sender, FormClosedEventArgs e)
        {
            camb = null;
        }

        private void modificarAplicaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (modap == null)
            {
                modap = new Modificar_aplicacion();
                modap.MdiParent = this;
                modap.FormClosed += new FormClosedEventHandler(ModificarAplicacion_FormClosed);
                modap.Show();
            }
        }

        private void ModificarAplicacion_FormClosed(object sender, FormClosedEventArgs e)
        {
            modap = null;
        }

        private void deshabilitarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (desh == null)
            {
                desh = new FormDeshabilitarUsuario();
                desh.MdiParent = this;
                desh.FormClosed += new FormClosedEventHandler(FormDeshabilitarUsuario_FormClosed);
                desh.Show();
            }
        }

        private void FormDeshabilitarUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            desh = null;
        }

        private void crearPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (asper == null)
            {
                asper = new FormAsignacionPerfil();
                asper.MdiParent = this;
                asper.FormClosed += new FormClosedEventHandler(FormAsignacionPerfil_FormClosed);
                asper.Show();
            }
        }

        private void FormAsignacionPerfil_FormClosed(object sender, FormClosedEventArgs e)
        {
            asper = null;
        }

        private void editarPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (edper == null)
            {
                edper = new Form_EditarPerfil();
                edper.MdiParent = this;
                edper.FormClosed += new FormClosedEventHandler(Form_EditarPerfil_FormClosed);
                edper.Show();
            }
        }

        private void Form_EditarPerfil_FormClosed(object sender, FormClosedEventArgs e)
        {
            edper = null;
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (elper == null)
            {
                elper = new FormEliminarPerfil();
                elper.MdiParent = this;
                elper.FormClosed += new FormClosedEventHandler(FormEliminarPerfil_FormClosed);
                elper.Show();
            }
        }

        private void FormEliminarPerfil_FormClosed(object sender, FormClosedEventArgs e)
        {
            elper = null;
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\Chrix\Desktop\Inventario\Inventario V3\Inventario\Inventario\bin\Debug\Ayuda Inventarios.chm");
        }
    }
}
