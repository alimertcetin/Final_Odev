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
    public partial class frm_OdemeYap : Form
    {
        public frm_OdemeYap(Musteriler musteri)
        {
            InitializeComponent();

            lbl_MusteriNo.Text = musteri.MusteriNo;
        }

        private void frm_OdemeYap_Load(object sender, EventArgs e)
        {
            BankDbEntities vt = new BankDbEntities();

            dtg_HesapGoruntule.AutoGenerateColumns = false;

            cmb_KategoriListesi.ValueMember = "KategoriID";
            cmb_KategoriListesi.DisplayMember = "KategoriAd";
            cmb_KategoriListesi.DataSource = vt.Kategoriler.ToList();

            cmb_KategoriListesi.SelectedIndex = 0;
            cmb_HesapTuru.SelectedIndex = 0;

            HesaplariGoruntule(vt);
        }

        /// <summary>
        /// Görüntüleme işlemi başarılıysa true döndürür.
        /// </summary>
        private bool HesaplariGoruntule(BankDbEntities vt)
        {
            var musteri = vt.Musteriler.FirstOrDefault(p => p.MusteriNo == lbl_MusteriNo.Text);
            if (musteri != null)
            {
                switch (cmb_HesapTuru.SelectedIndex)
                {
                    case (0):
                        HesapIslemleri.Hesap_BankaHesaplariniBul(vt, musteri, out List<Banka_Hesaplari> bankAccounts);

                        cmb_HesapListesi.DataSource = null;
                        cmb_HesapListesi.ValueMember = "BankaHesapNo";
                        cmb_HesapListesi.DisplayMember = "BankaHesapNo";
                        cmb_HesapListesi.DataSource = bankAccounts;

                        dtg_HesapGoruntule.DataSource = null;
                        dtg_HesapGoruntule.Columns.Clear();

                        DataGridViewColumn clm_BankHesapNo = FormYonetimi.ColumnOlustur("BankaHesapNo", "Hesap Numarası");
                        DataGridViewColumn clm_Iban = FormYonetimi.ColumnOlustur("BankIban", "Iban");
                        DataGridViewColumn clm_Bakiye = FormYonetimi.ColumnOlustur("Hesap_Bakiye", "Bakiye");

                        dtg_HesapGoruntule.Columns.Add(clm_BankHesapNo);
                        dtg_HesapGoruntule.Columns.Add(clm_Iban);
                        dtg_HesapGoruntule.Columns.Add(clm_Bakiye);

                        dtg_HesapGoruntule.DataSource = bankAccounts;
                        break;

                    case (1):
                        HesapIslemleri.Hesap_KrediHesaplariniBul(vt, musteri, out List<Kkart_Hesaplari> CreditAccounts);

                        cmb_HesapListesi.DataSource = null;
                        cmb_HesapListesi.ValueMember = "KkartHesapNo";
                        cmb_HesapListesi.DisplayMember = "KkartHesapNo";
                        cmb_HesapListesi.DataSource = CreditAccounts;

                        dtg_HesapGoruntule.DataSource = null;
                        dtg_HesapGoruntule.Columns.Clear();

                        DataGridViewColumn clm_KkartHesapNo = FormYonetimi.ColumnOlustur("KkartHesapNo", "Hesap Numarası");
                        DataGridViewColumn clm_KkartIban = FormYonetimi.ColumnOlustur("KkartIban", "Iban");
                        DataGridViewColumn clm_KkartLimit = FormYonetimi.ColumnOlustur("Kkart_Limit", "Hesap Limiti");
                        DataGridViewColumn clm_KkartBorc = FormYonetimi.ColumnOlustur("Kkart_Borc", "Borç");
                        DataGridViewColumn clm_KkartKesimGunu = FormYonetimi.ColumnOlustur("HesapKesimGunu", "Hesap Kesim Günü");
                        DataGridViewColumn clm_KkartSonOdemeGunu = FormYonetimi.ColumnOlustur("SonOdemeGunu", "Son Ödeme Günü");

                        dtg_HesapGoruntule.Columns.Add(clm_KkartHesapNo);
                        dtg_HesapGoruntule.Columns.Add(clm_KkartIban);
                        dtg_HesapGoruntule.Columns.Add(clm_KkartLimit);
                        dtg_HesapGoruntule.Columns.Add(clm_KkartBorc);
                        dtg_HesapGoruntule.Columns.Add(clm_KkartKesimGunu);
                        dtg_HesapGoruntule.Columns.Add(clm_KkartSonOdemeGunu);

                        dtg_HesapGoruntule.DataSource = CreditAccounts;
                        break;

                    default:
                        break;
                }

                return true;
            }
            else return false;
        }

        private void btn_Geri_Click(object sender, EventArgs e) => Close();

        private void btn_OdemeYap_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txt_OdemeTutari.Text, out decimal tutar))
            {
                MessageBox.Show("Geçerli bir ödeme tutarı girin.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (cmb_HesapListesi.SelectedItem == null)
            {
                MessageBox.Show("Geçerli bir hesap seçin.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult sonuc = MessageBox.Show($"Ödeme Tutarı : {tutar}" + Environment.NewLine
                + $"Açıklama : {txt_Aciklama.Text}" + Environment.NewLine
                + $"Hesap Numarası : {cmb_HesapListesi.SelectedValue.ToString()}" + Environment.NewLine
                + $"Kategori : {cmb_KategoriListesi.Text}",
                "İŞLEMİ ONAYLIYOR MUSUNUZ?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sonuc == DialogResult.Yes)
            {
                BankDbEntities vt = new BankDbEntities();
                string hesapNo = cmb_HesapListesi.SelectedValue.ToString();
                int KategoriId = Convert.ToInt32(cmb_KategoriListesi.SelectedValue);
                if (HesapIslemleri.hesaptanParaCek(vt, Convert.ToInt32(txt_OdemeTutari.Text), hesapNo, txt_Aciklama.Text, KategoriId, out string Mesaj))
                {
                    MessageBox.Show(Mesaj, "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_OdemeTutari.Text = string.Empty;
                    txt_Aciklama.Text = string.Empty;
                }
                else MessageBox.Show(Mesaj, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                HesaplariGoruntule(vt);
            }
        }

        private void cmb_HesapTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            BankDbEntities vt = new BankDbEntities();
            HesaplariGoruntule(vt);
        }
    }
}
