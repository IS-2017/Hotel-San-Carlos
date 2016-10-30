using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using seguridad;

namespace produccion
{
    public partial class frm_NuevoProceso : Form
    {
        public frm_NuevoProceso()
        {
            InitializeComponent();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            try
            {

                ValidacionNumerica val = new ValidacionNumerica();
                if (!val.funnumero(txt_tiempo_elaboracion.Text))
                {

                    MessageBox.Show("debe ingresar solo valores numericos");

                }
                else
                {
                    CapaObjetos.nuevoproceso objetoinsertar = new CapaObjetos.nuevoproceso();
                    CapaNegocio insertar = new CapaNegocio();
                    objetoinsertar.nom_proceso = txt_nombre_proceso.Text.Trim();
                    objetoinsertar.tiempo_elabora = Convert.ToDouble(txt_tiempo_elaboracion.Text.Trim());
                    objetoinsertar.medida_tiempo = cmb_medida_tiempo.Text;
                    objetoinsertar.descripcion = txt_descripcion.Text.Trim();
                    objetoinsertar.observacion = txt_observaciones.Text.Trim();
                    insertar.InsertarNuevoProceso(objetoinsertar);

                    MessageBox.Show("Proceso ingresado con exito");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void NuevoProceso_Load(object sender, EventArgs e)
        {
            seguridad.Conexion.DSN = "hotelsancarlos";

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            frm_nuevaformula frm = new frm_nuevaformula();
            this.Hide();
            
        }
    }
}
