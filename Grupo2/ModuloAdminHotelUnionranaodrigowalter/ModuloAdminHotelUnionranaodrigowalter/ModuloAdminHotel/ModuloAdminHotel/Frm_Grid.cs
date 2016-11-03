using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using FuncionesNavegador;
using dllconsultas;

namespace ModuloAdminHotel
{
    public partial class Frm_Grid : Form
    {
        Frm_MantenimientoEmpresa empresa;

        Frm_Sugerencia suge;
        Frm_Problema proble;
        Frm_MantenimientoHabitaciones habit;
        Frm_MantenimientoSalones salo;
        Frm_Login login;
        Frm_Promocion promo;
        Frm_MantenimientoCliente cliente;
        Frm_MantemientoTipoHabitacion tipohab;
//        Frm_MantenimientoEmpresa empresa;
        Frm_Invitado invitado;
        Frm_ObjetosOlvidados objolvi;
        Frm_Folio folio;
        Frm_ControlDeHabitaciones controlhabit;
        Frm_HabitacionesEspecificas habitespe;
        Frm_ReservacionHotel reservahotel;
        Frm_ReservacionSalon reservasalon;
  //      Frm_Grid grid;


        Frm_Padre padre;
        string tablaa;
        string consulta;

        public Frm_Grid()
        {
            InitializeComponent();
        }

        public Frm_Grid(string tabla)
        {
            tablaa = tabla;
            //MessageBox.Show(tabla);
            InitializeComponent();

            consulta = "select * from " + tablaa + "";
            //MessageBox.Show(consulta);

            //CapaNegocio fn = new CapaNegocio();
            //fn.ActualizarGrid(dataGridView1, consulta, tablaa);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tablaa == "empresa")
            {

                if (empresa == null)
                {
                    empresa = new Frm_MantenimientoEmpresa(dataGridView1);
                    empresa.MdiParent = padre;
                    empresa.FormClosed += new FormClosedEventHandler(empresa_FormClosed);
                    empresa.Show();
                }
                else
                {
                    empresa.Activate();
                }

            }
            else if (tablaa == "tipo")
            {
                if (tipohab == null)
                {
                    tipohab = new Frm_MantemientoTipoHabitacion(dataGridView1);
                    tipohab.MdiParent = padre;
                    tipohab.FormClosed += new FormClosedEventHandler(tipohab_FormClosed);
                    tipohab.Show();
                }
                else
                {
                    tipohab.Activate();
                }



            }
            else if (tablaa == "habitacion")
            {
                if (habit == null)
                {
                    habit = new Frm_MantenimientoHabitaciones(dataGridView1);
                    habit.MdiParent = padre;
                    habit.FormClosed += new FormClosedEventHandler(habit_FormClosed);
                    habit.Show();
                }
                else
                {
                    habit.Activate();
                }

            }

            else if (tablaa == "salon")
            {
                if (salo == null)
                {
                    salo = new Frm_MantenimientoSalones(dataGridView1);
                    salo.MdiParent = padre;
                    salo.FormClosed += new FormClosedEventHandler(salo_FormClosed);
                    salo.Show();
                }
                else
                {
                    salo.Activate();
                }

            }

            else if (tablaa == "promocion")
            {
                if (promo == null)
                {
                    promo = new Frm_Promocion(dataGridView1);
                    promo.MdiParent = padre;
                    promo.FormClosed += new FormClosedEventHandler(promo_FormClosed);
                    promo.Show();
                }
                else
                {
                    promo.Activate();
                }

            }

            else if (tablaa == "invitado")
            {
                if (invitado == null)
                {
                    invitado = new Frm_Invitado(dataGridView1);
                    invitado.MdiParent = padre;
                    invitado.FormClosed += new FormClosedEventHandler(invitado_FormClosed);
                    invitado.Show();
                }
                else
                {
                    invitado.Activate();
                }

            }

            else if (tablaa == "buzon")
            {
                if (suge == null)
                {
                    suge = new Frm_Sugerencia(dataGridView1);
                    suge.MdiParent = padre;
                    suge.FormClosed += new FormClosedEventHandler(suge_FormClosed);
                    suge.Show();
                }
                else
                {
                    suge.Activate();
                }

            }

            else if (tablaa == "problema")
            {
                if (proble == null)
                {
                    proble = new Frm_Problema(dataGridView1);
                    proble.MdiParent = padre;
                    proble.FormClosed += new FormClosedEventHandler(proble_FormClosed);
                    proble.Show();
                }
                else
                {
                    proble.Activate();
                }

            }

            else if (tablaa == "obj_perdido")
            {
                if (objolvi == null)
                {
                    objolvi = new Frm_ObjetosOlvidados(dataGridView1);
                    objolvi.MdiParent = padre;
                    objolvi.FormClosed += new FormClosedEventHandler(objolvi_FormClosed);
                    objolvi.Show();
                }
                else
                {
                    objolvi.Activate();
                }

            }


        }


        private void empresa_FormClosed(object sender, EventArgs e)
        {
            empresa = null;
        }


        private void objolvi_FormClosed(object sender, EventArgs e)
        {
            objolvi = null;
        }
        private void proble_FormClosed(object sender, EventArgs e)
        {
            proble = null;
        }

        private void suge_FormClosed(object sender, EventArgs e)
        {
            suge = null;
        }

        private void invitado_FormClosed(object sender, EventArgs e)
        {
            invitado = null;
        }

        private void promo_FormClosed(object sender, EventArgs e)
        {
            promo = null;
        }

        private void salo_FormClosed(object sender, EventArgs e)
        {
           salo = null;
        }

        private void Frm_Grid_Load(object sender, EventArgs e)
        {
            CapaNegocio fn = new CapaNegocio();
            fn.ActualizarGrid(dataGridView1, consulta, tablaa);
        }


        private void tipohab_FormClosed(object sender, EventArgs e)
        {
            tipohab = null;
        }


        private void habit_FormClosed(object sender, EventArgs e)
        {
            habit = null;
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {

            if (tablaa == "empresa")
            {

                if (empresa == null)
                {
                    empresa = new Frm_MantenimientoEmpresa(dataGridView1);
                    empresa.MdiParent = padre;
                    empresa.FormClosed += new FormClosedEventHandler(empresa_FormClosed);
                    empresa.Show();
                }
                else
                {
                    empresa.Activate();
                }

            }
            else if (tablaa == "tipo")
            {
                if (tipohab == null)
                {
                    tipohab = new Frm_MantemientoTipoHabitacion(dataGridView1);
                    tipohab.MdiParent = padre;
                    tipohab.FormClosed += new FormClosedEventHandler(tipohab_FormClosed);
                    tipohab.Show();
                }
                else
                {
                    tipohab.Activate();
                }



            }
            else if (tablaa == "habitacion")
            {
                if (habit == null)
                {
                    habit = new Frm_MantenimientoHabitaciones(dataGridView1);
                    habit.MdiParent = padre;
                    habit.FormClosed += new FormClosedEventHandler(habit_FormClosed);
                    habit.Show();
                }
                else
                {
                    habit.Activate();
                }

            }

            else if (tablaa == "salon")
            {
                if (salo == null)
                {
                    salo = new Frm_MantenimientoSalones(dataGridView1);
                    salo.MdiParent = padre;
                    salo.FormClosed += new FormClosedEventHandler(salo_FormClosed);
                    salo.Show();
                }
                else
                {
                    salo.Activate();
                }

            }

            else if (tablaa == "promocion")
            {
                if (promo == null)
                {
                    promo = new Frm_Promocion(dataGridView1);
                    promo.MdiParent = padre;
                    promo.FormClosed += new FormClosedEventHandler(promo_FormClosed);
                    promo.Show();
                }
                else
                {
                    promo.Activate();
                }

            }

            else if (tablaa == "invitado")
            {
                if (invitado == null)
                {
                    invitado = new Frm_Invitado(dataGridView1);
                    invitado.MdiParent = padre;
                    invitado.FormClosed += new FormClosedEventHandler(invitado_FormClosed);
                    invitado.Show();
                }
                else
                {
                    invitado.Activate();
                }

            }

            else if (tablaa == "buzon")
            {
                if (suge == null)
                {
                    suge = new Frm_Sugerencia(dataGridView1);
                    suge.MdiParent = padre;
                    suge.FormClosed += new FormClosedEventHandler(suge_FormClosed);
                    suge.Show();
                }
                else
                {
                    suge.Activate();
                }

            }

            else if (tablaa == "problema")
            {
                if (proble == null)
                {
                    proble = new Frm_Problema(dataGridView1);
                    proble.MdiParent = padre;
                    proble.FormClosed += new FormClosedEventHandler(proble_FormClosed);
                    proble.Show();
                }
                else
                {
                    proble.Activate();
                }

            }

            else if (tablaa == "obj_perdido")
            {
                if (objolvi == null)
                {
                    objolvi = new Frm_ObjetosOlvidados(dataGridView1);
                    objolvi.MdiParent = padre;
                    objolvi.FormClosed += new FormClosedEventHandler(objolvi_FormClosed);
                    objolvi.Show();
                }
                else
                {
                    objolvi.Activate();
                }

            }

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            operaciones op = new operaciones();
            op.ejecutar(dataGridView1, tablaa);

        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            CapaNegocio fn = new CapaNegocio();
            fn.Anterior(dataGridView1);

        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            CapaNegocio fn = new CapaNegocio();
            fn.Siguiente(dataGridView1);

        }

        private void btn_primero_Click(object sender, EventArgs e)
        {
            CapaNegocio fn = new CapaNegocio();
            fn.Primero(dataGridView1);

        }

        private void btn_ultimo_Click(object sender, EventArgs e)
        {
            CapaNegocio fn = new CapaNegocio();
            fn.Ultimo(dataGridView1);

        }
    }
}
