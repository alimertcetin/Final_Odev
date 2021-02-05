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
            if (ParaCekilecek)
            {
                this.Text = "Para Çek";
                btn_Onayla.Text = "Çek";
            }
            else
            {
                this.Text = "Para Yatır";
                btn_Onayla.Text = "Yatır";
            }
        }

        private void HesapGoruntule_GridYenile()
        {
            if (FormYonetimi.FormlariBul("frm_HesapGoruntule", out List<Form> HesapGoruntuleFormlari))
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
            if (HesapIslemleri.HesabaParaYatir(vt, Convert.ToInt32(cmb_Miktar.SelectedItem), txt_HesapNo.Text, ParaYatirmaAciklamasi, 7, out string Mesaj))
            {
                HesapGoruntule_GridYenile();
                MessageBox.Show(Mesaj);
            }
            else MessageBox.Show(Mesaj, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        const string ParaCekmeAciklamasi = "Banka görevlisi aracılığıyla çekilen para";
        private void ParaCek()
        {
            BankDbEntities vt = new BankDbEntities();
            if(HesapIslemleri.hesaptanParaCek(vt, Convert.ToInt32(cmb_Miktar.SelectedItem), txt_HesapNo.Text, ParaCekmeAciklamasi, 7, out string Mesaj))
            {
                MessageBox.Show(Mesaj);
                HesapGoruntule_GridYenile();
            }
            else
                MessageBox.Show(Mesaj, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        
    }
}
