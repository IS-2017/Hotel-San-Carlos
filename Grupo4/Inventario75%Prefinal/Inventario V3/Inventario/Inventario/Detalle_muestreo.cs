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
    public partial class Detalle_muestreo : Form
    {
        public Detalle_muestreo()
        {
            InitializeComponent();
        }
        public string congelar;
        private void Detalle_muestreo_Load(object sender, EventArgs e)
        {
            SistemaInventarioDatos ds = new SistemaInventarioDatos();
            DataTable dt = ds.Load_detalle(" select * from detalle_muestreo where id_muestreo_pk = '" + txt_ident.Text + "'");
            dvg_detalle.DataSource = dt;

            cbo_bien.DataSource = ds.ObtenerBien2();
            cbo_bien.ValueMember = "id_bien_pk";
            cbo_bien.DisplayMember = "descripcion";

            cbo_bodega.DataSource = ds.ObtenerBodega();
            cbo_bodega.ValueMember = "id_bodega_pk";
            cbo_bodega.DisplayMember = "nombre_bodega";

            cbo_categoria.DataSource = ds.ObtenerCategorias();
            cbo_categoria.ValueMember = "id_categoria_pk";
            cbo_categoria.DisplayMember = "tipo_categoria";
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
            if (!String.IsNullOrEmpty(txt_descripcion.Text.Trim() + txt_existencias.Text))
            {

                SistemaInventarioDatos sd = new SistemaInventarioDatos();
                int x = sd.Agregar_detalle_muestreo(txt_ident.Text, txt_descripcion.Text, textBox1.Text, cbo_bien.SelectedValue.ToString(), cbo_bodega.SelectedValue.ToString(), cbo_categoria.SelectedValue.ToString(), txt_existencias.Text);
                if (textBox1.Text == "e")
                {
                    //   MessageBox.Show("");
                    SistemaInventarioDatos ds = new SistemaInventarioDatos();

                    //ds.Insertarenproductobodega(cbo_bien.SelectedValue.ToString(), cbo_bodega.SelectedValue.ToString(), cbo_categoria.SelectedValue.ToString(), "0", "0", txt_existencias.Text);
                    DataTable dt = ds.Load_detalle(" select * from detalle_muestreo where id_muestreo_pk = '" + txt_ident.Text + "'");
                    int y = sd.Agregar_detalle_muestreo(txt_ident.Text, txt_descripcion.Text, textBox1.Text, cbo_bien.SelectedValue.ToString(), cbo_bodega.SelectedValue.ToString(), cbo_categoria.SelectedValue.ToString(), txt_existencias.Text);
                    dvg_detalle.DataSource = dt;
                    txt_descripcion.Text = "";

                    txt_existencias.Text = "";
                    Detalle_bodega_producto dm = new Detalle_bodega_producto();
                    dm.id_bien = cbo_bien.SelectedValue.ToString();
                    dm.id_bodega = cbo_bodega.SelectedValue.ToString();
                    dm.id_categoria = cbo_categoria.SelectedValue.ToString();

                    //dm.Show();


                }

                else
                {

                    sd.ActualizarBogedaproducto(textBox1.Text, txt_existencias.Text, cbo_bien.SelectedValue.ToString(), cbo_bodega.SelectedValue.ToString(), cbo_categoria.SelectedValue.ToString());

                    Detalle_bodega_producto dm = new Detalle_bodega_producto();
                    dm.id_bien = cbo_bien.SelectedValue.ToString();
                    dm.id_bodega = cbo_bodega.SelectedValue.ToString();
                    dm.id_categoria = cbo_categoria.SelectedValue.ToString();

                    dm.Show();
                    if (x == 1)
                    {

                        SistemaInventarioDatos ds = new SistemaInventarioDatos();
                        DataTable dt = ds.Load_detalle(" select * from detalle_muestreo where id_muestreo_pk = '" + txt_ident.Text + "'");
                        dvg_detalle.DataSource = dt;


                    }


                    else
                    {
                        MessageBox.Show("no se pudo ingresar el detalle de muestreo! ");
                    }
                }
            }



            else
            {
                MessageBox.Show("debe llenar todos los campos");
            }
            //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            SistemaInventarioDatos ds = new SistemaInventarioDatos();
            DataTable dt = ds.Load_detalle(" select * from detalle_muestreo where id_muestreo_pk = '" + txt_ident.Text + "'");
            dvg_detalle.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                SistemaInventarioDatos si = new SistemaInventarioDatos();
                DataTable dt = si.CongelarExistencias("Select existencia from producto_bodega where id_bien_pk = '" + cbo_bien.SelectedValue.ToString() + "' and id_bodega_pk = '" + cbo_bodega.SelectedValue.ToString() + "' and id_categoria_pk = '" + cbo_categoria.SelectedValue.ToString() + "'");
                dataGridView1.DataSource = dt;
                string hola = dt.Rows[0][0].ToString();
                // string hola = Convert.ToString(dt);
                MessageBox.Show(" Existencia Congelada de : " + hola + "");
                textBox1.Text = hola;
                string prueba = dataGridView1[0, 0].Value.ToString();

            }
            catch
            {
                MessageBox.Show(" No Hay existencias de ese producto en BD");
                textBox1.Text = "e";
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
