using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.Odbc;

namespace CambioPassword
{
    public class CapaDatos
    {

        public void Modificar(string usuario, string Acontrasenia, string Ncontrasenia, string RNcontrasenia)
        {

            try
            {// corregir el mensaje que muestra password modificada con exito, porque aunque no exista dice que si cambio pero en realidad no cambio nada solo registra en la bitacora que inserto
                // acccion
                OdbcCommand cmd = new OdbcCommand(string.Format("update usuario set contrasenia ='" + Ncontrasenia + "'where contrasenia ='" + Acontrasenia + "'and usuario ='" + usuario + "'")
                , Conexion.Conexion.ObtenerConexionODBC());

                cmd.ExecuteNonQuery();


                MessageBox.Show("Password Modificada con exito");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        string respuesta;
        public string RevisarContraseña(string usuario)
        {
            try
            {
                //OdbcConnection con = Conexion.Conexion.ObtenerConexionODBC();
                string sQuery = "select * from usuario where usuario = '" + usuario + "'";
                DataTable dt = new DataTable();
                OdbcCommand comando = new OdbcCommand(sQuery, Conexion.Conexion.ObtenerConexionODBC());
                OdbcDataAdapter adaptador = new OdbcDataAdapter(comando);
                adaptador.Fill(dt);


                if (dt.Rows.Count != 0)
                {

                    DataRow fila = dt.Rows[0];
                    String sUsuario = fila[0].ToString();
                    String sContra = fila[1].ToString();
                    respuesta = sContra;


                    // DataRow fila = dt.Rows[0];
                    // String sUsuario = fila[0].ToString();
                    //  String sContra = fila[2].ToString();
                }
                return respuesta;
            }
            catch (Exception)
            {
                return "error";
            }
        }
    }
}
