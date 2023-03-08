namespace EFProject
{
    partial class FrmUrunlerForm
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
            this.idText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.urunAdText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.markaText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.stokText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.fiyatText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.durumText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.listeleBtn = new System.Windows.Forms.Button();
            this.ekleBtn = new System.Windows.Forms.Button();
            this.silBtn = new System.Windows.Forms.Button();
            this.guncelleBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kategoriCombo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // idText
            // 
            this.idText.Location = new System.Drawing.Point(130, 39);
            this.idText.Name = "idText";
            this.idText.Size = new System.Drawing.Size(142, 20);
            this.idText.TabIndex = 0;
            this.idText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(83, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(21, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "ÜRÜN ADI:";
            // 
            // urunAdText
            // 
            this.urunAdText.Location = new System.Drawing.Point(130, 65);
            this.urunAdText.Name = "urunAdText";
            this.urunAdText.Size = new System.Drawing.Size(142, 20);
            this.urunAdText.TabIndex = 2;
            this.urunAdText.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(27, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "MARKASI:";
            // 
            // markaText
            // 
            this.markaText.Location = new System.Drawing.Point(130, 91);
            this.markaText.Name = "markaText";
            this.markaText.Size = new System.Drawing.Size(142, 20);
            this.markaText.TabIndex = 4;
            this.markaText.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(58, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "STOK:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // stokText
            // 
            this.stokText.Location = new System.Drawing.Point(130, 117);
            this.stokText.Name = "stokText";
            this.stokText.Size = new System.Drawing.Size(142, 20);
            this.stokText.TabIndex = 6;
            this.stokText.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(54, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "FİYAT:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // fiyatText
            // 
            this.fiyatText.Location = new System.Drawing.Point(130, 143);
            this.fiyatText.Name = "fiyatText";
            this.fiyatText.Size = new System.Drawing.Size(142, 20);
            this.fiyatText.TabIndex = 8;
            this.fiyatText.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(39, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "DURUM:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // durumText
            // 
            this.durumText.Location = new System.Drawing.Point(130, 169);
            this.durumText.Name = "durumText";
            this.durumText.Size = new System.Drawing.Size(142, 20);
            this.durumText.TabIndex = 10;
            this.durumText.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(17, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "KATEGORİ:";
            // 
            // listeleBtn
            // 
            this.listeleBtn.Location = new System.Drawing.Point(325, 29);
            this.listeleBtn.Name = "listeleBtn";
            this.listeleBtn.Size = new System.Drawing.Size(108, 38);
            this.listeleBtn.TabIndex = 14;
            this.listeleBtn.Text = "LİSTELE";
            this.listeleBtn.UseVisualStyleBackColor = true;
            this.listeleBtn.Click += new System.EventHandler(this.listeleBtn_Click);
            // 
            // ekleBtn
            // 
            this.ekleBtn.Location = new System.Drawing.Point(325, 83);
            this.ekleBtn.Name = "ekleBtn";
            this.ekleBtn.Size = new System.Drawing.Size(108, 38);
            this.ekleBtn.TabIndex = 15;
            this.ekleBtn.Text = "EKLE";
            this.ekleBtn.UseVisualStyleBackColor = true;
            this.ekleBtn.Click += new System.EventHandler(this.ekleBtn_Click);
            // 
            // silBtn
            // 
            this.silBtn.Location = new System.Drawing.Point(325, 133);
            this.silBtn.Name = "silBtn";
            this.silBtn.Size = new System.Drawing.Size(108, 38);
            this.silBtn.TabIndex = 16;
            this.silBtn.Text = "SİL";
            this.silBtn.UseVisualStyleBackColor = true;
            this.silBtn.Click += new System.EventHandler(this.silBtn_Click);
            // 
            // guncelleBtn
            // 
            this.guncelleBtn.Location = new System.Drawing.Point(325, 183);
            this.guncelleBtn.Name = "guncelleBtn";
            this.guncelleBtn.Size = new System.Drawing.Size(108, 38);
            this.guncelleBtn.TabIndex = 17;
            this.guncelleBtn.Text = "GÜNCELLE";
            this.guncelleBtn.UseVisualStyleBackColor = true;
            this.guncelleBtn.Click += new System.EventHandler(this.guncelleBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 246);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 197);
            this.dataGridView1.TabIndex = 18;
            // 
            // kategoriCombo
            // 
            this.kategoriCombo.FormattingEnabled = true;
            this.kategoriCombo.Location = new System.Drawing.Point(130, 196);
            this.kategoriCombo.Name = "kategoriCombo";
            this.kategoriCombo.Size = new System.Drawing.Size(142, 21);
            this.kategoriCombo.TabIndex = 19;
            // 
            // FrmUrunlerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 455);
            this.Controls.Add(this.kategoriCombo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.guncelleBtn);
            this.Controls.Add(this.silBtn);
            this.Controls.Add(this.ekleBtn);
            this.Controls.Add(this.listeleBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.durumText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fiyatText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.stokText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.markaText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.urunAdText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idText);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmUrunlerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmUrunlerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox idText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox urunAdText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox markaText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox stokText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox fiyatText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox durumText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button listeleBtn;
        private System.Windows.Forms.Button ekleBtn;
        private System.Windows.Forms.Button silBtn;
        private System.Windows.Forms.Button guncelleBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox kategoriCombo;
    }
}