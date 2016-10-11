using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;

namespace PruebaBitacoraSeguridad
{
    public partial class frmtabla_bitacora : Form
    {
        public frmtabla_bitacora()
        {
            InitializeComponent();
        }

        private void frmtabla_bitacora_Load(object sender, EventArgs e)
        {
            Conexion.Conexion.ObtenerConexionODBC();
            DataTable dt = CargarGrid("select * from bitacora");
            dataGridView1.DataSource = dt;
        }

        public static DataTable CargarGrid(String query)
        {
            DataTable dt = new DataTable();
            OdbcCommand comando = new OdbcCommand(query, Conexion.Conexion.ObtenerConexionODBC());
            OdbcDataAdapter adaptador = new OdbcDataAdapter(comando);
            adaptador.Fill(dt);
            return dt;
        }

    }
}
