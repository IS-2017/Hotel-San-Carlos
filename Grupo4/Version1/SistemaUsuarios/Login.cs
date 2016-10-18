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

namespace SistemaUsuarios
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        private void Login_Load(object sender, EventArgs e)
        {   
            Conexion.Conexion.DSN = "prueba2";
            Conexion.Conexion.Host ="localhost";
            Conexion.Conexion.DataBase = "sancarlosprueba";
            Conexion.Conexion.Role = "root";
            Conexion.Conexion.PassWord = "";
        }

        private void btn_logear_Click(object sender, EventArgs e)
        {
            OdbcConnection con = Conexion.Conexion.ObtenerConexionODBC();

            string usuario = txt_usuario.Text.Trim();
            string contraseña = txt_contraseña.Text.Trim();

            string consulta = "select usr, pswd from usuario where usr = '"+usuario+"' ";
            OdbcCommand comando = new OdbcCommand(consulta ,con);
            OdbcDataAdapter adaptador = new OdbcDataAdapter(comando);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);

            if(dt.Rows.Count > 0)
            {
                DataRow fila = dt.Rows[0];
                String usuariobd = fila[0].ToString();
                String contraseñabd = fila[1].ToString();

                if(contraseña == contraseñabd)
                {
                    Conexion.Conexion.Role = usuariobd;
                    Conexion.Conexion.PassWord = contraseñabd;
                    MessageBox.Show("Bienvenido");
                }
                else { MessageBox.Show("contraseña incorrecta"); }
                

            }
            else { MessageBox.Show("Usuario inexistente"); }



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
