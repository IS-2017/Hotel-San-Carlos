using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Graf1
{
    public class BdComun
    {
        
            public static MySqlConnection ObtenerConexion()
            {
                MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=base4; Uid=root; pwd=;");

                conectar.Open();
                return conectar;
            
        }
    }
}
