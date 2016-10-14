using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class ModuloProveedores : Form
    {
        private int childFormNumber = 0;
        frm_inicio Login;

        public ModuloProveedores()
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

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        { }
              private void logInToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Login == null)
            {
                Login = new frm_inicio();
                 Login.MdiParent = this;
                Login.Show();

            }
        }

        private void rRHHToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
    }

