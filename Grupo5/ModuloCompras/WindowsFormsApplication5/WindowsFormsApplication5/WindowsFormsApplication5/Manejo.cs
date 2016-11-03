using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication5
{
    class Manejo
    {
        public static int compra(String factura, String pedido, String serie, String fecha, String encargado, String total, String estado, String cuenta, String proveedor, String pago)
        {
            try
            {
                MySqlConnection con = new MySqlConnection("server=localhost; database=hotelsancarlos; Uid=root; pwd=;");
                int devolver = 0;
                MySqlCommand cmd = new MySqlCommand(string.Format("insert into compra(id_factura_pk, id_pedido_compra_pk, serie_factura, fecha_recibida, encargado, total, estado, id_cuenta_pk, id_proveedor_pk, id_forma_pk)" +
                    " values('" + factura + "','" + pedido + "','" + serie + "','" + fecha + "','" + encargado + "','" + total + "','"+ estado +"','" + cuenta + "','" + proveedor + "','" + pago +  "')"), con);
                devolver = cmd.ExecuteNonQuery();
                return devolver;
            }
            catch
            {
                return 1;
            }
        }

    }
}
