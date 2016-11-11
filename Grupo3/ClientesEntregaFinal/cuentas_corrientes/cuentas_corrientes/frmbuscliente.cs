using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using MySql.Data.MySqlClient;
using System.Data.Odbc;
using seguridad;

namespace cuentas_corrientes
{
    public partial class frmbuscliente : Form
    {
        public frmbuscliente()
        {
            InitializeComponent();
        }

        private void btn_buscimp_Click(object sender, EventArgs e)
        {
            try
            {
                dgv_clte.DataSource = clsOcliente.Buscar(txt_clte.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
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

        private void frmBuscImpuesto_Load(object sender, EventArgs e)
        {
            mostrar();
        }

        public cls_cliente descl { get; set; }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_clte.SelectedRows.Count == 1)
                {
                    int id = Convert.ToInt16(dgv_clte.CurrentRow.Cells[0].Value);
                    descl = clsOcliente.Obtenerclte(id);
                   // MessageBox.Show(Convert.ToString(descl.dias_cre));

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
    }
}
