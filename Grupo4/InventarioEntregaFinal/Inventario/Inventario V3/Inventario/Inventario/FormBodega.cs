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
    public partial class FormBodega : Form
    {
        public FormBodega()
        {
            InitializeComponent();
        }
        string id_form = "10102";
        Boolean Editar;
        string bodega_anterior;
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Editar)
                {
                    SistemaInventarioDatos sid = new SistemaInventarioDatos();
                    sid.Modificacion("update bodega set ubicacion= '" + txt_ubicacion.Text + "', nombre_bodega = '" + txt_nombre.Text + "', id_empresa_pk ='" + cbo_empresa.SelectedValue.ToString() + "' where id_bodega_pk= " + bodega_anterior + "");
                    SistemaInventarioDatos sd = new SistemaInventarioDatos();
                    dvg_bodega.DataSource = sd.VistaBodega();
                    Editar = false;
                }
                else
                {
                    //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
                    if (!String.IsNullOrEmpty(txt_ubicacion.Text.Trim()) && !String.IsNullOrEmpty(txt_nombre.Text.Trim()))
                    {
                        SistemaInventarioDatos sd = new SistemaInventarioDatos();
                        int x = sd.AgregarBodega(txt_ubicacion.Text.Trim(), txt_nombre.Text.Trim(), Convert.ToInt32(cbo_empresa.SelectedValue));
                        if (x == 1)
                        {
                            MessageBox.Show("Bodega registrada exitosamente!");
                            dvg_bodega.DataSource = sd.VistaBodega();
                        }
                        else { MessageBox.Show("no se pudo ingresar la bodega!"); }
                    }
                    else { MessageBox.Show("debe llenar todos los campos"); }
                    //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
                }
            }
            catch { MessageBox.Show("No se pudo guardar con exito"); }
        }

        private void FormBodega_Load(object sender, EventArgs e)
        {
            try
            {
                CapaNegocio fn = new CapaNegocio();
                DataTable seg = seguridad.ObtenerPermisos.Permisos(seguridad.Conexion.User, id_form);
                if (seg.Rows.Count > 0)
                {
                    fn.desactivarPermiso(seg, btn_guardar, btn_eliminar, btn_editar, btn_nuevo, btn_cancelar, btn_actualizar, btn_buscar, btn_anterior, btn_siguiente, btn_primero, btn_ultimo);
                }
                txt_nombre.ReadOnly = true;
                txt_ubicacion.ReadOnly = true;
                cbo_empresa.Enabled = false;
                SistemaInventarioDatos sd = new SistemaInventarioDatos();
                dvg_bodega.DataSource = sd.VistaBodega();
                dvg_bodega.Columns[0].HeaderText = "ID";
                dvg_bodega.Columns[1].HeaderText = "Nombre";
                dvg_bodega.Columns[2].HeaderText = "Ubicación";
                dvg_bodega.Columns[3].HeaderText = "Empresa";

                dvg_bodega.Columns[0].Width = 0;
                cbo_empresa.DataSource = sd.ObtenerEmpresas();
                cbo_empresa.ValueMember = "id_empresa_pk";
                cbo_empresa.DisplayMember = "nombre";
            }
            catch (Exception ex) { MessageBox.Show("No posee los permisos necesarios!", "¡Seguridad!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            try
            {
                CapaNegocio fn = new CapaNegocio();
                fn.Anterior(dvg_bodega);
                TextBox[] textbox = { txt_ubicacion, txt_nombre };
                fn.llenartextbox(textbox, dvg_bodega);
            }
            catch { }
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            try
            {
                CapaNegocio fn = new CapaNegocio();
                fn.Siguiente(dvg_bodega);
                TextBox[] textbox = { txt_ubicacion, txt_nombre };
                fn.llenartextbox(textbox, dvg_bodega);
            }catch { }
        }

        private void btn_primero_Click(object sender, EventArgs e)
        {
            try
            {
                CapaNegocio fn = new CapaNegocio();
                fn.Primero(dvg_bodega);
                TextBox[] textbox = { txt_ubicacion, txt_nombre };
                fn.llenartextbox(textbox, dvg_bodega);
            }
            catch { }
        }

        private void btn_ultimo_Click(object sender, EventArgs e)
        {
            try
            {
                CapaNegocio fn = new CapaNegocio();
                fn.Ultimo(dvg_bodega);
                TextBox[] textbox = { txt_ubicacion, txt_nombre };
                fn.llenartextbox(textbox, dvg_bodega);
            }
            catch { }
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            Editar = false;
            txt_nombre.ReadOnly = false;
            txt_ubicacion.ReadOnly = false;
            cbo_empresa.Enabled = true;

            txt_nombre.Text = "";
            txt_ubicacion.Text = "";
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                SistemaInventarioDatos sd = new SistemaInventarioDatos();
                dvg_bodega.DataSource = sd.VistaBodega();
            }
            catch { MessageBox.Show("No se pudo actualizar con exito"); }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                SistemaInventarioDatos sid = new SistemaInventarioDatos();
                string bodega = Convert.ToString(dvg_bodega.CurrentRow.Cells[0].Value);
                if (bodega == "1" || bodega == "2")
                {
                    MessageBox.Show("Esta bodega no se puede eliminar","¡Alerta!",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    sid.Eliminar("Update bodega set estado = 'inactivo' where id_bodega_pk= '" + bodega + "'");

                    dvg_bodega.DataSource = sid.VistaBodega();
                }
            }
            catch { MessageBox.Show("No se pudo eliminar con exito"); }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                Editar = true;
                string id_bodega = Convert.ToString(dvg_bodega.CurrentRow.Cells[0].Value);
                string nombre_bodega = Convert.ToString(dvg_bodega.CurrentRow.Cells[1].Value);
                string ubicacion = Convert.ToString(dvg_bodega.CurrentRow.Cells[2].Value);
                string empresa = Convert.ToString(dvg_bodega.CurrentRow.Cells[3].Value);

                txt_ubicacion.Text = ubicacion;
                txt_nombre.Text = nombre_bodega;
                int indice = cbo_empresa.FindString(empresa.Trim());
                cbo_empresa.SelectedIndex = indice;

                cbo_empresa.Enabled = true;
                txt_nombre.ReadOnly = false;
                txt_ubicacion.ReadOnly = false;
                bodega_anterior = Convert.ToString(dvg_bodega.CurrentRow.Cells[0].Value);
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
            txt_ubicacion.Text = "";
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string tabla = "bodega";
            operaciones op = new operaciones();
            op.ejecutar(dvg_bodega, tabla);
        }
    }
}
