namespace Graf1
{
    partial class frm_grafbarraDiseño
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_grafbarraDiseño));
            this.button1 = new System.Windows.Forms.Button();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_regresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(157, 426);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 50);
            this.button1.TabIndex = 1;
            this.button1.Text = "Guardar Gráfica en Imagen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chart2
            // 
            chartArea1.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart2.Legends.Add(legend1);
            this.chart2.Location = new System.Drawing.Point(77, 32);
            this.chart2.Name = "chart2";
            series1.ChartArea = "ChartArea1";
            series1.IsXValueIndexed = true;
            series1.Label = "#LEGENDTEXT";
            series1.LabelToolTip = "#VALX";
            series1.Legend = "Legend1";
            series1.LegendToolTip = "#LEGENDTEXT";
            series1.Name = "Series1";
            this.chart2.Series.Add(series1);
            this.chart2.Size = new System.Drawing.Size(375, 360);
            this.chart2.TabIndex = 2;
            this.chart2.Text = "chart2";
            this.chart2.Click += new System.EventHandler(this.chart2_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(299, 426);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 50);
            this.button2.TabIndex = 3;
            this.button2.Text = "Guarda en PDF";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(487, 115);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(226, 84);
            this.textBox1.TabIndex = 4;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_eliminar.BackgroundImage")));
            this.btn_eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_eliminar.Location = new System.Drawing.Point(533, 293);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(60, 60);
            this.btn_eliminar.TabIndex = 6;
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(482, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Agregue una breve descripción";
            // 
            // btn_regresar
            // 
            this.btn_regresar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_regresar.BackgroundImage")));
            this.btn_regresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_regresar.Location = new System.Drawing.Point(616, 293);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(60, 60);
            this.btn_regresar.TabIndex = 9;
            this.btn_regresar.UseVisualStyleBackColor = true;
            this.btn_regresar.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // frm_grafbarraDiseño
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(739, 514);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.button1);
            this.Name = "frm_grafbarraDiseño";
            this.Text = "Diseño Grafica Barras";
            this.Load += new System.EventHandler(this.frm_grafbarraDiseño_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_regresar;
    }
}