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

namespace dllconsultasgeneraless
{
    public class realizar
    {
        public void generar()
        {
            frm_consultas nuevo = new frm_consultas();
            nuevo.ShowDialog();
        }
    }
}
