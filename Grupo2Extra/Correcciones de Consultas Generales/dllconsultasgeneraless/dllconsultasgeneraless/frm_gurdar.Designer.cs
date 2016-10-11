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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_gurdar));
            this.btn_cancelarGuardar = new System.Windows.Forms.Button();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Regresar = new System.Windows.Forms.Button();
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
            this.btn_cancelarGuardar.Margin = new System.Windows.Forms.Padding(5);
            this.btn_cancelarGuardar.Name = "btn_cancelarGuardar";
            this.btn_cancelarGuardar.Size = new System.Drawing.Size(82, 49);
            this.btn_cancelarGuardar.TabIndex = 9;
            this.btn_cancelarGuardar.UseVisualStyleBackColor = true;
            this.btn_cancelarGuardar.Click += new System.EventHandler(this.btn_cancelarGuardar_Click);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(124, 22);
            this.lbl_titulo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(278, 25);
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
            this.btn_guardar.Location = new System.Drawing.Point(294, 124);
            this.btn_guardar.Margin = new System.Windows.Forms.Padding(5);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(81, 49);
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
            this.txt_Nombre.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_Nombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nombre.Location = new System.Drawing.Point(106, 78);
            this.txt_Nombre.Margin = new System.Windows.Forms.Padding(5);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(332, 27);
            this.txt_Nombre.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 184);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "Cancelar Consulta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(261, 184);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "Guardar Consulta";
            // 
            // btn_Regresar
            // 
            this.btn_Regresar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Regresar.BackgroundImage")));
            this.btn_Regresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Regresar.FlatAppearance.BorderSize = 0;
            this.btn_Regresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Regresar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Regresar.Location = new System.Drawing.Point(12, 9);
            this.btn_Regresar.Name = "btn_Regresar";
            this.btn_Regresar.Size = new System.Drawing.Size(55, 46);
            this.btn_Regresar.TabIndex = 71;
            this.btn_Regresar.UseVisualStyleBackColor = true;
            this.btn_Regresar.Click += new System.EventHandler(this.btn_Regresar_Click);
            // 
            // frm_gurdar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(456, 214);
            this.Controls.Add(this.btn_Regresar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cancelarGuardar);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.txt_Nombre);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Regresar;
    }
}