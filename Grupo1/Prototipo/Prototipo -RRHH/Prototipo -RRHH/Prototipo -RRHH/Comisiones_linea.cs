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
using MySql.Data.MySqlClient;
using System.Data.Odbc;

namespace Prototipo__RRHH
{
    public partial class Comisiones_linea : Form
    {
        public Comisiones_linea()
        {
            InitializeComponent();
        }
        CapaNegocio fn = new CapaNegocio();
        String Codigo;
        Boolean Editar;
        String atributo;
        int id_fact;
        decimal total;
        private static string id_form = "13201";
        //bitacora bita = new bitacora();
        //DataTable seg = seguridad.ObtenerPermisos.Permisos(seguridad.Conexion.User, id_form);
        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            try
            {
                Editar = false;
                fn.ActivarControles(gpb_com_ven);
                fn.LimpiarComponentes(gpb_com_ven);
                dateTimePicker2.Enabled = false;
                dateTimePicker3.Enabled = false;
                button1.Enabled = false;
                txt_total_com.Enabled = false;
                txt_venta.Enabled = false;
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
                fn.LimpiarComponentes(gpb_com_ven);
                fn.InhabilitarComponentes(gpb_com_ven);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Comisiones_linea_Load(object sender, EventArgs e)
        {
            fn.InhabilitarComponentes(gpb_com_ven);
            fn.InhabilitarComponentes(this);
            llenaridempresa();
            llenarvendedor();
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
        }

        private void llenaridempresa()
        {

            //se realiza la conexión a la base de datos
            Conexionmysql.ObtenerConexion();
            //se inicia un DataSet
            DataSet ds = new DataSet();
            //se indica la consulta en sql
            String Query = "select id_empresa_pk, nombre from empresa Where estado <>'INACTIVO'";
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

        private void llenarvendedor()
        {

            string selectedItem = cbo_empres.SelectedValue.ToString();
            //se realiza la conexión a la base de datos
            Conexionmysql.ObtenerConexion();
            //se inicia un DataSet
            DataSet ds = new DataSet();
            //se indica la consulta en sql=
            String Query = "select id_empleados_pk, nombre from empleado where id_empresa_pk ='" + selectedItem + "' AND estado <> 'INACTIVO' AND cargo ='Vendedor' AND cargo = 'VENDEDOR'";
            OdbcDataAdapter dad = new OdbcDataAdapter(Query, Conexionmysql.ObtenerConexion());
            //se indica con quu tabla se llena
            dad.Fill(ds, "empleado");
            cbo_empleado.DataSource = ds.Tables[0].DefaultView;
            //indicamos el valor de los miembros
            cbo_empleado.ValueMember = ("id_empleados_pk");
            //se indica el valor a desplegar en el combobox
            cbo_empleado.DisplayMember = ("nombre");
            Conexionmysql.Desconectar();
        }

        private void btn_emp_Click(object sender, EventArgs e)
        {
            cbo_empleado.Text = "  ";
            llenarvendedor();

        }


        public void factura()
        {
            int cont1 = 0;
            string selectedItem = cbo_empres.SelectedValue.ToString();
            string selectedItem2 = cbo_empleado.SelectedValue.ToString();
            string date1 = dateTimePicker2.Value.ToString("yyyy-MM-dd");
            string date2 = dateTimePicker3.Value.ToString("yyyy-MM-dd");
            OdbcCommand Query = new OdbcCommand();
            OdbcConnection Conexion;
            OdbcDataReader consultar;
            //string sql = "dsn=hotelsancarlos;server=localhost;user id=root;database=hotelsancarlos;password=";
            string sql = "dsn=hotelsancarlos;server=localhost;database=hotelsancarlos;uid=root;password=";
            Conexion = new OdbcConnection();
            Conexion.ConnectionString = sql;
            Conexion.Open();
            Query.CommandText = "SELECT id_fac_empresa_pk,total From factura where id_empleados_pk = '" + selectedItem2 + "'And id_empresa_pk ='" + selectedItem + "' AND estado <> 'INACTIVO' AND marca_comision <>'S' AND fecha_emision BETWEEN '" + date1 + "' AND '" + date2 + "';";
            Query.Connection = Conexion;
            consultar = Query.ExecuteReader();

            while (consultar.Read())
            {
                dataGridView1.Rows.Add(1);
                if (cont1 == 0)
                {
                    id_fact = consultar.GetInt32(0);
                    total = consultar.GetDecimal(1);
                    dataGridView1.Rows[0].Cells[0].Value = id_fact;
                    dataGridView1.Rows[0].Cells[1].Value = total;
                    // MessageBox.Show(Convert.ToString(id));
                }
                else
                {

                    id_fact = consultar.GetInt32(0);
                    total = consultar.GetDecimal(1);
                    dataGridView1.Rows[cont1].Cells[0].Value = id_fact;
                    dataGridView1.Rows[cont1].Cells[1].Value = total;
                }
                cont1++;
            }
        }

        int id_precio;
        int cantidad = 0;
        public void factura_detalle()
        {

            int cont1 = 0;

            for (int fila = 0; fila < dataGridView1.RowCount; fila++)
            {
                int ca = Convert.ToInt32(dataGridView1.Rows[fila].Cells[0].Value);
                string selectedItem = cbo_empres.SelectedValue.ToString();
                string selectedItem2 = cbo_empleado.SelectedValue.ToString();
                OdbcCommand Query = new OdbcCommand();
                OdbcConnection Conexion;
                OdbcDataReader consultar;
               // string sql = "dsn=hotelsancarlos;server=localhost;user id=root;database=hotelsancarlos;password=";
                string sql = "dsn=hotelsancarlos;server=localhost;database=hotelsancarlos;uid=root;password=";
                Conexion = new OdbcConnection();
                Conexion.ConnectionString = sql;
                Conexion.Open();
                Query.CommandText = "SELECT id_precio, cantidad From factura_detalle where id_fac_empresa_pk ='" + Convert.ToString(ca) + "';";
                Query.Connection = Conexion;
                consultar = Query.ExecuteReader();

                while (consultar.Read())
                {
                    if (cont1 == 0)
                    {

                        id_precio = consultar.GetInt32(0);
                        cantidad = consultar.GetInt32(1);
                        //MessageBox.Show(Convert.ToString(cadena2));
                        dataGridView1.Rows[0].Cells[2].Value = id_precio;
                        dataGridView1.Rows[0].Cells[5].Value = cantidad;
                    }
                    else
                    {

                        id_precio = consultar.GetInt32(0);
                        cantidad = consultar.GetInt32(1);
                        //MessageBox.Show(Convert.ToString(cadena2));
                        dataGridView1.Rows[cont1].Cells[2].Value = id_precio;
                        dataGridView1.Rows[cont1].Cells[5].Value = cantidad;
                    }
                    cont1 = cont1 + 1;
                }
            }
        }

        decimal precio_pro = 0;
        int id_bien = 0;
        public void precio()
        {

            int cont1 = 0;

            for (int fila = 0; fila < dataGridView1.RowCount; fila++)
            {
                int ca = Convert.ToInt32(dataGridView1.Rows[fila].Cells[2].Value);

                OdbcCommand Query = new OdbcCommand();
                OdbcConnection Conexion;
                OdbcDataReader consultar;
                //string sql = "dsn=hotelsancarlos;server=localhost;user id=root;database=hotelsancarlos;password=";
                string sql = "dsn=hotelsancarlos;server=localhost;database=hotelsancarlos;uid=root;password=";
                Conexion = new OdbcConnection();
                Conexion.ConnectionString = sql;
                Conexion.Open();
                Query.CommandText = "SELECT precio, id_bien_pk From precio where id_precio ='" + Convert.ToString(ca) + "';";
                Query.Connection = Conexion;
                consultar = Query.ExecuteReader();

                while (consultar.Read())
                {
                    if (cont1 == 0)
                    {

                        precio_pro = consultar.GetDecimal(0);
                        id_bien = consultar.GetInt32(1);
                        //MessageBox.Show(Convert.ToString(id_bien));
                        dataGridView1.Rows[0].Cells[4].Value = precio_pro;
                        dataGridView1.Rows[0].Cells[6].Value = id_bien;
                    }
                    else
                    {

                        precio_pro = consultar.GetDecimal(0);
                        id_bien = consultar.GetInt32(1);
                        // MessageBox.Show(Convert.ToString(id_bien));
                        dataGridView1.Rows[cont1].Cells[4].Value = precio_pro;
                        dataGridView1.Rows[cont1].Cells[6].Value = id_bien;
                    }
                    cont1 = cont1 + 1;
                }
            }
        }

        //decimal proce_pro = 0;
        string descrp;
        int marca_pk = 0;
        public void bien()
        {

            int cont1 = 0;

            for (int fila = 0; fila < dataGridView1.RowCount; fila++)
            {
                int ca = Convert.ToInt32(dataGridView1.Rows[fila].Cells[6].Value);

                OdbcCommand Query = new OdbcCommand();
                OdbcConnection Conexion;
                OdbcDataReader consultar;
                //string sql = "dsn=hotelsancarlos;server=localhost;user id=root;database=hotelsancarlos;password=";
                string sql = "dsn=hotelsancarlos;server=localhost;database=hotelsancarlos;uid=root;password=";
                Conexion = new OdbcConnection();
                Conexion.ConnectionString = sql;
                Conexion.Open();
                Query.CommandText = "SELECT descripcion, id_marca_pk From bien where id_bien_pk ='" + Convert.ToString(ca) + "';";
                Query.Connection = Conexion;
                consultar = Query.ExecuteReader();

                while (consultar.Read())
                {
                    if (cont1 == 0)
                    {

                        descrp = consultar.GetString(0);
                        //proce_pro = consultar.GetDecimal(1);
                        marca_pk = consultar.GetInt32(1);
                        dataGridView1.Rows[0].Cells[3].Value = descrp;
                        //MessageBox.Show(Convert.ToString(precio_pro));
                        dataGridView1.Rows[0].Cells[7].Value = marca_pk;


                    }
                    else
                    {
                        descrp = consultar.GetString(0);
                        marca_pk = consultar.GetInt32(1);
                        //proce_pro = consultar.GetDecimal(1);
                        dataGridView1.Rows[cont1].Cells[3].Value = descrp;
                        //MessageBox.Show(Convert.ToString(precio_pro));
                        dataGridView1.Rows[cont1].Cells[7].Value = marca_pk;

                    }
                    cont1 = cont1 + 1;
                }
            }
        }
        string linea_desc;
        decimal porc_linea = 0;
        public void linea()
        {

            int cont1 = 0;

            for (int fila = 0; fila < dataGridView1.RowCount; fila++)
            {
                int ca = Convert.ToInt32(dataGridView1.Rows[fila].Cells[7].Value);

                OdbcCommand Query = new OdbcCommand();
                OdbcConnection Conexion;
                OdbcDataReader consultar;
                //string sql = "dsn=hotelsancarlos;server=localhost;user id=root;database=hotelsancarlos;password=";
                string sql = "dsn=hotelsancarlos;server=localhost;database=hotelsancarlos;uid=root;password=";
                Conexion = new OdbcConnection();
                Conexion.ConnectionString = sql;
                Conexion.Open();
                Query.CommandText = "SELECT nombre_linea, porcentaje_comision From linea where id_linea_pk ='" + Convert.ToString(ca) + "';";
                Query.Connection = Conexion;
                consultar = Query.ExecuteReader();

                while (consultar.Read())
                {
                    if (cont1 == 0)
                    {

                        linea_desc = consultar.GetString(0);
                        //proce_pro = consultar.GetDecimal(1);
                        porc_linea = consultar.GetDecimal(1);
                        dataGridView1.Rows[0].Cells[8].Value = linea_desc;
                        //MessageBox.Show(Convert.ToString(precio_pro));
                        dataGridView1.Rows[0].Cells[9].Value = porc_linea;


                    }
                    else
                    {
                        linea_desc = consultar.GetString(0);
                        porc_linea = consultar.GetDecimal(1);
                        //proce_pro = consultar.GetDecimal(1);
                        dataGridView1.Rows[cont1].Cells[8].Value = linea_desc;
                        //MessageBox.Show(Convert.ToString(precio_pro));
                        dataGridView1.Rows[cont1].Cells[9].Value = porc_linea;

                    }
                    cont1 = cont1 + 1;
                }
            }
        }
        public void comision()
        {

            decimal total_comision = 0;
            for (int fila = 0; fila < dataGridView1.RowCount - 1; fila++)
            {

                total_comision = Convert.ToDecimal(dataGridView1.Rows[fila].Cells[10].Value) * ((Convert.ToDecimal(dataGridView1.Rows[fila].Cells[9].Value) / 100));
                dataGridView1.Rows[fila].Cells[11].Value = Math.Round(total_comision,2);
            }

        }

        public void totales()
        {
            decimal total_venta = 0;

            for (int fila = 0; fila < dataGridView1.RowCount - 1; fila++)
            {

                total_venta = Convert.ToDecimal(dataGridView1.Rows[fila].Cells[4].Value) * Convert.ToDecimal(dataGridView1.Rows[fila].Cells[5].Value);
                dataGridView1.Rows[fila].Cells[10].Value = Math.Round(total_venta,2);
            }

            //txt_total_com.Text = Convert.ToString(total_comi);
            //txt_venta.Text = Convert.ToString(total_venta);

        }


        private void cbo_empres_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbo_empleado.Text = "  ";
            llenarvendedor();
        }

        public void comision_total()
        {
            decimal comision_t = 0;
            for (int fila = 0; fila < dataGridView1.RowCount - 1; fila++)
            {

                comision_t += Convert.ToDecimal(dataGridView1.Rows[fila].Cells[11].Value);

            }
            txt_total_com.Text = Convert.ToString(comision_t);

        }
        public void venta_total()
        {
            decimal venta_t = 0;
            for (int fila = 0; fila < dataGridView1.RowCount - 1; fila++)
            {

                venta_t += Convert.ToDecimal(dataGridView1.Rows[fila].Cells[10].Value);

            }
            txt_venta.Text = Convert.ToString(venta_t);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            factura();
            factura_detalle();
            precio();
            bien();
            linea();
            totales();
            comision();
            venta_total();
            comision_total();
        }
        public void guardar_detalle()
        {
            string selectedItem = cbo_empres.SelectedValue.ToString();
            string selectedItem2 = cbo_empleado.SelectedValue.ToString();
            textBox5.Text = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            textBox8.Text = selectedItem;
            //DataRow permiso = seg.Rows[0];
            textBox7.Text = selectedItem2;

            CapaNegocio fn = new CapaNegocio();
            TextBox[] textbox = { txt_total_com, txt_venta, textBox5, textBox8, textBox7 };
            DataTable datos = fn.construirDataTable(textbox);
            if (datos.Rows.Count == 0)
            {
                //MessageBox.Show("Hay campos vacios", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string tabla = "detalle_com_ventas";
                if (Editar)
                {
                    fn.modificar(datos, tabla, atributo, Codigo);
                }
                else
                {
                    fn.insertar(datos, tabla);
                   // bita.Insertar("Insercion de comisiones del empleado: " + cbo_empleado.Text, "detalle_com_venta");
                }
                fn.LimpiarComponentes(this);
            }
        }
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            for (int fila = 0; fila < dataGridView1.RowCount - 1; fila++)
            {
                //DataRow permiso = seg.Rows[0];
                string selectedItem = cbo_empres.SelectedValue.ToString();
                string selectedItem2 = cbo_empleado.SelectedValue.ToString();
                textBox1.Text = selectedItem;
                textBox2.Text = Convert.ToString(dataGridView1.Rows[fila].Cells[0].Value);
                textBox3.Text = Convert.ToString(dataGridView1.Rows[fila].Cells[9].Value);
                textBox4.Text = Convert.ToString(dataGridView1.Rows[fila].Cells[10].Value);
                textBox5.Text = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                textBox6.Text = Convert.ToString(dataGridView1.Rows[fila].Cells[11].Value);
                textBox7.Text = selectedItem2;

                CapaNegocio fn = new CapaNegocio();
                TextBox[] textbox = { textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7 };
                DataTable datos = fn.construirDataTable(textbox);
                if (datos.Rows.Count == 0)
                {
                    //MessageBox.Show("Hay campos vacios", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string tabla = "com_venta";
                    if (Editar)
                    {
                        fn.modificar(datos, tabla, atributo, Codigo);
                    }
                    else
                    {

                        textBox10.Text = "S";
                        fn.insertar(datos, tabla);
                       // bita.Insertar("Insercion de comisiones del empleado: " + cbo_empleado.Text, "com_venta");
                        atributo = "id_fac_empresa_pk";
                        string tabla2 = "factura";
                        Codigo = textBox2.Text;
                        //CapaNegocio fn = new CapaNegocio();
                        TextBox[] textbox2 = { textBox10 };
                        DataTable datos2 = fn.construirDataTable(textbox2);
                        fn.modificar(datos2, tabla2, atributo, Codigo);

                    }
                    fn.LimpiarComponentes(this);
                }
            }
            guardar_detalle();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker2.Enabled = true;
            dateTimePicker3.Enabled = true;
            button1.Enabled = true;
        }

        private void cbo_empleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            txt_total_com.Text = "";
            txt_venta.Text = "";
        }

        private void cbo_empres_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            txt_total_com.Text = "";
            txt_venta.Text = "";
        }
    }
}
