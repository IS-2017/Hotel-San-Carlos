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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mantenimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.paginaPrincipalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bodegaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productoTerminadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materiaPrimaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.muestreoMateriaPrimaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materiaProductoTerminadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeExistenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientosToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.reportesToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1546, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mantenimientosToolStripMenuItem
            // 
            this.mantenimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paginaPrincipalToolStripMenuItem});
            this.mantenimientosToolStripMenuItem.Name = "mantenimientosToolStripMenuItem";
            this.mantenimientosToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.mantenimientosToolStripMenuItem.Text = "Inventario";
            this.mantenimientosToolStripMenuItem.Click += new System.EventHandler(this.mantenimientosToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoriaToolStripMenuItem,
            this.marcaToolStripMenuItem,
            this.bodegaToolStripMenuItem,
            this.productoTerminadoToolStripMenuItem,
            this.materiaPrimaToolStripMenuItem,
            this.muestreoMateriaPrimaToolStripMenuItem,
            this.materiaProductoTerminadoToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.reportesToolStripMenuItem.Text = "Mantenimientos";
            // 
            // reportesToolStripMenuItem1
            // 
            this.reportesToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteDeExistenciasToolStripMenuItem});
            this.reportesToolStripMenuItem1.Name = "reportesToolStripMenuItem1";
            this.reportesToolStripMenuItem1.Size = new System.Drawing.Size(80, 24);
            this.reportesToolStripMenuItem1.Text = "Reportes";
            // 
            // paginaPrincipalToolStripMenuItem
            // 
            this.paginaPrincipalToolStripMenuItem.Name = "paginaPrincipalToolStripMenuItem";
            this.paginaPrincipalToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.paginaPrincipalToolStripMenuItem.Text = "Pagina Principal";
            this.paginaPrincipalToolStripMenuItem.Click += new System.EventHandler(this.paginaPrincipalToolStripMenuItem_Click);
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(275, 26);
            this.categoriaToolStripMenuItem.Text = "Categoria";
            this.categoriaToolStripMenuItem.Click += new System.EventHandler(this.categoriaToolStripMenuItem_Click);
            // 
            // marcaToolStripMenuItem
            // 
            this.marcaToolStripMenuItem.Name = "marcaToolStripMenuItem";
            this.marcaToolStripMenuItem.Size = new System.Drawing.Size(275, 26);
            this.marcaToolStripMenuItem.Text = "Marca";
            this.marcaToolStripMenuItem.Click += new System.EventHandler(this.marcaToolStripMenuItem_Click);
            // 
            // bodegaToolStripMenuItem
            // 
            this.bodegaToolStripMenuItem.Name = "bodegaToolStripMenuItem";
            this.bodegaToolStripMenuItem.Size = new System.Drawing.Size(275, 26);
            this.bodegaToolStripMenuItem.Text = "Bodega";
            this.bodegaToolStripMenuItem.Click += new System.EventHandler(this.bodegaToolStripMenuItem_Click);
            // 
            // productoTerminadoToolStripMenuItem
            // 
            this.productoTerminadoToolStripMenuItem.Name = "productoTerminadoToolStripMenuItem";
            this.productoTerminadoToolStripMenuItem.Size = new System.Drawing.Size(275, 26);
            this.productoTerminadoToolStripMenuItem.Text = "Producto Terminado";
            this.productoTerminadoToolStripMenuItem.Click += new System.EventHandler(this.productoTerminadoToolStripMenuItem_Click);
            // 
            // materiaPrimaToolStripMenuItem
            // 
            this.materiaPrimaToolStripMenuItem.Name = "materiaPrimaToolStripMenuItem";
            this.materiaPrimaToolStripMenuItem.Size = new System.Drawing.Size(275, 26);
            this.materiaPrimaToolStripMenuItem.Text = "Materia Prima";
            this.materiaPrimaToolStripMenuItem.Click += new System.EventHandler(this.materiaPrimaToolStripMenuItem_Click);
            // 
            // muestreoMateriaPrimaToolStripMenuItem
            // 
            this.muestreoMateriaPrimaToolStripMenuItem.Name = "muestreoMateriaPrimaToolStripMenuItem";
            this.muestreoMateriaPrimaToolStripMenuItem.Size = new System.Drawing.Size(275, 26);
            this.muestreoMateriaPrimaToolStripMenuItem.Text = "Muestreo Materia Prima";
            this.muestreoMateriaPrimaToolStripMenuItem.Click += new System.EventHandler(this.muestreoMateriaPrimaToolStripMenuItem_Click);
            // 
            // materiaProductoTerminadoToolStripMenuItem
            // 
            this.materiaProductoTerminadoToolStripMenuItem.Name = "materiaProductoTerminadoToolStripMenuItem";
            this.materiaProductoTerminadoToolStripMenuItem.Size = new System.Drawing.Size(275, 26);
            this.materiaProductoTerminadoToolStripMenuItem.Text = "Materia Producto Terminado";
            this.materiaProductoTerminadoToolStripMenuItem.Click += new System.EventHandler(this.materiaProductoTerminadoToolStripMenuItem_Click);
            // 
            // reporteDeExistenciasToolStripMenuItem
            // 
            this.reporteDeExistenciasToolStripMenuItem.Name = "reporteDeExistenciasToolStripMenuItem";
            this.reporteDeExistenciasToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.reporteDeExistenciasToolStripMenuItem.Text = "Reporte de Existencias";
            this.reporteDeExistenciasToolStripMenuItem.Click += new System.EventHandler(this.reporteDeExistenciasToolStripMenuItem_Click);
            // 
            // contenedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1546, 847);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "contenedor";
            this.Text = "contenedor";
            this.Load += new System.EventHandler(this.contenedor_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mantenimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paginaPrincipalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bodegaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productoTerminadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materiaPrimaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem muestreoMateriaPrimaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materiaProductoTerminadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeExistenciasToolStripMenuItem;
    }
}