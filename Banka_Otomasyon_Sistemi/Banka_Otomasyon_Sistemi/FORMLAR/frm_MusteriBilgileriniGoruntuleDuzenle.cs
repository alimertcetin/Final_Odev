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
    public partial class frm_MusteriBilgileriniGoruntuleDuzenle : Form
    {

        public frm_MusteriBilgileriniGoruntuleDuzenle()
        {
            InitializeComponent();
        }

        private void txt_MusteriNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(13))
            {
                BankDbEntities vt = new BankDbEntities();
                if (!KisiIslemleri.MusteriVeritabanindaVarMi(vt, txt_MusteriNo.Text, out Musteriler musteri))
                    MessageBox.Show("Bu numarayla kayıtlı bir müşteri bulunamadı.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    txt_Ad.Text = musteri.m_Ad;
                    txt_Soyad.Text = musteri.m_Soyad;
                    dtp_DogumTarihi.Value = musteri.m_DogumTarihi;
                    txt_DogumYeri.Text = musteri.m_DogumYeri;
                    SetReadOnly(false);
                }
            }
        }

        private void txt_MusteriNo_TextChanged(object sender, EventArgs e)
        {
            if (!txt_Ad.ReadOnly)
            {
                AlanlarıTemizle();
                SetReadOnly(true);
            }

            lbl_Enter.Visible = string.IsNullOrEmpty(txt_MusteriNo.Text) ? false : true;
        }

        private void SetReadOnly(bool readOnly)
        {
            txt_Ad.ReadOnly = readOnly;
            txt_Soyad.ReadOnly = readOnly;
        }

        private void AlanlarıTemizle()
        {
            txt_Ad.Text = string.Empty;
            txt_Soyad.Text = string.Empty;
            dtp_DogumTarihi.Value = DateTime.Now;
            txt_DogumYeri.Text = string.Empty;
        }

        private void btn_Onayla_Click(object sender, EventArgs e)
        {
            BankDbEntities vt = new BankDbEntities();
            var musteri = vt.Musteriler.FirstOrDefault(p => p.MusteriNo == txt_MusteriNo.Text);
            if (musteri == null)
                MessageBox.Show("Doğru bir müşteri numarası girdiğinizden emin olun ve " +
                    "Enter tuşuna basın.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                var result = MessageBox.Show("Bu değişiklikleri kayıt etmek istediğinizden emin misiniz?", "UYARI",
                       MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    musteri.m_Ad = txt_Ad.Text;
                    musteri.m_Soyad = txt_Soyad.Text;
                    if (vt.SaveChanges() > 0)
                        MessageBox.Show("Değişiklikler başarıyla kayıt edildi.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Değişiklikler uygulanırken bir hata oluştu.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_iptalEt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            BankDbEntities vt = new BankDbEntities();
            var musteri = vt.Musteriler.FirstOrDefault(p => p.MusteriNo == txt_MusteriNo.Text);
            if (musteri == null || string.IsNullOrEmpty(txt_Ad.Text))
                MessageBox.Show("Doğru bir müşteri numarası girdiğinizden emin olun ve " +
                    "Enter tuşuna basın.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                var result = MessageBox.Show("Bu müşteriyi ve açık olan tüm hesaplarını silmek istediğinizden emin misiniz?",
                    "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    HesapIslemleri.Hesap_BankaHesaplariniBul(vt, musteri, out List<Banka_Hesaplari> TumBankaHesaplari);
                    HesapIslemleri.Hesap_KrediHesaplariniBul(vt, musteri, out List<Kkart_Hesaplari> TumKrediHesaplari);
                    decimal BankaHesaplarindakiToplamPara = 0;
                    List<Kkart_Hesaplari> borcluKkartHesaplari = new List<Kkart_Hesaplari>();
                    foreach (var item in TumBankaHesaplari)
                    {
                        BankaHesaplarindakiToplamPara += item.Hesap_Bakiye;
                        LogIslemleri.BankHesap_TumLoglariSil(vt, item);
                        vt.Banka_Hesaplari.Remove(item);
                        if (vt.SaveChanges() == 0)
                            MessageBox.Show("Bir hata oluştu.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    foreach (var item in TumKrediHesaplari)
                    {
                        if (item.Kkart_Borc > 0)
                        {
                            borcluKkartHesaplari.Add(item);
                        }
                        else
                        {
                            LogIslemleri.KkartHesap_TumLoglariSil(vt, item);
                            vt.Kkart_Hesaplari.Remove(item);
                            if (vt.SaveChanges() == 0)
                                MessageBox.Show("Bir hata oluştu.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    for (int i = borcluKkartHesaplari.Count; i > 0; i--)
                    {
                        var item = borcluKkartHesaplari[i - 1];
                        if (item.Kkart_Borc - BankaHesaplarindakiToplamPara < 0)
                        {
                            BankaHesaplarindakiToplamPara -= Convert.ToDecimal(item.Kkart_Borc);
                            item.Kkart_Borc = 0;
                            borcluKkartHesaplari.Remove(item);
                            LogIslemleri.KkartHesap_TumLoglariSil(vt, item);
                            vt.Kkart_Hesaplari.Remove(item);
                            var sonuc = vt.SaveChanges();
                            if (sonuc == 0)
                                MessageBox.Show("Bir hata oluştu.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            item.Kkart_Borc -= BankaHesaplarindakiToplamPara;
                            BankaHesaplarindakiToplamPara = 0;
                        }
                        if (BankaHesaplarindakiToplamPara <= 0) break;
                    }
                    if (borcluKkartHesaplari.Count > 0)
                    {
                        MessageBox.Show("Borçlu olduğu kredi hesapları mevcut olduğu için müşteri sistemden silinemiyor.",
                            "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        MessageBox.Show("İşlem sonucunda müşterinin açık banka hesaplarından" +
                            " kredi borçlarının bir kısmı otomatik olarak ödenmiş olabilir.",
                            "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (BankaHesaplarindakiToplamPara > 0)
                        {
                            vt.Musteriler.Remove(musteri);
                            if (vt.SaveChanges() > 0)
                                MessageBox.Show("Müşterinin tüm hesapları kapatıldı ve müşteri sistemden silindi. " +
                                    "Hesaplarda kalan toplam para " + BankaHesaplarindakiToplamPara + "TL müşteriye iade edilecek.",
                                    "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            else
                                MessageBox.Show("Bir hata oluştu.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            vt.Musteriler.Remove(musteri);
                            if (vt.SaveChanges() > 0)
                                MessageBox.Show("Müşterinin tüm hesapları kapatıldı ve müşteri sistemden silindi.",
                                    "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            else
                                MessageBox.Show("Bir hata oluştu.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }
            }
        }
    }
}
