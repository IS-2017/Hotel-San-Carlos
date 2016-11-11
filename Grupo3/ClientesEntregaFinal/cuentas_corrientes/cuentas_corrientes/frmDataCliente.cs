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
using FuncionesNavegador;
using dllconsultas;

namespace cuentas_corrientes
{
    public partial class frmDataCliente : Form
    {
        public frmDataCliente()
        {
            InitializeComponent();
            OdbcConnection conexion = seguridad.Conexion.ObtenerConexionODBC();
            OdbcDataAdapter dausuario = new OdbcDataAdapter("SELECT * FROM cliente", conexion);
            DataSet dsuario = new DataSet();
            dausuario.Fill(dsuario, "cliente");
            dgv_cliente.DataSource = dsuario;
            dgv_cliente.DataMember = "cliente";

        }

        public cls_cliente ImpSelec { get; set; }
        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            if (dgv_cliente.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt16(dgv_cliente.CurrentRow.Cells[0].Value);
                ImpSelec = clsOcliente.Obtenerclte(id);
                cuentas_corrientes.frmcliente impe = new cuentas_corrientes.frmcliente(ImpSelec);
                impe.ShowDialog();

            }
            else
            {
                frmcliente tem = new frmcliente(ImpSelec);
                tem.ShowDialog();
            }
        }

        private void frmDataCliente_Load(object sender, EventArgs e)
        {
            OdbcConnection conexion = seguridad.Conexion.ObtenerConexionODBC();
            OdbcDataAdapter dausuario = new OdbcDataAdapter("SELECT * FROM cliente", conexion);
            DataSet dsuario = new DataSet();
            dausuario.Fill(dsuario, "cliente");
            dgv_cliente.DataSource = dsuario;
            dgv_cliente.DataMember = "cliente";
        }        

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            dllconsultas.operaciones op = new dllconsultas.operaciones();
            op.ejecutar(dgv_cliente,"cliente");
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            OdbcConnection conexion = seguridad.Conexion.ObtenerConexionODBC();
            OdbcDataAdapter dausuario = new OdbcDataAdapter("SELECT * FROM cliente", conexion);
            DataSet dsuario = new DataSet();
            dausuario.Fill(dsuario, "cliente");
            dgv_cliente.DataSource = dsuario;
            dgv_cliente.DataMember = "cliente";            
        }

        FuncionesNavegador.CapaNegocio fn = new FuncionesNavegador.CapaNegocio();
        private void btn_anterior_Click(object sender, EventArgs e)
        {
            fn.Anterior(dgv_cliente);
            //TextBox[] textbox = { textBox4, textBox3, textBox2, textBox5 };
            //fn.llenartextbox(textbox, dataGridView1);
            //dateTimePicker1.Text = textBox5.Text;
            //comboBox1.Text = textBox4.Text;
        }
        public int id;
        private void dgv_cliente_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {                
                id = Convert.ToInt16(dgv_cliente.CurrentRow.Cells[0].Value);                
                //MessageBox.Show(Convert.ToString(id));
                string snom = dgv_cliente.Rows[dgv_cliente.CurrentCell.RowIndex].Cells[2].Value.ToString();
                string sapel = dgv_cliente.Rows[dgv_cliente.CurrentCell.RowIndex].Cells[3].Value.ToString();
                string sdpi = dgv_cliente.Rows[dgv_cliente.CurrentCell.RowIndex].Cells[4].Value.ToString();
                string snit = dgv_cliente.Rows[dgv_cliente.CurrentCell.RowIndex].Cells[5].Value.ToString();
                string sdirec = dgv_cliente.Rows[dgv_cliente.CurrentCell.RowIndex].Cells[7].Value.ToString();
                string svend = dgv_cliente.Rows[dgv_cliente.CurrentCell.RowIndex].Cells[11].Value.ToString();
                string stel = dgv_cliente.Rows[dgv_cliente.CurrentCell.RowIndex].Cells[6].Value.ToString();
                string scor = dgv_cliente.Rows[dgv_cliente.CurrentCell.RowIndex].Cells[1].Value.ToString();
                string sfec = dgv_cliente.Rows[dgv_cliente.CurrentCell.RowIndex].Cells[8].Value.ToString();
                string stcred = dgv_cliente.Rows[dgv_cliente.CurrentCell.RowIndex].Cells[9].Value.ToString();
                string stcontri = dgv_cliente.Rows[dgv_cliente.CurrentCell.RowIndex].Cells[10].Value.ToString();
                string stcata = dgv_cliente.Rows[dgv_cliente.CurrentCell.RowIndex].Cells[12].Value.ToString();
                frmcliente temp = new frmcliente(snom, sapel, sdpi, snit, sdirec, svend, stel, scor, sfec, stcred, stcontri, stcata);
                temp.id(id);
                temp.ShowDialog(this);                                           
                //funActualizarGrid();
            }
            catch (Exception)
            {
                MessageBox.Show("Error Al editar el Registro");
            }
        }
    }
}
