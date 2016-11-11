//using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.Odbc;

namespace cuentas_corrientes
{

    public partial class frmPedidos : Form
    {
        int idcat;


        public frmPedidos()
        {
            // Llenado del Combox
            InitializeComponent();
            cbo_estado.Items.Add("Activo");
            cbo_estado.Items.Add("Inactivo");
        }
        #region Procedimientos

        private void pro_habilitaInputs()
        {
            /*METODO PARA HABILITAR TODOS LOS CAMPOS
             * Autor: Merlyn Franco
             * Fecha: 06/11/2016*/
            try
            {
                cbo_empre.Enabled = true;
                cbo_vendedor.Enabled = true;
                txt_cliente.Enabled = true;
                btn_Buscte.Enabled = true;
                dtg_fecha.Enabled = true;
                txt_producto.Enabled = false;
                btn_buscPro.Enabled = true;
                txt_cantidad.Enabled = false;
                txt_precio.Enabled = false;
                cbo_estado.Enabled = true;



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.ToString());
            }
        }

        private void pro_deshabilitaInputs()
        {
            /*METODO PARA HABILITAR TODOS LOS CAMPOS
             * Autor: Merlyn Franco
             * Fecha: 06/11/2016*/
            try
            {
                cbo_empre.Enabled = false;
                cbo_vendedor.Enabled = false;
                txt_cliente.Enabled = false;
                btn_Buscte.Enabled = false;
                dtg_fecha.Enabled = false;
                txt_producto.Enabled = false;
                btn_buscPro.Enabled = false;
                txt_cantidad.Enabled = false;
                txt_precio.Enabled = false;
                cbo_estado.Enabled = false;



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.ToString());
            }
        }

        private void pro_limpiaInputs()
        {
            /*METODO PARA LIMPIAR VALORES DE TODOS LOS CAMPOS
             * Autor: Merlyn Franco
             * Fecha: 06/11/2016*/
            try
            {
                cbo_empre.Text = string.Empty;
                cbo_vendedor.Text = string.Empty;
                txt_Idcliente.Text = string.Empty;
                txt_cliente.Text = string.Empty;
                dtg_fecha.Text = string.Empty;
                txt_idprod.Text = string.Empty;
                txt_producto.Text = string.Empty;
                txt_cantidad.Text = string.Empty;
                txt_idprecio.Text = string.Empty;
                txt_precio.Text = string.Empty;
                dgv_detallepedido.DataSource = string.Empty;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.ToString());
            }
        }

        private void pro_limpiaInputsDetalle()
        {
            /*METODO PARA LIMPIAR VALORES DE TODOS LOS CAMPOS
             * Autor: Merlyn Franco
             * Fecha: 06/11/2016*/
            try
            {
                txt_idprod.Text = string.Empty;
                txt_producto.Text = string.Empty;
                txt_cantidad.Text = string.Empty;
                txt_idprecio.Text = string.Empty;
                txt_precio.Text = string.Empty;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.ToString());
            }
        }

        #endregion

        public cls_cliente cldes { get; set; }
        private void btn_Buscte_Click(object sender, EventArgs e)
        {
            try
            {
                frmBuscarClientePedido buscl = new frmBuscarClientePedido();
                buscl.ShowDialog();


                if (buscl.descl != null)
                {
                    cldes = buscl.descl;
                    txt_Idcliente.Text = Convert.ToString(buscl.descl.cod);
                    txt_cliente.Text = buscl.descl.nombre + " " + buscl.descl.apellido;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cbo_empre_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbo_vendedor.Items.Clear();

            OdbcConnection conectar3 = seguridad.Conexion.ObtenerConexionODBC(); 
            clsComun emp = new clsComun();
            OdbcCommand _comando = new OdbcCommand(String.Format(
                 "SELECT id_empresa_pk FROM empresa where nombre ='{0}' ", cbo_empre.Text), conectar3);
            OdbcDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {

                emp.cod = _reader.GetInt16(0);
            }


            conectar3.Close();
            OdbcConnection conectar4 = seguridad.Conexion.ObtenerConexionODBC();

            OdbcCommand _mcd2 = new OdbcCommand(String.Format("select * from empleado  where cargo='vendedor' and id_empresa_pk ='{0}' ", emp.cod), conectar4);

            OdbcDataReader mdr2 = _mcd2.ExecuteReader();
            while (mdr2.Read())
            {
                cbo_vendedor.Items.Add(mdr2.GetString(1));
            }


            conectar4.Close();
        }

        private void frmPedidos_Load(object sender, EventArgs e)

        {
            //DESHABILITA BOTONES INECESARIOS

            btn_nuevo.Enabled = true;
            btn_guardar.Enabled = false;
            btn_editar.Enabled = false;
            btn_actualizar.Enabled = false;
            btn_eliminar.Enabled = false;
            btn_cancelar.Enabled = false;
            btn_buscar.Enabled = false;

            //Deshabilita lo campos necesarios
            pro_deshabilitaInputs();

            OdbcConnection conectar2 = seguridad.Conexion.ObtenerConexionODBC();


            string scad1 = "select * from empresa";
            OdbcCommand mcd1 = new OdbcCommand(scad1, conectar2);
            OdbcDataReader mdr1 = mcd1.ExecuteReader();
            while (mdr1.Read())
            {
                cbo_empre.Items.Add(mdr1.GetString(1));
            }
            conectar2.Close();
        }

        public cls_Producto clspedi { get; set; }
        private void button1_Click(object sender, EventArgs e)

        {
            txt_producto.Enabled = true;
            txt_cantidad.Enabled = true;
            txt_precio.Enabled = true;

            try
            {


                frmBuscarProductoPedido buscl = new frmBuscarProductoPedido();
                buscl.ShowDialog();


                if (buscl.busq != null)
                {
                    clspedi = buscl.busq;

                    txt_idprod.Text = Convert.ToString(buscl.busq.id_bien_pk);
                    txt_producto.Text = buscl.busq.descripcion;
                    txt_idprecio.Text = Convert.ToString(buscl.busq.id_precio);
                    txt_precio.Text = Convert.ToString(buscl.busq.precio);
                    idcat = Convert.ToInt16(buscl.busq.id_categoria_pk);



                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btn_Agregar_Click(object sender, EventArgs e)

        {
            if (string.IsNullOrWhiteSpace(txt_cantidad.Text))
            {

                MessageBox.Show("Campo obligatorio vacío", "Campo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {


                string bien, descrip, idprecio;

                decimal cantidad, precio, subtot;

                bien = txt_idprod.Text;
                cantidad = Convert.ToDecimal(txt_cantidad.Text);
                descrip = txt_producto.Text;
                precio = Convert.ToDecimal(txt_precio.Text);
                subtot = cantidad * precio;
                idprecio = txt_idprecio.Text;

                dgv_detallepedido.Rows.Add(bien, cantidad, descrip, precio, subtot, idprecio);

                pro_limpiaInputsDetalle();

                txt_producto.Enabled = false;
                txt_cantidad.Enabled = false;
                txt_precio.Enabled = false;

                //DESHABILITA BOTONES INECESARIOS

                btn_nuevo.Enabled = true;
                btn_guardar.Enabled = true;
                btn_editar.Enabled = true;
                btn_actualizar.Enabled = true;
                btn_eliminar.Enabled = true;
                btn_cancelar.Enabled = true;
                btn_buscar.Enabled = true;

            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbo_empre.Text) || string.IsNullOrWhiteSpace(cbo_vendedor.Text))
                MessageBox.Show("Ingrese la Cantidad del Producto", "Campo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {

                ClsPedido pedi = new ClsPedido();

                //Obteniendo Id de empresa
                OdbcConnection conectar = seguridad.Conexion.ObtenerConexionODBC();
                // clsComun emp = new clsComun();
                OdbcCommand _comando = new OdbcCommand(String.Format(
               "SELECT id_empresa_pk FROM empresa where nombre ='{0}' ", cbo_empre.Text), conectar);
                OdbcDataReader _reader = _comando.ExecuteReader();
                while (_reader.Read())
                {

                    pedi.codemp = _reader.GetInt16(0); //Id empresa
                }
                conectar.Close();



                //Obteniendo Id de vendedor
                OdbcConnection conectar1 = seguridad.Conexion.ObtenerConexionODBC();
                //   clsComun vend = new clsComun();
                OdbcCommand _comando1 = new OdbcCommand(String.Format(
                     "SELECT id_empleados_pk FROM empleado where nombre ='{0}' ", cbo_vendedor.Text), conectar1);
                OdbcDataReader _reader1 = _comando1.ExecuteReader();
                while (_reader1.Read())
                {

                    pedi.codvende = _reader1.GetInt16(0); //Id vendedor
                }
                conectar1.Close();

                pedi.codemp = pedi.codemp;
                pedi.fec_pedido = Convert.ToDateTime(dtg_fecha.Text);
                pedi.estado = cbo_estado.Text;
                pedi.codcte = Convert.ToInt16(txt_Idcliente.Text);
                pedi.codvende = pedi.codvende;




                int iresultado = ClsOpPedi.AgregarPedido(pedi); //Enviando a facturar encabezado

                if (iresultado > 0)
                {
                    MessageBox.Show("Encabezado de Pedido guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Insertando en detalle de factura 
                    int filas = dgv_detallepedido.RowCount;


                    //Obteniendo el ultimo Id de insertar, para insertar detalle_Fact
                    OdbcConnection conectar3 = seguridad.Conexion.ObtenerConexionODBC();
                    //clsComun imp3 = new clsComun();
                    ClsPedido pd = new ClsPedido();
                    OdbcCommand _comando3 = new OdbcCommand(String.Format(
                         "SELECT MAX(id_pedido_pk) from pedido "), conectar3);
                    OdbcDataReader _reader3 = _comando3.ExecuteReader();
                    while (_reader3.Read())
                    {

                        pedi.codped = _reader3.GetInt16(0); //Id impuestp
                    }
                    conectar3.Close();

                    //Codigo para recorrer grid e insertar a detalle factura

                    for (int f = 0; f < filas - 1; f++)
                    {

                        ClsDetallePedido depedi = new ClsDetallePedido();

                        depedi.idemple = pedi.codvende;
                        depedi.idpedi = pedi.codped;
                        depedi.idbien = Convert.ToInt16(dgv_detallepedido.Rows[f].Cells[0].Value);
                        depedi.cantidad = Convert.ToInt16(dgv_detallepedido.Rows[f].Cells[1].Value);
                        depedi.descripcion = Convert.ToString(dgv_detallepedido.Rows[f].Cells[2].Value);
                        depedi.prec = Convert.ToDecimal(dgv_detallepedido.Rows[f].Cells[3].Value);
                        depedi.subtotal = Convert.ToDecimal(dgv_detallepedido.Rows[f].Cells[4].Value);
                        depedi.idprecio = Convert.ToInt16(dgv_detallepedido.Rows[f].Cells[5].Value);
                        depedi.idcat = idcat;
                        depedi.estado = pedi.estado;

                        //Debug.WriteLine("------"+depedi);
                        // MessageBox.Show("Errores"+depedi);

                        int iresultado1 = ClsOpPedi.AgregarDetPedido(depedi);

                        if (iresultado1 > 0)
                        {
                            MessageBox.Show("Detalle insertado correctamente");



                        }
                        else
                        {
                            MessageBox.Show("No se inserto detalle");
                        }


                    }
                }

                else
                {
                    MessageBox.Show("No se pudo guardar el encabezado de factura", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            //DESHABILITA BOTONES INECESARIOS

            btn_nuevo.Enabled = true;
            btn_guardar.Enabled = false;
            btn_editar.Enabled = false;
            btn_actualizar.Enabled = true;
            btn_eliminar.Enabled = false;
            btn_cancelar.Enabled = true;
            btn_buscar.Enabled = true;

            //HAbilita los textbox
            pro_habilitaInputs();


        }

        private void dgv_detallepedido_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            /*EVENTO DESENCADENADO EN CLICK DEL BOTON CANCELAR
             * Autor: Merlyn Franco
             * Fecha: 06/11/2016*/

            //LIMPIA INFORMACIÓN DE CAMPOS
            pro_limpiaInputs();

            //DESHABILITA LOS CAMPOS
            pro_deshabilitaInputs();

            //DESHABILITA BOTONES INECESARIOS
            btn_guardar.Enabled = false;
            btn_actualizar.Enabled = false;
            btn_eliminar.Enabled = false;
            btn_cancelar.Enabled = false;
        }
       
        private void btn_editar_Click(object sender, EventArgs e)
        {
 
            
        }

    }
 
}
