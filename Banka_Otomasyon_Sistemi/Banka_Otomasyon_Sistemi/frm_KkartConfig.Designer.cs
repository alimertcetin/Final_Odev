namespace Banka_Otomasyon_Sistemi
{
    partial class frm_KkartConfig
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
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_Limit = new System.Windows.Forms.ComboBox();
            this.cmb_HesapKesim = new System.Windows.Forms.ComboBox();
            this.cmb_SonOdeme = new System.Windows.Forms.ComboBox();
            this.btn_Onayla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 24);
            this.label4.TabIndex = 20;
            this.label4.Text = "Hesap Kesim Günü :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(91, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "Kredi Limiti :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(23, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 24);
            this.label2.TabIndex = 29;
            this.label2.Text = "Son Ödeme Günü :";
            // 
            // cmb_Limit
            // 
            this.cmb_Limit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Limit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_Limit.FormattingEnabled = true;
            this.cmb_Limit.Items.AddRange(new object[] {
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
            this.cmb_Limit.Location = new System.Drawing.Point(224, 18);
            this.cmb_Limit.Name = "cmb_Limit";
            this.cmb_Limit.Size = new System.Drawing.Size(122, 28);
            this.cmb_Limit.TabIndex = 31;
            // 
            // cmb_HesapKesim
            // 
            this.cmb_HesapKesim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_HesapKesim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_HesapKesim.FormattingEnabled = true;
            this.cmb_HesapKesim.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.cmb_HesapKesim.Location = new System.Drawing.Point(224, 60);
            this.cmb_HesapKesim.Name = "cmb_HesapKesim";
            this.cmb_HesapKesim.Size = new System.Drawing.Size(122, 28);
            this.cmb_HesapKesim.TabIndex = 32;
            // 
            // cmb_SonOdeme
            // 
            this.cmb_SonOdeme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_SonOdeme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_SonOdeme.FormattingEnabled = true;
            this.cmb_SonOdeme.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.cmb_SonOdeme.Location = new System.Drawing.Point(224, 106);
            this.cmb_SonOdeme.Name = "cmb_SonOdeme";
            this.cmb_SonOdeme.Size = new System.Drawing.Size(122, 28);
            this.cmb_SonOdeme.TabIndex = 33;
            // 
            // btn_Onayla
            // 
            this.btn_Onayla.BackColor = System.Drawing.Color.LightGreen;
            this.btn_Onayla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Onayla.Location = new System.Drawing.Point(222, 159);
            this.btn_Onayla.Name = "btn_Onayla";
            this.btn_Onayla.Size = new System.Drawing.Size(99, 41);
            this.btn_Onayla.TabIndex = 34;
            this.btn_Onayla.Text = "Onayla";
            this.btn_Onayla.UseVisualStyleBackColor = false;
            this.btn_Onayla.Click += new System.EventHandler(this.btn_Onayla_Click);
            // 
            // frm_KkartConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 213);
            this.Controls.Add(this.btn_Onayla);
            this.Controls.Add(this.cmb_SonOdeme);
            this.Controls.Add(this.cmb_HesapKesim);
            this.Controls.Add(this.cmb_Limit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "frm_KkartConfig";
            this.Text = "Kredi Kartı Ayarları";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_Limit;
        private System.Windows.Forms.ComboBox cmb_HesapKesim;
        private System.Windows.Forms.ComboBox cmb_SonOdeme;
        private System.Windows.Forms.Button btn_Onayla;
    }
}