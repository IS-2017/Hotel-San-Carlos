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

namespace ModuloAdminHotel
{
    class metodos
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
        public void EjecutarQuery(String Query)
        {
            Conectar();
            MySqlCommand comando = new MySqlCommand(Query, rutaconectada());
            int Ifilasafectadas = comando.ExecuteNonQuery();
            if (Ifilasafectadas > 0)
                MessageBox.Show("Operacion realizada con exitosamente");
            Desconectar();
        }

        public void EjecutarQuery1(String Query)
        {
            Conectar();
            MySqlCommand comando = new MySqlCommand(Query, rutaconectada());
            int Ifilasafectadas = comando.ExecuteNonQuery();
            if (Ifilasafectadas > 0) { }
             Desconectar();
        }

        public ArrayList getColumnas(String tabla)
        {
            MySqlConnection conexion = new MySqlConnection(connect);
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
        public void actualizargrid(string query, DataGridView datagrid)
        {
            try
            {
                Conectar();

                MySqlCommand peticion_dgv = new MySqlCommand(query, rutaconectada());

                MySqlDataAdapter conn = new MySqlDataAdapter(peticion_dgv);
                DataSet ds = new DataSet();
                conn.Fill(ds);


                datagrid.DataSource = ds.Tables[0];
                Desconectar();
            }
            catch (Exception)
            {
                MessageBox.Show("Consulta Incorrecta\n Verifique Manual de Uso", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


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
        public void extraeryejecutar(string query, DataGridView dg)
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
            //MessageBox.Show(traduccion);
            Desconectar();
            actualizargrid(traduccion, dg);
        }


        //---------------------------------------consulta de precios otras tablas---------------------------------------------
        //Programador: walter recinos
        //fecha inicio: 21-10-2016
        //fecha fin: 21-10-2016
        public double consulta_subtotal_folio_bien(string dato)
        {
            try
            {
                Conectar();
                DataTable dt = new DataTable();
                String sQuery = "SELECT SUM(costo) FROM folio_bien WHERE  id_cuenta_pagar_pk = '" + dato + "'";
                MySqlCommand comando = new MySqlCommand(sQuery, rutaconectada());
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                adaptador.Fill(dt);
                DataRow fila = dt.Rows[0];
                string sid = Convert.ToString(fila[0]);
                //MessageBox.Show("El Precio del articulo es: Q." + sid);
                double cantidad = Convert.ToDouble(sid);
                Desconectar();
                return cantidad;
            }
            catch (Exception)
            {
                return 0;
            }

        }
        //---------------------------------------------------------------------------------------------------------------------
        public double consulta_subtotal_folio_paquete(string dato)
        {
            try
            {
                Conectar();
                DataTable dt = new DataTable();
                String sQuery = "SELECT SUM(costo) FROM folio_promocion WHERE  id_cuenta_pagar_pk = '" + dato + "'";
                MySqlCommand comando = new MySqlCommand(sQuery,rutaconectada());
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                adaptador.Fill(dt);
                DataRow fila = dt.Rows[0];
                string sid = Convert.ToString(fila[0]);
                //MessageBox.Show("El Precio de la promocion es: Q." + sid);                
                double cantidad = Convert.ToDouble(sid);
                Desconectar();
                return cantidad;
            }
            catch (Exception)
            {
                return 0;
            }

        }
        //---------------------------------------------------------------------------------------------------------------------
        public double consulta_subtotal_folio_habitacion(string dato)
        {
            try
            {
                Conectar();
                DataTable dt = new DataTable();
                String sQuery = "SELECT SUM(costo) FROM folio_habitacion WHERE  id_cuenta_pagar_pk = '" + dato + "'";
                MySqlCommand comando = new MySqlCommand(sQuery,rutaconectada());
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                adaptador.Fill(dt);
                DataRow fila = dt.Rows[0];
                string sid = Convert.ToString(fila[0]);
                //MessageBox.Show("Costo subtotal habitacion: Q." + sid);
                Desconectar();
                double cantidad = Convert.ToDouble(sid);
                return cantidad;
            }
            catch (Exception)
            {
                return 0;
            }

        }
        //--------------------------------------------------------------------------------------------------------------------
        public double consulta_subtotal_folio_salon(string dato)
        {
            try
            {
                Conectar();
                DataTable dt = new DataTable();
                String sQuery = "SELECT SUM(costo) FROM folio_salon WHERE  id_cuenta_pagar_pk = '" + dato + "'";
                MySqlCommand comando = new MySqlCommand(sQuery,rutaconectada());
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                adaptador.Fill(dt);
                DataRow fila = dt.Rows[0];
                string sid = Convert.ToString(fila[0]);
                //MessageBox.Show("Costo subtotal de salon: Q." + sid);
                Desconectar();
                double cantidad = Convert.ToDouble(sid);
                return cantidad;
            }
            catch (Exception)
            {
                return 0;
            }

        }

        //---------------------------------------------------------------------------------------------------------------------
        //este sirve para contar todos los totales por folio
        public double subtotal_por_folio(string campo)
        {
            double n1 = consulta_subtotal_folio_habitacion(campo);
            double n2 = consulta_subtotal_folio_salon(campo);
            double n3 = consulta_subtotal_folio_bien(campo);
            double n4 = consulta_subtotal_folio_paquete(campo);
            double subtotal = n1 + n2 + n3 + n4;
            string Ssubtotal = Convert.ToString(subtotal);
            //MessageBox.Show("El Total es: Q." + Ssubtotal);
            return subtotal;
        }
        //--------------------------------------------------------------------------------------------------------------------
        //este sirve para ejecultar subtotal_por_folio y almacena el total en el campo costo de la tabla folio
        public void guardar_costo_folio(string campo_referencia)
        {
            double total = subtotal_por_folio(campo_referencia);
            Conectar();
            String Squery = "update folio  set costo ='" + total + "' where id_cuenta_pagar_pk ='" + campo_referencia + "'";
            EjecutarQuery1(Squery);
            //nombre_columna();
            Desconectar();
        }

        //--------------------------suma con detalle folio--------------------------------------------------------------------
        public void actualizar_total(string dato)
        {
            try
            {
                Conectar();
                DataTable dt = new DataTable();
                String sQuery = "SELECT sum(costo) FROM detalle_folio WHERE  id_cuenta_pagar_pk = '" + dato + "'";
                MySqlCommand comando = new MySqlCommand(sQuery, rutaconectada());
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                adaptador.Fill(dt);
                DataRow fila = dt.Rows[0];
                string sid = Convert.ToString(fila[0]);
                MessageBox.Show("Costoooooo subtotal de salon: Q." + sid);
                Desconectar();
                double cantidad = Convert.ToDouble(sid);


                Conectar();
                String Squery = "update folio  set costo ='" + cantidad + "' where id_cuenta_pagar_pk ='" + dato + "'";
                EjecutarQuery1(Squery);
                //nombre_columna();
                Desconectar();
            }
            catch (Exception)
            {
                double cantidad = 0;
                Conectar();
                String Squery = "update folio  set costo ='" + cantidad + "' where id_cuenta_pagar_pk ='" + dato + "'";
                EjecutarQuery1(Squery);
                //nombre_columna();
                Desconectar();
            }
            
        }

    }
}
