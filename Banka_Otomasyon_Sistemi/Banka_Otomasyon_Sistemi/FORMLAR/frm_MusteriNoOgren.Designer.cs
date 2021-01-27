namespace Banka_Otomasyon_Sistemi
{
    partial class frm_MusteriNoOgren
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
            this.txt_TcNo = new System.Windows.Forms.TextBox();
            this.txt_Soyad = new System.Windows.Forms.TextBox();
            this.txt_Ad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_MusteriNo = new System.Windows.Forms.TextBox();
            this.lbl_Enter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_TcNo
            // 
            this.txt_TcNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_TcNo.Location = new System.Drawing.Point(16, 39);
            this.txt_TcNo.MaxLength = 11;
            this.txt_TcNo.Name = "txt_TcNo";
            this.txt_TcNo.Size = new System.Drawing.Size(200, 26);
            this.txt_TcNo.TabIndex = 67;
            this.txt_TcNo.TextChanged += new System.EventHandler(this.txt_TcNo_TextChanged);
            this.txt_TcNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_TcNo_KeyPress);
            // 
            // txt_Soyad
            // 
            this.txt_Soyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Soyad.Location = new System.Drawing.Point(16, 151);
            this.txt_Soyad.Name = "txt_Soyad";
            this.txt_Soyad.ReadOnly = true;
            this.txt_Soyad.Size = new System.Drawing.Size(200, 26);
            this.txt_Soyad.TabIndex = 69;
            // 
            // txt_Ad
            // 
            this.txt_Ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Ad.Location = new System.Drawing.Point(16, 95);
            this.txt_Ad.Name = "txt_Ad";
            this.txt_Ad.ReadOnly = true;
            this.txt_Ad.Size = new System.Drawing.Size(200, 26);
            this.txt_Ad.TabIndex = 68;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 24);
            this.label3.TabIndex = 66;
            this.label3.Text = "Soy İsim :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 24);
            this.label2.TabIndex = 65;
            this.label2.Text = "İsim :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 24);
            this.label1.TabIndex = 64;
            this.label1.Text = "Tc Kimlik Numarası";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 24);
            this.label4.TabIndex = 70;
            this.label4.Text = "Müşteri Numarası";
            // 
            // txt_MusteriNo
            // 
            this.txt_MusteriNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_MusteriNo.Location = new System.Drawing.Point(16, 207);
            this.txt_MusteriNo.Name = "txt_MusteriNo";
            this.txt_MusteriNo.ReadOnly = true;
            this.txt_MusteriNo.Size = new System.Drawing.Size(200, 26);
            this.txt_MusteriNo.TabIndex = 71;
            // 
            // lbl_Enter
            // 
            this.lbl_Enter.AutoSize = true;
            this.lbl_Enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Enter.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_Enter.Location = new System.Drawing.Point(222, 45);
            this.lbl_Enter.Name = "lbl_Enter";
            this.lbl_Enter.Size = new System.Drawing.Size(47, 17);
            this.lbl_Enter.TabIndex = 72;
            this.lbl_Enter.Text = "Enter";
            this.lbl_Enter.Visible = false;
            // 
            // frm_MusteriNoOgren
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 259);
            this.Controls.Add(this.lbl_Enter);
            this.Controls.Add(this.txt_MusteriNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_TcNo);
            this.Controls.Add(this.txt_Soyad);
            this.Controls.Add(this.txt_Ad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_MusteriNoOgren";
            this.Text = "frm_MusteriNoOgren";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_TcNo;
        private System.Windows.Forms.TextBox txt_Soyad;
        private System.Windows.Forms.TextBox txt_Ad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_MusteriNo;
        private System.Windows.Forms.Label lbl_Enter;
    }
}