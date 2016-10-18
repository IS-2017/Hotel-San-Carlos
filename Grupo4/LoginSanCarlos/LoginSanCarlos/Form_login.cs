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
using Conexion;
using System.Data.Odbc;

namespace LoginSanCarlos
{
    public partial class Form_login : Form
    {
        public Form_login()
        {
            InitializeComponent();
        }

        private void Form_login_Load(object sender, EventArgs e)
        {   
            Conexion.Conexion.DSN = "prueba2";
            Conexion.Conexion.Host ="localhost";
            Conexion.Conexion.DataBase = "sancarlos2";
            Conexion.Conexion.Role = "root";
            Conexion.Conexion.PassWord = "1234";
        }

        private void btn_logear_Click(object sender, EventArgs e)
        {
            OdbcConnection con = Conexion.Conexion.ObtenerConexionODBC();

            string usuario = txt_usuario.Text.Trim();
            string contraseña = txt_contraseña.Text.Trim();

           string consulta = "select ValidarContraseña('"+usuario+"', '"+contraseña+"') ";
            OdbcCommand comando = new OdbcCommand(consulta ,con);
            object resultado = comando.ExecuteScalar();
        
            if(Convert.ToInt16(resultado)==1)
            {
                MessageBox.Show("logeo exitoso");
            }
            else
               {
                MessageBox.Show("fallo :(");
               }


            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // MySqlConnection  con = Conexion.Conexion.ObtenerConexionMYSQL();
            OdbcConnection con = new OdbcConnection();
            // con.ConnectionString = "dsn=prueba2; UID=cvbcvcvfdgdd; PWD=; ";
            con.ConnectionString = "dsn=prueba2; server=localhost; database=sancarlosprueba; Uid=root; pwd=;";
            //con.ConnectionString = "dsn=prueba2";
            con.Open();
           // if (con != null)
           if(con.State == ConnectionState.Open )
            {
                MessageBox.Show("conexion exitosa");
            }else { MessageBox.Show("no hay conexion"); }
        }
    }
}
