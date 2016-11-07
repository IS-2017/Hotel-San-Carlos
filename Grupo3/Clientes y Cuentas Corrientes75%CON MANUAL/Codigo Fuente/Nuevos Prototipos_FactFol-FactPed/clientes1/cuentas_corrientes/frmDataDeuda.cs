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
    public partial class frmDataDeuda : Form
    {
        public frmDataDeuda()
        {
            InitializeComponent();
            OdbcConnection conexion = seguridad.Conexion.ObtenerConexionODBC();
            OdbcDataAdapter dausuario = new OdbcDataAdapter("SELECT * FROM deuda", conexion);
            DataSet dsuario = new DataSet();
            dausuario.Fill(dsuario, "deuda");
            dgv_deuda.DataSource = dsuario;
            dgv_deuda.DataMember = "deuda";

        }

        public cls_deuda ImpSelec { get; set; }
        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            if (dgv_deuda.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt16(dgv_deuda.CurrentRow.Cells[0].Value);
                ImpSelec = clsOdeuda.Obtenerdeu(id);
                cuentas_corrientes.frmdeuda impe = new cuentas_corrientes.frmdeuda(ImpSelec);
                impe.ShowDialog();

            }
            else
            {
                frmdeuda tem = new frmdeuda(ImpSelec);
                tem.ShowDialog();
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            dllconsultas.operaciones op = new dllconsultas.operaciones();
            op.ejecutar(dgv_deuda, "deuda");
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            OdbcConnection conexion = seguridad.Conexion.ObtenerConexionODBC();
            OdbcDataAdapter dausuario = new OdbcDataAdapter("SELECT * FROM deuda", conexion);
            DataSet dsuario = new DataSet();
            dausuario.Fill(dsuario, "deuda");
            dgv_deuda.DataSource = dsuario;
            dgv_deuda.DataMember = "deuda";
        }

        private void dgv_deuda_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string smon = dgv_deuda.Rows[dgv_deuda.CurrentCell.RowIndex].Cells[1].Value.ToString();
                string sst = dgv_deuda.Rows[dgv_deuda.CurrentCell.RowIndex].Cells[2].Value.ToString();
                string scl = dgv_deuda.Rows[dgv_deuda.CurrentCell.RowIndex].Cells[3].Value.ToString();
                string sfac = dgv_deuda.Rows[dgv_deuda.CurrentCell.RowIndex].Cells[4].Value.ToString();
                string semp = dgv_deuda.Rows[dgv_deuda.CurrentCell.RowIndex].Cells[5].Value.ToString();
                string sser = dgv_deuda.Rows[dgv_deuda.CurrentCell.RowIndex].Cells[6].Value.ToString();
                frmdeuda temp = new frmdeuda(smon, sst, scl, sfac, semp, sser);
                temp.ShowDialog(this);
                //funActualizarGrid();
            }
            catch (Exception)
            {
                MessageBox.Show("Error Al editar el Registro");
            }        
        }
    }
}
