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


namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        string tabla1 = "empleado";
        string query = "select * from empleado";
        conexion rs = new conexion();
        public Form1()
        {
            InitializeComponent();
            rs.actualizargrid(query, dataGridView1);
        }
        operaciones op = new operaciones();



        private void button1_Click(object sender, EventArgs e)
        {
            op.ejecutar(dataGridView1,tabla1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
