using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banka_Otomasyon_Sistemi
{
    public partial class frm_HesapRaporuAl : Form, IWin32Window
    {
        public string HesapNumarasi { get => txt_HesapNo.Text; }
        public frm_HesapRaporuAl(string HesapNo)
        {
            InitializeComponent();
            txt_HesapNo.Text = HesapNo;
        }

        private void frm_HesapRaporuAl_Load(object sender, EventArgs e)
        {
            dtg_HesapGoruntule.AutoGenerateColumns = false;

            FormYonetimi.FormlariBul("frm_HesapRaporuAl", out List<Form> form);
            if (form.Count != 1)
            {
                for (int i = 0; i < form.Count - 1; i++)
                {
                    form[i].Close();
                    form.Remove(form[i]);
                }
            }

            HesapHareketleriniAl();
        }

        private class DataHolder
        {
            public string islemTutari { get; set; }
            public string islemAciklama { get; set; }
            public string KategoriAd { get; set; }
            public string islemTarihi { get; set; }
        }

        private List<DataHolder> ListeyiDoldur(BankDbEntities vt, bool islemler_BankaHesabi, string hesapNo)
        {
            if (islemler_BankaHesabi)
            {
                var sorgu =
                    from i in vt.islemler_BankaHesaplari
                    join k in vt.Kategoriler on i.islemKategori_id equals k.KategoriID
                    where i.HesapNo == hesapNo
                    orderby i.islemTarihi ascending
                    select new
                    {
                        islemTutari = i.islemTutari,
                        islemAciklama = i.islemAciklama,
                        KategoriAd = k.KategoriAd,
                        islemTarihi = i.islemTarihi
                    };

                var sorguListesi = new List<DataHolder>();
                foreach (var item in sorgu.ToList())
                {
                    DataHolder dh = new DataHolder();
                    dh.islemTutari = item.islemTutari.ToString();
                    dh.islemAciklama = item.islemAciklama;
                    dh.KategoriAd = item.KategoriAd;
                    dh.islemTarihi = item.islemTarihi.ToShortDateString();
                    if (Convert.ToDecimal(dh.islemTutari) > 0)
                        dh.islemTutari = "+" + dh.islemTutari;
                    if (item.islemTarihi < dtp_Bitis.Value && item.islemTarihi > dtp_Baslangic.Value)
                        sorguListesi.Add(dh);
                }
                return sorguListesi;
            }
            else
            {
                var sorgu =
                    from i in vt.islemler_KrediHesaplari
                    join k in vt.Kategoriler on i.islemKategori_id equals k.KategoriID
                    where i.HesapNo == hesapNo
                    orderby i.islemTarihi ascending
                    select new
                    {
                        islemTutari = i.islemTutari,
                        islemAciklama = i.islemAciklama,
                        KategoriAd = k.KategoriAd,
                        islemTarihi = i.islemTarihi
                    };

                var sorguListesi = new List<DataHolder>();
                foreach (var item in sorgu.ToList())
                {
                    DataHolder dh = new DataHolder();
                    dh.islemTutari = item.islemTutari.ToString();
                    dh.islemAciklama = item.islemAciklama;
                    dh.KategoriAd = item.KategoriAd;
                    dh.islemTarihi = item.islemTarihi.ToShortDateString();
                    if (Convert.ToDecimal(dh.islemTutari) > 0)
                        dh.islemTutari = "+" + dh.islemTutari;
                    if (item.islemTarihi < dtp_Bitis.Value && item.islemTarihi > dtp_Baslangic.Value)
                        sorguListesi.Add(dh);
                }
                return sorguListesi;
            }
        }

        private void HesapHareketleriniAl()
        {
            BankDbEntities vt = new BankDbEntities();
            var BBh = HesapIslemleri.Hesap_HesapGetirBank(vt, txt_HesapNo.Text);
            if (BBh != null)
            {
                dtg_HesapGoruntule.Columns.Clear();
                dtg_HesapGoruntule.DataSource = null;

                DataGridViewColumn islemTutari = FormYonetimi.ColumnOlustur("islemTutari", "İşlem Tutarı");
                DataGridViewColumn Aciklama = FormYonetimi.ColumnOlustur("islemAciklama", "Açıklama");
                DataGridViewColumn Kategori = FormYonetimi.ColumnOlustur("KategoriAd", "Kategori");
                DataGridViewColumn islemTarihi = FormYonetimi.ColumnOlustur("islemTarihi", "Tarih");

                dtg_HesapGoruntule.Columns.Add(islemTutari);
                dtg_HesapGoruntule.Columns.Add(Aciklama);
                dtg_HesapGoruntule.Columns.Add(Kategori);
                dtg_HesapGoruntule.Columns.Add(islemTarihi);

                var sorguListesi = ListeyiDoldur(vt, true, BBh.BankaHesapNo);
                dtg_HesapGoruntule.DataSource = sorguListesi;
            }
            else
            {
                var KKh = HesapIslemleri.Hesap_HesapGetirKkart(vt, txt_HesapNo.Text);
                if (KKh != null)
                {
                    dtg_HesapGoruntule.Columns.Clear();
                    dtg_HesapGoruntule.DataSource = null;

                    DataGridViewColumn islemTutari = FormYonetimi.ColumnOlustur("islemTutari", "İşlem Tutarı");
                    DataGridViewColumn Aciklama = FormYonetimi.ColumnOlustur("islemAciklama", "Açıklama");
                    DataGridViewColumn Kategori = FormYonetimi.ColumnOlustur("KategoriAd", "Kategori");
                    DataGridViewColumn islemTarihi = FormYonetimi.ColumnOlustur("islemTarihi", "Tarih");

                    dtg_HesapGoruntule.Columns.Add(islemTutari);
                    dtg_HesapGoruntule.Columns.Add(Aciklama);
                    dtg_HesapGoruntule.Columns.Add(Kategori);
                    dtg_HesapGoruntule.Columns.Add(islemTarihi);

                    var sorguListesi = ListeyiDoldur(vt, false, KKh.KkartHesapNo);
                    dtg_HesapGoruntule.DataSource = sorguListesi;

                }
                else MessageBox.Show("Bir hata oluştu. Formu kapatıp tekrar deneyin.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtp_Baslangic_ValueChanged(object sender, EventArgs e) => HesapHareketleriniAl();
        private void dtp_Bitis_ValueChanged(object sender, EventArgs e) => HesapHareketleriniAl();

        private void btn_RaporAl_Click(object sender, EventArgs e)
        {
            try
            {
                printPreviewDialog1.ShowDialog(this);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu." + ex);
                this.Close();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Gösterilecekler : 
            //Müşterinin adı,Soyadı
            //Hesap Numarası
            //IBAN
            string MUSTERIADSOYAD = string.Empty;
            string IBAN = string.Empty;
            BankDbEntities vt = new BankDbEntities();
            var BankHesabi = HesapIslemleri.Hesap_HesapGetirBank(vt, txt_HesapNo.Text);
            if (BankHesabi != null)
            {
                KisiIslemleri.MusteriVeritabanindaVarMi(vt, out Musteriler musteri, BankHesabi.HesapSahipTcno);
                MUSTERIADSOYAD = musteri.m_Ad +" "+ musteri.m_Soyad.ToUpper();
                IBAN = BankHesabi.BankIban;
            }
            else
            {
                var KkartHesabi = HesapIslemleri.Hesap_HesapGetirKkart(vt, txt_HesapNo.Text);
                if(KkartHesabi != null)
                {
                    KisiIslemleri.MusteriVeritabanindaVarMi(vt, out Musteriler musteri, KkartHesabi.HesapSahipTcno);
                    MUSTERIADSOYAD = musteri.m_Ad + " " + musteri.m_Soyad.ToUpper();
                    IBAN = KkartHesabi.KkartIban;
                }
            }

            //sıralama : tarih, açıklama, tutar, kategori
            var liste = dtg_HesapGoruntule.DataSource as List<DataHolder>;
            foreach (var item in liste)
            {
                int BaslangicIndex = 0;
                const int maxCharPerLine = 19;
                if (item.islemAciklama.Length >= 90) //Açıklama veritabanı üzerinde maksimum 100 karakter olacak şekilde sınırlandırıldı.
                {
                    BaslangicIndex = 0;
                    var Satir1 = item.islemAciklama.Substring(BaslangicIndex, maxCharPerLine); //19
                    BaslangicIndex += maxCharPerLine;
                    var Satir2 = Environment.NewLine + item.islemAciklama.Substring(BaslangicIndex, maxCharPerLine); //38
                    BaslangicIndex += maxCharPerLine;
                    var Satir3 = Environment.NewLine + item.islemAciklama.Substring(BaslangicIndex, maxCharPerLine); //57
                    BaslangicIndex += maxCharPerLine;
                    var Satir4 = Environment.NewLine + item.islemAciklama.Substring(BaslangicIndex, maxCharPerLine); //76
                    BaslangicIndex += maxCharPerLine;
                    var Satir5 = Environment.NewLine + item.islemAciklama.Substring(BaslangicIndex, maxCharPerLine); //85
                    BaslangicIndex += maxCharPerLine;
                    var Satir6 = Environment.NewLine + item.islemAciklama.Substring(BaslangicIndex, item.islemAciklama.Length - BaslangicIndex); //104
                    item.islemAciklama = 
                        Satir1 + 
                        Satir2 + 
                        Satir3 + 
                        Satir4 + 
                        Satir5 + 
                        Satir6;
                }
                else if (item.islemAciklama.Length >= 70)
                {
                    BaslangicIndex = 0;
                    var Satir1 = item.islemAciklama.Substring(BaslangicIndex, maxCharPerLine); //19
                    BaslangicIndex += maxCharPerLine;
                    var Satir2 = Environment.NewLine + item.islemAciklama.Substring(BaslangicIndex, maxCharPerLine); //38
                    BaslangicIndex += maxCharPerLine;
                    var Satir3 = Environment.NewLine + item.islemAciklama.Substring(BaslangicIndex, maxCharPerLine - 6); //57
                    BaslangicIndex += maxCharPerLine;
                    var Satir4 = Environment.NewLine + item.islemAciklama.Substring(BaslangicIndex, item.islemAciklama.Length - BaslangicIndex);
                    item.islemAciklama =
                        Satir1 +
                        Satir2 +
                        Satir3 +
                        Satir4;
                }
                else if(item.islemAciklama.Length >= 60)
                {
                    BaslangicIndex = 0;
                    var Satir1 = item.islemAciklama.Substring(BaslangicIndex, maxCharPerLine); //19
                    BaslangicIndex += maxCharPerLine;
                    var Satir2 = Environment.NewLine + item.islemAciklama.Substring(BaslangicIndex, maxCharPerLine); //38
                    BaslangicIndex += maxCharPerLine;
                    var Satir3 = Environment.NewLine + item.islemAciklama.Substring(BaslangicIndex, maxCharPerLine); //57
                    BaslangicIndex += maxCharPerLine;
                    var Satir4 = Environment.NewLine + item.islemAciklama.Substring(BaslangicIndex, item.islemAciklama.Length - BaslangicIndex);
                    item.islemAciklama =
                        Satir1 +
                        Satir2 +
                        Satir3 +
                        Satir4;
                }
                else if(item.islemAciklama.Length >= 40)
                {
                    BaslangicIndex = 0;
                    var Satir1 = item.islemAciklama.Substring(BaslangicIndex, maxCharPerLine + 1);
                    BaslangicIndex += maxCharPerLine + 1;
                    var Satir2 = Environment.NewLine + item.islemAciklama.Substring(BaslangicIndex, maxCharPerLine + 1);
                    BaslangicIndex += maxCharPerLine + 1;
                    var Satir3 = Environment.NewLine + item.islemAciklama.Substring(BaslangicIndex, item.islemAciklama.Length - BaslangicIndex);
                    item.islemAciklama =
                        Satir1 +
                        Satir2 +
                        Satir3;
                }
                else if (item.islemAciklama.Length >= 19)
                {
                    BaslangicIndex = 0;
                    var Satir1 = item.islemAciklama.Substring(0, maxCharPerLine);
                    BaslangicIndex += maxCharPerLine;
                    var Satir2 = Environment.NewLine + item.islemAciklama.Substring(BaslangicIndex, item.islemAciklama.Length - BaslangicIndex);
                    item.islemAciklama =
                        Satir1 +
                        Satir2;
                }
            }

            Graphics cizim = e.Graphics;
            Font BaslikTipi = new Font("Arial", 11, FontStyle.Bold);
            Font yaziTipi = new Font("Arial", 8, FontStyle.Regular);
            Font infoTipi = new Font("Arial", 11, FontStyle.Italic);
            SolidBrush firca = new SolidBrush(Color.Black);

            const int BaslikYukseklik = 100; //Tarih, işlem tutarı gibi alanların yüksekliği
            const int BaslikBoslukMiktari = 30; //Tarih, işlem tutarı gibi alanların Boşluk değeri
            int satirYukseklik = BaslikYukseklik + 70; //Logların yüksekliği

            cizim.DrawString("Sayın " + MUSTERIADSOYAD + Environment.NewLine + " hesabınıza ait " 
                + dtp_Baslangic.Value.ToShortDateString() + " - " + dtp_Bitis.Value.ToShortDateString()
                + " tarihleri arasında yapılan harcamalar" + Environment.NewLine 
                +"aşağıdaki gibidir." + Environment.NewLine
                + "Hesap Numarası : " + txt_HesapNo.Text + Environment.NewLine //Hesap No 16 karakter
                + "IBAN : " + IBAN, infoTipi, firca, new PointF(30, BaslikYukseklik - 90)); //IBAN 26 karakter

            cizim.DrawString("Tarih", BaslikTipi, firca, new PointF(20, BaslikYukseklik));
            cizim.DrawString("Açıklama", BaslikTipi, firca, new PointF(85 + BaslikBoslukMiktari, BaslikYukseklik));
            cizim.DrawString("İşlem Tutarı", BaslikTipi, firca, new PointF(185 + BaslikBoslukMiktari, BaslikYukseklik));
            cizim.DrawString("Kategori", BaslikTipi, firca, new PointF(300 + BaslikBoslukMiktari, BaslikYukseklik));

            Pen kalem = new Pen(Color.Black, 3);
            Point baslangic = new Point(30, BaslikYukseklik + 40);
            Point bitis = new Point(370, BaslikYukseklik + 40);
            cizim.DrawLine(kalem, baslangic, bitis);


            foreach (var item in liste)
            {
                cizim.DrawString(item.islemTarihi.ToString(), yaziTipi, firca, new PointF(10, satirYukseklik));
                cizim.DrawString(item.islemAciklama, yaziTipi, firca, new PointF(90 + BaslikBoslukMiktari / 2, satirYukseklik));
                cizim.DrawString(item.islemTutari, yaziTipi, firca, new PointF(210 + BaslikBoslukMiktari / 2, satirYukseklik));
                cizim.DrawString(item.KategoriAd, yaziTipi, firca, new PointF(325 + BaslikBoslukMiktari / 2, satirYukseklik));
                satirYukseklik += 85;
            }

            printDocument1.PrinterSettings.PrinterName = "Microsoft Print to PDF";
            printDocument1.PrinterSettings.PrintToFile = true;
            printDocument1.PrinterSettings.PrintFileName = Path.Combine(Application.LocalUserAppDataPath, "1715010059 - BankaOtomasyonSistemi_Rapor" + ".pdf");
            MessageBox.Show("Dosya " + Application.LocalUserAppDataPath + " lokasyonuna pdf olarak kayıt edilecektir.");
        }
    }
}
