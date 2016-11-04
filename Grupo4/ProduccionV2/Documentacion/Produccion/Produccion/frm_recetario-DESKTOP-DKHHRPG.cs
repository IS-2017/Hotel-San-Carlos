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
    public partial class frm_recetario : Form
    {
        public frm_recetario()
        {
            InitializeComponent();
        }

        private void frm_recetario_Load(object sender, EventArgs e)
        {
            // cargar datagridview con recetas
            CapaDatos cd = new CapaDatos();
            DataTable dt = cd.ConsultarReceta();
           

            dgv_recetario.DataSource= dt;

            dgv_recetario.Columns["id_receta_pk"].Visible = false;
            dgv_recetario.Columns["horas_hombre"].Visible = false;
            dgv_recetario.Columns["costo_receta"].Visible = false;
            dgv_recetario.Columns["nombre_receta"].HeaderText = "Receta";



        }

        // enviar los datos del datagridview hacia formulario de cambiar receta
        private void dgv_recetario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            frm_modificar_recetario frm_modificar_recetario = new frm_modificar_recetario();
           frm_modificar_recetario.StartPosition = FormStartPosition.CenterParent;

            {
                foreach (Form form in Application.OpenForms)
            {
                    if (form.Name == "frm_modificar_recetario")
                    {
                        frm_modificar_recetario = (frm_modificar_recetario)form;
                        frm_modificar_recetario.txt_nombre_receta.Text = dgv_recetario.CurrentRow.Cells["nombre_receta"].Value.ToString();
                        frm_modificar_recetario.lbl_id_receta_enc.Text = dgv_recetario.CurrentRow.Cells["id_receta_pk"].Value.ToString();
                        frm_modificar_recetario.lbl_hrs_hombre.Text = dgv_recetario.CurrentRow.Cells["horas_hombre"].Value.ToString();
                        frm_modificar_recetario.lbl_costo.Text = dgv_recetario.CurrentRow.Cells["costo_receta"].Value.ToString();
                        break;

                    }

            }
            }
                        
            frm_modificar_recetario.Show();
        }
    }
}
