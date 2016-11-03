namespace ModuloAdminHotel
{
    partial class Frm_ControlDeHabitaciones
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
            this.dgv_controlhabi = new System.Windows.Forms.DataGridView();
            this.txt_estado = new System.Windows.Forms.TextBox();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.lbl_buscar = new System.Windows.Forms.Label();
            this.txt_habitacion = new System.Windows.Forms.TextBox();
            this.lbl_habitacion = new System.Windows.Forms.Label();
            this.lbl_titulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_controlhabi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_controlhabi
            // 
            this.dgv_controlhabi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_controlhabi.Location = new System.Drawing.Point(12, 147);
            this.dgv_controlhabi.Name = "dgv_controlhabi";
            this.dgv_controlhabi.Size = new System.Drawing.Size(680, 222);
            this.dgv_controlhabi.TabIndex = 86;
            // 
            // txt_estado
            // 
            this.txt_estado.Location = new System.Drawing.Point(410, 59);
            this.txt_estado.Name = "txt_estado";
            this.txt_estado.Size = new System.Drawing.Size(235, 27);
            this.txt_estado.TabIndex = 84;
            // 
            // txt_buscar
            // 
            this.txt_buscar.Location = new System.Drawing.Point(269, 102);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(235, 27);
            this.txt_buscar.TabIndex = 85;
            // 
            // lbl_estado
            // 
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_estado.Location = new System.Drawing.Point(340, 65);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(64, 21);
            this.lbl_estado.TabIndex = 82;
            this.lbl_estado.Text = "Estado";
            // 
            // lbl_buscar
            // 
            this.lbl_buscar.AutoSize = true;
            this.lbl_buscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_buscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_buscar.Location = new System.Drawing.Point(198, 105);
            this.lbl_buscar.Name = "lbl_buscar";
            this.lbl_buscar.Size = new System.Drawing.Size(65, 21);
            this.lbl_buscar.TabIndex = 83;
            this.lbl_buscar.Text = "Buscar:";
            // 
            // txt_habitacion
            // 
            this.txt_habitacion.Location = new System.Drawing.Point(166, 59);
            this.txt_habitacion.Name = "txt_habitacion";
            this.txt_habitacion.Size = new System.Drawing.Size(145, 27);
            this.txt_habitacion.TabIndex = 81;
            // 
            // lbl_habitacion
            // 
            this.lbl_habitacion.AutoSize = true;
            this.lbl_habitacion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_habitacion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_habitacion.Location = new System.Drawing.Point(63, 62);
            this.lbl_habitacion.Name = "lbl_habitacion";
            this.lbl_habitacion.Size = new System.Drawing.Size(97, 21);
            this.lbl_habitacion.TabIndex = 80;
            this.lbl_habitacion.Text = "Habitacion";
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_titulo.Location = new System.Drawing.Point(174, 9);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(338, 28);
            this.lbl_titulo.TabIndex = 79;
            this.lbl_titulo.Text = "CONTROL DE HABITACIONES";
            // 
            // Frm_ControlDeHabitaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(104)))), ((int)(((byte)(107)))));
            this.ClientSize = new System.Drawing.Size(704, 381);
            this.Controls.Add(this.dgv_controlhabi);
            this.Controls.Add(this.txt_estado);
            this.Controls.Add(this.txt_buscar);
            this.Controls.Add(this.lbl_estado);
            this.Controls.Add(this.lbl_buscar);
            this.Controls.Add(this.txt_habitacion);
            this.Controls.Add(this.lbl_habitacion);
            this.Controls.Add(this.lbl_titulo);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Frm_ControlDeHabitaciones";
            this.Text = "Frm_ControlDeHabitaciones";
            this.Load += new System.EventHandler(this.Frm_ControlDeHabitaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_controlhabi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_controlhabi;
        private System.Windows.Forms.TextBox txt_estado;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Label lbl_estado;
        private System.Windows.Forms.Label lbl_buscar;
        private System.Windows.Forms.TextBox txt_habitacion;
        private System.Windows.Forms.Label lbl_habitacion;
        private System.Windows.Forms.Label lbl_titulo;
    }
}