namespace Inventario
{
    partial class FormRecibirStock
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
            this.dgw_entradas = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bodega = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Cant_recibida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbo_orden = new System.Windows.Forms.ComboBox();
            this.cbo_proveedor = new System.Windows.Forms.ComboBox();
            this.rdbt = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_añadir = new System.Windows.Forms.Button();
            this.btn_quitar = new System.Windows.Forms.Button();
            this.btn_recibir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_entradas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgw_entradas
            // 
            this.dgw_entradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_entradas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Descripcion,
            this.bodega,
            this.Cant_recibida,
            this.Costo});
            this.dgw_entradas.Location = new System.Drawing.Point(21, 224);
            this.dgw_entradas.Name = "dgw_entradas";
            this.dgw_entradas.Size = new System.Drawing.Size(739, 159);
            this.dgw_entradas.TabIndex = 0;
            this.dgw_entradas.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_entradas_CellValueChanged);
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
            // bodega
            // 
            this.bodega.HeaderText = "Bodega";
            this.bodega.Name = "bodega";
            this.bodega.Width = 120;
            // 
            // Cant_recibida
            // 
            this.Cant_recibida.HeaderText = "Cantidad recibida";
            this.Cant_recibida.Name = "Cant_recibida";
            this.Cant_recibida.ToolTipText = "cantidad del producto seleccionado que ingresará";
            // 
            // Costo
            // 
            this.Costo.HeaderText = "Costo unitario";
            this.Costo.Name = "Costo";
            this.Costo.ReadOnly = true;
            // 
            // cbo_orden
            // 
            this.cbo_orden.FormattingEnabled = true;
            this.cbo_orden.Location = new System.Drawing.Point(144, 115);
            this.cbo_orden.Name = "cbo_orden";
            this.cbo_orden.Size = new System.Drawing.Size(280, 21);
            this.cbo_orden.TabIndex = 1;
            this.cbo_orden.SelectedIndexChanged += new System.EventHandler(this.cbo_orden_SelectedIndexChanged);
            // 
            // cbo_proveedor
            // 
            this.cbo_proveedor.FormattingEnabled = true;
            this.cbo_proveedor.Location = new System.Drawing.Point(144, 40);
            this.cbo_proveedor.Name = "cbo_proveedor";
            this.cbo_proveedor.Size = new System.Drawing.Size(280, 21);
            this.cbo_proveedor.TabIndex = 2;
            // 
            // rdbt
            // 
            this.rdbt.AutoSize = true;
            this.rdbt.Location = new System.Drawing.Point(27, 17);
            this.rdbt.Name = "rdbt";
            this.rdbt.Size = new System.Drawing.Size(160, 17);
            this.rdbt.TabIndex = 3;
            this.rdbt.TabStop = true;
            this.rdbt.Text = "Recibir artículos específicos";
            this.rdbt.UseVisualStyleBackColor = true;
            this.rdbt.CheckedChanged += new System.EventHandler(this.rdbt_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(27, 92);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(159, 17);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Recibir por orden de compra";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Proveedor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Orden de compra:";
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.Location = new System.Drawing.Point(573, 19);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.Size = new System.Drawing.Size(200, 20);
            this.dtp_fecha.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(527, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fecha:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbo_orden);
            this.groupBox1.Controls.Add(this.cbo_proveedor);
            this.groupBox1.Controls.Add(this.rdbt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(761, 155);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de entrada";
            // 
            // btn_añadir
            // 
            this.btn_añadir.Location = new System.Drawing.Point(173, 390);
            this.btn_añadir.Name = "btn_añadir";
            this.btn_añadir.Size = new System.Drawing.Size(201, 23);
            this.btn_añadir.TabIndex = 10;
            this.btn_añadir.Text = "Añadir";
            this.btn_añadir.UseVisualStyleBackColor = true;
            this.btn_añadir.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_quitar
            // 
            this.btn_quitar.Location = new System.Drawing.Point(411, 390);
            this.btn_quitar.Name = "btn_quitar";
            this.btn_quitar.Size = new System.Drawing.Size(201, 23);
            this.btn_quitar.TabIndex = 11;
            this.btn_quitar.Text = "Quitar";
            this.btn_quitar.UseVisualStyleBackColor = true;
            this.btn_quitar.Click += new System.EventHandler(this.btn_quitar_Click);
            // 
            // btn_recibir
            // 
            this.btn_recibir.Location = new System.Drawing.Point(325, 456);
            this.btn_recibir.Name = "btn_recibir";
            this.btn_recibir.Size = new System.Drawing.Size(137, 23);
            this.btn_recibir.TabIndex = 12;
            this.btn_recibir.Text = "Recibir";
            this.btn_recibir.UseVisualStyleBackColor = true;
            this.btn_recibir.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // FormRecibirStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 491);
            this.Controls.Add(this.btn_recibir);
            this.Controls.Add(this.btn_quitar);
            this.Controls.Add(this.btn_añadir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtp_fecha);
            this.Controls.Add(this.dgw_entradas);
            this.Name = "FormRecibirStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recibir stock";
            this.Load += new System.EventHandler(this.FormRecibirStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_entradas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgw_entradas;
        private System.Windows.Forms.ComboBox cbo_orden;
        private System.Windows.Forms.ComboBox cbo_proveedor;
        private System.Windows.Forms.RadioButton rdbt;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_fecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_añadir;
        private System.Windows.Forms.Button btn_quitar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewComboBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewComboBoxColumn bodega;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cant_recibida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costo;
        private System.Windows.Forms.Button btn_recibir;
    }
}