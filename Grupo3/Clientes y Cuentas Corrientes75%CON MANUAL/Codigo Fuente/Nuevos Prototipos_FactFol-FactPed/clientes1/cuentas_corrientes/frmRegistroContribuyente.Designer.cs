namespace cuentas_corrientes
{
    partial class frmRegistroContribuyente
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
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_act = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_mod = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nombre:";
            // 
            // txt_nit
            // 
            this.txt_nit.Location = new System.Drawing.Point(109, 223);
            this.txt_nit.Name = "txt_nit";
            this.txt_nit.Size = new System.Drawing.Size(251, 20);
            this.txt_nit.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 21);
            this.label4.TabIndex = 16;
            this.label4.Text = "NIT:";
            // 
            // btn_act
            // 
            this.btn_act.BackgroundImage = global::cuentas_corrientes.Properties.Resources.actualizar;
            this.btn_act.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_act.Location = new System.Drawing.Point(456, 99);
            this.btn_act.Name = "btn_act";
            this.btn_act.Size = new System.Drawing.Size(65, 65);
            this.btn_act.TabIndex = 40;
            this.btn_act.UseVisualStyleBackColor = true;
            // 
            // btn_search
            // 
            this.btn_search.BackgroundImage = global::cuentas_corrientes.Properties.Resources.buscar;
            this.btn_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_search.Location = new System.Drawing.Point(385, 99);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(65, 65);
            this.btn_search.TabIndex = 39;
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // btn_save
            // 
            this.btn_save.BackgroundImage = global::cuentas_corrientes.Properties.Resources.guardar;
            this.btn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_save.Location = new System.Drawing.Point(314, 99);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(65, 65);
            this.btn_save.TabIndex = 38;
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_mod
            // 
            this.btn_mod.BackgroundImage = global::cuentas_corrientes.Properties.Resources.modificar;
            this.btn_mod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_mod.Location = new System.Drawing.Point(243, 99);
            this.btn_mod.Name = "btn_mod";
            this.btn_mod.Size = new System.Drawing.Size(65, 65);
            this.btn_mod.TabIndex = 37;
            this.btn_mod.UseVisualStyleBackColor = true;
            // 
            // btn_del
            // 
            this.btn_del.BackgroundImage = global::cuentas_corrientes.Properties.Resources.borrar;
            this.btn_del.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_del.Location = new System.Drawing.Point(172, 99);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(65, 65);
            this.btn_del.TabIndex = 36;
            this.btn_del.UseVisualStyleBackColor = true;
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.BackgroundImage = global::cuentas_corrientes.Properties.Resources.nuevo;
            this.btn_nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_nuevo.Location = new System.Drawing.Point(101, 99);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(65, 65);
            this.btn_nuevo.TabIndex = 35;
            this.btn_nuevo.UseVisualStyleBackColor = true;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(166, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(295, 32);
            this.label6.TabIndex = 41;
            this.label6.Text = "Cliente contribuyente";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(109, 180);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(251, 20);
            this.txt_nombre.TabIndex = 42;
            // 
            // frmRegistroContribuyente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 273);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_act);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_mod);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_nuevo);
            this.Controls.Add(this.txt_nit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Name = "frmRegistroContribuyente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRegistroContribuyente";
            this.Load += new System.EventHandler(this.frmRegistroContribuyente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_act;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_mod;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_nombre;
    }
}