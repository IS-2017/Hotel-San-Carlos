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
    class clsOpFormPago
    {
        public static int Agregar(clsFomPago tp) //Para insertar datos a Mysql 
        {
            int iretorno = 0;
            OdbcCommand comando = new OdbcCommand(string.Format("insert into forma_pago (id_forma_pk,tipo_pago, descripcion) values (NULL,'{0}','{1}')",
               tp.stp, tp.sdecripcion),seguridad.Conexion.ObtenerConexionODBC());
            iretorno = comando.ExecuteNonQuery();// Retorna un 1 si se ejecuta la inserción y 0 es error.
            return iretorno;

        }



        public static List<clsFomPago> Buscar(string nomtp) //Método tipo lista, que retornar el resultado dela busqueda
        {
            List<clsFomPago> _lista = new List<clsFomPago>();

            OdbcCommand _comando = new OdbcCommand(String.Format(
           "select id_forma_pk, tipo_pago, descripcion from forma_pago where tipo_pago ='{0}' ", nomtp), seguridad.Conexion.ObtenerConexionODBC());
            // "select id_impuesto, porcentaje, nombre, descripcion from categoria  where nombre_cat ='{0}' ", nomcat),
            OdbcDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
               clsFomPago  ptp = new clsFomPago();
                ptp.icod = _reader.GetInt16(0);
                
                ptp.stp = _reader.GetString(1);
                ptp.sdecripcion = _reader.GetString(2);

                _lista.Add(ptp);
            }

            return _lista;
        }

        public static clsFomPago Obtenerimp(int id_itp)
        {

            OdbcConnection conexion = seguridad.Conexion.ObtenerConexionODBC();
            clsFomPago ptp = new clsFomPago();

            OdbcCommand _comando = new OdbcCommand(String.Format("select id_forma_pk, tipo_pago, descripcion from forma_pago  where id_forma_pk ='{0}' ", id_itp), conexion);
            OdbcDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                ptp.icod = _reader.GetInt16(0);

                ptp.stp = _reader.GetString(1);
                ptp.sdecripcion = _reader.GetString(2);
            }

            conexion.Close();
            return ptp;
        }


        public static int Actualizar(clsFomPago ptp)
        {
            int iretorno = 0;
            OdbcConnection conexion = seguridad.Conexion.ObtenerConexionODBC();
            OdbcCommand comando = new OdbcCommand(string.Format("update forma_pago set tipo_pago='{0}', descripcion='{1}' where id_forma_pk='{2}'",
             ptp.stp, ptp.sdecripcion, ptp.icod), conexion);
            iretorno = comando.ExecuteNonQuery();
            conexion.Close();

            return iretorno;


        }

        public static int Eliminar(clsFomPago ptp)
        {
            int iretorno = 0;
            OdbcConnection conexion = seguridad.Conexion.ObtenerConexionODBC();
            OdbcCommand comando = new OdbcCommand(string.Format("update forma_pago set estado='{0}' where id_forma_pk='{1}'",
              ptp.sdecripcion, ptp.icod), conexion);
            iretorno = comando.ExecuteNonQuery();
            conexion.Close();

            return iretorno;

        }
    }
}
