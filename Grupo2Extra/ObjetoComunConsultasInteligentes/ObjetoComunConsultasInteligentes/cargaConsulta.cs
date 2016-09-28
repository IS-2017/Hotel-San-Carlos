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

namespace ObjetoComunConsultasInteligentes
{
    public partial class cargaConsulta : Form
    {
        public cargaConsulta()
        {
            InitializeComponent();
            actualizargrid(dgv_consultasAlmacenadas, Squerys, tabla);
        }
        MySqlConnection conexion = new MySqlConnection("server=localhost; database=bdcinetopia; Uid=root; pwd=;");
        string tabla = "consultaguardada";
        string Squerys = "SELECT a.idcon ,a.nombre FROM consultaguardada a";

        public void actualizargrid(DataGridView dg, String SQuery, String Stabla)
        {
            
            DataSet midataset = new DataSet();
            MySqlDataAdapter miadapter = new MySqlDataAdapter(SQuery, conexion);
            miadapter.Fill(midataset, Stabla);
            dg.DataSource = midataset;
            dg.DataMember = Stabla;
            

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            
            String Squerys = ("SELECT a.idcon ,a.nombre FROM consultaguardada a where a.nombre like '%" + txt_buscar.Text + "%';");
            MySqlCommand Micomando = new MySqlCommand(Squerys, conexion);
            int FilasAfectadas = Micomando.ExecuteNonQuery();
            if (FilasAfectadas > 0)
                MessageBox.Show("No se encontro el Registro", "Error del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("Busqueda Realizada", "Musqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            actualizargrid(dgv_consultasAlmacenadas, Squerys, tabla);
            conexion.Close();
        }

        string Querry;
        
        private void btn_extraer_Click(object sender, EventArgs e)
        {
            conexion.Open();
            Querry = this.dgv_consultasAlmacenadas.CurrentRow.Cells[0].Value.ToString();
            DataTable dt = new DataTable();
            String sQuery = "SELECT descripcion FROM consultaguardada WHERE idcon= '" + Querry + "'";
            MySqlCommand comando = new MySqlCommand(sQuery, conexion);
            MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
            adaptador.Fill(dt);
            DataRow fila = dt.Rows[0];
            string sid = Convert.ToString(fila[0]);
            MessageBox.Show(sid);
            conexion.Close();
        }

        private void cargaConsulta_Load(object sender, EventArgs e)
        {

        }

        private void btn_limpiartexto_Click(object sender, EventArgs e)
        {
            txt_buscar.Clear();
        }
    }
}
