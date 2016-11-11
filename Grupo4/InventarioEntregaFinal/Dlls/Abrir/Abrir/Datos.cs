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
        
      
        private void limpiar()
        {
            txt_nombre.Text = "";
            txt_ubicacion.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Manejocs mm = new Manejocs();
                txt_ubicacion.Text = txt_ubicacion.Text.Replace("\\","\\\\");
                mm.insertarRPT(txt_nombre.Text, txt_ubicacion.Text);
                
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
