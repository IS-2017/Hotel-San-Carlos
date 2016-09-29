namespace Graf1
{
    partial class frm_grafhori
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_grafhori));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_acpt = new System.Windows.Forms.Button();
            this.dgv_datos = new System.Windows.Forms.DataGridView();
            this.btn_y = new System.Windows.Forms.Button();
            this.btn_x = new System.Windows.Forms.Button();
            this.btn_gengraf = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cambiar = new System.Windows.Forms.Button();
            this.cbo_eje = new System.Windows.Forms.ComboBox();
            this.btn_validar = new System.Windows.Forms.Button();
            this.btn_historico = new System.Windows.Forms.Button();
            this.cbo_msem = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbo_mmes2 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cbo_mmes = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_ames = new System.Windows.Forms.TextBox();
            this.cbo_ssem = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_asem = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datos)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(473, 63);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // btn_acpt
            // 
            this.btn_acpt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_acpt.BackgroundImage")));
            this.btn_acpt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_acpt.Location = new System.Drawing.Point(614, 43);
            this.btn_acpt.Name = "btn_acpt";
            this.btn_acpt.Size = new System.Drawing.Size(60, 60);
            this.btn_acpt.TabIndex = 2;
            this.btn_acpt.UseVisualStyleBackColor = true;
            this.btn_acpt.Click += new System.EventHandler(this.btn_acpt_Click);
            // 
            // dgv_datos
            // 
            this.dgv_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_datos.Location = new System.Drawing.Point(20, 116);
            this.dgv_datos.Name = "dgv_datos";
            this.dgv_datos.Size = new System.Drawing.Size(768, 216);
            this.dgv_datos.TabIndex = 3;
            // 
            // btn_y
            // 
            this.btn_y.Location = new System.Drawing.Point(110, 353);
            this.btn_y.Name = "btn_y";
            this.btn_y.Size = new System.Drawing.Size(75, 25);
            this.btn_y.TabIndex = 4;
            this.btn_y.Text = "Y";
            this.btn_y.UseVisualStyleBackColor = true;
            this.btn_y.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_x
            // 
            this.btn_x.Location = new System.Drawing.Point(268, 353);
            this.btn_x.Name = "btn_x";
            this.btn_x.Size = new System.Drawing.Size(75, 25);
            this.btn_x.TabIndex = 5;
            this.btn_x.Text = "X";
            this.btn_x.UseVisualStyleBackColor = true;
            this.btn_x.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_gengraf
            // 
            this.btn_gengraf.Location = new System.Drawing.Point(188, 468);
            this.btn_gengraf.Name = "btn_gengraf";
            this.btn_gengraf.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_gengraf.Size = new System.Drawing.Size(100, 30);
            this.btn_gengraf.TabIndex = 7;
            this.btn_gengraf.Text = "Genera grafica";
            this.btn_gengraf.UseVisualStyleBackColor = true;
            this.btn_gengraf.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(172, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Titulo de grafico";
            // 
            // btn_cambiar
            // 
            this.btn_cambiar.Location = new System.Drawing.Point(51, 411);
            this.btn_cambiar.Name = "btn_cambiar";
            this.btn_cambiar.Size = new System.Drawing.Size(100, 30);
            this.btn_cambiar.TabIndex = 10;
            this.btn_cambiar.Text = "Cambiar Eje";
            this.btn_cambiar.UseVisualStyleBackColor = true;
            this.btn_cambiar.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // cbo_eje
            // 
            this.cbo_eje.Enabled = false;
            this.cbo_eje.FormattingEnabled = true;
            this.cbo_eje.Items.AddRange(new object[] {
            "X",
            "Y"});
            this.cbo_eje.Location = new System.Drawing.Point(176, 412);
            this.cbo_eje.Name = "cbo_eje";
            this.cbo_eje.Size = new System.Drawing.Size(121, 21);
            this.cbo_eje.TabIndex = 11;
            // 
            // btn_validar
            // 
            this.btn_validar.Location = new System.Drawing.Point(319, 411);
            this.btn_validar.Name = "btn_validar";
            this.btn_validar.Size = new System.Drawing.Size(100, 30);
            this.btn_validar.TabIndex = 12;
            this.btn_validar.Text = "Validar Eje";
            this.btn_validar.UseVisualStyleBackColor = true;
            this.btn_validar.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btn_historico
            // 
            this.btn_historico.Location = new System.Drawing.Point(615, 468);
            this.btn_historico.Name = "btn_historico";
            this.btn_historico.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_historico.Size = new System.Drawing.Size(100, 30);
            this.btn_historico.TabIndex = 59;
            this.btn_historico.Text = "Generar Historico";
            this.btn_historico.UseVisualStyleBackColor = true;
            this.btn_historico.Click += new System.EventHandler(this.btn_historico_Click);
            // 
            // cbo_msem
            // 
            this.cbo_msem.FormattingEnabled = true;
            this.cbo_msem.Location = new System.Drawing.Point(638, 368);
            this.cbo_msem.Name = "cbo_msem";
            this.cbo_msem.Size = new System.Drawing.Size(47, 21);
            this.cbo_msem.TabIndex = 58;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(622, 431);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(10, 13);
            this.label14.TabIndex = 57;
            this.label14.Text = "-";
            // 
            // cbo_mmes2
            // 
            this.cbo_mmes2.FormattingEnabled = true;
            this.cbo_mmes2.Location = new System.Drawing.Point(638, 428);
            this.cbo_mmes2.Name = "cbo_mmes2";
            this.cbo_mmes2.Size = new System.Drawing.Size(47, 21);
            this.cbo_mmes2.TabIndex = 56;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(639, 405);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 20);
            this.label11.TabIndex = 55;
            this.label11.Text = "Mes";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(634, 345);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 20);
            this.label12.TabIndex = 54;
            this.label12.Text = "Mes";
            // 
            // cbo_mmes
            // 
            this.cbo_mmes.FormattingEnabled = true;
            this.cbo_mmes.Location = new System.Drawing.Point(574, 428);
            this.cbo_mmes.Name = "cbo_mmes";
            this.cbo_mmes.Size = new System.Drawing.Size(47, 21);
            this.cbo_mmes.TabIndex = 53;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(575, 407);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 20);
            this.label8.TabIndex = 52;
            this.label8.Text = "Mes";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(704, 405);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 20);
            this.label7.TabIndex = 51;
            this.label7.Text = "Año";
            // 
            // txt_ames
            // 
            this.txt_ames.Location = new System.Drawing.Point(708, 428);
            this.txt_ames.Name = "txt_ames";
            this.txt_ames.Size = new System.Drawing.Size(47, 20);
            this.txt_ames.TabIndex = 50;
            // 
            // cbo_ssem
            // 
            this.cbo_ssem.FormattingEnabled = true;
            this.cbo_ssem.Location = new System.Drawing.Point(568, 369);
            this.cbo_ssem.Name = "cbo_ssem";
            this.cbo_ssem.Size = new System.Drawing.Size(47, 21);
            this.cbo_ssem.TabIndex = 49;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(704, 345);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 20);
            this.label6.TabIndex = 48;
            this.label6.Text = "Año";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(564, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 47;
            this.label5.Text = "Semana";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(469, 429);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 46;
            this.label3.Text = "Mensual";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(469, 370);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 45;
            this.label2.Text = "Semanal";
            // 
            // txt_asem
            // 
            this.txt_asem.Location = new System.Drawing.Point(708, 368);
            this.txt_asem.Name = "txt_asem";
            this.txt_asem.Size = new System.Drawing.Size(47, 20);
            this.txt_asem.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(220, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(309, 32);
            this.label4.TabIndex = 60;
            this.label4.Text = "GRAFICA HORIZONTAL";
            // 
            // frm_grafhori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(814, 531);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_historico);
            this.Controls.Add(this.cbo_msem);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cbo_mmes2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cbo_mmes);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_ames);
            this.Controls.Add(this.cbo_ssem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_asem);
            this.Controls.Add(this.btn_validar);
            this.Controls.Add(this.cbo_eje);
            this.Controls.Add(this.btn_cambiar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_gengraf);
            this.Controls.Add(this.btn_x);
            this.Controls.Add(this.btn_y);
            this.Controls.Add(this.dgv_datos);
            this.Controls.Add(this.btn_acpt);
            this.Controls.Add(this.comboBox1);
            this.Name = "frm_grafhori";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_acpt;
        private System.Windows.Forms.DataGridView dgv_datos;
        private System.Windows.Forms.Button btn_y;
        private System.Windows.Forms.Button btn_x;
        private System.Windows.Forms.Button btn_gengraf;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cambiar;
        private System.Windows.Forms.ComboBox cbo_eje;
        private System.Windows.Forms.Button btn_validar;
        private System.Windows.Forms.Button btn_historico;
        private System.Windows.Forms.ComboBox cbo_msem;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbo_mmes2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbo_mmes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_ames;
        private System.Windows.Forms.ComboBox cbo_ssem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_asem;
        private System.Windows.Forms.Label label4;
    }
}

