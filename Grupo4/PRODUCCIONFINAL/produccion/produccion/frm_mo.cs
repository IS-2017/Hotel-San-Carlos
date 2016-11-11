using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Autor: Yony Calito
 * UD:27/1072016
 * */
namespace produccion
{
    public partial class frm_mo : Form
    {
        public frm_mo()
        {
            InitializeComponent();
        }
        MoOP asig_mo = new MoOP();
        private void frm_mo_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = asig_mo.CargarPedidos();
                if (dt.Rows.Count != 0)
                {
                    cmb_pedido.DataSource = dt;
                    cmb_pedido.DisplayMember = "id_encabezado_pedido_pk";
                    cmb_pedido.ValueMember = "id_encabezado_pedido_pk";
                }
                else
                {
                    cmb_pedido.SelectedIndex = -1;
                }

            }
            catch
            { MessageBox.Show("Error en carga de pedidos", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error); ; }
            

            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
