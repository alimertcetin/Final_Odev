namespace Banka_Otomasyon_Sistemi
{
    partial class frm_HesapGoruntule
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
            this.components = new System.ComponentModel.Container();
            this.dtg_HesapGoruntule = new System.Windows.Forms.DataGridView();
            this.BankaHesapNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BankIban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hesap_Bakiye = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_MusteriNo = new System.Windows.Forms.TextBox();
            this.txt_Soyad = new System.Windows.Forms.TextBox();
            this.txt_Ad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_TcNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_HesapListesi = new System.Windows.Forms.ComboBox();
            this.menu_Calisan = new System.Windows.Forms.MenuStrip();
            this.hesapİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paraÇekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paraYatırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Musteri = new System.Windows.Forms.MenuStrip();
            this.hesapİşlemleriToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.hesapHareketleriniGörüntüleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_HesapGoruntule)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.menu_Calisan.SuspendLayout();
            this.menu_Musteri.SuspendLayout();
            this.SuspendLayout();
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
            this.dtg_HesapGoruntule.ContextMenuStrip = this.contextMenuStrip1;
            this.dtg_HesapGoruntule.Location = new System.Drawing.Point(14, 158);
            this.dtg_HesapGoruntule.Name = "dtg_HesapGoruntule";
            this.dtg_HesapGoruntule.ReadOnly = true;
            this.dtg_HesapGoruntule.Size = new System.Drawing.Size(578, 331);
            this.dtg_HesapGoruntule.TabIndex = 0;
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.AllowMerge = false;
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 48);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(105, 22);
            this.toolStripMenuItem1.Text = "Yenile";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // txt_MusteriNo
            // 
            this.txt_MusteriNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_MusteriNo.Location = new System.Drawing.Point(392, 94);
            this.txt_MusteriNo.MaxLength = 11;
            this.txt_MusteriNo.Name = "txt_MusteriNo";
            this.txt_MusteriNo.Size = new System.Drawing.Size(200, 26);
            this.txt_MusteriNo.TabIndex = 37;
            this.txt_MusteriNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_MusteriNo_KeyPress);
            // 
            // txt_Soyad
            // 
            this.txt_Soyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Soyad.Location = new System.Drawing.Point(139, 94);
            this.txt_Soyad.Name = "txt_Soyad";
            this.txt_Soyad.ReadOnly = true;
            this.txt_Soyad.Size = new System.Drawing.Size(200, 26);
            this.txt_Soyad.TabIndex = 39;
            // 
            // txt_Ad
            // 
            this.txt_Ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Ad.Location = new System.Drawing.Point(139, 62);
            this.txt_Ad.Name = "txt_Ad";
            this.txt_Ad.ReadOnly = true;
            this.txt_Ad.Size = new System.Drawing.Size(200, 26);
            this.txt_Ad.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(14, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 24);
            this.label3.TabIndex = 33;
            this.label3.Text = "Soy İsim :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(55, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 24);
            this.label2.TabIndex = 32;
            this.label2.Text = "İsim :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(388, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 24);
            this.label1.TabIndex = 31;
            this.label1.Text = "Müşteri No";
            // 
            // txt_TcNo
            // 
            this.txt_TcNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_TcNo.Location = new System.Drawing.Point(139, 126);
            this.txt_TcNo.Name = "txt_TcNo";
            this.txt_TcNo.ReadOnly = true;
            this.txt_TcNo.Size = new System.Drawing.Size(200, 26);
            this.txt_TcNo.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(35, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 24);
            this.label4.TabIndex = 46;
            this.label4.Text = "Tc No :";
            // 
            // cmb_HesapListesi
            // 
            this.cmb_HesapListesi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_HesapListesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_HesapListesi.FormattingEnabled = true;
            this.cmb_HesapListesi.Items.AddRange(new object[] {
            "Banka Hesapları",
            "Kredi Hesapları"});
            this.cmb_HesapListesi.Location = new System.Drawing.Point(392, 124);
            this.cmb_HesapListesi.Name = "cmb_HesapListesi";
            this.cmb_HesapListesi.Size = new System.Drawing.Size(200, 28);
            this.cmb_HesapListesi.TabIndex = 49;
            this.cmb_HesapListesi.SelectedIndexChanged += new System.EventHandler(this.cmb_HesapListesi_SelectedIndexChanged);
            // 
            // menu_Calisan
            // 
            this.menu_Calisan.AllowMerge = false;
            this.menu_Calisan.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hesapİşlemleriToolStripMenuItem});
            this.menu_Calisan.Location = new System.Drawing.Point(0, 24);
            this.menu_Calisan.Name = "menu_Calisan";
            this.menu_Calisan.Size = new System.Drawing.Size(604, 24);
            this.menu_Calisan.TabIndex = 50;
            this.menu_Calisan.Text = "menu_Calisan";
            // 
            // hesapİşlemleriToolStripMenuItem
            // 
            this.hesapİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paraÇekToolStripMenuItem,
            this.paraYatırToolStripMenuItem});
            this.hesapİşlemleriToolStripMenuItem.Name = "hesapİşlemleriToolStripMenuItem";
            this.hesapİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.hesapİşlemleriToolStripMenuItem.Text = "Hesap İşlemleri";
            // 
            // paraÇekToolStripMenuItem
            // 
            this.paraÇekToolStripMenuItem.Name = "paraÇekToolStripMenuItem";
            this.paraÇekToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.paraÇekToolStripMenuItem.Text = "Para Çek";
            this.paraÇekToolStripMenuItem.Click += new System.EventHandler(this.paraÇekToolStripMenuItem_Click);
            // 
            // paraYatırToolStripMenuItem
            // 
            this.paraYatırToolStripMenuItem.Name = "paraYatırToolStripMenuItem";
            this.paraYatırToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.paraYatırToolStripMenuItem.Text = "Para Yatır";
            this.paraYatırToolStripMenuItem.Click += new System.EventHandler(this.paraYatırToolStripMenuItem_Click);
            // 
            // menu_Musteri
            // 
            this.menu_Musteri.AllowMerge = false;
            this.menu_Musteri.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hesapİşlemleriToolStripMenuItem1});
            this.menu_Musteri.Location = new System.Drawing.Point(0, 0);
            this.menu_Musteri.Name = "menu_Musteri";
            this.menu_Musteri.Size = new System.Drawing.Size(604, 24);
            this.menu_Musteri.TabIndex = 51;
            this.menu_Musteri.Text = "menuStrip1";
            // 
            // hesapİşlemleriToolStripMenuItem1
            // 
            this.hesapİşlemleriToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hesapHareketleriniGörüntüleToolStripMenuItem});
            this.hesapİşlemleriToolStripMenuItem1.Name = "hesapİşlemleriToolStripMenuItem1";
            this.hesapİşlemleriToolStripMenuItem1.Size = new System.Drawing.Size(99, 20);
            this.hesapİşlemleriToolStripMenuItem1.Text = "Hesap İşlemleri";
            // 
            // hesapHareketleriniGörüntüleToolStripMenuItem
            // 
            this.hesapHareketleriniGörüntüleToolStripMenuItem.Name = "hesapHareketleriniGörüntüleToolStripMenuItem";
            this.hesapHareketleriniGörüntüleToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.hesapHareketleriniGörüntüleToolStripMenuItem.Text = "Hesap Hareketlerini Görüntüle";
            // 
            // frm_HesapGoruntule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 501);
            this.Controls.Add(this.menu_Calisan);
            this.Controls.Add(this.menu_Musteri);
            this.Controls.Add(this.cmb_HesapListesi);
            this.Controls.Add(this.txt_TcNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_MusteriNo);
            this.Controls.Add(this.txt_Soyad);
            this.Controls.Add(this.txt_Ad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtg_HesapGoruntule);
            this.MainMenuStrip = this.menu_Calisan;
            this.Name = "frm_HesapGoruntule";
            this.Text = "frm_BankHesapGoruntule";
            this.Load += new System.EventHandler(this.frm_HesapGoruntule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_HesapGoruntule)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.menu_Calisan.ResumeLayout(false);
            this.menu_Calisan.PerformLayout();
            this.menu_Musteri.ResumeLayout(false);
            this.menu_Musteri.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_HesapGoruntule;
        private System.Windows.Forms.TextBox txt_MusteriNo;
        private System.Windows.Forms.TextBox txt_Soyad;
        private System.Windows.Forms.TextBox txt_Ad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_TcNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn BankaHesapNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn BankIban;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hesap_Bakiye;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ComboBox cmb_HesapListesi;
        private System.Windows.Forms.MenuStrip menu_Calisan;
        private System.Windows.Forms.ToolStripMenuItem hesapİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paraÇekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paraYatırToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menu_Musteri;
        private System.Windows.Forms.ToolStripMenuItem hesapİşlemleriToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem hesapHareketleriniGörüntüleToolStripMenuItem;
    }
}