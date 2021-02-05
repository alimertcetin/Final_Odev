namespace Banka_Otomasyon_Sistemi
{
    partial class frm_OdemeYap
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
            this.cmb_HesapTuru = new System.Windows.Forms.ComboBox();
            this.txt_OdemeTutari = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtg_HesapGoruntule = new System.Windows.Forms.DataGridView();
            this.BankaHesapNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BankIban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hesap_Bakiye = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_HesapListesi = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_KategoriListesi = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_MusteriNo = new System.Windows.Forms.Label();
            this.btn_OdemeYap = new System.Windows.Forms.Button();
            this.btn_Geri = new System.Windows.Forms.Button();
            this.txt_Aciklama = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_HesapGoruntule)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_HesapTuru
            // 
            this.cmb_HesapTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_HesapTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_HesapTuru.FormattingEnabled = true;
            this.cmb_HesapTuru.Items.AddRange(new object[] {
            "Banka Hesapları",
            "Kredi Hesapları"});
            this.cmb_HesapTuru.Location = new System.Drawing.Point(341, 39);
            this.cmb_HesapTuru.Name = "cmb_HesapTuru";
            this.cmb_HesapTuru.Size = new System.Drawing.Size(253, 28);
            this.cmb_HesapTuru.TabIndex = 59;
            this.cmb_HesapTuru.SelectedIndexChanged += new System.EventHandler(this.cmb_HesapTuru_SelectedIndexChanged);
            // 
            // txt_OdemeTutari
            // 
            this.txt_OdemeTutari.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_OdemeTutari.Location = new System.Drawing.Point(16, 79);
            this.txt_OdemeTutari.MaxLength = 10;
            this.txt_OdemeTutari.Name = "txt_OdemeTutari";
            this.txt_OdemeTutari.Size = new System.Drawing.Size(253, 26);
            this.txt_OdemeTutari.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 24);
            this.label1.TabIndex = 51;
            this.label1.Text = "Ödeme Tutarı";
            // 
            // dtg_HesapGoruntule
            // 
            this.dtg_HesapGoruntule.AllowUserToAddRows = false;
            this.dtg_HesapGoruntule.AllowUserToDeleteRows = false;
            this.dtg_HesapGoruntule.AllowUserToResizeRows = false;
            this.dtg_HesapGoruntule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_HesapGoruntule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_HesapGoruntule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BankaHesapNo,
            this.BankIban,
            this.Hesap_Bakiye});
            this.dtg_HesapGoruntule.Location = new System.Drawing.Point(16, 214);
            this.dtg_HesapGoruntule.Name = "dtg_HesapGoruntule";
            this.dtg_HesapGoruntule.ReadOnly = true;
            this.dtg_HesapGoruntule.Size = new System.Drawing.Size(578, 207);
            this.dtg_HesapGoruntule.TabIndex = 50;
            // 
            // BankaHesapNo
            // 
            this.BankaHesapNo.DataPropertyName = "BankaHesapNo";
            this.BankaHesapNo.HeaderText = "Hesap Numarası";
            this.BankaHesapNo.Name = "BankaHesapNo";
            this.BankaHesapNo.ReadOnly = true;
            // 
            // BankIban
            // 
            this.BankIban.DataPropertyName = "BankIban";
            this.BankIban.HeaderText = "Iban";
            this.BankIban.Name = "BankIban";
            this.BankIban.ReadOnly = true;
            // 
            // Hesap_Bakiye
            // 
            this.Hesap_Bakiye.DataPropertyName = "Hesap_Bakiye";
            this.Hesap_Bakiye.HeaderText = "Bakiye";
            this.Hesap_Bakiye.Name = "Hesap_Bakiye";
            this.Hesap_Bakiye.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(304, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 24);
            this.label2.TabIndex = 60;
            this.label2.Text = "Ödeme Yapılacak Hesap Türü";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(354, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 24);
            this.label3.TabIndex = 62;
            this.label3.Text = "Ödeme Yapılacak Hesap";
            // 
            // cmb_HesapListesi
            // 
            this.cmb_HesapListesi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_HesapListesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_HesapListesi.FormattingEnabled = true;
            this.cmb_HesapListesi.Items.AddRange(new object[] {
            "Banka Hesapları",
            "Kredi Hesapları"});
            this.cmb_HesapListesi.Location = new System.Drawing.Point(341, 109);
            this.cmb_HesapListesi.Name = "cmb_HesapListesi";
            this.cmb_HesapListesi.Size = new System.Drawing.Size(253, 28);
            this.cmb_HesapListesi.TabIndex = 61;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(337, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(257, 24);
            this.label4.TabIndex = 64;
            this.label4.Text = "Ödeme Yapılacak Kategori";
            // 
            // cmb_KategoriListesi
            // 
            this.cmb_KategoriListesi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_KategoriListesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_KategoriListesi.FormattingEnabled = true;
            this.cmb_KategoriListesi.Items.AddRange(new object[] {
            "Banka Hesapları",
            "Kredi Hesapları"});
            this.cmb_KategoriListesi.Location = new System.Drawing.Point(341, 180);
            this.cmb_KategoriListesi.Name = "cmb_KategoriListesi";
            this.cmb_KategoriListesi.Size = new System.Drawing.Size(253, 28);
            this.cmb_KategoriListesi.TabIndex = 63;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.IndianRed;
            this.label5.Location = new System.Drawing.Point(13, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 79;
            this.label5.Text = "Müşteri No :";
            // 
            // lbl_MusteriNo
            // 
            this.lbl_MusteriNo.AutoSize = true;
            this.lbl_MusteriNo.Location = new System.Drawing.Point(112, 17);
            this.lbl_MusteriNo.Name = "lbl_MusteriNo";
            this.lbl_MusteriNo.Size = new System.Drawing.Size(91, 13);
            this.lbl_MusteriNo.TabIndex = 78;
            this.lbl_MusteriNo.Text = "00000000000000";
            // 
            // btn_OdemeYap
            // 
            this.btn_OdemeYap.BackColor = System.Drawing.Color.LightGreen;
            this.btn_OdemeYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_OdemeYap.Location = new System.Drawing.Point(477, 427);
            this.btn_OdemeYap.Name = "btn_OdemeYap";
            this.btn_OdemeYap.Size = new System.Drawing.Size(117, 41);
            this.btn_OdemeYap.TabIndex = 80;
            this.btn_OdemeYap.Text = "Ödeme Yap";
            this.btn_OdemeYap.UseVisualStyleBackColor = false;
            this.btn_OdemeYap.Click += new System.EventHandler(this.btn_OdemeYap_Click);
            // 
            // btn_Geri
            // 
            this.btn_Geri.BackColor = System.Drawing.Color.Coral;
            this.btn_Geri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Geri.Location = new System.Drawing.Point(16, 427);
            this.btn_Geri.Name = "btn_Geri";
            this.btn_Geri.Size = new System.Drawing.Size(99, 41);
            this.btn_Geri.TabIndex = 81;
            this.btn_Geri.Text = "Kapat";
            this.btn_Geri.UseVisualStyleBackColor = false;
            this.btn_Geri.Click += new System.EventHandler(this.btn_Geri_Click);
            // 
            // txt_Aciklama
            // 
            this.txt_Aciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Aciklama.Location = new System.Drawing.Point(16, 150);
            this.txt_Aciklama.MaxLength = 99;
            this.txt_Aciklama.Multiline = true;
            this.txt_Aciklama.Name = "txt_Aciklama";
            this.txt_Aciklama.Size = new System.Drawing.Size(253, 58);
            this.txt_Aciklama.TabIndex = 83;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(12, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 24);
            this.label6.TabIndex = 82;
            this.label6.Text = "Açıklama";
            // 
            // frm_OdemeYap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 480);
            this.Controls.Add(this.txt_Aciklama);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_Geri);
            this.Controls.Add(this.btn_OdemeYap);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_MusteriNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_KategoriListesi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_HesapListesi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_HesapTuru);
            this.Controls.Add(this.txt_OdemeTutari);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtg_HesapGoruntule);
            this.Name = "frm_OdemeYap";
            this.Text = "Ödeme Yap";
            this.Load += new System.EventHandler(this.frm_OdemeYap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_HesapGoruntule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_HesapTuru;
        private System.Windows.Forms.TextBox txt_OdemeTutari;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtg_HesapGoruntule;
        private System.Windows.Forms.DataGridViewTextBoxColumn BankaHesapNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn BankIban;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hesap_Bakiye;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_HesapListesi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_KategoriListesi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_MusteriNo;
        private System.Windows.Forms.Button btn_OdemeYap;
        private System.Windows.Forms.Button btn_Geri;
        private System.Windows.Forms.TextBox txt_Aciklama;
        private System.Windows.Forms.Label label6;
    }
}