using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;

namespace produccion
{
    public class produccionOP
    {
        public string carga_hh(string pedido)
        {
            string ped;
            try
            {
                OdbcConnection con = seguridad.Conexion.ObtenerConexionODBC();
                OdbcCommand cmd = new OdbcCommand("Select cant_hh from asignacion_mp where id_encabezado_pedido_pk='" + pedido + "'", con);
                OdbcDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ped = reader.GetString(0);
                    return ped;
                }
                con.Close();
            }
            catch
            {
                MessageBox.Show("Error al obtener cliente");
            }
            return null;
        }
        public DataTable cargar_rrhh()
        {
            try
            {
                OdbcConnection con = seguridad.Conexion.ObtenerConexionODBC();
                OdbcCommand cmd = new OdbcCommand("select e.id_empresa_pk as Empresa,e.id_empleados_pk as ID, e.nombre as Nombre,e.cargo as Cargo,round(((e.sueldo/30)/j.horas_trabajo),2) as Costo_x_Hora,j.horas_trabajo,e.disponibilidad, (j.horas_trabajo - a.cant_horas) as horas_disponibles FROM empleado e left JOIN jornada_trabajo j ON e.id_jornada_tra_pk = j.id_jornada_tra_pk left OUTER JOIN asignacion_mo a ON a.id_empresa_pk = e.id_empresa_pk AND a.id_empleados_pk = e.id_empleados_pk WHERE e.disponibilidad = 1; ", con);
                DataTable dt = new DataTable();
                OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                da.Fill(dt);
                con.Close();
                return dt;

            }

            catch
            {
                MessageBox.Show("Error de carga de datos de trabajadores");
                return null;
            }

        }
        public int inserta_prod(string id_ped, string costo_mo, string costo_mp, string costo_maq, string costo_prod, string fecha_caduc)
        {
            try
            {
                OdbcConnection con = seguridad.Conexion.ObtenerConexionODBC();
                OdbcCommand cmd = new OdbcCommand("Insert into produccion(id_encabezado_pedido_pk,costo_mano_de_obra,costo_materia_prima,costo_maquinaria,hora_produccion,fecha_produccion,costo_produccion,fecha_caducidad)values('" + id_ped + "','" + costo_mo + "','" + costo_mp + "','" + costo_maq + "',current_time(),curdate(),'" + costo_prod + "', '" + fecha_caduc + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();
                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Error al guardar detalle de pedido", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                return 0;
            }
            //Select concat(e.id_empresa_pk,'-',e.id_empleados_pk)as ID, e.nombre,e.cargo,e.sueldo,((e.sueldo/30)/j.horas_trabajo) as Costo_x_Hora,j.horas_trabajo,e.disponibilidad from empleado e, jornada_trabajo j where e.id_jornada_tra_pk=j.id_jornada_tra_pk and e.disponibilidad=1;

        }
        public int inserta_mo(string enc, string colab, string empresa, string fecha, decimal costo,string canth)
        {
            try
            {
                OdbcConnection con = seguridad.Conexion.ObtenerConexionODBC();
                OdbcCommand cmd = new OdbcCommand("insert into asignacion_mo(id_encabezado_pedido_pk,id_empleados_pk,id_empresa_pk,cant_horas,fecha_asig,costo)values('" + enc + "','" + colab + "','" + empresa + "','"+ canth +"','" + fecha + "'," + costo + ")", con);
                cmd.ExecuteNonQuery();
                con.Close();
                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Error al guardar detalle de pedido", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                return 0;
            }
        }
        public DataTable carga_pedidos()
        {
            try
            {
                OdbcConnection con = seguridad.Conexion.ObtenerConexionODBC();
                OdbcCommand cmd = new OdbcCommand("Select id_encabezado_pedido_pk from encabezado_pedido where estado='enpro' ORDER by id_encabezado_pedido_pk DESC", con);
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

        public string carga_mp(string pedido)
        {
            string costo;    
            try
            {
                OdbcConnection con = seguridad.Conexion.ObtenerConexionODBC();
                OdbcCommand cmd = new OdbcCommand(" select sum(round(r.costo_receta* d.cantidad)) as costo_mp from receta r, detalle_pedido_rest d where d.id_encabezado_pedido_pk='" + pedido + "'", con);
                OdbcDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    costo = reader.GetString(0);
                    return costo;
                }
                con.Close();
            }
            catch
            {
                MessageBox.Show("Error al obtener cliente");
            }
            return null;
        }
        public DataTable carga_pedidos2()
        {
            try
            {
                OdbcConnection con = seguridad.Conexion.ObtenerConexionODBC();
                OdbcCommand cmd = new OdbcCommand("Select id_encabezado_pedido_pk from encabezado_pedido where estado='pend' ORDER by id_encabezado_pedido_pk DESC", con);
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
        public DataTable carga_detalle_pedido2(string id)
        {
            try
            {
                OdbcConnection con = seguridad.Conexion.ObtenerConexionODBC();
                OdbcCommand cmd = new OdbcCommand("Select * from detalle_pedido_rest where id_encabezado_pedido_pk='"+id+"'", con);
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


    }
}
