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
    class ClsOpFolio
    {
        //Clase publica para realizar operaciones de folio en la base de datos
        //Olivia Vicente Tinoco 0901-13-194
        public static List<clsFolio> Buscarfoio(int idcte ) //Método tipo lista, que retornar el resultado dela busqueda
        {
            List<clsFolio> _lista = new List<clsFolio>();

            OdbcCommand _comando = new OdbcCommand(String.Format(
           "select id_cuenta_pagar_pk, estado,fecha_ingreso from folio where id_cliente_pk ='{0}' and estado!='cancelado' ", idcte), seguridad.Conexion.ObtenerConexionODBC());
            // "select id_impuesto, porcentaje, nombre, descripcion from categoria  where nombre_cat ='{0}' ", nomcat),
            OdbcDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                clsFolio pfol = new clsFolio();
            
                pfol.cod= _reader.GetInt16(0);
                pfol.estado = _reader.GetString(1);
                pfol.fec_ingre= _reader.GetString(2);
               
                _lista.Add(pfol);
            }

            return _lista;
        }

        public static clsFolio ObtenerFolio(int id_imp)
        {
            clsFolio pfol = new clsFolio();
            OdbcConnection conexion = seguridad.Conexion.ObtenerConexionODBC();

            OdbcCommand _comando = new OdbcCommand(String.Format("select id_cuenta_pagar_pk, estado,fecha_ingreso, id_cliente_pk , costo  from folio  where id_cuenta_pagar_pk ='{0}' ", id_imp), conexion);
            OdbcDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                

                pfol.cod = _reader.GetInt16(0);
                pfol.estado = _reader.GetString(1);
                pfol.fec_ingre = _reader.GetString(2);
                pfol.codcte = _reader.GetInt16(3);
                pfol.costo = _reader.GetInt16(4);
            }

            conexion.Close();
            return pfol;
        }


        public static int ActualizarFolio(clsFolio pfol)
        {
            int iretorno = 0;
            OdbcConnection conexion = seguridad.Conexion.ObtenerConexionODBC();
            OdbcCommand comando = new OdbcCommand(string.Format("update folio set estado='{0}', fecha_pago='{1}' where id_cuenta_pagar_pk={2}",
                pfol.estado, pfol.fec_pago, pfol.cod), conexion);
            iretorno = comando.ExecuteNonQuery();
            conexion.Close();

            return iretorno;
      

        }



        public static List<ClsDetalleFolio> BuscardetalleFol(int idfol) //Método tipo lista, que retornar el resultado dela busqueda
        {
            List<ClsDetalleFolio> _lista = new List<ClsDetalleFolio>();

            OdbcCommand _comando = new OdbcCommand(String.Format(
           "select id_detalle_folio_pk, nombre, costo from detalle_folio where id_cuenta_pagar_pk ='{0}' ", idfol), seguridad.Conexion.ObtenerConexionODBC());
            // "select id_impuesto, porcentaje, nombre, descripcion from categoria  where nombre_cat ='{0}' ", nomcat),
            OdbcDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                ClsDetalleFolio pfol = new ClsDetalleFolio();

                pfol.cod = _reader.GetInt16(0);
                pfol.descripcion = _reader.GetString(1);
                pfol.prec = _reader.GetInt16(2);

                _lista.Add(pfol);
            }

            return _lista;
        }
    }
}
