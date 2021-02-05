namespace Banka_Otomasyon_Sistemi
{
    partial class frm_MusteriBilgileriniGoruntuleDuzenle
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
            this.txt_MusteriNo = new System.Windows.Forms.TextBox();
            this.txt_Soyad = new System.Windows.Forms.TextBox();
            this.txt_Ad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_iptalEt = new System.Windows.Forms.Button();
            this.btn_Onayla = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_DogumYeri = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtp_DogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.lbl_Enter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_MusteriNo
            // 
            this.txt_MusteriNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_MusteriNo.Location = new System.Drawing.Point(16, 39);
            this.txt_MusteriNo.MaxLength = 11;
            this.txt_MusteriNo.Name = "txt_MusteriNo";
            this.txt_MusteriNo.Size = new System.Drawing.Size(200, 26);
            this.txt_MusteriNo.TabIndex = 56;
            this.txt_MusteriNo.TextChanged += new System.EventHandler(this.txt_MusteriNo_TextChanged);
            this.txt_MusteriNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_MusteriNo_KeyPress);
            // 
            // txt_Soyad
            // 
            this.txt_Soyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Soyad.Location = new System.Drawing.Point(16, 151);
            this.txt_Soyad.Name = "txt_Soyad";
            this.txt_Soyad.ReadOnly = true;
            this.txt_Soyad.Size = new System.Drawing.Size(200, 26);
            this.txt_Soyad.TabIndex = 58;
            // 
            // txt_Ad
            // 
            this.txt_Ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Ad.Location = new System.Drawing.Point(16, 95);
            this.txt_Ad.Name = "txt_Ad";
            this.txt_Ad.ReadOnly = true;
            this.txt_Ad.Size = new System.Drawing.Size(200, 26);
            this.txt_Ad.TabIndex = 57;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 24);
            this.label3.TabIndex = 55;
            this.label3.Text = "Soy İsim :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 24);
            this.label2.TabIndex = 54;
            this.label2.Text = "İsim :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 24);
            this.label1.TabIndex = 53;
            this.label1.Text = "Müşteri No";
            // 
            // btn_iptalEt
            // 
            this.btn_iptalEt.BackColor = System.Drawing.Color.Coral;
            this.btn_iptalEt.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_iptalEt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_iptalEt.Location = new System.Drawing.Point(238, 26);
            this.btn_iptalEt.Name = "btn_iptalEt";
            this.btn_iptalEt.Size = new System.Drawing.Size(99, 53);
            this.btn_iptalEt.TabIndex = 62;
            this.btn_iptalEt.Text = "İptal Et";
            this.btn_iptalEt.UseVisualStyleBackColor = false;
            this.btn_iptalEt.Click += new System.EventHandler(this.btn_iptalEt_Click);
            // 
            // btn_Onayla
            // 
            this.btn_Onayla.BackColor = System.Drawing.Color.LightGreen;
            this.btn_Onayla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Onayla.Location = new System.Drawing.Point(238, 250);
            this.btn_Onayla.Name = "btn_Onayla";
            this.btn_Onayla.Size = new System.Drawing.Size(99, 53);
            this.btn_Onayla.TabIndex = 61;
            this.btn_Onayla.Text = "Onayla";
            this.btn_Onayla.UseVisualStyleBackColor = false;
            this.btn_Onayla.Click += new System.EventHandler(this.btn_Onayla_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.BackColor = System.Drawing.Color.Brown;
            this.btn_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sil.Location = new System.Drawing.Point(238, 136);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(99, 53);
            this.btn_sil.TabIndex = 63;
            this.btn_sil.Text = "SİL";
            this.btn_sil.UseVisualStyleBackColor = false;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 24);
            this.label5.TabIndex = 64;
            this.label5.Text = "Doğum Tarihi :";
            // 
            // txt_DogumYeri
            // 
            this.txt_DogumYeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_DogumYeri.Location = new System.Drawing.Point(16, 263);
            this.txt_DogumYeri.Name = "txt_DogumYeri";
            this.txt_DogumYeri.ReadOnly = true;
            this.txt_DogumYeri.Size = new System.Drawing.Size(200, 26);
            this.txt_DogumYeri.TabIndex = 67;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(12, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 24);
            this.label6.TabIndex = 66;
            this.label6.Text = "Doğum Yeri :";
            // 
            // dtp_DogumTarihi
            // 
            this.dtp_DogumTarihi.Enabled = false;
            this.dtp_DogumTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtp_DogumTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_DogumTarihi.Location = new System.Drawing.Point(16, 207);
            this.dtp_DogumTarihi.Name = "dtp_DogumTarihi";
            this.dtp_DogumTarihi.Size = new System.Drawing.Size(200, 26);
            this.dtp_DogumTarihi.TabIndex = 68;
            // 
            // lbl_Enter
            // 
            this.lbl_Enter.AutoSize = true;
            this.lbl_Enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Enter.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_Enter.Location = new System.Drawing.Point(169, 15);
            this.lbl_Enter.Name = "lbl_Enter";
            this.lbl_Enter.Size = new System.Drawing.Size(47, 17);
            this.lbl_Enter.TabIndex = 73;
            this.lbl_Enter.Text = "Enter";
            this.lbl_Enter.Visible = false;
            // 
            // frm_MusteriBilgileriniGoruntuleDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_iptalEt;
            this.ClientSize = new System.Drawing.Size(349, 312);
            this.Controls.Add(this.lbl_Enter);
            this.Controls.Add(this.dtp_DogumTarihi);
            this.Controls.Add(this.txt_DogumYeri);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_iptalEt);
            this.Controls.Add(this.btn_Onayla);
            this.Controls.Add(this.txt_MusteriNo);
            this.Controls.Add(this.txt_Soyad);
            this.Controls.Add(this.txt_Ad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_MusteriBilgileriniGoruntuleDuzenle";
            this.Text = "Müşteri Bilgilerini Düzenle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_MusteriNo;
        private System.Windows.Forms.TextBox txt_Soyad;
        private System.Windows.Forms.TextBox txt_Ad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_iptalEt;
        private System.Windows.Forms.Button btn_Onayla;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_DogumYeri;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtp_DogumTarihi;
        private System.Windows.Forms.Label lbl_Enter;
    }
}