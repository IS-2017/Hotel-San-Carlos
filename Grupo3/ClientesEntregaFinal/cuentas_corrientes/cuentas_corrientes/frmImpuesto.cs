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
using FuncionesNavegador;
using System.Diagnostics;

namespace cuentas_corrientes
{
    public partial class frmImpuesto : Form
    {
        public frmImpuesto(clsimpuesto imp)
        {
            InitializeComponent();
            try
            {
               
                if (imp != null)
                {

                    ImpAct = imp;
                    txt_nombre.Text = imp.snombre;
                    txt_desc.Text = imp.sdecripcion;
                    txt_porce.Text = Convert.ToString(imp.iporcentaje);
                    btn_nuevo.Enabled = true;
                    btn_guardar.Enabled = false;
                    btn_eliminar.Enabled = true;
                    btn_editar.Enabled = true;
                    btn_cancelar.Enabled = true;

                   // MessageBox.Show("paso");
                }
                else
                {
                    txt_nombre.Text = "";
                    txt_desc.Text = "";
                    txt_porce.Text = "";
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
        Boolean editar; 

        private void frmImpuesto_Load(object sender, EventArgs e)
        {
            //btn_del.Enabled = false;
            //btn_mod.Enabled = false;
            //button3.Enabled = false;
          

        }

        public void mostrar()
        {
            OdbcConnection conexion = seguridad.Conexion.ObtenerConexionODBC();
            OdbcDataAdapter dausuario = new OdbcDataAdapter("SELECT * FROM impuesto", conexion);
            DataSet dsuario = new DataSet();
            dausuario.Fill(dsuario, "nombre");
           // dgv_impuesto.DataSource = dsuario;
            //dgv_impuesto.DataMember = "nombre";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_nombre.Text))
                    MessageBox.Show("Campo obligatorio vacío", "Campo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    clsimpuesto pimp = new clsimpuesto();
                    pimp.iporcentaje =Convert.ToInt16( txt_porce.Text.Trim());
                    pimp.snombre = txt_nombre.Text.Trim();
                    pimp.sdecripcion = txt_desc.Text.Trim();

               

                    int iresultado = clsOpImpuesto.Agregar(pimp);
                    if (iresultado > 0)
                    {
                        MessageBox.Show("Impuesto Guardada Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("No se pudo guardar el impuesto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public clsimpuesto ImpAct { get; set; }

        private void btn_search_Click(object sender, EventArgs e)
        {
            

            try
            {
                frmBuscImpuesto busimp = new frmBuscImpuesto();
                busimp.ShowDialog();
                if (busimp.ImpSelec != null)
                {

                    ImpAct = busimp.ImpSelec;
                    txt_nombre.Text = busimp.ImpSelec.snombre;
                    txt_desc.Text = busimp.ImpSelec.sdecripcion;
                    txt_porce.Text = Convert.ToString(busimp.ImpSelec.iporcentaje);
                  

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
                    clsimpuesto pimp = new clsimpuesto();
                    pimp.iporcentaje = Convert.ToInt16(txt_porce.Text.Trim());
                    pimp.snombre = txt_nombre.Text.Trim();
                    pimp.sdecripcion = txt_desc.Text.Trim();

                    pimp.icod = ImpAct.icod;

                    int iresultado = clsOpImpuesto.Actualizar(pimp);
                    if (iresultado > 0)
                    {
                        MessageBox.Show("Impuesto Actualizado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar el impuesto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                    clsimpuesto pimp = new clsimpuesto();
                    pimp.iporcentaje = Convert.ToDecimal(txt_porce.Text.Trim());
                    pimp.snombre = txt_nombre.Text.Trim();
                    pimp.sdecripcion = txt_desc.Text.Trim();



                    int iresultado = clsOpImpuesto.Agregar(pimp);
                    if (iresultado > 0)
                    {
                        MessageBox.Show("Impuesto Guardada Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_desc.Enabled = false;
                        txt_nombre.Enabled = false;
                        txt_porce.Enabled = false;
                        btn_nuevo.Enabled = true;
                        txt_desc.Clear();
                        txt_nombre.Clear();
                        txt_porce.Clear();
                       
                        
                    }
                    else
                    {
                        MessageBox.Show("No se pudo guardar el impuesto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txt_desc.Enabled = false;
                        txt_nombre.Enabled = false;
                        txt_porce.Enabled = false;
                        btn_nuevo.Enabled = true;
                        txt_desc.Clear();
                        txt_nombre.Clear();
                        txt_porce.Clear();
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
                    clsimpuesto pimp = new clsimpuesto();
                    pimp.iporcentaje = Convert.ToDecimal(txt_porce.Text.Trim());
                    pimp.snombre = txt_nombre.Text.Trim();
                    pimp.sdecripcion = txt_desc.Text.Trim();

                    pimp.icod = ImpAct.icod;

                    int iresultado = clsOpImpuesto.Actualizar(pimp);
                    if (iresultado > 0)
                    {
                        MessageBox.Show("Impuesto Actualizado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_desc.Enabled = false;
                        txt_nombre.Enabled = false;
                        txt_porce.Enabled = false;
                        btn_nuevo.Enabled = true;
                        txt_desc.Clear();
                        txt_nombre.Clear();
                        txt_porce.Clear();
                        btn_editar.Enabled = false;
                        btn_eliminar.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar el impuesto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txt_desc.Enabled = false;
                        txt_nombre.Enabled = false;
                        txt_porce.Enabled = false;
                        btn_nuevo.Enabled = true;
                        txt_desc.Clear();
                        txt_nombre.Clear();
                        txt_porce.Clear();
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

        private void btn_nuevo_Click_1(object sender, EventArgs e)
        {
            editar = false;
            FuncionesNavegador.CapaNegocio fn = new FuncionesNavegador.CapaNegocio();
            fn.ActivarControles(this);
            fn.LimpiarComponentes(this);
            btn_guardar.Enabled = true;
            btn_cancelar.Enabled = true;

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_nombre.Text))
                    MessageBox.Show("Campo obligatorio vacío", "Campo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    clsimpuesto pimp = new clsimpuesto();

                    pimp.snombre = "desactivado";
                  

                    pimp.icod = ImpAct.icod;

                    int iresultado = clsOpImpuesto.Eliminar(pimp);
                    if (iresultado > 0)
                    {
                        MessageBox.Show("Impuesto Eliminado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_desc.Enabled = false;
                        txt_nombre.Enabled = false;
                        txt_porce.Enabled = false;
                        btn_nuevo.Enabled = true;
                        txt_desc.Clear();
                        txt_nombre.Clear();
                        txt_porce.Clear();
                        btn_editar.Enabled = false;
                        btn_eliminar.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el impuesto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txt_desc.Enabled = false;
                        txt_nombre.Enabled = false;
                        txt_porce.Enabled = false;
                        btn_nuevo.Enabled = true;
                        txt_desc.Clear();
                        txt_nombre.Clear();
                        txt_porce.Clear();
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
            txt_porce.Enabled = false;
            btn_nuevo.Enabled = true;
            txt_desc.Clear();
            txt_nombre.Clear();
            txt_porce.Clear();
            btn_editar.Enabled = false;
            btn_eliminar.Enabled = false;
            btn_guardar.Enabled = false;
            btn_nuevo.Enabled = true;
        }

        private void btn_ayuda_Click(object sender, EventArgs e)
        {
            string ruta = "Manual_Impuesto.pdf";
            ProcessStartInfo startinfo = new ProcessStartInfo();
            startinfo.FileName = "AcroRd32.exe";
            startinfo.Arguments = ruta;
            Process.Start(startinfo);
        }
    }
}
