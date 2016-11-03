using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModuloAdminHotel
{
    public partial class Frm_Folio_Detalle : Form
    {
        metodos con = new metodos();
        public Frm_Folio_Detalle()
        {
            InitializeComponent();
            con.actualizargrid(Squeery, dgv_detallefolio);
        }
        string Squeery = "SELECT a.id_detalle_folio_pk, a.id_cuenta_pagar_pk, a.nombre, a.costo, a.fecha FROM detalle_folio a";

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            con.Conectar();
            String Squerys = ("SELECT a.id_detalle_folio_pk, a.id_cuenta_pagar_pk, a.nombre, a.costo, a.fecha FROM detalle_folio a WHERE a.id_detalle_folio_pk like'%" + txt_buscar_detalle.Text + "%' OR a.nombre like'%" + txt_buscar_detalle.Text + "%';");
            con.buscarquery(Squerys);
            con.actualizargrid(Squerys, dgv_detallefolio);
            con.Desconectar();
        }
    }
}
