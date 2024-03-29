﻿using System;
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
    public partial class Frm_ObjetosOlvidados : Form
    {

        conexionmanipulacion con = new conexionmanipulacion();

        Boolean editar;
        String atributo;
        String codigo;
        DataGridView datagridantes;
        string NO_form = "15106";
        seguridad.bitacora bita = new seguridad.bitacora();

        public Frm_ObjetosOlvidados()
        {
            InitializeComponent();
        }

        public Frm_ObjetosOlvidados(DataGridView datagrid)
        {
            InitializeComponent();
            datagridantes = datagrid;
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
            txt_estado.Text = cbo_estado.SelectedItem.ToString();
            txt_empresa.Text = cbo_empresa.SelectedValue.ToString();

            CapaNegocio fn = new CapaNegocio();
            TextBox[] textbox = { txt_nombre, txt_descripcion, txt_estado, txt_empresa};
            DataTable datos = fn.construirDataTable(textbox);
            if (datos.Rows.Count == 0)
            {
                MessageBox.Show("Hay campos vacios");
            }
            else
            {
                string tabla = "obj_perdido";
                if (editar)
                {
                    fn.modificar(datos, tabla, atributo, codigo);
                    bita.Modificar("Se modifico el registro", "obj_perdido");

                }
                else
                {
                    fn.insertar(datos, tabla);
                    bita.Insertar("Se inserto el registro", tabla);
                }
                fn.LimpiarComponentes(this);
                fn.ActualizarGrid(datagridantes, "select * from obj_perdido", tabla);

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
                atributo = "id_obj_perdido_pk";
                //codigo = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                codigo = datagridantes.CurrentRow.Cells[0].Value.ToString();

                TextBox[] textbox = { txt_nombre, txt_descripcion, txt_estado, txt_empresa };

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
                String atributo2 = "id_obj_perdido_pk";
                var resultado = MessageBox.Show("Desea borrar el registro", "Confirme su accion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    CapaNegocio fn = new CapaNegocio();
                    string tabla = "obj_perdido";
                    fn.eliminar(tabla, atributo2, codigo2);
                    bita.Eliminar("Se elimino el registro", tabla);
                }
            }
            catch
            {
                MessageBox.Show("No ha seleccionado ningun registro a editar");
            }


        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string tabla = "obj_perdido";
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
            string tabla = "obj_perdido";
            fn.ActualizarGrid(datagridantes, "select * from obj_perdido", tabla);

        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            CapaNegocio fn = new CapaNegocio();
            fn.Anterior(datagridantes);
            TextBox[] textbox = { txt_nombre, txt_descripcion, txt_estado, txt_empresa };
            fn.llenartextbox(textbox, datagridantes);

        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            CapaNegocio fn = new CapaNegocio();
            fn.Siguiente(datagridantes);
            TextBox[] textbox = { txt_nombre, txt_descripcion, txt_estado, txt_empresa };
            fn.llenartextbox(textbox, datagridantes);

        }

        private void btn_primero_Click(object sender, EventArgs e)
        {
            CapaNegocio fn = new CapaNegocio();
            fn.Primero(datagridantes);
            TextBox[] textbox = { txt_nombre, txt_descripcion, txt_estado, txt_empresa };
            fn.llenartextbox(textbox, datagridantes);

        }

        private void btn_ultimo_Click(object sender, EventArgs e)
        {
            CapaNegocio fn = new CapaNegocio();
            fn.Ultimo(datagridantes);
            TextBox[] textbox = { txt_nombre, txt_descripcion, txt_estado, txt_empresa };
            fn.llenartextbox(textbox, datagridantes);

        }

        private void Frm_ObjetosOlvidados_Load(object sender, EventArgs e)
        {

            CapaNegocio fn = new CapaNegocio();
            fn.InhabilitarComponentes(this);

            DataTable seg = seguridad.ObtenerPermisos.Permisos(seguridad.Conexion.User, NO_form);
            if (seg.Rows.Count > 0)
            {
                fn.desactivarPermiso(seg, btn_guardar, btn_eliminar, btn_editar, btn_nuevo, btn_cancelar, btn_actualizar, btn_buscar, btn_anterior, btn_siguiente, btn_primero, btn_ultimo);
            }



            DataSet ds1 = new DataSet();
            String Query1 = "select id_empresa_pk, nombre from empresa;";
            OdbcDataAdapter dad1 = new OdbcDataAdapter(Query1, con.rutaconectada());
            dad1.Fill(ds1, "empresa");

            cbo_empresa.DataSource = ds1.Tables[0].DefaultView;
            cbo_empresa.ValueMember = ("id_empresa_pk");
            cbo_empresa.DisplayMember = ("nombre");

        }
    }
}
