namespace Prototipo__RRHH
{
    partial class frm_Empleados_grid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Empleados_grid));
            this.lbl_form_emp = new System.Windows.Forms.Label();
            this.dgv_lista_emps = new System.Windows.Forms.DataGridView();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.lbl_busca_emp = new System.Windows.Forms.Label();
            this.gpb_lista_emps = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lista_emps)).BeginInit();
            this.gpb_lista_emps.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_form_emp
            // 
            this.lbl_form_emp.AutoSize = true;
            this.lbl_form_emp.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_form_emp.Location = new System.Drawing.Point(471, 9);
            this.lbl_form_emp.Name = "lbl_form_emp";
            this.lbl_form_emp.Size = new System.Drawing.Size(265, 32);
            this.lbl_form_emp.TabIndex = 170;
            this.lbl_form_emp.Text = "Lista de Empleados";
            // 
            // dgv_lista_emps
            // 
            this.dgv_lista_emps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_lista_emps.Location = new System.Drawing.Point(6, 62);
            this.dgv_lista_emps.Name = "dgv_lista_emps";
            this.dgv_lista_emps.Size = new System.Drawing.Size(1151, 358);
            this.dgv_lista_emps.TabIndex = 174;
            this.dgv_lista_emps.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_lista_emps_CellContentClick);
            this.dgv_lista_emps.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_lista_emps_CellDoubleClick);
            // 
            // txt_buscar
            // 
            this.txt_buscar.Location = new System.Drawing.Point(534, 14);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(304, 26);
            this.txt_buscar.TabIndex = 176;
            this.txt_buscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_buscar_KeyUp);
            // 
            // lbl_busca_emp
            // 
            this.lbl_busca_emp.AutoSize = true;
            this.lbl_busca_emp.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_busca_emp.Location = new System.Drawing.Point(298, 17);
            this.lbl_busca_emp.Name = "lbl_busca_emp";
            this.lbl_busca_emp.Size = new System.Drawing.Size(230, 20);
            this.lbl_busca_emp.TabIndex = 175;
            this.lbl_busca_emp.Text = "Buscar Nombre del Empleado:";
            // 
            // gpb_lista_emps
            // 
            this.gpb_lista_emps.Controls.Add(this.txt_buscar);
            this.gpb_lista_emps.Controls.Add(this.dgv_lista_emps);
            this.gpb_lista_emps.Controls.Add(this.lbl_busca_emp);
            this.gpb_lista_emps.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_lista_emps.Location = new System.Drawing.Point(12, 53);
            this.gpb_lista_emps.Name = "gpb_lista_emps";
            this.gpb_lista_emps.Size = new System.Drawing.Size(1163, 426);
            this.gpb_lista_emps.TabIndex = 177;
            this.gpb_lista_emps.TabStop = false;
            this.gpb_lista_emps.Text = "Empleados";
            // 
            // frm_Empleados_grid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.ClientSize = new System.Drawing.Size(1187, 491);
            this.Controls.Add(this.gpb_lista_emps);
            this.Controls.Add(this.lbl_form_emp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Empleados_grid";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empleados";
            this.Load += new System.EventHandler(this.frm_Empleados_grid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lista_emps)).EndInit();
            this.gpb_lista_emps.ResumeLayout(false);
            this.gpb_lista_emps.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_form_emp;
        private System.Windows.Forms.DataGridView dgv_lista_emps;
        private System.Windows.Forms.TextBox txt_buscar;
        internal System.Windows.Forms.Label lbl_busca_emp;
        private System.Windows.Forms.GroupBox gpb_lista_emps;
    }
}