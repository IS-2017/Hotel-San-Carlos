using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using seguridad;
using Abrir;
using FuncionesNavegador;
using dllconsultas;

namespace Menu_seguridad
{
    public partial class Navegador : Form
    {
        public Navegador()
        {
            InitializeComponent();
        }
        private static string id_form = "100";
        String Codigo;
        Boolean Editar;
        String atributo;
        public string[] codigo;
        //para escribir en bitacora
        bitacora bita = new bitacora();
        DataTable seg = seguridad.ObtenerPermisos.Permisos(seguridad.Conexion.User, id_form);

        FuncionesNavegador.CapaNegocio fn = new FuncionesNavegador.CapaNegocio();
        dllconsultas.operaciones op = new dllconsultas.operaciones();

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            Editar = false;
            fn.ActivarControles(this);
            fn.LimpiarComponentes(this);
        }

        public void llenarCbo1()
        {
            string query = "select id_documento_pk,no_documento from documento;";
            string tabla = "documento";
            string valor = "no_documento";
            string mostrar = "no_documento";
            comboBox1 = fn.llenarCbo(query, tabla, comboBox1, valor, mostrar);
        }

        private void Componente_Load(object sender, EventArgs e)
        {

        }


        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                String codigo2 = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                String atributo2 = "id_documento_pk";
                //String campo = "estado";
                var resultado = MessageBox.Show("DESEA BORRAR EL REGISTRO SELECCIONADO", "CONFIRME SU ACCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {

                    string tabla = "documento";
                    fn.eliminar(tabla, atributo2, codigo2);
                    //Para insertar el registro de la eliminacion en tabla documento
                    bita.Eliminar("Se realizo la eliminacion del documento: " + Codigo, "documento");
                }
            }
            catch
            {
                MessageBox.Show("No se ha seleccionado ningun registro a eliminar", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Editar = false;
            fn.LimpiarComponentes(this);
            fn.InhabilitarComponentes(this);
        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            fn.Siguiente(dataGridView1);
            TextBox[] textbox = { textBox4, textBox3, textBox2, textBox5};
            fn.llenartextbox(textbox, dataGridView1);
            dateTimePicker1.Text = textBox5.Text;
            comboBox1.Text = textBox4.Text;
        }

        private void btn_ultimo_Click(object sender, EventArgs e)
        {
            fn.Ultimo(dataGridView1);
            TextBox[] textbox = { textBox4, textBox3, textBox2, textBox5};
            fn.llenartextbox(textbox, dataGridView1);
            dateTimePicker1.Text = textBox5.Text;
            comboBox1.Text = textBox4.Text;
        }

        private void btn_primero_Click(object sender, EventArgs e)
        {
            fn.Primero(dataGridView1);
            TextBox[] textbox = { textBox4, textBox3, textBox2, textBox5};
            fn.llenartextbox(textbox, dataGridView1);
            dateTimePicker1.Text = textBox5.Text;
            comboBox1.Text = textBox4.Text;
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            fn.Anterior(dataGridView1);
            TextBox[] textbox = { textBox4, textBox3, textBox2, textBox5};
            fn.llenartextbox(textbox, dataGridView1);
            dateTimePicker1.Text = textBox5.Text;
            comboBox1.Text = textBox4.Text;
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            string tabla = "documento";
            fn.ActualizarGrid(this.dataGridView1, "Select * from documento WHERE estado <> 'INACTIVO' ", tabla);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            textBox5.Text = dateTimePicker1.Value.ToString("yyyy-MM-dd");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //textBox4.Text = comboBox1.SelectedValue.ToString();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string tabla = "documento";
            op.ejecutar(dataGridView1, tabla);
        }

        private void Navegador_Load(object sender, EventArgs e)
        {
            fn.InhabilitarComponentes(this);
            llenarCbo1();
            //fn.ActualizarGrid(this.dataGridView1, "Select * from empleado WHERE estado <> 'INACTIVO' ");
            fn.desactivarPermiso(seg, btn_guardar, btn_eliminar, btn_editar, btn_nuevo, btn_cancelar, btn_actualizar, btn_buscar, btn_anterior, btn_siguiente, btn_primero, btn_ultimo);
        }

        private void btn_guardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                DataRow permiso = seg.Rows[0];
                int insertar = Convert.ToInt32(permiso[0]);
                textBox4.Text = comboBox1.SelectedValue.ToString();
                textBox5.Text = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                TextBox[] textbox = { textBox2, textBox3, textBox4, textBox5};
                DataTable datos = fn.construirDataTable(textbox);
                if (datos.Rows.Count == 0)
                {
                    MessageBox.Show("Hay campos vacios", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string tabla = "documento";
                    if (Editar)
                    {
                        fn.modificar(datos, tabla, atributo, Codigo);
                        //Para insertar el registro de la modificacion en tabla documento
                        bita.Modificar("Modificacion de documento con codigo: " + Codigo, "documento");
                        if (insertar == 0)
                        {
                            btn_guardar.Enabled = false;
                        }
                    }
                    else
                    {
                        fn.insertar(datos, tabla);
                        //Para insertar el registro de la insercion en tabla documento
                        bita.Insertar("Insercion de documento: " + textBox4.Text, "documento");
                    }
                    fn.LimpiarComponentes(this);
                }
            }
            catch
            {
                MessageBox.Show("Ocurrio un error durante el proceso...", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_editar_Click_1(object sender, EventArgs e)
        {
            try
            {
                Editar = true;
                atributo = "id_documento_pk";
                Codigo = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                label2.Text = Codigo;
                TextBox[] textbox = { textBox4, textBox3, textBox2, textBox5};
                fn.llenartextbox(textbox, dataGridView1);
                dateTimePicker1.Text = textBox5.Text;
                comboBox1.SelectedValue = textBox4.Text;
                btn_guardar.Enabled = true;
                fn.ActivarControles(this);
            }
            catch
            {
                MessageBox.Show("No se ha seleccionado ningun registro a editar", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            try
            {
                Abrir.Form2 fv = new Abrir.Form2();

                fv.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
