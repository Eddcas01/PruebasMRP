namespace CapaVistaMRP
{
    partial class mantproductopovis
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
            this.navegador1 = new CapaDeDiseno.Navegador();
            this.SuspendLayout();
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.Color.White;
            this.navegador1.Font = new System.Drawing.Font("Century Gothic", 6.8F, System.Drawing.FontStyle.Bold);
            this.navegador1.Location = new System.Drawing.Point(-2, 0);
            this.navegador1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(991, 750);
            this.navegador1.TabIndex = 0;
            this.navegador1.Load += new System.EventHandler(this.Navegador1_Load);
            // 
            // mantproductopovis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 704);
            this.Controls.Add(this.navegador1);
            this.Name = "mantproductopovis";
            this.Text = "1001.1 - Mantenimiento Productos";
            this.ResumeLayout(false);

        }

        #endregion

        private CapaDeDiseno.Navegador navegador1;
    }
}