namespace cuentas_corrientes
{
    partial class frmFormaDePago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFormaDePago));
            this.dgv_tipopago = new System.Windows.Forms.DataGridView();
            this.txt_dir = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_buscprod = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tipopago)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_tipopago
            // 
            this.dgv_tipopago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tipopago.Location = new System.Drawing.Point(61, 166);
            this.dgv_tipopago.Name = "dgv_tipopago";
            this.dgv_tipopago.Size = new System.Drawing.Size(401, 150);
            this.dgv_tipopago.TabIndex = 17;
            // 
            // txt_dir
            // 
            this.txt_dir.Location = new System.Drawing.Point(179, 116);
            this.txt_dir.Name = "txt_dir";
            this.txt_dir.Size = new System.Drawing.Size(283, 20);
            this.txt_dir.TabIndex = 15;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(179, 80);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(283, 20);
            this.txt_nombre.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "Descripción:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tipo de Pago:";
            // 
            // btn_buscprod
            // 
            this.btn_buscprod.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_buscprod.BackgroundImage")));
            this.btn_buscprod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscprod.Location = new System.Drawing.Point(468, 113);
            this.btn_buscprod.Name = "btn_buscprod";
            this.btn_buscprod.Size = new System.Drawing.Size(34, 36);
            this.btn_buscprod.TabIndex = 18;
            this.btn_buscprod.UseVisualStyleBackColor = true;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_eliminar.BackgroundImage")));
            this.btn_eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_eliminar.Location = new System.Drawing.Point(233, 12);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(60, 60);
            this.btn_eliminar.TabIndex = 21;
            this.btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_modificar
            // 
            this.btn_modificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_modificar.BackgroundImage")));
            this.btn_modificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_modificar.Location = new System.Drawing.Point(334, 12);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(60, 60);
            this.btn_modificar.TabIndex = 20;
            this.btn_modificar.UseVisualStyleBackColor = true;
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_guardar.BackgroundImage")));
            this.btn_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_guardar.Location = new System.Drawing.Point(430, 12);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(60, 60);
            this.btn_guardar.TabIndex = 19;
            this.btn_guardar.UseVisualStyleBackColor = true;
            // 
            // frmFormaDePago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(541, 358);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_buscprod);
            this.Controls.Add(this.dgv_tipopago);
            this.Controls.Add(this.txt_dir);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFormaDePago";
            this.Text = "Forma De Pago";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tipopago)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_tipopago;
        private System.Windows.Forms.TextBox txt_dir;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_buscprod;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_guardar;
    }
}