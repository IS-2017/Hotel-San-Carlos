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

namespace Inventario
{
    public partial class FormFacturasPendientes : Form
    {
        public FormFacturasPendientes()
        {
            InitializeComponent();
        }
        string id_form = "10105";
        int cont = 0;
        private void FormFacturasPendientes_Load(object sender, EventArgs e)
        {
            try
            {
                SistemaInventarioDatos sd = new SistemaInventarioDatos();
                cbo_facturas.DataSource = sd.ObtenerFacturas();
                cbo_facturas.DisplayMember = "COD_FAC";
                cbo_facturas.ValueMember = "COD_FAC";
            }
            catch (Exception ex) { MessageBox.Show("No posee los permisos necesarios!", "¡Seguridad!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void cbo_facturas_SelectedIndexChanged(object sender, EventArgs e)
        {
            SistemaInventarioDatos sd = new SistemaInventarioDatos();
            cont++;
            if (cont >= 3)
            {
                string factura = cbo_facturas.SelectedValue.ToString().Trim();
                string[] factura_separada = factura.Split('-');

                string no = factura_separada[0].Trim();
                string serie = factura_separada[1].Trim();
                string empresa = factura_separada[2].Trim();

               dgw_detfac.DataSource = sd.ObtenerDetalleDoc(no,serie,"Factura",empresa);
                dgw_detfac.Columns[0].HeaderText = "Codigo";
                dgw_detfac.Columns[1].HeaderText = "Descripción";
                dgw_detfac.Columns[2].HeaderText = "Cantidad";

                dgw_detfac.Columns[0].Width = 55;
                dgw_detfac.Columns[1].Width =267;
                dgw_detfac.Columns[2].Width =55;


                lbl_no.Text = no;
                lbl_serie.Text = serie;
                lbl_no.Visible = true;
                lbl_serie.Visible = true;

            }
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {


            //try
            //{
            SistemaInventarioDatos sd = new SistemaInventarioDatos();
            char delimitador = '-';
            foreach (DataGridViewRow fila in dgw_detfac.Rows)
            {

                if (fila.Cells[0].Value != null)
                {

                    string factura = cbo_facturas.SelectedValue.ToString().Trim();
                    string[] factura_separada = factura.Split('-');

                    string no = factura_separada[0].Trim();
                    string serie = factura_separada[1].Trim();
                    string empresa = factura_separada[2].Trim();

                    int cantidad = Convert.ToInt32(fila.Cells[2].Value);


                    string codigo = fila.Cells[0].Value.ToString();

                    string[] codigo_separado = codigo.Split(delimitador);
                    string categoria = codigo_separado[0].Trim();
                    string id_bien = codigo_separado[1].Trim();
                  
                  //-----------INSERTAR 
                    sd.RegistrarMovimientoInvFac("Venta","2" , id_bien, categoria, cantidad, no, serie, "Factura", empresa);
                    //-------desaparecer fac
                    sd.FacturaProcesada(no,serie,"Factura", empresa);

                }






            }
            MessageBox.Show("Exitoso");
        }

   
    }
}
