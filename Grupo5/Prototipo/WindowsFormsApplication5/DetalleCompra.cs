using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class DetalleCompra : Form
    {
        public DetalleCompra()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GastosImportacion abrir = new GastosImportacion();
            abrir.Show();
        }
    }
}
