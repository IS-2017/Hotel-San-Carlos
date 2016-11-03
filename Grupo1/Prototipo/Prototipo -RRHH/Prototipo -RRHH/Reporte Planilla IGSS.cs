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
using System.Data.Odbc;
using MySql.Data.MySqlClient;

namespace Prototipo__RRHH
{
    public partial class Reporte_Planilla_IGSS : Form
    {
        public Reporte_Planilla_IGSS()
        {
            InitializeComponent();
            
        }

        CapaNegocio fn = new CapaNegocio();
        private void llenaridempresa()
        {

            //se realiza la conexión a la base de datos
            Conexionmysql.ObtenerConexion();
            //se inicia un DataSet
            DataSet ds = new DataSet();
            //se indica la consulta en sql
            String Query = "select id_empresa_pk, nombre from empresa";
            OdbcDataAdapter dad = new OdbcDataAdapter(Query, Conexionmysql.ObtenerConexion());
            //se indica con quu tabla se llena
            dad.Fill(ds, "empresa");
            cbo_empres.DataSource = ds.Tables[0].DefaultView;
            //indicamos el valor de los miembros
            cbo_empres.ValueMember = ("id_empresa_pk");
            //se indica el valor a desplegar en el combobox
            cbo_empres.DisplayMember = ("nombre");
            Conexionmysql.Desconectar();

        }

        private void btn_generar_Click(object sender, EventArgs e)
        {
            string tabla = "detalle_planilla_igss";
            string selectedItem = cbo_empres.SelectedValue.ToString();
            string date1 = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            fn.ActualizarGrid(this.dataGridView1, "SELECT DISTINCT E.id_empresa_pk, E.region, E.nombre, EMP.nombre, EMP.cargo, EMP.sueldo, DP.igss_pagar, DP.fecha  FROM empresa E, planilla_igss P, empleado EMP, detalle_planilla_igss DP WHERE(E.id_empresa_pk = P.id_empresa_pk AND P.id_planilla_igss_pk = DP.id_planilla_igss_pk AND E.id_empresa_pk = '"+selectedItem+"' AND DP.id_empleados_pk = EMP.id_empleados_pk AND DP.fecha = '"+date1+"');",tabla);
        }

        private void Reporte_Planilla_IGSS_Load(object sender, EventArgs e)
        {
            llenaridempresa();
            cbo_empres.Enabled = true;
        }
    }
}
