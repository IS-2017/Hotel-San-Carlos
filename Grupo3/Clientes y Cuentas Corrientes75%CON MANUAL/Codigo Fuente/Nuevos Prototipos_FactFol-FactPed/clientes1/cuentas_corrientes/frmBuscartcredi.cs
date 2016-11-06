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
    public partial class frmBuscartcredi : Form
    {
        public frmBuscartcredi()
        {
            InitializeComponent();
        }

        private void btn_busc_Click(object sender, EventArgs e)
        {
            try
            {
                dgv_btc.DataSource = clsOtcredi.Buscar(txt_tipo.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public cls_tcredi destc { get; set; }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_btc.SelectedRows.Count == 1)
                {
                    int id = Convert.ToInt16(dgv_btc.CurrentRow.Cells[0].Value);
                    destc = clsOtcredi.Obtenercredi(id);

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
