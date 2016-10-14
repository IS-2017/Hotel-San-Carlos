using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjetoComunConsultasInteligentes
{
    public partial class ConsultasAlmacenadas : Form
    {
        ObtieneColumna ejecutar = new ObtieneColumna();

        public ConsultasAlmacenadas()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ConsultasAlmacenadas_Load(object sender, EventArgs e)
        {
            String guardad = "select * from consultaguardada where idform = 1;";
            ejecutar.actualizargrid(guardad, dataGridView1);



        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frm_ConsultaInteligente frm = new Frm_ConsultaInteligente();
            this.Hide();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
