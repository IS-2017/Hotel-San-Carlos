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

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            FunNavegador obj = new FunNavegador();
            obj.activartextbox(textBox1);
            obj.activartextbox(textBox2);
            obj.activartextbox(textBox3);
        }

        private void Componente_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
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
            fn.insertar(datos,tabla);
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
    }
}
