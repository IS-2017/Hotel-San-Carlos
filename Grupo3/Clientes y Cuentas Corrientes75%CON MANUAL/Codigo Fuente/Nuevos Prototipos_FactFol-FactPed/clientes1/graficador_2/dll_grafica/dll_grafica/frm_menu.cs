using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graf1
{
    public partial class frm_menu : Form
    {
        public frm_menu()
        {
            InitializeComponent();
        }

        private void btn_graba_Click(object sender, EventArgs e)
        {
            frm_grafbarra gra = new frm_grafbarra();
            gra.ShowDialog();
        }

        private void btn_grahori_Click(object sender, EventArgs e)
        {
            frm_grafhori gra = new frm_grafhori();
            gra.ShowDialog();
        }

        private void btn_pie_Click(object sender, EventArgs e)
        {
            frm_grafpie gra = new frm_grafpie();
            gra.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
