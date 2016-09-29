namespace dllconsultasgeneraless
{
    partial class frm_gurdar
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
            this.btn_cancelarGuardar = new System.Windows.Forms.Button();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_cancelarGuardar
            // 
            this.btn_cancelarGuardar.BackgroundImage = global::dllconsultasgeneraless.Properties.Resources.Button_Close_icon;
            this.btn_cancelarGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cancelarGuardar.FlatAppearance.BorderSize = 0;
            this.btn_cancelarGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelarGuardar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelarGuardar.Location = new System.Drawing.Point(106, 124);
            this.btn_cancelarGuardar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_cancelarGuardar.Name = "btn_cancelarGuardar";
            this.btn_cancelarGuardar.Size = new System.Drawing.Size(82, 58);
            this.btn_cancelarGuardar.TabIndex = 9;
            this.btn_cancelarGuardar.UseVisualStyleBackColor = true;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(121, 9);
            this.lbl_titulo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(205, 21);
            this.lbl_titulo.TabIndex = 8;
            this.lbl_titulo.Text = "ALMACENAR CONSULTA";
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackgroundImage = global::dllconsultasgeneraless.Properties.Resources.Save_icon;
            this.btn_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_guardar.FlatAppearance.BorderSize = 0;
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.Location = new System.Drawing.Point(223, 124);
            this.btn_guardar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(94, 58);
            this.btn_guardar.TabIndex = 7;
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.Location = new System.Drawing.Point(14, 78);
            this.lbl_nombre.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(83, 21);
            this.lbl_nombre.TabIndex = 6;
            this.lbl_nombre.Text = "NOMBRE:";
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txt_Nombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nombre.Location = new System.Drawing.Point(106, 78);
            this.txt_Nombre.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(332, 27);
            this.txt_Nombre.TabIndex = 5;
            // 
            // frm_gurdar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(456, 214);
            this.Controls.Add(this.btn_cancelarGuardar);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.txt_Nombre);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "frm_gurdar";
            this.Text = "frm_gurdar";
            this.Load += new System.EventHandler(this.frm_gurdar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cancelarGuardar;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.TextBox txt_Nombre;
    }
}