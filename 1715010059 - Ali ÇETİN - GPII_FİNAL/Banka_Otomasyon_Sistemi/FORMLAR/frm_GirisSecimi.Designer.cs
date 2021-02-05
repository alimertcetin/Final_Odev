namespace Banka_Otomasyon_Sistemi
{
    partial class frm_GirisSecimi
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
            this.btn_pGiris = new System.Windows.Forms.Button();
            this.btn_kGiris = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_pGiris
            // 
            this.btn_pGiris.BackColor = System.Drawing.Color.Coral;
            this.btn_pGiris.Font = new System.Drawing.Font("Georgia Pro", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_pGiris.Location = new System.Drawing.Point(9, 12);
            this.btn_pGiris.Name = "btn_pGiris";
            this.btn_pGiris.Size = new System.Drawing.Size(203, 90);
            this.btn_pGiris.TabIndex = 0;
            this.btn_pGiris.Text = "Personel Girişi";
            this.btn_pGiris.UseVisualStyleBackColor = false;
            this.btn_pGiris.Click += new System.EventHandler(this.btn_pGiris_Click);
            // 
            // btn_kGiris
            // 
            this.btn_kGiris.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_kGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kGiris.Location = new System.Drawing.Point(220, 12);
            this.btn_kGiris.Name = "btn_kGiris";
            this.btn_kGiris.Size = new System.Drawing.Size(203, 90);
            this.btn_kGiris.TabIndex = 1;
            this.btn_kGiris.Text = "Kullanıcı Girişi";
            this.btn_kGiris.UseVisualStyleBackColor = false;
            this.btn_kGiris.Click += new System.EventHandler(this.btn_kGiris_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(103, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Banka Otomasyon Sistemi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(180, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ali ÇETİN";
            // 
            // frm_GirisSecimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 160);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_kGiris);
            this.Controls.Add(this.btn_pGiris);
            this.Name = "frm_GirisSecimi";
            this.Text = "Giriş";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_pGiris;
        private System.Windows.Forms.Button btn_kGiris;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

