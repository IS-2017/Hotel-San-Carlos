namespace cuentas_corrientes
{
    partial class frmListadoPrecio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListadoPrecio));
            this.txt_bien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_buscbirn = new System.Windows.Forms.Button();
            this.dgv_listadoprecio = new System.Windows.Forms.DataGridView();
            this.cbo_tipoprec = new System.Windows.Forms.ComboBox();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listadoprecio)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_bien
            // 
            this.txt_bien.Location = new System.Drawing.Point(115, 89);
            this.txt_bien.Name = "txt_bien";
            this.txt_bien.Size = new System.Drawing.Size(359, 20);
            this.txt_bien.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tipo de Precio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bien:";
            // 
            // btn_buscbirn
            // 
            this.btn_buscbirn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_buscbirn.BackgroundImage")));
            this.btn_buscbirn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscbirn.Location = new System.Drawing.Point(485, 90);
            this.btn_buscbirn.Name = "btn_buscbirn";
            this.btn_buscbirn.Size = new System.Drawing.Size(29, 23);
            this.btn_buscbirn.TabIndex = 8;
            this.btn_buscbirn.UseVisualStyleBackColor = true;
            this.btn_buscbirn.Click += new System.EventHandler(this.btn_Buscte_Click);
            // 
            // dgv_listadoprecio
            // 
            this.dgv_listadoprecio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listadoprecio.Location = new System.Drawing.Point(43, 176);
            this.dgv_listadoprecio.Name = "dgv_listadoprecio";
            this.dgv_listadoprecio.Size = new System.Drawing.Size(484, 150);
            this.dgv_listadoprecio.TabIndex = 9;
            // 
            // cbo_tipoprec
            // 
            this.cbo_tipoprec.FormattingEnabled = true;
            this.cbo_tipoprec.Location = new System.Drawing.Point(192, 116);
            this.cbo_tipoprec.Name = "cbo_tipoprec";
            this.cbo_tipoprec.Size = new System.Drawing.Size(282, 21);
            this.cbo_tipoprec.TabIndex = 10;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_eliminar.BackgroundImage")));
            this.btn_eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_eliminar.Location = new System.Drawing.Point(252, 12);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(60, 60);
            this.btn_eliminar.TabIndex = 20;
            this.btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_modificar
            // 
            this.btn_modificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_modificar.BackgroundImage")));
            this.btn_modificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_modificar.Location = new System.Drawing.Point(353, 12);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(60, 60);
            this.btn_modificar.TabIndex = 19;
            this.btn_modificar.UseVisualStyleBackColor = true;
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_guardar.BackgroundImage")));
            this.btn_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_guardar.Location = new System.Drawing.Point(449, 12);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(60, 60);
            this.btn_guardar.TabIndex = 18;
            this.btn_guardar.UseVisualStyleBackColor = true;
            // 
            // frmListadoPrecio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(568, 399);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.cbo_tipoprec);
            this.Controls.Add(this.dgv_listadoprecio);
            this.Controls.Add(this.btn_buscbirn);
            this.Controls.Add(this.txt_bien);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListadoPrecio";
            this.Text = "Listado de Precios";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listadoprecio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_bien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_buscbirn;
        private System.Windows.Forms.DataGridView dgv_listadoprecio;
        private System.Windows.Forms.ComboBox cbo_tipoprec;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_guardar;
    }
}