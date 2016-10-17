using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using seguridad;

namespace NuevaFormula
{
    public partial class NuevoProceso : Form
    {
        public NuevoProceso()
        {
            InitializeComponent();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {




        }

        private void NuevoProceso_Load(object sender, EventArgs e)
        {
            Conexion.Conexion.DSN = "Marvin";
            Conexion.Conexion.Host = "localhost";
            Conexion.Conexion.DataBase = "sancarlos2";
            Conexion.Conexion.Role = "root";
            Conexion.Conexion.PassWord = "1234";

        }
    }
}
