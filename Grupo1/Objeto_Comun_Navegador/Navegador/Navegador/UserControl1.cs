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
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            CapaNegocio fn = new CapaNegocio();
            fn.ActivarControles(this);
        }

        private void Componente_Load(object sender, EventArgs e)
        {
            /*textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false; */
            CapaNegocio fn = new CapaNegocio();
            fn.InhabilitarComponentes(this);
           // fn.ActualizarGrid(this.dataGridView1, "Select * from empleado WHERE estado <> 'INACTIVO' ");

        }



        private void btn_guardar_Click(object sender, EventArgs e)
        {
            /*
            FunNavegador fn = new FunNavegador();
            TextBox[] textbox = { textBox1, textBox2, textBox3 };
            DataTable datos = construirDataTable(textbox);
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
            fn.ActualizarGrid(this.dataGridView1, "Select * from empleado ");
            limpiarcajas(); */
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
           /* Editar = true;
            atributo = "codigo";
            Codigo = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox1.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString(); */

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
           /* String codigo2 = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            String atributo2 = "codigo";
            //String campo = "estado";
            var resultado = MessageBox.Show("DESEA BORRAR EL REGISTRO SELECCIONADO", "CONFIRME SU ACCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {

                FunNavegador fn = new FunNavegador();
                string tabla = "empleado";

                fn.eliminar(tabla, atributo2, codigo2);
                */
            } 
        }



    }
