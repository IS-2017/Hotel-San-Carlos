namespace ModuloAdminHotel
{
    partial class Frm_MantenimientoCliente
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_cliente = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.lbl_nit = new System.Windows.Forms.Label();
            this.lbl_correo = new System.Windows.Forms.Label();
            this.lbl_telefono = new System.Windows.Forms.Label();
            this.lbl_direccion = new System.Windows.Forms.Label();
            this.lbl_limcre = new System.Windows.Forms.Label();
            this.lbl_fecnac = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.txt_nit = new System.Windows.Forms.TextBox();
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.txt_limcre = new System.Windows.Forms.TextBox();
            this.dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(130, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(456, 85);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // lbl_cliente
            // 
            this.lbl_cliente.AutoSize = true;
            this.lbl_cliente.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cliente.ForeColor = System.Drawing.Color.White;
            this.lbl_cliente.Location = new System.Drawing.Point(281, 100);
            this.lbl_cliente.Name = "lbl_cliente";
            this.lbl_cliente.Size = new System.Drawing.Size(110, 30);
            this.lbl_cliente.TabIndex = 19;
            this.lbl_cliente.Text = "Clientes";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(29, 172);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(73, 21);
            this.lbl_nombre.TabIndex = 20;
            this.lbl_nombre.Text = "Nombre";
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.Location = new System.Drawing.Point(28, 203);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(74, 21);
            this.lbl_apellido.TabIndex = 21;
            this.lbl_apellido.Text = "Apellido";
            // 
            // lbl_nit
            // 
            this.lbl_nit.AutoSize = true;
            this.lbl_nit.Location = new System.Drawing.Point(67, 234);
            this.lbl_nit.Name = "lbl_nit";
            this.lbl_nit.Size = new System.Drawing.Size(35, 21);
            this.lbl_nit.TabIndex = 22;
            this.lbl_nit.Text = "NIT";
            // 
            // lbl_correo
            // 
            this.lbl_correo.AutoSize = true;
            this.lbl_correo.Location = new System.Drawing.Point(39, 264);
            this.lbl_correo.Name = "lbl_correo";
            this.lbl_correo.Size = new System.Drawing.Size(63, 21);
            this.lbl_correo.TabIndex = 23;
            this.lbl_correo.Text = "Correo";
            // 
            // lbl_telefono
            // 
            this.lbl_telefono.AutoSize = true;
            this.lbl_telefono.Location = new System.Drawing.Point(405, 172);
            this.lbl_telefono.Name = "lbl_telefono";
            this.lbl_telefono.Size = new System.Drawing.Size(76, 21);
            this.lbl_telefono.TabIndex = 24;
            this.lbl_telefono.Text = "Telefono";
            // 
            // lbl_direccion
            // 
            this.lbl_direccion.AutoSize = true;
            this.lbl_direccion.Location = new System.Drawing.Point(398, 203);
            this.lbl_direccion.Name = "lbl_direccion";
            this.lbl_direccion.Size = new System.Drawing.Size(83, 21);
            this.lbl_direccion.TabIndex = 25;
            this.lbl_direccion.Text = "Direccion";
            // 
            // lbl_limcre
            // 
            this.lbl_limcre.AutoSize = true;
            this.lbl_limcre.Location = new System.Drawing.Point(341, 234);
            this.lbl_limcre.Name = "lbl_limcre";
            this.lbl_limcre.Size = new System.Drawing.Size(140, 21);
            this.lbl_limcre.TabIndex = 26;
            this.lbl_limcre.Text = "Limite de credito";
            this.lbl_limcre.Click += new System.EventHandler(this.label7_Click);
            // 
            // lbl_fecnac
            // 
            this.lbl_fecnac.AutoSize = true;
            this.lbl_fecnac.Location = new System.Drawing.Point(304, 264);
            this.lbl_fecnac.Name = "lbl_fecnac";
            this.lbl_fecnac.Size = new System.Drawing.Size(177, 21);
            this.lbl_fecnac.TabIndex = 27;
            this.lbl_fecnac.Text = "Fecha de nacimiento";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(108, 169);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(190, 27);
            this.txt_nombre.TabIndex = 28;
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(108, 200);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(190, 27);
            this.txt_apellido.TabIndex = 29;
            // 
            // txt_nit
            // 
            this.txt_nit.Location = new System.Drawing.Point(108, 231);
            this.txt_nit.Name = "txt_nit";
            this.txt_nit.Size = new System.Drawing.Size(190, 27);
            this.txt_nit.TabIndex = 30;
            // 
            // txt_correo
            // 
            this.txt_correo.Location = new System.Drawing.Point(108, 261);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(190, 27);
            this.txt_correo.TabIndex = 31;
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(487, 169);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(190, 27);
            this.txt_telefono.TabIndex = 32;
            // 
            // txt_direccion
            // 
            this.txt_direccion.Location = new System.Drawing.Point(487, 200);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(190, 27);
            this.txt_direccion.TabIndex = 33;
            // 
            // txt_limcre
            // 
            this.txt_limcre.Location = new System.Drawing.Point(487, 231);
            this.txt_limcre.Name = "txt_limcre";
            this.txt_limcre.Size = new System.Drawing.Size(190, 27);
            this.txt_limcre.TabIndex = 34;
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.Location = new System.Drawing.Point(487, 261);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.Size = new System.Drawing.Size(190, 27);
            this.dtp_fecha.TabIndex = 35;
            // 
            // button6
            // 
            this.button6.BackgroundImage = global::ModuloAdminHotel.Properties.Resources.actualizar;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(383, 16);
            this.button6.Margin = new System.Windows.Forms.Padding(0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(65, 65);
            this.button6.TabIndex = 5;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::ModuloAdminHotel.Properties.Resources.guardar;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(232, 16);
            this.button5.Margin = new System.Windows.Forms.Padding(0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(65, 65);
            this.button5.TabIndex = 4;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::ModuloAdminHotel.Properties.Resources.buscar;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(309, 16);
            this.button4.Margin = new System.Windows.Forms.Padding(0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(65, 65);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::ModuloAdminHotel.Properties.Resources.modificar;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(156, 16);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(65, 65);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::ModuloAdminHotel.Properties.Resources.borrar;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(80, 16);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 65);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::ModuloAdminHotel.Properties.Resources.nuevo;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(6, 16);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 65);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Frm_MantenimientoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(104)))), ((int)(((byte)(107)))));
            this.ClientSize = new System.Drawing.Size(704, 381);
            this.Controls.Add(this.dtp_fecha);
            this.Controls.Add(this.txt_limcre);
            this.Controls.Add(this.txt_direccion);
            this.Controls.Add(this.txt_telefono);
            this.Controls.Add(this.txt_correo);
            this.Controls.Add(this.txt_nit);
            this.Controls.Add(this.txt_apellido);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.lbl_fecnac);
            this.Controls.Add(this.lbl_limcre);
            this.Controls.Add(this.lbl_direccion);
            this.Controls.Add(this.lbl_telefono);
            this.Controls.Add(this.lbl_correo);
            this.Controls.Add(this.lbl_nit);
            this.Controls.Add(this.lbl_apellido);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.lbl_cliente);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Frm_MantenimientoCliente";
            this.Text = "Frm_MantenimientoCliente";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_cliente;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_apellido;
        private System.Windows.Forms.Label lbl_nit;
        private System.Windows.Forms.Label lbl_correo;
        private System.Windows.Forms.Label lbl_telefono;
        private System.Windows.Forms.Label lbl_direccion;
        private System.Windows.Forms.Label lbl_limcre;
        private System.Windows.Forms.Label lbl_fecnac;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.TextBox txt_nit;
        private System.Windows.Forms.TextBox txt_correo;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.TextBox txt_limcre;
        private System.Windows.Forms.DateTimePicker dtp_fecha;
    }
}