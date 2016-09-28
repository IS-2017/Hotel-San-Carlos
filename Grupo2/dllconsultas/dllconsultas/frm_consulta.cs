using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

//rodrigo:convertir a dll
namespace dllconsultas
{
    public partial class frm_consulta : Form
    {
        DataGridView dg;
        metodos obtienecol = new metodos();
        string tabla, consultaa, consultaor, consulta1, consultaand, b1, b2, consultabet, consultalike;
        public frm_consulta(DataGridView gb,string tabla)
        {
            this.dg = gb;
            this.tabla = tabla;
            InitializeComponent();
        }

        private void lbl_titulo_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_NombreTabla_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                button2.Enabled = true;
                button3.Enabled = true;
                button7.Enabled = true;
                consulta1 = "SELECT * FROM " + tabla + " WHERE " + comboBox1.Text + comboBox2.Text + comboBox3.Text;
                generar(1);
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR: " + ex);
            }
        }
        private void generar(int opcion)
        {
            try
            {
                if (opcion == 1)
                {
                    MessageBox.Show(consulta1);
                }
                else if (opcion == 2)
                {
                    consultaand = " AND " + comboBox1.Text + comboBox2.Text + comboBox3.Text;

                    MessageBox.Show(consultaand);
                }

                else if (opcion == 3)
                {

                    consultaor = " OR " + comboBox1.Text + comboBox2.Text + comboBox3.Text;

                    MessageBox.Show(consultaor);


                }
                else if (opcion == 4)
                {

                    consultabet = " AND " + comboBox1.Text + " BETWEEN " + "'" + b1 + "' AND '" + b2 + "'";

                    MessageBox.Show(consultabet);


                }


                consultaa = consulta1 + consultabet + consultaand + consultaor;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            generar(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            generar(3);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string query1 = "select * from " + tabla + ";";
            obtienecol.actualizargrid(query1, dg);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            frm_almacenadas consultal = new frm_almacenadas(tabla,dg);
            consultal.Show();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            b1 = textBox2.Text;
            b2 = textBox3.Text;
            generar(4);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button4.Enabled = true;
            comboBox4.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
        }

        private void frm_consulta_Load(object sender, EventArgs e)
        {try
            {
                textBox1.Text = tabla;


                ArrayList columnas;
                columnas = obtienecol.getColumnas(tabla);
                comboBox1.Items.Clear();
                comboBox3.Items.Clear();
                comboBox4.Items.Clear();

                for (int i = 0; i < columnas.Count; i++)
                {
                    comboBox1.Items.Add(columnas[i].ToString());
                    comboBox3.Items.Add(columnas[i].ToString());
                    comboBox4.Items.Add(columnas[i].ToString());

                }

                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                //button5.Enabled = false;
                button7.Enabled = false;
                comboBox4.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                button7.Enabled = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR: " + ex);
            } 
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (consultaa == "")
                {
                    MessageBox.Show("Debe de llenar los campos para realizar una consulta");
                }
                else
                {
                    obtienecol.actualizargrid(consultaa, dg);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR: " + ex);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (consultaa == null)
            {
                MessageBox.Show("No hay consulta para guardar");
            }
            else
            {
                frm_guardar guardar = new frm_guardar(consultaa,tabla);
                guardar.Show();
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
