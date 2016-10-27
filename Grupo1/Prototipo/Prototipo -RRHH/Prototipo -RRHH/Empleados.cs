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
using System.Drawing;
using System.Data;
using System.Threading;
using System.IO;

namespace Prototipo__RRHH
{
    public partial class Empleados : Form
    {
        public Empleados()
        {
            InitializeComponent();
        }

        string imgLoc;
        String Codigo;
        Boolean Editar;
        String atributo;
        MySqlCommand comand;
        CapaNegocio fn = new CapaNegocio();

        private void Empleados_Load(object sender, EventArgs e)
        {
            fn.InhabilitarComponentes(gpb_regist_emp);
            fn.InhabilitarComponentes(this);
            string tabla = "empleado";
            fn.ActualizarGrid(this.dgv_datos_emp, "Select * from empleado WHERE estado <> 'INACTIVO' ", tabla);
            txt_cod_emp.Text = this.dgv_datos_emp.CurrentRow.Cells[0].Value.ToString();

        }

        private void btn_examinar_pic_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "JPG Files(*.jpg)|*.jpg|GIF Files(*.gif)|*.gif|All Files(*.*)|*.*";
                dlg.Title = "Selecciones su foto de perfil";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    imgLoc = dlg.FileName.ToString();
                    pic_empleado.ImageLocation = imgLoc;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            try
            {
                Editar = false;
                fn.ActivarControles(gpb_regist_emp);
                fn.LimpiarComponentes(gpb_regist_emp);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            try
            {
                Editar = false;
                fn.LimpiarComponentes(gpb_regist_emp);
                fn.InhabilitarComponentes(gpb_regist_emp);
                pic_empleado.InitialImage = null;
                pic_empleado.Image = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                string tabla = "empleado";
                operaciones op = new operaciones();
                op.ejecutar(dgv_datos_emp, tabla);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            string tabla = "empleado";
            fn.ActualizarGrid(this.dgv_datos_emp, "Select * from empleado WHERE estado <> 'INACTIVO' ", tabla);


            /*Conexionmysql.ObtenerConexion();
            String query1 = "Select foto_empleado from empleado where id_empleados_pk ='" + txt_cod_emp.Text + "'";
            OdbcCommand cmd = new OdbcCommand(query1);
            OdbcDataReader reader = cmd.ExecuteReader();

            byte[] img = (byte[])(reader[0]);
            if (img == null)
            {
                pic_empleado.Image = null;
            }
            else
            {
                MemoryStream ms = new MemoryStream(img);
                pic_empleado.Image = Image.FromStream(ms);

            }*/
        }

        private void gpb_navegador_Enter(object sender, EventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                txt_dtp_fecha_nacim.Text = dtp_fecha_nacim.Value.ToString("yyyy-MM-dd");
                txt_cbo_nacional_emp.Text = cbo_nacional_emp.Text;
                txt_cbo_estad_civ_emp.Text = cbo_estad_civ_emp.Text;
                txt_dtp_fecha_ingr_emp.Text = dtp_fecha_ingr_emp.Value.ToString("yyyy-MM-dd");
                txt_dtp_fecha_egre_emp.Text = dtp_fecha_egre_emp.Value.ToString("yyyy-MM-dd");
                txt_cbo_cargo_emp.Text = cbo_cargo_emp.Text;
                txt_cbo_gener_emp.Text = cbo_gener_emp.Text;

                TextBox[] textbox = { txt_nomb_emp, txt_dtp_fecha_nacim, txt_edad_emp, txt_dpi_emp, txt_cbo_nacional_emp, txt_cbo_estad_civ_emp, txt_carne_igss_emp, txt_sueldo_emp, txt_tipo_sueldo, txt_empresa, txt_dtp_fecha_ingr_emp, txt_dtp_fecha_egre_emp, txt_direc_emp, txt_cbo_cargo_emp, txt_telef_emp, txt_cbo_gener_emp, txt_estado_emp };
                DataTable datos = fn.construirDataTable(textbox);
                if (datos.Rows.Count == 0)
                {
                    MessageBox.Show("Hay campos vacios", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string tabla = "empleado";
                    if (Editar)
                    {
                        fn.modificar(datos, tabla, atributo, Codigo);
                    }
                    else
                    {
                        fn.insertar(datos, tabla);

                        Conexionmysql.ObtenerConexion();
                       
                        byte[] img = null;
                        FileStream fs = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
                        BinaryReader br = new BinaryReader(fs);
                        img = br.ReadBytes((int)fs.Length);
                        string sql = "Insert Into empleado (foto_empleado) values (',@img,')";
                        Conexionmysql.EjecutarMySql(sql);
                        comand = new MySqlCommand(sql);
                        comand.Parameters.Add(new MySqlParameter("@img", img));


                    }
                    fn.LimpiarComponentes(this);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                Editar = true;
                atributo = "id_empleados_pk";
                Codigo = this.dgv_datos_emp.CurrentRow.Cells[0].Value.ToString();
                TextBox[] textbox = { txt_nomb_emp, txt_dtp_fecha_nacim, txt_edad_emp, txt_dpi_emp, txt_cbo_nacional_emp, txt_cbo_estad_civ_emp, txt_carne_igss_emp, txt_sueldo_emp, txt_tipo_sueldo, txt_dtp_fecha_ingr_emp, txt_dtp_fecha_egre_emp, txt_direc_emp, txt_cbo_cargo_emp, txt_telef_emp, txt_cbo_gener_emp, txt_estado_emp };
                fn.llenartextbox(textbox, dgv_datos_emp);
            }
            catch
            {
                MessageBox.Show("No se ha seleccionado ningun registro a editar", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                String codigo2 = this.dgv_datos_emp.CurrentRow.Cells[0].Value.ToString();
                String atributo2 = "id_empleados_pk";
                //String campo = "estado";
                var resultado = MessageBox.Show("DESEA BORRAR EL REGISTRO SELECCIONADO", "CONFIRME SU ACCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    string tabla = "empleado";
                    fn.eliminar(tabla, atributo2, codigo2);

                }
            }
            catch
            {
                MessageBox.Show("No se ha seleccionado ningun registro a eliminar", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            fn.Anterior(dgv_datos_emp);
            TextBox[] textbox = { txt_nomb_emp, txt_dtp_fecha_nacim, txt_edad_emp, txt_dpi_emp, txt_cbo_nacional_emp, txt_cbo_estad_civ_emp, txt_carne_igss_emp, txt_sueldo_emp, txt_tipo_sueldo, txt_dtp_fecha_ingr_emp, txt_dtp_fecha_egre_emp, txt_direc_emp, txt_cbo_cargo_emp, txt_telef_emp, txt_cbo_gener_emp, txt_estado_emp };
            fn.llenartextbox(textbox, dgv_datos_emp);
            dtp_fecha_nacim.Text = txt_dtp_fecha_nacim.Text;
            cbo_nacional_emp.Text = txt_cbo_nacional_emp.Text;
            cbo_estad_civ_emp.Text = txt_cbo_estad_civ_emp.Text;
            dtp_fecha_ingr_emp.Text = txt_dtp_fecha_ingr_emp.Text;
            dtp_fecha_egre_emp.Text = txt_dtp_fecha_egre_emp.Text;
            cbo_cargo_emp.Text = txt_cbo_cargo_emp.Text;
            cbo_gener_emp.Text = txt_cbo_gener_emp.Text;
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            fn.Siguiente(dgv_datos_emp);
            TextBox[] textbox = { txt_nomb_emp, txt_dtp_fecha_nacim, txt_edad_emp, txt_dpi_emp, txt_cbo_nacional_emp, txt_cbo_estad_civ_emp, txt_carne_igss_emp, txt_sueldo_emp, txt_tipo_sueldo, txt_dtp_fecha_ingr_emp, txt_dtp_fecha_egre_emp, txt_direc_emp, txt_cbo_cargo_emp, txt_telef_emp, txt_cbo_gener_emp, txt_estado_emp };
            fn.llenartextbox(textbox, dgv_datos_emp);
            dtp_fecha_nacim.Text = txt_dtp_fecha_nacim.Text;
            cbo_nacional_emp.Text = txt_cbo_nacional_emp.Text;
            cbo_estad_civ_emp.Text = txt_cbo_estad_civ_emp.Text;
            dtp_fecha_ingr_emp.Text = txt_dtp_fecha_ingr_emp.Text;
            dtp_fecha_egre_emp.Text = txt_dtp_fecha_egre_emp.Text;
            cbo_cargo_emp.Text = txt_cbo_cargo_emp.Text;
            cbo_gener_emp.Text = txt_cbo_gener_emp.Text;
        }

        private void btn_primero_Click(object sender, EventArgs e)
        {
            fn.Primero(dgv_datos_emp);
            TextBox[] textbox = { txt_nomb_emp, txt_dtp_fecha_nacim, txt_edad_emp, txt_dpi_emp, txt_cbo_nacional_emp, txt_cbo_estad_civ_emp, txt_carne_igss_emp, txt_sueldo_emp, txt_tipo_sueldo, txt_dtp_fecha_ingr_emp, txt_dtp_fecha_egre_emp, txt_direc_emp, txt_cbo_cargo_emp, txt_telef_emp, txt_cbo_gener_emp, txt_estado_emp };
            fn.llenartextbox(textbox, dgv_datos_emp);
            dtp_fecha_nacim.Text = txt_dtp_fecha_nacim.Text;
            cbo_nacional_emp.Text = txt_cbo_nacional_emp.Text;
            cbo_estad_civ_emp.Text = txt_cbo_estad_civ_emp.Text;
            dtp_fecha_ingr_emp.Text = txt_dtp_fecha_ingr_emp.Text;
            dtp_fecha_egre_emp.Text = txt_dtp_fecha_egre_emp.Text;
            cbo_cargo_emp.Text = txt_cbo_cargo_emp.Text;
            cbo_gener_emp.Text = txt_cbo_gener_emp.Text;
        }

        private void btn_ultimo_Click(object sender, EventArgs e)
        {
            fn.Ultimo(dgv_datos_emp);
            TextBox[] textbox = { txt_nomb_emp, txt_dtp_fecha_nacim, txt_edad_emp, txt_dpi_emp, txt_cbo_nacional_emp, txt_cbo_estad_civ_emp, txt_carne_igss_emp, txt_sueldo_emp, txt_tipo_sueldo, txt_dtp_fecha_ingr_emp, txt_dtp_fecha_egre_emp, txt_direc_emp, txt_cbo_cargo_emp, txt_telef_emp, txt_cbo_gener_emp, txt_estado_emp };
            fn.llenartextbox(textbox, dgv_datos_emp);
            dtp_fecha_nacim.Text = txt_dtp_fecha_nacim.Text;
            cbo_nacional_emp.Text = txt_cbo_nacional_emp.Text;
            cbo_estad_civ_emp.Text = txt_cbo_estad_civ_emp.Text;
            dtp_fecha_ingr_emp.Text = txt_dtp_fecha_ingr_emp.Text;
            dtp_fecha_egre_emp.Text = txt_dtp_fecha_egre_emp.Text;
            cbo_cargo_emp.Text = txt_cbo_cargo_emp.Text;
            cbo_gener_emp.Text = txt_cbo_gener_emp.Text;
        }
    }
}
