using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dllconsultas;

namespace ModuloAdminHotel
{
    public partial class Frm_Folio_Unificado : Form
    {
        metodos con = new metodos();
        public Frm_Folio_Unificado()
        {
            InitializeComponent();
            con.actualizargrid(Squery, dgv_folio_unificado);
        }

        String Squery = "SELECT `id_cuenta_pagar_pk`,`id_detalle_folio_pk`,`costo`,`nombre`,`fecha` FROM `detalle_folio` ";

        private void btn_actualizarr_Click(object sender, EventArgs e)
        {
            con.actualizargrid(Squery, dgv_folio_unificado);
        }

        private void Frm_Folio_Unificado_Load(object sender, EventArgs e)
        {

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            operaciones rs = new operaciones();
            rs.ejecutar(dgv_folio_unificado, "detalle_folio");
        }
    }
}
