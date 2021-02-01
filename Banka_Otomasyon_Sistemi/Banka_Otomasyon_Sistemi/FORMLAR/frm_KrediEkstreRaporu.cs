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
                List<islemler_KrediHesaplari> islemler = vt.islemler_KrediHesaplari.Where(p => p.HesapNo == txt_HesapNo.Text).ToList();
                DateTime HesapKesimTarihi = new DateTime(DateTime.Now.Year, DateTime.Now.Month, krediHesabi.HesapKesimGunu);
                DateTime SonOdemeTarihi = new DateTime(DateTime.Now.Year, DateTime.Now.Month, krediHesabi.SonOdemeGunu);
                foreach (var item in islemler) //Döneme ait borcu oluştur.
                {
                    if(item.islemTarihi > HesapKesimTarihi) //
                    {
                        krediHesabi.Kkart_Borc -= item.islemTutari;
                    }
                }
                if (krediHesabi.Kkart_Borc <= 0) //Eğer yapılan işlemler sonucunda borcu yoksa
                {
                    MessageBox.Show("Borcunuz bulunmamaktadır.");
                    return;
                }
                var musteri = vt.Musteriler.FirstOrDefault(p => p.m_TcNo == krediHesabi.HesapSahipTcno);
                ReportParameter[] parametreler = new ReportParameter[]
                {
                    new ReportParameter("musteriAd_Soyad",musteri.m_Ad +" "+ musteri.m_Soyad),
                    new ReportParameter("HesapNo",txt_HesapNo.Text),
                    new ReportParameter("ekstreTarihi",HesapKesimTarihi.ToShortDateString()),
                    new ReportParameter("SonOdemeTarihi",SonOdemeTarihi.ToShortDateString())
                };
                var source = new List<Kkart_Hesaplari>();
                source.Add(krediHesabi);

                reportViewer1.LocalReport.DataSources.Clear(); //clear report
                reportViewer1.LocalReport.ReportEmbeddedResource = "Banka_Otomasyon_Sistemi.KrediEkstreRaporu.rdlc"; // bind reportviewer with .rdlc            
                ReportDataSource dataset = new ReportDataSource("DataSet_Ekstre", source); // set the datasource

                GrafigiGuncelle(vt, new DateTime(HesapKesimTarihi.Year, HesapKesimTarihi.Month - 1, HesapKesimTarihi.Day),
                    HesapKesimTarihi);

                reportViewer1.LocalReport.SetParameters(parametreler);
                reportViewer1.LocalReport.DataSources.Add(dataset);
                reportViewer1.LocalReport.Refresh();
                reportViewer1.RefreshReport();
            }
        }


        private void GrafigiGuncelle(BankDbEntities vt, DateTime baslangic, DateTime Bitis)
        {
            //verilen tarihler arasındaki tüm işlemleri döndürüyor.
            var source2 = vt.sp_KkartHesap_Harcama(baslangic, Bitis, txt_HesapNo.Text).ToList(); 
            //Listede sadece harcamalar kalacak şekilde liste düzenleniyor.
            for (int i = 0; i < source2.Count; i++)
            {
                if (source2[i].islemTutari > 0)
                    source2.Remove(source2[i]);
            }
            reportViewer1.LocalReport.ReportEmbeddedResource = "Banka_Otomasyon_Sistemi.KrediEkstreRaporu.rdlc";
            ReportDataSource ds_EkstreHarcamasi = new ReportDataSource("DataSet_EkstreHarcamasi", source2);
            reportViewer1.LocalReport.DataSources.Add(ds_EkstreHarcamasi);
            //reportViewer1.LocalReport.Refresh();
            //reportViewer1.RefreshReport();
        }

    }
}
