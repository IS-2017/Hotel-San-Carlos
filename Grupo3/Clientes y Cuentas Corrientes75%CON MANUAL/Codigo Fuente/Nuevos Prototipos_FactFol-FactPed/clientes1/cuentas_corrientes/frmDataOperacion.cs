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
using seguridad;

namespace cuentas_corrientes
{
    public partial class frmDataOperacion : Form
    {
        public frmDataOperacion()
        {
            InitializeComponent();

            OdbcConnection conexion = seguridad.Conexion.ObtenerConexionODBC();
            OdbcDataAdapter dausuario = new OdbcDataAdapter("SELECT * FROM operacion", conexion);
            DataSet dsuario = new DataSet();
            dausuario.Fill(dsuario, "operacion");
            dgv_operacion.DataSource = dsuario;
            dgv_operacion.DataMember = "operacion";
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            frmoperacion temp = new frmoperacion();
            temp.ShowDialog();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            dllconsultas.operaciones op = new dllconsultas.operaciones();
            op.ejecutar(dgv_operacion, "operacion");
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            OdbcConnection conexion = seguridad.Conexion.ObtenerConexionODBC();
            OdbcDataAdapter dausuario = new OdbcDataAdapter("SELECT * FROM operacion", conexion);
            DataSet dsuario = new DataSet();
            dausuario.Fill(dsuario, "operacion");
            dgv_operacion.DataSource = dsuario;
            dgv_operacion.DataMember = "operacion";
        }
    }
}
