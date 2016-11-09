namespace Prototipo__RRHH
{
    partial class Frm_Reporte_Nomina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Reporte_Nomina));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dtp_fecha_inicio_repor = new System.Windows.Forms.DateTimePicker();
            this.dtp_fecha_fin_repor = new System.Windows.Forms.DateTimePicker();
            this.cbo_empresa_rep = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_dtp_fecha_inicio_repor = new System.Windows.Forms.TextBox();
            this.txt_dtp_fecha_fin_repor = new System.Windows.Forms.TextBox();
            this.txt_cbo_empresa_rep = new System.Windows.Forms.TextBox();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(868, 129);
            this.dataGridView1.TabIndex = 0;
            // 
            // dtp_fecha_inicio_repor
            // 
            this.dtp_fecha_inicio_repor.Location = new System.Drawing.Point(104, 55);
            this.dtp_fecha_inicio_repor.Name = "dtp_fecha_inicio_repor";
            this.dtp_fecha_inicio_repor.Size = new System.Drawing.Size(200, 20);
            this.dtp_fecha_inicio_repor.TabIndex = 1;
            // 
            // dtp_fecha_fin_repor
            // 
            this.dtp_fecha_fin_repor.Location = new System.Drawing.Point(364, 55);
            this.dtp_fecha_fin_repor.Name = "dtp_fecha_fin_repor";
            this.dtp_fecha_fin_repor.Size = new System.Drawing.Size(200, 20);
            this.dtp_fecha_fin_repor.TabIndex = 2;
            // 
            // cbo_empresa_rep
            // 
            this.cbo_empresa_rep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_empresa_rep.FormattingEnabled = true;
            this.cbo_empresa_rep.Location = new System.Drawing.Point(615, 54);
            this.cbo_empresa_rep.Name = "cbo_empresa_rep";
            this.cbo_empresa_rep.Size = new System.Drawing.Size(121, 21);
            this.cbo_empresa_rep.TabIndex = 3;
            this.cbo_empresa_rep.SelectedIndexChanged += new System.EventHandler(this.cbo_empresa_rep_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(816, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 41);
            this.button1.TabIndex = 4;
            this.button1.Text = "Generar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Fecha de Inicio para Reporte:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(361, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fecha de Fin para Reporte:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(612, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Empresa:";
            // 
            // txt_dtp_fecha_inicio_repor
            // 
            this.txt_dtp_fecha_inicio_repor.Location = new System.Drawing.Point(310, 55);
            this.txt_dtp_fecha_inicio_repor.Name = "txt_dtp_fecha_inicio_repor";
            this.txt_dtp_fecha_inicio_repor.Size = new System.Drawing.Size(10, 20);
            this.txt_dtp_fecha_inicio_repor.TabIndex = 8;
            this.txt_dtp_fecha_inicio_repor.Visible = false;
            // 
            // txt_dtp_fecha_fin_repor
            // 
            this.txt_dtp_fecha_fin_repor.Location = new System.Drawing.Point(570, 55);
            this.txt_dtp_fecha_fin_repor.Name = "txt_dtp_fecha_fin_repor";
            this.txt_dtp_fecha_fin_repor.Size = new System.Drawing.Size(11, 20);
            this.txt_dtp_fecha_fin_repor.TabIndex = 9;
            this.txt_dtp_fecha_fin_repor.Visible = false;
            // 
            // txt_cbo_empresa_rep
            // 
            this.txt_cbo_empresa_rep.Location = new System.Drawing.Point(742, 55);
            this.txt_cbo_empresa_rep.Name = "txt_cbo_empresa_rep";
            this.txt_cbo_empresa_rep.Size = new System.Drawing.Size(10, 20);
            this.txt_cbo_empresa_rep.TabIndex = 10;
            this.txt_cbo_empresa_rep.Visible = false;
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_actualizar.BackgroundImage")));
            this.btn_actualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_actualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_actualizar.FlatAppearance.BorderSize = 0;
            this.btn_actualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_actualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_actualizar.Location = new System.Drawing.Point(805, 10);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(65, 65);
            this.btn_actualizar.TabIndex = 11;
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(12, 81);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(931, 304);
            this.crystalReportViewer1.TabIndex = 12;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // Frm_Reporte_Nomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.ClientSize = new System.Drawing.Size(953, 439);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.btn_actualizar);
            this.Controls.Add(this.txt_cbo_empresa_rep);
            this.Controls.Add(this.txt_dtp_fecha_fin_repor);
            this.Controls.Add(this.txt_dtp_fecha_inicio_repor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbo_empresa_rep);
            this.Controls.Add(this.dtp_fecha_fin_repor);
            this.Controls.Add(this.dtp_fecha_inicio_repor);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_Reporte_Nomina";
            this.Text = "Reporte Nomina";
            this.Load += new System.EventHandler(this.Frm_Reporte_Nomina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dtp_fecha_inicio_repor;
        private System.Windows.Forms.DateTimePicker dtp_fecha_fin_repor;
        private System.Windows.Forms.ComboBox cbo_empresa_rep;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_dtp_fecha_inicio_repor;
        private System.Windows.Forms.TextBox txt_dtp_fecha_fin_repor;
        private System.Windows.Forms.TextBox txt_cbo_empresa_rep;
        private System.Windows.Forms.Button btn_actualizar;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
    }
}