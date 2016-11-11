using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cuentas_corrientes
{
    class clsOclientePedido
    {
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
               /* cl.dpi = _reader.GetInt32(4);
                cl.nit = _reader.GetString(5);
                cl.tel = _reader.GetString(6);
                cl.dire = _reader.GetString(7);
                cl.fecha = _reader.GetString(8);
                cl.codcredi = _reader.GetInt16(9);
                cl.codcontri = _reader.GetInt16(10);
                cl.codven = _reader.GetInt16(11);
                cl.dias_cre = _reader.GetInt16(12);
                cl.codpre = _reader.GetInt16(13);*/



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
                /*   cl.dpi = _reader.GetInt32(4);
                   cl.nit = _reader.GetString(5);
                   cl.tel = _reader.GetString(6);
                   cl.dire = _reader.GetString(7);
                   cl.fecha = _reader.GetString(8);
                   cl.codcredi = _reader.GetInt16(9);
                   cl.codcontri = _reader.GetInt16(10);
                   cl.codpre = _reader.GetInt16(11);
                   cl.codven = _reader.GetInt16(12);
                   cl.dias_cre = _reader.GetInt16(13);
                   */
            }

            conexion.Close();
            return cl;
        }
    }
}
