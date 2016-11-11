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

namespace cuentas_corrientes
{
    public partial class frmTipocredito : Form
    {
        string sCod = "";
        public frmTipocredito(cls_tcredi imp)
        {
            InitializeComponent();
            try
            {

                if (imp != null)
                {

                    tcdes = imp;
                    txt_tipo.Text = imp.tipo;
                    txt_val.Text = imp.valor;                    

                    MessageBox.Show("paso");
                }
                else
                {
                    txt_tipo.Text = "";
                    txt_val.Text = "";
                    
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        public frmTipocredito(string sCodigo, string stipo, string svalor)
        {
            InitializeComponent();
            //funLlenarComboActividad();
            txt_tipo.Text = stipo;
            txt_val.Text = svalor;
            sCod = sCodigo;
            //cmbActividad.Text = sCodigoActividad;
            //string[] cortActividad = sCodigoActividad.Split('.');
            //txtActividad.Text = cortActividad[0];
        }

        public void mostrar()
        {
            OdbcConnection conexion = seguridad.Conexion.ObtenerConexionODBC();
            OdbcDataAdapter dausuario = new OdbcDataAdapter("SELECT * FROM tipo_credito", conexion);
            DataSet dsuario = new DataSet();
            dausuario.Fill(dsuario, "tipo_credito");
           // dgv_credito.DataSource = dsuario;
            //dgv_credito.DataMember = "tipo_credito";
        }

        private void button3_Click(object sender, EventArgs e)
        {
           /* try
            {
                if (string.IsNullOrWhiteSpace(txt_tipo.Text))
                    MessageBox.Show("Campo obligatorio vacío", "Campo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {

                    cls_tcredi tc = new cls_tcredi();
                    tc.tipo = txt_tipo.Text.Trim();
                    tc.valor = txt_val.Text.Trim();                                        

                    int iresultado = clsOtcredi.Agregar(tc);
                    if (iresultado > 0)
                    {
                        MessageBox.Show("Proyecto Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("No se pudo guardar el proyecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            mostrar();*/
        }
        public cls_tcredi tcdes { get; set; }        

        private void btn_search_Click(object sender, EventArgs e)
        {
            /*try
            {
                frmBuscartcredi bustc = new frmBuscartcredi();
                bustc.ShowDialog();


                if (bustc.destc != null)
                {
                    tcdes = bustc.destc;
                    txt_tipo.Text = bustc.destc.tipo;
                    txt_val.Text = bustc.destc.valor;                                                      

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            mostrar();*/
        }

        private void btn_mod_Click(object sender, EventArgs e)
        {
            /*try
            {
                if (string.IsNullOrWhiteSpace(txt_tipo.Text))

                    MessageBox.Show("Campo obligatorio vacío", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {


                    cls_tcredi tc = new cls_tcredi();
                    tc.tipo = txt_tipo.Text.Trim();
                    tc.valor = txt_val.Text.Trim();
                                      
                    tc.cod = tcdes.cod;

                    int iresultado = clsOtcredi.Actualizar(tc);
                    if (iresultado > 0)
                    {
                        MessageBox.Show("Proyecto actualizado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar el proyecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            mostrar();*/
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            /*try
            {
                if (MessageBox.Show("Esta Seguro que desea eliminar el proyecto Actual", "Estas Seguro??", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (clsOtcredi.Eliminar(tcdes.cod) > 0)
                    {
                        MessageBox.Show("Proyecto Eliminado Correctamente!", "Proyecto Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el proyecto", "Proyecto No Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                    MessageBox.Show("Se cancelo la eliminacion", "Eliminacion Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            mostrar();*/
        }

        private void frmTipocredito_Load(object sender, EventArgs e)
        {
            mostrar();
            //btn_del.Enabled = false;
            //btn_mod.Enabled = false;
           // btn_save.Enabled = false;
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            //btn_del.Enabled = true;
            //btn_mod.Enabled = true;
            //btn_save.Enabled = true;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_tipo.Text))
                    MessageBox.Show("Campo obligatorio vacío", "Campo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {

                    cls_tcredi tc = new cls_tcredi();
                    tc.tipo = txt_tipo.Text.Trim();
                    tc.valor = txt_val.Text.Trim();

                    int iresultado = clsOtcredi.Agregar(tc);
                    if (iresultado > 0)
                    {
                        MessageBox.Show("Proyecto Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("No se pudo guardar el proyecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            //mostrar();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                frmBuscartcredi bustc = new frmBuscartcredi();
                bustc.ShowDialog();


                if (bustc.destc != null)
                {
                    tcdes = bustc.destc;
                    txt_tipo.Text = bustc.destc.tipo;
                    txt_val.Text = bustc.destc.valor;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            //mostrar();
        }

        public int codigo;
        public void id(int id)
        {
            codigo = id;
        }
        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_tipo.Text))

                    MessageBox.Show("Campo obligatorio vacío", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {


                    cls_tcredi tc = new cls_tcredi();
                    tc.tipo = txt_tipo.Text.Trim();
                    tc.valor = txt_val.Text.Trim();

                    tc.cod = codigo;

                    int iresultado = clsOtcredi.Actualizar(tc);
                    if (iresultado > 0)
                    {
                        MessageBox.Show("Proyecto actualizado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar el proyecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

           // mostrar();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Esta Seguro que desea eliminar el proyecto Actual", "Estas Seguro??", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (clsOtcredi.Eliminar(codigo) > 0)
                    {
                        MessageBox.Show("Proyecto Eliminado Correctamente!", "Proyecto Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el proyecto", "Proyecto No Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                    MessageBox.Show("Se cancelo la eliminacion", "Eliminacion Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            //mostrar();
        }
    }
}
