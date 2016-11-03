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
using System.Data.Odbc;
namespace ModuloAdminHotel
{
    public partial class Frm_ReservacionHotel : Form
    {
        conexionmanipulacion conexion = new conexionmanipulacion();
        public Frm_ReservacionHotel()
        {
            InitializeComponent();
            bloquer();
            fechaentrada.MinDate = DateTime.Today;
            fechasalida.MinDate = DateTime.Today;
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


        private void gpb_reservacion_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void gpb_cliente_Enter(object sender, EventArgs e)
        {

        }
        private void cbo_tipo1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            cargar1();

            fechaentrada.Format = DateTimePickerFormat.Custom;
            fechaentrada.CustomFormat = "yyyy-MM-dd";
            string rs = fechaentrada.Text;
            fechaentrada.Format = DateTimePickerFormat.Custom;
            fechaentrada.CustomFormat = "dd-MM-yyyy";

            //
            fechasalida.Format = DateTimePickerFormat.Custom;
            fechasalida.CustomFormat = "yyyy-MM-dd";
            string rf= fechasalida.Text;
            fechasalida.Format = DateTimePickerFormat.Custom;
            fechasalida.CustomFormat = "dd-MM-yyyy";
          
            ckl_reservacion.Items.Clear();
            llenarcheck(cbo_tipo1, rs, rf);

            ckl_reservacion.Enabled = false;
            txt_cant1.Enabled = true;
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
        private void cbo_codigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenarcomboboxcodigo();
        }
        private void cbo_nombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenarcomboboxnombre();
        }
        private void cbo_dpi_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenarcomboboxdpi();
        }

        private void cbo_nit_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenarcomboboxnit();
        }
        //funciones
        //bloquea los botones, texto
        public void bloquer()
        {
            txt_niño1.ReadOnly = true;
         txt_adultos1.ReadOnly = true;
            txt_cant1.Enabled = false;
            fechasalida.Enabled = false;
   
            txt_totalapagar.ReadOnly = true;
        }
        //permite llemnar el combobox nombre con la concatenacion del nombre y el apellido
        public void llenarcbonombre(String Query)
        {

            MySqlCommand cm = new MySqlCommand(Query, conexion.rutaconectada());
            MySqlDataReader adaptador = cm.ExecuteReader();
            while (adaptador.Read())
            {
                cbo_nombre.Items.Add(adaptador["nombre"].ToString() + " " + adaptador["apellido"].ToString());

            }
            adaptador.Close();

        }
        public void llenartipo()
        {
            MySqlCommand cm = new MySqlCommand("SELECT  nivel_tipo FROM  tipo_habitacion where estado='activo';", conexion.rutaconectada());
            MySqlDataReader adaptador = cm.ExecuteReader();
            while (adaptador.Read())
            {
                cbo_tipo1.Items.Add(adaptador["nivel_tipo"].ToString());

            }
            adaptador.Close();
        }
        //llena los combobox del form
        public void llenarcolumnas()
        {
            try
            {
  
                llenartipo();
                conexion.getColumnas(cbo_codigo, "cliente", "id_cliente_pk");
                conexion.getColumnas(cbo_nit, "cliente", "nit");
                conexion.getColumnas(cbo_dpi, "cliente", "dpi");
                llenarcbonombre("SELECT * from cliente;");

            }

            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error: " + ex);

            }
        }
        //carga los textbox de acuerdo al combobx tipo1 en el area de reservacion
        public void cargar1()
        {

            String r1 = "SELECT ninio_tipo,adulto_tipo,especificaciones_tipo from tipo_habitacion WHERE nivel_tipo = '" + cbo_tipo1.Text + "';";
            if (cbo_tipo1.Text != "")
            {
                conexion.llenartext(txt_niño1, r1, "ninio_tipo");
                conexion.llenartext(txt_adultos1, r1, "adulto_tipo");
                conexion.llenartext(txt_descp1, r1, "especificaciones_tipo");
                txt_niño1.ReadOnly = true;
                txt_adultos1.ReadOnly = true;
                txt_descp1.ReadOnly = true;
            }
     

        }

        public void llenarcomboboxcodigo()
        {
            try
            {
                if (cbo_codigo.Text != "")
                {
                    int s = cbo_codigo.SelectedIndex;
                    cbo_nombre.SelectedIndex = s;
                    cbo_dpi.SelectedIndex = s;
                    cbo_nit.SelectedIndex = s;
                }
              
            }
            catch (Exception ex)
            {
                MessageBox.Show("error:" + ex);
            }
        }
        //permite cambiar los combobox del cliente de acuerdo al combobox nombre
        public void llenarcomboboxnombre()
        {
            try
            {
                if (cbo_nombre.Text != "")
                {

                    int f = cbo_nombre.SelectedIndex;
                    cbo_codigo.SelectedIndex = f;
                    cbo_dpi.SelectedIndex = f;
                    cbo_nit.SelectedIndex = f;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error:" + ex);
            }
        }
        //permite cambiar los combobox del cliente de acuerdo al combobox dpi

        public void llenarcomboboxdpi()
        {
            try
            {
                if (cbo_dpi.Text != "")
                {

                    int s = cbo_dpi.SelectedIndex;
                    cbo_codigo.SelectedIndex = s;
                    cbo_nombre.SelectedIndex = s;
                    cbo_nit.SelectedIndex = s;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error:" + ex);
            }
        }
        //permite cambiar los combobox del cliente de acuerdo al combobox nit
        public void llenarcomboboxnit()
        {
            try
            {
                if (cbo_nit.Text != "")
                {
                    int s = cbo_nit.SelectedIndex;
                    cbo_codigo.SelectedIndex = s;
                    cbo_dpi.SelectedIndex = s;
                    cbo_nombre.SelectedIndex = s;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error:" + ex);
            }
        }

        private void txt_acompañantes_KeyPress(object sender, KeyPressEventArgs e)
        {
            

        }
        private void txt_acompañantes_TextChanged(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_descp2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_descp1_TextChanged(object sender, EventArgs e)
        {

        }
        // solo permite ingresar numeros
        private void txt_acompañantes_KeyPress_1(object sender, KeyPressEventArgs e)
        {

            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Este campo solo debe llevar numero", "validacion de letras", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Este campo solo debe llevar numero", "validacion de letras", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dtp_entrada_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        { 
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
        //validacion de fechas que no puedan ingresar menos que la del sistema
        private void fechaentrada_ValueChanged(object sender, EventArgs e)
        {
            fechasalida.Enabled = true;
            fechasalida.MinDate = fechaentrada.Value;
            if (cbo_tipo1.Text!="")
            {
                fechaentrada.Format = DateTimePickerFormat.Custom;
                fechaentrada.CustomFormat = "yyyy-MM-dd";
                string rs = fechaentrada.Text;
                fechaentrada.Format = DateTimePickerFormat.Custom;
                fechaentrada.CustomFormat = "dd-MM-yyyy";

                //
                fechasalida.Format = DateTimePickerFormat.Custom;
                fechasalida.CustomFormat = "yyyy-MM-dd";
                string rf = fechasalida.Text;
                fechasalida.Format = DateTimePickerFormat.Custom;
                fechasalida.CustomFormat = "dd-MM-yyyy";

                ckl_reservacion.Items.Clear();
                llenarcheck(cbo_tipo1, rs, rf);

            }
        }
        //la fecha cambia de acuerdo a la de entrada
        private void fechasalida_ValueChanged(object sender, EventArgs e)
        {
            fechaentrada.MinDate = DateTime.Today;
            if (cbo_tipo1.Text != "")
            {
                fechaentrada.Format = DateTimePickerFormat.Custom;
                fechaentrada.CustomFormat = "yyyy-MM-dd";
                string rs = fechaentrada.Text;
                fechaentrada.Format = DateTimePickerFormat.Custom;
                fechaentrada.CustomFormat = "dd-MM-yyyy";

                fechasalida.Format = DateTimePickerFormat.Custom;
                fechasalida.CustomFormat = "yyyy-MM-dd";
                string rf = fechasalida.Text;
                fechasalida.Format = DateTimePickerFormat.Custom;
                fechasalida.CustomFormat = "dd-MM-yyyy";

                ckl_reservacion.Items.Clear();
                llenarcheck(cbo_tipo1, rs, rf);

            }
        }

        private void txt_adultos2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_adultos1_TextChanged(object sender, EventArgs e)
        {

        }
        //solo permite ingresar numeros en los textbox
        private void txt_cant1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Este campo solo debe llevar numero", "validacion de letras", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txt_cant2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Este campo solo debe llevar numero", "validacion de letras", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        
        private void txt_cant3_KeyPress(object sender, KeyPressEventArgs e)
        {
                if (char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
               
                }
                else if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                
                }
                else
                {
                    e.Handled = true;
                    MessageBox.Show("Este campo solo debe llevar numero", "validacion de letras", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
      
        private void txt_cant1_TextChanged(object sender, EventArgs e)
        {
            if (txt_cant1.Text == ""|| txt_cant1.Text == "0")
            {
                ckl_reservacion.Enabled = false;
            }
            else
            {
                int s = Convert.ToInt32(txt_cant1.Text);
                int f = Convert.ToInt32(ckl_reservacion.Items.Count.ToString());
                if (f < s)
                {
                    MessageBox.Show("No hay habitaciones suficientes");
                     ckl_reservacion.Enabled = false;
                }
                else
                {
                    ckl_reservacion.Enabled = true;
                }
            }
        }


        private void ckl_reservacion_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void ckl_reservacion_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void lbl_cantidad1_Click(object sender, EventArgs e)
        {

        }

        //hace el filtro para verificar si una habitacione sta disponible

        public void llenarcheck(ComboBox cb, string entrada, String salida)
        {
            String query1 = "select count(*) from habitacion;";
            int validacion1 = Convert.ToInt32(conexion.verificacionhabitaicon(query1));
            for (int a=1; a<=validacion1; a++)
            {
                String query2 = "Select count(*) from habitacion a, tipo_habitacion b where a.id_habitacion_pk=" + a + " and b.nivel_tipo='" + cb.Text + "'and a.id_tipo_Pk = b.id_tipo_pk and a.estado='activo';";
                int validacion2 = Convert.ToInt32(conexion.verificacionhabitaicon(query2));
                if(validacion2>0)
                {
                    String query3 = "SELECT count(*) from reservacion_habitacion where id_habitacion_pk =" + a + " and fecha_entreda >= '" + entrada + "'and fecha_entreda < '" + salida + "' and estado='reservado' or  id_habitacion_pk =" + a + " and fecha_entreda >= '" + entrada + "'and fecha_entreda < '" + salida + "' and estado='ocupado' or id_habitacion_pk =" + a + " and fecha_entreda <'" + entrada + "' and fecha_salida>'" + entrada + "' and estado='reservado' or id_habitacion_pk =" + a + " and fecha_entreda <'" + entrada + "' and fecha_salida>'" + entrada + "' and estado='ocupado' or id_habitacion_pk =" + a + " and  fecha_entreda<'" + entrada + "' and fecha_salida > '" + salida + "' and estado ='reservado'or id_habitacion_pk =" + a + " and  fecha_entreda<'" + entrada + "' and fecha_salida > '" + salida + "' and estado ='ocupado';";
                    int validacion3 = Convert.ToInt32(conexion.verificacionhabitaicon(query3));
                    if (validacion3==0)
                    {
                        String query4 = "Select nombre from habitacion where id_habitacion_pk=" + a + ";";
                        ckl_reservacion.Items.Add(conexion.verificacionhabitaicon(query4));
                    }
                    
                }
              
            }
        }

    }
}
