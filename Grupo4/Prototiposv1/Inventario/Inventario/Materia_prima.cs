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
    public partial class Materia_prima : Form
    {
        public Materia_prima()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormInventarioInicio fi = new FormInventarioInicio();
            fi.Show();
            this.Show();
        }
    }
}
