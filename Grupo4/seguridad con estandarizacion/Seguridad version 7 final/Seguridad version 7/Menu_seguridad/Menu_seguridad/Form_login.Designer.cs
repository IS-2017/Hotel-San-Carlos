﻿namespace Menu_seguridad
{
    partial class Form_login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_login));
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.txt_contraseña = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_logear = new System.Windows.Forms.Button();
            this.pb_hsc = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_hsc)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(172, 273);
            this.txt_usuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(193, 22);
            this.txt_usuario.TabIndex = 0;
            // 
            // txt_contraseña
            // 
            this.txt_contraseña.Location = new System.Drawing.Point(172, 312);
            this.txt_contraseña.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_contraseña.Name = "txt_contraseña";
            this.txt_contraseña.Size = new System.Drawing.Size(193, 22);
            this.txt_contraseña.TabIndex = 1;
            this.txt_contraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_contraseña_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 272);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 313);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña:";
            // 
            // btn_logear
            // 
            this.btn_logear.Location = new System.Drawing.Point(133, 376);
            this.btn_logear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_logear.Name = "btn_logear";
            this.btn_logear.Size = new System.Drawing.Size(195, 57);
            this.btn_logear.TabIndex = 4;
            this.btn_logear.Text = "Iniciar";
            this.btn_logear.UseVisualStyleBackColor = true;
            this.btn_logear.Click += new System.EventHandler(this.btn_logear_Click);
            // 
            // pb_hsc
            // 
            this.pb_hsc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_hsc.BackgroundImage")));
            this.pb_hsc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_hsc.Location = new System.Drawing.Point(133, 60);
            this.pb_hsc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pb_hsc.Name = "pb_hsc";
            this.pb_hsc.Size = new System.Drawing.Size(195, 172);
            this.pb_hsc.TabIndex = 5;
            this.pb_hsc.TabStop = false;
            // 
            // Form_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(448, 511);
            this.Controls.Add(this.pb_hsc);
            this.Controls.Add(this.btn_logear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_contraseña);
            this.Controls.Add(this.txt_usuario);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form_login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_hsc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.TextBox txt_contraseña;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_logear;
        private System.Windows.Forms.PictureBox pb_hsc;
    }
}
