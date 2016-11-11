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
using seguridad;
using System.Diagnostics;

namespace cuentas_corrientes
{
    public partial class frmdeuda : Form
    {
        public frmdeuda(cls_deuda imp)
        {
            InitializeComponent();
            try
            {

                if (imp != null)
                {

                    ddes = imp;                    
                    cbo_cliente.Text = Convert.ToString(imp.codclte);
                    cbo_empresa.Text = Convert.ToString(imp.codemp);
                    cbo_factura.Text = Convert.ToString(imp.codfac);
                    txt_monto.Text = imp.monto;
                    txt_saldot.Text = imp.saldo;
                    
                    MessageBox.Show("paso");
                }
                else
                {
                    cbo_cliente.Text = "";
                    cbo_empresa.Text = "";
                    cbo_factura.Text = "";
                    txt_monto.Text = "";
                    txt_saldot.Text = "";
                    
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        public frmdeuda(string snom, string sapel, string sdpi, string snit, string sdirec, string svend)
        {
            InitializeComponent();
            //funLlenarComboActividad();
            //MessageBox.Show(sdpi);
            //Convert.ToInt32(sdpi);
            txt_monto.Text = snom;
            txt_saldot.Text = sapel;
            OdbcCommand _comando = new OdbcCommand(String.Format(
                "SELECT nombre FROM cliente where id_cliente_pk ='{0}' ", sdpi), seguridad.Conexion.ObtenerConexionODBC());
            OdbcDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {                
                cbo_cliente.Text = _reader.GetString(0);
            }
            _reader.Close();
            //cbo_cliente.Text = sdpi;
            cbo_factura.Text = snit;
            OdbcCommand _comando3 = new OdbcCommand(String.Format(
                "SELECT nombre FROM empresa where id_empresa_pk ='{0}' ", sdirec), seguridad.Conexion.ObtenerConexionODBC());
            OdbcDataReader _reader3 = _comando3.ExecuteReader();
            while (_reader3.Read())
            {
                cbo_empresa.Text = _reader3.GetString(0);
            }
            _reader3.Close();
            //cbo_empresa.Text = sdirec;
            OdbcCommand _comando2 = new OdbcCommand(String.Format(
                "SELECT serie FROM factura where id_fac_empresa_pk ='{0}' ", svend), seguridad.Conexion.ObtenerConexionODBC());
            OdbcDataReader _reader2 = _comando2.ExecuteReader();
            while (_reader2.Read())
            {
                cbo_serie.Text = _reader2.GetString(0);
            }
            _reader2.Close();
            //cbo_serie.Text = svend;            
        }

        public void mostrar()
        {
            //OdbcCommand _comando = new OdbcCommand(String.Format("SELECT serie from factura where "), seguridad.Conexion.ObtenerConexionODBC());
            OdbcCommand _comando = new OdbcCommand(String.Format("select factura.serie from factura, cliente where cliente.nombre = '"+cbo_cliente.Text+"' and cliente.id_cliente_pk = factura.id_cliente_pk "), seguridad.Conexion.ObtenerConexionODBC());
            OdbcDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                cbo_serie.Text = _reader.GetString(0);
                cbo_serie.Items.Add(_reader["serie"].ToString());
            }
            _reader.Close();

            OdbcCommand _comando2 = new OdbcCommand(String.Format("SELECT nombre from cliente "), seguridad.Conexion.ObtenerConexionODBC());
            OdbcDataReader _reader2 = _comando2.ExecuteReader();
            while (_reader2.Read())
            {
                cbo_cliente.Text = _reader2.GetString(0);
                cbo_cliente.Items.Add(_reader2["nombre"].ToString());
            }
            _reader2.Close();

            OdbcCommand _comando3 = new OdbcCommand(String.Format("SELECT nombre from empresa"), seguridad.Conexion.ObtenerConexionODBC());
            OdbcDataReader _reader3 = _comando3.ExecuteReader();
            while (_reader3.Read())
            {
                cbo_empresa.Text = _reader3.GetString(0);
                cbo_empresa.Items.Add(_reader3["nombre"].ToString());
            }
            _reader3.Close();

            //OdbcCommand _comando4 = new OdbcCommand(String.Format("SELECT id_fac_empresa_pk from factura "), seguridad.Conexion.ObtenerConexionODBC());
            OdbcCommand _comando4 = new OdbcCommand(String.Format("select factura.id_fac_empresa_pk from factura, cliente where cliente.nombre = '"+cbo_cliente.Text+"' and cliente.id_cliente_pk = factura.id_cliente_pk "), seguridad.Conexion.ObtenerConexionODBC());
            OdbcDataReader _reader4 = _comando4.ExecuteReader();
            while (_reader4.Read())
            {
                cbo_factura.Text = _reader4.GetString(0);
                cbo_factura.Items.Add(_reader4["id_fac_empresa_pk"].ToString());
            }
            _reader4.Close();
        }

        private void frmFormaDePago_Load(object sender, EventArgs e)
        {
            //mostrar();
        }

        public Double saldo1, saldo2; public Double saldot=0;
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(cbo_cliente.Text))
                    MessageBox.Show("Campo obligatorio vacío", "Campo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {

                    cls_deuda tc = new cls_deuda();
                    //tc.codclte = Convert.ToInt16(txt_cliente.Text.Trim());
                    //tc.codemp = Convert.ToInt16(txt_empresa.Text.Trim());
                    tc.codfac = Convert.ToInt16(cbo_factura.Text.Trim());
                    tc.monto = txt_monto.Text.Trim();                   
                    saldo1 = Convert.ToDouble(txt_monto.Text.Trim());
                    saldo2 = Convert.ToDouble(txt_saldot.Text.Trim());
                    saldot = Convert.ToDouble(saldo1 + saldo2);
                    tc.saldo = Convert.ToString(saldot);
                    //tc.serie = txt_serie.Text.Trim();
                    OdbcCommand _comando = new OdbcCommand(String.Format(
                 "SELECT id_cliente_pk FROM cliente where nombre ='{0}' ", cbo_cliente.Text), seguridad.Conexion.ObtenerConexionODBC());
                    OdbcDataReader _reader = _comando.ExecuteReader();
                    while (_reader.Read())
                    {

                        tc.codclte = _reader.GetInt16(0);
                    }
                    _reader.Close();

                    OdbcCommand _comando2 = new OdbcCommand(String.Format(
                 "SELECT id_empresa_pk FROM empresa where nombre ='{0}' ", cbo_empresa.Text), seguridad.Conexion.ObtenerConexionODBC());
                    OdbcDataReader _reader2 = _comando2.ExecuteReader();
                    while (_reader2.Read())
                    {

                        tc.codemp = _reader2.GetInt16(0);
                    }


                    OdbcCommand _comando3 = new OdbcCommand(String.Format(
                 "SELECT id_fac_empresa_pk FROM factura where serie ='{0}' ", cbo_serie.Text), seguridad.Conexion.ObtenerConexionODBC());
                    OdbcDataReader _reader3 = _comando3.ExecuteReader();
                    while (_reader3.Read())
                    {

                        tc.serie = _reader3.GetString(0);
                    }

                    int iresultado = clsOdeuda.Agregar(tc);
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

        public cls_deuda ddes { get; set; }
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                frmBuscardeuda buscl = new frmBuscardeuda();
                buscl.ShowDialog();


                if (buscl.descl != null)
                {
                    ddes = buscl.descl;
                    //txt_cliente.Text = buscl.descl.nombre;
                    //txt_empresa.Text = buscl.descl.apellido;
                    cbo_factura.Text = Convert.ToString(buscl.descl.codfac);
                    txt_monto.Text = buscl.descl.monto;
                    txt_saldot.Text = buscl.descl.saldo;

                    OdbcCommand _comando = new OdbcCommand(String.Format(
                "SELECT nombre FROM cliente where id_cliente_pk ='{0}' ", buscl.descl.codclte), seguridad.Conexion.ObtenerConexionODBC());
                    OdbcDataReader _reader = _comando.ExecuteReader();
                    while (_reader.Read())
                    {

                        cbo_cliente.Text = _reader.GetString(0);
                    }
                    _reader.Close();

                    OdbcCommand _comando2 = new OdbcCommand(String.Format(
                "SELECT nombre FROM empresa where id_empresa_pk ='{0}' ", buscl.descl.codemp), seguridad.Conexion.ObtenerConexionODBC());
                    OdbcDataReader _reader2 = _comando2.ExecuteReader();
                    while (_reader2.Read())
                    {

                        cbo_empresa.Text = _reader2.GetString(0);
                    }                    


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            //mostrar();
        }

        public int codigo;
        public void id(int id)
        {
            codigo = id;
        }
        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(cbo_cliente.Text))

                    MessageBox.Show("Campo obligatorio vacío", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {


                    cls_deuda cl = new cls_deuda();
                    //cl.codclte = Convert.ToInt16(txt_cliente.Text.Trim());
                    //cl.codemp = Convert.ToInt16(txt_empresa.Text.Trim());
                    cl.codfac = Convert.ToInt16(cbo_factura.Text.Trim());
                    cl.monto = txt_monto.Text.Trim();
                    cl.saldo = txt_saldot.Text.Trim();

                    OdbcCommand _comando = new OdbcCommand(String.Format(
                 "SELECT id_cliente_pk FROM cliente where nombre ='{0}' ", cbo_cliente.Text), seguridad.Conexion.ObtenerConexionODBC());
                    OdbcDataReader _reader = _comando.ExecuteReader();
                    while (_reader.Read())
                    {

                        cl.codclte = _reader.GetInt16(0);
                    }
                    _reader.Close();

                    OdbcCommand _comando2 = new OdbcCommand(String.Format(
                 "SELECT id_empresa_pk FROM empresa where nombre ='{0}' ", cbo_empresa.Text), seguridad.Conexion.ObtenerConexionODBC());
                    OdbcDataReader _reader2 = _comando2.ExecuteReader();
                    while (_reader2.Read())
                    {

                        cl.codemp = _reader2.GetInt16(0);
                    }

                    OdbcCommand _comando3 = new OdbcCommand(String.Format(
                 "SELECT id_fac_empresa_pk FROM factura where serie ='{0}' ", cbo_serie.Text), seguridad.Conexion.ObtenerConexionODBC());
                    OdbcDataReader _reader3 = _comando3.ExecuteReader();
                    while (_reader3.Read())
                    {

                        cl.serie = _reader3.GetString(0);
                    }

                    cl.cod = codigo;

                    int iresultado = clsOdeuda.Actualizar(cl);
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
                    if (clsOtcredi.Eliminar(codigo) > 0)
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

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            mostrar();
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            OdbcCommand _comando = new OdbcCommand(String.Format("select factura.serie from factura, cliente where cliente.nombre = '" + cbo_cliente.Text + "' and cliente.id_cliente_pk = factura.id_cliente_pk "), seguridad.Conexion.ObtenerConexionODBC());
            OdbcDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                cbo_serie.Text = _reader.GetString(0);
                cbo_serie.Items.Add(_reader["serie"].ToString());
            }
            _reader.Close();

            //OdbcCommand _comando4 = new OdbcCommand(String.Format("SELECT id_fac_empresa_pk from factura "), seguridad.Conexion.ObtenerConexionODBC());
            OdbcCommand _comando4 = new OdbcCommand(String.Format("select factura.id_fac_empresa_pk from factura, cliente where cliente.nombre = '" + cbo_cliente.Text + "' and cliente.id_cliente_pk = factura.id_cliente_pk "), seguridad.Conexion.ObtenerConexionODBC());
            OdbcDataReader _reader4 = _comando4.ExecuteReader();
            while (_reader4.Read())
            {
                cbo_factura.Text = _reader4.GetString(0);
                cbo_factura.Items.Add(_reader4["id_fac_empresa_pk"].ToString());
            }
            _reader4.Close();
        }

        private void cbo_factura_SelectedIndexChanged(object sender, EventArgs e)
        {
            OdbcCommand _comando2 = new OdbcCommand(String.Format("select total from factura where id_fac_empresa_pk ='" + cbo_factura.Text + "'"), seguridad.Conexion.ObtenerConexionODBC());
            OdbcDataReader _reader2 = _comando2.ExecuteReader();
            while (_reader2.Read())
            {
                txt_monto.Text = _reader2.GetString(0);
            }
            _reader2.Close();
        }

        private void txt_saldot_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ruta = "manual_deuda.pdf";
            ProcessStartInfo startinfo = new ProcessStartInfo();
            startinfo.FileName = "AcroRd32.exe";
            startinfo.Arguments = ruta;
            Process.Start(startinfo);
        }

        private void cbo_cliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            OdbcCommand _comando = new OdbcCommand(String.Format("select factura.serie from factura, cliente where cliente.nombre = '" + cbo_cliente.Text + "' and cliente.id_cliente_pk = factura.id_cliente_pk "), seguridad.Conexion.ObtenerConexionODBC());
            OdbcDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                cbo_serie.Text = _reader.GetString(0);
                cbo_serie.Items.Add(_reader["serie"].ToString());
            }
            _reader.Close();

            OdbcCommand _comando2 = new OdbcCommand(String.Format("select d.saldo_total from deuda d, cliente c where c.nombre = '"+cbo_cliente.Text+"' and d.id_cliente_pk = c.id_cliente_pk"), seguridad.Conexion.ObtenerConexionODBC());
            OdbcDataReader _reader2 = _comando2.ExecuteReader();
            while (_reader2.Read())
            {
                txt_saldot.Text = _reader2.GetString(0);                
            }
            _reader.Close();

            //OdbcCommand _comando4 = new OdbcCommand(String.Format("SELECT id_fac_empresa_pk from factura "), seguridad.Conexion.ObtenerConexionODBC());
            OdbcCommand _comando4 = new OdbcCommand(String.Format("select factura.id_fac_empresa_pk from factura, cliente where cliente.nombre = '" + cbo_cliente.Text + "' and cliente.id_cliente_pk = factura.id_cliente_pk "), seguridad.Conexion.ObtenerConexionODBC());
            OdbcDataReader _reader4 = _comando4.ExecuteReader();
            while (_reader4.Read())
            {
                cbo_factura.Text = _reader4.GetString(0);
                cbo_factura.Items.Add(_reader4["id_fac_empresa_pk"].ToString());
            }
            _reader4.Close();            
        }    
    }
}
