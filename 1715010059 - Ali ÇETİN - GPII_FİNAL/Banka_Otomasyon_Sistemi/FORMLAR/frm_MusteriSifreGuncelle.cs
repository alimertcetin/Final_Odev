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
    public partial class frm_MusteriSifreGuncelle : Form
    {
        public frm_MusteriSifreGuncelle(string musteriNo)
        {
            InitializeComponent();
            
            lbl_MusteriNo.Text = musteriNo;
        }

        private void btn_Geri_Click(object sender, EventArgs e) => Close();

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            BankDbEntities vt = new BankDbEntities();
            if (!KisiIslemleri.MusteriVeritabanindaVarMi(vt, lbl_MusteriNo.Text, out Musteriler musteri))
                MessageBox.Show("Bu numaraya sahip bir müşteri bulunamadı!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            else if (string.IsNullOrEmpty(txt_YeniSifre.Text) || string.IsNullOrEmpty(txt_YeniSifreTekrar.Text))
                MessageBox.Show("Yeni şifre ve şifre tekrar alanları boş bırakılamaz!",
                    "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            else if (txt_YeniSifre.Text != txt_YeniSifreTekrar.Text)
                MessageBox.Show("Yeni şifre ve şifre tekrar alanları birbiriyle uyuşmuyor!",
                    "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            else if (txt_MevcutSifre.Text != musteri.m_Sifre)
                MessageBox.Show("Mevcut Şifre Geçersiz!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                musteri.m_Sifre = txt_YeniSifre.Text;
                if (vt.SaveChanges() > 0)
                    MessageBox.Show("Şifre başarıyla değiştirildi.");
                else
                    MessageBox.Show("Şifre değiştirilirken bir sorun oluştu!",
                        "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txt_MevcutSifre.Text = string.Empty;
                txt_YeniSifre.Text = string.Empty;
                txt_YeniSifreTekrar.Text = string.Empty;
            }
        }
    }
}
