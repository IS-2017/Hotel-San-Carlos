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
    public partial class FormMuestreo : Form
    {
        public FormMuestreo()
        {
            InitializeComponent();
        }

        private void FormMuestreo_Load(object sender, EventArgs e)
        {
            SistemaInventarioDatos si = new SistemaInventarioDatos();
            DataTable dt = si.Obtener_encabezado_muestreo();
            dgv_muestreo.DataSource = dt;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            string data_picker_time = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
            if (!String.IsNullOrEmpty(txt_responsable.Text.Trim()))
            {

                SistemaInventarioDatos sd = new SistemaInventarioDatos();
                int x = sd.Agregar_encabezado_muestreo(data_picker_time, txt_responsable.Text.Trim());
                if (x == 1)
                {
                    MessageBox.Show(" encabezado de muestreo registrado exitosamente! ");
                    dgv_muestreo.DataSource = sd.Obtener_encabezado_muestreo();
                }
                else
                {
                    MessageBox.Show("no se pudo ingresar el encabezado de muestreo! ");
                }
            }


            else
            {
                MessageBox.Show("debe llenar todos los campos");
            }
            //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        }

        private void dgv_muestreo_DoubleClick(object sender, EventArgs e)
        {
            

                try
                {

                    Detalle_muestreo mte = new Detalle_muestreo();

                    string id_muestreo = Convert.ToString(dgv_muestreo.CurrentRow.Cells[0].Value);
                    string fecha = Convert.ToString(dgv_muestreo.CurrentRow.Cells[1].Value);
                    string responsable = Convert.ToString(dgv_muestreo.CurrentRow.Cells[2].Value);

                    mte.txt_ident.Text = id_muestreo;
                    mte.textBox3.Text = fecha;
                    mte.textBox4.Text = responsable;
                    //txt_id_empresa.Text = id_empresa;


                    mte.Show();
                }
                catch
                {
                    MessageBox.Show("No existen registros que modificar");
                }
            
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            SistemaInventarioDatos si = new SistemaInventarioDatos();
            string id_encabezado = Convert.ToString(dgv_muestreo.CurrentRow.Cells[0].Value);
            si.Eliminar("update encabezado_muestreo set estado = 'INACTIVO' where id_muestreo_pk = '" + id_encabezado + "'");
            DataTable dt = si.Load_detalle(" select * from encabezado_muestreo where estado = 'ACTIVO'");
            dgv_muestreo.DataSource = dt;
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            SistemaInventarioDatos ds = new SistemaInventarioDatos();
            DataTable dt = ds.Load_detalle(" select * from encabezado_muestreo where estado = 'ACTIVO'");
            dgv_muestreo.DataSource = dt;
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                Modificar_encabezado_muestreo me = new Modificar_encabezado_muestreo();
                me.txt_id_muestreo.Text = Convert.ToString(dgv_muestreo.CurrentRow.Cells[0].Value);

                me.txt_responsable.Text = Convert.ToString(dgv_muestreo.CurrentRow.Cells[2].Value);

                OdbcConnection con = Conexion.ConexionPermisos();
                me.Show();

            }
            catch
            {
                MessageBox.Show("No existen registros que modificar");
            }
        }
    }
}
