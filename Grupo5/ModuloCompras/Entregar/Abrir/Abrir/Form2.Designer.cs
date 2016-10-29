namespace Abrir
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dgv_crystal = new System.Windows.Forms.DataGridView();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_imp = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.btn_ver = new System.Windows.Forms.Button();
            this.Btn_nuevo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_crystal)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dgv_crystal
            // 
            this.dgv_crystal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.dgv_crystal.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_crystal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_crystal.Location = new System.Drawing.Point(12, 191);
            this.dgv_crystal.Name = "dgv_crystal";
            this.dgv_crystal.RowTemplate.Height = 24;
            this.dgv_crystal.Size = new System.Drawing.Size(642, 202);
            this.dgv_crystal.TabIndex = 1;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // btn_imp
            // 
            this.btn_imp.BackgroundImage = global::Abrir.Properties.Resources.imprimir;
            this.btn_imp.FlatAppearance.BorderSize = 0;
            this.btn_imp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_imp.Location = new System.Drawing.Point(757, 191);
            this.btn_imp.Name = "btn_imp";
            this.btn_imp.Size = new System.Drawing.Size(87, 80);
            this.btn_imp.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btn_imp, "Mandar a Impresora");
            this.btn_imp.UseVisualStyleBackColor = true;
            this.btn_imp.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.BackgroundImage = global::Abrir.Properties.Resources.cerrar;
            this.btn_cerrar.FlatAppearance.BorderSize = 0;
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar.Location = new System.Drawing.Point(445, 49);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(87, 80);
            this.btn_cerrar.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btn_cerrar, "Cerrar Ventana");
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // btn_ver
            // 
            this.btn_ver.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ver.BackgroundImage")));
            this.btn_ver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ver.FlatAppearance.BorderSize = 0;
            this.btn_ver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ver.Location = new System.Drawing.Point(660, 191);
            this.btn_ver.Name = "btn_ver";
            this.btn_ver.Size = new System.Drawing.Size(87, 80);
            this.btn_ver.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btn_ver, "Visualizar RPT");
            this.btn_ver.UseVisualStyleBackColor = true;
            this.btn_ver.Click += new System.EventHandler(this.btn_ver_Click);
            // 
            // Btn_nuevo
            // 
            this.Btn_nuevo.BackgroundImage = global::Abrir.Properties.Resources.agregar_nuevo;
            this.Btn_nuevo.FlatAppearance.BorderSize = 0;
            this.Btn_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_nuevo.Location = new System.Drawing.Point(315, 49);
            this.Btn_nuevo.Name = "Btn_nuevo";
            this.Btn_nuevo.Size = new System.Drawing.Size(87, 80);
            this.Btn_nuevo.TabIndex = 0;
            this.toolTip1.SetToolTip(this.Btn_nuevo, "Agregar un nuevo .rtp");
            this.Btn_nuevo.UseVisualStyleBackColor = true;
            this.Btn_nuevo.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 405);
            this.Controls.Add(this.btn_imp);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.btn_ver);
            this.Controls.Add(this.dgv_crystal);
            this.Controls.Add(this.Btn_nuevo);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_crystal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button Btn_nuevo;
        private System.Windows.Forms.DataGridView dgv_crystal;
        private System.Windows.Forms.Button btn_ver;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Button btn_imp;
    }
}