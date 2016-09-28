using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Collections;

namespace ObjetoComunConsultasInteligentes
{
    class ObtieneColumna
    {
        String connect = "server=localhost; database=bdcinetopia; Uid=root ; pwd=;";
      
        public void Conectar()
        {
            MySqlConnection conexion = new MySqlConnection(connect);
            conexion.Open();

        }
        public void Desconectar()
        {
            MySqlConnection conexion = new MySqlConnection(connect);
            conexion.Close();
        }
        public MySqlConnection rutaconectada()
        {
            MySqlConnection conexion1 = new MySqlConnection(connect);
            conexion1.Open();
            return conexion1;
        }
        public ArrayList getColumnas(String tabla)
        {
            MySqlConnection conexion = new MySqlConnection("server=localhost; database=bdcinetopia; Uid=root ; pwd=;");
            MySqlCommand cm = new MySqlCommand("SELECT * FROM " + tabla + " LIMIT 0,0", conexion);
            MySqlDataAdapter adaptador = new MySqlDataAdapter(cm);
            DataSet ds = new DataSet();
            adaptador.Fill(ds);
            ArrayList columnas = new ArrayList();
            for (int i = 0; i < ds.Tables[0].Columns.Count; i++)
            {
                columnas.Add(ds.Tables[0].Columns[i].ColumnName);
            }
            return columnas;
        }
        public void actualizargrid( string query,DataGridView datagrid)
        {
               
       Conectar();

            MySqlCommand peticion_dgv = new MySqlCommand(query, rutaconectada());

            MySqlDataAdapter conn = new MySqlDataAdapter(peticion_dgv);
            DataSet ds = new DataSet();
            conn.Fill(ds);


            datagrid.DataSource = ds.Tables[0];
           Desconectar();

        
    }

    }
   
}
