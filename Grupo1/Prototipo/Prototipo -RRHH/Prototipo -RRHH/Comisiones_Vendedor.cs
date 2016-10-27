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
    public partial class Comisiones_Vendedor : Form
    {
        public Comisiones_Vendedor()
        {
            InitializeComponent();
        }

        CapaNegocio fn = new CapaNegocio();
        String Codigo;
        Boolean Editar;
        String atributo;
        int id;
        decimal total;
        private void Comisiones_Vendedor_Load(object sender, EventArgs e)
        {

            //cbo_empleado.Text = "VENDEDOR";
            fn.InhabilitarComponentes(gpb_com_ven);
            fn.InhabilitarComponentes(this);
            llenaridempresa();
            llenarvendedor();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            try
            {
                Editar = false;
                fn.ActivarControles(gpb_com_ven);
                fn.LimpiarComponentes(gpb_com_ven);
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

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            string tabla = "";
            fn.ActualizarGrid(this.dataGridView1, "Select * from empleado WHERE estado <> 'INACTIVO' ", tabla);
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                string tabla = "";
                operaciones op = new operaciones();
                op.ejecutar(dataGridView1, tabla);
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
        
        private void llenarvendedor()
        {
            
            string selectedItem = cbo_empres.SelectedValue.ToString();
            //se realiza la conexión a la base de datos
            Conexionmysql.ObtenerConexion();
            //se inicia un DataSet
            DataSet ds = new DataSet();
            //se indica la consulta en sql=
            String Query = "select id_empleados_pk, nombre from empleado where id_empresa_pk ='" + selectedItem + "' AND cargo = 'VENDEDOR'";
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
            OdbcCommand Query = new OdbcCommand();
            OdbcConnection Conexion;
            OdbcDataReader consultar;
            string sql = "dsn=hotelsancarlos;server=localhost;user id=root;database=hotelsancarlos;password=";
            Conexion = new OdbcConnection();
            Conexion.ConnectionString = sql;
            Conexion.Open();
            Query.CommandText = "SELECT id_fac_empresa_pk,total From factura where id_empleados_pk = '" + selectedItem2 + "'And id_empresa_pk ='" + selectedItem + "';";
            Query.Connection = Conexion;
            consultar = Query.ExecuteReader();
            
            while (consultar.Read())
            {
                dataGridView1.Rows.Add(1);
                if (cont1 == 0) 
                {
                    id = consultar.GetInt32(0);
                    total = consultar.GetDecimal(1);
                    dataGridView1.Rows[0].Cells[0].Value = id;
                    dataGridView1.Rows[0].Cells[1].Value = total;
                    // MessageBox.Show(Convert.ToString(id));
                }
                else
                {
                    
                    id = consultar.GetInt32(0);
                    total = consultar.GetDecimal(1);
                    dataGridView1.Rows[cont1].Cells[0].Value = id;
                    dataGridView1.Rows[cont1].Cells[1].Value = total;
                }
                cont1++;
            }
        }

        public void comision()
        {
            decimal por_comi = Convert.ToDecimal(txt_comi.Text);
            
            for (int fila = 0; fila < dataGridView1.RowCount - 1; fila++)
            {

                dataGridView1.Rows[fila].Cells[2].Value = por_comi;
                dataGridView1.Rows[fila].Cells[3].Value = Convert.ToDecimal(dataGridView1.Rows[fila].Cells[1].Value) * (Convert.ToDecimal(dataGridView1.Rows[fila].Cells[2].Value)/ 100);

            }
        }

        public void totales()
        {
            decimal total_comi = 0;
            decimal total_venta = 0;
            for (int fila = 0; fila < dataGridView1.RowCount - 1; fila++)
            {
                total_comi += Convert.ToDecimal(dataGridView1.Rows[fila].Cells[3].Value);
                total_venta += Convert.ToDecimal(dataGridView1.Rows[fila].Cells[1].Value);
            }

            txt_total_com.Text = Convert.ToString(total_comi);
            txt_venta.Text = Convert.ToString(total_venta);

        }
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            factura();
            comision();
            totales();
        }

        private void cbo_empres_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbo_empleado.Text = "  ";
            llenarvendedor();
        }
    }
}
