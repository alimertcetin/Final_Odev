namespace Banka_Otomasyon_Sistemi
{
    partial class frm_HesapSil
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
            this.btn_sil = new System.Windows.Forms.Button();
            this.txt_Soyad = new System.Windows.Forms.TextBox();
            this.txt_Ad = new System.Windows.Forms.TextBox();
            this.txt_MusteriNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp_DogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.cmb_SilinecekHesap = new System.Windows.Forms.ComboBox();
            this.lbl_Enter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_sil
            // 
            this.btn_sil.BackColor = System.Drawing.Color.Brown;
            this.btn_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sil.Location = new System.Drawing.Point(289, 183);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(99, 41);
            this.btn_sil.TabIndex = 30;
            this.btn_sil.Text = "SİL";
            this.btn_sil.UseVisualStyleBackColor = false;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // txt_Soyad
            // 
            this.txt_Soyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Soyad.Location = new System.Drawing.Point(190, 123);
            this.txt_Soyad.Name = "txt_Soyad";
            this.txt_Soyad.ReadOnly = true;
            this.txt_Soyad.Size = new System.Drawing.Size(200, 26);
            this.txt_Soyad.TabIndex = 25;
            // 
            // txt_Ad
            // 
            this.txt_Ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Ad.Location = new System.Drawing.Point(190, 91);
            this.txt_Ad.Name = "txt_Ad";
            this.txt_Ad.ReadOnly = true;
            this.txt_Ad.Size = new System.Drawing.Size(200, 26);
            this.txt_Ad.TabIndex = 24;
            // 
            // txt_MusteriNo
            // 
            this.txt_MusteriNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_MusteriNo.Location = new System.Drawing.Point(190, 27);
            this.txt_MusteriNo.MaxLength = 11;
            this.txt_MusteriNo.Name = "txt_MusteriNo";
            this.txt_MusteriNo.Size = new System.Drawing.Size(200, 26);
            this.txt_MusteriNo.TabIndex = 23;
            this.txt_MusteriNo.TextChanged += new System.EventHandler(this.txt_MusteriNo_TextChanged);
            this.txt_MusteriNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_MusteriNo_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(37, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 22);
            this.label4.TabIndex = 20;
            this.label4.Text = "Doğum Tarihi :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(79, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 24);
            this.label3.TabIndex = 19;
            this.label3.Text = "Soy İsim :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(120, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "İsim :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(56, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "Müşteri No :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(11, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 24);
            this.label5.TabIndex = 33;
            this.label5.Text = "Silinecek Hesap No : ";
            this.label5.UseCompatibleTextRendering = true;
            // 
            // dtp_DogumTarihi
            // 
            this.dtp_DogumTarihi.Enabled = false;
            this.dtp_DogumTarihi.Location = new System.Drawing.Point(190, 157);
            this.dtp_DogumTarihi.Name = "dtp_DogumTarihi";
            this.dtp_DogumTarihi.Size = new System.Drawing.Size(200, 20);
            this.dtp_DogumTarihi.TabIndex = 35;
            // 
            // cmb_SilinecekHesap
            // 
            this.cmb_SilinecekHesap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_SilinecekHesap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_SilinecekHesap.FormattingEnabled = true;
            this.cmb_SilinecekHesap.Items.AddRange(new object[] {
            "500",
            "1000",
            "2000",
            "3000",
            "4000",
            "5000",
            "6000",
            "7000",
            "8000",
            "9000",
            "10000",
            "15000",
            "20000",
            "40000",
            "60000",
            "80000",
            "100000",
            "150000",
            "200000",
            "250000",
            "300000",
            "350000",
            "400000",
            "450000",
            "500000",
            "550000",
            "600000",
            "650000",
            "700000",
            "750000",
            "800000",
            "850000",
            "900000",
            "1000000"});
            this.cmb_SilinecekHesap.Location = new System.Drawing.Point(190, 57);
            this.cmb_SilinecekHesap.Name = "cmb_SilinecekHesap";
            this.cmb_SilinecekHesap.Size = new System.Drawing.Size(200, 28);
            this.cmb_SilinecekHesap.TabIndex = 37;
            // 
            // lbl_Enter
            // 
            this.lbl_Enter.AutoSize = true;
            this.lbl_Enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Enter.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_Enter.Location = new System.Drawing.Point(343, 7);
            this.lbl_Enter.Name = "lbl_Enter";
            this.lbl_Enter.Size = new System.Drawing.Size(47, 17);
            this.lbl_Enter.TabIndex = 74;
            this.lbl_Enter.Text = "Enter";
            this.lbl_Enter.Visible = false;
            // 
            // frm_HesapSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 232);
            this.Controls.Add(this.lbl_Enter);
            this.Controls.Add(this.cmb_SilinecekHesap);
            this.Controls.Add(this.dtp_DogumTarihi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.txt_Soyad);
            this.Controls.Add(this.txt_Ad);
            this.Controls.Add(this.txt_MusteriNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_HesapSil";
            this.Text = "Hesap Sil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.TextBox txt_Soyad;
        private System.Windows.Forms.TextBox txt_Ad;
        private System.Windows.Forms.TextBox txt_MusteriNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp_DogumTarihi;
        private System.Windows.Forms.ComboBox cmb_SilinecekHesap;
        private System.Windows.Forms.Label lbl_Enter;
    }
}