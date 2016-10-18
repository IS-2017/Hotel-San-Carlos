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
    public partial class frmmenu : Form
    {
        frmPedido pedi;
        frmCotizacion cotiza;
        frmcliente clte;
        Frm_Login login;
        frmdeuda deuda;
        frmoperacion opera;
        frmFactura fac;
        frmRegistroContribuyente ccon;
        

        public frmmenu()
        {
            InitializeComponent();
        }

        private void sugerenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void problemasToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }


        private void mantenimientoHabitacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void mantenimientoSalonesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }


        private void sugerenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void problemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }


        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (login == null)
            {
                login = new Frm_Login();
                login.MdiParent = this;
                login.FormClosed += new FormClosedEventHandler(login_FormClosed);
                login.Show();
            }
            else
            {
                login.Activate();
            }
        }

        private void login_FormClosed(object sender, EventArgs e)
        {
            login = null;
        }


        private void habitacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void salonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }



        private void promocionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void reservacionDeHabitacionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frmmenu_Load(object sender, EventArgs e)
        {

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void pedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pedi == null)
            {
                pedi = new frmPedido();
                pedi.MdiParent = this;
                pedi.FormClosed += new FormClosedEventHandler(cotiza_FormClosed);
                pedi.Show();
            }
            else
            {
                pedi.Activate();
            }


        }

        private void deudaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (deuda == null)
            {
                deuda = new frmdeuda();
                deuda.MdiParent = this;
                deuda.FormClosed += new FormClosedEventHandler(deuda_FormClosed);
                deuda.Show();
            }
            else
            {
                deuda.Activate();
            }
        }


        private void deuda_FormClosed(object sender, EventArgs e)
        {
            deuda = null;
        }

        private void operacionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (opera == null)
            {
                opera = new frmoperacion();
                opera.MdiParent = this;
                opera.FormClosed += new FormClosedEventHandler(opera_FormClosed);
                opera.Show();
            }
            else
            {
                opera.Activate();
            }
        }

        private void opera_FormClosed(object sender, EventArgs e)
        {
            opera = null;
        }

        private void cotizacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cotiza == null)
            {
                cotiza = new frmCotizacion();
                cotiza.MdiParent = this;
                cotiza.FormClosed += new FormClosedEventHandler(cotiza_FormClosed);
                cotiza.Show();
            }
            else
            {
                cotiza.Activate();
            }

        }

        private void cotiza_FormClosed(object sender, EventArgs e)
        {
            cotiza = null;
        }

        private void facturacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fac == null)
            {
                fac = new frmFactura();
                fac.MdiParent = this;
                fac.FormClosed += new FormClosedEventHandler(fac_FormClosed);
                fac.Show();
            }
            else
            {
                fac.Activate();
            }

        }

        private void fac_FormClosed(object sender, EventArgs e)
        {
            fac = null;
        }

        private void catalogosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registroClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clte == null)
            {
                clte = new frmcliente();
                clte.MdiParent = this;
                clte.FormClosed += new FormClosedEventHandler(clte_FormClosed);
                clte.Show();
            }
            else
            {
                clte.Activate();
            }

        }
        private void clte_FormClosed(object sender, EventArgs e)
        {
            clte = null;
        }

        private void registroClienteContribuyenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ccon == null)
            {
                ccon = new frmRegistroContribuyente();
                ccon.MdiParent = this;
                ccon.FormClosed += new FormClosedEventHandler(ccon_FormClosed);
                ccon.Show();
            }
            else
            {
                clte.Activate();
            }

        }
        private void ccon_FormClosed(object sender, EventArgs e)
        {
            ccon = null;
        }
    }
}
