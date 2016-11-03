namespace ModuloAdminHotel
{
    partial class Frm_ReservacionSalon
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
            this.grb_cliente = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_fechaentrada = new System.Windows.Forms.Label();
            this.txt_dpi = new System.Windows.Forms.TextBox();
            this.lbl_dpi = new System.Windows.Forms.Label();
            this.txt_nit = new System.Windows.Forms.TextBox();
            this.lbl_nit = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.grp_reservacion = new System.Windows.Forms.GroupBox();
            this.lbl_dimencion = new System.Windows.Forms.Label();
            this.txt_dimencion = new System.Windows.Forms.TextBox();
            this.lbl_ubicacion = new System.Windows.Forms.Label();
            this.txt_ubicacion = new System.Windows.Forms.TextBox();
            this.rtb_descripcion = new System.Windows.Forms.RichTextBox();
            this.lbl_descripcion = new System.Windows.Forms.Label();
            this.cbo_salon = new System.Windows.Forms.ComboBox();
            this.lbl_salon = new System.Windows.Forms.Label();
            this.txt_capacidad = new System.Windows.Forms.TextBox();
            this.lbl_capacidad = new System.Windows.Forms.Label();
            this.cbo_tipo = new System.Windows.Forms.ComboBox();
            this.lbl_tipo = new System.Windows.Forms.Label();
            this.txt_hrasalida = new System.Windows.Forms.TextBox();
            this.txt_hraentrada = new System.Windows.Forms.TextBox();
            this.lbl_horasalida = new System.Windows.Forms.Label();
            this.lbl_hraentrada = new System.Windows.Forms.Label();
            this.dtp_fecsalida = new System.Windows.Forms.DateTimePicker();
            this.dtp_fecentrada = new System.Windows.Forms.DateTimePicker();
            this.lbl_fecsalida = new System.Windows.Forms.Label();
            this.lbl_entrada = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.lbl_buscar = new System.Windows.Forms.Label();
            this.dgv_reservacionsalon = new System.Windows.Forms.DataGridView();
            this.grb_cliente.SuspendLayout();
            this.grp_reservacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reservacionsalon)).BeginInit();
            this.SuspendLayout();
            // 
            // grb_cliente
            // 
            this.grb_cliente.Controls.Add(this.label1);
            this.grb_cliente.Controls.Add(this.lbl_fechaentrada);
            this.grb_cliente.Controls.Add(this.txt_dpi);
            this.grb_cliente.Controls.Add(this.lbl_dpi);
            this.grb_cliente.Controls.Add(this.txt_nit);
            this.grb_cliente.Controls.Add(this.lbl_nit);
            this.grb_cliente.Controls.Add(this.txt_nombre);
            this.grb_cliente.Controls.Add(this.lbl_nombre);
            this.grb_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_cliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grb_cliente.Location = new System.Drawing.Point(12, 62);
            this.grb_cliente.Name = "grb_cliente";
            this.grb_cliente.Size = new System.Drawing.Size(251, 143);
            this.grb_cliente.TabIndex = 77;
            this.grb_cliente.TabStop = false;
            this.grb_cliente.Text = "DATOS DEL CLIENTE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 21);
            this.label1.TabIndex = 11;
            // 
            // lbl_fechaentrada
            // 
            this.lbl_fechaentrada.AutoSize = true;
            this.lbl_fechaentrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fechaentrada.Location = new System.Drawing.Point(6, 118);
            this.lbl_fechaentrada.Name = "lbl_fechaentrada";
            this.lbl_fechaentrada.Size = new System.Drawing.Size(0, 24);
            this.lbl_fechaentrada.TabIndex = 8;
            // 
            // txt_dpi
            // 
            this.txt_dpi.Location = new System.Drawing.Point(80, 64);
            this.txt_dpi.Name = "txt_dpi";
            this.txt_dpi.Size = new System.Drawing.Size(147, 26);
            this.txt_dpi.TabIndex = 7;
            // 
            // lbl_dpi
            // 
            this.lbl_dpi.AutoSize = true;
            this.lbl_dpi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dpi.Location = new System.Drawing.Point(12, 66);
            this.lbl_dpi.Name = "lbl_dpi";
            this.lbl_dpi.Size = new System.Drawing.Size(40, 21);
            this.lbl_dpi.TabIndex = 6;
            this.lbl_dpi.Text = "Dpi:";
            // 
            // txt_nit
            // 
            this.txt_nit.Location = new System.Drawing.Point(80, 97);
            this.txt_nit.Name = "txt_nit";
            this.txt_nit.Size = new System.Drawing.Size(147, 26);
            this.txt_nit.TabIndex = 5;
            // 
            // lbl_nit
            // 
            this.lbl_nit.AutoSize = true;
            this.lbl_nit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nit.Location = new System.Drawing.Point(12, 99);
            this.lbl_nit.Name = "lbl_nit";
            this.lbl_nit.Size = new System.Drawing.Size(36, 21);
            this.lbl_nit.TabIndex = 4;
            this.lbl_nit.Text = "Nit:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(80, 32);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(147, 26);
            this.txt_nombre.TabIndex = 3;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.Location = new System.Drawing.Point(6, 34);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(77, 21);
            this.lbl_nombre.TabIndex = 2;
            this.lbl_nombre.Text = "Nombre:";
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_titulo.Location = new System.Drawing.Point(194, 9);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(297, 28);
            this.lbl_titulo.TabIndex = 78;
            this.lbl_titulo.Text = "RESERVACION DE SALON";
            // 
            // grp_reservacion
            // 
            this.grp_reservacion.Controls.Add(this.lbl_dimencion);
            this.grp_reservacion.Controls.Add(this.txt_dimencion);
            this.grp_reservacion.Controls.Add(this.lbl_ubicacion);
            this.grp_reservacion.Controls.Add(this.txt_ubicacion);
            this.grp_reservacion.Controls.Add(this.rtb_descripcion);
            this.grp_reservacion.Controls.Add(this.lbl_descripcion);
            this.grp_reservacion.Controls.Add(this.cbo_salon);
            this.grp_reservacion.Controls.Add(this.lbl_salon);
            this.grp_reservacion.Controls.Add(this.txt_capacidad);
            this.grp_reservacion.Controls.Add(this.lbl_capacidad);
            this.grp_reservacion.Controls.Add(this.cbo_tipo);
            this.grp_reservacion.Controls.Add(this.lbl_tipo);
            this.grp_reservacion.Controls.Add(this.txt_hrasalida);
            this.grp_reservacion.Controls.Add(this.txt_hraentrada);
            this.grp_reservacion.Controls.Add(this.lbl_horasalida);
            this.grp_reservacion.Controls.Add(this.lbl_hraentrada);
            this.grp_reservacion.Controls.Add(this.dtp_fecsalida);
            this.grp_reservacion.Controls.Add(this.dtp_fecentrada);
            this.grp_reservacion.Controls.Add(this.lbl_fecsalida);
            this.grp_reservacion.Controls.Add(this.lbl_entrada);
            this.grp_reservacion.Controls.Add(this.label2);
            this.grp_reservacion.Controls.Add(this.label3);
            this.grp_reservacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_reservacion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grp_reservacion.Location = new System.Drawing.Point(279, 62);
            this.grp_reservacion.Name = "grp_reservacion";
            this.grp_reservacion.Size = new System.Drawing.Size(572, 234);
            this.grp_reservacion.TabIndex = 79;
            this.grp_reservacion.TabStop = false;
            this.grp_reservacion.Text = "DATOS DEL SALON";
            // 
            // lbl_dimencion
            // 
            this.lbl_dimencion.AutoSize = true;
            this.lbl_dimencion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dimencion.Location = new System.Drawing.Point(338, 180);
            this.lbl_dimencion.Name = "lbl_dimencion";
            this.lbl_dimencion.Size = new System.Drawing.Size(93, 21);
            this.lbl_dimencion.TabIndex = 82;
            this.lbl_dimencion.Text = "Dimension:";
            // 
            // txt_dimencion
            // 
            this.txt_dimencion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dimencion.Location = new System.Drawing.Point(437, 180);
            this.txt_dimencion.Name = "txt_dimencion";
            this.txt_dimencion.Size = new System.Drawing.Size(124, 27);
            this.txt_dimencion.TabIndex = 81;
            // 
            // lbl_ubicacion
            // 
            this.lbl_ubicacion.AutoSize = true;
            this.lbl_ubicacion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ubicacion.Location = new System.Drawing.Point(338, 146);
            this.lbl_ubicacion.Name = "lbl_ubicacion";
            this.lbl_ubicacion.Size = new System.Drawing.Size(93, 21);
            this.lbl_ubicacion.TabIndex = 80;
            this.lbl_ubicacion.Text = "Ubicacion:";
            // 
            // txt_ubicacion
            // 
            this.txt_ubicacion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ubicacion.Location = new System.Drawing.Point(434, 143);
            this.txt_ubicacion.Name = "txt_ubicacion";
            this.txt_ubicacion.Size = new System.Drawing.Size(124, 27);
            this.txt_ubicacion.TabIndex = 79;
            // 
            // rtb_descripcion
            // 
            this.rtb_descripcion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_descripcion.Location = new System.Drawing.Point(122, 126);
            this.rtb_descripcion.Name = "rtb_descripcion";
            this.rtb_descripcion.Size = new System.Drawing.Size(209, 99);
            this.rtb_descripcion.TabIndex = 78;
            this.rtb_descripcion.Text = "";
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.AutoSize = true;
            this.lbl_descripcion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descripcion.Location = new System.Drawing.Point(12, 129);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Size = new System.Drawing.Size(104, 21);
            this.lbl_descripcion.TabIndex = 12;
            this.lbl_descripcion.Text = "Descripcion:";
            // 
            // cbo_salon
            // 
            this.cbo_salon.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_salon.FormattingEnabled = true;
            this.cbo_salon.Location = new System.Drawing.Point(259, 95);
            this.cbo_salon.Name = "cbo_salon";
            this.cbo_salon.Size = new System.Drawing.Size(121, 29);
            this.cbo_salon.TabIndex = 25;
            // 
            // lbl_salon
            // 
            this.lbl_salon.AutoSize = true;
            this.lbl_salon.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_salon.Location = new System.Drawing.Point(206, 98);
            this.lbl_salon.Name = "lbl_salon";
            this.lbl_salon.Size = new System.Drawing.Size(56, 21);
            this.lbl_salon.TabIndex = 24;
            this.lbl_salon.Text = "Salon:";
            // 
            // txt_capacidad
            // 
            this.txt_capacidad.Location = new System.Drawing.Point(509, 97);
            this.txt_capacidad.Name = "txt_capacidad";
            this.txt_capacidad.Size = new System.Drawing.Size(49, 26);
            this.txt_capacidad.TabIndex = 22;
            // 
            // lbl_capacidad
            // 
            this.lbl_capacidad.AutoSize = true;
            this.lbl_capacidad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_capacidad.Location = new System.Drawing.Point(397, 99);
            this.lbl_capacidad.Name = "lbl_capacidad";
            this.lbl_capacidad.Size = new System.Drawing.Size(106, 21);
            this.lbl_capacidad.TabIndex = 23;
            this.lbl_capacidad.Text = "Capacidad:";
            // 
            // cbo_tipo
            // 
            this.cbo_tipo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_tipo.FormattingEnabled = true;
            this.cbo_tipo.Location = new System.Drawing.Point(70, 92);
            this.cbo_tipo.Name = "cbo_tipo";
            this.cbo_tipo.Size = new System.Drawing.Size(121, 29);
            this.cbo_tipo.TabIndex = 21;
            // 
            // lbl_tipo
            // 
            this.lbl_tipo.AutoSize = true;
            this.lbl_tipo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipo.Location = new System.Drawing.Point(18, 94);
            this.lbl_tipo.Name = "lbl_tipo";
            this.lbl_tipo.Size = new System.Drawing.Size(46, 21);
            this.lbl_tipo.TabIndex = 20;
            this.lbl_tipo.Text = "Tipo:";
            // 
            // txt_hrasalida
            // 
            this.txt_hrasalida.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_hrasalida.Location = new System.Drawing.Point(446, 59);
            this.txt_hrasalida.Name = "txt_hrasalida";
            this.txt_hrasalida.Size = new System.Drawing.Size(112, 27);
            this.txt_hrasalida.TabIndex = 19;
            // 
            // txt_hraentrada
            // 
            this.txt_hraentrada.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_hraentrada.Location = new System.Drawing.Point(169, 59);
            this.txt_hraentrada.Name = "txt_hraentrada";
            this.txt_hraentrada.Size = new System.Drawing.Size(112, 27);
            this.txt_hraentrada.TabIndex = 18;
            // 
            // lbl_horasalida
            // 
            this.lbl_horasalida.AutoSize = true;
            this.lbl_horasalida.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_horasalida.Location = new System.Drawing.Point(303, 62);
            this.lbl_horasalida.Name = "lbl_horasalida";
            this.lbl_horasalida.Size = new System.Drawing.Size(128, 21);
            this.lbl_horasalida.TabIndex = 17;
            this.lbl_horasalida.Text = "Hora De Salida:";
            // 
            // lbl_hraentrada
            // 
            this.lbl_hraentrada.AutoSize = true;
            this.lbl_hraentrada.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hraentrada.Location = new System.Drawing.Point(18, 59);
            this.lbl_hraentrada.Name = "lbl_hraentrada";
            this.lbl_hraentrada.Size = new System.Drawing.Size(145, 21);
            this.lbl_hraentrada.TabIndex = 16;
            this.lbl_hraentrada.Text = "Hora de entrada:";
            // 
            // dtp_fecsalida
            // 
            this.dtp_fecsalida.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fecsalida.Location = new System.Drawing.Point(446, 29);
            this.dtp_fecsalida.MinDate = new System.DateTime(2016, 10, 12, 0, 0, 0, 0);
            this.dtp_fecsalida.Name = "dtp_fecsalida";
            this.dtp_fecsalida.Size = new System.Drawing.Size(112, 27);
            this.dtp_fecsalida.TabIndex = 15;
            // 
            // dtp_fecentrada
            // 
            this.dtp_fecentrada.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fecentrada.Location = new System.Drawing.Point(169, 29);
            this.dtp_fecentrada.MinDate = new System.DateTime(2016, 10, 12, 0, 0, 0, 0);
            this.dtp_fecentrada.Name = "dtp_fecentrada";
            this.dtp_fecentrada.Size = new System.Drawing.Size(112, 27);
            this.dtp_fecentrada.TabIndex = 14;
            // 
            // lbl_fecsalida
            // 
            this.lbl_fecsalida.AutoSize = true;
            this.lbl_fecsalida.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecsalida.Location = new System.Drawing.Point(303, 31);
            this.lbl_fecsalida.Name = "lbl_fecsalida";
            this.lbl_fecsalida.Size = new System.Drawing.Size(140, 21);
            this.lbl_fecsalida.TabIndex = 13;
            this.lbl_fecsalida.Text = "Fecha De Salida:";
            // 
            // lbl_entrada
            // 
            this.lbl_entrada.AutoSize = true;
            this.lbl_entrada.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_entrada.Location = new System.Drawing.Point(6, 31);
            this.lbl_entrada.Name = "lbl_entrada";
            this.lbl_entrada.Size = new System.Drawing.Size(157, 21);
            this.lbl_entrada.TabIndex = 12;
            this.lbl_entrada.Text = "Fecha De Entrada:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 21);
            this.label2.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 21);
            this.label3.TabIndex = 8;
            // 
            // txt_buscar
            // 
            this.txt_buscar.Location = new System.Drawing.Point(83, 242);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(190, 27);
            this.txt_buscar.TabIndex = 82;
            // 
            // lbl_buscar
            // 
            this.lbl_buscar.AutoSize = true;
            this.lbl_buscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_buscar.ForeColor = System.Drawing.Color.White;
            this.lbl_buscar.Location = new System.Drawing.Point(8, 245);
            this.lbl_buscar.Name = "lbl_buscar";
            this.lbl_buscar.Size = new System.Drawing.Size(78, 21);
            this.lbl_buscar.TabIndex = 81;
            this.lbl_buscar.Text = "BUSCAR:";
            // 
            // dgv_reservacionsalon
            // 
            this.dgv_reservacionsalon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_reservacionsalon.Location = new System.Drawing.Point(12, 305);
            this.dgv_reservacionsalon.Name = "dgv_reservacionsalon";
            this.dgv_reservacionsalon.Size = new System.Drawing.Size(839, 172);
            this.dgv_reservacionsalon.TabIndex = 83;
            // 
            // Frm_ReservacionSalon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(104)))), ((int)(((byte)(107)))));
            this.ClientSize = new System.Drawing.Size(864, 489);
            this.Controls.Add(this.dgv_reservacionsalon);
            this.Controls.Add(this.txt_buscar);
            this.Controls.Add(this.lbl_buscar);
            this.Controls.Add(this.grp_reservacion);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.grb_cliente);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Frm_ReservacionSalon";
            this.Text = "Frm_ReservacionSalon";
            this.grb_cliente.ResumeLayout(false);
            this.grb_cliente.PerformLayout();
            this.grp_reservacion.ResumeLayout(false);
            this.grp_reservacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reservacionsalon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_cliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_fechaentrada;
        private System.Windows.Forms.TextBox txt_dpi;
        private System.Windows.Forms.Label lbl_dpi;
        private System.Windows.Forms.TextBox txt_nit;
        private System.Windows.Forms.Label lbl_nit;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.GroupBox grp_reservacion;
        private System.Windows.Forms.Label lbl_dimencion;
        private System.Windows.Forms.TextBox txt_dimencion;
        private System.Windows.Forms.Label lbl_ubicacion;
        private System.Windows.Forms.TextBox txt_ubicacion;
        private System.Windows.Forms.RichTextBox rtb_descripcion;
        private System.Windows.Forms.Label lbl_descripcion;
        private System.Windows.Forms.ComboBox cbo_salon;
        private System.Windows.Forms.Label lbl_salon;
        private System.Windows.Forms.TextBox txt_capacidad;
        private System.Windows.Forms.Label lbl_capacidad;
        private System.Windows.Forms.ComboBox cbo_tipo;
        private System.Windows.Forms.Label lbl_tipo;
        private System.Windows.Forms.TextBox txt_hrasalida;
        private System.Windows.Forms.TextBox txt_hraentrada;
        private System.Windows.Forms.Label lbl_horasalida;
        private System.Windows.Forms.Label lbl_hraentrada;
        private System.Windows.Forms.DateTimePicker dtp_fecsalida;
        private System.Windows.Forms.DateTimePicker dtp_fecentrada;
        private System.Windows.Forms.Label lbl_fecsalida;
        private System.Windows.Forms.Label lbl_entrada;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Label lbl_buscar;
        private System.Windows.Forms.DataGridView dgv_reservacionsalon;
    }
}