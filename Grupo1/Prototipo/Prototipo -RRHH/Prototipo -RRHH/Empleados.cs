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

        public Empleados(DataGridView dgv, String id_empleados_pk, String nombre, String telefono, String direccion, String genero, String fecha_nacimiento, String fecha_ingreso, String fecha_egreso, String dpi, String no_afiliacion_igss, String estado, String edad, String nacionalidad, String estado_civil, String cargo, String sueldo, String tipo_sueldo, String id_empresa_pk, Boolean Editar1, Boolean tipo_accion)
        {
            this.dg = dgv;
            this.Editar = Editar1;
            InitializeComponent();
            atributo = "id_empleados_pk";
            this.Codigo = id_empleados_pk;
            if(tipo_accion == true)
            {
                
                this.txt_nomb_emp.Text = nombre;
                this.txt_telef_emp.Text = telefono;
                this.txt_direc_emp.Text = direccion;
                this.cbo_gener_emp.Text = genero;
                this.txt_dtp_fecha_nacim.Text = fecha_nacimiento; dtp_fecha_nacim.Text = txt_dtp_fecha_nacim.Text;
                this.txt_dtp_fecha_ingr_emp.Text = fecha_ingreso; dtp_fecha_ingr_emp.Text = txt_dtp_fecha_ingr_emp.Text;
                this.txt_dtp_fecha_egre_emp.Text = fecha_egreso; dtp_fecha_egre_emp.Text = txt_dtp_fecha_egre_emp.Text;
                this.txt_dpi_emp.Text = dpi;
                this.txt_carne_igss_emp.Text = no_afiliacion_igss;
                this.txt_edad_emp.Text = edad;
                this.txt_cbo_nacional_emp.Text = nacionalidad; cbo_estad_civ_emp.Text = txt_cbo_estad_civ_emp.Text;
                this.txt_cbo_estad_civ_emp.Text = estado_civil; cbo_estad_civ_emp.Text = txt_cbo_estad_civ_emp.Text;
                this.txt_cbo_cargo_emp.Text = cargo; cbo_cargo_emp.Text = txt_cbo_cargo_emp.Text;
                this.txt_sueldo_emp.Text = sueldo;
                this.txt_tipo_sueldo.Text = tipo_sueldo;
                this.fn.ActivarControles(gpb_regist_emp);
            }
            else
            {
                fn.ActivarControles(gpb_regist_emp);
            }

        }

        string imgLoc;
        string imgname;
        String Codigo;
        Boolean Editar;
        String atributo;
        MySqlCommand comand;
        CapaNegocio fn = new CapaNegocio();
        DataGridView dg;



        private void Empleados_Load(object sender, EventArgs e)
        {
            fn.InhabilitarComponentes(gpb_regist_emp);
            fn.InhabilitarComponentes(this);
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
                    imgname = dlg.SafeFileName.ToString();
                    txt_nom_img.Text = imgname;
                    pic_empleado.ImageLocation = imgLoc;
                    txt_direc_img.Text = imgLoc;
                    string targetPath = @"C:/empleados";
                    string sourceFile = System.IO.Path.Combine(imgLoc);
                    string destFile = System.IO.Path.Combine(targetPath, imgname);
                    if (!System.IO.Directory.Exists(targetPath))
                    {
                        System.IO.Directory.CreateDirectory(targetPath);
                    }
                    System.IO.File.Copy(sourceFile, destFile, true);
                    txt_img_final.Text = destFile;
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
                op.ejecutar(dg, tabla);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            string tabla = "empleado";
            fn.ActualizarGrid(this.dg, "Select `id_empleados_pk`, `nombre`, `telefono`, `direccion`, `genero`, `fecha_nacimiento`, `fecha_ingreso`, `fecha_egreso`, `dpi`, `no_afiliacion_igss`, `estado`, `edad`, `nacionalidad`, `estado_civil`, `cargo`, `sueldo`, `tipo_sueldo`, `id_empresa_pk` from empleado WHERE estado <> 'INACTIVO' ", tabla);


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

                TextBox[] textbox = { txt_nomb_emp, txt_dtp_fecha_nacim, txt_edad_emp, txt_dpi_emp, txt_cbo_nacional_emp, txt_cbo_estad_civ_emp, txt_carne_igss_emp, txt_sueldo_emp, txt_tipo_sueldo, txt_empresa, txt_dtp_fecha_ingr_emp, txt_dtp_fecha_egre_emp, txt_direc_emp, txt_cbo_cargo_emp, txt_telef_emp, txt_cbo_gener_emp, txt_nom_img, txt_estado };
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
                       
                        /*byte[] img = null;
                        FileStream fs = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
                        BinaryReader br = new BinaryReader(fs);
                        img = br.ReadBytes((int)fs.Length);
                        string sql = "Insert Into empleado (foto_empleado) values (',@img,')";
                        Conexionmysql.EjecutarMySql(sql);
                        comand = new MySqlCommand(sql);
                        comand.Parameters.Add(new MySqlParameter("@img", img));*/


                    }
                    fn.LimpiarComponentes(this);
                    pic_empleado.Image = null;
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
                this.Codigo = this.dg.CurrentRow.Cells[0].Value.ToString();
                this.txt_nomb_emp.Text = this.dg.CurrentRow.Cells[1].Value.ToString();
                this.txt_dtp_fecha_nacim.Text = this.dg.CurrentRow.Cells[5].Value.ToString(); dtp_fecha_nacim.Text = txt_dtp_fecha_nacim.Text;
                this.txt_edad_emp.Text = this.dg.CurrentRow.Cells[11].Value.ToString();
                this.txt_dpi_emp.Text = this.dg.CurrentRow.Cells[8].Value.ToString();
                this.txt_cbo_nacional_emp.Text = this.dg.CurrentRow.Cells[12].Value.ToString(); cbo_nacional_emp.Text = txt_cbo_nacional_emp.Text;
                this.txt_cbo_estad_civ_emp.Text = this.dg.CurrentRow.Cells[13].Value.ToString(); cbo_estad_civ_emp.Text = txt_cbo_estad_civ_emp.Text;
                this.txt_carne_igss_emp.Text = this.dg.CurrentRow.Cells[9].Value.ToString();
                this.txt_sueldo_emp.Text = this.dg.CurrentRow.Cells[15].Value.ToString();
                this.txt_tipo_sueldo.Text = this.dg.CurrentRow.Cells[16].Value.ToString();
                this.txt_dtp_fecha_ingr_emp.Text = this.dg.CurrentRow.Cells[6].Value.ToString(); dtp_fecha_ingr_emp.Text = txt_dtp_fecha_ingr_emp.Text;
                this.txt_dtp_fecha_egre_emp.Text = this.dg.CurrentRow.Cells[7].Value.ToString(); dtp_fecha_egre_emp.Text = txt_dtp_fecha_egre_emp.Text;
                this.txt_direc_emp.Text = this.dg.CurrentRow.Cells[3].Value.ToString();
                this.txt_telef_emp.Text = this.dg.CurrentRow.Cells[2].Value.ToString();
                this.txt_nom_img.Text = this.dg.CurrentRow.Cells[17].Value.ToString();
                this.txt_empresa.Text = this.dg.CurrentRow.Cells[18].Value.ToString();
                this.txt_cbo_gener_emp.Text = this.dg.CurrentRow.Cells[4].Value.ToString(); cbo_gener_emp.Text = txt_cbo_gener_emp.Text;
                fn.ActivarControles(gpb_regist_emp);
                string direc = txt_nom_img.Text;
                pic_empleado.ImageLocation = @"C:\empleados\" + direc;
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
                String codigo2 = this.dg.CurrentRow.Cells[0].Value.ToString();
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
            fn.Anterior(dg);
           /* TextBox[] textbox = { txt_nomb_emp, txt_dtp_fecha_nacim, txt_edad_emp, txt_dpi_emp, txt_cbo_nacional_emp, txt_cbo_estad_civ_emp, txt_carne_igss_emp, txt_sueldo_emp, txt_tipo_sueldo, txt_dtp_fecha_ingr_emp, txt_dtp_fecha_egre_emp, txt_direc_emp, txt_cbo_cargo_emp, txt_telef_emp, txt_cbo_gener_emp };
            fn.llenartextbox(textbox, dgv_datos_emp);
            dtp_fecha_nacim.Text = txt_dtp_fecha_nacim.Text;
            cbo_nacional_emp.Text = txt_cbo_nacional_emp.Text;
            cbo_estad_civ_emp.Text = txt_cbo_estad_civ_emp.Text;
            dtp_fecha_ingr_emp.Text = txt_dtp_fecha_ingr_emp.Text;
            dtp_fecha_egre_emp.Text = txt_dtp_fecha_egre_emp.Text;
            cbo_cargo_emp.Text = txt_cbo_cargo_emp.Text;
            cbo_gener_emp.Text = txt_cbo_gener_emp.Text; */
            atributo = "id_empleados_pk";
            this.Codigo = this.dg.CurrentRow.Cells[0].Value.ToString();
            this.txt_nomb_emp.Text = this.dg.CurrentRow.Cells[1].Value.ToString();
            this.txt_dtp_fecha_nacim.Text = this.dg.CurrentRow.Cells[5].Value.ToString(); dtp_fecha_nacim.Text = txt_dtp_fecha_nacim.Text;
            this.txt_edad_emp.Text = this.dg.CurrentRow.Cells[11].Value.ToString();
            this.txt_dpi_emp.Text = this.dg.CurrentRow.Cells[8].Value.ToString();
            this.txt_cbo_nacional_emp.Text = this.dg.CurrentRow.Cells[12].Value.ToString(); cbo_nacional_emp.Text = txt_cbo_nacional_emp.Text;
            this.txt_cbo_estad_civ_emp.Text = this.dg.CurrentRow.Cells[13].Value.ToString(); cbo_estad_civ_emp.Text = txt_cbo_estad_civ_emp.Text;
            this.txt_carne_igss_emp.Text = this.dg.CurrentRow.Cells[9].Value.ToString();
            this.txt_sueldo_emp.Text = this.dg.CurrentRow.Cells[15].Value.ToString();
            this.txt_tipo_sueldo.Text = this.dg.CurrentRow.Cells[16].Value.ToString();
            this.txt_dtp_fecha_ingr_emp.Text = this.dg.CurrentRow.Cells[6].Value.ToString(); dtp_fecha_ingr_emp.Text = txt_dtp_fecha_ingr_emp.Text;
            this.txt_dtp_fecha_egre_emp.Text = this.dg.CurrentRow.Cells[7].Value.ToString(); dtp_fecha_egre_emp.Text = txt_dtp_fecha_egre_emp.Text;
            this.txt_direc_emp.Text = this.dg.CurrentRow.Cells[3].Value.ToString();
            this.txt_telef_emp.Text = this.dg.CurrentRow.Cells[2].Value.ToString();
            this.txt_cbo_gener_emp.Text = this.dg.CurrentRow.Cells[13].Value.ToString(); cbo_gener_emp.Text = txt_cbo_gener_emp.Text;
            this.txt_nom_img.Text = this.dg.CurrentRow.Cells[17].Value.ToString();
            string direc = txt_nom_img.Text;
            pic_empleado.ImageLocation = @"C:\empleados\" + direc;
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            fn.Siguiente(dg);
           /* TextBox[] textbox = { txt_nomb_emp, txt_dtp_fecha_nacim, txt_edad_emp, txt_dpi_emp, txt_cbo_nacional_emp, txt_cbo_estad_civ_emp, txt_carne_igss_emp, txt_sueldo_emp, txt_tipo_sueldo, txt_dtp_fecha_ingr_emp, txt_dtp_fecha_egre_emp, txt_direc_emp, txt_cbo_cargo_emp, txt_telef_emp, txt_cbo_gener_emp };
            fn.llenartextbox(textbox, dgv_datos_emp);
            dtp_fecha_nacim.Text = txt_dtp_fecha_nacim.Text;
            cbo_nacional_emp.Text = txt_cbo_nacional_emp.Text;
            cbo_estad_civ_emp.Text = txt_cbo_estad_civ_emp.Text;
            dtp_fecha_ingr_emp.Text = txt_dtp_fecha_ingr_emp.Text;
            dtp_fecha_egre_emp.Text = txt_dtp_fecha_egre_emp.Text;
            cbo_cargo_emp.Text = txt_cbo_cargo_emp.Text;
            cbo_gener_emp.Text = txt_cbo_gener_emp.Text;*/
            atributo = "id_empleados_pk";
            this.Codigo = this.dg.CurrentRow.Cells[0].Value.ToString();
            this.txt_nomb_emp.Text = this.dg.CurrentRow.Cells[1].Value.ToString();
            this.txt_dtp_fecha_nacim.Text = this.dg.CurrentRow.Cells[5].Value.ToString(); dtp_fecha_nacim.Text = txt_dtp_fecha_nacim.Text;
            this.txt_edad_emp.Text = this.dg.CurrentRow.Cells[11].Value.ToString();
            this.txt_dpi_emp.Text = this.dg.CurrentRow.Cells[8].Value.ToString();
            this.txt_cbo_nacional_emp.Text = this.dg.CurrentRow.Cells[12].Value.ToString(); cbo_nacional_emp.Text = txt_cbo_nacional_emp.Text;
            this.txt_cbo_estad_civ_emp.Text = this.dg.CurrentRow.Cells[13].Value.ToString(); cbo_estad_civ_emp.Text = txt_cbo_estad_civ_emp.Text;
            this.txt_carne_igss_emp.Text = this.dg.CurrentRow.Cells[9].Value.ToString();
            this.txt_sueldo_emp.Text = this.dg.CurrentRow.Cells[15].Value.ToString();
            this.txt_tipo_sueldo.Text = this.dg.CurrentRow.Cells[16].Value.ToString();
            this.txt_dtp_fecha_ingr_emp.Text = this.dg.CurrentRow.Cells[6].Value.ToString(); dtp_fecha_ingr_emp.Text = txt_dtp_fecha_ingr_emp.Text;
            this.txt_dtp_fecha_egre_emp.Text = this.dg.CurrentRow.Cells[7].Value.ToString(); dtp_fecha_egre_emp.Text = txt_dtp_fecha_egre_emp.Text;
            this.txt_direc_emp.Text = this.dg.CurrentRow.Cells[3].Value.ToString();
            this.txt_telef_emp.Text = this.dg.CurrentRow.Cells[2].Value.ToString();
            this.txt_cbo_gener_emp.Text = this.dg.CurrentRow.Cells[13].Value.ToString(); cbo_gener_emp.Text = txt_cbo_gener_emp.Text;
            this.txt_nom_img.Text = this.dg.CurrentRow.Cells[17].Value.ToString();
            string direc = txt_nom_img.Text;
            pic_empleado.ImageLocation = @"C:\empleados\" + direc;
        }

        private void btn_primero_Click(object sender, EventArgs e)
        {
            fn.Primero(dg);
           /* TextBox[] textbox = { txt_nomb_emp, txt_dtp_fecha_nacim, txt_edad_emp, txt_dpi_emp, txt_cbo_nacional_emp, txt_cbo_estad_civ_emp, txt_carne_igss_emp, txt_sueldo_emp, txt_tipo_sueldo, txt_dtp_fecha_ingr_emp, txt_dtp_fecha_egre_emp, txt_direc_emp, txt_cbo_cargo_emp, txt_telef_emp, txt_cbo_gener_emp };
            fn.llenartextbox(textbox, dgv_datos_emp);
            dtp_fecha_nacim.Text = txt_dtp_fecha_nacim.Text;
            cbo_nacional_emp.Text = txt_cbo_nacional_emp.Text;
            cbo_estad_civ_emp.Text = txt_cbo_estad_civ_emp.Text;
            dtp_fecha_ingr_emp.Text = txt_dtp_fecha_ingr_emp.Text;
            dtp_fecha_egre_emp.Text = txt_dtp_fecha_egre_emp.Text;
            cbo_cargo_emp.Text = txt_cbo_cargo_emp.Text;
            cbo_gener_emp.Text = txt_cbo_gener_emp.Text; */
            atributo = "id_empleados_pk";
            this.Codigo = this.dg.CurrentRow.Cells[0].Value.ToString();
            this.txt_nomb_emp.Text = this.dg.CurrentRow.Cells[1].Value.ToString();
            this.txt_dtp_fecha_nacim.Text = this.dg.CurrentRow.Cells[5].Value.ToString(); dtp_fecha_nacim.Text = txt_dtp_fecha_nacim.Text;
            this.txt_edad_emp.Text = this.dg.CurrentRow.Cells[11].Value.ToString();
            this.txt_dpi_emp.Text = this.dg.CurrentRow.Cells[8].Value.ToString();
            this.txt_cbo_nacional_emp.Text = this.dg.CurrentRow.Cells[12].Value.ToString(); cbo_nacional_emp.Text = txt_cbo_nacional_emp.Text;
            this.txt_cbo_estad_civ_emp.Text = this.dg.CurrentRow.Cells[13].Value.ToString(); cbo_estad_civ_emp.Text = txt_cbo_estad_civ_emp.Text;
            this.txt_carne_igss_emp.Text = this.dg.CurrentRow.Cells[9].Value.ToString();
            this.txt_sueldo_emp.Text = this.dg.CurrentRow.Cells[15].Value.ToString();
            this.txt_tipo_sueldo.Text = this.dg.CurrentRow.Cells[16].Value.ToString();
            this.txt_dtp_fecha_ingr_emp.Text = this.dg.CurrentRow.Cells[6].Value.ToString(); dtp_fecha_ingr_emp.Text = txt_dtp_fecha_ingr_emp.Text;
            this.txt_dtp_fecha_egre_emp.Text = this.dg.CurrentRow.Cells[7].Value.ToString(); dtp_fecha_egre_emp.Text = txt_dtp_fecha_egre_emp.Text;
            this.txt_direc_emp.Text = this.dg.CurrentRow.Cells[3].Value.ToString();
            this.txt_telef_emp.Text = this.dg.CurrentRow.Cells[2].Value.ToString();
            this.txt_cbo_gener_emp.Text = this.dg.CurrentRow.Cells[13].Value.ToString(); cbo_gener_emp.Text = txt_cbo_gener_emp.Text;
            this.txt_nom_img.Text = this.dg.CurrentRow.Cells[17].Value.ToString();
            string direc = txt_nom_img.Text;
            pic_empleado.ImageLocation = @"C:\empleados\" + direc;
        }

        private void btn_ultimo_Click(object sender, EventArgs e)
        {
            fn.Ultimo(dg);
            /*TextBox[] textbox = { txt_nomb_emp, txt_dtp_fecha_nacim, txt_edad_emp, txt_dpi_emp, txt_cbo_nacional_emp, txt_cbo_estad_civ_emp, txt_carne_igss_emp, txt_sueldo_emp, txt_tipo_sueldo, txt_dtp_fecha_ingr_emp, txt_dtp_fecha_egre_emp, txt_direc_emp, txt_cbo_cargo_emp, txt_telef_emp, txt_cbo_gener_emp };
            fn.llenartextbox(textbox, dgv_datos_emp);
            dtp_fecha_nacim.Text = txt_dtp_fecha_nacim.Text;
            cbo_nacional_emp.Text = txt_cbo_nacional_emp.Text;
            cbo_estad_civ_emp.Text = txt_cbo_estad_civ_emp.Text;
            dtp_fecha_ingr_emp.Text = txt_dtp_fecha_ingr_emp.Text;
            dtp_fecha_egre_emp.Text = txt_dtp_fecha_egre_emp.Text;
            cbo_cargo_emp.Text = txt_cbo_cargo_emp.Text;
            cbo_gener_emp.Text = txt_cbo_gener_emp.Text;*/
            atributo = "id_empleados_pk";
            this.Codigo = this.dg.CurrentRow.Cells[0].Value.ToString();
            this.txt_nomb_emp.Text = this.dg.CurrentRow.Cells[1].Value.ToString();
            this.txt_dtp_fecha_nacim.Text = this.dg.CurrentRow.Cells[5].Value.ToString(); dtp_fecha_nacim.Text = txt_dtp_fecha_nacim.Text;
            this.txt_edad_emp.Text = this.dg.CurrentRow.Cells[11].Value.ToString();
            this.txt_dpi_emp.Text = this.dg.CurrentRow.Cells[8].Value.ToString();
            this.txt_cbo_nacional_emp.Text = this.dg.CurrentRow.Cells[12].Value.ToString(); cbo_nacional_emp.Text = txt_cbo_nacional_emp.Text;
            this.txt_cbo_estad_civ_emp.Text = this.dg.CurrentRow.Cells[13].Value.ToString(); cbo_estad_civ_emp.Text = txt_cbo_estad_civ_emp.Text;
            this.txt_carne_igss_emp.Text = this.dg.CurrentRow.Cells[9].Value.ToString();
            this.txt_sueldo_emp.Text = this.dg.CurrentRow.Cells[15].Value.ToString();
            this.txt_tipo_sueldo.Text = this.dg.CurrentRow.Cells[16].Value.ToString();
            this.txt_dtp_fecha_ingr_emp.Text = this.dg.CurrentRow.Cells[6].Value.ToString(); dtp_fecha_ingr_emp.Text = txt_dtp_fecha_ingr_emp.Text;
            this.txt_dtp_fecha_egre_emp.Text = this.dg.CurrentRow.Cells[7].Value.ToString(); dtp_fecha_egre_emp.Text = txt_dtp_fecha_egre_emp.Text;
            this.txt_direc_emp.Text = this.dg.CurrentRow.Cells[3].Value.ToString();
            this.txt_telef_emp.Text = this.dg.CurrentRow.Cells[2].Value.ToString();
            this.txt_cbo_gener_emp.Text = this.dg.CurrentRow.Cells[13].Value.ToString(); cbo_gener_emp.Text = txt_cbo_gener_emp.Text;
            this.txt_nom_img.Text = this.dg.CurrentRow.Cells[17].Value.ToString();
            string direc = txt_nom_img.Text;
            pic_empleado.ImageLocation = @"C:\empleados\" + direc;
        }
    }
}
