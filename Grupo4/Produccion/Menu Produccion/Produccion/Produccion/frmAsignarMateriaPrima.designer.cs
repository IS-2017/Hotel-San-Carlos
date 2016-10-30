namespace produccion
{
    partial class frmAsignarMateriaPrima
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
            this.cmb_pedido = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_pedido = new System.Windows.Forms.DataGridView();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.dgv_detalle_mp = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_bien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_cantidad_pedido = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detalle_mp)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_pedido
            // 
            this.cmb_pedido.FormattingEnabled = true;
            this.cmb_pedido.Location = new System.Drawing.Point(152, 62);
            this.cmb_pedido.Name = "cmb_pedido";
            this.cmb_pedido.Size = new System.Drawing.Size(121, 21);
            this.cmb_pedido.TabIndex = 0;
            this.cmb_pedido.SelectedIndexChanged += new System.EventHandler(this.cmb_pedido_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pedido";
            // 
            // dgv_pedido
            // 
            this.dgv_pedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pedido.Location = new System.Drawing.Point(12, 145);
            this.dgv_pedido.Name = "dgv_pedido";
            this.dgv_pedido.Size = new System.Drawing.Size(412, 150);
            this.dgv_pedido.TabIndex = 2;
            this.dgv_pedido.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_pedido_CellContentClick);
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(87, 324);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_aceptar.TabIndex = 3;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(218, 324);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 4;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_consultar
            // 
            this.btn_consultar.Location = new System.Drawing.Point(280, 59);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(75, 23);
            this.btn_consultar.TabIndex = 5;
            this.btn_consultar.Text = "Consultar";
            this.btn_consultar.UseVisualStyleBackColor = true;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
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
            this.dgv_detalle_mp.Location = new System.Drawing.Point(479, 59);
            this.dgv_detalle_mp.Name = "dgv_detalle_mp";
            this.dgv_detalle_mp.Size = new System.Drawing.Size(650, 311);
            this.dgv_detalle_mp.TabIndex = 6;
            this.dgv_detalle_mp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_detalle_mp_CellContentClick);
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
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "descripcion";
            this.descripcion.Name = "descripcion";
            // 
            // lbl_cantidad_pedido
            // 
            this.lbl_cantidad_pedido.AutoSize = true;
            this.lbl_cantidad_pedido.Location = new System.Drawing.Point(1152, 372);
            this.lbl_cantidad_pedido.Name = "lbl_cantidad_pedido";
            this.lbl_cantidad_pedido.Size = new System.Drawing.Size(35, 13);
            this.lbl_cantidad_pedido.TabIndex = 7;
            this.lbl_cantidad_pedido.Text = "label2";
            this.lbl_cantidad_pedido.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(699, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Materia Prima a utilizarse";
            // 
            // frmAsignarMateriaPrima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 412);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_cantidad_pedido);
            this.Controls.Add(this.dgv_detalle_mp);
            this.Controls.Add(this.btn_consultar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.dgv_pedido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_pedido);
            this.Name = "frmAsignarMateriaPrima";
            this.Text = "frmAsignarMateriaPrima";
            this.Load += new System.EventHandler(this.frmAsignarMateriaPrima_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detalle_mp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_pedido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_pedido;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.DataGridView dgv_detalle_mp;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn receta;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn medida;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_bien;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.Label lbl_cantidad_pedido;
        private System.Windows.Forms.Label label2;
    }
}