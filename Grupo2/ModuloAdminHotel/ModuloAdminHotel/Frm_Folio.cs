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

namespace ModuloAdminHotel
{
    public partial class Frm_Folio : Form
    {
        metodos con = new metodos();
        public Frm_Folio()
        {
            InitializeComponent();
            con.actualizargrid(Squeery, dgv_folio_habitacion);
            con.actualizargrid(Squeery1, dgv_folio_salon);
            con.actualizargrid(Squeery2, dgv_bien_folio);
            con.actualizargrid(Squeery3, dgv_folio_paquete);
            con.actualizargrid(Squeery4, dgv_lista_folio);
        }

        string Squeery = "SELECT a.`id_folio_habitacion_pk`,a.`costo`,b.nombre,c.`id_cuenta_pagar_pk` FROM folio_habitacion a, habitacion b, folio c WHERE a.id_habitacion_pk =b.id_habitacion_pk AND a.id_cuenta_pagar_pk = c.id_cuenta_pagar_pk";
        string Squeery1 = "SELECT a.`id_folio_salon_pk`,a.`costo`,b.`id_cuenta_pagar_pk`,c.nombre FROM folio_salon a,folio b,salon c WHERE a.id_cuenta_pagar_pk=b.id_cuenta_pagar_pk AND a.id_salon_pk=c.id_salon_pk"; 
        string Squeery2 = "SELECT a.`id_folio_bien_pk`,a.`costo`,b.`id_cuenta_pagar_pk`,c.descripcion FROM folio_bien a,folio b,bien c WHERE a.id_cuenta_pagar_pk=b.id_cuenta_pagar_pk AND a.id_bien_pk=c.id_bien_pk";
        string Squeery3 = "SELECT a.`id_folio_promocion_pk`,a.`costo`,b.`id_cuenta_pagar_pk`,c.nombre FROM folio_promocion a,folio b,promocion c WHERE a.id_cuenta_pagar_pk=b.id_cuenta_pagar_pk AND a.id_promocion_pk=c.id_promocion_pk";
        string Squeery4 = "SELECT * FROM folio WHERE estado = 'Pendiente'";
        string Codigo;
        Boolean entrar = true;


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        private void Frm_Folio_Load(object sender, EventArgs e)
        {
            cb1();
            cb2();
            cb3();
            cb4();
            cb5();
            cb6();
            cb7();
            cb8();
            cb9();
        }


        private void cb1()
        {
            try
            {
                con.Conectar();
                //se inicia un DataSet
                DataSet ds = new DataSet();
                //se indica la consulta en sql
                String Query = "select id_cuenta_pagar_pk from folio;";
                MySqlDataAdapter dad = new MySqlDataAdapter(Query, con.rutaconectada());
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

        private void cb2()
        {
            try
            {
                con.Conectar();
                //se inicia un DataSet
                DataSet ds = new DataSet();
                //se indica la consulta en sql
                String Query = "select id_habitacion_pk,nombre from habitacion;";
                MySqlDataAdapter dad = new MySqlDataAdapter(Query, con.rutaconectada());
                //se indica con quu tabla se llena
                dad.Fill(ds, "habitacion");
                cbo_habitacion.DataSource = ds.Tables[0].DefaultView;
                //indicamos el valor de los miembros
                cbo_habitacion.ValueMember = ("id_habitacion_pk");
                //se indica el valor a desplegar en el combobox
                cbo_habitacion.DisplayMember = ("nombre");
                con.Desconectar();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Los datos no cargaron de forma correcta" + ex, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cb3()
        {
            try
            {
                con.Conectar();
                //se inicia un DataSet
                DataSet ds = new DataSet();
                //se indica la consulta en sql
                String Query = "select id_cuenta_pagar_pk from folio;";
                MySqlDataAdapter dad = new MySqlDataAdapter(Query, con.rutaconectada());
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
        private void cb4()
        {
            try
            {
                con.Conectar();
                //se inicia un DataSet
                DataSet ds = new DataSet();
                //se indica la consulta en sql
                String Query = "select id_cuenta_pagar_pk from folio;";
                MySqlDataAdapter dad = new MySqlDataAdapter(Query, con.rutaconectada());
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

        private void cb5()
        {
            try
            {
                con.Conectar();
                //se inicia un DataSet
                DataSet ds = new DataSet();
                //se indica la consulta en sql
                String Query = "select id_cuenta_pagar_pk from folio;";
                MySqlDataAdapter dad = new MySqlDataAdapter(Query, con.rutaconectada());
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
        private void cb6()
        {
            try
            {
                con.Conectar();
                //se inicia un DataSet
                DataSet ds = new DataSet();
                //se indica la consulta en sql
                String Query = "select id_salon_pk,nombre from salon;";
                MySqlDataAdapter dad = new MySqlDataAdapter(Query, con.rutaconectada());
                //se indica con quu tabla se llena
                dad.Fill(ds, "salon");
                cbo_salon.DataSource = ds.Tables[0].DefaultView;
                //indicamos el valor de los miembros
                cbo_salon.ValueMember = ("id_salon_pk");
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
                MySqlDataAdapter dad = new MySqlDataAdapter(Query, con.rutaconectada());
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
                MySqlDataAdapter dad = new MySqlDataAdapter(Query, con.rutaconectada());
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
                con.Conectar();
                //se inicia un DataSet
                DataSet ds = new DataSet();
                //se indica la consulta en sql
                String Query = "select id_cliente_pk,nombre from cliente;";
                MySqlDataAdapter dad = new MySqlDataAdapter(Query, con.rutaconectada());
                //se indica con quu tabla se llena
                dad.Fill(ds, "cliente");
                cbo_cliente_folio.DataSource = ds.Tables[0].DefaultView;
                //indicamos el valor de los miembros
                cbo_cliente_folio.ValueMember = ("id_cliente_pk");
                //se indica el valor a desplegar en el combobox
                cbo_cliente_folio.DisplayMember = ("nombre");
                con.Desconectar();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Los datos no cargaron de forma correcta" + ex, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }









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

        public void insertartodo()
        {
           if (tabControl1.SelectedTab == tabPage1)
            {
                string cliente = cbo_cliente_folio.SelectedValue.ToString();

                con.Conectar();
                String Squery = "insert into  folio (estado,fecha_ingreso,id_cliente_pk) values('Pendiente',Sysdate(),'" + cliente + "');";
                con.EjecutarQuery(Squery);
                con.actualizargrid(Squeery4, dgv_lista_folio);
                //nombre_columna();
                con.Desconectar();
                MessageBox.Show("Folio");
            }
            if (tabControl1.SelectedTab == tabPage2)
            {
                string folio = cbo_folio_hab.SelectedValue.ToString();
                string habitacion = cbo_habitacion.SelectedValue.ToString();

                con.Conectar();
                DataTable dt = new DataTable();
                String sQuery = "SELECT id_tipo_pk FROM habitacion WHERE id_habitacion_pk = '" + habitacion + "'";
                MySqlCommand comando = new MySqlCommand(sQuery, con.rutaconectada());
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                adaptador.Fill(dt);
                DataRow fila = dt.Rows[0];
                string sid = Convert.ToString(fila[0]);
                MessageBox.Show(sid);
                con.Desconectar();

                con.Conectar();
                DataTable dt1 = new DataTable();
                String sQuery1 = "SELECT costo_tipo FROM tipo WHERE id_tipo_pk = '" + sid + "'";
                MySqlCommand comando1 = new MySqlCommand(sQuery1, con.rutaconectada());
                MySqlDataAdapter adaptador1 = new MySqlDataAdapter(comando1);
                adaptador1.Fill(dt1);
                DataRow fila1 = dt1.Rows[0];
                string sid1 = Convert.ToString(fila1[0]);
                MessageBox.Show(sid1);
                con.Desconectar();



                con.Conectar();
                String Squery = "insert into  folio_habitacion (id_habitacion_pk,id_cuenta_pagar_pk,costo) values('" + habitacion + "','" + folio + "','" + sid1 + "');";
                con.EjecutarQuery(Squery);
                con.actualizargrid(Squeery, dgv_folio_habitacion);
                //nombre_columna();
                con.Desconectar();
            }
            if (tabControl1.SelectedTab == tabPage3)
            {
                string folio = cbo_folio_salon.SelectedValue.ToString();
                string salon = cbo_salon.SelectedValue.ToString();

                con.Conectar();
                DataTable dt = new DataTable();
                String sQuery = "SELECT costo FROM salon WHERE id_salon_pk = '" + salon + "'";
                MySqlCommand comando = new MySqlCommand(sQuery, con.rutaconectada());
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                adaptador.Fill(dt);
                DataRow fila = dt.Rows[0];
                string sid = Convert.ToString(fila[0]);
                MessageBox.Show(sid);
                con.Desconectar();



                con.Conectar();
                String Squery = "insert into  folio_salon (id_salon_pk,id_cuenta_pagar_pk,costo) values('" + salon + "','" + folio + "','" + sid + "');";
                con.EjecutarQuery(Squery);
                con.actualizargrid(Squeery1, dgv_folio_salon);
                //nombre_columna();
                con.Desconectar();
            }
            if (tabControl1.SelectedTab == tabPage4)
            {
                string folio = cbo_folio_articulo.SelectedValue.ToString();
                string bien = cbo_articulo.SelectedValue.ToString();

                con.Conectar();
                DataTable dt = new DataTable();
                String sQuery = "SELECT costo FROM bien WHERE id_bien_pk = '" + bien + "'";
                MySqlCommand comando = new MySqlCommand(sQuery, con.rutaconectada());
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                adaptador.Fill(dt);
                DataRow fila = dt.Rows[0];
                string sid = Convert.ToString(fila[0]);
                MessageBox.Show(sid);
                con.Desconectar();



                con.Conectar();
                String Squery = "insert into  folio_bien (id_bien_pk,id_cuenta_pagar_pk,costo) values('" + bien + "','" + folio + "','" + sid + "');";
                con.EjecutarQuery(Squery);
                con.actualizargrid(Squeery2, dgv_bien_folio);
                //nombre_columna();
                con.Desconectar();
            }
            if (tabControl1.SelectedTab == tabPage5)
            {
                string folio = cbo_folio_paquete.SelectedValue.ToString();
                string paquete = cbo_paquete.SelectedValue.ToString();

                con.Conectar();
                DataTable dt = new DataTable();
                String sQuery = "SELECT costo FROM promocion WHERE id_promocion_pk = '" + paquete + "'";
                MySqlCommand comando = new MySqlCommand(sQuery, con.rutaconectada());
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                adaptador.Fill(dt);
                DataRow fila = dt.Rows[0];
                string sid = Convert.ToString(fila[0]);
                MessageBox.Show(sid);
                con.Desconectar();



                con.Conectar();
                String Squery = "insert into  folio_promocion (id_promocion_pk,id_cuenta_pagar_pk,costo) values('" + paquete + "','" + folio + "','" + sid + "');";
                con.EjecutarQuery(Squery);
                con.actualizargrid(Squeery3, dgv_folio_paquete);
                //nombre_columna();
                con.Desconectar();
            }
           
        }

        public void actualizartodo()
        {
            if (tabControl1.SelectedTab == tabPage1)
            {
                MessageBox.Show("Folio no puede actualizar");
            }
            if (tabControl1.SelectedTab == tabPage2)
            {
                string folio = cbo_folio_hab.SelectedValue.ToString();
                string habitacion = cbo_habitacion.SelectedValue.ToString();

                con.Conectar();
                DataTable dt = new DataTable();
                String sQuery = "SELECT id_tipo_pk FROM habitacion WHERE id_habitacion_pk = '" + habitacion + "'";
                MySqlCommand comando = new MySqlCommand(sQuery, con.rutaconectada());
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                adaptador.Fill(dt);
                DataRow fila = dt.Rows[0];
                string sid = Convert.ToString(fila[0]);
                MessageBox.Show(sid);
                con.Desconectar();

                con.Conectar();
                DataTable dt1 = new DataTable();
                String sQuery1 = "SELECT costo_tipo FROM tipo WHERE id_tipo_pk = '" + sid + "'";
                MySqlCommand comando1 = new MySqlCommand(sQuery1, con.rutaconectada());
                MySqlDataAdapter adaptador1 = new MySqlDataAdapter(comando1);
                adaptador1.Fill(dt1);
                DataRow fila1 = dt1.Rows[0];
                string sid1 = Convert.ToString(fila1[0]);
                MessageBox.Show(sid1);
                con.Desconectar();

                Codigo = this.dgv_folio_habitacion.CurrentRow.Cells[0].Value.ToString();
                con.Conectar();
                String Squery = "update folio_habitacion  set id_habitacion_pk ='" + habitacion + "', id_cuenta_pagar_pk ='" + folio + "',costo ='" + sid1 + "' where id_folio_habitacion_pk ='" + Codigo + "'";
                con.EjecutarQuery(Squery);
                con.actualizargrid(Squeery, dgv_folio_habitacion);
                //nombre_columna();
                con.Desconectar();
                entrar = true;
            }
            if (tabControl1.SelectedTab == tabPage3)
            {
                string folio = cbo_folio_salon.SelectedValue.ToString();
                string salon = cbo_salon.SelectedValue.ToString();

                con.Conectar();
                DataTable dt = new DataTable();
                String sQuery = "SELECT costo FROM salon WHERE id_salon_pk = '" + salon + "'";
                MySqlCommand comando = new MySqlCommand(sQuery, con.rutaconectada());
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                adaptador.Fill(dt);
                DataRow fila = dt.Rows[0];
                string sid = Convert.ToString(fila[0]);
                MessageBox.Show(sid);
                con.Desconectar();



                Codigo = this.dgv_folio_salon.CurrentRow.Cells[0].Value.ToString();
                con.Conectar();
                String Squery = "update folio_salon set id_salon_pk ='" + salon + "', id_cuenta_pagar_pk ='" + folio + "',costo ='" + sid + "' where id_folio_salon_pk ='" + Codigo + "'";
                con.EjecutarQuery(Squery);
                con.actualizargrid(Squeery1, dgv_folio_salon);
                //nombre_columna();
                con.Desconectar();
                entrar = true;
            }
            if (tabControl1.SelectedTab == tabPage4)
            {
                string folio = cbo_folio_articulo.SelectedValue.ToString();
                string bien = cbo_articulo.SelectedValue.ToString();

                con.Conectar();
                DataTable dt = new DataTable();
                String sQuery = "SELECT costo FROM bien WHERE id_bien_pk = '" + bien + "'";
                MySqlCommand comando = new MySqlCommand(sQuery, con.rutaconectada());
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                adaptador.Fill(dt);
                DataRow fila = dt.Rows[0];
                string sid = Convert.ToString(fila[0]);
                MessageBox.Show(sid);
                con.Desconectar();



                Codigo = this.dgv_bien_folio.CurrentRow.Cells[0].Value.ToString();
                con.Conectar();
                String Squery = "update folio_bien  set id_bien_pk ='" + bien + "', id_cuenta_pagar_pk ='" + folio + "',costo ='" + sid + "' where id_folio_bien_pk ='" + Codigo + "'";
                con.EjecutarQuery(Squery);
                con.actualizargrid(Squeery2, dgv_bien_folio);
                //nombre_columna();
                con.Desconectar();
                entrar = true;
            }
            if (tabControl1.SelectedTab == tabPage5)
            {
                string folio = cbo_folio_paquete.SelectedValue.ToString();
                string paquete = cbo_paquete.SelectedValue.ToString();

                con.Conectar();
                DataTable dt = new DataTable();
                String sQuery = "SELECT costo FROM promocion WHERE id_promocion_pk = '" + paquete + "'";
                MySqlCommand comando = new MySqlCommand(sQuery, con.rutaconectada());
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                adaptador.Fill(dt);
                DataRow fila = dt.Rows[0];
                string sid = Convert.ToString(fila[0]);
                MessageBox.Show(sid);
                con.Desconectar();


                
                Codigo = this.dgv_folio_paquete.CurrentRow.Cells[0].Value.ToString();
                con.Conectar();
                String Squery = "update folio_promocion set id_promocion_pk ='" + paquete + "', id_cuenta_pagar_pk ='" + folio + "',costo ='" + sid + "' where id_folio_promocion_pk ='" + Codigo + "'";
                con.EjecutarQuery(Squery);
                con.actualizargrid(Squeery3, dgv_folio_paquete);
                //nombre_columna();
                con.Desconectar();
                entrar = true;
            }
           
        }

        public void extraertodo()
        {
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            donde();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if(entrar == true)
            {
                insertartodo();
                MessageBox.Show("insert");
            }
            if(entrar == false)
            {
                actualizartodo();
                MessageBox.Show("update");
            }
            
        }

        private void dgv_bien_folio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_modificar(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage1)
            {
                MessageBox.Show("folio no puede extraer los datos");
            }
            if (tabControl1.SelectedTab == tabPage2)
            {
                string no1 = this.dgv_folio_habitacion.CurrentRow.Cells[2].Value.ToString();
                cbo_habitacion.Text = no1;
                string no2 = this.dgv_folio_habitacion.CurrentRow.Cells[3].Value.ToString();
                cbo_folio_hab.Text = no2;
                entrar = false;
            }
            if (tabControl1.SelectedTab == tabPage3)
            {
                string no3= this.dgv_folio_salon.CurrentRow.Cells[2].Value.ToString();
                cbo_folio_salon.Text = no3;
                string no4 = this.dgv_folio_salon.CurrentRow.Cells[3].Value.ToString();
                cbo_salon.Text = no4;
                entrar = false;
            }
            if (tabControl1.SelectedTab == tabPage4)
            {
                string no5 = this.dgv_bien_folio.CurrentRow.Cells[2].Value.ToString();
                string no6 = this.dgv_bien_folio.CurrentRow.Cells[3].Value.ToString();
                cbo_folio_articulo.Text = no5;
                cbo_articulo.Text = no6;
                entrar = false;
            }
            if (tabControl1.SelectedTab == tabPage5)
            {
                string no7 = this.dgv_folio_paquete.CurrentRow.Cells[2].Value.ToString();
                cbo_folio_paquete.Text = no7;
                string no8 = this.dgv_folio_paquete.CurrentRow.Cells[3].Value.ToString();
                cbo_paquete.Text = no8;
                entrar = false;
            }
            
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            
            if (tabControl1.SelectedTab == tabPage1)
            {
                MessageBox.Show("Folio no puede eliminar");
            }
            if (tabControl1.SelectedTab == tabPage2)
            {
                Codigo = this.dgv_folio_habitacion.CurrentRow.Cells[0].Value.ToString();
                con.Conectar();
                String Squerys = "delete from  folio_habitacion where id_folio_habitacion_pk = '" + Codigo + "';";
                con.EjecutarQuery(Squerys);
                con.actualizargrid(Squeery, dgv_folio_habitacion);
                //nombre_columna();
                con.Desconectar();
            }
            if (tabControl1.SelectedTab == tabPage3)
            {
                Codigo = this.dgv_folio_salon.CurrentRow.Cells[0].Value.ToString();
                con.Conectar();
                String Squerys = "delete from  folio_salon where id_folio_salon_pk = '" + Codigo + "';";
                con.EjecutarQuery(Squerys);
                con.actualizargrid(Squeery, dgv_folio_habitacion);
                //nombre_columna();
                con.Desconectar();
            }
            if (tabControl1.SelectedTab == tabPage4)
            {
                Codigo = this.dgv_bien_folio.CurrentRow.Cells[0].Value.ToString();
                con.Conectar();
                String Squerys = "delete from  folio_bien where id_folio_bien_pk = '" + Codigo + "';";
                con.EjecutarQuery(Squerys);
                con.actualizargrid(Squeery, dgv_folio_habitacion);
                //nombre_columna();
                con.Desconectar();
            }
            if (tabControl1.SelectedTab == tabPage5)
            {
                Codigo = this.dgv_folio_paquete.CurrentRow.Cells[0].Value.ToString();
                con.Conectar();
                String Squerys = "delete from  folio_promocion where id_folio_promocion_pk = '" + Codigo + "';";
                con.EjecutarQuery(Squerys);
                con.actualizargrid(Squeery, dgv_folio_habitacion);
                //nombre_columna();
                con.Desconectar();
            }
           
        }

        private void dgv_folio_habitacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            buscartodo();
        }

        public void buscartodo()
        {
            if (tabControl1.SelectedTab == tabPage1)
            {
                MessageBox.Show("Folio");
            }
            if (tabControl1.SelectedTab == tabPage2)
            {
                con.Conectar();
                String Squerys = ("SELECT a.`id_folio_habitacion_pk`,a.`costo`,b.nombre,c.`id_cuenta_pagar_pk` FROM folio_habitacion a, habitacion b, folio c WHERE a.id_habitacion_pk =b.id_habitacion_pk AND a.id_cuenta_pagar_pk = c.id_cuenta_pagar_pk AND a.id_cuenta_pagar_pk like'%" + txt_buscar_folio_habitacion.Text + "%';");
                con.buscarquery(Squerys);
                con.actualizargrid(Squerys, dgv_folio_habitacion);
                con.Desconectar();
            }
            if (tabControl1.SelectedTab == tabPage3)
            {
                con.Conectar();
                String Squerys = ("SELECT a.`id_folio_salon_pk`,a.`costo`,b.`id_cuenta_pagar_pk`,c.nombre FROM folio_salon a,folio b,salon c WHERE a.id_cuenta_pagar_pk=b.id_cuenta_pagar_pk AND a.id_salon_pk=c.id_salon_pk AND a.id_cuenta_pagar_pk like'%" + txt_buscar_salon.Text + "%';");
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

        public void botonesprinspaleshabilitar()
        {
            btn_eliminar.Enabled = true;
            btn_Modificar.Enabled = true;
            btn_guardar.Enabled = true;
            btn_buscar.Enabled = true;
            btn_actualizarr.Enabled = true;
        }

        public void deshabilitartodo()
        {
            btn_eliminar.Enabled = false;
            btn_Modificar.Enabled = false;
            btn_guardar.Enabled = false;
            btn_buscar.Enabled = false;
            btn_actualizarr.Enabled = false;
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

        private void btn_bloquear_Click(object sender, EventArgs e)
        {
            deshabilitartodo();
        }

        private void dgv_folio_paquete_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            habilitartodo();
        }

        public void buscar()
        {

        }

        private void btn_preciohabitacion_Click(object sender, EventArgs e)
        {
            string habitacion = cbo_habitacion.SelectedValue.ToString();

            con.Conectar();
            DataTable dt = new DataTable();
            String sQuery = "SELECT id_tipo_pk FROM habitacion WHERE id_habitacion_pk = '" + habitacion + "'";
            MySqlCommand comando = new MySqlCommand(sQuery, con.rutaconectada());
            MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
            adaptador.Fill(dt);
            DataRow fila = dt.Rows[0];
            string sid = Convert.ToString(fila[0]);
            //MessageBox.Show(sid);
            con.Desconectar();

            con.Conectar();
            DataTable dt1 = new DataTable();
            String sQuery1 = "SELECT costo_tipo FROM tipo WHERE id_tipo_pk = '" + sid + "'";
            MySqlCommand comando1 = new MySqlCommand(sQuery1, con.rutaconectada());
            MySqlDataAdapter adaptador1 = new MySqlDataAdapter(comando1);
            adaptador1.Fill(dt1);
            DataRow fila1 = dt1.Rows[0];
            string sid1 = Convert.ToString(fila1[0]);
            MessageBox.Show("El Precio de la Habitacion es: Q."+sid1);
            con.Desconectar();
        }

        private void btn_precioSalon_Click(object sender, EventArgs e)
        {
            string salon = cbo_salon.SelectedValue.ToString();

            con.Conectar();
            DataTable dt = new DataTable();
            String sQuery = "SELECT costo FROM salon WHERE id_salon_pk = '" + salon + "'";
            MySqlCommand comando = new MySqlCommand(sQuery, con.rutaconectada());
            MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
            adaptador.Fill(dt);
            DataRow fila = dt.Rows[0];
            string sid = Convert.ToString(fila[0]);
            MessageBox.Show("El Precio de la Salon es: Q." + sid);
            con.Desconectar();
        }

        private void btn_precioarticulo_Click(object sender, EventArgs e)
        {
            string bien = cbo_articulo.SelectedValue.ToString();

            con.Conectar();
            DataTable dt = new DataTable();
            String sQuery = "SELECT costo FROM bien WHERE id_bien_pk = '" + bien + "'";
            MySqlCommand comando = new MySqlCommand(sQuery, con.rutaconectada());
            MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
            adaptador.Fill(dt);
            DataRow fila = dt.Rows[0];
            string sid = Convert.ToString(fila[0]);
            MessageBox.Show("El Precio de Articulo es: Q." + sid);
            con.Desconectar();
        }

        private void btn_preciopaquete_Click(object sender, EventArgs e)
        {
            string paquete = cbo_paquete.SelectedValue.ToString();

            con.Conectar();
            DataTable dt = new DataTable();
            String sQuery = "SELECT costo FROM promocion WHERE id_promocion_pk = '" + paquete + "'";
            MySqlCommand comando = new MySqlCommand(sQuery, con.rutaconectada());
            MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
            adaptador.Fill(dt);
            DataRow fila = dt.Rows[0];
            string sid = Convert.ToString(fila[0]);
            MessageBox.Show("El Precio de Paquete es: Q." + sid);
            con.Desconectar();
        }
    }
}
