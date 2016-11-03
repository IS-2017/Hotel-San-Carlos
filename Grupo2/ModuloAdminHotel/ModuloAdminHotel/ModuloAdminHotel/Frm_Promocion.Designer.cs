namespace ModuloAdminHotel
{
    partial class Frm_Promocion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Promocion));
            this.txt_estado = new System.Windows.Forms.TextBox();
            this.txt_tipopaquete = new System.Windows.Forms.TextBox();
            this.txt_categoria = new System.Windows.Forms.TextBox();
            this.txt_bien = new System.Windows.Forms.TextBox();
            this.txt_habitacion = new System.Windows.Forms.TextBox();
            this.txt_salon = new System.Windows.Forms.TextBox();
            this.cbo_categoria = new System.Windows.Forms.ComboBox();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.cbo_bien = new System.Windows.Forms.ComboBox();
            this.lbl_bien = new System.Windows.Forms.Label();
            this.cbo_habitacion = new System.Windows.Forms.ComboBox();
            this.lbl_habitacion = new System.Windows.Forms.Label();
            this.cbo_salon = new System.Windows.Forms.ComboBox();
            this.lbl_salon = new System.Windows.Forms.Label();
            this.cbo_estado = new System.Windows.Forms.ComboBox();
            this.lbl_ordenmenu = new System.Windows.Forms.Label();
            this.txt_detalle = new System.Windows.Forms.TextBox();
            this.txt_costo = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_detalle = new System.Windows.Forms.Label();
            this.lbl_costo = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.cbo_tipopaquete = new System.Windows.Forms.ComboBox();
            this.lbl_tipopaquete = new System.Windows.Forms.Label();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_estado
            // 
            this.txt_estado.Location = new System.Drawing.Point(650, 181);
            this.txt_estado.Name = "txt_estado";
            this.txt_estado.Size = new System.Drawing.Size(18, 27);
            this.txt_estado.TabIndex = 194;
            this.txt_estado.Tag = "estado";
            this.txt_estado.Visible = false;
            // 
            // txt_tipopaquete
            // 
            this.txt_tipopaquete.Location = new System.Drawing.Point(356, 184);
            this.txt_tipopaquete.Name = "txt_tipopaquete";
            this.txt_tipopaquete.Size = new System.Drawing.Size(18, 27);
            this.txt_tipopaquete.TabIndex = 193;
            this.txt_tipopaquete.Tag = "tipo_paquete";
            this.txt_tipopaquete.Visible = false;
            // 
            // txt_categoria
            // 
            this.txt_categoria.Location = new System.Drawing.Point(650, 319);
            this.txt_categoria.Name = "txt_categoria";
            this.txt_categoria.Size = new System.Drawing.Size(18, 27);
            this.txt_categoria.TabIndex = 192;
            this.txt_categoria.Tag = "id_categoria_pk";
            this.txt_categoria.Visible = false;
            // 
            // txt_bien
            // 
            this.txt_bien.Location = new System.Drawing.Point(650, 284);
            this.txt_bien.Name = "txt_bien";
            this.txt_bien.Size = new System.Drawing.Size(18, 27);
            this.txt_bien.TabIndex = 191;
            this.txt_bien.Tag = "id_bien_pk";
            this.txt_bien.Visible = false;
            // 
            // txt_habitacion
            // 
            this.txt_habitacion.Location = new System.Drawing.Point(650, 252);
            this.txt_habitacion.Name = "txt_habitacion";
            this.txt_habitacion.Size = new System.Drawing.Size(18, 27);
            this.txt_habitacion.TabIndex = 190;
            this.txt_habitacion.Tag = "id_habitacion_pk";
            this.txt_habitacion.Visible = false;
            // 
            // txt_salon
            // 
            this.txt_salon.Location = new System.Drawing.Point(650, 219);
            this.txt_salon.Name = "txt_salon";
            this.txt_salon.Size = new System.Drawing.Size(18, 27);
            this.txt_salon.TabIndex = 189;
            this.txt_salon.Tag = "id_salon_pk";
            this.txt_salon.Visible = false;
            // 
            // cbo_categoria
            // 
            this.cbo_categoria.FormattingEnabled = true;
            this.cbo_categoria.Location = new System.Drawing.Point(489, 319);
            this.cbo_categoria.Name = "cbo_categoria";
            this.cbo_categoria.Size = new System.Drawing.Size(155, 29);
            this.cbo_categoria.TabIndex = 188;
            // 
            // lbl_estado
            // 
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.Location = new System.Drawing.Point(419, 187);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(64, 21);
            this.lbl_estado.TabIndex = 187;
            this.lbl_estado.Text = "Estado";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(25, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(655, 115);
            this.panel1.TabIndex = 186;
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
            this.groupBox1.Location = new System.Drawing.Point(7, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(636, 100);
            this.groupBox1.TabIndex = 11;
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
            this.btn_nuevo.Location = new System.Drawing.Point(17, 19);
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
            // cbo_bien
            // 
            this.cbo_bien.FormattingEnabled = true;
            this.cbo_bien.Location = new System.Drawing.Point(489, 284);
            this.cbo_bien.Name = "cbo_bien";
            this.cbo_bien.Size = new System.Drawing.Size(155, 29);
            this.cbo_bien.TabIndex = 185;
            // 
            // lbl_bien
            // 
            this.lbl_bien.AutoSize = true;
            this.lbl_bien.Location = new System.Drawing.Point(441, 287);
            this.lbl_bien.Name = "lbl_bien";
            this.lbl_bien.Size = new System.Drawing.Size(42, 21);
            this.lbl_bien.TabIndex = 184;
            this.lbl_bien.Text = "Bien";
            // 
            // cbo_habitacion
            // 
            this.cbo_habitacion.FormattingEnabled = true;
            this.cbo_habitacion.Location = new System.Drawing.Point(489, 252);
            this.cbo_habitacion.Name = "cbo_habitacion";
            this.cbo_habitacion.Size = new System.Drawing.Size(155, 29);
            this.cbo_habitacion.TabIndex = 183;
            // 
            // lbl_habitacion
            // 
            this.lbl_habitacion.AutoSize = true;
            this.lbl_habitacion.Location = new System.Drawing.Point(386, 252);
            this.lbl_habitacion.Name = "lbl_habitacion";
            this.lbl_habitacion.Size = new System.Drawing.Size(97, 21);
            this.lbl_habitacion.TabIndex = 182;
            this.lbl_habitacion.Text = "Habitacion";
            // 
            // cbo_salon
            // 
            this.cbo_salon.FormattingEnabled = true;
            this.cbo_salon.Location = new System.Drawing.Point(489, 219);
            this.cbo_salon.Name = "cbo_salon";
            this.cbo_salon.Size = new System.Drawing.Size(155, 29);
            this.cbo_salon.TabIndex = 181;
            // 
            // lbl_salon
            // 
            this.lbl_salon.AutoSize = true;
            this.lbl_salon.Location = new System.Drawing.Point(431, 222);
            this.lbl_salon.Name = "lbl_salon";
            this.lbl_salon.Size = new System.Drawing.Size(52, 21);
            this.lbl_salon.TabIndex = 180;
            this.lbl_salon.Text = "Salon";
            // 
            // cbo_estado
            // 
            this.cbo_estado.FormattingEnabled = true;
            this.cbo_estado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cbo_estado.Location = new System.Drawing.Point(489, 184);
            this.cbo_estado.Name = "cbo_estado";
            this.cbo_estado.Size = new System.Drawing.Size(155, 29);
            this.cbo_estado.TabIndex = 179;
            // 
            // lbl_ordenmenu
            // 
            this.lbl_ordenmenu.AutoSize = true;
            this.lbl_ordenmenu.Location = new System.Drawing.Point(392, 322);
            this.lbl_ordenmenu.Name = "lbl_ordenmenu";
            this.lbl_ordenmenu.Size = new System.Drawing.Size(91, 21);
            this.lbl_ordenmenu.TabIndex = 178;
            this.lbl_ordenmenu.Text = "Categoria";
            // 
            // txt_detalle
            // 
            this.txt_detalle.Location = new System.Drawing.Point(176, 284);
            this.txt_detalle.Multiline = true;
            this.txt_detalle.Name = "txt_detalle";
            this.txt_detalle.Size = new System.Drawing.Size(174, 95);
            this.txt_detalle.TabIndex = 177;
            this.txt_detalle.Tag = "detalle";
            // 
            // txt_costo
            // 
            this.txt_costo.Location = new System.Drawing.Point(176, 252);
            this.txt_costo.Name = "txt_costo";
            this.txt_costo.Size = new System.Drawing.Size(174, 27);
            this.txt_costo.TabIndex = 176;
            this.txt_costo.Tag = "costo";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(176, 219);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(174, 27);
            this.txt_nombre.TabIndex = 175;
            this.txt_nombre.Tag = "nombre";
            // 
            // lbl_detalle
            // 
            this.lbl_detalle.AutoSize = true;
            this.lbl_detalle.Location = new System.Drawing.Point(104, 287);
            this.lbl_detalle.Name = "lbl_detalle";
            this.lbl_detalle.Size = new System.Drawing.Size(66, 21);
            this.lbl_detalle.TabIndex = 174;
            this.lbl_detalle.Text = "Detalle";
            // 
            // lbl_costo
            // 
            this.lbl_costo.AutoSize = true;
            this.lbl_costo.Location = new System.Drawing.Point(114, 252);
            this.lbl_costo.Name = "lbl_costo";
            this.lbl_costo.Size = new System.Drawing.Size(56, 21);
            this.lbl_costo.TabIndex = 173;
            this.lbl_costo.Text = "Costo";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(97, 222);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(73, 21);
            this.lbl_nombre.TabIndex = 172;
            this.lbl_nombre.Text = "Nombre";
            // 
            // cbo_tipopaquete
            // 
            this.cbo_tipopaquete.FormattingEnabled = true;
            this.cbo_tipopaquete.Items.AddRange(new object[] {
            "Evento",
            "Habitacion"});
            this.cbo_tipopaquete.Location = new System.Drawing.Point(176, 184);
            this.cbo_tipopaquete.Name = "cbo_tipopaquete";
            this.cbo_tipopaquete.Size = new System.Drawing.Size(174, 29);
            this.cbo_tipopaquete.TabIndex = 171;
            // 
            // lbl_tipopaquete
            // 
            this.lbl_tipopaquete.AutoSize = true;
            this.lbl_tipopaquete.Location = new System.Drawing.Point(56, 187);
            this.lbl_tipopaquete.Name = "lbl_tipopaquete";
            this.lbl_tipopaquete.Size = new System.Drawing.Size(114, 21);
            this.lbl_tipopaquete.TabIndex = 170;
            this.lbl_tipopaquete.Text = "Tipo Paquete";
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.White;
            this.lbl_titulo.Location = new System.Drawing.Point(257, 137);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(169, 30);
            this.lbl_titulo.TabIndex = 169;
            this.lbl_titulo.Text = "Promociones";
            // 
            // Frm_Promocion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(104)))), ((int)(((byte)(107)))));
            this.ClientSize = new System.Drawing.Size(704, 381);
            this.Controls.Add(this.txt_estado);
            this.Controls.Add(this.txt_tipopaquete);
            this.Controls.Add(this.txt_categoria);
            this.Controls.Add(this.txt_bien);
            this.Controls.Add(this.txt_habitacion);
            this.Controls.Add(this.txt_salon);
            this.Controls.Add(this.cbo_categoria);
            this.Controls.Add(this.lbl_estado);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbo_bien);
            this.Controls.Add(this.lbl_bien);
            this.Controls.Add(this.cbo_habitacion);
            this.Controls.Add(this.lbl_habitacion);
            this.Controls.Add(this.cbo_salon);
            this.Controls.Add(this.lbl_salon);
            this.Controls.Add(this.cbo_estado);
            this.Controls.Add(this.lbl_ordenmenu);
            this.Controls.Add(this.txt_detalle);
            this.Controls.Add(this.txt_costo);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.lbl_detalle);
            this.Controls.Add(this.lbl_costo);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.cbo_tipopaquete);
            this.Controls.Add(this.lbl_tipopaquete);
            this.Controls.Add(this.lbl_titulo);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Frm_Promocion";
            this.Text = "Frm_Promocion";
            this.Load += new System.EventHandler(this.Frm_Promocion_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_estado;
        private System.Windows.Forms.TextBox txt_tipopaquete;
        private System.Windows.Forms.TextBox txt_categoria;
        private System.Windows.Forms.TextBox txt_bien;
        private System.Windows.Forms.TextBox txt_habitacion;
        private System.Windows.Forms.TextBox txt_salon;
        private System.Windows.Forms.ComboBox cbo_categoria;
        private System.Windows.Forms.Label lbl_estado;
        private System.Windows.Forms.Panel panel1;
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
        private System.Windows.Forms.ComboBox cbo_bien;
        private System.Windows.Forms.Label lbl_bien;
        private System.Windows.Forms.ComboBox cbo_habitacion;
        private System.Windows.Forms.Label lbl_habitacion;
        private System.Windows.Forms.ComboBox cbo_salon;
        private System.Windows.Forms.Label lbl_salon;
        private System.Windows.Forms.ComboBox cbo_estado;
        private System.Windows.Forms.Label lbl_ordenmenu;
        private System.Windows.Forms.TextBox txt_detalle;
        private System.Windows.Forms.TextBox txt_costo;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label lbl_detalle;
        private System.Windows.Forms.Label lbl_costo;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.ComboBox cbo_tipopaquete;
        private System.Windows.Forms.Label lbl_tipopaquete;
        private System.Windows.Forms.Label lbl_titulo;
    }
}