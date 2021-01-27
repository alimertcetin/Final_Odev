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
            BankDbEntities vt = new BankDbEntities();
            var BBh = HesapIslemleri.Hesap_HesapGetirBank(vt, txt_HesapNo.Text);
            if (BBh != null)
            {
                var islemListesi =
                    from i in vt.islemler_BankaHesaplari
                    join k in vt.Kategoriler on i.islemKategori_id equals k.KategoriID
                    select new
                    {
                        islemTutari = i.islemTutari,
                        islemAciklama = i.islemAciklama,
                        KategoriAd = k.KategoriAd,
                        islemTarihi = i.islemTarihi
                    };

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

                dtg_HesapGoruntule.DataSource = islemListesi.ToList();

            }
            else
            {
                var KKh = HesapIslemleri.Hesap_HesapGetirKkart(vt, txt_HesapNo.Text);
                if (KKh != null)
                {
                    var islemListesi = vt.Kkart_Hesaplari.Where(p => p.KkartHesapNo == txt_HesapNo.Text).ToList();

                    dtg_HesapGoruntule.Columns.Clear();
                    dtg_HesapGoruntule.DataSource = null;

                    DataGridViewColumn islemTutari = FormYonetimi.ColumnOlustur("islemTutari", "İşlem Tutarı");
                    DataGridViewColumn Aciklama = FormYonetimi.ColumnOlustur("islemAciklama", "Açıklama");
                    DataGridViewColumn Kategori = FormYonetimi.ColumnOlustur("islemKategori_id", "Kategori");
                    DataGridViewColumn islemTarihi = FormYonetimi.ColumnOlustur("islemTarihi", "Tarih");

                    dtg_HesapGoruntule.Columns.Add(islemTutari);
                    dtg_HesapGoruntule.Columns.Add(Aciklama);
                    dtg_HesapGoruntule.Columns.Add(Kategori);
                    dtg_HesapGoruntule.Columns.Add(islemTarihi);

                    dtg_HesapGoruntule.DataSource = islemListesi;
                }
                else MessageBox.Show("Bir hata oluştu. Formu kapatıp tekrar deneyin.", "HATA",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
