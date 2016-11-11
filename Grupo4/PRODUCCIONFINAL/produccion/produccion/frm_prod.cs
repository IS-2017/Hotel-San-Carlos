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

namespace produccion
{
    public partial class frm_prod : Form
    {
        produccionOP produccion = new produccionOP();
        pedido pedido = new pedido();
        String llave = "";
        string correlativo = "";
        int cantidad_total = 0;
        String valor_combo = "";
        String horas_total = "";

        double total_materia_prima = 0;
        string controlador = "";

        // crystal report
        private int? idbusqueda = null;
        // crystal report

        public frm_prod()
        {
            InitializeComponent();
        }
        String opcioncategoria = "";
        // cargar el combobox con todos los pedidos
        private void frm_prod_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = pedido.Carga_datos(seguridad.Conexion.User);
                if (dt.Rows.Count != 0)
                {
                    cmb_emp.DataSource = dt;
                    cmb_colab.DataSource = dt;
                    cmb_colab.DisplayMember = "nombre_colab";
                    cmb_colab.ValueMember = "id_empleado";
                    cmb_emp.ValueMember = "id_empresa";
                    cmb_emp.DisplayMember = "nombre_emp";


                }
                else
                {
                    cmb_colab.SelectedIndex = -1;
                    cmb_emp.SelectedIndex = -1;
                }
                timer1.Start();

                pedido pdo = new pedido();
                //CapaDatos cd = new CapaDatos();
               DataTable dt2 = pdo.carga_pedidos();
                cmb_pedido.DataSource = dt2;
                cmb_pedido.DisplayMember = "id_encabezado_pedido_pk";
                cmb_pedido.ValueMember = "id_encabezado_pedido_pk";
                comboBox1.DataSource = dt2;
                comboBox1.ValueMember = "id_encabezado_pedido_pk";


                // -------------------------------------- AREA DE TRABAJO PARA REQUISICION: ---------------------------
                // Carga de combobox Clasificacion
                CapaDatos cdcat = new CapaDatos();
                DataTable dtcat = cdcat.CargarDatosBienClasificacion();



                cmb_categoria.DataSource = dtcat;
                cmb_categoria.DisplayMember = "nombre_linea";
                cmb_categoria.ValueMember = "id_linea_pk";

                // Carga de combobox Medida
                DataTable medida = cdcat.CargarDatosMedida();

                cmb_medida.DataSource = medida;
                cmb_medida.DisplayMember = "nombre_medida";
                cmb_medida.ValueMember = "id_medida_pk";

                //--------------------cargando pedidos en proceso
                try
                {
                    produccionOP prod = new produccionOP();
                    DataTable dt4 = new DataTable();
                    dt4 = prod.carga_pedidos();
                    cmb_pedido2.DataSource = dt4;
                    cmb_pedido2.DisplayMember = "id_encabezado_pedido_pk";
                    cmb_pedido2.ValueMember = "id_encabezado_pedido_pk";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }






        private void tabPage2_Click(object sender, EventArgs e)
        {
           
        }

        // boton recorrer datagridview del detalle de pedido y mandar como resultado un nuevo detalle de materia prima a utilizarse
        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            int contador2 = 0;
            while (contador2 < dgv_pedido.RowCount - 1)
            {


                llave = dgv_pedido.Rows[contador2].Cells["id_menu_pk"].Value.ToString();
                correlativo = dgv_pedido.Rows[contador2].Cells["correlativo"].Value.ToString();

                CapaDatos cd = new CapaDatos();
                DataTable dt = cd.ConsultarMateriaPrimaSegunPedido(llave, correlativo);


                // recorre el datatable para ingresar detalle de materia prima a utilizarse segun detalle de pedido
                foreach (DataRow row in dt.Rows)
                {


                    cantidad_total = 0;
                    int contador = 0;
                    string cantidad_pedido = dgv_pedido.Rows[contador].Cells["cantidad"].Value.ToString();
                    //string cantidad_pedido = row["cantidad"].ToString();

                    string cantidad_mp = row[3].ToString();

                    cantidad_total = Convert.ToInt32(cantidad_pedido) * Convert.ToInt32(cantidad_mp);

                    //                      nombre de menu,     receta,             cantidad,                    medida,            id_bien,            descripcion,     id_menu           correlativo          id_bien
                    //dgv_detalle_mp.Rows.Add(row[0].ToString(), row[1].ToString(), cantidad_total.ToString(), row[4].ToString(), row[2].ToString(), row[5].ToString(), row[6].ToString(), row[7].ToString(), row["id_bien_pk"].ToString());
                    dgv_detalle_mp.Rows.Add(row["nombre"].ToString(), row["nombre_receta"].ToString(), cantidad_total.ToString(), row["nombre_medida"].ToString(), row["descripcion"].ToString(), row["id_menu_pk"].ToString(), row["correlativo"].ToString(), row["id_bien_pk"].ToString(), row["existencia"].ToString());
                    contador += 1;
                }



                //MessageBox.Show(llave);
                contador2 += 1;
            }
            // ------------------------- COSTO Y HORAS HOMBRE SUMATORIA
            double costo = 0;
            double hrs_hombre = 0;


            foreach (DataGridViewRow columna in dgv_pedido.Rows)
            {
                costo += Convert.ToDouble(columna.Cells["costo_receta"].Value);
                hrs_hombre += Convert.ToDouble(columna.Cells["horas_hombre"].Value) * Convert.ToDouble(columna.Cells["cantidad"].Value);

            }

            lbl_costo_total.Text = costo.ToString();
            lbl_hrs_hombre_total.Text = hrs_hombre.ToString();


            // ----------------- INSERTAR EN TABLA ASIGNACION_MP
            DataTable dtmanual = new DataTable();
            //dtmanual.Columns.Add("id_encabezado", typeof(string));
            dtmanual.Columns.Add("cant_mp", typeof(string));
            dtmanual.Columns.Add("id_menu", typeof(string));
            dtmanual.Columns.Add("correlativo", typeof(string));
            dtmanual.Columns.Add("bien", typeof(string));
            //dtmanual.Columns.Add("cant_hh", typeof(string));

            // inserción de datagridview en datatable
            foreach (DataGridViewRow dgv in dgv_detalle_mp.Rows)
            {
                //                                 id_encabezado,        cantidad_mp,     id_menu,             correlativo,      id_bien,                  cant_hh
                dtmanual.Rows.Add(dgv.Cells[2].Value, dgv.Cells[5].Value, dgv.Cells[6].Value, dgv.Cells[7].Value);

                // DETERMINAR SI HAY SUFICIENTE MATERIA PRIMA EN BODEGA:
                string descripcion = "";
                total_materia_prima = Convert.ToDouble(dgv.Cells["existencia"].Value) - Convert.ToDouble(dgv.Cells["cantidad"].Value);


                if (total_materia_prima > 0)
                {
                    descripcion = dgv.Cells["descripcion"].Value.ToString();
                    //MessageBox.Show(descripcion + " " + total_materia_prima);
                }
                else if (total_materia_prima < 0)
                {
                    //MessageBox.Show("no hay materia prima");
                    controlador = "requisicion";
                }

            }


            

            // ciclo que inserta todos los recorridos dentro del datatable en la base de datos
            if (controlador != "requisicion")
            {
                foreach (DataRow row in dtmanual.Rows)
                {
                    valor_combo = cmb_pedido.SelectedValue.ToString();
                    horas_total = lbl_hrs_hombre_total.Text;

                    if (row[0].ToString() != "" || row[1].ToString() != "" || row[2].ToString() != "" || row[3].ToString() != "")
                    {
                        OdbcConnection con2 = seguridad.Conexion.ObtenerConexionODBC();
                        string query = "insert into asignacion_mp (id_encabezado_pedido_pk,cant_mp,id_menu_pk,correlativo,id_bien_pk,cant_hh)values('" +
                        valor_combo + "','" + row["cant_mp"].ToString() + "','" + row["id_menu"].ToString() + "','" + row["correlativo"].ToString() + "',' " + row["bien"].ToString() + "','" + horas_total + "')";
                        //total_materia_prima
                        OdbcCommand comando = new OdbcCommand(query, con2);
                        comando.ExecuteNonQuery();
                        con2.Close();
                    }

                }
                CapaDatos cd = new CapaDatos();
                cd.ActualizarEstadoEncabezadoPedido(cmb_pedido.SelectedValue.ToString());
                MessageBox.Show(cmb_pedido.SelectedValue.ToString());
                lbl_tot_mat_prima.Text = total_materia_prima.ToString();
                MessageBox.Show("Materia prima asignada exitosamente");
                // aqui va el cambio de estado del pedido
               

                cargar_mo_det();
            }
            else if (controlador == "requisicion")
            {

                MessageBox.Show("Debe realizar una requisicion de materia prima");

            }

            try
            {
                produccionOP produccion = new produccionOP();
                DataTable dt = new DataTable();
                dt = produccion.carga_pedidos();
                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "id_encabezado_pedido_pk";
                comboBox1.ValueMember = "id_encabezado_pedido_pk";
            }
            catch
            {
            }
                    

        }





        // gridview con todo el cuerpo del pedido
        private void cmb_pedido_SelectedIndexChanged(object sender, EventArgs e)
        {
            CapaDatos cd = new CapaDatos();
            DataTable dt = cd.ConsultarPedidoDetalle(cmb_pedido.SelectedValue.ToString());
            //MessageBox.Show(cmb_pedido.SelectedValue.ToString());

            dgv_pedido.DataSource = dt;
            dgv_pedido.Columns["id_menu_pk"].Visible = false;
            dgv_pedido.Columns["orden"].Visible = false;
            dgv_pedido.Columns["correlativo"].Visible = false;
        }

        private void dgv_pedido_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            double costo = 0;
            double hrs_hombre = 0;

            foreach (DataGridViewRow columna in dgv_pedido.Rows)
            {
                costo += Convert.ToDouble(columna.Cells["costo_receta"].Value);
                hrs_hombre += Convert.ToDouble(columna.Cells["horas_hombre"].Value) * Convert.ToDouble(columna.Cells["cantidad"].Value);
            }

            lbl_costo_total.Text = costo.ToString();
            lbl_hrs_hombre_total.Text = hrs_hombre.ToString();
        }

        // boton de cancelar para limpiar ambos datagridview
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            //dgv_detalle_mp.DataSource =  ;

            //dgv_pedido.DataSource = "";
            dgv_detalle_mp.Rows.Clear();
            dgv_pedido.DataSource = "";
            controlador = "";
            lbl_costo_total.Text = "";
            lbl_hrs_hombre_total.Text = "";
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            
        }
        public void cargar_mo_det()
        {
            //txt_pedido.Text = cmb_pedido.SelectedValue.ToString();
            txt_pedido.Text = comboBox1.SelectedValue.ToString();
            txt_hh.Text = produccion.carga_hh(txt_pedido.Text.Trim());
            try
            {
                DataTable dt = new DataTable();
                dt = pedido.carga_dped(comboBox1.SelectedValue.ToString());
                if (dt.Rows.Count != 0)
                {
                    DataRow row = dt.Rows[0];
                    DateTime fecha = Convert.ToDateTime(row["fecha"].ToString());
                    txt_fechae.Text = fecha.ToString("dd/MM/yyyy");
                }

            }
            catch
            {
                MessageBox.Show("Error en carga de datos", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                DataTable dt = new DataTable();
                dt = produccion.cargar_rrhh();
                if (dt.Rows.Count != 0)
                {
                    dgv_personal.DataSource = dt;
                }
                else
                    MessageBox.Show("No se tienen datos", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //dgv_personal.Columns["disponibilidad"].Visible = false;
                //dgv_personal.Columns["Empresa"].Visible = false;

            }
            catch
            {
                MessageBox.Show("Error en carga de trabajadores", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_movright_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargar_mo_det();
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            cargar_mo_det();
            dgv_personal.Enabled = true;
        }

        private void dgv_personal_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                double hh_req = Convert.ToDouble(txt_hh.Text);
                double actual = 0.00;
                double hh = 0.00;
                foreach (DataGridViewRow row in dgv_personal.Rows)
                {
                    hh += Convert.ToDouble(row.Cells[0].Value);
                }
                actual = hh_req - hh;
                if (actual > 0)
                {
                    double horas_laborales = Convert.ToDouble(dgv_personal.Rows[dgv_personal.CurrentRow.Index].Cells[6].Value);
                    double horas_asignadas = Convert.ToDouble(dgv_personal.Rows[dgv_personal.CurrentRow.Index].Cells[0].Value);
                    double horas_disponibles = Convert.ToDouble(dgv_personal.Rows[dgv_personal.CurrentRow.Index].Cells[8].Value);
                    if (horas_asignadas > horas_laborales)
                    {
                        horas_asignadas = 0.00;
                        dgv_personal.Rows[dgv_personal.CurrentRow.Index].Cells[0].Value = "0.00";
                        
                        MessageBox.Show("No tiene horas disponibles", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (horas_asignadas > hh_req)
                    {
                        dgv_personal.Rows[dgv_personal.CurrentRow.Index].Cells[0].Value = "0.00";
                        
                        MessageBox.Show("No tiene horas disponibles", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (horas_asignadas > (hh_req - actual))
                    {
                        dgv_personal.Rows[dgv_personal.CurrentRow.Index].Cells[0].Value = "0.00";
                        

                    }
                    else if (horas_asignadas > horas_disponibles)
                    {
                        horas_asignadas = 0.00;
                        dgv_personal.Rows[dgv_personal.CurrentRow.Index].Cells[0].Value = "0.00";
                        
                        MessageBox.Show("No tiene horas disponibles", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        txt_hh.Text = hh_req.ToString();
                        label10.Text = Convert.ToString(hh_req - hh);
                    }
                }
                else
                {

                    
                    MessageBox.Show("Cantidad de horas es suficiente", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    label10.Text = Convert.ToString(hh_req - hh);
                    dgv_personal.Enabled = false;

                }
            }
            catch
            {
                MessageBox.Show("Error en los datos de asignación", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            
        }

        private void dgv_personal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                // ---------- insertar encabezado --------------
                CapaDatos cd = new CapaDatos();
                string usuario = seguridad.Conexion.User;
                cd.InsertarEncabezadoRequisicion(usuario);


                //-------------- llamar correlativo de encabezado
                DataTable dtuvalor = cd.ConsultarUltimoValorRequisicion();
                DataRow fila = dtuvalor.Rows[0];
                String ultimovalor = fila["max(id_requisicion_pk)"].ToString();
                //MessageBox.Show(ultimovalor);


                // ------------- insertar detalle
                DataTable dt = new DataTable();
                dt.Columns.Add("categoria", typeof(string));
                dt.Columns.Add("materia_prima", typeof(string));
                dt.Columns.Add("cantidad", typeof(string));
                dt.Columns.Add("medida", typeof(string));


                foreach (DataGridViewRow dgv in dgv_cuerpo_formula_ID.Rows)
                {
                    dt.Rows.Add(dgv.Cells[0].Value, dgv.Cells[1].Value, dgv.Cells[2].Value, dgv.Cells[3].Value);


                }

                foreach (DataRow row in dt.Rows)
                {

                    if (row[0].ToString() != "" || row[1].ToString() != "" || row[2].ToString() != "" || row[3].ToString() != "")
                    {
                        OdbcConnection con2 = seguridad.Conexion.ObtenerConexionODBC();
                        string query = "insert into detalle_requisicion (cantidad,id_bien_pk,id_categoria_pk,id_requisicion_pk,medida) values ('" + row["cantidad"].ToString() + "','" + row["materia_prima"].ToString() + "','" + row["categoria"].ToString() + "','" + ultimovalor + "','" + row["medida"].ToString() + "');";
                        OdbcCommand comando = new OdbcCommand(query, con2);
                        comando.ExecuteNonQuery();
                        con2.Close();
                    }

                }


                MessageBox.Show("Requisición agregada exitosamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmb_categoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // carga de materia prima segun categoria
                CapaDatos cd = new CapaDatos();
                opcioncategoria = cmb_categoria.SelectedValue.ToString();

                DataTable dt = cd.CargaDatosBien(opcioncategoria);

                cmb_materia_prima.DataSource = dt;
                cmb_materia_prima.DisplayMember = "descripcion";
                cmb_materia_prima.ValueMember = "id_bien_pk";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_categoria.Text == "" || cmb_materia_prima.Text == "" || cmb_medida.Text == "" || txt_cantidad.Text == "")
                {
                    MessageBox.Show("uno o mas campos estan vacios");
                }
                else
                {

                    // Datagrid a nivel de usuario
                    dgv_cuerpo_formula.Rows.Add(cmb_categoria.Text, cmb_materia_prima.Text, txt_cantidad.Text, cmb_medida.Text);

                    // Datagrid a nivel base de datos
                    dgv_cuerpo_formula_ID.Rows.Add("mp", cmb_materia_prima.SelectedValue.ToString(), txt_cantidad.Text, cmb_medida.SelectedValue.ToString());

                    // limpiar campos
                    cmb_categoria.Text = "";
                    cmb_materia_prima.Text = "";
                    cmb_medida.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // quitar una fila de datagridview
        private void btn_quitar_Click(object sender, EventArgs e)
        {
            try
            {
                int x = dgv_cuerpo_formula.CurrentRow.Index;
                //DataGridViewRow row = dgv_cuerpo_formula_ID.Rows[x];

                dgv_cuerpo_formula.Rows.RemoveAt(dgv_cuerpo_formula.CurrentRow.Index);
                dgv_cuerpo_formula_ID.Rows.RemoveAt(x);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        // nueva requisicion
        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            dgv_cuerpo_formula.Rows.Clear();
            dgv_cuerpo_formula_ID.Rows.Clear();
        }

        // nuevo
        private void button1_Click(object sender, EventArgs e)
        {
            dgv_detalle_mp.Rows.Clear();
            dgv_pedido.DataSource = "";
            controlador = "";
            lbl_costo_total.Text = "";
            lbl_hrs_hombre_total.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        // refresh
        private void button5_Click(object sender, EventArgs e)
        {
            pedido pdo = new pedido();
            //CapaDatos cd = new CapaDatos();
            DataTable dt = pdo.carga_pedidos();
            cmb_pedido.DataSource = dt;
            cmb_pedido.DisplayMember = "id_encabezado_pedido_pk";
            cmb_pedido.ValueMember = "id_encabezado_pedido_pk";
        }

        // reporte
        private void button13_Click(object sender, EventArgs e)
        {
            frm_reporte_requisicion frm = new frm_reporte_requisicion();
            frm.dgv_cen = dgv_cuerpo_formula;
            frm.Show();
            //DataSet ds = new DataSet();

            //DataTable dt = new DataTable();
            //dt.Columns.Add("categoria", typeof(string));
            //dt.Columns.Add("materia_prima", typeof(string));
            //dt.Columns.Add("cantidad", typeof(string));
            //dt.Columns.Add("medida", typeof(string));

            //foreach (DataGridViewRow dgv in dgv_cuerpo_formula.Rows)
            //{

            //    dt.Rows.Add(dgv.Cells[0].Value, dgv.Cells[1].Value,dgv.Cells[2].Value,dgv.Cells[3].Value);
            //}

            //ds.Tables.Add(dt);
            //ds.WriteXmlSchema("requisicion.xml");
             
            //Produccion.ReporteRequisicion cr = new Produccion.ReporteRequisicion();
            //cr.SetDataSource(ds);
            //crystalReportViewer1.ReportSource = cr;
            

        }
        // prueba
        private void button14_Click(object sender, EventArgs e)
        {
            //string parametro = "lptm";
            //produccion.ReporteRequisicion frm = new produccion.ReporteRequisicion();
            
            
        }

        private void button19_Click(object sender, EventArgs e)
        {
            produccionOP produccion = new produccionOP();
            int conteo = 1;
            if (dgv_personal.Rows.Count <= 1)
            {
                MessageBox.Show("Debe ingresar datos al pedido", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
            else
            {
                try
                {
                    foreach (DataGridViewRow row in dgv_personal.Rows)
                    {
                        if (conteo < dgv_personal.Rows.Count)
                        {
                            if (Convert.ToString(row.Cells[0].Value) != null || Convert.ToInt16(row.Cells[0].Value) != 0)
                            {
                                DateTime fecha_e = Convert.ToDateTime(dateTimePicker1.Value);
                                string colab = Convert.ToString(row.Cells[2].Value);
                                string empresa = Convert.ToString(row.Cells[1].Value);
                                decimal costo = Convert.ToDecimal(row.Cells[5].Value) * Convert.ToDecimal(row.Cells[0].Value);
                                string cant_horas = Convert.ToString(row.Cells[0].Value);
                                int resultado = produccion.inserta_mo(comboBox1.SelectedValue.ToString(), colab, empresa, fecha_e.ToString("yyyy-MM-dd"), costo, cant_horas);
                            }
                        }
                        else {
                            MessageBox.Show("No se asignó personal al pedido", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Error en la asignación de mano de obra", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                }
                
            }
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();
            txt_fecha.Text = DateTime.Now.ToString("yyyy-MM-dd");
            txt_hora.Text = DateTime.Now.ToString("HH:mm:ss");

        }

        private void cmb_pedido2_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                produccionOP produccion = new produccionOP();
                txt_costomp.Text = produccion.carga_mp(Convert.ToString(cmb_pedido2.SelectedValue));
            }
            catch
            { }
            try
            {
                
                DataTable dt = new DataTable();
                dt = produccion.carga_detalle_pedido2(cmb_pedido2.SelectedValue.ToString());
                dgv_pedido2.DataSource = dt;
                
            }
            catch
            {
                MessageBox.Show("Error en carga de datos", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmb_pedido2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
       
    }
}
