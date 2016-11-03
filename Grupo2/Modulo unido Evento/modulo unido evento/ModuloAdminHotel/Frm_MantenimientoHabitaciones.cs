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
            capadenegocioe fn = new capadenegocioe();
            fn.InhabilitarComponentes(this);


            DataSet ds = new DataSet();
            //se indica la consulta en sql
            String Query = "select id_tipo_pk, especificaciones_tipo from tipo;";
            MySqlDataAdapter dad = new MySqlDataAdapter(Query, con.rutaconectada());
            //se indica con quu tabla se llena
            dad.Fill(ds, "tipo");

            cbo_tipo.DataSource = ds.Tables[0].DefaultView;
            //indicamos el valor de los miembros
            cbo_tipo.ValueMember = ("id_tipo_pk");
            //se indica el valor a desplegar en el combobox
            cbo_tipo.DisplayMember = ("especificaciones_tipo");


            DataSet ds1 = new DataSet();
            String Query1 = "select id_empresa_pk, nombre from empresa;";
            MySqlDataAdapter dad1 = new MySqlDataAdapter(Query1, con.rutaconectada());
            dad1.Fill(ds1, "empresa");

            cbo_Empresa.DataSource = ds1.Tables[0].DefaultView;
            cbo_Empresa.ValueMember = ("id_empresa_pk");
            cbo_Empresa.DisplayMember = ("nombre");


        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            editar = false;
            capadenegocioe fn = new capadenegocioe();
            fn.ActivarControles(this);
            fn.LimpiarComponentes(this);

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            //try { 
            txt_estado.Text = cbo_estado.SelectedItem.ToString();
            txt_tipo.Text = cbo_tipo.SelectedItem.ToString();
            txt_empresa.Text = cbo_Empresa.SelectedItem.ToString();

            

            capadenegocioe fn = new capadenegocioe();
            TextBox[] textbox = { txt_nombre, txt_nivel, txt_estrellas, txt_Descripcion, txt_estado, txt_tipo, txt_empresa};
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

        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                editar = true;
                atributo = "codigo";
                //codigo = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                codigo = datagridantes.CurrentRow.Cells[0].Value.ToString();

                TextBox[] textbox = { txt_nombre, txt_nivel, txt_estrellas, txt_Descripcion, txt_estado, txt_tipo, txt_empresa };

                capadenegocioe fn = new capadenegocioe();
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
                String atributo2 = "codigo";
                var resultado = MessageBox.Show("Desea borrar el registro", "Confirme su accion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    capadenegocioe fn = new capadenegocioe();
                    string tabla = "habitacion";
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
            string tabla = "habitacion";
            operaciones op = new operaciones();
            op.ejecutar(datagridantes, tabla);

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            editar = false;
            capadenegocioe fn = new capadenegocioe();
            fn.LimpiarComponentes(this);
            fn.InhabilitarComponentes(this);


        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            capadenegocioe fn = new capadenegocioe();
            string tabla = "habitacion";
            fn.ActualizarGrid(datagridantes, "select * from habitacion", tabla);


        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            capadenegocioe fn = new capadenegocioe();
            fn.Anterior(datagridantes);
            TextBox[] textbox = { txt_nombre, txt_nivel, txt_estrellas, txt_Descripcion, txt_estado, txt_tipo, txt_empresa };
            fn.llenartextbox(textbox, datagridantes);

        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            capadenegocioe fn = new capadenegocioe();
            fn.Siguiente(datagridantes);
            TextBox[] textbox = { txt_nombre, txt_nivel, txt_estrellas, txt_Descripcion, txt_estado, txt_tipo, txt_empresa };
            fn.llenartextbox(textbox, datagridantes);


        }

        private void btn_primero_Click(object sender, EventArgs e)
        {
            capadenegocioe fn = new capadenegocioe();
            fn.Primero(datagridantes);
            TextBox[] textbox = { txt_nombre, txt_nivel, txt_estrellas, txt_Descripcion, txt_estado, txt_tipo, txt_empresa };
            fn.llenartextbox(textbox, datagridantes);


        }

        private void btn_ultimo_Click(object sender, EventArgs e)
        {
            capadenegocioe fn = new capadenegocioe();
            fn.Ultimo(datagridantes);
            TextBox[] textbox = { txt_nombre, txt_nivel, txt_estrellas, txt_Descripcion, txt_estado, txt_tipo, txt_empresa };
            fn.llenartextbox(textbox, datagridantes);


        }
    }
}
