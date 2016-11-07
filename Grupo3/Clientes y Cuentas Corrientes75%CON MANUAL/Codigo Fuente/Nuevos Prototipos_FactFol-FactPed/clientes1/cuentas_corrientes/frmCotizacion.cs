using MySql.Data.MySqlClient;
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

namespace cuentas_corrientes
{
    public partial class frmCotizacion : Form
    {
        public frmCotizacion()
        {
            InitializeComponent();
        }
        void ayudar()
        {
            string ruta = @"C:\Users\ALEJANDRO\Documents\manual_proveedor.pdf";
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
                    //dataGridView1.Rows.Add();
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
                        //dataGridView1.Rows.Add();
                        cont++;
                    }
                }

                //dataGridView1.Rows[3].Cells[0].Value = frm.bienseleccionado.cantidad;
                //MessageBox.Show(Convert.ToString(cont));
                //cont = cont + 1;

            }
            int filas= dataGridView1.RowCount;
            decimal sub = 0;
            for (int f = 0; f < filas; f++)
            {
                sub += Convert.ToDecimal(dataGridView1.Rows[f].Cells[2].Value);

            }


            textBox6.Text = Convert.ToString(sub);
            textBox7.Text = Convert.ToString(sub);                    

}

        private void button6_Click(object sender, EventArgs e)
        {
            cls_cotizacion cotizacion = new cls_cotizacion();
            cotizacion.nombre_cte = textBox1.Text.Trim();
            cotizacion.direccion_cte = textBox3.Text.Trim();
            cotizacion.apellido_cte = textBox2.Text.Trim();
            cotizacion.nit_cte = textBox5.Text.Trim();
            cotizacion.fecha_cot = textBox4.Text.Trim();
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
            textBox4.Clear();
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
            cotizacion.fecha_cot = textBox4.Text.Trim();
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
            textBox4.Clear();
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
            textBox4.Clear();
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
    }
    }

