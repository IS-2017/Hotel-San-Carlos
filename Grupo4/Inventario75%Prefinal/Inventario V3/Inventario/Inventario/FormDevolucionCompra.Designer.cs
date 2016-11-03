namespace Inventario
{
    partial class FormDevolucionCompra
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
            this.btn_crear = new System.Windows.Forms.Button();
            this.btn_quitar = new System.Windows.Forms.Button();
            this.btn_añadir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbo_bodega = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_encargado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_fecha_dev = new System.Windows.Forms.DateTimePicker();
            this.dgw_requisicion = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.cbo_compra = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbo_prov = new System.Windows.Forms.ComboBox();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Cant_devuelta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_requisicion)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_crear
            // 
            this.btn_crear.Location = new System.Drawing.Point(339, 454);
            this.btn_crear.Name = "btn_crear";
            this.btn_crear.Size = new System.Drawing.Size(137, 23);
            this.btn_crear.TabIndex = 27;
            this.btn_crear.Text = "Crear";
            this.btn_crear.UseVisualStyleBackColor = true;
            this.btn_crear.Click += new System.EventHandler(this.btn_crear_Click);
            // 
            // btn_quitar
            // 
            this.btn_quitar.Location = new System.Drawing.Point(416, 388);
            this.btn_quitar.Name = "btn_quitar";
            this.btn_quitar.Size = new System.Drawing.Size(201, 23);
            this.btn_quitar.TabIndex = 26;
            this.btn_quitar.Text = "Quitar";
            this.btn_quitar.UseVisualStyleBackColor = true;
            this.btn_quitar.Click += new System.EventHandler(this.btn_quitar_Click);
            // 
            // btn_añadir
            // 
            this.btn_añadir.Location = new System.Drawing.Point(178, 388);
            this.btn_añadir.Name = "btn_añadir";
            this.btn_añadir.Size = new System.Drawing.Size(201, 23);
            this.btn_añadir.TabIndex = 25;
            this.btn_añadir.Text = "Añadir";
            this.btn_añadir.UseVisualStyleBackColor = true;
            this.btn_añadir.Click += new System.EventHandler(this.btn_añadir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbo_prov);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbo_compra);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbo_bodega);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_encargado);
            this.groupBox1.Location = new System.Drawing.Point(26, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(761, 145);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos devolución";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Devuelto de (bodega):";
            // 
            // cbo_bodega
            // 
            this.cbo_bodega.FormattingEnabled = true;
            this.cbo_bodega.Location = new System.Drawing.Point(152, 43);
            this.cbo_bodega.Name = "cbo_bodega";
            this.cbo_bodega.Size = new System.Drawing.Size(310, 21);
            this.cbo_bodega.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Encargado:";
            // 
            // txt_encargado
            // 
            this.txt_encargado.Location = new System.Drawing.Point(152, 17);
            this.txt_encargado.Name = "txt_encargado";
            this.txt_encargado.Size = new System.Drawing.Size(310, 20);
            this.txt_encargado.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(541, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Fecha:";
            // 
            // dtp_fecha_dev
            // 
            this.dtp_fecha_dev.Location = new System.Drawing.Point(587, 17);
            this.dtp_fecha_dev.Name = "dtp_fecha_dev";
            this.dtp_fecha_dev.Size = new System.Drawing.Size(200, 20);
            this.dtp_fecha_dev.TabIndex = 22;
            // 
            // dgw_requisicion
            // 
            this.dgw_requisicion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_requisicion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Descripcion,
            this.Cant_devuelta,
            this.Observaciones});
            this.dgw_requisicion.Location = new System.Drawing.Point(26, 222);
            this.dgw_requisicion.Name = "dgw_requisicion";
            this.dgw_requisicion.Size = new System.Drawing.Size(761, 159);
            this.dgw_requisicion.TabIndex = 21;
            this.dgw_requisicion.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_requisicion_CellValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Por compra:";
            // 
            // cbo_compra
            // 
            this.cbo_compra.FormattingEnabled = true;
            this.cbo_compra.Location = new System.Drawing.Point(152, 70);
            this.cbo_compra.Name = "cbo_compra";
            this.cbo_compra.Size = new System.Drawing.Size(310, 21);
            this.cbo_compra.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Proveedor:";
            // 
            // cbo_prov
            // 
            this.cbo_prov.FormattingEnabled = true;
            this.cbo_prov.Location = new System.Drawing.Point(152, 97);
            this.cbo_prov.Name = "cbo_prov";
            this.cbo_prov.Size = new System.Drawing.Size(310, 21);
            this.cbo_prov.TabIndex = 10;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "CODIGO";
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.MaxDropDownItems = 100;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Descripcion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Descripcion.Width = 275;
            // 
            // Cant_devuelta
            // 
            this.Cant_devuelta.HeaderText = "Cantidad devuelta";
            this.Cant_devuelta.Name = "Cant_devuelta";
            this.Cant_devuelta.ToolTipText = "cantidad del producto seleccionado que ingresará";
            // 
            // Observaciones
            // 
            this.Observaciones.HeaderText = "Observaciones";
            this.Observaciones.Name = "Observaciones";
            this.Observaciones.Width = 250;
            // 
            // FormDevolucionCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 493);
            this.Controls.Add(this.btn_crear);
            this.Controls.Add(this.btn_quitar);
            this.Controls.Add(this.btn_añadir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtp_fecha_dev);
            this.Controls.Add(this.dgw_requisicion);
            this.Name = "FormDevolucionCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Devolución sobe compra";
            this.Load += new System.EventHandler(this.FormDevolucionCompra_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_requisicion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_crear;
        private System.Windows.Forms.Button btn_quitar;
        private System.Windows.Forms.Button btn_añadir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbo_bodega;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_encargado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_fecha_dev;
        private System.Windows.Forms.DataGridView dgw_requisicion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbo_prov;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbo_compra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewComboBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cant_devuelta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observaciones;
    }
}