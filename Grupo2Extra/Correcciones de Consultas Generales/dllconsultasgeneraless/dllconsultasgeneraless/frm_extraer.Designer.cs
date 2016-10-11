namespace dllconsultasgeneraless
{
    partial class frm_extraer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_extraer));
            this.lbl_consulta = new System.Windows.Forms.Label();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.dgv_consultasAlmacenadas = new System.Windows.Forms.DataGridView();
            this.btn_extraer = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_Regresar = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_consultasAlmacenadas)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_consulta
            // 
            this.lbl_consulta.AutoSize = true;
            this.lbl_consulta.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_consulta.Location = new System.Drawing.Point(103, 50);
            this.lbl_consulta.Name = "lbl_consulta";
            this.lbl_consulta.Size = new System.Drawing.Size(65, 18);
            this.lbl_consulta.TabIndex = 8;
            this.lbl_consulta.Text = "FILTRAR:";
            // 
            // txt_buscar
            // 
            this.txt_buscar.Location = new System.Drawing.Point(179, 47);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(373, 20);
            this.txt_buscar.TabIndex = 7;
            // 
            // dgv_consultasAlmacenadas
            // 
            this.dgv_consultasAlmacenadas.AllowUserToAddRows = false;
            this.dgv_consultasAlmacenadas.AllowUserToDeleteRows = false;
            this.dgv_consultasAlmacenadas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_consultasAlmacenadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_consultasAlmacenadas.Location = new System.Drawing.Point(14, 85);
            this.dgv_consultasAlmacenadas.Name = "dgv_consultasAlmacenadas";
            this.dgv_consultasAlmacenadas.ReadOnly = true;
            this.dgv_consultasAlmacenadas.Size = new System.Drawing.Size(811, 312);
            this.dgv_consultasAlmacenadas.TabIndex = 6;
            this.dgv_consultasAlmacenadas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_consultasAlmacenadas_CellContentClick);
            // 
            // btn_extraer
            // 
            this.btn_extraer.BackgroundImage = global::dllconsultasgeneraless.Properties.Resources.play;
            this.btn_extraer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_extraer.FlatAppearance.BorderSize = 0;
            this.btn_extraer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_extraer.Location = new System.Drawing.Point(671, 12);
            this.btn_extraer.Name = "btn_extraer";
            this.btn_extraer.Size = new System.Drawing.Size(63, 56);
            this.btn_extraer.TabIndex = 10;
            this.btn_extraer.UseVisualStyleBackColor = true;
            this.btn_extraer.Click += new System.EventHandler(this.btn_extraer_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackgroundImage = global::dllconsultasgeneraless.Properties.Resources.Document_Preview_icon;
            this.btn_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscar.FlatAppearance.BorderSize = 0;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.Location = new System.Drawing.Point(569, 13);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 55);
            this.btn_buscar.TabIndex = 9;
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // btn_Regresar
            // 
            this.btn_Regresar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Regresar.BackgroundImage")));
            this.btn_Regresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Regresar.FlatAppearance.BorderSize = 0;
            this.btn_Regresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Regresar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Regresar.Location = new System.Drawing.Point(14, 13);
            this.btn_Regresar.Name = "btn_Regresar";
            this.btn_Regresar.Size = new System.Drawing.Size(55, 55);
            this.btn_Regresar.TabIndex = 70;
            this.btn_Regresar.UseVisualStyleBackColor = true;
            this.btn_Regresar.Click += new System.EventHandler(this.btn_Regresar_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.BackgroundImage = global::dllconsultasgeneraless.Properties.Resources.Button_Close_icon;
            this.btn_limpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_limpiar.FlatAppearance.BorderSize = 0;
            this.btn_limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpiar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar.Location = new System.Drawing.Point(750, 13);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(75, 55);
            this.btn_limpiar.TabIndex = 78;
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // frm_extraer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(841, 414);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_Regresar);
            this.Controls.Add(this.btn_extraer);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.lbl_consulta);
            this.Controls.Add(this.txt_buscar);
            this.Controls.Add(this.dgv_consultasAlmacenadas);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frm_extraer";
            this.Text = "frm_extraer";
            this.Load += new System.EventHandler(this.frm_extraer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_consultasAlmacenadas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_extraer;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Label lbl_consulta;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.DataGridView dgv_consultasAlmacenadas;
        private System.Windows.Forms.Button btn_Regresar;
        private System.Windows.Forms.Button btn_limpiar;
    }
}