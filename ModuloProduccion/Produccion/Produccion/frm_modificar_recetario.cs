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
    public partial class frm_modificar_recetario : Form
    {
        public frm_modificar_recetario()
        {
            InitializeComponent();
        }
        String opcioncategoria = "";
        private void frm_modificar_recetario_Load(object sender, EventArgs e)
        {
            // Carga de combobox Clasificacion
            CapaDatos cdcat = new CapaDatos();
            DataTable dtcat = cdcat.CargarDatosBienClasificacion();



            cmb_categoria.DataSource = dtcat;
            cmb_categoria.DisplayMember = "clasificacion";
            cmb_categoria.ValueMember = "clasificacion";


            // Carga de combobox procesos

            CapaDatos cd = new CapaDatos();
            DataTable recolector = cd.CargaDatosProceso();

            cmb_proceso.DataSource = recolector;
            cmb_proceso.DisplayMember = "nombre_proceso";
            cmb_proceso.ValueMember = "id_proceso_pk";


            //Cargar combobox de medida

            CapaDatos cdmedida = new CapaDatos();
            DataTable medida = cdmedida.CargarDatosMedida();

            cmb_medida.DataSource = medida;
            cmb_medida.DisplayMember = "nombre_medida";
            cmb_medida.ValueMember = "id_medida_pk";

        }


        // Boton para consultar el detalle de formula segun encabezado
        private void btn_consultar_Click(object sender, EventArgs e)
        {
            CapaDatos cd = new CapaDatos();
            DataTable dt = cd.ConsultarRecetaDetalle(lbl_id_receta_enc.Text.ToString());

            dgv_modifica_receta.DataSource = dt;
        }

        // Nombre de receta en etiqueta de descripcion
        private void txt_nombre_receta_TextChanged(object sender, EventArgs e)
        {
            lbl_nombre_formula.Text = txt_nombre_receta.Text.Trim();
        }

        private void cmb_categoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            // carga de materia prima segun categoria
            CapaDatos cd = new CapaDatos();
            opcioncategoria = cmb_categoria.SelectedValue.ToString();

            DataTable dt = cd.CargaDatosBien(opcioncategoria);

            cmb_materia_prima.DataSource = dt;
            cmb_materia_prima.DisplayMember = "descripcion";
            cmb_materia_prima.ValueMember = "id_bien_pk";
        }
    }
}
