namespace ObjetoComunConsultasInteligentes
{
    partial class cargaConsulta
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
            this.dgv_consultasAlmacenadas = new System.Windows.Forms.DataGridView();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.lbl_consulta = new System.Windows.Forms.Label();
            this.btn_limpiartexto = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_extraer = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_consultasAlmacenadas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_consultasAlmacenadas
            // 
            this.dgv_consultasAlmacenadas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_consultasAlmacenadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_consultasAlmacenadas.Location = new System.Drawing.Point(3, 84);
            this.dgv_consultasAlmacenadas.Name = "dgv_consultasAlmacenadas";
            this.dgv_consultasAlmacenadas.Size = new System.Drawing.Size(764, 312);
            this.dgv_consultasAlmacenadas.TabIndex = 0;
            // 
            // txt_buscar
            // 
            this.txt_buscar.Location = new System.Drawing.Point(77, 37);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(320, 20);
            this.txt_buscar.TabIndex = 1;
            // 
            // lbl_consulta
            // 
            this.lbl_consulta.AutoSize = true;
            this.lbl_consulta.Location = new System.Drawing.Point(12, 40);
            this.lbl_consulta.Name = "lbl_consulta";
            this.lbl_consulta.Size = new System.Drawing.Size(55, 13);
            this.lbl_consulta.TabIndex = 2;
            this.lbl_consulta.Text = "FILTRAR:";
            // 
            // btn_limpiartexto
            // 
            this.btn_limpiartexto.FlatAppearance.BorderSize = 0;
            this.btn_limpiartexto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpiartexto.Location = new System.Drawing.Point(370, 37);
            this.btn_limpiartexto.Name = "btn_limpiartexto";
            this.btn_limpiartexto.Size = new System.Drawing.Size(27, 22);
            this.btn_limpiartexto.TabIndex = 5;
            this.btn_limpiartexto.Text = "x";
            this.toolTip1.SetToolTip(this.btn_limpiartexto, "Limpiar");
            this.btn_limpiartexto.UseVisualStyleBackColor = true;
            this.btn_limpiartexto.Click += new System.EventHandler(this.btn_limpiartexto_Click);
            // 
            // btn_extraer
            // 
            this.btn_extraer.BackgroundImage = global::ObjetoComunConsultasInteligentes.Properties.Resources.Button_Refresh_icon;
            this.btn_extraer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_extraer.FlatAppearance.BorderSize = 0;
            this.btn_extraer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_extraer.Location = new System.Drawing.Point(566, 12);
            this.btn_extraer.Name = "btn_extraer";
            this.btn_extraer.Size = new System.Drawing.Size(75, 55);
            this.btn_extraer.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btn_extraer, "Extraer Consulta");
            this.btn_extraer.UseVisualStyleBackColor = true;
            this.btn_extraer.Click += new System.EventHandler(this.btn_extraer_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackgroundImage = global::ObjetoComunConsultasInteligentes.Properties.Resources.Document_Preview_icon;
            this.btn_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscar.FlatAppearance.BorderSize = 0;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.Location = new System.Drawing.Point(467, 12);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 55);
            this.btn_buscar.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btn_buscar, "Buscar");
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // cargaConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 408);
            this.Controls.Add(this.btn_limpiartexto);
            this.Controls.Add(this.btn_extraer);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.lbl_consulta);
            this.Controls.Add(this.txt_buscar);
            this.Controls.Add(this.dgv_consultasAlmacenadas);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "cargaConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.cargaConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_consultasAlmacenadas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_consultasAlmacenadas;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Label lbl_consulta;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_extraer;
        private System.Windows.Forms.Button btn_limpiartexto;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}