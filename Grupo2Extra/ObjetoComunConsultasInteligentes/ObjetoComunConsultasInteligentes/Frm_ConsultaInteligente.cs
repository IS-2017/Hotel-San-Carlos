using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Collections;

namespace ObjetoComunConsultasInteligentes
{
    public partial class Frm_ConsultaInteligente : Form
    {
        string tabla, consulta,consultaor, consulta1,consultaand;
        MySqlConnection conexion = new MySqlConnection("server=localhost; database=prueba; Uid=root; pwd=;");
        public Frm_ConsultaInteligente()
        {
            InitializeComponent();
        }

        //public Frm_ConsultaInteligente(string ntabla)
        //{
        //    InitializeComponent();
        //    tabla = ntabla;

        //}


        private void Frm_ConsultaInteligente_Load(object sender, EventArgs e)
        {

            tabla = "empleado";
            textBox1.Text = tabla;
            
            ObtieneColumna obtienecol = new ObtieneColumna();
            ArrayList columnas;
            columnas = obtienecol.getColumnas(tabla);
            comboBox1.Items.Clear();
            comboBox3.Items.Clear();
            for (int i = 0; i < columnas.Count; i++)
            {
                comboBox1.Items.Add(columnas[i].ToString());
                comboBox3.Items.Add(columnas[i].ToString());
                  
            }

            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;


                consulta1 = "SELECT * FROM " + tabla + " WHERE " + comboBox1.Text + comboBox2.Text + comboBox3.Text;
            //    MessageBox.Show(consulta);

            generar(1);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            generar(3);
        }

        private void lbl_titulo_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            TextBox txtbx1 = new TextBox();
            txtbx1.Height = 20;
            txtbx1.Width = 80;

            panel1.Controls.Add(txtbx1);

            TextBox txtbx2 = new TextBox();
            txtbx2.Height = 20;
            txtbx2.Width = 80;
            panel2.Controls.Add(txtbx2);

            
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            //string campo1 = comboBox1.SelectedItem.ToString();
            //string op1 = comboBox2.SelectedItem.ToString();
            //string campo2 = comboBox3.SelectedItem.ToString();

            MessageBox.Show(consulta);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(and);
            generar(2);
        }

        private void generar(int opcion)
        {
            if (opcion == 1)
            {
                MessageBox.Show(consulta1);
            }
            else if(opcion == 2)
            {
                consultaand=" AND " + comboBox1.Text + comboBox2.Text + comboBox3.Text;

                MessageBox.Show(consultaand);
            }

            else if (opcion == 3)
            {

                consultaor = " OR " + comboBox1.Text + comboBox2.Text + comboBox3.Text;

                MessageBox.Show(consultaor);
            }

            consulta = consulta1 + consultaand + consultaor;
        }
    }
}
