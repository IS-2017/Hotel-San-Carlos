using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using MySql.Data.MySqlClient;
using System.Data.Odbc;
using seguridad;

namespace cuentas_corrientes
{
    public partial class frmRegistroContribuyente : Form
    {
        public frmRegistroContribuyente()
        {
            InitializeComponent();
        }

        public void mostrar()
        {
            /*MySqlConnection conexion = cls_bdcomun.ObtenerConexion();
            MySqlDataAdapter dausuario = new MySqlDataAdapter("SELECT * FROM contribuyente", conexion);
            DataSet dsuario = new DataSet();
            dausuario.Fill(dsuario, "contribuyente");
            dgv_clientes.DataSource = dsuario;
            dgv_clientes.DataMember = "contribuyente";*/
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_nombre.Text))
                    MessageBox.Show("Campo obligatorio vacío", "Campo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {

                    cls_contribuye tc = new cls_contribuye();
                    tc.nombre = txt_nombre.Text.Trim();
                    tc.nit = txt_nit.Text.Trim();

                    int iresultado = clsOcontri.Agregar(tc);
                    if (iresultado > 0)
                    {
                        MessageBox.Show("Proyecto Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("No se pudo guardar el proyecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            //mostrar();
        }

        private void frmRegistroContribuyente_Load(object sender, EventArgs e)
        {
            btn_del.Enabled = false;
            btn_mod.Enabled = false;
            btn_save.Enabled = false;
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            btn_del.Enabled = true;
            btn_mod.Enabled = true;
            btn_save.Enabled = true;
        }
    }
}
