using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Collections;
namespace ModuloAdminHotel
{
    public partial class Frm_ReservacionHotel : Form
    {
        conexionmanipulacion conexion = new conexionmanipulacion();
        public Frm_ReservacionHotel()
        {
            InitializeComponent();
            bloquer();
         
        }

        private void Frm_ReservacionHotel_Load(object sender, EventArgs e)
        {
            llenarcolumnas();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void lbl_tipo1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_tipo2_Click(object sender, EventArgs e)
        {

        }

        private void lbl_tipo3_Click(object sender, EventArgs e)
        {

        }

        private void lbl_tipo4_Click(object sender, EventArgs e)
        {

        }

        private void lbl_tipo5_Click(object sender, EventArgs e)
        {

        }

        //private void chb_habilitar4_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (chb_habilitar4.Checked == true)
        //    {

        //        cbo_tipo5.Enabled = true;
        //        txt_adultos5.Enabled = true;
        //        txt_niño5.Enabled = true;
        //        txt_descp5.Enabled = true;
        //        txt_cant5.Enabled = true;
        //        btn_habiespecifica5.Enabled = true;
        //    }
        //    else
        //    {
        //        cbo_tipo5.Enabled = false;
        //        txt_adultos5.Enabled = false;
        //        txt_niño5.Enabled = false;
        //        txt_descp5.Enabled = false;
        //        txt_cant5.Enabled = false;
        //        btn_habiespecifica5.Enabled = false;
        //    }
        //}

        //private void chb_habilitar3_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (chb_habilitar3.Checked == true)
        //    {

        //        cbo_tipo4.Enabled = true;
        //        txt_adultos4.Enabled = true;
        //        txt_niño4.Enabled = true;
        //        txt_descp4.Enabled = true;
        //        txt_cant4.Enabled = true;
        //        btn_habiespecifica4.Enabled = true;
        //    }
        //    else
        //    {
        //        cbo_tipo4.Enabled = false;
        //        txt_adultos4.Enabled = false;
        //        txt_niño4.Enabled = false;
        //        txt_descp4.Enabled = false;
        //        txt_cant4.Enabled = false;
        //        btn_habiespecifica4.Enabled = false;
        //    }
        //}

        private void gpb_reservacion_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void gpb_cliente_Enter(object sender, EventArgs e)
        {

        } 
        //funciones para llenar los diferentes columnas de reservacion
        public void llenarcolumnas()
        {
            try
            {
                
                conexion.getColumnas(cbo_tipo1, "tipo", "nivel_tipo");
                conexion.getColumnas(cbo_tipo2, "tipo", "nivel_tipo");
                conexion.getColumnas(cbo_tipo3, "tipo", "nivel_tipo");
                //conexion.getColumnas(cbo_tipo4, "tipo", "nivel_tipo");
                //conexion.getColumnas(cbo_tipo5, "tipo", "nivel_tipo");
                conexion.getColumnas(cbo_nombre, "cliente", "nombre");
       
               
            }

            catch(Exception ex)
            {
                MessageBox.Show("Ocurrio un error: " + ex);

            }
        }
        public void cargar1()
        {

            String r1 = "SELECT *from tipo WHERE nivel_tipo = '"+cbo_tipo1.Text+"';";
            if (cbo_tipo1.Text == "")
            {

            }
            else
            {
                conexion.llenartext(txt_niño1, r1, "ninios_tipo");
                conexion.llenartext(txt_adultos1, r1, "adultos_tipo");
                conexion.llenartext(txt_descp1, r1, "especificaciones_tipo");
                txt_niño1.ReadOnly = true;
                txt_adultos1.ReadOnly = true;
                txt_descp1.ReadOnly = true;

            }

        }
        public void cargar2()
        {

            String r1 = "SELECT *from tipo WHERE nivel_tipo = '" + cbo_tipo2.Text + "';";
            if (cbo_tipo1.Text == "")
            {

            }
            else
            {
                conexion.llenartext(txt_niño2, r1, "ninios_tipo");
                conexion.llenartext(txt_adultos2, r1, "adultos_tipo");
                conexion.llenartext(txt_descp2, r1, "especificaciones_tipo");
                txt_niño2.ReadOnly = true;
                txt_adultos2.ReadOnly = true;
                txt_descp2.ReadOnly = true;

            }
        }
        public void cargar3()
        {

            String r1 = "SELECT *from tipo WHERE nivel_tipo = '" + cbo_tipo3.Text + "';";
            if (cbo_tipo1.Text == "")
            {

            }
            else
            {
                conexion.llenartext(txt_niño3, r1, "ninios_tipo");
                conexion.llenartext(txt_adultos3, r1, "adultos_tipo");
                conexion.llenartext(txt_descp3, r1, "especificaciones_tipo");
                txt_niño3.ReadOnly = true;
                txt_adultos3.ReadOnly = true;
                txt_descp3.ReadOnly = true;

            }
        }
        //public void cargar4()
        //{

        //    String r1 = "SELECT *from tipo WHERE nivel_tipo = '" + cbo_tipo4.Text + "';";
        //    if (cbo_tipo1.Text == "")
        //    {

        //    }
        //    else
        //    {
        //        conexion.llenartext(txt_niño4, r1, "ninios_tipo");
        //        conexion.llenartext(txt_adultos4, r1, "adultos_tipo");
        //        conexion.llenartext(txt_descp4, r1, "especificaciones_tipo");
        //        txt_niño4.ReadOnly = true;
        //        txt_adultos4.ReadOnly = true;
        //        txt_descp4.ReadOnly = true;

        //    }
        //}
        //public void cargar5()
        //{

        //    String r1 = "SELECT *from tipo WHERE nivel_tipo = '" + cbo_tipo5.Text + "';";
        //    if (cbo_tipo1.Text == "")
        //    {

        //    }
        //    else
        //    {
        //        conexion.llenartext(txt_niño5, r1, "ninios_tipo");
        //        conexion.llenartext(txt_adultos5, r1, "adultos_tipo");
        //        conexion.llenartext(txt_descp5, r1, "especificaciones_tipo");
        //        txt_niño5.ReadOnly = true;
        //        txt_adultos5.ReadOnly = true;
        //        txt_descp5.ReadOnly = true;
        //    }
        //}


        private void cbo_tipo1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargar1();
        }

        private void cbo_tipo2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargar2();
        }

        private void cbo_tipo3_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargar3();
        }

        //private void cbo_tipo4_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    cargar4();
        //}

        //private void cbo_tipo5_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    cargar5();
        //}

        private void chb_habilitar1_CheckedChanged(object sender, EventArgs e)
        {

            if (chb_habilitar1.Checked == true)
            {

                cbo_tipo2.Enabled = true;
                txt_adultos2.Enabled = true;
                txt_niño2.Enabled = true;
                txt_descp2.Enabled = true;
                txt_cant2.Enabled = true;
                btn_habiespecifica2.Enabled = true;
            }
            else
            {
                cbo_tipo2.Enabled = false;
                txt_adultos2.Enabled = false;
                txt_niño2.Enabled = false;
                txt_descp2.Enabled = false;
                txt_cant2.Enabled = false;
                btn_habiespecifica2.Enabled = false;
            }
        }
        //bloque botones y campos
        public void bloquer()
        {
            txt_niño1.ReadOnly = true;
            txt_adultos1.ReadOnly = true;
            txt_adultos1.ReadOnly = true;
            txt_niño2.ReadOnly = true;
            txt_adultos2.ReadOnly = true;
            txt_adultos2.ReadOnly = true;
            txt_niño3.ReadOnly = true;
            txt_adultos3.ReadOnly = true;
            txt_adultos3.ReadOnly = true;
            //txt_niño4.ReadOnly = true;
            //txt_adultos4.ReadOnly = true;
            //txt_adultos4.ReadOnly = true;
            //txt_niño5.ReadOnly = true;
            //txt_adultos5.ReadOnly = true;
            //txt_adultos5.ReadOnly = true;
            cbo_tipo2.Enabled = false;
            txt_adultos2.Enabled = false;
            txt_niño2.Enabled = false;
          
            txt_cant2.Enabled = false;
            cbo_tipo2.Enabled = false;
            txt_adultos2.Enabled = false;
            txt_niño2.Enabled = false;
            txt_descp2.Enabled = false;
            txt_cant2.Enabled = false;
            btn_habiespecifica2.Enabled = false;
            cbo_tipo3.Enabled = false;
            txt_adultos3.Enabled = false;
            txt_niño3.Enabled = false;
            txt_descp3.Enabled = false;
            txt_cant3.Enabled = false;
            btn_habiespecifica3.Enabled = false;
            //cbo_tipo4.Enabled = false;
            //txt_adultos4.Enabled = false;
            //txt_niño4.Enabled = false;
            //txt_descp4.Enabled = false;
            //txt_cant4.Enabled = false;
            //btn_habiespecifica4.Enabled = false;
            //cbo_tipo5.Enabled = false;
            //txt_adultos5.Enabled = false;
            //txt_niño5.Enabled = false;
            //txt_descp5.Enabled = false;
            //txt_cant5.Enabled = false;
            //btn_habiespecifica5.Enabled = false;
 
            txt_totalapagar.ReadOnly = true;
        }

        private void chb_habilitar2_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_habilitar2.Checked == true)
            {

                cbo_tipo3.Enabled = true;
                txt_adultos3.Enabled = true;
                txt_niño3.Enabled = true;
                txt_descp3.Enabled = true;
                txt_cant3.Enabled = true;
                btn_habiespecifica3.Enabled = true;
            }
            else
            {
                cbo_tipo3.Enabled = false;
                txt_adultos3.Enabled = false;
                txt_niño3.Enabled = false;
                txt_descp3.Enabled = false;
                txt_cant3.Enabled = false;
                btn_habiespecifica3.Enabled = false;
            }
        }

        private void btn_habiespecifica1_Click(object sender, EventArgs e)
        {
            Frm_HabitacionesEspecificas rs = new Frm_HabitacionesEspecificas();
            rs.ShowDialog();
        }

        private void btn_habiespecifica2_Click(object sender, EventArgs e)
        {

        }

        private void lbl_capacidad3_Click(object sender, EventArgs e)
        {

        }

        private void txt_adultos3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txt_niño3_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_descripcion3_Click(object sender, EventArgs e)
        {

        }

        private void txt_descp3_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_cantidad3_Click(object sender, EventArgs e)
        {

        }

        private void txt_cant3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_habiespecifica3_Click(object sender, EventArgs e)
        {

        }
    }
}
