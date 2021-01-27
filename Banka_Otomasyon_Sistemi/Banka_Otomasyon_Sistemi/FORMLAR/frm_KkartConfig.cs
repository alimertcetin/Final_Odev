using System;
using System.Windows.Forms;

namespace Banka_Otomasyon_Sistemi
{
    public partial class frm_KkartConfig : Form
    {
        Musteriler musteri;
        BankDbEntities vt;
        bool KisiKayitEdilecek;
        public frm_KkartConfig(BankDbEntities _vt, Musteriler _musteri,bool KisiyiKaydet) //musterinin kontrolleri yapıldı. Kayıt edilmeye hazır.
        {
            InitializeComponent();

            KisiKayitEdilecek = KisiyiKaydet;
            vt = _vt;
            musteri = _musteri;

            cmb_Limit.SelectedIndex = 0;
            cmb_HesapKesim.SelectedIndex = 0;
            cmb_SonOdeme.SelectedIndex = 0;
        }

        private void btn_Onayla_Click(object sender, EventArgs e)
        {
            var limit = Convert.ToDecimal(cmb_Limit.SelectedItem);
            var hesapKesim = Convert.ToInt32(cmb_HesapKesim.SelectedItem);
            var sonOdeme = Convert.ToInt32(cmb_SonOdeme.SelectedItem);

            Kkart_Hesaplari kh = HesapIslemleri.KkartHesabiOlustur(musteri.m_TcNo, vt, limit, hesapKesim, sonOdeme);
            if (KisiKayitEdilecek)
                vt.Musteriler.Add(musteri);

            vt.Kkart_Hesaplari.Add(kh);
            var savedChanges = vt.SaveChanges();
            if (savedChanges > 0)
                MessageBox.Show("İşlem başarıyla tamamlandı. ", "Tebrikler!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Bir sorun oluştu.", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}