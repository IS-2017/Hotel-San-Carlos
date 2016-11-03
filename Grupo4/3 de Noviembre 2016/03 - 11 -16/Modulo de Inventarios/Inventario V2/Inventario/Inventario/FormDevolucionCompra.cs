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

namespace Inventario
{
    public partial class FormDevolucionCompra : Form
    {
        public FormDevolucionCompra()
        {
            InitializeComponent();
        }

        private void FormDevolucionCompra_Load(object sender, EventArgs e)
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

            dgw_requisicion.AutoGenerateColumns = false;


            cbo_compra.DataSource = sd.ObtenerOrdendev();      
            cbo_compra.ValueMember = "id_factura_compra_pk";
            cbo_compra.DisplayMember = "id_factura_compra_pk";

            cbo_prov.DataSource = sd.ObtenerProveedor();
            cbo_prov.ValueMember = "id_proveedor_pk";
            cbo_prov.DisplayMember = "nombre_proveedor";
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

           
            }
        }

        private void btn_crear_Click(object sender, EventArgs e)
        {
            SistemaInventarioDatos sd = new SistemaInventarioDatos();
            char delimitador = '-';
            string bodega = cbo_bodega.SelectedValue.ToString();

            bool y = ValidarExistenciaProd();
            

            if (y == true)
            {
                bool x = ValidarCantidadDelProducto();

                if (x== true)
                {
                    foreach (DataGridViewRow fila in dgw_requisicion.Rows)
                    {

                        if (fila.Cells["Codigo"].Value != null)
                        {
                            //------------OBTENER  CANTIDAD Y BIEN
                            int cantidad = Convert.ToInt32(fila.Cells["Cant_devuelta"].Value);

                            DataGridViewComboBoxCell CboBienes = fila.Cells["Descripcion"] as DataGridViewComboBoxCell;
                            string codigo = CboBienes.Value.ToString();

                            string[] codigo_separado = codigo.Split(delimitador);
                            string categoria = codigo_separado[0].Trim();
                            string id_bien = codigo_separado[1].Trim();
                           
                            int existencias = sd.ObtenerExistenciasEnBodega(id_bien, categoria, bodega);
                            int nueva_existencia = existencias - cantidad;
                            sd.ActualizarExistenciasEnBodega(id_bien, categoria, bodega, nueva_existencia);
                    
                        }
                    }
                    MessageBox.Show("devolucion procesada con exito");
                    //----INSERTAR ENCABEZADO
                    string encargado = txt_encargado.Text.Trim();
                    DateTime f = Convert.ToDateTime(dtp_fecha_dev.Value);
                    string fecha = f.ToString("yyyy-MM-dd");
                    string compra = cbo_compra.SelectedValue.ToString();
                    string proveedor = cbo_prov.SelectedValue.ToString();
                    
                    sd.InsertarDevCompra(encargado,fecha,bodega,compra,proveedor);
                    //--DETALLE
                    int id_dev = sd.ObtenerUltimaDevC();
                    InsertarDetalleDevolucion(id_dev);

                    //--INSERTAR DOC INV
                    sd.InsertarDocInvDin(id_dev.ToString(),"-","Devolucion sobre compra",fecha,"-","procesado",proveedor);
                    //--DETALLE DOC INV
                    InsertarDetalleDocInv(id_dev);

                    //--REGISTRAR MOV
                    RegistrarMovimiento(id_dev);
                   
                }
                else { MessageBox.Show("Hay menos existenicas de las que se quieren sacar de uno de los productos a devolver"); }

            }
            else { MessageBox.Show("Alguno de los productos de la devolucion no existe en la bodega indicada"); }



        }



        private void RegistrarMovimiento(int doc)
        {
            //try
            //{
            SistemaInventarioDatos sd = new SistemaInventarioDatos();
            char delimitador = '-';
            foreach (DataGridViewRow fila in dgw_requisicion.Rows)
            {

                if (fila.Cells["Codigo"].Value != null)
                {
                    int cantidad = Convert.ToInt32(fila.Cells["Cant_devuelta"].Value);

                    string bodega = cbo_bodega.SelectedValue.ToString();

                    DataGridViewComboBoxCell CboBienes = fila.Cells["Descripcion"] as DataGridViewComboBoxCell;
                    string codigo = CboBienes.Value.ToString();

                    string[] codigo_separado = codigo.Split(delimitador);
                    string categoria = codigo_separado[0].Trim();
                    string id_bien = codigo_separado[1].Trim();
                    string documento = doc.ToString();
                    //-----------INSERTAR 
                    sd.RegistrarMovimientoInvDev("Devolucion sobre compra", bodega, id_bien, categoria, cantidad, documento, "-", "Devolucion sobre compra", "-");

                }



            }
            //}
            //catch (Exception ex){ MessageBox.Show(ex.Message); }

        }

        private void InsertarDetalleDocInv(int id_dev)
        {
            SistemaInventarioDatos sd = new SistemaInventarioDatos();
            foreach (DataGridViewRow fila in dgw_requisicion.Rows)
            {

                if (fila.Cells["Codigo"].Value != null)
                {
                    //------------OBTENER  CANTIDAD Y BIEN
                    int cantidad = Convert.ToInt32(fila.Cells["Cant_devuelta"].Value);

                    DataGridViewComboBoxCell CboBienes = fila.Cells["Descripcion"] as DataGridViewComboBoxCell;
                    string codigo = CboBienes.Value.ToString();

                    string[] codigo_separado = codigo.Split('-');
                    string categoria = codigo_separado[0].Trim();
                    string id_bien = codigo_separado[1].Trim();


                    sd.InsertarDetalleDocInvDin(id_bien,cantidad,categoria,id_dev.ToString(),"-","Devolucion sobre compra","-");

                }
            }
        }

        private void InsertarDetalleDevolucion(int id_dev)
        {
            SistemaInventarioDatos sd = new SistemaInventarioDatos();
            foreach (DataGridViewRow fila in dgw_requisicion.Rows)
            {

                if (fila.Cells["Codigo"].Value != null)
                {
                    //------------OBTENER  CANTIDAD Y BIEN
                    int cantidad = Convert.ToInt32(fila.Cells["Cant_devuelta"].Value);

                    DataGridViewComboBoxCell CboBienes = fila.Cells["Descripcion"] as DataGridViewComboBoxCell;
                    string codigo = CboBienes.Value.ToString();

                    string[] codigo_separado = codigo.Split('-');
                    string categoria = codigo_separado[0].Trim();
                    string id_bien = codigo_separado[1].Trim();
                    string observaciones = fila.Cells["Observaciones"].Value.ToString();

                    sd.InsertarDetalleDevC(cantidad, observaciones,id_bien, categoria, id_dev);

                }
            }


        }



        private bool ValidarExistenciaProd()
        {
            string bodega = cbo_bodega.SelectedValue.ToString();
            SistemaInventarioDatos sd = new SistemaInventarioDatos();
            bool existente = true;

            foreach (DataGridViewRow fila in dgw_requisicion.Rows)
            {

                if (fila.Cells["Codigo"].Value != null)
                {

                    DataGridViewComboBoxCell CboBienes = fila.Cells["Descripcion"] as DataGridViewComboBoxCell;
                    string codigo = CboBienes.Value.ToString();

                    string[] codigo_separado = codigo.Split('-');
                    string categoria = codigo_separado[0].Trim();
                    string id_bien = codigo_separado[1].Trim();
                    //-----------VALIDAR SI YA EXISTE LA TUPLA
                    int y = sd.ValidarExistenciaDeProducto(id_bien, categoria, bodega);
                    if (y == 0)
                    {
                        existente = false;
                    }
                }
            }
            return existente;
        }


        private bool ValidarCantidadDelProducto()
        {
            string bodega = cbo_bodega.SelectedValue.ToString();
            SistemaInventarioDatos sd = new SistemaInventarioDatos();
            bool hay = true;

            foreach (DataGridViewRow fila in dgw_requisicion.Rows)
            {

                if (fila.Cells["Codigo"].Value != null)
                {
                    //------------OBTENER  CANTIDAD Y BIEN
                    int cantidad = Convert.ToInt32(fila.Cells["Cant_devuelta"].Value);

                    DataGridViewComboBoxCell CboBienes = fila.Cells["Descripcion"] as DataGridViewComboBoxCell;
                    string codigo = CboBienes.Value.ToString();

                    string[] codigo_separado = codigo.Split('-');
                    string categoria = codigo_separado[0].Trim();
                    string id_bien = codigo_separado[1].Trim();
              
                    int existencias = sd.ObtenerExistenciasEnBodega(id_bien, categoria, bodega);
                    int existencias_restantes = existencias - cantidad;
                  if(existencias_restantes < 0)
                    {
                        hay = false;
                    }

                }
            }
            return hay;
        }






    }
}
