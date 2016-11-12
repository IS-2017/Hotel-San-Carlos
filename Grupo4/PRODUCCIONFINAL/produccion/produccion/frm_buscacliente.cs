using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace produccion
{
    public partial class frm_buscacliente : Form
    {
        public frm_buscacliente()
        {
            InitializeComponent();
        }
        public info_cte cte_seleccionado {get;set;}
        pedido pedido = new pedido();
        private void frm_buscacliente_Load(object sender, EventArgs e)
        {

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string parametro = txt_parametro.Text.Trim();
            DataTable dt = new DataTable();
            dt = pedido.buscar_cte(parametro);
            try
            {
                if (dt.Rows.Count != 0)
                {
                    dgv_cte.DataSource = dt;
                    dgv_cte.Refresh();
                }
                else
                {
                    MessageBox.Show("Cliente no existe", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            { MessageBox.Show("Error en carga de datos", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (dgv_cte.SelectedRows.Count == 1)
            {
                string id = Convert.ToString(dgv_cte.CurrentRow.Cells["id_cliente_pk"].Value);
                cte_seleccionado = pedido.obtener_cte(id);
                this.Close();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila");
            }
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string parametro = txt_parametro.Text.Trim();
            DataTable dt = new DataTable();
            dt = pedido.buscar_cte(parametro);
            try
            {
                if (dt.Rows.Count != 0)
                {
                    dgv_cte.DataSource = dt;
                    dgv_cte.Refresh();
                }
                else
                {
                    MessageBox.Show("Cliente no existe", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            { MessageBox.Show("Error en carga de datos", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
