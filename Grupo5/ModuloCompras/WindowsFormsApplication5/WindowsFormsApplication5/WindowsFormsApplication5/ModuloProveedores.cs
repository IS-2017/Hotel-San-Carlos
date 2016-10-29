using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Abrir;

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
                Login.StartPosition = FormStartPosition.CenterScreen;
                Login.Show();

            }
        }

        private void rRHHToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cuentaCorrienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CC_Proveedor cc = new CC_Proveedor();
            cc.MdiParent = this;
            cc.StartPosition = FormStartPosition.CenterScreen;
            cc.Show();
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Abrir.Form2 fv = new Form2();
                //Ubicacion Del TXT que se encuenta en el RAR
                fv.ARCHIVO = @"C:\Users\ccarrera\Desktop\llenarDataGrid.txt";
                fv.StartPosition = FormStartPosition.CenterScreen;
                fv.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompraProveedores abrir = new CompraProveedores();
            abrir.MdiParent = this;
            abrir.StartPosition = FormStartPosition.CenterScreen;
            abrir.Show();
        }

        private void ordenDeCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrdenCompra or = new OrdenCompra();
            or.MdiParent = this;
            or.StartPosition = FormStartPosition.CenterScreen;
            or.Show();
        }

        private void ModuloProveedores_Load(object sender, EventArgs e)
        {
            MdiClient Chld;
            foreach(Control crtl in this.Controls)
            {
                try
                {
                    Chld = (MdiClient)crtl;
                    Chld.BackColor = this.BackColor;
                }
                catch (InvalidCastException exe)
                { }
            }
        }
    }
    }

