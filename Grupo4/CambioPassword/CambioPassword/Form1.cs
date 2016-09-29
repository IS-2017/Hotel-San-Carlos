using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CambioPassword
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (txt_nombre_usuario.Text.Trim() == "" || txt_contra_actual.Text.Trim() == "" || txt_contra_nueva.Text.Trim() == "" || txt_contra_nueva_repetir.Text.Trim() == "")
            {
                MessageBox.Show("campos vacios");
            }
            else if (txt_contra_nueva.Text.Trim() != txt_contra_nueva_repetir.Text.Trim())
            {
                MessageBox.Show("Las contraseñas no coinsiden");
            }
            string usuario = txt_nombre_usuario.Text.Trim();

            CapaDatos cd = new CapaDatos();
            string retorno_contraseña = cd.RevisarContraseña(usuario);
            if (retorno_contraseña == txt_contra_actual.Text.Trim())


            {
                Objetos.cuentas cuentaModificar = new Objetos.cuentas();
                CapaNegocio modifico = new CapaNegocio();
                cuentaModificar.usuario = txt_nombre_usuario.Text.Trim();
                cuentaModificar.Acontrasenia = txt_contra_actual.Text.Trim();
                cuentaModificar.Ncontrasenia = txt_contra_nueva.Text.Trim();
                cuentaModificar.RNcontrasenia = txt_contra_nueva_repetir.Text.Trim();
                modifico.Modificar(cuentaModificar);

                //string v = "a";
                string v = txt_nombre_usuario.Text.Trim() + "," + txt_contra_actual.Text.Trim() + "," + txt_contra_nueva.Text.Trim() + "," + txt_contra_nueva_repetir.Text.Trim();
                bitacoradll.bitacora x = new bitacoradll.bitacora();
                x.Insertar(v);
            }
            else {
                MessageBox.Show("Usuario incorrecto o Contraseña Actual Erronea");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt_contra_actual.PasswordChar = '*';
            txt_contra_nueva.PasswordChar = '*';
            txt_contra_nueva_repetir.PasswordChar = '*';

            Conexion.Conexion.DSN = "MarvinDsn";
            Conexion.Conexion.Host = "localhost";
            Conexion.Conexion.DataBase = "pruebassancarlos";
            Conexion.Conexion.Role = "root";
            Conexion.Conexion.PassWord = "1234";
        }
    }
}
