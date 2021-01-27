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
    public partial class frm_HesapRaporuAl : Form
    {
        public frm_HesapRaporuAl(string HesapNo)
        {
            InitializeComponent();
            txt_HesapNo.Text = HesapNo;
        }

        private void frm_HesapRaporuAl_Load(object sender, EventArgs e)
        {
            dtg_HesapGoruntule.AutoGenerateColumns = false;
            HesapHareketleriniAl();
        }

        private class DataHolder
        {
            public string islemTutari { get; set; }
            public string islemAciklama { get; set; }
            public string KategoriAd { get; set; }
            public DateTime islemTarihi { get; set; }
        }

        private List<DataHolder> ListeyiDoldur (BankDbEntities vt, bool islemler_BankaHesabi, string hesapNo)
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
                    dh.islemTarihi = item.islemTarihi;
                    if (Convert.ToDecimal(dh.islemTutari) > 0)
                        dh.islemTutari = "+" + dh.islemTutari;
                    if (dh.islemTarihi < dtp_Bitis.Value && dh.islemTarihi > dtp_Baslangic.Value)
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
                    dh.islemTarihi = item.islemTarihi;
                    if (Convert.ToDecimal(dh.islemTutari) > 0)
                        dh.islemTutari = "+" + dh.islemTutari;
                    if (dh.islemTarihi < dtp_Bitis.Value && dh.islemTarihi > dtp_Baslangic.Value)
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


    }
}
