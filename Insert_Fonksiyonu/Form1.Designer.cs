namespace Insert_Fonksiyonu
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
            this.txttabloisim = new System.Windows.Forms.TextBox();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.txtverigirisi = new System.Windows.Forms.TextBox();
            this.lstliste = new System.Windows.Forms.ListBox();
            this.btnekle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnverilerigetir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Veri = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btncikis = new System.Windows.Forms.Button();
            this.btntemizle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Veri.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txttabloisim
            // 
            this.txttabloisim.Location = new System.Drawing.Point(40, 19);
            this.txttabloisim.Name = "txttabloisim";
            this.txttabloisim.Size = new System.Drawing.Size(154, 20);
            this.txttabloisim.TabIndex = 1;
            // 
            // btnkaydet
            // 
            this.btnkaydet.Location = new System.Drawing.Point(26, 236);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(144, 23);
            this.btnkaydet.TabIndex = 5;
            this.btnkaydet.Text = "VERİTABANINA KAYDET";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // txtverigirisi
            // 
            this.txtverigirisi.Location = new System.Drawing.Point(26, 17);
            this.txtverigirisi.Name = "txtverigirisi";
            this.txtverigirisi.Size = new System.Drawing.Size(130, 20);
            this.txtverigirisi.TabIndex = 6;
            // 
            // lstliste
            // 
            this.lstliste.FormattingEnabled = true;
            this.lstliste.Location = new System.Drawing.Point(36, 72);
            this.lstliste.Name = "lstliste";
            this.lstliste.Size = new System.Drawing.Size(120, 108);
            this.lstliste.TabIndex = 7;
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(56, 43);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(75, 23);
            this.btnekle.TabIndex = 1;
            this.btnekle.Text = "Ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, -13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Veri Girişi";
            // 
            // btnverilerigetir
            // 
            this.btnverilerigetir.Location = new System.Drawing.Point(24, 55);
            this.btnverilerigetir.Name = "btnverilerigetir";
            this.btnverilerigetir.Size = new System.Drawing.Size(193, 23);
            this.btnverilerigetir.TabIndex = 11;
            this.btnverilerigetir.Text = "VERİLERİ GÖSTER";
            this.btnverilerigetir.UseVisualStyleBackColor = true;
            this.btnverilerigetir.Click += new System.EventHandler(this.btnverilerigetir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(12, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 60);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Veritabanı Seçimi";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(99, 37);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(49, 17);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Proje";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(8, 37);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(76, 17);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "NorthWind";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(604, 231);
            this.dataGridView1.TabIndex = 13;
            // 
            // Veri
            // 
            this.Veri.Controls.Add(this.btntemizle);
            this.Veri.Controls.Add(this.lstliste);
            this.Veri.Controls.Add(this.btnkaydet);
            this.Veri.Controls.Add(this.txtverigirisi);
            this.Veri.Controls.Add(this.btnekle);
            this.Veri.Controls.Add(this.label3);
            this.Veri.Location = new System.Drawing.Point(622, 21);
            this.Veri.Name = "Veri";
            this.Veri.Size = new System.Drawing.Size(200, 265);
            this.Veri.TabIndex = 14;
            this.Veri.TabStop = false;
            this.Veri.Text = "Veri Girişi";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txttabloisim);
            this.groupBox2.Controls.Add(this.btnverilerigetir);
            this.groupBox2.Location = new System.Drawing.Point(285, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(247, 99);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tablo İsmi";
            // 
            // btncikis
            // 
            this.btncikis.Location = new System.Drawing.Point(678, 312);
            this.btncikis.Name = "btncikis";
            this.btncikis.Size = new System.Drawing.Size(75, 23);
            this.btncikis.TabIndex = 16;
            this.btncikis.Text = "ÇIKIŞ";
            this.btncikis.UseVisualStyleBackColor = true;
            this.btncikis.Click += new System.EventHandler(this.btncikis_Click);
            // 
            // btntemizle
            // 
            this.btntemizle.Location = new System.Drawing.Point(56, 187);
            this.btntemizle.Name = "btntemizle";
            this.btntemizle.Size = new System.Drawing.Size(75, 23);
            this.btntemizle.TabIndex = 10;
            this.btntemizle.Text = "Temizle";
            this.btntemizle.UseVisualStyleBackColor = true;
            this.btntemizle.Click += new System.EventHandler(this.btntemizle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 347);
            this.Controls.Add(this.btncikis);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Veri);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Veri.ResumeLayout(false);
            this.Veri.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txttabloisim;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.TextBox txtverigirisi;
        private System.Windows.Forms.ListBox lstliste;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnverilerigetir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox Veri;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btncikis;
        private System.Windows.Forms.Button btntemizle;
    }
}

