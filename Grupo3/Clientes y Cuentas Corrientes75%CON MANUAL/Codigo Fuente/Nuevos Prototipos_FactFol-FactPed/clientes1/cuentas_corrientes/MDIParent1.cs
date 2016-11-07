using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dll_grafica;

namespace cuentas_corrientes
{
    public partial class MDIParent1 : Form
    {
        private int childFormNumber = 0;

        public MDIParent1()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Login temp = new Frm_Login();
            temp.MdiParent = this;
            temp.Show();
        }

        private void registroClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDataCliente temp = new frmDataCliente();
            temp.MdiParent = this;
            temp.Show();
        }

        private void registroClienteContribuyenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistroContribuyente temp = new frmRegistroContribuyente();
            temp.MdiParent = this;
            temp.Show();
        }

        private void tipoCreditoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDataTipoCredito temp = new frmDataTipoCredito();
            temp.MdiParent = this;
            temp.Show();
        }

        private void pedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
                        
        }

        private void cotizacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_cotizaciones temp = new frm_cotizaciones();
            temp.MdiParent = this;
            temp.Show();
        }

        private void facturacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void deudasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDataDeuda temp = new frmDataDeuda();
            temp.MdiParent = this;
            temp.Show();
        }

        private void operacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDataOperacion temp = new frmDataOperacion();
            temp.MdiParent = this;
            temp.Show();
        }

        private void impuestoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //frmImpuesto.show();
            frmDataImpuesto temp = new frmDataImpuesto();
            temp.MdiParent = this;
            temp.Show();
        }

        private void formaDePagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDataFormaPago temp = new frmDataFormaPago();
            temp.MdiParent = this;
            temp.Show();
        }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDataFactura temp = new frmDataFactura();
            temp.MdiParent = this;
            temp.Show();
        }

        private void listasDePreciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDataListadoPrecio temp = new frmDataListadoPrecio();
            temp.MdiParent = this;
            temp.Show();
        }

        private void parametrosFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDataParmFact temp = new frmDataParmFact();
            temp.MdiParent = this;
            temp.Show();
        }

        private void simpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graf1.frm_menu op = new Graf1.frm_menu();
            op.ShowDialog();
        }

        private void compuestoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_menu2 op = new frm_menu2();
            op.ShowDialog();
        }

        private void devolucionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Devoluciones op = new Devoluciones();
            op.ShowDialog();
        }

        private void tipoDePrecioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TipoPrecio op = new cuentas_corrientes.TipoPrecio();
            op.ShowDialog();
        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
