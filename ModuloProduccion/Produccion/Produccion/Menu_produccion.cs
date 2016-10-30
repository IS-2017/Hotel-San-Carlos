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
    public partial class Menu_produccion : Form
    {
        private int childFormNumber = 0;
        Form_login nflog = new Form_login();
        frm_buscacliente nfcte = new frm_buscacliente();
        frm_mo nfmo = new frm_mo();
        frm_mp nfmp = new frm_mp();
        frm_pedido nfped = new frm_pedido();
        frm_prod nfprod = new frm_prod();
        frm_requisicion nfreq = new frm_requisicion();
        modificar_pedido nfmodped = new modificar_pedido();
        frm_menu nfmen = new frm_menu();
        frm_NuevoProceso nfproc = new frm_NuevoProceso();
        frm_modificar_recetario nmfrecetario = new frm_modificar_recetario();
        frm_nuevaformula nfformula = new frm_nuevaformula();
        frm_recetario recetario = new frm_recetario();
        

        public Menu_produccion()
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

        private void Menu_produccion_Load(object sender, EventArgs e)
        {
            MdiClient ctlMDI;
            foreach (Control ctl in this.Controls)
            {
                try
                {
                    // Attempt to cast the control to type MdiClient.
                    ctlMDI = (MdiClient)ctl;

                    // Set the BackColor of the MdiClient control.
                    ctlMDI.BackColor = this.BackColor;
                }
                catch (InvalidCastException exc)
                {
                    // Catch and ignore the error if casting failed.
                }
            }
            nflog = null;
            nfcte = null;
            nfmo = null;
            nfmp = null;
            nfped = null;
            nfprod = null;
            nfreq = null;
            nfmodped = null;
            nfmen = null;
            nfproc = null;
            nmfrecetario = null;
            nfformula = null;
            nfped = null;
            nfprod = null;
            recetario = null;

            // Display a child form to show this is still an MDI application.
            //Form2 frm = new Form2();
            //frm.MdiParent = this;
            //frm.Show();
        }

        private void crearToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (nfped == null)
            {
                nfped = new frm_pedido();
                nfped.MdiParent = this;
                nfped.FormClosed += new FormClosedEventHandler(frm_pedido_FormClosed);
                nfped.StartPosition = FormStartPosition.CenterParent;
                nfped.Show();
            }
        }

        private void frm_pedido_FormClosed(object sender, FormClosedEventArgs e)
        {
            nfped = null;
        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void visualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (nfmen == null)
            {
                nfmen = new frm_menu();
                nfmen.MdiParent = this;
                nfmen.FormClosed += new FormClosedEventHandler(frm_menu_FormClosed);
                nfmen.StartPosition = FormStartPosition.CenterParent;
                nfmen.Show();
            }
        }

        private void frm_menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            nfmen = null;
        }

        private void frm_modificar_recetario_FormClosed(object sender, FormClosedEventArgs e)
        {
            nfmen = null;
        }

        private void crearToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (nfproc == null)
            {
                nfproc = new frm_NuevoProceso();
                nfproc.MdiParent = this;
                nfproc.FormClosed += new FormClosedEventHandler(frm_NuevoProceso_FormClosed);
                nfproc.StartPosition = FormStartPosition.CenterParent;
                nfproc.Show();
            }

        }

        private void frm_NuevoProceso_FormClosed(object sender, FormClosedEventArgs e)
        {
            nfproc = null;
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void crearToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (nfformula == null)
            {
                nfformula = new frm_nuevaformula(); ;
                nfformula.MdiParent = this;
                nfformula.FormClosed += new FormClosedEventHandler(frm_nuevaformula_FormClosed);
                nfformula.StartPosition = FormStartPosition.CenterParent;
                nfformula.Show();
            }
        }

        private void frm_nuevaformula_FormClosed(object sender, FormClosedEventArgs e)
        {
            nfformula = null;
        }
        // mostrar recetario para modificar o consultar
        private void modificarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (recetario == null)
            {
                recetario = new frm_recetario();
                recetario.MdiParent = this;
                recetario.FormClosed += new FormClosedEventHandler(frm_recetario_FormClosed);
                recetario.StartPosition = FormStartPosition.CenterParent;
                recetario.Show();
            }
        }

        private void frm_recetario_FormClosed(object sender, FormClosedEventArgs e)
        {
            recetario = null;
        }

        private void crearToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if (nfprod == null)
            {
                nfprod = new frm_prod();
                nfprod.MdiParent = this;
                nfprod.FormClosed += new FormClosedEventHandler(frm_prod_FormClosed);
                nfprod.StartPosition = FormStartPosition.CenterParent;
                nfprod.Show();
            }
        }

        private void frm_prod_FormClosed(object sender, FormClosedEventArgs e)
        {
            nfprod = null;
        }
    }
}
/*if(nfmen==null)
           {
               nfmen = new frm_menu();
nfmen.MdiParent = this;
               nfmen.FormClosed += new FormClosedEventHandler(frm_menu_FormClosed);
nfmen.StartPosition = FormStartPosition.CenterParent;
               nfmen.Show();
           }

    private void frm_menu_FormClosed(object sender, FormClosedEventArgs e)
       {
           nfmen = null;
       }
*/
