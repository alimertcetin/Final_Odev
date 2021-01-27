using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Banka_Otomasyon_Sistemi
{
    public partial class frm_HesapSil : Form
    {
        public string MNo => txt_MusteriNo.Text;
        BankDbEntities vt = new BankDbEntities();
        Musteriler musteri;

        public frm_HesapSil()
        {
            InitializeComponent();
        }

        private void HesapGoruntuleyeHaberVer()
        {
            //foreach (Form itm in Application.OpenForms)
            //{
            //    if (item.Name == "frm_HesapGoruntule")
            //    {
            //        frm_HesapGoruntule hesapGoruntule = (frm_HesapGoruntule)item;
            //        hesapGoruntule.GridYenile();
            //    }
            //}
            if(FormYonetimi.FormBul("frm_HesapGoruntule",out List<Form> HesapGoruntuleFormlari))
            {
                frm_HesapGoruntule hesapGoruntule = (frm_HesapGoruntule)HesapGoruntuleFormlari.ElementAt(0);
                hesapGoruntule.GridYenile();
            }
        }

        private List<string> HesapListesi()
        {
            if (musteri != null)
            {
                HesapIslemleri.Hesap_HesaplariBul(vt, musteri, out List<string> OwnedAccountNumbers);
                return OwnedAccountNumbers;
            }
            else return new List<string>();
        }

        private void txt_MusteriNo_TextChanged(object sender, EventArgs e)
        {
            string m_No = txt_MusteriNo.Text;
            musteri = vt.Musteriler.FirstOrDefault(p => p.MusteriNo == m_No);
            if (musteri != null)
            {
                cmb_SilinecekHesap.DataSource = HesapListesi();

                txt_Ad.Text = musteri.m_Ad;
                txt_Soyad.Text = musteri.m_Soyad;
                dtp_DogumTarihi.Value = musteri.m_DogumTarihi;
            }
            else
            {
                txt_Ad.Text = string.Empty;
                txt_Soyad.Text = string.Empty;
                dtp_DogumTarihi.Value = DateTime.Now;
            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bu hesabı silmek istediğinize emin misiniz? " +
                "Hesap kalıcı olarak silinecektir.", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                HesabiSil();
        }

        private void HesabiSil()
        {
            if (musteri != null)
            {
                if (string.IsNullOrEmpty(txt_Sifre.Text))
                    MessageBox.Show("Şifrenizi girmeniz gerek.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (txt_Sifre.Text != txt_SifreTekrar.Text)
                    MessageBox.Show("Şifreler uyuşmuyor.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (txt_Sifre.Text != musteri.m_Sifre)
                    MessageBox.Show("Geçersiz şifre.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (string.IsNullOrEmpty(cmb_SilinecekHesap.SelectedItem.ToString()))
                    MessageBox.Show("Silinecek hesap bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    var hesapNo = cmb_SilinecekHesap.SelectedItem.ToString();
                    var silinecek_Bh = vt.Banka_Hesaplari.FirstOrDefault(p => p.BankaHesapNo == hesapNo);
                    var silinecek_Kkh = vt.Kkart_Hesaplari.FirstOrDefault(p => p.KkartHesapNo == hesapNo);
                    if (silinecek_Bh != null)
                    {
                        vt.Banka_Hesaplari.Remove(silinecek_Bh);
                        if (vt.SaveChanges() > 0)
                        {
                            cmb_SilinecekHesap.DataSource = HesapListesi();
                            HesapGoruntuleyeHaberVer();
                            MessageBox.Show("Hesap silindi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                            MessageBox.Show("Hesap silinirken bir hata oluştu.", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (silinecek_Kkh != null)
                    {
                        vt.Kkart_Hesaplari.Remove(silinecek_Kkh);
                        if (vt.SaveChanges() > 0)
                        {
                            cmb_SilinecekHesap.DataSource = HesapListesi();
                            HesapGoruntuleyeHaberVer();
                            MessageBox.Show("Hesap silindi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                            MessageBox.Show("Hesap silinirken bir hata oluştu.", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else MessageBox.Show("Hesap bulunamadı!", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } //musteri null ise
            else MessageBox.Show("Geçerli bir Müşteri Numarası girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
