namespace CapaVistaMRP
{
    partial class MDI_MRP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDI_MRP));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeProduccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoProcesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoConfiguracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoInvetarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoUnidadDeMedidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenesPendientesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.productosEnProcesoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.estadisticasPorFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosEspecialesCRMToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.seguridadToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.Dgv_enProceso = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Dgv_ordenespen = new System.Windows.Forms.DataGridView();
            this.Dgv_terminadas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_enProceso)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_ordenespen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_terminadas)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.gestionDeProduccionToolStripMenuItem,
            this.mantenimientosToolStripMenuItem,
            this.toolsMenu,
            this.helpMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1397, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator3,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator4,
            this.printToolStripMenuItem,
            this.printPreviewToolStripMenuItem,
            this.printSetupToolStripMenuItem,
            this.toolStripSeparator5,
            this.exitToolStripMenuItem});
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(81, 24);
            this.fileMenu.Text = "&Archivo";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(276, 26);
            this.newToolStripMenuItem.Text = "&Nuevo";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.ShowNewForm);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(276, 26);
            this.openToolStripMenuItem.Text = "&Abrir";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenFile);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(273, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(276, 26);
            this.saveToolStripMenuItem.Text = "&Guardar";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(276, 26);
            this.saveAsToolStripMenuItem.Text = "Guardar &como";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(273, 6);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(276, 26);
            this.printToolStripMenuItem.Text = "&Imprimir";
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printPreviewToolStripMenuItem.Image")));
            this.printPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(276, 26);
            this.printPreviewToolStripMenuItem.Text = "&Vista previa de impresión";
            // 
            // printSetupToolStripMenuItem
            // 
            this.printSetupToolStripMenuItem.Name = "printSetupToolStripMenuItem";
            this.printSetupToolStripMenuItem.Size = new System.Drawing.Size(276, 26);
            this.printSetupToolStripMenuItem.Text = "Configurar impresión";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(273, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(276, 26);
            this.exitToolStripMenuItem.Text = "&Salir";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolsStripMenuItem_Click);
            // 
            // gestionDeProduccionToolStripMenuItem
            // 
            this.gestionDeProduccionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoEmpleadosToolStripMenuItem,
            this.mantenimientoProcesosToolStripMenuItem,
            this.mantenimientoConfiguracionToolStripMenuItem,
            this.mantenimientoInvetarioToolStripMenuItem,
            this.mantenimientoUnidadDeMedidaToolStripMenuItem,
            this.productoToolStripMenuItem});
            this.gestionDeProduccionToolStripMenuItem.Name = "gestionDeProduccionToolStripMenuItem";
            this.gestionDeProduccionToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.gestionDeProduccionToolStripMenuItem.Text = "Mantenimientos";
            this.gestionDeProduccionToolStripMenuItem.Click += new System.EventHandler(this.GestionDeProduccionToolStripMenuItem_Click);
            // 
            // mantenimientoEmpleadosToolStripMenuItem
            // 
            this.mantenimientoEmpleadosToolStripMenuItem.Name = "mantenimientoEmpleadosToolStripMenuItem";
            this.mantenimientoEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(394, 26);
            this.mantenimientoEmpleadosToolStripMenuItem.Text = "4001 - Mantenimiento Empleados";
            this.mantenimientoEmpleadosToolStripMenuItem.Click += new System.EventHandler(this.MantenimientoEmpleadosToolStripMenuItem_Click);
            // 
            // mantenimientoProcesosToolStripMenuItem
            // 
            this.mantenimientoProcesosToolStripMenuItem.Name = "mantenimientoProcesosToolStripMenuItem";
            this.mantenimientoProcesosToolStripMenuItem.Size = new System.Drawing.Size(394, 26);
            this.mantenimientoProcesosToolStripMenuItem.Text = "4002 - Mantenimiento Procesos y Recetas";
            this.mantenimientoProcesosToolStripMenuItem.Click += new System.EventHandler(this.MantenimientoProcesosToolStripMenuItem_Click);
            // 
            // mantenimientoConfiguracionToolStripMenuItem
            // 
            this.mantenimientoConfiguracionToolStripMenuItem.Name = "mantenimientoConfiguracionToolStripMenuItem";
            this.mantenimientoConfiguracionToolStripMenuItem.Size = new System.Drawing.Size(394, 26);
            this.mantenimientoConfiguracionToolStripMenuItem.Text = "4003 - Mantenimiento Configuracion";
            this.mantenimientoConfiguracionToolStripMenuItem.Click += new System.EventHandler(this.MantenimientoConfiguracionToolStripMenuItem_Click);
            // 
            // mantenimientoInvetarioToolStripMenuItem
            // 
            this.mantenimientoInvetarioToolStripMenuItem.Name = "mantenimientoInvetarioToolStripMenuItem";
            this.mantenimientoInvetarioToolStripMenuItem.Size = new System.Drawing.Size(394, 26);
            this.mantenimientoInvetarioToolStripMenuItem.Text = "4004 - Mantenimiento Invetario";
            this.mantenimientoInvetarioToolStripMenuItem.Click += new System.EventHandler(this.MantenimientoInvetarioToolStripMenuItem_Click);
            // 
            // mantenimientoUnidadDeMedidaToolStripMenuItem
            // 
            this.mantenimientoUnidadDeMedidaToolStripMenuItem.Name = "mantenimientoUnidadDeMedidaToolStripMenuItem";
            this.mantenimientoUnidadDeMedidaToolStripMenuItem.Size = new System.Drawing.Size(394, 26);
            this.mantenimientoUnidadDeMedidaToolStripMenuItem.Text = "4005 - Mantenimiento Unidad de Medida";
            this.mantenimientoUnidadDeMedidaToolStripMenuItem.Click += new System.EventHandler(this.MantenimientoUnidadDeMedidaToolStripMenuItem_Click);
            // 
            // productoToolStripMenuItem
            // 
            this.productoToolStripMenuItem.Name = "productoToolStripMenuItem";
            this.productoToolStripMenuItem.Size = new System.Drawing.Size(394, 26);
            this.productoToolStripMenuItem.Text = "1001 - Mantenimiento Producto ";
            this.productoToolStripMenuItem.Click += new System.EventHandler(this.ProductoToolStripMenuItem_Click);
            // 
            // mantenimientosToolStripMenuItem
            // 
            this.mantenimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordenesPendientesToolStripMenuItem1,
            this.productosEnProcesoToolStripMenuItem1,
            this.estadisticasPorFechaToolStripMenuItem,
            this.pedidosEspecialesCRMToolStripMenuItem1});
            this.mantenimientosToolStripMenuItem.Name = "mantenimientosToolStripMenuItem";
            this.mantenimientosToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.mantenimientosToolStripMenuItem.Text = "Procesos";
            this.mantenimientosToolStripMenuItem.Click += new System.EventHandler(this.MantenimientosToolStripMenuItem_Click);
            // 
            // ordenesPendientesToolStripMenuItem1
            // 
            this.ordenesPendientesToolStripMenuItem1.Name = "ordenesPendientesToolStripMenuItem1";
            this.ordenesPendientesToolStripMenuItem1.Size = new System.Drawing.Size(315, 26);
            this.ordenesPendientesToolStripMenuItem1.Text = "4101 - Ordenes Pendientes";
            this.ordenesPendientesToolStripMenuItem1.Click += new System.EventHandler(this.OrdenesPendientesToolStripMenuItem1_Click);
            // 
            // productosEnProcesoToolStripMenuItem1
            // 
            this.productosEnProcesoToolStripMenuItem1.Name = "productosEnProcesoToolStripMenuItem1";
            this.productosEnProcesoToolStripMenuItem1.Size = new System.Drawing.Size(315, 26);
            this.productosEnProcesoToolStripMenuItem1.Text = "4102 - Productos en Proceso";
            this.productosEnProcesoToolStripMenuItem1.Click += new System.EventHandler(this.ProductosEnProcesoToolStripMenuItem1_Click);
            // 
            // estadisticasPorFechaToolStripMenuItem
            // 
            this.estadisticasPorFechaToolStripMenuItem.Name = "estadisticasPorFechaToolStripMenuItem";
            this.estadisticasPorFechaToolStripMenuItem.Size = new System.Drawing.Size(315, 26);
            this.estadisticasPorFechaToolStripMenuItem.Text = "4103 - Estadisticas Por Fecha";
            this.estadisticasPorFechaToolStripMenuItem.Click += new System.EventHandler(this.EstadisticasPorFechaToolStripMenuItem_Click);
            // 
            // pedidosEspecialesCRMToolStripMenuItem1
            // 
            this.pedidosEspecialesCRMToolStripMenuItem1.Name = "pedidosEspecialesCRMToolStripMenuItem1";
            this.pedidosEspecialesCRMToolStripMenuItem1.Size = new System.Drawing.Size(315, 26);
            this.pedidosEspecialesCRMToolStripMenuItem1.Text = "2101 - Pedidos Especiales CRM";
            this.pedidosEspecialesCRMToolStripMenuItem1.Click += new System.EventHandler(this.PedidosEspecialesCRMToolStripMenuItem1_Click);
            // 
            // toolsMenu
            // 
            this.toolsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seguridadToolStripMenuItem1});
            this.toolsMenu.Name = "toolsMenu";
            this.toolsMenu.Size = new System.Drawing.Size(119, 24);
            this.toolsMenu.Text = "&Herramientas";
            // 
            // seguridadToolStripMenuItem1
            // 
            this.seguridadToolStripMenuItem1.Name = "seguridadToolStripMenuItem1";
            this.seguridadToolStripMenuItem1.Size = new System.Drawing.Size(166, 26);
            this.seguridadToolStripMenuItem1.Text = "Seguridad";
            this.seguridadToolStripMenuItem1.Click += new System.EventHandler(this.SeguridadToolStripMenuItem1_Click);
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator8,
            this.aboutToolStripMenuItem});
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(71, 24);
            this.helpMenu.Text = "Ay&uda";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(221, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.aboutToolStripMenuItem.Text = "&Acerca de MRP";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblUsuario});
            this.statusStrip1.Location = new System.Drawing.Point(0, 627);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1397, 26);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(57, 20);
            this.toolStripStatusLabel1.Text = "usuario";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.ToolStripStatusLabel1_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(18, 20);
            this.lblUsuario.Text = "...";
            // 
            // Dgv_enProceso
            // 
            this.Dgv_enProceso.AllowUserToAddRows = false;
            this.Dgv_enProceso.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_enProceso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_enProceso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dgv_enProceso.Location = new System.Drawing.Point(468, 18);
            this.Dgv_enProceso.Name = "Dgv_enProceso";
            this.Dgv_enProceso.ReadOnly = true;
            this.Dgv_enProceso.RowHeadersWidth = 51;
            this.Dgv_enProceso.RowTemplate.Height = 24;
            this.Dgv_enProceso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_enProceso.Size = new System.Drawing.Size(459, 57);
            this.Dgv_enProceso.TabIndex = 21;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Dgv_ordenespen, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Dgv_enProceso, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Dgv_terminadas, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 549);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1397, 78);
            this.tableLayoutPanel1.TabIndex = 22;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.TableLayoutPanel1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(933, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(461, 15);
            this.label3.TabIndex = 26;
            this.label3.Text = "Producto Terminado";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(468, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(459, 15);
            this.label2.TabIndex = 25;
            this.label2.Text = "Ordenes Pendientes";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Dgv_ordenespen
            // 
            this.Dgv_ordenespen.AllowUserToAddRows = false;
            this.Dgv_ordenespen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_ordenespen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_ordenespen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dgv_ordenespen.Location = new System.Drawing.Point(3, 18);
            this.Dgv_ordenespen.Name = "Dgv_ordenespen";
            this.Dgv_ordenespen.ReadOnly = true;
            this.Dgv_ordenespen.RowHeadersWidth = 51;
            this.Dgv_ordenespen.RowTemplate.Height = 24;
            this.Dgv_ordenespen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_ordenespen.Size = new System.Drawing.Size(459, 57);
            this.Dgv_ordenespen.TabIndex = 23;
            // 
            // Dgv_terminadas
            // 
            this.Dgv_terminadas.AllowUserToAddRows = false;
            this.Dgv_terminadas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_terminadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_terminadas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dgv_terminadas.Location = new System.Drawing.Point(933, 18);
            this.Dgv_terminadas.Name = "Dgv_terminadas";
            this.Dgv_terminadas.ReadOnly = true;
            this.Dgv_terminadas.RowHeadersWidth = 51;
            this.Dgv_terminadas.RowTemplate.Height = 24;
            this.Dgv_terminadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_terminadas.Size = new System.Drawing.Size(461, 57);
            this.Dgv_terminadas.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(459, 15);
            this.label1.TabIndex = 24;
            this.label1.Text = "Producto En Proceso";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 15000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 60000;
            this.timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // MDI_MRP
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1397, 653);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MDI_MRP";
            this.Text = "MDI_MRP";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MDI_MRP_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_enProceso)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_ordenespen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_terminadas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem printSetupToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsMenu;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem gestionDeProduccionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoEmpleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoProcesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoConfiguracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordenesPendientesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem productosEnProcesoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pedidosEspecialesCRMToolStripMenuItem1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblUsuario;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoInvetarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seguridadToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem productoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadisticasPorFechaToolStripMenuItem;
        private System.Windows.Forms.DataGridView Dgv_enProceso;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView Dgv_ordenespen;
        private System.Windows.Forms.DataGridView Dgv_terminadas;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoUnidadDeMedidaToolStripMenuItem;
        private System.Windows.Forms.Timer timer2;
    }
}



