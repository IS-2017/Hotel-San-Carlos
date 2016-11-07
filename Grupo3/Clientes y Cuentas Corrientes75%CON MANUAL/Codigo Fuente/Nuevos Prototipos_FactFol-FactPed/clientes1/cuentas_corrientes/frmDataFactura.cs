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
    public partial class frmDataFactura : Form
    {
        public frmDataFactura()
        {
            InitializeComponent();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            frmFactura temp = new frmFactura();
            temp.ShowDialog();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            dllconsultas.operaciones op = new dllconsultas.operaciones();
            op.ejecutar(dgv_fact, "factura");
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {            
            OdbcConnection conexion = seguridad.Conexion.ObtenerConexionODBC();
            OdbcDataAdapter dausuario = new OdbcDataAdapter("SELECT * FROM factura", conexion);
            DataSet dsuario = new DataSet();
            dausuario.Fill(dsuario, "factura");
            dgv_fact.DataSource = dsuario;
            dgv_fact.DataMember = "factura";
        }
    }
}
