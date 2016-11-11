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
    public partial class FormMedidas : Form
    {
        public FormMedidas()
        {
            InitializeComponent();
        }

        Boolean Editar;
        string id_form = "10109";
        private void FormMedidas_Load(object sender, EventArgs e)
        {
            try
            {
                CapaNegocio fn = new CapaNegocio();
                DataTable seg = seguridad.ObtenerPermisos.Permisos(seguridad.Conexion.User, id_form);
                if (seg.Rows.Count > 0)
                {
                    fn.desactivarPermiso(seg, btn_guardar, btn_eliminar, btn_editar, btn_nuevo, btn_cancelar, btn_actualizar, btn_buscar, btn_anterior, btn_siguiente, btn_primero, btn_ultimo);
                }
                //------------------------------
                txt_abrev.ReadOnly = true;
                txt_nombre.ReadOnly = true;

                SistemaInventarioDatos sd = new SistemaInventarioDatos();
                dgw_medidas.DataSource = sd.ObtenerMedidas();
                dgw_medidas.Columns[0].HeaderText = "Abreviatura";
                dgw_medidas.Columns[1].HeaderText = "Descripción";
                dgw_medidas.Columns[0].Width = 72;
                dgw_medidas.Columns[1].Width = 110;
            }
            catch (Exception ex) { MessageBox.Show("No posee los permisos necesarios!", "¡Seguridad!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
                if (!String.IsNullOrEmpty(txt_nombre.Text.Trim()) && !String.IsNullOrEmpty(txt_abrev.Text.Trim()))
                {
                    SistemaInventarioDatos sd = new SistemaInventarioDatos();
                    int x = sd.AgregarMedida(txt_abrev.Text.Trim(), txt_nombre.Text.Trim());
                    if (x == 1)
                    {
                        MessageBox.Show("medida registrada exitosamente!");
                        dgw_medidas.DataSource = sd.ObtenerMedidas();
                    }
                    else { MessageBox.Show("no se pudo ingresar la medida!"); }
                }
                else { MessageBox.Show("debe llenar todos los campos"); }
                //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
            }
            catch { MessageBox.Show("No se pudo guardar con exito"); }
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            CapaNegocio fn = new CapaNegocio();
            fn.Anterior(dgw_medidas);
            TextBox[] textbox = { txt_abrev, txt_nombre };
            fn.llenartextbox(textbox, dgw_medidas);
            
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            CapaNegocio fn = new CapaNegocio();
            fn.Siguiente(dgw_medidas);
            TextBox[] textbox = { txt_abrev, txt_nombre };
            fn.llenartextbox(textbox, dgw_medidas);
        }

        private void btn_primero_Click(object sender, EventArgs e)
        {
            CapaNegocio fn = new CapaNegocio();
            fn.Primero(dgw_medidas);
            TextBox[] textbox = { txt_abrev, txt_nombre };
            fn.llenartextbox(textbox, dgw_medidas);
        }

        private void btn_ultimo_Click(object sender, EventArgs e)
        {
            CapaNegocio fn = new CapaNegocio();
            fn.Ultimo(dgw_medidas);
            TextBox[] textbox = { txt_abrev, txt_nombre };
            fn.llenartextbox(textbox, dgw_medidas);
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            Editar = false;
            txt_abrev.ReadOnly = false;
            txt_nombre.ReadOnly = false;
            txt_abrev.Text = "";
            txt_nombre.Text = "";
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                SistemaInventarioDatos sd = new SistemaInventarioDatos();
                dgw_medidas.DataSource = sd.ObtenerMedidas();
            }
            catch { MessageBox.Show("No se pudo actualizar con exito"); }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
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
                Editar = true;
                string abreviatura = Convert.ToString(dgw_medidas.CurrentRow.Cells[0].Value);
                string desc = Convert.ToString(dgw_medidas.CurrentRow.Cells[1].Value);

            
                txt_nombre.Text = desc;
                txt_abrev.Text = abreviatura;
                txt_abrev.ReadOnly = false;
                txt_nombre.ReadOnly = false;
            }
            catch
            {
                MessageBox.Show("No existen registros que modificar");
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Editar = false;
            txt_abrev.Text = "";
            txt_nombre.Text = "";
        }
    }
}
