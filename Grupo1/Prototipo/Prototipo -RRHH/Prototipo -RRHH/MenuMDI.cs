using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using seguridad;
using FuncionesNavegador;

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
        Comisiones_linea comi_linea;
        Comision_marca comi_marca;
        comisiones_producto comi_prod;
        Reporte_Planilla_IGSS plan_igss;
        
        frm_Nominas_Empleados frm_nomin;
        frm_Devengados frm_prest_lab;
        frm_Empleados_grid frm_emp_dgv;
        frm_Deducciones_grid frm_deducc_grid;
        frm_Devengados_grid frm_deveng_grid;
        frm_Nominas_Empleados_grid frm_nomin_emp_grid;

        FormAsignarPermisosUsuario nusr = new FormAsignarPermisosUsuario();
        FormDeshabilitarUsuario form_desh = new FormDeshabilitarUsuario();
        Form_EditarPrivilegios form_priv = new Form_EditarPrivilegios();
        Form_EditarPerfil form_perf = new Form_EditarPerfil();
        CambioPass form_cambpass = new CambioPass();
        FormAsignacionPerfil form_asig = new FormAsignacionPerfil();
        agregarapp form_app = new agregarapp();
        //Modificar_aplicacion form_app_UD = new Modificar_aplicacion();
        Historial form_hist = new Historial();
        //Form_login form_log = new Form_login();
        Form_infouser form_infouser = new Form_infouser();
        FormEliminarPerfil inofuser = new FormEliminarPerfil();

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
                plan_igss = new Reporte_Planilla_IGSS();
                plan_igss.MdiParent = this;
                plan_igss.FormClosed += new FormClosedEventHandler(plan_igss_FormClosed);
                plan_igss.Show();
            }
        }

        void plan_igss_FormClosed(object sender, EventArgs e)
        {
            plan_igss = null;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Login_Prueba login_out = new Login_Prueba();
            login_out.FormClosed += new FormClosedEventHandler(login_out_FormClosed);
            login_out.Show();

            this.Hide();
        }

        void login_out_FormClosed(object sender, EventArgs e)
        {
            this.Close();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (form_infouser == null)
            {
                form_infouser = new Form_infouser();
                form_infouser.MdiParent = this;

                form_infouser.FormClosed += new FormClosedEventHandler(FormAsignacionPerfil_FormClosed);
                form_infouser.Show();
            }
        }

        private void FormAsignacionPerfil_FormClosed(object sender, FormClosedEventArgs e)
        {
            form_infouser = null;
        }

        private void MenuMDI_Load(object sender, EventArgs e)
        {
            nusr = null;
            form_desh = null;
            form_priv = null;
            form_perf = null;
            form_cambpass = null;
            form_asig = null;
            form_app = null;
            inofuser = null;
            //form_app_UD = null;
            form_hist = null;
            form_infouser = null;
        }

        private void cambioDeContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (form_cambpass == null)
            {
                form_cambpass = new CambioPass();
                form_cambpass.MdiParent = this;

                form_cambpass.FormClosed += new FormClosedEventHandler(CambiarPass_FormClosed);
                form_cambpass.StartPosition = FormStartPosition.CenterParent;
                form_cambpass.Show();
            }
        }

        public void CambiarPass_FormClosed(object sender, FormClosedEventArgs e)
        {
            form_cambpass = null;
        }

        private void bitacoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (form_hist == null)
            {
                form_hist = new Historial();
                form_hist.MdiParent = this;

                form_hist.FormClosed += new FormClosedEventHandler(Historial_FormClosed);
                form_hist.Show();
            }
        }

        public void Historial_FormClosed(object sender, FormClosedEventArgs e)
        {
            form_hist = null;
        }

        private void bitacoraToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (form_hist == null)
            {
                form_hist = new Historial();
                form_hist.MdiParent = this;

                form_hist.FormClosed += new FormClosedEventHandler(Historial_FormClosed);
                form_hist.Show();
            }
        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (form_asig == null)
            {
                form_asig = new FormAsignacionPerfil();
                form_asig.MdiParent = this;

                form_asig.FormClosed += new FormClosedEventHandler(FormAsignacionPerfil_FormClosed);
                form_asig.Show();
            }
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (form_perf == null)
            {
                form_perf = new Form_EditarPerfil();
                form_perf.MdiParent = this;

                form_perf.FormClosed += new FormClosedEventHandler(Form_EditarPerfil_FormClosed);
                form_perf.Show();
            }
        }

        public void Form_EditarPerfil_FormClosed(object sender, FormClosedEventArgs e)
        {
            form_perf = null;
        }

        private void deshabilitarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (inofuser == null)
            {
                inofuser = new FormEliminarPerfil();
                inofuser.MdiParent = this;

                inofuser.FormClosed += new FormClosedEventHandler(FormEliminarPerfil_FormClosed);
                inofuser.Show();
            }
        }

        private void FormEliminarPerfil_FormClosed(object sender, FormClosedEventArgs e)
        {
            inofuser = null;
        }

        private void crearToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (nusr == null)
            {
                nusr = new FormAsignarPermisosUsuario();
                nusr.MdiParent = this;

                nusr.FormClosed += new FormClosedEventHandler(FormAsignarPermisosUsuario_FormClosed);
                nusr.Show();
            }
        }

        public void FormAsignarPermisosUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            nusr = null;
        }

        private void modificarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (form_priv == null)
            {
                form_priv = new Form_EditarPrivilegios();
                form_priv.MdiParent = this;

                form_priv.FormClosed += new FormClosedEventHandler(Form_EditarPrivilegios_FormClosed);
                form_priv.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
                form_priv.Show();
            }
        }

        public void Form_EditarPrivilegios_FormClosed(object sender, FormClosedEventArgs e)
        {
            form_priv = null;
        }

        private void deshabilitarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (form_desh == null)
            {
                form_desh = new FormDeshabilitarUsuario();
                form_desh.MdiParent = this;

                form_desh.FormClosed += new FormClosedEventHandler(FormDeshabilitarUsuario_FormClosed);
                form_desh.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
                form_desh.Show();
            }
        }

        public void FormDeshabilitarUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            form_desh = null;
        }

        private void aplicacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (form_app == null)
            {
                form_app = new agregarapp();
                form_app.MdiParent = this;

                form_app.FormClosed += new FormClosedEventHandler(agregarapp_FormClosed);
                form_app.Show();
            }
        }

        public void agregarapp_FormClosed(object sender, FormClosedEventArgs e)
        {
            form_app = null;
        }

        private void porMarcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (comi_marca == null)
            {
                comi_marca = new Comision_marca();
                comi_marca.MdiParent = this;
                comi_marca.FormClosed += new FormClosedEventHandler(porMarca_FormClosed);
                comi_marca.Show();
            }
        }

        void porMarca_FormClosed(object sender, EventArgs e)
        {
            comi_marca = null;
        }

        private void porVendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (comi_ve == null)
            {
                comi_ve = new Comisiones_Vendedor();
                comi_ve.MdiParent = this;
                comi_ve.FormClosed += new FormClosedEventHandler(porVendedor_FormClosed);
                comi_ve.Show();
            }
        }
        void porVendedor_FormClosed(object sender, EventArgs e)
        {
            comi_ve = null;
        }

        private void porLineaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (comi_linea == null)
            {
                comi_linea= new Comisiones_linea();
                comi_linea.MdiParent = this;
                comi_linea.FormClosed += new FormClosedEventHandler(porlinea_FormClosed);
                comi_linea.Show();
            }
        }
        void porlinea_FormClosed(object sender, EventArgs e)
        {
            comi_linea = null;
        }

        private void porProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (comi_prod == null)
            {
                comi_prod = new comisiones_producto();
                comi_prod.MdiParent = this;
                comi_prod.FormClosed += new FormClosedEventHandler(porProducto_FormClosed);
                comi_prod.Show();
            }
        }
        void porProducto_FormClosed(object sender, EventArgs e)
        {
            comi_prod = null;
        }
    }
}
