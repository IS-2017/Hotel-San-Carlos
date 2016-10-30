namespace produccion
{
    partial class frm_modificar_recetario
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
            this.txt_nombre_receta = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_cantidad_formula = new System.Windows.Forms.Label();
            this.dgv_modifica_receta = new System.Windows.Forms.DataGridView();
            this.lbl_id_receta_enc = new System.Windows.Forms.Label();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_nombre_formula = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_hrs_hombre = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_costo = new System.Windows.Forms.Label();
            this.cmb_categoria = new System.Windows.Forms.ComboBox();
            this.cmb_materia_prima = new System.Windows.Forms.ComboBox();
            this.cmb_medida = new System.Windows.Forms.ComboBox();
            this.cmb_proceso = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_modifica_receta)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_nombre_receta
            // 
            this.txt_nombre_receta.Location = new System.Drawing.Point(77, 63);
            this.txt_nombre_receta.Name = "txt_nombre_receta";
            this.txt_nombre_receta.Size = new System.Drawing.Size(100, 20);
            this.txt_nombre_receta.TabIndex = 0;
            this.txt_nombre_receta.TextChanged += new System.EventHandler(this.txt_nombre_receta_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(77, 106);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(241, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Modificar Receta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(207, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Categoria";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(435, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Materia Prima";
            // 
            // txt_cantidad_formula
            // 
            this.txt_cantidad_formula.AutoSize = true;
            this.txt_cantidad_formula.Location = new System.Drawing.Point(21, 113);
            this.txt_cantidad_formula.Name = "txt_cantidad_formula";
            this.txt_cantidad_formula.Size = new System.Drawing.Size(49, 13);
            this.txt_cantidad_formula.TabIndex = 8;
            this.txt_cantidad_formula.Text = "Cantidad";
            // 
            // dgv_modifica_receta
            // 
            this.dgv_modifica_receta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_modifica_receta.Location = new System.Drawing.Point(29, 205);
            this.dgv_modifica_receta.Name = "dgv_modifica_receta";
            this.dgv_modifica_receta.Size = new System.Drawing.Size(520, 165);
            this.dgv_modifica_receta.TabIndex = 9;
            // 
            // lbl_id_receta_enc
            // 
            this.lbl_id_receta_enc.AutoSize = true;
            this.lbl_id_receta_enc.Location = new System.Drawing.Point(2, 392);
            this.lbl_id_receta_enc.Name = "lbl_id_receta_enc";
            this.lbl_id_receta_enc.Size = new System.Drawing.Size(35, 13);
            this.lbl_id_receta_enc.TabIndex = 10;
            this.lbl_id_receta_enc.Text = "label6";
            // 
            // btn_consultar
            // 
            this.btn_consultar.Location = new System.Drawing.Point(682, 60);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(75, 23);
            this.btn_consultar.TabIndex = 11;
            this.btn_consultar.Text = "consultar";
            this.btn_consultar.UseVisualStyleBackColor = true;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lbl_nombre_formula);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lbl_hrs_hombre);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.lbl_costo);
            this.groupBox1.Location = new System.Drawing.Point(566, 205);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(179, 165);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Descripción";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Formula:";
            // 
            // lbl_nombre_formula
            // 
            this.lbl_nombre_formula.AutoSize = true;
            this.lbl_nombre_formula.Location = new System.Drawing.Point(113, 38);
            this.lbl_nombre_formula.Name = "lbl_nombre_formula";
            this.lbl_nombre_formula.Size = new System.Drawing.Size(35, 13);
            this.lbl_nombre_formula.TabIndex = 14;
            this.lbl_nombre_formula.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Hrs Hombre: ";
            // 
            // lbl_hrs_hombre
            // 
            this.lbl_hrs_hombre.AutoSize = true;
            this.lbl_hrs_hombre.Location = new System.Drawing.Point(113, 77);
            this.lbl_hrs_hombre.Name = "lbl_hrs_hombre";
            this.lbl_hrs_hombre.Size = new System.Drawing.Size(35, 13);
            this.lbl_hrs_hombre.TabIndex = 16;
            this.lbl_hrs_hombre.Text = "label9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 117);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Costo: ";
            // 
            // lbl_costo
            // 
            this.lbl_costo.AutoSize = true;
            this.lbl_costo.Location = new System.Drawing.Point(113, 117);
            this.lbl_costo.Name = "lbl_costo";
            this.lbl_costo.Size = new System.Drawing.Size(41, 13);
            this.lbl_costo.TabIndex = 18;
            this.lbl_costo.Text = "label11";
            // 
            // cmb_categoria
            // 
            this.cmb_categoria.FormattingEnabled = true;
            this.cmb_categoria.Location = new System.Drawing.Point(279, 67);
            this.cmb_categoria.Name = "cmb_categoria";
            this.cmb_categoria.Size = new System.Drawing.Size(121, 21);
            this.cmb_categoria.TabIndex = 19;
            this.cmb_categoria.SelectedIndexChanged += new System.EventHandler(this.cmb_categoria_SelectedIndexChanged);
            // 
            // cmb_materia_prima
            // 
            this.cmb_materia_prima.FormattingEnabled = true;
            this.cmb_materia_prima.Location = new System.Drawing.Point(525, 70);
            this.cmb_materia_prima.Name = "cmb_materia_prima";
            this.cmb_materia_prima.Size = new System.Drawing.Size(121, 21);
            this.cmb_materia_prima.TabIndex = 20;
            // 
            // cmb_medida
            // 
            this.cmb_medida.FormattingEnabled = true;
            this.cmb_medida.Location = new System.Drawing.Point(279, 105);
            this.cmb_medida.Name = "cmb_medida";
            this.cmb_medida.Size = new System.Drawing.Size(121, 21);
            this.cmb_medida.TabIndex = 21;
            // 
            // cmb_proceso
            // 
            this.cmb_proceso.FormattingEnabled = true;
            this.cmb_proceso.Location = new System.Drawing.Point(525, 108);
            this.cmb_proceso.Name = "cmb_proceso";
            this.cmb_proceso.Size = new System.Drawing.Size(121, 21);
            this.cmb_proceso.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(207, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Medida";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(435, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Proceso";
            // 
            // frm_modificar_recetario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(840, 414);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmb_categoria);
            this.Controls.Add(this.cmb_materia_prima);
            this.Controls.Add(this.cmb_medida);
            this.Controls.Add(this.cmb_proceso);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_consultar);
            this.Controls.Add(this.lbl_id_receta_enc);
            this.Controls.Add(this.dgv_modifica_receta);
            this.Controls.Add(this.txt_cantidad_formula);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.txt_nombre_receta);
            this.Name = "frm_modificar_recetario";
            this.Text = "frm_modificar_recetario";
            this.Load += new System.EventHandler(this.frm_modificar_recetario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_modifica_receta)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txt_cantidad_formula;
        private System.Windows.Forms.DataGridView dgv_modifica_receta;
        public System.Windows.Forms.TextBox txt_nombre_receta;
        public System.Windows.Forms.Label lbl_id_receta_enc;
        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmb_medida;
        private System.Windows.Forms.ComboBox cmb_materia_prima;
        private System.Windows.Forms.ComboBox cmb_categoria;
        private System.Windows.Forms.ComboBox cmb_proceso;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label lbl_nombre_formula;
        public System.Windows.Forms.Label lbl_hrs_hombre;
        public System.Windows.Forms.Label lbl_costo;
    }
}