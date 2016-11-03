using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dllconsultas;
using FuncionesNavegador;
using MySql.Data.MySqlClient;
using System.Data.Odbc;

namespace ModuloAdminHotel
{
    public partial class Frm_Promocion : Form
    {

        Boolean editar;
        String atributo;
        String codigo;
        DataGridView datagridantes;

        conexionmanipulacion con = new conexionmanipulacion();

        public Frm_Promocion()
        {
            InitializeComponent();
        }

        public Frm_Promocion(DataGridView datagrid)
        {
            InitializeComponent();
            datagridantes = datagrid;
        }


        private void Frm_Promocion_Load(object sender, EventArgs e)
        {
            CapaNegocio fn = new CapaNegocio();
            fn.InhabilitarComponentes(this);

            DataSet ds1 = new DataSet();
            String Query1 = "select id_salon_pk, nombre from salon;";
            OdbcDataAdapter dad1 = new OdbcDataAdapter(Query1, con.rutaconectada());
            dad1.Fill(ds1, "salon");
            cbo_salon.DataSource = ds1.Tables[0].DefaultView;
            cbo_salon.ValueMember = ("id_salon_pk");
            cbo_salon.DisplayMember = ("nombre");


            DataSet ds2 = new DataSet();
            String Query2 = "select id_habitacion_pk, nombre from habitacion;";
            OdbcDataAdapter dad2 = new OdbcDataAdapter(Query2, con.rutaconectada());
            dad2.Fill(ds2, "habitacion");
            cbo_habitacion.DataSource = ds2.Tables[0].DefaultView;
            cbo_habitacion.ValueMember = ("id_habitacion_pk");
            cbo_habitacion.DisplayMember = ("nombre");


            DataSet ds3 = new DataSet();
            String Query3 = "select id_bien_pk, descripcion from bien;";
            OdbcDataAdapter dad3 = new OdbcDataAdapter(Query3, con.rutaconectada());
            dad3.Fill(ds3, "bien");
            cbo_bien.DataSource = ds3.Tables[0].DefaultView;
            cbo_bien.ValueMember = ("id_bien_pk");
            cbo_bien.DisplayMember = ("descripcion");


            DataSet ds4 = new DataSet();
            String Query4 = "select id_categoria_pk, tipo_categoria from categoria;";
            OdbcDataAdapter dad4 = new OdbcDataAdapter(Query4, con.rutaconectada());
            dad4.Fill(ds4, "categoria");
            cbo_categoria.DataSource = ds4.Tables[0].DefaultView;
            cbo_categoria.ValueMember = ("id_categoria_pk");
            cbo_categoria.DisplayMember = ("tipo_categoria");


        }

        private void cbo_salon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {

            editar = false;
            CapaNegocio fn = new CapaNegocio();
            fn.ActivarControles(this);
            fn.LimpiarComponentes(this);

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            txt_tipopaquete.Text = cbo_tipopaquete.SelectedItem.ToString();
            txt_estado.Text = cbo_estado.SelectedItem.ToString();
            txt_salon.Text = cbo_salon.SelectedItem.ToString();
            txt_habitacion.Text = cbo_habitacion.SelectedItem.ToString();
            txt_bien.Text = cbo_bien.SelectedItem.ToString();
            txt_categoria.Text = cbo_bien.SelectedItem.ToString();


            CapaNegocio fn = new CapaNegocio();
            TextBox[] textbox = { txt_tipopaquete, txt_nombre, txt_costo, txt_detalle, txt_estado, txt_salon, txt_habitacion, txt_bien, txt_categoria };
            DataTable datos = fn.construirDataTable(textbox);
            if (datos.Rows.Count == 0)
            {
                MessageBox.Show("Hay campos vacios");
            }
            else
            {
                string tabla = "promocion";
                if (editar)
                {
                    fn.modificar(datos, tabla, atributo, codigo);

                }
                else
                {
                    fn.insertar(datos, tabla);
                }
                fn.LimpiarComponentes(this);
                fn.ActualizarGrid(datagridantes, "select * from promocion", tabla);

            }
            //}
            //catch
            //{
            //    MessageBox.Show("Hubo un error durante el proceso");
            //}



        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                editar = true;
                atributo = "id_promocion_pk";
                //codigo = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                codigo = datagridantes.CurrentRow.Cells[0].Value.ToString();

                TextBox[] textbox = { txt_tipopaquete, txt_nombre, txt_costo, txt_detalle, txt_estado, txt_salon, txt_habitacion, txt_bien, txt_categoria };

                CapaNegocio fn = new CapaNegocio();
                fn.llenartextbox(textbox, datagridantes);


            }
            catch
            {
                MessageBox.Show("No ha seleccionado ningun registro a editar");
            }


        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                //                String codigo2 = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                String codigo2 = datagridantes.CurrentRow.Cells[0].Value.ToString();
                String atributo2 = "id_promocion_pk";
                var resultado = MessageBox.Show("Desea borrar el registro", "Confirme su accion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    CapaNegocio fn = new CapaNegocio();
                    string tabla = "promocion";
                    fn.eliminar(tabla, atributo2, codigo2);
                }
            }
            catch
            {
                MessageBox.Show("No ha seleccionado ningun registro a editar");
            }


        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string tabla = "promocion";
            operaciones op = new operaciones();
            op.ejecutar(datagridantes, tabla);

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            editar = false;
            CapaNegocio fn = new CapaNegocio();
            fn.LimpiarComponentes(this);
            fn.InhabilitarComponentes(this);

        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            CapaNegocio fn = new CapaNegocio();
            string tabla = "promocion";
            fn.ActualizarGrid(datagridantes, "select * from promocion", tabla);


        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            CapaNegocio fn = new CapaNegocio();
            fn.Anterior(datagridantes);
            TextBox[] textbox = { txt_tipopaquete, txt_nombre, txt_costo, txt_detalle, txt_estado, txt_salon, txt_habitacion, txt_bien, txt_categoria };
            fn.llenartextbox(textbox, datagridantes);

        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            CapaNegocio fn = new CapaNegocio();
            fn.Siguiente(datagridantes);
            TextBox[] textbox = { txt_tipopaquete, txt_nombre, txt_costo, txt_detalle, txt_estado, txt_salon, txt_habitacion, txt_bien, txt_categoria };
            fn.llenartextbox(textbox, datagridantes);


        }

        private void btn_primero_Click(object sender, EventArgs e)
        {
            CapaNegocio fn = new CapaNegocio();
            fn.Primero(datagridantes);
            TextBox[] textbox = { txt_tipopaquete, txt_nombre, txt_costo, txt_detalle, txt_estado, txt_salon, txt_habitacion, txt_bien, txt_categoria };
            fn.llenartextbox(textbox, datagridantes);

        }

        private void btn_ultimo_Click(object sender, EventArgs e)
        {
            CapaNegocio fn = new CapaNegocio();
            fn.Ultimo(datagridantes);
            TextBox[] textbox = { txt_tipopaquete, txt_nombre, txt_costo, txt_detalle, txt_estado, txt_salon, txt_habitacion, txt_bien, txt_categoria };
            fn.llenartextbox(textbox, datagridantes);

        }
    }
}
