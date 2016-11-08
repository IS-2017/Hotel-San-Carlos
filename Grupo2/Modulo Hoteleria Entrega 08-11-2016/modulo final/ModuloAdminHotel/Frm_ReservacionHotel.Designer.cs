namespace ModuloAdminHotel
{
    partial class Frm_ReservacionHotel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ReservacionHotel));
            this.gpb_cliente = new System.Windows.Forms.GroupBox();
            this.fechaentrada = new System.Windows.Forms.DateTimePicker();
            this.txt_codigocliente = new System.Windows.Forms.TextBox();
            this.txt_fechasalida = new System.Windows.Forms.TextBox();
            this.txt_fechaentrada = new System.Windows.Forms.TextBox();
            this.fechasalida = new System.Windows.Forms.DateTimePicker();
            this.cbo_nit = new System.Windows.Forms.ComboBox();
            this.cbo_dpi = new System.Windows.Forms.ComboBox();
            this.cbo_nombre = new System.Windows.Forms.ComboBox();
            this.cbo_codigo = new System.Windows.Forms.ComboBox();
            this.txt_niñosacompañantes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_fechaentrada = new System.Windows.Forms.Label();
            this.txt_acompañantes = new System.Windows.Forms.TextBox();
            this.lbl_dpi = new System.Windows.Forms.Label();
            this.lbl_nit = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_fechaent = new System.Windows.Forms.Label();
            this.lbl_fechasalida = new System.Windows.Forms.Label();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_tipo1 = new System.Windows.Forms.Label();
            this.cbo_tipo1 = new System.Windows.Forms.ComboBox();
            this.lbl_capacidad1 = new System.Windows.Forms.Label();
            this.lbl_descripcion1 = new System.Windows.Forms.Label();
            this.lbl_cantidad1 = new System.Windows.Forms.Label();
            this.txt_cant1 = new System.Windows.Forms.TextBox();
            this.btn_add3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_niño1 = new System.Windows.Forms.TextBox();
            this.gpb_reservacion = new System.Windows.Forms.GroupBox();
            this.txt_adultos1 = new System.Windows.Forms.TextBox();
            this.txt_descp1 = new System.Windows.Forms.TextBox();
            this.ckl_reservacion = new System.Windows.Forms.CheckedListBox();
            this.gpb_reservacionhab = new System.Windows.Forms.GroupBox();
            this.txt_estadoreservacion = new System.Windows.Forms.TextBox();
            this.txt_fechasistema = new System.Windows.Forms.TextBox();
            this.txt_idhabitacion = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
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
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.gpb_cliente.SuspendLayout();
            this.gpb_reservacion.SuspendLayout();
            this.gpb_reservacionhab.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpb_cliente
            // 
            this.gpb_cliente.Controls.Add(this.fechaentrada);
            this.gpb_cliente.Controls.Add(this.txt_codigocliente);
            this.gpb_cliente.Controls.Add(this.txt_fechasalida);
            this.gpb_cliente.Controls.Add(this.txt_fechaentrada);
            this.gpb_cliente.Controls.Add(this.fechasalida);
            this.gpb_cliente.Controls.Add(this.cbo_nit);
            this.gpb_cliente.Controls.Add(this.cbo_dpi);
            this.gpb_cliente.Controls.Add(this.cbo_nombre);
            this.gpb_cliente.Controls.Add(this.cbo_codigo);
            this.gpb_cliente.Controls.Add(this.txt_niñosacompañantes);
            this.gpb_cliente.Controls.Add(this.label4);
            this.gpb_cliente.Controls.Add(this.label2);
            this.gpb_cliente.Controls.Add(this.lbl_fechaentrada);
            this.gpb_cliente.Controls.Add(this.label6);
            this.gpb_cliente.Controls.Add(this.txt_acompañantes);
            this.gpb_cliente.Controls.Add(this.lbl_dpi);
            this.gpb_cliente.Controls.Add(this.lbl_nit);
            this.gpb_cliente.Controls.Add(this.lbl_nombre);
            this.gpb_cliente.Controls.Add(this.lbl_fechaent);
            this.gpb_cliente.Controls.Add(this.lbl_fechasalida);
            this.gpb_cliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_cliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gpb_cliente.Location = new System.Drawing.Point(12, 134);
            this.gpb_cliente.Name = "gpb_cliente";
            this.gpb_cliente.Size = new System.Drawing.Size(935, 177);
            this.gpb_cliente.TabIndex = 76;
            this.gpb_cliente.TabStop = false;
            this.gpb_cliente.Text = "DATOS DEL CLIENTE";
            this.gpb_cliente.Enter += new System.EventHandler(this.gpb_cliente_Enter);
            // 
            // fechaentrada
            // 
            this.fechaentrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaentrada.Location = new System.Drawing.Point(691, 82);
            this.fechaentrada.Name = "fechaentrada";
            this.fechaentrada.Size = new System.Drawing.Size(160, 27);
            this.fechaentrada.TabIndex = 25;
            this.fechaentrada.ValueChanged += new System.EventHandler(this.fechaentrada_ValueChanged_1);
            // 
            // txt_codigocliente
            // 
            this.txt_codigocliente.Location = new System.Drawing.Point(433, 22);
            this.txt_codigocliente.Name = "txt_codigocliente";
            this.txt_codigocliente.Size = new System.Drawing.Size(10, 27);
            this.txt_codigocliente.TabIndex = 24;
            this.txt_codigocliente.Tag = "id_cliente_pk";
            this.txt_codigocliente.Visible = false;
            this.txt_codigocliente.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txt_fechasalida
            // 
            this.txt_fechasalida.Location = new System.Drawing.Point(857, 115);
            this.txt_fechasalida.Name = "txt_fechasalida";
            this.txt_fechasalida.Size = new System.Drawing.Size(10, 27);
            this.txt_fechasalida.TabIndex = 23;
            this.txt_fechasalida.Tag = "fecha_salida";
            this.txt_fechasalida.Visible = false;
            // 
            // txt_fechaentrada
            // 
            this.txt_fechaentrada.Location = new System.Drawing.Point(779, 80);
            this.txt_fechaentrada.Name = "txt_fechaentrada";
            this.txt_fechaentrada.Size = new System.Drawing.Size(10, 27);
            this.txt_fechaentrada.TabIndex = 22;
            this.txt_fechaentrada.Tag = "fecha_entreda";
            this.txt_fechaentrada.Visible = false;
            // 
            // fechasalida
            // 
            this.fechasalida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechasalida.Location = new System.Drawing.Point(691, 115);
            this.fechasalida.Name = "fechasalida";
            this.fechasalida.Size = new System.Drawing.Size(160, 27);
            this.fechasalida.TabIndex = 21;
            this.fechasalida.ValueChanged += new System.EventHandler(this.fechasalida_ValueChanged);
            // 
            // cbo_nit
            // 
            this.cbo_nit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_nit.FormattingEnabled = true;
            this.cbo_nit.Location = new System.Drawing.Point(110, 126);
            this.cbo_nit.Name = "cbo_nit";
            this.cbo_nit.Size = new System.Drawing.Size(320, 29);
            this.cbo_nit.TabIndex = 19;
            this.cbo_nit.SelectedIndexChanged += new System.EventHandler(this.cbo_nit_SelectedIndexChanged);
            // 
            // cbo_dpi
            // 
            this.cbo_dpi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_dpi.FormattingEnabled = true;
            this.cbo_dpi.Location = new System.Drawing.Point(110, 91);
            this.cbo_dpi.Name = "cbo_dpi";
            this.cbo_dpi.Size = new System.Drawing.Size(320, 29);
            this.cbo_dpi.TabIndex = 18;
            this.cbo_dpi.SelectedIndexChanged += new System.EventHandler(this.cbo_dpi_SelectedIndexChanged);
            // 
            // cbo_nombre
            // 
            this.cbo_nombre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_nombre.FormattingEnabled = true;
            this.cbo_nombre.Location = new System.Drawing.Point(110, 55);
            this.cbo_nombre.Name = "cbo_nombre";
            this.cbo_nombre.Size = new System.Drawing.Size(320, 29);
            this.cbo_nombre.TabIndex = 17;
            this.cbo_nombre.SelectedIndexChanged += new System.EventHandler(this.cbo_nombre_SelectedIndexChanged);
            // 
            // cbo_codigo
            // 
            this.cbo_codigo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_codigo.FormattingEnabled = true;
            this.cbo_codigo.Location = new System.Drawing.Point(110, 23);
            this.cbo_codigo.Name = "cbo_codigo";
            this.cbo_codigo.Size = new System.Drawing.Size(320, 29);
            this.cbo_codigo.TabIndex = 16;
            this.cbo_codigo.SelectedIndexChanged += new System.EventHandler(this.cbo_codigo_SelectedIndexChanged);
            // 
            // txt_niñosacompañantes
            // 
            this.txt_niñosacompañantes.Location = new System.Drawing.Point(691, 53);
            this.txt_niñosacompañantes.Name = "txt_niñosacompañantes";
            this.txt_niñosacompañantes.Size = new System.Drawing.Size(160, 27);
            this.txt_niñosacompañantes.TabIndex = 14;
            this.txt_niñosacompañantes.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txt_niñosacompañantes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 21);
            this.label4.TabIndex = 15;
            this.label4.Text = "Codigo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(502, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "Acompañantes Niños:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl_fechaentrada
            // 
            this.lbl_fechaentrada.AutoSize = true;
            this.lbl_fechaentrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fechaentrada.Location = new System.Drawing.Point(6, 118);
            this.lbl_fechaentrada.Name = "lbl_fechaentrada";
            this.lbl_fechaentrada.Size = new System.Drawing.Size(0, 24);
            this.lbl_fechaentrada.TabIndex = 8;
            // 
            // txt_acompañantes
            // 
            this.txt_acompañantes.Location = new System.Drawing.Point(691, 23);
            this.txt_acompañantes.Name = "txt_acompañantes";
            this.txt_acompañantes.Size = new System.Drawing.Size(160, 27);
            this.txt_acompañantes.TabIndex = 10;
            this.txt_acompañantes.TextChanged += new System.EventHandler(this.txt_acompañantes_TextChanged);
            this.txt_acompañantes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_acompañantes_KeyPress_1);
            // 
            // lbl_dpi
            // 
            this.lbl_dpi.AutoSize = true;
            this.lbl_dpi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dpi.Location = new System.Drawing.Point(59, 94);
            this.lbl_dpi.Name = "lbl_dpi";
            this.lbl_dpi.Size = new System.Drawing.Size(40, 21);
            this.lbl_dpi.TabIndex = 6;
            this.lbl_dpi.Text = "Dpi:";
            // 
            // lbl_nit
            // 
            this.lbl_nit.AutoSize = true;
            this.lbl_nit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nit.Location = new System.Drawing.Point(59, 124);
            this.lbl_nit.Name = "lbl_nit";
            this.lbl_nit.Size = new System.Drawing.Size(36, 21);
            this.lbl_nit.TabIndex = 4;
            this.lbl_nit.Text = "Nit:";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.Location = new System.Drawing.Point(27, 58);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(77, 21);
            this.lbl_nombre.TabIndex = 2;
            this.lbl_nombre.Text = "Nombre:";
            // 
            // lbl_fechaent
            // 
            this.lbl_fechaent.AutoSize = true;
            this.lbl_fechaent.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fechaent.Location = new System.Drawing.Point(528, 91);
            this.lbl_fechaent.Name = "lbl_fechaent";
            this.lbl_fechaent.Size = new System.Drawing.Size(157, 21);
            this.lbl_fechaent.TabIndex = 2;
            this.lbl_fechaent.Text = "Fecha De Entrada:";
            // 
            // lbl_fechasalida
            // 
            this.lbl_fechasalida.AutoSize = true;
            this.lbl_fechasalida.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fechasalida.Location = new System.Drawing.Point(545, 121);
            this.lbl_fechasalida.Name = "lbl_fechasalida";
            this.lbl_fechasalida.Size = new System.Drawing.Size(140, 21);
            this.lbl_fechasalida.TabIndex = 6;
            this.lbl_fechasalida.Text = "Fecha De Salida:";
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_titulo.Location = new System.Drawing.Point(299, 17);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(365, 28);
            this.lbl_titulo.TabIndex = 77;
            this.lbl_titulo.Text = "RESERVACION DE HABITACION";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 24);
            this.label3.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 24);
            this.label1.TabIndex = 8;
            // 
            // lbl_tipo1
            // 
            this.lbl_tipo1.AutoSize = true;
            this.lbl_tipo1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipo1.Location = new System.Drawing.Point(53, 29);
            this.lbl_tipo1.Name = "lbl_tipo1";
            this.lbl_tipo1.Size = new System.Drawing.Size(46, 21);
            this.lbl_tipo1.TabIndex = 11;
            this.lbl_tipo1.Text = "Tipo:";
            this.lbl_tipo1.Click += new System.EventHandler(this.lbl_tipo1_Click);
            // 
            // cbo_tipo1
            // 
            this.cbo_tipo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_tipo1.FormattingEnabled = true;
            this.cbo_tipo1.Location = new System.Drawing.Point(101, 25);
            this.cbo_tipo1.Name = "cbo_tipo1";
            this.cbo_tipo1.Size = new System.Drawing.Size(121, 28);
            this.cbo_tipo1.TabIndex = 12;
            this.cbo_tipo1.TabStop = false;
            this.cbo_tipo1.SelectedIndexChanged += new System.EventHandler(this.cbo_tipo1_SelectedIndexChanged);
            // 
            // lbl_capacidad1
            // 
            this.lbl_capacidad1.AutoSize = true;
            this.lbl_capacidad1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_capacidad1.Location = new System.Drawing.Point(228, 27);
            this.lbl_capacidad1.Name = "lbl_capacidad1";
            this.lbl_capacidad1.Size = new System.Drawing.Size(74, 21);
            this.lbl_capacidad1.TabIndex = 13;
            this.lbl_capacidad1.Text = "Adultos:";
            // 
            // lbl_descripcion1
            // 
            this.lbl_descripcion1.AutoSize = true;
            this.lbl_descripcion1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descripcion1.Location = new System.Drawing.Point(6, 72);
            this.lbl_descripcion1.Name = "lbl_descripcion1";
            this.lbl_descripcion1.Size = new System.Drawing.Size(99, 21);
            this.lbl_descripcion1.TabIndex = 14;
            this.lbl_descripcion1.Text = "Descipcion:";
            // 
            // lbl_cantidad1
            // 
            this.lbl_cantidad1.AutoSize = true;
            this.lbl_cantidad1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cantidad1.Location = new System.Drawing.Point(13, 178);
            this.lbl_cantidad1.Name = "lbl_cantidad1";
            this.lbl_cantidad1.Size = new System.Drawing.Size(91, 21);
            this.lbl_cantidad1.TabIndex = 16;
            this.lbl_cantidad1.Text = "Cantidad:";
            this.lbl_cantidad1.Click += new System.EventHandler(this.lbl_cantidad1_Click);
            // 
            // txt_cant1
            // 
            this.txt_cant1.Location = new System.Drawing.Point(101, 176);
            this.txt_cant1.Name = "txt_cant1";
            this.txt_cant1.Size = new System.Drawing.Size(37, 26);
            this.txt_cant1.TabIndex = 17;
            this.txt_cant1.TextChanged += new System.EventHandler(this.txt_cant1_TextChanged);
            this.txt_cant1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cant1_KeyPress);
            // 
            // btn_add3
            // 
            this.btn_add3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_add3.FlatAppearance.BorderSize = 0;
            this.btn_add3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add3.Location = new System.Drawing.Point(6, 96);
            this.btn_add3.Name = "btn_add3";
            this.btn_add3.Size = new System.Drawing.Size(25, 23);
            this.btn_add3.TabIndex = 77;
            this.btn_add3.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(355, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 21);
            this.label5.TabIndex = 120;
            this.label5.Text = "Niños:";
            // 
            // txt_niño1
            // 
            this.txt_niño1.Location = new System.Drawing.Point(416, 27);
            this.txt_niño1.Name = "txt_niño1";
            this.txt_niño1.Size = new System.Drawing.Size(27, 26);
            this.txt_niño1.TabIndex = 119;
            this.txt_niño1.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // gpb_reservacion
            // 
            this.gpb_reservacion.Controls.Add(this.txt_adultos1);
            this.gpb_reservacion.Controls.Add(this.txt_descp1);
            this.gpb_reservacion.Controls.Add(this.txt_niño1);
            this.gpb_reservacion.Controls.Add(this.label5);
            this.gpb_reservacion.Controls.Add(this.btn_add3);
            this.gpb_reservacion.Controls.Add(this.txt_cant1);
            this.gpb_reservacion.Controls.Add(this.lbl_cantidad1);
            this.gpb_reservacion.Controls.Add(this.lbl_descripcion1);
            this.gpb_reservacion.Controls.Add(this.lbl_capacidad1);
            this.gpb_reservacion.Controls.Add(this.cbo_tipo1);
            this.gpb_reservacion.Controls.Add(this.lbl_tipo1);
            this.gpb_reservacion.Controls.Add(this.label1);
            this.gpb_reservacion.Controls.Add(this.label3);
            this.gpb_reservacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_reservacion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gpb_reservacion.Location = new System.Drawing.Point(12, 317);
            this.gpb_reservacion.Name = "gpb_reservacion";
            this.gpb_reservacion.Size = new System.Drawing.Size(468, 215);
            this.gpb_reservacion.TabIndex = 78;
            this.gpb_reservacion.TabStop = false;
            this.gpb_reservacion.Text = "DATOS DE RESERVACION";
            this.gpb_reservacion.Enter += new System.EventHandler(this.gpb_reservacion_Enter);
            // 
            // txt_adultos1
            // 
            this.txt_adultos1.Location = new System.Drawing.Point(308, 27);
            this.txt_adultos1.Name = "txt_adultos1";
            this.txt_adultos1.Size = new System.Drawing.Size(27, 26);
            this.txt_adultos1.TabIndex = 126;
            this.txt_adultos1.TextChanged += new System.EventHandler(this.txt_adultos1_TextChanged_1);
            // 
            // txt_descp1
            // 
            this.txt_descp1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txt_descp1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descp1.Location = new System.Drawing.Point(101, 69);
            this.txt_descp1.Multiline = true;
            this.txt_descp1.Name = "txt_descp1";
            this.txt_descp1.Size = new System.Drawing.Size(346, 101);
            this.txt_descp1.TabIndex = 125;
            this.txt_descp1.TextChanged += new System.EventHandler(this.txt_descp1_TextChanged);
            // 
            // ckl_reservacion
            // 
            this.ckl_reservacion.FormattingEnabled = true;
            this.ckl_reservacion.Location = new System.Drawing.Point(52, 35);
            this.ckl_reservacion.Name = "ckl_reservacion";
            this.ckl_reservacion.ScrollAlwaysVisible = true;
            this.ckl_reservacion.Size = new System.Drawing.Size(381, 172);
            this.ckl_reservacion.TabIndex = 135;
            this.ckl_reservacion.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ckl_reservacion_MouseClick);
            this.ckl_reservacion.SelectedIndexChanged += new System.EventHandler(this.ckl_reservacion_SelectedIndexChanged);
            // 
            // gpb_reservacionhab
            // 
            this.gpb_reservacionhab.Controls.Add(this.txt_estadoreservacion);
            this.gpb_reservacionhab.Controls.Add(this.txt_fechasistema);
            this.gpb_reservacionhab.Controls.Add(this.txt_idhabitacion);
            this.gpb_reservacionhab.Controls.Add(this.ckl_reservacion);
            this.gpb_reservacionhab.Controls.Add(this.label11);
            this.gpb_reservacionhab.Controls.Add(this.label12);
            this.gpb_reservacionhab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_reservacionhab.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gpb_reservacionhab.Location = new System.Drawing.Point(485, 317);
            this.gpb_reservacionhab.Name = "gpb_reservacionhab";
            this.gpb_reservacionhab.Size = new System.Drawing.Size(462, 215);
            this.gpb_reservacionhab.TabIndex = 127;
            this.gpb_reservacionhab.TabStop = false;
            this.gpb_reservacionhab.Text = "RESERVACION DE HABITACION";
            this.gpb_reservacionhab.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txt_estadoreservacion
            // 
            this.txt_estadoreservacion.Location = new System.Drawing.Point(439, 116);
            this.txt_estadoreservacion.Name = "txt_estadoreservacion";
            this.txt_estadoreservacion.Size = new System.Drawing.Size(10, 26);
            this.txt_estadoreservacion.TabIndex = 137;
            this.txt_estadoreservacion.Tag = "estado";
            this.txt_estadoreservacion.Visible = false;
            // 
            // txt_fechasistema
            // 
            this.txt_fechasistema.Location = new System.Drawing.Point(439, 70);
            this.txt_fechasistema.Name = "txt_fechasistema";
            this.txt_fechasistema.Size = new System.Drawing.Size(10, 26);
            this.txt_fechasistema.TabIndex = 136;
            this.txt_fechasistema.Tag = "fecha_reservacion";
            this.txt_fechasistema.Visible = false;
            this.txt_fechasistema.TextChanged += new System.EventHandler(this.txt_fechasistema_TextChanged);
            // 
            // txt_idhabitacion
            // 
            this.txt_idhabitacion.Location = new System.Drawing.Point(439, 35);
            this.txt_idhabitacion.Name = "txt_idhabitacion";
            this.txt_idhabitacion.Size = new System.Drawing.Size(11, 26);
            this.txt_idhabitacion.TabIndex = 25;
            this.txt_idhabitacion.Tag = "id_habitacion_pk";
            this.txt_idhabitacion.Visible = false;
            this.txt_idhabitacion.TextChanged += new System.EventHandler(this.txt_idhabitacion_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 118);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 24);
            this.label11.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(20, 94);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 24);
            this.label12.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_nuevo);
            this.groupBox2.Controls.Add(this.btn_ultimo);
            this.groupBox2.Controls.Add(this.btn_guardar);
            this.groupBox2.Controls.Add(this.btn_primero);
            this.groupBox2.Controls.Add(this.btn_editar);
            this.groupBox2.Controls.Add(this.btn_siguiente);
            this.groupBox2.Controls.Add(this.btn_eliminar);
            this.groupBox2.Controls.Add(this.btn_anterior);
            this.groupBox2.Controls.Add(this.btn_buscar);
            this.groupBox2.Controls.Add(this.btn_actualizar);
            this.groupBox2.Controls.Add(this.btn_cancelar);
            this.groupBox2.Location = new System.Drawing.Point(331, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(616, 88);
            this.groupBox2.TabIndex = 136;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
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
            this.btn_nuevo.Location = new System.Drawing.Point(17, 20);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(65, 65);
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
            this.btn_ultimo.Location = new System.Drawing.Point(565, 53);
            this.btn_ultimo.Name = "btn_ultimo";
            this.btn_ultimo.Size = new System.Drawing.Size(33, 33);
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
            this.btn_primero.Location = new System.Drawing.Point(529, 53);
            this.btn_primero.Name = "btn_primero";
            this.btn_primero.Size = new System.Drawing.Size(33, 33);
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
            this.btn_editar.Location = new System.Drawing.Point(159, 19);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(65, 65);
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
            this.btn_siguiente.Location = new System.Drawing.Point(565, 18);
            this.btn_siguiente.Name = "btn_siguiente";
            this.btn_siguiente.Size = new System.Drawing.Size(33, 33);
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
            this.btn_eliminar.Location = new System.Drawing.Point(230, 19);
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
            this.btn_anterior.Location = new System.Drawing.Point(529, 18);
            this.btn_anterior.Name = "btn_anterior";
            this.btn_anterior.Size = new System.Drawing.Size(33, 33);
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
            this.btn_buscar.Location = new System.Drawing.Point(301, 19);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(65, 65);
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
            this.btn_actualizar.Location = new System.Drawing.Point(443, 19);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(65, 65);
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
            this.btn_cancelar.Location = new System.Drawing.Point(372, 19);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(65, 65);
            this.btn_cancelar.TabIndex = 5;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::ModuloAdminHotel.Properties.Resources.Button_Help_icon;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(924, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 27);
            this.button2.TabIndex = 150;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(483, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(202, 21);
            this.label6.TabIndex = 9;
            this.label6.Text = "Acompañantes Adultos:";
            this.label6.Click += new System.EventHandler(this.lbl_adultos_Click);
            // 
            // Frm_ReservacionHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(959, 539);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gpb_reservacionhab);
            this.Controls.Add(this.gpb_reservacion);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.gpb_cliente);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Frm_ReservacionHotel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_ReservacionHotel";
            this.Load += new System.EventHandler(this.Frm_ReservacionHotel_Load);
            this.gpb_cliente.ResumeLayout(false);
            this.gpb_cliente.PerformLayout();
            this.gpb_reservacion.ResumeLayout(false);
            this.gpb_reservacion.PerformLayout();
            this.gpb_reservacionhab.ResumeLayout(false);
            this.gpb_reservacionhab.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpb_cliente;
        private System.Windows.Forms.TextBox txt_acompañantes;
        private System.Windows.Forms.Label lbl_fechaentrada;
        private System.Windows.Forms.Label lbl_dpi;
        private System.Windows.Forms.Label lbl_nit;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_fechasalida;
        private System.Windows.Forms.Label lbl_fechaent;
        private System.Windows.Forms.ComboBox cbo_codigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_niñosacompañantes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbo_nombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_tipo1;
        private System.Windows.Forms.ComboBox cbo_tipo1;
        private System.Windows.Forms.Label lbl_capacidad1;
        private System.Windows.Forms.Label lbl_descripcion1;
        private System.Windows.Forms.Label lbl_cantidad1;
        private System.Windows.Forms.TextBox txt_cant1;
        private System.Windows.Forms.Button btn_add3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_niño1;
        private System.Windows.Forms.GroupBox gpb_reservacion;
        private System.Windows.Forms.TextBox txt_descp1;
        private System.Windows.Forms.ComboBox cbo_nit;
        private System.Windows.Forms.ComboBox cbo_dpi;
        private System.Windows.Forms.DateTimePicker fechasalida;
        private System.Windows.Forms.TextBox txt_adultos1;
        private System.Windows.Forms.CheckedListBox ckl_reservacion;
        private System.Windows.Forms.GroupBox gpb_reservacionhab;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox2;
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
        private System.Windows.Forms.TextBox txt_codigocliente;
        private System.Windows.Forms.TextBox txt_fechasalida;
        private System.Windows.Forms.TextBox txt_estadoreservacion;
        private System.Windows.Forms.TextBox txt_fechasistema;
        private System.Windows.Forms.TextBox txt_idhabitacion;
        private System.Windows.Forms.TextBox txt_fechaentrada;
        private System.Windows.Forms.DateTimePicker fechaentrada;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
    }
}