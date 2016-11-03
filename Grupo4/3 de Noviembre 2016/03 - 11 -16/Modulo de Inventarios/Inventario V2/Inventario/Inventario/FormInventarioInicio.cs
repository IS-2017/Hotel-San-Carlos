using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FuncionesNavegador;
using dllconsultas;

namespace Inventario
{
    public partial class FormInventarioInicio : Form
    {
        public FormInventarioInicio()
        {
            InitializeComponent();
        }


        private void FormInventarioInicio_Load(object sender, EventArgs e)
        {
            SistemaInventarioDatos sd = new SistemaInventarioDatos();
            dgw_bienes.DataSource = sd.MostrarInventario();
            dgw_bienes.Columns[0].HeaderText = "Codigo";
            dgw_bienes.Columns[1].HeaderText = "Descripción";
            dgw_bienes.Columns[2].HeaderText = "Categoría";
            dgw_bienes.Columns[3].HeaderText = "Existencias";
            dgw_bienes.Columns[4].HeaderText = "Precio";
            dgw_bienes.Columns[5].HeaderText = "Costo";
            dgw_bienes.Columns[6].HeaderText = "Medida";
            dgw_bienes.Columns[7].HeaderText = "Línea";
            dgw_bienes.Columns[8].HeaderText = "Marca";

            dgw_bienes.Columns[0].Width = 67;
            dgw_bienes.Columns[1].Width = 282;
            dgw_bienes.Columns[2].Width = 78;
            dgw_bienes.Columns[3].Width = 62;
            dgw_bienes.Columns[4].Width = 50;
            dgw_bienes.Columns[5].Width = 50;
            dgw_bienes.Columns[6].Width = 69;
            dgw_bienes.Columns[7].Width = 88;
            dgw_bienes.Columns[8].Width = 89;


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FormNuevoProducto np = new FormNuevoProducto();
            np.Show();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            FormNuevoProducto f = new FormNuevoProducto();
            f.MdiParent = this.MdiParent;
            f.Show();
        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            SistemaInventarioDatos sd = new SistemaInventarioDatos();
            string busqueda = txt_buscar.Text.Trim();
            dgw_bienes.DataSource = sd.VistaProdLike(busqueda);
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            CapaNegocio fn = new CapaNegocio();
            fn.Anterior(dgw_bienes);
           
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            CapaNegocio fn = new CapaNegocio();
            fn.Siguiente(dgw_bienes);
        }

        private void btn_primero_Click(object sender, EventArgs e)
        {
            CapaNegocio fn = new CapaNegocio();
            fn.Primero(dgw_bienes);
        }

        private void btn_ultimo_Click(object sender, EventArgs e)
        {
            CapaNegocio fn = new CapaNegocio();
            fn.Ultimo(dgw_bienes);
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            SistemaInventarioDatos sd = new SistemaInventarioDatos();
            dgw_bienes.DataSource = sd.MostrarInventario();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string tabla = "bien";
            operaciones op = new operaciones();
            op.ejecutar(dgw_bienes, tabla);
        }
    }
}
