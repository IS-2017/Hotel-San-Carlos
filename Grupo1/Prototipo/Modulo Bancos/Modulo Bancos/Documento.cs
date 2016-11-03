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
using System.Data.Odbc;
using dllconsultas;
using seguridad;

namespace Modulo_Bancos
{
    public partial class Documento : Form
    {
        private static string id_form = "16101";
        FuncionesNavegador.CapaNegocio fn = new FuncionesNavegador.CapaNegocio();
        operaciones op = new operaciones();
        Boolean Editar;
        String Codigo;
        String atributo;
        DataGridView dg;
        Validar val;
        bitacora bita = new bitacora();
        DataTable seg = seguridad.ObtenerPermisos.Permisos(seguridad.Conexion.User, id_form);

        public Documento()
        {
            InitializeComponent();
        }

        public void validacion_sololetras(KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsLetter(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                    MessageBox.Show("Llene el campo con letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                // MessageBox.Show("Llene el campo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void validacion_solonumeros(KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;

                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                    MessageBox.Show("Llene el campo con numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                //MessageBox.Show("Llene el campo ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        public void validacion_solonumerocondosdecimales(KeyPressEventArgs e,TextBox textbox)
        {
            try
            {
                if (e.KeyChar == 8)
                {
                    e.Handled = false;
                    return;
                }


                bool IsDec = false;
                int nroDec = 0;

                for (int i = 0; i < textbox.Text.Length; i++)
                {
                    if (textbox.Text[i] == '.')
                        IsDec = true;

                    if (IsDec && nroDec++ >= 2)
                    {
                        e.Handled = true;
                        return;
                    }
                }

                if (e.KeyChar >= 48 && e.KeyChar <= 57)
                {
                    e.Handled = false;
                }
                else if (e.KeyChar == 46)
                {
                    e.Handled = (IsDec) ? true : false;
                }
                else
                {
                    MessageBox.Show("Llene el campo con numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Handled = true;
                }
                    
            }
            catch
            {
                //MessageBox.Show("Llene el campo ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        public Documento(DataGridView gb,String id_documento_pk,String conciliado, String fecha, String valor_total, String destinatario, String no_documento, String descripcion, String id_cuenta_bancaria_pk, String id_tipo_documento, String id_cuenta_pk, String id_proveedor_pk,Boolean Editar1)
        {
            this.dg = gb;
            this.Editar = Editar1;
            InitializeComponent();
            atributo = "id_documento_pk";
            this.Codigo = id_documento_pk;
            if(Editar == true)
            {
                if (id_tipo_documento == "1")
                {
                    this.txt_conciliado_dep.Text = conciliado; cbo_conciliado_dep.Text = txt_conciliado_dep.Text;
                    this.txt_fecha_dep.Text = fecha; dateTimePicker1.Text = txt_fecha_dep.Text;
                    this.txt_monto_dep.Text = valor_total;
                    this.txt_destinatario_dep.Text = destinatario;
                    this.txt_no_documento_dep.Text = no_documento;
                    this.txt_descripcion_dep.Text = descripcion;
                    this.txt_cuenta_bancaria_dep.Text = id_cuenta_bancaria_pk; cbo_cuenta_bancaria_dep.Text = txt_cuenta_bancaria_dep.Text;
                    tabControl.SelectedTab = tabPage1;
                }
                else
                {
                    if (id_tipo_documento == "2")
                    {
                        this.txt_conciliado_che.Text = conciliado; cbo_conciliado_che.Text = txt_conciliado_che.Text;
                        this.txt_fecha_che.Text = fecha; dateTimePicker2.Text = txt_fecha_che.Text;
                        this.txt_monto_che.Text = valor_total;
                        this.txt_destinatario_che.Text = destinatario;
                        this.txt_no_documento_che.Text = no_documento;
                        this.txt_descripcion_che.Text = descripcion;
                        this.txt_cuenta_bancaria_che.Text = id_cuenta_bancaria_pk; cbo_cuenta_bancaria_che.Text = txt_cuenta_bancaria_che.Text;
                        tabControl.SelectedTab = tabPage2;
                    }
                    else
                    {
                        if (id_tipo_documento == "3")
                        {
                            this.txt_conciliado_nc.Text = conciliado; cbo_conciliado_nc.Text = txt_conciliado_nc.Text;
                            this.txt_fecha_nc.Text = fecha; dateTimePicker3.Text = txt_fecha_nc.Text;
                            this.txt_monto_nc.Text = valor_total;
                            this.txt_destinatario_nc.Text = destinatario;
                            this.txt_no_documento_nc.Text = no_documento;
                            this.txt_descripcion_nc.Text = descripcion;
                            this.txt_cuenta_bancaria_nc.Text = id_cuenta_bancaria_pk; cbo_cuenta_bancaria_nc.Text = txt_cuenta_bancaria_nc.Text;
                            this.txt_cuenta_corriente_nc.Text = id_cuenta_pk; cbo_cuenta_corriente_nc.Text = txt_cuenta_corriente_nc.Text;
                            tabControl.SelectedTab = tabPage3;
                        }
                        else
                        {
                            if (id_tipo_documento == "4")
                            {
                                this.txt_conciliado_nb.Text = conciliado; cbo_conciliado_nb.Text = txt_conciliado_nb.Text;
                                this.txt_fecha_nb.Text = fecha; dateTimePicker4.Text = txt_fecha_nb.Text;
                                this.txt_monto_nb.Text = valor_total;
                                this.txt_destinatario_nb.Text = destinatario;
                                this.txt_no_documento_nb.Text = no_documento;
                                this.txt_descripcion_nb.Text = descripcion;
                                this.txt_cuenta_bancaria_nb.Text = id_cuenta_bancaria_pk; cbo_cuenta_bancaria_nb.Text = txt_cuenta_bancaria_nb.Text;
                                this.txt_cuenta_corriente_nb.Text = id_cuenta_pk; cbo_cuenta_corriente_nb.Text = txt_cuenta_corriente_nb.Text;
                                this.txt_id_proveedor_nb.Text = id_proveedor_pk; cbo_id_proveedor_pk_nb.Text = txt_id_proveedor_nb.Text;
                                tabControl.SelectedTab = tabPage4;
                            }
                        }
                    }
                }
            }
        }

        public void EditarDobleClick()
        {
            
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string tabla = "documento";
            op.ejecutar(this.dg, tabla);
        }

        private void cbo_empre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        public void llenarCboCuentaBancariaDeposito()
        {
            //se realiza la conexión a la base de datos
            Ayuda.ObtenerConexion();
            //se inicia un DataSet
            DataSet ds = new DataSet();
            //se indica la consulta en sql
            String Query = "select id_cuenta_bancaria_pk,id_empresa_pk,nombre_banco,no_cuenta from cuenta_bancaria";
            OdbcDataAdapter dad = new OdbcDataAdapter(Query, Ayuda.ObtenerConexion());
            //se indica con quu tabla se llena
            dad.Fill(ds, "cuenta_bancaria");
            cbo_cuenta_bancaria_dep.DataSource = ds.Tables[0].DefaultView;
            //indicamos el valor de los miembros
            cbo_cuenta_bancaria_dep.ValueMember = ("id_cuenta_bancaria_pk");
            //se indica el valor a desplegar en el combobox
            DataTable dt = ds.Tables[0];
            dt.Columns.Add("NewColumn", typeof(string));
            foreach (DataRow dr in dt.Rows)
            {
                dr["no_cuenta"] = dr["id_cuenta_bancaria_pk"].ToString() + "|" + dr["id_empresa_pk"].ToString() + "|" + dr["nombre_banco"].ToString() + "|" + dr["no_cuenta"].ToString();
            }
            cbo_cuenta_bancaria_dep.DataSource = dt;
            cbo_cuenta_bancaria_dep.DisplayMember = "no_cuenta";
        }

        public void llenarCboCuentaBancariaCheque()
        {
            //se realiza la conexión a la base de datos
            Ayuda.ObtenerConexion();
            //se inicia un DataSet
            DataSet ds = new DataSet();
            //se indica la consulta en sql
            String Query = "select id_cuenta_bancaria_pk,id_empresa_pk,nombre_banco,no_cuenta from cuenta_bancaria";
            OdbcDataAdapter dad = new OdbcDataAdapter(Query, Ayuda.ObtenerConexion());
            //se indica con quu tabla se llena
            dad.Fill(ds, "cuenta_bancaria");
            cbo_cuenta_bancaria_che.DataSource = ds.Tables[0].DefaultView;
            //indicamos el valor de los miembros
            cbo_cuenta_bancaria_che.ValueMember = ("id_cuenta_bancaria_pk");
            //se indica el valor a desplegar en el combobox
            DataTable dt = ds.Tables[0];
            dt.Columns.Add("NewColumn", typeof(string));
            foreach (DataRow dr in dt.Rows)
            {
                dr["no_cuenta"] = dr["id_cuenta_bancaria_pk"].ToString() + "|" + dr["id_empresa_pk"].ToString() + "|" + dr["nombre_banco"].ToString() + "|" + dr["no_cuenta"].ToString();
            }
            cbo_cuenta_bancaria_che.DataSource = dt;
            cbo_cuenta_bancaria_che.DisplayMember = "no_cuenta";
        }

        public void llenarCboCuentaBancariaNC()
        {
            //se realiza la conexión a la base de datos
            Ayuda.ObtenerConexion();
            //se inicia un DataSet
            DataSet ds = new DataSet();
            //se indica la consulta en sql
            String Query = "select id_cuenta_bancaria_pk,id_empresa_pk,nombre_banco,no_cuenta from cuenta_bancaria";
            OdbcDataAdapter dad = new OdbcDataAdapter(Query, Ayuda.ObtenerConexion());
            //se indica con quu tabla se llena
            dad.Fill(ds, "cuenta_bancaria");
            cbo_cuenta_bancaria_nc.DataSource = ds.Tables[0].DefaultView;
            //indicamos el valor de los miembros
            cbo_cuenta_bancaria_nc.ValueMember = ("id_cuenta_bancaria_pk");
            //se indica el valor a desplegar en el combobox
            DataTable dt = ds.Tables[0];
            dt.Columns.Add("NewColumn", typeof(string));
            foreach (DataRow dr in dt.Rows)
            {
                dr["no_cuenta"] = dr["id_cuenta_bancaria_pk"].ToString() + "|" + dr["id_empresa_pk"].ToString() + "|" + dr["nombre_banco"].ToString() + "|" + dr["no_cuenta"].ToString();
            }
            cbo_cuenta_bancaria_nc.DataSource = dt;
            cbo_cuenta_bancaria_nc.DisplayMember = "no_cuenta";
        }

        public void llenarCboCuentaBancariaNB()
        {
            //se realiza la conexión a la base de datos
            Ayuda.ObtenerConexion();
            //se inicia un DataSet
            DataSet ds = new DataSet();
            //se indica la consulta en sql
            String Query = "select id_cuenta_bancaria_pk,id_empresa_pk,nombre_banco,no_cuenta from cuenta_bancaria";
            OdbcDataAdapter dad = new OdbcDataAdapter(Query, Ayuda.ObtenerConexion());
            //se indica con quu tabla se llena
            dad.Fill(ds, "cuenta_bancaria");
            cbo_cuenta_bancaria_nb.DataSource = ds.Tables[0].DefaultView;
            //indicamos el valor de los miembros
            cbo_cuenta_bancaria_nb.ValueMember = ("id_cuenta_bancaria_pk");
            //se indica el valor a desplegar en el combobox
            DataTable dt = ds.Tables[0];
            dt.Columns.Add("NewColumn", typeof(string));
            foreach (DataRow dr in dt.Rows)
            {
                dr["no_cuenta"] = dr["id_cuenta_bancaria_pk"].ToString() + "|" + dr["id_empresa_pk"].ToString() + "|" + dr["nombre_banco"].ToString() + "|" + dr["no_cuenta"].ToString();
            }
            cbo_cuenta_bancaria_nb.DataSource = dt;
            cbo_cuenta_bancaria_nb.DisplayMember = "no_cuenta";
        }

        public void llenarCboCuentaCorrienteNC()
        {
            //se realiza la conexión a la base de datos
            Ayuda.ObtenerConexion();
            //se inicia un DataSet
            DataSet ds = new DataSet();
            //se indica la consulta en sql
            String Query = "select id_cuenta_pk,id_proveedor_pk from cuenta_corriente_por_pagar";
            OdbcDataAdapter dad = new OdbcDataAdapter(Query, Ayuda.ObtenerConexion());
            //se indica con quu tabla se llena
            dad.Fill(ds, "cuenta_corriente_por_pagar");
            cbo_cuenta_corriente_nc.DataSource = ds.Tables[0].DefaultView;
            //indicamos el valor de los miembros
            cbo_cuenta_corriente_nc.ValueMember = ("id_cuenta_pk");
            //se indica el valor a desplegar en el combobox
            DataTable dt = ds.Tables[0];
            dt.Columns.Add("NewColumn", typeof(string));
            foreach (DataRow dr in dt.Rows)
            {
                dr["id_cuenta_pk"] = dr["id_cuenta_pk"].ToString();
            }
            cbo_cuenta_corriente_nc.DataSource = dt;
            cbo_cuenta_corriente_nc.DisplayMember = "id_cuenta_pk";
        }

        public void llenarCboCuentaCorrienteNB()
        {
            //se realiza la conexión a la base de datos
            Ayuda.ObtenerConexion();
            //se inicia un DataSet
            DataSet ds = new DataSet();
            //se indica la consulta en sql
            String Query = "select id_cuenta_pk,id_proveedor_pk from cuenta_corriente_por_pagar";
            OdbcDataAdapter dad = new OdbcDataAdapter(Query, Ayuda.ObtenerConexion());
            //se indica con quu tabla se llena
            dad.Fill(ds, "cuenta_corriente_por_pagar");
            cbo_cuenta_corriente_nb.DataSource = ds.Tables[0].DefaultView;
            //indicamos el valor de los miembros
            cbo_cuenta_corriente_nb.ValueMember = ("id_cuenta_pk");
            //se indica el valor a desplegar en el combobox
            DataTable dt = ds.Tables[0];
            dt.Columns.Add("NewColumn", typeof(string));
            foreach (DataRow dr in dt.Rows)
            {
                dr["id_cuenta_pk"] = dr["id_cuenta_pk"].ToString();
            }
            cbo_cuenta_corriente_nb.DataSource = dt;
            cbo_cuenta_corriente_nb.DisplayMember = "id_cuenta_pk";
        }

        public void llenarCboProveedorNB()
        {
            //se realiza la conexión a la base de datos
            Ayuda.ObtenerConexion();
            //se inicia un DataSet
            DataSet ds = new DataSet();
            //se indica la consulta en sql
            String Query = "select id_proveedor_pk,nombre_proveedor from proveedor";
            OdbcDataAdapter dad = new OdbcDataAdapter(Query, Ayuda.ObtenerConexion());
            //se indica con quu tabla se llena
            dad.Fill(ds, "proveedor");
            cbo_id_proveedor_pk_nb.DataSource = ds.Tables[0].DefaultView;
            //indicamos el valor de los miembros
            cbo_id_proveedor_pk_nb.ValueMember = ("id_proveedor_pk");
            //se indica el valor a desplegar en el combobox
            DataTable dt = ds.Tables[0];
            dt.Columns.Add("NewColumn", typeof(string));
            foreach (DataRow dr in dt.Rows)
            {
                dr["nombre_proveedor"] = dr["nombre_proveedor"].ToString() + "|" + dr["id_proveedor_pk"].ToString();
            }
            cbo_id_proveedor_pk_nb.DataSource = dt;
            cbo_id_proveedor_pk_nb.DisplayMember = "nombre_proveedor";
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            DataRow permiso = seg.Rows[0];
            int insertar = Convert.ToInt32(permiso[0]);
            if (tabControl.SelectedTab == tabPage1)
            {
                try
                {
                    txt_fecha_dep.Text = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                    txt_cuenta_bancaria_dep.Text = cbo_cuenta_bancaria_dep.SelectedValue.ToString();
                    txt_conciliado_dep.Text = cbo_conciliado_dep.Text;
                    TextBox[] textbox = {txt_descripcion_dep,txt_conciliado_dep,txt_cuenta_bancaria_dep,txt_destinatario_dep,txt_fecha_dep,txt_monto_dep,txt_no_documento_dep,txt_tipo_documento_dep};
                    DataTable datos = fn.construirDataTable(textbox);
                    if (datos.Rows.Count == 0)
                    {
                        MessageBox.Show("Hay campos vacios", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string tabla = "documento";
                        if (Editar)
                        {
                            fn.modificar(datos, tabla, atributo, Codigo);
                            bita.Modificar("Modificacion de documento con el numero: " + txt_no_documento_dep.Text, "documento");
                            if (insertar == 0)
                            {
                                btn_guardar.Enabled = false;
                            }
                            txt_descripcion_dep.Text = ""; txt_conciliado_dep.Text = ""; txt_cuenta_bancaria_dep.Text = ""; txt_destinatario_dep.Text = ""; txt_fecha_dep.Text = ""; txt_monto_dep.Text = ""; txt_no_documento_dep.Text = "";
                        }
                        else
                        {
                            fn.insertar(datos, tabla);
                            bita.Insertar("Insercion de documento con el numero: " + txt_no_documento_dep.Text, "documento");
                            txt_descripcion_dep.Text = ""; txt_conciliado_dep.Text = ""; txt_cuenta_bancaria_dep.Text=""; txt_destinatario_dep.Text=""; txt_fecha_dep.Text=""; txt_monto_dep.Text=""; txt_no_documento_dep.Text="";
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Ocurrio un error durante el proceso...", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (tabControl.SelectedTab == tabPage2)
                {
                    try
                    {
                        txt_fecha_che.Text = dateTimePicker2.Value.ToString("yyyy-MM-dd");
                        txt_cuenta_bancaria_che.Text = cbo_cuenta_bancaria_che.SelectedValue.ToString();
                        txt_conciliado_che.Text = cbo_conciliado_che.Text;
                        TextBox[] textbox = { txt_descripcion_che,txt_conciliado_che, txt_cuenta_bancaria_che, txt_destinatario_che, txt_fecha_che, txt_monto_che, txt_no_documento_che,txt_tipo_documento_che };
                        DataTable datos = fn.construirDataTable(textbox);
                        if (datos.Rows.Count == 0)
                        {
                            MessageBox.Show("Hay campos vacios", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string tabla = "documento";
                            if (Editar)
                            {
                                fn.modificar(datos, tabla, atributo, Codigo);
                                bita.Modificar("Modificacion de documento con el numero: " + txt_no_documento_che.Text, "documento");
                                if (insertar == 0)
                                {
                                    btn_guardar.Enabled = false;
                                }
                                txt_descripcion_che.Text = ""; txt_conciliado_che.Text = ""; txt_cuenta_bancaria_che.Text = ""; txt_destinatario_che.Text = ""; txt_fecha_che.Text = ""; txt_monto_che.Text = ""; txt_no_documento_che.Text = "";
                            }
                            else
                            {
                                fn.insertar(datos, tabla);
                                bita.Insertar("Insertar de documento con el numero: " + txt_no_documento_che.Text, "documento");
                                txt_descripcion_che.Text = ""; txt_conciliado_che.Text = ""; txt_cuenta_bancaria_che.Text = ""; txt_destinatario_che.Text = ""; txt_fecha_che.Text = ""; txt_monto_che.Text = ""; txt_no_documento_che.Text = "";
                            }
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Ocurrio un error durante el proceso...", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (tabControl.SelectedTab == tabPage3)
                    {
                        try
                        {
                            txt_fecha_nc.Text = dateTimePicker3.Value.ToString("yyyy-MM-dd");
                            txt_cuenta_bancaria_nc.Text = cbo_cuenta_bancaria_nc.SelectedValue.ToString();
                            txt_conciliado_nc.Text = cbo_conciliado_nc.Text;
                            txt_cuenta_corriente_nc.Text = cbo_cuenta_bancaria_nc.SelectedValue.ToString();
                            TextBox[] textbox = { txt_descripcion_nc, txt_conciliado_nc, txt_cuenta_bancaria_nc, txt_destinatario_nc, txt_fecha_nc, txt_monto_nc, txt_no_documento_nc, txt_tipo_documento_nc,txt_cuenta_corriente_nc };
                            DataTable datos = fn.construirDataTable(textbox);
                            if (datos.Rows.Count == 0)
                            {
                                MessageBox.Show("Hay campos vacios", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string tabla = "documento";
                                if (Editar)
                                {
                                    fn.modificar(datos, tabla, atributo, Codigo);
                                    bita.Modificar("Modificacion de documento con el numero: " + txt_no_documento_nc.Text, "documento");
                                    if (insertar == 0)
                                    {
                                        btn_guardar.Enabled = false;
                                    }
                                    txt_descripcion_nc.Text = ""; txt_conciliado_nc.Text = ""; txt_cuenta_bancaria_nc.Text = ""; txt_destinatario_nc.Text = ""; txt_fecha_nc.Text = ""; txt_monto_nc.Text = ""; txt_no_documento_nc.Text = ""; txt_cuenta_corriente_nc.Text = "";
                                }
                                else
                                {
                                    fn.insertar(datos, tabla);
                                    bita.Insertar("Insertar de documento con el numero: " + txt_no_documento_nc.Text, "documento");
                                    txt_descripcion_nc.Text = ""; txt_conciliado_nc.Text = ""; txt_cuenta_bancaria_nc.Text = ""; txt_destinatario_nc.Text = ""; txt_fecha_nc.Text = ""; txt_monto_nc.Text = ""; txt_no_documento_nc.Text = ""; txt_cuenta_corriente_nc.Text = "";
                                }
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Ocurrio un error durante el proceso...", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        if (tabControl.SelectedTab == tabPage4)
                        {
                            try
                            {
                                txt_fecha_nb.Text = dateTimePicker4.Value.ToString("yyyy-MM-dd");
                                txt_cuenta_bancaria_nb.Text = cbo_cuenta_bancaria_nb.SelectedValue.ToString();
                                txt_conciliado_nb.Text = cbo_conciliado_nb.Text;
                                txt_cuenta_corriente_nb.Text = cbo_cuenta_bancaria_nb.SelectedValue.ToString();
                                txt_id_proveedor_nb.Text = cbo_id_proveedor_pk_nb.SelectedValue.ToString();
                                TextBox[] textbox = { txt_descripcion_nb, txt_conciliado_nb, txt_cuenta_bancaria_nb, txt_destinatario_nb, txt_fecha_nb, txt_monto_nb, txt_no_documento_nb, txt_tipo_documento_nb, txt_cuenta_corriente_nb,txt_id_proveedor_nb };
                                DataTable datos = fn.construirDataTable(textbox);
                                if (datos.Rows.Count == 0)
                                {
                                    MessageBox.Show("Hay campos vacios", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    string tabla = "documento";
                                    if (Editar)
                                    {
                                        fn.modificar(datos, tabla, atributo, Codigo);
                                        bita.Modificar("Modificacion de documento con el numero: " + txt_no_documento_nb.Text, "documento");
                                        if (insertar == 0)
                                        {
                                            btn_guardar.Enabled = false;
                                        }
                                        txt_descripcion_nb.Text = ""; txt_conciliado_nb.Text = ""; txt_cuenta_bancaria_nb.Text = ""; txt_destinatario_nb.Text = ""; txt_fecha_nb.Text = ""; txt_monto_nb.Text = ""; txt_no_documento_nb.Text = ""; txt_cuenta_corriente_nb.Text = ""; txt_id_proveedor_nb.Text = "";
                                    }
                                    else
                                    {
                                        fn.insertar(datos, tabla);
                                        bita.Insertar("Modificacion de documento con el numero: " + txt_no_documento_nb.Text, "documento");
                                        txt_descripcion_nb.Text = ""; txt_conciliado_nb.Text = ""; txt_cuenta_bancaria_nb.Text = ""; txt_destinatario_nb.Text = ""; txt_fecha_nb.Text = ""; txt_monto_nb.Text = ""; txt_no_documento_nb.Text = ""; txt_cuenta_corriente_nb.Text = ""; txt_id_proveedor_nb.Text = "";
                                    }
                                }
                            }
                            catch
                            {
                                MessageBox.Show("Ocurrio un error durante el proceso...", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            Editar = false;
            fn.ActivarControles(gpb_navegador);
            txt_descripcion_che.Enabled = true; txt_descripcion_dep.Enabled = true; txt_descripcion_nc.Enabled = true; txt_descripcion_nb.Enabled = true;
            txt_destinatario_che.Enabled = true; txt_destinatario_dep.Enabled = true; txt_destinatario_nc.Enabled = true; txt_destinatario_nb.Enabled = true;
            txt_monto_nb.Enabled = true; txt_monto_nc.Enabled = true; txt_monto_dep.Enabled = true; txt_monto_che.Enabled = true;
            txt_no_documento_che.Enabled = true; txt_no_documento_nb.Enabled = true; txt_no_documento_nc.Enabled = true; txt_no_documento_dep.Enabled = true;
            cbo_conciliado_che.Enabled = true; cbo_conciliado_nc.Enabled = true; cbo_conciliado_nb.Enabled = true; cbo_conciliado_dep.Enabled = true;
            cbo_cuenta_bancaria_che.Enabled = true; cbo_cuenta_bancaria_dep.Enabled = true; cbo_cuenta_bancaria_nc.Enabled = true; cbo_cuenta_bancaria_nb.Enabled = true;
            cbo_cuenta_corriente_nb.Enabled = true; cbo_cuenta_corriente_nc.Enabled = true;
            cbo_id_proveedor_pk_nb.Enabled = true;
            if (tabControl.SelectedTab == tabPage1)
            {
                txt_descripcion_dep.Text = ""; txt_conciliado_dep.Text = ""; txt_cuenta_bancaria_dep.Text = ""; txt_destinatario_dep.Text = ""; txt_fecha_dep.Text = ""; txt_monto_dep.Text = ""; txt_no_documento_dep.Text = "";
            }
            else
            {
                if (tabControl.SelectedTab == tabPage1)
                {
                    txt_descripcion_che.Text = ""; txt_conciliado_che.Text = ""; txt_cuenta_bancaria_che.Text = ""; txt_destinatario_che.Text = ""; txt_fecha_che.Text = ""; txt_monto_che.Text = ""; txt_no_documento_che.Text = "";
                }
                else
                {
                    if (tabControl.SelectedTab == tabPage3)
                    {
                        txt_descripcion_nc.Text = ""; txt_conciliado_nc.Text = ""; txt_cuenta_bancaria_nc.Text = ""; txt_destinatario_nc.Text = ""; txt_fecha_nc.Text = ""; txt_monto_nc.Text = ""; txt_no_documento_nc.Text = ""; txt_cuenta_corriente_nc.Text = "";
                    }
                    else
                    {
                        if (tabControl.SelectedTab == tabPage4)
                        {
                            txt_descripcion_nb.Text = ""; txt_conciliado_nb.Text = ""; txt_cuenta_bancaria_nb.Text = ""; txt_destinatario_nb.Text = ""; txt_fecha_nb.Text = ""; txt_monto_nb.Text = ""; txt_no_documento_nb.Text = ""; txt_cuenta_corriente_nb.Text = ""; txt_id_proveedor_nb.Text = "";
                        }
                    }
                }
            }
        }

        private void Documento_Load(object sender, EventArgs e)
        {
            fn.desactivarPermiso(seg, btn_guardar, btn_eliminar, btn_editar, btn_nuevo, btn_cancelar, btn_actualizar, btn_buscar, btn_anterior, btn_siguiente, btn_primero, btn_ultimo);
            llenarCboCuentaBancariaDeposito();
            llenarCboCuentaBancariaCheque();
            llenarCboCuentaBancariaNC();
            llenarCboCuentaCorrienteNC();
            llenarCboCuentaBancariaNB();
            llenarCboCuentaCorrienteNB();
            llenarCboProveedorNB();
            fn.InhabilitarComponentes(tabControl);
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                Editar = true;
                atributo = "id_documento_pk";
                this.Codigo = this.dg.CurrentRow.Cells[0].Value.ToString();
                btn_guardar.Enabled = true;
                if (this.dg.CurrentRow.Cells[9].Value.ToString() == "1")
                {
                    this.txt_conciliado_dep.Text = this.dg.CurrentRow.Cells[1].Value.ToString(); cbo_conciliado_dep.Text = txt_conciliado_dep.Text;
                    this.txt_fecha_dep.Text = this.dg.CurrentRow.Cells[2].Value.ToString(); dateTimePicker1.Text = txt_fecha_dep.Text;
                    this.txt_monto_dep.Text = this.dg.CurrentRow.Cells[3].Value.ToString();
                    this.txt_destinatario_dep.Text = this.dg.CurrentRow.Cells[4].Value.ToString();
                    this.txt_no_documento_dep.Text = this.dg.CurrentRow.Cells[5].Value.ToString();
                    this.txt_descripcion_dep.Text = this.dg.CurrentRow.Cells[6].Value.ToString();
                    this.txt_cuenta_bancaria_dep.Text = this.dg.CurrentRow.Cells[8].Value.ToString(); cbo_cuenta_bancaria_dep.Text = txt_cuenta_bancaria_dep.Text;
                    tabControl.SelectedTab = tabPage1;
                }
                else
                {
                    if (this.dg.CurrentRow.Cells[9].Value.ToString() == "2")
                    {
                        this.txt_conciliado_che.Text = this.dg.CurrentRow.Cells[1].Value.ToString(); cbo_conciliado_che.Text = txt_conciliado_che.Text;
                        this.txt_fecha_che.Text = this.dg.CurrentRow.Cells[2].Value.ToString(); dateTimePicker2.Text = txt_fecha_che.Text;
                        this.txt_monto_che.Text = this.dg.CurrentRow.Cells[3].Value.ToString();
                        this.txt_destinatario_che.Text = this.dg.CurrentRow.Cells[4].Value.ToString();
                        this.txt_no_documento_che.Text = this.dg.CurrentRow.Cells[5].Value.ToString();
                        this.txt_descripcion_che.Text = this.dg.CurrentRow.Cells[6].Value.ToString();
                        this.txt_cuenta_bancaria_che.Text = this.dg.CurrentRow.Cells[8].Value.ToString(); cbo_cuenta_bancaria_che.Text = txt_cuenta_bancaria_che.Text;
                        tabControl.SelectedTab = tabPage2;
                    }
                    else
                    {
                        if (this.dg.CurrentRow.Cells[9].Value.ToString() == "3")
                        {
                            this.txt_conciliado_nc.Text = this.dg.CurrentRow.Cells[1].Value.ToString(); cbo_conciliado_nc.Text = txt_conciliado_nc.Text;
                            this.txt_fecha_nc.Text = this.dg.CurrentRow.Cells[2].Value.ToString(); dateTimePicker3.Text = txt_fecha_nc.Text;
                            this.txt_monto_nc.Text = this.dg.CurrentRow.Cells[3].Value.ToString();
                            this.txt_destinatario_nc.Text = this.dg.CurrentRow.Cells[4].Value.ToString();
                            this.txt_no_documento_nc.Text = this.dg.CurrentRow.Cells[5].Value.ToString();
                            this.txt_descripcion_nc.Text = this.dg.CurrentRow.Cells[6].Value.ToString();
                            this.txt_cuenta_bancaria_nc.Text = this.dg.CurrentRow.Cells[8].Value.ToString(); cbo_cuenta_bancaria_nc.Text = txt_cuenta_bancaria_nc.Text;
                            this.txt_cuenta_corriente_nc.Text = this.dg.CurrentRow.Cells[10].Value.ToString(); cbo_cuenta_corriente_nc.Text = txt_cuenta_corriente_nc.Text;
                            tabControl.SelectedTab = tabPage3;
                        }
                        else
                        {
                            if (this.dg.CurrentRow.Cells[9].Value.ToString() == "4")
                            {
                                this.txt_conciliado_nb.Text = this.dg.CurrentRow.Cells[1].Value.ToString(); cbo_conciliado_nb.Text = txt_conciliado_nb.Text;
                                this.txt_fecha_nb.Text = this.dg.CurrentRow.Cells[2].Value.ToString(); dateTimePicker4.Text = txt_fecha_nb.Text;
                                this.txt_monto_nb.Text = this.dg.CurrentRow.Cells[3].Value.ToString();
                                this.txt_destinatario_nb.Text = this.dg.CurrentRow.Cells[4].Value.ToString();
                                this.txt_no_documento_nb.Text = this.dg.CurrentRow.Cells[5].Value.ToString();
                                this.txt_descripcion_nb.Text = this.dg.CurrentRow.Cells[6].Value.ToString();
                                this.txt_cuenta_bancaria_nb.Text = this.dg.CurrentRow.Cells[8].Value.ToString(); cbo_cuenta_bancaria_nb.Text = txt_cuenta_bancaria_nb.Text;
                                this.txt_cuenta_corriente_nb.Text = this.dg.CurrentRow.Cells[10].Value.ToString(); cbo_cuenta_corriente_nb.Text = txt_cuenta_corriente_nb.Text;
                                this.txt_id_proveedor_nb.Text = this.dg.CurrentRow.Cells[11].Value.ToString(); cbo_id_proveedor_pk_nb.Text = txt_id_proveedor_nb.Text;
                                tabControl.SelectedTab = tabPage4;
                            }
                        }
                    }
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
            if (this.dg.CurrentRow.Cells[9].Value.ToString() == "1")
            {
                TextBox[] textbox = { txt_conciliado_dep, txt_descripcion_dep, txt_destinatario_dep, txt_fecha_dep, txt_no_documento_dep, txt_cuenta_bancaria_dep, txt_monto_dep };
                fn.llenartextbox(textbox, dg);
                dateTimePicker1.Text = txt_fecha_dep.Text;
                cbo_cuenta_bancaria_dep.Text = txt_cuenta_bancaria_dep.Text;
                cbo_conciliado_dep.Text = txt_conciliado_dep.Text;
                tabControl.SelectedTab = tabPage1;
                txt_descripcion_che.Text = ""; txt_conciliado_che.Text = ""; txt_cuenta_bancaria_che.Text = ""; txt_destinatario_che.Text = ""; txt_fecha_che.Text = ""; txt_monto_che.Text = ""; txt_no_documento_che.Text = "";
                txt_descripcion_nc.Text = ""; txt_conciliado_nc.Text = ""; txt_cuenta_bancaria_nc.Text = ""; txt_destinatario_nc.Text = ""; txt_fecha_nc.Text = ""; txt_monto_nc.Text = ""; txt_no_documento_nc.Text = ""; txt_cuenta_corriente_nc.Text = "";
                txt_descripcion_nb.Text = ""; txt_conciliado_nb.Text = ""; txt_cuenta_bancaria_nb.Text = ""; txt_destinatario_nb.Text = ""; txt_fecha_nb.Text = ""; txt_monto_nb.Text = ""; txt_no_documento_nb.Text = ""; txt_cuenta_corriente_nb.Text = ""; txt_id_proveedor_nb.Text = "";
            }
            else
            {
                if (this.dg.CurrentRow.Cells[9].Value.ToString() == "2")
                {
                    TextBox[] textbox = { txt_conciliado_che, txt_descripcion_che, txt_destinatario_che, txt_fecha_dep, txt_no_documento_che, txt_cuenta_bancaria_che, txt_monto_che };
                    fn.llenartextbox(textbox, dg);
                    dateTimePicker2.Text = txt_fecha_che.Text;
                    cbo_cuenta_bancaria_che.Text = txt_cuenta_bancaria_che.Text;
                    cbo_conciliado_che.Text = txt_conciliado_che.Text;
                    tabControl.SelectedTab = tabPage2;
                    txt_descripcion_dep.Text = ""; txt_conciliado_dep.Text = ""; txt_cuenta_bancaria_dep.Text = ""; txt_destinatario_dep.Text = ""; txt_fecha_dep.Text = ""; txt_monto_dep.Text = ""; txt_no_documento_dep.Text = "";
                    txt_descripcion_nc.Text = ""; txt_conciliado_nc.Text = ""; txt_cuenta_bancaria_nc.Text = ""; txt_destinatario_nc.Text = ""; txt_fecha_nc.Text = ""; txt_monto_nc.Text = ""; txt_no_documento_nc.Text = ""; txt_cuenta_corriente_nc.Text = "";
                    txt_descripcion_nb.Text = ""; txt_conciliado_nb.Text = ""; txt_cuenta_bancaria_nb.Text = ""; txt_destinatario_nb.Text = ""; txt_fecha_nb.Text = ""; txt_monto_nb.Text = ""; txt_no_documento_nb.Text = ""; txt_cuenta_corriente_nb.Text = ""; txt_id_proveedor_nb.Text = "";
                }
                else
                {
                    if (this.dg.CurrentRow.Cells[9].Value.ToString() == "3")
                    {
                        TextBox[] textbox = { txt_conciliado_nc, txt_descripcion_nc, txt_destinatario_nc, txt_fecha_nc, txt_no_documento_nc, txt_cuenta_bancaria_nc, txt_monto_nc, txt_cuenta_corriente_nc };
                        fn.llenartextbox(textbox, dg);
                        dateTimePicker3.Text = txt_fecha_nc.Text;
                        cbo_cuenta_bancaria_nc.Text = txt_cuenta_bancaria_nc.Text;
                        cbo_conciliado_nc.Text = txt_conciliado_nc.Text;
                        cbo_cuenta_corriente_nc.Text = txt_cuenta_corriente_nc.Text;
                        tabControl.SelectedTab = tabPage3;
                        txt_descripcion_dep.Text = ""; txt_conciliado_dep.Text = ""; txt_cuenta_bancaria_dep.Text = ""; txt_destinatario_dep.Text = ""; txt_fecha_dep.Text = ""; txt_monto_dep.Text = ""; txt_no_documento_dep.Text = "";
                        txt_descripcion_che.Text = ""; txt_conciliado_che.Text = ""; txt_cuenta_bancaria_che.Text = ""; txt_destinatario_che.Text = ""; txt_fecha_che.Text = ""; txt_monto_che.Text = ""; txt_no_documento_che.Text = "";
                        txt_descripcion_nb.Text = ""; txt_conciliado_nb.Text = ""; txt_cuenta_bancaria_nb.Text = ""; txt_destinatario_nb.Text = ""; txt_fecha_nb.Text = ""; txt_monto_nb.Text = ""; txt_no_documento_nb.Text = ""; txt_cuenta_corriente_nb.Text = ""; txt_id_proveedor_nb.Text = "";
                    }
                    else
                    {
                        if (this.dg.CurrentRow.Cells[9].Value.ToString() == "4")
                        {
                            TextBox[] textbox = { txt_conciliado_nb, txt_descripcion_nb, txt_destinatario_nb, txt_fecha_nb, txt_no_documento_nb, txt_cuenta_bancaria_nb, txt_monto_nb, txt_cuenta_corriente_nb,txt_id_proveedor_nb };
                            fn.llenartextbox(textbox, dg);
                            dateTimePicker4.Text = txt_fecha_nb.Text;
                            cbo_cuenta_bancaria_nb.Text = txt_cuenta_bancaria_nb.Text;
                            cbo_conciliado_nb.Text = txt_conciliado_nb.Text;
                            cbo_cuenta_corriente_nb.Text = txt_cuenta_corriente_nb.Text;
                            cbo_id_proveedor_pk_nb.Text = txt_id_proveedor_nb.Text;
                            tabControl.SelectedTab = tabPage4;
                            txt_descripcion_che.Text = ""; txt_conciliado_che.Text = ""; txt_cuenta_bancaria_che.Text = ""; txt_destinatario_che.Text = ""; txt_fecha_che.Text = ""; txt_monto_che.Text = ""; txt_no_documento_che.Text = "";
                            txt_descripcion_dep.Text = ""; txt_conciliado_dep.Text = ""; txt_cuenta_bancaria_dep.Text = ""; txt_destinatario_dep.Text = ""; txt_fecha_dep.Text = ""; txt_monto_dep.Text = ""; txt_no_documento_dep.Text = "";
                            txt_descripcion_nc.Text = ""; txt_conciliado_nc.Text = ""; txt_cuenta_bancaria_nc.Text = ""; txt_destinatario_nc.Text = ""; txt_fecha_nc.Text = ""; txt_monto_nc.Text = ""; txt_no_documento_nc.Text = ""; txt_cuenta_corriente_nc.Text = "";
                        }
                    }
                }
            }
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            fn.Siguiente(dg);
            if (this.dg.CurrentRow.Cells[9].Value.ToString() == "1")
            {
                TextBox[] textbox = { txt_conciliado_dep, txt_descripcion_dep, txt_destinatario_dep, txt_fecha_dep, txt_no_documento_dep, txt_cuenta_bancaria_dep, txt_monto_dep };
                fn.llenartextbox(textbox, dg);
                dateTimePicker1.Text = txt_fecha_dep.Text;
                cbo_cuenta_bancaria_dep.Text = txt_cuenta_bancaria_dep.Text;
                cbo_conciliado_dep.Text = txt_conciliado_dep.Text;
                tabControl.SelectedTab = tabPage1;
                txt_descripcion_che.Text = ""; txt_conciliado_che.Text = ""; txt_cuenta_bancaria_che.Text = ""; txt_destinatario_che.Text = ""; txt_fecha_che.Text = ""; txt_monto_che.Text = ""; txt_no_documento_che.Text = "";
                txt_descripcion_nc.Text = ""; txt_conciliado_nc.Text = ""; txt_cuenta_bancaria_nc.Text = ""; txt_destinatario_nc.Text = ""; txt_fecha_nc.Text = ""; txt_monto_nc.Text = ""; txt_no_documento_nc.Text = ""; txt_cuenta_corriente_nc.Text = "";
                txt_descripcion_nb.Text = ""; txt_conciliado_nb.Text = ""; txt_cuenta_bancaria_nb.Text = ""; txt_destinatario_nb.Text = ""; txt_fecha_nb.Text = ""; txt_monto_nb.Text = ""; txt_no_documento_nb.Text = ""; txt_cuenta_corriente_nb.Text = ""; txt_id_proveedor_nb.Text = "";
            }
            else
            {
                if (this.dg.CurrentRow.Cells[9].Value.ToString() == "2")
                {
                    TextBox[] textbox = { txt_conciliado_che, txt_descripcion_che, txt_destinatario_che, txt_fecha_dep, txt_no_documento_che, txt_cuenta_bancaria_che, txt_monto_che };
                    fn.llenartextbox(textbox, dg);
                    dateTimePicker2.Text = txt_fecha_che.Text;
                    cbo_cuenta_bancaria_che.Text = txt_cuenta_bancaria_che.Text;
                    cbo_conciliado_che.Text = txt_conciliado_che.Text;
                    tabControl.SelectedTab = tabPage2;
                    txt_descripcion_dep.Text = ""; txt_conciliado_dep.Text = ""; txt_cuenta_bancaria_dep.Text = ""; txt_destinatario_dep.Text = ""; txt_fecha_dep.Text = ""; txt_monto_dep.Text = ""; txt_no_documento_dep.Text = "";
                    txt_descripcion_nc.Text = ""; txt_conciliado_nc.Text = ""; txt_cuenta_bancaria_nc.Text = ""; txt_destinatario_nc.Text = ""; txt_fecha_nc.Text = ""; txt_monto_nc.Text = ""; txt_no_documento_nc.Text = ""; txt_cuenta_corriente_nc.Text = "";
                    txt_descripcion_nb.Text = ""; txt_conciliado_nb.Text = ""; txt_cuenta_bancaria_nb.Text = ""; txt_destinatario_nb.Text = ""; txt_fecha_nb.Text = ""; txt_monto_nb.Text = ""; txt_no_documento_nb.Text = ""; txt_cuenta_corriente_nb.Text = ""; txt_id_proveedor_nb.Text = "";
                }
                else
                {
                    if (this.dg.CurrentRow.Cells[9].Value.ToString() == "3")
                    {
                        TextBox[] textbox = { txt_conciliado_nc, txt_descripcion_nc, txt_destinatario_nc, txt_fecha_nc, txt_no_documento_nc, txt_cuenta_bancaria_nc, txt_monto_nc, txt_cuenta_corriente_nc };
                        fn.llenartextbox(textbox, dg);
                        dateTimePicker3.Text = txt_fecha_nc.Text;
                        cbo_cuenta_bancaria_nc.Text = txt_cuenta_bancaria_nc.Text;
                        cbo_conciliado_nc.Text = txt_conciliado_nc.Text;
                        cbo_cuenta_corriente_nc.Text = txt_cuenta_corriente_nc.Text;
                        tabControl.SelectedTab = tabPage3;
                        txt_descripcion_dep.Text = ""; txt_conciliado_dep.Text = ""; txt_cuenta_bancaria_dep.Text = ""; txt_destinatario_dep.Text = ""; txt_fecha_dep.Text = ""; txt_monto_dep.Text = ""; txt_no_documento_dep.Text = "";
                        txt_descripcion_che.Text = ""; txt_conciliado_che.Text = ""; txt_cuenta_bancaria_che.Text = ""; txt_destinatario_che.Text = ""; txt_fecha_che.Text = ""; txt_monto_che.Text = ""; txt_no_documento_che.Text = "";
                        txt_descripcion_nb.Text = ""; txt_conciliado_nb.Text = ""; txt_cuenta_bancaria_nb.Text = ""; txt_destinatario_nb.Text = ""; txt_fecha_nb.Text = ""; txt_monto_nb.Text = ""; txt_no_documento_nb.Text = ""; txt_cuenta_corriente_nb.Text = ""; txt_id_proveedor_nb.Text = "";
                    }
                    else
                    {
                        if (this.dg.CurrentRow.Cells[9].Value.ToString() == "4")
                        {
                            TextBox[] textbox = { txt_conciliado_nb, txt_descripcion_nb, txt_destinatario_nb, txt_fecha_nb, txt_no_documento_nb, txt_cuenta_bancaria_nb, txt_monto_nb, txt_cuenta_corriente_nb, txt_id_proveedor_nb };
                            fn.llenartextbox(textbox, dg);
                            dateTimePicker4.Text = txt_fecha_nb.Text;
                            cbo_cuenta_bancaria_nb.Text = txt_cuenta_bancaria_nb.Text;
                            cbo_conciliado_nb.Text = txt_conciliado_nb.Text;
                            cbo_cuenta_corriente_nb.Text = txt_cuenta_corriente_nb.Text;
                            cbo_id_proveedor_pk_nb.Text = txt_id_proveedor_nb.Text;
                            tabControl.SelectedTab = tabPage4;
                            txt_descripcion_che.Text = ""; txt_conciliado_che.Text = ""; txt_cuenta_bancaria_che.Text = ""; txt_destinatario_che.Text = ""; txt_fecha_che.Text = ""; txt_monto_che.Text = ""; txt_no_documento_che.Text = "";
                            txt_descripcion_dep.Text = ""; txt_conciliado_dep.Text = ""; txt_cuenta_bancaria_dep.Text = ""; txt_destinatario_dep.Text = ""; txt_fecha_dep.Text = ""; txt_monto_dep.Text = ""; txt_no_documento_dep.Text = "";
                            txt_descripcion_nc.Text = ""; txt_conciliado_nc.Text = ""; txt_cuenta_bancaria_nc.Text = ""; txt_destinatario_nc.Text = ""; txt_fecha_nc.Text = ""; txt_monto_nc.Text = ""; txt_no_documento_nc.Text = ""; txt_cuenta_corriente_nc.Text = "";
                        }
                    }
                }
            }
        }

        private void btn_primero_Click(object sender, EventArgs e)
        {
            fn.Primero(dg);
            if (this.dg.CurrentRow.Cells[9].Value.ToString() == "1")
            {
                TextBox[] textbox = { txt_conciliado_dep, txt_descripcion_dep, txt_destinatario_dep, txt_fecha_dep, txt_no_documento_dep, txt_cuenta_bancaria_dep, txt_monto_dep };
                fn.llenartextbox(textbox, dg);
                dateTimePicker1.Text = txt_fecha_dep.Text;
                cbo_cuenta_bancaria_dep.Text = txt_cuenta_bancaria_dep.Text;
                cbo_conciliado_dep.Text = txt_conciliado_dep.Text;
                tabControl.SelectedTab = tabPage1;
                txt_descripcion_che.Text = ""; txt_conciliado_che.Text = ""; txt_cuenta_bancaria_che.Text = ""; txt_destinatario_che.Text = ""; txt_fecha_che.Text = ""; txt_monto_che.Text = ""; txt_no_documento_che.Text = "";
                txt_descripcion_nc.Text = ""; txt_conciliado_nc.Text = ""; txt_cuenta_bancaria_nc.Text = ""; txt_destinatario_nc.Text = ""; txt_fecha_nc.Text = ""; txt_monto_nc.Text = ""; txt_no_documento_nc.Text = ""; txt_cuenta_corriente_nc.Text = "";
                txt_descripcion_nb.Text = ""; txt_conciliado_nb.Text = ""; txt_cuenta_bancaria_nb.Text = ""; txt_destinatario_nb.Text = ""; txt_fecha_nb.Text = ""; txt_monto_nb.Text = ""; txt_no_documento_nb.Text = ""; txt_cuenta_corriente_nb.Text = ""; txt_id_proveedor_nb.Text = "";
            }
            else
            {
                if (this.dg.CurrentRow.Cells[9].Value.ToString() == "2")
                {
                    TextBox[] textbox = { txt_conciliado_che, txt_descripcion_che, txt_destinatario_che, txt_fecha_dep, txt_no_documento_che, txt_cuenta_bancaria_che, txt_monto_che };
                    fn.llenartextbox(textbox, dg);
                    dateTimePicker2.Text = txt_fecha_che.Text;
                    cbo_cuenta_bancaria_che.Text = txt_cuenta_bancaria_che.Text;
                    cbo_conciliado_che.Text = txt_conciliado_che.Text;
                    tabControl.SelectedTab = tabPage2;
                    txt_descripcion_dep.Text = ""; txt_conciliado_dep.Text = ""; txt_cuenta_bancaria_dep.Text = ""; txt_destinatario_dep.Text = ""; txt_fecha_dep.Text = ""; txt_monto_dep.Text = ""; txt_no_documento_dep.Text = "";
                    txt_descripcion_nc.Text = ""; txt_conciliado_nc.Text = ""; txt_cuenta_bancaria_nc.Text = ""; txt_destinatario_nc.Text = ""; txt_fecha_nc.Text = ""; txt_monto_nc.Text = ""; txt_no_documento_nc.Text = ""; txt_cuenta_corriente_nc.Text = "";
                    txt_descripcion_nb.Text = ""; txt_conciliado_nb.Text = ""; txt_cuenta_bancaria_nb.Text = ""; txt_destinatario_nb.Text = ""; txt_fecha_nb.Text = ""; txt_monto_nb.Text = ""; txt_no_documento_nb.Text = ""; txt_cuenta_corriente_nb.Text = ""; txt_id_proveedor_nb.Text = "";
                }
                else
                {
                    if (this.dg.CurrentRow.Cells[9].Value.ToString() == "3")
                    {
                        TextBox[] textbox = { txt_conciliado_nc, txt_descripcion_nc, txt_destinatario_nc, txt_fecha_nc, txt_no_documento_nc, txt_cuenta_bancaria_nc, txt_monto_nc, txt_cuenta_corriente_nc };
                        fn.llenartextbox(textbox, dg);
                        dateTimePicker3.Text = txt_fecha_nc.Text;
                        cbo_cuenta_bancaria_nc.Text = txt_cuenta_bancaria_nc.Text;
                        cbo_conciliado_nc.Text = txt_conciliado_nc.Text;
                        cbo_cuenta_corriente_nc.Text = txt_cuenta_corriente_nc.Text;
                        tabControl.SelectedTab = tabPage3;
                        txt_descripcion_dep.Text = ""; txt_conciliado_dep.Text = ""; txt_cuenta_bancaria_dep.Text = ""; txt_destinatario_dep.Text = ""; txt_fecha_dep.Text = ""; txt_monto_dep.Text = ""; txt_no_documento_dep.Text = "";
                        txt_descripcion_che.Text = ""; txt_conciliado_che.Text = ""; txt_cuenta_bancaria_che.Text = ""; txt_destinatario_che.Text = ""; txt_fecha_che.Text = ""; txt_monto_che.Text = ""; txt_no_documento_che.Text = "";
                        txt_descripcion_nb.Text = ""; txt_conciliado_nb.Text = ""; txt_cuenta_bancaria_nb.Text = ""; txt_destinatario_nb.Text = ""; txt_fecha_nb.Text = ""; txt_monto_nb.Text = ""; txt_no_documento_nb.Text = ""; txt_cuenta_corriente_nb.Text = ""; txt_id_proveedor_nb.Text = "";
                    }
                    else
                    {
                        if (this.dg.CurrentRow.Cells[9].Value.ToString() == "4")
                        {
                            TextBox[] textbox = { txt_conciliado_nb, txt_descripcion_nb, txt_destinatario_nb, txt_fecha_nb, txt_no_documento_nb, txt_cuenta_bancaria_nb, txt_monto_nb, txt_cuenta_corriente_nb, txt_id_proveedor_nb };
                            fn.llenartextbox(textbox, dg);
                            dateTimePicker4.Text = txt_fecha_nb.Text;
                            cbo_cuenta_bancaria_nb.Text = txt_cuenta_bancaria_nb.Text;
                            cbo_conciliado_nb.Text = txt_conciliado_nb.Text;
                            cbo_cuenta_corriente_nb.Text = txt_cuenta_corriente_nb.Text;
                            cbo_id_proveedor_pk_nb.Text = txt_id_proveedor_nb.Text;
                            tabControl.SelectedTab = tabPage4;
                            txt_descripcion_che.Text = ""; txt_conciliado_che.Text = ""; txt_cuenta_bancaria_che.Text = ""; txt_destinatario_che.Text = ""; txt_fecha_che.Text = ""; txt_monto_che.Text = ""; txt_no_documento_che.Text = "";
                            txt_descripcion_dep.Text = ""; txt_conciliado_dep.Text = ""; txt_cuenta_bancaria_dep.Text = ""; txt_destinatario_dep.Text = ""; txt_fecha_dep.Text = ""; txt_monto_dep.Text = ""; txt_no_documento_dep.Text = "";
                            txt_descripcion_nc.Text = ""; txt_conciliado_nc.Text = ""; txt_cuenta_bancaria_nc.Text = ""; txt_destinatario_nc.Text = ""; txt_fecha_nc.Text = ""; txt_monto_nc.Text = ""; txt_no_documento_nc.Text = ""; txt_cuenta_corriente_nc.Text = "";
                        }
                    }
                }
            }
        }

        private void btn_ultimo_Click(object sender, EventArgs e)
        {
            fn.Ultimo(dg);
            if (this.dg.CurrentRow.Cells[9].Value.ToString() == "1")
            {
                TextBox[] textbox = { txt_conciliado_dep, txt_descripcion_dep, txt_destinatario_dep, txt_fecha_dep, txt_no_documento_dep, txt_cuenta_bancaria_dep, txt_monto_dep };
                fn.llenartextbox(textbox, dg);
                dateTimePicker1.Text = txt_fecha_dep.Text;
                cbo_cuenta_bancaria_dep.Text = txt_cuenta_bancaria_dep.Text;
                cbo_conciliado_dep.Text = txt_conciliado_dep.Text;
                tabControl.SelectedTab = tabPage1;
                txt_descripcion_che.Text = ""; txt_conciliado_che.Text = ""; txt_cuenta_bancaria_che.Text = ""; txt_destinatario_che.Text = ""; txt_fecha_che.Text = ""; txt_monto_che.Text = ""; txt_no_documento_che.Text = "";
                txt_descripcion_nc.Text = ""; txt_conciliado_nc.Text = ""; txt_cuenta_bancaria_nc.Text = ""; txt_destinatario_nc.Text = ""; txt_fecha_nc.Text = ""; txt_monto_nc.Text = ""; txt_no_documento_nc.Text = ""; txt_cuenta_corriente_nc.Text = "";
                txt_descripcion_nb.Text = ""; txt_conciliado_nb.Text = ""; txt_cuenta_bancaria_nb.Text = ""; txt_destinatario_nb.Text = ""; txt_fecha_nb.Text = ""; txt_monto_nb.Text = ""; txt_no_documento_nb.Text = ""; txt_cuenta_corriente_nb.Text = ""; txt_id_proveedor_nb.Text = "";
            }
            else
            {
                if (this.dg.CurrentRow.Cells[9].Value.ToString() == "2")
                {
                    TextBox[] textbox = { txt_conciliado_che, txt_descripcion_che, txt_destinatario_che, txt_fecha_dep, txt_no_documento_che, txt_cuenta_bancaria_che, txt_monto_che };
                    fn.llenartextbox(textbox, dg);
                    dateTimePicker2.Text = txt_fecha_che.Text;
                    cbo_cuenta_bancaria_che.Text = txt_cuenta_bancaria_che.Text;
                    cbo_conciliado_che.Text = txt_conciliado_che.Text;
                    tabControl.SelectedTab = tabPage2;
                    txt_descripcion_dep.Text = ""; txt_conciliado_dep.Text = ""; txt_cuenta_bancaria_dep.Text = ""; txt_destinatario_dep.Text = ""; txt_fecha_dep.Text = ""; txt_monto_dep.Text = ""; txt_no_documento_dep.Text = "";
                    txt_descripcion_nc.Text = ""; txt_conciliado_nc.Text = ""; txt_cuenta_bancaria_nc.Text = ""; txt_destinatario_nc.Text = ""; txt_fecha_nc.Text = ""; txt_monto_nc.Text = ""; txt_no_documento_nc.Text = ""; txt_cuenta_corriente_nc.Text = "";
                    txt_descripcion_nb.Text = ""; txt_conciliado_nb.Text = ""; txt_cuenta_bancaria_nb.Text = ""; txt_destinatario_nb.Text = ""; txt_fecha_nb.Text = ""; txt_monto_nb.Text = ""; txt_no_documento_nb.Text = ""; txt_cuenta_corriente_nb.Text = ""; txt_id_proveedor_nb.Text = "";
                }
                else
                {
                    if (this.dg.CurrentRow.Cells[9].Value.ToString() == "3")
                    {
                        TextBox[] textbox = { txt_conciliado_nc, txt_descripcion_nc, txt_destinatario_nc, txt_fecha_nc, txt_no_documento_nc, txt_cuenta_bancaria_nc, txt_monto_nc, txt_cuenta_corriente_nc };
                        fn.llenartextbox(textbox, dg);
                        dateTimePicker3.Text = txt_fecha_nc.Text;
                        cbo_cuenta_bancaria_nc.Text = txt_cuenta_bancaria_nc.Text;
                        cbo_conciliado_nc.Text = txt_conciliado_nc.Text;
                        cbo_cuenta_corriente_nc.Text = txt_cuenta_corriente_nc.Text;
                        tabControl.SelectedTab = tabPage3;
                        txt_descripcion_dep.Text = ""; txt_conciliado_dep.Text = ""; txt_cuenta_bancaria_dep.Text = ""; txt_destinatario_dep.Text = ""; txt_fecha_dep.Text = ""; txt_monto_dep.Text = ""; txt_no_documento_dep.Text = "";
                        txt_descripcion_che.Text = ""; txt_conciliado_che.Text = ""; txt_cuenta_bancaria_che.Text = ""; txt_destinatario_che.Text = ""; txt_fecha_che.Text = ""; txt_monto_che.Text = ""; txt_no_documento_che.Text = "";
                        txt_descripcion_nb.Text = ""; txt_conciliado_nb.Text = ""; txt_cuenta_bancaria_nb.Text = ""; txt_destinatario_nb.Text = ""; txt_fecha_nb.Text = ""; txt_monto_nb.Text = ""; txt_no_documento_nb.Text = ""; txt_cuenta_corriente_nb.Text = ""; txt_id_proveedor_nb.Text = "";
                    }
                    else
                    {
                        if (this.dg.CurrentRow.Cells[9].Value.ToString() == "4")
                        {
                            TextBox[] textbox = { txt_conciliado_nb, txt_descripcion_nb, txt_destinatario_nb, txt_fecha_nb, txt_no_documento_nb, txt_cuenta_bancaria_nb, txt_monto_nb, txt_cuenta_corriente_nb, txt_id_proveedor_nb };
                            fn.llenartextbox(textbox, dg);
                            dateTimePicker4.Text = txt_fecha_nb.Text;
                            cbo_cuenta_bancaria_nb.Text = txt_cuenta_bancaria_nb.Text;
                            cbo_conciliado_nb.Text = txt_conciliado_nb.Text;
                            cbo_cuenta_corriente_nb.Text = txt_cuenta_corriente_nb.Text;
                            cbo_id_proveedor_pk_nb.Text = txt_id_proveedor_nb.Text;
                            tabControl.SelectedTab = tabPage4;
                            txt_descripcion_che.Text = ""; txt_conciliado_che.Text = ""; txt_cuenta_bancaria_che.Text = ""; txt_destinatario_che.Text = ""; txt_fecha_che.Text = ""; txt_monto_che.Text = ""; txt_no_documento_che.Text = "";
                            txt_descripcion_dep.Text = ""; txt_conciliado_dep.Text = ""; txt_cuenta_bancaria_dep.Text = ""; txt_destinatario_dep.Text = ""; txt_fecha_dep.Text = ""; txt_monto_dep.Text = ""; txt_no_documento_dep.Text = "";
                            txt_descripcion_nc.Text = ""; txt_conciliado_nc.Text = ""; txt_cuenta_bancaria_nc.Text = ""; txt_destinatario_nc.Text = ""; txt_fecha_nc.Text = ""; txt_monto_nc.Text = ""; txt_no_documento_nc.Text = ""; txt_cuenta_corriente_nc.Text = "";
                        }
                    }
                }
            }
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            string tabla = "documento";
            fn.ActualizarGrid(this.dg, "Select * from documento WHERE estado <> 'INACTIVO' ", tabla);
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                String codigo2 = this.dg.CurrentRow.Cells[0].Value.ToString();
                String atributo2 = "	id_documento_pk";
                //String campo = "estado";
                var resultado = MessageBox.Show("DESEA BORRAR EL REGISTRO SELECCIONADO", "CONFIRME SU ACCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {

                    string tabla = "documento";
                    fn.eliminar(tabla, atributo2, codigo2);
                    bita.Eliminar("Eliminacion de documento con el numero: " +codigo2, "documento");
                }
            }
            catch
            {
                MessageBox.Show("No se ha seleccionado ningun registro a eliminar", "Favor Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Editar = false;
            txt_descripcion_che.Enabled = false; txt_descripcion_dep.Enabled = false; txt_descripcion_nc.Enabled = false; txt_descripcion_nb.Enabled = false;
            txt_destinatario_che.Enabled = true; txt_destinatario_dep.Enabled = true; txt_destinatario_nc.Enabled = false; txt_destinatario_nb.Enabled = false;
            txt_monto_nb.Enabled = false; txt_monto_nc.Enabled = false; txt_monto_dep.Enabled = false; txt_monto_che.Enabled = false;
            txt_no_documento_che.Enabled = false; txt_no_documento_nb.Enabled = false; txt_no_documento_nc.Enabled = false; txt_no_documento_dep.Enabled = false;
            cbo_conciliado_che.Enabled = false; cbo_conciliado_nc.Enabled = false; cbo_conciliado_nb.Enabled = false; cbo_conciliado_dep.Enabled = false;
            cbo_cuenta_bancaria_che.Enabled = false; cbo_cuenta_bancaria_dep.Enabled = false; cbo_cuenta_bancaria_nc.Enabled = false; cbo_cuenta_bancaria_nb.Enabled = false;
            cbo_cuenta_corriente_nb.Enabled = false; cbo_cuenta_corriente_nc.Enabled = false;
            cbo_id_proveedor_pk_nb.Enabled = false;
            if (tabControl.SelectedTab == tabPage1)
            {
                txt_descripcion_dep.Text = ""; txt_conciliado_dep.Text = ""; txt_cuenta_bancaria_dep.Text = ""; txt_destinatario_dep.Text = ""; txt_fecha_dep.Text = ""; txt_monto_dep.Text = ""; txt_no_documento_dep.Text = "";
            }
            else
            {
                if (tabControl.SelectedTab == tabPage1)
                {
                    txt_descripcion_che.Text = ""; txt_conciliado_che.Text = ""; txt_cuenta_bancaria_che.Text = ""; txt_destinatario_che.Text = ""; txt_fecha_che.Text = ""; txt_monto_che.Text = ""; txt_no_documento_che.Text = "";
                }
                else
                {
                    if (tabControl.SelectedTab == tabPage3)
                    {
                        txt_descripcion_nc.Text = ""; txt_conciliado_nc.Text = ""; txt_cuenta_bancaria_nc.Text = ""; txt_destinatario_nc.Text = ""; txt_fecha_nc.Text = ""; txt_monto_nc.Text = ""; txt_no_documento_nc.Text = ""; txt_cuenta_corriente_nc.Text = "";
                    }
                    else
                    {
                        if (tabControl.SelectedTab == tabPage4)
                        {
                            txt_descripcion_nb.Text = ""; txt_conciliado_nb.Text = ""; txt_cuenta_bancaria_nb.Text = ""; txt_destinatario_nb.Text = ""; txt_fecha_nb.Text = ""; txt_monto_nb.Text = ""; txt_no_documento_nb.Text = ""; txt_cuenta_corriente_nb.Text = ""; txt_id_proveedor_nb.Text = "";
                        }
                    }
                }
            }
        }

        private void txt_no_documento_dep_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion_solonumeros(e);
        }

        private void txt_descripcion_dep_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion_sololetras(e);
        }

        private void txt_destinatario_dep_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion_sololetras(e);
        }

        private void txt_monto_dep_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion_solonumerocondosdecimales(e, txt_monto_dep);
        }

        private void txt_no_documento_che_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion_solonumeros(e);
        }

        private void txt_descripcion_che_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion_sololetras(e);
        }

        private void txt_destinatario_che_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion_sololetras(e);
        }

        private void txt_monto_che_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion_solonumerocondosdecimales(e, txt_monto_che);
        }

        private void txt_no_documento_nc_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion_solonumeros(e);
        }

        private void txt_descripcion_nc_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion_sololetras(e);
        }

        private void txt_destinatario_nc_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion_sololetras(e);
        }

        private void txt_monto_nc_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion_solonumerocondosdecimales(e, txt_monto_nc);
        }

        private void txt_no_documento_nb_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion_solonumeros(e);
        }

        private void txt_descripcion_nb_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion_sololetras(e);
        }

        private void txt_destinatario_nb_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion_sololetras(e);
        }

        private void txt_monton_nb_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion_solonumerocondosdecimales(e, txt_monto_nb);
        }
    }
}
