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
    public partial class Devoluciones : Form
    {
        public Devoluciones()
        {
            InitializeComponent();
            OdbcConnection conexion = seguridad.Conexion.ObtenerConexionODBC();
            OdbcDataAdapter dausuario = new OdbcDataAdapter("SELECT * FROM devolucion_venta", conexion);
            DataSet dsuario = new DataSet();
            dausuario.Fill(dsuario, "devolucion_venta");
            dgv_dev.DataSource = dsuario;
            dgv_dev.DataMember = "devolucion_venta";
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dgv_dev_DoubleClick(object sender, EventArgs e)
        {
        //    try
          //  {
                /*ClsFactura fact = new ClsFactura();
                fact.cod_fact = Convert.ToInt16(dgv_dev.Rows[dgv_dev.CurrentCell.RowIndex].Cells[0].Value.ToString());
                fact.cod_emp = Convert.ToInt16(dgv_dev.Rows[dgv_dev.CurrentCell.RowIndex].Cells[1].Value.ToString());
                fact.cod_imp = Convert.ToInt16(dgv_dev.Rows[dgv_dev.CurrentCell.RowIndex].Cells[2].Value.ToString());
                fact.serie = dgv_dev.Rows[dgv_dev.CurrentCell.RowIndex].Cells[3].Value.ToString();
                fact.cod_cte = Convert.ToInt16(dgv_dev.Rows[dgv_dev.CurrentCell.RowIndex].Cells[4].Value.ToString());
                fact.fec_emision = dgv_dev.Rows[dgv_dev.CurrentCell.RowIndex].Cells[5].Value.ToString();
                fact.estado_fact = dgv_dev.Rows[dgv_dev.CurrentCell.RowIndex].Cells[6].Value.ToString();
                fact.total = Convert.ToInt16(dgv_dev.Rows[dgv_dev.CurrentCell.RowIndex].Cells[7].Value.ToString());
                
    *frmDevolucion temp = new frmDevolucion(fact);
                temp.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            */

        }

        private void dgv_dev_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //public ClsFactura ImpSelec { get; set; }
        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            string imp = "";
            frmDevolucion temp = new frmDevolucion(imp);
            temp.Show();
        }
    }
}
