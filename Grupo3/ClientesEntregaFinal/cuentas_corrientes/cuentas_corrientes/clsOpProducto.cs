//using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cuentas_corrientes
{
    class clsOpProducto
    {
        public static List<cls_Producto> Buscar(string prod) //Método tipo lista, que retornar el resultado dela busqueda
        {
            List<cls_Producto> _lista = new List<cls_Producto>();
            //MessageBox.Show(credi);
            OdbcCommand _comando = new OdbcCommand(String.Format(
           "select bien.id_bien_pk, bien.descripcion, pre.precio, cat.id_categoria_pk, pre.id_precio,  pro.existencia,  cat.tipo_categoria from precio as pre Inner Join bien as bien Inner Join categoria as cat Inner Join producto_bodega as pro Inner Join bodega as bod on pre.id_precio = bien.id_bien_pk and pro.id_bien_pk = bien.id_bien_pk and pre.id_bien_pk = pre.id_bien_pk and bien.id_categoria_pk = cat.id_categoria_pk and pro.id_bodega_pk = bod.id_bodega_pk where bien.descripcion like '%{0}%'", prod), seguridad.Conexion.ObtenerConexionODBC());
            OdbcDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                cls_Producto produc = new cls_Producto();
                produc.id_bien_pk = _reader.GetInt32(0);
                produc.descripcion = _reader.GetString(1);
                produc.precio = _reader.GetDecimal(2);
                produc.id_categoria_pk = _reader.GetInt32(3);
                produc.id_precio = _reader.GetInt32(4);
                produc.existencia = _reader.GetInt32(5);
                produc.tipo_categoria = _reader.GetString(6);

                _lista.Add(produc);
            }

            return _lista;
        }

        public static cls_Producto Obtenerclte(int id_cl)
        {
            cls_Producto cl = new cls_Producto();

            OdbcConnection conexion = seguridad.Conexion.ObtenerConexionODBC();

            OdbcCommand _comando = new OdbcCommand(String.Format("select bien.id_bien_pk, bien.descripcion, pre.precio, cat.id_categoria_pk, pre.id_precio,  pro.existencia,  cat.tipo_categoria from precio as pre Inner Join bien as bien Inner Join categoria as cat Inner Join producto_bodega as pro Inner Join bodega as bod on pre.id_precio = bien.id_bien_pk and pro.id_bien_pk = bien.id_bien_pk and pre.id_bien_pk = pre.id_bien_pk and bien.id_categoria_pk = cat.id_categoria_pk and pro.id_bodega_pk = bod.id_bodega_pk where bien.id_bien_pk= {0}", id_cl), conexion);
            OdbcDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                cl.id_bien_pk = _reader.GetInt16(0);
                cl.descripcion = _reader.GetString(1);
                cl.precio = _reader.GetDecimal(2);
                cl.id_categoria_pk = _reader.GetInt16(3);
                cl.id_precio = _reader.GetInt16(4);
                cl.existencia = _reader.GetInt16(5);
                cl.tipo_categoria = _reader.GetString(6);
            }

            conexion.Close();
            return cl;
        }

        public static cls_ModificarPedido ObtenerPedido(int detprod)
        {
            cls_ModificarPedido modi = new cls_ModificarPedido();
            OdbcConnection conexion = seguridad.Conexion.ObtenerConexionODBC();

            OdbcCommand _comando = new OdbcCommand(String.Format("select p.id_pedido_pk, p.id_emp, p.id_vendedor, p.id_cliente_pk, p.fecha_pedido, d.id_pedido_pk, d.id_bien_pk, d.cantidad, d.descripcion, d.precio, d.subtotal, d.id_precio from pedido as p inner join detalle_pedido as d on p.id_pedido_pk = d.id_pedido_pk ", modi), conexion);
            OdbcDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                modi.idempresa = _reader.GetInt16(0);
                modi.fecha = _reader.GetDateTime(1);
                modi.estado_pedido = _reader.GetString(2);
                modi.id_cliente = _reader.GetInt16(3);
                modi.estado = _reader.GetString(4);
                modi.idvendedor = _reader.GetInt16(5);
                modi.idbien = _reader.GetInt16(6);
                modi.cantidad = _reader.GetInt16(7);
                modi.descripcion = _reader.GetString(8);
                modi.precio = _reader.GetDecimal(9);
                modi.subtotal = _reader.GetDecimal(10);
                modi.idcat = _reader.GetInt16(11);
                modi.esta = _reader.GetString(12);
                modi.esta_detalle = _reader.GetString(13);             
            }

            conexion.Close();
            return modi;
        }
    }
}
