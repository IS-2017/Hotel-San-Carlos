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
    public partial class frmDataImpuesto : Form
    {
        public frmDataImpuesto()
        {
            InitializeComponent();


            OdbcConnection conexion = seguridad.Conexion.ObtenerConexionODBC();
            OdbcDataAdapter dausuario = new OdbcDataAdapter("SELECT * FROM impuesto", conexion);
            DataSet dsuario = new DataSet();
            dausuario.Fill(dsuario, "impuesto");
             dgv_impuesto.DataSource = dsuario;
            dgv_impuesto.DataMember = "impuesto";
        }

      public   clsimpuesto ImpSelec { get; set; }
        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            //frmImpuesto tem = new frmImpuesto();
            //tem.ShowDialog();

            if (dgv_impuesto.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt16(dgv_impuesto.CurrentRow.Cells[0].Value);
                ImpSelec = clsOpImpuesto.Obtenerimp(id);
                cuentas_corrientes.frmImpuesto impe = new cuentas_corrientes.frmImpuesto(ImpSelec);
                impe.ShowDialog();
             
            }
            else
            {
                frmImpuesto tem = new frmImpuesto(ImpSelec);
               tem.ShowDialog();
            }

        }

        private void dgv_impuesto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            dllconsultas.operaciones op = new dllconsultas.operaciones();
            op.ejecutar(dgv_impuesto, "impupesto");
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            OdbcConnection conexion = seguridad.Conexion.ObtenerConexionODBC();
            OdbcDataAdapter dausuario = new OdbcDataAdapter("SELECT * FROM impuesto", conexion);
            DataSet dsuario = new DataSet();
            dausuario.Fill(dsuario, "impuesto");
            dgv_impuesto.DataSource = dsuario;
            dgv_impuesto.DataMember = "impuesto";
        }
    }
}
