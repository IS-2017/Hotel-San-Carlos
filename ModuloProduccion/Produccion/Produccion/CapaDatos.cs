using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;

namespace produccion
{
    public class CapaDatos
    {

        public void InsertarNuevoProceso(String nom_proceso, double tiempo, String medida_tiempo, String descripcion, String observacion)
        {

            OdbcConnection con = seguridad.Conexion.ObtenerConexionODBC();
            OdbcCommand cmd = new OdbcCommand(string.Format("insert into proceso (nombre_proceso,tiempo_proceso,medida_tiempo,caracteristica_proceso,observacion)values('" + nom_proceso + "','" + tiempo + "','" + medida_tiempo + "','" + descripcion + "','" + observacion + "')"),con);
            cmd.ExecuteNonQuery();
            con.Close();




        }
        // Consulta a la tabla bien, cargar datatable con clasificacion y enviarlo al load de nueva formula
        public DataTable CargarDatosBienClasificacion()
        {
            OdbcConnection con = seguridad.Conexion.ObtenerConexionODBC();
            String cadena = "select distinct clasificacion,id_categoria_pk from bien where id_categoria_pk= 'mp';";
            DataTable dt = new DataTable();

            OdbcCommand cmd = new OdbcCommand(cadena, con);
            OdbcDataAdapter adap = new OdbcDataAdapter(cmd);
            adap.Fill(dt);

            dt.Rows.InsertAt(dt.NewRow(), 0);
            con.Close();
            return dt;
        }

        // Consultar la tabla Bien, cargar datatable segun valor escojido por el combo box de clasificacion
        public DataTable CargaDatosBien(String clasificacion)
        {
            OdbcConnection con = seguridad.Conexion.ObtenerConexionODBC();
            String cadena = "select id_bien_pk,descripcion from bien where clasificacion='" + clasificacion + "'";
            DataTable dt = new DataTable();

            OdbcCommand cmd = new OdbcCommand(cadena, con);
            OdbcDataAdapter adap = new OdbcDataAdapter(cmd);

            adap.Fill(dt);
            con.Close();
            return dt;


        }
        // Consulta a la tabla medida, cargar datatable y enviarlo al load de nueva formula
        public DataTable CargarDatosMedida()
        {
            OdbcConnection con = seguridad.Conexion.ObtenerConexionODBC();
            String cadena = "select * from medida";
            DataTable dt = new DataTable();

            OdbcCommand cmd = new OdbcCommand(cadena, con);
            OdbcDataAdapter adap = new OdbcDataAdapter(cmd);

            adap.Fill(dt);

            dt.Rows.InsertAt(dt.NewRow(), 0);
            con.Close();
            return dt;
        }



        // Consulta a la tabla procesos, cargar datatable y enviarlo al load de nueva formula
        public DataTable CargaDatosProceso()
        {
            OdbcConnection con = seguridad.Conexion.ObtenerConexionODBC();
            String cadena = "select * from proceso;";
            DataTable dt = new DataTable();

            OdbcCommand cmd = new OdbcCommand(cadena, con);
            OdbcDataAdapter adap = new OdbcDataAdapter(cmd);
            adap.Fill(dt);
            dt.Rows.InsertAt(dt.NewRow(), 0);
            con.Close();
            return dt;
        }

        // Consulta para traer el valor de horas hombre
        public DataTable SeleccionarHorasHombre(string seleccion)
        {
            OdbcConnection con = seguridad.Conexion.ObtenerConexionODBC();
            string cadena = "select tiempo_proceso from proceso where id_proceso_pk='" + seleccion + "'";
            DataTable dt = new DataTable();
            OdbcCommand cmd = new OdbcCommand(cadena, con);
            OdbcDataAdapter adap = new OdbcDataAdapter(cmd);

            adap.Fill(dt);
            con.Close();
            return dt;

        }

        // Consulta para traer el valor de costo de materia prima
        public DataTable SeleccionCostoMateriaPrima(string dato)
        {
            OdbcConnection con = seguridad.Conexion.ObtenerConexionODBC();
            string cadena = "select costo from bien where id_bien_pk='" + dato + "'";
            DataTable dt = new DataTable();
            OdbcCommand cmd = new OdbcCommand(cadena, con);
            OdbcDataAdapter adap = new OdbcDataAdapter(cmd);
            adap.Fill(dt);
            con.Close();
            return dt;
        }

        // Consulta para traer el ultimo valor ingresado por parte del encabezado de formula
        public DataTable SeleccionUltimoDatoFormula()
        {
            OdbcConnection con = seguridad.Conexion.ObtenerConexionODBC();
            string cadena = "select max(id_receta_pk) from receta";
            DataTable dt = new DataTable();
            OdbcCommand cmd = new OdbcCommand(cadena,con);
            OdbcDataAdapter adap = new OdbcDataAdapter(cmd);
            adap.Fill(dt);
            con.Close();
            return dt;
        }

        // ------------------------------------------------------- CONSULTAS DE Formulario RECETARIO --------------------------------

        public DataTable ConsultarReceta()
        {
            OdbcConnection con = seguridad.Conexion.ObtenerConexionODBC();
            String cadena = "Select * from receta";
            DataTable dt = new DataTable();
            OdbcCommand cmd = new OdbcCommand(cadena, con);
            OdbcDataAdapter adap = new OdbcDataAdapter(cmd);

            adap.Fill(dt);
            con.Close();
            return dt;
        }
        // ---------------------------------------- CONSULTAS DE Formulario MODIFICAR RECETARIO -----------------------------------

        public DataTable ConsultarRecetaDetalle(string id_receta_encabezado)
        {
            OdbcConnection con = seguridad.Conexion.ObtenerConexionODBC();
            String consulta = "select * from detalle_receta_mp where id_receta_pk='" + id_receta_encabezado + "'";
            DataTable dt = new DataTable();
            OdbcCommand cmd = new OdbcCommand(consulta, con);
            OdbcDataAdapter adap = new OdbcDataAdapter(cmd);
            adap.Fill(dt);
            con.Close();
            return dt;

        }

        // ----------------------- LLENAR COMBOBOX DE PEDIDOS..........
        public DataTable ConsultarPedidos()
        {
            OdbcConnection con = seguridad.Conexion.ObtenerConexionODBC();
            String consulta = "select * from encabezado_pedido";
            DataTable dt = new DataTable();
            OdbcCommand cmd = new OdbcCommand(consulta, con);
            OdbcDataAdapter adap = new OdbcDataAdapter(cmd);
            adap.Fill(dt);
            //dt.Rows.InsertAt(dt.NewRow(), 0);
            con.Close();
            return dt;

        }
        // ---------------------- LLENAR DATAGRID CON VALUE SELECCIONADO DEL COMBOBOX-------
        public DataTable ConsultarPedidoDetalle(String valor)
        {
            OdbcConnection con = seguridad.Conexion.ObtenerConexionODBC();
            //String consulta = "select * from detalle_pedido_rest where id_encabezado_pedido_pk='" + valor + "'";
            //String consulta = "select det.cantidad, m.nombre,det.descuento, det.id_menu_pk , det.orden, det.correlativo  from detalle_pedido_rest det, menu m where  det.id_encabezado_pedido_pk = '"+valor+"' and det.id_menu_pk = m.id_menu_pk and m.correlativo = det.correlativo; ";
            String consulta = "select det.cantidad, m.nombre,det.descuento, det.id_menu_pk , det.orden, det.correlativo, r.horas_hombre,r.costo_receta from detalle_pedido_rest det, menu m, receta r where det.id_encabezado_pedido_pk = '"+valor+"' and det.id_menu_pk = m.id_menu_pk and m.correlativo = det.correlativo and m.id_receta_pk = r.id_receta_pk; ";

            DataTable dt = new DataTable();
            OdbcCommand cmd = new OdbcCommand(consulta, con);
            OdbcDataAdapter adap = new OdbcDataAdapter(cmd);
            adap.Fill(dt);
            con.Close();
            return dt;

        }

        // ----------------------- LLENAR DATAGRID CON DETALLE DE MATERIA PRIMA SEGUN LINEA DE DETALLE 
        public DataTable ConsultarMateriaPrimaSegunPedido(String llave_primaria , String correlativo)
        {
            OdbcConnection con = seguridad.Conexion.ObtenerConexionODBC();
            //String consulta = " select m.nombre, r.nombre_receta, d.id_bien_pk ,b.descripcion, d.cantidad ,me.nombre_medida from menu m, receta r , detalle_receta_mp d, bien b , medida me where m.id_receta_pk = '"+valor+"' and m.id_receta_pk = r.id_receta_pk and r.id_receta_pk = d.id_receta_pk and d.id_bien_pk = b.id_bien_pk and d.id_medida_pk = me.id_medida_pk; ";
            //String consulta = " select m.nombre, r.nombre_receta, d.id_bien_pk ,b.descripcion, d.cantidad ,me.nombre_medida from menu m, receta r , detalle_receta_mp d, bien b , medida me where m.id_receta_pk = '"+valor+"' and m.id_receta_pk = r.id_receta_pk and r.id_receta_pk = d.id_receta_pk and d.id_bien_pk = b.id_bien_pk and d.id_medida_pk = me.id_medida_pk; ";
            String consulta = "  select m.nombre, r.nombre_receta, d.id_bien_pk, d.cantidad,me.nombre_medida, b.descripcion from menu m , receta r, detalle_receta_mp d , medida me, bien b  where m.id_menu_pk = '"+llave_primaria+"' and m.correlativo = '"+correlativo+"' and m.id_receta_pk = r.id_receta_pk and r.id_receta_pk = d.id_receta_pk and d.id_medida_pk = me.id_medida_pk and d.id_bien_pk = b.id_bien_pk; ";
            DataTable dt = new DataTable();
            OdbcCommand cmd = new OdbcCommand(consulta, con);
            OdbcDataAdapter adap = new OdbcDataAdapter(cmd);
            adap.Fill(dt);
            con.Close();
            return dt;

        }


    }

    }

