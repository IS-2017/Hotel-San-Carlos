﻿namespace cuentas_corrientes
{
    partial class frmDescontando
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
            this.cbo_bodega = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_descontar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbo_bodega
            // 
            this.cbo_bodega.FormattingEnabled = true;
            this.cbo_bodega.Location = new System.Drawing.Point(203, 90);
            this.cbo_bodega.Name = "cbo_bodega";
            this.cbo_bodega.Size = new System.Drawing.Size(121, 21);
            this.cbo_bodega.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bodegas con existencia:";
            // 
            // btn_descontar
            // 
            this.btn_descontar.Location = new System.Drawing.Point(223, 156);
            this.btn_descontar.Name = "btn_descontar";
            this.btn_descontar.Size = new System.Drawing.Size(75, 23);
            this.btn_descontar.TabIndex = 2;
            this.btn_descontar.Text = "Descontar";
            this.btn_descontar.UseVisualStyleBackColor = true;
            this.btn_descontar.Click += new System.EventHandler(this.btn_descontar_Click);
            // 
            // frmDescontando
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 220);
            this.Controls.Add(this.btn_descontar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbo_bodega);
            this.Name = "frmDescontando";
            this.Text = "frmDescontando";
            this.Load += new System.EventHandler(this.frmDescontando_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo_bodega;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_descontar;
    }
}