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
        Musteriler musteri;
        public frm_HesapOlustur()
        {
            InitializeComponent();
            rb_Kredi.Checked = true;
        }

        private void btn_olustur_Click(object sender, EventArgs e)
        {
            if (musteri != null)
            {
                using (BankDbEntities vt = new BankDbEntities())
                {
                    if (rb_Banka.Checked)
                    {
                        Banka_Hesaplari bh = HesapIslemleri.BankaHesabiOlustur(musteri.m_TcNo, vt);
                        vt.Banka_Hesaplari.Add(bh);
                        int sonuc = vt.SaveChanges();
                        if (sonuc > 0) MessageBox.Show("Banka hesabı başarıyla oluşturuldu!");
                    }
                    else
                    {
                        if (FormYonetimi.FormlariBul("frm_KkartConfig", out List<Form> KkartConfigs))
                        {
                            MessageBox.Show("Hali hazırda devam eden bir işleminiz var. ",
                                    "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            KkartConfigs[0].Activate();
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
            else
            {
                MessageBox.Show("Geçerli bir müşteri numarası girip Enter(Giriş) tuşuna bastığınızdan emin olun.",
                    "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txt_MusteriNo_TextChanged(object sender, EventArgs e)
        {
            lbl_Enter.Visible = string.IsNullOrEmpty(txt_MusteriNo.Text) ? false : true;
            AlanlariTemizle();
        }

        private void txt_MusteriNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(13))
            {
                using (BankDbEntities vt = new BankDbEntities())
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
                        AlanlariTemizle();
                        MessageBox.Show("Bu numaraya sahip bir müşteri bulunamadı.", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void AlanlariTemizle()
        {
            txt_Ad.Text = string.Empty;
            txt_Soyad.Text = string.Empty;
            dtp_DogumTarihi.Value = DateTime.Now;
            txt_DogumYeri.Text = string.Empty;
        }
    }
}
