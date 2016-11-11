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
    public partial class FormLinea : Form
    {
        public FormLinea()
        {
            InitializeComponent();
        }
        Boolean Editar;
        string linea_ant;
        string id_form = "10108";
        private void FormLinea_Load(object sender, EventArgs e)
        {
            try
            {
                CapaNegocio fn = new CapaNegocio();
                DataTable seg = seguridad.ObtenerPermisos.Permisos(seguridad.Conexion.User, id_form);
                if (seg.Rows.Count > 0)
                {
                    fn.desactivarPermiso(seg, btn_guardar, btn_eliminar, btn_editar, btn_nuevo, btn_cancelar, btn_actualizar, btn_buscar, btn_anterior, btn_siguiente, btn_primero, btn_ultimo);
                }
                //----------------------------
                cbo_categoria.Enabled = false;
                txt_nombre.ReadOnly = true;

                SistemaInventarioDatos sd = new SistemaInventarioDatos();
                cbo_categoria.DataSource = sd.ObtenerCategorias();
                cbo_categoria.ValueMember = "id_categoria_pk";
                cbo_categoria.DisplayMember = "tipo_categoria";

                dgw_lineas.DataSource = sd.ObtenerLineas2();
                dgw_lineas.Columns[0].HeaderText = "ID";
                dgw_lineas.Columns[1].HeaderText = "Línea";
                dgw_lineas.Columns[2].HeaderText = "Categoría";


                dgw_lineas.Columns[0].Width = 30;
            }
            catch (Exception ex) { MessageBox.Show("No posee los permisos necesarios!", "¡Seguridad!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Editar)
                {
                    SistemaInventarioDatos sid = new SistemaInventarioDatos();
                    sid.Modificacion("update linea set nombre_linea='" + txt_nombre.Text + "',id_categoria_pk='" + cbo_categoria.SelectedValue.ToString() + "' where id_linea_pk= '" + linea_ant + "'");
                    //SistemaInventarioDatos sd = new SistemaInventarioDatos();
                    dgw_lineas.DataSource = sid.ObtenerLineas2();
                    Editar = false;
                }
                else
                {
                    //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
                    if (!String.IsNullOrEmpty(txt_nombre.Text.Trim()) && cbo_categoria.SelectedIndex != -1)
                    {
                        SistemaInventarioDatos sd = new SistemaInventarioDatos();
                        int x = sd.AgregarLinea(txt_nombre.Text.Trim(), cbo_categoria.SelectedValue.ToString());
                        if (x == 1)
                        {
                            MessageBox.Show("linea registrada exitosamente!");
                            dgw_lineas.DataSource = sd.ObtenerLineas2();
                        }
                        else { MessageBox.Show("no se pudo ingresar la linea!"); }
                    }
                    else { MessageBox.Show("debe llenar todos los campos"); }
                    //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
                }

            }
            catch { MessageBox.Show("No se pudo guardar con exito"); }
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            CapaNegocio fn = new CapaNegocio();
            fn.Anterior(dgw_lineas);
            TextBox[] textbox = {  txt_nombre };
            fn.llenartextbox(textbox, dgw_lineas);
            
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            CapaNegocio fn = new CapaNegocio();
            fn.Siguiente(dgw_lineas);
            TextBox[] textbox = {  txt_nombre };
            fn.llenartextbox(textbox, dgw_lineas);
            
        }

        private void btn_primero_Click(object sender, EventArgs e)
        {
            CapaNegocio fn = new CapaNegocio();
            fn.Primero(dgw_lineas);
            TextBox[] textbox = {  txt_nombre };
            fn.llenartextbox(textbox, dgw_lineas);
           
        }

        private void btn_ultimo_Click(object sender, EventArgs e)
        {
            CapaNegocio fn = new CapaNegocio();
            fn.Ultimo(dgw_lineas);
            TextBox[] textbox = {  txt_nombre };
            fn.llenartextbox(textbox, dgw_lineas);
           
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            Editar = false;
            cbo_categoria.Enabled = true;
            txt_nombre.ReadOnly = false;
            txt_nombre.Text = "";
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                SistemaInventarioDatos sd = new SistemaInventarioDatos();
                cbo_categoria.DataSource = sd.ObtenerCategorias();
            }
            catch { MessageBox.Show("No se pudo actualizar con exito"); }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                SistemaInventarioDatos sid = new SistemaInventarioDatos();
                string id_linea = Convert.ToString(dgw_lineas.CurrentRow.Cells[0].Value);
                sid.Eliminar("Update linea set estado = 'inactivo' where id_linea_pk= '" + id_linea + "'");
                dgw_lineas.DataSource = sid.ObtenerLineas2();
            }
            catch { MessageBox.Show("No se pudo eliminar con exito"); }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                Editar = true;
                string categoria = Convert.ToString(dgw_lineas.CurrentRow.Cells[2].Value);
                string nombre_linea = Convert.ToString(dgw_lineas.CurrentRow.Cells[1].Value);
                linea_ant = Convert.ToString(dgw_lineas.CurrentRow.Cells[0].Value);

                int indice = cbo_categoria.FindString(categoria.Trim());
                cbo_categoria.SelectedIndex = indice;
                txt_nombre.Text = nombre_linea;
                txt_nombre.ReadOnly = false;
                cbo_categoria.Enabled = true;
            }
            catch
            {
                MessageBox.Show("No existen registros que modificar");
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Editar = false;
            txt_nombre.Text = "";
        }
    }
}
