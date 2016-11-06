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
    public partial class frmDataTipoCredito : Form
    {
        public frmDataTipoCredito()
        {
            InitializeComponent();

            //InitializeComponent();
            OdbcConnection conexion = seguridad.Conexion.ObtenerConexionODBC();
            OdbcDataAdapter dausuario = new OdbcDataAdapter("SELECT * FROM tipo_credito", conexion);
            DataSet dsuario = new DataSet();
            dausuario.Fill(dsuario, "tipo_credito");
            dgv_tipocred.DataSource = dsuario;
            dgv_tipocred.DataMember = "tipo_credito";
        }

        public cls_tcredi ImpSelec { get; set; }
        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            if (dgv_tipocred.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt16(dgv_tipocred.CurrentRow.Cells[0].Value);
                ImpSelec = clsOtcredi.Obtenercredi(id);
                cuentas_corrientes.frmTipocredito impe = new cuentas_corrientes.frmTipocredito(ImpSelec);
                impe.ShowDialog();

            }
            else
            {
                frmTipocredito tem = new frmTipocredito(ImpSelec);
                tem.ShowDialog();
            }
        }

        private void dgv_tipocred_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string sCodigo = dgv_tipocred.Rows[dgv_tipocred.CurrentCell.RowIndex].Cells[0].Value.ToString();
                string stipo = dgv_tipocred.Rows[dgv_tipocred.CurrentCell.RowIndex].Cells[1].Value.ToString();
                string svalor = dgv_tipocred.Rows[dgv_tipocred.CurrentCell.RowIndex].Cells[2].Value.ToString();
                frmTipocredito temp = new frmTipocredito(sCodigo, stipo, svalor);
                temp.ShowDialog(this);
                //funActualizarGrid();
            }
            catch (Exception)
            {
                MessageBox.Show("Error Al editar el Registro");
            }
        }

        private void frmDataTipoCredito_Load(object sender, EventArgs e)
        {

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            dllconsultas.operaciones op = new dllconsultas.operaciones();
            op.ejecutar(dgv_tipocred, "tipo_credito");
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            OdbcConnection conexion = seguridad.Conexion.ObtenerConexionODBC();
            OdbcDataAdapter dausuario = new OdbcDataAdapter("SELECT * FROM tipo_credito", conexion);
            DataSet dsuario = new DataSet();
            dausuario.Fill(dsuario, "tipo_credito");
            dgv_tipocred.DataSource = dsuario;
            dgv_tipocred.DataMember = "tipo_credito";
        }
    }
}
