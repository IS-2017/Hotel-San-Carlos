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
    public class CapaDatos
    {

        public void InsertarNuevoProceso(String nom_proceso, double tiempo, String medida_tiempo, String descripcion, String observacion)
        {

            OdbcConnection con = seguridad.Conexion.ObtenerConexionODBC();
            OdbcCommand cmd = new OdbcCommand(string.Format("insert into proceso (nombre_proceso,tiempo_proceso,medida_tiempo,caracteristica_proceso,observacion)values('" + nom_proceso + "','" + tiempo + "','" + medida_tiempo + "','" + descripcion + "','" + observacion + "')"), con);
            cmd.ExecuteNonQuery();
            con.Close();




        }
        // Consulta a la tabla bien, cargar datatable con clasificacion y enviarlo al load de nueva formula
        public DataTable CargarDatosBienClasificacion()
        {
            OdbcConnection con = seguridad.Conexion.ObtenerConexionODBC();
            String cadena = "select distinct b.id_linea_pk, l.nombre_linea, b.id_categoria_pk from bien b, linea l where b.id_categoria_pk= 'MP' and l.id_linea_pk = b.id_linea_pk;";
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
            String cadena = "select id_bien_pk,descripcion from bien where id_linea_pk='" + clasificacion + "'";
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
            OdbcCommand cmd = new OdbcCommand(cadena, con);
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
            String consulta = "select det.cantidad, m.nombre,det.descuento, det.id_menu_pk , det.orden, det.correlativo, r.horas_hombre,r.costo_receta from detalle_pedido_rest det, menu m, receta r where det.id_encabezado_pedido_pk = '" + valor + "' and det.id_menu_pk = m.id_menu_pk and m.correlativo = det.correlativo and m.id_receta_pk = r.id_receta_pk; ";

            DataTable dt = new DataTable();
            OdbcCommand cmd = new OdbcCommand(consulta, con);
            OdbcDataAdapter adap = new OdbcDataAdapter(cmd);
            adap.Fill(dt);
            con.Close();
            return dt;

        }

        // ----------------------- LLENAR DATAGRID CON DETALLE DE MATERIA PRIMA SEGUN LINEA DE DETALLE 
        public DataTable ConsultarMateriaPrimaSegunPedido(String llave_primaria, String correlativo)
        {
            OdbcConnection con = seguridad.Conexion.ObtenerConexionODBC();
            //String consulta = " select m.nombre, r.nombre_receta, d.id_bien_pk ,b.descripcion, d.cantidad ,me.nombre_medida from menu m, receta r , detalle_receta_mp d, bien b , medida me where m.id_receta_pk = '"+valor+"' and m.id_receta_pk = r.id_receta_pk and r.id_receta_pk = d.id_receta_pk and d.id_bien_pk = b.id_bien_pk and d.id_medida_pk = me.id_medida_pk; ";
            //String consulta = " select m.nombre, r.nombre_receta, d.id_bien_pk ,b.descripcion, d.cantidad ,me.nombre_medida from menu m, receta r , detalle_receta_mp d, bien b , medida me where m.id_receta_pk = '"+valor+"' and m.id_receta_pk = r.id_receta_pk and r.id_receta_pk = d.id_receta_pk and d.id_bien_pk = b.id_bien_pk and d.id_medida_pk = me.id_medida_pk; ";
            String consulta = "  select m.nombre, r.nombre_receta, d.id_bien_pk, d.cantidad,me.nombre_medida, b.descripcion,m.id_menu_pk, m.correlativo ,r.horas_hombre,r.costo_receta, pb.existencia from menu m , receta r, detalle_receta_mp d , medida me, bien b, producto_bodega pb  where m.id_menu_pk = '" + llave_primaria + "' and m.correlativo = '" + correlativo + "' and m.id_receta_pk = r.id_receta_pk and r.id_receta_pk = d.id_receta_pk and d.id_medida_pk = me.id_medida_pk and d.id_bien_pk = b.id_bien_pk and b.id_bien_pk = pb.id_bien_pk;; ";
            //                          0           1               2               3           4               5               6           7               8               9               10
            DataTable dt = new DataTable();
            OdbcCommand cmd = new OdbcCommand(consulta, con);
            OdbcDataAdapter adap = new OdbcDataAdapter(cmd);
            adap.Fill(dt);
            con.Close();
            return dt;

        }
        // ----------- LLENAR COMBOBOX DE RECETAS EN FORMULARIO DE NUEVO MENU----------------
        public DataTable ConsultarRecetas()
        {
            DataTable dt = new DataTable();
            OdbcConnection con = seguridad.Conexion.ObtenerConexionODBC();
            //string cadena = "select id_receta_pk,nombre_receta costo_receta from receta;";
            string cadena = "select * from receta";
            OdbcCommand cmd = new OdbcCommand(cadena, con);
            OdbcDataAdapter adap = new OdbcDataAdapter(cmd);

            adap.Fill(dt);
            dt.Rows.InsertAt(dt.NewRow(), 0);

            con.Close();
            return dt;

        }
        //------------------ LLENAR COMBOBOX DE TAMANIO PORCION EN FORMULARIO DE NUEVO MENU
        public DataTable ConsultarTamanioPorcion()
        {
            DataTable dt = new DataTable();
            OdbcConnection con = seguridad.Conexion.ObtenerConexionODBC();
            string cadena = "select * from tamanio_porcion;";
            OdbcCommand cmd = new OdbcCommand(cadena, con);
            OdbcDataAdapter adap = new OdbcDataAdapter(cmd);

            adap.Fill(dt);
            dt.Rows.InsertAt(dt.NewRow(), 0);
            //dt.Rows.InsertAt(dt.NewRow(), 0);
            con.Close();
            return dt;

        }

        // ----------------- CONSULTAR PRECIO DE RECETA ESCOGIDA EN FORMULARIO DE NUEVO MENU
        public DataTable ConsultarPrecioReceta(string valor)
        {
            DataTable dt = new DataTable();
            OdbcConnection con = seguridad.Conexion.ObtenerConexionODBC();
            string cadena = "select costo_receta from receta where id_receta_pk='" + valor + "';";
            OdbcCommand cmd = new OdbcCommand(cadena, con);
            OdbcDataAdapter adap = new OdbcDataAdapter(cmd);

            adap.Fill(dt);
            con.Close();
            return dt;

        }
        // ------------------- CONSULTAR VALOR DE TABLA TAMANIO_PORCION EN FORMULARIO DE NUEVO MENU
        public DataTable ConsultarValorPorcion(string parametro)
        {
            string consulta = "select * from tamanio_porcion where id_tamaniop_pk='" + parametro + "';";
            DataTable data = new DataTable();
            OdbcCommand cmd = new OdbcCommand(consulta, seguridad.Conexion.ObtenerConexionODBC());
            OdbcDataAdapter adap = new OdbcDataAdapter(cmd);

            adap.Fill(data);

            return data;
        }

        // ------------------- INSERTAR NUEVO PRECIO DE NUEVO MENU ----------------
        public void InsertarNuevoPrecio(String precio, String id_categoria, String id_tamanio)
        {
            string cadena = "insert into precio (precio, id_categoria_pk, id_tamaniop_pk)values  ('" + precio + "','" + id_categoria + "','" + id_tamanio + "'); ";
            OdbcConnection con = seguridad.Conexion.ObtenerConexionODBC();
            OdbcCommand cmt = new OdbcCommand(cadena, seguridad.Conexion.ObtenerConexionODBC());
            //OdbcCommand cmd = new OdbcCommand(string.Format("insert into proceso (nombre_proceso,tiempo_proceso,medida_tiempo,caracteristica_proceso,observacion)values('" + nom_proceso + "','" + tiempo + "','" + medida_tiempo + "','" + descripcion + "','" + observacion + "')"), con);
            cmt.ExecuteNonQuery();
            con.Close();




        }

        // ----------------------CONSULTAR PRECIO INGRESADO DE NUEVO MENU -----------------
        public DataTable ConsultarUltimoValorPrecio()
        {
            string cadena = "select max(id_precio) from precio";
            DataTable data = new DataTable();
            OdbcCommand cmd = new OdbcCommand(cadena, seguridad.Conexion.ObtenerConexionODBC());
            OdbcDataAdapter adap = new OdbcDataAdapter(cmd);

            adap.Fill(data);

            return data;
        }

        // ---------------------- INSERTAR UN NUEVO MENU A LA TABLA MENU -----------------------
        public void InsertarNuevoMenu(String id_menu, String nombre_menu, String descripcion, String id_receta, String id_precio)
        {
            string cadena = "insert into menu (id_menu_pk, nombre, descripcion,id_receta_pk,id_precio)values  ('" + id_menu + "','" + nombre_menu + "','" + descripcion + "','" + id_receta + "','" + id_precio + "'); ";
            OdbcConnection con = seguridad.Conexion.ObtenerConexionODBC();
            OdbcCommand cmt = new OdbcCommand(cadena, seguridad.Conexion.ObtenerConexionODBC());

            cmt.ExecuteNonQuery();
            con.Close();




        }

        // -------------------------------- MODIFICAR TABLA DE FORMULAS O RECETAS ------------------------------
        public void ModificarReceta(String cantidad, String id_proceso, String id_medida, String id_categoria, String id_bien, String correlativo)
        {
            String cadena = "update detalle_receta_mp set cantidad = '" + cantidad + "', id_proceso_pk = '" + id_proceso + "', id_medida_pk = '" + id_medida + "' , id_categoria_pk='" + id_categoria + "', id_bien_pk = '" + id_bien + "' where correlativo = '" + correlativo + "';";
            OdbcConnection con = seguridad.Conexion.ObtenerConexionODBC();
            OdbcCommand cmd = new OdbcCommand(cadena, con);
            //OdbcDataAdapter adap = new OdbcDataAdapter(cmd);
            //OdbcCommand cmd = new OdbcCommand(string.Format("insert into proceso (nombre_proceso,tiempo_proceso,medida_tiempo,caracteristica_proceso,observacion)values('" + cantidad + "','" + id_proceso + "','" + id_medida + "','" + id_categoria + "','" + id_bien + "')"), con);
            cmd.ExecuteNonQuery();
            con.Close();




        }

        // --------------------------------- Consultar nombres especificos de la tabla detalle_pedido_mp -----------------------
        public DataTable ConsultarNombresRecetaDetalle(string id_receta_encabezado)
        {
            OdbcConnection con = seguridad.Conexion.ObtenerConexionODBC();
            String consulta = "select  r.nombre_receta, b.clasificacion,b.descripcion, d.cantidad, m.nombre_medida ,p.nombre_proceso,p.tiempo_proceso,b.costo,d.correlativo from detalle_receta_mp d, receta r, proceso p, medida m, bien b where d.id_receta_pk = '" + id_receta_encabezado + "' and d.id_receta_pk = r.id_receta_pk and d.id_proceso_pk = p.id_proceso_pk and d.id_medida_pk = m.id_medida_pk and d.id_bien_pk = b.id_bien_pk; ";
            DataTable dt = new DataTable();
            OdbcCommand cmd = new OdbcCommand(consulta, con);
            OdbcDataAdapter adap = new OdbcDataAdapter(cmd);
            adap.Fill(dt);
            con.Close();
            return dt;

        }

        // --------------------------------- Update al estado de tabla encabezado_pedido

        public void ActualizarEstadoEncabezadoPedido(string id_encabezado_pedido)
        {
            OdbcConnection con = seguridad.Conexion.ObtenerConexionODBC();
            String cadena = "update encabezado_pedido set estado = 'enpro' where id_encabezado_pedido_pk = '" + id_encabezado_pedido + "';";
            OdbcCommand cmd = new OdbcCommand(cadena, con);
            cmd.ExecuteNonQuery();
            con.Close();



        }

        // --------------------------------- Insertar encabezado requisicion ---------------------------

        public void InsertarEncabezadoRequisicion(string usuario)
        {
            OdbcConnection con = seguridad.Conexion.ObtenerConexionODBC();
            String cadena = "insert into requisicion (fecha,encargado,id_bodega_pk) values (sysdate(),'" + usuario + "','2');";
            OdbcCommand cmd = new OdbcCommand(cadena, con);
            cmd.ExecuteNonQuery();
            con.Close();



        }
        //-----------------------------------  Consulta ultimo valor ingresado requisicion encabezado
        public DataTable ConsultarUltimoValorRequisicion()
        {
            OdbcConnection con = seguridad.Conexion.ObtenerConexionODBC();
            String consulta = "select max(id_requisicion_pk) from requisicion;";
            DataTable dt = new DataTable();
            OdbcCommand cmd = new OdbcCommand(consulta, con);
            OdbcDataAdapter adap = new OdbcDataAdapter(cmd);
            adap.Fill(dt);
            con.Close();
            return dt;

        }
        public int AgregarBien(decimal precio, decimal costo, string nombre, int linea, int medida, int marca)
        {
            try
            {
                string categoria = "PT";
                OdbcConnection con = seguridad.Conexion.ObtenerConexionODBC();
                int id_bien = ObtenerCorrelativoBien(categoria);
                string query = "insert into bien(id_bien_pk, id_categoria_pk, precio, costo, descripcion, id_linea_pk,id_medida_pk, id_marca_pk,estado) values (" + id_bien + ",'" + categoria + "'," + precio + ","+costo+",'"+nombre+"',"+linea+","+medida+","+marca+",'activo')";
                OdbcCommand cmd = new OdbcCommand(query, con);
                cmd.ExecuteNonQuery();
//                bita.Insertar("insercion de bien " + desc, "bien");
                //**********************************
                BienBodegaCero( categoria,id_bien);
                con.Close();
                return 1;
            }
            catch(Exception ex) {
                MessageBox.Show("ERROR EN EL BIEN");
                return 0;
            }
        }

        public int BienBodegaCero(string id_categoria, int id_bien)
        {
            try
            {
                OdbcConnection con = seguridad.Conexion.ObtenerConexionODBC();
                string query = "insert into producto_bodega (id_bien_pk, id_categoria_pk, id_bodega_pk, existencia, estado) values (" + id_bien + ", '" + id_categoria + "', 1, 1 , 'activo')";
                OdbcCommand cmd = new OdbcCommand(query, con);
                cmd.ExecuteNonQuery();
                // bita.Insertar("insercion de bien " +desc , "bien");
                con.Close();
                return 1;
            }
            catch(Exception ex) {
                MessageBox.Show("ERROR EN PRODUCTO_BODEGA");
                return 0; }

        }
        public int ObtenerCorrelativoBien(string categoria)
        {
            try
            {
                OdbcConnection con = seguridad.Conexion.ObtenerConexionODBC();
                string consulta = "select ObtenerCorrelativoBien('" + categoria + "'); ";
                OdbcCommand comando = new OdbcCommand(consulta, con);
                object resultado = comando.ExecuteScalar();
                return Convert.ToInt32(resultado);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR EN CORRELATIVO");
                return 0;
            }

        }
        public DataTable ObtenerMarcastodo()
        {
            OdbcConnection con = seguridad.Conexion.ObtenerConexionODBC();
            DataTable dt = new DataTable();
            string query = "select * from  marca where estado = 'activo'";
            OdbcCommand cmd = new OdbcCommand(query, con);
            OdbcDataAdapter adp = new OdbcDataAdapter(cmd);
            adp.Fill(dt);
            con.Close();
            return dt;

        }
        public DataTable Consulta_linea()
        {
         
            OdbcConnection con = seguridad.Conexion.ObtenerConexionODBC();
            DataTable dt = new DataTable();
            string query = "select * from  linea where id_categoria_pk = 'PT'";
            OdbcCommand cmd = new OdbcCommand(query, con);
            OdbcDataAdapter adp = new OdbcDataAdapter(cmd);
            adp.Fill(dt);
            con.Close();
            return dt;

        }

    }
    }


