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
using System.Collections;
//creacion: rodrigo y walter
namespace dllconsultasgeneraless
{
    public partial class frm_consultas : Form
    {
        metodos obtienecol = new metodos();
        string SelectCadena;
        string aa = "";
        string a1 = "";
        string a2 = "b.";
        string a4;
        string ss = "";
        string s1 = "";
        string s2 = "a.";
        string s4;
        string dd = "";
        string d1 = "";
        string d2 = "e.";
        string d4;
        string cc = "";
        string c1 = "";
        string c2 = "d.";
        string c4;
        string bb = "";
        string b1 = "";
        string b2 = "c.";
        string b4;
        string n2 = "AND ";
        string oo = "";
        string o1 = "";
        string o2 = "OR ";
        string o4;
        string select = "SELECT";
        string SelectCompleto;
        int cont = 0;
        metodos manipulacion = new metodos();
        public frm_consultas()
        {
            InitializeComponent();
            desctivarCampos();
            combobox_carga_tablas();
        }
       

        private void frm_consultas_Load(object sender, EventArgs e)
        {

        }

        private void btn_add1_Click(object sender, EventArgs e)
        {
            //ComboBox cbx = new ComboBox();
            //cbx.Height = 100;
            //cbx.Width = 50;
            //cbx.Items.Add("Hola");
            //cbx.Items.Add("Hola1");
            if (cbo_from1.Text == "" || cbo_select1.Text == "")
            {
                MessageBox.Show("Llene los campos correspondientes", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string s3;
                if (cont == 0)
                {
                    s3 = "" + s2 + "" + cbo_select1.Text + " ";
                }
                else
                {
                    s3 = "," + s2 + "" + cbo_select1.Text + " ";
                }
                cont++;
                s1 = s3;
                s4 = s3;
                ss = ss + " " + s4;
                //MessageBox.Show(ss);
                CrearConsultas();
                chb_check1.Enabled = true;
            }
        }

        private void btn_add2_Click(object sender, EventArgs e)
        {
            if (cbo_from2.Text == "" || cbo_select2.Text == "" || cbo_from2.Text == cbo_from1.Text)
            {
                MessageBox.Show("Llene los campos correspondientes\n No repetir tabla", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                chb_check1.Checked = false;
            }
            else
            {
                string a3 = ", " + a2 + "" + cbo_select2.Text + " ";
                a1 = a3;
                a4 = a3;
                aa = aa + " " + a4;
                //MessageBox.Show(aa);
                CrearConsultas();
            }
        }

        private void btn_add3_Click(object sender, EventArgs e)
        {
            if (cbo_from3.Text == "" || cbo_select3.Text == "" || cbo_from2.Text == cbo_from3.Text || cbo_from3.Text == cbo_from1.Text)
            {
                MessageBox.Show("Llene los campos correspondientes\n No repetir tabla", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                chb_check2.Checked = false;
            }
            else
            {
                string b3 = ", " + b2 + "" + cbo_select3.Text + " ";
                b1 = b3;
                b4 = b3;
                bb = bb + " " + b4;
                //MessageBox.Show(bb);
                CrearConsultas();
            }
        }

        private void btn_add4_Click(object sender, EventArgs e)
        {
            if (cbo_from4.Text == "" || cbo_select4.Text == "" || cbo_from3.Text == cbo_from4.Text || cbo_from2.Text == cbo_from4.Text || cbo_from4.Text == cbo_from1.Text)
            {
                MessageBox.Show("Llene los campos correspondientes\n No repetir tabla", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                chb_check3.Checked = false;
            }
            else
            {
                string c3 = ", " + c2 + "" + cbo_select4.Text + " ";
                c1 = c3;
                c4 = c3;
                cc = cc + " " + c4;
                //MessageBox.Show(cc);
                CrearConsultas();
            }
        }

        private void btn_add5_Click(object sender, EventArgs e)
        {
            if (cbo_from5.Text == "" || cbo_select5.Text == "" || cbo_from4.Text == cbo_from5.Text || cbo_from3.Text == cbo_from5.Text || cbo_from2.Text == cbo_from5.Text || cbo_from5.Text == cbo_from1.Text)
            {
                MessageBox.Show("Llene los campos correspondientes", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                chb_check4.Checked = false;
            }
            else
            {
                string d3 = ", " + d2 + "" + cbo_select5.Text + " ";
                d1 = d3;
                d4 = d3;
                dd = dd + " " + d4;
                //MessageBox.Show(dd);
                CrearConsultas();
            }
        }

        private void chb_check1_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_check1.Checked == true)
            {

                cbo_from2.Enabled = true;
                cbo_select2.Enabled = true;
                btn_mas1.Enabled = true;
                chb_check2.Enabled = true;
            }
            else
            {
                cbo_from2.Enabled = false;
                cbo_select2.Enabled = false;
                btn_mas1.Enabled = false;
                chb_check2.Enabled = false;
                chb_check2.Checked = false;
            }
        }

        private void chb_check2_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_check2.Checked == true)
            {

                cbo_from3.Enabled = true;
                cbo_select3.Enabled = true;
                btn_add3.Enabled = true;
                chb_check3.Enabled = true;
            }
            else
            {
                cbo_from3.Enabled = false;
                cbo_select3.Enabled = false;
                btn_add3.Enabled = false;
                chb_check3.Enabled = false;
                chb_check3.Checked = false;
            }
        }

        private void chb_check3_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_check3.Checked == true)
            {

                cbo_from4.Enabled = true;
                cbo_select4.Enabled = true;
                btn_add4.Enabled = true;
                chb_check4.Enabled = true;
            }
            else
            {
                cbo_from4.Enabled = false;
                cbo_select4.Enabled = false;
                btn_add4.Enabled = false;
                chb_check4.Enabled = false;
                chb_check4.Checked = false;
            }
        }

        private void chb_check4_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_check4.Checked == true)
            {

                cbo_from5.Enabled = true;
                cbo_select5.Enabled = true;
                btn_add5.Enabled = true;
            }
            else
            {
                cbo_from5.Enabled = false;
                cbo_select5.Enabled = false;
                btn_add5.Enabled = false;
            }
        }

        private void rdb_conwhere_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_conwhere.Checked == true)
            {
                rdb_cond1.Enabled = true;
                rdb_cond2.Enabled = true;

            }
            else
            {
                cbo_condicion1.Enabled = false;
                cbo_condicion2.Enabled = false;
                cbo_condicion3.Enabled = false;
                btn_or.Enabled = false;
                btn_and.Enabled = false;
                cbo_tabla_condicion1.Enabled = false;
                cbo_tabla_condicion3.Enabled = false;
                btn_crear_condicion.Enabled = false;
                rdb_cond1.Enabled = false;
                rdb_cond2.Enabled = false;
                rdb_cond1.Checked = false;
                rdb_cond2.Checked = false;
                cbo_cond2_tabla.Enabled = false;
                cbo_cond2_campo.Enabled = false;
                cbo_simbolo.Enabled = false;
                cbo_indicador.Enabled = false;
            }
        }

        private void rdb_cond1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_cond1.Checked == true)
            {
                cbo_condicion1.Enabled = true;
                cbo_condicion2.Enabled = true;
                cbo_condicion3.Enabled = true;
                cbo_tabla_condicion1.Enabled = true;
                cbo_tabla_condicion3.Enabled = true;
                btn_crear_condicion.Enabled = true;
            }
            else
            {
                cbo_condicion1.Enabled = false;
                cbo_condicion2.Enabled = false;
                cbo_condicion3.Enabled = false;
                cbo_tabla_condicion1.Enabled = false;
                cbo_tabla_condicion3.Enabled = false;


            }
        }

        private void rdb_cond2_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_cond2.Checked == true)
            {
                cbo_cond2_tabla.Enabled = true;
                cbo_cond2_campo.Enabled = true;
                cbo_simbolo.Enabled = true;
                cbo_indicador.Enabled = true;
                btn_crear_condicion.Enabled = true;
            }
            else
            {
                cbo_cond2_tabla.Enabled = false;
                cbo_cond2_campo.Enabled = false;
                cbo_simbolo.Enabled = false;
                cbo_indicador.Enabled = false;
            }
        }

        private void cbo_condicion1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbo_from1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbo_select1.Items.Clear();
            combobox_carga_filas1();
        }

        private void cbo_select1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbo_from2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbo_select2.Items.Clear();
            combobox_carga_filas2();
        }

        private void cbo_from3_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbo_select3.Items.Clear();
            combobox_carga_filas3();
        }

        private void cbo_from4_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbo_select4.Items.Clear();
            combobox_carga_filas4();
        }

        private void cbo_from5_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbo_select5.Items.Clear();
            combobox_carga_filas5();
        }

        private void cbo_tabla_condicion1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbo_condicion1.Items.Clear();
            combobox_carga_filas6();
        }

        private void cbo_tabla_condicion3_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbo_condicion3.Items.Clear();
            combobox_carga_filas7();
        }

        private void btn_crear_condicion_Click(object sender, EventArgs e)
        {

            if (rdb_cond1.Checked == true || rdb_cond2.Checked == false)
            {
                if (cbo_condicion1.Text == "" || cbo_condicion2.Text == "" || cbo_condicion3.Text == "")
                {
                    MessageBox.Show("Llene los campos correspondientes", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    String prefijo1 = "";
                    string prefijo2 = "";
                    //prefijo1
                    if (cbo_tabla_condicion1.Text == cbo_from1.Text)
                    {
                        prefijo1 = "a.";
                    }
                    if (cbo_tabla_condicion1.Text == cbo_from2.Text)
                    {
                        prefijo1 = "b.";
                    }
                    if (cbo_tabla_condicion1.Text == cbo_from3.Text)
                    {
                        prefijo1 = "c.";
                    }
                    if (cbo_tabla_condicion1.Text == cbo_from4.Text)
                    {
                        prefijo1 = "d.";
                    }
                    if (cbo_tabla_condicion1.Text == cbo_from5.Text)
                    {
                        prefijo1 = "e.";
                    }
                    else
                    {
                        MessageBox.Show("No esta seleccionada la tabla");

                    }
                    //prefijo2
                    if (cbo_tabla_condicion3.Text == cbo_from1.Text)
                    {
                        prefijo2 = "a.";
                    }
                    if (cbo_tabla_condicion3.Text == cbo_from2.Text)
                    {
                        prefijo2 = "b.";
                    }
                    if (cbo_tabla_condicion3.Text == cbo_from3.Text)
                    {
                        prefijo2 = "c.";
                    }
                    if (cbo_tabla_condicion3.Text == cbo_from4.Text)
                    {
                        prefijo2 = "d.";
                    }
                    if (cbo_tabla_condicion3.Text == cbo_from5.Text)
                    {
                        prefijo2 = "e.";
                    }
                    else
                    {
                        MessageBox.Show("No esta seleccionada la tabla");

                    }
                    oo = prefijo1 + cbo_condicion1.Text + " " + cbo_condicion2.Text + " " + prefijo2 + cbo_condicion3.Text;
                    btn_or.Enabled = true;
                    btn_and.Enabled = true;
                    CrearConsultas();
                }
            }
            if (rdb_cond2.Checked == true)
            {
                if (cbo_cond2_campo.Text == "" || cbo_simbolo.Text == "" || cbo_indicador.Text == "")
                {
                    MessageBox.Show("Llene los campos correspondientes", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    String prefijo = "";
                    //MessageBox.Show("si entra");
                    //prefijo1
                    if (cbo_cond2_tabla.Text == cbo_from1.Text)
                    {
                        prefijo = "a.";
                    }
                    if (cbo_cond2_tabla.Text == cbo_from2.Text)
                    {
                        prefijo = "b.";
                    }
                    if (cbo_cond2_tabla.Text == cbo_from3.Text)
                    {
                        prefijo = "c.";
                    }
                    if (cbo_cond2_tabla.Text == cbo_from4.Text)
                    {
                        prefijo = "d.";
                    }
                    if (cbo_cond2_tabla.Text == cbo_from5.Text)
                    {
                        prefijo = "e.";
                    }
                    else
                    {
                        MessageBox.Show("No esta seleccionada la tabla");

                    }

                    oo = prefijo + cbo_cond2_campo.Text + " " + cbo_simbolo.Text + " " + cbo_indicador.Text;
                    btn_or.Enabled = true;
                    btn_and.Enabled = true;
                    CrearConsultas();
                }

            }
        }

        private void btn_or_Click(object sender, EventArgs e)
        {
            if (rdb_cond1.Checked == true)
            {
                if (cbo_condicion1.Text == "" || cbo_condicion2.Text == "" || cbo_condicion3.Text == "")
                {
                    MessageBox.Show("Llene los campos correspondientes", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    String prefijo1 = "";
                    string prefijo2 = "";
                    //prefijo1
                    if (cbo_tabla_condicion1.Text == cbo_from1.Text)
                    {
                        prefijo1 = "a.";
                    }
                    if (cbo_tabla_condicion1.Text == cbo_from2.Text)
                    {
                        prefijo1 = "b.";
                    }
                    if (cbo_tabla_condicion1.Text == cbo_from3.Text)
                    {
                        prefijo1 = "c.";
                    }
                    if (cbo_tabla_condicion1.Text == cbo_from4.Text)
                    {
                        prefijo1 = "d.";
                    }
                    if (cbo_tabla_condicion1.Text == cbo_from5.Text)
                    {
                        prefijo1 = "e.";
                    }
                    else
                    {
                        MessageBox.Show("No esta seleccionada la tabla");

                    }
                    //prefijo2
                    if (cbo_tabla_condicion3.Text == cbo_from1.Text)
                    {
                        prefijo2 = "a.";
                    }
                    if (cbo_tabla_condicion3.Text == cbo_from2.Text)
                    {
                        prefijo2 = "b.";
                    }
                    if (cbo_tabla_condicion3.Text == cbo_from3.Text)
                    {
                        prefijo2 = "c.";
                    }
                    if (cbo_tabla_condicion3.Text == cbo_from4.Text)
                    {
                        prefijo2 = "d.";
                    }
                    if (cbo_tabla_condicion3.Text == cbo_from5.Text)
                    {
                        prefijo2 = "e.";
                    }
                    else
                    {
                        MessageBox.Show("No esta seleccionada la tabla");

                    }
                    string o3 = "" + o2 + "" + prefijo1 + cbo_condicion1.Text + " " + cbo_condicion2.Text + " " + prefijo2 + cbo_condicion3.Text + " ";
                    o1 = o3;
                    o4 = o3;
                    oo = oo + " " + o4;
                    //MessageBox.Show(oo);
                    CrearConsultas();
                }
            }
            if (rdb_cond2.Checked == true)
            {
                if (cbo_cond2_campo.Text == "" || cbo_simbolo.Text == "" || cbo_indicador.Text == "")
                {
                    MessageBox.Show("Llene los campos correspondientes", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    String prefijo = "";

                    //prefijo1
                    if (cbo_cond2_tabla.Text == cbo_from1.Text)
                    {
                        prefijo = "a.";
                    }
                    if (cbo_cond2_tabla.Text == cbo_from2.Text)
                    {
                        prefijo = "b.";
                    }
                    if (cbo_cond2_tabla.Text == cbo_from3.Text)
                    {
                        prefijo = "c.";
                    }
                    if (cbo_cond2_tabla.Text == cbo_from4.Text)
                    {
                        prefijo = "d.";
                    }
                    if (cbo_cond2_tabla.Text == cbo_from5.Text)
                    {
                        prefijo = "e.";
                    }
                    else
                    {
                        MessageBox.Show("No esta seleccionada la tabla");

                    }

                    string o3 = "" + o2 + "" + prefijo + cbo_cond2_campo.Text + " " + cbo_simbolo.Text + " " + cbo_indicador.Text + " ";
                    o1 = o3;
                    o4 = o3;
                    oo = oo + " " + o4;
                    //MessageBox.Show(oo);
                    CrearConsultas();
                }

            }

        }

        private void btn_and_Click(object sender, EventArgs e)
        {
            if (rdb_cond1.Checked == true)
            {
                if (cbo_condicion1.Text == "" || cbo_condicion2.Text == "" || cbo_condicion3.Text == "")
                {
                    MessageBox.Show("Llene los campos correspondientes", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    String prefijo1 = "";
                    string prefijo2 = "";
                    //prefijo1
                    if (cbo_tabla_condicion1.Text == cbo_from1.Text)
                    {
                        prefijo1 = "a.";
                    }
                    if (cbo_tabla_condicion1.Text == cbo_from2.Text)
                    {
                        prefijo1 = "b.";
                    }
                    if (cbo_tabla_condicion1.Text == cbo_from3.Text)
                    {
                        prefijo1 = "c.";
                    }
                    if (cbo_tabla_condicion1.Text == cbo_from4.Text)
                    {
                        prefijo1 = "d.";
                    }
                    if (cbo_tabla_condicion1.Text == cbo_from5.Text)
                    {
                        prefijo1 = "e.";
                    }
                    else
                    {
                        MessageBox.Show("No esta seleccionada la tabla");

                    }
                    //prefijo2
                    if (cbo_tabla_condicion3.Text == cbo_from1.Text)
                    {
                        prefijo2 = "a.";
                    }
                    if (cbo_tabla_condicion3.Text == cbo_from2.Text)
                    {
                        prefijo2 = "b.";
                    }
                    if (cbo_tabla_condicion3.Text == cbo_from3.Text)
                    {
                        prefijo2 = "c.";
                    }
                    if (cbo_tabla_condicion3.Text == cbo_from4.Text)
                    {
                        prefijo2 = "d.";
                    }
                    if (cbo_tabla_condicion3.Text == cbo_from5.Text)
                    {
                        prefijo2 = "e.";
                    }
                    else
                    {
                        MessageBox.Show("No esta seleccionada la tabla");

                    }
                    string o3 = "" + n2 + "" + prefijo1 + cbo_condicion1.Text + " " + cbo_condicion2.Text + " " + prefijo2 + cbo_condicion3.Text + " ";
                    o1 = o3;
                    o4 = o3;
                    oo = oo + " " + o4;
                    //MessageBox.Show(oo);
                    CrearConsultas();
                }
            }
            if (rdb_cond2.Checked == true)
            {
                if (cbo_cond2_campo.Text == "" || cbo_simbolo.Text == "" || cbo_indicador.Text == "")
                {
                    MessageBox.Show("Llene los campos correspondientes", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    String prefijo = "";

                    //prefijo1
                    if (cbo_tabla_condicion1.Text == cbo_from1.Text)
                    {
                        prefijo = "a.";
                    }
                    if (cbo_tabla_condicion1.Text == cbo_from2.Text)
                    {
                        prefijo = "b.";
                    }
                    if (cbo_tabla_condicion1.Text == cbo_from3.Text)
                    {
                        prefijo = "c.";
                    }
                    if (cbo_tabla_condicion1.Text == cbo_from4.Text)
                    {
                        prefijo = "d.";
                    }
                    if (cbo_tabla_condicion1.Text == cbo_from5.Text)
                    {
                        prefijo = "e.";
                    }
                    else
                    {
                        MessageBox.Show("No esta seleccionada la tabla");

                    }

                    string o3 = "" + n2 + "" + prefijo + cbo_cond2_campo.Text + " " + cbo_simbolo.Text + " " + cbo_indicador.Text + " ";
                    o1 = o3;
                    o4 = o3;
                    oo = oo + " " + o4;
                    //MessageBox.Show(oo);
                    CrearConsultas();
                }
            }
        }

        private void btn_consAlmacen_Click(object sender, EventArgs e)
        {
            frm_extraer guardar = new frm_extraer(dataGridView1);
            guardar.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lbl_vistapreviaconsulta.Text == "Consulta vista Previa")
            {
                MessageBox.Show("No Hay Consulta\n Agregue Una Consulta", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string queru;
                queru = lbl_vistapreviaconsulta.Text;
                //MessageBox.Show(queru);
                frm_gurdar guardar = new frm_gurdar(queru);
                guardar.Show();
            }
        }

        private void btn_generarConsulta_Click(object sender, EventArgs e)
        {
            string Parametro_query;
            Parametro_query = lbl_vistapreviaconsulta.Text + ";";
            //MessageBox.Show(Parametro_query);
            manipulacion.actualizargrid(Parametro_query, dataGridView1);
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            limpiarQuery();
        }

        private void cbo_cond2_tabla_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbo_cond2_campo.Items.Clear();
            combobox_carga_filas8();
        }



        //-----------------------------------------------------carga de datos en combobox----------------------------------------------

        public void combobox_carga_filas1()
        {
            if (cbo_from1.Text == "")
            {

            }
            else
            {
                
                ArrayList columnas;

                columnas = obtienecol.getColumnas(cbo_from1.Text);
                for (int i = 0; i < columnas.Count; i++)
                {
                    cbo_select1.Items.Add(columnas[i].ToString());
                }
            }

        }

        public void combobox_carga_filas2()
        {
            if (cbo_from1.Text == "")
            {

            }
            else
            {
                ;
                ArrayList columnas;

                columnas = obtienecol.getColumnas(cbo_from2.Text);
                for (int i = 0; i < columnas.Count; i++)
                {
                    cbo_select2.Items.Add(columnas[i].ToString());
                }
            }

        }

        public void combobox_carga_filas3()
        {
            if (cbo_from1.Text == "")
            {

            }
            else
            {
                ;
                ArrayList columnas;

                columnas = obtienecol.getColumnas(cbo_from3.Text);
                for (int i = 0; i < columnas.Count; i++)
                {
                    cbo_select3.Items.Add(columnas[i].ToString());
                }
            }

        }

        public void combobox_carga_filas4()
        {
            if (cbo_from1.Text == "")
            {
                //no se hace nada para no cargar datos al combobox correcpondiente para evitar error
            }
            else
            {
              ;
                ArrayList columnas;

                columnas = obtienecol.getColumnas(cbo_from4.Text);
                for (int i = 0; i < columnas.Count; i++)
                {
                    cbo_select4.Items.Add(columnas[i].ToString());
                }
            }

        }

        public void combobox_carga_filas5()
        {
            if (cbo_from1.Text == "")
            {

            }
            else
            {
       
                ArrayList columnas;

                columnas = obtienecol.getColumnas(cbo_from5.Text);
                for (int i = 0; i < columnas.Count; i++)
                {
                    cbo_select5.Items.Add(columnas[i].ToString());
                }
            }

        }

        //-condiciones
        public void combobox_carga_filas6()
        {
            if (cbo_tabla_condicion1.Text == "")
            {

            }
            else
            {
              
                ArrayList columnas;

                columnas = obtienecol.getColumnas(cbo_tabla_condicion1.Text);
                for (int i = 0; i < columnas.Count; i++)
                {
                    cbo_condicion1.Items.Add(columnas[i].ToString());
                }
            }

        }

        public void combobox_carga_filas7()
        {
            if (cbo_tabla_condicion3.Text == "")
            {

            }
            else
            {
             

                ArrayList columnas;

                columnas = obtienecol.getColumnas(cbo_tabla_condicion3.Text);
                for (int i = 0; i < columnas.Count; i++)
                {
                    cbo_condicion3.Items.Add(columnas[i].ToString());
                }
            }

        }

        public void combobox_carga_filas8()
        {
            if (cbo_cond2_tabla.Text == "")
            {

            }
            else
            {
                metodos obtienecol = new metodos();
                ArrayList columnas;

                columnas = obtienecol.getColumnas(cbo_cond2_tabla.Text);
                for (int i = 0; i < columnas.Count; i++)
                {
                    cbo_cond2_campo.Items.Add(columnas[i].ToString());
                }
            }

        }

        MySqlDataReader dr;
        public void combobox_carga_tablas()
        {
          
            string sql = "SHOW TABLES;";
            MySqlCommand tbl = new MySqlCommand();
            tbl.CommandText = sql;
            tbl.CommandType = CommandType.Text;
            tbl.Connection = obtienecol.rutaconectada();
            dr = tbl.ExecuteReader();
            while (dr.Read())
            {
                cbo_from1.Items.Add(dr[0]);
                cbo_from2.Items.Add(dr[0]);
                cbo_from3.Items.Add(dr[0]);
                cbo_from4.Items.Add(dr[0]);
                cbo_from5.Items.Add(dr[0]);
                cbo_tabla_condicion1.Items.Add(dr[0]);
                cbo_tabla_condicion3.Items.Add(dr[0]);
                cbo_cond2_tabla.Items.Add(dr[0]);
            }
            dr.Close();
            obtienecol.Desconectar();
        }

        public void CrearConsultas()
        {
            // ---------------------------------------------QUERYS SIN WHERE---------------------------------------------------
            if (chb_check1.Checked == false && chb_check2.Checked == false && chb_check3.Checked == false && chb_check4.Checked == false && rdb_conwhere.Checked == false)
            {
                MessageBox.Show("opcion 0");
                string cadena;
                cadena = "SELECT" + ss + " FROM " + cbo_from1.Text + " a";
                //MessageBox.Show(cadena);
                lbl_vistapreviaconsulta.Text = cadena;
            }
            if (chb_check1.Checked == true && chb_check2.Checked == false && chb_check3.Checked == false && chb_check4.Checked == false && rdb_conwhere.Checked == false)
            {
                MessageBox.Show("opcion 1");
                string cadena;
                cadena = "SELECT" + ss + aa + " FROM " + cbo_from1.Text + " a," + cbo_from2.Text + " b";
                //MessageBox.Show(cadena);
                lbl_vistapreviaconsulta.Text = cadena;
            }
            if (chb_check1.Checked == true && chb_check2.Checked == true && chb_check3.Checked == false && chb_check4.Checked == false && rdb_conwhere.Checked == false)
            {
                MessageBox.Show("opcion 1,2");
                string cadena;
                cadena = "SELECT" + ss + aa + bb + " FROM " + cbo_from1.Text + " a," + cbo_from2.Text + " b," + cbo_from3.Text + " c";
                //MessageBox.Show(cadena);
                lbl_vistapreviaconsulta.Text = cadena;
            }
            if (chb_check1.Checked == true && chb_check2.Checked == true && chb_check3.Checked == true && chb_check4.Checked == false && rdb_conwhere.Checked == false)
            {
                MessageBox.Show("opcion 1,2,3");
                string cadena;
                cadena = "SELECT" + ss + aa + bb + cc + " FROM " + cbo_from1.Text + " a," + cbo_from2.Text + " b," + cbo_from3.Text + " c," + cbo_from4.Text + " d";
                //MessageBox.Show(cadena);
                lbl_vistapreviaconsulta.Text = cadena;
            }
            if (chb_check1.Checked == true && chb_check2.Checked == true && chb_check3.Checked == true && chb_check4.Checked == true && rdb_conwhere.Checked == false)
            {
                MessageBox.Show("opcion 1,2,3,4");
                string cadena;
                cadena = "SELECT" + ss + aa + bb + cc + dd + " FROM " + cbo_from1.Text + " a," + cbo_from2.Text + " b," + cbo_from3.Text + " c," + cbo_from4.Text + " d," + cbo_from5.Text + " e";
                //MessageBox.Show(cadena);
                lbl_vistapreviaconsulta.Text = cadena;
            }

            // ----------------------------------------------QUERYS CON WHERE----------------------------------------------------

            if (chb_check1.Checked == false && chb_check2.Checked == false && chb_check3.Checked == false && chb_check4.Checked == false && rdb_conwhere.Checked == true)
            {
                MessageBox.Show("opcion 0");
                string cadena;
                cadena = "SELECT" + ss + " FROM " + cbo_from1.Text + " a WHERE " + oo;
                //MessageBox.Show(cadena);
                lbl_vistapreviaconsulta.Text = cadena;
            }
            if (chb_check1.Checked == true && chb_check2.Checked == false && chb_check3.Checked == false && chb_check4.Checked == false && rdb_conwhere.Checked == true)
            {
                MessageBox.Show("opcion 1 where");
                string cadena;
                cadena = "SELECT" + ss + aa + " FROM " + cbo_from1.Text + " a," + cbo_from2.Text + " b WHERE " + oo;
                //MessageBox.Show(cadena);
                lbl_vistapreviaconsulta.Text = cadena;
            }
            if (chb_check1.Checked == true && chb_check2.Checked == true && chb_check3.Checked == false && chb_check4.Checked == false && rdb_conwhere.Checked == true)
            {
                MessageBox.Show("opcion 1,2 where");
                string cadena;
                cadena = "SELECT" + ss + aa + bb + " FROM " + cbo_from1.Text + " a," + cbo_from2.Text + " b," + cbo_from3.Text + " c WHERE " + oo;
                //MessageBox.Show(cadena);
                lbl_vistapreviaconsulta.Text = cadena;
            }
            if (chb_check1.Checked == true && chb_check2.Checked == true && chb_check3.Checked == true && chb_check4.Checked == false && rdb_conwhere.Checked == true)
            {
                MessageBox.Show("opcion 1,2,3 where");
                string cadena;
                cadena = "SELECT" + ss + aa + bb + cc + " FROM " + cbo_from1.Text + " a," + cbo_from2.Text + " b," + cbo_from3.Text + " c," + cbo_from4.Text + " d WHERE " + oo;
                //MessageBox.Show(cadena);
                lbl_vistapreviaconsulta.Text = cadena;
            }
            if (chb_check1.Checked == true && chb_check2.Checked == true && chb_check3.Checked == true && chb_check4.Checked == true && rdb_conwhere.Checked == true)
            {
                MessageBox.Show("opcion 1,2,3,4 where");
                string cadena;
                cadena = "SELECT" + ss + aa + bb + cc + dd + " FROM " + cbo_from1.Text + " a," + cbo_from2.Text + " b," + cbo_from3.Text + " c," + cbo_from4.Text + " d," + cbo_from5.Text + " e WHERE" + oo;
                //MessageBox.Show(cadena);
                lbl_vistapreviaconsulta.Text = cadena;
            }
        }

        public void limpiarQuery()
        {

            ss = "";
            aa = "";
            bb = "";
            cc = "";
            dd = "";
            oo = "";
            cont = 0;
            desctivarCampos();
            rdb_sinwhere.Checked = true;
            cbo_condicion1.ResetText();
            cbo_from1.ResetText();
            cbo_from2.ResetText();
            cbo_select2.ResetText();
            cbo_from3.ResetText();
            cbo_select3.ResetText();
            cbo_from4.ResetText();
            cbo_select4.ResetText();
            cbo_from5.ResetText();
            cbo_select5.ResetText();
            cbo_condicion1.ResetText();
            cbo_condicion2.ResetText();
            cbo_condicion3.ResetText();
            cbo_tabla_condicion1.ResetText();
            cbo_tabla_condicion3.ResetText();
            chb_check1.Checked = false;
            chb_check2.Checked = false;
            chb_check3.Checked = false;
            chb_check4.Checked = false;

        }
        void desctivarCampos()
        {
            cbo_from2.Enabled = false;
            cbo_select2.Enabled = false;
            cbo_from3.Enabled = false;
            cbo_select3.Enabled = false;
            cbo_from4.Enabled = false;
            cbo_select4.Enabled = false;
            cbo_from5.Enabled = false;
            cbo_select5.Enabled = false;
            btn_mas1.Enabled = false;
            btn_add3.Enabled = false;
            btn_add4.Enabled = false;
            btn_add5.Enabled = false;
            cbo_condicion1.Enabled = false;
            cbo_condicion2.Enabled = false;
            cbo_condicion3.Enabled = false;
            btn_or.Enabled = false;
            btn_and.Enabled = false;
            cbo_tabla_condicion1.Enabled = false;
            cbo_tabla_condicion3.Enabled = false;
            btn_crear_condicion.Enabled = false;
            chb_check1.Enabled = false;
            rdb_cond1.Enabled = false;
            rdb_cond2.Enabled = false;
            chb_check2.Enabled = false;
            chb_check3.Enabled = false;
            chb_check4.Enabled = false;
            cbo_cond2_tabla.Enabled = false;
            cbo_cond2_campo.Enabled = false;
            cbo_simbolo.Enabled = false;
            cbo_indicador.Enabled = false;
        }

        private void cbo_cond2_campo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private const string ayudacinetopiaadministrativa = "nuevo.chm";
        private void btn_ayuda_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Help.ShowHelp(this, Application.StartupPath + @"/" + ayudacinetopiaadministrativa);
        }
    }
}

