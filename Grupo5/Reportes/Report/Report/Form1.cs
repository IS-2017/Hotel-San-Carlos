using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Report
{
    public partial class Form1 : Form
    {
        DataSet MisDatos = new DataSet();
        public Form1()
        {
            InitializeComponent();
        }

        

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            crystal DataEmp = new crystal();
            Transporta t = new Transporta();
            DataEmp = t.TraspasaDatos(MisDatos);

            FVisor Mivisor = new FVisor(DataEmp);
            Mivisor.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // Añadimos una tabla al Dataset
       MisDatos.Tables.Add("Empleados");

            // Agremos las columnas a la Tabla
            MisDatos.Tables["Empleados"].Columns.Add("ID");
            MisDatos.Tables["Empleados"].Columns.Add("Nombre");
            MisDatos.Tables["Empleados"].Columns.Add("Apellido");
            MisDatos.Tables["Empleados"].Columns.Add("Telefono");


            // Creamos varias filas y se las agregamos al DataSet
            DataRow fila1 = MisDatos.Tables["Empleados"].NewRow();
            fila1["ID"] = "54090909Z";
            fila1["Nombre"] = "Pepe";
            fila1["Apellido"] = "Sanchez Vega";
            fila1["Telefono"] = "928721102";

            DataRow fila2 = MisDatos.Tables["Empleados"].NewRow();
            fila2["ID"] = "33012909Z";
            fila2["Nombre"] = "David";
            fila2["Apellido"] = "Perez Santana";
            fila2["Telefono"] = "928091502";

            DataRow fila3 = MisDatos.Tables["Empleados"].NewRow();
            fila3["ID"] = "10033909Z";
            fila3["Nombre"] = "Maria";
            fila3["Apellido"] = "Hernadez Peñate";
            fila3["Telefono"] = "928512502";

            // Agregamos las filas
            MisDatos.Tables["Empleados"].Rows.Add(fila1);
            MisDatos.Tables["Empleados"].Rows.Add(fila2);
            MisDatos.Tables["Empleados"].Rows.Add(fila3);


            // Rellenamos el nuestro Datagrid
            dgv_reporte.DataSource = MisDatos.Tables["Empleados"];

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
