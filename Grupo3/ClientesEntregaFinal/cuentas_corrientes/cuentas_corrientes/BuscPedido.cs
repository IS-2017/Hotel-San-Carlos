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
namespace cuentas_corrientes
    
{
    public partial class BuscPedido : Form
    {
        public BuscPedido()
        {
            InitializeComponent();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            /*MySqlConnection conectar3 = cls_bdcomun.ObtenerConexion();
            clsComun cte = new clsComun();
            MySqlCommand _comando = new MySqlCommand(String.Format(
                 "SELECT id_cliente_pk FROM cliente where nombre ='{0}'  ", txt_nombre.Text), conectar3);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {

                cte.cod = _reader.GetInt16(0);
            }*/

            OdbcConnection conectar = seguridad.Conexion.ObtenerConexionODBC();
            cls_cliente cte = new cls_cliente();
            OdbcCommand _comando = new OdbcCommand(String.Format(
            "SELECT id_cliente_pk FROM cliente where nombre = '{0}'  ", txt_nombre.Text), conectar);
            OdbcDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                cte.cod = _reader.GetInt16(0);
               
            }

           // MessageBox.Show(Convert.ToString(cte.cod));
            dgv_ped.DataSource = ClsOpPedido.Buscarpedido(cte.cod);
            //dgv_ped.Columns.Remove("codcte");
            //dgv_fol.Columns.Remove("fec_pago");
        }

        public ClsPedido PedSelec { get; set; }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_ped.SelectedRows.Count == 1)
                {
                    int id = Convert.ToInt16(dgv_ped.CurrentRow.Cells[0].Value);
                    PedSelec = ClsOpPedido.ObtenerPedido(id);
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

        private void BuscPedido_Load(object sender, EventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
