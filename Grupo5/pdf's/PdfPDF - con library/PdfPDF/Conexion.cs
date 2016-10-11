using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace PdfPDF
{
    class Conexion
    {
        public static MySqlConnection ObtenerConexion()
        {
            MySqlConnection con = new MySqlConnection("server=localhost; database=hotel; Uid=root; pwd=;");
            con.Open();
            return con;
        }

        public static DataTable DatosAsignacion_Catedratico()
        {
            MySqlConnection con = Conexion.ObtenerConexion();
            DataTable dt = new DataTable();
            string query = "select * from empleado";
            MySqlCommand comando = new MySqlCommand(query, con);
            MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
            adaptador.Fill(dt);
            con.Close();
            return dt;
        }

    }
}
