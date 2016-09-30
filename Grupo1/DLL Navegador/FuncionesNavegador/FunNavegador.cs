using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FuncionesNavegador
{
    public class FunNavegador
    {
        public void activartextbox(TextBox textbox)
        {
            textbox.Enabled = true;
        }

        public void desactivartextbox(TextBox textbox)
        {
            textbox.Enabled = false;
        }

        public void insertar(DataTable datos, string tabla)
        {
            Conexionmysql.ObtenerConexion();
            string query1 = "insert into " + tabla + " (";
            string query2 = "values (";
            int cuentaFilas = datos.Rows.Count;
            DataRow contenido;
            for (int fila = 0; fila < cuentaFilas; fila++)
            {
                contenido = datos.Rows[fila];
                query1 = query1 + contenido["Columna"].ToString();
                query2 = query2 + "'" + contenido["Valor"].ToString() + "'";
                if (fila!=(cuentaFilas-1))
                {
                    query1 = query1 + ", ";
                    query2 = query2 + ", ";
                }
            }
            string query = query1 + ") " + query2 + ");";
            Conexionmysql.EjecutarMySql(query);
            Conexionmysql.Desconectar();
        }

        public DataTable construirDataTable(TextBox[] textbox)
        {
            DataTable datos = new DataTable();
            datos.Columns.Add("Columna", typeof(string));
            datos.Columns.Add("Valor", typeof(string));
            DataRow fila;
            foreach (TextBox tb in textbox)
            {
                fila = datos.NewRow();
                fila["Columna"] = tb.Tag.ToString();
                fila["Valor"] = tb.Text;
                if (tb.Text == "")
                {
                    datos.Clear();
                    return datos;
                }
                datos.Rows.Add(fila);
            }
            return datos;
        }

        public void modificar(DataTable datos, string tabla,string atributo,string comparar)
        {
            Conexionmysql.ObtenerConexion();
            string query1 = "UPDATE  " + tabla + " SET ";
            string igual = "=";
            string comilla="";
           
            string query2 = " WHERE " +atributo+ "=" ;
            int cuentaFilas = datos.Rows.Count;
            DataRow contenido;
            for (int fila = 0; fila < cuentaFilas; fila++)
            {
                contenido = datos.Rows[fila];
                query1 = query1 + comilla + contenido["Columna"].ToString() + igual + comilla + "'" + contenido["Valor"].ToString() +"'";
                //query2 = query2 + "'" + contenido["Valor"].ToString() + "'";
                if (fila != (cuentaFilas - 1))
                {
                    query1 = query1 + ", ";
                   // query2 = query2 + ", ";
                }
            }
            string query = query1 + query2 + "'" + comparar+"'"+ ";";
            //MessageBox.Show(query);
            Conexionmysql.EjecutarMySql(query);
            Conexionmysql.Desconectar();
        }

        public void eliminar(string tabla, string atributo, string codigo)
        {
            string estado = "INACTIVO";
            string igual = "=";
            string comillas = "";
            string query = "UPDATE " + tabla + " SET estado =" + "'" + estado +"'" + " WHERE " + comillas +atributo + igual +comillas+ "'"+codigo +"'"+";";
           // MessageBox.Show(query);
            Conexionmysql.EjecutarMySql(query);
            Conexionmysql.Desconectar();
        }
        public void ActualizarGrid(DataGridView dg, String Query, string tabla)
        {
            Conexionmysql.ObtenerConexion();
            //crear DataSet
            System.Data.DataSet MiDataSet = new System.Data.DataSet();
            //Crear Adaptador de datos
            MySqlDataAdapter MiDataAdapter = new MySqlDataAdapter(Query, Conexionmysql.ObtenerConexion());
            //LLenar el DataSet
            MiDataAdapter.Fill(MiDataSet, tabla);
            //Asignarle el valor adecuado a las propiedades del DataGrid
            dg.DataSource = MiDataSet;
            dg.DataMember = tabla;
            //nos desconectamos de la base de datos...
            Conexionmysql.Desconectar();
        }

        public string[] Rsiguiente(int codigo, string tabla)
        {
            string codigon, nombre, apellido, descripcion = "";

            string conexion = "server=localhost; database=ejemplodll; uid=root; pwd=;";

            MySqlConnection conn = new MySqlConnection(conexion);

            conn.Open();
            string query = "SELECT * FROM "+tabla+" LIMIT " + codigo + " , 1";
            MySqlCommand mycomand = new MySqlCommand(query, conn);

            MySqlDataReader myreader = mycomand.ExecuteReader();

            myreader.Read();
            codigon = myreader["codigo"].ToString();
            nombre = myreader["nombre"].ToString();
            apellido = myreader["apellido"].ToString();
            descripcion = myreader["descripcion"].ToString();
            string[] datos = new string[4] { codigon, nombre, apellido, descripcion };

            return datos;
            conn.Close();
        }

        public string[] Ranterior(int codigo, string dato, string tabla) {
            string codigon, nombre, apellido, descripcion = "";

            string conexion = "server=localhost; database=ejemplodll; uid=root; pwd=;";

            MySqlConnection conn = new MySqlConnection(conexion);

            conn.Open();
            string query = "SELECT * FROM "+tabla+" WHERE "+dato+"<"+codigo+" ORDER BY codigo DESC LIMIT 1";
            MySqlCommand mycomand = new MySqlCommand(query, conn);

            MySqlDataReader myreader = mycomand.ExecuteReader();

            myreader.Read();
            codigon = myreader["codigo"].ToString();
            nombre = myreader["nombre"].ToString();
            apellido = myreader["apellido"].ToString();
            descripcion = myreader["descripcion"].ToString();
            string[] datos = new string[4] { codigon, nombre, apellido, descripcion };
            // MessageBox.Show("* " + datos[1] + " /");
            return datos;
            conn.Close();
        }

        public string[] Tsiguiente(string tabla) {
            string codigon, nombre, apellido, descripcion = "";

            string conexion = "server=localhost; database=ejemplodll; uid=root; pwd=;";

            MySqlConnection conn = new MySqlConnection(conexion);

            conn.Open();
            string query = "SELECT * FROM "+tabla+" ORDER BY codigo DESC LIMIT 1";
            MySqlCommand mycomand = new MySqlCommand(query, conn);

            MySqlDataReader myreader = mycomand.ExecuteReader();

            myreader.Read();
            codigon = myreader["codigo"].ToString();
            nombre = myreader["nombre"].ToString();
            apellido = myreader["apellido"].ToString();
            descripcion = myreader["descripcion"].ToString();
            string[] datos = new string[4] { codigon, nombre, apellido, descripcion };
            // MessageBox.Show("* " + datos[1] + " /");
            return datos;
            conn.Close();
        }

        public string[] Tanterior(string tabla) {
            string codigon, nombre, apellido, descripcion = "";

            string conexion = "server=localhost; database=ejemplodll; uid=root; pwd=;";

            MySqlConnection conn = new MySqlConnection(conexion);

            conn.Open();
            string query = "SELECT * FROM " + tabla + " ORDER BY codigo ASC LIMIT 1";
            MySqlCommand mycomand = new MySqlCommand(query, conn);

            MySqlDataReader myreader = mycomand.ExecuteReader();

            myreader.Read();
            codigon = myreader["codigo"].ToString();
            nombre = myreader["nombre"].ToString();
            apellido = myreader["apellido"].ToString();
            descripcion = myreader["descripcion"].ToString();
            string[] datos = new string[4] { codigon, nombre, apellido, descripcion };
            // MessageBox.Show("* " + datos[1] + " /");
            return datos;
            conn.Close();
        }

        public void LimpiarTextbox(TextBox textbox)
        {
            textbox.Text = "";
        }

        public void LimpiarCombobox(ComboBox combobox)
        {
            combobox.Text = "";
        }

        public ComboBox llenarCbo(string Query, string tabla, ComboBox cbo, string valor, string mostrar)
        {
            //se realiza la conexión a la base de datos
            Conexionmysql.ObtenerConexion();
            //se inicia un DataSet
            DataSet ds = new DataSet();
            //se indica la consulta en sql
            String Query1 = Query;
            MySqlDataAdapter dad = new MySqlDataAdapter(Query1, Conexionmysql.ObtenerConexion());
            //se indica con quu tabla se llena
            dad.Fill(ds, tabla);
            cbo.DataSource = ds.Tables[0].DefaultView;
            //indicamos el valor de los miembros
            cbo.ValueMember = (valor);
            //se indica el valor a desplegar en el combobox
            cbo.DisplayMember = (mostrar);
            return cbo;
        }
    }
}
