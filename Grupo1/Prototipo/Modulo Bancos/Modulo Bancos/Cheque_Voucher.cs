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
using FuncionesNavegador;
namespace Modulo_Bancos
{
    public partial class Cheque_Voucher : Form
    {
        public Cheque_Voucher()
        {
            InitializeComponent();
        }
        CapaNegocio fn = new CapaNegocio();
        String Codigo;
        Boolean Editar;
        String atributo;
        private void Cheque_Voucher_Load(object sender, EventArgs e)
        {
            fn.InhabilitarComponentes(gpb_cheque_v);
            fn.InhabilitarComponentes(this);
            llenardocuemnto();
        }
        int id;
        int id2;
        int id3;
        int cont2 = 1;
        string cadena1;
        decimal cadena2;
        private void llenardocuemnto()
        {

            //se realiza la conexión a la base de datos
            Ayuda.ObtenerConexion();
            //se inicia un DataSet
            DataSet ds = new DataSet();
            //se indica la consulta en sql
            String Query = "select id_documento_pk, no_documento from documento";
            OdbcDataAdapter dad = new OdbcDataAdapter(Query, Ayuda.ObtenerConexion());
            //se indica con quu tabla se llena
            dad.Fill(ds, "documento");
            cbo_doc.DataSource = ds.Tables[0].DefaultView;
            //indicamos el valor de los miembros
            cbo_doc.ValueMember = ("id_documento_pk");
            //se indica el valor a desplegar en el combobox
            cbo_doc.DisplayMember = ("no_documento");
            Ayuda.Desconectar();
        }

        public void documento()
        {

            OdbcCommand Query = new OdbcCommand();
            OdbcConnection Conexion;
            OdbcDataReader consultar;
            string sql = "dsn=hotelsancarlos;server=localhost;user id=root;database=hotelsancarlos;password=";
            Conexion = new OdbcConnection();
            Conexion.ConnectionString = sql;
            Conexion.Open();
            Query.CommandText = "SELECT id_documento_pk, descripcion,valor_total,id_cuenta_bancaria_pk From documento where no_documento = '" + cbo_doc.Text + "';";
            Query.Connection = Conexion;
            consultar = Query.ExecuteReader();
            while (consultar.Read())
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                id = consultar.GetInt32(0);
                cadena1 = consultar.GetString(1);
                cadena2 = consultar.GetDecimal(2);
                id2 = consultar.GetInt32(3);

                txt_monto.Text = Convert.ToString(cadena2);
                //MessageBox.Show(Convert.ToString(id2));
            }


        }
        public void cuenta()
        {

            int no_c = 0;
            OdbcConnection Conexion2;
            OdbcCommand Query2 = new OdbcCommand();
            OdbcDataReader consultar2;
            string sql = "dsn=hotelsancarlos;server=localhost;user id=root;database=hotelsancarlos;password=";
            Conexion2 = new OdbcConnection();
            Conexion2.ConnectionString = sql;
            Conexion2.Open();
            Query2.CommandText = "SELECT no_cuenta, id_empresa_pk From cuenta_bancaria where id_cuenta_bancaria_pk = '" + id2 + "';";
            Query2.Connection = Conexion2;
            consultar2 = Query2.ExecuteReader();
            while (consultar2.Read())
            {
                no_c = consultar2.GetInt32(0);
                id3 = consultar2.GetInt32(1);
                txt_cuenta.Text = Convert.ToString(no_c);

            }
        }
        public void empresa()
        {
            string nombre;
            OdbcCommand Query = new OdbcCommand();
            OdbcConnection Conexion;
            OdbcDataReader consultar;
            string sql = "dsn=hotelsancarlos;server=localhost;user id=root;database=hotelsancarlos;password=";
            Conexion = new OdbcConnection();
            Conexion.ConnectionString = sql;
            Conexion.Open();
            Query.CommandText = "SELECT nombre From empresa where id_empresa_pk = '" + id3 + "';";
            Query.Connection = Conexion;
            consultar = Query.ExecuteReader();

            while (consultar.Read())
            {

                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                cont2 = 1;

                nombre = consultar.GetString(0);
                txt_empresa.Text = nombre;
                // MessageBox.Show(Convert.ToString(id));
            }
            dataGridView1.Rows.Add(1);
        }
       

        private void cbo_doc_SelectedIndexChanged(object sender, EventArgs e)
        {
            documento();
            cuenta();
            empresa();

            dataGridView1.Rows[0].Cells[0].Value = id;
            dataGridView1.Rows[0].Cells[1].Value = cadena1;
            dataGridView1.Rows[0].Cells[3].Value = cadena2;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(1);
            dataGridView1.Rows[cont2].Cells[1].Value = txt_detalle.Text;
            dataGridView1.Rows[cont2].Cells[2].Value = Convert.ToDecimal(txt_cantida.Text);
            txt_cantida.Text = "";
            txt_detalle.Text = "";
            cont2++;
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            try
            {
                Editar = false;
                fn.ActivarControles(gpb_cheque_v);
                fn.LimpiarComponentes(gpb_cheque_v);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            try
            {
                Editar = false;
                fn.LimpiarComponentes(gpb_cheque_v);
                fn.InhabilitarComponentes(gpb_cheque_v);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {


            for (int fila = 0; fila < dataGridView1.RowCount - 1; fila++)
            {
                string fecha = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                Ayuda.ObtenerConexion();
                //string selectedItem = cbo_empres.SelectedValue.ToString();
                String Query = "INSERT INTO detalle_documentos (nombre_cuenta,detalle,debe,haber,fecha,id_documento_pk) VALUES ('" + txt_ref.Text+ "','" + dataGridView1.Rows[fila].Cells[1].Value + "','" + Convert.ToDecimal(dataGridView1.Rows[fila].Cells[2].Value) + "','" + Convert.ToDecimal(dataGridView1.Rows[fila].Cells[3].Value) + "','" + fecha + "','"+Convert.ToInt32(dataGridView1.Rows[0].Cells[0].Value)+"') ";
                Ayuda.EjecutarMySql(Query);
                //String bitacora = "INSERT INTO bitacora_de_control (fecha_accion_bitc, accion_bitc, usuario_conn_bitc, ip_usuario_bitc, tabla_modif_bitc,id_usuario_activo) VALUE (NOW(), 'Ingresar','" + Usuario + "','" + obtenerIP() + "', 'area_laboratorio'," + MiIdUsuario + ") ";
                //Conexionmysql.EjecutarMySql(bitacora);
                //ActualizarGrid(this.dataGridView1, "select pk_id_area_lab as ID_Area, descripcion_ar_lab as Descripcion, pk_id_lab as ID_Laboratorio from area_laboratorio");
                //this.LimpiarCajasTexto();
                Ayuda.Desconectar();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            decimal suma = 0;
            for (int fila = 0; fila < dataGridView1.RowCount - 1; fila++)
            {
                suma += Convert.ToDecimal(dataGridView1.Rows[fila].Cells[2].Value);

            }


            if (suma > Convert.ToDecimal(dataGridView1.Rows[0].Cells[3].Value))
            {
                dataGridView1.Rows[cont2].Cells[2].Value = suma;
                dataGridView1.Rows[cont2].Cells[2].Style.BackColor = Color.Red;
                dataGridView1.Rows[cont2].Cells[3].Value = dataGridView1.Rows[0].Cells[3].Value;
                dataGridView1.Rows[cont2].Cells[3].Style.BackColor = Color.Red;
            }
            else if (suma < Convert.ToDecimal(dataGridView1.Rows[0].Cells[3].Value))
            {
                dataGridView1.Rows[cont2].Cells[2].Value = suma;
                dataGridView1.Rows[cont2].Cells[2].Style.BackColor = Color.Red;
                dataGridView1.Rows[cont2].Cells[3].Value = dataGridView1.Rows[0].Cells[3].Value;
                dataGridView1.Rows[cont2].Cells[3].Style.BackColor = Color.Red;
            }
            else
            {
                dataGridView1.Rows[cont2].Cells[2].Value = suma;
                dataGridView1.Rows[cont2].Cells[3].Value = dataGridView1.Rows[0].Cells[3].Value;
                dataGridView1.Rows[cont2].Cells[2].Style.BackColor = Color.Green;
                dataGridView1.Rows[cont2].Cells[3].Style.BackColor = Color.Green;
            }
            //MessageBox.Show(Convert.ToString(suma));
        }
    }
}
