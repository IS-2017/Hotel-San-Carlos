//using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using seguridad;

namespace cuentas_corrientes
{
    public class cls_cotizaciondal
    {
        public int contador = 0;
        public static int Agregar(cls_cotizacion coti)  // procesode insertar un nueva cotizacion al sistema
        {


            
                int retorno = 0;
                int retorno2 = 0;
                OdbcCommand comando = new OdbcCommand(string.Format("Insert into cotizacion (nombre_cte, direccion_cte, apellido_cte, fecha_cot, nit_cte, telefono_cte, estado_cot) values ('{0}','{1}','{2}', '{3}','{4}', '{5}', '{6}')",
                coti.nombre_cte, coti.direccion_cte, coti.apellido_cte, coti.fecha_cot, coti.nit_cte, coti.telefono1, coti.estado_cot), Conexion.ObtenerConexionODBC());
                retorno = comando.ExecuteNonQuery();
                return retorno;
                
         }
        public static int AgregarDetFact(detalle_cot fact) //Para insertar datos a Mysql 
        {
            int iretorno = 0;
            OdbcCommand comando = new OdbcCommand(string.Format("insert into detalle_cotizacion (cantidad_detallecot, id_cotizacion_pk, id_precio  )values ('{0}','{1}','{2}')",
              fact.cantidad_detallecot  , fact.id_cotizacion_pk, fact.id_precio), Conexion.ObtenerConexionODBC());
            iretorno = comando.ExecuteNonQuery();// Retorna un 1 si se ejecuta la inserción y 0 es error.
            return iretorno;
        }


        public static List<bien> Buscar(string descripcion)

        {

            List<bien> _lista = new List<bien>();



            OdbcCommand _comando = new OdbcCommand(String.Format(

           "SELECT bien.id_bien_pk, bien.descripcion, precio.precio FROM bien, precio WHERE bien.descripcion = '{0}' AND bien.id_categoria_pk = 'PT' AND bien.id_bien_pk=precio.id_bien_pk  AND id_tprecio_pk = '1'", descripcion), seguridad.Conexion.ObtenerConexionODBC());

            OdbcDataReader _reader = _comando.ExecuteReader();

            while (_reader.Read())

            {

                bien bien = new bien();

                bien.id_bien_pk = _reader.GetInt32(0);

                bien.descripcion = _reader.GetString(1);

                bien.precio = _reader.GetString(2);

                //bien.cantidad = _reader.GetString(3);               

                _lista.Add(bien);

            }
            return _lista;
        }
        /*public static List<paquete> Buscar3(string descripcion)

        {

            List<bien> _lista = new List<bien>();



            MySqlCommand _comando = new MySqlCommand(String.Format(

           "SELECT bien.id_bien_pk, bien.descripcion, precio.precio FROM bien, precio where bien.id_bien_pk = precio.id_bien_pk and bien.descripcion ='{0}'", descripcion), cls_bdcomun.ObtenerConexion());

            MySqlDataReader _reader = _comando.ExecuteReader();

            while (_reader.Read())

            {

                bien bien = new bien();

                bien.id_bien_pk = _reader.GetInt32(0);

                bien.descripcion = _reader.GetString(1);

                bien.precio = _reader.GetString(2);

                //bien.cantidad = _reader.GetString(3);               

                _lista.Add(bien);

            }
            return _lista;
        }*/
        public static List<encabezado> Buscar2(string id_cotizacion)

        {

            List<encabezado> _lista2 = new List<encabezado>();



            OdbcCommand _comando = new OdbcCommand(String.Format(

           "select id_cotizacion, nombre_cte, apellido_cte, nit_cte, fecha_cot, estado_cot from cotizacion where id_cotizacion ='{0}'", id_cotizacion), seguridad.Conexion.ObtenerConexionODBC());

            OdbcDataReader _reader = _comando.ExecuteReader();

            while (_reader.Read())

            {

                encabezado enca = new encabezado();

                enca.id_cotizacion = _reader.GetInt32(0);

                enca.nombre_cte = _reader.GetString(1);

                enca.apellido_cte = _reader.GetString(2);
                enca.direccion_cte = _reader.GetString(4);
                enca.nit_cte = _reader.GetString(3);
                enca.fecha_cot = _reader.GetString(5);
                enca.estado_cot = _reader.GetString(6);
                //bien.cantidad = _reader.GetString(3);               

                _lista2.Add(enca);

            }
            return _lista2;
        }
        public static bien ObtenerProveedor(int id_bien_pk)

        {

            bien bien = new bien();

            OdbcConnection conexion = seguridad.Conexion.ObtenerConexionODBC();




            OdbcCommand _comando = new OdbcCommand(String.Format("SELECT bien.id_bien_pk, bien.descripcion, precio.precio FROM bien, precio where precio.id_bien_pk = bien.id_bien_pk and bien.id_bien_pk  ={0}", id_bien_pk), conexion);

            OdbcDataReader _reader = _comando.ExecuteReader();

            while (_reader.Read())

            {

                bien.id_bien_pk = _reader.GetInt32(0);
                bien.descripcion = _reader.GetString(1);
                bien.precio = _reader.GetString(2);              
                //bien.cantidad = _reader.GetString(3);            
            }

            conexion.Close();
            return bien;





        }

        public static encabezado ObtenerEncabezado(int id_cotizacion)

        {

            encabezado enca = new encabezado();

            OdbcConnection conexion = seguridad.Conexion.ObtenerConexionODBC();




            OdbcCommand _comando = new OdbcCommand(String.Format("SELECT id_cotizacion, nombre_cte, apellido_cte, nit_cte, direccion_cte, fecha_cot, estado_cot FROM cotizacion where id_cotizacion  ={0}", id_cotizacion), conexion);

            OdbcDataReader _reader = _comando.ExecuteReader();

            while (_reader.Read())

            {

                enca.id_cotizacion = _reader.GetInt32(0);
                enca.nombre_cte = _reader.GetString(1);
                enca.apellido_cte = _reader.GetString(2);
                enca.nit_cte = _reader.GetString(3);
                enca.direccion_cte = _reader.GetString(4);
                enca.fecha_cot = _reader.GetString(5);
                enca.estado_cot = _reader.GetString(6);
                //bien.cantidad = _reader.GetString(3);            
            }

            conexion.Close();
            return enca;





        }
        public static int Eliminar(int id_cotizacion)

        {

            int retorno = 0;
            //int resultado = 0;
            OdbcConnection conexion = seguridad.Conexion.ObtenerConexionODBC();
            OdbcCommand comando = new OdbcCommand(string.Format(" UPDATE cotizacion SET estado_cot = 'inactiva' WHERE id_cotizacion = {0}", id_cotizacion), conexion);
            //resultado++;
            /*if (resultado > 0)
            {
                OdbcCommand comando2 = new OdbcCommand(string.Format(" Delete From cotizacion where cotizacion.id_cotizacion = {0}", id_cotizacion), conexion);
                retorno = comando2.ExecuteNonQuery();
            }*/
            retorno = comando.ExecuteNonQuery();         
            conexion.Close();
            return retorno;
        }

        internal static bool Eliminar(bool v)
        {
            throw new NotImplementedException();
        }
    }
}
