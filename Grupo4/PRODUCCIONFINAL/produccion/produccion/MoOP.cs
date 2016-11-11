using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Data;
using System.Windows.Forms;

namespace produccion
{
    public class MoOP
    {
        public DataTable CargarPedidos()
        {
            try
            {
                OdbcConnection con = seguridad.Conexion.ObtenerConexionODBC();
                OdbcCommand cmd = new OdbcCommand("Select id_encabezado_pedido_pk from encabezado_pedido", con);
                DataTable dt = new DataTable();
                OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                da.Fill(dt);
                con.Close();
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Error de carga de datos");
                return null;
            }

        }
    }
}
