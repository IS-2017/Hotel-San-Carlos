using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class detalle : Form
    {
        public detalle(string cantidad)
        {
          

            InitializeComponent();
            this.lacantidad = cantidad;
        }
        string lacantidad;
        
       

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            vista_general vista = new vista_general();
            vista.ShowDialog();
        }

      

        private void Form1_Load(object sender, EventArgs e)
        {
           
          

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TextBox[,] tb = new TextBox[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    tb[i, j] = new TextBox();
                    tb[i, j].Size = new System.Drawing.Size(25, 10);
                    tb[i, j].Location = new System.Drawing.Point(i * 25, j * 20);
                    tb[i, j].Text = i.ToString() + "," + j.ToString();
                    Controls.Add(tb[i, j]);
                }
            } 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int columnas = Int32.Parse(lacantidad);

          
            for (int i = 1; i <= columnas; i++)
            {
                TextBox txt = new TextBox();
                txt = new TextBox();
                txt.Height = 15;
                txt.Width = 100;
                txt.Location = new System.Drawing.Point(25, i* 25 ); 
                txt.Name = "Textbox" + i;
                txt.Text = "Textbox" + i;
                Controls.Add(txt);
                panel1.Controls.Add(txt);
            
            }
        }
    }
}
