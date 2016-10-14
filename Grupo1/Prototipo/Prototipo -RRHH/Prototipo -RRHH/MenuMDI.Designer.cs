namespace Prototipo__RRHH
{
    partial class MenuMDI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuMDI));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.rRHHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nominasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.comisionDeVendedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planillaIGSSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rRHHToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // rRHHToolStripMenuItem
            // 
            this.rRHHToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nominasToolStripMenuItem,
            this.empleadosToolStripMenuItem,
            this.comisionDeVendedorToolStripMenuItem,
            this.planillaIGSSToolStripMenuItem});
            this.rRHHToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("rRHHToolStripMenuItem.Image")));
            this.rRHHToolStripMenuItem.Name = "rRHHToolStripMenuItem";
            this.rRHHToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.rRHHToolStripMenuItem.Text = "RRHH";
            this.rRHHToolStripMenuItem.Click += new System.EventHandler(this.rRHHToolStripMenuItem_Click);
            // 
            // nominasToolStripMenuItem
            // 
            this.nominasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nominasToolStripMenuItem.Image")));
            this.nominasToolStripMenuItem.Name = "nominasToolStripMenuItem";
            this.nominasToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.nominasToolStripMenuItem.Text = "Prestamos";
            this.nominasToolStripMenuItem.Click += new System.EventHandler(this.nominasToolStripMenuItem_Click);
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            this.empleadosToolStripMenuItem.Click += new System.EventHandler(this.empleadosToolStripMenuItem_Click);
            // 
            // comisionDeVendedorToolStripMenuItem
            // 
            this.comisionDeVendedorToolStripMenuItem.Name = "comisionDeVendedorToolStripMenuItem";
            this.comisionDeVendedorToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.comisionDeVendedorToolStripMenuItem.Text = "Comision de vendedor";
            this.comisionDeVendedorToolStripMenuItem.Click += new System.EventHandler(this.comisionDeVendedorToolStripMenuItem_Click);
            // 
            // planillaIGSSToolStripMenuItem
            // 
            this.planillaIGSSToolStripMenuItem.Name = "planillaIGSSToolStripMenuItem";
            this.planillaIGSSToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.planillaIGSSToolStripMenuItem.Text = "Planilla IGSS";
            this.planillaIGSSToolStripMenuItem.Click += new System.EventHandler(this.planillaIGSSToolStripMenuItem_Click);
            // 
            // MenuMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MenuMDI";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel San Carlos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem rRHHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nominasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comisionDeVendedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planillaIGSSToolStripMenuItem;
    }
}



