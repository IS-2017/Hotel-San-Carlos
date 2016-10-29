namespace WindowsFormsApplication5
{
    partial class CompraProveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompraProveedores));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.dgv_compras = new System.Windows.Forms.DataGridView();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.lbl_buscar = new System.Windows.Forms.Label();
            this.lbl_no_factura = new System.Windows.Forms.Label();
            this.lbl_pedido_compra = new System.Windows.Forms.Label();
            this.lbl_serie_factura = new System.Windows.Forms.Label();
            this.lbl_fecha_recibida = new System.Windows.Forms.Label();
            this.lbl_encargado = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.lbl_cuenta_por_pagar = new System.Windows.Forms.Label();
            this.lbl_proveedor = new System.Windows.Forms.Label();
            this.lbl_forma_pago = new System.Windows.Forms.Label();
            this.txt_no_factura = new System.Windows.Forms.TextBox();
            this.txt_serie_factura = new System.Windows.Forms.TextBox();
            this.txt_pedido_compra = new System.Windows.Forms.TextBox();
            this.dtp_fecha_recibida = new System.Windows.Forms.DateTimePicker();
            this.txt_invisible_fecha_recibida = new System.Windows.Forms.TextBox();
            this.txt_encargado = new System.Windows.Forms.TextBox();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.cbm_cuenta_por_pagar = new System.Windows.Forms.ComboBox();
            this.txt_invisible_cuenta_por_pagar = new System.Windows.Forms.TextBox();
            this.cbm_proveedor = new System.Windows.Forms.ComboBox();
            this.txt_invisible_proveedor = new System.Windows.Forms.TextBox();
            this.cbm_forma_pago = new System.Windows.Forms.ComboBox();
            this.txt_invisible_forma_pago = new System.Windows.Forms.TextBox();
            this.txt_estado = new System.Windows.Forms.TextBox();
            this.lbl_id_factura_compra_pk = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_compras)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_nuevo);
            this.groupBox1.Controls.Add(this.btn_ultimo);
            this.groupBox1.Controls.Add(this.btn_guardar);
            this.groupBox1.Controls.Add(this.btn_primero);
            this.groupBox1.Controls.Add(this.btn_editar);
            this.groupBox1.Controls.Add(this.btn_siguiente);
            this.groupBox1.Controls.Add(this.btn_eliminar);
            this.groupBox1.Controls.Add(this.btn_anterior);
            this.groupBox1.Controls.Add(this.btn_buscar);
            this.groupBox1.Controls.Add(this.btn_actualizar);
            this.groupBox1.Controls.Add(this.btn_cancelar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(135, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(848, 139);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Navegador";
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
            this.btn_nuevo.Location = new System.Drawing.Point(23, 30);
            this.btn_nuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(87, 90);
            this.btn_nuevo.TabIndex = 0;
            this.btn_nuevo.UseVisualStyleBackColor = true;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
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
            this.btn_ultimo.Location = new System.Drawing.Point(753, 73);
            this.btn_ultimo.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ultimo.Name = "btn_ultimo";
            this.btn_ultimo.Size = new System.Drawing.Size(44, 47);
            this.btn_ultimo.TabIndex = 10;
            this.btn_ultimo.UseVisualStyleBackColor = true;
            this.btn_ultimo.Click += new System.EventHandler(this.btn_ultimo_Click);
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
            this.btn_guardar.Location = new System.Drawing.Point(117, 26);
            this.btn_guardar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(87, 90);
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
            this.btn_primero.Location = new System.Drawing.Point(705, 73);
            this.btn_primero.Margin = new System.Windows.Forms.Padding(4);
            this.btn_primero.Name = "btn_primero";
            this.btn_primero.Size = new System.Drawing.Size(44, 47);
            this.btn_primero.TabIndex = 9;
            this.btn_primero.UseVisualStyleBackColor = true;
            this.btn_primero.Click += new System.EventHandler(this.btn_primero_Click);
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
            this.btn_editar.Location = new System.Drawing.Point(212, 26);
            this.btn_editar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(87, 90);
            this.btn_editar.TabIndex = 2;
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
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
            this.btn_siguiente.Location = new System.Drawing.Point(753, 24);
            this.btn_siguiente.Margin = new System.Windows.Forms.Padding(4);
            this.btn_siguiente.Name = "btn_siguiente";
            this.btn_siguiente.Size = new System.Drawing.Size(44, 47);
            this.btn_siguiente.TabIndex = 8;
            this.btn_siguiente.UseVisualStyleBackColor = true;
            this.btn_siguiente.Click += new System.EventHandler(this.btn_siguiente_Click);
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
            this.btn_eliminar.Location = new System.Drawing.Point(307, 26);
            this.btn_eliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(87, 90);
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
            this.btn_anterior.Location = new System.Drawing.Point(705, 24);
            this.btn_anterior.Margin = new System.Windows.Forms.Padding(4);
            this.btn_anterior.Name = "btn_anterior";
            this.btn_anterior.Size = new System.Drawing.Size(44, 47);
            this.btn_anterior.TabIndex = 7;
            this.btn_anterior.UseVisualStyleBackColor = true;
            this.btn_anterior.Click += new System.EventHandler(this.btn_anterior_Click);
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
            this.btn_buscar.Location = new System.Drawing.Point(401, 26);
            this.btn_buscar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(87, 90);
            this.btn_buscar.TabIndex = 4;
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
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
            this.btn_actualizar.Location = new System.Drawing.Point(591, 26);
            this.btn_actualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(87, 90);
            this.btn_actualizar.TabIndex = 6;
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
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
            this.btn_cancelar.Location = new System.Drawing.Point(495, 26);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(87, 90);
            this.btn_cancelar.TabIndex = 5;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // dgv_compras
            // 
            this.dgv_compras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_compras.Location = new System.Drawing.Point(135, 289);
            this.dgv_compras.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_compras.Name = "dgv_compras";
            this.dgv_compras.ReadOnly = true;
            this.dgv_compras.Size = new System.Drawing.Size(848, 311);
            this.dgv_compras.TabIndex = 19;
            this.dgv_compras.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_compras_CellDoubleClick);
            // 
            // txt_buscar
            // 
            this.txt_buscar.Location = new System.Drawing.Point(775, 261);
            this.txt_buscar.Margin = new System.Windows.Forms.Padding(4);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(208, 20);
            this.txt_buscar.TabIndex = 18;
            this.txt_buscar.Tag = "buscar";
            // 
            // lbl_buscar
            // 
            this.lbl_buscar.AutoSize = true;
            this.lbl_buscar.Location = new System.Drawing.Point(709, 268);
            this.lbl_buscar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_buscar.Name = "lbl_buscar";
            this.lbl_buscar.Size = new System.Drawing.Size(40, 13);
            this.lbl_buscar.TabIndex = 15;
            this.lbl_buscar.Text = "Buscar";
            // 
            // lbl_no_factura
            // 
            this.lbl_no_factura.AutoSize = true;
            this.lbl_no_factura.Location = new System.Drawing.Point(132, 181);
            this.lbl_no_factura.Name = "lbl_no_factura";
            this.lbl_no_factura.Size = new System.Drawing.Size(63, 13);
            this.lbl_no_factura.TabIndex = 21;
            this.lbl_no_factura.Text = "No. Factura";
            // 
            // lbl_pedido_compra
            // 
            this.lbl_pedido_compra.AutoSize = true;
            this.lbl_pedido_compra.Location = new System.Drawing.Point(670, 181);
            this.lbl_pedido_compra.Name = "lbl_pedido_compra";
            this.lbl_pedido_compra.Size = new System.Drawing.Size(79, 13);
            this.lbl_pedido_compra.TabIndex = 22;
            this.lbl_pedido_compra.Text = "Pedido Compra";
            // 
            // lbl_serie_factura
            // 
            this.lbl_serie_factura.AutoSize = true;
            this.lbl_serie_factura.Location = new System.Drawing.Point(397, 181);
            this.lbl_serie_factura.Name = "lbl_serie_factura";
            this.lbl_serie_factura.Size = new System.Drawing.Size(70, 13);
            this.lbl_serie_factura.TabIndex = 23;
            this.lbl_serie_factura.Text = "Serie Factura";
            // 
            // lbl_fecha_recibida
            // 
            this.lbl_fecha_recibida.AutoSize = true;
            this.lbl_fecha_recibida.Location = new System.Drawing.Point(179, 207);
            this.lbl_fecha_recibida.Name = "lbl_fecha_recibida";
            this.lbl_fecha_recibida.Size = new System.Drawing.Size(82, 13);
            this.lbl_fecha_recibida.TabIndex = 24;
            this.lbl_fecha_recibida.Text = "Fecha Recibida";
            // 
            // lbl_encargado
            // 
            this.lbl_encargado.AutoSize = true;
            this.lbl_encargado.Location = new System.Drawing.Point(496, 208);
            this.lbl_encargado.Name = "lbl_encargado";
            this.lbl_encargado.Size = new System.Drawing.Size(59, 13);
            this.lbl_encargado.TabIndex = 25;
            this.lbl_encargado.Text = "Encargado";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Location = new System.Drawing.Point(763, 208);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(31, 13);
            this.lbl_total.TabIndex = 26;
            this.lbl_total.Text = "Total";
            // 
            // lbl_estado
            // 
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.Location = new System.Drawing.Point(132, 268);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(40, 13);
            this.lbl_estado.TabIndex = 27;
            this.lbl_estado.Text = "Estado";
            // 
            // lbl_cuenta_por_pagar
            // 
            this.lbl_cuenta_por_pagar.AutoSize = true;
            this.lbl_cuenta_por_pagar.Location = new System.Drawing.Point(132, 237);
            this.lbl_cuenta_por_pagar.Name = "lbl_cuenta_por_pagar";
            this.lbl_cuenta_por_pagar.Size = new System.Drawing.Size(91, 13);
            this.lbl_cuenta_por_pagar.TabIndex = 28;
            this.lbl_cuenta_por_pagar.Text = "Cuenta Por Pagar";
            // 
            // lbl_proveedor
            // 
            this.lbl_proveedor.AutoSize = true;
            this.lbl_proveedor.Location = new System.Drawing.Point(397, 237);
            this.lbl_proveedor.Name = "lbl_proveedor";
            this.lbl_proveedor.Size = new System.Drawing.Size(56, 13);
            this.lbl_proveedor.TabIndex = 29;
            this.lbl_proveedor.Text = "Proveedor";
            // 
            // lbl_forma_pago
            // 
            this.lbl_forma_pago.AutoSize = true;
            this.lbl_forma_pago.Location = new System.Drawing.Point(670, 237);
            this.lbl_forma_pago.Name = "lbl_forma_pago";
            this.lbl_forma_pago.Size = new System.Drawing.Size(64, 13);
            this.lbl_forma_pago.TabIndex = 30;
            this.lbl_forma_pago.Text = "Forma Pago";
            // 
            // txt_no_factura
            // 
            this.txt_no_factura.Location = new System.Drawing.Point(201, 174);
            this.txt_no_factura.Name = "txt_no_factura";
            this.txt_no_factura.Size = new System.Drawing.Size(185, 20);
            this.txt_no_factura.TabIndex = 31;
            this.txt_no_factura.Tag = "no_factura";
            // 
            // txt_serie_factura
            // 
            this.txt_serie_factura.Location = new System.Drawing.Point(473, 174);
            this.txt_serie_factura.Name = "txt_serie_factura";
            this.txt_serie_factura.Size = new System.Drawing.Size(185, 20);
            this.txt_serie_factura.TabIndex = 32;
            this.txt_serie_factura.Tag = "serie_factura";
            // 
            // txt_pedido_compra
            // 
            this.txt_pedido_compra.Location = new System.Drawing.Point(755, 174);
            this.txt_pedido_compra.Name = "txt_pedido_compra";
            this.txt_pedido_compra.Size = new System.Drawing.Size(185, 20);
            this.txt_pedido_compra.TabIndex = 33;
            this.txt_pedido_compra.Tag = "pedido_compra";
            // 
            // dtp_fecha_recibida
            // 
            this.dtp_fecha_recibida.Location = new System.Drawing.Point(267, 201);
            this.dtp_fecha_recibida.Name = "dtp_fecha_recibida";
            this.dtp_fecha_recibida.Size = new System.Drawing.Size(26, 20);
            this.dtp_fecha_recibida.TabIndex = 34;
            // 
            // txt_invisible_fecha_recibida
            // 
            this.txt_invisible_fecha_recibida.Location = new System.Drawing.Point(299, 201);
            this.txt_invisible_fecha_recibida.Name = "txt_invisible_fecha_recibida";
            this.txt_invisible_fecha_recibida.Size = new System.Drawing.Size(191, 20);
            this.txt_invisible_fecha_recibida.TabIndex = 35;
            this.txt_invisible_fecha_recibida.Tag = "fecha_recibida";
            // 
            // txt_encargado
            // 
            this.txt_encargado.Location = new System.Drawing.Point(561, 200);
            this.txt_encargado.Name = "txt_encargado";
            this.txt_encargado.Size = new System.Drawing.Size(185, 20);
            this.txt_encargado.TabIndex = 36;
            this.txt_encargado.Tag = "encargado";
            // 
            // txt_total
            // 
            this.txt_total.Location = new System.Drawing.Point(798, 200);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(185, 20);
            this.txt_total.TabIndex = 37;
            this.txt_total.Tag = "total";
            // 
            // cbm_cuenta_por_pagar
            // 
            this.cbm_cuenta_por_pagar.FormattingEnabled = true;
            this.cbm_cuenta_por_pagar.Location = new System.Drawing.Point(229, 229);
            this.cbm_cuenta_por_pagar.Name = "cbm_cuenta_por_pagar";
            this.cbm_cuenta_por_pagar.Size = new System.Drawing.Size(121, 21);
            this.cbm_cuenta_por_pagar.TabIndex = 38;
            // 
            // txt_invisible_cuenta_por_pagar
            // 
            this.txt_invisible_cuenta_por_pagar.Location = new System.Drawing.Point(356, 230);
            this.txt_invisible_cuenta_por_pagar.Name = "txt_invisible_cuenta_por_pagar";
            this.txt_invisible_cuenta_por_pagar.Size = new System.Drawing.Size(24, 20);
            this.txt_invisible_cuenta_por_pagar.TabIndex = 39;
            this.txt_invisible_cuenta_por_pagar.Tag = "cuenta_por_pagar";
            this.txt_invisible_cuenta_por_pagar.Visible = false;
            // 
            // cbm_proveedor
            // 
            this.cbm_proveedor.FormattingEnabled = true;
            this.cbm_proveedor.Location = new System.Drawing.Point(459, 230);
            this.cbm_proveedor.Name = "cbm_proveedor";
            this.cbm_proveedor.Size = new System.Drawing.Size(121, 21);
            this.cbm_proveedor.TabIndex = 40;
            // 
            // txt_invisible_proveedor
            // 
            this.txt_invisible_proveedor.Location = new System.Drawing.Point(586, 230);
            this.txt_invisible_proveedor.Name = "txt_invisible_proveedor";
            this.txt_invisible_proveedor.Size = new System.Drawing.Size(24, 20);
            this.txt_invisible_proveedor.TabIndex = 41;
            this.txt_invisible_proveedor.Tag = "proveedor";
            this.txt_invisible_proveedor.Visible = false;
            // 
            // cbm_forma_pago
            // 
            this.cbm_forma_pago.FormattingEnabled = true;
            this.cbm_forma_pago.Location = new System.Drawing.Point(740, 229);
            this.cbm_forma_pago.Name = "cbm_forma_pago";
            this.cbm_forma_pago.Size = new System.Drawing.Size(121, 21);
            this.cbm_forma_pago.TabIndex = 42;
            // 
            // txt_invisible_forma_pago
            // 
            this.txt_invisible_forma_pago.Location = new System.Drawing.Point(867, 229);
            this.txt_invisible_forma_pago.Name = "txt_invisible_forma_pago";
            this.txt_invisible_forma_pago.Size = new System.Drawing.Size(24, 20);
            this.txt_invisible_forma_pago.TabIndex = 43;
            this.txt_invisible_forma_pago.Tag = "forma_pago";
            this.txt_invisible_forma_pago.Visible = false;
            // 
            // txt_estado
            // 
            this.txt_estado.Location = new System.Drawing.Point(178, 261);
            this.txt_estado.Name = "txt_estado";
            this.txt_estado.Size = new System.Drawing.Size(168, 20);
            this.txt_estado.TabIndex = 44;
            this.txt_estado.Tag = "estado";
            // 
            // lbl_id_factura_compra_pk
            // 
            this.lbl_id_factura_compra_pk.AutoSize = true;
            this.lbl_id_factura_compra_pk.Location = new System.Drawing.Point(515, 268);
            this.lbl_id_factura_compra_pk.Name = "lbl_id_factura_compra_pk";
            this.lbl_id_factura_compra_pk.Size = new System.Drawing.Size(44, 13);
            this.lbl_id_factura_compra_pk.TabIndex = 45;
            this.lbl_id_factura_compra_pk.Text = "muestra";
            // 
            // CompraProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 613);
            this.Controls.Add(this.lbl_id_factura_compra_pk);
            this.Controls.Add(this.txt_estado);
            this.Controls.Add(this.txt_invisible_forma_pago);
            this.Controls.Add(this.cbm_forma_pago);
            this.Controls.Add(this.txt_invisible_proveedor);
            this.Controls.Add(this.cbm_proveedor);
            this.Controls.Add(this.txt_invisible_cuenta_por_pagar);
            this.Controls.Add(this.cbm_cuenta_por_pagar);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.txt_encargado);
            this.Controls.Add(this.txt_invisible_fecha_recibida);
            this.Controls.Add(this.dtp_fecha_recibida);
            this.Controls.Add(this.txt_pedido_compra);
            this.Controls.Add(this.txt_serie_factura);
            this.Controls.Add(this.txt_no_factura);
            this.Controls.Add(this.lbl_forma_pago);
            this.Controls.Add(this.lbl_proveedor);
            this.Controls.Add(this.lbl_cuenta_por_pagar);
            this.Controls.Add(this.lbl_estado);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.lbl_encargado);
            this.Controls.Add(this.lbl_fecha_recibida);
            this.Controls.Add(this.lbl_serie_factura);
            this.Controls.Add(this.lbl_pedido_compra);
            this.Controls.Add(this.lbl_no_factura);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_compras);
            this.Controls.Add(this.txt_buscar);
            this.Controls.Add(this.lbl_buscar);
            this.Name = "CompraProveedores";
            this.Text = "CompraProveedores";
            this.Load += new System.EventHandler(this.CompraProveedores_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_compras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
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
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Label lbl_buscar;
        private System.Windows.Forms.Label lbl_no_factura;
        private System.Windows.Forms.Label lbl_pedido_compra;
        private System.Windows.Forms.Label lbl_serie_factura;
        private System.Windows.Forms.Label lbl_fecha_recibida;
        private System.Windows.Forms.Label lbl_encargado;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label lbl_estado;
        private System.Windows.Forms.Label lbl_cuenta_por_pagar;
        private System.Windows.Forms.Label lbl_proveedor;
        private System.Windows.Forms.Label lbl_forma_pago;
        private System.Windows.Forms.TextBox txt_no_factura;
        private System.Windows.Forms.TextBox txt_serie_factura;
        private System.Windows.Forms.TextBox txt_pedido_compra;
        private System.Windows.Forms.DateTimePicker dtp_fecha_recibida;
        private System.Windows.Forms.TextBox txt_invisible_fecha_recibida;
        private System.Windows.Forms.TextBox txt_encargado;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.ComboBox cbm_cuenta_por_pagar;
        private System.Windows.Forms.TextBox txt_invisible_cuenta_por_pagar;
        private System.Windows.Forms.ComboBox cbm_proveedor;
        private System.Windows.Forms.TextBox txt_invisible_proveedor;
        private System.Windows.Forms.ComboBox cbm_forma_pago;
        private System.Windows.Forms.TextBox txt_invisible_forma_pago;
        private System.Windows.Forms.TextBox txt_estado;
        private System.Windows.Forms.Label lbl_id_factura_compra_pk;
        public System.Windows.Forms.DataGridView dgv_compras;
    }
}