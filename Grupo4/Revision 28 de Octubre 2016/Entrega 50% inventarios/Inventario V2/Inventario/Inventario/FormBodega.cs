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
    public partial class FormBodega : Form
    {
        public FormBodega()
        {
            InitializeComponent();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
            if (!String.IsNullOrEmpty(txt_ubicacion.Text.Trim()) && !String.IsNullOrEmpty(txt_nombre.Text.Trim()) )
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

        private void FormBodega_Load(object sender, EventArgs e)
        {
            SistemaInventarioDatos sd = new SistemaInventarioDatos();
            dvg_bodega.DataSource = sd.VistaBodega();
            dvg_bodega.Columns[0].HeaderText = "Nombre";
            dvg_bodega.Columns[1].HeaderText = "Ubicación";
            dvg_bodega.Columns[2].HeaderText = "Empresa";


            cbo_empresa.DataSource = sd.ObtenerEmpresas();
            cbo_empresa.ValueMember = "id_empresa_pk";
            cbo_empresa.DisplayMember = "nombre";
        }
    }
}
