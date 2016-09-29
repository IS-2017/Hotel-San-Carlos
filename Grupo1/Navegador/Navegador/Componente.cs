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
            FuncionDeControles ctl = new FuncionDeControles();
            ctl.ActivarControles(this);
        }

        private void Componente_Load(object sender, EventArgs e)
        {
            /*textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false; */
            FuncionDeControles ctl = new FuncionDeControles();
            ctl.InhabilitarComponentes(this);

            FunNavegador fn = new FunNavegador();
            fn.ActualizarGrid(this.dataGridView1, "Select * from empleado WHERE estado <> 'INACTIVO' ");

        }
        public void limpiarcajas()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
            

        private void btn_guardar_Click(object sender, EventArgs e)
        {

            FunNavegador fn = new FunNavegador();
            TextBox[] textbox = { textBox1, textBox2, textBox3 };
            DataTable datos = construirDataTable(textbox);
            if (datos.Rows.Count==0)
            {
                MessageBox.Show("Hay campos vacios", "Favor Verificar",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string tabla = "empleado";
            if (Editar)
            {
                fn.modificar(datos, tabla,atributo, Codigo);
            }
            else
            {
                fn.insertar(datos, tabla);
            }
            fn.ActualizarGrid(this.dataGridView1, "Select * from empleado ");
            limpiarcajas();
        }
        private DataTable construirDataTable(TextBox[] textbox)
        {
            DataTable datos = new DataTable();
            datos.Columns.Add("Columna", typeof(string));
            datos.Columns.Add("Valor", typeof(string));
            DataRow fila;
            foreach (TextBox tb in textbox)
            {
                fila = datos.NewRow();
                fila["Columna"] = tb.Tag.ToString();
                fila["Valor"] = tb.Text;
                if (tb.Text == "")
                {
                    datos.Clear();
                    return datos;
                }
                datos.Rows.Add(fila);
            }
            return datos;
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            Editar = true;
            atributo = "codigo";
            Codigo = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            label2.Text = Codigo;
            textBox1.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
           
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
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

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            FuncionDeControles ctl = new FuncionDeControles();
            ctl.LimpiarComponentes(this);
            ctl.InhabilitarComponentes(this);
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
    }
}
