namespace cuentas_corrientes
{
    partial class frmBuscardeuda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscardeuda));
            this.txt_deuda = new System.Windows.Forms.TextBox();
            this.dgv_deuda = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_acpt = new System.Windows.Forms.Button();
            this.btn_busd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_deuda)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_deuda
            // 
            this.txt_deuda.Location = new System.Drawing.Point(120, 67);
            this.txt_deuda.Name = "txt_deuda";
            this.txt_deuda.Size = new System.Drawing.Size(199, 20);
            this.txt_deuda.TabIndex = 21;
            // 
            // dgv_deuda
            // 
            this.dgv_deuda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_deuda.Location = new System.Drawing.Point(25, 126);
            this.dgv_deuda.Name = "dgv_deuda";
            this.dgv_deuda.Size = new System.Drawing.Size(484, 150);
            this.dgv_deuda.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 21);
            this.label3.TabIndex = 17;
            this.label3.Text = "Nombre:";
            // 
            // btn_acpt
            // 
            this.btn_acpt.BackgroundImage = global::cuentas_corrientes.Properties.Resources.nuevo;
            this.btn_acpt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_acpt.Location = new System.Drawing.Point(444, 55);
            this.btn_acpt.Name = "btn_acpt";
            this.btn_acpt.Size = new System.Drawing.Size(65, 65);
            this.btn_acpt.TabIndex = 20;
            this.btn_acpt.UseVisualStyleBackColor = true;
            this.btn_acpt.Click += new System.EventHandler(this.btn_acpt_Click);
            // 
            // btn_busd
            // 
            this.btn_busd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_busd.BackgroundImage")));
            this.btn_busd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_busd.Location = new System.Drawing.Point(325, 65);
            this.btn_busd.Name = "btn_busd";
            this.btn_busd.Size = new System.Drawing.Size(29, 23);
            this.btn_busd.TabIndex = 18;
            this.btn_busd.UseVisualStyleBackColor = true;
            this.btn_busd.Click += new System.EventHandler(this.btn_busd_Click);
            // 
            // frmBuscardeuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 330);
            this.Controls.Add(this.txt_deuda);
            this.Controls.Add(this.btn_acpt);
            this.Controls.Add(this.dgv_deuda);
            this.Controls.Add(this.btn_busd);
            this.Controls.Add(this.label3);
            this.Name = "frmBuscardeuda";
            this.Text = "frmBuscardeuda";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_deuda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_deuda;
        private System.Windows.Forms.Button btn_acpt;
        private System.Windows.Forms.DataGridView dgv_deuda;
        private System.Windows.Forms.Button btn_busd;
        private System.Windows.Forms.Label label3;
    }
}