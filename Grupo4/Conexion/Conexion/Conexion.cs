using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.Odbc;
using System.Windows;

namespace Conexion
{
    public class Conexion
    {
//----------------------ALCENAR DSN PARA CONEXION ODBC-----------------------------------------------
        private static string dsn;

        public static string DSN
        {
            get
            {
                return dsn;
            }
            set
            {
                dsn = value;
            }
        }

//--------------------------ALMACENAR VARIABLES DE LA CADENA DE CONEXION-------------------------------------------
        private static string host = "localhost";
        private static string database;
        private static string role;
        private static string password;

        public static string Host
        {
            get
            {
                return host;
            }
            set
            {
                host = value;
            }
        }

        public static string DataBase
        {
            get
            {
                return database;
            }
            set
            {
                database = value;
            }
        }

        public static string Role
        {
            get
            {
                return role;
            }
            set
            {
                role = value;
            }
        }

        public static string PassWord
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }



        //----------------------METODO PARA OBTENER CONEXIÓN MYSQL-----------------

        public static MySqlConnection ObtenerConexionMYSQL()
        {
            
                //MySqlConnection con = new MySqlConnection("server=localhost; database=asignacionprueba; Uid=root; pwd=1234;");
                MySqlConnection con = new MySqlConnection("server=" + host + "; database=" + database + "; Uid=" + role + "; pwd=" + password + ";");
                con.Open();
                return con;
            
            
        }



        //----------------------METODO PARA OBTENER CONEXIÓN ODBC-----------------

        public static OdbcConnection ObtenerConexionODBC()
        {

          
            OdbcConnection con = new OdbcConnection();
            //con.ConnectionString = "dsn=prueba2; database="+database+"; UID="+role+"; PWD="+password+"; ";
            con.ConnectionString = "dsn="+dsn+"; server="+host+"; database=" + database + "; UID=" + role + "; PWD=" + password + "; ";
            con.Open();
            return con;
        }


    }
}
