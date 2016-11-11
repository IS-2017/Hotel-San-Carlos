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
    public partial class frmBuscProdDev : Form
    {
        public ClsDetalleFact DetSelec { get; set; }
        public frmBuscProdDev(ClsFactura fact)
        {
            InitializeComponent();

            //MessageBox.Show(Convert.ToString(fact.cod_fact));
            dgv_detalle.DataSource = Cls_OpDevo.BuscarDet(fact.cod_fact);
          //  dgv_detalle.Columns.Remove("cod_fact");
            //dgv_detalle.Columns.Remove("cod_emp");
           //dgv_detalle.Columns.Remove("serie");
            
        }

        private void frmBuscProdDev_Load(object sender, EventArgs e)
        {

        }

       
       
        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_detalle.SelectedRows.Count == 1)
                {
                    int id = Convert.ToInt16(dgv_detalle.CurrentRow.Cells[0].Value);

                    DetSelec = Cls_OpDevo.Obtenerbien(id);
                    //MessageBox.Show(FolSelec.estado);

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
