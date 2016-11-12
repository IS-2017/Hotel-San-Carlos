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
        double cantidad = 0;
        double horas = 0;
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
                    objetoinsertar.tiempo_elabora = horas;                                                                                                                                                 
                        objetoinsertar.medida_tiempo = cmb_medida_tiempo.Text;
                        objetoinsertar.descripcion = txt_descripcion.Text.Trim();
                        objetoinsertar.observacion = txt_observaciones.Text.Trim();
                        insertar.InsertarNuevoProceso(objetoinsertar);

                        MessageBox.Show("Proceso ingresado con exito");
                        limpiar();

                    
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void NuevoProceso_Load(object sender, EventArgs e)
        {
            try
            {
                seguridad.Conexion.DSN = "hotelsancarlos";
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            frm_nuevaformula frm = new frm_nuevaformula();
            this.Hide();
            
        }
        public void limpiar()
        {
            txt_descripcion.Clear();
            txt_nombre_proceso.Clear();
            txt_observaciones.Clear();
            txt_tiempo_elaboracion.Clear();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
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
                    objetoinsertar.tiempo_elabora = horas;
                    objetoinsertar.medida_tiempo = cmb_medida_tiempo.Text;
                    objetoinsertar.descripcion = txt_descripcion.Text.Trim();
                    objetoinsertar.observacion = txt_observaciones.Text.Trim();
                    insertar.InsertarNuevoProceso(objetoinsertar);

                    MessageBox.Show("Proceso ingresado con exito");
                    limpiar();



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            frm_nuevaformula frm = new frm_nuevaformula();
            this.Hide();
        }

        private void cmb_medida_tiempo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cantidad = Convert.ToDouble(txt_tiempo_elaboracion.Text);

            if (cmb_medida_tiempo.SelectedItem == "Minutos")
            {


                horas = cantidad / 60;

            }
            else if (cmb_medida_tiempo.SelectedItem == "Segundos")
            {
                horas = cantidad / 3600;
            }

            else if (cmb_medida_tiempo.SelectedItem == "Horas")
            {

                horas = cantidad;
            }
            //MessageBox.Show(horas.ToString("N3"));
        }
    }
}
