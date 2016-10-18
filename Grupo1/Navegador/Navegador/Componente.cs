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

namespace Navegador
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
            textBox4.Visible = false;
            textBox5.Visible = false;
            FuncionDeControles ctl = new FuncionDeControles();
            ctl.InhabilitarComponentes(this);

            FunNavegador fn = new FunNavegador();
            llenarCbo1();
            //fn.ActualizarGrid(this.dataGridView1, "Select * from empleado WHERE estado <> 'INACTIVO' ");

        }

            

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            /*try
            {*/
                textBox4.Text = comboBox1.SelectedValue.ToString();
                textBox5.Text = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                FunNavegador fn = new FunNavegador();
                TextBox[] textbox = { textBox2, textBox3, textBox4, textBox5 };
                DataTable datos = fn.construirDataTable(textbox);
                if (datos.Rows.Count == 0)
                {
                    MessageBox.Show("Hay campos vacios", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
                fn.LimpiarCombobox(comboBox1);
           /* }
            catch
            {
                MessageBox.Show("Ocurrio un error durante el proceso...", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }
        

        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                Editar = true;
                atributo = "codigo";
                Codigo = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                label2.Text = Codigo;
                textBox1.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox2.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBox3.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            }
            catch
            {
                MessageBox.Show("No se ha seleccionado ningun registro a editar", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
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
            int Codigo1 = 1;
            if (textBox1.Text != "")
            {
                Codigo1 = int.Parse(label2.Text);
            }
            
            string ntabla = "empleado";
            try
            {
                FunNavegador fn = new FunNavegador();
                codigo = fn.Rsiguiente(Codigo1, ntabla);
                label2.Text = codigo[0].ToString();
                textBox1.Text = codigo[1].ToString();
                textBox3.Text = codigo[2].ToString();
                textBox2.Text = codigo[3].ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Es el final de la lista");
            }
        }

        private void btn_ultimo_Click(object sender, EventArgs e)
        {
            string ntabla = "empleado";
            try
            {
                FunNavegador fn = new FunNavegador();
                codigo = fn.Tsiguiente(ntabla);
                label2.Text = codigo[0].ToString();
                textBox1.Text = codigo[1].ToString();
                textBox3.Text = codigo[2].ToString();
                textBox2.Text = codigo[3].ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Es el final de la lista");
            }
        }

        private void btn_primero_Click(object sender, EventArgs e)
        {
            string ntabla = "empleado";
            try
            {
                FunNavegador fn = new FunNavegador();
                codigo = fn.Tanterior(ntabla);
                label2.Text = codigo[0].ToString();
                textBox1.Text = codigo[1].ToString();
                textBox3.Text = codigo[2].ToString();
                textBox2.Text = codigo[3].ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Es el final de la lista");
            }
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            int Codigo1 = 1;
            if (textBox1.Text != "")
            {
                Codigo1 = int.Parse(label2.Text);
            }

            string ntabla = "empleado";
            string dato = "codigo";
            try
            {
                FunNavegador fn = new FunNavegador();
                codigo = fn.Ranterior(Codigo1, dato, ntabla);
                label2.Text = codigo[0].ToString();
                textBox1.Text = codigo[1].ToString();
                textBox3.Text = codigo[2].ToString();
                textBox2.Text = codigo[3].ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Es el final de la lista");
            }
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
    }
}
