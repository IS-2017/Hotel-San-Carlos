﻿namespace dllconsultas
{
    partial class frm_almacenadas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_almacenadas));
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.lbl_Buscar = new System.Windows.Forms.Label();
            this.btn_Regresar = new System.Windows.Forms.Button();
            this.btn_ejecutar = new System.Windows.Forms.Button();
            this.dgv_Almacenadas = new System.Windows.Forms.DataGridView();
            this.btn_buscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Almacenadas)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_buscar
            // 
            this.txt_buscar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_buscar.Location = new System.Drawing.Point(201, 53);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(243, 26);
            this.txt_buscar.TabIndex = 71;
            // 
            // lbl_Buscar
            // 
            this.lbl_Buscar.AutoSize = true;
            this.lbl_Buscar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Buscar.Location = new System.Drawing.Point(132, 53);
            this.lbl_Buscar.Name = "lbl_Buscar";
            this.lbl_Buscar.Size = new System.Drawing.Size(62, 20);
            this.lbl_Buscar.TabIndex = 70;
            this.lbl_Buscar.Text = "Buscar:";
            // 
            // btn_Regresar
            // 
            this.btn_Regresar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Regresar.BackgroundImage")));
            this.btn_Regresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Regresar.FlatAppearance.BorderSize = 0;
            this.btn_Regresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Regresar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Regresar.Location = new System.Drawing.Point(12, 18);
            this.btn_Regresar.Name = "btn_Regresar";
            this.btn_Regresar.Size = new System.Drawing.Size(55, 55);
            this.btn_Regresar.TabIndex = 69;
            this.btn_Regresar.UseVisualStyleBackColor = true;
            this.btn_Regresar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_ejecutar
            // 
            this.btn_ejecutar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ejecutar.BackgroundImage")));
            this.btn_ejecutar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ejecutar.FlatAppearance.BorderSize = 0;
            this.btn_ejecutar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ejecutar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ejecutar.Location = new System.Drawing.Point(236, 348);
            this.btn_ejecutar.Name = "btn_ejecutar";
            this.btn_ejecutar.Size = new System.Drawing.Size(81, 54);
            this.btn_ejecutar.TabIndex = 68;
            this.btn_ejecutar.UseVisualStyleBackColor = true;
            this.btn_ejecutar.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgv_Almacenadas
            // 
            this.dgv_Almacenadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Almacenadas.Location = new System.Drawing.Point(23, 95);
            this.dgv_Almacenadas.Name = "dgv_Almacenadas";
            this.dgv_Almacenadas.Size = new System.Drawing.Size(517, 247);
            this.dgv_Almacenadas.TabIndex = 67;
            this.dgv_Almacenadas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_buscar.BackgroundImage")));
            this.btn_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscar.FlatAppearance.BorderSize = 0;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.Location = new System.Drawing.Point(461, 43);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(54, 42);
            this.btn_buscar.TabIndex = 72;
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // frm_almacenadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(566, 403);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.txt_buscar);
            this.Controls.Add(this.lbl_Buscar);
            this.Controls.Add(this.btn_Regresar);
            this.Controls.Add(this.btn_ejecutar);
            this.Controls.Add(this.dgv_Almacenadas);
            this.Name = "frm_almacenadas";
            this.Text = "frm_almacenadas";
            this.Load += new System.EventHandler(this.frm_almacenadas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Almacenadas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Label lbl_Buscar;
        private System.Windows.Forms.Button btn_Regresar;
        private System.Windows.Forms.Button btn_ejecutar;
        private System.Windows.Forms.DataGridView dgv_Almacenadas;
        private System.Windows.Forms.Button btn_buscar;
    }
}