namespace ModuloAdminHotel
{
    partial class Frm_HabitacionesEspecificas
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
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.clb_habitaciones = new System.Windows.Forms.CheckedListBox();
            this.cbo_tipo = new System.Windows.Forms.ComboBox();
            this.lbl_tipo = new System.Windows.Forms.Label();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(475, 62);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(74, 27);
            this.txt_cantidad.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(378, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 21);
            this.label1.TabIndex = 26;
            this.label1.Text = "Cantidad:";
            // 
            // clb_habitaciones
            // 
            this.clb_habitaciones.FormattingEnabled = true;
            this.clb_habitaciones.Items.AddRange(new object[] {
            "hola"});
            this.clb_habitaciones.Location = new System.Drawing.Point(213, 120);
            this.clb_habitaciones.Name = "clb_habitaciones";
            this.clb_habitaciones.Size = new System.Drawing.Size(306, 224);
            this.clb_habitaciones.TabIndex = 25;
            // 
            // cbo_tipo
            // 
            this.cbo_tipo.FormattingEnabled = true;
            this.cbo_tipo.Location = new System.Drawing.Point(172, 62);
            this.cbo_tipo.Name = "cbo_tipo";
            this.cbo_tipo.Size = new System.Drawing.Size(187, 29);
            this.cbo_tipo.TabIndex = 24;
            // 
            // lbl_tipo
            // 
            this.lbl_tipo.AutoSize = true;
            this.lbl_tipo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_tipo.Location = new System.Drawing.Point(120, 65);
            this.lbl_tipo.Name = "lbl_tipo";
            this.lbl_tipo.Size = new System.Drawing.Size(46, 21);
            this.lbl_tipo.TabIndex = 23;
            this.lbl_tipo.Text = "Tipo:";
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_titulo.Location = new System.Drawing.Point(172, 8);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(365, 28);
            this.lbl_titulo.TabIndex = 22;
            this.lbl_titulo.Text = "RESERVACION DE HABITACION";
            // 
            // Frm_HabitacionesEspecificas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(104)))), ((int)(((byte)(107)))));
            this.ClientSize = new System.Drawing.Size(704, 381);
            this.Controls.Add(this.txt_cantidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clb_habitaciones);
            this.Controls.Add(this.cbo_tipo);
            this.Controls.Add(this.lbl_tipo);
            this.Controls.Add(this.lbl_titulo);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Frm_HabitacionesEspecificas";
            this.Text = "Frm_HabitacionesEspecificas";
            this.Load += new System.EventHandler(this.Frm_HabitacionesEspecificas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox clb_habitaciones;
        private System.Windows.Forms.ComboBox cbo_tipo;
        private System.Windows.Forms.Label lbl_tipo;
        private System.Windows.Forms.Label lbl_titulo;
    }
}