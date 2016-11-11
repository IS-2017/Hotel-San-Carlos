using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using MySql.Data.MySqlClient;
using System.Data.Odbc;
using seguridad;

namespace cuentas_corrientes
{
    public partial class frmDataFormaPago : Form
    {
        public frmDataFormaPago()
        {
            InitializeComponent();

            OdbcConnection conexion = seguridad.Conexion.ObtenerConexionODBC();
            OdbcDataAdapter dausuario = new OdbcDataAdapter("SELECT id_forma_pk, tipo_pago, descripcion FROM forma_pago where estado='activo'", conexion);
            DataSet dsuario = new DataSet();
            dausuario.Fill(dsuario, "forma_pago");
            dgv_formapago.DataSource = dsuario;
            dgv_formapago.DataMember = "forma_pago";
        }

        private void frmDataFormaPago_Load(object sender, EventArgs e)
        {

        }

        public clsFomPago fmSelec { get; set; }
        private void btn_nuevo_Click(object sender, EventArgs e)
        {
           
            
                frmFormaDePago tem = new frmFormaDePago(fmSelec);
                tem.ShowDialog();
            
        }

        private void dgv_formapago_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            OdbcConnection conexion = seguridad.Conexion.ObtenerConexionODBC();
            OdbcDataAdapter dausuario = new OdbcDataAdapter("SELECT id_forma_pk, tipo_pago, descripcion FROM forma_pago where estado='activo'", conexion);
            DataSet dsuario = new DataSet();
            dausuario.Fill(dsuario, "forma_pago");
            dgv_formapago.DataSource = dsuario;
            dgv_formapago.DataMember = "forma_pago";
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            dllconsultas.operaciones op = new dllconsultas.operaciones();
            op.ejecutar(dgv_formapago, "forma_pago");
        }

        private void dgv_formapago_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_formapago.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt16(dgv_formapago.CurrentRow.Cells[0].Value);
                fmSelec = clsOpFormPago.Obtenerimp(id);
                cuentas_corrientes.frmFormaDePago impe = new cuentas_corrientes.frmFormaDePago(fmSelec);
                impe.ShowDialog();

            }
            else
            {
                frmFormaDePago tem = new frmFormaDePago(fmSelec);
                tem.ShowDialog();
            }
        }
    }
}
