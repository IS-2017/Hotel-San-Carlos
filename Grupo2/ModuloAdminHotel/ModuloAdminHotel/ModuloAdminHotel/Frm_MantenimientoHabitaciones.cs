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
using dllconsultas;
using FuncionesNavegador;
using System.Data.Odbc;

namespace ModuloAdminHotel
{
    public partial class Frm_MantenimientoHabitaciones : Form
    {
        conexionmanipulacion con = new conexionmanipulacion();


        Boolean editar;
        String atributo;
        String codigo;
        DataGridView datagridantes;


        public Frm_MantenimientoHabitaciones()
        {
            InitializeComponent();
        }

        public Frm_MantenimientoHabitaciones(DataGridView datagrid)
        {
            InitializeComponent();
            datagridantes = datagrid;
        }

        private void cbo_tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Frm_MantenimientoHabitaciones_Load(object sender, EventArgs e)
        {
            CapaNegocio fn = new CapaNegocio();
            fn.InhabilitarComponentes(this);


            DataSet ds = new DataSet();
            //se indica la consulta en sql
            String Query = "select id_tipo_pk, especificaciones_tipo from tipo_habitacion;";
            OdbcDataAdapter dad = new OdbcDataAdapter(Query, con.rutaconectada());

            //se indica con quu tabla se llena
            dad.Fill(ds, "tipo_habitacion");

            cbo_tipo.DataSource = ds.Tables[0].DefaultView;
            //indicamos el valor de los miembros
            cbo_tipo.ValueMember = ("id_tipo_pk");
            //se indica el valor a desplegar en el combobox
            cbo_tipo.DisplayMember = ("especificaciones_tipo");


            DataSet ds1 = new DataSet();
            String Query1 = "select id_empresa_pk, nombre from empresa;";
            OdbcDataAdapter dad1 = new OdbcDataAdapter(Query1, con.rutaconectada());

            dad1.Fill(ds1, "empresa");

            cbo_Empresa.DataSource = ds1.Tables[0].DefaultView;
            cbo_Empresa.ValueMember = ("id_empresa_pk");
            cbo_Empresa.DisplayMember = ("nombre");


        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {


        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            


        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
           

        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
           


        }

        private void btn_primero_Click(object sender, EventArgs e)
        {
          

        }

        private void btn_ultimo_Click(object sender, EventArgs e)
        {
           

        }

        private void cbo_Empresa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_nuevo_Click_1(object sender, EventArgs e)
        {
            editar = false;
            CapaNegocio fn = new CapaNegocio();
            fn.ActivarControles(this);
            fn.LimpiarComponentes(this);

        }

        private void btn_guardar_Click_1(object sender, EventArgs e)
        {

            //try { 
            txt_estado.Text = cbo_estado.SelectedItem.ToString();
            txt_tipo.Text = cbo_tipo.SelectedItem.ToString();
            txt_empresa.Text = cbo_Empresa.SelectedItem.ToString();

            MessageBox.Show(txt_empresa.Text);

            CapaNegocio fn = new CapaNegocio();
            TextBox[] textbox = { txt_nombre, txt_nivel, txt_estrellas, txt_Descripcion, txt_estado, txt_tipo, txt_empresa };
            DataTable datos = fn.construirDataTable(textbox);
            if (datos.Rows.Count == 0)
            {
                MessageBox.Show("Hay campos vacios");
            }
            else
            {
                string tabla = "habitacion";
                if (editar)
                {
                    fn.modificar(datos, tabla, atributo, codigo);

                }
                else
                {
                    fn.insertar(datos, tabla);
                }
                fn.LimpiarComponentes(this);
                fn.ActualizarGrid(datagridantes, "select * from habitacion", tabla);

            }
            //}
            //catch
            //{
            //    MessageBox.Show("Hubo un error durante el proceso");
            //}


        }

        private void btn_editar_Click_1(object sender, EventArgs e)
        {
            try
            {
                editar = true;
                atributo = "id_habitacion_pk";
                //codigo = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                codigo = datagridantes.CurrentRow.Cells[0].Value.ToString();

                TextBox[] textbox = { txt_nombre, txt_nivel, txt_estrellas, txt_Descripcion, txt_estado, txt_tipo, txt_empresa };

                CapaNegocio fn = new CapaNegocio();
                fn.llenartextbox(textbox, datagridantes);


            }
            catch
            {
                MessageBox.Show("No ha seleccionado ningun registro a editar");
            }

        }

        private void btn_eliminar_Click_1(object sender, EventArgs e)
        {
            try
            {
                //                String codigo2 = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                String codigo2 = datagridantes.CurrentRow.Cells[0].Value.ToString();
                String atributo2 = "id_habitacion_pk";
                var resultado = MessageBox.Show("Desea borrar el registro", "Confirme su accion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    CapaNegocio fn = new CapaNegocio();
                    string tabla = "habitacion";
                    fn.eliminar(tabla, atributo2, codigo2);
                }
            }
            catch
            {
                MessageBox.Show("No ha seleccionado ningun registro a editar");
            }


        }

        private void btn_buscar_Click_1(object sender, EventArgs e)
        {

            string tabla = "habitacion";
            operaciones op = new operaciones();
            op.ejecutar(datagridantes, tabla);

        }

        private void btn_cancelar_Click_1(object sender, EventArgs e)
        {
            editar = false;
            CapaNegocio fn = new CapaNegocio();
            fn.LimpiarComponentes(this);
            fn.InhabilitarComponentes(this);
        }

        private void btn_actualizar_Click_1(object sender, EventArgs e)
        {
            CapaNegocio fn = new CapaNegocio();
            string tabla = "habitacion";
            fn.ActualizarGrid(datagridantes, "select * from habitacion", tabla);


        }

        private void btn_anterior_Click_1(object sender, EventArgs e)
        {
            CapaNegocio fn = new CapaNegocio();
            fn.Anterior(datagridantes);
            TextBox[] textbox = { txt_nombre, txt_nivel, txt_estrellas, txt_Descripcion, txt_estado, txt_tipo, txt_empresa };
            fn.llenartextbox(textbox, datagridantes);
        }

        private void btn_siguiente_Click_1(object sender, EventArgs e)
        {
            CapaNegocio fn = new CapaNegocio();
            fn.Siguiente(datagridantes);
            TextBox[] textbox = { txt_nombre, txt_nivel, txt_estrellas, txt_Descripcion, txt_estado, txt_tipo, txt_empresa };
            fn.llenartextbox(textbox, datagridantes);
        }

        private void btn_primero_Click_1(object sender, EventArgs e)
        {
            CapaNegocio fn = new CapaNegocio();
            fn.Primero(datagridantes);
            TextBox[] textbox = { txt_nombre, txt_nivel, txt_estrellas, txt_Descripcion, txt_estado, txt_tipo, txt_empresa };
            fn.llenartextbox(textbox, datagridantes);

        }

        private void btn_ultimo_Click_1(object sender, EventArgs e)
        {
            CapaNegocio fn = new CapaNegocio();
            fn.Ultimo(datagridantes);
            TextBox[] textbox = { txt_nombre, txt_nivel, txt_estrellas, txt_Descripcion, txt_estado, txt_tipo, txt_empresa };
            fn.llenartextbox(textbox, datagridantes);

        }
    }
}
