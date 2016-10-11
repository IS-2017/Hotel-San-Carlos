using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dllconsultasgeneraless
{
    public partial class frm_extraer : Form
    {
        DataGridView dg;
        metodos rs = new metodos();
       string tabla = "consultaguardada";
        string Squerys = "select * from consultaguardada;";
        public frm_extraer(DataGridView dg)
        {
            this.dg = dg;
            InitializeComponent();
            rs.actualizargrid(Squerys, dgv_consultasAlmacenadas);
        }

        private void frm_extraer_Load(object sender, EventArgs e)
        {

        }

        private void dgv_consultasAlmacenadas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void nombrecolumna()
        {
            this.dgv_consultasAlmacenadas.Columns[1].Visible = false;
            this.dgv_consultasAlmacenadas.Columns[0].HeaderText = "No";
            this.dgv_consultasAlmacenadas.Columns[2].HeaderText = "Nombre";
            this.dgv_consultasAlmacenadas.Columns[3].HeaderText = "Consulta";
            this.dgv_consultasAlmacenadas.Columns[4].HeaderText = "Tabla";
        }
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            String Squerys = ("Select * from consultaguardada where nombre like'" + txt_buscar.Text + "%'or descripcion like'" + txt_buscar.Text + "%'or tabla like'" + txt_buscar.Text + "%';");
            rs.buscarquery(Squerys);
           rs.actualizargrid(Squerys, dgv_consultasAlmacenadas);
            nombrecolumna();
        }

        private void btn_extraer_Click(object sender, EventArgs e)
        {
            try
            {
                string queryss = this.dgv_consultasAlmacenadas.CurrentRow.Cells[0].Value.ToString();
               rs.extraeryejecutar(queryss, dg);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex);
            }
        }

        private void btn_limpiartexto_Click(object sender, EventArgs e)
        {

        }

        private void btn_Regresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_buscar.Text = "";
        }
    }
}
