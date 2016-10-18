using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1
{
    public partial class vista_general : Form
    {
        
        
        public vista_general()
        {
            InitializeComponent();
        }
        MySqlConnection conectar = new MySqlConnection("server=localhost; user=root; database =hotel");
         
        String tabla = "cliente";
        String Query;
        String Columnas;
        String nColumnas;
        private void CracionDeTextbox(){
            try
            {
               
              
                Columnas = "SELECT count(*) FROM information_schema.`COLUMNS` C WHERE table_name = 'cliente' AND TABLE_SCHEMA = 'hotel'";

                
              
                MySqlCommand cmd = new MySqlCommand(Columnas, conexion.obtenerConexion());
                 nColumnas = cmd.ExecuteScalar().ToString();

                
        
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

   
        private void CargarData()
        {

            try
            {

            //    conexion.obtenerConexion().Open();
                conectar.Open();
                Query = "Select * From " + tabla + "";


            
             //MySqlDataAdapter DtCliente = new MySqlDataAdapter(Query, conexion.obtenerConexion());
                MySqlDataAdapter DtCliente = new MySqlDataAdapter(Query, conectar);
                MySqlDataAdapter columna = new MySqlDataAdapter(Columnas, conectar);
                DataSet dsCliente = new DataSet();
                DtCliente.Fill(dsCliente, tabla);

                dgb_cliente.DataSource = dsCliente;
                dgb_cliente.DataMember = tabla;
              //  conexion.obtenerConexion().Close();
                conectar.Close();
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error de insercion" + e.ToString());          //si el try-catch encontro algun error indica mensaje de fracaso
            }

  
        }

        private void vista_general_Load(object sender, EventArgs e)
        {
            CargarData();
            CracionDeTextbox();
      

           }
        private void dgb_cliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           /* int columnas = Int32.Parse(nColumnas);
             TextBox txt = new TextBox();

            for (int i = 1; i <= columnas; i++)
            {
               
                txt = new TextBox();
                txt.Height = 15;
                txt.Width = 100;
                txt.Location = new System.Drawing.Point(25, i * 25);
                txt.Name = "Textbox" + i;
                txt.Text = "Textbox" + i;
         
                Controls.Add(txt);
                panel1.Controls.Add(txt);

            }*/

                    while (e.RowIndex != 0)
            {
                DataGridViewRow row = this.dgb_cliente.Rows[e.RowIndex];
                textBox1.Text = row.Cells["id_cliente_pk"].Value.ToString();
                textBox2.Text = row.Cells["nombre"].Value.ToString();
                textBox3.Text = row.Cells["apellido"].Value.ToString();
                textBox4.Text = row.Cells["nit"].Value.ToString();
                textBox5.Text = row.Cells["direccion"].Value.ToString();
                textBox6.Text = row.Cells["fecha_nacimiento"].Value.ToString();
            }
            
        
           
        }

        private void dgb_cliente_C(object sender, DataGridViewCellEventArgs e)
        {

    
        }

        private void dgb_cliente_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //this.Hide();
            //detalle especifico = new detalle(nColumnas);
            //especifico.ShowDialog();
            //MessageBox.Show("el total de columnas es: " + nColumnas);
                
            

            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dgb_cliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            while (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgb_cliente.Rows[e.RowIndex];
                textBox1.Text = row.Cells["id_cliente_pk"].Value.ToString();
                textBox2.Text = row.Cells["nombre"].Value.ToString();
                textBox3.Text = row.Cells["apellido"].Value.ToString();
                textBox4.Text = row.Cells["nit"].Value.ToString();
                textBox5.Text = row.Cells["direccion"].Value.ToString();
                textBox6.Text = row.Cells["fecha_nacimiento"].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
      
        }

    
    }
}
