using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Banka_Otomasyon_Sistemi
{
    public partial class frm_ParaCekYatir : Form
    {
        bool ParaCekilecek;
        public frm_ParaCekYatir(string HesapNo,bool _ParaCekilecekMi)
        {
            InitializeComponent();

            txt_HesapNo.Text = HesapNo;
            cmb_Miktar.SelectedIndex = 0;
            ParaCekilecek = _ParaCekilecekMi;
            if (ParaCekilecek) btn_Onayla.Text = "Çek";
            else btn_Onayla.Text = "Yatır";
        }

        private void HesapGoruntule_GridYenile()
        {
            if (FormYonetimi.FormBul("frm_HesapGoruntule", out List<Form> HesapGoruntuleFormlari))
            {
                frm_HesapGoruntule hesapGoruntule = (frm_HesapGoruntule)HesapGoruntuleFormlari.ElementAt(0);
                hesapGoruntule.GridYenile();
            }
        }

        private void btn_iptalEt_Click(object sender, EventArgs e) => this.Close();

        private void btn_Onayla_Click(object sender, EventArgs e)
        {
            if (ParaCekilecek) ParaCek();
            else ParaYatir();
        }

        const string ParaYatirmaAciklamasi = "Banka görevlisi aracılığıyla yatırılan para";
        private void ParaYatir()
        {
            BankDbEntities vt = new BankDbEntities();
            var yatirilacakMiktar = Convert.ToInt32(cmb_Miktar.SelectedItem);
            var Bh = vt.Banka_Hesaplari.FirstOrDefault(p => p.BankaHesapNo == txt_HesapNo.Text);

            if (Bh != null)
            {
                var log = LogIslemleri.BankHesapLogOlustur(Bh.BankaHesapNo, yatirilacakMiktar, ParaYatirmaAciklamasi, 7);
                vt.islemler_BankaHesaplari.Add(log);

                Bh.Hesap_Bakiye += yatirilacakMiktar;
                if (vt.SaveChanges() > 0)
                {
                    HesapGoruntule_GridYenile();
                    MessageBox.Show("Para Yatırma işlemi Başarılı!");
                }
                else MessageBox.Show("İşlemi gerçekleştirirken bir hata oluştu!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var Kkh = vt.Kkart_Hesaplari.FirstOrDefault(p => p.KkartHesapNo == txt_HesapNo.Text);

                if (Kkh != null && Kkh.Kkart_Borc != null)
                {
                    if (Kkh.Kkart_Borc - yatirilacakMiktar >= 0)
                    {
                        var log = LogIslemleri.KrediHesapLogOlustur(Kkh.KkartHesapNo, yatirilacakMiktar, ParaYatirmaAciklamasi, 7);
                        vt.islemler_KrediHesaplari.Add(log);
                        Kkh.Kkart_Borc -= yatirilacakMiktar;

                        if (vt.SaveChanges() > 0)
                        {
                            HesapGoruntule_GridYenile();
                            MessageBox.Show("Para Yatırma işlemi Başarılı!");
                        }
                        else MessageBox.Show("İşlemi gerçekleştirirken bir hata oluştu!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if(Kkh.Kkart_Borc - yatirilacakMiktar < 0) //Yatırılmak istenen para borçtan fazla ise
                    {
                        decimal borc = Convert.ToDecimal(Kkh.Kkart_Borc);
                        decimal fazlaPara = yatirilacakMiktar - borc;

                        var log = LogIslemleri.KrediHesapLogOlustur(Kkh.KkartHesapNo, borc, ParaYatirmaAciklamasi, 7);
                        vt.islemler_KrediHesaplari.Add(log);
                        Kkh.Kkart_Borc = 0;

                        if (vt.SaveChanges() > 0)
                        {
                            HesapGoruntule_GridYenile();
                            MessageBox.Show("Para Yatırma işlemi Başarılı!");
                            MessageBox.Show("Hesaptaki borçtan fazla para yatırıldığı için " +
                                fazlaPara + "TL geri iade edilecek.");
                        }
                        else MessageBox.Show("İşlemi gerçekleştirirken bir hata oluştu!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else MessageBox.Show("Hesap Bulunamadı!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        const string ParaCekmeAciklamasi = "Banka görevlisi aracılığıyla çekilen para";
        private void ParaCek()
        {
            BankDbEntities vt = new BankDbEntities();
            var cekilecekMiktar = Convert.ToInt32(cmb_Miktar.SelectedItem);
            var Bh = vt.Banka_Hesaplari.FirstOrDefault(p => p.BankaHesapNo == txt_HesapNo.Text);

            if (Bh != null)
            {
                if (Bh.Hesap_Bakiye - cekilecekMiktar >= 0)
                {
                    var log = LogIslemleri.BankHesapLogOlustur(Bh.BankaHesapNo, -cekilecekMiktar, ParaCekmeAciklamasi, 7);
                    vt.islemler_BankaHesaplari.Add(log);
                    Bh.Hesap_Bakiye -= cekilecekMiktar;

                    if (vt.SaveChanges() > 0)
                    {
                        HesapGoruntule_GridYenile();
                        MessageBox.Show("Para Çekme işlemi Başarılı!");
                    }
                    else MessageBox.Show("İşlemi gerçekleştirirken bir hata oluştu!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else MessageBox.Show($"Yetersiz Bakiye!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var Kkh = vt.Kkart_Hesaplari.FirstOrDefault(p => p.KkartHesapNo == txt_HesapNo.Text);
                if (Kkh != null)
                {
                    if (Kkh.Kkart_Borc + cekilecekMiktar <= Kkh.Kkart_Limit)
                    {
                        var log = LogIslemleri.KrediHesapLogOlustur(Kkh.KkartHesapNo, -cekilecekMiktar, ParaCekmeAciklamasi, 7);
                        vt.islemler_KrediHesaplari.Add(log);
                        Kkh.Kkart_Borc += cekilecekMiktar;

                        if (vt.SaveChanges() > 0)
                        {
                            HesapGoruntule_GridYenile();
                            MessageBox.Show("Para Çekme işlemi Başarılı!");
                        }
                        else MessageBox.Show("İşlemi gerçekleştirirken bir hata oluştu!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else MessageBox.Show($"Yetersiz Bakiye!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else MessageBox.Show("Hesap Bulunamadı!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
