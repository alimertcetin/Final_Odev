namespace Banka_Otomasyon_Sistemi
{
    partial class frm_ParaCekYatir
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
            this.txt_HesapNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_Miktar = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Onayla = new System.Windows.Forms.Button();
            this.btn_iptalEt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_HesapNo
            // 
            this.txt_HesapNo.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txt_HesapNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_HesapNo.Location = new System.Drawing.Point(16, 39);
            this.txt_HesapNo.MaxLength = 11;
            this.txt_HesapNo.Name = "txt_HesapNo";
            this.txt_HesapNo.ReadOnly = true;
            this.txt_HesapNo.Size = new System.Drawing.Size(168, 26);
            this.txt_HesapNo.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 24);
            this.label1.TabIndex = 38;
            this.label1.Text = "Hesap No";
            // 
            // cmb_Miktar
            // 
            this.cmb_Miktar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Miktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_Miktar.FormattingEnabled = true;
            this.cmb_Miktar.Items.AddRange(new object[] {
            "10",
            "20",
            "40",
            "50",
            "100",
            "200",
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
            this.cmb_Miktar.Location = new System.Drawing.Point(16, 117);
            this.cmb_Miktar.Name = "cmb_Miktar";
            this.cmb_Miktar.Size = new System.Drawing.Size(168, 28);
            this.cmb_Miktar.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 40;
            this.label2.Text = "Tutar";
            // 
            // btn_Onayla
            // 
            this.btn_Onayla.BackColor = System.Drawing.Color.LightGreen;
            this.btn_Onayla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Onayla.Location = new System.Drawing.Point(214, 110);
            this.btn_Onayla.Name = "btn_Onayla";
            this.btn_Onayla.Size = new System.Drawing.Size(99, 41);
            this.btn_Onayla.TabIndex = 46;
            this.btn_Onayla.Text = "Onayla";
            this.btn_Onayla.UseVisualStyleBackColor = false;
            this.btn_Onayla.Click += new System.EventHandler(this.btn_Onayla_Click);
            // 
            // btn_iptalEt
            // 
            this.btn_iptalEt.BackColor = System.Drawing.Color.Coral;
            this.btn_iptalEt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_iptalEt.Location = new System.Drawing.Point(214, 32);
            this.btn_iptalEt.Name = "btn_iptalEt";
            this.btn_iptalEt.Size = new System.Drawing.Size(99, 41);
            this.btn_iptalEt.TabIndex = 47;
            this.btn_iptalEt.Text = "İptal Et";
            this.btn_iptalEt.UseVisualStyleBackColor = false;
            this.btn_iptalEt.Click += new System.EventHandler(this.btn_iptalEt_Click);
            // 
            // frm_ParaCekYatir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 165);
            this.Controls.Add(this.btn_iptalEt);
            this.Controls.Add(this.btn_Onayla);
            this.Controls.Add(this.cmb_Miktar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_HesapNo);
            this.Controls.Add(this.label1);
            this.Name = "frm_ParaCekYatir";
            this.Text = "frm_ParaCek";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_HesapNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_Miktar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Onayla;
        private System.Windows.Forms.Button btn_iptalEt;
    }
}