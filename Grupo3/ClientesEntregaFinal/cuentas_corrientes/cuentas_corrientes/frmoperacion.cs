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
using seguridad;
using System.Diagnostics;

namespace cuentas_corrientes
{
    public partial class frmoperacion : Form
    {
        public frmoperacion()
        {
            InitializeComponent();
        }

        public frmoperacion(string snom, string sapel, string sdpi, string snit, string sdirec)
        {
            InitializeComponent();
            //funLlenarComboActividad();
            //sdirec = date_clte.Value.ToString("yyyy-MM-dd");
            OdbcCommand _comando = new OdbcCommand(String.Format(
                 "SELECT monto FROM deuda where id_deuda ='{0}' ", snom), seguridad.Conexion.ObtenerConexionODBC());
            OdbcDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {

                cbo_monto.Text = _reader.GetString(0);
            }
            _reader.Close();
            //cbo_monto.Text = snom;
            txt_cantidad.Text = sapel;
            txt_descripcion.Text = sdpi;
            OdbcCommand _comando2 = new OdbcCommand(String.Format(
                "SELECT nombre_tipo FROM tipo_doc_1 where id_tipo_pk ='{0}' ", snit), seguridad.Conexion.ObtenerConexionODBC());
            OdbcDataReader _reader2 = _comando2.ExecuteReader();
            while (_reader2.Read())
            {

                cbo_tipodoc.Text = _reader2.GetString(0);
            }
            _reader.Close();
            //cbo_tipodoc.Text = snit;
            date_clte.Text = sdirec;            
        }

        public Int16 codclte;
        public void mostrar()
        {
            OdbcConnection conexion = seguridad.Conexion.ObtenerConexionODBC();
            OdbcDataAdapter dausuario = new OdbcDataAdapter("SELECT * FROM operacion", conexion);
            DataSet dsuario = new DataSet();
            dausuario.Fill(dsuario, "operacion");           

            OdbcCommand _comando = new OdbcCommand(String.Format("SELECT nombre_tipo from tipo_doc_1"), seguridad.Conexion.ObtenerConexionODBC());
            OdbcDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                cbo_tipodoc.Text = _reader.GetString(0);
                cbo_tipodoc.Items.Add(_reader["nombre_tipo"].ToString());
            }
            _reader.Close();

            OdbcCommand _comando1 = new OdbcCommand(String.Format("select max(c.nombre), d.id_cliente_pk from deuda d, cliente c where d.id_cliente_pk = c.id_cliente_pk group by (d.id_cliente_pk)"), seguridad.Conexion.ObtenerConexionODBC());
            OdbcDataReader _reader1 = _comando1.ExecuteReader();
            while (_reader1.Read())
            {
                cbo_clte.Text = _reader1.GetString(0);
                cbo_clte.Items.Add(_reader1["max(c.nombre)"].ToString());
            }
            _reader1.Close();

            /*OdbcCommand _comando2 = new OdbcCommand(String.Format("select id_cliente_pk from cliente where nombre = '"+cbo_clte.Text+"'"), seguridad.Conexion.ObtenerConexionODBC());
            OdbcDataReader _reader2 = _comando2.ExecuteReader();
            while (_reader2.Read())
            {                
                codclte = _reader2.GetInt16(0);
                //MessageBox.Show(Convert.ToString(codclte));
            }
            _reader2.Close();*/

        }

        private void frmImpuesto_Load(object sender, EventArgs e)
        {

        }
        public string nombre, monto, cantidad, tipodoc, total;
        public Double dat1, dat2, tot; public string doc; public Int16 micod;
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            nombre = cbo_clte.Text.Trim();
            monto = cbo_monto.Text.Trim();
            cantidad = txt_cantidad.Text.Trim();
            tipodoc = cbo_tipodoc.Text.Trim();
            total = txt_tot.Text.Trim();
            try
            {
                if (string.IsNullOrWhiteSpace(txt_descripcion.Text))
                    MessageBox.Show("Campo obligatorio vacío", "Campo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {

                    cls_operacion tc = new cls_operacion();
                    tc.cantidad = Convert.ToInt32(txt_cantidad.Text.Trim());
                    tc.desc = txt_descripcion.Text.Trim();
                    //tc.coddoc = Convert.ToInt32(cbo_tipodoc.Text.Trim());                    
                    tc.fecha = date_clte.Value.ToString("yyyy-MM-dd");
                    OdbcCommand _comando = new OdbcCommand(String.Format(
                 "SELECT id_deuda FROM deuda where saldo_total ='{0}' ", cbo_monto.Text), seguridad.Conexion.ObtenerConexionODBC());
                    OdbcDataReader _reader = _comando.ExecuteReader();
                    while (_reader.Read())
                    {

                        tc.codde = _reader.GetInt16(0);
                    }
                    _reader.Close();

                    OdbcCommand _comando2 = new OdbcCommand(String.Format(
                 "SELECT id_tipo_pk FROM tipo_doc_1 where nombre_tipo ='{0}' ", cbo_tipodoc.Text), seguridad.Conexion.ObtenerConexionODBC());
                    OdbcDataReader _reader2 = _comando2.ExecuteReader();
                    while (_reader2.Read())
                    {

                        tc.coddoc = _reader2.GetInt16(0);
                    }
                    

                    int iresultado = clsOperacion.Agregar(tc);

                    OdbcCommand _comando3 = new OdbcCommand(String.Format(
                "SELECT id_deuda from deuda where id_cliente_pk = '"+codclte+"' and id_fac_empresa_pk = "+cbo_fac.Text), seguridad.Conexion.ObtenerConexionODBC());
                    OdbcDataReader _reader3 = _comando3.ExecuteReader();
                    while (_reader3.Read())
                    {                        
                        micod = _reader3.GetInt16(0);
                        //MessageBox.Show(Convert.ToString(micod));
                    }

                    OdbcConnection conexion = seguridad.Conexion.ObtenerConexionODBC();
                    OdbcCommand comando = new OdbcCommand(string.Format("update deuda set saldo_total=" + txt_tot.Text+" where id_deuda = "+micod+""),conexion);
                    comando.ExecuteNonQuery();
                    conexion.Close();
                    //OdbcCommand comando = new OdbcCommand(string.Format("update deuda set saldo_total= "+70+" where id_deuda = "+7));
                    if (iresultado > 0)
                    {
                        MessageBox.Show("Proyecto Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if(iresultado > 0)
                        {
                            OdbcCommand comando2 = new OdbcCommand(string.Format("insert into tabla (id, nombre, monto, cantidad, tipodoc, total) values (NULL,'{0}','{1}','{2}','{3}','{4}')",
              nombre, monto, cantidad, tipodoc, total), seguridad.Conexion.ObtenerConexionODBC());
                            comando2.ExecuteNonQuery();
                        }
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

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            mostrar();
        }

        public int codigo;
        public void id(int id)
        {
            codigo = id;
        }

        public cls_cliente cldes { get; set; }

        private void button2_Click(object sender, EventArgs e)
        {
            string ruta = "manual_operacion.pdf";
            ProcessStartInfo startinfo = new ProcessStartInfo();
            startinfo.FileName = "AcroRd32.exe";
            startinfo.Arguments = ruta;
            Process.Start(startinfo);
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_descripcion.Text))

                    MessageBox.Show("Campo obligatorio vacío", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {


                    cls_operacion tc = new cls_operacion();
                    tc.cantidad = Convert.ToInt32(txt_cantidad.Text.Trim());
                    tc.desc = txt_descripcion.Text.Trim();
                    //tc.coddoc = Convert.ToInt32(cbo_tipodoc.Text.Trim());
                    tc.fecha = date_clte.Value.ToString("yyyy-MM-dd");
                    OdbcCommand _comando = new OdbcCommand(String.Format(
                 "SELECT id_deuda FROM deuda where saldo_total ='{0}' ", cbo_monto.Text), seguridad.Conexion.ObtenerConexionODBC());
                    OdbcDataReader _reader = _comando.ExecuteReader();
                    while (_reader.Read())
                    {

                        tc.codde = _reader.GetInt16(0);
                    }
                    _reader.Close();

                    OdbcCommand _comando2 = new OdbcCommand(String.Format(
                 "SELECT id_tipo_pk FROM tipo_doc_1 where nombre_tipo ='{0}' ", cbo_tipodoc.Text), seguridad.Conexion.ObtenerConexionODBC());
                    OdbcDataReader _reader2 = _comando2.ExecuteReader();
                    while (_reader2.Read())
                    {

                        tc.coddoc = _reader2.GetInt16(0);
                    }

                    //cl.cod = cldes.cod;                    
                    //MessageBox.Show(Convert.ToString("el dato es: "+codigo));
                    tc.cod = codigo;

                    int iresultado = clsOperacion.Actualizar(tc);
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
        }

        private void cbo_tipodoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            dat1 = Convert.ToDouble(cbo_monto.Text);
            dat2 = Convert.ToDouble(txt_cantidad.Text);
            doc = cbo_tipodoc.Text;
            if (doc == "Factura")
            {
                tot = dat1 + dat2;
                txt_tot.Text = Convert.ToString(tot);
                //int iretorno = 0;
                //OdbcConnection conexion = seguridad.Conexion.ObtenerConexionODBC();
                //OdbcCommand comando = new OdbcCommand(string.Format("update deuda set saldo_total='"+tot));                  
            }
            else if (doc == "Recibo")
            {
                tot = dat1 - dat2;
                txt_tot.Text = Convert.ToString(tot);
                //OdbcConnection conexion = seguridad.Conexion.ObtenerConexionODBC();
                //OdbcCommand comando = new OdbcCommand(string.Format("update deuda set saldo_total='" + tot));
            }
            else if (doc == "Nota de credito")
            {
                tot = dat1 - dat2;
                txt_tot.Text = Convert.ToString(tot);
                // OdbcConnection conexion = seguridad.Conexion.ObtenerConexionODBC();
                //OdbcCommand comando = new OdbcCommand(string.Format("update deuda set saldo_total='" + tot));
            }
            else if (doc == "Nota de debito")
            {
                tot = dat1 + dat2;
                txt_tot.Text = Convert.ToString(tot);
                // OdbcConnection conexion = seguridad.Conexion.ObtenerConexionODBC();
                // OdbcCommand comando = new OdbcCommand(string.Format("update deuda set saldo_total='" + tot));
            }
        }

        private void cbo_clte_SelectedIndexChanged(object sender, EventArgs e)
        {
            OdbcCommand _comando2 = new OdbcCommand(String.Format("select max(d.saldo_total), d.id_cliente_pk from deuda d, cliente c where c.nombre = '" + cbo_clte.Text + "'and d.id_cliente_pk = c.id_cliente_pk group by (d.id_cliente_pk)  "), seguridad.Conexion.ObtenerConexionODBC());
            OdbcDataReader _reader2 = _comando2.ExecuteReader();
            while (_reader2.Read())
            {
                cbo_monto.Text = _reader2.GetString(0);
                cbo_monto.Items.Add(_reader2["max(d.saldo_total)"].ToString());
            }
            _reader2.Close();

            OdbcCommand _comando3 = new OdbcCommand(String.Format("select id_cliente_pk from cliente where nombre = '" + cbo_clte.Text + "'"), seguridad.Conexion.ObtenerConexionODBC());
            OdbcDataReader _reader3 = _comando3.ExecuteReader();
            while (_reader3.Read())
            {
                codclte = _reader3.GetInt16(0);
                //MessageBox.Show(Convert.ToString(codclte));
            }
            _reader3.Close();

            OdbcCommand _comando = new OdbcCommand(String.Format("select max(id_fac_empresa_pk), id_cliente_pk from deuda where id_cliente_pk= '"+codclte+"' group by (id_fac_empresa_pk)"), seguridad.Conexion.ObtenerConexionODBC());
            OdbcDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                //MessageBox.Show(Convert.ToString(cod));
                cbo_fac.Text = _reader.GetString(0);
                cbo_fac.Items.Add(_reader["max(id_fac_empresa_pk)"].ToString());
            }
            _reader2.Close();
         
        }

        private void cbo_fac_SelectedIndexChanged(object sender, EventArgs e)
        {
            OdbcCommand _comando2 = new OdbcCommand(String.Format("select saldo_total, max(id_fac_empresa_pk) from deuda where id_fac_empresa_pk = "+cbo_fac.Text), seguridad.Conexion.ObtenerConexionODBC());
            OdbcDataReader _reader2 = _comando2.ExecuteReader();
            while (_reader2.Read())
            {
                cbo_monto.Text = _reader2.GetString(0);
                cbo_monto.Items.Add(_reader2["saldo_total"].ToString());
            }
            _reader2.Close();
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
        }
        
        private void txt_cantidad_TextChanged(object sender, EventArgs e)
        {            

        }
    }
}
