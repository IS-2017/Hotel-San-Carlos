using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototipo__RRHH
{
    public partial class MenuMDI : Form
    {
        private int childFormNumber = 0;


        frm_Prestamos frm_prest;
        Empleados frm_empleados;
        Comisiones_Vendedor comi_ve;
        Planilla_IGSS plan_igss;
        frm_Nominas_Empleados frm_nomin;
        frm_prestaciones_lab frm_prest_lab;



        public MenuMDI()
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



        private void rRHHToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }



        private void prestamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        

        private void empleadosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (frm_empleados == null)
            {
                frm_empleados = new Empleados();
                frm_empleados.MdiParent = this;
                frm_empleados.FormClosed += new FormClosedEventHandler(frm_empleados_FormClosed);
                frm_empleados.Show();
            }
        }

        void frm_empleados_FormClosed(object sender, EventArgs e)
        {
            frm_empleados = null;
        }

        private void comisionDeVendedorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (comi_ve == null)
            {
                comi_ve = new Comisiones_Vendedor();
                comi_ve.MdiParent = this;
                comi_ve.FormClosed += new FormClosedEventHandler(comi_ve_FormClosed);
                comi_ve.Show();
            }
        }

        void comi_ve_FormClosed(object sender, EventArgs e)
        {
            comi_ve = null;
        }

        private void planillaIGSSToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (plan_igss == null)
            {
                plan_igss = new Planilla_IGSS();
                plan_igss.MdiParent = this;
                plan_igss.FormClosed += new FormClosedEventHandler(plan_igss_FormClosed);
                plan_igss.Show();
            }
        }
        void plan_igss_FormClosed(object sender, EventArgs e)
        {
            plan_igss = null;
        }

        private void nominasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (frm_nomin == null)
            {
                frm_nomin = new frm_Nominas_Empleados();
                frm_nomin.MdiParent = this;
                frm_nomin.FormClosed += new FormClosedEventHandler(frm_nomin_FormClosed);
                frm_nomin.Show();
            }
        }
        void frm_nomin_FormClosed(object sender, EventArgs e)
        {
            frm_nomin = null;
        }

        private void prestamosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (frm_prest == null)
            {
                frm_prest = new frm_Prestamos();
                frm_prest.MdiParent = this;
                frm_prest.FormClosed += new FormClosedEventHandler(frm_prest_FormClosed);
                frm_prest.Show();
            }
        }
        void frm_prest_FormClosed(object sender, EventArgs e)
        {
            frm_prest = null;
        }

        private void salariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frm_prest_lab == null)
            {
                frm_prest_lab = new frm_prestaciones_lab();
                frm_prest_lab.MdiParent = this;
                frm_prest_lab.FormClosed += new FormClosedEventHandler(frm_prest_lab_FormClosed);
                frm_prest_lab.Show();
            }
        }
        void frm_prest_lab_FormClosed(object sender, EventArgs e)
        {
            frm_prest_lab = null;
        }
    }
}
