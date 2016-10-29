using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Abrir;

namespace Probar
{
    public partial class Form1 : Form
    {
    //    Abrir.Form2 F = new Abrir.Form2();
      //  Abrir.Form1 F1 = new Abrir.Form1();
        public Form1()
        {
            InitializeComponent();
           
        }

        private void Reporte_Click(object sender, EventArgs e)
        {

            
           // F1.Show();
        }

        private void btn_Reporte_Click(object sender, EventArgs e)
        {
            //Boton Reporteador
            try
            {
                Abrir.Form2 fv = new Abrir.Form2();
                //la Ubicacion del txt ubicadado dentro del rar
                fv.ARCHIVO = @"C:\Users\ccarrera\Desktop\llenarDataGrid.txt";
                fv.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Reporte_Click_1(object sender, EventArgs e)
        {
            try
            {
                Abrir.Form1 fm = new Abrir.Form1();
                
                //Ubicacion del rpt de modulo a probar
                
                fm.Crystal = @"C:\Users\ccarrera\Desktop\Entregar\Prueba\Prueba\CrystalReport1.rpt";
                fm.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
