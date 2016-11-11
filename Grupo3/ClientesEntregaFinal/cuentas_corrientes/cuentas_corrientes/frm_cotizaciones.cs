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
using seguridad;
using dllconsultas;
//using Abrir;

namespace cuentas_corrientes
{
    public partial class frm_cotizaciones : Form
    {
        public frm_cotizaciones()
        {
            InitializeComponent();
        }
        public encabezado encabezadoseleccionado { get; set; }
        public string id;
        public string nombre;
        public string apellido;
        public string nit;
        public string direccion;
        public string fecha;
        public string estado;
        public string telefono;
        private void frm_cotizaciones_Load(object sender, EventArgs e)
        {

        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            OdbcConnection cn = seguridad.Conexion.ObtenerConexionODBC();
            DataTable dt = new DataTable();
            String query = "select id_cotizacion, nombre_cte, apellido_cte, nit_cte, telefono_cte, direccion_cte, fecha_cot, estado_cot from cotizacion";
            OdbcCommand cmd = new OdbcCommand(query, cn);
            OdbcDataAdapter da = new OdbcDataAdapter(cmd);

            da.Fill(dt);
            dgv_cotizaciones.DataSource = dt;
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            dllconsultas.operaciones op = new dllconsultas.operaciones();
            op.ejecutar(dgv_cotizaciones, "cotizacion");
        }

        private void dgv_cotizaciones_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //try
            //{
                nombre = dgv_cotizaciones.Rows[dgv_cotizaciones.CurrentCell.RowIndex].Cells[1].Value.ToString();
                apellido = dgv_cotizaciones.Rows[dgv_cotizaciones.CurrentCell.RowIndex].Cells[2].Value.ToString();
                id = dgv_cotizaciones.Rows[dgv_cotizaciones.CurrentCell.RowIndex].Cells[0].Value.ToString();
                nit = dgv_cotizaciones.Rows[dgv_cotizaciones.CurrentCell.RowIndex].Cells[3].Value.ToString();
                telefono = dgv_cotizaciones.Rows[dgv_cotizaciones.CurrentCell.RowIndex].Cells[4].Value.ToString();
                direccion = dgv_cotizaciones.Rows[dgv_cotizaciones.CurrentCell.RowIndex].Cells[5].Value.ToString();
                fecha = dgv_cotizaciones.Rows[dgv_cotizaciones.CurrentCell.RowIndex].Cells[6].Value.ToString();
                estado = dgv_cotizaciones.Rows[dgv_cotizaciones.CurrentCell.RowIndex].Cells[7].Value.ToString();
                telefono = dgv_cotizaciones.Rows[dgv_cotizaciones.CurrentCell.RowIndex].Cells[4].Value.ToString();
                //string scor = dgv_cliente.Rows[dgv_cliente.CurrentCell.RowIndex].Cells[1].Value.ToString();
                //string sfec = dgv_cliente.Rows[dgv_cliente.CurrentCell.RowIndex].Cells[8].Value.ToString();
                //string stcred = dgv_cliente.Rows[dgv_cliente.CurrentCell.RowIndex].Cells[9].Value.ToString();
                //string stcontri = dgv_cliente.Rows[dgv_cliente.CurrentCell.RowIndex].Cells[10].Value.ToString();
                //string stcata = dgv_cliente.Rows[dgv_cliente.CurrentCell.RowIndex].Cells[12].Value.ToString();
                frmCotizacion_ temp = new frmCotizacion_(id, nombre, apellido, nit, telefono, direccion, fecha, estado);
                temp.ShowDialog(this);
                //funActualizarGrid();
                
            /*}
            catch (Exception)
            {
                MessageBox.Show("Error Al editar el Registro");
            }*/
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            
                frmCotizacion tem = new frmCotizacion();
                tem.ShowDialog();
           
        }

        private void dgv_cotizaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_reporte_Click(object sender, EventArgs e)
        {
            /*Abrir.Form1 abrir = new Abrir.Form1();
            abrir.Crystal = @"Cotizacion.rpt";
            abrir.Show();*/
        }
    }
}
