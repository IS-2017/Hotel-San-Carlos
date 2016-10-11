using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//ana lilian: guardado de consultas
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
            string traduccion = consultaa.Replace("'", "$");

            string nom = txt_Nombreconsulta.Text;
            String guar = "insert into consultaguardada(idform, nombre, descripcion, tabla) values('1','" + nom + "', '" + traduccion + "','"+tabla+"');";
            ejecutar.EjecutarQuery(guar);
            this.Close();
        }
    }
}
