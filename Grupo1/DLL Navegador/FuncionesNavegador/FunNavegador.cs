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
            MessageBox.Show(query);
            Conexionmysql.EjecutarMySql(query);
            Conexionmysql.Desconectar();
        }
        public void ActualizarGrid(DataGridView dg, String Query)
        {
            Conexionmysql.ObtenerConexion();
            //crear DataSet
            System.Data.DataSet MiDataSet = new System.Data.DataSet();
            //Crear Adaptador de datos
            MySqlDataAdapter MiDataAdapter = new MySqlDataAdapter(Query, Conexionmysql.ObtenerConexion());
            //LLenar el DataSet
            MiDataAdapter.Fill(MiDataSet, "empleado");
            //Asignarle el valor adecuado a las propiedades del DataGrid
            dg.DataSource = MiDataSet;
            dg.DataMember = "empleado";
            //nos desconectamos de la base de datos...
            Conexionmysql.Desconectar();
        }
    }
}
