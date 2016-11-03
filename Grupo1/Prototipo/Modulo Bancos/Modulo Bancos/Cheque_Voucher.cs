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
using FuncionesNavegador;
namespace Modulo_Bancos
{
    public partial class Cheque_Voucher : Form
    {
        CapaNegocio fn = new CapaNegocio();
        String Codigo;
        Boolean Editar = false;
        String atributo;
        DataGridView data;
        public Cheque_Voucher()
        {
            InitializeComponent();
        }
    
        public Cheque_Voucher(DataGridView dt)
        {
            this.data = dt;
            InitializeComponent();
        }
        
        private void Cheque_Voucher_Load(object sender, EventArgs e)
        {
            fn.InhabilitarComponentes(gpb_cheque_v);
            fn.InhabilitarComponentes(this);
            dataGridView1.Enabled = false;
            llenardocuemnto();
            dataGridView1.Columns[1].Visible = false;
        }
        int id;
        int id2;
        int id3;
        int cont2 = 1;
        string cadena1;
        decimal cadena2;
        int dato = 0;
        string cambio = "INSERTAR";
        private void llenardocuemnto()
        {

            //se realiza la conexión a la base de datos
            Ayuda.ObtenerConexion();
            //se inicia un DataSet
            DataSet ds = new DataSet();
            //se indica la consulta en sql
            String Query = "select id_documento_pk, no_documento from documento";
            OdbcDataAdapter dad = new OdbcDataAdapter(Query, Ayuda.ObtenerConexion());
            //se indica con quu tabla se llena
            dad.Fill(ds, "documento");
            cbo_doc.DataSource = ds.Tables[0].DefaultView;
            //indicamos el valor de los miembros
            cbo_doc.ValueMember = ("id_documento_pk");
            //se indica el valor a desplegar en el combobox
            cbo_doc.DisplayMember = ("no_documento");
            Ayuda.Desconectar();
        }

        public void documento()
        {

            OdbcCommand Query = new OdbcCommand();
            OdbcConnection Conexion;
            OdbcDataReader consultar;
            //string sql = "dsn=hotelsancarlos;server=localhost;user id=root;database=hotelsancarlos;password=";
            string sql = "dsn=hotelsancarlos;server=localhost;database=hotelsancarlos;uid=root;password=";
            Conexion = new OdbcConnection();
            Conexion.ConnectionString = sql;
            Conexion.Open();
            Query.CommandText = "SELECT id_documento_pk, descripcion,valor_total,id_cuenta_bancaria_pk From documento where no_documento = '" + cbo_doc.Text + "';";
            Query.Connection = Conexion;
            consultar = Query.ExecuteReader();
            while (consultar.Read())
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                id = consultar.GetInt32(0);
                cadena1 = consultar.GetString(1);
                cadena2 = consultar.GetDecimal(2);
                id2 = consultar.GetInt32(3);

                txt_monto.Text = Convert.ToString(cadena2);
                //MessageBox.Show(Convert.ToString(id2));
            }


        }
        public void cuenta()
        {

            int no_c = 0;
            OdbcConnection Conexion2;
            OdbcCommand Query2 = new OdbcCommand();
            OdbcDataReader consultar2;
            //string sql = "dsn=hotelsancarlos;server=localhost;user id=root;database=hotelsancarlos;password=";
            string sql = "dsn=hotelsancarlos;server=localhost;database=hotelsancarlos;uid=root;password=";
            Conexion2 = new OdbcConnection();
            Conexion2.ConnectionString = sql;
            Conexion2.Open();
            Query2.CommandText = "SELECT no_cuenta, id_empresa_pk From cuenta_bancaria where id_cuenta_bancaria_pk = '" + id2 + "';";
            Query2.Connection = Conexion2;
            consultar2 = Query2.ExecuteReader();
            while (consultar2.Read())
            {
                no_c = consultar2.GetInt32(0);
                id3 = consultar2.GetInt32(1);
                txt_cuenta.Text = Convert.ToString(no_c);

            }
        }
        public void empresa()
        {
            string nombre;
            OdbcCommand Query = new OdbcCommand();
            OdbcConnection Conexion;
            OdbcDataReader consultar;
            //string sql = "dsn=hotelsancarlos;server=localhost;user id=root;database=hotelsancarlos;password=";
            string sql = "dsn=hotelsancarlos;server=localhost;database=hotelsancarlos;uid=root;password=";
            Conexion = new OdbcConnection();
            Conexion.ConnectionString = sql;
            Conexion.Open();
            Query.CommandText = "SELECT nombre From empresa where id_empresa_pk = '" + id3 + "';";
            Query.Connection = Conexion;
            consultar = Query.ExecuteReader();

            while (consultar.Read())
            {

                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                cont2 = 1;

                nombre = consultar.GetString(0);
                txt_empresa.Text = nombre;
                // MessageBox.Show(Convert.ToString(id));
            }
            dataGridView1.Rows.Add(1);
        }
       

        private void cbo_doc_SelectedIndexChanged(object sender, EventArgs e)
        {
            documento();
            cuenta();
            empresa();

            dataGridView1.Rows[0].Cells[0].Value = id;
            dataGridView1.Rows[0].Cells[2].Value = cadena1;
            dataGridView1.Rows[0].Cells[4].Value = cadena2;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (dato == 1)
            {
                dataGridView1.Rows.Add(1);
                dataGridView1.Rows[cont2].Cells[1].Value = "X";
                dataGridView1.Rows[cont2].Cells[2].Value = txt_detalle.Text;
                dataGridView1.Rows[cont2].Cells[3].Value = Convert.ToDecimal(txt_cantida.Text);
                dataGridView1.Rows[cont2].Cells[4].Value = Convert.ToDecimal(txt_cantidad_h.Text);
                txt_cantida.Text = "0";
                txt_cantidad_h.Text = "0";
                txt_detalle.Text = "";
                cont2++;
                radioButton1.Checked = false;
                txt_cantida.Enabled = true;
                txt_cantidad_h.Enabled = true;
            } else if  (dato==2)
            {
                decimal x = 0;
                dataGridView1.Rows.Add(1);
                dataGridView1.Rows[cont2].Cells[1].Value = "X";
                dataGridView1.Rows[cont2].Cells[2].Value = txt_detalle.Text;
                dataGridView1.Rows[cont2].Cells[3].Value = Convert.ToDecimal(txt_cantida.Text);
                dataGridView1.Rows[cont2].Cells[4].Value = Convert.ToDecimal(txt_cantidad_h.Text);
                x = Convert.ToDecimal(dataGridView1.Rows[0].Cells[4].Value) - Convert.ToDecimal(dataGridView1.Rows[cont2].Cells[4].Value);
                dataGridView1.Rows[0].Cells[4].Value = x;
                txt_cantida.Text = "0";
                txt_cantidad_h.Text = "0";
                txt_detalle.Text = "";
                cont2++;
                radioButton2.Checked = false;
                txt_cantida.Enabled = true;
                txt_cantidad_h.Enabled = true;
            }
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            try
            {
                Editar = false;
                fn.ActivarControles(gpb_cheque_v);
                fn.LimpiarComponentes(gpb_cheque_v);
                btn_guardar.Enabled = false;
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            try
            {
                Editar = false;
                fn.LimpiarComponentes(gpb_cheque_v);
                fn.InhabilitarComponentes(gpb_cheque_v);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            
                if (cambio == "INSERTAR")
                {
                    for (int fila = 0; fila < dataGridView1.RowCount - 1; fila++)
                    {
                        if (Convert.ToString(dataGridView1.Rows[fila].Cells[1].Value) != "X")
                        {
                            
                            //MessageBox.Show("YA ESTA REGISTRADO");
                        }
                         else if (Convert.ToString(dataGridView1.Rows[fila].Cells[1].Value) == "X")
                        {
                            
                            //textBox4.Text = comboBox1.SelectedValue.ToString();
                            textBox5.Text = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                            textBox1.Text = Convert.ToString(dataGridView1.Rows[0].Cells[0].Value);
                            textBox2.Text = Convert.ToString(dataGridView1.Rows[fila].Cells[2].Value);
                            textBox3.Text = Convert.ToString(dataGridView1.Rows[fila].Cells[3].Value);
                            textBox4.Text = Convert.ToString(dataGridView1.Rows[fila].Cells[4].Value);
                            CapaNegocio fn = new CapaNegocio();
                            TextBox[] textbox = { textBox1, textBox2, textBox3, textBox4, textBox5, txt_ref };
                            DataTable datos = fn.construirDataTable(textbox);
                            if (datos.Rows.Count == 0)
                            {
                                //MessageBox.Show("Hay campos vacios", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string tabla = "detalle_documentos";
                                
                                    if (Editar)
                                    {
                                        fn.modificar(datos, tabla, atributo, Codigo);
                                    }
                                    else
                                    {
                                        fn.insertar(datos, tabla);
                                    }
                                    fn.LimpiarComponentes(this);
                                
                               
                            }

                        }
                    }
                act_documento();
                act_cv();
                act_total();
            }
                else if (cambio == "UPDATE")
                {
                    textBox2.Text = txt_detalle.Text;
                    textBox3.Text = txt_cantida.Text;
                    textBox4.Text = txt_cantidad_h.Text;
                    CapaNegocio fn = new CapaNegocio();
                    TextBox[] textbox = { textBox2, textBox3, textBox4 };
                    DataTable datos = fn.construirDataTable(textbox);
                    if (datos.Rows.Count == 0)
                    {
                        //MessageBox.Show("Hay campos vacios", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string tabla = "detalle_documentos";
                        fn.modificar(datos, tabla, atributo, Codigo);
                        fn.LimpiarComponentes(this);
                        cambio = "INSERTAR";
                        button3.Enabled = true;
                        button1.Enabled = true;
                        act_documento();
                        act_cv();
                        act_total();
                    }
                }
            

            
            /*
            for (int fila = 0; fila < dataGridView1.RowCount - 1; fila++)
            {
                string fecha = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                Ayuda.ObtenerConexion();
                //string selectedItem = cbo_empres.SelectedValue.ToString();
                String Query = "INSERT INTO detalle_documentos (nombre_cuenta,detalle,debe,haber,fecha,id_documento_pk) VALUES ('" + txt_ref.Text+ "','" + dataGridView1.Rows[fila].Cells[1].Value + "','" + Convert.ToDecimal(dataGridView1.Rows[fila].Cells[2].Value) + "','" + Convert.ToDecimal(dataGridView1.Rows[fila].Cells[3].Value) + "','" + fecha + "','"+Convert.ToInt32(dataGridView1.Rows[0].Cells[0].Value)+"') ";
                Ayuda.EjecutarMySql(Query);
                //String bitacora = "INSERT INTO bitacora_de_control (fecha_accion_bitc, accion_bitc, usuario_conn_bitc, ip_usuario_bitc, tabla_modif_bitc,id_usuario_activo) VALUE (NOW(), 'Ingresar','" + Usuario + "','" + obtenerIP() + "', 'area_laboratorio'," + MiIdUsuario + ") ";
                //Conexionmysql.EjecutarMySql(bitacora);
                //ActualizarGrid(this.dataGridView1, "select pk_id_area_lab as ID_Area, descripcion_ar_lab as Descripcion, pk_id_lab as ID_Laboratorio from area_laboratorio");
                //this.LimpiarCajasTexto();
                Ayuda.Desconectar();
               
            }*/
        }
        private void btn_editar_Click(object sender, EventArgs e)
        {
            fn.ActivarControles(gpb_cheque_v);
            try
            {
                
                btn_guardar.Enabled = true;
                button3.Enabled = false;
                button1.Enabled = false;
                //Editar = true;
                atributo = "id_detalle_cv_pk";
                Codigo = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                //label2.Text = Codigo;
                txt_detalle.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txt_cantida.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txt_cantidad_h.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                cambio = "UPDATE";
                //TextBox[] textbox = { textBox2, textBox3,textBox4 };
                //CapaNegocio fn = new CapaNegocio();
                //fn.llenartextbox(textbox, dataGridView1);
            }
            catch
            {
                MessageBox.Show("No se ha seleccionado ningun registro a editar", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            decimal suma = 0;
            decimal suma2 = 0;
            for (int fila = 0; fila < dataGridView1.RowCount - 1; fila++)
            {
                suma += Convert.ToDecimal(dataGridView1.Rows[fila].Cells[3].Value);
                suma2 += Convert.ToDecimal(dataGridView1.Rows[fila].Cells[4].Value);

            }


            if (suma >suma2)
            {
                dataGridView1.Rows[cont2].Cells[3].Value = suma;
                dataGridView1.Rows[cont2].Cells[3].Style.BackColor = Color.Red;
                dataGridView1.Rows[cont2].Cells[4].Value = suma2;
                dataGridView1.Rows[cont2].Cells[4].Style.BackColor = Color.Red;
                //MessageBox.Show("No Cuadra");
                txt_cantida.Text = "0";
                txt_cantidad_h.Text = "0";
                txt_detalle.Text = "";
                radioButton1.Checked = false;
                txt_cantida.Enabled = true;
                txt_cantidad_h.Enabled = true;
                btn_guardar.Enabled = false;
            }
            else if (suma < suma2)
            {
                dataGridView1.Rows[cont2].Cells[3].Value = suma;
                dataGridView1.Rows[cont2].Cells[3].Style.BackColor = Color.Red;
                dataGridView1.Rows[cont2].Cells[4].Value = suma2;
                dataGridView1.Rows[cont2].Cells[4].Style.BackColor = Color.Red;
                //MessageBox.Show("No Cuadra");
                btn_guardar.Enabled = false;
                MessageBox.Show("No Cuadra");
                txt_cantida.Text = "0";
                txt_cantidad_h.Text = "0";
                txt_detalle.Text = "";
                radioButton1.Checked = false;
                txt_cantida.Enabled = true;
                txt_cantidad_h.Enabled = true;

            }
            else if (suma == suma2)
            {
                
                dataGridView1.Rows[cont2].Cells[3].Value = suma;
                dataGridView1.Rows[cont2].Cells[4].Value = suma2;
                dataGridView1.Rows[cont2].Cells[3].Style.BackColor = Color.Green;
                dataGridView1.Rows[cont2].Cells[4].Style.BackColor = Color.Green;
                MessageBox.Show("Cuadra Correctamente");
                btn_guardar.Enabled = true;
                //MessageBox.Show("No Cuadra");
                txt_cantida.Text = "0";
                txt_cantidad_h.Text = "0";
                txt_detalle.Text = "";
                radioButton1.Checked = false;
                txt_cantida.Enabled = true;
                txt_cantidad_h.Enabled = true;
            }
            //MessageBox.Show(Convert.ToString(suma));
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txt_cantida.Enabled = true;
            txt_cantidad_h.Enabled = false;
            txt_cantidad_h.Text = "0";
            dato = 1;
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txt_cantida.Enabled = false;
            txt_cantidad_h.Enabled = true;
            txt_cantida.Text = "0";
            dato = 2;
            
        }

        int act_id_do;
        
        string act_cadena1;
        decimal act_cadena2;
        
        public void act_documento()
        {

            OdbcCommand Query = new OdbcCommand();
            OdbcConnection Conexion;
            OdbcDataReader consultar;
            string sql = "dsn=hotelsancarlos;server=localhost;user id=root;database=hotelsancarlos;password=";
            Conexion = new OdbcConnection();
            Conexion.ConnectionString = sql;
            Conexion.Open();
            Query.CommandText = "SELECT id_documento_pk, descripcion,valor_total From documento where no_documento = '" + cbo_doc.Text + "';";
            Query.Connection = Conexion;
            consultar = Query.ExecuteReader();
            while (consultar.Read())
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                dataGridView1.Rows.Add(1);
                act_id_do = consultar.GetInt32(0);
                act_cadena1 = consultar.GetString(1);
                act_cadena2 = consultar.GetDecimal(2);
                //id2 = consultar.GetInt32(3);
                dataGridView1.Rows[0].Cells[0].Value = act_id_do;
                dataGridView1.Rows[0].Cells[2].Value = act_cadena1;
                dataGridView1.Rows[0].Cells[4].Value = act_cadena2;
                //txt_monto.Text = Convert.ToString(cadena2);
                //MessageBox.Show(Convert.ToString(id2));
            }
           

        }
        int act_id_det_cv;
        string act_cadena3;
        string act_cadena4;
        decimal act_cadena5;
        decimal act_cadena6;
        public void act_cv()
        {
            int cont3 = 1;
            OdbcCommand Query = new OdbcCommand();
            OdbcConnection Conexion;
            OdbcDataReader consultar;
            string sql = "dsn=hotelsancarlos;server=localhost;user id=root;database=hotelsancarlos;password=";
            Conexion = new OdbcConnection();
            Conexion.ConnectionString = sql;
            Conexion.Open();
            Query.CommandText = "SELECT id_detalle_cv_pk,nombre_cuenta, detalle,debe,haber From detalle_documentos where id_documento_pk = '" + act_id_do + "' AND estado <> 'INACTIVO';";
            Query.Connection = Conexion;
            consultar = Query.ExecuteReader();
            
            while (consultar.Read())
            {
                dataGridView1.Rows.Add(1);

                act_id_det_cv = consultar.GetInt32(0);
                act_cadena3 = consultar.GetString(1);
                act_cadena4 = consultar.GetString(2);
                act_cadena5 = consultar.GetDecimal(3);
                act_cadena6 = consultar.GetDecimal(4);
                //id2 = consultar.GetInt32(3);
                dataGridView1.Rows[cont3].Cells[1].Value = act_id_det_cv;
                //dataGridView1.Rows[cont3].Cells[].Value = act_cadena3;
                dataGridView1.Rows[cont3].Cells[2].Value = act_cadena4;
                dataGridView1.Rows[cont3].Cells[3].Value = act_cadena5;
                dataGridView1.Rows[cont3].Cells[4].Value = act_cadena6;
                txt_ref.Text = Convert.ToString(act_cadena3);
                //MessageBox.Show(Convert.ToString(id2));
                cont3 = cont3 + 1;
            }
           

        }
        public void act_total()
        {
            int conteo_filas = 0;
            decimal resta = 0;
            decimal cifra = 0;
            decimal resultado = 0;
            for (int fila = 0; fila < dataGridView1.RowCount; fila++)
            {
                conteo_filas = fila;

            }
            for (int fila = 1; fila < dataGridView1.RowCount; fila++)
            {
                cifra = Convert.ToDecimal(dataGridView1.Rows[0].Cells[4].Value);
                resta += Convert.ToDecimal(dataGridView1.Rows[fila].Cells[4].Value);
                resultado = cifra - resta;
                //MessageBox.Show(Convert.ToString(resultado));
            }

            dataGridView1.Rows[0].Cells[4].Value = resultado;
            //MessageBox.Show(Convert.ToString(conteo_filas));
            cont2 = conteo_filas;
        }
        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            act_documento();
            act_cv();
            act_total();
           

           
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                String codigo2 = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                String atributo2 = "id_detalle_cv_pk";
                //String campo = "estado";
                if (codigo2 != "X")
                {
                    var resultado = MessageBox.Show("DESEA BORRAR EL REGISTRO SELECCIONADO", "CONFIRME SU ACCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {

                        CapaNegocio fn = new CapaNegocio();
                        string tabla = "detalle_documentos";
                        fn.eliminar(tabla, atributo2, codigo2);

                    }
                } else if (codigo2 == "X")
                {
                    int fil = dataGridView1.CurrentRow.Index;
                    dataGridView1.Rows.RemoveAt(fil);
                    cont2--;
                }

            }
            catch
            {
                MessageBox.Show("No se ha seleccionado ningun registro a eliminar", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            fn.Anterior(data);
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            fn.Siguiente(data);
        }

        private void btn_primero_Click(object sender, EventArgs e)
        {
            fn.Primero(data);
        }

        private void btn_ultimo_Click(object sender, EventArgs e)
        {
            fn.Ultimo(data);
        }
    }
}
