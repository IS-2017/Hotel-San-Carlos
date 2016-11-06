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
            OdbcCommand comando = new OdbcCommand(string.Format("insert into factura (id_fac_empresa_pk, id_empresa_pk, serie, id_empleados_pk, fecha_vencimiento, estado_factura, fecha_emision, subtotal, total, id_cliente_pk, id_impuesto_pk) values (NULL,'{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')",
               fact.cod_emp,fact.serie, fact.cod_emp,fact.fec_ven, fact.estado_fact, fact.fec_emision, fact.subtotal, fact.total, fact.cod_cte, fact.cod_imp), seguridad.Conexion.ObtenerConexionODBC());
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


    }
}
