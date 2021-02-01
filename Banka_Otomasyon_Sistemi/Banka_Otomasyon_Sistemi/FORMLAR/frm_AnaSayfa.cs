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


            this.Musteri = musteri;
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
            FormYonetimi.TekliFormOlustur(typeof(frm_GecisHesapOlustur));
        }

        private void hesapSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormYonetimi.TekliFormOlustur(typeof(frm_HesapSil));
        }
        
        private void calisan_BankHesapGoruntule_Click(object sender, EventArgs e)
        {
            if (!FormYonetimi.CloseAllInstance(nameof(frm_HesapGoruntule)))
            {
                frm_HesapGoruntule bankHesap = new frm_HesapGoruntule(Calisan);
                bankHesap.MdiParent = this;
                bankHesap.Show();
            }
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e) => AnasayfadakiCikisTiklandi();
        private void toolStripMenuItem2_Click(object sender, EventArgs e) => AnasayfadakiCikisTiklandi();

        private void AnasayfadakiCikisTiklandi()
        {
            if (MessageBox.Show("Çıkış yapmak istediğinizden emin misiniz?", "Uyarı",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                CikisTiklandi = true;
                FormYonetimi.GirisEkraninaDon();
            }
        }

        //müşteri
        private void musteri_hesaplarımıGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!FormYonetimi.CloseAllInstance(nameof(frm_HesapGoruntule)))
            {
                frm_HesapGoruntule bankHesap = new frm_HesapGoruntule(Musteri);
                bankHesap.MdiParent = this;
                bankHesap.Show();
            }
        }

        private void müşteriBilgileriniGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormYonetimi.TekliFormOlustur(typeof(frm_MusteriBilgileriniGoruntuleDuzenle));
        }

        private void müşteriyiBilgisiniSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormYonetimi.TekliFormOlustur(typeof(frm_MusteriNoOgren));
        }

        private void çalışanlarıGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormYonetimi.TekliFormOlustur(typeof(frm_CalisanlariGoruntule));
        }

        private void şifreDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!FormYonetimi.CloseAllInstance(nameof(frm_MusteriSifreGuncelle)))
            {
                frm_MusteriSifreGuncelle form = new frm_MusteriSifreGuncelle(Musteri.MusteriNo);
                form.MdiParent = this;
                form.Show();
            }
        }

        private void ödemeYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!FormYonetimi.CloseAllInstance(nameof(frm_OdemeYap)))
            {
                frm_OdemeYap form = new frm_OdemeYap(Musteri);
                form.MdiParent = this;
                form.Show();
            }
        }


        private void müsteriSifresiniGuncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
