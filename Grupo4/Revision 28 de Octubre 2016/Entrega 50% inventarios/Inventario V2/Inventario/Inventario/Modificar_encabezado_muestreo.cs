using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario
{
    public partial class Modificar_encabezado_muestreo : Form
    {
        public Modificar_encabezado_muestreo()
        {
            InitializeComponent();
        }

        private void Modificar_encabezado_muestreo_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //   dateTimePicker1.Show();

                //se abre conexion y se modifica la base de datos con los datos nuevos ingresados
                SistemaInventarioDatos si = new SistemaInventarioDatos();

                //   dateTimePicker1.Format = DateTimePickerFormat.Custom;
                //  dateTimePicker1.CustomFormat = "yyyy-MM-dd";

                si.Actualizar("update encabezado_muestreo set fecha ='" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "', responsable = '" + txt_responsable.Text + "' where id_muestreo_pk = '" + txt_id_muestreo.Text + "'");
                txt_responsable.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
