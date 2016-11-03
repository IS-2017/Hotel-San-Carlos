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

namespace ModuloAdminHotel
{
    class conexionmanipulacion
    {
        String connect = "server=localhost; database=hotelsancarlos; Uid=root ; pwd=;";
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
        //llena los combobox
        public void getColumnas(ComboBox cb,String tabla,String parametro)
        {
            
            MySqlCommand cm = new MySqlCommand("SELECT "+parametro+" FROM " + tabla +";" , rutaconectada());
            MySqlDataReader adaptador = cm.ExecuteReader();
            while(adaptador.Read())
            {
                cb.Items.Add(adaptador[parametro].ToString());
               
            }
            adaptador.Close();

        }
        public void EjecutarQuerydll(String Query)
        {
            Conectar();
            MySqlCommand comando = new MySqlCommand(Query, rutaconectada());
            int Ifilasafectadas = comando.ExecuteNonQuery();
            ;
            if (Ifilasafectadas > 0)
                MessageBox.Show("Operacion realizada con exitosamente");
            Desconectar();
        }
      

   
        //llena los textos
        public void llenartext(TextBox tx,String Query,String parametro)
        {
            MySqlCommand cm = new MySqlCommand(Query, rutaconectada());
            MySqlDataReader adaptador = cm.ExecuteReader();
            if(adaptador.Read()==true)
            {
               
                tx.Text=(adaptador[parametro].ToString());

            }
            adaptador.Close();
        }
        public void EjecutarQuery(TextBox tx,String Query)
        {
            Conectar();
            MySqlCommand comando = new MySqlCommand(Query, rutaconectada());
            int Ifilasafectadas = comando.ExecuteNonQuery();
           ;
            if (Ifilasafectadas > 0)
                MessageBox.Show("Operacion realizada con exitosamente");
            Desconectar();
        }
        public string verificacionhabitaicon(String Query)
        {
            DataTable dt = new DataTable();
            MySqlCommand comando = new MySqlCommand(Query, rutaconectada());
            MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
            adaptador.Fill(dt);
            DataRow row = dt.Rows[0];
            String id_cat = row[0].ToString().Trim();
            return id_cat;
        }

    
    }
}
