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
    public partial class FormLinea : Form
    {
        public FormLinea()
        {
            InitializeComponent();
        }

        private void FormLinea_Load(object sender, EventArgs e)
        {
            SistemaInventarioDatos sd = new SistemaInventarioDatos();
            cbo_categoria.DataSource = sd.ObtenerCategorias();
            cbo_categoria.ValueMember = "id_categoria_pk";
            cbo_categoria.DisplayMember = "tipo_categoria";

            dgw_lineas.DataSource = sd.ObtenerLineas();
            dgw_lineas.Columns[0].HeaderText = "Línea";
            dgw_lineas.Columns[1].HeaderText = "Categoría";
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
            if (!String.IsNullOrEmpty(txt_nombre.Text.Trim()) && cbo_categoria.SelectedIndex != -1)
            {
                SistemaInventarioDatos sd = new SistemaInventarioDatos();
                int x = sd.AgregarLinea(txt_nombre.Text.Trim(), cbo_categoria.SelectedValue.ToString());
                if (x == 1)
                {
                    MessageBox.Show("linea registrada exitosamente!");
                    dgw_lineas.DataSource = sd.ObtenerLineas();
                }
                else { MessageBox.Show("no se pudo ingresar la linea!"); }
            }
            else { MessageBox.Show("debe llenar todos los campos"); }
            //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        }
    }
}
