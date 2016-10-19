using System;

namespace cuentas_corrientes
{
    partial class frmmenu
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
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.impresorasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catalogosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cotizacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuentasCorrientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deudaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.operacionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservacionDeHabitacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manejoDeEventosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearReporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroClienteContribuyenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.catalogosToolStripMenuItem,
            this.procesosToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(634, 31);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.cerrarSesionToolStripMenuItem,
            this.configuracionToolStripMenuItem});
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(67, 25);
            this.inicioToolStripMenuItem.Text = "Inicio ";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
            // 
            // configuracionToolStripMenuItem
            // 
            this.configuracionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.impresorasToolStripMenuItem});
            this.configuracionToolStripMenuItem.Name = "configuracionToolStripMenuItem";
            this.configuracionToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.configuracionToolStripMenuItem.Text = "Configuracion";
            // 
            // impresorasToolStripMenuItem
            // 
            this.impresorasToolStripMenuItem.Name = "impresorasToolStripMenuItem";
            this.impresorasToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.impresorasToolStripMenuItem.Text = "Impresoras";
            // 
            // catalogosToolStripMenuItem
            // 
            this.catalogosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.pedidoToolStripMenuItem,
            this.cotizacionToolStripMenuItem,
            this.facturacionToolStripMenuItem,
            this.cuentasCorrientesToolStripMenuItem});
            this.catalogosToolStripMenuItem.Name = "catalogosToolStripMenuItem";
            this.catalogosToolStripMenuItem.Size = new System.Drawing.Size(104, 25);
            this.catalogosToolStripMenuItem.Text = "Catalogos";
            this.catalogosToolStripMenuItem.Click += new System.EventHandler(this.catalogosToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroClienteToolStripMenuItem,
            this.registroClienteContribuyenteToolStripMenuItem});
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // pedidoToolStripMenuItem
            // 
            this.pedidoToolStripMenuItem.Name = "pedidoToolStripMenuItem";
            this.pedidoToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.pedidoToolStripMenuItem.Text = "Pedido";
            this.pedidoToolStripMenuItem.Click += new System.EventHandler(this.pedidoToolStripMenuItem_Click);
            // 
            // cotizacionToolStripMenuItem
            // 
            this.cotizacionToolStripMenuItem.Name = "cotizacionToolStripMenuItem";
            this.cotizacionToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.cotizacionToolStripMenuItem.Text = "Cotizacion";
            this.cotizacionToolStripMenuItem.Click += new System.EventHandler(this.cotizacionToolStripMenuItem_Click);
            // 
            // facturacionToolStripMenuItem
            // 
            this.facturacionToolStripMenuItem.Name = "facturacionToolStripMenuItem";
            this.facturacionToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.facturacionToolStripMenuItem.Text = "Facturacion";
            this.facturacionToolStripMenuItem.Click += new System.EventHandler(this.facturacionToolStripMenuItem_Click);
            // 
            // cuentasCorrientesToolStripMenuItem
            // 
            this.cuentasCorrientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deudaToolStripMenuItem1,
            this.operacionToolStripMenuItem1});
            this.cuentasCorrientesToolStripMenuItem.Name = "cuentasCorrientesToolStripMenuItem";
            this.cuentasCorrientesToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.cuentasCorrientesToolStripMenuItem.Text = "Cuentas corrientes";
            // 
            // deudaToolStripMenuItem1
            // 
            this.deudaToolStripMenuItem1.Name = "deudaToolStripMenuItem1";
            this.deudaToolStripMenuItem1.Size = new System.Drawing.Size(164, 26);
            this.deudaToolStripMenuItem1.Text = "Deuda";
            this.deudaToolStripMenuItem1.Click += new System.EventHandler(this.deudaToolStripMenuItem1_Click);
            // 
            // operacionToolStripMenuItem1
            // 
            this.operacionToolStripMenuItem1.Name = "operacionToolStripMenuItem1";
            this.operacionToolStripMenuItem1.Size = new System.Drawing.Size(164, 26);
            this.operacionToolStripMenuItem1.Text = "Operacion";
            this.operacionToolStripMenuItem1.Click += new System.EventHandler(this.operacionToolStripMenuItem1_Click);
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reservacionDeHabitacionToolStripMenuItem,
            this.manejoDeEventosToolStripMenuItem});
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(88, 25);
            this.procesosToolStripMenuItem.Text = "Procesos";
            // 
            // reservacionDeHabitacionToolStripMenuItem
            // 
            this.reservacionDeHabitacionToolStripMenuItem.Name = "reservacionDeHabitacionToolStripMenuItem";
            this.reservacionDeHabitacionToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.reservacionDeHabitacionToolStripMenuItem.Text = "Clientes";
            this.reservacionDeHabitacionToolStripMenuItem.Click += new System.EventHandler(this.reservacionDeHabitacionToolStripMenuItem_Click);
            // 
            // manejoDeEventosToolStripMenuItem
            // 
            this.manejoDeEventosToolStripMenuItem.Name = "manejoDeEventosToolStripMenuItem";
            this.manejoDeEventosToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.manejoDeEventosToolStripMenuItem.Text = "Cotizacion";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearReporteToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(91, 25);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // crearReporteToolStripMenuItem
            // 
            this.crearReporteToolStripMenuItem.Name = "crearReporteToolStripMenuItem";
            this.crearReporteToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.crearReporteToolStripMenuItem.Text = "Crear Reporte";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(75, 25);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // registroClienteToolStripMenuItem
            // 
            this.registroClienteToolStripMenuItem.Name = "registroClienteToolStripMenuItem";
            this.registroClienteToolStripMenuItem.Size = new System.Drawing.Size(314, 26);
            this.registroClienteToolStripMenuItem.Text = "Registro cliente";
            this.registroClienteToolStripMenuItem.Click += new System.EventHandler(this.registroClienteToolStripMenuItem_Click);
            // 
            // registroClienteContribuyenteToolStripMenuItem
            // 
            this.registroClienteContribuyenteToolStripMenuItem.Name = "registroClienteContribuyenteToolStripMenuItem";
            this.registroClienteContribuyenteToolStripMenuItem.Size = new System.Drawing.Size(314, 26);
            this.registroClienteContribuyenteToolStripMenuItem.Text = "Registro cliente contribuyente";
            this.registroClienteContribuyenteToolStripMenuItem.Click += new System.EventHandler(this.registroClienteContribuyenteToolStripMenuItem_Click);
            // 
            // frmmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 354);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmmenu";
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmmenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }                               

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem impresorasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catalogosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservacionDeHabitacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manejoDeEventosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearReporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cotizacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuentasCorrientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deudaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem operacionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem registroClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroClienteContribuyenteToolStripMenuItem;
    }
}

