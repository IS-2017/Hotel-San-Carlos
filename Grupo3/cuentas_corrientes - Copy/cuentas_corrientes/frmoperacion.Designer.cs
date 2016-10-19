namespace cuentas_corrientes
{
    partial class frmoperacion
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
            this.dgv_operacion = new System.Windows.Forms.DataGridView();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt = new System.Windows.Forms.Label();
            this.date_clte = new System.Windows.Forms.DateTimePicker();
            this.cmb_tipodoc = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_nuevo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_operacion)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_operacion
            // 
            this.dgv_operacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_operacion.Location = new System.Drawing.Point(25, 345);
            this.dgv_operacion.Name = "dgv_operacion";
            this.dgv_operacion.Size = new System.Drawing.Size(749, 169);
            this.dgv_operacion.TabIndex = 10;
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(133, 245);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(150, 20);
            this.txt_descripcion.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 21);
            this.label3.TabIndex = 28;
            this.label3.Text = "Descripcion:";
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(133, 206);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(150, 20);
            this.txt_cantidad.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 21);
            this.label1.TabIndex = 26;
            this.label1.Text = "Cantidad:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(133, 165);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(150, 20);
            this.txt_nombre.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 21);
            this.label2.TabIndex = 24;
            this.label2.Text = "Monto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(386, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 21);
            this.label4.TabIndex = 32;
            this.label4.Text = "Fecha de emision:";
            // 
            // txt
            // 
            this.txt.AutoSize = true;
            this.txt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt.Location = new System.Drawing.Point(386, 165);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(143, 21);
            this.txt.TabIndex = 30;
            this.txt.Text = "Tipo documento:";
            // 
            // date_clte
            // 
            this.date_clte.Location = new System.Drawing.Point(549, 206);
            this.date_clte.Name = "date_clte";
            this.date_clte.Size = new System.Drawing.Size(200, 20);
            this.date_clte.TabIndex = 33;
            // 
            // cmb_tipodoc
            // 
            this.cmb_tipodoc.FormattingEnabled = true;
            this.cmb_tipodoc.Location = new System.Drawing.Point(549, 168);
            this.cmb_tipodoc.Name = "cmb_tipodoc";
            this.cmb_tipodoc.Size = new System.Drawing.Size(150, 21);
            this.cmb_tipodoc.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(294, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 32);
            this.label5.TabIndex = 35;
            this.label5.Text = "Operacion";
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::cuentas_corrientes.Properties.Resources.actualizar;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Location = new System.Drawing.Point(516, 78);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(65, 65);
            this.button5.TabIndex = 41;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::cuentas_corrientes.Properties.Resources.buscar;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Location = new System.Drawing.Point(445, 78);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(65, 65);
            this.button4.TabIndex = 40;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::cuentas_corrientes.Properties.Resources.guardar;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(374, 78);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(65, 65);
            this.button3.TabIndex = 39;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::cuentas_corrientes.Properties.Resources.modificar;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(303, 78);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 65);
            this.button2.TabIndex = 38;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::cuentas_corrientes.Properties.Resources.borrar;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(232, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 65);
            this.button1.TabIndex = 37;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.BackgroundImage = global::cuentas_corrientes.Properties.Resources.nuevo;
            this.btn_nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_nuevo.Location = new System.Drawing.Point(161, 78);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(65, 65);
            this.btn_nuevo.TabIndex = 36;
            this.btn_nuevo.UseVisualStyleBackColor = true;
            // 
            // frmoperacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(804, 526);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_nuevo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmb_tipodoc);
            this.Controls.Add(this.date_clte);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_cantidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_operacion);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmoperacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Operacion";
            this.Load += new System.EventHandler(this.frmImpuesto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_operacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_operacion;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txt;
        private System.Windows.Forms.DateTimePicker date_clte;
        private System.Windows.Forms.ComboBox cmb_tipodoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_nuevo;
    }
}