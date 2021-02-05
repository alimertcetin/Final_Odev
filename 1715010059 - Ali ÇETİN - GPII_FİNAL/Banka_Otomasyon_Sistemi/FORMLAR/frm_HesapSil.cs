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
            if(FormYonetimi.FormlariBul("frm_HesapGoruntule",out List<Form> HesapGoruntuleFormlari))
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
            lbl_Enter.Visible = string.IsNullOrEmpty(txt_MusteriNo.Text) ? false : true;
            FormuTemizle();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (musteri == null)
                MessageBox.Show("Geçerli bir Müşteri Numarası girin ve Giriş(Enter) tuşuna basın.",
                    "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                HesabiSil();
        }

        private void HesabiSil()
        {
            if(cmb_SilinecekHesap.Items.Count <=0)
            {
                MessageBox.Show("Hesap bulunamadı!", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Bu hesabı silmek istediğinize emin misiniz? " +
              "Hesap kalıcı olarak silinecektir.", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Error)
              == DialogResult.No)
                return;
            else
            {
                string hesapNo = cmb_SilinecekHesap.SelectedItem.ToString();
                Banka_Hesaplari silinecek_Bh = vt.Banka_Hesaplari.FirstOrDefault(p => p.BankaHesapNo == hesapNo);
                Kkart_Hesaplari silinecek_Kkh = vt.Kkart_Hesaplari.FirstOrDefault(p => p.KkartHesapNo == hesapNo);
                if (silinecek_Bh != null)
                {
                    LogIslemleri.BankHesap_TumLoglariSil(vt, silinecek_Bh);
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
                    LogIslemleri.KkartHesap_TumLoglariSil(vt, silinecek_Kkh);
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

        }

        private void txt_MusteriNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(13))
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
                    FormuTemizle();
                    MessageBox.Show("Müşteri bulunamadı.", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FormuTemizle()
        {
            txt_Ad.Text = string.Empty;
            txt_Soyad.Text = string.Empty;
            dtp_DogumTarihi.Value = DateTime.Now;
            cmb_SilinecekHesap.DataSource = null;
        }
    }
}
