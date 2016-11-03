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
      
        Frm_ReservacionHotel reservahotel;
        
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

            capadenegocioe fn = new capadenegocioe();
            fn.ActualizarGrid(dataGridView1, consulta, tablaa);

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
        }


        private void empresa_FormClosed(object sender, EventArgs e)
        {
            empresa = null;
        }

        private void salo_FormClosed(object sender, EventArgs e)
        {
           salo = null;
        }

        private void Frm_Grid_Load(object sender, EventArgs e)
        {

        }


        private void tipohab_FormClosed(object sender, EventArgs e)
        {
            tipohab = null;
        }


        private void habit_FormClosed(object sender, EventArgs e)
        {
            habit = null;
        }

    }
}
