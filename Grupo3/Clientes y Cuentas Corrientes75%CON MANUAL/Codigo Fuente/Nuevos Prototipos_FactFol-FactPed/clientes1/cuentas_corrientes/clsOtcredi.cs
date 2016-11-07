using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data.Odbc;
using seguridad;

namespace cuentas_corrientes
{
    class clsOtcredi
    {
        public static int Agregar(cls_tcredi credi) //Para insertar datos a Mysql 
        {
            int iretorno = 0;
            OdbcCommand comando = new OdbcCommand(string.Format("insert into tipo_credito (id_tipocredito_pk, tipo, valor) values (NULL,'{0}','{1}')",
              credi.tipo, credi.valor), seguridad.Conexion.ObtenerConexionODBC());
            iretorno = comando.ExecuteNonQuery();// Retorna un 1 si se ejecuta la inserción y 0 es error.
            return iretorno;

        }

        public static List<cls_tcredi> Buscar(string credi) //Método tipo lista, que retornar el resultado dela busqueda
        {
            List<cls_tcredi> _lista = new List<cls_tcredi>();
            MessageBox.Show(credi);
            OdbcCommand _comando = new OdbcCommand(String.Format(
           "select * from tipo_credito where tipo= " + credi), seguridad.Conexion.ObtenerConexionODBC());
            OdbcDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                cls_tcredi tc = new cls_tcredi();
                tc.cod = _reader.GetInt16(0);
                tc.tipo = _reader.GetString(1);
                //tc.valor = Convert.ToString(_reader.GetDouble(2));
                tc.valor = _reader.GetString(2);
                
                _lista.Add(tc);
            }

            return _lista;
        }

        public static cls_tcredi Obtenercredi(int id_cred)
        {
            cls_tcredi tc = new cls_tcredi();
            OdbcConnection conexion = seguridad.Conexion.ObtenerConexionODBC();

            OdbcCommand _comando = new OdbcCommand(String.Format("select *  from tipo_credito  where id_tipocredito_pk ='{0}' ", id_cred), conexion);
            OdbcDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                tc.cod = _reader.GetInt16(0);
                tc.tipo = _reader.GetString(1);
                tc.valor = _reader.GetString(2);
            }

            conexion.Close();
            return tc;
        }

        public static int Actualizar(cls_tcredi tc)
        {
            int iretorno = 0;
            OdbcConnection conexion = seguridad.Conexion.ObtenerConexionODBC();
            OdbcCommand comando = new OdbcCommand(string.Format("update tipo_riesgo set tipo='{0}', valor='{1}' where id_tiporiesgo_pk={2}",
                tc.tipo, tc.valor, tc.cod), conexion);
            iretorno = comando.ExecuteNonQuery();
            conexion.Close();

            return iretorno;


        }

        public static int Eliminar(int pId)
        {
            int retorno = 0;
            OdbcConnection conexion = seguridad.Conexion.ObtenerConexionODBC();

            OdbcCommand comando = new OdbcCommand(string.Format("delete from cliente where id_cliente_pk={0}", pId), conexion);

            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;

        }
    }
}
