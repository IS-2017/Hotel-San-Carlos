using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FuncionesNavegador;
using dllconsultas;


namespace Menu_seguridad
{
    public partial class Componente : Form
    {
        public Componente()
        {
            InitializeComponent();
        }
        String Codigo;
        Boolean Editar;
        String atributo;
        public string[] codigo;
        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            Editar = false;
            FuncionDeControles ctl = new FuncionDeControles();
            FunNavegador fn = new FunNavegador();
            ctl.ActivarControles(this);
            fn.LimpiarTextbox(textBox1);
            fn.LimpiarTextbox(textBox2);
            fn.LimpiarTextbox(textBox3);
        }
        string id_form = "100";
        public void llenarCbo1()
        {
            FunNavegador obj = new FunNavegador();
            string query = "select codigo,nombre from empleado;";
            string tabla = "empleado";
            string valor = "nombre";
            string mostrar = "nombre";
            comboBox1 = obj.llenarCbo(query, tabla, comboBox1, valor, mostrar);
        }

        private void Componente_Load(object sender, EventArgs e)
        {
            /*textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false; */
            /*textBox4.Visible = false;
            textBox5.Visible = false;*/
            FuncionDeControles ctl = new FuncionDeControles();
            ctl.InhabilitarComponentes(this);

            FuncionDeControles fn = new FuncionDeControles();
            llenarCbo1();
            //fn.ActualizarGrid(this.dataGridView1, "Select * from empleado WHERE estado <> 'INACTIVO' ");
            DataTable seg = seguridad.ObtenerPermisos.Permisos(seguridad.Conexion.User,id_form);
            fn.desactivarPermiso(seg,btn_guardar,btn_eliminar,btn_editar,btn_nuevo,btn_cancelar,btn_actualizar,btn_buscar,btn_anterior,btn_siguiente,btn_primero,btn_ultimo);
        }


        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                String codigo2 = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                String atributo2 = "codigo";
                //String campo = "estado";
                var resultado = MessageBox.Show("DESEA BORRAR EL REGISTRO SELECCIONADO", "CONFIRME SU ACCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {

                    FunNavegador fn = new FunNavegador();
                    string tabla = "empleado";
                    fn.eliminar(tabla, atributo2, codigo2);

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
            FuncionDeControles ctl = new FuncionDeControles();
            FunNavegador fn = new FunNavegador();
            ctl.LimpiarComponentes(this);
            ctl.InhabilitarComponentes(this);
            fn.LimpiarTextbox(textBox1);
            fn.LimpiarTextbox(textBox2);
            fn.LimpiarTextbox(textBox3);
        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            FunNavegador fn = new FunNavegador();
            fn.Siguiente(dataGridView1);
            TextBox[] textbox = { textBox4, textBox3, textBox2, textBox5, textbox6, textBox7 };
            fn.llenartextbox(textbox, dataGridView1);
            dateTimePicker1.Text = textBox5.Text;
            comboBox1.Text = textBox4.Text;
        }

        private void btn_ultimo_Click(object sender, EventArgs e)
        {
            FunNavegador fn = new FunNavegador();
            fn.Ultimo(dataGridView1);
            TextBox[] textbox = { textBox4, textBox3, textBox2, textBox5, textbox6, textBox7 };
            fn.llenartextbox(textbox, dataGridView1);
            dateTimePicker1.Text = textBox5.Text;
            comboBox1.Text = textBox4.Text;
        }

        private void btn_primero_Click(object sender, EventArgs e)
        {
            FunNavegador fn = new FunNavegador();
            fn.Primero(dataGridView1);
            TextBox[] textbox = { textBox4, textBox3, textBox2, textBox5, textbox6, textBox7 };
            fn.llenartextbox(textbox, dataGridView1);
            dateTimePicker1.Text = textBox5.Text;
            comboBox1.Text = textBox4.Text;
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            FunNavegador fn = new FunNavegador();
            fn.Anterior(dataGridView1);
            TextBox[] textbox = { textBox4, textBox3, textBox2, textBox5, textbox6, textBox7 };
            fn.llenartextbox(textbox, dataGridView1);
            dateTimePicker1.Text = textBox5.Text;
            comboBox1.Text = textBox4.Text;
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            FunNavegador fn = new FunNavegador();
            string tabla = "empleado";
            fn.ActualizarGrid(this.dataGridView1, "Select * from empleado WHERE estado <> 'INACTIVO' ", tabla);
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
            TextBox[] textbox = { textBox4, textBox3, textBox2, textBox5, textbox6 };
            FunNavegador fn = new FunNavegador();
            fn.llenartextbox(textbox, dataGridView1);
            dateTimePicker1.Text = textBox5.Text;
            comboBox1.Text = textBox4.Text;
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string tabla = "empleado";
            operaciones op = new operaciones();
            op.ejecutar(dataGridView1, tabla);
        }

        private void Componente_Load_1(object sender, EventArgs e)
        {
            /*textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false; */
            /*textBox4.Visible = false;
            textBox5.Visible = false;*/
            FuncionDeControles ctl = new FuncionDeControles();
            ctl.InhabilitarComponentes(this);

            FuncionDeControles fn = new FuncionDeControles();
            llenarCbo1();
            //fn.ActualizarGrid(this.dataGridView1, "Select * from empleado WHERE estado <> 'INACTIVO' ");
            DataTable seg = seguridad.ObtenerPermisos.Permisos(seguridad.Conexion.User, id_form);
            fn.desactivarPermiso(seg, btn_guardar, btn_eliminar, btn_editar, btn_nuevo, btn_cancelar, btn_actualizar, btn_buscar, btn_anterior, btn_siguiente, btn_primero, btn_ultimo);

        }

        private void btn_guardar_Click_1(object sender, EventArgs e)
        {
            /*try
            {*/
                textBox4.Text = comboBox1.SelectedValue.ToString();
                textBox5.Text = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                FunNavegador fn = new FunNavegador();
                TextBox[] textbox = { textBox2, textBox3, textBox4, textBox5, textbox6, textBox7 };
                DataTable datos = fn.construirDataTable(textbox);
                if (datos.Rows.Count == 0)
                {
                    MessageBox.Show("Hay campos vacios", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string tabla = "empleado";
                    if (Editar)
                    {
                        fn.modificar(datos, tabla, atributo, Codigo);
                    }
                    else
                    {
                        fn.insertar(datos, tabla);
                    }
                    // fn.ActualizarGrid(this.dataGridView1, "Select * from empleado ");
                    fn.LimpiarTextbox(textBox1);
                    fn.LimpiarTextbox(textBox2);
                    fn.LimpiarTextbox(textBox3);
                    fn.LimpiarTextbox(textBox4);
                    fn.LimpiarTextbox(textBox5);
                    fn.LimpiarTextbox(textbox6);
                    fn.LimpiarTextbox(textBox7);
                    fn.LimpiarCombobox(comboBox1);
                }
           /* }
            catch
            {
                MessageBox.Show("Ocurrio un error durante el proceso...", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }

        private void btn_editar_Click_1(object sender, EventArgs e)
        {
            try
            {
                Editar = true;
                atributo = "codigo";
                Codigo = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                label2.Text = Codigo;
                TextBox[] textbox = { textBox4, textBox3, textBox2, textBox5, textbox6, textBox7 };
                FunNavegador fn = new FunNavegador();
                fn.llenartextbox(textbox, dataGridView1);
            }
            catch
            {
                MessageBox.Show("No se ha seleccionado ningun registro a editar", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
