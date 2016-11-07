namespace cuentas_corrientes
{
    partial class frmbusclistaprecio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmbusclistaprecio));
            this.txt_bien = new System.Windows.Forms.TextBox();
            this.dgv_bien = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_buscbien = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bien)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_bien
            // 
            this.txt_bien.Location = new System.Drawing.Point(176, 92);
            this.txt_bien.Name = "txt_bien";
            this.txt_bien.Size = new System.Drawing.Size(199, 20);
            this.txt_bien.TabIndex = 21;
            // 
            // dgv_bien
            // 
            this.dgv_bien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_bien.Location = new System.Drawing.Point(81, 151);
            this.dgv_bien.Name = "dgv_bien";
            this.dgv_bien.Size = new System.Drawing.Size(484, 150);
            this.dgv_bien.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(77, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 21);
            this.label3.TabIndex = 17;
            this.label3.Text = "Nombre:";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::cuentas_corrientes.Properties.Resources.nuevo;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(500, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 65);
            this.button1.TabIndex = 20;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_buscbien
            // 
            this.btn_buscbien.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_buscbien.BackgroundImage")));
            this.btn_buscbien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscbien.Location = new System.Drawing.Point(381, 90);
            this.btn_buscbien.Name = "btn_buscbien";
            this.btn_buscbien.Size = new System.Drawing.Size(29, 23);
            this.btn_buscbien.TabIndex = 18;
            this.btn_buscbien.UseVisualStyleBackColor = true;
            this.btn_buscbien.Click += new System.EventHandler(this.btn_buscbien_Click);
            // 
            // frmbusclistaprecio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 349);
            this.Controls.Add(this.txt_bien);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv_bien);
            this.Controls.Add(this.btn_buscbien);
            this.Controls.Add(this.label3);
            this.Name = "frmbusclistaprecio";
            this.Text = "frmbusclistaprecio";
            this.Load += new System.EventHandler(this.frmbusclistaprecio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_bien;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgv_bien;
        private System.Windows.Forms.Button btn_buscbien;
        private System.Windows.Forms.Label label3;
    }
}