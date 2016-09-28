using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjetoComunConsultasInteligentes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            desctivarCampos();
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
            btn_add2.Enabled = false;
            btn_add3.Enabled = false;
            btn_add4.Enabled = false;
            btn_add5.Enabled = false;
            cbo_condicion1.Enabled = false;
            cbo_condicion2.Enabled = false;
            cbo_condicion3.Enabled = false;
            btn_or.Enabled = false;
            btn_and.Enabled = false;
        }

        //---------------------------------------Validaciones----------------------------------------------------------------
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_check1.Checked == true)
            {

                cbo_from2.Enabled = true;
                cbo_select2.Enabled = true;
                btn_add2.Enabled = true;
            }
            else
            {
                cbo_from2.Enabled = false;
                cbo_select2.Enabled = false;
                btn_add2.Enabled = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_check2.Checked == true)
            {

                cbo_from3.Enabled = true;
                cbo_select3.Enabled = true;
                btn_add3.Enabled = true;
            }
            else
            {
                cbo_from3.Enabled = false;
                cbo_select3.Enabled = false;
                btn_add3.Enabled = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_check3.Checked == true)
            {

                cbo_from4.Enabled = true;
                cbo_select4.Enabled = true;
                btn_add4.Enabled = true;
            }
            else
            {
                cbo_from4.Enabled = false;
                cbo_select4.Enabled = false;
                btn_add4.Enabled = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
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

        //--------------------------------------Agregar SELECT ----------------------------------------------------------------
        string SelectCadena;//unir select´s

        //------------------------------------------BOTON AÑADIR 1ra TABLA SELECT----------------------------------------------
        string ss = "";
        string s1 = "";
        string s2 = "a.";
        string s4;
        int cont = 0;
        private void btn_add1_Click(object sender, EventArgs e)
        {

            //ComboBox cbx = new ComboBox();
            //cbx.Height = 100;
            //cbx.Width = 50;
            //cbx.Items.Add("Hola");
            //cbx.Items.Add("Hola1");


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
        }

        //------------------------------------------BOTON AÑADIR 2da TABLA SELECT----------------------------------------------
        string aa = "";
        string a1 = "";
        string a2 = "b.";
        string a4;
        
        private void btn_add2_Click(object sender, EventArgs e)
        {
            string a3 = ", " + a2 + "" + cbo_select2.Text + " ";
            a1 = a3;
            a4 = a3;
            aa = aa + " " + a4;
            //MessageBox.Show(aa);
            CrearConsultas();
        }

        //------------------------------------------BOTON AÑADIR 3ra TABLA SELECT----------------------------------------------
        string bb = "";
        string b1 = "";
        string b2 = "c.";
        string b4;

        private void btn_add3_Click(object sender, EventArgs e)
        {
            string b3 = ", " + b2 + "" + cbo_select3.Text + " ";
            b1 = b3;
            b4 = b3;
            bb = bb + " " + b4;
            //MessageBox.Show(bb);
            CrearConsultas();
        }

        //------------------------------------------BOTON AÑADIR 4ta TABLA SELECT----------------------------------------------
        string cc = "";
        string c1 = "";
        string c2 = "d.";
        string c4;

        private void btn_add4_Click(object sender, EventArgs e)
        {
            string c3 = ", " + c2 + "" + cbo_select4.Text + " ";
            c1 = c3;
            c4 = c3;
            cc = cc + " " + c4;
            //MessageBox.Show(cc);
            CrearConsultas();
        }

        //------------------------------------------BOTON AÑADIR 5ta TABLA SELECT----------------------------------------------
        string dd = "";
        string d1 = "";
        string d2 = "e.";
        string d4;
        private void btn_add5_Click(object sender, EventArgs e)
        {
            string d3 = ", " + d2 + "" + cbo_select5.Text + " ";
            d1 = d3;
            d4 = d3;
            dd = dd + " " + d4;
            //MessageBox.Show(dd);
            CrearConsultas();
        }

        //--------------------------------------------BOTON VERIFICAR CADENA DE SELECT-----------------------------------------
        string select = "SELECT";
        string SelectCompleto;
        private void button1_Click(object sender, EventArgs e)
        {
            select = "SELECT";
            SelectCadena = ss + aa + bb + cc + dd;
            SelectCompleto = select + " " + SelectCadena;
            MessageBox.Show(SelectCompleto);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        //---------------------------------------------------------------------------------------------------------------------
        //------------------------------------CREAR OR-------------------------------------------------------------------------
        string oo = "";
        string o1 = "";
        string o2 = "OR ";
        string o4;
        private void btn_or_Click(object sender, EventArgs e)
        {
            string o3 = "" + o2 + "" + cbo_condicion1.Text + " "+ cbo_condicion2.Text + " "+ cbo_condicion3.Text + " ";
            o1 = o3;
            o4 = o3;
            oo = oo + " " + o4;
            //MessageBox.Show(oo);
            CrearConsultas();
        }

        // ----------------------------------CREAR AND--------------------------------------------------------------------------
        string n2 = "AND ";
        private void btn_and_Click(object sender, EventArgs e)
        {
            string o3 = "" + n2 + "" + cbo_condicion1.Text + " " + cbo_condicion2.Text + " " + cbo_condicion3.Text + " ";
            o1 = o3;
            o4 = o3;
            oo = oo + " " + o4;
            //MessageBox.Show(oo);
            CrearConsultas();
        }


        //--------------------------------------validacion con where ----------------------------------------------------------
        private void rdb_conwhere_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_conwhere.Checked == true)
            {
                cbo_condicion1.Enabled = true;
                cbo_condicion2.Enabled = true;
                cbo_condicion3.Enabled = true;
                
            }
            else
            {
                cbo_condicion1.Enabled = false;
                cbo_condicion2.Enabled = false;
                cbo_condicion3.Enabled = false;
                btn_or.Enabled = false;
                btn_and.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Hide();
            Frm_ConsultaInteligente consul = new Frm_ConsultaInteligente();
            consul.Show();
        }

        //---------------------------------------------------------------------------------------------------------------------
        //---------------------------------Condiciones Para Crear Query--------------------------------------------------------

        private void btn_generarConsulta_Click(object sender, EventArgs e)
        {
            CrearConsultas();
        }


        public void CrearConsultas()
        {
            // ---------------------------------------------QUERYS SIN WHERE---------------------------------------------------
            if (chb_check1.Checked == false && chb_check2.Checked == false && chb_check3.Checked == false && chb_check4.Checked == false && rdb_conwhere.Checked == false)
            {
                MessageBox.Show("opcion 0");
                string cadena;
                cadena = "SELECT" + ss + aa + bb + cc + dd + " FROM " + cbo_from1.Text + " a";
                //MessageBox.Show(cadena);
                lbl_vistapreviaconsulta.Text = cadena;
            }
            if (chb_check1.Checked == true && chb_check2.Checked == false && chb_check3.Checked == false && chb_check4.Checked == false && rdb_conwhere.Checked == false)
            {
                MessageBox.Show("opcion 1");
                string cadena;
                cadena = "SELECT" + ss + aa + bb + cc + dd + " FROM " + cbo_from1.Text + " a," + cbo_from2.Text + " b";
                //MessageBox.Show(cadena);
                lbl_vistapreviaconsulta.Text = cadena;
            }
            if (chb_check1.Checked == true && chb_check2.Checked == true && chb_check3.Checked == false && chb_check4.Checked == false && rdb_conwhere.Checked == false)
            {
                MessageBox.Show("opcion 1,2");
                string cadena;
                cadena = "SELECT" + ss + aa + bb + cc + dd + " FROM " + cbo_from1.Text + " a," + cbo_from2.Text + " b," + cbo_from3.Text + " c";
                //MessageBox.Show(cadena);
                lbl_vistapreviaconsulta.Text = cadena;
            }
            if (chb_check1.Checked == true && chb_check2.Checked == true && chb_check3.Checked == true && chb_check4.Checked == false && rdb_conwhere.Checked == false)
            {
                MessageBox.Show("opcion 1,2,3");
                string cadena;
                cadena = "SELECT" + ss + aa + bb + cc + dd + " FROM " + cbo_from1.Text + " a," + cbo_from2.Text + " b," + cbo_from3.Text + " c," + cbo_from4.Text + " d";
                //MessageBox.Show(cadena);
                lbl_vistapreviaconsulta.Text = cadena;
            }
            if (chb_check1.Checked == true && chb_check2.Checked == true && chb_check3.Checked == true && chb_check4.Checked == true && rdb_conwhere.Checked == false)
            {
                MessageBox.Show("opcion 1,2,3,4");
                string cadena;
                cadena = "SELECT" + ss + aa + bb + cc + dd + " FROM " + cbo_from1.Text + " a," + cbo_from2.Text + " b," + cbo_from3.Text + " c," + cbo_from4.Text +" d,"+ cbo_from5.Text +" e";
                //MessageBox.Show(cadena);
                lbl_vistapreviaconsulta.Text = cadena;
            }

            // ----------------------------------------------QUERYS CON WHERE----------------------------------------------------

            if (chb_check1.Checked == false && chb_check2.Checked == false && chb_check3.Checked == false && chb_check4.Checked == false && rdb_conwhere.Checked == true)
            {
                MessageBox.Show("opcion 0");
                string cadena;
                cadena = "SELECT" + ss + aa + bb + cc + dd + " FROM " + cbo_from1.Text + " a WHERE "+ oo;
                //MessageBox.Show(cadena);
                lbl_vistapreviaconsulta.Text = cadena;
            }
            if (chb_check1.Checked == true && chb_check2.Checked == false && chb_check3.Checked == false && chb_check4.Checked == false && rdb_conwhere.Checked == true)
            {
                MessageBox.Show("opcion 1 where");
                string cadena;
                cadena = "SELECT" + ss + aa + bb + cc + dd + " FROM " + cbo_from1.Text + " a," + cbo_from2.Text + " b WHERE "+ oo;
                //MessageBox.Show(cadena);
                lbl_vistapreviaconsulta.Text = cadena;
            }
            if (chb_check1.Checked == true && chb_check2.Checked == true && chb_check3.Checked == false && chb_check4.Checked == false && rdb_conwhere.Checked == true)
            {
                MessageBox.Show("opcion 1,2 where");
                string cadena;
                cadena = "SELECT" + ss + aa + bb + cc + dd + " FROM " + cbo_from1.Text + " a," + cbo_from2.Text + " b," + cbo_from3.Text + " c WHERE " + oo;
                //MessageBox.Show(cadena);
                lbl_vistapreviaconsulta.Text = cadena;
            }
            if (chb_check1.Checked == true && chb_check2.Checked == true && chb_check3.Checked == true && chb_check4.Checked == false && rdb_conwhere.Checked == true)
            {
                MessageBox.Show("opcion 1,2,3 where");
                string cadena;
                cadena = "SELECT" + ss + aa + bb + cc + dd + " FROM " + cbo_from1.Text + " a," + cbo_from2.Text + " b," + cbo_from3.Text + " c," + cbo_from4.Text + " d WHERE "+ oo;
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

        private void cbo_from4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //--------------------------------------Complemento de creacion de where-----------------------------------------------
        private void btn_crear_condicion_Click(object sender, EventArgs e)
        {
            oo = cbo_condicion1.Text + " " + cbo_condicion2.Text + " " + cbo_condicion3.Text;
            btn_or.Enabled = true;
            btn_and.Enabled = true;
            CrearConsultas();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
