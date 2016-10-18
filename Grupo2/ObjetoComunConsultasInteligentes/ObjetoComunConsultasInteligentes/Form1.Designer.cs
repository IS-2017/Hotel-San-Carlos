namespace ObjetoComunConsultasInteligentes
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_add3 = new System.Windows.Forms.Button();
            this.chb_check2 = new System.Windows.Forms.CheckBox();
            this.cbo_from3 = new System.Windows.Forms.ComboBox();
            this.cbo_select3 = new System.Windows.Forms.ComboBox();
            this.chb_check1 = new System.Windows.Forms.CheckBox();
            this.cbo_from2 = new System.Windows.Forms.ComboBox();
            this.cbo_select2 = new System.Windows.Forms.ComboBox();
            this.btn_add2 = new System.Windows.Forms.Button();
            this.btn_add1 = new System.Windows.Forms.Button();
            this.cbo_from1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbo_select1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_add4 = new System.Windows.Forms.Button();
            this.chb_check3 = new System.Windows.Forms.CheckBox();
            this.cbo_from4 = new System.Windows.Forms.ComboBox();
            this.cbo_select4 = new System.Windows.Forms.ComboBox();
            this.btn_add5 = new System.Windows.Forms.Button();
            this.chb_check4 = new System.Windows.Forms.CheckBox();
            this.cbo_from5 = new System.Windows.Forms.ComboBox();
            this.cbo_select5 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_consAlmacen = new System.Windows.Forms.Button();
            this.rdb_sinwhere = new System.Windows.Forms.RadioButton();
            this.rdb_conwhere = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_crear_condicion = new System.Windows.Forms.Button();
            this.btn_and = new System.Windows.Forms.Button();
            this.btn_or = new System.Windows.Forms.Button();
            this.cbo_condicion3 = new System.Windows.Forms.ComboBox();
            this.cbo_condicion2 = new System.Windows.Forms.ComboBox();
            this.cbo_condicion1 = new System.Windows.Forms.ComboBox();
            this.btn_generarConsulta = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.lbl_vistapreviaconsulta = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_add3
            // 
            this.btn_add3.BackgroundImage = global::ObjetoComunConsultasInteligentes.Properties.Resources.Button_Add_icon;
            this.btn_add3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_add3.Location = new System.Drawing.Point(533, 146);
            this.btn_add3.Name = "btn_add3";
            this.btn_add3.Size = new System.Drawing.Size(25, 23);
            this.btn_add3.TabIndex = 40;
            this.btn_add3.UseVisualStyleBackColor = true;
            this.btn_add3.Click += new System.EventHandler(this.btn_add3_Click);
            // 
            // chb_check2
            // 
            this.chb_check2.AutoSize = true;
            this.chb_check2.Location = new System.Drawing.Point(442, 96);
            this.chb_check2.Name = "chb_check2";
            this.chb_check2.Size = new System.Drawing.Size(59, 17);
            this.chb_check2.TabIndex = 39;
            this.chb_check2.Text = "Activar";
            this.chb_check2.UseVisualStyleBackColor = true;
            this.chb_check2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // cbo_from3
            // 
            this.cbo_from3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_from3.FormattingEnabled = true;
            this.cbo_from3.Items.AddRange(new object[] {
            "tabla 1 ",
            "tabla 2",
            "tabla 3",
            "tabla 4"});
            this.cbo_from3.Location = new System.Drawing.Point(412, 119);
            this.cbo_from3.Name = "cbo_from3";
            this.cbo_from3.Size = new System.Drawing.Size(121, 21);
            this.cbo_from3.TabIndex = 38;
            // 
            // cbo_select3
            // 
            this.cbo_select3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_select3.FormattingEnabled = true;
            this.cbo_select3.Items.AddRange(new object[] {
            "Campo 1",
            "campo 2 ",
            "campo 3",
            "campo 4",
            "campo 5",
            "campo 6",
            "*"});
            this.cbo_select3.Location = new System.Drawing.Point(412, 147);
            this.cbo_select3.Name = "cbo_select3";
            this.cbo_select3.Size = new System.Drawing.Size(121, 21);
            this.cbo_select3.TabIndex = 37;
            // 
            // chb_check1
            // 
            this.chb_check1.AutoSize = true;
            this.chb_check1.Location = new System.Drawing.Point(274, 96);
            this.chb_check1.Name = "chb_check1";
            this.chb_check1.Size = new System.Drawing.Size(59, 17);
            this.chb_check1.TabIndex = 36;
            this.chb_check1.Text = "Activar";
            this.chb_check1.UseVisualStyleBackColor = true;
            this.chb_check1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cbo_from2
            // 
            this.cbo_from2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_from2.FormattingEnabled = true;
            this.cbo_from2.Items.AddRange(new object[] {
            "tabla 1 ",
            "tabla 2",
            "tabla 3",
            "tabla 4"});
            this.cbo_from2.Location = new System.Drawing.Point(244, 119);
            this.cbo_from2.Name = "cbo_from2";
            this.cbo_from2.Size = new System.Drawing.Size(121, 21);
            this.cbo_from2.TabIndex = 35;
            // 
            // cbo_select2
            // 
            this.cbo_select2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_select2.FormattingEnabled = true;
            this.cbo_select2.Items.AddRange(new object[] {
            "Campo 1",
            "campo 2 ",
            "campo 3",
            "campo 4",
            "campo 5",
            "campo 6",
            "*"});
            this.cbo_select2.Location = new System.Drawing.Point(244, 147);
            this.cbo_select2.Name = "cbo_select2";
            this.cbo_select2.Size = new System.Drawing.Size(121, 21);
            this.cbo_select2.TabIndex = 34;
            // 
            // btn_add2
            // 
            this.btn_add2.BackgroundImage = global::ObjetoComunConsultasInteligentes.Properties.Resources.Button_Add_icon;
            this.btn_add2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_add2.Location = new System.Drawing.Point(365, 146);
            this.btn_add2.Name = "btn_add2";
            this.btn_add2.Size = new System.Drawing.Size(25, 23);
            this.btn_add2.TabIndex = 33;
            this.btn_add2.UseVisualStyleBackColor = true;
            this.btn_add2.Click += new System.EventHandler(this.btn_add2_Click);
            // 
            // btn_add1
            // 
            this.btn_add1.BackgroundImage = global::ObjetoComunConsultasInteligentes.Properties.Resources.Button_Add_icon;
            this.btn_add1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_add1.Location = new System.Drawing.Point(190, 146);
            this.btn_add1.Name = "btn_add1";
            this.btn_add1.Size = new System.Drawing.Size(25, 23);
            this.btn_add1.TabIndex = 32;
            this.btn_add1.UseVisualStyleBackColor = true;
            this.btn_add1.Click += new System.EventHandler(this.btn_add1_Click);
            // 
            // cbo_from1
            // 
            this.cbo_from1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_from1.FormattingEnabled = true;
            this.cbo_from1.Items.AddRange(new object[] {
            "tabla 1 ",
            "tabla 2",
            "tabla 3",
            "tabla 4"});
            this.cbo_from1.Location = new System.Drawing.Point(69, 119);
            this.cbo_from1.Name = "cbo_from1";
            this.cbo_from1.Size = new System.Drawing.Size(121, 21);
            this.cbo_from1.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "FROM";
            // 
            // cbo_select1
            // 
            this.cbo_select1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_select1.FormattingEnabled = true;
            this.cbo_select1.Items.AddRange(new object[] {
            "Campo 1",
            "campo 2 ",
            "campo 3",
            "campo 4",
            "campo 5",
            "campo 6",
            "*"});
            this.cbo_select1.Location = new System.Drawing.Point(69, 147);
            this.cbo_select1.Name = "cbo_select1";
            this.cbo_select1.Size = new System.Drawing.Size(121, 21);
            this.cbo_select1.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "SELECT";
            // 
            // btn_add4
            // 
            this.btn_add4.BackgroundImage = global::ObjetoComunConsultasInteligentes.Properties.Resources.Button_Add_icon;
            this.btn_add4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_add4.Location = new System.Drawing.Point(701, 146);
            this.btn_add4.Name = "btn_add4";
            this.btn_add4.Size = new System.Drawing.Size(25, 23);
            this.btn_add4.TabIndex = 44;
            this.btn_add4.UseVisualStyleBackColor = true;
            this.btn_add4.Click += new System.EventHandler(this.btn_add4_Click);
            // 
            // chb_check3
            // 
            this.chb_check3.AutoSize = true;
            this.chb_check3.Location = new System.Drawing.Point(610, 96);
            this.chb_check3.Name = "chb_check3";
            this.chb_check3.Size = new System.Drawing.Size(59, 17);
            this.chb_check3.TabIndex = 43;
            this.chb_check3.Text = "Activar";
            this.chb_check3.UseVisualStyleBackColor = true;
            this.chb_check3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // cbo_from4
            // 
            this.cbo_from4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_from4.FormattingEnabled = true;
            this.cbo_from4.Items.AddRange(new object[] {
            "tabla 1 ",
            "tabla 2",
            "tabla 3",
            "tabla 4"});
            this.cbo_from4.Location = new System.Drawing.Point(580, 119);
            this.cbo_from4.Name = "cbo_from4";
            this.cbo_from4.Size = new System.Drawing.Size(121, 21);
            this.cbo_from4.TabIndex = 42;
            this.cbo_from4.SelectedIndexChanged += new System.EventHandler(this.cbo_from4_SelectedIndexChanged);
            // 
            // cbo_select4
            // 
            this.cbo_select4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_select4.FormattingEnabled = true;
            this.cbo_select4.Items.AddRange(new object[] {
            "Campo 1",
            "campo 2 ",
            "campo 3",
            "campo 4",
            "campo 5",
            "campo 6",
            "*"});
            this.cbo_select4.Location = new System.Drawing.Point(580, 147);
            this.cbo_select4.Name = "cbo_select4";
            this.cbo_select4.Size = new System.Drawing.Size(121, 21);
            this.cbo_select4.TabIndex = 41;
            // 
            // btn_add5
            // 
            this.btn_add5.BackgroundImage = global::ObjetoComunConsultasInteligentes.Properties.Resources.Button_Add_icon;
            this.btn_add5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_add5.Location = new System.Drawing.Point(873, 146);
            this.btn_add5.Name = "btn_add5";
            this.btn_add5.Size = new System.Drawing.Size(25, 23);
            this.btn_add5.TabIndex = 48;
            this.btn_add5.UseVisualStyleBackColor = true;
            this.btn_add5.Click += new System.EventHandler(this.btn_add5_Click);
            // 
            // chb_check4
            // 
            this.chb_check4.AutoSize = true;
            this.chb_check4.Location = new System.Drawing.Point(782, 96);
            this.chb_check4.Name = "chb_check4";
            this.chb_check4.Size = new System.Drawing.Size(59, 17);
            this.chb_check4.TabIndex = 47;
            this.chb_check4.Text = "Activar";
            this.chb_check4.UseVisualStyleBackColor = true;
            this.chb_check4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // cbo_from5
            // 
            this.cbo_from5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_from5.FormattingEnabled = true;
            this.cbo_from5.Items.AddRange(new object[] {
            "tabla 1 ",
            "tabla 2",
            "tabla 3",
            "tabla 4"});
            this.cbo_from5.Location = new System.Drawing.Point(752, 119);
            this.cbo_from5.Name = "cbo_from5";
            this.cbo_from5.Size = new System.Drawing.Size(121, 21);
            this.cbo_from5.TabIndex = 46;
            // 
            // cbo_select5
            // 
            this.cbo_select5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_select5.FormattingEnabled = true;
            this.cbo_select5.Items.AddRange(new object[] {
            "Campo 1",
            "campo 2 ",
            "campo 3",
            "campo 4",
            "campo 5",
            "campo 6",
            "*"});
            this.cbo_select5.Location = new System.Drawing.Point(752, 147);
            this.cbo_select5.Name = "cbo_select5";
            this.cbo_select5.Size = new System.Drawing.Size(121, 21);
            this.cbo_select5.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(394, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 45);
            this.label3.TabIndex = 49;
            this.label3.Text = "Consultas ";
            // 
            // btn_consAlmacen
            // 
            this.btn_consAlmacen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_consAlmacen.Location = new System.Drawing.Point(814, 29);
            this.btn_consAlmacen.Name = "btn_consAlmacen";
            this.btn_consAlmacen.Size = new System.Drawing.Size(128, 23);
            this.btn_consAlmacen.TabIndex = 50;
            this.btn_consAlmacen.Text = "Consultas Almacenadas";
            this.btn_consAlmacen.UseVisualStyleBackColor = true;
            this.btn_consAlmacen.Click += new System.EventHandler(this.button1_Click);
            // 
            // rdb_sinwhere
            // 
            this.rdb_sinwhere.AutoSize = true;
            this.rdb_sinwhere.Location = new System.Drawing.Point(134, 21);
            this.rdb_sinwhere.Name = "rdb_sinwhere";
            this.rdb_sinwhere.Size = new System.Drawing.Size(87, 17);
            this.rdb_sinwhere.TabIndex = 52;
            this.rdb_sinwhere.TabStop = true;
            this.rdb_sinwhere.Text = "SIN WHERE";
            this.rdb_sinwhere.UseVisualStyleBackColor = true;
            // 
            // rdb_conwhere
            // 
            this.rdb_conwhere.AutoSize = true;
            this.rdb_conwhere.Location = new System.Drawing.Point(20, 21);
            this.rdb_conwhere.Name = "rdb_conwhere";
            this.rdb_conwhere.Size = new System.Drawing.Size(92, 17);
            this.rdb_conwhere.TabIndex = 51;
            this.rdb_conwhere.TabStop = true;
            this.rdb_conwhere.Text = "CON WHERE";
            this.rdb_conwhere.UseVisualStyleBackColor = true;
            this.rdb_conwhere.CheckedChanged += new System.EventHandler(this.rdb_conwhere_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdb_conwhere);
            this.groupBox1.Controls.Add(this.rdb_sinwhere);
            this.groupBox1.Location = new System.Drawing.Point(12, 175);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 53);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_crear_condicion);
            this.groupBox2.Controls.Add(this.btn_and);
            this.groupBox2.Controls.Add(this.btn_or);
            this.groupBox2.Controls.Add(this.cbo_condicion3);
            this.groupBox2.Controls.Add(this.cbo_condicion2);
            this.groupBox2.Controls.Add(this.cbo_condicion1);
            this.groupBox2.Location = new System.Drawing.Point(12, 234);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(659, 118);
            this.groupBox2.TabIndex = 54;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Condición";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btn_crear_condicion
            // 
            this.btn_crear_condicion.Location = new System.Drawing.Point(390, 49);
            this.btn_crear_condicion.Name = "btn_crear_condicion";
            this.btn_crear_condicion.Size = new System.Drawing.Size(75, 23);
            this.btn_crear_condicion.TabIndex = 34;
            this.btn_crear_condicion.Text = "CREAR";
            this.btn_crear_condicion.UseVisualStyleBackColor = true;
            this.btn_crear_condicion.Click += new System.EventHandler(this.btn_crear_condicion_Click);
            // 
            // btn_and
            // 
            this.btn_and.Location = new System.Drawing.Point(554, 49);
            this.btn_and.Name = "btn_and";
            this.btn_and.Size = new System.Drawing.Size(75, 23);
            this.btn_and.TabIndex = 33;
            this.btn_and.Text = "AND";
            this.btn_and.UseVisualStyleBackColor = true;
            this.btn_and.Click += new System.EventHandler(this.btn_and_Click);
            // 
            // btn_or
            // 
            this.btn_or.Location = new System.Drawing.Point(471, 49);
            this.btn_or.Name = "btn_or";
            this.btn_or.Size = new System.Drawing.Size(75, 23);
            this.btn_or.TabIndex = 32;
            this.btn_or.Text = "OR";
            this.btn_or.UseVisualStyleBackColor = true;
            this.btn_or.Click += new System.EventHandler(this.btn_or_Click);
            // 
            // cbo_condicion3
            // 
            this.cbo_condicion3.FormattingEnabled = true;
            this.cbo_condicion3.Items.AddRange(new object[] {
            "Campo 1",
            "campo 2 ",
            "campo 3",
            "campo 4",
            "campo 5",
            "campo 6"});
            this.cbo_condicion3.Location = new System.Drawing.Point(228, 49);
            this.cbo_condicion3.Name = "cbo_condicion3";
            this.cbo_condicion3.Size = new System.Drawing.Size(102, 21);
            this.cbo_condicion3.TabIndex = 30;
            // 
            // cbo_condicion2
            // 
            this.cbo_condicion2.DisplayMember = "=";
            this.cbo_condicion2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_condicion2.FormattingEnabled = true;
            this.cbo_condicion2.Items.AddRange(new object[] {
            "<",
            ">",
            "="});
            this.cbo_condicion2.Location = new System.Drawing.Point(175, 49);
            this.cbo_condicion2.Name = "cbo_condicion2";
            this.cbo_condicion2.Size = new System.Drawing.Size(47, 21);
            this.cbo_condicion2.TabIndex = 29;
            this.cbo_condicion2.ValueMember = "=";
            // 
            // cbo_condicion1
            // 
            this.cbo_condicion1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_condicion1.FormattingEnabled = true;
            this.cbo_condicion1.Items.AddRange(new object[] {
            "Campo 1",
            "campo 2 ",
            "campo 3",
            "campo 4",
            "campo 5",
            "campo 6"});
            this.cbo_condicion1.Location = new System.Drawing.Point(67, 49);
            this.cbo_condicion1.Name = "cbo_condicion1";
            this.cbo_condicion1.Size = new System.Drawing.Size(102, 21);
            this.cbo_condicion1.TabIndex = 28;
            // 
            // btn_generarConsulta
            // 
            this.btn_generarConsulta.Location = new System.Drawing.Point(782, 267);
            this.btn_generarConsulta.Name = "btn_generarConsulta";
            this.btn_generarConsulta.Size = new System.Drawing.Size(101, 23);
            this.btn_generarConsulta.TabIndex = 55;
            this.btn_generarConsulta.Text = "Generar Consulta";
            this.btn_generarConsulta.UseVisualStyleBackColor = true;
            this.btn_generarConsulta.Click += new System.EventHandler(this.btn_generarConsulta_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(782, 296);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(101, 23);
            this.btn_limpiar.TabIndex = 56;
            this.btn_limpiar.Text = "Limpiar Campos";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            // 
            // lbl_vistapreviaconsulta
            // 
            this.lbl_vistapreviaconsulta.AutoSize = true;
            this.lbl_vistapreviaconsulta.Location = new System.Drawing.Point(13, 16);
            this.lbl_vistapreviaconsulta.Name = "lbl_vistapreviaconsulta";
            this.lbl_vistapreviaconsulta.Size = new System.Drawing.Size(106, 13);
            this.lbl_vistapreviaconsulta.TabIndex = 57;
            this.lbl_vistapreviaconsulta.Text = "Consulta vista Previa";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 358);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(913, 89);
            this.tabControl1.TabIndex = 58;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tabPage1.Controls.Add(this.lbl_vistapreviaconsulta);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(905, 63);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "QUERY";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(954, 545);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_generarConsulta);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_consAlmacen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_add5);
            this.Controls.Add(this.chb_check4);
            this.Controls.Add(this.cbo_from5);
            this.Controls.Add(this.cbo_select5);
            this.Controls.Add(this.btn_add4);
            this.Controls.Add(this.chb_check3);
            this.Controls.Add(this.cbo_from4);
            this.Controls.Add(this.cbo_select4);
            this.Controls.Add(this.btn_add3);
            this.Controls.Add(this.chb_check2);
            this.Controls.Add(this.cbo_from3);
            this.Controls.Add(this.cbo_select3);
            this.Controls.Add(this.chb_check1);
            this.Controls.Add(this.cbo_from2);
            this.Controls.Add(this.cbo_select2);
            this.Controls.Add(this.btn_add2);
            this.Controls.Add(this.btn_add1);
            this.Controls.Add(this.cbo_from1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbo_select1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_add3;
        private System.Windows.Forms.CheckBox chb_check2;
        private System.Windows.Forms.ComboBox cbo_from3;
        private System.Windows.Forms.ComboBox cbo_select3;
        private System.Windows.Forms.CheckBox chb_check1;
        private System.Windows.Forms.ComboBox cbo_from2;
        private System.Windows.Forms.ComboBox cbo_select2;
        private System.Windows.Forms.Button btn_add2;
        private System.Windows.Forms.Button btn_add1;
        private System.Windows.Forms.ComboBox cbo_from1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbo_select1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_add4;
        private System.Windows.Forms.CheckBox chb_check3;
        private System.Windows.Forms.ComboBox cbo_from4;
        private System.Windows.Forms.ComboBox cbo_select4;
        private System.Windows.Forms.Button btn_add5;
        private System.Windows.Forms.CheckBox chb_check4;
        private System.Windows.Forms.ComboBox cbo_from5;
        private System.Windows.Forms.ComboBox cbo_select5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_consAlmacen;
        private System.Windows.Forms.RadioButton rdb_sinwhere;
        private System.Windows.Forms.RadioButton rdb_conwhere;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_and;
        private System.Windows.Forms.Button btn_or;
        private System.Windows.Forms.ComboBox cbo_condicion3;
        private System.Windows.Forms.ComboBox cbo_condicion2;
        private System.Windows.Forms.ComboBox cbo_condicion1;
        private System.Windows.Forms.Button btn_generarConsulta;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Label lbl_vistapreviaconsulta;
        private System.Windows.Forms.Button btn_crear_condicion;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
    }
}

