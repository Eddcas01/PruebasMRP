namespace CapaVistaMRP
{
    partial class procesoProduccion
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_para = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Txt_idproceso = new System.Windows.Forms.TextBox();
            this.Cmb_producto = new CapaVista.Combo();
            this.label7 = new System.Windows.Forms.Label();
            this.Txt_tiempopp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_descripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgb_produccionProceso = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Btn_actualizar = new System.Windows.Forms.Button();
            this.Btn_eliminar = new System.Windows.Forms.Button();
            this.Btn_insertar = new System.Windows.Forms.Button();
            this.Btn_Receta = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgb_produccionProceso)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(132)))), ((int)(((byte)(197)))));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.42921F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.5708F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1140, 130);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(132)))), ((int)(((byte)(197)))));
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(837, 130);
            this.label5.TabIndex = 8;
            this.label5.Text = "Proceso de Produccion";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(132)))), ((int)(((byte)(197)))));
            this.pictureBox1.BackgroundImage = global::CapaVistaMRP.Properties.Resources.factory;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(846, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 124);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_para);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.Txt_idproceso);
            this.groupBox1.Controls.Add(this.Cmb_producto);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.Txt_tiempopp);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Txt_descripcion);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 148);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(929, 206);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Proceso";
            // 
            // txt_para
            // 
            this.txt_para.Location = new System.Drawing.Point(202, 122);
            this.txt_para.Name = "txt_para";
            this.txt_para.Size = new System.Drawing.Size(170, 30);
            this.txt_para.TabIndex = 20;
            this.txt_para.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_para_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 129);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 23);
            this.label10.TabIndex = 19;
            this.label10.Text = "Proceso Para";
            // 
            // Txt_idproceso
            // 
            this.Txt_idproceso.Location = new System.Drawing.Point(202, 37);
            this.Txt_idproceso.Name = "Txt_idproceso";
            this.Txt_idproceso.Size = new System.Drawing.Size(44, 30);
            this.Txt_idproceso.TabIndex = 18;
            // 
            // Cmb_producto
            // 
            this.Cmb_producto.Location = new System.Drawing.Point(202, 80);
            this.Cmb_producto.Margin = new System.Windows.Forms.Padding(8);
            this.Cmb_producto.Name = "Cmb_producto";
            this.Cmb_producto.Size = new System.Drawing.Size(170, 31);
            this.Cmb_producto.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(387, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 23);
            this.label7.TabIndex = 9;
            this.label7.Text = "Descripción";
            // 
            // Txt_tiempopp
            // 
            this.Txt_tiempopp.Location = new System.Drawing.Point(272, 158);
            this.Txt_tiempopp.Name = "Txt_tiempopp";
            this.Txt_tiempopp.Size = new System.Drawing.Size(100, 30);
            this.Txt_tiempopp.TabIndex = 7;
            this.Txt_tiempopp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_tiempopp_KeyPress);
            this.Txt_tiempopp.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_tiempopp_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(255, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "tiempo por producto \"min\"";
            // 
            // Txt_descripcion
            // 
            this.Txt_descripcion.Location = new System.Drawing.Point(391, 71);
            this.Txt_descripcion.Multiline = true;
            this.Txt_descripcion.Name = "Txt_descripcion";
            this.Txt_descripcion.Size = new System.Drawing.Size(519, 129);
            this.Txt_descripcion.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "no_proceso";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Producto";
            // 
            // dgb_produccionProceso
            // 
            this.dgb_produccionProceso.AllowUserToAddRows = false;
            this.dgb_produccionProceso.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgb_produccionProceso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgb_produccionProceso.Location = new System.Drawing.Point(10, 360);
            this.dgb_produccionProceso.Name = "dgb_produccionProceso";
            this.dgb_produccionProceso.ReadOnly = true;
            this.dgb_produccionProceso.RowHeadersWidth = 51;
            this.dgb_produccionProceso.RowTemplate.Height = 24;
            this.dgb_produccionProceso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgb_produccionProceso.Size = new System.Drawing.Size(931, 150);
            this.dgb_produccionProceso.TabIndex = 14;
            this.dgb_produccionProceso.DoubleClick += new System.EventHandler(this.Dgb_produccionProceso_DoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 46);
            this.label3.TabIndex = 12;
            this.label3.Text = "Eliminar";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 46);
            this.label8.TabIndex = 14;
            this.label8.Text = "Guardar";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.label11, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.Btn_actualizar, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.Btn_eliminar, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.Btn_insertar, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.Btn_Receta, 0, 7);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(974, 136);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(111, 374);
            this.tableLayoutPanel2.TabIndex = 15;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.TableLayoutPanel2_Paint);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Location = new System.Drawing.Point(3, 276);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 46);
            this.label11.TabIndex = 18;
            this.label11.Text = "Crear Receta";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(3, 184);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 46);
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
            this.Btn_actualizar.Location = new System.Drawing.Point(3, 233);
            this.Btn_actualizar.Name = "Btn_actualizar";
            this.Btn_actualizar.Size = new System.Drawing.Size(105, 40);
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
            this.Btn_eliminar.Location = new System.Drawing.Point(3, 141);
            this.Btn_eliminar.Name = "Btn_eliminar";
            this.Btn_eliminar.Size = new System.Drawing.Size(105, 40);
            this.Btn_eliminar.TabIndex = 11;
            this.Btn_eliminar.UseVisualStyleBackColor = false;
            this.Btn_eliminar.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Btn_insertar
            // 
            this.Btn_insertar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(132)))), ((int)(((byte)(197)))));
            this.Btn_insertar.BackgroundImage = global::CapaVistaMRP.Properties.Resources._083_floppy_disk;
            this.Btn_insertar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_insertar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_insertar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(60)))), ((int)(((byte)(192)))));
            this.Btn_insertar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_insertar.Location = new System.Drawing.Point(3, 49);
            this.Btn_insertar.Name = "Btn_insertar";
            this.Btn_insertar.Size = new System.Drawing.Size(105, 40);
            this.Btn_insertar.TabIndex = 13;
            this.Btn_insertar.UseVisualStyleBackColor = false;
            this.Btn_insertar.Click += new System.EventHandler(this.Btn_insertar_Click);
            // 
            // Btn_Receta
            // 
            this.Btn_Receta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(132)))), ((int)(((byte)(197)))));
            this.Btn_Receta.BackgroundImage = global::CapaVistaMRP.Properties.Resources._144_add_file;
            this.Btn_Receta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Receta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Receta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(60)))), ((int)(((byte)(192)))));
            this.Btn_Receta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Receta.Location = new System.Drawing.Point(3, 325);
            this.Btn_Receta.Name = "Btn_Receta";
            this.Btn_Receta.Size = new System.Drawing.Size(105, 46);
            this.Btn_Receta.TabIndex = 17;
            this.Btn_Receta.UseVisualStyleBackColor = false;
            this.Btn_Receta.Click += new System.EventHandler(this.Btn_Receta_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::CapaVistaMRP.Properties.Resources.information;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(1078, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(59, 50);
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // procesoProduccion
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1140, 515);
            this.Controls.Add(this.dgb_produccionProceso);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "procesoProduccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "4002.1 - Mantenimiento Proceso";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgb_produccionProceso)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgb_produccionProceso;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Txt_tiempopp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_descripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_eliminar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button Btn_insertar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Btn_actualizar;
        private CapaVista.Combo Cmb_producto;
        private System.Windows.Forms.TextBox Txt_idproceso;
        private System.Windows.Forms.TextBox txt_para;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button Btn_Receta;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}