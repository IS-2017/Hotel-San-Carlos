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

namespace Modulo_Bancos
{
    public partial class Buscar_Cheque : Form
    {
        public Buscar_Cheque()
        {
            InitializeComponent();
        }
        CapaNegocio fn = new CapaNegocio();
        private void Buscar_Cheque_Load(object sender, EventArgs e)
        {

        }
       
        int id2 = 0;
        string cadena1;
        string cadena2;
        string cadena3;
        string cadena4;
        string cadena5;
        //string cadena6;
        public void emplea()
        {

            int id = 0;
            OdbcCommand Query = new OdbcCommand();
            OdbcConnection Conexion;
            OdbcDataReader consultar;
            string sql = "dsn=hotelsancarlos;server=localhost;user id=root;database=hotelsancarlos;password=";
            Conexion = new OdbcConnection();
            Conexion.ConnectionString = sql;
            Conexion.Open();
            Query.CommandText = "SELECT id_documento_pk From documento;";
            Query.Connection = Conexion;
            consultar = Query.ExecuteReader();
            while (consultar.Read())
            {
                
                id = consultar.GetInt32(0);
               // MessageBox.Show(Convert.ToString(id));
                
                documentos(id);

                
               
            }
            id = 0;
        }
        int cont = 0;
        public void documentos(int id)
        {

           
            
            OdbcCommand Query = new OdbcCommand();
            OdbcConnection Conexion;
            OdbcDataReader consultar;
            string sql = "dsn=hotelsancarlos;server=localhost;user id=root;database=hotelsancarlos;password=";
            Conexion = new OdbcConnection();
            Conexion.ConnectionString = sql;
            Conexion.Open();
            Query.CommandText = "SELECT DISTINCT D.id_documento_pk, E.nombre, C.no_cuenta, D.no_documento, D.descripcion, D.valor_total FROM empresa E, cuenta_bancaria C, documento D, detalle_documentos DD WHERE(D.id_cuenta_bancaria_pk = C.id_cuenta_bancaria_pk AND E.id_empresa_pk = C.id_empresa_pk AND DD.id_documento_pk = D.id_documento_pk AND DD.id_documento_pk = " + id+");";
            Query.Connection = Conexion;
            consultar = Query.ExecuteReader();
            while (consultar.Read())
            {
                
                if (cont == 0)
                {
                    dataGridView1.Rows.Add(1);
                    id2 = consultar.GetInt32(0);
                    //MessageBox.Show("Cadena5" + Convert.ToInt32(id2) + "");
                    cadena1 = consultar.GetString(1);
                    cadena2 = consultar.GetString(2);
                    cadena3 = consultar.GetString(3);
                    cadena4 = consultar.GetString(4);
                    cadena5 = consultar.GetString(5);
                    //cadena6 = consultar.GetString(6);
                    dataGridView1.Rows[0].Cells[0].Value = id2;
                    dataGridView1.Rows[0].Cells[1].Value = cadena1;
                    dataGridView1.Rows[0].Cells[2].Value = cadena2;
                    dataGridView1.Rows[0].Cells[3].Value = cadena3;
                    dataGridView1.Rows[0].Cells[4].Value = cadena4;
                    dataGridView1.Rows[0].Cells[5].Value = cadena5;
                   // dataGridView1.Rows[0].Cells[6].Value = cadena6;
                    // dataGridView1.Rows[0].Cells[1].Value = cadena1;
                    //cadena1 = consultar.GetString(1);
                }
                else
                {

                    
                    
                    //Convert.ToInt32(id2);
                    //MessageBox.Show("Cadena6 " + Convert.ToInt32(id2) + "");
                    if (consultar.IsDBNull(0) )
                    {
                        MessageBox.Show(".l.");
                        return;
                    }
                    else
                    {
                       
                        dataGridView1.Rows.Add(1);
                        id2 = consultar.GetInt32(0);
                        //MessageBox.Show("Cadena6 " + Convert.ToInt32(id2) + "");
                        cadena1 = consultar.GetString(1);
                        cadena2 = consultar.GetString(2);
                        cadena3 = consultar.GetString(3);
                        cadena4 = consultar.GetString(4);
                        cadena5 = consultar.GetString(5);
                        //cadena6 = consultar.GetString(6);
                        dataGridView1.Rows[cont].Cells[0].Value = id2;
                        dataGridView1.Rows[cont].Cells[1].Value = cadena1;
                        dataGridView1.Rows[cont].Cells[2].Value = cadena2;
                        dataGridView1.Rows[cont].Cells[3].Value = cadena3;
                        dataGridView1.Rows[cont].Cells[4].Value = cadena4;
                        dataGridView1.Rows[cont].Cells[5].Value = cadena5;
                        //dataGridView1.Rows[cont].Cells[6].Value = cadena6;
                        
                    }
                }
                //string tabla = "documento";
                //fn.ActualizarGrid(this.dataGridView1,"", tabla)
                // MessageBox.Show(Convert.ToString(id));
                cont = cont +1;
                //MessageBox.Show("Contador '"+Convert.ToString(cont)+"'");
            }
            
        }
        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            emplea();
            id2 = 1;
            cont = 0;
            
            //documentos();
            //string tabla = "documento";
            //fn.ActualizarGrid(this.dataGridView1, "SELECT D.id_documento_pk, E.nombre, C.no_cuenta, D.no_documento, D.descripcion, D.valor_total FROM empresa E, cuenta_bancaria C, documento D WHERE (D.id_cuenta_bancaria_pk = C.id_cuenta_bancaria_pk AND E.id_empresa_pk = C.id_empresa_pk);", tabla);
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            Cheque_Voucher a = new Cheque_Voucher(dataGridView1);
            a.MdiParent = this.ParentForm;
            a.Show();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            Cheque_Voucher a = new Cheque_Voucher(dataGridView1);
            a.MdiParent = this.ParentForm;
            a.Show();
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            fn.Anterior(dataGridView1) ;
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            fn.Siguiente(dataGridView1);
        }

        private void btn_primero_Click(object sender, EventArgs e)
        {
            fn.Primero(dataGridView1);
        }

        private void btn_ultimo_Click(object sender, EventArgs e)
        {
            fn.Ultimo(dataGridView1);
        }
    }
}
