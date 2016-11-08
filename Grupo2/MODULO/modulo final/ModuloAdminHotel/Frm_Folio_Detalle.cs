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
using System.Data.Odbc;

namespace ModuloAdminHotel
{
    public partial class Frm_Folio_Detalle : Form
    {
        metodos con = new metodos();
        public Frm_Folio_Detalle()
        {
            InitializeComponent();
            Carga();
        }

        

        Boolean Editar1;
        string nombre_cliente_filtro;
        string id_folio_promo, id_cuenta_pagarr, id_promo;
        string id_folio_habitacion, id_cuentas_pagar, id_reservacion;
        string id_folio_salon, id_cuentas_pagarr, id_evento;
        string id_folio_bien, id_cuenta_pagar, id_bien;
        double total = 0;
        double total2 = 0;
        double total3 = 0;
        double total4 = 0;

        //=======================================================================================================================
        //--------------------------------------CARGAR ELEMENTOS-------------------------------------------------------
        //=======================================================================================================================
        //programador:walter Recinos
        //fecha inicio: 29-10-2016
        //fecha finalizacion: 02-11-2016

        public void Carga()
        {
            try
            {
                combo10();
                string cft = cbo_nombreft.SelectedValue.ToString();
                combo4(cft);
                string folio = cbo_ftfolio.SelectedValue.ToString();
                carga(folio);
            }
            catch
            {
                MessageBox.Show("No hay ningun cliente ingresado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        public void carga(string folio)
        {
            string Squeeryy = "SELECT a.`id_folio_bien_pk`,a.`costo`,b.`id_cuenta_pagar_pk`,c.descripcion FROM folio_bien a,folio b,bien c WHERE a.id_cuenta_pagar_pk=b.id_cuenta_pagar_pk AND a.id_bien_pk=c.id_bien_pk AND a.id_cuenta_pagar_pk = '"+ folio + "' ";
            string Squeeryy1 = "SELECT a.`id_folio_promocion_pk`,a.`costo`,b.`id_cuenta_pagar_pk`,c.nombre FROM folio_promocion a,folio b,promocion c WHERE a.id_cuenta_pagar_pk=b.id_cuenta_pagar_pk AND a.id_promocion_pk=c.id_promocion_pk AND a.id_cuenta_pagar_pk = '" + folio + "'";
            string Squeeryy2 = "SELECT a.`id_folio_habitacion_pk`,a.`costo`,b.id_reserhabit_pk,c.`id_cuenta_pagar_pk` FROM folio_habitacion a, reservacion_habitacion b, folio c WHERE a.id_reserhabit_pk =b.id_reserhabit_pk AND a.id_cuenta_pagar_pk = c.id_cuenta_pagar_pk AND a.id_cuenta_pagar_pk = '" + folio + "'";
            string Squeeryy3 = "SELECT a.`id_folio_salon_pk`,a.`costo`,b.`id_cuenta_pagar_pk`,c.nombre FROM folio_salon a,folio b,evento c WHERE a.id_cuenta_pagar_pk=b.id_cuenta_pagar_pk AND a.id_evento_pk=c.id_evento_pk AND a.id_cuenta_pagar_pk = '" + folio + "'";


            con.actualizargrid(Squeeryy2, dgv_reservacion);
            con.actualizargrid(Squeeryy, dgv_articulo);
            con.actualizargrid(Squeeryy1, dgv_promocion);
            con.actualizargrid(Squeeryy3, dgv_evento);

            funcion_costos();
        }

        //=======================================================================================================================
        //--------------------------------------ACTIVAR RADIO BUTTOM-------------------------------------------------------
        //=======================================================================================================================
        //programador:walter Recinos
        //fecha inicio: 29-10-2016
        //fecha finalizacion: 02-11-2016

        private void dgv_evento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            radioButton2.Checked = true;
        }

        private void dgv_articulo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            radioButton3.Checked = true;
        }

        private void dgv_promocion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            radioButton4.Checked = true;
        }

        private void dgv_reservacion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            radioButton1.Checked = true;
        }

        private void cbo_nombreft_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cft = cbo_nombreft.SelectedValue.ToString();
            combo4(cft);
            funcion_costos();
        }

        private void cbo_ftfolio_SelectedIndexChanged(object sender, EventArgs e)
        {
            string folio = cbo_ftfolio.SelectedValue.ToString();
            carga(folio);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        //=======================================================================================================================
        //--------------------------------------FUNCION DE IR A FORM FOLIO-------------------------------------------------------
        //=======================================================================================================================
        //programador:walter Recinos
        //fecha inicio: 29-10-2016
        //fecha finalizacion: 02-11-2016

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                nombre_cliente_filtro = cbo_nombreft.Text;
                Editar1 = true;
                string dgv = "dgv_folio_habitacion";
                id_folio_habitacion = this.dgv_reservacion.CurrentRow.Cells[0].Value.ToString();
                id_cuentas_pagar = this.dgv_reservacion.CurrentRow.Cells[3].Value.ToString();
                id_reservacion = this.dgv_reservacion.CurrentRow.Cells[2].Value.ToString();
                Frm_Folio a = new Frm_Folio(id_folio_habitacion, id_cuentas_pagar, id_reservacion, Editar1, dgv_reservacion, dgv, nombre_cliente_filtro);
                a.MdiParent = this.ParentForm;
                a.Show();
            }
            if (radioButton2.Checked == true)
            {
                nombre_cliente_filtro = cbo_nombreft.Text;
                Editar1 = true;
                string dgv = "dgv_folio_salon";
                id_folio_salon = this.dgv_evento.CurrentRow.Cells[0].Value.ToString();
                id_cuentas_pagarr = this.dgv_evento.CurrentRow.Cells[2].Value.ToString();
                id_evento = this.dgv_evento.CurrentRow.Cells[3].Value.ToString();
                Frm_Folio a = new Frm_Folio(id_folio_salon, id_cuentas_pagarr, id_evento, Editar1, dgv_evento, dgv, nombre_cliente_filtro);
                a.MdiParent = this.ParentForm;
                a.Show();
            }
            if(radioButton3.Checked == true)
            {
                nombre_cliente_filtro = cbo_nombreft.Text;
                Editar1 = true;
                string dgv = "dgv_folio_bien";
                id_folio_bien = this.dgv_articulo.CurrentRow.Cells[0].Value.ToString();
                id_cuenta_pagar = this.dgv_articulo.CurrentRow.Cells[2].Value.ToString();
                id_bien = this.dgv_articulo.CurrentRow.Cells[3].Value.ToString();
                Frm_Folio a = new Frm_Folio(id_folio_bien, id_cuenta_pagar, id_bien, Editar1, dgv_articulo, dgv, nombre_cliente_filtro);
                a.MdiParent = this.ParentForm;
                a.Show();
            }
            if (radioButton4.Checked == true)
            {
                nombre_cliente_filtro = cbo_nombreft.Text;
                Editar1 = true;
                string dgv = "dgv_folio_promo";
                id_folio_promo = this.dgv_promocion.CurrentRow.Cells[0].Value.ToString();
                id_cuenta_pagarr = this.dgv_promocion.CurrentRow.Cells[2].Value.ToString();
                id_promo = this.dgv_promocion.CurrentRow.Cells[3].Value.ToString();
                Frm_Folio a = new Frm_Folio(id_folio_promo, id_cuenta_pagarr, id_promo, Editar1, dgv_promocion, dgv, nombre_cliente_filtro);
                a.MdiParent = this.ParentForm;
                a.Show();
            }
        }

        private void Frm_Folio_Detalle_Load(object sender, EventArgs e)
        {

        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            funcion_costos();
        }

        //=======================================================================================================================
        //--------------------------------------AYUDA DE ARCHIVO .CHM-------------------------------------------------------
        //=======================================================================================================================
        //programador:walter Recinos
        //fecha inicio: 29-10-2016
        //fecha finalizacion: 02-11-2016

        private const string ayudacinetopiaadministrativa = "ayuda_folio.chm";
        private void button2_Click_2(object sender, EventArgs e)
        {
            System.Windows.Forms.Help.ShowHelp(this, Application.StartupPath + @"/" + ayudacinetopiaadministrativa);
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            Carga();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            nombre_cliente_filtro = cbo_nombreft.Text;
            Editar1 = true;
            string dgv = "nada";
            id_folio_habitacion = "";
            id_cuentas_pagar = "";
            id_reservacion = "";
            Frm_Folio a = new Frm_Folio(id_folio_habitacion, id_cuentas_pagar, id_reservacion, Editar1, dgv_reservacion, dgv, nombre_cliente_filtro);
            a.MdiParent = this.ParentForm;
            a.Show();
        }

        //=======================================================================================================================
        //--------------------------------------CARGAR COMBOBOX-------------------------------------------------------
        //=======================================================================================================================
        //programador:walter Recinos
        //fecha inicio: 29-10-2016
        //fecha finalizacion: 02-11-2016

        private void combo10()
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
                cbo_nombreft.DataSource = ds.Tables[0].DefaultView;
                //indicamos el valor de los miembros
                cbo_nombreft.ValueMember = ("id_cliente_pk");
                //se indica el valor a desplegar en el combobox

                DataTable dt = ds.Tables[0];
                dt.Columns.Add("NewColumn", typeof(string));

                foreach (DataRow dr in dt.Rows)
                {
                    dr["nombre"] = dr["nombre"].ToString() + " " + dr["apellido"].ToString();
                }
                cbo_nombreft.DataSource = dt;
                cbo_nombreft.DisplayMember = "nombre";
                con.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Los datos no cargaron de forma correcta" + ex, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void combo4(string id_folio)
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
                cbo_ftfolio.DataSource = ds.Tables[0].DefaultView;
                //indicamos el valor de los miembros
                cbo_ftfolio.ValueMember = ("id_cuenta_pagar_pk");
                //se indica el valor a desplegar en el combobox
                cbo_ftfolio.DisplayMember = ("id_cuenta_pagar_pk");
                con.Desconectar();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Los datos no cargaron de forma correcta" + ex, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //=======================================================================================================================
        //--------------------------------------COSTOS DE FORMS-------------------------------------------------------
        //=======================================================================================================================
        //programador:walter Recinos
        //fecha inicio: 29-10-2016
        //fecha finalizacion: 02-11-2016

        public void costo_habitacion()
        {
            total = 0;
            try
            {
                foreach (DataGridViewRow row in dgv_reservacion.Rows)
                {
                    total += Convert.ToDouble(row.Cells[1].Value);
                }
                string subtotal = Convert.ToString(total);
                lbl_costo_reservacion.Text = subtotal;
            }
            catch
            {
                lbl_costo_reservacion.Text = "0.00";
            }
        }
        public void costo_evento()
        {
            total2 = 0;
            try
            {
                foreach (DataGridViewRow row in dgv_evento.Rows)
                {
                    total2 += Convert.ToDouble(row.Cells[1].Value);
                }
                string subtotal = Convert.ToString(total2);
                lbl_costo_evento.Text = subtotal;
            }
            catch
            {
                lbl_costo_reservacion.Text = "0.00";
            }

        }
        public void costo_articulo()
        {
            total3 = 0;
            try
            {
                foreach (DataGridViewRow row in dgv_articulo.Rows)
                {
                    total3 += Convert.ToDouble(row.Cells[1].Value);
                }
                string subtotal = Convert.ToString(total3);
                lbl_costo_articulo.Text = subtotal;
            }
            catch
            {
                lbl_costo_reservacion.Text = "0.00";
            }
        }
        public void costo_promo()
        {
            total4 = 0;
            try
            {
                foreach (DataGridViewRow row in dgv_promocion.Rows)
                {
                    total4 += Convert.ToDouble(row.Cells[1].Value);
                }
                string subtotal = Convert.ToString(total4);
                lbl_costo_promocion.Text = subtotal;
            }
            catch
            {
                lbl_costo_reservacion.Text = "0.00";
            }
        }
        public void costo_total()
        {
            double totaltotal=0;
            totaltotal = total + total2 + total3 + total4;
            string totall = Convert.ToString(totaltotal);
            lbl_total_folio.Text = totall;
        }

        public void funcion_costos()
        {
            costo_habitacion();
            costo_evento();
            costo_articulo();
            costo_promo();
            costo_total();
        }
    }
}
