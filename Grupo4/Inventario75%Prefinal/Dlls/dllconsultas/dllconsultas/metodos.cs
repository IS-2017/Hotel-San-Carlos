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
using System.Data.Odbc;
using seguridad;
//rodrigo:transformacion de form a dll
//rodrigo: creacion de metodos
namespace dllconsultas
{
    class metodos
    {
        /*String connect = "dsn=hotelsancarlos; server=localhost; database=hotelsancarlos; uid=root; pwd=;";
        public void Conectar()
        {
            OdbcConnection conexion = new OdbcConnection(connect);
            conexion.Open();

        }
        public void Desconectar()
        {
            OdbcConnection conexion = new OdbcConnection(connect);
            conexion.Close();
        }*/
       /* public OdbcConnection rutaconectada()
        {
            OdbcConnection conexion1 = new OdbcConnection(connect);
            conexion1.Open();
            return conexion1;
        }*/
        public ArrayList getColumnas(String tabla)
        {

            //Analillian: creacion de metodo
            //permite llenar los combobox con los atributos de las tablas
            OdbcConnection con = Conexion.ConexionPermisos();
            OdbcCommand cm = new OdbcCommand("SELECT * FROM " + tabla + " LIMIT 0,0", con);
            OdbcDataAdapter adaptador = new OdbcDataAdapter(cm);
            DataSet ds = new DataSet();
            adaptador.Fill(ds);
            ArrayList columnas = new ArrayList();
            for (int i = 0; i < ds.Tables[0].Columns.Count; i++)
            {
                columnas.Add(ds.Tables[0].Columns[i].ColumnName);
            }
            con.Close();
            return columnas;

        }


        public void actualizargrid(string query, DataGridView datagrid)
        {
            //permite actualizar cualquier grid
            OdbcConnection con = Conexion.ConexionPermisos();
            OdbcCommand peticion_dgv = new OdbcCommand(query, con);
            OdbcDataAdapter conn = new OdbcDataAdapter(peticion_dgv);
            DataSet ds = new DataSet();
            conn.Fill(ds);
            datagrid.DataSource = ds.Tables[0];
            con.Close();
        }
        public void EjecutarQuery(String Query)
        {
            OdbcConnection con = Conexion.ConexionPermisos();
            OdbcCommand comando = new OdbcCommand(Query, con);
            int Ifilasafectadas = comando.ExecuteNonQuery();
            if (Ifilasafectadas > 0)
                MessageBox.Show("Operacion realizada con exitosamente");
            con.Close();
        }
        public void buscarquery(String Squery)
        {
            OdbcConnection con = Conexion.ConexionPermisos();
            OdbcCommand Micomando = new OdbcCommand(Squery, con);
            int FilasAfectadas = Micomando.ExecuteNonQuery();
            if (FilasAfectadas > 0)
                MessageBox.Show("No se encontro el Registro", "Error del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("Busqueda Realizada", "Musqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
        }
       public void extraeryejecutar(string query,DataGridView dg)
        {
            //creador: walter
            OdbcConnection con = Conexion.ConexionPermisos();
            DataTable dt = new DataTable();
            String sQuery = "SELECT descripcion FROM consultaguardada WHERE idconsulta= '" + query + "'";
            OdbcCommand comando = new OdbcCommand(sQuery, con);
            OdbcDataAdapter adaptador = new OdbcDataAdapter(comando);
            adaptador.Fill(dt);
            DataRow fila = dt.Rows[0];
            string sid = Convert.ToString(fila[0]);
            string traduccion = sid.Replace("$", "'");
            con.Close();
            actualizargrid(sid, dg);
        }
    } 
}
