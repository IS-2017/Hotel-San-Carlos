using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.Odbc;

namespace Abrir
{
    class Manejocs
    {
        private static OdbcCommand mySqlComando;
        private static OdbcDataAdapter mySqlDAdAdaptador;
        public void insertarRPT(string nombre,string ruta)
        {
            try
            {
                mySqlComando = new OdbcCommand(string.Format("Insert into reporteador(nombre,ubicacion) values ('{0}','{1}')", nombre,ruta),seguridad.Conexion.ObtenerConexionODBC());
                mySqlComando.ExecuteNonQuery();
                MessageBox.Show("Se inserto con exito");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error en insercion");   
            }
        }

        public DataTable cargar(string query)
        {
            // llenado del data grid view 
            DataTable dt = new DataTable();
            OdbcCommand cmd = new OdbcCommand(query, seguridad.Conexion.ObtenerConexionODBC());
            OdbcDataAdapter adap = new OdbcDataAdapter(cmd);
            adap.Fill(dt);
            return dt;

        }

    }
}
