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


namespace ModuloAdminHotel
{
    public partial class Frm_Evento : Form
    {
        conexionmanipulacion con = new conexionmanipulacion();
        String Codigo;
        Boolean Editar;
        String atributo;
        int costototal;
        int costopaquete;
        int costosalon;
        public string[] codigo;
        public Frm_Evento()
        {
            InitializeComponent();
        }
        private void ComboxDPI()
        {
            try
            {

                con.Conectar();
                //se inicia un DataSet
                DataSet ds = new DataSet();
                //se indica la consulta en sql
                String Query = "select id_cliente_pk,dpi,nit,nombre from cliente;";
                MySqlDataAdapter dad = new MySqlDataAdapter(Query, con.rutaconectada());
                //se indica con quu tabla se llena
                dad.Fill(ds, "cliente");
                cbxcliente.DataSource = ds.Tables[0].DefaultView;
                //indicamos el valor de los miembros
                cbxcliente.ValueMember = ("id_cliente_pk");
               
                //se indica el valor a desplegar en el combobox
                cbxcliente.DisplayMember = ("dpi");

                //  String nit = "SELECT `nit` FROM `cliente` WHERE `id_cliente_pk`= '" + cbxcliente.Text + "'";
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Los datos no cargaron de forma correcta" + ex, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //------------------------------------------------------------------------------------------
        private void ComboxSanlon()
        {
            try
            {

                con.Conectar();
                //se inicia un DataSet
                DataSet ds = new DataSet();
                //se indica la consulta en sql
                String Query = "select id_salon_pk,nombre from salon;";
                MySqlDataAdapter dad = new MySqlDataAdapter(Query, con.rutaconectada());
                //se indica con quu tabla se llena
                dad.Fill(ds, "salon");
                cbxSalon.DataSource = ds.Tables[0].DefaultView;
                //indicamos el valor de los miembros
                cbxSalon.ValueMember = ("id_salon_pk");
                //se indica el valor a desplegar en el combobox
                cbxSalon.DisplayMember = ("nombre");
                con.Desconectar();
                //para ingresar el combobox
                // string combosalon = cbxSalon.SelectedValue.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Los datos no cargaron de forma correcta" + ex, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //---------------------------------------_________________________Combobox_Promosiones_______________________________--------------------------
        private void cb7()
        {
            try
            {
                con.Conectar();
                //se inicia un DataSet
                DataSet ds = new DataSet();
                //se indica la consulta en sql
                String Query = "select id_promocion_pk,nombre from promocion;";
                MySqlDataAdapter dad = new MySqlDataAdapter(Query, con.rutaconectada());
                //se indica con quu tabla se llena
                dad.Fill(ds, "promocion");
                cbxpaquete.DataSource = ds.Tables[0].DefaultView;
                //indicamos el valor de los miembros
                cbxpaquete.ValueMember = ("id_promocion_pk");
                //se indica el valor a desplegar en el combobox
                cbxpaquete.DisplayMember = ("nombre");
                con.Desconectar();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Los datos no cargaron de forma correcta" + ex, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
       
        private void Frm_Evento_Load(object sender, EventArgs e)
        {
            ComboxDPI();
            cb7();
            ComboxSanlon();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                cbxpaquete.Enabled = true;
                txtdescripcion.Enabled = true;
            }
            else
            {

                cbxpaquete.Enabled = false;
                txtdescripcion.Enabled = false;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (datFechaInicio.Value < datFechaFinal.Value)
            {
              

                    txtFechaInicio.Text = datFechaInicio.Value.ToString("yyyy-MM-dd");

                    txtFechaFinal.Text = datFechaFinal.Value.ToString("yyyy-MM-dd");


                    txtHoraFecha.Text = cbxHoraInicio.Text;
                    txtHoraInicio.Text = cbxHoraFinal.Text;
                    txtsalon.Text = cbxSalon.SelectedValue.ToString();
                    txtdpi.Text = cbxcliente.SelectedValue.ToString();
                 //   txtpromosion.Text = cbxpaquete.SelectedValue.ToString();




                    capadenegocioe fn = new capadenegocioe();
                    TextBox[] textbox = { txtevento, txtFechaInicio, txtFechaFinal, txtHoraFecha, txtHoraInicio, txtdpi , txtsalon,txtCosto};
                    DataTable datos = fn.construirDataTable(textbox);
                    if (datos.Rows.Count == 0)
                    {
                        MessageBox.Show("Hay campos vacios", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string tabla = "evento";
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


         
            
            else
            {
                MessageBox.Show("verifique la fecha por favor");
            }
        
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string tabla = "evento";
            capadenegocioe fn = new capadenegocioe();
            fn.ActualizarGrid(this.dataGridView3, "Select * from evento",tabla);
        }

        private void datFechaFinal_ValueChanged(object sender, EventArgs e)
        {

            if (datFechaInicio.Value > datFechaFinal.Value)
            { 
            }
        }

        private void cbxcliente_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cbxcliente_TextChanged(object sender, EventArgs e)
        {
            MySqlCommand comando = new MySqlCommand();
            String Query2 = "select dpi,nit,nombre from cliente where dpi= '" + cbxcliente.Text + "'";

            comando.Connection = con.rutaconectada();

            comando.CommandText = Query2;

            MySqlDataReader leer = comando.ExecuteReader();

            if (leer.HasRows)
            {
                while (leer.Read())
                {
                    leer.Read();

                    txtNit.Text = leer["nit"].ToString();
                    txtnombrecliente.Text = leer["nombre"].ToString();

                }
                con.Desconectar();
            }
              

        }
        //---------------------------------------busqueda y descripcion de promociones---------------------------------------------
        private void cbxpaquete_TextChanged(object sender, EventArgs e)
        {
            costopaquete = 0;
            MySqlCommand comando = new MySqlCommand();
            String Query2 = "select detalle,costo from promocion where nombre= '" + cbxpaquete.Text + "'";

            comando.Connection = con.rutaconectada();

            comando.CommandText = Query2;

            MySqlDataReader leer = comando.ExecuteReader();

            if (leer.HasRows)
            {
                while (leer.Read())
                {
                    leer.Read();

                    txtdescripcion.Text = leer["detalle"].ToString();

                  string  Costopaquete = leer["costo"].ToString();
                  costopaquete = int.Parse(Costopaquete);
                    costototal = costototal + costopaquete;
                    txtCosto.Text = costototal.ToString();

                   // int costopaquete = int.Parse(txtCosto.Text);
                }
               
                con.Desconectar();
            }

        }

        private void cbxpaquete_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxSalon_TextChanged(object sender, EventArgs e)
        {
            costosalon = 0;
            MySqlCommand comando = new MySqlCommand();
            String Query2 = "select costo from salon where nombre= '" + cbxSalon.Text + "'";

            comando.Connection = con.rutaconectada();

            comando.CommandText = Query2;

            MySqlDataReader leer = comando.ExecuteReader();

            if (leer.HasRows)
            {
                while (leer.Read())
                {
                    leer.Read();

           

                    string CostoSalon = leer["costo"].ToString();
                    costosalon = int.Parse(CostoSalon);
                    costototal = costototal + costosalon;
                    txtCosto.Text = costototal.ToString();

                    // int costopaquete = int.Parse(txtCosto.Text);
                }

                con.Desconectar();
            }


        }
    }
}
