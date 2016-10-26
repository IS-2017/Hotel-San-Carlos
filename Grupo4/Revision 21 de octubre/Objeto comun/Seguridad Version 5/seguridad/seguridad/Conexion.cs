using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Windows.Forms;

namespace seguridad
{
    public class Conexion
    {
       
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

        private static string user;
        private static string password;


        public static string User
        {
            get
            {
                return user;
            }
            set
            {
                user = value;
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


        public static OdbcConnection ObtenerConexionODBC()
        {

            try
            {
                OdbcConnection con = new OdbcConnection();
                //con.ConnectionString = "dsn=prueba2; database="+database+"; UID="+role+"; PWD="+password+"; ";
                con.ConnectionString = "dsn=" + dsn + "; UID=" + user + "; PWD=" + password + "; ";
                con.Open();
                return con;
            }
            catch (Exception ex){ MessageBox.Show(ex.Message); return null; }
        }



        public static OdbcConnection ConexionPermisos()
        {

            try
            {
                OdbcConnection con = new OdbcConnection();
                //con.ConnectionString = "dsn=prueba2; database="+database+"; UID="+role+"; PWD="+password+"; ";
                con.ConnectionString = "dsn=" + dsn + "; UID= dumpy; PWD= dumpy; ";
                con.Open();
                return con;
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); return null; }
        }

    }
}
