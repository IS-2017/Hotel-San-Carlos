using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Abrir
{
    public partial class Form2 : Form
    {
       Leer l = new Leer();
       public string ARCHIVO ;

        public Form2()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Datos d = new Datos();
                d.ruta = ARCHIVO;
                d.Show();
                this.Hide();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void cargarArchivo()
        {
            try
            {
                Datos d = new Datos();
                d.Show();
                //this.openFileDialog1.ShowDialog();
                //if(!string.IsNullOrEmpty(this.openFileDialog1.FileName))
                //{
                    //ARCHIVO = this.openFileDialog1.FileName;
                  //  l.lecturaArchivo(dvg_crystal, ',', ARCHIVO);
                //}
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            l.lecturaArchivo(dgv_crystal, ',', ARCHIVO);
        }

        private void btn_ver_Click(object sender, EventArgs e)
        {
            try
            {
                Visualizar vz = new Visualizar();
                string ruta = Convert.ToString(dgv_crystal.CurrentRow.Cells[1].Value);
                vz.Menu_General(ruta);
                vz.Show();

        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                      
             }
        }

        private void btn_impresora_Click(object sender, EventArgs e)
        {
            try
            {

                string ruta = Convert.ToString(dgv_crystal.CurrentRow.Cells[1].Value);

                PrintDocument print = new PrintDocument();
                ReportDocument rDocument = new ReportDocument();

                rDocument.Load(ruta);

                printPreviewDialog1.Document = print;
                printPreviewDialog1.ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {

                string ruta = Convert.ToString(dgv_crystal.CurrentRow.Cells[1].Value);

                PrintDocument print = new PrintDocument();
                ReportDocument rDocument = new ReportDocument();

                rDocument.Load(ruta);

                printPreviewDialog1.Document = print;
                printPreviewDialog1.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
