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
using dllconsultas;
using Abrir;

namespace cuentas_corrientes
{
    public partial class frmcliente : Form
    {
        public frmcliente(cls_cliente imp)
        {
            InitializeComponent();
            try
            {

                if (imp != null)
                {

                    cldes = imp;
                    txt_nombre.Text = imp.nombre;
                    txt_apellido.Text = imp.apellido;
                    txt_dpi.Text = Convert.ToString(imp.dpi);
                    txt_nit.Text = imp.nit;
                    txt_direccion.Text = imp.dire;
                    txt_telefono.Text = imp.tel;
                    txt_correo.Text = imp.correo;
                    date_clte.Text = imp.fecha;
                    //cbo_contri.Text = imp.codcontri;
                    //cbo_credi.Text = imp.codcredi;
                    
                    MessageBox.Show("paso");
                }
                else
                {
                    txt_nombre.Text = "";
                    txt_apellido.Text = "";
                    txt_dpi.Text = "";
                    txt_nit.Text = "";
                    txt_direccion.Text = "";
                    txt_telefono.Text = "";
                    txt_correo.Text = "";
                    date_clte.Text = "";
                    cbo_contri.Text = "";
                    cbo_credi.Text = "";

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        public frmcliente(string snom, string sapel, string sdpi, string snit, string sdirec, string svend, string stel, string scor, string sfec, string stcred, string stcontri, string stcata)
        {
            InitializeComponent();
            //funLlenarComboActividad();
            txt_nombre.Text = snom;
            txt_apellido.Text = sapel;
            txt_dpi.Text = sdpi;
            txt_nit.Text = snit;
            txt_direccion.Text = sdirec;
            cbo_ven.Text = svend;
            txt_telefono.Text = stel;
            txt_correo.Text = scor;
            date_clte.Text = sfec;
            cbo_credi.Text = stcred;
            cbo_contri.Text = stcontri;
            cbo_catalogo.Text = stcata;            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_fecemi_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmFactura_Load(object sender, EventArgs e)
        {
            mostrar();
            //btn_del.Enabled = false;
            //btn_mod.Enabled = false;
            //button3.Enabled = false;
        }
        //public static int cd;
        public void mostrar()
        {
            OdbcConnection conexion = seguridad.Conexion.ObtenerConexionODBC();
            OdbcDataAdapter dausuario = new OdbcDataAdapter("SELECT * FROM cliente", conexion);
            DataSet dsuario = new DataSet();
            dausuario.Fill(dsuario, "cliente");
            //dgv_cliente.DataSource = dsuario;
            //dgv_cliente.DataMember = "cliente";

            /*string scad = "Select * from tipo_precio";
            //OdbcCommand mcd = new OdbcCommand(scad, seguridad.Conexion.ObtenerConexionODBC());
            //OdbcDataReader mdr = mcd.ExecuteReader();
            DataTable dt = new DataTable();
            OdbcCommand mcd = new OdbcCommand(scad, seguridad.Conexion.ObtenerConexionODBC());
            OdbcDataAdapter da = new OdbcDataAdapter(mcd);
            da.Fill(dt);
            if (dt.Rows.Count != 0)
            {
                cbo_credi.DataSource = dt;
                cbo_credi.DisplayMember = "tipo";
                cbo_credi.ValueMember = "id_tprecio_pk";

            }
            else
            {
                MessageBox.Show("Error al cargar datos");
            }

            /*while (mdr.Read())
            {

                cbo_catalogo.Items.Add(mdr.GetString("tipo"));
                cd = mdr.GetInt16("id_tprecio_pk");

            }*/

            OdbcCommand _comando = new OdbcCommand(String.Format("SELECT tipo from tipo_precio"), seguridad.Conexion.ObtenerConexionODBC());
            OdbcDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                cbo_catalogo.Text = _reader.GetString(0);
                cbo_catalogo.Items.Add(_reader["tipo"].ToString());
            }
            _reader.Close();

            OdbcCommand _comando2 = new OdbcCommand(String.Format("SELECT tipo from tipo_credito"), seguridad.Conexion.ObtenerConexionODBC());
            OdbcDataReader _reader2 = _comando2.ExecuteReader();
            while (_reader2.Read())
            {
                cbo_credi.Text = _reader2.GetString(0);
                cbo_credi.Items.Add(_reader2["tipo"].ToString());
            }
            _reader2.Close();

            OdbcCommand _comando3 = new OdbcCommand(String.Format("SELECT nombre from contribuyente"), seguridad.Conexion.ObtenerConexionODBC());
            OdbcDataReader _reader3 = _comando3.ExecuteReader();
            while (_reader3.Read())
            {
                cbo_contri.Text = _reader3.GetString(0);
                cbo_contri.Items.Add(_reader3["nombre"].ToString());
            }
            _reader3.Close();

            OdbcCommand _comando4 = new OdbcCommand(String.Format("SELECT nombre from empleado where cargo = 'vendedor' "), seguridad.Conexion.ObtenerConexionODBC());
            OdbcDataReader _reader4 = _comando4.ExecuteReader();
            while (_reader4.Read())
            {
                cbo_ven.Text = _reader4.GetString(0);
                cbo_ven.Items.Add(_reader4["nombre"].ToString());
            }
            _reader4.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*try
            {
                if (string.IsNullOrWhiteSpace(txt_nombre.Text))
                    MessageBox.Show("Campo obligatorio vacío", "Campo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {

                    cls_cliente tc = new cls_cliente();
                    tc.nombre = txt_nombre.Text.Trim();
                    tc.apellido = txt_apellido.Text.Trim();
                    tc.nit = txt_nit.Text.Trim();
                    tc.dire = txt_direccion.Text.Trim();
                    tc.tel = txt_telefono.Text.Trim();
                    tc.correo = txt_correo.Text.Trim();
                    tc.fecha = date_clte.Text.Trim();
                    MySqlCommand _comando = new MySqlCommand(String.Format(
                 "SELECT id_contribuyente_pk FROM contribuyente where nombre ='{0}' ", cbo_contri.Text), cls_bdcomun.ObtenerConexion());
                    MySqlDataReader _reader = _comando.ExecuteReader();
                    while (_reader.Read())
                    {

                        tc.codcontri = _reader.GetInt16(0);
                    }
                    _reader.Close();

                    MySqlCommand _comando2 = new MySqlCommand(String.Format(
                 "SELECT id_tipocredito_pk FROM tipo_credito where tipo ='{0}' ", cbo_credi.Text), cls_bdcomun.ObtenerConexion());
                    MySqlDataReader _reader2 = _comando2.ExecuteReader();
                    while (_reader2.Read())
                    {

                        tc.codcredi = _reader2.GetInt16(0);
                    }

                    int iresultado = clsOcliente.Agregar(tc);
                    if (iresultado > 0)
                    {
                        MessageBox.Show("Proyecto Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("No se pudo guardar el proyecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            //mostrar();*/
        }

        public cls_cliente cldes { get; set; }
        private void btn_search_Click(object sender, EventArgs e)
        {
            /*try
            {
                frmbuscliente buscl = new frmbuscliente();
                buscl.ShowDialog();


                if (buscl.descl != null)
                {
                    cldes = buscl.descl;
                    txt_nombre.Text = buscl.descl.nombre;
                    txt_apellido.Text = buscl.descl.apellido;
                    txt_nit.Text = buscl.descl.nit;
                    txt_direccion.Text = buscl.descl.dire;
                    txt_telefono.Text = buscl.descl.tel;
                    txt_correo.Text = buscl.descl.correo;
                    date_clte.Text = buscl.descl.fecha;

                    MySqlCommand _comando = new MySqlCommand(String.Format(
                "SELECT nombre FROM contribuyente where id_contribuyente_pk ='{0}' ", buscl.descl.codcontri), cls_bdcomun.ObtenerConexion());
                    MySqlDataReader _reader = _comando.ExecuteReader();
                    while (_reader.Read())
                    {

                        cbo_contri.Text = _reader.GetString(0);
                    }
                    _reader.Close();

                    MySqlCommand _comando2 = new MySqlCommand(String.Format(
                "SELECT tipo FROM tipo_credito where id_tipocredito_pk ='{0}' ", buscl.descl.codcredi), cls_bdcomun.ObtenerConexion());
                    MySqlDataReader _reader2 = _comando2.ExecuteReader();
                    while (_reader2.Read())
                    {

                        cbo_credi.Text = _reader2.GetString(0);
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            mostrar();*/
        }

        private void btn_mod_Click(object sender, EventArgs e)
        {
            /*try
            {
                if (string.IsNullOrWhiteSpace(txt_nombre.Text))

                    MessageBox.Show("Campo obligatorio vacío", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {


                    cls_cliente cl = new cls_cliente();
                    cl.nombre = txt_nombre.Text.Trim();
                    cl.apellido = txt_apellido.Text.Trim();
                    cl.nit = txt_nit.Text.Trim();
                    cl.dire = txt_direccion.Text.Trim();
                    cl.tel = txt_telefono.Text.Trim();
                    cl.correo = txt_correo.Text.Trim();
                    cl.fecha = date_clte.Text.Trim();

                    MySqlCommand _comando = new MySqlCommand(String.Format(
                 "SELECT id_contribuyente_pk FROM contribuyente where nombre ='{0}' ", cbo_contri.Text), cls_bdcomun.ObtenerConexion());
                    MySqlDataReader _reader = _comando.ExecuteReader();
                    while (_reader.Read())
                    {

                        cl.codcontri = _reader.GetInt16(0);
                    }
                    _reader.Close();

                    MySqlCommand _comando2 = new MySqlCommand(String.Format(
                 "SELECT id_tipocredito_pk FROM tipo_credito where tipo ='{0}' ", cbo_credi.Text), cls_bdcomun.ObtenerConexion());
                    MySqlDataReader _reader2 = _comando2.ExecuteReader();
                    while (_reader2.Read())
                    {

                        cl.codcredi = _reader2.GetInt16(0);
                    }

                    cl.cod = cldes.cod;

                    int iresultado = clsOcliente.Actualizar(cl);
                    if (iresultado > 0)
                    {
                        MessageBox.Show("Proyecto actualizado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar el proyecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            mostrar();*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*try
            {
                if (MessageBox.Show("Esta Seguro que desea eliminar el proyecto Actual", "Estas Seguro??", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (clsOtcredi.Eliminar(cldes.cod) > 0)
                    {
                        MessageBox.Show("Proyecto Eliminado Correctamente!", "Proyecto Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el proyecto", "Proyecto No Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                    MessageBox.Show("Se cancelo la eliminacion", "Eliminacion Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            mostrar();*/
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {

//            btn_del.Enabled = true;
  //          btn_mod.Enabled = true;
    //        button3.Enabled = true;

            string scad = "select * from tipo_credito";
            DataTable dt = new DataTable();
            OdbcCommand mcd = new OdbcCommand(scad, seguridad.Conexion.ObtenerConexionODBC());
            OdbcDataAdapter da = new OdbcDataAdapter(mcd);
            da.Fill(dt);
            if(dt.Rows.Count != 0)
            {
                cbo_credi.DataSource = dt;
                cbo_credi.DisplayMember = "tipo";
                cbo_credi.ValueMember = "id_tipocredito_pk";
            }
            else {
                MessageBox.Show("Error al cargar datos");
            }
            /*while (mdr.Read())
            {
                cbo_credi.Items.Add(mdr.GetString("tipo"));
            }*/

            string scad2 = "select * from contribuyente";
            DataTable dt2 = new DataTable();
            OdbcCommand mcd2 = new OdbcCommand(scad2, seguridad.Conexion.ObtenerConexionODBC());
            OdbcDataAdapter da2 = new OdbcDataAdapter(mcd2);
            da.Fill(dt2);
            if (dt2.Rows.Count != 0)
            {
                cbo_contri.DataSource = dt2;
                cbo_contri.DisplayMember = "nombre";
                cbo_contri.ValueMember = "id_contribuyente_pk";
            }
            else
            {
                MessageBox.Show("Error al cargar datos");
            }
            
            /*while (mdr2.Read())
            {
                cbo_contri.Items.Add(mdr2.GetString("nombre"));
            }*/



        }

        private void btn_act_Click(object sender, EventArgs e)
        {
            mostrar();
        }

        private void btn_nuevo_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_nombre.Text))
                    MessageBox.Show("Campo obligatorio vacío", "Campo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {

                    cls_cliente tc = new cls_cliente();
                    tc.nombre = txt_nombre.Text.Trim();
                    tc.apellido = txt_apellido.Text.Trim();
                    tc.dpi = Convert.ToInt32(txt_dpi.Text.Trim());
                    tc.nit = txt_nit.Text.Trim();
                    tc.dire = txt_direccion.Text.Trim();
                    tc.tel = txt_telefono.Text.Trim();
                    tc.correo = txt_correo.Text.Trim();
                    tc.fecha = date_clte.Text.Trim();
   
                    OdbcCommand _comando = new OdbcCommand(String.Format(
                 "SELECT id_contribuyente_pk FROM contribuyente where nombre ='{0}' ", cbo_contri.Text), seguridad.Conexion.ObtenerConexionODBC());
                    OdbcDataReader _reader = _comando.ExecuteReader();
                    while (_reader.Read())
                    {
                        tc.codcontri = _reader.GetInt16(0);
                    }
                    _reader.Close();

                    OdbcCommand _comando2 = new OdbcCommand(String.Format(
                 "SELECT id_tipocredito_pk FROM tipo_credito where tipo ='{0}' ", cbo_credi.Text), seguridad.Conexion.ObtenerConexionODBC());
                    OdbcDataReader _reader2 = _comando2.ExecuteReader();
                    while (_reader2.Read())
                    {

                        tc.codcredi = _reader2.GetInt16(0);
                    }

                    OdbcCommand _comando3 = new OdbcCommand(String.Format(
                 "SELECT id_empleados_pk FROM empleado where nombre ='{0}' ", cbo_ven.Text), seguridad.Conexion.ObtenerConexionODBC());
                    OdbcDataReader _reader3 = _comando3.ExecuteReader();
                    while (_reader3.Read())
                    {

                        tc.codcredi = _reader3.GetInt16(0);
                    }

                    OdbcCommand _comando4 = new OdbcCommand(String.Format(
                 "SELECT id_tprecio_pk FROM tipo_precio where tipo ='{0}' ", cbo_catalogo.Text), seguridad.Conexion.ObtenerConexionODBC());
                    OdbcDataReader _reader4 = _comando4.ExecuteReader();
                    while (_reader4.Read())
                    {
                        tc.codpre = _reader4.GetInt16(0);
                    }
                
                    int iresultado = clsOcliente.Agregar(tc);
                    if (iresultado > 0)
                    {
                        MessageBox.Show("Proyecto Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("No se pudo guardar el proyecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                /*frmbuscliente buscl = new frmbuscliente();
                buscl.ShowDialog();


                if (buscl.descl != null)
                {
                    cldes = buscl.descl;
                    txt_nombre.Text = buscl.descl.nombre;
                    txt_apellido.Text = buscl.descl.apellido;
                    txt_dpi.Text = Convert.ToString(buscl.descl.dpi);
                    txt_nit.Text = buscl.descl.nit;
                    txt_direccion.Text = buscl.descl.dire;
                    txt_telefono.Text = buscl.descl.tel;
                    txt_correo.Text = buscl.descl.correo;
                    date_clte.Text = buscl.descl.fecha;

                    OdbcCommand _comando = new OdbcCommand(String.Format(
                "SELECT nombre FROM contribuyente where id_contribuyente_pk ='{0}' ", buscl.descl.codcontri), seguridad.Conexion.ObtenerConexionODBC());
                    OdbcDataReader _reader = _comando.ExecuteReader();
                    while (_reader.Read())
                    {

                        cbo_contri.Text = _reader.GetString(0);
                    }
                    _reader.Close();

                    OdbcCommand _comando2 = new OdbcCommand(String.Format(
                "SELECT tipo FROM tipo_credito where id_tipocredito_pk ='{0}' ", buscl.descl.codcredi), seguridad.Conexion.ObtenerConexionODBC());
                    OdbcDataReader _reader2 = _comando2.ExecuteReader();
                    while (_reader2.Read())
                    {

                        cbo_credi.Text = _reader2.GetString(0);
                    }

                }*/                

            }
                
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            //mostrar();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_nombre.Text))

                    MessageBox.Show("Campo obligatorio vacío", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {


                    cls_cliente cl = new cls_cliente();
                    cl.nombre = txt_nombre.Text.Trim();
                    cl.apellido = txt_apellido.Text.Trim();
                    cl.dpi = Convert.ToInt32(txt_dpi.Text.Trim());
                    cl.nit = txt_nit.Text.Trim();
                    cl.dire = txt_direccion.Text.Trim();
                    cl.tel = txt_telefono.Text.Trim();
                    cl.correo = txt_correo.Text.Trim();
                    cl.fecha = date_clte.Text.Trim();

                    OdbcCommand _comando = new OdbcCommand(String.Format(
                 "SELECT id_contribuyente_pk FROM contribuyente where nombre ='{0}' ", cbo_contri.Text), seguridad.Conexion.ObtenerConexionODBC());
                    OdbcDataReader _reader = _comando.ExecuteReader();
                    while (_reader.Read())
                    {

                        cl.codcontri = _reader.GetInt16(0);
                    }
                    _reader.Close();

                    OdbcCommand _comando2 = new OdbcCommand(String.Format(
                 "SELECT id_tipocredito_pk FROM tipo_credito where tipo ='{0}' ", cbo_credi.Text), seguridad.Conexion.ObtenerConexionODBC());
                    OdbcDataReader _reader2 = _comando2.ExecuteReader();
                    while (_reader2.Read())
                    {

                        cl.codcredi = _reader2.GetInt16(0);
                    }

                    //cl.cod = cldes.cod;

                    OdbcCommand _comando3 = new OdbcCommand(String.Format(
                 "SELECT id_empleados_pk FROM empleado where nombre ='{0}' ", cbo_ven.Text), seguridad.Conexion.ObtenerConexionODBC());
                    OdbcDataReader _reader3 = _comando3.ExecuteReader();
                    while (_reader3.Read())
                    {

                        cl.codven = _reader3.GetInt16(0);
                    }

                    OdbcCommand _comando4 = new OdbcCommand(String.Format(
                 "SELECT id_tprecio_pk FROM tipo_precio where tipo ='{0}' ", cbo_catalogo.Text), seguridad.Conexion.ObtenerConexionODBC());
                    OdbcDataReader _reader4 = _comando4.ExecuteReader();
                    while (_reader4.Read())
                    {

                        cl.codpre = _reader4.GetInt16(0);
                    }

                    //cl.cod = cldes.cod;

                    cl.cod = cldes.cod;

                    int iresultado = clsOcliente.Actualizar(cl);
                    if (iresultado > 0)
                    {
                        MessageBox.Show("Proyecto actualizado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar el proyecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            //mostrar();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Esta Seguro que desea eliminar el proyecto Actual", "Estas Seguro??", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (clsOtcredi.Eliminar(cldes.cod) > 0)
                    {
                        MessageBox.Show("Proyecto Eliminado Correctamente!", "Proyecto Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el proyecto", "Proyecto No Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                    MessageBox.Show("Se cancelo la eliminacion", "Eliminacion Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            //mostrar();
        }

        private void cbo_ven_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            try
            {
                Abrir.Form2 fv = new Abrir.Form2();

                fv.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void datos(object data)
        {

        }

        FuncionesNavegador.CapaNegocio fn = new FuncionesNavegador.CapaNegocio();
        private void btn_anterior_Click(object sender, EventArgs e)
        {
            //frmDataCliente dat = new cuentas_corrientes.frmDataCliente();            
            //fn.Anterior(dat);
            //TextBox[] textbox = { textBox4, textBox3, textBox2, textBox5 };
            //fn.llenartextbox(textbox, dataGridView1);
            //dateTimePicker1.Text = textBox5.Text;
            //comboBox1.Text = textBox4.Text;
        }
    }
}
