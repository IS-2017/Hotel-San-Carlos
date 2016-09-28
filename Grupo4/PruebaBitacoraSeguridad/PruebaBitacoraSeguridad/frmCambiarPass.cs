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

namespace PruebaBitacoraSeguridad
{
    public partial class frmCambiarPass : Form
    {
        public frmCambiarPass()
        {
            InitializeComponent();
        }

        private void btn_aceptar_pass_Click(object sender, EventArgs e)
        {
            string usuario = txt_usuario.Text.Trim();
            string operacion = txt_contrasenia.Text.Trim() + " " + txt_ncontrasenia.Text.Trim() + " " + txt_rep_ncontrasenia.Text.Trim();
            // envio de datos
            bitacora modifica = new bitacora();
            modifica.Modificar(usuario, operacion);

            
            

        }
    }
}
