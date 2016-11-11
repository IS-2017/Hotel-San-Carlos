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

        public int id;
        private void dgv_operacion_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id = Convert.ToInt16(dgv_operacion.CurrentRow.Cells[0].Value);
                //MessageBox.Show(Convert.ToString(id));
                string snom = dgv_operacion.Rows[dgv_operacion.CurrentCell.RowIndex].Cells[4].Value.ToString();
                string sapel = dgv_operacion.Rows[dgv_operacion.CurrentCell.RowIndex].Cells[1].Value.ToString();
                string sdpi = dgv_operacion.Rows[dgv_operacion.CurrentCell.RowIndex].Cells[2].Value.ToString();
                string snit = dgv_operacion.Rows[dgv_operacion.CurrentCell.RowIndex].Cells[5].Value.ToString();
                string sdirec = dgv_operacion.Rows[dgv_operacion.CurrentCell.RowIndex].Cells[3].Value.ToString();                                              
                frmoperacion temp = new frmoperacion(snom, sapel, sdpi, snit, sdirec);
                temp.id(id);
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
