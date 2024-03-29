﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FuncionesNavegador;

namespace Inventario
{
    public partial class marca : Form
    {
        public marca()
        {
            InitializeComponent();
        }
        Boolean Editar;
        string marca_ant;
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void marca_Load(object sender, EventArgs e)
        {
            txt_marca.ReadOnly = true;
            SistemaInventarioDatos sd = new SistemaInventarioDatos();
            dgw_marca.DataSource = sd.ObtenerMarcas2();
            dgw_marca.Columns[0].HeaderText = "ID";
            dgw_marca.Columns[1].HeaderText = "Marca";
            dgw_marca.Columns[0].Width = 30;
            //dgw_marca.Columns[1].Width = 110;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (Editar)
            {
                SistemaInventarioDatos sid = new SistemaInventarioDatos();
                sid.Modificacion("update marca set nombre_marca= '" + txt_marca.Text + "' where id_marca_pk= '" + marca_ant + "'");
                SistemaInventarioDatos sd = new SistemaInventarioDatos();
                dgw_marca.DataSource = sd.ObtenerMarcas2();
                Editar = false;
            }
            else
            {
                //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
                if (!String.IsNullOrEmpty(txt_marca.Text.Trim()))
                {
                    SistemaInventarioDatos sd = new SistemaInventarioDatos();
                    int x = sd.AgregarMarca(txt_marca.Text.Trim());
                    if (x == 1)
                    {
                        MessageBox.Show("marca registrada exitosamente!");
                        dgw_marca.DataSource = sd.ObtenerMarcas2();
                    }
                    else { MessageBox.Show("no se pudo ingresar la marca!"); }
                }
                else { MessageBox.Show("debe llenar todos los campos"); }
                //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
            }
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            CapaNegocio fn = new CapaNegocio();
            fn.Anterior(dgw_marca);
            TextBox[] textbox = { txt_marca };
            fn.llenartextbox(textbox, dgw_marca);
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            CapaNegocio fn = new CapaNegocio();
            fn.Siguiente(dgw_marca);
            TextBox[] textbox = { txt_marca };
            fn.llenartextbox(textbox, dgw_marca);
        }

        private void btn_primero_Click(object sender, EventArgs e)
        {
            CapaNegocio fn = new CapaNegocio();
            fn.Primero(dgw_marca);
            TextBox[] textbox = { txt_marca };
            fn.llenartextbox(textbox, dgw_marca);
        }

        private void btn_ultimo_Click(object sender, EventArgs e)
        {
            CapaNegocio fn = new CapaNegocio();
            fn.Ultimo(dgw_marca);
            TextBox[] textbox = { txt_marca };
            fn.llenartextbox(textbox, dgw_marca);
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            Editar = false;
            txt_marca.ReadOnly = false;
            txt_marca.Text = "";
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            SistemaInventarioDatos sd = new SistemaInventarioDatos();
            dgw_marca.DataSource = sd.ObtenerMarcas2();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            String id_marca = Convert.ToString(dgw_marca.CurrentRow.Cells[0].Value);

            SistemaInventarioDatos si = new SistemaInventarioDatos();
            si.Eliminar("update marca set estado= 'inactivo' where id_marca_pk = '" + id_marca + "'");
            SistemaInventarioDatos sd = new SistemaInventarioDatos();
            dgw_marca.DataSource = sd.ObtenerMarcas2();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                Editar = true;
                string id_marca = Convert.ToString(dgw_marca.CurrentRow.Cells[0].Value);
                string nombre_marca = Convert.ToString(dgw_marca.CurrentRow.Cells[1].Value);

                txt_marca.Text = nombre_marca;
                txt_marca.ReadOnly = false;
                marca_ant = id_marca;
            }
            catch
            {
                MessageBox.Show("No existen registros que modificar");
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Editar = false;
            txt_marca.Text = "";
        }
    }
}
