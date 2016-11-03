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
using dllconsultas;
using System.Data.Odbc;

namespace Modulo_Bancos
{
    public partial class Disponibilidad_bancaria : Form
    {
        public Disponibilidad_bancaria()
        {
            InitializeComponent();
        }

        operaciones op = new operaciones();
        CapaNegocio fn = new CapaNegocio();


        private void Disponibilidad_bancaria_Load(object sender, EventArgs e)
        {
            llenarCboCuentaBancariaNC();
            llenarCboDocts();
            
        }
        public void llenarCboCuentaBancariaNC()
        {
            //se realiza la conexión a la base de datos
            Ayuda.ObtenerConexion();
            //se inicia un DataSet
            DataSet ds = new DataSet();
            //se indica la consulta en sql
            String Query = "select distinct id_empresa_pk,nombre_banco from cuenta_bancaria";
            OdbcDataAdapter dad = new OdbcDataAdapter(Query, Ayuda.ObtenerConexion());
            //se indica con quu tabla se llena
            dad.Fill(ds, "nombre_banco");
            cbo_cuenta_bancaria_nc.DataSource = ds.Tables[0].DefaultView;
            //indicamos el valor de los miembros
            cbo_cuenta_bancaria_nc.ValueMember = ("nombre_banco");
            //se indica el valor a desplegar en el combobox
            DataTable dt = ds.Tables[0];
            dt.Columns.Add("NewColumn", typeof(string));
            foreach (DataRow dr in dt.Rows)
            {
                dr["nombre_banco"] = dr["nombre_banco"].ToString();
            }
            cbo_cuenta_bancaria_nc.DataSource = dt;
            cbo_cuenta_bancaria_nc.DisplayMember = "nombre_banco";
        }

        private void cbo_cuenta_bancaria_nc_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(cbo_cuenta_bancaria_nc.SelectedValue.ToString());
            string nom_banc = cbo_cuenta_bancaria_nc.SelectedValue.ToString();
            //se realiza la conexión a la base de datos
            Ayuda.ObtenerConexion();
            //se inicia un DataSet
            DataSet ds = new DataSet();
            //se indica la consulta en sql
            String Query = "select distinct id_empresa_pk,no_cuenta from cuenta_bancaria where nombre_banco = '"+ nom_banc +"'";
            OdbcDataAdapter dad = new OdbcDataAdapter(Query, Ayuda.ObtenerConexion());
            //se indica con quu tabla se llena
            dad.Fill(ds, "no_cuenta");
            cbo_ctn_bac.DataSource = ds.Tables[0].DefaultView;
            //indicamos el valor de los miembros
            cbo_ctn_bac.ValueMember = ("no_cuenta");
            //se indica el valor a desplegar en el combobox
            DataTable dt = ds.Tables[0];
            dt.Columns.Add("NewColumn", typeof(string));
            foreach (DataRow dr in dt.Rows)
            {
                dr["no_cuenta"] = dr["no_cuenta"].ToString();
            }
            cbo_ctn_bac.DataSource = dt;
            cbo_ctn_bac.DisplayMember = "no_cuenta";

            llenarsaldo();
            llenarsaldon();

        }

        public void llenarsaldo() {
            
            //MessageBox.Show(cbo_cuenta_bancaria_nc.SelectedValue.ToString());
            string nom_banc = cbo_cuenta_bancaria_nc.SelectedValue.ToString();
            //se realiza la conexión a la base de datos
            Ayuda.ObtenerConexion();
            //se inicia un DataSet
            DataSet ds = new DataSet();
            //se indica la consulta en sql
            String Query = "select distinct saldo_libros from cuenta_bancaria where nombre_banco = '" + nom_banc + "'";
            OdbcDataAdapter dad = new OdbcDataAdapter(Query, Ayuda.ObtenerConexion());
            //se indica con quu tabla se llena
            dad.Fill(ds, "saldo_libros");
            cbo_saldo_c.DataSource = ds.Tables[0].DefaultView;
            //indicamos el valor de los miembros
            cbo_saldo_c.ValueMember = ("saldo_libros");
            //se indica el valor a desplegar en el combobox
            DataTable dt = ds.Tables[0];
            dt.Columns.Add("NewColumn", typeof(string));
            foreach (DataRow dr in dt.Rows)
            {
                dr["saldo_libros"] = dr["saldo_libros"].ToString();
            }
            cbo_saldo_c.DataSource = dt;
            cbo_saldo_c.DisplayMember = "saldo_libros";
        }


        public void llenarsaldon()
        {
            
            //MessageBox.Show(cbo_cuenta_bancaria_nc.SelectedValue.ToString());
            string nom_banc = cbo_cuenta_bancaria_nc.SelectedValue.ToString();
            //se realiza la conexión a la base de datos
            Ayuda.ObtenerConexion();
            //se inicia un DataSet
            DataSet ds = new DataSet();
            //se indica la consulta en sql
            String Query = "select distinct saldo_bancarios from cuenta_bancaria where nombre_banco = '" + nom_banc + "'";
            OdbcDataAdapter dad = new OdbcDataAdapter(Query, Ayuda.ObtenerConexion());
            //se indica con quu tabla se llena
            dad.Fill(ds, "saldo_bancarios");
            cbo_saldo_nc.DataSource = ds.Tables[0].DefaultView;
            //indicamos el valor de los miembros
            cbo_saldo_nc.ValueMember = ("saldo_bancarios");
            //se indica el valor a desplegar en el combobox
            DataTable dt = ds.Tables[0];
            dt.Columns.Add("NewColumn", typeof(string));
            foreach (DataRow dr in dt.Rows)
            {
                dr["saldo_bancarios"] = dr["saldo_bancarios"].ToString();
            }
            cbo_saldo_nc.DataSource = dt;
            cbo_saldo_nc.DisplayMember = "saldo_bancarios";
         
        }


        public void llenarCboDocts() {
            //se realiza la conexión a la base de datos
            Ayuda.ObtenerConexion();
            //se inicia un DataSet
            DataSet ds = new DataSet();
            //se indica la consulta en sql
            String Query = "select distinct nombre_documento from tipo_documento";
            OdbcDataAdapter dad = new OdbcDataAdapter(Query, Ayuda.ObtenerConexion());
            //se indica con quu tabla se llena
            dad.Fill(ds, "nombre_documento");
            cbo_tp_doct.DataSource = ds.Tables[0].DefaultView;
            //indicamos el valor de los miembros
            cbo_tp_doct.ValueMember = ("nombre_documento");
            //se indica el valor a desplegar en el combobox
            DataTable dt = ds.Tables[0];
            dt.Columns.Add("NewColumn", typeof(string));
            foreach (DataRow dr in dt.Rows)
            {
                dr["nombre_documento"] = dr["nombre_documento"].ToString();
            }
            cbo_tp_doct.DataSource = dt;
            cbo_tp_doct.DisplayMember = "nombre_documento";
        }

        private void cbo_tp_doct_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {
            string banco = cbo_ctn_bac.SelectedValue.ToString();
            string cuenta = cbo_cuenta_bancaria_nc.SelectedValue.ToString();
            string t_documento = cbo_tp_doct.SelectedValue.ToString();
            string fecha = dateTimePicker1.Text;
            MessageBox.Show(t_documento);

            string tabla = "documento";
            fn.ActualizarGrid(this.dtg_disp_bancaria, "SELECT DISTINCT documento.id_documento_pk, tipo_documento.nombre_documento, documento.fecha, documento.valor_total, documento.destinatario, documento.descripcion FROM documento, tipo_documento WHERE documento.id_tipo_documento = tipo_documento.id_tipo_documento AND tipo_documento.nombre_documento = '"+t_documento+"' ", tabla);

            sumaConciliado();
        }

        public void sumaConciliado()
        {
            string t_documento = cbo_tp_doct.SelectedValue.ToString();
            //se realiza la conexión a la base de datos
            Ayuda.ObtenerConexion();
            //se indica la consulta en sql
            String Query1 = "SELECT SUM(documento.valor_total) FROM documento, tipo_documento WHERE documento.id_tipo_documento = tipo_documento.id_tipo_documento AND tipo_documento.id_tipo_documento = '"+t_documento+"'";
            
            //string nombre;
            OdbcCommand Query = new OdbcCommand();
            OdbcConnection Conexion;
            OdbcDataReader consultar;
            string sql = "dsn=hotelsancarlos; server=localhost; database=hotelsancarlos; uid=root; pwd=;";
            Conexion = new OdbcConnection();
            Conexion.ConnectionString = sql;
            Conexion.Open();
            Query.CommandText = Query1;
            Query.Connection = Conexion;
            consultar = Query.ExecuteReader();

            while (consultar.Read())
            {

               // string total = consultar.GetDecimal(0).ToString(); 
               // MessageBox.Show(total);
                //txt_ref.Text = total.ToString();
            }

        }

        private void cbo_ctn_bac_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenarsaldo();
            llenarsaldon();
        }
    }
}
