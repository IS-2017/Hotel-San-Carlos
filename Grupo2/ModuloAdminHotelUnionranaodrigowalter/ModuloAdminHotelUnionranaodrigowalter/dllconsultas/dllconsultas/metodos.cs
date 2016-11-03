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
//rodrigo:transformacion de form a dll
//rodrigo: creacion de metodos
namespace dllconsultas
{
    class metodos
    {
        String connect = "server=localhost; database=hotel; Uid=root ; pwd=;";

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

            //Analillian: creacion de metodo
            //permite llenar los combobox con los atributos de las tablas
            MySqlCommand cm = new MySqlCommand("SELECT * FROM " + tabla + " LIMIT 0,0", rutaconectada());
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


        public void actualizargrid(string query, DataGridView datagrid)
        {
            //permite actualizar cualquier grid
            Conectar();
            MySqlCommand peticion_dgv = new MySqlCommand(query, rutaconectada());
            MySqlDataAdapter conn = new MySqlDataAdapter(peticion_dgv);
            DataSet ds = new DataSet();
            conn.Fill(ds);
            datagrid.DataSource = ds.Tables[0];
            Desconectar();


        }
        public void EjecutarQuery(String Query)
        {
            Conectar();
            MySqlCommand comando = new MySqlCommand(Query, rutaconectada());
            int Ifilasafectadas = comando.ExecuteNonQuery();
            if (Ifilasafectadas > 0)
                MessageBox.Show("Operacion realizada con exitosamente");
            Desconectar();
        }
        public void buscarquery(String Squery)
        {
            Conectar();
            MySqlCommand Micomando = new MySqlCommand(Squery, rutaconectada());
            int FilasAfectadas = Micomando.ExecuteNonQuery();
            if (FilasAfectadas > 0)
                MessageBox.Show("No se encontro el Registro", "Error del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("Busqueda Realizada", "Musqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Desconectar();
        }
       public void extraeryejecutar(string query,DataGridView dg)
        {
            //creador: walter
            Conectar();
            DataTable dt = new DataTable();
            String sQuery = "SELECT descripcion FROM consultaguardada WHERE idconsulta= '" + query + "'";
            MySqlCommand comando = new MySqlCommand(sQuery, rutaconectada());
            MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
            adaptador.Fill(dt);
            DataRow fila = dt.Rows[0];
            string sid = Convert.ToString(fila[0]);
            string traduccion = sid.Replace("$", "'");
            Desconectar();
           actualizargrid(sid, dg);
        }
    } 
}
