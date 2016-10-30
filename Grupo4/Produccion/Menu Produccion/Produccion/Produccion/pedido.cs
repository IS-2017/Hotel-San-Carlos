using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;
/*
 Autor: Yony Calito
 UD: 24/10/2016
     */
namespace produccion
{
    public class pedido
    {

        public string generador_correlativo()
        {
            try
            {
                OdbcConnection con = seguridad.Conexion.ObtenerConexionODBC();
                string query = "select generador_correlativo()"; //funcion que permit visualizar el ultimo ID insertado, con lo cual muestra el correlativo correspondiente para el pedido actual
                OdbcCommand cmd = new OdbcCommand(query, con);
                OdbcDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    return dr.GetString(0);
                }
                else
                {
                    return "Error al generar correlativo";
                }
            }
            catch
            {
                MessageBox.Show("Error al cargar ID");
                return null;
            }
        }
        public DataTable Carga_datos(string usuario)
        {
            try
            {
                OdbcConnection con = seguridad.Conexion.ObtenerConexionODBC();
                OdbcCommand cmd = new OdbcCommand("select us.id_empresa_pk as id_empresa, us.id_empleados_pk as id_empleado, c.nombre as nombre_colab, e.nombre as nombre_emp from usuario us INNER JOIN empleado c ON us.id_empleados_pk = c.id_empleados_pk AND us.id_empresa_pk = c.id_empresa_pk INNER JOIN empresa e ON us.id_empresa_pk = e.id_empresa_pk WHERE usuario = '" + usuario + "'; ", con);
                DataTable dt = new DataTable();
                OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                da.Fill(dt);
                con.Close();
                return dt;

            }

            catch
            {
                MessageBox.Show("Error de carga de datos");
                return null;
            }

        }
        public DataTable buscar_cte(string parametro)
        {

            try
            {
                OdbcConnection con = seguridad.Conexion.ObtenerConexionODBC();
                DataTable dt = new DataTable();
                OdbcCommand cmd = new OdbcCommand("select * from cliente where nombre LIKE '" + parametro + "' OR apellido LIKE '" + parametro + "' OR nit LIKE '" + parametro + "'", con);
                OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                da.Fill(dt);
                con.Close();
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Error al cargar datos", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                return null;
            }
        }
        public static info_cte obtener_cte(string dato)
        {
            info_cte info_cte = new info_cte();
            try
            {
                OdbcConnection con = seguridad.Conexion.ObtenerConexionODBC();
                OdbcCommand cmd = new OdbcCommand("select id_cliente_pk from cliente where id_cliente_pk='" + dato + "'",con);
                OdbcDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    info_cte.id_cliente = reader.GetString(0);
                }
                con.Close();
            }
            catch
            {
                MessageBox.Show("Error al obtener cliente");
            }
            return info_cte;
        }
        public DataTable Carga_tipo()
        {
            try
            {
                OdbcConnection con = seguridad.Conexion.ObtenerConexionODBC();
                OdbcCommand cmd = new OdbcCommand("Select distinct id_menu_pk from menu", con);
                DataTable dt = new DataTable();
                OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                da.Fill(dt);
                con.Close();
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Error de carga de datos");
                return null;
            }

        }

        //cargamos los productos en función del tipo de id que se envie como parametro, ej: BB signifca que solo se desplegan bebidas
        public DataTable carga_productos(string tipo)
        {
            try
            {
                OdbcConnection con = seguridad.Conexion.ObtenerConexionODBC();
                OdbcCommand cmd = new OdbcCommand("Select distinct m.correlativo as ID, concat(m.nombre,'-',t.tamanio)as NOMBRE, p.precio as precio FROM menu m, tamanio_porcion t, precio p WHERE m.id_menu_pk = '"+tipo+"' AND m.id_precio =p.id_precio AND p.id_tamaniop_pk = t.id_tamaniop_pk;", con);
                DataTable dt = new DataTable();
                OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                da.Fill(dt);
                con.Close();
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Error de carga de datos");
                return null;
            }
        }
        public DataTable carga_precio(string tipo, string producto)
        {
            try
            {
                OdbcConnection con = seguridad.Conexion.ObtenerConexionODBC();
                OdbcCommand cmd = new OdbcCommand("Select p.precio as precio from precio p, menu m WHERE m.id_menu_pk='"+tipo+ "' AND m.correlativo='"+producto+"' AND m.id_precio=p.id_precio", con);
                DataTable dt = new DataTable();
                OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                da.Fill(dt);
                con.Close();
                return dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Error de carga de datos");
                return null;
            }
        }
        public int inserta_encabezado(string id, string hi,string fi, string clie, string fe, string he, string emp, string col)
        {
            try
            {
                OdbcConnection con = seguridad.Conexion.ObtenerConexionODBC();
                OdbcCommand cmd = new OdbcCommand("insert into encabezado_pedido(id_encabezado_pedido_pk,hora_ingreso,fecha_ingreso,id_cliente_pk,fecha_entrega,hora_entrega,id_empresa_pk,id_empleados_pk)values('"+id+"','"+hi+ "','"+fi+ "','"+clie+ "','"+fe+ "','"+he+ "','"+emp+ "','"+col+"')", con);
                cmd.ExecuteNonQuery();
                con.Close();
                return 1;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Error al guardar pedido", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                return 0;
            }
        }
        public int inserta_detalle(string id_enc, string tipo, int prod, double cant, double desc )
        {
            try
            {
                OdbcConnection con = seguridad.Conexion.ObtenerConexionODBC();
                OdbcCommand cmd = new OdbcCommand("insert into detalle_pedido_rest(id_encabezado_pedido_pk,id_menu_pk,correlativo,cantidad,descuento)values('"+id_enc+ "','"+tipo+"',"+prod+","+cant+","+desc+")", con);
                cmd.ExecuteNonQuery();
                con.Close();
                return 1;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Error al guardar detalle de pedido", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                return 0;
            }
        }
    } 
}
