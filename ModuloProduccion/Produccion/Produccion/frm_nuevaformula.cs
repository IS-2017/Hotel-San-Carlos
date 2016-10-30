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

namespace produccion
{
    public partial class frm_nuevaformula : Form
    {
        public frm_nuevaformula()
        {
            InitializeComponent();
        }

        // ir hacia recetario
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form proceso = new Form();
            frm_recetario frm = new frm_recetario();
            frm.Show();
            
        }

        String opcioncategoria = "";

        private void frm_nuevaformula_Load(object sender, EventArgs e)
        {
            // conexion odbc:
            seguridad.Conexion.DSN = "hotelsancarlos";
            // Carga de combobox Clasificacion
            CapaDatos cdcat = new CapaDatos();
            DataTable dtcat = cdcat.CargarDatosBienClasificacion();


            
            cmb_categoria.DataSource = dtcat;
            cmb_categoria.DisplayMember = "clasificacion";
            cmb_categoria.ValueMember = "clasificacion";
            cmb_categoria.SelectedItem = -1;


            // Carga de combobox procesos

            CapaDatos cd = new CapaDatos();
            DataTable recolector = cd.CargaDatosProceso();

            cmb_proceso.DataSource = recolector;
            cmb_proceso.DisplayMember = "nombre_proceso";
            cmb_proceso.ValueMember = "id_proceso_pk";

            //DataRow row = recolector.Rows[2];
            //String x = row["tiempo_proceso"].ToString();
            //MessageBox.Show(x);


            //Cargar combobox de medida

            CapaDatos cdmedida = new CapaDatos();
            DataTable medida = cdmedida.CargarDatosMedida();

            cmb_medida.DataSource = medida;
            cmb_medida.DisplayMember = "nombre_medida";
            cmb_medida.ValueMember = "id_medida_pk";


        }

        private void llbl_nuevo_proceso_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_NuevoProceso frm = new frm_NuevoProceso();
            frm.Show();
        }

        private void cmb_categoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            // carga de materia prima segun categoria
            CapaDatos cd = new CapaDatos();
            opcioncategoria = cmb_categoria.SelectedValue.ToString();

            DataTable dt = cd.CargaDatosBien(opcioncategoria);

            cmb_materia_prima.DataSource=dt;
            cmb_materia_prima.DisplayMember = "descripcion";
            cmb_materia_prima.ValueMember = "id_bien_pk";
        }


        // boton para agregar ingrediente al datagridvie
        private void btn_agregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_categoria.Text == "" || cmb_materia_prima.Text == "" || cmb_medida.Text == "" || cmb_proceso.Text == "" || txt_nombre_formula.Text == "" || txt_cantidad.Text == "")
                {
                    MessageBox.Show("uno o mas campos estan vacios");
                }
                else
                {
                    // consulta para tomar las horas hombre del proceso
                    if (cmb_proceso.SelectedValue.ToString() != "System.Data.DataRowView")
                    {
                        //MessageBox.Show(cmb_proceso.SelectedValue.ToString());
                        CapaDatos cd = new CapaDatos();
                        DataTable dt = cd.SeleccionarHorasHombre(cmb_proceso.SelectedValue.ToString());

                        DataRow casilla = dt.Rows[0];
                        string valor = casilla["tiempo_proceso"].ToString();


                        // Tomar dato de costo de cada materia prima seleccionada
                        CapaDatos cdcosto = new CapaDatos();
                        DataTable tabla = cdcosto.SeleccionCostoMateriaPrima(cmb_materia_prima.SelectedValue.ToString());
                        DataRow row = tabla.Rows[0];
                        String costo = row["Costo"].ToString();

                        //MessageBox.Show(costo);



                        // Datagrid a nivel de usuario
                        dgv_cuerpo_formula.Rows.Add(cmb_categoria.Text, cmb_materia_prima.Text,
                        txt_cantidad.Text, cmb_medida.Text, cmb_proceso.Text, valor,costo);

                        // Datagrid a nivel base de datos
                        dgv_cuerpo_formula_ID.Rows.Add("mp",cmb_materia_prima.SelectedValue.ToString(), txt_cantidad.Text, cmb_medida.SelectedValue.ToString(),
                        cmb_proceso.SelectedValue.ToString(), valor,costo);

                    }


                    // sumar las filas de las horas hombre

                    double resultado = 0;

                    foreach (DataGridViewRow columna in dgv_cuerpo_formula.Rows)
                    {
                        resultado += Convert.ToDouble(columna.Cells["horas_hombre"].Value);
                    }

                    lbl_precio.Text = resultado.ToString();

                    
                    // sumar filas de costo de materia prima
                    double suma = 0;
                    foreach (DataGridViewRow celda in dgv_cuerpo_formula.Rows)
                    {
                        suma += Convert.ToDouble(celda.Cells["costo"].Value);
                    }
                    lbl_costo.Text = suma.ToString();



                    // bloquear el campo de texto de nombre de la formula una vez ingresado el nombre
                    txt_nombre_formula.Enabled = false;

                    // limpiar todas los campos de texto para un nuevo ingreso
                    cmb_categoria.Text = "";
                    cmb_materia_prima.Text = "";
                    cmb_medida.Text = "";
                    cmb_proceso.Text = "";
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        // boton que envia a la base de datos
        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            OdbcConnection con = seguridad.Conexion.ObtenerConexionODBC();
            // insertar detalle receta

            String cadena = "insert into receta (nombre_receta,horas_hombre,costo_receta)values('" + lbl_nombre.Text + "','" + lbl_precio.Text + "','" + lbl_costo.Text + "')";
            OdbcCommand cmd = new OdbcCommand(cadena, con);
            cmd.ExecuteNonQuery();
            con.Close();
            CapaDatos cd = new CapaDatos();
            DataTable dtuvalor = cd.SeleccionUltimoDatoFormula();
            DataRow fila = dtuvalor.Rows[0];
            String ultimovalor = fila["max(id_receta_pk)"].ToString();
            lbl_encabezado.Text = ultimovalor;

            // insertar en detalle formula

            DataTable dt = new DataTable();
            dt.Columns.Add("categoria", typeof(string));
            dt.Columns.Add("materia_prima", typeof(string));
            dt.Columns.Add("cantidad", typeof(string));
            dt.Columns.Add("medida", typeof(string));
            dt.Columns.Add("tipo_proceso", typeof(string));

            foreach (DataGridViewRow dgv in dgv_cuerpo_formula_ID.Rows)
            {
                dt.Rows.Add(dgv.Cells[0].Value, dgv.Cells[1].Value, dgv.Cells[2].Value, dgv.Cells[3].Value, dgv.Cells[4].Value);


            }

            foreach (DataRow row in dt.Rows)
            {
                
                if (row[0].ToString() != ""|| row[1].ToString()!="" ||row[2].ToString()!=""||row[3].ToString()!=""||row[4].ToString()!="")
                {
                    OdbcConnection con2 = seguridad.Conexion.ObtenerConexionODBC();
                    string query = "insert into detalle_receta_mp(id_receta_pk,id_categoria_pk,id_bien_pk,cantidad,id_medida_pk,id_proceso_pk)values('" + ultimovalor + "','" + row[0].ToString() + "','" + row[1].ToString() + "','" + row[2].ToString() + "','" + row[3].ToString() + "','" + row[4].ToString() + "')";
                    OdbcCommand comando = new OdbcCommand(query, con2);
                    comando.ExecuteNonQuery();
                    con2.Close();
                }
                
            }









        }


        //public int InsertarPermisosUsuario(DataTable permisos, string usuario)
        //{
        //    try
        //    {
        //        OdbcConnection con = Conexion.ObtenerConexionODBC();

        //        foreach (DataRow row in permisos.Rows)
        //        {
        //            string query = "insert into usuario_privilegios (usuario, id_aplicacion, ins, sel, upd, del, id_perfil) values ('" + usuario + "', " + row[0].ToString() + ", " + row[1] + "," + row[2] + "," + row[3] + ", " + row[4] + "," + row[5] + " )";
        //            OdbcCommand cmd = new OdbcCommand(query, con);
        //            cmd.ExecuteNonQuery();
        //            bitacora.Permisos("Asignacion de permiso: " + "ins: " + row[1].ToString() + " sel: " + row[2].ToString() + " upd: " + row[3].ToString() + " del: " + row[4].ToString() + " a usuario: " + usuario + " Sobre aplicacion: " + row[0].ToString(), "usuario_privilegios");

        //        }
        //        con.Close();
        //        return 1;
        //    }
        //    catch { return 0; }
        //}



        // validacion dentro del textbox sobre la cantidad de materia prima a utilizarse, los datos ingresados solo deben ser numericos
        private void txt_cantidad_TextChanged(object sender, EventArgs e)
        {
            ValidacionNumerica validacion = new ValidacionNumerica();

            if (!validacion.funnumero(txt_cantidad.Text.Trim().ToString()))
            {
                MessageBox.Show("debe ingresar solo cantidades numericas");

            }
        }

        private void cmb_proceso_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        // evento doble clic para editar el nombre de la formula
        private void txt_nombre_formula_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        // evento doble clic sobre el nombre de la formula para editar y colocar nuevo nombre
        private void lbl_nombre_Click(object sender, EventArgs e)
        {
            txt_nombre_formula.Enabled = true;
        }

        private void txt_nombre_formula_Enter(object sender, EventArgs e)
        {
           
        }

        // evento para agregar nombre automaticamente a la formula
        private void txt_nombre_formula_TextChanged(object sender, EventArgs e)
        {
            lbl_nombre.Text = txt_nombre_formula.Text;

        }

        // boton para quitar una fila del datagridview
        private void btn_quitar_Click(object sender, EventArgs e)
        {
            //int x = dgv_cuerpo_formula.CurrentRow.Index;

            //DataGridViewRow row = dgv_cuerpo_formula_ID.Rows[x];

            try
            {
                int x = dgv_cuerpo_formula.CurrentRow.Index;
                //DataGridViewRow row = dgv_cuerpo_formula_ID.Rows[x];

                dgv_cuerpo_formula.Rows.RemoveAt(dgv_cuerpo_formula.CurrentRow.Index);
                dgv_cuerpo_formula_ID.Rows.RemoveAt(x);

                // sumar las filas de las horas hombre

                double resultado = 0;

                foreach (DataGridViewRow columna in dgv_cuerpo_formula.Rows)
                {
                    resultado += Convert.ToDouble(columna.Cells["horas_hombre"].Value);
                }

                lbl_precio.Text = resultado.ToString();

                // sumar columna de costo de materia prima
                double costo = 0;

                foreach (DataGridViewRow columna in dgv_cuerpo_formula.Rows)
                {
                    costo += Convert.ToDouble(columna.Cells["Costo"].Value);
                }

                lbl_costo.Text = costo.ToString();
            }
            catch
            {
                //throw new Exception ("no se ha seleccionado una columna para eliminar");
                MessageBox.Show("no se ha seleccionado una fila valida para eliminar");
            }
        }

        // boton para actualizar procesos combo box
        private void button1_Click(object sender, EventArgs e)
        {
            CapaDatos cd = new CapaDatos();
            DataTable recolector = cd.CargaDatosProceso();

            cmb_proceso.DataSource = recolector;
            cmb_proceso.DisplayMember = "nombre_proceso";
            cmb_proceso.ValueMember = "id_proceso_pk";
        }
        // tomar el valor de costo de la tabla bien
        private void cmb_materia_prima_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void llb_asigna_mp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //frmAsignarMateriaPrima frm = new frmAsignarMateriaPrima();
            //frm.Show();
        }

        public static implicit operator frm_nuevaformula(frm_modificar_recetario v)
        {
            throw new NotImplementedException();
        }
    }
}
