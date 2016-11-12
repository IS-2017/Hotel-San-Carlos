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
    public partial class FormRequisicion : Form
    {
        public FormRequisicion()
        {
            InitializeComponent();
        }
        string id_form = "10113";
        private void FormRequisicion_Load(object sender, EventArgs e)
        {
            try
            {
               
                SistemaInventarioDatos sd = new SistemaInventarioDatos();
                cbo_bodega.DataSource = sd.ObtenerBodega();
                cbo_bodega.DisplayMember = "nombre_bodega";
                cbo_bodega.ValueMember = "id_bodega_pk";
                //***************************************************
                DataGridViewComboBoxColumn cbobienes = dgw_requisicion.Columns[1] as DataGridViewComboBoxColumn;
                cbobienes.DataSource = sd.ObtenerBien();
                cbobienes.DisplayMember = "descripcion";
                cbobienes.ValueMember = "CODIGO";

                //DataGridViewComboBoxColumn cbobodega = dgw_requisicion.Columns[2] as DataGridViewComboBoxColumn;
                //cbobodega.DataSource = sd.ObtenerBodega();
                //cbobodega.DisplayMember = "nombre_bodega";
                //cbobodega.ValueMember = "id_bodega_pk";

                dgw_requisicion.AutoGenerateColumns = false;
            }
            catch (Exception ex) { MessageBox.Show("No posee los permisos necesarios!", "¡Seguridad!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btn_añadir_Click(object sender, EventArgs e)
        {
            DataGridViewRow entrada = new DataGridViewRow();
            dgw_requisicion.Rows.Add(entrada);
        }

        private void btn_quitar_Click(object sender, EventArgs e)
        {

            if (dgw_requisicion.CurrentRow.Index != dgw_requisicion.Rows.Count - 1)
            {

                DataGridViewRow entrada = new DataGridViewRow();
                entrada = dgw_requisicion.Rows[dgw_requisicion.CurrentRow.Index];
                dgw_requisicion.Rows.Remove(entrada);

            }
        }

        private void dgw_requisicion_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgw_requisicion.Columns[e.ColumnIndex].Name == "Descripcion")
            {

                DataGridViewComboBoxCell CboBienes = dgw_requisicion.CurrentRow.Cells["Descripcion"] as DataGridViewComboBoxCell;
                // DataGridViewComboBoxCell CboBienes = dgw_requisicion.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewComboBoxCell;
                string codigo = CboBienes.Value.ToString();
                dgw_requisicion.CurrentRow.Cells["Codigo"].Value = codigo;

                SistemaInventarioDatos sd = new SistemaInventarioDatos();
                DataTable dtc = sd.ObtenerCosto(codigo);
                DataRow row = dtc.Rows[0];
                string costo = row[0].ToString();
                dgw_requisicion.CurrentRow.Cells["Costo"].Value = costo;
            }
        }

        private void btn_crear_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txt_encargado.Text.Trim()))
            {
                SistemaInventarioDatos sd = new SistemaInventarioDatos();
                DateTime fecha = Convert.ToDateTime(dtp_fecha_req.Value);
                //fecha.ToString("yyyy-MM-dd");
                string encargado = txt_encargado.Text.Trim();
                int bodega = Convert.ToInt32(cbo_bodega.SelectedValue);

                int x = sd.AgregarRequisicion(fecha.ToString("yyyy-MM-dd"), encargado, bodega, dgw_requisicion);
                //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
                //>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                sd.IngresarCompra(fecha.ToString("yyyy-MM-dd"),  dgw_requisicion);//QUITAR DESPUES**
                //>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
                if (x == 1)
                {
                    MessageBox.Show("Requisicion agregada");
                }
            }
            else { MessageBox.Show("debe ingresar nombre del encargado"); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //dtp_fecha_req.Format =;
            //DateTime fecha =  dtp_fecha_req.Format;
            //txt_encargado.Text = fecha;


            //DateTime fecha_e = Convert.ToDateTime(dateTimePicker1.Value);

            
                //fecha_e.ToString("yyyy-MM-dd")

                //}
       }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    string codigo = dgw_requisicion.CurrentRow.Cells["Codigo"].Value.ToString();

        //    char[] delimitador = { '-' };

        //        string[] codigo_separado = codigo.Split(delimitador);

        //        string id_categoria = codigo_separado[0];
        //        string id_bien = codigo_separado[1];
        //    MessageBox.Show("la categoria es:" + id_categoria);
        //    MessageBox.Show("el bien es: "+id_bien);
        //}



    }
}
