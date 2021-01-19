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
    public partial class frm_HesapOlustur : Form
    {
        BankDbEntities vt = new BankDbEntities();
        Musteriler musteri;
        public frm_HesapOlustur()
        {
            InitializeComponent();
        }

        private void txt_MusteriNo_TextChanged(object sender, EventArgs e)
        {
            musteri = vt.Musteriler.FirstOrDefault(p => p.MusteriNo == txt_MusteriNo.Text);
            if (musteri != null)
            {
                txt_Ad.Text = musteri.m_Ad;
                txt_Soyad.Text = musteri.m_Soyad;
                dtp_DogumTarihi.Value = musteri.m_DogumTarihi;
                txt_DogumYeri.Text = musteri.m_DogumYeri;
            }
            else
            {
                txt_Ad.Text = string.Empty;
                txt_Soyad.Text = string.Empty;
                dtp_DogumTarihi.Value = DateTime.Now;
                txt_DogumYeri.Text = string.Empty;
            }
        }

        private void btn_olustur_Click(object sender, EventArgs e)
        {
            if(musteri.m_Sifre != txt_Sifre.Text)
                MessageBox.Show("Şifre yanlış.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (musteri != null)
            {
                if (rb_Banka.Checked)
                {
                    Banka_Hesaplari bh = HesapIslemleri.BankaHesabiOlustur(musteri.m_TcNo, vt);
                    vt.Banka_Hesaplari.Add(bh);
                    int sonuc = vt.SaveChanges();
                    if (sonuc > 0) MessageBox.Show("Hesap başarıyla oluşturuldu!");
                }
                else
                {
                    if (FormYonetimi.FormBul("frm_KkartConfig", out List<Form> KkartConfigs))
                    {
                        MessageBox.Show("Zaten şu anda devam eden bir işleminiz var. " +
                                "Önce devam eden kredi hesabı oluşturma işlemini sonlandırın.",
                                "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        KkartConfigs.ElementAt(0).Activate();
                        return;
                    }
                    else
                    {
                        frm_KkartConfig frm_Kkart = new frm_KkartConfig(vt, musteri, false);
                        frm_Kkart.MdiParent = this.MdiParent;
                        frm_Kkart.Show();
                    }
                }
            }
        }
    }
}
