using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario
{
    public partial class Detalle_bodega_producto : Form
    {
        public Detalle_bodega_producto()
        {
            InitializeComponent();
        }
        public string id_bien;
        public string id_bodega;
        public string id_categoria;
        private void Detalle_bodega_producto_Load(object sender, EventArgs e)
        {
            SistemaInventarioDatos si = new SistemaInventarioDatos();
            DataTable dtt = si.CongelarExistencias("select id_bien_pk, id_bodega_pk, id_categoria_pk , existencia, existencia_congelada, existencia_auditada from producto_bodega where id_bien_pk = '" + id_bien + "' and id_bodega_pk = '" + id_bodega + "' and id_categoria_pk = '" + id_categoria + "'");
            dataGridView1.DataSource = dtt;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SistemaInventarioDatos si = new SistemaInventarioDatos();
            DataTable dtt = si.CongelarExistencias("select id_bien_pk, id_bodega_pk, id_categoria_pk , existencia, existencia_congelada, existencia_auditada from producto_bodega where id_bien_pk = '" + id_bien + "' and id_bodega_pk = '" + id_bodega + "' and id_categoria_pk = '" + id_categoria + "'");
            dataGridView1.DataSource = dtt;
            string existencia = dtt.Rows[0][3].ToString();
            string existencia_auditada = dtt.Rows[0][5].ToString();
            int existencia2 = Convert.ToInt32(existencia);
            int existencia_auditada2 = Convert.ToInt32(existencia_auditada);
            int operacion = existencia2 - existencia_auditada2;


            if (existencia == existencia_auditada)
            {
                label1.Text = "Hay Coincidencia entre las existencias en Bodega y las Auditadas";

            }
            else
            {
                label1.Text = " No hay Coincidencias entre existencias de Bodega y existencias Auditadas , la diferencia es de :'" + operacion + "' ";
            }

        }
    }
}
