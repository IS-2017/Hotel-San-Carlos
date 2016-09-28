using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dllconsultas
{
    public partial class frm_guardar : Form
    {
        metodos ejecutar = new metodos();
        string consultaa, tabla;
        public frm_guardar(string consultaa ,string tabla)
        {
            this.tabla = tabla;
            this.consultaa = consultaa;
            InitializeComponent();
        }

        private void frm_guardar_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nom = textBox1.Text;
            String guar = "insert into consultaguardada(idform, nombre, descripcion, tabla) values('1','" + nom + "', '" + consultaa + "','"+tabla+"');";
            ejecutar.EjecutarQuery(guar);
            this.Close();
        }
    }
}
