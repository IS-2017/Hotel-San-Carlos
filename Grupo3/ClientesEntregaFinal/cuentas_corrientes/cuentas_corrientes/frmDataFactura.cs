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
using seguridad;
//using Abrir;

namespace cuentas_corrientes
{
    public partial class frmDataFactura : Form
    {
        public frmDataFactura()
        {
            InitializeComponent();
           
            OdbcConnection conexion = seguridad.Conexion.ObtenerConexionODBC();
            OdbcDataAdapter dausuario = new OdbcDataAdapter(" SELECT factura.id_fac_empresa_pk, empresa.nombre, factura.serie, cliente.nombre, cliente.apellido,factura.fecha_emision, factura.fecha_vencimiento, empleado.nombre ,factura.subtotal, factura.id_impuesto_pk, factura.total from factura, empresa, cliente, empleado where factura.estado='activo' and empresa.id_empresa_pk=factura.id_empresa_pk and cliente.id_cliente_pk=factura.id_cliente_pk and empleado.id_empleados_pk =factura.id_empleados_pk", conexion);
            DataSet dsuario = new DataSet();
            dausuario.Fill(dsuario, "factura");
            dgv_fact.DataSource = dsuario;
            dgv_fact.DataMember = "factura";
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            frmFactura temp = new frmFactura();
            temp.ShowDialog();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            dllconsultas.operaciones op = new dllconsultas.operaciones();
            op.ejecutar(dgv_fact, "factura");
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            OdbcConnection conexion = seguridad.Conexion.ObtenerConexionODBC();
            OdbcDataAdapter dausuario = new OdbcDataAdapter(" SELECT factura.id_fac_empresa_pk, empresa.nombre, factura.serie, cliente.nombre, cliente.apellido,factura.fecha_emision, factura.fecha_vencimiento, empleado.nombre ,factura.subtotal, factura.id_impuesto_pk, factura.total from factura, empresa, cliente, empleado where factura.estado='activo' and empresa.id_empresa_pk=factura.id_empresa_pk and cliente.id_cliente_pk=factura.id_cliente_pk and empleado.id_empleados_pk =factura.id_empleados_pk", conexion);
            DataSet dsuario = new DataSet();
            dausuario.Fill(dsuario, "factura");
            dgv_fact.DataSource = dsuario;
            dgv_fact.DataMember = "factura";
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dgv_fact_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt16(dgv_fact.CurrentRow.Cells[0].Value);
            string emp = Convert.ToString(dgv_fact.CurrentRow.Cells[1].Value);
            string serie = Convert.ToString(dgv_fact.CurrentRow.Cells[2].Value);
            string nom = Convert.ToString(dgv_fact.CurrentRow.Cells[3].Value);
            string ape = Convert.ToString(dgv_fact.CurrentRow.Cells[4].Value);
            string fec_emi = Convert.ToString(dgv_fact.CurrentRow.Cells[5].Value);
            string fec_ven = Convert.ToString(dgv_fact.CurrentRow.Cells[6].Value);
            string nom_emp = Convert.ToString(dgv_fact.CurrentRow.Cells[7].Value);
            decimal tot = Convert.ToDecimal(dgv_fact.CurrentRow.Cells[8].Value);
            decimal imp = Convert.ToDecimal(dgv_fact.CurrentRow.Cells[9].Value);
            decimal subtot = Convert.ToDecimal(dgv_fact.CurrentRow.Cells[10].Value);

            frmFactura fact = new frmFactura(id, emp, serie, nom, ape, fec_emi, fec_ven, nom_emp, tot, imp, subtot);
            fact.ShowDialog();
        }

        private void btn_reporte_Click(object sender, EventArgs e)
        {
            /*Abrir.Form1 abrir = new Abrir.Form1();
            abrir.Crystal = @"Factura.rpt";
            abrir.Show();*/
        }
    }
}
