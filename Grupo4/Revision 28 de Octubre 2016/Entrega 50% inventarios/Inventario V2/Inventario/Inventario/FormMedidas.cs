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
    public partial class FormMedidas : Form
    {
        public FormMedidas()
        {
            InitializeComponent();
        }

        private void FormMedidas_Load(object sender, EventArgs e)
        {
            SistemaInventarioDatos sd = new SistemaInventarioDatos();
            dgw_medidas.DataSource = sd.ObtenerMedidas();
            dgw_medidas.Columns[0].HeaderText = "Abreviatura";
            dgw_medidas.Columns[1].HeaderText = "Descripción";
            dgw_medidas.Columns[0].Width = 72;
            dgw_medidas.Columns[1].Width = 110;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
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
    }
}
