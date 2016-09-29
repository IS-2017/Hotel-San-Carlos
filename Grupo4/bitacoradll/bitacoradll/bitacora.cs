using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Net;
using Conexion;

namespace bitacoradll
{
    public class bitacora
    {
        // --------------- Metodo para registrar en la bitacora lo que se esta insertando ----------------------- 
        public void Insertar( string accion)
        {
            accion = "Insertar: " + accion;
            try
            {
               
                ClaseTomaIp ip = new ClaseTomaIp();
                string localIP = ip.direccion();

                OdbcCommand cmd = new OdbcCommand(string.Format("insert into bitacora(usuario,accion,ip,hora_y_fecha)"
                + "values('" + Conexion.Conexion.Role + "','" + accion + "','" + localIP + "',sysdate())"), Conexion.Conexion.ObtenerConexionODBC());
                cmd.ExecuteNonQuery();


            }

            catch (Exception)
            {
                System.Console.WriteLine("Error insertando en bitacora");
            }

        }



        // --------------- Metodo para registrar en la bitacora lo que se esta Modificando ----------------------- 


        public void Modificar(string accion)
        {
            accion = "Modificar: " + accion;
            try
            {
                ClaseTomaIp ip = new ClaseTomaIp();
                string localIP = ip.direccion();


                OdbcCommand cmd = new OdbcCommand(string.Format("insert into bitacora(usuario,accion,ip,hora_y_fecha)"
                + "values('" + Conexion.Conexion.Role + "','" + accion + "','" + localIP + "',sysdate())"), Conexion.Conexion.ObtenerConexionODBC());
                cmd.ExecuteNonQuery();


            }

            catch (Exception)
            {
                System.Console.WriteLine("Error insertando en bitacora");
            }

        }


        // --------------- Metodo para registrar en la bitacora lo que se esta Eliminando ----------------------- 


        public void Eliminar(string accion)
        {
            accion = "Eliminar: " + accion;
            try
            {
                ClaseTomaIp ip = new ClaseTomaIp();
                string localIP = ip.direccion();


                OdbcCommand cmd = new OdbcCommand(string.Format("insert into bitacora(usuario,accion,ip,hora_y_fecha)"
                + "values('" + Conexion.Conexion.Role + "','" + accion + "','" + localIP + "',sysdate())"), Conexion.Conexion.ObtenerConexionODBC());
                cmd.ExecuteNonQuery();


            }

            catch (Exception)
            {
                System.Console.WriteLine("Error insertando en bitacora");
            }

        }

    }    
}

