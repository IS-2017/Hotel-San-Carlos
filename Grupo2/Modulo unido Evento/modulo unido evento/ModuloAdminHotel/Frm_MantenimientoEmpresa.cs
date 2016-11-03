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

namespace ModuloAdminHotel
{
    public partial class Frm_MantenimientoEmpresa : Form
    {

        Boolean editar;
        String atributo;
        String codigo;
        DataGridView datagridantes;
        

        public Frm_MantenimientoEmpresa()
        {
            InitializeComponent();
        }

        public Frm_MantenimientoEmpresa(DataGridView datagrid)
        {
            InitializeComponent();
            datagridantes = datagrid;
        }

        
        private void button1_Click(object sender, EventArgs e)
        {

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
            capadenegocioe fn = new capadenegocioe();
            TextBox[] textbox = { txt_nombre, txt_direccion, txt_region, txt_estrellas, txt_nit, txt_correo, txt_telefono };
            DataTable datos = fn.construirDataTable(textbox);
            if (datos.Rows.Count == 0)
            {
                MessageBox.Show("Hay campos vacios");
            }
            else
            {
                string tabla = "empresa";
                if (editar)
                {
                    fn.modificar(datos, tabla, atributo, codigo);

                }
                else
                {
                    fn.insertar(datos, tabla);
                }
                fn.LimpiarComponentes(this);
                fn.ActualizarGrid(datagridantes, "select * from empresa", tabla);

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

                TextBox[] textbox = { txt_nombre, txt_direccion, txt_region, txt_estrellas, txt_nit, txt_correo, txt_telefono };

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
                    string tabla = "empresa";
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
            string tabla = "empresa";
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
            string tabla = "empresa";
            fn.ActualizarGrid(datagridantes, "select * from empresa", tabla);

            
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            capadenegocioe fn = new capadenegocioe();
            fn.Anterior(datagridantes);
            TextBox[] textbox = { txt_nombre, txt_direccion, txt_region, txt_estrellas, txt_nit, txt_correo, txt_telefono };
            fn.llenartextbox(textbox, datagridantes);

            

        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            capadenegocioe fn = new capadenegocioe();
            fn.Siguiente(datagridantes);
            TextBox[] textbox = { txt_nombre, txt_direccion, txt_region, txt_estrellas, txt_nit, txt_correo, txt_telefono };
            fn.llenartextbox(textbox, datagridantes);

            
        }

        private void btn_primero_Click(object sender, EventArgs e)
        {
            capadenegocioe fn = new capadenegocioe();
            fn.Primero(datagridantes);
            TextBox[] textbox = { txt_nombre, txt_direccion, txt_region, txt_estrellas, txt_nit, txt_correo, txt_telefono };
            fn.llenartextbox(textbox, datagridantes);

            
        }

        private void btn_ultimo_Click(object sender, EventArgs e)
        {
            capadenegocioe fn = new capadenegocioe();
            fn.Ultimo(datagridantes);
            TextBox[] textbox = { txt_nombre, txt_direccion, txt_region, txt_estrellas, txt_nit, txt_correo, txt_telefono };
            fn.llenartextbox(textbox, datagridantes);
            
        }

        private void Frm_MantenimientoEmpresa_Load(object sender, EventArgs e)
        {
            capadenegocioe fn = new capadenegocioe();
            fn.InhabilitarComponentes(this);
        }
    }
}
