using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using MySql.Data.MySqlClient;
using System.Data.Odbc;
using seguridad;
using System.Diagnostics;
using FuncionesNavegador;

namespace cuentas_corrientes
{
    public partial class frmFormaDePago : Form
    {
        public frmFormaDePago(clsFomPago fomp)
        {
            InitializeComponent();
            try
            {
               
                
                if (fomp != null)
                {

                    FmAct = fomp;
                    txt_nombre.Text = fomp.stp;
                    txt_desc.Text = fomp.sdecripcion;
                    btn_nuevo.Enabled = true;
                    btn_guardar.Enabled = false;
                    btn_eliminar.Enabled = true;
                    btn_editar.Enabled = true;
                    btn_cancelar.Enabled = true;
                }
                else
                {
                    txt_nombre.Text = "";
                    txt_desc.Text = "";
                    txt_nombre.Enabled = false;
                    txt_desc.Enabled = false;
                    btn_nuevo.Enabled = true;
                    btn_guardar.Enabled = false;
                    btn_eliminar.Enabled = false;
                    btn_editar.Enabled = false;
                    btn_cancelar.Enabled = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }

        public void llenar()
        {
            OdbcConnection conexion = seguridad.Conexion.ObtenerConexionODBC();
            OdbcDataAdapter dausuario = new OdbcDataAdapter("SELECT * FROM forma_pago", conexion);
            DataSet dsuario = new DataSet();
            dausuario.Fill(dsuario, "tipo_pago");
           // dgv_tipopago.DataSource = dsuario;
            //dgv_tipopago.DataMember = "tipo_pago";
        }

        public clsFomPago FmAct { get; set; }

        private void btn_search_Click(object sender, EventArgs e)
        {

            try
            {
                frm_Buscartp buscpag = new frm_Buscartp();
                buscpag.ShowDialog();
                if (buscpag.PagoSelec != null)
                {

                    FmAct = buscpag.PagoSelec;
                    txt_nombre.Text = buscpag.PagoSelec.stp;
                    txt_desc.Text = buscpag.PagoSelec.sdecripcion;
                  


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_nombre.Text))
                    MessageBox.Show("Campo obligatorio vacío", "Campo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    clsFomPago ptp = new clsFomPago();
                  
                    ptp.stp = txt_nombre.Text.Trim();
                    ptp.sdecripcion = txt_desc.Text.Trim();



                    int iresultado = clsOpFormPago.Agregar(ptp);
                    if (iresultado > 0)
                    {
                        MessageBox.Show("Forma de pago Guardada Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("No se pudo guardar la forma de pago", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_mod_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_nombre.Text))
                    MessageBox.Show("Campo obligatorio vacío", "Campo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    clsFomPago ptp = new clsFomPago();

                    ptp.stp = txt_nombre.Text.Trim();
                    ptp.sdecripcion = txt_desc.Text.Trim();
                    ptp.icod = FmAct.icod;



                    int iresultado = clsOpFormPago.Actualizar(ptp);
                    if (iresultado > 0)
                    {
                        MessageBox.Show("Forma de pago actualizada Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar la forma de pago", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {

        }

        private void frmFormaDePago_Load(object sender, EventArgs e)
        {
            llenar();
            //btn_del.Enabled = false;
            //btn_mod.Enabled = false;
            //button3.Enabled = false;
        }

        private void btn_act_Click(object sender, EventArgs e)
        {
            llenar();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            //btn_del.Enabled = true;
            //btn_mod.Enabled = true;
            //button3.Enabled = true;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_nombre.Text))
                    MessageBox.Show("Campo obligatorio vacío", "Campo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    clsFomPago ptp = new clsFomPago();

                    ptp.stp = txt_nombre.Text.Trim();
                    ptp.sdecripcion = txt_desc.Text.Trim();



                    int iresultado = clsOpFormPago.Agregar(ptp);
                    if (iresultado > 0)
                    {
                        MessageBox.Show("Forma de pago Guardada Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_desc.Enabled = false;
                        txt_nombre.Enabled = false;
                       
                        btn_nuevo.Enabled = true;
                        txt_desc.Clear();
                        txt_nombre.Clear();
                       
                    }
                    else
                    {

                        MessageBox.Show("No se pudo guardar la forma de pago", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txt_desc.Enabled = false;
                        txt_nombre.Enabled = false;

                        btn_nuevo.Enabled = true;
                        txt_desc.Clear();
                        txt_nombre.Clear();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_nombre.Text))
                    MessageBox.Show("Campo obligatorio vacío", "Campo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    clsFomPago ptp = new clsFomPago();

                    ptp.stp = txt_nombre.Text.Trim();
                    ptp.sdecripcion = txt_desc.Text.Trim();
                    ptp.icod = FmAct.icod;



                    int iresultado = clsOpFormPago.Actualizar(ptp);
                    if (iresultado > 0)
                    {
                        MessageBox.Show("Forma de pago actualizada Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_desc.Enabled = false;
                        txt_nombre.Enabled = false;
                    
                        btn_nuevo.Enabled = true;
                        txt_desc.Clear();
                        txt_nombre.Clear();
                        
                        btn_editar.Enabled = false;
                        btn_eliminar.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar la forma de pago", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txt_desc.Enabled = false;
                        txt_nombre.Enabled = false;

                        btn_nuevo.Enabled = true;
                        txt_desc.Clear();
                        txt_nombre.Clear();

                        btn_editar.Enabled = false;
                        btn_eliminar.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        Boolean editar;
        private void btn_nuevo_Click_1(object sender, EventArgs e)
        {
            editar = false;
            FuncionesNavegador.CapaNegocio fn = new FuncionesNavegador.CapaNegocio();
            fn.ActivarControles(this);
            fn.LimpiarComponentes(this);
            btn_guardar.Enabled = true;
            btn_cancelar.Enabled = true;
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_nombre.Text))
                    MessageBox.Show("Campo obligatorio vacío", "Campo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    clsFomPago ptp = new clsFomPago();

                   
                    ptp.sdecripcion = "descativado";
                    ptp.icod = FmAct.icod;



                    int iresultado = clsOpFormPago.Eliminar(ptp);
                    if (iresultado > 0)
                    {
                        MessageBox.Show("Forma de pago eliminada Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_desc.Enabled = false;
                        txt_nombre.Enabled = false;

                        btn_nuevo.Enabled = true;
                        txt_desc.Clear();
                        txt_nombre.Clear();

                        btn_editar.Enabled = false;
                        btn_eliminar.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar la forma de pago", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txt_desc.Enabled = false;
                        txt_nombre.Enabled = false;

                        btn_nuevo.Enabled = true;
                        txt_desc.Clear();
                        txt_nombre.Clear();

                        btn_editar.Enabled = false;
                        btn_eliminar.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {

            txt_desc.Enabled = false;
            txt_nombre.Enabled = false;

            btn_nuevo.Enabled = true;
            txt_desc.Clear();
            txt_nombre.Clear();
           
            btn_editar.Enabled = false;
            btn_eliminar.Enabled = false;
            btn_guardar.Enabled = false;
            btn_nuevo.Enabled = true;
        }

        private void btn_ayuda_Click(object sender, EventArgs e)
        {
            string ruta = "Manual_FormPago.pdf";
            ProcessStartInfo startinfo = new ProcessStartInfo();
            startinfo.FileName = "AcroRd32.exe";
            startinfo.Arguments = ruta;
            Process.Start(startinfo);
        }
    }
}
