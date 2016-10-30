namespace seguridad
{
    partial class Form_EditarPrivilegios
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
            this.dgw_permisos = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.chlb_permisos = new System.Windows.Forms.CheckedListBox();
            this.chlb_aplicaciones = new System.Windows.Forms.CheckedListBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbo_usuario = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgw_perfil = new System.Windows.Forms.DataGridView();
            this.btn_aceptar_perfil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_roles = new System.Windows.Forms.ComboBox();
            this.dgw_central = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_reporte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_permisos)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_perfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_central)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgw_permisos
            // 
            this.dgw_permisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_permisos.Location = new System.Drawing.Point(6, 147);
            this.dgw_permisos.Name = "dgw_permisos";
            this.dgw_permisos.Size = new System.Drawing.Size(496, 111);
            this.dgw_permisos.TabIndex = 22;
            this.dgw_permisos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_permisos_CellContentClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_aceptar);
            this.groupBox3.Controls.Add(this.dgw_permisos);
            this.groupBox3.Controls.Add(this.chlb_permisos);
            this.groupBox3.Controls.Add(this.chlb_aplicaciones);
            this.groupBox3.Controls.Add(this.btn_agregar);
            this.groupBox3.Location = new System.Drawing.Point(15, 7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(508, 291);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Asignar permisos nuevos:";
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(210, 264);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(97, 21);
            this.btn_aceptar.TabIndex = 26;
            this.btn_aceptar.Text = "Agregar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // chlb_permisos
            // 
            this.chlb_permisos.FormattingEnabled = true;
            this.chlb_permisos.Items.AddRange(new object[] {
            "Insertar",
            "Seleccionar",
            "Actualizar",
            "Eliminar"});
            this.chlb_permisos.Location = new System.Drawing.Point(267, 19);
            this.chlb_permisos.Name = "chlb_permisos";
            this.chlb_permisos.Size = new System.Drawing.Size(215, 94);
            this.chlb_permisos.TabIndex = 19;
            // 
            // chlb_aplicaciones
            // 
            this.chlb_aplicaciones.FormattingEnabled = true;
            this.chlb_aplicaciones.Location = new System.Drawing.Point(16, 19);
            this.chlb_aplicaciones.Name = "chlb_aplicaciones";
            this.chlb_aplicaciones.Size = new System.Drawing.Size(239, 94);
            this.chlb_aplicaciones.TabIndex = 8;
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(229, 119);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(78, 22);
            this.btn_agregar.TabIndex = 17;
            this.btn_agregar.Text = "Mover";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbo_usuario);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(20, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 53);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccionar usuario:";
            // 
            // cbo_usuario
            // 
            this.cbo_usuario.FormattingEnabled = true;
            this.cbo_usuario.Location = new System.Drawing.Point(228, 19);
            this.cbo_usuario.Name = "cbo_usuario";
            this.cbo_usuario.Size = new System.Drawing.Size(121, 21);
            this.cbo_usuario.TabIndex = 15;
            this.cbo_usuario.SelectedIndexChanged += new System.EventHandler(this.cbo_usuario_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Usuario:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(20, 249);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(560, 330);
            this.tabControl1.TabIndex = 28;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(552, 304);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Asignar permisos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgw_perfil);
            this.tabPage2.Controls.Add(this.btn_aceptar_perfil);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.cbo_roles);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(552, 304);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Asignar perfil";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgw_perfil
            // 
            this.dgw_perfil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_perfil.Location = new System.Drawing.Point(19, 56);
            this.dgw_perfil.Name = "dgw_perfil";
            this.dgw_perfil.Size = new System.Drawing.Size(509, 166);
            this.dgw_perfil.TabIndex = 31;
            // 
            // btn_aceptar_perfil
            // 
            this.btn_aceptar_perfil.Location = new System.Drawing.Point(214, 228);
            this.btn_aceptar_perfil.Name = "btn_aceptar_perfil";
            this.btn_aceptar_perfil.Size = new System.Drawing.Size(106, 22);
            this.btn_aceptar_perfil.TabIndex = 29;
            this.btn_aceptar_perfil.Text = "Aceptar";
            this.btn_aceptar_perfil.UseVisualStyleBackColor = true;
            this.btn_aceptar_perfil.Click += new System.EventHandler(this.btn_aceptar_perfil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Perfil:";
            // 
            // cbo_roles
            // 
            this.cbo_roles.FormattingEnabled = true;
            this.cbo_roles.Location = new System.Drawing.Point(200, 29);
            this.cbo_roles.Name = "cbo_roles";
            this.cbo_roles.Size = new System.Drawing.Size(140, 21);
            this.cbo_roles.TabIndex = 29;
            this.cbo_roles.SelectedIndexChanged += new System.EventHandler(this.cbo_roles_SelectedIndexChanged);
            // 
            // dgw_central
            // 
            this.dgw_central.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_central.Location = new System.Drawing.Point(8, 19);
            this.dgw_central.Name = "dgw_central";
            this.dgw_central.Size = new System.Drawing.Size(548, 155);
            this.dgw_central.TabIndex = 32;
            this.dgw_central.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_central_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgw_central);
            this.groupBox2.Location = new System.Drawing.Point(20, 62);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(560, 181);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Permisos:";
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(219, 581);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(168, 23);
            this.btn_Guardar.TabIndex = 40;
            this.btn_Guardar.Text = "Aceptar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // btn_reporte
            // 
            this.btn_reporte.Location = new System.Drawing.Point(409, 581);
            this.btn_reporte.Name = "btn_reporte";
            this.btn_reporte.Size = new System.Drawing.Size(112, 23);
            this.btn_reporte.TabIndex = 41;
            this.btn_reporte.Text = "Visualizar reporte";
            this.btn_reporte.UseVisualStyleBackColor = true;
            this.btn_reporte.Click += new System.EventHandler(this.btn_reporte_Click);
            // 
            // Form_EditarPrivilegios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 607);
            this.Controls.Add(this.btn_reporte);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_EditarPrivilegios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar privilegios";
            this.Load += new System.EventHandler(this.Form_EditarPrivilegios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_permisos)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_perfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_central)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgw_permisos;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckedListBox chlb_permisos;
        private System.Windows.Forms.CheckedListBox chlb_aplicaciones;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.ComboBox cbo_usuario;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgw_perfil;
        public System.Windows.Forms.ComboBox cbo_roles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_aceptar_perfil;
        private System.Windows.Forms.DataGridView dgw_central;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Button btn_reporte;
    }
}