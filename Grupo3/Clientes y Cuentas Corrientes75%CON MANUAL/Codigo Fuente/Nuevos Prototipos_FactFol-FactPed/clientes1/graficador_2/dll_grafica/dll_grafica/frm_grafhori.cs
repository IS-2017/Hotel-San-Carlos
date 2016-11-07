using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Windows.Forms.DataVisualization.Charting;
namespace Graf1
{
    public partial class frm_grafhori : Form
    {
        public frm_grafhori()
        {
            InitializeComponent();
            llenar();
            
        }
        public void llenar()
        {
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
            /*-----------------------------------*/
        }


        List<int> _listy = new List<int>();
        List<string> _listx = new List<string>();
        int tot;
        int cont1 = 0, cont2 = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            


            // string scad = "SHOW FULL TABLES FROM bdsistemadereparto";
            string scad = "select * from bodega";
            MySqlCommand mcd = new MySqlCommand(scad, BdComun.ObtenerConexion());
            MySqlDataReader mdr = mcd.ExecuteReader();
            while (mdr.Read())
            {
                //comboBox1.Items.Add(mdr.GetString("Tables_in_bdsistemadereparto"));
                comboBox1.Items.Add(mdr.GetString("ubic_bod"));
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //  string scad = "select * from bodega";
            string scad = "SHOW FULL TABLES FROM base4";
            MySqlCommand mcd = new MySqlCommand(scad, BdComun.ObtenerConexion());
            MySqlDataReader mdr = mcd.ExecuteReader();
            while (mdr.Read())
            {
                //comboBox1.Items.Add(mdr.GetString("Tables_in_bdsistemadereparto"));
                comboBox1.Items.Add(mdr.GetString("Tables_in_base4"));
                //comboBox1.Items.Add(mdr.GetString("ubic_bod"));
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
            btn_gengraf.Enabled = false;
            btn_x.Enabled = false;
            btn_y.Enabled = false;
            btn_semanal.Enabled = false;
            btn_mensual.Enabled = false;
            /*--------------------------------------------*/
        }

        private void btn_gen_Click(object sender, EventArgs e)
        {
            //  string scad = "select * from bodega";
            string scad = "SHOW FULL TABLES FROM base4";
            MySqlCommand mcd = new MySqlCommand(scad, BdComun.ObtenerConexion());
            MySqlDataReader mdr = mcd.ExecuteReader();
            while (mdr.Read())
            {
                //comboBox1.Items.Add(mdr.GetString("Tables_in_bdsistemadereparto"));
                comboBox1.Items.Add(mdr.GetString("Tables_in_base4"));
                //comboBox1.Items.Add(mdr.GetString("ubic_bod"));
            }
        }

        private void btn_acpt_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = BdComun.ObtenerConexion();
            MySqlDataAdapter dausuario = new MySqlDataAdapter("SELECT * FROM "+ comboBox1.Text, conexion);
            DataSet dsuario = new DataSet();
            dausuario.Fill(dsuario, comboBox1.Text);
            dgv_datos.DataSource = dsuario;
            dgv_datos.DataMember = comboBox1.Text;


            cbo_fecha.Items.Clear();
            cbo_fecha.Text = "";

            /*Llena ComboBox con los campos de fecha de la tabla seleccionada
            * Autor: Sammy Emanuel Salazar Toledo*/
            string scad = "SELECT COLUMN_NAME FROM information_schema.COLUMNS WHERE TABLE_SCHEMA = 'base4' AND TABLE_NAME = '" + comboBox1.Text + "' AND COLUMN_NAME LIKE '%fec%'";
            MySqlCommand leer = new MySqlCommand(scad, BdComun.ObtenerConexion());
            MySqlDataReader leer2 = leer.ExecuteReader();
            while (leer2.Read())
            {
                cbo_fecha.Items.Add(leer2.GetString("COLUMN_NAME"));
            }
            /*-------------------------------------------------*/

            /*Habilita y Deshabilita ComboBox, TextBox y Botones
            * Autor: Sammy Emanuel Salazar Toledo*/
            //cbo_eje.Enabled = true;
            cbo_mmes.Enabled = false;
            cbo_mmes2.Enabled = false;
            cbo_msem.Enabled = false;
            cbo_ssem.Enabled = false;
            cbo_fecha.Enabled = true;
            txt_ames.Enabled = false;
            txt_asem.Enabled = false;

            //btn_cambiar.Enabled = true;
            //btn_validar.Enabled = true;
            btn_gengraf.Enabled = false;
            btn_x.Enabled = true;
            btn_y.Enabled = true;
            /*-------------------------------------------------------------*/

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
                        tot = selectedCellCount;
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
            btn_gengraf.Enabled = true;
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
                string titu = textBox1.Text;
                /* OBTIENE LOS VALORES DE X, Y, TITULO Y TOTAL
                * Autor: Merlyn Franco
                * Fecha: 09/10/2016*/
                frm_grafhoriDiseño hori = new frm_grafhoriDiseño(_listx, _listy, tot, titu);
                hori.ShowDialog();
                /*--------------------------------------------------------------------------*/
            }
            else
            {
                MessageBox.Show("El numero de celdas para las coordenadas x y no es igual");
                //chart2.Series.Clear();
                _listx.Clear();
                _listy.Clear();
            }


        }

       
        public void limpiar()
        {
            cbo_mmes.Text = "";
            cbo_mmes2.Text = "";
            cbo_msem.Text = "";
            cbo_ssem.Text = "";
            txt_ames.Clear();
            txt_asem.Clear();
        }
        //----------------------- Nombre: Sammy Emanuel Salazar Toledo --------------------//
        //----------------------- Carne: 0901-12-5133 -------------------------------------//
        //------------------Genera Consulta Historica--------------------------------------//
        private void btn_historico_Click(object sender, EventArgs e)
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

            MySqlConnection conexion = BdComun.ObtenerConexion();

            /*Consulta por numero de semana en el mes
            * Autor: Sammy Emanuel Salazar Toledo*/
            if (cbo_ssem.Text == "1")
            {
                String cadenas1 = txt_asem.Text + "-" + cbo_msem.Text;
                MySqlDataAdapter dusuario = new MySqlDataAdapter("SELECT * FROM " + comboBox1.Text + " WHERE " + cbo_fecha.Text + " BETWEEN '" + cadenas1 + "-01' AND '" + cadenas1 + "-07'", conexion);
                DataSet dsuario = new DataSet();
                dusuario.Fill(dsuario, comboBox1.Text);
                dgv_datos.DataSource = dsuario;
                dgv_datos.DataMember = comboBox1.Text;
                limpiar();

            }
            else if (cbo_ssem.Text == "2")
            {
                String cadenas2 = txt_asem.Text + "-" + cbo_msem.Text;
                MySqlDataAdapter dusuario = new MySqlDataAdapter("SELECT * FROM " + comboBox1.Text + " WHERE " + cbo_fecha.Text + " BETWEEN '" + cadenas2 + "-08' AND '" + cadenas2 + "-14'", conexion);
                DataSet dsuario = new DataSet();
                dusuario.Fill(dsuario, comboBox1.Text);
                dgv_datos.DataSource = dsuario;
                dgv_datos.DataMember = comboBox1.Text;
                limpiar();
            }
            else if (cbo_ssem.Text == "3")
            {
                String cadenas3 = txt_asem.Text + "-" + cbo_msem.Text;
                MySqlDataAdapter dusuario = new MySqlDataAdapter("SELECT * FROM " + comboBox1.Text + " WHERE " + cbo_fecha.Text + " BETWEEN '" + cadenas3 + "-15' AND '" + cadenas3 + "-21'", conexion);
                DataSet dsuario = new DataSet();
                dusuario.Fill(dsuario, comboBox1.Text);
                dgv_datos.DataSource = dsuario;
                dgv_datos.DataMember = comboBox1.Text;
                limpiar();
            }
            else if (cbo_ssem.Text == "4")
            {
                String cadenas4 = txt_asem.Text + "-" + cbo_msem.Text;
                MySqlDataAdapter dusuario = new MySqlDataAdapter("SELECT * FROM " + comboBox1.Text + " WHERE " + cbo_fecha.Text + " BETWEEN '" + cadenas4 + "-22' AND '" + cadenas4 + "-31'", conexion);
                DataSet dsuario = new DataSet();
                dusuario.Fill(dsuario, comboBox1.Text);
                dgv_datos.DataSource = dsuario;
                dgv_datos.DataMember = comboBox1.Text;
                limpiar();
            }

            //}
            /*Hace la consulta historica mensual
             * Autor: Sammy Emanuel Salazar Toledo*/
            else if (cbo_mmes != null)
            {
                //MySqlConnection conexion = BdComun.ObtenerConexion();

                String cadena1 = txt_ames.Text + "-" + cbo_mmes.Text;
                String cadena2 = txt_ames.Text + "-" + cbo_mmes2.Text;
                MySqlDataAdapter dusuario2 = new MySqlDataAdapter("SELECT * FROM " + comboBox1.Text + " WHERE " + cbo_fecha.Text + " BETWEEN '" + cadena1 + "-01' AND '" + cadena2 + "-31'", conexion);
                DataSet dsuario2 = new DataSet();
                dusuario2.Fill(dsuario2, comboBox1.Text);
                dgv_datos.DataSource = dsuario2;
                dgv_datos.DataMember = comboBox1.Text;
                limpiar();

            }
            /*-------------------------------------------------*/
            limpiar();
            cbo_ssem.Enabled = false;
            cbo_msem.Enabled = false;
            txt_asem.Enabled = false;
            cbo_mmes.Enabled = false;
            cbo_mmes2.Enabled = false;
            txt_ames.Enabled = false;
           
        }

        private void button1_Click_3(object sender, EventArgs e)
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

        private void button2_Click_2(object sender, EventArgs e)
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

        private void txt_asem_TextChanged(object sender, EventArgs e)
        {
            btn_historico.Enabled = true;
        }

        private void txt_ames_TextChanged(object sender, EventArgs e)
        {
            btn_historico.Enabled = true;
        }

        private void cbo_fecha_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_semanal.Enabled = true;
            btn_mensual.Enabled = true;
        }

        private void button2_Click_3(object sender, EventArgs e)
        {
            //----------------------- Nombre: Pedro Alejandro Martinez Aguirre --------------------//
            //----------------------- Carne: 0901-12-4321 -------------------------------------//
            //------------------------Limpia combo box y cadenas para que puedan ser utilizadas en una nueva grafica--------//
            limpiar();
            _listx.Clear();
            _listy.Clear();
            
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            //----------------------- Nombre: Pedro Alejandro Martinez Aguirre --------------------//
            //----------------------- Carne: 0901-12-4321 -------------------------------------//
            //------------------------Actualiza datos de la tabla seleccionada y refresca el datagriedview--------//
            MySqlConnection conexion = BdComun.ObtenerConexion();
            MySqlDataAdapter dausuario = new MySqlDataAdapter("SELECT * FROM " + comboBox1.Text, conexion);
            DataSet dsuario = new DataSet();
            dausuario.Fill(dsuario, comboBox1.Text);
            dgv_datos.DataSource = dsuario;
            dgv_datos.DataMember = comboBox1.Text;
        }
    }
}
