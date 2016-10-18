using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaUsuarios
{
    public partial class FormAsignaPermisoUsuario : Form
    {
        public FormAsignaPermisoUsuario()
        {
            InitializeComponent();
        }

        DataTable dt = new DataTable();
        DataTable dg = new DataTable();

        DataTable dt_p = new DataTable();
        DataTable dg_p = new DataTable();
        int cont_e = 0;
      

        private void FormAsignaPermisoUsuario_Load(object sender, EventArgs e)
        {
            Conexion.Conexion.DSN = "prueba2";
            Conexion.Conexion.DataBase = "sancarlos2";
            Conexion.Conexion.Role = "root";
            Conexion.Conexion.PassWord = "1234";

            SistemaUsuarioDatos ss = new SistemaUsuarioDatos();
            DataTable dtz = ss.ObtenerPerfiles();
            cbo_roles.DataSource = dtz;
            cbo_roles.DisplayMember = "nombre_perfil";
            cbo_roles.ValueMember = "id_perfil";
            cbo_roles.SelectedIndex = -1;

          
            DataTable dt2  = ss.ObtenerAplicaciones();
            
             ((ListBox)chlb_aplicaciones).DataSource = dt2;
            ((ListBox)chlb_aplicaciones).ValueMember = "id_aplicacion";
            ((ListBox)chlb_aplicaciones).DisplayMember = "nombre_aplicacion";

          //  chlb_aplicaciones.CheckOnClick = true;
           // chlb_permisos.CheckOnClick = true;
            //---------------------------------------------------------
            DataColumn columna;
            //primera columna
            columna = new DataColumn();
            columna.DataType = System.Type.GetType("System.Int32");
            columna.ColumnName = "Aplicación";
            dt.Columns.Add(columna);

            //2 columna
            columna = new DataColumn();
            columna.DataType = System.Type.GetType("System.Boolean");
            columna.ColumnName = "Insertar";
            dt.Columns.Add(columna);
            //3 columna
            columna = new DataColumn();
            columna.DataType = System.Type.GetType("System.Boolean");
            columna.ColumnName = "Seleccionar";
            dt.Columns.Add(columna);
            //4 columna
            columna = new DataColumn();
            columna.DataType = System.Type.GetType("System.Boolean");
            columna.ColumnName = "Modificar";
            dt.Columns.Add(columna);
            //5 columna
            columna = new DataColumn();
            columna.DataType = System.Type.GetType("System.Boolean");
            columna.ColumnName = "Eliminar";
            dt.Columns.Add(columna);
            //------------------------------------------------------
            //primera columna
            columna = new DataColumn();
            columna.DataType = System.Type.GetType("System.String");
            columna.ColumnName = "Aplicación";
            dg.Columns.Add(columna);

            //2 columna
            columna = new DataColumn();
            columna.DataType = System.Type.GetType("System.String");
            columna.ColumnName = "Insertar";
            dg.Columns.Add(columna);
            //3 columna
            columna = new DataColumn();
            columna.DataType = System.Type.GetType("System.String");
            columna.ColumnName = "Seleccionar";
            dg.Columns.Add(columna);
            //4 columna
            columna = new DataColumn();
            columna.DataType = System.Type.GetType("System.String");
            columna.ColumnName = "Modificar";
            dg.Columns.Add(columna);
            //5 columna
            columna = new DataColumn();
            columna.DataType = System.Type.GetType("System.String");
            columna.ColumnName = "Eliminar";
            dg.Columns.Add(columna);
            //------------------------------------------------------
            //primera columna
            columna = new DataColumn();
            columna.DataType = System.Type.GetType("System.String");
            columna.ColumnName = "Aplicación";
            dg_p.Columns.Add(columna);

            //2 columna
            columna = new DataColumn();
            columna.DataType = System.Type.GetType("System.String");
            columna.ColumnName = "Insertar";
            dg_p.Columns.Add(columna);
            //3 columna
            columna = new DataColumn();
            columna.DataType = System.Type.GetType("System.String");
            columna.ColumnName = "Seleccionar";
            dg_p.Columns.Add(columna);
            //4 columna
            columna = new DataColumn();
            columna.DataType = System.Type.GetType("System.String");
            columna.ColumnName = "Modificar";
            dg_p.Columns.Add(columna);
            //5 columna
            columna = new DataColumn();
            columna.DataType = System.Type.GetType("System.String");
            columna.ColumnName = "Eliminar";
            dg_p.Columns.Add(columna);

        }

    

        private void cbo_roles_SelectedIndexChanged(object sender, EventArgs e)
        {
            dg_p.Clear();
            if (cbo_roles.SelectedValue is int)
            {
                SistemaUsuarioDatos ss = new SistemaUsuarioDatos();
                DataTable dtm = new DataTable();
                DataRow rowdg;
                dtm = ss.ObtenerPermisosPorPerfilesdg(cbo_roles.SelectedValue.ToString());
                foreach (DataRow row in dtm.Rows)
                {
                    rowdg = dg_p.NewRow();
                    for (int i = 0; i < dtm.Columns.Count; i++)
                    {
                        
                        // MessageBox.Show(row[i].ToString());
                        if (row[i].ToString() == "1")
                        {
                            rowdg[i] = "X";
                        }
                        else if (row[i].ToString() == "0")
                         {
                            rowdg[i] = "";
                        }
                        else
                           {
                            rowdg[i] = row[i].ToString();
                        }
                    }
                    dg_p.Rows.Add(rowdg);
                }
                dgw_perfil.DataSource = dg_p;
                // MessageBox.Show(cbo_roles.SelectedValue.ToString());

            }
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            //for (int i = 0; i < chlb_aplicaciones.Items.Count; i++)
            //{
            //    if (chlb_aplicaciones.GetItemCheckState(i) == CheckState.Checked)
            //    {
            //        //MessageBox.Show(chlb_aplicaciones.GetItemChecked(i).SelectedValue.ToString());
            //        MessageBox.Show(chlb_aplicaciones.CheckedItems[i]);
            //    }
            //}

            //foreach (object ap in chlb_aplicaciones.CheckedItems)
            //{
            //    //MessageBox.Show(((ListBox)chlb_aplicaciones).SelectedValue.ToString());
            //    //MessageBox.Show("valor es:"+ ap.ToString());
            //    MessageBox.Show("valor es:" +);
            //}

            //foreach (DataRowView ap in chlb_aplicaciones.CheckedItems)
            //{
            //    MessageBox.Show(((ListBox)chlb_aplicaciones).SelectedValue.ToString());
            //}

            //foreach (  ap in chlb_aplicaciones.CheckedItems)
            //{
            //    //MessageBox.Show(((ListBox)chlb_aplicaciones).SelectedValue.ToString());
            //    MessageBox.Show(ap.SelectedValue.ToString());
            //}

            //------------------------------------------------------------------------
            //dgw1.Rows.Insert

            ValidarListaApp();

            DataRow row;
            DataRow rowdg;
         
            int cont = 1;
            foreach (int i in chlb_aplicaciones.CheckedIndices)
            {
                chlb_aplicaciones.SelectedIndex = i;
                row = dt.NewRow();
                row[0] = chlb_aplicaciones.SelectedValue.ToString();//

                rowdg = dg.NewRow();
                rowdg[0] = chlb_aplicaciones.Text;//

                for (int t = 0; t < chlb_permisos.Items.Count; t++)
                {
                    if (chlb_permisos.GetItemCheckState(t) == CheckState.Checked)
                     {
                        row[cont] = true;
                        rowdg[cont] = "X";
                        cont++;
                     }
                    else
                      {
                        row[cont] = false;
                        cont++;
                      }
                        if (t == chlb_permisos.Items.Count-1)
                        {
                        dt.Rows.Add(row);
                        dg.Rows.Add(rowdg);
                        cont = 1;
                        }
                }
            }

            dgw_permisos.DataSource = dg;
            dataGridView1.DataSource = dt;

            BloquearCheck();
            BloquearExistentes();

            cont_e++;
            if (cont_e==1)
            {
                AgregarColEliminar();
            }
            //--------------------------------------------------------
            //foreach (int i in chlb_aplicaciones.SelectedIndices)
            //{
            //    DataRowView dr = (DataRowView)chlb_aplicaciones.Items;
            //}
        }


        public void ValidarListaApp()
        {
            string idp;
            foreach(DataRow  row in dt.Rows )
            {
                 idp = row[0].ToString();
                foreach (int i in chlb_aplicaciones.CheckedIndices)
                {
                    chlb_aplicaciones.SelectedIndex = i;
                    if (idp == chlb_aplicaciones.SelectedValue.ToString())
                    {
                        chlb_aplicaciones.SetItemCheckState(i, CheckState.Unchecked);
                    }
                }


            }

        }


        public void BloquearExistentes()
        {
            string idp;
            foreach (DataRow row in dt.Rows)
            {
                idp = row[0].ToString();
                for (int t = 0; t < chlb_aplicaciones.Items.Count; t++)
                {
                    chlb_aplicaciones.SelectedIndex = t;
                    if (idp == chlb_aplicaciones.SelectedValue.ToString())
                    {
                        chlb_aplicaciones.SetItemCheckState(t, CheckState.Indeterminate);
                    }
                }


            }

        }

        public void AgregarColEliminar()
        {
            DataGridViewButtonColumn dg_columna = new DataGridViewButtonColumn();
            //dg_columna  
            dgw_permisos.Columns.Add(dg_columna);
        }


        public void BloquearCheck()
        {
            for (int t = 0; t < chlb_aplicaciones.Items.Count; t++)
            {
                if (chlb_aplicaciones.GetItemCheckState(t) == CheckState.Checked)
                {

                    chlb_aplicaciones.SetItemCheckState(t, CheckState.Indeterminate);
                }
            }

            for (int r = 0; r < chlb_permisos.Items.Count; r++)
            {
                if (chlb_permisos.GetItemCheckState(r) == CheckState.Checked)
                {

                    chlb_permisos.SetItemCheckState(r, CheckState.Unchecked);
                }
            }


        }









      





        private void chlb_aplicaciones_MouseClick(object sender, MouseEventArgs e)
        {
            //int i = chlb_aplicaciones.SelectedIndex;
            //if (chlb_aplicaciones.GetItemCheckState(i) == CheckState.Indeterminate)
            //{

            //    chlb_aplicaciones.SetItemCheckState(i, CheckState.Indeterminate);

            //}
        }

        private void chlb_aplicaciones_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void chlb_aplicaciones_MouseDoubleClick(object sender, MouseEventArgs e)
        {
          
        }

        private void chlb_aplicaciones_ItemCheck(object sender, ItemCheckEventArgs e)
        {
          
        }

        private void chlb_aplicaciones_Click(object sender, EventArgs e)
        {
            
        }

        private void dgw_permisos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgw_permisos.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex !=-1 && e.RowIndex != dt.Rows.Count)
            {
                DataRow row = dt.Rows[dgw_permisos.CurrentRow.Index];
                row.Delete();

                DataRow rowdg = dg.Rows[dgw_permisos.CurrentRow.Index];
                rowdg.Delete();

                // MessageBox.Show(dgw_permisos.CurrentRow.Index.ToString());
                dgw_permisos.DataSource = dg;
                dataGridView1.DataSource = dt;
            }
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            SistemaUsuarioNegocio su = new SistemaUsuarioNegocio();
            SistemaUsuarioDatos ss = new SistemaUsuarioDatos();
            int u = su.ValidarChecklistVacia(dt);

            if (!String.IsNullOrEmpty(txt_usuario.Text.Trim()) && u == 1 && !String.IsNullOrEmpty(txt_contraseña.Text.Trim()) && !String.IsNullOrEmpty(txt_rep_contraseña.Text.Trim()))
            {
              if(txt_contraseña.Text.Trim() == txt_rep_contraseña.Text.Trim())
                {
                    int x= ss.CrearUsuario(txt_usuario.Text.Trim(), txt_contraseña.Text.Trim());
                    if(x==1)
                    {
                        ss.InsertarUsuario(txt_usuario.Text.Trim(), txt_contraseña.Text.Trim(), 0);
                        MessageBox.Show("usuario creado con exito"); }else { MessageBox.Show("error en la creacion del usuario"); }
                }
                else { MessageBox.Show("contraseñas no coinciden"); }

            }
            else { MessageBox.Show("Debe ingresar todos los campos y asignar permisos para el usuario!"); }
        }

        private void btn_aceptar_perfil_Click(object sender, EventArgs e)
        {
            SistemaUsuarioNegocio su = new SistemaUsuarioNegocio();
            SistemaUsuarioDatos ss = new SistemaUsuarioDatos();
            int u = su.ValidarChecklistVacia(dg_p);

            if (!String.IsNullOrEmpty(txt_usuario.Text.Trim()) && u == 1 && !String.IsNullOrEmpty(txt_contraseña.Text.Trim()) && !String.IsNullOrEmpty(txt_rep_contraseña.Text.Trim()))
            {
                if (txt_contraseña.Text.Trim() == txt_rep_contraseña.Text.Trim())
                {
                    int x = ss.CrearUsuario(txt_usuario.Text.Trim(), txt_contraseña.Text.Trim());
                    if (x == 1)
                    {
                        ss.InsertarUsuario(txt_usuario.Text.Trim(), txt_contraseña.Text.Trim(), Convert.ToInt32(cbo_roles.SelectedValue));
                        MessageBox.Show("usuario creado con exito"); }
                    else { MessageBox.Show("error en la creacion del usuario"); }
                }
                else { MessageBox.Show("contraseñas no coinciden"); }

            }
            else { MessageBox.Show("Debe ingresar todos los campos y un perfil para el usuario!"); }
        }
    }
}
