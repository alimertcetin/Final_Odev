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
            //foreach (Form itm in Application.OpenForms)
            //{
            //    if (item.Name == "frm_HesapGoruntule")
            //    {
            //        frm_HesapGoruntule hesapGoruntule = (frm_HesapGoruntule)item;
            //        hesapGoruntule.GridYenile();
            //    }
            //}
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

        private void ParaYatir()
        {
            BankDbEntities vt = new BankDbEntities();
            var yatirilacakMiktar = Convert.ToInt32(cmb_Miktar.SelectedItem);
            var Bh = vt.Banka_Hesaplari.FirstOrDefault(p => p.BankaHesapNo == txt_HesapNo.Text);
            if (Bh != null)
            {
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
                        Kkh.Kkart_Borc -= yatirilacakMiktar;
                        if (vt.SaveChanges() > 0)
                        {
                            HesapGoruntule_GridYenile();
                            MessageBox.Show("Para Yatırma işlemi Başarılı!");
                        }
                        else MessageBox.Show("İşlemi gerçekleştirirken bir hata oluştu!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if(Kkh.Kkart_Borc - yatirilacakMiktar < 0)
                    {
                        int borc = Convert.ToInt32(Kkh.Kkart_Borc);
                        while(borc > 0)
                        {
                            if (borc == 0) break;
                            borc -= 1;
                        }
                        Kkh.Kkart_Borc = Convert.ToDecimal(borc);
                        if (vt.SaveChanges() > 0)
                        {
                            HesapGoruntule_GridYenile();
                            MessageBox.Show("Para Yatırma işlemi Başarılı!");
                        }
                        else MessageBox.Show("İşlemi gerçekleştirirken bir hata oluştu!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else MessageBox.Show("Hesap Bulunamadı!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ParaCek()
        {
            BankDbEntities vt = new BankDbEntities();
            var cekilecekMiktar = Convert.ToInt32(cmb_Miktar.SelectedItem);
            var Bh = vt.Banka_Hesaplari.FirstOrDefault(p => p.BankaHesapNo == txt_HesapNo.Text);
            if (Bh != null)
            {
                if (Bh.Hesap_Bakiye - cekilecekMiktar >= 0)
                {
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
