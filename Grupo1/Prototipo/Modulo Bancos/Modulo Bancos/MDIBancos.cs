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

namespace Modulo_Bancos
{
    public partial class MDIBancos : Form
    {
        private int childFormNumber = 0;
        Documento doc;
        Cheque_Voucher che_Vo;
        Buscar_Cheque che;
        Conciliacion_Bancaria con_ban;
        Disponibilidad_bancaria disp_ban;
        Tipo_Documento tip_doc;
        Busqueda_Documento busq_doc;
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
            if (che == null)
            {
                che = new Buscar_Cheque();
                che.MdiParent = this;
                che.FormClosed += new FormClosedEventHandler(cheque_voucher_FormClosed);
                che.Show();
            }
        }
        void cheque_voucher_FormClosed(object sender, EventArgs e)
        {
            che = null;
        }

        private void MDIBancos_Load(object sender, EventArgs e)
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
            // form_log = null;
            MdiClient Chld;
            foreach (Control crtl in this.Controls)
            {
                try
                {
                    Chld = (MdiClient)crtl;
                    Chld.BackColor = this.BackColor;
                }
                catch (InvalidCastException exe)
                { }
            }
            //-------------------------------------------------------

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

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_login login = new Form_login();
            login.FormClosed += new FormClosedEventHandler(login_FormClosed);
            login.Show();
            this.Hide();
        }

        void login_FormClosed(Object sender, EventArgs e)
        {
            this.Close();
        }

        private void bitacoraToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (form_hist == null)
            {
                form_hist = new Historial();
                form_hist.MdiParent = this;

                form_hist.FormClosed += new FormClosedEventHandler(Historial_FormClosed);
                form_hist.Show();
            }
        }

        void Historial_FormClosed(object sender, EventArgs e)
        {
            form_hist = null;
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (form_infouser == null)
            {
                form_infouser = new Form_infouser();
                form_infouser.MdiParent = this;

                form_infouser.FormClosed += new FormClosedEventHandler(FormInfoUser_FormClosed);
                form_infouser.Show();
            }
        }

        public void FormInfoUser_FormClosed(object sender, FormClosedEventArgs e)
        {
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

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
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

        public void FormAsignacionPerfil_FormClosed(object sender, FormClosedEventArgs e)
        {
            form_asig = null;
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

        public void FormEliminarPerfil_FormClosed(object sender, FormClosedEventArgs e)
        {
            inofuser = null;
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
    }
}
