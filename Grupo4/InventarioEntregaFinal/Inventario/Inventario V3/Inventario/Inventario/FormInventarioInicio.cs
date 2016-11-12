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
using dllconsultas;

namespace Inventario
{
    public partial class FormInventarioInicio : Form
    {
        public FormInventarioInicio()
        {
            InitializeComponent();
        }

        string id_form = "10106";
        private void FormInventarioInicio_Load(object sender, EventArgs e)
        {
            try
            {
                CapaNegocio fn = new CapaNegocio();
                DataTable seg = seguridad.ObtenerPermisos.Permisos(seguridad.Conexion.User, id_form);
                if (seg.Rows.Count > 0)
                {
                    fn.desactivarPermiso(seg, btn_guardar, btn_eliminar, btn_editar, btn_nuevo, btn_cancelar, btn_actualizar, btn_buscar, btn_anterior, btn_siguiente, btn_primero, btn_ultimo);
                }
                SistemaInventarioDatos sd = new SistemaInventarioDatos();
                dgw_bienes.DataSource = sd.MostrarInventario();
                dgw_bienes.Columns[0].HeaderText = "Codigo";
                dgw_bienes.Columns[1].HeaderText = "Descripción";
                dgw_bienes.Columns[2].HeaderText = "Categoría";
                dgw_bienes.Columns[3].HeaderText = "Existencias";
                dgw_bienes.Columns[4].HeaderText = "Precio";
                dgw_bienes.Columns[5].HeaderText = "Costo";
                dgw_bienes.Columns[6].HeaderText = "Medida";
                dgw_bienes.Columns[7].HeaderText = "Línea";
                dgw_bienes.Columns[8].HeaderText = "Marca";

                dgw_bienes.Columns[0].Width = 67;
                dgw_bienes.Columns[1].Width = 282;
                dgw_bienes.Columns[2].Width = 78;
                dgw_bienes.Columns[3].Width = 62;
                dgw_bienes.Columns[4].Width = 50;
                dgw_bienes.Columns[5].Width = 50;
                dgw_bienes.Columns[6].Width = 69;
                dgw_bienes.Columns[7].Width = 88;
                dgw_bienes.Columns[8].Width = 89;

            }
            catch (Exception ex) { MessageBox.Show("No posee los permisos necesarios!", "¡Seguridad!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FormNuevoProducto np = new FormNuevoProducto();
            np.Show();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            FormNuevoProducto f = new FormNuevoProducto();
            f.MdiParent = this.MdiParent;
            f.Show();
        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SistemaInventarioDatos sd = new SistemaInventarioDatos();
                string busqueda = txt_buscar.Text.Trim();
                dgw_bienes.DataSource = sd.VistaProdLike(busqueda);
            }
            catch { MessageBox.Show("No se pudo buscar con exito"); }
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            CapaNegocio fn = new CapaNegocio();
            fn.Anterior(dgw_bienes);
           
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            CapaNegocio fn = new CapaNegocio();
            fn.Siguiente(dgw_bienes);
        }

        private void btn_primero_Click(object sender, EventArgs e)
        {
            CapaNegocio fn = new CapaNegocio();
            fn.Primero(dgw_bienes);
        }

        private void btn_ultimo_Click(object sender, EventArgs e)
        {
            CapaNegocio fn = new CapaNegocio();
            fn.Ultimo(dgw_bienes);
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                SistemaInventarioDatos sd = new SistemaInventarioDatos();
                dgw_bienes.DataSource = sd.MostrarInventario();
            }
            catch { MessageBox.Show("No se pudo actualizar con exito"); }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string tabla = "bien";
            operaciones op = new operaciones();
            op.ejecutar(dgw_bienes, tabla);
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch { MessageBox.Show("No se pudo eliminar con exito"); }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                string codigo = dgw_bienes.CurrentRow.Cells[0].Value.ToString();
                string[] codigo_separado = codigo.Split('-');
                string categoria = codigo_separado[0].ToString();
                string id_bien = codigo_separado[1].ToString();
                string descripcion = dgw_bienes.CurrentRow.Cells[1].Value.ToString().Trim();
                string categoria_nom = dgw_bienes.CurrentRow.Cells[2].Value.ToString().Trim();
                string precio = dgw_bienes.CurrentRow.Cells[4].Value.ToString().Trim();
                string costo = dgw_bienes.CurrentRow.Cells[5].Value.ToString().Trim();
                string medida = dgw_bienes.CurrentRow.Cells[6].Value.ToString().Trim();
                string linea = dgw_bienes.CurrentRow.Cells[7].Value.ToString().Trim();
                string marca = dgw_bienes.CurrentRow.Cells[8].Value.ToString().Trim();



                SistemaInventarioDatos sd = new SistemaInventarioDatos();
                FormNuevoProducto f = new FormNuevoProducto();
                f.MdiParent = this.MdiParent;
                f.Show();
                f.txt_desc.Text = descripcion;
                f.txt_costo.Text = costo;
                f.txt_precio.Text = precio;
                string comisdion = sd.ObtenerComision(id_bien, categoria);
                f.txt_comision.Text = comisdion;

                int indice_categoria = f.cbo_Categoria.FindString(categoria_nom);
                f.cbo_Categoria.SelectedIndex = indice_categoria;

                int indice_linea = f.cbo_linea.FindString(linea);
                f.cbo_linea.SelectedIndex = indice_linea;

                int indice_marca = f.cbo_marca.FindString(marca);
                f.cbo_marca.SelectedIndex = indice_marca;

                string medidareal = sd.ObtenerMedidaReal(medida);
                int indice_medida = f.cbo_medida.FindString(medidareal);
                f.cbo_medida.SelectedIndex = indice_medida;

                f.lbl_codigo.Text = codigo;

                f.cbo_Categoria.Enabled = false;
                f.Editar = true;
                f.id_bien = id_bien;
                f.id_categria = categoria;
                //f.MdiParent = this.MdiParent;
                // f.Show();
            }
            catch (Exception ex){ MessageBox.Show(ex.Message); }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                SistemaInventarioDatos sid = new SistemaInventarioDatos();
                string codigo = dgw_bienes.CurrentRow.Cells[0].Value.ToString();
                string[] codigo_separado = codigo.Split('-');
                string categoria = codigo_separado[0].ToString();
                string id_bien = codigo_separado[1].ToString();

                sid.Eliminar("Update bien set estado = 'inactivo' where id_bien_pk= " + id_bien + " and id_categoria_pk = '"+categoria+"'");
                MessageBox.Show("Eliminado con exito");
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
