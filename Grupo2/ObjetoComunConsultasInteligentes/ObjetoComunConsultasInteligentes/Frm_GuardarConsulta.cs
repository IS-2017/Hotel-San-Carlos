using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjetoComunConsultasInteligentes
{
    public partial class Frm_GuardarConsulta : Form
    {
        string f;
        ObtieneColumna ejecutar = new ObtieneColumna();
        public Frm_GuardarConsulta()
        {
            InitializeComponent();
        }
        public Frm_GuardarConsulta(string consulta)
        {
            f = consulta;
            InitializeComponent();
        }


        private void Frm_GuardarConsulta_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nom = textBox1.Text;
            String guar = "insert into consultaguardada(idform, nombre, descripcion) values('1','"+nom+"', '"+f+"');";
            ejecutar.EjecutarQuery(guar);
            this.Close();
        }
    }
}
