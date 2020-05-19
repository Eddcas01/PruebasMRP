namespace CapaVistaMRP
{
    partial class modificarOrden
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
            this.Dgb_modificarOd = new System.Windows.Forms.DataGridView();
            this.grb_detalle = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_productos = new CapaVista.Combo();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Btn_agregar = new System.Windows.Forms.Button();
            this.Btn_eliminar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Nud_cantidad = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_cantidad = new System.Windows.Forms.Label();
            this.grb_encabezado = new System.Windows.Forms.GroupBox();
            this.Dtp_FechaOrden = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.Btn_actualizarFecha = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Chb_editar = new System.Windows.Forms.CheckBox();
            this.Dtp_fechalim = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_tipo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_noOrden = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dgb_modificarOd)).BeginInit();
            this.grb_detalle.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_cantidad)).BeginInit();
            this.grb_encabezado.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgb_modificarOd
            // 
            this.Dgb_modificarOd.AllowUserToAddRows = false;
            this.Dgb_modificarOd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgb_modificarOd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgb_modificarOd.Location = new System.Drawing.Point(10, 546);
            this.Dgb_modificarOd.Name = "Dgb_modificarOd";
            this.Dgb_modificarOd.ReadOnly = true;
            this.Dgb_modificarOd.RowHeadersWidth = 51;
            this.Dgb_modificarOd.RowTemplate.Height = 24;
            this.Dgb_modificarOd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgb_modificarOd.Size = new System.Drawing.Size(685, 154);
            this.Dgb_modificarOd.TabIndex = 20;
            // 
            // grb_detalle
            // 
            this.grb_detalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grb_detalle.Controls.Add(this.tableLayoutPanel4);
            this.grb_detalle.Controls.Add(this.cmb_productos);
            this.grb_detalle.Controls.Add(this.tableLayoutPanel2);
            this.grb_detalle.Controls.Add(this.Nud_cantidad);
            this.grb_detalle.Controls.Add(this.label3);
            this.grb_detalle.Controls.Add(this.lbl_cantidad);
            this.grb_detalle.ForeColor = System.Drawing.Color.Black;
            this.grb_detalle.Location = new System.Drawing.Point(10, 346);
            this.grb_detalle.Name = "grb_detalle";
            this.grb_detalle.Size = new System.Drawing.Size(685, 180);
            this.grb_detalle.TabIndex = 18;
            this.grb_detalle.TabStop = false;
            this.grb_detalle.Text = "Detalle";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.button1, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(568, 65);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(111, 100);
            this.tableLayoutPanel4.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(132)))), ((int)(((byte)(197)))));
            this.button1.BackgroundImage = global::CapaVistaMRP.Properties.Resources._157_paper_plane;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(60)))), ((int)(((byte)(192)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(3, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 38);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 56);
            this.label2.TabIndex = 14;
            this.label2.Text = "Actualizar Orden";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmb_productos
            // 
            this.cmb_productos.Location = new System.Drawing.Point(196, 55);
            this.cmb_productos.Margin = new System.Windows.Forms.Padding(8);
            this.cmb_productos.Name = "cmb_productos";
            this.cmb_productos.Size = new System.Drawing.Size(139, 29);
            this.cmb_productos.TabIndex = 20;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.47368F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.52632F));
            this.tableLayoutPanel2.Controls.Add(this.Btn_agregar, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.Btn_eliminar, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label9, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(360, 65);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(190, 100);
            this.tableLayoutPanel2.TabIndex = 19;
            // 
            // Btn_agregar
            // 
            this.Btn_agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(132)))), ((int)(((byte)(197)))));
            this.Btn_agregar.BackgroundImage = global::CapaVistaMRP.Properties.Resources._159_pencil;
            this.Btn_agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_agregar.FlatAppearance.BorderSize = 0;
            this.Btn_agregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(60)))), ((int)(((byte)(192)))));
            this.Btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_agregar.ForeColor = System.Drawing.Color.Black;
            this.Btn_agregar.Location = new System.Drawing.Point(3, 53);
            this.Btn_agregar.Name = "Btn_agregar";
            this.Btn_agregar.Size = new System.Drawing.Size(87, 40);
            this.Btn_agregar.TabIndex = 11;
            this.Btn_agregar.UseVisualStyleBackColor = false;
            this.Btn_agregar.Click += new System.EventHandler(this.Btn_agregar_Click);
            // 
            // Btn_eliminar
            // 
            this.Btn_eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(132)))), ((int)(((byte)(197)))));
            this.Btn_eliminar.BackgroundImage = global::CapaVistaMRP.Properties.Resources._243_exit;
            this.Btn_eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_eliminar.FlatAppearance.BorderSize = 0;
            this.Btn_eliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(60)))), ((int)(((byte)(192)))));
            this.Btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_eliminar.ForeColor = System.Drawing.Color.Black;
            this.Btn_eliminar.Location = new System.Drawing.Point(96, 53);
            this.Btn_eliminar.Name = "Btn_eliminar";
            this.Btn_eliminar.Size = new System.Drawing.Size(91, 40);
            this.Btn_eliminar.TabIndex = 12;
            this.Btn_eliminar.UseVisualStyleBackColor = false;
            this.Btn_eliminar.Click += new System.EventHandler(this.Btn_eliminar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 50);
            this.label8.TabIndex = 15;
            this.label8.Text = "Agregar";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(96, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 50);
            this.label9.TabIndex = 16;
            this.label9.Text = "Eliminar ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Nud_cantidad
            // 
            this.Nud_cantidad.Location = new System.Drawing.Point(235, 95);
            this.Nud_cantidad.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.Nud_cantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Nud_cantidad.Name = "Nud_cantidad";
            this.Nud_cantidad.Size = new System.Drawing.Size(100, 30);
            this.Nud_cantidad.TabIndex = 13;
            this.Nud_cantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Producto";
            // 
            // lbl_cantidad
            // 
            this.lbl_cantidad.AutoSize = true;
            this.lbl_cantidad.Location = new System.Drawing.Point(19, 97);
            this.lbl_cantidad.Name = "lbl_cantidad";
            this.lbl_cantidad.Size = new System.Drawing.Size(99, 23);
            this.lbl_cantidad.TabIndex = 0;
            this.lbl_cantidad.Text = "Cantidad";
            // 
            // grb_encabezado
            // 
            this.grb_encabezado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grb_encabezado.Controls.Add(this.Dtp_FechaOrden);
            this.grb_encabezado.Controls.Add(this.tableLayoutPanel3);
            this.grb_encabezado.Controls.Add(this.Chb_editar);
            this.grb_encabezado.Controls.Add(this.Dtp_fechalim);
            this.grb_encabezado.Controls.Add(this.label6);
            this.grb_encabezado.Controls.Add(this.lbl_tipo);
            this.grb_encabezado.Controls.Add(this.label4);
            this.grb_encabezado.Controls.Add(this.lbl_noOrden);
            this.grb_encabezado.Controls.Add(this.label1);
            this.grb_encabezado.Controls.Add(this.lbl_fecha);
            this.grb_encabezado.ForeColor = System.Drawing.Color.Black;
            this.grb_encabezado.Location = new System.Drawing.Point(10, 159);
            this.grb_encabezado.Name = "grb_encabezado";
            this.grb_encabezado.Size = new System.Drawing.Size(685, 166);
            this.grb_encabezado.TabIndex = 17;
            this.grb_encabezado.TabStop = false;
            this.grb_encabezado.Text = "Encabezado";
            this.grb_encabezado.Enter += new System.EventHandler(this.Grb_encabezado_Enter);
            // 
            // Dtp_FechaOrden
            // 
            this.Dtp_FechaOrden.Location = new System.Drawing.Point(172, 95);
            this.Dtp_FechaOrden.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.Dtp_FechaOrden.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.Dtp_FechaOrden.Name = "Dtp_FechaOrden";
            this.Dtp_FechaOrden.Size = new System.Drawing.Size(375, 30);
            this.Dtp_FechaOrden.TabIndex = 23;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.Btn_actualizarFecha, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(565, 66);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(111, 100);
            this.tableLayoutPanel3.TabIndex = 22;
            // 
            // Btn_actualizarFecha
            // 
            this.Btn_actualizarFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(132)))), ((int)(((byte)(197)))));
            this.Btn_actualizarFecha.BackgroundImage = global::CapaVistaMRP.Properties.Resources._157_paper_plane;
            this.Btn_actualizarFecha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_actualizarFecha.FlatAppearance.BorderSize = 0;
            this.Btn_actualizarFecha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(60)))), ((int)(((byte)(192)))));
            this.Btn_actualizarFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_actualizarFecha.ForeColor = System.Drawing.Color.Black;
            this.Btn_actualizarFecha.Location = new System.Drawing.Point(3, 59);
            this.Btn_actualizarFecha.Name = "Btn_actualizarFecha";
            this.Btn_actualizarFecha.Size = new System.Drawing.Size(105, 38);
            this.Btn_actualizarFecha.TabIndex = 10;
            this.Btn_actualizarFecha.UseVisualStyleBackColor = false;
            this.Btn_actualizarFecha.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 56);
            this.label7.TabIndex = 14;
            this.label7.Text = "Actualizar Fecha";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Chb_editar
            // 
            this.Chb_editar.AutoSize = true;
            this.Chb_editar.Location = new System.Drawing.Point(339, 62);
            this.Chb_editar.Name = "Chb_editar";
            this.Chb_editar.Size = new System.Drawing.Size(206, 27);
            this.Chb_editar.TabIndex = 21;
            this.Chb_editar.Text = "Editar Fecha Limite";
            this.Chb_editar.UseVisualStyleBackColor = true;
            this.Chb_editar.CheckedChanged += new System.EventHandler(this.Chb_editar_CheckedChanged);
            // 
            // Dtp_fechalim
            // 
            this.Dtp_fechalim.Location = new System.Drawing.Point(172, 133);
            this.Dtp_fechalim.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.Dtp_fechalim.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.Dtp_fechalim.Name = "Dtp_fechalim";
            this.Dtp_fechalim.Size = new System.Drawing.Size(375, 30);
            this.Dtp_fechalim.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 23);
            this.label6.TabIndex = 19;
            this.label6.Text = "Fecha Limite";
            // 
            // lbl_tipo
            // 
            this.lbl_tipo.AutoSize = true;
            this.lbl_tipo.Location = new System.Drawing.Point(168, 68);
            this.lbl_tipo.Name = "lbl_tipo";
            this.lbl_tipo.Size = new System.Drawing.Size(34, 23);
            this.lbl_tipo.TabIndex = 17;
            this.lbl_tipo.Text = "tip";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(17, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 23);
            this.label4.TabIndex = 16;
            this.label4.Text = "Tipo";
            // 
            // lbl_noOrden
            // 
            this.lbl_noOrden.AutoSize = true;
            this.lbl_noOrden.Location = new System.Drawing.Point(168, 29);
            this.lbl_noOrden.Name = "lbl_noOrden";
            this.lbl_noOrden.Size = new System.Drawing.Size(104, 23);
            this.lbl_noOrden.TabIndex = 7;
            this.lbl_noOrden.Text = "No. Orden";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(17, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "No. Orden";
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Location = new System.Drawing.Point(19, 101);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(72, 23);
            this.lbl_fecha.TabIndex = 0;
            this.lbl_fecha.Text = "Fecha ";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(132)))), ((int)(((byte)(197)))));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.7792F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.2208F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(707, 150);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(132)))), ((int)(((byte)(197)))));
            this.pictureBox1.BackgroundImage = global::CapaVistaMRP.Properties.Resources.factory;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(536, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 144);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(132)))), ((int)(((byte)(197)))));
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(527, 150);
            this.label5.TabIndex = 8;
            this.label5.Text = "Modificar Orden";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::CapaVistaMRP.Properties.Resources.information;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(647, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(57, 50);
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // modificarOrden
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(707, 737);
            this.Controls.Add(this.Dgb_modificarOd);
            this.Controls.Add(this.grb_detalle);
            this.Controls.Add(this.grb_encabezado);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "modificarOrden";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "4101.1 Modificar Orden";
            this.Load += new System.EventHandler(this.ModificarOrden_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgb_modificarOd)).EndInit();
            this.grb_detalle.ResumeLayout(false);
            this.grb_detalle.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_cantidad)).EndInit();
            this.grb_encabezado.ResumeLayout(false);
            this.grb_encabezado.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgb_modificarOd;
        private System.Windows.Forms.GroupBox grb_detalle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private CapaVista.Combo cmb_productos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button Btn_agregar;
        private System.Windows.Forms.Button Btn_eliminar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown Nud_cantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_cantidad;
        private System.Windows.Forms.GroupBox grb_encabezado;
        private System.Windows.Forms.DateTimePicker Dtp_fechalim;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_tipo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_noOrden;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox Chb_editar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button Btn_actualizarFecha;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker Dtp_FechaOrden;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}