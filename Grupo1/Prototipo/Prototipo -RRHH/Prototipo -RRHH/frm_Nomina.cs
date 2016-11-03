using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using FuncionesNavegador;
using dllconsultas;
using MySql.Data.MySqlClient;

using dllconsultas;

namespace Prototipo__RRHH
{
    public partial class frm_Nomina : Form
    {
        public frm_Nomina()
        {
            InitializeComponent();
        }

        String id_empresa_pk_res, fecha_inicio_pago_res, fecha_de_corte_res;

        public frm_Nomina(String id_empresa_pk, String fecha_inicio_pago, String fecha_de_corte)
        {
            id_empresa_pk_res = id_empresa_pk;
            fecha_inicio_pago_res = fecha_inicio_pago;
            fecha_de_corte_res = fecha_de_corte;
            InitializeComponent();
        }

        CapaNegocio fn = new CapaNegocio();
        operaciones op = new operaciones();
        Boolean Editar1;
        String id_empleados_pk1;
        Boolean tipo_accion;

        String id_devengos_pk, nombre_dev, detalle_dev, cantidad_debengado;


        private void frm_Nomina_Load(object sender, EventArgs e)
        {
            
            string tabla = "empleado";
            fn.ActualizarGrid(this.dgv_datos_emp, "Select `id_empresa_pk`, `nombre`, `direccion`,  `fecha_ingreso`, `dpi`, `no_afiliacion_igss`, `estado`, `nacionalidad`,  `cargo`, `sueldo`,  `id_empleados_pk` from empleado WHERE estado <> 'INACTIVO' and id_empresa_pk = '"+id_empresa_pk_res +"' ", tabla);
            txt_fec_inic_pag_nom.Text = fecha_inicio_pago_res;
            txt_fec_fin_pag_nom.Text = fecha_de_corte_res;
            compararfechas();
        }


        private void btn_anterior_Click_1(object sender, EventArgs e)
        {
            fn.Anterior(dgv_datos_emp);
            TextBox[] textbox = { txt_nom_emp_nom, txt_cargo_emp_nom, txt_num_afiliac_nom, txt_fecha_ingre_emp_nom, txt_nacion_emp_nom };
            fn.llenartextbox(textbox, dgv_datos_emp);
            llenaridempresa();
            llenardireccion();
        }

        private void btn_siguiente_Click_1(object sender, EventArgs e)
        {
            fn.Siguiente(dgv_datos_emp);
            TextBox[] textbox = { txt_nom_emp_nom, txt_cargo_emp_nom, txt_num_afiliac_nom, txt_fecha_ingre_emp_nom, txt_nacion_emp_nom };
            fn.llenartextbox(textbox, dgv_datos_emp);
            llenaridempresa();
            llenardireccion();
        }


        public void llenaridempresa()
        {
                Conexionmysql.ObtenerConexion();
            String Codigo = this.dgv_datos_emp.CurrentRow.Cells[0].Value.ToString();
            String Query = "select E.nombre, E.id_empresa_pk, N.nombre from empresa E, empleado N where E.id_empresa_pk = '" + Codigo + "' ";
                OdbcCommand MiComando = new OdbcCommand(Query, Conexionmysql.ObtenerConexion());
            txt_nom_empresa_nom.Text = MiComando.ExecuteScalar().ToString();

                Conexionmysql.Desconectar(); 
        }

        public void llenardireccion()
        {
            Conexionmysql.ObtenerConexion();
            String Codigo = this.dgv_datos_emp.CurrentRow.Cells[0].Value.ToString();
            String Query = "select E.direccion, E.id_empresa_pk, N.nombre from empresa E, empleado N where E.id_empresa_pk = '" + Codigo + "' ";
            OdbcCommand MiComando = new OdbcCommand(Query, Conexionmysql.ObtenerConexion());
            txt_dirr_empr_nom.Text = MiComando.ExecuteScalar().ToString();

            Conexionmysql.Desconectar();
        }

        public void compararfechas()
        {
            DateTime fecha1 = Convert.ToDateTime(txt_fec_inic_pag_nom.Text).Date;
            DateTime fecha2 = Convert.ToDateTime(txt_fec_fin_pag_nom.Text).Date;
            double dias = (fecha2 - fecha1).TotalDays;
            txt_perd_liquid_nom.Text = dias.ToString();
        }

        public void llenar_devengos()
        {
            int cont1 = 0;
            id_empleados_pk1 = this.dgv_datos_emp.CurrentRow.Cells[10].Value.ToString();
            

            OdbcCommand Query = new OdbcCommand();
            OdbcConnection Conexion;
            OdbcDataReader consultar;
            string sql = "dsn=hotelsancarlos;server=localhost;database=hotelsancarlos;uid=root;password=";
            Conexion = new OdbcConnection();
            Conexion.ConnectionString = sql;
            Conexion.Open();
            Query.CommandText = "select E.id_devengos_pk, E.nombre, E.detalle, E.cantidad_debengado, N.nombre from devengos E, empleado N where E.id_empleados_pk = N.id_empleados_pk and N.id_empleados_pk = '" + id_empleados_pk1 + "';";
            Query.Connection = Conexion;
            consultar = Query.ExecuteReader();

            while (consultar.Read())
            {
                dgv_datos_emp.Rows.Add(1);
                if (cont1 == 0)
                {
                    id_devengos_pk = consultar.GetString(0);
                    nombre_dev = consultar.GetString(1);
                    detalle_dev = consultar.GetString(2);
                    cantidad_debengado = consultar.GetString(3);

                    dgv_datos_emp.Rows[0].Cells[0].Value = id_devengos_pk;
                    dgv_datos_emp.Rows[0].Cells[1].Value = nombre_dev;
                    // MessageBox.Show(Convert.ToString(id));
                }
                else
                {
                    dgv_datos_emp.Rows[0].Cells[0].Value = id_devengos_pk;
                    dgv_datos_emp.Rows[0].Cells[1].Value = nombre_dev;
                }
                cont1++;
            }
            

        }



        private void txt_nom_empresa_nom2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
