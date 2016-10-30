using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Conexion;
using System.Data.Odbc;
using System.Windows.Forms;

namespace SistemaUsuarios
{
    class SistemaUsuarioDatos
    {



        public DataTable ObtenerPerfiles()
        {
            OdbcConnection con = Conexion.Conexion.ObtenerConexionODBC();
            DataTable dt = new DataTable();
            OdbcCommand cmd = new OdbcCommand("select id_perfil, nombre_perfil from perfil",con);
            OdbcDataAdapter adp = new OdbcDataAdapter(cmd);
            adp.Fill(dt);
            con.Close();
            return dt;
        }

        public DataTable ObtenerAplicaciones()
        {
            OdbcConnection con = Conexion.Conexion.ObtenerConexionODBC();
            DataTable dt = new DataTable();
            OdbcCommand cmd = new OdbcCommand("select * from aplicacion", con);
            OdbcDataAdapter adp = new OdbcDataAdapter(cmd);
            adp.Fill(dt);
            con.Close();
            return dt;
        }

        public DataTable ObtenerPermisosPorPerfilesdg(string perfil)
        {
            OdbcConnection con = Conexion.Conexion.ObtenerConexionODBC();
            
            DataTable dt = new DataTable();
            string query = "select a.nombre_aplicacion, p.ins, p.sel, p.upd, p.del from aplicacion a inner join perfil_privilegios p on a.id_aplicacion = p.id_aplicacion where p.id_perfil = " + perfil;
            OdbcCommand cmd = new OdbcCommand(query, con);
            OdbcDataAdapter adp = new OdbcDataAdapter(cmd);
            adp.Fill(dt);

            
            con.Close();
            return dt;
            
        }

        public DataTable ObtenerPermisosPorPerfilesdt(string perfil)
        {
            OdbcConnection con = Conexion.Conexion.ObtenerConexionODBC();
            DataTable dt = new DataTable();
            string query = "select id_aplicacion, ins, sel, upd, del from  perfil_privilegios where id_perfil = " + perfil;
            OdbcCommand cmd = new OdbcCommand(query, con);
            OdbcDataAdapter adp = new OdbcDataAdapter(cmd);
            adp.Fill(dt);
            con.Close();
            return dt;

        }

        public int InsertarPerfil(string nombre_perfil)
        {

            try
            {
                OdbcConnection con = Conexion.Conexion.ObtenerConexionODBC();
                string query = "insert into perfil (id_perfil, nombre_perfil) values (null, '" + nombre_perfil + "')";
                OdbcCommand cmd = new OdbcCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                return 1;
            }
            catch { return 0; }
        }

        public int InsertarUsuario(string usuario,  string contraseña, int perfil)
        {

            try
            {
                OdbcConnection con = Conexion.Conexion.ObtenerConexionODBC();
                string query = "insert into usuario (usuario, contraseña, id_perfil) values ('"+usuario+"', '" + contraseña + "', "+perfil+")";
                OdbcCommand cmd = new OdbcCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                return 1;
            }
            catch { return 0; }
        }


        public int CrearUsuario(string usuario, string contraseña)
        {
            try
            {
                OdbcConnection con = Conexion.Conexion.ObtenerConexionODBC();
                string query = "create user " + usuario + " identified by '" + contraseña + "' ";
                OdbcCommand cmd = new OdbcCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                return 1;
            }
            catch { return 0; }
        }

        public int InsertarPermisosPerfil( DataTable permisos)
        {
            try
            {
                OdbcConnection con = Conexion.Conexion.ObtenerConexionODBC();

                DataTable dt = new DataTable();
                string querys = "select max(id_perfil)from perfil";
                OdbcCommand cmds = new OdbcCommand(querys, con);
                OdbcDataAdapter adap = new OdbcDataAdapter(cmds);
                adap.Fill(dt);
                DataRow row2 = dt.Rows[0];
                string id_perfil = row2[0].ToString();

                foreach (DataRow row in permisos.Rows)
                {
                    string query = "insert into perfil_privilegios (id_perfil, id_aplicacion, ins, sel, upd, del) values (" + id_perfil + ", " + row[0].ToString() + ", " + row[1] + "," + row[2] + "," + row[3] + ", " + row[4] + " )";
                    OdbcCommand cmd = new OdbcCommand(query, con);
                    cmd.ExecuteNonQuery();
                    
                }
                return 1;
            }
            catch { return 0; }
        }


    }
}
