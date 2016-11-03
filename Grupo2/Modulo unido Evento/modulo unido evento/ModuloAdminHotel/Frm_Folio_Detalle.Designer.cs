namespace ModuloAdminHotel
{
    partial class Frm_Folio_Detalle
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
            this.dgv_detallefolio = new System.Windows.Forms.DataGridView();
            this.label17 = new System.Windows.Forms.Label();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_buscar_detalle = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detallefolio)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_detallefolio
            // 
            this.dgv_detallefolio.AllowUserToAddRows = false;
            this.dgv_detallefolio.AllowUserToDeleteRows = false;
            this.dgv_detallefolio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_detallefolio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_detallefolio.Location = new System.Drawing.Point(6, 136);
            this.dgv_detallefolio.Name = "dgv_detallefolio";
            this.dgv_detallefolio.ReadOnly = true;
            this.dgv_detallefolio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_detallefolio.Size = new System.Drawing.Size(948, 432);
            this.dgv_detallefolio.TabIndex = 0;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(259, 9);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(418, 32);
            this.label17.TabIndex = 14;
            this.label17.Text = "INFORMACION FOLIO HUESPED";
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackgroundImage = global::ModuloAdminHotel.Properties.Resources.buscar;
            this.btn_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscar.FlatAppearance.BorderSize = 0;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.Location = new System.Drawing.Point(650, 56);
            this.btn_buscar.Margin = new System.Windows.Forms.Padding(0);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(65, 65);
            this.btn_buscar.TabIndex = 15;
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(261, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 21);
            this.label2.TabIndex = 118;
            this.label2.Text = "Buscar: ";
            // 
            // txt_buscar_detalle
            // 
            this.txt_buscar_detalle.Location = new System.Drawing.Point(336, 79);
            this.txt_buscar_detalle.Name = "txt_buscar_detalle";
            this.txt_buscar_detalle.Size = new System.Drawing.Size(281, 20);
            this.txt_buscar_detalle.TabIndex = 117;
            // 
            // Frm_Folio_Detalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.ClientSize = new System.Drawing.Size(963, 576);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_buscar_detalle);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.dgv_detallefolio);
            this.Name = "Frm_Folio_Detalle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Folio_Detalle";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detallefolio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_detallefolio;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_buscar_detalle;
    }
}