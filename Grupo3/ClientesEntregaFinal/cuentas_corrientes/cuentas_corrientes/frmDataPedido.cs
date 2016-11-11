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
    public partial class frmDataPedido : Form
    {
        public frmDataPedido()
        {
            InitializeComponent();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            frmPedidos temp = new frmPedidos();
            temp.ShowDialog();
        }

        private void dgv_fact_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btn_nuevo_Click_1(object sender, EventArgs e)
        {
            frmPedidos pedidos = new frmPedidos();
            pedidos.ShowDialog();
        }
    }
}
