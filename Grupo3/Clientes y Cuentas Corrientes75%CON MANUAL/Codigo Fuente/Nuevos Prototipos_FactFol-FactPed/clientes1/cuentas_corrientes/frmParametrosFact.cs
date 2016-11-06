using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cuentas_corrientes
{
    public partial class frmParametrosFact : Form
    {
        public frmParametrosFact(clsParamFact pam)
        {
            InitializeComponent();

            try
            {


                if (pam != null)
                {

                    FmAct = pam;
                    txt_nom.Text = pam.snombre;
                    txt_desc.Text = pam.sdecripcion;
                }
                else
                {
                    txt_nom.Text = "";
                    txt_desc.Text = "";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public clsParamFact FmAct { get; set; }

        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmParametrosFact_Load(object sender, EventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_nom.Text))
                    MessageBox.Show("Campo obligatorio vacío", "Campo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    clsParamFact ptp = new clsParamFact();

                    ptp.snombre = txt_nom.Text.Trim();
                    ptp.sdecripcion = txt_desc.Text.Trim();



                    int iresultado = clsOpParmFact.Agregar(ptp);
                    if (iresultado > 0)
                    {
                        MessageBox.Show("Parametro Guardada Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("No se pudo guardar el parametro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                if (string.IsNullOrWhiteSpace(txt_nom.Text))
                    MessageBox.Show("Campo obligatorio vacío", "Campo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    clsParamFact ptp = new clsParamFact();

                    ptp.snombre = txt_nom.Text.Trim();
                    ptp.sdecripcion = txt_desc.Text.Trim();
                    ptp.icod = FmAct.icod;


                    int iresultado = clsOpParmFact.Actualizar(ptp);
                    if (iresultado > 0)
                    {
                        MessageBox.Show("Parametro Guardada Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("No se pudo guardar el parametro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
