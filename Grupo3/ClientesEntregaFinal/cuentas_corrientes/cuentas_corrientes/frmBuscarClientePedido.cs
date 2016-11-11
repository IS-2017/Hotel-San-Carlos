using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cuentas_corrientes
{
    public partial class frmBuscarClientePedido : Form
    {
        public frmBuscarClientePedido()
        {
            InitializeComponent();
        }
        public void mostrar()
        {
            OdbcConnection conexion = seguridad.Conexion.ObtenerConexionODBC();
            OdbcDataAdapter dausuario = new OdbcDataAdapter("SELECT * FROM cliente", conexion);
            DataSet dsuario = new DataSet();
            dausuario.Fill(dsuario, "cliente");
            dgv_clte.DataSource = dsuario;
            dgv_clte.DataMember = "cliente";
        }
        public cls_cliente descl { get; set; }
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                if (dgv_clte.SelectedRows.Count == 1)
                {
                    int id = Convert.ToInt32(dgv_clte.CurrentRow.Cells[0].Value);
                    descl = clsOclientePedido.Obtenerclte(id);

                    this.Close();
                }
                else
                    MessageBox.Show("Debe de seleccionar una fila");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmBuscarClientePedido_Load(object sender, EventArgs e)
        {
            mostrar();
        }

        private void btn_buscimp_Click(object sender, EventArgs e)
        {
            try
            {
                dgv_clte.DataSource = clsOclientePedido.Buscar(txt_clte.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
