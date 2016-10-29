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
using dllconsultas;

namespace Prototipo__RRHH
{
    public partial class frm_prestaciones_lab : Form
    {
        public frm_prestaciones_lab()
        {
            InitializeComponent();
        }

        String Codigo;
        Boolean Editar;
        String atributo;
        CapaNegocio fn = new CapaNegocio();

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            try
            {
                Editar = false;
                fn.ActivarControles(gpb_devengado);
                fn.LimpiarComponentes(gpb_devengado);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            try
            {
                Editar = false;
                fn.LimpiarComponentes(gpb_devengado);
                fn.InhabilitarComponentes(gpb_devengado);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frm_prestaciones_lab_Load(object sender, EventArgs e)
        {
            fn.InhabilitarComponentes(gpb_devengado);
            fn.InhabilitarComponentes(this);
        }
    }
}
