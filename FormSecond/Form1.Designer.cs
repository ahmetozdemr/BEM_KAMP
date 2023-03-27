namespace FormSecond
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
            this.rdKadin = new System.Windows.Forms.RadioButton();
            this.rdErkek = new System.Windows.Forms.RadioButton();
            this.rdIlkokul = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdUniversite = new System.Windows.Forms.RadioButton();
            this.rdLise = new System.Windows.Forms.RadioButton();
            this.rdOrtaokul = new System.Windows.Forms.RadioButton();
            this.btnGoster = new System.Windows.Forms.Button();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkIngilizce = new System.Windows.Forms.CheckBox();
            this.checkAlmanca = new System.Windows.Forms.CheckBox();
            this.checkTurkce = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdKadin
            // 
            this.rdKadin.AutoSize = true;
            this.rdKadin.Location = new System.Drawing.Point(0, 22);
            this.rdKadin.Name = "rdKadin";
            this.rdKadin.Size = new System.Drawing.Size(94, 19);
            this.rdKadin.TabIndex = 0;
            this.rdKadin.TabStop = true;
            this.rdKadin.Text = "radioButton1";
            this.rdKadin.UseVisualStyleBackColor = true;
            this.rdKadin.CheckedChanged += new System.EventHandler(this.rdKadin_CheckedChanged);
            // 
            // rdErkek
            // 
            this.rdErkek.AutoSize = true;
            this.rdErkek.Location = new System.Drawing.Point(0, 56);
            this.rdErkek.Name = "rdErkek";
            this.rdErkek.Size = new System.Drawing.Size(94, 19);
            this.rdErkek.TabIndex = 1;
            this.rdErkek.TabStop = true;
            this.rdErkek.Text = "radioButton2";
            this.rdErkek.UseVisualStyleBackColor = true;
            // 
            // rdIlkokul
            // 
            this.rdIlkokul.AutoSize = true;
            this.rdIlkokul.Location = new System.Drawing.Point(6, 22);
            this.rdIlkokul.Name = "rdIlkokul";
            this.rdIlkokul.Size = new System.Drawing.Size(60, 19);
            this.rdIlkokul.TabIndex = 2;
            this.rdIlkokul.TabStop = true;
            this.rdIlkokul.Text = "İlkokul";
            this.rdIlkokul.UseVisualStyleBackColor = true;
            this.rdIlkokul.CheckedChanged += new System.EventHandler(this.txtAd_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdKadin);
            this.groupBox1.Controls.Add(this.rdErkek);
            this.groupBox1.Location = new System.Drawing.Point(160, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cinsiyet";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdUniversite);
            this.groupBox2.Controls.Add(this.rdLise);
            this.groupBox2.Controls.Add(this.rdOrtaokul);
            this.groupBox2.Controls.Add(this.rdIlkokul);
            this.groupBox2.Location = new System.Drawing.Point(160, 181);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 154);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Eğitim Durumu";
            // 
            // rdUniversite
            // 
            this.rdUniversite.AutoSize = true;
            this.rdUniversite.Location = new System.Drawing.Point(8, 99);
            this.rdUniversite.Name = "rdUniversite";
            this.rdUniversite.Size = new System.Drawing.Size(77, 19);
            this.rdUniversite.TabIndex = 6;
            this.rdUniversite.TabStop = true;
            this.rdUniversite.Text = "Üniversite";
            this.rdUniversite.UseVisualStyleBackColor = true;
            this.rdUniversite.CheckedChanged += new System.EventHandler(this.txtAd_TextChanged);
            // 
            // rdLise
            // 
            this.rdLise.AutoSize = true;
            this.rdLise.Location = new System.Drawing.Point(6, 72);
            this.rdLise.Name = "rdLise";
            this.rdLise.Size = new System.Drawing.Size(45, 19);
            this.rdLise.TabIndex = 5;
            this.rdLise.TabStop = true;
            this.rdLise.Text = "Lise";
            this.rdLise.UseVisualStyleBackColor = true;
            this.rdLise.CheckedChanged += new System.EventHandler(this.txtAd_TextChanged);
            // 
            // rdOrtaokul
            // 
            this.rdOrtaokul.AutoSize = true;
            this.rdOrtaokul.Location = new System.Drawing.Point(6, 47);
            this.rdOrtaokul.Name = "rdOrtaokul";
            this.rdOrtaokul.Size = new System.Drawing.Size(48, 19);
            this.rdOrtaokul.TabIndex = 3;
            this.rdOrtaokul.TabStop = true;
            this.rdOrtaokul.Text = "Orta";
            this.rdOrtaokul.UseVisualStyleBackColor = true;
            this.rdOrtaokul.CheckedChanged += new System.EventHandler(this.txtAd_TextChanged);
            // 
            // btnGoster
            // 
            this.btnGoster.Location = new System.Drawing.Point(599, 345);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(75, 23);
            this.btnGoster.TabIndex = 5;
            this.btnGoster.Text = "Göster";
            this.btnGoster.UseVisualStyleBackColor = true;
            this.btnGoster.Click += new System.EventHandler(this.btnGoster_Click);
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(168, 10);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 23);
            this.txtAd.TabIndex = 6;
            this.txtAd.TextChanged += new System.EventHandler(this.txtAd_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkIngilizce);
            this.groupBox3.Controls.Add(this.checkAlmanca);
            this.groupBox3.Controls.Add(this.checkTurkce);
            this.groupBox3.Location = new System.Drawing.Point(474, 42);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dil";
            // 
            // checkIngilizce
            // 
            this.checkIngilizce.AutoSize = true;
            this.checkIngilizce.Location = new System.Drawing.Point(6, 42);
            this.checkIngilizce.Name = "checkIngilizce";
            this.checkIngilizce.Size = new System.Drawing.Size(69, 19);
            this.checkIngilizce.TabIndex = 2;
            this.checkIngilizce.Text = "Ingilizce";
            this.checkIngilizce.UseVisualStyleBackColor = true;
            // 
            // checkAlmanca
            // 
            this.checkAlmanca.AutoSize = true;
            this.checkAlmanca.Location = new System.Drawing.Point(6, 67);
            this.checkAlmanca.Name = "checkAlmanca";
            this.checkAlmanca.Size = new System.Drawing.Size(73, 19);
            this.checkAlmanca.TabIndex = 1;
            this.checkAlmanca.Text = "Almanca";
            this.checkAlmanca.UseVisualStyleBackColor = true;
            // 
            // checkTurkce
            // 
            this.checkTurkce.AutoSize = true;
            this.checkTurkce.Location = new System.Drawing.Point(6, 22);
            this.checkTurkce.Name = "checkTurkce";
            this.checkTurkce.Size = new System.Drawing.Size(61, 19);
            this.checkTurkce.TabIndex = 0;
            this.checkTurkce.Text = "Türkçe";
            this.checkTurkce.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.btnGoster);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdKadin;
        private System.Windows.Forms.RadioButton rdErkek;
        private System.Windows.Forms.RadioButton rdIlkokul;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdOrtaokul;
        private System.Windows.Forms.RadioButton rdLise;
        private System.Windows.Forms.RadioButton rdUniversite;
        private System.Windows.Forms.Button btnGoster;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkIngilizce;
        private System.Windows.Forms.CheckBox checkAlmanca;
        private System.Windows.Forms.CheckBox checkTurkce;
    }
}
