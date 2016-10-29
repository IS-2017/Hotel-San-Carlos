using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using seguridad;
using System.Data;
using System.Windows.Forms;

namespace Inventario
{
    class SistemaInventarioDatos
    {
        bitacora bita = new bitacora();

        public int AgregarCategoria(string id_cat, string nombre_cat )
        {
            try
            {
                OdbcConnection con = Conexion.ConexionPermisos();
                string query = "insert into categoria (id_categoria_pk, tipo_categoria, estado) values ('"+id_cat+"', '" + nombre_cat + "', 'activo')";
                OdbcCommand cmd = new OdbcCommand(query, con);
                cmd.ExecuteNonQuery();
                bita.Insertar("insercion de categoria: " +nombre_cat , "categoria");
                con.Close();
                return 1;
            }
            catch { return 0; }

        }


        public DataTable ObtenerCategorias()
        {
            OdbcConnection con = Conexion.ConexionPermisos();
            DataTable dt = new DataTable();
            string query = "select id_categoria_pk, tipo_categoria from  categoria where estado = 'activo'" ;
            OdbcCommand cmd = new OdbcCommand(query, con);
            OdbcDataAdapter adp = new OdbcDataAdapter(cmd);
            adp.Fill(dt);
            con.Close();
            return dt;

        }

        public DataTable VistaBodega()
        {
            OdbcConnection con = Conexion.ConexionPermisos();
            DataTable dt = new DataTable();
            string query = "select b.nombre_bodega, b.ubicacion, e.nombre from bodega b INNER JOIN empresa e ON b.id_empresa_pk = e.id_empresa_pk where b.estado = 'activo'";
            OdbcCommand cmd = new OdbcCommand(query, con);
            OdbcDataAdapter adp = new OdbcDataAdapter(cmd);
            adp.Fill(dt);
            con.Close();
            return dt;

        }

        public DataTable ObtenerBodega()
        {
            OdbcConnection con = Conexion.ConexionPermisos();
            DataTable dt = new DataTable();
            string query = "select id_bodega_pk, nombre_bodega, ubicacion from  bodega where estado = 'activo'";
            OdbcCommand cmd = new OdbcCommand(query, con);
            OdbcDataAdapter adp = new OdbcDataAdapter(cmd);
            adp.Fill(dt);
            con.Close();
            return dt;

        }

        public DataTable ObtenerCosto(string codigo)
        {
            OdbcConnection con = Conexion.ConexionPermisos();
            DataTable dt = new DataTable();
            string query = "select costo from bien where concat(id_categoria_pk,'-',id_bien_pk)  = '"+codigo+"'";
            OdbcCommand cmd = new OdbcCommand(query, con);
            OdbcDataAdapter adp = new OdbcDataAdapter(cmd);
            adp.Fill(dt);
            con.Close();
            return dt;

        }

        public DataTable ObtenerMedidas()
        {
            OdbcConnection con = Conexion.ConexionPermisos();
            DataTable dt = new DataTable();
            string query = "select abreviatura, nombre_medida from  medida where estado = 'activo'";
            OdbcCommand cmd = new OdbcCommand(query, con);
            OdbcDataAdapter adp = new OdbcDataAdapter(cmd);
            adp.Fill(dt);
            con.Close();
            return dt;

        }


        public DataTable ObtenerMedidastodo()
        {
            OdbcConnection con = Conexion.ConexionPermisos();
            DataTable dt = new DataTable();
            string query = "select * from  medida where estado = 'activo'";
            OdbcCommand cmd = new OdbcCommand(query, con);
            OdbcDataAdapter adp = new OdbcDataAdapter(cmd);
            adp.Fill(dt);
            con.Close();
            return dt;

        }


        public int AgregarMedida(string abreviatura, string nombre_med)
        {
            try
            {
                OdbcConnection con = Conexion.ConexionPermisos();
                string query = "insert into medida(id_medida_pk, nombre_medida, abreviatura, estado) values ( null ,'" + nombre_med + "', '" + abreviatura + "', 'activo')";
                OdbcCommand cmd = new OdbcCommand(query, con);
                cmd.ExecuteNonQuery();
                // bita.Insertar("insercion de medida: " +nombre_med , "medida");
                con.Close();
                return 1;
            }
            catch { return 0; }

        }



        public DataTable ObtenerMarcas()
        {
            OdbcConnection con = Conexion.ConexionPermisos();
            DataTable dt = new DataTable();
            string query = "select nombre_marca from  marca where estado = 'activo'";
            OdbcCommand cmd = new OdbcCommand(query, con);
            OdbcDataAdapter adp = new OdbcDataAdapter(cmd);
            adp.Fill(dt);
            con.Close();
            return dt;

        }

        public DataTable ObtenerEmpresas()
        {
            OdbcConnection con = Conexion.ConexionPermisos();
            DataTable dt = new DataTable();
            string query = "select id_empresa_pk, nombre from  empresa where estado = 'activo'";
            OdbcCommand cmd = new OdbcCommand(query, con);
            OdbcDataAdapter adp = new OdbcDataAdapter(cmd);
            adp.Fill(dt);
            con.Close();
            return dt;

        }

        public DataTable LineasporCat(string categoria)
        {
            OdbcConnection con = Conexion.ConexionPermisos();
            DataTable dt = new DataTable();
            string query = "select id_linea_pk, nombre_linea from  linea where id_categoria_pk = '"+categoria+"' and estado = 'activo'";
            OdbcCommand cmd = new OdbcCommand(query, con);
            OdbcDataAdapter adp = new OdbcDataAdapter(cmd);
            adp.Fill(dt);
            con.Close();
            return dt;

        }



        public int AgregarMarca(string marca)
        {
            try
            {
                OdbcConnection con = Conexion.ConexionPermisos();
                string query = "insert into marca(id_marca_pk, nombre_marca, estado) values ( null ,'" + marca + "',  'activo')";
                OdbcCommand cmd = new OdbcCommand(query, con);
                cmd.ExecuteNonQuery();
                // bita.Insertar("insercion de Marca: " +marca , "marca");
                con.Close();
                return 1;
            }
            catch { return 0; }

        }


        public DataTable Obtener(string campo, string tabla)
        {
            OdbcConnection con = Conexion.ConexionPermisos();
            DataTable dt = new DataTable();
            string query = "select "+campo+" from  "+tabla+" where estado = 'activo'";
            OdbcCommand cmd = new OdbcCommand(query, con);
            OdbcDataAdapter adp = new OdbcDataAdapter(cmd);
            adp.Fill(dt);
            con.Close();
            return dt;

        }

        public DataTable ObtenerMarcastodo()
        {
            OdbcConnection con = Conexion.ConexionPermisos();
            DataTable dt = new DataTable();
            string query = "select * from  marca where estado = 'activo'";
            OdbcCommand cmd = new OdbcCommand(query, con);
            OdbcDataAdapter adp = new OdbcDataAdapter(cmd);
            adp.Fill(dt);
            con.Close();
            return dt;

        }


        public int ObtenerCorrelativoBien(string categoria)
        {
            OdbcConnection con = Conexion.ConexionPermisos();
            string consulta = "select ObtenerCorrelativoBien('" + categoria + "'); ";
            OdbcCommand comando = new OdbcCommand(consulta, con);
            object resultado = comando.ExecuteScalar();
            return Convert.ToInt32(resultado);
        }


        public int AgregarBien(string id_categoria, decimal precio, decimal costo, string desc, int linea, int medida, int marca)
        {
            try
            {
                OdbcConnection con = Conexion.ConexionPermisos();
                 int id_bien = ObtenerCorrelativoBien(id_categoria);
                string query = "insert into bien (id_bien_pk, id_categoria_pk, precio, costo, descripcion, id_linea_pk, apartados, id_medida_pk, id_marca_pk, estado) values ("+id_bien+", '"+id_categoria+"',"+precio+", "+costo+", '"+desc+"', "+linea+", 0 , "+medida+", "+marca+", 'activo')";
                OdbcCommand cmd = new OdbcCommand(query, con);
                cmd.ExecuteNonQuery();
                // bita.Insertar("insercion de bien " +desc , "bien");
                //**********************************
                BienBodegaCero(id_categoria, id_bien);
                con.Close();
                return 1;
            }
            catch { return 0; }

        }

        public int BienBodegaCero(string id_categoria, int id_bien)
        {
            try
            {
                OdbcConnection con = Conexion.ConexionPermisos();
                string query = "insert into producto_bodega (id_bien_pk, id_categoria_pk, id_bodega_pk, existencia, estado) values (" + id_bien + ", '" + id_categoria + "', 0 , 0 , 'activo')";
                OdbcCommand cmd = new OdbcCommand(query, con);
                cmd.ExecuteNonQuery();
                // bita.Insertar("insercion de bien " +desc , "bien");
                con.Close();
                return 1;
            }
            catch { return 0; }

        }



        public DataTable MostrarInventario()
        {
            OdbcConnection con = Conexion.ConexionPermisos();
            DataTable dt = new DataTable();
            string query = "select CONCAT(b.id_categoria_pk,'-', b.id_bien_pk) as CODIGO, b.descripcion, c.tipo_categoria, sum(pb.existencia), b.precio, b.costo, m.nombre_medida, li.nombre_linea, ma.nombre_marca   from bien b INNER JOIN categoria c ON b.id_categoria_pk = c.id_categoria_pk INNER JOIN medida m ON b.id_medida_pk = m.id_medida_pk INNER JOIN marca ma ON b.id_marca_pk = ma.id_marca_pk INNER JOIN producto_bodega pb ON b.id_bien_pk = pb.id_bien_pk and b.id_categoria_pk = pb.id_categoria_pk INNER JOIN linea li ON b.id_linea_pk = li.id_linea_pk where b.estado = 'activo' group by CODIGO";
            OdbcCommand cmd = new OdbcCommand(query, con);
            OdbcDataAdapter adp = new OdbcDataAdapter(cmd);
            adp.Fill(dt);
            con.Close();
            return dt;

        }


        public int AgregarBodega(string ubicacion, string nombre_bodega, int empresa)
        {
            try
            {
                OdbcConnection con = Conexion.ConexionPermisos();
                string query = "insert into bodega (id_bodega_pk, ubicacion, nombre_bodega, id_empresa_pk, estado) values (null, '" + ubicacion + "', '" + nombre_bodega + "', "+empresa+",'activo')";
                OdbcCommand cmd = new OdbcCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                return 1;
            }
            catch { return 0; }

        }

        public DataTable ObtenerLineas()
        {
            OdbcConnection con = Conexion.ConexionPermisos();
            DataTable dt = new DataTable();
            string query = "select l.nombre_linea, c.tipo_categoria from  linea l INNER JOIN categoria c ON l.id_categoria_pk = c.id_categoria_pk where l.estado = 'activo'";
            OdbcCommand cmd = new OdbcCommand(query, con);
            OdbcDataAdapter adp = new OdbcDataAdapter(cmd);
            adp.Fill(dt);
            con.Close();
            return dt;

        }



        public int AgregarLinea(string nombre_linea, string categoria)
        {
            try
            {
                OdbcConnection con = Conexion.ConexionPermisos();
                string query = "insert into linea (id_linea_pk, nombre_linea, id_categoria_pk, estado) values (null ,'" + nombre_linea + "', '" + categoria + "', 'activo')";
                OdbcCommand cmd = new OdbcCommand(query, con);
                cmd.ExecuteNonQuery();
                //bita.Insertar("insercion de lìnea: " + nombre_linea, "linea");
                con.Close();
                return 1;
            }
            catch { return 0; }

        }


        public DataTable ObtenerBien()
        {
            OdbcConnection con = Conexion.ConexionPermisos();
            DataTable dt = new DataTable();
            string query = "select CONCAT(id_categoria_pk,'-',id_bien_pk) as CODIGO, descripcion  from bien where estado = 'activo';";
            OdbcCommand cmd = new OdbcCommand(query, con);
            OdbcDataAdapter adp = new OdbcDataAdapter(cmd);
            adp.Fill(dt);
            con.Close();
            return dt;

        }

        public DataTable ObtenerBien2()
        {
            OdbcConnection con = Conexion.ConexionPermisos();
            DataTable dt = new DataTable();
            string query = "select id_bien_pk, descripcion from bien where estado = 'activo'";
            OdbcCommand cmd = new OdbcCommand(query, con);
            OdbcDataAdapter adp = new OdbcDataAdapter(cmd);
            adp.Fill(dt);
            con.Close();
            return dt;

        }




        public DataTable ObtenerProveedor()
        {
            OdbcConnection con = Conexion.ConexionPermisos();
            DataTable dt = new DataTable();
            string query = "select id_proveedor_pk, nombre_proveedor from  proveedor where estado = 'activo'";
            OdbcCommand cmd = new OdbcCommand(query, con);
            OdbcDataAdapter adp = new OdbcDataAdapter(cmd);
            adp.Fill(dt);
            con.Close();
            return dt;

        }

        public DataTable ObtenerReq()
        {
            OdbcConnection con = Conexion.ConexionPermisos();
            DataTable dt = new DataTable();
            string query = "select id_requisicion_pk from  requisicion where estado = 'activo'";
            OdbcCommand cmd = new OdbcCommand(query, con);
            OdbcDataAdapter adp = new OdbcDataAdapter(cmd);
            adp.Fill(dt);
            con.Close();
            return dt;

        }

        public DataTable ObtenerOrden()
        {
            OdbcConnection con = Conexion.ConexionPermisos();
            DataTable dt = new DataTable();
            string query = "select id_factura_compra_pk from  compra where estado = 'activo'";
            OdbcCommand cmd = new OdbcCommand(query, con);
            OdbcDataAdapter adp = new OdbcDataAdapter(cmd);
            adp.Fill(dt);
            con.Close();
            return dt;

        }


        public DataTable ObtenerDetalleReq(string id_req)
        {
            OdbcConnection con = Conexion.ConexionPermisos();
            DataTable dt = new DataTable();
  /*REQ*/    string query = "select id_categoria_pk, id_bien_pk, cantidad from  detalle_requisicion where id_requisicion_pk = "+id_req+" and estado = 'activo'";
 /*OC*/     //string query = "select id_categoria_pk, id_bien_pk, cantidad from  detalle_compra where id_factura_compra_pk = " + id_req + " and estado = 'activo'";
            OdbcCommand cmd = new OdbcCommand(query, con);
            OdbcDataAdapter adp = new OdbcDataAdapter(cmd);
            adp.Fill(dt);
            con.Close();
            return dt;

        }

        //****************************

        public int AgregarRequisicion( string fecha, string encargado, int bodega, DataGridView articulos)
        {
            try
            {
                OdbcConnection con = Conexion.ConexionPermisos();

                string query_ereq = "insert into requisicion (id_requisicion_pk, fecha, encargado, id_bodega_pk, estado) values (null ,'" +fecha + "', '" + encargado + "', "+bodega+",'activo')";
                OdbcCommand cmd_e = new OdbcCommand(query_ereq, con);
                cmd_e.ExecuteNonQuery();

               
                DataTable dt = new DataTable();
                OdbcCommand comando = new OdbcCommand("select max(id_requisicion_pk) from requisicion", con);
                OdbcDataAdapter adaptador = new OdbcDataAdapter(comando);
                adaptador.Fill(dt);
                DataRow rowm = dt.Rows[0];
                int id_req = Convert.ToInt32(rowm[0]);

                char delimitador =  '-' ;

                foreach (DataGridViewRow row in articulos.Rows)
                {
                if (row.Cells["Codigo"].Value != null)
                    {
                    string codigo = row.Cells["Codigo"].Value.ToString();
                 
                    string[] codigo_separado = codigo.Split(delimitador);

                    string id_categoria = codigo_separado[0].ToString();
                    MessageBox.Show(id_categoria);
                    string id_bien = codigo_separado[1].Trim();
                    MessageBox.Show(id_bien);

                    int cantidad = Convert.ToInt32(row.Cells["Cant_pedida"].Value);

                    string query = "insert into detalle_requisicion (id_detalle_requisicion_pk, id_requisicion_pk, id_categoria_pk, id_bien_pk, cantidad, estado) values (null, " + id_req + ", '" + id_categoria + "'," + id_bien + "," + cantidad + ", 'activo' )";
                    // bitacora.Permisos("Asignacion de permiso: " + "ins: " + row[1].ToString() + " sel: " + row[2].ToString() + " upd: " + row[3].ToString() + " del: " + row[4].ToString() + " a perfil: " + id_perfil + " Sobre aplicacion: " + row[0].ToString(), "perfil_privilegios");
                    OdbcCommand cmd = new OdbcCommand(query, con);
                    cmd.ExecuteNonQuery();
                    }
                }
                con.Close();
                return 1;
        }
            catch { return 0; }
        }

  //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
  //>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>


        public int Agregar_encabezado_muestreo(string fecha, string responsable)
        {
            try
            {
                OdbcConnection con = Conexion.ConexionPermisos();
                string query = "insert into encabezado_muestreo(id_muestreo_pk, fecha,responsable, estado) values (null, '" + fecha + "', '" + responsable + "','activo')";

                OdbcCommand cmd = new OdbcCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                return 1;
            }
            catch { return 0; }

        }


        public int Agregar_detalle_muestreo(string id_muestreo, string descripcion, string existencia, string id_bien_pk, string bodega, string id_categoria_pk, string existencia_auditada)
        {
            try
            {
                OdbcConnection con = Conexion.ConexionPermisos();
                string query = "insert into detalle_muestreo(id_muestreo_pk, descripcion,existencia, id_bien_pk, id_bodega_pk, id_categoria_pk, existencias_auditadas) values ('" + id_muestreo + "', '" + descripcion + "','" + existencia + "', '" + id_bien_pk + "', '" + bodega + "','" + id_categoria_pk + "','" + existencia_auditada + "')";

                OdbcCommand cmd = new OdbcCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                return 1;
                MessageBox.Show("bien");
            }
            catch { return 0; }
            MessageBox.Show("mal");
        }

        public void Actualizar(string query)
        {
            {
                try
                {

                    OdbcConnection con = Conexion.ConexionPermisos();
                    OdbcCommand comando = new OdbcCommand(query, con);
                    OdbcDataReader dr;
                    dr = comando.ExecuteReader();
                    con.Close();
                    MessageBox.Show("Actualizacion Exitosa");
                    //txt_nombre.Text = "";


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
        public DataTable Load_detalle(string query)
        {
            OdbcConnection con = Conexion.ConexionPermisos();
            DataTable dt = new DataTable();
            OdbcCommand cmd = new OdbcCommand(query, con);
            OdbcDataAdapter adp = new OdbcDataAdapter(cmd);
            adp.Fill(dt);
            con.Close();
            return dt;

        }
        public void Eliminar(string query)
        {
            try
            {

                OdbcConnection con = Conexion.ConexionPermisos();
                DialogResult resultado = MessageBox.Show("¿Seguro que desea eliminarlo?", "Aceptar", MessageBoxButtons.OKCancel);
                if (resultado == DialogResult.OK)
                {

                    OdbcCommand comando = new OdbcCommand(query, con);
                    comando.ExecuteNonQuery();

                }
                con.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Insertarenproductobodega(string id_bien_pk, string id_bodega_pk, string id_categoria_pk, string existencia, string existencia_congelada, string existencia_auditada)
        {
            try
            {
                OdbcConnection con = Conexion.ConexionPermisos();
                string query = "insert into producto_bodega (id_bien_pk, id_bodega_pk, id_categoria_pk, existencia, existencia_congelada, existencia_auditada) values ('" + id_bien_pk + "','" + id_bodega_pk + "','" + id_categoria_pk + "','" + existencia + "','" + existencia_congelada + "','" + existencia_auditada + "')";
                OdbcCommand cmd = new OdbcCommand(query, con);
                cmd.ExecuteNonQuery();
                // bita.Insertar("insercion de bien " +desc , "bien");
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("error");
            }

        }


        public int Borrar(string query)
        {
            try
            {
                OdbcConnection con = Conexion.ConexionPermisos();

                OdbcCommand cmd = new OdbcCommand(query, con);
                cmd.ExecuteNonQuery();
                // bita.Insertar("insercion de bien " +desc , "bien");
                //**********************************
                con.Close();
                return 1;
            }
            catch { return 0; }

        }


        public DataTable Obtener_encabezado_muestreo()
        {
            OdbcConnection con = Conexion.ConexionPermisos();
            DataTable dt = new DataTable();
            string query = "select id_muestreo_pk, fecha, responsable,estado from encabezado_muestreo where estado = 'activo'";
            OdbcCommand cmd = new OdbcCommand(query, con);
            OdbcDataAdapter adp = new OdbcDataAdapter(cmd);
            adp.Fill(dt);
            con.Close();
            return dt;

        }

        public DataTable CongelarExistencias(String query)
        {
            OdbcConnection con = Conexion.ConexionPermisos();
            DataTable dt = new DataTable();
            OdbcCommand cmd = new OdbcCommand(query, con);
            OdbcDataAdapter adp = new OdbcDataAdapter(cmd);
            adp.Fill(dt);
            con.Close();
            return dt;
        }

        public void ActualizarBogedaproducto(string existencia_congelada, string existencia_auditada, string id_bien, string id_bodega_pk, string id_categoria)
        {
            try
            {
                OdbcConnection con = Conexion.ConexionPermisos();
                string query = "update producto_bodega set existencia_congelada = '" + existencia_congelada + "', existencia_auditada = '" + existencia_auditada + "'  where id_bien_pk= '" + id_bien + "' and id_bodega_pk = '" + id_bodega_pk + " ' and id_categoria_pk = '" + id_categoria + "'";
                OdbcCommand cmd = new OdbcCommand(query, con);
                cmd.ExecuteNonQuery();
                // bita.Insertar("insercion de bien " +desc , "bien");

                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("error");
            }

        }





    }
}
