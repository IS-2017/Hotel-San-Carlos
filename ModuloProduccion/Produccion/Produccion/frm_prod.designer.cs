namespace produccion
{
    partial class frm_prod
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbl_cantidad_pedido = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_detalle_mp = new System.Windows.Forms.DataGridView();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.dgv_pedido = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_pedido = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_bien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_costo_total = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_hrs_hombre_total = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detalle_mp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pedido)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1159, 472);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1151, 446);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Producción";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.lbl_cantidad_pedido);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.dgv_detalle_mp);
            this.tabPage2.Controls.Add(this.btn_consultar);
            this.tabPage2.Controls.Add(this.btn_cancelar);
            this.tabPage2.Controls.Add(this.btn_aceptar);
            this.tabPage2.Controls.Add(this.dgv_pedido);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.cmb_pedido);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1151, 446);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Materia prima";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // lbl_cantidad_pedido
            // 
            this.lbl_cantidad_pedido.AutoSize = true;
            this.lbl_cantidad_pedido.Location = new System.Drawing.Point(1090, 25);
            this.lbl_cantidad_pedido.Name = "lbl_cantidad_pedido";
            this.lbl_cantidad_pedido.Size = new System.Drawing.Size(35, 13);
            this.lbl_cantidad_pedido.TabIndex = 17;
            this.lbl_cantidad_pedido.Text = "label2";
            this.lbl_cantidad_pedido.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(606, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Materia Prima a utilizarse";
            // 
            // dgv_detalle_mp
            // 
            this.dgv_detalle_mp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_detalle_mp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.receta,
            this.cantidad,
            this.medida,
            this.id_bien,
            this.descripcion});
            this.dgv_detalle_mp.Location = new System.Drawing.Point(401, 45);
            this.dgv_detalle_mp.Name = "dgv_detalle_mp";
            this.dgv_detalle_mp.Size = new System.Drawing.Size(543, 311);
            this.dgv_detalle_mp.TabIndex = 15;
            // 
            // btn_consultar
            // 
            this.btn_consultar.Location = new System.Drawing.Point(273, 45);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(75, 23);
            this.btn_consultar.TabIndex = 14;
            this.btn_consultar.Text = "Consultar";
            this.btn_consultar.UseVisualStyleBackColor = true;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(239, 333);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 13;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(74, 333);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_aceptar.TabIndex = 12;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // dgv_pedido
            // 
            this.dgv_pedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pedido.Location = new System.Drawing.Point(5, 131);
            this.dgv_pedido.Name = "dgv_pedido";
            this.dgv_pedido.Size = new System.Drawing.Size(343, 150);
            this.dgv_pedido.TabIndex = 11;
            this.dgv_pedido.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_pedido_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Pedido";
            // 
            // cmb_pedido
            // 
            this.cmb_pedido.FormattingEnabled = true;
            this.cmb_pedido.Location = new System.Drawing.Point(117, 45);
            this.cmb_pedido.Name = "cmb_pedido";
            this.cmb_pedido.Size = new System.Drawing.Size(121, 21);
            this.cmb_pedido.TabIndex = 9;
            this.cmb_pedido.SelectedIndexChanged += new System.EventHandler(this.cmb_pedido_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1151, 446);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Mano obra";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1151, 446);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Resumen";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1151, 446);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Requisición";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "nombre";
            this.nombre.Name = "nombre";
            // 
            // receta
            // 
            this.receta.HeaderText = "Receta";
            this.receta.Name = "receta";
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "cantidad";
            this.cantidad.Name = "cantidad";
            // 
            // medida
            // 
            this.medida.HeaderText = "medida";
            this.medida.Name = "medida";
            // 
            // id_bien
            // 
            this.id_bien.HeaderText = "ID Bien";
            this.id_bien.Name = "id_bien";
            this.id_bien.Visible = false;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "descripcion";
            this.descripcion.Name = "descripcion";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_hrs_hombre_total);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lbl_costo_total);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(963, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(161, 310);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Descripcion de Pedido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Costo:";
            // 
            // lbl_costo_total
            // 
            this.lbl_costo_total.AutoSize = true;
            this.lbl_costo_total.Location = new System.Drawing.Point(16, 86);
            this.lbl_costo_total.Name = "lbl_costo_total";
            this.lbl_costo_total.Size = new System.Drawing.Size(35, 13);
            this.lbl_costo_total.TabIndex = 1;
            this.lbl_costo_total.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Horas Hombre:";
            // 
            // lbl_hrs_hombre_total
            // 
            this.lbl_hrs_hombre_total.AutoSize = true;
            this.lbl_hrs_hombre_total.Location = new System.Drawing.Point(16, 211);
            this.lbl_hrs_hombre_total.Name = "lbl_hrs_hombre_total";
            this.lbl_hrs_hombre_total.Size = new System.Drawing.Size(35, 13);
            this.lbl_hrs_hombre_total.TabIndex = 3;
            this.lbl_hrs_hombre_total.Text = "label6";
            // 
            // frm_prod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 480);
            this.Controls.Add(this.tabControl1);
            this.Name = "frm_prod";
            this.Text = "Producciòn";
            this.Load += new System.EventHandler(this.frm_prod_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detalle_mp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pedido)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_detalle_mp;
        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.DataGridView dgv_pedido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_pedido;
        private System.Windows.Forms.Label lbl_cantidad_pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn receta;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn medida;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_bien;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_hrs_hombre_total;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_costo_total;
        private System.Windows.Forms.Label label3;
    }
}

