namespace Graf1
{
    partial class frm_menu
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
            this.btn_graba = new System.Windows.Forms.Button();
            this.btn_grahori = new System.Windows.Forms.Button();
            this.btn_pie = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_graba
            // 
            this.btn_graba.Location = new System.Drawing.Point(114, 62);
            this.btn_graba.Name = "btn_graba";
            this.btn_graba.Size = new System.Drawing.Size(132, 23);
            this.btn_graba.TabIndex = 0;
            this.btn_graba.Text = "Grafica barras";
            this.btn_graba.UseVisualStyleBackColor = true;
            this.btn_graba.Click += new System.EventHandler(this.btn_graba_Click);
            // 
            // btn_grahori
            // 
            this.btn_grahori.Location = new System.Drawing.Point(114, 91);
            this.btn_grahori.Name = "btn_grahori";
            this.btn_grahori.Size = new System.Drawing.Size(132, 23);
            this.btn_grahori.TabIndex = 1;
            this.btn_grahori.Text = "Grafica Horizontal";
            this.btn_grahori.UseVisualStyleBackColor = true;
            this.btn_grahori.Click += new System.EventHandler(this.btn_grahori_Click);
            // 
            // btn_pie
            // 
            this.btn_pie.AccessibleName = "";
            this.btn_pie.Location = new System.Drawing.Point(114, 120);
            this.btn_pie.Name = "btn_pie";
            this.btn_pie.Size = new System.Drawing.Size(132, 23);
            this.btn_pie.TabIndex = 2;
            this.btn_pie.Text = "Grafica Pie";
            this.btn_pie.UseVisualStyleBackColor = true;
            this.btn_pie.Click += new System.EventHandler(this.btn_pie_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 50);
            this.label1.TabIndex = 3;
            this.label1.Text = "SELECCIONE UNA GRAFICA";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frm_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(391, 163);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_pie);
            this.Controls.Add(this.btn_grahori);
            this.Controls.Add(this.btn_graba);
            this.Name = "frm_menu";
            this.Text = "Menu Graficas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_graba;
        private System.Windows.Forms.Button btn_grahori;
        private System.Windows.Forms.Button btn_pie;
        private System.Windows.Forms.Label label1;
    }
}