namespace Banka_Otomasyon_Sistemi
{
    partial class frm_GecisHesapOlustur
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
            this.btn_kGiris = new System.Windows.Forms.Button();
            this.btn_pGiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_kGiris
            // 
            this.btn_kGiris.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_kGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kGiris.Location = new System.Drawing.Point(223, 12);
            this.btn_kGiris.Name = "btn_kGiris";
            this.btn_kGiris.Size = new System.Drawing.Size(203, 90);
            this.btn_kGiris.TabIndex = 3;
            this.btn_kGiris.Text = "İlk Defa Hesap Oluşturacağım";
            this.btn_kGiris.UseVisualStyleBackColor = false;
            this.btn_kGiris.Click += new System.EventHandler(this.btn_kGiris_Click);
            // 
            // btn_pGiris
            // 
            this.btn_pGiris.BackColor = System.Drawing.Color.Coral;
            this.btn_pGiris.Font = new System.Drawing.Font("Georgia Pro", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_pGiris.Location = new System.Drawing.Point(12, 12);
            this.btn_pGiris.Name = "btn_pGiris";
            this.btn_pGiris.Size = new System.Drawing.Size(203, 90);
            this.btn_pGiris.TabIndex = 2;
            this.btn_pGiris.Text = "Daha Önce Hesap Oluşturdum";
            this.btn_pGiris.UseVisualStyleBackColor = false;
            this.btn_pGiris.Click += new System.EventHandler(this.btn_pGiris_Click);
            // 
            // frm_GecisHesapOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 118);
            this.Controls.Add(this.btn_kGiris);
            this.Controls.Add(this.btn_pGiris);
            this.Name = "frm_GecisHesapOlustur";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_kGiris;
        private System.Windows.Forms.Button btn_pGiris;
    }
}