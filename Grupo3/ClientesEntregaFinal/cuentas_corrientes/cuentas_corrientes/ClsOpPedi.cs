//using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cuentas_corrientes
{
    public class ClsOpPedi
    {
        public static int AgregarPedido(ClsPedido Pedi) //Para insertar datos a Mysql 
        {
            int iretorno = 0;
            OdbcCommand comando = new OdbcCommand(string.Format("insert into pedido (	id_pedido_pk, id_emp, fecha_pedido, estado_pedido, id_cliente_pk, estado, id_vendedor) values ('{0}','{1}','{2}','{3}','{4}','Activo','{6}')",
             Pedi.codped, Pedi.codemp, Pedi.fec_pedido.Date.ToString("yyyy-MM-dd"), Pedi.estado, Pedi.codcte, Pedi.estado2, Pedi.codvende), seguridad.Conexion.ObtenerConexionODBC());
            iretorno = comando.ExecuteNonQuery();// Retorna un 1 si se ejecuta la inserción y 0 es error.
            return iretorno;
        }

        public static int AgregarDetPedido(ClsDetallePedido detapedi) //Para insertar datos a Mysql 
        {
            int iretorno = 0;
            OdbcCommand comando = new OdbcCommand(string.Format("insert into detalle_pedido (id_detalle, id_emp, id_pedido_pk, id_bien_pk, cantidad, descripcion, precio, subtotal, id_precio, id_categoria_pk,  estado, estado_detalle )values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','Activo')",
              detapedi.cod, detapedi.idemple, detapedi.idpedi, detapedi.idbien, detapedi.cantidad, detapedi.descripcion, detapedi.prec, detapedi.subtotal,  detapedi.idprecio, detapedi.idcat, detapedi.estado, detapedi.estadetalle), seguridad.Conexion.ObtenerConexionODBC());
              iretorno = comando.ExecuteNonQuery();// Retorna un 1 si se ejecuta la inserción y 0 es error.
            return iretorno;
        }

       
    }
}
