using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banka_Otomasyon_Sistemi
{
    public partial class frm_KrediEkstre : Form
    {
        public string HesapNumarasi { get => txt_HesapNo.Text; }

        public frm_KrediEkstre(string hesapNo, int cmb_SelectedIndex) //index 0 = Banka, 1 = Kredi
        {
            if(cmb_SelectedIndex != 1)
            {
                MessageBox.Show("Bir Kredi hesabı seçmeniz gerek.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            InitializeComponent();
            txt_HesapNo.Text = hesapNo;
        }

        private void frm_KrediEkstre_Load(object sender, EventArgs e)
        {
            this.Height = MdiParent.Size.Height - 250;
            this.Width = MdiParent.Size.Width - 450;
            reportViewer1.Height = this.Size.Height - 100;
            reportViewer1.Width = this.Size.Width;

            using (BankDbEntities vt = new BankDbEntities())
            {
                Kkart_Hesaplari krediHesabi = vt.Kkart_Hesaplari.FirstOrDefault(p => p.KkartHesapNo == txt_HesapNo.Text);
                DateTime HesapKesimTarihi = new DateTime(DateTime.Now.Year, DateTime.Now.Month, krediHesabi.HesapKesimGunu);
                DateTime SonOdemeTarihi = new DateTime(DateTime.Now.Year, DateTime.Now.Month, krediHesabi.SonOdemeGunu);

                var musteri = vt.Musteriler.FirstOrDefault(p => p.m_TcNo == krediHesabi.HesapSahipTcno);
                ReportParameter[] parametreler = new ReportParameter[]
                {
                    new ReportParameter("musteriAd_Soyad",musteri.m_Ad +" "+ musteri.m_Soyad),
                    new ReportParameter("HesapNo",txt_HesapNo.Text),
                    new ReportParameter("ekstreTarihi",HesapKesimTarihi.ToShortDateString()),
                    new ReportParameter("SonOdemeTarihi",SonOdemeTarihi.ToShortDateString())
                };
                DateTime BaslangicTarihi = (DateTime)System.Data.SqlTypes.SqlDateTime.MinValue;

                List<sp_KkartHesap_Harcama_Result> harcamalar = HesapIslemleri.HesapHarcamalariniAl_Kredi(vt, BaslangicTarihi, HesapKesimTarihi, txt_HesapNo.Text);

                List<Kkart_Hesaplari> dataSource = new List<Kkart_Hesaplari>();
                dataSource.Add(krediHesabi);

                if(harcamalar.Count == 0)
                {
                    sp_KkartHesap_Harcama_Result sp = new sp_KkartHesap_Harcama_Result();
                    sp.HesapNo = txt_HesapNo.Text;
                    sp.islemAciklama = string.Empty;
                    sp.islemKategori_id = 7;
                    sp.islemTarihi = DateTime.Now;
                    sp.islemTutari = 0;
                    harcamalar.Add(sp);
                    parametreler[3] = new ReportParameter("SonOdemeTarihi", " ");
                    MessageBox.Show("Borcunuz bulunmamaktadır.");
                }

                reportViewer1.LocalReport.DataSources.Clear(); //clear report
                reportViewer1.LocalReport.ReportEmbeddedResource = "Banka_Otomasyon_Sistemi.KrediEkstreRaporu.rdlc"; // bind reportviewer with .rdlc            
                ReportDataSource dataset = new ReportDataSource("DataSet_Ekstre", dataSource);
                //-------
                reportViewer1.LocalReport.ReportEmbeddedResource = "Banka_Otomasyon_Sistemi.KrediEkstreRaporu.rdlc";
                ReportDataSource ds_EkstreHarcamasi = new ReportDataSource("DataSet_EkstreHarcamasi", harcamalar);
                reportViewer1.LocalReport.DataSources.Add(ds_EkstreHarcamasi);
                reportViewer1.LocalReport.SetParameters(parametreler);

                reportViewer1.LocalReport.DataSources.Add(dataset);
                reportViewer1.LocalReport.Refresh();
                reportViewer1.RefreshReport();
            }
        }

    }
}
