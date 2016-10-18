using System;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class ComprasProveedores : Form
    {
        public ComprasProveedores()
        {
            InitializeComponent();
        }

        private void dgv_compras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void dgv_compras_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DetalleCompra abrir = new DetalleCompra();
            abrir.Show();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            InsertarCompra abrir = new InsertarCompra();
            abrir.Show();
        }
    }
}
