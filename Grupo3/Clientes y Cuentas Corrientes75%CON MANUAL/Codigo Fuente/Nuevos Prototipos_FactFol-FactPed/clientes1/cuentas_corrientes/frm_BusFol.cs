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
    public partial class frm_BusFol : Form
    {
        public frm_BusFol()
        {
            InitializeComponent();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {


            OdbcConnection conectar3 = seguridad.Conexion.ObtenerConexionODBC();
            clsComun cte= new clsComun();
            OdbcCommand _comando = new OdbcCommand(String.Format(
                 "SELECT id_cliente_pk FROM cliente where nombre ='{0}'  ", txt_nombre.Text), conectar3);
            OdbcDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {

                cte.cod = _reader.GetInt16(0);
            }

            dgv_fol.DataSource = ClsOpFolio.Buscarfoio(cte.cod);
            dgv_fol.Columns.Remove("codcte");
            dgv_fol.Columns.Remove("fec_pago");
        }

       public clsFolio FolSelec { get; set; }
        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_fol.SelectedRows.Count == 1)
                {
                    int id = Convert.ToInt16(dgv_fol.CurrentRow.Cells[0].Value);
                    FolSelec = ClsOpFolio.ObtenerFolio(id);
                    //MessageBox.Show(FolSelec.estado);

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
