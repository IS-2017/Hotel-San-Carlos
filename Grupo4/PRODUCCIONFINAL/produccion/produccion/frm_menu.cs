using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
namespace produccion
{
    public partial class frm_menu : Form
    {
        public frm_menu()
        {
            InitializeComponent();
        }

        private void frm_menu_Load(object sender, EventArgs e)
        {

        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                OdbcConnection con = seguridad.Conexion.ObtenerConexionODBC();
                OdbcCommand cmd = new OdbcCommand("Select concat(m.id_menu_pk,'-',m.correlativo)as ID, concat(m.nombre,'-',t.tamanio) as Producto, m.descripcion,p.precio from menu m, tamanio_porcion t, precio p where m.id_precio=p.id_precio AND p.id_tamaniop_pk=t.id_tamaniop_pk ", con);
                DataTable dt = new DataTable();
                OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                da.Fill(dt);
                con.Close();
                dgv_menu.DataSource = dt;
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Problema con Menú", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
