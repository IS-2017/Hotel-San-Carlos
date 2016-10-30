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

namespace LoginSanCarlos
{
    public partial class form2 : Form
    {
        public form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OdbcConnection con = Conexion.Conexion.ObtenerConexionODBC();
            string consulta = "select * from usuario";
            OdbcCommand comando = new OdbcCommand(consulta, con);
            OdbcDataAdapter adaptador = new OdbcDataAdapter(comando);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OdbcConnection con = Conexion.Conexion.ObtenerConexionODBC();
            string consulta = "select * from producto";
            OdbcCommand comando = new OdbcCommand(consulta, con);
            OdbcDataAdapter adaptador = new OdbcDataAdapter(comando);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView2.DataSource = dt;
        }
    }
}
