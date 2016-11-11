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
            DataTable dt = ds.Load_detalle(" select encabezado_muestreo.id_muestreo_pk, fecha, responsable, descripcion, existencia, existencia_auditada, id_bien_pk, id_bodega_pk, id_categoria_pk from encabezado_muestreo inner join detalle_muestreo on encabezado_muestreo.id_muestreo_pk = detalle_muestreo.id_muestreo_pk  where encabezado_muestreo.id_muestreo_pk = '" + txt_ident.Text + "'");
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

            //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
            seguridad.bitacora ju = new seguridad.bitacora();

            ju.Insertar("Se ha hecho el registro de: " + txt_ident.Text + "," + txt_descripcion.Text + "," + textBox1.Text + "," + cbo_bien.SelectedValue.ToString() + "," + cbo_categoria.SelectedValue.ToString() + "," + txt_existencias.Text, " Detalle_ Muestreo ");


            textBox1.Visible = true;
            if (textBox1.Text == "e")
            {
                textBox1.Text = "0";

                SistemaInventarioDatos ds = new SistemaInventarioDatos();


                int y = ds.detalle_muestreo("insert into detalle_muestreo (id_muestreo_pk, descripcion, existencia, id_bien_pk , id_bodega_pk, id_categoria_pk, existencia_auditada) values ('" + txt_ident.Text.Trim() + "','" + txt_descripcion.Text.Trim() + "', '" + textBox1.Text + "','" + cbo_bien.SelectedValue.ToString() + "','" + cbo_bodega.SelectedValue.ToString() + "','" + cbo_categoria.SelectedValue.ToString() + "','" + txt_existencias.Text.Trim() + "')");

                if (y == 1)
                {
                    DataTable dt = ds.Load_detalle(" select encabezado_muestreo.id_muestreo_pk, fecha, responsable, descripcion, existencia, existencia_auditada, id_bien_pk, id_bodega_pk, id_categoria_pk from encabezado_muestreo inner join detalle_muestreo on encabezado_muestreo.id_muestreo_pk = detalle_muestreo.id_muestreo_pk where encabezado_muestreo.id_muestreo_pk = '" + txt_ident.Text + "'");
                    dvg_detalle.DataSource = dt;
                    txt_descripcion.Text = "";

                    txt_existencias.Text = "";



                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            else
            {
                SistemaInventarioDatos si = new SistemaInventarioDatos();
                int r = si.detalle_muestreo("insert into detalle_muestreo (id_muestreo_pk, descripcion, existencia, id_bien_pk , id_bodega_pk, id_categoria_pk, existencia_auditada) values ('" + txt_ident.Text.Trim() + "','" + txt_descripcion.Text.Trim() + "', '" + textBox1.Text + "','" + cbo_bien.SelectedValue.ToString() + "','" + cbo_bodega.SelectedValue.ToString() + "','" + cbo_categoria.SelectedValue.ToString() + "','" + txt_existencias.Text.Trim() + "')");


                if (r == 1)
                {

                    SistemaInventarioDatos ds = new SistemaInventarioDatos();
                    DataTable dt = ds.Load_detalle(" select * from detalle_muestreo where id_muestreo_pk = '" + txt_ident.Text + "'");
                    dvg_detalle.DataSource = dt;
                    si.ActualizarBogedaproducto(textBox1.Text, txt_existencias.Text, cbo_bien.SelectedValue.ToString(), cbo_bodega.SelectedValue.ToString(), cbo_categoria.SelectedValue.ToString());


                    Detalle_bodega_producto dm = new Detalle_bodega_producto();
                    dm.id_bien = cbo_bien.SelectedValue.ToString();
                    dm.id_bodega = cbo_bodega.SelectedValue.ToString();
                    dm.id_categoria = cbo_categoria.SelectedValue.ToString();

                    dm.Show();

                }


                else
                {
                    MessageBox.Show("no se pudo ingresar el detalle de muestreo! ");
                }
            }
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            SistemaInventarioDatos ds = new SistemaInventarioDatos();
            DataTable dt = ds.Load_detalle("select encabezado_muestreo.id_muestreo_pk, fecha, responsable, descripcion, existencia, existencia_auditada, id_bien_pk, id_bodega_pk, id_categoria_pk from encabezado_muestreo inner join detalle_muestreo on encabezado_muestreo.id_muestreo_pk = detalle_muestreo.id_muestreo_pk  where encabezado_muestreo.id_muestreo_pk = '" + txt_ident.Text + "'");
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

        private void dvg_detalle_DoubleClick(object sender, EventArgs e)
        {
            Detalle_bodega_producto dp = new Detalle_bodega_producto();
            dp.Show();

        }
    }
}
