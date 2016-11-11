using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using seguridad;

namespace cuentas_corrientes
{
    class clsOperacion
    {
        public static int Agregar(cls_operacion clte) //Para insertar datos a Mysql 
        {
            int iretorno = 0;
            OdbcCommand comando = new OdbcCommand(string.Format("insert into operacion (id_operacion, cantidad, descripcion, fecha_emision, id_deuda, id_doc) values (NULL,'{0}','{1}','{2}','{3}','{4}')",
              clte.cantidad, clte.desc, clte.fecha, clte.codde, clte.coddoc), seguridad.Conexion.ObtenerConexionODBC());
            iretorno = comando.ExecuteNonQuery();// Retorna un 1 si se ejecuta la inserción y 0 es error.
            return iretorno;

        }

        public static List<cls_deuda> Buscar(string clte) //Método tipo lista, que retornar el resultado dela busqueda
        {
            List<cls_deuda> _lista = new List<cls_deuda>();
            //MessageBox.Show(credi);
            OdbcCommand _comando = new OdbcCommand(String.Format(
           "select * from deuda where monto = '{0}' ", clte), seguridad.Conexion.ObtenerConexionODBC());
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

        public static int Actualizar(cls_operacion cl)
        {
            int iretorno = 0;
            OdbcConnection conexion = seguridad.Conexion.ObtenerConexionODBC();
            OdbcCommand comando = new OdbcCommand(string.Format("update operacion set cantidad='{0}', descripcion='{1}', fecha_emision='{2}', id_deuda='{3}', id_doc='{4}' where id_operacion={5}",
               cl.cantidad, cl.desc, cl.fecha, cl.codde, cl.coddoc, cl.cod), conexion);
            iretorno = comando.ExecuteNonQuery();
            conexion.Close();

            return iretorno;
        }

        public static int Eliminar(int pId)
        {
            int retorno = 0;
            OdbcConnection conexion = seguridad.Conexion.ObtenerConexionODBC();

            OdbcCommand comando = new OdbcCommand(string.Format("delete from operacion where id_operacion={0}", pId), conexion);

            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;

        }
    }
}
