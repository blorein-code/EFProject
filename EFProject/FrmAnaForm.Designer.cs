namespace EFProject
{
    partial class FrmAnaForm
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
            this.kategoriBtn = new System.Windows.Forms.Button();
            this.urunBtn = new System.Windows.Forms.Button();
            this.istatistikBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kategoriBtn
            // 
            this.kategoriBtn.Location = new System.Drawing.Point(31, 12);
            this.kategoriBtn.Name = "kategoriBtn";
            this.kategoriBtn.Size = new System.Drawing.Size(99, 107);
            this.kategoriBtn.TabIndex = 0;
            this.kategoriBtn.Text = "KATEGORİ İŞLEMLERİ";
            this.kategoriBtn.UseVisualStyleBackColor = true;
            this.kategoriBtn.Click += new System.EventHandler(this.kategoriBtn_Click);
            // 
            // urunBtn
            // 
            this.urunBtn.Location = new System.Drawing.Point(176, 12);
            this.urunBtn.Name = "urunBtn";
            this.urunBtn.Size = new System.Drawing.Size(99, 107);
            this.urunBtn.TabIndex = 1;
            this.urunBtn.Text = "ÜRÜN İŞLEMLERİ";
            this.urunBtn.UseVisualStyleBackColor = true;
            this.urunBtn.Click += new System.EventHandler(this.urunBtn_Click);
            // 
            // istatistikBtn
            // 
            this.istatistikBtn.Location = new System.Drawing.Point(327, 12);
            this.istatistikBtn.Name = "istatistikBtn";
            this.istatistikBtn.Size = new System.Drawing.Size(99, 107);
            this.istatistikBtn.TabIndex = 2;
            this.istatistikBtn.Text = "İSTATİSTİKLER";
            this.istatistikBtn.UseVisualStyleBackColor = true;
            // 
            // FrmAnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 132);
            this.Controls.Add(this.istatistikBtn);
            this.Controls.Add(this.urunBtn);
            this.Controls.Add(this.kategoriBtn);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAnaForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button kategoriBtn;
        private System.Windows.Forms.Button urunBtn;
        private System.Windows.Forms.Button istatistikBtn;
    }
}