namespace EFProject
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.idText = new System.Windows.Forms.TextBox();
            this.adText = new System.Windows.Forms.TextBox();
            this.listeleBtn = new System.Windows.Forms.Button();
            this.ekleBtn = new System.Windows.Forms.Button();
            this.silBtn = new System.Windows.Forms.Button();
            this.guncelleBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategori ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kategori Adı:";
            // 
            // idText
            // 
            this.idText.Location = new System.Drawing.Point(91, 20);
            this.idText.Name = "idText";
            this.idText.Size = new System.Drawing.Size(100, 20);
            this.idText.TabIndex = 2;
            // 
            // adText
            // 
            this.adText.Location = new System.Drawing.Point(91, 58);
            this.adText.Name = "adText";
            this.adText.Size = new System.Drawing.Size(100, 20);
            this.adText.TabIndex = 3;
            // 
            // listeleBtn
            // 
            this.listeleBtn.Location = new System.Drawing.Point(21, 115);
            this.listeleBtn.Name = "listeleBtn";
            this.listeleBtn.Size = new System.Drawing.Size(95, 29);
            this.listeleBtn.TabIndex = 4;
            this.listeleBtn.Text = "Listele";
            this.listeleBtn.UseVisualStyleBackColor = true;
            this.listeleBtn.Click += new System.EventHandler(this.listeleBtn_Click);
            // 
            // ekleBtn
            // 
            this.ekleBtn.Location = new System.Drawing.Point(21, 150);
            this.ekleBtn.Name = "ekleBtn";
            this.ekleBtn.Size = new System.Drawing.Size(95, 29);
            this.ekleBtn.TabIndex = 5;
            this.ekleBtn.Text = "Ekle";
            this.ekleBtn.UseVisualStyleBackColor = true;
            this.ekleBtn.Click += new System.EventHandler(this.ekleBtn_Click);
            // 
            // silBtn
            // 
            this.silBtn.Location = new System.Drawing.Point(122, 115);
            this.silBtn.Name = "silBtn";
            this.silBtn.Size = new System.Drawing.Size(95, 29);
            this.silBtn.TabIndex = 6;
            this.silBtn.Text = "Sil";
            this.silBtn.UseVisualStyleBackColor = true;
            this.silBtn.Click += new System.EventHandler(this.silBtn_Click);
            // 
            // guncelleBtn
            // 
            this.guncelleBtn.Location = new System.Drawing.Point(122, 150);
            this.guncelleBtn.Name = "guncelleBtn";
            this.guncelleBtn.Size = new System.Drawing.Size(95, 29);
            this.guncelleBtn.TabIndex = 7;
            this.guncelleBtn.Text = "Güncelle";
            this.guncelleBtn.UseVisualStyleBackColor = true;
            this.guncelleBtn.Click += new System.EventHandler(this.guncelleBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(237, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(551, 159);
            this.dataGridView1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 200);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.guncelleBtn);
            this.Controls.Add(this.silBtn);
            this.Controls.Add(this.ekleBtn);
            this.Controls.Add(this.listeleBtn);
            this.Controls.Add(this.adText);
            this.Controls.Add(this.idText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idText;
        private System.Windows.Forms.TextBox adText;
        private System.Windows.Forms.Button listeleBtn;
        private System.Windows.Forms.Button ekleBtn;
        private System.Windows.Forms.Button silBtn;
        private System.Windows.Forms.Button guncelleBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

