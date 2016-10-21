namespace Navegador
{
    partial class Form_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_login));
            this.pb_hsc = new System.Windows.Forms.PictureBox();
            this.btn_logear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_contraseña = new System.Windows.Forms.TextBox();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_hsc)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_hsc
            // 
            this.pb_hsc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_hsc.BackgroundImage")));
            this.pb_hsc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_hsc.Location = new System.Drawing.Point(110, 24);
            this.pb_hsc.Name = "pb_hsc";
            this.pb_hsc.Size = new System.Drawing.Size(146, 140);
            this.pb_hsc.TabIndex = 11;
            this.pb_hsc.TabStop = false;
            // 
            // btn_logear
            // 
            this.btn_logear.Location = new System.Drawing.Point(110, 280);
            this.btn_logear.Name = "btn_logear";
            this.btn_logear.Size = new System.Drawing.Size(146, 46);
            this.btn_logear.TabIndex = 10;
            this.btn_logear.Text = "Iniciar";
            this.btn_logear.UseVisualStyleBackColor = true;
            this.btn_logear.Click += new System.EventHandler(this.btn_logear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Contraseña:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Usuario:";
            // 
            // txt_contraseña
            // 
            this.txt_contraseña.Location = new System.Drawing.Point(110, 223);
            this.txt_contraseña.Name = "txt_contraseña";
            this.txt_contraseña.Size = new System.Drawing.Size(146, 20);
            this.txt_contraseña.TabIndex = 7;
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(110, 188);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(146, 20);
            this.txt_usuario.TabIndex = 6;
            // 
            // Form_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 368);
            this.Controls.Add(this.pb_hsc);
            this.Controls.Add(this.btn_logear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_contraseña);
            this.Controls.Add(this.txt_usuario);
            this.Name = "Form_login";
            this.Text = "Form_login";
            ((System.ComponentModel.ISupportInitialize)(this.pb_hsc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_hsc;
        private System.Windows.Forms.Button btn_logear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_contraseña;
        private System.Windows.Forms.TextBox txt_usuario;
    }
}