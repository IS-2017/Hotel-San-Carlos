using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace produccion
{
    public partial class frm_menu_nuevo : Form
    {
        public frm_menu_nuevo()
        {
            InitializeComponent();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    // envio de parametros para insertar nuevo precio
            //    CapaDatos capad = new CapaDatos();
            //    capad.InsertarNuevoPrecio(txt_precio.Text.ToString(), "pt", cmb_tamanio_porcion.SelectedValue.ToString());

            //    //--------- tomar valor ingresado de precio
            //    CapaDatos cd = new CapaDatos();
            //    DataTable dat = cd.ConsultarUltimoValorPrecio();
            //    DataRow fila = dat.Rows[0];
            //    String id_precio = fila["max(id_precio)"].ToString();

            //    // ------------------- envio de parametros para insertar nuevo menu
            //    cd.InsertarNuevoMenu(cmb_tipo.SelectedItem.ToString(), txt_nombre.Text.Trim(), txt_descripcion.Text.Trim(), cmb_receta_seleccion.SelectedValue.ToString(), id_precio);
                

            //    dgv_nuevo_menu.Rows.Add(cmb_tipo.SelectedItem.ToString(), txt_nombre.Text.Trim(), txt_descripcion.Text.Trim(), cmb_receta_seleccion.SelectedItem.ToString(), txt_precio.Text.Trim());
            //    txt_nombre.Text = "";
            //    txt_descripcion.Text = "";
            //    txt_precio.Text = "";

            //    MessageBox.Show("Menu agregado con exito");
            //    dgv_nuevo_menu.Rows.Clear();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }
        seguridad.bitacora accion = new seguridad.bitacora();
        private void frm_menu_nuevo_Load(object sender, EventArgs e)
        {
            try
            {
                // carga de combo box de recetas
                CapaDatos cd = new CapaDatos();
                DataTable dt = cd.ConsultarReceta();
                cmb_receta_seleccion.DataSource = dt;
                cmb_receta_seleccion.DisplayMember = "nombre_receta";
                cmb_receta_seleccion.ValueMember = "id_receta_pk";

                // cargar combobox de tamaño de porciones
                CapaDatos datos = new CapaDatos();
                DataTable dat = datos.ConsultarTamanioPorcion();
                cmb_tamanio_porcion.DataSource = dat;
                cmb_tamanio_porcion.DisplayMember = "tamanio";
                cmb_tamanio_porcion.ValueMember = "id_tamaniop_pk";

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            try
            {
                CapaDatos datos = new CapaDatos();
                DataTable data2 = new DataTable();
                data2 = datos.ObtenerMarcastodo();
                cmb_marca.DataSource = data2;
                cmb_marca.DisplayMember = "nombre_marca";
                cmb_marca.ValueMember = "id_marca_pk";

            }
            catch
            {

            }
            try
            {
                CapaDatos datos2 = new CapaDatos();
                DataTable data3 = new DataTable();
                data3 = datos2.Consulta_linea();
                cmb_linea.DataSource = data3;
                cmb_linea.DisplayMember = "nombre_linea";
                cmb_linea.ValueMember = "id_linea_pk";
            }
            catch
            {

            }

        }

        // text box de precio
        private void txt_precio_TextChanged(object sender, EventArgs e)
        {
            ValidacionNumerica validacion = new ValidacionNumerica();

            if (!validacion.funnumero(txt_precio.Text.Trim().ToString()))
            {
                MessageBox.Show("debe ingresar solo cantidades monetarias");

            }
        }

        

        private void btn_pruebas_Click(object sender, EventArgs e)
        {
            
                CapaDatos capa = new CapaDatos();
                DataTable tabla = capa.ConsultarValorPorcion(cmb_tamanio_porcion.SelectedValue.ToString());
                DataRow tupla = tabla.Rows[0];
                String valor = tupla["valor"].ToString();
                txt_precio.Text = valor;
            
        }

        private void cmb_tamanio_porcion_SelectedIndexChanged(object sender, EventArgs e)
        {
            // consulta de valor de la porcion
            try
            {
                if (cmb_tamanio_porcion.ValueMember != "")
                {
                    CapaDatos capa = new CapaDatos();
                    DataTable tabla = capa.ConsultarValorPorcion(cmb_tamanio_porcion.SelectedValue.ToString());
                    DataRow tupla = tabla.Rows[0];
                    String valor = tupla["valor"].ToString();


                    // calcular precio segun tamanio de porcion y costo de receta seleccionado
                    decimal precio = Convert.ToDecimal(lbl_costo_receta.Text) * Convert.ToDecimal(valor);
                    txt_precio.Text = precio.ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void cmb_receta_seleccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            // extraer costo de receta, previamente seleccionada
            try
            {
                if (cmb_receta_seleccion.SelectedValue.ToString() != "System.Data.DataRowView")
                {
                    CapaDatos cd = new CapaDatos();
                    DataTable dt = cd.ConsultarPrecioReceta(cmb_receta_seleccion.SelectedValue.ToString());
                    DataRow fila = dt.Rows[0];
                    decimal valor = Convert.ToDecimal(fila["costo_receta"].ToString());
                    lbl_costo_receta.Text = valor.ToString();
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // boton cancelar
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            //txt_nombre.Text = "";
            //txt_descripcion.Text = "";
            //txt_precio.Text = "";
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                CapaDatos datos = new CapaDatos();
                int medida = 1;
               
                int result = datos.AgregarBien(Convert.ToDecimal(txt_precio.Text), Convert.ToDecimal(lbl_costo_receta.Text), txt_nombre.Text, Convert.ToInt32(cmb_linea.SelectedValue), medida, Convert.ToInt32(cmb_marca.SelectedValue));
                if (result == 1)
                {
                    MessageBox.Show("Ingresado exitosamente");
                }
                else
                {
                    MessageBox.Show("Ingresado Error al insertar bien");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Error al crear bien", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
            //try
            //{
            // envio de parametros para insertar nuevo precio
            CapaDatos capad = new CapaDatos();
                capad.InsertarNuevoPrecio(txt_precio.Text.ToString(), "PT", cmb_tamanio_porcion.SelectedValue.ToString());

                //--------- tomar valor ingresado de precio
                CapaDatos cd = new CapaDatos();
                DataTable dat = cd.ConsultarUltimoValorPrecio();
                DataRow fila = dat.Rows[0];
                String id_precio = fila["max(id_precio)"].ToString();

                // ------------------- envio de parametros para insertar nuevo menu
                

                cd.InsertarNuevoMenu(cmb_linea.SelectedValue.ToString(), txt_nombre.Text.Trim(), txt_descripcion.Text.Trim(), cmb_receta_seleccion.SelectedValue.ToString(), id_precio);


                dgv_nuevo_menu.Rows.Add(cmb_linea.SelectedValue, txt_nombre.Text.Trim(), cmb_receta_seleccion.Text, cmb_tamanio_porcion.Text, txt_descripcion.Text.Trim());
                txt_nombre.Text = "";
                txt_descripcion.Text = "";
                txt_precio.Text = "";
                lbl_costo_receta.Text = "";
                lbl_tamanio.Text = "";


            //accion.Insertar("tipo"+cmb_tipo.SelectedValue.ToString()+"nombre"+txt_nombre.Text.Trim()+"receta"+cmb_receta_seleccion.SelectedValue.ToString()+"tamanio"+cmb_tamanio_porcion.SelectedValue.ToString()+"precio"+txt_precio.Text.Trim()+"descripcion"+txt_descripcion.Text.Trim(),"tbl_menu");
            //accion.Insertar(cmb_tipo.SelectedValue.ToString() + txt_nombre.Text.Trim() + cmb_receta_seleccion.SelectedValue.ToString() + cmb_tamanio_porcion.SelectedValue.ToString() + txt_precio.Text.Trim() + txt_descripcion.Text.Trim(), "tbl_menu");
            MessageBox.Show("Menu agregado con exito");
                dgv_nuevo_menu.Rows.Clear();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_nombre.Text = "";
            txt_descripcion.Text = "";
            txt_precio.Text = "";
            
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            try {
                dgv_nuevo_menu.Rows.Clear();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {

        }
    }
}
