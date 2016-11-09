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
using dllconsultas;
using MySql.Data.MySqlClient;


namespace Prototipo__RRHH
{
    public partial class frm_Nomina : Form
    {
        public frm_Nomina()
        {
            InitializeComponent();
        }

        String id_empresa_pk_res, fecha_inicio_pago_res, fecha_de_corte_res, id_nomina_pk_res;

        public frm_Nomina(String id_empresa_pk, String fecha_inicio_pago, String fecha_de_corte, String id_nomina_pk)
        {
            id_empresa_pk_res = id_empresa_pk;
            fecha_inicio_pago_res = fecha_inicio_pago;
            fecha_de_corte_res = fecha_de_corte;
            id_nomina_pk_res = id_nomina_pk;
            InitializeComponent();
        }

        CapaNegocio fn = new CapaNegocio();
        operaciones op = new operaciones();
        Boolean Editar1;
        String id_empleados_pk1, sueldo_base_emp;
        double dias_trab;
        double salario_nominal, Salario_ordinario, Salario_extra1, Salario_extra2, Subtotal, IGSS, Base_anual, Liquidacion1, Bono14_1, total_deduccion1, total_deduccion2, total_isr;
        double bono_I, Minimum_Vital, Igss_anual, Igss_sal_extra, total_egresos, Renta_imponible, renta_isr, Isr_2, total_descuentos, Bonificacion, total_ingres, salario_liq;

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_Reporte_Nomina frm_report_nomin = new Frm_Reporte_Nomina();
            frm_report_nomin.MdiParent = this.ParentForm;
            frm_report_nomin.Show();
        }

        Boolean tipo_accion;
        String Codigo;
        Boolean Editar;
        String atributo;


        String id_devengos_pk, nombre_dev, detalle_dev, id_presamo_pk, nombre_prest, detalle_prest; 
        float cantidad_debengado, cantidad_deduccion;

        private void btn_primero_Click(object sender, EventArgs e)
        {
            dgv_detalle_nom.Rows.Clear();
            fn.Primero(dgv_datos_emp);
            TextBox[] textbox = { txt_nom_emp_nom, txt_cargo_emp_nom, txt_num_afiliac_nom, txt_fecha_ingre_emp_nom, txt_nacion_emp_nom };
            fn.llenartextbox(textbox, dgv_datos_emp);
            dtp_fech_inic_pag.Text = txt_fec_inic_pag_nom.Text;
            dtp_fech_fin_pag.Text = txt_fec_fin_pag_nom.Text;
            compararfechas();
            llenaridempresa();
            llenardireccion();
            llenarJornada();
            salarioNominal();
            llenar_detalle();
            SumaDevengos();
            SumaDeduccion();

            CalculosNomina();
        }

        private void btn_ultimo_Click(object sender, EventArgs e)
        {
            dgv_detalle_nom.Rows.Clear();
            fn.Ultimo(dgv_datos_emp);
            TextBox[] textbox = { txt_nom_emp_nom, txt_cargo_emp_nom, txt_num_afiliac_nom, txt_fecha_ingre_emp_nom, txt_nacion_emp_nom };
            fn.llenartextbox(textbox, dgv_datos_emp);
            dtp_fech_inic_pag.Text = txt_fec_inic_pag_nom.Text;
            dtp_fech_fin_pag.Text = txt_fec_fin_pag_nom.Text;
            compararfechas();
            llenaridempresa();
            llenardireccion();
            llenarJornada();
            salarioNominal();
            llenar_detalle();
            SumaDevengos();
            SumaDeduccion();

            CalculosNomina();
        }

        public void frm_Nomina_Load(object sender, EventArgs e)
        {
            
            try
            {

                
                string tabla = "empleado";
                fn.ActualizarGrid(this.dgv_datos_emp, "Select `id_empresa_pk`, `nombre`, `direccion`,  `fecha_ingreso`, `dpi`, `no_afiliacion_igss`, `estado`, `nacionalidad`,  `cargo`, `sueldo`,  `id_empleados_pk`, `id_jornada_tra_pk` from empleado WHERE estado <> 'INACTIVO' and id_empresa_pk = '" + id_empresa_pk_res + "' ", tabla);
                txt_fec_inic_pag_nom.Text = fecha_inicio_pago_res;
                txt_fec_fin_pag_nom.Text = fecha_de_corte_res;
                compararfechas();

                TextBox[] textbox = { txt_nom_emp_nom, txt_cargo_emp_nom, txt_num_afiliac_nom, txt_fecha_ingre_emp_nom, txt_nacion_emp_nom };
                fn.llenartextbox(textbox, dgv_datos_emp);
            dtp_fech_inic_pag.Text = txt_fec_inic_pag_nom.Text;
            dtp_fech_fin_pag.Text = txt_fec_fin_pag_nom.Text;
                dtp_antig_emp.Text = txt_fecha_ingre_emp_nom.Text;

                llenaridempresa();
                llenardireccion();
                llenarJornada();
                salarioNominal();
                llenar_detalle();
                SumaDevengos();
                SumaDeduccion();
                
                CalculosNomina();
            }
            catch
            {
                MessageBox.Show("Error al Cargar los datos", "Favor Verificar que todo este en orden", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            string tabla = "empleado";
            fn.ActualizarGrid(this.dgv_datos_emp, "Select `id_empresa_pk`, `nombre`, `direccion`,  `fecha_ingreso`, `dpi`, `no_afiliacion_igss`, `estado`, `nacionalidad`,  `cargo`, `sueldo`,  `id_empleados_pk`, `id_jornada_tra_pk` from empleado WHERE estado <> 'INACTIVO' and id_empresa_pk = '" + id_empresa_pk_res + "' ", tabla);
        }

        private void btn_anterior_Click_1(object sender, EventArgs e)
        {
            dgv_detalle_nom.Rows.Clear();
            fn.Anterior(dgv_datos_emp);
            TextBox[] textbox = { txt_nom_emp_nom, txt_cargo_emp_nom, txt_num_afiliac_nom, txt_fecha_ingre_emp_nom, txt_nacion_emp_nom };
            fn.llenartextbox(textbox, dgv_datos_emp);
            dtp_fech_inic_pag.Text = txt_fec_inic_pag_nom.Text;
            dtp_fech_fin_pag.Text = txt_fec_fin_pag_nom.Text;
            compararfechas();
            llenaridempresa();
            llenardireccion();
            llenarJornada();
            salarioNominal();
            llenar_detalle();
            SumaDevengos();
            SumaDeduccion();

            CalculosNomina();
        }

        private void btn_siguiente_Click_1(object sender, EventArgs e)
        {
            dgv_detalle_nom.Rows.Clear();
            fn.Siguiente(dgv_datos_emp);
            TextBox[] textbox = { txt_nom_emp_nom, txt_cargo_emp_nom, txt_num_afiliac_nom, txt_fecha_ingre_emp_nom, txt_nacion_emp_nom };
            fn.llenartextbox(textbox, dgv_datos_emp);
            dtp_fech_inic_pag.Text = txt_fec_inic_pag_nom.Text;
            dtp_fech_fin_pag.Text = txt_fec_fin_pag_nom.Text;
            compararfechas();
            llenaridempresa();
            llenardireccion();
            llenarJornada();
            salarioNominal();
            llenar_detalle();
            SumaDevengos();
            SumaDeduccion();

            CalculosNomina();
        }


        public void llenaridempresa()
        {
                Conexionmysql.ObtenerConexion();
            String Codigo = this.dgv_datos_emp.CurrentRow.Cells[0].Value.ToString();
            String Query = "select E.nombre, E.id_empresa_pk, N.nombre from empresa E, empleado N where E.id_empresa_pk = '" + Codigo + "' ";
                OdbcCommand MiComando = new OdbcCommand(Query, Conexionmysql.ObtenerConexion());
            txt_nom_empresa_nom.Text = MiComando.ExecuteScalar().ToString();

                Conexionmysql.Desconectar(); 
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexionmysql.ObtenerConexion();
                string date1 = dtp_fech_inic_pag.Value.ToString("yyyy-MM-dd");
                string date2 = dtp_fech_fin_pag.Value.ToString("yyyy-MM-dd");

                OdbcDataReader consultar;

                String Codigo = this.dgv_datos_emp.CurrentRow.Cells[10].Value.ToString();
                String query1 = "select N.fecha, P.fecha, E.nombre from detalle_nomina N, detalle_planilla_igss P, empleado E where N.id_empleados_pk = E.id_empleados_pk and P.id_empleados_pk = E.id_empleados_pk and N.id_empleados_pk = '" + Codigo + "' and N.fecha BETWEEN '" + date1 + "' and '" + date2 + "' ";
                OdbcCommand Query = new OdbcCommand(query1, Conexionmysql.ObtenerConexion());
                consultar = Query.ExecuteReader();
                if (consultar.Read())
                {
                    MessageBox.Show("Este Registro ya fue almacenado...", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    id_empleados_pk1 = this.dgv_datos_emp.CurrentRow.Cells[10].Value.ToString();
                    txt_dtp_fecha_crea_nom.Text = dtp_fecha_crea_nom.Value.ToString("yyyy-MM-dd");
                    txt_id_nomina_res.Text = id_nomina_pk_res;
                    txt_id_emp_ingreso.Text = id_empleados_pk1;
                    TextBox[] textbox = { txt_salario_nominal, txt_sum_devengo, txt_sum_deduccion, txt_salario_liquido, txt_id_emp_ingreso, txt_id_nomina_res, txt_dtp_fecha_crea_nom };
                    DataTable datos = fn.construirDataTable(textbox);
                    if (datos.Rows.Count == 0)
                    {
                        MessageBox.Show("Hay campos vacios", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string tabla = "detalle_nomina";
                        if (Editar)
                        {
                            fn.modificar(datos, tabla, atributo, Codigo);
                        }
                        else
                        {
                            fn.insertar(datos, tabla);
                            guardar_detalle();
                        }
                        //fn.LimpiarComponentes(this);
                    }

                }
                Conexionmysql.Desconectar();
            }
            catch(Exception ex)
            {
                // MessageBox.Show("Ocurrio un error durante el proceso...", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw ex;
            }
            
        }

        public void llenardireccion()
        {
            Conexionmysql.ObtenerConexion();
            String Codigo = this.dgv_datos_emp.CurrentRow.Cells[0].Value.ToString();
            String Query = "select E.direccion, E.id_empresa_pk, N.nombre from empresa E, empleado N where E.id_empresa_pk = '" + Codigo + "' ";
            OdbcCommand MiComando = new OdbcCommand(Query, Conexionmysql.ObtenerConexion());
            txt_dirr_empr_nom.Text = MiComando.ExecuteScalar().ToString();

            Conexionmysql.Desconectar();
        }

        public void llenarJornada()
        {
            Conexionmysql.ObtenerConexion();
            String Codigo = this.dgv_datos_emp.CurrentRow.Cells[11].Value.ToString();
            String Query = "select J.horas_trabajo, J.jornada, N.nombre from jornada_trabajo J, empleado N where J.id_jornada_tra_pk = '" + Codigo + "' ";
            OdbcCommand MiComando = new OdbcCommand(Query, Conexionmysql.ObtenerConexion());
            txt_jornada_nom.Text = MiComando.ExecuteScalar().ToString();
            Conexionmysql.Desconectar();
        }

        public void salarioNominal()
        {
            Conexionmysql.ObtenerConexion();
            String Codigo = this.dgv_datos_emp.CurrentRow.Cells[11].Value.ToString();
            String Query = "select E.sueldo, E.tipo_sueldo, N.nombre from empleado E, empleado N where E.id_empleados_pk = N.id_empleados_pk and n.id_empleados_pk = '" + Codigo + "' ";
            OdbcCommand MiComando = new OdbcCommand(Query, Conexionmysql.ObtenerConexion());
            txt_salario_nominal.Text = MiComando.ExecuteScalar().ToString();
            Conexionmysql.Desconectar();
        }

        public void compararfechas()
        {
            DateTime fecha1 = Convert.ToDateTime(txt_fec_inic_pag_nom.Text).Date;
            DateTime fecha2 = Convert.ToDateTime(txt_fec_fin_pag_nom.Text).Date;
            double dias = (fecha2 - fecha1).TotalDays;
            txt_perd_liquid_nom.Text = dias.ToString();
        }

        public void llenar_detalle()
        {
            int cont1 = 0;
            id_empleados_pk1 = this.dgv_datos_emp.CurrentRow.Cells[10].Value.ToString();
            string date1 = dtp_fech_inic_pag.Value.ToString("yyyy-MM-dd");
            string date2 = dtp_fech_fin_pag.Value.ToString("yyyy-MM-dd");

            Conexionmysql.ObtenerConexion();
            OdbcDataReader consultar;
            OdbcDataReader consultar2;
            String query1 = "select E.id_devengos_pk, E.nombre, E.detalle, E.cantidad_debengado, N.nombre from devengos E, empleado N where E.id_empleados_pk = N.id_empleados_pk and N.id_empleados_pk = '" + id_empleados_pk1 + "'  and E.fecha BETWEEN '"+ date1 + "' and '" + date2 + "';";
            String query2 = "select P.id_presamo_pk, P.nombre, P.detalle, P.cantidad_deduccion, N.nombre from deducciones P, empleado N where P.id_empleados_pk = N.id_empleados_pk and N.id_empleados_pk = '" + id_empleados_pk1 + "'  and P.fecha BETWEEN '" + date1 + "' and '" + date2 + "';";
            OdbcCommand Query = new OdbcCommand(query1, Conexionmysql.ObtenerConexion());
            OdbcCommand Query2 = new OdbcCommand(query2, Conexionmysql.ObtenerConexion());

            consultar = Query.ExecuteReader();
            consultar2 = Query2.ExecuteReader();

            while (consultar.Read())
            {
                dgv_detalle_nom.Rows.Add(1);
                if (cont1 == 0)
                {
                    id_devengos_pk = consultar.GetString(0);
                    nombre_dev = consultar.GetString(1);
                    detalle_dev = consultar.GetString(2);
                    cantidad_debengado = consultar.GetFloat(3);

                    dgv_detalle_nom.Rows[0].Cells[0].Value = id_devengos_pk;
                    dgv_detalle_nom.Rows[0].Cells[1].Value = nombre_dev;
                    dgv_detalle_nom.Rows[0].Cells[2].Value = detalle_dev;
                    dgv_detalle_nom.Rows[0].Cells[4].Value = cantidad_debengado;
                }
                else
                {
                    id_devengos_pk = consultar.GetString(0);
                    nombre_dev = consultar.GetString(1);
                    detalle_dev = consultar.GetString(2);
                    cantidad_debengado = consultar.GetFloat(3);

                    dgv_detalle_nom.Rows[cont1].Cells[0].Value = id_devengos_pk;
                    dgv_detalle_nom.Rows[cont1].Cells[1].Value = nombre_dev;
                    dgv_detalle_nom.Rows[cont1].Cells[2].Value = detalle_dev;
                    dgv_detalle_nom.Rows[cont1].Cells[4].Value = cantidad_debengado;
                }
                cont1++;
                while (consultar2.Read())
                {
                    dgv_detalle_nom.Rows.Add(1);
                    if (cont1 == 0)
                    {
                        id_presamo_pk = consultar2.GetString(0);
                        nombre_prest = consultar2.GetString(1);
                        detalle_prest = consultar2.GetString(2);
                        cantidad_deduccion = consultar2.GetFloat(3);

                        dgv_detalle_nom.Rows[0].Cells[0].Value = id_presamo_pk;
                        dgv_detalle_nom.Rows[0].Cells[1].Value = nombre_prest;
                        dgv_detalle_nom.Rows[0].Cells[2].Value = detalle_prest;
                        dgv_detalle_nom.Rows[0].Cells[5].Value = cantidad_deduccion;
                    }
                    else
                    {
                        id_presamo_pk = consultar2.GetString(0);
                        nombre_prest = consultar2.GetString(1);
                        detalle_prest = consultar2.GetString(2);
                        cantidad_deduccion = consultar2.GetFloat(3);

                        dgv_detalle_nom.Rows[cont1].Cells[0].Value = id_presamo_pk;
                        dgv_detalle_nom.Rows[cont1].Cells[1].Value = nombre_prest;
                        dgv_detalle_nom.Rows[cont1].Cells[2].Value = detalle_prest;
                        dgv_detalle_nom.Rows[cont1].Cells[5].Value = cantidad_deduccion;
                    }
                    cont1++;
                }
            }
            Conexionmysql.Desconectar();
        }

        public void SumaDevengos()
        {
            double sum = 0;
            for (int i = 0; i < dgv_detalle_nom.Rows.Count; ++i)
            {
                sum += Convert.ToDouble(dgv_detalle_nom.Rows[i].Cells[4].Value);
                
            }
            txt_sum_devengo.Text = sum.ToString("#.###");
        }

        public void SumaDeduccion()
        {
            double sum = 0;
            for (int i = 0; i < dgv_detalle_nom.Rows.Count; ++i)
            {
                sum += Convert.ToDouble(dgv_detalle_nom.Rows[i].Cells[5].Value);
                
            }
            txt_sum_deduccion.Text = sum.ToString("#.###");
        }

        public void CalculosNomina()
        {
            

            salario_nominal = Convert.ToDouble(txt_salario_nominal.Text);
            Salario_ordinario = Convert.ToDouble(txt_salario_nominal.Text);
            dias_trab = Convert.ToDouble(txt_perd_liquid_nom.Text);
            if (txt_sum_devengo.Text == "")
            {
                txt_sum_devengo.Text = "0";
            }
            Salario_extra1 = Convert.ToDouble(txt_sum_devengo.Text);
            
            Salario_extra2 = Salario_extra1 / (dias_trab);

            if (txt_sum_deduccion.Text == "")
            {
                txt_sum_deduccion.Text = "0";
            }
            total_deduccion1 = Convert.ToDouble(txt_sum_deduccion.Text);
            
            total_deduccion2 = total_deduccion1 / (dias_trab);

            Subtotal = salario_nominal + Salario_extra2;
            IGSS = Subtotal * (0.0483);

            Base_anual = salario_nominal * 12;
            Liquidacion1 = salario_nominal;
            Bono14_1 = Salario_ordinario;
            bono_I = Salario_ordinario * (0.33333333);
            total_isr = Base_anual + Liquidacion1 + Bono14_1 + bono_I + Salario_extra2;

            txt_base_anual.Text = Base_anual.ToString("#.###");
            txt_liquid_isr.Text = Liquidacion1.ToString("#.###");
            txt_bono14_isr.Text = Bono14_1.ToString("#.###");
            txt_bonoI_isr.Text = bono_I.ToString("#.###");
            txt_salar_extr_isr.Text = Salario_extra2.ToString("#.###");
            txt_total_isr.Text = total_isr.ToString("#.###");

            Minimum_Vital = 48000;
            Igss_anual = IGSS * 12;
            Igss_sal_extra = Salario_extra2 * (0.0483);
            total_egresos = Minimum_Vital + Liquidacion1 + Bono14_1 + Igss_anual + Igss_sal_extra + total_deduccion2;

            txt_minim_vit_egres.Text = Minimum_Vital.ToString("#.###");
            txt_liquid_egres.Text = Liquidacion1.ToString("#.###");
            txt_bono14_egres.Text = Bono14_1.ToString("#.###");
            txt_igss_anual_egres.Text = Igss_anual.ToString("#.###");
            txt_igss_sal_extr_egres.Text = Igss_sal_extra.ToString("#.###");
            txt_total_egres.Text = total_egresos.ToString("#.###");

            Renta_imponible = total_isr - total_egresos;
            renta_isr = Renta_imponible / 20;
            Isr_2 = renta_isr / 12;
            total_descuentos = Isr_2 + IGSS;
            Bonificacion = 250;
            total_ingres = Bonificacion + Subtotal;
            salario_liq = total_ingres - total_descuentos;

            txt_renta_imponb.Text = Renta_imponible.ToString("#.###");
            txt_disponib_rent.Text = renta_isr.ToString("#.###");
            txt_isr_rent.Text = Isr_2.ToString("#.###");
            txt_total_descuent.Text = total_descuentos.ToString("#.###");
            txt_bonific_rent.Text = Bonificacion.ToString("#.###");
            txt_total_ingres_rent.Text = total_ingres.ToString("#.###");
            txt_salario_liquido.Text = salario_liq.ToString("#.###");

        }

        public void guardar_detalle()
        {
            txt_id_planilla_igss.Text = "1";
            id_empleados_pk1 = this.dgv_datos_emp.CurrentRow.Cells[10].Value.ToString();
            sueldo_base_emp = this.dgv_datos_emp.CurrentRow.Cells[9].Value.ToString();
            txt_id_emp_ingreso.Text = id_empleados_pk1;
            txt_sueldo_detalle_igss.Text = sueldo_base_emp;
            txt_igss_pagar_detalle.Text = IGSS.ToString("#.##");
            txt_dtp_fecha_crea_nom.Text = dtp_fecha_crea_nom.Value.ToString("yyyy-MM-dd");


            TextBox[] textbox = { txt_id_planilla_igss, txt_id_emp_ingreso, txt_sueldo_detalle_igss, txt_igss_pagar_detalle, txt_dtp_fecha_crea_nom };
            DataTable datos = fn.construirDataTable(textbox);
            if (datos.Rows.Count == 0)
            {
                //MessageBox.Show("Hay campos vacios", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string tabla = "detalle_planilla_igss";
                if (Editar)
                {
                    fn.modificar(datos, tabla, atributo, Codigo);
                }
                else
                {
                    fn.insertar(datos, tabla);
                }
                //fn.LimpiarComponentes(this);
            }
        }




    }
}
