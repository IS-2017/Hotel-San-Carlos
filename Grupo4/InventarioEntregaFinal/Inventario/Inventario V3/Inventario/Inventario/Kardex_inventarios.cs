using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using seguridad;


namespace Inventario
{
    public partial class Kardex_inventarios : Form
    {
        public Kardex_inventarios()
        {
            InitializeComponent();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string fecha_inicio = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string fecha_fin = dateTimePicker2.Value.ToString("yyyy-MM-dd");
            SistemaInventarioDatos si = new SistemaInventarioDatos();
            DataTable dt2 = si.Obtener_Ultimo_saldo(fecha_inicio);
            if (dt2.Rows.Count == 0)
            {
                textBox1.Text = "0";
            }

            else
            {
                var value = dt2.Rows[dt2.Rows.Count - 1]["Saldo"];
                textBox1.Text = Convert.ToString(value);

            }
            

            DataTable dt = si.Obtener_consulta_Kardex(fecha_inicio, fecha_fin, textBox1.Text);
            dataGridView1.DataSource = dt;

            
          







        }

        private void Kardex_inventarios_Load(object sender, EventArgs e)
        {


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Abrir.Form1 hola = new Abrir.Form1();
            //hola.Crystal = @"C:\Users\Chrix\Desktop\cosas\03 - 11 -16\reporte_existencias\reporte_existencias\reporte_movimientos.rpt";
            //hola.Show();
            try
            {
                FormReporteKardex f = new FormReporteKardex();
                f.dataGridView1 = dataGridView1;
                f.Show();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
