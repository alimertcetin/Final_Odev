namespace Banka_Otomasyon_Sistemi
{
    partial class frm_AnaSayfa
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
            this.menu_GiseGorevlisi = new System.Windows.Forms.MenuStrip();
            this.müşteriİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hesapİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniHesapOluşturToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hesapSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Yonetici = new System.Windows.Forms.MenuStrip();
            this.çalışanİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çalışanEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çalışanSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çalışanlarıGörüntüleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_musteri = new System.Windows.Forms.MenuStrip();
            this.hesapIşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.musteri_hesaplarımıGörüntüleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.hesapHareketRaporuAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriBilgileriniGörüntüleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriyiBilgisiniSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriBilgisiniDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_GiseGorevlisi.SuspendLayout();
            this.menu_Yonetici.SuspendLayout();
            this.menu_musteri.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu_GiseGorevlisi
            // 
            this.menu_GiseGorevlisi.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşteriİşlemleriToolStripMenuItem,
            this.müşteriToolStripMenuItem});
            this.menu_GiseGorevlisi.Location = new System.Drawing.Point(0, 48);
            this.menu_GiseGorevlisi.Name = "menu_GiseGorevlisi";
            this.menu_GiseGorevlisi.Size = new System.Drawing.Size(804, 24);
            this.menu_GiseGorevlisi.TabIndex = 1;
            this.menu_GiseGorevlisi.Text = "menuStrip1";
            // 
            // müşteriİşlemleriToolStripMenuItem
            // 
            this.müşteriİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hesapİşlemleriToolStripMenuItem,
            this.yeniHesapOluşturToolStripMenuItem,
            this.hesapSilToolStripMenuItem,
            this.hesapHareketRaporuAlToolStripMenuItem});
            this.müşteriİşlemleriToolStripMenuItem.Name = "müşteriİşlemleriToolStripMenuItem";
            this.müşteriİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(142, 20);
            this.müşteriİşlemleriToolStripMenuItem.Text = "Müşteri Hesap İşlemleri";
            // 
            // hesapİşlemleriToolStripMenuItem
            // 
            this.hesapİşlemleriToolStripMenuItem.Name = "hesapİşlemleriToolStripMenuItem";
            this.hesapİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.hesapİşlemleriToolStripMenuItem.Text = "Müşteri Hesaplarını Görüntüle";
            this.hesapİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.calisan_BankHesapGoruntule_Click);
            // 
            // yeniHesapOluşturToolStripMenuItem
            // 
            this.yeniHesapOluşturToolStripMenuItem.Name = "yeniHesapOluşturToolStripMenuItem";
            this.yeniHesapOluşturToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.yeniHesapOluşturToolStripMenuItem.Text = "Yeni Hesap Oluştur";
            this.yeniHesapOluşturToolStripMenuItem.Click += new System.EventHandler(this.yeniBankaHesabıOluşturToolStripMenuItem_Click);
            // 
            // hesapSilToolStripMenuItem
            // 
            this.hesapSilToolStripMenuItem.Name = "hesapSilToolStripMenuItem";
            this.hesapSilToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.hesapSilToolStripMenuItem.Text = "Hesap Sil";
            this.hesapSilToolStripMenuItem.Click += new System.EventHandler(this.hesapSilToolStripMenuItem_Click);
            // 
            // menu_Yonetici
            // 
            this.menu_Yonetici.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.çalışanİşlemleriToolStripMenuItem});
            this.menu_Yonetici.Location = new System.Drawing.Point(0, 24);
            this.menu_Yonetici.Name = "menu_Yonetici";
            this.menu_Yonetici.Size = new System.Drawing.Size(804, 24);
            this.menu_Yonetici.TabIndex = 3;
            this.menu_Yonetici.Text = "menuStrip1";
            // 
            // çalışanİşlemleriToolStripMenuItem
            // 
            this.çalışanİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.çalışanEkleToolStripMenuItem,
            this.çalışanSilToolStripMenuItem,
            this.çalışanlarıGörüntüleToolStripMenuItem});
            this.çalışanİşlemleriToolStripMenuItem.Name = "çalışanİşlemleriToolStripMenuItem";
            this.çalışanİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.çalışanİşlemleriToolStripMenuItem.Text = "Çalışan İşlemleri";
            // 
            // çalışanEkleToolStripMenuItem
            // 
            this.çalışanEkleToolStripMenuItem.Name = "çalışanEkleToolStripMenuItem";
            this.çalışanEkleToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.çalışanEkleToolStripMenuItem.Text = "Çalışan Ekle";
            // 
            // çalışanSilToolStripMenuItem
            // 
            this.çalışanSilToolStripMenuItem.Name = "çalışanSilToolStripMenuItem";
            this.çalışanSilToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.çalışanSilToolStripMenuItem.Text = "Çalışan Sil";
            // 
            // çalışanlarıGörüntüleToolStripMenuItem
            // 
            this.çalışanlarıGörüntüleToolStripMenuItem.Name = "çalışanlarıGörüntüleToolStripMenuItem";
            this.çalışanlarıGörüntüleToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.çalışanlarıGörüntüleToolStripMenuItem.Text = "Çalışanları Görüntüle";
            // 
            // menu_musteri
            // 
            this.menu_musteri.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hesapIşlemleriToolStripMenuItem});
            this.menu_musteri.Location = new System.Drawing.Point(0, 0);
            this.menu_musteri.Name = "menu_musteri";
            this.menu_musteri.Size = new System.Drawing.Size(804, 24);
            this.menu_musteri.TabIndex = 5;
            this.menu_musteri.Text = "menu_musteri";
            // 
            // hesapIşlemleriToolStripMenuItem
            // 
            this.hesapIşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.musteri_hesaplarımıGörüntüleToolStripMenuItem});
            this.hesapIşlemleriToolStripMenuItem.Name = "hesapIşlemleriToolStripMenuItem";
            this.hesapIşlemleriToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.hesapIşlemleriToolStripMenuItem.Text = "Hesap işlemleri";
            // 
            // musteri_hesaplarımıGörüntüleToolStripMenuItem
            // 
            this.musteri_hesaplarımıGörüntüleToolStripMenuItem.Name = "musteri_hesaplarımıGörüntüleToolStripMenuItem";
            this.musteri_hesaplarımıGörüntüleToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.musteri_hesaplarımıGörüntüleToolStripMenuItem.Text = "Hesaplarımı Görüntüle";
            this.musteri_hesaplarımıGörüntüleToolStripMenuItem.Click += new System.EventHandler(this.musteri_hesaplarımıGörüntüleToolStripMenuItem_Click);
            // 
            // btn_cikis
            // 
            this.btn_cikis.BackColor = System.Drawing.Color.Coral;
            this.btn_cikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_cikis.Location = new System.Drawing.Point(12, 117);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(100, 45);
            this.btn_cikis.TabIndex = 48;
            this.btn_cikis.Text = "ÇIKIŞ";
            this.btn_cikis.UseVisualStyleBackColor = false;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // hesapHareketRaporuAlToolStripMenuItem
            // 
            this.hesapHareketRaporuAlToolStripMenuItem.Name = "hesapHareketRaporuAlToolStripMenuItem";
            this.hesapHareketRaporuAlToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.hesapHareketRaporuAlToolStripMenuItem.Text = "Hesap Hareket Raporu al";
            // 
            // müşteriToolStripMenuItem
            // 
            this.müşteriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşteriBilgileriniGörüntüleToolStripMenuItem,
            this.müşteriyiBilgisiniSilToolStripMenuItem,
            this.müşteriBilgisiniDüzenleToolStripMenuItem});
            this.müşteriToolStripMenuItem.Name = "müşteriToolStripMenuItem";
            this.müşteriToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.müşteriToolStripMenuItem.Text = "Müşteri";
            // 
            // müşteriBilgileriniGörüntüleToolStripMenuItem
            // 
            this.müşteriBilgileriniGörüntüleToolStripMenuItem.Name = "müşteriBilgileriniGörüntüleToolStripMenuItem";
            this.müşteriBilgileriniGörüntüleToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.müşteriBilgileriniGörüntüleToolStripMenuItem.Text = "Müşteri Bilgilerini Görüntüle";
            // 
            // müşteriyiBilgisiniSilToolStripMenuItem
            // 
            this.müşteriyiBilgisiniSilToolStripMenuItem.Name = "müşteriyiBilgisiniSilToolStripMenuItem";
            this.müşteriyiBilgisiniSilToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.müşteriyiBilgisiniSilToolStripMenuItem.Text = "Müşteriyi Bilgisini Sil";
            // 
            // müşteriBilgisiniDüzenleToolStripMenuItem
            // 
            this.müşteriBilgisiniDüzenleToolStripMenuItem.Name = "müşteriBilgisiniDüzenleToolStripMenuItem";
            this.müşteriBilgisiniDüzenleToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.müşteriBilgisiniDüzenleToolStripMenuItem.Text = "Müşteri Bilgisini Düzenle";
            // 
            // frm_AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.btn_cikis);
            this.Controls.Add(this.menu_GiseGorevlisi);
            this.Controls.Add(this.menu_Yonetici);
            this.Controls.Add(this.menu_musteri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menu_GiseGorevlisi;
            this.MinimumSize = new System.Drawing.Size(820, 500);
            this.Name = "frm_AnaSayfa";
            this.Text = "frm_AnaSayfa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menu_GiseGorevlisi.ResumeLayout(false);
            this.menu_GiseGorevlisi.PerformLayout();
            this.menu_Yonetici.ResumeLayout(false);
            this.menu_Yonetici.PerformLayout();
            this.menu_musteri.ResumeLayout(false);
            this.menu_musteri.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu_GiseGorevlisi;
        private System.Windows.Forms.ToolStripMenuItem müşteriİşlemleriToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menu_Yonetici;
        private System.Windows.Forms.ToolStripMenuItem çalışanİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çalışanEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çalışanSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çalışanlarıGörüntüleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hesapİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniHesapOluşturToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hesapSilToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menu_musteri;
        private System.Windows.Forms.ToolStripMenuItem hesapIşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem musteri_hesaplarımıGörüntüleToolStripMenuItem;
        private System.Windows.Forms.Button btn_cikis;
        private System.Windows.Forms.ToolStripMenuItem hesapHareketRaporuAlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriBilgileriniGörüntüleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriyiBilgisiniSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriBilgisiniDüzenleToolStripMenuItem;
    }
}