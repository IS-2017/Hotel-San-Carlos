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
    public partial class Frm_Padre : Form
    {
        Frm_Sugerencia suge;
        Frm_Problema proble;
        Frm_MantenimientoHabitaciones habit;
        Frm_MantenimientoSalones salo;
        Frm_Login login;
        Frm_Promocion promo;
        Frm_MantenimientoCliente cliente;
        Frm_MantemientoTipoHabitacion tipohab;
        Frm_MantenimientoEmpresa empresa;
        Frm_Invitado invitado;
        Frm_ObjetosOlvidados objolvi;
        Frm_Folio folio;
        Frm_ControlDeHabitaciones controlhabit;
        Frm_HabitacionesEspecificas habitespe;
        Frm_ReservacionHotel reservahotel;
        Frm_ReservacionSalon reservasalon;

        public Frm_Padre()
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

            if (suge == null)
            {
                suge = new Frm_Sugerencia();
                suge.MdiParent = this;
                suge.FormClosed += new FormClosedEventHandler(suge_FormClosed);
                suge.Show();
            }
            else
            {
                suge.Activate();
            }
        }


        private void suge_FormClosed(object sender, EventArgs e)
        {
            suge = null;
        }

        private void problemaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (proble == null)
            {
                proble = new Frm_Problema();
                proble.MdiParent = this;
                proble.FormClosed += new FormClosedEventHandler(proble_FormClosed);
                proble.Show();
            }
            else
            {
                proble.Activate();
            }

        }

        private void proble_FormClosed(object sender, EventArgs e)
        {
            proble = null;
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
            if (habit == null)
            {
                habit = new Frm_MantenimientoHabitaciones();
                habit.MdiParent = this;
                habit.FormClosed += new FormClosedEventHandler(habit_FormClosed);
                habit.Show();
            }
            else
            {
                habit.Activate();
            }
        }


        private void habit_FormClosed(object sender, EventArgs e)
        {
            habit = null;
        }

        private void salonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (salo == null)
            {
                salo = new Frm_MantenimientoSalones();
                salo.MdiParent = this;
                salo.FormClosed += new FormClosedEventHandler(salo_FormClosed);
                salo.Show();
            }
            else
            {
                salo.Activate();
            }
        }

        private void salo_FormClosed(object sender, EventArgs e)
        {
            salo = null;
        }



        private void promocionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (promo == null)
            {
                promo = new Frm_Promocion();
                promo.MdiParent = this;
                promo.FormClosed += new FormClosedEventHandler(promo_FormClosed);
                promo.Show();
            }
            else
            {
                promo.Activate();
            }
        }

        private void promo_FormClosed(object sender, EventArgs e)
        {
            promo = null;
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cliente == null)
            {
                cliente = new Frm_MantenimientoCliente();
                cliente.MdiParent = this;
                cliente.FormClosed += new FormClosedEventHandler(cliente_FormClosed);
                cliente.Show();
            }
            else
            {
                cliente.Activate();
            }
        }


        private void cliente_FormClosed(object sender, EventArgs e)
        {
            cliente = null;
        }

        private void tipoHabitacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tipohab == null)
            {
                tipohab = new Frm_MantemientoTipoHabitacion();
                tipohab.MdiParent = this;
                tipohab.FormClosed += new FormClosedEventHandler(tipohab_FormClosed);
                tipohab.Show();
            }
            else
            {
                tipohab.Activate();
            }

        }

        private void tipohab_FormClosed(object sender, EventArgs e)
        {
            tipohab = null;
        }

        private void empresaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (empresa == null)
            {
                empresa = new Frm_MantenimientoEmpresa();
                empresa.MdiParent = this;
                empresa.FormClosed += new FormClosedEventHandler(empresa_FormClosed);
                empresa.Show();
            }
            else
            {
                empresa.Activate();
            }

        }


        private void empresa_FormClosed(object sender, EventArgs e)
        {
            empresa = null;
        }

        private void invitadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (invitado == null)
            {
                invitado = new Frm_Invitado();
                invitado.MdiParent = this;
                invitado.FormClosed += new FormClosedEventHandler(invitado_FormClosed);
                invitado.Show();
            }
            else
            {
                invitado.Activate();
            }


        }

        private void invitado_FormClosed(object sender, EventArgs e)
        {
            invitado = null;
        }

        private void objetosOlvidadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (objolvi == null)
            {
                objolvi = new Frm_ObjetosOlvidados();
                objolvi.MdiParent = this;
                objolvi.FormClosed += new FormClosedEventHandler(objolvi_FormClosed);
                objolvi.Show();
            }
            else
            {
                objolvi.Activate();
            }


        }

        private void objolvi_FormClosed(object sender, EventArgs e)
        {
            objolvi = null;
        }

        private void controlDeHuespedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (folio == null)
            {
                folio = new Frm_Folio();
                folio.MdiParent = this;
                folio.FormClosed += new FormClosedEventHandler(folio_FormClosed);
                folio.Show();
            }
            else
            {
                folio.Activate();
            }


        }

        private void folio_FormClosed(object sender, EventArgs e)
        {
            folio = null;
        }

        private void controlDeHabitacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (controlhabit == null)
            {
                controlhabit = new Frm_ControlDeHabitaciones();
                controlhabit.MdiParent = this;
                controlhabit.FormClosed += new FormClosedEventHandler(controlhabit_FormClosed);
                controlhabit.Show();
            }
            else
            {
                controlhabit.Activate();
            }


        }

        private void controlhabit_FormClosed(object sender, EventArgs e)
        {
            controlhabit = null;
        }

        private void habitacionesEspecificasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (habitespe == null)
            {
                habitespe = new Frm_HabitacionesEspecificas();
                habitespe.MdiParent = this;
                habitespe.FormClosed += new FormClosedEventHandler(habitespe_FormClosed);
                habitespe.Show();
            }
            else
            {
                habitespe.Activate();
            }


        }

        private void habitespe_FormClosed(object sender, EventArgs e)
        {
            habitespe = null;
        }

        private void reservacionHotelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (reservahotel == null)
            {
                reservahotel = new Frm_ReservacionHotel();
                reservahotel.MdiParent = this;
                reservahotel.FormClosed += new FormClosedEventHandler(reservahotel_FormClosed);
                reservahotel.Show();
            }
            else
            {
                reservahotel.Activate();
            }



        }

        private void reservahotel_FormClosed(object sender, EventArgs e)
        {
            reservahotel = null;
        }

        private void reservacionSalonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (reservasalon == null)
            {
                reservasalon = new Frm_ReservacionSalon();
                reservasalon.MdiParent = this;
                reservasalon.FormClosed += new FormClosedEventHandler(reservasalon_FormClosed);
                reservasalon.Show();
            }
            else
            {
                reservasalon.Activate();
            }



        }

        private void reservasalon_FormClosed(object sender, EventArgs e)
        {
            reservasalon = null;
        }

        private void procesosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void reservacionDeHabitacionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
