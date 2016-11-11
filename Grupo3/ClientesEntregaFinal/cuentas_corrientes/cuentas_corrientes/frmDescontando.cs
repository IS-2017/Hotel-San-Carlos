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

namespace cuentas_corrientes
{
    public partial class frmDescontando : Form
    {
        public frmDescontando(int idbien, int cant)
        {
            InitializeComponent();
            bien = idbien;
            cant2 = cant;
        }
        static int bien;
        static int cant2;
        public static int idbod;

        private void frmDescontando_Load(object sender, EventArgs e)
        {
            cbo_bodega.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_bodega.Items.Clear();
            string scad = "select bodega.nombre_bodega, bodega.id_bodega_pk from bodega inner join producto_bodega on bodega.id_bodega_pk = producto_bodega.id_bodega_pk and producto_bodega.id_bien_pk = " + bien + " and producto_bodega.id_categoria_pk = 'PT' and producto_bodega.existencia >= " + cant2;
            OdbcCommand mcd = new OdbcCommand(scad, seguridad.Conexion.ObtenerConexionODBC());
            OdbcDataReader mdr = mcd.ExecuteReader();

            while (mdr.Read())
            {

                cbo_bodega.Items.Add(mdr.GetString(0));
                idbod = mdr.GetInt16(1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                cbo_bodega.Items.Clear();
                string scad = "select bodega.nombre_bodega, bodega.id_bodega_pk from bodega inner join producto_bodega on bodega.id_bodega_pk = producto_bodega.id_bodega_pk and producto_bodega.id_bien_pk = " + bien + " and producto_bodega.id_categoria_pk = 'PT' and producto_bodega.existencia >= " + cant2;
                OdbcCommand mcd = new OdbcCommand(scad, seguridad.Conexion.ObtenerConexionODBC());
                OdbcDataReader mdr = mcd.ExecuteReader();

                while (mdr.Read())
                {

                    cbo_bodega.Items.Add(mdr.GetString(0));
                    idbod = mdr.GetInt16(1);
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_descontar_Click(object sender, EventArgs e)
        {
            try
            {
                cbo_bodega.Items.Clear();
                string scad = "select id_bodega_pk from bodega where nombre_bodega = '" + cbo_bodega.Text + "'";
                OdbcCommand mcd = new OdbcCommand(scad, seguridad.Conexion.ObtenerConexionODBC());
                OdbcDataReader mdr = mcd.ExecuteReader();

                if (mdr.Read())
                {

                    idbod = mdr.GetInt32(0);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


            this.Close();
        }
    }
}
