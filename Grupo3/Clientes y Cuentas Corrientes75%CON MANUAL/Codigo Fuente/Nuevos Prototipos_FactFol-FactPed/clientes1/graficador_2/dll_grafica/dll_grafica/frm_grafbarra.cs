using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using MySql.Data.MySqlClient;
using System.Windows.Forms.DataVisualization.Charting;
using System.Data.Odbc;
using seguridad;

namespace Graf1
{
    public partial class frm_grafbarra : Form
    {
        public frm_grafbarra()
        {
            InitializeComponent();
            btn_semanal.Enabled = false;
            btn_mensual.Enabled = false;
           
        }

       

        List<int> _listy = new List<int>();
        List<string> _listx = new List<string>();

        int cont1 = 0, cont2 = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            
            // string scad = "SHOW FULL TABLES FROM bdsistemadereparto";
            string scad = "select * from bodega";
            DataTable dt = new DataTable();
            OdbcCommand mcd = new OdbcCommand(scad, seguridad.Conexion.ObtenerConexionODBC());
            OdbcDataAdapter da = new OdbcDataAdapter(mcd);
            da.Fill(dt);

            if (dt.Rows.Count != 0)
            {
                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "ubic_bod";
                comboBox1.ValueMember = "pk_codbod";
            }
            //OdbcDataReader mdr = mcd.ExecuteReader();
            //while (mdr.Read())
            //{
            //    //comboBox1.Items.Add(mdr.GetString("Tables_in_bdsistemadereparto"));
            //    comboBox1.Items.Add(mdr.GetString("ubic_bod").ToString();
            //}
            else {
                MessageBox.Show("Error al cargar datos");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //  string scad = "select * from bodega";
            string scad = "SHOW FULL TABLES FROM base4";
            DataTable dt = new DataTable();
            OdbcCommand mcd = new OdbcCommand(scad, seguridad.Conexion.ObtenerConexionODBC());
            OdbcDataAdapter da = new OdbcDataAdapter(mcd);
            da.Fill(dt);

            if (dt.Rows.Count != 0)
            {
                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "Tables_in_base4";
                comboBox1.ValueMember = "Tables_in_base4";
            }            
            else
            {
                MessageBox.Show("Error al cargar datos");
            }
            /*while (mdr.Read())
            {
              
                comboBox1.Items.Add(mdr.GetString("Tables_in_bdsistemadereparto"));
              
            }
            /*Habilita y Deshabilita ComboBox, TextBox y Botones
            * Autor: Sammy Emanuel Salazar Toledo */
            cbo_mmes.Enabled = false;
            cbo_mmes2.Enabled = false;
            cbo_msem.Enabled = false;
            cbo_ssem.Enabled = false;
            cbo_fecha.Enabled = false;

            //Deshabilita edicion de ComboBox
            cbo_mmes.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_mmes2.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_msem.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_ssem.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_fecha.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;

            txt_ames.Enabled = false;
            txt_asem.Enabled = false;
            btn_historico.Enabled = false;
            //btn_cambiar.Enabled = false;
            //btn_validar.Enabled = false;
            btn_grafigen.Enabled = false;
            btn_x.Enabled = false;
            btn_y.Enabled = false;

            llenar();
            /*----------------------------------------------*/

        }
            public void llenar() {
            /*Llena ComboBox de Numero de Semana
            * Autor: Sammy Emanuel Salazar Toledo*/
            cbo_ssem.Items.Add("1");
            cbo_ssem.Items.Add("2");
            cbo_ssem.Items.Add("3");
            cbo_ssem.Items.Add("4");


            /*Llena ComboBox de Seleccion de Mes
             * Autor: Sammy Emanuel Salazar Toledo*/

            cbo_mmes.Items.Add("01");
            cbo_mmes.Items.Add("02");
            cbo_mmes.Items.Add("03");
            cbo_mmes.Items.Add("04");
            cbo_mmes.Items.Add("05");
            cbo_mmes.Items.Add("06");
            cbo_mmes.Items.Add("07");
            cbo_mmes.Items.Add("08");
            cbo_mmes.Items.Add("09");
            cbo_mmes.Items.Add("10");
            cbo_mmes.Items.Add("11");
            cbo_mmes.Items.Add("12");

            cbo_mmes2.Items.Add("01");
            cbo_mmes2.Items.Add("02");
            cbo_mmes2.Items.Add("03");
            cbo_mmes2.Items.Add("04");
            cbo_mmes2.Items.Add("05");
            cbo_mmes2.Items.Add("06");
            cbo_mmes2.Items.Add("07");
            cbo_mmes2.Items.Add("08");
            cbo_mmes2.Items.Add("09");
            cbo_mmes2.Items.Add("10");
            cbo_mmes2.Items.Add("11");
            cbo_mmes2.Items.Add("12");

            cbo_msem.Items.Add("01");
            cbo_msem.Items.Add("02");
            cbo_msem.Items.Add("03");
            cbo_msem.Items.Add("04");
            cbo_msem.Items.Add("05");
            cbo_msem.Items.Add("06");
            cbo_msem.Items.Add("07");
            cbo_msem.Items.Add("08");
            cbo_msem.Items.Add("09");
            cbo_msem.Items.Add("10");
            cbo_msem.Items.Add("11");
            cbo_msem.Items.Add("12");
            /*-----------------------------------*/
            }

    private void btn_gen_Click(object sender, EventArgs e)
        {
            //  string scad = "select * from bodega";
            string scad = "SHOW FULL TABLES FROM base4";
            DataTable dt = new DataTable();
            OdbcCommand mcd = new OdbcCommand(scad, seguridad.Conexion.ObtenerConexionODBC());
            //OdbcDataReader mdr = mcd.ExecuteReader();
            OdbcDataAdapter da = new OdbcDataAdapter(mcd);
            da.Fill(dt);

            if (dt.Rows.Count != 0)
            {
                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "base4";
                comboBox1.ValueMember = "base4";
            }
            else
            {
                MessageBox.Show("Error al cargar datos");
            }
            /*while (mdr.Read())
            {
                //comboBox1.Items.Add(mdr.GetString("Tables_in_bdsistemadereparto"));
                comboBox1.Items.Add(mdr.GetString("Tables_in_bdsistemadereparto"));
                //comboBox1.Items.Add(mdr.GetString("ubic_bod"));
            }*/
        }

        private void btn_acpt_Click(object sender, EventArgs e)
        {

            OdbcConnection conexion = seguridad.Conexion.ObtenerConexionODBC();
            OdbcDataAdapter dausuario = new OdbcDataAdapter("SELECT * FROM "+ comboBox1.Text, conexion);
            DataSet dsuario = new DataSet();
            dausuario.Fill(dsuario, comboBox1.Text);
            dgv_datos.DataSource = dsuario;
            dgv_datos.DataMember = comboBox1.Text;

            cbo_fecha.Items.Clear();
            cbo_fecha.Text= "";

            /*Llena ComboBox con los campos de fecha de la tabla seleccionada
           * Autor: Sammy Emanuel Salazar Toledo*/

            string scad = "SELECT COLUMN_NAME FROM information_schema.COLUMNS WHERE TABLE_SCHEMA = 'bdsistemadereparto' AND TABLE_NAME = '"+ comboBox1.Text +"' AND COLUMN_NAME LIKE '%fec%'";
            //OdbcCommand leer = new OdbcCommand(scad, seguridad.Conexion.ObtenerConexionODBC());
            //OdbcDataReader leer2 = leer.ExecuteReader();
            DataTable dt = new DataTable();
            OdbcCommand mcd = new OdbcCommand(scad, seguridad.Conexion.ObtenerConexionODBC());
            //OdbcDataReader mdr = mcd.ExecuteReader();
            OdbcDataAdapter da = new OdbcDataAdapter(mcd);
            da.Fill(dt);

            if (dt.Rows.Count != 0)
            {
                cbo_fecha.DataSource = dt;
                cbo_fecha.DisplayMember = "COLUMN_NAME";
                cbo_fecha.ValueMember = "COLUMN_NAME";
            }
            else
            {
                MessageBox.Show("Error al cargar datos");
            }

            /*while (leer2.Read())
            {
                cbo_fecha.Items.Add(leer2.GetString("COLUMN_NAME"));
            }*/
            /*----------------------------------------------*/

            /*Habilita y Deshabilita ComboBox, TextBox y Botones
           * Autor: Sammy Emanuel Salazar Toledo*/
            //cb_eje.Enabled = true;
            cbo_mmes.Enabled = false;
            cbo_mmes2.Enabled = false;
            cbo_msem.Enabled = false;
            cbo_ssem.Enabled = false;
            cbo_fecha.Enabled = true;
            txt_ames.Enabled = false;
            txt_asem.Enabled = false; 
           
            //btn_cambiar.Enabled = true;
            //btn_validar.Enabled = true;
            btn_grafigen.Enabled = false;
            btn_x.Enabled = true;
            btn_y.Enabled = true;
            /*--------------------------------*/
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
      
            try
            {
                Int32 selectedCellCount = dgv_datos.GetCellCount(DataGridViewElementStates.Selected);
                Int16 datos;
                if (selectedCellCount > 0)
                {
                    if (dgv_datos.AreAllCellsSelected(true))
                    {
                        MessageBox.Show("All cells are selected", "Selected Cells");
                    }
                    else
                    {
                        StringBuilder sb = new StringBuilder();

                        for (int i = 0; i < selectedCellCount; i++)
                        {
                            sb.Append("Row: ");
                            sb.Append(dgv_datos.SelectedCells[i].RowIndex.ToString());
                            sb.Append(", Column: ");
                            sb.Append(dgv_datos.SelectedCells[i].ColumnIndex.ToString());
                            sb.Append(Environment.NewLine);
                            datos = Convert.ToInt16(dgv_datos.SelectedCells[i].Value);
                            //MessageBox.Show(datos);
                            _listy.Add(datos);
                        }

                        cont1 = selectedCellCount;
                        sb.Append("Total: " + selectedCellCount.ToString());
                        MessageBox.Show("eje y seleccionado");
                    }
                }




            }
            catch (Exception )
            {
                //MessageBox.Show(ex.ToString());
                MessageBox.Show("Seleccione un dato o conjunto de datos numerico");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            btn_grafigen.Enabled = true;
            try
            {



                Int32 selectedCellCount = dgv_datos.GetCellCount(DataGridViewElementStates.Selected);
                string datos;
                if (selectedCellCount > 0)
                {
                    if (dgv_datos.AreAllCellsSelected(true))
                    {
                        MessageBox.Show("All cells are selected", "Selected Cells");
                    }
                    else
                    {
                        StringBuilder sb = new StringBuilder();

                        for (int i = 0; i < selectedCellCount; i++)
                        {
                            sb.Append("Row: ");
                            sb.Append(dgv_datos.SelectedCells[i].RowIndex.ToString());
                            sb.Append(", Column: ");
                            sb.Append(dgv_datos.SelectedCells[i].ColumnIndex.ToString());
                            sb.Append(Environment.NewLine);
                            datos = Convert.ToString(dgv_datos.SelectedCells[i].Value);
                            //MessageBox.Show(datos);
                            _listx.Add(datos);
                        }
                        cont2 = selectedCellCount;
                        sb.Append("Total: " + selectedCellCount.ToString());
                        MessageBox.Show("eje x seleccionado");
                    }
                }




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {            

            if (cont1 == cont2)
            {
                string[] series = _listx.ToArray();
                int[] puntos = _listy.ToArray();

                string tlt = textBox1.Text;

                /* DECLARACION DE VARIABLES QUE OBTIENE LOS 
                * VALORES DE X , Y TITULO 
                * Autor: Merlyn Franco
                * Fecha: 09/10/2016*/
                frm_grafbarraDiseño dise = new frm_grafbarraDiseño(_listy, _listx, tlt);
                dise.ShowDialog();
                /*-------------------------------------------------------------------------*/
            }
            else
            {
                MessageBox.Show("El numero de celdas para las coordenadas x y no es igual");
                //chart2.Series.Clear();
                _listx.Clear();
                _listy.Clear();
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

      

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }
        public void limpiar()
        {
            cbo_mmes.Text = "";
            cbo_mmes2.Text = "";
            cbo_msem.Text = "";
            cbo_ssem.Text="";
            txt_ames.Clear();
            txt_asem.Clear();

        }


        //----------------------- Nombre: Sammy Emanuel Salazar Toledo --------------------//
        //----------------------- Carne: 0901-12-5133 -------------------------------------//
        //------------------Genera Consulta Historica--------------------------------------//
        private void button1_Click_3(object sender, EventArgs e)
        {
            /*Habilita y Deshabilita ComboBox, TextBox, Botones
              * Autor: Sammy Emanuel Salazar Toledo*/
            cbo_mmes.Enabled = false;
            cbo_mmes2.Enabled = false;
            cbo_msem.Enabled = false;
            cbo_ssem.Enabled = false;
            txt_ames.Enabled = false;
            txt_asem.Enabled = false;
            btn_semanal.Enabled = true;
            btn_mensual.Enabled = true;
          

            OdbcConnection conexion = seguridad.Conexion.ObtenerConexionODBC();


            /*Consulta por numero de semana en el mes
             * Autor: Sammy Emanuel Salazar Toledo*/
            if (cbo_ssem.Text == "1") {
                String cadenas1 = txt_asem.Text +"-"+ cbo_msem.Text;
                OdbcDataAdapter dusuario = new OdbcDataAdapter("SELECT * FROM " + comboBox1.Text + " WHERE "+ cbo_fecha.Text +" BETWEEN '" + cadenas1 +"-01' AND '"+ cadenas1 +"-07'", conexion);
                DataSet dsuario = new DataSet();
                dusuario.Fill(dsuario, comboBox1.Text);
                dgv_datos.DataSource = dsuario;
                dgv_datos.DataMember = comboBox1.Text;
                limpiar();

            }
                else if (cbo_ssem.Text == "2"){
                String cadenas2 = txt_asem.Text + "-" + cbo_msem.Text;
                OdbcDataAdapter dusuario = new OdbcDataAdapter("SELECT * FROM " + comboBox1.Text + " WHERE "+ cbo_fecha.Text +" BETWEEN '" + cadenas2 + "-08' AND '" + cadenas2 + "-14'", conexion);
                DataSet dsuario = new DataSet();
                dusuario.Fill(dsuario, comboBox1.Text);
                dgv_datos.DataSource = dsuario;
                dgv_datos.DataMember = comboBox1.Text;
                limpiar();
            }
                else if (cbo_ssem.Text == "3"){
                String cadenas3 = txt_asem.Text + "-" + cbo_msem.Text;
                OdbcDataAdapter dusuario = new OdbcDataAdapter("SELECT * FROM " + comboBox1.Text + " WHERE "+cbo_fecha.Text+" BETWEEN '" + cadenas3 + "-15' AND '" + cadenas3 + "-21'", conexion);
                DataSet dsuario = new DataSet();
                dusuario.Fill(dsuario, comboBox1.Text);
                dgv_datos.DataSource = dsuario;
                dgv_datos.DataMember = comboBox1.Text;
                limpiar();
            }
                else if (cbo_ssem.Text == "4"){
                String cadenas4 = txt_asem.Text + "-" + cbo_msem.Text;
                OdbcDataAdapter dusuario = new OdbcDataAdapter("SELECT * FROM " + comboBox1.Text + " WHERE "+cbo_fecha.Text+" BETWEEN '" + cadenas4 + "-22' AND '" + cadenas4 + "-31'", conexion);
                DataSet dsuario = new DataSet();
                dusuario.Fill(dsuario, comboBox1.Text);
                dgv_datos.DataSource = dsuario;
                dgv_datos.DataMember = comboBox1.Text;
                limpiar();
            }
            /*-----------------------------------*/

            /*Hace la consulta historica mensual
           * Autor: Sammy Emanuel Salazar Toledo*/
            else if (cbo_mmes != null) {
                //MySqlConnection conexion = BdComun.ObtenerConexion();

                String cadena1 = txt_ames.Text + "-" + cbo_mmes.Text;
                String cadena2 = txt_ames.Text + "-" + cbo_mmes2.Text;

                OdbcDataAdapter dusuario2 = new OdbcDataAdapter("SELECT * FROM " + comboBox1.Text + " WHERE " + cbo_fecha.Text + " BETWEEN '" + cadena1 + "-01' AND '" + cadena2 + "-31'", conexion);
                DataSet dsuario2 = new DataSet();
                dusuario2.Fill(dsuario2, comboBox1.Text);
                dgv_datos.DataSource = dsuario2;
                dgv_datos.DataMember = comboBox1.Text;
                limpiar();

            }
            limpiar();
            /*Habilita y Deshabilita ComboBox y TextBox
             * Autor: Sammy Emanuel Salazar Toledo*/
            cbo_ssem.Enabled = false;
            cbo_msem.Enabled = false;
            txt_asem.Enabled = false;
            cbo_mmes.Enabled = false;
            cbo_mmes2.Enabled = false;
            txt_ames.Enabled = false;

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_4(object sender, EventArgs e)
        {
            //----------------------- Nombre: Sammy Emanuel Salazar Toledo --------------------//
            //----------------------- Carne: 0901-12-5133 -------------------------------------//
            //------------------------Habilita y Deshabilita ComboBox, TextBox, Botones--------//
            limpiar();
            cbo_mmes.Enabled = false;
            cbo_mmes2.Enabled = false;
            cbo_msem.Enabled = true;
            cbo_ssem.Enabled = true;
            txt_ames.Enabled = false;
            txt_asem.Enabled = true;
            btn_semanal.Enabled = true;
            btn_mensual.Enabled = true;
            btn_historico.Enabled = false;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //----------------------- Nombre: Sammy Emanuel Salazar Toledo --------------------//
            //----------------------- Carne: 0901-12-5133 -------------------------------------//
            //------------------------Habilita y Deshabilita ComboBox, TextBox, Botones--------//
            limpiar();
            cbo_mmes.Enabled = true;
            cbo_mmes2.Enabled = true;
            cbo_msem.Enabled = false;
            cbo_ssem.Enabled = false;
            txt_ames.Enabled = true;
            txt_asem.Enabled = false;
            btn_semanal.Enabled = true;
            btn_mensual.Enabled = true;
            btn_historico.Enabled = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb_eje_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbo_fecha_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_semanal.Enabled = true;
            btn_mensual.Enabled = true;
        }

        private void txt_asem_TextChanged(object sender, EventArgs e)
        {
            btn_historico.Enabled = true;
        }

        private void txt_ames_TextChanged(object sender, EventArgs e)
        {
            btn_historico.Enabled = true;
        }

        private void button1_Click_5(object sender, EventArgs e)
        {
            //----------------------- Nombre: Pedro Alejandro Martinez Aguirre --------------------//
            //----------------------- Carne: 0901-12-4321 -------------------------------------//
            //------------------------Funcion de actualizar datos de la tabla seleccionada en el datagriedview--------//
            OdbcConnection conexion = seguridad.Conexion.ObtenerConexionODBC();
            OdbcDataAdapter dausuario = new OdbcDataAdapter("SELECT * FROM " + comboBox1.Text, conexion);
            DataSet dsuario = new DataSet();
            dausuario.Fill(dsuario, comboBox1.Text);
            dgv_datos.DataSource = dsuario;
            dgv_datos.DataMember = comboBox1.Text;
                      
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            //----------------------- Nombre: Pedro Alejandro Martinez Aguirre --------------------//
            //----------------------- Carne: 0901-12-4321 -------------------------------------//
            //------------------------Limpia las cadenas asi como los combo box para poder ser utlizados en una nueva grafica--------//
            limpiar();
            _listx.Clear();
            _listy.Clear();
           
        }
    }
}
