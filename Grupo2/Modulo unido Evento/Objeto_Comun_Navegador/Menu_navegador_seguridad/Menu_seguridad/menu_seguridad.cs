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

namespace Menu_seguridad
{
    public partial class menu_seguridad : Form
    {
        private int childFormNumber = 0;
        FormAsignarPermisosUsuario nusr = new FormAsignarPermisosUsuario();
        FormDeshabilitarUsuario form_desh = new FormDeshabilitarUsuario();
        Form_EditarPrivilegios form_priv = new Form_EditarPrivilegios();
        Form_EditarPerfil form_perf = new Form_EditarPerfil();
        CambioPass form_cambpass = new CambioPass();
        FormAsignacionPerfil form_asig = new FormAsignacionPerfil();
       // agregarapp form_app = new agregarapp();
        Modificar_aplicacion form_app_UD = new Modificar_aplicacion();
        Historial form_hist = new Historial();
        //Form_login form_log = new Form_login();

        public menu_seguridad()
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

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
           if(nusr==null)
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

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (form_desh == null)
            {
                form_desh = new FormDeshabilitarUsuario();
                form_desh.MdiParent = this;

                form_desh.FormClosed += new FormClosedEventHandler(FormDeshabilitarUsuario_FormClosed);
                form_desh.Show();
            }
        }
        public void FormDeshabilitarUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            form_desh = null;
        }

        private void menu_seguridad_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(seguridad.LlegarSeguridad.ObtenerUsuario());
            nusr = null;
            form_desh = null;
            form_priv = null;
            form_perf = null;
            form_cambpass = null;
            form_asig = null;
            //form_app = null;
            form_app_UD = null;
            form_hist = null;
           // form_log = null;
        }

        private void permisosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (form_priv == null)
            {
                form_priv = new Form_EditarPrivilegios();
                form_priv.MdiParent = this;

                form_priv.FormClosed += new FormClosedEventHandler(Form_EditarPrivilegios_FormClosed);
                form_priv.Show();
            }
        }
        public void Form_EditarPrivilegios_FormClosed(object sender, FormClosedEventArgs e)
        {
            form_priv = null;
        }

        private void perfilesToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void cambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (form_cambpass == null)
            {
                form_cambpass = new CambioPass();
                form_cambpass.MdiParent = this;

                form_cambpass.FormClosed += new FormClosedEventHandler(CambiarPass_FormClosed);
                form_cambpass.Show();
            }
        }
        public void CambiarPass_FormClosed(object sender, FormClosedEventArgs e)
        {
            form_cambpass = null;
        }

        private void crearToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (form_asig == null)
            {
               form_asig  = new FormAsignacionPerfil();
                form_asig.MdiParent = this;

                form_asig.FormClosed += new FormClosedEventHandler(Form_AsignacionPerfil_FormClosed);
                form_asig.Show();
            }
        }
        public void Form_AsignacionPerfil_FormClosed(object sender, FormClosedEventArgs e)
        {
            form_asig = null;
        }

        private void editarToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void perfilToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void crearToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //if (form_app == null)
            //{
            //    form_app = new agregarapp();
            //    form_app.MdiParent = this;

            //    form_app.FormClosed += new FormClosedEventHandler(agregarapp_FormClosed);
            //    form_app.Show();
            //}
        }
        public void agregarapp_FormClosed(object sender, FormClosedEventArgs e)
        {
            //form_app = null;
        }

        private void eliminarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (form_app_UD == null)
            {
                 form_app_UD= new Modificar_aplicacion();
                form_app_UD.MdiParent = this;

                form_app_UD.FormClosed += new FormClosedEventHandler(Modificar_aplicacion_FormClosed);
                form_app_UD.Show();
            }
             
        }
        public void Modificar_aplicacion_FormClosed(object sender, FormClosedEventArgs e)
        {
            form_app_UD = null;
        }

        private void visualizarToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (form_log == null)
            //{
            //    form_log = new Form_login();
            //    form_log.MdiParent = this;

            //    form_log.FormClosed += new FormClosedEventHandler(form_login_FormClosed);
            //    form_log.Show();
            //}
        }
        public void form_login_FormClosed(object sender, FormClosedEventArgs e)
        {
           // form_log = null;
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_login f = new Form_login();
                f.Show();
            this.Hide();

        }

        private void navegadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Componente f = new Componente();
            f.Show();
        }

        //private void pruebaNavegadorToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    pruebanav p = new pruebanav();
        //    p.Show();
        //}
    }
    }
    
    

/*
 if (form_ == null)
            {
                 = new();
               .MdiParent = this;

                .FormClosed += new FormClosedEventHandler(_FormClosed);
                form_.Show();
            }
        }
        public void _FormClosed(object sender, FormClosedEventArgs e)
        {
            form_ = null;
        }
     */
