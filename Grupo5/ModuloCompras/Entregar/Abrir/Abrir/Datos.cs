using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Abrir
{
    public partial class Datos : Form
    {
        public string ruta;
        public Datos()
        {
            InitializeComponent();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {

        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            try
            {
                this.ofp_rpt.ShowDialog();
                if(!string.IsNullOrEmpty(this.ofp_rpt.FileName))
                {
                    txt_ubicacion.Text = this.ofp_rpt.FileName;
                }
            }
            catch(Exception ex)
            { MessageBox.Show(ex.Message); }
        }
        
        public static void Escribir(string Input,string Ruta)
        {
            try
            {
                StreamWriter WriterReportFile = File.AppendText(Ruta);
                WriterReportFile.WriteLine(Input);
                WriterReportFile.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void limpiar()
        {
            txt_nombre.Text = "";
            txt_ubicacion.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string linea = txt_nombre.Text + "," + txt_ubicacion.Text;
                Escribir(linea, ruta);
                MessageBox.Show("CrystalReport Agregado");
                limpiar();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                Form2 f = new Form2();
                f.ARCHIVO = ruta;
                f.Show();
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Datos_Load(object sender, EventArgs e)
        {

        }
    }
}
