namespace CinemaProjectForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listFilms = new System.Windows.Forms.ListBox();
            this.checkedListYiyecek = new System.Windows.Forms.CheckedListBox();
            this.listKoltuk = new System.Windows.Forms.ListBox();
            this.textAd = new System.Windows.Forms.TextBox();
            this.textSoyad = new System.Windows.Forms.TextBox();
            this.labelAd = new System.Windows.Forms.Label();
            this.labelSoyad = new System.Windows.Forms.Label();
            this.labelFilmList = new System.Windows.Forms.Label();
            this.labelListKoltuk = new System.Windows.Forms.Label();
            this.labelYiyecekList = new System.Windows.Forms.Label();
            this.btnGoster = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelFilmFiyat = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelFiyat = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelBilgiGoster = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.labelYiyecekFiyat = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // listFilms
            // 
            this.listFilms.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.listFilms.FormattingEnabled = true;
            this.listFilms.ItemHeight = 15;
            this.listFilms.Location = new System.Drawing.Point(8, 41);
            this.listFilms.Name = "listFilms";
            this.listFilms.Size = new System.Drawing.Size(117, 154);
            this.listFilms.TabIndex = 0;
            this.listFilms.SelectedIndexChanged += new System.EventHandler(this.listFilms_SelectedIndexChanged);
            // 
            // checkedListYiyecek
            // 
            this.checkedListYiyecek.FormattingEnabled = true;
            this.checkedListYiyecek.Location = new System.Drawing.Point(622, 38);
            this.checkedListYiyecek.Name = "checkedListYiyecek";
            this.checkedListYiyecek.Size = new System.Drawing.Size(99, 184);
            this.checkedListYiyecek.TabIndex = 2;
            this.checkedListYiyecek.SelectedIndexChanged += new System.EventHandler(this.checkedListYiyecek_SelectedIndexChanged);
            // 
            // listKoltuk
            // 
            this.listKoltuk.FormattingEnabled = true;
            this.listKoltuk.ItemHeight = 15;
            this.listKoltuk.Location = new System.Drawing.Point(474, 38);
            this.listKoltuk.Name = "listKoltuk";
            this.listKoltuk.Size = new System.Drawing.Size(112, 184);
            this.listKoltuk.TabIndex = 3;
            this.listKoltuk.SelectedIndexChanged += new System.EventHandler(this.listKoltuk_SelectedIndexChanged);
            // 
            // textAd
            // 
            this.textAd.Location = new System.Drawing.Point(69, 17);
            this.textAd.Name = "textAd";
            this.textAd.Size = new System.Drawing.Size(100, 23);
            this.textAd.TabIndex = 4;
            this.textAd.TextChanged += new System.EventHandler(this.textAd_TextChanged);
            // 
            // textSoyad
            // 
            this.textSoyad.Location = new System.Drawing.Point(69, 57);
            this.textSoyad.Name = "textSoyad";
            this.textSoyad.Size = new System.Drawing.Size(100, 23);
            this.textSoyad.TabIndex = 5;
            // 
            // labelAd
            // 
            this.labelAd.AutoSize = true;
            this.labelAd.Location = new System.Drawing.Point(10, 20);
            this.labelAd.Name = "labelAd";
            this.labelAd.Size = new System.Drawing.Size(28, 15);
            this.labelAd.TabIndex = 6;
            this.labelAd.Text = "Ad :";
            // 
            // labelSoyad
            // 
            this.labelSoyad.AutoSize = true;
            this.labelSoyad.Location = new System.Drawing.Point(10, 60);
            this.labelSoyad.Name = "labelSoyad";
            this.labelSoyad.Size = new System.Drawing.Size(45, 15);
            this.labelSoyad.TabIndex = 7;
            this.labelSoyad.Text = "Soyad :";
            // 
            // labelFilmList
            // 
            this.labelFilmList.AutoSize = true;
            this.labelFilmList.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelFilmList.Location = new System.Drawing.Point(8, 21);
            this.labelFilmList.Name = "labelFilmList";
            this.labelFilmList.Size = new System.Drawing.Size(117, 17);
            this.labelFilmList.TabIndex = 8;
            this.labelFilmList.Text = "Vizyondaki Filmler";
            // 
            // labelListKoltuk
            // 
            this.labelListKoltuk.AutoSize = true;
            this.labelListKoltuk.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelListKoltuk.Location = new System.Drawing.Point(474, 18);
            this.labelListKoltuk.Name = "labelListKoltuk";
            this.labelListKoltuk.Size = new System.Drawing.Size(87, 17);
            this.labelListKoltuk.TabIndex = 9;
            this.labelListKoltuk.Text = "Koltuk Listesi";
            // 
            // labelYiyecekList
            // 
            this.labelYiyecekList.AutoSize = true;
            this.labelYiyecekList.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelYiyecekList.Location = new System.Drawing.Point(622, 18);
            this.labelYiyecekList.Name = "labelYiyecekList";
            this.labelYiyecekList.Size = new System.Drawing.Size(93, 17);
            this.labelYiyecekList.TabIndex = 10;
            this.labelYiyecekList.Text = "Yiyecek Listesi";
            // 
            // btnGoster
            // 
            this.btnGoster.Location = new System.Drawing.Point(18, 36);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(75, 23);
            this.btnGoster.TabIndex = 11;
            this.btnGoster.Text = "Göster";
            this.btnGoster.UseVisualStyleBackColor = true;
            this.btnGoster.Click += new System.EventHandler(this.btnGoster_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.groupBox1.Controls.Add(this.textSoyad);
            this.groupBox1.Controls.Add(this.textAd);
            this.groupBox1.Controls.Add(this.labelAd);
            this.groupBox1.Controls.Add(this.labelSoyad);
            this.groupBox1.Location = new System.Drawing.Point(12, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kişi Bilgileri";
            // 
            // labelFilmFiyat
            // 
            this.labelFilmFiyat.AutoSize = true;
            this.labelFilmFiyat.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelFilmFiyat.Location = new System.Drawing.Point(131, 21);
            this.labelFilmFiyat.Name = "labelFilmFiyat";
            this.labelFilmFiyat.Size = new System.Drawing.Size(37, 17);
            this.labelFilmFiyat.TabIndex = 15;
            this.labelFilmFiyat.Text = "Fiyat";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox2.Controls.Add(this.labelFiyat);
            this.groupBox2.Controls.Add(this.listFilms);
            this.groupBox2.Controls.Add(this.labelFilmFiyat);
            this.groupBox2.Controls.Add(this.labelFilmList);
            this.groupBox2.Location = new System.Drawing.Point(231, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(195, 201);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fİlm Bilgisi";
            // 
            // labelFiyat
            // 
            this.labelFiyat.AutoSize = true;
            this.labelFiyat.Location = new System.Drawing.Point(129, 42);
            this.labelFiyat.Name = "labelFiyat";
            this.labelFiyat.Size = new System.Drawing.Size(0, 15);
            this.labelFiyat.TabIndex = 16;
            this.labelFiyat.Click += new System.EventHandler(this.labelFiyat_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelBilgiGoster);
            this.groupBox3.Controls.Add(this.btnGoster);
            this.groupBox3.Location = new System.Drawing.Point(351, 269);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(341, 155);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bilgiler";
            // 
            // labelBilgiGoster
            // 
            this.labelBilgiGoster.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelBilgiGoster.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.labelBilgiGoster.Location = new System.Drawing.Point(152, 16);
            this.labelBilgiGoster.Name = "labelBilgiGoster";
            this.labelBilgiGoster.Size = new System.Drawing.Size(176, 112);
            this.labelBilgiGoster.TabIndex = 12;
            this.labelBilgiGoster.Text = "Bilgiler";
            this.labelBilgiGoster.UseCompatibleTextRendering = true;
            this.labelBilgiGoster.Click += new System.EventHandler(this.labelBilgiGoster_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label.Location = new System.Drawing.Point(726, 18);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(37, 17);
            this.label.TabIndex = 18;
            this.label.Text = "Fiyat";
            // 
            // labelYiyecekFiyat
            // 
            this.labelYiyecekFiyat.AutoSize = true;
            this.labelYiyecekFiyat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelYiyecekFiyat.Location = new System.Drawing.Point(725, 41);
            this.labelYiyecekFiyat.Name = "labelYiyecekFiyat";
            this.labelYiyecekFiyat.Size = new System.Drawing.Size(0, 17);
            this.labelYiyecekFiyat.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelYiyecekFiyat);
            this.Controls.Add(this.label);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelYiyecekList);
            this.Controls.Add(this.labelListKoltuk);
            this.Controls.Add(this.listKoltuk);
            this.Controls.Add(this.checkedListYiyecek);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listFilms;
        private System.Windows.Forms.CheckedListBox checkedListYiyecek;
        private System.Windows.Forms.ListBox listKoltuk;
        private System.Windows.Forms.TextBox textAd;
        private System.Windows.Forms.TextBox textSoyad;
        private System.Windows.Forms.Label labelAd;
        private System.Windows.Forms.Label labelSoyad;
        private System.Windows.Forms.Label labelFilmList;
        private System.Windows.Forms.Label labelListKoltuk;
        private System.Windows.Forms.Label labelYiyecekList;
        private System.Windows.Forms.Button btnGoster;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelFilmFiyat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelBilgiGoster;
        private System.Windows.Forms.Label labelFiyat;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label labelYiyecekFiyat;
    }
}
