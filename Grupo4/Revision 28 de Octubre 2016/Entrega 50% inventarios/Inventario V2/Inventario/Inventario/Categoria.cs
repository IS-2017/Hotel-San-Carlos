using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario
{
    public partial class Categoria : Form
    {
        public Categoria()
        {
            InitializeComponent();
        }

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
            else{ MessageBox.Show("debe llenar todos los campos"); }
            //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        }

        private void Categoria_Load(object sender, EventArgs e)
        {
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
    }
}
