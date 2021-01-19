using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Banka_Otomasyon_Sistemi
{
    public partial class frm_YeniHesapOlustur : Form
    {
        public frm_YeniHesapOlustur()
        {
            InitializeComponent();
            //-----------------------Debug---------------------\\
            txt_TcNo.Text = "57559386086";
            txt_Ad.Text = "Ali";
            txt_Soyad.Text = "Çetin";
            txt_DogumYeri.Text = "Sakarya";
            txt_Sifre.Text = "123456";
            txt_SifreTekrar.Text = "123456";
            dateTimePicker1.Value = new DateTime(1998, 11, 20);
        }

        private void btn_olustur_Click(object sender, EventArgs e)
        {
            BankDbEntities vt = new BankDbEntities();

            string tcNo, ad, soyad, dogumYeri, sifre, sifreTekrar;
            DateTime dogumTarihi;
            int dogumYili;
            FormdanVerileriAl(out tcNo, out ad, out soyad, out dogumYeri, out sifre, out sifreTekrar, out dogumTarihi, out dogumYili);

            if (string.IsNullOrEmpty(tcNo) || string.IsNullOrEmpty(ad) ||
                string.IsNullOrEmpty(soyad) || string.IsNullOrEmpty(sifre) ||
                string.IsNullOrEmpty(sifreTekrar) || string.IsNullOrEmpty(dogumYeri))
                MessageBox.Show("Alanlar boş bırakılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            else if (sifre != sifreTekrar)
                MessageBox.Show("Girdiğiniz şifreler aynı değil.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            else if (!rb_Kredi.Checked && !rb_Banka.Checked)
                MessageBox.Show("Oluşturmak istediğiniz hesabı seçmelisiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            else if (!long.TryParse(tcNo, out long ltcNo) || tcNo.Length != 11)
                MessageBox.Show("Tc No geçerli değil.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            else if (HesapIslemleri.KisiVeritabanındaVarMi(vt, tcNo))
                MessageBox.Show("Daha önce böyle bir müşteri kayıt edilmiş! " +
                    "Lütfen daha önce hesap oluşturdum seçeneğini seçin " +
                    "ve hesap oluşturma işleminize oradan devam edin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                try
                {
                    KimlikSorgulama.KPSPublicSoapClient sorgu = new KimlikSorgulama.KPSPublicSoapClient();
                    if (!sorgu.TCKimlikNoDogrula(Convert.ToInt64(tcNo), ad, soyad, dogumYili))
                        MessageBox.Show("Kimlik Bilgileri geçersiz. Lütfen bilgileri tekrar kontrol edin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        Musteriler musteri = HesapIslemleri.MusteriOlustur(tcNo, ad, soyad, dogumYeri, sifre, dogumTarihi);

                        if (rb_Banka.Checked)
                        {
                            Banka_Hesaplari bh = HesapIslemleri.BankaHesabiOlustur(tcNo, vt);
                            HesabıVeMusteriyiKaydet(vt, bh, musteri);
                        }
                        else
                        {
                            FormYonetimi.FormBul("frm_KkartConfig", out List<Form> KkartConfigs);
                            if (KkartConfigs.Count == 0)
                            {
                                frm_KkartConfig frm_Kkart = new frm_KkartConfig(vt, musteri, true);
                                frm_Kkart.MdiParent = this.MdiParent;
                                frm_Kkart.Show();
                            }
                            else
                            {
                                MessageBox.Show("Kredi heabı oluşturmak için; ayarları açılan \"Kredi Kartı Ayarları\" " +
                                "penceresinde yapmanız gerek.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                KkartConfigs.ElementAt(0).Activate();
                            }
                        }
                    }
                }
                catch (Exception hata)
                {
                    MessageBox.Show("Bir hata oluştu : " + hata);
                }
            }
        }

        private static void HesabıVeMusteriyiKaydet(BankDbEntities vt, Banka_Hesaplari bh, Musteriler musteri)
        {
            vt.Banka_Hesaplari.Add(bh); //Veritabanına ekle.
            vt.Musteriler.Add(musteri); //Veritabanına ekle.
            if (vt.SaveChanges() > 0)
            {
                MessageBox.Show("Kayıt Başarılı.", "", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Kayıt Başarısız! " +
                    "Veritabanına kayıt edilirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void FormdanVerileriAl(out string tcNo, out string ad, out string soyad, out string dogumYeri, out string sifre, out string sifreTekrar, out DateTime dogumTarihi, out int dogumYili)
        {
            tcNo = txt_TcNo.Text;
            ad = txt_Ad.Text;
            soyad = txt_Soyad.Text;
            dogumYeri = txt_DogumYeri.Text;
            sifre = txt_Sifre.Text;
            sifreTekrar = txt_SifreTekrar.Text;
            dogumTarihi = dateTimePicker1.Value;
            dogumYili = dogumTarihi.Year;
        }
    }
}
