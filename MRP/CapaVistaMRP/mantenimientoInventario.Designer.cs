namespace CapaVistaMRP
{
    partial class mantenimientoInventario
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
            this.dgb_inventarios = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.Btn_actualizar = new System.Windows.Forms.Button();
            this.Btn_eliminar = new System.Windows.Forms.Button();
            this.Btn_insertar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_unidadmedida = new System.Windows.Forms.ComboBox();
            this.Txt_idinv = new System.Windows.Forms.TextBox();
            this.Nud_cantidad = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.Cmb_unm = new System.Windows.Forms.Label();
            this.cmb_config = new CapaVista.Combo();
            this.Cmb_prod = new CapaVista.Combo();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgb_inventarios)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_cantidad)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgb_inventarios
            // 
            this.dgb_inventarios.AllowUserToAddRows = false;
            this.dgb_inventarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgb_inventarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgb_inventarios.Location = new System.Drawing.Point(8, 353);
            this.dgb_inventarios.Name = "dgb_inventarios";
            this.dgb_inventarios.ReadOnly = true;
            this.dgb_inventarios.RowHeadersWidth = 51;
            this.dgb_inventarios.RowTemplate.Height = 24;
            this.dgb_inventarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgb_inventarios.Size = new System.Drawing.Size(977, 158);
            this.dgb_inventarios.TabIndex = 18;
            this.dgb_inventarios.DoubleClick += new System.EventHandler(this.Dgb_inventarios_DoubleClick);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.Btn_actualizar, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.Btn_eliminar, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.Btn_insertar, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(1027, 174);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.45741F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.93375F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.35016F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.72555F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.82019F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.201893F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(111, 317);
            this.tableLayoutPanel2.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(3, 190);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 34);
            this.label9.TabIndex = 16;
            this.label9.Text = "Modificar";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_actualizar
            // 
            this.Btn_actualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(132)))), ((int)(((byte)(197)))));
            this.Btn_actualizar.BackgroundImage = global::CapaVistaMRP.Properties.Resources._180_reload;
            this.Btn_actualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_actualizar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_actualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(60)))), ((int)(((byte)(192)))));
            this.Btn_actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_actualizar.Location = new System.Drawing.Point(3, 227);
            this.Btn_actualizar.Name = "Btn_actualizar";
            this.Btn_actualizar.Size = new System.Drawing.Size(105, 60);
            this.Btn_actualizar.TabIndex = 15;
            this.Btn_actualizar.UseVisualStyleBackColor = false;
            this.Btn_actualizar.Click += new System.EventHandler(this.Btn_actualizar_Click);
            // 
            // Btn_eliminar
            // 
            this.Btn_eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(132)))), ((int)(((byte)(197)))));
            this.Btn_eliminar.BackgroundImage = global::CapaVistaMRP.Properties.Resources._243_exit;
            this.Btn_eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_eliminar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_eliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(60)))), ((int)(((byte)(192)))));
            this.Btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_eliminar.Location = new System.Drawing.Point(3, 138);
            this.Btn_eliminar.Name = "Btn_eliminar";
            this.Btn_eliminar.Size = new System.Drawing.Size(105, 49);
            this.Btn_eliminar.TabIndex = 11;
            this.Btn_eliminar.UseVisualStyleBackColor = false;
            this.Btn_eliminar.Click += new System.EventHandler(this.Btn_eliminar_Click);
            // 
            // Btn_insertar
            // 
            this.Btn_insertar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(132)))), ((int)(((byte)(197)))));
            this.Btn_insertar.BackgroundImage = global::CapaVistaMRP.Properties.Resources._083_floppy_disk;
            this.Btn_insertar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_insertar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_insertar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(60)))), ((int)(((byte)(192)))));
            this.Btn_insertar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_insertar.Location = new System.Drawing.Point(3, 48);
            this.Btn_insertar.Name = "Btn_insertar";
            this.Btn_insertar.Size = new System.Drawing.Size(105, 43);
            this.Btn_insertar.TabIndex = 13;
            this.Btn_insertar.UseVisualStyleBackColor = false;
            this.Btn_insertar.Click += new System.EventHandler(this.Btn_insertar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 45);
            this.label8.TabIndex = 14;
            this.label8.Text = "Guardar";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 41);
            this.label3.TabIndex = 12;
            this.label3.Text = "Eliminar";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_unidadmedida);
            this.groupBox1.Controls.Add(this.Txt_idinv);
            this.groupBox1.Controls.Add(this.Nud_cantidad);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.Cmb_unm);
            this.groupBox1.Controls.Add(this.cmb_config);
            this.groupBox1.Controls.Add(this.Cmb_prod);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(985, 206);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Proceso";
            // 
            // cmb_unidadmedida
            // 
            this.cmb_unidadmedida.FormattingEnabled = true;
            this.cmb_unidadmedida.Location = new System.Drawing.Point(791, 86);
            this.cmb_unidadmedida.Name = "cmb_unidadmedida";
            this.cmb_unidadmedida.Size = new System.Drawing.Size(146, 30);
            this.cmb_unidadmedida.TabIndex = 18;
            this.cmb_unidadmedida.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cmb_unidadmedida_KeyPress);
            // 
            // Txt_idinv
            // 
            this.Txt_idinv.Location = new System.Drawing.Point(196, 38);
            this.Txt_idinv.Name = "Txt_idinv";
            this.Txt_idinv.Size = new System.Drawing.Size(44, 30);
            this.Txt_idinv.TabIndex = 17;
            // 
            // Nud_cantidad
            // 
            this.Nud_cantidad.DecimalPlaces = 2;
            this.Nud_cantidad.Location = new System.Drawing.Point(791, 41);
            this.Nud_cantidad.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Nud_cantidad.Name = "Nud_cantidad";
            this.Nud_cantidad.Size = new System.Drawing.Size(146, 30);
            this.Nud_cantidad.TabIndex = 16;
            this.Nud_cantidad.Enter += new System.EventHandler(this.Nud_cantidad_Enter);
            this.Nud_cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Nud_cantidad_KeyPress);
            this.Nud_cantidad.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Nud_cantidad_MouseClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(447, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(224, 23);
            this.label10.TabIndex = 15;
            this.label10.Text = "Cantidad en inventario";
            // 
            // Cmb_unm
            // 
            this.Cmb_unm.AutoSize = true;
            this.Cmb_unm.Location = new System.Drawing.Point(447, 89);
            this.Cmb_unm.Name = "Cmb_unm";
            this.Cmb_unm.Size = new System.Drawing.Size(187, 23);
            this.Cmb_unm.TabIndex = 13;
            this.Cmb_unm.Text = "Unidad de medida";
            // 
            // cmb_config
            // 
            this.cmb_config.Location = new System.Drawing.Point(196, 129);
            this.cmb_config.Margin = new System.Windows.Forms.Padding(15);
            this.cmb_config.Name = "cmb_config";
            this.cmb_config.Size = new System.Drawing.Size(182, 41);
            this.cmb_config.TabIndex = 12;
            // 
            // Cmb_prod
            // 
            this.Cmb_prod.Location = new System.Drawing.Point(196, 83);
            this.Cmb_prod.Margin = new System.Windows.Forms.Padding(15);
            this.Cmb_prod.Name = "Cmb_prod";
            this.Cmb_prod.Size = new System.Drawing.Size(182, 33);
            this.Cmb_prod.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "configuración";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "No_Inventario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Producto";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(132)))), ((int)(((byte)(197)))));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.42921F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.5708F));
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1171, 130);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(132)))), ((int)(((byte)(197)))));
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(912, 130);
            this.label5.TabIndex = 8;
            this.label5.Text = "Mantenimiento de Inventario";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(132)))), ((int)(((byte)(197)))));
            this.pictureBox1.BackgroundImage = global::CapaVistaMRP.Properties.Resources.factory;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(921, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(247, 124);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // mantenimientoInventario
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1171, 523);
            this.Controls.Add(this.dgb_inventarios);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "mantenimientoInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "4004 - Mantenimiento Inventario";
            ((System.ComponentModel.ISupportInitialize)(this.dgb_inventarios)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_cantidad)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgb_inventarios;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Btn_actualizar;
        private System.Windows.Forms.Button Btn_eliminar;
        private System.Windows.Forms.Button Btn_insertar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CapaVista.Combo cmb_config;
        private CapaVista.Combo Cmb_prod;
        private System.Windows.Forms.Label Cmb_unm;
        private System.Windows.Forms.NumericUpDown Nud_cantidad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Txt_idinv;
        private System.Windows.Forms.ComboBox cmb_unidadmedida;
    }
}