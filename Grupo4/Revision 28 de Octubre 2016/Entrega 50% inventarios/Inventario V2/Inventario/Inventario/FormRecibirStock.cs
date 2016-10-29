using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario
{
    public partial class FormRecibirStock : Form
    {
        public FormRecibirStock()
        {
            InitializeComponent();
        }

        private void rdbt_CheckedChanged(object sender, EventArgs e)
        {
            cbo_orden.Enabled = false;
            cbo_proveedor.Enabled = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            cbo_proveedor.Enabled = false;
            cbo_orden.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SistemaInventarioDatos sd = new SistemaInventarioDatos();

            //DataGridViewComboBoxColumn cbobienes = dgw_entradas.Columns["Descripcion"] as DataGridViewComboBoxColumn;
            //cbobienes.DataSource = sd.ObtenerBien();
            //cbobienes.DisplayMember = "descripcion";
            //cbobienes.ValueMember = "CODIGO";
            //************************************************
            
            DataGridViewRow entrada = new DataGridViewRow();
            dgw_entradas.Rows.Add(entrada);
            //*****************************
            //DataGridViewRow row = new DataGridViewRow();
            //row = dgw_entradas.Rows[dgw_entradas.Rows.Count - 2];
            //DataGridViewComboBoxCell CboBienes = row.Cells["Descripcion"] as DataGridViewComboBoxCell;
            //CboBienes.DataSource = sd.ObtenerBien();
            //CboBienes.DisplayMember = "descripcion";
            //CboBienes.ValueMember = "CODIGO";
            //**********************************



        }

        private void btn_quitar_Click(object sender, EventArgs e)
        {
                 if (dgw_entradas.CurrentRow.Index != dgw_entradas.Rows.Count - 1)
                   {

                DataGridViewRow entrada = new DataGridViewRow();
                entrada = dgw_entradas.Rows[dgw_entradas.CurrentRow.Index];
                dgw_entradas.Rows.Remove(entrada);

                  }
        }

        private void FormRecibirStock_Load(object sender, EventArgs e)
        {
            SistemaInventarioDatos sd = new SistemaInventarioDatos();

            DataGridViewComboBoxColumn cbobienes = dgw_entradas.Columns[1] as DataGridViewComboBoxColumn;
            cbobienes.DataSource = sd.ObtenerBien();
            cbobienes.DisplayMember = "descripcion";
            cbobienes.ValueMember = "CODIGO";

            DataGridViewComboBoxColumn cbobodega = dgw_entradas.Columns[2] as DataGridViewComboBoxColumn;
            cbobodega.DataSource = sd.ObtenerBodega();
            cbobodega.DisplayMember = "nombre_bodega";
            cbobodega.ValueMember = "id_bodega_pk";

            dgw_entradas.AutoGenerateColumns = false;

            //***************************************
            rdbt.Checked = true;
            cbo_proveedor.DataSource = sd.ObtenerProveedor();
            cbo_proveedor.ValueMember = "id_proveedor_pk";
            cbo_proveedor.DisplayMember = "nombre_proveedor";
            //***************************************
            cbo_orden.DataSource = sd.ObtenerReq();   /*REQ*/
            cbo_orden.ValueMember = "id_requisicion_pk";
            cbo_orden.DisplayMember = "id_requisicion_pk";

            //cbo_orden.DataSource = sd.ObtenerOrden();      /*OC*/
            //cbo_orden.ValueMember = "id_factura_compra_pk";
            //cbo_orden.DisplayMember = "id_factura_compra_pk";


        }

        private void dgw_entradas_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if(dgw_entradas.Columns[e.ColumnIndex].Name == "Descripcion")
            {

                DataGridViewComboBoxCell CboBienes = dgw_entradas.CurrentRow.Cells["Descripcion"] as DataGridViewComboBoxCell;
               // DataGridViewComboBoxCell CboBienes = dgw_entradas.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewComboBoxCell;
                string codigo = CboBienes.Value.ToString();
                dgw_entradas.CurrentRow.Cells["Codigo"].Value = codigo;

                SistemaInventarioDatos sd = new SistemaInventarioDatos();
                DataTable dtc = sd.ObtenerCosto(codigo);
                DataRow row = dtc.Rows[0];
                 string costo = row[0].ToString();
                dgw_entradas.CurrentRow.Cells["Costo"].Value =  costo;
            }
        }

        private void cbo_orden_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_orden.SelectedValue is int)
            {
                SistemaInventarioDatos sd = new SistemaInventarioDatos();
                DataTable dt = sd.ObtenerDetalleReq(cbo_orden.SelectedValue.ToString());
                dgw_entradas.Rows.Clear();

                foreach (DataRow row in dt.Rows)
                {
                    string categoria = row[0].ToString().Trim();
                    string id_bien = row[1].ToString().Trim();
                    string cantidad = row[2].ToString().Trim();
                    string codigo = categoria + "-" + id_bien;
                    DataGridViewRow entrada = new DataGridViewRow();
                    dgw_entradas.Rows.Add(entrada);

                    DataGridViewComboBoxCell CboBienes = dgw_entradas.Rows[dgw_entradas.Rows.Count - 2].Cells["Descripcion"] as DataGridViewComboBoxCell;

                    CboBienes.Value = codigo;
                    //---------------------------------------
                    dgw_entradas.Rows[dgw_entradas.Rows.Count - 2].Cells["Codigo"].Value = codigo;

                   
                    DataTable dtc = sd.ObtenerCosto(codigo);
                    DataRow rowc = dtc.Rows[0];
                    string costo = rowc[0].ToString();
                    

                    dgw_entradas.Rows[dgw_entradas.Rows.Count - 2].Cells["Costo"].Value = costo;

                    dgw_entradas.Rows[dgw_entradas.Rows.Count - 2].Cells["Cant_recibida"].Value = cantidad;


                }
               // dgw_entradas.Refresh();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
