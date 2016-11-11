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
            this.components = new System.ComponentModel.Container();
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
            this.existenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kardexToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.movimientosDeInventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_bitacora = new System.Windows.Forms.ToolStripMenuItem();
            this.configuracionesDeSeguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarAplicaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarAplicaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignacionPermisosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarPermisosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deshabilitarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perfilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearPerfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarPerfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarContraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
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
            this.menuStrip1.Size = new System.Drawing.Size(1134, 28);
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
            this.inicioToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("inicioToolStripMenuItem.Image")));
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
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
            this.mantenimientosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mantenimientosToolStripMenuItem.Image")));
            this.mantenimientosToolStripMenuItem.Name = "mantenimientosToolStripMenuItem";
            this.mantenimientosToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
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
            this.existenciasToolStripMenuItem,
            this.kardexToolStripMenuItem1,
            this.movimientosDeInventarioToolStripMenuItem});
            this.reporteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reporteToolStripMenuItem.Image")));
            this.reporteToolStripMenuItem.Name = "reporteToolStripMenuItem";
            this.reporteToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.reporteToolStripMenuItem.Text = "Reportes";
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
            this.ayudaToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_bitacora,
            this.configuracionesDeSeguridadToolStripMenuItem,
            this.asignacionPermisosToolStripMenuItem,
            this.perfilesToolStripMenuItem,
            this.cambiarContraseñaToolStripMenuItem,
            this.cerrarSesiónToolStripMenuItem});
            this.ayudaToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("ayudaToolStripMenuItem1.Image")));
            this.ayudaToolStripMenuItem1.Name = "ayudaToolStripMenuItem1";
            this.ayudaToolStripMenuItem1.Size = new System.Drawing.Size(92, 24);
            this.ayudaToolStripMenuItem1.Text = "Seguridad";
            // 
            // btn_bitacora
            // 
            this.btn_bitacora.Name = "btn_bitacora";
            this.btn_bitacora.Size = new System.Drawing.Size(232, 22);
            this.btn_bitacora.Text = "Bitacora";
            this.btn_bitacora.Click += new System.EventHandler(this.btn_bitacora_Click);
            // 
            // configuracionesDeSeguridadToolStripMenuItem
            // 
            this.configuracionesDeSeguridadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarAplicaciónToolStripMenuItem,
            this.modificarAplicaciónToolStripMenuItem});
            this.configuracionesDeSeguridadToolStripMenuItem.Name = "configuracionesDeSeguridadToolStripMenuItem";
            this.configuracionesDeSeguridadToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.configuracionesDeSeguridadToolStripMenuItem.Text = "Configuraciones de seguridad";
            // 
            // agregarAplicaciónToolStripMenuItem
            // 
            this.agregarAplicaciónToolStripMenuItem.Name = "agregarAplicaciónToolStripMenuItem";
            this.agregarAplicaciónToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.agregarAplicaciónToolStripMenuItem.Text = "Agregar aplicación";
            this.agregarAplicaciónToolStripMenuItem.Click += new System.EventHandler(this.agregarAplicaciónToolStripMenuItem_Click);
            // 
            // modificarAplicaciónToolStripMenuItem
            // 
            this.modificarAplicaciónToolStripMenuItem.Name = "modificarAplicaciónToolStripMenuItem";
            this.modificarAplicaciónToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.modificarAplicaciónToolStripMenuItem.Text = "Modificar aplicación";
            this.modificarAplicaciónToolStripMenuItem.Click += new System.EventHandler(this.modificarAplicaciónToolStripMenuItem_Click);
            // 
            // asignacionPermisosToolStripMenuItem
            // 
            this.asignacionPermisosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearToolStripMenuItem,
            this.editarPermisosToolStripMenuItem,
            this.deshabilitarToolStripMenuItem});
            this.asignacionPermisosToolStripMenuItem.Name = "asignacionPermisosToolStripMenuItem";
            this.asignacionPermisosToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.asignacionPermisosToolStripMenuItem.Text = "Usuarios";
            this.asignacionPermisosToolStripMenuItem.Click += new System.EventHandler(this.asignacionPermisosToolStripMenuItem_Click);
            // 
            // crearToolStripMenuItem
            // 
            this.crearToolStripMenuItem.Name = "crearToolStripMenuItem";
            this.crearToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.crearToolStripMenuItem.Text = "Crear";
            this.crearToolStripMenuItem.Click += new System.EventHandler(this.crearToolStripMenuItem_Click);
            // 
            // editarPermisosToolStripMenuItem
            // 
            this.editarPermisosToolStripMenuItem.Name = "editarPermisosToolStripMenuItem";
            this.editarPermisosToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.editarPermisosToolStripMenuItem.Text = "Editar permisos";
            this.editarPermisosToolStripMenuItem.Click += new System.EventHandler(this.editarPermisosToolStripMenuItem_Click);
            // 
            // deshabilitarToolStripMenuItem
            // 
            this.deshabilitarToolStripMenuItem.Name = "deshabilitarToolStripMenuItem";
            this.deshabilitarToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.deshabilitarToolStripMenuItem.Text = "Deshabilitar";
            this.deshabilitarToolStripMenuItem.Click += new System.EventHandler(this.deshabilitarToolStripMenuItem_Click);
            // 
            // perfilesToolStripMenuItem
            // 
            this.perfilesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearPerfilToolStripMenuItem,
            this.editarPerfilToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.perfilesToolStripMenuItem.Name = "perfilesToolStripMenuItem";
            this.perfilesToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.perfilesToolStripMenuItem.Text = "Perfiles";
            // 
            // crearPerfilToolStripMenuItem
            // 
            this.crearPerfilToolStripMenuItem.Name = "crearPerfilToolStripMenuItem";
            this.crearPerfilToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.crearPerfilToolStripMenuItem.Text = "Crear perfil";
            this.crearPerfilToolStripMenuItem.Click += new System.EventHandler(this.crearPerfilToolStripMenuItem_Click);
            // 
            // editarPerfilToolStripMenuItem
            // 
            this.editarPerfilToolStripMenuItem.Name = "editarPerfilToolStripMenuItem";
            this.editarPerfilToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.editarPerfilToolStripMenuItem.Text = "Editar perfil";
            this.editarPerfilToolStripMenuItem.Click += new System.EventHandler(this.editarPerfilToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // cambiarContraseñaToolStripMenuItem
            // 
            this.cambiarContraseñaToolStripMenuItem.Name = "cambiarContraseñaToolStripMenuItem";
            this.cambiarContraseñaToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.cambiarContraseñaToolStripMenuItem.Text = "Cambiar contraseña";
            this.cambiarContraseñaToolStripMenuItem.Click += new System.EventHandler(this.cambiarContraseñaToolStripMenuItem_Click);
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar sesión";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ayudaToolStripMenuItem.Image")));
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            this.ayudaToolStripMenuItem.Click += new System.EventHandler(this.ayudaToolStripMenuItem_Click);
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
            this.panel1.Location = new System.Drawing.Point(0, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(66, 604);
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
            this.toolTip1.SetToolTip(this.btn_nuevoprod, "Ir a lista de productos");
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
            this.toolTip1.SetToolTip(this.btn_exist, "Ir a existencias");
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
            this.toolTip1.SetToolTip(this.btn_mov, "Ir a movimientos");
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
            this.toolTip1.SetToolTip(this.btn_kardex, "Ir a kardex");
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
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1134, 702);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.ToolStripMenuItem btn_bitacora;
        private System.Windows.Forms.ToolStripMenuItem asignacionPermisosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuracionesDeSeguridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarAplicaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarPermisosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarAplicaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deshabilitarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perfilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearPerfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarPerfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarContraseñaToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}