namespace seguridad
{
    partial class FormEliminarPerfil
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_deshabilitar = new System.Windows.Forms.Button();
            this.cbo_perfil = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_deshabilitar);
            this.groupBox1.Controls.Add(this.cbo_perfil);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(36, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 144);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Deshabilitar perfil:";
            // 
            // btn_deshabilitar
            // 
            this.btn_deshabilitar.Location = new System.Drawing.Point(103, 98);
            this.btn_deshabilitar.Name = "btn_deshabilitar";
            this.btn_deshabilitar.Size = new System.Drawing.Size(75, 23);
            this.btn_deshabilitar.TabIndex = 2;
            this.btn_deshabilitar.Text = "Deshabilitar";
            this.btn_deshabilitar.UseVisualStyleBackColor = true;
            this.btn_deshabilitar.Click += new System.EventHandler(this.btn_deshabilitar_Click);
            // 
            // cbo_perfil
            // 
            this.cbo_perfil.FormattingEnabled = true;
            this.cbo_perfil.Location = new System.Drawing.Point(93, 46);
            this.cbo_perfil.Name = "cbo_perfil";
            this.cbo_perfil.Size = new System.Drawing.Size(121, 21);
            this.cbo_perfil.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Perfil:";
            // 
            // FormEliminarPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 235);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormEliminarPerfil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deshabilitar perfil";
            this.Load += new System.EventHandler(this.FormEliminarPerfil_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_deshabilitar;
        private System.Windows.Forms.ComboBox cbo_perfil;
        private System.Windows.Forms.Label label1;
    }
}