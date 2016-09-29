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
            cbo_ssem.Items.Add("1");
            cbo_ssem.Items.Add("2");
            cbo_ssem.Items.Add("3");
            cbo_ssem.Items.Add("4");

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
            string scad = "SHOW FULL TABLES FROM bdsistemadereparto";
            MySqlCommand mcd = new MySqlCommand(scad, BdComun.ObtenerConexion());
            MySqlDataReader mdr = mcd.ExecuteReader();
            while (mdr.Read())
            {
                //comboBox1.Items.Add(mdr.GetString("Tables_in_bdsistemadereparto"));
                comboBox1.Items.Add(mdr.GetString("Tables_in_bdsistemadereparto"));
                //comboBox1.Items.Add(mdr.GetString("ubic_bod"));
            }
            cbo_mmes.Enabled = false;
            cbo_mmes2.Enabled = false;
            cbo_msem.Enabled = false;
            cbo_ssem.Enabled = false;
            txt_ames.Enabled = false;
            txt_asem.Enabled = false;
            btn_historico.Enabled = false;
            btn_cambiar.Enabled = false;
            btn_validar.Enabled = false;
            btn_gengraf.Enabled = false;
            btn_x.Enabled = false;
            btn_y.Enabled = false;

        }

        private void btn_gen_Click(object sender, EventArgs e)
        {
            //  string scad = "select * from bodega";
            string scad = "SHOW FULL TABLES FROM bdsistemadereparto";
            MySqlCommand mcd = new MySqlCommand(scad, BdComun.ObtenerConexion());
            MySqlDataReader mdr = mcd.ExecuteReader();
            while (mdr.Read())
            {
                //comboBox1.Items.Add(mdr.GetString("Tables_in_bdsistemadereparto"));
                comboBox1.Items.Add(mdr.GetString("Tables_in_bdsistemadereparto"));
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

            cbo_eje.Enabled = true;
            cbo_mmes.Enabled = true;
            cbo_mmes2.Enabled = true;
            cbo_msem.Enabled = true;
            cbo_ssem.Enabled = true;
            txt_ames.Enabled = true;
            txt_asem.Enabled = true;
            btn_historico.Enabled = true;
            btn_cambiar.Enabled = true;
            btn_validar.Enabled = true;
            btn_x.Enabled = true;
            btn_y.Enabled = true;

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
                        MessageBox.Show(sb.ToString(), "Selected Cells");
                    }
                }




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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
                        MessageBox.Show(sb.ToString(), "Selected Cells");
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

                frm_grafhoriDiseño hori = new frm_grafhoriDiseño(_listx, _listy, tot, titu);
                hori.ShowDialog();
            }else
            {
                MessageBox.Show("El numero de celdas para las coordenadas x y no es igual");
                //chart2.Series.Clear();
                _listx.Clear();
                _listy.Clear();
            }

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            cbo_eje.Enabled = true;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (cbo_eje.Text == "X")
            {
                _listx.Clear();
            }
            else
            {
                if (cbo_eje.Text == "Y")
                {
                    _listy.Clear();
                }
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

        private void btn_historico_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = BdComun.ObtenerConexion();
            if (cbo_ssem.Text == "1")
            {
                String cadenas1 = txt_asem.Text + "-" + cbo_msem.Text;
                MySqlDataAdapter dusuario = new MySqlDataAdapter("SELECT * FROM " + comboBox1.Text + " WHERE fec_nac_clte BETWEEN '" + cadenas1 + "-01' AND '" + cadenas1 + "-07'", conexion);
                DataSet dsuario = new DataSet();
                dusuario.Fill(dsuario, comboBox1.Text);
                dgv_datos.DataSource = dsuario;
                dgv_datos.DataMember = comboBox1.Text;
                limpiar();

            }
            else if (cbo_ssem.Text == "2")
            {
                String cadenas2 = txt_asem.Text + "-" + cbo_msem.Text;
                MySqlDataAdapter dusuario = new MySqlDataAdapter("SELECT * FROM " + comboBox1.Text + " WHERE fec_nac_clte BETWEEN '" + cadenas2 + "-08' AND '" + cadenas2 + "-14'", conexion);
                DataSet dsuario = new DataSet();
                dusuario.Fill(dsuario, comboBox1.Text);
                dgv_datos.DataSource = dsuario;
                dgv_datos.DataMember = comboBox1.Text;
                limpiar();
            }
            else if (cbo_ssem.Text == "3")
            {
                String cadenas3 = txt_asem.Text + "-" + cbo_msem.Text;
                MySqlDataAdapter dusuario = new MySqlDataAdapter("SELECT * FROM " + comboBox1.Text + " WHERE fec_nac_clte BETWEEN '" + cadenas3 + "-15' AND '" + cadenas3 + "-21'", conexion);
                DataSet dsuario = new DataSet();
                dusuario.Fill(dsuario, comboBox1.Text);
                dgv_datos.DataSource = dsuario;
                dgv_datos.DataMember = comboBox1.Text;
                limpiar();
            }
            else if (cbo_ssem.Text == "4")
            {
                String cadenas4 = txt_asem.Text + "-" + cbo_msem.Text;
                MySqlDataAdapter dusuario = new MySqlDataAdapter("SELECT * FROM " + comboBox1.Text + " WHERE fec_nac_clte BETWEEN '" + cadenas4 + "-22' AND '" + cadenas4 + "-31'", conexion);
                DataSet dsuario = new DataSet();
                dusuario.Fill(dsuario, comboBox1.Text);
                dgv_datos.DataSource = dsuario;
                dgv_datos.DataMember = comboBox1.Text;
                limpiar();
            }

            //}
            else if (cbo_mmes != null)
            {
                //MySqlConnection conexion = BdComun.ObtenerConexion();

                String cadena1 = txt_ames.Text + "-" + cbo_mmes.Text;
                String cadena2 = txt_ames.Text + "-" + cbo_mmes2.Text;
                MySqlDataAdapter dusuario2 = new MySqlDataAdapter("SELECT * FROM " + comboBox1.Text + " WHERE fec_nac_clte BETWEEN '" + cadena1 + "-01' AND '" + cadena2 + "-31'", conexion);
                DataSet dsuario2 = new DataSet();
                dusuario2.Fill(dsuario2, comboBox1.Text);
                dgv_datos.DataSource = dsuario2;
                dgv_datos.DataMember = comboBox1.Text;
                limpiar();

            }
        }
    }
}
