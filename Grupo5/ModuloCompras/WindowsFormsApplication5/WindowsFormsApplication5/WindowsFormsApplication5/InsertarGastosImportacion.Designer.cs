namespace WindowsFormsApplication5
{
    partial class InsertarGastosImportacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertarGastosImportacion));
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.dtp_horafecha_salida = new System.Windows.Forms.DateTimePicker();
            this.txt_direccion_salida = new System.Windows.Forms.TextBox();
            this.txt_transporte = new System.Windows.Forms.TextBox();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.lbl_horafecha_salida = new System.Windows.Forms.Label();
            this.lbl_direccion_salida = new System.Windows.Forms.Label();
            this.lbl_transporte = new System.Windows.Forms.Label();
            this.lbl_id_importacion = new System.Windows.Forms.Label();
            this.txt_otros_impuestos = new System.Windows.Forms.TextBox();
            this.txt_aduana = new System.Windows.Forms.TextBox();
            this.dtp_horafecha_llegada = new System.Windows.Forms.DateTimePicker();
            this.txt_direccion_llegada = new System.Windows.Forms.TextBox();
            this.lbl_otros_impuestos = new System.Windows.Forms.Label();
            this.lbl_aduana = new System.Windows.Forms.Label();
            this.lbl_horafecha_llegada = new System.Windows.Forms.Label();
            this.lbl_direccion_llegada = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_aceptar.BackgroundImage")));
            this.btn_aceptar.FlatAppearance.BorderSize = 0;
            this.btn_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_aceptar.Location = new System.Drawing.Point(224, 31);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(65, 65);
            this.btn_aceptar.TabIndex = 0;
            this.btn_aceptar.UseVisualStyleBackColor = true;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cancelar.BackgroundImage")));
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Location = new System.Drawing.Point(335, 31);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(65, 65);
            this.btn_cancelar.TabIndex = 1;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // dtp_horafecha_salida
            // 
            this.dtp_horafecha_salida.Location = new System.Drawing.Point(175, 215);
            this.dtp_horafecha_salida.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_horafecha_salida.Name = "dtp_horafecha_salida";
            this.dtp_horafecha_salida.Size = new System.Drawing.Size(265, 20);
            this.dtp_horafecha_salida.TabIndex = 37;
            // 
            // txt_direccion_salida
            // 
            this.txt_direccion_salida.Location = new System.Drawing.Point(175, 187);
            this.txt_direccion_salida.Margin = new System.Windows.Forms.Padding(4);
            this.txt_direccion_salida.Name = "txt_direccion_salida";
            this.txt_direccion_salida.Size = new System.Drawing.Size(265, 20);
            this.txt_direccion_salida.TabIndex = 36;
            // 
            // txt_transporte
            // 
            this.txt_transporte.Location = new System.Drawing.Point(175, 159);
            this.txt_transporte.Margin = new System.Windows.Forms.Padding(4);
            this.txt_transporte.Name = "txt_transporte";
            this.txt_transporte.Size = new System.Drawing.Size(265, 20);
            this.txt_transporte.TabIndex = 35;
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(175, 131);
            this.txt_codigo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(265, 20);
            this.txt_codigo.TabIndex = 34;
            // 
            // lbl_horafecha_salida
            // 
            this.lbl_horafecha_salida.AutoSize = true;
            this.lbl_horafecha_salida.Location = new System.Drawing.Point(13, 222);
            this.lbl_horafecha_salida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_horafecha_salida.Name = "lbl_horafecha_salida";
            this.lbl_horafecha_salida.Size = new System.Drawing.Size(103, 13);
            this.lbl_horafecha_salida.TabIndex = 33;
            this.lbl_horafecha_salida.Text = "Hora y Fecha Salida";
            // 
            // lbl_direccion_salida
            // 
            this.lbl_direccion_salida.AutoSize = true;
            this.lbl_direccion_salida.Location = new System.Drawing.Point(13, 194);
            this.lbl_direccion_salida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_direccion_salida.Name = "lbl_direccion_salida";
            this.lbl_direccion_salida.Size = new System.Drawing.Size(84, 13);
            this.lbl_direccion_salida.TabIndex = 32;
            this.lbl_direccion_salida.Text = "Direccion Salida";
            // 
            // lbl_transporte
            // 
            this.lbl_transporte.AutoSize = true;
            this.lbl_transporte.Location = new System.Drawing.Point(13, 166);
            this.lbl_transporte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_transporte.Name = "lbl_transporte";
            this.lbl_transporte.Size = new System.Drawing.Size(58, 13);
            this.lbl_transporte.TabIndex = 31;
            this.lbl_transporte.Text = "Transporte";
            // 
            // lbl_id_importacion
            // 
            this.lbl_id_importacion.AutoSize = true;
            this.lbl_id_importacion.Location = new System.Drawing.Point(13, 138);
            this.lbl_id_importacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_id_importacion.Name = "lbl_id_importacion";
            this.lbl_id_importacion.Size = new System.Drawing.Size(40, 13);
            this.lbl_id_importacion.TabIndex = 30;
            this.lbl_id_importacion.Text = "Codigo";
            // 
            // txt_otros_impuestos
            // 
            this.txt_otros_impuestos.Location = new System.Drawing.Point(175, 327);
            this.txt_otros_impuestos.Margin = new System.Windows.Forms.Padding(4);
            this.txt_otros_impuestos.Name = "txt_otros_impuestos";
            this.txt_otros_impuestos.Size = new System.Drawing.Size(265, 20);
            this.txt_otros_impuestos.TabIndex = 45;
            // 
            // txt_aduana
            // 
            this.txt_aduana.Location = new System.Drawing.Point(175, 299);
            this.txt_aduana.Margin = new System.Windows.Forms.Padding(4);
            this.txt_aduana.Name = "txt_aduana";
            this.txt_aduana.Size = new System.Drawing.Size(265, 20);
            this.txt_aduana.TabIndex = 44;
            // 
            // dtp_horafecha_llegada
            // 
            this.dtp_horafecha_llegada.Location = new System.Drawing.Point(175, 271);
            this.dtp_horafecha_llegada.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_horafecha_llegada.Name = "dtp_horafecha_llegada";
            this.dtp_horafecha_llegada.Size = new System.Drawing.Size(265, 20);
            this.dtp_horafecha_llegada.TabIndex = 43;
            // 
            // txt_direccion_llegada
            // 
            this.txt_direccion_llegada.Location = new System.Drawing.Point(175, 243);
            this.txt_direccion_llegada.Margin = new System.Windows.Forms.Padding(4);
            this.txt_direccion_llegada.Name = "txt_direccion_llegada";
            this.txt_direccion_llegada.Size = new System.Drawing.Size(265, 20);
            this.txt_direccion_llegada.TabIndex = 42;
            // 
            // lbl_otros_impuestos
            // 
            this.lbl_otros_impuestos.AutoSize = true;
            this.lbl_otros_impuestos.Location = new System.Drawing.Point(13, 334);
            this.lbl_otros_impuestos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_otros_impuestos.Name = "lbl_otros_impuestos";
            this.lbl_otros_impuestos.Size = new System.Drawing.Size(83, 13);
            this.lbl_otros_impuestos.TabIndex = 41;
            this.lbl_otros_impuestos.Text = "Otros Impuestos";
            // 
            // lbl_aduana
            // 
            this.lbl_aduana.AutoSize = true;
            this.lbl_aduana.Location = new System.Drawing.Point(13, 306);
            this.lbl_aduana.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_aduana.Name = "lbl_aduana";
            this.lbl_aduana.Size = new System.Drawing.Size(44, 13);
            this.lbl_aduana.TabIndex = 40;
            this.lbl_aduana.Text = "Aduana";
            // 
            // lbl_horafecha_llegada
            // 
            this.lbl_horafecha_llegada.AutoSize = true;
            this.lbl_horafecha_llegada.Location = new System.Drawing.Point(13, 278);
            this.lbl_horafecha_llegada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_horafecha_llegada.Name = "lbl_horafecha_llegada";
            this.lbl_horafecha_llegada.Size = new System.Drawing.Size(112, 13);
            this.lbl_horafecha_llegada.TabIndex = 39;
            this.lbl_horafecha_llegada.Text = "Hora y Fecha Llegada";
            // 
            // lbl_direccion_llegada
            // 
            this.lbl_direccion_llegada.AutoSize = true;
            this.lbl_direccion_llegada.Location = new System.Drawing.Point(13, 250);
            this.lbl_direccion_llegada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_direccion_llegada.Name = "lbl_direccion_llegada";
            this.lbl_direccion_llegada.Size = new System.Drawing.Size(93, 13);
            this.lbl_direccion_llegada.TabIndex = 38;
            this.lbl_direccion_llegada.Text = "Direccion Llegada";
            // 
            // InsertarGastosImportacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 401);
            this.Controls.Add(this.txt_otros_impuestos);
            this.Controls.Add(this.txt_aduana);
            this.Controls.Add(this.dtp_horafecha_llegada);
            this.Controls.Add(this.txt_direccion_llegada);
            this.Controls.Add(this.lbl_otros_impuestos);
            this.Controls.Add(this.lbl_aduana);
            this.Controls.Add(this.lbl_horafecha_llegada);
            this.Controls.Add(this.lbl_direccion_llegada);
            this.Controls.Add(this.dtp_horafecha_salida);
            this.Controls.Add(this.txt_direccion_salida);
            this.Controls.Add(this.txt_transporte);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.lbl_horafecha_salida);
            this.Controls.Add(this.lbl_direccion_salida);
            this.Controls.Add(this.lbl_transporte);
            this.Controls.Add(this.lbl_id_importacion);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_aceptar);
            this.Name = "InsertarGastosImportacion";
            this.Text = "InsertarGastosImportacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.DateTimePicker dtp_horafecha_salida;
        private System.Windows.Forms.TextBox txt_direccion_salida;
        private System.Windows.Forms.TextBox txt_transporte;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Label lbl_horafecha_salida;
        private System.Windows.Forms.Label lbl_direccion_salida;
        private System.Windows.Forms.Label lbl_transporte;
        private System.Windows.Forms.Label lbl_id_importacion;
        private System.Windows.Forms.TextBox txt_otros_impuestos;
        private System.Windows.Forms.TextBox txt_aduana;
        private System.Windows.Forms.DateTimePicker dtp_horafecha_llegada;
        private System.Windows.Forms.TextBox txt_direccion_llegada;
        private System.Windows.Forms.Label lbl_otros_impuestos;
        private System.Windows.Forms.Label lbl_aduana;
        private System.Windows.Forms.Label lbl_horafecha_llegada;
        private System.Windows.Forms.Label lbl_direccion_llegada;
    }
}