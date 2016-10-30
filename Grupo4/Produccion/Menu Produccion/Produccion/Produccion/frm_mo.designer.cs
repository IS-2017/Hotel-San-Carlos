namespace produccion
{
    partial class frm_mo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_pedido = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dgv_colab_disp = new System.Windows.Forms.DataGridView();
            this.dgv_asignados = new System.Windows.Forms.DataGridView();
            this.btn_mover = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_colab_disp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_asignados)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.cmb_pedido);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(281, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(426, 139);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de pedido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pedido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Horas Hombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha de asignación";
            // 
            // cmb_pedido
            // 
            this.cmb_pedido.FormattingEnabled = true;
            this.cmb_pedido.Location = new System.Drawing.Point(180, 31);
            this.cmb_pedido.Name = "cmb_pedido";
            this.cmb_pedido.Size = new System.Drawing.Size(179, 21);
            this.cmb_pedido.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(182, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(177, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(182, 100);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(177, 20);
            this.textBox2.TabIndex = 5;
            // 
            // dgv_colab_disp
            // 
            this.dgv_colab_disp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_colab_disp.Location = new System.Drawing.Point(32, 196);
            this.dgv_colab_disp.Name = "dgv_colab_disp";
            this.dgv_colab_disp.Size = new System.Drawing.Size(448, 232);
            this.dgv_colab_disp.TabIndex = 1;
            // 
            // dgv_asignados
            // 
            this.dgv_asignados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_asignados.Location = new System.Drawing.Point(557, 196);
            this.dgv_asignados.Name = "dgv_asignados";
            this.dgv_asignados.Size = new System.Drawing.Size(440, 232);
            this.dgv_asignados.TabIndex = 2;
            // 
            // btn_mover
            // 
            this.btn_mover.Location = new System.Drawing.Point(496, 271);
            this.btn_mover.Name = "btn_mover";
            this.btn_mover.Size = new System.Drawing.Size(49, 42);
            this.btn_mover.TabIndex = 3;
            this.btn_mover.Text = ">";
            this.btn_mover.UseVisualStyleBackColor = true;
            // 
            // frm_mo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 466);
            this.Controls.Add(this.btn_mover);
            this.Controls.Add(this.dgv_asignados);
            this.Controls.Add(this.dgv_colab_disp);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_mo";
            this.Text = "Asignación Mano de Obra";
            this.Load += new System.EventHandler(this.frm_mo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_colab_disp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_asignados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cmb_pedido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_colab_disp;
        private System.Windows.Forms.DataGridView dgv_asignados;
        private System.Windows.Forms.Button btn_mover;
    }
}