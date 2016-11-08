using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using FuncionesNavegador;
using System.Data.Odbc;
using dllconsultas;


namespace ModuloAdminHotel
{
    public partial class Frm_Folio : Form
    {
        metodos con = new metodos();
        CapaNegocio fn = new CapaNegocio();
        string NO_form = "15101";
        seguridad.bitacora bita = new seguridad.bitacora();
        public Frm_Folio()
        {
            InitializeComponent();
        }
        int cont = 0;
        

        public Frm_Folio(String id_folio_tipo, String id_cuentas_pagar, String id_tipo,Boolean Editar1,DataGridView dgv_folio,String dgv,String client_filtro)
        {
            InitializeComponent();
            load_carga();

            if (dgv == "dgv_folio_habitacion")
            {
                this.datagrid = dgv;
                cont++;
                string filtro = client_filtro;
                cbo_clientefiltro.Text = filtro;
                string a0 = id_folio_tipo;//id del folio intermedio
                this.tipo_folio = a0;
                string a1 = id_cuentas_pagar;//id del folio
                string a2 = id_tipo;//nombre del tipo de lo que es el folio
                cbo_folio_hab.Text = a1;
                cbo_habitacion.Text = a2;
                tabControl1.SelectedTab = tabPage2;
                con.actualizargrid(Squeery, dgv_folio_habitacion);
            }
            else if(dgv == "dgv_folio_salon")
            {
                this.datagrid = dgv;
                cb10();//carga de combobox de cliente filtro
                string filtro = client_filtro;
                cbo_clientefiltro.Text = filtro;
                string a0 = id_folio_tipo;//id del folio intermedio
                this.tipo_folio = a0;
                string a1 = id_cuentas_pagar;//id del folio
                string a2 = id_tipo;//nombre del tipo de lo que es el folio
                cbo_folio_salon.Text = a1;
                cbo_salon.Text = a2;
                tabControl1.SelectedTab = tabPage3;
                con.actualizargrid(Squeery1, dgv_folio_salon);
            }
            else if(dgv == "dgv_folio_bien")
            {
                this.datagrid = dgv;
                cb10();//carga de combobox de cliente filtro
                string filtro = client_filtro;
                cbo_clientefiltro.Text = filtro;
                string a0 = id_folio_tipo;//id del folio intermedio
                this.tipo_folio = a0;
                string a1 = id_cuentas_pagar;//id del folio
                cbo_folio_articulo.Text = a1;
                string a2 = id_tipo;//nombre del tipo de lo que es el folio
                cbo_articulo.Text = a2;
                tabControl1.SelectedTab = tabPage4;
                con.actualizargrid(Squeery2, dgv_bien_folio);
            }
            else if (dgv == "dgv_folio_promo")
            {
                this.datagrid = dgv;
                cb10();//carga de combobox de cliente filtro
                string filtro = client_filtro;
                cbo_clientefiltro.Text = filtro;
                string a0 = id_folio_tipo;//id del folio intermedio
                this.tipo_folio = a0;
                string a1 = id_cuentas_pagar;//id del folio
                cbo_folio_paquete.Text = a1;
                string a2 = id_tipo;//nombre del tipo de lo que es el folio
                cbo_paquete.Text = a2;
                tabControl1.SelectedTab = tabPage5;
                con.actualizargrid(Squeery3, dgv_folio_paquete);
            }
            if (dgv == "nada")
            {
                cb10();//carga de combobox de cliente filtro
                string filtro = client_filtro;
                cbo_clientefiltro.Text = filtro;
                tabControl1.SelectedTab = tabPage1;
            }
        }

        string Squeery = "SELECT a.`id_folio_habitacion_pk`,a.`costo`,b.id_reserhabit_pk,c.`id_cuenta_pagar_pk` FROM folio_habitacion a, reservacion_habitacion b, folio c WHERE a.id_reserhabit_pk =b.id_reserhabit_pk AND a.id_cuenta_pagar_pk = c.id_cuenta_pagar_pk";
        string Squeery1 = "SELECT a.`id_folio_salon_pk`,a.`costo`,b.`id_cuenta_pagar_pk`,c.nombre FROM folio_salon a,folio b,evento c WHERE a.id_cuenta_pagar_pk=b.id_cuenta_pagar_pk AND a.id_evento_pk=c.id_evento_pk"; 
        string Squeery2 = "SELECT a.`id_folio_bien_pk`,a.`costo`,b.`id_cuenta_pagar_pk`,c.descripcion FROM folio_bien a,folio b,bien c WHERE a.id_cuenta_pagar_pk=b.id_cuenta_pagar_pk AND a.id_bien_pk=c.id_bien_pk";
        string Squeery3 = "SELECT a.`id_folio_promocion_pk`,a.`costo`,b.`id_cuenta_pagar_pk`,c.nombre FROM folio_promocion a,folio b,promocion c WHERE a.id_cuenta_pagar_pk=b.id_cuenta_pagar_pk AND a.id_promocion_pk=c.id_promocion_pk";
        string Squeery4 = "SELECT * FROM folio WHERE estado = 'Pendiente'";
        string Codigo;
        Boolean entrar = true;
        string tipo_folio, datagrid;
        string tabla = "folio";

        

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        private void Frm_Folio_Load(object sender, EventArgs e)
        {
            DataTable seg = seguridad.ObtenerPermisos.Permisos(seguridad.Conexion.User, NO_form);
            if (seg.Rows.Count > 0)
            {
                fn.desactivarPermiso(seg, btn_guardar, btn_eliminar, btn_editar, btn_nuevo, btn_cancelar, btn_actualizar, btn_buscar, btn_anterior, btn_siguiente, btn_primero, btn_ultimo);
            }
        }

        public void load_carga()
        {
            try
            {
                con.actualizargrid(Squeery, dgv_folio_habitacion);
                con.actualizargrid(Squeery1, dgv_folio_salon);
                con.actualizargrid(Squeery2, dgv_bien_folio);
                con.actualizargrid(Squeery3, dgv_folio_paquete);
                con.actualizargrid(Squeery4, dgv_lista_folio);

                cb10();//carga de combobox de cliente filtro
                string clientefiltro = cbo_clientefiltro.SelectedValue.ToString();
                cb2(clientefiltro);//carga de combobox de reservacion
                cb1(clientefiltro);//carga de combobox de folio1
                cb3(clientefiltro);//carga de combobox de folio2
                cb4(clientefiltro);//carga de combobox de folio3
                cb5(clientefiltro);//carga de combobox de folio4
                cb6(clientefiltro);//carga de combobox de evento
                cb7();//carga de combobox de bien
                cb8();//carga de combobox de promocion
                cb9();//carga de combobox de cliente
            }
            catch
            {
                MessageBox.Show("NO EXISTE NINGUN CLIENTE EN LA BASE DE DATOS\nLos datos no cargaron de forma correcta", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        //=======================================================================================================================
        //--------------------------------------LLENADO DE COMBOBOX--------------------------------------------------------------
        //=======================================================================================================================
        //programador:walter Recinos Rosales
        //fecha inicio: 12-10-2016
        //fecha finalizacion: 19-10-2016
        private void cb1(string id_folio)
        {
            try
            {
                con.Conectar();
                //se inicia un DataSet
                DataSet ds = new DataSet();
                //se indica la consulta en sql
                String Query = "select id_cuenta_pagar_pk from folio WHERE estado = 'Pendiente' AND id_cliente_pk = '"+ id_folio + "';";
                OdbcDataAdapter dad = new OdbcDataAdapter(Query, con.rutaconectada());
                //se indica con quu tabla se llena
                dad.Fill(ds, "folio");
                cbo_folio_hab.DataSource = ds.Tables[0].DefaultView;
                //indicamos el valor de los miembros
                cbo_folio_hab.ValueMember = ("id_cuenta_pagar_pk");
                //se indica el valor a desplegar en el combobox
                cbo_folio_hab.DisplayMember = ("id_cuenta_pagar_pk");
                con.Desconectar();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Los datos no cargaron de forma correcta" + ex, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cb2(string id_clientefiltro)
        {
            //string clientefiltro = cbo_clientefiltro.SelectedValue.ToString();
            try
            {
                con.Conectar();
                //se inicia un DataSet
                DataSet ds = new DataSet();
                //se indica la consulta en sql
                String Query = "select id_reserhabit_pk from reservacion_habitacion where id_cliente_pk = '"+ id_clientefiltro + "';";
                //String Query = "select id_reserhabit_pk from reservacion_habitacion ;";
                OdbcDataAdapter dad = new OdbcDataAdapter(Query, con.rutaconectada());
                //se indica con quu tabla se llena
                dad.Fill(ds, "reservacion_habitacion");
                cbo_habitacion.DataSource = ds.Tables[0].DefaultView;
                //indicamos el valor de los miembros
                cbo_habitacion.ValueMember = ("id_reserhabit_pk");
                //se indica el valor a desplegar en el combobox
                cbo_habitacion.DisplayMember = ("id_reserhabit_pk");
                con.Desconectar();

            }
            catch (Exception )
            {
                MessageBox.Show("Los datos no cargaron de forma correcta", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cb3(string id_folio)
        {
            try
            {
                con.Conectar();
                //se inicia un DataSet
                DataSet ds = new DataSet();
                //se indica la consulta en sql
                String Query = "select id_cuenta_pagar_pk from folio WHERE estado = 'Pendiente' AND id_cliente_pk = '" + id_folio + "';";
                OdbcDataAdapter dad = new OdbcDataAdapter(Query, con.rutaconectada());
                //se indica con quu tabla se llena
                dad.Fill(ds, "folio");
                cbo_folio_salon.DataSource = ds.Tables[0].DefaultView;
                //indicamos el valor de los miembros
                cbo_folio_salon.ValueMember = ("id_cuenta_pagar_pk");
                //se indica el valor a desplegar en el combobox
                cbo_folio_salon.DisplayMember = ("id_cuenta_pagar_pk");
                con.Desconectar();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Los datos no cargaron de forma correcta" + ex, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void cb4(string id_folio)
        {
            try
            {
                con.Conectar();
                //se inicia un DataSet
                DataSet ds = new DataSet();
                //se indica la consulta en sql
                String Query = "select id_cuenta_pagar_pk from folio WHERE estado = 'Pendiente' AND id_cliente_pk = '" + id_folio + "';";
                OdbcDataAdapter dad = new OdbcDataAdapter(Query, con.rutaconectada());
                //se indica con quu tabla se llena
                dad.Fill(ds, "folio");
                cbo_folio_articulo.DataSource = ds.Tables[0].DefaultView;
                //indicamos el valor de los miembros
                cbo_folio_articulo.ValueMember = ("id_cuenta_pagar_pk");
                //se indica el valor a desplegar en el combobox
                cbo_folio_articulo.DisplayMember = ("id_cuenta_pagar_pk");
                con.Desconectar();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Los datos no cargaron de forma correcta" + ex, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cb5(string id_folio)
        {
            try
            {
                con.Conectar();
                //se inicia un DataSet
                DataSet ds = new DataSet();
                //se indica la consulta en sql
                String Query = "select id_cuenta_pagar_pk from folio WHERE estado = 'Pendiente' AND id_cliente_pk = '" + id_folio + "';";
                OdbcDataAdapter dad = new OdbcDataAdapter(Query, con.rutaconectada());
                //se indica con quu tabla se llena
                dad.Fill(ds, "folio");
                cbo_folio_paquete.DataSource = ds.Tables[0].DefaultView;
                //indicamos el valor de los miembros
                cbo_folio_paquete.ValueMember = ("id_cuenta_pagar_pk");
                //se indica el valor a desplegar en el combobox
                cbo_folio_paquete.DisplayMember = ("id_cuenta_pagar_pk");
                con.Desconectar();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Los datos no cargaron de forma correcta" + ex, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void cb6(string id_clinte)
        {
            try
            {
                con.Conectar();
                //se inicia un DataSet
                DataSet ds = new DataSet();
                //se indica la consulta en sql
                String Query = "select id_evento_pk,nombre from evento WHERE id_cliente_pk = '" + id_clinte + "';";
                OdbcDataAdapter dad = new OdbcDataAdapter(Query, con.rutaconectada());
                //se indica con quu tabla se llena
                dad.Fill(ds, "evento");
                cbo_salon.DataSource = ds.Tables[0].DefaultView;
                //indicamos el valor de los miembros
                cbo_salon.ValueMember = ("id_evento_pk");
                //se indica el valor a desplegar en el combobox
                cbo_salon.DisplayMember = ("nombre");
                con.Desconectar();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Los datos no cargaron de forma correcta" + ex, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void cb7()
        {
            try
            {
                con.Conectar();
                //se inicia un DataSet
                DataSet ds = new DataSet();
                //se indica la consulta en sql
                String Query = "select id_bien_pk,descripcion from bien;";
                OdbcDataAdapter dad = new OdbcDataAdapter(Query, con.rutaconectada());
                //se indica con quu tabla se llena
                dad.Fill(ds, "bien");
                cbo_articulo.DataSource = ds.Tables[0].DefaultView;
                //indicamos el valor de los miembros
                cbo_articulo.ValueMember = ("id_bien_pk");
                //se indica el valor a desplegar en el combobox
                cbo_articulo.DisplayMember = ("descripcion");
                con.Desconectar();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Los datos no cargaron de forma correcta" + ex, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void cb8()
        {
            try
            {
                con.Conectar();
                //se inicia un DataSet
                DataSet ds = new DataSet();
                //se indica la consulta en sql
                String Query = "select id_promocion_pk,nombre from promocion;";
                OdbcDataAdapter dad = new OdbcDataAdapter(Query, con.rutaconectada());
                //se indica con quu tabla se llena
                dad.Fill(ds, "promocion");
                cbo_paquete.DataSource = ds.Tables[0].DefaultView;
                //indicamos el valor de los miembros
                cbo_paquete.ValueMember = ("id_promocion_pk");
                //se indica el valor a desplegar en el combobox
                cbo_paquete.DisplayMember = ("nombre");
                con.Desconectar();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Los datos no cargaron de forma correcta" + ex, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cb9()
        {
            try
            {
                //se realiza la conexión a la base de datos
                con.Conectar();
                //se inicia un DataSet
                DataSet ds = new DataSet();
                //se indica la consulta en sql
                String Query = "select id_cliente_pk,nombre,apellido from cliente;";
                OdbcDataAdapter dad = new OdbcDataAdapter(Query, con.rutaconectada());
                //se indica con quu tabla se llena
                dad.Fill(ds, "cliente");
                cbo_cliente_folio.DataSource = ds.Tables[0].DefaultView;
                //indicamos el valor de los miembros
                cbo_cliente_folio.ValueMember = ("id_cliente_pk");
                //se indica el valor a desplegar en el combobox

                DataTable dt = ds.Tables[0];
                dt.Columns.Add("NewColumn", typeof(string));

                foreach (DataRow dr in dt.Rows)
                {
                    dr["nombre"] = dr["nombre"].ToString() + " " + dr["apellido"].ToString();
                }
                cbo_cliente_folio.DataSource = dt;
                cbo_cliente_folio.DisplayMember = "nombre";
                con.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Los datos no cargaron de forma correcta" + ex, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cb10()
        {
            try
            {
                //se realiza la conexión a la base de datos
                con.Conectar();
                //se inicia un DataSet
                DataSet ds = new DataSet();
                //se indica la consulta en sql
                String Query = "select id_cliente_pk,nombre,apellido from cliente;";
                OdbcDataAdapter dad = new OdbcDataAdapter(Query, con.rutaconectada());
                //se indica con quu tabla se llena
                dad.Fill(ds, "cliente");
                cbo_clientefiltro.DataSource = ds.Tables[0].DefaultView;
                //indicamos el valor de los miembros
                cbo_clientefiltro.ValueMember = ("id_cliente_pk");
                //se indica el valor a desplegar en el combobox

                DataTable dt = ds.Tables[0];
                dt.Columns.Add("NewColumn", typeof(string));

                foreach (DataRow dr in dt.Rows)
                {
                    dr["nombre"] = dr["nombre"].ToString() + " " + dr["apellido"].ToString();
                }
                cbo_clientefiltro.DataSource = dt;
                cbo_clientefiltro.DisplayMember = "nombre";
                con.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Los datos no cargaron de forma correcta" + ex, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //=======================================================================================================================
        //--------------------------------------COMO SABER LA PAGINA_------------------------------------------------------------
        //=======================================================================================================================
        //programador:walter Recinos Rosales
        //fecha inicio: 12-10-2016
        //fecha finalizacion: 19-10-2016

        public void donde()
        {
            if (tabControl1.SelectedTab == tabPage1)
            {
                MessageBox.Show("Folio");
            }
            if (tabControl1.SelectedTab == tabPage2)
            {
                MessageBox.Show("Habitacion");
            }
            if (tabControl1.SelectedTab == tabPage3)
            {
                MessageBox.Show("Salon");
            }
            if (tabControl1.SelectedTab == tabPage4)
            {
                MessageBox.Show("Articulo");
            }
            if (tabControl1.SelectedTab == tabPage5)
            {
                MessageBox.Show("paquete");
            }
            
        }


        //=======================================================================================================================
        //--------------------------------------INSERTAR TABLAS--------------------------------------------------------------
        //=======================================================================================================================
        //programador:walter Recinos Rosales
        //fecha inicio: 12-10-2016
        //fecha finalizacion: 19-10-2016

        public void insertartodo()
        {
           if (tabControl1.SelectedTab == tabPage1)
            {
                try
                {
                    string cliente = cbo_cliente_folio.SelectedValue.ToString();

                    con.Conectar();
                    String Squery = "insert into  folio (estado,fecha_ingreso,costo,id_cliente_pk) values('Pendiente',Sysdate(),'0.00','" + cliente + "');";
                    con.EjecutarQuery(Squery);
                    con.actualizargrid(Squeery4, dgv_lista_folio);
                    //nombre_columna();
                    con.Desconectar();
                    //MessageBox.Show("Folio");
                    string clientefiltro = cbo_clientefiltro.SelectedValue.ToString();
                    cb1(clientefiltro);//carga de combobox de folio1
                    cb3(clientefiltro);//carga de combobox de folio2
                    cb4(clientefiltro);//carga de combobox de folio3
                    cb5(clientefiltro);//carga de combobox de folio4  
                    bita.Insertar("Insercion de nuevo folio","Folio"); 
                }
                catch
                {
                    MessageBox.Show("Llene todos los campos por favor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                                
            }
            if (tabControl1.SelectedTab == tabPage2)
            {

                if (cbo_folio_hab.Text == "" || cbo_habitacion.Text == "")
                {
                    MessageBox.Show("Llene todos los campos por favor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string folio = cbo_folio_hab.SelectedValue.ToString();
                    string habitacion = cbo_habitacion.SelectedValue.ToString();

                    if (Comparar_folio_con_credito(cbo_folio_hab.Text) == true)
                    {
                    }
                    else
                    {
                        MessageBox.Show("HA EXEDIDO LIMITE DE CREDITO", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    if (verificar_reservacion(folio, habitacion) == false)
                    {
                        string nombre = cbo_habitacion.Text;
                        DateTime tiempo = DateTime.Now;

                        con.Conectar();
                        DataTable dt2 = new DataTable();
                        String sQuery2 = "SELECT id_habitacion_pk FROM reservacion_habitacion WHERE id_reserhabit_pk = '" + habitacion + "'";
                        OdbcCommand comando2 = new OdbcCommand(sQuery2, con.rutaconectada());
                        OdbcDataAdapter adaptador2 = new OdbcDataAdapter(comando2);
                        adaptador2.Fill(dt2);
                        DataRow fila2 = dt2.Rows[0];
                        string sid2 = Convert.ToString(fila2[0]);
                        //MessageBox.Show(sid2);
                        con.Desconectar();

                        con.Conectar();
                        DataTable dt = new DataTable();
                        String sQuery = "SELECT id_tipo_pk FROM habitacion WHERE id_habitacion_pk = '" + sid2 + "'";
                        OdbcCommand comando = new OdbcCommand(sQuery, con.rutaconectada());
                        OdbcDataAdapter adaptador = new OdbcDataAdapter(comando);
                        adaptador.Fill(dt);
                        DataRow fila = dt.Rows[0];
                        string sid = Convert.ToString(fila[0]);
                        //MessageBox.Show(sid);
                        con.Desconectar();

                        con.Conectar();
                        DataTable dt1 = new DataTable();
                        String sQuery1 = "SELECT costo_tipo FROM tipo_habitacion WHERE id_tipo_pk = '" + sid + "'";
                        OdbcCommand comando1 = new OdbcCommand(sQuery1, con.rutaconectada());
                        OdbcDataAdapter adaptador1 = new OdbcDataAdapter(comando1);
                        adaptador1.Fill(dt1);
                        DataRow fila1 = dt1.Rows[0];
                        string sid1 = Convert.ToString(fila1[0]);
                        //MessageBox.Show(sid1);
                        con.Desconectar();

                        int costo_tip = Convert.ToInt32(sid1);
                        int costo_total = costo_tip * Dias_reservacion(habitacion);
                        string Costo_dias = Convert.ToString(costo_total);

                        con.Conectar();
                        String Squery = "insert into  folio_habitacion (id_reserhabit_pk,id_cuenta_pagar_pk,costo,fecha) values('" + habitacion + "','" + folio + "','" + Costo_dias + "','" + tiempo + "');";
                        con.EjecutarQuery(Squery);
                        con.actualizargrid(Squeery, dgv_folio_habitacion);
                        //nombre_columna();
                        con.Desconectar();
                        con.guardar_costo_folio(cbo_folio_hab.Text);
                        con.actualizargrid(Squeery4, dgv_lista_folio);
                        detalle_folio_insertar_habitacion(Costo_dias, nombre, folio, tiempo);
                        bita.Insertar("Insercion folio_reservacion", "folio_habitacion");
                    }
                    else
                    {
                        MessageBox.Show("ESTA ACCION YA EXISTE", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            if (tabControl1.SelectedTab == tabPage3)
            {

                if (cbo_folio_salon.Text == "" || cbo_salon.Text == "")
                {
                    MessageBox.Show("Llene todos los campos por favor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string folio = cbo_folio_salon.SelectedValue.ToString();
                    string salon = cbo_salon.SelectedValue.ToString();

                    if (Comparar_folio_con_credito(cbo_folio_salon.Text) == true)
                    {
                    }
                    else
                    {
                        MessageBox.Show("HA EXEDIDO LIMITE DE CREDITO", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    if (verificar_evento(folio, salon) == false)
                    {
                        string nombre = cbo_salon.Text;
                        DateTime tiempo = DateTime.Now;

                        con.Conectar();
                        DataTable dt = new DataTable();
                        String sQuery = "SELECT costo FROM evento WHERE id_evento_pk = '" + salon + "'";
                        OdbcCommand comando = new OdbcCommand(sQuery, con.rutaconectada());
                        OdbcDataAdapter adaptador = new OdbcDataAdapter(comando);
                        adaptador.Fill(dt);
                        DataRow fila = dt.Rows[0];
                        string sid = Convert.ToString(fila[0]);
                        //MessageBox.Show(sid);
                        con.Desconectar();

                        int costo_tip = Convert.ToInt32(sid);
                        int costo_total = costo_tip * Dias_evento(salon);
                        string Costo_dias = Convert.ToString(costo_total);

                        con.Conectar();
                        String Squery = "insert into  folio_salon (id_evento_pk,id_cuenta_pagar_pk,costo,fecha) values('" + salon + "','" + folio + "','" + Costo_dias + "','" + tiempo + "');";
                        con.EjecutarQuery(Squery);
                        con.actualizargrid(Squeery1, dgv_folio_salon);
                        //nombre_columna();
                        con.Desconectar();
                        con.guardar_costo_folio(cbo_folio_salon.Text);
                        con.actualizargrid(Squeery4, dgv_lista_folio);
                        detalle_folio_insertar_salon(Costo_dias, nombre, folio, tiempo);
                        bita.Insertar("Insercion folio_Evento", "folio_salon");
                    }
                    else
                    {
                        MessageBox.Show("ESTA ACCION YA EXISTE", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            if (tabControl1.SelectedTab == tabPage4)
            {
                if (cbo_folio_articulo.Text == "" || cbo_articulo.Text == "")
                {
                    MessageBox.Show("Llene todos los campos por favor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (Comparar_folio_con_credito(cbo_folio_articulo.Text) == true)
                    {

                    }
                    else
                    {
                        MessageBox.Show("HA EXEDIDO LIMITE DE CREDITO", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    string folio = cbo_folio_articulo.SelectedValue.ToString();
                        string bien = cbo_articulo.SelectedValue.ToString();
                        string nombre = cbo_articulo.Text;
                        DateTime tiempo4 = DateTime.Now;


                        con.Conectar();
                        DataTable dt = new DataTable();
                        String sQuery = "SELECT costo FROM bien WHERE id_bien_pk = '" + bien + "'";
                        OdbcCommand comando = new OdbcCommand(sQuery, con.rutaconectada());
                        OdbcDataAdapter adaptador = new OdbcDataAdapter(comando);
                        adaptador.Fill(dt);
                        DataRow fila = dt.Rows[0];
                        string sid = Convert.ToString(fila[0]);
                        //MessageBox.Show(sid);
                        con.Desconectar();



                        con.Conectar();
                        String Squery = "insert into  folio_bien (id_bien_pk,id_cuenta_pagar_pk,costo,fecha) values('" + bien + "','" + folio + "','" + sid + "','" + tiempo4 + "');";
                        con.EjecutarQuery(Squery);
                        con.actualizargrid(Squeery2, dgv_bien_folio);
                        //nombre_columna();
                        con.Desconectar();
                        con.guardar_costo_folio(cbo_folio_articulo.Text);
                        con.actualizargrid(Squeery4, dgv_lista_folio);
                        detalle_folio_insertar_bien(sid, nombre, folio, tiempo4);
                        bita.Insertar("Insercion folio_Articulo", "folio_bien");
                  
                }

            }
            if (tabControl1.SelectedTab == tabPage5)
            {
                if (cbo_folio_paquete.Text == "" || cbo_paquete.Text == "")
                {
                    MessageBox.Show("Llene todos los campos por favor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (Comparar_folio_con_credito(cbo_folio_paquete.Text) == true)
                    {
                    }
                    else
                    {
                        MessageBox.Show("HA EXEDIDO LIMITE DE CREDITO", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    string folio = cbo_folio_paquete.SelectedValue.ToString();
                        string paquete = cbo_paquete.SelectedValue.ToString();
                        string nombre = cbo_paquete.Text;
                        DateTime tiempo = DateTime.Now;

                        con.Conectar();
                        DataTable dt = new DataTable();
                        String sQuery = "SELECT costo FROM promocion WHERE id_promocion_pk = '" + paquete + "'";
                        OdbcCommand comando = new OdbcCommand(sQuery, con.rutaconectada());
                        OdbcDataAdapter adaptador = new OdbcDataAdapter(comando);
                        adaptador.Fill(dt);
                        DataRow fila = dt.Rows[0];
                        string sid = Convert.ToString(fila[0]);
                        //MessageBox.Show(sid);
                        con.Desconectar();



                        con.Conectar();
                        String Squery = "insert into  folio_promocion (id_promocion_pk,id_cuenta_pagar_pk,costo,fecha) values('" + paquete + "','" + folio + "','" + sid + "','" + tiempo + "');";
                        con.EjecutarQuery(Squery);
                        con.actualizargrid(Squeery3, dgv_folio_paquete);
                        //nombre_columna();
                        con.Desconectar();
                        con.guardar_costo_folio(cbo_folio_paquete.Text);
                        con.actualizargrid(Squeery4, dgv_lista_folio);
                        detalle_folio_insertar_promo(sid, nombre, folio, tiempo);
                        bita.Insertar("Insercion folio_Promocion", "folio_promocion");
                    
                }
            }
           
        }

        //=======================================================================================================================
        //--------------------------------------ACTUALIZAR TABLAS--------------------------------------------------------------
        //=======================================================================================================================
        //programador:walter Recinos Rosales
        //fecha inicio: 12-10-2016
        //fecha finalizacion: 19-10-2016

        public void actualizartodo()
        {
            if (tabControl1.SelectedTab == tabPage1)
            {
                MessageBox.Show("Folio no puede actualizarse");
            }
            if (tabControl1.SelectedTab == tabPage2)
            {
                if (cbo_folio_hab.Text == "" || cbo_habitacion.Text == "")
                {
                    MessageBox.Show("Llene todos los campos por favor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string folio = cbo_folio_hab.SelectedValue.ToString();
                    string habitacion = cbo_habitacion.SelectedValue.ToString();

                    if (verificar_reservacion(folio, habitacion) == false)
                    {
                        con.Conectar();
                        DataTable dt = new DataTable();
                        String sQuery = "SELECT id_tipo_pk FROM habitacion WHERE id_habitacion_pk = '" + habitacion + "'";
                        OdbcCommand comando = new OdbcCommand(sQuery, con.rutaconectada());
                        OdbcDataAdapter adaptador = new OdbcDataAdapter(comando);
                        adaptador.Fill(dt);
                        DataRow fila = dt.Rows[0];
                        string sid = Convert.ToString(fila[0]);
                        //MessageBox.Show(sid);
                        con.Desconectar();

                        con.Conectar();
                        DataTable dt1 = new DataTable();
                        String sQuery1 = "SELECT costo_tipo FROM tipo WHERE id_tipo_pk = '" + sid + "'";
                        OdbcCommand comando1 = new OdbcCommand(sQuery1, con.rutaconectada());
                        OdbcDataAdapter adaptador1 = new OdbcDataAdapter(comando1);
                        adaptador1.Fill(dt1);
                        DataRow fila1 = dt1.Rows[0];
                        string sid1 = Convert.ToString(fila1[0]);
                        //MessageBox.Show(sid1);
                        con.Desconectar();

                        int costo_tip = Convert.ToInt32(sid1);
                        int costo_total = costo_tip * Dias_reservacion(habitacion);
                        string Costo_dias = Convert.ToString(costo_total);


                        string id_folio = this.dgv_folio_habitacion.CurrentRow.Cells[3].Value.ToString();
                        Codigo = this.dgv_folio_habitacion.CurrentRow.Cells[0].Value.ToString();
                        con.Conectar();
                        String Squery = "update folio_habitacion  set id_reserhabit_pk ='" + habitacion + "', id_cuenta_pagar_pk ='" + folio + "',costo ='" + Costo_dias + "' where id_folio_habitacion_pk ='" + Codigo + "'";
                        con.EjecutarQuery(Squery);
                        con.actualizargrid(Squeery, dgv_folio_habitacion);
                        //nombre_columna();
                        con.Desconectar();
                        entrar = true;
                        con.guardar_costo_folio(cbo_folio_hab.Text);
                        con.actualizargrid(Squeery4, dgv_lista_folio);
                        detale_folio_update_habitacion(Codigo, Costo_dias);
                        bita.Modificar("Modificar folio_Reservacion", "folio_habitacion");
                    }
                }
            }
            if (tabControl1.SelectedTab == tabPage3)
            {
                try
                {
                    if (cbo_folio_salon.Text == "" || cbo_salon.Text == "")
                    {
                        MessageBox.Show("Llene todos los campos por favor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        string folio = cbo_folio_salon.SelectedValue.ToString();
                        string salon = cbo_salon.SelectedValue.ToString();

                        if (verificar_evento(folio, salon) == false)
                        {
                            con.Conectar();
                            DataTable dt = new DataTable();
                            String sQuery = "SELECT costo FROM evento WHERE id_evento_pk = '" + salon + "'";
                            OdbcCommand comando = new OdbcCommand(sQuery, con.rutaconectada());
                            OdbcDataAdapter adaptador = new OdbcDataAdapter(comando);
                            adaptador.Fill(dt);
                            DataRow fila = dt.Rows[0];
                            string sid = Convert.ToString(fila[0]);
                            //MessageBox.Show(sid);
                            con.Desconectar();

                            int costo_tip = Convert.ToInt32(sid);
                            int costo_total = costo_tip * Dias_evento(salon);
                            string Costo_dias = Convert.ToString(costo_total);

                            string id_folio = this.dgv_folio_salon.CurrentRow.Cells[2].Value.ToString();
                            Codigo = this.dgv_folio_salon.CurrentRow.Cells[0].Value.ToString();
                            con.Conectar();
                            String Squery = "update folio_salon set id_evento_pk ='" + salon + "', id_cuenta_pagar_pk ='" + folio + "',costo ='" + Costo_dias + "' where id_folio_salon_pk ='" + Codigo + "'";
                            con.EjecutarQuery(Squery);
                            con.actualizargrid(Squeery1, dgv_folio_salon);
                            //nombre_columna();
                            con.Desconectar();
                            entrar = true;
                            con.guardar_costo_folio(cbo_folio_salon.Text);
                            con.actualizargrid(Squeery4, dgv_lista_folio);
                            detale_folio_update_salon(Codigo, Costo_dias);
                            bita.Modificar("Modificar folio_Evento", "folio_salon");
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Llene todos los campos por favor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            if (tabControl1.SelectedTab == tabPage4)
            {
                if (cbo_folio_articulo.Text == "" || cbo_articulo.Text == "")
                {
                    MessageBox.Show("Llene todos los campos por favor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string folio = cbo_folio_articulo.SelectedValue.ToString();
                    string bien = cbo_articulo.SelectedValue.ToString();

                    con.Conectar();
                    DataTable dt = new DataTable();
                    String sQuery = "SELECT costo FROM bien WHERE id_bien_pk = '" + bien + "'";
                    OdbcCommand comando = new OdbcCommand(sQuery, con.rutaconectada());
                    OdbcDataAdapter adaptador = new OdbcDataAdapter(comando);
                    adaptador.Fill(dt);
                    DataRow fila = dt.Rows[0];
                    string sid = Convert.ToString(fila[0]);
                    //MessageBox.Show(sid);
                    con.Desconectar();



                    string id_folio = this.dgv_bien_folio.CurrentRow.Cells[2].Value.ToString();
                    Codigo = this.dgv_bien_folio.CurrentRow.Cells[0].Value.ToString();
                    con.Conectar();
                    String Squery = "update folio_bien  set id_bien_pk ='" + bien + "', id_cuenta_pagar_pk ='" + folio + "',costo ='" + sid + "' where id_folio_bien_pk ='" + Codigo + "'";
                    con.EjecutarQuery(Squery);
                    con.actualizargrid(Squeery2, dgv_bien_folio);
                    //nombre_columna();
                    con.Desconectar();
                    entrar = true;
                    con.guardar_costo_folio(cbo_folio_articulo.Text);
                    con.actualizargrid(Squeery4, dgv_lista_folio);
                    detale_folio_update_bien(Codigo, sid);
                    bita.Modificar("Modificar folio_Articulo", "folio_bien");
                }
            }
            if (tabControl1.SelectedTab == tabPage5)
            {
                if (cbo_folio_paquete.Text == "" || cbo_paquete.Text == "")
                {
                    MessageBox.Show("Llene todos los campos por favor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string folio = cbo_folio_paquete.SelectedValue.ToString();
                    string paquete = cbo_paquete.SelectedValue.ToString();

                    con.Conectar();
                    DataTable dt = new DataTable();
                    String sQuery = "SELECT costo FROM promocion WHERE id_promocion_pk = '" + paquete + "'";
                    OdbcCommand comando = new OdbcCommand(sQuery, con.rutaconectada());
                    OdbcDataAdapter adaptador = new OdbcDataAdapter(comando);
                    adaptador.Fill(dt);
                    DataRow fila = dt.Rows[0];
                    string sid = Convert.ToString(fila[0]);
                    //MessageBox.Show(sid);
                    con.Desconectar();


                    string id_folio = this.dgv_folio_paquete.CurrentRow.Cells[2].Value.ToString();
                    Codigo = this.dgv_folio_paquete.CurrentRow.Cells[0].Value.ToString();
                    con.Conectar();
                    String Squery = "update folio_promocion set id_promocion_pk ='" + paquete + "', id_cuenta_pagar_pk ='" + folio + "',costo ='" + sid + "' where id_folio_promocion_pk ='" + Codigo + "'";
                    con.EjecutarQuery(Squery);
                    con.actualizargrid(Squeery3, dgv_folio_paquete);
                    //nombre_columna();
                    con.Desconectar();
                    entrar = true;
                    con.guardar_costo_folio(cbo_folio_paquete.Text);
                    detale_folio_update_promo(Codigo, sid);
                    con.actualizargrid(Squeery4, dgv_lista_folio);
                    bita.Modificar("Modificar folio_Promocion", "folio_promocion");
                }
            }
           
        }

        //=======================================================================================================================
        //-----------------------------------BOTON ACTUALIZAR DGV  - COMBOBOX ---------------------------------------------------
        //=======================================================================================================================
        //programador:walter Recinos Rosales
        //fecha inicio: 19-10-2016
        //fecha finalizacion: 26-10-2016

        private void button6_Click(object sender, EventArgs e)
        {

            try
            {
                cb7();//carga de combobox de bien
                cb8();//carga de combobox de promocion
                cb9();//carga de combobox de cliente

                con.actualizargrid(Squeery, dgv_folio_habitacion);
                con.actualizargrid(Squeery1, dgv_folio_salon);
                con.actualizargrid(Squeery2, dgv_bien_folio);
                con.actualizargrid(Squeery3, dgv_folio_paquete);
                con.actualizargrid(Squeery4, dgv_lista_folio);
            }
            catch
            {
                MessageBox.Show("NO EXISTE NINGUN CLIENTE EN LA BASE DE DATOS\nLos datos no cargaron de forma correcta", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            
        }
        //=======================================================================================================================
        //--------------------------------------BOTON GUARDAR--------------------------------------------------------------
        //=======================================================================================================================
        //programador:walter Recinos Rosales
        //fecha inicio: 19-10-2016
        //fecha finalizacion: 26-10-2016

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if(entrar == true)
            {
                insertartodo();
                //MessageBox.Show("insert");
            }
            if(entrar == false)
            {
                actualizartodo();
                //MessageBox.Show("update");
                con.actualizar_total(textBox4.Text);
                con.actualizargrid(Squeery4, dgv_lista_folio);
            }
            
        }

        private void dgv_bien_folio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //=======================================================================================================================
        //--------------------------------------BOTON MODIFICAR-EXTRAER A COMBOBOX----------------------------------------------
        //=======================================================================================================================
        //programador:walter Recinos Rosales
        //fecha inicio: 19-10-2016
        //fecha finalizacion: 26-10-2016

        private void btn_modificar(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage1)
            {
                MessageBox.Show("folio no puede extraer los datos");
            }
            if (tabControl1.SelectedTab == tabPage2)
            {
                try
                {
                    string no1 = this.dgv_folio_habitacion.CurrentRow.Cells[2].Value.ToString();
                    cbo_habitacion.Text = no1;
                    string no2 = this.dgv_folio_habitacion.CurrentRow.Cells[3].Value.ToString();
                    cbo_folio_hab.Text = no2;
                    entrar = false;
                    textBox4.Text = no2;
                }
                catch
                {
                    MessageBox.Show("No hay ningun campo seleccionado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }           
            }
            if (tabControl1.SelectedTab == tabPage3)
            {
                try
                {
                    string no3 = this.dgv_folio_salon.CurrentRow.Cells[2].Value.ToString();
                    cbo_folio_salon.Text = no3;
                    string no4 = this.dgv_folio_salon.CurrentRow.Cells[3].Value.ToString();
                    cbo_salon.Text = no4;
                    entrar = false;
                    textBox4.Text = no3;
                }
                catch
                {
                    MessageBox.Show("No hay ningun campo seleccionado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }               
            }
            if (tabControl1.SelectedTab == tabPage4)
            {
                try
                {
                    string no5 = this.dgv_bien_folio.CurrentRow.Cells[2].Value.ToString();
                    string no6 = this.dgv_bien_folio.CurrentRow.Cells[3].Value.ToString();
                    cbo_folio_articulo.Text = no5;
                    cbo_articulo.Text = no6;
                    entrar = false;
                    textBox4.Text = no5;
                }
                catch
                {
                    MessageBox.Show("No hay ningun campo seleccionado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            if (tabControl1.SelectedTab == tabPage5)
            {
                try
                {
                    string no7 = this.dgv_folio_paquete.CurrentRow.Cells[2].Value.ToString();
                    cbo_folio_paquete.Text = no7;
                    string no8 = this.dgv_folio_paquete.CurrentRow.Cells[3].Value.ToString();
                    cbo_paquete.Text = no8;
                    entrar = false;
                    textBox4.Text = no7;
                }
                catch
                {
                    MessageBox.Show("No hay ningun campo seleccionado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }                     
            }
            
        }

        //=======================================================================================================================
        //--------------------------------------BOTON MODIFICAR--------------------------------------------------------------
        //=======================================================================================================================
        //programador:walter Recinos Rosales
        //fecha inicio: 19-10-2016
        //fecha finalizacion: 26-10-2016

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            
            if (tabControl1.SelectedTab == tabPage1)
            {
                MessageBox.Show("Folio no puede eliminar");
            }
            if (tabControl1.SelectedTab == tabPage2)
            {
                try
                {
                    string folio_actuar = this.dgv_folio_habitacion.CurrentRow.Cells[3].Value.ToString();
                    Boolean decicion = validar_folio(folio_actuar);
                    if (decicion == true)
                    {
                        if (MessageBox.Show("¿Desea eliminar el registo?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            resta_costo_folio_habitacion();
                            Codigo = this.dgv_folio_habitacion.CurrentRow.Cells[0].Value.ToString();
                            con.Conectar();
                            String Squerys = "delete from  folio_habitacion where id_folio_habitacion_pk = '" + Codigo + "';";
                            con.EjecutarQuery(Squerys);
                            con.actualizargrid(Squeery, dgv_folio_habitacion);
                            con.actualizargrid(Squeery4, dgv_lista_folio);
                            //nombre_columna();
                            con.Desconectar();
                            con.actualizargrid(Squeery4, dgv_lista_folio);
                            detalle_folio_borrar_habitacion(Codigo);
                            bita.Eliminar("Eliminar folio_Reservacion", "folio_habitacion");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Este Folio esta Pagado o inhabilitado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch
                {
                    MessageBox.Show("No hay ningun datos seleccionado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            if (tabControl1.SelectedTab == tabPage3)
                {
                try
                {
                    string folio_actuar = this.dgv_folio_salon.CurrentRow.Cells[2].Value.ToString();
                    Boolean decicion = validar_folio(folio_actuar);
                    if (decicion == true)
                    {
                        if (MessageBox.Show("¿Desea eliminar el registo?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            resta_costo_folio_Salon();
                            Codigo = this.dgv_folio_salon.CurrentRow.Cells[0].Value.ToString();
                            con.Conectar();
                            String Squerys = "delete from  folio_salon where id_folio_salon_pk = '" + Codigo + "';";
                            con.EjecutarQuery(Squerys);
                            con.actualizargrid(Squeery1, dgv_folio_salon);
                            //nombre_columna();
                            con.Desconectar();
                            con.actualizargrid(Squeery4, dgv_lista_folio);
                            detalle_folio_borrar_salon(Codigo);
                            bita.Eliminar("Eliminar folio_Evento", "folio_salon");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Este Folio esta Pagado o inhabilitado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch
                {
                    MessageBox.Show("No hay ningun datos seleccionado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            if (tabControl1.SelectedTab == tabPage4)
            {
                try
                {
                    string folio_actuar = this.dgv_bien_folio.CurrentRow.Cells[2].Value.ToString();
                    Boolean decicion = validar_folio(folio_actuar);
                    if (decicion == true)
                    {
                        if (MessageBox.Show("¿Desea eliminar el registo?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            resta_costo_folio_articulo();
                            Codigo = this.dgv_bien_folio.CurrentRow.Cells[0].Value.ToString();
                            con.Conectar();
                            String Squerys = "delete from  folio_bien where id_folio_bien_pk = '" + Codigo + "';";
                            con.EjecutarQuery(Squerys);
                            con.actualizargrid(Squeery2, dgv_bien_folio);
                            //nombre_columna();
                            con.Desconectar();
                            con.actualizargrid(Squeery4, dgv_lista_folio);
                            detalle_folio_borrar_bien(Codigo);
                            bita.Eliminar("Eliminar folio_Articulo", "folio_bien");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Este Folio esta Pagado o inhabilitado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch
                {
                    MessageBox.Show("No hay ningun datos seleccionado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            if (tabControl1.SelectedTab == tabPage5)
            {
                try
                {
                    string folio_actuar = this.dgv_folio_paquete.CurrentRow.Cells[2].Value.ToString();
                    Boolean decicion = validar_folio(folio_actuar);
                    if (decicion == true)
                    {
                        if (MessageBox.Show("¿Desea eliminar el registo?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            resta_costo_folio_paquete();
                            Codigo = this.dgv_folio_paquete.CurrentRow.Cells[0].Value.ToString();
                            con.Conectar();
                            String Squerys = "delete from  folio_promocion where id_folio_promocion_pk = '" + Codigo + "';";
                            con.EjecutarQuery(Squerys);
                            con.actualizargrid(Squeery3, dgv_folio_paquete);
                            //nombre_columna();
                            con.Desconectar();
                            con.actualizargrid(Squeery4, dgv_lista_folio);
                            detalle_folio_borrar_promo(Codigo);
                            bita.Eliminar("Eliminar folio_Promocion", "folio_promocion");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Este Folio esta Pagado o inhabilitado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch
                {
                    MessageBox.Show("No hay ningun datos seleccionado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
           
        }

        private void dgv_folio_habitacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //=======================================================================================================================
        //--------------------------------------BOTON BUSCAR--------------------------------------------------------------
        //=======================================================================================================================
        //programador:walter Recinos Rosales
        //fecha inicio: 19-10-2016
        //fecha finalizacion: 26-10-2016

        private void btn_buscar_Click(object sender, EventArgs e)
        {
           buscartodo();
        }

        //=======================================================================================================================
        //--------------------------------------FUNCION DE BUSCAR--------------------------------------------------------------
        //=======================================================================================================================
        //programador:walter Recinos Rosales
        //fecha inicio: 19-10-2016
        //fecha finalizacion: 26-10-2016

        public void buscartodo()
        {
            if (tabControl1.SelectedTab == tabPage1)
            {
                operaciones rs = new operaciones();
                rs.ejecutar(this.dgv_lista_folio, "folio");
            }
            if (tabControl1.SelectedTab == tabPage2)
            {
                con.Conectar();
                String Squerys = ("SELECT a.`id_folio_habitacion_pk`,a.`costo`,b.id_reserhabit_pk,c.`id_cuenta_pagar_pk` FROM folio_habitacion a, reservacion_habitacion b, folio c WHERE a.id_reserhabit_pk =b.id_reserhabit_pk AND a.id_cuenta_pagar_pk = c.id_cuenta_pagar_pk AND a.id_cuenta_pagar_pk like'%" + txt_buscar_folio_habitacion.Text + "%';");
                con.buscarquery(Squerys);
                con.actualizargrid(Squerys, dgv_folio_habitacion);
                con.Desconectar();
            }
            if (tabControl1.SelectedTab == tabPage3)
            {
                con.Conectar();
                String Squerys = ("SELECT a.`id_folio_salon_pk`,a.`costo`,b.`id_cuenta_pagar_pk`,c.nombre FROM folio_salon a,folio b,evento c WHERE a.id_cuenta_pagar_pk=b.id_cuenta_pagar_pk AND a.id_evento_pk=c.id_evento_pk AND a.id_cuenta_pagar_pk like'%" + txt_buscar_salon.Text + "%';");
                con.buscarquery(Squerys);
                con.actualizargrid(Squerys, dgv_folio_salon);
                con.Desconectar();
            }
            if (tabControl1.SelectedTab == tabPage4)
            {
                con.Conectar();
                String Squerys = ("SELECT a.`id_folio_bien_pk`,a.`costo`,b.`id_cuenta_pagar_pk`,c.descripcion FROM folio_bien a,folio b,bien c WHERE a.id_cuenta_pagar_pk=b.id_cuenta_pagar_pk AND a.id_bien_pk=c.id_bien_pk AND a.id_cuenta_pagar_pk like'%" + txt_buscar_articulo.Text + "%';");
                con.buscarquery(Squerys);
                con.actualizargrid(Squerys, dgv_bien_folio);
                con.Desconectar();
            }
            if (tabControl1.SelectedTab == tabPage5)
            {
                con.Conectar();
                String Squerys = ("SELECT a.`id_folio_promocion_pk`,a.`costo`,b.`id_cuenta_pagar_pk`,c.nombre FROM folio_promocion a,folio b,promocion c WHERE a.id_cuenta_pagar_pk=b.id_cuenta_pagar_pk AND a.id_promocion_pk=c.id_promocion_pk AND a.id_cuenta_pagar_pk like'%" + txt_buscar_promo.Text + "%';");
                con.buscarquery(Squerys);
                con.actualizargrid(Squerys, dgv_folio_paquete);
                con.Desconectar();
            }
            
        }

        //=======================================================================================================================
        //--------------------------------------BOTON HABILITAR--------------------------------------------------------------
        //=======================================================================================================================
        //programador:walter Recinos Rosales
        //fecha inicio: 19-10-2016
        //fecha finalizacion: 26-10-2016

        public void botonesprinspaleshabilitar()
        {
            btn_eliminar.Enabled = true;
            btn_editar.Enabled = true;
            btn_guardar.Enabled = true;
            btn_buscar.Enabled = true;
            btn_actualizar.Enabled = true;
        }

        //=======================================================================================================================
        //--------------------------------------BOTON DESHABILITAR--------------------------------------------------------------
        //=======================================================================================================================
        //programador:walter Recinos Rosales
        //fecha inicio: 19-10-2016
        //fecha finalizacion: 26-10-2016

        public void deshabilitartodo()
        {
            btn_eliminar.Enabled = false;
            btn_editar.Enabled = false;
            btn_guardar.Enabled = false;
            btn_buscar.Enabled = false;
            btn_actualizar.Enabled = false;
            cbo_cliente_folio.Enabled = false;
            txt_buscar_folio.Enabled = false;
            cbo_folio_hab.Enabled = false;
            cbo_habitacion.Enabled = false;
            cbo_folio_salon.Enabled = false;
            cbo_salon.Enabled = false;
            cbo_folio_articulo.Enabled = false;
            cbo_articulo.Enabled = false;
            cbo_folio_paquete.Enabled = false;
            cbo_paquete.Enabled = false;
        }

        //=======================================================================================================================
        //--------------------------------------FUNCION HABILITAR CAMPOS--------------------------------------------------------------
        //=======================================================================================================================
        //programador:walter Recinos Rosales
        //fecha inicio: 19-10-2016
        //fecha finalizacion: 26-10-2016

        public void habilitartodo()
        {
            if (tabControl1.SelectedTab == tabPage1)
            {
                cbo_cliente_folio.Enabled = true;
                txt_buscar_folio.Enabled = true;
                botonesprinspaleshabilitar();
                //MessageBox.Show("Folio");
            }
            if (tabControl1.SelectedTab == tabPage2)
            {
                cbo_folio_hab.Enabled = true;
                cbo_habitacion.Enabled = true;
                botonesprinspaleshabilitar();
                //MessageBox.Show("Habitacion");
            }
            if (tabControl1.SelectedTab == tabPage3)
            {
                cbo_folio_salon.Enabled = true;
                cbo_salon.Enabled = true;
                botonesprinspaleshabilitar();
                //MessageBox.Show("Salon");
            }
            if (tabControl1.SelectedTab == tabPage4)
            {
                cbo_folio_articulo.Enabled = true;
                cbo_articulo.Enabled = true;
                botonesprinspaleshabilitar();
                //MessageBox.Show("Articulo");
            }
            if (tabControl1.SelectedTab == tabPage5)
            {
                cbo_folio_paquete.Enabled = true;
                cbo_paquete.Enabled = true;
                botonesprinspaleshabilitar();
                //MessageBox.Show("paquete");
            }
        }




        private void cbo_paquete_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        //=======================================================================================================================
        //--------------------------------------BOTON DESHABILITAR--------------------------------------------------------------
        //=======================================================================================================================
        //programador:walter Recinos Rosales
        //fecha inicio: 19-10-2016
        //fecha finalizacion: 26-10-2016

        private void btn_bloquear_Click(object sender, EventArgs e)
        {
            deshabilitartodo();
          
        }

        private void dgv_folio_paquete_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //=======================================================================================================================
        //--------------------------------------BOTON HABILITAR--------------------------------------------------------------
        //=======================================================================================================================
        //programador:walter Recinos Rosales
        //fecha inicio: 19-10-2016
        //fecha finalizacion: 26-10-2016

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            habilitartodo();
            
        }

        public void buscar()
        {

        }

        //=======================================================================================================================
        //--------------------------------------FUNCIONES PARA VER COSTOS--------------------------------------------------------------
        //=======================================================================================================================
        //programador:walter Recinos Rosales
        //fecha inicio: 26-10-2016
        //fecha finalizacion: 02-11-2016

        private void btn_preciohabitacion_Click(object sender, EventArgs e)
        {
            try
            {
                string habitacion = cbo_habitacion.SelectedValue.ToString();

                con.Conectar();
                DataTable dt = new DataTable();
                String sQuery = "SELECT id_tipo_pk FROM habitacion WHERE id_habitacion_pk = '" + habitacion + "'";
                OdbcCommand comando = new OdbcCommand(sQuery, con.rutaconectada());
                OdbcDataAdapter adaptador = new OdbcDataAdapter(comando);
                adaptador.Fill(dt);
                DataRow fila = dt.Rows[0];
                string sid = Convert.ToString(fila[0]);
                //MessageBox.Show(sid);
                con.Desconectar();

                con.Conectar();
                DataTable dt1 = new DataTable();
                String sQuery1 = "SELECT costo_tipo FROM tipo_habitacion WHERE id_tipo_pk = '" + sid + "'";
                OdbcCommand comando1 = new OdbcCommand(sQuery1, con.rutaconectada());
                OdbcDataAdapter adaptador1 = new OdbcDataAdapter(comando1);
                adaptador1.Fill(dt1);
                DataRow fila1 = dt1.Rows[0];
                string sid1 = Convert.ToString(fila1[0]);
                MessageBox.Show("El Precio de la Habitacion es: Q." + sid1);
                con.Desconectar();
            }
            catch
            {

            }
        }

        private void btn_precioSalon_Click(object sender, EventArgs e)
        {
            try
            {
                string salon = cbo_salon.SelectedValue.ToString();

                con.Conectar();
                DataTable dt = new DataTable();
                String sQuery = "SELECT costo FROM evento WHERE id_evento_pk = '" + salon + "'";
                OdbcCommand comando = new OdbcCommand(sQuery, con.rutaconectada());
                OdbcDataAdapter adaptador = new OdbcDataAdapter(comando);
                adaptador.Fill(dt);
                DataRow fila = dt.Rows[0];
                string sid = Convert.ToString(fila[0]);
                MessageBox.Show("El Precio de la Salon es: Q." + sid);
                con.Desconectar();
            }
            catch
            {

            }
        }

        private void btn_precioarticulo_Click(object sender, EventArgs e)
        {
            try
            {
                string bien = cbo_articulo.SelectedValue.ToString();

                con.Conectar();
                DataTable dt = new DataTable();
                String sQuery = "SELECT costo FROM bien WHERE id_bien_pk = '" + bien + "'";
                OdbcCommand comando = new OdbcCommand(sQuery, con.rutaconectada());
                OdbcDataAdapter adaptador = new OdbcDataAdapter(comando);
                adaptador.Fill(dt);
                DataRow fila = dt.Rows[0];
                string sid = Convert.ToString(fila[0]);
                MessageBox.Show("El Precio de Articulo es: Q." + sid);
                con.Desconectar();
            }
            catch
            {

            }         
        }

        private void btn_preciopaquete_Click(object sender, EventArgs e)
        {
            try
            {
                string paquete = cbo_paquete.SelectedValue.ToString();

                con.Conectar();
                DataTable dt = new DataTable();
                String sQuery = "SELECT costo FROM promocion WHERE id_promocion_pk = '" + paquete + "'";
                OdbcCommand comando = new OdbcCommand(sQuery, con.rutaconectada());
                OdbcDataAdapter adaptador = new OdbcDataAdapter(comando);
                adaptador.Fill(dt);
                DataRow fila = dt.Rows[0];
                string sid = Convert.ToString(fila[0]);
                MessageBox.Show("El Precio de Paquete es: Q." + sid);
                con.Desconectar();
            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.guardar_costo_folio(cbo_folio_hab.Text);
            con.actualizargrid(Squeery4, dgv_lista_folio);
        }

        //=======================================================================================================================
        //--------------------------------RESTAR A FOLIO POR MEDIO DE DATAGRID--------------------------------------------------
        //=======================================================================================================================
        //programador:walter Recinos Rosales
        //fecha inicio: 26-10-2016
        //fecha finalizacion: 02-11-2016

        public void resta_costo_folio_paquete()
        {
            string folio_actuar = this.dgv_folio_paquete.CurrentRow.Cells[2].Value.ToString();
            string costo_paquete = this.dgv_folio_paquete.CurrentRow.Cells[1].Value.ToString();

            con.Conectar();
            DataTable dt = new DataTable();
            String sQuery = "SELECT costo FROM folio WHERE id_cuenta_pagar_pk = '" + folio_actuar + "'";
            OdbcCommand comando = new OdbcCommand(sQuery, con.rutaconectada());
            OdbcDataAdapter adaptador = new OdbcDataAdapter(comando);
            adaptador.Fill(dt);
            DataRow fila = dt.Rows[0];
            string sid = Convert.ToString(fila[0]);
            //MessageBox.Show(sid + "\n" +  costo_paquete);
            double resta1 = Convert.ToDouble(sid);
            double resta2 = Convert.ToDouble(costo_paquete);
            double resultado = resta1 - resta2;
            con.Desconectar();
            con.Conectar();
            String Squery = "update folio  set costo ='" + resultado + "' where id_cuenta_pagar_pk ='" + folio_actuar + "'";
            con.EjecutarQuery1(Squery);
            con.actualizargrid(Squeery, dgv_folio_habitacion);
            //nombre_columna();
            con.Desconectar();
            //con.actualizargrid(Squeery4, dgv_lista_folio);
        }
        
        public void resta_costo_folio_articulo()
        {
            string folio_actuar = this.dgv_bien_folio.CurrentRow.Cells[2].Value.ToString();
            string costo_paquete = this.dgv_bien_folio.CurrentRow.Cells[1].Value.ToString();

            con.Conectar();
            DataTable dt = new DataTable();
            String sQuery = "SELECT costo FROM folio WHERE id_cuenta_pagar_pk = '" + folio_actuar + "'";
            OdbcCommand comando = new OdbcCommand(sQuery, con.rutaconectada());
            OdbcDataAdapter adaptador = new OdbcDataAdapter(comando);
            adaptador.Fill(dt);
            DataRow fila = dt.Rows[0];
            string sid = Convert.ToString(fila[0]);
            //MessageBox.Show(sid + "\n" + costo_paquete);
            double resta1 = Convert.ToDouble(sid);
            double resta2 = Convert.ToDouble(costo_paquete);
            double resultado = resta1 - resta2;
            con.Desconectar();
            con.Conectar();
            String Squery = "update folio  set costo ='" + resultado + "' where id_cuenta_pagar_pk ='" + folio_actuar + "'";
            con.EjecutarQuery1(Squery);
            con.actualizargrid(Squeery, dgv_folio_habitacion);
            //nombre_columna();
            con.Desconectar();
            //con.actualizargrid(Squeery4, dgv_lista_folio);
        }

        public void resta_costo_folio_Salon()
        {
            string folio_actuar = this.dgv_folio_salon.CurrentRow.Cells[2].Value.ToString();
            string costo_paquete = this.dgv_folio_salon.CurrentRow.Cells[1].Value.ToString();

            con.Conectar();
            DataTable dt = new DataTable();
            String sQuery = "SELECT costo FROM folio WHERE id_cuenta_pagar_pk = '" + folio_actuar + "'";
            OdbcCommand comando = new OdbcCommand(sQuery, con.rutaconectada());
            OdbcDataAdapter adaptador = new OdbcDataAdapter(comando);
            adaptador.Fill(dt);
            DataRow fila = dt.Rows[0];
            string sid = Convert.ToString(fila[0]);
            //MessageBox.Show(sid + "\n" + costo_paquete);
            double resta1 = Convert.ToDouble(sid);
            double resta2 = Convert.ToDouble(costo_paquete);
            double resultado = resta1 - resta2;
            con.Desconectar();
            con.Conectar();
            String Squery = "update folio  set costo ='" + resultado + "' where id_cuenta_pagar_pk ='" + folio_actuar + "'";
            con.EjecutarQuery1(Squery);
            con.actualizargrid(Squeery, dgv_folio_habitacion);
            //nombre_columna();
            con.Desconectar();
            //con.actualizargrid(Squeery4, dgv_lista_folio);
        }

        public void resta_costo_folio_habitacion()
        {
            string folio_actuar = this.dgv_folio_habitacion.CurrentRow.Cells[3].Value.ToString();
            string costo_paquete = this.dgv_folio_habitacion.CurrentRow.Cells[1].Value.ToString();

            con.Conectar();
            DataTable dt = new DataTable();
            String sQuery = "SELECT costo FROM folio WHERE id_cuenta_pagar_pk = '" + folio_actuar + "'";
            OdbcCommand comando = new OdbcCommand(sQuery, con.rutaconectada());
            OdbcDataAdapter adaptador = new OdbcDataAdapter(comando);
            adaptador.Fill(dt);
            DataRow fila = dt.Rows[0];
            string sid = Convert.ToString(fila[0]);
            //MessageBox.Show(sid + "\n" + costo_paquete);
            double resta1 = Convert.ToDouble(sid);
            double resta2 = Convert.ToDouble(costo_paquete);
            double resultado = resta1 - resta2;
            con.Desconectar();
            con.Conectar();
            String Squery = "update folio  set costo ='" + resultado + "' where id_cuenta_pagar_pk ='" + folio_actuar + "'";
            con.EjecutarQuery1(Squery);
            //con.actualizargrid(Squeery, dgv_folio_habitacion);
            //nombre_columna();
            con.Desconectar();
            //con.actualizargrid(Squeery4, dgv_lista_folio);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        //=======================================================================================================================
        //----------------------------------COMPARAR FOLIO DEL CLIENTE CON SU LIMITE DE CREDITO--------------------------------
        //=======================================================================================================================
        //programador:walter Recinos Rosales
        //fecha inicio: 26-10-2016
        //fecha finalizacion: 02-11-2016

        public Boolean Comparar_folio_con_credito(string numfolio)
        {
            try
            {
                con.Conectar();
                DataTable dt = new DataTable();
                String sQuery = "SELECT costo, id_cliente_pk FROM folio WHERE id_cuenta_pagar_pk = '" + numfolio + "'";
                OdbcCommand comando = new OdbcCommand(sQuery, con.rutaconectada());
                OdbcDataAdapter adaptador = new OdbcDataAdapter(comando);
                adaptador.Fill(dt);
                DataRow fila = dt.Rows[0];
                string sid = Convert.ToString(fila[0]);
                string scliente = Convert.ToString(fila[1]);
                //MessageBox.Show("total Gastado: Q." + sid + "cliente:" + scliente);
                con.Desconectar();

                con.Conectar();
                DataTable dt1 = new DataTable();
                String sQuery1 = "SELECT id_tipocredito_pk FROM cliente WHERE id_cliente_pk = '" + scliente + "'";
                OdbcCommand comando1 = new OdbcCommand(sQuery1, con.rutaconectada());
                OdbcDataAdapter adaptador1 = new OdbcDataAdapter(comando1);
                adaptador1.Fill(dt1);
                DataRow fila1 = dt1.Rows[0];
                string sid1 = Convert.ToString(fila1[0]);
                //MessageBox.Show("tipo credito;" + sid1);
                con.Desconectar();

                con.Conectar();
                DataTable dt2 = new DataTable();
                String sQuery2 = "SELECT valor FROM tipo_credito WHERE id_tipocredito_pk = '" + sid1 + "'";
                OdbcCommand comando2 = new OdbcCommand(sQuery2, con.rutaconectada());
                OdbcDataAdapter adaptador2 = new OdbcDataAdapter(comando2);
                adaptador2.Fill(dt2);
                DataRow fila2 = dt2.Rows[0];
                string sid2 = Convert.ToString(fila2[0]);
                //MessageBox.Show("total credito credito:" + sid2);
                con.Desconectar();

                double cantidad_folio = Convert.ToDouble(sid);
                double cantidad_limite = Convert.ToDouble(sid2);
                if (cantidad_limite >= cantidad_folio)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        //=======================================================================================================================
        //----------------------------SE VALIDA EL ESTADO DEL FOLIO PARA QUE SOLO ESTE PENDIENTE__------------------------------
        //=======================================================================================================================
        //programador:walter Recinos Rosales
        //fecha inicio: 26-10-2016
        //fecha finalizacion: 02-11-2016

        public Boolean validar_folio(string folio_actual)
        {
            
            con.Conectar();
            DataTable dt1 = new DataTable();
            String sQuery1 = "SELECT estado FROM folio WHERE id_cuenta_pagar_pk = '" + folio_actual + "'";
            OdbcCommand comando1 = new OdbcCommand(sQuery1, con.rutaconectada());
            OdbcDataAdapter adaptador1 = new OdbcDataAdapter(comando1);
            adaptador1.Fill(dt1);
            DataRow fila1 = dt1.Rows[0];
            string sid1 = Convert.ToString(fila1[0]);
            //MessageBox.Show("Estado: " + sid1);
            con.Desconectar();
            if ( sid1 == "Pendiente")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //=======================================================================================================================
        //--------------------------------------BOTON IR A DETALLE FOLIO--------------------------------------------------------------
        //=======================================================================================================================
        //programador:walter Recinos Rosales
        //fecha inicio: 26-10-2016
        //fecha finalizacion: 02-11-2016

        private void button1_Click_1(object sender, EventArgs e)
        {
            //string folio_actuar = this.dgv_folio_habitacion.CurrentRow.Cells[3].Value.ToString();
            //Boolean decicion = validar_folio(folio_actuar);
            //if (decicion == true)
            //{
            //    MessageBox.Show("si se puede");
            //}
            //else
            //{
            //    MessageBox.Show("no se puede");
            //}
            Frm_Folio_Unificado r = new Frm_Folio_Unificado();
            r.ShowDialog();

        }

        //=======================================================================================================================
        //--------------------------------------DETALLE FOLIO  -- INSERTAR-------------------------------------------------------
        //=======================================================================================================================
        //programador:walter Recinos Rosales
        //fecha inicio: 26-10-2016
        //fecha finalizacion: 02-11-2016

        public void detalle_folio_insertar_promo(string costo,string nombre,string id_folio, DateTime tiempo)
        {
            string folio_actuar = this.cbo_folio_paquete.SelectedValue.ToString();
            string otro = this.cbo_paquete.SelectedValue.ToString();
           

            con.Conectar();
            DataTable dt1 = new DataTable();
            String sQuery1 = "SELECT id_folio_promocion_pk FROM folio_promocion WHERE id_cuenta_pagar_pk = '" + folio_actuar + "' AND id_promocion_pk = '" + otro + "' AND fecha = '" + tiempo + "'";
            OdbcCommand comando1 = new OdbcCommand(sQuery1, con.rutaconectada());
            OdbcDataAdapter adaptador1 = new OdbcDataAdapter(comando1);
            adaptador1.Fill(dt1);
            DataRow fila1 = dt1.Rows[0];
            string id_promo = Convert.ToString(fila1[0]);
            //MessageBox.Show("EL id de la promo es: " + id_promo);
            con.Desconectar();

            con.Conectar();
            String Squery = "insert into  detalle_folio (costo,nombre,id_folio_promocion_pk,id_cuenta_pagar_pk,fecha) values('" + costo + "','" + nombre + "','" + id_promo + "','" + id_folio + "','" + tiempo + "');";
            con.EjecutarQuery(Squery);
            //con.actualizargrid(Squeery3, dgv_folio_paquete);
            //nombre_columna();
            con.Desconectar();
            bita.Insertar("Insertar", "detalle_folio");
        }

        public void detalle_folio_insertar_habitacion(string costo, string nombre, string id_folio, DateTime tiempo)
        {
            string folio_actuar = this.cbo_folio_hab.SelectedValue.ToString();
            string otro = this.cbo_habitacion.SelectedValue.ToString();
            

            con.Conectar();
            DataTable dt1 = new DataTable();
            String sQuery1 = "SELECT id_folio_habitacion_pk FROM folio_habitacion WHERE id_cuenta_pagar_pk = '" + folio_actuar + "' AND fecha = '"+ tiempo +"'";
            OdbcCommand comando1 = new OdbcCommand(sQuery1, con.rutaconectada());
            OdbcDataAdapter adaptador1 = new OdbcDataAdapter(comando1);
            adaptador1.Fill(dt1);
            DataRow fila1 = dt1.Rows[0];
            string id_hab = Convert.ToString(fila1[0]);
            //MessageBox.Show("EL id de la habitacion es: " + id_hab);
            con.Desconectar();


            con.Conectar();
            String Squery = "insert into  detalle_folio (costo,nombre,id_folio_habitacion_pk,id_cuenta_pagar_pk,fecha) values('" + costo + "','" + nombre + "','" + id_hab + "','" + id_folio + "','"+ tiempo +"');";
            con.EjecutarQuery(Squery);
            //con.actualizargrid(Squeery3, dgv_folio_paquete);
            //nombre_columna();
            con.Desconectar();
            bita.Insertar("Insertar", "detalle_folio");
        }

        public void detalle_folio_insertar_salon(string costo, string nombre, string id_folio, DateTime tiempo)
        {
            string folio_actuar = this.cbo_folio_salon.SelectedValue.ToString();
            string otro = this.cbo_salon.SelectedValue.ToString();


            con.Conectar();
            DataTable dt1 = new DataTable();
            String sQuery1 = "SELECT id_folio_salon_pk FROM folio_salon WHERE id_cuenta_pagar_pk = '" + folio_actuar + "' AND id_evento_pk = '" + otro + "' AND fecha = '" + tiempo + "'";
            OdbcCommand comando1 = new OdbcCommand(sQuery1, con.rutaconectada());
            OdbcDataAdapter adaptador1 = new OdbcDataAdapter(comando1);
            adaptador1.Fill(dt1);
            DataRow fila1 = dt1.Rows[0];
            string id_salon = Convert.ToString(fila1[0]);
            //MessageBox.Show("EL id de la salon es: " + id_salon);
            con.Desconectar();

            con.Conectar();
            String Squery = "insert into  detalle_folio (costo,nombre,id_folio_salon_pk,id_cuenta_pagar_pk,fecha) values('" + costo + "','" + nombre + "','" + id_salon + "','" + id_folio + "','" + tiempo + "');";
            con.EjecutarQuery(Squery);
            //con.actualizargrid(Squeery3, dgv_folio_paquete);
            //nombre_columna();
            con.Desconectar();
            bita.Insertar("Insertar", "detalle_folio");
        }

        public void detalle_folio_insertar_bien(string costo, string nombre, string id_folio, DateTime tiempo)
        {
            string folio_actuar = this.cbo_folio_articulo.SelectedValue.ToString();
            string otro = this.cbo_articulo.SelectedValue.ToString();


            con.Conectar();
            DataTable dt1 = new DataTable();
            String sQuery1 = "SELECT id_folio_bien_pk FROM folio_bien WHERE id_cuenta_pagar_pk = '" + folio_actuar + "' AND id_bien_pk = '" + otro + "' AND fecha = '" + tiempo + "'";
            OdbcCommand comando1 = new OdbcCommand(sQuery1, con.rutaconectada());
            OdbcDataAdapter adaptador1 = new OdbcDataAdapter(comando1);
            adaptador1.Fill(dt1);
            DataRow fila1 = dt1.Rows[0];
            string id_bien = Convert.ToString(fila1[0]);
            //MessageBox.Show("EL id de la salon es: " + id_bien);
            con.Desconectar();

            con.Conectar();
            String Squery = "insert into  detalle_folio (costo,nombre,id_folio_bien_pk,id_cuenta_pagar_pk,fecha) values('" + costo + "','" + nombre + "','" + id_bien + "','" + id_folio + "','" + tiempo + "');";
            con.EjecutarQuery(Squery);
            //con.actualizargrid(Squeery3, dgv_folio_paquete);
            //nombre_columna();
            con.Desconectar();
            bita.Insertar("Insertar", "detalle_folio");
        }

        //=======================================================================================================================
        //--------------------------------------DETALLE FOLIO  -- ACTUALIZAR-------------------------------------------------------
        //=======================================================================================================================
        //programador:walter Recinos Rosales
        //fecha inicio: 26-10-2016
        //fecha finalizacion: 02-11-2016

        public void detale_folio_update_habitacion(string id_hab, string costo)
        {
            string folio_actuar = this.cbo_folio_hab.SelectedValue.ToString();
            string otro = this.cbo_habitacion.SelectedValue.ToString();
            string nombre = cbo_habitacion.Text;

            con.Conectar();
            String Squery = "update detalle_folio  set costo ='" + costo + "', nombre ='" + nombre + "',id_cuenta_pagar_pk ='" + folio_actuar + "' where id_folio_habitacion_pk ='" + id_hab + "'";
            con.EjecutarQuery(Squery);
            con.actualizargrid(Squeery2, dgv_bien_folio);
            //nombre_columna();
            con.Desconectar();
            bita.Modificar("Modificar", "detalle_folio");
        }

        public void detale_folio_update_salon(string id_sal, string costo)
        {
            string folio_actuar = this.cbo_folio_salon.SelectedValue.ToString();
            string otro = this.cbo_salon.SelectedValue.ToString();
            string nombre = cbo_salon.Text;

            con.Conectar();
            String Squery = "update detalle_folio  set costo ='" + costo + "', nombre ='" + nombre + "',id_cuenta_pagar_pk ='" + folio_actuar + "' where id_folio_salon_pk ='" + id_sal + "'";
            con.EjecutarQuery(Squery);
            con.actualizargrid(Squeery2, dgv_bien_folio);
            //nombre_columna();
            con.Desconectar();
            bita.Modificar("Modificar", "detalle_folio");
        }

        public void detale_folio_update_bien(string id_bien, string costo)
        {
            string folio_actuar = this.cbo_folio_articulo.SelectedValue.ToString();
            string otro = this.cbo_articulo.SelectedValue.ToString();
            string nombre = cbo_articulo.Text;

            con.Conectar();
            String Squery = "update detalle_folio  set costo ='" + costo + "', nombre ='" + nombre + "',id_cuenta_pagar_pk ='" + folio_actuar + "' where id_folio_bien_pk ='" + id_bien + "'";
            con.EjecutarQuery(Squery);
            con.actualizargrid(Squeery2, dgv_bien_folio);
            //nombre_columna();
            con.Desconectar();
            bita.Modificar("Modificar", "detalle_folio");
        }

        public void detale_folio_update_promo(string id_promo, string costo)
        {
            string folio_actuar = this.cbo_folio_paquete.SelectedValue.ToString();
            string otro = this.cbo_paquete.SelectedValue.ToString();
            string nombre = cbo_paquete.Text;

            con.Conectar();
            String Squery = "update detalle_folio  set costo ='" + costo + "', nombre ='" + nombre + "',id_cuenta_pagar_pk ='" + folio_actuar + "' where id_folio_promocion_pk ='" + id_promo + "'";
            con.EjecutarQuery(Squery);
            con.actualizargrid(Squeery2, dgv_bien_folio);
            //nombre_columna();
            con.Desconectar();
            bita.Modificar("Modificar", "detalle_folio");
        }

        //=======================================================================================================================
        //--------------------------------------DETALLE FOLIO  -- BORRAR-------------------------------------------------------
        //=======================================================================================================================
        //programador:walter Recinos Rosales
        //fecha inicio: 26-10-2016
        //fecha finalizacion: 02-11-2016

        public void detalle_folio_borrar_promo(string id_promo)
        {
            con.Conectar();
            String Squerys = "delete from  detalle_folio where id_folio_promocion_pk = '" + id_promo + "';";
            con.EjecutarQuery(Squerys);
            con.actualizargrid(Squeery3, dgv_folio_paquete);
            //nombre_columna();
            con.Desconectar();
            bita.Eliminar("Eliminar", "detalle_folio");
        }

        public void detalle_folio_borrar_habitacion(string id_hab)
        {
            con.Conectar();
            String Squerys = "delete from  detalle_folio where id_folio_habitacion_pk = '" + id_hab + "';";
            con.EjecutarQuery(Squerys);
            con.actualizargrid(Squeery3, dgv_folio_paquete);
            //nombre_columna();
            con.Desconectar();
            bita.Eliminar("Eliminar", "detalle_folio");
        }

        private void cbo_clientefiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            string clientefiltro = cbo_clientefiltro.SelectedValue.ToString();
            cb2(clientefiltro);//carga de combobox de reservacion
            cb1(clientefiltro);//carga de combobox de folio1
            cb3(clientefiltro);//carga de combobox de folio2
            cb4(clientefiltro);//carga de combobox de folio3
            cb5(clientefiltro);//carga de combobox de folio4
            cb6(clientefiltro);//carga de combobox de evento
        }

        public void detalle_folio_borrar_salon(string id_sal)
        {
            con.Conectar();
            String Squerys = "delete from  detalle_folio where id_folio_salon_pk = '" + id_sal + "';";
            con.EjecutarQuery(Squerys);
            con.actualizargrid(Squeery3, dgv_folio_paquete);
            //nombre_columna();
            con.Desconectar();
            bita.Eliminar("Eliminar", "detalle_folio");
        }

        public void detalle_folio_borrar_bien(string id_bien)
        {
            con.Conectar();
            String Squerys = "delete from  detalle_folio where id_folio_bien_pk = '" + id_bien + "';";
            con.EjecutarQuery(Squerys);
            con.actualizargrid(Squeery3, dgv_folio_paquete);
            //nombre_columna();
            con.Desconectar();
            bita.Eliminar("Eliminar", "detalle_folio");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
            con.actualizar_total(textBox4.Text);
        }

        //=======================================================================================================================
        //--------------------------------------VERIFICAR QUE NO SE REPITA-------------------------------------------------------
        //=======================================================================================================================
        //programador:walter Recinos Rosales
        //fecha inicio: 26-10-2016
        //fecha finalizacion: 02-11-2016

        public Boolean verificar_reservacion(string folio,string reservacion)
        {
            try
            {
                con.Conectar();
                DataTable dt1 = new DataTable();
                String sQuery1 = "SELECT id_folio_habitacion_pk FROM folio_habitacion WHERE id_cuenta_pagar_pk = '" + folio + "' AND id_reserhabit_pk = '" + reservacion + "';";
                OdbcCommand comando1 = new OdbcCommand(sQuery1, con.rutaconectada());
                OdbcDataAdapter adaptador1 = new OdbcDataAdapter(comando1);
                adaptador1.Fill(dt1);
                DataRow fila1 = dt1.Rows[0];
                string sid = Convert.ToString(fila1[0]);
                //MessageBox.Show(id_salon);
                con.Desconectar();
                return true;
            }
            catch
            {
                return false;
            }   
        }

        public Boolean verificar_evento(string folio, string reservacion)
        {
            try
            {
                con.Conectar();
                DataTable dt1 = new DataTable();
                String sQuery1 = "SELECT id_folio_salon_pk FROM folio_salon WHERE id_cuenta_pagar_pk = '" + folio + "' AND id_evento_pk = '" + reservacion + "';";
                OdbcCommand comando1 = new OdbcCommand(sQuery1, con.rutaconectada());
                OdbcDataAdapter adaptador1 = new OdbcDataAdapter(comando1);
                adaptador1.Fill(dt1);
                DataRow fila1 = dt1.Rows[0];
                string sid = Convert.ToString(fila1[0]);
                //MessageBox.Show(id_salon);
                con.Desconectar();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //=======================================================================================================================
        //--------------------------------------BOTONES DE NAVEGACION-------------------------------------------------------
        //=======================================================================================================================
        //programador:walter Recinos
        //fecha inicio: 29-10-2016
        //fecha finalizacion: 02-11-2016

        private void button2_Click_2(object sender, EventArgs e)
        {

            if (tabControl1.SelectedTab == tabPage1)
            {
                MessageBox.Show("Folio");
            }
            if (tabControl1.SelectedTab == tabPage2)
            {
                fn.Anterior(dgv_folio_habitacion);
                TextBox[] textbox = { txt_folio_reservacion, txt_codigo_reservacion };
                fn.llenartextbox(textbox, dgv_folio_habitacion);
                cbo_folio_hab.Text = txt_folio_reservacion.Text;
            }
            if (tabControl1.SelectedTab == tabPage3)
            {
                //MessageBox.Show("Salon");
                fn.Anterior(dgv_folio_salon);
                TextBox[] textbox = { txt_folio_evento_Nvisible, txt_evento_nvisible };
                fn.llenartextbox(textbox, dgv_folio_salon);
                cbo_folio_salon.Text = txt_folio_evento_Nvisible.Text;
            }
            if (tabControl1.SelectedTab == tabPage4)
            {
                fn.Anterior(dgv_bien_folio);
                TextBox[] textbox = { txt_folio_articuloNvisible, txt_articulo_Nvisible };
                fn.llenartextbox(textbox, dgv_bien_folio);
                cbo_folio_articulo.Text = txt_folio_articuloNvisible.Text;
                cbo_articulo.Text = txt_articulo_Nvisible.Text;
            }
            if (tabControl1.SelectedTab == tabPage5)
            {
                fn.Anterior(dgv_folio_paquete);
                TextBox[] textbox = { txt_folio_promocion_Nvisible, txt_promocion_Nvisible };
                fn.llenartextbox(textbox, dgv_folio_paquete);
                cbo_folio_articulo.Text = txt_folio_promocion_Nvisible.Text;
                cbo_articulo.Text = txt_promocion_Nvisible.Text;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage1)
            {
                MessageBox.Show("Folio");
            }
            if (tabControl1.SelectedTab == tabPage2)
            {
                fn.Siguiente(dgv_folio_habitacion);
                TextBox[] textbox = { txt_folio_reservacion, txt_codigo_reservacion };
                fn.llenartextbox(textbox, dgv_folio_habitacion);
                cbo_folio_hab.Text = txt_folio_reservacion.Text;
            }
            if (tabControl1.SelectedTab == tabPage3)
            {
                //MessageBox.Show("Salon");
                fn.Siguiente(dgv_folio_salon);
                TextBox[] textbox = { txt_folio_evento_Nvisible, txt_evento_nvisible };
                fn.llenartextbox(textbox, dgv_folio_salon);
                cbo_folio_salon.Text = txt_folio_evento_Nvisible.Text;
            }
            if (tabControl1.SelectedTab == tabPage4)
            {
                fn.Siguiente(dgv_bien_folio);
                TextBox[] textbox = { txt_folio_articuloNvisible, txt_articulo_Nvisible };
                fn.llenartextbox(textbox, dgv_bien_folio);
                cbo_folio_articulo.Text = txt_folio_articuloNvisible.Text;
                cbo_articulo.Text = txt_articulo_Nvisible.Text;
            }
            if (tabControl1.SelectedTab == tabPage5)
            {
                fn.Siguiente(dgv_folio_paquete);
                TextBox[] textbox = { txt_folio_promocion_Nvisible, txt_promocion_Nvisible };
                fn.llenartextbox(textbox, dgv_folio_paquete);
                cbo_folio_articulo.Text = txt_folio_promocion_Nvisible.Text;
                cbo_articulo.Text = txt_promocion_Nvisible.Text;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage1)
            {
                MessageBox.Show("Folio");
            }
            if (tabControl1.SelectedTab == tabPage2)
            {
                fn.Primero(dgv_folio_habitacion);
                TextBox[] textbox = { txt_folio_reservacion, txt_codigo_reservacion };
                fn.llenartextbox(textbox, dgv_folio_habitacion);
                cbo_folio_hab.Text = txt_folio_reservacion.Text;
            }
            if (tabControl1.SelectedTab == tabPage3)
            {
                //MessageBox.Show("Salon");
                fn.Primero(dgv_folio_salon);
                TextBox[] textbox = { txt_folio_evento_Nvisible, txt_evento_nvisible };
                fn.llenartextbox(textbox, dgv_folio_salon);
                cbo_folio_salon.Text = txt_folio_evento_Nvisible.Text;
            }
            if (tabControl1.SelectedTab == tabPage4)
            {
                fn.Primero(dgv_bien_folio);
                TextBox[] textbox = { txt_folio_articuloNvisible, txt_articulo_Nvisible };
                fn.llenartextbox(textbox, dgv_bien_folio);
                cbo_folio_articulo.Text = txt_folio_articuloNvisible.Text;
                cbo_articulo.Text = txt_articulo_Nvisible.Text;
            }
            if (tabControl1.SelectedTab == tabPage5)
            {
                fn.Primero(dgv_folio_paquete);
                TextBox[] textbox = { txt_folio_promocion_Nvisible, txt_promocion_Nvisible };
                fn.llenartextbox(textbox, dgv_folio_paquete);
                cbo_folio_articulo.Text = txt_folio_promocion_Nvisible.Text;
                cbo_articulo.Text = txt_promocion_Nvisible.Text;
            }
        }

        private void txt_buscar_folio_habitacion_TextChanged(object sender, EventArgs e)
        {
            con.Conectar();
            String Squerys = ("SELECT a.`id_folio_habitacion_pk`,a.`costo`,b.id_reserhabit_pk,c.`id_cuenta_pagar_pk` FROM folio_habitacion a, reservacion_habitacion b, folio c WHERE a.id_reserhabit_pk =b.id_reserhabit_pk AND a.id_cuenta_pagar_pk = c.id_cuenta_pagar_pk AND a.id_cuenta_pagar_pk like'%" + txt_buscar_folio_habitacion.Text + "%';");
            con.buscarquery(Squerys);
            con.actualizargrid(Squerys, dgv_folio_habitacion);
            con.Desconectar();
        }

        private void txt_buscar_articulo_TextChanged(object sender, EventArgs e)
        {
            con.Conectar();
            String Squerys = ("SELECT a.`id_folio_bien_pk`,a.`costo`,b.`id_cuenta_pagar_pk`,c.descripcion FROM folio_bien a,folio b,bien c WHERE a.id_cuenta_pagar_pk=b.id_cuenta_pagar_pk AND a.id_bien_pk=c.id_bien_pk AND a.id_cuenta_pagar_pk like'%" + txt_buscar_articulo.Text + "%';");
            con.buscarquery(Squerys);
            con.actualizargrid(Squerys, dgv_bien_folio);
            con.Desconectar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage1)
            {
                MessageBox.Show("Folio");
            }
            if (tabControl1.SelectedTab == tabPage2)
            {
                fn.Ultimo(dgv_folio_habitacion);
                TextBox[] textbox = { txt_folio_reservacion, txt_codigo_reservacion };
                fn.llenartextbox(textbox, dgv_folio_habitacion);
                cbo_folio_hab.Text = txt_folio_reservacion.Text;
            }
            if (tabControl1.SelectedTab == tabPage3)
            {
                //MessageBox.Show("Salon");
                fn.Ultimo(dgv_folio_salon);
                TextBox[] textbox = { txt_folio_evento_Nvisible, txt_evento_nvisible };
                fn.llenartextbox(textbox, dgv_folio_salon);
                cbo_folio_salon.Text = txt_folio_evento_Nvisible.Text;
            }
            if (tabControl1.SelectedTab == tabPage4)
            {
                //MessageBox.Show("Salon");
                fn.Ultimo(dgv_bien_folio);
                TextBox[] textbox = { txt_folio_articuloNvisible, txt_articulo_Nvisible };
                fn.llenartextbox(textbox, dgv_bien_folio);
                cbo_folio_articulo.Text = txt_folio_articuloNvisible.Text;
                cbo_articulo.Text = txt_articulo_Nvisible.Text;
            }
            if (tabControl1.SelectedTab == tabPage5)
            {
                fn.Ultimo(dgv_folio_paquete);
                TextBox[] textbox = { txt_folio_promocion_Nvisible, txt_promocion_Nvisible };
                fn.llenartextbox(textbox, dgv_folio_paquete);
                cbo_folio_articulo.Text = txt_folio_promocion_Nvisible.Text;
                cbo_articulo.Text = txt_promocion_Nvisible.Text;
            }
        }

        public int Dias_reservacion(string numreservacion)
        {
            try
            {
                con.Conectar();
                DataTable dt = new DataTable();
                String sQuery = "SELECT fecha_entreda, fecha_salida FROM reservacion_habitacion WHERE id_reserhabit_pk = '" + numreservacion + "'";
                OdbcCommand comando = new OdbcCommand(sQuery, con.rutaconectada());
                OdbcDataAdapter adaptador = new OdbcDataAdapter(comando);
                adaptador.Fill(dt);
                DataRow fila = dt.Rows[0];
                string sfechainicion = Convert.ToString(fila[0]);
                string sfehcafinal = Convert.ToString(fila[1]);
                //MessageBox.Show("total Gastado: Q." + sfechainicion + "cliente:" + sfehcafinal);
                con.Desconectar();

                DateTime fechainicio = Convert.ToDateTime(sfechainicion);
                DateTime fechafinal = Convert.ToDateTime(sfehcafinal);
                int cont = 0;

                while (fechainicio <= fechafinal)
                {
                    fechainicio = fechainicio.AddDays(1);
                    cont++;
                }
                return cont;
            }
            catch
            {
                MessageBox.Show("Ocurrio un error con las fechas de reservacion");
                return 0;
            }

        }

        public int Dias_evento(string numreservacion)
        {
            try
            {
                con.Conectar();
                DataTable dt = new DataTable();
                String sQuery = "SELECT fecha_entrada, fecha_salida FROM evento WHERE id_evento_pk = '" + numreservacion + "'";
                OdbcCommand comando = new OdbcCommand(sQuery, con.rutaconectada());
                OdbcDataAdapter adaptador = new OdbcDataAdapter(comando);
                adaptador.Fill(dt);
                DataRow fila = dt.Rows[0];
                string sfechainicion = Convert.ToString(fila[0]);
                string sfehcafinal = Convert.ToString(fila[1]);
                //MessageBox.Show("total Gastado: Q." + sfechainicion + "cliente:" + sfehcafinal);
                con.Desconectar();

                DateTime fechainicio = Convert.ToDateTime(sfechainicion);
                DateTime fechafinal = Convert.ToDateTime(sfehcafinal);
                int cont = 0;

                while (fechainicio <= fechafinal)
                {
                    fechainicio = fechainicio.AddDays(1);
                    cont++;
                }
                return cont;
            }
            catch
            {
                MessageBox.Show("Ocurrio un error con las fechas de evento");
                return 0;
            }

        }

    }

}
