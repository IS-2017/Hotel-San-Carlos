using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace Abrir
{
    class Conexion
    {
        public static MySqlConnection ObtenerConexion()
        {
            MySqlConnection con = new MySqlConnection("server=localhost; database=ejemplodll; Uid=root; pwd=1234;");
            con.Open();
            return con;
        }
    }
}
