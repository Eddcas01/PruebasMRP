namespace MDI_MRP
{
    partial class combo
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
            this.lbl_amigo = new System.Windows.Forms.Label();
            this.combo1 = new CapaVista.Combo();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_amigo2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_amigo
            // 
            this.lbl_amigo.AutoSize = true;
            this.lbl_amigo.Location = new System.Drawing.Point(169, 228);
            this.lbl_amigo.Name = "lbl_amigo";
            this.lbl_amigo.Size = new System.Drawing.Size(46, 17);
            this.lbl_amigo.TabIndex = 1;
            this.lbl_amigo.Text = "label1";
            // 
            // combo1
            // 
            this.combo1.Location = new System.Drawing.Point(212, 94);
            this.combo1.Name = "combo1";
            this.combo1.Size = new System.Drawing.Size(318, 24);
            this.combo1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(301, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // lbl_amigo2
            // 
            this.lbl_amigo2.AutoSize = true;
            this.lbl_amigo2.Location = new System.Drawing.Point(169, 276);
            this.lbl_amigo2.Name = "lbl_amigo2";
            this.lbl_amigo2.Size = new System.Drawing.Size(46, 17);
            this.lbl_amigo2.TabIndex = 3;
            this.lbl_amigo2.Text = "label1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(301, 273);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(301, 317);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(458, 228);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(161, 22);
            this.textBox1.TabIndex = 7;
            // 
            // combo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lbl_amigo2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_amigo);
            this.Controls.Add(this.combo1);
            this.Name = "combo";
            this.Text = "combo";
            this.Load += new System.EventHandler(this.Combo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CapaVista.Combo combo1;
        private System.Windows.Forms.Label lbl_amigo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_amigo2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}