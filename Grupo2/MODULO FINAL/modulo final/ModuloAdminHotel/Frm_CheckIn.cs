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
using FuncionesNavegador;
using System.Data.Odbc;

namespace ModuloAdminHotel
{
    public partial class Frm_CheckIn : Form
    {

        conexionmanipulacion con = new conexionmanipulacion();
        string clienteseleccionado;
        public List<string> cuartoseleccionado = new List<string>();

        int contador = 0;


        public Frm_CheckIn()
        {
            InitializeComponent();
        }

        private void Frm_CheckIn_Load(object sender, EventArgs e)
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

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            clienteseleccionado = cbo_cliente.SelectedValue.ToString();
            //MessageBox.Show(clienteseleccionado);

            DataSet ds1 = new DataSet();
            String Query1 = "select rh.fecha_entreda, rh.id_cliente_pk, rh.id_habitacion_pk, h.nombre from reservacion_habitacion rh, habitacion h where rh.id_cliente_pk="+clienteseleccionado+" and rh.id_habitacion_pk=h.id_habitacion_pk and rh.fecha_entreda=curdate();";
            OdbcDataAdapter dad1 = new OdbcDataAdapter(Query1, con.rutaconectada());
            dad1.Fill(ds1, "reservacion_habitacion");

           
            checkedListBox1.DataSource = ds1.Tables[0].DefaultView;
            checkedListBox1.ValueMember = ("id_habitacion_pk");
            checkedListBox1.DisplayMember = ("nombre");
            

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String Squery = "insert into  folio (estado,fecha_ingreso,costo,id_cliente_pk) values('Pendiente',Sysdate(),'0.00','" + clienteseleccionado + "');";

            EjecutarQuery(Squery);

            //for(int i=0; i <= checkedListBox1.Items.Count - 1; i++)
            //{
            //    string c = "";
            //    string nc = "";

            //    if (checkedListBox1.CheckedItems.)
            //    {

            //    }
            //}


            if (checkedListBox1.CheckedItems.Count != 0)
            {
                string s = "";
                string n="";
                for (int x = 0; x <= checkedListBox1.CheckedItems.Count - 1; x++)
                {
                    s = s + "Checked Item " + (x + 1).ToString() + " = " + checkedListBox1.CheckedItems[x].ToString() + "\n";
                    n = checkedListBox1.SelectedValue.ToString();

                    string query = "update habitacion set estado='OCUPADO' where id_habitacion_pk="+n+";";
                    EjecutarQuery(query);

                    //MessageBox.Show(n.ToString());
                    // m = checkedListBox1.SelectedItem[x].ToString();                                      
                }
                MessageBox.Show(s);
                MessageBox.Show(n);
            }
            
        }

        public void EjecutarQuery(String Query)
        {
            OdbcCommand comando = new OdbcCommand(Query, con.rutaconectada());
            int Ifilasafectadas = comando.ExecuteNonQuery();
            ;
            if (Ifilasafectadas > 0)
                MessageBox.Show("Operacion realizada con exitosamente");
        }

        private void cbo_cliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
