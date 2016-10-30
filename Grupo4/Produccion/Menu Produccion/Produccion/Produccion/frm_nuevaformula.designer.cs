namespace produccion
{
    partial class frm_nuevaformula
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_materia_prima = new System.Windows.Forms.ComboBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.dgv_cuerpo_formula = new System.Windows.Forms.DataGridView();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MateriaPrima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Medida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoProceso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horas_hombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_proceso = new System.Windows.Forms.ComboBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.llbl_nuevo_proceso = new System.Windows.Forms.LinkLabel();
            this.cmb_medida = new System.Windows.Forms.ComboBox();
            this.cmb_categoria = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.dgv_cuerpo_formula_ID = new System.Windows.Forms.DataGridView();
            this.CategoriaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MateriaPrimaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedidaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoProcesoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horas_hombreID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_nombre_formula = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_precio = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_quitar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_costo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_encabezado = new System.Windows.Forms.Label();
            this.llb_asigna_mp = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cuerpo_formula)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cuerpo_formula_ID)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(544, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Materia Prima:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cantidad: ";
            // 
            // cmb_materia_prima
            // 
            this.cmb_materia_prima.FormattingEnabled = true;
            this.cmb_materia_prima.Location = new System.Drawing.Point(639, 78);
            this.cmb_materia_prima.Name = "cmb_materia_prima";
            this.cmb_materia_prima.Size = new System.Drawing.Size(156, 21);
            this.cmb_materia_prima.TabIndex = 2;
            this.cmb_materia_prima.SelectedIndexChanged += new System.EventHandler(this.cmb_materia_prima_SelectedIndexChanged);
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(193, 226);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_agregar.TabIndex = 6;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // dgv_cuerpo_formula
            // 
            this.dgv_cuerpo_formula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cuerpo_formula.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Categoria,
            this.MateriaPrima,
            this.Cantidad,
            this.Medida,
            this.TipoProceso,
            this.horas_hombre,
            this.Costo});
            this.dgv_cuerpo_formula.Location = new System.Drawing.Point(39, 255);
            this.dgv_cuerpo_formula.Name = "dgv_cuerpo_formula";
            this.dgv_cuerpo_formula.Size = new System.Drawing.Size(613, 199);
            this.dgv_cuerpo_formula.TabIndex = 8;
            // 
            // Categoria
            // 
            this.Categoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            this.Categoria.Width = 77;
            // 
            // MateriaPrima
            // 
            this.MateriaPrima.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MateriaPrima.HeaderText = "Materia Prima";
            this.MateriaPrima.Name = "MateriaPrima";
            this.MateriaPrima.Width = 88;
            // 
            // Cantidad
            // 
            this.Cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 74;
            // 
            // Medida
            // 
            this.Medida.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Medida.HeaderText = "Medida";
            this.Medida.Name = "Medida";
            this.Medida.Width = 67;
            // 
            // TipoProceso
            // 
            this.TipoProceso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.TipoProceso.HeaderText = "Tipo de Proceso";
            this.TipoProceso.Name = "TipoProceso";
            this.TipoProceso.Width = 101;
            // 
            // horas_hombre
            // 
            this.horas_hombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.horas_hombre.HeaderText = "Horas Hombre";
            this.horas_hombre.Name = "horas_hombre";
            this.horas_hombre.Width = 92;
            // 
            // Costo
            // 
            this.Costo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Costo.HeaderText = "Costo";
            this.Costo.Name = "Costo";
            this.Costo.Width = 59;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(310, 472);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Cancelar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(531, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tipo de proceso:";
            // 
            // cmb_proceso
            // 
            this.cmb_proceso.FormattingEnabled = true;
            this.cmb_proceso.Items.AddRange(new object[] {
            "hola"});
            this.cmb_proceso.Location = new System.Drawing.Point(639, 118);
            this.cmb_proceso.Name = "cmb_proceso";
            this.cmb_proceso.Size = new System.Drawing.Size(156, 21);
            this.cmb_proceso.TabIndex = 11;
            this.cmb_proceso.SelectedIndexChanged += new System.EventHandler(this.cmb_proceso_SelectedIndexChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(854, 21);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(102, 13);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Consultar Formulario";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(294, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 29);
            this.label5.TabIndex = 13;
            this.label5.Text = "Nueva Receta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(259, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Medida:";
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(113, 129);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(70, 20);
            this.txt_cantidad.TabIndex = 15;
            this.txt_cantidad.TextChanged += new System.EventHandler(this.txt_cantidad_TextChanged);
            // 
            // llbl_nuevo_proceso
            // 
            this.llbl_nuevo_proceso.AutoSize = true;
            this.llbl_nuevo_proceso.Location = new System.Drawing.Point(801, 129);
            this.llbl_nuevo_proceso.Name = "llbl_nuevo_proceso";
            this.llbl_nuevo_proceso.Size = new System.Drawing.Size(81, 13);
            this.llbl_nuevo_proceso.TabIndex = 16;
            this.llbl_nuevo_proceso.TabStop = true;
            this.llbl_nuevo_proceso.Text = "Nuevo Proceso";
            this.llbl_nuevo_proceso.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbl_nuevo_proceso_LinkClicked);
            // 
            // cmb_medida
            // 
            this.cmb_medida.FormattingEnabled = true;
            this.cmb_medida.Location = new System.Drawing.Point(353, 118);
            this.cmb_medida.Name = "cmb_medida";
            this.cmb_medida.Size = new System.Drawing.Size(121, 21);
            this.cmb_medida.TabIndex = 17;
            // 
            // cmb_categoria
            // 
            this.cmb_categoria.FormattingEnabled = true;
            this.cmb_categoria.Location = new System.Drawing.Point(353, 78);
            this.cmb_categoria.Name = "cmb_categoria";
            this.cmb_categoria.Size = new System.Drawing.Size(121, 21);
            this.cmb_categoria.TabIndex = 18;
            this.cmb_categoria.SelectedIndexChanged += new System.EventHandler(this.cmb_categoria_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Categoria:";
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(193, 471);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_aceptar.TabIndex = 20;
            this.btn_aceptar.Text = "Aceptar\r\n";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // dgv_cuerpo_formula_ID
            // 
            this.dgv_cuerpo_formula_ID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cuerpo_formula_ID.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CategoriaID,
            this.MateriaPrimaID,
            this.CantidadID,
            this.MedidaID,
            this.TipoProcesoID,
            this.horas_hombreID,
            this.CostoID});
            this.dgv_cuerpo_formula_ID.Location = new System.Drawing.Point(39, 358);
            this.dgv_cuerpo_formula_ID.Name = "dgv_cuerpo_formula_ID";
            this.dgv_cuerpo_formula_ID.Size = new System.Drawing.Size(613, 97);
            this.dgv_cuerpo_formula_ID.TabIndex = 21;
            this.dgv_cuerpo_formula_ID.Visible = false;
            // 
            // CategoriaID
            // 
            this.CategoriaID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.CategoriaID.HeaderText = "Categoria";
            this.CategoriaID.Name = "CategoriaID";
            this.CategoriaID.Width = 77;
            // 
            // MateriaPrimaID
            // 
            this.MateriaPrimaID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.MateriaPrimaID.HeaderText = "Materia Prima";
            this.MateriaPrimaID.Name = "MateriaPrimaID";
            this.MateriaPrimaID.Width = 88;
            // 
            // CantidadID
            // 
            this.CantidadID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.CantidadID.HeaderText = "Cantidad";
            this.CantidadID.Name = "CantidadID";
            this.CantidadID.Width = 74;
            // 
            // MedidaID
            // 
            this.MedidaID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.MedidaID.HeaderText = "Medida";
            this.MedidaID.Name = "MedidaID";
            this.MedidaID.Width = 67;
            // 
            // TipoProcesoID
            // 
            this.TipoProcesoID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.TipoProcesoID.HeaderText = "Tipo de Proceso";
            this.TipoProcesoID.Name = "TipoProcesoID";
            this.TipoProcesoID.Width = 101;
            // 
            // horas_hombreID
            // 
            this.horas_hombreID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.horas_hombreID.HeaderText = "Horas Hombre";
            this.horas_hombreID.Name = "horas_hombreID";
            this.horas_hombreID.Width = 92;
            // 
            // CostoID
            // 
            this.CostoID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.CostoID.HeaderText = "Costo";
            this.CostoID.Name = "CostoID";
            this.CostoID.Width = 59;
            // 
            // txt_nombre_formula
            // 
            this.txt_nombre_formula.Location = new System.Drawing.Point(113, 89);
            this.txt_nombre_formula.Name = "txt_nombre_formula";
            this.txt_nombre_formula.Size = new System.Drawing.Size(100, 20);
            this.txt_nombre_formula.TabIndex = 22;
            this.txt_nombre_formula.TextChanged += new System.EventHandler(this.txt_nombre_formula_TextChanged);
            this.txt_nombre_formula.Enter += new System.EventHandler(this.txt_nombre_formula_Enter);
            this.txt_nombre_formula.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txt_nombre_formula_MouseDoubleClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Nombre:";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.Location = new System.Drawing.Point(94, 49);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(104, 16);
            this.lbl_nombre.TabIndex = 24;
            this.lbl_nombre.Text = "Nombre formula";
            this.lbl_nombre.Click += new System.EventHandler(this.lbl_nombre_Click);
            // 
            // lbl_precio
            // 
            this.lbl_precio.AutoSize = true;
            this.lbl_precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_precio.Location = new System.Drawing.Point(115, 94);
            this.lbl_precio.Name = "lbl_precio";
            this.lbl_precio.Size = new System.Drawing.Size(0, 16);
            this.lbl_precio.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(28, 94);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 16);
            this.label11.TabIndex = 27;
            this.label11.Text = "Hrs hombre:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(28, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 16);
            this.label8.TabIndex = 28;
            this.label8.Text = "Formula:";
            // 
            // btn_quitar
            // 
            this.btn_quitar.Location = new System.Drawing.Point(310, 226);
            this.btn_quitar.Name = "btn_quitar";
            this.btn_quitar.Size = new System.Drawing.Size(75, 23);
            this.btn_quitar.TabIndex = 29;
            this.btn_quitar.Text = "Quitar";
            this.btn_quitar.UseVisualStyleBackColor = true;
            this.btn_quitar.Click += new System.EventHandler(this.btn_quitar_Click);
            // 
            // button1
            // 
            //this.button1.BackgroundImage = global::NuevaFormula.Properties.Resources.refresh_button;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(869, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 53);
            this.button1.TabIndex = 30;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(28, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 16);
            this.label9.TabIndex = 31;
            this.label9.Text = "Costo";
            // 
            // lbl_costo
            // 
            this.lbl_costo.AutoSize = true;
            this.lbl_costo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_costo.Location = new System.Drawing.Point(94, 146);
            this.lbl_costo.Name = "lbl_costo";
            this.lbl_costo.Size = new System.Drawing.Size(41, 16);
            this.lbl_costo.TabIndex = 32;
            this.lbl_costo.Text = "costo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_costo);
            this.groupBox1.Controls.Add(this.lbl_nombre);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lbl_precio);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(700, 255);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 199);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Descripción";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(611, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "ID encabezado";
            this.label10.Visible = false;
            // 
            // lbl_encabezado
            // 
            this.lbl_encabezado.AutoSize = true;
            this.lbl_encabezado.Location = new System.Drawing.Point(697, 21);
            this.lbl_encabezado.Name = "lbl_encabezado";
            this.lbl_encabezado.Size = new System.Drawing.Size(41, 13);
            this.lbl_encabezado.TabIndex = 35;
            this.lbl_encabezado.Text = "label12";
            this.lbl_encabezado.Visible = false;
            // 
            // llb_asigna_mp
            // 
            this.llb_asigna_mp.AutoSize = true;
            this.llb_asigna_mp.Location = new System.Drawing.Point(36, 25);
            this.llb_asigna_mp.Name = "llb_asigna_mp";
            this.llb_asigna_mp.Size = new System.Drawing.Size(109, 13);
            this.llb_asigna_mp.TabIndex = 36;
            this.llb_asigna_mp.TabStop = true;
            this.llb_asigna_mp.Text = "Asignar Materia Prima";
            this.llb_asigna_mp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llb_asigna_mp_LinkClicked);
            // 
            // frm_nuevaformula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(968, 496);
            this.Controls.Add(this.llb_asigna_mp);
            this.Controls.Add(this.lbl_encabezado);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_quitar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_nombre_formula);
            this.Controls.Add(this.dgv_cuerpo_formula_ID);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_categoria);
            this.Controls.Add(this.cmb_medida);
            this.Controls.Add(this.llbl_nuevo_proceso);
            this.Controls.Add(this.txt_cantidad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.cmb_proceso);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dgv_cuerpo_formula);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.cmb_materia_prima);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "frm_nuevaformula";
            this.Text = "Nueva Formula";
            this.Load += new System.EventHandler(this.frm_nuevaformula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cuerpo_formula)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cuerpo_formula_ID)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_materia_prima;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.DataGridView dgv_cuerpo_formula;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_proceso;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.LinkLabel llbl_nuevo_proceso;
        private System.Windows.Forms.ComboBox cmb_medida;
        private System.Windows.Forms.ComboBox cmb_categoria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.DataGridView dgv_cuerpo_formula_ID;
        private System.Windows.Forms.TextBox txt_nombre_formula;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_precio;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_quitar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn MateriaPrima;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medida;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoProceso;
        private System.Windows.Forms.DataGridViewTextBoxColumn horas_hombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoriaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MateriaPrimaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedidaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoProcesoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn horas_hombreID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_costo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_encabezado;
        private System.Windows.Forms.LinkLabel llb_asigna_mp;
    }
}

