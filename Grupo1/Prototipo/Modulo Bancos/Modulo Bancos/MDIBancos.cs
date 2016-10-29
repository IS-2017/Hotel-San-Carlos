using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modulo_Bancos
{
    public partial class MDIBancos : Form
    {
        private int childFormNumber = 0;
        Documento doc;
        Cheque_Voucher che_Vo;
        Conciliacion_Bancaria con_ban;
        Disponibilidad_bancaria disp_ban;
        Tipo_Documento tip_doc;
        Busqueda_Documento busq_doc;

        public MDIBancos()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
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

        private void documentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (doc == null)
            {
                busq_doc = new Busqueda_Documento();
                busq_doc.MdiParent = this;
                busq_doc.FormClosed += new FormClosedEventHandler(documento_FormClosed);
                busq_doc.Show();
            }
        }

        void documento_FormClosed(object sender, EventArgs e)
        {
            busq_doc = null;
        }

        private void chequeVoucherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (che_Vo == null)
            {
                che_Vo = new Cheque_Voucher();
                che_Vo.MdiParent = this;
                che_Vo.FormClosed += new FormClosedEventHandler(cheque_voucher_FormClosed);
                che_Vo.Show();
            }
        }
        void cheque_voucher_FormClosed(object sender, EventArgs e)
        {
            che_Vo = null;
        }

        private void MDIBancos_Load(object sender, EventArgs e)
        {

        }

        private void conciliacionBancariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (con_ban == null)
            {
                con_ban = new Conciliacion_Bancaria();
                con_ban.MdiParent = this;
                con_ban.FormClosed += new FormClosedEventHandler(Conciliacion_Bancaria_FormClosed);
                con_ban.Show();
                
            }
        }

        private void Conciliacion_Bancaria_FormClosed(object sender, EventArgs e)
        {

        }

        private void disponibilidadBancariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (disp_ban == null)
            {
                disp_ban = new Disponibilidad_bancaria();
                disp_ban.MdiParent = this;
                disp_ban.FormClosed += new FormClosedEventHandler(disp_ban_FormClosed);
                disp_ban.Show();

            }
        }
        void disp_ban_FormClosed(object sender, EventArgs e)
        {
            disp_ban = null;
        }

        private void tipoDocumentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tip_doc == null)
            {
                tip_doc = new Tipo_Documento();
                tip_doc.MdiParent = this;
                tip_doc.FormClosed += new FormClosedEventHandler(tip_doc_FormClosed);
                tip_doc.Show();

            }
        }

        void tip_doc_FormClosed(object sender, EventArgs e)
        {
            tip_doc = null;
        }
    }
}
