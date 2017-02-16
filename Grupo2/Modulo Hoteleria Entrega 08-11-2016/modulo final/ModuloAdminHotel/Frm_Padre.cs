﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using seguridad;
using FuncionesNavegador;

namespace ModuloAdminHotel
{
    public partial class Frm_Padre : Form
    {
        Frm_Evento eve;
        Frm_CheckIn checkin;
        Frm_Grid grid;
        Frm_Sugerencia suge;
        Frm_Problema proble;
        Frm_MantenimientoHabitaciones habit;
        Frm_MantenimientoSalones salo;
        Frm_Login login;
        Frm_Folio_Detalle DetalleFolio;
        Frm_Promocion promo;
        Frm_MantenimientoCliente cliente;
        Frm_MantemientoTipoHabitacion tipohab;
        Frm_MantenimientoEmpresa empresa;
        Frm_Invitado invitado;
        Frm_ObjetosOlvidados objolvi;
        Frm_Folio folio;
        Frm_CheckOut checkout;
        string NO_form = "15100";
        
        Frm_ReservacionHotel reservahotel;
    
        Historial form_hist = new Historial();
        FormAsignarPermisosUsuario form_priv = new FormAsignarPermisosUsuario();
        agregarapp form_add = new agregarapp();

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
            if (grid == null)
            {
                grid = new Frm_Grid("buzon");
                grid.MdiParent = this;
                grid.FormClosed += new FormClosedEventHandler(grid_FormClosed);
                grid.Show();
            }
            else
            {
                grid.Activate();
            }
        }


        private void suge_FormClosed(object sender, EventArgs e)
        {
            suge = null;
        }

        private void problemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (grid == null)
            {
                grid = new Frm_Grid("problema");
                grid.MdiParent = this;
                grid.FormClosed += new FormClosedEventHandler(grid_FormClosed);
                grid.Show();
            }
            else
            {
                grid.Activate();
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
            if (grid == null)
            {
                grid = new Frm_Grid("habitacion");
                grid.MdiParent = this;
                grid.FormClosed += new FormClosedEventHandler(grid_FormClosed);
                grid.Show();
            }
            else
            {
                grid.Activate();
            }
        }


        private void habit_FormClosed(object sender, EventArgs e)
        {
            habit = null;
        }

        private void salonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (grid == null)
            {
                grid = new Frm_Grid("salon");
                grid.MdiParent = this;
                grid.FormClosed += new FormClosedEventHandler(grid_FormClosed);
                grid.Show();
            }
            else
            {
                grid.Activate();
            }
        }

        private void salo_FormClosed(object sender, EventArgs e)
        {
            salo = null;
        }



        private void promocionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (grid == null)
            {
                grid = new Frm_Grid("promocion");
                grid.MdiParent = this;
                grid.FormClosed += new FormClosedEventHandler(grid_FormClosed);
                grid.Show();
            }
            else
            {
                grid.Activate();
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
            if (grid == null)
            {
                grid = new Frm_Grid("tipo_habitacion");
                grid.MdiParent = this;
                grid.FormClosed += new FormClosedEventHandler(grid_FormClosed);
                grid.Show();
            }
            else
            {
                grid.Activate();
            }

        }

        private void tipohab_FormClosed(object sender, EventArgs e)
        {
            tipohab = null;
        }

        private void empresaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (grid == null)
            {
                grid = new Frm_Grid("empresa");
                grid.MdiParent = this;
                grid.FormClosed += new FormClosedEventHandler(grid_FormClosed);
                grid.Show();
            }
            else
            {
                grid.Activate();
            }
        }


        private void empresa_FormClosed(object sender, EventArgs e)
        {
            empresa = null;
        }

        private void invitadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (grid == null)
            {
                grid = new Frm_Grid("invitado");
                grid.MdiParent = this;
                grid.FormClosed += new FormClosedEventHandler(grid_FormClosed);
                grid.Show();
            }
            else
            {
                grid.Activate();
            }

        }

        private void invitado_FormClosed(object sender, EventArgs e)
        {
            invitado = null;
        }

        private void objetosOlvidadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (grid == null)
            {
                grid = new Frm_Grid("obj_perdido");
                grid.MdiParent = this;
                grid.FormClosed += new FormClosedEventHandler(grid_FormClosed);
                grid.Show();
            }
            else
            {
                grid.Activate();
            }


        }

        private void objolvi_FormClosed(object sender, EventArgs e)
        {
            objolvi = null;
        }

        private void controlDeHuespedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DetalleFolio == null)
            {
                DetalleFolio = new Frm_Folio_Detalle();
                DetalleFolio.MdiParent = this;
                DetalleFolio.FormClosed += new FormClosedEventHandler(folio_FormClosed);
                DetalleFolio.Show();
            }
            else
            {
                DetalleFolio.Activate();
            }


        }

        private void folio_FormClosed(object sender, EventArgs e)
        {
            DetalleFolio = null;
        }

        private void controlDeHabitacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
         

        }

        private void controlhabit_FormClosed(object sender, EventArgs e)
        {
           
        }

        private void habitacionesEspecificasToolStripMenuItem_Click(object sender, EventArgs e)
        {
           


        }

        private void habitespe_FormClosed(object sender, EventArgs e)
        {
           
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
           


        }

        private void reservasalon_FormClosed(object sender, EventArgs e)
        {
            
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_login login = new Form_login();
            login.FormClosed += new FormClosedEventHandler(login_Closed);
            login.Show();
            this.Hide();
        }

        void login_Closed(Object sender, EventArgs e)
        {
            this.Close();
        }

        private void bitacoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (form_hist == null)
            {
                form_hist = new Historial();
                form_hist.MdiParent = this;

                form_hist.FormClosed += new FormClosedEventHandler(Historial_FormClosed);
                form_hist.Show();
            }
        }
        public void Historial_FormClosed(object sender, FormClosedEventArgs e)
        {
            form_hist = null;
        }
        private void grid_FormClosed(object sender, EventArgs e)
        {
            grid = null;
        }
        private void reservacionDeHabitacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (grid == null)
            {
                grid = new Frm_Grid("reservacion_habitacion");
                grid.MdiParent = this;
                grid.FormClosed += new FormClosedEventHandler(grid_FormClosed);
                grid.Show();
            }
            else
            {
                grid.Activate();

            }
        }
        private void checkin_FormClosed(object sender, EventArgs e)
        {
            checkin = null;
        }

        private void checkInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkin == null)
            {
                checkin = new Frm_CheckIn();
                checkin.MdiParent = this;
                checkin.FormClosed += new FormClosedEventHandler(checkin_FormClosed);
                checkin.Show();
            }
            else
            {
                checkin.Activate();
            }
        }

        private void eve_FormClosed(object sender, EventArgs e)
        {
            checkin = null;
        }
        private void manejoDeEventosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (grid == null)
            {
                grid = new Frm_Grid("evento");
                grid.MdiParent = this;
                grid.FormClosed += new FormClosedEventHandler(grid_FormClosed);
                grid.Show();
            }
            else
            {
                grid.Activate();

            }

        }

        private void clienteMasEfectivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            CR_ClienteEfectivo r = new CR_ClienteEfectivo();
            r.ShowDialog();
        }

        private void Frm_Padre_Load(object sender, EventArgs e)
        {
            form_hist = null;
            form_priv = null;
            form_add = null;
        }

        private void privilegiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (form_priv == null)
            {
                form_priv = new FormAsignarPermisosUsuario();
                form_priv.MdiParent = this;
                form_priv.FormClosed += new FormClosedEventHandler(form_priv_FormClosed);
                form_priv.Show();
            }
            else
            {
                eve.Activate();
            }
        }

        private void form_priv_FormClosed(object sender, FormClosedEventArgs e)
        {
            form_priv = null;
        }

        private void agregarAplicacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (form_add == null)
            {
                form_add = new agregarapp();
                form_add.MdiParent = this;
                form_add.FormClosed += new FormClosedEventHandler(form_add_FormClosed);
                form_add.Show();
            }
            else
            {
                form_add.Activate();
            }
        }

        private void form_add_FormClosed(object sender, FormClosedEventArgs e)
        {
            form_add = null;
        }

        private void tipoHabitacionMasUsadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CR_tipo_habitacion r = new CR_tipo_habitacion();
            r.ShowDialog();
        }

        private const string ayudacinetopiaadministrativa = "ayuda_folio.chm";
        private void ayudaFolioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Help.ShowHelp(this, Application.StartupPath + @"/" + ayudacinetopiaadministrativa);
        }

        private const string ayuda = "ayuda_reservacion.chm";
        private void ayudaReservaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Help.ShowHelp(this, Application.StartupPath + @"/" + ayuda);
        }

        private void crearReporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Abrir.Form2 fv = new Abrir.Form2();

                fv.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private const string ayuda1 = "AyudaAdministracionHotel.chm";

        private void ayudaAdministracionHotelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Help.ShowHelp(this, Application.StartupPath + @"/" + ayuda1);


        }

        private void checkOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkout == null)
            {
                checkout = new Frm_CheckOut();
                checkout.MdiParent = this;
                checkout.FormClosed += new FormClosedEventHandler(checkout_FormClosed);
                checkout.Show();
            }
            else
            {
                checkout.Activate();
            }
        }


        private void checkout_FormClosed(object sender, FormClosedEventArgs e)
        {
            checkout = null;
        }
    }
}