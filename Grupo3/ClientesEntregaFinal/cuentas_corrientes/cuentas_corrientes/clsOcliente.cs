using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using MySql.Data.MySqlClient;
using System.Data.Odbc;
using seguridad;

namespace cuentas_corrientes
{
    class clsOcliente
    {
        public static int Agregar(cls_cliente clte) //Para insertar datos a Mysql 
        {
            int iretorno = 0;
            OdbcCommand comando = new OdbcCommand(string.Format("insert into cliente (id_cliente_pk, nombre, apellido, correo, dpi, nit, telefono, direccion, fecha_nacimiento, id_tipocredito_pk, id_contribuyente_pk, id_empleado_pk, dias_cred, id_tprecio_pk) values (NULL,'{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}', '{12}')",
              clte.nombre, clte.apellido, clte.correo, clte.dpi, clte.nit, clte.tel, clte.dire, clte.fecha, clte.codcredi, clte.codcontri, clte.codven, clte.dias_cre, clte.codpre), seguridad.Conexion.ObtenerConexionODBC());
            iretorno = comando.ExecuteNonQuery();// Retorna un 1 si se ejecuta la inserción y 0 es error.
            return iretorno;

        }

        public static List<cls_cliente> Buscar(string clte) //Método tipo lista, que retornar el resultado dela busqueda
        {
            List<cls_cliente> _lista = new List<cls_cliente>();
            //MessageBox.Show(credi);
            OdbcCommand _comando = new OdbcCommand(String.Format(
           "select * from cliente where nombre = '{0}' ", clte), seguridad.Conexion.ObtenerConexionODBC());
            OdbcDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                cls_cliente cl = new cls_cliente();
                cl.cod = _reader.GetInt16(0);
                
                //tc.valor = Convert.ToString(_reader.GetDouble(2));
                cl.nombre = _reader.GetString(1);
                cl.apellido = _reader.GetString(2);
                cl.correo = _reader.GetString(3);
                cl.dpi = _reader.GetInt32(4);
                cl.nit = _reader.GetString(5);
                cl.tel = _reader.GetString(6);
                cl.dire = _reader.GetString(7);
                cl.fecha = _reader.GetString(8);
                cl.codcredi = _reader.GetInt16(9);
                cl.codcontri = _reader.GetInt16(10);
                cl.codven = _reader.GetInt16(11);
                cl.codpre = _reader.GetInt16(12);
                cl.dias_cre = _reader.GetInt16(12);
               


                _lista.Add(cl);
            }

            return _lista;
        }

        public static cls_cliente Obtenerclte(int id_cl)
        {
            cls_cliente cl = new cls_cliente();
            OdbcConnection conexion = seguridad.Conexion.ObtenerConexionODBC();

            OdbcCommand _comando = new OdbcCommand(String.Format("select *  from cliente where id_cliente_pk ='{0}' ", id_cl), conexion);
            OdbcDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                cl.cod = _reader.GetInt16(0);
                cl.correo = _reader.GetString(1);
                cl.nombre = _reader.GetString(2);
                cl.apellido = _reader.GetString(3);
                //cl.correo = _reader.GetString(3);
                cl.dpi = _reader.GetInt32(4);
                cl.nit = _reader.GetString(5);
                cl.tel = _reader.GetString(6);
                cl.dire = _reader.GetString(7);
                cl.fecha = _reader.GetString(8);
                cl.codcredi = _reader.GetInt16(9);
                cl.codcontri = _reader.GetInt16(10);
                cl.codven = _reader.GetInt16(12);
                cl.codpre = _reader.GetInt16(13);
            }

            conexion.Close();
            return cl;
        }

        public static int Actualizar(cls_cliente cl)
        {
            int iretorno = 0;
            OdbcConnection conexion = seguridad.Conexion.ObtenerConexionODBC();
            OdbcCommand comando = new OdbcCommand(string.Format("update cliente set nombre='{0}', apellido='{1}', correo='{2}', dpi='{3}', nit='{4}', telefono='{5}', direccion='{6}', fecha_nacimiento='{7}', id_tipocredito_pk='{8}', id_contribuyente_pk='{9}', id_empleado_pk='{10}', dias_cred='{11}', id_tprecio_pk='{12}' where id_cliente_pk={13}",
               cl.nombre, cl.apellido, cl.correo, cl.dpi, cl.nit, cl.tel, cl.dire, cl.fecha, cl.codcredi, cl.codcontri, cl.codven, cl.dias_cre, cl.codpre, cl.cod), conexion);
            iretorno = comando.ExecuteNonQuery();
            conexion.Close();

            return iretorno;


        }

        public static int Eliminar(int pId)
        {
            int retorno = 0;
            OdbcConnection conexion = seguridad.Conexion.ObtenerConexionODBC();

            OdbcCommand comando = new OdbcCommand(string.Format("delete from cliente where id_cliente_pk={0}", pId), conexion);

            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;

        }
    }
}
