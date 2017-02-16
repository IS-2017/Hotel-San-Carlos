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
using CrystalDecisions.CrystalReports.Engine;

namespace Prototipo__RRHH
{
    public partial class Reporte_Planilla_IGSS : Form
    {
        public Reporte_Planilla_IGSS()
        {
            InitializeComponent();
            
        }

        CapaNegocio fn = new CapaNegocio();
        DataSet dataset1;
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
            fn.ActualizarGrid(this.dataGridView1, "SELECT DISTINCT E.id_empresa_pk, E.region, E.nombre, EMP.nombre AS Empleado, EMP.cargo, EMP.sueldo, DP.igss_pagar, DP.fecha  FROM empresa E, planilla_igss P, empleado EMP, detalle_planilla_igss DP WHERE(E.id_empresa_pk = P.id_empresa_pk AND P.id_planilla_igss_pk = DP.id_planilla_igss_pk AND E.id_empresa_pk = '"+selectedItem+"' AND DP.id_empleados_pk = EMP.id_empleados_pk AND DP.fecha = '"+date1+"');",tabla);
            
            reporte();

        }

        private void Reporte_Planilla_IGSS_Load(object sender, EventArgs e)
        {
            llenaridempresa();
            cbo_empres.Enabled = true;
        }
        
        public void reporte()
        {
           // crystalReportViewer1.Refresh();
            DataSet2 Ds = new DataSet2();
            int filas = dataGridView1.Rows.Count;
            for (int i = 0; i < filas - 1; i++)
            {
                Ds.Tables[0].Rows.Add(new object[] {
                    dataGridView1[0,i].Value.ToString(),
                    dataGridView1[1,i].Value.ToString(),
                    dataGridView1[2,i].Value.ToString(),
                    dataGridView1[3,i].Value.ToString(),
                    dataGridView1[4,i].Value.ToString(),
                    Convert.ToDecimal(dataGridView1[5,i].Value),
                    Convert.ToDecimal(dataGridView1[6,i].Value.ToString()),
                    dataGridView1[7,i].Value.ToString()
                });

                ReportDocument cRep = new ReportDocument();
                //cRep.Load("C:/Users/Cristian/Desktop/asis12/Navegador/RRHH Nuevo/Prototipo -RRHH/Prototipo -RRHH/CrystalReport1.rpt");
                string file = Application.StartupPath + "\\reporte_igss.rpt";
                //MessageBox.Show(file);
                cRep.Load(file);
                cRep.SetDataSource(Ds);
                crystalReportViewer1.ReportSource = cRep;
                
            }
           
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
