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
using MySql.Data.MySqlClient;

namespace ModuloAdminHotel
{
    public partial class Frm_CheckOut : Form
    {
        conexionmanipulacion con = new conexionmanipulacion();
        //MySqlConnection conexion1 = new MySqlConnection("database=hotelsancarlos; server=192.168.0.120; uid=root; pwd=lucario;");

        string clienteselec;
        public Frm_CheckOut()
        {
            InitializeComponent();
        }

        private void Frm_CheckOut_Load(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                String Query = "select id_cliente_pk,nombre,apellido from cliente;";
                OdbcDataAdapter dad = new OdbcDataAdapter(Query, con.rutaconectada());
                dad.Fill(ds, "cliente");
                cbo_cliente.DataSource = ds.Tables[0].DefaultView;
                cbo_cliente.ValueMember = ("id_cliente_pk");

                DataTable dt = ds.Tables[0];
                dt.Columns.Add("NewColumn", typeof(string));

                foreach (DataRow dr in dt.Rows)
                {
                    dr["nombre"] = dr["nombre"].ToString() + " " + dr["apellido"].ToString();
                }
                cbo_cliente.DataSource = dt;
                cbo_cliente.DisplayMember = ("nombre");

                //cbo_cliente.ValueMember = ("id_cliente_pk");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Los datos no cargaron de forma correcta" + ex, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void cbo_cliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clienteselec = cbo_cliente.SelectedValue.ToString();


            string query = "select * from folio where id_cliente_pk="+clienteselec+";";
            string tabla = "folio";
            CapaNegocio fn = new CapaNegocio();
            fn.ActualizarGrid(dataGridView1, query, tabla);

            string query1 = "select costo from folio where id_cliente_pk=" + clienteselec + " and fecha_ingreso=curdate();";
            EjecutarQuery1(query1);
            

        }


        public void EjecutarQuery(String Query)
        {
            OdbcCommand comando = new OdbcCommand(Query, con.rutaconectada());
            int Ifilasafectadas = comando.ExecuteNonQuery();
            ;
            if (Ifilasafectadas > 0)
                MessageBox.Show("Operacion realizada con exitosamente");
        }

        public void EjecutarQuery1(String Query)
        {
            OdbcCommand comando = new OdbcCommand(Query, con.rutaconectada());
            string resultado = Convert.ToString(comando.ExecuteScalar());
            label2.Text = "El monto a pagar es de: "+resultado;
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            string query2 = "update folio set estado='PAGADO', fecha_pago=CURRENT_DATE where id_cliente_pk=" + clienteselec+";";
            EjecutarQuery(query2);

            String query1 = "Select count(*) from reservacion_habitacion rh, habitacion h where rh.id_cliente_pk=" + clienteselec + " and rh.id_habitacion_pk=h.id_habitacion_pk and rh.fecha_entreda=curdate();";
            int validacion1 = Convert.ToInt32(con.verificacionhabitaicon(query1));
            for (int a = 1; a <= validacion1; a++)
            {


                String query4 = "select nombre from habitacion where id_habitacion_pk=" + a + ";";
                checkedListBox1.Items.Add(con.verificacionhabitaicon(query4));


            }
            foreach (var item in checkedListBox1.Items)
            //foreach (string s in checkedListBox1.CheckedItems)
            {
                //MessageBox.Show(item.ToString());

                string query = "update habitacion set estado='ACTIVADO' where nombre='" + item.ToString() + "';";
                EjecutarQuery(query);
            }

            string query3 = "update reservacion_habitacion set estado='INACTIVO' where id_cliente_pk=" + clienteselec + ";";
            EjecutarQuery(query3);


        }
    }
}
