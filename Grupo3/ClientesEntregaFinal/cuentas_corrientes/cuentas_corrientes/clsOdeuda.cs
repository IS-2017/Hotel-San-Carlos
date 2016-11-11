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
    class clsOdeuda
    {
        public static int Agregar(cls_deuda clte) //Para insertar datos a Mysql 
        {
            int iretorno = 0;
            OdbcCommand comando = new OdbcCommand(string.Format("insert into deuda (id_deuda, monto, saldo_total, id_cliente_pk, id_fac_empresa_pk, id_empresa_pk, serie) values (NULL,'{0}','{1}','{2}','{3}','{4}','{5}')",
              clte.monto, clte.saldo, clte.codclte, clte.codfac, clte.codemp, clte.serie), seguridad.Conexion.ObtenerConexionODBC());
            iretorno = comando.ExecuteNonQuery();// Retorna un 1 si se ejecuta la inserción y 0 es error.
            return iretorno;

        }

        public static List<cls_deuda> Buscar(string clte) //Método tipo lista, que retornar el resultado dela busqueda
        {
            List<cls_deuda> _lista = new List<cls_deuda>();
            //MessageBox.Show(credi);
            OdbcCommand _comando = new OdbcCommand(String.Format(
           "select * from deuda where monto = '{0}' ", clte),seguridad.Conexion.ObtenerConexionODBC());
            OdbcDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                cls_deuda cl = new cls_deuda();
                cl.cod = _reader.GetInt16(0);

                //tc.valor = Convert.ToString(_reader.GetDouble(2));
                cl.monto = _reader.GetString(1);
                cl.saldo = _reader.GetString(2);
                cl.codclte = _reader.GetInt16(3);
                cl.codfac = _reader.GetInt16(4);
                cl.codemp = _reader.GetInt16(5);
                cl.serie = _reader.GetString(6);                

                _lista.Add(cl);
            }

            return _lista;
        }

        public static cls_deuda Obtenerdeu(int id_cl)
        {
            cls_deuda cl = new cls_deuda();
            OdbcConnection conexion = seguridad.Conexion.ObtenerConexionODBC();

            OdbcCommand _comando = new OdbcCommand(String.Format("select *  from deuda where id_deuda ='{0}' ", id_cl), conexion);
            OdbcDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                cl.cod = _reader.GetInt16(0);
                cl.monto = _reader.GetString(1);
                cl.saldo = _reader.GetString(2);
                cl.codclte = _reader.GetInt16(3);
                cl.codfac = _reader.GetInt16(4);
                cl.codemp = _reader.GetInt16(5);
                cl.serie = _reader.GetString(6);                
            }

            conexion.Close();
            return cl;

        }

        public static int Actualizar(cls_deuda cl)
        {
            int iretorno = 0;
            OdbcConnection conexion = seguridad.Conexion.ObtenerConexionODBC();
            OdbcCommand comando = new OdbcCommand(string.Format("update deuda set monto='{0}', saldo_total='{1}', id_cliente_pk='{2}', id_fac_empresa_pk='{3}', id_empresa_pk='{4}', serie='{5}' where id_deuda={6}",
               cl.monto, cl.saldo, cl.codclte, cl.codfac, cl.codemp, cl.serie, cl.cod), conexion);
            iretorno = comando.ExecuteNonQuery();
            conexion.Close();

            return iretorno;
        }

        public static int Eliminar(int pId)
        {
            int retorno = 0;
            OdbcConnection conexion = seguridad.Conexion.ObtenerConexionODBC();

            OdbcCommand comando = new OdbcCommand(string.Format("delete from deuda where id_deuda={0}", pId), conexion);

            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;

        }
    }
}
