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
using CrystalDecisions.CrystalReports.Engine;

namespace Modulo_Bancos
{
    public partial class Kardex_Bancos : Form
    {
        decimal dato, valor, debe, haber, saldo;
        int cont1 = 0;
        string nombre_documento,conciliado,destinatario,nombre_cuenta,fecha;

        private void Kardex_Bancos_Load(object sender, EventArgs e)
        {

        }

        public Kardex_Bancos()
        {
            InitializeComponent();
        }

        private void btn_generar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            dato = 0; valor = 0; debe = 0; haber = 0; saldo = 0; cont1 = 0;
            string nombre_documento="", conciliado = "", destinatario = "", nombre_cuenta = "", fecha = "";
            if(dateTimePicker1.Value <= dateTimePicker2.Value)
            {
                PrimeraSuma();
                LlenarDatos();
                UltimoSaldo();
                reporte();
            }
            else
            {
                MessageBox.Show("La fecha de inicio del periodo debe ser menor a la fecha de finalizacion", "Favor corregir fecha de inicio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void PrimeraSuma()
        {
            Ayuda.ObtenerConexion();
            OdbcDataReader consultar;
            string Query1 = "select sum(DE.debe), SUM(DE.haber), SUM(DE.haber) - sum(DE.debe) from documento D, detalle_documentos DE WHERE D.id_documento_pk = DE.id_documento_pk AND DE.fecha < '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' AND D.estado = 'Activo' AND DE.estado = 'Activo';";
            OdbcCommand Query = new OdbcCommand(Query1, Ayuda.ObtenerConexion());
            consultar = Query.ExecuteReader();
            consultar.Read();
            if ((consultar.IsDBNull(0)) || (consultar.IsDBNull(1)) || (consultar.IsDBNull(2)))
            {
                MessageBox.Show("No existen documentos antes de la fecha inicial propuesta", "Favor corregir fecha de inicio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dato = consultar.GetDecimal(2);
                dataGridView1.Rows.Add(1);
                dataGridView1.Rows[0].Cells[0].Value = "Saldo Anterior";
                dataGridView1.Rows[0].Cells[1].Value = "----";
                dataGridView1.Rows[0].Cells[2].Value = "----";
                dataGridView1.Rows[0].Cells[3].Value = "----";
                dataGridView1.Rows[0].Cells[4].Value = "----";
                dataGridView1.Rows[0].Cells[5].Value = "----";
                dataGridView1.Rows[0].Cells[6].Value = "----";
                dataGridView1.Rows[0].Cells[7].Value = "----";
                dataGridView1.Rows[0].Cells[8].Value = dato;
                cont1++;
            }
            Ayuda.Desconectar();
        }

        private void LlenarDatos()
        {
            Ayuda.ObtenerConexion();
            OdbcDataReader consultar;
            string Query1 = "SELECT tipo_documento.nombre_documento, documento.conciliado, documento.valor_total, documento.destinatario, detalle_documentos.nombre_cuenta,detalle_documentos.fecha, detalle_documentos.debe, detalle_documentos.haber FROM detalle_documentos, documento, tipo_documento WHERE documento.id_documento_pk = detalle_documentos.id_documento_pk AND tipo_documento.id_tipo_documento = documento.id_tipo_documento AND (detalle_documentos.fecha BETWEEN '"+dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' AND '"+dateTimePicker2.Value.ToString("yyyy-MM-dd") + "') AND documento.estado = 'ACTIVO' AND detalle_documentos.estado = 'ACTIVO';";
            OdbcCommand Query = new OdbcCommand(Query1, Ayuda.ObtenerConexion());
            saldo = dato;
            consultar = Query.ExecuteReader();
            while (consultar.Read())
            {
                dataGridView1.Rows.Add(1);
                nombre_documento = consultar.GetString(0);
                conciliado = consultar.GetString(1);
                valor = consultar.GetDecimal(2);
                destinatario = consultar.GetString(3);
                nombre_cuenta = consultar.GetString(4);
                fecha = consultar.GetString(5);
                debe = consultar.GetDecimal(6);
                haber = consultar.GetDecimal(7);
                saldo = saldo + haber - debe;

                dataGridView1.Rows[cont1].Cells[0].Value = nombre_documento;
                dataGridView1.Rows[cont1].Cells[1].Value = conciliado;
                dataGridView1.Rows[cont1].Cells[2].Value = valor;
                dataGridView1.Rows[cont1].Cells[3].Value = destinatario;
                dataGridView1.Rows[cont1].Cells[4].Value = nombre_cuenta;
                dataGridView1.Rows[cont1].Cells[5].Value = fecha;
                dataGridView1.Rows[cont1].Cells[6].Value = debe;
                dataGridView1.Rows[cont1].Cells[7].Value = haber;
                dataGridView1.Rows[cont1].Cells[8].Value = saldo;
                if (saldo > 0)
                {
                    dataGridView1.Rows[cont1].Cells[8].Style.BackColor = Color.Green;
                }
                else
                {
                    dataGridView1.Rows[cont1].Cells[8].Style.BackColor = Color.Red;
                }
                cont1++;
                //saldo;
            }
        }
        public void reporte()
        {
            Kardex Ds = new Kardex();
            int filas = dataGridView1.Rows.Count;

            for (int i = 0; i < filas - 1; i++)
            {
                Ds.Tables[0].Rows.Add(new object[] {
                    dataGridView1[0,i].Value.ToString(),
                    dataGridView1[1,i].Value.ToString(),
                    dataGridView1[2,i].Value.ToString(),
                    dataGridView1[3,i].Value.ToString(),
                    dataGridView1[4,i].Value.ToString(),
                    dataGridView1[5,i].Value.ToString(),
                    dataGridView1[6,i].Value.ToString(),
                    dataGridView1[7,i].Value.ToString(),
                    dataGridView1[8,i].Value.ToString()
                });

                ReportDocument cRep = new ReportDocument();
                //cRep.Load("C:/Users/Cristian/Desktop/asis12/Navegador/RRHH Nuevo/Prototipo -RRHH/Prototipo -RRHH/CrystalReport1.rpt");
                string file = Application.StartupPath + "\\KardexDocumentos.rpt";
                //MessageBox.Show(file);
                cRep.Load(file);
                cRep.SetDataSource(Ds);
                crystalReportViewer1.ReportSource = cRep;

            }
        }
        private void UltimoSaldo()
        {
            dataGridView1.Rows.Add(1);
            dataGridView1.Rows[cont1].Cells[0].Value = "Saldo Actual ";
            dataGridView1.Rows[cont1].Cells[1].Value = "----";
            dataGridView1.Rows[cont1].Cells[2].Value = "----";
            dataGridView1.Rows[cont1].Cells[3].Value = "----";
            dataGridView1.Rows[cont1].Cells[4].Value = "----";
            dataGridView1.Rows[cont1].Cells[5].Value = "----";
            dataGridView1.Rows[cont1].Cells[6].Value = "----";
            dataGridView1.Rows[cont1].Cells[7].Value = "----";
            dataGridView1.Rows[cont1].Cells[8].Value = saldo;
        }
    }
}
