namespace cuentas_corrientes
{
    partial class frmbuscliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmbuscliente));
            this.cbo_nombreimpuesto = new System.Windows.Forms.ComboBox();
            this.dgv_impuesto = new System.Windows.Forms.DataGridView();
            this.btn_buscimp = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_impuesto)).BeginInit();
            this.SuspendLayout();
            // 
            // cbo_nombreimpuesto
            // 
            this.cbo_nombreimpuesto.FormattingEnabled = true;
            this.cbo_nombreimpuesto.Location = new System.Drawing.Point(126, 82);
            this.cbo_nombreimpuesto.Name = "cbo_nombreimpuesto";
            this.cbo_nombreimpuesto.Size = new System.Drawing.Size(282, 21);
            this.cbo_nombreimpuesto.TabIndex = 14;
            // 
            // dgv_impuesto
            // 
            this.dgv_impuesto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_impuesto.Location = new System.Drawing.Point(23, 142);
            this.dgv_impuesto.Name = "dgv_impuesto";
            this.dgv_impuesto.Size = new System.Drawing.Size(484, 150);
            this.dgv_impuesto.TabIndex = 13;
            // 
            // btn_buscimp
            // 
            this.btn_buscimp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_buscimp.BackgroundImage")));
            this.btn_buscimp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscimp.Location = new System.Drawing.Point(414, 80);
            this.btn_buscimp.Name = "btn_buscimp";
            this.btn_buscimp.Size = new System.Drawing.Size(29, 23);
            this.btn_buscimp.TabIndex = 12;
            this.btn_buscimp.UseVisualStyleBackColor = true;
            this.btn_buscimp.Click += new System.EventHandler(this.btn_buscimp_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nombre:";
            // 
            // frmbuscliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(531, 330);
            this.Controls.Add(this.cbo_nombreimpuesto);
            this.Controls.Add(this.dgv_impuesto);
            this.Controls.Add(this.btn_buscimp);
            this.Controls.Add(this.label3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmbuscliente";
            this.Text = "Buscar Cliente";
            this.Load += new System.EventHandler(this.frmBuscImpuesto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_impuesto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo_nombreimpuesto;
        private System.Windows.Forms.DataGridView dgv_impuesto;
        private System.Windows.Forms.Button btn_buscimp;
        private System.Windows.Forms.Label label3;
    }
}