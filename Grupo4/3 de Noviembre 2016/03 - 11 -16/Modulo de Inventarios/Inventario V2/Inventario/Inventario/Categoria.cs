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
    public partial class Categoria : Form
    {
        public Categoria()
        {
            InitializeComponent();
        }
        Boolean Editar;
        string cate_anterior;
        private void button1_Click(object sender, EventArgs e)
        {
            FormInventarioInicio fi = new FormInventarioInicio();
            fi.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Editar)
                {
                    SistemaInventarioDatos sid = new SistemaInventarioDatos();
                    sid.Modificacion("update categoria set tipo_categoria =  '" + txt_nombre.Text + "' , id_categoria_pk = '"+txt_ident.Text.Trim()+"' where id_categoria_pk= '" + cate_anterior + "'");
                    SistemaInventarioDatos sd = new SistemaInventarioDatos();
                    dgw_categorias.DataSource = sd.ObtenerCategorias();
                    txt_ident.ReadOnly = false;
                    Editar = false;

                }
                else
                {
                    //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
                    if (!String.IsNullOrEmpty(txt_nombre.Text.Trim()) && !String.IsNullOrEmpty(txt_ident.Text.Trim()))
                    {
                        SistemaInventarioDatos sd = new SistemaInventarioDatos();
                        int x = sd.AgregarCategoria(txt_ident.Text.Trim(), txt_nombre.Text.Trim());
                        if (x == 1)
                        {
                            MessageBox.Show("categoria registrada exitosamente!");
                            dgw_categorias.DataSource = sd.ObtenerCategorias();
                        }
                        else { MessageBox.Show("no se pudo ingresar la categoria!"); }
                    }
                    else { MessageBox.Show("debe llenar todos los campos"); }
                    //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
                }

            }
            catch { }
        }

        private void Categoria_Load(object sender, EventArgs e)
        {
            txt_ident.ReadOnly = true;
            txt_nombre.ReadOnly = true;
            SistemaInventarioDatos sd = new SistemaInventarioDatos();
            dgw_categorias.DataSource = sd.ObtenerCategorias();
            dgw_categorias.Columns[0].HeaderText = "Identificador";
            dgw_categorias.Columns[1].HeaderText = "Tipo de inventario";
            dgw_categorias.Columns[0].Width = 70;
        }

        private void txt_ident_TextChanged(object sender, EventArgs e)
        {
            
            String l = txt_ident.Text.Trim();
            int digitos = l.Length;
            if (digitos == 6)
            {
                txt_ident.Text = l.Remove(5);
                txt_ident.Select(5, 0);
            }
        }

        private void txt_ident_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.ValidarNoEspacios(e);
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            CapaNegocio fn = new CapaNegocio();
            fn.Anterior(dgw_categorias);
            TextBox[] textbox = { txt_ident, txt_nombre };
            fn.llenartextbox(textbox, dgw_categorias);
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            CapaNegocio fn = new CapaNegocio();
            fn.Siguiente(dgw_categorias);
            TextBox[] textbox = { txt_ident, txt_nombre };
            fn.llenartextbox(textbox, dgw_categorias);
        }

        private void btn_primero_Click(object sender, EventArgs e)
        {
            CapaNegocio fn = new CapaNegocio();
            fn.Primero(dgw_categorias);
            TextBox[] textbox = { txt_ident, txt_nombre };
            fn.llenartextbox(textbox, dgw_categorias);
        }

        private void btn_ultimo_Click(object sender, EventArgs e)
        {
            CapaNegocio fn = new CapaNegocio();
            fn.Ultimo(dgw_categorias);
            TextBox[] textbox = { txt_ident, txt_nombre };
            fn.llenartextbox(textbox, dgw_categorias);
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            Editar = false;
            txt_nombre.ReadOnly = false;
            txt_ident.ReadOnly = false;
            txt_ident.Text = "";
            txt_nombre.Text = "";
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            SistemaInventarioDatos sd = new SistemaInventarioDatos();
            dgw_categorias.DataSource = sd.ObtenerCategorias();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            SistemaInventarioDatos sid = new SistemaInventarioDatos();
            string id_linea = Convert.ToString(dgw_categorias.CurrentRow.Cells[0].Value);
            sid.Eliminar("Update categoria set estado = 'inactivo' where id_categoria_pk= '" + id_linea + "'");
            dgw_categorias.DataSource = sid.ObtenerCategorias();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                Editar = true;
                string id_categoria = Convert.ToString(dgw_categorias.CurrentRow.Cells[0].Value);
                string tipo_categoria = Convert.ToString(dgw_categorias.CurrentRow.Cells[1].Value);



                txt_ident.ReadOnly = true;
                txt_ident.Text = id_categoria;
                txt_nombre.Text = tipo_categoria;

                txt_ident.ReadOnly = false;
                txt_nombre.ReadOnly = false;
                cate_anterior = id_categoria;

            }
            catch
            {
                MessageBox.Show("No existen registros que modificar");
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Editar = false;
            txt_ident.Text = "";
            txt_nombre.Text = "";
        }
    }
}
