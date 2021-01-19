using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Banka_Otomasyon_Sistemi
{
    public partial class frm_AnaSayfa : Form
    {
        Musteriler Musteri;
        Calisanlar Calisan;
        bool CikisTiklandi;
        public frm_AnaSayfa(Calisanlar calisan)
        {
            InitializeComponent();
            this.FormClosed += onClose;
            MessageBox.Show("Hoşgeldin " + calisan.c_Ad, "HOŞGELDİNİZ", MessageBoxButtons.OK);
            Calisan = calisan;

            menu_GiseGorevlisi.Hide();
            menu_Yonetici.Hide();
            menu_musteri.Hide();

            switch (calisan.c_Rolid)
            {
                case 1:
                    menu_Yonetici.Show();
                    menu_GiseGorevlisi.Show();
                    break;
                case 3:
                    menu_GiseGorevlisi.Show();
                    break;
            }
        }

        public frm_AnaSayfa(Musteriler musteri)
        {
            InitializeComponent();


            Musteri = musteri;
            menu_GiseGorevlisi.Hide();
            menu_Yonetici.Hide();

            this.FormClosed += onClose;
            MessageBox.Show("Hoşgeldin " + musteri.m_Ad, "HOŞGELDİNİZ", MessageBoxButtons.OK);

            menu_musteri.Show();
        }

        private void onClose(object sender, FormClosedEventArgs e)
        {
            if (!CikisTiklandi)
                Application.Exit();
        }

        private void yeniBankaHesabıOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_GecisHesapOlustur frm_GecisHesap = new frm_GecisHesapOlustur();
            frm_GecisHesap.MdiParent = this;
            frm_GecisHesap.Show();
        }

        private void hesapSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FormYonetimi.FormBul("frm_HesapSil", out List<Form> hesapSilFormlari))
            {
                hesapSilFormlari.ElementAt(0).Activate();
                return;
            }
            else
            {
                frm_HesapSil hesapSil = new frm_HesapSil();
                hesapSil.MdiParent = this;
                hesapSil.Show();
            }
        }
        
        private void calisan_BankHesapGoruntule_Click(object sender, EventArgs e)
        {
            frm_HesapGoruntule bankHesap = new frm_HesapGoruntule(Calisan);
            bankHesap.MdiParent = this;
            bankHesap.Show();
        }

        //müşteri
        private void musteri_hesaplarımıGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_HesapGoruntule bankHesap = new frm_HesapGoruntule(Musteri);
            bankHesap.MdiParent = this;
            bankHesap.Show();
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            CikisTiklandi = true;
            FormYonetimi.GirisEkraninaDon();
        }
    }
}
