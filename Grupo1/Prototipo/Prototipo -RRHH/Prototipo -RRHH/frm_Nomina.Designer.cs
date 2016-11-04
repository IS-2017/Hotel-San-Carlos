namespace Prototipo__RRHH
{
    partial class frm_Nomina
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Nomina));
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.percepcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deduccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.txt_fec_fin_pag_nom = new System.Windows.Forms.TextBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.txt_fec_inic_pag_nom = new System.Windows.Forms.TextBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.txt_perd_liquid_nom = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.txt_nacion_emp_nom = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txt_num_afiliac_nom = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txt_fecha_ingre_emp_nom = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txt_cargo_emp_nom = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txt_dirr_empr_nom = new System.Windows.Forms.TextBox();
            this.gpb_navegador = new System.Windows.Forms.GroupBox();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.btn_ultimo = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_primero = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_siguiente = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_anterior = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_nom_emp_nom = new System.Windows.Forms.TextBox();
            this.dgv_datos_emp = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_nom_empresa_nom = new System.Windows.Forms.TextBox();
            this.lbl_recibo_nomina = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox12.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.gpb_navegador.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datos_emp)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clave,
            this.tipo,
            this.descripcion,
            this.unidades,
            this.percepcion,
            this.deduccion});
            this.dataGridView2.Location = new System.Drawing.Point(12, 437);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(825, 281);
            this.dataGridView2.TabIndex = 200;
            // 
            // clave
            // 
            this.clave.HeaderText = "Clave";
            this.clave.Name = "clave";
            // 
            // tipo
            // 
            this.tipo.HeaderText = "Tipo";
            this.tipo.Name = "tipo";
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.MinimumWidth = 7;
            this.descripcion.Name = "descripcion";
            this.descripcion.Width = 200;
            // 
            // unidades
            // 
            this.unidades.HeaderText = "Unidades";
            this.unidades.Name = "unidades";
            // 
            // percepcion
            // 
            this.percepcion.HeaderText = "Percepciones";
            this.percepcion.Name = "percepcion";
            this.percepcion.Width = 140;
            // 
            // deduccion
            // 
            this.deduccion.HeaderText = "Deducciones";
            this.deduccion.Name = "deduccion";
            this.deduccion.Width = 140;
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.txt_fec_fin_pag_nom);
            this.groupBox12.Location = new System.Drawing.Point(438, 381);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(169, 50);
            this.groupBox12.TabIndex = 193;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Fec. Final de Pago";
            // 
            // txt_fec_fin_pag_nom
            // 
            this.txt_fec_fin_pag_nom.Enabled = false;
            this.txt_fec_fin_pag_nom.Location = new System.Drawing.Point(6, 19);
            this.txt_fec_fin_pag_nom.Name = "txt_fec_fin_pag_nom";
            this.txt_fec_fin_pag_nom.Size = new System.Drawing.Size(157, 20);
            this.txt_fec_fin_pag_nom.TabIndex = 176;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.txt_fec_inic_pag_nom);
            this.groupBox11.Location = new System.Drawing.Point(253, 381);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(179, 50);
            this.groupBox11.TabIndex = 199;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Fec. Inicio Pago:";
            // 
            // txt_fec_inic_pag_nom
            // 
            this.txt_fec_inic_pag_nom.Enabled = false;
            this.txt_fec_inic_pag_nom.Location = new System.Drawing.Point(6, 19);
            this.txt_fec_inic_pag_nom.Name = "txt_fec_inic_pag_nom";
            this.txt_fec_inic_pag_nom.Size = new System.Drawing.Size(167, 20);
            this.txt_fec_inic_pag_nom.TabIndex = 176;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.textBox10);
            this.groupBox10.Location = new System.Drawing.Point(615, 381);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(222, 50);
            this.groupBox10.TabIndex = 198;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Tiempo - Dias";
            // 
            // textBox10
            // 
            this.textBox10.Enabled = false;
            this.textBox10.Location = new System.Drawing.Point(6, 19);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(207, 20);
            this.textBox10.TabIndex = 176;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.txt_perd_liquid_nom);
            this.groupBox9.Location = new System.Drawing.Point(12, 381);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(235, 50);
            this.groupBox9.TabIndex = 197;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Peridodo de Liquidacion";
            // 
            // txt_perd_liquid_nom
            // 
            this.txt_perd_liquid_nom.Enabled = false;
            this.txt_perd_liquid_nom.Location = new System.Drawing.Point(6, 19);
            this.txt_perd_liquid_nom.Name = "txt_perd_liquid_nom";
            this.txt_perd_liquid_nom.Size = new System.Drawing.Size(223, 20);
            this.txt_perd_liquid_nom.TabIndex = 176;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.txt_nacion_emp_nom);
            this.groupBox8.Location = new System.Drawing.Point(613, 325);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(224, 50);
            this.groupBox8.TabIndex = 195;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Nacionalidad";
            // 
            // txt_nacion_emp_nom
            // 
            this.txt_nacion_emp_nom.Enabled = false;
            this.txt_nacion_emp_nom.Location = new System.Drawing.Point(6, 19);
            this.txt_nacion_emp_nom.Name = "txt_nacion_emp_nom";
            this.txt_nacion_emp_nom.Size = new System.Drawing.Size(212, 20);
            this.txt_nacion_emp_nom.TabIndex = 176;
            this.txt_nacion_emp_nom.Tag = "nacionalidad";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.txt_num_afiliac_nom);
            this.groupBox7.Location = new System.Drawing.Point(711, 269);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(126, 50);
            this.groupBox7.TabIndex = 196;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Num. Afiliacion";
            // 
            // txt_num_afiliac_nom
            // 
            this.txt_num_afiliac_nom.Enabled = false;
            this.txt_num_afiliac_nom.Location = new System.Drawing.Point(6, 19);
            this.txt_num_afiliac_nom.Name = "txt_num_afiliac_nom";
            this.txt_num_afiliac_nom.Size = new System.Drawing.Size(110, 20);
            this.txt_num_afiliac_nom.TabIndex = 176;
            this.txt_num_afiliac_nom.Tag = "no_afiliacion_igss";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txt_fecha_ingre_emp_nom);
            this.groupBox6.Location = new System.Drawing.Point(448, 325);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(159, 50);
            this.groupBox6.TabIndex = 194;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Antigüedad ";
            // 
            // txt_fecha_ingre_emp_nom
            // 
            this.txt_fecha_ingre_emp_nom.Enabled = false;
            this.txt_fecha_ingre_emp_nom.Location = new System.Drawing.Point(6, 19);
            this.txt_fecha_ingre_emp_nom.Name = "txt_fecha_ingre_emp_nom";
            this.txt_fecha_ingre_emp_nom.Size = new System.Drawing.Size(147, 20);
            this.txt_fecha_ingre_emp_nom.TabIndex = 176;
            this.txt_fecha_ingre_emp_nom.Tag = "fecha_ingreso";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txt_cargo_emp_nom);
            this.groupBox5.Location = new System.Drawing.Point(288, 325);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(154, 50);
            this.groupBox5.TabIndex = 192;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Cargo del Empleado";
            // 
            // txt_cargo_emp_nom
            // 
            this.txt_cargo_emp_nom.Enabled = false;
            this.txt_cargo_emp_nom.Location = new System.Drawing.Point(6, 19);
            this.txt_cargo_emp_nom.Name = "txt_cargo_emp_nom";
            this.txt_cargo_emp_nom.Size = new System.Drawing.Size(138, 20);
            this.txt_cargo_emp_nom.TabIndex = 176;
            this.txt_cargo_emp_nom.Tag = "cargo";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txt_dirr_empr_nom);
            this.groupBox4.Location = new System.Drawing.Point(12, 325);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(270, 50);
            this.groupBox4.TabIndex = 190;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Direccion de la Empresa";
            // 
            // txt_dirr_empr_nom
            // 
            this.txt_dirr_empr_nom.Enabled = false;
            this.txt_dirr_empr_nom.Location = new System.Drawing.Point(6, 19);
            this.txt_dirr_empr_nom.Name = "txt_dirr_empr_nom";
            this.txt_dirr_empr_nom.Size = new System.Drawing.Size(258, 20);
            this.txt_dirr_empr_nom.TabIndex = 176;
            // 
            // gpb_navegador
            // 
            this.gpb_navegador.Controls.Add(this.btn_nuevo);
            this.gpb_navegador.Controls.Add(this.btn_ultimo);
            this.gpb_navegador.Controls.Add(this.btn_guardar);
            this.gpb_navegador.Controls.Add(this.btn_primero);
            this.gpb_navegador.Controls.Add(this.btn_editar);
            this.gpb_navegador.Controls.Add(this.btn_siguiente);
            this.gpb_navegador.Controls.Add(this.btn_eliminar);
            this.gpb_navegador.Controls.Add(this.btn_anterior);
            this.gpb_navegador.Controls.Add(this.btn_buscar);
            this.gpb_navegador.Controls.Add(this.btn_actualizar);
            this.gpb_navegador.Controls.Add(this.btn_cancelar);
            this.gpb_navegador.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_navegador.Location = new System.Drawing.Point(112, 54);
            this.gpb_navegador.Name = "gpb_navegador";
            this.gpb_navegador.Size = new System.Drawing.Size(636, 100);
            this.gpb_navegador.TabIndex = 191;
            this.gpb_navegador.TabStop = false;
            this.gpb_navegador.Text = "Navegador";
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_nuevo.BackgroundImage")));
            this.btn_nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_nuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_nuevo.FlatAppearance.BorderSize = 0;
            this.btn_nuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_nuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nuevo.Location = new System.Drawing.Point(17, 21);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(65, 65);
            this.btn_nuevo.TabIndex = 0;
            this.btn_nuevo.UseVisualStyleBackColor = true;
            // 
            // btn_ultimo
            // 
            this.btn_ultimo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ultimo.BackgroundImage")));
            this.btn_ultimo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ultimo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ultimo.FlatAppearance.BorderSize = 0;
            this.btn_ultimo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_ultimo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_ultimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ultimo.Location = new System.Drawing.Point(565, 53);
            this.btn_ultimo.Name = "btn_ultimo";
            this.btn_ultimo.Size = new System.Drawing.Size(33, 33);
            this.btn_ultimo.TabIndex = 10;
            this.btn_ultimo.UseVisualStyleBackColor = true;
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_guardar.BackgroundImage")));
            this.btn_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_guardar.FlatAppearance.BorderSize = 0;
            this.btn_guardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.Location = new System.Drawing.Point(88, 19);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(65, 65);
            this.btn_guardar.TabIndex = 1;
            this.btn_guardar.UseVisualStyleBackColor = true;
            // 
            // btn_primero
            // 
            this.btn_primero.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_primero.BackgroundImage")));
            this.btn_primero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_primero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_primero.FlatAppearance.BorderSize = 0;
            this.btn_primero.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_primero.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_primero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_primero.Location = new System.Drawing.Point(529, 53);
            this.btn_primero.Name = "btn_primero";
            this.btn_primero.Size = new System.Drawing.Size(33, 33);
            this.btn_primero.TabIndex = 9;
            this.btn_primero.UseVisualStyleBackColor = true;
            // 
            // btn_editar
            // 
            this.btn_editar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_editar.BackgroundImage")));
            this.btn_editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_editar.FlatAppearance.BorderSize = 0;
            this.btn_editar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_editar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar.Location = new System.Drawing.Point(159, 19);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(65, 65);
            this.btn_editar.TabIndex = 2;
            this.btn_editar.UseVisualStyleBackColor = true;
            // 
            // btn_siguiente
            // 
            this.btn_siguiente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_siguiente.BackgroundImage")));
            this.btn_siguiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_siguiente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_siguiente.FlatAppearance.BorderSize = 0;
            this.btn_siguiente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_siguiente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_siguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_siguiente.Location = new System.Drawing.Point(565, 18);
            this.btn_siguiente.Name = "btn_siguiente";
            this.btn_siguiente.Size = new System.Drawing.Size(33, 33);
            this.btn_siguiente.TabIndex = 8;
            this.btn_siguiente.UseVisualStyleBackColor = true;
            this.btn_siguiente.Click += new System.EventHandler(this.btn_siguiente_Click_1);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_eliminar.BackgroundImage")));
            this.btn_eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_eliminar.FlatAppearance.BorderSize = 0;
            this.btn_eliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_eliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar.Location = new System.Drawing.Point(230, 19);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(65, 65);
            this.btn_eliminar.TabIndex = 3;
            this.btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_anterior
            // 
            this.btn_anterior.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_anterior.BackgroundImage")));
            this.btn_anterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_anterior.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_anterior.FlatAppearance.BorderSize = 0;
            this.btn_anterior.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_anterior.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_anterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_anterior.Location = new System.Drawing.Point(529, 18);
            this.btn_anterior.Name = "btn_anterior";
            this.btn_anterior.Size = new System.Drawing.Size(33, 33);
            this.btn_anterior.TabIndex = 7;
            this.btn_anterior.UseVisualStyleBackColor = true;
            this.btn_anterior.Click += new System.EventHandler(this.btn_anterior_Click_1);
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_buscar.BackgroundImage")));
            this.btn_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_buscar.FlatAppearance.BorderSize = 0;
            this.btn_buscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_buscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.Location = new System.Drawing.Point(301, 19);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(65, 65);
            this.btn_buscar.TabIndex = 4;
            this.btn_buscar.UseVisualStyleBackColor = true;
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_actualizar.BackgroundImage")));
            this.btn_actualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_actualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_actualizar.FlatAppearance.BorderSize = 0;
            this.btn_actualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_actualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_actualizar.Location = new System.Drawing.Point(443, 19);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(65, 65);
            this.btn_actualizar.TabIndex = 6;
            this.btn_actualizar.UseVisualStyleBackColor = true;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cancelar.BackgroundImage")));
            this.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Location = new System.Drawing.Point(372, 19);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(65, 65);
            this.btn_cancelar.TabIndex = 5;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Location = new System.Drawing.Point(570, 269);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(135, 50);
            this.groupBox3.TabIndex = 189;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Num. Orden";
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(6, 19);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(122, 20);
            this.textBox3.TabIndex = 177;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_nom_emp_nom);
            this.groupBox2.Location = new System.Drawing.Point(291, 269);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(273, 50);
            this.groupBox2.TabIndex = 188;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nombre de Empleado";
            // 
            // txt_nom_emp_nom
            // 
            this.txt_nom_emp_nom.Enabled = false;
            this.txt_nom_emp_nom.Location = new System.Drawing.Point(6, 19);
            this.txt_nom_emp_nom.Name = "txt_nom_emp_nom";
            this.txt_nom_emp_nom.Size = new System.Drawing.Size(258, 20);
            this.txt_nom_emp_nom.TabIndex = 177;
            this.txt_nom_emp_nom.Tag = "nombre";
            // 
            // dgv_datos_emp
            // 
            this.dgv_datos_emp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_datos_emp.Location = new System.Drawing.Point(12, 160);
            this.dgv_datos_emp.Name = "dgv_datos_emp";
            this.dgv_datos_emp.Size = new System.Drawing.Size(825, 103);
            this.dgv_datos_emp.TabIndex = 187;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_nom_empresa_nom);
            this.groupBox1.Location = new System.Drawing.Point(12, 269);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 50);
            this.groupBox1.TabIndex = 186;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Empresa";
            // 
            // txt_nom_empresa_nom
            // 
            this.txt_nom_empresa_nom.Enabled = false;
            this.txt_nom_empresa_nom.Location = new System.Drawing.Point(6, 19);
            this.txt_nom_empresa_nom.Name = "txt_nom_empresa_nom";
            this.txt_nom_empresa_nom.Size = new System.Drawing.Size(258, 20);
            this.txt_nom_empresa_nom.TabIndex = 176;
            this.txt_nom_empresa_nom.Tag = "nombre";
            // 
            // lbl_recibo_nomina
            // 
            this.lbl_recibo_nomina.AutoSize = true;
            this.lbl_recibo_nomina.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_recibo_nomina.Location = new System.Drawing.Point(291, 11);
            this.lbl_recibo_nomina.Name = "lbl_recibo_nomina";
            this.lbl_recibo_nomina.Size = new System.Drawing.Size(276, 32);
            this.lbl_recibo_nomina.TabIndex = 185;
            this.lbl_recibo_nomina.Text = "Recibos de Nominas";
            // 
            // frm_Nomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.ClientSize = new System.Drawing.Size(848, 728);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.groupBox12);
            this.Controls.Add(this.groupBox11);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.gpb_navegador);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgv_datos_emp);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_recibo_nomina);
            this.Name = "frm_Nomina";
            this.Text = "frm_Nomina";
            this.Load += new System.EventHandler(this.frm_Nomina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.gpb_navegador.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datos_emp)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clave;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn percepcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn deduccion;
        private System.Windows.Forms.GroupBox groupBox12;
        public System.Windows.Forms.TextBox txt_fec_fin_pag_nom;
        private System.Windows.Forms.GroupBox groupBox11;
        public System.Windows.Forms.TextBox txt_fec_inic_pag_nom;
        private System.Windows.Forms.GroupBox groupBox10;
        public System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.GroupBox groupBox9;
        public System.Windows.Forms.TextBox txt_perd_liquid_nom;
        private System.Windows.Forms.GroupBox groupBox8;
        public System.Windows.Forms.TextBox txt_nacion_emp_nom;
        private System.Windows.Forms.GroupBox groupBox7;
        public System.Windows.Forms.TextBox txt_num_afiliac_nom;
        private System.Windows.Forms.GroupBox groupBox6;
        public System.Windows.Forms.TextBox txt_fecha_ingre_emp_nom;
        private System.Windows.Forms.GroupBox groupBox5;
        public System.Windows.Forms.TextBox txt_cargo_emp_nom;
        private System.Windows.Forms.GroupBox groupBox4;
        public System.Windows.Forms.TextBox txt_dirr_empr_nom;
        private System.Windows.Forms.GroupBox gpb_navegador;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Button btn_ultimo;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_primero;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_siguiente;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_anterior;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.TextBox txt_nom_emp_nom;
        private System.Windows.Forms.DataGridView dgv_datos_emp;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox txt_nom_empresa_nom;
        private System.Windows.Forms.Label lbl_recibo_nomina;
    }
}