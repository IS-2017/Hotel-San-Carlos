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
    public partial class Muestreo : Form
    {
        public Muestreo()
        {
            InitializeComponent();
        }

        private void Muestreo_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormInventarioInicio fi = new FormInventarioInicio();
            fi.Show();
            this.Hide();
        }
    }
}
