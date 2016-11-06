using MySql.Data.MySqlClient;
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
using seguridad;



namespace cuentas_corrientes
{
    public partial class frm_cotizaciones : Form
    {
        public frm_cotizaciones()
        {
            InitializeComponent();
        }
        OdbcConnection con = new OdbcConnection();
        public bien bienseleccionado { get; set; }
        public encabezado encabezadoseleccionado { get; set; }
        public detalle_cot detalleseleccionado { get; set; }
        public encabezado encabezadoactual { get; set; }
        private void button1_Click(object sender, EventArgs e)
        {
            OdbcConnection cn = seguridad.Conexion.ObtenerConexionODBC();
            DataTable dt = new DataTable();
            String query = "Select * from cotizacion";
            OdbcCommand cmd = new OdbcCommand(query, cn);
            OdbcDataAdapter da = new OdbcDataAdapter(cmd);

            da.Fill(dt);
            dgv_cotizaciones.DataSource = dt;
            /*cls_bdcomun.ObtenerConexionODBC();
            string squery = "SELECT * from cotizacion";
            //OdbcConnection con = new OdbcConnection("server=localhost; database=base1; Uid=root; pwd=;");
            //con.Open();
            //OdbcCommand cmdc = new OdbcCommand(squery, ConexionODBC. .ObtenerConexion());
            OdbcCommand cmdc = new OdbcCommand(squery, con.ConnectionString());
            DataTable dtDatos = new DataTable();
            OdbcDataAdapter mdaDatos = new OdbcDataAdapter(cmdc);
            mdaDatos.Fill(dtDatos);
            con.Close();
            dgv_cotizaciones.DataSource = dtDatos;*/
           
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            frmCotizacion frm = new frmCotizacion();
            frm.Show();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dgv_cotizaciones.SelectedRows.Count > 0)
            {
                int id_cotizacion = Convert.ToInt32(dgv_cotizaciones.CurrentRow.Cells[0].Value);
                //bienseleccionado = cls_cotizaciondal.ObtenerProveedor(id_bien_pk);
                //MessageBox.Show();
                this.Close();
                if (MessageBox.Show("Esta Seguro que desea eliminar la cotizacion seleccionada", "Estas Seguro??", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                {

                    if (cls_cotizaciondal.Eliminar(id_cotizacion) > 0)

                    {

                        MessageBox.Show("Cotizacion Eliminada Correctamente!", "Cliente Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                    else

                    {

                        MessageBox.Show("No se pudo eliminar la Cotizacion", "Cotizacion No Eliminada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }

                }

                else
                {

                    MessageBox.Show("Se cancelo la eliminacion", "Eliminacion Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                /*txt_nombre.Clear();
                txt_direccion.Clear();
                txt_nit.Clear();
                txt_observaciones.Clear();
                txt_razon.Clear();
                usuariodal.obtenerBitacora(usuariodal.varibaleUsuario, "Eliminar", "proveedor");*/
            }
            else
                MessageBox.Show("debe de seleccionar una fila");
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            /* if (dgv_cotizaciones.SelectedRows.Count > 0)
             {
                 int id_cotizacion = Convert.ToInt32(dgv_cotizaciones.CurrentRow.Cells[0].Value);
                 //bienseleccionado = cls_cotizaciondal.ObtenerProveedor(id_bien_pk);
                 //MessageBox.Show();
             }
             this.Close();*/
        }

        private void dgv_cotizaciones_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            /*if (dgv_cotizaciones.SelectedRows.Count > 0)
            {
                int id_cotizacion = Convert.ToInt32(dgv_cotizaciones.CurrentRow.Cells[0].Value);
                //MessageBox.Show();
                frmCotizacion frm = new frmCotizacion(id_cotizacion);
                frm.ShowDialog();
                encabezadoseleccionado = cls_cotizaciondal.ObtenerEncabezado(id_cotizacion);
                if (frm.encabezadoseleccionado != null)
                {
                    encabezadoactual = frm.encabezadoseleccionado;
                    
                    .Text = frm.encabezadoseleccionado.nombre_cte;
                    txt_direccion.Text = frm.ProveedorSeleccionado.direc_prov;
                    //txt_telefono.Text = frm.ProveedorSeleccionado.
                    txt_razon.Text = frm.ProveedorSeleccionado.razon_social_prov;
                    txt_observaciones.Text = frm.ProveedorSeleccionado.observ_prov;
                    txt_nit.Text = frm.ProveedorSeleccionado.nit_prov;
                }
            }
            this.Close();*/
            /*if (dgv_cotizaciones.SelectedRows.Count > 0)
            {
                int id_cotizacion = Convert.ToInt32(dgv_cotizaciones.CurrentRow.Cells[0].Value);
                //MessageBox.Show();
                frmCotizacion frm = new frmCotizacion();
                frm.ShowDialog();
                encabezadoseleccionado = cls_cotizaciondal.ObtenerEncabezado(id_cotizacion);
                if (frm.encabezadoseleccionado != null)
                {
                    encabezadoactual = frm.encabezadoseleccionado;

                    frm.textBox1.Text = frm.encabezadoseleccionado.nombre_cte;
                    frm.textBox2.Text = frm.encabezadoseleccionado.apellido_cte;
                    //txt_telefono.Text = frm.ProveedorSeleccionado.
                    frm.textBox3.Text = frm.encabezadoseleccionado.direccion_cte;
                    frm.textBox4.Text = frm.encabezadoseleccionado.fecha_cot;
                    frm.textBox5.Text = frm.encabezadoseleccionado.nit_cte;
                    frm.comboBox1.Text = frm.encabezadoseleccionado.estado_cot;
                }
            }
            this.Close();*/

        }

        private void frm_cotizaciones_Load(object sender, EventArgs e)
        {

        }

        private void dgv_cotizaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*frmCotizacion f = new frmCotizacion();
            f.MdiParent = this.MdiParent;


            f.textBox1.Text = ;
            f.lbl_no.Text = no;
            f.lbl_serie.Text = serie;
            f.lbl_tipo.Text = tipo_doc;
            f.dgw_det.DataSource = dt_doc;*/
            /*if (dgv_cotizaciones.SelectedRows.Count > 0)
           {
               int id_cotizacion = Convert.ToInt32(dgv_cotizaciones.CurrentRow.Cells[0].Value);
               //MessageBox.Show();
               frmCotizacion frm = new frmCotizacion();
               frm.ShowDialog();
               encabezadoseleccionado = cls_cotizaciondal.ObtenerEncabezado(id_cotizacion);
               if (frm.encabezadoseleccionado != null)
               {
                   encabezadoactual = frm.encabezadoseleccionado;

                   frm.textBox1.Text = frm.encabezadoseleccionado.nombre_cte;
                   frm.textBox2.Text = frm.encabezadoseleccionado.apellido_cte;
                   //txt_telefono.Text = frm.ProveedorSeleccionado.
                   frm.textBox3.Text = frm.encabezadoseleccionado.direccion_cte;
                   frm.textBox4.Text = frm.encabezadoseleccionado.fecha_cot;
                   frm.textBox5.Text = frm.encabezadoseleccionado.nit_cte;
                    frm.comboBox1.Text = frm.encabezadoseleccionado.estado_cot;
               }
           }
           this.Close();*/
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //MySqlConnection cn = cls_bdcomun.ObtenerConexion();
            /*DataTable dt = new DataTable();
            String query = "Select * from cotizacion";
            OdbcCommand cmd = new OdbcCommand(query, Conexion.ObtenerConexionODBC());
            OdbcDataAdapter da = new OdbcDataAdapter(cmd);

            da.Fill(dt);
            dgv_cotizaciones.DataSource = dt;*/  // para odbc conexion con seguridad
            /*OdbcConnection conexion = cls_bdcomun.ObtenerConexionODBC();
            OdbcDataAdapter cotiza = new OdbcDataAdapter("SELECT * FROM cotizaciones", conexion);
            DataSet dsuario = new DataSet();
            cotiza.Fill("cotizacion");
            dgv_cotizaciones.DataSource = dsuario;
            dgv_cotizaciones.DataMember = "cotizacion";*/
            OdbcConnection cn = seguridad.Conexion.ObtenerConexionODBC();
            DataTable dt = new DataTable();
            String query = "Select * from cotizacion";
            OdbcCommand cmd = new OdbcCommand(query, cn);
            OdbcDataAdapter da = new OdbcDataAdapter(cmd);

            da.Fill(dt);
            dgv_cotizaciones.DataSource = dt;
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            frmCotizacion frm = new frmCotizacion();
            frm.Show();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            dllconsultas.operaciones op = new dllconsultas.operaciones();
            op.ejecutar(dgv_cotizaciones, "cotizacion");
        }

        private void dgv_cotizaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           /* if (dgv_cotizaciones.SelectedRows.Count > 0)
            {
                int id_cotizacion = Convert.ToInt32(dgv_cotizaciones.CurrentRow.Cells[0].Value);
                //MessageBox.Show();
                frmCotizacion frm = new frmCotizacion();
                frm.ShowDialog();
                encabezadoseleccionado = cls_cotizaciondal.ObtenerEncabezado(id_cotizacion);
                if (frm.encabezadoseleccionado != null)
                {
                    encabezadoactual = frm.encabezadoseleccionado;

                    frm.textBox1.Text = frm.encabezadoseleccionado.nombre_cte;
                    frm.textBox2.Text = frm.encabezadoseleccionado.apellido_cte;
                    //txt_telefono.Text = frm.ProveedorSeleccionado.
                    frm.textBox3.Text = frm.encabezadoseleccionado.direccion_cte;
                    frm.textBox4.Text = frm.encabezadoseleccionado.fecha_cot;
                    frm.textBox5.Text = frm.encabezadoseleccionado.nit_cte;
                    frm.comboBox1.Text = frm.encabezadoseleccionado.estado_cot;
                }
            }
            this.Close();*/

            /*frmCotizacion f = new frmCotizacion();
           f.MdiParent = this.MdiParent;
           


            f.textBox1.Text = nombre_cte ;
           f.lbl_no.Text = no;
           f.lbl_serie.Text = serie;
           f.lbl_tipo.Text = tipo_doc;
           f.dgw_det.DataSource = dt_doc;*/
        }

        /*private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frm_cotizaciones
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "frm_cotizaciones";
            this.Load += new System.EventHandler(this.frm_cotizaciones_Load_1);
            this.ResumeLayout(false);

        }*/

        private void frm_cotizaciones_Load_1(object sender, EventArgs e)
        {

        }
    }
}
