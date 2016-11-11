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
    public partial class frmDataParmFact : Form
    {
        public frmDataParmFact()
        {
            InitializeComponent();

            OdbcConnection conexion = seguridad.Conexion.ObtenerConexionODBC();
            OdbcDataAdapter dausuario = new OdbcDataAdapter("SELECT id_parametros_pk, empresa, id_impuesto FROM parametros_fac where estado='activo'", conexion);
            DataSet dsuario = new DataSet();
            dausuario.Fill(dsuario, "parametros_fac");
            dgv_paramfact.DataSource = dsuario;
            dgv_paramfact.DataMember = "parametros_fac";
        }

        public clsParamFact facSelec { get; set; }
        private void btn_nuevo_Click(object sender, EventArgs e)
        {
           
                frmParametrosFact tem = new frmParametrosFact(facSelec);
                tem.ShowDialog();
            
        }

        private void dgv_paramfact_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            dllconsultas.operaciones op = new dllconsultas.operaciones();
            op.ejecutar(dgv_paramfact, "parametros_fac");
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            OdbcConnection conexion = seguridad.Conexion.ObtenerConexionODBC();
            OdbcDataAdapter dausuario = new OdbcDataAdapter("SELECT id_parametros_pk, empresa, id_impuesto FROM parametros_fac where estado='activo'", conexion);
            DataSet dsuario = new DataSet();
            dausuario.Fill(dsuario, "parametros_fac");
            dgv_paramfact.DataSource = dsuario;
            dgv_paramfact.DataMember = "parametros_fac";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dgv_paramfact_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_paramfact.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt16(dgv_paramfact.CurrentRow.Cells[0].Value);
                facSelec = clsOpParmFact.ObtenerParmFact(id);
                cuentas_corrientes.frmParametrosFact impe = new cuentas_corrientes.frmParametrosFact(facSelec);
               // MessageBox.Show(Convert.ToString(facSelec.icodmep));
                impe.ShowDialog();
                
            }
            else
            {
                frmParametrosFact tem = new frmParametrosFact(facSelec);
                tem.ShowDialog();
            }
        }
    }
}
