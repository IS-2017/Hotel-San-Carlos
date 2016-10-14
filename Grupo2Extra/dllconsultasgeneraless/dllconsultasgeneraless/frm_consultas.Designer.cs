namespace dllconsultasgeneraless
{
    partial class frm_consultas
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
            this.btn_consAlmacen = new System.Windows.Forms.Button();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.chb_check4 = new System.Windows.Forms.CheckBox();
            this.cbo_from5 = new System.Windows.Forms.ComboBox();
            this.cbo_select5 = new System.Windows.Forms.ComboBox();
            this.chb_check3 = new System.Windows.Forms.CheckBox();
            this.cbo_from4 = new System.Windows.Forms.ComboBox();
            this.cbo_select4 = new System.Windows.Forms.ComboBox();
            this.chb_check2 = new System.Windows.Forms.CheckBox();
            this.cbo_from3 = new System.Windows.Forms.ComboBox();
            this.cbo_select3 = new System.Windows.Forms.ComboBox();
            this.chb_check1 = new System.Windows.Forms.CheckBox();
            this.cbo_from2 = new System.Windows.Forms.ComboBox();
            this.cbo_select2 = new System.Windows.Forms.ComboBox();
            this.cbo_from1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbo_select1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tcl_consulta = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lbl_vistapreviaconsulta = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gpb_consulta = new System.Windows.Forms.GroupBox();
            this.cbo_indicador = new System.Windows.Forms.ComboBox();
            this.cbo_simbolo = new System.Windows.Forms.ComboBox();
            this.cbo_cond2_campo = new System.Windows.Forms.ComboBox();
            this.cbo_cond2_tabla = new System.Windows.Forms.ComboBox();
            this.rdb_cond2 = new System.Windows.Forms.RadioButton();
            this.rdb_cond1 = new System.Windows.Forms.RadioButton();
            this.cbo_tabla_condicion1 = new System.Windows.Forms.ComboBox();
            this.cbo_tabla_condicion3 = new System.Windows.Forms.ComboBox();
            this.btn_crear_condicion = new System.Windows.Forms.Button();
            this.btn_and = new System.Windows.Forms.Button();
            this.btn_or = new System.Windows.Forms.Button();
            this.cbo_condicion3 = new System.Windows.Forms.ComboBox();
            this.cbo_condicion2 = new System.Windows.Forms.ComboBox();
            this.cbo_condicion1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdb_conwhere = new System.Windows.Forms.RadioButton();
            this.rdb_sinwhere = new System.Windows.Forms.RadioButton();
            this.btn_ayuda = new System.Windows.Forms.Button();
            this.btn_mas = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_generarConsulta = new System.Windows.Forms.Button();
            this.btn_add5 = new System.Windows.Forms.Button();
            this.btn_add4 = new System.Windows.Forms.Button();
            this.btn_add3 = new System.Windows.Forms.Button();
            this.btn_mas1 = new System.Windows.Forms.Button();
            this.btn_add1 = new System.Windows.Forms.Button();
            this.tcl_consulta.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gpb_consulta.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_consAlmacen
            // 
            this.btn_consAlmacen.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_consAlmacen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_consAlmacen.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consAlmacen.Location = new System.Drawing.Point(702, 12);
            this.btn_consAlmacen.Name = "btn_consAlmacen";
            this.btn_consAlmacen.Size = new System.Drawing.Size(272, 59);
            this.btn_consAlmacen.TabIndex = 73;
            this.btn_consAlmacen.Text = "Consultas Almacenadas";
            this.btn_consAlmacen.UseVisualStyleBackColor = false;
            this.btn_consAlmacen.Click += new System.EventHandler(this.btn_consAlmacen_Click);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(298, 24);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(311, 30);
            this.lbl_titulo.TabIndex = 72;
            this.lbl_titulo.Text = "CONSULTAS INTELIGENTES";
            // 
            // chb_check4
            // 
            this.chb_check4.AutoSize = true;
            this.chb_check4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_check4.Location = new System.Drawing.Point(843, 86);
            this.chb_check4.Name = "chb_check4";
            this.chb_check4.Size = new System.Drawing.Size(88, 25);
            this.chb_check4.TabIndex = 70;
            this.chb_check4.Text = "Activar";
            this.chb_check4.UseVisualStyleBackColor = true;
            this.chb_check4.CheckedChanged += new System.EventHandler(this.chb_check4_CheckedChanged);
            // 
            // cbo_from5
            // 
            this.cbo_from5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_from5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_from5.FormattingEnabled = true;
            this.cbo_from5.Items.AddRange(new object[] {
            "tabla 1 ",
            "tabla 2",
            "tabla 3",
            "tabla 4"});
            this.cbo_from5.Location = new System.Drawing.Point(838, 117);
            this.cbo_from5.Name = "cbo_from5";
            this.cbo_from5.Size = new System.Drawing.Size(121, 29);
            this.cbo_from5.TabIndex = 69;
            this.cbo_from5.SelectedIndexChanged += new System.EventHandler(this.cbo_from5_SelectedIndexChanged);
            // 
            // cbo_select5
            // 
            this.cbo_select5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_select5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_select5.FormattingEnabled = true;
            this.cbo_select5.Location = new System.Drawing.Point(838, 154);
            this.cbo_select5.Name = "cbo_select5";
            this.cbo_select5.Size = new System.Drawing.Size(121, 29);
            this.cbo_select5.TabIndex = 68;
            // 
            // chb_check3
            // 
            this.chb_check3.AutoSize = true;
            this.chb_check3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_check3.Location = new System.Drawing.Point(666, 86);
            this.chb_check3.Name = "chb_check3";
            this.chb_check3.Size = new System.Drawing.Size(88, 25);
            this.chb_check3.TabIndex = 66;
            this.chb_check3.Text = "Activar";
            this.chb_check3.UseVisualStyleBackColor = true;
            this.chb_check3.CheckedChanged += new System.EventHandler(this.chb_check3_CheckedChanged);
            // 
            // cbo_from4
            // 
            this.cbo_from4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_from4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_from4.FormattingEnabled = true;
            this.cbo_from4.Items.AddRange(new object[] {
            "tabla 1 ",
            "tabla 2",
            "tabla 3",
            "tabla 4"});
            this.cbo_from4.Location = new System.Drawing.Point(666, 117);
            this.cbo_from4.Name = "cbo_from4";
            this.cbo_from4.Size = new System.Drawing.Size(121, 29);
            this.cbo_from4.TabIndex = 65;
            this.cbo_from4.SelectedIndexChanged += new System.EventHandler(this.cbo_from4_SelectedIndexChanged);
            // 
            // cbo_select4
            // 
            this.cbo_select4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_select4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_select4.FormattingEnabled = true;
            this.cbo_select4.Location = new System.Drawing.Point(666, 151);
            this.cbo_select4.Name = "cbo_select4";
            this.cbo_select4.Size = new System.Drawing.Size(121, 29);
            this.cbo_select4.TabIndex = 64;
            // 
            // chb_check2
            // 
            this.chb_check2.AutoSize = true;
            this.chb_check2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_check2.Location = new System.Drawing.Point(498, 86);
            this.chb_check2.Name = "chb_check2";
            this.chb_check2.Size = new System.Drawing.Size(88, 25);
            this.chb_check2.TabIndex = 62;
            this.chb_check2.Text = "Activar";
            this.chb_check2.UseVisualStyleBackColor = true;
            this.chb_check2.CheckedChanged += new System.EventHandler(this.chb_check2_CheckedChanged);
            // 
            // cbo_from3
            // 
            this.cbo_from3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_from3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_from3.FormattingEnabled = true;
            this.cbo_from3.Location = new System.Drawing.Point(498, 117);
            this.cbo_from3.Name = "cbo_from3";
            this.cbo_from3.Size = new System.Drawing.Size(121, 29);
            this.cbo_from3.TabIndex = 61;
            this.cbo_from3.SelectedIndexChanged += new System.EventHandler(this.cbo_from3_SelectedIndexChanged);
            // 
            // cbo_select3
            // 
            this.cbo_select3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_select3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_select3.FormattingEnabled = true;
            this.cbo_select3.Location = new System.Drawing.Point(498, 151);
            this.cbo_select3.Name = "cbo_select3";
            this.cbo_select3.Size = new System.Drawing.Size(121, 29);
            this.cbo_select3.TabIndex = 60;
            // 
            // chb_check1
            // 
            this.chb_check1.AutoSize = true;
            this.chb_check1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_check1.Location = new System.Drawing.Point(330, 86);
            this.chb_check1.Name = "chb_check1";
            this.chb_check1.Size = new System.Drawing.Size(88, 25);
            this.chb_check1.TabIndex = 59;
            this.chb_check1.Text = "Activar";
            this.chb_check1.UseVisualStyleBackColor = true;
            this.chb_check1.CheckedChanged += new System.EventHandler(this.chb_check1_CheckedChanged);
            // 
            // cbo_from2
            // 
            this.cbo_from2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_from2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_from2.FormattingEnabled = true;
            this.cbo_from2.Location = new System.Drawing.Point(330, 117);
            this.cbo_from2.Name = "cbo_from2";
            this.cbo_from2.Size = new System.Drawing.Size(121, 29);
            this.cbo_from2.TabIndex = 58;
            this.cbo_from2.SelectedIndexChanged += new System.EventHandler(this.cbo_from2_SelectedIndexChanged);
            // 
            // cbo_select2
            // 
            this.cbo_select2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_select2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_select2.FormattingEnabled = true;
            this.cbo_select2.Location = new System.Drawing.Point(330, 151);
            this.cbo_select2.Name = "cbo_select2";
            this.cbo_select2.Size = new System.Drawing.Size(121, 29);
            this.cbo_select2.TabIndex = 57;
            // 
            // cbo_from1
            // 
            this.cbo_from1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_from1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_from1.FormattingEnabled = true;
            this.cbo_from1.Location = new System.Drawing.Point(164, 117);
            this.cbo_from1.Name = "cbo_from1";
            this.cbo_from1.Size = new System.Drawing.Size(121, 29);
            this.cbo_from1.TabIndex = 54;
            this.cbo_from1.SelectedIndexChanged += new System.EventHandler(this.cbo_from1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 21);
            this.label2.TabIndex = 53;
            this.label2.Text = "DESDE";
            // 
            // cbo_select1
            // 
            this.cbo_select1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_select1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_select1.FormattingEnabled = true;
            this.cbo_select1.Location = new System.Drawing.Point(164, 152);
            this.cbo_select1.Name = "cbo_select1";
            this.cbo_select1.Size = new System.Drawing.Size(121, 29);
            this.cbo_select1.TabIndex = 52;
            this.cbo_select1.SelectedIndexChanged += new System.EventHandler(this.cbo_select1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 21);
            this.label1.TabIndex = 51;
            this.label1.Text = "SELECCIONAR";
            // 
            // tcl_consulta
            // 
            this.tcl_consulta.Controls.Add(this.tabPage1);
            this.tcl_consulta.Controls.Add(this.tabPage2);
            this.tcl_consulta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcl_consulta.Location = new System.Drawing.Point(10, 410);
            this.tcl_consulta.Name = "tcl_consulta";
            this.tcl_consulta.SelectedIndex = 0;
            this.tcl_consulta.Size = new System.Drawing.Size(908, 174);
            this.tcl_consulta.TabIndex = 78;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tabPage1.Controls.Add(this.lbl_vistapreviaconsulta);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(900, 140);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = " QUERY";
            // 
            // lbl_vistapreviaconsulta
            // 
            this.lbl_vistapreviaconsulta.AutoSize = true;
            this.lbl_vistapreviaconsulta.Location = new System.Drawing.Point(346, 33);
            this.lbl_vistapreviaconsulta.Name = "lbl_vistapreviaconsulta";
            this.lbl_vistapreviaconsulta.Size = new System.Drawing.Size(173, 21);
            this.lbl_vistapreviaconsulta.TabIndex = 57;
            this.lbl_vistapreviaconsulta.Text = "Consulta vista Previa";
            this.lbl_vistapreviaconsulta.Click += new System.EventHandler(this.lbl_vistapreviaconsulta_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(900, 140);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "CONSULTA";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(894, 142);
            this.dataGridView1.TabIndex = 59;
            // 
            // gpb_consulta
            // 
            this.gpb_consulta.Controls.Add(this.cbo_indicador);
            this.gpb_consulta.Controls.Add(this.cbo_simbolo);
            this.gpb_consulta.Controls.Add(this.cbo_cond2_campo);
            this.gpb_consulta.Controls.Add(this.cbo_cond2_tabla);
            this.gpb_consulta.Controls.Add(this.rdb_cond2);
            this.gpb_consulta.Controls.Add(this.rdb_cond1);
            this.gpb_consulta.Controls.Add(this.cbo_tabla_condicion1);
            this.gpb_consulta.Controls.Add(this.cbo_tabla_condicion3);
            this.gpb_consulta.Controls.Add(this.btn_crear_condicion);
            this.gpb_consulta.Controls.Add(this.btn_and);
            this.gpb_consulta.Controls.Add(this.btn_or);
            this.gpb_consulta.Controls.Add(this.cbo_condicion3);
            this.gpb_consulta.Controls.Add(this.cbo_condicion2);
            this.gpb_consulta.Controls.Add(this.cbo_condicion1);
            this.gpb_consulta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_consulta.Location = new System.Drawing.Point(12, 265);
            this.gpb_consulta.Name = "gpb_consulta";
            this.gpb_consulta.Size = new System.Drawing.Size(815, 139);
            this.gpb_consulta.TabIndex = 75;
            this.gpb_consulta.TabStop = false;
            this.gpb_consulta.Text = "Condición";
            // 
            // cbo_indicador
            // 
            this.cbo_indicador.FormattingEnabled = true;
            this.cbo_indicador.Location = new System.Drawing.Point(265, 86);
            this.cbo_indicador.Name = "cbo_indicador";
            this.cbo_indicador.Size = new System.Drawing.Size(144, 29);
            this.cbo_indicador.TabIndex = 58;
            // 
            // cbo_simbolo
            // 
            this.cbo_simbolo.DisplayMember = "=";
            this.cbo_simbolo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_simbolo.FormattingEnabled = true;
            this.cbo_simbolo.Items.AddRange(new object[] {
            "<",
            ">",
            "="});
            this.cbo_simbolo.Location = new System.Drawing.Point(212, 86);
            this.cbo_simbolo.Name = "cbo_simbolo";
            this.cbo_simbolo.Size = new System.Drawing.Size(47, 29);
            this.cbo_simbolo.TabIndex = 57;
            this.cbo_simbolo.ValueMember = "=";
            // 
            // cbo_cond2_campo
            // 
            this.cbo_cond2_campo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_cond2_campo.FormattingEnabled = true;
            this.cbo_cond2_campo.Location = new System.Drawing.Point(128, 86);
            this.cbo_cond2_campo.Name = "cbo_cond2_campo";
            this.cbo_cond2_campo.Size = new System.Drawing.Size(77, 29);
            this.cbo_cond2_campo.TabIndex = 56;
            this.cbo_cond2_campo.SelectedIndexChanged += new System.EventHandler(this.cbo_cond2_campo_SelectedIndexChanged);
            // 
            // cbo_cond2_tabla
            // 
            this.cbo_cond2_tabla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_cond2_tabla.FormattingEnabled = true;
            this.cbo_cond2_tabla.Location = new System.Drawing.Point(49, 86);
            this.cbo_cond2_tabla.Name = "cbo_cond2_tabla";
            this.cbo_cond2_tabla.Size = new System.Drawing.Size(80, 29);
            this.cbo_cond2_tabla.TabIndex = 55;
            this.cbo_cond2_tabla.SelectedIndexChanged += new System.EventHandler(this.cbo_cond2_tabla_SelectedIndexChanged);
            // 
            // rdb_cond2
            // 
            this.rdb_cond2.AutoSize = true;
            this.rdb_cond2.Location = new System.Drawing.Point(19, 94);
            this.rdb_cond2.Name = "rdb_cond2";
            this.rdb_cond2.Size = new System.Drawing.Size(14, 13);
            this.rdb_cond2.TabIndex = 54;
            this.rdb_cond2.TabStop = true;
            this.rdb_cond2.UseVisualStyleBackColor = true;
            this.rdb_cond2.CheckedChanged += new System.EventHandler(this.rdb_cond2_CheckedChanged);
            // 
            // rdb_cond1
            // 
            this.rdb_cond1.AutoSize = true;
            this.rdb_cond1.Location = new System.Drawing.Point(20, 52);
            this.rdb_cond1.Name = "rdb_cond1";
            this.rdb_cond1.Size = new System.Drawing.Size(14, 13);
            this.rdb_cond1.TabIndex = 53;
            this.rdb_cond1.TabStop = true;
            this.rdb_cond1.UseVisualStyleBackColor = true;
            this.rdb_cond1.CheckedChanged += new System.EventHandler(this.rdb_cond1_CheckedChanged);
            // 
            // cbo_tabla_condicion1
            // 
            this.cbo_tabla_condicion1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_tabla_condicion1.FormattingEnabled = true;
            this.cbo_tabla_condicion1.Location = new System.Drawing.Point(49, 49);
            this.cbo_tabla_condicion1.Name = "cbo_tabla_condicion1";
            this.cbo_tabla_condicion1.Size = new System.Drawing.Size(77, 29);
            this.cbo_tabla_condicion1.TabIndex = 36;
            this.cbo_tabla_condicion1.SelectedIndexChanged += new System.EventHandler(this.cbo_tabla_condicion1_SelectedIndexChanged);
            // 
            // cbo_tabla_condicion3
            // 
            this.cbo_tabla_condicion3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_tabla_condicion3.FormattingEnabled = true;
            this.cbo_tabla_condicion3.Location = new System.Drawing.Point(265, 48);
            this.cbo_tabla_condicion3.Name = "cbo_tabla_condicion3";
            this.cbo_tabla_condicion3.Size = new System.Drawing.Size(68, 29);
            this.cbo_tabla_condicion3.TabIndex = 35;
            this.cbo_tabla_condicion3.SelectedIndexChanged += new System.EventHandler(this.cbo_tabla_condicion3_SelectedIndexChanged);
            // 
            // btn_crear_condicion
            // 
            this.btn_crear_condicion.Location = new System.Drawing.Point(532, 57);
            this.btn_crear_condicion.Name = "btn_crear_condicion";
            this.btn_crear_condicion.Size = new System.Drawing.Size(79, 29);
            this.btn_crear_condicion.TabIndex = 34;
            this.btn_crear_condicion.Text = "CREAR";
            this.btn_crear_condicion.UseVisualStyleBackColor = true;
            this.btn_crear_condicion.Click += new System.EventHandler(this.btn_crear_condicion_Click);
            // 
            // btn_and
            // 
            this.btn_and.Location = new System.Drawing.Point(700, 57);
            this.btn_and.Name = "btn_and";
            this.btn_and.Size = new System.Drawing.Size(83, 29);
            this.btn_and.TabIndex = 33;
            this.btn_and.Text = "\"Y\"";
            this.btn_and.UseVisualStyleBackColor = true;
            this.btn_and.Click += new System.EventHandler(this.btn_and_Click);
            // 
            // btn_or
            // 
            this.btn_or.Location = new System.Drawing.Point(617, 57);
            this.btn_or.Name = "btn_or";
            this.btn_or.Size = new System.Drawing.Size(75, 28);
            this.btn_or.TabIndex = 32;
            this.btn_or.Text = "\"O\"";
            this.btn_or.UseVisualStyleBackColor = true;
            this.btn_or.Click += new System.EventHandler(this.btn_or_Click);
            // 
            // cbo_condicion3
            // 
            this.cbo_condicion3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_condicion3.FormattingEnabled = true;
            this.cbo_condicion3.Location = new System.Drawing.Point(332, 48);
            this.cbo_condicion3.Name = "cbo_condicion3";
            this.cbo_condicion3.Size = new System.Drawing.Size(77, 29);
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
            this.cbo_condicion2.Location = new System.Drawing.Point(212, 49);
            this.cbo_condicion2.Name = "cbo_condicion2";
            this.cbo_condicion2.Size = new System.Drawing.Size(47, 29);
            this.cbo_condicion2.TabIndex = 29;
            this.cbo_condicion2.ValueMember = "=";
            // 
            // cbo_condicion1
            // 
            this.cbo_condicion1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_condicion1.FormattingEnabled = true;
            this.cbo_condicion1.Location = new System.Drawing.Point(125, 49);
            this.cbo_condicion1.Name = "cbo_condicion1";
            this.cbo_condicion1.Size = new System.Drawing.Size(80, 29);
            this.cbo_condicion1.TabIndex = 28;
            this.cbo_condicion1.SelectedIndexChanged += new System.EventHandler(this.cbo_condicion1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdb_conwhere);
            this.groupBox1.Controls.Add(this.rdb_sinwhere);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 197);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(519, 53);
            this.groupBox1.TabIndex = 74;
            this.groupBox1.TabStop = false;
            // 
            // rdb_conwhere
            // 
            this.rdb_conwhere.AutoSize = true;
            this.rdb_conwhere.Location = new System.Drawing.Point(20, 21);
            this.rdb_conwhere.Name = "rdb_conwhere";
            this.rdb_conwhere.Size = new System.Drawing.Size(191, 25);
            this.rdb_conwhere.TabIndex = 51;
            this.rdb_conwhere.TabStop = true;
            this.rdb_conwhere.Text = "CONDICION DONDE";
            this.rdb_conwhere.UseVisualStyleBackColor = true;
            this.rdb_conwhere.CheckedChanged += new System.EventHandler(this.rdb_conwhere_CheckedChanged);
            // 
            // rdb_sinwhere
            // 
            this.rdb_sinwhere.AutoSize = true;
            this.rdb_sinwhere.Location = new System.Drawing.Point(273, 21);
            this.rdb_sinwhere.Name = "rdb_sinwhere";
            this.rdb_sinwhere.Size = new System.Drawing.Size(230, 25);
            this.rdb_sinwhere.TabIndex = 52;
            this.rdb_sinwhere.TabStop = true;
            this.rdb_sinwhere.Text = "SIN CONDICION \"DONDE\"";
            this.rdb_sinwhere.UseVisualStyleBackColor = true;
            // 
            // btn_ayuda
            // 
            this.btn_ayuda.BackgroundImage = global::dllconsultasgeneraless.Properties.Resources.Button_Help_icon;
            this.btn_ayuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ayuda.FlatAppearance.BorderSize = 0;
            this.btn_ayuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ayuda.Location = new System.Drawing.Point(3, 2);
            this.btn_ayuda.Name = "btn_ayuda";
            this.btn_ayuda.Size = new System.Drawing.Size(56, 42);
            this.btn_ayuda.TabIndex = 80;
            this.btn_ayuda.UseVisualStyleBackColor = true;
            this.btn_ayuda.Click += new System.EventHandler(this.btn_ayuda_Click);
            // 
            // btn_mas
            // 
            this.btn_mas.BackgroundImage = global::dllconsultasgeneraless.Properties.Resources.Save_icon;
            this.btn_mas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_mas.FlatAppearance.BorderSize = 0;
            this.btn_mas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mas.Location = new System.Drawing.Point(870, 216);
            this.btn_mas.Name = "btn_mas";
            this.btn_mas.Size = new System.Drawing.Size(75, 55);
            this.btn_mas.TabIndex = 79;
            this.btn_mas.UseVisualStyleBackColor = true;
            this.btn_mas.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.BackgroundImage = global::dllconsultasgeneraless.Properties.Resources.Button_Close_icon;
            this.btn_limpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_limpiar.FlatAppearance.BorderSize = 0;
            this.btn_limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpiar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar.Location = new System.Drawing.Point(870, 338);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(75, 55);
            this.btn_limpiar.TabIndex = 77;
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_generarConsulta
            // 
            this.btn_generarConsulta.BackgroundImage = global::dllconsultasgeneraless.Properties.Resources.play;
            this.btn_generarConsulta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_generarConsulta.FlatAppearance.BorderSize = 0;
            this.btn_generarConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_generarConsulta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_generarConsulta.Location = new System.Drawing.Point(870, 279);
            this.btn_generarConsulta.Name = "btn_generarConsulta";
            this.btn_generarConsulta.Size = new System.Drawing.Size(75, 55);
            this.btn_generarConsulta.TabIndex = 76;
            this.btn_generarConsulta.UseVisualStyleBackColor = true;
            this.btn_generarConsulta.Click += new System.EventHandler(this.btn_generarConsulta_Click);
            // 
            // btn_add5
            // 
            this.btn_add5.BackgroundImage = global::dllconsultasgeneraless.Properties.Resources.Button_Add_icon;
            this.btn_add5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_add5.FlatAppearance.BorderSize = 0;
            this.btn_add5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add5.Location = new System.Drawing.Point(959, 153);
            this.btn_add5.Name = "btn_add5";
            this.btn_add5.Size = new System.Drawing.Size(25, 23);
            this.btn_add5.TabIndex = 71;
            this.btn_add5.UseVisualStyleBackColor = true;
            this.btn_add5.Click += new System.EventHandler(this.btn_add5_Click);
            // 
            // btn_add4
            // 
            this.btn_add4.BackgroundImage = global::dllconsultasgeneraless.Properties.Resources.Button_Add_icon;
            this.btn_add4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_add4.FlatAppearance.BorderSize = 0;
            this.btn_add4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add4.Location = new System.Drawing.Point(793, 153);
            this.btn_add4.Name = "btn_add4";
            this.btn_add4.Size = new System.Drawing.Size(25, 23);
            this.btn_add4.TabIndex = 67;
            this.btn_add4.UseVisualStyleBackColor = true;
            this.btn_add4.Click += new System.EventHandler(this.btn_add4_Click);
            // 
            // btn_add3
            // 
            this.btn_add3.BackgroundImage = global::dllconsultasgeneraless.Properties.Resources.Button_Add_icon;
            this.btn_add3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_add3.FlatAppearance.BorderSize = 0;
            this.btn_add3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add3.Location = new System.Drawing.Point(619, 153);
            this.btn_add3.Name = "btn_add3";
            this.btn_add3.Size = new System.Drawing.Size(25, 23);
            this.btn_add3.TabIndex = 63;
            this.btn_add3.UseVisualStyleBackColor = true;
            this.btn_add3.Click += new System.EventHandler(this.btn_add3_Click);
            // 
            // btn_mas1
            // 
            this.btn_mas1.BackgroundImage = global::dllconsultasgeneraless.Properties.Resources.Button_Add_icon;
            this.btn_mas1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_mas1.FlatAppearance.BorderSize = 0;
            this.btn_mas1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mas1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mas1.Location = new System.Drawing.Point(451, 153);
            this.btn_mas1.Name = "btn_mas1";
            this.btn_mas1.Size = new System.Drawing.Size(25, 23);
            this.btn_mas1.TabIndex = 56;
            this.btn_mas1.UseVisualStyleBackColor = true;
            this.btn_mas1.Click += new System.EventHandler(this.btn_add2_Click);
            // 
            // btn_add1
            // 
            this.btn_add1.BackgroundImage = global::dllconsultasgeneraless.Properties.Resources.Button_Add_icon;
            this.btn_add1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_add1.FlatAppearance.BorderSize = 0;
            this.btn_add1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add1.Location = new System.Drawing.Point(291, 153);
            this.btn_add1.Name = "btn_add1";
            this.btn_add1.Size = new System.Drawing.Size(25, 23);
            this.btn_add1.TabIndex = 55;
            this.btn_add1.UseVisualStyleBackColor = true;
            this.btn_add1.Click += new System.EventHandler(this.btn_add1_Click);
            // 
            // frm_consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1007, 601);
            this.Controls.Add(this.btn_ayuda);
            this.Controls.Add(this.btn_mas);
            this.Controls.Add(this.tcl_consulta);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_generarConsulta);
            this.Controls.Add(this.gpb_consulta);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_consAlmacen);
            this.Controls.Add(this.lbl_titulo);
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
            this.Controls.Add(this.btn_mas1);
            this.Controls.Add(this.btn_add1);
            this.Controls.Add(this.cbo_from1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbo_select1);
            this.Controls.Add(this.label1);
            this.Name = "frm_consultas";
            this.Text = "consultas";
            this.Load += new System.EventHandler(this.frm_consultas_Load);
            this.tcl_consulta.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gpb_consulta.ResumeLayout(false);
            this.gpb_consulta.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_consAlmacen;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Button btn_add5;
        private System.Windows.Forms.CheckBox chb_check4;
        private System.Windows.Forms.ComboBox cbo_from5;
        private System.Windows.Forms.ComboBox cbo_select5;
        private System.Windows.Forms.Button btn_add4;
        private System.Windows.Forms.CheckBox chb_check3;
        private System.Windows.Forms.ComboBox cbo_from4;
        private System.Windows.Forms.ComboBox cbo_select4;
        private System.Windows.Forms.Button btn_add3;
        private System.Windows.Forms.CheckBox chb_check2;
        private System.Windows.Forms.ComboBox cbo_from3;
        private System.Windows.Forms.ComboBox cbo_select3;
        private System.Windows.Forms.CheckBox chb_check1;
        private System.Windows.Forms.ComboBox cbo_from2;
        private System.Windows.Forms.ComboBox cbo_select2;
        private System.Windows.Forms.Button btn_mas1;
        private System.Windows.Forms.Button btn_add1;
        private System.Windows.Forms.ComboBox cbo_from1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbo_select1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_mas;
        private System.Windows.Forms.TabControl tcl_consulta;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lbl_vistapreviaconsulta;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_generarConsulta;
        private System.Windows.Forms.GroupBox gpb_consulta;
        private System.Windows.Forms.ComboBox cbo_indicador;
        private System.Windows.Forms.ComboBox cbo_simbolo;
        private System.Windows.Forms.ComboBox cbo_cond2_campo;
        private System.Windows.Forms.ComboBox cbo_cond2_tabla;
        private System.Windows.Forms.RadioButton rdb_cond2;
        private System.Windows.Forms.RadioButton rdb_cond1;
        private System.Windows.Forms.ComboBox cbo_tabla_condicion1;
        private System.Windows.Forms.ComboBox cbo_tabla_condicion3;
        private System.Windows.Forms.Button btn_crear_condicion;
        private System.Windows.Forms.Button btn_and;
        private System.Windows.Forms.Button btn_or;
        private System.Windows.Forms.ComboBox cbo_condicion3;
        private System.Windows.Forms.ComboBox cbo_condicion2;
        private System.Windows.Forms.ComboBox cbo_condicion1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdb_conwhere;
        private System.Windows.Forms.RadioButton rdb_sinwhere;
        private System.Windows.Forms.Button btn_ayuda;
    }
}