namespace cuentas_corrientes
{
    partial class frmFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFactura));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_dir = new System.Windows.Forms.TextBox();
            this.txt_nit = new System.Windows.Forms.TextBox();
            this.btn_Buscte = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_subtot = new System.Windows.Forms.TextBox();
            this.dgv_detallefact = new System.Windows.Forms.DataGridView();
            this.btn_buscprod = new System.Windows.Forms.Button();
            this.btn_buscfolio = new System.Windows.Forms.Button();
            this.btn_buscped = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_agregarimp = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_fecemi = new System.Windows.Forms.TextBox();
            this.txt_fecven = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbo_formpago = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_serie = new System.Windows.Forms.ComboBox();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detallefact)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Dirección:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(507, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nit:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(158, 123);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(283, 20);
            this.txt_nombre.TabIndex = 2;
            // 
            // txt_dir
            // 
            this.txt_dir.Location = new System.Drawing.Point(158, 155);
            this.txt_dir.Name = "txt_dir";
            this.txt_dir.Size = new System.Drawing.Size(283, 20);
            this.txt_dir.TabIndex = 2;
            // 
            // txt_nit
            // 
            this.txt_nit.Location = new System.Drawing.Point(551, 122);
            this.txt_nit.Name = "txt_nit";
            this.txt_nit.Size = new System.Drawing.Size(191, 20);
            this.txt_nit.TabIndex = 2;
            // 
            // btn_Buscte
            // 
            this.btn_Buscte.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Buscte.BackgroundImage")));
            this.btn_Buscte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Buscte.Location = new System.Drawing.Point(447, 120);
            this.btn_Buscte.Name = "btn_Buscte";
            this.btn_Buscte.Size = new System.Drawing.Size(29, 23);
            this.btn_Buscte.TabIndex = 3;
            this.btn_Buscte.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 444);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "Subtotal:";
            // 
            // txt_subtot
            // 
            this.txt_subtot.Location = new System.Drawing.Point(121, 444);
            this.txt_subtot.Name = "txt_subtot";
            this.txt_subtot.Size = new System.Drawing.Size(103, 20);
            this.txt_subtot.TabIndex = 2;
            // 
            // dgv_detallefact
            // 
            this.dgv_detallefact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_detallefact.Location = new System.Drawing.Point(38, 256);
            this.dgv_detallefact.Name = "dgv_detallefact";
            this.dgv_detallefact.Size = new System.Drawing.Size(451, 169);
            this.dgv_detallefact.TabIndex = 4;
            this.dgv_detallefact.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_buscprod
            // 
            this.btn_buscprod.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_buscprod.BackgroundImage")));
            this.btn_buscprod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscprod.Location = new System.Drawing.Point(508, 256);
            this.btn_buscprod.Name = "btn_buscprod";
            this.btn_buscprod.Size = new System.Drawing.Size(34, 36);
            this.btn_buscprod.TabIndex = 3;
            this.btn_buscprod.UseVisualStyleBackColor = true;
            // 
            // btn_buscfolio
            // 
            this.btn_buscfolio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_buscfolio.BackgroundImage")));
            this.btn_buscfolio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscfolio.Location = new System.Drawing.Point(508, 298);
            this.btn_buscfolio.Name = "btn_buscfolio";
            this.btn_buscfolio.Size = new System.Drawing.Size(34, 36);
            this.btn_buscfolio.TabIndex = 3;
            this.btn_buscfolio.UseVisualStyleBackColor = true;
            // 
            // btn_buscped
            // 
            this.btn_buscped.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_buscped.BackgroundImage")));
            this.btn_buscped.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscped.Location = new System.Drawing.Point(508, 340);
            this.btn_buscped.Name = "btn_buscped";
            this.btn_buscped.Size = new System.Drawing.Size(34, 36);
            this.btn_buscped.TabIndex = 3;
            this.btn_buscped.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(548, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Buscar Producto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(548, 308);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Buscar Folio";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(548, 350);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Buscar Pedido";
            // 
            // btn_agregarimp
            // 
            this.btn_agregarimp.Location = new System.Drawing.Point(246, 444);
            this.btn_agregarimp.Name = "btn_agregarimp";
            this.btn_agregarimp.Size = new System.Drawing.Size(104, 23);
            this.btn_agregarimp.TabIndex = 5;
            this.btn_agregarimp.Text = "Agregar Impuesto";
            this.btn_agregarimp.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(34, 488);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 21);
            this.label9.TabIndex = 1;
            this.label9.Text = "Total:";
            // 
            // txt_total
            // 
            this.txt_total.Location = new System.Drawing.Point(121, 488);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(103, 20);
            this.txt_total.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(43, 236);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 17);
            this.label10.TabIndex = 1;
            this.label10.Text = "Detalle Factura";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(65, 187);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(165, 21);
            this.label11.TabIndex = 1;
            this.label11.Text = "Fecha vencimiento:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(507, 155);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(124, 21);
            this.label12.TabIndex = 1;
            this.label12.Text = "Fecha emisión:";
            // 
            // txt_fecemi
            // 
            this.txt_fecemi.Location = new System.Drawing.Point(637, 158);
            this.txt_fecemi.Name = "txt_fecemi";
            this.txt_fecemi.Size = new System.Drawing.Size(103, 20);
            this.txt_fecemi.TabIndex = 2;
            this.txt_fecemi.TextChanged += new System.EventHandler(this.txt_fecemi_TextChanged);
            // 
            // txt_fecven
            // 
            this.txt_fecven.Location = new System.Drawing.Point(236, 190);
            this.txt_fecven.Name = "txt_fecven";
            this.txt_fecven.Size = new System.Drawing.Size(205, 20);
            this.txt_fecven.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(507, 190);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(135, 21);
            this.label13.TabIndex = 1;
            this.label13.Text = "Forma de pago:";
            // 
            // cbo_formpago
            // 
            this.cbo_formpago.FormattingEnabled = true;
            this.cbo_formpago.Location = new System.Drawing.Point(637, 189);
            this.cbo_formpago.Name = "cbo_formpago";
            this.cbo_formpago.Size = new System.Drawing.Size(103, 21);
            this.cbo_formpago.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(507, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 21);
            this.label1.TabIndex = 21;
            this.label1.Text = "Serie:";
            // 
            // cbo_serie
            // 
            this.cbo_serie.FormattingEnabled = true;
            this.cbo_serie.Location = new System.Drawing.Point(563, 83);
            this.cbo_serie.Name = "cbo_serie";
            this.cbo_serie.Size = new System.Drawing.Size(103, 21);
            this.cbo_serie.TabIndex = 22;
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.BackgroundImage = global::cuentas_corrientes.Properties.Resources.nuevo;
            this.btn_nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_nuevo.Location = new System.Drawing.Point(153, 12);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(65, 65);
            this.btn_nuevo.TabIndex = 23;
            this.btn_nuevo.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::cuentas_corrientes.Properties.Resources.borrar;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(224, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 65);
            this.button1.TabIndex = 24;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::cuentas_corrientes.Properties.Resources.modificar;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(295, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 65);
            this.button2.TabIndex = 25;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::cuentas_corrientes.Properties.Resources.guardar;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(366, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(65, 65);
            this.button3.TabIndex = 26;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::cuentas_corrientes.Properties.Resources.buscar;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Location = new System.Drawing.Point(437, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(65, 65);
            this.button4.TabIndex = 27;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::cuentas_corrientes.Properties.Resources.actualizar;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Location = new System.Drawing.Point(508, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(65, 65);
            this.button5.TabIndex = 28;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // frmFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(805, 524);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_nuevo);
            this.Controls.Add(this.cbo_serie);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbo_formpago);
            this.Controls.Add(this.btn_agregarimp);
            this.Controls.Add(this.dgv_detallefact);
            this.Controls.Add(this.btn_buscped);
            this.Controls.Add(this.btn_buscfolio);
            this.Controls.Add(this.btn_buscprod);
            this.Controls.Add(this.btn_Buscte);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.txt_subtot);
            this.Controls.Add(this.txt_fecven);
            this.Controls.Add(this.txt_fecemi);
            this.Controls.Add(this.txt_nit);
            this.Controls.Add(this.txt_dir);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Facturación";
            this.Load += new System.EventHandler(this.frmFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detallefact)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_dir;
        private System.Windows.Forms.TextBox txt_nit;
        private System.Windows.Forms.Button btn_Buscte;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_subtot;
        private System.Windows.Forms.DataGridView dgv_detallefact;
        private System.Windows.Forms.Button btn_buscprod;
        private System.Windows.Forms.Button btn_buscfolio;
        private System.Windows.Forms.Button btn_buscped;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_agregarimp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_fecemi;
        private System.Windows.Forms.TextBox txt_fecven;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbo_formpago;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_serie;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

