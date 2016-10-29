using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Abrir;

namespace WindowsFormsApplication5
{
    public partial class CC_Proveedor : Form
    {
        public CC_Proveedor()
        {
            InitializeComponent();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {

        }

        private void CC_Proveedor_Load(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((comboBox1.SelectedItem.ToString() == "1100"))
            {
                textBox1.Text = "11110";
                textBox2.Text = "El Buen Precio";
                textBox3.Text = "Calle 13-03 Zona 4";

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PagoProveedor pp = new PagoProveedor();
           
            pp.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Abrir.Form1 f = new Form1();
            //Ubicacion de RTP del modulo a probar
            f.Crystal = @"C:\Users\ccarrera\Desktop\Entregar\Prueba\Prueba\CrystalReport1.rpt";
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }
    }
}
