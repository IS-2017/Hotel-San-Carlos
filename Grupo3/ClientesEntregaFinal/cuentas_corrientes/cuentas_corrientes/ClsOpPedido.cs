using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using MySql.Data.MySqlClient;
using System.Data.Odbc;

namespace cuentas_corrientes
{
    public class ClsOpPedido
    {
        public static List<ClsPedido> Buscarpedido(int idcte) //Método tipo lista, que retornar el resultado dela busqueda
        {
            List<ClsPedido> _lista = new List<ClsPedido>();

            OdbcCommand _comando = new OdbcCommand(String.Format(
           "select id_pedido_pk, id_emp, fecha_pedido, id_cliente_pk  from pedido where id_cliente_pk ='{0}' ", idcte), seguridad.Conexion.ObtenerConexionODBC());
            // "select id_impuesto, porcentaje, nombre, descripcion from categoria  where nombre_cat ='{0}' ", nomcat),
            OdbcDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                ClsPedido pPed= new ClsPedido();

                pPed.codped = _reader.GetInt16(0);
                pPed.codemp = _reader.GetInt16(1);
                pPed.fec_pedido = _reader.GetDateTime(2);
                pPed.codcte = _reader.GetInt16(3);
               

                _lista.Add(pPed);
            }

            return _lista;
        }

        public static ClsPedido ObtenerPedido(int id_imp)
        {
            ClsPedido pPed = new ClsPedido();
            OdbcConnection conexion = seguridad.Conexion.ObtenerConexionODBC();

            OdbcCommand _comando = new OdbcCommand(String.Format("select id_pedido_pk, id_emp, fecha_pedido, id_cliente_pk, estado_pedido   from pedido  where id_pedido_pk ='{0}' ", id_imp), conexion);
            OdbcDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {

                pPed.codped = _reader.GetInt16(0);
                pPed.codemp = _reader.GetInt16(1);
                pPed.fec_pedido = _reader.GetDateTime(2);
                pPed.codcte = _reader.GetInt16(3);
                pPed.estado = _reader.GetString(4);

            }

            conexion.Close();
            return pPed;
        }


        public static int ActualizarPedido(ClsPedido pPed)
        {
            int iretorno = 0;
            OdbcConnection conexion = seguridad.Conexion.ObtenerConexionODBC();
            OdbcCommand comando = new OdbcCommand(string.Format("update pedido set estado_pedido='{0} where id_pedido_pk={1}",
                pPed.estado, pPed.codped), conexion);
            iretorno = comando.ExecuteNonQuery();
            conexion.Close();

            return iretorno;


        }



        public static List<ClsDetallePedido> BuscardetallePed(int idemp, int idped) //Método tipo lista, que retornar el resultado dela busqueda
        {
            List<ClsDetallePedido> _lista = new List<ClsDetallePedido>();

            OdbcCommand _comando = new OdbcCommand(String.Format(
           "select id_bien_pk, cantidad,descripcion, precio, subtotal from detalle_pedido where id_emp='{0}' and id_pedido_pk = '{1}' ", idemp, idped), seguridad.Conexion.ObtenerConexionODBC());
            // "select id_impuesto, porcentaje, nombre, descripcion from categoria  where nombre_cat ='{0}' ", nomcat),
            OdbcDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                ClsDetallePedido pPed = new ClsDetallePedido();
                pPed.cod = _reader.GetInt16(0);
                pPed.cantidad = _reader.GetInt16(1);
                pPed.descripcion = _reader.GetString(2);
                pPed.prec = _reader.GetDecimal(3);
                pPed.subtotal = _reader.GetDecimal(4);

                _lista.Add(pPed);
            }

            return _lista;
        }
    }
}
