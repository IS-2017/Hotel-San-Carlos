namespace Modulo_Bancos
{
    partial class Documento
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Documento));
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cbo_tipo_documento = new System.Windows.Forms.ComboBox();
            this.txt_no_documento = new System.Windows.Forms.TextBox();
            this.lbl_tipo_documento = new System.Windows.Forms.Label();
            this.lbl_no_documento = new System.Windows.Forms.Label();
            this.dtp_fecha_documento = new System.Windows.Forms.DateTimePicker();
            this.lbl_fecha_documento = new System.Windows.Forms.Label();
            this.txt_destinatario = new System.Windows.Forms.TextBox();
            this.lbl_destinatario = new System.Windows.Forms.Label();
            this.txt_debe = new System.Windows.Forms.TextBox();
            this.lbl_descripcion = new System.Windows.Forms.Label();
            this.lbl_conciliado = new System.Windows.Forms.Label();
            this.txt_haber = new System.Windows.Forms.TextBox();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.cbo_conciliado = new System.Windows.Forms.ComboBox();
            this.txt_valor_total = new System.Windows.Forms.TextBox();
            this.lbl_valor_total = new System.Windows.Forms.Label();
            this.lbl_codigo_cuenta = new System.Windows.Forms.Label();
            this.txt_codigo_cuenta = new System.Windows.Forms.TextBox();
            this.txt_nombre_cuenta = new System.Windows.Forms.TextBox();
            this.lbl_nombre_cuenta = new System.Windows.Forms.Label();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.txt_estado = new System.Windows.Forms.TextBox();
            this.debe_debe = new System.Windows.Forms.Label();
            this.lbl_haber = new System.Windows.Forms.Label();
            this.gpb_datos_documento = new System.Windows.Forms.GroupBox();
            this.lbl_documento = new System.Windows.Forms.Label();
            this.gpb_navegador.SuspendLayout();
            this.gpb_datos_documento.SuspendLayout();
            this.SuspendLayout();
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
            this.gpb_navegador.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_navegador.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gpb_navegador.Location = new System.Drawing.Point(52, 40);
            this.gpb_navegador.Name = "gpb_navegador";
            this.gpb_navegador.Size = new System.Drawing.Size(636, 100);
            this.gpb_navegador.TabIndex = 12;
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
            this.toolTip1.SetToolTip(this.btn_nuevo, "Nuevo");
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
            this.toolTip1.SetToolTip(this.btn_ultimo, "Ultimo");
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
            this.toolTip1.SetToolTip(this.btn_guardar, "Guardar");
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
            this.toolTip1.SetToolTip(this.btn_primero, "Primero");
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
            this.toolTip1.SetToolTip(this.btn_editar, "Editar");
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
            this.toolTip1.SetToolTip(this.btn_siguiente, "Siguiente");
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
            this.toolTip1.SetToolTip(this.btn_eliminar, "Eliminar");
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
            this.toolTip1.SetToolTip(this.btn_anterior, "Anterior");
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
            this.toolTip1.SetToolTip(this.btn_buscar, "Buscar");
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
            this.toolTip1.SetToolTip(this.btn_actualizar, "Refrescar");
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
            this.toolTip1.SetToolTip(this.btn_cancelar, "Cancelar");
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // cbo_tipo_documento
            // 
            this.cbo_tipo_documento.FormattingEnabled = true;
            this.cbo_tipo_documento.Location = new System.Drawing.Point(169, 58);
            this.cbo_tipo_documento.Name = "cbo_tipo_documento";
            this.cbo_tipo_documento.Size = new System.Drawing.Size(178, 29);
            this.cbo_tipo_documento.TabIndex = 13;
            // 
            // txt_no_documento
            // 
            this.txt_no_documento.Location = new System.Drawing.Point(168, 94);
            this.txt_no_documento.Name = "txt_no_documento";
            this.txt_no_documento.Size = new System.Drawing.Size(178, 27);
            this.txt_no_documento.TabIndex = 14;
            // 
            // lbl_tipo_documento
            // 
            this.lbl_tipo_documento.AutoSize = true;
            this.lbl_tipo_documento.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_tipo_documento.Location = new System.Drawing.Point(2, 60);
            this.lbl_tipo_documento.Name = "lbl_tipo_documento";
            this.lbl_tipo_documento.Size = new System.Drawing.Size(164, 21);
            this.lbl_tipo_documento.TabIndex = 15;
            this.lbl_tipo_documento.Text = "Tipo de documento";
            // 
            // lbl_no_documento
            // 
            this.lbl_no_documento.AutoSize = true;
            this.lbl_no_documento.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_no_documento.Location = new System.Drawing.Point(36, 99);
            this.lbl_no_documento.Name = "lbl_no_documento";
            this.lbl_no_documento.Size = new System.Drawing.Size(130, 21);
            this.lbl_no_documento.TabIndex = 16;
            this.lbl_no_documento.Text = "No Documento";
            // 
            // dtp_fecha_documento
            // 
            this.dtp_fecha_documento.Location = new System.Drawing.Point(531, 65);
            this.dtp_fecha_documento.Name = "dtp_fecha_documento";
            this.dtp_fecha_documento.Size = new System.Drawing.Size(208, 27);
            this.dtp_fecha_documento.TabIndex = 17;
            // 
            // lbl_fecha_documento
            // 
            this.lbl_fecha_documento.AutoSize = true;
            this.lbl_fecha_documento.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_fecha_documento.Location = new System.Drawing.Point(358, 66);
            this.lbl_fecha_documento.Name = "lbl_fecha_documento";
            this.lbl_fecha_documento.Size = new System.Drawing.Size(157, 21);
            this.lbl_fecha_documento.TabIndex = 18;
            this.lbl_fecha_documento.Text = "Fecha Documento";
            // 
            // txt_destinatario
            // 
            this.txt_destinatario.Location = new System.Drawing.Point(168, 133);
            this.txt_destinatario.Name = "txt_destinatario";
            this.txt_destinatario.Size = new System.Drawing.Size(178, 27);
            this.txt_destinatario.TabIndex = 19;
            // 
            // lbl_destinatario
            // 
            this.lbl_destinatario.AutoSize = true;
            this.lbl_destinatario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_destinatario.Location = new System.Drawing.Point(58, 136);
            this.lbl_destinatario.Name = "lbl_destinatario";
            this.lbl_destinatario.Size = new System.Drawing.Size(105, 21);
            this.lbl_destinatario.TabIndex = 20;
            this.lbl_destinatario.Text = "Destinatario";
            // 
            // txt_debe
            // 
            this.txt_debe.Location = new System.Drawing.Point(529, 212);
            this.txt_debe.Name = "txt_debe";
            this.txt_debe.Size = new System.Drawing.Size(208, 27);
            this.txt_debe.TabIndex = 21;
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.AutoSize = true;
            this.lbl_descripcion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_descripcion.Location = new System.Drawing.Point(55, 171);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Size = new System.Drawing.Size(100, 21);
            this.lbl_descripcion.TabIndex = 22;
            this.lbl_descripcion.Text = "Descripcion";
            // 
            // lbl_conciliado
            // 
            this.lbl_conciliado.AutoSize = true;
            this.lbl_conciliado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_conciliado.Location = new System.Drawing.Point(415, 101);
            this.lbl_conciliado.Name = "lbl_conciliado";
            this.lbl_conciliado.Size = new System.Drawing.Size(94, 21);
            this.lbl_conciliado.TabIndex = 23;
            this.lbl_conciliado.Text = "Conciliado";
            // 
            // txt_haber
            // 
            this.txt_haber.Location = new System.Drawing.Point(529, 248);
            this.txt_haber.Name = "txt_haber";
            this.txt_haber.Size = new System.Drawing.Size(208, 27);
            this.txt_haber.TabIndex = 24;
            // 
            // lbl_estado
            // 
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_estado.Location = new System.Drawing.Point(91, 207);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(64, 21);
            this.lbl_estado.TabIndex = 25;
            this.lbl_estado.Text = "Estado";
            // 
            // cbo_conciliado
            // 
            this.cbo_conciliado.FormattingEnabled = true;
            this.cbo_conciliado.Location = new System.Drawing.Point(530, 99);
            this.cbo_conciliado.Name = "cbo_conciliado";
            this.cbo_conciliado.Size = new System.Drawing.Size(208, 29);
            this.cbo_conciliado.TabIndex = 26;
            // 
            // txt_valor_total
            // 
            this.txt_valor_total.Location = new System.Drawing.Point(166, 236);
            this.txt_valor_total.Name = "txt_valor_total";
            this.txt_valor_total.Size = new System.Drawing.Size(181, 27);
            this.txt_valor_total.TabIndex = 27;
            // 
            // lbl_valor_total
            // 
            this.lbl_valor_total.AutoSize = true;
            this.lbl_valor_total.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_valor_total.Location = new System.Drawing.Point(62, 242);
            this.lbl_valor_total.Name = "lbl_valor_total";
            this.lbl_valor_total.Size = new System.Drawing.Size(93, 21);
            this.lbl_valor_total.TabIndex = 28;
            this.lbl_valor_total.Text = "Valor Total";
            // 
            // lbl_codigo_cuenta
            // 
            this.lbl_codigo_cuenta.AutoSize = true;
            this.lbl_codigo_cuenta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_codigo_cuenta.Location = new System.Drawing.Point(379, 139);
            this.lbl_codigo_cuenta.Name = "lbl_codigo_cuenta";
            this.lbl_codigo_cuenta.Size = new System.Drawing.Size(133, 21);
            this.lbl_codigo_cuenta.TabIndex = 30;
            this.lbl_codigo_cuenta.Text = "Codigo Cuenta";
            // 
            // txt_codigo_cuenta
            // 
            this.txt_codigo_cuenta.Location = new System.Drawing.Point(529, 141);
            this.txt_codigo_cuenta.Name = "txt_codigo_cuenta";
            this.txt_codigo_cuenta.Size = new System.Drawing.Size(208, 27);
            this.txt_codigo_cuenta.TabIndex = 31;
            this.txt_codigo_cuenta.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // txt_nombre_cuenta
            // 
            this.txt_nombre_cuenta.Location = new System.Drawing.Point(529, 178);
            this.txt_nombre_cuenta.Name = "txt_nombre_cuenta";
            this.txt_nombre_cuenta.Size = new System.Drawing.Size(208, 27);
            this.txt_nombre_cuenta.TabIndex = 32;
            // 
            // lbl_nombre_cuenta
            // 
            this.lbl_nombre_cuenta.AutoSize = true;
            this.lbl_nombre_cuenta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_nombre_cuenta.Location = new System.Drawing.Point(377, 178);
            this.lbl_nombre_cuenta.Name = "lbl_nombre_cuenta";
            this.lbl_nombre_cuenta.Size = new System.Drawing.Size(138, 21);
            this.lbl_nombre_cuenta.TabIndex = 33;
            this.lbl_nombre_cuenta.Text = "Nombre Cuenta";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(166, 168);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(180, 27);
            this.txt_descripcion.TabIndex = 34;
            // 
            // txt_estado
            // 
            this.txt_estado.Location = new System.Drawing.Point(166, 201);
            this.txt_estado.Name = "txt_estado";
            this.txt_estado.Size = new System.Drawing.Size(180, 27);
            this.txt_estado.TabIndex = 35;
            // 
            // debe_debe
            // 
            this.debe_debe.AutoSize = true;
            this.debe_debe.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.debe_debe.Location = new System.Drawing.Point(448, 210);
            this.debe_debe.Name = "debe_debe";
            this.debe_debe.Size = new System.Drawing.Size(53, 21);
            this.debe_debe.TabIndex = 36;
            this.debe_debe.Text = "Debe";
            // 
            // lbl_haber
            // 
            this.lbl_haber.AutoSize = true;
            this.lbl_haber.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_haber.Location = new System.Drawing.Point(445, 254);
            this.lbl_haber.Name = "lbl_haber";
            this.lbl_haber.Size = new System.Drawing.Size(58, 21);
            this.lbl_haber.TabIndex = 37;
            this.lbl_haber.Text = "Haber";
            // 
            // gpb_datos_documento
            // 
            this.gpb_datos_documento.Controls.Add(this.dtp_fecha_documento);
            this.gpb_datos_documento.Controls.Add(this.lbl_valor_total);
            this.gpb_datos_documento.Controls.Add(this.lbl_haber);
            this.gpb_datos_documento.Controls.Add(this.txt_valor_total);
            this.gpb_datos_documento.Controls.Add(this.lbl_fecha_documento);
            this.gpb_datos_documento.Controls.Add(this.lbl_estado);
            this.gpb_datos_documento.Controls.Add(this.debe_debe);
            this.gpb_datos_documento.Controls.Add(this.txt_haber);
            this.gpb_datos_documento.Controls.Add(this.lbl_conciliado);
            this.gpb_datos_documento.Controls.Add(this.lbl_descripcion);
            this.gpb_datos_documento.Controls.Add(this.txt_estado);
            this.gpb_datos_documento.Controls.Add(this.txt_debe);
            this.gpb_datos_documento.Controls.Add(this.cbo_conciliado);
            this.gpb_datos_documento.Controls.Add(this.lbl_destinatario);
            this.gpb_datos_documento.Controls.Add(this.txt_descripcion);
            this.gpb_datos_documento.Controls.Add(this.txt_destinatario);
            this.gpb_datos_documento.Controls.Add(this.lbl_codigo_cuenta);
            this.gpb_datos_documento.Controls.Add(this.lbl_no_documento);
            this.gpb_datos_documento.Controls.Add(this.lbl_nombre_cuenta);
            this.gpb_datos_documento.Controls.Add(this.lbl_tipo_documento);
            this.gpb_datos_documento.Controls.Add(this.txt_no_documento);
            this.gpb_datos_documento.Controls.Add(this.txt_codigo_cuenta);
            this.gpb_datos_documento.Controls.Add(this.cbo_tipo_documento);
            this.gpb_datos_documento.Controls.Add(this.txt_nombre_cuenta);
            this.gpb_datos_documento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_datos_documento.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gpb_datos_documento.Location = new System.Drawing.Point(12, 146);
            this.gpb_datos_documento.Name = "gpb_datos_documento";
            this.gpb_datos_documento.Size = new System.Drawing.Size(749, 302);
            this.gpb_datos_documento.TabIndex = 38;
            this.gpb_datos_documento.TabStop = false;
            this.gpb_datos_documento.Text = "Datos Documento";
            // 
            // lbl_documento
            // 
            this.lbl_documento.AutoSize = true;
            this.lbl_documento.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_documento.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_documento.Location = new System.Drawing.Point(300, 9);
            this.lbl_documento.Name = "lbl_documento";
            this.lbl_documento.Size = new System.Drawing.Size(187, 36);
            this.lbl_documento.TabIndex = 38;
            this.lbl_documento.Text = "Documento";
            // 
            // Documento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(143)))));
            this.ClientSize = new System.Drawing.Size(782, 471);
            this.Controls.Add(this.lbl_documento);
            this.Controls.Add(this.gpb_datos_documento);
            this.Controls.Add(this.gpb_navegador);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Documento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Documento";
            this.gpb_navegador.ResumeLayout(false);
            this.gpb_datos_documento.ResumeLayout(false);
            this.gpb_datos_documento.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox cbo_tipo_documento;
        private System.Windows.Forms.TextBox txt_no_documento;
        private System.Windows.Forms.Label lbl_tipo_documento;
        private System.Windows.Forms.Label lbl_no_documento;
        private System.Windows.Forms.DateTimePicker dtp_fecha_documento;
        private System.Windows.Forms.Label lbl_fecha_documento;
        private System.Windows.Forms.TextBox txt_destinatario;
        private System.Windows.Forms.Label lbl_destinatario;
        private System.Windows.Forms.TextBox txt_debe;
        private System.Windows.Forms.Label lbl_descripcion;
        private System.Windows.Forms.Label lbl_conciliado;
        private System.Windows.Forms.TextBox txt_haber;
        private System.Windows.Forms.Label lbl_estado;
        private System.Windows.Forms.ComboBox cbo_conciliado;
        private System.Windows.Forms.TextBox txt_valor_total;
        private System.Windows.Forms.Label lbl_valor_total;
        private System.Windows.Forms.Label lbl_codigo_cuenta;
        private System.Windows.Forms.TextBox txt_codigo_cuenta;
        private System.Windows.Forms.TextBox txt_nombre_cuenta;
        private System.Windows.Forms.Label lbl_nombre_cuenta;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.TextBox txt_estado;
        private System.Windows.Forms.Label debe_debe;
        private System.Windows.Forms.Label lbl_haber;
        private System.Windows.Forms.GroupBox gpb_datos_documento;
        private System.Windows.Forms.Label lbl_documento;
    }
}

