//using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FuncionesNavegador;
using dllconsultas;
using System.Diagnostics;
using seguridad;
using System.Data.Odbc;
//using Abrir;


namespace cuentas_corrientes
{
    public partial class frmCotizacion : Form
    {
        /*public frmCotizacion(string id, string nombre, string apellido, string nit, string direccion,string fecha, string estado)
        {
            InitializeComponent();
            textBox1.Text = nombre;
            textBox2.Text = apellido;
            textBox5.Text = nit;
            textBox3.Text = direccion;
            textBox4.Text = fecha;
            comboBox1.Text = estado;
            textBox8.Text = id;
        }*/

        //public string resultado; 
       
        
        public frmCotizacion()
        {
            InitializeComponent();
            /*textBox1.Text = nombre;
            textBox2.Text = apellido;
            textBox5.Text = nit;
            textBox3.Text = direccion;
            textBox4.Text = fecha;
            comboBox1.Text = estado;
            textBox8.Text = id;*/
            /*int id2;
            id2 = Convert.ToInt32(textBox8.Text.Trim());
            OdbcConnection cn = seguridad.Conexion.ObtenerConexionODBC();
            DataTable dt = new DataTable();
            String query = "select bien.id_bien_pk, descripcion, precio.precio, cantidad_detallecot from detalle_cotizacion, precio, bien where id_cotizacion_pk ='" + id2 + "'and detalle_cotizacion.id_precio = precio.id_precio and precio.id_bien_pk = bien.id_bien_pk ";
            OdbcCommand cmd = new OdbcCommand(query, cn);
            OdbcDataAdapter da = new OdbcDataAdapter(cmd);

            da.Fill(dt);
            dataGridView1.(dt);
            //dataGridView1.Rows[cont].Cells[].Value = dt;*/


            //MessageBox.Show(Convert.ToString(textBox8));*/
        }

        void ayudar()
        {
            string ruta = "Manual_Cotizacion.pdf";
            ProcessStartInfo startinfo = new ProcessStartInfo();
            startinfo.FileName = "AcroRd32.exe";
            startinfo.Arguments = ruta;
            Process.Start(startinfo);
        }

        public bien bienseleccioando { get; set; }
        public encabezado encabezadoseleccionado { get; set; }
        int cont = 0;
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
                    bienseleccioando = frm.bienseleccionado;
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
                        bienseleccioando = frm.bienseleccionado;
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
                int filas = dataGridView1.RowCount;
                decimal sub = 0;
                //int sub2 = 0;
                //int sub3 = 0;
                for (int f = 0; f < filas; f++)
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
                textBox6.Text = Convert.ToString(sub);
                textBox7.Text = Convert.ToString(sub);

            }
            

        }

        private void button6_Click(object sender, EventArgs e)
        {
            cls_cotizacion cotizacion = new cls_cotizacion();
            cotizacion.nombre_cte = textBox1.Text.Trim();
            cotizacion.direccion_cte = textBox3.Text.Trim();
            cotizacion.apellido_cte = textBox2.Text.Trim();
            cotizacion.nit_cte = textBox5.Text.Trim();
            //cotizacion.fecha_cot = textBox4.Text.Trim();
            cotizacion.estado_cot = comboBox1.Text.Trim();

            int resultado = cls_cotizaciondal.Agregar(cotizacion);
            if (resultado > 0)
             {
                 MessageBox.Show("Cotizacion Guardada Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
             else
             {
                 MessageBox.Show("No se pudo guardar la Cotizacion", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
             }
            if (resultado > 0)
            {
                MessageBox.Show("Encabezado de factura guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Insertando en detalle de factura 
                int filas = dataGridView1.RowCount;



                OdbcConnection conectar3 = seguridad.Conexion.ObtenerConexionODBC();
                detalle_cot imp3 = new detalle_cot();
                OdbcCommand _comando3 = new OdbcCommand(String.Format(
                     "SELECT MAX(id_cotizacion) from cotizacion "), conectar3);
                OdbcDataReader _reader3 = _comando3.ExecuteReader();
                while (_reader3.Read())
                {

                    imp3.id_cotizacion_pk = _reader3.GetInt16(0); //Id encabezado
                }
                conectar3.Close();
                
                
                
                for (int f = 0; f < filas-1; f++)
                {
                    detalle_cot defact = new detalle_cot();
                    defact.id_cotizacion_pk = imp3.id_cotizacion_pk;          
                    //defact.cod_emp = fact.cod_emp;
                    //defact.serie = fact.serie;
                    defact.cantidad_detallecot = Convert.ToInt16(dataGridView1.Rows[f].Cells[3].Value);
                    defact.id_bien_pk = Convert.ToInt16(dataGridView1.Rows[f].Cells[0].Value);

                    OdbcConnection conectar4 = seguridad.Conexion.ObtenerConexionODBC();
                    detalle_cot imp4 = new detalle_cot();
                    OdbcCommand _comando4 = new OdbcCommand(string.Format("select id_precio from precio where id_bien_pk = "+ defact.id_bien_pk + " "), conectar4);
                    OdbcDataReader _reader4 = _comando4.ExecuteReader();
                    while (_reader4.Read())
                    {
                        imp4.id_precio = _reader4.GetInt16(0);
                    }
                    conectar4.Close();
                    defact.id_precio = imp4.id_precio;
                    //defact = Convert.ToInt16(dataGridView1.Rows[f].Cells[3].Value);
                    //MessageBox.Show(Convert.ToString(defact.));
                    //defact.descripcion = Convert.ToString(dgv_detallefact.Rows[f].Cells[2].Value);
                    //defact.prec = Convert.ToInt16(dgv_detallefact.Rows[f].Cells[3].Value);
                    //defact.subtotal = Convert.ToInt16(dgv_detallefact.Rows[f].Cells[4].Value);

                    int iresultado1 = cls_cotizaciondal.AgregarDetFact(defact);
                    if (iresultado1 > 0)
                    {
                        MessageBox.Show("Detalle insertado correctamente");

                    }
                    else
                    {
                        MessageBox.Show("No se inserto detalle");
                    }
                }


            }
            else
            {
                MessageBox.Show("No se pudo guardar el encabezado de factura", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }     
            /*catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }*/


            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            //textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            comboBox1.ResetText();
            textBox7.Clear();

        } 

        private void button2_Click(object sender, EventArgs e)
        {
            frmBuscarPromociones frm = new frmBuscarPromociones();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmBuscarPaquete frm = new frmBuscarPaquete();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            /*dllconsultas.frm_almacenadas busc = new frm_almacenadas();
            busc.Show();*/
        }

        private void frmCotizacion_Load(object sender, EventArgs e)
        {

            //if (textBox8.Text != null)
            //{

                
               /* OdbcConnection cn = seguridad.Conexion.ObtenerConexionODBC();
                DataTable dt = new DataTable();
                String query = "select bien.id_bien_pk, descripcion, precio.precio, cantidad_detallecot from detalle_cotizacion, precio, bien where id_cotizacion_pk ='" + textBox8.Text + "'and detalle_cotizacion.id_precio = precio.id_precio and precio.id_bien_pk = bien.id_bien_pk ";
                OdbcCommand cmd = new OdbcCommand(query, cn);
                OdbcDataAdapter da = new OdbcDataAdapter(cmd);

                da.Fill(dt);
                dataGridView1.DataSource = dt;*/
                /*dataGridView1.Rows[cont].Cells[1].Value = ;
                dataGridView1.Rows[cont].Cells[0].Value = frm.bienseleccionado.id_bien_pk;
                dataGridView1.Rows[cont].Cells[2].Value = frm.bienseleccionado.precio;*/
            //}

                /*dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = ();

                dataGridView1.DataSource = CargarProductosDT();

                //Tamaño de cada columna
                foreach (DataGridViewColumn columna in dataGridView1.Columns)
                {
                    columna.Width = 118;
                }*/
            
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            cls_cotizacion cotizacion = new cls_cotizacion();
            cotizacion.nombre_cte = textBox1.Text.Trim();
            cotizacion.direccion_cte = textBox3.Text.Trim();
            cotizacion.apellido_cte = textBox2.Text.Trim();
            cotizacion.nit_cte = textBox5.Text.Trim();
            cotizacion.fecha_cot = datap_fecha.Text.Trim();
            cotizacion.estado_cot = comboBox1.Text.Trim();
            cotizacion.telefono1 = txt_telefono.Text.Trim();

            int resultado = cls_cotizaciondal.Agregar(cotizacion);
            if (resultado > 0)
            {
                MessageBox.Show("Cotizacion Guardada Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo guardar la Cotizacion", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (resultado > 0)
            {
                MessageBox.Show("Encabezado de factura guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Insertando en detalle de factura 
                int filas = dataGridView1.RowCount;



                OdbcConnection conectar3 = seguridad.Conexion.ObtenerConexionODBC();
                detalle_cot imp3 = new detalle_cot();
                OdbcCommand _comando3 = new OdbcCommand(String.Format(
                     "SELECT MAX(id_cotizacion) from cotizacion "), conectar3);
                OdbcDataReader _reader3 = _comando3.ExecuteReader();
                while (_reader3.Read())
                {

                    imp3.id_cotizacion_pk = _reader3.GetInt16(0); //Id encabezado
                }
                conectar3.Close();



                for (int f = 0; f < filas - 1; f++)
                {
                    detalle_cot defact = new detalle_cot();
                    defact.id_cotizacion_pk = imp3.id_cotizacion_pk;
                    //defact.cod_emp = fact.cod_emp;
                    //defact.serie = fact.serie;
                    defact.cantidad_detallecot = Convert.ToInt16(dataGridView1.Rows[f].Cells[3].Value);
                    defact.id_bien_pk = Convert.ToInt16(dataGridView1.Rows[f].Cells[0].Value);

                    OdbcConnection conectar4 = seguridad.Conexion.ObtenerConexionODBC();
                    detalle_cot imp4 = new detalle_cot();
                    OdbcCommand _comando4 = new OdbcCommand(string.Format("select id_precio from precio where id_bien_pk = " + defact.id_bien_pk + " "), conectar4);
                    OdbcDataReader _reader4 = _comando4.ExecuteReader();
                    while (_reader4.Read())
                    {
                        imp4.id_precio = _reader4.GetInt16(0);
                    }
                    conectar4.Close();
                    defact.id_precio = imp4.id_precio;
                    //defact = Convert.ToInt16(dataGridView1.Rows[f].Cells[3].Value);
                    //MessageBox.Show(Convert.ToString(defact.));
                    //defact.descripcion = Convert.ToString(dgv_detallefact.Rows[f].Cells[2].Value);
                    //defact.prec = Convert.ToInt16(dgv_detallefact.Rows[f].Cells[3].Value);
                    //defact.subtotal = Convert.ToInt16(dgv_detallefact.Rows[f].Cells[4].Value);

                    int iresultado1 = cls_cotizaciondal.AgregarDetFact(defact);
                    if (iresultado1 > 0)
                    {
                        MessageBox.Show("Detalle insertado correctamente");

                    }
                    else
                    {
                        MessageBox.Show("No se inserto detalle");
                    }
                }


            }
            else
            {
                MessageBox.Show("No se pudo guardar el encabezado de factura", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            /*catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }*/


            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            //textBox4.Clear();
            txt_telefono.Clear();
            textBox5.Clear();
            textBox6.Clear();
            comboBox1.ResetText();
            textBox7.Clear();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            //textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            comboBox1.ResetText();
            textBox7.Clear();
            dataGridView1.ClearSelection();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            ayudar();
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
            /* if (MessageBox.Show("Esta Seguro que desea eliminar la cotizacion seleccionada", "Estas Seguro??", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

             {

                 if (cls_cotizaciondal.Eliminar(Convert.ToInt16(id)) > 0)

                 {

                     MessageBox.Show("Cotizacion Eliminada Correctamente!", "Cotizacion Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                 }

                 else

                 {

                     MessageBox.Show("No se pudo eliminar la Cotizacion", "Cotizacion No Eliminada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                 }

             }

             else
             {

                 MessageBox.Show("Se cancelo la eliminacion", "Eliminacion Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
             }
             /*txt_nombre.Clear();
             txt_direccion.Clear();
             txt_nit.Clear();
             txt_observaciones.Clear();
             txt_razon.Clear();
             usuariodal.obtenerBitacora(usuariodal.varibaleUsuario, "Eliminar", "proveedor");*/
            //int id_cotizacion = Convert.ToInt16(textBox8.Text);
           /* try
            {

                if (MessageBox.Show("Esta Seguro que desea eliminar el proyecto Actual", "Estas Seguro??", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    if (cls_cotizaciondal.Eliminar(cls > 0)
                    {
                        MessageBox.Show("Proyecto Eliminado Correctamente!", "Proyecto Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el proyecto", "Proyecto No Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                    MessageBox.Show("Se cancelo la eliminacion", "Eliminacion Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }*/

            //mostrar();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            /*Abrir.Form1 abrir = new Abrir.Form1();
            abrir.Crystal = @"C:\Users\ALEJANDRO\Desktop\ReportesdePeter\ReportesdePeter\PeterPeter.rpt";
            abrir.Show();*/
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox5.Enabled = true;
            datap_fecha.Enabled = true;
            textBox6.Enabled = true;
            textBox7.Enabled = true;
            txt_telefono.Enabled = true;
            comboBox1.Enabled = true;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox5.Enabled = false;
            datap_fecha.Enabled = false;
            textBox6.Enabled = false;
            textBox7.Enabled = false;
            txt_telefono.Enabled = false;
            comboBox1.Enabled = false;
            dataGridView1.DataSource = string.Empty;
        }
    }
    }
    

