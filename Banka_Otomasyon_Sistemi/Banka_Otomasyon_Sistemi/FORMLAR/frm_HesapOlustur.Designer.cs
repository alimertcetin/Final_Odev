namespace Banka_Otomasyon_Sistemi
{
    partial class frm_HesapOlustur
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
            this.btn_olustur = new System.Windows.Forms.Button();
            this.rb_Banka = new System.Windows.Forms.RadioButton();
            this.rb_Kredi = new System.Windows.Forms.RadioButton();
            this.grpbx_HesapSecim = new System.Windows.Forms.GroupBox();
            this.dtp_DogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.txt_Sifre = new System.Windows.Forms.TextBox();
            this.txt_DogumYeri = new System.Windows.Forms.TextBox();
            this.txt_Soyad = new System.Windows.Forms.TextBox();
            this.txt_Ad = new System.Windows.Forms.TextBox();
            this.txt_MusteriNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpbx_HesapSecim.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_olustur
            // 
            this.btn_olustur.BackColor = System.Drawing.Color.LightGreen;
            this.btn_olustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_olustur.Location = new System.Drawing.Point(286, 273);
            this.btn_olustur.Name = "btn_olustur";
            this.btn_olustur.Size = new System.Drawing.Size(99, 41);
            this.btn_olustur.TabIndex = 30;
            this.btn_olustur.Text = "Oluştur";
            this.btn_olustur.UseVisualStyleBackColor = false;
            this.btn_olustur.Click += new System.EventHandler(this.btn_olustur_Click);
            // 
            // rb_Banka
            // 
            this.rb_Banka.AutoSize = true;
            this.rb_Banka.Location = new System.Drawing.Point(6, 51);
            this.rb_Banka.Name = "rb_Banka";
            this.rb_Banka.Size = new System.Drawing.Size(192, 17);
            this.rb_Banka.TabIndex = 1;
            this.rb_Banka.TabStop = true;
            this.rb_Banka.Text = "Banka Hesabı Oluşturmak İstiyorum";
            this.rb_Banka.UseVisualStyleBackColor = true;
            // 
            // rb_Kredi
            // 
            this.rb_Kredi.AutoSize = true;
            this.rb_Kredi.Location = new System.Drawing.Point(6, 19);
            this.rb_Kredi.Name = "rb_Kredi";
            this.rb_Kredi.Size = new System.Drawing.Size(185, 17);
            this.rb_Kredi.TabIndex = 0;
            this.rb_Kredi.TabStop = true;
            this.rb_Kredi.Text = "Kredi Hesabı Oluşturmak İstiyorum";
            this.rb_Kredi.UseVisualStyleBackColor = true;
            // 
            // grpbx_HesapSecim
            // 
            this.grpbx_HesapSecim.Controls.Add(this.rb_Banka);
            this.grpbx_HesapSecim.Controls.Add(this.rb_Kredi);
            this.grpbx_HesapSecim.Location = new System.Drawing.Point(12, 246);
            this.grpbx_HesapSecim.Name = "grpbx_HesapSecim";
            this.grpbx_HesapSecim.Size = new System.Drawing.Size(197, 92);
            this.grpbx_HesapSecim.TabIndex = 29;
            this.grpbx_HesapSecim.TabStop = false;
            // 
            // dtp_DogumTarihi
            // 
            this.dtp_DogumTarihi.Enabled = false;
            this.dtp_DogumTarihi.Location = new System.Drawing.Point(185, 131);
            this.dtp_DogumTarihi.Name = "dtp_DogumTarihi";
            this.dtp_DogumTarihi.Size = new System.Drawing.Size(200, 20);
            this.dtp_DogumTarihi.TabIndex = 28;
            // 
            // txt_Sifre
            // 
            this.txt_Sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Sifre.Location = new System.Drawing.Point(185, 208);
            this.txt_Sifre.Name = "txt_Sifre";
            this.txt_Sifre.PasswordChar = '*';
            this.txt_Sifre.Size = new System.Drawing.Size(200, 26);
            this.txt_Sifre.TabIndex = 27;
            // 
            // txt_DogumYeri
            // 
            this.txt_DogumYeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_DogumYeri.Location = new System.Drawing.Point(185, 169);
            this.txt_DogumYeri.Name = "txt_DogumYeri";
            this.txt_DogumYeri.ReadOnly = true;
            this.txt_DogumYeri.Size = new System.Drawing.Size(200, 26);
            this.txt_DogumYeri.TabIndex = 26;
            // 
            // txt_Soyad
            // 
            this.txt_Soyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Soyad.Location = new System.Drawing.Point(185, 90);
            this.txt_Soyad.Name = "txt_Soyad";
            this.txt_Soyad.ReadOnly = true;
            this.txt_Soyad.Size = new System.Drawing.Size(200, 26);
            this.txt_Soyad.TabIndex = 25;
            // 
            // txt_Ad
            // 
            this.txt_Ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Ad.Location = new System.Drawing.Point(185, 50);
            this.txt_Ad.Name = "txt_Ad";
            this.txt_Ad.ReadOnly = true;
            this.txt_Ad.Size = new System.Drawing.Size(200, 26);
            this.txt_Ad.TabIndex = 24;
            // 
            // txt_MusteriNo
            // 
            this.txt_MusteriNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_MusteriNo.Location = new System.Drawing.Point(185, 9);
            this.txt_MusteriNo.MaxLength = 11;
            this.txt_MusteriNo.Name = "txt_MusteriNo";
            this.txt_MusteriNo.Size = new System.Drawing.Size(200, 26);
            this.txt_MusteriNo.TabIndex = 23;
            this.txt_MusteriNo.TextChanged += new System.EventHandler(this.txt_MusteriNo_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(96, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 24);
            this.label6.TabIndex = 22;
            this.label6.Text = "Şifre :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(28, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 24);
            this.label5.TabIndex = 21;
            this.label5.Text = "Doğum Yeri :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 24);
            this.label4.TabIndex = 20;
            this.label4.Text = "Doğum Tarihi :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(60, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 24);
            this.label3.TabIndex = 19;
            this.label3.Text = "Soy İsim :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(101, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "İsim :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(37, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "Müşteri No :";
            // 
            // frm_HesapOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 337);
            this.Controls.Add(this.btn_olustur);
            this.Controls.Add(this.grpbx_HesapSecim);
            this.Controls.Add(this.dtp_DogumTarihi);
            this.Controls.Add(this.txt_Sifre);
            this.Controls.Add(this.txt_DogumYeri);
            this.Controls.Add(this.txt_Soyad);
            this.Controls.Add(this.txt_Ad);
            this.Controls.Add(this.txt_MusteriNo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_HesapOlustur";
            this.Text = "Hesap Oluştur";
            this.grpbx_HesapSecim.ResumeLayout(false);
            this.grpbx_HesapSecim.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_olustur;
        private System.Windows.Forms.RadioButton rb_Banka;
        private System.Windows.Forms.RadioButton rb_Kredi;
        private System.Windows.Forms.GroupBox grpbx_HesapSecim;
        private System.Windows.Forms.DateTimePicker dtp_DogumTarihi;
        private System.Windows.Forms.TextBox txt_Sifre;
        private System.Windows.Forms.TextBox txt_DogumYeri;
        private System.Windows.Forms.TextBox txt_Soyad;
        private System.Windows.Forms.TextBox txt_Ad;
        private System.Windows.Forms.TextBox txt_MusteriNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}