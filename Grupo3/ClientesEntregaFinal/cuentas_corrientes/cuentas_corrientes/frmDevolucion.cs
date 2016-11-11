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
    public partial class frmDevolucion : Form
    {

        public frmDevolucion()
        {
            //llenar_encabezado();
            InitializeComponent();
           //tn_editar.Enabled = false;
            btn_eliminar.Enabled = false;
            btn_nuevo.Enabled = true;
            txt_nombre.Enabled = false;
            txt_nit.Enabled = false;
            txt_dir.Enabled = false;
            dpic_fecven.Enabled = false;
            cbo_empre.Enabled = false;
            cbo_factura.Enabled = false;
            txt_serie.Enabled = false;
            txt_mot.Enabled = false;
            txt_prod.Enabled = false;
            txt_tot.Enabled = false;
            txt_cant.Enabled = false;
            btn_busprod.Enabled = false;
            btn_Buscte.Enabled = false;
            btn_agregprod.Enabled = false;
            llenar_encabezado();
        }
        public ClsDevo devAct { get; set; } 
        public frmDevolucion(ClsDevo dev)
        {
            InitializeComponent();

            /*OdbcConnection conectar = seguridad.Conexion.ObtenerConexionODBC();
            clsComun emp = new clsComun();
            OdbcCommand _comando = new OdbcCommand(String.Format("SELECT nombre FROM empresa where id_empresa_pk ='{0}' ",fact.cod_emp), conectar);
            OdbcDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {

                emp.nombre= _reader.GetString(0); //Id empresa
            }
            conectar.Close();
            cbo_empre.Text = emp.nombre;
            cbo_factura.Text = Convert.ToString(fact.cod_imp);
            cbo_factura.Enabled = false;
            txt_serie.Text = fact.serie;
            txt_serie.Enabled = false;
            txt_tot.Enabled = false;
            txt_prod.Enabled = false;
            txt_cant.Enabled = false;
            btn_Buscte.Enabled = false;
            txt_mot.Text = fact.estado_fact;
            dpic_fecven.Text = fact.fec_emision;
            txt_tot.Text = Convert.ToString(fact.total);


            OdbcConnection conectar1 = seguridad.Conexion.ObtenerConexionODBC();
            cls_cliente cte = new cls_cliente();
            OdbcCommand _comando1 = new OdbcCommand(String.Format(
                 "SELECT nombre, apellido, nit, direccion FROM cliente where id_cliente_pk ='{0}' ", fact.cod_cte), conectar1);
            OdbcDataReader _reader1 = _comando1.ExecuteReader();
            while (_reader1.Read())
            {

                cte.nombre = _reader1.GetString(0); //Id empresa
                cte.apellido = _reader1.GetString(1);
                cte.nit = _reader1.GetString(2);
                cte.dire = _reader1.GetString(3);
            }
            cbo_empre.Enabled = false;
            // MessageBox.Show(Convert.ToString(fact.cod_emp));
            txt_nombre.Text = cte.nombre + " " + cte.apellido;
            txt_nit.Text = cte.nit;
            txt_dir.Text = cte.dire;
            txt_dir.Enabled = false;
            txt_nit.Enabled = false;
            txt_nombre.Enabled = false;

            dgv_detalledev.DataSource = Cls_OpDevo.BuscarDetDev(fact.cod_fact);
            txt_mot.Enabled = false;
            //llenar_encabezado();
            */

            try
            {

                if (dev != null)
                {

                    devAct = dev;
                    OdbcConnection conectar = seguridad.Conexion.ObtenerConexionODBC();
                    clsComun emp = new clsComun();
                    OdbcCommand _comando = new OdbcCommand(String.Format("SELECT nombre FROM empresa where id_empresa_pk ='{0}' ", dev.cod_emp), conectar);
                    OdbcDataReader _reader = _comando.ExecuteReader();
                    while (_reader.Read())
                    {

                        emp.nombre = _reader.GetString(0); //Id empresa
                    }
                    conectar.Close();
                    cbo_empre.Text = emp.nombre;
                    cbo_factura.Text = Convert.ToString(dev.cod_fact);
                    cbo_factura.Enabled = false;
                    txt_serie.Text = dev.serie;
                    txt_serie.Enabled = false;
                    txt_tot.Enabled = false;
                    txt_prod.Enabled = false;
                    txt_cant.Enabled = false;
                    btn_Buscte.Enabled = false;
                    txt_mot.Text = dev.motivo;
                    dpic_fecven.Text = dev.fec_emision;
                    txt_tot.Text = Convert.ToString(dev.total);

                   
                    OdbcConnection conectar1 = seguridad.Conexion.ObtenerConexionODBC();
                    cls_cliente cte = new cls_cliente();
                    OdbcCommand _comando1 = new OdbcCommand(String.Format(
                         "SELECT nombre, apellido, nit, direccion FROM cliente where id_cliente_pk ='{0}' ", dev.cod_cte), conectar1);
                    OdbcDataReader _reader1 = _comando1.ExecuteReader();
                    while (_reader1.Read())
                    {

                        cte.nombre = _reader1.GetString(0); //Id empresa
                        cte.apellido = _reader1.GetString(1);
                        cte.nit = _reader1.GetString(2);
                        cte.dire = _reader1.GetString(3);
                    }
                    cbo_empre.Enabled = false;
                    // MessageBox.Show(Convert.ToString(fact.cod_emp));
                    txt_nombre.Text = cte.nombre + " " + cte.apellido;
                    txt_nit.Text = cte.nit;
                    txt_dir.Text = cte.dire;
                    txt_dir.Enabled = false;
                    txt_nit.Enabled = false;
                    txt_nombre.Enabled = false;


                    dgv_detalledev.DataSource = Cls_OpDevo.BuscarDetDev(devAct.id_dev);

                    //cod_fact, cod_emp, serie

                    txt_mot.Enabled = false;


                    btn_nuevo.Enabled = false;
                    btn_guardar.Enabled = false;
                    btn_eliminar.Enabled = true;
                    //n_editar.Enabled = true;
                    btn_cancelar.Enabled = true;
                    btn_nuevo.Enabled = true;
                    //btn_mosdet.Enabled = true;
                    // MessageBox.Show("paso");
                }
                else
                {
                   
                        btn_nuevo.Enabled = false;
                        btn_guardar.Enabled = false;
                        btn_eliminar.Enabled = false;
                      //btn_editar.Enabled = false;
                        btn_cancelar.Enabled = false;
                        btn_Buscte.Enabled = true;
                        //btn_mosdet.Visible = false;
                    cbo_factura.Text = "";
                    

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
            

        public cls_cliente cldes { get; set; }
        private void btn_Buscte_Click(object sender, EventArgs e)
        {
            try
            {
                frmbuscliente buscl = new frmbuscliente();
                buscl.ShowDialog();
               // llenar_encabezado();


                if (buscl.descl != null)
                {
                    cldes = buscl.descl;
                    txt_nombre.Text = buscl.descl.nombre + " " + buscl.descl.apellido;

                    txt_nit.Text = buscl.descl.nit;
                    txt_dir.Text = buscl.descl.dire;
                    MessageBox.Show(Convert.ToString(cldes.cod));

                    cbo_empre.Enabled = true;
                    string scad1 = "select * from empresa";
                    DataTable dt1 = new DataTable();
                    OdbcCommand mcd1 = new OdbcCommand(scad1, seguridad.Conexion.ObtenerConexionODBC());
                    OdbcDataAdapter da1 = new OdbcDataAdapter(mcd1);
                    da1.Fill(dt1);

                    if (dt1.Rows.Count != 0)
                    {
                        cbo_empre.DataSource = dt1;
                        cbo_empre.DisplayMember = "nombre";
                        cbo_empre.ValueMember = "nombre";
                    }



                  


             


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmDevolucion_Load(object sender, EventArgs e)
        {
           
            //btn_mosdet.Enabled = false;
           
        }

        private void cbo_empre_SelectedIndexChanged(object sender, EventArgs e)
        {
            OdbcConnection conectar = seguridad.Conexion.ObtenerConexionODBC();
            clsComun emp = new clsComun();
            OdbcCommand _comando = new OdbcCommand(String.Format(
                 "SELECT id_empresa_pk FROM empresa where nombre ='{0}' ", cbo_empre.Text), conectar);
            OdbcDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {

                emp.cod = _reader.GetInt16(0); //Id empresa
            }
            conectar.Close();

            cbo_factura.Enabled = true;
            string scad2 = "select * from factura where id_empresa_pk=" + emp.cod + "and id_cliente_pk=1";
            //string scad2 = "select * from factura where id_empresa_pk=1 and id_cliente_pk=1";

            OdbcCommand _coman = new OdbcCommand(String.Format(
                "SELECT * FROM factura where id_empresa_pk ='{0}' and id_cliente_pk='{1}'", emp.cod, cldes.cod), conectar);
            DataTable dt2 = new DataTable();
            // OdbcCommand mcd2 = new OdbcCommand(scad2, seguridad.Conexion.ObtenerConexionODBC());
            OdbcDataAdapter da2 = new OdbcDataAdapter(_coman);
            da2.Fill(dt2);

            if (dt2.Rows.Count != 0)
            {
                cbo_factura.DataSource = dt2;
                cbo_factura.DisplayMember = "id_fac_empresa_pk";
                cbo_factura.ValueMember = "id_fac_empresa_pk";
            }


        }

        private void cbo_factura_SelectedIndexChanged(object sender, EventArgs e)
        {
            OdbcConnection conectar = seguridad.Conexion.ObtenerConexionODBC();
            clsComun emp = new clsComun();
            OdbcCommand _comando = new OdbcCommand(String.Format(
                 "SELECT serie FROM factura where id_fac_empresa_pk ='{0}' ", cbo_factura.Text), conectar);
            OdbcDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {

                txt_serie.Text= _reader.GetString(0); //Id empresa
            }
            conectar.Close();
            btn_busprod.Enabled = true;


        }

        private void txt_serie_TextChanged(object sender, EventArgs e)
        {

        }
        public ClsDetalleFact DetAct { get; set; }
        private void btn_busprod_Click(object sender, EventArgs e)
        {
            try
            {
                ClsFactura fact = new ClsFactura();
                fact.cod_fact = Convert.ToInt16(cbo_factura.Text);
                frmBuscProdDev temp = new frmBuscProdDev(fact);

                temp.ShowDialog();

                if (temp.DetSelec != null)
                {
                    DetAct = temp.DetSelec;
                    txt_prod.Text = DetAct.descripcion;
                    txt_cant.Text = Convert.ToString(DetAct.cantidad);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }




        public void llenar_encabezado()
        {
            DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
            c1.HeaderText = "Codigo";
            c1.Width = 100;
            c1.ReadOnly = true;

            dgv_detalledev.Columns.Add(c1);

            DataGridViewTextBoxColumn c2 = new DataGridViewTextBoxColumn();
            c2.HeaderText = "Cantidad";
            c2.Width = 50;
            c2.ReadOnly = true;

            dgv_detalledev.Columns.Add(c2);

            DataGridViewTextBoxColumn c3 = new DataGridViewTextBoxColumn();
            c3.HeaderText = "Nombre";
            c3.Width = 50;
            c3.ReadOnly = true;

            dgv_detalledev.Columns.Add(c3);

            DataGridViewTextBoxColumn c4 = new DataGridViewTextBoxColumn();
            c4.HeaderText = "Precio";
            c4.Width = 50;
            c4.ReadOnly = true;

            dgv_detalledev.Columns.Add(c4);

            DataGridViewTextBoxColumn c5 = new DataGridViewTextBoxColumn();
            c5.HeaderText = "Subtotal";
            c5.Width = 50;
            c5.ReadOnly = true;

            dgv_detalledev.Columns.Add(c5);

       
        }





        private void btn_agregprod_Click(object sender, EventArgs e)
        {
            int sub = (Convert.ToInt16(txt_cant.Text)) * DetAct.prec;

            
            dgv_detalledev.Rows.Add(DetAct.cod_bien, txt_cant.Text, txt_prod.Text, DetAct.prec, sub);

            int filas = dgv_detalledev.RowCount;
            decimal tot = 0;
            for (int f = 0; f < filas; f++)
            {
                tot += Convert.ToDecimal(dgv_detalledev.Rows[f].Cells[4].Value);

            }
            txt_tot.Text = Convert.ToString(tot);
           

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbo_empre.Text) || string.IsNullOrWhiteSpace(txt_nombre.Text) || string.IsNullOrWhiteSpace(cbo_factura.Text))
                MessageBox.Show("Campo obligatorio vacío", "Campo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {

                ClsDevo fact = new ClsDevo();

                //Obteniendo Id de empresa
                OdbcConnection conectar = seguridad.Conexion.ObtenerConexionODBC();
                clsComun emp = new clsComun();
                OdbcCommand _comando = new OdbcCommand(String.Format(
                     "SELECT id_empresa_pk FROM empresa where nombre ='{0}' ", cbo_empre.Text), conectar);
                OdbcDataReader _reader = _comando.ExecuteReader();
                while (_reader.Read())
                {

                    fact.cod_emp = _reader.GetInt16(0); //Id empresa
                }
                conectar.Close();

                fact.serie = txt_serie.Text; //Serie

                fact.cod_fact = Convert.ToInt16(cbo_factura.Text);
                fact.fec_emision = dpic_fecven.Text; //Fecha vencimiento;
                
                fact.motivo = txt_mot.Text; //Estado de factura
               // MessageBox.Show(fact.motivo);
               // MessageBox.Show(fact.fec_emision);
                
                fact.total = Convert.ToDecimal(txt_tot.Text); //Total
                fact.cod_cte = cldes.cod; //Id del cliente





                int iresultado = Cls_OpDevo.AgregarDevo(fact); //Enviando a facturar encabezado
                if (iresultado > 0)
                {
                    MessageBox.Show("Encabezado de factura guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //dgv_detalledev.Rows.Remove(dgv_detalledev.Rows[dgv_detalledev.Rows.Count - 1]);
                    //Insertando en detalle de factura 
                    int filas = dgv_detalledev.RowCount;


                    //Obteniendo el ultimo Id de insertar, para insertar detalle_Fact
                    OdbcConnection conectar3 = seguridad.Conexion.ObtenerConexionODBC();
                    clsComun imp3 = new clsComun();
                    OdbcCommand _comando3 = new OdbcCommand(String.Format(
                         "SELECT MAX(id_dev) from devolucion_venta "), conectar3);
                    OdbcDataReader _reader3 = _comando3.ExecuteReader();
                    while (_reader3.Read())
                    {

                        imp3.cod = _reader3.GetInt16(0); //Id impuestp
                    }
                    conectar3.Close();

                    //Codigo para recorrer grid e insertar a detalle factura

                    for (int f = 0; f < filas; f++)
                    {


                        ClsDetalleFact defact = new ClsDetalleFact();
                        defact.cod_fact = imp3.cod;
                        //defact.cod_emp = fact.cod_emp;
                        //defact.serie = fact.serie;
                        defact.cod_bien = Convert.ToInt16(dgv_detalledev.Rows[f].Cells[0].Value);
                        defact.cantidad = Convert.ToInt16(dgv_detalledev.Rows[f].Cells[1].Value);
                        //MessageBox.Show(Convert.ToString(defact.cantidad));
                        defact.descripcion = Convert.ToString(dgv_detalledev.Rows[f].Cells[2].Value);
                        defact.prec = Convert.ToInt16(dgv_detalledev.Rows[f].Cells[3].Value);
                        defact.subtotal = Convert.ToInt16(dgv_detalledev.Rows[f].Cells[4].Value);

                        int iresultado1 = Cls_OpDevo.AgregarDetDev(defact);
                        if (iresultado1 > 0)
                        {
                            MessageBox.Show("Detalle insertado correctamente");



                        }
                        else
                        {
                            MessageBox.Show("No se inserto detalle");
                        }


                    }


                  
                    
                    btn_nuevo.Enabled = true;
                    txt_nombre.Clear();
                    txt_dir.Clear();
                    txt_nit.Clear();
                    dpic_fecven.Text = "";
                    cbo_empre.Text = "";
                    cbo_factura.Text = "";
                    txt_serie.Text = "";
                    txt_mot.Clear();
                    txt_prod.Clear();
                    txt_cant.Clear();
                    btn_agregprod.Enabled = false;
                    btn_busprod.Enabled = false;
                    txt_tot.Clear();

                   
                    dgv_detalledev.Rows.Clear();
                    dgv_detalledev.Refresh();

                }

                else
                {
                    MessageBox.Show("No se pudo guardar el encabezado de factura", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }






            }
        }

        private void txt_nit_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            btn_busprod.Enabled = false;
            btn_Buscte.Enabled = true;
            cbo_empre.Enabled = false;
            cbo_factura.Enabled = false;
            txt_serie.Enabled = false;
           // llenar_encabezado();
            txt_nombre.Text = "";
            txt_dir.Text = "";
            txt_nit.Text = "";
            cbo_empre.Text = "";
            cbo_factura.Text = "";
            txt_serie.Text = "";
            txt_mot.Text = "";
            txt_tot.Text = Text = "";
            txt_mot.Enabled = true;
          btn_nuevo.Enabled = false;
            btn_agregprod.Enabled = true;
            txt_cant.Enabled = true;
            dpic_fecven.Enabled = true;
            //dgv_detalledev.DataSource = "";
            //dgv_detalledev.Rows.Clear();
           // dgv_detalledev.Refresh();
            // DataTable dt = (DataTable)dgv_detalledev.DataSource;
            //dt.Clear();
        }

        private void btn_mosdet_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_nombre.Text))
                    MessageBox.Show("Campo obligatorio vacío", "Campo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    

                   
                    
                    int iresultado = Cls_OpDevo.EliminarEncabeDevo(devAct.id_dev);
                    int re = Cls_OpDevo.EliminarDetalleDevo(devAct.id_dev);
                    if (iresultado > 0)
                    {
                        MessageBox.Show("Devolucion Eliminado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar la devolucion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
