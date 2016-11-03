using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Security.Cryptography;
using seguridad;
using System.Data.Odbc;


namespace Prototipo__RRHH
{
    public partial class Login_Prueba : Form
    {
        public Login_Prueba()
        {
            InitializeComponent();
        }

        private const string ayudaCHM = "Ayuda-Modulo-RRHH.chm";
        private const string inicioSesion = "Introduction.htm";
        Login_Prueba login;
        

        private void Btn_Inicio_secion_Click(object sender, EventArgs e)
        {
            // OdbcConnection con = seguridad.Conexion.ObtenerConexionODBC();
            OdbcConnection con = Conexion.ConexionPermisos();
            seguridad.SistemaUsuarioDatos ss = new SistemaUsuarioDatos();
            string usuario = txt_user.Text.Trim();
            string contraseña = ss.Encriptar(txt_pass.Text.Trim());
            ClaseTomaIp ip = new ClaseTomaIp();
            string localIP = ip.direccion();

            /****LLama a una funciòn almacenada que valida la existencia del usuario y la integridad de la contraseña****/
            //  try
            // {
            string consulta = "select ValidarContrasena('" + usuario + "', '" + contraseña + "','" + localIP + "') ";
            OdbcCommand comando = new OdbcCommand(consulta, con);
            object resultado = comando.ExecuteScalar();
            if (Convert.ToInt16(resultado) == 1) //esto nos indica que la validaciòn ha sido correcta por parte de la funciòn almacenada
            {
                // seguridad.LlegarSeguridad.EstablecerUsuario(usuario);
                seguridad.Conexion.User = usuario;
                seguridad.Conexion.PassWord = contraseña;

                MessageBox.Show("¡Bienvenido!: " + usuario);
                MenuMDI men_mdi = new MenuMDI();
                men_mdi.FormClosed += new FormClosedEventHandler(mdi_FormClosed);
                men_mdi.Show();
                txt_pass.Clear();
                txt_user.Clear();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña invàlidos"); //De lo contrario, si la contraseña es incorrecta o el usuario, nos devuelve el fallo
                txt_pass.Clear();
            }
            con.Close();
        }


        void mdi_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, ayudaCHM, HelpNavigator.Topic, inicioSesion);
        }

        private void Login_Prueba_Load(object sender, EventArgs e)
        {
            txt_pass.PasswordChar = '*';
        }

        private void txt_pass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Btn_Inicio_secion.PerformClick();
            }
        }
    }
}
