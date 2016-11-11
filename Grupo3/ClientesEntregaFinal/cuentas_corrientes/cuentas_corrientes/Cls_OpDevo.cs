using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Windows.Forms;

namespace cuentas_corrientes
{
    public class Cls_OpDevo
    {
        public static List<clsdetalle> BuscarDet(int idfact) //Método tipo lista, que retornar el resultado dela busqueda
        {
            List<clsdetalle> _lista = new List<clsdetalle>();

            OdbcCommand _comando = new OdbcCommand(String.Format(
           "select id_detalle_fact, id_precio, cantidad, descripcion, precio, subtotal from factura_detalle where id_fac_empresa_pk ='{0}' ", idfact), seguridad.Conexion.ObtenerConexionODBC());
            // "select id_impuesto, porcentaje, nombre, descripcion from categoria  where nombre_cat ='{0}' ", nomcat),
            OdbcDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                clsdetalle pfact = new clsdetalle();

                pfact.cod_fact = _reader.GetInt16(0);
                pfact.cod_bien = _reader.GetInt16(1);
                pfact.cantidad = _reader.GetInt16(2);
                pfact.descripcion = _reader.GetString(3);
                pfact.prec = _reader.GetInt16(4);
                pfact.subtotal = _reader.GetInt16(5);

                _lista.Add(pfact);
            }

            return _lista;
        }



        public static List<clsdetalle> BuscarDet1(int idfact) //Método tipo lista, que retornar el resultado dela busqueda
        {
            List<clsdetalle> _lista = new List<clsdetalle>();

            OdbcCommand _comando = new OdbcCommand(String.Format(
           "select id_detalle_fact, id_precio, cantidad, descripcion, precio, subtotal from factura_detalle where id_fac_empresa_pk ='{0}' ", idfact), seguridad.Conexion.ObtenerConexionODBC());
            // "select id_impuesto, porcentaje, nombre, descripcion from categoria  where nombre_cat ='{0}' ", nomcat),
            OdbcDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                clsdetalle pfact = new clsdetalle();

                pfact.cod_fact = _reader.GetInt16(0);
                pfact.cod_bien = _reader.GetInt16(1);
                pfact.cantidad = _reader.GetInt16(2);
                pfact.descripcion = _reader.GetString(3);
                pfact.prec = _reader.GetInt16(4);
                pfact.subtotal = _reader.GetInt16(5);

                _lista.Add(pfact);
            }

            return _lista;
        }




        public static ClsDetalleFact Obtenerbien(int id_fact)
        {
            ClsDetalleFact pfact = new ClsDetalleFact();
            OdbcConnection conexion = seguridad.Conexion.ObtenerConexionODBC();

            OdbcCommand _comando = new OdbcCommand(String.Format("select id_precio, cantidad, descripcion, precio, subtotal from factura_detalle where id_detalle_fact ='{0}' ", id_fact), conexion);
            OdbcDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {


                pfact.cod_bien = _reader.GetInt16(0);
                pfact.cantidad = _reader.GetInt16(1);
                pfact.descripcion = _reader.GetString(2);
                pfact.prec = _reader.GetInt16(3);
                pfact.subtotal = _reader.GetInt16(4);
            }

            conexion.Close();
            return pfact;
        }

        public static int AgregarDevo(ClsDevo dev) //Para insertar datos a Mysql 
        {
            int iretorno = 0;
            OdbcCommand comando = new OdbcCommand(string.Format("insert into devolucion_venta (id_dev, id_empresa, id_fact_emp, serie, id_cliente, fecha, motivo, total) values (NULL,'{0}','{1}','{2}','{3}','{4}','{5}','{6}')",
               dev.cod_emp, dev.cod_fact, dev.serie, dev.cod_cte, dev.fec_emision,dev.motivo, dev.total), seguridad.Conexion.ObtenerConexionODBC());
            iretorno = comando.ExecuteNonQuery();// Retorna un 1 si se ejecuta la inserción y 0 es error.
            return iretorno;
        }

        public static int AgregarDetDev(ClsDetalleFact fact) //Para insertar datos a Mysql 
        {
            int iretorno = 0;
            OdbcCommand comando = new OdbcCommand(string.Format("insert into devolucion_detventa (id_detalle_dec, id_dev, id_bien, cantidad, descripcion, precio, subtotal )values (NULL,'{0}','{1}','{2}','{3}','{4}','{5}')",
                fact.cod_fact,  fact.cod_bien, fact.cantidad, fact.descripcion, fact.prec, fact.subtotal), seguridad.Conexion.ObtenerConexionODBC());
            iretorno = comando.ExecuteNonQuery();// Retorna un 1 si se ejecuta la inserción y 0 es error.
            return iretorno;
        }

        public static List<ClsDetallePedido> BuscarDetDev(int iddev) //Método tipo lista, que retornar el resultado dela busqueda
        {
            List<ClsDetallePedido> _lista = new List<ClsDetallePedido>();

            OdbcCommand _comando = new OdbcCommand(String.Format(
           "select  id_bien, cantidad, descripcion, precio, subtotal from devolucion_detventa where id_dev ='{0}' ", iddev), seguridad.Conexion.ObtenerConexionODBC());
            // "select id_impuesto, porcentaje, nombre, descripcion from categoria  where nombre_cat ='{0}' ", nomcat),
            OdbcDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                ClsDetallePedido pfact = new ClsDetallePedido();

             
                pfact.cod = _reader.GetInt16(0);
                pfact.cantidad = _reader.GetInt16(1);
                pfact.descripcion = _reader.GetString(2);
                pfact.prec = _reader.GetInt16(3);
                pfact.subtotal = _reader.GetInt16(4);

                _lista.Add(pfact);
            }

          
            return _lista;
        }


        public static int EliminarEncabeDevo(int id)
        {
            int iretorno = 0;
            OdbcConnection conexion = seguridad.Conexion.ObtenerConexionODBC();
            OdbcCommand comando = new OdbcCommand(string.Format("update devolucion_venta set estado='desactivado' where id_dev='{0}'",
                  id), conexion);
            iretorno = comando.ExecuteNonQuery();
            conexion.Close();

            return iretorno;

        }
        public static int EliminarDetalleDevo(int id)
        {
            int iretorno = 0;
            OdbcConnection conexion = seguridad.Conexion.ObtenerConexionODBC();
            OdbcCommand comando = new OdbcCommand(string.Format("update devolucion_detventa set estado='desactivado' where id_dev='{0}'",
                  id), conexion);
            iretorno = comando.ExecuteNonQuery();
            conexion.Close();

            return iretorno;

        }
    }
}
