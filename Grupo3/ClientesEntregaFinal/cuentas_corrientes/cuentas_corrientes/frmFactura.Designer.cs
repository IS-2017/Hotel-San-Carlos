namespace cuentas_corrientes
{
    partial class frmFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFactura));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_dir = new System.Windows.Forms.TextBox();
            this.txt_nit = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_subtot = new System.Windows.Forms.TextBox();
            this.dgv_detallefact = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cbo_formpago = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_serie = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_ayuda = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.btn_ultimo = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_primero = new System.Windows.Forms.Button();
            this.btn_siguiente = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_anterior = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_tot = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.check_prod = new System.Windows.Forms.CheckBox();
            this.check_pre = new System.Windows.Forms.CheckBox();
            this.check_fol = new System.Windows.Forms.CheckBox();
            this.btn_busfolio = new System.Windows.Forms.Button();
            this.btn_busped = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_prod = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_cant = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.cbo_empre = new System.Windows.Forms.ComboBox();
            this.cbo_imp = new System.Windows.Forms.ComboBox();
            this.dpic_fecven = new System.Windows.Forms.DateTimePicker();
            this.dpic_fecemi = new System.Windows.Forms.DateTimePicker();
            this.btn_Buscte = new System.Windows.Forms.Button();
            this.btn_bproducto = new System.Windows.Forms.Button();
            this.btn_agrega = new System.Windows.Forms.Button();
            this.cbo_vendedor = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detallefact)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Dirección:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(502, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nit:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Enabled = false;
            this.txt_nombre.Location = new System.Drawing.Point(134, 189);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(283, 20);
            this.txt_nombre.TabIndex = 2;
            this.txt_nombre.TextChanged += new System.EventHandler(this.txt_nombre_TextChanged);
            // 
            // txt_dir
            // 
            this.txt_dir.Enabled = false;
            this.txt_dir.Location = new System.Drawing.Point(134, 221);
            this.txt_dir.Name = "txt_dir";
            this.txt_dir.Size = new System.Drawing.Size(283, 20);
            this.txt_dir.TabIndex = 2;
            // 
            // txt_nit
            // 
            this.txt_nit.Enabled = false;
            this.txt_nit.Location = new System.Drawing.Point(546, 192);
            this.txt_nit.Name = "txt_nit";
            this.txt_nit.Size = new System.Drawing.Size(285, 20);
            this.txt_nit.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(641, 541);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "Subtotal:";
            // 
            // txt_subtot
            // 
            this.txt_subtot.Enabled = false;
            this.txt_subtot.Location = new System.Drawing.Point(728, 541);
            this.txt_subtot.Name = "txt_subtot";
            this.txt_subtot.Size = new System.Drawing.Size(103, 20);
            this.txt_subtot.TabIndex = 2;
            // 
            // dgv_detallefact
            // 
            this.dgv_detallefact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_detallefact.Location = new System.Drawing.Point(18, 366);
            this.dgv_detallefact.Name = "dgv_detallefact";
            this.dgv_detallefact.Size = new System.Drawing.Size(813, 169);
            this.dgv_detallefact.TabIndex = 4;
            this.dgv_detallefact.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgv_detallefact.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgv_detallefact_KeyDown);
            this.dgv_detallefact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgv_detallefact_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(641, 576);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 21);
            this.label9.TabIndex = 1;
            this.label9.Text = "Impuesto";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(559, 444);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 17);
            this.label10.TabIndex = 1;
            this.label10.Text = "Detalle Factura";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(41, 253);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(165, 21);
            this.label11.TabIndex = 1;
            this.label11.Text = "Fecha vencimiento:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(502, 225);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(124, 21);
            this.label12.TabIndex = 1;
            this.label12.Text = "Fecha emisión:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(45, 281);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(135, 21);
            this.label13.TabIndex = 1;
            this.label13.Text = "Forma de pago:";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // cbo_formpago
            // 
            this.cbo_formpago.FormattingEnabled = true;
            this.cbo_formpago.Location = new System.Drawing.Point(175, 280);
            this.cbo_formpago.Name = "cbo_formpago";
            this.cbo_formpago.Size = new System.Drawing.Size(199, 21);
            this.cbo_formpago.TabIndex = 6;
            this.cbo_formpago.SelectedIndexChanged += new System.EventHandler(this.cbo_formpago_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(252, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 21);
            this.label1.TabIndex = 21;
            this.label1.Text = "Serie:";
            // 
            // cbo_serie
            // 
            this.cbo_serie.FormattingEnabled = true;
            this.cbo_serie.Location = new System.Drawing.Point(308, 139);
            this.cbo_serie.Name = "cbo_serie";
            this.cbo_serie.Size = new System.Drawing.Size(103, 21);
            this.cbo_serie.TabIndex = 22;
            this.cbo_serie.SelectedIndexChanged += new System.EventHandler(this.cbo_serie_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_ayuda);
            this.groupBox1.Controls.Add(this.btn_editar);
            this.groupBox1.Controls.Add(this.btn_nuevo);
            this.groupBox1.Controls.Add(this.btn_ultimo);
            this.groupBox1.Controls.Add(this.btn_guardar);
            this.groupBox1.Controls.Add(this.btn_primero);
            this.groupBox1.Controls.Add(this.btn_siguiente);
            this.groupBox1.Controls.Add(this.btn_eliminar);
            this.groupBox1.Controls.Add(this.btn_anterior);
            this.groupBox1.Controls.Add(this.btn_cancelar);
            this.groupBox1.Location = new System.Drawing.Point(175, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(531, 100);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Navegador";
            // 
            // btn_ayuda
            // 
            this.btn_ayuda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ayuda.BackgroundImage")));
            this.btn_ayuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ayuda.Location = new System.Drawing.Point(456, 24);
            this.btn_ayuda.Name = "btn_ayuda";
            this.btn_ayuda.Size = new System.Drawing.Size(65, 65);
            this.btn_ayuda.TabIndex = 12;
            this.btn_ayuda.UseVisualStyleBackColor = true;
            this.btn_ayuda.Click += new System.EventHandler(this.btn_ayuda_Click);
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
            this.btn_editar.Location = new System.Drawing.Point(231, 19);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(65, 65);
            this.btn_editar.TabIndex = 11;
            this.btn_editar.UseVisualStyleBackColor = true;
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
            this.btn_nuevo.Location = new System.Drawing.Point(17, 19);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(65, 65);
            this.btn_nuevo.TabIndex = 0;
            this.btn_nuevo.UseVisualStyleBackColor = true;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click_1);
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
            this.btn_ultimo.Location = new System.Drawing.Point(409, 55);
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
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
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
            this.btn_primero.Location = new System.Drawing.Point(373, 55);
            this.btn_primero.Name = "btn_primero";
            this.btn_primero.Size = new System.Drawing.Size(33, 33);
            this.btn_primero.TabIndex = 9;
            this.btn_primero.UseVisualStyleBackColor = true;
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
            this.btn_siguiente.Location = new System.Drawing.Point(409, 20);
            this.btn_siguiente.Name = "btn_siguiente";
            this.btn_siguiente.Size = new System.Drawing.Size(33, 33);
            this.btn_siguiente.TabIndex = 8;
            this.btn_siguiente.UseVisualStyleBackColor = true;
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
            this.btn_eliminar.Location = new System.Drawing.Point(162, 18);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(65, 65);
            this.btn_eliminar.TabIndex = 3;
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
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
            this.btn_anterior.Location = new System.Drawing.Point(373, 20);
            this.btn_anterior.Name = "btn_anterior";
            this.btn_anterior.Size = new System.Drawing.Size(33, 33);
            this.btn_anterior.TabIndex = 7;
            this.btn_anterior.UseVisualStyleBackColor = true;
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
            this.btn_cancelar.Location = new System.Drawing.Point(305, 19);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(65, 65);
            this.btn_cancelar.TabIndex = 5;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(37, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 21);
            this.label6.TabIndex = 21;
            this.label6.Text = "Empresa:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 611);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 25);
            this.label8.TabIndex = 1;
            this.label8.Text = "Total:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txt_tot
            // 
            this.txt_tot.Enabled = false;
            this.txt_tot.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tot.Location = new System.Drawing.Point(73, 604);
            this.txt_tot.Name = "txt_tot";
            this.txt_tot.Size = new System.Drawing.Size(103, 35);
            this.txt_tot.TabIndex = 2;
            this.txt_tot.TextChanged += new System.EventHandler(this.txt_tot_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.check_prod);
            this.groupBox2.Controls.Add(this.check_pre);
            this.groupBox2.Controls.Add(this.check_fol);
            this.groupBox2.Controls.Add(this.btn_busfolio);
            this.groupBox2.Controls.Add(this.btn_busped);
            this.groupBox2.Location = new System.Drawing.Point(18, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(151, 100);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo";
            // 
            // check_prod
            // 
            this.check_prod.AutoSize = true;
            this.check_prod.Location = new System.Drawing.Point(14, 70);
            this.check_prod.Name = "check_prod";
            this.check_prod.Size = new System.Drawing.Size(74, 17);
            this.check_prod.TabIndex = 0;
            this.check_prod.Text = "Productos";
            this.check_prod.UseVisualStyleBackColor = true;
            this.check_prod.CheckedChanged += new System.EventHandler(this.check_prod_CheckedChanged);
            // 
            // check_pre
            // 
            this.check_pre.AutoSize = true;
            this.check_pre.Location = new System.Drawing.Point(14, 47);
            this.check_pre.Name = "check_pre";
            this.check_pre.Size = new System.Drawing.Size(59, 17);
            this.check_pre.TabIndex = 0;
            this.check_pre.Text = "Pedido";
            this.check_pre.UseVisualStyleBackColor = true;
            this.check_pre.CheckedChanged += new System.EventHandler(this.check_pre_CheckedChanged);
            // 
            // check_fol
            // 
            this.check_fol.AutoSize = true;
            this.check_fol.Location = new System.Drawing.Point(14, 24);
            this.check_fol.Name = "check_fol";
            this.check_fol.Size = new System.Drawing.Size(48, 17);
            this.check_fol.TabIndex = 0;
            this.check_fol.Text = "Folio";
            this.check_fol.UseVisualStyleBackColor = true;
            this.check_fol.CheckedChanged += new System.EventHandler(this.check_fol_CheckedChanged);
            // 
            // btn_busfolio
            // 
            this.btn_busfolio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_busfolio.BackgroundImage")));
            this.btn_busfolio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_busfolio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_busfolio.FlatAppearance.BorderSize = 0;
            this.btn_busfolio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_busfolio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_busfolio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_busfolio.Location = new System.Drawing.Point(64, 24);
            this.btn_busfolio.Name = "btn_busfolio";
            this.btn_busfolio.Size = new System.Drawing.Size(15, 15);
            this.btn_busfolio.TabIndex = 4;
            this.btn_busfolio.UseVisualStyleBackColor = true;
            this.btn_busfolio.Click += new System.EventHandler(this.btn_busfolio_Click);
            // 
            // btn_busped
            // 
            this.btn_busped.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_busped.BackgroundImage")));
            this.btn_busped.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_busped.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_busped.FlatAppearance.BorderSize = 0;
            this.btn_busped.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_busped.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_busped.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_busped.Location = new System.Drawing.Point(79, 46);
            this.btn_busped.Name = "btn_busped";
            this.btn_busped.Size = new System.Drawing.Size(17, 16);
            this.btn_busped.TabIndex = 4;
            this.btn_busped.UseVisualStyleBackColor = true;
            this.btn_busped.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(22, 337);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 21);
            this.label15.TabIndex = 1;
            this.label15.Text = "Producto";
            // 
            // txt_prod
            // 
            this.txt_prod.Enabled = false;
            this.txt_prod.Location = new System.Drawing.Point(110, 337);
            this.txt_prod.Name = "txt_prod";
            this.txt_prod.Size = new System.Drawing.Size(168, 20);
            this.txt_prod.TabIndex = 2;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(330, 337);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(87, 21);
            this.label16.TabIndex = 1;
            this.label16.Text = "Cantidad";
            // 
            // txt_cant
            // 
            this.txt_cant.Location = new System.Drawing.Point(423, 338);
            this.txt_cant.Name = "txt_cant";
            this.txt_cant.Size = new System.Drawing.Size(122, 20);
            this.txt_cant.TabIndex = 2;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(588, 338);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(57, 21);
            this.label17.TabIndex = 1;
            this.label17.Text = "Precio";
            // 
            // txt_precio
            // 
            this.txt_precio.Enabled = false;
            this.txt_precio.Location = new System.Drawing.Point(642, 340);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(122, 20);
            this.txt_precio.TabIndex = 2;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(502, 254);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(92, 21);
            this.label18.TabIndex = 1;
            this.label18.Text = "Vendedor:";
            // 
            // cbo_empre
            // 
            this.cbo_empre.FormattingEnabled = true;
            this.cbo_empre.Location = new System.Drawing.Point(121, 139);
            this.cbo_empre.Name = "cbo_empre";
            this.cbo_empre.Size = new System.Drawing.Size(121, 21);
            this.cbo_empre.TabIndex = 43;
            this.cbo_empre.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cbo_imp
            // 
            this.cbo_imp.Enabled = false;
            this.cbo_imp.FormattingEnabled = true;
            this.cbo_imp.Location = new System.Drawing.Point(728, 576);
            this.cbo_imp.Name = "cbo_imp";
            this.cbo_imp.Size = new System.Drawing.Size(103, 21);
            this.cbo_imp.TabIndex = 45;
            // 
            // dpic_fecven
            // 
            this.dpic_fecven.Location = new System.Drawing.Point(202, 254);
            this.dpic_fecven.Name = "dpic_fecven";
            this.dpic_fecven.Size = new System.Drawing.Size(215, 20);
            this.dpic_fecven.TabIndex = 46;
            this.dpic_fecven.Value = new System.DateTime(2016, 11, 5, 0, 0, 0, 0);
            // 
            // dpic_fecemi
            // 
            this.dpic_fecemi.Location = new System.Drawing.Point(631, 225);
            this.dpic_fecemi.Name = "dpic_fecemi";
            this.dpic_fecemi.Size = new System.Drawing.Size(200, 20);
            this.dpic_fecemi.TabIndex = 47;
            this.dpic_fecemi.ValueChanged += new System.EventHandler(this.dpic_fecemi_ValueChanged);
            // 
            // btn_Buscte
            // 
            this.btn_Buscte.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Buscte.BackgroundImage")));
            this.btn_Buscte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Buscte.Location = new System.Drawing.Point(423, 186);
            this.btn_Buscte.Name = "btn_Buscte";
            this.btn_Buscte.Size = new System.Drawing.Size(29, 23);
            this.btn_Buscte.TabIndex = 3;
            this.btn_Buscte.UseVisualStyleBackColor = true;
            this.btn_Buscte.Click += new System.EventHandler(this.btn_Buscte_Click);
            // 
            // btn_bproducto
            // 
            this.btn_bproducto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_bproducto.BackgroundImage")));
            this.btn_bproducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_bproducto.Location = new System.Drawing.Point(284, 334);
            this.btn_bproducto.Name = "btn_bproducto";
            this.btn_bproducto.Size = new System.Drawing.Size(29, 23);
            this.btn_bproducto.TabIndex = 48;
            this.btn_bproducto.UseVisualStyleBackColor = true;
            this.btn_bproducto.Click += new System.EventHandler(this.btn_bproducto_Click);
            // 
            // btn_agrega
            // 
            this.btn_agrega.BackgroundImage = global::cuentas_corrientes.Properties.Resources.nuevo;
            this.btn_agrega.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_agrega.Location = new System.Drawing.Point(770, 336);
            this.btn_agrega.Name = "btn_agrega";
            this.btn_agrega.Size = new System.Drawing.Size(29, 23);
            this.btn_agrega.TabIndex = 49;
            this.btn_agrega.UseVisualStyleBackColor = true;
            this.btn_agrega.Click += new System.EventHandler(this.btn_agrega_Click);
            // 
            // cbo_vendedor
            // 
            this.cbo_vendedor.FormattingEnabled = true;
            this.cbo_vendedor.Location = new System.Drawing.Point(603, 254);
            this.cbo_vendedor.Name = "cbo_vendedor";
            this.cbo_vendedor.Size = new System.Drawing.Size(103, 21);
            this.cbo_vendedor.TabIndex = 50;
            // 
            // frmFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(853, 651);
            this.Controls.Add(this.cbo_vendedor);
            this.Controls.Add(this.btn_agrega);
            this.Controls.Add(this.btn_bproducto);
            this.Controls.Add(this.dpic_fecemi);
            this.Controls.Add(this.dpic_fecven);
            this.Controls.Add(this.cbo_imp);
            this.Controls.Add(this.cbo_empre);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbo_serie);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbo_formpago);
            this.Controls.Add(this.dgv_detallefact);
            this.Controls.Add(this.btn_Buscte);
            this.Controls.Add(this.txt_tot);
            this.Controls.Add(this.txt_subtot);
            this.Controls.Add(this.txt_precio);
            this.Controls.Add(this.txt_cant);
            this.Controls.Add(this.txt_prod);
            this.Controls.Add(this.txt_nit);
            this.Controls.Add(this.txt_dir);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturación";
            this.Load += new System.EventHandler(this.frmFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detallefact)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_dir;
        private System.Windows.Forms.TextBox txt_nit;
        private System.Windows.Forms.Button btn_Buscte;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_subtot;
        private System.Windows.Forms.DataGridView dgv_detallefact;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbo_formpago;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_serie;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Button btn_ultimo;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_primero;
        private System.Windows.Forms.Button btn_siguiente;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_anterior;
        private System.Windows.Forms.Button btn_busped;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_tot;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox check_prod;
        private System.Windows.Forms.CheckBox check_pre;
        private System.Windows.Forms.CheckBox check_fol;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_prod;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_cant;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cbo_empre;
        private System.Windows.Forms.Button btn_busfolio;
        private System.Windows.Forms.ComboBox cbo_imp;
        private System.Windows.Forms.DateTimePicker dpic_fecven;
        private System.Windows.Forms.DateTimePicker dpic_fecemi;
        private System.Windows.Forms.Button btn_bproducto;
        private System.Windows.Forms.Button btn_agrega;
        private System.Windows.Forms.ComboBox cbo_vendedor;
        private System.Windows.Forms.Button btn_ayuda;
        private System.Windows.Forms.Button btn_editar;
    }
}

