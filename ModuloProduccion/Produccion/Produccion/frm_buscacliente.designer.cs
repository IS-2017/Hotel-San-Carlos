namespace produccion
{
    partial class frm_buscacliente
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_parametro = new System.Windows.Forms.TextBox();
            this.dgv_cte = new System.Windows.Forms.DataGridView();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_regresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cte)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 127);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre o NIT";
            // 
            // txt_parametro
            // 
            this.txt_parametro.Location = new System.Drawing.Point(320, 123);
            this.txt_parametro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_parametro.Name = "txt_parametro";
            this.txt_parametro.Size = new System.Drawing.Size(251, 22);
            this.txt_parametro.TabIndex = 2;
            // 
            // dgv_cte
            // 
            this.dgv_cte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cte.Location = new System.Drawing.Point(61, 185);
            this.dgv_cte.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_cte.Name = "dgv_cte";
            this.dgv_cte.Size = new System.Drawing.Size(701, 144);
            this.dgv_cte.TabIndex = 4;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(353, 27);
            this.btn_buscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(91, 62);
            this.btn_buscar.TabIndex = 5;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(481, 27);
            this.btn_aceptar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(91, 62);
            this.btn_aceptar.TabIndex = 6;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_regresar
            // 
            this.btn_regresar.Location = new System.Drawing.Point(233, 27);
            this.btn_regresar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(91, 62);
            this.btn_regresar.TabIndex = 7;
            this.btn_regresar.Text = "Regresar";
            this.btn_regresar.UseVisualStyleBackColor = true;
            this.btn_regresar.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // frm_buscacliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 367);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.dgv_cte);
            this.Controls.Add(this.txt_parametro);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_buscacliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscador cliente";
            this.Load += new System.EventHandler(this.frm_buscacliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_parametro;
        private System.Windows.Forms.DataGridView dgv_cte;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_regresar;
    }
}