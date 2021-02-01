namespace Banka_Otomasyon_Sistemi
{
    partial class frm_KategorilereGoreRapor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_KategorilereGoreRapor));
            this.txt_HesapNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_Bitis = new System.Windows.Forms.DateTimePicker();
            this.dtp_Baslangic = new System.Windows.Forms.DateTimePicker();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_RaporAl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_HesapNo
            // 
            this.txt_HesapNo.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txt_HesapNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_HesapNo.Location = new System.Drawing.Point(264, 70);
            this.txt_HesapNo.MaxLength = 11;
            this.txt_HesapNo.Name = "txt_HesapNo";
            this.txt_HesapNo.ReadOnly = true;
            this.txt_HesapNo.Size = new System.Drawing.Size(168, 26);
            this.txt_HesapNo.TabIndex = 60;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(297, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 24);
            this.label1.TabIndex = 59;
            this.label1.Text = "Hesap No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(55, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 67;
            this.label4.Text = "Bitiş";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 66;
            this.label3.Text = "Başlangıç";
            // 
            // dtp_Bitis
            // 
            this.dtp_Bitis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Bitis.Location = new System.Drawing.Point(105, 72);
            this.dtp_Bitis.Name = "dtp_Bitis";
            this.dtp_Bitis.Size = new System.Drawing.Size(102, 20);
            this.dtp_Bitis.TabIndex = 65;
            // 
            // dtp_Baslangic
            // 
            this.dtp_Baslangic.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Baslangic.Location = new System.Drawing.Point(105, 8);
            this.dtp_Baslangic.Name = "dtp_Baslangic";
            this.dtp_Baslangic.Size = new System.Drawing.Size(102, 20);
            this.dtp_Baslangic.TabIndex = 64;
            this.dtp_Baslangic.Value = new System.DateTime(2021, 1, 20, 0, 0, 0, 0);
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
            // reportViewer1
            // 
            this.reportViewer1.AutoSize = true;
            this.reportViewer1.CausesValidation = false;
            this.reportViewer1.DocumentMapWidth = 1;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Banka_Otomasyon_Sistemi.MusteriHarcamaRaporu.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(6, 110);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.ShowBackButton = false;
            this.reportViewer1.ShowContextMenu = false;
            this.reportViewer1.ShowCredentialPrompts = false;
            this.reportViewer1.ShowDocumentMapButton = false;
            this.reportViewer1.ShowPageNavigationControls = false;
            this.reportViewer1.ShowParameterPrompts = false;
            this.reportViewer1.ShowStopButton = false;
            this.reportViewer1.Size = new System.Drawing.Size(592, 340);
            this.reportViewer1.TabIndex = 68;
            // 
            // btn_RaporAl
            // 
            this.btn_RaporAl.BackColor = System.Drawing.Color.LightGreen;
            this.btn_RaporAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_RaporAl.Location = new System.Drawing.Point(495, 63);
            this.btn_RaporAl.Name = "btn_RaporAl";
            this.btn_RaporAl.Size = new System.Drawing.Size(99, 41);
            this.btn_RaporAl.TabIndex = 69;
            this.btn_RaporAl.Text = "Rapor Al";
            this.btn_RaporAl.UseVisualStyleBackColor = false;
            this.btn_RaporAl.Click += new System.EventHandler(this.btn_RaporAl_Click);
            // 
            // frm_KategorilereGoreRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 461);
            this.Controls.Add(this.btn_RaporAl);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.txt_HesapNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtp_Bitis);
            this.Controls.Add(this.dtp_Baslangic);
            this.Name = "frm_KategorilereGoreRapor";
            this.Text = "Grafik Olarak Harcamalar";
            this.Load += new System.EventHandler(this.frm_KategorilereGoreRapor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_HesapNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_Bitis;
        private System.Windows.Forms.DateTimePicker dtp_Baslangic;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btn_RaporAl;
    }
}