namespace Banka_Otomasyon_Sistemi
{
    partial class frm_CalisanlariGoruntule
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.yenileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çalışanıSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çalışanıGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_CalisanEkle = new System.Windows.Forms.Button();
            this.dtv_Calisanlar = new System.Windows.Forms.DataGridView();
            this.txt_SicilNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Enter = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtv_Calisanlar)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yenileToolStripMenuItem,
            this.çalışanıSilToolStripMenuItem,
            this.çalışanıGüncelleToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(165, 70);
            // 
            // yenileToolStripMenuItem
            // 
            this.yenileToolStripMenuItem.Name = "yenileToolStripMenuItem";
            this.yenileToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.yenileToolStripMenuItem.Text = "Yenile";
            this.yenileToolStripMenuItem.Click += new System.EventHandler(this.yenileToolStripMenuItem_Click);
            // 
            // çalışanıSilToolStripMenuItem
            // 
            this.çalışanıSilToolStripMenuItem.Name = "çalışanıSilToolStripMenuItem";
            this.çalışanıSilToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.çalışanıSilToolStripMenuItem.Text = "Çalışanı Sil";
            this.çalışanıSilToolStripMenuItem.Click += new System.EventHandler(this.çalışanıSilToolStripMenuItem_Click);
            // 
            // çalışanıGüncelleToolStripMenuItem
            // 
            this.çalışanıGüncelleToolStripMenuItem.Name = "çalışanıGüncelleToolStripMenuItem";
            this.çalışanıGüncelleToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.çalışanıGüncelleToolStripMenuItem.Text = "Çalışanı Güncelle";
            this.çalışanıGüncelleToolStripMenuItem.Click += new System.EventHandler(this.çalışanıGüncelleToolStripMenuItem_Click);
            // 
            // btn_CalisanEkle
            // 
            this.btn_CalisanEkle.BackColor = System.Drawing.Color.LightGreen;
            this.btn_CalisanEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_CalisanEkle.Location = new System.Drawing.Point(512, 12);
            this.btn_CalisanEkle.Name = "btn_CalisanEkle";
            this.btn_CalisanEkle.Size = new System.Drawing.Size(117, 41);
            this.btn_CalisanEkle.TabIndex = 53;
            this.btn_CalisanEkle.Text = "Çalışan Ekle";
            this.btn_CalisanEkle.UseVisualStyleBackColor = false;
            this.btn_CalisanEkle.Click += new System.EventHandler(this.btn_CalisanEkle_Click);
            // 
            // dtv_Calisanlar
            // 
            this.dtv_Calisanlar.AllowUserToAddRows = false;
            this.dtv_Calisanlar.AllowUserToDeleteRows = false;
            this.dtv_Calisanlar.AllowUserToResizeRows = false;
            this.dtv_Calisanlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtv_Calisanlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtv_Calisanlar.ContextMenuStrip = this.contextMenuStrip1;
            this.dtv_Calisanlar.GridColor = System.Drawing.Color.DarkOliveGreen;
            this.dtv_Calisanlar.Location = new System.Drawing.Point(12, 119);
            this.dtv_Calisanlar.Name = "dtv_Calisanlar";
            this.dtv_Calisanlar.ReadOnly = true;
            this.dtv_Calisanlar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtv_Calisanlar.Size = new System.Drawing.Size(616, 331);
            this.dtv_Calisanlar.TabIndex = 54;
            // 
            // txt_SicilNo
            // 
            this.txt_SicilNo.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txt_SicilNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_SicilNo.Location = new System.Drawing.Point(25, 87);
            this.txt_SicilNo.MaxLength = 12;
            this.txt_SicilNo.Name = "txt_SicilNo";
            this.txt_SicilNo.Size = new System.Drawing.Size(168, 26);
            this.txt_SicilNo.TabIndex = 56;
            this.txt_SicilNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_SicilNo_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 55;
            this.label1.Text = "Sicil No :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 24);
            this.label2.TabIndex = 57;
            this.label2.Text = "Çalışan Ara";
            // 
            // lbl_Enter
            // 
            this.lbl_Enter.AutoSize = true;
            this.lbl_Enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Enter.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_Enter.Location = new System.Drawing.Point(199, 93);
            this.lbl_Enter.Name = "lbl_Enter";
            this.lbl_Enter.Size = new System.Drawing.Size(47, 17);
            this.lbl_Enter.TabIndex = 73;
            this.lbl_Enter.Text = "Enter";
            this.lbl_Enter.Visible = false;
            // 
            // frm_CalisanlariGoruntule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 462);
            this.Controls.Add(this.lbl_Enter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_SicilNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtv_Calisanlar);
            this.Controls.Add(this.btn_CalisanEkle);
            this.Name = "frm_CalisanlariGoruntule";
            this.Text = "Çalışanları Görüntüle";
            this.Load += new System.EventHandler(this.frm_CalisanlariGoruntule_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtv_Calisanlar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem çalışanıSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yenileToolStripMenuItem;
        private System.Windows.Forms.Button btn_CalisanEkle;
        private System.Windows.Forms.DataGridView dtv_Calisanlar;
        private System.Windows.Forms.TextBox txt_SicilNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Enter;
        private System.Windows.Forms.ToolStripMenuItem çalışanıGüncelleToolStripMenuItem;
    }
}