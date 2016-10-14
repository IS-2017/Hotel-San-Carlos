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

namespace ObjetoComunConsultasInteligentes
{
    public partial class guardarNombre : Form

    {
        string consulta;
        public guardarNombre(string consulta)
        {
            this.consulta = consulta;
            InitializeComponent();
        }

        MySqlConnection conexion = new MySqlConnection("server=localhost; database=bdcinetopia; Uid=root; pwd=;");

        private void button1_Click(object sender, EventArgs e)
        {
            insert();
        }

        private void guardarNombre_Load(object sender, EventArgs e)
        {

        }

        private void insert()
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Llene los campos por favor");
                MessageBox.Show(consulta);
            }
            else
            {

                try
                {
                    conexion.Open();
                    String Squery = "insert into  consultaguardada (idform,nombre,descripcion) values( 'C','" + textBox1.Text + "', '" + consulta + "');";
                    MySqlCommand comando = new MySqlCommand(Squery, conexion);
                    int Ifilasafectadas = comando.ExecuteNonQuery();
                    if (Ifilasafectadas > 0)
                        MessageBox.Show("Operacion realizada con exitosamente");
                    conexion.Close();
                    this.Close();
                    //this.Hide();
                    //Form1 r = new Form1();
                    //r.ShowDialog();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.TargetSite);
                    MessageBox.Show("Error al Guardar");
                }
            }
        }

        private void btn_cancelarGuardar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
