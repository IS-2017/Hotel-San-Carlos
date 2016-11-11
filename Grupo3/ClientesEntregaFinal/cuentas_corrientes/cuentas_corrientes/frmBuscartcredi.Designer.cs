namespace cuentas_corrientes
{
    partial class frmBuscartcredi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscartcredi));
            this.dgv_btc = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_busc = new System.Windows.Forms.Button();
            this.txt_tipo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_btc)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_btc
            // 
            this.dgv_btc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_btc.Location = new System.Drawing.Point(23, 121);
            this.dgv_btc.Name = "dgv_btc";
            this.dgv_btc.Size = new System.Drawing.Size(484, 150);
            this.dgv_btc.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 21);
            this.label3.TabIndex = 15;
            this.label3.Text = "Tipo:";
            // 
            // btn_busc
            // 
            this.btn_busc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_busc.BackgroundImage")));
            this.btn_busc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_busc.Location = new System.Drawing.Point(298, 64);
            this.btn_busc.Name = "btn_busc";
            this.btn_busc.Size = new System.Drawing.Size(29, 23);
            this.btn_busc.TabIndex = 16;
            this.btn_busc.UseVisualStyleBackColor = true;
            this.btn_busc.Click += new System.EventHandler(this.btn_busc_Click);
            // 
            // txt_tipo
            // 
            this.txt_tipo.Location = new System.Drawing.Point(95, 64);
            this.txt_tipo.Name = "txt_tipo";
            this.txt_tipo.Size = new System.Drawing.Size(187, 20);
            this.txt_tipo.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::cuentas_corrientes.Properties.Resources.nuevo;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(442, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 65);
            this.button1.TabIndex = 20;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmBuscartcredi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(531, 330);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_tipo);
            this.Controls.Add(this.dgv_btc);
            this.Controls.Add(this.btn_busc);
            this.Controls.Add(this.label3);
            this.Name = "frmBuscartcredi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBuscartcredi";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_btc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_btc;
        private System.Windows.Forms.Button btn_busc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_tipo;
        private System.Windows.Forms.Button button1;
    }
}