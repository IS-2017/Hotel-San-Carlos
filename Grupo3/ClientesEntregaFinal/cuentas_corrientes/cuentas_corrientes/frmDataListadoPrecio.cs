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
    public partial class frmDataListadoPrecio : Form
    {
        public frmDataListadoPrecio()
        {
            InitializeComponent();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            frmListadoPrecio tem =new frmListadoPrecio();
            tem.ShowDialog();
        }
    }
}
