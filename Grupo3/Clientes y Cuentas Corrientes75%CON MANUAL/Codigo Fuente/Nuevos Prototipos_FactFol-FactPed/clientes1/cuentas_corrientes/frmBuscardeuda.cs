using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cuentas_corrientes
{
    public partial class frmBuscardeuda : Form
    {
        public frmBuscardeuda()
        {
            InitializeComponent();
        }

        private void btn_busd_Click(object sender, EventArgs e)
        {
            try
            {
                dgv_deuda.DataSource = clsOdeuda.Buscar(txt_deuda.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public cls_deuda descl { get; set; }
        private void btn_acpt_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_deuda.SelectedRows.Count == 1)
                {
                    int id = Convert.ToInt16(dgv_deuda.CurrentRow.Cells[0].Value);
                    descl = clsOdeuda.Obtenerdeu(id);

                    this.Close();
                }
                else
                    MessageBox.Show("Debe de seleccionar una fila");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
