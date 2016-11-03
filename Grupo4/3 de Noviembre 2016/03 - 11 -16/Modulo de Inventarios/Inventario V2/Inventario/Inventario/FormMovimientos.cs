using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FuncionesNavegador;

namespace Inventario
{
    public partial class FormMovimientos : Form
    {
        public FormMovimientos()
        {
            InitializeComponent();
        }

        private void FormMovimientos_Load(object sender, EventArgs e)
        {
            SistemaInventarioDatos sd = new SistemaInventarioDatos();
            dgw_movimientos.DataSource = sd.TodosLosMovimientos();

            dgw_movimientos.Columns[0].HeaderText = "Mov.";
            dgw_movimientos.Columns[1].HeaderText = "Fecha";
            dgw_movimientos.Columns[2].HeaderText = "Codigo prod.";
            dgw_movimientos.Columns[3].HeaderText = "Descripción";
            dgw_movimientos.Columns[4].HeaderText = "Cant.";
            dgw_movimientos.Columns[5].HeaderText = "Transacción";
            dgw_movimientos.Columns[6].HeaderText = "Bodega";
            dgw_movimientos.Columns[7].HeaderText = "Doc.";
            dgw_movimientos.Columns[8].HeaderText = "Tipo doc.";


            dgw_movimientos.Columns[0].Width = 40;
            dgw_movimientos.Columns[1].Width = 70;
            dgw_movimientos.Columns[2].Width = 55;
            dgw_movimientos.Columns[3].Width = 290;
            dgw_movimientos.Columns[4].Width = 35;
            dgw_movimientos.Columns[5].Width = 70;
            dgw_movimientos.Columns[6].Width = 95;
            dgw_movimientos.Columns[7].Width = 42;
            dgw_movimientos.Columns[8].Width = 103;

        }

        private void btn_compras_Click(object sender, EventArgs e)
        {
            SistemaInventarioDatos sd = new SistemaInventarioDatos();
            dgw_movimientos.DataSource = sd.MovimientosCompras();
        }

        private void btn_devv_Click(object sender, EventArgs e)
        {
            SistemaInventarioDatos sd = new SistemaInventarioDatos();
            dgw_movimientos.DataSource = sd.MovimientosDevV();
        }

        private void btn_ventas_Click(object sender, EventArgs e)
        {
            SistemaInventarioDatos sd = new SistemaInventarioDatos();
            dgw_movimientos.DataSource = sd.MovimientosVentas();
        }

        private void btn_devc_Click(object sender, EventArgs e)
        {
            SistemaInventarioDatos sd = new SistemaInventarioDatos();
            dgw_movimientos.DataSource = sd.MovimientosDevC();
        }

        private void btn_todos_Click(object sender, EventArgs e)
        {
            SistemaInventarioDatos sd = new SistemaInventarioDatos();
            dgw_movimientos.DataSource = sd.TodosLosMovimientos();
        }

        private void dgw_movimientos_DoubleClick(object sender, EventArgs e)
        {
            
                FormDocumento f = new FormDocumento();
                f.MdiParent = this.MdiParent;

            SistemaInventarioDatos sd = new SistemaInventarioDatos();
            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();
            DataTable dt_doc = new DataTable();
            DataRow row;
            DataRow row2;
                string doc = dgw_movimientos.CurrentRow.Cells[7].Value.ToString();
                string[] doc_separado = doc.Split('-');
                string no = doc_separado[0].Trim();
                string serie = doc_separado[1].Trim();
                DateTime fe = Convert.ToDateTime(dgw_movimientos.CurrentRow.Cells[1].Value);
                string fecha = fe.ToString("dd-MM-yyyy");
                string tipo_doc = dgw_movimientos.CurrentRow.Cells[8].Value.ToString().Trim();
                string prov;
                string cliente;

                f.lbl_fecha.Text = fecha;
                f.lbl_no.Text = no;
                f.lbl_serie.Text = serie;
                f.lbl_tipo.Text = tipo_doc;
                //------------------
                string transaccion = dgw_movimientos.CurrentRow.Cells[5].Value.ToString();
                if (transaccion == "Compra")
                {
                try
                {
                   dt = sd.ObtenerProvClieCom(no,"-",tipo_doc);
                    row = dt.Rows[0];
                    string id_prov = row[0].ToString();
                    dt2 = sd.Prov(id_prov);
                    row2 = dt2.Rows[0];
                    string nombre_prov = row2[0].ToString();
                    f.label7.Visible = true;
                    f.lbl_prov.Visible = true;
                    f.lbl_prov.Text = nombre_prov;
                    //------------------------------
                    dt_doc = sd.ObtenerDetalleDocInv(no,"-",tipo_doc);
                    f.dgw_det.DataSource = dt_doc;
                   
                }
                catch { }

                }
           
                else if (transaccion == "Devolucion sobre compra")
                {
                try
                {
                    dt = sd.ObtenerProvClieCom(no, "-", tipo_doc);
                    row = dt.Rows[0];
                    string id_prov = row[0].ToString();
                    dt2 = sd.Prov(id_prov);
                    row2 = dt2.Rows[0];
                    string nombre_prov = row2[0].ToString();
                    f.label7.Visible = true;
                    f.lbl_prov.Visible = true;
                    f.lbl_prov.Text = nombre_prov;
                    //------------------------------
                    dt_doc = sd.ObtenerDetalleDocInv(no, "-", tipo_doc);
                    f.dgw_det.DataSource = dt_doc;
                }
                catch { }
                }
           

                //---
                f.Show();
          
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            CapaNegocio fn = new CapaNegocio();
            fn.Anterior(dgw_movimientos);
            //TextBox[] textbox = { txt_abrev, txt_nombre };
            //fn.llenartextbox(textbox, dgw_movimientos);
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            CapaNegocio fn = new CapaNegocio();
            fn.Siguiente(dgw_movimientos);
        }

        private void btn_primero_Click(object sender, EventArgs e)
        {
            CapaNegocio fn = new CapaNegocio();
            fn.Primero(dgw_movimientos);
        }

        private void btn_ultimo_Click(object sender, EventArgs e)
        {
            CapaNegocio fn = new CapaNegocio();
            fn.Ultimo(dgw_movimientos);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Abrir.Form1 hola = new Abrir.Form1();
            hola.Crystal = @"C:\Users\GABRIELA\Music\mantenimiento aplicacion\reporte_existencias\reporte_existencias\reporte_movimientos.rpt";
            hola.Show();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
