using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using MySql.Data.MySqlClient;
using System.Data.Odbc;
using seguridad;

namespace cuentas_corrientes
{
    public class clsOpParmFact
    {
        public static int Agregar(clsParamFact tp) //Para insertar datos a Mysql 
        {
            int iretorno = 0;
            OdbcCommand comando = new OdbcCommand(string.Format("insert into parametros_fac (id_parametros_pk,nombre, descripcion) values (NULL,'{0}','{1}')",
               tp.snombre, tp.sdecripcion), seguridad.Conexion.ObtenerConexionODBC());
            iretorno = comando.ExecuteNonQuery();// Retorna un 1 si se ejecuta la inserción y 0 es error.
            return iretorno;

        }



      /*  public static List<clsParamFact> Buscar(string nomtp) //Método tipo lista, que retornar el resultado dela busqueda
        {
            List<clsParamFact> _lista = new List<clsParamFact>();

            MySqlCommand _comando = new MySqlCommand(String.Format(
           "select id_parametros_pk, nombre, descripcion from parametros_fac where tipo_pago ='{0}' ", nomtp), cls_bdcomun.ObtenerConexion());
            // "select id_impuesto, porcentaje, nombre, descripcion from categoria  where nombre_cat ='{0}' ", nomcat),
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                clsFomPago ptp = new clsFomPago();
                ptp.icod = _reader.GetInt16(0);

                ptp.stp = _reader.GetString(1);
                ptp.sdecripcion = _reader.GetString(2);

                _lista.Add(ptp);
            }

            return _lista;
        }*/

        public static clsParamFact ObtenerParmFact(int id_itp)
        {

            OdbcConnection conexion = seguridad.Conexion.ObtenerConexionODBC();
            clsParamFact ptp = new clsParamFact();

            OdbcCommand _comando = new OdbcCommand(String.Format("select id_parametros_pk, nombre, descripcion from parametros_fac  where id_parametros_pk ='{0}' ", id_itp), conexion);
            OdbcDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                ptp.icod = _reader.GetInt16(0);

                ptp.snombre = _reader.GetString(1);
                ptp.sdecripcion = _reader.GetString(2);
            }

            conexion.Close();
            return ptp;
        }


        public static int Actualizar(clsParamFact ptp)
        {
            int iretorno = 0;
            OdbcConnection conexion = seguridad.Conexion.ObtenerConexionODBC();
            OdbcCommand comando = new OdbcCommand(string.Format("update parametros_fac set nombre='{0}', descripcion='{1}' where id_parametros_pk={2}",
             ptp.snombre, ptp.sdecripcion, ptp.icod), conexion);
            iretorno = comando.ExecuteNonQuery();
            conexion.Close();

            return iretorno;


        }

    /*    public static int Eliminar(int pId)
        {
            int retorno = 0;
            MySqlConnection conexion = cls_bdcomun.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(string.Format("delete from forma_pago where id_forma_pk={0}", pId), conexion);

            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;

        }
        */
    }
}
