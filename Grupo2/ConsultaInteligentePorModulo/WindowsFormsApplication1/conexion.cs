using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1
{
    class conexion
    {
        public static MySqlConnection obtenerConexion()
        {
            MySqlConnection conectar = new MySqlConnection("server=localhost; database=bdcinetopia; Uid=root; pwd=;");
            conectar.Open();
            return conectar;
            
        }
    }
}
