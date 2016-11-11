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
    public class ClsOpFact
    {
        public static int AgregarFact(ClsFactura fact) //Para insertar datos a Mysql 
        {
            int iretorno = 0;
            OdbcCommand comando = new OdbcCommand(string.Format("insert into factura (id_fac_empresa_pk, id_empresa_pk, serie, id_empleados_pk, fecha_vencimiento,  fecha_emision, subtotal, total, id_cliente_pk, id_impuesto_pk) values (NULL,'{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')",
               fact.cod_emp,fact.serie, fact.cod_emp,fact.fec_ven,  fact.fec_emision, fact.subtotal, fact.total, fact.cod_cte, fact.cod_imp), seguridad.Conexion.ObtenerConexionODBC());
            iretorno = comando.ExecuteNonQuery();// Retorna un 1 si se ejecuta la inserción y 0 es error.
            return iretorno;
        }

        public static int AgregarDetFact(ClsDetalleFact fact) //Para insertar datos a Mysql 
        {
            int iretorno = 0;
            OdbcCommand comando = new OdbcCommand(string.Format("insert into factura_detalle (id_detalle_fact,id_fac_empresa_pk,id_empresa_pk, serie, id_precio,cantidad, descripcion, precio, subtotal  )values (NULL,'{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')",
                fact.cod_fact, fact.cod_emp, fact.serie, fact.cod_bien, fact.cantidad, fact.descripcion, fact.prec, fact.subtotal), seguridad.Conexion.ObtenerConexionODBC());
            iretorno = comando.ExecuteNonQuery();// Retorna un 1 si se ejecuta la inserción y 0 es error.
            return iretorno;
        }


        public static int AgregarDetFactFol(ClsFactura fact, clsFolio fol) //Para insertar datos a Mysql 
        {
            int iretorno = 0;
            OdbcCommand comando = new OdbcCommand(string.Format("insert into folio_factura (id_cuenta_pagar_pk, id_fac_empresa_pk, id_empresa_pk, serie    )values ('{0}','{1}','{2}','{3}')",
                fol.cod, fact.cod_fact, fact.cod_emp, fact.serie), seguridad.Conexion.ObtenerConexionODBC());
            iretorno = comando.ExecuteNonQuery();// Retorna un 1 si se ejecuta la inserción y 0 es error.
            return iretorno;
        }

        public static int AgregarDetFactPed(ClsFactura fact, ClsPedido ped) //Para insertar datos a Mysql 
        {
            int iretorno = 0;
            OdbcCommand comando = new OdbcCommand(string.Format("insert into pedido_factura (id_pedido_pk, id_fac_empresa_pk, id_empresa_pk, serie    )values ('{0}','{1}','{2}','{3}')",
                ped.codped, fact.cod_fact, fact.cod_emp, fact.serie), seguridad.Conexion.ObtenerConexionODBC());
            iretorno = comando.ExecuteNonQuery();// Retorna un 1 si se ejecuta la inserción y 0 es error.
            return iretorno;
        }



        //FUNCION QUE DUELVE LOS PARAMETROS DE DEVOLUCION

        public static ClsDevo ObtenerDev(int id_dev)
        {
            ClsDevo dev = new ClsDevo();
            OdbcConnection conexion = seguridad.Conexion.ObtenerConexionODBC();

            OdbcCommand _comando = new OdbcCommand(String.Format("select id_dev, id_empresa, id_fact_emp, serie, id_cliente, fecha, motivo, total from devolucion_venta  where id_dev='{0}' ", id_dev), conexion);
            OdbcDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                dev.id_dev = _reader.GetInt16(0);
                dev.cod_emp = _reader.GetInt16(1);
                dev.cod_fact = _reader.GetInt16(2);
                dev.serie = _reader.GetString(3);
                dev.cod_cte = _reader.GetInt16(4);
                dev.fec_emision= _reader.GetString(5);
                dev.motivo= _reader.GetString(6);
                dev.total=_reader.GetDecimal(7);


            }

            conexion.Close();
            return dev;
        }


        public static int EliminarEncabeDevo(int id)
        {
            int iretorno = 0;
            OdbcConnection conexion = seguridad.Conexion.ObtenerConexionODBC();
            OdbcCommand comando = new OdbcCommand(string.Format("update factura set estado='desactivado' where id_fac_empresa_pk='{0}'",
                  id), conexion);
            iretorno = comando.ExecuteNonQuery();
            conexion.Close();

            return iretorno;

        }
        public static int EliminarDetalleDevo(int id)
        {
            int iretorno = 0;
            OdbcConnection conexion = seguridad.Conexion.ObtenerConexionODBC();
            OdbcCommand comando = new OdbcCommand(string.Format("update factura_detalle set estado='desactivado' where id_fac_empresa_pk='{0}'",
                  id), conexion);
            iretorno = comando.ExecuteNonQuery();
            conexion.Close();

            return iretorno;

        }

    }
}
