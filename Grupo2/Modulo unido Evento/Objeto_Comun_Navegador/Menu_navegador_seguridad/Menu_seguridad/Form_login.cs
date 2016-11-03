using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using seguridad;



using System.Data.Odbc;

/*
 Autor: Yony Calito
 UD:11/10/2016
     */

namespace Menu_seguridad
{
    public partial class Form_login : Form
    {
        public Form_login()
        {
            InitializeComponent();
        }

        private void Form_login_Load(object sender, EventArgs e)
        {
            
            seguridad.Conexion.DSN = "prueba2";
            //seguridad.Conexion.User = "root";
            //seguridad.Conexion.PassWord = "1234";


            txt_contraseña.PasswordChar = '*';
        }

        private void btn_logear_Click(object sender, EventArgs e)
        {
            // OdbcConnection con = seguridad.Conexion.ObtenerConexionODBC();
            OdbcConnection con = Conexion.ConexionPermisos();

            string usuario = txt_usuario.Text.Trim();
            string contraseña = txt_contraseña.Text.Trim();
            ClaseTomaIp ip = new ClaseTomaIp();
            string localIP = ip.direccion();

            /****LLama a una funciòn almacenada que valida la existencia del usuario y la integridad de la contraseña****/
            try
            {
                string consulta = "select ValidarContrasena('" + usuario + "', '" + contraseña + "','" + localIP + "') ";
                OdbcCommand comando = new OdbcCommand(consulta, con);
                object resultado = comando.ExecuteScalar();
                if (Convert.ToInt16(resultado) == 1) //esto nos indica que la validaciòn ha sido correcta por parte de la funciòn almacenada
                {
                   // seguridad.LlegarSeguridad.EstablecerUsuario(usuario);
                    seguridad.Conexion.User= usuario;
                    seguridad.Conexion.PassWord = contraseña;
                    MessageBox.Show("loggeo exitoso");
                    menu_seguridad men_seg = new menu_seguridad();
                    men_seg.Show();
                    txt_contraseña.Clear();
                    txt_usuario.Clear();
                    
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario y/o contraseña invàlidos"); //De lo contrario, si la contraseña es incorrecta o el usuario, nos devuelve el fallo
                    txt_contraseña.Clear();
                    //txt_usuario.Clear();
                }

        }
            catch
            {
                txt_contraseña.Clear();
                txt_usuario.Clear();
                txt_usuario.Focus();
                MessageBox.Show("Usuario no existe");
            }



    con.Close();
        }

        private void txt_contraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btn_logear.PerformClick();
            }
        }

        /*
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
        }^*/
    }
}
