using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SistemaUsuarios
{
    class ClaseConexion
    {

        public static MySqlConnection conexion()
        {
            MySqlConnection conectar = new MySqlConnection("server=localhost; user=root; Password=1234;database=dll");
            conectar.Open();
            return conectar;
        }

    }
}
