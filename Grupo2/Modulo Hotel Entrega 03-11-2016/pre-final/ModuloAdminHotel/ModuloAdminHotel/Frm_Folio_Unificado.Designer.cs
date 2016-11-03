namespace ModuloAdminHotel
{
    partial class Frm_Folio_Unificado
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
            this.components = new System.ComponentModel.Container();
            this.dgv_folio_unificado = new System.Windows.Forms.DataGridView();
            this.label17 = new System.Windows.Forms.Label();
            this.btn_actualizarr = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_buscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_folio_unificado)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_folio_unificado
            // 
            this.dgv_folio_unificado.AllowUserToDeleteRows = false;
            this.dgv_folio_unificado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_folio_unificado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_folio_unificado.Location = new System.Drawing.Point(12, 106);
            this.dgv_folio_unificado.Name = "dgv_folio_unificado";
            this.dgv_folio_unificado.ReadOnly = true;
            this.dgv_folio_unificado.Size = new System.Drawing.Size(940, 385);
            this.dgv_folio_unificado.TabIndex = 0;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(309, 9);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(371, 32);
            this.label17.TabIndex = 14;
            this.label17.Text = "Informacion Folio Unificado";
            // 
            // btn_actualizarr
            // 
            this.btn_actualizarr.BackgroundImage = global::ModuloAdminHotel.Properties.Resources.actualizar;
            this.btn_actualizarr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_actualizarr.FlatAppearance.BorderSize = 0;
            this.btn_actualizarr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_actualizarr.Location = new System.Drawing.Point(877, 21);
            this.btn_actualizarr.Margin = new System.Windows.Forms.Padding(0);
            this.btn_actualizarr.Name = "btn_actualizarr";
            this.btn_actualizarr.Size = new System.Drawing.Size(65, 65);
            this.btn_actualizarr.TabIndex = 15;
            this.toolTip1.SetToolTip(this.btn_actualizarr, "Actualizar");
            this.btn_actualizarr.UseVisualStyleBackColor = true;
            this.btn_actualizarr.Click += new System.EventHandler(this.btn_actualizarr_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackgroundImage = global::ModuloAdminHotel.Properties.Resources.buscar;
            this.btn_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscar.FlatAppearance.BorderSize = 0;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.Location = new System.Drawing.Point(798, 21);
            this.btn_buscar.Margin = new System.Windows.Forms.Padding(0);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(65, 65);
            this.btn_buscar.TabIndex = 16;
            this.toolTip1.SetToolTip(this.btn_buscar, "Buscar");
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // Frm_Folio_Unificado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(964, 575);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.btn_actualizarr);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.dgv_folio_unificado);
            this.Name = "Frm_Folio_Unificado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Folio_Unificado";
            this.Load += new System.EventHandler(this.Frm_Folio_Unificado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_folio_unificado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_folio_unificado;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btn_actualizarr;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btn_buscar;
    }
}