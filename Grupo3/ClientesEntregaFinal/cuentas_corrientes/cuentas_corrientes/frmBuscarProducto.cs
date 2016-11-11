using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cuentas_corrientes
{
    public partial class frmBuscarProducto : Form
    {
        public frmBuscarProducto()
        {
            InitializeComponent();
        }
        public bien bienseleccionado { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = cls_cotizaciondal.Buscar(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id_bien_pk = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                bienseleccionado = cls_cotizaciondal.ObtenerProveedor(id_bien_pk);
                //MessageBox.Show();

                this.Close();
            }
            else
                MessageBox.Show("debe de seleccionar una fila");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
