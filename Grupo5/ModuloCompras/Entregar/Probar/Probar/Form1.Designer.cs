namespace Probar
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Reporte = new System.Windows.Forms.Button();
            this.btn_Reporte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-3, 219);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(532, 213);
            this.dataGridView1.TabIndex = 0;
            // 
            // Reporte
            // 
            this.Reporte.Location = new System.Drawing.Point(427, 156);
            this.Reporte.Name = "Reporte";
            this.Reporte.Size = new System.Drawing.Size(75, 38);
            this.Reporte.TabIndex = 1;
            this.Reporte.Text = "Imprimir";
            this.Reporte.UseVisualStyleBackColor = true;
            this.Reporte.Click += new System.EventHandler(this.Reporte_Click_1);
            // 
            // btn_Reporte
            // 
            this.btn_Reporte.Location = new System.Drawing.Point(277, 36);
            this.btn_Reporte.Name = "btn_Reporte";
            this.btn_Reporte.Size = new System.Drawing.Size(107, 35);
            this.btn_Reporte.TabIndex = 2;
            this.btn_Reporte.Text = "Reporteador";
            this.btn_Reporte.UseVisualStyleBackColor = true;
            this.btn_Reporte.Click += new System.EventHandler(this.btn_Reporte_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 444);
            this.Controls.Add(this.btn_Reporte);
            this.Controls.Add(this.Reporte);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Reporte;
        private System.Windows.Forms.Button btn_Reporte;
    }
}

