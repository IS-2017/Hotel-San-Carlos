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
            this.dgv_clte = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_buscimp = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_clte = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clte)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_clte
            // 
            this.dgv_clte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_clte.Location = new System.Drawing.Point(23, 142);
            this.dgv_clte.Name = "dgv_clte";
            this.dgv_clte.Size = new System.Drawing.Size(484, 150);
            this.dgv_clte.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nombre:";
            // 
            // btn_buscimp
            // 
            this.btn_buscimp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_buscimp.BackgroundImage")));
            this.btn_buscimp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscimp.Location = new System.Drawing.Point(323, 81);
            this.btn_buscimp.Name = "btn_buscimp";
            this.btn_buscimp.Size = new System.Drawing.Size(29, 23);
            this.btn_buscimp.TabIndex = 12;
            this.btn_buscimp.UseVisualStyleBackColor = true;
            this.btn_buscimp.Click += new System.EventHandler(this.btn_buscimp_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::cuentas_corrientes.Properties.Resources.nuevo;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(442, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 65);
            this.button1.TabIndex = 15;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_clte
            // 
            this.txt_clte.Location = new System.Drawing.Point(118, 83);
            this.txt_clte.Name = "txt_clte";
            this.txt_clte.Size = new System.Drawing.Size(199, 20);
            this.txt_clte.TabIndex = 16;
            // 
            // frmbuscliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(531, 330);
            this.Controls.Add(this.txt_clte);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv_clte);
            this.Controls.Add(this.btn_buscimp);
            this.Controls.Add(this.label3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmbuscliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Cliente";
            this.Load += new System.EventHandler(this.frmBuscImpuesto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_clte;
        private System.Windows.Forms.Button btn_buscimp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_clte;
    }
}