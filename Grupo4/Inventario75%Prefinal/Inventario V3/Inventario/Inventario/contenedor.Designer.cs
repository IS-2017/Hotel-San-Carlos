namespace Inventario
{
    partial class contenedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(contenedor));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recibirStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarRequisiciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devSobreCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturasPendientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bodegaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.muestreoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medidasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.líneasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.existenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kardexToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.movimientosDeInventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_nuevoprod = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_exist = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_mov = new System.Windows.Forms.Button();
            this.btn_kardex = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.mantenimientosToolStripMenuItem,
            this.reporteToolStripMenuItem,
            this.ayudaToolStripMenuItem1,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1134, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoDeProductosToolStripMenuItem,
            this.recibirStockToolStripMenuItem,
            this.generarRequisiciónToolStripMenuItem,
            this.devSobreCompraToolStripMenuItem,
            this.facturasPendientesToolStripMenuItem});
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.inicioToolStripMenuItem.Text = "Inventario";
            // 
            // listadoDeProductosToolStripMenuItem
            // 
            this.listadoDeProductosToolStripMenuItem.Name = "listadoDeProductosToolStripMenuItem";
            this.listadoDeProductosToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.listadoDeProductosToolStripMenuItem.Text = "Listado de productos";
            this.listadoDeProductosToolStripMenuItem.Click += new System.EventHandler(this.listadoDeProductosToolStripMenuItem_Click);
            // 
            // recibirStockToolStripMenuItem
            // 
            this.recibirStockToolStripMenuItem.Name = "recibirStockToolStripMenuItem";
            this.recibirStockToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.recibirStockToolStripMenuItem.Text = "Recibir stock";
            this.recibirStockToolStripMenuItem.Click += new System.EventHandler(this.recibirStockToolStripMenuItem_Click);
            // 
            // generarRequisiciónToolStripMenuItem
            // 
            this.generarRequisiciónToolStripMenuItem.Name = "generarRequisiciónToolStripMenuItem";
            this.generarRequisiciónToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.generarRequisiciónToolStripMenuItem.Text = "Generar requisición";
            this.generarRequisiciónToolStripMenuItem.Click += new System.EventHandler(this.generarRequisiciónToolStripMenuItem_Click);
            // 
            // devSobreCompraToolStripMenuItem
            // 
            this.devSobreCompraToolStripMenuItem.Name = "devSobreCompraToolStripMenuItem";
            this.devSobreCompraToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.devSobreCompraToolStripMenuItem.Text = "Generar dev. sobre compra";
            this.devSobreCompraToolStripMenuItem.Click += new System.EventHandler(this.devSobreCompraToolStripMenuItem_Click);
            // 
            // facturasPendientesToolStripMenuItem
            // 
            this.facturasPendientesToolStripMenuItem.Name = "facturasPendientesToolStripMenuItem";
            this.facturasPendientesToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.facturasPendientesToolStripMenuItem.Text = "Facturas pendientes...";
            this.facturasPendientesToolStripMenuItem.Click += new System.EventHandler(this.facturasPendientesToolStripMenuItem_Click);
            // 
            // mantenimientosToolStripMenuItem
            // 
            this.mantenimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productoToolStripMenuItem,
            this.bodegaToolStripMenuItem,
            this.categoriasToolStripMenuItem,
            this.marcaToolStripMenuItem,
            this.muestreoToolStripMenuItem,
            this.medidasToolStripMenuItem,
            this.líneasToolStripMenuItem});
            this.mantenimientosToolStripMenuItem.Name = "mantenimientosToolStripMenuItem";
            this.mantenimientosToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.mantenimientosToolStripMenuItem.Text = "Mantenimientos";
            this.mantenimientosToolStripMenuItem.Click += new System.EventHandler(this.mantenimientosToolStripMenuItem_Click);
            // 
            // productoToolStripMenuItem
            // 
            this.productoToolStripMenuItem.Name = "productoToolStripMenuItem";
            this.productoToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.productoToolStripMenuItem.Text = "Producto";
            this.productoToolStripMenuItem.Click += new System.EventHandler(this.productoToolStripMenuItem_Click);
            // 
            // bodegaToolStripMenuItem
            // 
            this.bodegaToolStripMenuItem.Name = "bodegaToolStripMenuItem";
            this.bodegaToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.bodegaToolStripMenuItem.Text = "Bodega";
            this.bodegaToolStripMenuItem.Click += new System.EventHandler(this.bodegaToolStripMenuItem_Click);
            // 
            // categoriasToolStripMenuItem
            // 
            this.categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            this.categoriasToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.categoriasToolStripMenuItem.Text = "Categorias";
            this.categoriasToolStripMenuItem.Click += new System.EventHandler(this.categoriasToolStripMenuItem_Click);
            // 
            // marcaToolStripMenuItem
            // 
            this.marcaToolStripMenuItem.Name = "marcaToolStripMenuItem";
            this.marcaToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.marcaToolStripMenuItem.Text = "Marca";
            this.marcaToolStripMenuItem.Click += new System.EventHandler(this.marcaToolStripMenuItem_Click);
            // 
            // muestreoToolStripMenuItem
            // 
            this.muestreoToolStripMenuItem.Name = "muestreoToolStripMenuItem";
            this.muestreoToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.muestreoToolStripMenuItem.Text = "Muestreo";
            this.muestreoToolStripMenuItem.Click += new System.EventHandler(this.muestreoToolStripMenuItem_Click);
            // 
            // medidasToolStripMenuItem
            // 
            this.medidasToolStripMenuItem.Name = "medidasToolStripMenuItem";
            this.medidasToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.medidasToolStripMenuItem.Text = "Medidas";
            this.medidasToolStripMenuItem.Click += new System.EventHandler(this.medidasToolStripMenuItem_Click);
            // 
            // líneasToolStripMenuItem
            // 
            this.líneasToolStripMenuItem.Name = "líneasToolStripMenuItem";
            this.líneasToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.líneasToolStripMenuItem.Text = "Líneas";
            this.líneasToolStripMenuItem.Click += new System.EventHandler(this.líneasToolStripMenuItem_Click);
            // 
            // reporteToolStripMenuItem
            // 
            this.reporteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteadorToolStripMenuItem,
            this.existenciasToolStripMenuItem,
            this.kardexToolStripMenuItem1,
            this.movimientosDeInventarioToolStripMenuItem});
            this.reporteToolStripMenuItem.Name = "reporteToolStripMenuItem";
            this.reporteToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reporteToolStripMenuItem.Text = "Reportes";
            // 
            // reporteadorToolStripMenuItem
            // 
            this.reporteadorToolStripMenuItem.Name = "reporteadorToolStripMenuItem";
            this.reporteadorToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.reporteadorToolStripMenuItem.Text = "Reporteador";
            this.reporteadorToolStripMenuItem.Click += new System.EventHandler(this.reporteadorToolStripMenuItem_Click);
            // 
            // existenciasToolStripMenuItem
            // 
            this.existenciasToolStripMenuItem.Name = "existenciasToolStripMenuItem";
            this.existenciasToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.existenciasToolStripMenuItem.Text = "Existencias ";
            this.existenciasToolStripMenuItem.Click += new System.EventHandler(this.existenciasToolStripMenuItem_Click);
            // 
            // kardexToolStripMenuItem1
            // 
            this.kardexToolStripMenuItem1.Name = "kardexToolStripMenuItem1";
            this.kardexToolStripMenuItem1.Size = new System.Drawing.Size(216, 22);
            this.kardexToolStripMenuItem1.Text = "Kardex";
            this.kardexToolStripMenuItem1.Click += new System.EventHandler(this.kardexToolStripMenuItem1_Click);
            // 
            // movimientosDeInventarioToolStripMenuItem
            // 
            this.movimientosDeInventarioToolStripMenuItem.Name = "movimientosDeInventarioToolStripMenuItem";
            this.movimientosDeInventarioToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.movimientosDeInventarioToolStripMenuItem.Text = "Movimientos de inventario";
            this.movimientosDeInventarioToolStripMenuItem.Click += new System.EventHandler(this.movimientosDeInventarioToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem1
            // 
            this.ayudaToolStripMenuItem1.Name = "ayudaToolStripMenuItem1";
            this.ayudaToolStripMenuItem1.Size = new System.Drawing.Size(72, 20);
            this.ayudaToolStripMenuItem1.Text = "Seguridad";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_nuevoprod);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_exist);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btn_mov);
            this.panel1.Controls.Add(this.btn_kardex);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(66, 608);
            this.panel1.TabIndex = 2;
            // 
            // btn_nuevoprod
            // 
            this.btn_nuevoprod.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_nuevoprod.BackgroundImage")));
            this.btn_nuevoprod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_nuevoprod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_nuevoprod.FlatAppearance.BorderSize = 0;
            this.btn_nuevoprod.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_nuevoprod.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_nuevoprod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nuevoprod.Location = new System.Drawing.Point(15, 14);
            this.btn_nuevoprod.Name = "btn_nuevoprod";
            this.btn_nuevoprod.Size = new System.Drawing.Size(42, 47);
            this.btn_nuevoprod.TabIndex = 4;
            this.btn_nuevoprod.UseVisualStyleBackColor = true;
            this.btn_nuevoprod.Click += new System.EventHandler(this.btn_nuevoprod_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Principal";
            // 
            // btn_exist
            // 
            this.btn_exist.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_exist.BackgroundImage")));
            this.btn_exist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exist.FlatAppearance.BorderSize = 0;
            this.btn_exist.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_exist.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_exist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exist.Location = new System.Drawing.Point(10, 89);
            this.btn_exist.Name = "btn_exist";
            this.btn_exist.Size = new System.Drawing.Size(42, 47);
            this.btn_exist.TabIndex = 6;
            this.btn_exist.UseVisualStyleBackColor = true;
            this.btn_exist.Click += new System.EventHandler(this.btn_exist_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Existencias ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Kardex";
            // 
            // btn_mov
            // 
            this.btn_mov.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_mov.BackgroundImage")));
            this.btn_mov.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_mov.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_mov.FlatAppearance.BorderSize = 0;
            this.btn_mov.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_mov.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_mov.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mov.Location = new System.Drawing.Point(12, 164);
            this.btn_mov.Name = "btn_mov";
            this.btn_mov.Size = new System.Drawing.Size(42, 47);
            this.btn_mov.TabIndex = 7;
            this.btn_mov.UseVisualStyleBackColor = true;
            this.btn_mov.Click += new System.EventHandler(this.btn_mov_Click);
            // 
            // btn_kardex
            // 
            this.btn_kardex.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_kardex.BackgroundImage")));
            this.btn_kardex.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_kardex.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_kardex.FlatAppearance.BorderSize = 0;
            this.btn_kardex.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_kardex.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_kardex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kardex.Location = new System.Drawing.Point(12, 240);
            this.btn_kardex.Name = "btn_kardex";
            this.btn_kardex.Size = new System.Drawing.Size(42, 47);
            this.btn_kardex.TabIndex = 8;
            this.btn_kardex.UseVisualStyleBackColor = true;
            this.btn_kardex.Click += new System.EventHandler(this.btn_kardex_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Movimientos";
            // 
            // contenedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(220)))), ((int)(((byte)(168)))));
            this.BackgroundImage = global::Inventario.Properties.Resources.inventarios;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1134, 702);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "contenedor";
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.contenedor_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mantenimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem existenciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kardexToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem movimientosDeInventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bodegaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem muestreoToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_nuevoprod;
        private System.Windows.Forms.Button btn_kardex;
        private System.Windows.Forms.Button btn_mov;
        private System.Windows.Forms.Button btn_exist;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem medidasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recibirStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem líneasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarRequisiciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devSobreCompraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturasPendientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteadorToolStripMenuItem;
    }
}