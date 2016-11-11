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

        string id_form = "10112";

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
            try
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
                //cbo_orden.DataSource = sd.ObtenerReq();   /*REQ*/
                //cbo_orden.ValueMember = "id_requisicion_pk";
                //cbo_orden.DisplayMember = "id_requisicion_pk";

                cbo_orden.DataSource = sd.ObtenerOrden();      /*OC*/
                cbo_orden.ValueMember = "id_factura_compra_pk";
                cbo_orden.DisplayMember = "id_factura_compra_pk";

            }
            catch (Exception ex) { MessageBox.Show("No posee los permisos necesarios!", "¡Seguridad!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
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
                 dgw_entradas.CurrentRow.Cells["Cant_recibida"].Value = 1;
                
            }
        }

        private void cbo_orden_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
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
                    //-----
                    DataRow primera = dt.Rows[0];
                    string cantidad_primera = primera[2].ToString();
                    dgw_entradas.Rows[0].Cells["Cant_recibida"].Value = cantidad_primera;

                    //-----
                    // dgw_entradas.Refresh();
                }
            }
            catch { MessageBox.Show("Compra sin detalle"); }
        }




        private void button1_Click_1(object sender, EventArgs e)
        {
            //try
            //{

                SistemaInventarioDatos sd = new SistemaInventarioDatos();
                char delimitador = '-';
                bool vacia = ValidarBodegaVacia();
                if (vacia == false)
                {
                    foreach (DataGridViewRow fila in dgw_entradas.Rows)
                    {
                        //desaparecer orden
                        if (fila.Cells["Codigo"].Value != null)
                        {
                            //------------OBTENER BODEGA, CANTIDAD Y BIEN
                            int cantidad = Convert.ToInt32(fila.Cells["Cant_recibida"].Value);
                            //string bodega = fila.Cells["bodega"].Value.ToString();
                            DataGridViewComboBoxCell CboBodega = fila.Cells["bodega"] as DataGridViewComboBoxCell;
                            string bodega = CboBodega.Value.ToString();

                            //string codigo = fila.Cells["Descripcion"].Value.ToString();
                            DataGridViewComboBoxCell CboBienes = fila.Cells["Descripcion"] as DataGridViewComboBoxCell;
                            string codigo = CboBienes.Value.ToString();

                            string[] codigo_separado = codigo.Split(delimitador);
                            string categoria = codigo_separado[0].Trim();
                            string id_bien = codigo_separado[1].Trim();
                            //-----------VALIDAR SI YA EXISTE LA TUPLA
                            int y = sd.ValidarExistenciaDeProducto(id_bien, categoria, bodega);

                            if (y == 1)
                            {
                                int existencias = sd.ObtenerExistenciasEnBodega(id_bien, categoria, bodega);
                                int nueva_existencia = existencias + cantidad;
                                sd.ActualizarExistenciasEnBodega(id_bien, categoria, bodega, nueva_existencia);
                            }
                            else
                            {
                                sd.InsertarProductoEnBodega(id_bien, categoria, bodega, cantidad);
                            }

                        }



                    }
                    MessageBox.Show("Orden ingresada con exito");
                if (radioButton2.Checked)
                {
                    //<<<<<<<<<<<<<<INGRESAR DOCUMENTO<<<<<<<<<<<<<<<<<<<<<
                    //ENC
                    string id_orden = cbo_orden.SelectedValue.ToString();
                    DataTable dt_orden = sd.ObtenerDatosOrdenDeCompra(id_orden);
                    DataRow rowk = dt_orden.Rows[0];
                    string proveedor = rowk[0].ToString();
                    DateTime fecha = Convert.ToDateTime(rowk[1]);
                    string fechaS = fecha.ToString("yyyy-MM-dd");
                    string empresa = rowk[2].ToString();

                    sd.InsertarDocInv(id_orden, fechaS, empresa, proveedor);
                    //DET
                    IngresarDetalleOrden(id_orden, empresa);
                    //<<<<<<<<<<<<REGISTRAR MOVIMIENTO<<<<<<<<<<<<<<<<<<<<<
                    RegistrarMovimiento(id_orden, empresa);

                    //<<<<<<<DESAPARECER ORDEN<<<<<<<
                    sd.OrdenProcesada(id_orden);

                    cbo_orden.DataSource = sd.ObtenerOrden();      /*OC*/
                    cbo_orden.ValueMember = "id_factura_compra_pk";
                    cbo_orden.DisplayMember = "id_factura_compra_pk";
                }
                }
                else { MessageBox.Show("Debe seleccionar una ubicación (bodega) para todos los productos"); }
            //}
            //catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void RegistrarMovimiento( string orden, string empresa)
        {
            //try
            //{
                SistemaInventarioDatos sd = new SistemaInventarioDatos();
                char delimitador = '-';
                foreach (DataGridViewRow fila in dgw_entradas.Rows)
                {

                    if (fila.Cells["Codigo"].Value != null)
                    {
                        int cantidad = Convert.ToInt32(fila.Cells["Cant_recibida"].Value);

                        DataGridViewComboBoxCell CboBodega = fila.Cells["bodega"] as DataGridViewComboBoxCell;
                        string bodega = CboBodega.Value.ToString();

                        DataGridViewComboBoxCell CboBienes = fila.Cells["Descripcion"] as DataGridViewComboBoxCell;
                        string codigo = CboBienes.Value.ToString();

                        string[] codigo_separado = codigo.Split(delimitador);
                        string categoria = codigo_separado[0].Trim();
                        string id_bien = codigo_separado[1].Trim();
                        //-----------INSERTAR 
                        sd.RegistrarMovimientoInv("Compra",bodega,id_bien,categoria,cantidad,orden,"-","Orden de compra",empresa);

                    }



                }
            //}
            //catch (Exception ex){ MessageBox.Show(ex.Message); }

        }


        private void IngresarDetalleOrden(string id_orden, string empresa)
        {
            try
            {
                SistemaInventarioDatos sd = new SistemaInventarioDatos();
                char delimitador = '-';

                foreach (DataGridViewRow fila in dgw_entradas.Rows)
                {

                    if (fila.Cells["Codigo"].Value != null)
                    {
                        int cantidad = Convert.ToInt32(fila.Cells["Cant_recibida"].Value);

                        DataGridViewComboBoxCell CboBienes = fila.Cells["Descripcion"] as DataGridViewComboBoxCell;
                        string codigo = CboBienes.Value.ToString();

                        string[] codigo_separado = codigo.Split(delimitador);
                        string categoria = codigo_separado[0].Trim();
                        string id_bien = codigo_separado[1].Trim();
                        //-----------INSERTAR 
                        sd.InsertarDetalleDocInv(id_bien, cantidad, categoria, id_orden, empresa);

                    }



                }
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }


        public bool ValidarBodegaVacia()
        {
            foreach( DataGridViewRow fila in dgw_entradas.Rows)
            {
                if (fila.Index != dgw_entradas.Rows.Count-1)
                {
                    DataGridViewComboBoxCell CboBodega = fila.Cells["bodega"] as DataGridViewComboBoxCell;
                    if (CboBodega.Value == null)
                    {

                        return true;
                        break;
                    }
                }
            }
            return false;
        }





    }
}
