using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Banka_Otomasyon_Sistemi
{
    public partial class frm_KategorilereGoreRapor : Form
    {
        public string HesapNumarasi { get => txt_HesapNo.Text; }
        bool BankHesabi;
        public frm_KategorilereGoreRapor(string HesapNo, int cmb_HesapTuruSeciliIndex) //index 0 = Banka, 1 = Kredi
        {
            InitializeComponent();
            txt_HesapNo.Text = HesapNo;
            BankHesabi = cmb_HesapTuruSeciliIndex == 0 ? true : false;
        }

        private void frm_KategorilereGoreRapor_Load(object sender, EventArgs e)
        {
            this.Height = MdiParent.Size.Height - 250;
            this.Width = MdiParent.Size.Width - 450;
            reportViewer1.Height = this.Size.Height - 100;
            reportViewer1.Width = this.Size.Width;
            RaporYenile(BankHesabi);
        }

        private void btn_RaporAl_Click(object sender, EventArgs e) => RaporYenile(BankHesabi);

        private void RaporYenile(bool bankhesabi)
        {
            if (bankhesabi)
            {
                using (BankDbEntities vt = new BankDbEntities())
                {
                    var liste = vt.sp_BankHesap_Harcama(dtp_Baslangic.Value, dtp_Bitis.Value, txt_HesapNo.Text).ToList();
                    List<sp_BankHesap_Harcama_Result> harcamalar = new List<sp_BankHesap_Harcama_Result>();

                    for (int i = 0; i < liste.Count; i++)
                    {
                        if (liste[i].islemTutari < 0)
                            harcamalar.Add(liste[i]);
                    }
                    for (int i = 0; i < harcamalar.Count; i++)
                    {
                        harcamalar[i].islemTutari *= -1;
                    }

                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.LocalReport.ReportEmbeddedResource = "Banka_Otomasyon_Sistemi.MusteriHarcamaRaporu.rdlc";
                    ReportDataSource dataset = new ReportDataSource("DataSet1", harcamalar);
                    reportViewer1.LocalReport.DataSources.Add(dataset);
                    reportViewer1.LocalReport.Refresh();
                    reportViewer1.RefreshReport();
                }
            }
            else
            {
                using (BankDbEntities vt = new BankDbEntities())
                {
                    List<sp_KkartHesap_Harcama_Result> liste = vt.sp_KkartHesap_Harcama(dtp_Baslangic.Value, dtp_Bitis.Value, txt_HesapNo.Text).ToList();
                    List<sp_KkartHesap_Harcama_Result> harcamalar = new List<sp_KkartHesap_Harcama_Result>();
                    for (int i = 0; i < liste.Count; i++)
                    {
                        if (liste[i].islemTutari < 0)
                            harcamalar.Add(liste[i]);
                    }
                    for (int i = 0; i < harcamalar.Count; i++)
                    {
                        harcamalar[i].islemTutari *= -1;
                    }

                    reportViewer1.LocalReport.DataSources.Clear(); //clear report
                    reportViewer1.LocalReport.ReportEmbeddedResource = "Banka_Otomasyon_Sistemi.MusteriHarcamaRaporu.rdlc"; // bind reportviewer with .rdlc            
                    ReportDataSource dataset = new ReportDataSource("DataSet1", harcamalar); // set the datasource
                    reportViewer1.LocalReport.DataSources.Add(dataset);
                    reportViewer1.LocalReport.Refresh();
                    reportViewer1.RefreshReport(); // refresh report
                }
            }
        }

    }
}
