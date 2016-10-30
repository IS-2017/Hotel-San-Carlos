namespace produccion
{
    partial class frm_NuevoProceso
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
            this.txt_nombre_proceso = new System.Windows.Forms.TextBox();
            this.txt_tiempo_elaboracion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_medida_tiempo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_observaciones = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_nombre_proceso
            // 
            this.txt_nombre_proceso.Location = new System.Drawing.Point(257, 100);
            this.txt_nombre_proceso.Name = "txt_nombre_proceso";
            this.txt_nombre_proceso.Size = new System.Drawing.Size(237, 20);
            this.txt_nombre_proceso.TabIndex = 0;
            // 
            // txt_tiempo_elaboracion
            // 
            this.txt_tiempo_elaboracion.Location = new System.Drawing.Point(257, 136);
            this.txt_tiempo_elaboracion.Name = "txt_tiempo_elaboracion";
            this.txt_tiempo_elaboracion.Size = new System.Drawing.Size(64, 20);
            this.txt_tiempo_elaboracion.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre del Proceso:  ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tiempo de elaboracion: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Descripcion:";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(257, 179);
            this.txt_descripcion.Multiline = true;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(237, 94);
            this.txt_descripcion.TabIndex = 5;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(199, 436);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_aceptar.TabIndex = 6;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(358, 436);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 7;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(194, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 29);
            this.label5.TabIndex = 14;
            this.label5.Text = "Nuevo Proceso";
            // 
            // cmb_medida_tiempo
            // 
            this.cmb_medida_tiempo.FormattingEnabled = true;
            this.cmb_medida_tiempo.Items.AddRange(new object[] {
            "Segundo",
            "Minutos",
            "Horas"});
            this.cmb_medida_tiempo.Location = new System.Drawing.Point(400, 136);
            this.cmb_medida_tiempo.Name = "cmb_medida_tiempo";
            this.cmb_medida_tiempo.Size = new System.Drawing.Size(94, 21);
            this.cmb_medida_tiempo.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Observaciones:";
            // 
            // txt_observaciones
            // 
            this.txt_observaciones.Location = new System.Drawing.Point(257, 310);
            this.txt_observaciones.Multiline = true;
            this.txt_observaciones.Name = "txt_observaciones";
            this.txt_observaciones.Size = new System.Drawing.Size(237, 82);
            this.txt_observaciones.TabIndex = 17;
            // 
            // frm_NuevoProceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(644, 513);
            this.Controls.Add(this.txt_observaciones);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_medida_tiempo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_tiempo_elaboracion);
            this.Controls.Add(this.txt_nombre_proceso);
            this.Name = "frm_NuevoProceso";
            this.Text = "NuevoProceso";
            this.Load += new System.EventHandler(this.NuevoProceso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_nombre_proceso;
        private System.Windows.Forms.TextBox txt_tiempo_elaboracion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_medida_tiempo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_observaciones;
    }
}