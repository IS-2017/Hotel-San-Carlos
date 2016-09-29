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
            MySqlConnection conectar = new MySqlConnection("server=localhost; user=root; database =hotel");
            conectar.Open();
            return conectar;
            
        }
    }
}
