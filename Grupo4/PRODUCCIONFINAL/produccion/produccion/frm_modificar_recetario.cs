using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace produccion
{
    public partial class frm_modificar_recetario : Form
    {
        public frm_modificar_recetario()
        {
            InitializeComponent();
        }
        String opcioncategoria = "";
        private void frm_modificar_recetario_Load(object sender, EventArgs e)
        {try
            {
                // Carga de combobox Clasificacion
                CapaDatos cdcat = new CapaDatos();
                DataTable dtcat = cdcat.CargarDatosBienClasificacion();



                cmb_categoria.DataSource = dtcat;
                cmb_categoria.DisplayMember = "nombre_linea";
                cmb_categoria.ValueMember = "id_linea_pk";


                // Carga de combobox procesos

                CapaDatos cd = new CapaDatos();
                DataTable recolector = cd.CargaDatosProceso();

                cmb_proceso.DataSource = recolector;
                cmb_proceso.DisplayMember = "nombre_proceso";
                cmb_proceso.ValueMember = "id_proceso_pk";


                //Cargar combobox de medida

                CapaDatos cdmedida = new CapaDatos();
                DataTable medida = cdmedida.CargarDatosMedida();

                cmb_medida.DataSource = medida;
                cmb_medida.DisplayMember = "nombre_medida";
                cmb_medida.ValueMember = "id_medida_pk";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        // Boton para consultar el detalle de formula segun encabezado
        private void btn_consultar_Click(object sender, EventArgs e)
        {
            
        }

        // Nombre de receta en etiqueta de descripcion
        private void txt_nombre_receta_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lbl_nombre_formula.Text = txt_nombre_receta.Text.Trim();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void cmb_categoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // carga de materia prima segun categoria
                CapaDatos cd = new CapaDatos();
                opcioncategoria = cmb_categoria.SelectedValue.ToString();

                DataTable dt = cd.CargaDatosBien(opcioncategoria);

                cmb_materia_prima.DataSource = dt;
                cmb_materia_prima.DisplayMember = "descripcion";
                cmb_materia_prima.ValueMember = "id_bien_pk";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // modificar al hacer doble clic
        private void dgv_modifica_receta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_cantidad_formula.Text = dgv_modifica_receta.Rows[dgv_modifica_receta.CurrentRow.Index].Cells["cantidad"].Value.ToString();


                String id_receta = dgv_modifica_receta.Rows[dgv_modifica_receta.CurrentRow.Index].Cells["id_receta_pk"].Value.ToString();
                String cantidad = dgv_modifica_receta.Rows[dgv_modifica_receta.CurrentRow.Index].Cells["cantidad"].Value.ToString();
                String id_proceso = dgv_modifica_receta.Rows[dgv_modifica_receta.CurrentRow.Index].Cells["id_proceso_pk"].Value.ToString();
                String id_medida = dgv_modifica_receta.Rows[dgv_modifica_receta.CurrentRow.Index].Cells["id_medida_pk"].Value.ToString();
                String id_categoria = dgv_modifica_receta.Rows[dgv_modifica_receta.CurrentRow.Index].Cells["id_categoria_pk"].Value.ToString();
                String id_bien = dgv_modifica_receta.Rows[dgv_modifica_receta.CurrentRow.Index].Cells["id_bien_pk"].Value.ToString();

                //MessageBox.Show(id_receta + "  " + cantidad + " " + " " + id_proceso + " " + id_medida + " " + id_categoria + " " + id_bien);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgv_modifica_receta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_cuerpo_receta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        // datagrid contenedor de los nombres segun receta consultada

        private void dgv_cuerpo_receta_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                String correlativo = dgv_cuerpo_receta.Rows[dgv_cuerpo_receta.CurrentRow.Index].Cells["correlativo"].Value.ToString();
                String id_receta = dgv_cuerpo_receta.Rows[dgv_cuerpo_receta.CurrentRow.Index].Cells["nombre_receta"].Value.ToString();
                String cantidad = dgv_cuerpo_receta.Rows[dgv_cuerpo_receta.CurrentRow.Index].Cells["cantidad"].Value.ToString();
                String id_proceso = dgv_cuerpo_receta.Rows[dgv_cuerpo_receta.CurrentRow.Index].Cells["nombre_proceso"].Value.ToString();
                String id_medida = dgv_cuerpo_receta.Rows[dgv_cuerpo_receta.CurrentRow.Index].Cells["nombre_medida"].Value.ToString();
                String clasificacion = dgv_cuerpo_receta.Rows[dgv_cuerpo_receta.CurrentRow.Index].Cells["clasificacion"].Value.ToString();
                String id_bien = dgv_cuerpo_receta.Rows[dgv_cuerpo_receta.CurrentRow.Index].Cells["descripcion"].Value.ToString();

                txt_cantidad_formula.Text = cantidad;
                cmb_categoria.Text = clasificacion;
                cmb_materia_prima.Text = id_bien;
                cmb_medida.Text = id_medida;
                cmb_proceso.Text = id_proceso;
                lbl_correlativo.Text = correlativo;
                //MessageBox.Show(correlativo + " " + id_receta + "  " + cantidad + " " + " " + id_proceso + " " + id_medida + " " + id_bien);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // boton para modificar

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            //CapaDatos cd = new CapaDatos();
            //cd.ModificarReceta(txt_cantidad_formula.Text.Trim(), cmb_proceso.SelectedValue.ToString(), cmb_medida.SelectedValue.ToString(),
            //    cmb_categoria.SelectedValue.ToString(), cmb_materia_prima.SelectedValue.ToString(), lbl_correlativo.Text);

            //MessageBox.Show("Registro modificado con exito");


        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                double tiempo_proceso = 0;
                double costo = 0;
                CapaDatos cd = new CapaDatos();
                DataTable dt = cd.ConsultarRecetaDetalle(lbl_id_receta_enc.Text.ToString());

                dgv_modifica_receta.DataSource = dt;

                // llenar grid de nombres vista de usuario
                DataTable dtnombres = cd.ConsultarNombresRecetaDetalle(lbl_id_receta_enc.Text.ToString());
                dgv_cuerpo_receta.DataSource = dtnombres;
                // sumar columna de costos y horas hombre
                foreach (DataGridViewRow columna in dgv_cuerpo_receta.Rows)
                {
                    tiempo_proceso += Convert.ToDouble(columna.Cells["tiempo_proceso"].Value);
                    costo += Convert.ToDouble(columna.Cells["costo"].Value);
                }

                lbl_hrs_hombre.Text = tiempo_proceso.ToString();
                lbl_costo.Text = costo.ToString();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                CapaDatos cd = new CapaDatos();
                cd.ModificarReceta(txt_cantidad_formula.Text.Trim(), cmb_proceso.SelectedValue.ToString(), cmb_medida.SelectedValue.ToString(),
                    cmb_categoria.SelectedValue.ToString(), cmb_materia_prima.SelectedValue.ToString(), lbl_correlativo.Text);

                MessageBox.Show("Registro modificado con exito");
            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.Message);
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {

        }
    }
}
