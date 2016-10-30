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
        private const string ayudaCHM = "Ayuda-Modulo-RRHH.chm";
        private const string indiceCHM = "support.html";
        private const string acercasistema = "acercadelsistema.html";

        frm_Deducciones frm_prest;
        Empleados frm_empleados;
        Comisiones_Vendedor comi_ve;
        Planilla_IGSS plan_igss;
        frm_Nominas_Empleados frm_nomin;
        frm_Devengados frm_prest_lab;
        frm_Empleados_grid frm_emp_dgv;
        frm_Deducciones_grid frm_deducc_grid;
        frm_Devengados_grid frm_deveng_grid;
        frm_Nominas_Empleados_grid frm_nomin_emp_grid;



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

        private void prestamosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (frm_deducc_grid == null)
            {
                frm_deducc_grid = new frm_Deducciones_grid();
                frm_deducc_grid.MdiParent = this;
                frm_deducc_grid.FormClosed += new FormClosedEventHandler(frm_deducc_grid_FormClosed);
                frm_deducc_grid.Show();
            }
        }
        void frm_deducc_grid_FormClosed(object sender, EventArgs e)
        {
            frm_deducc_grid = null;
        }

        private void salariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frm_deveng_grid == null)
            {
                frm_deveng_grid = new frm_Devengados_grid();
                frm_deveng_grid.MdiParent = this;
                frm_deveng_grid.FormClosed += new FormClosedEventHandler(frm_deveng_grid_lab_FormClosed);
                frm_deveng_grid.Show();
            }
        }
        void frm_deveng_grid_lab_FormClosed(object sender, EventArgs e)
        {
            frm_deveng_grid = null;
        }

        private void contentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Help.ShowHelp(this, Application.StartupPath + @"\" + ayudaCHM);
        }

        private void indexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, ayudaCHM, HelpNavigator.Topic, indiceCHM);
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, ayudaCHM, HelpNavigator.Find, "");
        }

        private void empleadosToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            if (frm_emp_dgv == null)
            {
                frm_emp_dgv = new frm_Empleados_grid();
                frm_emp_dgv.MdiParent = this;
                frm_emp_dgv.FormClosed += new FormClosedEventHandler(frm_empleados_FormClosed);
                frm_emp_dgv.Show();
            }
        }

        void frm_empleados_FormClosed(object sender, EventArgs e)
        {
            frm_emp_dgv = null;
        }

        private void comisionDeVendedorToolStripMenuItem1_Click_1(object sender, EventArgs e)
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

        private void nominasToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            if (frm_nomin_emp_grid == null)
            {
                frm_nomin_emp_grid = new frm_Nominas_Empleados_grid();
                frm_nomin_emp_grid.MdiParent = this;
                frm_nomin_emp_grid.FormClosed += new FormClosedEventHandler(frm_nomin_emp_grid_FormClosed);
                frm_nomin_emp_grid.Show();
            }
        }
        void frm_nomin_emp_grid_FormClosed(object sender, EventArgs e)
        {
            frm_nomin_emp_grid = null;
        }

        private void planillaIGSSToolStripMenuItem1_Click_1(object sender, EventArgs e)
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
    }
}
