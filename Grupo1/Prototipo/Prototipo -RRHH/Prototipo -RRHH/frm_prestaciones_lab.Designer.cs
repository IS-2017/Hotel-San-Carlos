namespace Prototipo__RRHH
{
    partial class frm_prestaciones_lab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_prestaciones_lab));
            this.gpb_devengado = new System.Windows.Forms.GroupBox();
            this.lbl_tip_devenga = new System.Windows.Forms.Label();
            this.cbo_tip_devenga = new System.Windows.Forms.ComboBox();
            this.clb_emp_a_deveng = new System.Windows.Forms.CheckedListBox();
            this.lbl_emp_a_deveng = new System.Windows.Forms.Label();
            this.dtp_fecha_deveng = new System.Windows.Forms.DateTimePicker();
            this.lbl_fecha_deveng = new System.Windows.Forms.Label();
            this.lbl_canti_deveng = new System.Windows.Forms.Label();
            this.txt_canti_deveng = new System.Windows.Forms.TextBox();
            this.txt_cantid_deveng = new System.Windows.Forms.TextBox();
            this.txt_detall_deveng = new System.Windows.Forms.TextBox();
            this.txt_nom_deveng = new System.Windows.Forms.TextBox();
            this.lbl_cantid_deveng = new System.Windows.Forms.Label();
            this.lbl_detall_deveng = new System.Windows.Forms.Label();
            this.lbl_nom_deveng = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.lbl_form_prest_lab = new System.Windows.Forms.Label();
            this.gpb_devengado.SuspendLayout();
            this.gpb_navegador.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpb_devengado
            // 
            this.gpb_devengado.Controls.Add(this.lbl_tip_devenga);
            this.gpb_devengado.Controls.Add(this.cbo_tip_devenga);
            this.gpb_devengado.Controls.Add(this.clb_emp_a_deveng);
            this.gpb_devengado.Controls.Add(this.lbl_emp_a_deveng);
            this.gpb_devengado.Controls.Add(this.dtp_fecha_deveng);
            this.gpb_devengado.Controls.Add(this.lbl_fecha_deveng);
            this.gpb_devengado.Controls.Add(this.lbl_canti_deveng);
            this.gpb_devengado.Controls.Add(this.txt_canti_deveng);
            this.gpb_devengado.Controls.Add(this.txt_cantid_deveng);
            this.gpb_devengado.Controls.Add(this.txt_detall_deveng);
            this.gpb_devengado.Controls.Add(this.txt_nom_deveng);
            this.gpb_devengado.Controls.Add(this.lbl_cantid_deveng);
            this.gpb_devengado.Controls.Add(this.lbl_detall_deveng);
            this.gpb_devengado.Controls.Add(this.lbl_nom_deveng);
            this.gpb_devengado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_devengado.Location = new System.Drawing.Point(12, 162);
            this.gpb_devengado.Name = "gpb_devengado";
            this.gpb_devengado.Size = new System.Drawing.Size(906, 263);
            this.gpb_devengado.TabIndex = 166;
            this.gpb_devengado.TabStop = false;
            this.gpb_devengado.Text = "Devengado";
            // 
            // lbl_tip_devenga
            // 
            this.lbl_tip_devenga.AutoSize = true;
            this.lbl_tip_devenga.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tip_devenga.Location = new System.Drawing.Point(24, 40);
            this.lbl_tip_devenga.Name = "lbl_tip_devenga";
            this.lbl_tip_devenga.Size = new System.Drawing.Size(117, 18);
            this.lbl_tip_devenga.TabIndex = 68;
            this.lbl_tip_devenga.Text = "Tipo devengado:";
            // 
            // cbo_tip_devenga
            // 
            this.cbo_tip_devenga.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_tip_devenga.FormattingEnabled = true;
            this.cbo_tip_devenga.Items.AddRange(new object[] {
            "Horas extra",
            "Comision ventas",
            "Otro"});
            this.cbo_tip_devenga.Location = new System.Drawing.Point(147, 36);
            this.cbo_tip_devenga.Name = "cbo_tip_devenga";
            this.cbo_tip_devenga.Size = new System.Drawing.Size(252, 28);
            this.cbo_tip_devenga.TabIndex = 67;
            // 
            // clb_emp_a_deveng
            // 
            this.clb_emp_a_deveng.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.clb_emp_a_deveng.FormattingEnabled = true;
            this.clb_emp_a_deveng.Items.AddRange(new object[] {
            "Empleado1",
            "Empleado2",
            "Empleado3"});
            this.clb_emp_a_deveng.Location = new System.Drawing.Point(587, 36);
            this.clb_emp_a_deveng.Name = "clb_emp_a_deveng";
            this.clb_emp_a_deveng.Size = new System.Drawing.Size(250, 88);
            this.clb_emp_a_deveng.TabIndex = 66;
            // 
            // lbl_emp_a_deveng
            // 
            this.lbl_emp_a_deveng.AutoSize = true;
            this.lbl_emp_a_deveng.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_emp_a_deveng.Location = new System.Drawing.Point(489, 36);
            this.lbl_emp_a_deveng.Name = "lbl_emp_a_deveng";
            this.lbl_emp_a_deveng.Size = new System.Drawing.Size(87, 18);
            this.lbl_emp_a_deveng.TabIndex = 65;
            this.lbl_emp_a_deveng.Text = "Empleados:";
            // 
            // dtp_fecha_deveng
            // 
            this.dtp_fecha_deveng.Location = new System.Drawing.Point(587, 194);
            this.dtp_fecha_deveng.Name = "dtp_fecha_deveng";
            this.dtp_fecha_deveng.Size = new System.Drawing.Size(307, 26);
            this.dtp_fecha_deveng.TabIndex = 63;
            // 
            // lbl_fecha_deveng
            // 
            this.lbl_fecha_deveng.AutoSize = true;
            this.lbl_fecha_deveng.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha_deveng.Location = new System.Drawing.Point(523, 194);
            this.lbl_fecha_deveng.Name = "lbl_fecha_deveng";
            this.lbl_fecha_deveng.Size = new System.Drawing.Size(53, 18);
            this.lbl_fecha_deveng.TabIndex = 62;
            this.lbl_fecha_deveng.Text = "Fecha:";
            // 
            // lbl_canti_deveng
            // 
            this.lbl_canti_deveng.AutoSize = true;
            this.lbl_canti_deveng.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_canti_deveng.Location = new System.Drawing.Point(516, 162);
            this.lbl_canti_deveng.Name = "lbl_canti_deveng";
            this.lbl_canti_deveng.Size = new System.Drawing.Size(60, 18);
            this.lbl_canti_deveng.TabIndex = 61;
            this.lbl_canti_deveng.Text = "Cuotas:";
            // 
            // txt_canti_deveng
            // 
            this.txt_canti_deveng.Location = new System.Drawing.Point(587, 162);
            this.txt_canti_deveng.Name = "txt_canti_deveng";
            this.txt_canti_deveng.Size = new System.Drawing.Size(250, 26);
            this.txt_canti_deveng.TabIndex = 59;
            // 
            // txt_cantid_deveng
            // 
            this.txt_cantid_deveng.Location = new System.Drawing.Point(587, 130);
            this.txt_cantid_deveng.Name = "txt_cantid_deveng";
            this.txt_cantid_deveng.Size = new System.Drawing.Size(250, 26);
            this.txt_cantid_deveng.TabIndex = 53;
            // 
            // txt_detall_deveng
            // 
            this.txt_detall_deveng.Location = new System.Drawing.Point(148, 102);
            this.txt_detall_deveng.Multiline = true;
            this.txt_detall_deveng.Name = "txt_detall_deveng";
            this.txt_detall_deveng.Size = new System.Drawing.Size(251, 155);
            this.txt_detall_deveng.TabIndex = 50;
            // 
            // txt_nom_deveng
            // 
            this.txt_nom_deveng.Location = new System.Drawing.Point(148, 70);
            this.txt_nom_deveng.Name = "txt_nom_deveng";
            this.txt_nom_deveng.Size = new System.Drawing.Size(251, 26);
            this.txt_nom_deveng.TabIndex = 48;
            // 
            // lbl_cantid_deveng
            // 
            this.lbl_cantid_deveng.AutoSize = true;
            this.lbl_cantid_deveng.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cantid_deveng.Location = new System.Drawing.Point(430, 130);
            this.lbl_cantid_deveng.Name = "lbl_cantid_deveng";
            this.lbl_cantid_deveng.Size = new System.Drawing.Size(146, 18);
            this.lbl_cantid_deveng.TabIndex = 52;
            this.lbl_cantid_deveng.Text = "Cantidad a devengar:";
            // 
            // lbl_detall_deveng
            // 
            this.lbl_detall_deveng.AutoSize = true;
            this.lbl_detall_deveng.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_detall_deveng.Location = new System.Drawing.Point(25, 102);
            this.lbl_detall_deveng.Name = "lbl_detall_deveng";
            this.lbl_detall_deveng.Size = new System.Drawing.Size(57, 18);
            this.lbl_detall_deveng.TabIndex = 49;
            this.lbl_detall_deveng.Text = "Detalle:";
            // 
            // lbl_nom_deveng
            // 
            this.lbl_nom_deveng.AutoSize = true;
            this.lbl_nom_deveng.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nom_deveng.Location = new System.Drawing.Point(24, 70);
            this.lbl_nom_deveng.Name = "lbl_nom_deveng";
            this.lbl_nom_deveng.Size = new System.Drawing.Size(66, 18);
            this.lbl_nom_deveng.TabIndex = 47;
            this.lbl_nom_deveng.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(215, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 29);
            this.label1.TabIndex = 165;
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
            this.gpb_navegador.Location = new System.Drawing.Point(12, 56);
            this.gpb_navegador.Name = "gpb_navegador";
            this.gpb_navegador.Size = new System.Drawing.Size(636, 100);
            this.gpb_navegador.TabIndex = 69;
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
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // lbl_form_prest_lab
            // 
            this.lbl_form_prest_lab.AutoSize = true;
            this.lbl_form_prest_lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_form_prest_lab.Location = new System.Drawing.Point(300, 9);
            this.lbl_form_prest_lab.Name = "lbl_form_prest_lab";
            this.lbl_form_prest_lab.Size = new System.Drawing.Size(348, 32);
            this.lbl_form_prest_lab.TabIndex = 170;
            this.lbl_form_prest_lab.Text = "Devengados a Empleados";
            // 
            // frm_prestaciones_lab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.ClientSize = new System.Drawing.Size(932, 437);
            this.Controls.Add(this.lbl_form_prest_lab);
            this.Controls.Add(this.gpb_navegador);
            this.Controls.Add(this.gpb_devengado);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_prestaciones_lab";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Devengados";
            this.Load += new System.EventHandler(this.frm_prestaciones_lab_Load);
            this.gpb_devengado.ResumeLayout(false);
            this.gpb_devengado.PerformLayout();
            this.gpb_navegador.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpb_devengado;
        private System.Windows.Forms.Label lbl_tip_devenga;
        private System.Windows.Forms.ComboBox cbo_tip_devenga;
        private System.Windows.Forms.CheckedListBox clb_emp_a_deveng;
        private System.Windows.Forms.Label lbl_emp_a_deveng;
        private System.Windows.Forms.DateTimePicker dtp_fecha_deveng;
        private System.Windows.Forms.Label lbl_fecha_deveng;
        private System.Windows.Forms.Label lbl_canti_deveng;
        private System.Windows.Forms.TextBox txt_canti_deveng;
        private System.Windows.Forms.TextBox txt_cantid_deveng;
        private System.Windows.Forms.TextBox txt_detall_deveng;
        private System.Windows.Forms.TextBox txt_nom_deveng;
        private System.Windows.Forms.Label lbl_cantid_deveng;
        private System.Windows.Forms.Label lbl_detall_deveng;
        private System.Windows.Forms.Label lbl_nom_deveng;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.Label lbl_form_prest_lab;
    }
}