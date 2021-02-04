namespace Banka_Otomasyon_Sistemi
{
    partial class frm_HesapRaporuAl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_HesapRaporuAl));
            this.btn_RaporAl = new System.Windows.Forms.Button();
            this.txt_HesapNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtg_HesapGoruntule = new System.Windows.Forms.DataGridView();
            this.islemTutari = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.islemAciklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.islemKategoriID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.islemTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_Baslangic = new System.Windows.Forms.DateTimePicker();
            this.dtp_Bitis = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_HesapGoruntule)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_RaporAl
            // 
            this.btn_RaporAl.BackColor = System.Drawing.Color.LightGreen;
            this.btn_RaporAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_RaporAl.Location = new System.Drawing.Point(495, 32);
            this.btn_RaporAl.Name = "btn_RaporAl";
            this.btn_RaporAl.Size = new System.Drawing.Size(99, 41);
            this.btn_RaporAl.TabIndex = 52;
            this.btn_RaporAl.Text = "Çıktı Al";
            this.btn_RaporAl.UseVisualStyleBackColor = false;
            this.btn_RaporAl.Click += new System.EventHandler(this.btn_RaporAl_Click);
            // 
            // txt_HesapNo
            // 
            this.txt_HesapNo.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txt_HesapNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_HesapNo.Location = new System.Drawing.Point(121, 9);
            this.txt_HesapNo.MaxLength = 11;
            this.txt_HesapNo.Name = "txt_HesapNo";
            this.txt_HesapNo.ReadOnly = true;
            this.txt_HesapNo.Size = new System.Drawing.Size(168, 26);
            this.txt_HesapNo.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 24);
            this.label1.TabIndex = 49;
            this.label1.Text = "Hesap No";
            // 
            // dtg_HesapGoruntule
            // 
            this.dtg_HesapGoruntule.AllowUserToAddRows = false;
            this.dtg_HesapGoruntule.AllowUserToDeleteRows = false;
            this.dtg_HesapGoruntule.AllowUserToResizeRows = false;
            this.dtg_HesapGoruntule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_HesapGoruntule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_HesapGoruntule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.islemTutari,
            this.islemAciklama,
            this.islemKategoriID,
            this.islemTarihi});
            this.dtg_HesapGoruntule.Location = new System.Drawing.Point(16, 119);
            this.dtg_HesapGoruntule.Name = "dtg_HesapGoruntule";
            this.dtg_HesapGoruntule.ReadOnly = true;
            this.dtg_HesapGoruntule.Size = new System.Drawing.Size(578, 331);
            this.dtg_HesapGoruntule.TabIndex = 53;
            // 
            // islemTutari
            // 
            this.islemTutari.DataPropertyName = "islemTutari";
            this.islemTutari.HeaderText = "İşlem Tutarı";
            this.islemTutari.Name = "islemTutari";
            this.islemTutari.ReadOnly = true;
            // 
            // islemAciklama
            // 
            this.islemAciklama.DataPropertyName = "islemAciklama";
            this.islemAciklama.HeaderText = "Açıklama";
            this.islemAciklama.Name = "islemAciklama";
            this.islemAciklama.ReadOnly = true;
            // 
            // islemKategoriID
            // 
            this.islemKategoriID.DataPropertyName = "islemKategoriID";
            this.islemKategoriID.HeaderText = "Kategori";
            this.islemKategoriID.Name = "islemKategoriID";
            this.islemKategoriID.ReadOnly = true;
            // 
            // islemTarihi
            // 
            this.islemTarihi.DataPropertyName = "islemTarihi";
            this.islemTarihi.HeaderText = "İşlem Tarihi";
            this.islemTarihi.Name = "islemTarihi";
            this.islemTarihi.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(417, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 24);
            this.label2.TabIndex = 54;
            this.label2.Text = "Hesap Hareketleri";
            // 
            // dtp_Baslangic
            // 
            this.dtp_Baslangic.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Baslangic.Location = new System.Drawing.Point(121, 42);
            this.dtp_Baslangic.Name = "dtp_Baslangic";
            this.dtp_Baslangic.Size = new System.Drawing.Size(102, 20);
            this.dtp_Baslangic.TabIndex = 55;
            this.dtp_Baslangic.Value = new System.DateTime(2021, 1, 20, 0, 0, 0, 0);
            this.dtp_Baslangic.ValueChanged += new System.EventHandler(this.dtp_Baslangic_ValueChanged);
            // 
            // dtp_Bitis
            // 
            this.dtp_Bitis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Bitis.Location = new System.Drawing.Point(121, 75);
            this.dtp_Bitis.Name = "dtp_Bitis";
            this.dtp_Bitis.Size = new System.Drawing.Size(102, 20);
            this.dtp_Bitis.TabIndex = 56;
            this.dtp_Bitis.ValueChanged += new System.EventHandler(this.dtp_Bitis_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(28, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 57;
            this.label3.Text = "Başlangıç";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(71, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 58;
            this.label4.Text = "Bitiş";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // frm_HesapRaporuAl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 461);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtp_Bitis);
            this.Controls.Add(this.dtp_Baslangic);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtg_HesapGoruntule);
            this.Controls.Add(this.btn_RaporAl);
            this.Controls.Add(this.txt_HesapNo);
            this.Controls.Add(this.label1);
            this.Name = "frm_HesapRaporuAl";
            this.Text = "Hesap Hareketleri";
            this.Load += new System.EventHandler(this.frm_HesapRaporuAl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_HesapGoruntule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_RaporAl;
        private System.Windows.Forms.TextBox txt_HesapNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtg_HesapGoruntule;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn islemTutari;
        private System.Windows.Forms.DataGridViewTextBoxColumn islemAciklama;
        private System.Windows.Forms.DataGridViewTextBoxColumn islemKategoriID;
        private System.Windows.Forms.DataGridViewTextBoxColumn islemTarihi;
        private System.Windows.Forms.DateTimePicker dtp_Baslangic;
        private System.Windows.Forms.DateTimePicker dtp_Bitis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}