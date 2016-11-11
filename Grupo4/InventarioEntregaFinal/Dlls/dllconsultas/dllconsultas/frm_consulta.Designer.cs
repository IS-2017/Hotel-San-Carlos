namespace dllconsultas
{
    partial class frm_consulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_consulta));
            this.txt_campo2 = new System.Windows.Forms.TextBox();
            this.txt_campo1 = new System.Windows.Forms.TextBox();
            this.cbo_Campo4 = new System.Windows.Forms.ComboBox();
            this.btn_between = new System.Windows.Forms.Button();
            this.btn_Or = new System.Windows.Forms.Button();
            this.btn_And = new System.Windows.Forms.Button();
            this.btn_Ingresar = new System.Windows.Forms.Button();
            this.cbo_Campo3 = new System.Windows.Forms.ComboBox();
            this.cbo_Campo2 = new System.Windows.Forms.ComboBox();
            this.cbo_Campo1 = new System.Windows.Forms.ComboBox();
            this.lbl_where = new System.Windows.Forms.Label();
            this.txt_NombreTabla = new System.Windows.Forms.TextBox();
            this.lbl_NombreTabla = new System.Windows.Forms.Label();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.btn_Mostrar = new System.Windows.Forms.Button();
            this.btn_almacenada = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_ayuda = new System.Windows.Forms.Button();
            this.btn_Guarda = new System.Windows.Forms.Button();
            this.btn_mas = new System.Windows.Forms.Button();
            this.btn_Ir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_campo2
            // 
            this.txt_campo2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_campo2.Location = new System.Drawing.Point(488, 265);
            this.txt_campo2.Name = "txt_campo2";
            this.txt_campo2.Size = new System.Drawing.Size(100, 27);
            this.txt_campo2.TabIndex = 51;
            this.txt_campo2.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txt_campo1
            // 
            this.txt_campo1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_campo1.Location = new System.Drawing.Point(367, 267);
            this.txt_campo1.Name = "txt_campo1";
            this.txt_campo1.Size = new System.Drawing.Size(100, 27);
            this.txt_campo1.TabIndex = 50;
            this.txt_campo1.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // cbo_Campo4
            // 
            this.cbo_Campo4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_Campo4.FormattingEnabled = true;
            this.cbo_Campo4.Location = new System.Drawing.Point(100, 265);
            this.cbo_Campo4.Name = "cbo_Campo4";
            this.cbo_Campo4.Size = new System.Drawing.Size(133, 29);
            this.cbo_Campo4.TabIndex = 49;
            this.cbo_Campo4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // btn_between
            // 
            this.btn_between.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_between.Location = new System.Drawing.Point(253, 260);
            this.btn_between.Name = "btn_between";
            this.btn_between.Size = new System.Drawing.Size(82, 36);
            this.btn_between.TabIndex = 46;
            this.btn_between.Text = "ENTRE";
            this.btn_between.UseVisualStyleBackColor = true;
            this.btn_between.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_Or
            // 
            this.btn_Or.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Or.Location = new System.Drawing.Point(367, 203);
            this.btn_Or.Name = "btn_Or";
            this.btn_Or.Size = new System.Drawing.Size(85, 36);
            this.btn_Or.TabIndex = 45;
            this.btn_Or.Text = "O";
            this.btn_Or.UseVisualStyleBackColor = true;
            this.btn_Or.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_And
            // 
            this.btn_And.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_And.Location = new System.Drawing.Point(250, 203);
            this.btn_And.Name = "btn_And";
            this.btn_And.Size = new System.Drawing.Size(85, 36);
            this.btn_And.TabIndex = 44;
            this.btn_And.Text = "Y";
            this.btn_And.UseVisualStyleBackColor = true;
            this.btn_And.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_Ingresar
            // 
            this.btn_Ingresar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ingresar.Location = new System.Drawing.Point(151, 203);
            this.btn_Ingresar.Name = "btn_Ingresar";
            this.btn_Ingresar.Size = new System.Drawing.Size(85, 36);
            this.btn_Ingresar.TabIndex = 43;
            this.btn_Ingresar.Text = "Ingresar";
            this.btn_Ingresar.UseVisualStyleBackColor = true;
            this.btn_Ingresar.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbo_Campo3
            // 
            this.cbo_Campo3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_Campo3.FormattingEnabled = true;
            this.cbo_Campo3.Location = new System.Drawing.Point(392, 147);
            this.cbo_Campo3.Name = "cbo_Campo3";
            this.cbo_Campo3.Size = new System.Drawing.Size(121, 29);
            this.cbo_Campo3.TabIndex = 42;
            this.cbo_Campo3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // cbo_Campo2
            // 
            this.cbo_Campo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Campo2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_Campo2.FormattingEnabled = true;
            this.cbo_Campo2.Items.AddRange(new object[] {
            ">",
            "<",
            "=",
            ">=",
            "<=",
            " LIKE"});
            this.cbo_Campo2.Location = new System.Drawing.Point(286, 147);
            this.cbo_Campo2.Name = "cbo_Campo2";
            this.cbo_Campo2.Size = new System.Drawing.Size(85, 29);
            this.cbo_Campo2.TabIndex = 41;
            this.cbo_Campo2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // cbo_Campo1
            // 
            this.cbo_Campo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Campo1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_Campo1.FormattingEnabled = true;
            this.cbo_Campo1.Items.AddRange(new object[] {
            "id",
            "nombre",
            "apellido",
            "telefono",
            "direccion"});
            this.cbo_Campo1.Location = new System.Drawing.Point(151, 147);
            this.cbo_Campo1.Name = "cbo_Campo1";
            this.cbo_Campo1.Size = new System.Drawing.Size(121, 29);
            this.cbo_Campo1.TabIndex = 40;
            this.cbo_Campo1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lbl_where
            // 
            this.lbl_where.AutoSize = true;
            this.lbl_where.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_where.Location = new System.Drawing.Point(64, 155);
            this.lbl_where.Name = "lbl_where";
            this.lbl_where.Size = new System.Drawing.Size(69, 21);
            this.lbl_where.TabIndex = 39;
            this.lbl_where.Text = "DONDE";
            this.lbl_where.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_NombreTabla
            // 
            this.txt_NombreTabla.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NombreTabla.Location = new System.Drawing.Point(205, 89);
            this.txt_NombreTabla.Name = "txt_NombreTabla";
            this.txt_NombreTabla.Size = new System.Drawing.Size(308, 27);
            this.txt_NombreTabla.TabIndex = 38;
            this.txt_NombreTabla.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbl_NombreTabla
            // 
            this.lbl_NombreTabla.AutoSize = true;
            this.lbl_NombreTabla.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NombreTabla.Location = new System.Drawing.Point(62, 92);
            this.lbl_NombreTabla.Name = "lbl_NombreTabla";
            this.lbl_NombreTabla.Size = new System.Drawing.Size(121, 21);
            this.lbl_NombreTabla.TabIndex = 37;
            this.lbl_NombreTabla.Text = "Nombre Tabla";
            this.lbl_NombreTabla.Click += new System.EventHandler(this.lbl_NombreTabla_Click);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(198, 19);
            this.lbl_titulo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(300, 33);
            this.lbl_titulo.TabIndex = 40;
            this.lbl_titulo.Text = "Consultas Inteligentes";
            this.lbl_titulo.Click += new System.EventHandler(this.lbl_titulo_Click);
            // 
            // btn_Mostrar
            // 
            this.btn_Mostrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Mostrar.Location = new System.Drawing.Point(634, 97);
            this.btn_Mostrar.Name = "btn_Mostrar";
            this.btn_Mostrar.Size = new System.Drawing.Size(134, 59);
            this.btn_Mostrar.TabIndex = 53;
            this.btn_Mostrar.Text = "Mostrar todos";
            this.btn_Mostrar.UseVisualStyleBackColor = true;
            this.btn_Mostrar.Click += new System.EventHandler(this.button5_Click);
            // 
            // btn_almacenada
            // 
            this.btn_almacenada.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_almacenada.Location = new System.Drawing.Point(634, 19);
            this.btn_almacenada.Name = "btn_almacenada";
            this.btn_almacenada.Size = new System.Drawing.Size(134, 63);
            this.btn_almacenada.TabIndex = 54;
            this.btn_almacenada.Text = "Consultas Almacenadas";
            this.btn_almacenada.UseVisualStyleBackColor = true;
            this.btn_almacenada.Click += new System.EventHandler(this.button9_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.BackgroundImage = global::dllconsultas.Properties.Resources.Button_Close_icon;
            this.btn_limpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_limpiar.FlatAppearance.BorderSize = 0;
            this.btn_limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpiar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar.Location = new System.Drawing.Point(706, 185);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(75, 55);
            this.btn_limpiar.TabIndex = 78;
            this.btn_limpiar.UseVisualStyleBackColor = true;
            // 
            // btn_ayuda
            // 
            this.btn_ayuda.BackgroundImage = global::dllconsultas.Properties.Resources.Button_Help_icon;
            this.btn_ayuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ayuda.FlatAppearance.BorderSize = 0;
            this.btn_ayuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ayuda.Location = new System.Drawing.Point(6, 12);
            this.btn_ayuda.Name = "btn_ayuda";
            this.btn_ayuda.Size = new System.Drawing.Size(57, 50);
            this.btn_ayuda.TabIndex = 55;
            this.btn_ayuda.UseVisualStyleBackColor = true;
            this.btn_ayuda.Click += new System.EventHandler(this.btn_ayuda_Click);
            // 
            // btn_Guarda
            // 
            this.btn_Guarda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Guarda.BackgroundImage")));
            this.btn_Guarda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Guarda.FlatAppearance.BorderSize = 0;
            this.btn_Guarda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Guarda.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Guarda.Location = new System.Drawing.Point(634, 185);
            this.btn_Guarda.Name = "btn_Guarda";
            this.btn_Guarda.Size = new System.Drawing.Size(66, 59);
            this.btn_Guarda.TabIndex = 52;
            this.btn_Guarda.UseVisualStyleBackColor = true;
            this.btn_Guarda.Click += new System.EventHandler(this.button8_Click);
            // 
            // btn_mas
            // 
            this.btn_mas.BackgroundImage = global::dllconsultas.Properties.Resources.Button_Add_icon;
            this.btn_mas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_mas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mas.Location = new System.Drawing.Point(59, 260);
            this.btn_mas.Name = "btn_mas";
            this.btn_mas.Size = new System.Drawing.Size(35, 36);
            this.btn_mas.TabIndex = 48;
            this.btn_mas.UseVisualStyleBackColor = true;
            this.btn_mas.Click += new System.EventHandler(this.button7_Click);
            // 
            // btn_Ir
            // 
            this.btn_Ir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Ir.BackgroundImage")));
            this.btn_Ir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Ir.FlatAppearance.BorderSize = 0;
            this.btn_Ir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ir.Location = new System.Drawing.Point(673, 265);
            this.btn_Ir.Name = "btn_Ir";
            this.btn_Ir.Size = new System.Drawing.Size(69, 56);
            this.btn_Ir.TabIndex = 47;
            this.btn_Ir.UseVisualStyleBackColor = true;
            this.btn_Ir.Click += new System.EventHandler(this.button6_Click);
            // 
            // frm_consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(825, 335);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_ayuda);
            this.Controls.Add(this.btn_almacenada);
            this.Controls.Add(this.btn_Mostrar);
            this.Controls.Add(this.btn_Guarda);
            this.Controls.Add(this.txt_campo2);
            this.Controls.Add(this.txt_campo1);
            this.Controls.Add(this.cbo_Campo4);
            this.Controls.Add(this.btn_mas);
            this.Controls.Add(this.btn_between);
            this.Controls.Add(this.btn_Ir);
            this.Controls.Add(this.btn_Or);
            this.Controls.Add(this.btn_And);
            this.Controls.Add(this.btn_Ingresar);
            this.Controls.Add(this.cbo_Campo3);
            this.Controls.Add(this.cbo_Campo2);
            this.Controls.Add(this.cbo_Campo1);
            this.Controls.Add(this.lbl_where);
            this.Controls.Add(this.txt_NombreTabla);
            this.Controls.Add(this.lbl_NombreTabla);
            this.Controls.Add(this.lbl_titulo);
            this.Name = "frm_consulta";
            this.Text = " ";
            this.Load += new System.EventHandler(this.frm_consulta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_campo2;
        private System.Windows.Forms.TextBox txt_campo1;
        private System.Windows.Forms.ComboBox cbo_Campo4;
        private System.Windows.Forms.Button btn_mas;
        private System.Windows.Forms.Button btn_between;
        private System.Windows.Forms.Button btn_Ir;
        private System.Windows.Forms.Button btn_Or;
        private System.Windows.Forms.Button btn_And;
        private System.Windows.Forms.Button btn_Ingresar;
        private System.Windows.Forms.ComboBox cbo_Campo3;
        private System.Windows.Forms.ComboBox cbo_Campo2;
        private System.Windows.Forms.ComboBox cbo_Campo1;
        private System.Windows.Forms.Label lbl_where;
        private System.Windows.Forms.TextBox txt_NombreTabla;
        private System.Windows.Forms.Label lbl_NombreTabla;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Button btn_Mostrar;
        private System.Windows.Forms.Button btn_almacenada;
        protected internal System.Windows.Forms.Button btn_Guarda;
        private System.Windows.Forms.Button btn_ayuda;
        private System.Windows.Forms.Button btn_limpiar;
    }
}