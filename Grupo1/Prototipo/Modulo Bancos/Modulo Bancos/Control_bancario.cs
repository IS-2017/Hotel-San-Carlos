using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modulo_Bancos
{
    public partial class Control_bancario : Form
    {
        public Control_bancario()
        {
            InitializeComponent();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            Busqueda_Documento a = new Busqueda_Documento();
            a.ShowDialog();
        }
    }
}
