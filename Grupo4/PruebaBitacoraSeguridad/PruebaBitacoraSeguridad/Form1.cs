using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bitacoradll;
using System.Net;


namespace PruebaBitacoraSeguridad
{
    public partial class btn_ip : Form
    {
        public btn_ip()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                
                
                string usuario = ""+txt_usuario.Text.Trim();
                string accion = txt_usuario.Text.Trim() + " " + textBox2.Text.Trim();

                //string accion = "INSERT -Prueba - ";
                
                
                bitacora c11 = new bitacora();
                c11.Insertar(usuario,accion);
                

                frmtabla_bitacora fr = new frmtabla_bitacora();
                //this.Hide();
                fr.Show();
                


            }


            catch (Exception)


            {
                MessageBox.Show(" error");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Conexion.Conexion.DSN = "MarvinDsn";
            Conexion.Conexion.Host = "localhost";
            Conexion.Conexion.DataBase = "pruebassancarlos";
            Conexion.Conexion.Role = "root";
            Conexion.Conexion.PassWord = "1234";
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                /*IPHostEntry host;
                string localIP = "";
                host = Dns.GetHostEntry(Dns.GetHostName());
                foreach (IPAddress ip in host.AddressList)
                {
                    if (ip.AddressFamily.ToString() == "InterNetwork")
                    {
                        localIP = ip.ToString();
                    }
                }*/
                ClaseTomaIp dir = new ClaseTomaIp();
                string ruta = dir.direccion();
                MessageBox.Show(ruta);
            }

            catch (Exception)
            {
                System.Console.WriteLine("Error insertando en bitacora");
            }
            
        }

        private void lklbl_cambiocontraseña_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmCambiarPass cambiopass = new frmCambiarPass();
            cambiopass.Show();
        }
    }
}
