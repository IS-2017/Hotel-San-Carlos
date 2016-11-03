namespace ModuloAdminHotel
{
    partial class Frm_Folio_Detalle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Folio_Detalle));
            this.label17 = new System.Windows.Forms.Label();
            this.dgv_evento = new System.Windows.Forms.DataGridView();
            this.dgv_articulo = new System.Windows.Forms.DataGridView();
            this.dgv_promocion = new System.Windows.Forms.DataGridView();
            this.cbo_nombreft = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.cbo_ftfolio = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_reservacion = new System.Windows.Forms.DataGridView();
            this.lbl_costo_reservacion = new System.Windows.Forms.Label();
            this.lbl_costo_evento = new System.Windows.Forms.Label();
            this.lbl_costo_articulo = new System.Windows.Forms.Label();
            this.lbl_costo_promocion = new System.Windows.Forms.Label();
            this.lbl_total_folio = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_evento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_articulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_promocion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reservacion)).BeginInit();
            this.SuspendLayout();
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(483, 12);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(298, 32);
            this.label17.TabIndex = 14;
            this.label17.Text = "INFORMACION FOLIO";
            // 
            // dgv_evento
            // 
            this.dgv_evento.AllowUserToAddRows = false;
            this.dgv_evento.AllowUserToDeleteRows = false;
            this.dgv_evento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_evento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_evento.Location = new System.Drawing.Point(673, 109);
            this.dgv_evento.Name = "dgv_evento";
            this.dgv_evento.ReadOnly = true;
            this.dgv_evento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_evento.Size = new System.Drawing.Size(621, 204);
            this.dgv_evento.TabIndex = 119;
            this.dgv_evento.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_evento_CellContentClick);
            // 
            // dgv_articulo
            // 
            this.dgv_articulo.AllowUserToAddRows = false;
            this.dgv_articulo.AllowUserToDeleteRows = false;
            this.dgv_articulo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_articulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_articulo.Location = new System.Drawing.Point(12, 354);
            this.dgv_articulo.Name = "dgv_articulo";
            this.dgv_articulo.ReadOnly = true;
            this.dgv_articulo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_articulo.Size = new System.Drawing.Size(627, 206);
            this.dgv_articulo.TabIndex = 120;
            this.dgv_articulo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_articulo_CellContentClick);
            // 
            // dgv_promocion
            // 
            this.dgv_promocion.AllowUserToAddRows = false;
            this.dgv_promocion.AllowUserToDeleteRows = false;
            this.dgv_promocion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_promocion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_promocion.Location = new System.Drawing.Point(673, 354);
            this.dgv_promocion.Name = "dgv_promocion";
            this.dgv_promocion.ReadOnly = true;
            this.dgv_promocion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_promocion.Size = new System.Drawing.Size(621, 206);
            this.dgv_promocion.TabIndex = 121;
            this.dgv_promocion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_promocion_CellContentClick);
            // 
            // cbo_nombreft
            // 
            this.cbo_nombreft.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_nombreft.FormattingEnabled = true;
            this.cbo_nombreft.Location = new System.Drawing.Point(145, 12);
            this.cbo_nombreft.Name = "cbo_nombreft";
            this.cbo_nombreft.Size = new System.Drawing.Size(290, 21);
            this.cbo_nombreft.TabIndex = 127;
            this.cbo_nombreft.SelectedIndexChanged += new System.EventHandler(this.cbo_nombreft_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(2, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 21);
            this.label6.TabIndex = 126;
            this.label6.Text = "Nombre Cliente: ";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(12, 86);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(102, 17);
            this.radioButton1.TabIndex = 129;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "RESERVACIÓN";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(673, 83);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(69, 17);
            this.radioButton2.TabIndex = 130;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "EVENTO";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(12, 329);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(79, 17);
            this.radioButton3.TabIndex = 131;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "ARTICULO";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(675, 329);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(91, 17);
            this.radioButton4.TabIndex = 132;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "PROMOCIÓN";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // cbo_ftfolio
            // 
            this.cbo_ftfolio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_ftfolio.FormattingEnabled = true;
            this.cbo_ftfolio.Location = new System.Drawing.Point(145, 39);
            this.cbo_ftfolio.Name = "cbo_ftfolio";
            this.cbo_ftfolio.Size = new System.Drawing.Size(290, 21);
            this.cbo_ftfolio.TabIndex = 133;
            this.cbo_ftfolio.SelectedIndexChanged += new System.EventHandler(this.cbo_ftfolio_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 21);
            this.label1.TabIndex = 134;
            this.label1.Text = "Folio Cliente: ";
            // 
            // dgv_reservacion
            // 
            this.dgv_reservacion.AllowUserToAddRows = false;
            this.dgv_reservacion.AllowUserToDeleteRows = false;
            this.dgv_reservacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_reservacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_reservacion.Location = new System.Drawing.Point(12, 109);
            this.dgv_reservacion.Name = "dgv_reservacion";
            this.dgv_reservacion.ReadOnly = true;
            this.dgv_reservacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_reservacion.Size = new System.Drawing.Size(627, 204);
            this.dgv_reservacion.TabIndex = 136;
            this.dgv_reservacion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_reservacion_CellClick);
            // 
            // lbl_costo_reservacion
            // 
            this.lbl_costo_reservacion.AutoSize = true;
            this.lbl_costo_reservacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_costo_reservacion.Location = new System.Drawing.Point(594, 87);
            this.lbl_costo_reservacion.Name = "lbl_costo_reservacion";
            this.lbl_costo_reservacion.Size = new System.Drawing.Size(51, 16);
            this.lbl_costo_reservacion.TabIndex = 137;
            this.lbl_costo_reservacion.Text = "label2";
            // 
            // lbl_costo_evento
            // 
            this.lbl_costo_evento.AutoSize = true;
            this.lbl_costo_evento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_costo_evento.Location = new System.Drawing.Point(1238, 85);
            this.lbl_costo_evento.Name = "lbl_costo_evento";
            this.lbl_costo_evento.Size = new System.Drawing.Size(51, 16);
            this.lbl_costo_evento.TabIndex = 138;
            this.lbl_costo_evento.Text = "label3";
            // 
            // lbl_costo_articulo
            // 
            this.lbl_costo_articulo.AutoSize = true;
            this.lbl_costo_articulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_costo_articulo.Location = new System.Drawing.Point(564, 333);
            this.lbl_costo_articulo.Name = "lbl_costo_articulo";
            this.lbl_costo_articulo.Size = new System.Drawing.Size(51, 16);
            this.lbl_costo_articulo.TabIndex = 139;
            this.lbl_costo_articulo.Text = "label4";
            // 
            // lbl_costo_promocion
            // 
            this.lbl_costo_promocion.AutoSize = true;
            this.lbl_costo_promocion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_costo_promocion.Location = new System.Drawing.Point(1229, 329);
            this.lbl_costo_promocion.Name = "lbl_costo_promocion";
            this.lbl_costo_promocion.Size = new System.Drawing.Size(51, 16);
            this.lbl_costo_promocion.TabIndex = 140;
            this.lbl_costo_promocion.Text = "label5";
            // 
            // lbl_total_folio
            // 
            this.lbl_total_folio.AutoSize = true;
            this.lbl_total_folio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total_folio.Location = new System.Drawing.Point(673, 585);
            this.lbl_total_folio.Name = "lbl_total_folio";
            this.lbl_total_folio.Size = new System.Drawing.Size(57, 20);
            this.lbl_total_folio.TabIndex = 142;
            this.lbl_total_folio.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(350, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 16);
            this.label2.TabIndex = 143;
            this.label2.Text = "Total de Reservación: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1046, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 16);
            this.label3.TabIndex = 144;
            this.label3.Text = "Total de Evento: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(350, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 16);
            this.label4.TabIndex = 145;
            this.label4.Text = "Total de Articulo: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1060, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 16);
            this.label5.TabIndex = 146;
            this.label5.Text = "Total de Promoción: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(485, 585);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 20);
            this.label7.TabIndex = 147;
            this.label7.Text = "Total del Folio: ";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1232, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 54);
            this.button1.TabIndex = 128;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(910, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(53, 31);
            this.button2.TabIndex = 148;
            this.button2.Text = "Ayuda";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // Frm_Folio_Detalle
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.ClientSize = new System.Drawing.Size(1306, 614);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_total_folio);
            this.Controls.Add(this.lbl_costo_promocion);
            this.Controls.Add(this.lbl_costo_articulo);
            this.Controls.Add(this.lbl_costo_evento);
            this.Controls.Add(this.lbl_costo_reservacion);
            this.Controls.Add(this.dgv_reservacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbo_ftfolio);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbo_nombreft);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgv_promocion);
            this.Controls.Add(this.dgv_articulo);
            this.Controls.Add(this.dgv_evento);
            this.Controls.Add(this.label17);
            this.Name = "Frm_Folio_Detalle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Folio_Detalle";
            this.Load += new System.EventHandler(this.Frm_Folio_Detalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_evento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_articulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_promocion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reservacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridView dgv_evento;
        private System.Windows.Forms.DataGridView dgv_articulo;
        private System.Windows.Forms.DataGridView dgv_promocion;
        private System.Windows.Forms.ComboBox cbo_nombreft;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.ComboBox cbo_ftfolio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_reservacion;
        private System.Windows.Forms.Label lbl_costo_reservacion;
        private System.Windows.Forms.Label lbl_costo_evento;
        private System.Windows.Forms.Label lbl_costo_articulo;
        private System.Windows.Forms.Label lbl_costo_promocion;
        private System.Windows.Forms.Label lbl_total_folio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
    }
}