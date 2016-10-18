namespace cuentas_corrientes
{
    partial class frmBuscarFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscarFactura));
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_detallefact = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.cbo_serie = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_buscbirn = new System.Windows.Forms.Button();
            this.txt_bien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detallefact)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_eliminar.BackgroundImage")));
            this.btn_eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_eliminar.Location = new System.Drawing.Point(116, 6);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(60, 60);
            this.btn_eliminar.TabIndex = 43;
            this.btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_modificar
            // 
            this.btn_modificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_modificar.BackgroundImage")));
            this.btn_modificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_modificar.Location = new System.Drawing.Point(217, 6);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(60, 60);
            this.btn_modificar.TabIndex = 42;
            this.btn_modificar.UseVisualStyleBackColor = true;
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_guardar.BackgroundImage")));
            this.btn_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_guardar.Location = new System.Drawing.Point(313, 6);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(60, 60);
            this.btn_guardar.TabIndex = 41;
            this.btn_guardar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(97, 116);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(130, 20);
            this.textBox1.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 21);
            this.label3.TabIndex = 39;
            this.label3.Text = "Fecha:";
            // 
            // dgv_detallefact
            // 
            this.dgv_detallefact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_detallefact.Location = new System.Drawing.Point(28, 203);
            this.dgv_detallefact.Name = "dgv_detallefact";
            this.dgv_detallefact.Size = new System.Drawing.Size(451, 169);
            this.dgv_detallefact.TabIndex = 38;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(33, 183);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 17);
            this.label10.TabIndex = 37;
            this.label10.Text = "Detalle Factura";
            // 
            // cbo_serie
            // 
            this.cbo_serie.FormattingEnabled = true;
            this.cbo_serie.Location = new System.Drawing.Point(80, 148);
            this.cbo_serie.Name = "cbo_serie";
            this.cbo_serie.Size = new System.Drawing.Size(103, 21);
            this.cbo_serie.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 21);
            this.label1.TabIndex = 35;
            this.label1.Text = "Serie:";
            // 
            // btn_buscbirn
            // 
            this.btn_buscbirn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_buscbirn.BackgroundImage")));
            this.btn_buscbirn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscbirn.Location = new System.Drawing.Point(516, 79);
            this.btn_buscbirn.Name = "btn_buscbirn";
            this.btn_buscbirn.Size = new System.Drawing.Size(29, 23);
            this.btn_buscbirn.TabIndex = 34;
            this.btn_buscbirn.UseVisualStyleBackColor = true;
            // 
            // txt_bien
            // 
            this.txt_bien.Location = new System.Drawing.Point(146, 78);
            this.txt_bien.Name = "txt_bien";
            this.txt_bien.Size = new System.Drawing.Size(359, 20);
            this.txt_bien.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 21);
            this.label2.TabIndex = 32;
            this.label2.Text = "Numero Doc.";
            // 
            // frmBuscarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(679, 384);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv_detallefact);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbo_serie);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_buscbirn);
            this.Controls.Add(this.txt_bien);
            this.Controls.Add(this.label2);
            this.Name = "frmBuscarFactura";
            this.Text = "frmBuscarFactura";
            this.Load += new System.EventHandler(this.frmBuscarFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detallefact)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_detallefact;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbo_serie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_buscbirn;
        private System.Windows.Forms.TextBox txt_bien;
        private System.Windows.Forms.Label label2;
    }
}