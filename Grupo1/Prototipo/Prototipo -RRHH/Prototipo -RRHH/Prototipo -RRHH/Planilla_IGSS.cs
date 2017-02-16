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
using MySql.Data.MySqlClient;

namespace Prototipo__RRHH
{
    public partial class Planilla_IGSS : Form
    {
        public Planilla_IGSS(DataGridView dt)
        {
            this.data = dt;
            InitializeComponent();
        }

        String Codigo;
        Boolean Editar=false;
        String atributo;
        DataGridView data;

        CapaNegocio fn = new CapaNegocio();

        private void Planilla_IGSS_Load(object sender, EventArgs e)
        {
            fn.InhabilitarComponentes(gpb_planilla_igss);
            fn.InhabilitarComponentes(this);
            llenaridempresa();
            llenarigss();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            try
            {
                Editar = false;
                fn.ActivarControles(gpb_planilla_igss);
                fn.LimpiarComponentes(gpb_planilla_igss);
                cbo_igss.Text = "";
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
                fn.LimpiarComponentes(gpb_planilla_igss);
                fn.InhabilitarComponentes(gpb_planilla_igss);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void llenaridempresa()
        {

            //se realiza la conexión a la base de datos
            Conexionmysql.ObtenerConexion();
            //se inicia un DataSet
            DataSet ds = new DataSet();
            //se indica la consulta en sql
            String Query = "select id_empresa_pk, nombre from empresa";
            OdbcDataAdapter dad = new OdbcDataAdapter(Query, Conexionmysql.ObtenerConexion());
            //se indica con quu tabla se llena
            dad.Fill(ds, "empresa");
            cbo_empres.DataSource = ds.Tables[0].DefaultView;
            //indicamos el valor de los miembros
            cbo_empres.ValueMember = ("id_empresa_pk");
            //se indica el valor a desplegar en el combobox
            cbo_empres.DisplayMember = ("nombre");
            Conexionmysql.Desconectar();
            
        }

        private void llenarigss()
        {
            string selectedItem = cbo_empres.SelectedValue.ToString();
            //se realiza la conexión a la base de datos
            Conexionmysql.ObtenerConexion();
            //se inicia un DataSet
            DataSet ds = new DataSet();
            //se indica la consulta en sql
            String Query = "select id_planilla_igss_pk, porcentaje_igss from planilla_igss where id_empresa_pk ='" + selectedItem + "' AND estado <>'INACTIVO'";
            OdbcDataAdapter dad = new OdbcDataAdapter(Query, Conexionmysql.ObtenerConexion());
            //se indica con quu tabla se llena
            dad.Fill(ds, "planilla_igss");
            cbo_igss.DataSource = ds.Tables[0].DefaultView;
            //indicamos el valor de los miembros
            cbo_igss.ValueMember = ("id_planilla_igss_pk");
            //se indica el valor a desplegar en el combobox
            cbo_igss.DisplayMember = ("porcentaje_igss");
            Conexionmysql.Desconectar();
        }

        decimal cuota_pa = 0;
        public void igss()
        {
            decimal por = 0;
            string selectedItem = cbo_igss.SelectedValue.ToString();
            OdbcCommand Query = new OdbcCommand();
            OdbcConnection Conexion;
            OdbcDataReader consultar;
            string sql = "dsn=hotelsancarlos;server=localhost;database=hotelsancarlos;uid=root;;password=";
            Conexion = new OdbcConnection();
            Conexion.ConnectionString = sql;
            Conexion.Open();
            Query.CommandText = "SELECT cuota_patronal From planilla_igss where id_planilla_igss_pk = '" + selectedItem + "';";
            Query.Connection = Conexion;
            consultar = Query.ExecuteReader();
            while (consultar.Read())
            {
                cuota_pa = consultar.GetDecimal(0);
                
                txt_cuota_pa.Text = Convert.ToString(cuota_pa);
                //MessageBox.Show(Convert.ToString(por));
            }

           
        }
        

        //int id;
        int id_emp;
        string nombre_emp;
        decimal sueldo_emp;
        //int id_igss;
        //string cadena1;
        //decimal cadena2;
        public void empleados2()
        {
            string selectedItem = cbo_empres.SelectedValue.ToString();
            int cont1 = 0;
            OdbcConnection Conexion2;
            OdbcCommand Query2 = new OdbcCommand();
            OdbcDataReader consultar2;
            string sql = "dsn=hotelsancarlos;server=localhost;database=hotelsancarlos;uid=root;;password=";
            Conexion2 = new OdbcConnection();
            Conexion2.ConnectionString = sql;
            Conexion2.Open();
            Query2.CommandText = "SELECT id_empleados_pk, nombre, sueldo From empleado where id_empresa_pk = '" +selectedItem + "' AND no_afiliacion_igss <> 'NO AFILIADO';";
            Query2.Connection = Conexion2;
            consultar2 = Query2.ExecuteReader();
            while (consultar2.Read())
            {

                if (cont1 == 0)
                {
                    dataGridView1.Rows.Add(1);
                    id_emp = consultar2.GetInt32(0);
                    nombre_emp = consultar2.GetString(1);
                    sueldo_emp = consultar2.GetDecimal(2);
                    //MessageBox.Show(cadena1);
                    dataGridView1.Rows[0].Cells[0].Value = id_emp;
                    dataGridView1.Rows[0].Cells[1].Value = nombre_emp;
                    dataGridView1.Rows[0].Cells[2].Value = sueldo_emp;
                }
                else
                {
                    dataGridView1.Rows.Add(1);
                    id_emp = consultar2.GetInt32(0);
                    nombre_emp = consultar2.GetString(1);
                    sueldo_emp = consultar2.GetDecimal(2);
                    // MessageBox.Show(cadena1);
                    dataGridView1.Rows[cont1].Cells[0].Value = id_emp;
                    dataGridView1.Rows[cont1].Cells[1].Value = nombre_emp;
                    dataGridView1.Rows[cont1].Cells[2].Value = sueldo_emp;
                }


                cont1 = cont1 + 1;
                // MessageBox.Show(Convert.ToString(cont1));
            }
        }
        /*
        public void sueldo()
        {
            int cont1 = 0;

            for (int fila = 0; fila < dataGridView1.RowCount; fila++)
            {
                int ca = Convert.ToInt32(dataGridView1.Rows[fila].Cells[0].Value);
                //MessageBox.Show(Convert.ToString(ca));
                OdbcConnection Conexion2;
                OdbcCommand Query2 = new OdbcCommand();
                OdbcDataReader consultar2;
                string sql = "dsn=hotelsancarlos;server=localhost;user id=root;database=hotelsancarlos;password=";
                Conexion2 = new OdbcConnection();
                Conexion2.ConnectionString = sql;
                Conexion2.Open();
                Query2.CommandText = "SELECT sueldo_base From detalle_nomina where id_empleados_pk = '" + Convert.ToString(ca) + "';";
                Query2.Connection = Conexion2;
                consultar2 = Query2.ExecuteReader();
                while (consultar2.Read())
                {

                    if (cont1 == 0)
                    {

                        cadena2 = consultar2.GetDecimal(0);
                        //MessageBox.Show(Convert.ToString(cadena2));
                        dataGridView1.Rows[0].Cells[3].Value = cadena2;
                    }
                    else
                    {

                        cadena2 = consultar2.GetDecimal(0);
                        //MessageBox.Show(Convert.ToString(cadena2));
                        dataGridView1.Rows[cont1].Cells[3].Value = cadena2;
                    }


                    cont1 = cont1 + 1;
                    // MessageBox.Show(Convert.ToString(cont1));
                }
            }
        }*/
        /*
        public void emplea()
        {

            OdbcCommand Query = new OdbcCommand();
            OdbcConnection Conexion;
            OdbcDataReader consultar;
            string sql = "dsn=hotelsancarlos;server=localhost;user id=root;database=hotelsancarlos;password=";
            Conexion = new OdbcConnection();
            Conexion.ConnectionString = sql;
            Conexion.Open();
            Query.CommandText = "SELECT id_empresa_pk From empresa where nombre = '" + cbo_empres.Text + "';";
            Query.Connection = Conexion;
            consultar = Query.ExecuteReader();
            while (consultar.Read())
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                id = consultar.GetInt32(0);
                // MessageBox.Show(Convert.ToString(id));
            }

        }
        */
        public void ActualizarGrid(DataGridView dg, String Query)
        {
            Conexionmysql.ObtenerConexion();
            //crear DataSet
            System.Data.DataSet MiDataSet = new System.Data.DataSet();
            //Crear Adaptador de datos
            OdbcDataAdapter MiDataAdapter = new OdbcDataAdapter(Query, Conexionmysql.ObtenerConexion());
            //LLenar el DataSet
            MiDataAdapter.Fill(MiDataSet, "detalle_planilla_igss");
            //Asignarle el valor adecuado a las propiedades del DataGrid
            dg.DataSource = MiDataSet;
            dg.DataMember = "detalle_planilla_igss";
            //nos desconectamos de la base de datos...
            Conexionmysql.Desconectar();
        }
        private void btn_generar_Click(object sender, EventArgs e)
        {
            //dataGridView1.Rows.Clear();
            //dataGridView1.Refresh();
            // emplea();
            //empleados2();
            //igss();
            //sueldo();

            calcular_igss();
            calcular_cp();
            totales();
            /*
            
            */
            //string selectedItem = cbo_empres.SelectedValue.ToString();
            //ActualizarGrid(this.dataGridView1, "SELECT E.nombre, EMP.nombre, DN.sueldo_base, DP.igss_pagar FROM empleado EMP, empresa E, detalle_nomina DN, detalle_planilla_igss DP WHERE ( DP.id_empleados_pk = EMP.id_empleados_pk AND DN.id_empleados_pk = EMP.id_empleados_pk AND E.id_empresa_pk = '"+selectedItem+"')");
        }
        public void calcular_cp()
        {
            double cuota_patro;

            for (int fila = 0; fila < dataGridView1.RowCount - 1; fila++)
            {
                cuota_patro = Convert.ToDouble(dataGridView1.Rows[fila].Cells[2].Value) * (Convert.ToDouble(txt_cuota_pa.Text) / 100);
                dataGridView1.Rows[fila].Cells[4].Value = cuota_patro;
            }
        }

        public void calcular_igss()
        {
            double igss_total;

            for (int fila = 0; fila < dataGridView1.RowCount - 1; fila++)
            {
                igss_total = Convert.ToDouble(dataGridView1.Rows[fila].Cells[2].Value) * (Convert.ToDouble(cbo_igss.Text) / 100);
                dataGridView1.Rows[fila].Cells[3].Value = igss_total;
            }
        }

        public void totales()
        {
            decimal total_igss;

            for (int fila = 0; fila < dataGridView1.RowCount - 1; fila++)
            {
                total_igss= Convert.ToDecimal(dataGridView1.Rows[fila].Cells[3].Value) + Convert.ToDecimal(dataGridView1.Rows[fila].Cells[4].Value);
                dataGridView1.Rows[fila].Cells[5].Value = total_igss;
            }
        }

        private void btn_guardar_Click_1(object sender, EventArgs e)
        {

            for (int fila = 0; fila < dataGridView1.RowCount - 1; fila++)
            {
                //textBox4.Text = comboBox1.SelectedValue.ToString();
                string selectedItem = cbo_igss.SelectedValue.ToString();
                textBox4.Text = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                textBox1.Text = Convert.ToString(dataGridView1.Rows[fila].Cells[0].Value);
                textBox2.Text = Convert.ToString(dataGridView1.Rows[fila].Cells[2].Value);
                textBox3.Text = Convert.ToString(dataGridView1.Rows[fila].Cells[5].Value);
                textBox5.Text = selectedItem;
                CapaNegocio fn = new CapaNegocio();
                TextBox[] textbox = { textBox1, textBox2, textBox3, textBox4, textBox5};
                DataTable datos = fn.construirDataTable(textbox);
                if (datos.Rows.Count == 0)
                {
                    //MessageBox.Show("Hay campos vacios", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string tabla = "detalle_planilla_igss";
                    if (Editar)
                    {
                        fn.modificar(datos, tabla, atributo, Codigo);
                    }
                    else
                    {
                        fn.insertar(datos, tabla);
                    }
                    fn.LimpiarComponentes(this);
                }
            }

                
                /*

                for (int fila = 0; fila < dataGridView1.RowCount - 1; fila++)
                {
                    string fecha = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                    Conexionmysql.ObtenerConexion();
                    string selectedItem = cbo_empres.SelectedValue.ToString();
                    String Query = "INSERT INTO detalle_planilla_igss (id_planilla_igss_pk,id_empleados_pk,sueldo_base, igss_pagar,fecha) VALUES ('" + 1 + "','" + dataGridView1.Rows[fila].Cells[0].Value + "','" + dataGridView1.Rows[fila].Cells[3].Value + "','" + dataGridView1.Rows[fila].Cells[4].Value + "','" + fecha + "') ";
                    Conexionmysql.EjecutarMySql(Query);
                    //String bitacora = "INSERT INTO bitacora_de_control (fecha_accion_bitc, accion_bitc, usuario_conn_bitc, ip_usuario_bitc, tabla_modif_bitc,id_usuario_activo) VALUE (NOW(), 'Ingresar','" + Usuario + "','" + obtenerIP() + "', 'area_laboratorio'," + MiIdUsuario + ") ";
                    //Conexionmysql.EjecutarMySql(bitacora);
                    //ActualizarGrid(this.dataGridView1, "select pk_id_area_lab as ID_Area, descripcion_ar_lab as Descripcion, pk_id_lab as ID_Laboratorio from area_laboratorio");
                    //this.LimpiarCajasTexto();
                    Conexionmysql.Desconectar();
                }*/
          }

        private void cbo_empres_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenarigss();
            
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            // emplea();
            empleados2();
        }

        private void cbo_igss_SelectedIndexChanged(object sender, EventArgs e)
        {
            igss();
        }

        private void btn_cancelar_Click_1(object sender, EventArgs e)
        {
            try
            {
                Editar = false;
                fn.LimpiarComponentes(gpb_planilla_igss);
                fn.InhabilitarComponentes(gpb_planilla_igss);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {

        }
    }
}
