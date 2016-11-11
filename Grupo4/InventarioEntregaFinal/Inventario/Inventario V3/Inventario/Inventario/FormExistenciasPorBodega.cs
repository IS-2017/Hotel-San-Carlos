using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FuncionesNavegador;
namespace Inventario
{
    public partial class FormExistenciasPorBodega : Form
    {
        public FormExistenciasPorBodega()
        {
            InitializeComponent();
        }
        string id_form = "10104";
        private void FormExistenciasPorBodega_Load(object sender, EventArgs e)
        {
            try
            {
                CapaNegocio fn = new CapaNegocio();
                DataTable seg = seguridad.ObtenerPermisos.Permisos(seguridad.Conexion.User, id_form);
                if (seg.Rows.Count > 0)
                {
                    fn.desactivarPermiso(seg, btn_guardar, btn_eliminar, btn_editar, btn_nuevo, btn_cancelar, btn_actualizar, btn_buscar, btn_anterior, btn_siguiente, btn_primero, btn_ultimo);
                }
                //-----cargar bodega
                SistemaInventarioDatos sd = new SistemaInventarioDatos();
                DataTable dt = sd.ObtenerBodega();
                DataRow row = dt.NewRow();
                row[0] = 0;
                row[1] = "<Todos>";
                dt.Rows.InsertAt(row, 0);
                cbo_bodega.DataSource = dt;
                cbo_bodega.DisplayMember = "nombre_bodega";
                cbo_bodega.ValueMember = "id_bodega_pk";
                //----------------cargar categoria--
                DataTable dtc = sd.ObtenerCategorias();
                DataRow rowc = dtc.NewRow();
                rowc[0] = 0;
                rowc[1] = "<Todos>";
                dtc.Rows.InsertAt(rowc, 0);
                cbo_categoria.DataSource = dtc;
                cbo_categoria.DisplayMember = "tipo_categoria";
                cbo_categoria.ValueMember = "id_categoria_pk";
            }
            catch (Exception ex) { MessageBox.Show("No posee los permisos necesarios!", "¡Seguridad!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void cbo_bodega_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_bodega.SelectedValue is int)
            {




                //-----------------------------------------------------------------------
                SistemaInventarioDatos sd = new SistemaInventarioDatos();
                int indice_bod = cbo_bodega.SelectedIndex;
                int indice_cat = cbo_categoria.SelectedIndex;
                int indice_linea;

                if (indice_bod == 0)
                {
                    if(indice_cat == 0)
                    {
                        dgw_existencias.DataSource = sd.TodasLasBodegasYTodasLasCategorias();
                        DiseñoGrid();
                    }
                    else if(indice_cat > 0)
                          {
                             indice_linea = cbo_linea.SelectedIndex;
                            if(indice_linea == 0)
                             {
                            dgw_existencias.DataSource = sd.TodasLasBodegasYUnaCategoria(cbo_categoria.SelectedValue.ToString());
                            DiseñoGrid();
                             }else if ( indice_linea > 0)
                               {
                                dgw_existencias.DataSource = sd.TodasLasBodegasYUnaCategoriaYUnaLinea(cbo_categoria.SelectedValue.ToString(), cbo_linea.SelectedValue.ToString());
                                DiseñoGrid();
                                }
                          }
                }
                else if(indice_bod > 0 )
                     {
                         if (indice_cat == 0)
                           {
                             dgw_existencias.DataSource = sd.ObtenerExistPorBodega(cbo_bodega.SelectedValue.ToString());
                            DiseñoGrid();
                             }else if (indice_cat > 0)
                                {
                                 indice_linea = cbo_linea.SelectedIndex;
                                    if(indice_linea == 0)
                                      {
                                        dgw_existencias.DataSource = sd.UnaBodegaYUnaCategoria(cbo_bodega.SelectedValue.ToString(),cbo_categoria.SelectedValue.ToString());
                                        DiseñoGrid(); 
                                      } else if (indice_linea > 0)
                                             {
                                              dgw_existencias.DataSource = sd.UnaBodegaYUnaCategoriaYUnaLinea(cbo_bodega.SelectedValue.ToString(),cbo_categoria.SelectedValue.ToString(),cbo_linea.SelectedValue.ToString());
                                              DiseñoGrid();
                                             }
                                }
                     }
//--------------------------------------------------------------------------










            }
        }


        private void DiseñoGrid()
        {
            dgw_existencias.Columns[0].HeaderText = "Codigo";
            dgw_existencias.Columns[1].HeaderText = "Descripción";
            dgw_existencias.Columns[2].HeaderText = "Categoría";
            dgw_existencias.Columns[3].HeaderText = "Existencias";
            dgw_existencias.Columns[4].HeaderText = "Precio";
            dgw_existencias.Columns[5].HeaderText = "Costo";
            dgw_existencias.Columns[6].HeaderText = "Medida";
            dgw_existencias.Columns[7].HeaderText = "Línea";
            dgw_existencias.Columns[8].HeaderText = "Marca";
            dgw_existencias.Columns[9].HeaderText = "Bodega";

            dgw_existencias.Columns[0].Width = 55;
            dgw_existencias.Columns[1].Width = 270;
            dgw_existencias.Columns[2].Width = 95;
            dgw_existencias.Columns[3].Width = 55;
            dgw_existencias.Columns[4].Width = 55;
            dgw_existencias.Columns[5].Width = 55;
            dgw_existencias.Columns[6].Width = 65;
            dgw_existencias.Columns[7].Width = 80;
            dgw_existencias.Columns[8].Width = 65;
            dgw_existencias.Columns[9].Width = 95;

        }

        private void cbo_categoria_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            if (cbo_categoria.SelectedIndex > 0)
            {
                SistemaInventarioDatos ds = new SistemaInventarioDatos();
                string categoria = cbo_categoria.SelectedValue.ToString();
                DataTable dt = ds.LineasporCat(categoria);
                DataRow row = dt.NewRow();
                row[0] = 0;
                row[1] = "<Todos>";
                dt.Rows.InsertAt(row, 0);
                cbo_linea.DataSource = dt;
                cbo_linea.DisplayMember = "nombre_linea";
                cbo_linea.ValueMember = "id_linea_pk";
            }else if (cbo_categoria.SelectedIndex == 0)
                   {
                DataTable dtf = new DataTable();
                cbo_linea.DataSource = dtf;
                    }






            //------------------------------------------------------
            SistemaInventarioDatos sd = new SistemaInventarioDatos();
            int indice_bod = cbo_bodega.SelectedIndex;
            int indice_cat = cbo_categoria.SelectedIndex;
            int indice_linea;

            if (indice_bod == 0)
            {
                if (indice_cat == 0)
                {
                    dgw_existencias.DataSource = sd.TodasLasBodegasYTodasLasCategorias();
                    DiseñoGrid();
                }
                else if (indice_cat > 0)
                {
                    indice_linea = cbo_linea.SelectedIndex;
                    if (indice_linea == 0)
                    {
                        dgw_existencias.DataSource = sd.TodasLasBodegasYUnaCategoria(cbo_categoria.SelectedValue.ToString());
                        DiseñoGrid();
                    }
                    else if (indice_linea > 0)
                    {
                        dgw_existencias.DataSource = sd.TodasLasBodegasYUnaCategoriaYUnaLinea(cbo_categoria.SelectedValue.ToString(), cbo_linea.SelectedValue.ToString());
                        DiseñoGrid();
                    }
                }
            }
            else if (indice_bod > 0)
            {
                if (indice_cat == 0)
                {
                    dgw_existencias.DataSource = sd.ObtenerExistPorBodega(cbo_bodega.SelectedValue.ToString());
                    DiseñoGrid();
                }
                else if (indice_cat > 0)
                {
                    indice_linea = cbo_linea.SelectedIndex;
                    if (indice_linea == 0)
                    {
                        dgw_existencias.DataSource = sd.UnaBodegaYUnaCategoria(cbo_bodega.SelectedValue.ToString(), cbo_categoria.SelectedValue.ToString());
                        DiseñoGrid();
                    }
                    else if (indice_linea > 0)
                    {
                        dgw_existencias.DataSource = sd.UnaBodegaYUnaCategoriaYUnaLinea(cbo_bodega.SelectedValue.ToString(), cbo_categoria.SelectedValue.ToString(), cbo_linea.SelectedValue.ToString());
                        DiseñoGrid();
                    }
                }
            }
            //------------------------------------------------------

        }

        private void cbo_linea_SelectedIndexChanged(object sender, EventArgs e)
        {
            SistemaInventarioDatos sd = new SistemaInventarioDatos();
            int indice_bod = cbo_bodega.SelectedIndex;
            int indice_cat = cbo_categoria.SelectedIndex;
            int indice_linea;

            if (indice_bod == 0)
            {
                if (indice_cat == 0)
                {
                    dgw_existencias.DataSource = sd.TodasLasBodegasYTodasLasCategorias();
                    DiseñoGrid();
                }
                else if (indice_cat > 0)
                {
                    indice_linea = cbo_linea.SelectedIndex;
                    if (indice_linea == 0)
                    {
                        dgw_existencias.DataSource = sd.TodasLasBodegasYUnaCategoria(cbo_categoria.SelectedValue.ToString());
                        DiseñoGrid();
                    }
                    else if (indice_linea > 0)
                    {
                        dgw_existencias.DataSource = sd.TodasLasBodegasYUnaCategoriaYUnaLinea(cbo_categoria.SelectedValue.ToString(), cbo_linea.SelectedValue.ToString());
                        DiseñoGrid();
                    }
                }
            }
            else if (indice_bod > 0)
            {
                if (indice_cat == 0)
                {
                    dgw_existencias.DataSource = sd.ObtenerExistPorBodega(cbo_bodega.SelectedValue.ToString());
                    DiseñoGrid();
                }
                else if (indice_cat > 0)
                {
                    indice_linea = cbo_linea.SelectedIndex;
                    if (indice_linea == 0)
                    {
                        dgw_existencias.DataSource = sd.UnaBodegaYUnaCategoria(cbo_bodega.SelectedValue.ToString(), cbo_categoria.SelectedValue.ToString());
                        DiseñoGrid();
                    }
                    else if (indice_linea > 0)
                    {
                        dgw_existencias.DataSource = sd.UnaBodegaYUnaCategoriaYUnaLinea(cbo_bodega.SelectedValue.ToString(), cbo_categoria.SelectedValue.ToString(), cbo_linea.SelectedValue.ToString());
                        DiseñoGrid();
                    }
                }
            }
        }

        private void txt_busqueda_TextChanged(object sender, EventArgs e)
        {
            SistemaInventarioDatos sd = new SistemaInventarioDatos();
            int indice_bod = cbo_bodega.SelectedIndex;
            int indice_cat = cbo_categoria.SelectedIndex;
            int indice_linea;
            string busqueda = txt_busqueda.Text.Trim();

            if (indice_bod == 0)
            {
                if (indice_cat == 0)
                {
                    dgw_existencias.DataSource = sd.TodasLasBodegasYTodasLasCategoriaslike(busqueda);
                    DiseñoGrid();
                }
                else if (indice_cat > 0)
                {
                    indice_linea = cbo_linea.SelectedIndex;
                    if (indice_linea == 0)
                    {
                        dgw_existencias.DataSource = sd.TodasLasBodegasYUnaCategorialike(cbo_categoria.SelectedValue.ToString(), busqueda);
                        DiseñoGrid();
                    }
                    else if (indice_linea > 0)
                    {
                        dgw_existencias.DataSource = sd.TodasLasBodegasYUnaCategoriaYUnaLinealike(cbo_categoria.SelectedValue.ToString(), cbo_linea.SelectedValue.ToString(), busqueda);
                        DiseñoGrid();
                    }
                }
            }
            else if (indice_bod > 0)
            {
                if (indice_cat == 0)
                {
                    dgw_existencias.DataSource = sd.ObtenerExistPorBodegalike(cbo_bodega.SelectedValue.ToString(),busqueda);
                    DiseñoGrid();
                }
                else if (indice_cat > 0)
                {
                    indice_linea = cbo_linea.SelectedIndex;
                    if (indice_linea == 0)
                    {
                        dgw_existencias.DataSource = sd.UnaBodegaYUnaCategorialike(cbo_bodega.SelectedValue.ToString(), cbo_categoria.SelectedValue.ToString(), busqueda);
                        DiseñoGrid();
                    }
                    else if (indice_linea > 0)
                    {
                        dgw_existencias.DataSource = sd.UnaBodegaYUnaCategoriaYUnaLinealike(cbo_bodega.SelectedValue.ToString(), cbo_categoria.SelectedValue.ToString(), cbo_linea.SelectedValue.ToString(),busqueda);
                        DiseñoGrid();
                    }
                }
            }
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            CapaNegocio fn = new CapaNegocio();
            fn.Anterior(dgw_existencias);
           
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            CapaNegocio fn = new CapaNegocio();
            fn.Siguiente(dgw_existencias);
        }

        private void btn_primero_Click(object sender, EventArgs e)
        {
            CapaNegocio fn = new CapaNegocio();
            fn.Primero(dgw_existencias);
        }

        private void btn_ultimo_Click(object sender, EventArgs e)
        {
            CapaNegocio fn = new CapaNegocio();
            fn.Ultimo(dgw_existencias);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                //Abrir.Form1 hola = new Abrir.Form1();
                //hola.Crystal = @"C:\Users\Chrix\Desktop\cosas\03 - 11 -16\reporte_existencias\reporte_existencias\CrystalReport_existenciaas.rpt";
                //hola.Show();

                formreporteexist f = new formreporteexist();
                f.dgw_rep = dgw_existencias;
                f.Show();
            }
            catch (Exception ex){ MessageBox.Show(ex.Message); }
        }
    }
}
