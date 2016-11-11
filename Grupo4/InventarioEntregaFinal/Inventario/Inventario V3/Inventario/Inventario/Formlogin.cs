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

namespace Inventario
{
    public partial class Formlogin : Form
    {
        public Formlogin()
        {
            InitializeComponent();
        }

        private void Formlogin_Load(object sender, EventArgs e)
        {

            seguridad.Conexion.DSN = "prueba2";

        }

        private void btn_logear_Click(object sender, EventArgs e)
        {
            try
            {
                // OdbcConnection con = seguridad.Conexion.ObtenerConexionODBC();
                OdbcConnection con = Conexion.ConexionPermisos();
                seguridad.SistemaUsuarioDatos ss = new SistemaUsuarioDatos();
                string usuario = txt_usuario.Text.Trim();
                string contraseña = ss.Encriptar(txt_contraseña.Text.Trim());
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
                    contenedor men_seg = new contenedor();
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

                // }
                //catch
                //{
                //    txt_contraseña.Clear();
                //    txt_usuario.Clear();
                //    txt_usuario.Focus();
                //    MessageBox.Show("Usuario no existe");
                //}



                con.Close();
            }
            catch (Exception ex){ MessageBox.Show(ex.Message); }
        }

        private void txt_contraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btn_logear.PerformClick();
            }
        }
    }
}
