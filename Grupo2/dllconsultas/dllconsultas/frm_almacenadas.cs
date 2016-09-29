using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

//ana lilian: almacen de consultas
namespace dllconsultas
{
    public partial class frm_almacenadas : Form
    {
        string tabla;
        DataGridView dg;
        metodos ejecutar = new metodos();
        public frm_almacenadas(string tabla, DataGridView dg)
        {
            this.tabla = tabla;
            this.dg = dg;
            InitializeComponent();
        }

        private void frm_almacenadas_Load(object sender, EventArgs e)
        {
            String guardad = "select * from consultaguardada where idform = 1 and tabla='" + tabla + "';";
            ejecutar.actualizargrid(guardad, dgv_Almacenadas);
            nombrecolumna();
        }
        public void nombrecolumna()
        {
            try
            {
                //    creador:rodrigo
                this.dgv_Almacenadas.Columns[1].Visible = false;
                this.dgv_Almacenadas.Columns[0].HeaderText = "No";
                this.dgv_Almacenadas.Columns[2].HeaderText = "Nombre";
                this.dgv_Almacenadas.Columns[3].HeaderText = "Consulta";
                this.dgv_Almacenadas.Columns[3].HeaderText = "Tabla";
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex);
            }

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            String Squerys = ("Select * from consultaguardada where nombre like'" + txt_buscar.Text + "%'or descripcion like'" + txt_buscar.Text + "%';");
            ejecutar.buscarquery(Squerys);
            ejecutar.actualizargrid(Squerys, dgv_Almacenadas);
            nombrecolumna();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string queryss = this.dgv_Almacenadas.CurrentRow.Cells[0].Value.ToString();
                ejecutar.extraeryejecutar(queryss, dg);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex);
            }

        }
    }
}
