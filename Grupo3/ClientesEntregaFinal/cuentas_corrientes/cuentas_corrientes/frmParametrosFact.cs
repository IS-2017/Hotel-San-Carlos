using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.Odbc;

namespace cuentas_corrientes
{
    public partial class frmParametrosFact : Form
    {
        public frmParametrosFact(clsParamFact pam)
        {
            InitializeComponent();

            try
            {


                if (pam != null)
                {

                    FmAct = pam;

                    //MessageBox.Show(Convert.ToString(pam.icodmep));
                    OdbcConnection conectar = seguridad.Conexion.ObtenerConexionODBC();
                    clsComun emp = new clsComun();
                    OdbcCommand _comando = new OdbcCommand(String.Format(
                         "SELECT nombre FROM empresa where id_empresa_pk ='{0}' ", pam.icodmep), conectar);
                    OdbcDataReader _reader = _comando.ExecuteReader();
                    while (_reader.Read())
                    {

                        emp.nombre = _reader.GetString(0); //Id empresa
                    }
                    conectar.Close();
                   // MessageBox.Show(emp.nombre);
                    cbo_empre.Text = emp.nombre;

                    OdbcConnection conectar2 = seguridad.Conexion.ObtenerConexionODBC();
                    clsComun imp = new clsComun();
                    OdbcCommand _comando2 = new OdbcCommand(String.Format(
                         "SELECT nombre FROM impuesto where id_impuesto_pk ='{0}'  and estado='activo'", pam.codimp), conectar2);
                    OdbcDataReader _reader2 = _comando2.ExecuteReader();
                    while (_reader2.Read())
                    {

                        imp.nombre = _reader2.GetString(0); //Id impuestp
                    }
                    conectar2.Close();
                    cbo_imp.Text = imp.nombre;
                    btn_nuevo.Enabled = true;
                    btn_guardar.Enabled = false;
                    btn_eliminar.Enabled = true;
                    btn_editar.Enabled = true;
                    btn_cancelar.Enabled = true;


                }
                else
                {
                    


                    cbo_imp.Enabled = false;
                    cbo_empre.Enabled = false;
                    btn_nuevo.Enabled = true;
                    btn_guardar.Enabled = false;
                    btn_eliminar.Enabled = false;
                    btn_editar.Enabled = false;
                    btn_cancelar.Enabled = false;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public clsParamFact FmAct { get; set; }

        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmParametrosFact_Load(object sender, EventArgs e)
        {
            OdbcConnection conectar2 = seguridad.Conexion.ObtenerConexionODBC();
            string scad1 = "select * from empresa";
            OdbcCommand mcd1 = new OdbcCommand(scad1, conectar2);
            OdbcDataReader mdr1 = mcd1.ExecuteReader();
            while (mdr1.Read())
            {
                cbo_empre.Items.Add(mdr1.GetString(1));
            }
            conectar2.Close();



            OdbcConnection conectar3 = seguridad.Conexion.ObtenerConexionODBC();


            string scad3 = "select * from impuesto where estado='activo'";
            OdbcCommand mcd3 = new OdbcCommand(scad3, conectar3);
            OdbcDataReader mdr3 = mcd3.ExecuteReader();
            while (mdr3.Read())
            {
                cbo_imp.Items.Add(mdr3.GetString(2));
            }
            conectar2.Close();

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(cbo_empre.Text))
                    MessageBox.Show("Campo obligatorio vacío", "Campo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    clsParamFact ptp = new clsParamFact();


                    OdbcConnection conectar = seguridad.Conexion.ObtenerConexionODBC();
                    clsComun emp = new clsComun();
                    OdbcCommand _comando = new OdbcCommand(String.Format(
                         "SELECT id_empresa_pk FROM empresa where nombre ='{0}' ", cbo_empre.Text), conectar);
                    OdbcDataReader _reader = _comando.ExecuteReader();
                    while (_reader.Read())
                    {

                        emp.cod= _reader.GetInt16(0); //Id empresa
                    }
                    conectar.Close();
                    // MessageBox.Show(emp.nombre);
                   

                    OdbcConnection conectar2 = seguridad.Conexion.ObtenerConexionODBC();
                    clsComun imp = new clsComun();
                    OdbcCommand _comando2 = new OdbcCommand(String.Format(
                         "SELECT id_impuesto_pk FROM impuesto where nombre ='{0}' ", cbo_imp.Text), conectar2);
                    OdbcDataReader _reader2 = _comando2.ExecuteReader();
                    while (_reader2.Read())
                    {

                        imp.cod = _reader2.GetInt16(0); //Id impuestp
                    }
                   // MessageBox.Show(Convert.ToString(imp.cod));


                    ptp.icodmep = emp.cod;
                    ptp.codimp = imp.cod;


                    int iresultado = clsOpParmFact.Agregar(ptp);
                    if (iresultado > 0)
                    {
                        MessageBox.Show("Parametro Guardada Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cbo_empre.Enabled = false;
                        cbo_imp.Enabled = false;

                        btn_nuevo.Enabled = true;
                        cbo_imp.Text = "";
                        cbo_empre.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("No se pudo guardar el parametro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        cbo_empre.Enabled = false;
                        cbo_imp.Enabled = false;

                        btn_nuevo.Enabled = true;
                        cbo_imp.Text = "";
                        cbo_empre.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(cbo_empre.Text))
                    MessageBox.Show("Campo obligatorio vacío", "Campo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    clsParamFact ptp = new clsParamFact();

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
                    // MessageBox.Show(emp.nombre);


                    OdbcConnection conectar2 = seguridad.Conexion.ObtenerConexionODBC();
                    clsComun imp = new clsComun();
                    OdbcCommand _comando2 = new OdbcCommand(String.Format(
                         "SELECT id_impuesto_pk FROM impuesto where nombre ='{0}' ", cbo_imp.Text), conectar2);
                    OdbcDataReader _reader2 = _comando2.ExecuteReader();
                    while (_reader2.Read())
                    {

                        imp.cod = _reader2.GetInt16(0); //Id impuestp
                    }
                    // MessageBox.Show(Convert.ToString(imp.cod));


                    ptp.icodmep = emp.cod;
                    ptp.codimp = imp.cod;

                    ptp.icod = FmAct.icod;
                    int iresultado = clsOpParmFact.Actualizar(ptp);
                    if (iresultado > 0)
                    {
                        MessageBox.Show("Parametro actualizaco Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cbo_empre.Enabled = false;
                        cbo_imp.Enabled = false;

                        btn_nuevo.Enabled = true;
                        cbo_imp.Text = "";
                        cbo_empre.Text = "";

                        btn_editar.Enabled = false;
                        btn_eliminar.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar el parametro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        cbo_empre.Enabled = false;
                        cbo_imp.Enabled = false;

                        btn_nuevo.Enabled = true;
                        cbo_imp.Text = "";
                        cbo_empre.Text = "";

                        btn_editar.Enabled = false;
                        btn_eliminar.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        Boolean editar;
        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            editar = false;
            FuncionesNavegador.CapaNegocio fn = new FuncionesNavegador.CapaNegocio();
            fn.ActivarControles(this);
            fn.LimpiarComponentes(this);
            btn_guardar.Enabled = true;
            btn_cancelar.Enabled = true;
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(cbo_empre.Text))
                    MessageBox.Show("Campo obligatorio vacío", "Campo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    clsParamFact ptp = new clsParamFact();

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
                    // MessageBox.Show(emp.nombre);


                    OdbcConnection conectar2 = seguridad.Conexion.ObtenerConexionODBC();
                    clsComun imp = new clsComun();
                    OdbcCommand _comando2 = new OdbcCommand(String.Format(
                         "SELECT id_impuesto_pk FROM impuesto where nombre ='{0}' ", cbo_imp.Text), conectar2);
                    OdbcDataReader _reader2 = _comando2.ExecuteReader();
                    while (_reader2.Read())
                    {

                        imp.cod = _reader2.GetInt16(0); //Id impuestp
                    }
                    // MessageBox.Show(Convert.ToString(imp.cod));


                    ptp.icodmep = emp.cod;
                    ptp.codimp = imp.cod;

                    ptp.icod = FmAct.icod;
                    int iresultado = clsOpParmFact.Elimiar(ptp);
                    if (iresultado > 0)
                    {
                        MessageBox.Show("Parametro eliminado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cbo_empre.Enabled = false;
                        cbo_imp.Enabled = false;

                        btn_nuevo.Enabled = true;
                        cbo_imp.Text = "";
                        cbo_empre.Text = "";

                        btn_editar.Enabled = false;
                        btn_eliminar.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminado el parametro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        cbo_empre.Enabled = false;
                        cbo_imp.Enabled = false;

                        btn_nuevo.Enabled = true;
                        cbo_imp.Text = "";
                        cbo_empre.Text = "";

                        btn_editar.Enabled = false;
                        btn_eliminar.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_ayuda_Click(object sender, EventArgs e)
        {
            string ruta = "Manual_ParamFact.pdf";
            ProcessStartInfo startinfo = new ProcessStartInfo();
            startinfo.FileName = "AcroRd32.exe";
            startinfo.Arguments = ruta;
            Process.Start(startinfo);
        }
    }
}
