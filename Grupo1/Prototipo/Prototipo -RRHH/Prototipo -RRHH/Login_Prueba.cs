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


namespace Prototipo__RRHH
{
    public partial class Login_Prueba : Form
    {
        public Login_Prueba()
        {
            InitializeComponent();
        }

        private const string ayudaCHM = "Ayuda-Modulo-RRHH.chm";
        private const string inicioSesion = "gettingstarted.html";
        Login_Prueba login;
        

        private void Btn_Inicio_secion_Click(object sender, EventArgs e)
        {
            if(txt_user.Text == "Prueba")
            {
                if(txt_pass.Text == "123456")
                {
                    MessageBox.Show("Contraseña Correcta...", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MenuMDI mdi = new MenuMDI();
                    mdi.Show();
                    mdi.FormClosed += new FormClosedEventHandler(mdi_FormClosed);
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Contraseña Incorrecta!", "Advertencia",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Usuario Incorrecto!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        }
    }
}
