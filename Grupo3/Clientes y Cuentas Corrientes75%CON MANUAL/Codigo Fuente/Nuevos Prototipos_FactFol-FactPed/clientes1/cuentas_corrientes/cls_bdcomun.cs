﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace cuentas_corrientes
{
    class cls_bdcomun
    {
        public static MySqlConnection ObtenerConexion()
        {
            //MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=bdsistemadereparto; Uid=root; pwd=;");
            MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=base2; Uid=root; pwd=;");
            conectar.Open();
            return conectar;
        }
    }
}
