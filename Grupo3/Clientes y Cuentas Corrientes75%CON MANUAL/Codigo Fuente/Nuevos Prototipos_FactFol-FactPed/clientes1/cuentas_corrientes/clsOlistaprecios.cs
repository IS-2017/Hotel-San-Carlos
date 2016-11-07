using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using MySql.Data.MySqlClient;
using System.Data.Odbc;

namespace cuentas_corrientes
{
    class clsOlistaprecios
    {
        public static ClsListadoPrecio Obtenerbien(int id_bien, int co)
        {
            ClsListadoPrecio cl = new ClsListadoPrecio();
            OdbcConnection conexion = seguridad.Conexion.ObtenerConexionODBC();
            OdbcCommand _comando = new OdbcCommand(String.Format("SELECT bien.descripcion, bien.costo, precio.precio, bien.id_bien_pk FROM precio INNER JOIN bien ON bien.id_bien_pk = precio.id_bien_pk and precio.id_bien_pk={0} and precio.id_tprecio_pk={1}", id_bien,co), conexion);
            OdbcDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                cl.descripcion = _reader.GetString(0);
                cl.costo = _reader.GetFloat(1);
                cl.precio = _reader.GetFloat(2);
                cl.codbien = _reader.GetInt16(3);

                
            }

            conexion.Close();
            return cl;
        }

    }
}
