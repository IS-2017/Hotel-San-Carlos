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
    class clsOcontri
    {
        public static int Agregar(cls_contribuye cont) //Para insertar datos a Mysql 
        {
            int iretorno = 0;
            OdbcCommand comando = new OdbcCommand(string.Format("insert into contribuyente (id_contribuyente_pk, nombre, nit) values (NULL,'{0}','{1}')",
              cont.nombre, cont.nit), seguridad.Conexion.ObtenerConexionODBC());
            iretorno = comando.ExecuteNonQuery();// Retorna un 1 si se ejecuta la inserción y 0 es error.
            return iretorno;

        }

        public static List<cls_contribuye> Buscar(string contri) //Método tipo lista, que retornar el resultado dela busqueda
        {
            List<cls_contribuye> _lista = new List<cls_contribuye>();
            //MessageBox.Show(credi);
            OdbcCommand _comando = new OdbcCommand(String.Format(
           "select * from contribuyente where nombre= " + contri), seguridad.Conexion.ObtenerConexionODBC());
            OdbcDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                cls_contribuye con = new cls_contribuye();
                con.cod = _reader.GetInt16(0);
                con.nombre = _reader.GetString(1);
                //tc.valor = Convert.ToString(_reader.GetDouble(2));
                con.nit = _reader.GetString(2);

                _lista.Add(con);
            }

            return _lista;
        }

        public static cls_contribuye Obtenercon(int id_con)
        {
            cls_contribuye cn = new cls_contribuye();
            OdbcConnection conexion = seguridad.Conexion.ObtenerConexionODBC();

            OdbcCommand _comando = new OdbcCommand(String.Format("select *  from contribuyente  where id_contribuyente_pk ='{0}' ", id_con), conexion);
            OdbcDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                cn.cod = _reader.GetInt16(0);
                cn.nombre = _reader.GetString(1);
                cn.nit = _reader.GetString(2);
            }

            conexion.Close();
            return cn;
        }

        public static int Actualizar(cls_contribuye cn)
        {
            int iretorno = 0;
            OdbcConnection conexion = seguridad.Conexion.ObtenerConexionODBC();
            OdbcCommand comando = new OdbcCommand(string.Format("update contribuyente set nombre='{0}', nit='{1}' where id_contribuyente_pk={2}",
                cn.nombre, cn.nit, cn.cod), conexion);
            iretorno = comando.ExecuteNonQuery();
            conexion.Close();

            return iretorno;


        }

        public static int Eliminar(int pId)
        {
            int retorno = 0;
            OdbcConnection conexion = seguridad.Conexion.ObtenerConexionODBC();

            OdbcCommand comando = new OdbcCommand(string.Format("delete from contribuyente where id_contribuyente_pk={0}", pId), conexion);

            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;

        }
    }
}
