﻿namespace produccion
{
    partial class frm_pedido
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_colab = new System.Windows.Forms.ComboBox();
            this.cmb_emp = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_fechaing = new System.Windows.Forms.TextBox();
            this.txt_horaing = new System.Windows.Forms.TextBox();
            this.txt_nopedido = new System.Windows.Forms.TextBox();
            this.lbl_empleado = new System.Windows.Forms.Label();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.lbl_hora = new System.Windows.Forms.Label();
            this.lbl_pedido = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_hora = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txt_cte = new System.Windows.Forms.TextBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_totdesc = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_sub = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmb_prod = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.txt_desc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_tipo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_cant = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgv_det_ped = new System.Windows.Forms.DataGridView();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_borrar = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_det_ped)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_colab);
            this.groupBox1.Controls.Add(this.cmb_emp);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txt_fechaing);
            this.groupBox1.Controls.Add(this.txt_horaing);
            this.groupBox1.Controls.Add(this.txt_nopedido);
            this.groupBox1.Controls.Add(this.lbl_empleado);
            this.groupBox1.Controls.Add(this.lbl_fecha);
            this.groupBox1.Controls.Add(this.lbl_hora);
            this.groupBox1.Controls.Add(this.lbl_pedido);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(173, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 162);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingreso";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cmb_colab
            // 
            this.cmb_colab.Enabled = false;
            this.cmb_colab.FormattingEnabled = true;
            this.cmb_colab.Location = new System.Drawing.Point(147, 122);
            this.cmb_colab.Name = "cmb_colab";
            this.cmb_colab.Size = new System.Drawing.Size(100, 23);
            this.cmb_colab.TabIndex = 18;
            this.cmb_colab.SelectedIndexChanged += new System.EventHandler(this.cmb_colab_SelectedIndexChanged);
            // 
            // cmb_emp
            // 
            this.cmb_emp.Enabled = false;
            this.cmb_emp.FormattingEnabled = true;
            this.cmb_emp.Location = new System.Drawing.Point(147, 13);
            this.cmb_emp.Name = "cmb_emp";
            this.cmb_emp.Size = new System.Drawing.Size(100, 23);
            this.cmb_emp.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(44, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 16);
            this.label10.TabIndex = 16;
            this.label10.Text = "Empresa";
            // 
            // txt_fechaing
            // 
            this.txt_fechaing.Enabled = false;
            this.txt_fechaing.Location = new System.Drawing.Point(147, 96);
            this.txt_fechaing.Name = "txt_fechaing";
            this.txt_fechaing.Size = new System.Drawing.Size(100, 20);
            this.txt_fechaing.TabIndex = 6;
            // 
            // txt_horaing
            // 
            this.txt_horaing.Enabled = false;
            this.txt_horaing.Location = new System.Drawing.Point(147, 67);
            this.txt_horaing.Name = "txt_horaing";
            this.txt_horaing.Size = new System.Drawing.Size(100, 20);
            this.txt_horaing.TabIndex = 5;
            // 
            // txt_nopedido
            // 
            this.txt_nopedido.Enabled = false;
            this.txt_nopedido.Location = new System.Drawing.Point(147, 40);
            this.txt_nopedido.Name = "txt_nopedido";
            this.txt_nopedido.Size = new System.Drawing.Size(100, 20);
            this.txt_nopedido.TabIndex = 4;
            // 
            // lbl_empleado
            // 
            this.lbl_empleado.AutoSize = true;
            this.lbl_empleado.Location = new System.Drawing.Point(44, 126);
            this.lbl_empleado.Name = "lbl_empleado";
            this.lbl_empleado.Size = new System.Drawing.Size(78, 16);
            this.lbl_empleado.TabIndex = 3;
            this.lbl_empleado.Text = "Colaborador";
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Location = new System.Drawing.Point(44, 99);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(42, 16);
            this.lbl_fecha.TabIndex = 2;
            this.lbl_fecha.Text = "Fecha";
            // 
            // lbl_hora
            // 
            this.lbl_hora.AutoSize = true;
            this.lbl_hora.Location = new System.Drawing.Point(44, 74);
            this.lbl_hora.Name = "lbl_hora";
            this.lbl_hora.Size = new System.Drawing.Size(74, 16);
            this.lbl_hora.TabIndex = 1;
            this.lbl_hora.Text = "Hora ingreso";
            // 
            // lbl_pedido
            // 
            this.lbl_pedido.AutoSize = true;
            this.lbl_pedido.Location = new System.Drawing.Point(44, 47);
            this.lbl_pedido.Name = "lbl_pedido";
            this.lbl_pedido.Size = new System.Drawing.Size(68, 16);
            this.lbl_pedido.TabIndex = 0;
            this.lbl_pedido.Text = "No. Pedido";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_hora);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.txt_cte);
            this.groupBox2.Controls.Add(this.btn_buscar);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(509, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(282, 162);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de pedido";
            // 
            // txt_hora
            // 
            this.txt_hora.Location = new System.Drawing.Point(102, 89);
            this.txt_hora.Margin = new System.Windows.Forms.Padding(2);
            this.txt_hora.Name = "txt_hora";
            this.txt_hora.Size = new System.Drawing.Size(151, 20);
            this.txt_hora.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(102, 58);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(151, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // txt_cte
            // 
            this.txt_cte.Enabled = false;
            this.txt_cte.Location = new System.Drawing.Point(142, 28);
            this.txt_cte.Name = "txt_cte";
            this.txt_cte.Size = new System.Drawing.Size(110, 20);
            this.txt_cte.TabIndex = 4;
            this.txt_cte.TextChanged += new System.EventHandler(this.txt_cte_TextChanged);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(94, 28);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(43, 19);
            this.btn_buscar.TabIndex = 3;
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hora entrega";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha entrega";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_totdesc);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txt_total);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txt_sub);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.cmb_prod);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.btn_agregar);
            this.groupBox3.Controls.Add(this.txt_desc);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txt_precio);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.cmb_tipo);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txt_cant);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.dgv_det_ped);
            this.groupBox3.Enabled = false;
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(43, 213);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(929, 257);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ingreso de productos";
            // 
            // txt_totdesc
            // 
            this.txt_totdesc.Enabled = false;
            this.txt_totdesc.Location = new System.Drawing.Point(804, 134);
            this.txt_totdesc.Name = "txt_totdesc";
            this.txt_totdesc.Size = new System.Drawing.Size(70, 20);
            this.txt_totdesc.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(736, 137);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 16);
            this.label12.TabIndex = 18;
            this.label12.Text = "Descuentos";
            // 
            // txt_total
            // 
            this.txt_total.Enabled = false;
            this.txt_total.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total.Location = new System.Drawing.Point(804, 159);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(70, 34);
            this.txt_total.TabIndex = 17;
            this.txt_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(736, 162);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 26);
            this.label11.TabIndex = 16;
            this.label11.Text = "Total";
            // 
            // txt_sub
            // 
            this.txt_sub.Enabled = false;
            this.txt_sub.Location = new System.Drawing.Point(804, 106);
            this.txt_sub.Name = "txt_sub";
            this.txt_sub.Size = new System.Drawing.Size(70, 20);
            this.txt_sub.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(736, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Subtotal";
            // 
            // cmb_prod
            // 
            this.cmb_prod.FormattingEnabled = true;
            this.cmb_prod.Location = new System.Drawing.Point(320, 32);
            this.cmb_prod.Name = "cmb_prod";
            this.cmb_prod.Size = new System.Drawing.Size(303, 23);
            this.cmb_prod.TabIndex = 13;
            this.cmb_prod.SelectedValueChanged += new System.EventHandler(this.cmb_prod_SelectedValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(264, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 16);
            this.label9.TabIndex = 12;
            this.label9.Text = "Producto";
            // 
            // btn_agregar
            // 
            this.btn_agregar.Enabled = false;
            this.btn_agregar.Location = new System.Drawing.Point(734, 72);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(57, 23);
            this.btn_agregar.TabIndex = 9;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // txt_desc
            // 
            this.txt_desc.Enabled = false;
            this.txt_desc.Location = new System.Drawing.Point(814, 37);
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.Size = new System.Drawing.Size(70, 20);
            this.txt_desc.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.Location = new System.Drawing.Point(746, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Descuento";
            // 
            // txt_precio
            // 
            this.txt_precio.Enabled = false;
            this.txt_precio.Location = new System.Drawing.Point(681, 36);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(60, 20);
            this.txt_precio.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(629, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Precio Q.";
            // 
            // cmb_tipo
            // 
            this.cmb_tipo.FormattingEnabled = true;
            this.cmb_tipo.Location = new System.Drawing.Point(180, 32);
            this.cmb_tipo.Name = "cmb_tipo";
            this.cmb_tipo.Size = new System.Drawing.Size(70, 23);
            this.cmb_tipo.TabIndex = 4;
            this.cmb_tipo.SelectedIndexChanged += new System.EventHandler(this.cmb_tipo_SelectedIndexChanged);
            this.cmb_tipo.SelectedValueChanged += new System.EventHandler(this.cmb_tipo_SelectedValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(146, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tipo";
            // 
            // txt_cant
            // 
            this.txt_cant.Location = new System.Drawing.Point(83, 32);
            this.txt_cant.Name = "txt_cant";
            this.txt_cant.Size = new System.Drawing.Size(54, 20);
            this.txt_cant.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Cantidad";
            // 
            // dgv_det_ped
            // 
            this.dgv_det_ped.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_det_ped.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tipo,
            this.Producto,
            this.Cantidad,
            this.Importe,
            this.descuento,
            this.Eliminar});
            this.dgv_det_ped.Location = new System.Drawing.Point(73, 72);
            this.dgv_det_ped.Name = "dgv_det_ped";
            this.dgv_det_ped.Size = new System.Drawing.Size(634, 169);
            this.dgv_det_ped.TabIndex = 0;
            this.dgv_det_ped.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_det_ped_CellContentClick);
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Importe
            // 
            this.Importe.HeaderText = "Importe";
            this.Importe.Name = "Importe";
            this.Importe.ReadOnly = true;
            // 
            // descuento
            // 
            this.descuento.HeaderText = "descuento";
            this.descuento.Name = "descuento";
            this.descuento.ReadOnly = true;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Enabled = false;
            this.btn_aceptar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aceptar.Location = new System.Drawing.Point(409, 0);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(68, 39);
            this.btn_aceptar.TabIndex = 3;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_borrar
            // 
            this.btn_borrar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_borrar.Location = new System.Drawing.Point(498, 0);
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.Size = new System.Drawing.Size(68, 39);
            this.btn_borrar.TabIndex = 4;
            this.btn_borrar.Text = "borrar";
            this.btn_borrar.UseVisualStyleBackColor = true;
            this.btn_borrar.Click += new System.EventHandler(this.btn_borrar_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(50, 29);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(24, 13);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "MO";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // frm_pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 479);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btn_borrar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_pedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedido";
            this.Load += new System.EventHandler(this.frm_pedido_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_det_ped)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_fechaing;
        private System.Windows.Forms.TextBox txt_horaing;
        private System.Windows.Forms.TextBox txt_nopedido;
        private System.Windows.Forms.Label lbl_empleado;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.Label lbl_hora;
        private System.Windows.Forms.Label lbl_pedido;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox cmb_emp;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmb_colab;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_tipo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_cant;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv_det_ped;
        public System.Windows.Forms.TextBox txt_cte;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.TextBox txt_desc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_borrar;
        private System.Windows.Forms.ComboBox cmb_prod;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.TextBox txt_hora;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_sub;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.DataGridViewTextBoxColumn descuento;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.TextBox txt_totdesc;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}