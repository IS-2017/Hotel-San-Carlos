using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dll_grafica
{
    public partial class frm_menu2 : Form
    {
        public frm_menu2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fmr_barracomp op = new fmr_barracomp();
            op.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_grafcomp op = new frm_grafcomp();
            op.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm_piecomp op = new frm_piecomp();
            op.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
