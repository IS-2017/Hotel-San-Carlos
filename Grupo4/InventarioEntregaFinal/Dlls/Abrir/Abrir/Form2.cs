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
using MySql.Data.MySqlClient;
using seguridad;
using System.Data.Odbc;

namespace Abrir
{
    public partial class Form2 : Form
    {
       //Leer l = new Leer();
       //public string ARCHIVO ;

        public Form2()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Datos d = new Datos();
                d.Show();
                this.Hide();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       
        private void Form2_Load(object sender, EventArgs e)
        {
            Manejocs mm = new Manejocs();
            DataTable dt = mm.cargar("select * from reporteador");
            dgv_crystal.DataSource = dt;
            dgv_crystal.Columns[0].HeaderText = "ID";
            dgv_crystal.Columns[1].HeaderText = "Nombre";
            dgv_crystal.Columns[2].HeaderText = "Ubicacion";
        }

        private void btn_ver_Click(object sender, EventArgs e)
        {
            try
            {
                Visualizar vz = new Visualizar();
                string ruta = Convert.ToString(dgv_crystal.CurrentRow.Cells[2].Value);
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

                string ruta = Convert.ToString(dgv_crystal.CurrentRow.Cells[2].Value);

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

                string ruta = Convert.ToString(dgv_crystal.CurrentRow.Cells[2].Value);

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

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string id = Convert.ToString(dgv_crystal.CurrentRow.Cells[0].Value);
                
                DialogResult resultado = MessageBox.Show("¿Seguro que desea eliminar  el proyecto?", "Aceptar", MessageBoxButtons.OKCancel);
                if (resultado == DialogResult.OK)
                {
                    String cuery = "delete from reporteador where id_reporteador= '" + id + "'";

                    OdbcCommand comando = new OdbcCommand(cuery, seguridad.Conexion.ObtenerConexionODBC());

                    comando.ExecuteNonQuery();

                    DataTable dtd = new DataTable();
                    string queryd = "Select * from reporteador";
                    OdbcCommand cmdd = new OdbcCommand(queryd, seguridad.Conexion.ObtenerConexionODBC());
                    OdbcDataAdapter adapd = new OdbcDataAdapter(cmdd);
                    adapd.Fill(dtd);
                    dgv_crystal.DataSource = dtd;

                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            modificar m = new modificar();
            m.txt_id.Text = Convert.ToString(dgv_crystal.CurrentRow.Cells[0].Value);
            m.txt_nombre.Text = Convert.ToString(dgv_crystal.CurrentRow.Cells[1].Value);
            m.txt_ubicacion.Text = Convert.ToString(dgv_crystal.CurrentRow.Cells[2].Value);
            m.Show();
        }

        private void btn_refrescar_Click(object sender, EventArgs e)
        {
            try
            {
                Manejocs mm = new Manejocs();
                DataTable dt = mm.cargar("Select * from reporteador");
                dgv_crystal.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
