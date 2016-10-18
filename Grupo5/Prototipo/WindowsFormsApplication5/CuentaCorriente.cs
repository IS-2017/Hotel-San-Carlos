using System;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class CuentaCorriente : Form
    {
        public CuentaCorriente()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if((comboBox1.SelectedItem.ToString()=="1100"))
            {
                textBox1.Text = "11110";
                textBox2.Text = "El Buen Precio";
                textBox3.Text = "Calle 13-03 Zona 4";

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
