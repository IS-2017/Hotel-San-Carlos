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
    public partial class frmBuscImpuesto : Form
    {
        public frmBuscImpuesto()
        {
            InitializeComponent();
        }

        private void btn_buscimp_Click(object sender, EventArgs e)
        {
            dgv_impuesto.DataSource = clsOpImpuesto.Buscar(txt_nom.Text);
        }
        public clsimpuesto ImpSelec { get; set; }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_impuesto.SelectedRows.Count == 1)
                {
                    int id = Convert.ToInt16(dgv_impuesto.CurrentRow.Cells[0].Value);
                    ImpSelec = clsOpImpuesto.Obtenerimp(id);

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

        private void frmBuscImpuesto_Load(object sender, EventArgs e)
        {

        }
    }
    }
