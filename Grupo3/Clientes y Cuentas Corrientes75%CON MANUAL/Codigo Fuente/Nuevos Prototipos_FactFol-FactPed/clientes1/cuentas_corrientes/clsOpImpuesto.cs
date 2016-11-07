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
    class clsOpImpuesto
    {
        public static int Agregar(clsimpuesto imp) //Para insertar datos a Mysql 
        {
            int iretorno = 0;
            OdbcCommand comando = new OdbcCommand(string.Format("insert into impuesto (id_impuesto_pk, porcentaje, nombre, descripcion) values (NULL,'{0}','{1}','{2}')",
               imp.iporcentaje, imp.snombre, imp.sdecripcion), seguridad.Conexion.ObtenerConexionODBC());
            iretorno = comando.ExecuteNonQuery();// Retorna un 1 si se ejecuta la inserción y 0 es error.
            return iretorno;

        }



        public static List<clsimpuesto> Buscar(string nomimp) //Método tipo lista, que retornar el resultado dela busqueda
        {
            List<clsimpuesto> _lista = new List<clsimpuesto>();

            OdbcCommand _comando = new OdbcCommand(String.Format(
           "select id_impuesto_pk, porcentaje, nombre, descripcion from impuesto where nombre ='{0}' ", nomimp), seguridad.Conexion.ObtenerConexionODBC());
            // "select id_impuesto, porcentaje, nombre, descripcion from categoria  where nombre_cat ='{0}' ", nomcat),
            OdbcDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                clsimpuesto pimp = new clsimpuesto();
                pimp.icod = _reader.GetInt16(0);
               pimp.iporcentaje = _reader.GetInt16(1);
                pimp.snombre = _reader.GetString(2);
                pimp.sdecripcion = _reader.GetString(3);

                _lista.Add(pimp);
            }

            return _lista;
        }

        public static clsimpuesto Obtenerimp(int id_imp)
        {
            clsimpuesto pimp = new clsimpuesto();
            OdbcConnection conexion = seguridad.Conexion.ObtenerConexionODBC();

            OdbcCommand _comando = new OdbcCommand(String.Format("select id_impuesto_pk, porcentaje, nombre, descripcion from impuesto  where id_impuesto_pk ='{0}' ", id_imp), conexion);
            OdbcDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                pimp.icod = _reader.GetInt16(0);
                pimp.iporcentaje = _reader.GetInt16(1);
                pimp.snombre = _reader.GetString(2);
                pimp.sdecripcion = _reader.GetString(3);
            }

            conexion.Close();
            return pimp;
        }


        public static int Actualizar(clsimpuesto pimp)
        {
            int iretorno = 0;
            OdbcConnection conexion = seguridad.Conexion.ObtenerConexionODBC();
            OdbcCommand comando = new OdbcCommand(string.Format("update impuesto set porcentaje='{0}', nombre='{1}', descripcion='{2}' where id_impuesto_pk={3}",
                pimp.iporcentaje, pimp.snombre, pimp.sdecripcion, pimp.icod), conexion);
            iretorno = comando.ExecuteNonQuery();
            conexion.Close();

            return iretorno;


        }

        public static int Eliminar(int pId)
        {
            int retorno = 0;
            OdbcConnection conexion = seguridad.Conexion.ObtenerConexionODBC();

            OdbcCommand comando = new OdbcCommand(string.Format("delete from impuesto where id_impuesto_pk={0}", pId), conexion);

            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;

        }
    }
}
