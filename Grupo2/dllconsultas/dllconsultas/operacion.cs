using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Collections;
//rodrigo:trasnformar windows form en dll
namespace dllconsultas
{
    public class operaciones
    {
        public void ejecutar(DataGridView dg, string tabla)
        {
            frm_consulta dw = new frm_consulta(dg, tabla);
            dw.ShowDialog();

        }
        
    }

}
