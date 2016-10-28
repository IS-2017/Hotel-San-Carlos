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
    public partial class marca : Form
    {
        public marca()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void marca_Load(object sender, EventArgs e)
        {
            SistemaInventarioDatos sd = new SistemaInventarioDatos();
            dgw_marca.DataSource = sd.ObtenerMarcas();
            dgw_marca.Columns[0].HeaderText = "Marca";
            //dgw_marca.Columns[0].Width = 72;
            //dgw_marca.Columns[1].Width = 110;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
            if (!String.IsNullOrEmpty(txt_marca.Text.Trim()))
            {
                SistemaInventarioDatos sd = new SistemaInventarioDatos();
                int x = sd.AgregarMarca(txt_marca.Text.Trim());
                if (x == 1)
                {
                    MessageBox.Show("marca registrada exitosamente!");
                    dgw_marca.DataSource = sd.ObtenerMarcas();
                }
                else { MessageBox.Show("no se pudo ingresar la marca!"); }
            }
            else { MessageBox.Show("debe llenar todos los campos"); }
            //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        }
    }
}
