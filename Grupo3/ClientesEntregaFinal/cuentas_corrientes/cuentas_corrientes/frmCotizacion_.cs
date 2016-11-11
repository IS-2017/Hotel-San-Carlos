using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cuentas_corrientes
{
    public partial class frmCotizacion_ : Form
    {
        public frmCotizacion_(string id, string nombre, string apellido, string nit, string telefono, string direccion, string fecha, string estado)
        {
            InitializeComponent();
            textBox1.Text = nombre;
            textBox2.Text = apellido;
            textBox5.Text = nit;
            textBox3.Text = direccion;
            //textBox4.Text = fecha;
            txt_telefono.Text = telefono;
            datep_fecha.Text = fecha;
            comboBox1.Text = estado;
            textBox8.Text = id;
            int id2;
            id2 = Convert.ToInt32(textBox8.Text.Trim());
            OdbcConnection cn = seguridad.Conexion.ObtenerConexionODBC();
            DataTable dt = new DataTable();
            String query = "select bien.id_bien_pk, descripcion, precio.precio, cantidad_detallecot from detalle_cotizacion, precio, bien where id_cotizacion_pk ='" + id2 + "'and detalle_cotizacion.id_precio = precio.id_precio and precio.id_bien_pk = bien.id_bien_pk and bien.id_categoria_pk = 'PT' ";
            OdbcCommand cmd = new OdbcCommand(query, cn);
            OdbcDataAdapter da = new OdbcDataAdapter(cmd);

            da.Fill(dt);
            DataRow filas; 
            dataGridView1.DataSource = dt;
        }
        public int cantidad_detallecot;
        public int id_precio;
        public int retorno2 = 0;
        public bien bienseleccionado { get; set; }
        public int cont;
        void ayudar()
        {
            string ruta = "Manual_Cotizacion.pdf";
            ProcessStartInfo startinfo = new ProcessStartInfo();
            startinfo.FileName = "AcroRd32.exe";
            startinfo.Arguments = ruta;
            Process.Start(startinfo);
        }
        private void frmCotizacion__Load(object sender, EventArgs e)
        {

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta Seguro que desea eliminar la cotizacion seleccionada", "Estas Seguro??", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

            {
                int resultado = 0;
                cls_cotizaciondal.Eliminar(Convert.ToInt32(textBox8.Text.Trim()));
                resultado++;
                if (resultado > 0)
                {
                    MessageBox.Show("Cotizacion Eliminada Correctamente!", "Cotizacion Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    //textBox4.Clear();
                    textBox5.Clear();
                    textBox6.Clear();
                    textBox7.Clear();
                    textBox8.Clear();
                    comboBox1.ResetText();
                    dataGridView1.ClearSelection();
                }
            }
            MessageBox.Show("Cotizacion Eliminada Exitosamente");
            this.Close();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {

        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            string snombre = textBox1.Text.Trim();
            string sapellido = textBox2.Text.Trim();
            string snit = textBox5.Text.Trim();
            string sdireccion = textBox3.Text.Trim();
            string sfecha = datep_fecha.Text.Trim();
            string sestado = comboBox1.Text.Trim();
            string sid = textBox8.Text.Trim();
            string stelefono = txt_telefono.Text.Trim();

            int retorno = 0;
            OdbcConnection conexion = seguridad.Conexion.ObtenerConexionODBC();

            OdbcCommand comando = new OdbcCommand(string.Format("Update cotizacion set nombre_cte ='{0}', apellido_cte ='{1}', nit_cte ='{2}', telefono_cte ='{3}', direccion_cte ='{4}', fecha_cot='{5}', estado_cot='{6}' where id_cotizacion = {7}",
                snombre, sapellido, snit, stelefono, sdireccion, sfecha, sestado, sid), conexion);

            retorno = comando.ExecuteNonQuery();
            conexion.Close();
            retorno++;
            if (retorno > 0)
            {
                int filas = dataGridView1.Rows.Count;
                for (int f = 0; f < filas - 1; f++)
                {

                    
                    int id_bien_pk;
                    
                    cantidad_detallecot = Convert.ToInt16(dataGridView1.Rows[f].Cells[3].Value);
                    id_bien_pk = Convert.ToInt16(dataGridView1.Rows[f].Cells[0].Value);

                    OdbcConnection conectar4 = seguridad.Conexion.ObtenerConexionODBC();
                    detalle_cot imp4 = new detalle_cot();
                    OdbcCommand _comando4 = new OdbcCommand(string.Format("select id_precio from precio where id_bien_pk = " + id_bien_pk + " "), conectar4);
                    OdbcDataReader _reader4 = _comando4.ExecuteReader();
                    while (_reader4.Read())
                    {
                        imp4.id_precio = _reader4.GetInt16(0);
                    }
                    conectar4.Close();
                    id_precio = imp4.id_precio;
                    retorno++;
                    retorno2++;
                    if (retorno > 0)
                    {
                        int iretorno = 0;
                        int id_cotizacion_pk = Convert.ToInt16(textBox8.Text.Trim());
                        /*OdbcCommand cmd = new OdbcCommand(string.Format("insert into detalle_cotizacion (cantidad_detallecot, id_cotizacion_pk, id_precio  )values ('{0}','{1}','{2}')",
                          fact.cantida_detallecot, fact.id_cotizacion_pk, fact.id_precio), Conexion.ObtenerConexionODBC());*/
                        OdbcConnection con = seguridad.Conexion.ObtenerConexionODBC();
                        OdbcCommand cmd = new OdbcCommand(string.Format("Update detalle_cotizacion set cantidad_detallecot ='{0}' where id_cotizacion_pk = {1} and id_precio= '{2}' ",cantidad_detallecot, id_cotizacion_pk, id_precio), con);
                        iretorno = cmd.ExecuteNonQuery();// Retorna un 1 si se ejecuta la inserción y 0 es error.
                        iretorno++;
                        if (iretorno > 0)
                        {
                            MessageBox.Show("Detalle Actualizado Correctamente");
                        }
                        //MessageBox.Show(Convert.ToString("cantidad_detallecot"));
                        con.Close();
                        /*textBox1.Clear();
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox4.Clear();
                        textBox5.Clear();
                        textBox6.Clear();
                        textBox7.Clear();*/
                        //MessageBox.Show("Modificacion Realizada Con Exito");
                    }
                }
                
            }
            MessageBox.Show("Cotizacion Actualizada Exitosamente");
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmBuscarProducto frm = new frmBuscarProducto();
            frm.ShowDialog();


            if (frm.bienseleccionado != null)
            {

                //frm.ShowDialog();
                dataGridView1.Rows.Add(1);
                if (dataGridView1.Rows.Count == 0)
                {
                    //frm.ShowDialog();
                    bienseleccionado = frm.bienseleccionado;
                    dataGridView1.Rows[cont].Cells[1].Value = frm.bienseleccionado.descripcion;
                    dataGridView1.Rows[cont].Cells[0].Value = frm.bienseleccionado.id_bien_pk;
                    dataGridView1.Rows[cont].Cells[2].Value = frm.bienseleccionado.precio;
                    dataGridView1.Rows[cont].Cells[3].Value = frm.bienseleccionado.cantidad;
                    cont++;
                }
                else
                {
                    if (dataGridView1.Rows.Count > 1)
                    {
                        //frm.ShowDialog();
                        bienseleccionado = frm.bienseleccionado;
                        dataGridView1.Rows[cont].Cells[1].Value = frm.bienseleccionado.descripcion;
                        dataGridView1.Rows[cont].Cells[0].Value = frm.bienseleccionado.id_bien_pk;
                        dataGridView1.Rows[cont].Cells[2].Value = frm.bienseleccionado.precio;
                        dataGridView1.Rows[cont].Cells[3].Value = frm.bienseleccionado.cantidad;
                        cont++;
                    }
                }

                //dataGridView1.Rows[3].Cells[0].Value = frm.bienseleccionado.cantidad;
                //MessageBox.Show(Convert.ToString(cont));
                //cont = cont + 1;
                //int filas = dataGridView1.RowCount;
                //decimal sub = 0;
                //int sub2 = 0;
                //int sub3 = 0;
                /*for (int f = 0; f < filas; f++)
                {
                    sub += Convert.ToDecimal(dataGridView1.Rows[f].Cells[2].Value);
                    //sub2 += Convert.ToInt32(resultado);
                    //sub3 += Convert.ToUInt32(sub) * sub2;
                    //MessageBox.Show(Convert.ToString(sub2));
                    //sub3 = 
                }

                //Convert.ToInt32(sub2);
                int s = Convert.ToInt32(sub);
                //int s1 = Convert.ToInt32(sub2);
                //int resultado = s * s1;
                textBox6.Text = Convert.ToString(resultado);
                textBox7.Text = Convert.ToString(resultado);*/

            }


        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox5.Enabled = true;
            datep_fecha.Enabled = true;
            textBox6.Enabled = true;
            textBox7.Enabled = true;
            txt_telefono.Enabled = true;
            comboBox1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ayudar();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox5.Enabled = false;
            datep_fecha.Enabled = false;
            textBox6.Enabled = false;
            textBox7.Enabled = false;
            txt_telefono.Enabled = false;
            comboBox1.Enabled = false;
            dataGridView1.DataSource = string.Empty;
        }
    }
}
