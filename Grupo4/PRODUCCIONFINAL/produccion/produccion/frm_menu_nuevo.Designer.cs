namespace produccion
{
    partial class frm_menu_nuevo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_menu_nuevo));
            this.cmb_tamanio_porcion = new System.Windows.Forms.ComboBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.Linea = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgv_nuevo_menu = new System.Windows.Forms.DataGridView();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Receta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tamaño = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_costo_receta = new System.Windows.Forms.Label();
            this.lbl_tamanio = new System.Windows.Forms.Label();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_receta_seleccion = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_ultimo = new System.Windows.Forms.Button();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_primero = new System.Windows.Forms.Button();
            this.btn_anterior = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_siguiente = new System.Windows.Forms.Button();
            this.Marca = new System.Windows.Forms.Label();
            this.cmb_marca = new System.Windows.Forms.ComboBox();
            this.cmb_linea = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nuevo_menu)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_tamanio_porcion
            // 
            this.cmb_tamanio_porcion.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_tamanio_porcion.FormattingEnabled = true;
            this.cmb_tamanio_porcion.Location = new System.Drawing.Point(139, 188);
            this.cmb_tamanio_porcion.Name = "cmb_tamanio_porcion";
            this.cmb_tamanio_porcion.Size = new System.Drawing.Size(74, 24);
            this.cmb_tamanio_porcion.TabIndex = 4;
            this.cmb_tamanio_porcion.SelectedIndexChanged += new System.EventHandler(this.cmb_tamanio_porcion_SelectedIndexChanged);
            // 
            // txt_nombre
            // 
            this.txt_nombre.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.Location = new System.Drawing.Point(302, 148);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(100, 21);
            this.txt_nombre.TabIndex = 2;
            // 
            // Linea
            // 
            this.Linea.AutoSize = true;
            this.Linea.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Linea.Location = new System.Drawing.Point(87, 155);
            this.Linea.Name = "Linea";
            this.Linea.Size = new System.Drawing.Size(30, 16);
            this.Linea.TabIndex = 5;
            this.Linea.Text = "Tipo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(248, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(453, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Descripción";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(453, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Receta";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descripcion.Location = new System.Drawing.Point(529, 188);
            this.txt_descripcion.Multiline = true;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(169, 75);
            this.txt_descripcion.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(258, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Precio";
            // 
            // dgv_nuevo_menu
            // 
            this.dgv_nuevo_menu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_nuevo_menu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tipo,
            this.nombre,
            this.Receta,
            this.Tamaño,
            this.Descripcion});
            this.dgv_nuevo_menu.Location = new System.Drawing.Point(71, 304);
            this.dgv_nuevo_menu.Name = "dgv_nuevo_menu";
            this.dgv_nuevo_menu.Size = new System.Drawing.Size(641, 150);
            this.dgv_nuevo_menu.TabIndex = 11;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            // 
            // Receta
            // 
            this.Receta.HeaderText = "Receta";
            this.Receta.Name = "Receta";
            // 
            // Tamaño
            // 
            this.Tamaño.HeaderText = "Tamaño";
            this.Tamaño.Name = "Tamaño";
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aceptar.Location = new System.Drawing.Point(247, 265);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_aceptar.TabIndex = 7;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Visible = false;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.Location = new System.Drawing.Point(410, 265);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 13;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Visible = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(304, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 28);
            this.label6.TabIndex = 14;
            this.label6.Text = "Nuevo menu";
            // 
            // lbl_costo_receta
            // 
            this.lbl_costo_receta.AutoSize = true;
            this.lbl_costo_receta.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_costo_receta.Location = new System.Drawing.Point(657, 155);
            this.lbl_costo_receta.Name = "lbl_costo_receta";
            this.lbl_costo_receta.Size = new System.Drawing.Size(41, 16);
            this.lbl_costo_receta.TabIndex = 15;
            this.lbl_costo_receta.Text = "label7";
            // 
            // lbl_tamanio
            // 
            this.lbl_tamanio.AutoSize = true;
            this.lbl_tamanio.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tamanio.Location = new System.Drawing.Point(83, 196);
            this.lbl_tamanio.Name = "lbl_tamanio";
            this.lbl_tamanio.Size = new System.Drawing.Size(53, 16);
            this.lbl_tamanio.TabIndex = 16;
            this.lbl_tamanio.Text = "Tamaño";
            // 
            // txt_precio
            // 
            this.txt_precio.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_precio.Location = new System.Drawing.Point(308, 188);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(100, 21);
            this.txt_precio.TabIndex = 5;
            this.txt_precio.TextChanged += new System.EventHandler(this.txt_precio_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(622, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Q. ";
            // 
            // cmb_receta_seleccion
            // 
            this.cmb_receta_seleccion.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_receta_seleccion.FormattingEnabled = true;
            this.cmb_receta_seleccion.Location = new System.Drawing.Point(502, 147);
            this.cmb_receta_seleccion.Name = "cmb_receta_seleccion";
            this.cmb_receta_seleccion.Size = new System.Drawing.Size(121, 24);
            this.cmb_receta_seleccion.TabIndex = 3;
            this.cmb_receta_seleccion.SelectedIndexChanged += new System.EventHandler(this.cmb_receta_seleccion_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_nuevo);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btn_ultimo);
            this.panel1.Controls.Add(this.btn_actualizar);
            this.panel1.Controls.Add(this.btn_guardar);
            this.panel1.Controls.Add(this.btn_buscar);
            this.panel1.Controls.Add(this.btn_primero);
            this.panel1.Controls.Add(this.btn_anterior);
            this.panel1.Controls.Add(this.btn_editar);
            this.panel1.Controls.Add(this.btn_eliminar);
            this.panel1.Controls.Add(this.btn_siguiente);
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(71, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(641, 98);
            this.panel1.TabIndex = 184;
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
            this.btn_nuevo.Location = new System.Drawing.Point(27, 21);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(65, 69);
            this.btn_nuevo.TabIndex = 171;
            this.btn_nuevo.UseVisualStyleBackColor = true;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(399, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 69);
            this.button2.TabIndex = 176;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.btn_ultimo.Location = new System.Drawing.Point(592, 54);
            this.btn_ultimo.Name = "btn_ultimo";
            this.btn_ultimo.Size = new System.Drawing.Size(33, 36);
            this.btn_ultimo.TabIndex = 181;
            this.btn_ultimo.UseVisualStyleBackColor = true;
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
            this.btn_actualizar.Location = new System.Drawing.Point(470, 18);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(65, 69);
            this.btn_actualizar.TabIndex = 177;
            this.btn_actualizar.UseVisualStyleBackColor = true;
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
            this.btn_guardar.Location = new System.Drawing.Point(115, 18);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(65, 69);
            this.btn_guardar.TabIndex = 172;
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
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
            this.btn_buscar.Location = new System.Drawing.Point(328, 18);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(65, 69);
            this.btn_buscar.TabIndex = 175;
            this.btn_buscar.UseVisualStyleBackColor = true;
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
            this.btn_primero.Location = new System.Drawing.Point(556, 54);
            this.btn_primero.Name = "btn_primero";
            this.btn_primero.Size = new System.Drawing.Size(33, 36);
            this.btn_primero.TabIndex = 180;
            this.btn_primero.UseVisualStyleBackColor = true;
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
            this.btn_anterior.Location = new System.Drawing.Point(556, 17);
            this.btn_anterior.Name = "btn_anterior";
            this.btn_anterior.Size = new System.Drawing.Size(33, 36);
            this.btn_anterior.TabIndex = 178;
            this.btn_anterior.UseVisualStyleBackColor = true;
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
            this.btn_editar.Location = new System.Drawing.Point(186, 18);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(65, 69);
            this.btn_editar.TabIndex = 173;
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
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
            this.btn_eliminar.Location = new System.Drawing.Point(257, 18);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(65, 69);
            this.btn_eliminar.TabIndex = 174;
            this.btn_eliminar.UseVisualStyleBackColor = true;
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
            this.btn_siguiente.Location = new System.Drawing.Point(592, 17);
            this.btn_siguiente.Name = "btn_siguiente";
            this.btn_siguiente.Size = new System.Drawing.Size(33, 36);
            this.btn_siguiente.TabIndex = 179;
            this.btn_siguiente.UseVisualStyleBackColor = true;
            // 
            // Marca
            // 
            this.Marca.AutoSize = true;
            this.Marca.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Marca.Location = new System.Drawing.Point(83, 235);
            this.Marca.Name = "Marca";
            this.Marca.Size = new System.Drawing.Size(45, 16);
            this.Marca.TabIndex = 186;
            this.Marca.Text = "Marca";
            // 
            // cmb_marca
            // 
            this.cmb_marca.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_marca.FormattingEnabled = true;
            this.cmb_marca.Location = new System.Drawing.Point(139, 227);
            this.cmb_marca.Name = "cmb_marca";
            this.cmb_marca.Size = new System.Drawing.Size(74, 24);
            this.cmb_marca.TabIndex = 185;
            // 
            // cmb_linea
            // 
            this.cmb_linea.FormattingEnabled = true;
            this.cmb_linea.Location = new System.Drawing.Point(139, 154);
            this.cmb_linea.Name = "cmb_linea";
            this.cmb_linea.Size = new System.Drawing.Size(74, 21);
            this.cmb_linea.TabIndex = 187;
            // 
            // frm_menu_nuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 484);
            this.Controls.Add(this.cmb_linea);
            this.Controls.Add(this.Marca);
            this.Controls.Add(this.cmb_marca);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmb_receta_seleccion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_precio);
            this.Controls.Add(this.lbl_tamanio);
            this.Controls.Add(this.lbl_costo_receta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.dgv_nuevo_menu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Linea);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.cmb_tamanio_porcion);
            this.Name = "frm_menu_nuevo";
            this.Text = "frm_menu_nuevo";
            this.Load += new System.EventHandler(this.frm_menu_nuevo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nuevo_menu)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmb_tamanio_porcion;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label Linea;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgv_nuevo_menu;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_costo_receta;
        private System.Windows.Forms.Label lbl_tamanio;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_receta_seleccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Receta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tamaño;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_ultimo;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_primero;
        private System.Windows.Forms.Button btn_anterior;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_siguiente;
        private System.Windows.Forms.Label Marca;
        private System.Windows.Forms.ComboBox cmb_marca;
        private System.Windows.Forms.ComboBox cmb_linea;
    }
}